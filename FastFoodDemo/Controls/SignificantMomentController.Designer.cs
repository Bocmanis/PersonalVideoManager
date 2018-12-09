namespace FastFoodDemo.Controls
{
    partial class SignificantMomentController
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
            this.TillTextBox = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.skipCheckBox = new System.Windows.Forms.CheckBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.applyToAllButton = new System.Windows.Forms.Button();
            this.toSkipNumber = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TillTextBox
            // 
            this.TillTextBox.Location = new System.Drawing.Point(87, 49);
            this.TillTextBox.Name = "TillTextBox";
            this.TillTextBox.Size = new System.Drawing.Size(89, 20);
            this.TillTextBox.TabIndex = 0;
            this.TillTextBox.TextChanged += new System.EventHandler(this.TillTextBox_TextChanged);
            // 
            // playButton
            // 
            this.playButton.Image = global::FastFoodDemo.Properties.Resources.control_play_blue;
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playButton.Location = new System.Drawing.Point(3, 6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(64, 37);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // skipCheckBox
            // 
            this.skipCheckBox.AutoSize = true;
            this.skipCheckBox.Checked = true;
            this.skipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skipCheckBox.Location = new System.Drawing.Point(73, 3);
            this.skipCheckBox.Name = "skipCheckBox";
            this.skipCheckBox.Size = new System.Drawing.Size(70, 17);
            this.skipCheckBox.TabIndex = 2;
            this.skipCheckBox.Text = "Skip This";
            this.skipCheckBox.UseVisualStyleBackColor = true;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(3, 49);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(78, 20);
            this.fromTextBox.TabIndex = 3;
            this.fromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            // 
            // applyToAllButton
            // 
            this.applyToAllButton.Location = new System.Drawing.Point(73, 20);
            this.applyToAllButton.Name = "applyToAllButton";
            this.applyToAllButton.Size = new System.Drawing.Size(103, 23);
            this.applyToAllButton.TabIndex = 4;
            this.applyToAllButton.Text = "Apply To All";
            this.applyToAllButton.UseVisualStyleBackColor = true;
            this.applyToAllButton.Click += new System.EventHandler(this.applyToAllButton_Click);
            // 
            // toSkipNumber
            // 
            this.toSkipNumber.AutoSize = true;
            this.toSkipNumber.Location = new System.Drawing.Point(3, 72);
            this.toSkipNumber.Name = "toSkipNumber";
            this.toSkipNumber.Size = new System.Drawing.Size(0, 13);
            this.toSkipNumber.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 72);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(173, 42);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // SignificantMomentController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.toSkipNumber);
            this.Controls.Add(this.applyToAllButton);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.skipCheckBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.TillTextBox);
            this.Name = "SignificantMomentController";
            this.Size = new System.Drawing.Size(179, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TillTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.CheckBox skipCheckBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Button applyToAllButton;
        private System.Windows.Forms.Label toSkipNumber;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}
