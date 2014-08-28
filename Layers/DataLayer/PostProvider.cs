using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PostProvider
    {
        public static List<tbl_Post> GetAllPost()
        {
            List<tbl_Post> _Postlst = new List<tbl_Post>();
            using (BloggerEntities db = new BloggerEntities())
            {
                _Postlst = db.tbl_Post.ToList();
            }
            return _Postlst;
        }
    }
}
