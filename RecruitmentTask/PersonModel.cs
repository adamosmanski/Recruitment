using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentTask
{
    public class PersonModel
    {
        public int IdOsoby { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Plec { get; set; }

        public int? IdOjca { get; set; }

        public int? IdMatki { get; set; }

        public string RokUrodzenia { get; set; }

    }
}
