using System;

//Добавить в пример Lesson3 обобщенный делегат. 

namespace Lesson_3
{
    partial class Program
    {
        class Observer2 
        {
            public void Do(object o)
            {
                Console.WriteLine($"Второй. Принял, что объект {0} побежал", o);
            }
        }
    }
}
