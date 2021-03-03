using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    //interface template (not a class), meant to be inherited...to help us contrl what's in the class
    public interface IBookRepository
    {
        IQueryable<Books> Books { get; }

        //IQueryable = getting data out of memory; generally drawing from an outside database to get data
        //IEnumerable = grabbing things that are stored/exists within the program. Read-only. 
    }
}
