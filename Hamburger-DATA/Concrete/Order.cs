using Hamburger_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DATA.Concrete
{
    public class Order : BaseEntity
    {
        public virtual Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public virtual IList<OrderDetail> OrderDetails { get; set; }
    }
}
