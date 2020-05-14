using System;

//Добавить в пример Lesson3 обобщенный делегат. 

namespace Lesson_3
{
    partial class Program
    {
        class ObDelegate
        {
            public event Action<object> Run;

            public void Start()
            {
                Console.WriteLine("RUN");
                if (Run != null) Run(this);
            }
        }
    }
}
