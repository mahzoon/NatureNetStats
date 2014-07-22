using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureNetStats
{
    class ActivityDataProvider
    {
        public List<Activity> GetActivites()
        {
            NatureNetDataClassesDataContext db = DatabaseManager.GetNewDBContext();
            var acs = from a in db.Activities
                      where a.id > 1
                      select a;
            if (acs.Count() == 0) return new List<Activity>();
            return acs.ToList<Activity>();
        }

        public Dictionary<int, List<ActivityItemDataSource>> GetNewContributionsInActivity()
        {
            Dictionary<int, List<ActivityItemDataSource>> changes = new Dictionary<int, List<ActivityItemDataSource>>();
            if (DatabaseChange.last_observation_id_changed)
            {
                NatureNetDataClassesDataContext db=DatabaseManager.GetNewDBContext();
                foreach (Contribution c in DatabaseChange.last_observations_list)
                {
                    ActivityItemDataSource data = new ActivityItemDataSource();
                    data.date = c.date; data.location = c.Location.name;
                    Activity a = DatabaseManager.GetActivityOfContribution(db, c.id);
                    User u = DatabaseManager.GetUserOfContribution(db, c.id);
                    data.username = u.name; data.note = c.note;
                    if (changes.ContainsKey(a.id))
                    {
                        if (!changes[a.id].Contains(data))
                            changes[a.id].Add(data);
                    }
                    else
                    {
                        List<ActivityItemDataSource> contribs = new List<ActivityItemDataSource>();
                        contribs.Add(data);
                        changes.Add(a.id, contribs);
                    }
                }
            }
            return changes;
        }
    }
}
