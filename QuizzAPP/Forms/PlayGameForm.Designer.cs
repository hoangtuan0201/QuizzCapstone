namespace QuizzAPP.Forms
{
    partial class PlayGameForm
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
        private MaterialSkin.Controls.MaterialLabel progressLabel;
        private MaterialSkin.Controls.MaterialCard questionCard;
        private MaterialSkin.Controls.MaterialLabel questionLabel;
        
        // Multiple Choice Controls
        private System.Windows.Forms.Panel multipleChoicePanel;
        private MaterialSkin.Controls.MaterialRadioButton option1RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton option2RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton option3RadioButton;
        private MaterialSkin.Controls.MaterialRadioButton option4RadioButton;
        
        // Open Ended Controls
        private System.Windows.Forms.Panel openEndedPanel;
        private MaterialSkin.Controls.MaterialTextBox answerTextBox;
        
        // True/False Controls
        private System.Windows.Forms.Panel trueFalsePanel;
        private MaterialSkin.Controls.MaterialRadioButton trueRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton falseRadioButton;
        
        private MaterialSkin.Controls.MaterialButton submitButton;
        private MaterialSkin.Controls.MaterialButton exitButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.progressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionCard = new MaterialSkin.Controls.MaterialCard();
            this.questionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.multipleChoicePanel = new System.Windows.Forms.Panel();
            this.option1RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.option2RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.option3RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.option4RadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.openEndedPanel = new System.Windows.Forms.Panel();
            this.answerTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.trueFalsePanel = new System.Windows.Forms.Panel();
            this.trueRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.falseRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.submitButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.mainPanel.SuspendLayout();
            this.questionCard.SuspendLayout();
            this.multipleChoicePanel.SuspendLayout();
            this.openEndedPanel.SuspendLayout();
            this.trueFalsePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.submitButton);
            this.mainPanel.Controls.Add(this.trueFalsePanel);
            this.mainPanel.Controls.Add(this.openEndedPanel);
            this.mainPanel.Controls.Add(this.multipleChoicePanel);
            this.mainPanel.Controls.Add(this.questionCard);
            this.mainPanel.Controls.Add(this.progressLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(24);
            this.mainPanel.Size = new System.Drawing.Size(994, 683);
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
            this.titleLabel.Size = new System.Drawing.Size(186, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Geography Quiz";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Depth = 0;
            this.progressLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.progressLabel.Location = new System.Drawing.Point(24, 65);
            this.progressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(108, 19);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "Question 1 of 10";
            // 
            // questionCard
            // 
            this.questionCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.questionCard.Controls.Add(this.questionLabel);
            this.questionCard.Depth = 0;
            this.questionCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionCard.Location = new System.Drawing.Point(24, 100);
            this.questionCard.Margin = new System.Windows.Forms.Padding(14);
            this.questionCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionCard.Name = "questionCard";
            this.questionCard.Padding = new System.Windows.Forms.Padding(20);
            this.questionCard.Size = new System.Drawing.Size(746, 120);
            this.questionCard.TabIndex = 2;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Depth = 0;
            this.questionLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.questionLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.questionLabel.Location = new System.Drawing.Point(20, 20);
            this.questionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(123, 19);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question text here";
            // 
            // multipleChoicePanel
            // 
            this.multipleChoicePanel.Controls.Add(this.option4RadioButton);
            this.multipleChoicePanel.Controls.Add(this.option3RadioButton);
            this.multipleChoicePanel.Controls.Add(this.option2RadioButton);
            this.multipleChoicePanel.Controls.Add(this.option1RadioButton);
            this.multipleChoicePanel.Location = new System.Drawing.Point(24, 240);
            this.multipleChoicePanel.Name = "multipleChoicePanel";
            this.multipleChoicePanel.Size = new System.Drawing.Size(746, 200);
            this.multipleChoicePanel.TabIndex = 3;
            this.multipleChoicePanel.Visible = false;
            // 
            // option1RadioButton
            // 
            this.option1RadioButton.AutoSize = true;
            this.option1RadioButton.Depth = 0;
            this.option1RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.option1RadioButton.Location = new System.Drawing.Point(20, 20);
            this.option1RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.option1RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option1RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.option1RadioButton.Name = "option1RadioButton";
            this.option1RadioButton.Ripple = true;
            this.option1RadioButton.Size = new System.Drawing.Size(82, 30);
            this.option1RadioButton.TabIndex = 0;
            this.option1RadioButton.TabStop = true;
            this.option1RadioButton.Text = "Option 1";
            this.option1RadioButton.UseVisualStyleBackColor = true;
            // 
            // option2RadioButton
            // 
            this.option2RadioButton.AutoSize = true;
            this.option2RadioButton.Depth = 0;
            this.option2RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.option2RadioButton.Location = new System.Drawing.Point(20, 60);
            this.option2RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.option2RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option2RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.option2RadioButton.Name = "option2RadioButton";
            this.option2RadioButton.Ripple = true;
            this.option2RadioButton.Size = new System.Drawing.Size(82, 30);
            this.option2RadioButton.TabIndex = 1;
            this.option2RadioButton.TabStop = true;
            this.option2RadioButton.Text = "Option 2";
            this.option2RadioButton.UseVisualStyleBackColor = true;
            // 
            // option3RadioButton
            // 
            this.option3RadioButton.AutoSize = true;
            this.option3RadioButton.Depth = 0;
            this.option3RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.option3RadioButton.Location = new System.Drawing.Point(20, 100);
            this.option3RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.option3RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option3RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.option3RadioButton.Name = "option3RadioButton";
            this.option3RadioButton.Ripple = true;
            this.option3RadioButton.Size = new System.Drawing.Size(82, 30);
            this.option3RadioButton.TabIndex = 2;
            this.option3RadioButton.TabStop = true;
            this.option3RadioButton.Text = "Option 3";
            this.option3RadioButton.UseVisualStyleBackColor = true;
            // 
            // option4RadioButton
            // 
            this.option4RadioButton.AutoSize = true;
            this.option4RadioButton.Depth = 0;
            this.option4RadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.option4RadioButton.Location = new System.Drawing.Point(20, 140);
            this.option4RadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.option4RadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.option4RadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.option4RadioButton.Name = "option4RadioButton";
            this.option4RadioButton.Ripple = true;
            this.option4RadioButton.Size = new System.Drawing.Size(82, 30);
            this.option4RadioButton.TabIndex = 3;
            this.option4RadioButton.TabStop = true;
            this.option4RadioButton.Text = "Option 4";
            this.option4RadioButton.UseVisualStyleBackColor = true;
            // 
            // openEndedPanel
            // 
            this.openEndedPanel.Controls.Add(this.answerTextBox);
            this.openEndedPanel.Location = new System.Drawing.Point(24, 240);
            this.openEndedPanel.Name = "openEndedPanel";
            this.openEndedPanel.Size = new System.Drawing.Size(746, 200);
            this.openEndedPanel.TabIndex = 4;
            this.openEndedPanel.Visible = false;
            // 
            // answerTextBox
            // 
            this.answerTextBox.AnimateReadOnly = false;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerTextBox.Depth = 0;
            this.answerTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.answerTextBox.Hint = "Enter your answer here (1-4 words)";
            this.answerTextBox.LeadingIcon = null;
            this.answerTextBox.Location = new System.Drawing.Point(20, 20);
            this.answerTextBox.MaxLength = 200;
            this.answerTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.answerTextBox.Multiline = false;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(700, 50);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "";
            this.answerTextBox.TrailingIcon = null;
            // 
            // trueFalsePanel
            // 
            this.trueFalsePanel.Controls.Add(this.falseRadioButton);
            this.trueFalsePanel.Controls.Add(this.trueRadioButton);
            this.trueFalsePanel.Location = new System.Drawing.Point(24, 240);
            this.trueFalsePanel.Name = "trueFalsePanel";
            this.trueFalsePanel.Size = new System.Drawing.Size(746, 200);
            this.trueFalsePanel.TabIndex = 5;
            this.trueFalsePanel.Visible = false;
            // 
            // trueRadioButton
            // 
            this.trueRadioButton.AutoSize = true;
            this.trueRadioButton.Depth = 0;
            this.trueRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.trueRadioButton.Location = new System.Drawing.Point(20, 20);
            this.trueRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.trueRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.trueRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.trueRadioButton.Name = "trueRadioButton";
            this.trueRadioButton.Ripple = true;
            this.trueRadioButton.Size = new System.Drawing.Size(58, 30);
            this.trueRadioButton.TabIndex = 0;
            this.trueRadioButton.TabStop = true;
            this.trueRadioButton.Text = "True";
            this.trueRadioButton.UseVisualStyleBackColor = true;
            // 
            // falseRadioButton
            // 
            this.falseRadioButton.AutoSize = true;
            this.falseRadioButton.Depth = 0;
            this.falseRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.falseRadioButton.Location = new System.Drawing.Point(20, 60);
            this.falseRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.falseRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.falseRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.falseRadioButton.Name = "falseRadioButton";
            this.falseRadioButton.Ripple = true;
            this.falseRadioButton.Size = new System.Drawing.Size(62, 30);
            this.falseRadioButton.TabIndex = 1;
            this.falseRadioButton.TabStop = true;
            this.falseRadioButton.Text = "False";
            this.falseRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = false;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.submitButton.Depth = 0;
            this.submitButton.HighEmphasis = true;
            this.submitButton.Icon = null;
            this.submitButton.Location = new System.Drawing.Point(570, 460);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.submitButton.Size = new System.Drawing.Size(100, 36);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.submitButton.UseAccentColor = true;
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = false;
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = false;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(680, 460);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(90, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PlayGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.mainPanel);
            this.Name = "PlayGameForm";
            this.Text = "Play Quiz";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.questionCard.ResumeLayout(false);
            this.questionCard.PerformLayout();
            this.multipleChoicePanel.ResumeLayout(false);
            this.multipleChoicePanel.PerformLayout();
            this.openEndedPanel.ResumeLayout(false);
            this.trueFalsePanel.ResumeLayout(false);
            this.trueFalsePanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
