using System;
using System.Diagnostics;

namespace QuizzAPP.Managers
{
    // Theo dõi thời gian làm quiz và từng câu hỏi
    public class TimeTracker
    {
        private Stopwatch _overallStopwatch;
        private Stopwatch _questionStopwatch;
        private DateTime _quizStartTime;
        private DateTime _questionStartTime;
        private bool _isQuizActive;
        private bool _isQuestionActive;

        // Tổng thời gian đã trôi qua từ khi bắt đầu quiz
        public TimeSpan TotalElapsed
        {
            get { return _overallStopwatch.Elapsed; }
        }

        // Thời gian đã trôi qua cho câu hỏi hiện tại
        public TimeSpan CurrentQuestionElapsed
        {
            get { return _questionStopwatch.Elapsed; }
        }

        // Timer quiz có đang chạy không
        public bool IsQuizRunning
        {
            get { return _isQuizActive && _overallStopwatch.IsRunning; }
        }

        // Timer câu hỏi có đang chạy không
        public bool IsQuestionRunning
        {
            get { return _isQuestionActive && _questionStopwatch.IsRunning; }
        }

        // Thời điểm bắt đầu quiz
        public DateTime QuizStartTime
        {
            get { return _quizStartTime; }
        }

        // Thời điểm bắt đầu câu hỏi hiện tại
        public DateTime QuestionStartTime
        {
            get { return _questionStartTime; }
        }



        // Constructor
        public TimeTracker()
        {
            _overallStopwatch = new Stopwatch();
            _questionStopwatch = new Stopwatch();
            Reset();
        }

        // Bắt đầu timer tổng thể của quiz
        public void StartQuiz()
        {
            if (_isQuizActive)
                return;

            _quizStartTime = DateTime.Now;
            _isQuizActive = true;
            _overallStopwatch.Start();
        }

        // Dừng timer tổng thể của quiz
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



        // Bắt đầu timer cho câu hỏi mới
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

        // Dừng timer câu hỏi hiện tại
        public TimeSpan StopQuestion()
        {
            if (!_isQuestionActive)
                return TimeSpan.Zero;

            _questionStopwatch.Stop();
            _isQuestionActive = false;

            return _questionStopwatch.Elapsed;
        }

        // Reset tất cả timer
        public void Reset()
        {
            _overallStopwatch.Reset();
            _questionStopwatch.Reset();
            _isQuizActive = false;
            _isQuestionActive = false;
            _quizStartTime = DateTime.MinValue;
            _questionStartTime = DateTime.MinValue;
        }

        // Format thời gian để hiển thị (MM:SS hoặc HH:MM:SS)
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

/*
 * GIẢI THÍCH VỀ LỚP TIMETRACKER:
 *
 * 1. DUAL TIMER SYSTEM:
 *    - _overallStopwatch: Theo dõi tổng thời gian làm quiz
 *    - _questionStopwatch: Theo dõi thời gian từng câu hỏi
 *    - Hoạt động độc lập nhưng có thể sync với nhau
 *
 * 2. STATE MANAGEMENT:
 *    - _isQuizActive: Quiz có đang active không
 *    - _isQuestionActive: Câu hỏi có đang active không
 *    - DateTime tracking: Lưu thời điểm bắt đầu chính xác
 *
 * 3. CORE METHODS:
 *    - StartQuiz()/StopQuiz(): Quản lý timer tổng thể
 *    - StartQuestion()/StopQuestion(): Quản lý timer từng câu
 *    - Reset(): Đặt lại tất cả timer về 0
 *
 * 4. PROPERTIES:
 *    - TotalElapsed: Tổng thời gian đã trôi qua
 *    - CurrentQuestionElapsed: Thời gian câu hỏi hiện tại
 *    - IsQuizRunning/IsQuestionRunning: Trạng thái timer
 *
 * 5. UTILITY FEATURES:
 *    - FormatTime(): Static method format thời gian đẹp
 *    - Tự động dừng question timer khi dừng quiz
 *    - Restart question timer khi bắt đầu câu mới
 *
 * 6. USE CASES:
 *    - Hiển thị thời gian real-time trong UI
 *    - Tính toán performance metrics
 *    - Ghi lại thời gian hoàn thành quiz
 *    - Phân tích thời gian trả lời từng câu
 */
