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
using PersonalVideoManager.Logic;

namespace PersonalVideoManager.Controls
{
    public partial class HeadlinerController : UserControl
    {
        private Video Video;
        public SeasonalCollection Model { get; set; }
        public HeadlinerController(SeasonalCollection collection)
        {
            InitializeComponent();
            Model = collection;
            videoNameLabel.Text = collection.Name;
            if (collection.Seasons.Count == 0)
            {
                Context.Collections.Remove(collection);
            }
            else
            {
                this.Video = collection.Seasons[0].Videos[0];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Model.Seasons.Count > 1 || Model.Seasons[0].Videos.Count > 1)
            {
                Context.ViewSwitcher.SwitchToSeasonalItemScreen(Model);
            }
            else
            {
                Context.ViewSwitcher.SwitchToSingleVideoScreen(Video);
            }
        }
    }
}
