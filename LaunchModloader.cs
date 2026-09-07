using System;

// wahoo first program
namespace tModLoaderLauncher
{
    class Program
    {
        public static void Main()
        {
            // man how the FUCK did this break on steam?

            string path = @"C:\\Program Files (x86)\Steam\steamapps\common\tModLoader\start-tModLoader.bat";
            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                // motherfucker please work i beg aefouhagdehuofgeahuoarfwehuo

                process.StartInfo.FileName = path;
                process.StartInfo.UseShellExecute = true;
                process.Start();
            }
        }
    }
}