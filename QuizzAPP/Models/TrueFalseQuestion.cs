using System;

namespace QuizzAPP.Models
{
    // Câu hỏi đúng/sai - kế thừa từ Question
    public class TrueFalseQuestion : Question
    {
        private bool _isTrue;

        // Câu lệnh đúng hay sai
        public bool IsTrue
        {
            get { return _isTrue; }
            set
            {
                _isTrue = value;
                // Update the correct answer based on the boolean value
                CorrectAnswer = value ? "True" : "False";
            }
        }

        // Loại câu hỏi
        public override string QuestionType
        {
            get { return "True/False"; }
        }

        // Constructor
        public TrueFalseQuestion(int id, string questionText, bool isTrue)
            : base(id, questionText, isTrue ? "True" : "False")
        {
            IsTrue = isTrue;
        }

        // Kiểm tra đáp án đúng - hỗ trợ nhiều định dạng (True/False, T/F, 1/0, Yes/No)
        public override bool IsAnswerCorrect(string userAnswer)
        {
            if (string.IsNullOrWhiteSpace(userAnswer))
                return false;

            string normalizedAnswer = userAnswer.Trim().ToLowerInvariant();

            // Parse various true representations
            bool userAnswerBool;
            if (normalizedAnswer == "true" || normalizedAnswer == "t" || normalizedAnswer == "1" ||
                normalizedAnswer == "yes" || normalizedAnswer == "y")
            {
                userAnswerBool = true;
            }
            else if (normalizedAnswer == "false" || normalizedAnswer == "f" || normalizedAnswer == "0" ||
                     normalizedAnswer == "no" || normalizedAnswer == "n")
            {
                userAnswerBool = false;
            }
            else
            {
                throw new ArgumentException($"Invalid answer format: {userAnswer}. Please use True/False, T/F, 1/0, or Yes/No.");
            }

            return userAnswerBool == IsTrue;
        }



        // Hiển thị câu hỏi với hướng dẫn True/False
        public override string GetDisplayText()
        {
            return base.GetDisplayText() + "\n1. True\n2. False";
        }
    }
}

/*
 * GIẢI THÍCH VỀ LỚP TRUEFALSEQUESTION:
 *
 * 1. KẾ THỪA (Inheritance):
 *    - Kế thừa từ lớp Question
 *    - Sử dụng constructor của lớp cha
 *    - Override abstract method IsAnswerCorrect()
 *
 * 2. TÍNH LINH HOẠT:
 *    - Hỗ trợ nhiều định dạng đầu vào:
 *      + True/False (đầy đủ)
 *      + T/F (viết tắt)
 *      + 1/0 (số)
 *      + Yes/No (tiếng Anh)
 *      + Y/N (viết tắt Yes/No)
 *
 * 3. VALIDATION & PARSING:
 *    - Normalize input (trim, lowercase)
 *    - Parse thành boolean trước khi so sánh
 *    - Throw ArgumentException nếu format không hợp lệ
 *
 * 4. USER EXPERIENCE:
 *    - GetDisplayText() hiển thị "1. True\n2. False"
 *    - Dễ dàng cho người dùng chọn
 *    - Constructor đơn giản chỉ cần isTrue boolean
 *    - Tự động set CorrectAnswer thành "True" hoặc "False"
 */
