using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Sample_MVCApp.Models
{
    public class Student
    {
       
        public string Nume { get; set; }
       
        public string Prenume { get; set; }
        public float    Medie { get; set; }
       
       
        public int Numar { get; set; }
       
        public string Disciplina { get; set; }
    }
    public class Users
    {
        public Users()
        {
            _userList.Add(new Student
            {
                Nume = "Ardelean",
                Prenume = "Flavius",
                Medie = 7,
                Numar = 3456,
                Disciplina="Teoria sistemelor"

            });
            _userList.Add(new Student
            {
                Nume = "Berdich",
                Prenume = "Adriana",
                Medie = 9,
                Numar = 5367,
                Disciplina = "CAEHP"

            });
            _userList.Add(new Student
            {
                Nume = "Bobar",
                Prenume = "Vlad",
                Medie = 7,
                Numar = 2167,
                Disciplina = "Programare JAVA"

            });
        }

        public List<Student> _userList = new List<Student>();

        public void CreateUser(Student userModel)
        {
            _userList.Add(userModel);
        }

     
        public  Student GetUser(int Numar) {
            Student usrMdl = null;

            foreach (Student um in _userList)
                if (um.Numar == Numar)
                    usrMdl = um;

            return usrMdl;
        }

       
    }
}
