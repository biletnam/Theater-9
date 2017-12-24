﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    /// Интерфейс для глубокого копирования
    public interface ICloneable
    {
        object Clone();
    }

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
        // Устанвка сектора заместо указанного по индексу sectorIndex
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

        /// Глубокое копирование
        public object Clone()
        {
            List<Sector> sectors = new List<Sector>(this.Sectors);
            return new Hall {
                Number = this.Number,
                Name = this.Name,
                Sectors = sectors};
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
    public class Spectacle
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
        public Spectacle(DateTime performanceDate, String name, Double basePrice, Int32 hallNumber, List<Ticket> tickets)
        {
            this.performanceDate = DateTime.Now;
            this.name = "";
            this.basePrice = 0.0;
            this.hallNumber = -1;
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

        
    }

    /// Абстрактный класс "Билет"
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
        protected void changeStatus()
        {
            reserved = !reserved;
        }

        // Подсчет стоимости билета в зависимости от типа
        protected abstract void calculatePrice(Double basePrice, Double rate);
    }
    
    /// Класс "Обычный билет"
    public class NormalTicket : Ticket
    {
        protected override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate;
        }
    }
    
    /// Класс "Билет со скидкой"
    public class SaleTicket : NormalTicket
    {
        private Double sale;                // Размер скидки

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
        protected override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate * sale;
        }
    }

    /// Класс "VIP билет"
    public class VIPTicket : NormalTicket
    {
        private Double additionalCost;      // Дополнительная стоимоть доп. услуги по VIP билету
        private String additionalService;   // Содержание доп. услуги по VIP билету
        
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
        protected override void calculatePrice(Double basePrice, Double rate)
        {
            calculatedPrice = basePrice * rate + additionalCost;
        }
    }
}
