using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        
        public int UserID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string E_Mail { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public Role Role { get; set; } 
        public UserDetail UserDetail { get; set; }
       
    }
}
