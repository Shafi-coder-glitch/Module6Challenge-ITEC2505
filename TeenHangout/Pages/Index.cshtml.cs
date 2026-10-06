using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

// Define the information for each Teen Hangout member.
public class User
{
    public string Username { get; set; }
    public int Age { get; set; }
    public string FavoriteColor { get; set; }

    // Create a new member with a username, age, and favorite color.
    public User(string username, int age, string favoriteColor)
    {
        Username = username;
        Age = age;
        FavoriteColor = favoriteColor;
    }
}

// Define the information for each post.
public class Post
{
    public string Username { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    // Create a new post with a username, content, and number of likes.
    public Post(string username, string content, int likes)
    {
        Username = username;
        Content = content;
        Likes = likes;
    }
}

public class IndexModel : PageModel
{
    // List the five Teen Hangout members.
    public User[] Users =
    {
        new User("Alex", 15, "Blue"),
        new User("Maya", 16, "Purple"),
        new User("Jordan", 17, "Green"),
        new User("Sam", 14, "Red"),
        new User("Taylor", 18, "Yellow")
    };

    // List the five posts and their number of likes.
    public Post[] Posts =
    {
        new Post("Alex", "Hanging out with friends!", 12),
        new Post("Maya", "I love this weekend!", 25),
        new Post("Jordan", "Playing games today!", 30),
        new Post("Sam", "Just finished my homework.", 8),
        new Post("Taylor", "Going to the movies tonight!", 22)
    };

    // Run when the page is opened.
    public void OnGet()
    {
    }
}