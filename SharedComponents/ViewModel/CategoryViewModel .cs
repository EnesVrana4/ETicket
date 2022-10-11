using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.ViewModel
{

    public class CategoryBaseViewModel
    {
        public string Name { get; set; }
        public string NumOfTickets { get; set; }
     
    }

    public class CategoryViewModel : CategoryBaseViewModel
    {
        public int CategoryId { get; set; }
    }

    public class CategoryEditViewModel : CategoryBaseViewModel
    {
    }
}