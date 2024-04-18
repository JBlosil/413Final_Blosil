using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class MusicalPreference
{
    [Key]
    public int? CustomerId { get; set; }

    public int? StyleId { get; set; }

    public int? PreferenceSeq { get; set; }
}
