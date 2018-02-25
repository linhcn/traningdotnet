using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class OrderDetail
    {
        [Display(Name = "Id detail")]
        [Key]
        public int OrderDetailID { get; set; }

        [Display(Name = "Id bill")]
        public int BillOrderRefId { get; set; }

        [Display(Name = "Id book")]
        public int BookRefId { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public OrderDetail()
        {

        }
        public OrderDetail(int billID, int bookID, int quantity)
        {
            BillOrderRefId = billID;
            BookRefId = bookID;
            Quantity = quantity;
        }

        [ForeignKey("BillOrderRefId")]
        public virtual BillOrder BillOrder { get; set; }

        [ForeignKey("BookRefId")]
        public virtual Book Book { get; set; }

    }
}