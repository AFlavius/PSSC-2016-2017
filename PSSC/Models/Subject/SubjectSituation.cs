using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    public class SubjectSituation
    {
        public Attendance Attendance { get; internal set; }
        public List<Grade> ExamGrades { get; internal set; }
        public List<BiggerExamGrade> BigExamGrades{get;internal set;}
        public Grade ActivityGrade { get; internal set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(Attendance attendance, List<Grade> examGrades,List<BiggerExamGrade> examGrades1, Grade activityGrade)
        {
            Attendance = attendance;
            ExamGrades = examGrades;
            BigExamGrades= examGrades1;
            ActivityGrade = activityGrade;
        }

        public void AddExamGrade(Grade examGrade, BiggerExamGrade examGrade1)// functie modificata pentru adaugarea unei note mai mari de la marire
        {
            if (examGrade.Value < examGrade1.Value)
            {
                BigExamGrades.Add(examGrade1);
                
            }
            else
            {
                ExamGrades.Add(examGrade);
            }
        }

        public void AddActivityGrade(Grade activityGrade)
        {
            ActivityGrade = activityGrade;
        }

        public void AddAttendance(Attendance attendance)
        {
            Attendance = attendance;
        }

        public decimal GetExamAverage(EvaluationType type)// functie pentru calculul note finale modificata tinand cont de notele mai mari de la marire
        {
            Grade average;
            BiggerExamGrade average_1;
            decimal average_2;
            if(type.Equals(EvaluationType.Distributed))
            {
                if ((BigExamGrades[0].Value > ExamGrades[0].Value) && (BigExamGrades[1].Value < ExamGrades[1].Value))
                {
                    average_2 = (BigExamGrades[0].Value + ExamGrades[1].Value) / 2;
                    return average_2;
                }
                else
                {
                    if ((BigExamGrades[0].Value < ExamGrades[0].Value) && (BigExamGrades[1].Value > ExamGrades[1].Value))
                    {
                        average_2 = (ExamGrades[0].Value + BigExamGrades[0].Value) / 2;
                        return average_2;
                    }
                    else
                    {

                        average_1 = new BiggerExamGrade((BigExamGrades[0].Value + BigExamGrades[1].Value) / 2);
                        average = new Grade((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
                        if (average_1.Value > average.Value)
                        {
                            return average_1.Value;
                        }
                        else
                        {
                            return average.Value;
                        }
                    }
                }
            } 
            else
            {
                average = new Grade(ExamGrades[0].Value);
                average_1 = new BiggerExamGrade(BigExamGrades[0].Value);
                if (average_1.Value > average.Value)
                {
                    return average_1.Value;
                }
                else
                {
                    return average.Value;
                }

            }

        }
    }
}
