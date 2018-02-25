using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name="Name Customer")]
        public string CustomerName { get; set; }

        [Display(Name = "Brithday")]
        [DataType(DataType.Date)]
        public DateTime CustomerBirthday { get; set; }

        [Display(Name = "Gender")]
        public string CustomerGender { get; set; }

        [Required]
        [Display(Name = "Email Customer")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email address is note valid")]
        public string CustomerEmail { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Phone is note valid")]
        public int CustomerPhone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string CustomerAddress { get; set; }

        [Required]
        [MinLength(6)]
        public string CustomerPass { get; set; }
        
        [Display(Name="Account")]
        public string CustomerAccount { get; set; }

        public Customer()
        {

        }
        public Customer(int cusID, string cusName, DateTime cusBirthday, string cusGender, string cusEmail, int cusPhone, string cusAddress, string cusPass, string cusAccount)
        {
            CustomerID = cusID;
            CustomerName = cusName;
            CustomerBirthday = cusBirthday;
            CustomerGender = cusGender;
            CustomerEmail = cusEmail;
            CustomerPhone = cusPhone;
            CustomerAddress = cusAddress;
            CustomerPass = cusPass;
            CustomerAccount = cusAccount;
        }
    }
}