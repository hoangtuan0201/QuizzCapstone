using MaterialSkin;
using MaterialSkin.Controls;
using QuizzAPP.Forms;
using QuizzAPP.Managers;
using QuizzAPP.Utils;

namespace QuizzAPP;

public partial class Form1 : MaterialForm
{
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly QuizManager _quizManager;

    public Form1()
    {
        // Initialize Material Design
        _materialSkinManager = MaterialSkinManager.Instance;
        _materialSkinManager.AddFormToManage(this);
        MaterialTheme.InitializeTheme(_materialSkinManager);

        InitializeComponent();

        // Initialize quiz manager
        _quizManager = new QuizManager();

        // Apply Material Design styling
        MaterialTheme.ApplyFormStyling(this);

        // Set form properties
        this.Text = "Geography Quiz Game";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MinimumSize = new Size(800, 600);
        this.Size = new Size(800, 700);

        // Subscribe to quiz manager events
        _quizManager.QuestionChanged += OnQuestionChanged;

        // Auto-load sample questions on startup
        SampleDataLoader.LoadSampleQuestions(_quizManager);

        // Update stats display
        UpdateStatsDisplay();
    }

    private void OnQuestionChanged(object? sender, Managers.QuestionEventArgs e)
    {
        UpdateStatsDisplay();
    }

    private void UpdateStatsDisplay()
    {
        var stats = _quizManager.GetStatistics();
        if (stats.TotalQuestions == 0)
        {
            statsLabel.Text = "No questions available. Please add some questions to start playing!";
            playGameButton.Enabled = false;
        }
        else
        {
            statsLabel.Text = $"Ready to play! Total Questions: {stats.TotalQuestions} " +
                             $"(Multiple Choice: {stats.MultipleChoiceCount}, " +
                             $"Open Ended: {stats.OpenEndedCount}, " +
                             $"True/False: {stats.TrueFalseCount})";
            playGameButton.Enabled = true;
        }
    }

    private void createGameButton_Click(object sender, EventArgs e)
    {
        var createGameForm = new CreateGameForm(_quizManager);
        createGameForm.ShowDialog();
    }

    private void playGameButton_Click(object sender, EventArgs e)
    {
        if (!_quizManager.IsReadyToPlay())
        {
            MessageBox.Show("Please create some questions first!", "No Questions",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var playGameForm = new PlayGameForm(_quizManager);
        playGameForm.ShowDialog();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }


}