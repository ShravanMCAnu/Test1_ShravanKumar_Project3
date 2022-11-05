// See https://aka.ms/new-console-template for more information
using Test1_ShravanKumar_Project3;
try
{


    Grade objGrade = new Grade();
    objGrade.StudentDetails();
    objGrade.MarksCalculation();
    objGrade.CalculateAverage();
    objGrade.DisplayAll();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}