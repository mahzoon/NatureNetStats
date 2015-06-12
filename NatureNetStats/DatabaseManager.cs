using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureNetStats
{
    public static class DatabaseManager
    {
        public static NatureNetDataClassesDataContext GetNewDBContext()
        {
            return GetTableTopDB();
        }

        public static int GetNumObservations(NatureNetDataClassesDataContext db)
        {
            var contrib1 = from d in db.Contributions
                           where (d.tags != "Design Idea")
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumObservations(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var contrib1 = from d in db.Contributions
                           where (d.tags != "Design Idea") && (d.date.CompareTo(_from) >= 0) && (d.date.CompareTo(_to) < 0)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumDesignIdeas(NatureNetDataClassesDataContext db)
        {
            var contrib1 = from d in db.Design_Ideas
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumDesignIdeas(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var contrib1 = from d in db.Design_Ideas
                           where (d.date.CompareTo(_from) >= 0) && (d.date.CompareTo(_to) < 0)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumComments(NatureNetDataClassesDataContext db)
        {
            var contrib1 = from d in db.Feedbacks
                           where (d.type_id == 1)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumComments(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var contrib1 = from d in db.Feedbacks
                           where (d.type_id == 1) && (d.date.CompareTo(_from) >= 0) && (d.date.CompareTo(_to) < 0)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumComments(NatureNetDataClassesDataContext db, int user_id)
        {
            var comments = from f in db.Feedbacks
                           where (f.type_id == 1) && (f.user_id == user_id)
                           select f.id;
            return comments.Count();
        }
        public static int GetNumLikes(NatureNetDataClassesDataContext db)
        {
            var contrib1 = from d in db.Feedbacks
                           where (d.type_id == 2)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumLikes(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var contrib1 = from d in db.Feedbacks
                           where (d.type_id == 2) && (d.date.CompareTo(_from) >= 0) && (d.date.CompareTo(_to) < 0)
                           select d.id;
            return contrib1.Count();
        }
        public static int GetNumInteraction(NatureNetDataClassesDataContext db)
        {
            var date_log = from i in db.Interaction_Logs
                           select i.id;
            return date_log.Count();
        }
        public static int GetNumInteraction(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var date_log = from i in db.Interaction_Logs
                           where (i.date.CompareTo(_from) >= 0) && (i.date.CompareTo(_to) < 0)
                           select i.id;
            return date_log.Count();
        }
        public static int GetNumUsers(NatureNetDataClassesDataContext db)
        {
            var users = from u in db.Users
                        where u.id > 0
                        select u.id;
            return users.Count();
        }
        public static int GetNumActiveUsers(NatureNetDataClassesDataContext db)
        {
            var logs1 = from i in db.Interaction_Logs
                        where (i.type == 29) || (i.type == 38)
                        select i;
            List<int> distinct_users = new List<int>();
            string search_str = "user id: ";
            foreach (Interaction_Log log in logs1)
            {
                int i = log.details.IndexOf(search_str);
                if (i == -1) continue;
                i = i + search_str.Length;
                string n = "";
                while (i < log.details.Length && Char.IsDigit(log.details[i])) { n = n + log.details[i]; i++; }
                int id = -1;
                try { id = Convert.ToInt32(n); }
                catch (Exception) { continue; }
                if (!distinct_users.Contains(id)) distinct_users.Add(id);
            }
            var logs2 = from i in db.Interaction_Logs
                        where (i.type == 38)
                        select i;
            foreach (Interaction_Log log in logs2)
            {
                string uname = "";
                try { uname = log.details.Split(new char[] { '=' })[1]; }
                catch (Exception) { continue; }
                int id = GetUserID(db, uname);
                if (id == -1) continue;
                if (!distinct_users.Contains(id)) distinct_users.Add(id);
            }
            return distinct_users.Count();
        }
        public static int GetNumActiveUsers(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var logs1 = from i in db.Interaction_Logs
                        where (i.type == 29) && (i.date.CompareTo(_from) >= 0) && (i.date.CompareTo(_to) < 0)
                        select i;
            List<int> distinct_users = new List<int>();
            string search_str = "user id: ";
            foreach (Interaction_Log log in logs1)
            {
                int id = -1;
                int i = log.details.IndexOf(search_str);
                if (i == -1)
                    continue;
                i = i + search_str.Length;
                string n = "";
                while (i < log.details.Length && Char.IsDigit(log.details[i])) { n = n + log.details[i]; i++; }
                try { id = Convert.ToInt32(n); }
                catch (Exception) { continue; }
                if (!distinct_users.Contains(id)) distinct_users.Add(id);
            }
            var logs2 = from i in db.Interaction_Logs
                        where (i.type == 38) && (i.date.CompareTo(_from) >= 0) && (i.date.CompareTo(_to) < 0)
                        select i;
            foreach (Interaction_Log log in logs2)
            {
                string uname="";
                try { uname = log.details.Split(new char[] { '=' })[1]; }
                catch (Exception) { continue; }
                int id = GetUserID(db, uname);
                if (id == -1) continue;
                if (!distinct_users.Contains(id)) distinct_users.Add(id);
            }
            return distinct_users.Count();
        }
        public static int GetNumNewUsers(NatureNetDataClassesDataContext db)
        {
            var users = from i in db.Interaction_Logs
                        where (i.type == 38)
                        select i;
            return users.Count();
        }
        public static int GetNumNewUsers(NatureNetDataClassesDataContext db, DateTime _from, DateTime _to)
        {
            var users = from i in db.Interaction_Logs
                        where (i.type == 38) && (i.date.CompareTo(_from) >= 0) && (i.date.CompareTo(_to) < 0)
                        select i;
            return users.Count();
        }
        public static int GetLevelOfComment(NatureNetDataClassesDataContext db, Feedback f)
        {
            if (f.parent_id == 0) return 0;
            int level = 0;
            Feedback f2 = f;
            while (f2 != null && f2.parent_id != 0)
            {
                var fv = from fs in db.Feedbacks
                         where fs.id == f2.parent_id
                         select fs;
                f2 = fv.First<Feedback>();
                level++;
            }
            return level;
        }
        public static string GetUserName(NatureNetDataClassesDataContext db, int user_id)
        {
            var users = from u in db.Users
                        where u.id == user_id
                        select u;
            if (users.Count() != 1) return "";
            return users.Single<User>().name;
        }
        public static int GetUserID(NatureNetDataClassesDataContext db, string username)
        {
            var users = from u in db.Users
                        where u.name == username
                        select u;
            if (users.Count() != 1) return -1;
            return users.Single<User>().id;
        }

        public static List<DailyLogDataSource> GetDailyLogDataSource(DateTime _from, DateTime _to)
        {
            NatureNetDataClassesDataContext db = GetNewDBContext();
            DateTime dt_from = _from.Date;
            DateTime dt_to = _from.Date; dt_to = dt_to.AddDays(1);
            int num_days = Convert.ToInt32((_to - _from).TotalDays);
            List<DailyLogDataSource> results = new List<DailyLogDataSource>();
            for (int counter = 0; counter <= num_days; counter++)
            {
                DailyLogDataSource log = new DailyLogDataSource(dt_from);
                log.comments = GetNumComments(db, dt_from, dt_to);
                log.ideas = GetNumDesignIdeas(db, dt_from, dt_to);
                log.interactions = GetNumInteraction(db, dt_from, dt_to);
                log.likes = GetNumLikes(db, dt_from, dt_to);
                log.medias = GetNumObservations(db, dt_from, dt_to);
                log.date = dt_from;
                log.num_active_users = GetNumActiveUsers(db, dt_from, dt_to);
                log.num_new_users = GetNumNewUsers(db, dt_from, dt_to);
                if (log.comments != 0 || log.ideas != 0 || log.interactions != 0 ||
                    log.likes != 0 || log.medias != 0 || log.num_active_users != 0 || log.num_new_users != 0)
                    results.Add(log);
                dt_from = dt_from.AddDays(1);
                dt_to = dt_to.AddDays(1);
            }
            return results;
        }

        public static User GetUserOfContribution(NatureNetDataClassesDataContext db, int contribution_id)
        {
            var users = from mappings in db.Collection_Contribution_Mappings
                        where mappings.contribution_id == contribution_id
                        select mappings.Collection.User;
            if (users == null) return null;
            if (users.Count() == 0) return null;
            return users.First<User>();
        }
        public static Activity GetActivityOfContribution(NatureNetDataClassesDataContext db, int contribution_id)
        {
            var activities = from mappings in db.Collection_Contribution_Mappings
                             where mappings.contribution_id == contribution_id
                             select mappings.Collection.Activity;
            if (activities == null) return null;
            if (activities.Count() == 0) return null;
            return activities.First<Activity>();
        }

        private static NatureNetDataClassesDataContext GetTableTopDB()
        {
            if (Configurations.site_name == "aces")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_aces);
            if (Configurations.site_name == "umd")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_umd);
            if (Configurations.site_name == "uncc")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_uncc);
            return new NatureNetDataClassesDataContext();
        }
    }

    public static class DatabaseChange
    {
        private static int _last_user_id = 0;
        public static bool last_user_id_changed { get; private set; }
        public static List<User> last_users_list { get; private set; }
        public static int last_user_id
        {
            get { return _last_user_id; }
            set
            {
                last_user_id_changed = true;
                _last_user_id = value;
            }
        }
        ///////////////////////////////////////////////////
        private static long _last_interaction_id = 0;
        public static bool last_interaction_id_changed { get; private set; }
        public static List<Interaction_Log> last_interactions_list { get; private set; }
        public static long last_interaction_id
        {
            get { return _last_interaction_id; }
            set
            {
                last_interaction_id_changed = true;
                _last_interaction_id = value;
            }
        }
        ///////////////////////////////////////////////////
        private static int _last_observation_id = 0;
        public static bool last_observation_id_changed { get; private set; }
        public static List<Contribution> last_observations_list { get; private set; }
        public static int last_observation_id
        {
            get { return _last_observation_id; }
            set
            {
                last_observation_id_changed = true;
                _last_observation_id = value;
            }
        }
        ///////////////////////////////////////////////////
        private static int _last_design_idea_id = 0;
        public static bool last_design_idea_id_changed { get; private set; }
        public static List<Design_Idea> last_design_ideas_list { get; private set; }
        public static int last_design_idea_id
        {
            get { return _last_design_idea_id; }
            set
            {
                last_design_idea_id_changed = true;
                _last_design_idea_id = value;
            }
        }
        ///////////////////////////////////////////////////
        private static int _last_feedback_id = 0;
        public static bool last_feedback_id_changed { get; private set; }
        public static List<Feedback> last_feedbacks_list { get; private set; }
        public static int last_feedback_id
        {
            get { return _last_feedback_id; }
            set
            {
                last_feedback_id_changed = true;
                _last_feedback_id = value;
            }
        }
        ///////////////////////////////////////////////////
        
        public static void ResetChangedFlags()
        {
            last_design_idea_id_changed = false; last_design_ideas_list = new List<Design_Idea>();
            last_feedback_id_changed = false; last_feedbacks_list = new List<Feedback>();
            last_interaction_id_changed = false; last_interactions_list = new List<Interaction_Log>();
            last_observation_id_changed = false; last_observations_list = new List<Contribution>();
            last_user_id_changed = false; last_users_list = new List<User>();
        }
        public static void CheckForChanges()
        {
            NatureNetDataClassesDataContext db = GetTableTopDB();
            //////////// Users ////////////
            var v1 = from u in db.Users
                     where u.id > last_user_id
                     orderby u.id
                     select u;
            if (v1.Count() > 0)
            {
                last_users_list = v1.ToList<User>();
                last_user_id = last_users_list[last_users_list.Count - 1].id;
            }
            //////////// Observations ////////////
            var v2 = from u in db.Contributions
                     where (u.tags != "Design Idea") && (u.id > last_observation_id)
                     orderby u.id
                     select u;
            if (v2.Count() > 0)
            {
                last_observations_list = v2.ToList<Contribution>();
                last_observation_id = last_observations_list[last_observations_list.Count - 1].id;
            }
            //////////// Interactions ////////////
            var v3 = from u in db.Interaction_Logs
                     where u.id > last_interaction_id
                     orderby u.id
                     select u;
            if (v3.Count() > 0)
            {
                last_interactions_list = v3.ToList<Interaction_Log>();
                last_interaction_id = last_interactions_list[last_interactions_list.Count - 1].id;
            }
            //////////// Feedbacks ////////////
            var v4 = from u in db.Feedbacks
                     where u.id > last_feedback_id
                     orderby u.id
                     select u;
            if (v4.Count() > 0)
            {
                last_feedbacks_list = v4.ToList<Feedback>();
                last_feedback_id = last_feedbacks_list[last_feedbacks_list.Count - 1].id;
            }
            //////////// DesignIdeas ////////////
            var v5 = from u in db.Design_Ideas
                     where u.id > last_design_idea_id
                     orderby u.id
                     select u;
            if (v5.Count() > 0)
            {
                last_design_ideas_list = v5.ToList<Design_Idea>();
                last_design_idea_id = last_design_ideas_list[last_design_ideas_list.Count - 1].id;
            }
        }

        private static NatureNetDataClassesDataContext GetTableTopDB()
        {
            if (Configurations.site_name == "aces")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_aces);
            if (Configurations.site_name == "umd")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_umd);
            if (Configurations.site_name == "uncc")
                return new NatureNetDataClassesDataContext(NatureNetStats.Properties.Settings.Default.nature_netConnectionString_uncc);
            return new NatureNetDataClassesDataContext();
        }
    }
}
