using Store.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            label13.Text = DateTime.Now.ToString("MM/dd/yyyy  H:mm:ss");
            label14.Hide();
            lSize.Hide();
        }
        FoodAndBeverages food = new FoodAndBeverages("apples", "BrandA", 1.50, new DateTime(2022 - 01 - 14));
        FoodAndBeverages beverages = new FoodAndBeverages("milk", "BrandM", 0.99, new DateTime(2022 - 02 - 02));
        Clothes clothes = new Clothes("T-shirt", "BrandT", 15.99, Class.Size.M, "violet");
        Appliances appliances = new Appliances("laptop", "BrandL", 2345, "ModelL", new DateTime(2021 - 03 - 03), 1.125);
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbFood.ForeColor =Color.Green;
            rbClothes.ForeColor = Color.Red;
            rbAppliances.ForeColor = Color.Red;
            rbBeverages.ForeColor = Color.Red;
            cmbProduct.Items.Clear();
           
            cmbProduct.Items.Add(food.name.ToString());
           
        }

        private void rbBeverages_CheckedChanged(object sender, EventArgs e)
        {
            rbFood.ForeColor = Color.Red;
            rbClothes.ForeColor = Color.Red;
            rbAppliances.ForeColor = Color.Red;
            rbBeverages.ForeColor = Color.Green;
         
            cmbProduct.Items.Clear();

            cmbProduct.Items.Add(beverages.name.ToString());
        }

        private void rbClothes_CheckedChanged(object sender, EventArgs e)
        {
            rbFood.ForeColor = Color.Red;
            rbClothes.ForeColor = Color.Green;
            rbAppliances.ForeColor = Color.Red;
            rbBeverages.ForeColor = Color.Red;
            cmbProduct.Items.Clear();

            cmbProduct.Items.Add(clothes.name.ToString());
        }

        private void rbAppliances_CheckedChanged(object sender, EventArgs e)
        {
            rbFood.ForeColor = Color.Red;
            rbClothes.ForeColor = Color.Red;
            rbAppliances.ForeColor = Color.Green;
            rbBeverages.ForeColor = Color.Red;
         
            cmbProduct.Items.Clear();

            cmbProduct.Items.Add(appliances.name.ToString());
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                string check = cmbProduct.SelectedItem.ToString();
                txtQuantity.Text = "";
                txtTotal.Text = "";
                if (rbFood.Checked)
                {
                    lPrice.Text = food.price.ToString();
                }
                else if (rbBeverages.Checked)
                {
                    lPrice.Text = beverages.price.ToString();
                }
                else if (rbAppliances.Checked) {
                    lPrice.Text = appliances.price.ToString();
                }
                else
                {
                    lPrice.Text = clothes.price.ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try {
               if(txtQuantity.Text.Length > 0)
                {
                    txtTotal.Text = (float.Parse(lPrice.Text)*int.Parse(txtQuantity.Text)).ToString();
                    if (rbAppliances.Checked)
                    {
                        txtDiscount.Text = appliances.Discount().ToString();
                    }
                    else if (rbFood.Checked)
                    {
                        txtDiscount.Text = food.Discount().ToString();
                    }
                    else if (rbBeverages.Checked)
                    {
                        txtDiscount.Text = beverages.Discount().ToString();
                    }
                    else 
                    {
                        txtDiscount.Text = clothes.Discount().ToString();
                        lSize.Text = clothes.size.ToString();
                        lSize.Show();
                        label14.Show();
                    }
                   
                }
               
            }
            catch
            {
                MessageBox.Show("You must enter the quantity as a number.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbProduct.Text == "") {
                MessageBox.Show("Choose an item");
            }
            else
            {
                string[] arr = new string[5];
                arr[0] = cmbProduct.SelectedItem.ToString();
                arr[1] = lPrice.Text;
                arr[2] = txtQuantity.Text;
                arr[3] = txtNeto.Text;
                arr[4] = (float.Parse(txtTotal.Text) - float.Parse(txtNeto.Text)).ToString(); 

                if (!string.IsNullOrEmpty(arr[0]) && !string.IsNullOrEmpty(arr[1]) && !string.IsNullOrEmpty(arr[2])
                         && !string.IsNullOrEmpty(arr[3]) && !string.IsNullOrEmpty(arr[4]))
                {
                    ListViewItem list = new ListViewItem(arr);
                    listView1.Items.Add(list);
                    try
                    {
                        txtAllTotal.Text = (float.Parse(txtAllTotal.Text) + float.Parse(txtTotal.Text)).ToString();
                    }
                    catch(Exception ex) { txtAllTotal.Text = ""; }
                }
                else
                {
                    MessageBox.Show("Fill in all the fields");
                    return;
                }
             }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtPaid.Text.Length > 0)
                {
                    txtBalanse.Text = (float.Parse(txtAllTotal.Text) - float.Parse(txtPaid.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Font font = new Font("Arial Bold", 11);
                SolidBrush brush = new SolidBrush(Color.Black);


                PrintDocument print = new PrintDocument();
                print.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {

                    e1.Graphics.DrawString("---Products---", font, brush, new RectangleF(0, 30, 0, 0));
                    e1.Graphics.DrawString("Date: " + DateTime.Now, font, brush, new RectangleF(0, 50, 0, 0));
                    e1.Graphics.DrawString("\n " + "\n", new Font("Arial Bold", 11), new SolidBrush(Color.Black), new RectangleF(0, 0, print.DefaultPageSettings.PrintableArea.Width, print.DefaultPageSettings.PrintableArea.Height));
                    var startX = 0;
                    var startY = 80;
                    var Offset = 0;

                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        int ii = 1;
                        ii++;
                        string first = listView1.Items[i].SubItems[0].Text;
                        string third = listView1.Items[i].SubItems[1].Text;
                        string second = listView1.Items[i].SubItems[2].Text;
                        string total = listView1.Items[i].SubItems[3].Text;
                        string discount = listView1.Items[i].SubItems[4].Text;

                        e1.Graphics.DrawString("Name: " + first + "\t", font, brush, startX, startY + Offset);
                        Offset = Offset + 25;
                        e1.Graphics.DrawString(third+"x"+second+"="+total, font, brush, startX, startY + Offset);
                        Offset = Offset + 25;
                        e1.Graphics.DrawString("Discount: -"+discount+"$" , font, brush, startX, startY + Offset);
                        Offset = Offset + 40;
                    }
                    Offset = Offset + 25;
                    e1.Graphics.DrawString("--------------------------------", font, brush, startX, startY + Offset);
                    Offset = Offset + 25;
                    e1.Graphics.DrawString("Subtotal: " + txtAllTotal.Text, font, brush, startX, startY + Offset);
                    Offset = Offset + 25;
                    e1.Graphics.DrawString("Paid: " + txtPaid.Text, font, brush, startX, startY + Offset);
                    Offset = Offset + 25;
                    e1.Graphics.DrawString("Change: " + txtBalanse.Text, font, brush, startX, startY + Offset);
                    Offset = Offset + 25;


                };

                try
                {
                    print.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text.Length > 0)
                {
                    txtNeto.Text = (float.Parse(txtTotal.Text) - float.Parse(txtTotal.Text)*(float.Parse(txtDiscount.Text) / 100)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
