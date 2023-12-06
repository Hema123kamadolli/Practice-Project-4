using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4DesignPatterns
{
    public class Subject 
    {
        public string Name { get; set; }
        public string SubCode { get; set; }
        public Teacher AssignedTeacher { get; set; }

        public Subject(string name, string subCode, Teacher assignedTeacher)
        {
            Name = name;
            SubCode = subCode;
            AssignedTeacher = assignedTeacher;
        }
    }
}
