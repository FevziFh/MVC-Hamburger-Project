using Hamburger_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DATA.Concrete
{
    public class Sauce : BaseEntity
    {
        public string SauceName { get; set; }
        public double SaucePrice { get; set; }
        public virtual IList<OrderDetail> OrderDetails { get; set; }
    }
}
