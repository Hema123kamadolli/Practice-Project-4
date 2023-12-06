using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4DesignPatterns
{
    public class Teacher 
    {
        public string Name { get; set; }
        public int Class { get; set; }
        public char Section { get; set; }

        public Teacher(string name, int class1, char section)
        {
            Name = name;
            Class = class1;
            Section = section;
        }
    }
}
