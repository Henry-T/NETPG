using System;
using System.IO;

namespace UpdateAllSVN  
{
    public class Program
    {
        public static int Main(string[] args)
        {

            foreach (var driveInfo in DriveInfo.GetDrives())
            {
                DirectoryInfo rootDirInfo = driveInfo.RootDirectory;
                ProcesDirRecursivly(rootDirInfo, 3);
            }
        }

        public static void ProcesDirRecursivly(DirectoryInfo dirInfo, int depth)
        {
            if (IsSVNDir(dirInfo.FullName))
                UpdateSVNDir(dirInfo.FullName);
            else
            {
                if (depth > 0)
                {
                    foreach (var subDirInfo in dirInfo.GetDirectories())
                    {
                        ProcesDirRecursivly(subDirInfo, depth - 1)

                    }
                }
            }
        }


        public static bool IsSVNDir(string dir)
        {
            // todo 
            return true

        }

        public static int UpdateSVNDir(string dir)
        {
            svn.update(dir);
            return 0;
        }
    }
}

