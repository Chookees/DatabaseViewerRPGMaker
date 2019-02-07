namespace GameFileViewer
{
    partial class WeaponDatabaseViewerW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponDatabaseViewerW));
            this.DataGridWeapon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridWeapon
            // 
            this.DataGridWeapon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWeapon.Location = new System.Drawing.Point(12, 12);
            this.DataGridWeapon.Name = "DataGridWeapon";
            this.DataGridWeapon.Size = new System.Drawing.Size(540, 426);
            this.DataGridWeapon.TabIndex = 0;
            this.DataGridWeapon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WeaponDatabaseViewerW_KeyDown);
            // 
            // WeaponDatabaseViewerW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.DataGridWeapon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponDatabaseViewerW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Database Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WeaponDatabaseViewerW_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWeapon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridWeapon;
    }
}