using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_4
{
    public partial class Form1 : Form
    {
        private Matrix<int> matrix;
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
        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            matrix.FillByHands(textBoxHandCol, textBoxValue, textBoxMatrix);
            groupBoxCreateMatrix.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRandom.Enabled = radioButton1.Checked;
        }

        private void labelMethod_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int column = Convert.ToInt32(textBoxColumnsNum.Text);
                int row = Convert.ToInt32(textBoxRowNums.Text);
                matrix = new Matrix<int>(column, row);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неверный тип!");
            }
        }
        private void buttonFillRandom_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxValue.Enabled = false;
                buttonEnter.Enabled = false;
                int from = Convert.ToInt32(textBoxFrom.Text);
                int to = Convert.ToInt32(textBoxTo.Text);
                matrix.FillMatrixRandom(from, to, textBoxMatrix);
            }
            catch (Exception ex)
            {

            }
            //char[] toCgar = to.ToCharArray();
            //bool flag = false;
            //string columns = textBoxColumnsNum.Text;
            //string rows = textBoxRowNums.Text;
            //uint colsNum = Convert.ToUInt32(columns);
            //uint rowsnum = Convert.ToUInt32(rows);
            //foreach (char c in fromCgar)
            //{
            //    if (c == ',') flag = true;
            //}
            //foreach (char c in toCgar)
            //{
            //    if (c == ',') flag = true;
            //}
            //if (flag)
            //{
            //    Matrix<double> matrix = new Matrix<double>(colsNum, rowsnum);
            //    double dblfrom = Convert.ToDouble(from);
            //    double dblto = Convert.ToDouble(to);
            //    matrix.FillMatrixRandom(dblfrom, dblto);
            //}
            //else
            //{
            //    Matrix<int> matrix = new Matrix<int>(2, 5);
            //    int intfrom = Convert.ToInt32(from);
            //    int intto = Convert.ToInt32(to);
            //    matrix.FillMatrixRandom(intfrom, intto);
            //}
            //buttonFillRandom.Enabled = false;
        }

        private void textBoxColumnsNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxHandFill.Enabled = radioButton2.Checked;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Enabled = false;
            radioButton2.Checked = false;
            groupBoxRandom.Enabled = false;
            groupBoxHandFill.Enabled = false;
            textBoxMatrix.Clear();
            textBoxColumnsNum.Clear();
            textBoxRowNums.Clear();
            textBoxFrom.Clear();
            textBoxTo.Clear();
            textBoxHandCol.Text = "Строка 1, столбец 1";
            textBoxValue.Clear();
        }

        private void textBoxHandCol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
