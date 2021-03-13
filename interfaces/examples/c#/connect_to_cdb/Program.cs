//+============================================================================+
//| Company:   SOFiSTiK AG                                                     |
//| Version:   SOFiSTIK 2018                                                   |
//+============================================================================+

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;       //importing DLLS

namespace sofCDB
{
    class Program
    {
        // In this example 64bit dlls are used (Visual Studio Platform 64bit)

        // sof_cdb_init
        [DllImport("cdb_w50_x64.dll", CallingConvention=CallingConvention.Cdecl)]
        // [DllImport("cdb_w50_x64.lib")]
        public static extern int sof_cdb_init(
            string name,
            int initType
        );

        // sof_cdb_close
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void sof_cdb_close(
            int index
        );

        // sof_cdb_status
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_status(int index);

        static void Main(string[] args)
        {
            int index = 0;
            int status = 0;
            // Define the path of the dlls
            string directory1 = @"C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit";
            string directory2 = @"C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018";

            // Get the path
            string path = Environment.GetEnvironmentVariable("path");
            
            // Set the new path environment variable + SOFiSTiK dlls path
            path = directory1 + ";" + directory2 + ";" + path;

            // Set the path variable (to read the data from CDB)
            System.Environment.SetEnvironmentVariable("path", path);

            // Connect to CDB, int sof_cdb_init  ( char* FileName, int Index);
            // Always use index 99, for more details see cdbase.chm
            index = sof_cdb_init("S:\\test\\test.cdb", 99);
            if (index < 0)
            {
                Console.WriteLine("ERROR: Index = " + index + " < 0 - see clib1.h for meaning of error code");
                return;
            }
            else if(index == 0)
            {
                Console.WriteLine("ERROR: Index = " + index + " - The file is not a database");
                return;
            }
            status = sof_cdb_status(index);

            Console.WriteLine("Index: " + index);
            Console.WriteLine("Status: " + status);
            sof_cdb_close(0);

            // Output the status after closing the CDB
            Console.WriteLine();
            if (sof_cdb_status(index) == 0)
            {
                Console.WriteLine("CDB closed succesfully, status = 0");
            }
            
            Console.Write("Press <ENTER> to close the application...");
            Console.ReadLine();
        }
    }
}
