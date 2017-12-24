namespace Theater
{
    partial class management
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
            this.dataGridView_halls = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.hallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_halls)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_halls
            // 
            this.dataGridView_halls.AllowUserToAddRows = false;
            this.dataGridView_halls.AllowUserToDeleteRows = false;
            this.dataGridView_halls.AllowUserToResizeRows = false;
            this.dataGridView_halls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_halls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_halls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_halls.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_halls.Location = new System.Drawing.Point(0, 24);
            this.dataGridView_halls.MultiSelect = false;
            this.dataGridView_halls.Name = "dataGridView_halls";
            this.dataGridView_halls.ReadOnly = true;
            this.dataGridView_halls.RowHeadersVisible = false;
            this.dataGridView_halls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_halls.Size = new System.Drawing.Size(344, 177);
            this.dataGridView_halls.TabIndex = 0;
            this.dataGridView_halls.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_halls_RowEnter);
            this.dataGridView_halls.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_halls_RowLeave);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // hallToolStripMenuItem
            // 
            this.hallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHallToolStripMenuItem,
            this.editHallToolStripMenuItem,
            this.removeHallToolStripMenuItem});
            this.hallToolStripMenuItem.Name = "hallToolStripMenuItem";
            this.hallToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.hallToolStripMenuItem.Text = "Зал";
            // 
            // addHallToolStripMenuItem
            // 
            this.addHallToolStripMenuItem.Name = "addHallToolStripMenuItem";
            this.addHallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addHallToolStripMenuItem.Text = "Добавить";
            this.addHallToolStripMenuItem.Click += new System.EventHandler(this.addHallToolStripMenuItem_Click);
            // 
            // editHallToolStripMenuItem
            // 
            this.editHallToolStripMenuItem.Name = "editHallToolStripMenuItem";
            this.editHallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editHallToolStripMenuItem.Text = "Изменить";
            this.editHallToolStripMenuItem.Click += new System.EventHandler(this.editHallToolStripMenuItem_Click);
            // 
            // removeHallToolStripMenuItem
            // 
            this.removeHallToolStripMenuItem.Name = "removeHallToolStripMenuItem";
            this.removeHallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeHallToolStripMenuItem.Text = "Удалить";
            this.removeHallToolStripMenuItem.Click += new System.EventHandler(this.removeHallToolStripMenuItem_Click);
            // 
            // management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.dataGridView_halls);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "management";
            this.Text = "Управление залами";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.management_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_halls)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_halls;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem hallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeHallToolStripMenuItem;
    }
}