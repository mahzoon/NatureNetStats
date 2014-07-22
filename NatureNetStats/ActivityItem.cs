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
    public partial class ActivityItem : UserControl
    {
        public List<ActivityItemDataSource> contributions = new List<ActivityItemDataSource>();

        public ActivityItem()
        {
            InitializeComponent();
            Contribution c;
            //c.
            // Setting Columns of the GridView
        }

        public void SetValues(string activity_text, string activity_desc)
        {
            this.label_activity.Text = activity_text;
            this.label_desc.Text = activity_desc;
        }

        public void RefreshDataModel()
        {
            this.dataGridView_contributions.DataSource = this.contributions;
            this.dataGridView_contributions.Refresh();
        }

        public void RefreshDataModel(object data_source)
        {
            this.dataGridView_contributions.DataSource = data_source;
            this.dataGridView_contributions.Refresh();
        }
    }

    public class ActivityItemDataSource
    {
        public DateTime date { set; get; }
        public string username { set; get; }
        public string note { set; get; }
        public string location { set; get; }
    }
}
