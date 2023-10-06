using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.DTOs
{
    public class OrderCreateDTO
    {
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public int SaucesId { get; set; }
    }
}
