# UML Class Diagram - Geography Quiz Game

## Overview
This comprehensive UML Class Diagram illustrates the object-oriented architecture of the Geography Quiz Game, demonstrating inheritance, encapsulation, abstraction, and polymorphism principles as required for COMP1551 coursework.

## Class Diagram

```mermaid
classDiagram
    %% Models Layer - Question Hierarchy
    class Question {
        <<abstract>>
        -int _id
        -string _questionText
        -string _correctAnswer
        +int Id
        +string QuestionText
        +string CorrectAnswer
        +abstract string QuestionType
        #Question(int id, string questionText, string correctAnswer)
        +abstract bool IsAnswerCorrect(string userAnswer)
        +virtual string GetDisplayText()
        +string ToString()
    }

    class MultipleChoiceQuestion {
        -List~string~ _options
        -int _correctOptionIndex
        +List~string~ Options
        +int CorrectOptionIndex
        +string QuestionType
        +MultipleChoiceQuestion(int id, string questionText, List~string~ options, int correctOptionIndex)
        +bool IsAnswerCorrect(string userAnswer)
        +string GetDisplayText()
    }

    class OpenEndedQuestion {
        -List~string~ _alternativeAnswers
        +List~string~ AlternativeAnswers
        +string QuestionType
        +OpenEndedQuestion(int id, string questionText, string correctAnswer, List~string~ alternativeAnswers)
        +bool IsAnswerCorrect(string userAnswer)
        -string NormalizeAnswer(string answer)
        +string GetDisplayText()
    }

    class TrueFalseQuestion {
        -bool _isTrue
        +bool IsTrue
        +string QuestionType
        +TrueFalseQuestion(int id, string questionText, bool isTrue)
        +bool IsAnswerCorrect(string userAnswer)
        +string GetDisplayText()
    }

    %% Managers Layer
    class QuizManager {
        -List~Question~ _questions
        -int _nextQuestionId
        +IReadOnlyList~Question~ Questions
        +int QuestionCount
        +event EventHandler~QuestionEventArgs~ QuestionChanged
        +QuizManager()
        +int AddQuestion(Question question)
        +bool UpdateQuestion(Question updatedQuestion)
        +bool RemoveQuestion(int questionId)
        +Question GetQuestion(int questionId)
        +List~Question~ GetQuestionsByType(string questionType)
        +void ClearAllQuestions()
        +List~Question~ GetShuffledQuestions()
        +bool IsReadyToPlay()
        +QuizStatistics GetStatistics()
        #virtual void OnQuestionChanged(QuestionEventArgs args)
    }

    class ScoreManager {
        -List~QuestionResult~ _results
        +IReadOnlyList~QuestionResult~ Results
        +int TotalQuestions
        +int CorrectAnswers
        +int IncorrectAnswers
        +double ScorePercentage
        +string ScoreFraction
        +string LetterGrade
        +ScoreManager()
        +void RecordAnswer(Question question, string userAnswer, bool isCorrect, TimeSpan timeSpent)
        +void Reset()
        +List~QuestionResult~ GetResultsByType(string questionType)
        +ScoreBreakdown GetScoreBreakdown()
        -string GetLetterGrade(double percentage)
    }

    class TimeTracker {
        -Stopwatch _overallStopwatch
        -bool _isQuizActive
        +TimeSpan TotalElapsed
        +TimeTracker()
        +void StartQuiz()
        +TimeSpan StopQuiz()
        +void Reset()
        +static string FormatTime(TimeSpan timeSpan)
    }

    %% Supporting Classes
    class QuestionResult {
        +Question Question
        +string UserAnswer
        +bool IsCorrect
        +TimeSpan TimeSpent
        +DateTime AnsweredAt
    }

    class QuestionEventArgs {
        +Question Question
        +QuestionChangeType ChangeType
        +QuestionEventArgs(Question question, QuestionChangeType changeType)
    }

    class QuizStatistics {
        +int TotalQuestions
        +int MultipleChoiceCount
        +int OpenEndedCount
        +int TrueFalseCount
    }

    class ScoreBreakdown {
        +TypeScore MultipleChoice
        +TypeScore OpenEnded
        +TypeScore TrueFalse
        +TypeScore Overall
    }

    class TypeScore {
        +int Correct
        +int Total
        +double Percentage
        +string Fraction
    }

    %% Enums
    class QuestionChangeType {
        <<enumeration>>
        Added
        Updated
        Removed
    }

    %% Inheritance Relationships
    Question <|-- MultipleChoiceQuestion : inherits
    Question <|-- OpenEndedQuestion : inherits
    Question <|-- TrueFalseQuestion : inherits

    %% Composition Relationships
    QuizManager *-- Question : manages 1..*
    ScoreManager *-- QuestionResult : contains 0..*
    QuestionResult *-- Question : references 1
    ScoreBreakdown *-- TypeScore : contains 4

    %% Association Relationships
    QuizManager --> QuestionEventArgs : creates
    QuizManager --> QuizStatistics : creates
    QuestionEventArgs --> QuestionChangeType : uses
    ScoreManager --> ScoreBreakdown : creates

    %% Dependency Relationships
    QuizManager ..> Question : uses
    ScoreManager ..> Question : uses
```

## Relationship Details

### Inheritance Relationships (Hollow Triangle Arrows)
- **Question** ← **MultipleChoiceQuestion** (1:1 inheritance)
- **Question** ← **OpenEndedQuestion** (1:1 inheritance)  
- **Question** ← **TrueFalseQuestion** (1:1 inheritance)

### Composition Relationships (Filled Diamond)
- **QuizManager** ◆→ **Question** (1 to many - QuizManager owns Questions)
- **ScoreManager** ◆→ **QuestionResult** (1 to many - ScoreManager owns Results)
- **QuestionResult** ◆→ **Question** (1 to 1 - QuestionResult contains Question reference)
- **ScoreBreakdown** ◆→ **TypeScore** (1 to 4 - contains MultipleChoice, OpenEnded, TrueFalse, Overall)

### Association Relationships (Simple Arrows)
- **QuizManager** → **QuestionEventArgs** (creates events)
- **QuizManager** → **QuizStatistics** (generates statistics)
- **ScoreManager** → **ScoreBreakdown** (creates breakdown analysis)

### Dependency Relationships (Dashed Arrows)
- **QuestionEventArgs** ⇢ **QuestionChangeType** (uses enum)

## Multiplicity Indicators

| Relationship | Multiplicity | Description |
|-------------|-------------|-------------|
| QuizManager → Question | 1 to * | One QuizManager manages many Questions |
| ScoreManager → QuestionResult | 1 to * | One ScoreManager contains many QuestionResults |
| QuestionResult → Question | * to 1 | Many QuestionResults reference one Question |
| ScoreBreakdown → TypeScore | 1 to 4 | One ScoreBreakdown contains exactly 4 TypeScores |

## Visibility Indicators

| Symbol | Visibility | Usage |
|--------|-----------|-------|
| + | Public | Properties, public methods, constructors |
| - | Private | Private fields, private helper methods |
| # | Protected | Protected constructors, protected virtual methods |

## Abstract Elements (Italics in Implementation)

### Abstract Class
- **Question** - Cannot be instantiated directly

### Abstract Members
- **Question.QuestionType** - Abstract property, must be implemented by subclasses
- **Question.IsAnswerCorrect()** - Abstract method, must be implemented by subclasses

### Virtual Members
- **Question.GetDisplayText()** - Virtual method, can be overridden by subclasses
- **QuizManager.OnQuestionChanged()** - Virtual method for event handling

## OOP Principles Demonstrated

### 1. Inheritance
- **Question** serves as abstract base class
- **MultipleChoiceQuestion**, **OpenEndedQuestion**, **TrueFalseQuestion** inherit from Question
- Common properties and methods defined in base class
- Specialized behavior implemented in derived classes

### 2. Encapsulation
- Private fields with public property accessors
- Data validation in property setters
- Internal state protected from direct access
- Clear public interface for each class

### 3. Abstraction
- **Question** abstract class defines contract for all question types
- Abstract methods force implementation in concrete classes
- Complex internal logic hidden behind simple public interfaces
- Manager classes abstract away data management complexity

### 4. Polymorphism
- **IsAnswerCorrect()** method behaves differently for each question type
- **GetDisplayText()** method customized per question type
- Questions can be treated uniformly through base class reference
- Runtime method resolution based on actual object type

## Design Patterns Implemented

### 1. Template Method Pattern
- **Question.GetDisplayText()** provides base implementation
- Subclasses can override to customize display format

### 2. Strategy Pattern
- Different answer validation strategies in **IsAnswerCorrect()** implementations
- Each question type has unique validation logic

### 3. Observer Pattern
- **QuizManager.QuestionChanged** event notifies UI of data changes
- **QuestionEventArgs** carries event information
- Loose coupling between data layer and presentation layer

### 4. Repository Pattern
- **QuizManager** acts as repository for Question objects
- Provides CRUD operations and query methods
- Encapsulates data access logic

## Class Responsibilities

### Models Layer
- **Question**: Abstract base defining common question interface
- **MultipleChoiceQuestion**: Handles 4-option questions with index-based answers
- **OpenEndedQuestion**: Manages text-based answers with alternative answer support
- **TrueFalseQuestion**: Processes boolean questions with flexible input formats

### Managers Layer
- **QuizManager**: CRUD operations, question management, event notifications
- **ScoreManager**: Score calculation, result tracking, performance analysis
- **TimeTracker**: Quiz timing, stopwatch management, time formatting

### Supporting Classes
- **QuestionResult**: Individual question answer data
- **QuestionEventArgs**: Event data for question changes
- **QuizStatistics**: Aggregate statistics about quiz content
- **ScoreBreakdown**: Detailed performance analysis by question type
- **TypeScore**: Score metrics for specific question types
- **QuestionChangeType**: Enumeration of possible question changes

This UML Class Diagram demonstrates comprehensive object-oriented design principles and serves as complete documentation for the Geography Quiz Game architecture, fulfilling all COMP1551 coursework requirements for Part 3 UML documentation.
