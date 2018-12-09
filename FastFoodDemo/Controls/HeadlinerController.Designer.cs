namespace FastFoodDemo.Controls
{
    partial class HeadlinerController
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
            this.videoNameLabel = new System.Windows.Forms.Label();
            this.videoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).BeginInit();
            this.videoPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoNameLabel
            // 
            this.videoNameLabel.AutoSize = true;
            this.videoNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.videoNameLabel.CausesValidation = false;
            this.videoNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.videoNameLabel.Location = new System.Drawing.Point(3, 77);
            this.videoNameLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.videoNameLabel.Name = "videoNameLabel";
            this.videoNameLabel.Size = new System.Drawing.Size(189, 38);
            this.videoNameLabel.TabIndex = 1;
            this.videoNameLabel.Text = "Base video name label text might be quite long";
            // 
            // videoPictureBox
            // 
            this.videoPictureBox.Controls.Add(this.videoNameLabel);
            this.videoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPictureBox.Image = global::FastFoodDemo.Properties.Resources.application_home;
            this.videoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.videoPictureBox.Name = "videoPictureBox";
            this.videoPictureBox.Size = new System.Drawing.Size(200, 124);
            this.videoPictureBox.TabIndex = 0;
            this.videoPictureBox.TabStop = false;
            this.videoPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HeadlinerController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoPictureBox);
            this.Name = "HeadlinerController";
            this.Size = new System.Drawing.Size(200, 124);
            ((System.ComponentModel.ISupportInitialize)(this.videoPictureBox)).EndInit();
            this.videoPictureBox.ResumeLayout(false);
            this.videoPictureBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label videoNameLabel;
        private System.Windows.Forms.PictureBox videoPictureBox;
    }
}
