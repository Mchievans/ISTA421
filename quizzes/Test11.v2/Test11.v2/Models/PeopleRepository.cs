using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test11.v2.Models
{
    public class PeopleRepository
    {
        private static PeopleRepository listOfPeople = new PeopleRepository();

        private Dictionary<string,Person> PeopleDictionary = new Dictionary<string,Person>();

        public PeopleRepository()
        {
            var malachi = new[] {
               new Person {Name = "Malachi", Nickname = "chi", Height = 5.6, Sex = "Male"},
               new Person {Name = "Kindra", Nickname = "AngryKin", Height = 5.6, Sex = "Female" },
               new Person  {Name = "Jacob", Nickname = "Chipper", Height = 5.8, Sex = "Male" },
               new Person {Name = "Carter", Nickname = "CarTech", Height = 5.8, Sex = "Male" },
               };
            foreach(var p in malachi)
            {
                AddPeopleInfo(p);
            }
        }

        public static PeopleRepository UsableListofPeople
        {
            get
            {
                return listOfPeople;
            }
        }


        public static IEnumerable<Person> GetPeopleInfo
        {
            get
            {
                return UsableListofPeople.PeopleDictionary.Values;
            }

        }

        public void AddPeopleInfo(Person p)
        {
            PeopleDictionary.Add(p.Name,p);
        }
    }
}

