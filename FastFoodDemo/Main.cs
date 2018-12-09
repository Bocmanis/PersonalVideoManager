using FastFoodDemo.Controls;
using FastFoodDemo.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Main : Form
    {
        public ViewSwitcher ViewSwitcher { get; set; }
        public Main()
        {
            InitializeComponent();
            var userControl = new AddScreen();
            ViewSwitcher = new ViewSwitcher(groupBox1);
            Context.ViewSwitcher = ViewSwitcher;
            SwitchView(userControl);
        }

        private void SwitchView(UserControl userControl)
        {
            var groupBox = groupBox1;
            ViewSwitcher.SwitchView(userControl);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ViewSwitcher.SwitchToAddScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userControl = new VideoList(Context.GetHeadliners());
            SwitchView(userControl);
        }
    }
}
