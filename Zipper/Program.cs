using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zipper
{
  class Program
  {
    static void Main(string[] args)
    {
#if DEBUG
      string root = @"D:\Projekti\mojMarket\SLIKE_ZA_SAJT\obradjene web";
      int filesPerZip = 30;
      string moveTo = @"D:\Projekti\mojMarket\SLIKE_ZA_SAJT\zipped";
#else
      string root = args[0];
      int filesPerZip = int.Parse(args[1]);
      string moveTo = args[2];
      int maxSizeInMB = args[3];
#endif
      string[] files = Directory.GetFiles(root);
      int fileCount = files.Length;
      int zipCount = fileCount / filesPerZip + 1;
      long maxSizeInMB = 20;
      long maxSizeInBytes = maxSizeInMB * 1024 * 1024;

      DirectoryInfo d = new DirectoryInfo(root);
      FileInfo[] fileInfos = d.GetFiles();

      int i = 0;
      int fileIndex = 0;
      //for (int i = 0; i < zipCount; i++)
      //{
      while (fileIndex < fileCount)
      {
        //List<string> fs = files.OrderBy(f => f).Skip(i * filesPerZip).Take(filesPerZip).ToList();

        //List<FileInfo> fis =  fileInfos.OrderBy(f => f.Length).Skip(i * filesPerZip).Take(filesPerZip).ToList();
        List<FileInfo> fis = new List<FileInfo>();
        long totalSize = 0;

        while (totalSize < maxSizeInBytes && fileIndex < fileCount)
        {
          fis.Add(fileInfos[fileIndex]);
          totalSize += fileInfos[fileIndex].Length;
          fileIndex++;
        }

        Console.WriteLine(string.Format("Creating package {0}", (i + 1).ToString()));

        string zipName = root + "\\" + (i + 1).ToString() + ".zip";
        FileStream fsZip = File.Create(zipName);

        ZipOutputStream zipStream = new ZipOutputStream(fsZip);
        int folderOffset = root.Length + (root.EndsWith("\\") ? 0 : 1);

        foreach (var file in fis)
        {
          string filename = file.FullName;
          FileInfo fi = new FileInfo(filename);
          string entryName = filename.Substring(folderOffset); // Makes the name in zip based on the folder
          entryName = ZipEntry.CleanName(entryName); // Removes drive from name and fixes slash direction
          ZipEntry newEntry = new ZipEntry(entryName);
          zipStream.PutNextEntry(newEntry);
          byte[] buffer = new byte[4096];
          using (FileStream streamReader = File.OpenRead(filename))
          {
            StreamUtils.Copy(streamReader, zipStream, buffer);
          }
          zipStream.CloseEntry();
        }
        zipStream.IsStreamOwner = true; // Makes the Close also Close the underlying stream
        zipStream.Close();

        FileInfo fiz = new FileInfo(zipName);
        if (Directory.Exists(moveTo) == false)
          Directory.CreateDirectory(moveTo);
        if (File.Exists(moveTo + "\\" + fiz.Name))
          File.Delete(moveTo + "\\" + fiz.Name);
        fiz.MoveTo(moveTo + "\\" + fiz.Name);
        i++;
      }
    }

  }
}
