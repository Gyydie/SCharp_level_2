using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Lesson_5.Class
{
    class Employee : IEquatable<Employee>, INotifyPropertyChanged
    {
        string employeeName;

        public string Name 
        {
            get { return this.employeeName; }
            set
            {
                this.employeeName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
            }
        }
        public string Surname { get; set; }
        public uint Age { get; set; }
        public decimal Salary { get; set; }
        public uint DepartID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Инициализирует сотрудника</summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="department">Отдел</param>
        public Employee(string name, string surname, uint age, decimal salary, uint department)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            DepartID = department;
        }

        /// <summary>Возвращет имя и фамилию сотрудника</summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return $"{Name} {Surname}";
        //}

        /// <summary>Возвращает всю информацию о сотруднике</summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nЗарплата: {Salary}\n" +
                $"Отдел: {GetDepartmentName(MainWindow.db.GetDeptaments() as ObservableCollection<Department>)}\n";
        }

        internal string GetDepartmentName(ObservableCollection<Department> list)
        {
            var request = from e
                          in list
                          where e.DepartID == DepartID
                          select e;

            string result = (request.ElementAt(0)).Name;

            return result;
        }

        /// <summary>Метод сравнения сотрудника с другим</summary>
        /// <param name="another">Слово типа Dictionary для сравнения</param>
        /// <returns></returns>
        public bool Equals(Employee another)
        {
            return this.Name == another.Name && this.Surname == another.Surname && this.Age == another.Age &&
                this.DepartID == another.DepartID && this.Salary == another.Salary;
        }
    }
}
