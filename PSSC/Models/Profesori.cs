using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesori
    {
        int evaluare;
        string prenume;
        string CNP;
        string data_nasterii;
        string titlu;
        string cabinet;
        public int nota_1;
        public int nota_2;
        public int nota_3;
        public float nota_examen;
        public float nota_examen1;
        public float nota_examen2;
        public float nota_marire;
        public float proportie;
        public void dis(int evaluare, float nota_examen)
        {
            if (evaluare == 2)
            {
                nota_examen = (nota_examen1 + nota_examen2) / 2;
            }
        }

    }
}
