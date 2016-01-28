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
      string moveTo = @"D:\Projekti\mojMarket\SLIKE_ZA_SAJT\zipped";
      long maxSizeInMB = 20;
#else
      string root = args[0];
      string moveTo = args[2];
      int maxSizeInMB = args[3];
#endif



    }

  }
}
