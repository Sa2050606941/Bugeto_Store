using Bugeto_store.Domain.Entities.Commons;
using Bugeto_store.Domain.Entities.Users;
using Bugeto_Store.Domain.Entities.Finances;
using Bugeto_Store.Domain.Entities.Products;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bugeto_Store.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {

        public virtual User User { get; set; }
        public long UserId { get; set; }

        public virtual RequestPay RequestPay { get; set; }
        public long RequestPayId { get; set; }

        public OrderState OrderState { get; set; }

        public string Address { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail:BaseEntity
    {
        public virtual Order Order { get; set; }
        public long OrderId { get; set; }

        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

        public int Price { get; set; }
        public int Count { get; set; }
    }


    public enum OrderState
    {
        [Display(Name = "در حالی پردازش")]
        Processing = 0,
        [Display(Name = "لغو شده")]
        Canceled = 1,
        [Display(Name = "تحویل شده")]
        Delivered = 2,
    }

}
