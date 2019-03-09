using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmUserRegistration : Form
    {

        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtMname.Clear();
            txtLName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtState.Clear();
            txtFName.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timTimer_Tick(object sender, EventArgs e)
        {

            txtTimer.Text = Convert.ToString(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string dataEntry;

            if (txtFName.Text.Equals(""))
            {
                MessageBox.Show("Each box must have an input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            dataEntry = txtFName.Text + "\r\n" + txtMname.Text + "\r\n" + txtLName.Text + "\r\n" + txtAddress1.Text + "\r\n" + txtAddress2.Text + "\r\n" + txtCity.Text + "\r\n" + txtState.Text + "\r\n" +
                txtCountry.Text;
            MessageBox.Show(dataEntry,"Data Entry", MessageBoxButtons.OK);

        }
    }
}
