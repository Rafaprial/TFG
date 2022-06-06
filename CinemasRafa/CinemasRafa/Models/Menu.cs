using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public class Menu
    {
        public int ID { get; set; }

        public string Action { get; set; }

        public string Label { get; set; }

        public string Controller { get; set; }


        [InverseProperty("Menu")]
        public List<RoleHasMenu> RoleHasMenus { get; set; }
    }
}
