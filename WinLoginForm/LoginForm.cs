using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            if (untxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("username cannot be empty");
                return false;
            }
            if (pwdtxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("password cannont be empty");
                return false;
            }
            return true;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Function Func = new Function();
            string query = "SELECT * FROM WinLogin";
            DataSet data = new DataSet();

            data = Func.getData(query);
            DataRow drow = data.Tables[0].Rows[0];
            string str = drow.ItemArray.GetValue(2).ToString();
            MessageBox.Show(str);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegPage objRegisterpage = new RegPage();
            this.Hide();
            objRegisterpage.Show();
        }
    }
}
