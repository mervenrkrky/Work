using Entities.Concretes;
using System.IO;
using System;

namespace Core
{
    public class FileWrite : IFileWrite
    {
        public void Write(string path, string content)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, content);
            }
        }

        public void Write(Files file)
        {
            string fullFileName = file.Name + file.Extension;
            string path = Path.Combine(file.Directory, fullFileName);

            this.Write(path, file.Content);
        }
    }
}
