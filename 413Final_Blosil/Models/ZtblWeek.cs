using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class ZtblWeek
{
    [Key]
    public DateOnly? WeekStart { get; set; }

    public DateOnly? WeekEnd { get; set; }
}
