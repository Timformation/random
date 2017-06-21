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
            //1
            dblD = intA;
            //2
            intB = intA;
            //3
            txtTotalSales.Text = (double.Parse(strSales) * 2).ToString();
            //4
            intB = int.Parse(strSales);
            //5
            intB = 22 / 7;
            //6
            dblD = intA / 3;
            //7
            lblSalesTax.Text = dblD.ToString();
            //8
            txtTotalSales.Text = strSales;
            //9
            dblD = double.Parse(txtTotalSales.Text);
            //10
            dblD = dblC * double.Parse(lblSalesTax.Text);
            //11
            txtOutput.Text = blnFlag.ToString();
            //12
            txtOutput.Text = (dblC * double.Parse(lblSalesTax.Text) + double.Parse(strSales)).ToString("c");
            //13
            txtOutput.Text = double.Parse(strSales).ToString("p1");
            //14
            txtTotalSales.Text = double.Parse(lblSalesTax.Text).ToString("c");
            //15
            txtTotalSales.Text = "The total is "+ double.Parse(strSales) +" dollars".ToString();
            //16
            txtTotalSales.Text = "The total is " + dblC + " dollars";
            //17
            ("A circle with the radius " + dblC + " is " + dblC * dblC * Math.PI).ToString();






















        }
    }
}
