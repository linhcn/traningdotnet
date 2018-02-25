using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BookManagement1.Uniti;

namespace BookManagement1.Areas.Admin.Models
{
    public class Account
    {

        private string _password;
        public Account()
        {

        }
        public Account(String userName, string password, string roleName,bool rememberMe)
        {
            Username = userName;
            Password = password;
            RoleName = roleName;
            RememberMe = rememberMe;
        }
        [Key]
        public int AccountId { get; set; }
        [Required(ErrorMessage = "This is required")]
        public string Username { get; set; }

        [MinLength(6)]
        [Required(ErrorMessage = "This is required")]
        public string Password {
            get { return _password;}

            set { _password = value;}
        }

        [Required(ErrorMessage = "This is required")]
        public string RoleName { get; set; }

        public bool RememberMe { get; set; }
    }
}