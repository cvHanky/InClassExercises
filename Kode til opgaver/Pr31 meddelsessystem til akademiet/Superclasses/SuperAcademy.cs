using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr31_meddelsessystem_til_akademiet.Superclasses
{
    public abstract class SuperAcademy
    {
        private List<SuperStudent> students = new List<SuperStudent>();

        public void Attach(SuperStudent student)
        {
            students.Add(student);
        }
        public void Detach(SuperStudent student)
        {
            students.Remove(student);
        }
        public void Notify()
        {
            foreach (SuperStudent student in students)
            {
                student.Update();
            }
        }
    }
}
