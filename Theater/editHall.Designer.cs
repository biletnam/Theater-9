namespace Theater
{
    partial class editHall
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.залToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_hall = new System.Windows.Forms.GroupBox();
            this.groupBox_sectors = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_hall.SuspendLayout();
            this.groupBox_sectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_name.Location = new System.Drawing.Point(86, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(303, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(23, 48);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 13);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Название";
            // 
            // textBox_number
            // 
            this.textBox_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_number.Enabled = false;
            this.textBox_number.Location = new System.Drawing.Point(86, 19);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(303, 20);
            this.textBox_number.TabIndex = 5;
            // 
            // label_number
            // 
            this.label_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(62, 22);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(18, 13);
            this.label_number.TabIndex = 4;
            this.label_number.Text = "№";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.залToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // залToolStripMenuItem
            // 
            this.залToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.залToolStripMenuItem.Name = "залToolStripMenuItem";
            this.залToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.залToolStripMenuItem.Text = "Сектор";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // groupBox_hall
            // 
            this.groupBox_hall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_hall.Controls.Add(this.button_add);
            this.groupBox_hall.Controls.Add(this.textBox_number);
            this.groupBox_hall.Controls.Add(this.label_name);
            this.groupBox_hall.Controls.Add(this.label_number);
            this.groupBox_hall.Controls.Add(this.textBox_name);
            this.groupBox_hall.Location = new System.Drawing.Point(3, 27);
            this.groupBox_hall.Name = "groupBox_hall";
            this.groupBox_hall.Size = new System.Drawing.Size(398, 104);
            this.groupBox_hall.TabIndex = 10;
            this.groupBox_hall.TabStop = false;
            this.groupBox_hall.Text = "Зал";
            // 
            // groupBox_sectors
            // 
            this.groupBox_sectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_sectors.Controls.Add(this.dataGridView1);
            this.groupBox_sectors.Location = new System.Drawing.Point(3, 137);
            this.groupBox_sectors.Name = "groupBox_sectors";
            this.groupBox_sectors.Size = new System.Drawing.Size(398, 224);
            this.groupBox_sectors.TabIndex = 11;
            this.groupBox_sectors.TabStop = false;
            this.groupBox_sectors.Text = "Секторы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(392, 205);
            this.dataGridView1.TabIndex = 12;
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(269, 71);
            this.button_add.MinimumSize = new System.Drawing.Size(120, 0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // editHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.groupBox_sectors);
            this.Controls.Add(this.groupBox_hall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "editHall";
            this.Text = "Изменить зал";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_hall.ResumeLayout(false);
            this.groupBox_hall.PerformLayout();
            this.groupBox_sectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem залToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_hall;
        private System.Windows.Forms.GroupBox groupBox_sectors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
    }
}