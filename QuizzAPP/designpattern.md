# Design Patterns trong Geography Quiz Game

## Tổng quan dự án
Geography Quiz Game là một ứng dụng Windows Forms được phát triển bằng C# .NET 9.0, sử dụng Material Design UI và thể hiện các nguyên lý lập trình hướng đối tượng thông qua việc triển khai nhiều design pattern khác nhau.

## Kiến trúc tổng thể

### Layered Architecture Pattern
```
┌─────────────────────────────────────┐
│     Presentation Layer (Forms)     │
├─────────────────────────────────────┤
│    Business Logic Layer (Managers) │
├─────────────────────────────────────┤
│       Data Layer (Models)          │
├─────────────────────────────────────┤
│      Utility Layer (Utils)         │
└─────────────────────────────────────┘
```

---

## 1. Template Method Pattern

### Mô tả
Template Method Pattern được triển khai trong lớp abstract `Question` để định nghĩa khung sườn chung cho việc xử lý câu hỏi.

### Triển khai
```csharp
// Abstract base class định nghĩa template
public abstract class Question
{
    // Template method - khung sườn chung
    public virtual string GetDisplayText()
    {
        return $"Q{Id}: {QuestionText}";
    }
    
    // Abstract method - bắt buộc implement
    public abstract bool IsAnswerCorrect(string userAnswer);
    public abstract string QuestionType { get; }
}
```

### Concrete implementations
- **MultipleChoiceQuestion**: Override `GetDisplayText()` để hiển thị các lựa chọn
- **OpenEndedQuestion**: Override `GetDisplayText()` để thêm hướng dẫn nhập
- **TrueFalseQuestion**: Override `GetDisplayText()` để hiển thị True/False options

### Lợi ích
- Đảm bảo tính nhất quán trong cách hiển thị câu hỏi
- Cho phép tùy chỉnh chi tiết cho từng loại câu hỏi
- Dễ dàng mở rộng thêm loại câu hỏi mới

---

## 2. Strategy Pattern

### Mô tả
Strategy Pattern được sử dụng để triển khai các thuật toán kiểm tra đáp án khác nhau cho từng loại câu hỏi.

### Triển khai
```csharp
// Strategy interface
public abstract bool IsAnswerCorrect(string userAnswer);

// Concrete strategies
public class MultipleChoiceQuestion : Question
{
    public override bool IsAnswerCorrect(string userAnswer)
    {
        // Strategy: So sánh index hoặc text
        if (int.TryParse(userAnswer.Trim(), out int selectedIndex))
            return selectedIndex == CorrectOptionIndex;
        return normalizedUserAnswer == normalizedCorrectAnswer;
    }
}

public class OpenEndedQuestion : Question
{
    public override bool IsAnswerCorrect(string userAnswer)
    {
        // Strategy: Normalize và so sánh với alternative answers
        return AlternativeAnswers.Any(alt => 
            NormalizeAnswer(alt) == normalizedUserAnswer);
    }
}

public class TrueFalseQuestion : Question
{
    public override bool IsAnswerCorrect(string userAnswer)
    {
        // Strategy: Parse nhiều format (True/False, T/F, 1/0, Yes/No)
        bool userAnswerBool = ParseBooleanAnswer(userAnswer);
        return userAnswerBool == IsTrue;
    }
}
```

### Lợi ích
- Mỗi loại câu hỏi có logic validation riêng biệt
- Dễ dàng thay đổi hoặc mở rộng logic kiểm tra
- Tuân thủ Open/Closed Principle

---

## 3. Observer Pattern

### Mô tả
Observer Pattern được triển khai thông qua event system trong `QuizManager` để thông báo cho UI khi có thay đổi dữ liệu.

### Triển khai
```csharp
// Subject (Observable)
public class QuizManager
{
    // Event declaration
    public event EventHandler<QuestionEventArgs>? QuestionChanged;
    
    // Notify observers
    protected virtual void OnQuestionChanged(QuestionEventArgs args)
    {
        QuestionChanged?.Invoke(this, args);
    }
    
    public int AddQuestion(Question question)
    {
        _questions.Add(question);
        // Notify observers about the change
        OnQuestionChanged(new QuestionEventArgs(question, QuestionChangeType.Added));
        return question.Id;
    }
}

// Event arguments
public class QuestionEventArgs : EventArgs
{
    public Question Question { get; }
    public QuestionChangeType ChangeType { get; }
}

public enum QuestionChangeType { Added, Updated, Removed }
```

### Observer (UI Forms)
```csharp
// Observer - Form1 subscribes to events
public Form1()
{
    _quizManager = new QuizManager();
    
    // Subscribe to events
    _quizManager.QuestionChanged += OnQuestionChanged;
}

private void OnQuestionChanged(object? sender, QuestionEventArgs e)
{
    // React to data changes
    UpdateStatsDisplay();
}
```

### Lợi ích
- UI tự động cập nhật khi dữ liệu thay đổi
- Loose coupling giữa business logic và presentation
- Dễ dàng thêm nhiều observer khác

---

## 4. Factory Method Pattern

### Mô tả
Factory Method Pattern được sử dụng trong `QuestionEditForm` để tạo ra các loại câu hỏi khác nhau dựa trên user input.

### Triển khai
```csharp
public class QuestionEditForm : MaterialForm
{
    // Factory method
    private Question CreateQuestionFromInput()
    {
        string questionText = questionTextBox.Text.Trim();
        
        // Factory logic based on type selection
        if (questionTypeComboBox.SelectedIndex == 0)
            return CreateMultipleChoiceQuestion(questionText);
        else if (questionTypeComboBox.SelectedIndex == 1)
            return CreateOpenEndedQuestion(questionText);
        else if (questionTypeComboBox.SelectedIndex == 2)
            return CreateTrueFalseQuestion(questionText);
        else
            throw new InvalidOperationException("Invalid question type selected.");
    }
    
    // Concrete factory methods
    private MultipleChoiceQuestion CreateMultipleChoiceQuestion(string questionText)
    {
        var options = GetOptionsFromUI();
        int correctIndex = GetCorrectIndexFromUI();
        return new MultipleChoiceQuestion(0, questionText, options, correctIndex);
    }
    
    private OpenEndedQuestion CreateOpenEndedQuestion(string questionText)
    {
        string correctAnswer = correctAnswerTextBox.Text.Trim();
        var alternatives = GetAlternativeAnswersFromUI();
        return new OpenEndedQuestion(0, questionText, correctAnswer, alternatives);
    }
    
    private TrueFalseQuestion CreateTrueFalseQuestion(string questionText)
    {
        bool isTrue = trueFalseComboBox.SelectedIndex == 0;
        return new TrueFalseQuestion(0, questionText, isTrue);
    }
}
```

### Lợi ích
- Encapsulate object creation logic
- Dễ dàng thêm loại câu hỏi mới
- Centralized creation logic

---

## 5. Repository Pattern

### Mô tả
Repository Pattern được triển khai trong `QuizManager` để quản lý collection của Question objects.

### Triển khai
```csharp
public class QuizManager
{
    private List<Question> _questions;
    
    // Repository interface
    public IReadOnlyList<Question> Questions => _questions.AsReadOnly();
    
    // CRUD operations
    public int AddQuestion(Question question) { /* ... */ }
    public bool UpdateQuestion(Question updatedQuestion) { /* ... */ }
    public bool RemoveQuestion(int questionId) { /* ... */ }
    public Question? GetQuestion(int questionId) { /* ... */ }
    public List<Question> GetQuestionsByType(string questionType) { /* ... */ }
    
    // Query methods
    public List<Question> GetShuffledQuestions() { /* ... */ }
    public QuizStatistics GetStatistics() { /* ... */ }
    public bool IsReadyToPlay() { /* ... */ }
}
```

### Lợi ích
- Abstraction layer cho data access
- Centralized data management
- Easy to test và mock
- Consistent CRUD interface

---

## 6. Singleton Pattern (Modified)

### Mô tả
MaterialSkinManager sử dụng Singleton pattern để đảm bảo consistent theming across toàn bộ application.

### Triển khai
```csharp
// MaterialSkinManager từ thư viện MaterialSkin.NET
public class MaterialSkinManager
{
    public static MaterialSkinManager Instance { get; }
    
    // Được sử dụng trong mọi form
    public Form1()
    {
        _materialSkinManager = MaterialSkinManager.Instance;
        _materialSkinManager.AddFormToManage(this);
        MaterialTheme.InitializeTheme(_materialSkinManager);
    }
}

// Utility class để apply theme consistently
public static class MaterialTheme
{
    public static void InitializeTheme(MaterialSkinManager materialSkinManager)
    {
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(/* ... */);
    }
}
```

### Lợi ích
- Consistent UI theming
- Global configuration management
- Resource efficiency

---

## 7. Composition Pattern

### Mô tả
Composition Pattern được sử dụng để xây dựng các object phức tạp từ các component đơn giản hơn.

### Triển khai
```csharp
// PlayGameForm composed of multiple managers
public class PlayGameForm : MaterialForm
{
    private readonly QuizManager _quizManager;        // Data management
    private readonly ScoreCalculator _scoreCalculator; // Score calculation
    private readonly TimeTracker _timeTracker;        // Time tracking
    
    public PlayGameForm(QuizManager quizManager)
    {
        _quizManager = quizManager;
        _scoreCalculator = new ScoreCalculator();  // Composition
        _timeTracker = new TimeTracker();          // Composition
    }
}

// ScoreCalculator composed of multiple result objects
public class ScoreCalculator
{
    private List<QuestionResult> _results;
    
    public ScoreBreakdown GetScoreBreakdown()
    {
        return new ScoreBreakdown
        {
            MultipleChoice = new TypeScore { /* ... */ },
            OpenEnded = new TypeScore { /* ... */ },
            TrueFalse = new TypeScore { /* ... */ }
        };
    }
}
```

### Lợi ích
- Modular design
- Reusable components
- Clear separation of concerns
- Easy to test individual components

---

## Kết luận

### Tổng kết Design Patterns được sử dụng:
1. **Template Method Pattern** - Question hierarchy
2. **Strategy Pattern** - Answer validation strategies
3. **Observer Pattern** - Event-driven UI updates
4. **Factory Method Pattern** - Question creation
5. **Repository Pattern** - Data management
6. **Singleton Pattern** - Theme management
7. **Composition Pattern** - Complex object construction

### Lợi ích tổng thể:
- **Maintainability**: Code dễ bảo trì và mở rộng
- **Testability**: Các component độc lập, dễ test
- **Reusability**: Các pattern có thể tái sử dụng
- **Scalability**: Dễ dàng thêm tính năng mới
- **Clean Architecture**: Separation of concerns rõ ràng

### Tuân thủ SOLID Principles:
- **Single Responsibility**: Mỗi class có một nhiệm vụ cụ thể
- **Open/Closed**: Mở cho extension, đóng cho modification
- **Liskov Substitution**: Derived classes có thể thay thế base class
- **Interface Segregation**: Interfaces nhỏ và focused
- **Dependency Inversion**: Depend on abstractions, not concretions

Dự án Geography Quiz Game thể hiện việc áp dụng thành công nhiều design pattern kinh điển, tạo ra một kiến trúc software vững chắc, dễ bảo trì và mở rộng.
