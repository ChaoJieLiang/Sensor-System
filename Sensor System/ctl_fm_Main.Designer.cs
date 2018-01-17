namespace Sensor_System
{
    partial class ctl_fm_Main
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
            this.ctl_mn_Main = new System.Windows.Forms.MenuStrip();
            this.ctl_mn_LV1_System = new System.Windows.Forms.ToolStripMenuItem();
            this.ctl_mn_LV2_OPMode = new System.Windows.Forms.ToolStripMenuItem();
            this.ctl_mn_LV2_ENMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctl_mn_LV2_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctl_mn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctl_mn_Main
            // 
            this.ctl_mn_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctl_mn_LV1_System});
            this.ctl_mn_Main.Location = new System.Drawing.Point(0, 0);
            this.ctl_mn_Main.Name = "ctl_mn_Main";
            this.ctl_mn_Main.Size = new System.Drawing.Size(1011, 25);
            this.ctl_mn_Main.TabIndex = 0;
            // 
            // ctl_mn_LV1_System
            // 
            this.ctl_mn_LV1_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctl_mn_LV2_OPMode,
            this.ctl_mn_LV2_ENMode,
            this.toolStripMenuItem1,
            this.ctl_mn_LV2_Exit});
            this.ctl_mn_LV1_System.Name = "ctl_mn_LV1_System";
            this.ctl_mn_LV1_System.Size = new System.Drawing.Size(61, 21);
            this.ctl_mn_LV1_System.Text = "System";
            // 
            // ctl_mn_LV2_OPMode
            // 
            this.ctl_mn_LV2_OPMode.Name = "ctl_mn_LV2_OPMode";
            this.ctl_mn_LV2_OPMode.Size = new System.Drawing.Size(132, 22);
            this.ctl_mn_LV2_OPMode.Text = "OP Mode";
            // 
            // ctl_mn_LV2_ENMode
            // 
            this.ctl_mn_LV2_ENMode.Name = "ctl_mn_LV2_ENMode";
            this.ctl_mn_LV2_ENMode.Size = new System.Drawing.Size(132, 22);
            this.ctl_mn_LV2_ENMode.Text = "EN Mode";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // ctl_mn_LV2_Exit
            // 
            this.ctl_mn_LV2_Exit.Name = "ctl_mn_LV2_Exit";
            this.ctl_mn_LV2_Exit.Size = new System.Drawing.Size(132, 22);
            this.ctl_mn_LV2_Exit.Text = "Exit";
            this.ctl_mn_LV2_Exit.Click += new System.EventHandler(this.ctl_mn_LV2_Exit_Click);
            // 
            // ctl_fm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 567);
            this.Controls.Add(this.ctl_mn_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ctl_mn_Main;
            this.MaximizeBox = false;
            this.Name = "ctl_fm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senser System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ctl_fm_Main_FormClosed);
            this.ctl_mn_Main.ResumeLayout(false);
            this.ctl_mn_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ctl_mn_Main;
        private System.Windows.Forms.ToolStripMenuItem ctl_mn_LV1_System;
        private System.Windows.Forms.ToolStripMenuItem ctl_mn_LV2_OPMode;
        private System.Windows.Forms.ToolStripMenuItem ctl_mn_LV2_ENMode;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctl_mn_LV2_Exit;
    }
}