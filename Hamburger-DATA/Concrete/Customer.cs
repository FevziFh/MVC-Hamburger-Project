using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_DATA.Concrete
{
    public class Customer : IdentityUser
    {
        public virtual IList<Order> Orders { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
