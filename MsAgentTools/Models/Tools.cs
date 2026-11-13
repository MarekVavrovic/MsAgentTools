namespace MsAgentTools.Models
{
    public class Tools
    {
        // Returns the current date and time based on the specified TimeType (Local or Utc).
        public static DateTime CurrentDateAndTime(TimeType type)
        {
            // Use a switch expression to return the appropriate DateTime.
            return type switch
            {
                TimeType.Local => DateTime.Now,
                TimeType.Utc => DateTime.UtcNow,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }

        // Returns the display name of the current local timezone.
        public static string CurrentTimezone()
        {
            return TimeZoneInfo.Local.DisplayName;
        }

        // Enum to specify the type of time (Local or Utc).
        public enum TimeType
        {
            Local,
            Utc
        }

    }
}
