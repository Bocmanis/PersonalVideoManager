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
    public partial class SignificantMomentController : UserControl
    {
        public SignificantMoment Model { get; set; }
        public VideoControllerLogic VideoControllerLogic { get; set; }

        public SignificantMomentController(SignificantMoment model, VideoControllerLogic videoControllerLogic)
        {
            InitializeComponent();
            this.Model = model;
            this.VideoControllerLogic = videoControllerLogic;
            descriptionTextBox.Text = Model.Description;
            fromTextBox.Text = VideoControllerLogic.GetHHMMssFromMiliseconds(Model.SkipFrom);
            TillTextBox.Text = VideoControllerLogic.GetHHMMssFromMiliseconds(Model.SkipTo);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            VideoControllerLogic.Play(Model);
        }

        private void applyToAllButton_Click(object sender, EventArgs e)
        {

        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var split = fromTextBox.Text.Split(':').Select(x => int.Parse(x)).ToArray();
                var timeSpan = new TimeSpan(split[0], split[1], split[2]);
                Model.SkipFrom = Convert.ToInt64(timeSpan.TotalMilliseconds);
            }
            catch (Exception)
            {
            }

        }

        private void TillTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var split = TillTextBox.Text.Split(':').Select(x => int.Parse(x)).ToArray();
                var timeSpan = new TimeSpan(split[0], split[1], split[2]);
                Model.SkipTo = Convert.ToInt64(timeSpan.TotalMilliseconds);
            }
            catch (Exception)
            {
            }
        }
    }
}
