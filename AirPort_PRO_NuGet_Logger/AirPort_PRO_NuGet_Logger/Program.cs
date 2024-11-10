using AirPort_PRO_NuGet_Logger.AirPortManager;
using DataGridAirPort.Storage.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace AirPort_PRO_NuGet_Logger
{
    /// <summary>
    /// Главный класс приложения, содержащий точку входа
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var factory = LoggerFactory.Create(builder => builder.AddDebug());
            var logger = factory.CreateLogger(nameof(DataGrid));

            var storage = new MemoryAirPlaneStorage();
            var manager = new PlaneManager_cs(storage, logger);

            Application.Run(new Form1(manager));
        }
    }
}
