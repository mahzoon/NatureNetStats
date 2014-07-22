using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NatureNetStats
{
    public partial class MainForm : Form
    {
        DesignIdeasControl design_idea_control = new DesignIdeasControl();
        UserList users_list = new UserList();
        Activities_Control activities_control = new Activities_Control();

        System.Threading.Thread data_thread;
        System.Threading.Timer data_timer;
        bool data_thread_started = false;
        long data_timer_time = 0;

        // 0=dashboard, 1=Users, 2=, 3=.
        int active_control_id;

        bool first_update = true;

        public MainForm()
        {
            Configurations.LoadSettings();
            InitializeComponent();
            
            pictureBox_banner.BackColor = Color.FromArgb(131, 192, 50);
            data_thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.DataThreadEntry));
            data_timer = new System.Threading.Timer(new System.Threading.TimerCallback(this.DataTimerChanged), null, System.Threading.Timeout.Infinite, Configurations.data_timer_step);          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartUpdateData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopUpdateData();
            //Configurations.SaveSettings();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            if (!first_update)
            {
                Control c = panel_right.Controls[0];
                panel_right.Controls.RemoveAt(0);
                try
                {
                    panel_right.Controls.Add(users_list);
                    users_list.Dock = DockStyle.Fill;
                    this.active_control_id = 1;
                }
                catch (Exception) { panel_right.Controls.RemoveAt(0); panel_right.Controls.Add(c); }
            }
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (!first_update)
            {
                panel_right.Controls.RemoveAt(0);
                panel_right.Controls.Add(dashboard_control);
                dashboard_control.Dock = DockStyle.Fill;
                this.active_control_id = 0;
            }
        }

        private void button_designideas_Click(object sender, EventArgs e)
        {
            if (!first_update)
            {
                panel_right.Controls.RemoveAt(0);
                panel_right.Controls.Add(design_idea_control);
                design_idea_control.Dock = DockStyle.Fill;
                this.active_control_id = 3;
            }
        }

        private void button_activities_Click(object sender, EventArgs e)
        {
            if (!first_update)
            {
                panel_right.Controls.RemoveAt(0);
                panel_right.Controls.Add(activities_control);
                activities_control.Dock = DockStyle.Fill;
                this.active_control_id = 4;
            }
        }

        public void StartUpdateData()
        {
            DatabaseChange.ResetChangedFlags();
            if (!data_thread_started)
            {
                data_timer.Change(0, Configurations.data_timer_step);
            }
            data_thread_started = !data_thread_started;
        }

        public void StopUpdateData()
        {
            if (data_thread_started)
            {
                data_timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            }
            data_thread_started = !data_thread_started;
        }

        void DataTimerChanged(Object stateInfo)
        {
            if (data_timer_time % Configurations.data_refresh_rate == 0)
            {
                data_timer_time = Configurations.data_timer_step;
                //SetProgressBar_1(0);
                restart_data_thread(stateInfo);
            }
            else
            {
                data_timer_time = data_timer_time + Configurations.data_timer_step;
                //SetProgressBar_1((int)((data_timer_time * 100) / Configurations.data_refresh_rate));
            }
        }

        void restart_data_thread(Object stateInfo)
        {
            if (data_thread != null)
            {
                if (data_thread.ThreadState == System.Threading.ThreadState.Stopped || data_thread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    data_thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.DataThreadEntry));
                    data_thread.Start();
                }
            }
            else
            {
                data_thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.DataThreadEntry));
                data_thread.Start();
            }
        }

        public void DataThreadEntry()
        {
            DatabaseChange.CheckForChanges();
            //if (active_control_id == 0)
            dashboard_control.DataThreadEntry();
            //if (active_control_id == 1)
            users_list.DataThreadEntry();
            design_idea_control.DataThreadEntry();
            activities_control.DataThreadEntry();
            DatabaseChange.ResetChangedFlags();
            if (first_update) first_update = !first_update;
        }
    }

    // Dashboard
    public delegate void UpdatePlot(List<DailyLogDataSource> new_data, int index);
    public delegate void UpdateStats(Statistics stats);
    public delegate void UpdateDailyLogTable(List<DailyLogDataSource> source);
    public delegate void UpdateInteractionLogTable(List<InteractionLogDataSource> source);
    // Other menu items
    public delegate void UpdateUsers(List<UserItemInfo> user_items);
    public delegate void UpdateIdeas();
    public delegate void UpdateActivities(int activity_id, List<ActivityItemDataSource> contribs);
}
