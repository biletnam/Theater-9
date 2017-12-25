namespace Theater
{
    partial class profitReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.chart_profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_period = new System.Windows.Forms.GroupBox();
            this.groupBox_profit = new System.Windows.Forms.GroupBox();
            this.button_calc = new System.Windows.Forms.Button();
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_profit)).BeginInit();
            this.groupBox_period.SuspendLayout();
            this.groupBox_profit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(9, 38);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_from.TabIndex = 0;
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(9, 83);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_to.TabIndex = 1;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // chart_profit
            // 
            this.chart_profit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_profit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_profit.Legends.Add(legend1);
            this.chart_profit.Location = new System.Drawing.Point(9, 19);
            this.chart_profit.Name = "chart_profit";
            this.chart_profit.Size = new System.Drawing.Size(745, 341);
            this.chart_profit.TabIndex = 3;
            this.chart_profit.Text = "chart1";
            // 
            // groupBox_period
            // 
            this.groupBox_period.Controls.Add(this.label_to);
            this.groupBox_period.Controls.Add(this.label_from);
            this.groupBox_period.Controls.Add(this.button_calc);
            this.groupBox_period.Controls.Add(this.dateTimePicker_from);
            this.groupBox_period.Controls.Add(this.dateTimePicker_to);
            this.groupBox_period.Location = new System.Drawing.Point(12, 12);
            this.groupBox_period.Name = "groupBox_period";
            this.groupBox_period.Size = new System.Drawing.Size(221, 165);
            this.groupBox_period.TabIndex = 4;
            this.groupBox_period.TabStop = false;
            this.groupBox_period.Text = "Период";
            // 
            // groupBox_profit
            // 
            this.groupBox_profit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_profit.Controls.Add(this.chart_profit);
            this.groupBox_profit.Location = new System.Drawing.Point(12, 183);
            this.groupBox_profit.Name = "groupBox_profit";
            this.groupBox_profit.Size = new System.Drawing.Size(760, 366);
            this.groupBox_profit.TabIndex = 5;
            this.groupBox_profit.TabStop = false;
            this.groupBox_profit.Text = "Прибыль";
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(94, 112);
            this.button_calc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(115, 23);
            this.button_calc.TabIndex = 2;
            this.button_calc.Text = "Посчитать";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Location = new System.Drawing.Point(6, 22);
            this.label_from.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(14, 13);
            this.label_from.TabIndex = 3;
            this.label_from.Text = "C";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(6, 67);
            this.label_to.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(22, 13);
            this.label_to.TabIndex = 4;
            this.label_to.Text = "До";
            // 
            // profitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox_profit);
            this.Controls.Add(this.groupBox_period);
            this.Name = "profitReport";
            this.Text = "Отчет о прибыли";
            ((System.ComponentModel.ISupportInitialize)(this.chart_profit)).EndInit();
            this.groupBox_period.ResumeLayout(false);
            this.groupBox_period.PerformLayout();
            this.groupBox_profit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_profit;
        private System.Windows.Forms.GroupBox groupBox_period;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.GroupBox groupBox_profit;
    }
}