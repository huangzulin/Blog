using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Blog.Models.DBContext
{
    public class BaseModel
    {
        public BaseModel()
        {
            var userid  = HttpContext.Current.Request.IsAuthenticated? HttpContext.Current.User.Identity.GetUserId():null;
            CreateBy = userid;
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}