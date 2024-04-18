using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _413Final_Blosil.Models;

public partial class ZtblDay
{
    [Key]
    public DateOnly? DateField { get; set; }
}
