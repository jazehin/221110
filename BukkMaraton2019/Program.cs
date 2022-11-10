namespace BukkMaraton2019
{
    internal class Program
    {
        static List<Versenytav> tavok = new();
        static void Main(string[] args)
        {
            F03();
            F04();
            F05();
            F06();
            F07();
            F08();
            Console.ReadLine();
        }

        private static void F08()
        {
            Dictionary<string, int> statisztika = new();
            foreach (var tav in tavok)
            {
                if (tav.Kategoria.Contains("f"))
                {
                    if (statisztika.ContainsKey(tav.Kategoria))
                    {
                        statisztika[tav.Kategoria]++;
                    }
                    else
                    {
                        statisztika.Add(tav.Kategoria, 1);
                    }
                }
            }
            Console.WriteLine("8. feladat: Statisztika");
            foreach (var kv in statisztika)
            {
                Console.WriteLine($"\t{kv.Key} - {kv.Value}fő");
            }

        }

        private static void F07()
        {
            Versenytav gyoztes = tavok
                .Where(tav => tav.Rajtszam.StartsWith("R"))
                .Where(tav => tav.Kategoria == "ff")
                .OrderBy(tav => tav.Ido)
                .First();

            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon");
            Console.WriteLine($"\tRajtszám: {gyoztes.Rajtszam}");
            Console.WriteLine($"\tNév: {gyoztes.Nev}");
            Console.WriteLine($"\tEgyesület: {gyoztes.Egyesulet}");
            Console.WriteLine($"\tIdő: 0{gyoztes.Ido}");
        }

        private static void F06()
        {
            if (tavok.Any(tav => tav.Ido.StartsWith("6")))
                Console.WriteLine("6. feladat: Volt ilyen versenyző");
            else
                Console.WriteLine("6. feladat: Nem volt ilyen versenyző");
        }

        private static void F05()
        {
            int noiVersenyzok = tavok.Count(tav => tav.Kategoria.EndsWith("n") && tav.Tav == "Rövid");
            Console.WriteLine($"5. feladat: Női versenyzők száma a rövid távú versenyen: {noiVersenyzok}fő");
        }

        private static void F03()
        {
            using StreamReader sr = new(@"..\..\..\..\res\bukkm2019.txt", System.Text.Encoding.UTF8);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] t = sr.ReadLine().Split(';');
                tavok.Add(new Versenytav(
                    rajtszam: t[0],
                    kategoria: t[1],
                    nev: t[2],
                    egyesulet: t[3],
                    ido: t[4]
                ));
            }
        }

        private static void F04()
        {
            double indulok = 691;
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {Math.Round((1 - (tavok.Count/indulok)) * 100, 14)}%");
        }
    }
}