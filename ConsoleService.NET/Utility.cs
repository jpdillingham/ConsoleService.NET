using System;

namespace ConsoleService.NET
{
    /// <summary>
    ///     Miscellaneous utility methods.
    /// </summary>
    internal static class Utility
    {
        /// <summary>
        ///     Determines whether the current platform is Windows using Environment.OSVersion.Platform.
        /// </summary>
        /// <returns>A value indicating whether the current platform is Windows.</returns>
        internal static bool IsWindows()
        {
            int p = (int)Environment.OSVersion.Platform;
            return !((p == 4) || (p == 6) || (p == 128));
        }

        /// <summary>
        ///     Installs or uninstalls the Windows Service using the included ProjectInstaller.
        /// </summary>
        /// <param name="action">If 'uninstall', uninstalls the service.  Any other string installs the service.</param>
        internal static void ModifyService(string action)
        {
            try
            {
                if (action == "install")
                {
                    System.Configuration.Install.ManagedInstallerClass.InstallHelper(new string[] { "/u", System.Reflection.Assembly.GetExecutingAssembly().Location });
                }
                else
                {
                    System.Configuration.Install.ManagedInstallerClass.InstallHelper(new string[] { System.Reflection.Assembly.GetExecutingAssembly().Location });
                }
            }
        }
    }
}