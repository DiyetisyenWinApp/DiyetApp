using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class UserDetail
    {
        public int ID { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public Gender Gender { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }

    }
}
