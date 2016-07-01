using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Models.DBContext;

namespace Blog.Models
{
    public class Article:BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}