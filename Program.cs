using System;
using System.Diagnostics;

namespace LaunchCustomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //using (Process ThisProcess = new Process())
                //{
                //    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\3_dotnet-runtime-6.0.32-win-x64.exe";
                //    ThisProcess.StartInfo.UseShellExecute = true;
                //    ThisProcess.Start();
                //    Console.WriteLine("Application 3 launched. Waiting for it to exit...");
                //    ThisProcess.WaitForExit();
                //}
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\ConsoleSetDevMode\net6.0\ConsoleSetDevMode.exe";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 4 launched. Waiting for it to exit...");
                    ThisProcess.WaitForExit();
                }
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\5_WindowsApplicationDriver_1.2.1.msi";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 5 launched. Waiting for it to exit...");
                    ThisProcess.WaitForExit();
                }
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 6 launched. Waiting for it to exit...");
                    //ThisProcess.WaitForExit();
                }
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\7_fabreasyPDFcreator-setup.exe";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 7 launched. Waiting for it to exit...");
                    ThisProcess.WaitForExit();
                }
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\Release\FabreasyImportSettings.exe";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 8 launched. Waiting for it to exit...");
                    ThisProcess.WaitForExit();
                }
                using (Process ThisProcess = new Process())
                {
                    ThisProcess.StartInfo.FileName = @"C:\Users\WDAGUtilityAccount\Desktop\SandboxTransfer\ConsoleCopyFiles\bin\Release\net6.0\ConsoleCopyFiles.exe";
                    ThisProcess.StartInfo.UseShellExecute = true;
                    ThisProcess.Start();
                    Console.WriteLine("Application 9 launched. Waiting for it to exit...");
                    ThisProcess.WaitForExit();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Pause the console to view the result
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            Console.WriteLine("Klaar");
            Thread.Sleep(2000);
        }
    }
}
