using System.ComponentModel;

namespace ConsoleService.NET
{
    /// <summary>
    ///     The installer for the Service.
    /// </summary>
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ProjectInstaller"/> class.
        /// </summary>
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
