using BookManagement1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class Categolory
    {

        [Key]
        public int CategoloryID { get; set; }

        [Required]
        public string CategoloryName { get; set; }

        public ICollection<Book> Books { get; set; }

        public Categolory()
        {
            Books = new HashSet<Book>();
        }

    }
}