﻿using System.ComponentModel.DataAnnotations;

namespace webanthuc.Entity
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string MapData { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Phone]
        public string Phone { get; set; }   
    }
}
