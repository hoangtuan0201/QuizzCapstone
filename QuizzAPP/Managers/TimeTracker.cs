using System;
using System.Diagnostics;

namespace QuizzAPP.Managers
{
    // Tracks the total time spent on the quiz
    public class TimeTracker
    {
        private Stopwatch _overallStopwatch;   // Stopwatch for total quiz time
        private bool _isQuizActive;            // Indicates if the quiz is currently running

        // Total elapsed time since the quiz started
        public TimeSpan TotalElapsed
        {
            get { return _overallStopwatch.Elapsed; }
        }

        // Constructor
        public TimeTracker()
        {
            _overallStopwatch = new Stopwatch();
            Reset();
        }

        // Starts the overall quiz timer
        public void StartQuiz()
        {
            if (_isQuizActive)
                return;
            _isQuizActive = true;
            _overallStopwatch.Start();
        }

        // Stops the overall quiz timer and returns the total elapsed time
        public TimeSpan StopQuiz()
        {
            if (!_isQuizActive)
                return TimeSpan.Zero;

            _overallStopwatch.Stop();
            _isQuizActive = false;

            return _overallStopwatch.Elapsed;
        }

        // Resets all timers to their initial state
        public void Reset()
        {
            _overallStopwatch.Reset();
            _isQuizActive = false;
        }

        // Formats the time for display (MM:SS or HH:MM:SS)
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
 * GIẢI THÍCH VỀ LỚP TIMETRACKER (PHIÊN BẢN RÚT GỌN):
 *
 * 1. CHỨC NĂNG CHÍNH:
 *    - Theo dõi tổng thời gian làm quiz bằng Stopwatch (_overallStopwatch).
 *    - Không còn quản lý thời gian từng câu hỏi riêng lẻ.
 *
 * 2. QUẢN LÝ TRẠNG THÁI:
 *    - _isQuizActive: Xác định quiz có đang chạy hay không.
 *    - Reset() sẽ đưa quiz về trạng thái ban đầu (thời gian = 0).
 *
 * 3. PHƯƠNG THỨC CỐT LÕI:
 *    - StartQuiz(): Bắt đầu đo tổng thời gian quiz.
 *    - StopQuiz(): Dừng đo và trả về tổng thời gian đã trôi qua.
 *    - Reset(): Đặt lại đồng hồ về 0.
 *
 * 4. THUỘC TÍNH:
 *    - TotalElapsed: Tổng thời gian quiz đã chạy (TimeSpan).
 *
 * 5. HÀM TIỆN ÍCH:
 *    - FormatTime(): Chuyển TimeSpan thành chuỗi định dạng đẹp (MM:SS hoặc HH:MM:SS) để hiển thị lên UI.
 *
 * 6. ỨNG DỤNG:
 *    - Hiển thị thời gian quiz real-time trong giao diện người dùng.
 *    - Tính toán thời gian hoàn thành quiz cho báo cáo hoặc thống kê.
 */
 