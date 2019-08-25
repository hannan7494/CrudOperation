using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudoperation
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Employee_Name"].DefaultValue = txtName.Text;
            SqlDataSource1.InsertParameters["Employee_Dept"].DefaultValue = txtDpt.Text;
            SqlDataSource1.InsertParameters["Email"].DefaultValue = txtEmail.Text;
            SqlDataSource1.Insert();
            txtName.Text = "";
            txtDpt.Text = "";
            txtEmail.Text = "";
        }
    }
}