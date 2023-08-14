using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anketa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            listBox1.Items.Add($"{name} {lastName} {email} {phone}");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
