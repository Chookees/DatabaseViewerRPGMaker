namespace GameFileViewer
{
    partial class DatabaseViewerS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewerS));
            this.DataGridSkill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSkill
            // 
            this.DataGridSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSkill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridSkill.Location = new System.Drawing.Point(12, 12);
            this.DataGridSkill.Name = "DataGridSkill";
            this.DataGridSkill.Size = new System.Drawing.Size(538, 426);
            this.DataGridSkill.TabIndex = 0;
            // 
            // DatabaseViewerS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.DataGridSkill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewerS";
            this.Text = "Skills Database Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatabaseViewerS_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSkill;
    }
}