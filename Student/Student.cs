using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEx
{
    class Student
    {
        private string name;
        private int id;
        private string program;

        public Student (string n, int i, string p)
        {
            name = n;
            id = i;
            program = p;
        }

        public Student()
        {
           
        }

        public void setName(string n)
        {
            name = n;
        }

        public void setProgram(string p)
        {
            program = p;
        }

        public void setId(int i)
        {
            id = i;
        }

        public string getName()
        {
            return name;
        }

        public string getProgram()
        {
            return program;
        }

        public int getId()
        {
            return id;
        }

    }

    class Student2
    {
        // Properties -> an extension of fields 
        // variables that are accessed like methods
        // 차이점 알아야 함
        public string Name
        {
            get;set;
        }

        public string Program
        {
            get;set;
        }

        public int Id
        {
            get;set;
        }
    }
}
