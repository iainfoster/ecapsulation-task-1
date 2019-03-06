using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecapsulation_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creditcard c1 = new Creditcard();
            Console.WriteLine("This program is to store credit card info and return public information back");
            Console.WriteLine("Please enter your name: ");
            c1.Name = Console.ReadLine();
            Console.WriteLine("Please enter the Creditcards number: ");
            c1.Cardnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the cards security number: ");
            c1.Pin = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the expiry date (DD/../....):  ");
            c1.Expire.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the expiry date (../MM/....) :");
            c1.Expire.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the expiry date (../../YYYY) :");
            c1.Expire.Year = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("................Your public information.................. ");
            Console.WriteLine($"Creditcard holders name: {c1.Name}");
            Console.WriteLine($"Expiration Date: {c1.Expire.Day}/{c1.Expire.Month}/{c1.Expire.Year}");
            Console.ReadKey();
        }
    }
    
    class Creditcard
    {
        string name;
        int cardnumber;
        int pin;
        ExpiryDate expire = new ExpiryDate();

        public string Name { get { return name; } set{ name = value; } }
        public int Cardnumber { private get { return cardnumber; } set { cardnumber = value; } }
        public int Pin { private get { return pin; } set { pin = value; } }
        public ExpiryDate Expire { get { return expire; } set { expire = value; } }

        public Creditcard(string _name, int _cardnumber, int _pin, ExpiryDate _expire)
        {
            Name = _name;
            Cardnumber = _cardnumber;
            Pin = _pin;
            Expire = _expire;
        }

        public Creditcard()
        {

        }
    }

    class ExpiryDate
    {
        int day;
        int month;
        int year;

        public int Day {  get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }

    }
    
}
