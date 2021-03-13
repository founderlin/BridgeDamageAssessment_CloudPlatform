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

    public static class Program
    {
        // In this example 64bit dlls are used (Visual Studio Platform 64bit)

        // sof_cdb_init
        [DllImport("cdb_w50_x64.dll", CallingConvention=CallingConvention.Cdecl)]
        // [DllImport("cdb_w33_x64.lib")]
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

        public static unsafe void Main(string[] args)
        {
            int index = 0;
            int status = 0;
            int datalen;

            string directory1 = @"C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit";
            string directory2 = @"C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018";
            string cdbPath = @"S:\test\single_span_girder\simple_span_girder.cdb";

            // Get the path
            string path = Environment.GetEnvironmentVariable("path");

            // Set the new path environment variable + SOFiSTiK dlls path
            path = directory1 + ";" + directory2 + ";" + path;

            // Set the path variable (to read the data from CDB)
            System.Environment.SetEnvironmentVariable("path", path);

            // connect to CDB
            index = sof_cdb_init(cdbPath, 99);
            // check if sof_cdb_flush is working
            status = Program.sof_cdb_status(index);

            // print index and status
            Console.WriteLine("Index: " + index);
            Console.WriteLine("Status: " + status);
            Console.WriteLine();            

            // Read the f_ck value
            ClassMatConc.cs_mat_conc c_mat_conc = new ClassMatConc.cs_mat_conc();
            datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassMatConc.cs_mat_conc));
            while (ClassMatConc.sof_cdb_get(index, 1, 1, ref c_mat_conc, ref datalen, 1) < 2)
            {
                if (c_mat_conc.m_id == 1)
                {
                    // divide with 1000 because of units kN/m^2 -> MN/m^2
                    Gv.fck = c_mat_conc.m_fck / 1000;   
                    Console.WriteLine(string.Format("{0,-7}", "fck") + 
                        string.Format("{0,-2}", "=") + 
                        string.Format("{0,-15}", Gv.fck) + " MPa");
                }
                // Get data length
                datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassMatConc.cs_mat_conc));    
            }
            // Release all locks
            sof_cdb_flush(index);       

            // Read the f_y value
            ClassMatStee.cs_mat_stee c_mat_stee = new ClassMatStee.cs_mat_stee();
            datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassMatStee.cs_mat_stee));
            while (ClassMatStee.sof_cdb_get(index, 1, 2, ref c_mat_stee, ref datalen, 1) < 2)
            {
                if (c_mat_stee.m_id == 1)
                {
                    // Divide with 1000 because of units kN/m^2 -> MN/m^2
                    Gv.fy = c_mat_stee.m_fy / 1000;     
                    Console.WriteLine(string.Format("{0,-7}", "fy") + 
                        string.Format("{0,-2}", "=") + 
                        string.Format("{0,-15}", Gv.fy) + " MPa");
                }
                // Get data length
                datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassMatStee.cs_mat_stee));    
            }
            sof_cdb_flush(index);       // Release all locks
            Console.WriteLine();

            ClassBeamFoc.cs_beam_foc c_beam_foc = new ClassBeamFoc.cs_beam_foc();
            datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassBeamFoc.cs_beam_foc));
            while (ClassBeamFoc.sof_cdb_get(index, 102, 1001, ref c_beam_foc, ref datalen, 1) == 0)
            {
                if (c_beam_foc.m_id == 0)
                {
                    if (Math.Abs(Gv.Ned) < Math.Abs(c_beam_foc.m_n) && (Math.Abs(c_beam_foc.m_n) < 1e35))
                    {
                        Gv.Ned = c_beam_foc.m_n / 1000;     // divide with 1000 because of units kN/m^2 -> MN/m^2
                        Console.WriteLine(string.Format("{0,-7}", "Ned") + 
                            string.Format("{0,-2}", "=") + 
                            string.Format("{0,-15}", Gv.Ned) + " MN");
                    }

                    if (Math.Abs(Gv.Med) < Math.Abs(c_beam_foc.m_my) && (Math.Abs(c_beam_foc.m_my) < 1e35))
                    {
                        // Divide with 1000 because of units kNm/m^2 -> MNm/m^2
                        Gv.Med = c_beam_foc.m_my / 1000;    
                        Console.WriteLine(string.Format("{0,-7}", "Med") + 
                            string.Format("{0,-2}", "=") + 
                            string.Format("{0,-15}", Gv.Med) + " MNm");
                    }
                }
                datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassBeamFoc.cs_beam_foc));    // get data length
            } 
            sof_cdb_flush(index);       // Release all locks
            Console.WriteLine();

            // Read the b, h, so, su values
            ClassSectRec.cs_sect_rec c_sect_rec = new ClassSectRec.cs_sect_rec();
            datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassSectRec.cs_sect_rec));
            while (ClassSectRec.sof_cdb_get(index, 9, 1, ref c_sect_rec, ref datalen, 1) < 2)
            {
                if (c_sect_rec.m_id == 10)
                {
                    Gv.b = c_sect_rec.m_b;
                    Gv.h = c_sect_rec.m_h;
                    Gv.so = c_sect_rec.m_so;
                    Gv.su = c_sect_rec.m_su;
                }
                datalen = System.Runtime.InteropServices.Marshal.SizeOf(typeof(ClassSectRec.cs_sect_rec));    // get data length
            }
            sof_cdb_flush(index);       // Release all locks
            Console.WriteLine(string.Format("{0,-7}", "b") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Gv.b) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "h") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Gv.h) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "so") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Gv.so) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "su") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Gv.su) + 
                " m");
            Console.WriteLine();

            // ITERATION AND DESIGN
            float epss = 25;
            float epsc = 0;
            float Mrd = 0;
            float mu = 0;
            float alpha = 0;
            float xi = 0;
            float x = 0;
            float d = Gv.h - Gv.su;
            float ka = 0;
            float z = 0;
            float zeta = 0;
            float omega = 0;
            double fcd = (Gv.fck * 0.85) / 1.5;
            double fyd = Gv.fy / 1.15;
            double As1 = 0;

            Gv.Meds = Convert.ToSingle(Gv.Med - Gv.Ned*(Gv.h/2-Gv.su));
            Console.WriteLine(string.Format("{0,-7}", "Meds") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Gv.Meds) + 
                " m");
            while (Mrd <= Gv.Meds && mu < 0.296)
            {
                if (epsc > 0 && epsc <= 2)
                {
                    alpha = epsc / 12 * (6 - epsc);
                }
                else if (epsc > 2 && epsc <= 3.5)
                {
                    alpha = (3 * epsc - 2) / (3 * epsc);
                }

                // Calculate the Xi Value
                xi = epsc / (epss + epsc);

                // Calculate x
                x = xi * d;

                // Calculate ka
                if (epsc > 0 && epsc <= 2)
                {
                    ka = (8 - epsc) / (4 * (6 - epsc));
                }
                else if (epsc > 2 && epsc <= 3.5)
                {
                    ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2));
                }

                // Calculate z
                z = d - ka * x;

                // Calculate zeta
                zeta = 1 - ka * xi;

                // Calculate omega
                omega = alpha * xi;
            
                // Calculate mu
                // mu = alpha * xi * d * Gv.b * Convert.ToSingle(fcd);         
                mu = alpha * xi * zeta;

                // Calculate the Mrd resistance moment
                Mrd = alpha * xi * d * Gv.b * Convert.ToSingle(fcd) * zeta * d;

                // Required reinforcement
                As1 = (1 / fyd) * (omega * Gv.b * d * Convert.ToSingle(fcd) + Gv.Ned);

                if (epsc >= 3.5)
                {
                    while (Mrd <= Gv.Meds && epss >= 0 && mu < 0.296)
                    {
                        if (epsc > 0 && epsc <= 2)
                        {
                            alpha = epsc / 12 * (6 - epsc);
                        }
                        else if (epsc > 2 && epsc <= 3.5)
                        {
                            alpha = (3 * epsc - 2) / (3 * epsc);
                        }

                        // Calculate the Xi Value
                        xi = epsc / (epss + epsc);

                        // Calculate x
                        x = xi * d;

                        // Calculate ka
                        if (epsc > 0 && epsc <= 2)
                        {
                            ka = (8 - epsc) / (4 * (6 - epsc));
                        }
                        else if (epsc > 2 && epsc <= 3.5)
                        {
                            ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2));
                        }

                        // Calculate z
                        z = d - ka * x;

                        // Calculate zeta
                        zeta = 1 - ka * xi;

                        // Calculate omega
                        omega = alpha * xi;

                        // Calculate mu
                        mu = alpha * xi * zeta;

                        // Calculate the Mrd resistance moment
                        Mrd = alpha * xi * d * Gv.b * Convert.ToSingle(fcd) * zeta * d;

                        // Required reinforcement
                        As1 = (1 / fyd) * (omega * Gv.b * d * Convert.ToSingle(fcd) + Gv.Ned);

                        if (epss == 0)
                        {
                            Console.WriteLine("Reinforced reached 0 [o/oo]");
                        }

                        // Iterate epss
                        epss = Convert.ToSingle(epss - 0.001);
                    }
                }
                
                // Iterate epsc
                epsc = Convert.ToSingle(epsc + 0.1);
            }
           
            // Print design values
            Console.WriteLine(string.Format("{0,-7}", "fcd") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", fcd) + 
                " MPa");
            Console.WriteLine(string.Format("{0,-7}", "fyd") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(fyd, 5)) + 
                " MPa");
            Console.WriteLine(string.Format("{0,-7}", "epsc") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(epsc, 5)) + 
                " [o/oo]");
            Console.WriteLine(string.Format("{0,-7}", "epss") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(epss, 5)) + 
                " [o/oo]");
            Console.WriteLine(string.Format("{0,-7}", "alpha") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(alpha, 5)));
            Console.WriteLine(string.Format("{0,-7}", "ka") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(ka, 5)));
            Console.WriteLine(string.Format("{0,-7}", "z") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(z, 5)) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "zeta") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(zeta, 5)));
            Console.WriteLine(string.Format("{0,-7}", "omega") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(omega, 5)));
            Console.WriteLine(string.Format("{0,-7}", "mu") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(mu, 5)));
            Console.WriteLine(string.Format("{0,-7}", "d") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", d) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "Xi") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", xi));
            Console.WriteLine(string.Format("{0,-7}", "x") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", x) + 
                " m");
            Console.WriteLine(string.Format("{0,-7}", "Mrds") + 
                string.Format("{0,-2}", "=") + 
                string.Format("{0,-15}", Math.Round(Mrd, 5)) + 
                " MNm");
            Console.WriteLine("------------");
            Console.WriteLine(string.Format("{0,-7}", "As1") + 
                string.Format("{0,-2}", "=") +
                Math.Round(As1 * 100 * 100, 3) + 
                " cm2");
            // Check the cross-section
            if (Mrd < Gv.Meds)
            {
                Console.WriteLine("The cross-section must be redimensioned");
            }
            Console.WriteLine();

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

            Console.Write("Press any key to close the application...");
            Console.ReadKey();
        }
    }
}