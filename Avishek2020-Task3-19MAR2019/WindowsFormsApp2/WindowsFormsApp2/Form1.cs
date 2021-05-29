using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApp2
{
    public partial class frmUserRegistration : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("task3_db");
        static IMongoCollection<DataModel> Collection = db.GetCollection<DataModel>("Task3");

        public void ReadAllDocuments()
        {
            List<DataModel> list = Collection.AsQueryable().ToList<DataModel>();
            dataGridView1.DataSource = list;
            //dataGridView1.ColumnCount = 10;

            //Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (dataGridView1.RowCount > 0)
            {
                
                 txtFName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                //MessageBox.Show("Value Avishek " + txtFName.Text);
                txtMname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtAddress1.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                txtAddress2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                DateDOB.Text = dataGridView1.Rows[0].Cells[5].FormattedValue.ToString();
                ////ataGridView1.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
                txtCity.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                txtState.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                txtCountry.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                txtId.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
                //dataGridView1.Refresh();
            }

        }


        public frmUserRegistration()
        {
            InitializeComponent();
            ReadAllDocuments();
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

            if (txtFName.Text.Equals("")    || 
               // txtMname.Text.Equals("")    || 
                txtLName.Text.Equals("")    ||
                txtAddress1.Text.Equals("") || 
                txtAddress2.Text.Equals("") ||
                txtCity.Text.Equals("")     ||
                txtCountry.Text.Equals("")  ||
                txtState.Text.Equals(""))
            {
                MessageBox.Show("Each box must have an input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            dataEntry = txtFName.Text + "\r\n" + txtMname.Text + "\r\n" + txtLName.Text + "\r\n" + txtAddress1.Text + "\r\n" + txtAddress2.Text + "\r\n" + txtCity.Text + "\r\n" + txtState.Text + "\r\n" +
                txtCountry.Text;
            MessageBox.Show(dataEntry,"Data Entry", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Equals("") ||
              // txtMname.Text.Equals("") ||
               txtLName.Text.Equals("") ||
               txtAddress1.Text.Equals("") ||
               txtAddress2.Text.Equals("") ||
               txtCity.Text.Equals("") ||
               txtCountry.Text.Equals("") ||
               txtState.Text.Equals(""))
            {
                MessageBox.Show("Each box must have an input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }
            else
            {
                // Set the Format type and the CustomFormat string.
                // txtDob.Format = DateTimePickerFormat.Custom;
                // txtDob.CustomFormat = "yyyy/MM/dd";
                DateTime dt;
                String MyString;
                MyString = DateDOB.Value.ToString("yyyy-MM-dd"); 
               
                DateTime oDate;
                DateTime dt1 = new DateTime();

                // oDate = Convert.ToDateTime(MyString);
               // dt1 = Convert.ToDateTime(DateDOB.Value.Day + "/" + DateDOB.Value.Month + "/" + DateDOB.Value.Year);
               // MessageBox.Show(DateDOB.Value.Day + "/" + DateDOB.Value.Month + "/" + DateDOB.Value.Year);



                DataModel record = new DataModel(txtFName.Text,
                                                txtMname.Text,
                                                txtLName.Text,
                                                txtAddress1.Text,
                                                txtAddress2.Text,
                                               //Convert.ToDateTime(DateDOB.Value.ToShortDateString()),
                                                DateDOB.Value,
                                                txtCity.Text,
                                                txtState.Text,
                                                txtCountry.Text);
                Collection.InsertOne(record);
                MessageBox.Show("Record saved successfully. ");
                ReadAllDocuments();

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Equals("") ||
              // txtMname.Text.Equals("") ||
               txtLName.Text.Equals("") ||
               txtAddress1.Text.Equals("") ||
               txtAddress2.Text.Equals("") ||
               txtCity.Text.Equals("") ||
               txtCountry.Text.Equals("") ||
               txtState.Text.Equals(""))
            {
                MessageBox.Show("No record selected for update !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }
            else
            {
                var updateDef = Builders<DataModel>.Update.Set("fname", txtFName.Text)
                                                            .Set("mname", txtMname.Text)
                                                            .Set("lname", txtLName.Text)
                                                            .Set("Add1", txtAddress1.Text)
                                                            .Set("Add2", txtAddress2.Text)
                                                            .Set("DOB", DateDOB.Value.Date)
                                                            .Set("City", txtCity.Text)
                                                            .Set("State", txtState.Text)
                                                            .Set("Country", txtCountry.Text);
           // MessageBox.Show("updateDef"+ updateDef);
                Collection.UpdateOne(record => record.Id == ObjectId.Parse(txtId.Text), updateDef);
                ReadAllDocuments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Equals("") ||
               txtMname.Text.Equals("") ||
               txtLName.Text.Equals("") ||
               txtAddress1.Text.Equals("") ||
               txtAddress2.Text.Equals("") ||
               txtCity.Text.Equals("") ||
               txtCountry.Text.Equals("") ||
               txtState.Text.Equals(""))
            {
                MessageBox.Show("No record selected for deletion !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }
            else
            {
                Collection.DeleteOne(record => record.Id == ObjectId.Parse(txtId.Text));
                ReadAllDocuments();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Hi->" );
           
            txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            DateDOB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtState.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }
    }
}
