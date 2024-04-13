namespace TheSku
{
    partial class frmNameEditor
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
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            txtOldName = new Telerik.WinControls.UI.RadTextBox();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            txtNewName = new Telerik.WinControls.UI.RadTextBox();
            btnRename = new Telerik.WinControls.UI.RadButton();
            btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOldName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNewName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRename).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radLabel1.Location = new System.Drawing.Point(12, 54);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new System.Drawing.Size(45, 21);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Name:";
            radLabel1.ThemeName = "Windows8";
            // 
            // txtOldName
            // 
            txtOldName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtOldName.Location = new System.Drawing.Point(93, 51);
            txtOldName.Name = "txtOldName";
            txtOldName.ReadOnly = true;
            txtOldName.Size = new System.Drawing.Size(259, 27);
            txtOldName.TabIndex = 1;
            txtOldName.TabStop = false;
            txtOldName.ThemeName = "Windows8";
            // 
            // radLabel2
            // 
            radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            radLabel2.Location = new System.Drawing.Point(143, 12);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new System.Drawing.Size(72, 21);
            radLabel2.TabIndex = 0;
            radLabel2.Text = "Edit Name";
            radLabel2.ThemeName = "Windows8";
            // 
            // radLabel3
            // 
            radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radLabel3.Location = new System.Drawing.Point(12, 87);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new System.Drawing.Size(75, 21);
            radLabel3.TabIndex = 0;
            radLabel3.Text = "New Name:";
            radLabel3.ThemeName = "Windows8";
            // 
            // txtNewName
            // 
            txtNewName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNewName.Location = new System.Drawing.Point(93, 84);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new System.Drawing.Size(259, 27);
            txtNewName.TabIndex = 0;
            txtNewName.ThemeName = "Windows8";
            // 
            // btnRename
            // 
            btnRename.Location = new System.Drawing.Point(126, 133);
            btnRename.Name = "btnRename";
            btnRename.Size = new System.Drawing.Size(110, 24);
            btnRename.TabIndex = 1;
            btnRename.Text = "Rename";
            btnRename.ThemeName = "Windows8";
            btnRename.Click += btnRename_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(242, 133);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 24);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.ThemeName = "Windows8";
            // 
            // frmNameEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(364, 169);
            Controls.Add(btnCancel);
            Controls.Add(btnRename);
            Controls.Add(txtNewName);
            Controls.Add(txtOldName);
            Controls.Add(radLabel3);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNameEditor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit Name";
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOldName).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNewName).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRename).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtOldName;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtNewName;
        private Telerik.WinControls.UI.RadButton btnRename;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}