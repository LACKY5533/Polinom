using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynomial
{
    public partial class MainMenu : Form
    {

        StartScreen f;

        Polynomial obMain; // Коэфициенты, полученные из предыдущего окна

        public MainMenu(StartScreen frm) // Конструктор класса с передачей интерфейса
        {
            InitializeComponent();
            f = frm;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            double[] IntKoefs = (double[])f.IntKoefs.Clone(); // Передача из предыдущей формы значений
            obMain = new Polynomial(IntKoefs);
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string[] strKoefs = textBoxSum.Text.Split(','); // Строковые версии коэффициентов
            double[] intKoefs = new double[strKoefs.Length]; // Числовые версии коэффициентов
            bool ifParsed; // Рабочая; Переманная показывает, что строку правильно спарсили
            bool resultParsed = true; // Результат парсинга

            for (int i = 0; i < strKoefs.Length; i++)
            {
                ifParsed = double.TryParse(strKoefs[i], out intKoefs[i]);
                if (ifParsed == false)
                {
                    MessageBox.Show("Один или несколько введенных элементов не соответсвуют требованиям", "Ошибка 1", MessageBoxButtons.OK);
                    resultParsed = false;
                    break;
                }
            }

            if (intKoefs.Length < 2)
                MessageBox.Show("Слишком мало введенных элементов", "Ошибка 2", MessageBoxButtons.OK);
            else if (resultParsed == true)
            {
                Polynomial obSum, obTmp; // Полином суммы и временный полином
                obTmp = new Polynomial(intKoefs);
                obSum = obMain + obTmp;
                MessageBox.Show(obSum.ToString(), "Результат", MessageBoxButtons.OK);
            }
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            string[] strKoefs = textBoxSum.Text.Split(','); // Строковые версии коэффициентов
            double[] intKoefs = new double[strKoefs.Length]; // Числовые версии коэффициентов
            bool ifParsed; // Рабочая; Переманная показывает, что строку правильно спарсили
            bool resultParsed = true; // Результат парсинга

            for (int i = 0; i < strKoefs.Length; i++)
            {
                ifParsed = double.TryParse(strKoefs[i], out intKoefs[i]);
                if (ifParsed == false)
                {
                    MessageBox.Show("Один или несколько введенных элементов не соответсвуют требованиям", "Ошибка 1", MessageBoxButtons.OK);
                    resultParsed = false;
                    break;
                }
            }

            if (intKoefs.Length < 2)
                MessageBox.Show("Слишком мало введенных элементов", "Ошибка 2", MessageBoxButtons.OK);
            else if (resultParsed == true)
            {
                Polynomial obSubstr, obTmp; // Полином разности и временный полином
                obTmp = new Polynomial(intKoefs);
                obSubstr = obMain - obTmp;
                MessageBox.Show(obSubstr.ToString(), "Результат", MessageBoxButtons.OK);
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string[] strKoefs = textBoxSum.Text.Split(','); // Строковые версии коэффициентов
            double[] intKoefs = new double[strKoefs.Length]; // Числовые версии коэффициентов
            bool ifParsed; // Рабочая; Переманная показывает, что строку правильно спарсили
            bool resultParsed = true; // Результат парсинга

            for (int i = 0; i < strKoefs.Length; i++)
            {
                ifParsed = double.TryParse(strKoefs[i], out intKoefs[i]);
                if (ifParsed == false)
                {
                    MessageBox.Show("Один или несколько введенных элементов не соответсвуют требованиям", "Ошибка 1", MessageBoxButtons.OK);
                    resultParsed = false;
                    break;
                }
            }

            if (intKoefs.Length < 2)
                MessageBox.Show("Слишком мало введенных элементов", "Ошибка 2", MessageBoxButtons.OK);
            else if (resultParsed == true)
            {
                Polynomial obMultipl, obTmp; // Полином разности и временный полином
                obTmp = new Polynomial(intKoefs);
                obMultipl = obMain * obTmp;
                MessageBox.Show(obMultipl.ToString(), "Результат", MessageBoxButtons.OK);
            }
        }
    }
}
