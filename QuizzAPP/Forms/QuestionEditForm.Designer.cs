namespace QuizzAPP.Forms
{
    partial class QuestionEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialLabel titleLabel;
        private MaterialSkin.Controls.MaterialLabel questionTypeLabel;
        private MaterialSkin.Controls.MaterialComboBox questionTypeComboBox;
        private MaterialSkin.Controls.MaterialLabel questionTextLabel;
        private MaterialSkin.Controls.MaterialTextBox questionTextBox;
        
        // Multiple Choice Controls
        private System.Windows.Forms.Panel multipleChoicePanel;
        private MaterialSkin.Controls.MaterialLabel optionsLabel;
        private MaterialSkin.Controls.MaterialTextBox option1TextBox;
        private MaterialSkin.Controls.MaterialTextBox option2TextBox;
        private MaterialSkin.Controls.MaterialTextBox option3TextBox;
        private MaterialSkin.Controls.MaterialTextBox option4TextBox;
        private MaterialSkin.Controls.MaterialLabel correctAnswerLabel;
        private MaterialSkin.Controls.MaterialComboBox correctAnswerComboBox;
        
        // Open Ended Controls
        private System.Windows.Forms.Panel openEndedPanel;
        private MaterialSkin.Controls.MaterialLabel correctAnswerTextLabel;
        private MaterialSkin.Controls.MaterialTextBox correctAnswerTextBox;
        private MaterialSkin.Controls.MaterialLabel alternativeAnswersLabel;
        private MaterialSkin.Controls.MaterialTextBox alternativeAnswersTextBox;
        
        // True/False Controls
        private System.Windows.Forms.Panel trueFalsePanel;
        private MaterialSkin.Controls.MaterialLabel trueFalseLabel;
        private MaterialSkin.Controls.MaterialComboBox trueFalseComboBox;
        
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            saveButton = new MaterialSkin.Controls.MaterialButton();
            trueFalsePanel = new System.Windows.Forms.Panel();
            trueFalseComboBox = new MaterialSkin.Controls.MaterialComboBox();
            trueFalseLabel = new MaterialSkin.Controls.MaterialLabel();
            openEndedPanel = new System.Windows.Forms.Panel();
            alternativeAnswersTextBox = new MaterialSkin.Controls.MaterialTextBox();
            alternativeAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            correctAnswerTextBox = new MaterialSkin.Controls.MaterialTextBox();
            correctAnswerTextLabel = new MaterialSkin.Controls.MaterialLabel();
            multipleChoicePanel = new System.Windows.Forms.Panel();
            correctAnswerComboBox = new MaterialSkin.Controls.MaterialComboBox();
            correctAnswerLabel = new MaterialSkin.Controls.MaterialLabel();
            option4TextBox = new MaterialSkin.Controls.MaterialTextBox();
            option3TextBox = new MaterialSkin.Controls.MaterialTextBox();
            option2TextBox = new MaterialSkin.Controls.MaterialTextBox();
            option1TextBox = new MaterialSkin.Controls.MaterialTextBox();
            optionsLabel = new MaterialSkin.Controls.MaterialLabel();
            questionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            questionTextLabel = new MaterialSkin.Controls.MaterialLabel();
            questionTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            questionTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            titleLabel = new MaterialSkin.Controls.MaterialLabel();
            mainPanel.SuspendLayout();
            trueFalsePanel.SuspendLayout();
            openEndedPanel.SuspendLayout();
            multipleChoicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(cancelButton);
            mainPanel.Controls.Add(saveButton);
            mainPanel.Controls.Add(trueFalsePanel);
            mainPanel.Controls.Add(openEndedPanel);
            mainPanel.Controls.Add(multipleChoicePanel);
            mainPanel.Controls.Add(questionTextBox);
            mainPanel.Controls.Add(questionTextLabel);
            mainPanel.Controls.Add(questionTypeComboBox);
            mainPanel.Controls.Add(questionTypeLabel);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(4, 74);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(28, 28, 28, 28);
            mainPanel.Size = new System.Drawing.Size(1042, 788);
            mainPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = false;
            cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = false;
            cancelButton.Icon = null;
            cancelButton.Location = new System.Drawing.Point(677, 554);
            cancelButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            cancelButton.Size = new System.Drawing.Size(105, 42);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "CANCEL";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = false;
            saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new System.Drawing.Point(548, 554);
            saveButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            saveButton.Size = new System.Drawing.Size(117, 42);
            saveButton.TabIndex = 8;
            saveButton.Text = "SAVE";
            saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // trueFalsePanel
            // 
            trueFalsePanel.Controls.Add(trueFalseComboBox);
            trueFalsePanel.Controls.Add(trueFalseLabel);
            trueFalsePanel.Location = new System.Drawing.Point(28, 323);
            trueFalsePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trueFalsePanel.Name = "trueFalsePanel";
            trueFalsePanel.Size = new System.Drawing.Size(754, 208);
            trueFalsePanel.TabIndex = 7;
            trueFalsePanel.Visible = false;
            // 
            // trueFalseComboBox
            // 
            trueFalseComboBox.AutoResize = false;
            trueFalseComboBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            trueFalseComboBox.Depth = 0;
            trueFalseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            trueFalseComboBox.DropDownHeight = 174;
            trueFalseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            trueFalseComboBox.DropDownWidth = 121;
            trueFalseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            trueFalseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            trueFalseComboBox.FormattingEnabled = true;
            trueFalseComboBox.IntegralHeight = false;
            trueFalseComboBox.ItemHeight = 43;
            trueFalseComboBox.Location = new System.Drawing.Point(0, 29);
            trueFalseComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trueFalseComboBox.MaxDropDownItems = 4;
            trueFalseComboBox.MouseState = MaterialSkin.MouseState.OUT;
            trueFalseComboBox.Name = "trueFalseComboBox";
            trueFalseComboBox.Size = new System.Drawing.Size(233, 49);
            trueFalseComboBox.StartIndex = 0;
            trueFalseComboBox.TabIndex = 1;
            trueFalseComboBox.SelectedIndexChanged += trueFalseComboBox_SelectedIndexChanged;
            // 
            // trueFalseLabel
            // 
            trueFalseLabel.AutoSize = true;
            trueFalseLabel.Depth = 0;
            trueFalseLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            trueFalseLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            trueFalseLabel.Location = new System.Drawing.Point(0, 0);
            trueFalseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            trueFalseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            trueFalseLabel.Name = "trueFalseLabel";
            trueFalseLabel.Size = new System.Drawing.Size(107, 19);
            trueFalseLabel.TabIndex = 0;
            trueFalseLabel.Text = "Correct Answer";
            // 
            // openEndedPanel
            // 
            openEndedPanel.Controls.Add(alternativeAnswersTextBox);
            openEndedPanel.Controls.Add(alternativeAnswersLabel);
            openEndedPanel.Controls.Add(correctAnswerTextBox);
            openEndedPanel.Controls.Add(correctAnswerTextLabel);
            openEndedPanel.Location = new System.Drawing.Point(28, 323);
            openEndedPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openEndedPanel.Name = "openEndedPanel";
            openEndedPanel.Size = new System.Drawing.Size(754, 208);
            openEndedPanel.TabIndex = 6;
            openEndedPanel.Visible = false;
            // 
            // alternativeAnswersTextBox
            // 
            alternativeAnswersTextBox.AnimateReadOnly = false;
            alternativeAnswersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            alternativeAnswersTextBox.Depth = 0;
            alternativeAnswersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            alternativeAnswersTextBox.Hint = "Enter alternative answers separated by commas (optional)";
            alternativeAnswersTextBox.LeadingIcon = null;
            alternativeAnswersTextBox.Location = new System.Drawing.Point(0, 127);
            alternativeAnswersTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            alternativeAnswersTextBox.MaxLength = 500;
            alternativeAnswersTextBox.MouseState = MaterialSkin.MouseState.OUT;
            alternativeAnswersTextBox.Multiline = false;
            alternativeAnswersTextBox.Name = "alternativeAnswersTextBox";
            alternativeAnswersTextBox.Size = new System.Drawing.Size(723, 50);
            alternativeAnswersTextBox.TabIndex = 3;
            alternativeAnswersTextBox.Text = "";
            alternativeAnswersTextBox.TrailingIcon = null;
            // 
            // alternativeAnswersLabel
            // 
            alternativeAnswersLabel.AutoSize = true;
            alternativeAnswersLabel.Depth = 0;
            alternativeAnswersLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            alternativeAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            alternativeAnswersLabel.Location = new System.Drawing.Point(0, 98);
            alternativeAnswersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            alternativeAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            alternativeAnswersLabel.Name = "alternativeAnswersLabel";
            alternativeAnswersLabel.Size = new System.Drawing.Size(140, 19);
            alternativeAnswersLabel.TabIndex = 2;
            alternativeAnswersLabel.Text = "Alternative Answers";
            // 
            // correctAnswerTextBox
            // 
            correctAnswerTextBox.AnimateReadOnly = false;
            correctAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            correctAnswerTextBox.Depth = 0;
            correctAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            correctAnswerTextBox.Hint = "Enter the correct answer (1-4 words)";
            correctAnswerTextBox.LeadingIcon = null;
            correctAnswerTextBox.Location = new System.Drawing.Point(0, 29);
            correctAnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            correctAnswerTextBox.MaxLength = 200;
            correctAnswerTextBox.MouseState = MaterialSkin.MouseState.OUT;
            correctAnswerTextBox.Multiline = false;
            correctAnswerTextBox.Name = "correctAnswerTextBox";
            correctAnswerTextBox.Size = new System.Drawing.Size(723, 50);
            correctAnswerTextBox.TabIndex = 1;
            correctAnswerTextBox.Text = "";
            correctAnswerTextBox.TrailingIcon = null;
            // 
            // correctAnswerTextLabel
            // 
            correctAnswerTextLabel.AutoSize = true;
            correctAnswerTextLabel.Depth = 0;
            correctAnswerTextLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            correctAnswerTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            correctAnswerTextLabel.Location = new System.Drawing.Point(0, 0);
            correctAnswerTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correctAnswerTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            correctAnswerTextLabel.Name = "correctAnswerTextLabel";
            correctAnswerTextLabel.Size = new System.Drawing.Size(107, 19);
            correctAnswerTextLabel.TabIndex = 0;
            correctAnswerTextLabel.Text = "Correct Answer";
            // 
            // multipleChoicePanel
            // 
            multipleChoicePanel.Controls.Add(correctAnswerComboBox);
            multipleChoicePanel.Controls.Add(correctAnswerLabel);
            multipleChoicePanel.Controls.Add(option4TextBox);
            multipleChoicePanel.Controls.Add(option3TextBox);
            multipleChoicePanel.Controls.Add(option2TextBox);
            multipleChoicePanel.Controls.Add(option1TextBox);
            multipleChoicePanel.Controls.Add(optionsLabel);
            multipleChoicePanel.Location = new System.Drawing.Point(28, 323);
            multipleChoicePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            multipleChoicePanel.Name = "multipleChoicePanel";
            multipleChoicePanel.Size = new System.Drawing.Size(754, 208);
            multipleChoicePanel.TabIndex = 5;
            multipleChoicePanel.Visible = false;
            // 
            // correctAnswerComboBox
            // 
            correctAnswerComboBox.AutoResize = false;
            correctAnswerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            correctAnswerComboBox.Depth = 0;
            correctAnswerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            correctAnswerComboBox.DropDownHeight = 174;
            correctAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            correctAnswerComboBox.DropDownWidth = 121;
            correctAnswerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            correctAnswerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            correctAnswerComboBox.FormattingEnabled = true;
            correctAnswerComboBox.IntegralHeight = false;
            correctAnswerComboBox.ItemHeight = 43;
            correctAnswerComboBox.Location = new System.Drawing.Point(140, 162);
            correctAnswerComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            correctAnswerComboBox.MaxDropDownItems = 4;
            correctAnswerComboBox.MouseState = MaterialSkin.MouseState.OUT;
            correctAnswerComboBox.Name = "correctAnswerComboBox";
            correctAnswerComboBox.Size = new System.Drawing.Size(209, 49);
            correctAnswerComboBox.StartIndex = 0;
            correctAnswerComboBox.TabIndex = 6;
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.AutoSize = true;
            correctAnswerLabel.Depth = 0;
            correctAnswerLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            correctAnswerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            correctAnswerLabel.Location = new System.Drawing.Point(0, 167);
            correctAnswerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correctAnswerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new System.Drawing.Size(107, 19);
            correctAnswerLabel.TabIndex = 5;
            correctAnswerLabel.Text = "Correct Answer";
            // 
            // option4TextBox
            // 
            option4TextBox.AnimateReadOnly = false;
            option4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            option4TextBox.Depth = 0;
            option4TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            option4TextBox.Hint = "Option 4";
            option4TextBox.LeadingIcon = null;
            option4TextBox.Location = new System.Drawing.Point(373, 98);
            option4TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            option4TextBox.MaxLength = 200;
            option4TextBox.MouseState = MaterialSkin.MouseState.OUT;
            option4TextBox.Multiline = false;
            option4TextBox.Name = "option4TextBox";
            option4TextBox.Size = new System.Drawing.Size(350, 50);
            option4TextBox.TabIndex = 4;
            option4TextBox.Text = "";
            option4TextBox.TrailingIcon = null;
            // 
            // option3TextBox
            // 
            option3TextBox.AnimateReadOnly = false;
            option3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            option3TextBox.Depth = 0;
            option3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            option3TextBox.Hint = "Option 3";
            option3TextBox.LeadingIcon = null;
            option3TextBox.Location = new System.Drawing.Point(0, 98);
            option3TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            option3TextBox.MaxLength = 200;
            option3TextBox.MouseState = MaterialSkin.MouseState.OUT;
            option3TextBox.Multiline = false;
            option3TextBox.Name = "option3TextBox";
            option3TextBox.Size = new System.Drawing.Size(350, 50);
            option3TextBox.TabIndex = 3;
            option3TextBox.Text = "";
            option3TextBox.TrailingIcon = null;
            // 
            // option2TextBox
            // 
            option2TextBox.AnimateReadOnly = false;
            option2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            option2TextBox.Depth = 0;
            option2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            option2TextBox.Hint = "Option 2";
            option2TextBox.LeadingIcon = null;
            option2TextBox.Location = new System.Drawing.Point(373, 29);
            option2TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            option2TextBox.MaxLength = 200;
            option2TextBox.MouseState = MaterialSkin.MouseState.OUT;
            option2TextBox.Multiline = false;
            option2TextBox.Name = "option2TextBox";
            option2TextBox.Size = new System.Drawing.Size(350, 50);
            option2TextBox.TabIndex = 2;
            option2TextBox.Text = "";
            option2TextBox.TrailingIcon = null;
            // 
            // option1TextBox
            // 
            option1TextBox.AnimateReadOnly = false;
            option1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            option1TextBox.Depth = 0;
            option1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            option1TextBox.Hint = "Option 1";
            option1TextBox.LeadingIcon = null;
            option1TextBox.Location = new System.Drawing.Point(0, 29);
            option1TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            option1TextBox.MaxLength = 200;
            option1TextBox.MouseState = MaterialSkin.MouseState.OUT;
            option1TextBox.Multiline = false;
            option1TextBox.Name = "option1TextBox";
            option1TextBox.Size = new System.Drawing.Size(350, 50);
            option1TextBox.TabIndex = 1;
            option1TextBox.Text = "";
            option1TextBox.TrailingIcon = null;
            // 
            // optionsLabel
            // 
            optionsLabel.AutoSize = true;
            optionsLabel.Depth = 0;
            optionsLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            optionsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            optionsLabel.Location = new System.Drawing.Point(0, 0);
            optionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            optionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            optionsLabel.Name = "optionsLabel";
            optionsLabel.Size = new System.Drawing.Size(56, 19);
            optionsLabel.TabIndex = 0;
            optionsLabel.Text = "Options";
            // 
            // questionTextBox
            // 
            questionTextBox.AnimateReadOnly = false;
            questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            questionTextBox.Depth = 0;
            questionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            questionTextBox.Hint = "Enter your question here...";
            questionTextBox.LeadingIcon = null;
            questionTextBox.Location = new System.Drawing.Point(28, 213);
            questionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            questionTextBox.MaxLength = 500;
            questionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new System.Drawing.Size(754, 50);
            questionTextBox.TabIndex = 4;
            questionTextBox.Text = "";
            questionTextBox.TrailingIcon = null;
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Depth = 0;
            questionTextLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            questionTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            questionTextLabel.Location = new System.Drawing.Point(28, 185);
            questionTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            questionTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new System.Drawing.Size(99, 19);
            questionTextLabel.TabIndex = 3;
            questionTextLabel.Text = "Question Text";
            // 
            // questionTypeComboBox
            // 
            questionTypeComboBox.AutoResize = false;
            questionTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            questionTypeComboBox.Depth = 0;
            questionTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            questionTypeComboBox.DropDownHeight = 174;
            questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            questionTypeComboBox.DropDownWidth = 121;
            questionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            questionTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            questionTypeComboBox.FormattingEnabled = true;
            questionTypeComboBox.IntegralHeight = false;
            questionTypeComboBox.ItemHeight = 43;
            questionTypeComboBox.Location = new System.Drawing.Point(28, 110);
            questionTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            questionTypeComboBox.MaxDropDownItems = 4;
            questionTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            questionTypeComboBox.Name = "questionTypeComboBox";
            questionTypeComboBox.Size = new System.Drawing.Size(349, 49);
            questionTypeComboBox.StartIndex = 0;
            questionTypeComboBox.TabIndex = 2;
            questionTypeComboBox.SelectedIndexChanged += questionTypeComboBox_SelectedIndexChanged;
            // 
            // questionTypeLabel
            // 
            questionTypeLabel.AutoSize = true;
            questionTypeLabel.Depth = 0;
            questionTypeLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            questionTypeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            questionTypeLabel.Location = new System.Drawing.Point(28, 81);
            questionTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            questionTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            questionTypeLabel.Name = "questionTypeLabel";
            questionTypeLabel.Size = new System.Drawing.Size(103, 19);
            questionTypeLabel.TabIndex = 1;
            questionTypeLabel.Text = "Question Type";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Depth = 0;
            titleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            titleLabel.Location = new System.Drawing.Point(28, 28);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(145, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Edit Question";
            // 
            // QuestionEditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1050, 865);
            Controls.Add(mainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Text = "Edit Question";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            trueFalsePanel.ResumeLayout(false);
            trueFalsePanel.PerformLayout();
            openEndedPanel.ResumeLayout(false);
            openEndedPanel.PerformLayout();
            multipleChoicePanel.ResumeLayout(false);
            multipleChoicePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
