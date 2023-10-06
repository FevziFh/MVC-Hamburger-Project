using AutoMapper;
using Hamburger_DAL.Repository.Interfaces;
using Hamburger_DATA.Concrete;
using Hamburger_Service.DTOs;
using Hamburger_Service.SouceService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.MenuService
{
    public class MenuService
    {
        private readonly IBaseRepo<Menu> _repo;
        private readonly IMapper _mapper;
        //private readonly IBaseRepo<Sauce> _sauceRepo;

        public MenuService(IBaseRepo<Menu> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IList<MenuUpdateDTO> GetMenus()
        {
            IList<Menu> menus = _repo.GetAll().ToList();
            IList<MenuUpdateDTO> menuDTOList = _mapper.Map<IList<Menu>, IList<MenuUpdateDTO>>(menus);
            return menuDTOList;
        }
        public MenuUpdateDTO GetMenuById(int id) 
        {
            Menu menu = _repo.GetById(id);
            MenuUpdateDTO menuDTO = _mapper.Map<MenuUpdateDTO>(menu);
            return menuDTO;
        }
        public void MenuAdd(MenuCreateDTO menuDTO)
        {
            Menu menu = _mapper.Map<Menu>(menuDTO);
            _repo.Add(menu);
        }
        public void MenuRemove(int id)
        {
            _repo.Delete(id);
        }
        public void MenuUpdate(MenuUpdateDTO menuDTO)
        {
            Menu menu = _mapper.Map<Menu>(menuDTO);
            _repo.Update(menu);
        }
        //public IEnumerable MenuSouce(int menuId)
        //{
        //    var souce = _repo.GetFilteredList(
        //        select: x => new MenuSauceDTO
        //        {
        //            MenuName = x.MenuName,
        //            MenuId = x.Id,
        //            Price = x.MenuPrice,
        //            Sauces = x.OrderDetails.Join(x => x.Sauces,
        //                x => x.SaucesId,
        //            )
        //        },
        //        join: x => x.Include(a => a.OrderDetails).ThenInclude(c => c.Menu),
        //        where: null,
        //        orderBy: null
        //        );

        //}
    }
}
