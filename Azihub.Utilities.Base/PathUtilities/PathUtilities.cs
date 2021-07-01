using System;
using System.Linq;

namespace Azihub.Utilities.Base.PathUtilities
{
    public static class PathUtilities
    {
        /// <summary>
        /// Remove N number of folder from right side of a path
        /// </summary>
        /// <param name="path">Pathname</param>
        /// <param name="folderCount">How many folder needed to be removed from right</param>
        /// <returns></returns>
        public static string RemoveFolder(string path, int folderCount)
        {
            char DS = System.IO.Path.DirectorySeparatorChar;
            return String.Join(DS, path.Split(DS).Reverse().Skip(folderCount).Reverse());
        }
    }
}
