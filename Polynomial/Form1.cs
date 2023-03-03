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
    public partial class StartScreen : Form
    {
        public double[] IntKoefs;

        public StartScreen()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strKoefs = textBox.Text.Split(','); // Строковые версии коэффициентов
            IntKoefs = new double[strKoefs.Length]; // Числовые версии коэффициентов
            bool ifParsed; // Рабочая; Переманная показывает, что строку правильно спарсили
            bool resultParsed = true; // Результат парсинга(проверяет являются ли все элементы числами)

            for (int i = 0; i < strKoefs.Length; i++)
            {
                ifParsed = double.TryParse(strKoefs[i], out IntKoefs[i]);
                if (ifParsed == false)
                {
                    MessageBox.Show("Один или несколько введенных элементов не соответсвуют требованиям", "Ошибка 1", MessageBoxButtons.OK);
                    resultParsed = false;
                    break;
                }
            }

            if (IntKoefs.Length < 2)
                MessageBox.Show("Слишком мало введенных элементов", "Ошибка 2", MessageBoxButtons.OK);
            else if (resultParsed == true)
            {
                this.Hide(); // Скрыть это окно
                MainMenu mainMenu = new MainMenu(this); // Объявить новое окно mainMenu
                mainMenu.Closed += (s, args) => this.Close(); // Полностью завершить это окно по закрытии mainMenu
                mainMenu.ShowDialog(); // Показать mainMenu 
            }
        }
    }
}
