using BookManagement1.DAL;
using BookManagement1.Uniti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManagement1.Areas.Admin.Models
{
    public class AccountModel
    {
        private BookContext db =new BookContext();

        public AccountModel()
        {
            db = new BookContext();
        }
        public bool login(string userName, string password)
        {
            string pass = EncryptData.md5(password);
            List<Account> accouts = db.Accounts.ToList();
            
            foreach (var item in accouts)
            {
                string pass1 = item.Password;
                if (item.Username.Equals(userName) && item.Password.Equals(pass))
                {
                    return true;
                }
            }
            return false;
        }
    }
}