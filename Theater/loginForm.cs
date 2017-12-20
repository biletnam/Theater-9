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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.login;
            // И выбираем пользователя
            comboBox_user.SelectedIndex = 1;
        }

        // Смена иконки пользователя согласно выбранному пользователю
        private void comboBox_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_user.SelectedIndex == 0)
                pictureBox_avatar.Image = new Bitmap(images.manager, pictureBox_avatar.Width, pictureBox_avatar.Height);
            else if (comboBox_user.SelectedIndex == 1)
                pictureBox_avatar.Image = new Bitmap(images.cashier, pictureBox_avatar.Width, pictureBox_avatar.Height);
        }

        // Открытие формы для менеджера или кассира в зависимости от выбора
        private void button_login_Click(object sender, EventArgs e)
        {
            if (comboBox_user.SelectedIndex == 0)
            {
                new management().Show(this);
                this.Hide();
            }
            else if (comboBox_user.SelectedIndex == 1)
            {
                /*new management().Show(this);
                this.Hide();*/
            }
        }
    }
}
