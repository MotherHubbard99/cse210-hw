using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

public class Video
{
    //member variables aka attributes
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> Comments;

    public Video(string title, int seconds, string author)
    {
        _title = title;
        _seconds = seconds;
        _author = author;
        //List to hold comments
        Comments = new List<Comment>();

    }
    //Method to add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
        //Call Method to count comments per video
    }



}