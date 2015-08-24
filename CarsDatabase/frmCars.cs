using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();            
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);
        }

        private void tblCarBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            position();            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            position();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            position();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            position();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            position();
        }

        private void position()
        {
            textCounter.Text = ((tblCarBindingSource.Position + 1) + " of " + tblCarBindingSource.Count);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textReg.Text != "")
                {
                    this.Validate();
                    //hireDataSet.AcceptChanges();
                    this.tblCarBindingSource.EndEdit();
                    this.tblCarTableAdapter.Update(this.hireDataSet.tblCar);
                    MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration field must contain a value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error in Update: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblCarBindingSource.EndEdit();

                this.hireDataSet.tblCar.AddtblCarRow("REG", null, null, DateTime.Now, 0, false);

                this.tblCarBindingSource.MoveLast();
                position();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Adding Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblCarBindingSource.EndEdit();

                hireDataSet.tblCar.FindByVehicleRegNo(textReg.Text).Delete();

                position();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting Row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                hireDataSet.RejectChanges();
                tblCarBindingSource.ResetBindings(false);
                position();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.Show();
        }

    }
}
