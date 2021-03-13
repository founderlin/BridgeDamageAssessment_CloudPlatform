/*   SOFiSTiK AG
     cdbtypegeo.h
     automatically generated header, no use to modify
*/


#ifndef cdbtypegeo_INCLUDED
#define cdbtypegeo_INCLUDED

#ifndef SOF_CHARS_IN_PACKCODE
#define SOF_CHARS_IN_PACKCODE(pack) ((sizeof(pack)/sizeof(pack[0]))*2 - 1) 
#endif

#ifndef SOF_CDBASE_VERSION
#define SOF_CDBASE_VERSION 233455
#endif

typedef int bhr;
typedef int chr;
#define AXIS_ID 0
#define AXIS_VER 201509
typedef struct tagCDB_AXIS {     /* 3/ID  Geometric Axis */
int     m_id0;                   /*        identifier 0 */
int     m_id1;                   /*        subtype of axis */
#define AXIS_SUBTYPE_NONE 0
#define AXIS_SUBTYPE_AXIS 1
#define AXIS_SUBTYPE_BEAM 2
#define AXIS_SUBTYPE_LANE 10
#define AXIS_SUBTYPE_BGEO 11
#define AXIS_SUBTYPE_TEND 12
#define AXIS_SUBTYPE_POST 15
#define AXIS_SUBTYPE_AUXI 19
#define AXIS_SUBTYPE_GRAF 90
int     m_id2;                   /*        reserved */
int     m_id3;                   /*        reserved */
int     m_id4;                   /*        reserved */
int     m_id5;                   /*        reserved */
pckcode m_text[17];              /*        Designation of Line */
#define AXIS_TEXT_LEN 32
} typeCDB_AXIS;

#define AXIS_REF_VER 0
typedef struct tagCDB_AXIS_REF { /* 3/ID  Reference to another Geometry */
int     m_igm;                   /*        negative value of the master geometry 03/abs(IGM) */
int     m_igs;                   /*        optional identifier of a secondary axis */
float   m_smin;                  /*        min parameter on referenced axis */
float   m_smax;                  /*        max parameter on referenced axis */
} typeCDB_AXIS_REF;

#define AXIS_GEO_VER 200801
typedef struct tagCDB_AXIS_GEO { /* 3/ID  Geometric properties */
int     m_iln;                   /*        Code of geometry */
#define GAX_GEO_DEFAULT 1
#define GAX_GEO_PROJECT 2
#define GAX_GEO_SPLINE 3
#define GAX_GEO_EXSPLI 4
#define GAX_GEO_BEZIER 5
#define GAX_GEO_NURBS 6
#define GAX_GEO_NURBX 7
#define GAX_GEO_DATA 8
#define GAX_GEO_NORM 9
#define GAX_GEO_CIRC 11
#define GAX_GEO_CBEZIER 15
#define GAX_GEO_CNURBS 16
#define GAX_GEO_PROJ_CLO 20
#define GAX_GEO_PROJ_CUB 21
#define GAX_GEO_PROJ_BLO 22
#define GAX_GEO_PROJ_SIN 24
#define GAX_GEO_PROJ_COS 25
#define GAX_GEO_NURBS_KN 90
#define GAX_GEO_NURBS_CPT 91
float   m_gpg;                   /* [1001] geometry parameter 1 */
float   m_gpa;                   /* [1001] geometry parameter 2 */
float   m_dd;                    /* [1001] arc length */
float   m_s1;                    /*        parameter s on start */
float   m_xyz1[3];               /* [1001] Ordinate of start */
float   m_dxyz1[3];              /*        Tangent of start */
float   m_rg1;                   /* [1009] in-plane curvature */
float   m_ra1;                   /* [1009] vertical curvature */
float   m_s2;                    /*        parameter s on end */
float   m_xyz2[3];               /* [1001] Ordinate of endpoint */
float   m_dxyz2[3];              /*        Tangent of endpoint */
float   m_rg2;                   /* [1009] in-plane curvature */
float   m_ra2;                   /* [1009] vertical curvature */
float   m_xat;                   /* [1001] relat. startordinate */
} typeCDB_AXIS_GEO;

#define AXIS_NKN_ID 90
#define AXIS_NKN_VER 200705
typedef struct tagCDB_AXIS_NKN { /* 3/ID  Knots of a Nurb */
int     m_iln;                   /*        ID=90 */
int     m_deg;                   /*        Order of Spline */
float   m_s[256];                /*        Knot-Vector */
} typeCDB_AXIS_NKN;

#define SLN_NKN_ID 90
#define SLN_NKN_VER 200705
typedef struct tagCDB_SLN_NKN {  /* 39/NR  Knots of a Nurb */
int     m_iln;                   /*        ID=90 */
int     m_deg;                   /*        Order of Spline */
float   m_s[256];                /*        Knot-Vector */
} typeCDB_SLN_NKN;

#define AXIS_CPT_ID 91
#define AXIS_CPT_VER 200705
typedef struct tagCDB_AXIS_CPT { /* 3/ID  Control point of a Nurb */
int     m_iln;                   /*        ID=91 */
float   m_w;                     /*        Weight */
float   m_xyz[3];                /* [1001] Coordinates */
float   m_dir[3];                /*        upward direction */
} typeCDB_AXIS_CPT;

#define SLN_CPT_ID 91
#define SLN_CPT_VER 200705
typedef struct tagCDB_SLN_CPT {  /* 39/NR  Control point of a Nurb */
int     m_iln;                   /*        ID=91 */
float   m_w;                     /*        Weight */
float   m_xyz[3];                /* [1001] Coordinates */
float   m_dir[3];                /*        upward direction */
} typeCDB_SLN_CPT;

#define AXIS_PT_ID 92
#define AXIS_PT_VER 200707
typedef struct tagCDB_AXIS_PT {  /* 3/ID  Data point on curve */
int     m_iln;                   /*        ID=92 */
float   m_s;                     /*        Parameter along curve */
float   m_xyz[3];                /* [1001] Coordinates */
float   m_dir[3];                /*        upward direction */
} typeCDB_AXIS_PT;

#define SLN_PT_ID 92
#define SLN_PT_VER 200707
typedef struct tagCDB_SLN_PT {   /* 39/NR  Data point on curve */
int     m_iln;                   /*        ID=92 */
float   m_s;                     /*        Parameter along curve */
float   m_xyz[3];                /* [1001] Coordinates */
float   m_dir[3];                /*        upward direction */
} typeCDB_SLN_PT;

#define AXIS_ARC_ID 93
#define AXIS_ARC_VER 200707
typedef struct tagCDB_AXIS_ARC { /* 3/ID  Circular Arc */
int     m_iln;                   /*        ID=93 */
int     m_idf;                   /*        Definition selected */
float   m_r;                     /* [1001] Radius of arc */
float   m_xyz[3];                /* [1001] Coordinates of center */
float   m_dir[3];                /*        upward direction of plane */
float   m_xyza[3];               /* [1001] optional start point of arc */
float   m_xyze[3];               /* [1001] optional end point of arc */
} typeCDB_AXIS_ARC;

#define SLN_ARC_ID 93
#define SLN_ARC_VER 200707
typedef struct tagCDB_SLN_ARC {  /* 39/NR  Circular Arc */
int     m_iln;                   /*        ID=93 */
int     m_idf;                   /*        Definition selected */
float   m_r;                     /* [1001] Radius of arc */
float   m_xyz[3];                /* [1001] Coordinates of center */
float   m_dir[3];                /*        upward direction of plane */
float   m_xyza[3];               /* [1001] optional start point of arc */
float   m_xyze[3];               /* [1001] optional end point of arc */
} typeCDB_SLN_ARC;

#define AXIS_SPT_ID 97
#define AXIS_SPT_VER 200707
typedef struct tagCDB_AXIS_SPT { /* 3/ID  Station point on a Nurb */
int     m_iln;                   /*        ID=97 */
float   m_s;                     /*        Station value at data point */
float   m_l;                     /* [1001] Length (prescribed if XYZ==0.0) */
float   m_xyz[3];                /* [1001] Coordinates for 3D-intersection plane */
float   m_dir[3];                /*        Direction (nx,ny,nz) of normal of the plane */
} typeCDB_AXIS_SPT;

#define AXIS_VIZ_ID 98
#define AXIS_VIZ_VER 200601
typedef struct tagCDB_AXIS_VIZ { /* 3/ID  Data points for visualisation */
int     m_iln;                   /*        ID=98 */
int     m_color;                 /*        hexadecimal RGB-value (e.g. 99AAFF) */
int     m_thick;                 /*        Thickness in pixel */
float   m_pts[64][3];            /* [1001] Data Points */
} typeCDB_AXIS_VIZ;

#define AXIS_OBB_ID 99
#define AXIS_OBB_VER 200705
typedef struct tagCDB_AXIS_OBB { /* 3/ID  Oriented Boundig Box */
int     m_iln;                   /*        ID=99 */
float   m_s1;                    /*        Parameter on Start */
float   m_s2;                    /*        Parameter on end */
float   m_ta[3][3];              /*        Transformation Matrix */
float   m_xyz[3];                /* [1001] Center of Box */
float   m_xi[3];                 /* [1001] Half widths */
} typeCDB_AXIS_OBB;

#define AXIS_ATB_ID 101
#define AXIS_ATB_VER 200701
typedef struct tagCDB_AXIS_ATB { /* 3/ID  Geometric segments of axis plan view */
int     m_id0;                   /*        ident=101 */
int     m_id1;                   /*        specification type */
int     m_id2;                   /*        type of transition curve to be used */
float   m_s;                     /*        Station value at tangent */
float   m_l[5];                  /* [1001] Length of segment */
float   m_r[5];                  /* [1001] Radius mid & start & end */
float   m_xyz[3];                /* [1001] Startpoint of tangent */
float   m_dir[3];                /*        Tangential direction */
float   m_d[2];                  /* [1001] Distance to point on curve (start/end) */
float   m_tau;                   /* [   5] deflection angle */
chr     m_txt;                   /*        Identifier of this sequence */
} typeCDB_AXIS_ATB;

#define AXIS_VTB_ID 102
#define AXIS_VTB_VER 200601
typedef struct tagCDB_AXIS_VTB { /* 3/ID  Geometric properties for axis heights */
int     m_id0;                   /*        ident=102 */
int     m_id1;                   /*        specification type */
int     m_id2;                   /*        reserved */
float   m_s;                     /*        Parameter s along the axis */
float   m_h;                     /* [1001] Height of gradient polygon */
float   m_r;                     /* [1001] Radius of curvature at this point */
float   m_x;                     /* [1001] Calculated true length along the axis */
float   m_t;                     /* [1001] Calculated secant length along the axis */
} typeCDB_AXIS_VTB;

#define AXIS_ITB_ID 103
#define AXIS_ITB_VER 200712
typedef struct tagCDB_AXIS_ITB { /* 3/ID  Placement at axis position */
int     m_id0;                   /*        ident=103 */
int     m_ids;                   /*        Enum of secondary axis */
int     m_typ;                   /*        properties of this placement */
int     m_npt;                   /*        point number */
int     m_grp;                   /*        group number behind that placement */
int     m_nos[2];                /*        Number of section before and behind that placement */
chr     m_segt;                  /*        identifier of a segment see (900/0) behind that placement */
float   m_s;                     /*        Parameter s of this section */
float   m_y;                     /* [1001] additional transverse offset */
float   m_z;                     /* [1001] additional vertical offset */
float   m_alf;                   /* [   5] Rotation about global Z */
float   m_alfx;                  /* [   5] Rotation about local axis x */
float   m_alfy;                  /* [   5] Rotation about transverse y */
float   m_alfz;                  /* [   5] Rotation about vertical   z */
float   m_incr;                  /* [   5] Inclination to the right +y */
float   m_incl;                  /* [   5] Inclination to the left  -y */
chr     m_srule[5];              /*        Formula string to evaluate the value S */
pckcode m_text[17];              /*        Designation of Placement */
#define AXIS_ITB_TEXT_LEN 32
} typeCDB_AXIS_ITB;

#define AXIS_ITS_ID 104
#define AXIS_ITS_VER 200705
typedef struct tagCDB_AXIS_ITS { /* 3/ID  Secondary axis definition */
int     m_id0;                   /*        Ident=104 */
int     m_ids;                   /*        Enum of secondary axis (1='A' to 26 ='Z') */
int     m_iref;                  /*        Reference to external axis geometry */
int     m_npt;                   /*        offset for structural points along the axis */
int     m_grp;                   /*        group number (:103 is always added as an offset) */
float   m_y;                     /* [1001] constant or maximum value of y offset */
float   m_z;                     /* [1001] constant or maximum value of z offset */
chr     m_y_v[4];                /*        variable name for y offset (see :110) */
chr     m_z_v[4];                /*        variable name for z offset (see :110) */
pckcode m_text[17];              /*        Designation (only for first point of a sequence) */
#define AXIS_ITS_TEXT_LEN 32
} typeCDB_AXIS_ITS;

#define AXIS_PSM_ID 105
#define AXIS_PSM_VER 200701
typedef struct tagCDB_AXIS_PSM { /* 3/ID  Prestress method */
int     m_id0;                   /*        ident=105 */
int     m_idt;                   /*        Identifier of Tendon */
int     m_type;                  /*        Type of Spline geometry */
int     m_nsp;                   /*        Number of tendon elements */
int     m_id5;                   /*        Placement of tendons */
int     m_jack;                  /*        Jacking procedure */
int     m_lire;                  /*        Sides for jacking */
int     m_iba[3];                /*        Construction stage identifiers */
int     m_nrsv;                  /*        number of jacking method */
int     m_dummy[5];              /*        reserved */
float   m_fak;                   /*        factor for prestress */
float   m_litz;                  /*        partial number of strands */
float   m_frsp[2];               /* [1001] Length controls for free tendon geometry */
float   m_zsp[2];                /* [1011] Distances of tendon to extreme fiber upper/lower */
pckcode m_textl[17];             /*        Designation of layer of Tendons */
#define AXIS_PSM_TEXTL_LEN 32
} typeCDB_AXIS_PSM;

#define AXIS_PSP_ID 106
#define AXIS_PSP_VER 200701
typedef struct tagCDB_AXIS_PSP { /* 3/ID  Prestress placements */
int     m_id0;                   /*        ident=106 */
int     m_typ;                   /*        Type of placement */
int     m_id2;                   /*        Type of station data (bitpattern) */
int     m_id3;                   /*        reserved */
int     m_id4;                   /*        reserved */
int     m_id5;                   /*        reserved */
float   m_s;                     /*        Station along axis */
float   m_zt;                    /* [1011] Distances of tendon to extreme fiber upper/lower */
float   m_dzt;                   /*        inclination of tendon to axis */
} typeCDB_AXIS_PSP;

#define AXIS_PLC_ID 107
#define AXIS_PLC_VER 201006
typedef struct tagCDB_AXIS_PLC { /* 3/ID  Placement at axis position */
int     m_id0;                   /*        ident=107 */
int     m_ids;                   /*        Enum of secondary axis */
int     m_typ;                   /*        properties of this placement */
int     m_npt;                   /*        point number */
int     m_grp;                   /*        group number behind that placement */
int     m_nos[2];                /*        Number of section before and behind that placement */
int     m_ib0;                   /*        general bit-mask */
chr     m_idp;                   /*        identifier of this placement */
chr     m_segt;                  /*        identifier of a segment see (900/0) behind that placement */
int     m_res[6];                /*        reserved */
float   m_s;                     /*        Parameter s of this section */
float   m_y;                     /* [1001] additional transverse offset */
float   m_z;                     /* [1001] additional vertical offset */
float   m_alf;                   /* [   5] Rotation about global Z */
float   m_alfx;                  /* [   5] Rotation about local axis x */
float   m_alfy;                  /* [   5] Rotation about transverse y */
float   m_alfz;                  /* [   5] Rotation about vertical   z */
float   m_incr;                  /* [   5] Inclination to the right +y */
float   m_incl;                  /* [   5] Inclination to the left  -y */
chr     m_srule[5];              /*        Formula string to evaluate the value S */
pckcode m_text[17];              /*        Designation of placement */
#define AXIS_PLC_TEXT_LEN 32
} typeCDB_AXIS_PLC;

#define AXIS_OPT_ID 10107
#define AXIS_OPT_VER 210415
typedef struct tagCDB_AXIS_OPT { /* 3/ID  Placement options */
int     m_id0;                   /*        ident=10107 */
int     m_a_filter;              /*        Filter for axis */
int     m_t_filter;              /*        Filter for axis type */
} typeCDB_AXIS_OPT;

#define AXIS_PRP_ID 110
#define AXIS_PRP_VER 200603
typedef struct tagCDB_AXIS_PRP { /* 3/ID  General properties of axis */
int     m_id0;                   /*        ident=110 */
chr     m_name[4];               /*        Name of this item */
int     m_typ;                   /*        Continuity Type of this data point */
float   m_s_val[5];              /*        Parameter s of this section and values */
chr     m_srule[5];              /*        Formula string to evaluate the value S */
chr     m_vrule[10];             /*        Formula string to evaluate the value VAL */
chr     m_dvrule[10];            /*        Formula string to evaluate the value dVAL/dS */
} typeCDB_AXIS_PRP;

#define GAXD_ATB_ID 121
#define GAXD_ATB_VER 201101
typedef struct tagCDB_GAXD_ATB { /* 3/ID  Geometric segments of axis plan view (double precision) */
int     m_id0;                   /*        ident=121 */
int     m_id1;                   /*        specification type */
int     m_id2;                   /*        type of transition curve to be used */
int     m_id3;                   /*        reserved */
double  m_s;                     /*        Station value at tangent */
double  m_l[5];                  /* [1001] Length of segment */
double  m_r[5];                  /* [1001] Radius mid & start & end */
double  m_xyz[3];                /* [1001] Startpoint of tangent */
double  m_dir[3];                /*        Tangential direction */
double  m_d[2];                  /* [1001] Distance to point on curve (start/end) */
double  m_tau;                   /* [   5] deflection angle */
chr     m_txt0;                  /*        reserved */
chr     m_txt;                   /*        Identifier of this sequence */
} typeCDB_GAXD_ATB;

#define GAXD_VTB_ID 122
#define GAXD_VTB_VER 201101
typedef struct tagCDB_GAXD_VTB { /* 3/ID  Geometric properties for axis heights (double precision) */
int     m_id0;                   /*        ident=122 */
int     m_id1;                   /*        specification type */
int     m_id2;                   /*        reserved */
int     m_id3;                   /*        reserved */
double  m_s;                     /*        Parameter s along the axis */
double  m_h;                     /* [1001] Height of gradient polygon */
double  m_r;                     /* [1001] Radius of curvature at this point */
double  m_x;                     /* [1001] Calculated true length along the axis */
double  m_t;                     /* [1001] Calculated secant length along the axis */
} typeCDB_GAXD_VTB;

#define GAXD_GEO_VER 201101
typedef struct tagCDB_GAXD_GEO { /* 3/ID  Geometric properties */
int     m_iln;                   /*        Code of geometry */
#define GAXD_GEO_DEFAULT 181
#define GAXD_GEO_PROJECT 182
int     m_id1;                   /*        reserved */
double  m_gpg;                   /* [1001] geometry parameter 1 */
double  m_gpa;                   /* [1001] geometry parameter 2 */
double  m_dd;                    /* [1001] arc length */
double  m_s1;                    /*        parameter s on start */
double  m_xyz1[3];               /* [1001] Ordinate of start */
double  m_dxyz1[3];              /*        Tangent of start */
double  m_rg1;                   /* [1009] in-plane curvature */
double  m_ra1;                   /* [1009] vertical curvature */
double  m_s2;                    /*        parameter s on end */
double  m_xyz2[3];               /* [1001] Ordinate of endpoint */
double  m_dxyz2[3];              /*        Tangent of endpoint */
double  m_rg2;                   /* [1009] in-plane curvature */
double  m_ra2;                   /* [1009] vertical curvature */
double  m_xat;                   /* [1001] relat. startordinate */
} typeCDB_GAXD_GEO;

#define GAXD_NKN_ID 190
#define GAXD_NKN_VER 201101
typedef struct tagCDB_GAXD_NKN { /* 3/ID  Knots of a Nurb */
int     m_iln;                   /*        ID=190 */
int     m_deg;                   /*        Order of Spline */
double  m_s[256];                /*        Knot-Vector */
} typeCDB_GAXD_NKN;

#define GAXD_CPT_ID 191
#define GAXD_CPT_VER 201101
typedef struct tagCDB_GAXD_CPT { /* 3/ID  Control point of a Nurb */
int     m_iln;                   /*        ID=191 */
int     m_id1;                   /*        reserved */
double  m_w;                     /*        Weight */
double  m_xyz[3];                /* [1001] Coordinates */
double  m_dir[3];                /*        upward direction */
} typeCDB_GAXD_CPT;

#define GAXD_PT_ID 192
#define GAXD_PT_VER 201101
typedef struct tagCDB_GAXD_PT {  /* 3/ID  Data point on curve */
int     m_iln;                   /*        ID=192 */
int     m_id1;                   /*        specification type */
double  m_s;                     /*        Parameter along curve */
double  m_xyz[3];                /* [1001] Coordinates */
double  m_dir[3];                /*        direction */
} typeCDB_GAXD_PT;

#define GAXD_ARC_ID 193
#define GAXD_ARC_VER 201101
typedef struct tagCDB_GAXD_ARC { /* 3/ID  Circular Arc */
int     m_iln;                   /*        ID=193 */
int     m_idf;                   /*        Definition selected */
double  m_r;                     /* [1001] Radius of arc */
double  m_xyz[3];                /* [1001] Coordinates of center */
double  m_dir[3];                /*        upward direction of plane */
double  m_xyza[3];               /* [1001] optional start point of arc */
double  m_xyze[3];               /* [1001] optional end point of arc */
} typeCDB_GAXD_ARC;

#define AXIS_TRL_ID 300
#define AXIS_TRL_VER 200601
typedef struct tagCDB_AXIS_TRL { /* 3/ID  Properties for train loading */
int     m_id0;                   /*        ident 300 */
int     m_nra;                   /*        Number of the lane (0:99) */
int     m_nrs;                   /*        Number of the segment */
chr     m_btyp;                  /*        Literal of default type */
float   m_sa;                    /*        Parameter s of start of this section */
float   m_se;                    /*        Parameter s of end of this section */
float   m_yca;                   /* [1001] Center ordinate of lane at SA */
float   m_yce;                   /* [1001] Center ordinate of lane at SE */
float   m_yra;                   /* [1001] Right boundary at SA of lane area */
float   m_yre;                   /* [1001] Right boundary at SE of lane area */
float   m_yla;                   /* [1001] Left boundary at SA of lane area */
float   m_yle;                   /* [1001] Left boundary at SE of lane area */
float   m_l;                     /* [1001] Reference length for impact factor */
float   m_hsa;                   /* [1001] Total height of traffic lane above axis at SA */
float   m_hse;                   /* [1001] Total height of traffic lane above axis at SE */
float   m_inca;                  /* [   5] Inclination within lane at SA */
float   m_ince;                  /* [   5] Inclination within lane at SE */
float   m_heff;                  /* [1001] Height of rail and sleeper construction */
float   m_beff;                  /* [1001] Effective length of sleeper */
float   m_deff;                  /* [1001] Width of sleepers */
float   m_incd;                  /*        Inclination of load distribution (e.g. 1:4) */
float   m_asl;                   /* [1001] Distance of Sleepers or mounting points */
} typeCDB_AXIS_TRL;

#define AREA_ID 0
#define AREA_VER 200704
typedef struct tagCDB_AREA {     /* 5/ID  Geometric Area */
int     m_id0;                   /*        identifier 0 */
int     m_ng;                    /*        Type of surface representation */
chr     m_gid1;                  /*        Axis identifier of first reference axis */
chr     m_gid2;                  /*        Axis identifier of second reference axis */
int     m_mgri;                  /*        number of data/control points in s of mesh */
int     m_ngri;                  /*        number of data/control points in t of mesh */
int     m_mspl;                  /*        degree of B-spline in s direction */
int     m_nspl;                  /*        degree of B-spline in t direction */
int     m_sflg;                  /*        property options of surface */
float   m_t[4][3];               /*        Transformation */
float   m_par[16];               /*        additional Parameters */
float   m_box[3][2];             /* [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax */
pckcode m_text[17];              /*        Designation of Line */
#define AREA_TEXT_LEN 32
} typeCDB_AREA;

#define AREA_CPT_ID 10
#define AREA_CPT_VER 200704
typedef struct tagCDB_AREA_CPT { /* 5/ID  Control points of area */
int     m_id;                    /*        Identification of control point data = 10 */
float   m_xpar[1];               /*        spline grid and coefficients */
                                 /*        unknown length! */
#define ANZOF_AREA_CPT_XPAR(il) ((il)-offsetof(typeCDB_AREA_CPT,m_xpar))/sizeof(float)
} typeCDB_AREA_CPT;

#define AREA_PTS_ID 11
#define AREA_PTS_VER 200704
typedef struct tagCDB_AREA_PTS { /* 5/ID  AreaPointonSurface */
int     m_id;                    /*        Identification of surface description = 11 */
int     m_it;                    /*        Type of point */
int     m_m;                     /*        Rasterlocation of mesh (0 < m < mgri ) */
int     m_n;                     /*        Rasterlocation of mesh (0 < n < ngri ) */
float   m_w;                     /*        the weight of NURBS control point */
float   m_x;                     /* [1001] X-ordinate */
float   m_y;                     /* [1001] Y-ordinate */
float   m_z;                     /* [1001] Z-ordinate */
float   m_t;                     /* [1010] Thickness */
} typeCDB_AREA_PTS;

#define AREA_CPI_ID 12
#define AREA_CPI_VER 200702
typedef struct tagCDB_AREA_CPI { /* 5/ID  COONsPatchInfo */
int     m_id;                    /*        Identification of COONs blending edges 12 */
int     m_it;                    /*        Type of blending */
int     m_iu0;                   /*        No of geometry line for u=umin (left) */
int     m_iu1;                   /*        No of geometry line for u=umax (right) */
int     m_iv0;                   /*        No of geometry line for v=vmin (lower) */
int     m_iv1;                   /*        No of geometry line for v=vmax (upper) */
float   m_sp[4][3];              /*        Length parameters for the edges iu0,iu1,iv0,iv1 */
float   m_uv[2][2];              /*        umin,umax,vmin,vmax of the parameter plane */
float   m_cxyz[4][3];            /*        Coordinates of the corner points C1,C2,C3,C4 */
float   m_tinc[8][3];            /*        inclinations for a bicubic patch as vectors */
float   m_twist[4][3];           /*        Twist of x,y,z-Ordinate at corner C1 (0,0) */
} typeCDB_AREA_CPI;

#define AREA_NKN_VER 200705
typedef struct tagCDB_AREA_NKN { /* 5/ID  Knots of a Nurb */
int     m_iln;                   /*        ID */
int     m_deg;                   /*        Order of Spline */
float   m_s[256];                /*        Knot-Vector */
} typeCDB_AREA_NKN;

#define GARD_PTS_ID 290
#define GARD_PTS_VER 201001
typedef struct tagCDB_GARD_PTS { /* 5/ID  AreaPointonSurface */
int     m_id;                    /*        Id = 290 */
int     m_it;                    /*        Type of point */
int     m_m;                     /*        Rasterlocation of mesh (0 < m < mgri ) */
int     m_n;                     /*        Rasterlocation of mesh (0 < n < ngri ) */
double  m_w;                     /*        the weight of NURBS control point */
double  m_x;                     /* [1001] X-ordinate */
double  m_y;                     /* [1001] Y-ordinate */
double  m_z;                     /* [1001] Z-ordinate */
double  m_t;                     /* [1010] Thickness */
} typeCDB_GARD_PTS;

#define GARD_NKU_ID 291
#define GARD_NKU_VER 201101
typedef struct tagCDB_GARD_NKU { /* 5/ID  Knots of a Nurb */
int     m_iln;                   /*        ID */
int     m_deg;                   /*        Order of Spline */
double  m_s[256];                /*        Knot-Vector */
} typeCDB_GARD_NKU;

#define GARD_NKV_ID 292
#define GARD_NKV_VER 201101
typedef struct tagCDB_GARD_NKV { /* 5/ID  Knots of a Nurb */
int     m_iln;                   /*        ID */
int     m_deg;                   /*        Order of Spline */
double  m_s[256];                /*        Knot-Vector */
} typeCDB_GARD_NKV;

#define GEO_ITRAX_NODE 0
#define GEO_ITRAX_LINE 4
#define GEO_ITRAX_AREA 8
#define GEO_ITRAX_NONE 0
#define GEO_ITRAX_YZ 1
#define GEO_ITRAX_ZX 2
#define GEO_ITRAX_XY 3
#define GEO_ITRAX_ZY 4
#define GEO_ITRAX_XZ 5
#define GEO_ITRAX_YX 6
#define GEO_ITRAX_POSX 7
#define GEO_ITRAX_POSY 8
#define GEO_ITRAX_POSZ 9
#define GEO_ITRAX_NEGX 10
#define GEO_ITRAX_NEGY 11
#define GEO_ITRAX_NEGZ 12
#define GEO_ITRAX_RADI 13
#define GEO_ITRAX_TANG 14
#define GEO_ITRAX_STRU 15
#define GEO_ITRAX_DROT 16
#define GLN_MATC_VER 201301
typedef struct tagCDB_GLN_MATC { /* 31/0  Heritage of Structural lines */
int     m_nr;                    /*        original structural line number */
int     m_ids[1];                /*        sequence of sub-lines */
                                 /*        unknown length! */
#define ANZOF_GLN_MATC_IDS(il) ((il)-offsetof(typeCDB_GLN_MATC,m_ids))/sizeof(int)
} typeCDB_GLN_MATC;

#define GAR_MATC_VER 201301
typedef struct tagCDB_GAR_MATC { /* 32/0  Heritage of Structural Areas */
int     m_nr;                    /*        original structural area number */
int     m_ids[1];                /*        list of sub-areas */
                                 /*        unknown length! */
#define ANZOF_GAR_MATC_IDS(il) ((il)-offsetof(typeCDB_GAR_MATC,m_ids))/sizeof(int)
} typeCDB_GAR_MATC;

#define SPT_ID 0
#define SPT_VER 201303
typedef struct tagCDB_SPT {      /* 39/NR  Structural points */
int     m_id;                    /*        identifier 0 */
int     m_ids;                   /*        optional identifier of point */
int     m_ref;                   /*        reserved reference */
int     m_nog;                   /*        reserved number of group */
int     m_nom;                   /*        reserved number of material */
int     m_nor;                   /*        reserved number of reinforc. */
int     m_ibt;                   /*        Bitpattern of element properties */
int     m_ibc;                   /*        Boundary condition */
int     m_i_8;                   /*        reserved */
int     m_i_9;                   /*        reserved */
float   m_xyz[3];                /* [1001] Coordinates of that point */
float   m_t[3][3];               /*        transformation matrix */
float   m_bx;                    /* [1001] Dimension in local x */
float   m_by;                    /* [1001] Dimension in local y */
float   m_thick;                 /* [1010] Plate thickness at that point */
float   m_hmesh;                 /* [1001] Mesh density at point */
float   m_res[3];                /*        reserved */
pckcode m_text[17];              /*        Designation of Point */
#define SPT_TEXT_LEN 32
} typeCDB_SPT;

#define SLN_ID 100
#define SLN_VER 201303
typedef struct tagCDB_SLN {      /* 39/NR  Structural lines */
int     m_id;                    /*        identifier 100 */
int     m_ids;                   /*        optional identifier of structural line */
int     m_ref;                   /*        reference identifier to a given GAX [chr] or sln [int] */
int     m_sref;                  /*        secondary axis enum for GAX references */
int     m_na;                    /*        optional identifier of line start point */
int     m_nb;                    /*        optional identifier of line end point */
int     m_ibt;                   /*        Bitpattern of element properties */
int     m_ibc;                   /*        primary boundary condition */
int     m_id8;                   /*        reserved */
int     m_id9;                   /*        reserved */
float   m_hmesh;                 /* [1001] >0.0 = mesh density along line */
float   m_tup[3];                /*        Vector to define downward direction */
float   m_trot;                  /*        Fractional rotation about local x-axis  (obsoleted => :101/:102 */
float   m_tal[3];                /*        Vector to be aligned as local axis      (obsoleted => :101/:102 */
float   m_prog;                  /*        progression factor (>0 monoton, <0 symmetric) */
float   m_r10;                   /*        reserved */
float   m_r11;                   /*        reserved */
float   m_r12;                   /*        reserved */
float   m_r13;                   /*        reserved */
float   m_r14;                   /*        reserved */
float   m_r15;                   /*        reserved */
pckcode m_text[17];              /*        Designation of Line */
#define SLN_TEXT_LEN 32
} typeCDB_SLN;

#define SLN_BEAM_ID 101
#define SLN_BEAM_VER 200701
typedef struct tagCDB_SLN_BEAM { /* 39/NR  Properties of beams */
int     m_id;                    /*        ident 101 */
int     m_typ;                   /*        Element type (see 009/NR:90:4 IBTYP) */
#define SLN_BEAM_NONE -1
#define SLN_BEAM_CENTRIC 0
#define SLN_BEAM_REFERENCE 1
#define SLN_BEAM_TRUSS 2
#define SLN_BEAM_CABLE 3
#define SLN_BEAM_CCOLUMN 4
#define SLN_BEAM_COLUMN 5
#define SLN_BEAM_SECTION 7
int     m_nog;                   /*        group number */
int     m_nq[2];                 /*        number cross section start/end */
int     m_np;                    /*        number bedding props */
int     m_ibc[4];                /*        Hinge properties A/E/XA/XE (start/end/internal start/end) */
int     m_div;                   /*        type of element subdivision */
float   m_kr;                    /*        identifier of local coordinate system orientation */
float   m_r12;
float   m_r13;
float   m_r14;
float   m_r15;
float   m_exa;                   /* [1001] eccentricity at start */
float   m_eya;                   /* [1001] eccentricity at start */
float   m_eza;                   /* [1001] eccentricity at start */
float   m_exe;                   /* [1001] eccentricity at end */
float   m_eye;                   /* [1001] eccentricity at end */
float   m_eze;                   /* [1001] eccentricity at end */
float   m_trot;                  /*        additional rotation about local x-axis, given as fraction of 36 */
float   m_tal[3];                /*        vector defining the orientation of the local z-axis of the loca */
} typeCDB_SLN_BEAM;

#define GLN_BPRO_ID 101
#define GLN_BPRO_VER 200701
typedef struct tagCDB_GLN_BPRO { /* 31/NR  Properties of beams */
int     m_id;                    /*        ident 101 */
int     m_typ;                   /*        Element type (see 009/NR:90:4 IBTYP) */
int     m_nog;                   /*        group number */
int     m_nq[2];                 /*        number cross section start/end */
int     m_np;                    /*        number bedding props */
int     m_ibc[4];                /*        Hinge properties A/E/XA/XE (start/end/internal start/end) */
int     m_div;                   /*        type of element subdivision */
float   m_kr;                    /*        identifier of local coordinate system orientation */
float   m_r12;
float   m_r13;
float   m_r14;
float   m_r15;
float   m_exa;                   /* [1001] eccentricity at start */
float   m_eya;                   /* [1001] eccentricity at start */
float   m_eza;                   /* [1001] eccentricity at start */
float   m_exe;                   /* [1001] eccentricity at end */
float   m_eye;                   /* [1001] eccentricity at end */
float   m_eze;                   /* [1001] eccentricity at end */
float   m_trot;                  /*        additional rotation about local x-axis, given as fraction of 36 */
float   m_tal[3];                /*        vector defining the orientation of the local z-axis of the loca */
} typeCDB_GLN_BPRO;

#define SLN_SUPP_ID 102
#define SLN_SUPP_VER 200808
typedef struct tagCDB_SLN_SUPP { /* 39/NR  Support of Structural lines */
int     m_id;                    /*        identifier 102 */
int     m_ids;                   /*        type of reference */
int     m_ref;                   /*        reference identifier */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_ibc;                   /*        Boundary condition / kinematic constraints */
int     m_kr;                    /*        local orientation */
float   m_w;                     /* [1001] width of support */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
float   m_cm;                    /* [1099] torsional bedding */
float   m_drx;                   /*        explicit X direction of support */
float   m_dry;                   /*        explicit Y direction of support */
float   m_drz;                   /*        explicit Z direction of support */
float   m_d;                     /* [1001] distance to coupled line (IDS={5,6,7}) */
float   m_r8;
float   m_r9;
float   m_fka;                   /*        factor bedding at start */
float   m_fke;                   /*        factor bedding at end */
float   m_trot;                  /*        Fractional rotation about local x-axis */
float   m_tal[3];                /*        Vector to be aligned as local axis */
} typeCDB_SLN_SUPP;

#define GLN_SUPP_ID 102
#define GLN_SUPP_VER 200808
typedef struct tagCDB_GLN_SUPP { /* 31/NR  Support of Structural lines */
int     m_id;                    /*        identifier 102 */
int     m_ids;                   /*        type of reference */
int     m_ref;                   /*        reference identifier */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_ibc;                   /*        Boundary condition / kinematic constraints */
int     m_kr;                    /*        local orientation */
float   m_w;                     /* [1001] width of support */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
float   m_cm;                    /* [1099] torsional bedding */
float   m_drx;                   /*        explicit X direction of support */
float   m_dry;                   /*        explicit Y direction of support */
float   m_drz;                   /*        explicit Z direction of support */
float   m_d;                     /* [1001] distance to coupled line (IDS={5,6,7}) */
float   m_r8;
float   m_r9;
float   m_fka;                   /*        factor bedding at start */
float   m_fke;                   /*        factor bedding at end */
float   m_trot;                  /*        Fractional rotation about local x-axis */
float   m_tal[3];                /*        Vector to be aligned as local axis */
} typeCDB_GLN_SUPP;

#define SLN_EXYZ_ID 120
#define SLN_EXYZ_VER 201301
typedef struct tagCDB_SLN_EXYZ { /* 39/NR  Explicit nodes on lines */
int     m_id;                    /*        identifier = 120 */
int     m_id1;                   /*        reserved */
float   m_xyz[64][3];            /* [1001] XYZ coordinates */
} typeCDB_SLN_EXYZ;

#define GLN_EXYZ_ID 120
#define GLN_EXYZ_VER 201301
typedef struct tagCDB_GLN_EXYZ { /* 31/NR  Explicit nodes on lines */
int     m_id;                    /*        identifier = 120 */
int     m_id1;                   /*        reserved */
float   m_xyz[64][3];            /* [1001] XYZ coordinates */
} typeCDB_GLN_EXYZ;

#define SLN_SCT_ID 130
#define SLN_SCT_VER 201405
typedef struct tagCDB_SLN_SCT {  /* 39/NR  Beams sections */
int     m_id;                    /*        identifier = 130 */
int     m_reft;                  /*        Type of reference */
int     m_ityp;                  /*        Bitcodes according 100/NR:0 ITYP */
int     m_i1;                    /*        reserved */
float   m_s;                     /* [1001] location on geometry */
} typeCDB_SLN_SCT;

#define GLN_SCT_ID 130
#define GLN_SCT_VER 201405
typedef struct tagCDB_GLN_SCT {  /* 31/NR  Beams sections */
int     m_id;                    /*        identifier = 130 */
int     m_reft;                  /*        Type of reference */
int     m_ityp;                  /*        Bitcodes according 100/NR:0 ITYP */
int     m_i1;                    /*        reserved */
float   m_s;                     /* [1001] location on geometry */
} typeCDB_GLN_SCT;

#define SAR_ID 200
#define SAR_VER 200808
typedef struct tagCDB_SAR {      /* 39/NR  Structural area */
int     m_id;                    /*        identification of general data = 200 */
int     m_ids;                   /*        identifier of structural area (0=auto) */
int     m_ref;                   /*        reference to a given GAR [chr] or SAR [int] */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_nor;                   /*        number of reinforc. */
int     m_itp;                   /*        Bitpattern for element generation QUAD */
int     m_ibc;                   /*        Boundary condition */
int     m_kr;                    /*        local orientation QUADs */
int     m_iatr;                  /*        Bitpattern for attribut areas (see SBOX_PROP) */
float   m_td[5];                 /* [1010] Constant thickness */
float   m_cb;                    /*        bedding factor */
float   m_cq;                    /*        tangential bedding factor */
float   m_tup[3];                /*        Vector to define upward direction */
float   m_trot;                  /*        Fractional rotation about local z-axis */
float   m_tal[3];                /*        Vector to be aligned as local axis */
float   m_h[7];                  /* [1001] mesh density parameters */
pckcode m_text[17];              /*        Designation of surface */
#define SAR_TEXT_LEN 32
} typeCDB_SAR;

#define SAR_INF_ID 210
#define SAR_INF_VER 200808
typedef struct tagCDB_SAR_INF {  /* 39/NR  GeometricAreaInfo */
int     m_id0;                   /*        identifier 210 */
int     m_ng;                    /*        Type of surface representation */
chr     m_gid1;                  /*        Axis identifier of first reference axis */
chr     m_gid2;                  /*        Axis identifier of second reference axis */
float   m_t[4][3];               /*        Transformation */
float   m_uv[2][2];              /*        umin,umax,vmin,vmax of the parameter plane */
} typeCDB_SAR_INF;

#define SAR_PTS_ID 211
#define SAR_PTS_VER 200808
typedef struct tagCDB_SAR_PTS {  /* 39/NR  AreaPointonSurface */
int     m_id;                    /*        Identifier 211 */
int     m_it;                    /*        Type of point (see 5/ID:11 for more) */
int     m_m;                     /*        Rasterlocation of mesh (0 < m < mgri ) */
int     m_n;                     /*        Rasterlocation of mesh (0 < n < ngri ) */
float   m_w;                     /*        the weight of NURBS control point */
float   m_x;                     /* [1001] X-ordinate */
float   m_y;                     /* [1001] Y-ordinate */
float   m_z;                     /* [1001] Z-ordinate */
float   m_t;                     /* [1010] Thickness */
} typeCDB_SAR_PTS;

#define SAR_CPI_ID 212
#define SAR_CPI_VER 200702
typedef struct tagCDB_SAR_CPI {  /* 39/NR  COONsPatchInfo */
int     m_id;                    /*        Id = 212 */
int     m_it;                    /*        Type of blending */
int     m_iu0;                   /*        No of geometry line for u=umin (left) */
int     m_iu1;                   /*        No of geometry line for u=umax (right) */
int     m_iv0;                   /*        No of geometry line for v=vmin (lower) */
int     m_iv1;                   /*        No of geometry line for v=vmax (upper) */
} typeCDB_SAR_CPI;

#define SAR_EXYZ_ID 220
#define SAR_EXYZ_VER 201301
typedef struct tagCDB_SAR_EXYZ { /* 39/NR  Explicit QUAD nodes on area */
int     m_id;                    /*        identifier = 220 */
int     m_id1;                   /*        reserved */
float   m_xyz[4][3];             /* [1001] XYZ coordinates */
} typeCDB_SAR_EXYZ;

#define GAR_EXYZ_ID 220
#define GAR_EXYZ_VER 201301
typedef struct tagCDB_GAR_EXYZ { /* 32/NR  Explicit QUAD nodes on area */
int     m_id;                    /*        identifier = 220 */
int     m_id1;                   /*        reserved */
float   m_xyz[4][3];             /* [1001] XYZ coordinates */
} typeCDB_GAR_EXYZ;

#define SAR_SUPP_ID 221
#define SAR_SUPP_VER 201408
typedef struct tagCDB_SAR_SUPP { /* 39/NR  Support and coupling of structural areas */
int     m_id;                    /*        identifier 221 */
int     m_ids;                   /*        type of reference */
int     m_ref;                   /*        reference identifier */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_ibc;                   /*        Boundary condition / kinematic constraints */
int     m_i6;                    /*        reserved */
int     m_rctl;                  /*        properties of area-area reference */
int     m_rptr;                  /*        reference point on boundary of referenced area */
int     m_rpt0;                  /*        reference point on boundary of given area */
int     m_i10;                   /*        reserved */
float   m_d;                     /* [1001] distance of interface layer */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
} typeCDB_SAR_SUPP;

#define GAR_SUPP_ID 221
#define GAR_SUPP_VER 201408
typedef struct tagCDB_GAR_SUPP { /* 32/NR  Support and coupling of structural areas */
int     m_id;                    /*        identifier 221 */
int     m_ids;                   /*        type of reference */
int     m_ref;                   /*        reference identifier */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_ibc;                   /*        Boundary condition / kinematic constraints */
int     m_i6;                    /*        reserved */
int     m_rctl;                  /*        properties of area-area reference */
int     m_rptr;                  /*        reference point on boundary of referenced area */
int     m_rpt0;                  /*        reference point on boundary of given area */
int     m_i10;                   /*        reserved */
float   m_d;                     /* [1001] distance of interface layer */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
} typeCDB_GAR_SUPP;

#define SVO_ID 300
#define SVO_VER 200808
typedef struct tagCDB_SVO {      /* 39/NR  StructuralVolume */
int     m_id;                    /*        identification = 300 */
int     m_ids;                   /*        identifier of structural area (0=auto) */
int     m_ref;                   /*        reference to a given GVO (reserved) */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_nor;                   /*        number of reinforc. */
int     m_not;                   /*        number of elementtype */
int     m_ibc;                   /*        Boundary condition */
int     m_id8;                   /*        reserved */
int     m_id9;                   /*        reserved */
pckcode m_text[17];              /*        Designation of Volume */
#define SVO_TEXT_LEN 32
} typeCDB_SVO;

#define SMB_ATTR_ID 997
#define SMB_ATTR_VER 201607
typedef struct tagCDB_SMB_ATTR { /* 39/NR  Attributes of structural member */
int     m_id;                    /*        identifier 997 */
int     m_i1;                    /*        reserved */
int     m_i2;                    /*        reserved */
chr     m_grxa;                  /*        identifier of 1st grid axis x-x */
chr     m_grya;                  /*        identifier of 2nd grid axis y-y */
chr     m_elvb;                  /*        identifier of elevation at bottom */
chr     m_elvt;                  /*        identifier of elevation at top */
chr     m_dpos;                  /*        Identifier of design group membership */
pckcode m_dtxt[17];              /*        Designation of design group membership */
#define SMB_ATTR_DTXT_LEN 32
} typeCDB_SMB_ATTR;

#define SPT_ATTR_ID 997
#define SPT_ATTR_VER 0
typedef struct tagCDB_SPT_ATTR { /* 30/NR  Attributes of structural member */
int     m_id;                    /*        identifier 997 */
int     m_i1;                    /*        reserved */
int     m_i2;                    /*        reserved */
chr     m_grxa;                  /*        identifier of 1st grid axis x-x */
chr     m_grya;                  /*        identifier of 2nd grid axis y-y */
chr     m_elvb;                  /*        identifier of elevation at bottom */
chr     m_elvt;                  /*        identifier of elevation at top */
chr     m_dpos;                  /*        Identifier of design group membership */
pckcode m_dtxt[17];              /*        Designation of design group membership */
#define SPT_ATTR_DTXT_LEN 32
} typeCDB_SPT_ATTR;

#define SLN_ATTR_ID 997
#define SLN_ATTR_VER 0
typedef struct tagCDB_SLN_ATTR { /* 31/NR  Attributes of structural member */
int     m_id;                    /*        identifier 997 */
int     m_i1;                    /*        reserved */
int     m_i2;                    /*        reserved */
chr     m_grxa;                  /*        identifier of 1st grid axis x-x */
chr     m_grya;                  /*        identifier of 2nd grid axis y-y */
chr     m_elvb;                  /*        identifier of elevation at bottom */
chr     m_elvt;                  /*        identifier of elevation at top */
chr     m_dpos;                  /*        Identifier of design group membership */
pckcode m_dtxt[17];              /*        Designation of design group membership */
#define SLN_ATTR_DTXT_LEN 32
} typeCDB_SLN_ATTR;

#define SAR_ATTR_ID 997
#define SAR_ATTR_VER 0
typedef struct tagCDB_SAR_ATTR { /* 32/NR  Attributes of structural member */
int     m_id;                    /*        identifier 997 */
int     m_i1;                    /*        reserved */
int     m_i2;                    /*        reserved */
chr     m_grxa;                  /*        identifier of 1st grid axis x-x */
chr     m_grya;                  /*        identifier of 2nd grid axis y-y */
chr     m_elvb;                  /*        identifier of elevation at bottom */
chr     m_elvt;                  /*        identifier of elevation at top */
chr     m_dpos;                  /*        Identifier of design group membership */
pckcode m_dtxt[17];              /*        Designation of design group membership */
#define SAR_ATTR_DTXT_LEN 32
} typeCDB_SAR_ATTR;

#define SMB_GUID_ID 999
#define SMB_GUID_VER 0
typedef struct tagCDB_SMB_GUID { /* 39/NR  Unique identifier of structural member */
int     m_id;                    /*        identifier 999 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of preceeding element */
} typeCDB_SMB_GUID;

#define SPT_GUID_ID 999
#define SPT_GUID_VER 0
typedef struct tagCDB_SPT_GUID { /* 30/NR  Unique identifier of structural member */
int     m_id;                    /*        identifier 999 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of preceeding element */
} typeCDB_SPT_GUID;

#define SLN_GUID_ID 999
#define SLN_GUID_VER 0
typedef struct tagCDB_SLN_GUID { /* 31/NR  Unique identifier of structural member */
int     m_id;                    /*        identifier 999 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of preceeding element */
} typeCDB_SLN_GUID;

#define SAR_GUID_ID 999
#define SAR_GUID_VER 0
typedef struct tagCDB_SAR_GUID { /* 32/NR  Unique identifier of structural member */
int     m_id;                    /*        identifier 999 */
chr     m_idbim[36];             /*        256 Bit GUId Identifier of preceeding element */
} typeCDB_SAR_GUID;

#define GPT_ID 0
#define GPT_VER 201303
typedef struct tagCDB_GPT {      /* 30/NR  Structural points */
int     m_id;                    /*        identifier 0 (always the first record) */
int     m_ibc;                   /*        Boundary condition */
#define GPT_IBC_SUP 8192
#define GPT_IBC_REF 32768
float   m_xyz[3];                /* [1001] Ordinates */
float   m_t[3][3];               /*        transformation matrix */
float   m_bx;                    /* [1001] Dimension in x */
float   m_by;                    /* [1001] Dimension in y */
float   m_thick;                 /* [1010] Plate thickness */
float   m_hmesh;                 /* [1001] Mesh density at point */
float   m_r17;                   /*        reserved */
pckcode m_text[17];              /*        Designation of Point */
#define GPT_TEXT_LEN 32
} typeCDB_GPT;

#define GPT_COH_ID 1
#define GPT_COH_VER 200501
typedef struct tagCDB_GPT_COH {  /* 30/NR  Dimension of column head */
int     m_id;                    /*        identifier 1/2/3 */
int     m_ns;                    /*        Number of a cross section 9/NR for details */
float   m_x;                     /* [1001] Width in local x */
float   m_y;                     /* [1001] Width in local y */
float   m_a;                     /* [1002] Equivalent Area */
float   m_t;                     /* [1010] Plate thickness */
} typeCDB_GPT_COH;

#define GPT_HAU_ID 2
#define GPT_HAU_VER 200501
typedef struct tagCDB_GPT_HAU {  /* 30/NR  Dimension of voute */
int     m_id;                    /*        identifier 1/2/3 */
int     m_ns;                    /*        Number of a cross section 9/NR for details */
float   m_x;                     /* [1001] Width in local x */
float   m_y;                     /* [1001] Width in local y */
float   m_a;                     /* [1002] Equivalent Area */
float   m_t;                     /* [1010] Plate thickness */
} typeCDB_GPT_HAU;

#define GPT_PUN_ID 3
#define GPT_PUN_VER 200501
typedef struct tagCDB_GPT_PUN {  /* 30/NR  Dimension of punching perimeter */
int     m_id;                    /*        identifier 1/2/3 */
int     m_ns;                    /*        Number of a cross section 9/NR for details */
float   m_x;                     /* [1001] Width in local x */
float   m_y;                     /* [1001] Width in local y */
float   m_a;                     /* [1002] Equivalent Area */
float   m_t;                     /* [1010] Plate thickness */
} typeCDB_GPT_PUN;

#define GPT_COL_ID 4
#define GPT_COL_VER 200501
typedef struct tagCDB_GPT_COL {  /* 30/NR  Connecting columns */
int     m_id;                    /*        identifier 4 */
int     m_ns;                    /*        Number of a cross section 9/NR for column */
float   m_x;                     /* [1001] Width in local x */
float   m_y;                     /* [1001] Width in local y */
float   m_a;                     /* [1002] Equivalent Area */
float   m_l;                     /* [1001] Column length */
float   m_fak;                   /*        Rigidity factor */
} typeCDB_GPT_COL;

#define GPT_FOO_ID 5
#define GPT_FOO_VER 201411
typedef struct tagCDB_GPT_FOO {  /* 30/NR  Footing instance definition */
int     m_id;                    /*        identifier 5 */
chr     m_pos;                   /*        referenced building position */
int     m_type;                  /*        Type of foundation */
int     m_igp;                   /*        Bitpattern Foundation Properties */
int     m_idr;                   /*        Bitpattern Design Results */
int     m_ir1;                   /*        reserved */
int     m_mno;                   /*        Id of concrete material */
int     m_mrf;                   /*        Id of reinforcement material */
int     m_nrsp;                  /*        Id of soil profile (002/NR) */
float   m_t[3][3];               /*        Orientation of local coordinate system */
float   m_bx;                    /* [1001] Width in local x */
float   m_by;                    /* [1001] Width in local y */
float   m_hi;                    /* [1001] inner Thickness */
float   m_ha;                    /* [1001] outer Thickness */
float   m_ex;                    /* [1001] Eccentricity of column in local x-direction */
float   m_ey;                    /* [1001] Eccentricity of column in local y-direction */
float   m_ez;                    /* [1001] Eccentricity of endpoint of column(=structural point) in local  */
float   m_clx;                   /* [1011] Assumed dimension of column in local x-direction */
float   m_cly;                   /* [1011] Assumed dimension of column in local y-direction */
float   m_sxt;                   /* [1024] Boundary distance of x-aligned reinforcement on top face */
float   m_syt;                   /* [1024] Boundary distance of y-aligned reinforcement on top face */
float   m_sxb;                   /* [1024] Boundary distance of x-aligned reinforcement on bottom face */
float   m_syb;                   /* [1024] Boundary distance of y-aligned reinforcement on bottom face */
float   m_covt;                  /* [1024] Concrete cover (nominal) on top face */
float   m_covb;                  /* [1024] Concrete cover (nominal) on bottom face */
float   m_covl;                  /* [1024] Concrete cover (nominal) on lateral faces */
float   m_res1;                  /*        Reserved */
float   m_res2;                  /*        Reserved */
float   m_res3;                  /*        Reserved */
float   m_res4;                  /*        Reserved */
float   m_slho;                  /* [1001] obsolete */
float   m_slhi;                  /* [1001] obsolete */
float   m_slwx;                  /* [1001] obsolete */
float   m_slwy;                  /* [1001] obsolete */
float   m_slgu;                  /* [1001] obsolete */
float   m_slgl;                  /* [1001] obsolete */
float   m_data[12];              /*        Reserved */
pckcode m_titl[17];              /*        Designation of Foundation */
#define GPT_FOO_TITL_LEN 32
} typeCDB_GPT_FOO;

#define GPT_FRR_ID 1005
#define GPT_FRR_VER 201411
typedef struct tagCDB_GPT_FRR {  /* 30/NR  Footing required reinforcement */
int     m_id;                    /*        identifier 1005 */
int     m_type;                  /*        Type of reinforcement */
int     m_n_as;                  /*        number of values stored in array AS */
int     m_ir1;                   /*        reserved */
int     m_ir2;                   /*        reserved */
float   m_xoff;                  /* [1001] offset of distribution in x-direction */
float   m_yoff;                  /* [1001] offset of distribution in y-direction */
float   m_res1;                  /*        reserved */
float   m_res2;                  /*        reserved */
float   m_as[32];                /* [1021] reinforcement values */
} typeCDB_GPT_FRR;

#define GPT_SLP_ID 1006
#define GPT_SLP_VER 201503
typedef struct tagCDB_GPT_SLP {  /* 30/NR  Sleeve foundation properties */
int     m_id;                    /*        identifier 1006 */
int     m_ir1;                   /*        reserved */
int     m_ir2;                   /*        reserved */
int     m_ir3;                   /*        reserved */
float   m_hswo;                  /* [1001] Outer height of sleeve wall (measured from z=0 of local coordin */
float   m_hswi;                  /* [1001] Inner height of sleeve wall (measured from upper face of sleeve */
float   m_wxwu;                  /* [1001] Upper width of sleeve wall in x-direction */
float   m_wywu;                  /* [1001] Upper width of sleeve wall in y-direction */
float   m_wxwl;                  /* [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l */
float   m_wywl;                  /* [1001] Lower width of sleeve wall in y-direction */
float   m_wxgu;                  /* [1001] Upper width of gap between wall and column in x-direction */
float   m_wygu;                  /* [1001] Upper width of gap between wall and column in y-direction */
float   m_wxgl;                  /* [1001] Lower width of gap between wall and column in x-direction */
float   m_wygl;                  /* [1001] Lower width of gap between wall and column in y-direction */
float   m_clx;                   /* [1011] Assumed dimension of column in local x-direction (deprecated) */
float   m_cly;                   /* [1011] Assumed dimension of column in local y-direction (deprecated) */
} typeCDB_GPT_SLP;

#define GPT_HPI_ID 6
#define GPT_HPI_VER 200501
typedef struct tagCDB_GPT_HPI {  /* 30/NR  Halfspace pile */
int     m_id;                    /*        identifier 6 */
int     m_nq;                    /*        number cross section   =0 if diameter from 030/NR:0 */
float   m_l;                     /* [1001] pile length in GDIR direction */
float   m_mant;                  /*        percentage of skin friction for linear analysis */
float   m_zman;                  /*        percentage of inactive skin length */
float   m_pman;                  /* [1151] maximum load skin friction (nonlinear analysis) */
float   m_pmaf;                  /* [1151] maximum load pile foot */
} typeCDB_GPT_HPI;

#define GPT_CON_ID 8
#define GPT_CON_VER 200501
typedef struct tagCDB_GPT_CON {  /* 30/NR  Steelconnection reference */
int     m_id;                    /*        identifier 8 */
chr     m_conid;                 /*        connection identifier */
struct {
int     m_nelt;
int     m_nrel;
int     m_node;
int     m_narb;
float   m_x;                     /* [1001]  */
      } m_m[15];                 /*        connected members */
} typeCDB_GPT_CON;

#define GPT_SPR_ID 10
#define GPT_SPR_VER 201307
typedef struct tagCDB_GPT_SPR {  /* 30/NR  Elastic Spring support */
int     m_id;                    /*        identifier 10 */
int     m_iri;                   /*        direction */
int     m_nr;                    /*        element number */
int     m_ng;                    /*        group number */
int     m_ipc;                   /*        connecting to node */
int     m_nwl;                   /*        Reference to work-law / material no */
float   m_t[3];                  /*        explicit direction (dx,dy,dz) */
float   m_aref;                  /*        reference / influence area (see also  184 170/0 ) */
float   m_cp;                    /* [1095] spring stiffness z */
float   m_cq;                    /* [1095] transverse stiff. */
float   m_cm;                    /* [1098] torsional stiff. */
float   m_pre;                   /*        prestress for cp */
float   m_gap;                   /*        slip of spring */
float   m_riss;                  /*        max tension force */
float   m_flie;                  /*        yielding load */
float   m_mue;                   /*        friction cross */
float   m_coh;                   /*        cohesion cross */
float   m_dil;                   /*        dilatancy factor */
float   m_gapq;                  /*        transverse slip/gap */
} typeCDB_GPT_SPR;

#define GPT_KIN_ID 11
#define GPT_KIN_VER 200501
typedef struct tagCDB_GPT_KIN {  /* 30/NR  Kinematic Constraint */
int     m_id;                    /*        identifier 11 */
int     m_ktl;                   /*        type +  10000*group-number */
int     m_kr1;                   /*        reference GPT 1 */
int     m_kr2;                   /*        reference GPT 2 */
float   m_dx;                    /*        direction of coupling X-axis */
float   m_dy;                    /*        direction of coupling Y-axis */
float   m_dz;                    /*        direction of coupling Z-axis */
float   m_dd;                    /*        factor of interpolation */
float   m_ff;                    /*        factor of multiplication */
} typeCDB_GPT_KIN;

#define GPT_SPC_ID 12
#define GPT_SPC_VER 200911
typedef struct tagCDB_GPT_SPC {  /* 30/NR  Elastic Spring connection (obsoleted) */
int     m_id;                    /*        identifier 12 */
int     m_iri;                   /*        direction + 100*sign(group number,direction) */
int     m_ipc;                   /*        connecting Spoint */
int     m_nwl;                   /*        work law number */
float   m_cp;                    /* [1095] spring stiffness z */
float   m_cq;                    /* [1095] transverse stiff. */
float   m_cm;                    /* [1098] torsional stiff. */
float   m_pre;                   /*        prestress for cp */
float   m_gap;                   /*        slip of spring */
float   m_riss;                  /*        max tension force */
float   m_flie;                  /*        yielding load */
float   m_mue;                   /*        friction cross */
float   m_coh;                   /*        cohesion cross */
float   m_dil;                   /*        dilatancy factor */
} typeCDB_GPT_SPC;

#define GPT_DADS_ID 998
#define GPT_DADS_VER 200808
typedef struct tagCDB_GPT_DADS { /* 30/NR  List of origin ids the structural member has been created from */
int     m_id;                    /*        ident 998 */
int     m_idd[63];               /*        ids of all anchestors */
} typeCDB_GPT_DADS;

#define GLN_ID 0
#define GLN_VER 201303
typedef struct tagCDB_GLN {      /* 31/NR  Structural lines */
int     m_id;                    /*        identifier 0 */
int     m_pt[2];                 /*        Number start & end point */
int     m_i3;                    /*        reserved */
int     m_ibt;                   /*        Bitpattern of element properties acc. 39/NR:100 IBT */
int     m_ibc;                   /*        Boundary condition acc. 39/NR:100 IBC */
float   m_i_0[10];               /*        reserved */
float   m_hmesh;                 /* [1001] mesh density along line acc. 39/NR:100 HMESH */
float   m_i_11[3];               /*        reserved */
float   m_prog;                  /*        progression factor (>0 monoton, <0 symmetric) */
float   m_i_15;
pckcode m_text[17];              /*        Designation of Line */
#define GLN_TEXT_LEN 32
} typeCDB_GLN;

#define GLN_REF_VER 200501
typedef struct tagCDB_GLN_REF {  /* 31/NR  Reference to another Geometry */
int     m_igm;                   /*        negative value of the master geometry */
int     m_igs;                   /*        optional identifier of a secondary axis */
float   m_smin;                  /*        min parameter on referenced axis */
float   m_smax;                  /*        max parameter on referenced axis */
} typeCDB_GLN_REF;

#define GLN_GEO_VER 200501
typedef struct tagCDB_GLN_GEO {  /* 31/NR  Geometric properties */
int     m_iln;                   /*        Code of geometry */
#define GLN_GEO_DEFAULT 1
#define GLN_GEO_KLOTOID 2
#define GLN_GEO_SPLINE 3
#define GLN_GEO_EXSPLI 4
#define GLN_GEO_BEZIER 5
#define GLN_GEO_NURBS 6
#define GLN_GEO_NURBX 7
#define GLN_GEO_DATA 8
#define GLN_GEO_NORM 9
#define GLN_GEO_CIRC 10
#define GLN_GEO_DWN_POSY +2
#define GLN_GEO_DWN_NEGY -2
#define GLN_GEO_DWN_POSZ +3
#define GLN_GEO_DWN_NEGZ -3
float   m_gpg;                   /* [1001] geometry parameter 1 */
float   m_gpa;                   /* [1001] geometry parameter 2 */
float   m_dd;                    /* [1001] arc length */
float   m_s1;                    /*        parameter s on start */
float   m_xyz1[3];               /* [1001] Ordinate of start */
float   m_dxyz1[3];              /*        Tangent of start */
float   m_rg1;                   /* [1009] in-plane curvature */
float   m_ra1;                   /* [1009] vertical curvature */
float   m_s2;                    /*        parameter s on end */
float   m_xyz2[3];               /* [1001] Ordinate of endpoint */
float   m_dxyz2[3];              /*        Tangent of endpoint */
float   m_rg2;                   /* [1009] in-plane curvature */
float   m_ra2;                   /* [1009] vertical curvature */
} typeCDB_GLN_GEO;

#define GLN_BEAM_ID 100
#define GLN_BEAM_VER 200501
typedef struct tagCDB_GLN_BEAM { /* 31/NR  Properties of beams (obsoleted) */
int     m_id;                    /*        ident 100 */
int     m_nog;                   /*        Element type */
int     m_nq;                    /*        number cross section */
int     m_np;                    /*        number bedding props */
int     m_ibc;                   /*        Hinge code */
#define GLN_BEAM_IBC_LOCAL 16384
#define GLN_BEAM_IBC_NFREE 32768
int     m_div;                   /*        prescribed subdivision no of segments */
float   m_eya;                   /* [1001] eccentricity at start */
float   m_eza;                   /* [1001] eccentricity at start */
float   m_eye;                   /* [1001] eccentricity at end */
float   m_eze;                   /* [1001] eccentricity at end */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
float   m_cm;                    /* [1099] torsional bedding */
float   m_cx;                    /* [1096] global X  bedding */
float   m_cy;                    /* [1096] global Y  bedding */
float   m_cz;                    /* [1096] global Z  bedding */
float   m_cxx;                   /* [1099] global X  tors.bed. */
float   m_cyy;                   /* [1099] global Y  tors.bed. */
float   m_czz;                   /* [1099] global Z  tors.bed. */
} typeCDB_GLN_BEAM;

#define GLN_ELNR_ID 121
#define GLN_ELNR_VER 201301
typedef struct tagCDB_GLN_ELNR { /* 31/NR  Elements generated on lines */
int     m_id;                    /*        identifier = 121 */
int     m_etyp;                  /*        Type of element {100,150,160,...} for {Beam,Truss,Cable,...} */
int     m_ibit;                  /*        Bit-code */
int     m_nr[253];               /*        packed list of element numbers */
} typeCDB_GLN_ELNR;

#define GLN_DADS_ID 998
#define GLN_DADS_VER 200808
typedef struct tagCDB_GLN_DADS { /* 31/NR  Ids of items being an anchestor */
int     m_id;                    /*        ident 998 */
int     m_idd[63];               /*        ids of all anchestors */
} typeCDB_GLN_DADS;

#define GAR_ID 0
#define GAR_VER 200501
typedef struct tagCDB_GAR {      /* 32/NR  Structural area */
int     m_id;                    /*        identification of general data (0) */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_nor;                   /*        number of reinforc. */
int     m_itp;                   /*        Bitpattern for element generation QUAD */
int     m_ibc;                   /*        Boundary condition */
#define GAR_IBC_REF 32768
float   m_td[5];                 /* [1010] Constant thickness */
float   m_cb;                    /*        bedding factor */
float   m_cq;                    /*        tangential bedding factor */
float   m_trot;                  /*        Fractional rotation about local z-axisBruchteil der 360-Grad Dr */
float   m_tal[3];                /*        Vector to be aligned as local axis */
pckcode m_text[17];              /*        Designation of surface */
#define GAR_TEXT_LEN 32
} typeCDB_GAR;

#define GAR_REF_VER 200501
typedef struct tagCDB_GAR_REF {  /* 32/NR  Reference to another Geometry */
int     m_igm;                   /*        negative value of the master geometry */
} typeCDB_GAR_REF;

#define GAR_BOUN_ID 1
#define GAR_BOUN_VER 200501
typedef struct tagCDB_GAR_BOUN { /* 32/NR  Outer Boundary of Area */
int     m_id;                    /*        identification */
int     m_ng;                    /*        edgeno     (31/NG) */
int     m_na;                    /*        startpoint (30/NA) */
int     m_nb;                    /*        endpoint   (30/NB) */
int     m_nm;                    /*        midpoint   (30/NM) */
int     m_ifc;                   /*        Interface hinge bit pattern */
float   m_t;                     /* [1010] Plate thickness of edge */
float   m_dfix;                  /* [1001] Distance (offset) of region to edge */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
float   m_cm;                    /* [1099] torsional bedding */
} typeCDB_GAR_BOUN;

#define GAR_HOLE_ID 2
#define GAR_HOLE_VER 200501
typedef struct tagCDB_GAR_HOLE { /* 32/NR  Inner Boundary of Area */
int     m_id;                    /*        identification */
int     m_ng;                    /*        edgeno     (31/NG) */
int     m_na;                    /*        startpoint (30/NA) */
int     m_nb;                    /*        endpoint   (30/NB) */
int     m_nm;                    /*        midpoint   (30/NM) */
int     m_ifc;                   /*        Interface hinge bit pattern */
float   m_t;                     /* [1010] Plate thickness of edge */
float   m_dfix;                  /* [1001] Distance (offset) of region to edge */
float   m_ca;                    /* [1096] axial     bedding */
float   m_cq;                    /* [1096] lateral   bedding */
float   m_cm;                    /* [1099] torsional bedding */
} typeCDB_GAR_HOLE;

#define GAR_CON3_ID 3
#define GAR_CON3_VER 200501
typedef struct tagCDB_GAR_CON3 { /* 32/NR  Prescribed Edges/Points */
int     m_id;                    /*        identification */
int     m_ng;                    /*        edgenumber (31/NG) */
int     m_na;                    /*        startpoint (30/NA) */
int     m_nb;                    /*        endpoint   (30/NB) */
int     m_nm;                    /*        midpoint   (30/NM) */
int     m_mat;                   /*        Materialnumber of subregion for ID==4 */
float   m_t;                     /* [1010] Plate thickness at edge or point */
} typeCDB_GAR_CON3;

#define GAR_CON4_ID 4
#define GAR_CON4_VER 200501
typedef struct tagCDB_GAR_CON4 { /* 32/NR  Domain-Subdivision-Edges */
int     m_id;                    /*        identification */
int     m_ng;                    /*        edgenumber (31/NG) */
int     m_na;                    /*        startpoint (30/NA) */
int     m_nb;                    /*        endpoint   (30/NB) */
int     m_nm;                    /*        midpoint   (30/NM) */
int     m_mat;                   /*        Materialnumber of subregion for ID==4 */
float   m_t;                     /* [1010] Plate thickness at edge or point */
} typeCDB_GAR_CON4;

#define GAR_MESH_ID 9
#define GAR_MESH_VER 201109
typedef struct tagCDB_GAR_MESH { /* 32/NR  Prescribed Mesh size */
int     m_id;                    /*        identification */
int     m_ng;                    /*        number of support macro generating mesh */
int     m_na;                    /*        startedge  (31/NA) */
int     m_nb;                    /*        endedge    (31/NB) */
int     m_i4;                    /*        not used */
int     m_i5;                    /*        not used */
float   m_hsize[3];              /* [1001] requested mesh size */
float   m_pta[3];                /* [1001] Coordinates of startpoint */
float   m_pte[3];                /* [1001] Coordinates of endpoint */
float   m_ptm[3];                /* [1001] Coordinates of midpoint */
} typeCDB_GAR_MESH;

#define GAR_GEO_ID 10
#define GAR_GEO_VER 200501
typedef struct tagCDB_GAR_GEO {  /* 32/NR  Geometry of surface */
int     m_id;                    /*        Identification of surface description 10 */
int     m_ng;                    /*        Type of surface representation */
int     m_mgri;                  /*        number of data/control points in s of mesh */
int     m_ngri;                  /*        number of data/control points in t of mesh */
int     m_mspl;                  /*        degree of B-spline in s direction */
int     m_nspl;                  /*        degree of B-spline in t direction */
float   m_sx;                    /*        plane  direction sx */
float   m_sy;                    /*        plane  direction sy */
float   m_sz;                    /*        plane  direction sz */
float   m_tx;                    /*        plane  direction tx */
float   m_ty;                    /*        plane  direction ty */
float   m_tz;                    /*        plane  direction tz */
float   m_nx;                    /*        normal direction nx */
float   m_ny;                    /*        normal direction ny */
float   m_nz;                    /*        normal direction nz */
float   m_x;                     /* [1001] X-ordinate Origin */
float   m_y;                     /* [1001] Y-ordinate Origin */
float   m_z;                     /* [1001] Z-ordinate Origin */
float   m_par[16];               /*        additional Parameters */
float   m_box[3][2];             /* [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax */
float   m_xpar[1];               /*        extended parameters */
                                 /*        unknown length! */
#define ANZOF_GAR_GEO_XPAR(il) ((il)-offsetof(typeCDB_GAR_GEO,m_xpar))/sizeof(float)
} typeCDB_GAR_GEO;

#define GAR_SURF_ID 11
#define GAR_SURF_VER 200501
typedef struct tagCDB_GAR_SURF { /* 32/NR  UserPointonSurface */
int     m_id;                    /*        Identification of user surface description 11 */
int     m_it;                    /*        Type of point */
int     m_m;                     /*        Rasterlocation of mesh 0 < m ( mgri ) */
int     m_n;                     /*        Rasterlocation of mesh 0 < n ( ngri ) */
int     m_n3;                    /*        the degree of the Spline becoming effective */
int     m_n4;                    /*        the weight of NURBS control point [-] */
float   m_x;                     /* [1001] X-ordinate */
float   m_y;                     /* [1001] Y-ordinate */
float   m_z;                     /* [1001] Z-ordinate */
float   m_t;                     /* [1010] Thickness */
} typeCDB_GAR_SURF;

#define GAR_COON_ID 12
#define GAR_COON_VER 201303
typedef struct tagCDB_GAR_COON { /* 32/NR  COONsPatchInfo */
int     m_id;                    /*        Identification of COONs blending edges 12 */
int     m_it;                    /*        Type of blending */
int     m_iu0;                   /*        No of geometry line for u=umin (left) */
int     m_iu1;                   /*        No of geometry line for u=umax (right) */
int     m_iv0;                   /*        No of geometry line for v=vmin (lower) */
int     m_iv1;                   /*        No of geometry line for v=vmax (upper) */
float   m_sp[4][3];              /*        Length parameters for the edges iu0,iu1,iv0,iv1 */
float   m_uv[2][2];              /*        umin,umax,vmin,vmax of the parameter plane */
float   m_cxyz[4][3];            /*        Coordinates of the corner points C1,C2,C3,C4 */
float   m_tinc[8][3];            /*        inclinations for a bicubic patch as vectors */
float   m_twist[4][3];           /*        Twist of x,y,z-Ordinate at corner C1 (0,0) */
} typeCDB_GAR_COON;

#define GAR_ELNR_ID 221
#define GAR_ELNR_VER 201301
typedef struct tagCDB_GAR_ELNR { /* 32/NR  Generated elements from area */
int     m_id;                    /*        identifier = 221 */
int     m_etyp;                  /*        Type of element {200,...} for {QUAD,...} */
int     m_id2;                   /*        reserved */
int     m_nr[253];               /*        packed list of element numbers */
} typeCDB_GAR_ELNR;

#define GAR_DADS_ID 998
#define GAR_DADS_VER 200808
typedef struct tagCDB_GAR_DADS { /* 32/NR  Ids of items being an anchestor */
int     m_id;                    /*        ident 998 */
int     m_idd[63];               /*        ids of all anchestors */
} typeCDB_GAR_DADS;

#define GVO_ID 0
#define GVO_VER 200501
typedef struct tagCDB_GVO {      /* 33/NR  StructuralVolume */
int     m_id;                    /*        identification of general data (0) */
int     m_nog;                   /*        number of group */
int     m_nom;                   /*        number of material */
int     m_nor;                   /*        number of reinforc. */
int     m_not;                   /*        number of elementtype */
int     m_ibc;                   /*        Boundary condition */
pckcode m_text[17];              /*        Designation of Volume */
#define GVO_TEXT_LEN 32
} typeCDB_GVO;

#define GVO_SURF_VER 200501
typedef struct tagCDB_GVO_SURF { /* 33/NR  Involved Surfaces */
int     m_itp;                   /*        identification of definition */
int     m_ng;                    /*        surface    (32/NG) */
int     m_nr;                    /*        extrusion or rotation geometry identifier */
int     m_nref;                  /*        optional number of a reference point */
int     m_nara;                  /*        region identifier for start surface */
int     m_nare;                  /*        region identifier for end surface */
float   m_t;                     /* [1010] Thickness of interface layer */
float   m_fac;                   /*        Scale factor for extrusion */
float   m_fac0;                  /*        Scale factor for start segment */
float   m_phi;                   /* [   5] end rotation angle for extrusion/rotation */
float   m_phi0;                  /* [   5] start rotation angle for rotation */
float   m_dphi;                  /* [   5] allowable sector angle for rotation */
float   m_dx;                    /* [1001] explicit extrusion / rotational axis */
float   m_dy;                    /* [1001] explicit extrusion / rotational axis */
float   m_dz;                    /* [1001] explicit extrusion / rotational axis */
float   m_xref;                  /* [1001] explicit reference point */
float   m_yref;                  /* [1001] explicit reference point */
float   m_zref;                  /* [1001] explicit reference point */
float   m_tfac[3];               /* [1010] Factor for thickness extrusion START/END/REF */
} typeCDB_GVO_SURF;

#define SLVL_DEF_ID 0
#define SLVL_DEF_VER 200501
typedef struct tagCDB_SLVL_DEF { /* 34/NR  Structural Storey Level Definition */
int     m_id0;                   /*        identification of definition data (0) */
int     m_sptm;                  /*        ID of SPT to be generated at center of mass */
int     m_sptr;                  /*        ID of SPT to be generated at center of rigidity */
int     m_ibit_stc;              /*        stiffness calculation bit pattern */
int     m_ibit_cpc;              /*        capacity calculation bit pattern */
int     m_ibc;                   /*        reserved */
float   m_zlev;                  /* [1006] Storey level, upwards positive (reference) */
float   m_dzupw;                 /* [1001] Vertical extension upwards (search box) OK */
float   m_dzdwn;                 /* [1001] Vertical extension downwards (search box) UK */
float   m_xmin;                  /* [1001] Lateral extension (search box) */
float   m_xmax;                  /* [1001] Lateral extension (search box) */
float   m_ymin;                  /* [1001] Lateral extension (search box) */
float   m_ymax;                  /* [1001] Lateral extension (search box) */
pckcode m_text[17];              /*        Designation of level */
#define SLVL_DEF_TEXT_LEN 32
} typeCDB_SLVL_DEF;

#define DSLN_DEF_ID 0
#define DSLN_DEF_VER 201804
typedef struct tagCDB_DSLN_DEF { /* 35/ID  Design Element Definition */
int     m_id0;                   /*        identification of definition data (0) */
int     m_dsln;                  /*        number of design element */
int     m_fref;                  /*        reference of forces */
int     m_ncs;                   /*        number of cross section */
int     m_dsel;                  /*        type of quad selection */
int     m_nids;                  /*        count of geometry identifiers */
float   m_hdiv;                  /* [1001] interval of sub-division sections */
} typeCDB_DSLN_DEF;

#define DGEO_DEF_ID 1
#define DGEO_DEF_VER 201804
typedef struct tagCDB_DGEO_DEF { /* 35/ID  Design Element Geometry */
int     m_id;                    /*        identification of data (2) */
int     m_type;                  /*        type of geometric definition */
int     m_ids[100];              /*        ids of structural lines or beams */
float   m_xyza[3];               /* [1001] geometry of a straight line */
float   m_xyze[3];               /* [1001] geometry of a straight line */
float   m_dz[3];                 /* [1001] direction z-axis of straight line */
} typeCDB_DGEO_DEF;

#define DSLC_DEF_ID 2
#define DSLC_DEF_VER 201804
typedef struct tagCDB_DSLC_DEF { /* 35/ID  Design Sections */
int     m_id;                    /*        identification of data (1) */
int     m_type;                  /*        type of sectioning */
int     m_ityp;                  /*        type of section */
float   m_pos;                   /* [1001] position of sections */
} typeCDB_DSLC_DEF;

#define GLAR_0_ID 0
#define GLAR_0_VER 200501
typedef struct tagCDB_GLAR_0 {   /* 38/NR  Load distribution areas Header */
int     m_id;                    /*        Identification 0 */
int     m_ngar;                  /*        number of an 32/NGAR area definition */
int     m_ngrp[4];               /*        group of area and three active groups */
int     m_mgri;                  /*        prescribed grid subdivision (NGAR=0) */
int     m_ngri;                  /*        prescribed grid subdivision (NGAR=0) */
int     m_id32;                  /*        access ID of 32/0 to check valid data */
int     m_id20;                  /*        access ID of 20/0 to check valid data */
int     m_nnod;                  /*        number of nodes            38/NR:1 */
int     m_nqua;                  /*        number of quadrilaterals   38/NR:2 */
int     m_nseg;                  /*        number of beam sections    38/NR:3 */
int     m_dummy[2];              /*        reserved */
int     m_sgrp;                  /*        optional secondary group selector id */
float   m_t;                     /* [1010] thickness of load area used to catch beams */
float   m_xyz[4][3];             /* [1001] ! 4 corner points of area (optional) */
} typeCDB_GLAR_0;

#define GLAR_NOD_ID 1
#define GLAR_NOD_VER 200803
typedef struct tagCDB_GLAR_NOD { /* 38/NR  Node of load distribution area */
int     m_id;                    /*        Identification 1 (instead of NR) */
int     m_inr;                   /*        nodenumber within the region */
int     m_nfix;                  /*        not used */
int     m_ncod;                  /*        not used */
float   m_xyz[3];                /* [1001] coordinates */
float   m_dxyz[3];               /* [1001] displacements for uniform load -> animator */
} typeCDB_GLAR_NOD;

#define GLAR_QUA_ID 2
#define GLAR_QUA_VER 200501
typedef struct tagCDB_GLAR_QUA { /* 38/NR  QUAD of load distribution area */
int     m_id;                    /*        Identification 2 (instead of NR) */
int     m_node[4];               /*        nodenumbers of the quad within region */
int     m_mat;                   /*        not used */
int     m_mrf;                   /*        not used */
int     m_nra;                   /*        type of element */
float   m_det[3];                /*        Parameter of Jacobi Determinant */
float   m_thick[5];              /* [1010] element thickness */
float   m_cb;                    /*        not used */
float   m_cq;                    /*        not used */
float   m_t[3][3];               /*        transformation matrix */
} typeCDB_GLAR_QUA;

#define GLAR_SEG_ID 3
#define GLAR_SEG_VER 200501
typedef struct tagCDB_GLAR_SEG { /* 38/NR  BEAM segments within area */
int     m_id;                    /*        Identification 3 */
int     m_nr;                    /*        number of loaded beam element */
float   m_x;                     /* [1001] start point */
float   m_l;                     /* [1001] length of segment */
} typeCDB_GLAR_SEG;

#define GLAR_P_VER 200501
typedef struct tagCDB_GLAR_P {   /* 38/NR  Load distribution areas  Pointloads */
int     m_id;                    /*        Identification 10:13 */
int     m_inr;                   /*        nodenumber of 038/NR:1 within region */
int     m_node;                  /*        nodenumber of a global node */
float   m_p[4];                  /*        value of load */
} typeCDB_GLAR_P;

#define GLAR_L_VER 200501
typedef struct tagCDB_GLAR_L {   /* 38/NR  Load distribution areas  Beamloads */
int     m_id;                    /*        Identification 100:103 */
int     m_inr;                   /*        nodenumber of 038/NR:1 within region */
int     m_nseg;                  /*        number of 038/NR:3 segment */
float   m_pa;                    /*        start value of load */
float   m_pe;                    /*        end value of load */
float   m_ma;                    /*        start value of torque */
float   m_me;                    /*        end value of torque */
} typeCDB_GLAR_L;


#define AXIS_KWH 3
typedef union taguAXIS {   /* 3/ID */
int m_id;
typeCDB_AXIS m_axis;
typeCDB_AXIS_REF m_axis_ref;
typeCDB_AXIS_GEO m_axis_geo;
typeCDB_AXIS_NKN m_axis_nkn;
typeCDB_AXIS_CPT m_axis_cpt;
typeCDB_AXIS_PT m_axis_pt;
typeCDB_AXIS_ARC m_axis_arc;
typeCDB_AXIS_SPT m_axis_spt;
typeCDB_AXIS_VIZ m_axis_viz;
typeCDB_AXIS_OBB m_axis_obb;
typeCDB_AXIS_ATB m_axis_atb;
typeCDB_AXIS_VTB m_axis_vtb;
typeCDB_AXIS_ITB m_axis_itb;
typeCDB_AXIS_ITS m_axis_its;
typeCDB_AXIS_PSM m_axis_psm;
typeCDB_AXIS_PSP m_axis_psp;
typeCDB_AXIS_PLC m_axis_plc;
typeCDB_AXIS_OPT m_axis_opt;
typeCDB_AXIS_PRP m_axis_prp;
typeCDB_GAXD_ATB m_gaxd_atb;
typeCDB_GAXD_VTB m_gaxd_vtb;
typeCDB_GAXD_GEO m_gaxd_geo;
typeCDB_GAXD_NKN m_gaxd_nkn;
typeCDB_GAXD_CPT m_gaxd_cpt;
typeCDB_GAXD_PT m_gaxd_pt;
typeCDB_GAXD_ARC m_gaxd_arc;
typeCDB_AXIS_TRL m_axis_trl;
} typeuAXIS;


#define AREA_KWH 5
typedef union taguAREA {   /* 5/ID */
int m_id;
typeCDB_AREA m_area;
typeCDB_AREA_CPT m_area_cpt;
typeCDB_AREA_PTS m_area_pts;
typeCDB_AREA_CPI m_area_cpi;
typeCDB_AREA_NKN m_area_nkn;
typeCDB_GARD_PTS m_gard_pts;
typeCDB_GARD_NKU m_gard_nku;
typeCDB_GARD_NKV m_gard_nkv;
} typeuAREA;


#define GPT_KWH 30
typedef union taguGPT {   /* 30/NR */
int m_id;
typeCDB_SPT_ATTR m_spt_attr;
typeCDB_SPT_GUID m_spt_guid;
typeCDB_GPT m_gpt;
typeCDB_GPT_COH m_gpt_coh;
typeCDB_GPT_HAU m_gpt_hau;
typeCDB_GPT_PUN m_gpt_pun;
typeCDB_GPT_COL m_gpt_col;
typeCDB_GPT_FOO m_gpt_foo;
typeCDB_GPT_FRR m_gpt_frr;
typeCDB_GPT_SLP m_gpt_slp;
typeCDB_GPT_HPI m_gpt_hpi;
typeCDB_GPT_CON m_gpt_con;
typeCDB_GPT_SPR m_gpt_spr;
typeCDB_GPT_KIN m_gpt_kin;
typeCDB_GPT_SPC m_gpt_spc;
typeCDB_GPT_DADS m_gpt_dads;
} typeuGPT;


#define GLN_MATC_KWH 31
#define GLN_MATC_KWL 0
typedef union taguGLN_MATC {   /* 31/0 */
int m_id;
typeCDB_GLN_MATC m_gln_matc;
} typeuGLN_MATC;


#define GLN_KWH 31
typedef union taguGLN {   /* 31/NR */
int m_id;
typeCDB_GLN_BPRO m_gln_bpro;
typeCDB_GLN_SUPP m_gln_supp;
typeCDB_GLN_EXYZ m_gln_exyz;
typeCDB_GLN_SCT m_gln_sct;
typeCDB_SLN_ATTR m_sln_attr;
typeCDB_SLN_GUID m_sln_guid;
typeCDB_GLN m_gln;
typeCDB_GLN_REF m_gln_ref;
typeCDB_GLN_GEO m_gln_geo;
typeCDB_GLN_BEAM m_gln_beam;
typeCDB_GLN_ELNR m_gln_elnr;
typeCDB_GLN_DADS m_gln_dads;
} typeuGLN;


#define GAR_MATC_KWH 32
#define GAR_MATC_KWL 0
typedef union taguGAR_MATC {   /* 32/0 */
int m_id;
typeCDB_GAR_MATC m_gar_matc;
} typeuGAR_MATC;


#define GAR_KWH 32
typedef union taguGAR {   /* 32/NR */
int m_id;
typeCDB_GAR_EXYZ m_gar_exyz;
typeCDB_GAR_SUPP m_gar_supp;
typeCDB_SAR_ATTR m_sar_attr;
typeCDB_SAR_GUID m_sar_guid;
typeCDB_GAR m_gar;
typeCDB_GAR_REF m_gar_ref;
typeCDB_GAR_BOUN m_gar_boun;
typeCDB_GAR_HOLE m_gar_hole;
typeCDB_GAR_CON3 m_gar_con3;
typeCDB_GAR_CON4 m_gar_con4;
typeCDB_GAR_MESH m_gar_mesh;
typeCDB_GAR_GEO m_gar_geo;
typeCDB_GAR_SURF m_gar_surf;
typeCDB_GAR_COON m_gar_coon;
typeCDB_GAR_ELNR m_gar_elnr;
typeCDB_GAR_DADS m_gar_dads;
} typeuGAR;


#define GVO_KWH 33
typedef union taguGVO {   /* 33/NR */
int m_id;
typeCDB_GVO m_gvo;
typeCDB_GVO_SURF m_gvo_surf;
} typeuGVO;


#define SLVL_DEF_KWH 34
typedef union taguSLVL_DEF {   /* 34/NR */
int m_id;
typeCDB_SLVL_DEF m_slvl_def;
} typeuSLVL_DEF;


#define DSLN_DEF_KWH 35
typedef union taguDSLN_DEF {   /* 35/ID */
int m_id;
typeCDB_DSLN_DEF m_dsln_def;
typeCDB_DGEO_DEF m_dgeo_def;
typeCDB_DSLC_DEF m_dslc_def;
} typeuDSLN_DEF;


#define GLAR_0_KWH 38
typedef union taguGLAR_0 {   /* 38/NR */
int m_id;
typeCDB_GLAR_0 m_glar_0;
typeCDB_GLAR_NOD m_glar_nod;
typeCDB_GLAR_QUA m_glar_qua;
typeCDB_GLAR_SEG m_glar_seg;
typeCDB_GLAR_P m_glar_p;
typeCDB_GLAR_L m_glar_l;
} typeuGLAR_0;


#define SPT_KWH 39
typedef union taguSPT {   /* 39/NR */
int m_id;
typeCDB_SLN_NKN m_sln_nkn;
typeCDB_SLN_CPT m_sln_cpt;
typeCDB_SLN_PT m_sln_pt;
typeCDB_SLN_ARC m_sln_arc;
typeCDB_SPT m_spt;
typeCDB_SLN m_sln;
typeCDB_SLN_BEAM m_sln_beam;
typeCDB_SLN_SUPP m_sln_supp;
typeCDB_SLN_EXYZ m_sln_exyz;
typeCDB_SLN_SCT m_sln_sct;
typeCDB_SAR m_sar;
typeCDB_SAR_INF m_sar_inf;
typeCDB_SAR_PTS m_sar_pts;
typeCDB_SAR_CPI m_sar_cpi;
typeCDB_SAR_EXYZ m_sar_exyz;
typeCDB_SAR_SUPP m_sar_supp;
typeCDB_SVO m_svo;
typeCDB_SMB_ATTR m_smb_attr;
typeCDB_SMB_GUID m_smb_guid;
} typeuSPT;


/*   SOFiSTiK AG
     cdbtypegeo.h
     end of automatically generated header
*/
#endif
