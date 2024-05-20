using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Data;
public class BookingsMetadata{

    [Display(Name = "Customer ID")]
    public int? CustomerId { get; set; }

    [Display(Name = "Room ID")]
    public int? RoomId { get; set; }

    [Display(Name = "Customer ID")]
    public virtual Customer? Customer { get; set; }
    [Display(Name = "Room ID")]
    public virtual Room? Room { get; set; }

}

[ModelMetadataType(typeof(BookingsMetadata))]
public partial class Booking{}