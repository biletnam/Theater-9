namespace Theater
{
    partial class addTicket
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
            this.comboBox_ticketType = new System.Windows.Forms.ComboBox();
            this.comboBox_seats = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_seat = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.checkBox_reserved = new System.Windows.Forms.CheckBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox_sale = new System.Windows.Forms.GroupBox();
            this.textBox_sale = new System.Windows.Forms.TextBox();
            this.label_sale = new System.Windows.Forms.Label();
            this.groupBox_VIP = new System.Windows.Forms.GroupBox();
            this.textBox_addService = new System.Windows.Forms.TextBox();
            this.label2_addService = new System.Windows.Forms.Label();
            this.textBox_addCost = new System.Windows.Forms.TextBox();
            this.label_addCost = new System.Windows.Forms.Label();
            this.button_getPrice = new System.Windows.Forms.Button();
            this.groupBox_sale.SuspendLayout();
            this.groupBox_VIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_ticketType
            // 
            this.comboBox_ticketType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ticketType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_ticketType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_ticketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ticketType.FormattingEnabled = true;
            this.comboBox_ticketType.Items.AddRange(new object[] {
            "Обычный",
            "Скидочный",
            "VIP"});
            this.comboBox_ticketType.Location = new System.Drawing.Point(15, 77);
            this.comboBox_ticketType.Name = "comboBox_ticketType";
            this.comboBox_ticketType.Size = new System.Drawing.Size(257, 21);
            this.comboBox_ticketType.TabIndex = 13;
            this.comboBox_ticketType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ticketType_SelectedIndexChanged);
            // 
            // comboBox_seats
            // 
            this.comboBox_seats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_seats.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_seats.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_seats.FormattingEnabled = true;
            this.comboBox_seats.Location = new System.Drawing.Point(15, 123);
            this.comboBox_seats.Name = "comboBox_seats";
            this.comboBox_seats.Size = new System.Drawing.Size(257, 21);
            this.comboBox_seats.TabIndex = 14;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(12, 61);
            this.label_type.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(26, 13);
            this.label_type.TabIndex = 15;
            this.label_type.Text = "Тип";
            // 
            // label_seat
            // 
            this.label_seat.AutoSize = true;
            this.label_seat.Location = new System.Drawing.Point(12, 107);
            this.label_seat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_seat.Name = "label_seat";
            this.label_seat.Size = new System.Drawing.Size(39, 13);
            this.label_seat.TabIndex = 16;
            this.label_seat.Text = "Место";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(12, 15);
            this.label_number.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(41, 13);
            this.label_number.TabIndex = 17;
            this.label_number.Text = "Номер";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(15, 32);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.ReadOnly = true;
            this.textBox_number.Size = new System.Drawing.Size(257, 20);
            this.textBox_number.TabIndex = 18;
            // 
            // checkBox_reserved
            // 
            this.checkBox_reserved.AutoSize = true;
            this.checkBox_reserved.Location = new System.Drawing.Point(15, 153);
            this.checkBox_reserved.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.checkBox_reserved.Name = "checkBox_reserved";
            this.checkBox_reserved.Size = new System.Drawing.Size(117, 17);
            this.checkBox_reserved.TabIndex = 20;
            this.checkBox_reserved.Text = "Зарезервирован?";
            this.checkBox_reserved.UseVisualStyleBackColor = true;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 179);
            this.label_price.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(33, 13);
            this.label_price.TabIndex = 21;
            this.label_price.Text = "Цена";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(15, 195);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(257, 20);
            this.textBox_price.TabIndex = 22;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(197, 228);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 23;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // groupBox_sale
            // 
            this.groupBox_sale.Controls.Add(this.textBox_sale);
            this.groupBox_sale.Controls.Add(this.label_sale);
            this.groupBox_sale.Location = new System.Drawing.Point(15, 265);
            this.groupBox_sale.Name = "groupBox_sale";
            this.groupBox_sale.Size = new System.Drawing.Size(257, 100);
            this.groupBox_sale.TabIndex = 24;
            this.groupBox_sale.TabStop = false;
            this.groupBox_sale.Text = "Скидочный";
            // 
            // textBox_sale
            // 
            this.textBox_sale.Location = new System.Drawing.Point(9, 32);
            this.textBox_sale.Name = "textBox_sale";
            this.textBox_sale.Size = new System.Drawing.Size(242, 20);
            this.textBox_sale.TabIndex = 3;
            // 
            // label_sale
            // 
            this.label_sale.AutoSize = true;
            this.label_sale.Location = new System.Drawing.Point(6, 16);
            this.label_sale.Name = "label_sale";
            this.label_sale.Size = new System.Drawing.Size(44, 13);
            this.label_sale.TabIndex = 2;
            this.label_sale.Text = "Скидка";
            // 
            // groupBox_VIP
            // 
            this.groupBox_VIP.Controls.Add(this.textBox_addService);
            this.groupBox_VIP.Controls.Add(this.label2_addService);
            this.groupBox_VIP.Controls.Add(this.textBox_addCost);
            this.groupBox_VIP.Controls.Add(this.label_addCost);
            this.groupBox_VIP.Location = new System.Drawing.Point(15, 265);
            this.groupBox_VIP.Name = "groupBox_VIP";
            this.groupBox_VIP.Size = new System.Drawing.Size(257, 100);
            this.groupBox_VIP.TabIndex = 25;
            this.groupBox_VIP.TabStop = false;
            this.groupBox_VIP.Text = "VIP";
            // 
            // textBox_addService
            // 
            this.textBox_addService.Location = new System.Drawing.Point(9, 71);
            this.textBox_addService.Name = "textBox_addService";
            this.textBox_addService.Size = new System.Drawing.Size(242, 20);
            this.textBox_addService.TabIndex = 5;
            // 
            // label2_addService
            // 
            this.label2_addService.AutoSize = true;
            this.label2_addService.Location = new System.Drawing.Point(6, 55);
            this.label2_addService.Name = "label2_addService";
            this.label2_addService.Size = new System.Drawing.Size(129, 13);
            this.label2_addService.TabIndex = 1;
            this.label2_addService.Text = "Дополнительная услуга";
            // 
            // textBox_addCost
            // 
            this.textBox_addCost.Location = new System.Drawing.Point(9, 32);
            this.textBox_addCost.Name = "textBox_addCost";
            this.textBox_addCost.Size = new System.Drawing.Size(242, 20);
            this.textBox_addCost.TabIndex = 4;
            // 
            // label_addCost
            // 
            this.label_addCost.AutoSize = true;
            this.label_addCost.Location = new System.Drawing.Point(6, 16);
            this.label_addCost.Name = "label_addCost";
            this.label_addCost.Size = new System.Drawing.Size(150, 13);
            this.label_addCost.TabIndex = 0;
            this.label_addCost.Text = "Дополнительная стоимость";
            // 
            // button_getPrice
            // 
            this.button_getPrice.Location = new System.Drawing.Point(111, 228);
            this.button_getPrice.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.button_getPrice.Name = "button_getPrice";
            this.button_getPrice.Size = new System.Drawing.Size(80, 23);
            this.button_getPrice.TabIndex = 26;
            this.button_getPrice.Text = "Узнать цену";
            this.button_getPrice.UseVisualStyleBackColor = true;
            this.button_getPrice.Click += new System.EventHandler(this.button_getPrice_Click);
            // 
            // addTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.button_getPrice);
            this.Controls.Add(this.groupBox_VIP);
            this.Controls.Add(this.groupBox_sale);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.checkBox_reserved);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_seat);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_seats);
            this.Controls.Add(this.comboBox_ticketType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить билет";
            this.groupBox_sale.ResumeLayout(false);
            this.groupBox_sale.PerformLayout();
            this.groupBox_VIP.ResumeLayout(false);
            this.groupBox_VIP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ticketType;
        private System.Windows.Forms.ComboBox comboBox_seats;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_seat;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.CheckBox checkBox_reserved;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.GroupBox groupBox_sale;
        private System.Windows.Forms.TextBox textBox_sale;
        private System.Windows.Forms.Label label_sale;
        private System.Windows.Forms.GroupBox groupBox_VIP;
        private System.Windows.Forms.TextBox textBox_addService;
        private System.Windows.Forms.Label label2_addService;
        private System.Windows.Forms.TextBox textBox_addCost;
        private System.Windows.Forms.Label label_addCost;
        private System.Windows.Forms.Button button_getPrice;
    }
}