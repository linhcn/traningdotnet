using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookManagement1.Models
{
    public class Book     {
        
        [Key]
        public int BookID { get; set; }

        [Required]
        [Display(Name="Name")]
        public string BookName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double BookPrices { get; set; }

        [Display(Name = "Description")]
        public string BookDescription { get; set; }

        [Display(Name = "Date Update")]
        public DateTime BookDateUpdate { get; set; }

        [Display(Name = "Quantity")]
        public int BookQuantity { get; set; }

        [Display(Name = "Discount")]
        public string BookDiscount { get; set; }

        [Display(Name = "Topic Id")]
        public int? TopicRefId { get; set; }

        [Display(Name = "Production Id")]
        public int? ProductionRefId { get; set; }

        [Display(Name = "Author Id")]
        public int? AuthorRefId { get; set; }

        [Display(Name = "Image")]
        public string BookImage { get  ; set  ; }

        public Book()
        {
            Categolorys = new HashSet<Categolory>();
        }
        public Book(int bookID, string bookName, double bookPrices, string bookDesc, DateTime bookDate, int bookQuan, string bookDisc, int bookTopic, int bookPro, int bookAuthor, string bookImage)
        {
            BookID = bookID;
            BookName = bookName;
            BookPrices = bookPrices;
            BookDescription = bookDesc;
            BookDateUpdate = bookDate;
            BookQuantity = bookQuan;
            BookDiscount = bookDisc;
            TopicRefId = bookTopic;
            ProductionRefId = bookPro;
            AuthorRefId = bookAuthor;
            BookImage = bookImage;
            Categolorys = new HashSet<Categolory>();
        }


        public ICollection<Categolory> Categolorys { get; set; }

        [Display(Name="Id topic")]
        [ForeignKey("TopicRefId")]
        public virtual Topic Topic { get; set; }

        [Display(Name = "Id producton")]
        [ForeignKey("ProductionRefId")]
        public virtual Production Production { get; set; }

        [Display(Name = "Id author")]
        [ForeignKey("AuthorRefId")]
        public virtual Author Authors { get; set; }
    }
}