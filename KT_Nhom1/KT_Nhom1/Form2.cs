using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_Nhom1
{
    public partial class Form2 : Form
    {

          public Form2(string username)
          {
                InitializeComponent();
             lblWelcome.Text = "Chào mừng " + username + "! Đăng nhập thành công!";
          }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
