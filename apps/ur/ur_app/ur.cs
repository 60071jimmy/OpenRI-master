using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ur_app
{
    class ur
    {

        public static string[] IP = new string[2];

        [StructLayout(LayoutKind.Sequential)]
        public struct MotorData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] MotorAng;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public double[] URPose;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] MotorVolt;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] MotorTemp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public float[] MotorCurrent;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] digitalInputBits;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] digitalOutputBits;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] analogInputUnit;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] analogInput;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public int[] analogOutputUnit;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public double[] analogOutput;
        }

        public static MotorData[] aoiMotorData = new MotorData[2];

        #region 馬達編號
        public static int BASE = 0;
        public static int SHOULDER = 1;
        public static int ELBOW = 2;
        public static int WRIST1 = 3;
        public static int WRIST2 = 4;
        public static int WRIST3 = 5;
        #endregion

        #region pose編號
        public static int POSEX = 0;
        public static int POSEY = 1;
        public static int POSEZ = 2;
        public static int POSERX = 3;
        public static int POSERY = 4;
        public static int POSERZ = 5;
        #endregion

        #region UR手臂連線
        public static int LEFTHAND = 0;
        public static int RIGHTHAND = 1;
        #endregion

        public static bool connectAnotherUR = false;

        [DllImport("ur_dll.dll", EntryPoint = "Ur_urModel", CallingConvention = CallingConvention.Cdecl)]
        public static extern int urModel(IntPtr Handle);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_DrawUr", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DrawUr();

        [DllImport("ur_dll.dll", EntryPoint = "Ur_Connect", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Connect(int urSn, string ip);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_Init", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Init();

        [DllImport("ur_dll.dll", EntryPoint = "Ur_DisConnect", CallingConvention = CallingConvention.Cdecl)]
        public static extern int DisConnect(int urSn);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_Send", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Send(int urSn, string str, int len);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_Receive", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReceiveByte(int urSn);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_GetMotorData", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetMotorData(ref MotorData motorInfo, int urSn);

        [DllImport("ur_dll.dll", EntryPoint = "Ur_Close", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Close();

        public static void sendCmd(int i, string message)
        {
            int ret = ur.Send(i, message, message.Length);
            if (ret <= 0)
            {
                MessageBox.Show("Failed to send message");
            }
        }
    }
}
