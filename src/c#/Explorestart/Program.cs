using System.Diagnostics;

namespace Explorestart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] ExplorerProcess = Process.GetProcessesByName("explorer");
            foreach (Process p in ExplorerProcess)
            {
                p.Kill();
            }
            ExplorerProcess = Process.GetProcessesByName("explorer");
            if (ExplorerProcess.Length == 0)
            {
                Process.Start("explorer.exe");
            }
        }
    }
}