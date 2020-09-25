using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusRami02
{
    public partial class Form1 : Form
    {
        String usr1_login = "1";
        String usr2_login = "2";
        String usr3_login = "3";

        String usr1_pwd = "1";
        String usr2_pwd = "2";
        String usr3_pwd = "3";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             String get_Login = textBox1.Text;
             String get_Pswd = textBox2.Text;

            if ((get_Login == "1" && get_Pswd == "1") || (get_Login == "2" && get_Pswd == "2") || (get_Login == "3" & get_Pswd == "3"))
            {
                Form form2 = new Form2(get_Login, get_Pswd);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации");
            }
        }
    }
}
