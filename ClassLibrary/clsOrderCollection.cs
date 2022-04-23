using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public List<clsOrder> OrderList { get; set; }
        public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
    }
}