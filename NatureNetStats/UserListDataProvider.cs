using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureNetStats
{
    class UserListDataProvider
    {
        Dictionary<string, UserItemInfo> users_list = new Dictionary<string, UserItemInfo>();

        public List<UserItemInfo> GetUserItemList()
        {
            NatureNetDataClassesDataContext db = DatabaseManager.GetNewDBContext();
            List<UserItemInfo> change_list = new List<UserItemInfo>();
            if (DatabaseChange.last_user_id_changed)
            {
                foreach (User u in DatabaseChange.last_users_list)
                {
                    UserItemInfo i = new UserItemInfo();
                    i.username = u.name; i.avatar = u.avatar;
                    users_list.Add(u.name, i);
                    change_list.Add(i);
                }
            }
            if (DatabaseChange.last_feedback_id_changed)
            {
                foreach(Feedback f in DatabaseChange.last_feedbacks_list)
                {
                    if (f.type_id == 1) // comment
                    {
                        string uname = DatabaseManager.GetUserName(db, f.user_id);
                        if (users_list.ContainsKey(uname))
                        {
                            users_list[uname].num_comments++;
                            if (!change_list.Contains(users_list[uname]))
                                change_list.Add(users_list[uname]);
                        }
                    }
                    if (f.type_id == 2 && f.object_type == "nature_net.Contribution") //like
                        UpdateNumBadges(db, f, change_list);
                }
            }
            if (DatabaseChange.last_design_idea_id_changed)
            {
                foreach (Design_Idea d in DatabaseChange.last_design_ideas_list)
                {
                    if (users_list.ContainsKey(d.name))
                    {
                        users_list[d.name].num_designideas++;
                        users_list[d.name].ReplaceDateIfMoreRecent(d.date);
                        if (!change_list.Contains(users_list[d.name]))
                            change_list.Add(users_list[d.name]);
                    }
                }
            }
            if (DatabaseChange.last_observation_id_changed)
            {
                foreach (Contribution c in DatabaseChange.last_observations_list)
                {
                    UpdateNumObservations(db, c, change_list);
                }
            }
            return change_list;
        }

        private void UpdateNumBadges(NatureNetDataClassesDataContext db, Feedback f, List<UserItemInfo> change_list)
        {
            // f is of type 'like' and has a reference to a contribution (object_id)
            if (!f.object_id.HasValue || f.type_id != 2) return;
            User u = DatabaseManager.GetUserOfContribution(db, f.object_id.Value);
            if (users_list.ContainsKey(u.name))
            {
                users_list[u.name].num_badges++;
                if (!change_list.Contains(users_list[u.name]))
                    change_list.Add(users_list[u.name]);
            }
        }
        private void UpdateNumObservations(NatureNetDataClassesDataContext db, Contribution c, List<UserItemInfo> change_list)
        {
            User u = DatabaseManager.GetUserOfContribution(db, c.id);
            if (users_list.ContainsKey(u.name))
            {
                users_list[u.name].num_observations++;
                users_list[u.name].ReplaceDateIfMoreRecent(c.date);
                if (!change_list.Contains(users_list[u.name]))
                    change_list.Add(users_list[u.name]);
            }
        }
    }

    public class UserItemInfo
    {
        public string avatar { get; set; }
        public string username { get; set; }
        public int num_observations { get; set; }
        public int num_designideas { get; set; }
        public int num_comments { get; set; }
        public int num_badges { get; set; }
        public DateTime? last_contribution_date { get; set; }

        public void ReplaceDateIfMoreRecent(DateTime dt)
        {
            if (!last_contribution_date.HasValue)
                last_contribution_date = dt;
            else
                if (dt.CompareTo(last_contribution_date.Value) > 0)
                    last_contribution_date = dt;
        }
    }
}
