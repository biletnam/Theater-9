namespace Theater
{
    partial class addSpectacle
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
            this.dateTimePicker_perfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_baseTicketPrice = new System.Windows.Forms.TextBox();
            this.comboBox_hall = new System.Windows.Forms.ComboBox();
            this.label_perfomanceDate = new System.Windows.Forms.Label();
            this.label_baseTicketPrice = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_hall = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_perfomanceDate
            // 
            this.dateTimePicker_perfomanceDate.Location = new System.Drawing.Point(15, 29);
            this.dateTimePicker_perfomanceDate.Name = "dateTimePicker_perfomanceDate";
            this.dateTimePicker_perfomanceDate.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker_perfomanceDate.TabIndex = 0;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(15, 72);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(257, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_baseTicketPrice
            // 
            this.textBox_baseTicketPrice.Location = new System.Drawing.Point(15, 115);
            this.textBox_baseTicketPrice.Name = "textBox_baseTicketPrice";
            this.textBox_baseTicketPrice.Size = new System.Drawing.Size(257, 20);
            this.textBox_baseTicketPrice.TabIndex = 2;
            // 
            // comboBox_hall
            // 
            this.comboBox_hall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_hall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hall.FormattingEnabled = true;
            this.comboBox_hall.Location = new System.Drawing.Point(15, 158);
            this.comboBox_hall.Name = "comboBox_hall";
            this.comboBox_hall.Size = new System.Drawing.Size(257, 21);
            this.comboBox_hall.TabIndex = 3;
            // 
            // label_perfomanceDate
            // 
            this.label_perfomanceDate.AutoSize = true;
            this.label_perfomanceDate.Location = new System.Drawing.Point(12, 9);
            this.label_perfomanceDate.Name = "label_perfomanceDate";
            this.label_perfomanceDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_perfomanceDate.Size = new System.Drawing.Size(102, 17);
            this.label_perfomanceDate.TabIndex = 4;
            this.label_perfomanceDate.Text = "Дата выступления";
            // 
            // label_baseTicketPrice
            // 
            this.label_baseTicketPrice.AutoSize = true;
            this.label_baseTicketPrice.Location = new System.Drawing.Point(12, 95);
            this.label_baseTicketPrice.Name = "label_baseTicketPrice";
            this.label_baseTicketPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_baseTicketPrice.Size = new System.Drawing.Size(115, 17);
            this.label_baseTicketPrice.TabIndex = 5;
            this.label_baseTicketPrice.Text = "Базовая цена билета";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 52);
            this.label_name.Name = "label_name";
            this.label_name.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_name.Size = new System.Drawing.Size(113, 17);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Название спектакля";
            // 
            // label_hall
            // 
            this.label_hall.AutoSize = true;
            this.label_hall.Location = new System.Drawing.Point(12, 138);
            this.label_hall.Name = "label_hall";
            this.label_hall.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_hall.Size = new System.Drawing.Size(26, 17);
            this.label_hall.TabIndex = 7;
            this.label_hall.Text = "Зал";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 192);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // addSpectacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_hall);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_baseTicketPrice);
            this.Controls.Add(this.label_perfomanceDate);
            this.Controls.Add(this.comboBox_hall);
            this.Controls.Add(this.textBox_baseTicketPrice);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dateTimePicker_perfomanceDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSpectacle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить спектакль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_perfomanceDate;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_baseTicketPrice;
        private System.Windows.Forms.ComboBox comboBox_hall;
        private System.Windows.Forms.Label label_perfomanceDate;
        private System.Windows.Forms.Label label_baseTicketPrice;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_hall;
        private System.Windows.Forms.Button button_add;
    }
}