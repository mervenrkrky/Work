using Business;
using Core;
using Entities.Concretes;
using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {

            Files inputFile = new Files
            {
                Extension = ".sdx",
                Name = "SameInReverse",
                Directory = @"c:\odev\",
                Content = null
            };


            string content = Read(inputFile);

            Palindrom palindrom = new Palindrom();
            var result = palindrom.EnUzunPalindrom(content);

            Files outputFile = new Files
            {
                Extension = ".sdx",
                Name = "SameInReverseFound",
                Directory = @"c:\odev\",
                Content = result
            };

            Write(outputFile);

           
        }

        static string Read(Files file)
        {
            IFileRead fileRead = new FileRead();
            return fileRead.Read(file);
        }

        static void Write(Files file)
        {
            IFileWrite fileWrite = new FileWrite();
            fileWrite.Write(file);
        }
    }
}
