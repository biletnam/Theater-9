namespace Theater
{
    partial class addSector
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_rate = new System.Windows.Forms.TextBox();
            this.label_rate = new System.Windows.Forms.Label();
            this.numericUpDown_startSeat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_endSeat = new System.Windows.Forms.NumericUpDown();
            this.label_startSeat = new System.Windows.Forms.Label();
            this.label_endSeat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_endSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(193, 115);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(114, 11);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(154, 20);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyUp);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(51, 14);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Название";
            // 
            // textBox_rate
            // 
            this.textBox_rate.Location = new System.Drawing.Point(114, 37);
            this.textBox_rate.Name = "textBox_rate";
            this.textBox_rate.Size = new System.Drawing.Size(154, 20);
            this.textBox_rate.TabIndex = 9;
            this.textBox_rate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_rate_KeyUp);
            // 
            // label_rate
            // 
            this.label_rate.AutoSize = true;
            this.label_rate.Location = new System.Drawing.Point(51, 40);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(57, 13);
            this.label_rate.TabIndex = 8;
            this.label_rate.Text = "Надбавка";
            // 
            // numericUpDown_startSeat
            // 
            this.numericUpDown_startSeat.Location = new System.Drawing.Point(114, 63);
            this.numericUpDown_startSeat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_startSeat.Name = "numericUpDown_startSeat";
            this.numericUpDown_startSeat.Size = new System.Drawing.Size(154, 20);
            this.numericUpDown_startSeat.TabIndex = 10;
            this.numericUpDown_startSeat.ValueChanged += new System.EventHandler(this.numericUpDown_startSeat_ValueChanged);
            this.numericUpDown_startSeat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_startSeat_KeyUp);
            // 
            // numericUpDown_endSeat
            // 
            this.numericUpDown_endSeat.Location = new System.Drawing.Point(114, 89);
            this.numericUpDown_endSeat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_endSeat.Name = "numericUpDown_endSeat";
            this.numericUpDown_endSeat.Size = new System.Drawing.Size(154, 20);
            this.numericUpDown_endSeat.TabIndex = 11;
            this.numericUpDown_endSeat.ValueChanged += new System.EventHandler(this.numericUpDown_endSeat_ValueChanged);
            this.numericUpDown_endSeat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_endSeat_KeyUp);
            // 
            // label_startSeat
            // 
            this.label_startSeat.AutoSize = true;
            this.label_startSeat.Location = new System.Drawing.Point(12, 65);
            this.label_startSeat.Name = "label_startSeat";
            this.label_startSeat.Size = new System.Drawing.Size(96, 13);
            this.label_startSeat.TabIndex = 12;
            this.label_startSeat.Text = "Начальное место";
            // 
            // label_endSeat
            // 
            this.label_endSeat.AutoSize = true;
            this.label_endSeat.Location = new System.Drawing.Point(19, 91);
            this.label_endSeat.Name = "label_endSeat";
            this.label_endSeat.Size = new System.Drawing.Size(89, 13);
            this.label_endSeat.TabIndex = 13;
            this.label_endSeat.Text = "Конечное место";
            // 
            // addSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.label_endSeat);
            this.Controls.Add(this.label_startSeat);
            this.Controls.Add(this.numericUpDown_endSeat);
            this.Controls.Add(this.numericUpDown_startSeat);
            this.Controls.Add(this.textBox_rate);
            this.Controls.Add(this.label_rate);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addSector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сектор зала";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_endSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_rate;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.NumericUpDown numericUpDown_startSeat;
        private System.Windows.Forms.NumericUpDown numericUpDown_endSeat;
        private System.Windows.Forms.Label label_startSeat;
        private System.Windows.Forms.Label label_endSeat;
    }
}