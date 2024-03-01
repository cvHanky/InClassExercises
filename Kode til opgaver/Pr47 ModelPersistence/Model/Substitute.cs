using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr47_ModelPersistence.Model
{
    public class Substitute
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Phone { get; set; }
        public string CPR { get; set; }
        public DateTime CertificateDate { get; set; }
        public bool Status { get; set; }

        public Substitute(string name, string phone, string cPR, DateTime certificateDate, bool status)
        {
            Name = name;
            Phone = phone;
            CPR = cPR;
            CertificateDate = certificateDate;
            Status = status;
        }
    }
}
