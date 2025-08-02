namespace QuizzAPP.Forms
{
    partial class QuizResultsForm
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
        private MaterialSkin.Controls.MaterialCard resultsCard;
        private MaterialSkin.Controls.MaterialLabel scoreLabel;
        private MaterialSkin.Controls.MaterialLabel gradeLabel;
        private MaterialSkin.Controls.MaterialLabel timeLabel;
        private MaterialSkin.Controls.MaterialLabel avgTimeLabel;
        private MaterialSkin.Controls.MaterialCard breakdownCard;
        private MaterialSkin.Controls.MaterialLabel breakdownTitleLabel;
        private System.Windows.Forms.RichTextBox detailedResultsTextBox;
        private MaterialSkin.Controls.MaterialLabel performanceLabel;
        private MaterialSkin.Controls.MaterialButton closeButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            performanceLabel = new MaterialSkin.Controls.MaterialLabel();
            breakdownCard = new MaterialSkin.Controls.MaterialCard();
            closeButton = new MaterialSkin.Controls.MaterialButton();
            detailedResultsTextBox = new System.Windows.Forms.RichTextBox();
            breakdownTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            resultsCard = new MaterialSkin.Controls.MaterialCard();
            avgTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            timeLabel = new MaterialSkin.Controls.MaterialLabel();
            gradeLabel = new MaterialSkin.Controls.MaterialLabel();
            scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            titleLabel = new MaterialSkin.Controls.MaterialLabel();
            mainPanel.SuspendLayout();
            breakdownCard.SuspendLayout();
            resultsCard.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(performanceLabel);
            mainPanel.Controls.Add(breakdownCard);
            mainPanel.Controls.Add(resultsCard);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(4, 74);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(28);
            mainPanel.Size = new System.Drawing.Size(728, 611);
            mainPanel.TabIndex = 0;
            // 
            // performanceLabel
            // 
            performanceLabel.Depth = 0;
            performanceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            performanceLabel.Location = new System.Drawing.Point(0, 0);
            performanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            performanceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            performanceLabel.Name = "performanceLabel";
            performanceLabel.Size = new System.Drawing.Size(117, 27);
            performanceLabel.TabIndex = 5;
            // 
            // breakdownCard
            // 
            breakdownCard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            breakdownCard.Controls.Add(closeButton);
            breakdownCard.Controls.Add(detailedResultsTextBox);
            breakdownCard.Controls.Add(breakdownTitleLabel);
            breakdownCard.Depth = 0;
            breakdownCard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            breakdownCard.Location = new System.Drawing.Point(28, 265);
            breakdownCard.Margin = new System.Windows.Forms.Padding(16);
            breakdownCard.MouseState = MaterialSkin.MouseState.HOVER;
            breakdownCard.Name = "breakdownCard";
            breakdownCard.Padding = new System.Windows.Forms.Padding(23);
            breakdownCard.Size = new System.Drawing.Size(637, 329);
            breakdownCard.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.AutoSize = false;
            closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            closeButton.Depth = 0;
            closeButton.HighEmphasis = true;
            closeButton.Icon = null;
            closeButton.Location = new System.Drawing.Point(511, 275);
            closeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            closeButton.Name = "closeButton";
            closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            closeButton.Size = new System.Drawing.Size(117, 42);
            closeButton.TabIndex = 4;
            closeButton.Text = "CLOSE";
            closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            closeButton.UseAccentColor = true;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // detailedResultsTextBox
            //
            detailedResultsTextBox.BackColor = System.Drawing.Color.White;
            detailedResultsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            detailedResultsTextBox.Font = new System.Drawing.Font("Roboto", 10F);
            detailedResultsTextBox.Location = new System.Drawing.Point(23, 52);
            detailedResultsTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            detailedResultsTextBox.Name = "detailedResultsTextBox";
            detailedResultsTextBox.ReadOnly = true;
            detailedResultsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            detailedResultsTextBox.Size = new System.Drawing.Size(590, 213);
            detailedResultsTextBox.TabIndex = 1;
            detailedResultsTextBox.Text = "Detailed results will appear here...";
            // 
            // breakdownTitleLabel
            // 
            breakdownTitleLabel.AutoSize = true;
            breakdownTitleLabel.Depth = 0;
            breakdownTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            breakdownTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            breakdownTitleLabel.Location = new System.Drawing.Point(23, 23);
            breakdownTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            breakdownTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            breakdownTitleLabel.Name = "breakdownTitleLabel";
            breakdownTitleLabel.Size = new System.Drawing.Size(115, 19);
            breakdownTitleLabel.TabIndex = 0;
            breakdownTitleLabel.Text = "Detailed Results";
            // 
            // resultsCard
            // 
            resultsCard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            resultsCard.Controls.Add(avgTimeLabel);
            resultsCard.Controls.Add(timeLabel);
            resultsCard.Controls.Add(gradeLabel);
            resultsCard.Controls.Add(scoreLabel);
            resultsCard.Depth = 0;
            resultsCard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            resultsCard.Location = new System.Drawing.Point(28, 81);
            resultsCard.Margin = new System.Windows.Forms.Padding(16);
            resultsCard.MouseState = MaterialSkin.MouseState.HOVER;
            resultsCard.Name = "resultsCard";
            resultsCard.Padding = new System.Windows.Forms.Padding(23);
            resultsCard.Size = new System.Drawing.Size(637, 162);
            resultsCard.TabIndex = 1;
            // 
            // avgTimeLabel
            // 
            avgTimeLabel.Depth = 0;
            avgTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            avgTimeLabel.Location = new System.Drawing.Point(0, 0);
            avgTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            avgTimeLabel.Name = "avgTimeLabel";
            avgTimeLabel.Size = new System.Drawing.Size(100, 23);
            avgTimeLabel.TabIndex = 0;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Depth = 0;
            timeLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            timeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            timeLabel.Location = new System.Drawing.Point(23, 92);
            timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(224, 19);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "Total Time: 05:30 (5.5 minutes)";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Depth = 0;
            gradeLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            gradeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            gradeLabel.Location = new System.Drawing.Point(23, 58);
            gradeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gradeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(61, 19);
            gradeLabel.TabIndex = 1;
            gradeLabel.Text = "Grade: B";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Depth = 0;
            scoreLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            scoreLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            scoreLabel.Location = new System.Drawing.Point(23, 23);
            scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            scoreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(176, 24);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "Score: 8/10 (80.0%)";
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
            titleLabel.Size = new System.Drawing.Size(134, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Quiz Results";
            // 
            // QuizResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(736, 688);
            Controls.Add(mainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Text = "Quiz Results";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            breakdownCard.ResumeLayout(false);
            breakdownCard.PerformLayout();
            resultsCard.ResumeLayout(false);
            resultsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
