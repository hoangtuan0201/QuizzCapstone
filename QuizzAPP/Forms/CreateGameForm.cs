using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using QuizzAPP.Managers;
using QuizzAPP.Models;
using QuizzAPP.Utils;

namespace QuizzAPP.Forms
{
    public partial class CreateGameForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private readonly QuizManager _quizManager;

        public CreateGameForm(QuizManager quizManager)
        {
            _quizManager = quizManager ?? throw new ArgumentNullException(nameof(quizManager));

            // Initialize Material Design
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);

            InitializeComponent();
            
            // Apply Material Design styling
            MaterialTheme.ApplyFormStyling(this);
            
            // Set form properties
            this.Text = "Create Quiz Questions";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(900, 700);
            this.MinimumSize = new Size(1300, 600);

            // Load existing questions
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            questionsListBox.Items.Clear();
            
            foreach (var question in _quizManager.Questions)
            {
                questionsListBox.Items.Add($"[{question.QuestionType}] {question.QuestionText}");
            }

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = questionsListBox.SelectedIndex >= 0;
            editButton.Enabled = hasSelection;
            deleteButton.Enabled = hasSelection;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var questionEditForm = new QuestionEditForm(_quizManager);
            if (questionEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadQuestions();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex < 0) return;

            var selectedQuestion = _quizManager.Questions[questionsListBox.SelectedIndex];
            var questionEditForm = new QuestionEditForm(_quizManager, selectedQuestion);
            
            if (questionEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadQuestions();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex < 0) return;

            var selectedQuestion = _quizManager.Questions[questionsListBox.SelectedIndex];
            var result = MessageBox.Show(
                $"Are you sure you want to delete this question?\n\n{selectedQuestion.QuestionText}",
                "Delete Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _quizManager.RemoveQuestion(selectedQuestion.Id);
                LoadQuestions();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            if (_quizManager.QuestionCount == 0)
            {
                MessageBox.Show("No questions to clear.", "Information", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete all {_quizManager.QuestionCount} questions?",
                "Clear All Questions",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _quizManager.ClearAllQuestions();
                LoadQuestions();
            }
        }

        private void questionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
            
            if (questionsListBox.SelectedIndex >= 0)
            {
                var selectedQuestion = _quizManager.Questions[questionsListBox.SelectedIndex];
                ShowQuestionPreview(selectedQuestion);
            }
            else
            {
                ClearQuestionPreview();
            }
        }

        private void ShowQuestionPreview(Question question)
        {
            previewLabel.Text = question.GetDisplayText();

            // Thêm phần hiển thị đáp án với format đẹp hơn
            previewLabel.Text += "\n\n" + "".PadRight(50, '=');
            previewLabel.Text += "\n📝 ĐÁP ÁN:";

            switch (question)
            {
                case MultipleChoiceQuestion mcq:
                    previewLabel.Text += $"\n✅ Correct answer: {mcq.CorrectOptionIndex + 1}. {mcq.CorrectAnswer}";
                    break;
                case OpenEndedQuestion oeq:
                    previewLabel.Text += $"\n✅ Correct answer: {oeq.CorrectAnswer}";
                    if (oeq.AlternativeAnswers.Any())
                    {
                        previewLabel.Text += $"\n🔄 Alternative answer: {string.Join(", ", oeq.AlternativeAnswers)}";
                    }
                    break;
                case TrueFalseQuestion tfq:
                    previewLabel.Text += $"\n✅ Correct answer: {tfq.CorrectAnswer}";
                    break;
            }

            previewLabel.Text += "\n" + "".PadRight(50, '=');
        }

        private void ClearQuestionPreview()
        {
            previewLabel.Text = "Select a question to preview it here.";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void questionsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex >= 0)
            {
                editButton_Click(sender, e);
            }
        }

        
    }
}
