[Flags]
enum Days
{
	None = 0,
	Monday = 1,
	Tuesday = 2,
	Wednesday = 4,
	Thursday = 8,
	Friday = 16,
	Saturday = 32,
	Sunday = 64,
	Weekend = Saturday | Sunday
}

internal class EnumExample
{
	internal static void Main()
	{
		Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
		Console.WriteLine(meetingDays);

		Days workingFromHomeDays = Days.Thursday | Days.Friday | Days.Monday;
		Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

		bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
		Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

		var a = (Days)37;
		Console.WriteLine(a);
	}
}
