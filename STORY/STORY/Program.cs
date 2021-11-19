using System;
using System.Collections.Generic;

namespace STORY
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Details do you want to Enter:");
            int count = int.Parse(Console.ReadLine());
            List<Story> s1 = new List<Story>();
            int click = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name,AuthorName,Gen,Chapters,Likes,Reads");

                string story = Console.ReadLine();
                string[] story1 = story.Split(',');
                Story story_Details = new Story(story1[0], story1[1], story1[2], int.Parse(story1[3]), int.Parse(story1[4]), int.Parse(story1[5]));
                s1.Add(story_Details);
            }
            Console.WriteLine("Press 1 for Searching based on Author:Press 2 for Searching based on Likes:");
            click = Convert.ToInt32(Console.ReadLine());
            search s = new search();
            List<Story> search = new List<Story>();
            switch (click)
            {
                case 1:
                    Console.WriteLine("Please Enter the AuthorName:");
                    search = s.findStory(s1, Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter the Salary:");
                    search = s.findStory(s1, Convert.ToInt32(Console.ReadLine()));
                    break;
                default:
                    break;
            }
            foreach (var item in search)
            {
                Console.WriteLine(item);
            }

        }
    }
}




