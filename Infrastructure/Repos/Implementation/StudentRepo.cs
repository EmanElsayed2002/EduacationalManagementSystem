using DATA.Models;
using Infrastructure.Context;
using Infrastructure.Repos.abstracts;

namespace Infrastructure.Repos.Implementation
{
    public class StudentRepo : GenericRepo<Student>, IStudentRepo
    {
        private readonly AppDbContext _context;
        public StudentRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
