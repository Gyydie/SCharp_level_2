using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Lesson_5.Class
{
    class Department : IEquatable<Department>, INotifyPropertyChanged
    {
        static uint ID = 0;

        string departmentName;

        public string Name 
        {
            get { return this.departmentName; }
            set
            {
                this.departmentName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
            }
        }

        public uint DepartID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Инициализирует отдел</summary>
        /// <param name="name">Название</param>
        public Department(string name)
        {
            Name = name;
            DepartID = ID++;
        }

        /// <summary>Возвращает название отдела </summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return $"{Name}";
        //}

        /// <summary>Возвращает информацию о всех сотрудниках в отделе</summary>
        /// <param name="name">Название отдела</param>
        /// <param name="list">Список всех сотрудников</param>
        /// <returns></returns>
        internal string GetEmployees(string name, ObservableCollection<Employee> list)
        {
            var request = from e
                         in list
                          where e.DepartID == DepartID
                          select e;

            string result = String.Empty;

            foreach (Employee item in request)
            {
                result += $"{item.Name} {item.Surname}, возраст: {item.Age}, зарплата: {item.Salary}, отдел: {item.DepartID}\n";
            }

            return result;
        }

        /// <summary>Метод сравнения отдела с другим</summary>
        /// <param name="another">Слово типа Dictionary для сравнения</param>
        /// <returns></returns>
        public bool Equals(Department another)
        {
            return this.Name == another.Name;
        }

    }
}
