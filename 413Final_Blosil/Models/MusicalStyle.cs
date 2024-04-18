using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class MusicalStyle
{
    [Key]
    public int? StyleId { get; set; }

    public string? StyleName { get; set; }
}
