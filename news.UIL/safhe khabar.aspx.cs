using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using news.BLL2;
using news.Entities;

namespace news.UIL
{
    public partial class safhe_khabar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                News news = new News();
                khabar kh = news.loadfirstnews();
                newsid.Text = kh.textbox;
                title.Text = kh.title;
                textbox.Text = kh.id.ToString();
            }
          

        }
        protected void nextbuttom_click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(textbox.Text , out id);
            News news = new News();
            khabar kh = news.loadnextnews(id);
            newsid.Text = kh.textbox;
            title.Text = kh.title;
            textbox.Text = kh.id.ToString();

        }
    }
}