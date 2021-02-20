using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinalProject.Utilities
{

    public static class Utilities
    {
        public static bool RemoveImage(string root, string image)
        {
            string path = Path.Combine(root, "img", image);
            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }

            return false;
        }
    }





















    //public static class Utilities
    //{

    //    public static void RemoveFile(string path, string existingImageName)
    //    {
    //        var fullPath = Path.Combine(path, existingImageName);
    //        if (File.Exists(fullPath))
    //            File.Delete(fullPath);
    //        else
    //            throw new FileNotFoundException("The file with name " + existingImageName + " not found!");
    //    }
    //}
}
