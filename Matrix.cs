using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа_4
{

    internal class Matrix<T>
    {
        uint column;
        uint row;
        public T[,] matrix;
        public Matrix(uint column, uint row)
        {
            this.column = column;
            this.row = row;
            matrix = new T[column, row];
        }
        public void FillMatrixRandom(T from, T to)
        {
            if (from.GetType() != to.GetType() || to.GetType() != typeof(double) || to.GetType() != typeof(int) || from.GetType() != typeof(int) || from.GetType() != typeof(double))
            {
                if (from.GetType() == typeof(double))
                {
                    Random random = new Random();
                    double number = random.NextDouble();
                }
                if (to.GetType() == typeof(int))
                {
                    Random random = new Random();
                    double number = random.Next();
                }
            }
            else
            {
                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

