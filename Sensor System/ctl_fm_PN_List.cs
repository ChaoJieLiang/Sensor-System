using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sensor_System
{
    public partial class ctl_fm_PN_List : Form
    {
        public ctl_fm_PN_List()
        {
            InitializeComponent();
        }

        /* Enter按钮的点击事件 */
        private void ctl_bt_Enter_Main_Click(object sender, EventArgs e)
        {
            /* 创建ctl_fm_Main对象 */
            Form obj_fm_Main = new ctl_fm_Main();
           
            /* 当串口正确初始化后，显示主界面，隐藏产品列表界面 */
            /* 当串口未正确初始化，保持当前界面，"Enter"按钮变灰 */
            if (func_Open_Serial_Port())
            {
                obj_fm_Main.Show();
                this.Hide();
            }
            else
            {
                ctl_bt_Enter_Main.Enabled = false;
            }
        }

        /* ctl_fm_PN_List界面关闭后的事件 */
        private void ctl_fm_PN_List_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* 串口关闭，系统退出 */
            func_Serial_Close();
            Application.Exit();
        }

        /* ctl_fm_PN_List串口加载时间 */
        private void ctl_fm_PN_List_Load(object sender, EventArgs e)
        {
            /* 获取串口列表 */
            func_Serial_Get_List();
        }

        /* 串口列表选择切换事件 */
        private void ctl_cmb_Com_Ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 使能"Enter"按钮 */
            ctl_bt_Enter_Main.Enabled = true;
        }
    }
}
