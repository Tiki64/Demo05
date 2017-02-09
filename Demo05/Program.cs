using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (collection)
            Persons myFriends = new Persons();

            //create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Jesse",
                Lastname = "McCree",
                SocialSecurityNumber = "010101-123A"
            };
            Person person2 = new Person
            {
                Firstname = "Tracer",
                Lastname = "OP",
                SocialSecurityNumber = "020202-234B"
            };

            // add person objects t opersons (myfriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);

            // get one more person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Can't find that person");
            }
            // tulostetaan collection
            myFriends.PrintData();

            //etsitään person
            string sotu = "5224522-2223342";
            Console.WriteLine("Etsi henkilä jolla sotu: " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Kyseistä henkilöä ei löydy valitulla sotulla kek.");
            }
        }
    }
}
