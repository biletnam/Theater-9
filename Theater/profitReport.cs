using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Theater
{
    public partial class profitReport : Form
    {
        // Храним переданную коллекцию
        private List<Spectacle> spectacles;

        public profitReport(List<Spectacle> spectacles)
        {
            InitializeComponent();

            // Устанавливаем иконку формы
            Icon = icons.profitReport;

            // Сохранаем переданную коллекцию
            this.spectacles = spectacles;
            // Устанавливаем ограничения на период отчета
            setDateLimit();
        }

        public void setDateLimit()
        {
            DateTime minDT, maxDT;
            if (spectacles.Count == 0)
            {
                groupBox_period.Enabled = false;
                groupBox_profit.Enabled = false;
            }
            else
            {
                minDT = maxDT = spectacles[0].PerformanceDate;
                foreach (Spectacle spectacle in spectacles)
                {
                    if (minDT > spectacle.PerformanceDate)
                        minDT = spectacle.PerformanceDate;
                    if (maxDT < spectacle.PerformanceDate)
                        maxDT = spectacle.PerformanceDate;
                }
                dateTimePicker_from.MinDate = minDT;
                dateTimePicker_from.MaxDate = maxDT;
                dateTimePicker_to.MinDate = minDT;
                dateTimePicker_to.MaxDate = maxDT;
                dateTimePicker_from.Value = minDT;
                dateTimePicker_to.Value = maxDT;
            }
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_to.MinDate = dateTimePicker_from.Value;
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_from.MaxDate = dateTimePicker_to.Value;
        }

        private static void Swap<T>(List<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            chart_profit.Series.Clear();
            chart_profit.Titles.Clear();

            chart_profit.Series.Clear();

            chart_profit.Titles.Add("Прибыль");

            Series series = chart_profit.Series.Add("Прибыль");

            for (int i = 0; i < spectacles.Count; i++)
                for (int j = 0; j < spectacles.Count; j++)
                    if (spectacles[i].PerformanceDate < spectacles[j].PerformanceDate)
                        Swap(spectacles, i, j);

            Dictionary<String, Double> data = new Dictionary<String, Double>();
            foreach (Spectacle spectacle in spectacles)
            {
                DateTime dtfrom = dateTimePicker_from.Value.Date;
                DateTime dtto = dateTimePicker_to.Value;

                if ((spectacle.PerformanceDate < dtfrom) ||
                    (spectacle.PerformanceDate > dtto))
                    continue;
                String key = Convert.ToString(spectacle.PerformanceDate.Month) + "." + Convert.ToString(spectacle.PerformanceDate.Year);
                if (data.ContainsKey(key))
                {
                    data[key] = data[key] + spectacle.getProfit();
                }
                else
                {
                    data.Add(key, spectacle.getProfit());
                }
            }

            foreach (KeyValuePair<String, Double> record in data)
            {
                series.Points.AddXY(Convert.ToString(record.Key), record.Value);
            }
        }
    }
}
