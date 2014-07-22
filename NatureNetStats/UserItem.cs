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
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
        }

        public void SetValues(string uname, int n_obsv, int n_comments, int n_ideas, int n_badges)
        {
            this.label_username.Text = uname;
            this.label_observations.Text = n_obsv.ToString();
            this.label_designideas.Text = n_ideas.ToString();
            this.label_comments.Text = n_comments.ToString();
            this.label_badges.Text = n_badges.ToString();
        }

        public void SetValues(UserItemInfo ui)
        {
            this.label_username.Text = ui.username;
            this.label_observations.Text = ui.num_observations.ToString();
            this.label_designideas.Text = ui.num_designideas.ToString();
            this.label_comments.Text = ui.num_comments.ToString();
            this.label_badges.Text = ui.num_badges.ToString();
            string path = Configurations.GetAbsoluteAvatarPath() + ui.avatar;
            this.pictureBox_avatar.BackgroundImage = Image.FromFile(path);
            if (ui.last_contribution_date.HasValue)
                this.label_lastdate.Text = ui.last_contribution_date.Value.Date.ToString("MM/dd");
        }

        public string GetUsername()
        {
            return label_username.Text;
        }

        public static int CompareUserItemName(UserItem i1, UserItem i2)
        {
            return i1.label_username.Text.CompareTo(i2.label_username.Text);
        }
        public static int CompareUserItemNumContrib(UserItem i1, UserItem i2)
        {
            return (Convert.ToInt32(i2.label_observations.Text) + Convert.ToInt32(i2.label_designideas.Text)).CompareTo(
                Convert.ToInt32(i1.label_observations.Text) + Convert.ToInt32(i1.label_designideas.Text));
        }
        public static int ComapereUserItemDate(UserItem i1, UserItem i2)
        {
            if (i1.label_lastdate.Text == "N/A") return 1;
            if (i2.label_lastdate.Text == "N/A") return -1;
            return DateTime.ParseExact(i2.label_lastdate.Text, "MM/dd", null).CompareTo(
                DateTime.ParseExact(i1.label_lastdate.Text, "MM/dd", null));
        }
    }
}
