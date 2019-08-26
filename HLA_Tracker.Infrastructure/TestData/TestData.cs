using HLA_Tracker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using static HLA_Tracker.Core.Domain.Enums;

namespace HLA_Tracker.Infrastructure.TestData
{
    public class HLATestData
    {
        private readonly List<Race> _races;
        private readonly List<User> _users;
        private readonly List<Patient> _patients;

        public HLATestData()
        {
            _races = CreateRaces();
            _users = CreateUsers();
            _patients = CreatePatients();
        }

        public List<Patient> GetAllPatients()
        {
            return _patients;
        }

        private List<Race> CreateRaces()
        {
            var races = new List<Race>();

            races.Add(new Race { Id = 1, Description = "White" });
            races.Add(new Race { Id = 2, Description = "Black" });
            races.Add(new Race { Id = 3, Description = "Asian" });
            races.Add(new Race { Id = 4, Description = "Uknown" });

            return races;
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();

            users.Add(new User { Id = 1, CreateDateTime = DateTime.Now, EditDateTime = DateTime.Now, FirstName = "Chuck", LastName = "Fontana", Password = "Password", UserName = "chuck1" });

            return users;
        }

        private List<Patient> CreatePatients()
        {
            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                Id = 1,
                LastName = "Smith",
                FirstName = "Sam",
                DateOfBirth = new DateTime(1990, 10, 22),
                MRN = "1234589",
                SSN = "333-33-3332,",
                Gender = Gender.Male,
                Race = _races[0],
                CreateDateTime = DateTime.Now,
                CreatedBy = _users[0],
                EditDateTime = DateTime.Now,
                EditedBy = _users[0]
            });

            patients.Add(new Patient
            {
                Id = 1,
                LastName = "Robinson",
                FirstName = "Monique",
                DateOfBirth = new DateTime(1950, 9, 14),
                MRN = "1234556",
                SSN = "234-33-4444,",
                Gender = Gender.Female,
                Race = _races[0],
                CreateDateTime = DateTime.Now,
                CreatedBy = _users[0],
                EditDateTime = DateTime.Now,
                EditedBy = _users[0]
            });

            return patients;
        }


    }
}
