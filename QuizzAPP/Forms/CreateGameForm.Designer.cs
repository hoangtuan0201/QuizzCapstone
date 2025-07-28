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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionsCard = new MaterialSkin.Controls.MaterialCard();
            this.questionsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.editButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.clearAllButton = new MaterialSkin.Controls.MaterialButton();
            this.previewCard = new MaterialSkin.Controls.MaterialCard();
            this.previewTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.previewLabel = new MaterialSkin.Controls.MaterialLabel();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.mainPanel.SuspendLayout();
            this.questionsCard.SuspendLayout();
            this.previewCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.previewCard);
            this.mainPanel.Controls.Add(this.clearAllButton);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.editButton);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Controls.Add(this.questionsCard);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(24);
            this.mainPanel.Size = new System.Drawing.Size(894, 633);
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
            this.titleLabel.Size = new System.Drawing.Size(264, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Manage Quiz Questions";
            // 
            // questionsCard
            // 
            this.questionsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.questionsCard.Controls.Add(this.questionsListBox);
            this.questionsCard.Controls.Add(this.questionsLabel);
            this.questionsCard.Depth = 0;
            this.questionsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionsCard.Location = new System.Drawing.Point(24, 70);
            this.questionsCard.Margin = new System.Windows.Forms.Padding(14);
            this.questionsCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionsCard.Name = "questionsCard";
            this.questionsCard.Padding = new System.Windows.Forms.Padding(16);
            this.questionsCard.Size = new System.Drawing.Size(420, 400);
            this.questionsCard.TabIndex = 1;
            // 
            // questionsLabel
            // 
            this.questionsLabel.AutoSize = true;
            this.questionsLabel.Depth = 0;
            this.questionsLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.questionsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.questionsLabel.Location = new System.Drawing.Point(16, 16);
            this.questionsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionsLabel.Name = "questionsLabel";
            this.questionsLabel.Size = new System.Drawing.Size(73, 19);
            this.questionsLabel.TabIndex = 0;
            this.questionsLabel.Text = "Questions";
            // 
            // questionsListBox
            // 
            this.questionsListBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.questionsListBox.FormattingEnabled = true;
            this.questionsListBox.ItemHeight = 17;
            this.questionsListBox.Location = new System.Drawing.Point(16, 45);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(388, 327);
            this.questionsListBox.TabIndex = 1;
            this.questionsListBox.SelectedIndexChanged += new System.EventHandler(this.questionsListBox_SelectedIndexChanged);
            this.questionsListBox.DoubleClick += new System.EventHandler(this.questionsListBox_DoubleClick);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(24, 490);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(100, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "ADD";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = false;
            this.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editButton.Depth = 0;
            this.editButton.HighEmphasis = true;
            this.editButton.Icon = null;
            this.editButton.Location = new System.Drawing.Point(134, 490);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editButton.Name = "editButton";
            this.editButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editButton.Size = new System.Drawing.Size(100, 36);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "EDIT";
            this.editButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.editButton.UseAccentColor = false;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = false;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteButton.Depth = 0;
            this.deleteButton.HighEmphasis = false;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(244, 490);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteButton.Size = new System.Drawing.Size(100, 36);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.AutoSize = false;
            this.clearAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearAllButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearAllButton.Depth = 0;
            this.clearAllButton.HighEmphasis = false;
            this.clearAllButton.Icon = null;
            this.clearAllButton.Location = new System.Drawing.Point(354, 490);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearAllButton.Size = new System.Drawing.Size(90, 36);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "CLEAR ALL";
            this.clearAllButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.clearAllButton.UseAccentColor = false;
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // previewCard
            // 
            this.previewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewCard.Controls.Add(this.previewLabel);
            this.previewCard.Controls.Add(this.previewTitleLabel);
            this.previewCard.Depth = 0;
            this.previewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.previewCard.Location = new System.Drawing.Point(464, 70);
            this.previewCard.Margin = new System.Windows.Forms.Padding(14);
            this.previewCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewCard.Name = "previewCard";
            this.previewCard.Padding = new System.Windows.Forms.Padding(16);
            this.previewCard.Size = new System.Drawing.Size(600, 400);
            this.previewCard.TabIndex = 6;
            // 
            // previewTitleLabel
            // 
            this.previewTitleLabel.AutoSize = true;
            this.previewTitleLabel.Depth = 0;
            this.previewTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.previewTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.previewTitleLabel.Location = new System.Drawing.Point(16, 16);
            this.previewTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewTitleLabel.Name = "previewTitleLabel";
            this.previewTitleLabel.Size = new System.Drawing.Size(58, 19);
            this.previewTitleLabel.TabIndex = 0;
            this.previewTitleLabel.Text = "Preview";
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.Depth = 0;
            this.previewLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.previewLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.previewLabel.Location = new System.Drawing.Point(16, 45);
            this.previewLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(234, 19);
            this.previewLabel.TabIndex = 1;
            this.previewLabel.Text = "Select a question to preview it here.";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = false;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.closeButton.Depth = 0;
            this.closeButton.HighEmphasis = true;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(770, 490);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.closeButton.Size = new System.Drawing.Size(100, 36);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "CLOSE";
            this.closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeButton.UseAccentColor = true;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // CreateGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.mainPanel);
            this.Name = "CreateGameForm";
            this.Text = "Create Quiz Questions";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.questionsCard.ResumeLayout(false);
            this.questionsCard.PerformLayout();
            this.previewCard.ResumeLayout(false);
            this.previewCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
