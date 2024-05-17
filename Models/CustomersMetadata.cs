using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.MVC.Data;


public class CustomerMetadata{

    [Display(Name ="First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name ="Last Name")]
    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    [Display(Name ="Phone Number")]
    public string PhoneNumber { get; set; } = null!;

    [Display(Name ="ID Number")]
    public string DriverLicense { get; set; } = null!;

    [Display(Name ="Debit/Credit Number")]
    public string CardNumber { get; set; } = null!;

    [Display(Name ="Date of Birth")]
    public DateTime DateOfBirth { get; set; }

}

[ModelMetadataType(typeof(CustomerMetadata))]
public partial class Customer{}