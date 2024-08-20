using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases03
{
    public class Student
    {
        private int id;
        private string name;
        private string course;
        private double average;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public double Average
        {
            get { return average; }
            set { average = value; }
        }

        public Student(int Id, string Name, string Course, double Average)
        {
            id = Id;
            name = Name;
            course = Course;
            average = Average;
        }

        public override string ToString()
        {
            return "Id: " + id + " Name: " + name + " Course: " + course + " Average: " + average;
        }

    }
}
