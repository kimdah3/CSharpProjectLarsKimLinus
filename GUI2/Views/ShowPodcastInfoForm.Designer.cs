namespace GUI2.Views
{
    partial class ShowPodcastInfoForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelMp3Url = new System.Windows.Forms.Label();
            this.textBoxMp3Url = new System.Windows.Forms.TextBox();
            this.labelPublishDate = new System.Windows.Forms.Label();
            this.textBoxPublishDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(12, 32);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(570, 26);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 71);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 20);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(12, 94);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(570, 156);
            this.textBoxDescription.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(405, 463);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(177, 39);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelMp3Url
            // 
            this.labelMp3Url.AutoSize = true;
            this.labelMp3Url.Location = new System.Drawing.Point(12, 261);
            this.labelMp3Url.Name = "labelMp3Url";
            this.labelMp3Url.Size = new System.Drawing.Size(46, 20);
            this.labelMp3Url.TabIndex = 5;
            this.labelMp3Url.Text = "URL:";
            // 
            // textBoxMp3Url
            // 
            this.textBoxMp3Url.Location = new System.Drawing.Point(12, 284);
            this.textBoxMp3Url.Name = "textBoxMp3Url";
            this.textBoxMp3Url.ReadOnly = true;
            this.textBoxMp3Url.Size = new System.Drawing.Size(570, 26);
            this.textBoxMp3Url.TabIndex = 6;
            // 
            // labelPublishDate
            // 
            this.labelPublishDate.AutoSize = true;
            this.labelPublishDate.Location = new System.Drawing.Point(12, 322);
            this.labelPublishDate.Name = "labelPublishDate";
            this.labelPublishDate.Size = new System.Drawing.Size(121, 20);
            this.labelPublishDate.TabIndex = 7;
            this.labelPublishDate.Text = "Date Published:";
            // 
            // textBoxPublishDate
            // 
            this.textBoxPublishDate.Location = new System.Drawing.Point(12, 345);
            this.textBoxPublishDate.Name = "textBoxPublishDate";
            this.textBoxPublishDate.ReadOnly = true;
            this.textBoxPublishDate.Size = new System.Drawing.Size(570, 26);
            this.textBoxPublishDate.TabIndex = 8;
            // 
            // ShowPodcastInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 514);
            this.Controls.Add(this.textBoxPublishDate);
            this.Controls.Add(this.labelPublishDate);
            this.Controls.Add(this.textBoxMp3Url);
            this.Controls.Add(this.labelMp3Url);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "ShowPodcastInfoForm";
            this.Text = "ShowPodcastInfoForm";
            this.Load += new System.EventHandler(this.ShowPodcastInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelMp3Url;
        private System.Windows.Forms.TextBox textBoxMp3Url;
        private System.Windows.Forms.Label labelPublishDate;
        private System.Windows.Forms.TextBox textBoxPublishDate;
    }
}