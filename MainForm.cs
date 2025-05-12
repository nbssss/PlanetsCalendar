using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace astro_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void planetBtn_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            Planet selectedPlanet;
            string planetName = clickedBtn.Text;

            if (Enum.TryParse(planetName, out selectedPlanet))
            {
                PlanetClockControl planetClockControl = new PlanetClockControl(selectedPlanet);
                panelMain.Controls.Clear();

                panelMain.Controls.Add(planetClockControl);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //btnEarth.PerformClick();
            planetBtn_Click(btnEarth, EventArgs.Empty);
        }
    }
}
