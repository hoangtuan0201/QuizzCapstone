using System;
using System.Diagnostics;

namespace QuizzAPP.Managers
{
    /// <summary>
    /// Tracks time spent on quiz questions and overall quiz - demonstrates Encapsulation
    /// </summary>
    public class TimeTracker
    {
        private Stopwatch _overallStopwatch;
        private Stopwatch _questionStopwatch;
        private DateTime _quizStartTime;
        private DateTime _questionStartTime;
        private bool _isQuizActive;
        private bool _isQuestionActive;

        /// <summary>
        /// Total time elapsed since quiz started
        /// </summary>
        public TimeSpan TotalElapsed => _overallStopwatch.Elapsed;

        /// <summary>
        /// Time elapsed for current question
        /// </summary>
        public TimeSpan CurrentQuestionElapsed => _questionStopwatch.Elapsed;

        /// <summary>
        /// Whether the quiz timer is currently running
        /// </summary>
        public bool IsQuizRunning => _isQuizActive && _overallStopwatch.IsRunning;

        /// <summary>
        /// Whether the question timer is currently running
        /// </summary>
        public bool IsQuestionRunning => _isQuestionActive && _questionStopwatch.IsRunning;

        /// <summary>
        /// When the quiz was started
        /// </summary>
        public DateTime QuizStartTime => _quizStartTime;

        /// <summary>
        /// When the current question was started
        /// </summary>
        public DateTime QuestionStartTime => _questionStartTime;



        /// <summary>
        /// Constructor initializes stopwatches
        /// </summary>
        public TimeTracker()
        {
            _overallStopwatch = new Stopwatch();
            _questionStopwatch = new Stopwatch();
            Reset();
        }

        /// <summary>
        /// Start the overall quiz timer
        /// </summary>
        public void StartQuiz()
        {
            if (_isQuizActive)
                return;

            _quizStartTime = DateTime.Now;
            _isQuizActive = true;
            _overallStopwatch.Start();
        }

        /// <summary>
        /// Stop the overall quiz timer
        /// </summary>
        /// <returns>Total time elapsed</returns>
        public TimeSpan StopQuiz()
        {
            if (!_isQuizActive)
                return TimeSpan.Zero;

            _overallStopwatch.Stop();
            _isQuizActive = false;
            
            // Also stop question timer if running
            if (_isQuestionActive)
            {
                StopQuestion();
            }

            return _overallStopwatch.Elapsed;
        }



        /// <summary>
        /// Start timing a new question
        /// </summary>
        public void StartQuestion()
        {
            // Stop previous question if running
            if (_isQuestionActive)
            {
                StopQuestion();
            }

            _questionStartTime = DateTime.Now;
            _isQuestionActive = true;
            _questionStopwatch.Restart();
        }

        /// <summary>
        /// Stop timing the current question
        /// </summary>
        /// <returns>Time spent on the question</returns>
        public TimeSpan StopQuestion()
        {
            if (!_isQuestionActive)
                return TimeSpan.Zero;

            _questionStopwatch.Stop();
            _isQuestionActive = false;

            return _questionStopwatch.Elapsed;
        }

        /// <summary>
        /// Reset all timers
        /// </summary>
        public void Reset()
        {
            _overallStopwatch.Reset();
            _questionStopwatch.Reset();
            _isQuizActive = false;
            _isQuestionActive = false;
            _quizStartTime = DateTime.MinValue;
            _questionStartTime = DateTime.MinValue;
        }

        /// <summary>
        /// Get formatted time string for display
        /// </summary>
        /// <param name="timeSpan">Time to format</param>
        /// <returns>Formatted time string</returns>
        public static string FormatTime(TimeSpan timeSpan)
        {
            if (timeSpan.TotalHours >= 1)
            {
                return $"{(int)timeSpan.TotalHours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
            }
            else
            {
                return $"{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";
            }
        }




    }
}
