/*   SOFiSTiK AG                             Aug  6 2014
     sofistik_daten.cs
     automatically generated header, no use to modify!
*/


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace SofistikDataTypes
{
      public unsafe struct cs_rec_vers                  //        -999/-999  Revision number of generating cdbase.txt
      {
            public int  m_vers;                         //        version
      } // cs_rec_vers

      public unsafe struct cs_rec_indx                  //        -999/-998  Sorted index on structure names
      {
            public fixed int  m_name[2];                //        Name of this structure
            public int  m_kwh;                          //        Kwh
            public int  m_kwl;                          //        Kwl
            public fixed int  m_sel1[2];                //        Selection string of first integer value
            public fixed int  m_sel2[2];                //        Selection string of second integer value
      } // cs_rec_indx

      public unsafe struct cs_rec_pub                   //        -999/-997:1  public REC
      {
            public int  m_id;                           //        Identification 1/2
            public int  m_kwh;                          //        Kwh
            public int  m_kwl;                          //        Kwl (may be NR/LC or number)
            public fixed int  m_sel1[2];                //        Selection string of first integer value
            public fixed int  m_sel2[2];                //        Selection string of second integer value
            public fixed int  m_name[2];                //        name of this structure
            public int  m_version;                      //        Version number of description
            public int  m_option;                       //        options  0 = default
      } // cs_rec_pub

      public unsafe struct cs_rec_int                   //        -999/-997:2  internal REC
      {
            public int  m_id;                           //        Identification 1/2
            public int  m_kwh;                          //        Kwh
            public int  m_kwl;                          //        Kwl (may be NR/LC or number)
            public fixed int  m_sel1[2];                //        Selection string of first integer value
            public fixed int  m_sel2[2];                //        Selection string of second integer value
            public fixed int  m_name[2];                //        name of this structure
            public int  m_version;                      //        Version number of description
            public int  m_option;                       //        options  0 = default
      } // cs_rec_int

      public unsafe struct cs_rec_dad                   //        -999/-997:3  public DAD
      {
            public int  m_id;                           //        Identification 3
            public int  m_kwh;                          //        Kwh
            public int  m_kwl;                          //        Kwl
      } // cs_rec_dad

      public unsafe struct cs_rec_desc                  //        -999/-997:4  description string to last entry or item
      {
            public int  m_id;                           //        Identification 4
            public int  m_lang;                         //        Language of this item
            public fixed int m_name[64];                //        Description
      } // cs_rec_desc

      public unsafe struct cs_rec_itm5_stru             //        Names of the structure elements
      {
            public fixed int  m_name[2];
            public int  m_dim;
            public int  m_dim1;
      } // cs_rec_itm5_stru

      public unsafe struct cs_rec_itm5                  //        -999/-997:5  item of a record (obsoleted)
      {
            public int  m_id;                           //        Identification 5
            public int  m_nr;                           //        number of the item
            public int  m_index;                        //        index of the item starting with 0
            public int  m_typ;                          //        Type of the item
            public int  m_offset;                       //        offset of the item to be merged
            public fixed int  m_name[2];                //        item name (4 chars significant)
            public int  m_dim;                          //        unit or type of item
            public int  m_dim1;                         //        first dimension
            public int  m_beg1;                         //        first index of first dimension
            public int  m_dim2;                         //        second dimension
            public int  m_beg2;                         //        first index of second dimension
            public int  m_bits;                         //        additional information Bits
            public cs_rec_itm5_stru  m_structur;        //        Names of the structure elements
      } // cs_rec_itm5

      public unsafe struct cs_rec_item_stru             //        Names of the structure elements
      {
            public fixed int  m_name[2];
            public int  m_dim;
            public int  m_type;
            public int  m_dim1;
      } // cs_rec_item_stru

      public unsafe struct cs_rec_item                  //        -999/-997:6  item of a record
      {
            public int  m_id;                           //        Identification 6
            public int  m_nr;                           //        number of the item
            public int  m_index;                        //        index of the item starting with 0
            public int  m_typ;                          //        Type of the item
            public int  m_offset;                       //        offset of the item to be merged
            public fixed int  m_name[2];                //        item name (4 chars significant)
            public int  m_dim;                          //        unit of item
            public int  m_type;                         //        type of item
            public int  m_dim1;                         //        first dimension
            public int  m_beg1;                         //        first index of first dimension
            public int  m_dim2;                         //        second dimension
            public int  m_beg2;                         //        first index of second dimension
            public int  m_bits;                         //        additional information Bits
            public cs_rec_item_stru  m_structur;        //        Names of the structure elements
      } // cs_rec_item

      public unsafe struct cs_rec_mix_mixi              //        Mixinfo
      {
            public int  m_typ;
            public int  m_keytyp;
            public int  m_mixfrom;
      } // cs_rec_mix_mixi

      public unsafe struct cs_rec_mix                   //        -999/-997:11  mixinfo of a record
      {
            public int  m_id;                           //        Identification 11/12
            public int  m_nkey;
            public int  m_nlen;
            public int  m_nmixflag;
            public int  m_selector;
            public cs_rec_mix_mixi  m_mixinfo;          //        Mixinfo
      } // cs_rec_mix

      public unsafe struct cs_rec_mhd_mixi              //        Mixinfo
      {
            public int  m_typ;
            public int  m_keytyp;
            public int  m_mixfrom;
      } // cs_rec_mhd_mixi

      public unsafe struct cs_rec_mhd                   //        -999/-997:12  mixinfo of a record header
      {
            public int  m_id;                           //        Identification 11/12
            public int  m_nkey;
            public int  m_nlen;
            public int  m_nmixflag;
            public int  m_selector;
            public cs_rec_mhd_mixi  m_mixinfo;          //        Mixinfo
      } // cs_rec_mhd

      public unsafe struct cs_ctrl_010                  //        0/01:999  AccessInfo Last Program
      {
            public int  m_id;                           //        Identifier 999
            public int  m_acce;                         //        Number of access
            public int  m_vers;                         //        Version number
            public fixed int m_name[17];                //        Name of Program
            public fixed int  m_err[4];                 //        Name of ERR-File
      } // cs_ctrl_010

      public unsafe struct cs_ctrl_011                  //        0/01:?  Messages
      {
            public int  m_id;                           //        Level
            public fixed int  m_iderr[2];               //        Number of errortext
            public fixed int  m_idsup[4];               //        Name of subroutine
            public fixed int  m_itext[6];               //        Text value of message
            public int  m_nilist;                       //        count on Integer values of message
            public int  m_nrlist;                       //        count on Real values of message
            public fixed int  m_list[255];              //        values of message ILIST+RLIST
      } // cs_ctrl_011

      public unsafe struct cs_ctrl_obj                  //        0/01:101  involved objects
      {
            public int  m_id;                           //        Identifier = 101
            public int  m_id2;                          //        bitpattern of specified data
            public int  m_type;                         //        KWH of Elementtype (30,31,32,33)
            public int  m_nr;                           //        Number of element  (TYPE/NR)
            public fixed int  m_idbim[32];              //        256 Bit GUId Identifier of element in the BIM/CAD system
            public fixed float  m_uvw[3];               // [1001] local coordinates in object
            public fixed float  m_box[2*3];             // [1001] bounding box x,y,z min, x,y,z max
      } // cs_ctrl_obj

      public unsafe struct cs_ctrl_oid                  //        0/01:102  GUId
      {
            public int  m_id;                           //        identifier 102
            public fixed int  m_idbim[36];              //        256 Bit GUId Identifier of preceeding element
      } // cs_ctrl_oid

      public unsafe struct cs_ssd_spe                   //        0/96:1  SSD-Spezial
      {
            public int  m_id;                           //        id==1
            public int  m_type;                         //        type of information
            public int  m_ival;                         //        integer value
            public fixed float  m_rval[3];              //        real values
            public fixed int  m_itxt[4];                //        string value
      } // cs_ssd_spe

      public unsafe struct cs_vis_lc0                   //        0/97:0  active Loadcase
      {
            public int  m_id;                           //        id==0
            public int  m_lfnr;                         //        Loadcase number
            public int  m_vis;                          //        unused
      } // cs_vis_lc0

      public unsafe struct cs_vis_lc                    //        0/97:1  Loadcase visualisation
      {
            public int  m_id;                           //        id==1
            public int  m_lfnr;                         //        Loadcase number
            public int  m_vis;                          //        Visualisation
      } // cs_vis_lc

      enum CTRL_ACCESS_MIX { CTRL_ACCESS_MIX = 1 }
      enum CTRL_ACCESS_CONVERT { CTRL_ACCESS_CONVERT = 2 }
      enum CTRL_ACCESS_2010 { CTRL_ACCESS_2010 = 4 }
      enum CTRL_ACCESS_2012 { CTRL_ACCESS_2012 = 8 }
      enum CTRL_ACCESS_2014 { CTRL_ACCESS_2014 = 16 }
      enum CTRL_ACCESS_2016 { CTRL_ACCESS_2016 = 32 }
      public unsafe struct cs_ctrl                      //        0/99:*  PrintControl
      {
            public int  m_maxl;                         //        Lines per page
            public int  m_marg;                         //        Left margin
            public int  m_tobo;                         //        Top/bottom margin
            public int  m_modp;                         //        Type of Headding
            public int  m_page;                         //        Current page no
            public int  m_lout;                         //        Output Language
            public int  m_linp;                         //        Input  Language
            public int  m_unit;                         //        Unit set
            public int  m_acce;                         //        No of last access
            public fixed int m_pag[7];                  //        Paging Text
            public int  m_rel_vers;                     //        ReleaseVersion of this database
            public int  m_rel_bits;                     //        Accessbits
      } // cs_ctrl

      public unsafe struct cs_ctrl_0                    //        0/99:0  AccessInfo
      {
            public int  m_id;                           //        Identifier 0
            public int  m_acce;                         //        Number of access
            public int  m_vers;                         //        Version number
            public int  m_erro;                         //        Number of Errors
            public int  m_warn;                         //        Number of Errors
            public fixed int m_name[17];                //        Name of Program
            public int  m_rel_vers;                     //        ReleaseVersion of last access
      } // cs_ctrl_0

      public unsafe struct cs_ctrl_1                    //        0/99:1  AccessTitle
      {
            public int  m_id;                           //        Identifier 1
            public int  m_acce;                         //        Number of access
            public fixed int m_kopf[64];                //        Title of access
      } // cs_ctrl_1

      public unsafe struct cs_ctrl_var                  //        0/100  Global_CADINP_Variable
      {
            public fixed int  m_name[4];                //        name of variable
            public int  m_ind;                          //        index for arrays
            public float  m_val;                        //        value of variable
            public int  m_scope;                        //        name of scope
            public int  m_dim;                          //        unit of variable
            public fixed int m_txt[17];                 //        Comment on variable
      } // cs_ctrl_var

      public unsafe struct cs_ctrl_vap                  //        0/100:???  Private_CADINP_Variable
      {
            public int  m_id;                           //        Identification = ???
            public int  m_ind1;                         //        Lower Index of variable
            public int  m_ind2;                         //        Upper Index of variable
            public fixed int  m_name[4];                //        Name of variable
            public fixed float  m_val[1020];            //        values of the variable NAME[IND1:IND2]
      } // cs_ctrl_vap

      enum MAT_CONS_GW { MAT_CONS_GW = 701 }
      enum MAT_CONS_GP { MAT_CONS_GP = 702 }
      enum MAT_CONS_GM { MAT_CONS_GM = 703 }
      enum MAT_CONS_GC { MAT_CONS_GC = 704 }
      enum MAT_CONS_SW { MAT_CONS_SW = 705 }
      enum MAT_CONS_SP { MAT_CONS_SP = 706 }
      enum MAT_CONS_SM { MAT_CONS_SM = 707 }
      enum MAT_CONS_SC { MAT_CONS_SC = 708 }
      enum MAT_CONS_SAND { MAT_CONS_SAND = 709 }
      enum MAT_CONS_ML { MAT_CONS_ML = 711 }
      enum MAT_CONS_MI { MAT_CONS_MI = 712 }
      enum MAT_CONS_MH { MAT_CONS_MH = 713 }
      enum MAT_CONS_CL { MAT_CONS_CL = 715 }
      enum MAT_CONS_CI { MAT_CONS_CI = 716 }
      enum MAT_CONS_CH { MAT_CONS_CH = 717 }
      enum MAT_CONS_CLAY { MAT_CONS_CLAY = 719 }
      enum MAT_CONS_ROC1 { MAT_CONS_ROC1 = 721 }
      enum MAT_CONS_ROC2 { MAT_CONS_ROC2 = 722 }
      enum MAT_CONS_ROC3 { MAT_CONS_ROC3 = 723 }
      enum MAT_CONS_ROC4 { MAT_CONS_ROC4 = 724 }
      enum MAT_CONS_AIR { MAT_CONS_AIR = 801 }
      enum MAT_CONS_H2O { MAT_CONS_H2O = 802 }
      enum MAT_CONS_CO2 { MAT_CONS_CO2 = 803 }
      enum MAT_CONS_O2 { MAT_CONS_O2 = 804 }
      enum MAT_CONS_N2 { MAT_CONS_N2 = 805 }
      enum MAT_CONS_CH4 { MAT_CONS_CH4 = 806 }
      enum MAT_CONS_HE { MAT_CONS_HE = 809 }
      enum MAT_CONS_NE { MAT_CONS_NE = 810 }
      enum MAT_CONS_AR { MAT_CONS_AR = 811 }
      enum MAT_CONS_KR { MAT_CONS_KR = 812 }
      enum MAT_CONS_XE { MAT_CONS_XE = 813 }
      enum MAT_CONS_SF6 { MAT_CONS_SF6 = 814 }
      enum MAT_CONS_GLAS { MAT_CONS_GLAS = 901 }
      enum MAT_CONS_ESG { MAT_CONS_ESG = 902 }
      enum MAT_CONS_VSGh { MAT_CONS_VSGh = 903 }
      enum MAT_CONS_VSGv { MAT_CONS_VSGv = 904 }
      enum MAT_CONS_TVG { MAT_CONS_TVG = 905 }
      enum MAT_CONS_Cu { MAT_CONS_Cu = 906 }
      enum MAT_CONS_Pb { MAT_CONS_Pb = 907 }
      enum MAT_CONS_Mg { MAT_CONS_Mg = 908 }
      enum MAT_CONS_W { MAT_CONS_W = 909 }
      enum MAT_CONS_Zn { MAT_CONS_Zn = 910 }
      enum MAT_CONS_BRAS { MAT_CONS_BRAS = 911 }
      enum MAT_CONS_BRON { MAT_CONS_BRON = 912 }
      enum MAT_CONS_BRIC { MAT_CONS_BRIC = 925 }
      enum MAT_CONS_SLBR { MAT_CONS_SLBR = 926 }
      enum MAT_CONS_CLIN { MAT_CONS_CLIN = 927 }
      enum MAT_CONS_IGYP { MAT_CONS_IGYP = 930 }
      enum MAT_CONS_GYPS { MAT_CONS_GYPS = 931 }
      enum MAT_CONS_MOGY { MAT_CONS_MOGY = 932 }
      enum MAT_CONS_MOCH { MAT_CONS_MOCH = 933 }
      enum MAT_CONS_MOCE { MAT_CONS_MOCE = 934 }
      enum MAT_CONS_ASPH { MAT_CONS_ASPH = 937 }
      enum MAT_CONS_BITU { MAT_CONS_BITU = 938 }
      enum MAT_CONS_CARP { MAT_CONS_CARP = 941 }
      enum MAT_CONS_WOOL { MAT_CONS_WOOL = 942 }
      enum MAT_CONS_CORK { MAT_CONS_CORK = 943 }
      enum MAT_CONS_LINO { MAT_CONS_LINO = 944 }
      enum MAT_CONS_EPOX { MAT_CONS_EPOX = 946 }
      enum MAT_CONS_PHEN { MAT_CONS_PHEN = 947 }
      enum MAT_CONS_PEST { MAT_CONS_PEST = 948 }
      enum MAT_CONS_ACRY { MAT_CONS_ACRY = 949 }
      enum MAT_CONS_PC { MAT_CONS_PC = 950 }
      enum MAT_CONS_PTFE { MAT_CONS_PTFE = 951 }
      enum MAT_CONS_PVC { MAT_CONS_PVC = 952 }
      enum MAT_CONS_PMMA { MAT_CONS_PMMA = 953 }
      enum MAT_CONS_POM { MAT_CONS_POM = 954 }
      enum MAT_CONS_PA { MAT_CONS_PA = 955 }
      enum MAT_CONS_PEHD { MAT_CONS_PEHD = 956 }
      enum MAT_CONS_PELD { MAT_CONS_PELD = 957 }
      enum MAT_CONS_PS { MAT_CONS_PS = 958 }
      enum MAT_CONS_PP { MAT_CONS_PP = 959 }
      enum MAT_CONS_PUR { MAT_CONS_PUR = 960 }
      enum MAT_CONS_RUBB { MAT_CONS_RUBB = 961 }
      enum MAT_CONS_NEOP { MAT_CONS_NEOP = 962 }
      enum MAT_CONS_EBON { MAT_CONS_EBON = 963 }
      enum MAT_CONS_EPDM { MAT_CONS_EPDM = 964 }
      enum MAT_CONS_PSUL { MAT_CONS_PSUL = 965 }
      enum MAT_CONS_BUTA { MAT_CONS_BUTA = 966 }
      enum MAT_CONS_SI { MAT_CONS_SI = 967 }
      enum MAT_CONS_SILA { MAT_CONS_SILA = 968 }
      enum MAT_CONS_FOAM { MAT_CONS_FOAM = 973 }
      enum MAT_CONS_FOAS { MAT_CONS_FOAS = 974 }
      enum MAT_CONS_FOAU { MAT_CONS_FOAU = 975 }
      enum MAT_CONS_FOAC { MAT_CONS_FOAC = 976 }
      enum MAT_CONS_FOAR { MAT_CONS_FOAR = 977 }
      enum MAT_CONS_FOAE { MAT_CONS_FOAE = 978 }
      enum MAT_CONS_LAY { MAT_CONS_LAY = 999 }
      public unsafe struct cs_mat                       //        1/NR:0  MaterialTitle
      {
            public int  m_id;                           //        Identification = 0
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public fixed int m_title[17];               //        designation
      } // cs_mat

      public unsafe struct cs_mat_user                  //        1/NR:10??  Information on user input
      {
            public int  m_id;                           //        Identification
            public fixed int  m_bit[32];                //        User input for 001/NR:1
      } // cs_mat_user

      public unsafe struct cs_mat_flui                  //        1/NR:1  MaterialConstants
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Compression modulus
            public float  m_nue;                        // [1221] Kinematic Viscosity
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_rho;                        // [ 159] Density
            public float  m_gamb;                       // [1091] dead weight buyoncy
            public float  m_alfa;                       // [ 107] Temperature Elongation coefficient
      } // cs_mat_flui

      enum MAT_CONS_LINE { MAT_CONS_LINE = 0 }
      enum MAT_CONS_MISE { MAT_CONS_MISE = 1 }
      enum MAT_CONS_MOHR { MAT_CONS_MOHR = 2 }
      enum MAT_CONS_GUDE { MAT_CONS_GUDE = 3 }
      enum MAT_CONS_ROCK { MAT_CONS_ROCK = 4 }
      enum MAT_CONS_LADE { MAT_CONS_LADE = 5 }
      enum MAT_CONS_DUNC { MAT_CONS_DUNC = 6 }
      enum MAT_CONS_HYPO { MAT_CONS_HYPO = 7 }
      enum MAT_CONS_MEMB { MAT_CONS_MEMB = 8 }
      enum MAT_CONS_GRAN { MAT_CONS_GRAN = 10 }
      enum MAT_CONS_CAMC { MAT_CONS_CAMC = 11 }
      enum MAT_CONS_UNDR { MAT_CONS_UNDR = 14 }
      enum MAT_CONS_FAIL { MAT_CONS_FAIL = 15 }
      enum MAT_CONS_SWEL { MAT_CONS_SWEL = 16 }
      enum MAT_CONS_VMIS { MAT_CONS_VMIS = 17 }
      enum MAT_CONS_DRUC { MAT_CONS_DRUC = 18 }
      public unsafe struct cs_mat_cons                  //        1/NR:1  MaterialConstants
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_gamb;                       // [1091] dead weight buyoncy
            public float  m_alfa;                       // [ 107] Temperature Expansion
            public float  m_e90;                        // [1090] Transvers Elasticity
            public float  m_mue90;                      //        anisotrope Poisson
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fy;                         // [1092] effective strength
            public float  m_ft;                         // [1092] nominal strength
            public fixed float  m_p[18];                //        variable parameters
      } // cs_mat_cons

      public unsafe struct cs_mat_undr                  //        1/NR:14  Undrained soil parameters
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_gamb;                       // [1091] dead weight buyoncy
            public float  m_alfa;                       // [ 107] Temperature Expansion
            public float  m_e90;                        // [1090] Transvers Elasticity
            public float  m_mue90;                      //        anisotrope Poisson
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fy;                         // [1092] effective strength
            public float  m_ft;                         // [1092] nominal strength
            public fixed float  m_p[18];                //        variable parameters
      } // cs_mat_undr

      public unsafe struct cs_mat_faul                  //        1/NR:15  Fault/Shear plane
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_gamb;                       // [1091] dead weight buyoncy
            public float  m_alfa;                       // [ 107] Temperature Expansion
            public float  m_e90;                        // [1090] Transvers Elasticity
            public float  m_mue90;                      //        anisotrope Poisson
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fy;                         // [1092] effective strength
            public float  m_ft;                         // [1092] nominal strength
            public fixed float  m_p[18];                //        variable parameters
      } // cs_mat_faul

      public unsafe struct cs_mat_swel                  //        1/NR:16  Swelling parameters
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_gamb;                       // [1091] dead weight buyoncy
            public float  m_alfa;                       // [ 107] Temperature Expansion
            public float  m_e90;                        // [1090] Transvers Elasticity
            public float  m_mue90;                      //        anisotrope Poisson
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fy;                         // [1092] effective strength
            public float  m_ft;                         // [1092] nominal strength
            public fixed float  m_p[18];                //        variable parameters
      } // cs_mat_swel

      public unsafe struct cs_mat_conc                  //        1/NR:1  MaterialConcrete
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] Dead weight
            public float  m_rho;                        // [ 159] Density
            public float  m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float  m_e90;                        // [1090] Elasticity modulus perpendicular
            public float  m_mue90;                      //        Poissons ratio perpendicular
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fc;                         // [1092] effective strength
            public float  m_fck;                        // [1092] nominal strength
            public float  m_ftm;                        // [1092] mean value of tensional strength
            public float  m_ftl;                        // [1092] lower fractile of tensional strength
            public float  m_ftk;                        // [1092] upper fractile of tensional strength
            public float  m_ec;                         //        compr. failure Energy (deprecated)
            public float  m_et;                         // [ 112] tensile failure energy
            public float  m_muer;                       //        friction in the crack
            public float  m_fcm;                        // [1092] mean value of strength
            public float  m_rdcl;                       //        weight class
            public float  m_fcr;                        // [1092] calculatoric mean value of strength
            public float  m_ecr;                        // [1090] Elasticity modul for worklaw CE
            public float  m_fbd;                        // [1092] bond strength (EC2 Table. 5.1.3)
            public float  m_ftd;                        // [1092] Initial tensile strength Bemessungszugfestigkeit
            public float  m_feqr;                       // [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
            public float  m_feqt;                       // [1092] Residual tensile strength  Restzugfestigkeit im Bruch
            public float  m_fcfat;                      // [1092] Fatigue Strength
            public float  m_scms;                       //        Material safety
            public float  m_scmu;                       //        Material safety
            public float  m_scmc;                       //        Material safety
      } // cs_mat_conc

      public unsafe struct cs_mat_stee                  //        1/NR:1  MaterialSteel
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_rho;                        // [ 159] Density
            public float  m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float  m_e90;                        // [1090] Elasticity modulus perpendicular
            public float  m_mue90;                      //        Poissons ratio perpendicular
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fy;                         // [1092] yield stress
            public float  m_ft;                         // [1092] tensile strength
            public float  m_eps;                        // [   9] limit strain
            public float  m_rel1;                       //        Relaxation 0.55fpk
            public float  m_rel2;                       //        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
            public float  m_r;                          //        bond coefficient
            public float  m_k1;                         //        bondfactor EC2
            public float  m_eh;                         // [1090] Hardening module
            public float  m_fe;                         // [1092] Proportional stress
            public float  m_epse;                       // [   9] Plastic strain
            public float  m_fdyn;                       // [1092] Dynamic strength
            public float  m_fyc;                        // [1092] compr. yield stress
            public float  m_ftc;                        // [1092] compress. strength
            public float  m_tmax;                       // [  16] max.plate thickness
            public float  m_bc;                         //        (eg. Aluminium 1.0/2.0 = "A","B" )
            public fixed float  m_dummy[2];
            public float  m_scms;                       //        Material safety
            public float  m_scmu;                       //        Material safety
            public float  m_scmc;                       //        Material safety
      } // cs_mat_stee

      public unsafe struct cs_mat_timb                  //        1/NR:1  MaterialTimber
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Material type
            public int  m_class;                        //        Classification
            public float  m_emod;                       // [1090] Elasticity Modulus along the fibres
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_rho;                        // [ 159] Density
            public float  m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float  m_e90;                        // [1090] Elasticity modulus perpendicular to fibres
            public float  m_mue90;                      //        Poissons ratio perpendicular
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fyb;                        // [1092] Bending strength
            public float  m_fyt;                        // [1092] tensile strength along the fibres
            public float  m_fyt90;                      // [1092] tensile strength perpend. the fibres
            public float  m_fyc;                        // [1092] compressive strength along the fibres
            public float  m_fyc90;                      // [1092] compressive strength perpend. the fibres
            public float  m_fys;                        // [1092] middle shear strength (Membrane Shear force)
            public float  m_fyst;                       // [1092] edge shear strength (Torsion)
            public float  m_fysb;                       // [1092] maximum shear strength (plate shear)
            public float  m_fyb90;                      // [1092] Bending strength perpendicular to fibres
            public float  m_g90;                        // [1090] transverse shear modulus for platebending
            public float  m_smod0;                      //        Strength Modifier kmod for Service classes
            public float  m_smod1;                      //        Strength Modifier kmod for Service classes
            public float  m_smod2;                      //        Strength Modifier kmod for Service classes
            public float  m_smod3;                      //        Strength Modifier kmod for Service classes
            public float  m_smod4;                      //        Strength Modifier kmod for Service classes
            public float  m_kdef;                       //        Deformation modifier
            public float  m_tmax;                       // [  16] max.plate thickness
            public float  m_scms;                       //        Material safety
            public float  m_scmu;                       //        Material safety
            public float  m_scmc;                       //        Material safety
      } // cs_mat_timb

      public unsafe struct cs_mat_bric                  //        1/NR:1  MaterialBrickwork
      {
            public int  m_id;                           //        Identification
            public int  m_type;                         //        Bric type and strength
            public int  m_class;                        //        Mortar class
            public float  m_emod;                       // [1090] Elasticity Modulus
            public float  m_mue;                        //        Poissons ratio
            public float  m_gmod;                       // [1090] Shear modulus
            public float  m_kmod;                       // [1090] Compression modulus
            public float  m_gam;                        // [1091] dead weight
            public float  m_rho;                        // [ 159] Density
            public float  m_alfa;                       // [ 107] Temperature Elongation coefficient
            public float  m_e90;                        // [1090] Elasticity modulus perpendicular
            public float  m_mue90;                      //        Poissons ratio perpendicular
            public float  m_alf;                        // [   5] Euler Angle I
            public float  m_bet;                        // [   5] Euler Angle II
            public float  m_scm;                        //        Material safety
            public float  m_fk;                         // [1092] Strength
            public float  m_fb;                         // [1092] brick strength
            public float  m_ft;                         // [1092] tensile strength
            public float  m_fv;                         // [1092] shear strength
            public float  m_fv0;                        // [1092] adhesional strength
            public float  m_fbt;                        // [1092] tens.brick strength
            public float  m_fm;                         // [1092] mortar strength
            public fixed float  m_dummy[10];
            public float  m_scms;                       //        Material safety
            public float  m_scmu;                       //        Material safety
            public float  m_scmc;                       //        Material safety
      } // cs_mat_bric

      public unsafe struct cs_mat_serv                  //        1/NR:2  StressStrainLaw (Servicability)
      {
            public int  m_id;                           //        Identification
            public int  m_temp;                         //        Temperature
            public int  m_type;                         //        Type of law
            public float  m_scm;                        //        Safety factor
            public float  m_eps;                        // [   9] Elongation at TEMP if TEMP>0
            public float  m_res1;                       // [   9] Shift of strains TEMP>0 (-TempStrain)
            public float  m_res2;                       //        Tensile Strength  Concrete   for 21:24
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_mat_serv

      public unsafe struct cs_mat_ulti                  //        1/NR:3  StressStrainLaw (Ultimate Limit state)
      {
            public int  m_id;                           //        Identification
            public int  m_temp;                         //        Temperature
            public int  m_type;                         //        Type of law
            public float  m_scm;                        //        Safety factor
            public float  m_eps;                        // [   9] Elongation at TEMP if TEMP>0
            public float  m_res1;                       // [   9] Shift of strains TEMP>0 (-TempStrain)
            public float  m_res2;                       //        Tensile Strength  Concrete   for 21:24
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_mat_ulti

      public unsafe struct cs_mat_nonl                  //        1/NR:4  StressStrainLaw (Nonlinear Mean Values)
      {
            public int  m_id;                           //        Identification
            public int  m_temp;                         //        Temperature
            public int  m_type;                         //        Type of law
            public float  m_scm;                        //        Safety factor
            public float  m_eps;                        // [   9] Elongation at TEMP if TEMP>0
            public float  m_res1;                       // [   9] Shift of strains TEMP>0 (-TempStrain)
            public float  m_res2;                       //        Tensile Strength  Concrete   for 21:24
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_mat_nonl

      public unsafe struct cs_mat_bed                   //        1/NR:7  MaterialBedding
      {
            public int  m_id;                           //        Identification
            public int  m_mnr;                          //        Materialnumber of bedding boddy
            public int  m_ibt;                          //        Type of bedding mechanism
            public float  m_c;                          // [1097] Bedding Coefficient
            public float  m_ct;                         // [1097] Tangential Bedding
            public float  m_riss;                       // [1092] rupture stress
            public float  m_flie;                       // [1092] yield   stress
            public float  m_mue;                        //        friction coefficient
            public float  m_koh;                        // [1092] cohesion
            public float  m_dil;                        //        dilatancy coeffic.
            public float  m_gam;                        // [1184] mass of bedding
            public float  m_h;                          // [1001] reference length
      } // cs_mat_bed

      public unsafe struct cs_mat_lay                   //        1/NR:8  MaterialLayerStructure
      {
            public int  m_id;                           //        Identification
            public int  m_nm;                           //        Number of a material
            public int  m_i_2;
            public float  m_t;                          // [1010] Thickness
      } // cs_mat_lay

      enum MAT_HYD_FLOW { MAT_HYD_FLOW = -1 }
      enum MAT_HYD_DARC { MAT_HYD_DARC = 0 }
      enum MAT_HYD_ADARC { MAT_HYD_ADARC = 1 }
      enum MAT_HYD_FORC { MAT_HYD_FORC = 2 }
      enum MAT_HYD_MISS { MAT_HYD_MISS = 3 }
      enum MAT_HYD_FOUR { MAT_HYD_FOUR = 4 }
      enum MAT_HYD_AFOUR { MAT_HYD_AFOUR = 5 }
      enum MAT_HYD_EC4S { MAT_HYD_EC4S = 6 }
      enum MAT_HYD_EC4C { MAT_HYD_EC4C = 7 }
      enum MAT_HYD_JONA { MAT_HYD_JONA = 16 }
      enum MAT_HYD_HSCM { MAT_HYD_HSCM = 17 }
      enum MAT_HYD_WESC { MAT_HYD_WESC = 18 }
      public unsafe struct cs_mat_hyd                   //        1/NR:9  MaterialConductivity
      {
            public int  m_id;                           //        Identification
            public int  m_t;                            //        Temperature / pressure
            public int  m_type;                         //        Type of Material law
            public float  m_d;                          //        special Parameter
            public float  m_c;                          //        Storage Capacity
            public float  m_n;                          //        Porosity/humidity
            public fixed float  m_k[6];                 //        Conductivity
            public fixed float  m_kloc[6];              //        Conductivity
      } // cs_mat_hyd

      public unsafe struct cs_mat_spe                   //        1/NR:90  MaterialSpecial
      {
            public int  m_id;                           //        Identification = 90
            public int  m_type;                         //        type of material value
            public int  m_exp;                          //        exposition class identifier (0=all classes)
            public fixed float  m_rval[10];             //        real material values
      } // cs_mat_spe

      public unsafe struct cs_bore                      //        2/NR:0  SoilProfile
      {
            public int  m_id;                           //        identifier 0 (always the first record)
            public float  m_x;                          // [1001] X_ordinate
            public float  m_y;                          // [1001] Y_ordinate
            public float  m_z;                          // [1001] Z_ordinate
            public float  m_dx;                         //        direction of axis
            public float  m_dy;                         //        direction of axis
            public float  m_dz;                         //        direction of axis
            public float  m_alf;                        // [   5] Angle of reference
            public float  m_hgwl;                       // [1006] lower ground water level
            public float  m_hgwh;                       // [1006] upper ground water level
            public fixed float  m_i_10[6];
            public fixed int m_text[17];                //        Designation of Profile
      } // cs_bore

      public unsafe struct cs_bore_lay                  //        2/NR:1  Soillayer
      {
            public int  m_id;                           //        Identifier 1
            public int  m_mnr;                          //        Material number
            public int  m_vari;                         //        Type of stiffness variation
            public int  m_ilay;                         //        Additional layer information
            public int  m_i_4;                          //        reserved
            public int  m_i_5;                          //        reserved
            public float  m_s;                          // [1001] Ordinate on bore profile axis (positive)
            public float  m_es;                         // [1096] Stiffness Modulus
            public float  m_des;                        // [1096] Increment of ES within current layer
            public float  m_mue;                        //        Poissons ratio
            public float  m_pmax;                       // [1096] Max. pressure at pile foot
            public float  m_pmal;                       // [1096] Max. lateral pressure
            public float  m_c;                          // [1096] Cohesion
            public float  m_phi;                        // [   5] Soil/Pile friction angle
            public float  m_gam;                        // [1091] Specific weight
            public float  m_gamb;                       // [1091] Specific weight under buoyancy
      } // cs_bore_lay

      public unsafe struct cs_bore_tab                  //        2/NR:10  SoilTabdefinition
      {
            public int  m_id;                           //        Identifier 10
            public int  m_opt;                          //        Option
            public int  m_class;                        //        Classification subtype
            public float  m_facs;                       //        Factor on stresses
            public fixed float  m_b[10];                // [1001] Width of foundation
      } // cs_bore_tab

      public unsafe struct cs_bore_tad                  //        2/NR:11  SoilTabvalues
      {
            public int  m_id;                           //        Identifier 11
            public int  m_i_1;                          //        reserved
            public int  m_i_2;                          //        reserved
            public float  m_d;                          // [1006] Embedment depth of foundation
            public fixed float  m_sigd[10];             // [1089] design stresses at specified depth values
      } // cs_bore_tad

      public unsafe struct cs_bore_bax                  //        2/NR:1001  BoreProfileAxial
      {
            public int  m_id;                           //        identifier 1001
            public float  m_z1;                         //        parameter s on start
            public float  m_z2;                         //        parameter s on end
            public float  m_k0;                         // [1096] constant bedding
            public float  m_k1;                         // [1096] parabolic bedding
            public float  m_k2;                         // [1096] linear bedding
            public float  m_k3;                         // [1096] quadratic bedding
            public float  m_m0;                         // [1153] cohesive loading
            public float  m_c0;                         // [1153] cohesion
            public float  m_tanr;                       //        friction angle
            public float  m_tand;                       //        dilatancy angle
            public float  m_kq;                         //        pressure coefficient
            public float  m_pmax;                       // [1101] maxforce at pile foot
      } // cs_bore_bax

      public unsafe struct cs_bore_bla                  //        2/NR:1002  BoreProfileTransverse
      {
            public int  m_id;                           //        identifier 1002
            public float  m_z1;                         //        parameter s on start
            public float  m_z2;                         //        parameter s on end
            public float  m_k0;                         // [1096] constant bedding
            public float  m_k1;                         // [1096] parabolic bedding
            public float  m_k2;                         // [1096] linear bedding
            public float  m_k3;                         // [1096] quadratic bedding
            public float  m_f0;                         //        peripher Distribution
            public float  m_f1;
            public float  m_f2;
            public float  m_pm1;                        // [1153] maximum value on upper ordinate
            public float  m_pm2;                        // [1153] maximum value on lower ordinate
            public float  m_p0;                         //        peripher Distribution
            public float  m_p1;
            public float  m_p2;
            public float  m_p3;
      } // cs_bore_bla

      public unsafe struct cs_bore_bam                  //        2/NR:1003  BoreProfileMoment
      {
            public int  m_id;                           //        identifier 1003
            public float  m_z1;                         //        parameter s on start
            public float  m_z2;                         //        parameter s on end
            public float  m_k0;                         // [1099] constant bedding
            public float  m_k1;                         // [1099] parabolic bedding
            public float  m_k2;                         // [1099] linear bedding
            public float  m_k3;                         // [1099] quadratic bedding
      } // cs_bore_bam

      public unsafe struct cs_bore_dya                  //        2/NR:1011  BoreProfileAxialDynamic
      {
            public int  m_id;                           //        identifier 1011
            public float  m_z1;                         //        parameter s on start
            public float  m_z2;                         //        parameter s on end
            public float  m_d0;                         // [ 105] constant damping
            public float  m_d1;                         // [ 105] parabolic damping
            public float  m_d2;                         // [ 105] linear damping
            public float  m_d3;                         // [ 105] quadratic damping
      } // cs_bore_dya

      public unsafe struct cs_bore_dyl                  //        2/NR:1012  BoreProfileTransverseDynamic
      {
            public int  m_id;                           //        identifier 1012
            public float  m_z1;                         //        parameter s on start
            public float  m_z2;                         //        parameter s on end
            public float  m_d0;                         // [ 105] constant damping
            public float  m_d1;                         // [ 105] parabolic damping
            public float  m_d2;                         // [ 105] linear damping
            public float  m_d3;                         // [ 105] quadratic damping
            public float  m_m0;                         // [1181] constant soil mass
            public float  m_m2;                         // [1181] linear soil mass
      } // cs_bore_dyl

      enum AXIS_SUBTYPE_NONE { AXIS_SUBTYPE_NONE = 0 }
      enum AXIS_SUBTYPE_AXIS { AXIS_SUBTYPE_AXIS = 1 }
      enum AXIS_SUBTYPE_BEAM { AXIS_SUBTYPE_BEAM = 2 }
      enum AXIS_SUBTYPE_LANE { AXIS_SUBTYPE_LANE = 10 }
      enum AXIS_SUBTYPE_BGEO { AXIS_SUBTYPE_BGEO = 11 }
      enum AXIS_SUBTYPE_TEND { AXIS_SUBTYPE_TEND = 12 }
      enum AXIS_SUBTYPE_POST { AXIS_SUBTYPE_POST = 15 }
      enum AXIS_SUBTYPE_AUXI { AXIS_SUBTYPE_AUXI = 19 }
      enum AXIS_SUBTYPE_GRAF { AXIS_SUBTYPE_GRAF = 90 }
      public unsafe struct cs_axis                      //        3/ID:0  Geometric Axis
      {
            public int  m_id0;                          //        identifier 0
            public int  m_id1;                          //        subtype of axis
            public int  m_id2;                          //        reserved
            public int  m_id3;                          //        reserved
            public int  m_id4;                          //        reserved
            public int  m_id5;                          //        reserved
            public fixed int m_text[17];                //        Designation of Line
      } // cs_axis

      public unsafe struct cs_axis_ref                  //        3/ID:-  Reference to another Geometry
      {
            public int  m_igm;                          //        negative value of the master geometry 03/abs(IGM)
            public int  m_igs;                          //        optional identifier of a secondary axis
            public float  m_smin;                       //        min parameter on referenced axis
            public float  m_smax;                       //        max parameter on referenced axis
      } // cs_axis_ref

      enum GAX_GEO_DEFAULT { GAX_GEO_DEFAULT = 1 }
      enum GAX_GEO_PROJECT { GAX_GEO_PROJECT = 2 }
      enum GAX_GEO_SPLINE { GAX_GEO_SPLINE = 3 }
      enum GAX_GEO_EXSPLI { GAX_GEO_EXSPLI = 4 }
      enum GAX_GEO_BEZIER { GAX_GEO_BEZIER = 5 }
      enum GAX_GEO_NURBS { GAX_GEO_NURBS = 6 }
      enum GAX_GEO_NURBX { GAX_GEO_NURBX = 7 }
      enum GAX_GEO_DATA { GAX_GEO_DATA = 8 }
      enum GAX_GEO_NORM { GAX_GEO_NORM = 9 }
      enum GAX_GEO_CIRC { GAX_GEO_CIRC = 11 }
      enum GAX_GEO_CBEZIER { GAX_GEO_CBEZIER = 15 }
      enum GAX_GEO_CNURBS { GAX_GEO_CNURBS = 16 }
      enum GAX_GEO_PROJ_CLO { GAX_GEO_PROJ_CLO = 20 }
      enum GAX_GEO_PROJ_CUB { GAX_GEO_PROJ_CUB = 21 }
      enum GAX_GEO_PROJ_BLO { GAX_GEO_PROJ_BLO = 22 }
      enum GAX_GEO_PROJ_SIN { GAX_GEO_PROJ_SIN = 24 }
      enum GAX_GEO_PROJ_COS { GAX_GEO_PROJ_COS = 25 }
      enum GAX_GEO_NURBS_KN { GAX_GEO_NURBS_KN = 90 }
      enum GAX_GEO_NURBS_CPT { GAX_GEO_NURBS_CPT = 91 }
      public unsafe struct cs_axis_geo                  //        3/ID:??  Geometric properties
      {
            public int  m_iln;                          //        Code of geometry
            public float  m_gpg;                        // [1001] geometry parameter 1
            public float  m_gpa;                        // [1001] geometry parameter 2
            public float  m_dd;                         // [1001] arc length
            public float  m_s1;                         //        parameter s on start
            public fixed float  m_xyz1[3];              // [1001] Ordinate of start
            public fixed float  m_dxyz1[3];             //        Tangent of start
            public float  m_rg1;                        // [1009] in-plane curvature
            public float  m_ra1;                        // [1009] vertical curvature
            public float  m_s2;                         //        parameter s on end
            public fixed float  m_xyz2[3];              // [1001] Ordinate of endpoint
            public fixed float  m_dxyz2[3];             //        Tangent of endpoint
            public float  m_rg2;                        // [1009] in-plane curvature
            public float  m_ra2;                        // [1009] vertical curvature
            public float  m_xat;                        // [1001] relat. startordinate
      } // cs_axis_geo

      public unsafe struct cs_axis_nkn                  //        3/ID:90  Knots of a Nurb
      {
            public int  m_iln;                          //        ID=90
            public int  m_deg;                          //        Order of Spline
            public fixed float  m_s[256];               //        Knot-Vector
      } // cs_axis_nkn

      public unsafe struct cs_sln_nkn                   //        39/NR:90  Knots of a Nurb
      {
            public int  m_iln;                          //        ID=90
            public int  m_deg;                          //        Order of Spline
            public fixed float  m_s[256];               //        Knot-Vector
      } // cs_sln_nkn

      public unsafe struct cs_axis_cpt                  //        3/ID:91  Control point of a Nurb
      {
            public int  m_iln;                          //        ID=91
            public float  m_w;                          //        Weight
            public fixed float  m_xyz[3];               // [1001] Coordinates
            public fixed float  m_dir[3];               //        upward direction
      } // cs_axis_cpt

      public unsafe struct cs_sln_cpt                   //        39/NR:91  Control point of a Nurb
      {
            public int  m_iln;                          //        ID=91
            public float  m_w;                          //        Weight
            public fixed float  m_xyz[3];               // [1001] Coordinates
            public fixed float  m_dir[3];               //        upward direction
      } // cs_sln_cpt

      public unsafe struct cs_axis_pt                   //        3/ID:92  Data point on curve
      {
            public int  m_iln;                          //        ID=92
            public float  m_s;                          //        Parameter along curve
            public fixed float  m_xyz[3];               // [1001] Coordinates
            public fixed float  m_dir[3];               //        upward direction
      } // cs_axis_pt

      public unsafe struct cs_sln_pt                    //        39/NR:92  Data point on curve
      {
            public int  m_iln;                          //        ID=92
            public float  m_s;                          //        Parameter along curve
            public fixed float  m_xyz[3];               // [1001] Coordinates
            public fixed float  m_dir[3];               //        upward direction
      } // cs_sln_pt

      public unsafe struct cs_axis_arc                  //        3/ID:93  Circular Arc
      {
            public int  m_iln;                          //        ID=93
            public int  m_idf;                          //        Definition selected
            public float  m_r;                          // [1001] Radius of arc
            public fixed float  m_xyz[3];               // [1001] Coordinates of center
            public fixed float  m_dir[3];               //        upward direction of plane
            public fixed float  m_xyza[3];              // [1001] optional start point of arc
            public fixed float  m_xyze[3];              // [1001] optional end point of arc
      } // cs_axis_arc

      public unsafe struct cs_sln_arc                   //        39/NR:93  Circular Arc
      {
            public int  m_iln;                          //        ID=93
            public int  m_idf;                          //        Definition selected
            public float  m_r;                          // [1001] Radius of arc
            public fixed float  m_xyz[3];               // [1001] Coordinates of center
            public fixed float  m_dir[3];               //        upward direction of plane
            public fixed float  m_xyza[3];              // [1001] optional start point of arc
            public fixed float  m_xyze[3];              // [1001] optional end point of arc
      } // cs_sln_arc

      public unsafe struct cs_axis_spt                  //        3/ID:97  Station point on a Nurb
      {
            public int  m_iln;                          //        ID=97
            public float  m_s;                          //        Station value at data point
            public float  m_l;                          // [1001] Length (prescribed if XYZ==0.0)
            public fixed float  m_xyz[3];               // [1001] Coordinates for 3D-intersection plane
            public fixed float  m_dir[3];               //        Direction (nx,ny,nz) of normal of the plane
      } // cs_axis_spt

      public unsafe struct cs_axis_viz                  //        3/ID:98  Data points for visualisation
      {
            public int  m_iln;                          //        ID=98
            public int  m_color;                        //        hexadecimal RGB-value (e.g. 99AAFF)
            public int  m_thick;                        //        Thickness in pixel
            public fixed float  m_pts[64*3];            // [1001] Data Points
      } // cs_axis_viz

      public unsafe struct cs_axis_obb                  //        3/ID:99  Oriented Boundig Box
      {
            public int  m_iln;                          //        ID=99
            public float  m_s1;                         //        Parameter on Start
            public float  m_s2;                         //        Parameter on end
            public fixed float  m_ta[3*3];              //        Transformation Matrix
            public fixed float  m_xyz[3];               // [1001] Center of Box
            public fixed float  m_xi[3];                // [1001] Half widths
      } // cs_axis_obb

      public unsafe struct cs_axis_atb                  //        3/ID:101  Geometric segments of axis plan view
      {
            public int  m_id0;                          //        ident 101
            public int  m_id1;                          //        specification type
            public int  m_id2;                          //        type of transition curve to be used
            public float  m_s;                          //        Station value at tangent
            public fixed float  m_l[5];                 // [1001] Length of segment
            public fixed float  m_r[5];                 // [1001] Radius mid & start & end
            public fixed float  m_xyz[3];               // [1001] Startpoint of tangent
            public fixed float  m_dir[3];               //        Tangential direction
            public fixed float  m_d[2];                 // [1001] Distance to point on curve (start/end)
            public float  m_tau;                        // [   5] deflection angle
            public int  m_txt;                          //        Identifier of this sequence
      } // cs_axis_atb

      public unsafe struct cs_axis_vtb                  //        3/ID:102  Geometric properties for axis heights
      {
            public int  m_id0;                          //        ident 102
            public int  m_id1;                          //        specification type
            public int  m_id2;                          //        reserved
            public float  m_s;                          //        Parameter s along the axis
            public float  m_h;                          // [1001] Height of gradient polygon
            public float  m_r;                          // [1001] Radius of curvature at this point
            public float  m_x;                          // [1001] Calculated true length along the axis
            public float  m_t;                          // [1001] Calculated secant length along the axis
      } // cs_axis_vtb

      public unsafe struct cs_axis_itb                  //        3/ID:103  Placement at axis position
      {
            public int  m_id0;                          //        ident 103
            public int  m_ids;                          //        Enum of secondary axis
            public int  m_typ;                          //        properties of this placement
            public int  m_npt;                          //        point number
            public int  m_grp;                          //        group number behind that placement
            public fixed int  m_nos[2];                 //        Number of section before and behind that placement
            public int  m_segt;                         //        identifier of a segment see (900/0) behind that placement
            public float  m_s;                          //        Parameter s of this section
            public float  m_y;                          // [1001] additional transverse offset
            public float  m_z;                          // [1001] additional vertical offset
            public float  m_alf;                        // [   5] Rotation about global Z
            public float  m_alfx;                       // [   5] Rotation about local axis x
            public float  m_alfy;                       // [   5] Rotation about transverse y
            public float  m_alfz;                       // [   5] Rotation about vertical   z
            public float  m_incr;                       // [   5] Inclination to the right +y
            public float  m_incl;                       // [   5] Inclination to the left  -y
            public fixed int  m_srule[5];               //        Formula string to evaluate the value S
            public fixed int m_text[17];                //        Designation of Placement
      } // cs_axis_itb

      public unsafe struct cs_axis_its                  //        3/ID:104  Secondary axis definition
      {
            public int  m_id0;                          //        Ident 104
            public int  m_ids;                          //        Enum of secondary axis (1='A' to 26 ='Z')
            public int  m_iref;                         //        Reference to external axis geometry
            public int  m_npt;                          //        offset for structural points along the axis
            public int  m_grp;                          //        group number (:103 is always added as an offset)
            public float  m_y;                          // [1001] constant or maximum value of y offset
            public float  m_z;                          // [1001] constant or maximum value of z offset
            public fixed int  m_y_v[4];                 //        variable name for y offset (see :110)
            public fixed int  m_z_v[4];                 //        variable name for z offset (see :110)
            public fixed int m_text[17];                //        Designation (only for first point of a sequence)
      } // cs_axis_its

      public unsafe struct cs_axis_psm                  //        3/ID:105  Prestress method
      {
            public int  m_id0;                          //        ident 105
            public int  m_idt;                          //        Identifier of Tendon
            public int  m_type;                         //        Type of Spline geometry
            public int  m_nsp;                          //        Number of tendon elements
            public int  m_id5;                          //        Placement of tendons
            public int  m_jack;                         //        Jacking procedure
            public int  m_lire;                         //        Sides for jacking
            public fixed int  m_iba[3];                 //        Construction stage identifiers
            public int  m_nrsv;                         //        number of jacking method
            public fixed int  m_dummy[5];               //        reserved
            public float  m_fak;                        //        factor for prestress
            public float  m_litz;                       //        partial number of strands
            public fixed float  m_frsp[2];              // [1001] Length controls for free tendon geometry
            public fixed float  m_zsp[2];               // [1011] Distances of tendon to extreme fiber upper/lower
            public fixed int m_textl[17];               //        Designation of layer of Tendons
      } // cs_axis_psm

      public unsafe struct cs_axis_psp                  //        3/ID:106  Prestress placements
      {
            public int  m_id0;                          //        ident 106
            public int  m_typ;                          //        Type of placement
            public int  m_id2;                          //        Type of station data (bitpattern)
            public int  m_id3;                          //        reserved
            public int  m_id4;                          //        reserved
            public int  m_id5;                          //        reserved
            public float  m_s;                          //        Station along axis
            public float  m_zt;                         // [1011] Distances of tendon to extreme fiber upper/lower
            public float  m_dzt;                        //        inclination of tendon to axis
      } // cs_axis_psp

      public unsafe struct cs_axis_plc                  //        3/ID:107  Placement at axis position
      {
            public int  m_id0;                          //        ident 107
            public int  m_ids;                          //        Enum of secondary axis
            public int  m_typ;                          //        properties of this placement
            public int  m_npt;                          //        point number
            public int  m_grp;                          //        group number behind that placement
            public fixed int  m_nos[2];                 //        Number of section before and behind that placement
            public int  m_ib0;                          //        general bit-mask
            public int  m_idp;                          //        identifier of this placement
            public int  m_segt;                         //        identifier of a segment see (900/0) behind that placement
            public fixed int  m_res[6];                 //        reserved
            public float  m_s;                          //        Parameter s of this section
            public float  m_y;                          // [1001] additional transverse offset
            public float  m_z;                          // [1001] additional vertical offset
            public float  m_alf;                        // [   5] Rotation about global Z
            public float  m_alfx;                       // [   5] Rotation about local axis x
            public float  m_alfy;                       // [   5] Rotation about transverse y
            public float  m_alfz;                       // [   5] Rotation about vertical   z
            public float  m_incr;                       // [   5] Inclination to the right +y
            public float  m_incl;                       // [   5] Inclination to the left  -y
            public fixed int  m_srule[5];               //        Formula string to evaluate the value S
            public fixed int m_text[17];                //        Designation of placement
      } // cs_axis_plc

      public unsafe struct cs_axis_opt                  //        3/ID:10107  Placement options
      {
            public int  m_id0;                          //        ident 10107
            public int  m_a_filter;                     //        Filter for axis
            public int  m_t_filter;                     //        Filter for axis type
      } // cs_axis_opt

      public unsafe struct cs_axis_prp                  //        3/ID:110  General properties of axis
      {
            public int  m_id0;                          //        ident 110
            public fixed int  m_name[4];                //        Name of this item
            public int  m_typ;                          //        Continuity Type of this data point
            public fixed float  m_s_val[5];             //        Parameter s of this section and values
            public fixed int  m_srule[5];               //        Formula string to evaluate the value S
            public fixed int  m_vrule[10];              //        Formula string to evaluate the value VAL
            public fixed int  m_dvrule[10];             //        Formula string to evaluate the value dVAL/dS
      } // cs_axis_prp

      public unsafe struct cs_gaxd_atb                  //        3/ID:121  Geometric segments of axis plan view (double precision)
      {
            public int  m_id0;                          //        ident 201
            public int  m_id1;                          //        specification type
            public int  m_id2;                          //        type of transition curve to be used
            public int  m_id3;                          //        reserved
            public double  m_s;                         //        Station value at tangent
            public fixed double  m_l[5];                // [1001] Length of segment
            public fixed double  m_r[5];                // [1001] Radius mid & start & end
            public fixed double  m_xyz[3];              // [1001] Startpoint of tangent
            public fixed double  m_dir[3];              //        Tangential direction
            public fixed double  m_d[2];                // [1001] Distance to point on curve (start/end)
            public double  m_tau;                       // [   5] deflection angle
            public int  m_txt0;                         //        reserved
            public int  m_txt;                          //        Identifier of this sequence
      } // cs_gaxd_atb

      public unsafe struct cs_gaxd_vtb                  //        3/ID:122  Geometric properties for axis heights (double precision)
      {
            public int  m_id0;                          //        ident 202
            public int  m_id1;                          //        specification type
            public int  m_id2;                          //        reserved
            public int  m_id3;                          //        reserved
            public double  m_s;                         //        Parameter s along the axis
            public double  m_h;                         // [1001] Height of gradient polygon
            public double  m_r;                         // [1001] Radius of curvature at this point
            public double  m_x;                         // [1001] Calculated true length along the axis
            public double  m_t;                         // [1001] Calculated secant length along the axis
      } // cs_gaxd_vtb

      enum GAXD_GEO_DEFAULT { GAXD_GEO_DEFAULT = 181 }
      enum GAXD_GEO_PROJECT { GAXD_GEO_PROJECT = 182 }
      public unsafe struct cs_gaxd_geo                  //        3/ID:18?  Geometric properties
      {
            public int  m_iln;                          //        Code of geometry
            public int  m_id1;                          //        reserved
            public double  m_gpg;                       // [1001] geometry parameter 1
            public double  m_gpa;                       // [1001] geometry parameter 2
            public double  m_dd;                        // [1001] arc length
            public double  m_s1;                        //        parameter s on start
            public fixed double  m_xyz1[3];             // [1001] Ordinate of start
            public fixed double  m_dxyz1[3];            //        Tangent of start
            public double  m_rg1;                       // [1009] in-plane curvature
            public double  m_ra1;                       // [1009] vertical curvature
            public double  m_s2;                        //        parameter s on end
            public fixed double  m_xyz2[3];             // [1001] Ordinate of endpoint
            public fixed double  m_dxyz2[3];            //        Tangent of endpoint
            public double  m_rg2;                       // [1009] in-plane curvature
            public double  m_ra2;                       // [1009] vertical curvature
            public double  m_xat;                       // [1001] relat. startordinate
      } // cs_gaxd_geo

      public unsafe struct cs_gaxd_nkn                  //        3/ID:190  Knots of a Nurb
      {
            public int  m_iln;                          //        ID=290
            public int  m_deg;                          //        Order of Spline
            public fixed double  m_s[256];              //        Knot-Vector
      } // cs_gaxd_nkn

      public unsafe struct cs_gaxd_cpt                  //        3/ID:191  Control point of a Nurb
      {
            public int  m_iln;                          //        ID=191
            public int  m_id1;                          //        reserved
            public double  m_w;                         //        Weight
            public fixed double  m_xyz[3];              // [1001] Coordinates
            public fixed double  m_dir[3];              //        upward direction
      } // cs_gaxd_cpt

      public unsafe struct cs_gaxd_pt                   //        3/ID:192  Data point on curve
      {
            public int  m_iln;                          //        ID=192
            public int  m_id1;                          //        specification type
            public double  m_s;                         //        Parameter along curve
            public fixed double  m_xyz[3];              // [1001] Coordinates
            public fixed double  m_dir[3];              //        direction
      } // cs_gaxd_pt

      public unsafe struct cs_gaxd_arc                  //        3/ID:193  Circular Arc
      {
            public int  m_iln;                          //        ID=93
            public int  m_idf;                          //        Definition selected
            public double  m_r;                         // [1001] Radius of arc
            public fixed double  m_xyz[3];              // [1001] Coordinates of center
            public fixed double  m_dir[3];              //        upward direction of plane
            public fixed double  m_xyza[3];             // [1001] optional start point of arc
            public fixed double  m_xyze[3];             // [1001] optional end point of arc
      } // cs_gaxd_arc

      public unsafe struct cs_axis_trl                  //        3/ID:300  Properties for train loading
      {
            public int  m_id0;                          //        ident 300
            public int  m_nra;                          //        Number of the lane (0:99)
            public int  m_nrs;                          //        Number of the segment
            public int  m_btyp;                         //        Literal of default type
            public float  m_sa;                         //        Parameter s of start of this section
            public float  m_se;                         //        Parameter s of end of this section
            public float  m_yca;                        // [1001] Center ordinate of lane at SA
            public float  m_yce;                        // [1001] Center ordinate of lane at SE
            public float  m_yra;                        // [1001] Right boundary at SA of lane area
            public float  m_yre;                        // [1001] Right boundary at SE of lane area
            public float  m_yla;                        // [1001] Left boundary at SA of lane area
            public float  m_yle;                        // [1001] Left boundary at SE of lane area
            public float  m_l;                          // [1001] Reference length for impact factor
            public float  m_hsa;                        // [1001] Total height of traffic lane above axis at SA
            public float  m_hse;                        // [1001] Total height of traffic lane above axis at SE
            public float  m_inca;                       // [   5] Inclination within lane at SA
            public float  m_ince;                       // [   5] Inclination within lane at SE
            public float  m_heff;                       // [1001] Height of rail and sleeper construction
            public float  m_beff;                       // [1001] Effective length of sleeper
            public float  m_deff;                       // [1001] Width of sleepers
            public float  m_incd;                       //        Inclination of load distribution (e.g. 1:4)
            public float  m_asl;                        // [1001] Distance of Sleepers or mounting points
      } // cs_axis_trl

      public unsafe struct cs_tend                      //        4/ID:0  Prestressing Schemes
      {
            public int  m_id0;                          //        identifier 0
            public int  m_key;                          //        Control bits + Info
            public int  m_mnr;                          //        Material number Steel
            public fixed int m_txt[17];                 //        Main Designation of company and scheme
      } // cs_tend

      public unsafe struct cs_tend_1                    //        4/ID:1  Tendon of Prestressing Schemes
      {
            public int  m_id0;                          //        identifier 1
            public int  m_id1;                          //        reserved
            public int  m_id2;                          //        reserved
            public float  m_zv;                         // [1028] Nominal force
            public float  m_az;                         // [1020] Area of tendon
            public float  m_rnli;                       //        Number or wires
            public float  m_sls;                        // [  16] Slip at anchor
            public float  m_slk;                        // [  16] Slip at coupling
            public float  m_slf;                        // [  16] Slip at fixed end
            public float  m_vls;                        //        Loss at anchor
            public float  m_vlk;                        //        Loss at coupling
            public float  m_vlf;                        //        Loss at fixed end
            public float  m_dls;                        // [1001] Straight at anchor
            public float  m_dlk;                        // [1001] Straight at coupling
            public float  m_dlf;                        // [1001] Straight at fixed end
            public float  m_di;                         // [1023] inner diameter of duct
            public float  m_da;                         // [1023] outer diamtere of duct
            public float  m_rmin;                       // [1001] minimum radius
            public fixed float  m_beta[2];              // [  17] unintended angles
            public fixed float  m_rmue[2];              //        Friction coefficients
            public float  m_exz;                        // [1011] max exzentricity
            public float  m_eachs;                      // [1011] distance between
            public float  m_erand;                      // [1011] distance to outer edge
            public fixed float  m_block[8];             //        reserved extra data
            public fixed int m_txt[17];                 //        Designation of tendon
      } // cs_tend_1

      public unsafe struct cs_tend_2                    //        4/ID:2  Anchor of Prestressing Schemes
      {
            public int  m_id0;                          //        identifier 2
            public int  m_id1;                          //        Type of anchor
            public int  m_typ;                          //        Type of anchor geometry
            public fixed float  m_anker[16];            //        Data
            public fixed int m_txt[17];                 //        Designation of anchor
      } // cs_tend_2

      public unsafe struct cs_tend_3                    //        4/ID:3  Jack of Prestressing Schemes
      {
            public int  m_id0;                          //        identifier 2
            public int  m_id1;                          //        reserved
            public int  m_typ;                          //        Type of jack
            public fixed float  m_jack[16];             //        Data
            public fixed int m_txt[17];                 //        Designation of jack
      } // cs_tend_3

      public unsafe struct cs_area                      //        5/ID:0  Geometric Area
      {
            public int  m_id0;                          //        identifier 0
            public int  m_ng;                           //        Type of surface representation
            public int  m_gid1;                         //        Axis identifier of first reference axis
            public int  m_gid2;                         //        Axis identifier of second reference axis
            public int  m_mgri;                         //        number of data/control points in s of mesh
            public int  m_ngri;                         //        number of data/control points in t of mesh
            public int  m_mspl;                         //        degree of B-spline in s direction
            public int  m_nspl;                         //        degree of B-spline in t direction
            public int  m_sflg;                         //        property options of surface
            public fixed float  m_t[4*3];               //        Transformation
            public fixed float  m_par[16];              //        additional Parameters
            public fixed float  m_box[3*2];             // [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
            public fixed int m_text[17];                //        Designation of Line
      } // cs_area

      public unsafe struct cs_area_cpt                  //        5/ID:10  Control points of area
      {
            public int  m_id;                           //        Identification of control point data = 10
            public fixed float  m_xpar[9999];           //        spline grid and coefficients
      } // cs_area_cpt

      public unsafe struct cs_area_pts                  //        5/ID:11  AreaPointonSurface
      {
            public int  m_id;                           //        Identification of surface description = 11
            public int  m_it;                           //        Type of point
            public int  m_m;                            //        Rasterlocation of mesh (0 < m < mgri )
            public int  m_n;                            //        Rasterlocation of mesh (0 < n < ngri )
            public float  m_w;                          //        the weight of NURBS control point
            public float  m_x;                          // [1001] X-ordinate
            public float  m_y;                          // [1001] Y-ordinate
            public float  m_z;                          // [1001] Z-ordinate
            public float  m_t;                          // [1010] Thickness
      } // cs_area_pts

      public unsafe struct cs_area_cpi                  //        5/ID:12  COONsPatchInfo
      {
            public int  m_id;                           //        Identification of COONs blending edges 12
            public int  m_it;                           //        Type of blending
            public int  m_iu0;                          //        No of geometry line for u=umin (left)
            public int  m_iu1;                          //        No of geometry line for u=umax (right)
            public int  m_iv0;                          //        No of geometry line for v=vmin (lower)
            public int  m_iv1;                          //        No of geometry line for v=vmax (upper)
            public fixed float  m_sp[4*3];              //        Length parameters for the edges iu0,iu1,iv0,iv1
            public fixed float  m_uv[2*2];              //        umin,umax,vmin,vmax of the parameter plane
            public fixed float  m_cxyz[4*3];            //        Coordinates of the corner points C1,C2,C3,C4
            public fixed float  m_tinc[8*3];            //        inclinations for a bicubic patch as vectors
            public fixed float  m_twist[4*3];           //        Twist of x,y,z-Ordinate at corner C1 (0,0)
      } // cs_area_cpi

      public unsafe struct cs_area_nkn                  //        5/ID:9?  Knots of a Nurb
      {
            public int  m_iln;                          //        ID
            public int  m_deg;                          //        Order of Spline
            public fixed float  m_s[256];               //        Knot-Vector
      } // cs_area_nkn

      public unsafe struct cs_gard_pts                  //        5/ID:290  AreaPointonSurface
      {
            public int  m_id;                           //        Id = 290
            public int  m_it;                           //        Type of point
            public int  m_m;                            //        Rasterlocation of mesh (0 < m < mgri )
            public int  m_n;                            //        Rasterlocation of mesh (0 < n < ngri )
            public double  m_w;                         //        the weight of NURBS control point
            public double  m_x;                         // [1001] X-ordinate
            public double  m_y;                         // [1001] Y-ordinate
            public double  m_z;                         // [1001] Z-ordinate
            public double  m_t;                         // [1010] Thickness
      } // cs_gard_pts

      public unsafe struct cs_gard_nku                  //        5/ID:291  Knots of a Nurb
      {
            public int  m_iln;                          //        ID
            public int  m_deg;                          //        Order of Spline
            public fixed double  m_s[256];              //        Knot-Vector
      } // cs_gard_nku

      public unsafe struct cs_gard_nkv                  //        5/ID:292  Knots of a Nurb
      {
            public int  m_iln;                          //        ID
            public int  m_deg;                          //        Order of Spline
            public fixed double  m_s[256];              //        Knot-Vector
      } // cs_gard_nkv

      public unsafe struct cs_con_0                     //        8/ID:0  Connection Headder
      {
            public int  m_ids;                          //        Identification = 0
            public int  m_typ;                          //        Type of connection
            public int  m_mat;                          //        Materialnumber for all plates
            public fixed int m_text[17];                //        designation of connection
      } // cs_con_0

      public unsafe struct cs_con_bol                   //        8/ID:1  Definition of Bolts
      {
            public int  m_ids;                          //        Identification = 1
            public int  m_typ;                          //        Type of hole
            public int  m_mat;                          //        Materialdesignation of bolt
            public float  m_d;                          // [1011] Diameter of bolt
            public fixed int  m_norm[4];                //        Designation of product code
            public fixed int m_text[17];                //        designation of bolt
      } // cs_con_bol

      public unsafe struct cs_con_wel                   //        8/ID:2  Definition of Weldings
      {
            public int  m_ids;                          //        Identification = 2
            public int  m_typ;                          //        Type of weld
            public int  m_mat;                          //        Materialnumber of weld (not used)
            public float  m_t;                          // [1011] Thickness of weld
            public float  m_aw;                         //        Reduction factor
            public fixed int m_text[17];                //        designation of weld
      } // cs_con_wel

      public unsafe struct cs_con_cle                   //        8/ID:3  Definition of Cleats (Angle/Latch)
      {
            public int  m_ids;                          //        Identification = 3
            public int  m_typ;                          //        Enum of type (angle/latch not really enforced)
            public int  m_mat;                          //        Material number of the plate
            public fixed int  m_bol[2];                 //        id of bolts
            public fixed int  m_nbb[2];                 //        Number of bolts in width direction
            public fixed int  m_nbl[2];                 //        Number of bolts in angle directions 1 & 2
            public float  m_t;                          // [1011] Thickness of cleat
            public float  m_b;                          // [1011] Width/Height of cleat
            public fixed float  m_l[2];                 // [1011] Length of angles
            public fixed float  m_w[8];                 // [1011] Distances
            public fixed float  m_a[2];                 // [1011] weld thickness for NBL(i) if welding is used
            public float  m_tf;                         // [1011] Thickness of backplate
            public fixed int m_text[17];                //        designation of element
      } // cs_con_cle

      public unsafe struct cs_con_mem                   //        8/ID:10  Connected Member data
      {
            public int  m_ids;                          //        Identification = 10
            public int  m_nr;                           //        Enumeration or designation of member
            public int  m_typ;                          //        Type of connection bitpattern
            public int  m_nrq;                          //        Number of section
            public int  m_wtyp;                         //        id of the web connection
            public int  m_utyp;                         //        id of the upper flange connection
            public int  m_ltyp;                         //        id of the lower flange connection
            public float  m_l;                          // [1001] length of member
            public float  m_aw;                         // [1011] weld thickness for web connection
            public float  m_au;                         // [1011] weld thickness for upper flange connection
            public float  m_al;                         // [1011] weld thickness for lower flange connection
            public float  m_dd;                         // [1011] Distance value of endpoint to central node
            public fixed float  m_d[3];                 //        Direction vector to beam axis in the
            public float  m_roty;                       // [   5] Angle of end plate y-rotation
            public float  m_rotz;                       // [   5] Angle of end plate z-rotation
            public float  m_cutu;                       // [1011] Cut out height for upper flange
            public float  m_cutl;                       // [1011] Cut out height for lower flange
            public float  m_clu;                        // [1011] Cut out length for upper flange
            public float  m_cld;                        // [1011] Cut out length for lower flange
            public fixed float  m_voute[4*2];           // [1011] Voute [lenght,height] for
      } // cs_con_mem

      public unsafe struct cs_con_end                   //        8/ID:11  Endplate of Beam
      {
            public int  m_ids;                          //        Identification = 11
            public int  m_typ;                          //        Type of end plate
            public int  m_mat;                          //        Materialnumber of endplate
            public int  m_bolt;                         //        Identifier of bolt type
            public int  m_nbr;                          //        Number of bolts in height direction
            public int  m_nbc;                          //        Number of bolts in width direction
            public float  m_b;                          // [1011] Width of plate
            public float  m_h;                          // [1011] Total plate height
            public float  m_mx;                         // [1011] Eccentricity
            public float  m_t;                          // [1011] Thickness of plate
            public fixed float  m_hb[5];                // [1011] Height for bolts
            public fixed float  m_w[2];                 // [1011] Width for bolts
            public fixed float  m_htbp[4];              // [1011] Height and thickness values for back plates
      } // cs_con_end

      public unsafe struct cs_con_pin                   //        8/ID:12  Pinned plate of Beam
      {
            public int  m_ids;                          //        Identification = 13
            public int  m_mat;                          //        Materialnumber of pin plate
            public int  m_mats;                         //        Materialnumber of support plate
            public int  m_matp;                         //        Materialnumber of pin
            public float  m_dp;                         // [1011] Diameter of pin
            public float  m_dh;                         // [1011] Diameter of hole
            public float  m_tp;                         // [1011] Thickness pin plate
            public float  m_tsup;                       // [1011] Thickness sup plate
            public float  m_c;                          // [1011] gap between plates
            public float  m_e1;                         // [1011] eccentricity 1
            public float  m_e2;                         // [1011] eccentricity 2
      } // cs_con_pin

      public unsafe struct cs_con_plt                   //        8/ID:20  Additional plates in connection
      {
            public int  m_ids;                          //        Identification = 20
            public int  m_typ;                          //        Type of plate
            public int  m_mat;                          //        Number of material
            public float  m_t;                          // [1011] Thickness of plate
            public fixed float  m_edge[8*5];            // [1011] Local coordinates, weldid, weldthickness
      } // cs_con_plt

      public unsafe struct cs_sect                      //        9/NR:0  SectionalValues (total section)
      {
            public int  m_id;                           //        Identification
            public int  m_mno;                          //        Materialnumber of sections
            public int  m_mrf;                          //        Materialnumber of Reinforcement
            public float  m_a;                          // [1012] Area
            public float  m_ay;                         // [1012] Sheardeformation area Y
            public float  m_az;                         // [1012] Sheardeformation area Z
            public float  m_it;                         // [1014] Torsional moment of inertia
            public float  m_iy;                         // [1014] Moments of inertia y-y
            public float  m_iz;                         // [1014] Moments of inertia z-z
            public float  m_iyz;                        // [1014] Moments of inertia y-z
            public float  m_ys;                         // [1011] y-Ordinate Center of gravity
            public float  m_zs;                         // [1011] z-Ordinate Center of gravity
            public float  m_ysc;                        // [1011] y-Ordinate of Shear-Center
            public float  m_zsc;                        // [1011] z-Ordinate of Shear-Center
            public float  m_em;                         // [1090] Elasticity Modulus
            public float  m_gm;                         // [1090] Shear Modulus
            public float  m_gam;                        // [1091] Deadweight
      } // cs_sect

      public unsafe struct cs_sect_eff                  //        9/NR:1  SectionalValues (effective section)
      {
            public int  m_id;                           //        Identification
            public int  m_mno;                          //        Materialnumber of sections
            public int  m_mrf;                          //        Materialnumber of Reinforcement
            public float  m_a;                          // [1012] Area
            public float  m_ay;                         // [1012] Sheardeformation area Y
            public float  m_az;                         // [1012] Sheardeformation area Z
            public float  m_it;                         // [1014] Torsional moment of inertia
            public float  m_iy;                         // [1014] Moments of inertia y-y
            public float  m_iz;                         // [1014] Moments of inertia z-z
            public float  m_iyz;                        // [1014] Moments of inertia y-z
            public float  m_ys;                         // [1011] y-Ordinate Center of gravity
            public float  m_zs;                         // [1011] z-Ordinate Center of gravity
            public float  m_ysc;                        // [1011] y-Ordinate of Shear-Center
            public float  m_zsc;                        // [1011] z-Ordinate of Shear-Center
            public float  m_em;                         // [1090] Elasticity Modulus
            public float  m_gm;                         // [1090] Shear Modulus
            public float  m_gam;                        // [1091] Deadweight
      } // cs_sect_eff

      public unsafe struct cs_sect_par                  //        9/NR:2  SectionalValues (total part of section)
      {
            public int  m_id;                           //        Identification
            public int  m_mno;                          //        Materialnumber of sections
            public int  m_mrf;                          //        Materialnumber of Reinforcement
            public float  m_a;                          // [1012] Area
            public float  m_ay;                         // [1012] Sheardeformation area Y
            public float  m_az;                         // [1012] Sheardeformation area Z
            public float  m_it;                         // [1014] Torsional moment of inertia
            public float  m_iy;                         // [1014] Moments of inertia y-y
            public float  m_iz;                         // [1014] Moments of inertia z-z
            public float  m_iyz;                        // [1014] Moments of inertia y-z
            public float  m_ys;                         // [1011] y-Ordinate Center of gravity
            public float  m_zs;                         // [1011] z-Ordinate Center of gravity
            public float  m_ysc;                        // [1011] y-Ordinate of Shear-Center
            public float  m_zsc;                        // [1011] z-Ordinate of Shear-Center
            public float  m_em;                         // [1090] Elasticity Modulus
            public float  m_gm;                         // [1090] Shear Modulus
            public float  m_gam;                        // [1091] Deadweight
      } // cs_sect_par

      public unsafe struct cs_sect_pef                  //        9/NR:3  SectionalValues (effective part of section)
      {
            public int  m_id;                           //        Identification
            public int  m_mno;                          //        Materialnumber of sections
            public int  m_mrf;                          //        Materialnumber of Reinforcement
            public float  m_a;                          // [1012] Area
            public float  m_ay;                         // [1012] Sheardeformation area Y
            public float  m_az;                         // [1012] Sheardeformation area Z
            public float  m_it;                         // [1014] Torsional moment of inertia
            public float  m_iy;                         // [1014] Moments of inertia y-y
            public float  m_iz;                         // [1014] Moments of inertia z-z
            public float  m_iyz;                        // [1014] Moments of inertia y-z
            public float  m_ys;                         // [1011] y-Ordinate Center of gravity
            public float  m_zs;                         // [1011] z-Ordinate Center of gravity
            public float  m_ysc;                        // [1011] y-Ordinate of Shear-Center
            public float  m_zsc;                        // [1011] z-Ordinate of Shear-Center
            public float  m_em;                         // [1090] Elasticity Modulus
            public float  m_gm;                         // [1090] Shear Modulus
            public float  m_gam;                        // [1091] Deadweight
      } // cs_sect_pef

      enum SECT_ADD_MOD { SECT_ADD_MOD = 0 }
      enum SECT_ADD_VAL { SECT_ADD_VAL = 1 }
      enum SECT_ADD_TYP { SECT_ADD_TYP = 2 }
      enum SECT_ADD_PLA { SECT_ADD_PLA = 3 }
      enum SECT_ADD_SOL { SECT_ADD_SOL = 4 }
      enum SECT_ADD_EFF { SECT_ADD_EFF = 5 }
      enum SECT_ADD_FEM { SECT_ADD_FEM = 6 }
      enum SECT_ADD_HYD { SECT_ADD_HYD = 9 }
      enum SECT_ADD_FIBRE { SECT_ADD_FIBRE = +128 }
      enum SECT_ADD_NEFF { SECT_ADD_NEFF = +512 }
      enum SECT_ADD_INTE { SECT_ADD_INTE = +1024 }
      enum SECT_ADD_TEMP { SECT_ADD_TEMP = +2048 }
      enum SECT_ADD_VARI { SECT_ADD_VARI = +4096 }
      enum SECT_ADD_REFP { SECT_ADD_REFP = +8192 }
      enum SECT_ADD_HOT { SECT_ADD_HOT = +16384 }
      public unsafe struct cs_sect_add                  //        9/NR:4  SectionalValuesShear , Temperature
      {
            public int  m_id;
            public int  m_stype;
            public int  m_mrf;                          //        Materialnumber of Stirup-Reinforcement
            public float  m_at;                         // [ 107] Elongationkoefficient for Temperature
            public float  m_ymin;                       // [1011] Minimum Ordinate of section to center ys
            public float  m_ymax;                       // [1011] Maximum Ordinate of section to center ys
            public float  m_zmin;                       // [1011] Minimum Ordinate of section to center zs
            public float  m_zmax;                       // [1011] Maximum Ordinate of section to center zs
            public float  m_tmin;                       // [1011] minimum thickness
            public float  m_tmax;                       // [1011] maximum thickness
            public float  m_wt;                         // [1018] maximum tau for Torsion MT=1
            public float  m_wvy;                        // [1017] maximum tau for Shear VY=1
            public float  m_wvz;                        // [1017] maximum tau for Shear VZ=1
            public float  m_wt2;                        // [1018] maximum tau for sekundary Torsion
            public float  m_ak;                         // [1012] kernel area for Torsion
            public float  m_ayz;                        // [1012] Shear deviation area
            public float  m_ab;                         // [1012] pure concrete area
            public float  m_levy;                       // [1011] minimum lever for cracked shear Vy
            public float  m_levz;                       // [1011] minimum lever for cracked shear Vz
            public float  m_elvy;                       // [1011] elastic lever for shear Vy = Sy-max/Iz
            public float  m_elvz;                       // [1011] elastic lever for shear Vz = Sz-max/Iy
            public float  m_ymine;                      // [1011] Minimum Ordinate of effective section
            public float  m_ymaxe;                      // [1011] Maximum Ordinate of effective section
            public float  m_zmine;                      // [1011] Minimum Ordinate of effective section
            public float  m_zmaxe;                      // [1011] Maximum Ordinate of effective section
      } // cs_sect_add

      public unsafe struct cs_sect_war                  //        9/NR:5  SectionalValuesWarping
      {
            public int  m_id;                           //        Identification = 5
            public int  m_i_1;                          //        unused
            public int  m_i_2;                          //        unused
            public float  m_ayyy;                       // [1015] Integrals on section
            public float  m_ayyz;                       // [1015] Integrals on section
            public float  m_ayzz;                       // [1015] Integrals on section
            public float  m_azzz;                       // [1015] Integrals on section
            public float  m_awy;                        // [1015] Integrals on section
            public float  m_awz;                        // [1015] Integrals on section
            public float  m_awyy;                       // [1016] Integrals on section
            public float  m_awzz;                       // [1016] Integrals on section
            public float  m_cm;                         // [1016] Warping resistance
            public float  m_cms;                        // [1014] Warping Shear resist.
            public float  m_wmin;                       // [1012] Minimum warping
            public float  m_wmax;                       // [1012] Maximum warping
            public float  m_fysw;                       // [1012] Shear VY-MT2 area
            public float  m_fzsw;                       // [1012] Shear VZ-MT2 area
      } // cs_sect_war

      public unsafe struct cs_sect_pla                  //        9/NR:6  SectionalPlasticForces
      {
            public int  m_id;                           //        Identification = 6
            public int  m_ibc;                          //        Buckling curve IBC
            public int  m_ib;                           //        Control
            public float  m_wpn;                        // [1101] Normal force
            public float  m_wpvy;                       // [1102] Y-Shear force
            public float  m_wpvz;                       // [1102] Y-Shear force
            public float  m_wpmt;                       // [1103] Torsional moment
            public float  m_wpmy;                       // [1104] Bending moment My
            public float  m_wpmz;                       // [1104] Bending moment Mz
            public float  m_ysp;                        // [1001] Plastic center
            public float  m_zsp;                        // [1001] Plastic center
            public float  m_wpmb;                       // [1105] warping moment Mb
            public float  m_wpt2;                       // [1103] 2nd torsional moment
      } // cs_sect_pla

      public unsafe struct cs_sect_des                  //        9/NR:7  SectionalValuesDesign
      {
            public int  m_id;                           //        Identification = 7
            public int  m_mnr;                          //        used reference material
            public int  m_ibc;                          //        buckling curve index
            public float  m_a;                          // [1012] Area
            public float  m_ay;                         // [1012] Sheardeformation area Y
            public float  m_az;                         // [1012] Sheardeformation area Z
            public float  m_it;                         // [1014] Torsional moment of inertia
            public float  m_iy;                         // [1014] Moments of inertia y-y
            public float  m_iz;                         // [1014] Moments of inertia z-z
            public float  m_iyz;                        // [1014] Moments of inertia y-z
            public float  m_ys;                         // [1011] y-Ordinate Center of gravity
            public float  m_zs;                         // [1011] z-Ordinate Center of gravity
            public float  m_ysc;                        // [1011] y-Ordinate of Shear-Center
            public float  m_zsc;                        // [1011] z-Ordinate of Shear-Center
            public float  m_em;                         // [1090] Elasticity Modulus/safety
            public float  m_gm;                         // [1090] Shear Modulus/safety
            public float  m_gam;                        // [1091] Deadweight
      } // cs_sect_des

      public unsafe struct cs_sect_pre                  //        9/NR:8  SectionalForcesPrestress
      {
            public int  m_id;                           //        Identification = 8
            public int  m_itp;                          //        subtype of information = 0
            public int  m_its;                          //        source of values
            public float  m_n;                          // [1101] Normal force
            public float  m_my;                         // [1104] Bending moment My
            public float  m_mz;                         // [1104] Bending moment Mz
            public float  m_ea;                         // [1101] tangential stiffnes E*A
            public float  m_eay;                        // [1105] tangential stiffnes E*A*z*z
            public float  m_eaz;                        // [1105] tangential stiffnes E*A*y*y
            public float  m_eayz;                       // [1105] tangential stiffnes E*A*y*z
            public float  m_yse;                        // [1011] elastic tangential center ys
            public float  m_zse;                        // [1011] elastic tangential center zs
            public float  m_ncm;                        // [1101] maximum compressive force
            public float  m_ntm;                        // [1101] maximum tensile force
      } // cs_sect_pre

      public unsafe struct cs_sect_gv                   //        9/NR:8  SectionalGeometricValues
      {
            public int  m_id;                           //        Identification = 8
            public int  m_itp;                          //        subtype of information = 2
            public int  m_mno;                          //        Materialnumber (0=total section)
            public float  m_uo;                         // [1011] outer perimeter
            public float  m_ui;                         // [1011] inner perimeter
            public float  m_tmin;                       // [1011] minimum thickness
            public float  m_tmax;                       // [1011] maximum thickness
            public float  m_ktz;                        // [   8] total weight factor
            public float  m_uom;                        // [1011] outer effect.perimeter
            public float  m_uim;                        // [1011] inner effect.perimeter
            public float  m_aro;                        // [1012] Outer total gross area
            public float  m_ar;                         // [1012] total gross area
            public float  m_ipm;                        // [1014] rotational inertia      gam*Ip
            public float  m_iym;                        // [1014] sectional mass inertia  gam*Iy
            public float  m_izm;                        // [1014] sectional mass inertia  gam*Iz
            public float  m_iyzm;                       // [1014] sectional mass inertia  gam*Iyz
            public float  m_ysm;                        // [1011] true mass gravity center
            public float  m_zsm;                        // [1011] true mass gravity center
            public float  m_dw;                         // [1011] effective thickness for creep/shrinkage
            public float  m_uair;                       // [1011] air contact perimeter
      } // cs_sect_gv

      public unsafe struct cs_sect_tra                  //        9/NR:8  SectionalAppliedTransformation
      {
            public int  m_id;                           //        Identification = 8
            public int  m_itp;                          //        subtype of information = 3
            public int  m_i_2;                          //        not used
            public float  m_alf;                        // [   5] rotation angle
            public float  m_ytf;                        // [1011] shift in y direction
            public float  m_ztf;                        // [1011] shift in z direction
      } // cs_sect_tra

      public unsafe struct cs_sect_lay                  //        9/NR:9  SectionalReinforcementLayer
      {
            public int  m_id;                           //        Identification = 9
            public int  m_mnr;                          //        Materialnumber + 1000*No of concrete \%
            public int  m_inr;                          //        Type/number of layer
            public int  m_tnr;                          //        Designation
            public float  m_alow;                       // [1020] Lower bound for area of layer
            public float  m_ahig;                       // [1020] Upper bound for area of layer
            public float  m_asum;                       // [1020] Sum of reference areas of layer
            public float  m_afak;                       //        maximum allowable factor of layer
            public float  m_ys;                         // [1011] center of layer
            public float  m_zs;                         // [1011] center of layer
            public float  m_vas;                        // [1020] Lower sequential total bound of layer area
            public float  m_bas;                        // [1020] Upper sequential total bound of layer area
            public float  m_iy;                         // [1014] 4th ord.areas (inertia)
            public float  m_iz;                         // [1014] 4th ord.areas (inertia)
            public float  m_iyz;                        // [1014] 4th ord.areas (inertia)
            public float  m_emod;                       // [1090] Elasticity-Modulus
            public float  m_bets;                       // [1092] yieldstress
            public float  m_rl;                         // [1011] torsional refer. length
            public float  m_n;                          // [1101] Normal force
            public float  m_my;                         // [1104] Bending moment My
            public float  m_mz;                         // [1104] Bending moment Mz
            public float  m_ea;                         // [1101] tangential stiffnes E*A
            public float  m_eay;                        // [1105] tangential stiffnes E*A*z*z
            public float  m_eaz;                        // [1105] tangential stiffnes E*A*y*y
            public float  m_eayz;                       // [1105] tangential stiffnes E*A*y*z
            public float  m_yse;                        // [1011] elastic tangential center ys
            public float  m_zse;                        // [1011] elastic tangential center zs
      } // cs_sect_lay

      enum SECT_REC_PLATE { SECT_REC_PLATE = 0 }
      enum SECT_REC_RECT { SECT_REC_RECT = 1 }
      enum SECT_REC_TBEAM { SECT_REC_TBEAM = 2 }
      enum SECT_REC_VPLAT { SECT_REC_VPLAT = 4 }
      enum SECT_REC_VHREC { SECT_REC_VHREC = 5 }
      enum SECT_REC_VBREC { SECT_REC_VBREC = 6 }
      enum SECT_REC_VRECT { SECT_REC_VRECT = 7 }
      enum SECT_REC_RF_CU { SECT_REC_RF_CU = 0 }
      enum SECT_REC_RF_SYM { SECT_REC_RF_SYM = 1 }
      enum SECT_REC_RF_ASY { SECT_REC_RF_ASY = 2 }
      enum SECT_REC_RF_AST { SECT_REC_RF_AST = 3 }
      enum SECT_REC_RF_ASB { SECT_REC_RF_ASB = 4 }
      enum SECT_REC_CORNER { SECT_REC_CORNER = 8 }
      enum SECT_REC_RF_TRA { SECT_REC_RF_TRA = 64 }
      enum SECT_REC_BUNDLE { SECT_REC_BUNDLE = 128 }
      public unsafe struct cs_sect_rec                  //        9/NR:10  SectiontypeRectangular T-Beam
      {
            public int  m_id;                           //        Identification = 10
            public int  m_iq;                           //        Identification of section
            public int  m_ir;                           //        Identification of reinforcement and origin
            public float  m_h;                          // [1011] total height
            public float  m_b;                          // [1011] width (of web)
            public float  m_so;                         // [1024] Boundary distance of upper reinforcement
            public float  m_su;                         // [1024] Boundary distance of lower reinforcement
            public float  m_aso;                        // [1020] reinforcement up
            public float  m_asu;                        // [1020] reinforcement down
            public float  m_ho;                         // [1011] height of plate
            public float  m_bo;                         // [1011] width  of plate
            public float  m_daso;                       // [1023] reinf. Diameter up
            public float  m_dasu;                       // [1023] reinf. Diameter dn
            public float  m_fkit;                       //        <0 = factor for torsional inertia >0 = absolut value of torsion
            public float  m_fkay;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
            public float  m_fkaz;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
            public float  m_ysmp;                       // [1011] explicit location of shear center
            public float  m_zssmp;                      // [1011] explicit location of shear center
            public float  m_ys;                         // [1011] explicit location of reference point
            public float  m_zs;                         // [1011] explicit location of reference point
            public float  m_phib;                       // [   5] inclination of shear links
            public float  m_beff;                       // [1011] width of equivalent hollow section
            public float  m_asbm;                       // [1022] Minimum shear reinf.
            public float  m_a;                          // [1011] spacing of reinforcements
            public float  m_amin;                       // [1011] minimum distance of single reinforcements
            public float  m_amax;                       // [1011] maximum distance of single reinforcements
            public float  m_ss;                         // [1024] Boundary distance of lateral reinforcement
            public float  m_dass;                       // [1023] reinf. Diameter side
            public float  m_hmax;                       // [1011] maximum mesh size for FE/fibre analysis
      } // cs_sect_rec

      public unsafe struct cs_sect_ann                  //        9/NR:11  SectiontypeAnnular
      {
            public int  m_id;                           //        Identification = 11
            public int  m_ir;                           //        Identification of section
            public int  m_ir2;                          //        Identification of reinforcement
            public float  m_ro;                         // [1011] outer radius
            public float  m_ri;                         // [1011] inner radius
            public float  m_ros;                        // [1011] outer reinf radius
            public float  m_ris;                        // [1011] inner reinf radius
            public float  m_aso;                        // [1020] outer reinforcement
            public float  m_asi;                        // [1020] inner reinforcement
            public float  m_daso;                       // [1023] reinf. Diameter
            public float  m_amax;                       // [1011] maximum distance of single reinforcements
            public float  m_asbm;                       // [1021] Minimum shear reinf.
            public float  m_hmax;                       // [1011] maximum mesh size for FE/fibre analysis
            public float  m_fkit;                       //        <0 = factor for torsional inertia >0 = absolut value of torsion
            public float  m_fkay;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
            public float  m_fkaz;                       //        <0 = factor for shear deformation area >0 = absolut value of sh
      } // cs_sect_ann

      public unsafe struct cs_sect_tub                  //        9/NR:11  SectiontypeTube
      {
            public int  m_id;                           //        Identification = 11
            public int  m_ir;                           //        Identification of section = 2
            public int  m_ir2;                          //        property Bit
            public float  m_d;                          // [1011] Diameter
            public float  m_t;                          // [1011] thickness of tubes
      } // cs_sect_tub

      public unsafe struct cs_sect_cab                  //        9/NR:11  SectiontypeCable
      {
            public int  m_id;                           //        Identification = 11
            public int  m_ir;                           //        Identification of section = 3
            public int  m_ic;                           //        sectiontype*256 + codeflag*16 + inlet type
            public float  m_d;                          // [1011] Diameter
            public fixed int  m_typ[2];                 //        Literal of type
            public int  m_inl;                          //        Literal of inlet
            public float  m_nli;                        //        no of strands
            public float  m_ndr;                        //        no of wires
            public float  m_f;                          //        fill factor
            public float  m_k;                          //        cable factor
            public float  m_w;                          //        weight factor
            public float  m_ke;                         //        loss factor
            public float  m_zd;                         // [1090] design  force
            public float  m_zb;                         // [1090] rupture force
            public float  m_gam;                        // [ 158] weight
      } // cs_sect_cab

      public unsafe struct cs_sect_pro                  //        9/NR:12  SectiontypeShape
      {
            public int  m_id;                           //        Identification = 12
            public int  m_mno;                          //        Materialnumber + 1000*imbedded Materialnumber
            public int  m_ibit;                         //        ityp + 64*iref + 1024*ivtp
            public int  m_typ;                          //        type of section
            public float  m_z1;                         //        first dimension mm
            public float  m_z2;                         //        first dimension mm
            public float  m_z3;                         //        first dimension mm
            public float  m_alf;                        // [   5] rotation angle
            public float  m_it;                         // [1014] tabul.Tors.Inertia
            public float  m_ysc;                        // [1011] tabul.shear center
            public float  m_zsc;                        // [1011] tabul.shear center
            public float  m_h;                          // [1011] height
            public float  m_b;                          // [1011] width
            public float  m_s;                          // [1011] thickness of web
            public float  m_t;                          // [1011] thickness of flange
            public float  m_r1;                         // [1011] radius
            public float  m_r2;                         // [1011] radius
            public float  m_yoff;                       // [1011] y coord. offset
            public float  m_zoff;                       // [1011] z coord. offset
            public float  m_cm;                         // [1016] tabul.warp.resist.
            public float  m_wmin;                       // [1012] charact. warping 1
            public float  m_wmax;                       // [1012] charact. warping 2
            public float  m_wt;                         // [1018] Torsional resist.
            public float  m_ay;                         // [1012] Shear area
            public float  m_az;                         // [1012] Shear area
            public int  m_rid;                          //        user defined ident
            public float  m_wu1;                        // [1011] bolt position 1
            public float  m_wu2;                        // [1011] bolt position 2
            public float  m_wu3;                        // [1011] bolt position 3
            public float  m_yref;                       // [1011] Coordinates of
            public float  m_zref;                       // [1011] Reference point
            public float  m_b2;                         // [1011] width lower part
            public float  m_t2;                         // [1011] lower flange thick.
            public fixed int  m_bez[8];                 //        character of shape
            public float  m_vypl;                       // [1102] plastic shear force Vy
            public float  m_vzpl;                       // [1102] plastic shear force Vz
            public float  m_mtpl;                       // [1103] plastic torsional   Mt
            public float  m_mt2pl;                      // [1103] plastic torsional   Mt2
            public float  m_mbpl;                       // [1103] plastic warpmoment  Mb
      } // cs_sect_pro

      public unsafe struct cs_sect_tba                  //        9/NR:18  List of construction stages
      {
            public int  m_id;                           //        Identification = 18
            public int  m_iba;                          //        Headder of construction stages = 0
            public int  m_ibd;                          //        Number of materials over all construction stages
            public fixed int  m_ibat[64];               //        List of external construction stage numbers
      } // cs_sect_tba

      public unsafe struct cs_sect_iba                  //        9/NR:18  ConstructionStage
      {
            public int  m_id;                           //        Identification = 18
            public int  m_iba;                          //        number of construction stage BIRTH
            public int  m_ibd;                          //        number of construction stage DEATH
            public fixed int m_txt[17];                 //        Text
      } // cs_sect_iba

      public unsafe struct cs_sect_txt                  //        9/NR:19  SectionText
      {
            public int  m_id;                           //        Identification = 19
            public int  m_nr;                           //        external construction stage number for CS separator
            public int  m_ids;                          //        Source/Selector flag
            public fixed int m_txt[128];                //        Text
      } // cs_sect_txt

      public unsafe struct cs_sect_wls                  //        9/NR:6?  SectionWorklaw Serviceability Analysis
      {
            public int  m_id;                           //        Identification
            public int  m_n;                            //        Normal force 0/00
            public int  m_ntyp;                         //        Type of law
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_sect_wls

      public unsafe struct cs_sect_wlu                  //        9/NR:7?  SectionWorklaw Ultimate Analysis
      {
            public int  m_id;                           //        Identification
            public int  m_n;                            //        Normal force 0/00
            public int  m_ntyp;                         //        Type of law
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_sect_wlu

      public unsafe struct cs_sect_cw                   //        9/NR:80  Hydrodynamic coefficients (Wind/Wave loading)
      {
            public int  m_id;                           //        Identification 80
            public int  m_iref;                         //        Reference of coefficients
            public int  m_alf;                          //        angle of attack in degrees
            public float  m_cy;                         //        wind reaction coefficient in y-direction
            public float  m_cz;                         //        wind reaction coefficient in z-direction
            public float  m_ct;                         //        wind reaction coefficient for torsional moment
            public float  m_chyd;                       //        hydrodynamic coefficient (Morrison equation)
            public float  m_clat;                       //        lateral wind reaction coefficient
            public float  m_s;                          //        Strouhal number
            public float  m_ag;                         //        reserved (must be present to detect old data without chyd)
      } // cs_sect_cw

      public unsafe struct cs_sect_wpa                  //        9/NR:81  SectionWindParameters for Wind loading
      {
            public int  m_id;                           //        Identification 81
            public int  m_iba;                          //        construction stage number
            public int  m_ibit;                         //        bitpattern of explicit limits
            public float  m_kd;                         //        relative roughness k/D
            public float  m_ice;                        // [1011] ice cover
            public float  m_traf;                       // [1011] height of traffic lane
            public float  m_ymin;                       // [1011] wind attack area
            public float  m_ymax;                       // [1011] wind attack area
            public float  m_zmin;                       // [1011] wind attack area
            public float  m_zmax;                       // [1011] wind attack area
            public float  m_yref;                       // [1011] wind moment reference
            public float  m_zref;                       // [1011] wind moment reference
      } // cs_sect_wpa

      public unsafe struct cs_sect_wde                  //        9/NR:82  SectionWindDerivativa for Wind loading
      {
            public int  m_id;                           //        Identification 82
            public int  m_iref;                         //        Type of derivativa
            public int  m_alf;                          //        angle of attack in degrees (see 009/NR:80)
            public fixed float  m_der[20*5];            //        Derivativa vred,value as splines
      } // cs_sect_wde

      public unsafe struct cs_sect_usr                  //        9/NR:90  SectionUserValues
      {
            public int  m_id;                           //        Identification = 90
            public int  m_itp;                          //        type of control value set
            public int  m_ival;                         //        value of control flag
            public float  m_rval;                       //        real value of control flag
            public float  m_rvald;                      //        place to save the original value which has been
      } // cs_sect_usr

      public unsafe struct cs_sect_mat                  //        9/NR:91  SectionalMaterial list
      {
            public int  m_id;                           //        Identification = 91
            public fixed int  m_mat[31];                //        material numbers
      } // cs_sect_mat

      public unsafe struct cs_sect_vad                  //        9/NR:97  SectionVarDefaults
      {
            public int  m_id;                           //        Identification = 97/98
            public int  m_ind1;                         //        Lower Index of variable
            public int  m_ind2;                         //        Upper Index of variable
            public int  m_idim;                         //        Unit of variable
            public fixed int  m_name[4];                //        Name of variable
            public fixed float  m_rval[1020];           //        values of the variable NAME(I1:I2)
      } // cs_sect_vad

      public unsafe struct cs_sect_var                  //        9/NR:98  SectionVarValues
      {
            public int  m_id;                           //        Identification = 97/98
            public int  m_ind1;                         //        Lower Index of variable
            public int  m_ind2;                         //        Upper Index of variable
            public int  m_idim;                         //        Unit of variable
            public fixed int  m_name[4];                //        Name of variable
            public fixed float  m_rval[1020];           //        values of the variable NAME(I1:I2)
      } // cs_sect_var

      public unsafe struct cs_sect_ref                  //        9/NR:99  SectionReference
      {
            public int  m_id;                           //        Identification 099
            public int  m_im;                           //        Type of reference structure definition (see AQUA.ERR)
            public int  m_irts;                         //        Subtype of reference definition for the points:
            public fixed int  m_ref[200];               //        Identifier of references (0 = not defined)
      } // cs_sect_ref

      public unsafe struct cs_sect_spt                  //        9/NR:100  SectionStressPoint
      {
            public int  m_id;                           //        Identification 100/101
            public int  m_mno;                          //        Material number
            public int  m_idp;                          //        Number*256 + Bitpattern
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_rt;                         // [1011] Radius of arc   (:101) ; effect. thickness (:100)
            public float  m_wty;                        // [1018] Resistance Torsion
            public float  m_wvyy;                       // [1017] Resistance y-shear
            public float  m_wvzy;                       // [1017] Resistance z-shear
            public float  m_wt2y;                       // [1018] Resistance 2nd Torsion
            public float  m_wtz;                        // [1018] Resistance Torsion
            public float  m_wvyz;                       // [1017] Resistance y-shear
            public float  m_wvzz;                       // [1017] Resistance z-shear
            public float  m_wt2z;                       // [1018] Resistance 2nd Torsion
            public float  m_w0;                         // [1012] unit warping
            public float  m_epsr;                       //        non effective strain ratio (0 < epsr <= 1)
            public float  m_exp;                        //        exposition class
            public float  m_fix;                        // [1011] location of fix point
            public float  m_sigd;                       // [1092] max. dynamic allowed stress range sig-d(-1)
            public float  m_taud;                       // [1092] max dynamic allowed stress range tau-d(-1)
            public int  m_litd;                         //        literal for notch type
            public float  m_sigy;                       // [1092] stress perpendicular
            public float  m_aref;                       // [1012] weight (effective area) FE-integration points
            public float  m_temp;                       // [1215] Temperature
            public float  m_temp1;                      // [1215] maximum temperature in history (for damage)
      } // cs_sect_spt

      public unsafe struct cs_sect_ppt                  //        9/NR:101  SectionPolygonPoint
      {
            public int  m_id;                           //        Identification 100/101
            public int  m_mno;                          //        Material number
            public int  m_idp;                          //        Number*256 + Bitpattern
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_rt;                         // [1011] Radius of arc   (:101) ; effect. thickness (:100)
            public float  m_wty;                        // [1018] Resistance Torsion
            public float  m_wvyy;                       // [1017] Resistance y-shear
            public float  m_wvzy;                       // [1017] Resistance z-shear
            public float  m_wt2y;                       // [1018] Resistance 2nd Torsion
            public float  m_wtz;                        // [1018] Resistance Torsion
            public float  m_wvyz;                       // [1017] Resistance y-shear
            public float  m_wvzz;                       // [1017] Resistance z-shear
            public float  m_wt2z;                       // [1018] Resistance 2nd Torsion
            public float  m_w0;                         // [1012] unit warping
            public float  m_epsr;                       //        non effective strain ratio (0 < epsr <= 1)
            public float  m_exp;                        //        exposition class
            public float  m_fix;                        // [1011] location of fix point
            public float  m_sigd;                       // [1092] max. dynamic allowed stress range sig-d(-1)
            public float  m_taud;                       // [1092] max dynamic allowed stress range tau-d(-1)
            public int  m_litd;                         //        literal for notch type
            public float  m_sigy;                       // [1092] stress perpendicular
            public float  m_aref;                       // [1012] weight (effective area) FE-integration points
            public float  m_temp;                       // [1215] Temperature
            public float  m_temp1;                      // [1215] maximum temperature in history (for damage)
      } // cs_sect_ppt

      public unsafe struct cs_sect_cir                  //        9/NR:102  SectionCircle
      {
            public int  m_id;                           //        Identification 102
            public int  m_mno;                          //        Material number
            public int  m_itp;                          //        interior construction
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate center
            public float  m_z;                          // [1011] z-ordinate center
            public float  m_r;                          // [1011] Radius
            public float  m_ri;                         // [1011] Radius hole
            public float  m_uc;                         // [1011] air contact length
      } // cs_sect_cir

      public unsafe struct cs_sect_pan                  //        9/NR:103  SectionPanel
      {
            public int  m_id;                           //        Identification 103/104
            public int  m_mno;                          //        Material number
            public int  m_idp;                          //        Bit-pattern
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_t;                          // [1010] thickness
            public float  m_wa;                         // [1012] unit warping start
            public float  m_we;                         // [1012] unit warping end
            public float  m_wt;                         // [1018] maximum shear from MT
            public float  m_wvy;                        // [1017] maximum shear from Vy
            public float  m_wvz;                        // [1017] maximum shear from Vz
            public float  m_wt2;                        // [1018] maximum shear from MT2
            public float  m_xvy;                        //        relative Ordinate WVy
            public float  m_xvz;                        //        relative Ordinate WVz
            public float  m_xmt2;                       //        relative Ordinate Wt2
            public float  m_wtbr;                       //        Bredt torsional shear
            public float  m_fixa;                       // [1011] location of fix point
            public float  m_fixb;                       // [1011] location of fix point
            public float  m_teff;                       // [1010] effective thickness
            public float  m_ast;                        // [1011] Distance of stiffeners along beam axis
            public float  m_eta;                        //        Reduction factor for local buckling
      } // cs_sect_pan

      public unsafe struct cs_sect_wel                  //        9/NR:104  SectionWeld
      {
            public int  m_id;                           //        Identification 103/104
            public int  m_mno;                          //        Material number
            public int  m_idp;                          //        Bit-pattern
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_t;                          // [1010] thickness
            public float  m_wa;                         // [1012] unit warping start
            public float  m_we;                         // [1012] unit warping end
            public float  m_wt;                         // [1018] maximum shear from MT
            public float  m_wvy;                        // [1017] maximum shear from Vy
            public float  m_wvz;                        // [1017] maximum shear from Vz
            public float  m_wt2;                        // [1018] maximum shear from MT2
            public float  m_xvy;                        //        relative Ordinate WVy
            public float  m_xvz;                        //        relative Ordinate WVz
            public float  m_xmt2;                       //        relative Ordinate Wt2
            public float  m_wtbr;                       //        Bredt torsional shear
            public float  m_fixa;                       // [1011] location of fix point
            public float  m_fixb;                       // [1011] location of fix point
            public float  m_teff;                       // [1010] effective thickness
            public float  m_ast;                        // [1011] Distance of stiffeners along beam axis
            public float  m_eta;                        //        Reduction factor for local buckling
      } // cs_sect_wel

      public unsafe struct cs_sect_per                  //        9/NR:110  SectionPeriphery
      {
            public int  m_id;                           //        Identification 110
            public int  m_mno;                          //        Material number
            public int  m_mn2;                          //        2nd material number
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate
            public float  m_za;                         // [1011] z-ordinate
            public float  m_ye;                         // [1011] y-ordinate
            public float  m_ze;                         // [1011] z-ordinate
            public float  m_air;                        //        air contact ratio
      } // cs_sect_per

      public unsafe struct cs_sect_fem                  //        9/NR:112  SectionTopology
      {
            public int  m_id;                           //        Identification 111
            public int  m_mno;                          //        Material number
            public int  m_nrel;                         //        internal element number
            public fixed int  m_node[4];                //        internal element nodes
      } // cs_sect_fem

      public unsafe struct cs_sect_ner                  //        9/NR:190  SectionNonEffectiveRectangle
      {
            public int  m_id;                           //        Identification 190
            public int  m_mno;                          //        Material number
            public int  m_idp;                          //        Noneffective for (same bits as :101)
            public int  m_tnr;                          //        Designation
            public float  m_ymin;                       // [1011] y-ordinate
            public float  m_zmin;                       // [1011] z-ordinate
            public float  m_ymax;                       // [1011] y-ordinate
            public float  m_zmax;                       // [1011] z-ordinate
            public float  m_t;                          // [1011] thickness
            public float  m_smin;                       // [1092] stress at point (ymin,zmin)
            public float  m_smax;                       // [1092] stress at point (ymax,zmax)
      } // cs_sect_ner

      public unsafe struct cs_sect_nep                  //        9/NR:191  Partial non effective polygons
      {
            public int  m_id;                           //        Identification 191
            public int  m_mno;                          //        Materialnumber
            public int  m_idp;                          //        Noneffective for (see :190)
            public int  m_tnr;                          //        Ident from 190 / Cut identifier for :312 elements
            public fixed float  m_yz[511*2];            // [1011] yz(2,*) = vertices (old format is blocked with 7 points
      } // cs_sect_nep

      public unsafe struct cs_sect_prf                  //        9/NR:200  SectionPointReinforcement
      {
            public int  m_id;                           //        Identification 200
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_sig;                        // [1092] prestress
            public float  m_temp;                       // [1215] Temperature
            public float  m_as;                         // [1020] Reinforcement area
            public float  m_asma;                       // [1020] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1012] Reference area
            public float  m_a;                          // [1011] distance of bars
      } // cs_sect_prf

      public unsafe struct cs_sect_lrf                  //        9/NR:201  SectionLineReinforcement
      {
            public int  m_id;                           //        Identification 201/211/221 or 321
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_r;                          // [1011] Radius
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_lrf

      public unsafe struct cs_sect_lrp                  //        9/NR:211  SectionLineReinforcement in Points
      {
            public int  m_id;                           //        Identification 201/211/221 or 321
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_r;                          // [1011] Radius
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_lrp

      public unsafe struct cs_sect_lsl                  //        9/NR:221  SectionShearLink
      {
            public int  m_id;                           //        Identification 201/211/221 or 321
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_r;                          // [1011] Radius
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_lsl

      public unsafe struct cs_sect_crf                  //        9/NR:202  SectionCircularReinforcement
      {
            public int  m_id;                           //        Identification 202/212/222
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate center
            public float  m_z;                          // [1011] z-ordinate center
            public float  m_r;                          // [1011] Radius
            public float  m_i_4;
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_crf

      public unsafe struct cs_sect_crp                  //        9/NR:212  SectionCircularReinforcement in Points
      {
            public int  m_id;                           //        Identification 202/212/222
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate center
            public float  m_z;                          // [1011] z-ordinate center
            public float  m_r;                          // [1011] Radius
            public float  m_i_4;
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_crp

      public unsafe struct cs_sect_csl                  //        9/NR:222  SectionHelicalShearLink
      {
            public int  m_id;                           //        Identification 202/212/222
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate center
            public float  m_z;                          // [1011] z-ordinate center
            public float  m_r;                          // [1011] Radius
            public float  m_i_4;
            public float  m_as;                         // [1029] Reinforc. area
            public float  m_asma;                       // [1029] max Reinforcement area
            public float  m_rng;                        //        Layer number
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Diameter
            public float  m_aref;                       // [1019] Reference area = width of element
            public float  m_a;                          // [1011] distance of bars
            public float  m_phia;                       // [   5] start angle for generated points
            public float  m_phie;                       // [   5] end   angle for generated points
      } // cs_sect_csl

      public unsafe struct cs_sect_urf                  //        9/NR:210  SectionPeriphericReinforcement
      {
            public int  m_id;                           //        Identification 210/220
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_cover;                      // [1024] static cover
            public fixed int  m_exp[2];                 //        Exposition class
            public float  m_wc;                         //        weight for centering reinforcement
            public float  m_as;                         // [1021] Reinforc. area/length
            public float  m_asma;                       // [1021] max Reinforcement area
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Bar Diameter
            public float  m_aref;                       // [1019] Reference area for crack width
            public float  m_a;                          // [1011] distance of bars
      } // cs_sect_urf

      public unsafe struct cs_sect_usl                  //        9/NR:220  SectionPeriphericShearLink
      {
            public int  m_id;                           //        Identification 210/220
            public int  m_mno;                          //        Material number
            public int  m_ir;                           //        Layer number
            public int  m_tnr;                          //        Designation
            public float  m_cover;                      // [1024] static cover
            public fixed int  m_exp[2];                 //        Exposition class
            public float  m_wc;                         //        weight for centering reinforcement
            public float  m_as;                         // [1021] Reinforc. area/length
            public float  m_asma;                       // [1021] max Reinforcement area
            public float  m_ft;                         //        torsional effect
            public float  m_d;                          // [1023] Bar Diameter
            public float  m_aref;                       // [1019] Reference area for crack width
            public float  m_a;                          // [1011] distance of bars
      } // cs_sect_usl

      public unsafe struct cs_sect_cpt                  //        9/NR:300  SectionCutStressPoint
      {
            public int  m_id;                           //        Identification 300
            public int  m_mno;                          //        Material of Reinforc. + 1000*Materialnumber
            public int  m_bit;                          //        Cut-Index*128 + Bitpattern
            public int  m_tnr;                          //        Designation
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_b0;                         // [1011] width of cut
            public float  m_wtm;                        // [1018] Resistance Torsion
            public float  m_wtr;                        // [1018] Resistance max Torsion
            public float  m_wvy;                        // [1017] Resistance y-shear
            public float  m_wvz;                        // [1017] Resistance z-shear
            public float  m_frs;                        //        Factor for total reinf
            public float  m_w0;                         // [1012] unit warping
            public float  m_sigy;                       // [1092] stress perpendicular
            public float  m_bb;                         // [1011] total width of cut
            public float  m_vyfk;                       //        part of total y-shear
            public float  m_vzfk;                       //        part of total z-shear
            public float  m_bqfk;                       //        partial width factor
      } // cs_sect_cpt

      public unsafe struct cs_sect_cut                  //        9/NR:301  SectionCut
      {
            public int  m_id;                           //        Identification 301
            public int  m_mno;                          //        Material of Reinforc. + 1000*Materialnumber
            public int  m_idp;                          //        Bitpattern
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_b0;                         // [1011] effective width
            public float  m_n;                          // [1111] Normal force perpend.
            public float  m_m;                          // [1114] bending moment perpend
            public float  m_wtm;                        // [1018] Resistance Torsion mid
            public float  m_wtd;                        // [1018] add tors.resist.edge
            public float  m_vyfk;                       //        part of total y-shear
            public float  m_vzfk;                       //        part of total z-shear
            public float  m_bv;                         // [1011] total width
            public float  m_phib;                       // [   5] inclination stirups
            public float  m_irb;                        //        number of shearlayer
            public float  m_ty;                         // [  17] unit shear Sy/Iz
            public float  m_tz;                         // [  17] unit shear Sz/Iy
            public float  m_bred;                       // [1011] reduction for ducts
            public float  m_asbm;                       //        Minimum shear reinf.
            public float  m_betc;                       //        friction coefficient
            public float  m_mue;                        //        friction in joint
            public float  m_act;                        // [1012] Area of cut off
            public float  m_ksl;                        //        parameters for plate
            public float  m_sxe;                        // [1011] crack spacing for AASTHO
            public float  m_cott;                       //        explicit selected inclination for truss model
      } // cs_sect_cut

      public unsafe struct cs_sect_hyd                  //        9/NR:900  SectionalHydraulics total section
      {
            public int  m_id;                           //        Identification = 900/903
            public int  m_i_1;
            public int  m_i_2;
            public float  m_a;                          // [1012] Area
            public float  m_ut;                         // [1011] total periphery
            public float  m_up;                         // [1011] total wet periphery
            public float  m_r;                          // [1011] hydraulic radius
            public float  m_zet1;                       //        loss factor 1
            public float  m_zet2;                       //        loss factor 2
            public float  m_slk;                        //        total leakage
            public float  m_ys;                         // [1011] y-Ordinate Center
            public float  m_zs;                         // [1011] y-Ordinate Center
      } // cs_sect_hyd

      public unsafe struct cs_sect_hyp                  //        9/NR:903  SectionalHydraulics partial section
      {
            public int  m_id;                           //        Identification = 900/903
            public int  m_i_1;
            public int  m_i_2;
            public float  m_a;                          // [1012] Area
            public float  m_ut;                         // [1011] total periphery
            public float  m_up;                         // [1011] total wet periphery
            public float  m_r;                          // [1011] hydraulic radius
            public float  m_zet1;                       //        loss factor 1
            public float  m_zet2;                       //        loss factor 2
            public float  m_slk;                        //        total leakage
            public float  m_ys;                         // [1011] y-Ordinate Center
            public float  m_zs;                         // [1011] y-Ordinate Center
      } // cs_sect_hyp

      public unsafe struct cs_sect_hya                  //        9/NR:904  SectionalHydraulicsAddval
      {
            public int  m_id;                           //        identifier 904
            public int  m_i_2;
            public int  m_type;                         //        type of section
            public float  m_nw;                         //        Nominal width
            public float  m_ymin;                       // [1011] Minimum Ordinate of section
            public float  m_ymax;                       // [1011] Maximum Ordinate of section
            public float  m_zmin;                       // [1011] Minimum Ordinate of section
            public float  m_zmax;                       // [1011] Maximum Ordinate of section
            public float  m_ks;                         // [  16] absolute roughness
            public float  m_s;                          //        storage coefficient
            public float  m_i_8;                        //        reserved
            public float  m_i_9;                        //        reserved
            public float  m_i_10;                       //        reserved
            public float  m_hp;                         // [1010] lift of pump
            public float  m_lmin;                       //        minimum power
            public float  m_lmax;                       //        maximum power
            public float  m_qmax;                       //        maximum delivery
      } // cs_sect_hya

      public unsafe struct cs_sect_hys                  //        9/NR:910  SectionalHydraulicsPolygon
      {
            public int  m_id;                           //        Identification 910
            public int  m_mat;                          //        identifier 0 (material number)
            public int  m_nr;                           //        number of side
            public int  m_tnr;                          //        Designation
            public float  m_ya;                         // [1011] y-ordinate start
            public float  m_za;                         // [1011] z-ordinate start
            public float  m_ye;                         // [1011] y-ordinate end
            public float  m_ze;                         // [1011] z-ordinate end
            public float  m_ks;                         // [  16] absolute roughness
            public float  m_slk;                        //        leakage
      } // cs_sect_hys

      public unsafe struct cs_syst                      //        10/00  SystemInfo
      {
            public int  m_iprob;                        //        Type of System
            public int  m_iachs;                        //        Orientation of gravity
            public int  m_nknot;                        //        Number of nodes
            public int  m_mknot;                        //        Highest node number
            public int  m_igdiv;                        //        Group divisor
            public int  m_igres;
            public fixed float  m_box[2*3];             // [1001] bounding box
            public fixed float  m_tg[4*3];              //        global CDB-System transformation matrix
            public fixed int m_txt[64];                 //        Name of projekt, 127 chars
      } // cs_syst

      public unsafe struct cs_syst_des                  //        10/1:0  SystemDesignCode
      {
            public int  m_id;                           //        identifier = 0
            public int  m_idc;                          //        Design code enumeration
            public int  m_country;                      //        Country code for variants
            public int  m_code;                         //        main number or ident of code
            public int  m_year;                         //        Year of publication
            public int  m_class;                        //        enum of a classification (see master.ini)
            public fixed int  m_txt[4];                 //        specific Text of Design code (16 characters)
            public int  m_wind;                         //        enum of a wind classification (see master.ini)
            public int  m_snow;                         //        enum of a snow-classification (see master.ini)
            public int  m_seis;                         //        enum of a seismic-classification (see master.ini)
            public int  m_dummy;                        //        reserved classification values
            public float  m_altitude;                   // [1006] altitude above sea level
            public float  m_vers;                       //        Version number of INI-File (21.0)
      } // cs_syst_des

      public unsafe struct cs_syst_act                  //        10/1:1  Predefined Actions from INI-file
      {
            public int  m_id;                           //        identifier = 1
            public int  m_action;                       //        ID of the real action = type of action
            public int  m_type;                         //        16*Part of action + superposition
            public float  m_gamu;                       //        safety factor unfavourable
            public float  m_gamf;                       //        safety factor favourable
            public float  m_psi0;                       //        combination value
            public float  m_psi1;                       //        frequent combination value
            public float  m_psi2;                       //        quasi permanent combination value
            public float  m_ps1s;                       //        non frequent combination value psi1'
            public float  m_gama;                       //        safety factor accidential
            public int  m_cat;                          //        sub category of action
            public int  m_txtref;                       //        designation_enum in SOFISTIK.ERR
            public fixed int m_txt[17];                 //        explicit designation (in native language)
      } // cs_syst_act

      public unsafe struct cs_syst_com_act              //        Identifier of action
      {
            public int  m_id;
            public float  m_faku;
            public float  m_fakf;
      } // cs_syst_com_act

      public unsafe struct cs_syst_com                  //        10/1:2  Possible Combination of actions
      {
            public int  m_id;                           //        identifier = 2
            public int  m_lfb;                          //        loadcase number offset
            public int  m_extr;                         //        Combination rule equation to be used
            public int  m_type;                         //        type or action of resulting load case
            public int  m_apply;                        //        Is generally used for:
            public fixed int  m_txt[8];                 //        Name of combination
            public float  m_dummy;                      //        reserved
            public cs_syst_com_act  m_act;              //        Identifier of action
      } // cs_syst_com

      public unsafe struct cs_grp                       //        11/00  Groups
      {
            public int  m_ng;                           //        group-number
            public int  m_typ;                          //        element code
            public int  m_num;                          //        number of elements of this type
            public int  m_min;                          //        minimum element-number of group
            public int  m_max;                          //        maximum element-number of group
            public int  m_mnr;                          //        material-number of group
            public int  m_mbw;                          //        reinforcement material-number of group
            public int  m_inf;                          //        Bit-code of group
            public float  m_faks;                       //        stiffness factor of group (ASE/TALPA)
            public float  m_faka;                       //        reducing factor of axial bedding for piles
            public float  m_fakt;                       //        reducing factor of transverse bedding
            public float  m_vtot;                       // [1093] total volume
            public float  m_mtot;                       // [1093] total mass
            public float  m_rtot;                       // [1030] total reinforcement
            public float  m_etot;                       // [1093] total energy
            public float  m_ecom;                       // [1093] compression energy
            public float  m_edev;                       // [1093] shear energy
            public float  m_ekin;                       // [1093] kinetic energy
            public float  m_epot;                       // [1093] potential energy
            public float  m_edam;                       // [1093] damping energy
            public float  m_h_gw;                       // [1001] Level of Groundwater
            public float  m_dummy;                      //        reserved
            public fixed int m_text[17];                //        Designation of Group
      } // cs_grp

      public unsafe struct cs_grp_lc                    //        11/LC  Groups of Loadcase
      {
            public int  m_ng;                           //        group-number
            public int  m_typ;                          //        element code
            public int  m_num;                          //        number of elements of this type
            public int  m_min;                          //        minimum element-number of group
            public int  m_max;                          //        maximum element-number of group
            public int  m_mnr;                          //        material-number of group
            public int  m_mbw;                          //        reinforcement material-number of group
            public int  m_inf;                          //        Bit-code of group
            public float  m_faks;                       //        stiffness factor of group (ASE/TALPA)
            public float  m_faka;                       //        reducing factor of axial bedding for piles
            public float  m_fakt;                       //        reducing factor of transverse bedding
            public float  m_vtot;                       // [1093] total volume
            public float  m_mtot;                       // [1093] total mass
            public float  m_rtot;                       // [1030] total reinforcement
            public float  m_etot;                       // [1093] total energy
            public float  m_ecom;                       // [1093] compression energy
            public float  m_edev;                       // [1093] shear energy
            public float  m_ekin;                       // [1093] kinetic energy
            public float  m_epot;                       // [1093] potential energy
            public float  m_edam;                       // [1093] damping energy
            public float  m_h_gw;                       // [1001] Level of Groundwater
            public float  m_dummy;                      //        reserved
            public fixed int m_text[17];                //        Designation of Group
      } // cs_grp_lc

      enum LTYP_IMP { LTYP_IMP = 70 }
      public unsafe struct cs_lc_ctrl                   //        12/LC:?  Informations on loadcase LC
      {
            public int  m_kind;                         //        type of loadcase
            public int  m_ityp;                         //        action type (14/ID)
            public int  m_theo;                         //        first order theory
            public fixed int  m_iba[2];                 //        construction stage number of birth & death
            public int  m_plc;                          //        Primary load case for 2nd order analysis
            public float  m_rpar;                       //        Timevalue of Load [sec]
            public float  m_psi0;                       //        combin. factor psi0
            public float  m_psi1;                       //        combin. factor psi1
            public float  m_psi2;                       //        combin. factor psi2
            public float  m_fact;                       //        loadcase factor
            public float  m_facx;                       //        dead load factor X
            public float  m_facy;                       //        dead load factor Y
            public float  m_facz;                       //        dead load factor Z
            public float  m_rx;                         // [1151] sum of support PX
            public float  m_ry;                         // [1151] sum of support PY
            public float  m_rz;                         // [1151] sum of support PZ
            public float  m_cri1;                       //        1st eval. criteria
            public float  m_cri2;                       //        2nd eval. criteria
            public float  m_cri3;                       //        3rd eval. criteria
            public float  m_gam1;                       //        unfavourable factor
            public float  m_gam2;                       //        favourable factor
            public fixed int  m_name[8];                //        Generating source
            public fixed int m_rtex[17];                //        Designation of loadcase
      } // cs_lc_ctrl

      public unsafe struct cs_lc_eval                   //        12/LC:011  Evaluation request
      {
            public int  m_id;                           //        identifier 11
            public int  m_lref;                         //        Referenced load case
            public int  m_ltyp;                         //        type of evaluation request
            public float  m_val;                        //        Result of evaluation
            public fixed int  m_name[2];                //        Literal of variable name
      } // cs_lc_eval

      public unsafe struct cs_lc_copy                   //        12/LC:012  Loads from other loadcases
      {
            public int  m_id;                           //        identifier 12 / 13
            public int  m_lref;                         //        Referenced load case or action ID [chr]
            public int  m_lsel;                         //        selection bits for elements
            public int  m_litf;                         //        enum of applied generic factors
            public fixed int  m_isel[4];                //        optional filter for element numbers
            public fixed int  m_nref[8];                //        Load train application control (see cdblfta.for)
            public fixed float  m_sref[32];             //        Factors and coordinates
            public fixed float  m_sum[7];               //        Sum of forces (psup,lsup)
            public fixed int m_clit[128];               //        Literal of an external database as source
      } // cs_lc_copy

      public unsafe struct cs_lc_copi                   //        12/LC:013  Loads from other loadcases
      {
            public int  m_id;                           //        identifier 12 / 13
            public int  m_lref;                         //        Referenced load case or action ID [chr]
            public int  m_lsel;                         //        selection bits for elements
            public int  m_litf;                         //        enum of applied generic factors
            public fixed int  m_isel[4];                //        optional filter for element numbers
            public fixed int  m_nref[8];                //        Load train application control (see cdblfta.for)
            public fixed float  m_sref[32];             //        Factors and coordinates
            public fixed float  m_sum[7];               //        Sum of forces (psup,lsup)
            public fixed int m_clit[128];               //        Literal of an external database as source
      } // cs_lc_copi

      public unsafe struct cs_lc_mbody                  //        12/LC:2?  Rotation of Body
      {
            public int  m_id;                           //        identifier 20/21
            public int  m_nr;                           //        primary or secondary group number of moving elements
            public int  m_nref;                         //        Reference beam number
            public float  m_ax;                         // [1003] acceleration local X
            public float  m_ay;                         // [1003] acceleration local Y
            public float  m_az;                         // [1003] acceleration local Z
            public float  m_axx;                        // [1207] rotational acceleration local X-X
            public float  m_ayy;                        // [1207] rotational acceleration local Y-Y
            public float  m_azz;                        // [1207] rotational acceleration local Z-Z
            public float  m_arx;                        // [1207] rotational acceleration local X-X  (= vxx**2)
            public float  m_ary;                        // [1207] rotational acceleration local Y-Y  (= vyy**2)
            public float  m_arz;                        // [1207] rotational acceleration local Z-Z  (= vzz**2)
            public float  m_ex;                         // [1001] global reference point for rotational acceleration
            public float  m_ey;                         // [1001] global reference point for rotational acceleration
            public float  m_ez;                         // [1001] global reference point for rotational acceleration
      } // cs_lc_mbody

      public unsafe struct cs_lc_lpos                   //        12/LC:90  Position of Load trains
      {
            public int  m_id;                           //        identifier 90
            public int  m_case;                         //        number of the case
            public int  m_ref;                          //        name of the reference lane
            public int  m_sub;                          //        subnumber of lane
            public int  m_kw;                           //        KW where result has been stored
            public int  m_ipos;                         //        Position of Result within record
            public int  m_nrel;                         //        Elementnumber
            public int  m_lftg;                         //        LFT*1000+500*ISCONVOY+LFG
            public float  m_xabs;                       // [1011] Section location for beams
            public float  m_yex;                        // [1001] Eccentricity of load train
            public fixed float  m_psc[2];               //        Maximum load values in load train (PL/BL)
            public fixed float  m_xpos[64];             //        Position and distance values
      } // cs_lc_lpos

      public unsafe struct cs_lc_lpo1                   //        12/LC:91  Individual position of Point load
      {
            public int  m_id;                           //        identifier 91
            public float  m_x;                          // [1001] Position of individual load
            public fixed float  m_pval[4];              //        Load values in PV,PVM,PX,PY
      } // cs_lc_lpo1

      public unsafe struct cs_lc_lpo2                   //        12/LC:92  Individual position of Block load
      {
            public int  m_id;                           //        identifier 92
            public float  m_xa;                         // [1001] Position of individual load start
            public float  m_xe;                         // [1001] Position of individual load end
            public fixed float  m_pval[4];              //        Load values in PV,PVM,PX,PY
      } // cs_lc_lpo2

      public unsafe struct cs_lc_lpo3                   //        12/LC:93  Individual residual loadings
      {
            public int  m_id;                           //        identifier 93
            public float  m_xa;                         // [1001] Position of individual load start
            public float  m_xe;                         // [1001] Position of individual load end
            public fixed float  m_pval[8];              //        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
      } // cs_lc_lpo3

      public unsafe struct cs_lc_lpox                   //        12/LC:99  Spandefinitions from ELLA
      {
            public int  m_id;                           //        identifier 99
            public float  m_xa;                         // [1001] Limits of an active area start
            public float  m_xe;                         // [1001] Limits of an active area end
            public float  m_yl;                         // [1001] Limits of an active area left
            public float  m_yr;                         // [1001] Limits of an active area right
            public float  m_phi;                        //        impact factor
            public float  m_v;                          // [1203] velocity of load train
      } // cs_lc_lpox

      public unsafe struct cs_lc_poin_lpt               //        loadpt
      {
            public float  m_p;
            public float  m_x;                          // [1001] 
            public float  m_y;                          // [1001] 
            public float  m_z;                          // [1001] 
      } // cs_lc_poin_lpt

      public unsafe struct cs_lc_poin                   //        12/LC:10?  Free point loads
      {
            public int  m_kref;                         //        Reference type
            public int  m_nref;                         //        Reference number
            public int  m_typ;                          //        type of load
            public fixed int  m_txt[3];                 //        Identifiying Text (12 characters)
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_widt;                       // [1001] Tolerance load direction to match elements
            public cs_lc_poin_lpt  m_lpt;               //        loadpt
      } // cs_lc_poin

      public unsafe struct cs_lc_line_lpt               //        loadpts
      {
            public float  m_p;
            public float  m_x;                          // [1001] 
            public float  m_y;                          // [1001] 
            public float  m_z;                          // [1001] 
      } // cs_lc_line_lpt

      public unsafe struct cs_lc_line                   //        12/LC:11?  Free line loads
      {
            public int  m_kref;                         //        Reference type
            public int  m_nref;                         //        Reference number
            public int  m_typ;                          //        type of load
            public fixed int  m_txt[3];                 //        Identifiying Text (12 characters)
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_widt;                       // [1001] Tolerance load direction to match elements
            public cs_lc_line_lpt  m_lpt;               //        loadpts
      } // cs_lc_line

      public unsafe struct cs_lc_curv_lpt               //        loadpts
      {
            public float  m_p;
            public float  m_x;                          // [1001] 
            public float  m_y;                          // [1001] 
            public float  m_z;                          // [1001] 
      } // cs_lc_curv_lpt

      public unsafe struct cs_lc_curv                   //        12/LC:14?  Free spline loads
      {
            public int  m_kref;                         //        Reference type
            public int  m_nref;                         //        Reference number
            public int  m_typ;                          //        type of load
            public fixed int  m_txt[3];                 //        Identifiying Text (12 characters)
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_widt;                       // [1001] Tolerance load direction to match elements
            public cs_lc_curv_lpt  m_lpt;               //        loadpts
      } // cs_lc_curv

      public unsafe struct cs_lc_area_lpt               //        loadpts
      {
            public float  m_p;
            public float  m_x;                          // [1001] 
            public float  m_y;                          // [1001] 
            public float  m_z;                          // [1001] 
      } // cs_lc_area_lpt

      public unsafe struct cs_lc_area                   //        12/LC:12?  Free area loads
      {
            public int  m_kref;                         //        Reference type
            public int  m_nref;                         //        Reference number
            public int  m_typ;                          //        type of load
            public fixed int  m_txt[3];                 //        Identifiying Text (12 characters)
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_width;                      // [1001] Tolerance load direction to match elements
            public cs_lc_area_lpt  m_lpt;               //        loadpts
      } // cs_lc_area

      public unsafe struct cs_lc_volu                   //        12/LC:13?  Free volume loads
      {
            public int  m_kref;                         //        Reference type
            public int  m_nref;                         //        Reference number
            public int  m_typ;                          //        type of load
            public fixed int  m_txt[3];                 //        Identifiying Text (12 characters)
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_width;                      // [1001] Factor for silo fillings A/U
            public float  m_p0;                         //        load value
            public float  m_x;                          // [1001] Reference point for load value P0
            public float  m_y;                          // [1001] 
            public float  m_z;                          // [1001] 
            public float  m_p1;                         //        variant load value second reference point
            public float  m_dx1;                        // [1001] Reference point for load value P1
            public float  m_dy1;                        // [1001] 
            public float  m_dz1;                        // [1001] 
            public float  m_p2;                         //        variant load value second reference point
            public float  m_dx2;                        // [1001] Reference point for load value P2
            public float  m_dy2;                        // [1001] 
            public float  m_dz2;                        // [1001] 
            public float  m_p3;                         //        variant load value second reference point
            public float  m_dx3;                        // [1001] Reference point for load value P3
            public float  m_dy3;                        // [1001] 
            public float  m_dz3;                        // [1001] 
            public float  m_p4;                         //        variant load value second reference point
            public float  m_dx4;                        // [1001] Reference point for load value P2
            public float  m_dy4;                        // [1001] 
            public float  m_dz4;                        // [1001] 
            public float  m_p5;                         //        variant load value second reference point
            public float  m_dx5;                        // [1001] Reference point for load value P3
            public float  m_dy5;                        // [1001] 
            public float  m_dz5;                        // [1001] 
      } // cs_lc_volu

      public unsafe struct cs_lc_trai                   //        12/LC:300  Train loading
      {
            public int  m_id;                           //        identifier 300
            public int  m_iden;                         //        Type of load train
            public int  m_bpat;                         //        Preselected Bitpattern of special options
            public float  m_p1;                         //        Char Designation or Class of loading
            public float  m_p2;                         //        second entry for load magnitude
            public float  m_p3;                         //        third entry for load magnitude
            public float  m_p4;                         //        fourth entry for load magnitude
            public float  m_p5;                         //        Basic area loading
            public float  m_p6;                         //        Wind loading
            public float  m_p7;                         //        Height subjected to wind load
            public float  m_p8;                         //        Entry for brake loading
            public float  m_p9;                         //        Height of the gravity centreline
            public float  m_totfac;                     //        Factor for the vertical loads of the
            public float  m_phib;                       //        explicit impact factor for bending
            public float  m_phibf;                      //        explicit impact factor favourable bending
            public float  m_phis;                       //        explicit impact factor for shear
            public float  m_phisf;                      //        explicit impact factor favourable shear
            public float  m_width;                      // [1001] Width of moving lane to be spared with P5
            public float  m_yex;                        // [1001] reserved: Eccentricity of loading in lane
            public float  m_xcol;                       // [1001] Minimum distance for multiple instances
            public float  m_v;                          // [1203] Speed of train
            public float  m_facf;                       //        Factor for the masses of the loading
            public float  m_dummy;                      //        reserved
            public float  m_frb;                        //        Frequence of body to bogie spring
            public float  m_dab;                        //        Modal damping of body to bogie
            public float  m_pzbo;                       // [1001] Fractional load value of bogie (included in PZ)
            public float  m_frbo;                       //        Frequence of bogie to wheel spring
            public float  m_dabo;                       //        Modal damping of bogie to body
            public float  m_pzwh;                       // [1001] Fractional load value of wheel (included in PZ)
            public float  m_frwh;                       //        Frequence of wheel to surface / bridge deck
            public float  m_dawh;                       //        Modal damping of wheel to surface
      } // cs_lc_trai

      public unsafe struct cs_lc_tral                   //        12/LC:301  Individual loads of Train loading
      {
            public int  m_id;                           //        identifier 301
            public int  m_type;                         //        Type of loading
            public int  m_bpat;                         //        contact node for single loads
            public float  m_pz;                         //        Vertical loading
            public float  m_ymin;                       // [1001] min eccentricity in y direction
            public float  m_ymax;                       // [1001] max eccentricity in y direction
            public float  m_px;                         //        Load value for braking
            public float  m_pw;                         //        Explicit force for wind attack
            public float  m_zw;                         // [1001] Height for wind force resultant
            public float  m_pv;                         //        Massvalue for zentrifugal force
            public float  m_zpv;                        // [1001] Height for zentrifugal force resultant
            public float  m_facfav;                     //        Factor for favourable effects
            public float  m_a;                          // [1001] Distance to last load
            public float  m_l;                          // [1001] Length of loading for block loads (0 = unlimited)
            public float  m_lmax;                       // [1001] Maximum length of block loading if variable
            public float  m_ldel;                       // [1001] Discrete increment of length for block loading
            public float  m_hw;                         // [1001] Height of train for wind attack area
            public float  m_width;                      // [1001] Width of train
            public float  m_yexvar;                     //        Variable eccentricity for secondary load trains
            public float  m_wwheel;                     // [1001] Width of single wheel
            public float  m_lwheel;                     // [1001] Length of single wheel
            public fixed float  m_dummy[2];             //        reserved
            public float  m_frb;                        //        Frequence of body to bogie spring
            public float  m_dab;                        //        Modal damping of body to bogie
            public float  m_pzbo;                       // [1001] Fractional load value of bogie (included in PZ)
            public float  m_frbo;                       //        Frequence of bogie to wheel spring
            public float  m_dabo;                       //        Modal damping of bogie to body
            public float  m_pzwh;                       // [1001] Fractional load value of wheel (included in PZ)
            public float  m_frwh;                       //        Frequence of wheel to surface / bridge deck
            public float  m_dawh;                       //        Modal damping of wheel to surface
      } // cs_lc_tral

      public unsafe struct cs_lc_wind                   //        12/LC:400  wind loading
      {
            public int  m_id;                           //        identifier 400
            public int  m_norm;                         //        wind design code
            public int  m_clas;                         //        type of zone
            public float  m_vatm;                       // [1201] atmospheric wind
            public float  m_vref;                       // [1201] mean reference wind
            public float  m_vboe;                       // [1201] gust reference wind
            public float  m_dx;                         //        components of wind direction
            public float  m_dy;
            public float  m_dz;
            public float  m_xref;                       // [1001] Reference point
            public float  m_yref;                       // [1001] 
            public float  m_zref;                       // [1001] 
            public float  m_dxre;                       //        Reference direction
            public float  m_dyre;
            public float  m_dzre;
            public float  m_gh;                         // [1001] coordinate of ground level
            public float  m_hmin;                       // [1001] value for constant wind speed below
            public float  m_rho;                        // [  59] weight of the air / fluid
            public float  m_lat;                        // [   5] lattitude of site
      } // cs_lc_wind

      public unsafe struct cs_lc_wtop                   //        12/LC:401  Wind environment
      {
            public int  m_id;                           //        identifier 401
            public float  m_typ;                        //        type of environment height
            public float  m_i_2;                        //        reserved
            public float  m_xm;                         // [1001] center of elevation in system coordinates
            public float  m_ym;                         // [1001] center of elevation in system coordinates
            public float  m_zm;                         // [1001] center of elevation in system coordinates
            public float  m_dx;                         //        direction of crest of ridge
            public float  m_dy;                         //        or local x-coordinate of a summit
            public float  m_dz;
            public float  m_h;                          // [1001] height above ground defining the slopes
            public float  m_wlen;                       // [1001] width in negative local y direction
            public float  m_blen;                       // [1001] width in positive local x direction
      } // cs_lc_wtop

      public unsafe struct cs_lc_wrou_r                 //        limits given
      {
            public float  m_d;                          // [1001] 
            public float  m_r;                          // [1001] 
            public float  m_dh;                         // [1001] 
            public float  m_hh;                         // [1001] 
      } // cs_lc_wrou_r

      public unsafe struct cs_lc_wrou                   //        12/LC:402  Roughness (wind)
      {
            public int  m_id;                           //        identifier 402
            public float  m_i_1;                        //        reserved
            public float  m_i_2;                        //        reserved
            public float  m_dsea;                       // [1001] Distance to the sea
            public cs_lc_wrou_r  m_r;                   //        limits given
      } // cs_lc_wrou

      public unsafe struct cs_lc_wspe                   //        12/LC:410  wind spectrum
      {
            public int  m_id;                           //        identifier 410
            public int  m_typ;                          //        type of spectra
            public int  m_i_2;                          //        reserved
            public float  m_a1lo;                       //        1st coefficient longitudinal
            public float  m_a2lo;                       //        2nd coefficient longitudinal
            public float  m_a3lo;                       //        3rd coefficient longitudinal
            public float  m_b_lo;                       //        4th coefficient longitudinal
            public float  m_c_lo;                       //        5th coefficient longitudinal
            public float  m_d_lo;                       //        6th coefficient longitudinal
            public float  m_a1la;                       //        1st coefficient lateral
            public float  m_a2la;                       //        2nd coefficient lateral
            public float  m_a3la;                       //        3rd coefficient lateral
            public float  m_b_la;                       //        4th coefficient lateral
            public float  m_c_la;                       //        5th coefficient lateral
            public float  m_d_la;                       //        6th coefficient lateral
            public float  m_a1ve;                       //        1st coefficient vertical
            public float  m_a2ve;                       //        2nd coefficient vertical
            public float  m_a3ve;                       //        3rd coefficient vertical
            public float  m_b_ve;                       //        4th coefficient vertical
            public float  m_c_ve;                       //        5th coefficient vertical
            public float  m_d_ve;                       //        6th coefficient vertical
            public float  m_c3d;                        //        Longitudinal coefficient
            public float  m_kuu;                        //        halfvalue distance coefficient
            public float  m_kuv;                        //        halfvalue distance coefficient
            public float  m_kuw;                        //        halfvalue distance coefficient
            public float  m_kvu;                        //        halfvalue distance coefficient
            public float  m_kvv;                        //        halfvalue distance coefficient
            public float  m_kvw;                        //        halfvalue distance coefficient
            public float  m_kwu;                        //        halfvalue distance coefficient
            public float  m_kwv;                        //        halfvalue distance coefficient
            public float  m_kww;                        //        halfvalue distance coefficient
      } // cs_lc_wspe

      public unsafe struct cs_lc_wtst                   //        12/LC:411  wind coherence test requests
      {
            public int  m_id;                           //        identifier 411
            public int  m_typ;                          //        type of coherence component
            public int  m_lc;                           //        load case of an eigenvalue
            public float  m_xref;                       // [1001] Reference point
            public float  m_yref;                       // [1001] 
            public float  m_zref;                       // [1001] 
            public float  m_rx;                         // [1001] Distance or direction of distance
            public float  m_ry;                         // [1001] 
            public float  m_rz;                         // [1001] 
            public float  m_cx;                         //        Davenport/Krenk reference coefficients
            public float  m_cy;
            public float  m_cz;
            public float  m_eig;                        //        Eigenfrequency (Hertz) for LC>0
            public float  m_u;                          // [  96] mean velocity
            public float  m_hwd;                        // [1001] real distance for LC==0
            public float  m_xmax;                       //        maximum x-value for data
            public fixed float  m_data[64];             //        calculated sqrt of coherence data ( 2 sets)
      } // cs_lc_wtst

      public unsafe struct cs_lc_wprc                   //        12/LC:420  wind profile control values
      {
            public int  m_id;                           //        identifier 420
            public int  m_id2;                          //        identifier 0
            public float  m_ipro;                       //        number of generated profiles
            public float  m_wxmi;                       // [1001] size of structure in wind coordinates
            public float  m_wxma;                       // [1001] 
            public float  m_wymi;                       // [1001] 
            public float  m_wyma;                       // [1001] 
            public float  m_wzmi;                       // [1001] 
            public float  m_wzma;                       // [1001] 
            public float  m_alfa;                       //        some angle ...
            public float  m_beta;                       //        some angle ...
            public float  m_gamm;                       //        some angle ...
            public float  m_delt;                       //        some angle ...
      } // cs_lc_wprc

      public unsafe struct cs_lc_wpro                   //        12/LC:420  wind profile distinct values
      {
            public int  m_id;                           //        identifier 420
            public int  m_ist;                          //        source of data
            public float  m_i_2;                        //        index reserved
            public float  m_h;                          // [1001] height above ground level
            public float  m_v;                          // [1201] mean value of wind velocity
            public float  m_vboe;                       // [1201] peak value of wind velocity
            public float  m_tlon;                       // [1201] longitudinal turbulence
            public float  m_tlat;                       // [1201] lateral turbulence
            public float  m_tver;                       // [1201] vertical turbulence
            public float  m_llon;                       // [1001] longitudinal wave length
            public float  m_llat;                       // [1001] lateral wave length
            public float  m_lver;                       // [1001] vertical wave length
            public float  m_phas;                       //        phase
      } // cs_lc_wpro

      public unsafe struct cs_lc_wave                   //        12/LC:500  Wave Loading
      {
            public int  m_id;                           //        identifier 500
            public int  m_typ;                          //        wave theory bit pattern
            public int  m_nf;                           //        number of frequencies in spectra
            public float  m_h;                          // [1001] wave height / significant wave height
            public float  m_t;                          // [  90] period of wave / peak period of wave
            public float  m_d;                          // [1001] water depth (0 = infinite)
            public float  m_swl;                        // [1001] sea water reference level
            public fixed float  m_dir[3];               //        principal direction of travelling
            public float  m_uc;                         // [1201] additional constant current
            public float  m_alf;                        //        exponent U(z)=UC*(z/d)**alf
            public float  m_rho;                        // [  59] weight of the fluid
            public float  m_l;                          // [1001] calculated wave length
            public fixed float  m_par[15];              //        special parameters for wave spectra
      } // cs_lc_wave

      public unsafe struct cs_lc_hist                   //        13/LC:0  TimeHistoryTitle
      {
            public int  m_id;                           //        identifier 0
            public int  m_idt;                          //        Unit of time resp x-axis
            public int  m_idf;                          //        Unit of function values
            public int  m_nfun;                         //        number of functions
            public int  m_nval;                         //        max number of discrete time values
            public int  m_type;                         //        general type of curve
            public fixed int m_title[17];               //        Designation
      } // cs_lc_hist

      public unsafe struct cs_lc_damp                   //        13/LC:1  Damping values
      {
            public int  m_id;                           //        identifier 1
            public fixed float  m_d[7];                 //        modal damping values
      } // cs_lc_damp

      public unsafe struct cs_lc_fval                   //        13/LC:?0  Discrete function values
      {
            public int  m_id;                           //        identifier
            public float  m_tt;                         //        Time/frequency
            public fixed float  m_f[7];                 //        function values
      } // cs_lc_fval

      public unsafe struct cs_lc_fsin                   //        13/LC:?1  Harmonic function
      {
            public int  m_id;                           //        identifier
            public float  m_t;                          // [  90] Time/frequency
            public float  m_f1;                         //        Amplitude value
            public float  m_phi1;                       // [  90] phase value
            public float  m_tmin;                       // [  90] starttime
            public float  m_tmax;                       // [  90] stoptime if > starttime
            public float  m_s;                          //        impactfactor
            public float  m_f2;                         //        Amplitude value for T/2 (Fourier)
            public float  m_phi2;                       // [  90] phase value for f2
            public float  m_f3;                         //        Amplitude value for T/3 (Fourier)
            public float  m_phi3;                       // [  90] phase value for f3
            public float  m_f4;                         //        Amplitude value for T/4 (Fourier)
            public float  m_phi4;                       // [  90] phase value for f4
      } // cs_lc_fsin

      public unsafe struct cs_lc_fstp                   //        13/LC:?2  Periodic stepping function
      {
            public int  m_id;                           //        identifier
            public float  m_t;                          // [  90] Time/frequency
            public float  m_f;                          //        Amplitude value
            public float  m_tc;                         // [  90] contact time
            public float  m_tmin;                       // [  90] starttime
            public float  m_tmax;                       // [  90] stoptime if > starttime
            public float  m_s;                          //        impactfactor (Sailer/Hüttner/Bachmann)
      } // cs_lc_fstp

      public unsafe struct cs_lc_fint                   //        13/LC:?3  Aperiodic function
      {
            public int  m_id;                           //        identifier 13
            public float  m_t;                          // [  90] Total Time
            public float  m_f;                          //        Amplitude value
            public float  m_t1;                         // [  90] Time of constant intensity
            public float  m_tmin;                       // [  90] starttime
            public float  m_tmax;                       // [  90] stoptime = tmin+T
            public int  m_typ;                          //        Type of function
            public float  m_f2;                         //        Amplitude factor
            public float  m_t2;                         // [  90] lead in time duration
            public float  m_f3;                         //        Amplitude factor
            public float  m_t3;                         // [  90] lead out time duration
      } // cs_lc_fint

      public unsafe struct cs_lc_resw                   //        13/LC:9??  Response spectra wind
      {
            public int  m_typ;                          //        Type of spectra 900 - 999
            public float  m_sint;                       //        Integral of spectra
            public float  m_a1;                         //        Spectrum coefficient
            public float  m_a2;                         //        Spectrum coefficient
            public float  m_a3;                         //        Spectrum coefficient
            public float  m_b;                          //        Spectrum coefficient
            public float  m_c;                          //        Spectrum coefficient
            public float  m_d;                          //        Spectrum coefficient
            public fixed float  m_res[9];               //        reserved
            public fixed int m_title[17];               //        Designation of Spectra
      } // cs_lc_resw

      public unsafe struct cs_lc_resp                   //        13/LC:???  Response spectra
      {
            public int  m_typ;                          //        Type of spectra 100 - 999
            public float  m_d;                          //        Damping value eta or behaviour factor q
            public float  m_sa;                         //        Rigid acceleration factor (Soil Parameter S)
            public float  m_sb;                         //        Max acceleration factor
            public float  m_smin;                       //        Min acceleration factor (beta)
            public float  m_tb;                         // [  90] Time value
            public float  m_tc;                         // [  90] Time value
            public float  m_td;                         // [  90] Time value
            public float  m_te;                         // [  90] Cutt-Off Time
            public float  m_k1;                         //        Coefficient k1
            public float  m_k2;                         //        Coefficient k2
            public fixed int  m_zone[3];                //        Earthquake zone
            public float  m_ag;                         // [1202] Reference base acceleration
            public float  m_ah;                         //        Horizontal factor (importance etc.)
            public float  m_av;                         //        Vertical factor
            public fixed int m_title[17];               //        Designation of Spectra
      } // cs_lc_resp

      public unsafe struct cs_lc_fref                   //        13/LC:????  Discrete reference function values
      {
            public int  m_id;                           //        line type
            public float  m_tt;                         //        Time/frequency
            public fixed float  m_f[2];                 //        function values
      } // cs_lc_fref

      public unsafe struct cs_act_task_scom             //        index,factor and name of items
      {
            public int  m_ind;
            public float  m_fak;
            public int  m_bez;
      } // cs_act_task_scom

      public unsafe struct cs_act_task                  //        14/0  Superposition task commands
      {
            public int  m_ivers;                        //        < 9999 = old data format (ACT_RULE)
            public int  m_num;                          //        number of superposition command
            public int  m_act;                          //        number of groups of actions at 14/act
            public fixed int  m_lfm[2];                 //        base of load case numbers
            public int  m_ksav;                         //        0 = do not save, >0 = save factors as combination KSAV
            public int  m_kwerg;                        //        Identifier of resultrecord in CDB
            public int  m_from;                         //        smallest  element number (echo only)
            public int  m_to;                           //        highest   element number (echo only)
            public int  m_inc;                          //        increment element number (echo only)
            public int  m_tid;                          //        optional identifier
            public float  m_x;                          // [1001] X-ordinate for beams
            public int  m_comb;                         //        combination method for items given at SCOM
            public cs_act_task_scom  m_scom;            //        index,factor and name of items
            public fixed int m_txt[33];                 //        Name of superposition
            public fixed int  m_uform[128];             //        User defined target function (index == 0!)
      } // cs_act_task

      public unsafe struct cs_act_rule_scom             //        index,factor and name of items
      {
            public int  m_ind;
            public float  m_fak;
            public int  m_bez;
      } // cs_act_rule_scom

      public unsafe struct cs_act_rule                  //        14/0  Superposition commands (old Version)
      {
            public int  m_num;                          //        number of superposition command
            public int  m_act;                          //        number of groups of actions at 14/act
            public fixed int  m_lfm[2];                 //        base of load case numbers
            public int  m_kwerg;                        //        Identifier of resultrecord in CDB
            public int  m_from;                         //        smallest  element number (echo only)
            public int  m_to;                           //        highest   element number (echo only)
            public int  m_inc;                          //        increment element number (echo only)
            public int  m_tid;                          //        optional identifier
            public int  m_comb;                         //        combination method for items given at SCOM
            public cs_act_rule_scom  m_scom;            //        index,factor and name of items
            public fixed int m_txt[33];                 //        Name of superposition
      } // cs_act_rule

      public unsafe struct cs_lc_act0                   //        14/NR:0  Group of Actions for SUPP-task
      {
            public int  m_id;                           //        ident = 0  user defined ; < 0 automatic
            public int  m_lfb;                          //        load case offset
            public int  m_extr;                         //        type of formula for evaluating the extrema
            public int  m_type;                         //        type or action of resulting load case
            public fixed int m_txt[17];                 //        Group designation for collection of actions
      } // cs_lc_act0

      public unsafe struct cs_lc_act1                   //        14/NR:1  Actionmember
      {
            public int  m_id;                           //        ident = 1
            public int  m_action;                       //        ID of the action = type of action
            public int  m_type;                         //        256*subgroup + 16*Group_of_action + superposition
            public float  m_gamu;                       //        safety factor unfavourable
            public float  m_gamf;                       //        safety factor favourable
            public float  m_psi0;                       //        combination value
            public float  m_psi1;                       //        combination value
            public float  m_psi2;                       //        quasi permanent combination value
            public float  m_ps1s;                       //        non frequent combination value psi1'
            public float  m_gama;                       //        safety factor accidential
            public int  m_cat;                          //        category (see 14/IDT) not used here
            public fixed int m_txt[17];                 //        designation
      } // cs_lc_act1

      public unsafe struct cs_lc_act_l                  //        14/NR:2  loadcase of action
      {
            public int  m_id;                           //        ident = 2
            public int  m_lf;                           //        load case number
            public int  m_type;                         //        load case action type
            public float  m_fact;                       //        factor
      } // cs_lc_act_l

      public unsafe struct cs_lc_act_r                  //        14/NR:1?  Response Spectra
      {
            public int  m_id;                           //        Evaluation type of response
            public int  m_resp;                         //        load case number of spectra
            public int  m_lfeig;                        //        load case of first eigenform
            public int  m_neig;                         //        numbers of eigenforms to be used
      } // cs_lc_act_r

      public unsafe struct cs_lc_act                    //        14/IDT:1  Action defaults
      {
            public int  m_id;                           //        ident = 1
            public int  m_action;                       //        ID of the real action = type of action
            public int  m_type;                         //        256*subgroup + 16*Group_of_action + superposition
            public float  m_gamu;                       //        safety factor unfavourable
            public float  m_gamf;                       //        safety factor favourable
            public float  m_psi0;                       //        combination value
            public float  m_psi1;                       //        combination value
            public float  m_psi2;                       //        quasi permanent combination value
            public float  m_ps1s;                       //        non frequent combination value psi1'
            public float  m_gama;                       //        safety factor accidential
            public int  m_cat;                          //        category for preselection of psi-values
            public fixed int m_txt[17];                 //        designation
      } // cs_lc_act

      public unsafe struct cs_csm_grp                   //        15/-1  Construction Stage Group Definitions
      {
            public int  m_grp;                          //        Group number
            public int  m_ics;                          //        CS number of first activation
            public int  m_gfix;                         //        CS number of hinge fixing
            public int  m_end;                          //        CS number of last action
            public fixed int  m_free[2];                //        free integer for later use
            public float  m_t0;                         // [  93] minimum age for loading
      } // cs_csm_grp

      public unsafe struct cs_csm_lc                    //        15/-2  Construction Stage Loadcase Definitions
      {
            public int  m_lc;                           //        Loadcase
            public int  m_start;                        //        CS number for first action
            public int  m_end;                          //        CS number of last action
      } // cs_csm_lc

      public unsafe struct cs_csm_cs                    //        15/-3  Construction Stage Table
      {
            public int  m_cs;                           //        Construction Stage
            public int  m_id;                           //        Main action type in this CS
            public int  m_cstep;                        //        number of creep+shrink step to be produced
            public int  m_dl_cs;                        //        dead load activation in composite cross sections
            public fixed int  m_free[2];                //        free integer for later use
            public float  m_dt;                         // [  93] duration of creep+shrink step
            public float  m_rh;                         // [   8] relative humidity in this creep+shrink step
            public float  m_temp;                       // [   8] temperture in this creep+shrink step
      } // cs_csm_cs

      public unsafe struct cs_csm_cree                  //        15/-4  creep+shrink values for manual input
      {
            public int  m_mno;                          //        Material number
            public int  m_grp;                          //        Group number
            public float  m_phi;                        //        total creep factor from first loading til infinite
            public float  m_eps;                        //        total shrinkage coefficient
            public float  m_relax;                      //        total tendon relaxation
      } // cs_csm_cree

      public unsafe struct cs_csg_cs                    //        15/-10  Construction Stage
      {
            public int  m_no;                           //        construction stage number
            public fixed int  m_titl[32];               //        Designation
            public float  m_dt;                         // [  93] duration of construction stage
      } // cs_csg_cs

      public unsafe struct cs_csg_cgrp                  //        15/-11  Group specification
      {
            public int  m_ics;                          //        corresponding cs number
            public int  m_no;                           //        group number
            public int  m_act;                          //        group action
            public int  m_act2;                         //        group action cont'd
            public int  m_ptyp;                         //        type of prestressing
            public int  m_plq;                          //        primary load case swelling
            public int  m_mno;                          //        material number
            public float  m_facs;                       //        stiffness factor
            public float  m_alph;                       //        alpha factor
            public float  m_hw;                         // [  13] ground water level
            public float  m_k;                          //        earth pressure coefficient
            public float  m_p;                          //        prestress force
      } // cs_csg_cgrp

      public unsafe struct cs_csg_clas                  //        15/-12  Load specification
      {
            public int  m_ics;                          //        corresponding cs number
            public int  m_no;                           //        number of referenced loadcase
            public int  m_opt;                          //        option of the load
            public float  m_fact;                       //        factor for loads
      } // cs_csg_clas

      public unsafe struct cs_csg_csys                  //        15/-13  System specification
      {
            public int  m_ics;                          //        corresponding cs number
            public int  m_prob;                         //        problem type
      } // cs_csg_csys

      public unsafe struct cs_csg_ccrl                  //        15/-14  Computation control
      {
            public int  m_ics;                          //        corresponding cs number
            public int  m_opt;                          //        control option
            public int  m_save;                         //        save interval
            public int  m_facq;                         //        not used
            public float  m_val;                        //        value of the option
            public float  m_fmax;                       //        2nd value of the option
            public float  m_fmin;                       //        3rd value of the option
            public float  m_emax;                       //        4th value of the option
            public float  m_emin;                       //        5th value of the option
            public float  m_v6;                         //        6th value of the option
            public float  m_v7;                         //        7th value of the option
            public float  m_v8;                         //        8th value of the option
      } // cs_csg_ccrl

      public unsafe struct cs_csg_cgw                   //        15/-15  Change ground water level
      {
            public int  m_ics;                          //        corresponding cs number
            public float  m_hw;                         // [  13] new ground water level
      } // cs_csg_cgw

      public unsafe struct cs_csg_echo                  //        15/-16  Echo options
      {
            public int  m_ics;                          //        corresponding cs number
            public int  m_opt;                          //        echo option
            public int  m_val;                          //        value of the option
      } // cs_csg_echo

      public unsafe struct cs_csm_lc1                   //        15/LC:1  CSM loadcase parameters Group members
      {
            public int  m_id;                           //        identifier 1
            public int  m_grp;                          //        Group number
            public float  m_t1;                         // [  93] age at the end of loadcase
            public float  m_sumeps;                     //        accumulated shrinkage strain
      } // cs_csm_lc1

      public unsafe struct cs_csm_lc2                   //        15/LC:2  CSM loadcase parameters quad-tendon members
      {
            public int  m_id;                           //        identifier 2
            public int  m_grp;                          //        quad-tendon number
            public float  m_t1;                         // [  93] age at the end of loadcase
            public float  m_sumrelax;                   //        accumulated quad-tendon relaxation
      } // cs_csm_lc2

      public unsafe struct cs_view                      //        18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
      {
            public int  m_iachs;                        //        downward direction (compare 10/0)
            public int  m_pers;                         //        Perspective
            public int  m_lc;                           //        loadcase
            public int  m_vopt;                         //        View Options (Bitcode I)
            public int  m_eopt;                         //        Element Options (Bitcode II)
            public int  m_copt;                         //        Colour Options (Bitcode III)
            public fixed int  m_dummy[3];               //        reserved
            public int  m_topt;                         //        Exchange option
            public float  m_xbl;                        // [1001] X-coordinate of view point
            public float  m_ybl;                        // [1001] Y-coordinate of view point
            public float  m_zbl;                        // [1001] Z-coordinate of view point
            public float  m_xcam;                       // [1001] X-coordinate of camera point
            public float  m_ycam;                       // [1001] Y-coordinate of camera point
            public float  m_zcam;                       // [1001] Z-coordinate of camera point
            public float  m_fakv;                       //        Factor of deformed structure
            public float  m_ssiz;                       //        Size of supports (0.-100.)
            public float  m_wmag;                       //        Warping magnification (0.-100.)
            public float  m_fovy;                       // [   5] perspective angle of field of view
            public float  m_xup;                        //        X-part Up Vector
            public float  m_yup;                        //        Y-part Up Vector
            public float  m_zup;                        //        Z-part Up Vector
      } // cs_view

      public unsafe struct cs_view_sel_r                //        Range lower and upper limit
      {
            public int  m_low;
            public int  m_upp;
      } // cs_view_sel_r

      public unsafe struct cs_view_sel                  //        18/-2  currently selected elements in WINGRAF
      {
            public int  m_id;                           //        Identifikator
            public cs_view_sel_r  m_r;                  //        Range lower and upper limit
      } // cs_view_sel

      public unsafe struct cs_view_sre                  //        18/-3  currently selected results in WINGRAF
      {
            public int  m_kwh;                          //        Main key of current item
            public int  m_kwl;                          //        Secondary key of cuurent item (LF,MAT)
            public fixed int  m_values[14];             //        Selected values of this record type
      } // cs_view_sre

      public unsafe struct cs_mtxt_0                    //        18/-4:0  Header for membrane manufacturing
      {
            public int  m_id;                           //        identificator = 0
            public int  m_lf;                           //        used load case of a deformed structure Lastfallnummer einer ver
            public int  m_bits;                         //        Bitpattern of conditions of evaluation
            public int  m_nfl;                          //        Number of manufacturing areas
            public int  m_nqu;                          //        total number of QUADS within those areas
            public int  m_nno;                          //        Number of new nodes inserted
      } // cs_mtxt_0

      public unsafe struct cs_mtxt_nod                  //        18/-4:-  Definition of new nodes
      {
            public int  m_no;                           //        Number of new interpolated node
            public int  m_quad;                         //        Nummer of QUAD-element containing this node
            public float  m_s;                          //        S-Koordinate im QUAD-Element
            public float  m_t;                          //        T-Koordinate im QUAD-Element
      } // cs_mtxt_nod

      public unsafe struct cs_mtxt_elm                  //        18/-4:+  Definition of manufacturing elements
      {
            public int  m_no;                           //        Number of manufacturing area
            public int  m_quad;                         //        Number of QUAD-element
            public int  m_n1;                           //        1st node (< 0 if new interpolated node)
            public int  m_n2;                           //        2nd node (< 0 if new interpolated node)
            public int  m_n3;                           //        3rd node (< 0 if new interpolated node)
            public int  m_n4;                           //        4th node (< 0 if new interpolated node)
      } // cs_mtxt_elm

      public unsafe struct cs_view_mco                  //        18/-5  Colour of material
      {
            public int  m_no;                           //        Number of material / group
            public float  m_red;                        //        RGBA: red color
            public float  m_green;                      //        RGBA: green color
            public float  m_blue;                       //        RGBA: blue color
            public float  m_alpha;                      //        RGBA: alpha value
      } // cs_view_mco

      public unsafe struct cs_view_gco                  //        18/-6  Colour of group
      {
            public int  m_no;                           //        Number of material / group
            public float  m_red;                        //        RGBA: red color
            public float  m_green;                      //        RGBA: green color
            public float  m_blue;                       //        RGBA: blue color
            public float  m_alpha;                      //        RGBA: alpha value
      } // cs_view_gco

      public unsafe struct cs_ani_sele                  //        18/-101:1  Dialogbox Animator selection request
      {
            public int  m_sele;                         //        identifier 1 : selection request
            public int  m_igrp;                         //        element-group switch
            public int  m_nsel;                         //        necessary-possible amount of selected elements
            public int  m_etyp;                         //        requested element type - multiple records allowed
            public int  m_from;                         //        select only elements or groups from FROM to TO
            public int  m_to;                           //        TO
      } // cs_ani_sele

      public unsafe struct cs_ani_ctrl                  //        18/-101:2  Dialogbox Animator drawing controls
      {
            public int  m_sele;                         //        identifier 2 : drawing controls
            public int  m_igrp;                         //        element-group switch as in record 018/-101
            public int  m_nsel;                         //        free
            public int  m_etyp;                         //        element type - see 018/-101:1
            public int  m_from;                         //        drawing controls for elements/groups from FROM to TO
            public int  m_to;                           //        TO
            public int  m_style;                        //        representation style guide number
            public fixed float  m_rgba[4];              //        colour and transparency factor - only for STYLE=1
      } // cs_ani_ctrl

      public unsafe struct cs_ani_sres                  //        18/-103  Selection result from Animator
      {
            public int  m_id101;                        //        access ID of 18/-101 to check if selection allready done
            public int  m_igrp;                         //        element-group switch as defined in 018/-101
            public int  m_isel;                         //        termination control
            public int  m_etyp;                         //        element type - see 018/-101:1
            public int  m_from;                         //        first selected element or group
            public int  m_to;                           //        last "
            public int  m_free;                         //        not used
            public float  m_x;                          // [1001] sectional abscissa
      } // cs_ani_sres

      public unsafe struct cs_lc_self                   //        18/LCD  Self weight loading of elements from ASE
      {
            public int  m_kwh;                          //        Type of load element
            public int  m_nr;                           //        all other values as in KWH/LC
            public int  m_typ;                          //        all other values as in KWH/LC
            public fixed float  m_pval[9999];           //        all other values as in KWH/LC
      } // cs_lc_self

      public unsafe struct cs_grp_bil                   //        19/LC  Bilances of Flow in HYDRA
      {
            public int  m_id;                           //        type of result
            public int  m_nr;                           //        group number
            public float  m_qinp;                       //        Quantity of inflow
            public float  m_qout;                       //        Quantity of outflow
            public float  m_qnew;                       //        Quantity generated in domain
            public float  m_ener;                       //        Energy term
      } // cs_grp_bil

      public unsafe struct cs_node                      //        20/00  Nodes
      {
            public int  m_nr;                           //        node-number
            public int  m_inr;                          //        internal node-number
            public int  m_kfix;                         //        degree of freedoms
            public int  m_ncod;                         //        additional bit code
            public fixed float  m_xyz[3];               // [1001] X-Y-Z-ordinates
      } // cs_node

      public unsafe struct cs_node_grc                  //        20/11:0  number of Nodegroups
      {
            public int  m_id;
            public int  m_maxgrp;                       //        maximum number of groups per node
      } // cs_node_grc

      public unsafe struct cs_node_grp                  //        20/11:+  Nodegroups
      {
            public int  m_n;                            //        node-number
            public fixed int  m_igrp[9999];             //        group-numbers connecting to node
      } // cs_node_grp

      public unsafe struct cs_node_kic                  //        21/00:0  Info on kinematic constraints
      {
            public int  m_id;
            public int  m_nlev;                         //        depth of recurent coupling (obsolete)
            public int  m_nkin;                         //        maximum number of coupling equations
            public int  m_nvar;                         //        maximum number of coupling factors
      } // cs_node_kic

      public unsafe struct cs_node_kin                  //        21/00:+  Standard kinematic constraint
      {
            public int  m_ktl;                          //        type + 100 * depth + 10000*group-number
            public int  m_nr;                           //        node-number
            public fixed int  m_kr[2];                  //        reference nodes
            public fixed float  m_dxyz[3];              //        direction of coupling X/Y/Z-axis
            public float  m_dd;                         //        factor of interpolation for INTP/INTF/INTS
            public float  m_ff;                         //        factor of multiplication (not used)
      } // cs_node_kin

      public unsafe struct cs_node_kig_id               //        node+degree-numbers of dependent and up to 21
      {
            public int  m_nr;
            public int  m_nd;
      } // cs_node_kig_id

      public unsafe struct cs_node_kig                  //        21/00:*99  general constraints (equation list)
      {
            public int  m_ktl;
            public cs_node_kig_id  m_id;                //        node+degree-numbers of dependent and up to 21
      } // cs_node_kig

      public unsafe struct cs_node_kif                  //        21/00:*99  general constraints (factor list)
      {
            public int  m_ktl;                          //        99 + 100 * depth
            public int  m_id;                           //        identifier 0
            public fixed float  m_fr[21];               //        factors of constrained equation
      } // cs_node_kif

      public unsafe struct cs_node_kih                  //        21/09  Hydraulic couplings
      {
            public int  m_ng;                           //        group-number
            public int  m_nr;                           //        node-number
            public int  m_kr;                           //        reference node
      } // cs_node_kih

      public unsafe struct cs_node_kfc                  //        22/LC:0  Max. Constraining Forces
      {
            public int  m_id;                           //        identifier 0
            public float  m_px;                         // [1190] force component X
            public float  m_py;                         // [1190] force component Y
            public float  m_pz;                         // [1190] force component Z
            public float  m_mx;                         // [1194] moment component X
            public float  m_my;                         // [1194] moment component Y
            public float  m_mz;                         // [1194] moment component Z
            public float  m_mb;                         // [1194] warping moment
      } // cs_node_kfc

      public unsafe struct cs_node_kfo                  //        22/LC:+  Constraining forces
      {
            public int  m_nr;                           //        node-number
            public float  m_px;                         // [1190] force component X
            public float  m_py;                         // [1190] force component Y
            public float  m_pz;                         // [1190] force component Z
            public float  m_mx;                         // [1194] moment component X
            public float  m_my;                         // [1194] moment component Y
            public float  m_mz;                         // [1194] moment component Z
            public float  m_mb;                         // [1194] warping moment
      } // cs_node_kfo

      public unsafe struct cs_node_l                    //        23/LC:+  Nodal_loads
      {
            public int  m_nr;                           //        node-number
            public int  m_typ;                          //        type of load
            public float  m_px;                         // [1190] single force X-component
            public float  m_py;                         // [1190] single force Y-component
            public float  m_pz;                         // [1190] single force Z-component
            public float  m_mx;                         // [1194] single moment X-component
            public float  m_my;                         // [1194] single moment Y-component
            public float  m_mz;                         // [1194] single moment Z-component
            public float  m_mb;                         // [1195] warping moment
      } // cs_node_l

      public unsafe struct cs_node_lw                   //        23/LC:+  prescribed support displacements
      {
            public int  m_nr;                           //        node-number
            public int  m_typ;                          //        type of load
            public float  m_wx;                         // [1003] Displacement X
            public float  m_wy;                         // [1003] Displacement Y
            public float  m_wz;                         // [1003] Displacement Z
            public float  m_rx;                         // [1004] Rotation X-X
            public float  m_ry;                         // [1004] Rotation Y-Y
            public float  m_rz;                         // [1004] Rotation Z-Z
      } // cs_node_lw

      public unsafe struct cs_node_acc                  //        23/LC:*  Base acceleration
      {
            public int  m_nr;                           //        node number / influence load case
            public int  m_typ;                          //        type of load (=10)
            public float  m_ax;                         // [1202] transversal acceleration X
            public float  m_ay;                         // [1202] transversal acceleration Y
            public float  m_az;                         // [1202] transversal acceleration Z
            public float  m_axx;                        // [1207] rotational acceleration X-X
            public float  m_ayy;                        // [1207] rotational acceleration Y-Y
            public float  m_azz;                        // [1207] rotational acceleration Z-Z
            public float  m_ex;                         // [1001] reference point for rotational acceleration
            public float  m_ey;                         // [1001] reference point for rotational acceleration
            public float  m_ez;                         // [1001] reference point for rotational acceleration
            public float  m_exref;                      //        V25: if a value is present (length criteria)
      } // cs_node_acc

      public unsafe struct cs_node_la                   //        23/LC:+  prescribed nodal accelerations
      {
            public int  m_nr;                           //        node-number
            public int  m_typ;                          //        type of load
            public float  m_ax;                         // [1003] acceleration X
            public float  m_ay;                         // [1003] acceleration Y
            public float  m_az;                         // [1003] acceleration Z
            public float  m_arx;                        // [1004] Rotation X-X
            public float  m_ary;                        // [1004] Rotation Y-Y
            public float  m_arz;                        // [1004] Rotation Z-Z
      } // cs_node_la

      public unsafe struct cs_node_rot                  //        23/LC:+  Rotation of Body
      {
            public int  m_nr;                           //        influence reference
            public int  m_typ;                          //        type of load (=20)
            public float  m_axx;                        // [1207] rotational acceleration X-X  (= vxx**2)
            public float  m_ayy;                        // [1207] rotational acceleration Y-Y  (= vyy**2)
            public float  m_azz;                        // [1207] rotational acceleration Z-Z  (= vzz**2)
            public float  m_ex;                         // [1001] reference point for rotational acceleration
            public float  m_ey;                         // [1001] reference point for rotational acceleration
            public float  m_ez;                         // [1001] reference point for rotational acceleration
      } // cs_node_rot

      public unsafe struct cs_n_dispc                   //        24/LC:0  Max. Displacements and support forces
      {
            public int  m_id;
            public float  m_ux;                         // [1003] displacement X
            public float  m_uy;                         // [1003] displacement Y
            public float  m_uz;                         // [1003] displacement Z
            public float  m_urx;                        // [1004] rotation X
            public float  m_ury;                        // [1004] rotation Y
            public float  m_urz;                        // [1004] rotation Z
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support X
            public float  m_py;                         // [1151] nodal support Y
            public float  m_pz;                         // [1151] nodal support Z
            public float  m_mx;                         // [1152] support moment X
            public float  m_my;                         // [1152] support moment Y
            public float  m_mz;                         // [1152] support moment Z
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_dispc

      public unsafe struct cs_n_dispic                  //        26/LC:0  Max. Displacement and forces increments
      {
            public int  m_id;
            public float  m_ux;                         // [1003] displacement X
            public float  m_uy;                         // [1003] displacement Y
            public float  m_uz;                         // [1003] displacement Z
            public float  m_urx;                        // [1004] rotation X
            public float  m_ury;                        // [1004] rotation Y
            public float  m_urz;                        // [1004] rotation Z
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support X
            public float  m_py;                         // [1151] nodal support Y
            public float  m_pz;                         // [1151] nodal support Z
            public float  m_mx;                         // [1152] support moment X
            public float  m_my;                         // [1152] support moment Y
            public float  m_mz;                         // [1152] support moment Z
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_dispic

      public unsafe struct cs_n_disptc                  //        27/LC:0  Max. Cooordinate offsets
      {
            public int  m_id;
            public float  m_ux;                         // [1003] displacement X
            public float  m_uy;                         // [1003] displacement Y
            public float  m_uz;                         // [1003] displacement Z
            public float  m_urx;                        // [1004] rotation X
            public float  m_ury;                        // [1004] rotation Y
            public float  m_urz;                        // [1004] rotation Z
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support X
            public float  m_py;                         // [1151] nodal support Y
            public float  m_pz;                         // [1151] nodal support Z
            public float  m_mx;                         // [1152] support moment X
            public float  m_my;                         // [1152] support moment Y
            public float  m_mz;                         // [1152] support moment Z
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_disptc

      public unsafe struct cs_n_disp                    //        24/LC:+  Displacements and support forces of nodes
      {
            public int  m_nr;                           //        node-number
            public float  m_ux;                         // [1003] displacement
            public float  m_uy;                         // [1003] displacement
            public float  m_uz;                         // [1003] displacement
            public float  m_urx;                        // [1004] rotation
            public float  m_ury;                        // [1004] rotation
            public float  m_urz;                        // [1004] rotation
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support
            public float  m_py;                         // [1151] nodal support
            public float  m_pz;                         // [1151] nodal support
            public float  m_mx;                         // [1152] support moment
            public float  m_my;                         // [1152] support moment
            public float  m_mz;                         // [1152] support moment
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_disp

      public unsafe struct cs_n_dispi                   //        26/LC:+  Displacement increments and residual forces
      {
            public int  m_nr;                           //        node-number
            public float  m_ux;                         // [1003] displacement
            public float  m_uy;                         // [1003] displacement
            public float  m_uz;                         // [1003] displacement
            public float  m_urx;                        // [1004] rotation
            public float  m_ury;                        // [1004] rotation
            public float  m_urz;                        // [1004] rotation
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support
            public float  m_py;                         // [1151] nodal support
            public float  m_pz;                         // [1151] nodal support
            public float  m_mx;                         // [1152] support moment
            public float  m_my;                         // [1152] support moment
            public float  m_mz;                         // [1152] support moment
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_dispi

      public unsafe struct cs_n_dispt                   //        27/LC:+  Cooordinate offsets
      {
            public int  m_nr;                           //        node-number
            public float  m_ux;                         // [1003] displacement
            public float  m_uy;                         // [1003] displacement
            public float  m_uz;                         // [1003] displacement
            public float  m_urx;                        // [1004] rotation
            public float  m_ury;                        // [1004] rotation
            public float  m_urz;                        // [1004] rotation
            public float  m_urb;                        // [1005] twisting
            public float  m_px;                         // [1151] nodal support
            public float  m_py;                         // [1151] nodal support
            public float  m_pz;                         // [1151] nodal support
            public float  m_mx;                         // [1152] support moment
            public float  m_my;                         // [1152] support moment
            public float  m_mz;                         // [1152] support moment
            public float  m_mb;                         // [1105] warping moment
      } // cs_n_dispt

      public unsafe struct cs_n_veloc                   //        25/LC:0  Max. velocities and accelerations of nodes
      {
            public int  m_id;
            public float  m_vx;                         // [1201] velocity X
            public float  m_vy;                         // [1201] velocity Y
            public float  m_vz;                         // [1201] velocity Z
            public float  m_vrx;                        // [1206] angular veloc. XX
            public float  m_vry;                        // [1206] angular veloc. YY
            public float  m_vrz;                        // [1206] angular veloc. ZZ
            public float  m_vbb;                        // [1208] twisting velocity
            public float  m_ax;                         // [1202] acceleration X
            public float  m_ay;                         // [1202] acceleration Y
            public float  m_az;                         // [1202] acceleration Z
            public float  m_arx;                        // [1207] ang. acceler. XX
            public float  m_ary;                        // [1207] ang. acceler. YY
            public float  m_arz;                        // [1207] ang. acceler. ZZ
            public float  m_abb;                        // [1209] twisting acceler
      } // cs_n_veloc

      public unsafe struct cs_n_velo                    //        25/LC:+  velocitys and acceleration of nodes
      {
            public int  m_nr;                           //        node-number
            public float  m_vx;                         // [1201] velocity X
            public float  m_vy;                         // [1201] velocity Y
            public float  m_vz;                         // [1201] velocity Z
            public float  m_vrx;                        // [1206] angular veloc. X-X
            public float  m_vry;                        // [1206] angular veloc. Y-Y
            public float  m_vrz;                        // [1206] angular veloc. Z-Z
            public float  m_vbb;                        // [1208] twisting velocity
            public float  m_ax;                         // [1202] acceleration X
            public float  m_ay;                         // [1202] acceleration Y
            public float  m_az;                         // [1202] acceleration Z
            public float  m_arx;                        // [1207] ang. acceler. X-X
            public float  m_ary;                        // [1207] ang. acceler. Y-Y
            public float  m_arz;                        // [1207] ang. acceler. Z-Z
            public float  m_abb;                        // [1209] twisting acceler
      } // cs_n_velo

      public unsafe struct cs_spt                       //        39/NR:0  Structural points
      {
            public int  m_id;                           //        identifier 0
            public int  m_ids;                          //        optional identifier of point
            public int  m_ref;                          //        reserved reference
            public int  m_nog;                          //        reserved number of group
            public int  m_nom;                          //        reserved number of material
            public int  m_nor;                          //        reserved number of reinforc.
            public int  m_ibt;                          //        Bitpattern of element properties
            public int  m_ibc;                          //        Boundary condition
            public int  m_i_8;                          //        reserved
            public int  m_i_9;                          //        reserved
            public fixed float  m_xyz[3];               // [1001] Coordinates of that point
            public fixed float  m_t[3*3];               //        transformation matrix
            public float  m_bx;                         // [1001] Dimension in local x
            public float  m_by;                         // [1001] Dimension in local y
            public float  m_thick;                      // [1010] Plate thickness at that point
            public float  m_hmesh;                      // [1001] Mesh density at point
            public fixed float  m_res[3];               //        reserved
            public fixed int m_text[17];                //        Designation of Point
      } // cs_spt

      public unsafe struct cs_sln                       //        39/NR:100  Structural lines
      {
            public int  m_id;                           //        identifier 100
            public int  m_ids;                          //        optional identifier of structural line
            public int  m_ref;                          //        reference identifier to a given GAX [chr] or sln [int]
            public int  m_sref;                         //        secondary axis enum for GAX references
            public int  m_na;                           //        optional identifier of line start point
            public int  m_nb;                           //        optional identifier of line end point
            public int  m_ibt;                          //        Bitpattern of element properties
            public int  m_ibc;                          //        primary boundary condition
            public int  m_id8;                          //        reserved
            public int  m_id9;                          //        reserved
            public float  m_hmesh;                      // [1001] >0.0 = mesh density along line
            public fixed float  m_tup[3];               //        Vector to define downward direction
            public float  m_trot;                       //        Fractional rotation about local x-axis  (obsoleted => :101/:102
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis      (obsoleted => :101/:102
            public float  m_prog;                       //        progression factor (>0 monoton, <0 symmetric)
            public float  m_r10;                        //        reserved
            public float  m_r11;                        //        reserved
            public float  m_r12;                        //        reserved
            public float  m_r13;                        //        reserved
            public float  m_r14;                        //        reserved
            public float  m_r15;                        //        reserved
            public fixed int m_text[17];                //        Designation of Line
      } // cs_sln

      enum SLN_BEAM_NONE { SLN_BEAM_NONE = -1 }
      enum SLN_BEAM_CENTRIC { SLN_BEAM_CENTRIC = 0 }
      enum SLN_BEAM_REFERENCE { SLN_BEAM_REFERENCE = 1 }
      enum SLN_BEAM_TRUSS { SLN_BEAM_TRUSS = 2 }
      enum SLN_BEAM_CABLE { SLN_BEAM_CABLE = 3 }
      enum SLN_BEAM_CCOLUMN { SLN_BEAM_CCOLUMN = 4 }
      enum SLN_BEAM_COLUMN { SLN_BEAM_COLUMN = 5 }
      enum SLN_BEAM_SECTION { SLN_BEAM_SECTION = 7 }
      public unsafe struct cs_sln_beam                  //        39/NR:101  Properties of beams
      {
            public int  m_id;                           //        ident 101
            public int  m_typ;                          //        Element type (see 009/NR:90:4 IBTYP)
            public int  m_nog;                          //        group number
            public fixed int  m_nq[2];                  //        number cross section start/end
            public int  m_np;                           //        number bedding props
            public fixed int  m_ibc[4];                 //        Hinge properties A/E/XA/XE (start/end/internal start/end)
            public int  m_div;                          //        type of element subdivision
            public float  m_kr;                         //        identifier of local coordinate system orientation
            public float  m_r12;
            public float  m_r13;
            public float  m_r14;
            public float  m_r15;
            public float  m_exa;                        // [1001] eccentricity at start
            public float  m_eya;                        // [1001] eccentricity at start
            public float  m_eza;                        // [1001] eccentricity at start
            public float  m_exe;                        // [1001] eccentricity at end
            public float  m_eye;                        // [1001] eccentricity at end
            public float  m_eze;                        // [1001] eccentricity at end
            public float  m_trot;                       //        additional rotation about local x-axis, given as fraction of 36
            public fixed float  m_tal[3];               //        vector defining the orientation of the local z-axis of the loca
      } // cs_sln_beam

      public unsafe struct cs_gln_bpro                  //        31/NR:101  Properties of beams
      {
            public int  m_id;                           //        ident 101
            public int  m_typ;                          //        Element type (see 009/NR:90:4 IBTYP)
            public int  m_nog;                          //        group number
            public fixed int  m_nq[2];                  //        number cross section start/end
            public int  m_np;                           //        number bedding props
            public fixed int  m_ibc[4];                 //        Hinge properties A/E/XA/XE (start/end/internal start/end)
            public int  m_div;                          //        type of element subdivision
            public float  m_kr;                         //        identifier of local coordinate system orientation
            public float  m_r12;
            public float  m_r13;
            public float  m_r14;
            public float  m_r15;
            public float  m_exa;                        // [1001] eccentricity at start
            public float  m_eya;                        // [1001] eccentricity at start
            public float  m_eza;                        // [1001] eccentricity at start
            public float  m_exe;                        // [1001] eccentricity at end
            public float  m_eye;                        // [1001] eccentricity at end
            public float  m_eze;                        // [1001] eccentricity at end
            public float  m_trot;                       //        additional rotation about local x-axis, given as fraction of 36
            public fixed float  m_tal[3];               //        vector defining the orientation of the local z-axis of the loca
      } // cs_gln_bpro

      public unsafe struct cs_sln_supp                  //        39/NR:102  Support of Structural lines
      {
            public int  m_id;                           //        identifier 102
            public int  m_ids;                          //        type of reference
            public int  m_ref;                          //        reference identifier
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_ibc;                          //        Boundary condition / kinematic constraints
            public int  m_kr;                           //        local orientation
            public float  m_w;                          // [1001] width of support
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
            public float  m_cm;                         // [1099] torsional bedding
            public float  m_drx;                        //        explicit X direction of support
            public float  m_dry;                        //        explicit Y direction of support
            public float  m_drz;                        //        explicit Z direction of support
            public float  m_d;                          // [1001] distance to coupled line (IDS={5,6,7})
            public float  m_r8;
            public float  m_r9;
            public float  m_fka;                        //        factor bedding at start
            public float  m_fke;                        //        factor bedding at end
            public float  m_trot;                       //        Fractional rotation about local x-axis
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis
      } // cs_sln_supp

      public unsafe struct cs_gln_supp                  //        31/NR:102  Support of Structural lines
      {
            public int  m_id;                           //        identifier 102
            public int  m_ids;                          //        type of reference
            public int  m_ref;                          //        reference identifier
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_ibc;                          //        Boundary condition / kinematic constraints
            public int  m_kr;                           //        local orientation
            public float  m_w;                          // [1001] width of support
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
            public float  m_cm;                         // [1099] torsional bedding
            public float  m_drx;                        //        explicit X direction of support
            public float  m_dry;                        //        explicit Y direction of support
            public float  m_drz;                        //        explicit Z direction of support
            public float  m_d;                          // [1001] distance to coupled line (IDS={5,6,7})
            public float  m_r8;
            public float  m_r9;
            public float  m_fka;                        //        factor bedding at start
            public float  m_fke;                        //        factor bedding at end
            public float  m_trot;                       //        Fractional rotation about local x-axis
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis
      } // cs_gln_supp

      public unsafe struct cs_sln_exyz                  //        39/NR:120  Explicit nodes on lines
      {
            public int  m_id;                           //        identifier = 120
            public int  m_id1;                          //        reserved
            public fixed float  m_xyz[64*3];            // [1001] XYZ coordinates
      } // cs_sln_exyz

      public unsafe struct cs_gln_exyz                  //        31/NR:120  Explicit nodes on lines
      {
            public int  m_id;                           //        identifier = 120
            public int  m_id1;                          //        reserved
            public fixed float  m_xyz[64*3];            // [1001] XYZ coordinates
      } // cs_gln_exyz

      public unsafe struct cs_sln_sct                   //        39/NR:130  Beams sections
      {
            public int  m_id;                           //        identifier = 130
            public int  m_reft;                         //        Type of reference
            public int  m_ityp;                         //        Bitcodes according 100/NR:0 ITYP
            public int  m_i1;                           //        reserved
            public float  m_s;                          // [1001] location on geometry
      } // cs_sln_sct

      public unsafe struct cs_gln_sct                   //        31/NR:130  Beams sections
      {
            public int  m_id;                           //        identifier = 130
            public int  m_reft;                         //        Type of reference
            public int  m_ityp;                         //        Bitcodes according 100/NR:0 ITYP
            public int  m_i1;                           //        reserved
            public float  m_s;                          // [1001] location on geometry
      } // cs_gln_sct

      public unsafe struct cs_sar                       //        39/NR:200  Structural area
      {
            public int  m_id;                           //        identification of general data = 200
            public int  m_ids;                          //        identifier of structural area (0=auto)
            public int  m_ref;                          //        reference to a given GAR [chr] or SAR [int]
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_nor;                          //        number of reinforc.
            public int  m_itp;                          //        Bitpattern for element generation QUAD
            public int  m_ibc;                          //        Boundary condition
            public int  m_kr;                           //        local orientation QUADs
            public int  m_iatr;                         //        Bitpattern for attribut areas (see SBOX_PROP)
            public fixed float  m_td[5];                // [1010] Constant thickness
            public float  m_cb;                         //        bedding factor
            public float  m_cq;                         //        tangential bedding factor
            public fixed float  m_tup[3];               //        Vector to define upward direction
            public float  m_trot;                       //        Fractional rotation about local z-axis
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis
            public fixed float  m_h[7];                 // [1001] mesh density parameters
            public fixed int m_text[17];                //        Designation of surface
      } // cs_sar

      public unsafe struct cs_sar_inf                   //        39/NR:210  GeometricAreaInfo
      {
            public int  m_id0;                          //        identifier 210
            public int  m_ng;                           //        Type of surface representation
            public int  m_gid1;                         //        Axis identifier of first reference axis
            public int  m_gid2;                         //        Axis identifier of second reference axis
            public fixed float  m_t[4*3];               //        Transformation
            public fixed float  m_uv[2*2];              //        umin,umax,vmin,vmax of the parameter plane
      } // cs_sar_inf

      public unsafe struct cs_sar_pts                   //        39/NR:211  AreaPointonSurface
      {
            public int  m_id;                           //        Identifier 211
            public int  m_it;                           //        Type of point (see 5/ID:11 for more)
            public int  m_m;                            //        Rasterlocation of mesh (0 < m < mgri )
            public int  m_n;                            //        Rasterlocation of mesh (0 < n < ngri )
            public float  m_w;                          //        the weight of NURBS control point
            public float  m_x;                          // [1001] X-ordinate
            public float  m_y;                          // [1001] Y-ordinate
            public float  m_z;                          // [1001] Z-ordinate
            public float  m_t;                          // [1010] Thickness
      } // cs_sar_pts

      public unsafe struct cs_sar_cpi                   //        39/NR:212  COONsPatchInfo
      {
            public int  m_id;                           //        Id = 212
            public int  m_it;                           //        Type of blending
            public int  m_iu0;                          //        No of geometry line for u=umin (left)
            public int  m_iu1;                          //        No of geometry line for u=umax (right)
            public int  m_iv0;                          //        No of geometry line for v=vmin (lower)
            public int  m_iv1;                          //        No of geometry line for v=vmax (upper)
      } // cs_sar_cpi

      public unsafe struct cs_sar_exyz                  //        39/NR:220  Explicit QUAD nodes on area
      {
            public int  m_id;                           //        identifier = 220
            public int  m_id1;                          //        reserved
            public fixed float  m_xyz[4*3];             // [1001] XYZ coordinates
      } // cs_sar_exyz

      public unsafe struct cs_gar_exyz                  //        32/NR:220  Explicit QUAD nodes on area
      {
            public int  m_id;                           //        identifier = 220
            public int  m_id1;                          //        reserved
            public fixed float  m_xyz[4*3];             // [1001] XYZ coordinates
      } // cs_gar_exyz

      public unsafe struct cs_sar_supp                  //        39/NR:221  Support and coupling of structural areas
      {
            public int  m_id;                           //        identifier 221
            public int  m_ids;                          //        type of reference
            public int  m_ref;                          //        reference identifier
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_ibc;                          //        Boundary condition / kinematic constraints
            public int  m_i6;                           //        reserved
            public int  m_rctl;                         //        properties of area-area reference
            public int  m_rptr;                         //        reference point on boundary of referenced area
            public int  m_rpt0;                         //        reference point on boundary of given area
            public int  m_i10;                          //        reserved
            public float  m_d;                          // [1001] distance of interface layer
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
      } // cs_sar_supp

      public unsafe struct cs_gar_supp                  //        32/NR:221  Support and coupling of structural areas
      {
            public int  m_id;                           //        identifier 221
            public int  m_ids;                          //        type of reference
            public int  m_ref;                          //        reference identifier
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_ibc;                          //        Boundary condition / kinematic constraints
            public int  m_i6;                           //        reserved
            public int  m_rctl;                         //        properties of area-area reference
            public int  m_rptr;                         //        reference point on boundary of referenced area
            public int  m_rpt0;                         //        reference point on boundary of given area
            public int  m_i10;                          //        reserved
            public float  m_d;                          // [1001] distance of interface layer
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
      } // cs_gar_supp

      public unsafe struct cs_svo                       //        39/NR:300  StructuralVolume
      {
            public int  m_id;                           //        identification = 300
            public int  m_ids;                          //        identifier of structural area (0=auto)
            public int  m_ref;                          //        reference to a given GVO (reserved)
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_nor;                          //        number of reinforc.
            public int  m_not;                          //        number of elementtype
            public int  m_ibc;                          //        Boundary condition
            public int  m_id8;                          //        reserved
            public int  m_id9;                          //        reserved
            public fixed int m_text[17];                //        Designation of Volume
      } // cs_svo

      public unsafe struct cs_spt_id                    //        39/NR:999  GUId
      {
            public int  m_id;                           //        identifier 999
            public fixed int  m_idbim[36];              //        256 Bit GUId Identifier of preceeding element
      } // cs_spt_id

      enum GPT_IBC_SUP { GPT_IBC_SUP = 8192 }
      enum GPT_IBC_REF { GPT_IBC_REF = 32768 }
      public unsafe struct cs_gpt                       //        30/NR:0  Structural points
      {
            public int  m_id;                           //        identifier 0 (always the first record)
            public int  m_ibc;                          //        Boundary condition
            public fixed float  m_xyz[3];               // [1001] Ordinates
            public fixed float  m_t[3*3];               //        transformation matrix
            public float  m_bx;                         // [1001] Dimension in x
            public float  m_by;                         // [1001] Dimension in y
            public float  m_thick;                      // [1010] Plate thickness
            public float  m_hmesh;                      // [1001] Mesh density at point
            public float  m_r17;                        //        reserved
            public fixed int m_text[17];                //        Designation of Point
      } // cs_gpt

      public unsafe struct cs_gpt_coh                   //        30/NR:1  Dimension of column head
      {
            public int  m_id;                           //        identifier 1/2/3
            public int  m_ns;                           //        Number of a cross section 9/NR for details
            public float  m_x;                          // [1001] Width in local x
            public float  m_y;                          // [1001] Width in local y
            public float  m_a;                          // [1002] Equivalent Area
            public float  m_t;                          // [1010] Plate thickness
      } // cs_gpt_coh

      public unsafe struct cs_gpt_hau                   //        30/NR:2  Dimension of voute
      {
            public int  m_id;                           //        identifier 1/2/3
            public int  m_ns;                           //        Number of a cross section 9/NR for details
            public float  m_x;                          // [1001] Width in local x
            public float  m_y;                          // [1001] Width in local y
            public float  m_a;                          // [1002] Equivalent Area
            public float  m_t;                          // [1010] Plate thickness
      } // cs_gpt_hau

      public unsafe struct cs_gpt_pun                   //        30/NR:3  Dimension of punching perimeter
      {
            public int  m_id;                           //        identifier 1/2/3
            public int  m_ns;                           //        Number of a cross section 9/NR for details
            public float  m_x;                          // [1001] Width in local x
            public float  m_y;                          // [1001] Width in local y
            public float  m_a;                          // [1002] Equivalent Area
            public float  m_t;                          // [1010] Plate thickness
      } // cs_gpt_pun

      public unsafe struct cs_gpt_col                   //        30/NR:4  Connecting columns
      {
            public int  m_id;                           //        identifier 4
            public int  m_ns;                           //        Number of a cross section 9/NR for column
            public float  m_x;                          // [1001] Width in local x
            public float  m_y;                          // [1001] Width in local y
            public float  m_a;                          // [1002] Equivalent Area
            public float  m_l;                          // [1001] Column length
            public float  m_fak;                        //        Rigidity factor
      } // cs_gpt_col

      public unsafe struct cs_gpt_foo                   //        30/NR:5  Footing instance definition
      {
            public int  m_id;                           //        identifier 5
            public int  m_pos;                          //        referenced building position
            public int  m_type;                         //        Type of foundation
            public int  m_igp;                          //        Bitpattern Foundation Properties
            public int  m_idr;                          //        Bitpattern Design Results
            public int  m_ir1;                          //        reserved
            public int  m_mno;                          //        Id of concrete material
            public int  m_mrf;                          //        Id of reinforcement material
            public int  m_nrsp;                         //        Id of soil profile (002/NR)
            public fixed float  m_t[3*3];               //        Orientation of local coordinate system
            public float  m_bx;                         // [1001] Width in local x
            public float  m_by;                         // [1001] Width in local y
            public float  m_hi;                         // [1001] inner Thickness
            public float  m_ha;                         // [1001] outer Thickness
            public float  m_ex;                         // [1001] Eccentricity of column in local x-direction
            public float  m_ey;                         // [1001] Eccentricity of column in local y-direction
            public float  m_ez;                         // [1001] Eccentricity of endpoint of column(=structural point) in local 
            public float  m_clx;                        // [1011] Assumed dimension of column in local x-direction
            public float  m_cly;                        // [1011] Assumed dimension of column in local y-direction
            public float  m_sxt;                        // [1024] Boundary distance of x-aligned reinforcement on top face
            public float  m_syt;                        // [1024] Boundary distance of y-aligned reinforcement on top face
            public float  m_sxb;                        // [1024] Boundary distance of x-aligned reinforcement on bottom face
            public float  m_syb;                        // [1024] Boundary distance of y-aligned reinforcement on bottom face
            public float  m_covt;                       // [1024] Concrete cover (nominal) on top face
            public float  m_covb;                       // [1024] Concrete cover (nominal) on bottom face
            public float  m_covl;                       // [1024] Concrete cover (nominal) on lateral faces
            public float  m_res1;                       //        Reserved
            public float  m_res2;                       //        Reserved
            public float  m_res3;                       //        Reserved
            public float  m_res4;                       //        Reserved
            public float  m_slho;                       // [1001] obsolete
            public float  m_slhi;                       // [1001] obsolete
            public float  m_slwx;                       // [1001] obsolete
            public float  m_slwy;                       // [1001] obsolete
            public float  m_slgu;                       // [1001] obsolete
            public float  m_slgl;                       // [1001] obsolete
            public fixed float  m_data[12];             //        Reserved
            public fixed int m_titl[17];                //        Designation of Foundation
      } // cs_gpt_foo

      public unsafe struct cs_gpt_frr                   //        30/NR:1005  Footing required reinforcement
      {
            public int  m_id;                           //        identifier 1005
            public int  m_type;                         //        Type of reinforcement
            public int  m_n_as;                         //        number of values stored in array AS
            public int  m_ir1;                          //        reserved
            public int  m_ir2;                          //        reserved
            public float  m_xoff;                       // [1001] offset of distribution in x-direction
            public float  m_yoff;                       // [1001] offset of distribution in y-direction
            public float  m_res1;                       //        reserved
            public float  m_res2;                       //        reserved
            public fixed float  m_as[32];               // [1021] reinforcement values
      } // cs_gpt_frr

      public unsafe struct cs_gpt_slp                   //        30/NR:1006  Sleeve foundation properties
      {
            public int  m_id;                           //        identifier 1006
            public int  m_ir1;                          //        reserved
            public int  m_ir2;                          //        reserved
            public int  m_ir3;                          //        reserved
            public float  m_hswo;                       // [1001] Outer height of sleeve wall (measured from z=0 of local coordin
            public float  m_hswi;                       // [1001] Inner height of sleeve wall (measured from upper face of sleeve
            public float  m_wxwu;                       // [1001] Upper width of sleeve wall in x-direction
            public float  m_wywu;                       // [1001] Upper width of sleeve wall in y-direction
            public float  m_wxwl;                       // [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
            public float  m_wywl;                       // [1001] Lower width of sleeve wall in y-direction
            public float  m_wxgu;                       // [1001] Upper width of gap between wall and column in x-direction
            public float  m_wygu;                       // [1001] Upper width of gap between wall and column in y-direction
            public float  m_wxgl;                       // [1001] Lower width of gap between wall and column in x-direction
            public float  m_wygl;                       // [1001] Lower width of gap between wall and column in y-direction
            public float  m_clx;                        // [1011] Assumed dimension of column in local x-direction (deprecated)
            public float  m_cly;                        // [1011] Assumed dimension of column in local y-direction (deprecated)
      } // cs_gpt_slp

      public unsafe struct cs_gpt_hpi                   //        30/NR:6  Halfspace pile
      {
            public int  m_id;                           //        identifier 6
            public int  m_nq;                           //        number cross section   =0 if diameter from 030/NR:0
            public float  m_l;                          // [1001] pile length in GDIR direction
            public float  m_mant;                       //        percentage of skin friction for linear analysis
            public float  m_zman;                       //        percentage of inactive skin length
            public float  m_pman;                       // [1151] maximum load skin friction (nonlinear analysis)
            public float  m_pmaf;                       // [1151] maximum load pile foot
      } // cs_gpt_hpi

      public unsafe struct cs_gpt_con_m                 //        connected members
      {
            public int  m_nelt;
            public int  m_nrel;
            public int  m_node;
            public int  m_narb;
            public float  m_x;                          // [1001] 
      } // cs_gpt_con_m

      public unsafe struct cs_gpt_con                   //        30/NR:8  Steelconnection reference
      {
            public int  m_id;                           //        identifier 8
            public int  m_conid;                        //        connection identifier
            public cs_gpt_con_m  m_m;                   //        connected members
      } // cs_gpt_con

      public unsafe struct cs_gpt_spr                   //        30/NR:10  Elastic Spring support
      {
            public int  m_id;                           //        identifier 10
            public int  m_iri;                          //        direction
            public int  m_nr;                           //        element number
            public int  m_ng;                           //        group number
            public int  m_ipc;                          //        connecting to node
            public int  m_nwl;                          //        Material/section no (see  184 170/0 )
            public fixed float  m_t[3];                 //        explicit direction (dx,dy,dz)
            public float  m_aref;                       //        reference area (see  184 170/0 )
            public float  m_cp;                         // [1095] spring stiffness z
            public float  m_cq;                         // [1095] transverse stiff.
            public float  m_cm;                         // [1098] torsional stiff.
            public float  m_pre;                        //        prestress for cp
            public float  m_gap;                        //        slip of spring
            public float  m_riss;                       //        max tension force
            public float  m_flie;                       //        yielding load
            public float  m_mue;                        //        friction cross
            public float  m_coh;                        //        cohesion cross
            public float  m_dil;                        //        dilatancy factor
            public float  m_gapq;                       //        transverse slip/gap
      } // cs_gpt_spr

      public unsafe struct cs_gpt_kin                   //        30/NR:11  Kinematic Constraint
      {
            public int  m_id;                           //        identifier 11
            public int  m_ktl;                          //        type +  10000*group-number
            public int  m_kr1;                          //        reference GPT 1
            public int  m_kr2;                          //        reference GPT 2
            public float  m_dx;                         //        direction of coupling X-axis
            public float  m_dy;                         //        direction of coupling Y-axis
            public float  m_dz;                         //        direction of coupling Z-axis
            public float  m_dd;                         //        factor of interpolation
            public float  m_ff;                         //        factor of multiplication
      } // cs_gpt_kin

      public unsafe struct cs_gpt_spc                   //        30/NR:12  Elastic Spring connection (obsoleted)
      {
            public int  m_id;                           //        identifier 12
            public int  m_iri;                          //        direction + 100*sign(group number,direction)
            public int  m_ipc;                          //        connecting Spoint
            public int  m_nwl;                          //        work law number
            public float  m_cp;                         // [1095] spring stiffness z
            public float  m_cq;                         // [1095] transverse stiff.
            public float  m_cm;                         // [1098] torsional stiff.
            public float  m_pre;                        //        prestress for cp
            public float  m_gap;                        //        slip of spring
            public float  m_riss;                       //        max tension force
            public float  m_flie;                       //        yielding load
            public float  m_mue;                        //        friction cross
            public float  m_coh;                        //        cohesion cross
            public float  m_dil;                        //        dilatancy factor
      } // cs_gpt_spc

      public unsafe struct cs_gpt_dads                  //        30/NR:998  Ids of items being an anchestor
      {
            public int  m_id;                           //        ident 998
            public fixed int  m_idd[63];                //        ids of all anchestors
      } // cs_gpt_dads

      public unsafe struct cs_gln                       //        31/NR:0  Structural lines
      {
            public int  m_id;                           //        identifier 0
            public fixed int  m_pt[2];                  //        Number start & end point
            public int  m_i3;                           //        reserved
            public int  m_ibt;                          //        Bitpattern of element properties acc. 39/NR:100 IBT
            public int  m_ibc;                          //        Boundary condition acc. 39/NR:100 IBC
            public fixed float  m_i_0[10];              //        reserved
            public float  m_hmesh;                      // [1001] mesh density along line acc. 39/NR:100 HMESH
            public fixed float  m_i_11[3];              //        reserved
            public float  m_prog;                       //        progression factor (>0 monoton, <0 symmetric)
            public float  m_i_15;
            public fixed int m_text[17];                //        Designation of Line
      } // cs_gln

      public unsafe struct cs_gln_ref                   //        31/NR:-  Reference to another Geometry
      {
            public int  m_igm;                          //        negative value of the master geometry
            public int  m_igs;                          //        optional identifier of a secondary axis
            public float  m_smin;                       //        min parameter on referenced axis
            public float  m_smax;                       //        max parameter on referenced axis
      } // cs_gln_ref

      enum GLN_GEO_DEFAULT { GLN_GEO_DEFAULT = 1 }
      enum GLN_GEO_KLOTOID { GLN_GEO_KLOTOID = 2 }
      enum GLN_GEO_SPLINE { GLN_GEO_SPLINE = 3 }
      enum GLN_GEO_EXSPLI { GLN_GEO_EXSPLI = 4 }
      enum GLN_GEO_BEZIER { GLN_GEO_BEZIER = 5 }
      enum GLN_GEO_NURBS { GLN_GEO_NURBS = 6 }
      enum GLN_GEO_NURBX { GLN_GEO_NURBX = 7 }
      enum GLN_GEO_DATA { GLN_GEO_DATA = 8 }
      enum GLN_GEO_NORM { GLN_GEO_NORM = 9 }
      enum GLN_GEO_CIRC { GLN_GEO_CIRC = 10 }
      enum GLN_GEO_DWN_POSY { GLN_GEO_DWN_POSY = +2 }
      enum GLN_GEO_DWN_NEGY { GLN_GEO_DWN_NEGY = -2 }
      enum GLN_GEO_DWN_POSZ { GLN_GEO_DWN_POSZ = +3 }
      enum GLN_GEO_DWN_NEGZ { GLN_GEO_DWN_NEGZ = -3 }
      public unsafe struct cs_gln_geo                   //        31/NR:??  Geometric properties
      {
            public int  m_iln;                          //        Code of geometry
            public float  m_gpg;                        // [1001] geometry parameter 1
            public float  m_gpa;                        // [1001] geometry parameter 2
            public float  m_dd;                         // [1001] arc length
            public float  m_s1;                         //        parameter s on start
            public fixed float  m_xyz1[3];              // [1001] Ordinate of start
            public fixed float  m_dxyz1[3];             //        Tangent of start
            public float  m_rg1;                        // [1009] in-plane curvature
            public float  m_ra1;                        // [1009] vertical curvature
            public float  m_s2;                         //        parameter s on end
            public fixed float  m_xyz2[3];              // [1001] Ordinate of endpoint
            public fixed float  m_dxyz2[3];             //        Tangent of endpoint
            public float  m_rg2;                        // [1009] in-plane curvature
            public float  m_ra2;                        // [1009] vertical curvature
      } // cs_gln_geo

      enum GLN_BEAM_IBC_LOCAL { GLN_BEAM_IBC_LOCAL = 16384 }
      enum GLN_BEAM_IBC_NFREE { GLN_BEAM_IBC_NFREE = 32768 }
      public unsafe struct cs_gln_beam                  //        31/NR:100  Properties of beams (obsoleted)
      {
            public int  m_id;                           //        ident 100
            public int  m_nog;                          //        Element type
            public int  m_nq;                           //        number cross section
            public int  m_np;                           //        number bedding props
            public int  m_ibc;                          //        Hinge code
            public int  m_div;                          //        prescribed subdivision no of segments
            public float  m_eya;                        // [1001] eccentricity at start
            public float  m_eza;                        // [1001] eccentricity at start
            public float  m_eye;                        // [1001] eccentricity at end
            public float  m_eze;                        // [1001] eccentricity at end
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
            public float  m_cm;                         // [1099] torsional bedding
            public float  m_cx;                         // [1096] global X  bedding
            public float  m_cy;                         // [1096] global Y  bedding
            public float  m_cz;                         // [1096] global Z  bedding
            public float  m_cxx;                        // [1099] global X  tors.bed.
            public float  m_cyy;                        // [1099] global Y  tors.bed.
            public float  m_czz;                        // [1099] global Z  tors.bed.
      } // cs_gln_beam

      public unsafe struct cs_gln_elnr                  //        31/NR:121  Elements generated on lines
      {
            public int  m_id;                           //        identifier = 121
            public int  m_etyp;                         //        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
            public int  m_ibit;                         //        Bit-code
            public fixed int  m_nr[253];                //        packed list of element numbers
      } // cs_gln_elnr

      public unsafe struct cs_gln_dads                  //        31/NR:998  Ids of items being an anchestor
      {
            public int  m_id;                           //        ident 998
            public fixed int  m_idd[63];                //        ids of all anchestors
      } // cs_gln_dads

      enum GAR_IBC_REF { GAR_IBC_REF = 32768 }
      public unsafe struct cs_gar                       //        32/NR:0  Structural area
      {
            public int  m_id;                           //        identification of general data (0)
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_nor;                          //        number of reinforc.
            public int  m_itp;                          //        Bitpattern for element generation QUAD
            public int  m_ibc;                          //        Boundary condition
            public fixed float  m_td[5];                // [1010] Constant thickness
            public float  m_cb;                         //        bedding factor
            public float  m_cq;                         //        tangential bedding factor
            public float  m_trot;                       //        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis
            public fixed int m_text[17];                //        Designation of surface
      } // cs_gar

      public unsafe struct cs_gar_ref                   //        32/NR:-  Reference to another Geometry
      {
            public int  m_igm;                          //        negative value of the master geometry
      } // cs_gar_ref

      public unsafe struct cs_gar_boun                  //        32/NR:1  Outer Boundary of Area
      {
            public int  m_id;                           //        identification
            public int  m_ng;                           //        edgeno     (31/NG)
            public int  m_na;                           //        startpoint (30/NA)
            public int  m_nb;                           //        endpoint   (30/NB)
            public int  m_nm;                           //        midpoint   (30/NM)
            public int  m_ifc;                          //        Interface hinge bit pattern
            public float  m_t;                          // [1010] Plate thickness of edge
            public float  m_dfix;                       // [1001] Distance (offset) of region to edge
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
            public float  m_cm;                         // [1099] torsional bedding
      } // cs_gar_boun

      public unsafe struct cs_gar_hole                  //        32/NR:2  Inner Boundary of Area
      {
            public int  m_id;                           //        identification
            public int  m_ng;                           //        edgeno     (31/NG)
            public int  m_na;                           //        startpoint (30/NA)
            public int  m_nb;                           //        endpoint   (30/NB)
            public int  m_nm;                           //        midpoint   (30/NM)
            public int  m_ifc;                          //        Interface hinge bit pattern
            public float  m_t;                          // [1010] Plate thickness of edge
            public float  m_dfix;                       // [1001] Distance (offset) of region to edge
            public float  m_ca;                         // [1096] axial     bedding
            public float  m_cq;                         // [1096] lateral   bedding
            public float  m_cm;                         // [1099] torsional bedding
      } // cs_gar_hole

      public unsafe struct cs_gar_con3                  //        32/NR:3  Prescribed Edges/Points
      {
            public int  m_id;                           //        identification
            public int  m_ng;                           //        edgenumber (31/NG)
            public int  m_na;                           //        startpoint (30/NA)
            public int  m_nb;                           //        endpoint   (30/NB)
            public int  m_nm;                           //        midpoint   (30/NM)
            public int  m_mat;                          //        Materialnumber of subregion for ID==4
            public float  m_t;                          // [1010] Plate thickness at edge or point
      } // cs_gar_con3

      public unsafe struct cs_gar_con4                  //        32/NR:4  Domain-Subdivision-Edges
      {
            public int  m_id;                           //        identification
            public int  m_ng;                           //        edgenumber (31/NG)
            public int  m_na;                           //        startpoint (30/NA)
            public int  m_nb;                           //        endpoint   (30/NB)
            public int  m_nm;                           //        midpoint   (30/NM)
            public int  m_mat;                          //        Materialnumber of subregion for ID==4
            public float  m_t;                          // [1010] Plate thickness at edge or point
      } // cs_gar_con4

      public unsafe struct cs_gar_mesh                  //        32/NR:9  Prescribed Mesh size
      {
            public int  m_id;                           //        identification
            public int  m_ng;                           //        number of support macro generating mesh
            public int  m_na;                           //        startedge  (31/NA)
            public int  m_nb;                           //        endedge    (31/NB)
            public int  m_i4;                           //        not used
            public int  m_i5;                           //        not used
            public fixed float  m_hsize[3];             // [1001] requested mesh size
            public fixed float  m_pta[3];               // [1001] Coordinates of startpoint
            public fixed float  m_pte[3];               // [1001] Coordinates of endpoint
            public fixed float  m_ptm[3];               // [1001] Coordinates of midpoint
      } // cs_gar_mesh

      public unsafe struct cs_gar_geo                   //        32/NR:10  Geometry of surface
      {
            public int  m_id;                           //        Identification of surface description 10
            public int  m_ng;                           //        Type of surface representation
            public int  m_mgri;                         //        number of data/control points in s of mesh
            public int  m_ngri;                         //        number of data/control points in t of mesh
            public int  m_mspl;                         //        degree of B-spline in s direction
            public int  m_nspl;                         //        degree of B-spline in t direction
            public float  m_sx;                         //        plane  direction sx
            public float  m_sy;                         //        plane  direction sy
            public float  m_sz;                         //        plane  direction sz
            public float  m_tx;                         //        plane  direction tx
            public float  m_ty;                         //        plane  direction ty
            public float  m_tz;                         //        plane  direction tz
            public float  m_nx;                         //        normal direction nx
            public float  m_ny;                         //        normal direction ny
            public float  m_nz;                         //        normal direction nz
            public float  m_x;                          // [1001] X-ordinate Origin
            public float  m_y;                          // [1001] Y-ordinate Origin
            public float  m_z;                          // [1001] Z-ordinate Origin
            public fixed float  m_par[16];              //        additional Parameters
            public fixed float  m_box[3*2];             // [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
            public fixed float  m_xpar[9999];           //        extended parameters
      } // cs_gar_geo

      public unsafe struct cs_gar_surf                  //        32/NR:11  UserPointonSurface
      {
            public int  m_id;                           //        Identification of user surface description 11
            public int  m_it;                           //        Type of point
            public int  m_m;                            //        Rasterlocation of mesh 0 < m ( mgri )
            public int  m_n;                            //        Rasterlocation of mesh 0 < n ( ngri )
            public int  m_n3;                           //        the degree of the Spline becoming effective
            public int  m_n4;                           //        the weight of NURBS control point [-]
            public float  m_x;                          // [1001] X-ordinate
            public float  m_y;                          // [1001] Y-ordinate
            public float  m_z;                          // [1001] Z-ordinate
            public float  m_t;                          // [1010] Thickness
      } // cs_gar_surf

      public unsafe struct cs_gar_coon                  //        32/NR:12  COONsPatchInfo
      {
            public int  m_id;                           //        Identification of COONs blending edges 12
            public int  m_it;                           //        Type of blending
            public int  m_iu0;                          //        No of geometry line for u=umin (left)
            public int  m_iu1;                          //        No of geometry line for u=umax (right)
            public int  m_iv0;                          //        No of geometry line for v=vmin (lower)
            public int  m_iv1;                          //        No of geometry line for v=vmax (upper)
            public fixed float  m_sp[4*3];              //        Length parameters for the edges iu0,iu1,iv0,iv1
            public fixed float  m_uv[2*2];              //        umin,umax,vmin,vmax of the parameter plane
            public fixed float  m_cxyz[4*3];            //        Coordinates of the corner points C1,C2,C3,C4
            public fixed float  m_tinc[8*3];            //        inclinations for a bicubic patch as vectors
            public fixed float  m_twist[4*3];           //        Twist of x,y,z-Ordinate at corner C1 (0,0)
      } // cs_gar_coon

      public unsafe struct cs_gar_elnr                  //        32/NR:221  Generated elements from area
      {
            public int  m_id;                           //        identifier = 221
            public int  m_etyp;                         //        Type of element {200,...} for {QUAD,...}
            public int  m_id2;                          //        reserved
            public fixed int  m_nr[253];                //        packed list of element numbers
      } // cs_gar_elnr

      public unsafe struct cs_gar_dads                  //        32/NR:998  Ids of items being an anchestor
      {
            public int  m_id;                           //        ident 998
            public fixed int  m_idd[63];                //        ids of all anchestors
      } // cs_gar_dads

      public unsafe struct cs_gvo                       //        33/NR:0  StructuralVolume
      {
            public int  m_id;                           //        identification of general data (0)
            public int  m_nog;                          //        number of group
            public int  m_nom;                          //        number of material
            public int  m_nor;                          //        number of reinforc.
            public int  m_not;                          //        number of elementtype
            public int  m_ibc;                          //        Boundary condition
            public fixed int m_text[17];                //        Designation of Volume
      } // cs_gvo

      public unsafe struct cs_gvo_surf                  //        33/NR:+  Involved Surfaces
      {
            public int  m_itp;                          //        identification of definition
            public int  m_ng;                           //        surface    (32/NG)
            public int  m_nr;                           //        extrusion or rotation geometry identifier
            public int  m_nref;                         //        optional number of a reference point
            public int  m_nara;                         //        region identifier for start surface
            public int  m_nare;                         //        region identifier for end surface
            public float  m_t;                          // [1010] Thickness of interface layer
            public float  m_fac;                        //        Scale factor for extrusion
            public float  m_fac0;                       //        Scale factor for start segment
            public float  m_phi;                        // [   5] end rotation angle for extrusion/rotation
            public float  m_phi0;                       // [   5] start rotation angle for rotation
            public float  m_dphi;                       // [   5] allowable sector angle for rotation
            public float  m_dx;                         // [1001] explicit extrusion / rotational axis
            public float  m_dy;                         // [1001] explicit extrusion / rotational axis
            public float  m_dz;                         // [1001] explicit extrusion / rotational axis
            public float  m_xref;                       // [1001] explicit reference point
            public float  m_yref;                       // [1001] explicit reference point
            public float  m_zref;                       // [1001] explicit reference point
            public fixed float  m_tfac[3];              // [1010] Factor for thickness extrusion START/END/REF
      } // cs_gvo_surf

      public unsafe struct cs_sgrp                      //        37/ID:0  Secondary groups
      {
            public int  m_id0;                          //        identification of general data (0)
            public int  m_typ;                          //        Bit infos of selected element types
            public int  m_bit;                          //        Bit infos on selections contained in that group
            public fixed int m_text[17];                //        Designation of sgrp
      } // cs_sgrp

      public unsafe struct cs_sgrp_box                  //        37/ID:1  Selective Basic-Volume
      {
            public int  m_id;                           //        identification of data (1)
            public int  m_typ;                          //        type of property volume
            public int  m_bit;                          //        option
            public fixed float  m_par[7*3];             // [1001] PARAMETERS OF BOX par(3,0:6)
      } // cs_sgrp_box

      public unsafe struct cs_sgrp_pol                  //        37/ID:2  Selective Polyeder-Volume
      {
            public int  m_id;                           //        identification of data (2)
            public int  m_typ;                          //        number of vertices
            public int  m_bit;                          //        option
            public fixed float  m_t[4*3];               //        transformation matrix to local coordinates
            public fixed float  m_ext[3*3];             // [1001] global extension, local extensions min/max
            public fixed float  m_vert[63*3];           // [1001] vertices in local coordinates r,s,t
      } // cs_sgrp_pol

      public unsafe struct cs_sgrp_lis                  //        37/ID:0???  Calculated Selective Element List
      {
            public int  m_id;                           //        identifier of element to be selected (positive)
            public fixed int  m_nr[255];                //        element numbers
      } // cs_sgrp_lis

      public unsafe struct cs_sgrp_add                  //        37/ID:1???  Selecting Element List
      {
            public int  m_id;                           //        identifier of element to be selected (positive)
            public fixed int  m_nr[255];                //        element numbers
      } // cs_sgrp_add

      public unsafe struct cs_sgrp_sub                  //        37/ID:2???  Excluding Element List
      {
            public int  m_id;                           //        identifier of element to be selected (positive)
            public fixed int  m_nr[255];                //        element numbers
      } // cs_sgrp_sub

      public unsafe struct cs_sgrp_sel                  //        37/ID:3???  Property-Values
      {
            public int  m_id;                           //        identifier of element to be modified
            public int  m_type;                         //        Option to perform
            public int  m_bit;                          //        bit pattern of selected data
            public int  m_itp;                          //        key value for orientation of coordinate system
            public int  m_div;                          //        key value of subdivision or other extended data
            public int  m_idq;                          //        key value of cross section or other extended data
            public int  m_idh;                          //        key value of hinge conditions or other extended data
            public int  m_idx;                          //        key value of other extended data
            public float  m_trot;                       //        Fractional rotation about
            public fixed float  m_tal[3];               //        Vector to be aligned as local axis
            public fixed float  m_rdat[4];              //        reserved for values not in DATA
            public fixed int  m_data[64];               //        equivalenced data structure of that
      } // cs_sgrp_sel

      public unsafe struct cs_glar_0                    //        38/NR:0  Load distribution areas Header
      {
            public int  m_id;                           //        Identification 0
            public int  m_ngar;                         //        number of an 32/NGAR area definition
            public fixed int  m_ngrp[4];                //        group of area and three active groups
            public int  m_mgri;                         //        prescribed grid subdivision (NGAR=0)
            public int  m_ngri;                         //        prescribed grid subdivision (NGAR=0)
            public int  m_id32;                         //        access ID of 32/0 to check valid data
            public int  m_id20;                         //        access ID of 20/0 to check valid data
            public int  m_nnod;                         //        number of nodes            38/NR:1
            public int  m_nqua;                         //        number of quadrilaterals   38/NR:2
            public int  m_nseg;                         //        number of beam sections    38/NR:3
            public fixed int  m_dummy[2];               //        reserved
            public int  m_sgrp;                         //        optional secondary group selector id
            public float  m_t;                          // [1010] thickness of load area used to catch beams
            public fixed float  m_xyz[4*3];             // [1001] ! 4 corner points of area (optional)
      } // cs_glar_0

      public unsafe struct cs_glar_nod                  //        38/NR:1  Node of load distribution area
      {
            public int  m_id;                           //        Identification 1 (instead of NR)
            public int  m_inr;                          //        nodenumber within the region
            public int  m_nfix;                         //        not used
            public int  m_ncod;                         //        not used
            public fixed float  m_xyz[3];               // [1001] coordinates
            public fixed float  m_dxyz[3];              // [1001] displacements for uniform load -> animator
      } // cs_glar_nod

      public unsafe struct cs_glar_qua                  //        38/NR:2  QUAD of load distribution area
      {
            public int  m_id;                           //        Identification 2 (instead of NR)
            public fixed int  m_node[4];                //        nodenumbers of the quad within region
            public int  m_mat;                          //        not used
            public int  m_mrf;                          //        not used
            public int  m_nra;                          //        type of element
            public fixed float  m_det[3];               //        Parameter of Jacobi Determinant
            public fixed float  m_thick[5];             // [1010] element thickness
            public float  m_cb;                         //        not used
            public float  m_cq;                         //        not used
            public fixed float  m_t[3*3];               //        transformation matrix
      } // cs_glar_qua

      public unsafe struct cs_glar_seg                  //        38/NR:3  BEAM segments within area
      {
            public int  m_id;                           //        Identification 3
            public int  m_nr;                           //        number of loaded beam element
            public float  m_x;                          // [1001] start point
            public float  m_l;                          // [1001] length of segment
      } // cs_glar_seg

      public unsafe struct cs_glar_p                    //        38/NR:1?  Load distribution areas  Pointloads
      {
            public int  m_id;                           //        Identification 10:13
            public int  m_inr;                          //        nodenumber of 038/NR:1 within region
            public int  m_node;                         //        nodenumber of a global node
            public fixed float  m_p[4];                 //        value of load
      } // cs_glar_p

      public unsafe struct cs_glar_l                    //        38/NR:10?  Load distribution areas  Beamloads
      {
            public int  m_id;                           //        Identification 100:103
            public int  m_inr;                          //        nodenumber of 038/NR:1 within region
            public int  m_nseg;                         //        number of 038/NR:3 segment
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
            public float  m_ma;                         //        start value of torque
            public float  m_me;                         //        end value of torque
      } // cs_glar_l

      public unsafe struct cs_tendaxis                  //        40/NR:0  Tendon lanes/reference axis data
      {
            public int  m_id0;                          //        identifier 0
            public int  m_igsys;                        //        prestress for:
            public int  m_iginfo;                       //        Systeminfo
            public int  m_igref;                        //        reference to geometry
            public int  m_icbit;                        //        bit for analysis type
            public int  m_ids;                          //        Enum of secondary axis (1='A' to 26 ='Z')
            public fixed int m_text[17];                //        Designation
      } // cs_tendaxis

      public unsafe struct cs_tendax_1                  //        40/NR:1  Tendon lane stations
      {
            public int  m_id0;                          //        identifier 1
            public int  m_igbit;                        //        station parameter
            public int  m_nrstab;                       //        internal beam number
            public int  m_id3;                          //        reserved (value = 0)
            public float  m_xl;                         //        beam X/L on beam
            public float  m_s;                          // [1001] station on reference lane
            public float  m_sg;                         // [1001] station of geometry
            public float  m_sf;                         //        toppoint station
      } // cs_tendax_1

      public unsafe struct cs_tendspli                  //        41/NR:0  Tendon splines
      {
            public int  m_id0;                          //        identifier 0
            public int  m_nrspur;                       //        corresponding lane
            public int  m_nrsv;                         //        prestress system
            public int  m_igsys;                        //        prestress for:
            public int  m_intyp;                        //        bit for analysis type
            public int  m_igref;                        //        reference to      geometry  Rec: 03
            public int  m_igrefx;                       //        reference to exc. geometry  Rec: 03
            public int  m_id7;                          //        reserved (value = 0)
            public int  m_id8;                          //        reserved (value = 0)
            public int  m_id9;                          //        reserved (value = 0)
            public fixed float  m_stparm[12];           //        additional data:
            public fixed int m_text[17];                //        Designation
      } // cs_tendspli

      public unsafe struct cs_tendsp_i                  //        41/NR:??  Input points
      {
            public int  m_id0;                          //        identifier INTYP see 41/0  (1=ZPUV standard geometry)
            public int  m_igbit;                        //        station parameter see 40/1
            public int  m_id2;                          //        reserved (value = 0)
            public int  m_id3;                          //        reserved (value = 0)
            public fixed float  m_data[20];             //        Input point data
            public int  m_qsp;                          //        Selection string - reference to cross section point
            public int  m_varu;                         //        Selection string - axis variable for offset U
            public int  m_varv;                         //        Selection string - axis variable for offset V
            public fixed float  m_dat2[50];             //        Additional input point
      } // cs_tendsp_i

      public unsafe struct cs_tendtopp                  //        43/NR  Tendon toppoints
      {
            public int  m_id0;                          //        identifier:
            public int  m_nr;                           //        corresponding lane
            public int  m_igref;                        //        reference to      geometry  Rec: 03
            public fixed float  m_s[124];               // [1001] stations on toppoints (max. 124)
      } // cs_tendtopp

      public unsafe struct cs_tendon                    //        44/NR:0  Tendons
      {
            public int  m_id0;                          //        identifier 0
            public int  m_nrspur;                       //        corresponding lane
            public int  m_nrspli;                       //        Spline-No
            public int  m_nrstrg;                       //        tendon no.
            public int  m_igref;                        //        reference to      geometry  Rec: 03
            public int  m_igtyp;                        //        bit for analysis type
            public int  m_iz_ref;                       //        IGTYP=1024:  Def-No of geometry
            public fixed int  m_niba[3];                //        construction stages
            public int  m_nrsv;                         //        prestress system
            public int  m_nsp;                          //        number of tendons
            public int  m_mata;                         //        material concrete
            public int  m_nvart;                        //        type of jacking
            public int  m_nvartu;                       //        output control
            public int  m_nvvor;                        //        prestress input
            public fixed int  m_nvbit[2];               //        jacking bit
            public fixed int  m_lfp[2];                 //        prestress loadcases
            public int  m_igsys;                        //        prestress for:
            public int  m_id21;                         //        reserved (value = 0)
            public float  m_kapa;                       //        KAPA + 100*KAPL + 1000*action
            public float  m_einl;                       //        transition length
            public float  m_etyp;                       //        force type to EINL
            public float  m_tfak;                       //        factor partial p
            public float  m_tlitz;                      //        no. of wires
            public float  m_ar;                         //        crack design area
            public float  m_dz;                         //        diameter of tendon
            public float  m_uz;                         //        perimeter
            public fixed float  m_valm[4];              //        reserved
            public fixed int m_text[17];                //        Designation
      } // cs_tendon

      public unsafe struct cs_tendjack                  //        44/NR:1  Tendon jacking data
      {
            public int  m_id0;                          //        identifier 1
            public int  m_id1;                          //        reserved (value = 0)
            public int  m_id2;                          //        reserved (value = 0)
            public int  m_id3;                          //        reserved (value = 0)
            public fixed float  m_zvstrg[16];           //        geometry data
            public fixed float  m_zvfak[24];            //        stresses and stressing factors
            public fixed float  m_zvvor[12];            //        direct input of prestress
            public fixed float  m_zvfree[12];           //        free prestress
            public fixed float  m_zvaend[8];            //        local geometry position
            public fixed float  m_zvreib[8];            //        additional friction data
            public fixed float  m_zvfgrz[32];           //        limit values of prestress
            public fixed float  m_zvweg[16];            //        stressing deformation
            public fixed int m_text[17];                //        Designation
      } // cs_tendjack

      public unsafe struct cs_tendfact                  //        44/NR:2  Tendon jacking factors
      {
            public int  m_id0;                          //        identifier 2
            public int  m_igbit;                        //        station parameter see 40/1
            public int  m_id2;                          //        reserved (value = 0)
            public int  m_id3;                          //        reserved (value = 0)
            public float  m_s;                          // [1001] station
            public float  m_fak;                        //        active stressing factors
            public fixed float  m_zwfak[12];            //        additional factor data
      } // cs_tendfact

      public unsafe struct cs_hist_hed                  //        80/LC:-10?  TimeHistoryTitle
      {
            public float  m_rid;                        //        Identifier of history type
            public fixed int m_title[33];               //        Designation
      } // cs_hist_hed

      public unsafe struct cs_hist_par                  //        80/LC:-9??  IterationParameters
      {
            public float  m_rid;                        //        identifier
            public float  m_val;                        //        current value
            public float  m_min;                        //        minimum allowed value
            public float  m_max;                        //        maximum allowed value
            public fixed int m_name[17];                //        name of parameter
      } // cs_hist_par

      public unsafe struct cs_hist_item                 //        History element
      {
            public int  m_nr;
            public int  m_typ;
      } // cs_hist_item

      public unsafe struct cs_hist                      //        80/LC:-  Identification of history elements
      {
            public float  m_rid;                        //        Identification -100 < RID < 0.
            public cs_hist_item  m_item;                //        History element
      } // cs_hist

      public unsafe struct cs_hist_val                  //        80/LC:+  Transient data
      {
            public float  m_tt;                         //        Time/frequency
            public fixed float  m_vb[32];               //        curve values
      } // cs_hist_val

      public unsafe struct cs_base_sum                  //        87/LC  Base shear values
      {
            public int  m_nr;                           //        mode-number
            public float  m_px;                         // [1151] nodal support X
            public float  m_py;                         // [1151] nodal support Y
            public float  m_pz;                         // [1151] nodal support Z
            public float  m_mx;                         // [1152] support moment X
            public float  m_my;                         // [1152] support moment Y
            public float  m_mz;                         // [1152] support moment Z
            public float  m_lsaf;                       // [  98] modal acceleration
            public float  m_h;                          // [1001] height of base shear
      } // cs_base_sum

      public unsafe struct cs_beam                      //        100/00:+  Beams
      {
            public int  m_nr;                           //        beam number
            public fixed int  m_node[2];                //        node number start/end
            public int  m_np;                           //        prop number
            public float  m_dl;                         // [1001] beamlength
            public fixed float  m_t[3*3];               //        transformation matrix
            public fixed float  m_ex[2*3];              // [1001] 
            public int  m_nref;                         //        reference axis
            public fixed float  m_spar[2];              //        distances along a continuous beam or
            public float  m_bety;
            public float  m_betz;
            public float  m_ldfy;
            public float  m_ldfz;                       //        deformation length factor for vz
      } // cs_beam

      public unsafe struct cs_bsct                      //        140/00:+  External sections
      {
            public int  m_nr;                           //        beam number
            public fixed int  m_node[2];                //        node number start/end
            public int  m_np;                           //        prop number
            public float  m_dl;                         // [1001] beamlength
            public fixed float  m_t[3*3];               //        transformation matrix
            public fixed float  m_ex[2*3];              // [1001] 
            public int  m_nref;                         //        reference axis
            public fixed float  m_spar[2];              //        distances along a continuous beam or
            public float  m_bety;
            public float  m_betz;
            public float  m_ldfy;
            public float  m_ldfz;                       //        deformation length factor for vz
      } // cs_bsct

      public unsafe struct cs_beam_sct                  //        100/00:0  Beams sections
      {
            public int  m_id;                           //        identifier for sections 0
            public int  m_nq;                           //        number cross section
            public int  m_ityp;                         //        Bitcodes
            public int  m_itp2;                         //        Connection / Hinges for x=0,x=dl
            public float  m_x;                          // [1001] sectional abscissa
      } // cs_beam_sct

      public unsafe struct cs_bsct_sct                  //        140/00:0  External sections
      {
            public int  m_id;                           //        identifier for sections 0
            public int  m_nq;                           //        number cross section
            public int  m_ityp;                         //        Bitcode I   (identical to 100/0:0)
            public int  m_itp2;                         //        Bitcode II  (identical to 100/0:0)
            public float  m_x;                          // [1001] sectional abscissa
            public fixed float  m_t[4*3];               //        transformation matrix
            public float  m_ymin;                       // [1001] Box of active elements in cut plane
            public float  m_zmin;                       // [1001] Box of active elements in cut plane
            public float  m_ymax;                       // [1001] Box of active elements in cut plane
            public float  m_zmax;                       // [1001] Box of active elements in cut plane
            public float  m_xmin;                       // [1001] Box of active elements in cut plane
            public float  m_xmax;                       // [1001] Box of active elements in cut plane
            public float  m_yminsel;                    // [1001] Max user defined size of Box
            public float  m_zminsel;                    // [1001] Max user defined size of Box
            public float  m_ymaxsel;                    // [1001] Max user defined size of Box
            public float  m_zmaxsel;                    // [1001] Max user defined size of Box
            public float  m_ysc;                        // [1001] Coordinate y of shear centre
            public float  m_zsc;                        // [1001] Coordinate z of shear centre
      } // cs_bsct_sct

      public unsafe struct cs_beam_tra                  //        100/01  transformation matrix
      {
            public int  m_nr;                           //        beamnumber
            public float  m_dl;                         // [1001] beamlength
            public fixed float  m_t[3*3];               //        transformation matrix
      } // cs_beam_tra

      public unsafe struct cs_beam_trs                  //        100/03  Info about dynamic moving beams (TREX)
      {
            public int  m_lf;                           //        Loadcase number containing the train
            public int  m_nr;                           //        Number of Beam
            public int  m_bpat;                         //        Options for BEAM (see TREX in SOFILOAD)
            public fixed int  m_noda[4];                //        Node Numbers for Start of beam element
            public fixed int  m_node[4];                //        Node Numbers for end of beam element
            public fixed float  m_xn[2];                // [1001] x-values of nodes along load train
      } // cs_beam_trs

      public unsafe struct cs_beam_tnd                  //        100/05  tendons of beams
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nrs;                          //        tendon number
            public int  m_mnr;                          //        material number of tendon + 1000 * material number of cross-sec
            public int  m_iba1;                         //        construction stage number for placing
            public int  m_iba2;                         //        construction stage number for grouting
            public int  m_iba3;                         //        construction stage number for removing
            public float  m_x;                          // [1011] x-ordinate
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_zz;                         // [1101] tensoning force
            public float  m_az;                         // [1020] tendon area
            public float  m_d;                          // [1023] diameter
            public float  m_uz;                         // [1023] effect. periphery
            public float  m_ny;                         //        inclination DY/DX
            public float  m_nz;                         //        inclination DZ/DX
            public float  m_yhr;                        // [1011] y-ordinate sheath
            public float  m_zhr;                        // [1011] z-ordinate sheath
            public float  m_ahr;                        // [1020] area of sheath
            public float  m_ar;                         // [1012] reference area
            public float  m_temp;                       // [1215] Temperature
            public float  m_redfak;                     //        Reduction factor within transmission length
            public float  m_xsi;                        //        Relative ordinate within total tendon
      } // cs_beam_tnd

      public unsafe struct cs_bsct_tnd                  //        140/05  tendons of external sections
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nrs;                          //        tendon number
            public int  m_mnr;                          //        material number of tendon + 1000 * material number of cross-sec
            public int  m_iba1;                         //        construction stage number for placing
            public int  m_iba2;                         //        construction stage number for grouting
            public int  m_iba3;                         //        construction stage number for removing
            public float  m_x;                          // [1011] x-ordinate
            public float  m_y;                          // [1011] y-ordinate
            public float  m_z;                          // [1011] z-ordinate
            public float  m_zz;                         // [1101] tensoning force
            public float  m_az;                         // [1020] tendon area
            public float  m_d;                          // [1023] diameter
            public float  m_uz;                         // [1023] effect. periphery
            public float  m_ny;                         //        inclination DY/DX
            public float  m_nz;                         //        inclination DZ/DX
            public float  m_yhr;                        // [1011] y-ordinate sheath
            public float  m_zhr;                        // [1011] z-ordinate sheath
            public float  m_ahr;                        // [1020] area of sheath
            public float  m_ar;                         // [1012] reference area
            public float  m_temp;                       // [1215] Temperature
            public float  m_redfak;                     //        Reduction factor within transmission length
            public float  m_xsi;                        //        Relative ordinate within total tendon
      } // cs_bsct_tnd

      public unsafe struct cs_beam_sl                   //        101/LC:*  single beam loads
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_x;                          // [1001] load point
            public float  m_i_2;                        // [1001] reserved 0.
            public float  m_pa;                         //        value of load
            public float  m_i_4;                        //        reserved 0.
            public float  m_ya;                         // [1001] eccentr. local y
            public float  m_za;                         // [1001] eccentr. local z
      } // cs_beam_sl

      public unsafe struct cs_beam_dl                   //        101/LC:*  distributed beam loading on reference
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_x;                          // [1001] start point
            public float  m_l;                          // [1001] length of load
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
            public float  m_ya;                         // [1001] eccentr. local y A
            public float  m_za;                         // [1001] eccentr. local z A
            public float  m_ye;                         // [1001] eccentr. local y E
            public float  m_ze;                         // [1001] eccentr. local z E
            public float  m_dya;                        //        gradient of eccentricity, local y, start
            public float  m_dza;                        //        gradient of eccentricity, local z, start
            public float  m_dye;                        //        gradient of eccentricity, local y, end
            public float  m_dze;                        //        gradient of eccentricity, local z, end
      } // cs_beam_dl

      public unsafe struct cs_beam_tl                   //        101/LC:*  distributed beam loading on reference
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_x;                          // [1001] start point
            public float  m_l;                          // [1001] length of load
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
            public float  m_ya;                         // [1001] eccentr. local y A
            public float  m_za;                         // [1001] eccentr. local z A
            public float  m_ye;                         // [1001] eccentr. local y E
            public float  m_ze;                         // [1001] eccentr. local z E
            public float  m_dya;                        //        gradient of eccentricity, local y, start
            public float  m_dza;                        //        gradient of eccentricity, local z, start
            public float  m_dye;                        //        gradient of eccentricity, local y, end
            public float  m_dze;                        //        gradient of eccentricity, local z, end
      } // cs_beam_tl

      public unsafe struct cs_beam_cl                   //        101/LC:*  cubic beamloads
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_x;                          // [1001] start point
            public float  m_l;                          // [1001] length of load
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
            public float  m_dpa;                        //        start derivative
            public float  m_dpe;                        //        end   derivative
      } // cs_beam_cl

      public unsafe struct cs_beam_wl                   //        101/LC:*  dynamic wind loads
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_fa;                         //        Factor cross start
            public float  m_fe;                         //        Factor cross end
            public float  m_ft;                         //        Factor frictional
            public float  m_vxa;                        // [1201] wind velocity
            public float  m_vya;                        // [1201] wind velocity
            public float  m_vza;                        // [1201] wind velocity
            public float  m_vxe;                        // [1201] wind velocity
            public float  m_vye;                        // [1201] wind velocity
            public float  m_vze;                        // [1201] wind velocity
            public float  m_vxam;                       // [1201] mean wind velocity
            public float  m_vyam;                       // [1201] mean wind velocity
            public float  m_vzam;                       // [1201] mean wind velocity
            public float  m_vxem;                       // [1201] mean wind velocity
            public float  m_vyem;                       // [1201] mean wind velocity
            public float  m_vzem;                       // [1201] mean wind velocity
      } // cs_beam_wl

      public unsafe struct cs_trus_wl                   //        151/LC:*  dynamic wind loads
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_fa;                         //        Factor cross start
            public float  m_fe;                         //        Factor cross end
            public float  m_ft;                         //        Factor frictional
            public float  m_vxa;                        // [1201] wind velocity
            public float  m_vya;                        // [1201] wind velocity
            public float  m_vza;                        // [1201] wind velocity
            public float  m_vxe;                        // [1201] wind velocity
            public float  m_vye;                        // [1201] wind velocity
            public float  m_vze;                        // [1201] wind velocity
            public float  m_vxam;                       // [1201] mean wind velocity
            public float  m_vyam;                       // [1201] mean wind velocity
            public float  m_vzam;                       // [1201] mean wind velocity
            public float  m_vxem;                       // [1201] mean wind velocity
            public float  m_vyem;                       // [1201] mean wind velocity
            public float  m_vzem;                       // [1201] mean wind velocity
      } // cs_trus_wl

      public unsafe struct cs_cabl_wl                   //        161/LC:*  dynamic wind loads
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of load
            public float  m_fa;                         //        Factor cross start
            public float  m_fe;                         //        Factor cross end
            public float  m_ft;                         //        Factor frictional
            public float  m_vxa;                        // [1201] wind velocity
            public float  m_vya;                        // [1201] wind velocity
            public float  m_vza;                        // [1201] wind velocity
            public float  m_vxe;                        // [1201] wind velocity
            public float  m_vye;                        // [1201] wind velocity
            public float  m_vze;                        // [1201] wind velocity
            public float  m_vxam;                       // [1201] mean wind velocity
            public float  m_vyam;                       // [1201] mean wind velocity
            public float  m_vzam;                       // [1201] mean wind velocity
            public float  m_vxem;                       // [1201] mean wind velocity
            public float  m_vyem;                       // [1201] mean wind velocity
            public float  m_vzem;                       // [1201] mean wind velocity
      } // cs_cabl_wl

      public unsafe struct cs_beam_foc                  //        102/LC:0  Maximum of Total Beam forces and deformations
      {
            public int  m_id;                           //        identifier 0
            public float  m_x;                          // [1001] max. beam length
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsionalmom.
            public float  m_ux;                         // [1003] diplacem. local x
            public float  m_uy;                         // [1003] diplacem. local y
            public float  m_uz;                         // [1003] diplacem. local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_beam_foc

      public unsafe struct cs_beam_ftc                  //        112/LC:0  Maximum of Beam forces without plate components
      {
            public int  m_id;                           //        identifier 0
            public float  m_x;                          // [1001] max. beam length
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsionalmom.
            public float  m_ux;                         // [1003] diplacem. local x
            public float  m_uy;                         // [1003] diplacem. local y
            public float  m_uz;                         // [1003] diplacem. local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_beam_ftc

      public unsafe struct cs_bsct_foc                  //        142/LC:0  Maximum of External sections forces
      {
            public int  m_id;                           //        identifier 0
            public float  m_x;                          // [1001] max. beam length
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsionalmom.
            public float  m_ux;                         // [1003] diplacem. local x
            public float  m_uy;                         // [1003] diplacem. local y
            public float  m_uz;                         // [1003] diplacem. local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_bsct_foc

      public unsafe struct cs_beam_for                  //        102/LC:+  Total Beam forces and deformations
      {
            public int  m_nr;                           //        beamnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsional moment
            public float  m_ux;                         // [1003] diplacement local x
            public float  m_uy;                         // [1003] diplacement local y
            public float  m_uz;                         // [1003] diplacement local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_beam_for

      public unsafe struct cs_beam_ftr                  //        112/LC:+  Beam forces without plate components
      {
            public int  m_nr;                           //        beamnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsional moment
            public float  m_ux;                         // [1003] diplacement local x
            public float  m_uy;                         // [1003] diplacement local y
            public float  m_uz;                         // [1003] diplacement local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_beam_ftr

      public unsafe struct cs_bsct_for                  //        142/LC:+  External sections forces
      {
            public int  m_nr;                           //        beamnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsional moment
            public float  m_ux;                         // [1003] diplacement local x
            public float  m_uy;                         // [1003] diplacement local y
            public float  m_uz;                         // [1003] diplacement local z
            public float  m_phix;                       // [1004] rotation local x
            public float  m_phiy;                       // [1004] rotation local y
            public float  m_phiz;                       // [1004] rotation local z
            public float  m_phiw;                       // [1005] twisting
            public float  m_mt3;                        // [1103] 3rd torsionalmom
            public float  m_pa;                         // [1095] axial bedding
            public float  m_pt;                         // [1095] transverse bedding
            public float  m_pty;                        // [1095] local y component of transverse bedding
            public float  m_ptz;                        // [1095] local z component of transverse bedding
      } // cs_bsct_for

      public unsafe struct cs_beam_fox                  //        102/0  Total External Beam forces
      {
            public int  m_nq;                           //        section number
            public int  m_nr;                           //        beamnumber
            public float  m_x;                          // [1001] abscissa
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsion.moment
      } // cs_beam_fox

      public unsafe struct cs_bsct_fox                  //        142/0  Total External Beam forces
      {
            public int  m_nq;                           //        section number
            public int  m_nr;                           //        beamnumber
            public float  m_x;                          // [1001] abscissa
            public float  m_n;                          // [1101] normal force
            public float  m_vy;                         // [1102] y-shear force
            public float  m_vz;                         // [1102] z-shear force
            public float  m_mt;                         // [1103] torsional moment
            public float  m_my;                         // [1104] bending moment My
            public float  m_mz;                         // [1104] bending moment Mz
            public float  m_mb;                         // [1105] warping moment Mb
            public float  m_mt2;                        // [1103] 2nd torsion.moment
      } // cs_bsct_fox

      public unsafe struct cs_beam_sti                  //        103/LC  Stiffness of beams
      {
            public int  m_nr;                           //        beam number
            public float  m_x;                          // [1001] distance from start
            public float  m_ea;                         // [  62] normal stiffness
            public float  m_gay;                        // [  62] y-shear stiffness
            public float  m_gaz;                        // [  62] z-shear stiffness
            public float  m_git;                        // [  83] torsional stiffness
            public float  m_eiy;                        // [  83] bending stiffness y
            public float  m_eiz;                        // [  83] bending stiffness z
            public float  m_eiyz;                       // [  83] bending stiffness yz
            public float  m_gayz;                       // [  62] yz-shear stiffness
            public float  m_kpx;                        // [   8] plastic strain x
            public float  m_kpy;                        // [  17] plastic curvature y
            public float  m_kpz;                        // [  17] plastic curvature z
            public float  m_emin;                       // [1081] minimum strain
            public float  m_emax;                       // [1081] maximum strain
            public float  m_ge1;                        // [1101] Residual of current step (Crisfield)
            public float  m_ge2;                        // [1104] Residual of current step (Crisfield)
            public float  m_ge3;                        // [1104] Residual of current step (Crisfield)
            public float  m_ea0;                        // [  83] lin. stiffness EA
            public float  m_eiy0;                       // [  83] lin. stiffness EIy
            public float  m_eiz0;                       // [  83] lin. stiffness EIz
            public float  m_dysm;                       // [1011] ordinate shear centre to gravity centre
            public float  m_dzsm;                       // [1011] ordinate shear centre to gravity centre
            public float  m_pre;                        // [1101] primary axial force
            public float  m_ys;                         // [1001] y-eccentricity of centre of gravity
            public float  m_zs;                         // [1001] z-eccentricity of centre of gravity
            public float  m_ecm;                        //        warping stiffness
            public float  m_gcms;                       //        secondary torsion
            public float  m_ni;                         // [1101] inner normal force
            public float  m_vyi;                        // [1102] inner y-shear force
            public float  m_vzi;                        // [1102] inner z-shear force
            public float  m_mti;                        // [1103] inner torsional moment
            public float  m_myi;                        // [1104] inner bending moment My
            public float  m_mzi;                        // [1104] inner bending moment Mz
            public float  m_mbi;                        // [1105] inner warping moment Mb
            public float  m_e0;                         // [1081] total strain x
            public float  m_gkpy;                       // [  17] total curvature y
            public float  m_gkpz;                       // [  17] total curvature z
            public float  m_kfvy;                       //        plastic factor V-y
            public float  m_kfvz;                       //        plastic factor V-z
            public float  m_kfmt;                       //        plastic factor M-t
            public fixed float  m_de_0[7];              //        Crisfield increments of current step di
            public fixed float  m_de_1[7];              //        Crisfield increments of last step di-1
            public float  m_i_54;                       //        unused
            public float  m_erf_min;                    // [1081] minimum strain reinf.
            public float  m_erf_max;                    // [1081] maximum strain reinf.
            public float  m_hc;                         // [   8] relative compressive zone height
            public float  m_ccw;                        // [1026] current crack opening
            public fixed float  m_i_59[11];             //        unused
      } // cs_beam_sti

      public unsafe struct cs_bsct_sti                  //        143/LC  Stiffness of beams
      {
            public int  m_nr;                           //        beam number
            public float  m_x;                          // [1001] distance from start
            public float  m_ea;                         // [  62] normal stiffness
            public float  m_gay;                        // [  62] y-shear stiffness
            public float  m_gaz;                        // [  62] z-shear stiffness
            public float  m_git;                        // [  83] torsional stiffness
            public float  m_eiy;                        // [  83] bending stiffness y
            public float  m_eiz;                        // [  83] bending stiffness z
            public float  m_eiyz;                       // [  83] bending stiffness yz
            public float  m_gayz;                       // [  62] yz-shear stiffness
            public float  m_kpx;                        // [   8] plastic strain x
            public float  m_kpy;                        // [  17] plastic curvature y
            public float  m_kpz;                        // [  17] plastic curvature z
            public float  m_emin;                       // [1081] minimum strain
            public float  m_emax;                       // [1081] maximum strain
            public float  m_ge1;                        // [1101] Residual of current step (Crisfield)
            public float  m_ge2;                        // [1104] Residual of current step (Crisfield)
            public float  m_ge3;                        // [1104] Residual of current step (Crisfield)
            public float  m_ea0;                        // [  83] lin. stiffness EA
            public float  m_eiy0;                       // [  83] lin. stiffness EIy
            public float  m_eiz0;                       // [  83] lin. stiffness EIz
            public float  m_dysm;                       // [1011] ordinate shear centre to gravity centre
            public float  m_dzsm;                       // [1011] ordinate shear centre to gravity centre
            public float  m_pre;                        // [1101] primary axial force
            public float  m_ys;                         // [1001] y-eccentricity of centre of gravity
            public float  m_zs;                         // [1001] z-eccentricity of centre of gravity
            public float  m_ecm;                        //        warping stiffness
            public float  m_gcms;                       //        secondary torsion
            public float  m_ni;                         // [1101] inner normal force
            public float  m_vyi;                        // [1102] inner y-shear force
            public float  m_vzi;                        // [1102] inner z-shear force
            public float  m_mti;                        // [1103] inner torsional moment
            public float  m_myi;                        // [1104] inner bending moment My
            public float  m_mzi;                        // [1104] inner bending moment Mz
            public float  m_mbi;                        // [1105] inner warping moment Mb
            public float  m_e0;                         // [1081] total strain x
            public float  m_gkpy;                       // [  17] total curvature y
            public float  m_gkpz;                       // [  17] total curvature z
            public float  m_kfvy;                       //        plastic factor V-y
            public float  m_kfvz;                       //        plastic factor V-z
            public float  m_kfmt;                       //        plastic factor M-t
            public fixed float  m_de_0[7];              //        Crisfield increments of current step di
            public fixed float  m_de_1[7];              //        Crisfield increments of last step di-1
            public float  m_i_54;                       //        unused
            public float  m_erf_min;                    // [1081] minimum strain reinf.
            public float  m_erf_max;                    // [1081] maximum strain reinf.
            public float  m_hc;                         // [   8] relative compressive zone height
            public float  m_ccw;                        // [1026] current crack opening
            public fixed float  m_i_59[11];             //        unused
      } // cs_bsct_sti

      public unsafe struct cs_beam_crc                  //        104/LC:0  Parameter of creep interval for each material
      {
            public int  m_id;                           //        identifier 0
            public int  m_mnr;                          //        materialnumber
            public float  m_i_0;
            public float  m_t;                          // [  93] absolute age
            public float  m_phi;                        //        creep coefficient
            public float  m_eps;                        //        shrinkage
            public float  m_rh;                         // [   8] relative moisture
            public float  m_temp;                       // [   6] temperature
            public float  m_twa;                        // [  93] effective age start
            public float  m_twe;                        // [  93] effective age end
            public float  m_beth;                       //        creep coefficient beta-h
            public float  m_ts;                         // [  93] start date of drying
      } // cs_beam_crc

      public unsafe struct cs_bsct_crc                  //        144/LC:0  Parameter of creep interval for each material
      {
            public int  m_id;                           //        identifier 0
            public int  m_mnr;                          //        materialnumber
            public float  m_i_0;
            public float  m_t;                          // [  93] absolute age
            public float  m_phi;                        //        creep coefficient
            public float  m_eps;                        //        shrinkage
            public float  m_rh;                         // [   8] relative moisture
            public float  m_temp;                       // [   6] temperature
            public float  m_twa;                        // [  93] effective age start
            public float  m_twe;                        // [  93] effective age end
            public float  m_beth;                       //        creep coefficient beta-h
            public float  m_ts;                         // [  93] start date of drying
      } // cs_bsct_crc

      public unsafe struct cs_beam_crf                  //        104/LC:+  resulting forces of redistribution
      {
            public int  m_nr;                           //        beamnumber
            public int  m_id;                           //        identifier 0
            public float  m_x;                          // [1001] distance from start
            public float  m_sdni;                       // [1101] total normal force
            public float  m_sdvy;                       // [1102] total y-shear force
            public float  m_sdvz;                       // [1102] total z-shear force
            public float  m_sdmt;                       // [1103] total torsion moment
            public float  m_sdmy;                       // [1104] total bending moment
            public float  m_sdmz;                       // [1104] total bending moment
            public float  m_srni;                       // [1101] relat. normal force
            public float  m_srvy;                       // [1102] relat. y-shear force
            public float  m_srvz;                       // [1102] relat. y-shear force
            public float  m_srmt;                       // [1103] relat. torsionmoment
            public float  m_srmy;                       // [1104] relat. bendingmoment
            public float  m_srmz;                       // [1104] relat. bendingmoment
      } // cs_beam_crf

      public unsafe struct cs_bsct_crf                  //        144/LC:+  resulting forces of redistribution
      {
            public int  m_nr;                           //        beamnumber
            public int  m_id;                           //        identifier 0
            public float  m_x;                          // [1001] distance from start
            public float  m_sdni;                       // [1101] total normal force
            public float  m_sdvy;                       // [1102] total y-shear force
            public float  m_sdvz;                       // [1102] total z-shear force
            public float  m_sdmt;                       // [1103] total torsion moment
            public float  m_sdmy;                       // [1104] total bending moment
            public float  m_sdmz;                       // [1104] total bending moment
            public float  m_srni;                       // [1101] relat. normal force
            public float  m_srvy;                       // [1102] relat. y-shear force
            public float  m_srvz;                       // [1102] relat. y-shear force
            public float  m_srmt;                       // [1103] relat. torsionmoment
            public float  m_srmy;                       // [1104] relat. bendingmoment
            public float  m_srmz;                       // [1104] relat. bendingmoment
      } // cs_bsct_crf

      public unsafe struct cs_beam_crp                  //        104/LC:+  forces on sectional parts per material
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_dni;                        // [1101] impr. normal force
            public float  m_dmyi;                       // [1104] impr. bending moment
            public float  m_dmzi;                       // [1104] impr. bending moment
            public float  m_ni;                         // [1101] total normal force
            public float  m_myi;                        // [1104] total bending moment
            public float  m_mzi;                        // [1104] total bending moment
            public float  m_sdni;                       // [1192] stress plane parameter from (DNI:DMZI)
            public float  m_sdmyi;                      // [1193] stress plane parameter from (DNI:DMZI)
            public float  m_sdmzi;                      // [1193] stress plane parameter from (DNI:DMZI)
            public float  m_sni;                        // [1192] stress plane parameter from (NI:MZI)
            public float  m_smyi;                       // [1193] stress plane parameter from (NI:MZI)
            public float  m_smzi;                       // [1193] stress plane parameter from (NI:MZI)
      } // cs_beam_crp

      public unsafe struct cs_bsct_crp                  //        144/LC:+  forces on sectional parts per material
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_dni;                        // [1101] impr. normal force
            public float  m_dmyi;                       // [1104] impr. bending moment
            public float  m_dmzi;                       // [1104] impr. bending moment
            public float  m_ni;                         // [1101] total normal force
            public float  m_myi;                        // [1104] total bending moment
            public float  m_mzi;                        // [1104] total bending moment
            public float  m_sdni;                       // [1192] stress plane parameter from (DNI:DMZI)
            public float  m_sdmyi;                      // [1193] stress plane parameter from (DNI:DMZI)
            public float  m_sdmzi;                      // [1193] stress plane parameter from (DNI:DMZI)
            public float  m_sni;                        // [1192] stress plane parameter from (NI:MZI)
            public float  m_smyi;                       // [1193] stress plane parameter from (NI:MZI)
            public float  m_smzi;                       // [1193] stress plane parameter from (NI:MZI)
      } // cs_bsct_crp

      public unsafe struct cs_beam_crt                  //        104/LC:+  changes of tensional force
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nrs;                          //        neg. tendonnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_dzz;                        // [1092] change of stress to prestress
            public float  m_dzr;                        // [1092] rel. change of stress to concrete strain
            public float  m_dz;                         // [1091] rel. change of force from mean strain
            public fixed float  m_dzfak[5];             //        ordinates, inclinations to evaluate forces
      } // cs_beam_crt

      public unsafe struct cs_bsct_crt                  //        144/LC:+  changes of tensional force
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nrs;                          //        neg. tendonnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_dzz;                        // [1092] change of stress to prestress
            public float  m_dzr;                        // [1092] rel. change of stress to concrete strain
            public float  m_dz;                         // [1091] rel. change of force from mean strain
            public fixed float  m_dzfak[5];             //        ordinates, inclinations to evaluate forces
      } // cs_bsct_crt

      public unsafe struct cs_beam_stc                  //        105/LC:0  Maximum stresses in cross-section of beams
      {
            public int  m_nr;                           //        Ident 0
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance to start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigv;                       // [1092] reference stress
            public float  m_si;                         // [1092] main tension stress
            public float  m_sii;                        // [1092] main compress stress
            public float  m_sigo;                       // [1092] uniaxial comp stress
            public float  m_sigu;                       // [1092] uniaxial tens stress
            public float  m_dsig;                       // [1092] sway of normal stress
            public float  m_dtau;                       // [1092] sway of shear stress
            public float  m_sigw;                       // [1092] stress in weldings
            public float  m_vb;                         // [1153] Bond force
            public float  m_buck;                       //        buckling intensity
            public float  m_i_14;                       //        reserved
            public float  m_sigct;                      //        decompression stress
      } // cs_beam_stc

      public unsafe struct cs_bsct_stc                  //        145/LC:0  Maximum stresses in cross-section of beams
      {
            public int  m_nr;                           //        Ident 0
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance to start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigv;                       // [1092] reference stress
            public float  m_si;                         // [1092] main tension stress
            public float  m_sii;                        // [1092] main compress stress
            public float  m_sigo;                       // [1092] uniaxial comp stress
            public float  m_sigu;                       // [1092] uniaxial tens stress
            public float  m_dsig;                       // [1092] sway of normal stress
            public float  m_dtau;                       // [1092] sway of shear stress
            public float  m_sigw;                       // [1092] stress in weldings
            public float  m_vb;                         // [1153] Bond force
            public float  m_buck;                       //        buckling intensity
            public float  m_i_14;                       //        reserved
            public float  m_sigct;                      //        decompression stress
      } // cs_bsct_stc

      public unsafe struct cs_beam_sts                  //        105/LC:+  Stresses in reinforcements of beams
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        neg. materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] stress in shear links
            public float  m_sds;                        // [1092] longitudinal stress sway for reinforcements
            public float  m_sdl;                        // [1092] stress sway for shear links reinforcements
            public float  m_sii;                        // [1092] reserved
      } // cs_beam_sts

      public unsafe struct cs_bsct_sts                  //        145/LC:+  Stresses in reinforcements of beams
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        neg. materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] stress in shear links
            public float  m_sds;                        // [1092] longitudinal stress sway for reinforcements
            public float  m_sdl;                        // [1092] stress sway for shear links reinforcements
            public float  m_sii;                        // [1092] reserved
      } // cs_bsct_sts

      public unsafe struct cs_beam_str                  //        105/LC:+  Stresses in cross-section of beams
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigv;                       // [1092] reference stress
            public float  m_si;                         // [1092] main tension stress
            public float  m_sii;                        // [1092] main compress stress
            public float  m_sigo;                       // [1092] uniaxial stress up
            public float  m_sigu;                       // [1092] uniaxial stress down
            public float  m_dsig;                       // [1092] sway of normal stress
            public float  m_dtau;                       // [1092] sway of shear stress
            public float  m_sigw;                       // [1092] stress in weldings
            public float  m_vb;                         // [1153] Bond force
            public float  m_buck;                       //        buckling effects
            public float  m_i_14;                       //        reserved
            public float  m_sigct;                      //        decompression stress
            public float  m_rctrl;                      //        control value of stress/strain description
            public float  m_es0;                        //        strain in center of total section
            public float  m_esy;                        //        strain gradient in y-direction
            public float  m_esz;                        //        strain gradient in z-direction
            public float  m_yc;                         // [1011] location of center of partial section
            public float  m_zc;                         // [1011] location of center of partial section
            public float  m_esw;                        //        factor for unit warping
            public float  m_vyf;                        // [1102] shear force
            public float  m_vzf;                        // [1102] shear force
            public float  m_mtf;                        // [1103] primary torsional moment
            public float  m_mt2f;                       // [1103] secondary torsional moment
      } // cs_beam_str

      public unsafe struct cs_bsct_str                  //        145/LC:+  Stresses in cross-section of beams
      {
            public int  m_nr;                           //        beamnumber
            public int  m_mnr;                          //        materialnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_sigc;                       // [1092] compressive stress
            public float  m_sigt;                       // [1092] tensile stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigv;                       // [1092] reference stress
            public float  m_si;                         // [1092] main tension stress
            public float  m_sii;                        // [1092] main compress stress
            public float  m_sigo;                       // [1092] uniaxial stress up
            public float  m_sigu;                       // [1092] uniaxial stress down
            public float  m_dsig;                       // [1092] sway of normal stress
            public float  m_dtau;                       // [1092] sway of shear stress
            public float  m_sigw;                       // [1092] stress in weldings
            public float  m_vb;                         // [1153] Bond force
            public float  m_buck;                       //        buckling effects
            public float  m_i_14;                       //        reserved
            public float  m_sigct;                      //        decompression stress
            public float  m_rctrl;                      //        control value of stress/strain description
            public float  m_es0;                        //        strain in center of total section
            public float  m_esy;                        //        strain gradient in y-direction
            public float  m_esz;                        //        strain gradient in z-direction
            public float  m_yc;                         // [1011] location of center of partial section
            public float  m_zc;                         // [1011] location of center of partial section
            public float  m_esw;                        //        factor for unit warping
            public float  m_vyf;                        // [1102] shear force
            public float  m_vzf;                        // [1102] shear force
            public float  m_mtf;                        // [1103] primary torsional moment
            public float  m_mt2f;                       // [1103] secondary torsional moment
      } // cs_bsct_str

      public unsafe struct cs_beam_rf0                  //        106/DC:0  max. values of reinforcement
      {
            public int  m_nr;                           //        identifier 0
            public int  m_nvers;                        //        Version number
            public float  m_aslmax;                     // [1021] maximum longitudinal reinforcement
            public float  m_asbmax;                     // [1021] maximum of shear link reinforcement
            public float  m_vmmax;                      // [1001] maximum of shift rule offset
            public fixed float  m_reserved[12];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_beam_rf0

      public unsafe struct cs_bsct_rf0                  //        146/DC:0  max. values of reinforcement
      {
            public int  m_nr;                           //        identifier 0
            public int  m_nvers;                        //        Version number
            public float  m_aslmax;                     // [1021] maximum longitudinal reinforcement
            public float  m_asbmax;                     // [1021] maximum of shear link reinforcement
            public float  m_vmmax;                      // [1001] maximum of shift rule offset
            public fixed float  m_reserved[12];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_bsct_rf0

      public unsafe struct cs_trus_rf0                  //        156/DC:0  max. values of reinforcement
      {
            public int  m_nr;                           //        identifier 0
            public int  m_nvers;                        //        Version number
            public float  m_aslmax;                     // [1021] maximum longitudinal reinforcement
            public float  m_asbmax;                     // [1021] maximum of shear link reinforcement
            public float  m_vmmax;                      // [1001] maximum of shift rule offset
            public fixed float  m_reserved[12];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_trus_rf0

      public unsafe struct cs_cabl_rf0                  //        166/DC:0  max. values of reinforcement
      {
            public int  m_nr;                           //        identifier 0
            public int  m_nvers;                        //        Version number
            public float  m_aslmax;                     // [1021] maximum longitudinal reinforcement
            public float  m_asbmax;                     // [1021] maximum of shear link reinforcement
            public float  m_vmmax;                      // [1001] maximum of shift rule offset
            public fixed float  m_reserved[12];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_cabl_rf0

      public unsafe struct cs_beam_rfi                  //        106/DC:+  info of reinforcement of beam
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        info id = 0
            public float  m_x;                          // [1001] distance from start
            public fixed int  m_asl[10*2];              //        infos for longitudinal layers 0:9
            public fixed int  m_asv[15*2];              //        infos for shear link   layers 1:15
      } // cs_beam_rfi

      public unsafe struct cs_bsct_rfi                  //        146/DC:+  info of reinforcement of external section
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        info id = 0
            public float  m_x;                          // [1001] distance from start
            public fixed int  m_asl[10*2];              //        infos for longitudinal layers 0:9
            public fixed int  m_asv[15*2];              //        infos for shear link   layers 1:15
      } // cs_bsct_rfi

      public unsafe struct cs_trus_rfi                  //        156/DC:+  info of reinforcement of truss
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        info id = 0
            public float  m_x;                          // [1001] distance from start
            public fixed int  m_asl[10*2];              //        infos for longitudinal layers 0:9
            public fixed int  m_asv[15*2];              //        infos for shear link   layers 1:15
      } // cs_trus_rfi

      public unsafe struct cs_cabl_rfi                  //        166/DC:+  info of reinforcement of cables
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        info id = 0
            public float  m_x;                          // [1001] distance from start
            public fixed int  m_asl[10*2];              //        infos for longitudinal layers 0:9
            public fixed int  m_asv[15*2];              //        infos for shear link   layers 1:15
      } // cs_cabl_rfi

      public unsafe struct cs_beam_rfc                  //        106/DC:+  reinforcement of beam
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        section number
            public float  m_x;                          // [1001] distance from start
            public float  m_asum;                       // [1020] Total longitudinal reinforcement
            public float  m_ator;                       // [1021] maximum of torsional reinforcement
            public fixed float  m_asl[10];              // [1020] Area of layer 0:9
            public float  m_vm;                         // [1001] shift rule offset
            public float  m_asbmax;                     // [1021] maximum of all shear link areas
            public fixed float  m_asb[15*2];            // [1021] shear links
      } // cs_beam_rfc

      public unsafe struct cs_bsct_rfc                  //        146/DC:+  reinforcement of external section
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        section number
            public float  m_x;                          // [1001] distance from start
            public float  m_asum;                       // [1020] Total longitudinal reinforcement
            public float  m_ator;                       // [1021] maximum of torsional reinforcement
            public fixed float  m_asl[10];              // [1020] Area of layer 0:9
            public float  m_vm;                         // [1001] shift rule offset
            public float  m_asbmax;                     // [1021] maximum of all shear link areas
            public fixed float  m_asb[15*2];            // [1021] shear links
      } // cs_bsct_rfc

      public unsafe struct cs_trus_rfc                  //        156/DC:+  reinforcement of truss
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        section number
            public float  m_x;                          // [1001] distance from start
            public float  m_asum;                       // [1020] Total longitudinal reinforcement
            public float  m_ator;                       // [1021] maximum of torsional reinforcement
            public fixed float  m_asl[10];              // [1020] Area of layer 0:9
            public float  m_vm;                         // [1001] shift rule offset
            public float  m_asbmax;                     // [1021] maximum of all shear link areas
            public fixed float  m_asb[15*2];            // [1021] shear links
      } // cs_trus_rfc

      public unsafe struct cs_cabl_rfc                  //        166/DC:+  reinforcement of cables
      {
            public int  m_nr;                           //        beamnumber
            public int  m_nq;                           //        section number
            public float  m_x;                          // [1001] distance from start
            public float  m_asum;                       // [1020] Total longitudinal reinforcement
            public float  m_ator;                       // [1021] maximum of torsional reinforcement
            public fixed float  m_asl[10];              // [1020] Area of layer 0:9
            public float  m_vm;                         // [1001] shift rule offset
            public float  m_asbmax;                     // [1021] maximum of all shear link areas
            public fixed float  m_asb[15*2];            // [1021] shear links
      } // cs_cabl_rfc

      public unsafe struct cs_beam_des                  //        107/LC  Ultimate/Plastic Design results
      {
            public int  m_nr;                           //        elementnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_ni;                         // [1101] Inner normal force
            public float  m_myi;                        // [1104] bending moment My
            public float  m_mzi;                        // [1104] bending moment My
            public float  m_scf;                        //        relative capacity
            public float  m_e0;                         // [   9] strain at center
            public float  m_ey;                         // [1009] curvature y direct.
            public float  m_ez;                         // [1009] curvature z direct.
            public float  m_e1;                         // [   9] compressive strain
            public float  m_e2;                         // [   9] tensional   strain
            public float  m_hl;                         // [1011] lever of forces
            public float  m_hvm;                        // [1001] shift rule value
            public float  m_hx;                         // [1001] height of compression zone   (NSTR-Analysis)
            public float  m_edcmin;                     // [   9] minimum decompression strain (NSTR-Analysis)
            public float  m_edcmax;                     // [   9] maximum decompression strain (NSTR-Analysis)
            public float  m_fchk;                       // [1092] not used
            public float  m_tcf;                        //        total utilisation level (all effects)
            public float  m_scn;                        //        utilisation level  (1) N/Npl
            public float  m_scvy;                       //        utilisation level  (2) Vy/Vypl
            public float  m_scvz;                       //        utilisation level  (3) Vz/Vzpl
            public float  m_scmt;                       //        utilisation level  (4) Mt/Mtpl
            public float  m_scmy;                       //        utilisation level  (5) My/Mypl
            public float  m_scmz;                       //        utilisation level  (6) Mz/Mzpl
            public float  m_scmb;                       //        utilisation level  (7) Mb/Mbpl
            public float  m_sct2;                       //        utilisation level  (8) Mt2/Mt2pl
            public float  m_sccomb;                     //        utilisation level  (9) TOTAL INTERACTION
            public float  m_scbn;                       //        utilisation level (10) buckling / torsional buckling
            public float  m_csigc;                      //        utilisation level (11) sig-c/fy
            public float  m_csigt;                      //        utilisation level (12) sig-t/fy
            public float  m_ctau;                       //        utilisation level (13) tau/tauy
            public float  m_csgv;                       //        utilisation level (14) sigv/fy (von Mises)
            public float  m_csgr;                       //        utilisation level (15) sig-s (tendon/reinforc.stress)
            public float  m_cas;                        //        utilisation level (16) As/As-provided (long.Reinforc)
            public float  m_casl;                       //        utilisation level (17) Asl/Asl-provided (shear links)
            public float  m_ccw;                        //        utilisation level (18) As/As-provided for crack width
            public float  m_csgd;                       //        utilisation level (19) sig-d (dynamic stress range)
            public float  m_ctau0;                      //        utilisation level (20) tau0  (Nachweisgrenzen)
            public float  m_c2t;                        //        utilisation level (21) plate slenderness (c/t)
            public float  m_class;                      //        highest criteria for section class
      } // cs_beam_des

      public unsafe struct cs_bsct_des                  //        147/LC  Ultimate/Plastic Design results
      {
            public int  m_nr;                           //        elementnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_ni;                         // [1101] Inner normal force
            public float  m_myi;                        // [1104] bending moment My
            public float  m_mzi;                        // [1104] bending moment My
            public float  m_scf;                        //        relative capacity
            public float  m_e0;                         // [   9] strain at center
            public float  m_ey;                         // [1009] curvature y direct.
            public float  m_ez;                         // [1009] curvature z direct.
            public float  m_e1;                         // [   9] compressive strain
            public float  m_e2;                         // [   9] tensional   strain
            public float  m_hl;                         // [1011] lever of forces
            public float  m_hvm;                        // [1001] shift rule value
            public float  m_hx;                         // [1001] height of compression zone   (NSTR-Analysis)
            public float  m_edcmin;                     // [   9] minimum decompression strain (NSTR-Analysis)
            public float  m_edcmax;                     // [   9] maximum decompression strain (NSTR-Analysis)
            public float  m_fchk;                       // [1092] not used
            public float  m_tcf;                        //        total utilisation level (all effects)
            public float  m_scn;                        //        utilisation level  (1) N/Npl
            public float  m_scvy;                       //        utilisation level  (2) Vy/Vypl
            public float  m_scvz;                       //        utilisation level  (3) Vz/Vzpl
            public float  m_scmt;                       //        utilisation level  (4) Mt/Mtpl
            public float  m_scmy;                       //        utilisation level  (5) My/Mypl
            public float  m_scmz;                       //        utilisation level  (6) Mz/Mzpl
            public float  m_scmb;                       //        utilisation level  (7) Mb/Mbpl
            public float  m_sct2;                       //        utilisation level  (8) Mt2/Mt2pl
            public float  m_sccomb;                     //        utilisation level  (9) TOTAL INTERACTION
            public float  m_scbn;                       //        utilisation level (10) buckling / torsional buckling
            public float  m_csigc;                      //        utilisation level (11) sig-c/fy
            public float  m_csigt;                      //        utilisation level (12) sig-t/fy
            public float  m_ctau;                       //        utilisation level (13) tau/tauy
            public float  m_csgv;                       //        utilisation level (14) sigv/fy (von Mises)
            public float  m_csgr;                       //        utilisation level (15) sig-s (tendon/reinforc.stress)
            public float  m_cas;                        //        utilisation level (16) As/As-provided (long.Reinforc)
            public float  m_casl;                       //        utilisation level (17) Asl/Asl-provided (shear links)
            public float  m_ccw;                        //        utilisation level (18) As/As-provided for crack width
            public float  m_csgd;                       //        utilisation level (19) sig-d (dynamic stress range)
            public float  m_ctau0;                      //        utilisation level (20) tau0  (Nachweisgrenzen)
            public float  m_c2t;                        //        utilisation level (21) plate slenderness (c/t)
            public float  m_class;                      //        highest criteria for section class
      } // cs_bsct_des

      public unsafe struct cs_trus_des                  //        157/LC  Ultimate/Plastic Design results
      {
            public int  m_nr;                           //        elementnumber
            public float  m_x;                          // [1001] distance from start
            public float  m_ni;                         // [1101] Inner normal force
            public float  m_myi;                        // [1104] bending moment My
            public float  m_mzi;                        // [1104] bending moment My
            public float  m_scf;                        //        relative capacity
            public float  m_e0;                         // [   9] strain at center
            public float  m_ey;                         // [1009] curvature y direct.
            public float  m_ez;                         // [1009] curvature z direct.
            public float  m_e1;                         // [   9] compressive strain
            public float  m_e2;                         // [   9] tensional   strain
            public float  m_hl;                         // [1011] lever of forces
            public float  m_hvm;                        // [1001] shift rule value
            public float  m_hx;                         // [1001] height of compression zone   (NSTR-Analysis)
            public float  m_edcmin;                     // [   9] minimum decompression strain (NSTR-Analysis)
            public float  m_edcmax;                     // [   9] maximum decompression strain (NSTR-Analysis)
            public float  m_fchk;                       // [1092] not used
            public float  m_tcf;                        //        total utilisation level (all effects)
            public float  m_scn;                        //        utilisation level  (1) N/Npl
            public float  m_scvy;                       //        utilisation level  (2) Vy/Vypl
            public float  m_scvz;                       //        utilisation level  (3) Vz/Vzpl
            public float  m_scmt;                       //        utilisation level  (4) Mt/Mtpl
            public float  m_scmy;                       //        utilisation level  (5) My/Mypl
            public float  m_scmz;                       //        utilisation level  (6) Mz/Mzpl
            public float  m_scmb;                       //        utilisation level  (7) Mb/Mbpl
            public float  m_sct2;                       //        utilisation level  (8) Mt2/Mt2pl
            public float  m_sccomb;                     //        utilisation level  (9) TOTAL INTERACTION
            public float  m_scbn;                       //        utilisation level (10) buckling / torsional buckling
            public float  m_csigc;                      //        utilisation level (11) sig-c/fy
            public float  m_csigt;                      //        utilisation level (12) sig-t/fy
            public float  m_ctau;                       //        utilisation level (13) tau/tauy
            public float  m_csgv;                       //        utilisation level (14) sigv/fy (von Mises)
            public float  m_csgr;                       //        utilisation level (15) sig-s (tendon/reinforc.stress)
            public float  m_cas;                        //        utilisation level (16) As/As-provided (long.Reinforc)
            public float  m_casl;                       //        utilisation level (17) Asl/Asl-provided (shear links)
            public float  m_ccw;                        //        utilisation level (18) As/As-provided for crack width
            public float  m_csgd;                       //        utilisation level (19) sig-d (dynamic stress range)
            public float  m_ctau0;                      //        utilisation level (20) tau0  (Nachweisgrenzen)
            public float  m_c2t;                        //        utilisation level (21) plate slenderness (c/t)
            public float  m_class;                      //        highest criteria for section class
      } // cs_trus_des

      public unsafe struct cs_beam_pif                  //        108/LC  reducing factors of stiffness
      {
            public int  m_nr;                           //        pilenumber
            public float  m_redp;                       //        reducing factor of stiffness
            public float  m_reda;                       //        reducing factor of axial bedding
            public float  m_redq;                       //        reducing factor of cross bedding
      } // cs_beam_pif

      public unsafe struct cs_beam_hr0                  //        111/LC:0  Maximum of Implicit Hinge Reactions
      {
            public int  m_id;                           //        identifier 0
            public int  m_typ;                          //        type of hinge
            public fixed int  m_ibit[2];                //        reserved
            public float  m_x;                          // [1001] max. beam length
            public float  m_reac;                       //        extremal reaction force/ moment
            public fixed float  m_stv[4];               //        extremal values of statevar's
      } // cs_beam_hr0

      public unsafe struct cs_beam_hrc                  //        111/LC:+  Implicit Hinge Reactions
      {
            public int  m_nr;                           //        beamnumber
            public int  m_typ;                          //        type of hinge
            public fixed int  m_ibit[2];                //        reserved
            public float  m_x;                          // [1001] hinge location, beam abscissa value
            public float  m_reac;                       //        reaction force/ moment
            public fixed float  m_stv[4];               //        statevar's
      } // cs_beam_hrc

      public unsafe struct cs_beam_mp0                  //        132/LC:0  Extremal values of cross-sectional material point reactions
      {
            public int  m_nr;                           //        identifier 0
            public int  m_type;                         //        type: reinforcement=1, base material point=0
            public int  m_mno;                          //        material number
            public int  m_mrf;                          //        material number reinforcement
            public int  m_npts;                         //        number of base material points
            public int  m_nrf;                          //        Anzahl Materialpunkte Bewehrung
            public float  m_x;                          // [1001] max. beam length
            public float  m_y;                          // [1011] max. y-ccordinate
            public float  m_z;                          // [1011] max. z-ccordinate
            public float  m_sigx;                       // [1092] axial normal stress
            public float  m_tauxy;                      // [1092] shear stress xy
            public float  m_tauxz;                      // [1092] shear stress xz
            public float  m_f0;                         //        utilization level
            public float  m_kapap;                      // [   9] equiv. plastic strain
            public float  m_kapad;                      // [   9] fracturing strain
            public float  m_ccw;                        // [1026] current crack opening
            public float  m_temp;                       // [   6] current temperature
            public float  m_tempmax;                    // [   6] maximum temperature in loading history
            public float  m_eps_s;                      // [   9] pure reinforcement strain (without TS strain correction)
            public float  m_eps_ts;                     // [   9] tension stiffening strain correction (accumulated)
            public float  m_dummy;                      //        unused
            public float  m_izone;                      //        performance interval
            public float  m_epst;                       // [   9] axial temperature strain
            public float  m_epsx;                       // [   9] axial total strain (without temperature strain)
            public float  m_a_mpt;                      // [1012] associated material point area
            public float  m_fc_temp;                    // [1092] current compressive strength (temperature dependent)
            public float  m_ft_temp;                    // [1092] current tensile strength (temperature dependent)
      } // cs_beam_mp0

      public unsafe struct cs_beam_mpt                  //        132/LC:+  Cross-sectional material point reactions
      {
            public int  m_nr;                           //        beam number
            public int  m_type;                         //        type: reinforcement=1, base material point=0
            public int  m_mno;                          //        material number
            public int  m_mrf;                          //        material number reinforcement
            public int  m_npts;                         //        number of base material points
            public int  m_nrf;                          //        Anzahl Materialpunkte Bewehrung
            public float  m_x;                          // [1001] beam abscissa value
            public float  m_y;                          // [1011] cross-sectional y-position
            public float  m_z;                          // [1011] cross-sectional z-position
            public float  m_sigx;                       // [1092] axial normal stress
            public float  m_tauxy;                      // [1092] shear stress xy
            public float  m_tauxz;                      // [1092] shear stress xz
            public float  m_f0;                         //        utilization level
            public float  m_kapap;                      // [   9] equiv. plastic strain
            public float  m_kapad;                      // [   9] fracturing strain
            public float  m_ccw;                        // [1026] current crack opening
            public float  m_temp;                       // [   6] current temperature
            public float  m_tempmax;                    // [   6] maximum temperature in loading history
            public float  m_eps_s;                      // [   9] pure reinforcement strain (without TS strain correction)
            public float  m_eps_ts;                     // [   9] tension stiffening strain correction (accumulated)
            public float  m_dummy;                      //        unused
            public float  m_izone;                      //        performance interval
            public float  m_epst;                       // [   9] axial temperature strain
            public float  m_epsx;                       // [   9] axial total strain (without temperature strain)
            public float  m_a_mpt;                      // [1012] associated material point area
            public float  m_fc_temp;                    // [1092] current compressive strength (temperature dependent)
            public float  m_ft_temp;                    // [1092] current tensile strength (temperature dependent)
      } // cs_beam_mpt

      public unsafe struct cs_trus                      //        150/00  trusselements
      {
            public int  m_nr;                           //        truss number
            public fixed int  m_node[2];                //        nodenumbers
            public int  m_nrq;                          //        cross-section number
            public fixed float  m_t[3];                 //        normal direction
            public float  m_dl;                         // [1001] length of truss
            public float  m_pre;                        // [1101] prestress
            public float  m_gap;                        // [1003] slip of element
            public float  m_riss;                       // [1101] max tension force
            public float  m_flie;                       // [1101] yielding load
            public int  m_nref;                         //        reference axis
      } // cs_trus

      public unsafe struct cs_trus_loa                  //        151/LC  Loads on truss elements
      {
            public int  m_nr;                           //        truss number
            public int  m_typ;                          //        type of load
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
      } // cs_trus_loa

      public unsafe struct cs_trus_re0                  //        152/LC:0  maximum of results of truss elements
      {
            public int  m_nr;                           //        identifier 0
            public float  m_n;                          // [1101] normal force
            public float  m_v;                          // [1003] axial displacement
      } // cs_trus_re0

      public unsafe struct cs_trus_res                  //        152/LC:+  results of truss elements
      {
            public int  m_nr;                           //        truss number
            public float  m_n;                          // [1101] normal force
            public float  m_v;                          // [1003] axial displacement
            public float  m_lex;                        //        nonlinear effect
            public fixed float  m_damm[6];              //        Damage Parameter
      } // cs_trus_res

      public unsafe struct cs_trus_st0                  //        155/LC:0  checked truss stresses
      {
            public int  m_nr;                           //        ident 0
            public int  m_mat;                          //        Materialnumber
            public float  m_sig;                        // [1092] normal stress
            public float  m_buck;                       //        buckling intensity
      } // cs_trus_st0

      public unsafe struct cs_trus_str                  //        155/LC:+  truss stress (AQB)
      {
            public int  m_nr;                           //        trussingnumber
            public int  m_mat;                          //        Materialnumber
            public float  m_sig;                        // [1092] normal stress
            public float  m_buck;                       //        buckling intensity
      } // cs_trus_str

      public unsafe struct cs_cabl                      //        160/00  cable elements
      {
            public int  m_nr;                           //        cable number
            public fixed int  m_node[2];                //        nodenumbers
            public int  m_nrq;                          //        cross-section number
            public fixed float  m_t[3];                 //        normal direction
            public float  m_dl;                         // [1001] length of cable
            public float  m_pre;                        // [1101] prestress
            public float  m_gap;                        // [1003] slip of element
            public float  m_riss;                       // [1101] max tension force
            public float  m_flie;                       // [1101] yielding load
            public int  m_nref;                         //        reference axis
      } // cs_cabl

      public unsafe struct cs_cabl_loa                  //        161/LC  loads on cables
      {
            public int  m_nr;                           //        cable number
            public int  m_typ;                          //        type of load
            public float  m_pa;                         //        start value of load
            public float  m_pe;                         //        end value of load
      } // cs_cabl_loa

      public unsafe struct cs_cabl_re0                  //        162/LC:0  maximum results of cables
      {
            public int  m_nr;                           //        identifier 0
            public float  m_n;                          // [1101] normal force
            public float  m_v;                          // [1003] axial displacement
            public float  m_vt;                         // [1003] maximum suspension of cable across axis
            public float  m_vtx;                        // [1003] suspension of cable, global X-component
            public float  m_vty;                        // [1003] suspension of cable, global Y-component
            public float  m_vtz;                        // [1003] suspension of cable, global Z-component
            public float  m_eps0;                       //        maximum induced strain
      } // cs_cabl_re0

      public unsafe struct cs_cabl_res                  //        162/LC:+  results of cables
      {
            public int  m_nr;                           //        cablenumber
            public float  m_n;                          // [1101] normal force
            public float  m_v;                          // [1003] axial displacement
            public float  m_vq;                         // [1003] maximum suspension of cable across axis
            public float  m_vtx;                        // [1003] suspension of cable, global X-component
            public float  m_vty;                        // [1003] suspension of cable, global Y-component
            public float  m_vtz;                        // [1003] suspension of cable, global Z-component
            public float  m_eps0;                       //        Total induced strain
            public float  m_n_m;                        // [1101] average normal force
            public float  m_f0;                         //        vertical suspension of cable in load direction
            public float  m_l0;                         //        relaxed cable length incl. temp. and prestrain effects
            public float  m_lex;                        //        nonlinear effect
            public fixed float  m_damm[6];              //        Damage Parameter
      } // cs_cabl_res

      public unsafe struct cs_cabl_slp                  //        163/00  slip cables
      {
            public int  m_nrsl;                         //        slip cable number
            public int  m_nrg;                          //        group number
            public int  m_nrel;                         //        element number
      } // cs_cabl_slp

      public unsafe struct cs_cabl_st0                  //        165/LC:0  checked cable stresses
      {
            public int  m_nr;                           //        ident 0
            public int  m_mat;                          //        Materialnumber
            public float  m_sig;                        // [1092] normal stress
      } // cs_cabl_st0

      public unsafe struct cs_cabl_str                  //        165/LC:+  cable stresses (AQB)
      {
            public int  m_nr;                           //        trussingnumber
            public int  m_mat;                          //        Materialnumber
            public float  m_sig;                        // [1092] normal stress
      } // cs_cabl_str

      public unsafe struct cs_spri                      //        170/00  Spring-elements
      {
            public int  m_nr;                           //        springnumber
            public fixed int  m_node[2];                //        start nodenumber
            public int  m_nrq;                          //        Material/section no
            public fixed float  m_t[3];                 //        normal direction
            public float  m_aref;                       //        reference area
            public float  m_cp;                         // [1095] spring stiffness
            public float  m_cq;                         // [1095] transverse stiff.
            public float  m_cm;                         // [1098] torsional stiff.
            public float  m_pre;                        //        prestress
            public float  m_gap;                        //        slip/gap of spring
            public float  m_riss;                       //        max tension force
            public float  m_flie;                       //        yielding load
            public float  m_mue;                        //        friction cross
            public float  m_coh;                        //        cohesion cross
            public float  m_dil;                        //        dilatancy factor
            public float  m_gapq;                       //        transverse slip/gap
            public float  m_dp;                         //        damping constant
            public float  m_dq;                         //        damping shear
            public float  m_dm;                         //        damping moment
            public float  m_expp;                       //        exponent for nonlinear damping dp**expp
            public float  m_expq;                       //        exponent for nonlinear damping dq**expq
            public float  m_expm;                       //        exponent for nonlinear damping dm**expm
            public fixed float  m_tb[3];                //        rotational direction
            public int  m_nref;                         //        additional bit code
      } // cs_spri

      public unsafe struct cs_spri_re0                  //        170/LC:0  maximum of results of spring-elements
      {
            public int  m_id;                           //        identifier
            public float  m_p;                          // [1151] maximum spring force
            public float  m_pt;                         // [1151] maximum spring transverse force
            public float  m_ptx;                        // [1151] maximum global X-shear component
            public float  m_pty;                        // [1151] maximum global Y-shear component
            public float  m_ptz;                        // [1151] maximum global Z-shear component
            public float  m_m;                          // [1152] maximum spring moment
            public float  m_v;                          // [1003] maximum axial displacement
            public float  m_vt;                         // [1003] maximum transverse displacement
            public float  m_vtx;                        // [1003] maximum trans displ., global X-component
            public float  m_vty;                        // [1003] maximum trans displ., global Y-component
            public float  m_vtz;                        // [1003] maximum trans displ., global Z-component
            public float  m_phi;                        // [1004] rotation
      } // cs_spri_re0

      public unsafe struct cs_spri_res                  //        170/LC:+  results of spring-elements
      {
            public int  m_nr;                           //        springnumber
            public float  m_p;                          // [1151] spring force
            public float  m_pt;                         // [1151] spring transforce
            public float  m_ptx;                        // [1151] global X-shear component
            public float  m_pty;                        // [1151] global Y-shear component
            public float  m_ptz;                        // [1151] global Z-shear component
            public float  m_m;                          // [1152] spring moment
            public float  m_v;                          // [1003] axial displacement
            public float  m_vt;                         // [1003] trans. displacement
            public float  m_vtx;                        // [1003] trans. displacement, global X-component
            public float  m_vty;                        // [1003] trans. displacement, global Y-component
            public float  m_vtz;                        // [1003] trans. displacement, global Z-component
            public float  m_phi;                        // [1004] rotation
            public float  m_lex;                        //        nonlinear effect
            public fixed float  m_stvp[10];             //        State variable / Damage Parameter for CP
            public fixed float  m_stvm[10];             //        State variable / Damage Parameter for CM
            public fixed float  m_stvt[10];             //        State variable / Damage Parameter for CT
      } // cs_spri_res

      public unsafe struct cs_damp                      //        171/00  Damping elements (DYNA)
      {
            public int  m_nr;                           //        element number
            public fixed int  m_node[2];                //        nodenumbers
            public int  m_i_3;
            public fixed float  m_t[3];                 //        normal direction
            public float  m_aref;                       //        reference area
            public float  m_dp;                         //        damping constant
            public float  m_dq;                         //        damping shear
            public float  m_dm;                         //        damping moment
            public float  m_expp;                       //        exponent for nonlinear damping dp**expp
            public float  m_expq;                       //        exponent for nonlinear damping dq**expq
            public float  m_expm;                       //        exponent for nonlinear damping dm**expm
      } // cs_damp

      public unsafe struct cs_mass                      //        172/00  Persistent Nodal masses
      {
            public int  m_nr;                           //        nodenumber
            public int  m_nrg;                          //        pseudoelementnumber IGDIV*Groupnr+IREF
            public fixed float  m_mt[3];                // [  52] transversal mass mt-x,mt-y,mt-z
            public fixed float  m_mr[6];                // [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
            public fixed float  m_mb[7];                //        warping  mass and higher coefficients
      } // cs_mass

      public unsafe struct cs_mass_add                  //        172/01  non persistent additional nodal masses
      {
            public int  m_nr;                           //        nodenumber
            public int  m_nrg;                          //        pseudoelementnumber IGDIV*Groupnr+IREF
            public fixed float  m_mt[3];                // [  52] transversal mass mt-x,mt-y,mt-z
            public fixed float  m_mr[6];                // [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
            public fixed float  m_mb[7];                //        warping  mass and higher coefficients
      } // cs_mass_add

      public unsafe struct cs_mass_eff                  //        172/LD:Z+  Effective nodal masses
      {
            public int  m_nr;                           //        identifier
            public fixed float  m_mt[3];                // [  52] transversal mass mt-x,mt-y,mt-z
            public fixed float  m_mr[3];                // [  55] rotatory mass    mr-xx,mr-yy,mr-zz
      } // cs_mass_eff

      public unsafe struct cs_mass_efc                  //        172/LD:-  Effective consistent masses
      {
            public int  m_nr;                           //        identifier = negative number of nodes
            public fixed int  m_node[8];                //        node numbers
            public fixed float  m_m[1176];              //        mass matrix in triangular format
      } // cs_mass_efc

      enum SPRI_WL0_LTYP_STD { SPRI_WL0_LTYP_STD = 1 }
      enum SPRI_WL0_LTYP_IHNG { SPRI_WL0_LTYP_IHNG = 2 }
      enum SPRI_WL0_LTYP_PMM { SPRI_WL0_LTYP_PMM = 3 }
      enum SPRI_WL0_MTYP_PLAS { SPRI_WL0_MTYP_PLAS = 1 }
      enum SPRI_WL0_MTYP_PISO { SPRI_WL0_MTYP_PISO = 2 }
      enum SPRI_WL0_MTYP_HYPE { SPRI_WL0_MTYP_HYPE = 3 }
      enum SPRI_WL0_MTYP_PKIN { SPRI_WL0_MTYP_PKIN = 4 }
      public unsafe struct cs_spri_wl0                  //        173/NR:0  (nonlinear) Spring material
      {
            public int  m_id;                           //        Identification = 0
            public int  m_ltyp;                         //        Type of link
            public int  m_mtyp;                         //        Type of law
            public int  m_icap;                         //        capacities from reference-section SNO
            public int  m_ibit2;                        //        reserved
            public int  m_ihbit;                        //        Bitpattern of defined degrees of freedom for implicit hinges
            public fixed float  m_rlim[2*7];            // [1105] 
            public float  m_alph;                       //        Interpolation exponent My-Mz (PMM, only)
            public fixed float  m_par[16];              //        further reserved material parameters
            public fixed int m_title[17];               //        Designation
      } // cs_spri_wl0

      enum SPRI_WL_ID_CP { SPRI_WL_ID_CP = 1 }
      enum SPRI_WL_ID_CQ { SPRI_WL_ID_CQ = 2 }
      enum SPRI_WL_ID_CM { SPRI_WL_ID_CM = 3 }
      enum SPRI_WL_ID_NX { SPRI_WL_ID_NX = 11 }
      enum SPRI_WL_ID_VY { SPRI_WL_ID_VY = 12 }
      enum SPRI_WL_ID_VZ { SPRI_WL_ID_VZ = 13 }
      enum SPRI_WL_ID_MT { SPRI_WL_ID_MT = 14 }
      enum SPRI_WL_ID_MY { SPRI_WL_ID_MY = 15 }
      enum SPRI_WL_ID_MZ { SPRI_WL_ID_MZ = 16 }
      enum SPRI_WL_ID_MB { SPRI_WL_ID_MB = 17 }
      enum SPRI_WL_NTYP_USER { SPRI_WL_NTYP_USER = 0 }
      enum SPRI_WL_NTYP_LIN { SPRI_WL_NTYP_LIN = 1 }
      enum SPRI_WL_NTYP_BILIN { SPRI_WL_NTYP_BILIN = 2 }
      enum SPRI_WL_NTYP_TRILIN { SPRI_WL_NTYP_TRILIN = 3 }
      enum SPRI_WL_NTYP_PLAS { SPRI_WL_NTYP_PLAS = 4 }
      public unsafe struct cs_spri_wl                   //        173/NR:+  Worklaw for nonlinear Springs
      {
            public int  m_id;                           //        Identification
            public int  m_ntyp;                         //        Type of law
            public float  m_plvl;                       // [1101] Normal force reference level
            public float  m_eur;                        //        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
            public fixed float  m_par[8];               //        further reserved material parameters
            public fixed float  m_arb[20*5];            //        Function values
      } // cs_spri_wl

      public unsafe struct cs_spri_mov                  //        174/00  Moving Springs
      {
            public int  m_nr;                           //        spring element number
            public int  m_typ;                          //        searching criteria
            public int  m_from;                         //        selection for TYP
            public int  m_to;                           //        selection for TYP
            public int  m_inc;                          //        selection for TYP
      } // cs_spri_mov

      public unsafe struct cs_s_matrix                  //        175/00  General stiffness matrix
      {
            public int  m_nr;                           //        elementnumber
            public int  m_ndn;                          //        number of degrees of freedom per node
            public fixed int  m_node[6];                //        nodenumbers
            public fixed float  m_s[2048];              //        stiffness matrix
      } // cs_s_matrix

      public unsafe struct cs_d_matrix                  //        176/00  General damping matrix
      {
            public int  m_nr;                           //        elementnumber
            public int  m_ndn;                          //        number of degrees of freedom per node
            public fixed int  m_node[6];                //        nodenumbers
            public fixed float  m_s[2048];              //        stiffness matrix
      } // cs_d_matrix

      public unsafe struct cs_m_matrix                  //        177/00  General mass matrix
      {
            public int  m_nr;                           //        elementnumber
            public int  m_ndn;                          //        number of degrees of freedom per node
            public fixed int  m_node[6];                //        nodenumbers
            public fixed float  m_s[2048];              //        stiffness matrix
      } // cs_m_matrix

      public unsafe struct cs_boun                      //        180/00:+  Boundary elements
      {
            public int  m_nr;                           //        elementnumber
            public int  m_nvon;                         //        start nodenumber
            public int  m_nbis;                         //        end nodenumber
            public int  m_ndel;                         //        increment
            public int  m_typ;                          //        type of bedding
            public int  m_mess;                         //        direction of addition
            public float  m_ca;                         //        start constant of bedding
            public float  m_ce;                         //        end constant of bedding
            public fixed float  m_dxyz[3];              //        direction of bedding, X/Y/Z-component
            public fixed int m_text[17];                //        Designation of element
      } // cs_boun

      public unsafe struct cs_boun_res                  //        180/LC  results of boundary elements
      {
            public int  m_nr;                           //        element number
            public int  m_nk;                           //        nodenumber
            public float  m_px;                         // [1153] X-support force
            public float  m_py;                         // [1153] Y-support force
            public float  m_pz;                         // [1153] Z-support force
            public float  m_mn;                         // [1154] support moment
      } // cs_boun_res

      public unsafe struct cs_boun_sum                  //        181/LC  resultant of boundary results
      {
            public int  m_nr;                           //        element number
            public float  m_px;                         // [1151] X-support force
            public float  m_py;                         // [1151] X-support force
            public float  m_pz;                         // [1151] X-support force
            public float  m_mn;                         // [1152] N-support moment
            public float  m_mx;                         // [1152] X-support moment
            public float  m_my;                         // [1152] Y-support moment
            public float  m_mz;                         // [1152] Z-support moment
      } // cs_boun_sum

      public unsafe struct cs_boun_lc_lpt               //        node number + load value
      {
            public int  m_n;
            public float  m_p;
      } // cs_boun_lc_lpt

      public unsafe struct cs_boun_lc                   //        183/LC  Info on loading on boundaries
      {
            public int  m_nr;                           //        element number
            public int  m_typ;                          //        type of load
            public cs_boun_lc_lpt  m_lpt;               //        node number + load value
      } // cs_boun_lc

      public unsafe struct cs_boun_loa                  //        176/LC  loads on edges
      {
            public int  m_nvon;                         //        start nodenumber
            public int  m_nbis;                         //        end nodenumber
            public int  m_ndel;                         //        increment
            public int  m_typ;                          //        type of load
            public int  m_mess;                         //        direction of addition
            public float  m_pa;                         //        start load value
            public float  m_pe;                         //        end load value
      } // cs_boun_loa

      public unsafe struct cs_spri_sum                  //        187/LC  Sum of forces of support springs
      {
            public int  m_nr;                           //        group-number
            public float  m_px;                         // [1151] nodal support X
            public float  m_py;                         // [1151] nodal support Y
            public float  m_pz;                         // [1151] nodal support u
            public float  m_mx;                         // [1152] support moment X
            public float  m_my;                         // [1152] support moment Y
            public float  m_mz;                         // [1152] support moment Z
            public float  m_mb;                         // [1105] warping moment
      } // cs_spri_sum

      public unsafe struct cs_rset                      //        188/00:+  Sets of results
      {
            public int  m_id;                           //        number / identifier of result set
            public int  m_nit;                          //        number of items in that result set
            public fixed int m_text[17];                //        Designation of that set
      } // cs_rset

      public unsafe struct cs_rset_itm                  //        188/00:0  Member of result set
      {
            public int  m_id0;                          //        Identifier = 0
            public fixed int  m_id[2];                  //        Short name of member for headdings
            public fixed int  m_ids[2];                 //        Selector of main structure
            public fixed int  m_idm[2];                 //        Selector of item member
            public int  m_dim;                          //        enum of explicitly selected unit
            public int  m_kwh;                          //        main id of result data
            public int  m_pos;                          //        position of value in data (starting at zero)
            public int  m_bit;                          //        bit pattern of defined selection data
            public int  m_nr;                           //        main number of result data
            public int  m_ng;                           //        second number of result data (e.g. group)
            public int  m_nd1;                          //        reserved for additional selection data
            public int  m_nd2;                          //        reserved for additional selection data
            public int  m_nd3;                          //        reserved for additional selection data
            public float  m_x;                          //        selector for beam abscissae
      } // cs_rset_itm

      public unsafe struct cs_rset_dat                  //        188/LC  Result-values for sets of results
      {
            public int  m_id;                           //        identifier of result set
            public fixed float  m_val[255];             //        result values
      } // cs_rset_dat

      public unsafe struct cs_link                      //        179/00  link elements
      {
            public int  m_nr;                           //        pipenumber
            public fixed int  m_node[2];                //        nodenumbers
            public int  m_nrq;                          //        material-, type- or cross-sectionnumber
            public float  m_dl;                         // [1001] length of pipe
            public float  m_a;                          //        Nominal width or linear loss factor
            public float  m_b;                          //        Abs. Roughness or quadratic loss factor
            public float  m_c;                          //        specific storage coefficient
            public float  m_eps;                        //        emission coefficient
            public float  m_aref;                       // [1002] reference area of element
      } // cs_link

      public unsafe struct cs_pipe                      //        190/00  pipes / armatures
      {
            public int  m_nr;                           //        pipenumber
            public fixed int  m_node[2];                //        nodenumbers
            public int  m_nrq;                          //        material-, type- or cross-sectionnumber
            public float  m_dl;                         // [1001] length of pipe
            public float  m_a;                          //        Nominal width or linear loss factor
            public float  m_b;                          //        Abs. Roughness or quadratic loss factor
            public float  m_c;                          //        specific storage coefficient
            public float  m_eps;                        //        emission coefficient
            public float  m_aref;                       // [1002] reference area of element
      } // cs_pipe

      public unsafe struct cs_pipe_res                  //        190/LC  results of pipes
      {
            public int  m_nr;                           //        pipenumber
            public float  m_ha;                         // [1010] start potential
            public float  m_he;                         // [1010] end potential
            public float  m_i;                          //        gradient
            public float  m_a;                          // [1012] flow area
            public float  m_pa;                         // [  70] start compression
            public float  m_pe;                         // [  70] end compression
            public float  m_q;                          // [1211] flow quantity
            public float  m_v;                          // [1212] flow velocity
            public float  m_r;                          // [1011] hydraulic radius
            public float  m_k;                          // [1016] roughness
            public float  m_re;                         //        Reynolds number
            public float  m_fr;                         //        Froud    number
      } // cs_pipe_res

      enum LEN_CQUAD0 { LEN_CQUAD0 = 27 }
      public unsafe struct cs_quad                      //        200/00  QuadElements
      {
            public int  m_nr;                           //        elementnumber
            public fixed int  m_node[4];                //        nodenumbers
            public int  m_mat;                          //        materialnumber
            public int  m_mrf;                          //        material Reinf.
            public int  m_nra;                          //        type of element
            public fixed float  m_det[3];               //        Parameter of Jacobi Determinant
            public fixed float  m_thick[5];             // [1010] element thickness
            public float  m_cb;                         //        bedding factor
            public float  m_cq;                         //        tangential bedding factor
            public fixed float  m_t[3*3];               //        transformation matrix
            public int  m_ifc1;                         //        identifier of a most adjacent outer boundary
            public fixed float  m_dfc1[4];              // [1001] distance of the nodes to the boundary IFC1
            public int  m_ifc2;                         //        identifier of a most adjacent inner boundary
            public fixed float  m_dfc2[4];              // [1001] distance of the nodes to the boundary IFC2
      } // cs_quad

      public unsafe struct cs_quad_noh                  //        200/1:0  unified properties of Quad-nodes
      {
            public int  m_id1;
            public int  m_id2;
            public int  m_nkrec;
            public int  m_maxnel;
            public int  m_maxugr;
            public int  m_maxgr;
            public int  m_nquad;
            public int  m_mquad;                        //        Highest Number of Quadelement
      } // cs_quad_noh

      public unsafe struct cs_quad_nom                  //        200/1:-  unified properties of Quad-nodes
      {
            public int  m_ngt;                          //        groupselector
            public int  m_nr;                           //        nodenumber
            public fixed int  m_iel[9999];              //        connecting elements
      } // cs_quad_nom

      public unsafe struct cs_quad_nod                  //        200/1:*  properties of Quad-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public float  m_d;                          // [1010] minimum thickness of plate on node
            public fixed float  m_t[3*3];               //        lokal average coordinate system
      } // cs_quad_nod

      public unsafe struct cs_quad_edh                  //        200/2:0  Edges of Quad-elements
      {
            public int  m_id1;
            public int  m_id2;
            public int  m_nedg;
            public int  m_mqua;                         //        max number of quads per edge
      } // cs_quad_edh

      public unsafe struct cs_quad_edg                  //        200/2:+  Edges of Quad-elements
      {
            public int  m_ka;                           //        First Node
            public int  m_ke;                           //        Last Node
            public int  m_ijmp;                         //        bit pattern of jump condition
            public int  m_nqua;                         //        number of quads
            public fixed int  m_nrel[9999];             //        Number of Quad-elements
      } // cs_quad_edg

      public unsafe struct cs_quad_ten                  //        200/5  tendons of Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public int  m_nrs;                          //        tendon number
            public int  m_mnr;                          //        tendon material
            public int  m_iba1;                         //        construction stage number for placing
            public int  m_iba2;                         //        construction stage number for grouting
            public int  m_iba3;                         //        construction stage number for removing
            public fixed float  m_r[2];                 //        isoparametric coordinates start/end point
            public fixed float  m_s[2];                 //        isoparametric coordinates start/end point
            public fixed float  m_z[2];                 // [1011] eccentricity of the middle area
            public fixed float  m_zz[2];                // [1101] tendon force, start- and endpoint
            public float  m_az;                         // [1020] area of tendon
            public float  m_uz;                         // [1023] effect. periphery
            public float  m_ah;                         // [1020] area of sheath
            public float  m_ar;                         // [1012] relative area
            public fixed float  m_dy[2];                //        gradient of tendon
            public fixed float  m_dz[2];                //        gradient of tendon
            public fixed float  m_exz[2];               // [1011] perpendicular eccentricity of duct to tendon
            public fixed float  m_exy[2];               // [1011] transverse eccentricity of duct to tendon
            public fixed float  m_sref[2];              //        parameter values along tendon geometry
            public fixed float  m_xyzt[2*3];            // [1001] Coordinates of tendon start & endpoint
            public fixed float  m_xyzh[2*3];            // [1001] Coordinates of duct start & endpoint
      } // cs_quad_ten

      public unsafe struct cs_quad_rim                  //        200/6  Prescribed Reinforcements of Quad-elements
      {
            public int  m_nrg;                          //        group number
            public int  m_nr;                           //        selector number
            public int  m_typ;                          //        Type of Reinforc.
            public int  m_gtyp;                         //        Type of grading
            public int  m_idra;                         //        drawing source type
            public float  m_rio;                        // [   5] direction of upside reinforcement
            public float  m_rioq;                       // [   5] direction of upside cross reinforcement
            public float  m_rioi;                       // [   5] direction of upside third reinforcement
            public float  m_riu;                        // [   5] direction of downside reinforcement
            public float  m_riuq;                       // [   5] direction of downside cross reinforcement
            public float  m_riui;                       // [   5] direction of downside third reinforcement
            public float  m_xref;                       // [1001] Reference point for circular reinforcement
            public float  m_yref;                       // [1001] Reference point for circular reinforcement
            public float  m_zref;                       // [1001] Reference point for circular reinforcement
            public float  m_hio;                        // [1024] distance of upside reinforcement
            public float  m_hioq;                       // [1024] distance of upside cross reinforcement
            public float  m_hioi;                       // [1024] distance of upside third reinforcement
            public float  m_hiu;                        // [1024] distance of downside reinforcement
            public float  m_hiuq;                       // [1024] distance of downside cross reinforcement
            public float  m_hiui;                       // [1024] distance of downside third reinforcement
            public float  m_dio;                        // [1023] Diameter of upside reinforcement
            public float  m_dioq;                       // [1023] Diameter of upside cross reinforcement
            public float  m_dioi;                       // [1023] Diameter of upside third reinforcement
            public float  m_diu;                        // [1023] Diameter of downside reinforcement
            public float  m_diuq;                       // [1023] Diameter of downside cross reinforcement
            public float  m_diui;                       // [1023] Diameter of downside third reinforcement
            public float  m_dss;                        // [1023] Diameter of stirrup reinforcement
            public float  m_aso;                        // [1021] upside Minimum reinforcement (outside)
            public float  m_asoq;                       // [1021] upside cross Minimum reinforcement (middle)
            public float  m_asoi;                       // [1021] upside third Minimum reinforcement (inside)
            public float  m_asu;                        // [1021] downside Minimum reinforcement (outside)
            public float  m_asuq;                       // [1021] downside cross Minimum reinforcement (middle)
            public float  m_asui;                       // [1021] downside third Minimum reinforcement (inside)
            public float  m_ass;                        // [1022] Min stirrup cm2/m2
            public float  m_amo;                        // [1021] upside Maximum reinforcement (outside)
            public float  m_amoq;                       // [1021] upside cross Maximum reinforcement (middle)
            public float  m_amoi;                       // [1021] upside third Maximum reinforcement (inside)
            public float  m_amu;                        // [1021] downside Maximum reinforcement (outside)
            public float  m_amuq;                       // [1021] downside cross Maximum reinforcement (middle)
            public float  m_amui;                       // [1021] downside third Maximum reinforcement (inside)
            public float  m_ams;                        // [1022] Max stirrup cm2/m2
            public fixed float  m_wk6[6];               // [1026] design crack width
            public fixed float  m_sig6[6];              // [1092] SLS steel stress limit
      } // cs_quad_rim

      public unsafe struct cs_qcut_0                    //        200/8:0  Header for fabrication areas
      {
            public int  m_nr;                           //        identifier = 0
            public int  m_typ;                          //        identifier = 0
            public int  m_nar;                          //        number of areas
            public float  m_x;                          // [1001] x-center
            public float  m_y;                          // [1001] y-
            public float  m_ar3d;                       // [1002] area in 3D
            public float  m_ar2d;                       // [1002] area in 2D
            public float  m_ar_0;                       // [1002] area stressfree
      } // cs_qcut_0

      public unsafe struct cs_qcut_new                  //        200/8:+  New cutting area
      {
            public int  m_nr;                           //        areanumber
            public int  m_typ;                          //        identifier = 0
            public int  m_lf;                           //        Loadcase
            public float  m_x;                          // [1001] x-ordinate
            public float  m_y;                          // [1001] y- center(text)
            public float  m_ar3d;                       // [1002] area in 3D
            public float  m_ar2d;                       // [1002] area in 2D
            public float  m_ar_0;                       // [1002] area stressfree
      } // cs_qcut_new

      public unsafe struct cs_qcut_dir                  //        200/8:+  Material direction
      {
            public int  m_nr;                           //        areanumber
            public int  m_typ;                          //        Identification
            public int  m_mnr;                          //        material no
            public float  m_alf;                        // [   5] warp direction
            public float  m_emod;                       // [1090] E Mod warp direction
            public float  m_e90;                        // [1090] Elasticity modulus perpendicular
      } // cs_qcut_dir

      public unsafe struct cs_qcut_out                  //        200/8:+  Vertex of geometric boundary
      {
            public int  m_nr;                           //        areanumber
            public int  m_typ;                          //        Identification
            public int  m_line;                         //        linetype
            public float  m_x;                          // [1001] x-ordinate
            public float  m_y;                          // [1001] y-ordinate
      } // cs_qcut_out

      public unsafe struct cs_qcut_in                   //        200/8:+  Geometry inner lines
      {
            public int  m_nr;                           //        areanumber
            public int  m_typ;                          //        Identification
            public int  m_i_2;
            public float  m_xa;                         // [1001] x  startpoint
            public float  m_ya;                         // [1001] y  startpoint
            public float  m_xe;                         // [1001] x  endpoint
            public float  m_ye;                         // [1001] y  endpoint
      } // cs_qcut_in

      public unsafe struct cs_qcut_war                  //        200/8:+  element warp direction
      {
            public int  m_nr;                           //        areanumber
            public int  m_typ;                          //        Identification
            public int  m_nrel;                         //        orig elem.no
            public float  m_xa;                         // [1001] x  startpoint
            public float  m_ya;                         // [1001] y  startpoint
            public float  m_xe;                         // [1001] x  endpoint
            public float  m_ye;                         // [1001] y  endpoint
            public float  m_alf;                        // [   5] warp direction
      } // cs_qcut_war

      public unsafe struct cs_textile                   //        200/9  definition of cutting lines
      {
            public int  m_ig;                           //        group selector
            public int  m_typ;                          //        type of line
            public float  m_xa;                         // [1001] line point A
            public float  m_ya;                         // [1001] 
            public float  m_za;                         // [1001] 
            public float  m_xe;                         // [1001] line point E
            public float  m_ye;                         // [1001] 
            public float  m_ze;                         // [1001] 
            public float  m_nx;                         // [1001] projection
            public float  m_ny;                         // [1001] 
            public float  m_nz;                         // [1001] 
      } // cs_textile

      public unsafe struct cs_quad_p                    //        200/10  Quad-P-elements
      {
            public int  m_nr;                           //        elementnumber
            public fixed int  m_node[4];                //        nodenumbers
            public int  m_mat;                          //        materialnumber
            public int  m_mrf;                          //        material Reinf.
            public int  m_nra;                          //        type of element
            public fixed int  m_edge[4];                //        No of geometric property of edge 1-2
            public fixed float  m_det[3];               //        Parameter of Jacobi Determinant
            public fixed float  m_thick[5];             // [1010] element thickness
            public float  m_cb;                         //        bedding factor
            public float  m_cq;                         //        tangential bedding factor
            public fixed float  m_t[3*3];               //        transformation matrix
      } // cs_quad_p

      public unsafe struct cs_quad_lpt                  //        201/LC:*  Free single loads on Quad-elements
      {
            public int  m_nrg;                          //        groupnumber
            public int  m_typ;                          //        type of load
            public float  m_xa;                         // [1001] load point
            public float  m_ya;                         // [1001] load point
            public float  m_za;                         // [1001] load point
            public float  m_p;                          //        load value
            public float  m_prz;                        // [   8] Percentage of load covered with elements
      } // cs_quad_lpt

      public unsafe struct cs_quad_lln                  //        201/LC:*  global line loads of Quad-elements
      {
            public int  m_nrg;                          //        groupnumber
            public int  m_typ;                          //        type of load
            public float  m_xa;                         // [1001] load reference point
            public float  m_ya;                         // [1001] load reference point
            public float  m_za;                         // [1001] load reference point
            public float  m_dx;                         // [1001] difference to 2nd point
            public float  m_dy;                         // [1001] difference to 2nd point
            public float  m_dz;                         // [1001] difference to 2nd point
            public float  m_pa;                         //        load value start point
            public float  m_pb;                         //        load value end point
            public float  m_prz;                        // [   8] Percentage of load covered with elements
      } // cs_quad_lln

      public unsafe struct cs_quad_lar                  //        201/LC:*  global area loads of Quad-elements
      {
            public int  m_nrg;                          //        groupnumber
            public int  m_typ;                          //        type of load
            public float  m_xa;                         // [1001] load reference point
            public float  m_ya;                         // [1001] load reference point
            public float  m_za;                         // [1001] load reference point
            public float  m_dx;                         // [1001] difference to 3rd point (diagonal)
            public float  m_dy;                         // [1001] difference to 3rd point (diagonal)
            public float  m_dz;                         // [1001] difference to 3rd point (diagonal)
            public float  m_dxs;                        // [1001] difference to 2nd point
            public float  m_dys;                        // [1001] difference to 2nd point
            public float  m_dzs;                        // [1001] difference to 2nd point
            public float  m_dxt;                        // [1001] difference to 4th point
            public float  m_dyt;                        // [1001] difference to 4th point
            public float  m_dzt;                        // [1001] difference to 4th point
            public float  m_p1;                         //        load value
            public float  m_p2;                         //        load value
            public float  m_p3;                         //        load value
            public float  m_prz;                        // [   8] Percentage of load covered with elements
      } // cs_quad_lar

      public unsafe struct cs_quad_loa                  //        202/LC  Quad-element loads
      {
            public int  m_von;                          //        start elementnumber
            public int  m_bis;                          //        end elementnumber
            public int  m_del;                          //        increment
            public int  m_typ;                          //        type of load
            public int  m_lnr;                          //        special option value
            public float  m_p;                          //        load values
            public float  m_dpdx;
            public float  m_dpdy;
            public float  m_dpdz;
            public float  m_xref;                       // [1001] optional reference point for load value to
            public float  m_yref;                       // [1001] 
            public float  m_zref;                       // [1001] 
            public fixed float  m_tfun[15*2];           //        optional function of load values across the
      } // cs_quad_loa

      public unsafe struct cs_quad_lpi                  //        203/LC:*  internal single loads on Quad-elements
      {
            public int  m_nr;                           //        element number
            public int  m_typ;                          //        type of load
            public float  m_prz;                        // [   8] Percentage of load covered with elements
            public float  m_s;                          //        load point in local coordinates
            public float  m_t;                          //        load point in local coordinates
            public float  m_p;                          //        load value
      } // cs_quad_lpi

      public unsafe struct cs_quad_lli                  //        203/LC:*  internal line loads of Quad-elements
      {
            public int  m_nr;                           //        element number
            public int  m_typ;                          //        type of load
            public float  m_prz;                        // [   8] 
            public float  m_sa;
            public float  m_ta;
            public float  m_pa;
            public float  m_sb;
            public float  m_tb;
            public float  m_pb;                         //        load value end point
      } // cs_quad_lli

      public unsafe struct cs_quad_lai_lpt              //        load points in local coordinates
      {
            public float  m_s;
            public float  m_t;
            public float  m_p;
      } // cs_quad_lai_lpt

      public unsafe struct cs_quad_lai                  //        203/LC:*  Free area loads on Quad-elements
      {
            public int  m_nr;                           //        element number
            public int  m_typ;                          //        type of load
            public float  m_prz;                        // [   8] 
            public cs_quad_lai_lpt  m_lpt;              //        load points in local coordinates
      } // cs_quad_lai

      public unsafe struct cs_quad_lt                   //        206/NR  Temperature load profiles for QUADs
      {
            public float  m_t;                          // [  90] Time value
            public fixed float  m_temp[20*5];           //        Temperature values
      } // cs_quad_lt

      public unsafe struct cs_quad_foc                  //        210/LC:0  maximum forces of Quad elements
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force
            public float  m_vy;                         // [1111] shear force
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public float  m_hp1;                        //        yield function
            public float  m_hp2;                        //        volum. hardening
      } // cs_quad_foc

      public unsafe struct cs_quad_for                  //        210/LC:+  forces of Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force
            public float  m_vy;                         // [1111] shear force
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public fixed float  m_sg[4*8];              // [1112] results in GAUSS-points
            public fixed float  m_hp1[5];               //        yield function
            public fixed float  m_hp2[5];               //        volum. hardening
            public fixed float  m_hp3[5];               //        3rd parameter
      } // cs_quad_for

      public unsafe struct cs_quad_nfc                  //        211/LC:0  maximum forces in nodes
      {
            public int  m_ng;                           //        ident 0 for maximum (first records)
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force
            public float  m_vy;                         // [1111] shear force
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public float  m_hp1;                        //        yield function
      } // cs_quad_nfc

      public unsafe struct cs_quad_nfo                  //        211/LC:Z+  Nodal Quad forces
      {
            public int  m_ng;                           //        groupselector
            public int  m_nr;                           //        nodenumber
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force abs
            public float  m_vy;                         // [1111] shear force abs
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public float  m_vx_v;                       // [1111] shear force signed
            public float  m_vy_v;                       // [1111] shear force signed
            public float  m_fy;                         //        yield function
      } // cs_quad_nfo

      public unsafe struct cs_quad_efc                  //        212/LC:0  maximum error estimates for Quad-elements
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force
            public float  m_vy;                         // [1111] shear force
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public float  m_err;                        //        error in energy
      } // cs_quad_efc

      public unsafe struct cs_quad_efo                  //        212/LC:+  error estimates for Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_mxx;                        // [1114] bending moment
            public float  m_myy;                        // [1114] bending moment
            public float  m_mxy;                        // [1113] torsion moment
            public float  m_vx;                         // [1111] shear force
            public float  m_vy;                         // [1111] shear force
            public float  m_nx;                         // [1112] membran force
            public float  m_ny;                         // [1112] membran force
            public float  m_nxy;                        // [1112] membran force
            public float  m_hopt;                       // [1001] optimal mesh size
      } // cs_quad_efo

      public unsafe struct cs_quad_bec                  //        213/LC:0  bedding stresses and results
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_pse;                        // [1155] bedding centre
            public fixed float  m_ps[4];                // [1155] bedding in nodes
            public float  m_pre;                        // [1151] result bedd.force in centre
            public fixed float  m_pr[4];                // [1151] result bedd. values in Quad-nodes
            public float  m_pve;                        // [1003] bedding displacememts in centre
            public fixed float  m_pv[4];                // [1003] bedding displacements in nodes
            public float  m_pte;                        // [1155] tangential bedding in centre
            public fixed float  m_pt[4];                // [1155] tangential bedding in nodes
            public float  m_ptxe;                       // [1155] tangential bedding in centre X-component
            public fixed float  m_ptx[4];               // [1155] tangential bedding in nodes X-component
            public float  m_ptye;                       // [1155] tangential bedding in centre Y-component
            public fixed float  m_pty[4];               // [1155] tangential bedding in nodes Y-component
            public float  m_ptze;                       // [1155] tangential bedding in centre Z-component
            public fixed float  m_ptz[4];               // [1155] tangential bedding in nodes Z-component
            public fixed float  m_rq[12];               // [1151] resulting tangential bedding in nodes
      } // cs_quad_bec

      public unsafe struct cs_quad_bed                  //        213/LC:+  bedding stresses and results
      {
            public int  m_nr;                           //        Quadelementnumber
            public float  m_pse;                        // [1155] bedding centre
            public fixed float  m_ps[4];                // [1155] bedding in nodes
            public float  m_pre;                        // [1151] result bedd.force in centre
            public fixed float  m_pr[4];                // [1151] result bedd. values in Quad-nodes
            public float  m_pve;                        // [1003] bedding displacememts in centre
            public fixed float  m_pv[4];                // [1003] bedding displacements in nodes
            public float  m_pte;                        // [1155] tangential bedding in centre
            public fixed float  m_pt[4];                // [1155] tangential bedding in nodes
            public float  m_ptxe;                       // [1155] tangential bedding in centre X-component
            public fixed float  m_ptx[4];               // [1155] tangential bedding in nodes X-component
            public float  m_ptye;                       // [1155] tangential bedding in centre Y-component
            public fixed float  m_pty[4];               // [1155] tangential bedding in nodes Y-component
            public float  m_ptze;                       // [1155] tangential bedding in centre Z-component
            public fixed float  m_ptz[4];               // [1155] tangential bedding in nodes Z-component
            public fixed float  m_rq[12];               // [1151] resulting tangential bedding in nodes
      } // cs_quad_bed

      public unsafe struct cs_quad_rfx                  //        214/LC  additional information for primary loadcases
      {
            public int  m_nr;                           //        Quad-elementnumber
            public fixed float  m_eps[8*5];             //        strain
            public fixed float  m_riss[8*5];            //        directions of crack
      } // cs_quad_rfx

      public unsafe struct cs_quad_rnc                  //        215/LC:0  nonlinear results of Quad-element
      {
            public int  m_nr;                           //        ident 0 for maximum
            public int  m_nmat;                         //        type of material behaviour
            public float  m_esxo;                       // [   9] upside strain
            public float  m_esyo;                       // [   9] upside strain
            public float  m_exyo;                       // [   9] upside strain
            public float  m_esmo;                       // [   9] upside reference strain
            public float  m_esxu;                       // [   9] downside strain
            public float  m_esyu;                       // [   9] downside strain
            public float  m_exyu;                       // [   9] downside strain
            public float  m_esmu;                       // [   9] downside reference strain
            public float  m_sxo;                        // [1092] upside stress
            public float  m_syo;                        // [1092] upside stress
            public float  m_sxyo;                       // [1092] upside stress
            public float  m_smo;                        // [1092] upside reference stress
            public float  m_sxu;                        // [1092] downside stress
            public float  m_syu;                        // [1092] downside stress
            public float  m_sxyu;                       // [1092] downside stress
            public float  m_sm_u;                       // [1092] downside reference stress
            public float  m_sgvo;                       // [1092] upside reference stress incl. shear
            public float  m_sgvu;                       // [1092] downside reference stress incl. shear
            public float  m_fy;                         //        yield function
            public float  m_fdo;                        // [1011] steel - upside yield depth
            public float  m_fdu;                        // [1011] steel - downside yield depth
            public float  m_i_22;
            public float  m_wr1o;                       //        concrete - upside direction of crack 1
            public float  m_wr1u;                       //        concrete - downside direction of crack 1
            public float  m_wr2o;                       //        concrete - upside direction of crack 2
            public float  m_wr2u;                       //        concrete - downside direction of crack 2
            public float  m_sgso;                       // [1092] concrete - upside shear stress on crack
            public float  m_sgsu;                       // [1092] concrete - downside shear stress on crack
            public float  m_sg1o;                       // [1092] concrete - upside steel stress II,dir.1
            public float  m_sg1u;                       // [1092] concrete - downside steel stress II,dir.1
            public float  m_sg2o;                       // [1092] concrete - upside steel stress II,dir. 2
            public float  m_sg2u;                       // [1092] concrete - downside steel stress II,dir.2
            public float  m_w1o;                        // [1026] concrete - upside width of crack,direct. 1
            public float  m_w1u;                        // [1026] concrete - downside width of crack,dir. 1
            public float  m_w2o;                        // [1026] concrete - upside width of crack,direct. 2
            public float  m_w2u;                        // [1026] concrete - downside width of crack,dir. 2
            public float  m_bro;                        //        concrete -upside direction reinforcement
            public float  m_bru;                        //        concrete -downs. direction reinforcement
            public float  m_xd_x;                       // [1011] Minimum compression depth in local x axis
            public float  m_xd_y;                       // [1011] Minimum compression depth in local y axis
            public float  m_xd_1;                       // [1011] Minimum compression depth at least pressed uniaxial
            public float  m_xd_2;                       // [1011] Minimum compression depth pressed biaxial
            public float  m_epsb;                       // [   9] Maximum concrete compression strain
            public float  m_epsc;                       // [   9] Minimum averaged reinforcement strain
            public float  m_epst;                       // [   9] Maximum averaged reinforcement strain
            public float  m_sigc;                       // [1092] Maximum concrete compression stress
            public float  m_sigt;                       // [1092] Maximum concrete tension in the concrete layers
            public float  m_epsr;                       // [   9] Maximum reinforcement strain in the crack
      } // cs_quad_rnc

      public unsafe struct cs_quad_rno                  //        215/LC:+  nonlinear results of Quad-element
      {
            public int  m_nr;                           //        Quad-elementnumber
            public int  m_nmat;                         //        type of material behaviour
            public float  m_esxo;                       // [   9] upside strain
            public float  m_esyo;                       // [   9] upside strain
            public float  m_exyo;                       // [   9] upside strain
            public float  m_esmo;                       // [   9] upside reference strain
            public float  m_esxu;                       // [   9] downside strain
            public float  m_esyu;                       // [   9] downside strain
            public float  m_exyu;                       // [   9] downside strain
            public float  m_esmu;                       // [   9] downside reference strain
            public float  m_sxo;                        // [1092] upside stress
            public float  m_syo;                        // [1092] upside stress
            public float  m_sxyo;                       // [1092] upside stress
            public float  m_smo;                        // [1092] upside reference stress
            public float  m_sxu;                        // [1092] downside stress
            public float  m_syu;                        // [1092] downside stress
            public float  m_sxyu;                       // [1092] downside stress
            public float  m_sm_u;                       // [1092] downside reference stress
            public float  m_sgvo;                       // [1092] upside reference stress incl. shear
            public float  m_sgvu;                       // [1092] downside reference stress incl. shear
            public float  m_fy;                         //        yield function
            public float  m_fdo;                        // [1011] steel - upside yield depth
            public float  m_fdu;                        // [1011] steel - downside yield depth
            public float  m_i_22;
            public float  m_wr1o;                       //        concrete - upside direction of crack 1
            public float  m_wr1u;                       //        concrete - downside direction of crack 1
            public float  m_wr2o;                       //        concrete - upside direction of crack 2
            public float  m_wr2u;                       //        concrete - downside direction of crack 2
            public float  m_sgso;                       // [1092] concrete - upside shear stress on crack
            public float  m_sgsu;                       // [1092] concrete - downside shear stress on crack
            public float  m_sg1o;                       // [1092] concrete - upside steel stress II,dir.1
            public float  m_sg1u;                       // [1092] concrete - downside steel stress II,dir.1
            public float  m_sg2o;                       // [1092] concrete - upside steel stress II,dir. 2
            public float  m_sg2u;                       // [1092] concrete - downside steel stress II,dir.2
            public float  m_w1o;                        // [1026] concrete - upside width of crack,direct. 1
            public float  m_w1u;                        // [1026] concrete - downside width of crack,dir. 1
            public float  m_w2o;                        // [1026] concrete - upside width of crack,direct. 2
            public float  m_w2u;                        // [1026] concrete - downside width of crack,dir. 2
            public float  m_bro;                        //        concrete -upside direction reinforcement
            public float  m_bru;                        //        concrete -downs. direction reinforcement
            public float  m_xd_x;                       // [1011] Minimum compression depth in local x axis
            public float  m_xd_y;                       // [1011] Minimum compression depth in local y axis
            public float  m_xd_1;                       // [1011] Minimum compression depth at least pressed uniaxial
            public float  m_xd_2;                       // [1011] Minimum compression depth pressed biaxial
            public float  m_epsb;                       // [   9] Maximum concrete compression strain
            public float  m_epsc;                       // [   9] Minimum averaged reinforcement strain
            public float  m_epst;                       // [   9] Maximum averaged reinforcement strain
            public float  m_sigc;                       // [1092] Maximum concrete compression stress
            public float  m_sigt;                       // [1092] Maximum concrete tension in the concrete layers
            public float  m_epsr;                       // [   9] Maximum reinforcement strain in the crack
      } // cs_quad_rno

      public unsafe struct cs_quad_stc                  //        220/LC:0  maximum Quad-stress
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_svxy;                       // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public float  m_hp1;                        // [1092] yield function
            public float  m_hp2;                        //        2nd Parameter
            public float  m_hp3;                        //        3rd Parameter
            public float  m_hp4;                        //        4th Parameter
            public float  m_hp5;                        //        5th Parameter
            public float  m_hp6;                        //        6th Parameter
      } // cs_quad_stc

      public unsafe struct cs_quad_stp_htyp             //        = state variables for nonlinear material
      {
            public int  m_id;
            public int  m_idim;
            public float  m_maxval;
      } // cs_quad_stp_htyp

      public unsafe struct cs_quad_stp                  //        220/LC:-  Nonlinear QUAD-stress Headder
      {
            public int  m_typ;                          //        enum of nonlinear parameters as in 1/NR:1/???
            public cs_quad_stp_htyp  m_htyp;            //        = state variables for nonlinear material
      } // cs_quad_stp

      public unsafe struct cs_bric_stp_htyp             //        = state variables for nonlinear material
      {
            public int  m_id;
            public int  m_idim;
            public float  m_maxval;
      } // cs_bric_stp_htyp

      public unsafe struct cs_bric_stp                  //        310/LC:-  Nonlinear BRIC-stress Headder
      {
            public int  m_typ;                          //        enum of nonlinear parameters as in 1/NR:1/???
            public cs_bric_stp_htyp  m_htyp;            //        = state variables for nonlinear material
      } // cs_bric_stp

      public unsafe struct cs_quad_str_sg               //        results in GAUSS-points
      {
            public float  m_sigx;                       // [1092] 
            public float  m_sigy;                       // [1092] 
            public float  m_tau;                        // [1092] 
            public float  m_sigz;                       // [1092] 
      } // cs_quad_str_sg

      public unsafe struct cs_quad_str                  //        220/LC  stresses of Quad-element
      {
            public int  m_nr;                           //        Elementnumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public cs_quad_str_sg  m_sg;                //        results in GAUSS-points
            public float  m_pvx;                        // [1192] volume loading
            public float  m_pvy;                        // [1192] volume loading
            public float  m_pvt;                        // [   6] temperature loads
            public fixed float  m_hp1[5];               //        yield function
            public fixed float  m_hp2[5];               //        2nd parameter as specified in headder record
            public fixed float  m_hp3[5];               //        3rd parameter as specified in headder record
            public fixed float  m_hp4[5];               //        4th parameter as specified in headder record
            public fixed float  m_hp5[5];               //        5th parameter as specified in headder record
            public fixed float  m_hp6[5];               //        6th parameter as specified in headder record
            public fixed float  m_hp7[5];               //        7th parameter as specified in headder record
            public fixed float  m_hp8[5];               //        8th parameter as specified in headder record
            public fixed float  m_hp9[5];               //        9th parameter as specified in headder record
            public fixed float  m_hp10[5];              //        10th parameter as specified in headder record
            public fixed float  m_hp11[5];              //        11th parameter as specified in headder record
            public fixed float  m_hp12[5];              //        12th parameter as specified in headder record
            public fixed float  m_hp13[5];              //        13th parameter as specified in headder record
            public fixed float  m_hp14[5];              //        14th parameter as specified in headder record
            public fixed float  m_hp15[5];              //        15th parameter as specified in headder record
      } // cs_quad_str

      public unsafe struct cs_quad_nsc                  //        221/LC:0  maximum stresses in nodes
      {
            public int  m_ng;                           //        ident 0 for maximum (first records)
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_svxy;                       // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public float  m_fy;                         //        yield function
      } // cs_quad_nsc

      public unsafe struct cs_quad_nst                  //        221/LC:Z+  stresses in Quad-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public float  m_fy;                         //        yield function
      } // cs_quad_nst

      public unsafe struct cs_quad_esc                  //        222/LC:0  max. errors in nodes
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_svxy;                       // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public float  m_err;                        //        error in energy
      } // cs_quad_esc

      public unsafe struct cs_quad_est                  //        222/LC:+  error estimates of Quad-element stresses
      {
            public int  m_nr;                           //        elementnumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_tau;                        // [1092] shear stress
            public float  m_sigz;                       // [1092] stress
            public float  m_hopt;                       // [1002] optimal mesh size
      } // cs_quad_est

      public unsafe struct cs_quad_rlc                  //        225/LC:0  max Quad-Layer-results
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public int  m_mnr;                          //        ident 0 for maximum (first records)
            public float  m_xi;                         //        local-z
            public float  m_sigx;                       // [1092] stress x
            public float  m_sigy;                       // [1092] stress y
            public float  m_tau;                        // [1092] shear stress xy
            public float  m_sigz;                       // [1092] stress
            public float  m_taux;                       // [1092] shear stress vx
            public float  m_tauy;                       // [1092] shear stress vy
            public float  m_hp1;                        //        yield function
            public float  m_hp2;                        //        volum. hardening
            public float  m_hp3;                        //        damage parameter x
            public float  m_hp4;                        //        damage parameter y
            public float  m_hp5;                        // [   3] crack direction 1
            public float  m_hp6;                        // [   3] crack direction 2
            public float  m_hp7;                        // [   9] accumulated temperature strain
            public float  m_hp8;                        //        internal damage parameter shrinkage
            public float  m_hp9;                        // [   9] accumulated shrinkage strain
            public float  m_hp10;                       //        damage parameter xy
            public float  m_hp11;                       // [   9] epsx  strain in stress strain curve
            public float  m_hp12;                       // [   9] epsy  strain in stress strain curve
            public float  m_hp13;                       // [1215] layer temperature in case of fire analysis
      } // cs_quad_rlc

      public unsafe struct cs_quad_rla_sg               //        results in GAUSS-points
      {
            public float  m_sigx;                       // [1092] 
            public float  m_sigy;                       // [1092] 
            public float  m_tau;                        // [1092] 
            public float  m_sigz;                       // [1092] 
            public float  m_taux;                       // [1092] 
            public float  m_tauy;                       // [1092] 
      } // cs_quad_rla_sg

      public unsafe struct cs_quad_rla                  //        225/LC:+  Layer-stresses of Quads
      {
            public int  m_nr;                           //        Elementnumber
            public int  m_mnr;                          //        Materialnumber MNR>0
            public float  m_xi;                         //        local-z
            public float  m_sigx;                       // [1092] stress x
            public float  m_sigy;                       // [1092] stress y
            public float  m_tau;                        // [1092] shear stress xy
            public float  m_sigz;                       // [1092] stress
            public float  m_taux;                       // [1092] shear stress vx
            public float  m_tauy;                       // [1092] shear stress vy
            public cs_quad_rla_sg  m_sg;                //        results in GAUSS-points
            public fixed float  m_hp1[5];               //        yield function
            public fixed float  m_hp2[5];               //        volum. hardening
            public fixed float  m_hp3[5];               //        damage parameter x
            public fixed float  m_hp4[5];               //        damage parameter y
            public fixed float  m_hp5[5];               // [   3] crack direction 1
            public fixed float  m_hp6[5];               // [   3] crack direction 2
            public fixed float  m_hp7[5];               // [   9] accumulated temperature strain
            public fixed float  m_hp8[5];               //        internal damage parameter shrinkage
            public fixed float  m_hp9[5];               // [   9] accumulated shrinkage strain
            public fixed float  m_hp10[5];              //        damage parameter xy
            public fixed float  m_hp11[5];              // [   9] epsx  strain in stress strain curve
            public fixed float  m_hp12[5];              // [   9] epsy  strain in stress strain curve
            public fixed float  m_hp13[5];              // [1215] layer temperature in case of fire analysis
            public fixed float  m_hp14[5];              // [1215] max. layer temperature in load history
      } // cs_quad_rla

      public unsafe struct cs_quad_rlb_sg               //        results in GAUSS-points
      {
            public float  m_sig1;                       // [1092] 
            public float  m_sig2;                       // [1092] 
            public float  m_eps1;
            public float  m_xi1;
            public float  m_xi2;
            public float  m_eps2;
      } // cs_quad_rlb_sg

      public unsafe struct cs_quad_rlb                  //        225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
      {
            public int  m_nr;                           //        Elementnumber
            public int  m_mnr;                          //        MNR=-1 identifier for reinforcement data
            public float  m_xi;                         //        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
            public float  m_sig1;                       // [1092] stress in reinforcement 1. layer
            public float  m_sig2;                       // [1092] stress in reinforcement 2. layer
            public float  m_eps1;                       //        eps strain in stress strain curve 1. layer
            public float  m_xi1;                        //        exact xi position 1. layer
            public float  m_xi2;                        //        exact xi position 2. layer
            public float  m_eps2;                       //        eps strain in stress strain curve 2. layer
            public cs_quad_rlb_sg  m_sg;                //        results in GAUSS-points
            public fixed float  m_hp1[5];               //        damage parameter 1. layer
            public fixed float  m_hp2[5];               //        damage parameter 2. layer
            public fixed float  m_hp3[5];               // [1092] delta-sigma tension stiff. layer 1
            public fixed float  m_hp4[5];               // [1092] delta-sigma tension stiff. layer 2
            public fixed float  m_hp5[5];               //        direction of reinforcement layer 1
            public fixed float  m_hp6[5];               //        direction of reinforcement layer 2
            public fixed float  m_hp7[5];               // [   9] accumulated temperature strain
            public fixed float  m_hp8[5];               //        free
            public fixed float  m_hp9[5];               //        free
            public fixed float  m_hp10[5];              // [1215] layer 1 actual temperature in case of fire analysis
            public fixed float  m_hp11[5];              // [1215] layer 2 actual temperature in case of fire analysis
      } // cs_quad_rlb

      public unsafe struct cs_quad_sec                  //        229/LC:0  maximum Quad-sectional stress
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] normalstress
            public float  m_sigy;                       // [1092] transverse stress
            public float  m_sigz;                       // [1092] transverse stress
            public float  m_tauxy;                      // [1092] shear stress
            public float  m_tauxz;                      // [1092] shear stress
            public float  m_tauyz;                      // [1092] shear stress
      } // cs_quad_sec

      public unsafe struct cs_quad_seq                  //        229/LC:-  location of sectional results in master
      {
            public int  m_nr;                           //        negative beam number
            public float  m_x;                          // [1001] section along beam
      } // cs_quad_seq

      public unsafe struct cs_quad_ser                  //        229/LC:+  stresses of sectional Quad-elements
      {
            public int  m_nr;                           //        Elementnumber
            public float  m_sigx;                       // [1092] normalstress
            public float  m_sigy;                       // [1092] transverse stress
            public float  m_sigz;                       // [1092] transverse stress
            public float  m_tauxy;                      // [1092] shear stress
            public float  m_tauxz;                      // [1092] shear stress
            public float  m_tauyz;                      // [1092] shear stress
      } // cs_quad_ser

      public unsafe struct cs_quad_rts                  //        230/LC  tendon stresses in two integration points
      {
            public int  m_nr;                           //        elementnumber
            public int  m_nrs;                          //        tendonnumber
            public float  m_sigz;                       // [1092] stress increment
            public float  m_zz;                         // [1025] force in tendon
            public float  m_zh;                         // [1025] sheath deduct. force
            public float  m_szg1;                       // [1092] stress in G-point 1
            public float  m_szg2;                       // [1092] stress in G-point 2
            public float  m_zzx1;                       // [1025] force tendon+cement1
            public float  m_zzx2;                       // [1025] force tendon+cement1
            public float  m_zhg1;                       // [1025] sheath deduct.  G1
            public float  m_zhg2;                       // [1025] sheath deduct.  G2
            public float  m_zzg1;                       // [1025] force in tendon G1
            public float  m_zzg2;                       // [1025] force in tendon G2
            public float  m_age;                        // [  93] age since prestress
            public float  m_relz;                       //        accumulated relaxation
            public float  m_tzg1;                       // [1215] temperature tendon G1
            public float  m_tzg2;                       // [1215] temperature tendon G2
            public float  m_thg1;                       // [1215] temperature tendon duct G1
            public float  m_thg2;                       // [1215] temperature tendon duct G2
      } // cs_quad_rts

      public unsafe struct cs_quad_dst                  //        250/DC  design stresses in Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_smio;                       // [1092] minimum upside main stress
            public float  m_smao;                       // [1092] maximum upside main stress
            public float  m_smiu;                       // [1092] minimum downside main stress
            public float  m_smau;                       // [1092] maximum downside main stress
            public float  m_taum;                       // [1092] maximum shear stress
            public float  m_svma;                       // [1092] maximum reference stress
            public float  m_svo;                        // [1092] maximum reference stress upside
            public float  m_svu;                        // [1092] maximum reference stress downside
            public fixed float  m_reserved[7];          //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_quad_dst

      public unsafe struct cs_quad_nds                  //        251/DC  design stresses in Quad-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public float  m_smio;                       // [1092] minimum upside main stress Minimale Hauptspannung oben
            public float  m_smao;                       // [1092] maximum upside main stress Maximale Hauptspannung oben
            public float  m_smiu;                       // [1092] minimum downside main stress Minimale Hauptspannung unten
            public float  m_smau;                       // [1092] maximum downside main stress Maximale Hauptspannung unten
            public float  m_taum;                       // [1092] maximum shear stress
            public float  m_svma;                       // [1092] maximum reference stress
            public float  m_svo;                        // [1092] maximum reference stress upside
            public float  m_svu;                        // [1092] maximum reference stress downside
            public fixed float  m_reserved[7];          //        reserved for future usage
            public fixed int m_text[17];                //        Designation of designcase
      } // cs_quad_nds

      public unsafe struct cs_quad_ric                  //        260/DC:0  maximum reinforcement in Quad-elements
      {
            public int  m_nr;                           //        ident 0
            public float  m_aso;                        // [1021] upside reinforcement (outside)
            public float  m_asoq;                       // [1021] upside cross reinforcement (middle)
            public float  m_asu;                        // [1021] downside reinforcement (outside)
            public float  m_asuq;                       // [1021] downside cross reinforcement (middle)
            public float  m_asoi;                       // [1021] upside third reinforcement (inside)
            public float  m_asui;                       // [1021] downside third reinforcement (inside)
            public float  m_ass;                        // [1022] stirrup cm2/m2
            public float  m_asse;                       // [1020] stirrup cm2
            public float  m_tau0;                       // [1092] design shear stress (shear force)
            public float  m_sixo;                       // [1030] upside reinforcement quantity
            public float  m_sixu;                       // [1030] downside reinforcement quantity
            public float  m_sixs;                       // [1030] shear reinforcement quantity
            public fixed float  m_free0[3];             //        not yet used
            public float  m_zmin;                       // [1001] minimum lever arm
            public float  m_vedr;                       //        max. VED/VRDMAX
            public float  m_cott;                       //        max. cot_theta
            public float  m_ved;                        //        max. VED
            public float  m_free;                       //        not yet used
            public fixed float  m_sdo[3];               // [1092] upside stress range (outside)
            public fixed float  m_sdu[3];               // [1092] downside stress range (inside)
            public float  m_sdv;                        // [1092] stirrup stress range
            public fixed float  m_sso[3];               // [1092] maximum stell stress upside (outside)
            public fixed float  m_ssu[3];               // [1092] maximum stell stress downside(inside)
            public float  m_ssv;                        // [1092] maximum stirrup stress (not yet used)
            public float  m_sigbo;                      // [1092] maximum concrete pressure upside (outside)
            public float  m_sigbu;                      // [1092] maximum concrete pressure downside(inside)
            public float  m_shzmax;                     //        maximum skew principal tensile stress
            public float  m_shzx;                       //        max. skew principal tensile stress in local x
            public float  m_shzy;                       //        max. skew principal tensile stress in local y
            public float  m_free40;                     //        not yet used
            public fixed float  m_asbend[6];            // [1021] Info reinforcement bending design only
            public fixed float  m_asplus[6];            // [1021] Info reinforcement if increased due to shear
            public fixed float  m_asposs[6];            // [1021] Info reinforcement to satisfy shear without stirrups
            public fixed float  m_bmom[6];              // [1114] Design bending moment in direction of reinforcement
            public fixed float  m_origin[7];            //        bitpattern of origins of maximum reinforcements
            public fixed float  m_deco[2];              // [   9] decompression strain in the direction of tendons
            public fixed float  m_reserved[10];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of designcase
      } // cs_quad_ric

      public unsafe struct cs_quad_rei                  //        260/DC:+  reinforcement in Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_aso;                        // [1021] upside reinforcement (outside)
            public float  m_asoq;                       // [1021] upside cross reinforcement (middle)
            public float  m_asu;                        // [1021] downside reinforcement (outside)
            public float  m_asuq;                       // [1021] downside cross reinforcement (middle)
            public float  m_asoi;                       // [1021] upside third reinforcement (inside)
            public float  m_asui;                       // [1021] downside third reinforcement (inside)
            public float  m_ass;                        // [1022] stirrup cm2/m2
            public float  m_asse;                       // [1020] stirrup cm2
            public float  m_tau0;                       // [1092] design shear stress (shear force)
            public float  m_rio;                        //        direction of upside reinforcement
            public float  m_rioq;                       //        direction of upside cross reinforcement
            public float  m_riu;                        //        direction of downside reinforcement
            public float  m_riuq;                       //        direction of downside cross reinforcement
            public float  m_rioi;                       //        direction of upside third reinforcement
            public float  m_riui;                       //        direction of downside third reinforcement
            public float  m_zmin;                       // [1001] minimum lever arm (ULS design)
            public float  m_vedr;                       //        max. VED/VRDMAX (ULS design)
            public float  m_cott;                       //        max. cot_theta (ULS design)
            public float  m_ved;                        //        max. VED (ULS design)
            public float  m_vm;                         // [1001] shift rule
            public fixed float  m_sdo[3];               // [1092] upside stress range (outside)
            public fixed float  m_sdu[3];               // [1092] downside stress range (inside)
            public float  m_sdv;                        // [1092] stirrup stress range
            public fixed float  m_sso[3];               // [1092] maximum stell stress upside (outside)
            public fixed float  m_ssu[3];               // [1092] maximum stell stress downside(inside)
            public float  m_ssv;                        // [1092] maximum stirrup stress (not yet used)
            public float  m_sigbo;                      // [1092] maximum concrete pressure upside (outside)
            public float  m_sigbu;                      // [1092] maximum concrete pressure downside(inside)
            public float  m_shzmax;                     //        maximum skew principal tensile stress (SLS uncracked)
            public float  m_shzx;                       //        max. skew principal tensile stress in local x
            public float  m_shzy;                       //        max. skew principal tensile stress in local y
            public float  m_free40;                     //        not yet used
            public fixed float  m_asbend[6];            // [1021] Info reinforcement bending design only (ULS design)
            public fixed float  m_asplus[6];            // [1021] Info reinforcement if increased due to shear (ULS design)
            public fixed float  m_asposs[6];            // [1021] Info reinforcement to satisfy shear without stirrups (ULS)
            public fixed float  m_bmom[6];              // [1114] Design bending moment in direction of reinforcement
            public fixed float  m_origin[7];            //        origin of maximum reinforcement:
            public fixed float  m_deco[2];              // [   9] decompression strain in the direction of tendons
      } // cs_quad_rei

      public unsafe struct cs_quad_nrc                  //        261/DC:0  maximum reinforcement in Quad-nodes
      {
            public int  m_nr;                           //        ident 0
            public int  m_ng;                           //        ident 0
            public float  m_aso;                        // [1021] upside reinforcement (outside)
            public float  m_asoq;                       // [1021] upside cross reinforcement (middle)
            public float  m_asu;                        // [1021] downside reinforcement (outside)
            public float  m_asuq;                       // [1021] downside cross reinforcement (middle)
            public float  m_asoi;                       // [1021] upside third reinforcement (inside)
            public float  m_asui;                       // [1021] downside third reinforcement (inside)
            public float  m_ass;                        // [1022] stirrup cm2/m2
            public float  m_i_8;                        //        reserved 0.0
            public float  m_tau0;                       // [1092] design shear stress (shear force)
            public fixed float  m_free0[6];             //        not yet used
            public float  m_zmin;                       // [1001] minimum lever arm
            public float  m_vedr;                       //        max. VED/VRDMAX
            public float  m_cott;                       //        max. cot_theta
            public float  m_ved;                        //        max. VED
            public float  m_free;                       //        not yet used
            public fixed float  m_sdo[3];               // [1092] upside stress range (outside)
            public fixed float  m_sdu[3];               // [1092] downside stress range (inside)
            public float  m_sdv;                        // [1092] stirrup stress range
            public fixed float  m_sso[3];               // [1092] maximum stell stress upside (outside)
            public fixed float  m_ssu[3];               // [1092] maximum stell stress downside(inside)
            public float  m_ssv;                        // [1092] maximum stirrup stress (not yet used)
            public float  m_sigbo;                      // [1092] maximum concrete pressure upside (outside)
            public float  m_sigbu;                      // [1092] maximum concrete pressure downside(inside)
            public float  m_shzmax;                     //        maximum skew principal tensile stress
            public float  m_shzx;                       //        max. skew principal tensile stress in local x
            public float  m_shzy;                       //        max. skew principal tensile stress in local y
            public float  m_free40;                     //        not yet used
            public fixed float  m_asbend[6];            // [1021] Info reinforcement bending design only
            public fixed float  m_asplus[6];            // [1021] Info reinforcement if increased due to shear
            public fixed float  m_asposs[6];            // [1021] Info reinforcement to satisfy shear without stirrups
            public fixed float  m_bmom[6];              // [1114] Design bending moment in direction of reinforcement
            public fixed float  m_origin[7];            //        bitpattern of origins of maximum reinforcements
            public fixed float  m_deco[2];              // [   9] decompression strain in the direction of tendons
            public fixed float  m_reserved[10];         //        reserved for future usage
            public fixed int m_text[17];                //        Designation of Designcase
      } // cs_quad_nrc

      public unsafe struct cs_quad_nri                  //        261/DC:Z+  reinforcement in Quad-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public float  m_aso;                        // [1021] upside reinforcement (outside)
            public float  m_asoq;                       // [1021] upside cross reinforcement (middle)
            public float  m_asu;                        // [1021] downside reinforcement (outside)
            public float  m_asuq;                       // [1021] downside cross reinforcement (middle)
            public float  m_asoi;                       // [1021] upside third reinforcement (inside)
            public float  m_asui;                       // [1021] downside third reinforcement (inside)
            public float  m_ass;                        // [1022] stirrup cm2/m2
            public float  m_i_8;                        //        reserved 0.0
            public float  m_tau0;                       // [1092] design shear stress (shear force)
            public float  m_rio;                        //        direction of upside reinforcement
            public float  m_rioq;                       //        direction of upside cross reinforcement
            public float  m_riu;                        //        direction of downside reinforcement
            public float  m_riuq;                       //        direction of downside cross reinforcement
            public float  m_rioi;                       //        direction of upside third reinforcement
            public float  m_riui;                       //        direction of downside third reinforcement
            public float  m_zmin;                       // [1001] minimum lever arm
            public float  m_vedr;                       //        max. VED/VRDMAX
            public float  m_cott;                       //        max. cot_theta
            public float  m_ved;                        //        max. VED
            public float  m_free;                       //        not yet used
            public fixed float  m_sdo[3];               // [1092] upside stress range (outside)
            public fixed float  m_sdu[3];               // [1092] downside stress range (inside)
            public float  m_sdv;                        // [1092] stirrup stress range
            public fixed float  m_sso[3];               // [1092] maximum stell stress upside (outside)
            public fixed float  m_ssu[3];               // [1092] maximum stell stress downside(inside)
            public float  m_ssv;                        // [1092] maximum stirrup stress (not yet used)
            public float  m_sigbo;                      // [1092] maximum concrete pressure upside (outside)
            public float  m_sigbu;                      // [1092] maximum concrete pressure downside(inside)
            public float  m_shzmax;                     //        maximum skew principal tensile stress
            public float  m_shzx;                       //        max. skew principal tensile stress in local x
            public float  m_shzy;                       //        max. skew principal tensile stress in local y
            public float  m_free40;                     //        not yet used
            public fixed float  m_asbend[6];            // [1021] Info reinforcement bending design only
            public fixed float  m_asplus[6];            // [1021] Info reinforcement if increased due to shear
            public fixed float  m_asposs[6];            // [1021] Info reinforcement to satisfy shear without stirrups
            public fixed float  m_bmom[6];              // [1114] Design bending moment in direction of reinforcement
            public fixed float  m_origin[7];            //        origin of maximum reinforcement
            public fixed float  m_deco[2];              // [   9] decompression strain in the direction of tendons
      } // cs_quad_nri

      public unsafe struct cs_quad_nrp                  //        262/DC:+  punching reinforcement in nodes
      {
            public int  m_nr;                           //        nodenumber
            public int  m_ista;                         //        state of force
            public int  m_idus;                         //        punching state
            public float  m_u0;                         // [1001] effective length of first perimeter
            public float  m_redo;                       //        reduction factor for openings/free edges
            public float  m_v;                          // [1151] punching force
            public float  m_asl;                        // [1020] required longitudinal reinforcement
            public float  m_asv1;                       // [1022] shear reinforcement within 1st perimeter
            public float  m_asv2;                       // [1022] shear reinforcement within 2nd perimeter
            public float  m_asv3;                       // [1022] shear reinforcement within 3rd perimeter
            public float  m_asv4;                       // [1022] shear reinforcement within 4th perimeter
            public fixed float  m_free0[5];             //        not yet used
            public fixed int m_txt1[16];                //        Halfen Description 1 (30 chars require n/2+1 words)
            public fixed int m_txt2[16];                //        Halfen Description 2
            public fixed int m_txt3[16];                //        Halfen Description 3
      } // cs_quad_nrp

      public unsafe struct cs_quad_pun                  //        262/DC:0  punching periphery
      {
            public int  m_nr;                           //        identifier 0
            public int  m_id;                           //        identifier 0
            public int  m_typ;                          //        type of line
            public float  m_x1;                         // [1001] Coordinates of start point
            public float  m_y1;                         // [1001] 
            public float  m_z1;                         // [1001] 
            public float  m_x2;                         // [1001] Coordinates of end point
            public float  m_y2;                         // [1001] 
            public float  m_z2;                         // [1001] 
      } // cs_quad_pun

      public unsafe struct cs_quad_pu1                  //        262/DC:0  punching parameters
      {
            public int  m_nr;                           //        identifier 0
            public int  m_id;                           //        identifier 1
            public fixed int  m_kdust[199];             //        Integer-punching parameters
            public fixed float  m_rdust[299];           //        Real-punching parameters
      } // cs_quad_pu1

      public unsafe struct cs_quad_cfd                  //        290/LC  Fluid flow results in Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_vx;                         // [1212] velocity
            public float  m_vy;                         // [1212] velocity
            public float  m_vz;                         // [1212] velocity
            public float  m_q;                          // [1211] stream quantity
            public float  m_hopt;                       // [1001] Boundary layer
            public float  m_vxa;                        // [1212] particle velocity
            public float  m_vya;                        // [1212] particle velocity
            public float  m_vza;                        // [1212] particle velocity
            public float  m_mued;                       // [1220] laminar viscosity
            public fixed float  m_dux[2];               // [  95] gradient values of fluid flow du/dx, du/dy
            public fixed float  m_dvx[2];               // [  95] gradient values of fluid flow dv/dx, dv/dy
            public float  m_tk;                         // [1222] turbulent energy
            public float  m_muet;                       // [1220] turbulent viscosity
            public float  m_ed;                         // [1223] dissipation rate
            public fixed float  m_scalar[4];            //        optional scalar values
      } // cs_quad_cfd

      public unsafe struct cs_quad_tm                   //        291/LC:0  Maximum of Temperature Results in Quads
      {
            public int  m_nr;                           //        elementnumber
            public float  m_qx;                         // [1218] heat flux
            public float  m_qy;                         // [1218] heat flux
            public float  m_qz;                         // [1218] heat flux
            public float  m_q;                          // [1216] Total flux
            public float  m_hopt;                       // [1001] optimal mesh size
            public float  m_teff;                       // [  92] Effective Age
            public float  m_hydr;                       //        Hydration degree
            public float  m_lfr;                        //        Liquid fraction
      } // cs_quad_tm

      public unsafe struct cs_quad_tmp                  //        291/LC  Temperature Results in Quad-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_qx;                         // [1218] heat flux
            public float  m_qy;                         // [1218] heat flux
            public float  m_qz;                         // [1218] heat flux
            public float  m_q;                          // [1216] Total flux
            public float  m_hopt;                       // [1001] optimal mesh size
            public fixed float  m_teff[5];              // [  92] Effective Age
            public fixed float  m_hydr[5];              //        Hydratation degree
            public fixed float  m_lfr[5];               //        Liquid fraction
      } // cs_quad_tmp

      public unsafe struct cs_bric                      //        300/00  Bric-elements
      {
            public int  m_nr;                           //        elementnumber
            public fixed int  m_node[8];                //        nodenumbers
            public int  m_mat;                          //        materialnumber
            public int  m_nra;                          //        type of element
            public fixed float  m_det[4];               //        Values of Jacobian Determinant / Volume
      } // cs_bric

      public unsafe struct cs_bric_su                   //        300/02:0  Surfaces and Neighbours of Bric-elements
      {
            public fixed int  m_n0[4];
            public int  m_nsur;
            public int  m_mbri;                         //        max number of brics per surface
      } // cs_bric_su

      public unsafe struct cs_bric_sur                  //        300/02:+  Surfaces and Neighbours of Bric-elements
      {
            public fixed int  m_node[4];
            public int  m_ijmp;
            public int  m_nbri;
            public fixed int  m_nrel[7];                //        bric numbers for this surface
      } // cs_bric_sur

      public unsafe struct cs_bric_rim                  //        300/6  Prescribed Reinforcements of Bric-elements
      {
            public int  m_nrg;                          //        group number
            public int  m_nr;                           //        selector number
            public int  m_typ;                          //        Type of Reinforc.
            public int  m_gtyp;                         //        Type of grading
            public int  m_idra;                         //        drawing source type
            public float  m_oal;                        //        Euler Angle I reinforcement
            public float  m_oaf;                        //        Euler Angle II
            public float  m_xref;                       // [1001] Reference point for circular reinforcement
            public float  m_yref;                       // [1001] XREF+YREF allowed in combination with OAL and OAF
            public float  m_zref;                       // [1001] ZREF<>RW only allowed for OAL=OAF=0
            public fixed float  m_di[3];                // [1023] Diameter of reinforcement 1-3
            public fixed float  m_as[3];                // [1022] Minimum reinforcement 1-3
            public fixed float  m_am[3];                // [1022] Maximum reinforcement 1-3
            public fixed float  m_wk[3];                // [1026] design crack width
            public fixed float  m_sig[3];               // [1092] SLS steel stress limit
      } // cs_bric_rim

      public unsafe struct cs_bric_p                    //        300/10  Bric-P-Elements
      {
            public int  m_nr;                           //        elementnumber
            public fixed int  m_node[8];                //        nodenumbers
            public int  m_mat;                          //        materialnumber
            public fixed int  m_edge[12];               //        geometric id of edge 1-2
            public fixed int  m_face[6];                //        geometric id of face 1-2-3-4
      } // cs_bric_p

      public unsafe struct cs_bric_loa                  //        302/LC  loads of Bric-elements
      {
            public int  m_von;                          //        start elementnumber
            public int  m_bis;                          //        end elementnumber
            public int  m_del;                          //        increment
            public int  m_typ;                          //        type of load
            public int  m_lnr;                          //        primary loadcasenumber,if TYP = 18/30
            public float  m_p;                          //        load value
            public float  m_dpdx;
            public float  m_dpdy;
            public float  m_dpdz;
            public float  m_xref;                       // [1001] optional reference point for load value
            public float  m_yref;                       // [1001] 
            public float  m_zref;                       // [1001] 
      } // cs_bric_loa

      public unsafe struct cs_bric_stc                  //        310/LC:0  maximum stress in BRICs
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
            public float  m_hp1;                        //        yield function
            public float  m_hp2;                        //        volum. hardening
      } // cs_bric_stc

      public unsafe struct cs_bric_str_sg               //        results in GAUSS-points
      {
            public float  m_sigx;                       // [1092] 
            public float  m_sigy;                       // [1092] 
            public float  m_sigz;                       // [1092] 
            public float  m_tvxy;                       // [1092] 
            public float  m_tvxz;                       // [1092] 
            public float  m_tvyz;                       // [1092] 
      } // cs_bric_str_sg

      public unsafe struct cs_bric_str                  //        310/LC:+  3D-stresses in Bric-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
            public cs_bric_str_sg  m_sg;                //        results in GAUSS-points
            public fixed float  m_hp1[9];               //        yield function
            public fixed float  m_hp2[9];               //        2nd parameter as specified in headder record
            public fixed float  m_hp3[9];               //        3rd parameter as specified in headder record
            public fixed float  m_hp4[9];               //        4th parameter as specified in headder record
            public fixed float  m_hp5[9];               //        5th parameter as specified in headder record
            public fixed float  m_hp6[9];               //        6th parameter as specified in headder record
            public fixed float  m_hp7[9];               //        7th parameter as specified in headder record
            public fixed float  m_hp8[9];               //        8th parameter as specified in headder record
            public fixed float  m_hp9[9];               //        9th parameter as specified in headder record
            public fixed float  m_hp10[9];              //        10th parameter as specified in headder record
            public fixed float  m_hp11[9];              //        11th parameter as specified in headder record
            public fixed float  m_hp12[9];              //        12th parameter as specified in headder record
            public fixed float  m_hp13[9];              //        13th parameter as specified in headder record
            public fixed float  m_hp14[9];              //        14th parameter as specified in headder record
            public fixed float  m_hp15[9];              //        15th parameter as specified in headder record
      } // cs_bric_str

      public unsafe struct cs_bric_nsc                  //        311/LC:0  maximum nodal 3D stress
      {
            public int  m_ng;                           //        ident 0 for maximum (first records)
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
      } // cs_bric_nsc

      public unsafe struct cs_bric_nst                  //        311/LC:+  3D-stresses in Bric-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
            public float  m_fy;                         //        yield function
      } // cs_bric_nst

      public unsafe struct cs_bric_esc                  //        312/LC:0  max. errors of Bric-stresses
      {
            public int  m_nr;                           //        ident 0 for maximum (first records)
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
      } // cs_bric_esc

      public unsafe struct cs_bric_est                  //        312/LC:+  3D-error estimates in Bric-Elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_sigx;                       // [1092] stress
            public float  m_sigy;                       // [1092] stress
            public float  m_sigz;                       // [1092] stress
            public float  m_tvxy;                       // [1092] shear stress
            public float  m_tvxz;                       // [1092] shear stress
            public float  m_tvyz;                       // [1092] shear stress
      } // cs_bric_est

      public unsafe struct cs_bric_rei                  //        360/DC:+  reinforcement in Bric-elements
      {
            public int  m_nr;                           //        elementnumber
            public fixed float  m_as[3];                // [1022] reinforcement 1-3
            public float  m_oal;                        //        Euler Angle I
            public float  m_oaf;                        //        Euler Angle II
            public fixed float  m_sd[3];                // [1092] stress range 1-3
            public float  m_sigb;                       // [1092] maximum concrete pressure
            public float  m_shzmax;                     //        maximum skew principal tensile stress (SLS uncracked)
            public fixed float  m_origin[3];            //        origin of maximum reinforcement: as defined in 260/DC
      } // cs_bric_rei

      public unsafe struct cs_bric_nri                  //        361/DC:+  reinforcement in Bric-nodes
      {
            public int  m_ng;                           //        groupnumber
            public int  m_nr;                           //        nodenumber
            public fixed float  m_as[3];                // [1022] reinforcement 1-3
            public float  m_oal;                        //        Euler Angle I
            public float  m_oaf;                        //        Euler Angle II
            public fixed float  m_sd[3];                // [1092] stress range 1-3
            public float  m_sigb;                       // [1092] maximum concrete pressure
            public float  m_shzmax;                     //        maximum skew principal tensile stress (SLS uncracked)
            public fixed float  m_origin[3];            //        origin of maximum reinforcement: as defined in 260/DC
      } // cs_bric_nri

      public unsafe struct cs_bric_cfd                  //        390/LC  Fluid flow results in BRIC-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_vx;                         // [1212] velocity
            public float  m_vy;                         // [1212] velocity
            public float  m_vz;                         // [1212] velocity
            public float  m_q;                          // [1211] stream quantity
            public float  m_hopt;                       // [1001] optimal mesh size
            public float  m_vxa;                        // [1212] particle velocity
            public float  m_vya;                        // [1212] particle velocity
            public float  m_vza;                        // [1212] particle velocity
            public float  m_mued;                       // [1220] laminar viscosity
            public fixed float  m_dux[3];               // [  95] gradient values fluid flow du/dx, du/dy, du/dz
            public fixed float  m_dvx[3];               // [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
            public fixed float  m_dwx[3];               // [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
            public float  m_tk;                         // [1222] turbulent energy
            public float  m_muet;                       // [1220] turbulent viscosity
            public float  m_ed;                         // [1223] dissipation rate
            public fixed float  m_scalar[4];            //        optional scalar parameters
      } // cs_bric_cfd

      public unsafe struct cs_bric_tm                   //        391/LC:0  Maximum Temperature Results in BRICs
      {
            public int  m_nr;                           //        elementnumber
            public float  m_qx;                         // [1218] heat flux
            public float  m_qy;                         // [1218] heat flux
            public float  m_qz;                         // [1218] heat flux
            public float  m_q;                          // [1216] Total flux
            public float  m_teff;                       // [  92] Effective Age
            public float  m_hydr;                       //        Hydration degree
            public float  m_lfr;                        //        Liquid fraction
      } // cs_bric_tm

      public unsafe struct cs_bric_tmp                  //        391/LC  Temperature Results in BRIC-elements
      {
            public int  m_nr;                           //        elementnumber
            public float  m_qx;                         // [1218] heat flux
            public float  m_qy;                         // [1218] heat flux
            public float  m_qz;                         // [1218] heat flux
            public float  m_q;                          // [1216] Total flux
            public fixed float  m_teff[9];              // [  92] Effective Age
            public fixed float  m_hydr[9];              //        Hydration degree
            public fixed float  m_lfr[9];               //        Liquid fraction
      } // cs_bric_tmp

      public unsafe struct cs_hase_pih                  //        404/NR:0  HASE-Piles in Half-space
      {
            public int  m_id;                           //        Identification 0
            public int  m_npile;                        //        Number of piles
            public int  m_mpile;                        //        Max. values per pile
            public int  m_nhknot;                       //        Number of nodes
      } // cs_hase_pih

      public unsafe struct cs_hase_pil                  //        404/NR:+  HASE-Piles in Half-space
      {
            public int  m_enr;                          //        External node number
            public float  m_x;                          // [1001] Pile X-coordinate
            public float  m_y;                          // [1001] Pile Y-coordinate
            public float  m_df;                         // [1001] Pile-foot diameter
            public float  m_z;                          // [1001] Pile-foot coordinate
            public float  m_mant;                       //        Fraction of the total pile load transfered as a pile
            public float  m_pmam;                       // [1190] Max. load transferable by skin friction
            public int  m_inr;                          //        Ixternal node number
            public fixed int  m_bez[4];                 //        Designation
            public float  m_pmaf;                       // [1190] Max. load transferable trough pile-foot
            public float  m_zman;                       // [1001] Z-coordiante from which the skin friction is active
            public float  m_cfac;                       //        Factor of load applied as compression-only
            public float  m_plen;                       // [1001] Pile length
            public float  m_plsf;                       // [1001] Pile length part inactive for skin friction
            public float  m_d0;                         // [1001] Pile diameter
            public float  m_mnr;                        //        Pile material number
      } // cs_hase_pil

      public unsafe struct cs_seg_def                   //        900/00  Segmentdefinition
      {
            public int  m_id;                           //        Identification of segment
            public int  m_typ;                          //        Type of segment
            public int  m_bit;                          //        Bitpattern idef+4*iref
            public float  m_len;                        // [1001] Length of segment
            public float  m_alfa;                       // [   5] Angle of start face to axis (0 = match-cast)
            public float  m_alfr;                       // [   5] Angle of end   face to axis (0 = match-cast)
            public float  m_dspa;                       // [1001] Distance of start survey point
            public float  m_dspe;                       // [1001] Distance of end survey point
            public fixed int m_text[17];                //        designation of segment
      } // cs_seg_def

      public unsafe struct cs_il_ctrl0                  //        -1/NS:0  Headder of a location
      {
            public int  m_id;                           //        ID=0
            public int  m_kwerg;                        //        KWH for results to be saved
            public int  m_nerg;                         //        Count on corresponding items
            public int  m_nn;                           //        reserved
            public float  m_xabs;                       // [1001] abszissae for beam sections
            public fixed int m_txt[17];                 //        Name of location
      } // cs_il_ctrl0

      public unsafe struct cs_il_ctrl1                  //        -1/NS:?  Headder of a result
      {
            public int  m_idi;                          //        Type of result
            public int  m_ierg;                         //        index of this item + 1000*IMUNIT
            public int  m_lfmax;                        //        Offset for load case number of results for maximum
            public int  m_lfmin;                        //        Offset for load case number of results for minimum
            public float  m_lphi;                       // [1001] characteristic lenght for dynamic impact factor
            public fixed int m_txt[17];                 //        Name of item
      } // cs_il_ctrl1

      public unsafe struct cs_il_data0                  //        -1/NS:1????  Influence values (V23, obsoleted)
      {
            public int  m_idi;                          //        Type of derivatives defined
            public float  m_x;                          // [1001] abszissae along lane
            public float  m_pv;                         //        Influence value for vertical loading (z)
            public float  m_mt;                         //        Influence value for torsional loading (x-x)
            public float  m_pl;                         //        Influence value for longitudinal loading (x)
            public float  m_pt;                         //        Influence value for transverse loading (y)
            public float  m_dpv;                        //        Derivative of PV/dx (if IDI&1000)
            public float  m_dmt;                        //        Derivative of MT/dx (if IDI&0100)
            public float  m_dpl;                        //        Derivative of PL/dx (if IDI&0010)
            public float  m_dpt;                        //        Derivative of PT/dx (if IDI&0001)
      } // cs_il_data0

      public unsafe struct cs_il_data                   //        -1/NS:1??????  Influence values
      {
            public int  m_idi;                          //        Type of derivatives defined
            public float  m_x;                          // [1001] abszissae along lane
            public float  m_pv;                         //        Influence value for vertical loading (z)
            public float  m_mt;                         //        Influence value for torsional loading (x-x)
            public float  m_pl;                         //        Influence value for longitudinal loading (x)
            public float  m_pt;                         //        Influence value for transverse loading (y)
            public float  m_ppos;                       //        Influence value for vertical distributed loading
            public float  m_pneg;                       //        Influence value for vertical distributed loading
            public float  m_dpv;                        //        Derivative of PV/dx   (if IDI&100000)
            public float  m_dmt;                        //        Derivative of MT/dx   (if IDI&010000)
            public float  m_dpl;                        //        Derivative of PL/dx   (if IDI&001000)
            public float  m_dpt;                        //        Derivative of PT/dx   (if IDI&000100)
            public float  m_dppos;                      //        Derivative of PPOS/dx (if IDI&000010)
            public float  m_dpneg;                      //        Derivative of PNEG/dx (if IDI&000001)
            public float  m_rres;                       //        Influence value for right residual loading
            public float  m_lres;                       //        Influence value for left residual loading
      } // cs_il_data


}

/*   SOFiSTiK AG                             Aug  6 2014
     sofistik_daten.cs
     end of automatically generated header
*/


