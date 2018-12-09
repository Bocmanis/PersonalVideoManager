using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.Models;
using FastFoodDemo.Logic;
using System.IO;

namespace FastFoodDemo.Controls
{
    public partial class SingleVideoView : UserControl
    {
        public Video Video { get; set; }
        public VideoControllerLogic VideoControllerLogic { get; set; }

        public SingleVideoView(Video video, bool fullScreen)
        {
            InitializeComponent();
            this.VideoControllerLogic = new VideoControllerLogic(videoPlayer);
            this.Video = video;
            foreach (var moment in Video.TimeSkips)
            {
                momentsFlowLayoutPanel.Controls.Add(new SignificantMomentController(moment, VideoControllerLogic));
            }

            stopWatchingMomentButton.Visible = false;
            timersLabel.Text = TimeLabelText;
            timer1.Tick += TimeTickEvent;
            timer1.Interval = 100;
            timer1.Start();
            videoNameText.Text = video.Name;
            VideoControllerLogic.Play(Video, fullScreen);
        }

        private void videoNameText_TextChanged(object sender, EventArgs e)
        {
            Video.Name = videoNameText.Text;
        }

        private string TimeLabelText
        {
            get
            {
                return $"{GetHHMMssFromMiliseconds(videoPlayer.Time)}/{GetHHMMssFromMiliseconds(videoPlayer.Length)}";
            }
        }

        private string GetHHMMssFromMiliseconds(double time)
        {
            return VideoControllerLogic.GetHHMMssFromMiliseconds(time);
        }

        private void TimeTickEvent(object sender, EventArgs eventArgs)
        {
            timersLabel.Text = TimeLabelText;
            if (VideoControllerLogic.MomentToWatchNow != null)
            {
                stopWatchingMomentButton.Visible = true;
            }
            if (videoPlayer.Time + 500 > videoPlayer.Length)
            {
                var hasFullScreen = false;
                var video = Context.GetNextVideo(Video);
                if (video != null)
                {
                    Context.ViewSwitcher.SwitchToSingleVideoScreen(video, hasFullScreen);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (videoPlayer.Time < 10000)
            {
                videoPlayer.Time = 0;
            }
            else
            {
                videoPlayer.Time -= (long)new TimeSpan(0, 0, 10).TotalMilliseconds;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            videoPlayer.Time += (long)new TimeSpan(0, 0, 10).TotalMilliseconds;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var parent = Video.Parent;
            parent.VideoId = Video.Id;
            var model = new SignificantMoment()
            {
                SkipFrom = videoPlayer.Time,
                SkipTo = videoPlayer.Length,
                SkipThis = true,
                Parent = parent
            };
            Video.TimeSkips.Add(model);
            var control = new SignificantMomentController(model, VideoControllerLogic);
            momentsFlowLayoutPanel.Controls.Add(control);
        }

        private void stopWatchingMomentButton_Click(object sender, EventArgs e)
        {
            VideoControllerLogic.MomentToWatchNow = null;
            stopWatchingMomentButton.Visible = false;
        }

        private void momentsFlowLayoutPanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.momentsFlowLayoutPanel.Focus();
            this.ActiveControl = null;
        }
    }
}
