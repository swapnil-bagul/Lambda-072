using System;
using System.Collections.Generic;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Program.AddDetailsInList(list);
            GetDatails(list);
            
            Console.WriteLine("Hello World!");
        }
        public static void AddDetailsInList(List<Person > list)
        {

            list.Add(new Person() { name = "swapnil", address = "Nandurbar", age = 23, SSN = 1 });
            list.Add(new Person() { name = "vijay", address = "dhule", age = 16, SSN = 2 });
            list.Add(new Person() { name = "rajiv", address = "pune", age = 65, SSN = 3 });
            list.Add(new Person() { name = "vishal", address = "surat", age = 33, SSN = 4 });
            list.Add(new Person() { name = "uday", address = "nagpur", age = 74, SSN = 5 });
            list.Add(new Person() { name = "kasam", address = "navapur", age = 56, SSN = 6 });

        }
        public static void GetDatails(List<Person> list)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    Console.WriteLine("SSN: {0} | Name: {1} | Address: {2} | Age: {3}",item.SSN ,item .name ,item .address ,item .age );
                }

            }
        }
    }
}
