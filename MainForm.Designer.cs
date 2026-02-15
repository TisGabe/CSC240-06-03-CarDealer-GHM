namespace CarDealer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.ListBox modelsListBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel headerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modelsListBox = new System.Windows.Forms.ListBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(640, 90);
            this.headerPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.subtitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.subtitleLabel.Location = new System.Drawing.Point(22, 52);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(403, 20);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "Choose a model to see features, MSRP, and MPG ratings.";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(18, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(251, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CarDealer Catalog";
            // 
            // modelsListBox
            // 
            this.modelsListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.modelsListBox.FormattingEnabled = true;
            this.modelsListBox.ItemHeight = 21;
            this.modelsListBox.Location = new System.Drawing.Point(25, 120);
            this.modelsListBox.Name = "modelsListBox";
            this.modelsListBox.Size = new System.Drawing.Size(350, 151);
            this.modelsListBox.TabIndex = 1;
            this.modelsListBox.SelectedIndexChanged += new System.EventHandler(this.modelsListBox_SelectedIndexChanged);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.continueButton.Location = new System.Drawing.Point(410, 120);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(190, 42);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.resetButton.Location = new System.Drawing.Point(410, 175);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(190, 42);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exitButton.Location = new System.Drawing.Point(410, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(190, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusLabel.Location = new System.Drawing.Point(25, 290);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(205, 19);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Select a model to view details.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(640, 340);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.modelsListBox);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CarDealer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
