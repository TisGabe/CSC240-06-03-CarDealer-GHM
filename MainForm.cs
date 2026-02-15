using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<string, CarModel> _models = new()
        {
            ["Falcon LX"] = new CarModel(
                name: "Falcon LX",
                trim: "2.0T AWD",
                msrp: 28995m,
                mpgCity: 24,
                mpgHwy: 32,
                highlights: new[] { "All-Wheel Drive", "8\" Touchscreen", "Adaptive Cruise Control" }
            ),
            ["Comet Hybrid"] = new CarModel(
                name: "Comet Hybrid",
                trim: "1.8 Hybrid FWD",
                msrp: 27450m,
                mpgCity: 49,
                mpgHwy: 52,
                highlights: new[] { "49/52 MPG", "Wireless CarPlay/Android Auto", "Lane Keep Assist" }
            ),
            ["Atlas Sport"] = new CarModel(
                name: "Atlas Sport",
                trim: "V6 RWD",
                msrp: 36990m,
                mpgCity: 20,
                mpgHwy: 27,
                highlights: new[] { "V6 Performance", "Sport Suspension", "Premium Audio" }
            ),
        };

        private readonly Color _defaultBackColor;

        public MainForm()
        {
            InitializeComponent();
            _defaultBackColor = this.BackColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            modelsListBox.Items.Clear();
            foreach (var name in _models.Keys)
            {
                modelsListBox.Items.Add(name);
            }

            continueButton.Enabled = false;
            statusLabel.Text = "Select a model to view details.";
        }

        private void modelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            continueButton.Enabled = modelsListBox.SelectedIndex >= 0;

            if (modelsListBox.SelectedItem is string selected)
            {
                statusLabel.Text = $"Selected: {selected}. Click Continue to view details.";
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (modelsListBox.SelectedItem is not string selected || !_models.ContainsKey(selected))
            {
                MessageBox.Show("Please select a car model.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var model = _models[selected];

            using var details = new DetailsForm(model);
            details.StartPosition = FormStartPosition.CenterParent;
            details.ShowDialog(this);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            modelsListBox.ClearSelected();
            continueButton.Enabled = false;
            statusLabel.Text = "Select a model to view details.";
            this.BackColor = _defaultBackColor;
            modelsListBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
