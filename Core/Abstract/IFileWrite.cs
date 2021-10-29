using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IFileWrite
    {
        void Write(Files file);
        void Write(string path, string context);
    }
}
