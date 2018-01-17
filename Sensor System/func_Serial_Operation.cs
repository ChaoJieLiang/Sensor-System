using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO.Ports;

namespace Sensor_System
{
    public partial class ctl_fm_PN_List
    {
        static string pStr_Reg_LocalMachine = "Hardware\\DeviceMap\\SerialComm";
        private SerialPort sp_Comm = new SerialPort();

        /* 获取串口列表函数 */
        private void func_Serial_Get_List()
        {
            //Get register value from "Hardware\\DeviceMap\\SerialComm"
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(pStr_Reg_LocalMachine);
            if (keyCom != null)
            {
                string[] str_SubKeys = keyCom.GetValueNames();
                /* 串口列表清空 */
                this.ctl_cmb_Com_Ports.Items.Clear();
                /* 遍历串口列表，将串口号添加到下拉列表框中 */
                foreach (string str_Name in str_SubKeys)
                {
                    string str_Value = (string)keyCom.GetValue(str_Name);
                    this.ctl_cmb_Com_Ports.Items.Add(str_Value);
                }
            }
        }

        /* 串口开关函数 */
        private bool func_Open_Serial_Port()
        {
            /* 当串口被占用时，提示用户 */
            if (sp_Comm.IsOpen)
            {
                func_Serial_Close();
                MessageBox.Show("Serial port is used.");
                return false;
            }
            /* 未被占用的情况，初始化串口 */
            else
            {
                sp_Comm.PortName    = ctl_cmb_Com_Ports.Text;
                sp_Comm.BaudRate    = 9600;
                sp_Comm.DataBits    = 8;
                sp_Comm.Parity      = Parity.None;
                sp_Comm.StopBits    = StopBits.One;
                sp_Comm.ReadTimeout = 200;
                try
                {
                    func_Serial_Open();
                    return true;
                }
                /* 如出现异常，提示 */
                catch(Exception)
                {
                    MessageBox.Show("Serial port open failed.");
                    return false;
                }
            }
        }

        /* 串口开启函数 */
        private void func_Serial_Open()
        {
            sp_Comm.Open();
        }

        /* 串口关闭函数 */
        public void func_Serial_Close()
        {
            sp_Comm.Close();
        }
    }
}
