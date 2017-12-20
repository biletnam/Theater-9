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
    public partial class management : Form
    {
        // Список залов
        private List<Hall> halls = new List<Hall>();

        public management()
        {
            InitializeComponent();

            // Устанавливаем иконки
            setIcons();
            // Инициализируем таблицу
            initializeDataGridView();
            // Выводим данные на таблицу
            showHallsOnDataGridView();
            // Блокируем изменение залов не выбрав конкретный
            lockEditAndRemoveHall();
        }

        // Установка иконок
        private void setIcons()
        {
            Icon = icons.hall;
            hallToolStripMenuItem.Image = icons.hall.ToBitmap();
            addHallToolStripMenuItem.Image = icons.addRecord.ToBitmap();
            editHallToolStripMenuItem.Image = icons.editRecord.ToBitmap();
            removeHallToolStripMenuItem.Image = icons.removeRecord.ToBitmap();
        }

        // Инициализация таблицы
        private void initializeDataGridView()
        {
            dataGridView_halls.ColumnCount = 3;
            dataGridView_halls.Columns[0].Name = "№";
            dataGridView_halls.Columns[1].Name = "Название";
            dataGridView_halls.Columns[2].Name = "Число секторов";

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_halls.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Вывод данных на таблицу
        private void showHallsOnDataGridView()
        {
            dataGridView_halls.Rows.Clear();

            foreach (Hall hall in halls)
            {
                string[] newRow = new string[] { Convert.ToString(hall.Number),
                                                 Convert.ToString(hall.Name),
                                                 Convert.ToString(hall.Sectors.Count) };
                dataGridView_halls.Rows.Add(newRow);
            }
        }

        // Добавление зала
        private void addHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления зала
            addHall newForm = new addHall(halls);
            newForm.ShowDialog(this);

            // Возвращаем данные
            if (newForm.IfNotLeft)
                halls.Add(newForm.NewHall);

            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }

        // Изменения зала
        private void editHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }

        // Удаление зала
        private void removeHallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            halls.RemoveAt(dataGridView_halls.CurrentRow.Index);
            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }

        // Показ формы входа, когда форма для работы менеджера закрывается
        private void management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        // Если строка в таблице не выбрана, то отключаем возможность редактирования и удаления из меню
        private void lockEditAndRemoveHall()
        {
            if (dataGridView_halls.CurrentRow != null)
            {
                editHallToolStripMenuItem.Enabled = true;
                removeHallToolStripMenuItem.Enabled = true;
            }
            else
            {
                editHallToolStripMenuItem.Enabled = false;
                removeHallToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView_halls_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveHall();
        }

        private void dataGridView_halls_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveHall();
        }
    }
}
