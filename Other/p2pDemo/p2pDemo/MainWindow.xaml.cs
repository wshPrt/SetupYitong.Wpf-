using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace p2pDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public  partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            txtSendTwo.Text = "1.输入自己的ID" + "\r\n" 
                               + "2.点击注册" + "\r\n" + "3.输入对方的ID" + "\r\n" 
                               +"4.点击P2P链接" + "\r\n" + "5.点击发送模拟视频帧按钮";
        }
            /// <summary>
            /// 初始化程序
            /// </summary>
            /// <param name="ip">ip为服务器IP</param>
            /// <param name="port">port为服务器port</param>
            /// <returns></returns>
            [DllImport(@"p2pclient.dll", EntryPoint = "Init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            extern static int Init(string ip, ushort port);
            [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.StdCall)]
            public delegate void OnStreamConnect(int erro);
            public delegate void OnStreamBroken(int erro);

            /// <summary>
            /// 注册程序
            /// </summary>
            /// <param name="localid">客户端id</param>
            /// <param name="cb">cb链接成功函数指针</param>
            /// <param name="sb">sb 链接失败函数指针</param>
            /// <returns></returns>
            [DllImport("p2pclient.dll", EntryPoint = "Register", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern int Register(string localid, OnStreamConnect cb, OnStreamBroken sb);

            /// <summary>
            /// 开始p2p链接
            /// </summary>
            /// <param name="otherSide">对方id</param>
            /// <param name="savefolder">保存接受文件的路径，绝对路径</param>
            /// <param name="pd">OnP2pTsFaildp2p链接回掉</param>
            /// <returns></returns>
            [DllImport(@"p2pclient.dll", EntryPoint = "Connect", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern int Connect(string otherSide, string savefolder, OnP2pTsFaild pb);
            public delegate void OnP2pTsFaild(int erro);
            [DllImport("p2pclient.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "setSaveFolder", CharSet = CharSet.Ansi)]
            extern static int setSaveFolder(string savefolder);
            /// <summary>
            /// 传输文件
            /// </summary>
            /// <param name="FileName">要传送的文件名;绝对路径</param>
            /// <param name="fd">fb文件发送回到函数指针</param>
            /// <returns></returns>
            [DllImport(@"p2pclient.dll", EntryPoint = "TransferFile", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern int TransferFile(string FileName, FileTransmitDone fd);
            public delegate void FileTransmitDone(int erro);
            /// <summary>
            /// 停止程序
            /// </summary>
            /// <returns></returns>
            [DllImport(@"p2pclient.dll", EntryPoint = "Stop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public static extern int Stop();


            private static void OnConnect(int erro)
            {

            }
            private static void onBroken(int erro)
            {

            }
            private static void OnFaild(int erro)
            {

            }
            private static void filetransmitdone(int erro)
            {

            }
            OnStreamConnect render = new OnStreamConnect(OnConnect);
            OnStreamBroken render2 = new OnStreamBroken(onBroken);
            OnP2pTsFaild onP2P = new OnP2pTsFaild(OnFaild);
            FileTransmitDone fileDone = new FileTransmitDone(TransmitDone);
 

            private void txtRegister_Click(object sender, RoutedEventArgs e)
            {
                App.Current.MainWindow.Dispatcher.Invoke(new Action(() =>
                {
                    try
                    {
                        string _ip = "114.55.233.160";
                        ushort _port = 6001;
                        if (!string.IsNullOrEmpty(_ip))
                        {
                            int ret = Init(_ip, _port);
                            LogHelper.WriteLog("Init ====>" + _ip + _port);

                            string localID = txtUser.Text.Trim().ToString();
                            Register(localID, render, render2);
                            LogHelper.WriteLog("Register ====>" + localID + render + render2);
                            MessageBox.Show("注册成功！");
                            string _path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "flie";
                            LogHelper.WriteLog("接收文件夹 :" + _path);
                            if (!Directory.Exists(_path))
                            {
                                Directory.CreateDirectory(_path);
                                LogHelper.WriteLog("创建文件夹 :" + _path);
                            }
                            setSaveFolder(_path);
                        }
                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("错误" + ex.ToString());
                        LogHelper.WriteLog("错误日志记录! Register错误", ex);
                    }
                }));
            }


            private async void btnStartP2P_Click(object sender, RoutedEventArgs e)
            {
                App.Current.MainWindow.Dispatcher.Invoke(new Action(() =>
                {
                    try
                    {

                        //创建文件夹
                        string _path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "flie";
                        if (!Directory.Exists(_path))
                        {
                            Directory.CreateDirectory(_path);
                            LogHelper.WriteLog("创建文件夹 :" + _path);
                        }
                        Connect(txtRemote.Text.Trim().ToString(), _path, onP2P);
                        LogHelper.WriteLog("Connect :" + txtRemote.Text.Trim().ToString() + _path + onP2P);
                        MessageBox.Show("P2P连接成功！");
                    }
                    catch (Exception ex)
                    {
                        LogHelper.WriteLog("错误日志记录! P2P连接错误", ex);
                        //MessageBox.Show("错误" + ex.ToString());
                    }
                }));
            }

            private static void TransmitDone(int erro)
            {
            }
            private async void btnSendFile_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    var openFileDialog = new Microsoft.Win32.OpenFileDialog()
                    {
                        Filter = "Files|*.*;*.*"
                    };
                    LogHelper.WriteLog("openFileDialog :" + openFileDialog.ToString());
                    var result = openFileDialog.ShowDialog();
                    if (result == true)
                    {
                        var _fileName = openFileDialog.FileName.Trim();

                        await Task.Run(() =>
                        {
                            TransferFile(_fileName, fileDone);
                            LogHelper.WriteLog("传输文件 :" + _fileName.ToString() +"====" +fileDone);
                        });
                        MessageBox.Show("文件发送成功！");
                        //Stop();
                        //LogHelper.WriteLog("Stop");
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteLog("TransferFile 错误" + ex);
                }

            }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    }
