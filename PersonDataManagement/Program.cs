using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Create List
            List<Person> list = new List<Person>();
            //call Static Method
            AddDetailsInList(list);
            GetDatails(list);
            GetTopTwoRecordAgeLessThan60(list);
            AgeLessThan18(list);
            GetAverageAge(list);
            NamePresentOrNot(list, "swapnil");
            
           
        }
        //Adding Person Details in List
        public static void AddDetailsInList(List<Person > list)
        {

            list.Add(new Person() { name = "swapnil", address = "Nandurbar", age = 23, SSN = 1 });
            list.Add(new Person() { name = "vijay", address = "dhule", age = 16, SSN = 2 });
            list.Add(new Person() { name = "rajiv", address = "pune", age = 65, SSN = 3 });
            list.Add(new Person() { name = "vishal", address = "surat", age = 33, SSN = 4 });
            list.Add(new Person() { name = "uday", address = "nagpur", age = 74, SSN = 5 });
            list.Add(new Person() { name = "kasam", address = "navapur", age = 56, SSN = 6 });

        }
        //Printing Person Details
        public static void GetDatails(List<Person> list)
        {
            //Programming Construct
            if (list != null)
            {
                // //Programming Construct
                foreach (var item in list)
                {
                    Console.WriteLine("SSN: {0} | Name: {1} | Address: {2} | Age: {3}",item.SSN ,item .name ,item .address ,item .age );
                }

            }
            else
            {
                Console.WriteLine("List Is Empty");
            }

        }
        //get Top Two Person Age less than 60
        public static void GetTopTwoRecordAgeLessThan60(List <Person > list)
        {
            List<Person> result = list.FindAll(perosn => perosn.age < 60).OrderByDescending (person => person.age).Take (2).ToList ();
            Console .WriteLine ("Top Two Person Age less than 60 ");
            GetDatails(result);
        }

        // Person Age less than 18
        public static void AgeLessThan18(List<Person> list)
        {
            List<Person> result = list.FindAll(perosn => perosn.age < 18).ToList();
            Console.WriteLine("Person Age less than 18 ");
            GetDatails(result);
        }

        //find Average age
        public static void GetAverageAge(List<Person> list)
        {
            Console.WriteLine("Average Age ");
            var result = list.Average<Person>(person => person.age);
            Console.WriteLine(result);
            
        }

        //person is present or not
        public static void NamePresentOrNot(List<Person> list ,string present)
        {
            //create object
            var personObj = list.Find(person => person.name == present);

            if (personObj !=null  )
            {
                Console.WriteLine(" Person Is Present \n Name: {0}  Address: {1}", personObj.name, personObj.address);
            }
            else
            {
                Console.WriteLine("Person Is Not Present");
            }
            
          
        }
    }
}
