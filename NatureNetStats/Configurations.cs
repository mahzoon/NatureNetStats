using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace NatureNetStats
{
    class Configurations
    {
        public static int data_refresh_rate = 40000;
        public static int data_timer_step = 200;
        //static string image_path = ".\\images\\";
        static string avatar_path = ".\\avatars\\";
        static string config_file = "config.ini";
        public static string site_name = "aces";

        public static void SaveSettings()
		{
			INIParser parser = new INIParser(GetAbsoluteConfigFilePath(), Encoding.UTF8);
            parser.SetValue("Parameters", "last_user_id", DatabaseChange.last_user_id);
            parser.SetValue("Parameters", "last_observation_id", DatabaseChange.last_observation_id);
            parser.SetValue("Parameters", "last_interaction_id", DatabaseChange.last_interaction_id);
            parser.SetValue("Parameters", "last_feedback_id", DatabaseChange.last_feedback_id);
            parser.SetValue("Parameters", "last_design_idea_id", DatabaseChange.last_design_idea_id);
            parser.Save(GetAbsoluteConfigFilePath(), Encoding.UTF8);
		}

        public static void LoadSettings()
        {
            INIParser parser = new INIParser(GetAbsoluteConfigFilePath(), Encoding.UTF8);
            DatabaseChange.last_design_idea_id = parser.GetValue("Parameters", "last_design_idea_id", 0);
            DatabaseChange.last_feedback_id = parser.GetValue("Parameters", "last_feedback_id", 0);
            DatabaseChange.last_interaction_id = parser.GetValue("Parameters", "last_interaction_id", 0);
            DatabaseChange.last_observation_id = parser.GetValue("Parameters", "last_observation_id", 0);
            DatabaseChange.last_user_id = parser.GetValue("Parameters", "last_user_id", 0);
            site_name = parser.GetValue("Parameters", "site_name", "aces");
        }

        public static string GetDate_Formatted(DateTime dt)
        {
            string r = dt.Day.ToString() + " " + GetMonthName(dt.Month) + " " + dt.Year.ToString();
            return r;
        }
        public static string GetDate_Formatted_Without_Year(DateTime dt)
        {
            string r = dt.Day.ToString() + " " + GetMonthName(dt.Month);
            return r;
        }
        public static String GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sep";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return "Unknown";
            }
        }

        public static string GetAbsolutePath()
        {
            string c = Assembly.GetExecutingAssembly().CodeBase;
            string a = Path.GetFullPath(c.Substring(8));
            string b = (a).Substring(0, a.Length - 18);
            return b;
        }
        public static string GetAbsoluteAvatarPath()
        {
            return Configurations.GetAbsolutePath() + Configurations.avatar_path.Substring(2);
        }
        public static string GetAbsoluteConfigFilePath()
        {
            string a = Configurations.GetAbsolutePath();
            return Configurations.GetAbsolutePath() + Configurations.config_file;
        }
    }
}
