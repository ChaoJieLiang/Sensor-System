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
    public partial class ctl_fm_Main : Form
    {
        /* 创建ctl_fm_PN_List对象，用于对串口操作 */
        ctl_fm_PN_List obj_fm_PN_List = new ctl_fm_PN_List();

        public ctl_fm_Main()
        {
            InitializeComponent();
        }

        /* 点击菜单“退出”按钮，退出当前应用 */
        private void ctl_mn_LV2_Exit_Click(object sender, EventArgs e)
        {
            /* 关闭当前窗口 */
            this.Close();
        }

        /* 当前窗口关闭后的操作 */
        private void ctl_fm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* 关闭串口，关闭整个程序 */
            obj_fm_PN_List.func_Serial_Close();
            System.Environment.Exit(0);
        }
    }
}
