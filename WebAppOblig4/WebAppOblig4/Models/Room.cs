using System;
using System.Collections.Generic;

namespace WebAppOblig4.Models;

public partial class Room
{
    public int Id { get; set; }

    public int RoomNumber { get; set; }

    public string RoomType { get; set; } = null!;

    public int NumBeds { get; set; }

    public int RoomSize { get; set; }

    public decimal PricePerNight { get; set; }
}
