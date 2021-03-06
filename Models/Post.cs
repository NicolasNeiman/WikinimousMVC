using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WikinimousMVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public string Content { get; set; }

        public List<Comment> Comments { get; set; }
    }
}