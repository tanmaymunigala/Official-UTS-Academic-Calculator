using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Official_UTS_Academic_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.ShowDialog();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addTableRow();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculateWAM();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteTableRow();
        }
        private void addTableRow()
        {

        }
        private void deleteTableRow()
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            setTableRows();
        }
        private void setTableRows()
        {

        }
        private Double calculateWAM()
        {
            Double wam = 0.0;
            wam = wam + ((Double.Parse(textBox3.Text) * Double.Parse(textBox4.Text) + Double.Parse(textBox6.Text) * Double.Parse(textBox7.Text) + Double.Parse(textBox9.Text) * Double.Parse(textBox10.Text) + Double.Parse(textBox12.Text) * Double.Parse(textBox13.Text)) / (Double.Parse(textBox4.Text) + Double.Parse(textBox7.Text) + Double.Parse(textBox10.Text) + Double.Parse(textBox13.Text)));
            label6.Text = wam.ToString();
            return wam;
        }
    }
}
