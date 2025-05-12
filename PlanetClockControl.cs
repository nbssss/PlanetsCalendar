using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace astro_app
{
    public partial class PlanetClockControl : UserControl
    {
        private PlanetTimeService planetTimeService = new PlanetTimeService();
        private Planet planet;
        public PlanetClockControl(Planet selectedPlanet)
        {
            InitializeComponent();
            planet = selectedPlanet;
            SetPlanetImage();
        }

        private void PlanetClockControl_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = planetTimeService.GetPlanetDate(planet).ToLongDateString();
            CenterLabel();
        }

        private void SetPlanetImage()
        {
            //
            string imagePath = $"Images/{planet.ToString().ToLower()}.png";

            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void CenterLabel()
        {
            int pictureCenter = pictureBox.Width / 2;
            int labelCenter = dateLabel.Width / 2;
            dateLabel.Left = pictureBox.Left + pictureCenter - labelCenter;
        }
    }
}
