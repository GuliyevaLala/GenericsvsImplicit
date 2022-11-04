using ImpilicitvsExplicit_Generictypes.EmployeeData;
using ImpilicitvsExplicit_Generictypes.Temperature;
using System;

namespace ImpilicitvsExplicit_Generictypes {
    class Program {
        static void Main(string[] args)
        {
            Celius celius = new Celius(){ Degree = 30};
            Kelvin kelvin = celius;
            Console.WriteLine(kelvin.Degree);

            Employee[] _arr = Employee._arr;

            Employee worker1 = new Employee(DateConverter("05/06/2022"));
            worker1.Name = "Sabirə";
            worker1.Surname = "Qurbanova";
            worker1.Add(worker1);
            Employee worker2 = new Employee(DateConverter("01/07/2022"));
            worker2.Name = "Əbülfəz";
            worker2.Surname = "Rəcəbov";
            worker2.Add(worker2);
            Employee worker3 = new Employee(DateConverter("07/07/2019"));
            worker3.Name = "Novruz";
            worker3.Surname = "Mədətov";
            worker3.Add(worker3);

            Console.WriteLine(worker1.FindEmployee(DateConverter("05/06/2022"), DateConverter("11/11/2022"), 5200));
            //Console.WriteLine(worker2.FindEmployee(DateConverter("11/04/2022"), DateConverter("11/11/2022"), 750));
            //Console.WriteLine(worker3.FindEmployee(DateConverter("11/04/2022"), DateConverter("11/11/2022"), 1800);

        }
        public static DateTime DateConverter(string calendar)
        {
            return DateTime.Parse(calendar);
        }
    }
}
