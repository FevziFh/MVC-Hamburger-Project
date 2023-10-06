using Hamburger_DATA.Abstract;
using Hamburger_DATA.Enums;


namespace Hamburger_DATA.Concrete
{
    public class Menu : BaseEntity
    {
        public string MenuName { get; set; }
        public double MenuPrice { get; set; }
        public Size Size { get; set; }
        public virtual IList<OrderDetail> OrderDetails { get; set; }
    }
}