using System;
using System.Collections.Generic;
using System.Linq;

namespace LR_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Education> education = new List<Education>()
            {
                new Education { University = "BSUIR", Year=2024, City="Minsk"},
                new Education { University = "BNTU", Year=2023, City="Minsk" }
            };
            List<Graduates> graduates= new List<Graduates>()
            {
               new Graduates {Name="Валерия", Age = 18, Specialization="Information technology software" },
               new Graduates {Name="Александра", Age = 19, Specialization="Electronic computing systems"},
            };

            var high_education = from edu in education
                          from grad in graduates
                          select new { Name_l = edu.University, Name_r = grad.Name, Name_b = grad.Specialization };

            foreach (var h in high_education)
                Console.WriteLine($"University '{h.Name_l}'  Graduate student - {h.Name_r} - Specialization - {h.Name_b}");
            Console.ReadKey();

        }
    }
    class Education
    {
        public string University { get; set; }
        public int Year { get; set; }
        public string City { get; set; }
    }
    class Graduates
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
    }

}

