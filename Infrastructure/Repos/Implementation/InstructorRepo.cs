using DATA.Models;
using Infrastructure.Context;
using Infrastructure.Repos.abstracts;

namespace Infrastructure.Repos.Implementation
{
    public class InstructorRepo : GenericRepo<Instructor>, IInstructorRepo
    {
        private readonly AppDbContext _context;
        public InstructorRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
