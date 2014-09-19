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

        public static tbl_Post GetPost(int Id)
        {
           tbl_Post _Post = new tbl_Post();
            using (BloggerEntities db = new BloggerEntities())
            {
                _Post = db.tbl_Post.Where(p=>p.Id==Id).FirstOrDefault();
            }
            return _Post;
        }
    }
}
