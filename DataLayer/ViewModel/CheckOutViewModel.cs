using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModel
{
    public class CheckOutViewModel
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public float totalPayed { get; set; }
        public float Dong { get; set; }
    }
}
