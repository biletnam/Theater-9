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
            this.sectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_hall = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.groupBox_sectors = new System.Windows.Forms.GroupBox();
            this.dataGridView_sectors = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox_hall.SuspendLayout();
            this.groupBox_sectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sectors)).BeginInit();
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
            this.textBox_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyUp);
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
            this.sectorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sectorToolStripMenuItem
            // 
            this.sectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSectorToolStripMenuItem,
            this.editSectorToolStripMenuItem,
            this.removeSectorToolStripMenuItem});
            this.sectorToolStripMenuItem.Name = "sectorToolStripMenuItem";
            this.sectorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sectorToolStripMenuItem.Text = "Сектор";
            // 
            // addSectorToolStripMenuItem
            // 
            this.addSectorToolStripMenuItem.Name = "addSectorToolStripMenuItem";
            this.addSectorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addSectorToolStripMenuItem.Text = "Добавить";
            this.addSectorToolStripMenuItem.Click += new System.EventHandler(this.addSectorToolStripMenuItem_Click);
            // 
            // editSectorToolStripMenuItem
            // 
            this.editSectorToolStripMenuItem.Name = "editSectorToolStripMenuItem";
            this.editSectorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editSectorToolStripMenuItem.Text = "Изменить";
            this.editSectorToolStripMenuItem.Click += new System.EventHandler(this.editSectorToolStripMenuItem_Click);
            // 
            // removeSectorToolStripMenuItem
            // 
            this.removeSectorToolStripMenuItem.Name = "removeSectorToolStripMenuItem";
            this.removeSectorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.removeSectorToolStripMenuItem.Text = "Удалить";
            this.removeSectorToolStripMenuItem.Click += new System.EventHandler(this.removeSectorToolStripMenuItem_Click);
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
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(269, 71);
            this.button_add.MinimumSize = new System.Drawing.Size(120, 0);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 23);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Изменить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // groupBox_sectors
            // 
            this.groupBox_sectors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_sectors.Controls.Add(this.dataGridView_sectors);
            this.groupBox_sectors.Location = new System.Drawing.Point(3, 137);
            this.groupBox_sectors.Name = "groupBox_sectors";
            this.groupBox_sectors.Size = new System.Drawing.Size(398, 224);
            this.groupBox_sectors.TabIndex = 11;
            this.groupBox_sectors.TabStop = false;
            this.groupBox_sectors.Text = "Секторы";
            // 
            // dataGridView_sectors
            // 
            this.dataGridView_sectors.AllowUserToAddRows = false;
            this.dataGridView_sectors.AllowUserToDeleteRows = false;
            this.dataGridView_sectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sectors.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_sectors.Name = "dataGridView_sectors";
            this.dataGridView_sectors.ReadOnly = true;
            this.dataGridView_sectors.RowHeadersVisible = false;
            this.dataGridView_sectors.Size = new System.Drawing.Size(392, 205);
            this.dataGridView_sectors.TabIndex = 12;
            this.dataGridView_sectors.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sectors_RowEnter);
            this.dataGridView_sectors.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sectors_RowLeave);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить зал";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_hall.ResumeLayout(false);
            this.groupBox_hall.PerformLayout();
            this.groupBox_sectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sectors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSectorToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_hall;
        private System.Windows.Forms.GroupBox groupBox_sectors;
        private System.Windows.Forms.DataGridView dataGridView_sectors;
        private System.Windows.Forms.Button button_add;
    }
}