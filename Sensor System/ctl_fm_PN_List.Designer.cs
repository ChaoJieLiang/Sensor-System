namespace Sensor_System
{
    partial class ctl_fm_PN_List
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ctl_cmb_PN_List = new System.Windows.Forms.ComboBox();
            this.ctl_bt_Enter_Main = new System.Windows.Forms.Button();
            this.ctl_cmb_Com_Ports = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ctl_cmb_PN_List
            // 
            this.ctl_cmb_PN_List.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctl_cmb_PN_List.FormattingEnabled = true;
            this.ctl_cmb_PN_List.Items.AddRange(new object[] {
            "SM-UART-01L/01L+/02L",
            "SM-UART-03L",
            "SM-UART-01D/02D/03D"});
            this.ctl_cmb_PN_List.Location = new System.Drawing.Point(29, 21);
            this.ctl_cmb_PN_List.Name = "ctl_cmb_PN_List";
            this.ctl_cmb_PN_List.Size = new System.Drawing.Size(156, 20);
            this.ctl_cmb_PN_List.TabIndex = 0;
            this.ctl_cmb_PN_List.Text = "SM-UART-01L/01L+/02L";
            // 
            // ctl_bt_Enter_Main
            // 
            this.ctl_bt_Enter_Main.Enabled = false;
            this.ctl_bt_Enter_Main.Location = new System.Drawing.Point(29, 86);
            this.ctl_bt_Enter_Main.Name = "ctl_bt_Enter_Main";
            this.ctl_bt_Enter_Main.Size = new System.Drawing.Size(156, 23);
            this.ctl_bt_Enter_Main.TabIndex = 1;
            this.ctl_bt_Enter_Main.Text = "Enter";
            this.ctl_bt_Enter_Main.UseVisualStyleBackColor = true;
            this.ctl_bt_Enter_Main.Click += new System.EventHandler(this.ctl_bt_Enter_Main_Click);
            // 
            // ctl_cmb_Com_Ports
            // 
            this.ctl_cmb_Com_Ports.FormattingEnabled = true;
            this.ctl_cmb_Com_Ports.Location = new System.Drawing.Point(29, 54);
            this.ctl_cmb_Com_Ports.Name = "ctl_cmb_Com_Ports";
            this.ctl_cmb_Com_Ports.Size = new System.Drawing.Size(156, 20);
            this.ctl_cmb_Com_Ports.TabIndex = 2;
            this.ctl_cmb_Com_Ports.SelectedIndexChanged += new System.EventHandler(this.ctl_cmb_Com_Ports_SelectedIndexChanged);
            // 
            // ctl_fm_PN_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 131);
            this.Controls.Add(this.ctl_cmb_Com_Ports);
            this.Controls.Add(this.ctl_bt_Enter_Main);
            this.Controls.Add(this.ctl_cmb_PN_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ctl_fm_PN_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PN Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ctl_fm_PN_List_FormClosed);
            this.Load += new System.EventHandler(this.ctl_fm_PN_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ctl_cmb_PN_List;
        private System.Windows.Forms.Button ctl_bt_Enter_Main;
        private System.Windows.Forms.ComboBox ctl_cmb_Com_Ports;
    }
}

