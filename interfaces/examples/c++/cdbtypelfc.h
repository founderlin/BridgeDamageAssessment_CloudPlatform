/*   SOFiSTiK AG
     cdbtypelfc.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypelfc_INCLUDED
#define cdbtypelfc_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;
#define MAXLFD  999999
#define MAXLFX  999999

#define LC_CTRL_VER 200501
typedef struct tagCDB_LC_CTRL {  /* 12/LC  Informations on loadcase LC */
int     m_kind;                  /*        type of loadcase */
chr     m_ityp;                  /*        action type (14/ID) */
#define LTYP_IMP 70
int     m_theo;                  /*        first order theory */
int     m_iba[2];                /*        construction stage number of birth & death */
int     m_plc;                   /*        Primary load case for 2nd order analysis */
float   m_rpar;                  /*        Timevalue of Load [sec] */
float   m_psi0;                  /*        combin. factor psi0 */
float   m_psi1;                  /*        combin. factor psi1 */
float   m_psi2;                  /*        combin. factor psi2 */
float   m_fact;                  /*        loadcase factor */
float   m_facx;                  /*        dead load factor X */
float   m_facy;                  /*        dead load factor Y */
float   m_facz;                  /*        dead load factor Z */
float   m_rx;                    /* [1151] sum of support PX */
float   m_ry;                    /* [1151] sum of support PY */
float   m_rz;                    /* [1151] sum of support PZ */
float   m_cri1;                  /*        1st eval. criteria */
float   m_cri2;                  /*        2nd eval. criteria */
float   m_cri3;                  /*        3rd eval. criteria */
float   m_gam1;                  /*        unfavourable factor */
float   m_gam2;                  /*        favourable factor */
chr     m_name[8];               /*        Generating source */
pckcode m_rtex[17];              /*        Designation of loadcase */
#define LC_CTRL_RTEX_LEN 32
} typeCDB_LC_CTRL;

#define LC_EVAL_ID 11
#define LC_EVAL_VER 200501
typedef struct tagCDB_LC_EVAL {  /* 12/LC  Evaluation request */
int     m_id;                    /*        identifier 11 */
int     m_lref;                  /*        Referenced load case or construction stage */
int     m_ltyp;                  /*        type of evaluation request */
int     m_leig;                  /*        load case number of first eigenvalue */
chr     m_name[4];               /*        Literal of variable name */
float   m_val[99];               /*        Results of evaluation (array for ietyp 4) */
} typeCDB_LC_EVAL;

#define LC_COPY_ID 12
#define LC_COPY_VER 201211
typedef struct tagCDB_LC_COPY {  /* 12/LC  Loads from other loadcases */
int     m_id;                    /*        identifier 12 / 13 */
int     m_lref;                  /*        Referenced load case or action ID [chr] */
int     m_lsel;                  /*        selection bits for elements */
int     m_litf;                  /*        enum of applied generic factors */
int     m_isel[4];               /*        optional filter for element numbers */
int     m_nref[8];               /*        Load train application control (see cdblfta.for) */
float   m_sref[32];              /*        Factors and coordinates */
float   m_sum[7];                /*        Sum of forces (psup,lsup) */
pckcode m_clit[128];             /*        Literal of an external database as source */
#define LC_COPY_CLIT_LEN 255
} typeCDB_LC_COPY;

#define LC_COPI_ID 13
#define LC_COPI_VER 201211
typedef struct tagCDB_LC_COPI {  /* 12/LC  Loads from other loadcases */
int     m_id;                    /*        identifier 12 / 13 */
int     m_lref;                  /*        Referenced load case or action ID [chr] */
int     m_lsel;                  /*        selection bits for elements */
int     m_litf;                  /*        enum of applied generic factors */
int     m_isel[4];               /*        optional filter for element numbers */
int     m_nref[8];               /*        Load train application control (see cdblfta.for) */
float   m_sref[32];              /*        Factors and coordinates */
float   m_sum[7];                /*        Sum of forces (psup,lsup) */
pckcode m_clit[128];             /*        Literal of an external database as source */
#define LC_COPI_CLIT_LEN 255
} typeCDB_LC_COPI;

#define LC_MBODY_VER 201312
typedef struct tagCDB_LC_MBODY { /* 12/LC  Rotation of Body */
int     m_id;                    /*        identifier 20/21 */
int     m_nr;                    /*        primary or secondary group number of moving elements */
int     m_nref;                  /*        Reference beam number */
float   m_ax;                    /* [1003] acceleration local X */
float   m_ay;                    /* [1003] acceleration local Y */
float   m_az;                    /* [1003] acceleration local Z */
float   m_axx;                   /* [1207] rotational acceleration local X-X */
float   m_ayy;                   /* [1207] rotational acceleration local Y-Y */
float   m_azz;                   /* [1207] rotational acceleration local Z-Z */
float   m_arx;                   /* [1207] rotational acceleration local X-X  (= vxx**2) */
float   m_ary;                   /* [1207] rotational acceleration local Y-Y  (= vyy**2) */
float   m_arz;                   /* [1207] rotational acceleration local Z-Z  (= vzz**2) */
float   m_ex;                    /* [1001] global reference point for rotational acceleration */
float   m_ey;                    /* [1001] global reference point for rotational acceleration */
float   m_ez;                    /* [1001] global reference point for rotational acceleration */
} typeCDB_LC_MBODY;

#define LC_LRES_ID 89
#define LC_LRES_VER 201607
typedef struct tagCDB_LC_LRES {  /* 12/LC  Explicit factors for selected results */
int     m_id;                    /*        identifier 89 */
int     m_kw;                    /*        KW where result has been stored */
int     m_ipos;                  /*        Position of Result within record */
int     m_nrel;                  /*        Element number */
float   m_xabs;                  /* [1011] Section location for beams/structural lines */
struct {
int     m_n;
float   m_f;
      } m_lc[255];               /*        load case number and factor (dynamic length) */
} typeCDB_LC_LRES;

#define LC_LPOS_ID 90
#define LC_LPOS_VER 200805
typedef struct tagCDB_LC_LPOS {  /* 12/LC  Position of Load trains */
int     m_id;                    /*        identifier 90 */
int     m_case;                  /*        number of the case */
chr     m_ref;                   /*        name of the reference lane */
int     m_sub;                   /*        subnumber of lane */
int     m_kw;                    /*        KW where result has been stored */
int     m_ipos;                  /*        Position of Result within record */
int     m_nrel;                  /*        Elementnumber */
int     m_lftg;                  /*        LFT*1000+500*ISCONVOY+LFG */
float   m_xabs;                  /* [1011] Section location for beams */
float   m_yex;                   /* [1001] Eccentricity of load train */
float   m_psc[2];                /*        Maximum load values in load train (PL/BL) */
float   m_xpos[64];              /*        Position and distance values */
} typeCDB_LC_LPOS;

#define LC_LPO1_ID 91
#define LC_LPO1_VER 200601
typedef struct tagCDB_LC_LPO1 {  /* 12/LC  Individual position of Point load */
int     m_id;                    /*        identifier 91 */
float   m_x;                     /* [1001] Position of individual load */
float   m_pval[4];               /*        Load values in PV,PVM,PX,PY */
} typeCDB_LC_LPO1;

#define LC_LPO2_ID 92
#define LC_LPO2_VER 200601
typedef struct tagCDB_LC_LPO2 {  /* 12/LC  Individual position of Block load */
int     m_id;                    /*        identifier 92 */
float   m_xa;                    /* [1001] Position of individual load start */
float   m_xe;                    /* [1001] Position of individual load end */
float   m_pval[4];               /*        Load values in PV,PVM,PX,PY */
} typeCDB_LC_LPO2;

#define LC_LPO3_ID 93
#define LC_LPO3_VER 200601
typedef struct tagCDB_LC_LPO3 {  /* 12/LC  Individual residual loadings */
int     m_id;                    /*        identifier 93 */
float   m_xa;                    /* [1001] Position of individual load start */
float   m_xe;                    /* [1001] Position of individual load end */
float   m_pval[8];               /*        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE */
} typeCDB_LC_LPO3;

#define LC_LPOX_ID 99
#define LC_LPOX_VER 200911
typedef struct tagCDB_LC_LPOX {  /* 12/LC  Spandefinitions from ELLA */
int     m_id;                    /*        identifier 99 */
float   m_xa;                    /* [1001] Limits of an active area start */
float   m_xe;                    /* [1001] Limits of an active area end */
float   m_yl;                    /* [1001] Limits of an active area left */
float   m_yr;                    /* [1001] Limits of an active area right */
float   m_phi;                   /*        impact factor */
float   m_v;                     /* [1203] velocity of load train */
} typeCDB_LC_LPOX;

#define LC_POIN_VER 200707
typedef struct tagCDB_LC_POIN {  /* 12/LC  Free point loads */
int     m_kref;                  /*        Reference type */
int     m_nref;                  /*        Reference number */
chr     m_tref[3];               /*        Reference text    (12 characters) */
int     m_typ;                   /*        type of load */
chr     m_txt[3];                /*        Identifiying Text (12 characters) */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_width;                 /* [1001] Tolerance load direction to match elements */
struct {
float   m_p;
float   m_x;                     /* [1001]  */
float   m_y;                     /* [1001]  */
float   m_z;                     /* [1001]  */
      } m_lpt;                   /*        loadpt */
} typeCDB_LC_POIN;

#define LC_LINE_VER 200502
typedef struct tagCDB_LC_LINE {  /* 12/LC  Free line loads */
int     m_kref;                  /*        Reference type */
int     m_nref;                  /*        Reference number */
chr     m_tref[3];               /*        Reference text    (12 characters) */
int     m_typ;                   /*        type of load */
chr     m_txt[3];                /*        Identifiying Text (12 characters) */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_width;                 /* [1001] Tolerance load direction to match elements */
struct {
float   m_p;
float   m_x;                     /* [1001]  */
float   m_y;                     /* [1001]  */
float   m_z;                     /* [1001]  */
      } m_lpt[63];               /*        loadpts */
} typeCDB_LC_LINE;

#define LC_CURV_VER 200502
typedef struct tagCDB_LC_CURV {  /* 12/LC  Free spline loads */
int     m_kref;                  /*        Reference type */
int     m_nref;                  /*        Reference number */
chr     m_tref[3];               /*        Reference text    (12 characters) */
int     m_typ;                   /*        type of load */
chr     m_txt[3];                /*        Identifiying Text (12 characters) */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_width;                 /* [1001] Tolerance load direction to match elements */
struct {
float   m_p;
float   m_x;                     /* [1001]  */
float   m_y;                     /* [1001]  */
float   m_z;                     /* [1001]  */
      } m_lpt[63];               /*        loadpts */
} typeCDB_LC_CURV;

#define LC_AREA_VER 200501
typedef struct tagCDB_LC_AREA {  /* 12/LC  Free area loads */
int     m_kref;                  /*        Reference type */
int     m_nref;                  /*        Reference number */
chr     m_tref[3];               /*        Reference text    (12 characters) */
int     m_typ;                   /*        type of load */
chr     m_txt[3];                /*        Identifiying Text (12 characters) */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_width;                 /* [1001] Tolerance load direction to match elements */
struct {
float   m_p;
float   m_x;                     /* [1001]  */
float   m_y;                     /* [1001]  */
float   m_z;                     /* [1001]  */
      } m_lpt[63];               /*        loadpts */
} typeCDB_LC_AREA;

#define LC_VOLU_VER 200502
typedef struct tagCDB_LC_VOLU {  /* 12/LC  Free volume loads */
int     m_kref;                  /*        Reference type */
int     m_nref;                  /*        Reference number */
chr     m_tref[3];               /*        Reference text    (12 characters) */
int     m_typ;                   /*        type of load */
chr     m_txt[3];                /*        Identifiying Text (12 characters) */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_width;                 /* [1001] Factor for silo fillings A/U */
float   m_p0;                    /*        load value */
float   m_x;                     /* [1001] Reference point for load value P0 */
float   m_y;                     /* [1001]  */
float   m_z;                     /* [1001]  */
float   m_p1;                    /*        variant load value second reference point */
float   m_dx1;                   /* [1001] Reference point for load value P1 */
float   m_dy1;                   /* [1001]  */
float   m_dz1;                   /* [1001]  */
float   m_p2;                    /*        variant load value second reference point */
float   m_dx2;                   /* [1001] Reference point for load value P2 */
float   m_dy2;                   /* [1001]  */
float   m_dz2;                   /* [1001]  */
float   m_p3;                    /*        variant load value second reference point */
float   m_dx3;                   /* [1001] Reference point for load value P3 */
float   m_dy3;                   /* [1001]  */
float   m_dz3;                   /* [1001]  */
float   m_p4;                    /*        variant load value second reference point */
float   m_dx4;                   /* [1001] Reference point for load value P2 */
float   m_dy4;                   /* [1001]  */
float   m_dz4;                   /* [1001]  */
float   m_p5;                    /*        variant load value second reference point */
float   m_dx5;                   /* [1001] Reference point for load value P3 */
float   m_dy5;                   /* [1001]  */
float   m_dz5;                   /* [1001]  */
} typeCDB_LC_VOLU;

#define GLC_GUID_ID 199
#define GLC_GUID_VER 0
typedef struct tagCDB_GLC_GUID { /* 12/LC  Unique identifier of loading member */
int     m_id;                    /*        identifier 199 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of following element */
} typeCDB_GLC_GUID;

#define LC_TRAI_ID 300
#define LC_TRAI_VER 201807
typedef struct tagCDB_LC_TRAI {  /* 12/LC  Train loading */
int     m_id;                    /*        identifier 300 */
int     m_iden;                  /*        Type of load train */
int     m_bpat;                  /*        Preselected Bitpattern of special options */
float   m_p1;                    /*        Char Designation or Class of loading */
float   m_p2;                    /*        second entry for load magnitude */
float   m_p3;                    /*        third entry for load magnitude */
float   m_p4;                    /*        fourth entry for load magnitude */
float   m_p5;                    /*        Basic area loading */
float   m_p6;                    /*        Wind loading */
float   m_p7;                    /*        Height subjected to wind load */
float   m_p8;                    /*        Entry for brake loading */
float   m_p9;                    /*        Height of the gravity centreline */
float   m_totfac;                /*        Factor for the vertical loads of the */
float   m_phib;                  /*        explicit impact factor for bending */
float   m_phibf;                 /*        explicit impact factor favourable bending */
float   m_phis;                  /*        explicit impact factor for shear */
float   m_phisf;                 /*        explicit impact factor favourable shear */
float   m_width;                 /* [1001] Width of moving lane to be spared with P5 */
float   m_yex;                   /* [1001] reserved: Eccentricity of loading in lane */
float   m_xcol;                  /* [1001] Minimum distance for multiple instances */
float   m_v;                     /* [1203] Speed of train */
float   m_facf;                  /*        Factor for the masses of the loading */
float   m_favf;                  /*        factor for favorable loading */
float   m_frb;                   /*        Frequence of body to bogie spring */
float   m_dab;                   /*        Modal damping of body to bogie */
float   m_pzbo;                  /* [1001] Fractional load value of bogie (included in PZ) */
float   m_frbo;                  /*        Frequence of bogie to wheel spring */
float   m_dabo;                  /*        Modal damping of bogie to body */
float   m_pzwh;                  /* [1001] Fractional load value of wheel (included in PZ) */
float   m_frwh;                  /*        Frequence of wheel to surface / bridge deck */
float   m_dawh;                  /*        Modal damping of wheel to surface */
} typeCDB_LC_TRAI;

#define LC_TRAL_ID 301
#define LC_TRAL_VER 200911
typedef struct tagCDB_LC_TRAL {  /* 12/LC  Individual loads of Train loading */
int     m_id;                    /*        identifier 301 */
int     m_type;                  /*        Type of loading */
int     m_bpat;                  /*        contact node for single loads */
float   m_pz;                    /*        Vertical loading */
float   m_ymin;                  /* [1001] min eccentricity in y direction */
float   m_ymax;                  /* [1001] max eccentricity in y direction */
float   m_px;                    /*        Load value for braking */
float   m_pw;                    /*        Explicit force for wind attack */
float   m_zw;                    /* [1001] Height for wind force resultant */
float   m_pv;                    /*        Massvalue for zentrifugal force */
float   m_zpv;                   /* [1001] Height for zentrifugal force resultant */
float   m_facfav;                /*        Factor for favourable effects */
float   m_a;                     /* [1001] Distance to last load */
float   m_l;                     /* [1001] Length of loading for block loads (0 = unlimited) */
float   m_lmax;                  /* [1001] Maximum length of block loading if variable */
float   m_ldel;                  /* [1001] Discrete increment of length for block loading */
float   m_hw;                    /* [1001] Height of train for wind attack area */
float   m_width;                 /* [1001] Width of train */
float   m_yexvar;                /*        Variable eccentricity for secondary load trains */
float   m_wwheel;                /* [1001] Width of single wheel */
float   m_lwheel;                /* [1001] Length of single wheel */
float   m_dummy[2];              /*        reserved */
float   m_frb;                   /*        Frequence of body to bogie spring */
float   m_dab;                   /*        Modal damping of body to bogie */
float   m_pzbo;                  /* [1001] Fractional load value of bogie (included in PZ) */
float   m_frbo;                  /*        Frequence of bogie to wheel spring */
float   m_dabo;                  /*        Modal damping of bogie to body */
float   m_pzwh;                  /* [1001] Fractional load value of wheel (included in PZ) */
float   m_frwh;                  /*        Frequence of wheel to surface / bridge deck */
float   m_dawh;                  /*        Modal damping of wheel to surface */
} typeCDB_LC_TRAL;

#define LC_WIND_ID 400
#define LC_WIND_VER 200501
typedef struct tagCDB_LC_WIND {  /* 12/LC  wind loading */
int     m_id;                    /*        identifier 400 */
int     m_norm;                  /*        wind design code */
int     m_clas;                  /*        type of zone and terrain */
float   m_vatm;                  /* [1201] atmospheric wind */
float   m_vref;                  /* [1201] mean reference wind */
float   m_vboe;                  /* [1201] gust reference wind */
float   m_dx;                    /*        components of wind direction */
float   m_dy;
float   m_dz;
float   m_xref;                  /* [1001] Reference point */
float   m_yref;                  /* [1001]  */
float   m_zref;                  /* [1001]  */
float   m_dxre;                  /*        Reference direction */
float   m_dyre;
float   m_dzre;
float   m_gh;                    /* [1001] coordinate of ground level */
float   m_hmin;                  /* [1001] value for constant wind speed below (zmin) */
float   m_rho;                   /* [  59] weight of the air / fluid */
float   m_lat;                   /* [   5] explicit lattitude of site */
float   m_z0;                    /* [1001] explicit roughness */
} typeCDB_LC_WIND;

#define LC_WTOP_ID 401
#define LC_WTOP_VER 200501
typedef struct tagCDB_LC_WTOP {  /* 12/LC  Wind environment */
int     m_id;                    /*        identifier 401 */
float   m_typ;                   /*        type of environment height */
float   m_i_2;                   /*        reserved */
float   m_xm;                    /* [1001] center of elevation in system coordinates */
float   m_ym;                    /* [1001] center of elevation in system coordinates */
float   m_zm;                    /* [1001] center of elevation in system coordinates */
float   m_dx;                    /*        direction of crest of ridge */
float   m_dy;                    /*        or local x-coordinate of a summit */
float   m_dz;
float   m_h;                     /* [1001] height above ground defining the slopes */
float   m_wlen;                  /* [1001] width in negative local y direction */
float   m_blen;                  /* [1001] width in positive local x direction */
} typeCDB_LC_WTOP;

#define LC_WROU_ID 402
#define LC_WROU_VER 200501
typedef struct tagCDB_LC_WROU {  /* 12/LC  Roughness (wind) */
int     m_id;                    /*        identifier 402 */
float   m_i_1;                   /*        reserved */
float   m_i_2;                   /*        reserved */
float   m_dsea;                  /* [1001] Distance to the sea */
struct {
float   m_d;                     /* [1001]  */
float   m_r;                     /* [1001]  */
float   m_dh;                    /* [1001]  */
float   m_hh;                    /* [1001]  */
      } m_r[9];                  /*        limits given */
} typeCDB_LC_WROU;

#define LC_WSPE_ID 410
#define LC_WSPE_VER 200501
typedef struct tagCDB_LC_WSPE {  /* 12/LC  wind spectrum */
int     m_id;                    /*        identifier 410 */
int     m_typ;                   /*        type of spectra */
int     m_ctyp;                  /*        type of coherence model */
float   m_a1lo;                  /*        1st coefficient longitudinal */
float   m_a2lo;                  /*        2nd coefficient longitudinal */
float   m_a3lo;                  /*        3rd coefficient longitudinal */
float   m_b_lo;                  /*        4th coefficient longitudinal */
float   m_c_lo;                  /*        5th coefficient longitudinal */
float   m_d_lo;                  /*        6th coefficient longitudinal */
float   m_a1la;                  /*        1st coefficient lateral */
float   m_a2la;                  /*        2nd coefficient lateral */
float   m_a3la;                  /*        3rd coefficient lateral */
float   m_b_la;                  /*        4th coefficient lateral */
float   m_c_la;                  /*        5th coefficient lateral */
float   m_d_la;                  /*        6th coefficient lateral */
float   m_a1ve;                  /*        1st coefficient vertical */
float   m_a2ve;                  /*        2nd coefficient vertical */
float   m_a3ve;                  /*        3rd coefficient vertical */
float   m_b_ve;                  /*        4th coefficient vertical */
float   m_c_ve;                  /*        5th coefficient vertical */
float   m_d_ve;                  /*        6th coefficient vertical */
float   m_c3d;                   /*        Longitudinal coefficient */
float   m_kuu;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kuv;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kuw;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kvu;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kvv;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kvw;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kwu;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kwv;                   /*        HWD factor for ESDU, coefficient otherwise */
float   m_kww;                   /*        HWD factor for ESDU, coefficient otherwise */
} typeCDB_LC_WSPE;

#define LC_WTST_ID 411
#define LC_WTST_VER 201406
typedef struct tagCDB_LC_WTST {  /* 12/LC  wind coherence test requests */
int     m_id;                    /*        identifier 411 */
int     m_typ;                   /*        type of coherence component */
int     m_lc;                    /*        load case of an eigenvalue */
float   m_xref;                  /* [1001] Reference point */
float   m_yref;                  /* [1001]  */
float   m_zref;                  /* [1001]  */
float   m_rx;                    /* [1001] Distance or direction of distance */
float   m_ry;                    /* [1001]  */
float   m_rz;                    /* [1001]  */
float   m_cx;                    /*        Davenport/Krenk reference coefficients */
float   m_cy;
float   m_cz;
float   m_eig;                   /*        Eigenfrequency (Hertz) for LC>0 */
float   m_u;                     /* [  96] mean velocity */
float   m_hwd;                   /* [1001] real distance for LC==0 */
float   m_xmax;                  /*        maximum x-value for data */
float   m_data[64];              /*        calculated sqrt of coherence data ( 2 sets) */
} typeCDB_LC_WTST;

#define LC_WPRC_ID 420
#define LC_WPRC_VER 200501
typedef struct tagCDB_LC_WPRC {  /* 12/LC  wind profile control values */
int     m_id;                    /*        identifier 420 */
int     m_id2;                   /*        identifier 0 */
float   m_ipro;                  /*        number of generated profiles */
float   m_wxmi;                  /* [1001] size of structure in wind coordinates */
float   m_wxma;                  /* [1001]  */
float   m_wymi;                  /* [1001]  */
float   m_wyma;                  /* [1001]  */
float   m_wzmi;                  /* [1001]  */
float   m_wzma;                  /* [1001]  */
float   m_alfa;                  /*        some angle ... */
float   m_beta;                  /*        some angle ... */
float   m_gamm;                  /*        some angle ... */
float   m_delt;                  /*        some angle ... */
} typeCDB_LC_WPRC;

#define LC_WPRO_ID 420
#define LC_WPRO_VER 200501
typedef struct tagCDB_LC_WPRO {  /* 12/LC  wind profile distinct values */
int     m_id;                    /*        identifier 420 */
int     m_ist;                   /*        source of data */
float   m_i_2;                   /*        index reserved */
float   m_h;                     /* [1001] height above ground level */
float   m_v;                     /* [1201] mean value of wind velocity */
float   m_vboe;                  /* [1201] peak value of wind velocity */
float   m_tlon;                  /* [1201] longitudinal turbulence */
float   m_tlat;                  /* [1201] lateral turbulence */
float   m_tver;                  /* [1201] vertical turbulence */
float   m_llon;                  /* [1001] longitudinal wave length */
float   m_llat;                  /* [1001] lateral wave length */
float   m_lver;                  /* [1001] vertical wave length */
float   m_phas;                  /*        phase */
} typeCDB_LC_WPRO;

#define LC_WAVE_ID 500
#define LC_WAVE_VER 201301
typedef struct tagCDB_LC_WAVE {  /* 12/LC  Wave Loading */
int     m_id;                    /*        identifier 500 */
int     m_typ;                   /*        wave theory bit pattern */
int     m_nf;                    /*        number of frequencies in spectra */
float   m_h;                     /* [1001] wave height / significant wave height */
float   m_t;                     /* [  90] period of wave / peak period of wave */
float   m_d;                     /* [1001] water depth (0 = infinite) */
float   m_swl;                   /* [1001] sea water reference level */
float   m_dir[3];                /*        principal direction of travelling */
float   m_uc;                    /* [1201] additional constant current */
float   m_alf;                   /*        exponent U(z)=UC*(z/d)**alf */
float   m_rho;                   /* [  59] weight of the fluid */
float   m_l;                     /* [1001] calculated wave length */
float   m_par[15];               /*        special parameters for wave spectra */
} typeCDB_LC_WAVE;

#define LC_HIST_ID 0
#define LC_HIST_VER 201104
typedef struct tagCDB_LC_HIST {  /* 13/LC  TimeHistoryTitle */
int     m_id;                    /*        identifier 0 */
int     m_idt;                   /*        Unit of time resp x-axis */
int     m_idf;                   /*        Unit of function values */
int     m_nfun;                  /*        number of functions */
int     m_nval;                  /*        max number of discrete time values */
int     m_type;                  /*        general type of curve */
pckcode m_title[17];             /*        Designation */
#define LC_HIST_TITLE_LEN 32
} typeCDB_LC_HIST;

#define LC_DAMP_ID 1
#define LC_DAMP_VER 200501
typedef struct tagCDB_LC_DAMP {  /* 13/LC  Damping values */
int     m_id;                    /*        identifier 1 */
float   m_d[7];                  /*        modal damping values */
} typeCDB_LC_DAMP;

#define LC_FVAL_VER 200501
typedef struct tagCDB_LC_FVAL {  /* 13/LC  Discrete function values */
int     m_id;                    /*        identifier */
float   m_tt;                    /*        Time/frequency/modenumber */
float   m_f[7];                  /*        function values */
} typeCDB_LC_FVAL;

#define LC_FMODC_VER 201602
typedef struct tagCDB_LC_FMODC { /* 13/LC  Explicit modal coordinates */
int     m_id;                    /*        identifier */
float   m_tt;                    /*        Time/frequency/modenumber */
float   m_f[7];                  /*        function values */
} typeCDB_LC_FMODC;

#define LC_FSIN_ID 11
#define LC_FSIN_VER 200501
typedef struct tagCDB_LC_FSIN {  /* 13/LC  Harmonic function additive */
int     m_id;                    /*        identifier */
float   m_t;                     /* [  90] Time/frequency */
float   m_f1;                    /*        Amplitude value */
float   m_phi1;                  /* [  90] phase value */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime if > starttime */
float   m_s;                     /*        impactfactor */
float   m_f2;                    /*        Amplitude value for T/2 (Fourier) */
float   m_phi2;                  /* [  90] phase value for f2 */
float   m_f3;                    /*        Amplitude value for T/3 (Fourier) */
float   m_phi3;                  /* [  90] phase value for f3 */
float   m_f4;                    /*        Amplitude value for T/4 (Fourier) */
float   m_phi4;                  /* [  90] phase value for f4 */
} typeCDB_LC_FSIN;

#define LC_FSINM_ID 21
#define LC_FSINM_VER 200501
typedef struct tagCDB_LC_FSINM { /* 13/LC  Harmonic function multiplier */
int     m_id;                    /*        identifier */
float   m_t;                     /* [  90] Time/frequency */
float   m_f1;                    /*        Amplitude value */
float   m_phi1;                  /* [  90] phase value */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime if > starttime */
float   m_s;                     /*        impactfactor */
float   m_f2;                    /*        Amplitude value for T/2 (Fourier) */
float   m_phi2;                  /* [  90] phase value for f2 */
float   m_f3;                    /*        Amplitude value for T/3 (Fourier) */
float   m_phi3;                  /* [  90] phase value for f3 */
float   m_f4;                    /*        Amplitude value for T/4 (Fourier) */
float   m_phi4;                  /* [  90] phase value for f4 */
} typeCDB_LC_FSINM;

#define LC_FSTP_ID 12
#define LC_FSTP_VER 200501
typedef struct tagCDB_LC_FSTP {  /* 13/LC  Periodic stepping function additive */
int     m_id;                    /*        identifier */
float   m_t;                     /* [  90] Time/frequency */
float   m_f;                     /*        Amplitude value */
float   m_tc;                    /* [  90] contact time */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime if > starttime */
float   m_s;                     /*        impactfactor (Sailer/Hüttner/Bachmann) */
} typeCDB_LC_FSTP;

#define LC_FSTPM_ID 22
#define LC_FSTPM_VER 200501
typedef struct tagCDB_LC_FSTPM { /* 13/LC  Periodic stepping function multiplier */
int     m_id;                    /*        identifier */
float   m_t;                     /* [  90] Time/frequency */
float   m_f;                     /*        Amplitude value */
float   m_tc;                    /* [  90] contact time */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime if > starttime */
float   m_s;                     /*        impactfactor (Sailer/Hüttner/Bachmann) */
} typeCDB_LC_FSTPM;

#define LC_FINA_ID 13
#define LC_FINA_VER 201104
typedef struct tagCDB_LC_FINA {  /* 13/LC  Aperiodic function additive */
int     m_id;                    /*        identifier 13 */
float   m_t;                     /* [  90] Total Time */
float   m_f;                     /*        Amplitude value */
float   m_t1;                    /* [  90] Time of constant intensity */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime = tmin+T */
chr     m_typ;                   /*        Type of function */
float   m_f2;                    /*        Amplitude factor */
float   m_t2;                    /* [  90] lead in time duration */
float   m_f3;                    /*        Amplitude factor */
float   m_t3;                    /* [  90] lead out time duration */
} typeCDB_LC_FINA;

#define LC_FINM_ID 23
#define LC_FINM_VER 201104
typedef struct tagCDB_LC_FINM {  /* 13/LC  Aperiodic function multiplier */
int     m_id;                    /*        identifier 13 */
float   m_t;                     /* [  90] Total Time */
float   m_f;                     /*        Amplitude value */
float   m_t1;                    /* [  90] Time of constant intensity */
float   m_tmin;                  /* [  90] starttime */
float   m_tmax;                  /* [  90] stoptime = tmin+T */
chr     m_typ;                   /*        Type of function */
float   m_f2;                    /*        Amplitude factor */
float   m_t2;                    /* [  90] lead in time duration */
float   m_f3;                    /*        Amplitude factor */
float   m_t3;                    /* [  90] lead out time duration */
} typeCDB_LC_FINM;

#define LC_RESW_VER 201502
typedef struct tagCDB_LC_RESW {  /* 13/LC  Response spectra wind */
int     m_typ;                   /*        Type of spectra 900 - 999 */
float   m_sint;                  /*        Integral of spectra */
float   m_a1;                    /*        Spectrum coefficient */
float   m_a2;                    /*        Spectrum coefficient */
float   m_a3;                    /*        Spectrum coefficient */
float   m_b;                     /*        Spectrum coefficient */
float   m_c;                     /*        Spectrum coefficient */
float   m_d;                     /*        Spectrum coefficient */
float   m_res[9];                /*        reserved */
pckcode m_title[17];             /*        Designation of Spectra */
#define LC_RESW_TITLE_LEN 32
} typeCDB_LC_RESW;

#define LC_RESP_VER 200501
typedef struct tagCDB_LC_RESP {  /* 13/LC  Response seismic spectra */
int     m_typ;                   /*        Type of spectra 100 - 999 */
float   m_d;                     /*        Damping value eta or behaviour factor q */
float   m_sa;                    /*        Rigid acceleration factor (Soil Parameter S) */
float   m_sb;                    /*        Max acceleration factor */
float   m_smin;                  /*        Min acceleration factor (beta) */
float   m_tb;                    /* [  90] Time value */
float   m_tc;                    /* [  90] Time value */
float   m_td;                    /* [  90] Time value */
float   m_te;                    /* [  90] Cutt-Off Time */
float   m_k1;                    /*        Coefficient k1 */
float   m_k2;                    /*        Coefficient k2 */
chr     m_zone[3];               /*        Seismic zone */
float   m_ag;                    /* [1202] Reference base acceleration */
float   m_ah;                    /*        Horizontal factor (importance etc.) */
float   m_av;                    /*        Vertical factor */
pckcode m_title[17];             /*        Designation of Spectra */
#define LC_RESP_TITLE_LEN 32
} typeCDB_LC_RESP;

#define LC_FREF_VER 201104
typedef struct tagCDB_LC_FREF {  /* 13/LC  Discrete reference function values */
int     m_id;                    /*        line type */
float   m_tt;                    /*        Time/frequency */
float   m_f[2];                  /*        function values */
} typeCDB_LC_FREF;

#define ACT_TASK_VER 200806
typedef struct tagCDB_ACT_TASK { /* 14/0  Superposition task commands */
int     m_ivers;                 /*        < 9999 = old data format (ACT_RULE) */
int     m_num;                   /*        number of superposition command */
int     m_act;                   /*        number of groups of actions at 14/act */
int     m_lfm[2];                /*        base of load case numbers */
int     m_ksav;                  /*        0 = do not save, >0 = save factors as combination KSAV */
int     m_kwerg;                 /*        Identifier of resultrecord in CDB */
int     m_from;                  /*        smallest  element number */
int     m_to;                    /*        highest   element number */
int     m_inc;                   /*        increment element number */
int     m_tid;                   /*        optional identifier */
float   m_x;                     /* [1001] X-ordinate for beams (see INC!) */
int     m_comb;                  /*        combination method for items given at SCOM */
struct {
int     m_ind;
float   m_fak;
chr     m_bez;
      } m_scom[9];               /*        index,factor and name of items */
pckcode m_txt[33];               /*        Name of superposition */
#define ACT_TASK_TXT_LEN 64
chr     m_uform[128];            /*        User defined target function (index == 0!) */
} typeCDB_ACT_TASK;

#define ACT_RULE_VER 200501
typedef struct tagCDB_ACT_RULE { /* 14/0  Superposition commands (old Version) */
int     m_num;                   /*        number of superposition command */
int     m_act;                   /*        number of groups of actions at 14/act */
int     m_lfm[2];                /*        base of load case numbers */
int     m_kwerg;                 /*        Identifier of resultrecord in CDB */
int     m_from;                  /*        smallest  element number (echo only) */
int     m_to;                    /*        highest   element number (echo only) */
int     m_inc;                   /*        increment element number (echo only) */
int     m_tid;                   /*        optional identifier */
int     m_comb;                  /*        combination method for items given at SCOM */
struct {
int     m_ind;
float   m_fak;
chr     m_bez;
      } m_scom[9];               /*        index,factor and name of items */
pckcode m_txt[33];               /*        Name of superposition */
#define ACT_RULE_TXT_LEN 64
} typeCDB_ACT_RULE;

#define LC_ACT0_ID 0
#define LC_ACT0_VER 200501
typedef struct tagCDB_LC_ACT0 {  /* 14/NR  Group of Actions for SUPP-task */
int     m_id;                    /*        ident = 0  user defined ; < 0 automatic */
int     m_lfb;                   /*        load case offset */
int     m_extr;                  /*        type of formula for evaluating the extrema */
int     m_type;                  /*        type or action of resulting load case */
pckcode m_txt[17];               /*        Group designation for collection of actions */
#define LC_ACT0_TXT_LEN 32
} typeCDB_LC_ACT0;

#define LC_CACT0_ID 80
#define LC_CACT0_VER 0
typedef struct tagCDB_LC_CACT0 { /* 12/LC  Group of Actions for SUPP-task */
int     m_id;                    /*        ident = 0  user defined ; < 0 automatic */
int     m_lfb;                   /*        load case offset */
int     m_extr;                  /*        type of formula for evaluating the extrema */
int     m_type;                  /*        type or action of resulting load case */
pckcode m_txt[17];               /*        Group designation for collection of actions */
#define LC_CACT0_TXT_LEN 32
} typeCDB_LC_CACT0;

#define LC_ACT1_ID 1
#define LC_ACT1_VER 200501
typedef struct tagCDB_LC_ACT1 {  /* 14/NR  Action member */
int     m_id;                    /*        ident = 1 / 81 */
chr     m_action;                /*        ID of the action = type of action */
int     m_type;                  /*        256*subgroup + 16*Group_of_action + superposition */
float   m_gamu;                  /*        safety factor unfavourable */
float   m_gamf;                  /*        safety factor favourable */
float   m_psi0;                  /*        combination value */
float   m_psi1;                  /*        combination value */
float   m_psi2;                  /*        quasi permanent combination value */
float   m_ps1s;                  /*        non frequent combination value psi1' */
float   m_gama;                  /*        safety factor accidential */
chr     m_cat;                   /*        category (see 14/ID) not used here */
pckcode m_txt[17];               /*        designation */
#define LC_ACT1_TXT_LEN 32
} typeCDB_LC_ACT1;

#define LC_CACT1_ID 81
#define LC_CACT1_VER 201607
typedef struct tagCDB_LC_CACT1 { /* 12/NR  current action member */
int     m_id;                    /*        ident = 1 / 81 */
chr     m_action;                /*        ID of the action = type of action */
int     m_type;                  /*        256*subgroup + 16*Group_of_action + superposition */
float   m_gamu;                  /*        safety factor unfavourable */
float   m_gamf;                  /*        safety factor favourable */
float   m_psi0;                  /*        combination value */
float   m_psi1;                  /*        combination value */
float   m_psi2;                  /*        quasi permanent combination value */
float   m_ps1s;                  /*        non frequent combination value psi1' */
float   m_gama;                  /*        safety factor accidential */
chr     m_cat;                   /*        category (see 14/ID) not used here */
pckcode m_txt[17];               /*        designation */
#define LC_CACT1_TXT_LEN 32
} typeCDB_LC_CACT1;

#define LC_ACT_L_ID 2
#define LC_ACT_L_VER 200501
typedef struct tagCDB_LC_ACT_L { /* 14/NR  loadcase of action */
int     m_id;                    /*        ident = 2 / 82 */
int     m_lf;                    /*        load case number */
int     m_type;                  /*        load case action type */
float   m_fact;                  /*        factor */
} typeCDB_LC_ACT_L;

#define LC_CACT2_ID 82
#define LC_CACT2_VER 201607
typedef struct tagCDB_LC_CACT2 { /* 12/NR  current loadcase of action */
int     m_id;                    /*        ident = 2 / 82 */
int     m_lf;                    /*        load case number */
int     m_type;                  /*        load case action type */
float   m_fact;                  /*        factor */
} typeCDB_LC_CACT2;

#define LC_ACT_R_VER 200501
typedef struct tagCDB_LC_ACT_R { /* 14/NR  Response Spectra */
int     m_id;                    /*        Evaluation type of response */
int     m_resp;                  /*        load case number of spectra */
int     m_lfeig;                 /*        load case of first eigenform */
int     m_neig;                  /*        numbers of eigenforms to be used */
} typeCDB_LC_ACT_R;

#define LC_ACT_ID 1
#define LC_ACT_VER 200501
typedef struct tagCDB_LC_ACT {   /* 14/ID  Action defaults */
int     m_id;                    /*        ident = 1 */
int     m_action;                /*        ID of the real action = type of action */
int     m_type;                  /*        256*subgroup + 16*Group_of_action + superposition */
float   m_gamu;                  /*        safety factor unfavourable */
float   m_gamf;                  /*        safety factor favourable */
float   m_psi0;                  /*        combination value */
float   m_psi1;                  /*        combination value */
float   m_psi2;                  /*        quasi permanent combination value */
float   m_ps1s;                  /*        non frequent combination value psi1' */
float   m_gama;                  /*        safety factor accidential */
chr     m_cat;                   /*        category for preselection of psi-values */
pckcode m_txt[17];               /*        designation */
#define LC_ACT_TXT_LEN 32
} typeCDB_LC_ACT;


#define LC_CTRL_KWH 12
typedef union taguLC_CTRL {   /* 12/LC */
int m_id;
typeCDB_LC_CTRL m_lc_ctrl;
typeCDB_LC_EVAL m_lc_eval;
typeCDB_LC_COPY m_lc_copy;
typeCDB_LC_COPI m_lc_copi;
typeCDB_LC_MBODY m_lc_mbody;
typeCDB_LC_LRES m_lc_lres;
typeCDB_LC_LPOS m_lc_lpos;
typeCDB_LC_LPO1 m_lc_lpo1;
typeCDB_LC_LPO2 m_lc_lpo2;
typeCDB_LC_LPO3 m_lc_lpo3;
typeCDB_LC_LPOX m_lc_lpox;
typeCDB_LC_POIN m_lc_poin;
typeCDB_LC_LINE m_lc_line;
typeCDB_LC_CURV m_lc_curv;
typeCDB_LC_AREA m_lc_area;
typeCDB_LC_VOLU m_lc_volu;
typeCDB_GLC_GUID m_glc_guid;
typeCDB_LC_TRAI m_lc_trai;
typeCDB_LC_TRAL m_lc_tral;
typeCDB_LC_WIND m_lc_wind;
typeCDB_LC_WTOP m_lc_wtop;
typeCDB_LC_WROU m_lc_wrou;
typeCDB_LC_WSPE m_lc_wspe;
typeCDB_LC_WTST m_lc_wtst;
typeCDB_LC_WPRC m_lc_wprc;
typeCDB_LC_WPRO m_lc_wpro;
typeCDB_LC_WAVE m_lc_wave;
typeCDB_LC_CACT0 m_lc_cact0;
} typeuLC_CTRL;


#define LC_CACT1_KWH 12
typedef union taguLC_CACT1 {   /* 12/NR */
int m_id;
typeCDB_LC_CACT1 m_lc_cact1;
typeCDB_LC_CACT2 m_lc_cact2;
} typeuLC_CACT1;


#define LC_HIST_KWH 13
typedef union taguLC_HIST {   /* 13/LC */
int m_id;
typeCDB_LC_HIST m_lc_hist;
typeCDB_LC_DAMP m_lc_damp;
typeCDB_LC_FVAL m_lc_fval;
typeCDB_LC_FMODC m_lc_fmodc;
typeCDB_LC_FSIN m_lc_fsin;
typeCDB_LC_FSINM m_lc_fsinm;
typeCDB_LC_FSTP m_lc_fstp;
typeCDB_LC_FSTPM m_lc_fstpm;
typeCDB_LC_FINA m_lc_fina;
typeCDB_LC_FINM m_lc_finm;
typeCDB_LC_RESW m_lc_resw;
typeCDB_LC_RESP m_lc_resp;
typeCDB_LC_FREF m_lc_fref;
} typeuLC_HIST;


#define ACT_TASK_KWH 14
#define ACT_TASK_KWL 0
typedef union taguACT_TASK {   /* 14/0 */
int m_id;
typeCDB_ACT_TASK m_act_task;
typeCDB_ACT_RULE m_act_rule;
} typeuACT_TASK;


#define LC_ACT0_KWH 14
typedef union taguLC_ACT0 {   /* 14/NR */
int m_id;
typeCDB_LC_ACT0 m_lc_act0;
typeCDB_LC_ACT1 m_lc_act1;
typeCDB_LC_ACT_L m_lc_act_l;
typeCDB_LC_ACT_R m_lc_act_r;
} typeuLC_ACT0;


#define LC_ACT_KWH 14
typedef union taguLC_ACT {   /* 14/ID */
int m_id;
typeCDB_LC_ACT m_lc_act;
} typeuLC_ACT;


/*   SOFiSTiK AG
     cdbtypelfc.h
     end of automatically generated header
*/
#endif
