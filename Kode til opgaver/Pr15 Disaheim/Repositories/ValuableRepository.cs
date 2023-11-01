using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr15_Disaheim.Objects;

namespace Pr15_Disaheim.Repositories
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable? GetValuable(string id)
        {
            IValuable? valuable = null;
            foreach (IValuable v in valuables)
            {
                if (v is Amulet)
                {
                    if (((Amulet)v).ItemId == id)
                        valuable = v;
                }
                else if (v is Book)
                {
                    if (((Book)v).ItemId == id)
                        valuable = v;
                }
                else if (v is Course)
                {
                    if (((Course)v).Name == id)
                        valuable = v;
                }
            }
            return valuable;
        }
        public double GetTotalValue()
        {
            double total = 0;
            foreach (IValuable v in valuables)
            {
                if (v is Amulet)
                    total += ((Amulet)v).GetValue();
                if (v is Book)
                    total += ((Book)v).GetValue();
                if (v is Course)
                    total += ((Course)v).GetValue();
            }
            return total;
        }
        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            StreamWriter sw = new StreamWriter("ValuableRepository.txt");
            foreach (IValuable v in valuables)
            {
                if (v is Amulet a)
                    sw.WriteLine($"AMULET;{a.ItemId};{a.Quality};{a.Design};");
                if (v is Book b)
                    sw.WriteLine($"BOOK;{b.ItemId};{b.Title};{b.Price};");
                if (v is Course c)
                    sw.WriteLine($"COURSE;{c.Name};{c.DurationInMinutes};{c.GetValue()};");
            }
            sw.Close();
        }

        public void Save(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (IValuable v in valuables)
            {
                if (v is Amulet a)
                    sw.WriteLine($"AMULET;{a.ItemId};{a.Quality};{a.Design};");
                if (v is Book b)
                    sw.WriteLine($"BOOK;{b.ItemId};{b.Title};{b.Price};");
                if (v is Course c)
                    sw.WriteLine($"COURSE;{c.Name};{c.DurationInMinutes};{c.GetValue()};");
            }
            sw.Close();
        }

        public void Load()
        {
            StreamReader sr = new StreamReader("ValuableRepository.txt");
            string[] lines = sr.ReadToEnd().Split('\n');

            if (lines.Length > 0 )
            {
                foreach (string line in lines)
                {
                    string[] data = line.Split(";");
                    switch (data[0])
                    {
                        case "AMULET":
                            Amulet a = new Amulet(itemId: data[1], quality: Amulet.StringToLevel(data[2]), design: data[3]);
                            valuables.Add(a);
                            break;
                        case "BOOK":
                            Book b = new Book(itemId: data[1], title: data[2], price: Double.Parse(data[3]));
                            valuables.Add(b);
                            break;
                        case "COURSE":
                            Course c = new Course(name: data[1], durationInMinutes: int.Parse(data[2]));
                            valuables.Add(c);
                            break;
                        default:
                            break;
                    }
                }
            }
            sr.Close();
        }

        public void Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string[] lines = sr.ReadToEnd().Split('\n');

            if (lines.Length > 0)
            {
                foreach (string line in lines)
                {
                    string[] data = line.Split(";");
                    switch (data[0])
                    {
                        case "AMULET":
                            Amulet a = new Amulet(itemId: data[1], quality: Amulet.StringToLevel(data[2]), design: data[3]);
                            valuables.Add(a);
                            break;
                        case "BOOK":
                            Book b = new Book(itemId: data[1], title: data[2], price: Double.Parse(data[3]));
                            valuables.Add(b);
                            break;
                        case "COURSE":
                            Course c = new Course(name: data[1], durationInMinutes: int.Parse(data[2]));
                            valuables.Add(c);
                            break;
                        default:
                            break;
                    }
                }
            }
            sr.Close();
        }
    }
}
