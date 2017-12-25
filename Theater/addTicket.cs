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
    public partial class addTicket : Form
    {
        // Список залов
        private List<Hall> halls;
        // Изменяемый спектакль
        private Spectacle spectacle;
        // Номер билета
        private Int32 number;

        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Добавляемый билет
        private Ticket newTicket;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Ticket NewTicket
        {
            get
            {
                return newTicket;
            }
        }

        public addTicket(List<Hall> halls, Spectacle spectacle)
        {
            InitializeComponent();

            // Устанавливаем данные
            this.halls = halls;
            this.spectacle = spectacle;

            // Устанавливаем иконку формы
            Icon = icons.addRecord;
            // Генерируем номер билета
            generateTicketNumber();
            // И устанавливаем его на форму
            textBox_number.Text = Convert.ToString(number);
            // Заполняем comboBox'ы
            fillComboBox();

            // Настраиваем дополнительные поля
            this.Size = new Size(300, 300);
            groupBox_sale.Visible = false;
            groupBox_VIP.Visible = false;

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
        }

        private void generateTicketNumber()
        {
            Random rnd = new Random();

            number = Convert.ToInt32(DateTime.Now.Day);
            number *= 100;
            number += Convert.ToInt32(DateTime.Now.Month);
            number *= 10000;
            number += rnd.Next(10000);
        }

        private void fillComboBox()
        {
            comboBox_ticketType.SelectedIndex = 0;

            List<Int32> seats = new List<Int32>();
            foreach (Hall hall in halls)
                if (hall.Number == spectacle.HallNumber)
                {
                    seats = hall.getSeats();
                    break;
                }

            foreach (int seat in seats)
            {
                comboBox_seats.Items.Add(Convert.ToString(seat));
            }

            if (seats.Count == 0)
            {
                comboBox_seats.Enabled = false;
                button_add.Enabled = false;
            }
            else
            {
                comboBox_seats.SelectedIndex = 0;
            }
        }

        // Проверка вводимой цены
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

        // Пересчитать цену билета
        private Ticket recalculatePrice()
        {
            Double rate = 0;

            foreach (Hall hall in halls)
                if (hall.Number == spectacle.HallNumber)
                {
                    Int32 seat = Convert.ToInt32(comboBox_seats.SelectedItem.ToString());
                    foreach (Sector sector in hall.Sectors)
                        if ((sector.StartSeat <= seat) && (sector.EndSeat >= seat))
                            rate = sector.Rate;
                }

            if (comboBox_ticketType.SelectedIndex == 0)
            {

                NormalTicket nt = new NormalTicket(number,
                                                    Convert.ToInt32(comboBox_seats.SelectedItem.ToString()),
                                                    0,
                                                    checkBox_reserved.Checked);
                nt.calculatePrice(spectacle.BasePrice, rate);
                return nt;
            }
            else if (comboBox_ticketType.SelectedIndex == 1)
            {
                if (!priceValidator(textBox_sale.Text))
                {
                    return null;
                }
                SaleTicket st = new SaleTicket( number,
                                                Convert.ToInt32(comboBox_seats.SelectedItem.ToString()),
                                                Convert.ToDouble(textBox_sale.Text),
                                                0,
                                                checkBox_reserved.Checked);
                st.calculatePrice(spectacle.BasePrice, rate);
                return st;
            }
            else if (comboBox_ticketType.SelectedIndex == 2)
            {
                if (!priceValidator(textBox_addCost.Text))
                {
                    return null;
                }
                VIPTicket vipt = new VIPTicket( number,
                                                Convert.ToInt32(comboBox_seats.SelectedItem.ToString()),
                                                Convert.ToDouble(textBox_addCost.Text),
                                                0,
                                                checkBox_reserved.Checked,
                                                textBox_addService.Text);
                vipt.calculatePrice(spectacle.BasePrice, rate);
                return vipt;
            }
            return null;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Ticket ticket = recalculatePrice();
            if (ticket == null)
                textBox_price.Text = "Не все поля заполнены";
            else
                textBox_price.Text = Convert.ToString(ticket.CalculatedPrice);

            // Устанавливаем данные для передачи
            ifNotLeft = true;
            newTicket = ticket;

            this.Close();
        }

        // Автонастройка формы в зависимости от выбора типа билета
        private void comboBox_ticketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox_sale.Visible = false;
            groupBox_VIP.Visible = false;
            if (comboBox_ticketType.SelectedIndex == 0)
            {
                this.Size = new Size(300, 300);
            }
            else
            {
                this.Size = new Size(300, 420);
                if (comboBox_ticketType.SelectedIndex == 1)
                    groupBox_sale.Visible = true;
                else if (comboBox_ticketType.SelectedIndex == 2)
                    groupBox_VIP.Visible = true;
            }
        }

        // Установить цену билета
        private void button_getPrice_Click(object sender, EventArgs e)
        {
            Ticket ticket = recalculatePrice();
            if (ticket == null)
                textBox_price.Text = "Не все поля заполнены";
            else
                textBox_price.Text = Convert.ToString(ticket.CalculatedPrice);
        }
    }
}
