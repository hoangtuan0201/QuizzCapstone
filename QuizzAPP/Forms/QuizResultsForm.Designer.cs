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
        private MaterialSkin.Controls.MaterialLabel breakdownLabel;
        private MaterialSkin.Controls.MaterialLabel performanceLabel;
        private MaterialSkin.Controls.MaterialButton closeButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resultsCard = new MaterialSkin.Controls.MaterialCard();
            this.scoreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gradeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.timeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.avgTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.breakdownCard = new MaterialSkin.Controls.MaterialCard();
            this.breakdownTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.breakdownLabel = new MaterialSkin.Controls.MaterialLabel();
            this.performanceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.mainPanel.SuspendLayout();
            this.resultsCard.SuspendLayout();
            this.breakdownCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.performanceLabel);
            this.mainPanel.Controls.Add(this.breakdownCard);
            this.mainPanel.Controls.Add(this.resultsCard);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(24);
            this.mainPanel.Size = new System.Drawing.Size(594, 433);
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
            this.titleLabel.Size = new System.Drawing.Size(147, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Quiz Results";
            // 
            // resultsCard
            // 
            this.resultsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultsCard.Controls.Add(this.avgTimeLabel);
            this.resultsCard.Controls.Add(this.timeLabel);
            this.resultsCard.Controls.Add(this.gradeLabel);
            this.resultsCard.Controls.Add(this.scoreLabel);
            this.resultsCard.Depth = 0;
            this.resultsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultsCard.Location = new System.Drawing.Point(24, 70);
            this.resultsCard.Margin = new System.Windows.Forms.Padding(14);
            this.resultsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsCard.Name = "resultsCard";
            this.resultsCard.Padding = new System.Windows.Forms.Padding(20);
            this.resultsCard.Size = new System.Drawing.Size(546, 140);
            this.resultsCard.TabIndex = 1;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Depth = 0;
            this.scoreLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.scoreLabel.Location = new System.Drawing.Point(20, 20);
            this.scoreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(174, 22);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 8/10 (80.0%)";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Depth = 0;
            this.gradeLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gradeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.gradeLabel.Location = new System.Drawing.Point(20, 50);
            this.gradeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(62, 19);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.Text = "Grade: B";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Depth = 0;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.timeLabel.Location = new System.Drawing.Point(20, 80);
            this.timeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(189, 19);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Total Time: 05:30 (5.5 minutes)";
            // 
            // avgTimeLabel
            // 
            this.avgTimeLabel.AutoSize = true;
            this.avgTimeLabel.Depth = 0;
            this.avgTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.avgTimeLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.avgTimeLabel.Location = new System.Drawing.Point(20, 105);
            this.avgTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.avgTimeLabel.Name = "avgTimeLabel";
            this.avgTimeLabel.Size = new System.Drawing.Size(221, 19);
            this.avgTimeLabel.TabIndex = 3;
            this.avgTimeLabel.Text = "Average Time per Question: 00:33";
            // 
            // breakdownCard
            // 
            this.breakdownCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.breakdownCard.Controls.Add(this.breakdownLabel);
            this.breakdownCard.Controls.Add(this.breakdownTitleLabel);
            this.breakdownCard.Depth = 0;
            this.breakdownCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.breakdownCard.Location = new System.Drawing.Point(24, 230);
            this.breakdownCard.Margin = new System.Windows.Forms.Padding(14);
            this.breakdownCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.breakdownCard.Name = "breakdownCard";
            this.breakdownCard.Padding = new System.Windows.Forms.Padding(20);
            this.breakdownCard.Size = new System.Drawing.Size(546, 100);
            this.breakdownCard.TabIndex = 2;
            // 
            // breakdownTitleLabel
            // 
            this.breakdownTitleLabel.AutoSize = true;
            this.breakdownTitleLabel.Depth = 0;
            this.breakdownTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.breakdownTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.breakdownTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.breakdownTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.breakdownTitleLabel.Name = "breakdownTitleLabel";
            this.breakdownTitleLabel.Size = new System.Drawing.Size(127, 19);
            this.breakdownTitleLabel.TabIndex = 0;
            this.breakdownTitleLabel.Text = "Score Breakdown";
            // 
            // breakdownLabel
            // 
            this.breakdownLabel.AutoSize = true;
            this.breakdownLabel.Depth = 0;
            this.breakdownLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.breakdownLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.breakdownLabel.Location = new System.Drawing.Point(20, 45);
            this.breakdownLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.breakdownLabel.Name = "breakdownLabel";
            this.breakdownLabel.Size = new System.Drawing.Size(340, 19);
            this.breakdownLabel.TabIndex = 1;
            this.breakdownLabel.Text = "Multiple Choice: 3/4 (75%) | Open Ended: 2/3 (67%) | True/False: 3/3 (100%)";
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Depth = 0;
            this.performanceLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.performanceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.performanceLabel.Location = new System.Drawing.Point(24, 350);
            this.performanceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(284, 19);
            this.performanceLabel.TabIndex = 3;
            this.performanceLabel.Text = "Great job! You performed very well on this quiz.";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = false;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeButton.Depth = 0;
            this.closeButton.HighEmphasis = true;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(470, 380);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeButton.Size = new System.Drawing.Size(100, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "CLOSE";
            this.closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeButton.UseAccentColor = true;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // QuizResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.mainPanel);
            this.Name = "QuizResultsForm";
            this.Text = "Quiz Results";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.resultsCard.ResumeLayout(false);
            this.resultsCard.PerformLayout();
            this.breakdownCard.ResumeLayout(false);
            this.breakdownCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
