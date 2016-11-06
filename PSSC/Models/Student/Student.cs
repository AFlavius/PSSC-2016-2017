using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

 // factory method pentru student
    }
    interface CreateStudent
    {
        Student CreStudent(RegistrationNumber number,PlainText n, Credits c);
    }
    class GradeReportFactory:CreateStudent
    {
        public Student CreStudent(RegistrationNumber number, PlainText n, Credits c)
        {
            return new Student(){RegNumber=number, Name=n, Credits=c};
        }
    }

    }
}
