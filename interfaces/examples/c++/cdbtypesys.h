/*   SOFiSTiK AG
     cdbtypesys.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypesys_INCLUDED
#define cdbtypesys_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;
#define CTRL_010_ID 999
#define CTRL_010_VER 201004
typedef struct tagCDB_CTRL_010 { /* 0/01  AccessInfo Last Program */
int     m_id;                    /*        Identifier 999 */
int     m_acce;                  /*        Number of access */
int     m_vers;                  /*        Version number */
pckcode m_name[17];              /*        Name of Program */
#define CTRL_010_NAME_LEN 32
chr     m_err[4];                /*        Name of ERR-File */
} typeCDB_CTRL_010;

#define CTRL_011_VER 200706
typedef struct tagCDB_CTRL_011 { /* 0/01  Messages */
int     m_id;                    /*        Level */
chr     m_iderr[2];              /*        Number of errortext */
chr     m_idsup[4];              /*        Name of subroutine */
chr     m_itext[6];              /*        Text value of message */
int     m_nilist;                /*        count on Integer values of message */
int     m_nrlist;                /*        count on Real values of message */
int     m_list[255];             /*        values of message ILIST+RLIST */
} typeCDB_CTRL_011;

#define CTRL_OBJ_ID 101
#define CTRL_OBJ_VER 200706
typedef struct tagCDB_CTRL_OBJ { /* 0/01  involved objects */
int     m_id;                    /*        Identifier = 101 */
int     m_id2;                   /*        bitpattern of specified data */
int     m_type;                  /*        KWH of Elementtype (30,31,32,33) */
int     m_nr;                    /*        Number of element  (TYPE/NR) */
chr     m_idbim[32];             /*        256 Bit GUId Identifier of element in the BIM/CAD system */
float   m_uvw[3];                /* [1001] local coordinates in object */
float   m_box[2][3];             /* [1001] bounding box x,y,z min, x,y,z max */
} typeCDB_CTRL_OBJ;

#define CTRL_OID_ID 102
#define CTRL_OID_VER 201005
typedef struct tagCDB_CTRL_OID { /* 0/01  GUId */
int     m_id;                    /*        identifier 102 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of preceeding element */
} typeCDB_CTRL_OID;

#define SSD_SPE_ID 1
#define SSD_SPE_VER 0
typedef struct tagCDB_SSD_SPE {  /* 0/96  SSD-Spezial */
int     m_id;                    /*        id==1 */
int     m_type;                  /*        type of information */
int     m_ival;                  /*        integer value */
float   m_rval[3];               /*        real values */
chr     m_itxt[4];               /*        string value */
} typeCDB_SSD_SPE;

#define VIS_LC0_ID 0
#define VIS_LC0_VER 0
typedef struct tagCDB_VIS_LC0 {  /* 0/97  active Loadcase */
int     m_id;                    /*        id==0 */
int     m_lfnr;                  /*        Loadcase number */
int     m_vis;                   /*        unused */
} typeCDB_VIS_LC0;

#define VIS_LC_ID 1
#define VIS_LC_VER 0
typedef struct tagCDB_VIS_LC {   /* 0/97  Loadcase visualisation */
int     m_id;                    /*        id==1 */
int     m_lfnr;                  /*        Loadcase number */
int     m_vis;                   /*        Visualisation */
} typeCDB_VIS_LC;

#define CTRL_VER 200501
typedef struct tagCDB_CTRL {     /* 0/99  PrintControl */
int     m_maxl;                  /*        Lines per page */
int     m_marg;                  /*        Left margin */
int     m_tobo;                  /*        Top/bottom margin */
int     m_modp;                  /*        Type of Headding */
int     m_page;                  /*        Current page no */
int     m_lout;                  /*        Output Language */
int     m_linp;                  /*        Input  Language */
int     m_unit;                  /*        Unit set */
int     m_acce;                  /*        No of last access */
pckcode m_pag[7];                /*        Paging Text */
#define CTRL_PAG_LEN 12
int     m_rel_vers;              /*        ReleaseVersion of this database */
int     m_rel_bits;              /*        Accessbits */
#define CTRL_ACCESS_MIX 1
#define CTRL_ACCESS_CONVERT 2
#define CTRL_ACCESS_2010 4
#define CTRL_ACCESS_2012 8
#define CTRL_ACCESS_2014 16
#define CTRL_ACCESS_2016 32
#define CTRL_ACCESS_2018 64
#define CTRL_ACCESS_2020 128
} typeCDB_CTRL;

#define CTRL_0_ID 0
#define CTRL_0_VER 200501
typedef struct tagCDB_CTRL_0 {   /* 0/99  AccessInfo */
int     m_id;                    /*        Identifier 0 */
int     m_acce;                  /*        Number of access */
int     m_vers;                  /*        Version number */
int     m_erro;                  /*        Number of Errors */
int     m_warn;                  /*        Number of Errors */
pckcode m_name[17];              /*        Name of Program */
#define CTRL_0_NAME_LEN 32
int     m_rel_vers;              /*        ReleaseVersion of last access */
} typeCDB_CTRL_0;

#define CTRL_1_ID 1
#define CTRL_1_VER 200501
typedef struct tagCDB_CTRL_1 {   /* 0/99  AccessTitle */
int     m_id;                    /*        Identifier 1 */
int     m_acce;                  /*        Number of access */
pckcode m_kopf[64];              /*        Title of access */
#define CTRL_1_KOPF_LEN 127
} typeCDB_CTRL_1;

#define CTRL_VAR_VER 201310
typedef struct tagCDB_CTRL_VAR { /* 0/100  Global_CADINP_Variable */
chr     m_name[4];               /*        name of variable */
int     m_ind;                   /*        index for arrays */
float   m_val;                   /*        value of variable */
int     m_scope;                 /*        name of scope */
int     m_dim;                   /*        unit of variable */
pckcode m_txt[17];               /*        Comment on variable */
#define CTRL_VAR_TXT_LEN 32
} typeCDB_CTRL_VAR;

#define CTRL_VAP_VER 200704
typedef struct tagCDB_CTRL_VAP { /* 0/100  Private_CADINP_Variable */
int     m_id;                    /*        Identification = ??? */
int     m_ind1;                  /*        Lower Index of variable */
int     m_ind2;                  /*        Upper Index of variable */
chr     m_name[4];               /*        Name of variable */
float   m_val[1020];             /*        values of the variable NAME[IND1:IND2] */
} typeCDB_CTRL_VAP;

#define CTRL_DIM_VER 201606
typedef struct tagCDB_CTRL_DIM { /* 0/101  Unit definitions */
int     m_idim;                  /*        number of an implicit unit (>999) */
int     m_unia;                  /*        unit for output (0=do not change) */
int     m_unie;                  /*        unit for input  (0=do not change) */
int     m_diga;                  /*        number of digits for output (>10 for Exponential) */
int     m_dige;                  /*        number of digits for input (=GUI) */
} typeCDB_CTRL_DIM;

#define SYST_VER 200501
typedef struct tagCDB_SYST {     /* 10/00  SystemInfo */
int     m_iprob;                 /*        Type of System */
int     m_iachs;                 /*        Orientation of gravity */
int     m_nknot;                 /*        Number of nodes */
int     m_mknot;                 /*        Highest node number */
int     m_igdiv;                 /*        Group divisor */
int     m_igres;
float   m_box[2][3];             /* [1001] bounding box */
float   m_tg[4][3];              /*        global CDB-System transformation matrix */
pckcode m_txt[64];               /*        Name of projekt, 127 chars */
#define SYST_TXT_LEN 127
} typeCDB_SYST;

#define SYST_DES_ID 0
#define SYST_DES_VER 200502
typedef struct tagCDB_SYST_DES { /* 10/1  SystemDesignCode */
int     m_id;                    /*        identifier = 0 */
int     m_idc;                   /*        Design code enumeration */
int     m_country;               /*        Country code for variants */
int     m_code;                  /*        main number or ident of code */
int     m_year;                  /*        Year of publication */
chr     m_class;                 /*        classification (see master.ini) */
chr     m_txt[4];                /*        specific Text of Design code (16 characters) */
int     m_wind;                  /*        enum of a wind classification (see master.ini) */
int     m_snow;                  /*        enum of a snow-classification (see master.ini) */
int     m_seis;                  /*        enum of a seismic-classification (see master.ini) */
float   m_gravity;               /* [1202] explicit gravity acceleration constant for site */
float   m_altiobs;               /* [1006] obsoleted altitude above sea level */
float   m_vers;                  /*        Version number of INI-File (21.0) */
float   m_longitud;              /* [ 205] longitude of location */
float   m_latitude;              /* [ 205] latitude of location */
float   m_altitude;              /* [1006] altitude above sea level */
} typeCDB_SYST_DES;

#define SYST_ACT_ID 1
#define SYST_ACT_VER 200501
typedef struct tagCDB_SYST_ACT { /* 10/1  Predefined Actions from INI-file */
int     m_id;                    /*        identifier = 1 */
int     m_action;                /*        ID of the real action = type of action */
int     m_type;                  /*        16*Part of action + superposition */
float   m_gamu;                  /*        safety factor unfavourable */
float   m_gamf;                  /*        safety factor favourable */
float   m_psi0;                  /*        combination value */
float   m_psi1;                  /*        frequent combination value */
float   m_psi2;                  /*        quasi permanent combination value */
float   m_ps1s;                  /*        non frequent combination value psi1' */
float   m_gama;                  /*        safety factor accidential */
chr     m_cat;                   /*        sub category of action */
int     m_txtref;                /*        designation_enum in SOFISTIK.ERR */
pckcode m_txt[17];               /*        explicit designation (in native language) */
#define SYST_ACT_TXT_LEN 32
} typeCDB_SYST_ACT;

#define SYST_COM_ID 2
#define SYST_COM_VER 200501
typedef struct tagCDB_SYST_COM { /* 10/1  Possible Combination of actions */
int     m_id;                    /*        identifier = 2 */
int     m_lfb;                   /*        loadcase number offset */
int     m_extr;                  /*        Combination rule equation to be used */
int     m_type;                  /*        type or action of resulting load case */
int     m_apply;                 /*        Is generally used for: */
chr     m_txt[8];                /*        Name of combination */
float   m_dummy;                 /*        reserved */
struct {
chr     m_id;
float   m_faku;
float   m_fakf;
      } m_act[31];               /*        Identifier of action */
} typeCDB_SYST_COM;

/* -- Number of groups allowed -- */
#define MAXGRP   999

#define GRP_VER 200501
typedef struct tagCDB_GRP {      /* 11/00  Groups */
int     m_ng;                    /*        group-number */
int     m_typ;                   /*        element code */
int     m_num;                   /*        number of elements of this type */
int     m_min;                   /*        minimum element-number of group */
int     m_max;                   /*        maximum element-number of group */
int     m_mnr;                   /*        material-number of group */
int     m_mbw;                   /*        reinforcement material-number of group */
int     m_inf;                   /*        Bit-code of group */
float   m_faks;                  /*        stiffness factor of group (ASE/TALPA) */
float   m_faka;                  /*        reducing factor of axial bedding for piles */
float   m_fakt;                  /*        reducing factor of transverse bedding */
float   m_vtot;                  /* [1093] total volume */
float   m_mtot;                  /* [1093] total mass */
float   m_rtot;                  /* [1030] total reinforcement */
float   m_etot;                  /* [1093] total energy */
float   m_ecom;                  /* [1093] compression energy */
float   m_edev;                  /* [1093] shear energy */
float   m_ekin;                  /* [1093] kinetic energy */
float   m_epot;                  /* [1093] potential energy */
float   m_edam;                  /* [1093] damping energy */
float   m_h_gw;                  /* [1001] Level of Groundwater */
float   m_dummy;                 /*        reserved */
pckcode m_text[17];              /*        Designation of Group */
#define GRP_TEXT_LEN 32
} typeCDB_GRP;

#define GRP_LC_VER 200501
typedef struct tagCDB_GRP_LC {   /* 11/LC  Groups of Loadcase */
int     m_ng;                    /*        group-number */
int     m_typ;                   /*        element code */
int     m_num;                   /*        number of elements of this type */
int     m_min;                   /*        minimum element-number of group */
int     m_max;                   /*        maximum element-number of group */
int     m_mnr;                   /*        material-number of group */
int     m_mbw;                   /*        reinforcement material-number of group */
int     m_inf;                   /*        Bit-code of group */
float   m_faks;                  /*        stiffness factor of group (ASE/TALPA) */
float   m_faka;                  /*        reducing factor of axial bedding for piles */
float   m_fakt;                  /*        reducing factor of transverse bedding */
float   m_vtot;                  /* [1093] total volume */
float   m_mtot;                  /* [1093] total mass */
float   m_rtot;                  /* [1030] total reinforcement */
float   m_etot;                  /* [1093] total energy */
float   m_ecom;                  /* [1093] compression energy */
float   m_edev;                  /* [1093] shear energy */
float   m_ekin;                  /* [1093] kinetic energy */
float   m_epot;                  /* [1093] potential energy */
float   m_edam;                  /* [1093] damping energy */
float   m_h_gw;                  /* [1001] Level of Groundwater */
float   m_dummy;                 /*        reserved */
pckcode m_text[17];              /*        Designation of Group */
#define GRP_LC_TEXT_LEN 32
} typeCDB_GRP_LC;

#define CSM_GRP_VER 200501
typedef struct tagCDB_CSM_GRP {  /* 15/-1  Construction Stage Group Definitions */
int     m_grp;                   /*        Group number */
int     m_ics;                   /*        CS number of first activation */
int     m_gfix;                  /*        CS number of hinge fixing */
int     m_end;                   /*        CS number of last action */
int     m_free[2];               /*        free integer for later use */
float   m_t0;                    /* [  93] minimum age for loading */
} typeCDB_CSM_GRP;

#define CSM_LC_VER 200501
typedef struct tagCDB_CSM_LC {   /* 15/-2  Construction Stage Loadcase Definitions */
int     m_lc;                    /*        Loadcase */
int     m_start;                 /*        CS number for first action */
int     m_end;                   /*        CS number of last action */
} typeCDB_CSM_LC;

#define CSM_CS_VER 200501
typedef struct tagCDB_CSM_CS {   /* 15/-3  Construction Stage Table */
int     m_cs;                    /*        Construction Stage */
int     m_id;                    /*        Main action type in this CS */
int     m_cstep;                 /*        number of creep+shrink step to be produced */
int     m_dl_cs;                 /*        dead load activation in composite cross sections */
int     m_free[2];               /*        free integer for later use */
float   m_dt;                    /* [  93] duration of creep+shrink step */
float   m_rh;                    /* [   8] relative humidity in this creep+shrink step */
float   m_temp;                  /* [   8] temperture in this creep+shrink step */
} typeCDB_CSM_CS;

#define CSM_CREE_VER 200501
typedef struct tagCDB_CSM_CREE { /* 15/-4  creep+shrink values for manual input */
int     m_mno;                   /*        Material number */
int     m_grp;                   /*        Group number */
float   m_phi;                   /*        total creep factor from first loading til infinite */
float   m_eps;                   /*        total shrinkage coefficient */
float   m_relax;                 /*        total tendon relaxation */
} typeCDB_CSM_CREE;

#define CSG_CS_VER 200501
typedef struct tagCDB_CSG_CS {   /* 15/-10  Construction Stage */
int     m_no;                    /*        construction stage number */
chr     m_titl[32];              /*        Designation */
float   m_dt;                    /* [  93] duration of construction stage */
} typeCDB_CSG_CS;

#define CSG_CGRP_VER 200501
typedef struct tagCDB_CSG_CGRP { /* 15/-11  Group specification */
int     m_ics;                   /*        corresponding cs number */
int     m_no;                    /*        group number */
int     m_act;                   /*        group action */
int     m_act2;                  /*        group action cont'd */
int     m_ptyp;                  /*        type of prestressing */
int     m_plq;                   /*        primary load case swelling */
int     m_mno;                   /*        material number */
float   m_facs;                  /*        stiffness factor */
float   m_alph;                  /*        alpha factor */
float   m_hw;                    /* [  13] ground water level */
float   m_k;                     /*        earth pressure coefficient */
float   m_p;                     /*        prestress force */
} typeCDB_CSG_CGRP;

#define CSG_CLAS_VER 200501
typedef struct tagCDB_CSG_CLAS { /* 15/-12  Load specification */
int     m_ics;                   /*        corresponding cs number */
int     m_no;                    /*        number of referenced loadcase */
int     m_opt;                   /*        option of the load */
float   m_fact;                  /*        factor for loads */
} typeCDB_CSG_CLAS;

#define CSG_CSYS_VER 200501
typedef struct tagCDB_CSG_CSYS { /* 15/-13  System specification */
int     m_ics;                   /*        corresponding cs number */
int     m_prob;                  /*        problem type */
} typeCDB_CSG_CSYS;

#define CSG_CCRL_VER 200501
typedef struct tagCDB_CSG_CCRL { /* 15/-14  Computation control */
int     m_ics;                   /*        corresponding cs number */
int     m_opt;                   /*        control option */
int     m_save;                  /*        save interval */
int     m_facq;                  /*        not used */
float   m_val;                   /*        value of the option */
float   m_fmax;                  /*        2nd value of the option */
float   m_fmin;                  /*        3rd value of the option */
float   m_emax;                  /*        4th value of the option */
float   m_emin;                  /*        5th value of the option */
float   m_v6;                    /*        6th value of the option */
float   m_v7;                    /*        7th value of the option */
float   m_v8;                    /*        8th value of the option */
} typeCDB_CSG_CCRL;

#define CSG_CGW_VER 200501
typedef struct tagCDB_CSG_CGW {  /* 15/-15  Change ground water level */
int     m_ics;                   /*        corresponding cs number */
float   m_hw;                    /* [  13] new ground water level */
} typeCDB_CSG_CGW;

#define CSG_ECHO_VER 200501
typedef struct tagCDB_CSG_ECHO { /* 15/-16  Echo options */
int     m_ics;                   /*        corresponding cs number */
int     m_opt;                   /*        echo option */
int     m_val;                   /*        value of the option */
} typeCDB_CSG_ECHO;

#define CSM_LC1_ID 1
#define CSM_LC1_VER 200501
typedef struct tagCDB_CSM_LC1 {  /* 15/LC  CSM loadcase parameters Group members */
int     m_id;                    /*        identifier 1 */
int     m_grp;                   /*        Group number */
float   m_t1;                    /* [  93] age at the end of loadcase */
float   m_sumeps;                /*        accumulated shrinkage strain */
} typeCDB_CSM_LC1;

#define CSM_LC2_ID 2
#define CSM_LC2_VER 200501
typedef struct tagCDB_CSM_LC2 {  /* 15/LC  CSM loadcase parameters quad-tendon members */
int     m_id;                    /*        identifier 2 */
int     m_grp;                   /*        quad-tendon number */
float   m_t1;                    /* [  93] age at the end of loadcase */
float   m_sumrelax;              /*        accumulated quad-tendon relaxation */
} typeCDB_CSM_LC2;

#define VIEW_VER 0
typedef struct tagCDB_VIEW {     /* 18/-1  View definitions (Exchange ANIMATOR-WINGRAF) */
int     m_iachs;                 /*        downward direction (compare 10/0) */
int     m_pers;                  /*        Perspective */
int     m_lc;                    /*        loadcase */
int     m_vopt;                  /*        View Options (Bitcode I) */
int     m_eopt;                  /*        Element Options (Bitcode II) */
int     m_copt;                  /*        Colour Options (Bitcode III) */
int     m_dummy[3];              /*        reserved */
int     m_topt;                  /*        Exchange option */
float   m_xbl;                   /* [1001] X-coordinate of view point */
float   m_ybl;                   /* [1001] Y-coordinate of view point */
float   m_zbl;                   /* [1001] Z-coordinate of view point */
float   m_xcam;                  /* [1001] X-coordinate of camera point */
float   m_ycam;                  /* [1001] Y-coordinate of camera point */
float   m_zcam;                  /* [1001] Z-coordinate of camera point */
float   m_fakv;                  /*        Factor of deformed structure */
float   m_ssiz;                  /*        Size of supports (0.-100.) */
float   m_wmag;                  /*        Warping magnification (0.-100.) */
float   m_fovy;                  /* [   5] perspective angle of field of view */
float   m_xup;                   /*        X-part Up Vector */
float   m_yup;                   /*        Y-part Up Vector */
float   m_zup;                   /*        Z-part Up Vector */
} typeCDB_VIEW;

#define VIEW_SEL_VER 0
typedef struct tagCDB_VIEW_SEL { /* 18/-2  currently selected elements in WINGRAF */
int     m_id;                    /*        Identifikator */
struct {
int     m_low;
int     m_upp;
      } m_r[32];                 /*        Range lower and upper limit */
} typeCDB_VIEW_SEL;

#define VIEW_SRE_VER 0
typedef struct tagCDB_VIEW_SRE { /* 18/-3  currently selected results in WINGRAF */
int     m_kwh;                   /*        Main key of current item */
int     m_kwl;                   /*        Secondary key of cuurent item (LF,MAT) */
int     m_values[14];            /*        Selected values of this record type */
} typeCDB_VIEW_SRE;

#define MTXT_0_ID 0
#define MTXT_0_VER 0
typedef struct tagCDB_MTXT_0 {   /* 18/-4  Header for membrane manufacturing */
int     m_id;                    /*        identificator = 0 */
int     m_lf;                    /*        used load case of a deformed structure Lastfallnummer einer ver */
int     m_bits;                  /*        Bitpattern of conditions of evaluation */
int     m_nfl;                   /*        Number of manufacturing areas */
int     m_nqu;                   /*        total number of QUADS within those areas */
int     m_nno;                   /*        Number of new nodes inserted */
} typeCDB_MTXT_0;

#define MTXT_NOD_VER 0
typedef struct tagCDB_MTXT_NOD { /* 18/-4  Definition of new nodes */
int     m_no;                    /*        Number of new interpolated node */
int     m_quad;                  /*        Nummer of QUAD-element containing this node */
float   m_s;                     /*        S-Koordinate im QUAD-Element */
float   m_t;                     /*        T-Koordinate im QUAD-Element */
} typeCDB_MTXT_NOD;

#define MTXT_ELM_VER 0
typedef struct tagCDB_MTXT_ELM { /* 18/-4  Definition of manufacturing elements */
int     m_no;                    /*        Number of manufacturing area */
int     m_quad;                  /*        Number of QUAD-element */
int     m_n1;                    /*        1st node (< 0 if new interpolated node) */
int     m_n2;                    /*        2nd node (< 0 if new interpolated node) */
int     m_n3;                    /*        3rd node (< 0 if new interpolated node) */
int     m_n4;                    /*        4th node (< 0 if new interpolated node) */
} typeCDB_MTXT_ELM;

#define VIEW_MCO_VER 0
typedef struct tagCDB_VIEW_MCO { /* 18/-5  Colour of material */
int     m_no;                    /*        Number of material / group */
float   m_red;                   /*        RGBA: red color */
float   m_green;                 /*        RGBA: green color */
float   m_blue;                  /*        RGBA: blue color */
float   m_alpha;                 /*        RGBA: alpha value */
} typeCDB_VIEW_MCO;

#define VIEW_GCO_VER 0
typedef struct tagCDB_VIEW_GCO { /* 18/-6  Colour of group */
int     m_no;                    /*        Number of material / group */
float   m_red;                   /*        RGBA: red color */
float   m_green;                 /*        RGBA: green color */
float   m_blue;                  /*        RGBA: blue color */
float   m_alpha;                 /*        RGBA: alpha value */
} typeCDB_VIEW_GCO;

#define ANI_SELE_ID 1
#define ANI_SELE_VER 0
typedef struct tagCDB_ANI_SELE { /* 18/-101  Dialogbox Animator selection request */
int     m_sele;                  /*        identifier 1 : selection request */
int     m_igrp;                  /*        element-group switch */
#define ANI_SELE_IGRP_ELEM 0
#define ANI_SELE_IGRP_BEAM 1
#define ANI_SELE_IGRP_GRUP 2
#define ANI_SELE_IGRP_SLN 3
int     m_nsel;                  /*        necessary-possible amount of selected elements */
int     m_etyp;                  /*        requested element type - multiple records allowed */
int     m_from;                  /*        select only elements or groups from FROM to TO */
int     m_to;                    /*        TO */
} typeCDB_ANI_SELE;

#define ANI_CTRL_ID 2
#define ANI_CTRL_VER 0
typedef struct tagCDB_ANI_CTRL { /* 18/-101  Dialogbox Animator drawing controls */
int     m_sele;                  /*        identifier 2 : drawing controls */
int     m_igrp;                  /*        element-group switch as in record 018/-101 */
int     m_nsel;                  /*        free */
int     m_etyp;                  /*        element type - see 018/-101:1 */
int     m_from;                  /*        drawing controls for elements/groups from FROM to TO */
int     m_to;                    /*        TO */
int     m_style;                 /*        representation style guide number */
float   m_rgba[4];               /*        colour and transparency factor - only for STYLE=1 */
} typeCDB_ANI_CTRL;

#define ANI_SRES_VER 0
typedef struct tagCDB_ANI_SRES { /* 18/-103  Selection result from Animator */
int     m_id101;                 /*        access ID of 18/-101 to check if selection allready done */
int     m_igrp;                  /*        element-group switch as defined in 018/-101 */
int     m_isel;                  /*        termination control */
int     m_etyp;                  /*        element type - see 018/-101:1 */
int     m_from;                  /*        first selected element or group */
int     m_to;                    /*        last " */
int     m_free;                  /*        not used */
float   m_x;                     /* [1001] sectional abscissa */
} typeCDB_ANI_SRES;

#define LC_SELF_VER 0
typedef struct tagCDB_LC_SELF {  /* 18/LCD  Self weight loading of elements from ASE */
int     m_kwh;                   /*        Type of load element */
int     m_nr;                    /*        all other values as in KWH/LC */
int     m_typ;                   /*        all other values as in KWH/LC */
float   m_pval[1];               /*        all other values as in KWH/LC */
                                 /*        unknown length! */
#define ANZOF_LC_SELF_PVAL(il) ((il)-offsetof(typeCDB_LC_SELF,m_pval))/sizeof(float)
} typeCDB_LC_SELF;

#define GRP_BIL_VER 201112
typedef struct tagCDB_GRP_BIL {  /* 19/LC  Bilances of Flow in HYDRA */
int     m_id;                    /*        type of result */
int     m_nr;                    /*        group number */
float   m_qinp;                  /*        Quantity of inflow */
float   m_qout;                  /*        Quantity of outflow */
float   m_qnew;                  /*        Quantity generated in domain */
float   m_ener;                  /*        Energy term */
} typeCDB_GRP_BIL;

#define NODE_VER 200501
typedef struct tagCDB_NODE {     /* 20/00  Nodes */
int     m_nr;                    /*        node-number */
int     m_inr;                   /*        internal node-number */
int     m_kfix;                  /*        degree of freedoms */
int     m_ncod;                  /*        additional bit code */
float   m_xyz[3];                /* [1001] X-Y-Z-ordinates */
} typeCDB_NODE;

#define NODE_GRC_ID 0
#define NODE_GRC_VER 200501
typedef struct tagCDB_NODE_GRC { /* 20/11  number of Nodegroups */
int     m_id;
int     m_maxgrp;                /*        maximum number of groups per node */
} typeCDB_NODE_GRC;

#define NODE_GRP_VER 200501
typedef struct tagCDB_NODE_GRP { /* 20/11  Nodegroups */
int     m_n;                     /*        node-number */
int     m_igrp[1];               /*        group-numbers connecting to node */
                                 /*        unknown length! */
#define ANZOF_NODE_GRP_IGRP(il) ((il)-offsetof(typeCDB_NODE_GRP,m_igrp))/sizeof(int)
} typeCDB_NODE_GRP;

#define NODE_KIC_ID 0
#define NODE_KIC_VER 200501
typedef struct tagCDB_NODE_KIC { /* 21/00  Info on kinematic constraints */
int     m_id;
int     m_nlev;                  /*        depth of recurent coupling (obsolete) */
int     m_nkin;                  /*        maximum number of coupling equations */
int     m_nvar;                  /*        maximum number of coupling factors */
} typeCDB_NODE_KIC;

#define NODE_KIN_VER 201704
typedef struct tagCDB_NODE_KIN { /* 21/00  Standard kinematic constraint */
int     m_ktl;                   /*        type + 100 * depth + 10000*group-number */
int     m_nr;                    /*        node-number */
int     m_kr[2];                 /*        reference nodes */
float   m_dxyz[3];               /*        direction of coupling X/Y/Z-axis */
float   m_dd;                    /*        factor of interpolation for INTP/INTF/INTS */
float   m_ff;                    /*        factor of multiplication (not used) */
} typeCDB_NODE_KIN;

#define NODE_KIG_VER 201704
typedef struct tagCDB_NODE_KIG { /* 21/00  general constraints (equation list) */
int     m_ktl;
struct {
int     m_nr;
int     m_nd;
      } m_id[256];               /*        node+degree-number of dependent (0) */
} typeCDB_NODE_KIG;

#define NODE_KIF_VER 201704
typedef struct tagCDB_NODE_KIF { /* 21/00  general constraints (factor list) */
int     m_ktl;                   /*        99 + 100 * depth */
int     m_id;                    /*        identifier 0 */
float   m_fr[255];               /*        factors of constrained equation */
} typeCDB_NODE_KIF;

#define NODE_KIH_VER 200501
typedef struct tagCDB_NODE_KIH { /* 21/09  Hydraulic couplings */
int     m_ng;                    /*        group-number */
int     m_nr;                    /*        node-number */
int     m_kr;                    /*        reference node */
} typeCDB_NODE_KIH;

#define NODE_KFC_ID 0
#define NODE_KFC_VER 200501
typedef struct tagCDB_NODE_KFC { /* 22/LC  Max. Constraining Forces */
int     m_id;                    /*        identifier 0 */
float   m_px;                    /* [1190] force component X */
float   m_py;                    /* [1190] force component Y */
float   m_pz;                    /* [1190] force component Z */
float   m_mx;                    /* [1194] moment component X */
float   m_my;                    /* [1194] moment component Y */
float   m_mz;                    /* [1194] moment component Z */
float   m_mb;                    /* [1194] warping moment */
} typeCDB_NODE_KFC;

#define NODE_KFO_VER 200501
typedef struct tagCDB_NODE_KFO { /* 22/LC  Constraining forces */
int     m_nr;                    /*        node-number */
float   m_px;                    /* [1190] force component X */
float   m_py;                    /* [1190] force component Y */
float   m_pz;                    /* [1190] force component Z */
float   m_mx;                    /* [1194] moment component X */
float   m_my;                    /* [1194] moment component Y */
float   m_mz;                    /* [1194] moment component Z */
float   m_mb;                    /* [1194] warping moment */
} typeCDB_NODE_KFO;

#define NODE_L_VER 200601
typedef struct tagCDB_NODE_L {   /* 23/LC  Nodal_loads */
int     m_nr;                    /*        node-number */
int     m_typ;                   /*        type of load */
float   m_px;                    /* [1190] single force X-component */
float   m_py;                    /* [1190] single force Y-component */
float   m_pz;                    /* [1190] single force Z-component */
float   m_mx;                    /* [1194] single moment X-component */
float   m_my;                    /* [1194] single moment Y-component */
float   m_mz;                    /* [1194] single moment Z-component */
float   m_mb;                    /* [1195] warping moment */
} typeCDB_NODE_L;

#define NODE_LW_VER 200501
typedef struct tagCDB_NODE_LW {  /* 23/LC  prescribed support displacements */
int     m_nr;                    /*        node-number */
int     m_typ;                   /*        type of load */
float   m_wx;                    /* [1003] Displacement X */
float   m_wy;                    /* [1003] Displacement Y */
float   m_wz;                    /* [1003] Displacement Z */
float   m_rx;                    /* [1004] Rotation X-X */
float   m_ry;                    /* [1004] Rotation Y-Y */
float   m_rz;                    /* [1004] Rotation Z-Z */
} typeCDB_NODE_LW;

#define NODE_ACC_VER 200905
typedef struct tagCDB_NODE_ACC { /* 23/LC  Base acceleration */
int     m_nr;                    /*        node number / influence load case */
int     m_typ;                   /*        type of load (=10) */
float   m_ax;                    /* [1202] transversal acceleration X */
float   m_ay;                    /* [1202] transversal acceleration Y */
float   m_az;                    /* [1202] transversal acceleration Z */
float   m_axx;                   /* [1207] rotational acceleration X-X */
float   m_ayy;                   /* [1207] rotational acceleration Y-Y */
float   m_azz;                   /* [1207] rotational acceleration Z-Z */
float   m_ex;                    /* [1001] reference point for rotational acceleration */
float   m_ey;                    /* [1001] reference point for rotational acceleration */
float   m_ez;                    /* [1001] reference point for rotational acceleration */
float   m_exref;                 /*        V25: if a value is present (length criteria) */
} typeCDB_NODE_ACC;

#define NODE_LA_VER 200904
typedef struct tagCDB_NODE_LA {  /* 23/LC  prescribed nodal accelerations */
int     m_nr;                    /*        node-number */
int     m_typ;                   /*        type of load */
float   m_ax;                    /* [1003] acceleration X */
float   m_ay;                    /* [1003] acceleration Y */
float   m_az;                    /* [1003] acceleration Z */
float   m_arx;                   /* [1004] Rotation X-X */
float   m_ary;                   /* [1004] Rotation Y-Y */
float   m_arz;                   /* [1004] Rotation Z-Z */
} typeCDB_NODE_LA;

#define NODE_ROT_VER 200607
typedef struct tagCDB_NODE_ROT { /* 23/LC  Rotation of Body */
int     m_nr;                    /*        influence reference */
int     m_typ;                   /*        type of load (=20) */
float   m_axx;                   /* [1207] rotational acceleration X-X  (= vxx**2) */
float   m_ayy;                   /* [1207] rotational acceleration Y-Y  (= vyy**2) */
float   m_azz;                   /* [1207] rotational acceleration Z-Z  (= vzz**2) */
float   m_ex;                    /* [1001] reference point for rotational acceleration */
float   m_ey;                    /* [1001] reference point for rotational acceleration */
float   m_ez;                    /* [1001] reference point for rotational acceleration */
} typeCDB_NODE_ROT;

#define N_DISPC_ID 0
#define N_DISPC_VER 200501
typedef struct tagCDB_N_DISPC {  /* 24/LC  Max. Displacements and support forces */
int     m_id;
float   m_ux;                    /* [1003] displacement X */
float   m_uy;                    /* [1003] displacement Y */
float   m_uz;                    /* [1003] displacement Z */
float   m_urx;                   /* [1004] rotation X */
float   m_ury;                   /* [1004] rotation Y */
float   m_urz;                   /* [1004] rotation Z */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support X */
float   m_py;                    /* [1151] nodal support Y */
float   m_pz;                    /* [1151] nodal support Z */
float   m_mx;                    /* [1152] support moment X */
float   m_my;                    /* [1152] support moment Y */
float   m_mz;                    /* [1152] support moment Z */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISPC;

#define N_DISPIC_ID 0
#define N_DISPIC_VER 200501
typedef struct tagCDB_N_DISPIC { /* 26/LC  Max. Displacement and forces increments */
int     m_id;
float   m_ux;                    /* [1003] displacement X */
float   m_uy;                    /* [1003] displacement Y */
float   m_uz;                    /* [1003] displacement Z */
float   m_urx;                   /* [1004] rotation X */
float   m_ury;                   /* [1004] rotation Y */
float   m_urz;                   /* [1004] rotation Z */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support X */
float   m_py;                    /* [1151] nodal support Y */
float   m_pz;                    /* [1151] nodal support Z */
float   m_mx;                    /* [1152] support moment X */
float   m_my;                    /* [1152] support moment Y */
float   m_mz;                    /* [1152] support moment Z */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISPIC;

#define N_DISPTC_ID 0
#define N_DISPTC_VER 200702
typedef struct tagCDB_N_DISPTC { /* 27/LC  Max. Cooordinate offsets */
int     m_id;
float   m_ux;                    /* [1003] displacement X */
float   m_uy;                    /* [1003] displacement Y */
float   m_uz;                    /* [1003] displacement Z */
float   m_urx;                   /* [1004] rotation X */
float   m_ury;                   /* [1004] rotation Y */
float   m_urz;                   /* [1004] rotation Z */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support X */
float   m_py;                    /* [1151] nodal support Y */
float   m_pz;                    /* [1151] nodal support Z */
float   m_mx;                    /* [1152] support moment X */
float   m_my;                    /* [1152] support moment Y */
float   m_mz;                    /* [1152] support moment Z */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISPTC;

#define N_DISP_VER 200501
typedef struct tagCDB_N_DISP {   /* 24/LC  Displacements and support forces of nodes */
int     m_nr;                    /*        node-number */
float   m_ux;                    /* [1003] displacement */
float   m_uy;                    /* [1003] displacement */
float   m_uz;                    /* [1003] displacement */
float   m_urx;                   /* [1004] rotation */
float   m_ury;                   /* [1004] rotation */
float   m_urz;                   /* [1004] rotation */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support */
float   m_py;                    /* [1151] nodal support */
float   m_pz;                    /* [1151] nodal support */
float   m_mx;                    /* [1152] support moment */
float   m_my;                    /* [1152] support moment */
float   m_mz;                    /* [1152] support moment */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISP;

#define N_DISPI_VER 200501
typedef struct tagCDB_N_DISPI {  /* 26/LC  Displacement increments and residual forces */
int     m_nr;                    /*        node-number */
float   m_ux;                    /* [1003] displacement */
float   m_uy;                    /* [1003] displacement */
float   m_uz;                    /* [1003] displacement */
float   m_urx;                   /* [1004] rotation */
float   m_ury;                   /* [1004] rotation */
float   m_urz;                   /* [1004] rotation */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support */
float   m_py;                    /* [1151] nodal support */
float   m_pz;                    /* [1151] nodal support */
float   m_mx;                    /* [1152] support moment */
float   m_my;                    /* [1152] support moment */
float   m_mz;                    /* [1152] support moment */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISPI;

#define N_DISPT_VER 200702
typedef struct tagCDB_N_DISPT {  /* 27/LC  Cooordinate offsets */
int     m_nr;                    /*        node-number */
float   m_ux;                    /* [1003] displacement */
float   m_uy;                    /* [1003] displacement */
float   m_uz;                    /* [1003] displacement */
float   m_urx;                   /* [1004] rotation */
float   m_ury;                   /* [1004] rotation */
float   m_urz;                   /* [1004] rotation */
float   m_urb;                   /* [1005] twisting */
float   m_px;                    /* [1151] nodal support */
float   m_py;                    /* [1151] nodal support */
float   m_pz;                    /* [1151] nodal support */
float   m_mx;                    /* [1152] support moment */
float   m_my;                    /* [1152] support moment */
float   m_mz;                    /* [1152] support moment */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_N_DISPT;

#define N_VELOC_ID 0
#define N_VELOC_VER 200501
typedef struct tagCDB_N_VELOC {  /* 25/LC  Max. velocities and accelerations of nodes */
int     m_id;
float   m_vx;                    /* [1201] velocity X */
float   m_vy;                    /* [1201] velocity Y */
float   m_vz;                    /* [1201] velocity Z */
float   m_vrx;                   /* [1206] angular veloc. XX */
float   m_vry;                   /* [1206] angular veloc. YY */
float   m_vrz;                   /* [1206] angular veloc. ZZ */
float   m_vbb;                   /* [1208] twisting velocity */
float   m_ax;                    /* [1202] acceleration X */
float   m_ay;                    /* [1202] acceleration Y */
float   m_az;                    /* [1202] acceleration Z */
float   m_arx;                   /* [1207] ang. acceler. XX */
float   m_ary;                   /* [1207] ang. acceler. YY */
float   m_arz;                   /* [1207] ang. acceler. ZZ */
float   m_abb;                   /* [1209] twisting acceler */
} typeCDB_N_VELOC;

#define N_VELO_VER 200501
typedef struct tagCDB_N_VELO {   /* 25/LC  velocitys and acceleration of nodes */
int     m_nr;                    /*        node-number */
float   m_vx;                    /* [1201] velocity X */
float   m_vy;                    /* [1201] velocity Y */
float   m_vz;                    /* [1201] velocity Z */
float   m_vrx;                   /* [1206] angular veloc. X-X */
float   m_vry;                   /* [1206] angular veloc. Y-Y */
float   m_vrz;                   /* [1206] angular veloc. Z-Z */
float   m_vbb;                   /* [1208] twisting velocity */
float   m_ax;                    /* [1202] acceleration X */
float   m_ay;                    /* [1202] acceleration Y */
float   m_az;                    /* [1202] acceleration Z */
float   m_arx;                   /* [1207] ang. acceler. X-X */
float   m_ary;                   /* [1207] ang. acceler. Y-Y */
float   m_arz;                   /* [1207] ang. acceler. Z-Z */
float   m_abb;                   /* [1209] twisting acceler */
} typeCDB_N_VELO;

#define SGRP_ID 0
#define SGRP_VER 200903
typedef struct tagCDB_SGRP {     /* 37/ID  Secondary groups */
int     m_id0;                   /*        identification of general data (0) */
int     m_typ;                   /*        Bit infos of selected element types */
int     m_bit;                   /*        Bit infos on selections contained in that group */
pckcode m_text[17];              /*        Designation of sgrp */
#define SGRP_TEXT_LEN 32
} typeCDB_SGRP;

#define SGRP_BOX_ID 1
#define SGRP_BOX_VER 200903
typedef struct tagCDB_SGRP_BOX { /* 37/ID  Selective Basic-Volume */
int     m_id;                    /*        identification of data (1) */
int     m_typ;                   /*        type of property volume */
int     m_bit;                   /*        option */
float   m_par[7][3];             /* [1001] PARAMETERS OF BOX par(3,0:6) */
} typeCDB_SGRP_BOX;

#define SGRP_POL_ID 2
#define SGRP_POL_VER 200903
typedef struct tagCDB_SGRP_POL { /* 37/ID  Selective Polyeder-Volume */
int     m_id;                    /*        identification of data (2) */
int     m_typ;                   /*        number of vertices */
int     m_bit;                   /*        option */
float   m_t[4][3];               /*        transformation matrix to local coordinates */
float   m_ext[3][3];             /* [1001] global extension, local extensions min/max */
float   m_vert[63][3];           /* [1001] vertices in local coordinates r,s,t */
} typeCDB_SGRP_POL;

#define SGRP_LIS_VER 200903
typedef struct tagCDB_SGRP_LIS { /* 37/ID  Calculated Selective Element List */
int     m_id;                    /*        identifier of element to be selected (positive) */
int     m_nr[255];               /*        element numbers */
} typeCDB_SGRP_LIS;

#define SGRP_ADD_VER 200903
typedef struct tagCDB_SGRP_ADD { /* 37/ID  Selecting Element List */
int     m_id;                    /*        identifier of element to be selected (positive) */
int     m_nr[255];               /*        element numbers */
} typeCDB_SGRP_ADD;

#define SGRP_SUB_VER 200903
typedef struct tagCDB_SGRP_SUB { /* 37/ID  Excluding Element List */
int     m_id;                    /*        identifier of element to be selected (positive) */
int     m_nr[255];               /*        element numbers */
} typeCDB_SGRP_SUB;

#define SGRP_SEL_VER 200903
typedef struct tagCDB_SGRP_SEL { /* 37/ID  Property-Values */
int     m_id;                    /*        identifier of element to be modified */
int     m_type;                  /*        Option to perform */
int     m_bit;                   /*        bit pattern of selected data */
int     m_itp;                   /*        key value for orientation of coordinate system */
int     m_div;                   /*        key value of subdivision or other extended data */
int     m_idq;                   /*        key value of cross section or other extended data */
int     m_idh;                   /*        key value of hinge conditions or other extended data */
int     m_idx;                   /*        key value of other extended data */
float   m_trot;                  /*        Fractional rotation about */
float   m_tal[3];                /*        Vector to be aligned as local axis */
float   m_rdat[4];               /*        reserved for values not in DATA */
int     m_data[64];              /*        equivalenced data structure of that */
} typeCDB_SGRP_SEL;

#define HIST_HED_VER 200501
typedef struct tagCDB_HIST_HED { /* 80/LC  TimeHistoryTitle */
float   m_rid;                   /*        Identifier of history type */
pckcode m_title[33];             /*        Designation */
#define HIST_HED_TITLE_LEN 64
} typeCDB_HIST_HED;

#define HIST_PAR_VER 200501
typedef struct tagCDB_HIST_PAR { /* 80/LC  IterationParameters */
float   m_rid;                   /*        identifier */
float   m_val;                   /*        current value */
float   m_min;                   /*        minimum allowed value */
float   m_max;                   /*        maximum allowed value */
pckcode m_name[17];              /*        name of parameter */
#define HIST_PAR_NAME_LEN 32
} typeCDB_HIST_PAR;

#define HIST_VER 200502
typedef struct tagCDB_HIST {     /* 80/LC  Identification of history elements */
float   m_rid;                   /*        Identification -100 < RID < 0. */
struct {
int     m_nr;
int     m_typ;
      } m_item[32];              /*        History element */
} typeCDB_HIST;

#define HIST_VAL_VER 200501
typedef struct tagCDB_HIST_VAL { /* 80/LC  Transient data */
float   m_tt;                    /*        Time/frequency */
float   m_vb[32];                /*        curve values */
} typeCDB_HIST_VAL;

#define SLVL_DAT_VER 200902
typedef struct tagCDB_SLVL_DAT { /* 87/0  Structural Storey Level Data */
int     m_nr;                    /*        Storey Level ID (34/NR) */
int     m_nref[2];               /*        Node numbers of reference nodes on level */
int     m_nr_cor;                /*        spt number of center of rigidity (COR) */
int     m_nr_com;                /*        spt number of center of mass (COM) */
int     m_creator;               /*        generated by (program) (0=SOFiMSHC, 1=DYNA) */
float   m_zlev;                  /* [1006] Storey elevation, upwards positive (reference) */
float   m_h;                     /* [1001] Storey height */
float   m_xext[2];               /* [1001] Storey extensions in global X [XMIN, XMAX] */
float   m_yext[2];               /* [1001] Storey extensions in global Y [YMIN, YMAX] */
float   m_mass;                  /* [1180] Storey mass */
float   m_xyzm[3];               /* [1001] Coordinates of COM */
float   m_stx;                   /* [1095] Storey stiffness in global X */
float   m_sty;                   /* [1095] Storey stiffness in global Y */
float   m_xyzr[3];               /* [1001] Coordinates of COR */
float   m_cpx;                   /* [1151] Storey capacity in global X */
float   m_cpy;                   /* [1151] Storey capacity in global Y */
pckcode m_text[17];              /*        Designation of level */
#define SLVL_DAT_TEXT_LEN 32
} typeCDB_SLVL_DAT;

#define SLVL_RES_VER 200902
typedef struct tagCDB_SLVL_RES { /* 87/LC  Structural Storey Level Results */
int     m_nr;                    /*        Storey Level ID (34/NR) */
int     m_nr_mode;               /*        mode number (=0: resultant values, e.g. from CQC sup.) */
chr     m_styp[2];               /*        superposition type */
float   m_px;                    /* [1151] base shear in X */
float   m_py;                    /* [1151] base shear in Y */
float   m_pz;                    /* [1151] total vertical load at and above the storey */
float   m_mx;                    /* [1152] moment about X */
float   m_my;                    /* [1152] moment about Y */
float   m_mz;                    /* [1152] moment about Z */
float   m_ux;                    /* [1003] average storey displacement in X (=translations at COR) */
float   m_uy;                    /* [1003] average storey displacement in Y */
float   m_uz;                    /* [1003] average storey displacement in Z */
float   m_rz;                    /* [1004] average storey rotation in XY-plane */
float   m_dx;                    /* [1003] inter-storey drift in X (=difference between top and bottom of  */
float   m_dy;                    /* [1003] inter-storey drift in Y */
float   m_drz;                   /* [1004] inter-storey rotation in XY-plane */
float   m_lsaf;                  /* [  98] modal acceleration (only for NR_MODE>0) */
} typeCDB_SLVL_RES;

#define BEAM_VER 200502
typedef struct tagCDB_BEAM {     /* 100/00  Beams */
int     m_nr;                    /*        beam number */
int     m_node[2];               /*        node number start/end */
int     m_np;                    /*        prop number */
float   m_dl;                    /* [1001] beamlength */
float   m_t[3][3];               /*        transformation matrix */
float   m_ex[2][3];              /* [1001]  */
int     m_nref;                  /*        reference axis */
float   m_spar[2];               /*        distances along a continuous beam or */
float   m_bety;
float   m_betz;
float   m_ldfy;
float   m_ldfz;                  /*        deformation length factor for vz */
} typeCDB_BEAM;

#define BSLN_VER 201606
typedef struct tagCDB_BSLN {     /* 120/00  Design elements */
int     m_nr;                    /*        beam number */
int     m_node[2];               /*        node number start/end */
int     m_np;                    /*        prop number */
float   m_dl;                    /* [1001] beamlength */
float   m_t[3][3];               /*        transformation matrix */
float   m_ex[2][3];              /* [1001]  */
int     m_nref;                  /*        reference axis */
float   m_spar[2];               /*        distances along a continuous beam or */
float   m_bety;
float   m_betz;
float   m_ldfy;
float   m_ldfz;                  /*        deformation length factor for vz */
} typeCDB_BSLN;

#define BSCT_VER 200501
typedef struct tagCDB_BSCT {     /* 140/00  External sections */
int     m_nr;                    /*        beam number */
int     m_node[2];               /*        node number start/end */
int     m_np;                    /*        prop number */
float   m_dl;                    /* [1001] beamlength */
float   m_t[3][3];               /*        transformation matrix */
float   m_ex[2][3];              /* [1001]  */
int     m_nref;                  /*        reference axis */
float   m_spar[2];               /*        distances along a continuous beam or */
float   m_bety;
float   m_betz;
float   m_ldfy;
float   m_ldfz;                  /*        deformation length factor for vz */
} typeCDB_BSCT;

#define BEAM_SCT_ID 0
#define BEAM_SCT_VER 200502
typedef struct tagCDB_BEAM_SCT { /* 100/00  Beams sections */
int     m_id;                    /*        identifier for sections 0 */
int     m_nq;                    /*        number cross section */
int     m_ityp;                  /*        Bitcodes */
int     m_itp2;                  /*        Connection / Hinges for x=0,x=dl */
float   m_x;                     /* [1001] sectional abscissa */
} typeCDB_BEAM_SCT;

#define BSLN_SCT_ID 0
#define BSLN_SCT_VER 201606
typedef struct tagCDB_BSLN_SCT { /* 120/00  Design element sections */
int     m_id;                    /*        identifier for sections 0 */
int     m_nq;                    /*        number cross section */
int     m_ityp;                  /*        Bitcode I   (identical to 100/0:0) */
int     m_itp2;                  /*        Bitcode II  (identical to 100/0:0) */
float   m_x;                     /* [1001] sectional abscissa */
float   m_t[4][3];               /*        transformation matrix */
float   m_ymin;                  /* [1001] Box of active elements in cut plane */
float   m_zmin;                  /* [1001] Box of active elements in cut plane */
float   m_ymax;                  /* [1001] Box of active elements in cut plane */
float   m_zmax;                  /* [1001] Box of active elements in cut plane */
float   m_xmin;                  /* [1001] Box of active elements in cut plane */
float   m_xmax;                  /* [1001] Box of active elements in cut plane */
float   m_yminsel;               /* [1001] Max user defined size of Box */
float   m_zminsel;               /* [1001] Max user defined size of Box */
float   m_ymaxsel;               /* [1001] Max user defined size of Box */
float   m_zmaxsel;               /* [1001] Max user defined size of Box */
float   m_ysc;                   /* [1001] Coordinate y of shear centre */
float   m_zsc;                   /* [1001] Coordinate z of shear centre */
} typeCDB_BSLN_SCT;

#define BSCT_SCT_ID 0
#define BSCT_SCT_VER 200501
typedef struct tagCDB_BSCT_SCT { /* 140/00  External sections */
int     m_id;                    /*        identifier for sections 0 */
int     m_nq;                    /*        number cross section */
int     m_ityp;                  /*        Bitcode I   (identical to 100/0:0) */
int     m_itp2;                  /*        Bitcode II  (identical to 100/0:0) */
float   m_x;                     /* [1001] sectional abscissa */
float   m_t[4][3];               /*        transformation matrix */
float   m_ymin;                  /* [1001] Box of active elements in cut plane */
float   m_zmin;                  /* [1001] Box of active elements in cut plane */
float   m_ymax;                  /* [1001] Box of active elements in cut plane */
float   m_zmax;                  /* [1001] Box of active elements in cut plane */
float   m_xmin;                  /* [1001] Box of active elements in cut plane */
float   m_xmax;                  /* [1001] Box of active elements in cut plane */
float   m_yminsel;               /* [1001] Max user defined size of Box */
float   m_zminsel;               /* [1001] Max user defined size of Box */
float   m_ymaxsel;               /* [1001] Max user defined size of Box */
float   m_zmaxsel;               /* [1001] Max user defined size of Box */
float   m_ysc;                   /* [1001] Coordinate y of shear centre */
float   m_zsc;                   /* [1001] Coordinate z of shear centre */
} typeCDB_BSCT_SCT;

#define BEAM_TRA_VER 200501
typedef struct tagCDB_BEAM_TRA { /* 100/01  transformation matrix */
int     m_nr;                    /*        beamnumber */
float   m_dl;                    /* [1001] beamlength */
float   m_t[3][3];               /*        transformation matrix */
} typeCDB_BEAM_TRA;

#define BEAM_TRS_VER 200501
typedef struct tagCDB_BEAM_TRS { /* 100/03  Info about dynamic moving beams (TREX) */
int     m_lf;                    /*        Loadcase number containing the train */
int     m_nr;                    /*        Number of Beam */
int     m_bpat;                  /*        Options for BEAM (see TREX in SOFILOAD) */
int     m_noda[4];               /*        Node Numbers for Start of beam element */
int     m_node[4];               /*        Node Numbers for end of beam element */
float   m_xn[2];                 /* [1001] x-values of nodes along load train */
} typeCDB_BEAM_TRS;

#define BEAM_TND_VER 200501
typedef struct tagCDB_BEAM_TND { /* 100/05  tendons of beams */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        tendon number */
int     m_mnr;                   /*        material number of tendon + 1000 * material number of cross-sec */
int     m_iba1;                  /*        construction stage number for placing */
int     m_iba2;                  /*        construction stage number for grouting */
int     m_iba3;                  /*        construction stage number for removing */
float   m_x;                     /* [1011] x-ordinate */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_zz;                    /* [1101] tensoning force */
float   m_az;                    /* [1020] tendon area */
float   m_d;                     /* [1023] diameter */
float   m_uz;                    /* [1023] effect. periphery */
float   m_ny;                    /*        inclination DY/DX */
float   m_nz;                    /*        inclination DZ/DX */
float   m_yhr;                   /* [1011] y-ordinate duct */
float   m_zhr;                   /* [1011] z-ordinate duct */
float   m_ahr;                   /* [1020] area of duct */
float   m_ar;                    /* [1012] reference area */
float   m_temp;                  /* [1215] Temperature */
float   m_redfak;                /*        Reduction factor within transmission length */
float   m_xsi;                   /*        Relative ordinate within total tendon */
} typeCDB_BEAM_TND;

#define BSLN_TND_VER 201606
typedef struct tagCDB_BSLN_TND { /* 120/05  tendons of structural beam lines */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        tendon number */
int     m_mnr;                   /*        material number of tendon + 1000 * material number of cross-sec */
int     m_iba1;                  /*        construction stage number for placing */
int     m_iba2;                  /*        construction stage number for grouting */
int     m_iba3;                  /*        construction stage number for removing */
float   m_x;                     /* [1011] x-ordinate */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_zz;                    /* [1101] tensoning force */
float   m_az;                    /* [1020] tendon area */
float   m_d;                     /* [1023] diameter */
float   m_uz;                    /* [1023] effect. periphery */
float   m_ny;                    /*        inclination DY/DX */
float   m_nz;                    /*        inclination DZ/DX */
float   m_yhr;                   /* [1011] y-ordinate duct */
float   m_zhr;                   /* [1011] z-ordinate duct */
float   m_ahr;                   /* [1020] area of duct */
float   m_ar;                    /* [1012] reference area */
float   m_temp;                  /* [1215] Temperature */
float   m_redfak;                /*        Reduction factor within transmission length */
float   m_xsi;                   /*        Relative ordinate within total tendon */
} typeCDB_BSLN_TND;

#define BSCT_TND_VER 200501
typedef struct tagCDB_BSCT_TND { /* 140/05  tendons of external sections */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        tendon number */
int     m_mnr;                   /*        material number of tendon + 1000 * material number of cross-sec */
int     m_iba1;                  /*        construction stage number for placing */
int     m_iba2;                  /*        construction stage number for grouting */
int     m_iba3;                  /*        construction stage number for removing */
float   m_x;                     /* [1011] x-ordinate */
float   m_y;                     /* [1011] y-ordinate */
float   m_z;                     /* [1011] z-ordinate */
float   m_zz;                    /* [1101] tensoning force */
float   m_az;                    /* [1020] tendon area */
float   m_d;                     /* [1023] diameter */
float   m_uz;                    /* [1023] effect. periphery */
float   m_ny;                    /*        inclination DY/DX */
float   m_nz;                    /*        inclination DZ/DX */
float   m_yhr;                   /* [1011] y-ordinate duct */
float   m_zhr;                   /* [1011] z-ordinate duct */
float   m_ahr;                   /* [1020] area of duct */
float   m_ar;                    /* [1012] reference area */
float   m_temp;                  /* [1215] Temperature */
float   m_redfak;                /*        Reduction factor within transmission length */
float   m_xsi;                   /*        Relative ordinate within total tendon */
} typeCDB_BSCT_TND;

#define BEAM_SL_VER 200501
typedef struct tagCDB_BEAM_SL {  /* 101/LC  single beam loads */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_x;                     /* [1001] load point */
float   m_i_2;                   /* [1001] reserved 0. */
float   m_pa;                    /*        value of load */
float   m_i_4;                   /*        reserved 0. */
float   m_ya;                    /* [1001] eccentr. local y */
float   m_za;                    /* [1001] eccentr. local z */
} typeCDB_BEAM_SL;

#define BEAM_DL_VER 200501
typedef struct tagCDB_BEAM_DL {  /* 101/LC  distributed beam loading on reference */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_x;                     /* [1001] start point */
float   m_l;                     /* [1001] length of load */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
float   m_ya;                    /* [1001] eccentr. local y A */
float   m_za;                    /* [1001] eccentr. local z A */
float   m_ye;                    /* [1001] eccentr. local y E */
float   m_ze;                    /* [1001] eccentr. local z E */
float   m_dya;                   /*        gradient of eccentricity, local y, start */
float   m_dza;                   /*        gradient of eccentricity, local z, start */
float   m_dye;                   /*        gradient of eccentricity, local y, end */
float   m_dze;                   /*        gradient of eccentricity, local z, end */
} typeCDB_BEAM_DL;

#define BEAM_TL_VER 200501
typedef struct tagCDB_BEAM_TL {  /* 101/LC  distributed beam loading on reference */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_x;                     /* [1001] start point */
float   m_l;                     /* [1001] length of load */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
float   m_ya;                    /* [1001] eccentr. local y A */
float   m_za;                    /* [1001] eccentr. local z A */
float   m_ye;                    /* [1001] eccentr. local y E */
float   m_ze;                    /* [1001] eccentr. local z E */
float   m_dya;                   /*        gradient of eccentricity, local y, start */
float   m_dza;                   /*        gradient of eccentricity, local z, start */
float   m_dye;                   /*        gradient of eccentricity, local y, end */
float   m_dze;                   /*        gradient of eccentricity, local z, end */
} typeCDB_BEAM_TL;

#define BEAM_CL_VER 200501
typedef struct tagCDB_BEAM_CL {  /* 101/LC  cubic beamloads */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_x;                     /* [1001] start point */
float   m_l;                     /* [1001] length of load */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
float   m_dpa;                   /*        start derivative */
float   m_dpe;                   /*        end   derivative */
} typeCDB_BEAM_CL;

#define BEAM_WL_VER 200501
typedef struct tagCDB_BEAM_WL {  /* 101/LC  dynamic wind loads */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_fa;                    /*        Factor cross start */
float   m_fe;                    /*        Factor cross end */
float   m_ft;                    /*        Factor frictional */
float   m_vxa;                   /* [1201] wind velocity */
float   m_vya;                   /* [1201] wind velocity */
float   m_vza;                   /* [1201] wind velocity */
float   m_vxe;                   /* [1201] wind velocity */
float   m_vye;                   /* [1201] wind velocity */
float   m_vze;                   /* [1201] wind velocity */
float   m_vxam;                  /* [1201] mean wind velocity */
float   m_vyam;                  /* [1201] mean wind velocity */
float   m_vzam;                  /* [1201] mean wind velocity */
float   m_vxem;                  /* [1201] mean wind velocity */
float   m_vyem;                  /* [1201] mean wind velocity */
float   m_vzem;                  /* [1201] mean wind velocity */
} typeCDB_BEAM_WL;

#define TRUS_WL_VER 200501
typedef struct tagCDB_TRUS_WL {  /* 151/LC  dynamic wind loads */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_fa;                    /*        Factor cross start */
float   m_fe;                    /*        Factor cross end */
float   m_ft;                    /*        Factor frictional */
float   m_vxa;                   /* [1201] wind velocity */
float   m_vya;                   /* [1201] wind velocity */
float   m_vza;                   /* [1201] wind velocity */
float   m_vxe;                   /* [1201] wind velocity */
float   m_vye;                   /* [1201] wind velocity */
float   m_vze;                   /* [1201] wind velocity */
float   m_vxam;                  /* [1201] mean wind velocity */
float   m_vyam;                  /* [1201] mean wind velocity */
float   m_vzam;                  /* [1201] mean wind velocity */
float   m_vxem;                  /* [1201] mean wind velocity */
float   m_vyem;                  /* [1201] mean wind velocity */
float   m_vzem;                  /* [1201] mean wind velocity */
} typeCDB_TRUS_WL;

#define CABL_WL_VER 200501
typedef struct tagCDB_CABL_WL {  /* 161/LC  dynamic wind loads */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of load */
float   m_fa;                    /*        Factor cross start */
float   m_fe;                    /*        Factor cross end */
float   m_ft;                    /*        Factor frictional */
float   m_vxa;                   /* [1201] wind velocity */
float   m_vya;                   /* [1201] wind velocity */
float   m_vza;                   /* [1201] wind velocity */
float   m_vxe;                   /* [1201] wind velocity */
float   m_vye;                   /* [1201] wind velocity */
float   m_vze;                   /* [1201] wind velocity */
float   m_vxam;                  /* [1201] mean wind velocity */
float   m_vyam;                  /* [1201] mean wind velocity */
float   m_vzam;                  /* [1201] mean wind velocity */
float   m_vxem;                  /* [1201] mean wind velocity */
float   m_vyem;                  /* [1201] mean wind velocity */
float   m_vzem;                  /* [1201] mean wind velocity */
} typeCDB_CABL_WL;

#define BEAM_FOC_ID 0
#define BEAM_FOC_VER 200803
typedef struct tagCDB_BEAM_FOC { /* 102/LC  Maximum of Total Beam forces and deformations */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] max. beam length */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsionalmom. */
float   m_ux;                    /* [1003] diplacem. local x */
float   m_uy;                    /* [1003] diplacem. local y */
float   m_uz;                    /* [1003] diplacem. local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
} typeCDB_BEAM_FOC;

#define BEAM_FTC_ID 0
#define BEAM_FTC_VER 200803
typedef struct tagCDB_BEAM_FTC { /* 112/LC  Maximum of Beam forces without plate components */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] max. beam length */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsionalmom. */
float   m_ux;                    /* [1003] diplacem. local x */
float   m_uy;                    /* [1003] diplacem. local y */
float   m_uz;                    /* [1003] diplacem. local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
} typeCDB_BEAM_FTC;

#define BSLN_FTC_ID 0
#define BSLN_FTC_VER 201606
typedef struct tagCDB_BSLN_FTC { /* 122/LC  Maximum of Beam forces without plate components */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] max. beam length */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsionalmom. */
float   m_ux;                    /* [1003] diplacem. local x */
float   m_uy;                    /* [1003] diplacem. local y */
float   m_uz;                    /* [1003] diplacem. local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
} typeCDB_BSLN_FTC;

#define BSCT_FOC_ID 0
#define BSCT_FOC_VER 200803
typedef struct tagCDB_BSCT_FOC { /* 142/LC  Maximum of External sections forces */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] max. beam length */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsionalmom. */
float   m_ux;                    /* [1003] diplacem. local x */
float   m_uy;                    /* [1003] diplacem. local y */
float   m_uz;                    /* [1003] diplacem. local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
} typeCDB_BSCT_FOC;

#define BEAM_FOR_VER 201109
typedef struct tagCDB_BEAM_FOR { /* 102/LC  Total Beam forces and deformations */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] distance from start */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsional moment */
float   m_ux;                    /* [1003] diplacement local x */
float   m_uy;                    /* [1003] diplacement local y */
float   m_uz;                    /* [1003] diplacement local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
float   m_q1;                    /*        quaternion component q1 */
float   m_q2;                    /*        quaternion component q2 */
float   m_q3;                    /*        quaternion component q3 */
float   m_q0;                    /*        quaternion component q0 */
float   m_uxx;                   /* [1003] translation in global X */
float   m_uyy;                   /* [1003] translation in global Y */
float   m_uzz;                   /* [1003] translation in global Z */
} typeCDB_BEAM_FOR;

#define BEAM_FTR_VER 201109
typedef struct tagCDB_BEAM_FTR { /* 112/LC  Beam forces without plate components */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] distance from start */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsional moment */
float   m_ux;                    /* [1003] diplacement local x */
float   m_uy;                    /* [1003] diplacement local y */
float   m_uz;                    /* [1003] diplacement local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
float   m_q1;                    /*        quaternion component q1 */
float   m_q2;                    /*        quaternion component q2 */
float   m_q3;                    /*        quaternion component q3 */
float   m_q0;                    /*        quaternion component q0 */
float   m_uxx;                   /* [1003] translation in global X */
float   m_uyy;                   /* [1003] translation in global Y */
float   m_uzz;                   /* [1003] translation in global Z */
} typeCDB_BEAM_FTR;

#define BSLN_FTR_VER 201606
typedef struct tagCDB_BSLN_FTR { /* 122/LC  Beam forces without plate components */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] distance from start */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsional moment */
float   m_ux;                    /* [1003] diplacement local x */
float   m_uy;                    /* [1003] diplacement local y */
float   m_uz;                    /* [1003] diplacement local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
float   m_q1;                    /*        quaternion component q1 */
float   m_q2;                    /*        quaternion component q2 */
float   m_q3;                    /*        quaternion component q3 */
float   m_q0;                    /*        quaternion component q0 */
float   m_uxx;                   /* [1003] translation in global X */
float   m_uyy;                   /* [1003] translation in global Y */
float   m_uzz;                   /* [1003] translation in global Z */
} typeCDB_BSLN_FTR;

#define BSCT_FOR_VER 201109
typedef struct tagCDB_BSCT_FOR { /* 142/LC  External sections forces */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] distance from start */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsional moment */
float   m_ux;                    /* [1003] diplacement local x */
float   m_uy;                    /* [1003] diplacement local y */
float   m_uz;                    /* [1003] diplacement local z */
float   m_phix;                  /* [1004] rotation local x */
float   m_phiy;                  /* [1004] rotation local y */
float   m_phiz;                  /* [1004] rotation local z */
float   m_phiw;                  /* [1005] twisting */
float   m_mt3;                   /* [1103] 3rd torsionalmom */
float   m_pa;                    /* [1095] axial bedding */
float   m_pt;                    /* [1095] transverse bedding */
float   m_pty;                   /* [1095] local y component of transverse bedding */
float   m_ptz;                   /* [1095] local z component of transverse bedding */
float   m_q1;                    /*        quaternion component q1 */
float   m_q2;                    /*        quaternion component q2 */
float   m_q3;                    /*        quaternion component q3 */
float   m_q0;                    /*        quaternion component q0 */
float   m_uxx;                   /* [1003] translation in global X */
float   m_uyy;                   /* [1003] translation in global Y */
float   m_uzz;                   /* [1003] translation in global Z */
} typeCDB_BSCT_FOR;

#define BEAM_FOX_VER 200501
typedef struct tagCDB_BEAM_FOX { /* 102/0  Total External Beam forces */
int     m_nq;                    /*        section number */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] abscissa */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsion.moment */
} typeCDB_BEAM_FOX;

#define BSCT_FOX_VER 200501
typedef struct tagCDB_BSCT_FOX { /* 142/0  Total External Forces for external sections */
int     m_nq;                    /*        section number */
int     m_nr;                    /*        beamnumber */
float   m_x;                     /* [1001] abscissa */
float   m_n;                     /* [1101] normal force */
float   m_vy;                    /* [1102] y-shear force */
float   m_vz;                    /* [1102] z-shear force */
float   m_mt;                    /* [1103] torsional moment */
float   m_my;                    /* [1104] bending moment My */
float   m_mz;                    /* [1104] bending moment Mz */
float   m_mb;                    /* [1105] warping moment Mb */
float   m_mt2;                   /* [1103] 2nd torsion.moment */
} typeCDB_BSCT_FOX;

#define BEAM_STI_VER 200501
typedef struct tagCDB_BEAM_STI { /* 103/LC  Stiffness of beams */
int     m_nr;                    /*        beam number */
float   m_x;                     /* [1001] distance from start */
float   m_ea;                    /* [  62] normal stiffness */
float   m_gay;                   /* [  62] y-shear stiffness */
float   m_gaz;                   /* [  62] z-shear stiffness */
float   m_git;                   /* [  83] torsional stiffness */
float   m_eiy;                   /* [  83] bending stiffness y */
float   m_eiz;                   /* [  83] bending stiffness z */
float   m_eiyz;                  /* [  83] bending stiffness yz */
float   m_gayz;                  /* [  62] yz-shear stiffness */
float   m_kpx;                   /* [   8] plastic strain x */
float   m_kpy;                   /* [  17] plastic curvature y */
float   m_kpz;                   /* [  17] plastic curvature z */
float   m_emin;                  /* [1081] minimum strain */
float   m_emax;                  /* [1081] maximum strain */
float   m_ge1;                   /* [1101] Residual of current step (Crisfield) */
float   m_ge2;                   /* [1104] Residual of current step (Crisfield) */
float   m_ge3;                   /* [1104] Residual of current step (Crisfield) */
float   m_ea0;                   /* [  83] lin. stiffness EA */
float   m_eiy0;                  /* [  83] lin. stiffness EIy */
float   m_eiz0;                  /* [  83] lin. stiffness EIz */
float   m_dysm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_dzsm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_pre;                   /* [1101] primary axial force */
float   m_ys;                    /* [1001] y-eccentricity of centre of gravity */
float   m_zs;                    /* [1001] z-eccentricity of centre of gravity */
float   m_ecm;                   /*        warping stiffness */
float   m_gcms;                  /*        secondary torsion */
float   m_ni;                    /* [1101] inner normal force */
float   m_vyi;                   /* [1102] inner y-shear force */
float   m_vzi;                   /* [1102] inner z-shear force */
float   m_mti;                   /* [1103] inner torsional moment */
float   m_myi;                   /* [1104] inner bending moment My */
float   m_mzi;                   /* [1104] inner bending moment Mz */
float   m_mbi;                   /* [1105] inner warping moment Mb */
float   m_e0;                    /* [1081] total strain x */
float   m_gkpy;                  /* [  17] total curvature y */
float   m_gkpz;                  /* [  17] total curvature z */
float   m_kfvy;                  /*        plastic factor V-y */
float   m_kfvz;                  /*        plastic factor V-z */
float   m_kfmt;                  /*        plastic factor M-t */
float   m_de_0[7];               /*        Crisfield increments of current step di */
float   m_de_1[7];               /*        Crisfield increments of last step di-1 */
float   m_i_54;                  /*        unused */
float   m_erf_min;               /* [1081] minimum strain reinf. */
float   m_erf_max;               /* [1081] maximum strain reinf. */
float   m_hc;                    /* [   8] relative compressive zone height */
float   m_ccw;                   /* [1026] current crack opening */
float   m_i_59[11];              /*        unused */
} typeCDB_BEAM_STI;

#define BSLN_STI_VER 201606
typedef struct tagCDB_BSLN_STI { /* 123/LC  Stiffness of beams */
int     m_nr;                    /*        beam number */
float   m_x;                     /* [1001] distance from start */
float   m_ea;                    /* [  62] normal stiffness */
float   m_gay;                   /* [  62] y-shear stiffness */
float   m_gaz;                   /* [  62] z-shear stiffness */
float   m_git;                   /* [  83] torsional stiffness */
float   m_eiy;                   /* [  83] bending stiffness y */
float   m_eiz;                   /* [  83] bending stiffness z */
float   m_eiyz;                  /* [  83] bending stiffness yz */
float   m_gayz;                  /* [  62] yz-shear stiffness */
float   m_kpx;                   /* [   8] plastic strain x */
float   m_kpy;                   /* [  17] plastic curvature y */
float   m_kpz;                   /* [  17] plastic curvature z */
float   m_emin;                  /* [1081] minimum strain */
float   m_emax;                  /* [1081] maximum strain */
float   m_ge1;                   /* [1101] Residual of current step (Crisfield) */
float   m_ge2;                   /* [1104] Residual of current step (Crisfield) */
float   m_ge3;                   /* [1104] Residual of current step (Crisfield) */
float   m_ea0;                   /* [  83] lin. stiffness EA */
float   m_eiy0;                  /* [  83] lin. stiffness EIy */
float   m_eiz0;                  /* [  83] lin. stiffness EIz */
float   m_dysm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_dzsm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_pre;                   /* [1101] primary axial force */
float   m_ys;                    /* [1001] y-eccentricity of centre of gravity */
float   m_zs;                    /* [1001] z-eccentricity of centre of gravity */
float   m_ecm;                   /*        warping stiffness */
float   m_gcms;                  /*        secondary torsion */
float   m_ni;                    /* [1101] inner normal force */
float   m_vyi;                   /* [1102] inner y-shear force */
float   m_vzi;                   /* [1102] inner z-shear force */
float   m_mti;                   /* [1103] inner torsional moment */
float   m_myi;                   /* [1104] inner bending moment My */
float   m_mzi;                   /* [1104] inner bending moment Mz */
float   m_mbi;                   /* [1105] inner warping moment Mb */
float   m_e0;                    /* [1081] total strain x */
float   m_gkpy;                  /* [  17] total curvature y */
float   m_gkpz;                  /* [  17] total curvature z */
float   m_kfvy;                  /*        plastic factor V-y */
float   m_kfvz;                  /*        plastic factor V-z */
float   m_kfmt;                  /*        plastic factor M-t */
float   m_de_0[7];               /*        Crisfield increments of current step di */
float   m_de_1[7];               /*        Crisfield increments of last step di-1 */
float   m_i_54;                  /*        unused */
float   m_erf_min;               /* [1081] minimum strain reinf. */
float   m_erf_max;               /* [1081] maximum strain reinf. */
float   m_hc;                    /* [   8] relative compressive zone height */
float   m_ccw;                   /* [1026] current crack opening */
float   m_i_59[11];              /*        unused */
} typeCDB_BSLN_STI;

#define BSCT_STI_VER 200501
typedef struct tagCDB_BSCT_STI { /* 143/LC  Stiffness of beams */
int     m_nr;                    /*        beam number */
float   m_x;                     /* [1001] distance from start */
float   m_ea;                    /* [  62] normal stiffness */
float   m_gay;                   /* [  62] y-shear stiffness */
float   m_gaz;                   /* [  62] z-shear stiffness */
float   m_git;                   /* [  83] torsional stiffness */
float   m_eiy;                   /* [  83] bending stiffness y */
float   m_eiz;                   /* [  83] bending stiffness z */
float   m_eiyz;                  /* [  83] bending stiffness yz */
float   m_gayz;                  /* [  62] yz-shear stiffness */
float   m_kpx;                   /* [   8] plastic strain x */
float   m_kpy;                   /* [  17] plastic curvature y */
float   m_kpz;                   /* [  17] plastic curvature z */
float   m_emin;                  /* [1081] minimum strain */
float   m_emax;                  /* [1081] maximum strain */
float   m_ge1;                   /* [1101] Residual of current step (Crisfield) */
float   m_ge2;                   /* [1104] Residual of current step (Crisfield) */
float   m_ge3;                   /* [1104] Residual of current step (Crisfield) */
float   m_ea0;                   /* [  83] lin. stiffness EA */
float   m_eiy0;                  /* [  83] lin. stiffness EIy */
float   m_eiz0;                  /* [  83] lin. stiffness EIz */
float   m_dysm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_dzsm;                  /* [1011] ordinate shear centre to gravity centre */
float   m_pre;                   /* [1101] primary axial force */
float   m_ys;                    /* [1001] y-eccentricity of centre of gravity */
float   m_zs;                    /* [1001] z-eccentricity of centre of gravity */
float   m_ecm;                   /*        warping stiffness */
float   m_gcms;                  /*        secondary torsion */
float   m_ni;                    /* [1101] inner normal force */
float   m_vyi;                   /* [1102] inner y-shear force */
float   m_vzi;                   /* [1102] inner z-shear force */
float   m_mti;                   /* [1103] inner torsional moment */
float   m_myi;                   /* [1104] inner bending moment My */
float   m_mzi;                   /* [1104] inner bending moment Mz */
float   m_mbi;                   /* [1105] inner warping moment Mb */
float   m_e0;                    /* [1081] total strain x */
float   m_gkpy;                  /* [  17] total curvature y */
float   m_gkpz;                  /* [  17] total curvature z */
float   m_kfvy;                  /*        plastic factor V-y */
float   m_kfvz;                  /*        plastic factor V-z */
float   m_kfmt;                  /*        plastic factor M-t */
float   m_de_0[7];               /*        Crisfield increments of current step di */
float   m_de_1[7];               /*        Crisfield increments of last step di-1 */
float   m_i_54;                  /*        unused */
float   m_erf_min;               /* [1081] minimum strain reinf. */
float   m_erf_max;               /* [1081] maximum strain reinf. */
float   m_hc;                    /* [   8] relative compressive zone height */
float   m_ccw;                   /* [1026] current crack opening */
float   m_i_59[11];              /*        unused */
} typeCDB_BSCT_STI;

#define BEAM_CRC_ID 0
#define BEAM_CRC_VER 200701
typedef struct tagCDB_BEAM_CRC { /* 104/LC  Parameter of creep interval for each material */
int     m_id;                    /*        identifier 0 */
int     m_mnr;                   /*        materialnumber */
chr     m_exp;                   /*        exposition class of explicit curve */
float   m_t;                     /* [  93] absolute age */
float   m_phi;                   /*        creep coefficient */
float   m_eps;                   /*        shrinkage */
float   m_rh;                    /* [   8] relative moisture */
float   m_temp;                  /* [   6] temperature */
float   m_twa;                   /* [  93] effective age start */
float   m_twe;                   /* [  93] effective age end */
float   m_beth;                  /*        creep coefficient beta-h */
float   m_ts;                    /* [  93] start date of drying */
float   m_tc;                    /* [  93] start date of loading */
} typeCDB_BEAM_CRC;

#define BSLN_CRC_ID 0
#define BSLN_CRC_VER 201606
typedef struct tagCDB_BSLN_CRC { /* 124/LC  Parameter of creep interval for each material */
int     m_id;                    /*        identifier 0 */
int     m_mnr;                   /*        materialnumber */
chr     m_exp;                   /*        exposition class of explicit curve */
float   m_t;                     /* [  93] absolute age */
float   m_phi;                   /*        creep coefficient */
float   m_eps;                   /*        shrinkage */
float   m_rh;                    /* [   8] relative moisture */
float   m_temp;                  /* [   6] temperature */
float   m_twa;                   /* [  93] effective age start */
float   m_twe;                   /* [  93] effective age end */
float   m_beth;                  /*        creep coefficient beta-h */
float   m_ts;                    /* [  93] start date of drying */
float   m_tc;                    /* [  93] start date of loading */
} typeCDB_BSLN_CRC;

#define BSCT_CRC_ID 0
#define BSCT_CRC_VER 200701
typedef struct tagCDB_BSCT_CRC { /* 144/LC  Parameter of creep interval for each material */
int     m_id;                    /*        identifier 0 */
int     m_mnr;                   /*        materialnumber */
chr     m_exp;                   /*        exposition class of explicit curve */
float   m_t;                     /* [  93] absolute age */
float   m_phi;                   /*        creep coefficient */
float   m_eps;                   /*        shrinkage */
float   m_rh;                    /* [   8] relative moisture */
float   m_temp;                  /* [   6] temperature */
float   m_twa;                   /* [  93] effective age start */
float   m_twe;                   /* [  93] effective age end */
float   m_beth;                  /*        creep coefficient beta-h */
float   m_ts;                    /* [  93] start date of drying */
float   m_tc;                    /* [  93] start date of loading */
} typeCDB_BSCT_CRC;

#define BEAM_CRF_VER 200501
typedef struct tagCDB_BEAM_CRF { /* 104/LC  resulting forces of redistribution */
int     m_nr;                    /*        beamnumber */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_sdni;                  /* [1101] total normal force */
float   m_sdvy;                  /* [1102] total y-shear force */
float   m_sdvz;                  /* [1102] total z-shear force */
float   m_sdmt;                  /* [1103] total torsion moment */
float   m_sdmy;                  /* [1104] total bending moment */
float   m_sdmz;                  /* [1104] total bending moment */
float   m_srni;                  /* [1101] relat. normal force */
float   m_srvy;                  /* [1102] relat. y-shear force */
float   m_srvz;                  /* [1102] relat. y-shear force */
float   m_srmt;                  /* [1103] relat. torsionmoment */
float   m_srmy;                  /* [1104] relat. bendingmoment */
float   m_srmz;                  /* [1104] relat. bendingmoment */
} typeCDB_BEAM_CRF;

#define BSLN_CRF_VER 201606
typedef struct tagCDB_BSLN_CRF { /* 124/LC  resulting forces of redistribution */
int     m_nr;                    /*        beamnumber */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_sdni;                  /* [1101] total normal force */
float   m_sdvy;                  /* [1102] total y-shear force */
float   m_sdvz;                  /* [1102] total z-shear force */
float   m_sdmt;                  /* [1103] total torsion moment */
float   m_sdmy;                  /* [1104] total bending moment */
float   m_sdmz;                  /* [1104] total bending moment */
float   m_srni;                  /* [1101] relat. normal force */
float   m_srvy;                  /* [1102] relat. y-shear force */
float   m_srvz;                  /* [1102] relat. y-shear force */
float   m_srmt;                  /* [1103] relat. torsionmoment */
float   m_srmy;                  /* [1104] relat. bendingmoment */
float   m_srmz;                  /* [1104] relat. bendingmoment */
} typeCDB_BSLN_CRF;

#define BSCT_CRF_VER 200501
typedef struct tagCDB_BSCT_CRF { /* 144/LC  resulting forces of redistribution */
int     m_nr;                    /*        beamnumber */
int     m_id;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_sdni;                  /* [1101] total normal force */
float   m_sdvy;                  /* [1102] total y-shear force */
float   m_sdvz;                  /* [1102] total z-shear force */
float   m_sdmt;                  /* [1103] total torsion moment */
float   m_sdmy;                  /* [1104] total bending moment */
float   m_sdmz;                  /* [1104] total bending moment */
float   m_srni;                  /* [1101] relat. normal force */
float   m_srvy;                  /* [1102] relat. y-shear force */
float   m_srvz;                  /* [1102] relat. y-shear force */
float   m_srmt;                  /* [1103] relat. torsionmoment */
float   m_srmy;                  /* [1104] relat. bendingmoment */
float   m_srmz;                  /* [1104] relat. bendingmoment */
} typeCDB_BSCT_CRF;

#define BEAM_TSN_VER 201704
typedef struct tagCDB_BEAM_TSN { /* 104/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        10000+materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ts[32][2];             /* [1092] Eigenstress table (z,sig) */
} typeCDB_BEAM_TSN;

#define BSLN_TSN_VER 201704
typedef struct tagCDB_BSLN_TSN { /* 124/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        10000+materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ts[32][2];             /* [1092] Eigenstress table (z,sig) */
} typeCDB_BSLN_TSN;

#define BSCT_TSN_VER 201704
typedef struct tagCDB_BSCT_TSN { /* 144/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        10000+materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ts[32][2];             /* [1092] Eigenstress table (z,sig) */
} typeCDB_BSCT_TSN;

#define BEAM_CRP_VER 200501
typedef struct tagCDB_BEAM_CRP { /* 104/LC  forces on sectional parts per material */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dni;                   /* [1101] impr. normal force */
float   m_dmyi;                  /* [1104] impr. bending moment */
float   m_dmzi;                  /* [1104] impr. bending moment */
float   m_ni;                    /* [1101] total normal force */
float   m_myi;                   /* [1104] total bending moment */
float   m_mzi;                   /* [1104] total bending moment */
float   m_sdni;                  /* [1192] stress plane parameter from (DNI:DMZI) */
float   m_sdmyi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sdmzi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sni;                   /* [1192] stress plane parameter from (NI:MZI) */
float   m_smyi;                  /* [1193] stress plane parameter from (NI:MZI) */
float   m_smzi;                  /* [1193] stress plane parameter from (NI:MZI) */
} typeCDB_BEAM_CRP;

#define BSLN_CRP_VER 201606
typedef struct tagCDB_BSLN_CRP { /* 124/LC  forces on sectional parts per material */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dni;                   /* [1101] impr. normal force */
float   m_dmyi;                  /* [1104] impr. bending moment */
float   m_dmzi;                  /* [1104] impr. bending moment */
float   m_ni;                    /* [1101] total normal force */
float   m_myi;                   /* [1104] total bending moment */
float   m_mzi;                   /* [1104] total bending moment */
float   m_sdni;                  /* [1192] stress plane parameter from (DNI:DMZI) */
float   m_sdmyi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sdmzi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sni;                   /* [1192] stress plane parameter from (NI:MZI) */
float   m_smyi;                  /* [1193] stress plane parameter from (NI:MZI) */
float   m_smzi;                  /* [1193] stress plane parameter from (NI:MZI) */
} typeCDB_BSLN_CRP;

#define BSCT_CRP_VER 200501
typedef struct tagCDB_BSCT_CRP { /* 144/LC  forces on sectional parts per material */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dni;                   /* [1101] impr. normal force */
float   m_dmyi;                  /* [1104] impr. bending moment */
float   m_dmzi;                  /* [1104] impr. bending moment */
float   m_ni;                    /* [1101] total normal force */
float   m_myi;                   /* [1104] total bending moment */
float   m_mzi;                   /* [1104] total bending moment */
float   m_sdni;                  /* [1192] stress plane parameter from (DNI:DMZI) */
float   m_sdmyi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sdmzi;                 /* [1193] stress plane parameter from (DNI:DMZI) */
float   m_sni;                   /* [1192] stress plane parameter from (NI:MZI) */
float   m_smyi;                  /* [1193] stress plane parameter from (NI:MZI) */
float   m_smzi;                  /* [1193] stress plane parameter from (NI:MZI) */
} typeCDB_BSCT_CRP;

#define BEAM_CRT_VER 200501
typedef struct tagCDB_BEAM_CRT { /* 104/LC  changes of tensional force */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        neg. tendonnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dzz;                   /* [1092] change of stress to prestress */
float   m_dzr;                   /* [1092] rel. change of stress to concrete strain */
float   m_dz;                    /* [1101] rel. change of force from mean strain */
float   m_dzfak[5];              /*        ordinates, inclinations to evaluate forces */
} typeCDB_BEAM_CRT;

#define BSLN_CRT_VER 201606
typedef struct tagCDB_BSLN_CRT { /* 124/LC  changes of tensional force */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        neg. tendonnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dzz;                   /* [1092] change of stress to prestress */
float   m_dzr;                   /* [1092] rel. change of stress to concrete strain */
float   m_dz;                    /* [1101] rel. change of force from mean strain */
float   m_dzfak[5];              /*        ordinates, inclinations to evaluate forces */
} typeCDB_BSLN_CRT;

#define BSCT_CRT_VER 200501
typedef struct tagCDB_BSCT_CRT { /* 144/LC  changes of tensional force */
int     m_nr;                    /*        beamnumber */
int     m_nrs;                   /*        neg. tendonnumber */
float   m_x;                     /* [1001] distance from start */
float   m_dzz;                   /* [1092] change of stress to prestress */
float   m_dzr;                   /* [1092] rel. change of stress to concrete strain */
float   m_dz;                    /* [1101] rel. change of force from mean strain */
float   m_dzfak[5];              /*        ordinates, inclinations to evaluate forces */
} typeCDB_BSCT_CRT;

#define BEAM_STC_ID 0
#define BEAM_STC_VER 200501
typedef struct tagCDB_BEAM_STC { /* 105/LC  Maximum stresses in cross-section of beams */
int     m_nr;                    /*        Ident 0 */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance to start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial comp stress */
float   m_sigu;                  /* [1092] uniaxial tens stress */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling intensity */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
} typeCDB_BEAM_STC;

#define BSLN_STC_ID 0
#define BSLN_STC_VER 200501
typedef struct tagCDB_BSLN_STC { /* 125/LC  Maximum stresses in cross-section of beams */
int     m_nr;                    /*        Ident 0 */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance to start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial comp stress */
float   m_sigu;                  /* [1092] uniaxial tens stress */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling intensity */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
} typeCDB_BSLN_STC;

#define BSCT_STC_ID 0
#define BSCT_STC_VER 200501
typedef struct tagCDB_BSCT_STC { /* 145/LC  Maximum stresses in cross-section of beams */
int     m_nr;                    /*        Ident 0 */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance to start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial comp stress */
float   m_sigu;                  /* [1092] uniaxial tens stress */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling intensity */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
} typeCDB_BSCT_STC;

#define BEAM_TST_VER 201704
typedef struct tagCDB_BEAM_TST { /* 105/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        100000 + material number as in BSCT_STC */
float   m_x;                     /* [1001] distance from start */
float   m_ts[128][2];            /* [1092] Eigenstress table (z,sig) */
} typeCDB_BEAM_TST;

#define BSLN_TST_VER 201704
typedef struct tagCDB_BSLN_TST { /* 125/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        100000 + material number as in BSCT_STC */
float   m_x;                     /* [1001] distance from start */
float   m_ts[128][2];            /* [1092] Eigenstress table (z,sig) */
} typeCDB_BSLN_TST;

#define BSCT_TST_VER 201704
typedef struct tagCDB_BSCT_TST { /* 145/LC  thermal eigen stress per material */
int     m_nr;                    /*        element number */
int     m_mnrx;                  /*        100000 + material number as in BSCT_STC */
float   m_x;                     /* [1001] distance from start */
float   m_ts[128][2];            /* [1092] Eigenstress table (z,sig) */
} typeCDB_BSCT_TST;

#define BEAM_STR_VER 201009
typedef struct tagCDB_BEAM_STR { /* 105/LC  Stresses in cross-section of beams */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial stress up */
float   m_sigu;                  /* [1092] uniaxial stress down */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling effects */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
float   m_rctrl;                 /*        control value of stress/strain description */
float   m_es0;                   /*        strain in center of total section */
float   m_esy;                   /*        strain gradient in y-direction */
float   m_esz;                   /*        strain gradient in z-direction */
float   m_yc;                    /* [1011] location of center of partial section */
float   m_zc;                    /* [1011] location of center of partial section */
float   m_esw;                   /*        factor for unit warping */
float   m_vyf;                   /* [1102] shear force */
float   m_vzf;                   /* [1102] shear force */
float   m_mtf;                   /* [1103] primary torsional moment */
float   m_mt2f;                  /* [1103] secondary torsional moment */
} typeCDB_BEAM_STR;

#define BSLN_STR_VER 201606
typedef struct tagCDB_BSLN_STR { /* 125/LC  Stresses in cross-section of beams */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial stress up */
float   m_sigu;                  /* [1092] uniaxial stress down */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling effects */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
float   m_rctrl;                 /*        control value of stress/strain description */
float   m_es0;                   /*        strain in center of total section */
float   m_esy;                   /*        strain gradient in y-direction */
float   m_esz;                   /*        strain gradient in z-direction */
float   m_yc;                    /* [1011] location of center of partial section */
float   m_zc;                    /* [1011] location of center of partial section */
float   m_esw;                   /*        factor for unit warping */
float   m_vyf;                   /* [1102] shear force */
float   m_vzf;                   /* [1102] shear force */
float   m_mtf;                   /* [1103] primary torsional moment */
float   m_mt2f;                  /* [1103] secondary torsional moment */
} typeCDB_BSLN_STR;

#define BSCT_STR_VER 201009
typedef struct tagCDB_BSCT_STR { /* 145/LC  Stresses in cross-section of beams */
int     m_nr;                    /*        beamnumber */
int     m_mnr;                   /*        materialnumber */
float   m_x;                     /* [1001] distance from start */
float   m_sigc;                  /* [1092] compressive stress */
float   m_sigt;                  /* [1092] tensile stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigv;                  /* [1092] reference stress */
float   m_si;                    /* [1092] main tension stress */
float   m_sii;                   /* [1092] main compress stress */
float   m_sigo;                  /* [1092] uniaxial stress up */
float   m_sigu;                  /* [1092] uniaxial stress down */
float   m_dsig;                  /* [1092] sway of normal stress */
float   m_dtau;                  /* [1092] sway of shear stress */
float   m_sigw;                  /* [1092] stress in weldings */
float   m_vb;                    /* [1153] Bond force */
float   m_buck;                  /*        buckling effects */
float   m_i_14;                  /*        reserved */
float   m_sigct;                 /* [1092] decompression stress */
float   m_rctrl;                 /*        control value of stress/strain description */
float   m_es0;                   /*        strain in center of total section */
float   m_esy;                   /*        strain gradient in y-direction */
float   m_esz;                   /*        strain gradient in z-direction */
float   m_yc;                    /* [1011] location of center of partial section */
float   m_zc;                    /* [1011] location of center of partial section */
float   m_esw;                   /*        factor for unit warping */
float   m_vyf;                   /* [1102] shear force */
float   m_vzf;                   /* [1102] shear force */
float   m_mtf;                   /* [1103] primary torsional moment */
float   m_mt2f;                  /* [1103] secondary torsional moment */
} typeCDB_BSCT_STR;

#define BEAM_RF0_ID 0
#define BEAM_RF0_VER 200804
typedef struct tagCDB_BEAM_RF0 { /* 106/DC  max. values of reinforcement */
int     m_nr;                    /*        identifier 0 */
int     m_nvers;                 /*        Version number */
float   m_aslmax;                /* [1021] maximum longitudinal reinforcement */
float   m_asbmax;                /* [1021] maximum of transverse reinforcement reinforcement */
float   m_vmmax;                 /* [1001] maximum of shift rule offset */
float   m_reserved[12];          /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define BEAM_RF0_TEXT_LEN 32
} typeCDB_BEAM_RF0;

#define BSLN_RF0_ID 0
#define BSLN_RF0_VER 201606
typedef struct tagCDB_BSLN_RF0 { /* 126/DC  max. values of reinforcement */
int     m_nr;                    /*        identifier 0 */
int     m_nvers;                 /*        Version number */
float   m_aslmax;                /* [1021] maximum longitudinal reinforcement */
float   m_asbmax;                /* [1021] maximum of transverse reinforcement reinforcement */
float   m_vmmax;                 /* [1001] maximum of shift rule offset */
float   m_reserved[12];          /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define BSLN_RF0_TEXT_LEN 32
} typeCDB_BSLN_RF0;

#define BSCT_RF0_ID 0
#define BSCT_RF0_VER 200804
typedef struct tagCDB_BSCT_RF0 { /* 146/DC  max. values of reinforcement */
int     m_nr;                    /*        identifier 0 */
int     m_nvers;                 /*        Version number */
float   m_aslmax;                /* [1021] maximum longitudinal reinforcement */
float   m_asbmax;                /* [1021] maximum of transverse reinforcement reinforcement */
float   m_vmmax;                 /* [1001] maximum of shift rule offset */
float   m_reserved[12];          /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define BSCT_RF0_TEXT_LEN 32
} typeCDB_BSCT_RF0;

#define TRUS_RF0_ID 0
#define TRUS_RF0_VER 200804
typedef struct tagCDB_TRUS_RF0 { /* 156/DC  max. values of reinforcement */
int     m_nr;                    /*        identifier 0 */
int     m_nvers;                 /*        Version number */
float   m_aslmax;                /* [1021] maximum longitudinal reinforcement */
float   m_asbmax;                /* [1021] maximum of transverse reinforcement reinforcement */
float   m_vmmax;                 /* [1001] maximum of shift rule offset */
float   m_reserved[12];          /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define TRUS_RF0_TEXT_LEN 32
} typeCDB_TRUS_RF0;

#define CABL_RF0_ID 0
#define CABL_RF0_VER 200804
typedef struct tagCDB_CABL_RF0 { /* 166/DC  max. values of reinforcement */
int     m_nr;                    /*        identifier 0 */
int     m_nvers;                 /*        Version number */
float   m_aslmax;                /* [1021] maximum longitudinal reinforcement */
float   m_asbmax;                /* [1021] maximum of transverse reinforcement reinforcement */
float   m_vmmax;                 /* [1001] maximum of shift rule offset */
float   m_reserved[12];          /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define CABL_RF0_TEXT_LEN 32
} typeCDB_CABL_RF0;

#define BEAM_RFI_VER 201501
typedef struct tagCDB_BEAM_RFI { /* 106/DC  info of reinforcement of beam */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        info id = 0 */
float   m_x;                     /* [1001] distance from start */
int     m_asl[10][2];            /*        infos for longitudinal layers 0:9 */
int     m_asv[15][2];            /*        infos for transverse reinforcement layers 1:15 */
} typeCDB_BEAM_RFI;

#define BSLN_RFI_VER 201606
typedef struct tagCDB_BSLN_RFI { /* 126/DC  info of reinforcement of design element sect. */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        info id = 0 */
float   m_x;                     /* [1001] distance from start */
int     m_asl[10][2];            /*        infos for longitudinal layers 0:9 */
int     m_asv[15][2];            /*        infos for transverse reinforcement layers 1:15 */
} typeCDB_BSLN_RFI;

#define BSCT_RFI_VER 201501
typedef struct tagCDB_BSCT_RFI { /* 146/DC  info of reinforcement of external section */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        info id = 0 */
float   m_x;                     /* [1001] distance from start */
int     m_asl[10][2];            /*        infos for longitudinal layers 0:9 */
int     m_asv[15][2];            /*        infos for transverse reinforcement layers 1:15 */
} typeCDB_BSCT_RFI;

#define TRUS_RFI_VER 201501
typedef struct tagCDB_TRUS_RFI { /* 156/DC  info of reinforcement of truss */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        info id = 0 */
float   m_x;                     /* [1001] distance from start */
int     m_asl[10][2];            /*        infos for longitudinal layers 0:9 */
int     m_asv[15][2];            /*        infos for transverse reinforcement layers 1:15 */
} typeCDB_TRUS_RFI;

#define CABL_RFI_VER 201501
typedef struct tagCDB_CABL_RFI { /* 166/DC  info of reinforcement of cables */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        info id = 0 */
float   m_x;                     /* [1001] distance from start */
int     m_asl[10][2];            /*        infos for longitudinal layers 0:9 */
int     m_asv[15][2];            /*        infos for transverse reinforcement layers 1:15 */
} typeCDB_CABL_RFI;

#define BEAM_RFC_VER 200804
typedef struct tagCDB_BEAM_RFC { /* 106/DC  reinforcement of beam */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        section number */
float   m_x;                     /* [1001] distance from start */
float   m_asum;                  /* [1020] Total longitudinal reinforcement */
float   m_ator;                  /* [1021] maximum of torsional reinforcement */
float   m_asl[10];               /* [1020] Area of layer 0:9 */
float   m_vm;                    /* [1001] shift rule offset */
float   m_asbmax;                /* [1021] maximum of all transverse reinforcement areas */
float   m_asb[15][2];            /* [1021] transverse reinforcements */
} typeCDB_BEAM_RFC;

#define BSLN_RFC_VER 201606
typedef struct tagCDB_BSLN_RFC { /* 126/DC  reinforcement of design element section */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        section number */
float   m_x;                     /* [1001] distance from start */
float   m_asum;                  /* [1020] Total longitudinal reinforcement */
float   m_ator;                  /* [1021] maximum of torsional reinforcement */
float   m_asl[10];               /* [1020] Area of layer 0:9 */
float   m_vm;                    /* [1001] shift rule offset */
float   m_asbmax;                /* [1021] maximum of all transverse reinforcement areas */
float   m_asb[15][2];            /* [1021] transverse reinforcements */
} typeCDB_BSLN_RFC;

#define BSCT_RFC_VER 200804
typedef struct tagCDB_BSCT_RFC { /* 146/DC  reinforcement of external section */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        section number */
float   m_x;                     /* [1001] distance from start */
float   m_asum;                  /* [1020] Total longitudinal reinforcement */
float   m_ator;                  /* [1021] maximum of torsional reinforcement */
float   m_asl[10];               /* [1020] Area of layer 0:9 */
float   m_vm;                    /* [1001] shift rule offset */
float   m_asbmax;                /* [1021] maximum of all transverse reinforcement areas */
float   m_asb[15][2];            /* [1021] transverse reinforcements */
} typeCDB_BSCT_RFC;

#define TRUS_RFC_VER 200804
typedef struct tagCDB_TRUS_RFC { /* 156/DC  reinforcement of truss */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        section number */
float   m_x;                     /* [1001] distance from start */
float   m_asum;                  /* [1020] Total longitudinal reinforcement */
float   m_ator;                  /* [1021] maximum of torsional reinforcement */
float   m_asl[10];               /* [1020] Area of layer 0:9 */
float   m_vm;                    /* [1001] shift rule offset */
float   m_asbmax;                /* [1021] maximum of all transverse reinforcement areas */
float   m_asb[15][2];            /* [1021] transverse reinforcements */
} typeCDB_TRUS_RFC;

#define CABL_RFC_VER 200804
typedef struct tagCDB_CABL_RFC { /* 166/DC  reinforcement of cables */
int     m_nr;                    /*        beamnumber */
int     m_nq;                    /*        section number */
float   m_x;                     /* [1001] distance from start */
float   m_asum;                  /* [1020] Total longitudinal reinforcement */
float   m_ator;                  /* [1021] maximum of torsional reinforcement */
float   m_asl[10];               /* [1020] Area of layer 0:9 */
float   m_vm;                    /* [1001] shift rule offset */
float   m_asbmax;                /* [1021] maximum of all transverse reinforcement areas */
float   m_asb[15][2];            /* [1021] transverse reinforcements */
} typeCDB_CABL_RFC;

#define BEAM_DE0_ID 0
#define BEAM_DE0_VER 200501
typedef struct tagCDB_BEAM_DE0 { /* 107/LC  max. values of Ultimate/Plastic Design results */
int     m_nr;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BEAM_DE0;

#define BSLN_DE0_ID 0
#define BSLN_DE0_VER 201606
typedef struct tagCDB_BSLN_DE0 { /* 127/LC  max. values of Ultimate/Plastic Design results */
int     m_nr;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BSLN_DE0;

#define BSCT_DE0_ID 0
#define BSCT_DE0_VER 200501
typedef struct tagCDB_BSCT_DE0 { /* 147/LC  max. values of Ultimate/Plastic Design results */
int     m_nr;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BSCT_DE0;

#define TRUS_DE0_ID 0
#define TRUS_DE0_VER 200501
typedef struct tagCDB_TRUS_DE0 { /* 157/LC  max. values of Ultimate/Plastic Design results */
int     m_nr;                    /*        identifier 0 */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_TRUS_DE0;

#define BEAM_DES_VER 200501
typedef struct tagCDB_BEAM_DES { /* 107/LC  Ultimate/Plastic Design results */
int     m_nr;                    /*        elementnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BEAM_DES;

#define BSLN_DES_VER 201606
typedef struct tagCDB_BSLN_DES { /* 127/LC  Ultimate/Plastic Design results */
int     m_nr;                    /*        elementnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BSLN_DES;

#define BSCT_DES_VER 200501
typedef struct tagCDB_BSCT_DES { /* 147/LC  Ultimate/Plastic Design results */
int     m_nr;                    /*        elementnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_BSCT_DES;

#define TRUS_DES_VER 200501
typedef struct tagCDB_TRUS_DES { /* 157/LC  Ultimate/Plastic Design results */
int     m_nr;                    /*        elementnumber */
float   m_x;                     /* [1001] distance from start */
float   m_ni;                    /* [1101] Inner normal force */
float   m_myi;                   /* [1104] bending moment My */
float   m_mzi;                   /* [1104] bending moment My */
float   m_scf;                   /*        relative capacity */
float   m_e0;                    /* [   9] strain at center */
float   m_ey;                    /* [1009] curvature y direct. */
float   m_ez;                    /* [1009] curvature z direct. */
float   m_e1;                    /* [   9] compressive strain */
float   m_e2;                    /* [   9] tensional   strain */
float   m_hl;                    /* [1011] lever of forces */
float   m_hvm;                   /* [1001] shift rule value */
float   m_hx;                    /* [1001] height of compression zone   (NSTR-Analysis) */
float   m_edcmin;                /* [   9] minimum decompression strain (NSTR-Analysis) */
float   m_edcmax;                /* [   9] maximum decompression strain (NSTR-Analysis) */
float   m_fchk;                  /* [1092] not used */
float   m_tcf;                   /*        total utilisation level (all effects) */
float   m_scn;                   /*        utilisation level  (1) N/Npl */
float   m_scvy;                  /*        utilisation level  (2) Vy/Vypl */
float   m_scvz;                  /*        utilisation level  (3) Vz/Vzpl */
float   m_scmt;                  /*        utilisation level  (4) Mt/Mtpl */
float   m_scmy;                  /*        utilisation level  (5) My/Mypl */
float   m_scmz;                  /*        utilisation level  (6) Mz/Mzpl */
float   m_scmb;                  /*        utilisation level  (7) Mb/Mbpl */
float   m_sct2;                  /*        utilisation level  (8) Mt2/Mt2pl */
float   m_sccomb;                /*        utilisation level  (9) TOTAL INTERACTION */
float   m_scbn;                  /*        utilisation level (10) buckling / torsional buckling */
float   m_csigc;                 /*        utilisation level (11) sig-c/fy */
float   m_csigt;                 /*        utilisation level (12) sig-t/fy */
float   m_ctau;                  /*        utilisation level (13) tau/tauy */
float   m_csgv;                  /*        utilisation level (14) sigv/fy (von Mises) */
float   m_csgr;                  /*        utilisation level (15) sig-s (tendon/reinforc.stress) */
float   m_cas;                   /*        utilisation level (16) As/As-provided (long.Reinforc) */
float   m_casl;                  /*        utilisation level (17) Asv/Asv-provided (transverse reinf) */
float   m_ccw;                   /*        utilisation level (18) As/As-provided for crack width */
float   m_csgd;                  /*        utilisation level (19) sig-d (dynamic stress range) */
float   m_ctau0;                 /*        utilisation level (20) tau0  (Nachweisgrenzen) */
float   m_c2t;                   /*        utilisation level (21) plate slenderness (c/t) */
float   m_class;                 /*        highest criteria for section class */
} typeCDB_TRUS_DES;

#define BEAM_PIF_VER 200501
typedef struct tagCDB_BEAM_PIF { /* 108/LC  reducing factors of stiffness */
int     m_nr;                    /*        pilenumber */
float   m_redp;                  /*        reducing factor of stiffness */
float   m_reda;                  /*        reducing factor of axial bedding */
float   m_redq;                  /*        reducing factor of cross bedding */
} typeCDB_BEAM_PIF;

#define BEAM_HR0_ID 0
#define BEAM_HR0_VER 200707
typedef struct tagCDB_BEAM_HR0 { /* 111/LC  Maximum of Implicit Hinge Reactions */
int     m_id;                    /*        identifier 0 */
int     m_typ;                   /*        type of hinge */
int     m_ibit[2];               /*        reserved */
float   m_x;                     /* [1001] max. beam length */
float   m_reac;                  /*        extremal reaction force/ moment */
float   m_stv[4];                /*        extremal values of statevar's */
} typeCDB_BEAM_HR0;

#define BEAM_HRC_VER 200707
typedef struct tagCDB_BEAM_HRC { /* 111/LC  Implicit Hinge Reactions */
int     m_nr;                    /*        beamnumber */
int     m_typ;                   /*        type of hinge */
int     m_ibit[2];               /*        reserved */
float   m_x;                     /* [1001] hinge location, beam abscissa value */
float   m_reac;                  /*        reaction force/ moment */
float   m_stv[4];                /*        statevar's */
} typeCDB_BEAM_HRC;

#define BEAM_MP0_ID 0
#define BEAM_MP0_VER 201008
typedef struct tagCDB_BEAM_MP0 { /* 115/LC  Extremal values of cross-sectional material point reactions */
int     m_nr;                    /*        identifier 0 */
int     m_type;                  /*        type: reinforcement=1, base material point=0 */
int     m_mno;                   /*        material number */
int     m_mrf;                   /*        material number reinforcement */
int     m_npts;                  /*        number of base material points */
int     m_nrf;                   /*        Anzahl Materialpunkte Bewehrung */
float   m_x;                     /* [1001] max. beam length */
float   m_y;                     /* [1011] max. y-ccordinate */
float   m_z;                     /* [1011] max. z-ccordinate */
float   m_sigx;                  /* [1092] axial normal stress */
float   m_tauxy;                 /* [1092] shear stress xy */
float   m_tauxz;                 /* [1092] shear stress xz */
float   m_f0;                    /*        utilization level */
float   m_kapap;                 /* [   9] equiv. plastic strain */
float   m_kapad;                 /* [   9] fracturing strain */
float   m_ccw;                   /* [1026] current crack opening */
float   m_temp;                  /* [   6] current temperature */
float   m_tempmax;               /* [   6] maximum temperature in loading history */
float   m_eps_s;                 /* [   9] pure reinforcement strain (without TS strain correction) */
float   m_eps_ts;                /* [   9] tension stiffening strain correction (accumulated) */
float   m_dummy;                 /*        unused */
float   m_izone;                 /*        performance interval */
float   m_epst;                  /* [   9] axial temperature strain */
float   m_epsx;                  /* [   9] axial total strain (without temperature strain) */
float   m_a_mpt;                 /* [1012] associated material point area */
float   m_fc_temp;               /* [1092] current compressive strength (temperature dependent) */
float   m_ft_temp;               /* [1092] current tensile strength (temperature dependent) */
} typeCDB_BEAM_MP0;

#define BEAM_MPT_VER 201008
typedef struct tagCDB_BEAM_MPT { /* 115/LC  Cross-sectional material point reactions */
int     m_nr;                    /*        beam number */
int     m_type;                  /*        type: reinforcement=1, base material point=0 */
int     m_mno;                   /*        material number */
int     m_mrf;                   /*        material number reinforcement */
int     m_npts;                  /*        number of base material points */
int     m_nrf;                   /*        Anzahl Materialpunkte Bewehrung */
float   m_x;                     /* [1001] beam abscissa value */
float   m_y;                     /* [1011] cross-sectional y-position */
float   m_z;                     /* [1011] cross-sectional z-position */
float   m_sigx;                  /* [1092] axial normal stress */
float   m_tauxy;                 /* [1092] shear stress xy */
float   m_tauxz;                 /* [1092] shear stress xz */
float   m_f0;                    /*        utilization level */
float   m_kapap;                 /* [   9] equiv. plastic strain */
float   m_kapad;                 /* [   9] fracturing strain */
float   m_ccw;                   /* [1026] current crack opening */
float   m_temp;                  /* [   6] current temperature */
float   m_tempmax;               /* [   6] maximum temperature in loading history */
float   m_eps_s;                 /* [   9] pure reinforcement strain (without TS strain correction) */
float   m_eps_ts;                /* [   9] tension stiffening strain correction (accumulated) */
float   m_dummy;                 /*        unused */
float   m_izone;                 /*        performance interval */
float   m_epst;                  /* [   9] axial temperature strain */
float   m_epsx;                  /* [   9] axial total strain (without temperature strain) */
float   m_a_mpt;                 /* [1012] associated material point area */
float   m_fc_temp;               /* [1092] current compressive strength (temperature dependent) */
float   m_ft_temp;               /* [1092] current tensile strength (temperature dependent) */
} typeCDB_BEAM_MPT;

#define TRUS_VER 200910
typedef struct tagCDB_TRUS {     /* 150/00  trusselements */
int     m_nr;                    /*        truss number */
int     m_node[2];               /*        nodenumbers */
int     m_nrq;                   /*        cross-section number */
float   m_t[3];                  /*        normal direction */
float   m_dl;                    /* [1001] length of truss */
float   m_pre;                   /* [1101] prestress */
float   m_gap;                   /* [1003] slip of element */
float   m_riss;                  /* [1101] max tension force */
float   m_flie;                  /* [1101] yielding load */
int     m_nref;                  /*        reference axis */
} typeCDB_TRUS;

#define TRUS_LOA_VER 200501
typedef struct tagCDB_TRUS_LOA { /* 151/LC  Loads on truss elements */
int     m_nr;                    /*        truss number */
int     m_typ;                   /*        type of load */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
} typeCDB_TRUS_LOA;

#define TRUS_RE0_ID 0
#define TRUS_RE0_VER 200501
typedef struct tagCDB_TRUS_RE0 { /* 152/LC  maximum of results of truss elements */
int     m_nr;                    /*        identifier 0 */
float   m_n;                     /* [1101] normal force */
float   m_v;                     /* [1003] axial displacement */
} typeCDB_TRUS_RE0;

#define TRUS_RES_VER 200501
typedef struct tagCDB_TRUS_RES { /* 152/LC  results of truss elements */
int     m_nr;                    /*        truss number */
float   m_n;                     /* [1101] normal force */
float   m_v;                     /* [1003] axial displacement */
float   m_lex;                   /*        nonlinear effect */
float   m_damm[6];               /*        Damage Parameter */
} typeCDB_TRUS_RES;

#define TRUS_ST0_ID 0
#define TRUS_ST0_VER 200501
typedef struct tagCDB_TRUS_ST0 { /* 155/LC  checked truss stresses */
int     m_nr;                    /*        ident 0 */
int     m_mat;                   /*        Materialnumber */
float   m_sig;                   /* [1092] normal stress */
float   m_buck;                  /*        buckling intensity */
} typeCDB_TRUS_ST0;

#define TRUS_STR_VER 200501
typedef struct tagCDB_TRUS_STR { /* 155/LC  truss stress (AQB) */
int     m_nr;                    /*        trussingnumber */
int     m_mat;                   /*        Materialnumber */
float   m_sig;                   /* [1092] normal stress */
float   m_buck;                  /*        buckling intensity */
} typeCDB_TRUS_STR;

#define CABL_VER 200910
typedef struct tagCDB_CABL {     /* 160/00  cable elements */
int     m_nr;                    /*        cable number */
int     m_node[2];               /*        nodenumbers */
int     m_nrq;                   /*        cross-section number */
float   m_t[3];                  /*        normal direction */
float   m_dl;                    /* [1001] length of cable */
float   m_pre;                   /* [1101] prestress */
float   m_gap;                   /* [1003] slip of element */
float   m_riss;                  /* [1101] max tension force */
float   m_flie;                  /* [1101] yielding load */
int     m_nref;                  /*        reference axis */
} typeCDB_CABL;

#define CABL_LOA_VER 200501
typedef struct tagCDB_CABL_LOA { /* 161/LC  loads on cables */
int     m_nr;                    /*        cable number */
int     m_typ;                   /*        type of load */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
} typeCDB_CABL_LOA;

#define CABL_RE0_ID 0
#define CABL_RE0_VER 200501
typedef struct tagCDB_CABL_RE0 { /* 162/LC  maximum results of cables */
int     m_nr;                    /*        identifier 0 */
float   m_n;                     /* [1101] normal force */
float   m_v;                     /* [1003] axial displacement */
float   m_vt;                    /* [1003] maximum suspension of cable across axis */
float   m_vtx;                   /* [1003] suspension of cable, global X-component */
float   m_vty;                   /* [1003] suspension of cable, global Y-component */
float   m_vtz;                   /* [1003] suspension of cable, global Z-component */
float   m_eps0;                  /*        maximum induced strain */
} typeCDB_CABL_RE0;

#define CABL_RES_VER 200501
typedef struct tagCDB_CABL_RES { /* 162/LC  results of cables */
int     m_nr;                    /*        cablenumber */
float   m_n;                     /* [1101] normal force */
float   m_v;                     /* [1003] axial displacement */
float   m_vq;                    /* [1003] maximum suspension of cable across axis */
float   m_vtx;                   /* [1003] suspension of cable, global X-component */
float   m_vty;                   /* [1003] suspension of cable, global Y-component */
float   m_vtz;                   /* [1003] suspension of cable, global Z-component */
float   m_eps0;                  /*        Total induced strain */
float   m_n_m;                   /* [1101] average normal force */
float   m_f0;                    /* [1003] vertical suspension of cable in load direction */
float   m_l0;                    /* [1001] relaxed cable length incl. temp. and prestrain effects */
float   m_lex;                   /*        nonlinear effect */
float   m_effs;                  /*        effective stiffness factor due to cable sagging */
float   m_damm[6];               /*        Damage Parameter */
} typeCDB_CABL_RES;

#define CABL_SLP_VER 200501
typedef struct tagCDB_CABL_SLP { /* 163/00  slip cables */
int     m_nrsl;                  /*        slip cable number */
int     m_nrg;                   /*        group number */
int     m_nrel;                  /*        element number */
int     m_free;                  /*        free */
float   m_mue;                   /*        friction value */
} typeCDB_CABL_SLP;

#define CABL_ST0_ID 0
#define CABL_ST0_VER 200501
typedef struct tagCDB_CABL_ST0 { /* 165/LC  checked cable stresses */
int     m_nr;                    /*        ident 0 */
int     m_mat;                   /*        Materialnumber */
float   m_sig;                   /* [1092] normal stress */
} typeCDB_CABL_ST0;

#define CABL_STR_VER 200501
typedef struct tagCDB_CABL_STR { /* 165/LC  cable stresses (AQB) */
int     m_nr;                    /*        trussingnumber */
int     m_mat;                   /*        Materialnumber */
float   m_sig;                   /* [1092] normal stress */
} typeCDB_CABL_STR;

#define SPRI_VER 201201
typedef struct tagCDB_SPRI {     /* 170/00  Spring-elements */
int     m_nr;                    /*        springnumber */
int     m_node[2];               /*        start nodenumber */
int     m_nrq;                   /*        Material/section no */
float   m_t[3];                  /*        normal direction */
float   m_aref;                  /*        reference area */
float   m_cp;                    /* [1095] spring stiffness */
float   m_cq;                    /* [1095] transverse stiff. */
float   m_cm;                    /* [1098] torsional stiff. */
float   m_pre;                   /*        prestress */
float   m_gap;                   /*        slip/gap of spring */
float   m_riss;                  /*        max tension force */
float   m_flie;                  /*        yielding load */
float   m_mue;                   /*        friction cross */
float   m_coh;                   /*        cohesion cross */
float   m_dil;                   /*        dilatancy factor */
float   m_gapq;                  /*        transverse slip/gap */
float   m_dp;                    /*        damping constant */
float   m_dq;                    /*        damping shear */
float   m_dm;                    /*        damping moment */
float   m_expp;                  /*        exponent for nonlinear damping dp**expp */
float   m_expq;                  /*        exponent for nonlinear damping dq**expq */
float   m_expm;                  /*        exponent for nonlinear damping dm**expm */
float   m_tb[3];                 /*        rotational direction */
int     m_nref;                  /*        additional bit code */
} typeCDB_SPRI;

#define SPRI_RE0_ID 0
#define SPRI_RE0_VER 200501
typedef struct tagCDB_SPRI_RE0 { /* 170/LC  maximum of results of spring-elements */
int     m_id;                    /*        identifier */
float   m_p;                     /* [1151] maximum spring force */
float   m_pt;                    /* [1151] maximum spring transverse force */
float   m_ptx;                   /* [1151] maximum global X-shear component */
float   m_pty;                   /* [1151] maximum global Y-shear component */
float   m_ptz;                   /* [1151] maximum global Z-shear component */
float   m_m;                     /* [1152] maximum spring moment */
float   m_v;                     /* [1003] maximum axial displacement */
float   m_vt;                    /* [1003] maximum transverse displacement */
float   m_vtx;                   /* [1003] maximum trans displ., global X-component */
float   m_vty;                   /* [1003] maximum trans displ., global Y-component */
float   m_vtz;                   /* [1003] maximum trans displ., global Z-component */
float   m_phi;                   /* [1004] rotation */
} typeCDB_SPRI_RE0;

#define SPRI_RES_VER 200501
typedef struct tagCDB_SPRI_RES { /* 170/LC  results of spring-elements */
int     m_nr;                    /*        springnumber */
float   m_p;                     /* [1151] spring force */
float   m_pt;                    /* [1151] spring transforce */
float   m_ptx;                   /* [1151] global X-shear component */
float   m_pty;                   /* [1151] global Y-shear component */
float   m_ptz;                   /* [1151] global Z-shear component */
float   m_m;                     /* [1152] spring moment */
float   m_v;                     /* [1003] axial displacement */
float   m_vt;                    /* [1003] trans. displacement */
float   m_vtx;                   /* [1003] trans. displacement, global X-component */
float   m_vty;                   /* [1003] trans. displacement, global Y-component */
float   m_vtz;                   /* [1003] trans. displacement, global Z-component */
float   m_phi;                   /* [1004] rotation */
float   m_lex;                   /*        nonlinear effect */
float   m_stvp[10];              /*        State variable / Damage Parameter for CP */
float   m_stvm[10];              /*        State variable / Damage Parameter for CM */
float   m_stvt[10];              /*        State variable / Damage Parameter for CT */
} typeCDB_SPRI_RES;

#define DAMP_VER 200501
typedef struct tagCDB_DAMP {     /* 171/00  Damping elements (DYNA) */
int     m_nr;                    /*        element number */
int     m_node[2];               /*        nodenumbers */
int     m_i_3;
float   m_t[3];                  /*        normal direction */
float   m_aref;                  /*        reference area */
float   m_dp;                    /*        damping constant */
float   m_dq;                    /*        damping shear */
float   m_dm;                    /*        damping moment */
float   m_expp;                  /*        exponent for nonlinear damping dp**expp */
float   m_expq;                  /*        exponent for nonlinear damping dq**expq */
float   m_expm;                  /*        exponent for nonlinear damping dm**expm */
} typeCDB_DAMP;

#define MASS_VER 200501
typedef struct tagCDB_MASS {     /* 172/00  Persistent Nodal masses */
int     m_nr;                    /*        nodenumber */
int     m_nrg;                   /*        pseudoelementnumber IGDIV*Groupnr+IREF */
float   m_mt[3];                 /* [  52] transversal mass mt-x,mt-y,mt-z */
float   m_mr[6];                 /* [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz */
float   m_mb[7];                 /*        warping  mass and higher coefficients */
} typeCDB_MASS;

#define MASS_ADD_VER 200501
typedef struct tagCDB_MASS_ADD { /* 172/01  non persistent additional nodal masses */
int     m_nr;                    /*        nodenumber */
int     m_nrg;                   /*        pseudoelementnumber IGDIV*Groupnr+IREF */
float   m_mt[3];                 /* [  52] transversal mass mt-x,mt-y,mt-z */
float   m_mr[6];                 /* [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz */
float   m_mb[7];                 /*        warping  mass and higher coefficients */
} typeCDB_MASS_ADD;

#define MASS_EFF_VER 200910
typedef struct tagCDB_MASS_EFF { /* 172/LD  Effective nodal masses */
int     m_nr;                    /*        identifier */
float   m_mt[3];                 /* [  52] transversal mass mt-x,mt-y,mt-z */
float   m_mr[3];                 /* [  55] rotatory mass    mr-xx,mr-yy,mr-zz */
} typeCDB_MASS_EFF;

#define MASS_EFC_VER 200910
typedef struct tagCDB_MASS_EFC { /* 172/LD  Effective consistent masses */
int     m_nr;                    /*        identifier = negative number of nodes */
int     m_node[8];               /*        node numbers */
float   m_m[1176];               /*        mass matrix in triangular format */
} typeCDB_MASS_EFC;

#define SPRI_WL0_ID 0
#define SPRI_WL0_VER 201502
typedef struct tagCDB_SPRI_WL0 { /* 173/NR  (nonlinear) Spring material */
int     m_id;                    /*        Identification = 0 */
int     m_ltyp;                  /*        Type of link */
#define SPRI_WL0_LTYP_STD 1
#define SPRI_WL0_LTYP_IHNG 2
#define SPRI_WL0_LTYP_PMM 3
int     m_mtyp;                  /*        Type of law */
#define SPRI_WL0_MTYP_PLAS 1
#define SPRI_WL0_MTYP_PISO 2
#define SPRI_WL0_MTYP_HYPE 3
#define SPRI_WL0_MTYP_PKIN 4
int     m_icap;                  /*        capacities from reference-section SNO */
int     m_ibit2;                 /*        reserved */
int     m_ihbit;                 /*        Bitpattern of defined degrees of freedom for implicit hinges */
float   m_rlim[2][7];            /* [1105]  */
float   m_alph;                  /*        Interpolation exponent My-Mz (PMM, only) */
float   m_par[16];               /*        further reserved material parameters */
pckcode m_title[17];             /*        Designation */
#define SPRI_WL0_TITLE_LEN 32
} typeCDB_SPRI_WL0;

#define SPRI_WL_VER 201206
typedef struct tagCDB_SPRI_WL {  /* 173/NR  Worklaw for nonlinear Springs */
int     m_id;                    /*        Identification */
#define SPRI_WL_ID_CP 1
#define SPRI_WL_ID_CQ 2
#define SPRI_WL_ID_CM 3
#define SPRI_WL_ID_NX 11
#define SPRI_WL_ID_VY 12
#define SPRI_WL_ID_VZ 13
#define SPRI_WL_ID_MT 14
#define SPRI_WL_ID_MY 15
#define SPRI_WL_ID_MZ 16
#define SPRI_WL_ID_MB 17
int     m_ntyp;                  /*        Type of law */
#define SPRI_WL_NTYP_USER 0
#define SPRI_WL_NTYP_LIN 1
#define SPRI_WL_NTYP_BILIN 2
#define SPRI_WL_NTYP_TRILIN 3
#define SPRI_WL_NTYP_PLAS 4
float   m_plvl;                  /* [1101] Normal force reference level */
float   m_eur;                   /*        Elastic unloading/reloading stiffness [kN/m],[kNm/rad] */
float   m_par[8];                /*        further reserved material parameters */
float   m_arb[20][5];            /*        Function values */
} typeCDB_SPRI_WL;

#define SPRI_MOV_VER 200501
typedef struct tagCDB_SPRI_MOV { /* 174/00  Moving Springs */
int     m_nr;                    /*        spring element number */
int     m_typ;                   /*        searching criteria */
int     m_from;                  /*        selection for TYP */
int     m_to;                    /*        selection for TYP */
int     m_inc;                   /*        selection for TYP */
} typeCDB_SPRI_MOV;

#define S_MATRIX_VER 201601
typedef struct tagCDB_S_MATRIX { /* 175/00  General systemmatrices */
int     m_nr;                    /*        element number */
int     m_typ;                   /*        element type */
int     m_ndn;                   /*        number of degrees of freedom per node */
int     m_node[6];               /*        node numbers */
float   m_per;                   /* [  90] period of matrix */
float   m_s[2048];               /*        stiffness matrix */
} typeCDB_S_MATRIX;

#define BOUN_VER 200501
typedef struct tagCDB_BOUN {     /* 180/00  Boundary elements */
int     m_nr;                    /*        elementnumber */
int     m_nvon;                  /*        start nodenumber */
int     m_nbis;                  /*        end nodenumber */
int     m_ndel;                  /*        increment */
int     m_typ;                   /*        type of bedding */
int     m_mess;                  /*        direction of addition */
float   m_ca;                    /*        start constant of bedding */
float   m_ce;                    /*        end constant of bedding */
float   m_dxyz[3];               /*        direction of bedding, X/Y/Z-component */
pckcode m_text[17];              /*        Designation of element */
#define BOUN_TEXT_LEN 32
} typeCDB_BOUN;

#define BOUN_RES_VER 200501
typedef struct tagCDB_BOUN_RES { /* 180/LC  results of boundary elements */
int     m_nr;                    /*        element number */
int     m_nk;                    /*        nodenumber */
float   m_px;                    /* [1153] X-support force */
float   m_py;                    /* [1153] Y-support force */
float   m_pz;                    /* [1153] Z-support force */
float   m_mn;                    /* [1154] support moment */
} typeCDB_BOUN_RES;

#define BOUN_SUM_VER 200501
typedef struct tagCDB_BOUN_SUM { /* 181/LC  resultant of boundary results */
int     m_nr;                    /*        element number */
float   m_px;                    /* [1151] X-support force */
float   m_py;                    /* [1151] X-support force */
float   m_pz;                    /* [1151] X-support force */
float   m_mn;                    /* [1152] N-support moment */
float   m_mx;                    /* [1152] X-support moment */
float   m_my;                    /* [1152] Y-support moment */
float   m_mz;                    /* [1152] Z-support moment */
} typeCDB_BOUN_SUM;

#define BOUN_LC_VER 200501
typedef struct tagCDB_BOUN_LC {  /* 183/LC  Info on loading on boundaries */
int     m_nr;                    /*        element number */
int     m_typ;                   /*        type of load */
struct {
int     m_n;
float   m_p;
      } m_lpt[127];              /*        node number + load value */
} typeCDB_BOUN_LC;

#define SPRI_SUM_VER 200501
typedef struct tagCDB_SPRI_SUM { /* 187/LC  Sum of forces of support springs */
int     m_nr;                    /*        group-number */
float   m_px;                    /* [1151] nodal support X */
float   m_py;                    /* [1151] nodal support Y */
float   m_pz;                    /* [1151] nodal support u */
float   m_mx;                    /* [1152] support moment X */
float   m_my;                    /* [1152] support moment Y */
float   m_mz;                    /* [1152] support moment Z */
float   m_mb;                    /* [1105] warping moment */
} typeCDB_SPRI_SUM;

#define RSET_VER 201005
typedef struct tagCDB_RSET {     /* 188/00  Sets of results */
bhr     m_id;                    /*        number / identifier of result set */
int     m_nit;                   /*        number of items in that result set */
pckcode m_text[17];              /*        Designation of that set */
#define RSET_TEXT_LEN 32
} typeCDB_RSET;

#define RSET_ITM_ID 0
#define RSET_ITM_VER 201005
typedef struct tagCDB_RSET_ITM { /* 188/00  Member of result set */
int     m_id0;                   /*        Identifier = 0 */
chr     m_id[2];                 /*        Short name of member for headdings */
chr     m_ids[2];                /*        Selector of main structure */
chr     m_idm[2];                /*        Selector of item member */
int     m_dim;                   /*        enum of explicitly selected unit */
int     m_kwh;                   /*        main id of result data */
int     m_pos;                   /*        position of value in data (starting at zero) */
int     m_bit;                   /*        bit pattern of defined selection data */
int     m_nr;                    /*        main number of result data */
int     m_ng;                    /*        second number of result data (e.g. group) */
int     m_nd1;                   /*        reserved for additional selection data */
int     m_nd2;                   /*        reserved for additional selection data */
int     m_nd3;                   /*        reserved for additional selection data */
float   m_x;                     /*        selector for beam abscissae */
} typeCDB_RSET_ITM;

#define RSET_DAT_VER 200910
typedef struct tagCDB_RSET_DAT { /* 188/LC  Result-values for sets of results */
bhr     m_id;                    /*        identifier of result set */
float   m_val[255];              /*        result values */
} typeCDB_RSET_DAT;

#define LINK_VER 201304
typedef struct tagCDB_LINK {     /* 179/00  link elements */
int     m_nr;                    /*        pipenumber */
int     m_node[2];               /*        nodenumbers */
int     m_nrq;                   /*        material-, type- or cross-sectionnumber */
float   m_dl;                    /* [1001] length of pipe */
float   m_a;                     /*        Nominal width or linear loss factor */
float   m_b;                     /*        Abs. Roughness or quadratic loss factor */
float   m_c;                     /*        specific storage coefficient */
float   m_eps;                   /*        emission coefficient */
float   m_aref;                  /* [1002] reference area of element */
} typeCDB_LINK;

#define PIPE_VER 201304
typedef struct tagCDB_PIPE {     /* 190/00  pipes / armatures */
int     m_nr;                    /*        pipenumber */
int     m_node[2];               /*        nodenumbers */
int     m_nrq;                   /*        material-, type- or cross-sectionnumber */
float   m_dl;                    /* [1001] length of pipe */
float   m_a;                     /*        Nominal width or linear loss factor */
float   m_b;                     /*        Abs. Roughness or quadratic loss factor */
float   m_c;                     /*        specific storage coefficient */
float   m_eps;                   /*        emission coefficient */
float   m_aref;                  /* [1002] reference area of element */
} typeCDB_PIPE;

#define PIPE_RES_VER 200501
typedef struct tagCDB_PIPE_RES { /* 190/LC  results of pipes */
int     m_nr;                    /*        pipenumber */
float   m_ha;                    /* [1010] start potential */
float   m_he;                    /* [1010] end potential */
float   m_i;                     /*        gradient */
float   m_a;                     /* [1012] flow area */
float   m_pa;                    /* [  70] start compression */
float   m_pe;                    /* [  70] end compression */
float   m_q;                     /* [1211] flow quantity */
float   m_v;                     /* [1212] flow velocity */
float   m_r;                     /* [1011] hydraulic radius */
float   m_k;                     /* [1016] roughness */
float   m_re;                    /*        Reynolds number */
float   m_fr;                    /*        Froud    number */
} typeCDB_PIPE_RES;

#define QUAD_VER 201408
typedef struct tagCDB_QUAD {     /* 200/00  QuadElements */
int     m_nr;                    /*        elementnumber */
int     m_node[4];               /*        nodenumbers */
int     m_mat;                   /*        materialnumber */
int     m_mrf;                   /*        material Reinf. */
int     m_nra;                   /*        type of element */
float   m_det[3];                /*        Parameter of Jacobi Determinant */
float   m_thick[5];              /* [1010] element thickness */
float   m_cb;                    /*        bedding factor */
float   m_cq;                    /*        tangential bedding factor */
float   m_t[3][3];               /*        transformation matrix */
int     m_ifc1;                  /*        identifier of a most adjacent outer boundary */
float   m_dfc1[4];               /* [1001] distance of the nodes to the boundary IFC1 */
int     m_ifc2;                  /*        identifier of a most adjacent inner boundary */
float   m_dfc2[4];               /* [1001] distance of the nodes to the boundary IFC2 */
#define LEN_CQUAD0 27
} typeCDB_QUAD;

#define QUAD_NOH_ID 0
#define QUAD_NOH_VER 0
typedef struct tagCDB_QUAD_NOH { /* 200/1  unified properties of Quad-nodes */
int     m_id1;
int     m_id2;
int     m_nkrec;
int     m_maxnel;
int     m_maxugr;
int     m_maxgr;
int     m_nquad;
int     m_mquad;                 /*        Highest Number of Quadelement */
} typeCDB_QUAD_NOH;

#define QUAD_NOM_VER 0
typedef struct tagCDB_QUAD_NOM { /* 200/1  unified properties of Quad-nodes */
int     m_ngt;                   /*        groupselector */
int     m_nr;                    /*        nodenumber */
int     m_iel[1];                /*        connecting elements */
                                 /*        unknown length! */
#define ANZOF_QUAD_NOM_IEL(il) ((il)-offsetof(typeCDB_QUAD_NOM,m_iel))/sizeof(int)
} typeCDB_QUAD_NOM;

#define QUAD_NOD_VER 0
typedef struct tagCDB_QUAD_NOD { /* 200/1  properties of Quad-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_d;                     /* [1010] minimum thickness of plate on node */
float   m_t[3][3];               /*        lokal average coordinate system */
} typeCDB_QUAD_NOD;

#define QUAD_EDH_ID 0
#define QUAD_EDH_VER 0
typedef struct tagCDB_QUAD_EDH { /* 200/2  Edges of Quad-elements */
int     m_id1;
int     m_id2;
int     m_nedg;
int     m_mqua;                  /*        max number of quads per edge */
} typeCDB_QUAD_EDH;

#define QUAD_EDG_VER 0
typedef struct tagCDB_QUAD_EDG { /* 200/2  Edges of Quad-elements */
int     m_ka;                    /*        First Node */
int     m_ke;                    /*        Last Node */
int     m_ijmp;                  /*        bit pattern of jump condition */
int     m_nqua;                  /*        number of quads */
int     m_nrel[1];               /*        Number of Quad-elements */
                                 /*        unknown length! */
#define ANZOF_QUAD_EDG_NREL(il) ((il)-offsetof(typeCDB_QUAD_EDG,m_nrel))/sizeof(int)
} typeCDB_QUAD_EDG;

#define QUAD_TEN_VER 200501
typedef struct tagCDB_QUAD_TEN { /* 200/5  tendons of Quad-elements */
int     m_nr;                    /*        elementnumber */
int     m_nrs;                   /*        tendon number */
int     m_mnr;                   /*        tendon material */
int     m_iba1;                  /*        construction stage number for placing */
int     m_iba2;                  /*        construction stage number for grouting */
int     m_iba3;                  /*        construction stage number for removing */
float   m_r[2];                  /*        isoparametric coordinates start/end point */
float   m_s[2];                  /*        isoparametric coordinates start/end point */
float   m_z[2];                  /* [1011] eccentricity of the middle area */
float   m_zz[2];                 /* [1101] tendon force, start- and endpoint */
float   m_az;                    /* [1020] area of tendon */
float   m_uz;                    /* [1023] effect. periphery */
float   m_ah;                    /* [1020] area of duct */
float   m_ar;                    /* [1012] relative area */
float   m_dy[2];                 /*        gradient of tendon */
float   m_dz[2];                 /*        gradient of tendon */
float   m_exz[2];                /* [1011] perpendicular eccentricity of duct to tendon */
float   m_exy[2];                /* [1011] transverse eccentricity of duct to tendon */
float   m_sref[2];               /*        parameter values along tendon geometry */
float   m_xyzt[2][3];            /* [1001] Coordinates of tendon start & endpoint */
float   m_xyzh[2][3];            /* [1001] Coordinates of duct start & endpoint */
} typeCDB_QUAD_TEN;

#define QUAD_RIM_VER 200501
typedef struct tagCDB_QUAD_RIM { /* 200/6  Prescribed Reinforcements of Quad-elements */
int     m_nrg;                   /*        group number */
int     m_nr;                    /*        selector number */
int     m_typ;                   /*        Type of Reinforc. */
int     m_gtyp;                  /*        Type of grading */
int     m_idra;                  /*        drawing source type */
float   m_rio;                   /* [   5] direction of upside reinforcement */
float   m_rioq;                  /* [   5] direction of upside cross reinforcement */
float   m_rioi;                  /* [   5] direction of upside third reinforcement */
float   m_riu;                   /* [   5] direction of downside reinforcement */
float   m_riuq;                  /* [   5] direction of downside cross reinforcement */
float   m_riui;                  /* [   5] direction of downside third reinforcement */
float   m_xref;                  /* [1001] Reference point for circular reinforcement */
float   m_yref;                  /* [1001] Reference point for circular reinforcement */
float   m_zref;                  /* [1001] Reference point for circular reinforcement */
float   m_hio;                   /* [1024] distance of upside reinforcement */
float   m_hioq;                  /* [1024] distance of upside cross reinforcement */
float   m_hioi;                  /* [1024] distance of upside third reinforcement */
float   m_hiu;                   /* [1024] distance of downside reinforcement */
float   m_hiuq;                  /* [1024] distance of downside cross reinforcement */
float   m_hiui;                  /* [1024] distance of downside third reinforcement */
float   m_dio;                   /* [1023] Diameter of upside reinforcement */
float   m_dioq;                  /* [1023] Diameter of upside cross reinforcement */
float   m_dioi;                  /* [1023] Diameter of upside third reinforcement */
float   m_diu;                   /* [1023] Diameter of downside reinforcement */
float   m_diuq;                  /* [1023] Diameter of downside cross reinforcement */
float   m_diui;                  /* [1023] Diameter of downside third reinforcement */
float   m_dss;                   /* [1023] Diameter of transverse reinforcement */
float   m_aso;                   /* [1021] upside Minimum reinforcement (outside) */
float   m_asoq;                  /* [1021] upside cross Minimum reinforcement (middle) */
float   m_asoi;                  /* [1021] upside third Minimum reinforcement (inside) */
float   m_asu;                   /* [1021] downside Minimum reinforcement (outside) */
float   m_asuq;                  /* [1021] downside cross Minimum reinforcement (middle) */
float   m_asui;                  /* [1021] downside third Minimum reinforcement (inside) */
float   m_ass;                   /* [1022] Min stirrup cm2/m2 */
float   m_amo;                   /* [1021] upside Maximum reinforcement (outside) */
float   m_amoq;                  /* [1021] upside cross Maximum reinforcement (middle) */
float   m_amoi;                  /* [1021] upside third Maximum reinforcement (inside) */
float   m_amu;                   /* [1021] downside Maximum reinforcement (outside) */
float   m_amuq;                  /* [1021] downside cross Maximum reinforcement (middle) */
float   m_amui;                  /* [1021] downside third Maximum reinforcement (inside) */
float   m_ams;                   /* [1022] Max stirrup cm2/m2 */
float   m_wk6[6];                /* [1026] design crack width */
float   m_sig6[6];               /* [1092] SLS steel stress limit */
} typeCDB_QUAD_RIM;

#define QUAD_RID_ID 0
#define QUAD_RID_VER 201603
typedef struct tagCDB_QUAD_RID { /* 200/7  Reinforcement Definitions of Quad-elements */
int     m_id;                    /*        identifier (0 = Headder of a definition) */
int     m_nrg;                   /*        group number */
int     m_nr;                    /*        selector or element number */
int     m_bits;                  /*        Type of grading */
float   m_ass;                   /* [1022] Min stirrup ratio */
float   m_ams;                   /* [1022] Max stirrup ratio */
float   m_dss;                   /* [1023] Diameter of stirrup reinforcements */
chr     m_expp;                  /*        Exposition class at positive face */
chr     m_expn;                  /*        Exposition class at negative face */
} typeCDB_QUAD_RID;

#define QUAD_RED_ID 0
#define QUAD_RED_VER 201603
typedef struct tagCDB_QUAD_RED { /* 270/0  Evaluated Reinforcement Definitions of Elements */
int     m_id;                    /*        identifier (0 = Headder of a definition) */
int     m_nrg;                   /*        group number */
int     m_nr;                    /*        selector or element number */
int     m_bits;                  /*        Type of grading */
float   m_ass;                   /* [1022] Min stirrup ratio */
float   m_ams;                   /* [1022] Max stirrup ratio */
float   m_dss;                   /* [1023] Diameter of stirrup reinforcements */
chr     m_expp;                  /*        Exposition class at positive face */
chr     m_expn;                  /*        Exposition class at negative face */
} typeCDB_QUAD_RED;

#define QUAD_RIL_VER 201603
typedef struct tagCDB_QUAD_RIL { /* 200/7  Reinforcement Layers of Quad-elements */
bhr     m_id;                    /*        reference for this layer */
int     m_dir;                   /*        Type of local x-direction */
float   m_rot;                   /* [   5] Angle with reference to the local x-direction */
float   m_xdir;                  /* [1001] Global reference direction or reference point */
float   m_ydir;                  /* [1001] Global reference direction or reference point */
float   m_zdir;                  /* [1001] Global reference direction or reference point */
float   m_h;                     /* [1011] effective distance according to ID-reference definition */
float   m_asmin;                 /* [1021] Min reinforcement value */
float   m_asmax;                 /* [1021] Max reinforcement value */
float   m_d;                     /* [1023] Diameter of reinforcements */
float   m_sig;                   /* [1092] SLS steel stress limit for crack width (optional) */
float   m_crw;                   /* [1026] design crack width (optional) */
} typeCDB_QUAD_RIL;

#define QUAD_REL_VER 201603
typedef struct tagCDB_QUAD_REL { /* 270/0  Evaluated Reinforcement Definitions of Elements */
bhr     m_id;                    /*        reference for this layer */
int     m_dir;                   /*        Type of local x-direction */
float   m_rot;                   /* [   5] Angle with reference to the local x-direction */
float   m_xdir;                  /* [1001] Global reference direction or reference point */
float   m_ydir;                  /* [1001] Global reference direction or reference point */
float   m_zdir;                  /* [1001] Global reference direction or reference point */
float   m_h;                     /* [1011] effective distance according to ID-reference definition */
float   m_asmin;                 /* [1021] Min reinforcement value */
float   m_asmax;                 /* [1021] Max reinforcement value */
float   m_d;                     /* [1023] Diameter of reinforcements */
float   m_sig;                   /* [1092] SLS steel stress limit for crack width (optional) */
float   m_crw;                   /* [1026] design crack width (optional) */
} typeCDB_QUAD_REL;

#define QCUT_0_ID 0
#define QCUT_0_VER 0
typedef struct tagCDB_QCUT_0 {   /* 200/8  Header for fabrication areas */
int     m_nr;                    /*        identifier = 0 */
int     m_typ;                   /*        identifier = 0 */
int     m_nar;                   /*        number of areas */
float   m_x;                     /* [1001] x-center */
float   m_y;                     /* [1001] y- */
float   m_ar3d;                  /* [1002] area in 3D */
float   m_ar2d;                  /* [1002] area in 2D */
float   m_ar_0;                  /* [1002] area stressfree */
} typeCDB_QCUT_0;

#define QCUT_NEW_VER 0
typedef struct tagCDB_QCUT_NEW { /* 200/8  New cutting area */
int     m_nr;                    /*        areanumber */
int     m_typ;                   /*        identifier = 0 */
int     m_lf;                    /*        Loadcase */
float   m_x;                     /* [1001] x-ordinate */
float   m_y;                     /* [1001] y- center(text) */
float   m_ar3d;                  /* [1002] area in 3D */
float   m_ar2d;                  /* [1002] area in 2D */
float   m_ar_0;                  /* [1002] area stressfree */
} typeCDB_QCUT_NEW;

#define QCUT_DIR_VER 0
typedef struct tagCDB_QCUT_DIR { /* 200/8  Material direction */
int     m_nr;                    /*        areanumber */
int     m_typ;                   /*        Identification */
int     m_mnr;                   /*        material no */
float   m_alf;                   /* [   5] warp direction */
float   m_emod;                  /* [1090] E Mod warp direction */
float   m_e90;                   /* [1090] Elasticity modulus perpendicular */
} typeCDB_QCUT_DIR;

#define QCUT_OUT_VER 0
typedef struct tagCDB_QCUT_OUT { /* 200/8  Vertex of geometric boundary */
int     m_nr;                    /*        areanumber */
int     m_typ;                   /*        Identification */
int     m_line;                  /*        linetype */
float   m_x;                     /* [1001] x-ordinate */
float   m_y;                     /* [1001] y-ordinate */
} typeCDB_QCUT_OUT;

#define QCUT_IN_VER 0
typedef struct tagCDB_QCUT_IN {  /* 200/8  Geometry inner lines */
int     m_nr;                    /*        areanumber */
int     m_typ;                   /*        Identification */
int     m_i_2;
float   m_xa;                    /* [1001] x  startpoint */
float   m_ya;                    /* [1001] y  startpoint */
float   m_xe;                    /* [1001] x  endpoint */
float   m_ye;                    /* [1001] y  endpoint */
} typeCDB_QCUT_IN;

#define QCUT_WAR_VER 0
typedef struct tagCDB_QCUT_WAR { /* 200/8  element warp direction */
int     m_nr;                    /*        areanumber */
int     m_typ;                   /*        Identification */
int     m_nrel;                  /*        orig elem.no */
float   m_xa;                    /* [1001] x  startpoint */
float   m_ya;                    /* [1001] y  startpoint */
float   m_xe;                    /* [1001] x  endpoint */
float   m_ye;                    /* [1001] y  endpoint */
float   m_alf;                   /* [   5] warp direction */
} typeCDB_QCUT_WAR;

#define TEXTILE_VER 200501
typedef struct tagCDB_TEXTILE {  /* 200/9  definition of cutting lines */
int     m_ig;                    /*        group selector */
int     m_typ;                   /*        type of line */
float   m_xa;                    /* [1001] line point A */
float   m_ya;                    /* [1001]  */
float   m_za;                    /* [1001]  */
float   m_xe;                    /* [1001] line point E */
float   m_ye;                    /* [1001]  */
float   m_ze;                    /* [1001]  */
float   m_nx;                    /* [1001] projection */
float   m_ny;                    /* [1001]  */
float   m_nz;                    /* [1001]  */
} typeCDB_TEXTILE;

#define QUAD_P_VER 200501
typedef struct tagCDB_QUAD_P {   /* 200/10  Quad-P-elements */
int     m_nr;                    /*        elementnumber */
int     m_node[4];               /*        nodenumbers */
int     m_mat;                   /*        materialnumber */
int     m_mrf;                   /*        material Reinf. */
int     m_nra;                   /*        type of element */
int     m_edge[4];               /*        No of geometric property of edge 1-2 */
float   m_det[3];                /*        Parameter of Jacobi Determinant */
float   m_thick[5];              /* [1010] element thickness */
float   m_cb;                    /*        bedding factor */
float   m_cq;                    /*        tangential bedding factor */
float   m_t[3][3];               /*        transformation matrix */
} typeCDB_QUAD_P;

#define QUAD_LOA_VER 200501
typedef struct tagCDB_QUAD_LOA { /* 202/LC  Quad-element loads */
int     m_von;                   /*        start elementnumber */
int     m_bis;                   /*        end elementnumber */
int     m_del;                   /*        increment */
int     m_typ;                   /*        type of load */
int     m_lnr;                   /*        special option value */
float   m_p;                     /*        load values */
float   m_dpdx;
float   m_dpdy;
float   m_dpdz;
float   m_xref;                  /* [1001] optional reference point for load value to */
float   m_yref;                  /* [1001]  */
float   m_zref;                  /* [1001]  */
float   m_tfun[16][2];           /*        optional function of load values across the */
} typeCDB_QUAD_LOA;

#define QUAD_LPI_VER 0
typedef struct tagCDB_QUAD_LPI { /* 203/LC  internal single loads on Quad-elements */
int     m_nr;                    /*        element number */
int     m_typ;                   /*        type of load */
float   m_prz;                   /* [   8] Percentage of load covered with elements */
float   m_s;                     /*        load point in local coordinates */
float   m_t;                     /*        load point in local coordinates */
float   m_p;                     /*        load value */
} typeCDB_QUAD_LPI;

#define QUAD_LLI_VER 0
typedef struct tagCDB_QUAD_LLI { /* 203/LC  internal line loads of Quad-elements */
int     m_nr;                    /*        element number */
int     m_typ;                   /*        type of load */
float   m_prz;                   /* [   8]  */
float   m_sa;
float   m_ta;
float   m_pa;
float   m_sb;
float   m_tb;
float   m_pb;                    /*        load value end point */
} typeCDB_QUAD_LLI;

#define QUAD_LAI_VER 0
typedef struct tagCDB_QUAD_LAI { /* 203/LC  Free area loads on Quad-elements */
int     m_nr;                    /*        element number */
int     m_typ;                   /*        type of load */
float   m_prz;                   /* [   8]  */
struct {
float   m_s;
float   m_t;
float   m_p;
      } m_lpt[63];               /*        load points in local coordinates */
} typeCDB_QUAD_LAI;

#define QUAD_LT_VER 200811
typedef struct tagCDB_QUAD_LT {  /* 206/NR  Temperature load profiles for QUADs */
float   m_t;                     /* [  90] Time value */
float   m_temp[20][5];           /*        Temperature values */
} typeCDB_QUAD_LT;

#define QUAD_FOC_ID 0
#define QUAD_FOC_VER 200501
typedef struct tagCDB_QUAD_FOC { /* 210/LC  maximum forces of Quad elements */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force */
float   m_vy;                    /* [1111] shear force */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_hp1;                   /*        yield function */
float   m_hp2;                   /*        volum. hardening */
} typeCDB_QUAD_FOC;

#define QUAD_FOR_VER 200501
typedef struct tagCDB_QUAD_FOR { /* 210/LC  forces of Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force */
float   m_vy;                    /* [1111] shear force */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_sg[4][8];              /* [1112] results in GAUSS-points */
float   m_hp1[5];                /*        yield function */
float   m_hp2[5];                /*        volum. hardening */
float   m_hp3[5];                /*        3rd parameter */
} typeCDB_QUAD_FOR;

#define QUAD_NFC_ID 0
#define QUAD_NFC_VER 200501
typedef struct tagCDB_QUAD_NFC { /* 211/LC  maximum forces in nodes */
int     m_ng;                    /*        ident 0 for maximum (first records) */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force */
float   m_vy;                    /* [1111] shear force */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_vx_v;                  /* [1111] shear force signed */
float   m_vy_v;                  /* [1111] shear force signed */
float   m_hp1;                   /*        yield function */
} typeCDB_QUAD_NFC;

#define QUAD_NFO_VER 200501
typedef struct tagCDB_QUAD_NFO { /* 211/LC  Nodal Quad forces */
int     m_ng;                    /*        groupselector */
int     m_nr;                    /*        nodenumber */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force abs */
float   m_vy;                    /* [1111] shear force abs */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_vx_v;                  /* [1111] shear force signed */
float   m_vy_v;                  /* [1111] shear force signed */
float   m_fy;                    /*        yield function */
} typeCDB_QUAD_NFO;

#define QUAD_EFC_ID 0
#define QUAD_EFC_VER 200501
typedef struct tagCDB_QUAD_EFC { /* 212/LC  maximum error estimates for Quad-elements */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force */
float   m_vy;                    /* [1111] shear force */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_err;                   /*        error in energy */
} typeCDB_QUAD_EFC;

#define QUAD_EFO_VER 200501
typedef struct tagCDB_QUAD_EFO { /* 212/LC  error estimates for Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_mxx;                   /* [1114] bending moment */
float   m_myy;                   /* [1114] bending moment */
float   m_mxy;                   /* [1113] torsion moment */
float   m_vx;                    /* [1111] shear force */
float   m_vy;                    /* [1111] shear force */
float   m_nx;                    /* [1112] membran force */
float   m_ny;                    /* [1112] membran force */
float   m_nxy;                   /* [1112] membran force */
float   m_hopt;                  /* [1001] optimal mesh size */
} typeCDB_QUAD_EFO;

#define QUAD_BEC_ID 0
#define QUAD_BEC_VER 200501
typedef struct tagCDB_QUAD_BEC { /* 213/LC  bedding stresses and results */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_pse;                   /* [1155] bedding centre */
float   m_ps[4];                 /* [1155] bedding in nodes */
float   m_pre;                   /* [1151] result bedd.force in centre */
float   m_pr[4];                 /* [1151] result bedd. values in Quad-nodes */
float   m_pve;                   /* [1003] bedding displacememts in centre */
float   m_pv[4];                 /* [1003] bedding displacements in nodes */
float   m_pte;                   /* [1155] tangential bedding in centre */
float   m_pt[4];                 /* [1155] tangential bedding in nodes */
float   m_ptxe;                  /* [1155] tangential bedding in centre X-component */
float   m_ptx[4];                /* [1155] tangential bedding in nodes X-component */
float   m_ptye;                  /* [1155] tangential bedding in centre Y-component */
float   m_pty[4];                /* [1155] tangential bedding in nodes Y-component */
float   m_ptze;                  /* [1155] tangential bedding in centre Z-component */
float   m_ptz[4];                /* [1155] tangential bedding in nodes Z-component */
float   m_rq[12];                /* [1151] resulting tangential bedding in nodes */
} typeCDB_QUAD_BEC;

#define QUAD_BED_VER 200501
typedef struct tagCDB_QUAD_BED { /* 213/LC  bedding stresses and results */
int     m_nr;                    /*        Quadelementnumber */
float   m_pse;                   /* [1155] bedding centre */
float   m_ps[4];                 /* [1155] bedding in nodes */
float   m_pre;                   /* [1151] result bedd.force in centre */
float   m_pr[4];                 /* [1151] result bedd. values in Quad-nodes */
float   m_pve;                   /* [1003] bedding displacememts in centre */
float   m_pv[4];                 /* [1003] bedding displacements in nodes */
float   m_pte;                   /* [1155] tangential bedding in centre */
float   m_pt[4];                 /* [1155] tangential bedding in nodes */
float   m_ptxe;                  /* [1155] tangential bedding in centre X-component */
float   m_ptx[4];                /* [1155] tangential bedding in nodes X-component */
float   m_ptye;                  /* [1155] tangential bedding in centre Y-component */
float   m_pty[4];                /* [1155] tangential bedding in nodes Y-component */
float   m_ptze;                  /* [1155] tangential bedding in centre Z-component */
float   m_ptz[4];                /* [1155] tangential bedding in nodes Z-component */
float   m_rq[12];                /* [1151] resulting tangential bedding in nodes */
} typeCDB_QUAD_BED;

#define QUAD_RFX_VER 200501
typedef struct tagCDB_QUAD_RFX { /* 214/LC  additional information for primary loadcases */
int     m_nr;                    /*        Quad-elementnumber */
float   m_eps[8][5];             /*        strain */
float   m_riss[8][5];            /*        directions of crack */
} typeCDB_QUAD_RFX;

#define QUAD_RNC_ID 0
#define QUAD_RNC_VER 200501
typedef struct tagCDB_QUAD_RNC { /* 215/LC  nonlinear results of Quad-element */
int     m_nr;                    /*        ident 0 for maximum */
int     m_nmat;                  /*        type of material behaviour */
float   m_esxo;                  /* [   9] upside strain */
float   m_esyo;                  /* [   9] upside strain */
float   m_exyo;                  /* [   9] upside strain */
float   m_esmo;                  /* [   9] upside reference strain */
float   m_esxu;                  /* [   9] downside strain */
float   m_esyu;                  /* [   9] downside strain */
float   m_exyu;                  /* [   9] downside strain */
float   m_esmu;                  /* [   9] downside reference strain */
float   m_sxo;                   /* [1092] upside stress */
float   m_syo;                   /* [1092] upside stress */
float   m_sxyo;                  /* [1092] upside stress */
float   m_smo;                   /* [1092] upside reference stress */
float   m_sxu;                   /* [1092] downside stress */
float   m_syu;                   /* [1092] downside stress */
float   m_sxyu;                  /* [1092] downside stress */
float   m_sm_u;                  /* [1092] downside reference stress */
float   m_sgvo;                  /* [1092] upside reference stress incl. shear */
float   m_sgvu;                  /* [1092] downside reference stress incl. shear */
float   m_fy;                    /*        yield function */
float   m_fdo;                   /* [1011] steel - upside yield depth */
float   m_fdu;                   /* [1011] steel - downside yield depth */
float   m_i_22;
float   m_wr1o;                  /*        concrete - upside direction of crack 1 */
float   m_wr1u;                  /*        concrete - downside direction of crack 1 */
float   m_wr2o;                  /*        concrete - upside direction of crack 2 */
float   m_wr2u;                  /*        concrete - downside direction of crack 2 */
float   m_sgso;                  /* [1092] concrete - upside shear stress on crack */
float   m_sgsu;                  /* [1092] concrete - downside shear stress on crack */
float   m_sg1o;                  /* [1092] concrete - upside steel stress II,dir.1 */
float   m_sg1u;                  /* [1092] concrete - downside steel stress II,dir.1 */
float   m_sg2o;                  /* [1092] concrete - upside steel stress II,dir. 2 */
float   m_sg2u;                  /* [1092] concrete - downside steel stress II,dir.2 */
float   m_w1o;                   /* [1026] concrete - upside width of crack,direct. 1 */
float   m_w1u;                   /* [1026] concrete - downside width of crack,dir. 1 */
float   m_w2o;                   /* [1026] concrete - upside width of crack,direct. 2 */
float   m_w2u;                   /* [1026] concrete - downside width of crack,dir. 2 */
float   m_bro;                   /*        concrete -upside direction reinforcement */
float   m_bru;                   /*        concrete -downs. direction reinforcement */
float   m_xd_x;                  /* [1011] Minimum compression depth in local x axis */
float   m_xd_y;                  /* [1011] Minimum compression depth in local y axis */
float   m_xd_1;                  /* [1011] Minimum compression depth at least pressed uniaxial */
float   m_xd_2;                  /* [1011] Minimum compression depth pressed biaxial */
float   m_epsb;                  /* [   9] Maximum concrete compression strain */
float   m_epsc;                  /* [   9] Minimum averaged reinforcement strain */
float   m_epst;                  /* [   9] Maximum averaged reinforcement strain */
float   m_sigc;                  /* [1092] Maximum concrete compression stress */
float   m_sigt;                  /* [1092] Maximum concrete tension in the concrete layers */
float   m_epsr;                  /* [   9] Maximum reinforcement strain in the crack */
} typeCDB_QUAD_RNC;

#define QUAD_RNO_VER 200501
typedef struct tagCDB_QUAD_RNO { /* 215/LC  nonlinear results of Quad-element */
int     m_nr;                    /*        Quad-elementnumber */
int     m_nmat;                  /*        type of material behaviour */
float   m_esxo;                  /* [   9] upside strain */
float   m_esyo;                  /* [   9] upside strain */
float   m_exyo;                  /* [   9] upside strain */
float   m_esmo;                  /* [   9] upside reference strain */
float   m_esxu;                  /* [   9] downside strain */
float   m_esyu;                  /* [   9] downside strain */
float   m_exyu;                  /* [   9] downside strain */
float   m_esmu;                  /* [   9] downside reference strain */
float   m_sxo;                   /* [1092] upside stress */
float   m_syo;                   /* [1092] upside stress */
float   m_sxyo;                  /* [1092] upside stress */
float   m_smo;                   /* [1092] upside reference stress */
float   m_sxu;                   /* [1092] downside stress */
float   m_syu;                   /* [1092] downside stress */
float   m_sxyu;                  /* [1092] downside stress */
float   m_sm_u;                  /* [1092] downside reference stress */
float   m_sgvo;                  /* [1092] upside reference stress incl. shear */
float   m_sgvu;                  /* [1092] downside reference stress incl. shear */
float   m_fy;                    /*        yield function */
float   m_fdo;                   /* [1011] steel - upside yield depth */
float   m_fdu;                   /* [1011] steel - downside yield depth */
float   m_i_22;
float   m_wr1o;                  /*        concrete - upside direction of crack 1 */
float   m_wr1u;                  /*        concrete - downside direction of crack 1 */
float   m_wr2o;                  /*        concrete - upside direction of crack 2 */
float   m_wr2u;                  /*        concrete - downside direction of crack 2 */
float   m_sgso;                  /* [1092] concrete - upside shear stress on crack */
float   m_sgsu;                  /* [1092] concrete - downside shear stress on crack */
float   m_sg1o;                  /* [1092] concrete - upside steel stress II,dir.1 */
float   m_sg1u;                  /* [1092] concrete - downside steel stress II,dir.1 */
float   m_sg2o;                  /* [1092] concrete - upside steel stress II,dir. 2 */
float   m_sg2u;                  /* [1092] concrete - downside steel stress II,dir.2 */
float   m_w1o;                   /* [1026] concrete - upside width of crack,direct. 1 */
float   m_w1u;                   /* [1026] concrete - downside width of crack,dir. 1 */
float   m_w2o;                   /* [1026] concrete - upside width of crack,direct. 2 */
float   m_w2u;                   /* [1026] concrete - downside width of crack,dir. 2 */
float   m_bro;                   /*        concrete -upside direction reinforcement */
float   m_bru;                   /*        concrete -downs. direction reinforcement */
float   m_xd_x;                  /* [1011] Minimum compression depth in local x axis */
float   m_xd_y;                  /* [1011] Minimum compression depth in local y axis */
float   m_xd_1;                  /* [1011] Minimum compression depth at least pressed uniaxial */
float   m_xd_2;                  /* [1011] Minimum compression depth pressed biaxial */
float   m_epsb;                  /* [   9] Maximum concrete compression strain */
float   m_epsc;                  /* [   9] Minimum averaged reinforcement strain */
float   m_epst;                  /* [   9] Maximum averaged reinforcement strain */
float   m_sigc;                  /* [1092] Maximum concrete compression stress */
float   m_sigt;                  /* [1092] Maximum concrete tension in the concrete layers */
float   m_epsr;                  /* [   9] Maximum reinforcement strain in the crack */
} typeCDB_QUAD_RNO;

#define QUAD_STC_ID 0
#define QUAD_STC_VER 200502
typedef struct tagCDB_QUAD_STC { /* 220/LC  maximum Quad-stress */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_svxy;                  /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
float   m_hp1;                   /* [1092] yield function */
float   m_hp2;                   /*        2nd Parameter */
float   m_hp3;                   /*        3rd Parameter */
float   m_hp4;                   /*        4th Parameter */
float   m_hp5;                   /*        5th Parameter */
float   m_hp6;                   /*        6th Parameter */
} typeCDB_QUAD_STC;

#define QUAD_STP_VER 200501
typedef struct tagCDB_QUAD_STP { /* 220/LC  Nonlinear QUAD-stress Headder */
int     m_typ;                   /*        enum of nonlinear parameters as in 1/NR:1/??? */
struct {
int     m_id;
int     m_idim;
float   m_maxval;
      } m_htyp[15];              /*        = state variables for nonlinear material */
} typeCDB_QUAD_STP;

#define BRIC_STP_VER 200501
typedef struct tagCDB_BRIC_STP { /* 310/LC  Nonlinear BRIC-stress Headder */
int     m_typ;                   /*        enum of nonlinear parameters as in 1/NR:1/??? */
struct {
int     m_id;
int     m_idim;
float   m_maxval;
      } m_htyp[15];              /*        = state variables for nonlinear material */
} typeCDB_BRIC_STP;

#define QUAD_STR_VER 200502
typedef struct tagCDB_QUAD_STR { /* 220/LC  stresses of Quad-element */
int     m_nr;                    /*        Elementnumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
struct {
float   m_sigx;                  /* [1092]  */
float   m_sigy;                  /* [1092]  */
float   m_tau;                   /* [1092]  */
float   m_sigz;                  /* [1092]  */
      } m_sg[4];                 /*        results in GAUSS-points */
float   m_pvx;                   /* [1192] volume loading */
float   m_pvy;                   /* [1192] volume loading */
float   m_pvt;                   /* [   6] temperature loads */
float   m_hp1[5];                /*        yield function */
float   m_hp2[5];                /*        2nd parameter as specified in headder record */
float   m_hp3[5];                /*        3rd parameter as specified in headder record */
float   m_hp4[5];                /*        4th parameter as specified in headder record */
float   m_hp5[5];                /*        5th parameter as specified in headder record */
float   m_hp6[5];                /*        6th parameter as specified in headder record */
float   m_hp7[5];                /*        7th parameter as specified in headder record */
float   m_hp8[5];                /*        8th parameter as specified in headder record */
float   m_hp9[5];                /*        9th parameter as specified in headder record */
float   m_hp10[5];               /*        10th parameter as specified in headder record */
float   m_hp11[5];               /*        11th parameter as specified in headder record */
float   m_hp12[5];               /*        12th parameter as specified in headder record */
float   m_hp13[5];               /*        13th parameter as specified in headder record */
float   m_hp14[5];               /*        14th parameter as specified in headder record */
float   m_hp15[5];               /*        15th parameter as specified in headder record */
} typeCDB_QUAD_STR;

#define QUAD_NSC_ID 0
#define QUAD_NSC_VER 200501
typedef struct tagCDB_QUAD_NSC { /* 221/LC  maximum stresses in nodes */
int     m_ng;                    /*        ident 0 for maximum (first records) */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_svxy;                  /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
float   m_fy;                    /*        yield function */
} typeCDB_QUAD_NSC;

#define QUAD_NST_VER 200501
typedef struct tagCDB_QUAD_NST { /* 221/LC  stresses in Quad-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
float   m_fy;                    /*        yield function */
} typeCDB_QUAD_NST;

#define QUAD_ESC_ID 0
#define QUAD_ESC_VER 200501
typedef struct tagCDB_QUAD_ESC { /* 222/LC  max. errors in nodes */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_svxy;                  /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
float   m_err;                   /*        error in energy */
} typeCDB_QUAD_ESC;

#define QUAD_EST_VER 200501
typedef struct tagCDB_QUAD_EST { /* 222/LC  error estimates of Quad-element stresses */
int     m_nr;                    /*        elementnumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_tau;                   /* [1092] shear stress */
float   m_sigz;                  /* [1092] stress */
float   m_hopt;                  /* [1002] optimal mesh size */
} typeCDB_QUAD_EST;

#define QUAD_RLC_ID 0
#define QUAD_RLC_VER 200501
typedef struct tagCDB_QUAD_RLC { /* 225/LC  max Quad-Layer-results */
int     m_nr;                    /*        ident 0 for maximum (first records) */
int     m_mnr;                   /*        ident 0 for maximum (first records) */
float   m_xi;                    /*        local-z */
float   m_sigx;                  /* [1092] stress x */
float   m_sigy;                  /* [1092] stress y */
float   m_tau;                   /* [1092] shear stress xy */
float   m_sigz;                  /* [1092] stress */
float   m_taux;                  /* [1092] shear stress vx */
float   m_tauy;                  /* [1092] shear stress vy */
float   m_hp1;                   /*        yield function */
float   m_hp2;                   /*        volum. hardening */
float   m_hp3;                   /*        damage parameter x */
float   m_hp4;                   /*        damage parameter y */
float   m_hp5;                   /* [   3] crack direction 1 */
float   m_hp6;                   /* [   3] crack direction 2 */
float   m_hp7;                   /* [   9] accumulated temperature strain */
float   m_hp8;                   /*        internal damage parameter shrinkage */
float   m_hp9;                   /* [   9] accumulated shrinkage strain */
float   m_hp10;                  /*        damage parameter xy */
float   m_hp11;                  /* [   9] epsx  strain in stress strain curve */
float   m_hp12;                  /* [   9] epsy  strain in stress strain curve */
float   m_hp13;                  /* [1215] layer temperature in case of fire analysis */
} typeCDB_QUAD_RLC;

#define QUAD_RLA_VER 200501
typedef struct tagCDB_QUAD_RLA { /* 225/LC  Layer-stresses of Quads */
int     m_nr;                    /*        Elementnumber */
int     m_mnr;                   /*        Materialnumber MNR>0 */
float   m_xi;                    /*        local-z */
float   m_sigx;                  /* [1092] stress x */
float   m_sigy;                  /* [1092] stress y */
float   m_tau;                   /* [1092] shear stress xy */
float   m_sigz;                  /* [1092] stress */
float   m_taux;                  /* [1092] shear stress vx */
float   m_tauy;                  /* [1092] shear stress vy */
struct {
float   m_sigx;                  /* [1092]  */
float   m_sigy;                  /* [1092]  */
float   m_tau;                   /* [1092]  */
float   m_sigz;                  /* [1092]  */
float   m_taux;                  /* [1092]  */
float   m_tauy;                  /* [1092]  */
      } m_sg[4];                 /*        results in GAUSS-points */
float   m_hp1[5];                /*        yield function */
float   m_hp2[5];                /*        volum. hardening */
float   m_hp3[5];                /*        damage parameter x */
float   m_hp4[5];                /*        damage parameter y */
float   m_hp5[5];                /* [   3] crack direction 1 */
float   m_hp6[5];                /* [   3] crack direction 2 */
float   m_hp7[5];                /* [   9] accumulated temperature strain */
float   m_hp8[5];                /*        internal damage parameter shrinkage */
float   m_hp9[5];                /* [   9] accumulated shrinkage strain */
float   m_hp10[5];               /*        damage parameter xy */
float   m_hp11[5];               /* [   9] epsx  strain in stress strain curve */
float   m_hp12[5];               /* [   9] epsy  strain in stress strain curve */
float   m_hp13[5];               /* [1215] layer temperature in case of fire analysis */
float   m_hp14[5];               /* [1215] max. layer temperature in load history */
} typeCDB_QUAD_RLA;

#define QUAD_RLB_VER 200501
typedef struct tagCDB_QUAD_RLB { /* 225/LC  Layer-reinforcement stresses of Quads MNR=-1 */
int     m_nr;                    /*        Elementnumber */
int     m_mnr;                   /*        MNR=-1 identifier for reinforcement data */
float   m_xi;                    /*        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement */
float   m_sig1;                  /* [1092] stress in reinforcement 1. layer */
float   m_sig2;                  /* [1092] stress in reinforcement 2. layer */
float   m_eps1;                  /*        eps strain in stress strain curve 1. layer */
float   m_xi1;                   /*        exact xi position 1. layer */
float   m_xi2;                   /*        exact xi position 2. layer */
float   m_eps2;                  /*        eps strain in stress strain curve 2. layer */
struct {
float   m_sig1;                  /* [1092]  */
float   m_sig2;                  /* [1092]  */
float   m_eps1;
float   m_xi1;
float   m_xi2;
float   m_eps2;
      } m_sg[4];                 /*        results in GAUSS-points */
float   m_hp1[5];                /*        damage parameter 1. layer */
float   m_hp2[5];                /*        damage parameter 2. layer */
float   m_hp3[5];                /* [1092] delta-sigma tension stiff. layer 1 */
float   m_hp4[5];                /* [1092] delta-sigma tension stiff. layer 2 */
float   m_hp5[5];                /*        direction of reinforcement layer 1 */
float   m_hp6[5];                /*        direction of reinforcement layer 2 */
float   m_hp7[5];                /* [   9] accumulated temperature strain */
float   m_hp8[5];                /*        free */
float   m_hp9[5];                /*        free */
float   m_hp10[5];               /* [1215] layer 1 actual temperature in case of fire analysis */
float   m_hp11[5];               /* [1215] layer 2 actual temperature in case of fire analysis */
} typeCDB_QUAD_RLB;

#define QUAD_SEC_ID 0
#define QUAD_SEC_VER 200708
typedef struct tagCDB_QUAD_SEC { /* 229/LC  maximum Quad-sectional stress */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] normalstress */
float   m_sigy;                  /* [1092] transverse stress */
float   m_sigz;                  /* [1092] transverse stress */
float   m_tauxy;                 /* [1092] shear stress */
float   m_tauxz;                 /* [1092] shear stress */
float   m_tauyz;                 /* [1092] shear stress */
} typeCDB_QUAD_SEC;

#define QUAD_SEQ_VER 200708
typedef struct tagCDB_QUAD_SEQ { /* 229/LC  location of sectional results in master */
int     m_nr;                    /*        negative beam number */
float   m_x;                     /* [1001] section along beam */
} typeCDB_QUAD_SEQ;

#define QUAD_SER_VER 200708
typedef struct tagCDB_QUAD_SER { /* 229/LC  stresses of sectional Quad-elements */
int     m_nr;                    /*        Elementnumber */
float   m_sigx;                  /* [1092] normalstress */
float   m_sigy;                  /* [1092] transverse stress */
float   m_sigz;                  /* [1092] transverse stress */
float   m_tauxy;                 /* [1092] shear stress */
float   m_tauxz;                 /* [1092] shear stress */
float   m_tauyz;                 /* [1092] shear stress */
} typeCDB_QUAD_SER;

#define QUAD_RT0_ID 0
#define QUAD_RT0_VER 200501
typedef struct tagCDB_QUAD_RT0 { /* 230/LC  maximum of tendon stresses */
int     m_nr;                    /*        identifier 0 */
int     m_nrs;                   /*        identifier 0 */
float   m_sigz;                  /* [1092] stress increment */
float   m_zz;                    /* [1101] force in tendon */
float   m_zh;                    /* [1101] duct deduction force */
float   m_szg1;                  /* [1092] stress in G-point 1 */
float   m_szg2;                  /* [1092] stress in G-point 2 */
float   m_zzx1;                  /* [1101] force tendon+cement1 */
float   m_zzx2;                  /* [1101] force tendon+cement1 */
float   m_zhg1;                  /* [1101] duct deduction G1 */
float   m_zhg2;                  /* [1101] duct deduction G2 */
float   m_zzg1;                  /* [1101] force in tendon G1 */
float   m_zzg2;                  /* [1101] force in tendon G2 */
float   m_age;                   /* [  93] age since prestress */
float   m_relz;                  /*        accumulated relaxation */
float   m_tzg1;                  /* [1215] temperature tendon G1 */
float   m_tzg2;                  /* [1215] temperature tendon G2 */
float   m_thg1;                  /* [1215] temperature tendon duct G1 */
float   m_thg2;                  /* [1215] temperature tendon duct G2 */
} typeCDB_QUAD_RT0;

#define QUAD_RTS_VER 200501
typedef struct tagCDB_QUAD_RTS { /* 230/LC  tendon stresses in two integration points */
int     m_nr;                    /*        elementnumber */
int     m_nrs;                   /*        tendonnumber */
float   m_sigz;                  /* [1092] stress increment */
float   m_zz;                    /* [1101] force in tendon */
float   m_zh;                    /* [1101] duct deduction force */
float   m_szg1;                  /* [1092] stress in G-point 1 */
float   m_szg2;                  /* [1092] stress in G-point 2 */
float   m_zzx1;                  /* [1101] force tendon+cement1 */
float   m_zzx2;                  /* [1101] force tendon+cement1 */
float   m_zhg1;                  /* [1101] duct deduction G1 */
float   m_zhg2;                  /* [1101] duct deduction G2 */
float   m_zzg1;                  /* [1101] force in tendon G1 */
float   m_zzg2;                  /* [1101] force in tendon G2 */
float   m_age;                   /* [  93] age since prestress */
float   m_relz;                  /*        accumulated relaxation */
float   m_tzg1;                  /* [1215] temperature tendon G1 */
float   m_tzg2;                  /* [1215] temperature tendon G2 */
float   m_thg1;                  /* [1215] temperature tendon duct G1 */
float   m_thg2;                  /* [1215] temperature tendon duct G2 */
} typeCDB_QUAD_RTS;

#define QUAD_DST_VER 200501
typedef struct tagCDB_QUAD_DST { /* 250/DC  design stresses in Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_smio;                  /* [1092] minimum upside main stress */
float   m_smao;                  /* [1092] maximum upside main stress */
float   m_smiu;                  /* [1092] minimum downside main stress */
float   m_smau;                  /* [1092] maximum downside main stress */
float   m_taum;                  /* [1092] maximum shear stress */
float   m_svma;                  /* [1092] maximum reference stress */
float   m_svo;                   /* [1092] maximum reference stress upside */
float   m_svu;                   /* [1092] maximum reference stress downside */
float   m_reserved[7];           /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define QUAD_DST_TEXT_LEN 32
} typeCDB_QUAD_DST;

#define QUAD_NDS_VER 200501
typedef struct tagCDB_QUAD_NDS { /* 251/DC  design stresses in Quad-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_smio;                  /* [1092] minimum upside main stress Minimale Hauptspannung oben */
float   m_smao;                  /* [1092] maximum upside main stress Maximale Hauptspannung oben */
float   m_smiu;                  /* [1092] minimum downside main stress Minimale Hauptspannung unten */
float   m_smau;                  /* [1092] maximum downside main stress Maximale Hauptspannung unten */
float   m_taum;                  /* [1092] maximum shear stress */
float   m_svma;                  /* [1092] maximum reference stress */
float   m_svo;                   /* [1092] maximum reference stress upside */
float   m_svu;                   /* [1092] maximum reference stress downside */
float   m_reserved[7];           /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of designcase */
#define QUAD_NDS_TEXT_LEN 32
} typeCDB_QUAD_NDS;

#define QUAD_RIC_ID 0
#define QUAD_RIC_VER 200501
typedef struct tagCDB_QUAD_RIC { /* 260/DC  maximum reinforcement in Quad-elements */
int     m_nr;                    /*        ident 0 */
float   m_aso;                   /* [1021] upside reinforcement (outside) */
float   m_asoq;                  /* [1021] upside cross reinforcement (middle) */
float   m_asu;                   /* [1021] downside reinforcement (outside) */
float   m_asuq;                  /* [1021] downside cross reinforcement (middle) */
float   m_asoi;                  /* [1021] upside third reinforcement (inside) */
float   m_asui;                  /* [1021] downside third reinforcement (inside) */
float   m_ass;                   /* [1022] stirrup cm2/m2 */
float   m_asse;                  /* [1020] stirrup cm2 */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_sixo;                  /* [1030] upside reinforcement quantity */
float   m_sixu;                  /* [1030] downside reinforcement quantity */
float   m_sixs;                  /* [1030] shear reinforcement quantity */
float   m_free0[3];              /*        not yet used */
float   m_zmin;                  /* [1001] minimum lever arm */
float   m_vedr;                  /*        max. VED/VRDMAX */
float   m_cott;                  /*        max. cot_theta */
float   m_ved;                   /*        max. VED */
float   m_vm;                    /* [1001] shift rule */
float   m_sdo[3];                /* [1092] upside stress range (outside) */
float   m_sdu[3];                /* [1092] downside stress range (inside) */
float   m_sdv;                   /* [1092] stirrup stress range */
float   m_sso[3];                /* [1092] maximum stell stress upside (outside) */
float   m_ssu[3];                /* [1092] maximum stell stress downside(inside) */
float   m_ssv;                   /* [1092] maximum stirrup stress (not yet used) */
float   m_sigbo;                 /* [1092] maximum concrete pressure upside (outside) */
float   m_sigbu;                 /* [1092] maximum concrete pressure downside(inside) */
float   m_shzmax;                /*        maximum skew principal tensile stress */
float   m_shzx;                  /*        max. skew principal tensile stress in local x */
float   m_shzy;                  /*        max. skew principal tensile stress in local y */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_asbend[6];             /* [1021] Info reinforcement bending design only */
float   m_asplus[6];             /* [1021] Info reinforcement if increased due to shear */
float   m_asposs[6];             /* [1021] Info reinforcement to satisfy shear without stirrups */
float   m_bmom[6];               /* [1114] Design bending moment in direction of reinforcement */
float   m_origin[7];             /*        bitpattern of origins of maximum reinforcements */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons */
float   m_wk6[6];                /* [1026] crack width  reinforcement */
float   m_reserved[4];           /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of designcase */
#define QUAD_RIC_TEXT_LEN 32
} typeCDB_QUAD_RIC;

#define QUAD_REI_VER 200501
typedef struct tagCDB_QUAD_REI { /* 260/DC  reinforcement in Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_aso;                   /* [1021] upside reinforcement (outside) */
float   m_asoq;                  /* [1021] upside cross reinforcement (middle) */
float   m_asu;                   /* [1021] downside reinforcement (outside) */
float   m_asuq;                  /* [1021] downside cross reinforcement (middle) */
float   m_asoi;                  /* [1021] upside third reinforcement (inside) */
float   m_asui;                  /* [1021] downside third reinforcement (inside) */
float   m_ass;                   /* [1022] stirrup cm2/m2 */
float   m_asse;                  /* [1020] stirrup cm2 */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_rio;                   /*        direction of upside reinforcement */
float   m_rioq;                  /*        direction of upside cross reinforcement */
float   m_riu;                   /*        direction of downside reinforcement */
float   m_riuq;                  /*        direction of downside cross reinforcement */
float   m_rioi;                  /*        direction of upside third reinforcement */
float   m_riui;                  /*        direction of downside third reinforcement */
float   m_zmin;                  /* [1001] minimum lever arm (ULS design) */
float   m_vedr;                  /*        max. VED/VRDMAX (ULS design) */
float   m_cott;                  /*        max. cot_theta (ULS design) */
float   m_ved;                   /*        max. VED (ULS design) */
float   m_vm;                    /* [1001] shift rule */
float   m_sdo[3];                /* [1092] upside stress range (outside) */
float   m_sdu[3];                /* [1092] downside stress range (inside) */
float   m_sdv;                   /* [1092] stirrup stress range */
float   m_sso[3];                /* [1092] maximum stell stress upside (outside) */
float   m_ssu[3];                /* [1092] maximum stell stress downside(inside) */
float   m_ssv;                   /* [1092] maximum stirrup stress (not yet used) */
float   m_sigbo;                 /* [1092] maximum concrete pressure upside (outside) */
float   m_sigbu;                 /* [1092] maximum concrete pressure downside(inside) */
float   m_shzmax;                /*        maximum skew principal tensile stress (SLS uncracked) */
float   m_shzx;                  /*        max. skew principal tensile stress in local x */
float   m_shzy;                  /*        max. skew principal tensile stress in local y */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_asbend[6];             /* [1021] Info reinforcement bending design only (ULS design) */
float   m_asplus[6];             /* [1021] Info reinforcement if increased due to shear (ULS design) */
float   m_asposs[6];             /* [1021] Info reinforcement to satisfy shear without stirrups (ULS) */
float   m_bmom[6];               /* [1114] Design bending moment in direction of reinforcement */
float   m_origin[7];             /*        origin of maximum reinforcement: */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons */
float   m_wk6[6];                /* [1026] crack width  reinforcement */
} typeCDB_QUAD_REI;

#define QUAD_NRC_ID 0
#define QUAD_NRC_VER 200501
typedef struct tagCDB_QUAD_NRC { /* 261/DC  maximum reinforcement in Quad-nodes */
int     m_nr;                    /*        ident 0 */
int     m_ng;                    /*        ident 0 */
float   m_aso;                   /* [1021] upside reinforcement (outside) */
float   m_asoq;                  /* [1021] upside cross reinforcement (middle) */
float   m_asu;                   /* [1021] downside reinforcement (outside) */
float   m_asuq;                  /* [1021] downside cross reinforcement (middle) */
float   m_asoi;                  /* [1021] upside third reinforcement (inside) */
float   m_asui;                  /* [1021] downside third reinforcement (inside) */
float   m_ass;                   /* [1022] stirrup cm2/m2 */
float   m_i_8;                   /*        reserved 0.0 */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_free0[6];              /*        not yet used */
float   m_zmin;                  /* [1001] minimum lever arm */
float   m_vedr;                  /*        max. VED/VRDMAX */
float   m_cott;                  /*        max. cot_theta */
float   m_ved;                   /*        max. VED */
float   m_vm;                    /* [1001] shift rule */
float   m_sdo[3];                /* [1092] upside stress range (outside) */
float   m_sdu[3];                /* [1092] downside stress range (inside) */
float   m_sdv;                   /* [1092] stirrup stress range */
float   m_sso[3];                /* [1092] maximum stell stress upside (outside) */
float   m_ssu[3];                /* [1092] maximum stell stress downside(inside) */
float   m_ssv;                   /* [1092] maximum stirrup stress (not yet used) */
float   m_sigbo;                 /* [1092] maximum concrete pressure upside (outside) */
float   m_sigbu;                 /* [1092] maximum concrete pressure downside(inside) */
float   m_shzmax;                /*        maximum skew principal tensile stress */
float   m_shzx;                  /*        max. skew principal tensile stress in local x */
float   m_shzy;                  /*        max. skew principal tensile stress in local y */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_asbend[6];             /* [1021] Info reinforcement bending design only */
float   m_asplus[6];             /* [1021] Info reinforcement if increased due to shear */
float   m_asposs[6];             /* [1021] Info reinforcement to satisfy shear without stirrups */
float   m_bmom[6];               /* [1114] Design bending moment in direction of reinforcement */
float   m_origin[7];             /*        bitpattern of origins of maximum reinforcements */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons */
float   m_wk6[6];                /* [1026] crack width  reinforcement */
float   m_reserved[4];           /*        reserved for future usage */
pckcode m_text[17];              /*        Designation of Designcase */
#define QUAD_NRC_TEXT_LEN 32
} typeCDB_QUAD_NRC;

#define QUAD_NRI_VER 200501
typedef struct tagCDB_QUAD_NRI { /* 261/DC  reinforcement in Quad-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_aso;                   /* [1021] upside reinforcement (outside) */
float   m_asoq;                  /* [1021] upside cross reinforcement (middle) */
float   m_asu;                   /* [1021] downside reinforcement (outside) */
float   m_asuq;                  /* [1021] downside cross reinforcement (middle) */
float   m_asoi;                  /* [1021] upside third reinforcement (inside) */
float   m_asui;                  /* [1021] downside third reinforcement (inside) */
float   m_ass;                   /* [1022] stirrup cm2/m2 */
float   m_i_8;                   /*        reserved 0.0 */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_rio;                   /*        direction of upside reinforcement */
float   m_rioq;                  /*        direction of upside cross reinforcement */
float   m_riu;                   /*        direction of downside reinforcement */
float   m_riuq;                  /*        direction of downside cross reinforcement */
float   m_rioi;                  /*        direction of upside third reinforcement */
float   m_riui;                  /*        direction of downside third reinforcement */
float   m_zmin;                  /* [1001] minimum lever arm */
float   m_vedr;                  /*        max. VED/VRDMAX */
float   m_cott;                  /*        max. cot_theta */
float   m_ved;                   /*        max. VED */
float   m_vm;                    /* [1001] shift rule */
float   m_sdo[3];                /* [1092] upside stress range (outside) */
float   m_sdu[3];                /* [1092] downside stress range (inside) */
float   m_sdv;                   /* [1092] stirrup stress range */
float   m_sso[3];                /* [1092] maximum stell stress upside (outside) */
float   m_ssu[3];                /* [1092] maximum stell stress downside(inside) */
float   m_ssv;                   /* [1092] maximum stirrup stress (not yet used) */
float   m_sigbo;                 /* [1092] maximum concrete pressure upside (outside) */
float   m_sigbu;                 /* [1092] maximum concrete pressure downside(inside) */
float   m_shzmax;                /*        maximum skew principal tensile stress */
float   m_shzx;                  /*        max. skew principal tensile stress in local x */
float   m_shzy;                  /*        max. skew principal tensile stress in local y */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_asbend[6];             /* [1021] Info reinforcement bending design only */
float   m_asplus[6];             /* [1021] Info reinforcement if increased due to shear */
float   m_asposs[6];             /* [1021] Info reinforcement to satisfy shear without stirrups */
float   m_bmom[6];               /* [1114] Design bending moment in direction of reinforcement */
float   m_origin[7];             /*        origin of maximum reinforcement */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons */
float   m_wk6[6];                /* [1026] crack width  reinforcement */
} typeCDB_QUAD_NRI;

#define QUAD_NRP_VER 200501
typedef struct tagCDB_QUAD_NRP { /* 262/DC  punching reinforcement in nodes */
int     m_nr;                    /*        nodenumber */
int     m_ista;                  /*        state of force */
int     m_idus;                  /*        punching state */
float   m_u0;                    /* [1001] effective length of first perimeter */
float   m_redo;                  /*        reduction factor for openings/free edges */
float   m_v;                     /* [1151] punching force */
float   m_asl;                   /* [1020] required longitudinal reinforcement */
float   m_asv1;                  /* [1022] shear reinforcement within 1st perimeter */
float   m_asv2;                  /* [1022] shear reinforcement within 2nd perimeter */
float   m_asv3;                  /* [1022] shear reinforcement within 3rd perimeter */
float   m_asv4;                  /* [1022] shear reinforcement within 4th perimeter */
float   m_free0[5];              /*        not yet used */
pckcode m_txt1[16];              /*        Halfen Description 1 (30 chars require n/2+1 words) */
#define QUAD_NRP_TXT1_LEN 30
pckcode m_txt2[16];              /*        Halfen Description 2 */
#define QUAD_NRP_TXT2_LEN 30
pckcode m_txt3[16];              /*        Halfen Description 3 */
#define QUAD_NRP_TXT3_LEN 30
} typeCDB_QUAD_NRP;

#define QUAD_PUN_ID 0
#define QUAD_PUN_VER 200501
typedef struct tagCDB_QUAD_PUN { /* 262/DC  punching periphery */
int     m_nr;                    /*        identifier 0 */
int     m_id;                    /*        identifier 0 */
int     m_typ;                   /*        type of line */
float   m_x1;                    /* [1001] Coordinates of start point */
float   m_y1;                    /* [1001]  */
float   m_z1;                    /* [1001]  */
float   m_x2;                    /* [1001] Coordinates of end point */
float   m_y2;                    /* [1001]  */
float   m_z2;                    /* [1001]  */
} typeCDB_QUAD_PUN;

#define QUAD_PU1_ID 0
#define QUAD_PU1_VER 200501
typedef struct tagCDB_QUAD_PU1 { /* 262/DC  punching parameters */
int     m_nr;                    /*        identifier 0 */
int     m_id;                    /*        identifier 1 */
int     m_kdust[199];            /*        Integer-punching parameters */
float   m_rdust[299];            /*        Real-punching parameters */
} typeCDB_QUAD_PU1;

#define QUAD_RD0_ID 0
#define QUAD_RD0_VER 200501
typedef struct tagCDB_QUAD_RD0 { /* 265/DC  maximum of tendon stresses in the design */
int     m_nr;                    /*        identifier 0 */
int     m_nrs;                   /*        identifier 0 */
float   m_smax;                  /* [1092] maximum design stress */
float   m_smin;                  /* [1092] minimum design stress */
float   m_perm;                  /* [1092] permanent stress */
} typeCDB_QUAD_RD0;

#define QUAD_RTD_VER 200501
typedef struct tagCDB_QUAD_RTD { /* 265/DC  tendon stress in the design */
int     m_nr;                    /*        elementnumber */
int     m_nrs;                   /*        tendonnumber */
float   m_smax;                  /* [1092] maximum design stress */
float   m_smin;                  /* [1092] minimum design stress */
float   m_perm;                  /* [1092] permanent stress */
} typeCDB_QUAD_RTD;

#define QUAD_REE_ID 0
#define QUAD_REE_VER 201603
typedef struct tagCDB_QUAD_REE { /* 270/DC  maximum design values in Quad-elements */
int     m_ng;                    /*        ident 0 */
int     m_nr;                    /*        ident 0 */
int     m_id;                    /*        activated layers: -(nupper +100*nlower +10000*ncentric) */
int     m_orig;                  /*        origin - error messages: */
float   m_sigc[2];               /* [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+) */
float   m_sigcd[2];              /* [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+) */
float   m_shz[3];                /* [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked) */
float   m_sigs[3];               /* [1092] maximum SLS reinforcement stress for center/upside/downside */
float   m_sigsd[3];              /* [1092] maximum SLS reinforcement stress range for center/upside/downsi */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons upside/downsid */
float   m_zmin;                  /* [1001] minimum lever arm (ULS design) */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_ass;                   /* [1022] stirrup reinforcement ratio */
float   m_vedr;                  /*        max. VED/VRDMAX (ULS design) */
float   m_cott;                  /*        max. cot_theta (ULS design) */
float   m_ved;                   /*        max. VED (ULS design) */
float   m_vm;                    /* [1001] shift rule */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_opt[15];               /*        reserved */
float   m_sumo;                  /* [1030] upside reinforcement quantity */
float   m_sumu;                  /* [1030] downside reinforcement quantity */
float   m_summ;                  /* [1030] centric reinforcement quantity */
float   m_sums;                  /* [1030] shear reinforcement quantity */
pckcode m_text[17];              /*        Designation of designcase */
#define QUAD_REE_TEXT_LEN 32
} typeCDB_QUAD_REE;

#define QUAD_RNE_ID 0
#define QUAD_RNE_VER 201603
typedef struct tagCDB_QUAD_RNE { /* 271/DC  maximum design values in Nodes of Quad-elements */
int     m_ng;                    /*        ident 0 */
int     m_nr;                    /*        ident 0 */
int     m_id;                    /*        activated layers: -(nupper +100*nlower +10000*ncentric) */
int     m_orig;                  /*        origin - error messages: */
float   m_sigc[2];               /* [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+) */
float   m_sigcd[2];              /* [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+) */
float   m_shz[3];                /* [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked) */
float   m_sigs[3];               /* [1092] maximum SLS reinforcement stress for center/upside/downside */
float   m_sigsd[3];              /* [1092] maximum SLS reinforcement stress range for center/upside/downsi */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons upside/downsid */
float   m_zmin;                  /* [1001] minimum lever arm (ULS design) */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_ass;                   /* [1022] stirrup reinforcement ratio */
float   m_vedr;                  /*        max. VED/VRDMAX (ULS design) */
float   m_cott;                  /*        max. cot_theta (ULS design) */
float   m_ved;                   /*        max. VED (ULS design) */
float   m_vm;                    /* [1001] shift rule */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
float   m_opt[15];               /*        reserved */
float   m_sumo;                  /* [1030] upside reinforcement quantity */
float   m_sumu;                  /* [1030] downside reinforcement quantity */
float   m_summ;                  /* [1030] centric reinforcement quantity */
float   m_sums;                  /* [1030] shear reinforcement quantity */
pckcode m_text[17];              /*        Designation of designcase */
#define QUAD_RNE_TEXT_LEN 32
} typeCDB_QUAD_RNE;

#define QUAD_REM_ID 0
#define QUAD_REM_VER 201603
typedef struct tagCDB_QUAD_REM { /* 270/DC  maximum reinforcement results in Quad-elements */
int     m_ng;                    /*        ident 0 */
int     m_nr;                    /*        ident 0 */
int     m_id;                    /*        +1 identifier for reincorcement */
int     m_orig;                  /*        origin of maximum reinforcement, see QUAD_REA for Details */
float   m_aso;                   /* [1021] reinforcement area */
float   m_sdo[3];                /* [1092] reinforcement stress SLS */
float   m_asbend;                /* [1021] Info reinforcement bending design only (ULS design) */
float   m_asplus;                /* [1021] Info reinforcement if increased due to shear (ULS design) */
float   m_asposs;                /* [1021] Info reinforcement to satisfy shear without stirrups (ULS) */
float   m_bmom;                  /* [1114] Design bending moment in direction of reinforcement */
float   m_wk;                    /* [1026] crack width */
} typeCDB_QUAD_REM;

#define QUAD_REA_VER 201603
typedef struct tagCDB_QUAD_REA { /* 270/DC  General Concrete Design Results */
int     m_ng;                    /*        group number (for nodal results) */
int     m_nr;                    /*        element number */
int     m_id;                    /*        ident 0 : concrete results */
int     m_orig;                  /*        origin of maximum reinforcement: */
float   m_sigo[3];               /* [1092] stress of concrete pressure upside (Z-) */
float   m_sigu[3];               /* [1092] stress of concrete pressure downside (Z+) */
float   m_shzmax;                /*        maximum skew principal tensile stress (SLS uncracked) */
float   m_shzx;                  /*        max. skew principal tensile stress in local x */
float   m_shzy;                  /*        max. skew principal tensile stress in local y */
float   m_zmin;                  /* [1001] minimum lever arm (ULS design) */
float   m_deco[2];               /* [   9] decompression strain in the direction of tendons */
float   m_sumo;                  /* [1021] upside reinforcement quantity */
float   m_sumu;                  /* [1021] downside reinforcement quantity */
float   m_summ;                  /* [1021] shear reinforcement quantity */
float   m_tau0;                  /* [1092] design shear stress (shear force) */
float   m_ass;                   /* [1022] stirrup reinforcement ratio */
float   m_vedr;                  /*        max. VED/VRDMAX (ULS design) */
float   m_cott;                  /*        max. cot_theta (ULS design) */
float   m_ved;                   /*        max. VED (ULS design) */
float   m_vm;                    /* [1001] shift rule */
float   m_utilc;                 /*        max. utilization fatigue check concrete */
} typeCDB_QUAD_REA;

#define QUAD_RER_VER 201603
typedef struct tagCDB_QUAD_RER { /* 270/DC  Reinforcement Layer Design Results */
int     m_ng;                    /*        group number (for nodal results) */
int     m_nr;                    /*        element number */
int     m_id;                    /*        identifier of reincorcement layer */
int     m_orig;                  /*        origin of maximum reinforcement, see QUAD_REA for Details */
float   m_aso;                   /* [1021] reinforcement area */
float   m_sdo[3];                /* [1092] reinforcement stress SLS */
float   m_asbend;                /* [1021] Info reinforcement bending design only (ULS design) */
float   m_asplus;                /* [1021] Info reinforcement if increased due to shear (ULS design) */
float   m_asposs;                /* [1021] Info reinforcement to satisfy shear without stirrups (ULS) */
float   m_bmom;                  /* [1114] Design bending moment in direction of reinforcement */
float   m_wk;                    /* [1026] crack width */
} typeCDB_QUAD_RER;

#define QUAD_CFD_VER 201108
typedef struct tagCDB_QUAD_CFD { /* 290/LC  Fluid flow results in Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_vx;                    /* [1212] velocity */
float   m_vy;                    /* [1212] velocity */
float   m_vz;                    /* [1212] velocity */
float   m_q;                     /* [1211] stream quantity */
float   m_hopt;                  /* [1001] Boundary layer */
float   m_vxa;                   /* [1212] particle velocity */
float   m_vya;                   /* [1212] particle velocity */
float   m_vza;                   /* [1212] particle velocity */
float   m_mued;                  /* [1220] laminar viscosity */
float   m_dux[2];                /* [  95] gradient values of fluid flow du/dx, du/dy */
float   m_dvx[2];                /* [  95] gradient values of fluid flow dv/dx, dv/dy */
float   m_tk;                    /* [1222] turbulent energy */
float   m_muet;                  /* [1220] turbulent viscosity */
float   m_ed;                    /* [1223] dissipation rate */
float   m_scalar[4];             /*        optional scalar values */
} typeCDB_QUAD_CFD;

#define QUAD_TM_ID 0
#define QUAD_TM_VER 200501
typedef struct tagCDB_QUAD_TM {  /* 291/LC  Maximum of Temperature Results in Quads */
int     m_nr;                    /*        elementnumber */
float   m_qx;                    /* [1218] heat flux */
float   m_qy;                    /* [1218] heat flux */
float   m_qz;                    /* [1218] heat flux */
float   m_q;                     /* [1216] Total flux */
float   m_hopt;                  /* [1001] optimal mesh size */
float   m_teff;                  /* [  92] Effective Age */
float   m_hydr;                  /*        Hydration degree */
float   m_lfr;                   /*        Liquid fraction */
} typeCDB_QUAD_TM;

#define QUAD_TMP_VER 200501
typedef struct tagCDB_QUAD_TMP { /* 291/LC  Temperature Results in Quad-elements */
int     m_nr;                    /*        elementnumber */
float   m_qx;                    /* [1218] heat flux */
float   m_qy;                    /* [1218] heat flux */
float   m_qz;                    /* [1218] heat flux */
float   m_q;                     /* [1216] Total flux */
float   m_hopt;                  /* [1001] optimal mesh size */
float   m_teff[5];               /* [  92] Effective Age */
float   m_hydr[5];               /*        Hydratation degree */
float   m_lfr[5];                /*        Liquid fraction */
} typeCDB_QUAD_TMP;

#define BRIC_VER 200501
typedef struct tagCDB_BRIC {     /* 300/00  Bric-elements */
int     m_nr;                    /*        elementnumber */
int     m_node[8];               /*        nodenumbers */
int     m_mat;                   /*        materialnumber */
int     m_nra;                   /*        type of element */
float   m_det[4];                /*        Values of Jacobian Determinant / Volume */
} typeCDB_BRIC;

#define BRIC_SU_ID 0
#define BRIC_SU_VER 200502
typedef struct tagCDB_BRIC_SU {  /* 300/02  Surfaces and Neighbours of Bric-elements */
int     m_n0[4];
int     m_nsur;
int     m_mbri;                  /*        max number of brics per surface */
} typeCDB_BRIC_SU;

#define BRIC_SUR_VER 200502
typedef struct tagCDB_BRIC_SUR { /* 300/02  Surfaces and Neighbours of Bric-elements */
int     m_node[4];
int     m_ijmp;
int     m_nbri;
int     m_nrel[7];               /*        bric numbers for this surface */
} typeCDB_BRIC_SUR;

#define BRIC_RIM_VER 200904
typedef struct tagCDB_BRIC_RIM { /* 300/6  Prescribed Reinforcements of Bric-elements */
int     m_nrg;                   /*        group number */
int     m_nr;                    /*        selector number */
int     m_typ;                   /*        Type of Reinforc. */
int     m_gtyp;                  /*        Type of grading */
int     m_idra;                  /*        drawing source type */
float   m_oal;                   /*        Euler Angle I reinforcement */
float   m_oaf;                   /*        Euler Angle II */
float   m_xref;                  /* [1001] Reference point for circular reinforcement */
float   m_yref;                  /* [1001] XREF+YREF allowed in combination with OAL and OAF */
float   m_zref;                  /* [1001] ZREF<>RW only allowed for OAL=OAF=0 */
float   m_di[3];                 /* [1023] Diameter of reinforcement 1-3 */
float   m_as[3];                 /* [1022] Minimum reinforcement 1-3 */
float   m_am[3];                 /* [1022] Maximum reinforcement 1-3 */
float   m_wk[3];                 /* [1026] design crack width */
float   m_sig[3];                /* [1092] SLS steel stress limit */
} typeCDB_BRIC_RIM;

#define BRIC_P_VER 200501
typedef struct tagCDB_BRIC_P {   /* 300/10  Bric-P-Elements */
int     m_nr;                    /*        elementnumber */
int     m_node[8];               /*        nodenumbers */
int     m_mat;                   /*        materialnumber */
int     m_edge[12];              /*        geometric id of edge 1-2 */
int     m_face[6];               /*        geometric id of face 1-2-3-4 */
} typeCDB_BRIC_P;

#define BRIC_LOA_VER 200501
typedef struct tagCDB_BRIC_LOA { /* 302/LC  loads of Bric-elements */
int     m_von;                   /*        start elementnumber */
int     m_bis;                   /*        end elementnumber */
int     m_del;                   /*        increment */
int     m_typ;                   /*        type of load */
int     m_lnr;                   /*        primary loadcasenumber,if TYP = 18/30 */
float   m_p;                     /*        load value */
float   m_dpdx;
float   m_dpdy;
float   m_dpdz;
float   m_xref;                  /* [1001] optional reference point for load value */
float   m_yref;                  /* [1001]  */
float   m_zref;                  /* [1001]  */
} typeCDB_BRIC_LOA;

#define BRIC_STC_ID 0
#define BRIC_STC_VER 200501
typedef struct tagCDB_BRIC_STC { /* 310/LC  maximum stress in BRICs */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
float   m_hp1;                   /*        yield function */
float   m_hp2;                   /*        volum. hardening */
} typeCDB_BRIC_STC;

#define BRIC_STR_VER 200501
typedef struct tagCDB_BRIC_STR { /* 310/LC  3D-stresses in Bric-elements */
int     m_nr;                    /*        elementnumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
struct {
float   m_sigx;                  /* [1092]  */
float   m_sigy;                  /* [1092]  */
float   m_sigz;                  /* [1092]  */
float   m_tvxy;                  /* [1092]  */
float   m_tvxz;                  /* [1092]  */
float   m_tvyz;                  /* [1092]  */
      } m_sg[8];                 /*        results in GAUSS-points */
float   m_hp1[9];                /*        yield function */
float   m_hp2[9];                /*        2nd parameter as specified in headder record */
float   m_hp3[9];                /*        3rd parameter as specified in headder record */
float   m_hp4[9];                /*        4th parameter as specified in headder record */
float   m_hp5[9];                /*        5th parameter as specified in headder record */
float   m_hp6[9];                /*        6th parameter as specified in headder record */
float   m_hp7[9];                /*        7th parameter as specified in headder record */
float   m_hp8[9];                /*        8th parameter as specified in headder record */
float   m_hp9[9];                /*        9th parameter as specified in headder record */
float   m_hp10[9];               /*        10th parameter as specified in headder record */
float   m_hp11[9];               /*        11th parameter as specified in headder record */
float   m_hp12[9];               /*        12th parameter as specified in headder record */
float   m_hp13[9];               /*        13th parameter as specified in headder record */
float   m_hp14[9];               /*        14th parameter as specified in headder record */
float   m_hp15[9];               /*        15th parameter as specified in headder record */
} typeCDB_BRIC_STR;

#define BRIC_NSC_ID 0
#define BRIC_NSC_VER 200501
typedef struct tagCDB_BRIC_NSC { /* 311/LC  maximum nodal 3D stress */
int     m_ng;                    /*        ident 0 for maximum (first records) */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
} typeCDB_BRIC_NSC;

#define BRIC_NST_VER 200501
typedef struct tagCDB_BRIC_NST { /* 311/LC  3D-stresses in Bric-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
float   m_fy;                    /*        yield function */
} typeCDB_BRIC_NST;

#define BRIC_ESC_ID 0
#define BRIC_ESC_VER 200501
typedef struct tagCDB_BRIC_ESC { /* 312/LC  max. errors of Bric-stresses */
int     m_nr;                    /*        ident 0 for maximum (first records) */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
} typeCDB_BRIC_ESC;

#define BRIC_EST_VER 200501
typedef struct tagCDB_BRIC_EST { /* 312/LC  3D-error estimates in Bric-Elements */
int     m_nr;                    /*        elementnumber */
float   m_sigx;                  /* [1092] stress */
float   m_sigy;                  /* [1092] stress */
float   m_sigz;                  /* [1092] stress */
float   m_tvxy;                  /* [1092] shear stress */
float   m_tvxz;                  /* [1092] shear stress */
float   m_tvyz;                  /* [1092] shear stress */
} typeCDB_BRIC_EST;

#define BRIC_REI_VER 200904
typedef struct tagCDB_BRIC_REI { /* 360/DC  reinforcement in Bric-elements */
int     m_nr;                    /*        elementnumber */
float   m_as[3];                 /* [1022] reinforcement 1-3 */
float   m_oal;                   /*        Euler Angle I */
float   m_oaf;                   /*        Euler Angle II */
float   m_sd[3];                 /* [1092] stress range 1-3 */
float   m_sigb;                  /* [1092] maximum concrete pressure */
float   m_shzmax;                /*        maximum skew principal tensile stress (SLS uncracked) */
float   m_origin[3];             /*        origin of maximum reinforcement: as defined in 260/DC */
} typeCDB_BRIC_REI;

#define BRIC_NRI_VER 200904
typedef struct tagCDB_BRIC_NRI { /* 361/DC  reinforcement in Bric-nodes */
int     m_ng;                    /*        groupnumber */
int     m_nr;                    /*        nodenumber */
float   m_as[3];                 /* [1022] reinforcement 1-3 */
float   m_oal;                   /*        Euler Angle I */
float   m_oaf;                   /*        Euler Angle II */
float   m_sd[3];                 /* [1092] stress range 1-3 */
float   m_sigb;                  /* [1092] maximum concrete pressure */
float   m_shzmax;                /*        maximum skew principal tensile stress (SLS uncracked) */
float   m_origin[3];             /*        origin of maximum reinforcement: as defined in 260/DC */
} typeCDB_BRIC_NRI;

#define BRIC_CFD_VER 201108
typedef struct tagCDB_BRIC_CFD { /* 390/LC  Fluid flow results in BRIC-elements */
int     m_nr;                    /*        elementnumber */
float   m_vx;                    /* [1212] velocity */
float   m_vy;                    /* [1212] velocity */
float   m_vz;                    /* [1212] velocity */
float   m_q;                     /* [1211] stream quantity */
float   m_hopt;                  /* [1001] optimal mesh size */
float   m_vxa;                   /* [1212] particle velocity */
float   m_vya;                   /* [1212] particle velocity */
float   m_vza;                   /* [1212] particle velocity */
float   m_mued;                  /* [1220] laminar viscosity */
float   m_dux[3];                /* [  95] gradient values fluid flow du/dx, du/dy, du/dz */
float   m_dvx[3];                /* [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz */
float   m_dwx[3];                /* [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz */
float   m_tk;                    /* [1222] turbulent energy */
float   m_muet;                  /* [1220] turbulent viscosity */
float   m_ed;                    /* [1223] dissipation rate */
float   m_scalar[4];             /*        optional scalar parameters */
} typeCDB_BRIC_CFD;

#define BRIC_TM_ID 0
#define BRIC_TM_VER 200501
typedef struct tagCDB_BRIC_TM {  /* 391/LC  Maximum Temperature Results in BRICs */
int     m_nr;                    /*        elementnumber */
float   m_qx;                    /* [1218] heat flux */
float   m_qy;                    /* [1218] heat flux */
float   m_qz;                    /* [1218] heat flux */
float   m_q;                     /* [1216] Total flux */
float   m_teff;                  /* [  92] Effective Age */
float   m_hydr;                  /*        Hydration degree */
float   m_lfr;                   /*        Liquid fraction */
} typeCDB_BRIC_TM;

#define BRIC_TMP_VER 200501
typedef struct tagCDB_BRIC_TMP { /* 391/LC  Temperature Results in BRIC-elements */
int     m_nr;                    /*        elementnumber */
float   m_qx;                    /* [1218] heat flux */
float   m_qy;                    /* [1218] heat flux */
float   m_qz;                    /* [1218] heat flux */
float   m_q;                     /* [1216] Total flux */
float   m_teff[9];               /* [  92] Effective Age */
float   m_hydr[9];               /*        Hydration degree */
float   m_lfr[9];                /*        Liquid fraction */
} typeCDB_BRIC_TMP;

#define HASE_PIH_ID 0
#define HASE_PIH_VER 0
typedef struct tagCDB_HASE_PIH { /* 404/NR  HASE-Piles in Half-space */
int     m_id;                    /*        Identification 0 */
int     m_npile;                 /*        Number of piles */
int     m_mpile;                 /*        Max. values per pile */
int     m_nhknot;                /*        Number of nodes */
} typeCDB_HASE_PIH;

#define HASE_PIL_VER 0
typedef struct tagCDB_HASE_PIL { /* 404/NR  HASE-Piles in Half-space */
int     m_enr;                   /*        External node number */
float   m_x;                     /* [1001] Pile X-coordinate */
float   m_y;                     /* [1001] Pile Y-coordinate */
float   m_df;                    /* [1001] Pile-foot diameter */
float   m_z;                     /* [1001] Pile-foot coordinate */
float   m_mant;                  /*        Fraction of the total pile load transfered as a pile */
float   m_pmam;                  /* [1190] Max. load transferable by skin friction */
int     m_inr;                   /*        Ixternal node number */
chr     m_bez[4];                /*        Designation */
float   m_pmaf;                  /* [1190] Max. load transferable trough pile-foot */
float   m_zman;                  /* [1001] Z-coordiante from which the skin friction is active */
float   m_cfac;                  /*        Factor of load applied as compression-only */
float   m_plen;                  /* [1001] Pile length */
float   m_plsf;                  /* [1001] Pile length part inactive for skin friction */
float   m_d0;                    /* [1001] Pile diameter */
float   m_mnr;                   /*        Pile material number */
} typeCDB_HASE_PIL;

#define Substruc_VER 0
typedef struct tagCDB_Substruc { /* 411/NR */
chr     m_id;                    /*        Identification of segment */
int     m_typ;                   /*        Type of segment */
int     m_bit;                   /*        Bitpattern idef+4*iref */
float   m_len;                   /* [1001] Length of segment */
float   m_alfa;                  /* [   5] Angle of start face to axis (0 = match-cast) */
float   m_alfr;                  /* [   5] Angle of end   face to axis (0 = match-cast) */
float   m_dspa;                  /* [1001] Distance of start survey point */
float   m_dspe;                  /* [1001] Distance of end survey point */
pckcode m_text[17];              /*        designation of segment */
#define Substruc_TEXT_LEN 32
} typeCDB_Substruc;

#define SEG_DEF_VER 200712
typedef struct tagCDB_SEG_DEF {  /* 900/00  Segmentdefinition */
chr     m_id;                    /*        Identification of segment */
int     m_typ;                   /*        Type of segment */
int     m_bit;                   /*        Bitpattern idef+4*iref */
float   m_len;                   /* [1001] Length of segment */
float   m_alfa;                  /* [   5] Angle of start face to axis (0 = match-cast) */
float   m_alfr;                  /* [   5] Angle of end   face to axis (0 = match-cast) */
float   m_dspa;                  /* [1001] Distance of start survey point */
float   m_dspe;                  /* [1001] Distance of end survey point */
pckcode m_text[17];              /*        designation of segment */
#define SEG_DEF_TEXT_LEN 32
} typeCDB_SEG_DEF;

#define IL_CTRL0_ID 0
#define IL_CTRL0_VER 201105
typedef struct tagCDB_IL_CTRL0 { /* -1/NS  Headder of a location */
int     m_id;                    /*        ID=0 */
int     m_kwerg;                 /*        KWH for results to be saved */
int     m_nerg;                  /*        Count on corresponding items */
int     m_nrel;                  /*        element number */
float   m_xabs;                  /* [1001] abszissae for beam sections */
pckcode m_txt[17];               /*        Name of location */
#define IL_CTRL0_TXT_LEN 32
} typeCDB_IL_CTRL0;

#define IL_CTRL1_VER 201105
typedef struct tagCDB_IL_CTRL1 { /* -1/NS  Headder of a result */
int     m_idi;                   /*        Type of result */
int     m_ierg;                  /*        index of this item + 1000*IMUNIT */
int     m_lfmax;                 /*        Offset for load case number of results for maximum */
int     m_lfmin;                 /*        Offset for load case number of results for minimum */
float   m_lphi;                  /* [1001] characteristic lenght for dynamic impact factor */
pckcode m_txt[17];               /*        Name of item */
#define IL_CTRL1_TXT_LEN 32
} typeCDB_IL_CTRL1;

#define IL_DATA0_VER 201105
typedef struct tagCDB_IL_DATA0 { /* -1/NS  Influence values (V23, obsoleted) */
int     m_idi;                   /*        Type of derivatives defined */
float   m_x;                     /* [1001] abszissae along lane */
float   m_pv;                    /*        Influence value for vertical loading (z) */
float   m_mt;                    /*        Influence value for torsional loading (x-x) */
float   m_pl;                    /*        Influence value for longitudinal loading (x) */
float   m_pt;                    /*        Influence value for transverse loading (y) */
float   m_dpv;                   /*        Derivative of PV/dx (if IDI&1000) */
float   m_dmt;                   /*        Derivative of MT/dx (if IDI&0100) */
float   m_dpl;                   /*        Derivative of PL/dx (if IDI&0010) */
float   m_dpt;                   /*        Derivative of PT/dx (if IDI&0001) */
} typeCDB_IL_DATA0;

#define IL_DATA_VER 201105
typedef struct tagCDB_IL_DATA {  /* -1/NS  Influence values */
int     m_idi;                   /*        Type of derivatives defined */
float   m_x;                     /* [1001] abszissae along lane */
float   m_pv;                    /*        Influence value for vertical loading (z) */
float   m_mt;                    /*        Influence value for torsional loading (x-x) */
float   m_pl;                    /*        Influence value for longitudinal loading (x) */
float   m_pt;                    /*        Influence value for transverse loading (y) */
float   m_ppos;                  /*        Influence value for vertical distributed loading */
float   m_pneg;                  /*        Influence value for vertical distributed loading */
float   m_dpv;                   /*        Derivative of PV/dx   (if IDI&100000) */
float   m_dmt;                   /*        Derivative of MT/dx   (if IDI&010000) */
float   m_dpl;                   /*        Derivative of PL/dx   (if IDI&001000) */
float   m_dpt;                   /*        Derivative of PT/dx   (if IDI&000100) */
float   m_dppos;                 /*        Derivative of PPOS/dx (if IDI&000010) */
float   m_dpneg;                 /*        Derivative of PNEG/dx (if IDI&000001) */
float   m_rres;                  /*        Influence value for right residual loading */
float   m_lres;                  /*        Influence value for left residual loading */
} typeCDB_IL_DATA;


#define IL_DATA_KWH -1
typedef union taguIL_DATA {   /* -1/NS */
int m_id;
typeCDB_IL_CTRL0 m_il_ctrl0;
typeCDB_IL_CTRL1 m_il_ctrl1;
typeCDB_IL_DATA0 m_il_data0;
typeCDB_IL_DATA m_il_data;
} typeuIL_DATA;


#define CTRL_010_KWH 0
#define CTRL_010_KWL 1
typedef union taguCTRL_010 {   /* 0/01 */
int m_id;
typeCDB_CTRL_010 m_ctrl_010;
typeCDB_CTRL_011 m_ctrl_011;
typeCDB_CTRL_OBJ m_ctrl_obj;
typeCDB_CTRL_OID m_ctrl_oid;
} typeuCTRL_010;


#define SSD_SPE_KWH 0
#define SSD_SPE_KWL 96
typedef union taguSSD_SPE {   /* 0/96 */
int m_id;
typeCDB_SSD_SPE m_ssd_spe;
} typeuSSD_SPE;


#define VIS_LC_KWH 0
#define VIS_LC_KWL 97
typedef union taguVIS_LC {   /* 0/97 */
int m_id;
typeCDB_VIS_LC0 m_vis_lc0;
typeCDB_VIS_LC m_vis_lc;
} typeuVIS_LC;


#define CTRL_KWH 0
#define CTRL_KWL 99
typedef union taguCTRL {   /* 0/99 */
int m_id;
typeCDB_CTRL m_ctrl;
typeCDB_CTRL_0 m_ctrl_0;
typeCDB_CTRL_1 m_ctrl_1;
} typeuCTRL;


#define CTRL_VAR_KWH 0
#define CTRL_VAR_KWL 100
typedef union taguCTRL_VAR {   /* 0/100 */
int m_id;
typeCDB_CTRL_VAR m_ctrl_var;
typeCDB_CTRL_VAP m_ctrl_vap;
} typeuCTRL_VAR;


#define CTRL_DIM_KWH 0
#define CTRL_DIM_KWL 101
typedef union taguCTRL_DIM {   /* 0/101 */
int m_id;
typeCDB_CTRL_DIM m_ctrl_dim;
} typeuCTRL_DIM;


#define SYST_KWH 10
#define SYST_KWL 0
typedef union taguSYST {   /* 10/00 */
int m_id;
typeCDB_SYST m_syst;
} typeuSYST;


#define SYST_DES_KWH 10
#define SYST_DES_KWL 1
typedef union taguSYST_DES {   /* 10/1 */
int m_id;
typeCDB_SYST_DES m_syst_des;
typeCDB_SYST_ACT m_syst_act;
typeCDB_SYST_COM m_syst_com;
} typeuSYST_DES;


#define GRP_KWH 11
#define GRP_KWL 0
typedef union taguGRP {   /* 11/00 */
int m_id;
typeCDB_GRP m_grp;
} typeuGRP;


#define GRP_LC_KWH 11
typedef union taguGRP_LC {   /* 11/LC */
int m_id;
typeCDB_GRP_LC m_grp_lc;
} typeuGRP_LC;


#define CSM_GRP_KWH 15
#define CSM_GRP_KWL -1
typedef union taguCSM_GRP {   /* 15/-1 */
int m_id;
typeCDB_CSM_GRP m_csm_grp;
} typeuCSM_GRP;


#define CSM_LC_KWH 15
#define CSM_LC_KWL -2
typedef union taguCSM_LC {   /* 15/-2 */
int m_id;
typeCDB_CSM_LC m_csm_lc;
} typeuCSM_LC;


#define CSM_CS_KWH 15
#define CSM_CS_KWL -3
typedef union taguCSM_CS {   /* 15/-3 */
int m_id;
typeCDB_CSM_CS m_csm_cs;
} typeuCSM_CS;


#define CSM_CREE_KWH 15
#define CSM_CREE_KWL -4
typedef union taguCSM_CREE {   /* 15/-4 */
int m_id;
typeCDB_CSM_CREE m_csm_cree;
} typeuCSM_CREE;


#define CSG_CS_KWH 15
#define CSG_CS_KWL -10
typedef union taguCSG_CS {   /* 15/-10 */
int m_id;
typeCDB_CSG_CS m_csg_cs;
} typeuCSG_CS;


#define CSG_CGRP_KWH 15
#define CSG_CGRP_KWL -11
typedef union taguCSG_CGRP {   /* 15/-11 */
int m_id;
typeCDB_CSG_CGRP m_csg_cgrp;
} typeuCSG_CGRP;


#define CSG_CLAS_KWH 15
#define CSG_CLAS_KWL -12
typedef union taguCSG_CLAS {   /* 15/-12 */
int m_id;
typeCDB_CSG_CLAS m_csg_clas;
} typeuCSG_CLAS;


#define CSG_CSYS_KWH 15
#define CSG_CSYS_KWL -13
typedef union taguCSG_CSYS {   /* 15/-13 */
int m_id;
typeCDB_CSG_CSYS m_csg_csys;
} typeuCSG_CSYS;


#define CSG_CCRL_KWH 15
#define CSG_CCRL_KWL -14
typedef union taguCSG_CCRL {   /* 15/-14 */
int m_id;
typeCDB_CSG_CCRL m_csg_ccrl;
} typeuCSG_CCRL;


#define CSG_CGW_KWH 15
#define CSG_CGW_KWL -15
typedef union taguCSG_CGW {   /* 15/-15 */
int m_id;
typeCDB_CSG_CGW m_csg_cgw;
} typeuCSG_CGW;


#define CSG_ECHO_KWH 15
#define CSG_ECHO_KWL -16
typedef union taguCSG_ECHO {   /* 15/-16 */
int m_id;
typeCDB_CSG_ECHO m_csg_echo;
} typeuCSG_ECHO;


#define CSM_LC1_KWH 15
typedef union taguCSM_LC1 {   /* 15/LC */
int m_id;
typeCDB_CSM_LC1 m_csm_lc1;
typeCDB_CSM_LC2 m_csm_lc2;
} typeuCSM_LC1;


#define VIEW_KWH 18
#define VIEW_KWL -1
typedef union taguVIEW {   /* 18/-1 */
int m_id;
typeCDB_VIEW m_view;
} typeuVIEW;


#define VIEW_SEL_KWH 18
#define VIEW_SEL_KWL -2
typedef union taguVIEW_SEL {   /* 18/-2 */
int m_id;
typeCDB_VIEW_SEL m_view_sel;
} typeuVIEW_SEL;


#define VIEW_SRE_KWH 18
#define VIEW_SRE_KWL -3
typedef union taguVIEW_SRE {   /* 18/-3 */
int m_id;
typeCDB_VIEW_SRE m_view_sre;
} typeuVIEW_SRE;


#define MTXT_0_KWH 18
#define MTXT_0_KWL -4
typedef union taguMTXT_0 {   /* 18/-4 */
int m_id;
typeCDB_MTXT_0 m_mtxt_0;
typeCDB_MTXT_NOD m_mtxt_nod;
typeCDB_MTXT_ELM m_mtxt_elm;
} typeuMTXT_0;


#define VIEW_MCO_KWH 18
#define VIEW_MCO_KWL -5
typedef union taguVIEW_MCO {   /* 18/-5 */
int m_id;
typeCDB_VIEW_MCO m_view_mco;
} typeuVIEW_MCO;


#define VIEW_GCO_KWH 18
#define VIEW_GCO_KWL -6
typedef union taguVIEW_GCO {   /* 18/-6 */
int m_id;
typeCDB_VIEW_GCO m_view_gco;
} typeuVIEW_GCO;


#define ANI_SELE_KWH 18
#define ANI_SELE_KWL -101
typedef union taguANI_SELE {   /* 18/-101 */
int m_id;
typeCDB_ANI_SELE m_ani_sele;
typeCDB_ANI_CTRL m_ani_ctrl;
} typeuANI_SELE;


#define ANI_SRES_KWH 18
#define ANI_SRES_KWL -103
typedef union taguANI_SRES {   /* 18/-103 */
int m_id;
typeCDB_ANI_SRES m_ani_sres;
} typeuANI_SRES;


#define LC_SELF_KWH 18
typedef union taguLC_SELF {   /* 18/LCD */
int m_id;
typeCDB_LC_SELF m_lc_self;
} typeuLC_SELF;


#define GRP_BIL_KWH 19
typedef union taguGRP_BIL {   /* 19/LC */
int m_id;
typeCDB_GRP_BIL m_grp_bil;
} typeuGRP_BIL;


#define NODE_KWH 20
#define NODE_KWL 0
typedef union taguNODE {   /* 20/00 */
int m_id;
typeCDB_NODE m_node;
} typeuNODE;


#define NODE_GRC_KWH 20
#define NODE_GRC_KWL 11
typedef union taguNODE_GRC {   /* 20/11 */
int m_id;
typeCDB_NODE_GRC m_node_grc;
typeCDB_NODE_GRP m_node_grp;
} typeuNODE_GRC;


#define NODE_KIC_KWH 21
#define NODE_KIC_KWL 0
typedef union taguNODE_KIC {   /* 21/00 */
int m_id;
typeCDB_NODE_KIC m_node_kic;
typeCDB_NODE_KIN m_node_kin;
typeCDB_NODE_KIG m_node_kig;
typeCDB_NODE_KIF m_node_kif;
} typeuNODE_KIC;


#define NODE_KIH_KWH 21
#define NODE_KIH_KWL 9
typedef union taguNODE_KIH {   /* 21/09 */
int m_id;
typeCDB_NODE_KIH m_node_kih;
} typeuNODE_KIH;


#define NODE_KFC_KWH 22
typedef union taguNODE_KFC {   /* 22/LC */
int m_id;
typeCDB_NODE_KFC m_node_kfc;
typeCDB_NODE_KFO m_node_kfo;
} typeuNODE_KFC;


#define NODE_L_KWH 23
typedef union taguNODE_L {   /* 23/LC */
int m_id;
typeCDB_NODE_L m_node_l;
typeCDB_NODE_LW m_node_lw;
typeCDB_NODE_ACC m_node_acc;
typeCDB_NODE_LA m_node_la;
typeCDB_NODE_ROT m_node_rot;
} typeuNODE_L;


#define N_DISP_KWH 24
typedef union taguN_DISP {   /* 24/LC */
int m_id;
typeCDB_N_DISPC m_n_dispc;
typeCDB_N_DISP m_n_disp;
} typeuN_DISP;


#define N_VELO_KWH 25
typedef union taguN_VELO {   /* 25/LC */
int m_id;
typeCDB_N_VELOC m_n_veloc;
typeCDB_N_VELO m_n_velo;
} typeuN_VELO;


#define N_DISPI_KWH 26
typedef union taguN_DISPI {   /* 26/LC */
int m_id;
typeCDB_N_DISPIC m_n_dispic;
typeCDB_N_DISPI m_n_dispi;
} typeuN_DISPI;


#define N_DISPT_KWH 27
typedef union taguN_DISPT {   /* 27/LC */
int m_id;
typeCDB_N_DISPTC m_n_disptc;
typeCDB_N_DISPT m_n_dispt;
} typeuN_DISPT;


#define SGRP_KWH 37
typedef union taguSGRP {   /* 37/ID */
int m_id;
typeCDB_SGRP m_sgrp;
typeCDB_SGRP_BOX m_sgrp_box;
typeCDB_SGRP_POL m_sgrp_pol;
typeCDB_SGRP_LIS m_sgrp_lis;
typeCDB_SGRP_ADD m_sgrp_add;
typeCDB_SGRP_SUB m_sgrp_sub;
typeCDB_SGRP_SEL m_sgrp_sel;
} typeuSGRP;


#define HIST_KWH 80
typedef union taguHIST {   /* 80/LC */
int m_id;
typeCDB_HIST_HED m_hist_hed;
typeCDB_HIST_PAR m_hist_par;
typeCDB_HIST m_hist;
typeCDB_HIST_VAL m_hist_val;
} typeuHIST;


#define SLVL_DAT_KWH 87
#define SLVL_DAT_KWL 0
typedef union taguSLVL_DAT {   /* 87/0 */
int m_id;
typeCDB_SLVL_DAT m_slvl_dat;
} typeuSLVL_DAT;


#define SLVL_RES_KWH 87
typedef union taguSLVL_RES {   /* 87/LC */
int m_id;
typeCDB_SLVL_RES m_slvl_res;
} typeuSLVL_RES;


#define BEAM_KWH 100
#define BEAM_KWL 0
typedef union taguBEAM {   /* 100/00 */
int m_id;
typeCDB_BEAM m_beam;
typeCDB_BEAM_SCT m_beam_sct;
} typeuBEAM;


#define BEAM_TRA_KWH 100
#define BEAM_TRA_KWL 1
typedef union taguBEAM_TRA {   /* 100/01 */
int m_id;
typeCDB_BEAM_TRA m_beam_tra;
} typeuBEAM_TRA;


#define BEAM_TRS_KWH 100
#define BEAM_TRS_KWL 3
typedef union taguBEAM_TRS {   /* 100/03 */
int m_id;
typeCDB_BEAM_TRS m_beam_trs;
} typeuBEAM_TRS;


#define BEAM_TND_KWH 100
#define BEAM_TND_KWL 5
typedef union taguBEAM_TND {   /* 100/05 */
int m_id;
typeCDB_BEAM_TND m_beam_tnd;
} typeuBEAM_TND;


#define BEAM_SL_KWH 101
typedef union taguBEAM_SL {   /* 101/LC */
int m_id;
typeCDB_BEAM_SL m_beam_sl;
typeCDB_BEAM_DL m_beam_dl;
typeCDB_BEAM_TL m_beam_tl;
typeCDB_BEAM_CL m_beam_cl;
typeCDB_BEAM_WL m_beam_wl;
} typeuBEAM_SL;


#define BEAM_FOC_KWH 102
typedef union taguBEAM_FOC {   /* 102/LC */
int m_id;
typeCDB_BEAM_FOC m_beam_foc;
typeCDB_BEAM_FOR m_beam_for;
} typeuBEAM_FOC;


#define BEAM_FOX_KWH 102
#define BEAM_FOX_KWL 0
typedef union taguBEAM_FOX {   /* 102/0 */
int m_id;
typeCDB_BEAM_FOX m_beam_fox;
} typeuBEAM_FOX;


#define BEAM_STI_KWH 103
typedef union taguBEAM_STI {   /* 103/LC */
int m_id;
typeCDB_BEAM_STI m_beam_sti;
} typeuBEAM_STI;


#define BEAM_CRC_KWH 104
typedef union taguBEAM_CRC {   /* 104/LC */
int m_id;
typeCDB_BEAM_CRC m_beam_crc;
typeCDB_BEAM_CRF m_beam_crf;
typeCDB_BEAM_TSN m_beam_tsn;
typeCDB_BEAM_CRP m_beam_crp;
typeCDB_BEAM_CRT m_beam_crt;
} typeuBEAM_CRC;


#define BEAM_STC_KWH 105
typedef union taguBEAM_STC {   /* 105/LC */
int m_id;
typeCDB_BEAM_STC m_beam_stc;
typeCDB_BEAM_TST m_beam_tst;
typeCDB_BEAM_STR m_beam_str;
} typeuBEAM_STC;


#define BEAM_RF0_KWH 106
typedef union taguBEAM_RF0 {   /* 106/DC */
int m_id;
typeCDB_BEAM_RF0 m_beam_rf0;
typeCDB_BEAM_RFI m_beam_rfi;
typeCDB_BEAM_RFC m_beam_rfc;
} typeuBEAM_RF0;


#define BEAM_DE0_KWH 107
typedef union taguBEAM_DE0 {   /* 107/LC */
int m_id;
typeCDB_BEAM_DE0 m_beam_de0;
typeCDB_BEAM_DES m_beam_des;
} typeuBEAM_DE0;


#define BEAM_PIF_KWH 108
typedef union taguBEAM_PIF {   /* 108/LC */
int m_id;
typeCDB_BEAM_PIF m_beam_pif;
} typeuBEAM_PIF;


#define BEAM_HR0_KWH 111
typedef union taguBEAM_HR0 {   /* 111/LC */
int m_id;
typeCDB_BEAM_HR0 m_beam_hr0;
typeCDB_BEAM_HRC m_beam_hrc;
} typeuBEAM_HR0;


#define BEAM_FTC_KWH 112
typedef union taguBEAM_FTC {   /* 112/LC */
int m_id;
typeCDB_BEAM_FTC m_beam_ftc;
typeCDB_BEAM_FTR m_beam_ftr;
} typeuBEAM_FTC;


#define BEAM_MP0_KWH 115
typedef union taguBEAM_MP0 {   /* 115/LC */
int m_id;
typeCDB_BEAM_MP0 m_beam_mp0;
typeCDB_BEAM_MPT m_beam_mpt;
} typeuBEAM_MP0;


#define BSLN_KWH 120
#define BSLN_KWL 0
typedef union taguBSLN {   /* 120/00 */
int m_id;
typeCDB_BSLN m_bsln;
typeCDB_BSLN_SCT m_bsln_sct;
} typeuBSLN;


#define BSLN_TND_KWH 120
#define BSLN_TND_KWL 5
typedef union taguBSLN_TND {   /* 120/05 */
int m_id;
typeCDB_BSLN_TND m_bsln_tnd;
} typeuBSLN_TND;


#define BSLN_FTC_KWH 122
typedef union taguBSLN_FTC {   /* 122/LC */
int m_id;
typeCDB_BSLN_FTC m_bsln_ftc;
typeCDB_BSLN_FTR m_bsln_ftr;
} typeuBSLN_FTC;


#define BSLN_STI_KWH 123
typedef union taguBSLN_STI {   /* 123/LC */
int m_id;
typeCDB_BSLN_STI m_bsln_sti;
} typeuBSLN_STI;


#define BSLN_CRC_KWH 124
typedef union taguBSLN_CRC {   /* 124/LC */
int m_id;
typeCDB_BSLN_CRC m_bsln_crc;
typeCDB_BSLN_CRF m_bsln_crf;
typeCDB_BSLN_TSN m_bsln_tsn;
typeCDB_BSLN_CRP m_bsln_crp;
typeCDB_BSLN_CRT m_bsln_crt;
} typeuBSLN_CRC;


#define BSLN_STC_KWH 125
typedef union taguBSLN_STC {   /* 125/LC */
int m_id;
typeCDB_BSLN_STC m_bsln_stc;
typeCDB_BSLN_TST m_bsln_tst;
typeCDB_BSLN_STR m_bsln_str;
} typeuBSLN_STC;


#define BSLN_RF0_KWH 126
typedef union taguBSLN_RF0 {   /* 126/DC */
int m_id;
typeCDB_BSLN_RF0 m_bsln_rf0;
typeCDB_BSLN_RFI m_bsln_rfi;
typeCDB_BSLN_RFC m_bsln_rfc;
} typeuBSLN_RF0;


#define BSLN_DE0_KWH 127
typedef union taguBSLN_DE0 {   /* 127/LC */
int m_id;
typeCDB_BSLN_DE0 m_bsln_de0;
typeCDB_BSLN_DES m_bsln_des;
} typeuBSLN_DE0;


#define BSCT_KWH 140
#define BSCT_KWL 0
typedef union taguBSCT {   /* 140/00 */
int m_id;
typeCDB_BSCT m_bsct;
typeCDB_BSCT_SCT m_bsct_sct;
} typeuBSCT;


#define BSCT_TND_KWH 140
#define BSCT_TND_KWL 5
typedef union taguBSCT_TND {   /* 140/05 */
int m_id;
typeCDB_BSCT_TND m_bsct_tnd;
} typeuBSCT_TND;


#define BSCT_FOC_KWH 142
typedef union taguBSCT_FOC {   /* 142/LC */
int m_id;
typeCDB_BSCT_FOC m_bsct_foc;
typeCDB_BSCT_FOR m_bsct_for;
} typeuBSCT_FOC;


#define BSCT_FOX_KWH 142
#define BSCT_FOX_KWL 0
typedef union taguBSCT_FOX {   /* 142/0 */
int m_id;
typeCDB_BSCT_FOX m_bsct_fox;
} typeuBSCT_FOX;


#define BSCT_STI_KWH 143
typedef union taguBSCT_STI {   /* 143/LC */
int m_id;
typeCDB_BSCT_STI m_bsct_sti;
} typeuBSCT_STI;


#define BSCT_CRC_KWH 144
typedef union taguBSCT_CRC {   /* 144/LC */
int m_id;
typeCDB_BSCT_CRC m_bsct_crc;
typeCDB_BSCT_CRF m_bsct_crf;
typeCDB_BSCT_TSN m_bsct_tsn;
typeCDB_BSCT_CRP m_bsct_crp;
typeCDB_BSCT_CRT m_bsct_crt;
} typeuBSCT_CRC;


#define BSCT_STC_KWH 145
typedef union taguBSCT_STC {   /* 145/LC */
int m_id;
typeCDB_BSCT_STC m_bsct_stc;
typeCDB_BSCT_TST m_bsct_tst;
typeCDB_BSCT_STR m_bsct_str;
} typeuBSCT_STC;


#define BSCT_RF0_KWH 146
typedef union taguBSCT_RF0 {   /* 146/DC */
int m_id;
typeCDB_BSCT_RF0 m_bsct_rf0;
typeCDB_BSCT_RFI m_bsct_rfi;
typeCDB_BSCT_RFC m_bsct_rfc;
} typeuBSCT_RF0;


#define BSCT_DE0_KWH 147
typedef union taguBSCT_DE0 {   /* 147/LC */
int m_id;
typeCDB_BSCT_DE0 m_bsct_de0;
typeCDB_BSCT_DES m_bsct_des;
} typeuBSCT_DE0;


#define TRUS_KWH 150
#define TRUS_KWL 0
typedef union taguTRUS {   /* 150/00 */
int m_id;
typeCDB_TRUS m_trus;
} typeuTRUS;


#define TRUS_WL_KWH 151
typedef union taguTRUS_WL {   /* 151/LC */
int m_id;
typeCDB_TRUS_WL m_trus_wl;
typeCDB_TRUS_LOA m_trus_loa;
} typeuTRUS_WL;


#define TRUS_RE0_KWH 152
typedef union taguTRUS_RE0 {   /* 152/LC */
int m_id;
typeCDB_TRUS_RE0 m_trus_re0;
typeCDB_TRUS_RES m_trus_res;
} typeuTRUS_RE0;


#define TRUS_ST0_KWH 155
typedef union taguTRUS_ST0 {   /* 155/LC */
int m_id;
typeCDB_TRUS_ST0 m_trus_st0;
typeCDB_TRUS_STR m_trus_str;
} typeuTRUS_ST0;


#define TRUS_RF0_KWH 156
typedef union taguTRUS_RF0 {   /* 156/DC */
int m_id;
typeCDB_TRUS_RF0 m_trus_rf0;
typeCDB_TRUS_RFI m_trus_rfi;
typeCDB_TRUS_RFC m_trus_rfc;
} typeuTRUS_RF0;


#define TRUS_DE0_KWH 157
typedef union taguTRUS_DE0 {   /* 157/LC */
int m_id;
typeCDB_TRUS_DE0 m_trus_de0;
typeCDB_TRUS_DES m_trus_des;
} typeuTRUS_DE0;


#define CABL_KWH 160
#define CABL_KWL 0
typedef union taguCABL {   /* 160/00 */
int m_id;
typeCDB_CABL m_cabl;
} typeuCABL;


#define CABL_WL_KWH 161
typedef union taguCABL_WL {   /* 161/LC */
int m_id;
typeCDB_CABL_WL m_cabl_wl;
typeCDB_CABL_LOA m_cabl_loa;
} typeuCABL_WL;


#define CABL_RE0_KWH 162
typedef union taguCABL_RE0 {   /* 162/LC */
int m_id;
typeCDB_CABL_RE0 m_cabl_re0;
typeCDB_CABL_RES m_cabl_res;
} typeuCABL_RE0;


#define CABL_SLP_KWH 163
#define CABL_SLP_KWL 0
typedef union taguCABL_SLP {   /* 163/00 */
int m_id;
typeCDB_CABL_SLP m_cabl_slp;
} typeuCABL_SLP;


#define CABL_ST0_KWH 165
typedef union taguCABL_ST0 {   /* 165/LC */
int m_id;
typeCDB_CABL_ST0 m_cabl_st0;
typeCDB_CABL_STR m_cabl_str;
} typeuCABL_ST0;


#define CABL_RF0_KWH 166
typedef union taguCABL_RF0 {   /* 166/DC */
int m_id;
typeCDB_CABL_RF0 m_cabl_rf0;
typeCDB_CABL_RFI m_cabl_rfi;
typeCDB_CABL_RFC m_cabl_rfc;
} typeuCABL_RF0;


#define SPRI_KWH 170
#define SPRI_KWL 0
typedef union taguSPRI {   /* 170/00 */
int m_id;
typeCDB_SPRI m_spri;
} typeuSPRI;


#define SPRI_RE0_KWH 170
typedef union taguSPRI_RE0 {   /* 170/LC */
int m_id;
typeCDB_SPRI_RE0 m_spri_re0;
typeCDB_SPRI_RES m_spri_res;
} typeuSPRI_RE0;


#define DAMP_KWH 171
#define DAMP_KWL 0
typedef union taguDAMP {   /* 171/00 */
int m_id;
typeCDB_DAMP m_damp;
} typeuDAMP;


#define MASS_KWH 172
#define MASS_KWL 0
typedef union taguMASS {   /* 172/00 */
int m_id;
typeCDB_MASS m_mass;
} typeuMASS;


#define MASS_ADD_KWH 172
#define MASS_ADD_KWL 1
typedef union taguMASS_ADD {   /* 172/01 */
int m_id;
typeCDB_MASS_ADD m_mass_add;
} typeuMASS_ADD;


#define MASS_EFF_KWH 172
typedef union taguMASS_EFF {   /* 172/LD */
int m_id;
typeCDB_MASS_EFF m_mass_eff;
typeCDB_MASS_EFC m_mass_efc;
} typeuMASS_EFF;


#define SPRI_WL_KWH 173
typedef union taguSPRI_WL {   /* 173/NR */
int m_id;
typeCDB_SPRI_WL0 m_spri_wl0;
typeCDB_SPRI_WL m_spri_wl;
} typeuSPRI_WL;


#define SPRI_MOV_KWH 174
#define SPRI_MOV_KWL 0
typedef union taguSPRI_MOV {   /* 174/00 */
int m_id;
typeCDB_SPRI_MOV m_spri_mov;
} typeuSPRI_MOV;


#define S_MATRIX_KWH 175
#define S_MATRIX_KWL 0
typedef union taguS_MATRIX {   /* 175/00 */
int m_id;
typeCDB_S_MATRIX m_s_matrix;
} typeuS_MATRIX;


#define LINK_KWH 179
#define LINK_KWL 0
typedef union taguLINK {   /* 179/00 */
int m_id;
typeCDB_LINK m_link;
} typeuLINK;


#define BOUN_KWH 180
#define BOUN_KWL 0
typedef union taguBOUN {   /* 180/00 */
int m_id;
typeCDB_BOUN m_boun;
} typeuBOUN;


#define BOUN_RES_KWH 180
typedef union taguBOUN_RES {   /* 180/LC */
int m_id;
typeCDB_BOUN_RES m_boun_res;
} typeuBOUN_RES;


#define BOUN_SUM_KWH 181
typedef union taguBOUN_SUM {   /* 181/LC */
int m_id;
typeCDB_BOUN_SUM m_boun_sum;
} typeuBOUN_SUM;


#define BOUN_LC_KWH 183
typedef union taguBOUN_LC {   /* 183/LC */
int m_id;
typeCDB_BOUN_LC m_boun_lc;
} typeuBOUN_LC;


#define SPRI_SUM_KWH 187
typedef union taguSPRI_SUM {   /* 187/LC */
int m_id;
typeCDB_SPRI_SUM m_spri_sum;
} typeuSPRI_SUM;


#define RSET_KWH 188
#define RSET_KWL 0
typedef union taguRSET {   /* 188/00 */
int m_id;
typeCDB_RSET m_rset;
typeCDB_RSET_ITM m_rset_itm;
} typeuRSET;


#define RSET_DAT_KWH 188
typedef union taguRSET_DAT {   /* 188/LC */
int m_id;
typeCDB_RSET_DAT m_rset_dat;
} typeuRSET_DAT;


#define PIPE_KWH 190
#define PIPE_KWL 0
typedef union taguPIPE {   /* 190/00 */
int m_id;
typeCDB_PIPE m_pipe;
} typeuPIPE;


#define PIPE_RES_KWH 190
typedef union taguPIPE_RES {   /* 190/LC */
int m_id;
typeCDB_PIPE_RES m_pipe_res;
} typeuPIPE_RES;


#define QUAD_KWH 200
#define QUAD_KWL 0
typedef union taguQUAD {   /* 200/00 */
int m_id;
typeCDB_QUAD m_quad;
} typeuQUAD;


#define QUAD_NOH_KWH 200
#define QUAD_NOH_KWL 1
typedef union taguQUAD_NOH {   /* 200/1 */
int m_id;
typeCDB_QUAD_NOH m_quad_noh;
typeCDB_QUAD_NOM m_quad_nom;
typeCDB_QUAD_NOD m_quad_nod;
} typeuQUAD_NOH;


#define QUAD_EDH_KWH 200
#define QUAD_EDH_KWL 2
typedef union taguQUAD_EDH {   /* 200/2 */
int m_id;
typeCDB_QUAD_EDH m_quad_edh;
typeCDB_QUAD_EDG m_quad_edg;
} typeuQUAD_EDH;


#define QUAD_TEN_KWH 200
#define QUAD_TEN_KWL 5
typedef union taguQUAD_TEN {   /* 200/5 */
int m_id;
typeCDB_QUAD_TEN m_quad_ten;
} typeuQUAD_TEN;


#define QUAD_RIM_KWH 200
#define QUAD_RIM_KWL 6
typedef union taguQUAD_RIM {   /* 200/6 */
int m_id;
typeCDB_QUAD_RIM m_quad_rim;
} typeuQUAD_RIM;


#define QUAD_RID_KWH 200
#define QUAD_RID_KWL 7
typedef union taguQUAD_RID {   /* 200/7 */
int m_id;
typeCDB_QUAD_RID m_quad_rid;
typeCDB_QUAD_RIL m_quad_ril;
} typeuQUAD_RID;


#define QCUT_0_KWH 200
#define QCUT_0_KWL 8
typedef union taguQCUT_0 {   /* 200/8 */
int m_id;
typeCDB_QCUT_0 m_qcut_0;
typeCDB_QCUT_NEW m_qcut_new;
typeCDB_QCUT_DIR m_qcut_dir;
typeCDB_QCUT_OUT m_qcut_out;
typeCDB_QCUT_IN m_qcut_in;
typeCDB_QCUT_WAR m_qcut_war;
} typeuQCUT_0;


#define TEXTILE_KWH 200
#define TEXTILE_KWL 9
typedef union taguTEXTILE {   /* 200/9 */
int m_id;
typeCDB_TEXTILE m_textile;
} typeuTEXTILE;


#define QUAD_P_KWH 200
#define QUAD_P_KWL 10
typedef union taguQUAD_P {   /* 200/10 */
int m_id;
typeCDB_QUAD_P m_quad_p;
} typeuQUAD_P;


#define QUAD_LOA_KWH 202
typedef union taguQUAD_LOA {   /* 202/LC */
int m_id;
typeCDB_QUAD_LOA m_quad_loa;
} typeuQUAD_LOA;


#define QUAD_LPI_KWH 203
typedef union taguQUAD_LPI {   /* 203/LC */
int m_id;
typeCDB_QUAD_LPI m_quad_lpi;
typeCDB_QUAD_LLI m_quad_lli;
typeCDB_QUAD_LAI m_quad_lai;
} typeuQUAD_LPI;


#define QUAD_LT_KWH 206
typedef union taguQUAD_LT {   /* 206/NR */
int m_id;
typeCDB_QUAD_LT m_quad_lt;
} typeuQUAD_LT;


#define QUAD_FOC_KWH 210
typedef union taguQUAD_FOC {   /* 210/LC */
int m_id;
typeCDB_QUAD_FOC m_quad_foc;
typeCDB_QUAD_FOR m_quad_for;
} typeuQUAD_FOC;


#define QUAD_NFC_KWH 211
typedef union taguQUAD_NFC {   /* 211/LC */
int m_id;
typeCDB_QUAD_NFC m_quad_nfc;
typeCDB_QUAD_NFO m_quad_nfo;
} typeuQUAD_NFC;


#define QUAD_EFC_KWH 212
typedef union taguQUAD_EFC {   /* 212/LC */
int m_id;
typeCDB_QUAD_EFC m_quad_efc;
typeCDB_QUAD_EFO m_quad_efo;
} typeuQUAD_EFC;


#define QUAD_BEC_KWH 213
typedef union taguQUAD_BEC {   /* 213/LC */
int m_id;
typeCDB_QUAD_BEC m_quad_bec;
typeCDB_QUAD_BED m_quad_bed;
} typeuQUAD_BEC;


#define QUAD_RFX_KWH 214
typedef union taguQUAD_RFX {   /* 214/LC */
int m_id;
typeCDB_QUAD_RFX m_quad_rfx;
} typeuQUAD_RFX;


#define QUAD_RNC_KWH 215
typedef union taguQUAD_RNC {   /* 215/LC */
int m_id;
typeCDB_QUAD_RNC m_quad_rnc;
typeCDB_QUAD_RNO m_quad_rno;
} typeuQUAD_RNC;


#define QUAD_STC_KWH 220
typedef union taguQUAD_STC {   /* 220/LC */
int m_id;
typeCDB_QUAD_STC m_quad_stc;
typeCDB_QUAD_STP m_quad_stp;
typeCDB_QUAD_STR m_quad_str;
} typeuQUAD_STC;


#define QUAD_NSC_KWH 221
typedef union taguQUAD_NSC {   /* 221/LC */
int m_id;
typeCDB_QUAD_NSC m_quad_nsc;
typeCDB_QUAD_NST m_quad_nst;
} typeuQUAD_NSC;


#define QUAD_ESC_KWH 222
typedef union taguQUAD_ESC {   /* 222/LC */
int m_id;
typeCDB_QUAD_ESC m_quad_esc;
typeCDB_QUAD_EST m_quad_est;
} typeuQUAD_ESC;


#define QUAD_RLC_KWH 225
typedef union taguQUAD_RLC {   /* 225/LC */
int m_id;
typeCDB_QUAD_RLC m_quad_rlc;
typeCDB_QUAD_RLA m_quad_rla;
typeCDB_QUAD_RLB m_quad_rlb;
} typeuQUAD_RLC;


#define QUAD_SEC_KWH 229
typedef union taguQUAD_SEC {   /* 229/LC */
int m_id;
typeCDB_QUAD_SEC m_quad_sec;
typeCDB_QUAD_SEQ m_quad_seq;
typeCDB_QUAD_SER m_quad_ser;
} typeuQUAD_SEC;


#define QUAD_RT0_KWH 230
typedef union taguQUAD_RT0 {   /* 230/LC */
int m_id;
typeCDB_QUAD_RT0 m_quad_rt0;
typeCDB_QUAD_RTS m_quad_rts;
} typeuQUAD_RT0;


#define QUAD_DST_KWH 250
typedef union taguQUAD_DST {   /* 250/DC */
int m_id;
typeCDB_QUAD_DST m_quad_dst;
} typeuQUAD_DST;


#define QUAD_NDS_KWH 251
typedef union taguQUAD_NDS {   /* 251/DC */
int m_id;
typeCDB_QUAD_NDS m_quad_nds;
} typeuQUAD_NDS;


#define QUAD_RIC_KWH 260
typedef union taguQUAD_RIC {   /* 260/DC */
int m_id;
typeCDB_QUAD_RIC m_quad_ric;
typeCDB_QUAD_REI m_quad_rei;
} typeuQUAD_RIC;


#define QUAD_NRC_KWH 261
typedef union taguQUAD_NRC {   /* 261/DC */
int m_id;
typeCDB_QUAD_NRC m_quad_nrc;
typeCDB_QUAD_NRI m_quad_nri;
} typeuQUAD_NRC;


#define QUAD_NRP_KWH 262
typedef union taguQUAD_NRP {   /* 262/DC */
int m_id;
typeCDB_QUAD_NRP m_quad_nrp;
typeCDB_QUAD_PUN m_quad_pun;
typeCDB_QUAD_PU1 m_quad_pu1;
} typeuQUAD_NRP;


#define QUAD_RD0_KWH 265
typedef union taguQUAD_RD0 {   /* 265/DC */
int m_id;
typeCDB_QUAD_RD0 m_quad_rd0;
typeCDB_QUAD_RTD m_quad_rtd;
} typeuQUAD_RD0;


#define QUAD_RED_KWH 270
#define QUAD_RED_KWL 0
typedef union taguQUAD_RED {   /* 270/0 */
int m_id;
typeCDB_QUAD_RED m_quad_red;
typeCDB_QUAD_REL m_quad_rel;
} typeuQUAD_RED;


#define QUAD_REE_KWH 270
typedef union taguQUAD_REE {   /* 270/DC */
int m_id;
typeCDB_QUAD_REE m_quad_ree;
typeCDB_QUAD_REM m_quad_rem;
typeCDB_QUAD_REA m_quad_rea;
typeCDB_QUAD_RER m_quad_rer;
} typeuQUAD_REE;


#define QUAD_RNE_KWH 271
typedef union taguQUAD_RNE {   /* 271/DC */
int m_id;
typeCDB_QUAD_RNE m_quad_rne;
} typeuQUAD_RNE;


#define QUAD_CFD_KWH 290
typedef union taguQUAD_CFD {   /* 290/LC */
int m_id;
typeCDB_QUAD_CFD m_quad_cfd;
} typeuQUAD_CFD;


#define QUAD_TM_KWH 291
typedef union taguQUAD_TM {   /* 291/LC */
int m_id;
typeCDB_QUAD_TM m_quad_tm;
typeCDB_QUAD_TMP m_quad_tmp;
} typeuQUAD_TM;


#define BRIC_KWH 300
#define BRIC_KWL 0
typedef union taguBRIC {   /* 300/00 */
int m_id;
typeCDB_BRIC m_bric;
} typeuBRIC;


#define BRIC_SU_KWH 300
#define BRIC_SU_KWL 2
typedef union taguBRIC_SU {   /* 300/02 */
int m_id;
typeCDB_BRIC_SU m_bric_su;
typeCDB_BRIC_SUR m_bric_sur;
} typeuBRIC_SU;


#define BRIC_RIM_KWH 300
#define BRIC_RIM_KWL 6
typedef union taguBRIC_RIM {   /* 300/6 */
int m_id;
typeCDB_BRIC_RIM m_bric_rim;
} typeuBRIC_RIM;


#define BRIC_P_KWH 300
#define BRIC_P_KWL 10
typedef union taguBRIC_P {   /* 300/10 */
int m_id;
typeCDB_BRIC_P m_bric_p;
} typeuBRIC_P;


#define BRIC_LOA_KWH 302
typedef union taguBRIC_LOA {   /* 302/LC */
int m_id;
typeCDB_BRIC_LOA m_bric_loa;
} typeuBRIC_LOA;


#define BRIC_STP_KWH 310
typedef union taguBRIC_STP {   /* 310/LC */
int m_id;
typeCDB_BRIC_STP m_bric_stp;
typeCDB_BRIC_STC m_bric_stc;
typeCDB_BRIC_STR m_bric_str;
} typeuBRIC_STP;


#define BRIC_NSC_KWH 311
typedef union taguBRIC_NSC {   /* 311/LC */
int m_id;
typeCDB_BRIC_NSC m_bric_nsc;
typeCDB_BRIC_NST m_bric_nst;
} typeuBRIC_NSC;


#define BRIC_ESC_KWH 312
typedef union taguBRIC_ESC {   /* 312/LC */
int m_id;
typeCDB_BRIC_ESC m_bric_esc;
typeCDB_BRIC_EST m_bric_est;
} typeuBRIC_ESC;


#define BRIC_REI_KWH 360
typedef union taguBRIC_REI {   /* 360/DC */
int m_id;
typeCDB_BRIC_REI m_bric_rei;
} typeuBRIC_REI;


#define BRIC_NRI_KWH 361
typedef union taguBRIC_NRI {   /* 361/DC */
int m_id;
typeCDB_BRIC_NRI m_bric_nri;
} typeuBRIC_NRI;


#define BRIC_CFD_KWH 390
typedef union taguBRIC_CFD {   /* 390/LC */
int m_id;
typeCDB_BRIC_CFD m_bric_cfd;
} typeuBRIC_CFD;


#define BRIC_TM_KWH 391
typedef union taguBRIC_TM {   /* 391/LC */
int m_id;
typeCDB_BRIC_TM m_bric_tm;
typeCDB_BRIC_TMP m_bric_tmp;
} typeuBRIC_TM;


#define HASE_PIH_KWH 404
typedef union taguHASE_PIH {   /* 404/NR */
int m_id;
typeCDB_HASE_PIH m_hase_pih;
typeCDB_HASE_PIL m_hase_pil;
} typeuHASE_PIH;


#define Substruc_KWH 411
typedef union taguSubstruc {   /* 411/NR */
int m_id;
typeCDB_Substruc m_substruc;
} typeuSubstruc;


#define SEG_DEF_KWH 900
#define SEG_DEF_KWL 0
typedef union taguSEG_DEF {   /* 900/00 */
int m_id;
typeCDB_SEG_DEF m_seg_def;
} typeuSEG_DEF;


/*   SOFiSTiK AG
     cdbtypesys.h
     end of automatically generated header
*/
#endif
