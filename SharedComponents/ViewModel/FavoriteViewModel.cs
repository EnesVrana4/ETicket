using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.ViewModel
{
    public class FavoriteBaseViewModel
    {
        //public int EventId { get; set; }
    }

    public class FavoriteViewModel : FavoriteBaseViewModel
    {
        public int FavoriteId { get; set; }
    }

    public class FavoriteEditViewModel : FavoriteBaseViewModel
    {
    }
}
