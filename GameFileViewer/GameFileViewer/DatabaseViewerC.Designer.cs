namespace GameFileViewer
{
    partial class DatabaseViewerC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseViewerC));
            this.DataGridClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridClass
            // 
            this.DataGridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridClass.Location = new System.Drawing.Point(12, 12);
            this.DataGridClass.Name = "DataGridClass";
            this.DataGridClass.Size = new System.Drawing.Size(569, 426);
            this.DataGridClass.TabIndex = 0;
            this.DataGridClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatabaseViewerC_KeyDown);
            // 
            // DatabaseViewerC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.DataGridClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatabaseViewerC";
            this.Text = "Class Database Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DatabaseViewerC_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridClass;
    }
}