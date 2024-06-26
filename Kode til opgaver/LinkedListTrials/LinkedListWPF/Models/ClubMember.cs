﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWPF.Models
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable<ClubMember>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int CompareTo(ClubMember? other)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }
    }
}
