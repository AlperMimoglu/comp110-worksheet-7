using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_7
{
    public static class DirectoryUtils
    {
        // Return the size, in bytes, of the given file
        public static long GetFileSize(string filePath)
        {
            Int64 size = GetFileSize(filePath);
            return Int64;
        }

        // Return true if the given path points to a directory, false if it points to a file
        public static bool IsDirectory(string path)
        {
            return File.GetAttributes(Object).HasFlag(FileAttributes.Directory);
        }

        // Return the total size, in bytes, of all the files below the given directory
        public static long GetTotalSize(string directory)
        {
            Int64 size = 0;
            string[] file = Directory.GetFileSystemEntries(directory);
            for (int s = 0; file.Length > s; s++)
            {
                if (IsDirectory(file[s]) == true)
                {
                    size += GetTotalSize(file[s]);
                }
                else
                {
                    size += GetFileSize(file[s]);
                }
            }
            return size;
        }

        // Return the number of files (not counting directories) below the given directory
        public static int CountFiles(string directory)
        {
            int number_of_files = 0;
            string[] folder = Directory.GetDirectories(directory);
            for (int s = 0; folder.Length > s; s++)
            {
                number_of_files += CountFiles(folder[s]);
            }
            return number_of_files;
        }

        // Return the nesting depth of the given directory. A directory containing only files (no subdirectories) has a depth of 0.
        public static int GetDepth(string directory)
        {
            int depth = 0;
            string[] array = Directory.GetDirectories(directory);
            bool loop = true;
            for (int s = 0; folder.Length > s; s++)
            {
                if (folder.Length >= 1)
                {
                    depth += 1;
                    folder = Directory.GetDirectories(folder[s]);
                }
            }
            return depth;
        }

        // Get the path and size (in bytes) of the smallest file below the given directory
        public static Tuple<string, long> GetSmallestFile(string directory)
        {
            long Smallest_byte = 9223372036854775807;
            string Location_of_file = "";
            string file = Directory.GetFileSystemEntries(directory);
            for (int s = 0; file.Length > s; s++)
            {
                if (IsDirectory(file[s]) == true)
                {
                    Location_of_file && Smallest_byte = GetSmallestFile(file[s]);
                }
                else if (GetFileSize(file[s]) < Smallest_byte)
                {
                    Smallest_byte = GetFileSize(file[s]);
                    Location_of_file = file[s];

                }
            }
            return Smallest_byte;
        }
    

    // Get the path and size (in bytes) of the largest file below the given directory
    public static Tuple<string, long> GetLargestFile(string directory)
    {
            long Largest_byte = 0;
            string Location_of_file = "";
            string file = Directory.GetFileSystemEntries(directory);
            for (int s = 0; file.Length > s; s++)
            {
                if (IsDirectory(file[s]) == true)
                {
                    Location_of_file && Largest_byte = GetLargestFile(file[s]);
                }
                else if (GetFileSize(file[s]) < Largest_byte)
                {
                    Largest_byte = GetFileSize(file[s]);
                    Location_of_file = file[s];

                }
            }
            return Largest_byte;
        }

    // Get all files whose size is equal to the given value (in bytes) below the given directory
    public static IEnumerable<string> GetFilesOfSize(string directory, long size)
    {
            string[] same_file_size;     
            string[] file = Directory.GetFileSystemEntries(directory);     
            for (int s = 0; file.Length > s; s++)     
            {
                if (IsDirectory(file[s]) == true)     
                {
                    same_file_size_plus = GetFileSystemEntries(file[s]);     
                    same_file_size.Add(same_file_size_plus);     

                }
                else     
                {
                    if (GetFileSize(file[s]) = size)    
                    {
                        same_file_size.Add(file[s]);     
                    }
                }
            }
            return same_file_size;     
        }
    }
}


