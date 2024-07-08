using System.ComponentModel.DataAnnotations;

namespace CoreFirstCoreF.K.DropDown.Models
{
    public class City
    {
        [Key]
        public int city_id { get; set; }
        public string city_name { get; set; }
    }
}
