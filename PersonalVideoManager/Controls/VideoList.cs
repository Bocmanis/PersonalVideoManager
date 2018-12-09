using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalVideoManager.Models;
using PersonalVideoManager.Interfaces;

namespace PersonalVideoManager.Controls
{
    public partial class VideoList : UserControl
    {
        public List<SeasonalCollection> Model;
        public VideoList(List<SeasonalCollection> model)
        {
            Model = model ?? new List<SeasonalCollection>();

            InitializeComponent();

            modelSource.DataSource = model;
            AddControlsToFlowPanel();
        }

        private void AddControlsToFlowPanel()
        {
            foreach (var collection in Model)
            {
                var i = 0;

                var controller = new HeadlinerController(collection);

                if (i != 0 && i % 4 == 0)
                {
                    flowLayoutPanel1.SetFlowBreak(controller, true);
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(controller);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
