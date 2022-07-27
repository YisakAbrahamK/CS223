using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace CSharp_assignment_4__GUI_Inventory_form_
{
    public partial class Form1 : Form
    {
        public Form1(string name)
        {
            InitializeComponent();
            currentUser.Text += name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            Regex rxForNumber = new Regex(@"^[0-9]{5}$");
            Regex rxForInventoryNumber = new Regex(@"^[0-9]{6}$");

            bool allFieldsAreCorrect = true;
            errorProvider1.Clear();
            
            if (rxForNumber.IsMatch(txt_number.Text))
            {
                p.number = int.Parse(txt_number.Text);
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txt_number, "The filed should be 5 digite whole number.");
            }

            if (rxForInventoryNumber.IsMatch(txt_inventory_number.Text))
            {
                p.inventoryNumber = int.Parse(txt_inventory_number.Text);
            }
            else
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txt_inventory_number, "The field should be 6 digite whole number.");
            }

            p.Date = dtp_date.Value;

            for(int i = 0; i < txt_object_name.Text.Length; i++)
            {
                if (((txt_object_name.Text[i]>='A' && txt_object_name.Text[i] <= 'Z') || (txt_object_name.Text[i] >= 'a' && txt_object_name.Text[i] <= 'z') || (txt_object_name.Text[i] >= '0' && txt_object_name.Text[i] <= '9') || (txt_object_name.Text[i] == ' ' || txt_object_name.Text[i] == '_'))==false)
                {
                    allFieldsAreCorrect = false;
                    errorProvider1.SetError(txt_object_name, "The field should only contain alphabet, number, space and underscore('_').");
                    break;
                }
            }
            p.objectName = txt_object_name.Text;

            try
            {
                p.count = int.Parse(txt_count.Text);

            }catch(Exception ex)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txt_count, "The field should contain number.");
            }

            try
            {
                p.price = double.Parse(txt_price.Text);
            }
            catch (Exception ex)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(txt_price, "The field should contain number(it can be decimal number).");
            }

            p.isAvailable = isAvailable.Checked;

            foreach (var item in clbCatagory.CheckedItems)
            {
                p.catagory += item.ToString() + " ";
            }

            if (rbSimple.Checked == false && rbVariable.Checked == false)
            {
                allFieldsAreCorrect = false;
                errorProvider1.SetError(gbProductType, "One of the radio buttons should be selected.");

            }

            p.productType=(rbVariable.Checked==true)?"Variable":"Simple";

            if (allFieldsAreCorrect == true)
            {
                p.save();
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = Product.getAllProducts();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_count.Text = "";
            txt_inventory_number.Text = "";
            txt_number.Text = "";
            txt_object_name.Text = "";
            txt_price.Text = "";
            isAvailable.Checked = false;
        }

        private void isAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
