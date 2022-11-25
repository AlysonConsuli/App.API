﻿using System.ComponentModel.DataAnnotations.Schema;

namespace App.API.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Side { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
