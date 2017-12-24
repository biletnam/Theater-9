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
    public partial class addSpectacle : Form
    {
        // Список залов
        private List<Hall> halls;
        // Список спектаклей
        private List<Spectacle> spectacles;

        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Новый зал
        private Spectacle newSpectacle;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Spectacle NewSpectacle
        {
            get
            {
                return newSpectacle;
            }
        }

        public addSpectacle(List<Hall> halls, List<Spectacle> spectacles)
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.addRecord;

            // Устанавливаем данные
            this.halls = halls;
            this.spectacles = spectacles;

            // Заполняем combBox
            fillComboBox();

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
            newSpectacle = new Spectacle();
        }

        private void fillComboBox()
        {
            foreach (Hall hall in halls)
                comboBox_hall.Items.Add(hall.Name);

            if (halls.Count == 0)
            {
                comboBox_hall.Enabled = false;
                button_add.Enabled = false;
            }
            else
                comboBox_hall.SelectedIndex = 0;
        }

        // Проверка вводимого названия спектакля
        private bool nameValidator(String name)
        {
            if (name.Length > 2)
                return true;
            else
                return false;
        }

        // Проверка вводимой надбавки
        private bool priceValidator(String rate)
        {
            double currentPrice;

            // Проверка на пустоту
            if (rate.Length == 0)
                return false;

            // Проверка на правильный формат и переполнение
            try
            {
                currentPrice = Convert.ToDouble(rate);
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }

            // Проверка на отрицательность
            if (currentPrice < 0)
                return false;

            return true;
        }

        // Фокус на следующий элемент формы по нажатию enter'а на текущем
        private void dateTimePicker_perfomanceDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_name.Focus();
        }
        private void textBox_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_baseTicketPrice.Focus();
        }
        private void textBox_baseTicketPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                comboBox_hall.Focus();
        }
        private void comboBox_hall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_add.Focus();
        }

        // Добавление спектакля
        private void button_add_Click(object sender, EventArgs e)
        {
            if (!nameValidator(textBox_name.Text))
            {
                MessageBox.Show(this,
                                "В названии зала допущена ошибка: название должно быть длиной более двух символов",
                                "Название зала введено некорректно",
                                MessageBoxButtons.OK);
                textBox_name.Focus();
                return;
            }

            if (!priceValidator(textBox_baseTicketPrice.Text))
            {
                MessageBox.Show(this,
                                "Базовая цена билета должна быть введена в формате 0.000, не может быть отрицательной и/или пустой",
                                "Базовая цена билета была введена некорректно",
                                MessageBoxButtons.OK);
                textBox_baseTicketPrice.Focus();
                return;
            }

            // Устанавливаем данные для передачи
            ifNotLeft = true;
            newSpectacle = new Spectacle(dateTimePicker_perfomanceDate.Value, textBox_name.Text, Convert.ToDouble(textBox_baseTicketPrice.Text), halls[comboBox_hall.SelectedIndex].Number);

            this.Close();
        }
    }
}
