using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookManagement1.Models
{
    public class Topic
    {
        [Display(Name = "Id topic")]
        [Key]
        public int TopicID { get; set; }

        [Required]
        [Display(Name = "Name Topic")]
        public string TopicName { get; set; }

        public Topic()
        {

        }
        public Topic(int topID, string topName)
        {
            TopicID = topID;
            TopicName = topName;

        }
    }
}