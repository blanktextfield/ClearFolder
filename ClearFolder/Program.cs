using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\mammu\samples";
            DeleteAllfiles();
            DirectoryInfo rootDirectory = new DirectoryInfo(rootpath);
            foreach (DirectoryInfo dir in rootDirectory.GetDirectories())
           
            {
                 DeleteAllfolders(dir.FullName, true);
            }


        }


        public static void DeleteAllfiles()
        {
            string rootpath = @"C:\Users\mammu\samples";
            DirectoryInfo directory = new DirectoryInfo(rootpath);
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
                
            }



        }
        public static void DeleteAllfolders(string directoryName, bool ifExists)
        {
            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);

            }else if (ifExists)
            {
                throw new SystemException("No such directory to delete");
            }

        }



    }



}
