using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [Required]
        [Display(Name="Author Name")]
        public string AuthorName { get; set; }

        [Display(Name = "Author address")]
        public string AuthorAddress { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int? AuthorPhone { get; set; }

        [Display(Name = "Summary")]
        public string AuthorSummary { get; set; }

        public Author() { }

        public Author(int authorID, string authorName, string authorAddress, int authorPhone, string authorSum )
        {
            AuthorID = authorID;
            AuthorName = authorName;
            AuthorAddress = authorAddress;
            AuthorPhone = authorPhone;
            AuthorSummary = authorSum;

        }
    }
}