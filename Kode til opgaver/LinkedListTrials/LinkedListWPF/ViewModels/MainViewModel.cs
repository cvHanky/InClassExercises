using LinkedListWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWPF.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<ClubMember> ClubMembers { get; set; } = new ObservableCollection<ClubMember>();
        public ClubMember SelectedItem { get; set; }
        public int SelectedIndex { get; set; }

        public MainViewModel()
        {
            ClubMembers.Add(
                new ClubMember
                {
                    Id = 1,
                    FirstName = "Lis",
                    LastName = "Sørensen",
                    Gender = Gender.Female,
                    Age = 18
                });
            ClubMembers.Add(
                new ClubMember
                {
                    Id = 2,
                    FirstName = "Bjørn",
                    LastName = "Borg",
                    Gender = Gender.Male,
                    Age = 30
                });
            ClubMembers.Add(
                new ClubMember
                {
                    Id = 3,
                    FirstName = "Anders",
                    LastName = "And",
                    Gender = Gender.Male,
                    Age = 15
                });
            ClubMembers.Add(
                new ClubMember
                {
                    Id = 4,
                    FirstName = "Cristian",
                    LastName = "Nielsen",
                    Gender = Gender.Male,
                    Age = 20
                });
            ClubMembers.Add(
                new ClubMember
                {
                    Id = 5,
                    FirstName = "Kurt",
                    LastName = "Nielsen",
                    Gender = Gender.Male,
                    Age = 33
                });
        }
    }
}
