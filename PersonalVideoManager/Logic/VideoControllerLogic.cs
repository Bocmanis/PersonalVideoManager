using AxWMPLib;
using PersonalVideoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace PersonalVideoManager.Logic
{
    public class VideoControllerLogic
    {
        public AxWindowsMediaPlayer VideoPlayer { get; set; }
        public List<SignificantMoment> SkipMoments { get; set; }
        public SignificantMoment MomentToWatchNow { get; set; }

        private Timer Timer { get; set; }

        public VideoControllerLogic(AxWindowsMediaPlayer videoPlayer)
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
            var currentTime = VideoPlayer.Ctlcontrols.currentPosition;
            if (MomentToWatchNow != null)
            {
                if (currentTime > MomentToWatchNow.SkipTo)
                {
                    VideoPlayer.Ctlcontrols.currentPosition = MomentToWatchNow.SkipFrom;
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
                        VideoPlayer.Ctlcontrols.currentPosition = endTime;
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

        internal void Play(SignificantMoment momentToWach, bool fullScreen = false)
        {
            VideoPlayer.Ctlcontrols.currentPosition = momentToWach.SkipFrom;
            VideoPlayer.Ctlcontrols.play();
            MomentToWatchNow = momentToWach;
        }

        internal void Play(Video video, bool fullScreen = false)
        {
            VideoPlayer.Ctlcontrols.stop();

            VideoPlayer.URL = video.Path;
            SkipMoments = video.TimeSkips.Where(x => x.SkipThis).ToList();
            VideoPlayer.Ctlcontrols.play();
            if (fullScreen)
            {
                VideoPlayer.PlayStateChange += SetStateFullscreen;
            }
        }

        private void SetStateFullscreen(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (VideoPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                VideoPlayer.fullScreen = true;
            }
        }
    }
}
