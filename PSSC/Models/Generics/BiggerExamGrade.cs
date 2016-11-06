using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
   public class BiggerExamGrade //object value adaugat care corespunde listei pentru notele la marire
    {
       private decimal _value;
        public decimal Value { get { return _value; } }

        public BiggerExamGrade(decimal value)
        {
            _value = value;
        }
    }
}
