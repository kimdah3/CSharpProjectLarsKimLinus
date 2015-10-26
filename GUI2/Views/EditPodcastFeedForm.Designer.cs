namespace GUI2.Views
{
    partial class EditPodcastFeedForm
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
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelUpdateInterval = new System.Windows.Forms.Label();
            this.textBoxUpdateInterval = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelEpisode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(12, 9);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(32, 13);
            this.labelUrl.TabIndex = 0;
            this.labelUrl.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 25);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(354, 20);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 48);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(12, 64);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(354, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // labelUpdateInterval
            // 
            this.labelUpdateInterval.AutoSize = true;
            this.labelUpdateInterval.Location = new System.Drawing.Point(12, 87);
            this.labelUpdateInterval.Name = "labelUpdateInterval";
            this.labelUpdateInterval.Size = new System.Drawing.Size(83, 13);
            this.labelUpdateInterval.TabIndex = 4;
            this.labelUpdateInterval.Text = "Update Interval:";
            // 
            // textBoxUpdateInterval
            // 
            this.textBoxUpdateInterval.Location = new System.Drawing.Point(12, 103);
            this.textBoxUpdateInterval.Name = "textBoxUpdateInterval";
            this.textBoxUpdateInterval.Size = new System.Drawing.Size(149, 20);
            this.textBoxUpdateInterval.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 148);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(12, 164);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(354, 21);
            this.comboBoxCategories.TabIndex = 7;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(235, 202);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(64, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(305, 202);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelEpisode
            // 
            this.labelEpisode.AutoSize = true;
            this.labelEpisode.Location = new System.Drawing.Point(12, 129);
            this.labelEpisode.Name = "labelEpisode";
            this.labelEpisode.Size = new System.Drawing.Size(56, 13);
            this.labelEpisode.TabIndex = 10;
            this.labelEpisode.Text = "Episodes: ";
            // 
            // EditPodcastFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 237);
            this.Controls.Add(this.labelEpisode);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxUpdateInterval);
            this.Controls.Add(this.labelUpdateInterval);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelUrl);
            this.Name = "EditPodcastFeedForm";
            this.Text = "Edit Podcast Feed";
            this.Load += new System.EventHandler(this.EditPodcastFeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelUpdateInterval;
        private System.Windows.Forms.TextBox textBoxUpdateInterval;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelEpisode;
    }
}