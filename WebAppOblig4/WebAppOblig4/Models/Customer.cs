using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppOblig4.Models;

public partial class Customer
{
    public int Id { get; set; }


    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();


    public Customer ()
    {

    }
    public Customer(string email, string name, string passsword) {

        Email = email;
        Name = name;
        Password = passsword;
}
}
