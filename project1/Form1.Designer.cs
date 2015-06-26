namespace Project1
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
            this.components = new System.ComponentModel.Container();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.cmdSaveProduct = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.cmdDeleteProduct = new System.Windows.Forms.Button();
            this.cmdUpdateProduct = new System.Windows.Forms.Button();
            this.cmdAddProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmdSaveCustomer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdDeleteCustomer = new System.Windows.Forms.Button();
            this.cmdUpdateCustomer = new System.Windows.Forms.Button();
            this.cmdAddCustomer = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.lblInvGrandTotal = new System.Windows.Forms.Label();
            this.lblInvTax = new System.Windows.Forms.Label();
            this.lblInvSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdInvRemoveItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInv2 = new System.Windows.Forms.DataGridView();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.lblInvPhone = new System.Windows.Forms.Label();
            this.lblInvPostal = new System.Windows.Forms.Label();
            this.lblInvLName = new System.Windows.Forms.Label();
            this.lblInvFName = new System.Windows.Forms.Label();
            this.cmdInvAddItem = new System.Windows.Forms.Button();
            this.cmdInvAddCust = new System.Windows.Forms.Button();
            this.dgInv1 = new System.Windows.Forms.DataGridView();
            this.cmdInvFindItem = new System.Windows.Forms.Button();
            this.cmdInvFindCust = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tab.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.tabInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabProduct.Controls.Add(this.lblMsg2);
            this.tabProduct.Controls.Add(this.cmdSaveProduct);
            this.tabProduct.Controls.Add(this.dgv2);
            this.tabProduct.Controls.Add(this.cmdDeleteProduct);
            this.tabProduct.Controls.Add(this.cmdUpdateProduct);
            this.tabProduct.Controls.Add(this.cmdAddProduct);
            this.tabProduct.Controls.Add(this.txtQuantity);
            this.tabProduct.Controls.Add(this.label15);
            this.tabProduct.Controls.Add(this.txtPrice);
            this.tabProduct.Controls.Add(this.label14);
            this.tabProduct.Controls.Add(this.txtDesc);
            this.tabProduct.Controls.Add(this.label13);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.label12);
            this.tabProduct.Controls.Add(this.txtProdId);
            this.tabProduct.Controls.Add(this.label11);
            this.tabProduct.Location = new System.Drawing.Point(4, 26);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProduct.Size = new System.Drawing.Size(966, 565);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = "Products";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(279, 18);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(0, 17);
            this.lblMsg2.TabIndex = 15;
            // 
            // cmdSaveProduct
            // 
            this.cmdSaveProduct.Location = new System.Drawing.Point(25, 514);
            this.cmdSaveProduct.Name = "cmdSaveProduct";
            this.cmdSaveProduct.Size = new System.Drawing.Size(218, 30);
            this.cmdSaveProduct.TabIndex = 14;
            this.cmdSaveProduct.Text = "No Changes - Save";
            this.cmdSaveProduct.UseVisualStyleBackColor = true;
            this.cmdSaveProduct.Click += new System.EventHandler(this.cmdSaveProduct_Click);
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AllowUserToResizeColumns = false;
            this.dgv2.AllowUserToResizeRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(279, 38);
            this.dgv2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(663, 506);
            this.dgv2.TabIndex = 13;
            // 
            // cmdDeleteProduct
            // 
            this.cmdDeleteProduct.Location = new System.Drawing.Point(25, 470);
            this.cmdDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdDeleteProduct.Name = "cmdDeleteProduct";
            this.cmdDeleteProduct.Size = new System.Drawing.Size(218, 30);
            this.cmdDeleteProduct.TabIndex = 12;
            this.cmdDeleteProduct.Text = "Delete Product";
            this.cmdDeleteProduct.UseVisualStyleBackColor = true;
            this.cmdDeleteProduct.Click += new System.EventHandler(this.cmdDeleteProduct_Click);
            // 
            // cmdUpdateProduct
            // 
            this.cmdUpdateProduct.Location = new System.Drawing.Point(25, 428);
            this.cmdUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdUpdateProduct.Name = "cmdUpdateProduct";
            this.cmdUpdateProduct.Size = new System.Drawing.Size(218, 30);
            this.cmdUpdateProduct.TabIndex = 11;
            this.cmdUpdateProduct.Text = "Update Product";
            this.cmdUpdateProduct.UseVisualStyleBackColor = true;
            this.cmdUpdateProduct.Click += new System.EventHandler(this.cmdUpdateProduct_Click);
            // 
            // cmdAddProduct
            // 
            this.cmdAddProduct.Location = new System.Drawing.Point(25, 386);
            this.cmdAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdAddProduct.Name = "cmdAddProduct";
            this.cmdAddProduct.Size = new System.Drawing.Size(218, 30);
            this.cmdAddProduct.TabIndex = 11;
            this.cmdAddProduct.Text = "Add Product";
            this.cmdAddProduct.UseVisualStyleBackColor = true;
            this.cmdAddProduct.Click += new System.EventHandler(this.cmdAddProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(25, 346);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(218, 24);
            this.txtQuantity.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Quantity:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(25, 273);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(218, 24);
            this.txtPrice.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Price:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(25, 200);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(218, 24);
            this.txtDesc.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Description:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(25, 127);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(218, 24);
            this.txtProdName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Product Name:";
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(25, 54);
            this.txtProdId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.ReadOnly = true;
            this.txtProdId.Size = new System.Drawing.Size(218, 24);
            this.txtProdId.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Product ID:";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabCustomer);
            this.tab.Controls.Add(this.tabProduct);
            this.tab.Controls.Add(this.tabInvoice);
            this.tab.Location = new System.Drawing.Point(-2, 35);
            this.tab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(974, 595);
            this.tab.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabCustomer.Controls.Add(this.lblMsg);
            this.tabCustomer.Controls.Add(this.cmdSaveCustomer);
            this.tabCustomer.Controls.Add(this.label10);
            this.tabCustomer.Controls.Add(this.label9);
            this.tabCustomer.Controls.Add(this.label8);
            this.tabCustomer.Controls.Add(this.label7);
            this.tabCustomer.Controls.Add(this.label6);
            this.tabCustomer.Controls.Add(this.cmdDeleteCustomer);
            this.tabCustomer.Controls.Add(this.cmdUpdateCustomer);
            this.tabCustomer.Controls.Add(this.cmdAddCustomer);
            this.tabCustomer.Controls.Add(this.dgv1);
            this.tabCustomer.Controls.Add(this.txtPhone);
            this.tabCustomer.Controls.Add(this.txtPostal);
            this.tabCustomer.Controls.Add(this.txtLastname);
            this.tabCustomer.Controls.Add(this.txtFirstname);
            this.tabCustomer.Controls.Add(this.txtCustId);
            this.tabCustomer.Location = new System.Drawing.Point(4, 26);
            this.tabCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCustomer.Size = new System.Drawing.Size(966, 565);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Customers";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(279, 18);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 20;
            // 
            // cmdSaveCustomer
            // 
            this.cmdSaveCustomer.Location = new System.Drawing.Point(25, 515);
            this.cmdSaveCustomer.Name = "cmdSaveCustomer";
            this.cmdSaveCustomer.Size = new System.Drawing.Size(218, 30);
            this.cmdSaveCustomer.TabIndex = 19;
            this.cmdSaveCustomer.Text = "No Changes - Save";
            this.cmdSaveCustomer.UseVisualStyleBackColor = true;
            this.cmdSaveCustomer.Click += new System.EventHandler(this.cmdSaveCustomer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Postal Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Customer ID:";
            // 
            // cmdDeleteCustomer
            // 
            this.cmdDeleteCustomer.Location = new System.Drawing.Point(25, 472);
            this.cmdDeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdDeleteCustomer.Name = "cmdDeleteCustomer";
            this.cmdDeleteCustomer.Size = new System.Drawing.Size(218, 30);
            this.cmdDeleteCustomer.TabIndex = 13;
            this.cmdDeleteCustomer.Text = "Delete Customer";
            this.cmdDeleteCustomer.UseVisualStyleBackColor = true;
            this.cmdDeleteCustomer.Click += new System.EventHandler(this.cmdDeleteCustomer_Click);
            // 
            // cmdUpdateCustomer
            // 
            this.cmdUpdateCustomer.Location = new System.Drawing.Point(25, 429);
            this.cmdUpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdUpdateCustomer.Name = "cmdUpdateCustomer";
            this.cmdUpdateCustomer.Size = new System.Drawing.Size(218, 30);
            this.cmdUpdateCustomer.TabIndex = 12;
            this.cmdUpdateCustomer.Text = "Update Customer";
            this.cmdUpdateCustomer.UseVisualStyleBackColor = true;
            this.cmdUpdateCustomer.Click += new System.EventHandler(this.cmdUpdateCustomer_Click);
            // 
            // cmdAddCustomer
            // 
            this.cmdAddCustomer.Location = new System.Drawing.Point(25, 386);
            this.cmdAddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdAddCustomer.Name = "cmdAddCustomer";
            this.cmdAddCustomer.Size = new System.Drawing.Size(218, 30);
            this.cmdAddCustomer.TabIndex = 11;
            this.cmdAddCustomer.Text = "Add Customer";
            this.cmdAddCustomer.UseVisualStyleBackColor = true;
            this.cmdAddCustomer.Click += new System.EventHandler(this.cmdAddCustomer_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeColumns = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(279, 38);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(555, 507);
            this.dgv1.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(25, 346);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(218, 24);
            this.txtPhone.TabIndex = 9;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(25, 273);
            this.txtPostal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(218, 24);
            this.txtPostal.TabIndex = 7;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(25, 200);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(218, 24);
            this.txtLastname.TabIndex = 5;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(25, 127);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(218, 24);
            this.txtFirstname.TabIndex = 3;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(25, 54);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(218, 24);
            this.txtCustId.TabIndex = 1;
            // 
            // tabInvoice
            // 
            this.tabInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabInvoice.Controls.Add(this.lblInvGrandTotal);
            this.tabInvoice.Controls.Add(this.lblInvTax);
            this.tabInvoice.Controls.Add(this.lblInvSubTotal);
            this.tabInvoice.Controls.Add(this.label4);
            this.tabInvoice.Controls.Add(this.label3);
            this.tabInvoice.Controls.Add(this.label2);
            this.tabInvoice.Controls.Add(this.cmdInvRemoveItem);
            this.tabInvoice.Controls.Add(this.label1);
            this.tabInvoice.Controls.Add(this.dgInv2);
            this.tabInvoice.Controls.Add(this.lblInvPhone);
            this.tabInvoice.Controls.Add(this.lblInvPostal);
            this.tabInvoice.Controls.Add(this.lblInvLName);
            this.tabInvoice.Controls.Add(this.lblInvFName);
            this.tabInvoice.Controls.Add(this.cmdInvAddItem);
            this.tabInvoice.Controls.Add(this.cmdInvAddCust);
            this.tabInvoice.Controls.Add(this.dgInv1);
            this.tabInvoice.Controls.Add(this.cmdInvFindItem);
            this.tabInvoice.Controls.Add(this.cmdInvFindCust);
            this.tabInvoice.Location = new System.Drawing.Point(4, 26);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoice.Size = new System.Drawing.Size(966, 565);
            this.tabInvoice.TabIndex = 2;
            this.tabInvoice.Text = "Invoice";
            // 
            // lblInvGrandTotal
            // 
            this.lblInvGrandTotal.AutoSize = true;
            this.lblInvGrandTotal.Location = new System.Drawing.Point(814, 462);
            this.lblInvGrandTotal.Name = "lblInvGrandTotal";
            this.lblInvGrandTotal.Size = new System.Drawing.Size(52, 17);
            this.lblInvGrandTotal.TabIndex = 17;
            this.lblInvGrandTotal.Text = "label17";
            // 
            // lblInvTax
            // 
            this.lblInvTax.AutoSize = true;
            this.lblInvTax.Location = new System.Drawing.Point(814, 435);
            this.lblInvTax.Name = "lblInvTax";
            this.lblInvTax.Size = new System.Drawing.Size(52, 17);
            this.lblInvTax.TabIndex = 16;
            this.lblInvTax.Text = "label16";
            // 
            // lblInvSubTotal
            // 
            this.lblInvSubTotal.AutoSize = true;
            this.lblInvSubTotal.Location = new System.Drawing.Point(814, 408);
            this.lblInvSubTotal.Name = "lblInvSubTotal";
            this.lblInvSubTotal.Size = new System.Drawing.Size(44, 17);
            this.lblInvSubTotal.TabIndex = 15;
            this.lblInvSubTotal.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Grand Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "GST / PST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sub Total:";
            // 
            // cmdInvRemoveItem
            // 
            this.cmdInvRemoveItem.Enabled = false;
            this.cmdInvRemoveItem.Location = new System.Drawing.Point(724, 362);
            this.cmdInvRemoveItem.Name = "cmdInvRemoveItem";
            this.cmdInvRemoveItem.Size = new System.Drawing.Size(218, 30);
            this.cmdInvRemoveItem.TabIndex = 11;
            this.cmdInvRemoveItem.Text = "Remove Item";
            this.cmdInvRemoveItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Items to purchase:";
            // 
            // dgInv2
            // 
            this.dgInv2.AutoGenerateColumns = false;
            this.dgInv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInv2.DataSource = this.bindingSource4;
            this.dgInv2.Location = new System.Drawing.Point(26, 362);
            this.dgInv2.Name = "dgInv2";
            this.dgInv2.Size = new System.Drawing.Size(674, 150);
            this.dgInv2.TabIndex = 9;
            // 
            // lblInvPhone
            // 
            this.lblInvPhone.AutoSize = true;
            this.lblInvPhone.Location = new System.Drawing.Point(262, 300);
            this.lblInvPhone.Name = "lblInvPhone";
            this.lblInvPhone.Size = new System.Drawing.Size(44, 17);
            this.lblInvPhone.TabIndex = 8;
            this.lblInvPhone.Text = "label4";
            // 
            // lblInvPostal
            // 
            this.lblInvPostal.AutoSize = true;
            this.lblInvPostal.Location = new System.Drawing.Point(262, 271);
            this.lblInvPostal.Name = "lblInvPostal";
            this.lblInvPostal.Size = new System.Drawing.Size(44, 17);
            this.lblInvPostal.TabIndex = 7;
            this.lblInvPostal.Text = "label3";
            // 
            // lblInvLName
            // 
            this.lblInvLName.AutoSize = true;
            this.lblInvLName.Location = new System.Drawing.Point(26, 300);
            this.lblInvLName.Name = "lblInvLName";
            this.lblInvLName.Size = new System.Drawing.Size(44, 17);
            this.lblInvLName.TabIndex = 6;
            this.lblInvLName.Text = "label2";
            // 
            // lblInvFName
            // 
            this.lblInvFName.AutoSize = true;
            this.lblInvFName.Location = new System.Drawing.Point(26, 271);
            this.lblInvFName.Name = "lblInvFName";
            this.lblInvFName.Size = new System.Drawing.Size(44, 17);
            this.lblInvFName.TabIndex = 5;
            this.lblInvFName.Text = "label1";
            // 
            // cmdInvAddItem
            // 
            this.cmdInvAddItem.Enabled = false;
            this.cmdInvAddItem.Location = new System.Drawing.Point(23, 181);
            this.cmdInvAddItem.Name = "cmdInvAddItem";
            this.cmdInvAddItem.Size = new System.Drawing.Size(218, 30);
            this.cmdInvAddItem.TabIndex = 4;
            this.cmdInvAddItem.Text = "Add Product";
            this.cmdInvAddItem.UseVisualStyleBackColor = true;
            // 
            // cmdInvAddCust
            // 
            this.cmdInvAddCust.Enabled = false;
            this.cmdInvAddCust.Location = new System.Drawing.Point(23, 78);
            this.cmdInvAddCust.Name = "cmdInvAddCust";
            this.cmdInvAddCust.Size = new System.Drawing.Size(218, 30);
            this.cmdInvAddCust.TabIndex = 3;
            this.cmdInvAddCust.Text = "Set Customer";
            this.cmdInvAddCust.UseVisualStyleBackColor = true;
            this.cmdInvAddCust.Click += new System.EventHandler(this.cmdInvAddCust_Click);
            // 
            // dgInv1
            // 
            this.dgInv1.AllowUserToAddRows = false;
            this.dgInv1.AllowUserToDeleteRows = false;
            this.dgInv1.AllowUserToResizeColumns = false;
            this.dgInv1.AllowUserToResizeRows = false;
            this.dgInv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInv1.Location = new System.Drawing.Point(265, 41);
            this.dgInv1.MultiSelect = false;
            this.dgInv1.Name = "dgInv1";
            this.dgInv1.ReadOnly = true;
            this.dgInv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInv1.Size = new System.Drawing.Size(677, 170);
            this.dgInv1.TabIndex = 2;
            // 
            // cmdInvFindItem
            // 
            this.cmdInvFindItem.Enabled = false;
            this.cmdInvFindItem.Location = new System.Drawing.Point(23, 145);
            this.cmdInvFindItem.Name = "cmdInvFindItem";
            this.cmdInvFindItem.Size = new System.Drawing.Size(218, 30);
            this.cmdInvFindItem.TabIndex = 1;
            this.cmdInvFindItem.Text = "Find Product";
            this.cmdInvFindItem.UseVisualStyleBackColor = true;
            this.cmdInvFindItem.Click += new System.EventHandler(this.cmdInvFindItem_Click);
            // 
            // cmdInvFindCust
            // 
            this.cmdInvFindCust.Location = new System.Drawing.Point(23, 41);
            this.cmdInvFindCust.Name = "cmdInvFindCust";
            this.cmdInvFindCust.Size = new System.Drawing.Size(218, 30);
            this.cmdInvFindCust.TabIndex = 0;
            this.cmdInvFindCust.Text = "Find Customer";
            this.cmdInvFindCust.UseVisualStyleBackColor = true;
            this.cmdInvFindCust.Click += new System.EventHandler(this.cmdInvFindCust_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 628);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.tabInvoice.ResumeLayout(false);
            this.tabInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.Button cmdDeleteCustomer;
        private System.Windows.Forms.Button cmdUpdateCustomer;
        private System.Windows.Forms.Button cmdAddCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdDeleteProduct;
        private System.Windows.Forms.Button cmdUpdateProduct;
        private System.Windows.Forms.Button cmdAddProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.BindingSource bindingSource2;
        public System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        protected System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button cmdSaveCustomer;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button cmdSaveProduct;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.Label lblInvGrandTotal;
        private System.Windows.Forms.Label lblInvTax;
        private System.Windows.Forms.Label lblInvSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdInvRemoveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInv2;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.Label lblInvPhone;
        private System.Windows.Forms.Label lblInvPostal;
        private System.Windows.Forms.Label lblInvLName;
        private System.Windows.Forms.Label lblInvFName;
        private System.Windows.Forms.Button cmdInvAddItem;
        private System.Windows.Forms.Button cmdInvAddCust;
        private System.Windows.Forms.DataGridView dgInv1;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Button cmdInvFindItem;
        private System.Windows.Forms.Button cmdInvFindCust;


    }
}

