﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }
       
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
