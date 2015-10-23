namespace GUI2.Views
{
    partial class EditCategoryForm
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
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.textBoxAffectedFeeds = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelAffectedFeeds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(8, 17);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(158, 20);
            this.labelNewName.TabIndex = 0;
            this.labelNewName.Text = "New Category Name:";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(12, 48);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(282, 26);
            this.textBoxNewName.TabIndex = 1;
            // 
            // textBoxAffectedFeeds
            // 
            this.textBoxAffectedFeeds.Location = new System.Drawing.Point(12, 134);
            this.textBoxAffectedFeeds.Multiline = true;
            this.textBoxAffectedFeeds.Name = "textBoxAffectedFeeds";
            this.textBoxAffectedFeeds.ReadOnly = true;
            this.textBoxAffectedFeeds.Size = new System.Drawing.Size(438, 163);
            this.textBoxAffectedFeeds.TabIndex = 2;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(233, 317);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(115, 40);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(354, 316);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 41);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelAffectedFeeds
            // 
            this.labelAffectedFeeds.AutoSize = true;
            this.labelAffectedFeeds.Location = new System.Drawing.Point(8, 97);
            this.labelAffectedFeeds.Name = "labelAffectedFeeds";
            this.labelAffectedFeeds.Size = new System.Drawing.Size(144, 20);
            this.labelAffectedFeeds.TabIndex = 5;
            this.labelAffectedFeeds.Text = "Feeds In Category:";
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 369);
            this.Controls.Add(this.labelAffectedFeeds);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxAffectedFeeds);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewName);
            this.Name = "EditCategoryForm";
            this.Text = "EditCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.TextBox textBoxAffectedFeeds;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelAffectedFeeds;
    }
}