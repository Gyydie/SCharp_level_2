using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дана коллекция List<T>, требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции:
//а) для целых чисел;
//б) * для обобщенной коллекции;
//в) * используя Linq.

 //   Архипов Д.А.
namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListT<int>.list.Add(1);
            ListT<int>.list.Add(2);
            ListT<int>.list.Add(1);
            ListT<int>.list.Add(7);
            ListT<int>.list.Add(1);
            ListT<int>.list.Add(9);
            ListT<int>.list.Add(7);
            ListT<int>.list.Add(2);
            ListT<int>.list.Add(9);

            Console.WriteLine("\nСоздан следующий список элементов:");
            ListT<int>.Print();

            foreach (KeyValuePair<int, int> item in ListT<int>.GetStatistic())
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine("\nпри помощи linq:");

            var orderedItems = ListT<int>.list.GroupBy(l => l);

            foreach (var item in orderedItems)
                Console.WriteLine($"{item.Key} : {item.Count()}");

            Console.ReadLine();
        }
    }
}
