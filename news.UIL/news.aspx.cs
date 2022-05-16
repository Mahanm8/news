using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using news.BLL2;
using news.Entities;

namespace news.UIL2
{
    public partial class news : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            News news = new News();
            khabar kh = news.loadfirstnews();
        }
    }
}