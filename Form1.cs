using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFillRandom_Click(object sender, EventArgs e)
        {
            textBoxValue.Enabled = false;
            buttonEnter.Enabled = false;
            string from = textBoxFrom.Text;
            char[] fromCgar = from.ToCharArray();
            string to = textBoxTo.Text;
            char[] toCgar = to.ToCharArray();
            bool flag = false;
            string columns = textBoxColumnsNum.Text;
            string rows = textBoxRowNums.Text;
            uint colsNum = Convert.ToUInt32(columns);
            uint rowsnum = Convert.ToUInt32(rows);
            foreach (char c in fromCgar)
            {
                if (c == ',') flag = true;
            }
            foreach (char c in toCgar)
            {
                if (c == ',') flag = true;
            }
            if (flag)
            {
                Matrix<double> matrix = new Matrix<double>(colsNum, rowsnum);
                double dblfrom = Convert.ToDouble(from);
                double dblto = Convert.ToDouble(to);
                matrix.FillMatrixRandom(dblfrom, dblto);
            }
            else
            {
                Matrix<int> matrix = new Matrix<int>(2, 5);
                int intfrom = Convert.ToInt32(from);
                int intto = Convert.ToInt32(to);
                matrix.FillMatrixRandom(intfrom, intto);
            }
            buttonFillRandom.Enabled = false;
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBoxFrom.Enabled = false;
            textBoxTo.Enabled = false;
            buttonFillRandom.Enabled = false;
        }
    }
}
