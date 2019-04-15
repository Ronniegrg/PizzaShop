namespace Rouni_Gorgees_Lab10_Ex1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateInformationButton = new System.Windows.Forms.Button();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.clearOrderButton = new System.Windows.Forms.Button();
            this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.onionsCheckBox = new System.Windows.Forms.CheckBox();
            this.olivesCheckBox = new System.Windows.Forms.CheckBox();
            this.peppersCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomsCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.hamCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.TextBox();
            this.pizzaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pizzaShopComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ordersSummaryTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.clearInformationButton = new System.Windows.Forms.Button();
            this.clearAllOrders = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateInformationButton);
            this.groupBox1.Controls.Add(this.deliveryAddressTextBox);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.orderNumberTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // updateInformationButton
            // 
            this.updateInformationButton.Location = new System.Drawing.Point(47, 195);
            this.updateInformationButton.Name = "updateInformationButton";
            this.updateInformationButton.Size = new System.Drawing.Size(118, 23);
            this.updateInformationButton.TabIndex = 8;
            this.updateInformationButton.Text = "Update Information";
            this.updateInformationButton.UseVisualStyleBackColor = true;
            this.updateInformationButton.Click += new System.EventHandler(this.UpdateInformationButton_Click);
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(110, 157);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(110, 20);
            this.deliveryAddressTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(110, 114);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(110, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(110, 75);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.customerNameTextBox.TabIndex = 5;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.CustomerNameTextBox_TextChanged);
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(110, 30);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(110, 20);
            this.orderNumberTextBox.TabIndex = 4;
            this.orderNumberTextBox.TextChanged += new System.EventHandler(this.OrderNumberTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addOrderButton);
            this.groupBox2.Controls.Add(this.clearOrderButton);
            this.groupBox2.Controls.Add(this.cheeseCheckBox);
            this.groupBox2.Controls.Add(this.onionsCheckBox);
            this.groupBox2.Controls.Add(this.olivesCheckBox);
            this.groupBox2.Controls.Add(this.peppersCheckBox);
            this.groupBox2.Controls.Add(this.pineappleCheckBox);
            this.groupBox2.Controls.Add(this.mushroomsCheckBox);
            this.groupBox2.Controls.Add(this.sausageCheckBox);
            this.groupBox2.Controls.Add(this.hamCheckBox);
            this.groupBox2.Controls.Add(this.pepperoniCheckBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.itemPrice);
            this.groupBox2.Controls.Add(this.pizzaTypeComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pizzaShopComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(250, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pizza Selection";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(197, 194);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(93, 23);
            this.addOrderButton.TabIndex = 16;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.Location = new System.Drawing.Point(41, 194);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(102, 23);
            this.clearOrderButton.TabIndex = 15;
            this.clearOrderButton.Text = "Clear Order";
            this.clearOrderButton.UseVisualStyleBackColor = true;
            this.clearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // cheeseCheckBox
            // 
            this.cheeseCheckBox.AutoSize = true;
            this.cheeseCheckBox.Location = new System.Drawing.Point(213, 159);
            this.cheeseCheckBox.Name = "cheeseCheckBox";
            this.cheeseCheckBox.Size = new System.Drawing.Size(62, 17);
            this.cheeseCheckBox.TabIndex = 14;
            this.cheeseCheckBox.Text = "Cheese";
            this.cheeseCheckBox.UseVisualStyleBackColor = true;
            this.cheeseCheckBox.CheckedChanged += new System.EventHandler(this.CheeseCheckBox_CheckedChanged);
            // 
            // onionsCheckBox
            // 
            this.onionsCheckBox.AutoSize = true;
            this.onionsCheckBox.Location = new System.Drawing.Point(213, 136);
            this.onionsCheckBox.Name = "onionsCheckBox";
            this.onionsCheckBox.Size = new System.Drawing.Size(59, 17);
            this.onionsCheckBox.TabIndex = 13;
            this.onionsCheckBox.Text = "Onions";
            this.onionsCheckBox.UseVisualStyleBackColor = true;
            this.onionsCheckBox.CheckedChanged += new System.EventHandler(this.OnionsCheckBox_CheckedChanged);
            // 
            // olivesCheckBox
            // 
            this.olivesCheckBox.AutoSize = true;
            this.olivesCheckBox.Location = new System.Drawing.Point(213, 113);
            this.olivesCheckBox.Name = "olivesCheckBox";
            this.olivesCheckBox.Size = new System.Drawing.Size(55, 17);
            this.olivesCheckBox.TabIndex = 12;
            this.olivesCheckBox.Text = "Olives";
            this.olivesCheckBox.UseVisualStyleBackColor = true;
            this.olivesCheckBox.CheckedChanged += new System.EventHandler(this.OlivesCheckBox_CheckedChanged);
            // 
            // peppersCheckBox
            // 
            this.peppersCheckBox.AutoSize = true;
            this.peppersCheckBox.Location = new System.Drawing.Point(116, 159);
            this.peppersCheckBox.Name = "peppersCheckBox";
            this.peppersCheckBox.Size = new System.Drawing.Size(65, 17);
            this.peppersCheckBox.TabIndex = 11;
            this.peppersCheckBox.Text = "Peppers";
            this.peppersCheckBox.UseVisualStyleBackColor = true;
            this.peppersCheckBox.CheckedChanged += new System.EventHandler(this.PeppersCheckBox_CheckedChanged);
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(116, 136);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.pineappleCheckBox.TabIndex = 10;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            this.pineappleCheckBox.CheckedChanged += new System.EventHandler(this.PineappleCheckBox_CheckedChanged);
            // 
            // mushroomsCheckBox
            // 
            this.mushroomsCheckBox.AutoSize = true;
            this.mushroomsCheckBox.Location = new System.Drawing.Point(116, 113);
            this.mushroomsCheckBox.Name = "mushroomsCheckBox";
            this.mushroomsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.mushroomsCheckBox.TabIndex = 9;
            this.mushroomsCheckBox.Text = "Mushrooms";
            this.mushroomsCheckBox.UseVisualStyleBackColor = true;
            this.mushroomsCheckBox.CheckedChanged += new System.EventHandler(this.MushroomsCheckBox_CheckedChanged);
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(13, 159);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(68, 17);
            this.sausageCheckBox.TabIndex = 8;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            this.sausageCheckBox.CheckedChanged += new System.EventHandler(this.SausageCheckBox_CheckedChanged);
            // 
            // hamCheckBox
            // 
            this.hamCheckBox.AutoSize = true;
            this.hamCheckBox.Location = new System.Drawing.Point(13, 136);
            this.hamCheckBox.Name = "hamCheckBox";
            this.hamCheckBox.Size = new System.Drawing.Size(48, 17);
            this.hamCheckBox.TabIndex = 7;
            this.hamCheckBox.Text = "Ham";
            this.hamCheckBox.UseVisualStyleBackColor = true;
            this.hamCheckBox.CheckedChanged += new System.EventHandler(this.HamCheckBox_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(13, 113);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 6;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.PepperoniCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Extra Toppings:";
            // 
            // itemPrice
            // 
            this.itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrice.Location = new System.Drawing.Point(213, 29);
            this.itemPrice.Multiline = true;
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(100, 55);
            this.itemPrice.TabIndex = 4;
            this.itemPrice.Text = "$0.00";
            this.itemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pizzaTypeComboBox
            // 
            this.pizzaTypeComboBox.FormattingEnabled = true;
            this.pizzaTypeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.pizzaTypeComboBox.Location = new System.Drawing.Point(75, 63);
            this.pizzaTypeComboBox.Name = "pizzaTypeComboBox";
            this.pizzaTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaTypeComboBox.TabIndex = 3;
            this.pizzaTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PizzaTypeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pizza Type:";
            // 
            // pizzaShopComboBox
            // 
            this.pizzaShopComboBox.FormattingEnabled = true;
            this.pizzaShopComboBox.Items.AddRange(new object[] {
            "Pizza Pizza",
            "Dominos",
            "Pizza Hut"});
            this.pizzaShopComboBox.Location = new System.Drawing.Point(75, 29);
            this.pizzaShopComboBox.Name = "pizzaShopComboBox";
            this.pizzaShopComboBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaShopComboBox.TabIndex = 1;
            this.pizzaShopComboBox.SelectedIndexChanged += new System.EventHandler(this.PizzaShopComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pizza Shop:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Orders Summary:";
            // 
            // ordersSummaryTextBox
            // 
            this.ordersSummaryTextBox.Location = new System.Drawing.Point(12, 289);
            this.ordersSummaryTextBox.Multiline = true;
            this.ordersSummaryTextBox.Name = "ordersSummaryTextBox";
            this.ordersSummaryTextBox.Size = new System.Drawing.Size(231, 149);
            this.ordersSummaryTextBox.TabIndex = 3;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(250, 417);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(304, 23);
            this.totalTextBox.TabIndex = 5;
            // 
            // clearInformationButton
            // 
            this.clearInformationButton.Location = new System.Drawing.Point(59, 454);
            this.clearInformationButton.Name = "clearInformationButton";
            this.clearInformationButton.Size = new System.Drawing.Size(118, 23);
            this.clearInformationButton.TabIndex = 6;
            this.clearInformationButton.Text = "Clear Information";
            this.clearInformationButton.UseVisualStyleBackColor = true;
            this.clearInformationButton.Click += new System.EventHandler(this.ClearInformationButton_Click);
            // 
            // clearAllOrders
            // 
            this.clearAllOrders.Location = new System.Drawing.Point(291, 454);
            this.clearAllOrders.Name = "clearAllOrders";
            this.clearAllOrders.Size = new System.Drawing.Size(102, 23);
            this.clearAllOrders.TabIndex = 7;
            this.clearAllOrders.Text = "Clear All Orders";
            this.clearAllOrders.UseVisualStyleBackColor = true;
            this.clearAllOrders.Click += new System.EventHandler(this.ClearAllOrders_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(447, 454);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(250, 289);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.ScrollAlwaysVisible = true;
            this.itemsListBox.Size = new System.Drawing.Size(304, 121);
            this.itemsListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 489);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearAllOrders);
            this.Controls.Add(this.clearInformationButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.ordersSummaryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Global Pizza Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateInformationButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox pizzaTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pizzaShopComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button clearOrderButton;
        private System.Windows.Forms.CheckBox cheeseCheckBox;
        private System.Windows.Forms.CheckBox onionsCheckBox;
        private System.Windows.Forms.CheckBox olivesCheckBox;
        private System.Windows.Forms.CheckBox peppersCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
        private System.Windows.Forms.CheckBox mushroomsCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.CheckBox hamCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ordersSummaryTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button clearInformationButton;
        private System.Windows.Forms.Button clearAllOrders;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox itemsListBox;
    }
}

