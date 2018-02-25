using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class Production
    {
        [Display(Name = "Id production")]
        [Key]
        public int ProductionID { get; set; }

        [Required]
        [Display(Name = "Production name")]
        public string ProductionName { get; set; }

        [Display(Name = "Phone")]
        public int? ProductionPhone { get; set; }

        [Display(Name = "Address")]
        public string ProductionAddress { get; set; }

        public Production() { }
        public Production(int proId, string proName, int proPhone, string proAddress)
        {
            ProductionID = proId;
            ProductionName = proName;
            ProductionPhone = proPhone;
            ProductionAddress = proAddress;
        }
    }
}