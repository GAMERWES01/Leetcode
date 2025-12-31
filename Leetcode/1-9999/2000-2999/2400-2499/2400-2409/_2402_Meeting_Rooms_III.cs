namespace Leetcode._1_9999._2000_2999._2400_2499._2400_2409;

public class _2402_Meeting_Rooms_III
{
    public int MostBooked(int n, int[][] meetings)
    {

        (int count, long freeTime)[] rooms = new (int count, long freeTime)[n];
        int result = 0;
        long max = 0;
        
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        foreach (int[] meeting in meetings)
        {
            int meetingRoomNumber = -1;
            long laagsteTijd = long.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (rooms[i].freeTime <= meeting[0])
                {
                    meetingRoomNumber = i;
                    laagsteTijd = meeting[0];
                    break;
                }
                if (rooms[i].freeTime < laagsteTijd)
                {
                    meetingRoomNumber = i;
                    laagsteTijd = rooms[i].freeTime;
                }
            }
            rooms[meetingRoomNumber].count++;
            rooms[meetingRoomNumber].freeTime = laagsteTijd + meeting[1] - meeting[0];
            if (max < rooms[meetingRoomNumber].count || 
                (max == rooms[meetingRoomNumber].count && meetingRoomNumber < result))
            {
                max = rooms[meetingRoomNumber].count;
                result = meetingRoomNumber;
            }
        }
        return result;
    }
}