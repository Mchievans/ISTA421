using System.Collections.Generic;

namespace Test11.Models
{
    public class People
    {
        private static People listOfPeople = new People();

        private static Dictionary<string,Person> personlist = new Dictionary<string,Person>();

         public People()
        {
            var malachi = new[] {
               new Person {Name = "Malachi", NickName = "chi", Height = 5.6, Sex = "Male"},
               new Person {Name = "Kindra", NickName = "AngryKin", Height = 5.6, Sex = "Female" },
               new Person  {Name = "Jacob", NickName = "Chipper", Height = 5.8, Sex = "Male" },
               new Person {Name = "Carter", NickName = "CarTech", Height = 5.8, Sex = "Male" },
               };
            foreach(var p in malachi)
            {
                AddPeopleInfo(p);
            }
        }

        public static People UsableListofPeople
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
                return personlist.Values;
            }

        }

        public static void AddPeopleInfo(Person p)
        {
            personlist.Add(p.Name,p);
        }
    }
}
