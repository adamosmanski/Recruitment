using Microsoft.Identity.Client;
using RecruitmentDTO.Model;
using RecruitmentDTO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();
            result.Run();
        }
    }

    public class Result
    {
        public Result()
        {
            Repository = new PersonRepository(Context);
            Persons = FromDtoConverter.Transform(Repository.GettAllPerson());
        }
        public TasksContext Context = new TasksContext();
        public PersonRepository Repository { get; set; }
        public List<PersonModel> Persons { get; set; }
        private void OldCollection()
        {
            Console.WriteLine($"Stara kolekcja: ");
            foreach (var person in Persons)
            {
                Console.WriteLine($"{person.IdOsoby}|{person.Imie}|{person.Nazwisko}|{person.RokUrodzenia}|{person.Plec}|{person.IdOjca}|{person.IdMatki}" );
            }
        }

        private void NewCollection()
        {
            var result = from person in Persons select new {imie = person.Imie, nazwisko = person.Nazwisko};
            var Sortedlist = result.OrderBy(x => x.imie);

            Console.WriteLine("\n\nPosortowana kolekcja:");
            foreach ( var item in Sortedlist)
            {
                Console.WriteLine($"{item.imie} {item.nazwisko}");
            }

            var GroupedList = result.GroupBy(x => x.nazwisko);
            Console.WriteLine("\n\nPogrupowana kolekcja:");
            foreach(var item in GroupedList)
            {
                Console.WriteLine(item.Key);
            }
        }

        public void Run()
        {
            OldCollection();
            NewCollection();
        }
    }
}
