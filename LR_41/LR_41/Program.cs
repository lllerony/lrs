using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            List<Education> shops = new List<Education>
            {
                new Education {Spesialization="Information technology software", University="BSUIR" },
                new Education {Spesialization="Electronic computing systems", University="BSUIR" },
                new Education {Spesialization="Information Security", University="BSUIR" },
                new Education {Spesialization="Engineering Economics", University="BSUIR" },
                new Education {Spesialization="Computer systems and networks", University="BSUIR" },
                new Education {Spesialization="Machine structure", University="BNTU" },
                new Education {Spesialization="Energy", University="BNTU" },
                new Education {Spesialization="Technology of management and humanitarization", University="BNTU" }
            };

            var shopGroups = from shop in shops
                             group shop by shop.University;

            foreach (IGrouping<string, Education> g in shopGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Spesialization);
                Console.WriteLine();
            }

        }
        class Education
        {
            public string Spesialization { get; set; }
            public string University { get; set; }
        }
    }



