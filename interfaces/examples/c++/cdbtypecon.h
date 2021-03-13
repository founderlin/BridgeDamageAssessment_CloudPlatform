/*   SOFiSTiK AG
     cdbtypecon.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypecon_INCLUDED
#define cdbtypecon_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;

#define CON_0_ID 0
#define CON_0_VER 200501
typedef struct tagCDB_CON_0 {    /* 8/ID  Connection Headder */
int     m_ids;                   /*        Identification = 0 */
int     m_typ;                   /*        Type of connection */
int     m_mat;                   /*        Materialnumber for all plates */
pckcode m_text[17];              /*        designation of connection */
#define CON_0_TEXT_LEN 32
} typeCDB_CON_0;

#define CON_BOL_ID 1
#define CON_BOL_VER 200501
typedef struct tagCDB_CON_BOL {  /* 8/ID  Definition of Bolts */
int     m_ids;                   /*        Identification = 1 */
int     m_typ;                   /*        Type of hole */
chr     m_mat;                   /*        Materialdesignation of bolt */
float   m_d;                     /* [1011] Diameter of bolt */
chr     m_norm[4];               /*        Designation of product code */
pckcode m_text[17];              /*        designation of bolt */
#define CON_BOL_TEXT_LEN 32
} typeCDB_CON_BOL;

#define CON_WEL_ID 2
#define CON_WEL_VER 200501
typedef struct tagCDB_CON_WEL {  /* 8/ID  Definition of Weldings */
int     m_ids;                   /*        Identification = 2 */
int     m_typ;                   /*        Type of weld */
int     m_mat;                   /*        Materialnumber of weld (not used) */
float   m_t;                     /* [1011] Thickness of weld */
float   m_aw;                    /*        Reduction factor */
pckcode m_text[17];              /*        designation of weld */
#define CON_WEL_TEXT_LEN 32
} typeCDB_CON_WEL;

#define CON_CLE_ID 3
#define CON_CLE_VER 200501
typedef struct tagCDB_CON_CLE {  /* 8/ID  Definition of Cleats (Angle/Latch) */
int     m_ids;                   /*        Identification = 3 */
int     m_typ;                   /*        Enum of type (angle/latch not really enforced) */
int     m_mat;                   /*        Material number of the plate */
chr     m_bol[2];                /*        id of bolts */
int     m_nbb[2];                /*        Number of bolts in width direction */
int     m_nbl[2];                /*        Number of bolts in angle directions 1 & 2 */
float   m_t;                     /* [1011] Thickness of cleat */
float   m_b;                     /* [1011] Width/Height of cleat */
float   m_l[2];                  /* [1011] Length of angles */
float   m_w[8];                  /* [1011] Distances */
float   m_a[2];                  /* [1011] weld thickness for NBL(i) if welding is used */
float   m_tf;                    /* [1011] Thickness of backplate */
pckcode m_text[17];              /*        designation of element */
#define CON_CLE_TEXT_LEN 32
} typeCDB_CON_CLE;

#define CON_MEM_ID 10
#define CON_MEM_VER 200501
typedef struct tagCDB_CON_MEM {  /* 8/ID  Connected Member data */
int     m_ids;                   /*        Identification = 10 */
chr     m_nr;                    /*        Enumeration or designation of member */
int     m_typ;                   /*        Type of connection bitpattern */
int     m_nrq;                   /*        Number of section */
chr     m_wtyp;                  /*        id of the web connection */
chr     m_utyp;                  /*        id of the upper flange connection */
chr     m_ltyp;                  /*        id of the lower flange connection */
float   m_l;                     /* [1001] length of member */
float   m_aw;                    /* [1011] weld thickness for web connection */
float   m_au;                    /* [1011] weld thickness for upper flange connection */
float   m_al;                    /* [1011] weld thickness for lower flange connection */
float   m_dd;                    /* [1011] Distance value of endpoint to central node */
float   m_d[3];                  /*        Direction vector to beam axis in the */
float   m_roty;                  /* [   5] Angle of end plate y-rotation */
float   m_rotz;                  /* [   5] Angle of end plate z-rotation */
float   m_cutu;                  /* [1011] Cut out height for upper flange */
float   m_cutl;                  /* [1011] Cut out height for lower flange */
float   m_clu;                   /* [1011] Cut out length for upper flange */
float   m_cld;                   /* [1011] Cut out length for lower flange */
float   m_voute[4][2];           /* [1011] Voute [lenght,height] for */
} typeCDB_CON_MEM;

#define CON_END_ID 11
#define CON_END_VER 200501
typedef struct tagCDB_CON_END {  /* 8/ID  Endplate of Beam */
int     m_ids;                   /*        Identification = 11 */
int     m_typ;                   /*        Type of end plate */
int     m_mat;                   /*        Materialnumber of endplate */
chr     m_bolt;                  /*        Identifier of bolt type */
int     m_nbr;                   /*        Number of bolts in height direction */
int     m_nbc;                   /*        Number of bolts in width direction */
float   m_b;                     /* [1011] Width of plate */
float   m_h;                     /* [1011] Total plate height */
float   m_mx;                    /* [1011] Eccentricity */
float   m_t;                     /* [1011] Thickness of plate */
float   m_hb[5];                 /* [1011] Height for bolts */
float   m_w[2];                  /* [1011] Width for bolts */
float   m_htbp[4];               /* [1011] Height and thickness values for back plates */
} typeCDB_CON_END;

#define CON_PIN_ID 12
#define CON_PIN_VER 200712
typedef struct tagCDB_CON_PIN {  /* 8/ID  Pinned plate of Beam */
int     m_ids;                   /*        Identification = 13 */
int     m_mat;                   /*        Materialnumber of pin plate */
int     m_mats;                  /*        Materialnumber of support plate */
int     m_matp;                  /*        Materialnumber of pin */
float   m_dp;                    /* [1011] Diameter of pin */
float   m_dh;                    /* [1011] Diameter of hole */
float   m_tp;                    /* [1011] Thickness pin plate */
float   m_tsup;                  /* [1011] Thickness sup plate */
float   m_c;                     /* [1011] gap between plates */
float   m_e1;                    /* [1011] eccentricity 1 */
float   m_e2;                    /* [1011] eccentricity 2 */
} typeCDB_CON_PIN;

#define CON_PLT_ID 20
#define CON_PLT_VER 200501
typedef struct tagCDB_CON_PLT {  /* 8/ID  Additional plates in connection */
int     m_ids;                   /*        Identification = 20 */
int     m_typ;                   /*        Type of plate */
int     m_mat;                   /*        Number of material */
float   m_t;                     /* [1011] Thickness of plate */
float   m_edge[8][5];            /* [1011] Local coordinates, weldid, weldthickness */
} typeCDB_CON_PLT;


#define CON_0_KWH 8
typedef union taguCON_0 {   /* 8/ID */
int m_id;
typeCDB_CON_0 m_con_0;
typeCDB_CON_BOL m_con_bol;
typeCDB_CON_WEL m_con_wel;
typeCDB_CON_CLE m_con_cle;
typeCDB_CON_MEM m_con_mem;
typeCDB_CON_END m_con_end;
typeCDB_CON_PIN m_con_pin;
typeCDB_CON_PLT m_con_plt;
} typeuCON_0;


/*   SOFiSTiK AG
     cdbtypecon.h
     end of automatically generated header
*/
#endif
