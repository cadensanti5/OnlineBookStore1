using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class EFBookRepository : IBookRepository
    {
        //creating a propert "context" of type "projectDbContext"
        private ProjectDbContext _context;

        //contstructor
        public EFBookRepository (ProjectDbContext context)
        {
            _context = context; //assigning parameter "context" to our private property "_context"
        }

        public IQueryable<Books> Books => _context.Books;
    }
}
