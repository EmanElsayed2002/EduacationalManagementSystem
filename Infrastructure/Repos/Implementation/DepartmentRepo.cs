using DATA.Models;
using Infrastructure.Context;
using Infrastructure.Repos.abstracts;

namespace Infrastructure.Repos.Implementation
{
    public class DepartmentRepo : GenericRepo<Department>, IDepartmentRepo
    {
        private readonly AppDbContext _context;
        public DepartmentRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
