using FastFoodDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace FastFoodDemo.Logic
{
    public class VideoControllerLogic
    {
        public VlcControl VideoPlayer { get; set; }
        public List<SignificantMoment> SkipMoments { get; set; }
        public SignificantMoment MomentToWatchNow { get; set; }

        private Timer Timer { get; set; }

        public VideoControllerLogic(VlcControl videoPlayer)
        {
            this.VideoPlayer = videoPlayer;
            SkipMoments = new List<SignificantMoment>();
            Timer = new Timer();
            Timer.Tick += TimerTick;
            Timer.Interval = 137;
            Timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (!VideoPlayer.CanFocus)
            {
                return;
            }
            var currentTime = VideoPlayer.Time;
            if (MomentToWatchNow != null)
            {
                if (currentTime > MomentToWatchNow.SkipTo)
                {
                    VideoPlayer.Time = MomentToWatchNow.SkipFrom;
                }
            }
            else
            {
                if (SkipMoments.Any())
                {
                    var haGotcha = SkipMoments.Where(x => x.SkipFrom > currentTime && x.SkipTo < currentTime);
                    if (haGotcha.Any())
                    {
                        var endTime = haGotcha.Max(x => x.SkipTo);
                        VideoPlayer.Time = endTime;
                    }
                }
            }
        }

        public string GetHHMMssFromMiliseconds(double miliseconds)
        {
            if (miliseconds == -1)
            {
                return "00:00:00";
            }
            var timeSpan = TimeSpan.FromMilliseconds(miliseconds);
            return $"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}";
        }

        internal void Play(SignificantMoment momentToWach)
        {
            Play(momentToWach);
        }

        internal void Play(SignificantMoment momentToWach, bool fullScreen = false)
        {
            VideoPlayer.Time = momentToWach.SkipFrom;
            VideoPlayer.Play();
            MomentToWatchNow = momentToWach;
        }

        internal void Play(Video video, bool fullScreen = false)
        {
            var uri = new Uri(video.Path);
            var convertedURI = uri.AbsoluteUri;
            VideoPlayer.Stop();

            SkipMoments = video.TimeSkips.Where(x => x.SkipThis).ToList();
            if (fullScreen)
            {
                VideoPlayer.Play(convertedURI, ":fullscreen");
            }
            else
            {
                VideoPlayer.Play(convertedURI);
            }
        }
    }
}
