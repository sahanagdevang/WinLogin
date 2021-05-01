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
    public partial class RegPage : Form
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            Function Func = new Function();

            int t1 = Int32.Parse(textBox1.Text);
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            string query = string.Format("INSERT INTO WinLogin VALUES({0},'{1}','{2}','{3}')",t1,t2,t3,t4);
            //string query = "Insert into WinLogin Values(" + t1 + "," + t2 + "," + t3 + "," + t4 + ")";
            Func.setData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
