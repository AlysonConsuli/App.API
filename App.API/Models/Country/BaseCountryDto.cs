using System.ComponentModel.DataAnnotations;

namespace App.API.Models.Country
{
    public abstract class BaseCountryDto
    {
        [Required]
        public int Name { get; set; }
        public int ShortName { get; set; }
    }
}
