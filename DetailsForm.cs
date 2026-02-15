using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class DetailsForm : Form
    {
        private readonly CarModel _model;

        public DetailsForm(CarModel model)
        {
            _model = model;
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            modelNameLabel.Text = _model.Name;
            trimLabel.Text = _model.Trim;
            msrpValueLabel.Text = _model.MSRP.ToString("C");
            mpgValueLabel.Text = $"{_model.MpgCity} city / {_model.MpgHwy} hwy";

            highlightsListBox.Items.Clear();
            foreach (var h in _model.Highlights)
            {
                highlightsListBox.Items.Add("• " + h);
            }

            accentPanel.BackColor = _model.Name switch
            {
                "Falcon LX" => Color.FromArgb(37, 99, 235),
                "Comet Hybrid" => Color.FromArgb(16, 185, 129),
                "Atlas Sport" => Color.FromArgb(244, 63, 94),
                _ => Color.FromArgb(99, 102, 241)
            };
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
