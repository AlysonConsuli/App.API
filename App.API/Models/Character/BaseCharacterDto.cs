using System.ComponentModel.DataAnnotations;

namespace App.API.Models.Character
{
    public abstract class BaseCharacterDto
    {
        [Required]
        public string Name { get; set; }
        public string Side { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
