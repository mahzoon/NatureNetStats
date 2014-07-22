using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot;

namespace NatureNetStats
{
    public partial class Dashboard : UserControl
    {
        DashboardDataProvider data_provider;
        
        DataTable interaction_log_table;
        DataTable daily_log_table;

        List<InteractionLogDataSource> current_ilog;
        List<DailyLogDataSource> current_dlog;

        // Plot Stuff
        DateTimeAxis xAxisDateTime;
        LinearAxis yAxisValues;
        PlotModel plot_model;
        LineSeries line_series_observations;
        LineSeries line_series_design_ideas;
        LineSeries line_series_interactions;
        List<DailyLogDataSource> plot_data_observations;
        List<DailyLogDataSource> plot_data_design_ideas;
        List<DailyLogDataSource> plot_data_interactions;

        // Manual Table Refresh
        private readonly BackgroundWorker table_refresher = new BackgroundWorker();
        // Manual Plot Refresh
        private readonly BackgroundWorker plot_refresher = new BackgroundWorker();

        public Dashboard()
        {
            InitializeComponent();

            plot_refresher.DoWork += new DoWorkEventHandler(refresh_plot);
            table_refresher.DoWork += new DoWorkEventHandler(refresh_table);
            //table_refresher.RunWorkerCompleted += new RunWorkerCompletedEventHandler(refresh_table_done);
            
            data_provider = new DashboardDataProvider();

            /////// Plot Related Settings ///////
            line_series_observations = new LineSeries { Title = "Number of Observations", StrokeThickness = 2 };
            line_series_design_ideas = new LineSeries { Title = "Number of Design Ideas", StrokeThickness = 2 };
            line_series_interactions = new LineSeries { Title = "Number of Interactions", StrokeThickness = 2 };
            plot_data_observations = new List<DailyLogDataSource>();
            plot_data_interactions = new List<DailyLogDataSource>();
            plot_data_design_ideas = new List<DailyLogDataSource>();
            plot_model = new OxyPlot.PlotModel();
            plot_model.PlotType = OxyPlot.PlotType.XY;
            xAxisDateTime = new DateTimeAxis()
            {
                IntervalType = DateTimeIntervalType.Auto,
                MinorIntervalType = DateTimeIntervalType.Hours,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                FirstDayOfWeek = DayOfWeek.Monday,
                Position = AxisPosition.Bottom,
                StringFormat = "MM/dd",
                Minimum = DateTime.Parse("6/1/2014").ToOADate(),
                Maximum = DateTime.Now.ToOADate()
            };
            xAxisDateTime.AxisChanged += xAxisDateTime_AxisChanged;
            yAxisValues = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            };
            plot_model.Series.Add(line_series_observations);
            plot_model.Axes.Add(xAxisDateTime);
            plot_model.Axes.Add(yAxisValues);
            this.plotView_interactions.Model = plot_model;

            interaction_log_table = new DataTable();
            DataColumn c1 = new DataColumn("Date", System.Type.GetType("System.DateTime")); interaction_log_table.Columns.Add(c1);
            DataColumn c2 = new DataColumn("Type", System.Type.GetType("System.String")); interaction_log_table.Columns.Add(c2);
            DataColumn c3 = new DataColumn("Details", System.Type.GetType("System.String")); interaction_log_table.Columns.Add(c3);
            DataColumn c4 = new DataColumn("TouchID", System.Type.GetType("System.Int32")); interaction_log_table.Columns.Add(c4);
            DataColumn c5 = new DataColumn("TouchX", System.Type.GetType("System.Double")); interaction_log_table.Columns.Add(c5);
            DataColumn c6 = new DataColumn("TouchY", System.Type.GetType("System.Double")); interaction_log_table.Columns.Add(c6);
            daily_log_table = new DataTable();
            DataColumn c7 = new DataColumn("Date", System.Type.GetType("System.DateTime")); daily_log_table.Columns.Add(c7);
            DataColumn c8 = new DataColumn("Ideas", System.Type.GetType("System.Int32")); daily_log_table.Columns.Add(c8);
            DataColumn c9 = new DataColumn("Medias", System.Type.GetType("System.Int32")); daily_log_table.Columns.Add(c9);
            DataColumn c10 = new DataColumn("Comments", System.Type.GetType("System.Int32")); daily_log_table.Columns.Add(c10);
            DataColumn c11 = new DataColumn("Likes", System.Type.GetType("System.Int32")); daily_log_table.Columns.Add(c11);
            DataColumn c12 = new DataColumn("Interactions", System.Type.GetType("System.Int32")); daily_log_table.Columns.Add(c12);

            comboBox_source_tables.SelectedIndex = 0;
            comboBox_source_tables.SelectedIndexChanged += new EventHandler(comboBox_source_tables_SelectedIndexChanged);

            comboBox_source_plot.SelectedIndex = 0;
            comboBox_source_plot.SelectedIndexChanged += new EventHandler(comboBox_source_plot_SelectedIndexChanged);

            button_refresh_tables_Click(null, null);
        }

        public void DataThreadEntry()
        {
            int num_changes = data_provider.GetChangeInDailyData();
            if (num_changes > 0) button_refresh_plot_Click(null, null);
            Statistics stats = data_provider.GetStatistics();
            this.update_stats(stats);
        }

        public void update_dlog(List<DailyLogDataSource> dlog)
        {
            if (this.comboBox_source_tables.InvokeRequired)
            {
                UpdateDailyLogTable u = new UpdateDailyLogTable(this.update_dlog);
                this.comboBox_source_tables.Invoke(u, new object[] { dlog });
            }
            else
            {
                current_dlog = dlog;
                UpdateTable();
            }
        }
        public void update_ilog(List<InteractionLogDataSource> ilog)
        {
            if (this.comboBox_source_tables.InvokeRequired)
            {
                UpdateInteractionLogTable u = new UpdateInteractionLogTable(this.update_ilog);
                this.comboBox_source_tables.Invoke(u, new object[] { ilog });
            }
            else
            {
                current_ilog = ilog;
                UpdateTable();
            }
        }
        public void update_stats(Statistics stats)
        {
            if (this.label_designideas.InvokeRequired)
            {
                UpdateStats u = new UpdateStats(this.update_stats);
                this.label_designideas.Invoke(u, new object[] { stats });
            }
            else
            {
                this.label_designideas.Text = stats.num_designideas.ToString();
                this.label_comments.Text = stats.num_comments.ToString();
                this.label_interactions.Text = stats.num_interactions.ToString();
                this.label_likes.Text = stats.num_likes.ToString();
                this.label_observations.Text = stats.num_observations.ToString();
                this.label_users.Text = stats.num_users.ToString();
            }
        }
        //public void update_plot(List<InteractionLogData> new_data)
        //{
        //    if (this.plotView_interactions.InvokeRequired)
        //    {
        //        UpdatePlot c = new UpdatePlot(this.update_plot);
        //        this.plotView_interactions.Invoke(c, new object[] { new_data });
        //    }
        //    else
        //    {
        //        for (int counter = 0; counter < new_data.Count; counter++)
        //        {
        //            line_series.Points.Add(new DataPoint(new_data[counter].date.ToOADate(), new_data[counter].num_interactions));
        //            plot_data.Add(new_data[counter]);
        //        }
        //        //plotView_interactions.Model.Axes.Clear();
        //        //plotView_interactions.Model.Series.Clear();
        //        //plotView_interactions.Model = new OxyPlot.PlotModel();
        //        //plotView_interactions.Model.PlotType = OxyPlot.PlotType.XY;
        //        //plotView_interactions.Model.Series.Add(s1);
        //        //plotView_interactions.Model.Axes.Add(xAxisDateTime);
        //        //plotView_interactions.Model.Axes.Add(yAxisValues);
        //        //xAxisDateTime.Zoom(new_data[0].date.ToOADate(), new_data[new_data.Count - 1].date.ToOADate());
        //        //yAxisValues.Zoom(0, 4000);
        //        xAxisDateTime_AxisChanged(xAxisDateTime, null);
        //        plotView_interactions.Refresh();
        //    }
        //}
        public void update_plot(List<DailyLogDataSource> new_data, int index)
        {
            if (this.plotView_interactions.InvokeRequired)
            {
                UpdatePlot c = new UpdatePlot(this.update_plot);
                this.plotView_interactions.Invoke(c, new object[] { new_data, index });
            }
            else
            {
                for (int counter = 0; counter < new_data.Count; counter++)
                {
                    if (index == 0)
                    {
                        SubmitChangeInLineSeries(new_data[counter].date, new_data[counter].medias, line_series_observations);
                    }
                    if (index == 1)
                    {
                        SubmitChangeInLineSeries(new_data[counter].date, new_data[counter].ideas, line_series_design_ideas);
                    }
                    if (index == 2)
                    {
                        SubmitChangeInLineSeries(new_data[counter].date, new_data[counter].interactions, line_series_interactions);
                    }
                    //plot_data.Add(new_data[counter]);
                }

                //if (comboBox_source_plot.SelectedIndex == index)
                //{
                    //plotView_interactions.Model.Axes.Clear();
                    //plotView_interactions.Model.Series.Clear();
                    //plotView_interactions.Model = new OxyPlot.PlotModel();
                    //plotView_interactions.Model.PlotType = OxyPlot.PlotType.XY;
                    //plotView_interactions.Model.Series.Add(s1);
                    //plotView_interactions.Model.Axes.Add(xAxisDateTime);
                    //plotView_interactions.Model.Axes.Add(yAxisValues);
                    //xAxisDateTime.Zoom(new_data[0].date.ToOADate(), new_data[new_data.Count - 1].date.ToOADate());
                    //yAxisValues.Zoom(0, 4000);
                    
                    //xAxisDateTime_AxisChanged(xAxisDateTime, null);
                //}
                plotView_interactions.Refresh();
            }
        }
        void xAxisDateTime_AxisChanged(object sender, AxisChangedEventArgs e)
        {
            DateTimeAxis axis = sender as DateTimeAxis;

            //save the current min/max date values
            //DateTime dtMax = DateTime.FromOADate(axis.ActualMaximum);
            //DateTime dtMin = DateTime.FromOADate(axis.ActualMinimum);

            double minValue = double.MaxValue;
            double maxValue = double.MinValue;

            LineSeries plot_data = GetActiveLineSeries();
            int idxMin=0;
            for (int counter=0;counter<plot_data.Points.Count;counter++)
                if (plot_data.Points[counter].X > axis.ActualMinimum)
                {
                    idxMin = counter;
                    break;
                }
            int idxMax = plot_data.Points.Count;
            for (int counter=plot_data.Points.Count-1;counter>0;counter--)
                if (plot_data.Points[counter].X < axis.ActualMaximum)
                {
                    idxMax = counter;
                    break;
                }
            //int idxMin = GetActivePlotData().BinarySearch(new InteractionLogData(dtMin));
            //int idxMax = GetActivePlotData().BinarySearch(new InteractionLogData(dtMax));

            ////if we can not find an exact location (result is negativ) we can use the complement 
            ////see BinarySearch help for further explanation
            //if (idxMin < 0) idxMin = ~idxMin;
            //if (idxMax < 0) idxMax = ~idxMax;

            //find the corresponding min/max values in the selected intervall
            for (int i = idxMin; i < idxMax; i++)
            {
                minValue = Math.Min(minValue, plot_data.Points[i].Y);
                maxValue = Math.Max(maxValue, plot_data.Points[i].Y);
            }

            //set y-axis min/max and redraw the chart
            yAxisValues.Zoom(minValue - (0.2 * minValue), maxValue + (0.2 * maxValue));
            //xAxisDateTime.Minimum = plot_data.Points[idxMin].X;
            //xAxisDateTime.Maximum = plot_data.Points[idxMax].X;
            //xAxisDateTime.Zoom(plot_data.Points[idxMin].X, plot_data.Points[idxMax].X);
            plotView_interactions.Refresh();
        }
        void SubmitChangeInLineSeries(DateTime change_time, int y, LineSeries series)
        {
            double x = change_time.Subtract(new TimeSpan(1,0,0,0)).ToOADate();
            bool has_changed = false;
            int counter = 0;
            for (counter = 0; counter < series.Points.Count; counter++)
            {
                if (series.Points[counter].X == x)
                {
                    //series.Points[counter] = new DataPoint(x, y);
                    DataPoint p = series.Points[counter];
                    p.Y = y;
                    has_changed = true;
                    break;
                }
                if (series.Points[counter].X > x)
                    break;
            }
            if (!has_changed)
            {
                series.Points.Insert(counter, new DataPoint(x, y));
            }
        }

        void comboBox_source_plot_SelectedIndexChanged(object sender, EventArgs e)
        {
            plot_model.Axes.Clear();
            plot_model.Series.Clear();
            plot_model = new OxyPlot.PlotModel();
            plot_model.PlotType = OxyPlot.PlotType.XY;
            
            if (comboBox_source_plot.SelectedIndex == 0)
                plot_model.Series.Add(line_series_observations);
            if (comboBox_source_plot.SelectedIndex == 1)
                plot_model.Series.Add(line_series_design_ideas);
            if (comboBox_source_plot.SelectedIndex == 2)
                plot_model.Series.Add(line_series_interactions);

            plot_model.Axes.Add(xAxisDateTime);
            plot_model.Axes.Add(yAxisValues);
            plotView_interactions.Model = plot_model;
            xAxisDateTime_AxisChanged(xAxisDateTime, null);
            plotView_interactions.Refresh();
        }
        private void button_refresh_plot_Click(object sender, EventArgs e)
        {
            if (!plot_refresher.IsBusy)
                plot_refresher.RunWorkerAsync(null);
        }

        public void refresh_plot(object arg, DoWorkEventArgs e)
        {
            List<DailyLogDataSource> ilogs = data_provider.GetChangeInDailyData_Interactions();
            if (ilogs.Count > 0) this.update_plot(ilogs, 2);
            List<DailyLogDataSource> ologs = data_provider.GetChangeInDailyData_Observations();
            if (ologs.Count > 0) this.update_plot(ologs, 0);
            List<DailyLogDataSource> dlogs = data_provider.GetChangeInDailyData_DesignIdeas();
            if (dlogs.Count > 0) this.update_plot(dlogs, 1);
            data_provider.ResetDailyChanges();
        }

        private List<DailyLogDataSource> GetActivePlotData()
        {
            if (comboBox_source_plot.SelectedIndex == 0)
                return plot_data_observations;
            if (comboBox_source_plot.SelectedIndex == 1)
                return plot_data_design_ideas;
            if (comboBox_source_plot.SelectedIndex == 2)
                return plot_data_interactions;
            return new List<DailyLogDataSource>();
        }
        private LineSeries GetActiveLineSeries()
        {
            if (comboBox_source_plot.SelectedIndex == 0)
                return line_series_observations;
            if (comboBox_source_plot.SelectedIndex == 1)
                return line_series_design_ideas;
            if (comboBox_source_plot.SelectedIndex == 2)
                return line_series_interactions;
            return new LineSeries();
        }
        
        void comboBox_source_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!table_refresher.IsBusy)
                table_refresher.RunWorkerAsync(null);
        }
        private void button_refresh_tables_Click(object sender, EventArgs e)
        {
            if (!table_refresher.IsBusy)
                table_refresher.RunWorkerAsync(null);
        }

        public void refresh_table(object arg, DoWorkEventArgs e)
        {
            List<DailyLogDataSource> dlogs = data_provider.GetDailyLogDataSource(dateTimePicker_from.Value, dateTimePicker_to.Value);
            update_dlog(dlogs);
            List<InteractionLogDataSource> ilogs = data_provider.GetInteractionLogDataSource(dateTimePicker_from.Value, dateTimePicker_to.Value);
            update_ilog(ilogs);
        }
        private void UpdateTable()
        {
            if (comboBox_source_tables.SelectedIndex == 0)
            {
                dataGridView_log.DataSource = current_dlog;
                dataGridView_log.Refresh();
            }
            if (comboBox_source_tables.SelectedIndex == 1)
            {
                dataGridView_log.DataSource = current_ilog;
                dataGridView_log.Refresh();
            }
        }

        private void dateTimePicker_from_ValueChanged(object sender, EventArgs e)
        {
            button_refresh_tables_Click(null, null);
        }

        private void dateTimePicker_to_ValueChanged(object sender, EventArgs e)
        {
            button_refresh_tables_Click(null, null);
        }
    }
}
