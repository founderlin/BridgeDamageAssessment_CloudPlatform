/*   SOFiSTiK AG
     cdbtypesct.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypesct_INCLUDED
#define cdbtypesct_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;
#define MAXQNR   999

#define SECT_ID 0
#define SECT_VER 200501
typedef struct tagCDB_SECT {     /* 9/NR  SectionalValues (total section) */
int     m_id;                    /*        Identification */
int     m_mno;                   /*        Materialnumber of sections */
int     m_mrf;                   /*        Materialnumber of Reinforcement */
float   m_a;                     /* [1012] Area */
float   m_ay;                    /* [1012] Sheardeformation area Y */
float   m_az;                    /* [1012] Sheardeformation area Z */
float   m_it;                    /* [1014] Torsional moment of inertia */
float   m_iy;                    /* [1014] Moments of inertia y-y */
float   m_iz;                    /* [1014] Moments of inertia z-z */
float   m_iyz;                   /* [1014] Moments of inertia y-z */
float   m_ys;                    /* [1011] y-Ordinate Center of elasticity */
float   m_zs;                    /* [1011] z-Ordinate Center of elasticity */
float   m_ysc;                   /* [1011] y-Ordinate of Shear-Center */
float   m_zsc;                   /* [1011] z-Ordinate of Shear-Center */
float   m_em;                    /* [1090] Elasticity Modulus */
float   m_gm;                    /* [1090] Shear Modulus */
float   m_gam;                   /* [1091] Nominal weight */
} typeCDB_SECT;

#define SECT_EFF_ID 1
#define SECT_EFF_VER 200501
typedef struct tagCDB_SECT_EFF { /* 9/NR  SectionalValues (effective section) */
int     m_id;                    /*        Identification */
int     m_mno;                   /*        Materialnumber of sections */
int     m_mrf;                   /*        Materialnumber of Reinforcement */
float   m_a;                     /* [1012] Area */
float   m_ay;                    /* [1012] Sheardeformation area Y */
float   m_az;                    /* [1012] Sheardeformation area Z */
float   m_it;                    /* [1014] Torsional moment of inertia */
float   m_iy;                    /* [1014] Moments of inertia y-y */
float   m_iz;                    /* [1014] Moments of inertia z-z */
float   m_iyz;                   /* [1014] Moments of inertia y-z */
float   m_ys;                    /* [1011] y-Ordinate Center of elasticity */
float   m_zs;                    /* [1011] z-Ordinate Center of elasticity */
float   m_ysc;                   /* [1011] y-Ordinate of Shear-Center */
float   m_zsc;                   /* [1011] z-Ordinate of Shear-Center */
float   m_em;                    /* [1090] Elasticity Modulus */
float   m_gm;                    /* [1090] Shear Modulus */
float   m_gam;                   /* [1091] Nominal weight */
} typeCDB_SECT_EFF;

#define SECT_PAR_ID 2
#define SECT_PAR_VER 200501
typedef struct tagCDB_SECT_PAR { /* 9/NR  SectionalValues (total part of section) */
int     m_id;                    /*        Identification */
int     m_mno;                   /*        Materialnumber of sections */
int     m_mrf;                   /*        Materialnumber of Reinforcement */
float   m_a;                     /* [1012] Area */
float   m_ay;                    /* [1012] Sheardeformation area Y */
float   m_az;                    /* [1012] Sheardeformation area Z */
float   m_it;                    /* [1014] Torsional moment of inertia */
float   m_iy;                    /* [1014] Moments of inertia y-y */
float   m_iz;                    /* [1014] Moments of inertia z-z */
float   m_iyz;                   /* [1014] Moments of inertia y-z */
float   m_ys;                    /* [1011] y-Ordinate Center of elasticity */
float   m_zs;                    /* [1011] z-Ordinate Center of elasticity */
float   m_ysc;                   /* [1011] y-Ordinate of Shear-Center */
float   m_zsc;                   /* [1011] z-Ordinate of Shear-Center */
float   m_em;                    /* [1090] Elasticity Modulus */
float   m_gm;                    /* [1090] Shear Modulus */
float   m_gam;                   /* [1091] Nominal weight */
} typeCDB_SECT_PAR;

#define SECT_PEF_ID 3
#define SECT_PEF_VER 200501
typedef struct tagCDB_SECT_PEF { /* 9/NR  SectionalValues (effective part of section) */
int     m_id;                    /*        Identification */
int     m_mno;                   /*        Materialnumber of sections */
int     m_mrf;                   /*        Materialnumber of Reinforcement */
float   m_a;                     /* [1012] Area */
float   m_ay;                    /* [1012] Sheardeformation area Y */
float   m_az;                    /* [1012] Sheardeformation area Z */
float   m_it;                    /* [1014] Torsional moment of inertia */
float   m_iy;                    /* [1014] Moments of inertia y-y */
float   m_iz;                    /* [1014] Moments of inertia z-z */
float   m_iyz;                   /* [1014] Moments of inertia y-z */
float   m_ys;                    /* [1011] y-Ordinate Center of elasticity */
float   m_zs;                    /* [1011] z-Ordinate Center of elasticity */
float   m_ysc;                   /* [1011] y-Ordinate of Shear-Center */
float   m_zsc;                   /* [1011] z-Ordinate of Shear-Center */
float   m_em;                    /* [1090] Elasticity Modulus */
float   m_gm;                    /* [1090] Shear Modulus */
float   m_gam;                   /* [1091] Nominal weight */
} typeCDB_SECT_PEF;

#define SECT_ADD_ID 4
#define SECT_ADD_VER 200501
typedef struct tagCDB_SECT_ADD { /* 9/NR  SectionalValuesShear , Temperature */
int     m_id;
int     m_stype;
#define SECT_ADD_MOD 0
#define SECT_ADD_VAL 1
#define SECT_ADD_TYP 2
#define SECT_ADD_PLA 3
#define SECT_ADD_SOL 4
#define SECT_ADD_EFF 5
#define SECT_ADD_FEM 6
#define SECT_ADD_HYD 9
#define SECT_ADD_FIBRE +128
#define SECT_ADD_NEFF +512
#define SECT_ADD_INTE +1024
#define SECT_ADD_TEMP +2048
#define SECT_ADD_VARI +4096
#define SECT_ADD_REFP +8192
#define SECT_ADD_HOT +16384
int     m_mrf;                   /*        Materialnumber of Stirup-Reinforcement */
float   m_at;                    /* [ 107] Elongationkoefficient for Temperature */
float   m_ymin;                  /* [1011] Minimum Ordinate of section to center ys */
float   m_ymax;                  /* [1011] Maximum Ordinate of section to center ys */
float   m_zmin;                  /* [1011] Minimum Ordinate of section to center zs */
float   m_zmax;                  /* [1011] Maximum Ordinate of section to center zs */
float   m_tmin;                  /* [1011] minimum thickness */
float   m_tmax;                  /* [1011] maximum thickness */
float   m_wt;                    /* [1018] maximum tau for Torsion MT=1 */
float   m_wvy;                   /* [1017] maximum tau for Shear VY=1 */
float   m_wvz;                   /* [1017] maximum tau for Shear VZ=1 */
float   m_wt2;                   /* [1018] maximum tau for sekundary Torsion */
float   m_ak;                    /* [1012] kernel area for Torsion */
float   m_ayz;                   /* [1012] Shear deviation area */
float   m_ab;                    /* [1012] pure concrete area */
float   m_levy;                  /* [1011] minimum lever for cracked shear Vy */
float   m_levz;                  /* [1011] minimum lever for cracked shear Vz */
float   m_elvy;                  /* [  17] elastic shear flux for Vy = Sy-max/Iz */
float   m_elvz;                  /* [  17] elastic shear flux for Vz = Sz-max/Iy */
float   m_ymine;                 /* [1011] Minimum Ordinate of effective section */
float   m_ymaxe;                 /* [1011] Maximum Ordinate of effective section */
float   m_zmine;                 /* [1011] Minimum Ordinate of effective section */
float   m_zmaxe;                 /* [1011] Maximum Ordinate of effective section */
} typeCDB_SECT_ADD;

#define SECT_WAR_ID 5
#define SECT_WAR_VER 200501
typedef struct tagCDB_SECT_WAR { /* 9/NR  SectionalValuesWarping */
int     m_id;                    /*        Identification = 5 */
int     m_i_1;                   /*        unused */
int     m_i_2;                   /*        unused */
float   m_ayyy;                  /* [1015] Integrals on section */
float   m_ayyz;                  /* [1015] Integrals on section */
float   m_ayzz;                  /* [1015] Integrals on section */
float   m_azzz;                  /* [1015] Integrals on section */
float   m_awy;                   /* [1015] Integrals on section */
float   m_awz;                   /* [1015] Integrals on section */
float   m_awyy;                  /* [1016] Integrals on section */
float   m_awzz;                  /* [1016] Integrals on section */
float   m_cm;                    /* [1016] Warping resistance */
float   m_cms;                   /* [1014] Warping Shear resist. */
float   m_wmin;                  /* [1012] Minimum warping */
float   m_wmax;                  /* [1012] Maximum warping */
float   m_fysw;                  /* [1012] Shear VY-MT2 area */
float   m_fzsw;                  /* [1012] Shear VZ-MT2 area */
float   m_ipsc;                  /* [1014] polar inertia at SC */
} typeCDB_SECT_WAR;

#define SECT_PLA_ID 6
#define SECT_PLA_VER 200501
typedef struct tagCDB_SECT_PLA { /* 9/NR  SectionalPlasticForces */
int     m_id;                    /*        Identification = 6 */
int     m_ibc;                   /*        Buckling curve */
#define SECT_IBC_MULT 32
int     m_ib;                    /*        Control */
float   m_wpn;                   /* [1101] Normal force */
float   m_wpvy;                  /* [1102] Y-Shear force */
float   m_wpvz;                  /* [1102] Y-Shear force */
float   m_wpmt;                  /* [1103] Torsional moment */
float   m_wpmy;                  /* [1104] Bending moment My */
float   m_wpmz;                  /* [1104] Bending moment Mz */
float   m_ysp;                   /* [1001] Plastic center */
float   m_zsp;                   /* [1001] Plastic center */
float   m_wpmb;                  /* [1105] warping moment Mb */
float   m_wpt2;                  /* [1103] 2nd torsional moment */
} typeCDB_SECT_PLA;

#define SECT_DES_ID 7
#define SECT_DES_VER 200501
typedef struct tagCDB_SECT_DES { /* 9/NR  SectionalValuesDesign */
int     m_id;                    /*        Identification = 7 */
int     m_mnr;                   /*        used reference material */
int     m_ibc;                   /*        buckling curve index (see 009/NR:6) */
float   m_a;                     /* [1012] Area */
float   m_ay;                    /* [1012] Sheardeformation area Y */
float   m_az;                    /* [1012] Sheardeformation area Z */
float   m_it;                    /* [1014] Torsional moment of inertia */
float   m_iy;                    /* [1014] Moments of inertia y-y */
float   m_iz;                    /* [1014] Moments of inertia z-z */
float   m_iyz;                   /* [1014] Moments of inertia y-z */
float   m_ys;                    /* [1011] y-Ordinate Center of gravity */
float   m_zs;                    /* [1011] z-Ordinate Center of gravity */
float   m_ysc;                   /* [1011] y-Ordinate of Shear-Center */
float   m_zsc;                   /* [1011] z-Ordinate of Shear-Center */
float   m_em;                    /* [1090] Elasticity Modulus/safety */
float   m_gm;                    /* [1090] Shear Modulus/safety */
float   m_gam;                   /* [1091] Nominal weight */
} typeCDB_SECT_DES;

#define SECT_PRE_ID 8
#define SECT_PRE_VER 200501
typedef struct tagCDB_SECT_PRE { /* 9/NR  SectionalForcesPrestress */
int     m_id;                    /*        Identification = 8 */
int     m_itp;                   /*        subtype of information = 0 */
int     m_its;                   /*        source of values */
float   m_n;                     /* [1101] Normal force */
float   m_my;                    /* [1104] Bending moment My */
float   m_mz;                    /* [1104] Bending moment Mz */
float   m_ea;                    /* [1101] tangential stiffnes E*A */
float   m_eay;                   /* [1105] tangential stiffnes E*A*z*z */
float   m_eaz;                   /* [1105] tangential stiffnes E*A*y*y */
float   m_eayz;                  /* [1105] tangential stiffnes E*A*y*z */
float   m_yse;                   /* [1011] elastic tangential center ys */
float   m_zse;                   /* [1011] elastic tangential center zs */
float   m_ncm;                   /* [1101] maximum compressive force */
float   m_ntm;                   /* [1101] maximum tensile force */
} typeCDB_SECT_PRE;

#define SECT_GV_ID 8
#define SECT_GV_VER 200501
typedef struct tagCDB_SECT_GV {  /* 9/NR  SectionalGeometricValues */
int     m_id;                    /*        Identification = 8 */
int     m_itp;                   /*        subtype of information = 2 */
int     m_mno;                   /*        Materialnumber (0=total section) */
float   m_uo;                    /* [1011] outer perimeter */
float   m_ui;                    /* [1011] inner perimeter */
float   m_tmin;                  /* [1011] minimum thickness */
float   m_tmax;                  /* [1011] maximum thickness */
float   m_ktz;                   /* [   8] total weight factor */
float   m_uom;                   /* [1011] outer effect.perimeter */
float   m_uim;                   /* [1011] inner effect.perimeter */
float   m_aro;                   /* [1012] Outer total gross area */
float   m_ar;                    /* [1012] total gross area */
float   m_ipm;                   /* [1183] rotational inertia      gam*Ip  ! values to be converted * DC_M */
float   m_iym;                   /* [1183] sectional mass inertia  gam*Iy  ! values to be converted * DC_M */
float   m_izm;                   /* [1183] sectional mass inertia  gam*Iz  ! values to be converted * DC_M */
float   m_iyzm;                  /* [1183] sectional mass inertia  gam*Iyz ! values to be converted * DC_M */
float   m_ysm;                   /* [1011] true mass gravity center */
float   m_zsm;                   /* [1011] true mass gravity center */
float   m_dw;                    /* [1011] effective thickness for creep/shrinkage */
float   m_uair;                  /* [1011] air contact perimeter */
} typeCDB_SECT_GV;

#define SECT_TRA_ID 8
#define SECT_TRA_VER 201306
typedef struct tagCDB_SECT_TRA { /* 9/NR  SectionalAppliedTransformation */
int     m_id;                    /*        Identification = 8 */
int     m_itp;                   /*        subtype of information = 3 */
int     m_i_2;                   /*        not used */
float   m_alf;                   /* [   5] rotation angle */
float   m_ytf;                   /* [1011] shift in y direction */
float   m_ztf;                   /* [1011] shift in z direction */
} typeCDB_SECT_TRA;

#define SECT_LAY_ID 9
#define SECT_LAY_VER 201705
typedef struct tagCDB_SECT_LAY { /* 9/NR  SectionalReinforcementLayer  (LAY) */
int     m_id;                    /*        Identification = 9 */
int     m_mnr;                   /*        Materialnumber + 1000*No of concrete \% */
int     m_inr;                   /*        Type/number of layer */
chr     m_tnr;                   /*        Designation */
float   m_alow;                  /* [1020] Lower bound for area of layer */
float   m_ahig;                  /* [1020] Upper bound for area of layer */
float   m_asum;                  /* [1020] Sum of reference areas of layer */
float   m_afak;                  /*        maximum allowable factor of layer */
float   m_ys;                    /* [1011] center of layer */
float   m_zs;                    /* [1011] center of layer */
float   m_vas;                   /* [1020] Lower sequential total bound of layer area */
float   m_bas;                   /* [1020] Upper sequential total bound of layer area */
float   m_iy;                    /* [1014] 4th ord.areas (inertia) */
float   m_iz;                    /* [1014] 4th ord.areas (inertia) */
float   m_iyz;                   /* [1014] 4th ord.areas (inertia) */
float   m_emod;                  /* [1090] Elasticity-Modulus */
float   m_bets;                  /* [1092] yieldstress */
float   m_rl;                    /* [1011] torsional refer. length */
float   m_dmin;                  /* [1023] smallest used diameter */
float   m_dmax;                  /* [1023] largest  used diameter */
float   m_n;                     /* [1101] Normal force */
float   m_my;                    /* [1104] Bending moment My */
float   m_mz;                    /* [1104] Bending moment Mz */
float   m_ea;                    /* [1101] tangential stiffnes E*A */
float   m_eay;                   /* [1104] tangential stiffnes E*A*z */
float   m_eaz;                   /* [1104] tangential stiffnes E*A*y */
float   m_eayy;                  /* [1105] tangential stiffnes E*A*y*y */
float   m_eazz;                  /* [1105] tangential stiffnes E*A*z*z */
float   m_eayz;                  /* [1105] tangential stiffnes E*A*y*z */
float   m_nplc;                  /* [1101] maximum compressive force */
float   m_nplt;                  /* [1101] maximum tensile force */
} typeCDB_SECT_LAY;

#define SECT_REC_ID 10
#define SECT_REC_VER 201302
typedef struct tagCDB_SECT_REC { /* 9/NR  SectiontypeRectangular T-Beam (SREC) */
int     m_id;                    /*        Identification = 10 */
int     m_iq;                    /*        Identification of section */
#define SECT_REC_PLATE 0
#define SECT_REC_RECT 1
#define SECT_REC_TBEAM 2
#define SECT_REC_TTBEAM 3
#define SECT_REC_VPLAT 4
#define SECT_REC_VHREC 5
#define SECT_REC_VBREC 6
#define SECT_REC_VRECT 7
#define SECT_REC_REFPT 256
#define SECT_REC_SCLOC 8192
#define SECT_REC_IBCOFF 32768
int     m_ir;                    /*        Identification of reinforcement and origin */
#define SECT_REC_RF_CU 0
#define SECT_REC_RF_SYM 1
#define SECT_REC_RF_ASY 2
#define SECT_REC_RF_AST 3
#define SECT_REC_RF_ASB 4
#define SECT_REC_CORNER 8
#define SECT_REC_RF_TRA 64
#define SECT_REC_BUNDLE 128
#define SECT_REC_FIXLAY 256
float   m_h;                     /* [1011] total height */
float   m_b;                     /* [1011] width (of web) */
float   m_so;                    /* [1024] Boundary distance of upper reinforcement */
float   m_su;                    /* [1024] Boundary distance of lower reinforcement */
float   m_aso;                   /* [1020] reinforcement up */
float   m_asu;                   /* [1020] reinforcement down */
float   m_ho;                    /* [1011] height of plate */
float   m_bo;                    /* [1011] width  of plate */
float   m_daso;                  /* [1023] reinf. Diameter up */
float   m_dasu;                  /* [1023] reinf. Diameter dn */
float   m_fkit;                  /*        <0 = factor for torsional inertia >0 = absolut value of torsion */
float   m_fkay;                  /*        <0 = factor for shear deformation area >0 = absolut value of sh */
float   m_fkaz;                  /*        <0 = factor for shear deformation area >0 = absolut value of sh */
float   m_ysmp;                  /* [1011] explicit location of shear center */
float   m_zssmp;                 /* [1011] explicit location of shear center */
float   m_ys;                    /* [1011] explicit location of reference point */
float   m_zs;                    /* [1011] explicit location of reference point */
float   m_phib;                  /* [   5] inclination of transverse reinforcements */
float   m_beff;                  /* [1011] width of equivalent hollow section */
float   m_asbm;                  /*        Minimum shear reinf. */
float   m_a;                     /* [1011] spacing of reinforcements */
float   m_amin;                  /* [1011] minimum distance of single reinforcements */
float   m_amax;                  /* [1011] maximum distance of single reinforcements */
float   m_ss;                    /* [1024] Boundary distance of lateral reinforcement */
float   m_dass;                  /* [1023] reinf. Diameter side */
float   m_hmax;                  /* [1011] maximum mesh size for FE/fibre analysis */
float   m_betc;                  /*        friction coefficient */
float   m_mue;                   /*        friction in joint */
} typeCDB_SECT_REC;

#define SECT_ANN_ID 11
#define SECT_ANN_VER 201212
typedef struct tagCDB_SECT_ANN { /* 9/NR  SectiontypeAnnular (SCIT) */
int     m_id;                    /*        Identification = 11 */
int     m_ir;                    /*        Identification of section */
int     m_ir2;                   /*        Identification of reinforcement */
float   m_ro;                    /* [1011] outer radius */
float   m_ri;                    /* [1011] inner radius */
float   m_ros;                   /* [1011] outer reinf radius */
float   m_ris;                   /* [1011] inner reinf radius */
float   m_aso;                   /* [1020] outer reinforcement */
float   m_asi;                   /* [1020] inner reinforcement */
float   m_daso;                  /* [1023] reinf. Diameter */
float   m_amax;                  /* [1011] maximum distance of single reinforcements */
float   m_asbm;                  /* [1021] Minimum shear reinf. */
float   m_hmax;                  /* [1011] maximum mesh size for FE/fibre analysis */
float   m_fkit;                  /*        <0 = factor for torsional inertia >0 = absolut value of torsion */
float   m_fkay;                  /*        <0 = factor for shear deformation area >0 = absolut value of sh */
float   m_fkaz;                  /*        <0 = factor for shear deformation area >0 = absolut value of sh */
} typeCDB_SECT_ANN;

#define SECT_TUB_ID 11
#define SECT_TUB_VER 200501
typedef struct tagCDB_SECT_TUB { /* 9/NR  SectiontypeTube (TUBE) */
int     m_id;                    /*        Identification = 11 */
int     m_ir;                    /*        Identification of section = 2 */
int     m_ir2;                   /*        property Bit */
float   m_d;                     /* [1011] Diameter */
float   m_t;                     /* [1011] thickness of tubes */
} typeCDB_SECT_TUB;

#define SECT_CAB_ID 11
#define SECT_CAB_VER 200501
typedef struct tagCDB_SECT_CAB { /* 9/NR  SectiontypeCable (CABL) */
int     m_id;                    /*        Identification = 11 */
int     m_ir;                    /*        Identification of section = 3 */
int     m_ic;                    /*        sectiontype*256 + codeflag*64 + inlet type */
float   m_d;                     /* [1011] Diameter */
chr     m_typ[2];                /*        Literal of type */
chr     m_inl;                   /*        Literal of inlet */
float   m_nli;                   /*        no of strands */
float   m_ndr;                   /*        no of wires */
float   m_f;                     /*        fill factor */
float   m_k;                     /*        cable factor */
float   m_w;                     /*        weight factor */
float   m_ke;                    /*        loss factor */
float   m_zd;                    /* [1090] design  force */
float   m_zb;                    /* [1090] rupture force */
float   m_gam;                   /* [1188] weight */
} typeCDB_SECT_CAB;

#define SECT_PRO_ID 12
#define SECT_PRO_VER 201311
typedef struct tagCDB_SECT_PRO { /* 9/NR  SectiontypeShape (PROF) */
int     m_id;                    /*        Identification = 12 */
int     m_mno;                   /*        Materialnumber + 1000*imbedded Materialnumber */
int     m_ibit;                  /*        ityp + 64*iref + ivtp */
chr     m_typ;                   /*        type of section */
float   m_z1;                    /*        nominal first size */
float   m_z2;                    /*        nominal second size */
float   m_z3;                    /*        thickness or weight selector */
float   m_alf;                   /* [   5] rotation angle */
float   m_it;                    /* [1014] tabul.Tors.Inertia */
float   m_ysc;                   /* [1011] tabul.shear center */
float   m_zsc;                   /* [1011] tabul.shear center */
float   m_h;                     /* [1011] height */
float   m_b;                     /* [1011] width */
float   m_s;                     /* [1011] thickness of web */
float   m_t;                     /* [1011] thickness of flange */
float   m_r1;                    /* [1011] radius */
float   m_r2;                    /* [1011] radius */
float   m_yoff;                  /* [1011] y coord. offset */
float   m_zoff;                  /* [1011] z coord. offset */
float   m_cm;                    /* [1016] tabul.warp.resist. */
float   m_wmin;                  /* [1012] charact. warping 1 */
float   m_wmax;                  /* [1012] charact. warping 2 */
float   m_wt;                    /* [1018] Torsional resist. */
float   m_ay;                    /* [1012] Shear area */
float   m_az;                    /* [1012] Shear area */
chr     m_rid;                   /*        user defined ident */
float   m_wu1;                   /* [1011] bolt position 1 */
float   m_wu2;                   /* [1011] bolt position 2 */
float   m_wu3;                   /* [1011] bolt position 3 */
float   m_yref;                  /* [1011] Coordinates of */
float   m_zref;                  /* [1011] Reference point */
float   m_b2;                    /* [1011] width lower part */
float   m_t2;                    /* [1011] lower flange thick. */
chr     m_bez[8];                /*        character of shape */
float   m_vypl;                  /* [1102] plastic shear force Vy */
float   m_vzpl;                  /* [1102] plastic shear force Vz */
float   m_mtpl;                  /* [1103] plastic torsional   Mt */
float   m_mt2pl;                 /* [1103] plastic torsional   Mt2 */
float   m_mbpl;                  /* [1103] plastic warpmoment  Mb */
} typeCDB_SECT_PRO;

#define SECT_TBA_ID 18
#define SECT_TBA_VER 201509
typedef struct tagCDB_SECT_TBA { /* 9/NR  List of construction stages */
int     m_id;                    /*        Identification = 18 */
int     m_iba;                   /*        Headder of construction stages = 0 */
int     m_ibd;                   /*        Number of materials over all construction stages */
int     m_ibat[64];              /*        List of external construction stage numbers */
} typeCDB_SECT_TBA;

#define SECT_IBA_ID 18
#define SECT_IBA_VER 200501
typedef struct tagCDB_SECT_IBA { /* 9/NR  ConstructionStage (CS/BA) */
int     m_id;                    /*        Identification = 18 */
int     m_iba;                   /*        number of construction stage BIRTH */
int     m_ibd;                   /*        number of construction stage DEATH */
pckcode m_txt[17];               /*        Text */
#define SECT_IBA_TXT_LEN 32
} typeCDB_SECT_IBA;

#define SECT_TXT_ID 19
#define SECT_TXT_VER 200501
typedef struct tagCDB_SECT_TXT { /* 9/NR  SectionText */
int     m_id;                    /*        Identification = 19 */
int     m_nr;                    /*        external construction stage number for CS separator */
int     m_ids;                   /*        Source/Selector flag */
pckcode m_txt[128];              /*        Text */
#define SECT_TXT_TXT_LEN 255
} typeCDB_SECT_TXT;

#define SECT_WLS_VER 200501
typedef struct tagCDB_SECT_WLS { /* 9/NR  SectionWorklaw Serviceability Analysis */
int     m_id;                    /*        Identification */
int     m_n;                     /*        Normal force 0/00 */
int     m_ntyp;                  /*        Type of law */
float   m_arb[20][5];            /*        Function values */
} typeCDB_SECT_WLS;

#define SECT_WLU_VER 200501
typedef struct tagCDB_SECT_WLU { /* 9/NR  SectionWorklaw Ultimate Analysis */
int     m_id;                    /*        Identification */
int     m_n;                     /*        Normal force 0/00 */
int     m_ntyp;                  /*        Type of law */
float   m_arb[20][5];            /*        Function values */
} typeCDB_SECT_WLU;

#define SECT_CW_ID 80
#define SECT_CW_VER 201301
typedef struct tagCDB_SECT_CW {  /* 9/NR  Hydrodynamic coefficients (WIND/Wave loading) */
int     m_id;                    /*        Identification 80 */
int     m_iref;                  /*        Reference of coefficients */
int     m_alf;                   /*        angle of attack in degrees */
float   m_cy;                    /*        wind reaction coefficient in y-direction */
float   m_cz;                    /*        wind reaction coefficient in z-direction */
float   m_ct;                    /*        wind reaction coefficient for torsional moment */
float   m_chyd;                  /*        hydrodynamic coefficient (Morrison equation) */
float   m_clat;                  /*        lateral wind reaction coefficient */
float   m_s;                     /*        Strouhal number */
float   m_ag;                    /*        reserved (must be present to detect old data without chyd) */
} typeCDB_SECT_CW;

#define SECT_WPA_ID 81
#define SECT_WPA_VER 200501
typedef struct tagCDB_SECT_WPA { /* 9/NR  SectionWindParameters for Wind loading (WPAR) */
int     m_id;                    /*        Identification 81 */
int     m_iba;                   /*        construction stage number */
int     m_ibit;                  /*        bitpattern of explicit limits */
float   m_kd;                    /* [1011] equivalent roughness k */
float   m_ice;                   /* [1011] ice cover */
float   m_traf;                  /* [1011] height of traffic lane */
float   m_ymin;                  /* [1011] wind attack area */
float   m_zmin;                  /* [1011] wind attack area */
float   m_ymax;                  /* [1011] wind attack area */
float   m_zmax;                  /* [1011] wind attack area */
float   m_yref;                  /* [1011] wind moment reference */
float   m_zref;                  /* [1011] wind moment reference */
float   m_corn;                  /* [1011] radius of round edge for rectangular shapes */
float   m_cwf;                   /*        explicit factor or value of wind coefficient */
float   m_alf;                   /* [   5] rotation for default wind coefficients */
} typeCDB_SECT_WPA;

#define SECT_WDE_ID 82
#define SECT_WDE_VER 200601
typedef struct tagCDB_SECT_WDE { /* 9/NR  SectionWindDerivativa for Wind loading (WIND) */
int     m_id;                    /*        Identification 82 */
int     m_iref;                  /*        Type of derivativa */
int     m_alf;                   /*        angle of attack in degrees (see 009/NR:80) */
float   m_der[20][5];            /*        Derivativa vred,value as splines */
} typeCDB_SECT_WDE;

#define SECT_USR_ID 90
#define SECT_USR_VER 200502
typedef struct tagCDB_SECT_USR { /* 9/NR  SectionUserValues (SV/QW) */
int     m_id;                    /*        Identification = 90 */
int     m_itp;                   /*        type of control value set */
int     m_ival;                  /*        value of control flag */
float   m_rval;                  /*        real value of control flag */
float   m_rvald;                 /*        place to save the original value which has been */
} typeCDB_SECT_USR;

#define SECT_MAT_ID 91
#define SECT_MAT_VER 201507
typedef struct tagCDB_SECT_MAT { /* 9/NR  SectionalMaterial list */
int     m_id;                    /*        Identification = 91 */
int     m_mat[31];               /*        material numbers */
} typeCDB_SECT_MAT;

#define SECT_VAD_ID 97
#define SECT_VAD_VER 201310
typedef struct tagCDB_SECT_VAD { /* 9/NR  SectionVarDefaults */
int     m_id;                    /*        Identification = 97/98 */
int     m_ind1;                  /*        Lower Index of variable */
int     m_ind2;                  /*        Upper Index of variable */
int     m_idim;                  /*        Unit of variable */
chr     m_name[4];               /*        Name of variable */
float   m_rval[1020];            /*        values of the variable NAME(I1:I2) */
} typeCDB_SECT_VAD;

#define SECT_VAR_ID 98
#define SECT_VAR_VER 201310
typedef struct tagCDB_SECT_VAR { /* 9/NR  SectionVarValues */
int     m_id;                    /*        Identification = 97/98 */
int     m_ind1;                  /*        Lower Index of variable */
int     m_ind2;                  /*        Upper Index of variable */
int     m_idim;                  /*        Unit of variable */
chr     m_name[4];               /*        Name of variable */
float   m_rval[1020];            /*        values of the variable NAME(I1:I2) */
} typeCDB_SECT_VAR;

#define SECT_REF_ID 99
#define SECT_REF_VER 200501
typedef struct tagCDB_SECT_REF { /* 9/NR  SectionReference */
int     m_id;                    /*        Identification 099 */
int     m_im;                    /*        Type of reference structure definition (see AQUA.ERR) */
int     m_irts;                  /*        Subtype of reference definition for the points: */
chr     m_ref[200];              /*        Identifier of references (0 = not defined) */
} typeCDB_SECT_REF;

#define SECT_SPT_ID 100
#define SECT_SPT_VER 200805
typedef struct tagCDB_SECT_SPT { /* 9/NR  SectionStressPoint (SPT/QSP) */
int     m_id;                    /*        Identification 100/101 */
int     m_mno;                   /*        Material number */
int     m_idp;                   /*        Number*256 + Bitpattern */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_rt;                    /* [1011] Radius of arc   (:101) ; effect. thickness (:100) */
float   m_wty;                   /* [1018] Resistance Torsion */
float   m_wvyy;                  /* [1017] Resistance y-shear */
float   m_wvzy;                  /* [1017] Resistance z-shear */
float   m_wt2y;                  /* [1018] Resistance 2nd Torsion */
float   m_wtz;                   /* [1018] Resistance Torsion */
float   m_wvyz;                  /* [1017] Resistance y-shear */
float   m_wvzz;                  /* [1017] Resistance z-shear */
float   m_wt2z;                  /* [1018] Resistance 2nd Torsion */
float   m_w0;                    /* [1012] unit warping */
float   m_epsr;                  /*        non effective strain ratio (0 < epsr <= 1) */
float   m_exp;                   /*        exposition class */
float   m_fix;                   /* [1011] location of fix point */
float   m_sigd;                  /* [1092] max. dynamic allowed stress range sig-d(-1) */
float   m_taud;                  /* [1092] max dynamic allowed stress range tau-d(-1) */
chr     m_litd;                  /*        literal for notch type */
float   m_sigy;                  /* [1092] stress perpendicular */
float   m_aref;                  /* [1012] weight (effective area) FE-integration points */
float   m_temp;                  /* [1215] Temperature */
float   m_temp1;                 /* [1215] maximum temperature in history (for damage) */
} typeCDB_SECT_SPT;

#define SECT_PPT_ID 101
#define SECT_PPT_VER 200910
typedef struct tagCDB_SECT_PPT { /* 9/NR  SectionPolygonPoint (POLY/QPOL) */
int     m_id;                    /*        Identification 100/101 */
int     m_mno;                   /*        Material number */
int     m_idp;                   /*        Number*256 + Bitpattern */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_rt;                    /* [1011] Radius of arc   (:101) ; effect. thickness (:100) */
float   m_wty;                   /* [1018] Resistance Torsion */
float   m_wvyy;                  /* [1017] Resistance y-shear */
float   m_wvzy;                  /* [1017] Resistance z-shear */
float   m_wt2y;                  /* [1018] Resistance 2nd Torsion */
float   m_wtz;                   /* [1018] Resistance Torsion */
float   m_wvyz;                  /* [1017] Resistance y-shear */
float   m_wvzz;                  /* [1017] Resistance z-shear */
float   m_wt2z;                  /* [1018] Resistance 2nd Torsion */
float   m_w0;                    /* [1012] unit warping */
float   m_epsr;                  /*        non effective strain ratio (0 < epsr <= 1) */
float   m_exp;                   /*        exposition class */
float   m_fix;                   /* [1011] location of fix point */
float   m_sigd;                  /* [1092] max. dynamic allowed stress range sig-d(-1) */
float   m_taud;                  /* [1092] max dynamic allowed stress range tau-d(-1) */
chr     m_litd;                  /*        literal for notch type */
float   m_sigy;                  /* [1092] stress perpendicular */
float   m_aref;                  /* [1012] weight (effective area) FE-integration points */
float   m_temp;                  /* [1215] Temperature */
float   m_temp1;                 /* [1215] maximum temperature in history (for damage) */
} typeCDB_SECT_PPT;

#define SECT_CIR_ID 102
#define SECT_CIR_VER 200501
typedef struct tagCDB_SECT_CIR { /* 9/NR  SectionCircle (CIRC/KREI) */
int     m_id;                    /*        Identification 102 */
int     m_mno;                   /*        Material number */
int     m_itp;                   /*        interior construction */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate center */
float   m_z;                     /* [1011] z-ordinate center */
float   m_r;                     /* [1011] Radius */
float   m_ri;                    /* [1011] Radius hole */
float   m_uc;                    /* [1011] air contact length */
} typeCDB_SECT_CIR;

#define SECT_PAN_ID 103
#define SECT_PAN_VER 201803
typedef struct tagCDB_SECT_PAN { /* 9/NR  SectionPanel (PLAT,WALL) */
int     m_id;                    /*        Identification 103/104 */
int     m_mno;                   /*        Material number */
int     m_idp;                   /*        Bit-pattern */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_t;                     /* [1010] thickness */
float   m_wa;                    /* [1012] unit warping start */
float   m_we;                    /* [1012] unit warping end */
float   m_wt;                    /* [1018] maximum shear from MT */
float   m_wvy;                   /* [1017] maximum shear from Vy */
float   m_wvz;                   /* [1017] maximum shear from Vz */
float   m_wt2;                   /* [1018] maximum shear from MT2 */
float   m_xvy;                   /*        relative Ordinate WVy */
float   m_xvz;                   /*        relative Ordinate WVz */
float   m_xmt2;                  /*        relative Ordinate Wt2 */
float   m_wtbr;                  /*        Bredt torsional shear */
float   m_fixa;                  /* [1011] location of fix point */
float   m_fixb;                  /* [1011] location of fix point */
float   m_teff;                  /* [1010] effective thickness */
float   m_ast;                   /* [1011] Distance of stiffeners along beam axis */
float   m_eta;                   /*        Reduction factor for local buckling */
} typeCDB_SECT_PAN;

#define SECT_WEL_ID 104
#define SECT_WEL_VER 201803
typedef struct tagCDB_SECT_WEL { /* 9/NR  SectionWeld  (WELD) */
int     m_id;                    /*        Identification 103/104 */
int     m_mno;                   /*        Material number */
int     m_idp;                   /*        Bit-pattern */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_t;                     /* [1010] thickness */
float   m_wa;                    /* [1012] unit warping start */
float   m_we;                    /* [1012] unit warping end */
float   m_wt;                    /* [1018] maximum shear from MT */
float   m_wvy;                   /* [1017] maximum shear from Vy */
float   m_wvz;                   /* [1017] maximum shear from Vz */
float   m_wt2;                   /* [1018] maximum shear from MT2 */
float   m_xvy;                   /*        relative Ordinate WVy */
float   m_xvz;                   /*        relative Ordinate WVz */
float   m_xmt2;                  /*        relative Ordinate Wt2 */
float   m_wtbr;                  /*        Bredt torsional shear */
float   m_fixa;                  /* [1011] location of fix point */
float   m_fixb;                  /* [1011] location of fix point */
float   m_teff;                  /* [1010] effective thickness */
float   m_ast;                   /* [1011] Distance of stiffeners along beam axis */
float   m_eta;                   /*        Reduction factor for local buckling */
} typeCDB_SECT_WEL;

#define SECT_PER_ID 110
#define SECT_PER_VER 200708
typedef struct tagCDB_SECT_PER { /* 9/NR  SectionPeriphery */
int     m_id;                    /*        Identification 110 */
int     m_mno;                   /*        Material number */
int     m_mn2;                   /*        2nd material number */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate */
float   m_za;                    /* [1011] z-ordinate */
float   m_ye;                    /* [1011] y-ordinate */
float   m_ze;                    /* [1011] z-ordinate */
float   m_air;                   /*        air contact ratio */
} typeCDB_SECT_PER;

#define SECT_FEM_ID 112
#define SECT_FEM_VER 201301
typedef struct tagCDB_SECT_FEM { /* 9/NR  SectionTopology */
int     m_id;                    /*        Identification 111 */
int     m_mno;                   /*        Material number */
int     m_nrel;                  /*        internal element number */
int     m_node[4];               /*        internal element nodes */
} typeCDB_SECT_FEM;

#define SECT_NER_ID 190
#define SECT_NER_VER 201511
typedef struct tagCDB_SECT_NER { /* 9/NR  SectionNonEffectiveRectangle (NEFF) */
int     m_id;                    /*        Identification 190 */
int     m_mno;                   /*        Material number */
int     m_idp;                   /*        Noneffective for (same bits as :101) */
chr     m_tnr;                   /*        Designation */
float   m_ymin;                  /* [1011] y-ordinate */
float   m_zmin;                  /* [1011] z-ordinate */
float   m_ymax;                  /* [1011] y-ordinate */
float   m_zmax;                  /* [1011] z-ordinate */
float   m_t;                     /* [1011] thickness */
float   m_smin;                  /* [1092] stress at point (ymin,zmin) */
float   m_smax;                  /* [1092] stress at point (ymax,zmax) */
} typeCDB_SECT_NER;

#define SECT_NEP_ID 191
#define SECT_NEP_VER 200810
typedef struct tagCDB_SECT_NEP { /* 9/NR  Partial non effective polygons */
int     m_id;                    /*        Identification 191 */
int     m_mno;                   /*        Materialnumber */
int     m_idp;                   /*        Noneffective for (see :190) */
chr     m_tnr;                   /*        Ident from 190 / Cut identifier for :312 elements */
float   m_yz[511][2];            /* [1011] yz(2,*) = vertices (old format is blocked with 7 points */
} typeCDB_SECT_NEP;

#define SECT_PRF_ID 200
#define SECT_PRF_VER 200501
typedef struct tagCDB_SECT_PRF { /* 9/NR  SectionPointReinforcement (RF/BEW) */
int     m_id;                    /*        Identification 200 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_sig;                   /* [1092] prestress */
float   m_temp;                  /* [1215] Temperature */
float   m_as;                    /* [1020] Reinforcement area */
float   m_asma;                  /* [1020] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1012] Reference area */
float   m_a;                     /* [1011] distance of bars */
} typeCDB_SECT_PRF;

#define SECT_LRF_ID 201
#define SECT_LRF_VER 200501
typedef struct tagCDB_SECT_LRF { /* 9/NR  SectionLineReinforcement (LRF/LBEW) */
int     m_id;                    /*        Identification 201/211/221 or 321 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_r;                     /* [1011] Radius */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_LRF;

#define SECT_LRP_ID 211
#define SECT_LRP_VER 201302
typedef struct tagCDB_SECT_LRP { /* 9/NR  SectionLineReinforcement in Points */
int     m_id;                    /*        Identification 201/211/221 or 321 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_r;                     /* [1011] Radius */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_LRP;

#define SECT_LSL_ID 221
#define SECT_LSL_VER 201112
typedef struct tagCDB_SECT_LSL { /* 9/NR  SectionShearLink */
int     m_id;                    /*        Identification 201/211/221 or 321 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_r;                     /* [1011] Radius */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_LSL;

#define SECT_CRF_ID 202
#define SECT_CRF_VER 200501
typedef struct tagCDB_SECT_CRF { /* 9/NR  SectionCircularReinforcement (CRF/KBEW) */
int     m_id;                    /*        Identification 202/212/222 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate center */
float   m_z;                     /* [1011] z-ordinate center */
float   m_r;                     /* [1011] Radius */
float   m_i_4;
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_CRF;

#define SECT_CRP_ID 212
#define SECT_CRP_VER 201210
typedef struct tagCDB_SECT_CRP { /* 9/NR  SectionCircularReinforcement in Points */
int     m_id;                    /*        Identification 202/212/222 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate center */
float   m_z;                     /* [1011] z-ordinate center */
float   m_r;                     /* [1011] Radius */
float   m_i_4;
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_CRP;

#define SECT_CSL_ID 222
#define SECT_CSL_VER 201112
typedef struct tagCDB_SECT_CSL { /* 9/NR  SectionHelicalShearLink */
int     m_id;                    /*        Identification 202/212/222 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate center */
float   m_z;                     /* [1011] z-ordinate center */
float   m_r;                     /* [1011] Radius */
float   m_i_4;
float   m_as;                    /* [1029] Reinforc. area */
float   m_asma;                  /* [1029] max Reinforcement area */
float   m_rng;                   /*        Layer number */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Diameter */
float   m_aref;                  /* [1019] Reference area = width of element */
float   m_a;                     /* [1011] distance of bars */
float   m_phia;                  /* [   5] start angle for generated points */
float   m_phie;                  /* [   5] end   angle for generated points */
} typeCDB_SECT_CSL;

#define SECT_URF_ID 210
#define SECT_URF_VER 201302
typedef struct tagCDB_SECT_URF { /* 9/NR  SectionPeriphericReinforcement (CURF,UBEW) */
int     m_id;                    /*        Identification 210/220 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_cover;                 /* [1024] static cover */
chr     m_exp[2];                /*        Exposition class */
float   m_wc;                    /*        weight for centering reinforcement */
float   m_as;                    /* [1021] Reinforc. area/length */
float   m_asma;                  /* [1021] max Reinforcement area */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Bar Diameter */
float   m_aref;                  /* [1019] Reference area for crack width */
float   m_a;                     /* [1011] distance of bars */
} typeCDB_SECT_URF;

#define SECT_USL_ID 220
#define SECT_USL_VER 201302
typedef struct tagCDB_SECT_USL { /* 9/NR  SectionPeriphericShearLink */
int     m_id;                    /*        Identification 210/220 */
int     m_mno;                   /*        Material number */
int     m_ir;                    /*        Layer number */
chr     m_tnr;                   /*        Designation */
float   m_cover;                 /* [1024] static cover */
chr     m_exp[2];                /*        Exposition class */
float   m_wc;                    /*        weight for centering reinforcement */
float   m_as;                    /* [1021] Reinforc. area/length */
float   m_asma;                  /* [1021] max Reinforcement area */
float   m_ft;                    /*        torsional effect */
float   m_d;                     /* [1023] Bar Diameter */
float   m_aref;                  /* [1019] Reference area for crack width */
float   m_a;                     /* [1011] distance of bars */
} typeCDB_SECT_USL;

#define SECT_CPT_ID 300
#define SECT_CPT_VER 200501
typedef struct tagCDB_SECT_CPT { /* 9/NR  SectionCutStressPoint */
int     m_id;                    /*        Identification 300 */
int     m_mno;                   /*        Material of Reinforc. + 1000*Materialnumber */
int     m_bit;                   /*        Cut-Index*128 + Bitpattern */
chr     m_tnr;                   /*        Designation */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_b0;                    /* [1011] width of cut */
float   m_wtm;                   /* [1018] Resistance Torsion */
float   m_wtr;                   /* [1018] Resistance max Torsion */
float   m_wvy;                   /* [1017] Resistance y-shear */
float   m_wvz;                   /* [1017] Resistance z-shear */
float   m_frs;                   /*        Factor for total reinf */
float   m_w0;                    /* [1012] unit warping */
float   m_sigy;                  /* [1092] stress perpendicular */
float   m_bb;                    /* [1011] total width of cut */
float   m_vyfk;                  /*        part of total y-shear */
float   m_vzfk;                  /*        part of total z-shear */
float   m_bqfk;                  /*        partial width factor */
float   m_byfk;                  /* [1011] shear design width for Vy */
float   m_bzfk;                  /* [1011] shear design width for Vz */
} typeCDB_SECT_CPT;

#define SECT_CUT_ID 301
#define SECT_CUT_VER 201803
typedef struct tagCDB_SECT_CUT { /* 9/NR  ShearCut (CUT) */
int     m_id;                    /*        Identification 301 */
int     m_mno;                   /*        Material of Reinforc. + 1000*Materialnumber */
int     m_idp;                   /*        Bitpattern */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_b0;                    /* [1011] effective width */
float   m_n;                     /* [1111] Normal force perpend. */
float   m_m;                     /* [1114] bending moment perpend */
float   m_wtm;                   /* [1018] Resistance Torsion mid */
float   m_wtd;                   /* [1018] add tors.resist.edge */
float   m_vyfk;                  /*        part of total y-shear */
float   m_vzfk;                  /*        part of total z-shear */
float   m_bv;                    /* [1011] total effective width */
float   m_phib;                  /* [   5] inclination stirups */
float   m_irb;                   /*        number of shearlayer */
float   m_ty;                    /* [  17] unit shear Sy/Iz */
float   m_tz;                    /* [  17] unit shear Sz/Iy */
float   m_bred;                  /* [1011] reduction for ducts */
float   m_asbm;                  /*        Minimum shear reinf. */
float   m_betc;                  /*        friction coefficient */
float   m_mue;                   /*        friction in joint */
float   m_act;                   /* [1012] Area of cut off */
float   m_ksl;                   /*        parameters for plate */
float   m_sxe;                   /* [1011] crack spacing for AASTHO */
float   m_cott;                  /*        explicit selected inclination for truss model */
float   m_bmin;                  /* [1011] minimum of cut width */
float   m_bmax;                  /* [1011] maximum of cut width */
} typeCDB_SECT_CUT;

#define SECT_CPL_ID 311
#define SECT_CPL_VER 0
typedef struct tagCDB_SECT_CPL { /* 9/NR  Partial polygons of shear cut */
int     m_id;                    /*        Identification 311 */
int     m_mno;                   /*        Materialnumber */
int     m_idp;                   /*        Cut number (0=continue last one) */
chr     m_tnr;                   /*        Designation of cut */
float   m_yz[511][2];            /* [1011] yz(2,*) = up to seven vertices */
} typeCDB_SECT_CPL;

#define SECT_APL_ID 313
#define SECT_APL_VER 0
typedef struct tagCDB_SECT_APL { /* 9/NR  Partial polygons of AKT crack area */
int     m_id;                    /*        Identification 311 */
int     m_mno;                   /*        Materialnumber */
int     m_idp;                   /*        Cut number (0=continue last one) */
chr     m_tnr;                   /*        Designation of cut */
float   m_yz[511][2];            /* [1011] yz(2,*) = up to seven vertices */
} typeCDB_SECT_APL;

#define SECT_HYD_ID 900
#define SECT_HYD_VER 200501
typedef struct tagCDB_SECT_HYD { /* 9/NR  SectionalHydraulics total section */
int     m_id;                    /*        Identification = 900/903 */
int     m_i_1;
int     m_i_2;
float   m_a;                     /* [1012] Area */
float   m_ut;                    /* [1011] total periphery */
float   m_up;                    /* [1011] total wet periphery */
float   m_r;                     /* [1011] hydraulic radius */
float   m_zet1;                  /*        loss factor 1 */
float   m_zet2;                  /*        loss factor 2 */
float   m_slk;                   /*        total leakage */
float   m_ys;                    /* [1011] y-Ordinate Center */
float   m_zs;                    /* [1011] y-Ordinate Center */
} typeCDB_SECT_HYD;

#define SECT_HYP_ID 903
#define SECT_HYP_VER 200501
typedef struct tagCDB_SECT_HYP { /* 9/NR  SectionalHydraulics partial section */
int     m_id;                    /*        Identification = 900/903 */
int     m_i_1;
int     m_i_2;
float   m_a;                     /* [1012] Area */
float   m_ut;                    /* [1011] total periphery */
float   m_up;                    /* [1011] total wet periphery */
float   m_r;                     /* [1011] hydraulic radius */
float   m_zet1;                  /*        loss factor 1 */
float   m_zet2;                  /*        loss factor 2 */
float   m_slk;                   /*        total leakage */
float   m_ys;                    /* [1011] y-Ordinate Center */
float   m_zs;                    /* [1011] y-Ordinate Center */
} typeCDB_SECT_HYP;

#define SECT_HYA_ID 904
#define SECT_HYA_VER 200501
typedef struct tagCDB_SECT_HYA { /* 9/NR  SectionalHydraulicsAddval */
int     m_id;                    /*        identifier 904 */
int     m_i_2;
int     m_type;                  /*        type of section */
float   m_nw;                    /*        Nominal width */
float   m_ymin;                  /* [1011] Minimum Ordinate of section */
float   m_ymax;                  /* [1011] Maximum Ordinate of section */
float   m_zmin;                  /* [1011] Minimum Ordinate of section */
float   m_zmax;                  /* [1011] Maximum Ordinate of section */
float   m_ks;                    /* [  16] absolute roughness */
float   m_s;                     /*        storage coefficient */
float   m_i_8;                   /*        reserved */
float   m_i_9;                   /*        reserved */
float   m_i_10;                  /*        reserved */
float   m_hp;                    /* [1010] lift of pump */
float   m_lmin;                  /*        minimum power */
float   m_lmax;                  /*        maximum power */
float   m_qmax;                  /*        maximum delivery */
} typeCDB_SECT_HYA;

#define SECT_HYS_ID 910
#define SECT_HYS_VER 200501
typedef struct tagCDB_SECT_HYS { /* 9/NR  SectionalHydraulicsPolygon */
int     m_id;                    /*        Identification 910 */
int     m_mat;                   /*        identifier 0 (material number) */
int     m_nr;                    /*        number of side */
chr     m_tnr;                   /*        Designation */
float   m_ya;                    /* [1011] y-ordinate start */
float   m_za;                    /* [1011] z-ordinate start */
float   m_ye;                    /* [1011] y-ordinate end */
float   m_ze;                    /* [1011] z-ordinate end */
float   m_ks;                    /* [  16] absolute roughness */
float   m_slk;                   /*        leakage */
} typeCDB_SECT_HYS;

#define SECT_INS_ID 100002
#define SECT_INS_VER 0
typedef struct tagCDB_SECT_INS { /* 9/NR  structural database contents */
int     m_id;                    /*        Identification of record key */
int     m_kwh;                   /*        Identification of record key (30/31/32) */
int     m_kwl;                   /*        Identification of record key (=NR) */
int     m_ib[1];                 /*        buffer of record contents for record KWH/KWL */
                                 /*        unknown length! */
#define ANZOF_SECT_INS_IB(il) ((il)-offsetof(typeCDB_SECT_INS,m_ib))/sizeof(int)
} typeCDB_SECT_INS;


#define SECT_KWH 9
typedef union taguSECT {   /* 9/NR */
int m_id;
typeCDB_SECT m_sect;
typeCDB_SECT_EFF m_sect_eff;
typeCDB_SECT_PAR m_sect_par;
typeCDB_SECT_PEF m_sect_pef;
typeCDB_SECT_ADD m_sect_add;
typeCDB_SECT_WAR m_sect_war;
typeCDB_SECT_PLA m_sect_pla;
typeCDB_SECT_DES m_sect_des;
typeCDB_SECT_PRE m_sect_pre;
typeCDB_SECT_GV m_sect_gv;
typeCDB_SECT_TRA m_sect_tra;
typeCDB_SECT_LAY m_sect_lay;
typeCDB_SECT_REC m_sect_rec;
typeCDB_SECT_ANN m_sect_ann;
typeCDB_SECT_TUB m_sect_tub;
typeCDB_SECT_CAB m_sect_cab;
typeCDB_SECT_PRO m_sect_pro;
typeCDB_SECT_TBA m_sect_tba;
typeCDB_SECT_IBA m_sect_iba;
typeCDB_SECT_TXT m_sect_txt;
typeCDB_SECT_WLS m_sect_wls;
typeCDB_SECT_WLU m_sect_wlu;
typeCDB_SECT_CW m_sect_cw;
typeCDB_SECT_WPA m_sect_wpa;
typeCDB_SECT_WDE m_sect_wde;
typeCDB_SECT_USR m_sect_usr;
typeCDB_SECT_MAT m_sect_mat;
typeCDB_SECT_VAD m_sect_vad;
typeCDB_SECT_VAR m_sect_var;
typeCDB_SECT_REF m_sect_ref;
typeCDB_SECT_SPT m_sect_spt;
typeCDB_SECT_PPT m_sect_ppt;
typeCDB_SECT_CIR m_sect_cir;
typeCDB_SECT_PAN m_sect_pan;
typeCDB_SECT_WEL m_sect_wel;
typeCDB_SECT_PER m_sect_per;
typeCDB_SECT_FEM m_sect_fem;
typeCDB_SECT_NER m_sect_ner;
typeCDB_SECT_NEP m_sect_nep;
typeCDB_SECT_PRF m_sect_prf;
typeCDB_SECT_LRF m_sect_lrf;
typeCDB_SECT_LRP m_sect_lrp;
typeCDB_SECT_LSL m_sect_lsl;
typeCDB_SECT_CRF m_sect_crf;
typeCDB_SECT_CRP m_sect_crp;
typeCDB_SECT_CSL m_sect_csl;
typeCDB_SECT_URF m_sect_urf;
typeCDB_SECT_USL m_sect_usl;
typeCDB_SECT_CPT m_sect_cpt;
typeCDB_SECT_CUT m_sect_cut;
typeCDB_SECT_CPL m_sect_cpl;
typeCDB_SECT_APL m_sect_apl;
typeCDB_SECT_HYD m_sect_hyd;
typeCDB_SECT_HYP m_sect_hyp;
typeCDB_SECT_HYA m_sect_hya;
typeCDB_SECT_HYS m_sect_hys;
typeCDB_SECT_INS m_sect_ins;
} typeuSECT;


/*   SOFiSTiK AG
     cdbtypesct.h
     end of automatically generated header
*/
#endif
