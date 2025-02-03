using System;
using System.Collections.Generic;

namespace GruppFlashCards.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public User(int userid, string username, string email, string password)
    {
        UserId = userid;
        UserName = username;
        Email = email;
        Password = password;
    }
    public User()
    {
        
    }
}
