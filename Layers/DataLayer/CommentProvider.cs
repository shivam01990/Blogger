using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CommentProvider
    {
        public static List<tbl_Comment> GetAllCommentByPostId(int Id)
        {
            List<tbl_Comment> _Commentlst = new List<tbl_Comment>();
            using (BloggerEntities db = new BloggerEntities())
            {
                _Commentlst = db.tbl_Comment.Where(c=>c.PostId==Id).ToList();
            }
            return _Commentlst;
        }

    }
}
