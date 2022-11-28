using System;
using System.Collections.Generic;

namespace RecruitmentDTO.Model;

public partial class Osoby
{
    public int IdOsoby { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Plec { get; set; } = null!;

    public int? IdOjca { get; set; }

    public int? IdMatki { get; set; }

    public string RokUrodzenia { get; set; } = null!;
}
