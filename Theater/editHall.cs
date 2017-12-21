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
        // Изменяемый зал
        private Hall hall;

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
            // Блокируем изменение залов не выбрав конкретный
            //lockEditAndRemoveHall();
        }

        // Установка иконок
        private void setIcons()
        {
            Icon = icons.editRecord;
            sectorToolStripMenuItem.Image = icons.hall.ToBitmap();
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
            dataGridView_sectors.Columns[2].Name = "Стартовое место";
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

        private void button_add_Click(object sender, EventArgs e)
        {

        }
    }
}
