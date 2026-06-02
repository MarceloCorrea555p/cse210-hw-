using System;

class Program
{
    static void Main(string[] args)
    {

         List<Video> videoList = new List<Video>();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

         Video video1 = new Video("SNAIL SOUP", "KARINA REBELLO", 800);

        // 2. Agregar comentarios usando el método público
        video1.AddComment("Mia ", "Snail soup is my favorite.");
        video1.AddComment("Lorenzo", "The video is very long. A summary should be made..");
        video1.AddComment("Roman Firka", "Thank you very much, great video.");
        video1.AddComment("Deloredo", "I prepare snail soup in a different way...");


        Video video2 = new Video("Abrimos 100 CAJAS MISTERIOSAS de POKEMON", "WILLYREX", 350);
        video2.AddComment("Luis", "proving once again that he is not an expert in anything.");
        video2.AddComment("Paco", "This video makes no sense, thanks for the invitation!.");
        video2.AddComment("Miguel Angel", "The video is really cool, but it would have been awesome to have a close-up camera showing the cards coming out of the envelopes..");
        video2.AddComment("Rafael", "0:13 expert at losing Lockes.");

        Video video3 = new Video("Episode 367 - Slobo comes out of the closet","Slovosky", 950);
        video3.AddComment("Lolo", "Barry is underrated, he always gets the best punchlines in the production..");
        video3.AddComment("Roma", "The section should be called time capsules with Professor Sloby.");
        video3.AddComment("MIA", "And this rose?..");
        video3.AddComment("Milei", "I can't wait for them to bark about what went down with that jerk who says t-shirts talk.");

        Video video4 = new Video("1 HOUR OF SURVIVAL IN MINECRAFT","MrBeast", 11000);
        video4.AddComment("Lolo", "He’s a king? No, he’s a legend..");
        video4.AddComment("Roma", "How old is this video if even technoblade is participating in it.");
        video4.AddComment("MIA", "I love these compilation videos!.");
        video4.AddComment("Milei", "Techno is with us! Always.");


        // show results
        videoList.Add(video1);
        videoList.Add(video2);  
        videoList.Add(video3);
        videoList.Add(video4);


        foreach (var video in videoList)
        {
            video.GetDisplayText();
            Console.WriteLine();
        }

    }
}