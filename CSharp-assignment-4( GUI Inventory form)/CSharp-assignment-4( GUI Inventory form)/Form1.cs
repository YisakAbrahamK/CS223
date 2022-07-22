using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace CSharp_assignment_4__GUI_Inventory_form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Date = dtp_date.Value;
            p.inventoryNumber = int.Parse(txt_inventory_number.Text);
            p.objectName = txt_object_name.Text;
            p.count = int.Parse(txt_count.Text);
            p.price = double.Parse(txt_price.Text);
            p.save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
