using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizzAPP.Models
{
    // Câu hỏi trắc nghiệm với 4 lựa chọn - kế thừa từ Question
    public class MultipleChoiceQuestion : Question
    {
        private List<string> _options = new List<string>();
        private int _correctOptionIndex;

        // Danh sách 4 lựa chọn
        public List<string> Options
        {
            get { return _options; }
            set
            {
                if (value == null || value.Count != 4)
                    throw new ArgumentException("Multiple choice questions must have exactly 4 options.");
                _options = value;
            }
        }

        // Chỉ số đáp án đúng (0-3)
        public int CorrectOptionIndex
        {
            get { return _correctOptionIndex; }
            set
            {
                if (value < 0 || value > 3)
                    throw new ArgumentOutOfRangeException(nameof(value), "Correct option index must be between 0 and 3.");
                _correctOptionIndex = value;
            }
        }

        // Loại câu hỏi
        public override string QuestionType
        {
            get { return "Multiple Choice"; }
        }

        // Constructor
        public MultipleChoiceQuestion(int id, string questionText, List<string> options, int correctOptionIndex)
            : base(id, questionText, "")
        {
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
            // Set the correct answer to the text of the correct option
            CorrectAnswer = options[correctOptionIndex];
        }

        // Kiểm tra đáp án đúng - implement từ abstract method
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            // Try to parse as index first (0, 1, 2, 3)
            if (int.TryParse(userAnswer.Trim(), out int selectedIndex))
            {
                return selectedIndex == CorrectOptionIndex;
            }

            // Try to match the actual text of the option
            string normalizedUserAnswer = userAnswer.Trim().ToLowerInvariant();
            string normalizedCorrectAnswer = CorrectAnswer.Trim().ToLowerInvariant();
            
            return normalizedUserAnswer == normalizedCorrectAnswer;
        }

        // Hiển thị câu hỏi với các lựa chọn được đánh số
        public override string GetDisplayText()
        {
            var displayText = base.GetDisplayText() + "\n";
            for (int i = 0; i < Options.Count; i++)
            {
                displayText += $"{i + 1}. {Options[i]}\n";
            }
            return displayText.TrimEnd();
        }
    }
}

/*
 * GIẢI THÍCH VỀ LỚP MULTIPLECHOICEQUESTION:
 *
 * 1. KẾ THỪA (Inheritance):
 *    - Kế thừa từ lớp Question
 *    - Sử dụng constructor của lớp cha với base()
 *    - Override các abstract method và virtual method
 *
 * 2. ĐÓNG GÓI (Encapsulation):
 *    - Private fields: _options, _correctOptionIndex
 *    - Public properties với validation logic
 *    - Bảo vệ dữ liệu với ArgumentException khi không hợp lệ
 *
 * 3. ĐA HÌNH (Polymorphism):
 *    - Override IsAnswerCorrect() với logic riêng cho trắc nghiệm
 *    - Override GetDisplayText() để hiển thị các lựa chọn
 *    - Có thể xử lý cả index (0,1,2,3) và text của đáp án
 *
 * 4. VALIDATION:
 *    - Bắt buộc phải có đúng 4 lựa chọn
 *    - Index đáp án đúng phải từ 0-3
 *    - Tự động set CorrectAnswer từ Options[correctOptionIndex]
 */
