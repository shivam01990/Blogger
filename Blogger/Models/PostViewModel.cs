using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogger.Models
{
    public class PostViewModel
    {
        public PostModel Post { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}