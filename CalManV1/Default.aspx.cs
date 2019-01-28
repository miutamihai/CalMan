using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logic;

namespace CalManV1
{
    public partial class _Default : Page
    {
        Calculate logic = new Calculate();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "") return;
            BulletedList1.Items.Clear();
            logic.SetInput(System.Convert.ToDouble(TextBox1.Text));
            logic.Result(BulletedList1);
            
        }
    }
}