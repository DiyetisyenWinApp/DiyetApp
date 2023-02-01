using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        
        public int UserID { get; set; }
        
        public string UserName { get; set; }
        public string E_Mail { get; set; }

        public string Password { get; set; }
        public UserDetail UserDetail { get; set; }
       
    }
}
