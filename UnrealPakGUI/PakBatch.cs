using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnrealPakGUI
{
    class PakBatch
    {
        public string CommonPath { get; private set; }

        public string BatchNodeText
        {
            get
            {
                return CommonPath + $" - {FilesPrivate.Count} Files";
            }
        }

        public string[] Files
        {
            get { return FilesPrivate.ToArray(); }
        }

        private string OutputPathPrivate;
        public string OutputPath
        {
            get
            {
                return OutputPathPrivate;
            }
            set
            {
                if (value.EndsWith(".pak"))
                {
                    OutputPathPrivate = value;
                }
                else
                {
                    OutputPathPrivate = value + Path.GetFileNameWithoutExtension(Path.GetDirectoryName(CommonPath)) + ".pak";
                }
            }
        }

        private List<string> FilesPrivate;

        public PakBatch(string[] InFileNames)
        {
            FilesPrivate = new List<string>();
            foreach (string FileName in InFileNames)
            {
                if (Directory.Exists(FileName))
                {
                    foreach (string SubFileName in Directory.EnumerateFiles(FileName, "*.*", SearchOption.AllDirectories))
                    {
                        FilesPrivate.Add(SubFileName);
                    }
                }
                else
                {
                    FilesPrivate.Add(FileName);
                }
            }
            CommonPath = GetCommonRootPath(InFileNames);
        }

        public static string GetCommonRootPath(string[] FileNames)
        {
            if (FileNames.Length == 1 && Directory.Exists(FileNames[0]))
            {
                return FileNames[0];
            }
            string Root = GetLongestPath(FileNames).Normalize();
            for (int FileIndex = 0; FileIndex < FileNames.Length && Root.Length > 0; FileIndex++)
            {
                string FileName = FileNames[FileIndex];
                string FilePath = Path.GetDirectoryName(FileName) + @"\";
                int CommonSeparatorIndex = -1;
                int SeparatorIndex = FilePath.IndexOf(@"\");
                while (SeparatorIndex >= 0)
                {
                    if (string.Compare(Root, 0, FilePath, 0, SeparatorIndex + 1) != 0)
                    {
                        break;
                    }
                    CommonSeparatorIndex = SeparatorIndex;
                    if (CommonSeparatorIndex + 1 < FilePath.Length)
                    {
                        SeparatorIndex = FilePath.IndexOf(@"\", CommonSeparatorIndex + 1);
                    }
                    else
                    {
                        break;
                    }
                }
                if ((CommonSeparatorIndex + 1) < Root.Length)
                {
                    Root = Root.Substring(0, CommonSeparatorIndex + 1);
                }
            }
            return Root.Normalize();
        }

        public static string GetLongestPath(string[] FileNames)
        {
            string LongestPath = string.Empty;
            int MaxNumDirectories = 0;

            for (int FileIndex = 0; FileIndex < FileNames.Length; FileIndex++)
            {
                string FileName = FileNames[FileIndex];
                int NumDirectories = 0;
                for (int Index = 0; Index < FileName.Length; Index++)
                {
                    if (FileName[Index] == '\\')
                    {
                        NumDirectories++;
                    }
                }
                if (NumDirectories > MaxNumDirectories)
                {
                    LongestPath = FileName;
                    MaxNumDirectories = NumDirectories;
                }
            }
            return Path.GetDirectoryName(LongestPath) + @"\";
        }
    }
}
