using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Добавить в пример Lesson3 обобщенный делегат. 

namespace Lesson_3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ObDelegate obBel = new ObDelegate();
            Observer1 o1 = new Observer1();
            Observer2 o2 = new Observer2();
            Action<object> d1 = o1.Do;
            obBel.Run += d1;
            obBel.Run += o2.Do;
            obBel.Start();
            obBel.Run -= d1;
            obBel.Start();
        }
    }
}
