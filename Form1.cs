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

            Matrix<int> matrix = new Matrix<int>(2, 5);
            string from = textBoxFrom.Text;
            char[] fromCgar = from.ToCharArray();
            string to = textBoxTo.Text;
            char[] toCgar = to.ToCharArray();
            bool flag = false;
            foreach (char c in fromCgar) {
                if (c == ',') flag = true;
            }
            foreach (char c in toCgar) {
                if (c == ',') flag = true;
            }
            if (flag)
            {

            }
            else
            {

            }
            //matrix.FillMatrixRandom(from, to);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
