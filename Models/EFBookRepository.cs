using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        private ProjectDbContext _context;

        //contstructor
        public EFBookRepository (ProjectDbContext context)
        {
            _context = context;
        }

        public IQueryable<Books> Books => _context.Books;
    }
}
