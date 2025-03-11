using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_2
{
    internal class Student
    {
        private int Student_id;
        private string Studentname;
        private int[] Studentgrade;
        private int grade_count;

        public Student(int ID, string name)
        {
            this.Student_id = ID;
            this.Studentname = name;
            Studentgrade = new int[5];
            grade_count = 0;

        }

        public void Setgrade(int grade)
        {
            Studentgrade[grade_count] = grade;
            grade_count++;
        }

        public double Average()
        {
            if (grade_count == 0) return 0;
            double sum = 0;
            for (int i = 0; i < grade_count; i++)
            {
                sum += Studentgrade[i];
                
                

            }
            return sum / grade_count;


        }
        public int GetStudentID()
        {
            return Student_id;

        }
        public string GetName()
        {

            return Studentname;
        }
    }
}