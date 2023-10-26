using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_CustomExceptionDemo
{
    internal class UsingException
    {
        FileStream fs;
        StreamWriter sw;
        public void CreateFile()
        {
            using (fs = new FileStream("Test222.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine("Hello");
                    sw.Flush();
                }
            }
        }
    }
}
