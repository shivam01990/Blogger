using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogger.Models
{

    public partial class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentMsg { get; set; }
        public string Imageurl { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }

}