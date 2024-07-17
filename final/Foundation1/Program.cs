using System;

class Program
{
    static void Main(string[] args)
    {
        bool input = false;
        while (!input)
        {
            string response;

            List<Video> _videos = new List<Video>();
            Video _video = new Video();
            _video.SetText();
            _video.AddComment();

            Console.Write("Add another Video? (Y/N): ");
            response = Console.ReadLine();

            if (response == "N")
            {
                Console.Write("See added videos with comments? (Y/N): ");
                response = Console.ReadLine();
                if(response == "N")
                {
                    input = true;
                }
                else
                {
                    foreach(Video vid in _videos)
                    {
                        Console.WriteLine($"{vid.GetTitle()}, by {vid.Getauthor()}");
                    }
                    _video.Display();
                }
            }
        }
    }
}