using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatureNetStats
{
    class DesignIdeasDataProvider
    {
        Dictionary<int, DesignIdeaDataSource> design_ideas = new Dictionary<int, DesignIdeaDataSource>();
        Dictionary<int, CommentsDataSource> comments = new Dictionary<int, CommentsDataSource>();

        public List<DesignIdeaDataSource> GetNewDesignIdeas()
        {
            List<DesignIdeaDataSource> changes = new List<DesignIdeaDataSource>();
            if (DatabaseChange.last_design_idea_id_changed)
            {
                foreach (Design_Idea d in DatabaseChange.last_design_ideas_list)
                {
                    if (!design_ideas.ContainsKey(d.id))
                    {
                        DesignIdeaDataSource dids = new DesignIdeaDataSource();
                        dids.date = d.date; dids.ID = d.id; dids.text = d.note; dids.username = d.name;
                        design_ideas.Add(d.id, dids);
                    }
                    //else
                    //{
                    //    design_ideas[d.id].date = d.date; design_ideas[d.id].text = d.note;
                    //    design_ideas[d.id].username = d.name;
                    //}
                    changes.Add(design_ideas[d.id]);
                }
            }
            if (DatabaseChange.last_feedback_id_changed)
            {
                foreach (Feedback f in DatabaseChange.last_feedbacks_list)
                {
                    if (f.type_id == 1 && f.object_type == "nature_net.Contribution") //comment
                    {
                        if (!f.object_id.HasValue) continue;
                        if (design_ideas.ContainsKey(f.object_id.Value))
                        {
                            design_ideas[f.object_id.Value].num_comments++;
                            if (!changes.Contains(design_ideas[f.object_id.Value]))
                                changes.Add(design_ideas[f.object_id.Value]);
                            //CommentsDataSource comment = new CommentsDataSource();
                            //comment.date = f.date; comment.design_idea_id = f.object_id.Value;
                            //comment.text = f.note; comment.username = f.User.name;
                            //comment.level = DatabaseManager.GetLevelOfComment(DatabaseManager.GetNewDBContext(), f);
                            //comments.Add(f.id, comment);
                        }
                    }
                    if (f.type_id == 2 && f.object_type == "nature_net.Contribution") //like
                    {
                        if (!f.object_id.HasValue) continue;
                        if (design_ideas.ContainsKey(f.object_id.Value))
                        {
                            design_ideas[f.object_id.Value].num_likes++;
                            if (!changes.Contains(design_ideas[f.object_id.Value]))
                                changes.Add(design_ideas[f.object_id.Value]);
                        }
                    }
                }
            }
            return changes;
        }

        public List<CommentsDataSource> GetNewComments()
        {
            List<CommentsDataSource> changes = new List<CommentsDataSource>();
            if (DatabaseChange.last_feedback_id_changed)
            {
                foreach (Feedback f in DatabaseChange.last_feedbacks_list)
                {
                    if (f.type_id == 1 && f.object_type == "nature_net.Contribution") //comment
                    {
                        if (!f.object_id.HasValue) continue;
                        if (design_ideas.ContainsKey(f.object_id.Value))
                        {
                            //design_ideas[f.object_id.Value].num_comments++;
                            //changes.Add(design_ideas[f.object_id.Value]);
                            CommentsDataSource comment = new CommentsDataSource();
                            comment.date = f.date; comment.design_idea_id = f.object_id.Value;
                            comment.text = f.note; comment.username = f.User.name;
                            comment.level = DatabaseManager.GetLevelOfComment(DatabaseManager.GetNewDBContext(), f);
                            comments.Add(f.id, comment);
                            changes.Add(comment);
                        }
                    }
                    //if (f.type_id == 2 && f.object_type == "nature_net.Contribution") //like
                    //{
                    //    if (!f.object_id.HasValue) continue;
                    //    if (design_ideas.ContainsKey(f.object_id.Value))
                    //    {
                    //        design_ideas[f.object_id.Value].num_likes++;
                    //        changes.Add(design_ideas[f.object_id.Value]);
                    //    }
                    //}
                }
            }
            return changes;
        }
    }
}
