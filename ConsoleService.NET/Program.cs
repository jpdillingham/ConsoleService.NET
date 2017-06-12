using System;
using System.ServiceProcess;

namespace ConsoleService.NET
{
    internal class Program
    {
        #region Internal Methods

        internal static void Start(string[] args)
        {
            Console.WriteLine("Started!");

            // do stuff here
        }

        internal static void Stop()
        {
            Console.WriteLine("Stopped.");
        }

        #endregion Internal Methods

        #region Private Methods

        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "install")
                {
                    Utility.ModifyService("install");
                }
                else if (args[0] == "uninstall")
                {
                    Utility.ModifyService("uninstall");
                }
            }

            if (Utility.IsWindows() && (!Environment.UserInteractive))
            {
                ServiceBase.Run(new Service());
            }
            else
            {
                Start(args);
                Stop();
            }
        }

        #endregion Private Methods
    }
}