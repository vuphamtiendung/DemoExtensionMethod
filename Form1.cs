using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment_7
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int n = txtN.LaySoNguyen();
            List<int> list = n.DanhSachSNT();
            foreach(var i in list)
            {
                lstDSSNT.Items.Add(i);  
            }
        }

    }
}
