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
    public class ClassNode
    {
        public unsafe struct cs_node                    // 20/00  Nodes
        {
            public int m_nr;                            // node-number
            public int m_inr;                           // internal node-number
            public int m_kfix;                          // degree of freedoms
            public int m_ncod;                          // additional bit code
            public fixed float m_xyz[3];             // [1001] X-Y-Z-ordinates
        }

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_node data_,
            ref int recLen_,
            int pos);
    }

    public class ClassMatConc
    {
        public unsafe struct cs_mat_conc                  //        1/NR:1  MaterialConcrete
        {
            public int m_id;                           //        Identification
            public int m_type;                         //        Material type
            public int m_class;                        //        Classification
            public float m_emod;                       // [1090] Elasticity Modulus
            public float m_mue;                        //        Poissons ratio
            public float m_gmod;                       // [1090] Shear modulus
            public float m_kmod;                       // [1090] Compression modulus
            public float m_gam;                        // [1091] Dead weight
            public float m_rho;                        // [ 159] Density
            public float m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float m_e90;                        // [1090] Elasticity modulus perpendicular
            public float m_mue90;                      //        Poissons ratio perpendicular
            public float m_alf;                        // [   5] Euler Angle I
            public float m_bet;                        // [   5] Euler Angle II
            public float m_scm;                        //        Material safety
            public float m_fc;                         // [1092] effective strength
            public float m_fck;                        // [1092] nominal strength
            public float m_ftm;                        // [1092] mean value of tensional strength
            public float m_ftl;                        // [1092] lower fractile of tensional strength
            public float m_ftk;                        // [1092] upper fractile of tensional strength
            public float m_ec;                         //        compr. failure Energy (deprecated)
            public float m_et;                         // [ 112] tensile failure energy
            public float m_muer;                       //        friction in the crack
            public float m_fcm;                        // [1092] mean value of strength
            public float m_rdcl;                       //        weight class
            public float m_fcr;                        // [1092] calculatoric mean value of strength
            public float m_ecr;                        // [1090] Elasticity modul for worklaw CE
            public float m_fbd;                        // [1092] bond strength (EC2 Table. 5.1.3)
            public float m_ftd;                        // [1092] Initial tensile strength Bemessungszugfestigkeit
            public float m_feqr;                       // [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
            public float m_feqt;                       // [1092] Residual tensile strength  Restzugfestigkeit im Bruch
            public float m_fcfat;                      // [1092] Fatigue Strength
            public float m_scms;                       //        Material safety
            public float m_scmu;                       //        Material safety
            public float m_scmc;                       //        Material safety
        } // cs_mat_conc

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_mat_conc data_,
            ref int recLen_,
            int pos);
    }

    public class ClassMatStee
    {
        public unsafe struct cs_mat_stee                  //        1/NR:1  MaterialSteel
        {
            public int m_id;                           //        Identification
            public int m_type;                         //        Material type
            public int m_class;                        //        Classification
            public float m_emod;                       // [1090] Elasticity Modulus
            public float m_mue;                        //        Poissons ratio
            public float m_gmod;                       // [1090] Shear modulus
            public float m_kmod;                       // [1090] Compression modulus
            public float m_gam;                        // [1091] dead weight
            public float m_rho;                        // [ 159] Density
            public float m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float m_e90;                        // [1090] Elasticity modulus perpendicular
            public float m_mue90;                      //        Poissons ratio perpendicular
            public float m_alf;                        // [   5] Euler Angle I
            public float m_bet;                        // [   5] Euler Angle II
            public float m_scm;                        //        Material safety
            public float m_fy;                         // [1092] yield stress
            public float m_ft;                         // [1092] tensile strength
            public float m_eps;                        // [   9] limit strain
            public float m_rel1;                       //        Relaxation 0.55fpk
            public float m_rel2;                       //        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
            public float m_r;                          //        bond coefficient
            public float m_k1;                         //        bondfactor EC2
            public float m_eh;                         // [1090] Hardening module
            public float m_fe;                         // [1092] Proportional stress
            public float m_epse;                       // [   9] Plastic strain
            public float m_fdyn;                       // [1092] Dynamic strength
            public float m_fyc;                        // [1092] compr. yield stress
            public float m_ftc;                        // [1092] compress. strength
            public float m_tmax;                       // [  16] max.plate thickness
            public float m_bc;                         //        (eg. Aluminium 1.0/2.0 = "A","B" )
            public fixed float m_dummy[2];
            public float m_scms;                       //        Material safety
            public float m_scmu;                       //        Material safety
            public float m_scmc;                       //        Material safety
        } // cs_mat_stee

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_mat_stee data_,
            ref int recLen_,
            int pos);
    }

    public class ClassBeamFoc
    {
        public unsafe struct cs_beam_foc                  //        102/LC:0  Maximum of Total Beam forces and deformations
        {
            public int m_id;                           //        identifier 0
            public float m_x;                          // [1001] max. beam length
            public float m_n;                          // [1101] normal force
            public float m_vy;                         // [1102] y-shear force
            public float m_vz;                         // [1102] z-shear force
            public float m_mt;                         // [1103] torsional moment
            public float m_my;                         // [1104] bending moment My
            public float m_mz;                         // [1104] bending moment Mz
            public float m_mb;                         // [1105] warping moment Mb
            public float m_mt2;                        // [1103] 2nd torsionalmom.
            public float m_ux;                         // [1003] diplacem. local x
            public float m_uy;                         // [1003] diplacem. local y
            public float m_uz;                         // [1003] diplacem. local z
            public float m_phix;                       // [1004] rotation local x
            public float m_phiy;                       // [1004] rotation local y
            public float m_phiz;                       // [1004] rotation local z
            public float m_phiw;                       // [1005] twisting
            public float m_mt3;                        // [1103] 3rd torsionalmom
            public float m_pa;                         // [1095] axial bedding
            public float m_pt;                         // [1095] transverse bedding
            public float m_pty;                        // [1095] local y component of transverse bedding
            public float m_ptz;                        // [1095] local z component of transverse bedding
        } // cs_beam_foc

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_beam_foc data_,
            ref int recLen_,
            int pos);
    }

    public class ClassSectRec
    {
        public unsafe struct cs_sect_rec                  //        9/NR:10  SectiontypeRectangular T-Beam
        {
            public int m_id;                           //        Identification = 10
            public int m_iq;                           //        Identification of section
            public int m_ir;                           //        Identification of reinforcement and origin
            public float m_h;                          // [1011] total height
            public float m_b;                          // [1011] width (of web)
            public float m_so;                         // [1024] Boundary distance of upper reinforcement
            public float m_su;                         // [1024] Boundary distance of lower reinforcement
            public float m_aso;                        // [1020] reinforcement up
            public float m_asu;                        // [1020] reinforcement down
            public float m_ho;                         // [1011] height of plate
            public float m_bo;                         // [1011] width  of plate
            public float m_daso;                       // [1023] reinf. Diameter up
            public float m_dasu;                       // [1023] reinf. Diameter dn
            public float m_fkit;                       //        <0 = factor for torsional inertia >0 = absolut value of torsion
            public float m_fkay;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
            public float m_fkaz;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
            public float m_ysmp;                       // [1011] explicit location of shear center
            public float m_zssmp;                      // [1011] explicit location of shear center
            public float m_ys;                         // [1011] explicit location of reference point
            public float m_zs;                         // [1011] explicit location of reference point
            public float m_phib;                       // [   5] inclination of shear links
            public float m_beff;                       // [1011] width of equivalent hollow section
            public float m_asbm;                       // [1022] Minimum shear reinf.
            public float m_a;                          // [1011] spacing of reinforcements
            public float m_amin;                       // [1011] minimum distance of single reinforcements
            public float m_amax;                       // [1011] maximum distance of single reinforcements
            public float m_ss;                         // [1024] Boundary distance of lateral reinforcement
            public float m_dass;                       // [1023] reinf. Diameter side
            public float m_hmax;                       // [1011] maximum mesh size for FE/fibre analysis
        } // cs_sect_rec

        // sof_cdb_get
        [DllImport("cdb_w50_x64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sof_cdb_get(
            int index_,
            int kwh_,
            int kwl_,
            ref cs_sect_rec data_,
            ref int recLen_,
            int pos);
    }
}
