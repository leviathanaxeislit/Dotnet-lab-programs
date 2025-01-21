using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultilevelInheritance
{
    public class student
    {
        protected int Roll_no;
        protected string name;
    }
    public class Test : student
    {
        protected int marks1;
        protected int marks2;
    }
    public class Result : Test
    {
        private int total;
        public void getDetails()
        {
            Console.WriteLine("\n Enter the Student Details :");
            Console.Write("=================================");
            Console.Write("\n Enter the Student Roll number :");
            base.Roll_no = int.Parse(Console.ReadLine());
            Console.Write("\n Enter the Student Name :");
            base.name = Console.ReadLine();
            Console.Write("\n Enter the Mark-1 :");
            base.marks1 = int.Parse(Console.ReadLine());
            Console.Write("\n Enter the Mark-2 :");
            base.marks2 = int.Parse(Console.ReadLine());
        }
        public void showDetails()
        {
            Console.WriteLine("\n\n Student Details :");
            Console.Write("=================================");
            Console.WriteLine("\n Student Roll number :" + base.Roll_no); Console.WriteLine("\n Student Name :" + base.name);
            Console.WriteLine("\n Mark-1 :" + base.marks1);
            Console.WriteLine("\n Mark-2 :" + base.marks2);
            this.total = base.marks1 + base.marks2;
            Console.WriteLine("\n Total Marks obtained :" + this.total);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result s1 = new Result();
            s1.getDetails();
            s1.showDetails();
            Console.ReadLine();
        }
    }
}
