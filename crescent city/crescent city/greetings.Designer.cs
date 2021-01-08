namespace crescent_city
{
    partial class greetings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soloButton = new System.Windows.Forms.Button();
            this.duoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soloButton
            // 
            this.soloButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soloButton.Location = new System.Drawing.Point(159, 80);
            this.soloButton.Name = "soloButton";
            this.soloButton.Size = new System.Drawing.Size(75, 23);
            this.soloButton.TabIndex = 0;
            this.soloButton.Text = "solo";
            this.soloButton.UseVisualStyleBackColor = true;
            this.soloButton.Click += new System.EventHandler(this.soloButton_Click);
            // 
            // duoButton
            // 
            this.duoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.duoButton.Location = new System.Drawing.Point(159, 170);
            this.duoButton.Name = "duoButton";
            this.duoButton.Size = new System.Drawing.Size(75, 23);
            this.duoButton.TabIndex = 1;
            this.duoButton.Text = "duo";
            this.duoButton.UseVisualStyleBackColor = true;
            this.duoButton.Click += new System.EventHandler(this.duoButton_Click);
            // 
            // greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crescent_city.Properties.Resources.crescentCity;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.duoButton);
            this.Controls.Add(this.soloButton);
            this.Name = "greetings";
            this.Text = "greetings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button soloButton;
        private System.Windows.Forms.Button duoButton;
    }
}