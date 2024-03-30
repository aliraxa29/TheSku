using TheSku.Data;

namespace TheSku
{
    partial class frmUser
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
            label1 = new System.Windows.Forms.Label();
            radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            radCollapsiblePanel2 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)radTextBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel1).BeginInit();
            radCollapsiblePanel1.PanelContainer.SuspendLayout();
            radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel2).BeginInit();
            radCollapsiblePanel2.PanelContainer.SuspendLayout();
            radCollapsiblePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radTextBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 18);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // radTextBox1
            // 
            radTextBox1.Location = new System.Drawing.Point(3, 28);
            radTextBox1.Name = "radTextBox1";
            radTextBox1.Size = new System.Drawing.Size(100, 24);
            radTextBox1.TabIndex = 1;
            // 
            // radCollapsiblePanel1
            // 
            radCollapsiblePanel1.Location = new System.Drawing.Point(94, 12);
            radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            radCollapsiblePanel1.PanelContainer.Controls.Add(radTextBox1);
            radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(148, 70);
            radCollapsiblePanel1.Size = new System.Drawing.Size(150, 98);
            radCollapsiblePanel1.TabIndex = 2;
            radCollapsiblePanel1.ThemeName = "Windows8";
            // 
            // radCollapsiblePanel2
            // 
            radCollapsiblePanel2.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            radCollapsiblePanel2.HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Stretch;
            radCollapsiblePanel2.Location = new System.Drawing.Point(94, 116);
            radCollapsiblePanel2.Name = "radCollapsiblePanel2";
            // 
            // radCollapsiblePanel2.PanelContainer
            // 
            radCollapsiblePanel2.PanelContainer.Controls.Add(radTextBox2);
            radCollapsiblePanel2.PanelContainer.Size = new System.Drawing.Size(148, 70);
            radCollapsiblePanel2.Size = new System.Drawing.Size(150, 98);
            radCollapsiblePanel2.TabIndex = 2;
            radCollapsiblePanel2.ThemeName = "Windows8";
            radCollapsiblePanel2.VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Bottom;
            // 
            // radTextBox2
            // 
            radTextBox2.Location = new System.Drawing.Point(3, 28);
            radTextBox2.Name = "radTextBox2";
            radTextBox2.Size = new System.Drawing.Size(142, 24);
            radTextBox2.TabIndex = 1;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(radCollapsiblePanel2);
            Controls.Add(radCollapsiblePanel1);
            Controls.Add(label1);
            Name = "frmUser";
            Text = "User";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)radTextBox1).EndInit();
            radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel1).EndInit();
            radCollapsiblePanel1.ResumeLayout(false);
            radCollapsiblePanel2.PanelContainer.ResumeLayout(false);
            radCollapsiblePanel2.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radCollapsiblePanel2).EndInit();
            radCollapsiblePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radTextBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
    }
}