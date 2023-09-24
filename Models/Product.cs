using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace commerce.Models;

public partial class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int product_id { get; set; }

    public string? Title { get; set; }
    public string? Price { get; set; }
    public string? Details { get; set; }
    public string? ImageUrl { get; set; }
    public int Quantity { get; set; }

    [ForeignKey("category_id")]
    public int? CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
