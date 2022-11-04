using System;
using System.Collections.Generic;
using System.Text;

namespace ImpilicitvsExplicit_Generictypes.EmployeeData {
    public class Employee{
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }
        public int Count { get; private set; }


        public static Employee[] _arr = new Employee[0];

        public Employee(DateTime birthday)
        {
            Birthday = birthday;
        }


        public void Add(Employee data)
        {
            Array.Resize(ref _arr, _arr.Length + 1);

            _arr[^1] = data;
        }
        public int FindEmployee(DateTime start, DateTime end, double salary)
        {
            Salary = (int)salary;

            if (start < Birthday && Birthday < end && Salary > 2000)
            {
                Count++;
            }
            return Count;

        }




    }

}

