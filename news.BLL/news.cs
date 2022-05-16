using news.DAL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using news.Entities;

namespace news.BLL2
{
    public class News
    {
        public khabar loadfirstnews()
        {
            newsDao newsDao = new newsDao();
            return newsDao.Loadfirstnews();
        }
    }
}
