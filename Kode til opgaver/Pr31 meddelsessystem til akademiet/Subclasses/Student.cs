using Pr31_meddelsessystem_til_akademiet.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_meddelsessystem_til_akademiet.Subclasses
{
    public class Student : SuperStudent
    {
        private Academy subject;
        public string Message { get; set; }
        public string Name { get; }

        public Student(Academy subject, string name)
        {
            this.subject = subject;
            Name = name;
        }
        public override void Update()
        {
            this.Message = subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden {Message} fra {subject.Name}");
        }
    }
}
