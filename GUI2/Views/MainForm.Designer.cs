﻿namespace GUI
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
            this.listBoxPodcastFeeds = new System.Windows.Forms.ListBox();
            this.listBoxPodcastEpisodes = new System.Windows.Forms.ListBox();
            this.buttonAddPodcastFeed = new System.Windows.Forms.Button();
            this.buttonPlayPodcastEpisode = new System.Windows.Forms.Button();
            this.comboBoxFeedCategory = new System.Windows.Forms.ComboBox();
            this.buttonCategorySettings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeletePodcastFeed = new System.Windows.Forms.Button();
            this.buttonShowPodcastInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPodcastFeeds
            // 
            this.labelPodcastFeeds.AutoSize = true;
            this.labelPodcastFeeds.Location = new System.Drawing.Point(12, 23);
            this.labelPodcastFeeds.Name = "labelPodcastFeeds";
            this.labelPodcastFeeds.Size = new System.Drawing.Size(111, 20);
            this.labelPodcastFeeds.TabIndex = 0;
            this.labelPodcastFeeds.Text = "Podcast feeds";
            // 
            // labelPodcastEpisodes
            // 
            this.labelPodcastEpisodes.AutoSize = true;
            this.labelPodcastEpisodes.Location = new System.Drawing.Point(522, 23);
            this.labelPodcastEpisodes.Name = "labelPodcastEpisodes";
            this.labelPodcastEpisodes.Size = new System.Drawing.Size(135, 20);
            this.labelPodcastEpisodes.TabIndex = 2;
            this.labelPodcastEpisodes.Text = "Podcast episodes";
            // 
            // listBoxPodcastFeeds
            // 
            this.listBoxPodcastFeeds.FormattingEnabled = true;
            this.listBoxPodcastFeeds.ItemHeight = 20;
            this.listBoxPodcastFeeds.Location = new System.Drawing.Point(16, 97);
            this.listBoxPodcastFeeds.Name = "listBoxPodcastFeeds";
            this.listBoxPodcastFeeds.Size = new System.Drawing.Size(458, 344);
            this.listBoxPodcastFeeds.TabIndex = 4;
            this.listBoxPodcastFeeds.SelectedIndexChanged += new System.EventHandler(this.listBoxPodcastFeeds_SelectedIndexChanged);
            // 
            // listBoxPodcastEpisodes
            // 
            this.listBoxPodcastEpisodes.FormattingEnabled = true;
            this.listBoxPodcastEpisodes.ItemHeight = 20;
            this.listBoxPodcastEpisodes.Location = new System.Drawing.Point(526, 54);
            this.listBoxPodcastEpisodes.Name = "listBoxPodcastEpisodes";
            this.listBoxPodcastEpisodes.Size = new System.Drawing.Size(452, 384);
            this.listBoxPodcastEpisodes.TabIndex = 5;
            // 
            // buttonAddPodcastFeed
            // 
            this.buttonAddPodcastFeed.Location = new System.Drawing.Point(16, 448);
            this.buttonAddPodcastFeed.Name = "buttonAddPodcastFeed";
            this.buttonAddPodcastFeed.Size = new System.Drawing.Size(112, 38);
            this.buttonAddPodcastFeed.TabIndex = 6;
            this.buttonAddPodcastFeed.Text = "Add Feed";
            this.buttonAddPodcastFeed.UseVisualStyleBackColor = true;
            this.buttonAddPodcastFeed.Click += new System.EventHandler(this.buttonAddPodcastFeed_Click);
            // 
            // buttonPlayPodcastEpisode
            // 
            this.buttonPlayPodcastEpisode.Location = new System.Drawing.Point(874, 452);
            this.buttonPlayPodcastEpisode.Name = "buttonPlayPodcastEpisode";
            this.buttonPlayPodcastEpisode.Size = new System.Drawing.Size(104, 38);
            this.buttonPlayPodcastEpisode.TabIndex = 7;
            this.buttonPlayPodcastEpisode.Text = "Play";
            this.buttonPlayPodcastEpisode.UseVisualStyleBackColor = true;
            this.buttonPlayPodcastEpisode.Click += new System.EventHandler(this.buttonPlayPodcastEpisode_Click);
            // 
            // comboBoxFeedCategory
            // 
            this.comboBoxFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeedCategory.FormattingEnabled = true;
            this.comboBoxFeedCategory.Location = new System.Drawing.Point(16, 54);
            this.comboBoxFeedCategory.Name = "comboBoxFeedCategory";
            this.comboBoxFeedCategory.Size = new System.Drawing.Size(242, 28);
            this.comboBoxFeedCategory.TabIndex = 8;
            this.comboBoxFeedCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxFeedCategory_SelectedIndexChanged);
            // 
            // buttonCategorySettings
            // 
            this.buttonCategorySettings.Location = new System.Drawing.Point(314, 54);
            this.buttonCategorySettings.Name = "buttonCategorySettings";
            this.buttonCategorySettings.Size = new System.Drawing.Size(160, 32);
            this.buttonCategorySettings.TabIndex = 9;
            this.buttonCategorySettings.Text = "Category Settings";
            this.buttonCategorySettings.UseVisualStyleBackColor = true;
            this.buttonCategorySettings.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonEditPodcastFeed_Click);
            // 
            // buttonDeletePodcastFeed
            // 
            this.buttonDeletePodcastFeed.Location = new System.Drawing.Point(384, 451);
            this.buttonDeletePodcastFeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeletePodcastFeed.Name = "buttonDeletePodcastFeed";
            this.buttonDeletePodcastFeed.Size = new System.Drawing.Size(93, 35);
            this.buttonDeletePodcastFeed.TabIndex = 11;
            this.buttonDeletePodcastFeed.Text = "Delete";
            this.buttonDeletePodcastFeed.UseVisualStyleBackColor = true;
            this.buttonDeletePodcastFeed.Click += new System.EventHandler(this.buttonDeletePodcastFeed_Click);
            // 
            // buttonShowPodcastInfo
            // 
            this.buttonShowPodcastInfo.Location = new System.Drawing.Point(526, 452);
            this.buttonShowPodcastInfo.Name = "buttonShowPodcastInfo";
            this.buttonShowPodcastInfo.Size = new System.Drawing.Size(101, 38);
            this.buttonShowPodcastInfo.TabIndex = 12;
            this.buttonShowPodcastInfo.Text = "Show Info";
            this.buttonShowPodcastInfo.UseVisualStyleBackColor = true;
            this.buttonShowPodcastInfo.Click += new System.EventHandler(this.buttonShowMore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 665);
            this.Controls.Add(this.buttonShowPodcastInfo);
            this.Controls.Add(this.buttonDeletePodcastFeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCategorySettings);
            this.Controls.Add(this.comboBoxFeedCategory);
            this.Controls.Add(this.buttonPlayPodcastEpisode);
            this.Controls.Add(this.buttonAddPodcastFeed);
            this.Controls.Add(this.listBoxPodcastEpisodes);
            this.Controls.Add(this.listBoxPodcastFeeds);
            this.Controls.Add(this.labelPodcastEpisodes);
            this.Controls.Add(this.labelPodcastFeeds);
            this.Name = "MainForm";
            this.Text = "Pod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPodcastFeeds;
        private System.Windows.Forms.Label labelPodcastEpisodes;
        private System.Windows.Forms.ListBox listBoxPodcastFeeds;
        private System.Windows.Forms.ListBox listBoxPodcastEpisodes;
        private System.Windows.Forms.Button buttonAddPodcastFeed;
        private System.Windows.Forms.Button buttonPlayPodcastEpisode;
        private System.Windows.Forms.ComboBox comboBoxFeedCategory;
        private System.Windows.Forms.Button buttonCategorySettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeletePodcastFeed;
        private System.Windows.Forms.Button buttonShowPodcastInfo;
    }
}

