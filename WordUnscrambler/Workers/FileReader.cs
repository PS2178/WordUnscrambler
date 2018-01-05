using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordUnscrambler.Workers
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            string[] fileContent = File.ReadAllLines(filename);

            return fileContent;
        }
    }
}
