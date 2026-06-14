using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Практическая_работа_4
{

    internal class Matrix<T>
    {
        int column;
        int row;
        public dynamic[,] matrix;
        public Matrix(int column, int row)
        {
            this.column = column;
            this.row = row;
            matrix = new dynamic[column, row];
        }
        public void FillMatrixRandom(T from, T to, TextBox textBoxMatrix)
        {
            try
            {
                dynamic dfrom = from, dto = to;
                Random random = new Random();
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        matrix[i, j] = random.Next() % (dto - dfrom + 1) + dfrom;
                    }
                }
                string result = "";
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        result += $"{matrix[i, j]}, ";
                    }
                    result += "\n";
                }
                result = result.Substring(0, result.Length - 2);
                textBoxMatrix.Text = result;
            }
            catch (Exception ex)
            {
            }
        }
        int curRow = 1;
        int curColumn = 1;
        public void FillByHands(TextBox textBoxHandCol, TextBox textBoxValue, TextBox textBoxMatrix)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxValue.Text))
                {
                    matrix[curRow - 1, curColumn - 1] = Convert.ToInt32(textBoxValue.Text);
                    curColumn++;
                    if (curColumn > column)
                    {
                        curColumn = 1;
                        curRow++;
                    }
                }
                if (curRow > row)
                {
                    textBoxHandCol.Text = "Заполнение завершено!";
                    string result = "";
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            result += matrix[i, j].ToString().PadLeft(4) + " ";
                        }
                        result += Environment.NewLine;
                    }
                    textBoxMatrix.Text = result;
                    textBoxValue.Enabled = false;
                }
                else
                {
                    textBoxHandCol.Text = $"Строка {curRow}, столбец {curColumn}";
                }
                textBoxValue.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный тип!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxValue.Clear();
            }
            void SaddlePoints()
            {

            }
        }
    }
}
            //if (from.GetType() == to.GetType() && to.GetType() == typeof(double) || from.GetType() == to.GetType() && to.GetType() == typeof(int))
            //{
            //    if (from.GetType() == typeof(double))
            //    {
            //        Random random = new Random();
            //        for (int i = 0; i < column; i++)
            //        {
            //            for (int j = 0; j < row; j++)
            //            {
            //                matrix[i,j] = random.NextDouble()%(Convert.ToDouble(to) - Convert.ToDouble(from) + 1)+ Convert.ToDouble(from);
            //            }
            //        }
            //    }
            //    if (to.GetType() == typeof(int))
            //    {
            //        for (int i = 0; i < column; i++)
            //        {
            //            for (; i < row; i++)
            //            {

            //            }
            //        }
            //        Random random = new Random();
            //        double number = random.Next();
            //    }
            //    Form1.Text = "";

