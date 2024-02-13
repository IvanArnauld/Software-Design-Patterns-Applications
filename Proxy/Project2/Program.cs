using System;
using System.Collections.Generic;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PostProxy> Posts = new List<PostProxy>();
            Post defaultPost = new();
            PostProxy p1 = new PostProxy();
            Posts.Add(p1);

            PostProxy p2 = new PostProxy();
            Posts.Add(p2);

            PostProxy p3 = new PostProxy();
            Posts.Add(p3);

            Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
            string command = "";

            while(command != "quit") {
                string[] commandArgs = command!.Split(":");
                int postNum = -1;
                if(commandArgs.Length > 1) {
                    try {
                        postNum = int.Parse(commandArgs[1]);
                    } catch(FormatException) {
                        Console.WriteLine("Error: Invalid post number specified!");
                    }

                    if(postNum < 0 || postNum >= Posts.Count) {
                        Console.WriteLine("Error: Invalid post number specified!");
                        break;
                    }
                }
                
                string parameter;
                switch(commandArgs[0]) {
                    case "help":
                        Console.WriteLine("help\t\t\tDisplay this menu");
                        Console.WriteLine("new\t\t\tCreate a new post.");
                        Console.WriteLine("list\t\t\tList all posts.");
                        Console.WriteLine("download:[id]\t\tDownload a post.");
                        Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                        Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                        Console.WriteLine("view:[id]\t\tView a post.");
                        Console.WriteLine("quit\t\t\tQuit the application");
                        break;
                    case "new":
                        PostProxy newPostProxy = new(defaultPost.Clone() as Post);
                        Posts.Add(newPostProxy);
                        Console.WriteLine("Added a new Post.");
                        break;
                    case "list":
                        for (int i = 0; i < Posts.Count; i++)
                        {
                            var post = Posts[i];
                            Console.WriteLine($"{i}\t{post.GetPrintableTitle()}");
                        }
                        break;
                    case "download":
                        Posts[postNum] = new PostProxy(Posts[postNum].Download());
                        Console.WriteLine("Done.");
                        break;
                    case "settitle":
                        if (commandArgs.Length < 3)
                        {
                            Console.WriteLine("Error: No post number or no title specified!");
                        }
                        else
                        {
                            parameter = commandArgs[2];
                            Posts[postNum].SetTitle(parameter);
                            
                        }
                        break;
                    case "setbody":
                        if (commandArgs.Length < 3)
                        {
                            Console.WriteLine("Error: No post number or no body specified!");
                        }
                        else
                        {
                            parameter = commandArgs[2];
                            Posts[postNum].SetBody(parameter);
                            
                        }
                        break;
                    case "view":
                        Posts[postNum].View();
                        break;
                    default:
                        if(command != "") {
                            Console.WriteLine("Invalid command.");
                        }
                        break;
                }
                Console.Write(">");
                command = Console.ReadLine()!;
            }
        }
    }
}
