using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Data;
public class BookingsMetadata{

    [Display(Name = "Customer")]
    public int? CustomerId { get; set; }

    [Display(Name = "Room Number")]
    public int? RoomId { get; set; }

    public virtual Customer? Customer { get; set; }
    public virtual Room? Room { get; set; }

}

[ModelMetadataType(typeof(BookingsMetadata))]
public partial class Booking{}