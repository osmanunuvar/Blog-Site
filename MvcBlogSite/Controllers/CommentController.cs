﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogSite.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        CommentManager cm = new CommentManager();
        public PartialViewResult CommentList(int id)
        {
            var commentlist = cm.CommentByBlog(id);
            return PartialView(commentlist);
        }
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}