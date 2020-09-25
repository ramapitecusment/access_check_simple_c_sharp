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
    public partial class Form2 : Form
    {
        Form form1 = new Form1();

        String get_Login;
        String get_Pswd;
        String MessageText;

        public Form2(String get_Login, String get_Pswd)
        {
            InitializeComponent();

            this.get_Login = get_Login;
            this.get_Pswd = get_Pswd;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (get_Login == "1")
            {
                MessageText = "У вас первый уровень доступа"; 
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
            else if(get_Login == "2")
            {
                MessageText = "У вас второй уровень доступа";
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                MessageText = "У вас третий уровень доступа";
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MessageText);
        }

        private void button1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MessageText);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MessageText);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
