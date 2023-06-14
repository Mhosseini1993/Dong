using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModel
{
  public  class TransActionViewModel
    {
        public int ID { get; set; }
        public Nullable<int> GoodsID { get; set; }
        public string FullName { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string SharePersons { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public Nullable<bool> IsCheckOut { get; set; }
    }
}
