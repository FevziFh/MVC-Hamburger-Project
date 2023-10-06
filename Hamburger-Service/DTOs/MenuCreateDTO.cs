using Hamburger_DATA.Concrete;
using Hamburger_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.DTOs
{
    public class MenuCreateDTO
    {
        //public int Id { get; set; }
        public string MenuName { get; set; }
        public double MenuPrice { get; set; }
        public Size Size { get; set; }
        //public virtual IList<OrderDetail> OrderDetails { get; set; }
    }
}
