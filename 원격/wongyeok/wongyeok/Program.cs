using System;
using System.ServiceProcess;
using System.Windows.Forms;

namespace wongyeok
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>        /// 
        [STAThread]
        static void Main()
        {            
            Application.Run(new MainForm());

           // ServiceBase[] ServicesToRun;
           // ServicesToRun = new ServiceBase[]
           // {
           //     
           // };
           // ServiceBase.Run(ServicesToRun);
        }
    }
}
