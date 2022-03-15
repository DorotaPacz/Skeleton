using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool IsFulfilled { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
        public int ID { get; set; }
    }
}