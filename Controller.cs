using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    static class Controller
    {
        public static int CountExperiments(Session session)
        {
            return session.Exams.Count() + session.Credits.Count();
        }

        public static int CountTests(List<Test> tests, int questionsCount)
        {
            int counter = 0;
            foreach(Test test in tests)
            {
                if(test.QuestinsCount == questionsCount)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
