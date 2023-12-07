using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("Tech Talk", "Exploring the latest technologies", new DateTime(2023, 11, 27), new TimeSpan(14, 30, 0), new Address("123 Main St", "Cityville","State", "12345"), "Tech Expert", 100);
        ReceptionEvent receptionEvent = new ReceptionEvent("Networking Mixer", "Casual networking event", new DateTime(2023, 12, 7), new TimeSpan(18, 0, 0), new Address("456 Oak St", "Townsville","State", "67890"), "rsvp@example.com");
        OutDoorGatheringEvent outDoorEvent = new OutDoorGatheringEvent("Picnic in the Park", "Enjoy nature and good company", new DateTime(2023, 12, 10), new TimeSpan(12, 0, 0), new Address("789 Pine St", "Villageville","State", "54321"), "Weather permitting");

        Console.WriteLine(lectureEvent.GetRateStandardDetails());
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine(lectureEvent.GenerateShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine(receptionEvent.GetRateStandardDetails());
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine(receptionEvent.GenerateShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine(outDoorEvent.GetRateStandardDetails());
        Console.WriteLine(outDoorEvent.GenerateFullDetails());
        Console.WriteLine(outDoorEvent.GenerateShortDescription());       
    }
}