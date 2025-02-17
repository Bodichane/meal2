using System;

class Program
{
    static double ConvertTime(string time)
    {
        string[] parts = time.Split(':');
        int hour = int.Parse(parts[0]);
        int minute = int.Parse(parts[1]);
        return hour + minute / 60.0;
    }

    static void Main()
    {
        Console.Write("What time is it? ");
        string time = Console.ReadLine();

        double convertTime = ConvertTime(time);

        if (7 <= convertTime && convertTime <= 8)
        {
            Console.WriteLine("breakfast time");
        }
        else if (12 <= convertTime && convertTime <= 13)
        {
            Console.WriteLine("lunch time");
        }
        else if (18 <= convertTime && convertTime <= 19)
        {
            Console.WriteLine("dinner time");
        }
    }
}
