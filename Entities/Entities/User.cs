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
        public string Mail { get; set; }
        public DateTime?  Birthdate { get; set; }
        public DateTime?  CreateDate { get; set; }

        public Role Role { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
        public UserDetail userDetail { get; set; }
    }
}
