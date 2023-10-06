using AutoMapper;
using Hamburger_DAL.Repository.Interfaces;
using Hamburger_DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.OrderService
{
    public class OrderService
    {
        private readonly IBaseRepo<Order> _repo;
        private readonly IOrderDetailRepo _detailRepo;
        private readonly IMapper _mapper;

        public OrderService(IBaseRepo<Order> repo, IMapper mapper = null, IOrderDetailRepo detailRepo = null)
        {
            _repo = repo;
            _mapper = mapper;
            _detailRepo = detailRepo;
        }
        public IList<Order> GetOrders()
        {
            return _repo.GetAll().ToList();
        }

    }
}
