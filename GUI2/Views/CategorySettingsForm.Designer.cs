using System;
using System.Collections.Generic;
using Logic.Entities;

namespace GUI2.Views
{
    partial class CategorySettingsForm
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
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.labelCurrentCategorie = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(15, 16);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(141, 20);
            this.labelAddCategory.TabIndex = 0;
            this.labelAddCategory.Text = "Add New Category";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 20;
            this.listBoxCategories.Location = new System.Drawing.Point(313, 51);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(405, 304);
            this.listBoxCategories.TabIndex = 1;
            // 
            // labelCurrentCategorie
            // 
            this.labelCurrentCategorie.AutoSize = true;
            this.labelCurrentCategorie.Location = new System.Drawing.Point(309, 16);
            this.labelCurrentCategorie.Name = "labelCurrentCategorie";
            this.labelCurrentCategorie.Size = new System.Drawing.Size(143, 20);
            this.labelCurrentCategorie.TabIndex = 2;
            this.labelCurrentCategorie.Text = "Current Categories";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(15, 51);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(55, 20);
            this.labelCategoryName.TabIndex = 3;
            this.labelCategoryName.Text = "Name:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(19, 74);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(276, 26);
            this.textBoxCategoryName.TabIndex = 4;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(19, 115);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(130, 39);
            this.buttonAddCategory.TabIndex = 5;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(448, 364);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(117, 40);
            this.buttonEditCategory.TabIndex = 6;
            this.buttonEditCategory.Text = "Edit";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(585, 364);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(133, 40);
            this.buttonDeleteCategory.TabIndex = 7;
            this.buttonDeleteCategory.Text = "Delete";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(585, 429);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 37);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CategorySettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 478);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.labelCurrentCategorie);
            this.Controls.Add(this.listBoxCategories);
            this.Controls.Add(this.labelAddCategory);
            this.Name = "CategorySettingsForm";
            this.Text = "CategorySettingsForm";
            this.Load += new System.EventHandler(this.CategorySettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal void ShowDialog(HashSet<Category> categories)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Label labelCurrentCategorie;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonClose;
    }
}