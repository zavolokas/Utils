using System.Diagnostics;
using System.IO;

namespace Zavolokas.Utils.Processes
{
    public static class FilesExtensions
    {
        /// <summary>
        /// Executes the file.
        /// </summary>
        /// <param name="fileInfo">The file information.</param>
        /// <exception cref="FileNotFoundException"></exception>
        public static void ShowFile(this FileInfo fileInfo)
        {
            if (!fileInfo.Exists)
                throw new FileNotFoundException($"File \"{fileInfo.Name}\" doesn't exist.", fileInfo.FullName);

            Process.Start(new ProcessStartInfo("cmd", $"/c start {fileInfo.FullName}"));
        }
    }
}