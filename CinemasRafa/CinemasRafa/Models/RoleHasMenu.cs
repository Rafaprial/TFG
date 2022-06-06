using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public class RoleHasMenu
    {
        public int ID { get; set; }

        public int MenuID { get; set; }

        [ForeignKey("MenuID")]
        public Menu Menu { get; set; }

        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }
    }
}
