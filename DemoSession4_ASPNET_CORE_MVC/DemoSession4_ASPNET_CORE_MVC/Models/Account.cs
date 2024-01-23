using System;
using System.Collections.Generic;

namespace DemoSession4_ASPNET_CORE_MVC.Models;

public partial class Account
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Status { get; set; }
    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
