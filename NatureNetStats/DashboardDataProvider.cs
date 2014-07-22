using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureNetStats
{
    class DashboardDataProvider
    {
        private Statistics db_stats = new Statistics();
        private Dictionary<string, DailyLogDataSource> daily_log_data = new Dictionary<string, DailyLogDataSource>();
        private List<Interaction_Log> interaction_logs = new List<Interaction_Log>();

        private List<DailyLogDataSource> interaction_changes = new List<DailyLogDataSource>();
        private List<DailyLogDataSource> observation_changes = new List<DailyLogDataSource>();
        private List<DailyLogDataSource> design_idea_changes = new List<DailyLogDataSource>();

        ///////// First Section of Dashboard /////////
        public int GetChangeInDailyData()
        {
            if (DatabaseChange.last_interaction_id_changed)
            {
                foreach (Interaction_Log log in DatabaseChange.last_interactions_list)
                {
                    string date = Configurations.GetDate_Formatted_Without_Year(log.date);
                    if (daily_log_data.ContainsKey(date))
                        daily_log_data[date].interactions = daily_log_data[date].interactions + 1;
                    else
                    {
                        DailyLogDataSource log_data = new DailyLogDataSource(log.date.Date);
                        log_data.interactions = 1;
                        daily_log_data.Add(date, log_data);
                    }
                    interaction_logs.Add(log);
                    interaction_changes.Add(daily_log_data[date]);
                }
            }
            if (DatabaseChange.last_observation_id_changed)
            {
                foreach (Contribution contrib in DatabaseChange.last_observations_list)
                {
                    string date = Configurations.GetDate_Formatted_Without_Year(contrib.date);
                    if (daily_log_data.ContainsKey(date))
                        daily_log_data[date].medias = daily_log_data[date].medias + 1;
                    else
                    {
                        DailyLogDataSource log_data = new DailyLogDataSource(contrib.date.Date);
                        log_data.medias = 1;
                        daily_log_data.Add(date, log_data);
                    }
                    observation_changes.Add(daily_log_data[date]);
                }
            }
            if (DatabaseChange.last_design_idea_id_changed)
            {
                foreach (Design_Idea contrib in DatabaseChange.last_design_ideas_list)
                {
                    string date = Configurations.GetDate_Formatted_Without_Year(contrib.date.Date);
                    if (daily_log_data.ContainsKey(date))
                        daily_log_data[date].ideas = daily_log_data[date].ideas + 1;
                    else
                    {
                        DailyLogDataSource log_data = new DailyLogDataSource(contrib.date);
                        log_data.ideas = 1;
                        daily_log_data.Add(date, log_data);
                    }
                    design_idea_changes.Add(daily_log_data[date]);
                }
            }
            return interaction_changes.Count + observation_changes.Count + design_idea_changes.Count;
        }
        public List<DailyLogDataSource> GetChangeInDailyData_Interactions()
        {
            return interaction_changes;
        }
        public List<DailyLogDataSource> GetChangeInDailyData_Observations()
        {
            return observation_changes;
        }
        public List<DailyLogDataSource> GetChangeInDailyData_DesignIdeas()
        {
            return design_idea_changes;
        }
        public void ResetDailyChanges()
        {
            interaction_changes.Clear();
            observation_changes.Clear();
            design_idea_changes.Clear();
        }

        ///////// Second Section of Dashboard /////////
        public Statistics GetStatistics()
        {
            // update db_stats and return it
            NatureNetDataClassesDataContext db = DatabaseManager.GetNewDBContext();
            if (DatabaseChange.last_user_id_changed)
            {
                db_stats.num_users = DatabaseManager.GetNumUsers(db);
            }
            if (DatabaseChange.last_observation_id_changed)
            {
                db_stats.num_observations = DatabaseManager.GetNumObservations(db);
            }
            if (DatabaseChange.last_feedback_id_changed)
            {
                db_stats.num_likes = DatabaseManager.GetNumLikes(db);
                db_stats.num_comments = DatabaseManager.GetNumComments(db);
            }
            if (DatabaseChange.last_interaction_id_changed)
            {
                db_stats.num_interactions = DatabaseManager.GetNumInteraction(db);
            }
            if (DatabaseChange.last_design_idea_id_changed)
            {
                db_stats.num_designideas = DatabaseManager.GetNumDesignIdeas(db);
            }
            return db_stats;
        }

        ///////// Third Section of Dashboard -- Part A /////////
        public List<InteractionLogDataSource> GetInteractionLogDataSource(DateTime _from, DateTime _to)
        {
            DateTime _from_limit = _from.Date;
            DateTime _to_limit = _to.AddDays(1).Date;
            var ilogs = interaction_logs
                .Where(i => i.date.CompareTo(_from_limit) >= 0 && i.date.CompareTo(_to_limit) < 0)
                .OrderBy(i => i.date);
            if (ilogs.Count() == 0) return new List<InteractionLogDataSource>();
            List<InteractionLogDataSource> results = new List<InteractionLogDataSource>();
            foreach (var log in ilogs)
            {
                InteractionLogDataSource i = new InteractionLogDataSource();
                i.date = log.date; i.details = log.details; i.type = log.Interaction_Type.type;
                i.touch_id = log.touch_id; i.touch_x = log.touch_x; i.touch_y = log.touch_y;
                results.Add(i);
            }
            return results;
        }

        ///////// Third Section of Dashboard -- Part B /////////
        public List<DailyLogDataSource> GetDailyLogDataSource(DateTime _from, DateTime _to)
        {
            return DatabaseManager.GetDailyLogDataSource(_from, _to);
        }
    }

    public class InteractionLogData : IComparable 
    {
        public DateTime date { get; set; }
        public int num_interactions { get; set; }
        int IComparable.CompareTo(object to)
        {
            return date.CompareTo(((InteractionLogData)to).date);
        }
        public InteractionLogData(DateTime d)
        {
            date = new DateTime(d.Year, d.Month, d.Day);
            num_interactions = 1;
        }
    }

    public class Statistics
    {
        public int num_designideas { get; set; }
        public int num_observations { get; set; }
        public int num_users { get; set; }
        public int num_comments { get; set; }
        public int num_likes { get; set; }
        public int num_interactions { get; set; }
    }

    public class InteractionLogDataSource
    {
        public DateTime date { get; set; }
        public string type { get; set; }
        public string details { get; set; }
        public int touch_id { get; set; }
        public double touch_x { get; set; }
        public double touch_y { get; set; }
    }

    public class DailyLogDataSource
    {
        public DateTime date { get; set; }
        public int ideas { get; set; }
        public int medias { get; set; }
        public int comments { get; set; }
        public int likes { get; set; }
        public int interactions { get; set; }

        public DailyLogDataSource(DateTime d)
        {
            //date = new DateTime(d.Year, d.Month, d.Day);
            date = d;
            ideas = 0; medias = 0; comments = 0; likes = 0; interactions = 0;
        }
    }
}
