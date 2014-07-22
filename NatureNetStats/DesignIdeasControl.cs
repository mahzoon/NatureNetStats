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
    public partial class DesignIdeasControl : UserControl
    {
        DesignIdeasDataProvider data_provider = new DesignIdeasDataProvider();

        //DataTable designidea_table;
        //DataTable comments_table;

        List<DesignIdeaDataSource> designidea_datasource = new List<DesignIdeaDataSource>();
        List<CommentsDataSource> comments_datasource = new List<CommentsDataSource>();

        public DesignIdeasControl()
        {
            InitializeComponent();

            //designidea_table = new DataTable();
            //DataColumn c0 = new DataColumn("ID", System.Type.GetType("System.Int32")); designidea_table.Columns.Add(c0);
            //DataColumn c1 = new DataColumn("Date", System.Type.GetType("System.DateTime")); designidea_table.Columns.Add(c1);
            //DataColumn c2 = new DataColumn("Username", System.Type.GetType("System.String")); designidea_table.Columns.Add(c2);
            //DataColumn c3 = new DataColumn("Text", System.Type.GetType("System.String")); designidea_table.Columns.Add(c3);
            //DataColumn c4 = new DataColumn("Num Comments", System.Type.GetType("System.Int32")); designidea_table.Columns.Add(c4);
            //DataColumn c5 = new DataColumn("Num Likes", System.Type.GetType("System.Int32")); designidea_table.Columns.Add(c5);
            ////DataColumn c6 = new DataColumn("", System.Type.GetType("System.Double")); designidea_table.Columns.Add(c6);
            //comments_table = new DataTable();
            //DataColumn c8 = new DataColumn("DesignIdea ID", System.Type.GetType("System.Int32")); comments_table.Columns.Add(c8);
            //DataColumn c11 = new DataColumn("Level", System.Type.GetType("System.Int32")); comments_table.Columns.Add(c11);
            //DataColumn c12 = new DataColumn("Username", System.Type.GetType("System.String")); comments_table.Columns.Add(c12);
            //DataColumn c10 = new DataColumn("Text", System.Type.GetType("System.String")); comments_table.Columns.Add(c10);
            //DataColumn c7 = new DataColumn("Date", System.Type.GetType("System.DateTime")); comments_table.Columns.Add(c7);
            ////DataColumn c9 = new DataColumn("Medias", System.Type.GetType("System.Int32")); comments_table.Columns.Add(c9);
        }

        public void DataThreadEntry()
        {
            List<DesignIdeaDataSource> new_ideas = data_provider.GetNewDesignIdeas();
            designidea_datasource.AddRange(new_ideas);
            List<CommentsDataSource> new_comments = data_provider.GetNewComments();
            comments_datasource.AddRange(new_comments);
            UpdateTables();
        }

        public void UpdateTables()
        {
            if (this.dataGridView_designideas.InvokeRequired)
            {
                UpdateIdeas u = new UpdateIdeas(this.UpdateTables);
                this.dataGridView_designideas.Invoke(u);
            }
            else
            {
                dataGridView_designideas.DataSource = designidea_datasource;
                dataGridView_designideas.Refresh();
                dataGridView_comments.DataSource = comments_datasource;
                dataGridView_comments.Refresh();
            }
        }
    }

    public class DesignIdeaDataSource
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public string username { get; set; }
        public string text { get; set; }
        public int num_comments { get; set; }
        public int num_likes { get; set; }
    }

    public class CommentsDataSource
    {
        public int design_idea_id { get; set; }
        public int level { get; set; }
        public string username { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
    }
}
