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
            this.labelTitleShow = new System.Windows.Forms.Label();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(12, 9);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(46, 20);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL:";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 37);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(546, 26);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.Leave += new System.EventHandler(this.textBoxURL_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 76);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title:";
            // 
            // labelTitleShow
            // 
            this.labelTitleShow.AutoSize = true;
            this.labelTitleShow.Location = new System.Drawing.Point(19, 106);
            this.labelTitleShow.Name = "labelTitleShow";
            this.labelTitleShow.Size = new System.Drawing.Size(0, 20);
            this.labelTitleShow.TabIndex = 3;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(11, 161);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(77, 20);
            this.labelAddCategory.TabIndex = 5;
            this.labelAddCategory.Text = "Category:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(463, 240);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 32);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(356, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 32);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(12, 189);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(546, 28);
            this.comboBoxCategories.TabIndex = 9;
            // 
            // AddPodcastFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 293);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAddCategory);
            this.Controls.Add(this.labelTitleShow);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.labelURL);
            this.Name = "AddPodcastFeedForm";
            this.Text = "AddPodcastFeedForm";
            this.Load += new System.EventHandler(this.AddPodcastFeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTitleShow;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCategories;
    }
}