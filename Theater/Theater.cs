using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    /// Класс "Зал"
    [Serializable]
    public class Hall : ICloneable
    {
        public Int32 number;            // Идетификатор зала
        private String name;            // Название зала
        private List<Sector> sectors;   // Список секторов входящих в этот зал

        /// Конструкторы
        public Hall()
        {
            number = 0;
            name = "";
            sectors = new List<Sector>();
        }
        public Hall(Int32 number, String name)
        {
            this.number = number;
            this.name = name;
            sectors = new List<Sector>();
        }

        /// Свойства для получения/установки значения поля
        public Int32 Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0 || value > Int32.MaxValue)
                    throw new ArgumentOutOfRangeException($"Значение идентификатора зала должно быть между 0 и {Int32.MaxValue}");
                number = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value.Length > 0) ? value : "Не задано";
            }
        }
        public List<Sector> Sectors
        {
            get
            {
                return sectors;
            }
            set
            {
                sectors = value;
            }
        }

        /// Методы для работы с секторами зала
        // Добавление нового сектора в зал
        // true - добавление произошло успешно, false - неуспешно
        public bool addSector(Sector newSector)
        {
            // Проверяем, чтобы места нового сектора не пересекались
            // с местами секторов уже добавленных в зал

            // Номера секторов не должны быть отрицательными
            if (newSector.StartSeat < 0 || newSector.EndSeat < 0)
            {
                return false;
            }

            // Если секоров ещё нет, то сразу добавляем новый сектора
            if (sectors.Count == 0)
            {
                sectors.Add(newSector);
                return true;
            }

            // Далее проверяем на пересечения
            for (int i = 0; i < sectors.Count; i++)
            {
                if ((newSector.StartSeat < sectors[i].StartSeat && newSector.EndSeat < sectors[i].StartSeat) ||
                    (newSector.StartSeat > sectors[i].EndSeat && newSector.EndSeat > sectors[i].EndSeat))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            // После проверок добавляем новый сектор
            sectors.Add(newSector);

            return true;
        }
        // Получение сектора по индексу
        // null - получение произошло неуспешно
        public Sector getSector(Int32 index)
        {
            if (index < 0 || index >= sectors.Count)
            {
                return null;
            }

            return sectors[index];
        }
        // Установка сектора заместо указанного по индексу sectorIndex
        // true - добавление произошло успешно, false - неуспешно
        public bool setSector(Sector newSector, Int32 sectorIndex)
        {
            // Проверяем, чтобы места нового сектора не пересекались
            // с местами секторов уже добавленных в зал

            // Номера секторов не должны быть отрицательными
            if (newSector.StartSeat < 0 || newSector.EndSeat < 0)
            {
                return false;
            }

            // Если секоров ещё нет, то сразу выходим, т. к. заменять нечего
            if (sectors.Count == 0)
            {
                return false;
            }

            // Далее проверяем на пересечения
            for (int i = 0; i < sectors.Count; i++)
            {
                // Но не учитываем индекс заменяемого сектора зала
                if (i == sectorIndex)
                    continue;

                // Проверяем
                if ((newSector.StartSeat < sectors[i].StartSeat && newSector.EndSeat < sectors[i].StartSeat) ||
                    (newSector.StartSeat > sectors[i].EndSeat && newSector.EndSeat > sectors[i].EndSeat))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            // После проверок изменяем сектор
            sectors[sectorIndex] = newSector;

            return true;
        }
        // Удаление сектора по индексу
        // true - удаление произошло успешно, false - неуспешно
        public bool removeSector(Int32 index)
        {
            if (index < 0 || index >= sectors.Count)
            {
                return false;
            }

            // После проверок удаляем сектор
            sectors.RemoveAt(index);

            return true;
        }

        // Получить количество всех мест в зале
        public Int32 getTotalSeats()
        {
            Int32 counter = 0;
            for (int i = 0; i < sectors.Count; i++)
                counter += sectors[i].EndSeat - sectors[i].StartSeat + 1;
            return counter;
        }

        // Получить все места в зале
        public List<Int32> getSeats()
        {
            List<Int32> temp = new List<int>();

            foreach (Sector sector in sectors)
                for (int i = sector.StartSeat; i <= sector.EndSeat; i++)
                    temp.Add(i);

            // Сортируем их
            temp.Sort();

            return temp;
        }

        /// Глубокое копирование
        public object Clone()
        {
            List<Sector> sectors = new List<Sector>(this.Sectors);
            return new Hall
            {
                Number = this.Number,
                Name = this.Name,
                Sectors = sectors
            };
        }
    }

    /// Класс "Сектора зала"
    [Serializable]
    public class Sector
    {
        private String name;        // Название сектора зала
        private Double rate;        // Надбавка за сектор к базовой цене спектакля
        private Int32 startSeat;    // Начальное место сектора
        private Int32 endSeat;      // Конечное место сектора

        /// Конструкторы
        public Sector()
        {
            name = "";
            rate = 1.0;
            startSeat = 0;
            endSeat = 0;
        }
        public Sector(String name, Double rate, Int32 startSeat, Int32 endSeat)
        {
            this.name = name;
            this.rate = rate;
            this.startSeat = startSeat;
            this.endSeat = endSeat;
        }

        /// Свойства для получения/установки значения поля
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value.Length > 0) ? value : "Не задано";
            }
        }
        public Double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = (value < 0) ? 0 : value;
            }
        }
        public Int32 StartSeat
        {
            get
            {
                return startSeat;
            }
            set
            {
                rate = (value < 0) ? 0 : value;
            }
        }
        public Int32 EndSeat
        {
            get
            {
                return endSeat;
            }
            set
            {
                rate = (value < startSeat) ? startSeat : value;
            }
        }
    }

    /// Класс "Спектакль"
    [Serializable]
    public class Spectacle : ICloneable
    {
        private DateTime performanceDate;   // Дата выступления
        private String name;                // Название спектакля
        private Double basePrice;           // Базовая стоимость билета на спектакль
        private Int32 hallNumber;           // Номер зала в котором будет проходить выступление
        private List<Ticket> tickets;       // Билеты на спектакль
        
        /// Конструкторы
        public Spectacle()
        {
            performanceDate = DateTime.Now;
            name = "";
            basePrice = 0.0;
            hallNumber = -1;
            tickets = new List<Ticket>();
        }
        public Spectacle(DateTime performanceDate, String name, Double basePrice, Int32 hallNumber)
        {
            this.performanceDate = performanceDate;
            this.name = name;
            this.basePrice = basePrice;
            this.hallNumber = hallNumber;
            this.tickets = new List<Ticket>();
        }

        /// Свойства для получения/установки значения поля
        public DateTime PerformanceDate
        {
            get
            {
                return performanceDate;
            }
            set
            {
                performanceDate = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value.Length > 0) ? value : "Не задано";
            }
        }
        public Double BasePrice
        {
            get
            {
                return basePrice;
            }
            set
            {
                basePrice = (value < 0) ? 0 : value;
            }
        }
        public Int32 HallNumber
        {
            get
            {
                return hallNumber;
            }
            set
            {
                hallNumber = (value < 0) ? -1 : value;
            }
        }
        public List<Ticket> Tickets
        {
            get
            {
                return tickets;
            }
            set
            {
                tickets = value;
            }
        }

        // Добавить билет
        public void addTicket(Ticket newTicket)
        {
            tickets.Add(newTicket);
        }

        // Изменить статус резрвирования билета с индексом ticketIndex
        public void changeTicketStatus(Int32 ticketIndex)
        {
            tickets[ticketIndex].changeStatus();
        }

        // Удалить билет с индексом ticketIndex
        public void removeTicket(Int32 ticketIndex)
        {
            tickets.RemoveAt(ticketIndex);
        }

        // Удалить все билеты
        public void removeTickets()
        {
            tickets.Clear();
        }

        // Получить прибыль с билетов
        public Double getProfit()
        {
            Double profit = 0.0;

            foreach (Ticket ticket in tickets)
                profit += ticket.CalculatedPrice;

            return profit;
        }

        /// Глубокое копирование
        public object Clone()
        {
            List<Ticket> tickets = new List<Ticket>(this.Tickets);
            return new Spectacle
            {
                PerformanceDate = this.PerformanceDate,
                Name = this.Name,
                BasePrice = this.BasePrice,
                HallNumber = this.HallNumber,
                Tickets = tickets
            };
        }
    }

    /// Абстрактный класс "Билет"
    [Serializable]
    public abstract class Ticket
    {
        protected Int32 number;           // Уникальный номер билета
        protected Int32 seat;             // Место
        protected Double calculatedPrice; // Стоимость билета
        protected Boolean reserved;       // Билет только забронирован или уже куплен

        /// Конструкторы
        public Ticket()
        {
            number = 0;
            seat = -1;
            calculatedPrice = 0.0;
            reserved = false;
        }
        public Ticket(Int32 number, Int32 seat, Double calculatedPrice, Boolean reserved)
        {
            this.number = number;
            this.seat = seat;
            this.calculatedPrice = calculatedPrice;
            this.reserved = reserved;
        }

        /// Свойства для получения/установки значения поля
        public Int32 Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0 || value > Int32.MaxValue)
                    throw new ArgumentOutOfRangeException($"Значение идентификатора зала должно быть между 0 и {Int32.MaxValue}");
                number = value;
            }
        }
        public Int32 Seat
        {
            get
            {
                return seat;
            }
            set
            {
                seat = (value < 0) ? 0 : value;
            }
        }
        public double CalculatedPrice
        {
            get
            {
                return calculatedPrice;
            }
            set
            {
                calculatedPrice = (value < 0) ? -1 : value;
            }
        }
        public bool Reserved
        {
            get
            {
                return reserved;
            }
            set
            {
                reserved = value;
            }
        }

        // Сменить статус резервирования билета на противоположный
        public void changeStatus()
        {
            reserved = !reserved;
        }

        // Подсчет стоимости билета в зависимости от типа
        public abstract void calculatePrice(Double basePrice, Double rate);
    }

    /// Класс "Обычный билет"
    [Serializable]
    public class NormalTicket : Ticket
    {
        /// Конструкторы
        public NormalTicket() : base()
        {
        }
        public NormalTicket(Int32 number, Int32 seat, Double calculatedPrice, Boolean reserved) : base(number, seat, calculatedPrice, reserved)
        {
        }

        public override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate;
        }
    }

    /// Класс "Билет со скидкой"
    [Serializable]
    public class SaleTicket : NormalTicket
    {
        private Double sale;                // Размер скидки

        /// Конструкторы
        public SaleTicket() : base()
        {
            sale = 0.0;
        }
        public SaleTicket(Int32 number, Int32 seat, Double sale, Double calculatedPrice, Boolean reserved) : base(number, seat, calculatedPrice, reserved)
        {
            this.sale = sale;
        }

        /// Свойства для получения/установки значения поля
        public Double Sale
        {
            get
            {
                return sale;
            }
            set
            {
                sale = value;
            }
        }

        // Подсчет стоимости билета в зависимости от типа
        public override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate - basePrice * rate * sale;
            if (calculatedPrice < 0)
                calculatedPrice = 0;
        }
    }

    /// Класс "VIP билет"
    [Serializable]
    public class VIPTicket : NormalTicket
    {
        private Double additionalCost;      // Дополнительная стоимоть доп. услуги по VIP билету
        private String additionalService;   // Содержание доп. услуги по VIP билету

        /// Конструкторы
        public VIPTicket() : base()
        {
            additionalCost = 0.0;
            additionalService = "Не задано";
        }
        public VIPTicket(Int32 number, Int32 seat, Double additionalCost, Double calculatedPrice, Boolean reserved, String additionalService) : base(number, seat, calculatedPrice, reserved)
        {
            this.additionalCost = additionalCost;
            this.additionalService = additionalService;
        }

        /// Свойства для получения/установки значения поля
        public Double AdditionalCost
        {
            get
            {
                return additionalCost;
            }
            set
            {
                additionalCost = value;
            }
        }
        public String AdditionalService
        {
            get
            {
                return additionalService;
            }
            set
            {
                additionalService = value;
            }
        }

        // Подсчет стоимости билета в зависимости от типа
        public override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate + additionalCost;
        }
    }
}
