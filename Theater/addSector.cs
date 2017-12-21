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
    public partial class addSector : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Новый сектор
        private List<Sector> sectors;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public List<Sector> Sectors
        {
            get
            {
                return sectors;
            }
        }

        public addSector(List<Sector> sectors)
        {
            InitializeComponent();

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
            this.sectors = sectors;
        }
    }
}
