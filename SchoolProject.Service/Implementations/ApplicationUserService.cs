﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Data.Entities.Identity;
using SchoolProject.Infrustructure.Data;
using SchoolProject.Service.Abstracts;
using System.Net;

namespace SchoolProject.Service.Implementations
{
    public class ApplicationUserService : IApplicationUserService
    {
        #region Fields
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmailsService _emailsService;
        private readonly ApplicationDBContext _applicationDBContext;
        private readonly IUrlHelper _urlHelper;
        #endregion
        #region Constructors
        public ApplicationUserService(UserManager<User> userManager,
                                      IHttpContextAccessor httpContextAccessor,
                                      IEmailsService emailsService,
                                      ApplicationDBContext applicationDBContext,
                                      IUrlHelper urlHelper)
        {
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _emailsService = emailsService;
            _applicationDBContext = applicationDBContext;
            _urlHelper = urlHelper;
        }
        #endregion
        #region Handle Functions
        public async Task<string> AddUserAsync(User user, string password)
        {
            var trans = await _applicationDBContext.Database.BeginTransactionAsync();
            try
            {
                //if Email is Exist
                var existUser = await _userManager.FindByEmailAsync(user.Email);
                //email is Exist
                if (existUser != null) return "EmailIsExist";
                user.UserName = user.FullName;
                //if username is Exist
                var userByUserName = await _userManager.FindByNameAsync(user.UserName);
                //username is Exist
                if (userByUserName != null) return "UserNameIsExist";
                //Create
                var createResult = await _userManager.CreateAsync(user, password);
                //Failed
                if (!createResult.Succeeded)
                    return string.Join(",", createResult.Errors.Select(x => x.Description).ToList());

                await _userManager.AddToRoleAsync(user, "User");

                //Send Confirm Email
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var encodedCode = WebUtility.UrlEncode(code); // 🔐 تشفير الكود ليصبح URL-safe

                var request = _httpContextAccessor.HttpContext.Request;

                var returnUrl = request.Scheme + "://" + request.Host +
                                _urlHelper.Action("ConfirmEmail", "Authentication", new { userId = user.Id, code = encodedCode });

                var message = $"To Confirm Email Click Link: <a href='{returnUrl}'>Link Of Confirmation</a>";

                await _emailsService.SendEmail(user.Email, message, "Confirm Email");

                await trans.CommitAsync();
                return "Success";

            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
                return "Failed";
            }

        }
        #endregion
    }
}
