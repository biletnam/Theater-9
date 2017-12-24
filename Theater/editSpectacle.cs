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
    public partial class editSpectacle : Form
    {
        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Изменяемый зал
        private Spectacle spectacle;


        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Spectacle Spectacle
        {
            get
            {
                return spectacle;
            }
        }

        public editSpectacle(Spectacle spectacle)
        {
            InitializeComponent();

            // Сохраняем зал
            this.spectacle = spectacle;

            // По умолчанию пользователь не ввел данные
            ifNotLeft = false;
        }
    }
}
