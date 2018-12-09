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

namespace FastFoodDemo.Controls
{
    public partial class SingleVideoControl : UserControl
    {
        public Video Model { get; set; }
        public SingleVideoControl(Video video)
        {
            InitializeComponent();
            Model = video;
            videoNameLabel.Text = video.Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Context.ViewSwitcher.SwitchToSingleVideoScreen(Model);
        }
    }
}
