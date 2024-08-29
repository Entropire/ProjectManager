using ProjectManager.Forms;
using System.Security.Cryptography;

namespace ProjectManager
{
    internal static class Program
    {
        public static Action<Form>? UpdateForm;

        public static ProjectHandler ProjectHandlerInstance { get; private set; } = new ProjectHandler();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}