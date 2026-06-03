using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> _videos = new List<Video>(); 

        Video video1 = new Video(
            "Python Basics",
            "Josh Jewwett",
            240);
        
        video1.AddComment(new Comment("Alejandra", "Great video to start with Python!"));
        video1.AddComment(new Comment("Kazuo", "Just on time for my test on the university!"));
        video1.AddComment(new Comment("Steven", "Could you please share the code you used in the video?"));

        _videos.Add(video1);

        Video video2 = new Video(
            "PIC16F877A First Steps",
            "Emily Davis",
            1500);
        
        video2.AddComment(new Comment("Ali", "This is exactly what I needed to get started with PIC programming!"));
        video2.AddComment(new Comment("Daleska", "Can you make a video usign an ultrasonic sensor?"));
        video2.AddComment(new Comment("Frank", "Is it mandatory to use capacitors of 22pF for the crystal oscillator?"));

        _videos.Add(video2);

        Video video3 = new Video(
            "STM32F104RTC6 Black Pill Review",
            "Michael Brown",
            1150);
        
        video3.AddComment(new Comment("Joy", "Very interesting option to advance from the blue pill!"));
        video3.AddComment(new Comment("Mikael", "Is it mandatory to use the STmV2 Link?"));
        video3.AddComment(new Comment("Kenji", "Can you make a video about the differences between the blue pill and the black pill?"));

        _videos.Add(video3);


        foreach (Video video in _videos)
        {
            Console.WriteLine(video.GetVideoInfo());
        }
        





        
    }
}