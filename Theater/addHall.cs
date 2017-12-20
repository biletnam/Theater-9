using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class addHall : Form
    {
        // Номер зала
        private Int32 number;

        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Новый зал
        private Hall newHall;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Hall NewHall
        {
            get
            {
                return newHall;
            }
        }

        public addHall(List<Hall> halls)
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.addRecord;
            // Генерируем уникальный номер зала
            generateNumber(halls);
            // Выводим этот уникальный номер на форму
            textBox_number.Text = Convert.ToString(number);

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
            newHall = new Hall();
        }

        // Генерация уникального номера зала
        private void generateNumber(List<Hall> halls)
        {
            if (halls.Count == 0)
            {
                number = 1;
                return;
            }
            for (int i = 1; i < Int32.MaxValue; i++)
                for (int j = 0; j < halls.Count; j++)
                    if (i != halls[j].Number)
                    {
                        number = i;
                        return;
                    }
        }

        // Проверка вводимого названия зала
        private bool nameValidator(String name)
        {
            if (name.Length > 2)
                return true;
            else
                return false;
        }

        // Фокус на кнопку добавления по нажатию enter в поле ввода названия
        private void textBox_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_add.Focus();
        }

        // Добавление зала
        private void button_add_Click(object sender, EventArgs e)
        {
            if (!nameValidator(textBox_name.Text))
            {
                MessageBox.Show(this,
                                "В названии зала допущена ошибка: название должно быть длиной более двух символов",
                                "Название зала введено некорректно",
                                MessageBoxButtons.OK);
                return;
            }

            // Устанавливаем данные для передачи
            ifNotLeft = true;
            newHall = new Hall(number, textBox_name.Text);

            this.Close();
        }
    }
}
