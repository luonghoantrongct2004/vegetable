using System;
using System.Collections.Generic;

#nullable disable

namespace Selling_Vegetable_26102023.Models
{
    public partial class Product
    {
        public Product()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public int? StockQuantity { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? Active { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
