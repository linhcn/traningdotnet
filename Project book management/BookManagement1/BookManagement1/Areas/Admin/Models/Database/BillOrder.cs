using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class BillOrder
    {
        [Key]
        [Display(Name = "Id bill")]
        public int BillOrderID { get; set; }

        [Required]
        [Display(Name = "Cus ref id")]
        public int CustormerRefId { get; set; }

        [Display(Name = "Ship date")]
        [DataType(DataType.Date)]
        public DateTime Shipdate { get; set; }
        
        [Required]
        [Display(Name = "Order date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [Display(Name = "Pay Date")]
        [DataType(DataType.Date)]
        public DateTime PayDay { get; set; }

        [Display(Name = "Money total")]
        public double BillOrderMoneyTotal { get; set; }

        [Display(Name="Paid Status")]
        public Boolean PaidStatus { get; set; }

        public BillOrder()
        {

        }
        public BillOrder(int cusID, DateTime shipDate, DateTime orderDate, DateTime payDay, double billMoneyTotal, Boolean paidStatus)
        {
            CustormerRefId = cusID;
            Shipdate = shipDate;
            OrderDate = orderDate;
            PayDay = payDay;
            BillOrderMoneyTotal = billMoneyTotal;
            PaidStatus = paidStatus;

        }

        [ForeignKey("CustormerRefId")]
        public virtual Customer Customer { get; set; }


    }
}