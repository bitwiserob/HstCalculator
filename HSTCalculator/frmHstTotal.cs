using System;
using System.Windows.Forms;

namespace HstCalculator
{
    public partial class frmHstTotal : Form
    {
        public frmHstTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Math for calculating hst   
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal hst = .13m;
            decimal hstTotal = subtotal * hst;
            decimal total = subtotal + hstTotal;

            //Setting values in input fields
            txtHst.Text = hst.ToString("p1");
            txtHstTotal.Text = hstTotal.ToString("c");
            txtTotal.Text = total.ToString("c");

            //Focus on the subtotal field
            txtSubtotal.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
