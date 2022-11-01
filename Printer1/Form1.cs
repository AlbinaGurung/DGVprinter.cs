using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DGVPrinterHelper;


namespace Printer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
       DGVPrinter printer = new DGVPrinter();
            printer.Title="DataGridView Report";
            printer.SubTitle=String.Format("Products", printer.SubTitleColor=Color.Black,printer);
            printer.SubTitleFormatFlags=StringFormatFlags.LineLimit|StringFormatFlags.NoClip;
            printer.PageNumberInHeader=false;
            printer.PorportionalColumns=true;
            printer.Footer="List of products";
            printer.FooterSpacing=1;
            printer.PrintPreviewDataGridView(dgv1);
            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Add(ProductNametbx.Text,Quantitytbx.Text,TotalPricetbx.Text);
        }
    }

}
