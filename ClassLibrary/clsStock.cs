using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Available { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockItemNo { get; set; }
        public string StockItemDescription { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}