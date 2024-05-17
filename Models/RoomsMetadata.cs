using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Data;


public class RoomMetadata{
    public int Id { get; set; }

    [StringLength(5,ErrorMessage ="Max 5 Characters")]
    [Display(Name ="Room Number")]
    public string RoomNumber { get; set; } = null!;

    [Range(0,1, ErrorMessage ="Can be either 0 for unbooked or 1 for booked")]
    [Display(Name ="Room Status")]
    public int RoomStatus { get; set; }
}

[ModelMetadataType(typeof(RoomMetadata))]
public partial class Room{}