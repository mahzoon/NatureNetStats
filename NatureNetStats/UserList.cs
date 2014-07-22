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
    public partial class UserList : UserControl
    {
        UserListDataProvider data_provider;
        Dictionary<string, UserItem> user_items = new Dictionary<string, UserItem>();
        int last_row = 0;
        int last_col = -1;
        int max_col = 6;

        public UserList()
        {
            InitializeComponent();
            data_provider = new UserListDataProvider();
            this.tableLayoutPanel_frame.ColumnStyles[1].Width = max_col * 127;
            this.tableLayoutPanel_items.ColumnStyles.Clear();
            this.tableLayoutPanel_items.ColumnCount = max_col;
            for (int counter = 0; counter < max_col; counter++)
                this.tableLayoutPanel_items.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel_items.Update();
            //this.tableLayoutPanel_items.Width = max_col * 126;
            //this.tableLayoutPanel_items.BackColor = Color.Red;
        }

        public void DataThreadEntry()
        {
            List<UserItemInfo> new_user_items = data_provider.GetUserItemList();
            if (new_user_items.Count > 0) UpdateUsersList(new_user_items);
        }

        public void UpdateUsersList(List<UserItemInfo> new_user_items)
        {
            if (this.InvokeRequired)
            {
                UpdateUsers u = new UpdateUsers(this.UpdateUsersList);
                this.Invoke(u, new object[] { new_user_items });
            }
            else
            {
                //this.tableLayoutPanel_items.Visible = false;
                this.tableLayoutPanel_items.RowStyles.Clear();
                this.tableLayoutPanel_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 233F));
                for (int counter = 0; counter < new_user_items.Count; counter++)
                {
                    if (user_items.ContainsKey(new_user_items[counter].username))
                    {
                        user_items[new_user_items[counter].username].SetValues(new_user_items[counter]);
                    }
                    else
                    {
                        int col = 0; int row = 0;
                        if (last_col == max_col - 1)
                        {
                            col = 0;
                            row = last_row + 1;
                            this.tableLayoutPanel_items.RowStyles.Add(new RowStyle(SizeType.Absolute, 233F));
                        }
                        else
                        {
                            col = last_col + 1;
                            row = last_row;
                        }
                        UserItem ui = new UserItem();
                        ui.SetValues(new_user_items[counter]);
                        this.tableLayoutPanel_items.Controls.Add(ui, col, row);
                        this.tableLayoutPanel_items.Height = (this.tableLayoutPanel_items.RowStyles.Count) * 235;
                        this.tableLayoutPanel_frame.Height = (this.tableLayoutPanel_items.RowStyles.Count) * 235;
                        last_row = row;
                        last_col = col;
                        this.user_items.Add(new_user_items[counter].username, ui);
                    }
                }
                this.tableLayoutPanel_items.RowCount = ((this.tableLayoutPanel_items.Controls.Count - 1) / max_col) + 1;
                //this.Height = (this.tableLayoutPanel_items.RowStyles.Count) * 235 + this.tableLayoutPanel_header.Height;
                if (radioButton_atoz.Checked) SortByAZ();
                if (radioButton_recent.Checked) SortByRecent();
                if (radioButton_top.Checked) SortByTop();
                //this.tableLayoutPanel_items.Refresh();
                //this.tableLayoutPanel_items.Update();
                //this.tableLayoutPanel_items.Visible = true;
            }
        }

        private void radioButton_atoz_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanel_items.Visible = false;
            SortByAZ();
            this.tableLayoutPanel_items.Visible = true;
        }

        private void SortByAZ()
        {
            List<UserItem> ui = user_items.Values.ToList();
            ui.Sort((x, y) => UserItem.CompareUserItemName(x, y));
            for (int counter = 0; counter < ui.Count; counter++)
            {
                UserItem u1 = user_items[ui[counter].GetUsername()];
                TableLayoutPanelCellPosition position1 = tableLayoutPanel_items.GetPositionFromControl(u1);
                UserItem u2 = (UserItem)this.tableLayoutPanel_items.GetControlFromPosition(counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Remove(u1); this.tableLayoutPanel_items.Controls.Remove(u2);
                this.tableLayoutPanel_items.Controls.Add(u1, counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Add(u2, position1.Column, position1.Row);
            }            
        }

        private void radioButton_top_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanel_items.Visible = false;
            SortByTop();
            this.tableLayoutPanel_items.Visible = true;
        }

        private void SortByTop()
        {
            List<UserItem> ui = user_items.Values.ToList();
            ui.Sort((x, y) => UserItem.CompareUserItemNumContrib(x, y));
            for (int counter = 0; counter < ui.Count; counter++)
            {
                UserItem u1 = user_items[ui[counter].GetUsername()];
                TableLayoutPanelCellPosition position1 = tableLayoutPanel_items.GetPositionFromControl(u1);
                UserItem u2 = (UserItem)this.tableLayoutPanel_items.GetControlFromPosition(counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Remove(u1); this.tableLayoutPanel_items.Controls.Remove(u2);
                this.tableLayoutPanel_items.Controls.Add(u1, counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Add(u2, position1.Column, position1.Row);
            }
        }

        private void radioButton_recent_CheckedChanged(object sender, EventArgs e)
        {
            this.tableLayoutPanel_items.Visible = false;
            SortByRecent();
            this.tableLayoutPanel_items.Visible = true;
        }

        private void SortByRecent()
        {
            List<UserItem> ui = user_items.Values.ToList();
            ui.Sort((x, y) => UserItem.ComapereUserItemDate(x, y));
            for (int counter = 0; counter < ui.Count; counter++)
            {
                UserItem u1 = user_items[ui[counter].GetUsername()];
                TableLayoutPanelCellPosition position1 = tableLayoutPanel_items.GetPositionFromControl(u1);
                UserItem u2 = (UserItem)this.tableLayoutPanel_items.GetControlFromPosition(counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Remove(u1); this.tableLayoutPanel_items.Controls.Remove(u2);
                this.tableLayoutPanel_items.Controls.Add(u1, counter % max_col, counter / max_col);
                this.tableLayoutPanel_items.Controls.Add(u2, position1.Column, position1.Row);
            }
        }
    }
}
