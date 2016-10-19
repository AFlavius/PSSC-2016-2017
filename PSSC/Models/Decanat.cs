using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat : Disciplina
    {

        public string[] nume_profesor;
        public string[] disciplina;
        public float media_gen;
        public int stare;
        public float m(Disciplina t, float media_gen)
        {
            if ((t.nota_marire > t.nota_examen) && (t.proportie == 1 / 3))
            {
                return media_gen = ((t.media_dis / 3) + (t.nota_marire * 2 / 3));
            }
            else
            {
                if (t.proportie == 1 / 3)
                {
                    return media_gen = ((t.media_dis / 3) + (t.nota_examen * 2 / 3));
                }

                else
                {
                    if ((t.nota_marire > t.nota_examen) && (t.proportie == 1 / 2))
                    {
                        return media_gen = (t.media_dis + t.nota_marire) / 2;
                    }
                    else
                    {
                        return media_gen = (t.media_dis + t.nota_examen) / 2;
                    }
                }
            }
        }
        public int s(Disciplina t, int stare)
        {
            int sum = 0;
            while (t.credite >= 0)
            {
                sum = sum + t.credite;
            }
            if (sum == 60)
            {
                return stare = 1;
            }
            else
            {
                return stare = 0;
            }
        }

        }
    }

             





