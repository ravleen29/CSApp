using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        protected NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            Console.WriteLine("Ravleen's Newsfeed!");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "DisplayMenu All Posts", "Remove Post",  "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: RemovePost(); break;
                    case 7: wantToQuit = true; break;
                }
            }
            while (!wantToQuit);
        }

        private void RemovePost()
        {
            throw new NotImplementedException();
        }

        public void RemovePost(Post post)
        {
            news.RemovePost(post);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
