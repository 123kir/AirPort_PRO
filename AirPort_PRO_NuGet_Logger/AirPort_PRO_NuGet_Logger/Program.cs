using AirPort_PRO_NuGet_Logger.PlaneManager;
using AirPort_PRO_NuGet_Logger.Storage.Memory;
using System;
using System.Windows.Forms;

namespace DataGridAirPort
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

            var storage = new MemoryAirPlaneStorage();
            var manager = new PlaneManager(storage);

            Application.Run(new Form1(manager));
        }
    }
}
