namespace Store
{
    partial class Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbFood = new System.Windows.Forms.RadioButton();
            this.rbClothes = new System.Windows.Forms.RadioButton();
            this.rbAppliances = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.rbBeverages = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAllTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtBalanse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbFood
            // 
            this.rbFood.AutoSize = true;
            this.rbFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFood.Location = new System.Drawing.Point(52, 38);
            this.rbFood.Name = "rbFood";
            this.rbFood.Size = new System.Drawing.Size(72, 26);
            this.rbFood.TabIndex = 0;
            this.rbFood.TabStop = true;
            this.rbFood.Text = "Food";
            this.rbFood.UseVisualStyleBackColor = true;
            this.rbFood.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbClothes
            // 
            this.rbClothes.AutoSize = true;
            this.rbClothes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClothes.Location = new System.Drawing.Point(535, 38);
            this.rbClothes.Name = "rbClothes";
            this.rbClothes.Size = new System.Drawing.Size(91, 26);
            this.rbClothes.TabIndex = 1;
            this.rbClothes.TabStop = true;
            this.rbClothes.Text = "Clothes";
            this.rbClothes.UseVisualStyleBackColor = true;
            this.rbClothes.CheckedChanged += new System.EventHandler(this.rbClothes_CheckedChanged);
            // 
            // rbAppliances
            // 
            this.rbAppliances.AutoSize = true;
            this.rbAppliances.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAppliances.Location = new System.Drawing.Point(816, 38);
            this.rbAppliances.Name = "rbAppliances";
            this.rbAppliances.Size = new System.Drawing.Size(121, 26);
            this.rbAppliances.TabIndex = 2;
            this.rbAppliances.TabStop = true;
            this.rbAppliances.Text = "Appliances";
            this.rbAppliances.UseVisualStyleBackColor = true;
            this.rbAppliances.CheckedChanged += new System.EventHandler(this.rbAppliances_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a product:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(270, 92);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(241, 30);
            this.cmbProduct.TabIndex = 4;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // rbBeverages
            // 
            this.rbBeverages.AutoSize = true;
            this.rbBeverages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeverages.Location = new System.Drawing.Point(247, 38);
            this.rbBeverages.Name = "rbBeverages";
            this.rbBeverages.Size = new System.Drawing.Size(114, 26);
            this.rbBeverages.TabIndex = 5;
            this.rbBeverages.TabStop = true;
            this.rbBeverages.Text = "Beverages";
            this.rbBeverages.UseVisualStyleBackColor = true;
            this.rbBeverages.CheckedChanged += new System.EventHandler(this.rbBeverages_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "$\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(229, 196);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(94, 30);
            this.txtQuantity.TabIndex = 10;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(421, 196);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 30);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(816, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price,
            this.Quantity,
            this.Total,
            this.Discount});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(9, 301);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(961, 231);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 150;
            // 
            // Discount
            // 
            this.Discount.Text = "Discount";
            this.Discount.Width = 120;
            // 
            // lPrice
            // 
            this.lPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrice.Location = new System.Drawing.Point(32, 199);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(100, 30);
            this.lPrice.TabIndex = 15;
            this.lPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "All total";
            // 
            // txtAllTotal
            // 
            this.txtAllTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllTotal.Location = new System.Drawing.Point(122, 583);
            this.txtAllTotal.Name = "txtAllTotal";
            this.txtAllTotal.Size = new System.Drawing.Size(121, 30);
            this.txtAllTotal.TabIndex = 17;
            this.txtAllTotal.Text = "0";
            this.txtAllTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Discount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Paid";
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(122, 634);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(121, 30);
            this.txtPaid.TabIndex = 22;
            this.txtPaid.Text = "\r\n";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtBalanse
            // 
            this.txtBalanse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanse.Location = new System.Drawing.Point(122, 683);
            this.txtBalanse.Name = "txtBalanse";
            this.txtBalanse.Size = new System.Drawing.Size(121, 30);
            this.txtBalanse.TabIndex = 23;
            this.txtBalanse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 683);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Change\r\n";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(797, 673);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 40);
            this.button4.TabIndex = 26;
            this.button4.Text = "Print\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Date and time:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 22);
            this.label13.TabIndex = 28;
            this.label13.Text = "date and time\r\n";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(672, 199);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(0, 22);
            this.txtDiscount.TabIndex = 29;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(484, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 22);
            this.label9.TabIndex = 30;
            this.label9.Text = "Price per discount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(756, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "$";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(650, 254);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(100, 22);
            this.txtNeto.TabIndex = 33;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(812, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "Size:";
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(884, 196);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(0, 22);
            this.lSize.TabIndex = 35;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBalanse);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAllTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbBeverages);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAppliances);
            this.Controls.Add(this.rbClothes);
            this.Controls.Add(this.rbFood);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFood;
        private System.Windows.Forms.RadioButton rbClothes;
        private System.Windows.Forms.RadioButton rbAppliances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.RadioButton rbBeverages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.TextBox lPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAllTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtBalanse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.ColumnHeader Discount;
    }
}

