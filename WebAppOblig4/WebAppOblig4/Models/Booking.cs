using System;
using System.Collections.Generic;

namespace WebAppOblig4.Models;

public partial class Booking
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string RoomType { get; set; } = null!;

    public DateOnly CheckinDate { get; set; }

    public DateOnly CheckoutDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
