namespace FastFoodDemo.Controls
{
    partial class SingleVideoView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleVideoView));
            this.skipsLabel = new System.Windows.Forms.Label();
            this.videoNameText = new System.Windows.Forms.TextBox();
            this.timersLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.stopWatchingMomentButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.momentsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // skipsLabel
            // 
            this.skipsLabel.AutoSize = true;
            this.skipsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsLabel.Location = new System.Drawing.Point(611, 19);
            this.skipsLabel.Name = "skipsLabel";
            this.skipsLabel.Size = new System.Drawing.Size(168, 19);
            this.skipsLabel.TabIndex = 3;
            this.skipsLabel.Text = "Moments of significance";
            // 
            // videoNameText
            // 
            this.videoNameText.BackColor = System.Drawing.SystemColors.Menu;
            this.videoNameText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoNameText.Location = new System.Drawing.Point(3, 11);
            this.videoNameText.Name = "videoNameText";
            this.videoNameText.Size = new System.Drawing.Size(505, 27);
            this.videoNameText.TabIndex = 5;
            this.videoNameText.TextChanged += new System.EventHandler(this.videoNameText_TextChanged);
            // 
            // timersLabel
            // 
            this.timersLabel.AutoSize = true;
            this.timersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timersLabel.Location = new System.Drawing.Point(9, 478);
            this.timersLabel.Name = "timersLabel";
            this.timersLabel.Size = new System.Drawing.Size(45, 19);
            this.timersLabel.TabIndex = 6;
            this.timersLabel.Text = "00:00";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(9, 498);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<= 10s";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(90, 498);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 23);
            this.forwardButton.TabIndex = 7;
            this.forwardButton.Text = "10s =>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(273, 498);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Play Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(183, 498);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(84, 23);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = "Play Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Image = global::FastFoodDemo.Properties.Resources.add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(497, 481);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 53);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // stopWatchingMomentButton
            // 
            this.stopWatchingMomentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatchingMomentButton.Image = global::FastFoodDemo.Properties.Resources.delete;
            this.stopWatchingMomentButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stopWatchingMomentButton.Location = new System.Drawing.Point(354, 481);
            this.stopWatchingMomentButton.Name = "stopWatchingMomentButton";
            this.stopWatchingMomentButton.Size = new System.Drawing.Size(137, 53);
            this.stopWatchingMomentButton.TabIndex = 10;
            this.stopWatchingMomentButton.Text = "Stop watching the moment";
            this.stopWatchingMomentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stopWatchingMomentButton.UseVisualStyleBackColor = false;
            this.stopWatchingMomentButton.Click += new System.EventHandler(this.stopWatchingMomentButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.momentsFlowLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(615, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 489);
            this.panel1.TabIndex = 11;
            // 
            // momentsFlowLayoutPanel
            // 
            this.momentsFlowLayoutPanel.AllowDrop = true;
            this.momentsFlowLayoutPanel.AutoScroll = true;
            this.momentsFlowLayoutPanel.AutoSize = true;
            this.momentsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.momentsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.momentsFlowLayoutPanel.Name = "momentsFlowLayoutPanel";
            this.momentsFlowLayoutPanel.Size = new System.Drawing.Size(201, 489);
            this.momentsFlowLayoutPanel.TabIndex = 3;
            this.momentsFlowLayoutPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.momentsFlowLayoutPanel_Scroll);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(3, 45);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(588, 430);
            this.videoPlayer.TabIndex = 12;
            // 
            // SingleVideoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stopWatchingMomentButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.timersLabel);
            this.Controls.Add(this.videoNameText);
            this.Controls.Add(this.skipsLabel);
            this.Name = "SingleVideoView";
            this.Size = new System.Drawing.Size(837, 548);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label skipsLabel;
        private System.Windows.Forms.TextBox videoNameText;
        private System.Windows.Forms.Label timersLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button stopWatchingMomentButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel momentsFlowLayoutPanel;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
    }
}
