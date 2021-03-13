/*   SOFiSTiK AG
     cdbtypeten.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypeten_INCLUDED
#define cdbtypeten_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

#define TENDAXIS_ID 0
#define TENDAXIS_VER 201002
typedef struct tagCDB_TENDAXIS { /* 40/NR  Tendon lanes/reference axis data */
int     m_id0;                   /*        identifier 0 */
int     m_igsys;                 /*        prestress for: */
int     m_iginfo;                /*        Systeminfo */
int     m_igref;                 /*        reference to geometry */
int     m_icbit;                 /*        bit for analysis type */
int     m_ids;                   /*        Enum of secondary axis (1='A' to 26 ='Z') */
pckcode m_text[17];              /*        Designation */
#define TENDAXIS_TEXT_LEN 32
} typeCDB_TENDAXIS;

#define TENDAX_1_ID 1
#define TENDAX_1_VER 201002
typedef struct tagCDB_TENDAX_1 { /* 40/NR  Tendon lane stations */
int     m_id0;                   /*        identifier 1 */
int     m_igbit;                 /*        station parameter */
int     m_nrstab;                /*        internal beam number */
int     m_id3;                   /*        reserved (value = 0) */
float   m_xl;                    /*        beam X/L on beam */
float   m_s;                     /* [1001] station on reference lane */
float   m_sg;                    /* [1001] station of geometry */
float   m_sf;                    /*        toppoint station */
} typeCDB_TENDAX_1;

#define TENDSPLI_ID 0
#define TENDSPLI_VER 201002
typedef struct tagCDB_TENDSPLI { /* 41/NR  Tendon splines */
int     m_id0;                   /*        identifier 0 */
int     m_nrspur;                /*        corresponding lane */
int     m_nrsv;                  /*        prestress system */
int     m_igsys;                 /*        prestress for: */
int     m_intyp;                 /*        bit for analysis type */
int     m_igref;                 /*        reference to      geometry  Rec: 03 */
int     m_igrefx;                /*        reference to exc. geometry  Rec: 03 */
int     m_id7;                   /*        reserved (value = 0) */
int     m_id8;                   /*        reserved (value = 0) */
int     m_id9;                   /*        reserved (value = 0) */
float   m_stparm[12];            /*        additional data: */
pckcode m_text[17];              /*        Designation */
#define TENDSPLI_TEXT_LEN 32
} typeCDB_TENDSPLI;

#define TENDSP_I_VER 201002
typedef struct tagCDB_TENDSP_I { /* 41/NR  Input points */
int     m_id0;                   /*        identifier INTYP see 41/0  (1=ZPUV standard geometry) */
int     m_igbit;                 /*        station parameter see 40/1 */
int     m_id2;                   /*        reserved (value = 0) */
int     m_id3;                   /*        reserved (value = 0) */
float   m_data[20];              /*        Input point data */
chr     m_qsp;                   /*        Selection string - reference to cross section point */
chr     m_varu;                  /*        Selection string - axis variable for offset U */
chr     m_varv;                  /*        Selection string - axis variable for offset V */
float   m_dat2[50];              /*        Additional input point */
} typeCDB_TENDSP_I;

#define TENDTOPP_VER 201002
typedef struct tagCDB_TENDTOPP { /* 43/NR  Tendon toppoints */
int     m_id0;                   /*        identifier: */
int     m_nr;                    /*        corresponding lane */
int     m_igref;                 /*        reference to      geometry  Rec: 03 */
float   m_s[124];                /* [1001] stations on toppoints (max. 124) */
} typeCDB_TENDTOPP;

#define TENDON_ID 0
#define TENDON_VER 201002
typedef struct tagCDB_TENDON {   /* 44/NR  Tendons */
int     m_id0;                   /*        identifier 0 */
int     m_nrspur;                /*        corresponding lane */
int     m_nrspli;                /*        Spline-No */
int     m_nrstrg;                /*        tendon no. */
int     m_igref;                 /*        reference to      geometry  Rec: 03 */
int     m_igtyp;                 /*        bit for analysis type */
int     m_iz_ref;                /*        IGTYP=1024:  Def-No of geometry */
int     m_niba[3];               /*        construction stages */
int     m_nrsv;                  /*        prestress system */
int     m_nsp;                   /*        number of tendons */
int     m_mata;                  /*        material concrete */
int     m_nvart;                 /*        type of jacking */
int     m_nvartu;                /*        output control */
int     m_nvvor;                 /*        prestress input */
int     m_nvbit[2];              /*        jacking bit */
int     m_lfp[2];                /*        prestress loadcases */
int     m_igsys;                 /*        prestress for: */
int     m_id21;                  /*        reserved (value = 0) */
float   m_kapa;                  /*        KAPA + 100*KAPL + 1000*action */
float   m_einl;                  /*        transition length */
float   m_etyp;                  /*        force type to EINL */
float   m_tfak;                  /*        factor partial p */
float   m_tlitz;                 /*        no. of wires */
float   m_ar;                    /*        crack design area */
float   m_dz;                    /*        diameter of tendon */
float   m_uz;                    /*        perimeter */
float   m_valm[4];               /*        reserved */
pckcode m_text[17];              /*        Designation */
#define TENDON_TEXT_LEN 32
} typeCDB_TENDON;

#define TENDJACK_ID 1
#define TENDJACK_VER 201002
typedef struct tagCDB_TENDJACK { /* 44/NR  Tendon jacking data */
int     m_id0;                   /*        identifier 1 */
int     m_id1;                   /*        reserved (value = 0) */
int     m_id2;                   /*        reserved (value = 0) */
int     m_id3;                   /*        reserved (value = 0) */
float   m_zvstrg[16];            /*        geometry data */
float   m_zvfak[24];             /*        stresses and stressing factors */
float   m_zvvor[12];             /*        direct input of prestress */
float   m_zvfree[12];            /*        free prestress */
float   m_zvaend[8];             /*        local geometry position */
float   m_zvreib[8];             /*        additional friction data */
float   m_zvfgrz[32];            /*        limit values of prestress */
float   m_zvweg[16];             /*        stressing deformation */
pckcode m_text[17];              /*        Designation */
#define TENDJACK_TEXT_LEN 32
} typeCDB_TENDJACK;

#define TENDFACT_ID 2
#define TENDFACT_VER 201002
typedef struct tagCDB_TENDFACT { /* 44/NR  Tendon jacking factors */
int     m_id0;                   /*        identifier 2 */
int     m_igbit;                 /*        station parameter see 40/1 */
int     m_id2;                   /*        reserved (value = 0) */
int     m_id3;                   /*        reserved (value = 0) */
float   m_s;                     /* [1001] station */
float   m_fak;                   /*        active stressing factors */
float   m_zwfak[12];             /*        additional factor data */
} typeCDB_TENDFACT;


#define TENDAXIS_KWH 40
typedef union taguTENDAXIS {   /* 40/NR */
int m_id;
typeCDB_TENDAXIS m_tendaxis;
typeCDB_TENDAX_1 m_tendax_1;
} typeuTENDAXIS;


#define TENDSPLI_KWH 41
typedef union taguTENDSPLI {   /* 41/NR */
int m_id;
typeCDB_TENDSPLI m_tendspli;
typeCDB_TENDSP_I m_tendsp_i;
} typeuTENDSPLI;


#define TENDTOPP_KWH 43
typedef union taguTENDTOPP {   /* 43/NR */
int m_id;
typeCDB_TENDTOPP m_tendtopp;
} typeuTENDTOPP;


#define TENDON_KWH 44
typedef union taguTENDON {   /* 44/NR */
int m_id;
typeCDB_TENDON m_tendon;
typeCDB_TENDJACK m_tendjack;
typeCDB_TENDFACT m_tendfact;
} typeuTENDON;


/*   SOFiSTiK AG
     cdbtypeten.h
     end of automatically generated header
*/
#endif
