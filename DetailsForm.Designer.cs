namespace CarDealer
{
    partial class DetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.Label trimLabel;
        private System.Windows.Forms.Label msrpLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label msrpValueLabel;
        private System.Windows.Forms.Label mpgValueLabel;
        private System.Windows.Forms.ListBox highlightsListBox;
        private System.Windows.Forms.Label highlightsLabel;
        private System.Windows.Forms.Button backButton;

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
            this.accentPanel = new System.Windows.Forms.Panel();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.trimLabel = new System.Windows.Forms.Label();
            this.msrpLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.msrpValueLabel = new System.Windows.Forms.Label();
            this.mpgValueLabel = new System.Windows.Forms.Label();
            this.highlightsListBox = new System.Windows.Forms.ListBox();
            this.highlightsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accentPanel
            // 
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accentPanel.Location = new System.Drawing.Point(0, 0);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(12, 360);
            this.accentPanel.TabIndex = 0;
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.modelNameLabel.Location = new System.Drawing.Point(30, 20);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(167, 37);
            this.modelNameLabel.TabIndex = 1;
            this.modelNameLabel.Text = "ModelName";
            // 
            // trimLabel
            // 
            this.trimLabel.AutoSize = true;
            this.trimLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.trimLabel.ForeColor = System.Drawing.Color.DimGray;
            this.trimLabel.Location = new System.Drawing.Point(34, 65);
            this.trimLabel.Name = "trimLabel";
            this.trimLabel.Size = new System.Drawing.Size(52, 21);
            this.trimLabel.TabIndex = 2;
            this.trimLabel.Text = "Trim...";
            // 
            // msrpLabel
            // 
            this.msrpLabel.AutoSize = true;
            this.msrpLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.msrpLabel.Location = new System.Drawing.Point(34, 110);
            this.msrpLabel.Name = "msrpLabel";
            this.msrpLabel.Size = new System.Drawing.Size(55, 20);
            this.msrpLabel.TabIndex = 3;
            this.msrpLabel.Text = "MSRP:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mpgLabel.Location = new System.Drawing.Point(34, 145);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(45, 20);
            this.mpgLabel.TabIndex = 4;
            this.mpgLabel.Text = "MPG:";
            // 
            // msrpValueLabel
            // 
            this.msrpValueLabel.AutoSize = true;
            this.msrpValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.msrpValueLabel.Location = new System.Drawing.Point(110, 110);
            this.msrpValueLabel.Name = "msrpValueLabel";
            this.msrpValueLabel.Size = new System.Drawing.Size(47, 20);
            this.msrpValueLabel.TabIndex = 5;
            this.msrpValueLabel.Text = "$0.00";
            // 
            // mpgValueLabel
            // 
            this.mpgValueLabel.AutoSize = true;
            this.mpgValueLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mpgValueLabel.Location = new System.Drawing.Point(110, 145);
            this.mpgValueLabel.Name = "mpgValueLabel";
            this.mpgValueLabel.Size = new System.Drawing.Size(101, 20);
            this.mpgValueLabel.TabIndex = 6;
            this.mpgValueLabel.Text = "0 city / 0 hwy";
            // 
            // highlightsListBox
            // 
            this.highlightsListBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.highlightsListBox.FormattingEnabled = true;
            this.highlightsListBox.ItemHeight = 20;
            this.highlightsListBox.Location = new System.Drawing.Point(38, 220);
            this.highlightsListBox.Name = "highlightsListBox";
            this.highlightsListBox.Size = new System.Drawing.Size(520, 84);
            this.highlightsListBox.TabIndex = 7;
            // 
            // highlightsLabel
            // 
            this.highlightsLabel.AutoSize = true;
            this.highlightsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.highlightsLabel.Location = new System.Drawing.Point(34, 190);
            this.highlightsLabel.Name = "highlightsLabel";
            this.highlightsLabel.Size = new System.Drawing.Size(83, 20);
            this.highlightsLabel.TabIndex = 8;
            this.highlightsLabel.Text = "Highlights";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backButton.Location = new System.Drawing.Point(430, 320);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 32);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.highlightsLabel);
            this.Controls.Add(this.highlightsListBox);
            this.Controls.Add(this.mpgValueLabel);
            this.Controls.Add(this.msrpValueLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.msrpLabel);
            this.Controls.Add(this.trimLabel);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.accentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsForm";
            this.Text = "Model Details";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
