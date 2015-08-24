using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");
            cboField.SelectedIndex = 0;
            cboField.DropDownStyle = ComboBoxStyle.DropDownList;

            cboOperator.Items.Add('=');
            cboOperator.Items.Add('<');
            cboOperator.Items.Add('>');
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
            cboOperator.SelectedIndex = 0;
            cboOperator.DropDownStyle = ComboBoxStyle.DropDownList;           
        }

        private void searchSQL2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Hire.mdf;Integrated Security=True");

            string select = String.Format("SELECT * FROM tblCar WHERE {0} {1} '{2}'", cboField.Text, cboOperator.Text, textValue.Text);

            SqlDataAdapter da = new SqlDataAdapter(select, con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void searchSQL()
        {
            if (textValue.Text != null && textValue.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Hire.mdf;Integrated Security=True"))
                {

                    try
                    {
                        con.Open();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error opening SQL connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    try
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;


                        if (textValue.Text.ToUpper() == "YES")
                            textValue.Text = "1";
                        else if (textValue.Text.ToUpper() == "NO")
                            textValue.Text = "0";

                        string select = String.Format("SELECT * FROM tblCar WHERE {0} {1} @Param", cboField.SelectedItem, cboOperator.SelectedItem);

                        SqlParameter myParam = new SqlParameter("@Param", textValue.Text);
                        cmd.Parameters.Add(myParam);

                        cmd.CommandText = select;
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Columns["RentalPerDay"].DefaultCellStyle.Format = "C";
                        dataGridView1.AllowUserToAddRows = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    try
                    {
                        con.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error closing SQL connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Please enter a search value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            searchSQL();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
