using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project3
{
    public class Marks:Student
    {
       public  int telugu, english, hindi, maths, science, social, totalMarks;
        public void MarksCalculation()
        {
            Console.WriteLine("Enter Marks::");
            Console.WriteLine("Enter Telugu: ");
            telugu = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter English: ");
            english = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Hindi: ");
            hindi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Maths: ");
            maths = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Science: ");
            science = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Social Studies: ");
            social = Convert.ToInt16(Console.ReadLine());
            totalMarks = telugu+hindi+english+maths+science+social;

        }
    }
}
