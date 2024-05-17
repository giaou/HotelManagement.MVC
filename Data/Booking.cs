using System;
using System.Collections.Generic;

namespace HotelManagement.MVC.Data;

public partial class Booking
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? RoomId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Room? Room { get; set; }
}
