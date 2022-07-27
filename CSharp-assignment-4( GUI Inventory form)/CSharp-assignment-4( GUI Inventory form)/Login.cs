using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_assignment_4__GUI_Inventory_form_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="Admin" && txtPassword.Text == "Admin")
            {
                Form1 home = new Form1(txtName.Text);
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Incorrect email or password");
            }

        }
    }
}
