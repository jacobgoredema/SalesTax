using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTax
{
    public partial class frmSalesTaxCalculator : Form
    {
        public frmSalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salesAmount;
            const double stateTax = 0.04; // 4% 
            const double countyTax = 0.02; //2%
            double totalSalesTax;
            double totalSales;
            double totalStateTax;
            double totalCountyTax;

            salesAmount = Convert.ToDouble(txtSalesAmount.Text);
            totalStateTax = salesAmount * stateTax;
            totalCountyTax = salesAmount * countyTax;
            totalSalesTax = totalStateTax + totalCountyTax;

            totalSales = totalStateTax + salesAmount;

            lstOutput.Items.Add("Sales Amount: " + salesAmount.ToString("C"));
            lstOutput.Items.Add("State Tax:" + totalStateTax.ToString("C"));
            lstOutput.Items.Add("County Tax: " + totalCountyTax.ToString("C"));
            lstOutput.Items.Add("Total Sales Tax: " + totalSalesTax.ToString("C"));
            lstOutput.Items.Add("Total Amount" + totalSales.ToString("C"));
        }
    }
}
