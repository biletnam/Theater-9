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
    public partial class editHall : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Изменяемый зал
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

        public editHall(Hall hall)
        {
            InitializeComponent();

            // Сохраняем зал
            this.hall = hall;

            // Устанавливаем иконки
            setIcons();
            // Выводим номер и название зала
            showHall();
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
            sectorToolStripMenuItem.Image = icons.sector.ToBitmap();
            addSectorToolStripMenuItem.Image = icons.addRecord.ToBitmap();
            editSectorToolStripMenuItem.Image = icons.editRecord.ToBitmap();
            removeSectorToolStripMenuItem.Image = icons.removeRecord.ToBitmap();
        }

        // Вывод номера и названия зала
        private void showHall()
        {
            textBox_number.Text = Convert.ToString(hall.Number);
            textBox_name.Text = hall.Name;
        }

        // Инициализация таблицы
        private void initializeDataGridView()
        {
            dataGridView_sectors.ColumnCount = 4;
            dataGridView_sectors.Columns[0].Name = "Название";
            dataGridView_sectors.Columns[1].Name = "Надбавка";
            dataGridView_sectors.Columns[2].Name = "Начальное место";
            dataGridView_sectors.Columns[3].Name = "Конечное место";

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_sectors.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Вывод данных на таблицу
        private void showSectorsOnDataGridView()
        {
            dataGridView_sectors.Rows.Clear();

            foreach (Sector seсtor in hall.Sectors)
            {
                string[] newRow = new string[] { Convert.ToString(seсtor.Name),
                                                 Convert.ToString(seсtor.Rate),
                                                 Convert.ToString(seсtor.StartSeat),
                                                 Convert.ToString(seсtor.EndSeat) };
                dataGridView_sectors.Rows.Add(newRow);
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

        private void addSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления сектора зала
            addSector newForm = new addSector(hall);
            newForm.ShowDialog(this);

            // Возвращаем данные
            if (newForm.IfNotLeft)
                hall = newForm.Hall;

            showSectorsOnDataGridView();
            lockEditAndRemoveSector();
        }

        private void editSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения сектора зала
            editSector newForm = new editSector(hall, dataGridView_sectors.CurrentRow.Index);
            newForm.ShowDialog(this);

            // Возвращаем данные
            if (newForm.IfNotLeft)
                hall = newForm.Hall;

            showSectorsOnDataGridView();
            lockEditAndRemoveSector();
        }

        // Удаление сектора из зала
        private void removeSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hall.removeSector(dataGridView_sectors.CurrentRow.Index);
            showSectorsOnDataGridView();
            lockEditAndRemoveSector();
        }

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

            // Устанавливаем данные для передачи
            ifNotLeft = true;
            hall.Name = textBox_name.Text;

            this.Close();
        }

        // Если строка в таблице не выбрана, то отключаем возможность редактирования и удаления из меню
        private void lockEditAndRemoveSector()
        {
            if (dataGridView_sectors.CurrentRow != null)
            {
                editSectorToolStripMenuItem.Enabled = true;
                removeSectorToolStripMenuItem.Enabled = true;
            }
            else
            {
                editSectorToolStripMenuItem.Enabled = false;
                removeSectorToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView_sectors_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveSector();
        }

        private void dataGridView_sectors_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveSector();
        }
    }
}
