using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
{
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name, contact, address;

            int quantity;
            

            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;

            string order = orderComboBox.Text;
            quantity = Convert.ToInt32(quantityTextBox.Text);
            int Black_120 = 120;
            int Cold_100 = 100;
            int Hot_90 = 90;
            int Regular_80= 80;

             if (order=="Black_120")
            {
                richTextBox.Text = Convert.ToString(quantity * Black_120);
            }
             else if (order=="Cold_100")
            {
                richTextBox.Text = Convert.ToString(quantity * Cold_100);
            
            }
             else if (order== "Hot_90")
            {
                richTextBox.Text = Convert.ToString(quantity * Hot_90);
            }
             else if (order=="Reguler_80")
                    {
                richTextBox.Text = Convert.ToString(quantity * Regular_80);
            }
            else
            {
                MessageBox.Show("Please Select An Item");
            }

            richTextBox.Text = name + Environment.NewLine + contact  + Environment.NewLine+  address +
               Environment.NewLine + richTextBox.Text ;
        }
    }
}
