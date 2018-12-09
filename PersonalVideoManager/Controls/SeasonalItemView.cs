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
    public partial class SeasonalItemView : UserControl
    {
        public SeasonalCollection Model { get; set; }
        public SeasonalItemView(SeasonalCollection seasonalCollection)
        {
            InitializeComponent();
            Model = seasonalCollection;

            collectionNameLabel.Text = Model.Name;
            var baseTabPage = collectionTabControl.TabPages[0];
            collectionTabControl.TabPages.Remove(baseTabPage);
            foreach (var season in Model.Seasons)
            {
                var tabPage = new TabPage();
                tabPage.Text = season.Name;
                tabPage.Name = season.Name;
                var flowLayout = new FlowLayoutPanel();
                flowLayout.FlowDirection = FlowDirection.LeftToRight;
                flowLayout.AutoScroll = true;
                flowLayout.AutoSize = true;
                flowLayout.WrapContents = true;
                flowLayout.Controls.AddRange(GetVideos(season));
                flowLayout.Dock = DockStyle.Fill;
                tabPage.Controls.Add(flowLayout);
                collectionTabControl.TabPages.Add(tabPage);
            }
        }

        private Control[] GetVideos(Collection season)
        {
            return season.Videos.Select(v=> new SingleVideoControl(v)).ToArray();
        }

        private void playAllButton_Click(object sender, EventArgs e)
        {
            var currentSeason = collectionTabControl.SelectedTab.Text;
            var season = Model.Seasons.FirstOrDefault(x => x.Name == currentSeason);
            Context.ViewSwitcher.SwitchToSingleVideoScreen(season.Videos[0], true);
        }
    }
}
