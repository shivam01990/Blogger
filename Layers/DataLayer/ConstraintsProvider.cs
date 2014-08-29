using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ConstraintsProvider
    {
        public  enum Constraints
        {
            Announcement=1
        }

        public static string GetAnnouncement()
        {
            string Announcementtext = "";
            using (BloggerEntities db = new BloggerEntities())
            {
                Announcementtext = (from u in db.tbl_Constraints
                                   where u.RelatedId == (int)Constraints.Announcement
                                   select u.DataValues).FirstOrDefault();

            }
            return Announcementtext;
        }
    }
}
