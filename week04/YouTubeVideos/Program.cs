using System;
using YouTubeVideos;
namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Leo","What a nice meeting");
        Comment comment2 = new Comment("leo2","What a nice meeting12");
        Comment comment3 = new Comment("leo3","What a nice meeting123");
        Comment comment4 = new Comment("leo4","What a nice meeting1234");
        Comment comment5 = new Comment("leo5","What a nice meeting12345");

        Comment comment6 = new Comment("Leo","What a nice meeting");
        Comment comment7 = new Comment("leo2","What a nice meeting12");
        Comment comment8 = new Comment("leo3","What a nice meeting123");
        Comment comment9 = new Comment("leo4","What a nice meeting1234");
        Comment comment10 = new Comment("leo5","What a nice meeting12345");

        Video video1 = new Video("Meeting", "Leo", 100);   
        Video video2 = new Video("Restaurant", "Leo2", 200);
        Video video3 = new Video("Hotel", "Leo3", 300);
        Video video4 = new Video("Casino", "Leo4", 400);
        Video video5 = new Video("School", "Leo5", 500);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        video1.AddComment(comment5);

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        video2.AddComment(comment5);

        video3.AddComment(comment6);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        video4.AddComment(comment6);
        video4.AddComment(comment7);
        video4.AddComment(comment8);
        video4.AddComment(comment9);
        video4.AddComment(comment10);

        video5.AddComment(comment6);
        video5.AddComment(comment7);
        video5.AddComment(comment8);
        video5.AddComment(comment9);
        video5.AddComment(comment10);

        video1.displayVideo();
        video2.displayVideo();
        video3.displayVideo(); 
        video4.displayVideo();
        video5.displayVideo();

    }
}