using System.Collections.Generic;
using QuizzAPP.Managers;
using QuizzAPP.Models;

namespace QuizzAPP.Utils
{
    /// <summary>
    /// Utility class to load sample geography quiz questions
    /// </summary>
    public static class SampleDataLoader
    {
        /// <summary>
        /// Load sample geography questions into the quiz manager
        /// </summary>
        /// <param name="quizManager">Quiz manager to load questions into</param>
        public static void LoadSampleQuestions(QuizManager quizManager)
        {
            // Multiple Choice Questions
            LoadMultipleChoiceQuestions(quizManager);
            
            // Open Ended Questions
            LoadOpenEndedQuestions(quizManager);
            
            // True/False Questions
            LoadTrueFalseQuestions(quizManager);
        }

        private static void LoadMultipleChoiceQuestions(QuizManager quizManager)
        {
            // Question 1: World's largest country
            var options1 = new List<string>
            {
                "Russia",
                "Canada", 
                "China",
                "United States"
            };
            var mcq1 = new MultipleChoiceQuestion(0, "What is the largest country in the world by land area?", options1, 0);
            quizManager.AddQuestion(mcq1);

            // Question 2: Capital of Australia
            var options2 = new List<string>
            {
                "Sydney",
                "Melbourne",
                "Canberra",
                "Perth"
            };
            var mcq2 = new MultipleChoiceQuestion(0, "What is the capital city of Australia?", options2, 2);
            quizManager.AddQuestion(mcq2);

            // Question 3: Longest river
            var options3 = new List<string>
            {
                "Amazon River",
                "Nile River",
                "Yangtze River",
                "Mississippi River"
            };
            var mcq3 = new MultipleChoiceQuestion(0, "Which is the longest river in the world?", options3, 1);
            quizManager.AddQuestion(mcq3);

           
        }

        private static void LoadOpenEndedQuestions(QuizManager quizManager)
        {
            // Question 1: Capital of France
            var alternatives1 = new List<string> { "Paris, France" };
            var oeq1 = new OpenEndedQuestion(0, "What is the capital city of France?", "Paris", alternatives1);
            quizManager.AddQuestion(oeq1);

            // Question 2: Currency of Japan
            var alternatives2 = new List<string> { "Japanese Yen", "JPY" };
            var oeq2 = new OpenEndedQuestion(0, "What is the currency of Japan?", "Yen", alternatives2);
            quizManager.AddQuestion(oeq2);

            // Question 3: Ocean between Europe and America
            var alternatives3 = new List<string> { "North Atlantic", "Atlantic Ocean" };
            var oeq3 = new OpenEndedQuestion(0, "Which ocean lies between Europe and North America?", "Atlantic", alternatives3);
            quizManager.AddQuestion(oeq3);

            // Question 4: Desert in Africa
            var alternatives4 = new List<string> { "Sahara Desert" };
            var oeq4 = new OpenEndedQuestion(0, "What is the largest desert in Africa?", "Sahara", alternatives4);
            quizManager.AddQuestion(oeq4);

            // Question 5: Country with most time zones
            var alternatives5 = new List<string> { "Russian Federation" };
            var oeq5 = new OpenEndedQuestion(0, "Which country has the most time zones?", "Russia", alternatives5);
            quizManager.AddQuestion(oeq5);
        }

        private static void LoadTrueFalseQuestions(QuizManager quizManager)
        {
            // Question 1: Africa largest continent
            var tfq1 = new TrueFalseQuestion(0, "Africa is the largest continent in the world.", true);
            quizManager.AddQuestion(tfq1);

            // Question 2: Amazon rainforest location
            var tfq2 = new TrueFalseQuestion(0, "The Amazon rainforest is located primarily in Brazil.", true);
            quizManager.AddQuestion(tfq2);

            // Question 3: Great Wall visibility from space
            var tfq3 = new TrueFalseQuestion(0, "The Great Wall of China is visible from space with the naked eye.", false);
            quizManager.AddQuestion(tfq3);

            // Question 4: Antarctica population
            var tfq4 = new TrueFalseQuestion(0, "Antarctica has a permanent population of indigenous people.", false);
            quizManager.AddQuestion(tfq4);

            
        }


    }
}
