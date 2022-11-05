using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Test1_ShravanKumar_Project3
{
    public class Grade:Marks
    {
        double averageMarks;
        char grade;
        public void CalculateAverage()
        {
            averageMarks = totalMarks / 6;
            if(averageMarks > 60)
            {
                grade = 'A';
            }
            else if(averageMarks > 50 && averageMarks < 60)
            {
                grade = 'B';
            }
            else if(averageMarks>35 && averageMarks<50)
            {
                grade = 'c';
            }
        }
        public void DisplayAll()
        {
            Console.WriteLine(" Student ID: "+studentId);
            Console.WriteLine(" Student Name: "+studentName);
            Console.WriteLine(" Standard: "+standard);
            Console.WriteLine(" Student Address: "+studentAddress);
            Console.WriteLine(" Section: "+section);
            Console.WriteLine(" Gender: "+gender);
            Console.WriteLine("AND \n Marks Are Given below::");
            Console.WriteLine("\n Telugu: "+telugu);
            Console.WriteLine(" English: "+english);
            Console.WriteLine(" Hindi: "+hindi);
            Console.WriteLine(" Maths: "+maths);
            Console.WriteLine(" Science: "+science);
            Console.WriteLine(" Social Studies: "+social);
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Average Marks: "+averageMarks);
            Console.WriteLine("\n\tAnd Grade is   " + grade);
           
            
        }

    }
}
