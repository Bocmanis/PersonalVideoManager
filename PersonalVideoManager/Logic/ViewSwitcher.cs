using PersonalVideoManager.Controls;
using PersonalVideoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalVideoManager.Logic
{
    public class ViewSwitcher
    {
        GroupBox GroupBox { get; set; }
        public ViewSwitcher(GroupBox groupBox)
        {
            GroupBox = groupBox;
        }

        public void SwitchView(UserControl userControl)
        {
            if (GroupBox.Controls.Count > 0)
            {
                UserControl oldView = GroupBox.Controls[0] as UserControl;
                GroupBox.Controls.Remove(oldView);
                oldView.Dispose();
            }
            GroupBox.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        public void SwitchToAddScreen()
        {
            var userControl = new AddScreen();
            SwitchView(userControl);
        }

        public void SwitchToList()
        {
            var userControl = new VideoList(Context.Collections);
            SwitchView(userControl);
        }

        internal void SwitchToSeasonalItemScreen(SeasonalCollection collection)
        {
            var userControl = new SeasonalItemView(collection);
            SwitchView(userControl);
        }

        public void SwitchToSingleVideoScreen(Video video, bool fullScreen = false)
        {
            var userControl = new SingleVideoView(video, fullScreen);
            SwitchView(userControl);
        }
    }
}
