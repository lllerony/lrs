using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_40
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Education> education = new List<Education>();
            education.Add(new Education { University = "BSUIR", Specialization = "Information technology software" });
            education.Add(new Education { University = "BNTU", Specialization = "Electronic computing systems" });
            education.Add(new Education { University = "BGU", Specialization = "Marketing" });

            List<Graduates> graduates = new List<Graduates>()
            {
                new Graduates {Name="Gleb", Year = 2021 },
                new Graduates {Name="Andrew",Year = 2022 },
                new Graduates {Name="Anastasia",Year = 2023 },
            };

            var names = from u in education select u.University;

            var itogpost = from edu in education
                           from grad in graduates
                           select new { Education = edu.University, Year = grad.Year, Specialization = edu.Specialization, Name = grad.Name };
            var result = graduates.OrderByDescending(u => u.Year); //сортировка по убыванию

            foreach (Graduates p in result)
                Console.WriteLine($"{p.Name} получила высшее образование в {p.Year} году.");
        }
    }
    public class Education
    {
        public string University { get; set; }
        public string Specialization { get; set; }
    }
    class Graduates
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

}
