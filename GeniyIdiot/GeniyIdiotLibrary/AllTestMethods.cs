using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotLibrary
{
    public class AllTestMethods
    {

        public static string GetUserDiagnosis(User user, int questionsCount)
        {
            int exelentPersentResult = 100;
            double userPersentResult = (exelentPersentResult * user.CountRightAnswers) / questionsCount;

            if (userPersentResult <= 20)
            {
                return "Идиот";
            }
            if (userPersentResult <= 40)
            {
                return "Дурак";
            }
            if (userPersentResult <= 60)
            {
                return "Нормальный";
            }
            if (userPersentResult <= 80)
            {
                return "Талант";
            }
            if (userPersentResult > 80)
            {
                return "Гений";
            }
            return "Кретин";
        }

        public static string ShowTestResult(User user)
        {
            string Name = user.UserName;
            int CountRightAnswers = user.CountRightAnswers;
            string Diagnosis = user.Diagnosis;
            return $"{Name}, ваше количество верных ответо: {CountRightAnswers}! Ваш диагноз: {Diagnosis}";
        }
    }
}
