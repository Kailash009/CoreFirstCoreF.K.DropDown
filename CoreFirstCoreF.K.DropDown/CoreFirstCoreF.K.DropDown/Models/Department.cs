using System.ComponentModel.DataAnnotations;

namespace CoreFirstCoreF.K.DropDown.Models
{
    public class Department
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }
    }
}
