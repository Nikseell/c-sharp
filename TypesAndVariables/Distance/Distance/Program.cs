using System;
public class Exercise7
{
    public static void Main()
    {
        double distance, hour, min, sec, timeSec, mps, kph, mph;

        Console.Write("Input distance(meters): ");
        distance = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input timeSec(hour): ");
        hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input timeSec(minutes): ");
        min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input timeSec(seconds): ");
        sec = Convert.ToInt32(Console.ReadLine());

        timeSec = (hour * 3600) + (min * 60) + sec;
        mps = distance / timeSec;
        kph = (distance / 1000) / (timeSec / 3600);
        mph = kph / 1.609;

        Console.WriteLine("Your speed in meters/sec is " + Math.Round(mps, 8));
        Console.WriteLine("Your speed in km/h is " + Math.Round(kph, 8));
        Console.WriteLine("Your speed in miles/h is " + Math.Round(mph, 8));
    }
}