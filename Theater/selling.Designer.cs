namespace Theater
{
    partial class selling
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
            this.dataGridView_spectacles = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.spectacleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSpecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_spectacles)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_spectacles
            // 
            this.dataGridView_spectacles.AllowUserToAddRows = false;
            this.dataGridView_spectacles.AllowUserToDeleteRows = false;
            this.dataGridView_spectacles.AllowUserToResizeRows = false;
            this.dataGridView_spectacles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_spectacles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_spectacles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_spectacles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_spectacles.Location = new System.Drawing.Point(0, 24);
            this.dataGridView_spectacles.MultiSelect = false;
            this.dataGridView_spectacles.Name = "dataGridView_spectacles";
            this.dataGridView_spectacles.ReadOnly = true;
            this.dataGridView_spectacles.RowHeadersVisible = false;
            this.dataGridView_spectacles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_spectacles.Size = new System.Drawing.Size(344, 177);
            this.dataGridView_spectacles.TabIndex = 1;
            this.dataGridView_spectacles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_spectacles_RowEnter);
            this.dataGridView_spectacles.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_spectacles_RowLeave);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spectacleToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // spectacleToolStripMenuItem
            // 
            this.spectacleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpecToolStripMenuItem,
            this.editSpecToolStripMenuItem,
            this.removeSpecToolStripMenuItem});
            this.spectacleToolStripMenuItem.Name = "spectacleToolStripMenuItem";
            this.spectacleToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.spectacleToolStripMenuItem.Text = "Спектакль";
            // 
            // addSpecToolStripMenuItem
            // 
            this.addSpecToolStripMenuItem.Name = "addSpecToolStripMenuItem";
            this.addSpecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addSpecToolStripMenuItem.Text = "Добавить";
            this.addSpecToolStripMenuItem.Click += new System.EventHandler(this.addSpecToolStripMenuItem_Click);
            // 
            // editSpecToolStripMenuItem
            // 
            this.editSpecToolStripMenuItem.Name = "editSpecToolStripMenuItem";
            this.editSpecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editSpecToolStripMenuItem.Text = "Изменить";
            this.editSpecToolStripMenuItem.Click += new System.EventHandler(this.editSpecToolStripMenuItem_Click);
            // 
            // removeSpecToolStripMenuItem
            // 
            this.removeSpecToolStripMenuItem.Name = "removeSpecToolStripMenuItem";
            this.removeSpecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeSpecToolStripMenuItem.Text = "Удалить";
            this.removeSpecToolStripMenuItem.Click += new System.EventHandler(this.removeSpecToolStripMenuItem_Click);
            // 
            // selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.dataGridView_spectacles);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "selling";
            this.Text = "Продажа билетов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.selling_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_spectacles)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_spectacles;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem spectacleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSpecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSpecToolStripMenuItem;
    }
}