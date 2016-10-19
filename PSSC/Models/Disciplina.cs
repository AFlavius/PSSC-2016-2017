using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
      class Disciplina:Profesori 
    {
          public int evaluare;
          public int credite;
          public float media_dis;
          public float media(Profesori n, float media_dis)
          {
              media_dis = (n.nota_1 + n.nota_2 + n.nota_3) / 3;
              return media_dis;
          }

          
    }
}
