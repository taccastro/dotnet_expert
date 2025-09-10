using System.Diagnostics;

namespace DevFreela.API
{
    public static class LocalDbHelper
    {
        public static void StartLocalDb()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "sqllocaldb",
                    Arguments = "start MSSQLLocalDB",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}
