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
    public partial class addSpectacle : Form
    {
        // Список залов
        private List<Hall> halls;
        // Список спектаклей
        private List<Spectacle> spectacles;

        // Флаг того, покинул ли пользователь форму не введя данные
        private bool ifNotLeft;
        // Новый зал
        private Spectacle newSpectacle;

        // Свойства для возврата значений из формы
        public bool IfNotLeft
        {
            get
            {
                return ifNotLeft;
            }
        }
        public Spectacle NewSpectacle
        {
            get
            {
                return newSpectacle;
            }
        }

        public addSpectacle(List<Hall> halls, List<Spectacle> spectacles)
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.addRecord;
        }
    }
}
