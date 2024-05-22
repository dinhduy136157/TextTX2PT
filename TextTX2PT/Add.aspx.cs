using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextTX2PT
{
    public partial class Add : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl.DataSource = data.DsChucvu();
                ddl.DataTextField = "name";
                ddl.DataValueField = "id";
                DataBind();
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien nv = new Nhanvien();
                nv.name = txtht.Text;
                nv.gender = txtgt.Text;
                nv.address = txtdc.Text;
                nv.email = txtemail.Text;
                nv.title = Convert.ToInt32(ddl.SelectedValue);
                data.AddNV(nv);
                msg.Text = "Thêm thành công";


            }
            catch (Exception ex)
            {

                msg.Text = "Có lỗi xảy ra: " + ex.Message;
            }
        }
    }
}