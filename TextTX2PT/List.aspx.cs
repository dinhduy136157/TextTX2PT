using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextTX2PT
{
    public partial class List : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hienthi();
            }
        }
        public void Hienthi()
        {
            grdDs.DataSource = data.DsNhanvien();
            DataBind();
        }
        protected void Xoa_Click(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "xoa")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                data.XoaNV(m);
                Hienthi();
            }
        }
        protected void Sua_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "capnhat")
            {
                int m = Convert.ToInt16(e.CommandArgument);
                Nhanvien n = data.lay1Nhanvien(m);
                Session["nv"] = n;
                Response.Redirect("Sua.aspx");
            }
        }

    }
}