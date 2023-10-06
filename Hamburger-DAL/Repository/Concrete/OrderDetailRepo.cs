using Hamburger_DAL.Context;
using Hamburger_DAL.Repository.Interfaces;
using Hamburger_DATA.Concrete;
using Hamburger_DATA.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DAL.Repository.Concrete
{
    public class OrderDetailRepo : IOrderDetailRepo
    {
        private readonly AppDbContext _context;

        public OrderDetailRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Add(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public IEnumerable GetAllMenus()
        {
            var list = _context.OrderDetails.Join(
                _context.Menus,
                order => order.MenuId,
                menu => menu.Id,
                (o, m) => new
                {
                    m.Id,
                    m.MenuName,
                    m.MenuPrice,
                    m.Size,
                    m.Status
                }
                ).Where(o => o.Status != Status.Passive).ToList();
            return list;
        }

        public IEnumerable GetAllOrders()
        {
            var list = _context.OrderDetails.Join(
                _context.Orders,
                orderD => orderD.OrderId,
                order => order.Id,
                (od, o) => new
                {
                    od.Discount,
                    od.Quantity,
                    o.Customer,
                    o.Status
                }
                ).Where(o => o.Status != Status.Passive).ToList();
            return list;
        }

        public IEnumerable GetAllSouces()
        {
            var list = _context.OrderDetails.Join(
                _context.Sauces,
                orderD => orderD.SaucesId,
                souce => souce.Id,
                (od, s) => new
                {
                    s.SauceName,
                    s.SaucePrice,
                    s.Status
                }
                ).Where(o => o.Status != Status.Passive).ToList();
            return list;
        }
        public void Update(OrderDetail orderDetail)
        {
            _context.Update(orderDetail);
            _context.SaveChanges();
        }
    }
}
