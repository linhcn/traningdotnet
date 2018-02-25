using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDemo.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Gender StudentGender { get; set; }
        public bool isMarried { get; set; }
        public override string ToString()
        {
            return string.Format("ID={0},Name={1}",StudentID,StudentName);
        }
    }
    public enum Gender
    {
        Female,
        Male
    }
}