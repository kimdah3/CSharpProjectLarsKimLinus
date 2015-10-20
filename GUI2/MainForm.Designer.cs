namespace GUI2
{
    partial class MainForm
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
            this.labelPodcastFeeds = new System.Windows.Forms.Label();
            this.labelPodcastEpisodes = new System.Windows.Forms.Label();
            this.listViewPodcastEpisodes = new System.Windows.Forms.ListView();
            this.listBoxPodcastFeeds = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelPodcastFeeds
            // 
            this.labelPodcastFeeds.AutoSize = true;
            this.labelPodcastFeeds.Location = new System.Drawing.Point(12, 9);
            this.labelPodcastFeeds.Name = "labelPodcastFeeds";
            this.labelPodcastFeeds.Size = new System.Drawing.Size(111, 20);
            this.labelPodcastFeeds.TabIndex = 0;
            this.labelPodcastFeeds.Text = "Podcast feeds";
            // 
            // labelPodcastEpisodes
            // 
            this.labelPodcastEpisodes.AutoSize = true;
            this.labelPodcastEpisodes.Location = new System.Drawing.Point(352, 9);
            this.labelPodcastEpisodes.Name = "labelPodcastEpisodes";
            this.labelPodcastEpisodes.Size = new System.Drawing.Size(135, 20);
            this.labelPodcastEpisodes.TabIndex = 2;
            this.labelPodcastEpisodes.Text = "Podcast episodes";
            // 
            // listViewPodcastEpisodes
            // 
            this.listViewPodcastEpisodes.Location = new System.Drawing.Point(356, 32);
            this.listViewPodcastEpisodes.Name = "listViewPodcastEpisodes";
            this.listViewPodcastEpisodes.Size = new System.Drawing.Size(319, 351);
            this.listViewPodcastEpisodes.TabIndex = 3;
            this.listViewPodcastEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxPodcastFeeds
            // 
            this.listBoxPodcastFeeds.FormattingEnabled = true;
            this.listBoxPodcastFeeds.ItemHeight = 20;
            this.listBoxPodcastFeeds.Location = new System.Drawing.Point(16, 32);
            this.listBoxPodcastFeeds.Name = "listBoxPodcastFeeds";
            this.listBoxPodcastFeeds.Size = new System.Drawing.Size(325, 344);
            this.listBoxPodcastFeeds.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.listBoxPodcastFeeds);
            this.Controls.Add(this.listViewPodcastEpisodes);
            this.Controls.Add(this.labelPodcastEpisodes);
            this.Controls.Add(this.labelPodcastFeeds);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPodcastFeeds;
        private System.Windows.Forms.Label labelPodcastEpisodes;
        private System.Windows.Forms.ListView listViewPodcastEpisodes;
        private System.Windows.Forms.ListBox listBoxPodcastFeeds;
    }
}

