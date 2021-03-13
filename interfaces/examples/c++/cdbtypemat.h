/*   SOFiSTiK AG
     cdbtypemat.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypemat_INCLUDED
#define cdbtypemat_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;
#define MAXMAT   999

#define MAT_ID 0
#define MAT_VER 200501
typedef struct tagCDB_MAT {      /* 1/NR  MaterialTitle */
int     m_id;                    /*        Identification = 0 */
int     m_type;                  /*        Material type */
#define MAT_CONS_GW 701
#define MAT_CONS_GP 702
#define MAT_CONS_GM 703
#define MAT_CONS_GC 704
#define MAT_CONS_SW 705
#define MAT_CONS_SP 706
#define MAT_CONS_SM 707
#define MAT_CONS_SC 708
#define MAT_CONS_SAND 709
#define MAT_CONS_ML 711
#define MAT_CONS_MI 712
#define MAT_CONS_MH 713
#define MAT_CONS_CL 715
#define MAT_CONS_CI 716
#define MAT_CONS_CH 717
#define MAT_CONS_CLAY 719
#define MAT_CONS_ROC1 721
#define MAT_CONS_ROC2 722
#define MAT_CONS_ROC3 723
#define MAT_CONS_ROC4 724
#define MAT_CONS_AIR 801
#define MAT_CONS_H2O 802
#define MAT_CONS_CO2 803
#define MAT_CONS_O2 804
#define MAT_CONS_N2 805
#define MAT_CONS_CH4 806
#define MAT_CONS_HE 809
#define MAT_CONS_NE 810
#define MAT_CONS_AR 811
#define MAT_CONS_KR 812
#define MAT_CONS_XE 813
#define MAT_CONS_SF6 814
#define MAT_CONS_GLAS 901
#define MAT_CONS_ESG 902
#define MAT_CONS_VSGh 903
#define MAT_CONS_VSGv 904
#define MAT_CONS_TVG 905
#define MAT_CONS_Cu 906
#define MAT_CONS_Pb 907
#define MAT_CONS_Mg 908
#define MAT_CONS_W 909
#define MAT_CONS_Zn 910
#define MAT_CONS_BRAS 911
#define MAT_CONS_BRON 912
#define MAT_CONS_BRIC 925
#define MAT_CONS_SLBR 926
#define MAT_CONS_CLIN 927
#define MAT_CONS_IGYP 930
#define MAT_CONS_GYPS 931
#define MAT_CONS_MOGY 932
#define MAT_CONS_MOCH 933
#define MAT_CONS_MOCE 934
#define MAT_CONS_ASPH 937
#define MAT_CONS_BITU 938
#define MAT_CONS_CARP 941
#define MAT_CONS_WOOL 942
#define MAT_CONS_CORK 943
#define MAT_CONS_LINO 944
#define MAT_CONS_EPOX 946
#define MAT_CONS_PHEN 947
#define MAT_CONS_PEST 948
#define MAT_CONS_ACRY 949
#define MAT_CONS_PC 950
#define MAT_CONS_PTFE 951
#define MAT_CONS_PVC 952
#define MAT_CONS_PMMA 953
#define MAT_CONS_POM 954
#define MAT_CONS_PA 955
#define MAT_CONS_PEHD 956
#define MAT_CONS_PELD 957
#define MAT_CONS_PS 958
#define MAT_CONS_PP 959
#define MAT_CONS_PUR 960
#define MAT_CONS_RUBB 961
#define MAT_CONS_NEOP 962
#define MAT_CONS_EBON 963
#define MAT_CONS_EPDM 964
#define MAT_CONS_PSUL 965
#define MAT_CONS_BUTA 966
#define MAT_CONS_SI 967
#define MAT_CONS_SILA 968
#define MAT_CONS_FOAM 973
#define MAT_CONS_FOAS 974
#define MAT_CONS_FOAU 975
#define MAT_CONS_FOAC 976
#define MAT_CONS_FOAR 977
#define MAT_CONS_FOAE 978
#define MAT_CONS_LAY 999
int     m_class;                 /*        Classification */
pckcode m_title[17];             /*        designation */
#define MAT_TITLE_LEN 32
} typeCDB_MAT;

#define MAT_USER_VER 0
typedef struct tagCDB_MAT_USER { /* 1/NR  Information on user input */
int     m_id;                    /*        Identification */
int     m_bit[32];               /*        User input for 001/NR:1 */
} typeCDB_MAT_USER;

#define MAT_FLUI_ID 1
#define MAT_FLUI_VER 200502
typedef struct tagCDB_MAT_FLUI { /* 1/NR  MaterialConstants */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Compression modulus */
float   m_nue;                   /* [1221] Kinematic Viscosity */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_rho;                   /* [1189] Density */
float   m_gamb;                  /* [1091] dead weight buyoncy */
float   m_alfa;                  /* [ 107] Temperature Elongation coefficient */
} typeCDB_MAT_FLUI;

#define MAT_CONS_ID 1
#define MAT_CONS_VER 200502
typedef struct tagCDB_MAT_CONS { /* 1/NR  MaterialConstants */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
#define MAT_CONS_LINE 0
#define MAT_CONS_MISE 1
#define MAT_CONS_MOHR 2
#define MAT_CONS_GUDE 3
#define MAT_CONS_ROCK 4
#define MAT_CONS_LADE 5
#define MAT_CONS_DUNC 6
#define MAT_CONS_HYPO 7
#define MAT_CONS_MEMB 8
#define MAT_CONS_GRAN 10
#define MAT_CONS_CAMC 11
#define MAT_CONS_UNDR 14
#define MAT_CONS_FAIL 15
#define MAT_CONS_SWEL 16
#define MAT_CONS_VMIS 17
#define MAT_CONS_DRUC 18
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_gamb;                  /* [1091] dead weight buyoncy */
float   m_alfa;                  /* [ 107] Temperature Expansion */
float   m_e90;                   /* [1090] Transvers Elasticity */
float   m_mue90;                 /*        anisotrope Poisson */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fy;                    /* [1092] effective strength */
float   m_ft;                    /* [1092] nominal strength */
float   m_p[18];                 /*        variable parameters */
} typeCDB_MAT_CONS;

#define MAT_UNDR_ID 14
#define MAT_UNDR_VER 201302
typedef struct tagCDB_MAT_UNDR { /* 1/NR  Undrained soil parameters */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_gamb;                  /* [1091] dead weight buyoncy */
float   m_alfa;                  /* [ 107] Temperature Expansion */
float   m_e90;                   /* [1090] Transvers Elasticity */
float   m_mue90;                 /*        anisotrope Poisson */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fy;                    /* [1092] effective strength */
float   m_ft;                    /* [1092] nominal strength */
float   m_p[18];                 /*        variable parameters */
} typeCDB_MAT_UNDR;

#define MAT_FAUL_ID 15
#define MAT_FAUL_VER 200501
typedef struct tagCDB_MAT_FAUL { /* 1/NR  Fault/Shear plane */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_gamb;                  /* [1091] dead weight buyoncy */
float   m_alfa;                  /* [ 107] Temperature Expansion */
float   m_e90;                   /* [1090] Transvers Elasticity */
float   m_mue90;                 /*        anisotrope Poisson */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fy;                    /* [1092] effective strength */
float   m_ft;                    /* [1092] nominal strength */
float   m_p[18];                 /*        variable parameters */
} typeCDB_MAT_FAUL;

#define MAT_SWEL_ID 16
#define MAT_SWEL_VER 200501
typedef struct tagCDB_MAT_SWEL { /* 1/NR  Swelling parameters */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_gamb;                  /* [1091] dead weight buyoncy */
float   m_alfa;                  /* [ 107] Temperature Expansion */
float   m_e90;                   /* [1090] Transvers Elasticity */
float   m_mue90;                 /*        anisotrope Poisson */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fy;                    /* [1092] effective strength */
float   m_ft;                    /* [1092] nominal strength */
float   m_p[18];                 /*        variable parameters */
} typeCDB_MAT_SWEL;

#define MAT_CONC_ID 1
#define MAT_CONC_VER 200501
typedef struct tagCDB_MAT_CONC { /* 1/NR  MaterialConcrete */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_rho;                   /* [1189] Density */
float   m_alfa;                  /* [ 107] Temperature Elongation coefficient */
float   m_e90;                   /* [1090] Elasticity modulus perpendicular */
float   m_mue90;                 /*        Poissons ratio perpendicular */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fc;                    /* [1092] effective strength */
float   m_fck;                   /* [1092] nominal strength */
float   m_ftm;                   /* [1092] mean value of tensional strength */
float   m_ftl;                   /* [1092] lower fractile of tensional strength */
float   m_ftk;                   /* [1092] upper fractile of tensional strength */
float   m_ec;                    /*        compr. failure Energy (deprecated) */
float   m_et;                    /* [ 112] tensile failure energy */
float   m_muer;                  /*        friction in the crack */
float   m_fcm;                   /* [1092] mean value of strength */
float   m_rdcl;                  /*        weight class */
float   m_fcr;                   /* [1092] calculatoric mean value of strength */
float   m_ecr;                   /* [1090] Elasticity modul for worklaw CE */
float   m_fbd;                   /* [1092] bond strength (EC2 Table. 5.1.3) */
float   m_ftd;                   /* [1092] Initial tensile strength Bemessungszugfestigkeit */
float   m_feqr;                  /* [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung */
float   m_feqt;                  /* [1092] Residual tensile strength  Restzugfestigkeit im Bruch */
float   m_fcfat;                 /* [1092] Fatigue Strength */
float   m_scms;                  /*        Material safety for the serviceability law */
float   m_scmu;                  /*        Material safety for ultimate stress strain law */
float   m_scmc;                  /*        Material safety for the calculatoric law */
} typeCDB_MAT_CONC;

#define MAT_STEE_ID 1
#define MAT_STEE_VER 200501
typedef struct tagCDB_MAT_STEE { /* 1/NR  MaterialSteel */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_rho;                   /* [1189] Density */
float   m_alfa;                  /* [ 107] Temperature Elongation coefficient */
float   m_e90;                   /* [1090] Elasticity modulus perpendicular */
float   m_mue90;                 /*        Poissons ratio perpendicular */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fy;                    /* [1092] yield stress */
float   m_ft;                    /* [1092] tensile strength */
float   m_eps;                   /* [   9] limit strain */
float   m_rel1;                  /*        Relaxation 0.55fpk */
float   m_rel2;                  /*        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC? */
float   m_r;                     /*        bond coefficient */
float   m_k1;                    /*        bondfactor EC2 */
float   m_eh;                    /* [1090] Hardening module */
float   m_fe;                    /* [1092] Proportional stress */
float   m_epse;                  /* [   9] Plastic strain */
float   m_fdyn;                  /* [1092] Dynamic strength */
float   m_fyc;                   /* [1092] compr. yield stress */
float   m_ftc;                   /* [1092] compress. strength */
float   m_tmax;                  /* [1023] max.plate thickness */
float   m_bc;                    /*        (eg. Aluminium 1.0/2.0 = "A","B" ) */
float   m_dummy[2];
float   m_scms;                  /*        Material safety for the serviceability law */
float   m_scmu;                  /*        Material safety for ultimate stress strain law */
float   m_scmc;                  /*        Material safety for the calculatoric law */
} typeCDB_MAT_STEE;

#define MAT_TIMB_ID 1
#define MAT_TIMB_VER 200501
typedef struct tagCDB_MAT_TIMB { /* 1/NR  MaterialTimber */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Material type */
int     m_class;                 /*        Classification */
float   m_emod;                  /* [1090] Elasticity Modulus along the fibres */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] nominal weight */
float   m_rho;                   /* [1189] Density */
float   m_alfa;                  /* [ 107] Temperature Elongation coefficient */
float   m_e90;                   /* [1090] Elasticity modulus perpendicular to fibres */
float   m_mue90;                 /*        Poissons ratio perpendicular */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fyb;                   /* [1092] Bending strength */
float   m_fyt;                   /* [1092] tensile strength along the fibres */
float   m_fyt90;                 /* [1092] tensile strength perpend. the fibres */
float   m_fyc;                   /* [1092] compressive strength along the fibres */
float   m_fyc90;                 /* [1092] compressive strength perpend. the fibres */
float   m_fys;                   /* [1092] middle shear strength (Membrane Shear force) */
float   m_fyst;                  /* [1092] edge shear strength (Torsion) */
float   m_fysb;                  /* [1092] maximum shear strength (plate shear) */
float   m_fyb90;                 /* [1092] Bending strength perpendicular to fibres */
float   m_g90;                   /* [1090] transverse shear modulus for platebending */
float   m_smod0;                 /*        Strength Modifier kmod for Service classes */
float   m_smod1;                 /*        Strength Modifier kmod for Service classes */
float   m_smod2;                 /*        Strength Modifier kmod for Service classes */
float   m_smod3;                 /*        Strength Modifier kmod for Service classes */
float   m_smod4;                 /*        Strength Modifier kmod for Service classes */
float   m_kdef;                  /*        Deformation modifier */
float   m_tmax;                  /* [1023] max.plate thickness */
float   m_scms;                  /*        Material safety */
float   m_scmu;                  /*        Material safety */
float   m_scmc;                  /*        Material safety */
} typeCDB_MAT_TIMB;

#define MAT_BRIC_ID 1
#define MAT_BRIC_VER 200501
typedef struct tagCDB_MAT_BRIC { /* 1/NR  MaterialBrickwork */
int     m_id;                    /*        Identification */
int     m_type;                  /*        Bric type and strength */
int     m_class;                 /*        Mortar class */
float   m_emod;                  /* [1090] Elasticity Modulus */
float   m_mue;                   /*        Poissons ratio */
float   m_gmod;                  /* [1090] Shear modulus */
float   m_kmod;                  /* [1090] Compression modulus */
float   m_gam;                   /* [1091] dead weight */
float   m_rho;                   /* [1189] Density */
float   m_alfa;                  /* [ 107] Temperature Elongation coefficient */
float   m_e90;                   /* [1090] Elasticity modulus perpendicular */
float   m_mue90;                 /*        Poissons ratio perpendicular */
float   m_alf;                   /* [   5] Euler Angle I */
float   m_bet;                   /* [   5] Euler Angle II */
float   m_scm;                   /*        Material safety */
float   m_fk;                    /* [1092] Strength */
float   m_fb;                    /* [1092] brick strength */
float   m_ft;                    /* [1092] tensile strength */
float   m_fv;                    /* [1092] shear strength */
float   m_fv0;                   /* [1092] adhesional strength */
float   m_fbt;                   /* [1092] tens.brick strength */
float   m_fm;                    /* [1092] mortar strength */
float   m_dummy[10];
float   m_scms;                  /*        Material safety */
float   m_scmu;                  /*        Material safety */
float   m_scmc;                  /*        Material safety */
} typeCDB_MAT_BRIC;

#define MAT_SERV_ID 2
#define MAT_SERV_VER 200501
typedef struct tagCDB_MAT_SERV { /* 1/NR  StressStrainLaw (Servicability) */
int     m_id;                    /*        Identification */
int     m_temp;                  /*        Temperature */
int     m_type;                  /*        Type of law */
float   m_scm;                   /*        Safety factor */
float   m_eps;                   /* [   9] Elongation at TEMP if TEMP>0 */
float   m_res1;                  /* [   9] Shift of strains TEMP>0 (-TempStrain) */
float   m_res2;                  /*        Tensile Strength  Concrete   for 21:24 */
float   m_arb[20][5];            /*        Function values */
} typeCDB_MAT_SERV;

#define MAT_ULTI_ID 3
#define MAT_ULTI_VER 200501
typedef struct tagCDB_MAT_ULTI { /* 1/NR  StressStrainLaw (Ultimate Limit state) */
int     m_id;                    /*        Identification */
int     m_temp;                  /*        Temperature */
int     m_type;                  /*        Type of law */
float   m_scm;                   /*        Safety factor */
float   m_eps;                   /* [   9] Elongation at TEMP if TEMP>0 */
float   m_res1;                  /* [   9] Shift of strains TEMP>0 (-TempStrain) */
float   m_res2;                  /*        Tensile Strength  Concrete   for 21:24 */
float   m_arb[20][5];            /*        Function values */
} typeCDB_MAT_ULTI;

#define MAT_NONL_ID 4
#define MAT_NONL_VER 200501
typedef struct tagCDB_MAT_NONL { /* 1/NR  StressStrainLaw (Nonlinear Mean Values) */
int     m_id;                    /*        Identification */
int     m_temp;                  /*        Temperature */
int     m_type;                  /*        Type of law */
float   m_scm;                   /*        Safety factor */
float   m_eps;                   /* [   9] Elongation at TEMP if TEMP>0 */
float   m_res1;                  /* [   9] Shift of strains TEMP>0 (-TempStrain) */
float   m_res2;                  /*        Tensile Strength  Concrete   for 21:24 */
float   m_arb[20][5];            /*        Function values */
} typeCDB_MAT_NONL;

#define MAT_BED_ID 7
#define MAT_BED_VER 200501
typedef struct tagCDB_MAT_BED {  /* 1/NR  MaterialBedding */
int     m_id;                    /*        Identification */
int     m_mnr;                   /*        Materialnumber of bedding boddy */
int     m_ibt;                   /*        Type of bedding mechanism */
float   m_c;                     /* [1097] Bedding Coefficient */
float   m_ct;                    /* [1097] Tangential Bedding */
float   m_riss;                  /* [1092] rupture stress */
float   m_flie;                  /* [1092] yield   stress */
float   m_mue;                   /*        friction coefficient */
float   m_koh;                   /* [1092] cohesion */
float   m_dil;                   /*        dilatancy coeffic. */
float   m_gam;                   /* [1184] mass of bedding */
float   m_h;                     /* [1001] reference length */
} typeCDB_MAT_BED;

#define MAT_LAY_ID 8
#define MAT_LAY_VER 200501
typedef struct tagCDB_MAT_LAY {  /* 1/NR  MaterialLayerStructure */
int     m_id;                    /*        Identification */
int     m_nm;                    /*        Number of a material */
int     m_i_2;
float   m_t;                     /* [1010] Thickness */
} typeCDB_MAT_LAY;

#define MAT_HYD_ID 9
#define MAT_HYD_VER 200501
typedef struct tagCDB_MAT_HYD {  /* 1/NR  MaterialConductivity */
int     m_id;                    /*        Identification */
int     m_t;                     /*        Temperature / pressure */
int     m_type;                  /*        Type of Material law */
#define MAT_HYD_FLOW -1
#define MAT_HYD_DARC 0
#define MAT_HYD_ADARC 1
#define MAT_HYD_FORC 2
#define MAT_HYD_MISS 3
#define MAT_HYD_FOUR 4
#define MAT_HYD_AFOUR 5
#define MAT_HYD_EC4S 6
#define MAT_HYD_EC4C 7
#define MAT_HYD_JONA 16
#define MAT_HYD_HSCM 17
#define MAT_HYD_WESC 18
float   m_d;                     /*        special Parameter */
float   m_c;                     /*        Storage Capacity */
float   m_n;                     /*        Porosity/humidity */
float   m_k[6];                  /*        Conductivity */
float   m_kloc[6];               /*        Conductivity */
} typeCDB_MAT_HYD;

#define MAT_SPE_ID 90
#define MAT_SPE_VER 200501
typedef struct tagCDB_MAT_SPE {  /* 1/NR  MaterialSpecial */
int     m_id;                    /*        Identification = 90 */
int     m_type;                  /*        type of material value */
chr     m_exp;                   /*        exposition class identifier (0=all classes) */
float   m_rval[32];              /*        real material values */
} typeCDB_MAT_SPE;

#define BORE_ID 0
#define BORE_VER 201407
typedef struct tagCDB_BORE {     /* 2/NR  SoilProfile */
int     m_id;                    /*        identifier 0 (always the first record) */
float   m_x;                     /* [1001] X_ordinate */
float   m_y;                     /* [1001] Y_ordinate */
float   m_z;                     /* [1001] Z_ordinate */
float   m_dx;                    /*        direction of axis */
float   m_dy;                    /*        direction of axis */
float   m_dz;                    /*        direction of axis */
float   m_alf;                   /* [   5] Angle of reference */
float   m_hgwl;                  /* [1006] lower ground water level */
float   m_hgwh;                  /* [1006] upper ground water level */
float   m_i_10[6];
pckcode m_text[17];              /*        Designation of Profile */
#define BORE_TEXT_LEN 32
} typeCDB_BORE;

#define BORE_LAY_ID 1
#define BORE_LAY_VER 201011
typedef struct tagCDB_BORE_LAY { /* 2/NR  Soillayer */
int     m_id;                    /*        Identifier 1 */
int     m_mnr;                   /*        Material number */
int     m_vari;                  /*        Type of stiffness variation */
int     m_ilay;                  /*        Additional layer information */
int     m_i_4;                   /*        reserved */
int     m_i_5;                   /*        reserved */
float   m_s;                     /* [1001] Ordinate on bore profile axis (positive) */
float   m_es;                    /* [1096] Stiffness Modulus */
float   m_des;                   /* [1096] Increment of ES within current layer */
float   m_mue;                   /*        Poissons ratio */
float   m_pmax;                  /* [1096] Max. pressure at pile foot */
float   m_pmal;                  /* [1096] Max. lateral pressure */
float   m_c;                     /* [1096] Cohesion */
float   m_phi;                   /* [   5] Soil/Pile friction angle */
float   m_gam;                   /* [1091] nominal weight */
float   m_gamb;                  /* [1091] nominal weight under buoyancy */
} typeCDB_BORE_LAY;

#define BORE_TAB_ID 10
#define BORE_TAB_VER 201407
typedef struct tagCDB_BORE_TAB { /* 2/NR  SoilTabdefinition */
int     m_id;                    /*        Identifier 10 */
int     m_opt;                   /*        Option */
int     m_class;                 /*        Classification subtype */
float   m_facs;                  /*        Factor on stresses */
float   m_b[10];                 /* [1001] Width of foundation */
} typeCDB_BORE_TAB;

#define BORE_TAD_ID 11
#define BORE_TAD_VER 201407
typedef struct tagCDB_BORE_TAD { /* 2/NR  SoilTabvalues */
int     m_id;                    /*        Identifier 11 */
int     m_i_1;                   /*        reserved */
int     m_i_2;                   /*        reserved */
float   m_d;                     /* [1006] Embedment depth of foundation */
float   m_sigd[10];              /* [1089] design stresses at specified depth values */
} typeCDB_BORE_TAD;

#define BORE_BAX_ID 1001
#define BORE_BAX_VER 201004
typedef struct tagCDB_BORE_BAX { /* 2/NR  BoreProfileAxial */
int     m_id;                    /*        identifier 1001 */
float   m_z1;                    /*        parameter s on start */
float   m_z2;                    /*        parameter s on end */
float   m_k0;                    /* [1096] constant bedding */
float   m_k1;                    /* [1096] parabolic bedding */
float   m_k2;                    /* [1096] linear bedding */
float   m_k3;                    /* [1096] quadratic bedding */
float   m_m0;                    /* [1153] cohesive loading */
float   m_c0;                    /* [1153] cohesion */
float   m_tanr;                  /*        friction angle */
float   m_tand;                  /*        dilatancy angle */
float   m_kq;                    /*        pressure coefficient */
float   m_pmax;                  /* [1101] maxforce at pile foot */
} typeCDB_BORE_BAX;

#define BORE_BLA_ID 1002
#define BORE_BLA_VER 200501
typedef struct tagCDB_BORE_BLA { /* 2/NR  BoreProfileTransverse */
int     m_id;                    /*        identifier 1002 */
float   m_z1;                    /*        parameter s on start */
float   m_z2;                    /*        parameter s on end */
float   m_k0;                    /* [1096] constant bedding */
float   m_k1;                    /* [1096] parabolic bedding */
float   m_k2;                    /* [1096] linear bedding */
float   m_k3;                    /* [1096] quadratic bedding */
float   m_f0;                    /*        peripher Distribution */
float   m_f1;
float   m_f2;
float   m_pm1;                   /* [1153] maximum value on upper ordinate */
float   m_pm2;                   /* [1153] maximum value on lower ordinate */
float   m_p0;                    /*        peripher Distribution */
float   m_p1;
float   m_p2;
float   m_p3;
} typeCDB_BORE_BLA;

#define BORE_BAM_ID 1003
#define BORE_BAM_VER 200501
typedef struct tagCDB_BORE_BAM { /* 2/NR  BoreProfileMoment */
int     m_id;                    /*        identifier 1003 */
float   m_z1;                    /*        parameter s on start */
float   m_z2;                    /*        parameter s on end */
float   m_k0;                    /* [1099] constant bedding */
float   m_k1;                    /* [1099] parabolic bedding */
float   m_k2;                    /* [1099] linear bedding */
float   m_k3;                    /* [1099] quadratic bedding */
} typeCDB_BORE_BAM;

#define BORE_DYA_ID 1011
#define BORE_DYA_VER 200601
typedef struct tagCDB_BORE_DYA { /* 2/NR  BoreProfileAxialDynamic */
int     m_id;                    /*        identifier 1011 */
float   m_z1;                    /*        parameter s on start */
float   m_z2;                    /*        parameter s on end */
float   m_d0;                    /* [ 105] constant damping */
float   m_d1;                    /* [ 105] parabolic damping */
float   m_d2;                    /* [ 105] linear damping */
float   m_d3;                    /* [ 105] quadratic damping */
} typeCDB_BORE_DYA;

#define BORE_DYL_ID 1012
#define BORE_DYL_VER 200601
typedef struct tagCDB_BORE_DYL { /* 2/NR  BoreProfileTransverseDynamic */
int     m_id;                    /*        identifier 1012 */
float   m_z1;                    /*        parameter s on start */
float   m_z2;                    /*        parameter s on end */
float   m_d0;                    /* [ 105] constant damping */
float   m_d1;                    /* [ 105] parabolic damping */
float   m_d2;                    /* [ 105] linear damping */
float   m_d3;                    /* [ 105] quadratic damping */
float   m_m0;                    /* [1181] constant soil mass */
float   m_m2;                    /* [1181] linear soil mass */
} typeCDB_BORE_DYL;

#define TEND_ID 0
#define TEND_VER 200701
typedef struct tagCDB_TEND {     /* 4/ID  Prestressing Schemes */
int     m_id0;                   /*        identifier 0 */
int     m_key;                   /*        Control bits + Info */
int     m_id2;                   /*        reserved */
pckcode m_txt[17];               /*        Main Designation of company and scheme */
#define TEND_TXT_LEN 32
} typeCDB_TEND;

#define TEND_1_ID 1
#define TEND_1_VER 200701
typedef struct tagCDB_TEND_1 {   /* 4/ID  Tendon of Prestressing Schemes */
int     m_id0;                   /*        identifier 1 */
int     m_mnr;                   /*        Material number of Prestressing Steel */
int     m_id2;                   /*        reserved */
float   m_zv;                    /* [1028] Nominal force */
float   m_az;                    /* [1020] Area of tendon */
float   m_rnli;                  /*        Number or wires */
float   m_sls;                   /* [  16] Slip at anchor */
float   m_slk;                   /* [  16] Slip at coupling */
float   m_slf;                   /* [  16] Slip at fixed end */
float   m_vls;                   /*        Loss at anchor */
float   m_vlk;                   /*        Loss at coupling */
float   m_vlf;                   /*        Loss at fixed end */
float   m_dls;                   /* [1001] Straight at anchor */
float   m_dlk;                   /* [1001] Straight at coupling */
float   m_dlf;                   /* [1001] Straight at fixed end */
float   m_di;                    /* [1023] inner diameter of duct */
float   m_da;                    /* [1023] outer diamtere of duct */
float   m_rmin;                  /* [1001] minimum radius */
float   m_beta[2];               /* [  17] unintended angles */
float   m_rmue[2];               /*        Friction coefficients */
float   m_exz;                   /* [1011] max exzentricity */
float   m_eachs;                 /* [1011] distance between */
float   m_erand;                 /* [1011] distance to outer edge */
float   m_block[8];              /*        reserved extra data */
pckcode m_txt[17];               /*        Designation of tendon */
#define TEND_1_TXT_LEN 32
} typeCDB_TEND_1;

#define TEND_2_ID 2
#define TEND_2_VER 200701
typedef struct tagCDB_TEND_2 {   /* 4/ID  Anchor of Prestressing Schemes */
int     m_id0;                   /*        identifier 2 */
int     m_id1;                   /*        Type of anchor */
int     m_typ;                   /*        Type of anchor geometry */
float   m_anker[16];             /*        Data */
pckcode m_txt[17];               /*        Designation of anchor */
#define TEND_2_TXT_LEN 32
} typeCDB_TEND_2;

#define TEND_3_ID 3
#define TEND_3_VER 200701
typedef struct tagCDB_TEND_3 {   /* 4/ID  Jack of Prestressing Schemes */
int     m_id0;                   /*        identifier 2 */
int     m_id1;                   /*        reserved */
int     m_typ;                   /*        Type of jack */
float   m_jack[16];              /*        Data */
pckcode m_txt[17];               /*        Designation of jack */
#define TEND_3_TXT_LEN 32
} typeCDB_TEND_3;


#define MAT_KWH 1
typedef union taguMAT {   /* 1/NR */
int m_id;
typeCDB_MAT m_mat;
typeCDB_MAT_USER m_mat_user;
typeCDB_MAT_FLUI m_mat_flui;
typeCDB_MAT_CONS m_mat_cons;
typeCDB_MAT_UNDR m_mat_undr;
typeCDB_MAT_FAUL m_mat_faul;
typeCDB_MAT_SWEL m_mat_swel;
typeCDB_MAT_CONC m_mat_conc;
typeCDB_MAT_STEE m_mat_stee;
typeCDB_MAT_TIMB m_mat_timb;
typeCDB_MAT_BRIC m_mat_bric;
typeCDB_MAT_SERV m_mat_serv;
typeCDB_MAT_ULTI m_mat_ulti;
typeCDB_MAT_NONL m_mat_nonl;
typeCDB_MAT_BED m_mat_bed;
typeCDB_MAT_LAY m_mat_lay;
typeCDB_MAT_HYD m_mat_hyd;
typeCDB_MAT_SPE m_mat_spe;
} typeuMAT;


#define BORE_KWH 2
typedef union taguBORE {   /* 2/NR */
int m_id;
typeCDB_BORE m_bore;
typeCDB_BORE_LAY m_bore_lay;
typeCDB_BORE_TAB m_bore_tab;
typeCDB_BORE_TAD m_bore_tad;
typeCDB_BORE_BAX m_bore_bax;
typeCDB_BORE_BLA m_bore_bla;
typeCDB_BORE_BAM m_bore_bam;
typeCDB_BORE_DYA m_bore_dya;
typeCDB_BORE_DYL m_bore_dyl;
} typeuBORE;


#define TEND_KWH 4
typedef union taguTEND {   /* 4/ID */
int m_id;
typeCDB_TEND m_tend;
typeCDB_TEND_1 m_tend_1;
typeCDB_TEND_2 m_tend_2;
typeCDB_TEND_3 m_tend_3;
} typeuTEND;


/*   SOFiSTiK AG
     cdbtypemat.h
     end of automatically generated header
*/
#endif
