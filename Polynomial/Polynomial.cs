using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    class Polynomial
    {
        double[] koeffs; // Коэфициенты класса
        int n; // Количество коэфициентов, определяется само при запуске конструктора

        public int Length // Свойство длины полинома
        {
            get { return koeffs.Length; }
        }

        public double this[int d] // Индексация массива коэффициентов
        {
            get { return koeffs[d]; }
            set { koeffs[d] = value; }
        }

        public Polynomial(double[] koeffs)
        {
            this.koeffs = (double[])koeffs.Clone();
            n = this.koeffs.Length;
        }

        public override string ToString() // Перегрузка "оператора вывода"
        {
            string str = ""; // Выходная строка

            for (int i = Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    str += "(" + this[i].ToString() + ")";
                else if (i == 1)
                    str += "(" + this[i].ToString() + ")" + "x" + " + ";
                else
                    str += "(" + this[i].ToString() + ")" + "x^" + i.ToString() + " + ";
            }

            return str;
        }

        public static Polynomial operator+(Polynomial ob1, Polynomial ob2) // Сложение полиномов
        {
            int maxLength; // Максимальная длина
            int minLength; // Минимальная длина
            int max; // Номер объекта с максимальной длиной
            if (ob1.Length > ob2.Length)
            {
                maxLength = ob1.Length;
                minLength = ob2.Length;
                max = 1;
            }

            else if (ob1.Length < ob2.Length)
            {
                maxLength = ob2.Length;
                minLength = ob1.Length;
                max = 2;
            }

            else
            {
                maxLength = ob1.Length;
                minLength = ob1.Length;
                max = 0;
            }
            Polynomial ob3 = new Polynomial(new double[maxLength]);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    ob3[i] = ob1[i] + ob2[i];
                    continue;
                }

                switch (max)
                {
                    case 0:
                        break;
                    case 1:
                        ob3[i] = ob1[i];
                        break;
                    case 2:
                        ob3[i] = ob2[i];
                        break;
                }
            }
            return ob3;
        }

        public static Polynomial operator -(Polynomial ob1, Polynomial ob2) // Разность полиномов
        {
            int maxLength; // Максимальная длина
            int minLength; // Минимальная длина
            int max; // Номер объекта с максимальной длиной
            if (ob1.Length > ob2.Length)
            {
                maxLength = ob1.Length;
                minLength = ob2.Length;
                max = 1;
            }

            else if (ob1.Length < ob2.Length)
            {
                maxLength = ob2.Length;
                minLength = ob1.Length;
                max = 2;
            }

            else
            {
                maxLength = ob1.Length;
                minLength = ob1.Length;
                max = 0;
            }
            Polynomial ob3 = new Polynomial(new double[maxLength]);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < minLength)
                {
                    ob3[i] = ob1[i] - ob2[i];
                    continue;
                }

                switch (max)
                {
                    case 0:
                        break;
                    case 1:
                        ob3[i] = ob1[i];
                        break;
                    case 2:
                        ob3[i] = -ob2[i];
                        break;
                }
            }
            return ob3;
        }

        public static Polynomial operator *(Polynomial ob1, Polynomial ob2) // Сложение полиномов
        {
            double[] intKoefs = new double[ob1.Length + ob2.Length - 1]; // Новый полином
            for (int i = 0; i < ob1.Length; ++i)
                for (int j = 0; j < ob2.Length; ++j)
                    intKoefs[i + j] += ob1[i] * ob2[j];
            return new Polynomial(intKoefs);
        }
    }
}