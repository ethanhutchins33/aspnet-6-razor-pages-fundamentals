﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WiredBrainCoffeeAdmin.Data.Models;

public class Product
{
    public int Id { get; set; }

    [Required] public string? Name { get; set; }

    [Required]
    [MinLength(20, ErrorMessage = "The description should be at least 20 characters with meaningful content")]
    public string? Description { get; set; }

    [Required] [MaxLength(30)] public string? ShortDescription { get; set; }

    [Required] public decimal Price { get; set; }

    public string? ImageFile { get; set; }

    [Required] public DateTime Created { get; set; }

    [Required] public string? Category { get; set; }

    [NotMapped] public IFormFile? Upload { get; set; }
}
