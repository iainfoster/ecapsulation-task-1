using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_task_2
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int size = 5;//Change this to change the max size of the collection;
            string check = "";
            int counter = 0;
            List<Person> people = new List<Person>();
            do
            {

                Console.Write("Would you like to create a new person record (y/n): ");
                check = Console.ReadLine().ToLower();//Reads in user input and converts to lowercase
                if (check == "y")//If the user entered a y or Y
                {
                    Console.Clear();
                    Console.WriteLine("Enter The person's details...");
                    Console.Write("First name: ");
                    string fname = Console.ReadLine();
                    Console.Write("{0}'s last name: ", fname);
                    string lname = Console.ReadLine();
                    Console.Write("{0} {1}'s age: ", fname, lname);
                    int age = int.Parse(Console.ReadLine());
                    people.Add(new Person(fname, lname, age));//Add a new person to the list of people.
                    counter = counter + 1;
                }
                else if (check != "y" && check != "n")
                {
                    Console.WriteLine("That was not a valid input, please try again.");
                }
            } while (counter < size && check != "n");

            Console.Clear();
            Console.WriteLine("******* {0} Sets of Details *******", Person.counter);
            foreach (Person x in people)
            {
                Console.WriteLine("Name: {0} {1}\nAge: {2}\n", x.Fname, x.Lname, x.Age);
            }
        }
    }

    class Person
    {
        /*Private Attributes*/
        private string fname;
        private string lname;
        private int age;
        /*Static Attribute - note that it's accessible to the class not the object*/
        public static int counter = 0;

        /*Public Getters and Setters*/
        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        /*Constructor*/
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
            Console.WriteLine("New Person Object Created");
            counter++;
        }
    }
}
