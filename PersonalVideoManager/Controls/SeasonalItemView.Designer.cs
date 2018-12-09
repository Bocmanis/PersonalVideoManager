namespace PersonalVideoManager.Controls
{
    partial class SeasonalItemView
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
            this.collectionTabControl = new System.Windows.Forms.TabControl();
            this.collectionNameLabel = new System.Windows.Forms.Label();
            this.playAllButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.collectionTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // collectionTabControl
            // 
            this.collectionTabControl.Controls.Add(this.tabPage1);
            this.collectionTabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionTabControl.ItemSize = new System.Drawing.Size(180, 30);
            this.collectionTabControl.Location = new System.Drawing.Point(3, 61);
            this.collectionTabControl.Multiline = true;
            this.collectionTabControl.Name = "collectionTabControl";
            this.collectionTabControl.SelectedIndex = 0;
            this.collectionTabControl.Size = new System.Drawing.Size(832, 446);
            this.collectionTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.collectionTabControl.TabIndex = 0;
            // 
            // collectionNameLabel
            // 
            this.collectionNameLabel.AutoSize = true;
            this.collectionNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collectionNameLabel.Location = new System.Drawing.Point(19, 18);
            this.collectionNameLabel.Name = "collectionNameLabel";
            this.collectionNameLabel.Size = new System.Drawing.Size(380, 19);
            this.collectionNameLabel.TabIndex = 1;
            this.collectionNameLabel.Text = "This is gonna be long and nice collection name right here";
            // 
            // playAllButton
            // 
            this.playAllButton.Location = new System.Drawing.Point(471, 5);
            this.playAllButton.Name = "playAllButton";
            this.playAllButton.Size = new System.Drawing.Size(136, 32);
            this.playAllButton.TabIndex = 2;
            this.playAllButton.Text = "Play All";
            this.playAllButton.UseVisualStyleBackColor = true;
            this.playAllButton.Click += new System.EventHandler(this.playAllButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(824, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonalItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playAllButton);
            this.Controls.Add(this.collectionNameLabel);
            this.Controls.Add(this.collectionTabControl);
            this.Name = "SeasonalItemView";
            this.Size = new System.Drawing.Size(838, 526);
            this.collectionTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl collectionTabControl;
        private System.Windows.Forms.Label collectionNameLabel;
        private System.Windows.Forms.Button playAllButton;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
