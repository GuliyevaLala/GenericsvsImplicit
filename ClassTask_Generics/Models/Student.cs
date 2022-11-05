using System;
using System.Collections.Generic;
using System.Text;
using ClassTask_Generics.Interface;

namespace ClassTask_Generics.Models
{
    public class Student : Person , ITest
    {
        public string Teacher { get; set; }
    }
}
