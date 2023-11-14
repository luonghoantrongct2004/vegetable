using System;
using System.Collections.Generic;

#nullable disable

namespace Selling_Vegetable_26102023.Models
{
    public partial class Orderdetail
    {
        public int OrderdetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? OrderNumber { get; set; }
        public int? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Total { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Order Order { get; set; }
    }
}
