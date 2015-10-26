namespace GUI.Views
{
    partial class AddPodcastFeedForm
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
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelUpdateInterval = new System.Windows.Forms.Label();
            this.textBoxUpdateInterval = new System.Windows.Forms.TextBox();
            this.labelEpisodes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 9);
            this.labelURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(8, 24);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(365, 20);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 49);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title:";
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(7, 154);
            this.labelAddCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(52, 13);
            this.labelAddCategory.TabIndex = 7;
            this.labelAddCategory.Text = "Category:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(309, 208);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(63, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(238, 208);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(67, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(8, 172);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(365, 21);
            this.comboBoxCategories.TabIndex = 8;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(8, 65);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(364, 20);
            this.textBoxTitle.TabIndex = 3;
            // 
            // labelUpdateInterval
            // 
            this.labelUpdateInterval.AutoSize = true;
            this.labelUpdateInterval.Location = new System.Drawing.Point(12, 88);
            this.labelUpdateInterval.Name = "labelUpdateInterval";
            this.labelUpdateInterval.Size = new System.Drawing.Size(128, 13);
            this.labelUpdateInterval.TabIndex = 4;
            this.labelUpdateInterval.Text = "Update Interval: (minutes)";
            // 
            // textBoxUpdateInterval
            // 
            this.textBoxUpdateInterval.Location = new System.Drawing.Point(8, 104);
            this.textBoxUpdateInterval.Name = "textBoxUpdateInterval";
            this.textBoxUpdateInterval.Size = new System.Drawing.Size(364, 20);
            this.textBoxUpdateInterval.TabIndex = 5;
            // 
            // labelEpisodes
            // 
            this.labelEpisodes.AutoSize = true;
            this.labelEpisodes.Location = new System.Drawing.Point(12, 127);
            this.labelEpisodes.Name = "labelEpisodes";
            this.labelEpisodes.Size = new System.Drawing.Size(56, 13);
            this.labelEpisodes.TabIndex = 6;
            this.labelEpisodes.Text = "Episodes: ";
            // 
            // AddPodcastFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 243);
            this.Controls.Add(this.labelEpisodes);
            this.Controls.Add(this.textBoxUpdateInterval);
            this.Controls.Add(this.labelUpdateInterval);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPodcastFeedForm";
            this.Text = "Add Podcast Feed";
            this.Load += new System.EventHandler(this.AddPodcastFeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelUpdateInterval;
        private System.Windows.Forms.TextBox textBoxUpdateInterval;
        private System.Windows.Forms.Label labelEpisodes;
    }
}