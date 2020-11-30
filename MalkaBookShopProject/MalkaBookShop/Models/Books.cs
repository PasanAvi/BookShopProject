using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalkaBookShop.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string RackNumber { get; set; }
        public int Quantity { get; set; }
        public int YearOfPrinting { get; set; }
        public string ISBN { get; set; }
    }
}
