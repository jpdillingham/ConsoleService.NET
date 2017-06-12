using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleService.NET
{
    partial class ConsoleService : ServiceBase
    {
        #region Public Constructors

        public ConsoleService()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Protected Methods

        protected override void OnStart(string[] args)
        {
            // set the working directory for the application to the location of the executable. if this is not set here, the
            // application believes it is running from %windir%\system32\.
            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            Program.Start(args);
        }

        protected override void OnStop()
        {
            Program.Stop();
        }

        #endregion Protected Methods
    }
}