using System;

namespace Feeds.Views.Home
{
    /// <summary>
    /// Extension for calculating timespan between posting time and now
    /// </summary>
    public static class TimespanExtension
    {
        /// <summary>
        /// Method for calculating timespan
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string TimeAgo(this string time)
        {
            TimeSpan timeSince = DateTime.Now.Subtract(Convert.ToDateTime(time));

            if (timeSince.TotalMilliseconds < 1)
            {
                time = "not yet";
            }
            else if (timeSince.TotalMinutes < 1)
            {
                time = "just now";
            }
            else if (timeSince.TotalMinutes < 2)
            {
                time = "1 minute ago";
            }
            else if (timeSince.TotalMinutes < 60)
            {
                time = string.Format("{0} minutes ago", timeSince.Minutes);
            }
            else if (timeSince.TotalMinutes < 120)
            {
                time = "1 hour ago";
            }
            else if (timeSince.TotalHours < 24)
            {
                time = string.Format("{0} hours ago", timeSince.Hours);
            }
            else if (timeSince.TotalDays == 1)
            {
                time = "yesterday";
            }
            else if (timeSince.TotalDays < 7)
            {
                time = string.Format("{0} days ago", timeSince.Days);
            }
            else if (timeSince.TotalDays < 14)
            {
                time = "last week";
            }
            else if (timeSince.TotalDays < 21)
            {
                time = "2 weeks ago";
            }
            else if (timeSince.TotalDays < 28)
            {
                time = "3 weeks ago";
            }
            else if (timeSince.TotalDays < 60)
            {
                time = "last month";
            }
            else if (timeSince.TotalDays < 365)
            {
                time = string.Format("{0} months ago", Math.Round(timeSince.TotalDays / 30));
            }
            else if (timeSince.TotalDays >= 365 && timeSince.TotalDays < 730)
            {
                time = "last year";
            }
            else
            {
                time = string.Format("{0} years ago", Math.Round(timeSince.TotalDays / 365));
            }
            return time;
        }
    }
}
