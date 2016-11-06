using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //Entity
    public class Professor
    {
        public PlainText Name { get; internal set; }
    }
    //factory method pentru profesor
    interface CreateProfessor
    {
        Professor CreProfesor(PlainText nume);
    }
    class SubjectsFactory : CreateProfessor
    {
        public Professor CreProfesor(PlainText nume)
        {
            return new Professor() { Name = nume };
        }
    }
}
