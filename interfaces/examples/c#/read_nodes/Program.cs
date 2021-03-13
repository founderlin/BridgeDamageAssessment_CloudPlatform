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
        // If you are using Visual Studio, you need to use unsafe code blocks
        // Open "Project properties" -> "Build Tab" -> "Allow Unsafe Code"

        // structure
        public unsafe struct cs_node                    // 20/00  Nodes
        {
            public int m_nr;                            // node-number
            public int m_inr;                           // internal node-number
            public int m_kfix;                          // degree of freedoms
            public int m_ncod;                          // additional bit code
            // public fixed float m_xyz[3];             // [1001] X-Y-Z-ordinates
            public float m_x;
            public float m_y;
            public float m_z;
        }

        // sof_cdb_init
        [DllImport("cdb_w50_x64.dll", CallingConvention=CallingConvention.Cdecl)]
        // [DllImport("cdb_w50_x64.lib")]
        public static extern int sof_cdb_init(
            string name_,
            int initType_
        );

        // sof_cdb_close
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void sof_cdb_close(
            int index_);

        // sof_cdb_status
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_status(
            int index_);

        // sof_cdb_flush
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_flush(
            int index_);

        // sof_cdb_flush
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_free(
            int kwh_, 
            int kwl_);

        // sof_cdb_flush
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void sof_cdb_kenq_ex(
            int index,
            ref int kwh_, 
            ref int kwl_, 
            int request_);

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_node node_,
            ref int recLen_,
            int pos);

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
            index = sof_cdb_init(@"S:\test\read_nodes.cdb", 99);
            if (index < 0)
            {
                Console.WriteLine("ERROR: Index = " + index + " < 0 - see clib1.h for meaning of error code");
                return;
            }
            else if (index == 0)
            {
                Console.WriteLine("ERROR: Index = " + index + " - The file is not a database");
                return;
            }

            // Check if sof_cdb_flush is working
            status = sof_cdb_status(index);

            // print index and status
            Console.WriteLine("Index: " + index);
            Console.WriteLine("Status: " + status);
            Console.WriteLine();

            // data as cs_node
            cs_node data = new cs_node();

            // get the data from CDB
            int datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(cs_node));   // get the length of the structure

            Console.WriteLine(string.Format("{0,-14}", "NR") + 
                string.Format("{0,-14}", "INR") + 
                string.Format("{0,-14}", "KFIX") + 
                string.Format("{0,-14}", "NCOD") + 
                string.Format("{0,-14}", "X") + 
                string.Format("{0,-14}", "Y") + 
                string.Format("{0,-14}", "Z"));
            while (sof_cdb_get(index, 20, 0, ref data, ref datalen, 1) == 0)    // the kwh = 20, kwl = 0, pos = 1
            {
                Console.WriteLine(string.Format("{0,-14}", data.m_nr) + 
                    string.Format("{0,-14}", data.m_inr) + 
                    string.Format("{0,-14}", data.m_kfix) + 
                    string.Format("{0,-14}", data.m_ncod) + 
                    string.Format("{0,-14}", data.m_x) + 
                    string.Format("{0,-14}", data.m_y) + 
                    string.Format("{0,-14}", data.m_z));
                datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(cs_node));   // check again for the length
            }

            // use sof_cdb_flush() and sof_cdb_close()
            sof_cdb_flush(index);
            sof_cdb_close(0);   // close the CDB

            // Output the status after closing the CDB
            Console.WriteLine();
            if (sof_cdb_status(index) == 0)
            {
                Console.WriteLine("CDB Status = 0, CDB closed succesfully");
            }
            else
            {
                Console.WriteLine("CDB Status <> 0, the CDB doesn't closed successfully");
            }

            Console.Write("Press <ENTER> key to close the application...");
            Console.ReadKey();
        }
    }
}