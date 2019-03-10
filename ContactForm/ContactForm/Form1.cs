using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string dataEntered;

            if (firstName.Text.Equals ( ""))
            {

            }
            */

            MessageBox.Show(firstName.Text + "\r\n" + middleName.Text + "\r\n" + lastName.Text + "\r\n" + address.Text + "\r\n"
                + "\r\n" + dateTime.Value.ToString());


           // MessageBox.Show(textBox2.Text);
           // MessageBox.Show(textBox3.Text);
           // MessageBox.Show(textBox4.Text);
        }

       /*
        private void ShowAll()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
        */

    
    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstName.Clear();
            middleName.Clear();
            address.Clear();
            lastName.Clear();
            firstName.Focus();
        }
    }
}
