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
        }

        // Устанавливка иконок
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
        }

        // Изменения зала
        private void editHallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Удаление зала
        private void removeHallToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Показ формы входа, когда форма для работы менеджера закрывается
        private void management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }
    }
}
