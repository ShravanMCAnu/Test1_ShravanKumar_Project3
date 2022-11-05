using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project3
{
    public class Student
    {
        public int studentId,standard;
        public string? studentName,studentAddress;
        public char? gender,section;
        public void StudentDetails()
        {
            Console.WriteLine("Enter Student ID: ");
            studentId=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            studentName = Console.ReadLine(); 
            Console.WriteLine("Enter Gender ( M or F) : ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Standard: ");
            standard = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Section: ");
            section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            studentAddress = Console.ReadLine();
        }
    }
}
