using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleService.NET
{
    internal class Program
    {
        #region Internal Methods

        internal static void Start(string[] args)
        {
            Console.WriteLine("Started!");
        }

        internal static void Stop()
        {
            Console.WriteLine("Stopped.");
        }

        #endregion Internal Methods

        #region Private Methods

        /// <summary>
        ///     Installs or uninstalls the application as a Windows Service, depending on the provided action.
        /// </summary>
        /// <param name="action">The action to perform (uninstall or install).</param>
        /// <returns>True if the installation/uninstallation succeeded, false otherwise.</returns>
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static bool ModifyService(string action)
        {
            try
            {
                if (action == "uninstall")
                {
                    System.Configuration.Install.ManagedInstallerClass.InstallHelper(new string[] { "/u", System.Reflection.Assembly.GetExecutingAssembly().Location });
                }
                else
                {
                    System.Configuration.Install.ManagedInstallerClass.InstallHelper(new string[] { System.Reflection.Assembly.GetExecutingAssembly().Location });
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "install")
                {
                    ModifyService("install");
                }
                else if (args[0] == "uninstall")
                {
                    ModifyService("uninstall");
                }
            }

            Start(args);

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

            Stop();
        }

        #endregion Private Methods
    }
}