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
        // Список секторов зала
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

        // Проверка вводимого названия зала
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
    }
}
