using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookManagement1.DAL;
using BookManagement1.Models;

namespace BookManagement1.Areas.Admin.Models
{
    
    public class BookModel
    {
        private BookContext db;

        public BookModel()
        {
            db = new BookContext();
        }

        //public List<Book> getAll()        
        //{
        //    return (from b in db.Books
        //                    select new 
        //                    {
        //                        BookID = b.BookID,
        //                        BookName = b.BookName,
        //                        BookPrices = b.BookPrices,
        //                        BookDescription = b.BookDescription,
        //                        BookDateUpdate = b.BookDateUpdate,
        //                        BookQuantity = b.BookQuantity,
        //                        BookDiscount = b.BookDiscount,
        //                        TopicRefId = b.TopicRefId,
        //                        ProductionRefId = b.AuthorRefId,
        //                        AuthorRefId = b.AuthorRefId,
        //                        BookImage = b.BookImage,

        //                    }).ToList<Book>();
                 
        //}

        public List<Book> getAllBook()
            {

                var query = from b in db.Books
                            select new
                            {
                                BookID = b.BookID,
                                BookName = b.BookName,
                                BookPrices = b.BookPrices,
                                BookDescription = b.BookDescription,
                                BookDateUpdate = b.BookDateUpdate,
                                BookQuantity = b.BookQuantity,
                                BookDiscount = b.BookDiscount,
                            };
                var books = query.ToList().Select(b => new Book
                {
                    BookID = b.BookID,
                    BookName = b.BookName,
                    BookPrices = b.BookPrices,
                    BookDescription = b.BookDescription,
                    BookDateUpdate = b.BookDateUpdate,
                    BookQuantity = b.BookQuantity,
                    BookDiscount = b.BookDiscount,
                }).ToList();

                return books;
            }

    }
}
