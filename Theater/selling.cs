using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class selling : Form
    {
        // Список залов
        private List<Hall> halls;
        // Список спектаклей
        private List<Spectacle> spectacles;

        public selling()
        {
            InitializeComponent();

            // Инициализируем поля
            halls = new List<Hall>();
            spectacles = new List<Spectacle>();

            // Устанавливаем иконки
            setIcons();
            // Инициализируем таблицу
            initializeDataGridView();
            // Загружаем данные из файла
            DeserializeHalls();
            // Выводим данные на таблицу
            showHallsOnDataGridView();
            // Блокируем изменение залов не выбрав конкретный
            lockEditAndRemoveHall();
        }

        // Установка иконок
        private void setIcons()
        {
            Icon = icons.selling;
            spectacleToolStripMenuItem.Image = icons.spectacle.ToBitmap();
            addSpecToolStripMenuItem.Image = icons.addRecord.ToBitmap();
            editSpecToolStripMenuItem.Image = icons.editRecord.ToBitmap();
            removeSpecToolStripMenuItem.Image = icons.removeRecord.ToBitmap();
        }

        // Инициализация таблицы
        private void initializeDataGridView()
        {
            dataGridView_spectacles.ColumnCount = 7;
            dataGridView_spectacles.Columns[0].Name = "Дата выступления";
            dataGridView_spectacles.Columns[1].Name = "Название";
            dataGridView_spectacles.Columns[2].Name = "Базовая цена";
            dataGridView_spectacles.Columns[3].Name = "Зал";
            dataGridView_spectacles.Columns[4].Name = "Билетов всего";
            dataGridView_spectacles.Columns[5].Name = "Продано";
            dataGridView_spectacles.Columns[6].Name = "Забронировано";

            // Отключаем пользовательскую сортировку
            foreach (DataGridViewColumn column in dataGridView_spectacles.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Вывод данных на таблицу
        private void showHallsOnDataGridView()
        {
            dataGridView_spectacles.Rows.Clear();

            foreach (Spectacle spectacle in spectacles)
            {
                string[] newRow = new string[] { Convert.ToString(spectacle.PerformanceDate),
                                                 Convert.ToString(spectacle.Name),
                                                 Convert.ToString(spectacle.BasePrice),
                                                 getHallName(spectacle.HallNumber),
                                                 Convert.ToString(getTotalSeats(spectacle.HallNumber)),
                                                 Convert.ToString(getSoldTickets(spectacle.Tickets)),
                                                 Convert.ToString(getReservedTickets(spectacle.Tickets)) };
                dataGridView_spectacles.Rows.Add(newRow);
            }
        }

        // Получить название зала по месту
        private String getHallName(Int32 hallNumber)
        {
            for (int i = 0; i < halls.Count; i++)
                if (halls[i].Number == hallNumber)
                    return halls[i].Name;
            return "Не найдено";
        }

        // Получить количество мест в зале
        private Int32 getTotalSeats(Int32 hallNumber)
        {
            for (int i = 0; i < halls.Count; i++)
                if (halls[i].Number == hallNumber)
                    return halls[i].getTotalSeats();
            return 0;
        }

        // Получить количество проданных билетов
        private Int32 getSoldTickets(List<Ticket> tickets)
        {
            Int32 counter = 0;
            foreach (Ticket ticket in tickets)
                if (!ticket.Reserved)
                counter += 1;
            return counter;
        }

        // Получить количество забронированных билетов
        private Int32 getReservedTickets(List<Ticket> tickets)
        {
            Int32 counter = 0;
            foreach (Ticket ticket in tickets)
                if (ticket.Reserved)
                    counter += 1;
            return counter;
        }

        // Сериализация данныx в файл
        private void SerializeHalls()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("halls.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, halls);
            stream.Close();
        }

        // Десериализация данных из файла
        private void DeserializeHalls()
        {
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream("halls.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                halls = (List<Hall>) formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }

        // Если строка в таблице не выбрана, то отключаем возможность редактирования и удаления из меню
        private void lockEditAndRemoveHall()
        {
            if (dataGridView_spectacles.CurrentRow != null)
            {
                editSpecToolStripMenuItem.Enabled = true;
                removeSpecToolStripMenuItem.Enabled = true;
            }
            else
            {
                editSpecToolStripMenuItem.Enabled = false;
                removeSpecToolStripMenuItem.Enabled = false;
            }
        }

        private void dataGridView_spectacles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveHall();
        }

        private void dataGridView_spectacles_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            lockEditAndRemoveHall();
        }

        private void selling_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void addSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму добавления зала
            addSpectacle newForm = new addSpectacle(halls, spectacles);
            newForm.ShowDialog(this);

            // Возвращаем данные
            if (newForm.IfNotLeft)
                spectacles.Add(newForm.NewSpectacle);

            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }

        private void editSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем форму изменения зала
            editSpectacle newForm = new editSpectacle((Spectacle) spectacles[dataGridView_spectacles.CurrentRow.Index].Clone());
            newForm.ShowDialog(this);

            // Возвращаем данные
            if (newForm.IfNotLeft)
                spectacles[dataGridView_spectacles.CurrentRow.Index] = newForm.Spectacle;

            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }

        private void removeSpecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spectacles.RemoveAt(dataGridView_spectacles.CurrentRow.Index);
            showHallsOnDataGridView();
            lockEditAndRemoveHall();
        }
    }
}
