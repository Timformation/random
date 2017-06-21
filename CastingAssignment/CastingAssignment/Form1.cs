using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastingAssignment
{
    public partial class Form1 : Form
    {
        int intA = 100;
        int intB;
        double dblC = 50.5;
        double dblD;
        bool blnFlag = false;
        string strSales = "55.65";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dblD = intA;
            intB = intA;
            txtTotalSales.Text = (double.Parse(strSales) * 2).ToString();
            intB = int.Parse(strSales);
            intB = 22 / 7;
            dblD = intA / 3;
            lblSalesTax.Text = dblD.ToString();
            txtTotalSales.Text = strSales;
            dblD = double.Parse(txtTotalSales.Text);
            dblD = dblC * double.Parse(lblSalesTax.Text);
            txtOutput.Text = blnFlag.ToString();
            txtOutput.Text = (dblC * double.Parse(lblSalesTax.Text) + strSales).ToString("c");

            //Figure out why I can't turn this into $$$. 














        }
    }
}
