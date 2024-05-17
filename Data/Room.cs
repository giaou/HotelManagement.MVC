using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.MVC.Data;

public partial class Room
{
    public int Id { get; set; }

    public string RoomNumber { get; set; } = null!;

    public int RoomStatus { get; set; }
}
