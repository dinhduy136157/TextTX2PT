using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextTX2PT
{
    public partial class Sua : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Nhanvien nv = (Nhanvien)Session["nv"];
                txtmanv.Text = nv.id.ToString();
                txtht.Text = nv.name;
                txtgt.Text = nv.gender;
                txtdc.Text = nv.address;
                txtemail.Text = nv.email;
                ddl.DataSource = data.DsChucvu();
                ddl.DataTextField = "name";
                ddl.DataValueField = "id";
                DataBind();
                ddl.SelectedValue = nv.title.ToString();
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien nv = new Nhanvien();
                nv.id = int.Parse(txtmanv.Text);
                nv.name = txtht.Text;
                nv.gender = txtgt.Text;
                nv.address = txtdc.Text;
                nv.email = txtemail.Text;
                nv.title = int.Parse(ddl.SelectedValue);
                data.updateNV(nv);
                msg.Text = "Cập nhật thành công";
            }
            catch (Exception e1)
            {

                msg.Text = e1.Message;
            }
        }
    }
}