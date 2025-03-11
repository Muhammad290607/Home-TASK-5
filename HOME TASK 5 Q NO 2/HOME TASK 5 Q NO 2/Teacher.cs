using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME_TASK_5_Q_NO_2
{
    internal class Teacher
    {
        private int Teacher_id;
        private string name;
        private string subject;

        public Teacher(int teacher_id, string name, string subject)
        {
            Teacher_id = teacher_id;
            this.name = name;
            this.subject = subject;
        }

        public void AssignGrade(Student std, int Grade)
        {
            std.Setgrade(Grade);
        }

        public int GetID() { return Teacher_id; }
    
        public string GetName() { return name; }
        
      public string GetSub() {  return subject; }         
        
    }
}