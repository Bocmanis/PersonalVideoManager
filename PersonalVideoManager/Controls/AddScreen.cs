using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PersonalVideoManager.Logic;

namespace PersonalVideoManager
{
    public partial class AddScreen : UserControl
    {
        private ItemAddingLogic itemAddingLogic;
        public AddScreen()
        {
            itemAddingLogic = new ItemAddingLogic();
            InitializeComponent();
        }

        private void addFilesButton_Click(object sender, EventArgs e)
        {
            var files = itemAddingLogic.AddItems();

            logTextBox.Text = files;
        }
    }
}
