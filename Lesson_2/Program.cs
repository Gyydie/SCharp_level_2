﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


//Архипов Денис

//Построить три  класса(базовый и  2  потомка),  описывающих работников  с почасовой  оплатой(один из  потомков)  и фиксированной оплатой(второй потомок) :
//Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»; для работников  с фиксированной  оплатой: «среднемесячная заработная плата = фиксированная месячная оплата»;
//Создать на базе абстрактного класса массив сотрудников и заполнить его;
//* Реализовать интерфейсы для возможности сортировки массива, используя Array.Sort();
//* Создать класс, содержащий массив сотрудников, и реализовать возможность вывода данных с использованием foreach.

namespace Lesson_2
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа вывода отсортированного массива сотрудников");

            int numberOfWorkers = 20;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine(Environment.NewLine + "Создадим список сотрудников:");

            ArrayOfWorkers arr = new ArrayOfWorkers();

            arr.Init(numberOfWorkers);

            arr.Print();

            Console.WriteLine(Environment.NewLine + "Отсортируем список по зарплате:");

            arr.Sort();
            arr.Print();

            Console.ReadKey();
        }
    }
}
