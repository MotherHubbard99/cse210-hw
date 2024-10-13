using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System.Net.Mail;
using System.ComponentModel;

class Program
{
    public int numberOfComments;
    static void Main(string[] args)
    {

        List<Video> videoList = new List<Video>();

        //Create a new Video object and add it to the list
        Video firstVideo = new Video("Recipe for a Cake", 212, "Angela Hubbard");
        firstVideo.AddComment(new Comment("Jim", "This recipe is fantastic!"));
        firstVideo.AddComment(new Comment("Shane", "I need to get my wife to make this for me."));
        firstVideo.AddComment(new Comment("Patty", "Wow, just wow!"));

        Video secondVideo = new Video("Frosting a Cake", 500, "Angela Hubbard");
        secondVideo.AddComment(new Comment("Suzie", "This frosting is a food group in itself :)"));
        secondVideo.AddComment(new Comment("Paul", "Freakin' Amazing!"));
        secondVideo.AddComment(new Comment("Payton", "Yummy!!!"));
        secondVideo.AddComment(new Comment("Drew", "Simply Amazing!!!!"));

        Video thirdVideo = new Video("Sharing and Eating a Cake", 432, "Angela Hubbard");
        thirdVideo.AddComment(new Comment("Max", "I shared this with my class and everyone gave rave reviews!"));
        thirdVideo.AddComment(new Comment("Celeste", "I will definitely share this with my family again!"));
        thirdVideo.AddComment(new Comment("Lou", "This is my new favorite. Thanks!"));

        //Add videos to the List
        videoList.Add(firstVideo);
        videoList.Add(secondVideo);
        videoList.Add(thirdVideo);

        //Display the Videos in the list
        foreach (var video in videoList)
        {
            //Initialize the comment counter per video
            int i = 0;
            Console.WriteLine($"Title: {video._title} ,Duration in Seconds: {video._seconds}, Author: {video._author}  ");
            Console.WriteLine("Comments: ");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($" - {comment._name}:  {comment._text}");
                //get the number of comments per video
                i += 1;
            }
            Console.WriteLine($"Number of comments: {i}");
        }

    }
}