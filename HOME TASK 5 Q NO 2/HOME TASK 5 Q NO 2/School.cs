using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_2
{
    internal class School
    {

        private string school_name;
        private string location;
        private Student[] students;
        private int student_count;


        public School(string name, string location)
        {
            school_name = name;
            this.location = location;
            students = new Student[100];
            student_count = 0;
        }

        public void Addstudent(Student std)
        {
            students[student_count] = std;
            student_count++;


        }


        public string Getname() { return school_name; }
        public string GetLoc() { return location; }


        public Student[] GetStudent() { return students; }

    }
}

