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
    public partial class editSpectacle : Form
    {
        // Список залов
        private List<Hall> halls;

        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Изменяемый зал
        private Spectacle spectacle;


        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Spectacle Spectacle
        {
            get
            {
                return spectacle;
            }
        }

        public editSpectacle(List<Hall> halls, Spectacle spectacle)
        {
            InitializeComponent();

            // Устанавливаем данные
            this.halls = halls;
            this.spectacle = spectacle;

            // Устанавливаем иконки
            setIcons();
            // Выводим номер и название зала
            showSector();
            // Инициализируем таблицу
            initializeDataGridView();
            // Выводим данные на таблицу
            showSectorsOnDataGridView();
            // Блокируем изменение секторов не выбрав конкретный
            lockEditAndRemoveSector();

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
        }

        // Установка иконок
        private void setIcons()
        {
            Icon = icons.editRecord;
            ticketToolStripMenuItem.Image = icons.tickets.ToBitmap();
            addTicketToolStripMenuItem.Image = icons.addRecord.ToBitmap();
            removeTicketToolStripMenuItem.Image = icons.removeRecord.ToBitmap();
        }

        // Вывод полей сектора
        private void showSector()
        {
            dateTimePicker_perfomanceDate.Value = spectacle.PerformanceDate;
            textBox_name.Text = spectacle.Name;
            textBox_baseTicketPrice.Text = Convert.ToString(spectacle.BasePrice);

            // Заполняем combBox
            fillComboBox();
        }

        // Инициализация таблицы
        private void initializeDataGridView()
        {
            dataGridView_tickets.ColumnCount = 5;
            dataGridView_tickets.Columns[0].Name = "Номер";
            dataGridView_tickets.Columns[1].Name = "Тип";
            dataGridView_tickets.Columns[2].Name = "Место";
            dataGridView_tickets.Columns[3].Name = "Цена";
            dataGridView_tickets.Columns[4].Name = "Зарезервирован?";

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_tickets.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Вывод данных на таблицу
        private void showSectorsOnDataGridView()
        {
            dataGridView_tickets.Rows.Clear();

            foreach (Ticket ticket in spectacle.Tickets)
            {
                string[] newRow = new string[] { Convert.ToString(ticket.Number),
                                                 Convert.ToString(ticket.GetType().ToString()),
                                                 Convert.ToString(ticket.Seat),
                                                 Convert.ToString(ticket.CalculatedPrice),
                                                 Convert.ToString(ticket.Reserved ? "Да" : "Нет") };
                dataGridView_tickets.Rows.Add(newRow);
            }
        }

        // Если строка в таблице не выбрана, то отключаем возможность удаления из меню
        private void lockEditAndRemoveSector()
        {
            if (dataGridView_tickets.CurrentRow != null)
            {
                removeTicketToolStripMenuItem.Enabled = true;
            }
            else
            {
                removeTicketToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView_tickets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveSector();
        }

        private void dataGridView_tickets_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveSector();
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
                button_edit.Focus();
        }

        private void fillComboBox()
        {
            foreach (Hall hall in halls)
                comboBox_hall.Items.Add(hall.Name);

            if (halls.Count == 0)
            {
                comboBox_hall.Enabled = false;
                button_edit.Enabled = false;
            }
            else
            {
                for (int i = 0; i < halls.Count; i++)
                    if (halls[i].Number == spectacle.HallNumber)
                    {
                        comboBox_hall.SelectedIndex = i;
                        break;
                    }
            }
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

        // Изменение спектакля
        private void button_edit_Click(object sender, EventArgs e)
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
            spectacle = new Spectacle(dateTimePicker_perfomanceDate.Value, textBox_name.Text, Convert.ToDouble(textBox_baseTicketPrice.Text), halls[comboBox_hall.SelectedIndex].Number);

            this.Close();
        }
    }
}
