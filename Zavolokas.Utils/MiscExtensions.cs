using System.Diagnostics;
using System.IO;

namespace Zavolokas
{
    public static class MiscExtensions
    {
        public static void ShowFile(this FileInfo fileInfo)
        {
            if (!fileInfo.Exists)
                throw new FileNotFoundException($"File \"{fileInfo.Name}\" doesn't exist.", fileInfo.FullName);

            Process.Start(fileInfo.FullName);
        }
    }
}