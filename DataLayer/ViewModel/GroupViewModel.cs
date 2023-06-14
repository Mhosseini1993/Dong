using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModel
{
    public class GroupViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string CreateDate { get; set; }
        public Nullable<int> Count { get; set; }

    }
}
