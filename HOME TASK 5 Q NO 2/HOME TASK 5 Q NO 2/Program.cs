using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STUDENT
            Console.WriteLine(" Adding Students");
            Student std1 = new Student(111, "ALI");
            Student std2 = new Student(112, "Abdullah");
            Student std3 = new Student(113, "Ahmed");

            //TEACHER
            Console.WriteLine(" Adding Teaacher");
            Teacher tch1 = new Teacher(1, "Waqar"," PF");
            Teacher tch2 = new Teacher(2, "Naseer", " Stats");

            //SCHOOL
            Console.WriteLine( " Managing School ");
            School school = new School(" NTU ", " Manawala");

            //ADDING SCHOOL

            Console.WriteLine(" ADDING STUDENTS TO SCHOOL");
            school.Addstudent(std1);
            school.Addstudent(std2);
            school.Addstudent(std3);

            Console.WriteLine(" Assiging Grade to Student");
            tch1.AssignGrade(std1,93);
            tch1.AssignGrade(std2,87);
            tch2.AssignGrade(std1, 65);
            tch2.AssignGrade(std3, 80);

            Console.WriteLine(" AVEARGE OF GRADES OF STUDENT");
            Console.WriteLine(std1.GetName() + " Has Average " + std1.Average());
            Console.WriteLine($"{std2.GetName()}   Has Average  {std2.Average()}");
            Console.WriteLine($"{std3.GetName()}   Has Average  {std3.Average()}");

            Console.WriteLine(" Display School info ");
            Console.WriteLine(school.Getname());
            Console.WriteLine(school.GetLoc());

            foreach(Student std in school.GetStudent())
            {
                if(std != null)
                {
                    Console.WriteLine(std.GetName());
                    Console.WriteLine(std.GetStudentID());
                }

            }
            Console.ReadLine();
        }
    }
}
