using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theater
{
    /// Класс "Зал"
    public class Hall
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
    }

    /// Класс "Сектора зала"
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

    public class Spectacle
    {
        private DateTime performanceDate;
        private String name;
        private Double basePrice;
        private Int32 hallNumber;
    }

    public abstract class Ticket
    {
        private Int32 number;
        private Int32 row;
        private Int32 seat;
        private Double calculatedPrice;
        private Boolean reserved;
    }

    public class NormalTicket : Ticket
    {

    }

    public class SaleTicket : NormalTicket
    {

    }

    public class VIPTicket : NormalTicket
    {

    }
}
