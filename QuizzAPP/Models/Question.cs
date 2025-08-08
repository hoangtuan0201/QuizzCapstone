using System;

namespace QuizzAPP.Models
{
    // Lớp cơ sở trừu tượng cho tất cả các loại câu hỏi
    // Thể hiện tính trừu tượng và kế thừa trong OOP
    public abstract class Question
    {
        private string _questionText = string.Empty;
        private string _correctAnswer = string.Empty;
        private int _id;

        // ID duy nhất của câu hỏi
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Nội dung câu hỏi
        public string QuestionText
        {
            get { return _questionText; }
            set { _questionText = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        // Đáp án đúng của câu hỏi
        public string CorrectAnswer
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        // Loại câu hỏi - phải được implement bởi các lớp con
        public abstract string QuestionType { get; }

        // Constructor của lớp Question
        protected Question(int id, string questionText, string correctAnswer)
        {
            Id = id;
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        // Kiểm tra đáp án có đúng không - mỗi loại câu hỏi sẽ implement khác nhau
        public abstract bool IsAnswerCorrect(string userAnswer);

        // Lấy text hiển thị của câu hỏi
        public virtual string GetDisplayText()
        {
            return $"Q{Id}: {QuestionText}";
        }

        
    }
}

/*
 * GIẢI THÍCH VỀ LỚP QUESTION:
 *
 * 1. TÍNH TRỪU TƯỢNG (Abstraction):
 *    - Question là abstract class, không thể tạo instance trực tiếp
 *    - Có abstract method IsAnswerCorrect() bắt buộc các lớp con phải implement
 *    - Có abstract property QuestionType để xác định loại câu hỏi
 *
 * 2. TÍNH ĐÓNG GÓI (Encapsulation):
 *    - Các field private (_id, _questionText, _correctAnswer)
 *    - Truy cập thông qua public properties với validation
 *    - Bảo vệ dữ liệu khỏi truy cập trực tiếp
 *
 * 3. TÍNH KẾ THỪA (Inheritance):
 *    - Là lớp cha cho MultipleChoiceQuestion, OpenEndedQuestion, TrueFalseQuestion
 *    - Cung cấp các thuộc tính và phương thức chung
 *    - Constructor được gọi từ các lớp con
 *
 * 4. TÍNH ĐA HÌNH (Polymorphism):
 *    - Method IsAnswerCorrect() được implement khác nhau ở mỗi lớp con
 *    - Virtual method GetDisplayText() có thể được override
 *    - Có thể xử lý các loại câu hỏi khác nhau thông qua interface chung
 */
