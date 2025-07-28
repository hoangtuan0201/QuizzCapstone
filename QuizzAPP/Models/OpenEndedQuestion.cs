using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzAPP.Models
{
    // Câu hỏi tự luận - hỗ trợ nhiều đáp án đúng (VD: "United Kingdom" và "UK")
    public class OpenEndedQuestion : Question
    {
        private List<string> _alternativeAnswers = new List<string>();

        // Danh sách các đáp án đúng khác
        public List<string> AlternativeAnswers
        {
            get { return _alternativeAnswers; }
            set { _alternativeAnswers = value ?? new List<string>(); }
        }

        // Loại câu hỏi
        public override string QuestionType
        {
            get { return "Open Ended"; }
        }

        // Constructor
        public OpenEndedQuestion(int id, string questionText, string correctAnswer, List<string>? alternativeAnswers = null)
            : base(id, questionText, correctAnswer)
        {
            AlternativeAnswers = alternativeAnswers ?? new List<string>();
        }

        // Kiểm tra đáp án đúng - hỗ trợ nhiều biến thể đáp án
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string normalizedUserAnswer = NormalizeAnswer(userAnswer);
            string normalizedCorrectAnswer = NormalizeAnswer(CorrectAnswer);

            // Check primary answer
            if (normalizedUserAnswer == normalizedCorrectAnswer)
                return true;

            // Check alternative answers
            return AlternativeAnswers.Any(alt =>
            {
                return NormalizeAnswer(alt) == normalizedUserAnswer;
            });
        }

        /// <summary>
        /// Normalize answer for comparison (remove extra spaces, convert to lowercase, etc.)
        /// </summary>
        /// <param name="answer">Raw answer</param>
        /// <returns>Normalized answer</returns>
        private string NormalizeAnswer(string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                return string.Empty;

            return answer.Trim()
                        .ToLowerInvariant()
                        .Replace("  ", " ") // Replace double spaces with single space
                        .Replace(".", "") // Remove periods
                        .Replace(",", ""); // Remove commas
        }



        // Hiển thị câu hỏi với hướng dẫn
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + "\n(Enter your answer - 1 to 4 words)";
        }
    }
}

/*
 * GIẢI THÍCH VỀ LỚP OPENENDEDQUESTION:
 *
 * 1. KẾ THỪA (Inheritance):
 *    - Kế thừa từ lớp Question
 *    - Sử dụng constructor của lớp cha
 *    - Override abstract method IsAnswerCorrect()
 *
 * 2. TÍNH NĂNG ĐẶC BIỆT:
 *    - Hỗ trợ nhiều đáp án đúng (AlternativeAnswers)
 *    - VD: "United Kingdom", "UK", "Britain" đều đúng
 *    - Normalize answer để so sánh (bỏ dấu, viết thường, trim)
 *
 * 3. VALIDATION & NORMALIZATION:
 *    - NormalizeAnswer() chuẩn hóa text trước khi so sánh
 *    - Bỏ khoảng trắng thừa, dấu chấm, dấu phẩy
 *    - Chuyển về chữ thường để so sánh không phân biệt hoa thường
 *
 * 4. USER EXPERIENCE:
 *    - GetDisplayText() thêm hướng dẫn "(Enter your answer - 1 to 4 words)"
 *    - Linh hoạt trong việc nhận đáp án từ người dùng
 *    - Kiểm tra cả đáp án chính và các đáp án thay thế
 */
