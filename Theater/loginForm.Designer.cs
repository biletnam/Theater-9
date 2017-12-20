namespace Theater
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_login = new System.Windows.Forms.Button();
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(6, 46);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(145, 23);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            // 
            // comboBox_user
            // 
            this.comboBox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Items.AddRange(new object[] {
            "Менеджер",
            "Кассир"});
            this.comboBox_user.Location = new System.Drawing.Point(6, 19);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(145, 21);
            this.comboBox_user.TabIndex = 1;
            this.comboBox_user.SelectedIndexChanged += new System.EventHandler(this.comboBox_user_SelectedIndexChanged);
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(97, 97);
            this.pictureBox_avatar.TabIndex = 2;
            this.pictureBox_avatar.TabStop = false;
            // 
            // groupBox_login
            // 
            this.groupBox_login.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_login.Controls.Add(this.comboBox_user);
            this.groupBox_login.Controls.Add(this.button_login);
            this.groupBox_login.Location = new System.Drawing.Point(115, 22);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(157, 77);
            this.groupBox_login.TabIndex = 4;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Выберите пользователя";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.pictureBox_avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.groupBox_login.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.PictureBox pictureBox_avatar;
        private System.Windows.Forms.GroupBox groupBox_login;
    }
}

