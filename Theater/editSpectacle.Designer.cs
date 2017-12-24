namespace Theater
{
    partial class editSpectacle
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
            this.groupBox_tickets = new System.Windows.Forms.GroupBox();
            this.dataGridView_tickets = new System.Windows.Forms.DataGridView();
            this.groupBox_spectacle = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_edit = new System.Windows.Forms.Button();
            this.label_hall = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_baseTicketPrice = new System.Windows.Forms.Label();
            this.label_perfomanceDate = new System.Windows.Forms.Label();
            this.comboBox_hall = new System.Windows.Forms.ComboBox();
            this.textBox_baseTicketPrice = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dateTimePicker_perfomanceDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox_tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).BeginInit();
            this.groupBox_spectacle.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_tickets
            // 
            this.groupBox_tickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_tickets.Controls.Add(this.dataGridView_tickets);
            this.groupBox_tickets.Location = new System.Drawing.Point(3, 255);
            this.groupBox_tickets.Name = "groupBox_tickets";
            this.groupBox_tickets.Size = new System.Drawing.Size(398, 170);
            this.groupBox_tickets.TabIndex = 13;
            this.groupBox_tickets.TabStop = false;
            this.groupBox_tickets.Text = "Билеты";
            // 
            // dataGridView_tickets
            // 
            this.dataGridView_tickets.AllowUserToAddRows = false;
            this.dataGridView_tickets.AllowUserToDeleteRows = false;
            this.dataGridView_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_tickets.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_tickets.Name = "dataGridView_tickets";
            this.dataGridView_tickets.ReadOnly = true;
            this.dataGridView_tickets.RowHeadersVisible = false;
            this.dataGridView_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_tickets.Size = new System.Drawing.Size(392, 151);
            this.dataGridView_tickets.TabIndex = 12;
            this.dataGridView_tickets.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tickets_RowEnter);
            this.dataGridView_tickets.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tickets_RowLeave);
            // 
            // groupBox_spectacle
            // 
            this.groupBox_spectacle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_spectacle.Controls.Add(this.button_edit);
            this.groupBox_spectacle.Controls.Add(this.label_hall);
            this.groupBox_spectacle.Controls.Add(this.label_name);
            this.groupBox_spectacle.Controls.Add(this.label_baseTicketPrice);
            this.groupBox_spectacle.Controls.Add(this.label_perfomanceDate);
            this.groupBox_spectacle.Controls.Add(this.comboBox_hall);
            this.groupBox_spectacle.Controls.Add(this.textBox_baseTicketPrice);
            this.groupBox_spectacle.Controls.Add(this.textBox_name);
            this.groupBox_spectacle.Controls.Add(this.dateTimePicker_perfomanceDate);
            this.groupBox_spectacle.Location = new System.Drawing.Point(3, 27);
            this.groupBox_spectacle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox_spectacle.Name = "groupBox_spectacle";
            this.groupBox_spectacle.Size = new System.Drawing.Size(398, 229);
            this.groupBox_spectacle.TabIndex = 12;
            this.groupBox_spectacle.TabStop = false;
            this.groupBox_spectacle.Text = "Спектакль";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(404, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTicketToolStripMenuItem,
            this.removeTicketToolStripMenuItem});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ticketToolStripMenuItem.Text = "Билет";
            // 
            // addTicketToolStripMenuItem
            // 
            this.addTicketToolStripMenuItem.Name = "addTicketToolStripMenuItem";
            this.addTicketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTicketToolStripMenuItem.Text = "Добавить";
            // 
            // removeTicketToolStripMenuItem
            // 
            this.removeTicketToolStripMenuItem.Name = "removeTicketToolStripMenuItem";
            this.removeTicketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeTicketToolStripMenuItem.Text = "Удалить";
            // 
            // button_edit
            // 
            this.button_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_edit.Location = new System.Drawing.Point(269, 198);
            this.button_edit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(120, 23);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label_hall
            // 
            this.label_hall.AutoSize = true;
            this.label_hall.Location = new System.Drawing.Point(6, 145);
            this.label_hall.Name = "label_hall";
            this.label_hall.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_hall.Size = new System.Drawing.Size(26, 17);
            this.label_hall.TabIndex = 16;
            this.label_hall.Text = "Зал";
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 58);
            this.label_name.Name = "label_name";
            this.label_name.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_name.Size = new System.Drawing.Size(113, 17);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "Название спектакля";
            // 
            // label_baseTicketPrice
            // 
            this.label_baseTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_baseTicketPrice.AutoSize = true;
            this.label_baseTicketPrice.Location = new System.Drawing.Point(6, 101);
            this.label_baseTicketPrice.Name = "label_baseTicketPrice";
            this.label_baseTicketPrice.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_baseTicketPrice.Size = new System.Drawing.Size(115, 17);
            this.label_baseTicketPrice.TabIndex = 14;
            this.label_baseTicketPrice.Text = "Базовая цена билета";
            // 
            // label_perfomanceDate
            // 
            this.label_perfomanceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_perfomanceDate.AutoSize = true;
            this.label_perfomanceDate.Location = new System.Drawing.Point(6, 15);
            this.label_perfomanceDate.Name = "label_perfomanceDate";
            this.label_perfomanceDate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label_perfomanceDate.Size = new System.Drawing.Size(102, 17);
            this.label_perfomanceDate.TabIndex = 13;
            this.label_perfomanceDate.Text = "Дата выступления";
            // 
            // comboBox_hall
            // 
            this.comboBox_hall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_hall.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_hall.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_hall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hall.FormattingEnabled = true;
            this.comboBox_hall.Location = new System.Drawing.Point(9, 164);
            this.comboBox_hall.Name = "comboBox_hall";
            this.comboBox_hall.Size = new System.Drawing.Size(380, 21);
            this.comboBox_hall.TabIndex = 12;
            this.comboBox_hall.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox_hall_KeyUp);
            // 
            // textBox_baseTicketPrice
            // 
            this.textBox_baseTicketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_baseTicketPrice.Location = new System.Drawing.Point(9, 121);
            this.textBox_baseTicketPrice.Name = "textBox_baseTicketPrice";
            this.textBox_baseTicketPrice.Size = new System.Drawing.Size(380, 20);
            this.textBox_baseTicketPrice.TabIndex = 11;
            this.textBox_baseTicketPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_baseTicketPrice_KeyUp);
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(9, 78);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(380, 20);
            this.textBox_name.TabIndex = 10;
            this.textBox_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyUp);
            // 
            // dateTimePicker_perfomanceDate
            // 
            this.dateTimePicker_perfomanceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_perfomanceDate.Location = new System.Drawing.Point(9, 35);
            this.dateTimePicker_perfomanceDate.Name = "dateTimePicker_perfomanceDate";
            this.dateTimePicker_perfomanceDate.Size = new System.Drawing.Size(380, 20);
            this.dateTimePicker_perfomanceDate.TabIndex = 9;
            this.dateTimePicker_perfomanceDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker_perfomanceDate_KeyUp);
            // 
            // editSpectacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 427);
            this.Controls.Add(this.groupBox_tickets);
            this.Controls.Add(this.groupBox_spectacle);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "editSpectacle";
            this.Text = "Изменить спектакль";
            this.groupBox_tickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tickets)).EndInit();
            this.groupBox_spectacle.ResumeLayout(false);
            this.groupBox_spectacle.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_tickets;
        private System.Windows.Forms.DataGridView dataGridView_tickets;
        private System.Windows.Forms.GroupBox groupBox_spectacle;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTicketToolStripMenuItem;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label_hall;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_baseTicketPrice;
        private System.Windows.Forms.Label label_perfomanceDate;
        private System.Windows.Forms.ComboBox comboBox_hall;
        private System.Windows.Forms.TextBox textBox_baseTicketPrice;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_perfomanceDate;
    }
}