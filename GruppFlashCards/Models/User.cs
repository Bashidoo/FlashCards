using System;
using System.Collections.Generic;

namespace GruppFlashCards.Models;

public partial class User
{

    private static readonly Random random = new Random();
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public User(string username, string email, string password)
    {
        UserId = random.Next(10, 100001);
        UserName = username;
        Email = email;
        Password = password;
    }
    public User()
    {
        
    }
}
