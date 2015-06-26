using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter daCust = null;
        SqlDataAdapter daProd = null;
        DataSet dsCust = null;
        DataSet dsProd = null;
        int dgIndex = -1;


        public Form1()
        {
            InitializeComponent();
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tab event handler
            tab.SelectedIndexChanged += new EventHandler(tab_SelectedIndexChanged);

            //when you click on a row in dgv1 it will populate the text fields with the info from the table 
            
            //Customer Tab
            dgv1.Click += new EventHandler(dgv1_Click);
            dgv1.KeyDown += new KeyEventHandler(dgv1_KeyDown);
            
            //Product Tab
            dgv2.Click += new EventHandler(dgv2_Click);
            dgv2.KeyDown += new KeyEventHandler(dgv2_KeyDown);
           
            //Invoice Tab
            dgInv1.Click += new EventHandler(dgInv1_Click);

            getCustomerData("c");
            buttonStateCustomer("i");

            getProductData("p");

        }

        // Events Handlers

        void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

                if (tab.SelectedTab.Equals(tabCustomer))
                {
                    buttonStateCustomer("i");
                    nextPrimaryKey("c");
                }
                else if (tab.SelectedTab.Equals(tabProduct))
                {
                    buttonStateProduct("i");
                    nextPrimaryKey("p");
                }
        }

            //Customer Tab
        void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            //escape key press to revert back to add mode
            if (e.KeyCode == Keys.Escape)
            {
                removeText();
                buttonStateCustomer("i");
            }
        }

        void dgv1_Click(object sender, EventArgs e)
        {
            //index for update command
            dgIndex = dgv1.CurrentRow.Index;

            //when you click on a row in dgv1 it will populate the text fields with the info from the table
            dgv1.CurrentRow.Selected = true;
            txtCustId.Text = dgv1.CurrentRow.Cells["customerId"].Value.ToString();
            txtFirstname.Text = dgv1.CurrentRow.Cells["firstname"].Value.ToString();
            txtLastname.Text = dgv1.CurrentRow.Cells["lastname"].Value.ToString();
            txtPostal.Text = dgv1.CurrentRow.Cells["postalcode"].Value.ToString();
            txtPhone.Text = dgv1.CurrentRow.Cells["phone"].Value.ToString();
            //txtCustId.ReadOnly = true;
            txtCustId.Enabled = false;

            //go to update mode upon selection of grid entry
            buttonStateCustomer("u/d");
        }

            //Product Tab
        void dgv2_KeyDown(object sender, KeyEventArgs e)
        {
            //escape key press to revert back to add mode
            if (e.KeyCode == Keys.Escape)
            {
                removeText();
                buttonStateProduct("i");
            }
        }

        void dgv2_Click(object sender, EventArgs e)
        {
            //index for update command
            dgIndex = dgv2.CurrentRow.Index;
            
            dgv2.CurrentRow.Selected = true;
            txtProdId.Text = dgv2.CurrentRow.Cells["productId"].Value.ToString();
            txtProdName.Text = dgv2.CurrentRow.Cells["productName"].Value.ToString();
            txtDesc.Text = dgv2.CurrentRow.Cells["description"].Value.ToString();
            txtPrice.Text = dgv2.CurrentRow.Cells["price"].Value.ToString();
            txtQuantity.Text = dgv2.CurrentRow.Cells["quantity"].Value.ToString();
            //txtProdId.ReadOnly = true;
            txtProdId.Enabled = false;
            
            //go to update mode upon selection of grid entry
            buttonStateProduct("u/d");
        }

            //Invoice Tab
        void dgInv1_Click(object sender, EventArgs e)
        {
            //if (invState.Equals("addCust"))
            //{
            //    dgInv1.CurrentRow.Selected = true;
            //    lblInvFName.Text = dgInv1.CurrentRow.Cells["firstname"].Value.ToString();
            //    lblInvLName.Text = dgInv1.CurrentRow.Cells["lastname"].Value.ToString();
            //    lblInvPostal.Text = dgInv1.CurrentRow.Cells["postalcode"].Value.ToString();
            //    lblInvPhone.Text = dgInv1.CurrentRow.Cells["phone"].Value.ToString();
            //}
        }

        // DataGrid & SQL Commands Below

        private void customerSQLCommands()
        {
            //all parameters called when getCustomerData() is loaded through form1_load

            //INSERT
            SqlCommand cmd = new SqlCommand();
            string sql = "INSERT INTO [tCustomer] ([customerId], [firstname], [lastname], [postalcode], [phone]) VALUES (@cid, @fn, @ln, @pc, @pn)";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 10, "customerId");
            cmd.Parameters.Add("@fn", SqlDbType.VarChar, 20, "firstname");
            cmd.Parameters.Add("@ln", SqlDbType.VarChar, 20, "lastname");
            cmd.Parameters.Add("@pc", SqlDbType.VarChar, 10, "postalcode");
            cmd.Parameters.Add("@pn", SqlDbType.VarChar, 15, "phone");
            daCust.InsertCommand = cmd;

            //DELETE
            cmd = new SqlCommand();
            sql = "DELETE FROM [tCustomer] WHERE [customerId] = @cid";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 10, "customerId");
            daCust.DeleteCommand = cmd;

            //UPDATE
            cmd = new SqlCommand();
            sql = "UPDATE [tCustomer] SET [customerId] = @cid, [firstname] = @fn, [lastname] = @ln, [postalcode] = @pc, [phone] = @pn WHERE [customerId] = @cidOrig";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 10, "customerId");
            cmd.Parameters.Add("@fn", SqlDbType.VarChar, 20, "firstname");
            cmd.Parameters.Add("@ln", SqlDbType.VarChar, 20, "lastname");
            cmd.Parameters.Add("@pc", SqlDbType.VarChar, 10, "postalcode");
            cmd.Parameters.Add("@pn", SqlDbType.VarChar, 15, "phone");
            SqlParameter sp = cmd.Parameters.Add("@cidOrig", SqlDbType.VarChar, 10, "customerId");
            sp.SourceVersion = DataRowVersion.Original;
            daCust.UpdateCommand = cmd;

        }

        private void getCustomerData(string s)
        {
            //don't forget to escape slashes
            string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\PROG34998\\finalProject\\Project1\\Store.mdf;Integrated Security=True;User Instance=True";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string sql = "SELECT * FROM [tCustomer]";
                daCust = new SqlDataAdapter(sql, conn);

                customerSQLCommands();

                dsCust = new DataSet();
                daCust.Fill(dsCust, "tCustomer");
                conn.Close();

                //display on Customer Tab / Invoice Tab

                if (s.Equals("c"))
                {
                    bindingSource1.DataSource = dsCust;
                    bindingSource1.DataMember = "tCustomer";
                    dgv1.DataSource = bindingSource1;
                    dgv1.ClearSelection();
                }
                else if (s.Equals("i"))
                {
                    bindingSource3.DataSource = dsCust;
                    bindingSource3.DataMember = "tCustomer";
                    dgInv1.DataSource = bindingSource3;
                    dgInv1.ClearSelection();
                }


            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Retrieving from DataBase");
            }
        }

        private void productSQLCommands()
        {
            //all parameters called when getProductData() is loaded through form1_load

            //INSERT
            SqlCommand cmd = new SqlCommand();
            string sql = "INSERT INTO [tProduct] ([productId], [productName], [description], [price], [quantity]) VALUES (@pid, @pn, @dsc, @prc, @qty)";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pid", SqlDbType.VarChar, 10, "productId");
            cmd.Parameters.Add("@pn", SqlDbType.VarChar, 25, "productName");
            cmd.Parameters.Add("@dsc", SqlDbType.VarChar, 25, "description");
            cmd.Parameters.Add("@prc", SqlDbType.Money, 8, "price");
            cmd.Parameters.Add("@qty", SqlDbType.Int, 4, "quantity");
            daProd.InsertCommand = cmd;

            //DELETE
            cmd = new SqlCommand();
            sql = "DELETE FROM [tProduct] WHERE [productId] = @pid";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pid", SqlDbType.VarChar, 10, "productId");
            daProd.DeleteCommand = cmd;

            //UPDATE
            cmd = new SqlCommand();
            sql = "UPDATE [tProduct] SET [productId] = @cid, [productName] = @pn, [description] = @dsc, [price] = @prc, [quantity] = @qty WHERE [productId] = @pidOrig";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@pid", SqlDbType.VarChar, 10, "productId");
            cmd.Parameters.Add("@pn", SqlDbType.VarChar, 20, "productName");
            cmd.Parameters.Add("@dsc", SqlDbType.VarChar, 20, "description");
            cmd.Parameters.Add("@prc", SqlDbType.VarChar, 10, "price");
            cmd.Parameters.Add("@qty", SqlDbType.VarChar, 15, "quantity");
            SqlParameter sp = cmd.Parameters.Add("@pidOrig", SqlDbType.VarChar, 10, "productId");
            sp.SourceVersion = DataRowVersion.Original;
            daCust.UpdateCommand = cmd;


        }

        private void getProductData(string s)
        {
            string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\PROG34998\\finalProject\\Project1\\Store.mdf;Integrated Security=True;User Instance=True";
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string sql = "SELECT * FROM [tProduct]";
                daProd = new SqlDataAdapter(sql, conn);

                productSQLCommands();

                dsProd = new DataSet();
                daProd.Fill(dsProd, "tProduct");
                conn.Close();

                if (s.Equals("p"))
                {
                    bindingSource2.DataSource = dsProd;
                    bindingSource2.DataMember = "tProduct";
                    dgv2.DataSource = bindingSource2;
                    dgv2.ClearSelection();
                }
                else if (s.Equals("i"))
                {
                    bindingSource3.DataSource = dsProd;
                    bindingSource3.DataMember = "tProduct";
                    dgInv1.DataSource = bindingSource2;
                    dgInv1.ClearSelection();
                }
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Reading Product Record");
            }
        }

        // Customer Tab Buttons Below

        private void cmdAddCustomer_Click(object sender, EventArgs e)
        {

            DataRow dr = dsCust.Tables["tCustomer"].NewRow();
            dr["customerId"] = txtCustId.Text;
            dr["firstname"] = txtFirstname.Text;
            dr["lastname"] = txtLastname.Text;
            dr["postalcode"] = txtPostal.Text;
            dr["phone"] = txtPhone.Text;

            //ds instance from getCustomerData() loaded through formload
            dsCust.Tables["tCustomer"].Rows.Add(dr);

            removeText();
            buttonStateCustomer("s");
        }

        private void cmdUpdateCustomer_Click(object sender, EventArgs e)
        {
            DataRow dr = dsCust.Tables["tCustomer"].Rows[dgIndex];
            dr["customerId"] = txtCustId.Text;
            dr["firstname"] = txtFirstname.Text;
            dr["lastname"] = txtLastname.Text;
            dr["postalcode"] = txtPostal.Text;
            dr["phone"] = txtPhone.Text;

            tabProduct.Enabled = false;
            tabInvoice.Enabled = false;

            buttonStateCustomer("i");
            buttonStateCustomer("s");

        }

            //delete function to be removed once testing is done !!!!
        private void cmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this customer from the database?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                //ds instance from getCustomerData() loaded through formload
                dsCust.Tables["tCustomer"].Rows[dgIndex].Delete();

                buttonStateCustomer("i");
                buttonStateCustomer("s");
            }
        }

        private void cmdSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                daCust.Update(dsCust, "tCustomer");
                conn.Close();
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Saving to the Database");
            }
            finally
            {
                buttonStateCustomer("ds");
            }
        }

        // Product Tab Buttons Below

        private void cmdAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = dsProd.Tables["tProduct"].NewRow();
                dr["productId"] = txtProdId.Text;
                dr["productName"] = txtProdName.Text;
                dr["description"] = txtDesc.Text;
                dr["price"] = String.Format("{0:0.00}", Convert.ToDouble(txtPrice.Text));
                dr["quantity"] = Convert.ToInt32(txtQuantity.Text);

                //ds instance from getPData() loaded through formload
                dsProd.Tables["tProduct"].Rows.Add(dr);

                removeText();
                buttonStateProduct("s");

            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Adding Product Record");
            }
        }

        private void cmdUpdateProduct_Click(object sender, EventArgs e)
        {
            DataRow dr = dsProd.Tables["tProduct"].Rows[dgIndex];
            dr["productId"] = txtProdId.Text;
            dr["productName"] = txtProdName.Text;
            dr["description"] = txtDesc.Text;
            dr["price"] = String.Format("{0:0.00}", Convert.ToDouble(txtPrice.Text));
            dr["quantity"] = Convert.ToInt32(txtQuantity.Text);

        }
        
            //delete function to be removed once testing is done !!!
        private void cmdDeleteProduct_Click(object sender, EventArgs e)
        {
            //ds instance from getCustomerData() loaded through formload
            dsProd.Tables["tProduct"].Rows[dgIndex].Delete();
        }

        private void cmdSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                daProd.Update(dsProd, "tProduct");
                conn.Close();

                buttonStateProduct("ds");
            }
            catch (SqlException ex)
            {
                if (conn != null)
                {
                    conn.Close();
                }
                MessageBox.Show(ex.Message, "Error Saving to the Database");
            }
        }

        // Invoice Tab Buttons Below

        private void cmdInvFindCust_Click(object sender, EventArgs e)
        {
            getCustomerData("i");
            buttonStateInvoice("ac");

        }

        private void cmdInvAddCust_Click(object sender, EventArgs e)
        {

            dgInv1.CurrentRow.Selected = true;
            lblInvFName.Text = dgInv1.CurrentRow.Cells["firstname"].Value.ToString();
            lblInvLName.Text = dgInv1.CurrentRow.Cells["lastname"].Value.ToString();
            lblInvPostal.Text = dgInv1.CurrentRow.Cells["postalcode"].Value.ToString();
            lblInvPhone.Text = dgInv1.CurrentRow.Cells["phone"].Value.ToString();
            //clear datagridview
            dgInv1.DataSource = null;
            
            buttonStateInvoice("sc");
        }

        private void cmdInvFindItem_Click(object sender, EventArgs e)
        {
            getProductData("i");
        }

        // Formatting & Validatons Below

        private int nextPrimaryKey(string s)
        {
            if (s.Equals("c"))
            {
                int totalRows = dsCust.Tables["tCustomer"].Rows.Count;
                totalRows++;
                return totalRows;
            }
            else if (s.Equals("p"))
            {
                int totalRows = dsProd.Tables["tProduct"].Rows.Count;
                totalRows++;
                return totalRows;
            }
            else
            {
                return 0;
            }
        }

        private void removeText()
        {

            txtCustId.Text = "";
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPostal.Text = "";
            txtPhone.Text = "";
            dgv1.ClearSelection();
            //return focus to customer id text field 
            txtCustId.Focus();
            txtProdId.Text = "";
            txtProdName.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            dgv2.ClearSelection();
            txtProdId.Focus();
            txtProdId.Enabled = true;
            txtCustId.Enabled = true;


        }

        private void buttonStateCustomer(string s)
        {
            if (s.Equals("i"))
            {
                lblMsg.Text = "";
                cmdAddCustomer.Enabled = true;
                cmdUpdateCustomer.Enabled = false;
                cmdDeleteCustomer.Enabled = false;
                cmdSaveCustomer.Enabled = false;
                removeText();
                //load next primary key
                txtCustId.Text = nextPrimaryKey("c").ToString();

            }
            else if (s.Equals("u/d"))
            {
                lblMsg.Text = "Press ESC to leave edit mode";
                cmdAddCustomer.Enabled = false;
                cmdUpdateCustomer.Enabled = true;
                cmdDeleteCustomer.Enabled = true;
            }
            else if (s.Equals("s"))
            {
                cmdSaveCustomer.Enabled = true;
                cmdSaveCustomer.Text = "Changes Made - Save";
                lblMsg.Text = "Changes have been made, remember to click save";
                //load next primary key
                txtCustId.Text = nextPrimaryKey("c").ToString();
            }
            else if (s.Equals("ds"))
            {
                cmdSaveCustomer.Enabled = false;
                lblMsg.Text = "";
                cmdSaveCustomer.Text = "No Changes - Save";
            }
        }

        private void buttonStateProduct(string s)
        {

            if (s.Equals("i"))
            {
                lblMsg2.Text = "";
                cmdAddProduct.Enabled = true;
                cmdUpdateProduct.Enabled = false;
                cmdDeleteProduct.Enabled = false;
                cmdSaveProduct.Enabled = false;
                removeText();
                //load next primary key
                txtProdId.Text = nextPrimaryKey("p").ToString();
            }
            else if (s.Equals("u/d"))
            {
                lblMsg2.Text = "Press ESC to leave edit mode";
                cmdAddProduct.Enabled = false;
                cmdUpdateProduct.Enabled = true;
                cmdDeleteProduct.Enabled = true;
            }
            else if (s.Equals("s"))
            {
                cmdSaveProduct.Enabled = true;
                cmdSaveProduct.Text = "Changes Made - Save";
                lblMsg2.Text = "Changes have been made, remember to click save";
                //load next primary key
                txtProdId.Text = nextPrimaryKey("p").ToString();
            }
            else if (s.Equals("ds"))
            {
                cmdSaveProduct.Enabled = false;
                lblMsg2.Text = "";
                cmdSaveProduct.Text = "No Changes - Save";
            }
        }

        private void buttonStateInvoice(string s)
        {
            if (s.Equals("ac"))
            {
                cmdInvFindCust.Enabled = false;
                cmdInvAddCust.Enabled = true;
            }
            if (s.Equals("sc"))
            {
                cmdInvFindCust.Enabled = true;
                cmdInvAddCust.Enabled = false;
                cmdInvFindItem.Enabled = true;
            }
        }

    }
}
