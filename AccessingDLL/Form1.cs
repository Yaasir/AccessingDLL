using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CreatingDLL;

namespace AccessingDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            try
            {
                txtResult.Text = Convert.ToString(c1.sum(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
