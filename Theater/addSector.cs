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
    public partial class addSector : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Зал в который добавляем сектор
        private Hall hall;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Hall Hall
        {
            get
            {
                return hall;
            }
        }

        public addSector(Hall hall)
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.addRecord;

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
            this.hall = hall;
        }

        // Проверка вводимого названия сектора
        private bool nameValidator(String name)
        {
            if (name.Length > 2)
                return true;
            else
                return false;
        }

        // Проверка вводимой надбавки
        private bool rateValidator(String rate)
        {
            double currentRate;

            // Проверка на пустоту
            if (rate.Length == 0)
                return false;

            // Проверка на правильный формат и переполнение
            try
            {
                currentRate = Convert.ToDouble(rate);
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
            if (currentRate < 0)
                return false;

            return true;
        }

        // Фокус на следующий элемент по нажатию enter в текущем поле
        private void textBox_name_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_rate.Focus();
        }

        private void textBox_rate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDown_startSeat.Focus();
        }

        private void numericUpDown_startSeat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                numericUpDown_endSeat.Focus();
        }

        private void numericUpDown_endSeat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_add.Focus();
        }

        // Делаем ограничение прямо на форме на вводимые номера мест
        private void numericUpDown_startSeat_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_endSeat.Minimum = numericUpDown_startSeat.Value;
        }

        private void numericUpDown_endSeat_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown_startSeat.Maximum = numericUpDown_endSeat.Value;
        }

        // Добавляем сектор в зал
        private void button_add_Click(object sender, EventArgs e)
        {
            // Проверяем название зала
            if (!nameValidator(textBox_name.Text))
            {
                MessageBox.Show(this,
                                "В названии зала допущена ошибка: название должно быть длиной более двух символов",
                                "Название зала введено некорректно",
                                MessageBoxButtons.OK);
                textBox_name.Focus();
                return;
            }

            // Проверяем надбавку
            if (!rateValidator(textBox_rate.Text))
            {
                MessageBox.Show(this,
                                "Надбавка должна быть введена в формате 0.000, не может быть отрицательной и/или пустой",
                                "Надбавка введена некорректно",
                                MessageBoxButtons.OK);
                textBox_rate.Focus();
                return;
            }

            // Пробуем добавить новый сектор
            if (!Hall.addSector(new Sector(textBox_name.Text,
                Convert.ToDouble(textBox_rate.Text),
                Convert.ToInt32(numericUpDown_startSeat.Value),
                Convert.ToInt32(numericUpDown_endSeat.Value))))
            {
                MessageBox.Show(this,
                "Начальное место не может быть больше конечного и диапазон мест нового сектора не может пересекаться ни с одним диапазоном мест другого сектора зала",
                "Диапазон мест сектора введен некорректно",
                MessageBoxButtons.OK);
                numericUpDown_startSeat.Focus();
                return;
            }

            // Устанавливаем флаг, что данные введены корректно
            ifNotLeft = true;

            this.Close();
        }
    }
}
