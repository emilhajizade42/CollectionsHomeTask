using System;
using System.Collections;

namespace Generic_type__Collections.Modals
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            SortedList my_slist1 = new SortedList();
            my_slist1.Add(1991, "python");
            my_slist1.Add(1995, "js");
            my_slist1.Add(1972, "c");
            my_slist1.Add(1985, "c++");
            Console.WriteLine("");
            Console.WriteLine("ile gore siralma");
            Console.WriteLine("");
            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine($"{pair.Key} and {pair.Value}");
            }

            Console.WriteLine("");
            Console.WriteLine("ada gore siralama");
            Console.WriteLine("");
            SortedList list = new SortedList();
            list.Add("python", 1991);
            list.Add("js", 1995);
            list.Add("c", 1972);
            list.Add("c++", 1985);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} and {item.Value}");
            }
        }
    }
}
