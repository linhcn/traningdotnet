using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookManagement1.Areas.Admin.Models;
using BookManagement1.Uniti;
using BookManagement1.Models;

namespace BookManagement1.DAL
{
    public class AccountInitilizer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            Account acount = new Account() { 
                Password = EncryptData.md5("abc@1234"),
                Username = "linhcn",
                RoleName = "Admin"
            };

            context.Accounts.Add(acount);

            Author author = new Author()
            {
                AuthorName = "Tô Hoài",
                AuthorSummary = "Tô Hoài sinh ra tại quê nội ở thôn Cát Động, Thị trấn Kim Bài, huyện Thanh Oai, tỉnh Hà Đông cũ trong một gia đình thợ thủ công. Tuy nhiên, ông lớn lên ở quê ngoại là làng Nghĩa Đô, huyện Từ Liêm, phủ Hoài Đức, tỉnh Hà Đông (nay thuộc phường Nghĩa Đô, quận Cầu Giấy, Hà Nội, Việt Nam[2]). Bút danh Tô Hoài gắn với hai địa danh: sông Tô Lịch và phủ Hoài Đức."
            };
            context.Authors.Add(author);

            Production production = new Production() 
            {
                ProductionName = "Kim đồng"
            };
            
            context.Productions.Add(production);

            context.SaveChanges();
        }
    }
}