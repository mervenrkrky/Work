using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities.Concretes;

namespace Core
{
    public  class FileRead : IFileRead
    {
        public string Read(string path)
        {
            string readText = File.ReadAllText(path);
            return readText;
        }

        public string Read(Files file)
        {
            string fullFileName = file.Name + file.Extension;
            string path = Path.Combine(file.Directory, fullFileName);
            return Read(path);
        }
    }
}
