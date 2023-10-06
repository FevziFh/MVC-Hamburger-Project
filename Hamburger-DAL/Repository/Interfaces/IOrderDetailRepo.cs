using Hamburger_DATA.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DAL.Repository.Interfaces
{
    public interface IOrderDetailRepo
    {
        public void Add(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public IEnumerable<OrderDetail> GetAll();
        public IEnumerable GetAllMenus();
        public IEnumerable GetAllSouces();
        public IEnumerable GetAllOrders();
    }
}
