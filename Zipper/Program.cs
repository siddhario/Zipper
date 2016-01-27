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
      string root = @"E:\Slike\backup20160105";
      int filesPerZip = 15;
      string moveTo = @"E:\Slike\zipped";
#else
      string root = args[0];
      int filesPerZip = int.Parse(args[1]);
      string moveTo = args[2];
#endif
      string[] files = Directory.GetFiles(root);
      int fileCount = files.Length;
      int zipCount = fileCount / filesPerZip + 1;
      for (int i = 0; i < zipCount; i++)
      {
        List<string> fs = files.OrderBy(f => f).Skip(i * filesPerZip).Take(filesPerZip).ToList();
        Console.WriteLine(string.Format("Creating package {0}/{1}...", (i + 1).ToString(), zipCount));

        string zipName = root + "\\" + (i + 1).ToString() + ".zip";
        FileStream fsZip = File.Create(zipName);

        ZipOutputStream zipStream = new ZipOutputStream(fsZip);
        int folderOffset = root.Length + (root.EndsWith("\\") ? 0 : 1);

        foreach (var filename in fs)
        {
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
      }
    }

  }
}
