using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CShapeFile
{
     class Program
     {
          static void Main(string[] args)
          {
               FileStream fstr;
               try
               {
                    fstr = new FileStream("data.txt.txt", FileMode.Open);
               }
               catch(IOException ecx)
               {
                    Console.Write(ecx.Message);
                    return;
               }
          }
     }
}
