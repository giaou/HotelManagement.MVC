﻿using System;
using System.Collections.Generic;

namespace HotelManagement.MVC.Data;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string DriverLicense { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
