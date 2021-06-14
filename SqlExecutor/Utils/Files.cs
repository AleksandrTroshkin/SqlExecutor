using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExecutor.Utils
{
    public static class Files
    {
        public static IReadOnlyList<string> GetPaths(string[] filenames, string folder, bool subfolders)
        {
            if (string.IsNullOrEmpty(folder))
                return filenames;

            if (!subfolders)
                return Directory.GetFiles(folder, "*.sql");

            var folders = new List<string>();
            var subdirs = Directory.GetDirectories(folder);
            foreach (var item in subdirs)
                LoadSubFolders(item, folders);

            folders.Add(folder);

            var files = new List<string>();
            foreach (var item in folders)
                files.AddRange(Directory.GetFiles(item, "*.sql"));

            return files;
        }

        private static void LoadSubFolders(string dir, List<string> list)
        {
            var subfolders = Directory.GetDirectories(dir);
            list.AddRange(subfolders);
            foreach (string item in subfolders)
                LoadSubFolders(item, list);

            list.Add(dir);
        }
    }
}
