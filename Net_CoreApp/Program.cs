using System;
using Net_CoreApp.Model;

namespace Net_CoreApp  
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Student ps = new Student();
            string name = "Nguyễn Đức Nhật";
            int birthYear = 21;

            Console.WriteLine("{0} - {1} - {2}", name, ps.GetYearOfBirth(birthYear), "Bắc Ninh");

            Employee emp = new Employee();
            emp.EnterData();
            emp.Display();
        }
    }
}