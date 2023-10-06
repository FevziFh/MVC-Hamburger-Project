using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DATA.Concrete
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public int SaucesId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
        public virtual Sauce Sauce { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; } = 1;   

    }
}
