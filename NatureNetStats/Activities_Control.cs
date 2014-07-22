using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NatureNetStats
{
    public partial class Activities_Control : UserControl
    {
        ActivityDataProvider data_provider = new ActivityDataProvider();

        List<Activity> activities = new List<Activity>();
        Dictionary<int, ActivityItem> activity_items = new Dictionary<int, ActivityItem>();

        public Activities_Control()
        {
            InitializeComponent();

            //populate activities for the first time
            activities = data_provider.GetActivites();
            this.tableLayoutPanel_activities.RowStyles.Clear();
            for (int counter = 0; counter < activities.Count; counter++)
            {
                this.tableLayoutPanel_activities.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
                ActivityItem ai = new ActivityItem();
                ai.SetValues(activities[counter].name, activities[counter].description);
                activity_items.Add(activities[counter].id, ai);
                ai.Dock = DockStyle.Fill;
                this.tableLayoutPanel_activities.Controls.Add(ai, 0, counter);
            }
            this.tableLayoutPanel_activities.Height = activities.Count * 401;
        }

        public void DataThreadEntry()
        {
            Dictionary<int, List<ActivityItemDataSource>> new_contributions = data_provider.GetNewContributionsInActivity();
            foreach (KeyValuePair<int, List<ActivityItemDataSource>> kvp in new_contributions)
            {
                UpdateActivityTable(kvp.Key, kvp.Value);
            }
        }

        public void UpdateActivityTable(int activity_id, List<ActivityItemDataSource> new_contributions)
        {
            if (!activity_items.ContainsKey(activity_id)) return;
            ActivityItem ai = activity_items[activity_id];
            if (ai.InvokeRequired)
            {
                UpdateActivities u = new UpdateActivities(this.UpdateActivityTable);
                ai.Invoke(u, new object[] { activity_id, new_contributions });
            }
            else
            {
                ai.contributions.AddRange(new_contributions);
                ai.RefreshDataModel();
            }
        }
    }
}
