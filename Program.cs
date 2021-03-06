﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ps2psw {
   class Program {
      static void Main (string[] args) {
         var file = File.ReadAllLines (args[0]);
         var newFile = new List<string> ();
         var header = new string[] { "Group/Title", "Username", "Password", "URL" };
         newFile.Add (string.Join ("\t", header));
         foreach(var line in file.Skip(1)) {
            var entries = line.Trim ().Split ('\t');
            var newArray = new string[] {entries[0], entries[2], entries[3], entries[4] };
            newFile.Add (string.Join ("\t", newArray));
         }
         File.WriteAllLines (args[1], newFile.ToArray ());
      }
   }
}
