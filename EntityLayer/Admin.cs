using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [StringLength(50)]
        public String AdminUserName { get; set; }

        [StringLength(50)]
        public String Adminpassword { get; set; }

        [StringLength(1)]
        public String AdminRole { get; set; }
    }
}
