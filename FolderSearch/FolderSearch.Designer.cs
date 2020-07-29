namespace FolderSearch
{
    partial class SongScoutForm
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
            this.SearchCriteria = new System.Windows.Forms.TextBox();
            this.MatchingFoldersListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchCriteria
            // 
            this.SearchCriteria.AccessibleDescription = "Search Criteria Textbox";
            this.SearchCriteria.AccessibleName = "SearchCriteriaTextbox";
            this.SearchCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCriteria.Location = new System.Drawing.Point(30, 36);
            this.SearchCriteria.Name = "SearchCriteria";
            this.SearchCriteria.Size = new System.Drawing.Size(367, 23);
            this.SearchCriteria.TabIndex = 0;
            this.SearchCriteria.Enter += new System.EventHandler(this.SearchCriteria_Enter);
            this.SearchCriteria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCriteria_KeyDown);
            this.SearchCriteria.Leave += new System.EventHandler(this.SearchCriteria_Leave);
            // 
            // MatchingFoldersListbox
            // 
            this.MatchingFoldersListbox.AccessibleDescription = "Matching Folders Listbox";
            this.MatchingFoldersListbox.AccessibleName = "MatchingFoldersListbox";
            this.MatchingFoldersListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchingFoldersListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchingFoldersListbox.FormattingEnabled = true;
            this.MatchingFoldersListbox.ItemHeight = 16;
            this.MatchingFoldersListbox.Location = new System.Drawing.Point(30, 98);
            this.MatchingFoldersListbox.Name = "MatchingFoldersListbox";
            this.MatchingFoldersListbox.Size = new System.Drawing.Size(367, 340);
            this.MatchingFoldersListbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Search Criteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matching Folders List";
            // 
            // SongScoutForm
            // 
            this.AccessibleDescription = "Song Scout Search Form";
            this.AccessibleName = "SongScoutForm";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatchingFoldersListbox);
            this.Controls.Add(this.SearchCriteria);
            this.Name = "SongScoutForm";
            this.Text = "Song Scout";
            this.Load += new System.EventHandler(this.FolderSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchCriteria;
        private System.Windows.Forms.ListBox MatchingFoldersListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

