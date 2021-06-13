using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HstCalculator
{
    public partial class frmHstTotal : Form
    {
        //List of provinces
        private string[] provinces = { "ON", "BC", "QC", "AB", "SK", "MB", "YT", "NB", "NS", "NL", "NT", "NU", "PE", };

        //Dictionary with provinces and tax rates
        private Dictionary<string, decimal> provinceRates = new Dictionary<string, decimal>()
            {
                {"ON", .13m},
                {"QC", .05m},
                {"BC", .05m},
                {"AB", .05m},
                {"SK", .05m},
                {"MB", .05m},
                {"YT", .05m},
                {"NB", .15m},
                {"NS", .15m},
                {"NL", .15m},
                {"NT", .05m},
                {"NU", .05m},
                {"PE", .15m},
            };


        public frmHstTotal()
        {
            InitializeComponent();
            foreach (string province in provinces)
            {
                cbProvinces.Items.Add(province);
            }
            cbProvinces.SelectedIndex = 0;
            txtHst.Text = provinceRates[provinces[0]].ToString("p1");
            rdBefore.Checked = true;

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Math for calculating hst   
            if(isValid())
            { 
                decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal hst = provinceRates[provinces[cbProvinces.SelectedIndex]];
                decimal hstTotal = subtotal * hst;
                decimal total;
                //check radio button
                if (rdBefore.Checked)
                {
                    total = subtotal + hstTotal;
                }
                else
                {
                    total = subtotal / (hst + 1);
                }

                //Setting values in input fields
                txtHstTotal.Text = hstTotal.ToString("c");
                txtTotal.Text = total.ToString("c");


                //Focus on the subtotal field
                txtSubtotal.Focus();
            }
        }

        private bool isValid()
        {
            bool valid = true;
            string errorMessage = "";

            errorMessage += IsDecimal(txtSubtotal.Text);
            if (errorMessage != "")
            {
                valid = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return valid;
        }

        private string IsDecimal(string value)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += "Subtotal must be a valid decimal value.\n";
            }
            return msg;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHst.Text = provinceRates[provinces[cbProvinces.SelectedIndex]].ToString("p1");
        }


    }
}
