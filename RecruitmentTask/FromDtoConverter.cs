using RecruitmentDTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentTask
{
    public static class FromDtoConverter
    {
        public static List<PersonModel> Transform(IEnumerable<Osoby> collection)
        {
            List<PersonModel> result = new List<PersonModel>();

            foreach (var item in collection)
            {
                PersonModel model = new PersonModel();
                model.IdMatki = item.IdMatki;
                model.Plec = item.Plec;
                model.Nazwisko = item.Nazwisko;
                model.RokUrodzenia = item.RokUrodzenia;
                model.IdOjca = item.IdOjca;
                model.IdOsoby = item.IdOsoby;
                model.Imie = item.Imie;
                result.Add(model);
            }
            return result;
        }
    }
}
