using System;

//Добавить в пример Lesson3 обобщенный делегат. 

namespace Lesson_3
{
    partial class Program
    {
        class Observer1
        {
            public void Do(object o)
            {
                Console.WriteLine($"Первый. Принял, что объект {0} побежал", o);
            }
        }
    }
}
