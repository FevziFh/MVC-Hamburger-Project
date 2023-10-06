using AutoMapper;
using Hamburger_DAL.Repository.Interfaces;
using Hamburger_DATA.Concrete;
using Hamburger_Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.SouceService
{
    public class SauceServis
    {
        private readonly IBaseRepo<Sauce> _repo;
        private readonly IMapper _mapper;

        public SauceServis(IBaseRepo<Sauce> repo, IMapper mapper = null)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public IList<SauceUpdateDTO> GetSauces()
        {
            IList<Sauce> sauces = _repo.GetAll().ToList();
            IList<SauceUpdateDTO> sauceDTOs = _mapper.Map<IList<Sauce>, IList<SauceUpdateDTO>>(sauces);
            return sauceDTOs;
        }
        public SauceUpdateDTO GetSauceById(int id)
        {
            Sauce sauce = _repo.GetById(id);
            SauceUpdateDTO sauceDTO = _mapper.Map<SauceUpdateDTO>(sauce);
            return sauceDTO;
        }
        public void SauceAdd(MenuCreateDTO sauceDTO)
        {
            Sauce sauce = _mapper.Map<Sauce>(sauceDTO);
            _repo.Add(sauce);
        }
        public void SauceRemove(int id)
        {
            _repo.Delete(id);
        }
        public void SauceUpdate(SauceUpdateDTO sauceDTO)
        {
            Sauce sauce= _mapper.Map<Sauce>(sauceDTO);
            _repo.Update(sauce);
        }
    }
}
