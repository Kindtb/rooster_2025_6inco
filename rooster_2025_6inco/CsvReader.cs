using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rooster_2025_6inco
{
    internal class CsvReader
    {
        public List<Klas> klassen = new List<Klas>();
        public List<Leerkracht> leerkrachten = new List<Leerkracht>();
        public List<Lokaal> lokalen = new List<Lokaal>();

        private string filePath;

        public CsvReader(string filePath)
        {
            this.filePath = filePath;
            var classNames = new List<string>();
            var teacherNames = new List<string>();
            var classrooms = new List<string>();

            foreach (var line in File.ReadLines(filePath))
            {
                // Skip empty lines
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Split CSV, handle quoted commas
                var fields = SplitCsv(line);

                if (fields.Length < 7) continue; // skip malformed lines

                if (classNames.Contains(fields[1].Trim('\'')))
                {

                }
                else
                {
                    classNames.Add(fields[1].Trim('\''));
                }
                if (teacherNames.Contains(fields[2].Trim('\'')))
                {

                }
                else
                {
                    teacherNames.Add(fields[2].Trim('\''));
                }
                if (classrooms.Contains(fields[4].Trim('\'')))
                {

                }
                else
                {
                    classrooms.Add(fields[4].Trim('\''));
                }

                /*klassen.Add(new Klas(fields[1].Trim('\'')));
                leerkrachten.Add(new Leerkracht(fields[2].Trim('\'')));
                lokalen.Add(new Lokaal(fields[4].Trim('\'')));*/
            }

            foreach (string klas in classNames)
            {
                klassen.Add(new Klas(klas));
            }
            foreach (string leerkracht in teacherNames)
            {
                leerkrachten.Add(new Leerkracht(leerkracht));
            }
            foreach (string lokaal in classrooms)
            {
                lokalen.Add(new Lokaal(lokaal));
            }
            // Example: Output the lists
            /*Console.WriteLine("Class Names:");
            classNames.ForEach(Console.WriteLine);

            Console.WriteLine("\nTeacher Names:");
            teacherNames.ForEach(Console.WriteLine);

            Console.WriteLine("\nClassrooms:");
            classrooms.ForEach(Console.WriteLine);*/
        }

        // Simple CSV splitter (handles quoted fields)
        static string[] SplitCsv(string input)
        {
            var result = new List<string>();
            bool inQuotes = false;
            int start = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                    inQuotes = !inQuotes;
                else if (input[i] == ',' && !inQuotes)
                {
                    result.Add(input.Substring(start, i - start));
                    start = i + 1;
                }
            }
            result.Add(input.Substring(start));
            return result.ToArray();
        }

        public List<Klas> getKlassen()
        {
            return klassen;
        }

        public List<Leerkracht> getLeerkrachten()
        {
            return leerkrachten;
        }

        public List<Lokaal> getLokalen()
        {
            return lokalen;
        }

        public List<Les> getLessenVoorLeerkracht(string leerkracht)
        {
            List<Les> lessen = new List<Les> ();

            foreach (var line in File.ReadLines(filePath))
            {
                // Skip empty lines
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Split CSV, handle quoted commas
                var fields = SplitCsv(line);

                if (fields.Length < 7) continue; // skip malformed lines



                
            }
            return lessen;
        }
    }
}
