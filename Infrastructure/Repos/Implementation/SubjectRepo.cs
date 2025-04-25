using DATA.Models;
using Infrastructure.Context;
using Infrastructure.Repos.abstracts;

namespace Infrastructure.Repos.Implementation
{
    public class SubjectRepo : GenericRepo<Subject>, ISubjectRepo
    {
        private readonly AppDbContext _context;
        public SubjectRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
