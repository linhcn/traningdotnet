using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookManagement1.Areas.Admin.Models.Database
{
    public class CategoloryBook
    {
        [Key] 
        [Column(Order = 1)]
        public int CategolotyID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int BookID { get; set; }
            
    }
}