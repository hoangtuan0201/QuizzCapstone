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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionTypeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.questionTextLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.multipleChoicePanel = new System.Windows.Forms.Panel();
            this.optionsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.option1TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.option2TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.option3TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.option4TextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.correctAnswerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.correctAnswerComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.openEndedPanel = new System.Windows.Forms.Panel();
            this.correctAnswerTextLabel = new MaterialSkin.Controls.MaterialLabel();
            this.correctAnswerTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.alternativeAnswersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.alternativeAnswersTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.trueFalsePanel = new System.Windows.Forms.Panel();
            this.trueFalseLabel = new MaterialSkin.Controls.MaterialLabel();
            this.trueFalseComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.mainPanel.SuspendLayout();
            this.multipleChoicePanel.SuspendLayout();
            this.openEndedPanel.SuspendLayout();
            this.trueFalsePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.saveButton);
            this.mainPanel.Controls.Add(this.trueFalsePanel);
            this.mainPanel.Controls.Add(this.openEndedPanel);
            this.mainPanel.Controls.Add(this.multipleChoicePanel);
            this.mainPanel.Controls.Add(this.questionTextBox);
            this.mainPanel.Controls.Add(this.questionTextLabel);
            this.mainPanel.Controls.Add(this.questionTypeComboBox);
            this.mainPanel.Controls.Add(this.questionTypeLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(24);
            this.mainPanel.Size = new System.Drawing.Size(894, 683);
            this.mainPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Depth = 0;
            this.titleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.titleLabel.Location = new System.Drawing.Point(24, 24);
            this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(174, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Edit Question";
            // 
            // questionTypeLabel
            // 
            this.questionTypeLabel.AutoSize = true;
            this.questionTypeLabel.Depth = 0;
            this.questionTypeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.questionTypeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.questionTypeLabel.Location = new System.Drawing.Point(24, 70);
            this.questionTypeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionTypeLabel.Name = "questionTypeLabel";
            this.questionTypeLabel.Size = new System.Drawing.Size(101, 19);
            this.questionTypeLabel.TabIndex = 1;
            this.questionTypeLabel.Text = "Question Type";
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.AutoResize = false;
            this.questionTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.questionTypeComboBox.Depth = 0;
            this.questionTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.questionTypeComboBox.DropDownHeight = 174;
            this.questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionTypeComboBox.DropDownWidth = 121;
            this.questionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.questionTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionTypeComboBox.FormattingEnabled = true;
            this.questionTypeComboBox.IntegralHeight = false;
            this.questionTypeComboBox.ItemHeight = 43;
            this.questionTypeComboBox.Location = new System.Drawing.Point(24, 95);
            this.questionTypeComboBox.MaxDropDownItems = 4;
            this.questionTypeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(300, 49);
            this.questionTypeComboBox.StartIndex = 0;
            this.questionTypeComboBox.TabIndex = 2;
            this.questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.questionTypeComboBox_SelectedIndexChanged);
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Depth = 0;
            this.questionTextLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.questionTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.questionTextLabel.Location = new System.Drawing.Point(24, 160);
            this.questionTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(95, 19);
            this.questionTextLabel.TabIndex = 3;
            this.questionTextLabel.Text = "Question Text";
            // 
            // questionTextBox
            // 
            this.questionTextBox.AnimateReadOnly = false;
            this.questionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTextBox.Depth = 0;
            this.questionTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.questionTextBox.Hint = "Enter your question here...";
            this.questionTextBox.LeadingIcon = null;
            this.questionTextBox.Location = new System.Drawing.Point(24, 185);
            this.questionTextBox.MaxLength = 500;
            this.questionTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(646, 80);
            this.questionTextBox.TabIndex = 4;
            this.questionTextBox.Text = "";
            this.questionTextBox.TrailingIcon = null;
            // 
            // multipleChoicePanel
            // 
            this.multipleChoicePanel.Controls.Add(this.correctAnswerComboBox);
            this.multipleChoicePanel.Controls.Add(this.correctAnswerLabel);
            this.multipleChoicePanel.Controls.Add(this.option4TextBox);
            this.multipleChoicePanel.Controls.Add(this.option3TextBox);
            this.multipleChoicePanel.Controls.Add(this.option2TextBox);
            this.multipleChoicePanel.Controls.Add(this.option1TextBox);
            this.multipleChoicePanel.Controls.Add(this.optionsLabel);
            this.multipleChoicePanel.Location = new System.Drawing.Point(24, 280);
            this.multipleChoicePanel.Name = "multipleChoicePanel";
            this.multipleChoicePanel.Size = new System.Drawing.Size(646, 180);
            this.multipleChoicePanel.TabIndex = 5;
            this.multipleChoicePanel.Visible = false;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Depth = 0;
            this.optionsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.optionsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.optionsLabel.Location = new System.Drawing.Point(0, 0);
            this.optionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(55, 19);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Options";
            // 
            // option1TextBox
            // 
            this.option1TextBox.AnimateReadOnly = false;
            this.option1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.option1TextBox.Depth = 0;
            this.option1TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.option1TextBox.Hint = "Option 1";
            this.option1TextBox.LeadingIcon = null;
            this.option1TextBox.Location = new System.Drawing.Point(0, 25);
            this.option1TextBox.MaxLength = 200;
            this.option1TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.option1TextBox.Multiline = false;
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(300, 50);
            this.option1TextBox.TabIndex = 1;
            this.option1TextBox.Text = "";
            this.option1TextBox.TrailingIcon = null;
            // 
            // option2TextBox
            // 
            this.option2TextBox.AnimateReadOnly = false;
            this.option2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.option2TextBox.Depth = 0;
            this.option2TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.option2TextBox.Hint = "Option 2";
            this.option2TextBox.LeadingIcon = null;
            this.option2TextBox.Location = new System.Drawing.Point(320, 25);
            this.option2TextBox.MaxLength = 200;
            this.option2TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.option2TextBox.Multiline = false;
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(300, 50);
            this.option2TextBox.TabIndex = 2;
            this.option2TextBox.Text = "";
            this.option2TextBox.TrailingIcon = null;
            // 
            // option3TextBox
            // 
            this.option3TextBox.AnimateReadOnly = false;
            this.option3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.option3TextBox.Depth = 0;
            this.option3TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.option3TextBox.Hint = "Option 3";
            this.option3TextBox.LeadingIcon = null;
            this.option3TextBox.Location = new System.Drawing.Point(0, 85);
            this.option3TextBox.MaxLength = 200;
            this.option3TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.option3TextBox.Multiline = false;
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(300, 50);
            this.option3TextBox.TabIndex = 3;
            this.option3TextBox.Text = "";
            this.option3TextBox.TrailingIcon = null;
            // 
            // option4TextBox
            // 
            this.option4TextBox.AnimateReadOnly = false;
            this.option4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.option4TextBox.Depth = 0;
            this.option4TextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.option4TextBox.Hint = "Option 4";
            this.option4TextBox.LeadingIcon = null;
            this.option4TextBox.Location = new System.Drawing.Point(320, 85);
            this.option4TextBox.MaxLength = 200;
            this.option4TextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.option4TextBox.Multiline = false;
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(300, 50);
            this.option4TextBox.TabIndex = 4;
            this.option4TextBox.Text = "";
            this.option4TextBox.TrailingIcon = null;
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Depth = 0;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.correctAnswerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.correctAnswerLabel.Location = new System.Drawing.Point(0, 145);
            this.correctAnswerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(105, 19);
            this.correctAnswerLabel.TabIndex = 5;
            this.correctAnswerLabel.Text = "Correct Answer";
            // 
            // correctAnswerComboBox
            // 
            this.correctAnswerComboBox.AutoResize = false;
            this.correctAnswerComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.correctAnswerComboBox.Depth = 0;
            this.correctAnswerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.correctAnswerComboBox.DropDownHeight = 174;
            this.correctAnswerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.correctAnswerComboBox.DropDownWidth = 121;
            this.correctAnswerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.correctAnswerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.correctAnswerComboBox.FormattingEnabled = true;
            this.correctAnswerComboBox.IntegralHeight = false;
            this.correctAnswerComboBox.ItemHeight = 43;
            this.correctAnswerComboBox.Location = new System.Drawing.Point(120, 140);
            this.correctAnswerComboBox.MaxDropDownItems = 4;
            this.correctAnswerComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.correctAnswerComboBox.Name = "correctAnswerComboBox";
            this.correctAnswerComboBox.Size = new System.Drawing.Size(180, 49);
            this.correctAnswerComboBox.StartIndex = 0;
            this.correctAnswerComboBox.TabIndex = 6;
            // 
            // openEndedPanel
            // 
            this.openEndedPanel.Controls.Add(this.alternativeAnswersTextBox);
            this.openEndedPanel.Controls.Add(this.alternativeAnswersLabel);
            this.openEndedPanel.Controls.Add(this.correctAnswerTextBox);
            this.openEndedPanel.Controls.Add(this.correctAnswerTextLabel);
            this.openEndedPanel.Location = new System.Drawing.Point(24, 280);
            this.openEndedPanel.Name = "openEndedPanel";
            this.openEndedPanel.Size = new System.Drawing.Size(646, 180);
            this.openEndedPanel.TabIndex = 6;
            this.openEndedPanel.Visible = false;
            // 
            // correctAnswerTextLabel
            // 
            this.correctAnswerTextLabel.AutoSize = true;
            this.correctAnswerTextLabel.Depth = 0;
            this.correctAnswerTextLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.correctAnswerTextLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.correctAnswerTextLabel.Location = new System.Drawing.Point(0, 0);
            this.correctAnswerTextLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.correctAnswerTextLabel.Name = "correctAnswerTextLabel";
            this.correctAnswerTextLabel.Size = new System.Drawing.Size(105, 19);
            this.correctAnswerTextLabel.TabIndex = 0;
            this.correctAnswerTextLabel.Text = "Correct Answer";
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.AnimateReadOnly = false;
            this.correctAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correctAnswerTextBox.Depth = 0;
            this.correctAnswerTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.correctAnswerTextBox.Hint = "Enter the correct answer (1-4 words)";
            this.correctAnswerTextBox.LeadingIcon = null;
            this.correctAnswerTextBox.Location = new System.Drawing.Point(0, 25);
            this.correctAnswerTextBox.MaxLength = 200;
            this.correctAnswerTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.correctAnswerTextBox.Multiline = false;
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.Size = new System.Drawing.Size(620, 50);
            this.correctAnswerTextBox.TabIndex = 1;
            this.correctAnswerTextBox.Text = "";
            this.correctAnswerTextBox.TrailingIcon = null;
            // 
            // alternativeAnswersLabel
            // 
            this.alternativeAnswersLabel.AutoSize = true;
            this.alternativeAnswersLabel.Depth = 0;
            this.alternativeAnswersLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.alternativeAnswersLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.alternativeAnswersLabel.Location = new System.Drawing.Point(0, 85);
            this.alternativeAnswersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.alternativeAnswersLabel.Name = "alternativeAnswersLabel";
            this.alternativeAnswersLabel.Size = new System.Drawing.Size(139, 19);
            this.alternativeAnswersLabel.TabIndex = 2;
            this.alternativeAnswersLabel.Text = "Alternative Answers";
            // 
            // alternativeAnswersTextBox
            // 
            this.alternativeAnswersTextBox.AnimateReadOnly = false;
            this.alternativeAnswersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alternativeAnswersTextBox.Depth = 0;
            this.alternativeAnswersTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.alternativeAnswersTextBox.Hint = "Enter alternative answers separated by commas (optional)";
            this.alternativeAnswersTextBox.LeadingIcon = null;
            this.alternativeAnswersTextBox.Location = new System.Drawing.Point(0, 110);
            this.alternativeAnswersTextBox.MaxLength = 500;
            this.alternativeAnswersTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.alternativeAnswersTextBox.Multiline = false;
            this.alternativeAnswersTextBox.Name = "alternativeAnswersTextBox";
            this.alternativeAnswersTextBox.Size = new System.Drawing.Size(620, 50);
            this.alternativeAnswersTextBox.TabIndex = 3;
            this.alternativeAnswersTextBox.Text = "";
            this.alternativeAnswersTextBox.TrailingIcon = null;
            // 
            // trueFalsePanel
            // 
            this.trueFalsePanel.Controls.Add(this.trueFalseComboBox);
            this.trueFalsePanel.Controls.Add(this.trueFalseLabel);
            this.trueFalsePanel.Location = new System.Drawing.Point(24, 280);
            this.trueFalsePanel.Name = "trueFalsePanel";
            this.trueFalsePanel.Size = new System.Drawing.Size(646, 180);
            this.trueFalsePanel.TabIndex = 7;
            this.trueFalsePanel.Visible = false;
            // 
            // trueFalseLabel
            // 
            this.trueFalseLabel.AutoSize = true;
            this.trueFalseLabel.Depth = 0;
            this.trueFalseLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.trueFalseLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.trueFalseLabel.Location = new System.Drawing.Point(0, 0);
            this.trueFalseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.trueFalseLabel.Name = "trueFalseLabel";
            this.trueFalseLabel.Size = new System.Drawing.Size(105, 19);
            this.trueFalseLabel.TabIndex = 0;
            this.trueFalseLabel.Text = "Correct Answer";
            // 
            // trueFalseComboBox
            // 
            this.trueFalseComboBox.AutoResize = false;
            this.trueFalseComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trueFalseComboBox.Depth = 0;
            this.trueFalseComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.trueFalseComboBox.DropDownHeight = 174;
            this.trueFalseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trueFalseComboBox.DropDownWidth = 121;
            this.trueFalseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.trueFalseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trueFalseComboBox.FormattingEnabled = true;
            this.trueFalseComboBox.IntegralHeight = false;
            this.trueFalseComboBox.ItemHeight = 43;
            this.trueFalseComboBox.Location = new System.Drawing.Point(0, 25);
            this.trueFalseComboBox.MaxDropDownItems = 4;
            this.trueFalseComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.trueFalseComboBox.Name = "trueFalseComboBox";
            this.trueFalseComboBox.Size = new System.Drawing.Size(200, 49);
            this.trueFalseComboBox.StartIndex = 0;
            this.trueFalseComboBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = false;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(470, 480);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "SAVE";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelButton.Depth = 0;
            this.cancelButton.HighEmphasis = false;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(580, 480);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cancelButton.Size = new System.Drawing.Size(90, 36);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.mainPanel);
            this.Name = "QuestionEditForm";
            this.Text = "Edit Question";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.multipleChoicePanel.ResumeLayout(false);
            this.multipleChoicePanel.PerformLayout();
            this.openEndedPanel.ResumeLayout(false);
            this.openEndedPanel.PerformLayout();
            this.trueFalsePanel.ResumeLayout(false);
            this.trueFalsePanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
