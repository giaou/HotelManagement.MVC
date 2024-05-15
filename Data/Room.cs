using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.MVC.Data;

public partial class Room
{
    public int Id { get; set; }

    [StringLength(5,ErrorMessage ="Max 5 Characters")]
    public string RoomNumber { get; set; } = null!;

    [Range(0,1, ErrorMessage ="Can be either 0 for unbooked or 1 for booked")]
    public int RoomStatus { get; set; }
}
