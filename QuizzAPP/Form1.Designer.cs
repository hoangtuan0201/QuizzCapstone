namespace QuizzAPP;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    private MaterialSkin.Controls.MaterialLabel subtitleLabel;
    private MaterialSkin.Controls.MaterialButton createGameButton;
    private MaterialSkin.Controls.MaterialButton playGameButton;
    private MaterialSkin.Controls.MaterialButton exitButton;
    private MaterialSkin.Controls.MaterialButton loadSampleButton;
    private MaterialSkin.Controls.MaterialCard statsCard;
    private MaterialSkin.Controls.MaterialLabel statsLabel;

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.mainPanel = new System.Windows.Forms.Panel();
        this.titleLabel = new MaterialSkin.Controls.MaterialLabel();
        this.subtitleLabel = new MaterialSkin.Controls.MaterialLabel();
        this.createGameButton = new MaterialSkin.Controls.MaterialButton();
        this.playGameButton = new MaterialSkin.Controls.MaterialButton();
        this.exitButton = new MaterialSkin.Controls.MaterialButton();
        this.loadSampleButton = new MaterialSkin.Controls.MaterialButton();
        this.statsCard = new MaterialSkin.Controls.MaterialCard();
        this.statsLabel = new MaterialSkin.Controls.MaterialLabel();
        this.mainPanel.SuspendLayout();
        this.statsCard.SuspendLayout();
        this.SuspendLayout();
        //
        // mainPanel
        //
        this.mainPanel.Controls.Add(this.exitButton);
        this.mainPanel.Controls.Add(this.loadSampleButton);
        this.mainPanel.Controls.Add(this.playGameButton);
        this.mainPanel.Controls.Add(this.createGameButton);
        this.mainPanel.Controls.Add(this.statsCard);
        this.mainPanel.Controls.Add(this.subtitleLabel);
        this.mainPanel.Controls.Add(this.titleLabel);
        this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.mainPanel.Location = new System.Drawing.Point(3, 64);
        this.mainPanel.Name = "mainPanel";
        this.mainPanel.Padding = new System.Windows.Forms.Padding(50);
        this.mainPanel.Size = new System.Drawing.Size(994, 633);
        this.mainPanel.TabIndex = 0;
        //
        // titleLabel
        //
        this.titleLabel.AutoSize = true;
        this.titleLabel.Depth = 0;
        this.titleLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.titleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
        this.titleLabel.Location = new System.Drawing.Point(50, 80);
        this.titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
        this.titleLabel.Name = "titleLabel";
        this.titleLabel.Size = new System.Drawing.Size(394, 41);
        this.titleLabel.TabIndex = 0;
        this.titleLabel.Text = "Geography Quiz Game";
        //
        // subtitleLabel
        //
        this.subtitleLabel.AutoSize = true;
        this.subtitleLabel.Depth = 0;
        this.subtitleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.subtitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        this.subtitleLabel.Location = new System.Drawing.Point(50, 130);
        this.subtitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
        this.subtitleLabel.Name = "subtitleLabel";
        this.subtitleLabel.Size = new System.Drawing.Size(387, 19);
        this.subtitleLabel.TabIndex = 1;
        this.subtitleLabel.Text = "Test your knowledge of world geography with this interactive quiz";
        //
        // createGameButton
        //
        this.createGameButton.AutoSize = false;
        this.createGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.createGameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.createGameButton.Depth = 0;
        this.createGameButton.HighEmphasis = true;
        this.createGameButton.Icon = null;
        this.createGameButton.Location = new System.Drawing.Point(50, 280);
        this.createGameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.createGameButton.MouseState = MaterialSkin.MouseState.HOVER;
        this.createGameButton.Name = "createGameButton";
        this.createGameButton.NoAccentTextColor = System.Drawing.Color.Empty;
        this.createGameButton.Size = new System.Drawing.Size(200, 50);
        this.createGameButton.TabIndex = 2;
        this.createGameButton.Text = "CREATE GAME";
        this.createGameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.createGameButton.UseAccentColor = false;
        this.createGameButton.UseVisualStyleBackColor = true;
        this.createGameButton.Click += new System.EventHandler(this.createGameButton_Click);
        //
        // playGameButton
        //
        this.playGameButton.AutoSize = false;
        this.playGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.playGameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.playGameButton.Depth = 0;
        this.playGameButton.HighEmphasis = true;
        this.playGameButton.Icon = null;
        this.playGameButton.Location = new System.Drawing.Point(270, 280);
        this.playGameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.playGameButton.MouseState = MaterialSkin.MouseState.HOVER;
        this.playGameButton.Name = "playGameButton";
        this.playGameButton.NoAccentTextColor = System.Drawing.Color.Empty;
        this.playGameButton.Size = new System.Drawing.Size(200, 50);
        this.playGameButton.TabIndex = 3;
        this.playGameButton.Text = "PLAY GAME";
        this.playGameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        this.playGameButton.UseAccentColor = true;
        this.playGameButton.UseVisualStyleBackColor = true;
        this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
        //
        // loadSampleButton
        //
        this.loadSampleButton.AutoSize = false;
        this.loadSampleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.loadSampleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.loadSampleButton.Depth = 0;
        this.loadSampleButton.HighEmphasis = false;
        this.loadSampleButton.Icon = null;
        this.loadSampleButton.Location = new System.Drawing.Point(50, 350);
        this.loadSampleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.loadSampleButton.MouseState = MaterialSkin.MouseState.HOVER;
        this.loadSampleButton.Name = "loadSampleButton";
        this.loadSampleButton.NoAccentTextColor = System.Drawing.Color.Empty;
        this.loadSampleButton.Size = new System.Drawing.Size(200, 36);
        this.loadSampleButton.TabIndex = 6;
        this.loadSampleButton.Text = "LOAD SAMPLE QUIZ";
        this.loadSampleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
        this.loadSampleButton.UseAccentColor = false;
        this.loadSampleButton.UseVisualStyleBackColor = true;
        this.loadSampleButton.Click += new System.EventHandler(this.loadSampleButton_Click);
        //
        // exitButton
        //
        this.exitButton.AutoSize = false;
        this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        this.exitButton.Depth = 0;
        this.exitButton.HighEmphasis = false;
        this.exitButton.Icon = null;
        this.exitButton.Location = new System.Drawing.Point(490, 280);
        this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
        this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
        this.exitButton.Name = "exitButton";
        this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
        this.exitButton.Size = new System.Drawing.Size(120, 50);
        this.exitButton.TabIndex = 4;
        this.exitButton.Text = "EXIT";
        this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
        this.exitButton.UseAccentColor = false;
        this.exitButton.UseVisualStyleBackColor = true;
        this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
        //
        // statsCard
        //
        this.statsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.statsCard.Controls.Add(this.statsLabel);
        this.statsCard.Depth = 0;
        this.statsCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.statsCard.Location = new System.Drawing.Point(50, 180);
        this.statsCard.Margin = new System.Windows.Forms.Padding(14);
        this.statsCard.MouseState = MaterialSkin.MouseState.HOVER;
        this.statsCard.Name = "statsCard";
        this.statsCard.Padding = new System.Windows.Forms.Padding(20);
        this.statsCard.Size = new System.Drawing.Size(560, 80);
        this.statsCard.TabIndex = 5;
        //
        // statsLabel
        //
        this.statsLabel.AutoSize = true;
        this.statsLabel.Depth = 0;
        this.statsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        this.statsLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
        this.statsLabel.Location = new System.Drawing.Point(20, 30);
        this.statsLabel.MouseState = MaterialSkin.MouseState.HOVER;
        this.statsLabel.Name = "statsLabel";
        this.statsLabel.Size = new System.Drawing.Size(155, 19);
        this.statsLabel.TabIndex = 0;
        this.statsLabel.Text = "No questions available";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1000, 700);
        this.Controls.Add(this.mainPanel);
        this.Name = "Form1";
        this.Text = "Geography Quiz Game";
        this.mainPanel.ResumeLayout(false);
        this.mainPanel.PerformLayout();
        this.statsCard.ResumeLayout(false);
        this.statsCard.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}