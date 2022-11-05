using System;
using System.Text.RegularExpressions;
using ClassTask_Generics.Models;

namespace ClassTask_Generics {
    class Program
    {
        static void Main(string[] args)
        {

            #region implicit explicit
            //Manat manat = new Manat(17);

            //Dollar  dollar  = (Dollar)manat;

            //Console.WriteLine(dollar.Usd);


            //DateTime date = DateTime.Now;

            //Console.WriteLine(date.ToString("MMMM/dd/dddd/yyyy"));
            #endregion

            #region Generic list
            // StringList list =  new StringList();

            //list.Add("Qoshqar");
            //list.Add("Ramil");
            //list.Add("Resul");
            //list.Add("Gultac");
            //list.Add("Novreste");
            //list.Add("Lala");

            //list.GetAll();


            //IntList ages =  new IntList();

            //ages.Add(29);
            //ages.Add(25);
            //ages.Add(15);
            //ages.Add(18);
            //ages.Add(25);
            //ages.Add(26);

            //ages.GetAll();

            //BookList book = new BookList();

            //book.Add(new Book{ Name = "CSS"});
            //book.Add(new Book{ Name = "C#"});
            //book.Add(new Book{ Name = "JS"});

            //book.GetAll();


            //DataList<int> ages = new DataList<int>();

            //ages.Add(29);
            //ages.Add(25);
            //ages.Add(15);
            //ages.Add(18);
            //ages.Add(25);
            //ages.Add(27);

            //ages.GetAll();

            //DataList<string> list = new DataList<string>();

            //list.Add("Qoshqar");
            //list.Add("Ramil");
            //list.Add("Resul");
            //list.Add("Gultac");
            //list.Add("Novreste");
            //list.Add("Lala");

            //list.GetAll();

            //DataList<bool> marries = new DataList<bool>();

            //marries.Add(true);
            //marries.Add(false);
            //marries.Add(true);

            //marries.GetAll();
            #endregion

            //string a =  "Audrey";

            //String str = new String("hepburn");
            //Int32 num = new Int32();

            //num=55;

            //Repository<Regex> time = new Repository<Regex>();

            //Repository <int> number = new Repository<int>();

            //Repository <double> numbers = new Repository<double>();

            //Repository <string> name = new Repository<string>();

            //Repository <Student> student = new Repository<Student>();

            //Repository <Employee> employee = new Repository<Employee>();

            //Repository<Student,Common> student1 = new Repository<Student,Common>();

            //Repository<Employee,Common> employee1 = new Repository<Employee,Common>();



            //DateTime start = DateTime.Now;


            //DateTime end = DateTime.Now.AddMinutes(10);

            //GetProductByDate(start,end,500);

            //Console.WriteLine($"Start date : {start}  - End Date : {end}");
        }

        public static void GetProductByDate(DateTime start,DateTime end,double price)
        {
            
            //DateTime productDate = DateTime.Now.AddDays(-30);

            string productDate = "17/12/2007";

            DateTime date = DateTime.Parse(productDate);

            if ((start > end /*&& start<end*/) && price>1000)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }





    public class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);

            _datas[_datas.Length - 1] = data;
        }

        public void GetAll()
        {
            foreach (var item in _datas)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class StringList
    {
        private string[] _arr ;

        public StringList()
        {
            _arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _arr,_arr.Length+1);

            _arr[_arr.Length-1] = str;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }

    }


    public class IntList
    {
        private int[] _arr;

        public IntList()
        {
            _arr = new int[0];
        }

        public void Add(int str)
        {
            Array.Resize(ref _arr, _arr.Length + 1);

            _arr[_arr.Length - 1] = str;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }

    }



    #region Public class Dollar
    //class Dollar
    //{
    //    public double Usd {get ; set;}

    //    public Dollar(double usd)
    //    {
    //        Usd = usd;
    //    }
    //}

    //class Manat
    //{
    //    public double Azn { get; set; }

    //    public Manat (double azn)
    //    {
    //        Azn = azn;
    //    }

    //    public static explicit /*implicit*/ operator Dollar(Manat manat)
    //    {
    //        return new Dollar (manat.Azn/1.7);
    //    }

    //}





}
