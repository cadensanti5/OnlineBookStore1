using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Books> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
