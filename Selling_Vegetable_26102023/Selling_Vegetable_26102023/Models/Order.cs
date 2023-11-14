using System;
using System.Collections.Generic;

#nullable disable

namespace Selling_Vegetable_26102023.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public bool? StaticOrder { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
