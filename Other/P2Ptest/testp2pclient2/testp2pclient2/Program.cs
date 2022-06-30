using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace testp2pclient2
{
    class Program
    {
        [DllImport(@"p2pclient.dll", EntryPoint = "Init", CallingConvention = CallingConvention.Cdecl)]
        extern static int Init(ref string ip, ushort port);
        public delegate void OnStreamConnect(int erro);
        public delegate void OnStreamBroken(int erro);
        [DllImport("p2pclient.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        extern static int Register(string localid, OnStreamConnect cb, OnStreamBroken sb);
        private static void OnConnect(int erro)
        {
        }
        private static void onBroken(int erro)
        {
        }
        static void Main(string[] args)
        {
            string ip = "127.0.0.1";
            ushort port = 122;
            int ret = Init(ref ip, port);
            OnStreamConnect render = new OnStreamConnect(OnConnect);
            OnStreamBroken render2 = new OnStreamBroken(onBroken);
            string localid = "11111111";
            Register(localid, render, render2);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
