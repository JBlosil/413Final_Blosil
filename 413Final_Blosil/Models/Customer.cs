using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }

    public string? CustFirstName { get; set; }

    public string? CustLastName { get; set; }

    public string? CustStreetAddress { get; set; }

    public string? CustCity { get; set; }

    public string? CustState { get; set; }

    public string? CustZipCode { get; set; }

    public string? CustPhoneNumber { get; set; }
}
