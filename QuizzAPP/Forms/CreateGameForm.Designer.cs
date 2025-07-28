namespace QuizzAPP.Forms
{
    partial class CreateGameForm
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
        private MaterialSkin.Controls.MaterialCard questionsCard;
        private MaterialSkin.Controls.MaterialLabel questionsLabel;
        private System.Windows.Forms.ListBox questionsListBox;
        private MaterialSkin.Controls.MaterialButton addButton;
        private MaterialSkin.Controls.MaterialButton editButton;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialButton clearAllButton;
        private MaterialSkin.Controls.MaterialCard previewCard;
        private MaterialSkin.Controls.MaterialLabel previewTitleLabel;
        private MaterialSkin.Controls.MaterialLabel previewLabel;
        private MaterialSkin.Controls.MaterialButton closeButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            closeButton = new MaterialSkin.Controls.MaterialButton();
            previewCard = new MaterialSkin.Controls.MaterialCard();
            previewLabel = new MaterialSkin.Controls.MaterialLabel();
            previewTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            clearAllButton = new MaterialSkin.Controls.MaterialButton();
            deleteButton = new MaterialSkin.Controls.MaterialButton();
            editButton = new MaterialSkin.Controls.MaterialButton();
            addButton = new MaterialSkin.Controls.MaterialButton();
            questionsCard = new MaterialSkin.Controls.MaterialCard();
            questionsListBox = new System.Windows.Forms.ListBox();
            questionsLabel = new MaterialSkin.Controls.MaterialLabel();
            titleLabel = new MaterialSkin.Controls.MaterialLabel();
            mainPanel.SuspendLayout();
            previewCard.SuspendLayout();
            questionsCard.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(closeButton);
            mainPanel.Controls.Add(previewCard);
            mainPanel.Controls.Add(clearAllButton);
            mainPanel.Controls.Add(deleteButton);
            mainPanel.Controls.Add(editButton);
            mainPanel.Controls.Add(addButton);
            mainPanel.Controls.Add(questionsCard);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(4, 74);
            mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(28);
            mainPanel.Size = new System.Drawing.Size(1042, 731);
            mainPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = false;
            closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            closeButton.Depth = 0;
            closeButton.HighEmphasis = true;
            closeButton.Icon = null;
            closeButton.Location = new System.Drawing.Point(898, 565);
            closeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            closeButton.Name = "closeButton";
            closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            closeButton.Size = new System.Drawing.Size(117, 42);
            closeButton.TabIndex = 7;
            closeButton.Text = "CLOSE";
            closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            closeButton.UseAccentColor = true;
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // previewCard
            // 
            previewCard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            previewCard.Controls.Add(previewLabel);
            previewCard.Controls.Add(previewTitleLabel);
            previewCard.Depth = 0;
            previewCard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            previewCard.Location = new System.Drawing.Point(541, 81);
            previewCard.Margin = new System.Windows.Forms.Padding(16);
            previewCard.MouseState = MaterialSkin.MouseState.HOVER;
            previewCard.Name = "previewCard";
            previewCard.Padding = new System.Windows.Forms.Padding(19, 18, 19, 18);
            previewCard.Size = new System.Drawing.Size(700, 462);
            previewCard.TabIndex = 6;
            // 
            // previewLabel
            // 
            previewLabel.AutoSize = false;
            previewLabel.Depth = 0;
            previewLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            previewLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            previewLabel.Location = new System.Drawing.Point(19, 52);
            previewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            previewLabel.MouseState = MaterialSkin.MouseState.HOVER;
            previewLabel.Name = "previewLabel";
            previewLabel.Size = new System.Drawing.Size(249, 249);
            previewLabel.TabIndex = 1;
            previewLabel.Text = "Select a question to preview it here.";
            // 
            // previewTitleLabel
            // 
            previewTitleLabel.AutoSize = true;
            previewTitleLabel.Depth = 0;
            previewTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            previewTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            previewTitleLabel.Location = new System.Drawing.Point(19, 18);
            previewTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            previewTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            previewTitleLabel.Name = "previewTitleLabel";
            previewTitleLabel.Size = new System.Drawing.Size(56, 19);
            previewTitleLabel.TabIndex = 0;
            previewTitleLabel.Text = "Preview";
            // 
            // clearAllButton
            // 
            clearAllButton.AutoSize = false;
            clearAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            clearAllButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            clearAllButton.Depth = 0;
            clearAllButton.HighEmphasis = false;
            clearAllButton.Icon = null;
            clearAllButton.Location = new System.Drawing.Point(413, 565);
            clearAllButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            clearAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            clearAllButton.Name = "clearAllButton";
            clearAllButton.NoAccentTextColor = System.Drawing.Color.Empty;
            clearAllButton.Size = new System.Drawing.Size(105, 42);
            clearAllButton.TabIndex = 5;
            clearAllButton.Text = "CLEAR ALL";
            clearAllButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            clearAllButton.UseAccentColor = false;
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = false;
            deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteButton.Depth = 0;
            deleteButton.HighEmphasis = false;
            deleteButton.Icon = null;
            deleteButton.Location = new System.Drawing.Point(285, 565);
            deleteButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            deleteButton.Name = "deleteButton";
            deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            deleteButton.Size = new System.Drawing.Size(117, 42);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "DELETE";
            deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            deleteButton.UseAccentColor = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = false;
            editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            editButton.Depth = 0;
            editButton.HighEmphasis = true;
            editButton.Icon = null;
            editButton.Location = new System.Drawing.Point(156, 565);
            editButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            editButton.MouseState = MaterialSkin.MouseState.HOVER;
            editButton.Name = "editButton";
            editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            editButton.Size = new System.Drawing.Size(117, 42);
            editButton.TabIndex = 3;
            editButton.Text = "EDIT";
            editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            editButton.UseAccentColor = false;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = false;
            addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addButton.Depth = 0;
            addButton.HighEmphasis = true;
            addButton.Icon = null;
            addButton.Location = new System.Drawing.Point(28, 565);
            addButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            addButton.MouseState = MaterialSkin.MouseState.HOVER;
            addButton.Name = "addButton";
            addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            addButton.Size = new System.Drawing.Size(117, 42);
            addButton.TabIndex = 2;
            addButton.Text = "ADD";
            addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addButton.UseAccentColor = false;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // questionsCard
            // 
            questionsCard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)255)));
            questionsCard.Controls.Add(questionsListBox);
            questionsCard.Controls.Add(questionsLabel);
            questionsCard.Depth = 0;
            questionsCard.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)222)), ((int)((byte)0)), ((int)((byte)0)), ((int)((byte)0)));
            questionsCard.Location = new System.Drawing.Point(28, 81);
            questionsCard.Margin = new System.Windows.Forms.Padding(16);
            questionsCard.MouseState = MaterialSkin.MouseState.HOVER;
            questionsCard.Name = "questionsCard";
            questionsCard.Padding = new System.Windows.Forms.Padding(19, 18, 19, 18);
            questionsCard.Size = new System.Drawing.Size(490, 462);
            questionsCard.TabIndex = 1;
            // 
            // questionsListBox
            // 
            questionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            questionsListBox.FormattingEnabled = true;
            questionsListBox.Location = new System.Drawing.Point(19, 52);
            questionsListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            questionsListBox.Name = "questionsListBox";
            questionsListBox.Size = new System.Drawing.Size(452, 372);
            questionsListBox.TabIndex = 1;
            questionsListBox.SelectedIndexChanged += questionsListBox_SelectedIndexChanged;
            questionsListBox.DoubleClick += questionsListBox_DoubleClick;
            // 
            // questionsLabel
            // 
            questionsLabel.AutoSize = true;
            questionsLabel.Depth = 0;
            questionsLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            questionsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            questionsLabel.Location = new System.Drawing.Point(19, 18);
            questionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            questionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            questionsLabel.Name = "questionsLabel";
            questionsLabel.Size = new System.Drawing.Size(72, 19);
            questionsLabel.TabIndex = 0;
            questionsLabel.Text = "Questions";
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
            titleLabel.Size = new System.Drawing.Size(255, 29);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Manage Quiz Questions";
            // 
            // CreateGameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1050, 808);
            Controls.Add(mainPanel);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Padding = new System.Windows.Forms.Padding(4, 74, 4, 3);
            Text = "Create Quiz Questions";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            previewCard.ResumeLayout(false);
            previewCard.PerformLayout();
            questionsCard.ResumeLayout(false);
            questionsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
