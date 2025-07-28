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
        /// Event fired when quiz timer starts
        /// </summary>
        public event EventHandler? QuizStarted;

        /// <summary>
        /// Event fired when quiz timer stops
        /// </summary>
        public event EventHandler<TimeSpan>? QuizStopped;

        /// <summary>
        /// Event fired when question timer starts
        /// </summary>
        public event EventHandler? QuestionStarted;

        /// <summary>
        /// Event fired when question timer stops
        /// </summary>
        public event EventHandler<TimeSpan>? QuestionStopped;

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
            
            OnQuizStarted();
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

            var elapsed = _overallStopwatch.Elapsed;
            OnQuizStopped(elapsed);
            return elapsed;
        }

        /// <summary>
        /// Pause the overall quiz timer
        /// </summary>
        public void PauseQuiz()
        {
            if (_isQuizActive && _overallStopwatch.IsRunning)
            {
                _overallStopwatch.Stop();
            }
        }

        /// <summary>
        /// Resume the overall quiz timer
        /// </summary>
        public void ResumeQuiz()
        {
            if (_isQuizActive && !_overallStopwatch.IsRunning)
            {
                _overallStopwatch.Start();
            }
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
            
            OnQuestionStarted();
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

            var elapsed = _questionStopwatch.Elapsed;
            OnQuestionStopped(elapsed);
            return elapsed;
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

        /// <summary>
        /// Get formatted time string with milliseconds
        /// </summary>
        /// <param name="timeSpan">Time to format</param>
        /// <returns>Formatted time string with milliseconds</returns>
        public static string FormatTimeDetailed(TimeSpan timeSpan)
        {
            return $"{FormatTime(timeSpan)}.{timeSpan.Milliseconds:D3}";
        }

        /// <summary>
        /// Get time in minutes as decimal
        /// </summary>
        /// <param name="timeSpan">Time to convert</param>
        /// <returns>Time in minutes</returns>
        public static double GetMinutes(TimeSpan timeSpan)
        {
            return timeSpan.TotalMinutes;
        }

        /// <summary>
        /// Get time in seconds as decimal
        /// </summary>
        /// <param name="timeSpan">Time to convert</param>
        /// <returns>Time in seconds</returns>
        public static double GetSeconds(TimeSpan timeSpan)
        {
            return timeSpan.TotalSeconds;
        }

        /// <summary>
        /// Get current quiz time formatted for display
        /// </summary>
        /// <returns>Formatted current quiz time</returns>
        public string GetFormattedQuizTime()
        {
            return FormatTime(TotalElapsed);
        }

        /// <summary>
        /// Get current question time formatted for display
        /// </summary>
        /// <returns>Formatted current question time</returns>
        public string GetFormattedQuestionTime()
        {
            return FormatTime(CurrentQuestionElapsed);
        }

        /// <summary>
        /// Fire the QuizStarted event
        /// </summary>
        protected virtual void OnQuizStarted()
        {
            QuizStarted?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fire the QuizStopped event
        /// </summary>
        /// <param name="elapsed">Total elapsed time</param>
        protected virtual void OnQuizStopped(TimeSpan elapsed)
        {
            QuizStopped?.Invoke(this, elapsed);
        }

        /// <summary>
        /// Fire the QuestionStarted event
        /// </summary>
        protected virtual void OnQuestionStarted()
        {
            QuestionStarted?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fire the QuestionStopped event
        /// </summary>
        /// <param name="elapsed">Time spent on question</param>
        protected virtual void OnQuestionStopped(TimeSpan elapsed)
        {
            QuestionStopped?.Invoke(this, elapsed);
        }
    }
}
