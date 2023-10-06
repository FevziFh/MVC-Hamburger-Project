using Hamburger_DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.DTOs
{
    //Kullanmak nasip olmadı
    public class MenuSauceDTO
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public IList<SauceUpdateDTO> Sauces { get; set; }
        public double Price { get; set; }

    }
}
