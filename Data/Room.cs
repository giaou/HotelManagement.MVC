using System;
using System.Collections.Generic;

namespace HotelManagement.MVC.Data;

public partial class Room
{
    public int Id { get; set; }

    public string RoomNumber { get; set; } = null!;

    public int RoomStatus { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
