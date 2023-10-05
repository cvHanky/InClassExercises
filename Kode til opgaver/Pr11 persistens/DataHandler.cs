using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11_persistens
{
    public class DataHandler
    {
        public DataHandler(string dataFileName)
        { 
            this.dataFileName = dataFileName;
        }
        
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }

        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(dataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }
        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader(dataFileName);
            string line = sr.ReadLine();
            string[] personData = line.Split(";");

            Person person = new Person(personData[0], DateTime.Parse(personData[1]), Double.Parse(personData[2]), bool.Parse(personData[3]), int.Parse(personData[4]));
            sr.Close();
            return person;
        }
        public void SavePersons(Person[] persons)
        {
            StreamWriter sw = new StreamWriter(dataFileName);
            for (int i = 0; i < persons.Length; i++)
            {
                sw.WriteLine(persons[i].MakeTitle());
            }
            sw.Close();
        }
        public Person[] LoadPersons()
        {
            StreamReader sr = new StreamReader(dataFileName);
            string[] separatedLines = sr.ReadToEnd().Split("\n");
            Person[] persons = new Person[separatedLines.Length-1];

            int count = 0;
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                string[] personData = new string[5];
                personData = line.Split(";");

                Person pr = new Person(personData[0], DateTime.Parse(personData[1]), double.Parse(personData[2]), bool.Parse(personData[3]), int.Parse(personData[4]));
                persons[count] = pr;
                count++;
            }
            return persons;
            sr.Close();
        }
    }
}
