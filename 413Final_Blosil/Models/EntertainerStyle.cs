using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class EntertainerStyle
{
    [Key]
    public int? EntertainerId { get; set; }

    public int? StyleId { get; set; }

    public int? StyleStrength { get; set; }
}
