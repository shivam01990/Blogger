using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoryProvider
    {

        public static List<tbl_Category> GetAllCategory()
        {
            List<tbl_Category> _Categorylst = new List<tbl_Category>();
            using (BloggerEntities db = new BloggerEntities())
            {
                _Categorylst = db.tbl_Category.ToList();
            }
            return _Categorylst;
        }
    }
}
