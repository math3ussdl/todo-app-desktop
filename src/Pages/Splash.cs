using System;
using System.IO;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            panelLoad.Width += 3;

            if (panelLoad.Width >= 700)
            {
                timer.Stop();

                string pathJSON = $"{Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))}/.data/prfl.json";
                   
                if (File.Exists(pathJSON))
                {
                    new Dashboard().Show();
                    this.Hide();
                }

                else
                {
                    new Login().Show();
                    this.Hide();
                }
            }
        }
    }
}
