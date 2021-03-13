!     cdbtypegeo.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_GEO

      INTEGER, PARAMETER :: AXIS_SUBTYPE_NONE=0
      INTEGER, PARAMETER :: AXIS_SUBTYPE_AXIS=1
      INTEGER, PARAMETER :: AXIS_SUBTYPE_BEAM=2
      INTEGER, PARAMETER :: AXIS_SUBTYPE_LANE=10
      INTEGER, PARAMETER :: AXIS_SUBTYPE_BGEO=11
      INTEGER, PARAMETER :: AXIS_SUBTYPE_TEND=12
      INTEGER, PARAMETER :: AXIS_SUBTYPE_POST=15
      INTEGER, PARAMETER :: AXIS_SUBTYPE_AUXI=19
      INTEGER, PARAMETER :: AXIS_SUBTYPE_GRAF=90
      TYPE CAXIS                   ! 3/ID:0  Geometric Axis
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   ID1              !        subtype of axis
        INTEGER   ID2              !        reserved
        INTEGER   ID3              !        reserved
        INTEGER   ID4              !        reserved
        INTEGER   ID5              !        reserved
        INTEGER   TEXT(17)         !        Designation of Line
      END TYPE CAXIS
      INTEGER, PARAMETER :: LEN_CAXIS=23
      INTEGER, PARAMETER :: VER_CAXIS=201509

      TYPE CAXIS_REF               ! 3/ID:-  Reference to another Geometry
        SEQUENCE
        INTEGER   IGM              !        negative value of the master geometry 03/abs(IGM)
        INTEGER   IGS              !        optional identifier of a secondary axis
        REAL*4      SMIN           !        min parameter on referenced axis
        REAL*4      SMAX           !        max parameter on referenced axis
      END TYPE CAXIS_REF
      INTEGER, PARAMETER :: LEN_CAXIS_REF=4
      INTEGER, PARAMETER :: VER_CAXIS_REF=0

      INTEGER, PARAMETER :: GAX_GEO_DEFAULT=1
      INTEGER, PARAMETER :: GAX_GEO_PROJECT=2
      INTEGER, PARAMETER :: GAX_GEO_SPLINE=3
      INTEGER, PARAMETER :: GAX_GEO_EXSPLI=4
      INTEGER, PARAMETER :: GAX_GEO_BEZIER=5
      INTEGER, PARAMETER :: GAX_GEO_NURBS=6
      INTEGER, PARAMETER :: GAX_GEO_NURBX=7
      INTEGER, PARAMETER :: GAX_GEO_DATA=8
      INTEGER, PARAMETER :: GAX_GEO_NORM=9
      INTEGER, PARAMETER :: GAX_GEO_CIRC=11
      INTEGER, PARAMETER :: GAX_GEO_CBEZIER=15
      INTEGER, PARAMETER :: GAX_GEO_CNURBS=16
      INTEGER, PARAMETER :: GAX_GEO_PROJ_CLO=20
      INTEGER, PARAMETER :: GAX_GEO_PROJ_CUB=21
      INTEGER, PARAMETER :: GAX_GEO_PROJ_BLO=22
      INTEGER, PARAMETER :: GAX_GEO_PROJ_SIN=24
      INTEGER, PARAMETER :: GAX_GEO_PROJ_COS=25
      INTEGER, PARAMETER :: GAX_GEO_NURBS_KN=90
      INTEGER, PARAMETER :: GAX_GEO_NURBS_CPT=91
      TYPE CAXIS_GEO               ! 3/ID:??  Geometric properties
        SEQUENCE
        INTEGER   ILN              !        Code of geometry
        REAL*4      GPG            ! [1001] geometry parameter 1
        REAL*4      GPA            ! [1001] geometry parameter 2
        REAL*4      DD             ! [1001] arc length
        REAL*4      S1             !        parameter s on start
        REAL*4      XYZ1(3)        ! [1001] Ordinate of start
        REAL*4      DXYZ1(3)       !        Tangent of start
        REAL*4      RG1            ! [1009] in-plane curvature
        REAL*4      RA1            ! [1009] vertical curvature
        REAL*4      S2             !        parameter s on end
        REAL*4      XYZ2(3)        ! [1001] Ordinate of endpoint
        REAL*4      DXYZ2(3)       !        Tangent of endpoint
        REAL*4      RG2            ! [1009] in-plane curvature
        REAL*4      RA2            ! [1009] vertical curvature
        REAL*4      XAT            ! [1001] relat. startordinate
      END TYPE CAXIS_GEO
      INTEGER, PARAMETER :: LEN_CAXIS_GEO=23
      INTEGER, PARAMETER :: VER_CAXIS_GEO=200801

      TYPE CAXIS_NKN               ! 3/ID:90  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=90
        INTEGER   DEG              !        Order of Spline
        REAL*4      S(256)         !        Knot-Vector
      END TYPE CAXIS_NKN
      INTEGER, PARAMETER :: LEN_CAXIS_NKN=258
      INTEGER, PARAMETER :: VER_CAXIS_NKN=200705

      TYPE CSLN_NKN                ! 39/NR:90  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=90
        INTEGER   DEG              !        Order of Spline
        REAL*4      S(256)         !        Knot-Vector
      END TYPE CSLN_NKN
      INTEGER, PARAMETER :: LEN_CSLN_NKN=258
      INTEGER, PARAMETER :: VER_CSLN_NKN=200705

      TYPE CAXIS_CPT               ! 3/ID:91  Control point of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=91
        REAL*4      W              !        Weight
        REAL*4      XYZ(3)         ! [1001] Coordinates
        REAL*4      DIR(3)         !        upward direction
      END TYPE CAXIS_CPT
      INTEGER, PARAMETER :: LEN_CAXIS_CPT=8
      INTEGER, PARAMETER :: VER_CAXIS_CPT=200705

      TYPE CSLN_CPT                ! 39/NR:91  Control point of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=91
        REAL*4      W              !        Weight
        REAL*4      XYZ(3)         ! [1001] Coordinates
        REAL*4      DIR(3)         !        upward direction
      END TYPE CSLN_CPT
      INTEGER, PARAMETER :: LEN_CSLN_CPT=8
      INTEGER, PARAMETER :: VER_CSLN_CPT=200705

      TYPE CAXIS_PT                ! 3/ID:92  Data point on curve
        SEQUENCE
        INTEGER   ILN              !        ID=92
        REAL*4      S              !        Parameter along curve
        REAL*4      XYZ(3)         ! [1001] Coordinates
        REAL*4      DIR(3)         !        upward direction
      END TYPE CAXIS_PT
      INTEGER, PARAMETER :: LEN_CAXIS_PT=8
      INTEGER, PARAMETER :: VER_CAXIS_PT=200707

      TYPE CSLN_PT                 ! 39/NR:92  Data point on curve
        SEQUENCE
        INTEGER   ILN              !        ID=92
        REAL*4      S              !        Parameter along curve
        REAL*4      XYZ(3)         ! [1001] Coordinates
        REAL*4      DIR(3)         !        upward direction
      END TYPE CSLN_PT
      INTEGER, PARAMETER :: LEN_CSLN_PT=8
      INTEGER, PARAMETER :: VER_CSLN_PT=200707

      TYPE CAXIS_ARC               ! 3/ID:93  Circular Arc
        SEQUENCE
        INTEGER   ILN              !        ID=93
        INTEGER   IDF              !        Definition selected
        REAL*4      R              ! [1001] Radius of arc
        REAL*4      XYZ(3)         ! [1001] Coordinates of center
        REAL*4      DIR(3)         !        upward direction of plane
        REAL*4      XYZA(3)        ! [1001] optional start point of arc
        REAL*4      XYZE(3)        ! [1001] optional end point of arc
      END TYPE CAXIS_ARC
      INTEGER, PARAMETER :: LEN_CAXIS_ARC=15
      INTEGER, PARAMETER :: VER_CAXIS_ARC=200707

      TYPE CSLN_ARC                ! 39/NR:93  Circular Arc
        SEQUENCE
        INTEGER   ILN              !        ID=93
        INTEGER   IDF              !        Definition selected
        REAL*4      R              ! [1001] Radius of arc
        REAL*4      XYZ(3)         ! [1001] Coordinates of center
        REAL*4      DIR(3)         !        upward direction of plane
        REAL*4      XYZA(3)        ! [1001] optional start point of arc
        REAL*4      XYZE(3)        ! [1001] optional end point of arc
      END TYPE CSLN_ARC
      INTEGER, PARAMETER :: LEN_CSLN_ARC=15
      INTEGER, PARAMETER :: VER_CSLN_ARC=200707

      TYPE CAXIS_SPT               ! 3/ID:97  Station point on a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=97
        REAL*4      S              !        Station value at data point
        REAL*4      L              ! [1001] Length (prescribed if XYZ==0.0)
        REAL*4      XYZ(3)         ! [1001] Coordinates for 3D-intersection plane
        REAL*4      DIR(3)         !        Direction (nx,ny,nz) of normal of the plane
      END TYPE CAXIS_SPT
      INTEGER, PARAMETER :: LEN_CAXIS_SPT=9
      INTEGER, PARAMETER :: VER_CAXIS_SPT=200707

      TYPE CAXIS_VIZ               ! 3/ID:98  Data points for visualisation
        SEQUENCE
        INTEGER   ILN              !        ID=98
        INTEGER   COLOR            !        hexadecimal RGB-value (e.g. 99AAFF)
        INTEGER   THICK            !        Thickness in pixel
        REAL*4      PTS(3,64)      ! [1001] Data Points
      END TYPE CAXIS_VIZ
      INTEGER, PARAMETER :: LEN_CAXIS_VIZ=195
      INTEGER, PARAMETER :: VER_CAXIS_VIZ=200601

      TYPE CAXIS_OBB               ! 3/ID:99  Oriented Boundig Box
        SEQUENCE
        INTEGER   ILN              !        ID=99
        REAL*4      S1             !        Parameter on Start
        REAL*4      S2             !        Parameter on end
        REAL*4      TA(3,3)        !        Transformation Matrix
        REAL*4      XYZ(3)         ! [1001] Center of Box
        REAL*4      XI(3)          ! [1001] Half widths
      END TYPE CAXIS_OBB
      INTEGER, PARAMETER :: LEN_CAXIS_OBB=18
      INTEGER, PARAMETER :: VER_CAXIS_OBB=200705

      TYPE CAXIS_ATB               ! 3/ID:101  Geometric segments of axis plan view
        SEQUENCE
        INTEGER   ID0              !        ident=101
        INTEGER   ID1              !        specification type
        INTEGER   ID2              !        type of transition curve to be used
        REAL*4      S              !        Station value at tangent
        REAL*4      L(0:4)         ! [1001] Length of segment
        REAL*4      R(0:4)         ! [1001] Radius mid & start & end
        REAL*4      XYZ(3)         ! [1001] Startpoint of tangent
        REAL*4      DIR(3)         !        Tangential direction
        REAL*4      D(2)           ! [1001] Distance to point on curve (start/end)
        REAL*4      TAU            ! [   5] deflection angle
        INTEGER   TXT              !        Identifier of this sequence
      END TYPE CAXIS_ATB
      INTEGER, PARAMETER :: LEN_CAXIS_ATB=24
      INTEGER, PARAMETER :: VER_CAXIS_ATB=200701

      TYPE CAXIS_VTB               ! 3/ID:102  Geometric properties for axis heights
        SEQUENCE
        INTEGER   ID0              !        ident=102
        INTEGER   ID1              !        specification type
        INTEGER   ID2              !        reserved
        REAL*4      S              !        Parameter s along the axis
        REAL*4      H              ! [1001] Height of gradient polygon
        REAL*4      R              ! [1001] Radius of curvature at this point
        REAL*4      X              ! [1001] Calculated true length along the axis
        REAL*4      T              ! [1001] Calculated secant length along the axis
      END TYPE CAXIS_VTB
      INTEGER, PARAMETER :: LEN_CAXIS_VTB=8
      INTEGER, PARAMETER :: VER_CAXIS_VTB=200601

      TYPE CAXIS_ITB               ! 3/ID:103  Placement at axis position
        SEQUENCE
        INTEGER   ID0              !        ident=103
        INTEGER   IDS              !        Enum of secondary axis
        INTEGER   TYP              !        properties of this placement
        INTEGER   NPT              !        point number
        INTEGER   GRP              !        group number behind that placement
        INTEGER   NOS(2)           !        Number of section before and behind that placement
        INTEGER   SEGT             !        identifier of a segment see (900/0) behind that placement
        REAL*4      S              !        Parameter s of this section
        REAL*4      Y              ! [1001] additional transverse offset
        REAL*4      Z              ! [1001] additional vertical offset
        REAL*4      ALF            ! [   5] Rotation about global Z
        REAL*4      ALFX           ! [   5] Rotation about local axis x
        REAL*4      ALFY           ! [   5] Rotation about transverse y
        REAL*4      ALFZ           ! [   5] Rotation about vertical   z
        REAL*4      INCR           ! [   5] Inclination to the right +y
        REAL*4      INCL           ! [   5] Inclination to the left  -y
        INTEGER   SRULE(5)         !        Formula string to evaluate the value S
        INTEGER   TEXT(17)         !        Designation of Placement
      END TYPE CAXIS_ITB
      INTEGER, PARAMETER :: LEN_CAXIS_ITB=39
      INTEGER, PARAMETER :: VER_CAXIS_ITB=200712

      TYPE CAXIS_ITS               ! 3/ID:104  Secondary axis definition
        SEQUENCE
        INTEGER   ID0              !        Ident=104
        INTEGER   IDS              !        Enum of secondary axis (1='A' to 26 ='Z')
        INTEGER   IREF             !        Reference to external axis geometry
        INTEGER   NPT              !        offset for structural points along the axis
        INTEGER   GRP              !        group number (:103 is always added as an offset)
        REAL*4      Y              ! [1001] constant or maximum value of y offset
        REAL*4      Z              ! [1001] constant or maximum value of z offset
        INTEGER   Y_V(4)           !        variable name for y offset (see :110)
        INTEGER   Z_V(4)           !        variable name for z offset (see :110)
        INTEGER   TEXT(17)         !        Designation (only for first point of a sequence)
      END TYPE CAXIS_ITS
      INTEGER, PARAMETER :: LEN_CAXIS_ITS=32
      INTEGER, PARAMETER :: VER_CAXIS_ITS=200705

      TYPE CAXIS_PSM               ! 3/ID:105  Prestress method
        SEQUENCE
        INTEGER   ID0              !        ident=105
        INTEGER   IDT              !        Identifier of Tendon
        INTEGER   TYPE             !        Type of Spline geometry
        INTEGER   NSP              !        Number of tendon elements
        INTEGER   ID5              !        Placement of tendons
        INTEGER   JACK             !        Jacking procedure
        INTEGER   LIRE             !        Sides for jacking
        INTEGER   IBA(3)           !        Construction stage identifiers
        INTEGER   NRSV             !        number of jacking method
        INTEGER   DUMMY(5)         !        reserved
        REAL*4      FAK            !        factor for prestress
        REAL*4      LITZ           !        partial number of strands
        REAL*4      FRSP(2)        ! [1001] Length controls for free tendon geometry
        REAL*4      ZSP(2)         ! [1011] Distances of tendon to extreme fiber upper/lower
        INTEGER   TEXTL(17)        !        Designation of layer of Tendons
      END TYPE CAXIS_PSM
      INTEGER, PARAMETER :: LEN_CAXIS_PSM=39
      INTEGER, PARAMETER :: VER_CAXIS_PSM=200701

      TYPE CAXIS_PSP               ! 3/ID:106  Prestress placements
        SEQUENCE
        INTEGER   ID0              !        ident=106
        INTEGER   TYP              !        Type of placement
        INTEGER   ID2              !        Type of station data (bitpattern)
        INTEGER   ID3              !        reserved
        INTEGER   ID4              !        reserved
        INTEGER   ID5              !        reserved
        REAL*4      S              !        Station along axis
        REAL*4      ZT             ! [1011] Distances of tendon to extreme fiber upper/lower
        REAL*4      DZT            !        inclination of tendon to axis
      END TYPE CAXIS_PSP
      INTEGER, PARAMETER :: LEN_CAXIS_PSP=9
      INTEGER, PARAMETER :: VER_CAXIS_PSP=200701

      TYPE CAXIS_PLC               ! 3/ID:107  Placement at axis position
        SEQUENCE
        INTEGER   ID0              !        ident=107
        INTEGER   IDS              !        Enum of secondary axis
        INTEGER   TYP              !        properties of this placement
        INTEGER   NPT              !        point number
        INTEGER   GRP              !        group number behind that placement
        INTEGER   NOS(2)           !        Number of section before and behind that placement
        INTEGER   IB0              !        general bit-mask
        INTEGER   IDP              !        identifier of this placement
        INTEGER   SEGT             !        identifier of a segment see (900/0) behind that placement
        INTEGER   RES(6)           !        reserved
        REAL*4      S              !        Parameter s of this section
        REAL*4      Y              ! [1001] additional transverse offset
        REAL*4      Z              ! [1001] additional vertical offset
        REAL*4      ALF            ! [   5] Rotation about global Z
        REAL*4      ALFX           ! [   5] Rotation about local axis x
        REAL*4      ALFY           ! [   5] Rotation about transverse y
        REAL*4      ALFZ           ! [   5] Rotation about vertical   z
        REAL*4      INCR           ! [   5] Inclination to the right +y
        REAL*4      INCL           ! [   5] Inclination to the left  -y
        INTEGER   SRULE(5)         !        Formula string to evaluate the value S
        INTEGER   TEXT(17)         !        Designation of placement
      END TYPE CAXIS_PLC
      INTEGER, PARAMETER :: LEN_CAXIS_PLC=47
      INTEGER, PARAMETER :: VER_CAXIS_PLC=201006

      TYPE CAXIS_OPT               ! 3/ID:10107  Placement options
        SEQUENCE
        INTEGER   ID0              !        ident=10107
        INTEGER   A_FILTER         !        Filter for axis
        INTEGER   T_FILTER         !        Filter for axis type
      END TYPE CAXIS_OPT
      INTEGER, PARAMETER :: LEN_CAXIS_OPT=3
      INTEGER, PARAMETER :: VER_CAXIS_OPT=210415

      TYPE CAXIS_PRP               ! 3/ID:110  General properties of axis
        SEQUENCE
        INTEGER   ID0              !        ident=110
        INTEGER   NAME(4)          !        Name of this item
        INTEGER   TYP              !        Continuity Type of this data point
        REAL*4      S_VAL(0:4)     !        Parameter s of this section and values
        INTEGER   SRULE(5)         !        Formula string to evaluate the value S
        INTEGER   VRULE(10)        !        Formula string to evaluate the value VAL
        INTEGER   DVRULE(10)       !        Formula string to evaluate the value dVAL/dS
      END TYPE CAXIS_PRP
      INTEGER, PARAMETER :: LEN_CAXIS_PRP=36
      INTEGER, PARAMETER :: VER_CAXIS_PRP=200603

      TYPE CGAXD_ATB               ! 3/ID:121  Geometric segments of axis plan view (double precision)
        SEQUENCE
        INTEGER   ID0              !        ident=121
        INTEGER   ID1              !        specification type
        INTEGER   ID2              !        type of transition curve to be used
        INTEGER   ID3              !        reserved
        REAL*8    S                !        Station value at tangent
        REAL*8    L(0:4)           ! [1001] Length of segment
        REAL*8    R(0:4)           ! [1001] Radius mid & start & end
        REAL*8    XYZ(3)           ! [1001] Startpoint of tangent
        REAL*8    DIR(3)           !        Tangential direction
        REAL*8    D(2)             ! [1001] Distance to point on curve (start/end)
        REAL*8    TAU              ! [   5] deflection angle
        INTEGER   TXT0             !        reserved
        INTEGER   TXT              !        Identifier of this sequence
      END TYPE CGAXD_ATB
      INTEGER, PARAMETER :: LEN_CGAXD_ATB=46
      INTEGER, PARAMETER :: VER_CGAXD_ATB=201101

      TYPE CGAXD_VTB               ! 3/ID:122  Geometric properties for axis heights (double precision)
        SEQUENCE
        INTEGER   ID0              !        ident=122
        INTEGER   ID1              !        specification type
        INTEGER   ID2              !        reserved
        INTEGER   ID3              !        reserved
        REAL*8    S                !        Parameter s along the axis
        REAL*8    H                ! [1001] Height of gradient polygon
        REAL*8    R                ! [1001] Radius of curvature at this point
        REAL*8    X                ! [1001] Calculated true length along the axis
        REAL*8    T                ! [1001] Calculated secant length along the axis
      END TYPE CGAXD_VTB
      INTEGER, PARAMETER :: LEN_CGAXD_VTB=14
      INTEGER, PARAMETER :: VER_CGAXD_VTB=201101

      INTEGER, PARAMETER :: GAXD_GEO_DEFAULT=181
      INTEGER, PARAMETER :: GAXD_GEO_PROJECT=182
      TYPE CGAXD_GEO               ! 3/ID:18?  Geometric properties
        SEQUENCE
        INTEGER   ILN              !        Code of geometry
        INTEGER   ID1              !        reserved
        REAL*8    GPG              ! [1001] geometry parameter 1
        REAL*8    GPA              ! [1001] geometry parameter 2
        REAL*8    DD               ! [1001] arc length
        REAL*8    S1               !        parameter s on start
        REAL*8    XYZ1(3)          ! [1001] Ordinate of start
        REAL*8    DXYZ1(3)         !        Tangent of start
        REAL*8    RG1              ! [1009] in-plane curvature
        REAL*8    RA1              ! [1009] vertical curvature
        REAL*8    S2               !        parameter s on end
        REAL*8    XYZ2(3)          ! [1001] Ordinate of endpoint
        REAL*8    DXYZ2(3)         !        Tangent of endpoint
        REAL*8    RG2              ! [1009] in-plane curvature
        REAL*8    RA2              ! [1009] vertical curvature
        REAL*8    XAT              ! [1001] relat. startordinate
      END TYPE CGAXD_GEO
      INTEGER, PARAMETER :: LEN_CGAXD_GEO=46
      INTEGER, PARAMETER :: VER_CGAXD_GEO=201101

      TYPE CGAXD_NKN               ! 3/ID:190  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=190
        INTEGER   DEG              !        Order of Spline
        REAL*8    S(256)           !        Knot-Vector
      END TYPE CGAXD_NKN
      INTEGER, PARAMETER :: LEN_CGAXD_NKN=514
      INTEGER, PARAMETER :: VER_CGAXD_NKN=201101

      TYPE CGAXD_CPT               ! 3/ID:191  Control point of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID=191
        INTEGER   ID1              !        reserved
        REAL*8    W                !        Weight
        REAL*8    XYZ(3)           ! [1001] Coordinates
        REAL*8    DIR(3)           !        upward direction
      END TYPE CGAXD_CPT
      INTEGER, PARAMETER :: LEN_CGAXD_CPT=16
      INTEGER, PARAMETER :: VER_CGAXD_CPT=201101

      TYPE CGAXD_PT                ! 3/ID:192  Data point on curve
        SEQUENCE
        INTEGER   ILN              !        ID=192
        INTEGER   ID1              !        specification type
        REAL*8    S                !        Parameter along curve
        REAL*8    XYZ(3)           ! [1001] Coordinates
        REAL*8    DIR(3)           !        direction
      END TYPE CGAXD_PT
      INTEGER, PARAMETER :: LEN_CGAXD_PT=16
      INTEGER, PARAMETER :: VER_CGAXD_PT=201101

      TYPE CGAXD_ARC               ! 3/ID:193  Circular Arc
        SEQUENCE
        INTEGER   ILN              !        ID=193
        INTEGER   IDF              !        Definition selected
        REAL*8    R                ! [1001] Radius of arc
        REAL*8    XYZ(3)           ! [1001] Coordinates of center
        REAL*8    DIR(3)           !        upward direction of plane
        REAL*8    XYZA(3)          ! [1001] optional start point of arc
        REAL*8    XYZE(3)          ! [1001] optional end point of arc
      END TYPE CGAXD_ARC
      INTEGER, PARAMETER :: LEN_CGAXD_ARC=28
      INTEGER, PARAMETER :: VER_CGAXD_ARC=201101

      TYPE CAXIS_TRL               ! 3/ID:300  Properties for train loading
        SEQUENCE
        INTEGER   ID0              !        ident 300
        INTEGER   NRA              !        Number of the lane (0:99)
        INTEGER   NRS              !        Number of the segment
        INTEGER   BTYP             !        Literal of default type
        REAL*4      SA             !        Parameter s of start of this section
        REAL*4      SE             !        Parameter s of end of this section
        REAL*4      YCA            ! [1001] Center ordinate of lane at SA
        REAL*4      YCE            ! [1001] Center ordinate of lane at SE
        REAL*4      YRA            ! [1001] Right boundary at SA of lane area
        REAL*4      YRE            ! [1001] Right boundary at SE of lane area
        REAL*4      YLA            ! [1001] Left boundary at SA of lane area
        REAL*4      YLE            ! [1001] Left boundary at SE of lane area
        REAL*4      L              ! [1001] Reference length for impact factor
        REAL*4      HSA            ! [1001] Total height of traffic lane above axis at SA
        REAL*4      HSE            ! [1001] Total height of traffic lane above axis at SE
        REAL*4      INCA           ! [   5] Inclination within lane at SA
        REAL*4      INCE           ! [   5] Inclination within lane at SE
        REAL*4      HEFF           ! [1001] Height of rail and sleeper construction
        REAL*4      BEFF           ! [1001] Effective length of sleeper
        REAL*4      DEFF           ! [1001] Width of sleepers
        REAL*4      INCD           !        Inclination of load distribution (e.g. 1:4)
        REAL*4      ASL            ! [1001] Distance of Sleepers or mounting points
      END TYPE CAXIS_TRL
      INTEGER, PARAMETER :: LEN_CAXIS_TRL=22
      INTEGER, PARAMETER :: VER_CAXIS_TRL=200601


      TYPE CAREA                   ! 5/ID:0  Geometric Area
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   NG               !        Type of surface representation
        INTEGER   GID1             !        Axis identifier of first reference axis
        INTEGER   GID2             !        Axis identifier of second reference axis
        INTEGER   MGRI             !        number of data/control points in s of mesh
        INTEGER   NGRI             !        number of data/control points in t of mesh
        INTEGER   MSPL             !        degree of B-spline in s direction
        INTEGER   NSPL             !        degree of B-spline in t direction
        INTEGER   SFLG             !        property options of surface
        REAL*4      T(3,4)         !        Transformation
        REAL*4      PAR(0:15)      !        additional Parameters
        REAL*4      BOX(2,3)       ! [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        INTEGER   TEXT(17)         !        Designation of Line
      END TYPE CAREA
      INTEGER, PARAMETER :: LEN_CAREA=60
      INTEGER, PARAMETER :: VER_CAREA=200704

      TYPE CAREA_CPT               ! 5/ID:10  Control points of area
        SEQUENCE
        INTEGER   ID               !        Identification of control point data = 10
        REAL*4      XPAR(1)        !        spline grid and coefficients
                                   !        unknwon length!
      END TYPE CAREA_CPT
      INTEGER, PARAMETER :: LEN_CAREA_CPT=2
      INTEGER, PARAMETER :: VER_CAREA_CPT=200704

      TYPE CAREA_PTS               ! 5/ID:11  AreaPointonSurface
        SEQUENCE
        INTEGER   ID               !        Identification of surface description = 11
        INTEGER   IT               !        Type of point
        INTEGER   M                !        Rasterlocation of mesh (0 < m < mgri )
        INTEGER   N                !        Rasterlocation of mesh (0 < n < ngri )
        REAL*4      W              !        the weight of NURBS control point
        REAL*4      X              ! [1001] X-ordinate
        REAL*4      Y              ! [1001] Y-ordinate
        REAL*4      Z              ! [1001] Z-ordinate
        REAL*4      T              ! [1010] Thickness
      END TYPE CAREA_PTS
      INTEGER, PARAMETER :: LEN_CAREA_PTS=9
      INTEGER, PARAMETER :: VER_CAREA_PTS=200704

      TYPE CAREA_CPI               ! 5/ID:12  COONsPatchInfo
        SEQUENCE
        INTEGER   ID               !        Identification of COONs blending edges 12
        INTEGER   IT               !        Type of blending
        INTEGER   IU0              !        No of geometry line for u=umin (left)
        INTEGER   IU1              !        No of geometry line for u=umax (right)
        INTEGER   IV0              !        No of geometry line for v=vmin (lower)
        INTEGER   IV1              !        No of geometry line for v=vmax (upper)
        REAL*4      SP(3,4)        !        Length parameters for the edges iu0,iu1,iv0,iv1
        REAL*4      UV(2,2)        !        umin,umax,vmin,vmax of the parameter plane
        REAL*4      CXYZ(3,4)      !        Coordinates of the corner points C1,C2,C3,C4
        REAL*4      TINC(3,8)      !        inclinations for a bicubic patch as vectors
        REAL*4      TWIST(3,4)     !        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END TYPE CAREA_CPI
      INTEGER, PARAMETER :: LEN_CAREA_CPI=70
      INTEGER, PARAMETER :: VER_CAREA_CPI=200702

      TYPE CAREA_NKN               ! 5/ID:9?  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID
        INTEGER   DEG              !        Order of Spline
        REAL*4      S(256)         !        Knot-Vector
      END TYPE CAREA_NKN
      INTEGER, PARAMETER :: LEN_CAREA_NKN=258
      INTEGER, PARAMETER :: VER_CAREA_NKN=200705

      TYPE CGARD_PTS               ! 5/ID:290  AreaPointonSurface
        SEQUENCE
        INTEGER   ID               !        Id = 290
        INTEGER   IT               !        Type of point
        INTEGER   M                !        Rasterlocation of mesh (0 < m < mgri )
        INTEGER   N                !        Rasterlocation of mesh (0 < n < ngri )
        REAL*8    W                !        the weight of NURBS control point
        REAL*8    X                ! [1001] X-ordinate
        REAL*8    Y                ! [1001] Y-ordinate
        REAL*8    Z                ! [1001] Z-ordinate
        REAL*8    T                ! [1010] Thickness
      END TYPE CGARD_PTS
      INTEGER, PARAMETER :: LEN_CGARD_PTS=14
      INTEGER, PARAMETER :: VER_CGARD_PTS=201001

      TYPE CGARD_NKU               ! 5/ID:291  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID
        INTEGER   DEG              !        Order of Spline
        REAL*8    S(256)           !        Knot-Vector
      END TYPE CGARD_NKU
      INTEGER, PARAMETER :: LEN_CGARD_NKU=514
      INTEGER, PARAMETER :: VER_CGARD_NKU=201101

      TYPE CGARD_NKV               ! 5/ID:292  Knots of a Nurb
        SEQUENCE
        INTEGER   ILN              !        ID
        INTEGER   DEG              !        Order of Spline
        REAL*8    S(256)           !        Knot-Vector
      END TYPE CGARD_NKV
      INTEGER, PARAMETER :: LEN_CGARD_NKV=514
      INTEGER, PARAMETER :: VER_CGARD_NKV=201101

      TYPE CGLN_MATC               ! 31/0  Heritage of Structural lines
        SEQUENCE
        INTEGER   NR               !        original structural line number
        INTEGER   IDS(1)           !        sequence of sub-lines
                                   !        unknwon length!
      END TYPE CGLN_MATC
      INTEGER, PARAMETER :: LEN_CGLN_MATC=2
      INTEGER, PARAMETER :: VER_CGLN_MATC=201301

      TYPE CGAR_MATC               ! 32/0  Heritage of Structural Areas
        SEQUENCE
        INTEGER   NR               !        original structural area number
        INTEGER   IDS(1)           !        list of sub-areas
                                   !        unknwon length!
      END TYPE CGAR_MATC
      INTEGER, PARAMETER :: LEN_CGAR_MATC=2
      INTEGER, PARAMETER :: VER_CGAR_MATC=201301

      TYPE CSPT                    ! 39/NR:0  Structural points
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   IDS              !        optional identifier of point
        INTEGER   REF              !        reserved reference
        INTEGER   NOG              !        reserved number of group
        INTEGER   NOM              !        reserved number of material
        INTEGER   NOR              !        reserved number of reinforc.
        INTEGER   IBT              !        Bitpattern of element properties
        INTEGER   IBC              !        Boundary condition
        INTEGER   I_8              !        reserved
        INTEGER   I_9              !        reserved
        REAL*4      XYZ(3)         ! [1001] Coordinates of that point
        REAL*4      T(3,3)         !        transformation matrix
        REAL*4      BX             ! [1001] Dimension in local x
        REAL*4      BY             ! [1001] Dimension in local y
        REAL*4      THICK          ! [1010] Plate thickness at that point
        REAL*4      HMESH          ! [1001] Mesh density at point
        REAL*4      RES(3)         !        reserved
        INTEGER   TEXT(17)         !        Designation of Point
      END TYPE CSPT
      INTEGER, PARAMETER :: LEN_CSPT=46
      INTEGER, PARAMETER :: VER_CSPT=201303

      TYPE CSLN                    ! 39/NR:100  Structural lines
        SEQUENCE
        INTEGER   ID               !        identifier 100
        INTEGER   IDS              !        optional identifier of structural line
        INTEGER   REF              !        reference identifier to a given GAX [chr] or sln [int]
        INTEGER   SREF             !        secondary axis enum for GAX references
        INTEGER   NA               !        optional identifier of line start point
        INTEGER   NB               !        optional identifier of line end point
        INTEGER   IBT              !        Bitpattern of element properties
        INTEGER   IBC              !        primary boundary condition
        INTEGER   ID8              !        reserved
        INTEGER   ID9              !        reserved
        REAL*4      HMESH          ! [1001] >0.0 = mesh density along line
        REAL*4      TUP(3)         !        Vector to define downward direction
        REAL*4      TROT           !        Fractional rotation about local x-axis  (obsoleted => :101/:102
        REAL*4      TAL(3)         !        Vector to be aligned as local axis      (obsoleted => :101/:102
        REAL*4      PROG           !        progression factor (>0 monoton, <0 symmetric)
        REAL*4      R10            !        reserved
        REAL*4      R11            !        reserved
        REAL*4      R12            !        reserved
        REAL*4      R13            !        reserved
        REAL*4      R14            !        reserved
        REAL*4      R15            !        reserved
        INTEGER   TEXT(17)         !        Designation of Line
      END TYPE CSLN
      INTEGER, PARAMETER :: LEN_CSLN=42
      INTEGER, PARAMETER :: VER_CSLN=201303

      INTEGER, PARAMETER :: SLN_BEAM_NONE=-1
      INTEGER, PARAMETER :: SLN_BEAM_CENTRIC=0
      INTEGER, PARAMETER :: SLN_BEAM_REFERENCE=1
      INTEGER, PARAMETER :: SLN_BEAM_TRUSS=2
      INTEGER, PARAMETER :: SLN_BEAM_CABLE=3
      INTEGER, PARAMETER :: SLN_BEAM_CCOLUMN=4
      INTEGER, PARAMETER :: SLN_BEAM_COLUMN=5
      INTEGER, PARAMETER :: SLN_BEAM_SECTION=7
      TYPE CSLN_BEAM               ! 39/NR:101  Properties of beams
        SEQUENCE
        INTEGER   ID               !        ident 101
        INTEGER   TYP              !        Element type (see 009/NR:90:4 IBTYP)
        INTEGER   NOG              !        group number
        INTEGER   NQ(2)            !        number cross section start/end
        INTEGER   NP               !        number bedding props
        INTEGER   IBC(4)           !        Hinge properties A/E/XA/XE (start/end/internal start/end)
        INTEGER   DIV              !        type of element subdivision
        REAL*4      KR             !        identifier of local coordinate system orientation
        REAL*4      R12
        REAL*4      R13
        REAL*4      R14
        REAL*4      R15
        REAL*4      EXA            ! [1001] eccentricity at start
        REAL*4      EYA            ! [1001] eccentricity at start
        REAL*4      EZA            ! [1001] eccentricity at start
        REAL*4      EXE            ! [1001] eccentricity at end
        REAL*4      EYE            ! [1001] eccentricity at end
        REAL*4      EZE            ! [1001] eccentricity at end
        REAL*4      TROT           !        additional rotation about local x-axis, given as fraction of 36
        REAL*4      TAL(3)         !        vector defining the orientation of the local z-axis of the loca
      END TYPE CSLN_BEAM
      INTEGER, PARAMETER :: LEN_CSLN_BEAM=26
      INTEGER, PARAMETER :: VER_CSLN_BEAM=200701

      TYPE CGLN_BPRO               ! 31/NR:101  Properties of beams
        SEQUENCE
        INTEGER   ID               !        ident 101
        INTEGER   TYP              !        Element type (see 009/NR:90:4 IBTYP)
        INTEGER   NOG              !        group number
        INTEGER   NQ(2)            !        number cross section start/end
        INTEGER   NP               !        number bedding props
        INTEGER   IBC(4)           !        Hinge properties A/E/XA/XE (start/end/internal start/end)
        INTEGER   DIV              !        type of element subdivision
        REAL*4      KR             !        identifier of local coordinate system orientation
        REAL*4      R12
        REAL*4      R13
        REAL*4      R14
        REAL*4      R15
        REAL*4      EXA            ! [1001] eccentricity at start
        REAL*4      EYA            ! [1001] eccentricity at start
        REAL*4      EZA            ! [1001] eccentricity at start
        REAL*4      EXE            ! [1001] eccentricity at end
        REAL*4      EYE            ! [1001] eccentricity at end
        REAL*4      EZE            ! [1001] eccentricity at end
        REAL*4      TROT           !        additional rotation about local x-axis, given as fraction of 36
        REAL*4      TAL(3)         !        vector defining the orientation of the local z-axis of the loca
      END TYPE CGLN_BPRO
      INTEGER, PARAMETER :: LEN_CGLN_BPRO=26
      INTEGER, PARAMETER :: VER_CGLN_BPRO=200701

      TYPE CSLN_SUPP               ! 39/NR:102  Support of Structural lines
        SEQUENCE
        INTEGER   ID               !        identifier 102
        INTEGER   IDS              !        type of reference
        INTEGER   REF              !        reference identifier
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   IBC              !        Boundary condition / kinematic constraints
        INTEGER   KR               !        local orientation
        REAL*4      W              ! [1001] width of support
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
        REAL*4      CM             ! [1099] torsional bedding
        REAL*4      DRX            !        explicit X direction of support
        REAL*4      DRY            !        explicit Y direction of support
        REAL*4      DRZ            !        explicit Z direction of support
        REAL*4      D              ! [1001] distance to coupled line (IDS={5,6,7})
        REAL*4      R8
        REAL*4      R9
        REAL*4      FKA            !        factor bedding at start
        REAL*4      FKE            !        factor bedding at end
        REAL*4      TROT           !        Fractional rotation about local x-axis
        REAL*4      TAL(3)         !        Vector to be aligned as local axis
      END TYPE CSLN_SUPP
      INTEGER, PARAMETER :: LEN_CSLN_SUPP=23
      INTEGER, PARAMETER :: VER_CSLN_SUPP=200808

      TYPE CGLN_SUPP               ! 31/NR:102  Support of Structural lines
        SEQUENCE
        INTEGER   ID               !        identifier 102
        INTEGER   IDS              !        type of reference
        INTEGER   REF              !        reference identifier
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   IBC              !        Boundary condition / kinematic constraints
        INTEGER   KR               !        local orientation
        REAL*4      W              ! [1001] width of support
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
        REAL*4      CM             ! [1099] torsional bedding
        REAL*4      DRX            !        explicit X direction of support
        REAL*4      DRY            !        explicit Y direction of support
        REAL*4      DRZ            !        explicit Z direction of support
        REAL*4      D              ! [1001] distance to coupled line (IDS={5,6,7})
        REAL*4      R8
        REAL*4      R9
        REAL*4      FKA            !        factor bedding at start
        REAL*4      FKE            !        factor bedding at end
        REAL*4      TROT           !        Fractional rotation about local x-axis
        REAL*4      TAL(3)         !        Vector to be aligned as local axis
      END TYPE CGLN_SUPP
      INTEGER, PARAMETER :: LEN_CGLN_SUPP=23
      INTEGER, PARAMETER :: VER_CGLN_SUPP=200808

      TYPE CSLN_EXYZ               ! 39/NR:120  Explicit nodes on lines
        SEQUENCE
        INTEGER   ID               !        identifier = 120
        INTEGER   ID1              !        reserved
        REAL*4      XYZ(3,64)      ! [1001] XYZ coordinates
      END TYPE CSLN_EXYZ
      INTEGER, PARAMETER :: LEN_CSLN_EXYZ=194
      INTEGER, PARAMETER :: VER_CSLN_EXYZ=201301

      TYPE CGLN_EXYZ               ! 31/NR:120  Explicit nodes on lines
        SEQUENCE
        INTEGER   ID               !        identifier = 120
        INTEGER   ID1              !        reserved
        REAL*4      XYZ(3,64)      ! [1001] XYZ coordinates
      END TYPE CGLN_EXYZ
      INTEGER, PARAMETER :: LEN_CGLN_EXYZ=194
      INTEGER, PARAMETER :: VER_CGLN_EXYZ=201301

      TYPE CSLN_SCT                ! 39/NR:130  Beams sections
        SEQUENCE
        INTEGER   ID               !        identifier = 130
        INTEGER   REFT             !        Type of reference
        INTEGER   ITYP             !        Bitcodes according 100/NR:0 ITYP
        INTEGER   I1               !        reserved
        REAL*4      S              ! [1001] location on geometry
      END TYPE CSLN_SCT
      INTEGER, PARAMETER :: LEN_CSLN_SCT=5
      INTEGER, PARAMETER :: VER_CSLN_SCT=201405

      TYPE CGLN_SCT                ! 31/NR:130  Beams sections
        SEQUENCE
        INTEGER   ID               !        identifier = 130
        INTEGER   REFT             !        Type of reference
        INTEGER   ITYP             !        Bitcodes according 100/NR:0 ITYP
        INTEGER   I1               !        reserved
        REAL*4      S              ! [1001] location on geometry
      END TYPE CGLN_SCT
      INTEGER, PARAMETER :: LEN_CGLN_SCT=5
      INTEGER, PARAMETER :: VER_CGLN_SCT=201405

      TYPE CSAR                    ! 39/NR:200  Structural area
        SEQUENCE
        INTEGER   ID               !        identification of general data = 200
        INTEGER   IDS              !        identifier of structural area (0=auto)
        INTEGER   REF              !        reference to a given GAR [chr] or SAR [int]
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   NOR              !        number of reinforc.
        INTEGER   ITP              !        Bitpattern for element generation QUAD
        INTEGER   IBC              !        Boundary condition
        INTEGER   KR               !        local orientation QUADs
        INTEGER   IATR             !        Bitpattern for attribut areas (see SBOX_PROP)
        REAL*4      TD(0:4)        ! [1010] Constant thickness
        REAL*4      CB             !        bedding factor
        REAL*4      CQ             !        tangential bedding factor
        REAL*4      TUP(3)         !        Vector to define upward direction
        REAL*4      TROT           !        Fractional rotation about local z-axis
        REAL*4      TAL(3)         !        Vector to be aligned as local axis
        REAL*4      H(7)           ! [1001] mesh density parameters
        INTEGER   TEXT(17)         !        Designation of surface
      END TYPE CSAR
      INTEGER, PARAMETER :: LEN_CSAR=48
      INTEGER, PARAMETER :: VER_CSAR=200808

      TYPE CSAR_INF                ! 39/NR:210  GeometricAreaInfo
        SEQUENCE
        INTEGER   ID0              !        identifier 210
        INTEGER   NG               !        Type of surface representation
        INTEGER   GID1             !        Axis identifier of first reference axis
        INTEGER   GID2             !        Axis identifier of second reference axis
        REAL*4      T(3,4)         !        Transformation
        REAL*4      UV(2,2)        !        umin,umax,vmin,vmax of the parameter plane
      END TYPE CSAR_INF
      INTEGER, PARAMETER :: LEN_CSAR_INF=20
      INTEGER, PARAMETER :: VER_CSAR_INF=200808

      TYPE CSAR_PTS                ! 39/NR:211  AreaPointonSurface
        SEQUENCE
        INTEGER   ID               !        Identifier 211
        INTEGER   IT               !        Type of point (see 5/ID:11 for more)
        INTEGER   M                !        Rasterlocation of mesh (0 < m < mgri )
        INTEGER   N                !        Rasterlocation of mesh (0 < n < ngri )
        REAL*4      W              !        the weight of NURBS control point
        REAL*4      X              ! [1001] X-ordinate
        REAL*4      Y              ! [1001] Y-ordinate
        REAL*4      Z              ! [1001] Z-ordinate
        REAL*4      T              ! [1010] Thickness
      END TYPE CSAR_PTS
      INTEGER, PARAMETER :: LEN_CSAR_PTS=9
      INTEGER, PARAMETER :: VER_CSAR_PTS=200808

      TYPE CSAR_CPI                ! 39/NR:212  COONsPatchInfo
        SEQUENCE
        INTEGER   ID               !        Id = 212
        INTEGER   IT               !        Type of blending
        INTEGER   IU0              !        No of geometry line for u=umin (left)
        INTEGER   IU1              !        No of geometry line for u=umax (right)
        INTEGER   IV0              !        No of geometry line for v=vmin (lower)
        INTEGER   IV1              !        No of geometry line for v=vmax (upper)
      END TYPE CSAR_CPI
      INTEGER, PARAMETER :: LEN_CSAR_CPI=6
      INTEGER, PARAMETER :: VER_CSAR_CPI=200702

      TYPE CSAR_EXYZ               ! 39/NR:220  Explicit QUAD nodes on area
        SEQUENCE
        INTEGER   ID               !        identifier = 220
        INTEGER   ID1              !        reserved
        REAL*4      XYZ(3,4)       ! [1001] XYZ coordinates
      END TYPE CSAR_EXYZ
      INTEGER, PARAMETER :: LEN_CSAR_EXYZ=14
      INTEGER, PARAMETER :: VER_CSAR_EXYZ=201301

      TYPE CGAR_EXYZ               ! 32/NR:220  Explicit QUAD nodes on area
        SEQUENCE
        INTEGER   ID               !        identifier = 220
        INTEGER   ID1              !        reserved
        REAL*4      XYZ(3,4)       ! [1001] XYZ coordinates
      END TYPE CGAR_EXYZ
      INTEGER, PARAMETER :: LEN_CGAR_EXYZ=14
      INTEGER, PARAMETER :: VER_CGAR_EXYZ=201301

      TYPE CSAR_SUPP               ! 39/NR:221  Support and coupling of structural areas
        SEQUENCE
        INTEGER   ID               !        identifier 221
        INTEGER   IDS              !        type of reference
        INTEGER   REF              !        reference identifier
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   IBC              !        Boundary condition / kinematic constraints
        INTEGER   I6               !        reserved
        INTEGER   RCTL             !        properties of area-area reference
        INTEGER   RPTR             !        reference point on boundary of referenced area
        INTEGER   RPT0             !        reference point on boundary of given area
        INTEGER   I10              !        reserved
        REAL*4      D              ! [1001] distance of interface layer
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
      END TYPE CSAR_SUPP
      INTEGER, PARAMETER :: LEN_CSAR_SUPP=14
      INTEGER, PARAMETER :: VER_CSAR_SUPP=201408

      TYPE CGAR_SUPP               ! 32/NR:221  Support and coupling of structural areas
        SEQUENCE
        INTEGER   ID               !        identifier 221
        INTEGER   IDS              !        type of reference
        INTEGER   REF              !        reference identifier
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   IBC              !        Boundary condition / kinematic constraints
        INTEGER   I6               !        reserved
        INTEGER   RCTL             !        properties of area-area reference
        INTEGER   RPTR             !        reference point on boundary of referenced area
        INTEGER   RPT0             !        reference point on boundary of given area
        INTEGER   I10              !        reserved
        REAL*4      D              ! [1001] distance of interface layer
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
      END TYPE CGAR_SUPP
      INTEGER, PARAMETER :: LEN_CGAR_SUPP=14
      INTEGER, PARAMETER :: VER_CGAR_SUPP=201408

      TYPE CSVO                    ! 39/NR:300  StructuralVolume
        SEQUENCE
        INTEGER   ID               !        identification = 300
        INTEGER   IDS              !        identifier of structural area (0=auto)
        INTEGER   REF              !        reference to a given GVO (reserved)
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   NOR              !        number of reinforc.
        INTEGER   NOT              !        number of elementtype
        INTEGER   IBC              !        Boundary condition
        INTEGER   ID8              !        reserved
        INTEGER   ID9              !        reserved
        INTEGER   TEXT(17)         !        Designation of Volume
      END TYPE CSVO
      INTEGER, PARAMETER :: LEN_CSVO=27
      INTEGER, PARAMETER :: VER_CSVO=200808

      TYPE CSMB_ATTR               ! 39/NR:997  Attributes of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 997
        INTEGER   I1               !        reserved
        INTEGER   I2               !        reserved
        INTEGER   GRXA             !        identifier of 1st grid axis x-x
        INTEGER   GRYA             !        identifier of 2nd grid axis y-y
        INTEGER   ELVB             !        identifier of elevation at bottom
        INTEGER   ELVT             !        identifier of elevation at top
        INTEGER   DPOS             !        Identifier of design group membership
        INTEGER   DTXT(17)         !        Designation of design group membership
      END TYPE CSMB_ATTR
      INTEGER, PARAMETER :: LEN_CSMB_ATTR=25
      INTEGER, PARAMETER :: VER_CSMB_ATTR=201607

      TYPE CSPT_ATTR               ! 30/NR:997  Attributes of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 997
        INTEGER   I1               !        reserved
        INTEGER   I2               !        reserved
        INTEGER   GRXA             !        identifier of 1st grid axis x-x
        INTEGER   GRYA             !        identifier of 2nd grid axis y-y
        INTEGER   ELVB             !        identifier of elevation at bottom
        INTEGER   ELVT             !        identifier of elevation at top
        INTEGER   DPOS             !        Identifier of design group membership
        INTEGER   DTXT(17)         !        Designation of design group membership
      END TYPE CSPT_ATTR
      INTEGER, PARAMETER :: LEN_CSPT_ATTR=25
      INTEGER, PARAMETER :: VER_CSPT_ATTR=0

      TYPE CSLN_ATTR               ! 31/NR:997  Attributes of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 997
        INTEGER   I1               !        reserved
        INTEGER   I2               !        reserved
        INTEGER   GRXA             !        identifier of 1st grid axis x-x
        INTEGER   GRYA             !        identifier of 2nd grid axis y-y
        INTEGER   ELVB             !        identifier of elevation at bottom
        INTEGER   ELVT             !        identifier of elevation at top
        INTEGER   DPOS             !        Identifier of design group membership
        INTEGER   DTXT(17)         !        Designation of design group membership
      END TYPE CSLN_ATTR
      INTEGER, PARAMETER :: LEN_CSLN_ATTR=25
      INTEGER, PARAMETER :: VER_CSLN_ATTR=0

      TYPE CSAR_ATTR               ! 32/NR:997  Attributes of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 997
        INTEGER   I1               !        reserved
        INTEGER   I2               !        reserved
        INTEGER   GRXA             !        identifier of 1st grid axis x-x
        INTEGER   GRYA             !        identifier of 2nd grid axis y-y
        INTEGER   ELVB             !        identifier of elevation at bottom
        INTEGER   ELVT             !        identifier of elevation at top
        INTEGER   DPOS             !        Identifier of design group membership
        INTEGER   DTXT(17)         !        Designation of design group membership
      END TYPE CSAR_ATTR
      INTEGER, PARAMETER :: LEN_CSAR_ATTR=25
      INTEGER, PARAMETER :: VER_CSAR_ATTR=0

      TYPE CSMB_GUID               ! 39/NR:999  Unique identifier of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 999
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of preceeding element
      END TYPE CSMB_GUID
      INTEGER, PARAMETER :: LEN_CSMB_GUID=37
      INTEGER, PARAMETER :: VER_CSMB_GUID=0

      TYPE CSPT_GUID               ! 30/NR:999  Unique identifier of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 999
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of preceeding element
      END TYPE CSPT_GUID
      INTEGER, PARAMETER :: LEN_CSPT_GUID=37
      INTEGER, PARAMETER :: VER_CSPT_GUID=0

      TYPE CSLN_GUID               ! 31/NR:999  Unique identifier of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 999
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of preceeding element
      END TYPE CSLN_GUID
      INTEGER, PARAMETER :: LEN_CSLN_GUID=37
      INTEGER, PARAMETER :: VER_CSLN_GUID=0

      TYPE CSAR_GUID               ! 32/NR:999  Unique identifier of structural member
        SEQUENCE
        INTEGER   ID               !        identifier 999
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of preceeding element
      END TYPE CSAR_GUID
      INTEGER, PARAMETER :: LEN_CSAR_GUID=37
      INTEGER, PARAMETER :: VER_CSAR_GUID=0

      INTEGER, PARAMETER :: GPT_IBC_SUP=8192
      INTEGER, PARAMETER :: GPT_IBC_REF=32768
      TYPE CGPT                    ! 30/NR:0  Structural points
        SEQUENCE
        INTEGER   ID               !        identifier 0 (always the first record)
        INTEGER   IBC              !        Boundary condition
        REAL*4      XYZ(3)         ! [1001] Ordinates
        REAL*4      T(3,3)         !        transformation matrix
        REAL*4      BX             ! [1001] Dimension in x
        REAL*4      BY             ! [1001] Dimension in y
        REAL*4      THICK          ! [1010] Plate thickness
        REAL*4      HMESH          ! [1001] Mesh density at point
        REAL*4      R17            !        reserved
        INTEGER   TEXT(17)         !        Designation of Point
      END TYPE CGPT
      INTEGER, PARAMETER :: LEN_CGPT=36
      INTEGER, PARAMETER :: VER_CGPT=201303

      TYPE CGPT_COH                ! 30/NR:1  Dimension of column head
        SEQUENCE
        INTEGER   ID               !        identifier 1/2/3
        INTEGER   NS               !        Number of a cross section 9/NR for details
        REAL*4      X              ! [1001] Width in local x
        REAL*4      Y              ! [1001] Width in local y
        REAL*4      A              ! [1002] Equivalent Area
        REAL*4      T              ! [1010] Plate thickness
      END TYPE CGPT_COH
      INTEGER, PARAMETER :: LEN_CGPT_COH=6
      INTEGER, PARAMETER :: VER_CGPT_COH=200501

      TYPE CGPT_HAU                ! 30/NR:2  Dimension of voute
        SEQUENCE
        INTEGER   ID               !        identifier 1/2/3
        INTEGER   NS               !        Number of a cross section 9/NR for details
        REAL*4      X              ! [1001] Width in local x
        REAL*4      Y              ! [1001] Width in local y
        REAL*4      A              ! [1002] Equivalent Area
        REAL*4      T              ! [1010] Plate thickness
      END TYPE CGPT_HAU
      INTEGER, PARAMETER :: LEN_CGPT_HAU=6
      INTEGER, PARAMETER :: VER_CGPT_HAU=200501

      TYPE CGPT_PUN                ! 30/NR:3  Dimension of punching perimeter
        SEQUENCE
        INTEGER   ID               !        identifier 1/2/3
        INTEGER   NS               !        Number of a cross section 9/NR for details
        REAL*4      X              ! [1001] Width in local x
        REAL*4      Y              ! [1001] Width in local y
        REAL*4      A              ! [1002] Equivalent Area
        REAL*4      T              ! [1010] Plate thickness
      END TYPE CGPT_PUN
      INTEGER, PARAMETER :: LEN_CGPT_PUN=6
      INTEGER, PARAMETER :: VER_CGPT_PUN=200501

      TYPE CGPT_COL                ! 30/NR:4  Connecting columns
        SEQUENCE
        INTEGER   ID               !        identifier 4
        INTEGER   NS               !        Number of a cross section 9/NR for column
        REAL*4      X              ! [1001] Width in local x
        REAL*4      Y              ! [1001] Width in local y
        REAL*4      A              ! [1002] Equivalent Area
        REAL*4      L              ! [1001] Column length
        REAL*4      FAK            !        Rigidity factor
      END TYPE CGPT_COL
      INTEGER, PARAMETER :: LEN_CGPT_COL=7
      INTEGER, PARAMETER :: VER_CGPT_COL=200501

      TYPE CGPT_FOO                ! 30/NR:5  Footing instance definition
        SEQUENCE
        INTEGER   ID               !        identifier 5
        INTEGER   POS              !        referenced building position
        INTEGER   TYPE             !        Type of foundation
        INTEGER   IGP              !        Bitpattern Foundation Properties
        INTEGER   IDR              !        Bitpattern Design Results
        INTEGER   IR1              !        reserved
        INTEGER   MNO              !        Id of concrete material
        INTEGER   MRF              !        Id of reinforcement material
        INTEGER   NRSP             !        Id of soil profile (002/NR)
        REAL*4      T(3,3)         !        Orientation of local coordinate system
        REAL*4      BX             ! [1001] Width in local x
        REAL*4      BY             ! [1001] Width in local y
        REAL*4      HI             ! [1001] inner Thickness
        REAL*4      HA             ! [1001] outer Thickness
        REAL*4      EX             ! [1001] Eccentricity of column in local x-direction
        REAL*4      EY             ! [1001] Eccentricity of column in local y-direction
        REAL*4      EZ             ! [1001] Eccentricity of endpoint of column(=structural point) in local 
        REAL*4      CLX            ! [1011] Assumed dimension of column in local x-direction
        REAL*4      CLY            ! [1011] Assumed dimension of column in local y-direction
        REAL*4      SXT            ! [1024] Boundary distance of x-aligned reinforcement on top face
        REAL*4      SYT            ! [1024] Boundary distance of y-aligned reinforcement on top face
        REAL*4      SXB            ! [1024] Boundary distance of x-aligned reinforcement on bottom face
        REAL*4      SYB            ! [1024] Boundary distance of y-aligned reinforcement on bottom face
        REAL*4      COVT           ! [1024] Concrete cover (nominal) on top face
        REAL*4      COVB           ! [1024] Concrete cover (nominal) on bottom face
        REAL*4      COVL           ! [1024] Concrete cover (nominal) on lateral faces
        REAL*4      RES1           !        Reserved
        REAL*4      RES2           !        Reserved
        REAL*4      RES3           !        Reserved
        REAL*4      RES4           !        Reserved
        REAL*4      SLHO           ! [1001] obsolete
        REAL*4      SLHI           ! [1001] obsolete
        REAL*4      SLWX           ! [1001] obsolete
        REAL*4      SLWY           ! [1001] obsolete
        REAL*4      SLGU           ! [1001] obsolete
        REAL*4      SLGL           ! [1001] obsolete
        REAL*4      DATA(12)       !        Reserved
        INTEGER   TITL(17)         !        Designation of Foundation
      END TYPE CGPT_FOO
      INTEGER, PARAMETER :: LEN_CGPT_FOO=73
      INTEGER, PARAMETER :: VER_CGPT_FOO=201411

      TYPE CGPT_FRR                ! 30/NR:1005  Footing required reinforcement
        SEQUENCE
        INTEGER   ID               !        identifier 1005
        INTEGER   TYPE             !        Type of reinforcement
        INTEGER   N_AS             !        number of values stored in array AS
        INTEGER   IR1              !        reserved
        INTEGER   IR2              !        reserved
        REAL*4      XOFF           ! [1001] offset of distribution in x-direction
        REAL*4      YOFF           ! [1001] offset of distribution in y-direction
        REAL*4      RES1           !        reserved
        REAL*4      RES2           !        reserved
        REAL*4      AS(32)         ! [1021] reinforcement values
      END TYPE CGPT_FRR
      INTEGER, PARAMETER :: LEN_CGPT_FRR=41
      INTEGER, PARAMETER :: VER_CGPT_FRR=201411

      TYPE CGPT_SLP                ! 30/NR:1006  Sleeve foundation properties
        SEQUENCE
        INTEGER   ID               !        identifier 1006
        INTEGER   IR1              !        reserved
        INTEGER   IR2              !        reserved
        INTEGER   IR3              !        reserved
        REAL*4      HSWO           ! [1001] Outer height of sleeve wall (measured from z=0 of local coordin
        REAL*4      HSWI           ! [1001] Inner height of sleeve wall (measured from upper face of sleeve
        REAL*4      WXWU           ! [1001] Upper width of sleeve wall in x-direction
        REAL*4      WYWU           ! [1001] Upper width of sleeve wall in y-direction
        REAL*4      WXWL           ! [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
        REAL*4      WYWL           ! [1001] Lower width of sleeve wall in y-direction
        REAL*4      WXGU           ! [1001] Upper width of gap between wall and column in x-direction
        REAL*4      WYGU           ! [1001] Upper width of gap between wall and column in y-direction
        REAL*4      WXGL           ! [1001] Lower width of gap between wall and column in x-direction
        REAL*4      WYGL           ! [1001] Lower width of gap between wall and column in y-direction
        REAL*4      CLX            ! [1011] Assumed dimension of column in local x-direction (deprecated)
        REAL*4      CLY            ! [1011] Assumed dimension of column in local y-direction (deprecated)
      END TYPE CGPT_SLP
      INTEGER, PARAMETER :: LEN_CGPT_SLP=16
      INTEGER, PARAMETER :: VER_CGPT_SLP=201503

      TYPE CGPT_HPI                ! 30/NR:6  Halfspace pile
        SEQUENCE
        INTEGER   ID               !        identifier 6
        INTEGER   NQ               !        number cross section   =0 if diameter from 030/NR:0
        REAL*4      L              ! [1001] pile length in GDIR direction
        REAL*4      MANT           !        percentage of skin friction for linear analysis
        REAL*4      ZMAN           !        percentage of inactive skin length
        REAL*4      PMAN           ! [1151] maximum load skin friction (nonlinear analysis)
        REAL*4      PMAF           ! [1151] maximum load pile foot
      END TYPE CGPT_HPI
      INTEGER, PARAMETER :: LEN_CGPT_HPI=7
      INTEGER, PARAMETER :: VER_CGPT_HPI=200501

      TYPE CGPT_CON_M              !        connected members
        SEQUENCE
        INTEGER   NELT
        INTEGER   NREL
        INTEGER   NODE
        INTEGER   NARB
        REAL*4      X              ! [1001] 
      END TYPE CGPT_CON_M
      INTEGER, PARAMETER :: LEN_CGPT_CON_M=5

      TYPE CGPT_CON                ! 30/NR:8  Steelconnection reference
        SEQUENCE
        INTEGER   ID               !        identifier 8
        INTEGER   CONID            !        connection identifier
        TYPE(CGPT_CON_M) M(15)     !        connected members
      END TYPE CGPT_CON
      INTEGER, PARAMETER :: LEN_CGPT_CON=77
      INTEGER, PARAMETER :: VER_CGPT_CON=200501

      TYPE CGPT_SPR                ! 30/NR:10  Elastic Spring support
        SEQUENCE
        INTEGER   ID               !        identifier 10
        INTEGER   IRI              !        direction
        INTEGER   NR               !        element number
        INTEGER   NG               !        group number
        INTEGER   IPC              !        connecting to node
        INTEGER   NWL              !        Reference to work-law / material no
        REAL*4      T(3)           !        explicit direction (dx,dy,dz)
        REAL*4      AREF           !        reference / influence area (see also  184 170/0 )
        REAL*4      CP             ! [1095] spring stiffness z
        REAL*4      CQ             ! [1095] transverse stiff.
        REAL*4      CM             ! [1098] torsional stiff.
        REAL*4      PRE            !        prestress for cp
        REAL*4      GAP            !        slip of spring
        REAL*4      RISS           !        max tension force
        REAL*4      FLIE           !        yielding load
        REAL*4      MUE            !        friction cross
        REAL*4      COH            !        cohesion cross
        REAL*4      DIL            !        dilatancy factor
        REAL*4      GAPQ           !        transverse slip/gap
      END TYPE CGPT_SPR
      INTEGER, PARAMETER :: LEN_CGPT_SPR=21
      INTEGER, PARAMETER :: VER_CGPT_SPR=201307

      TYPE CGPT_KIN                ! 30/NR:11  Kinematic Constraint
        SEQUENCE
        INTEGER   ID               !        identifier 11
        INTEGER   KTL              !        type +  10000*group-number
        INTEGER   KR1              !        reference GPT 1
        INTEGER   KR2              !        reference GPT 2
        REAL*4      DX             !        direction of coupling X-axis
        REAL*4      DY             !        direction of coupling Y-axis
        REAL*4      DZ             !        direction of coupling Z-axis
        REAL*4      DD             !        factor of interpolation
        REAL*4      FF             !        factor of multiplication
      END TYPE CGPT_KIN
      INTEGER, PARAMETER :: LEN_CGPT_KIN=9
      INTEGER, PARAMETER :: VER_CGPT_KIN=200501

      TYPE CGPT_SPC                ! 30/NR:12  Elastic Spring connection (obsoleted)
        SEQUENCE
        INTEGER   ID               !        identifier 12
        INTEGER   IRI              !        direction + 100*sign(group number,direction)
        INTEGER   IPC              !        connecting Spoint
        INTEGER   NWL              !        work law number
        REAL*4      CP             ! [1095] spring stiffness z
        REAL*4      CQ             ! [1095] transverse stiff.
        REAL*4      CM             ! [1098] torsional stiff.
        REAL*4      PRE            !        prestress for cp
        REAL*4      GAP            !        slip of spring
        REAL*4      RISS           !        max tension force
        REAL*4      FLIE           !        yielding load
        REAL*4      MUE            !        friction cross
        REAL*4      COH            !        cohesion cross
        REAL*4      DIL            !        dilatancy factor
      END TYPE CGPT_SPC
      INTEGER, PARAMETER :: LEN_CGPT_SPC=14
      INTEGER, PARAMETER :: VER_CGPT_SPC=200911

      TYPE CGPT_DADS               ! 30/NR:998  List of origin ids the structural member has been created from
        SEQUENCE
        INTEGER   ID               !        ident 998
        INTEGER   IDD(63)          !        ids of all anchestors
      END TYPE CGPT_DADS
      INTEGER, PARAMETER :: LEN_CGPT_DADS=64
      INTEGER, PARAMETER :: VER_CGPT_DADS=200808

      TYPE CGLN                    ! 31/NR:0  Structural lines
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   PT(2)            !        Number start & end point
        INTEGER   I3               !        reserved
        INTEGER   IBT              !        Bitpattern of element properties acc. 39/NR:100 IBT
        INTEGER   IBC              !        Boundary condition acc. 39/NR:100 IBC
        REAL*4      I_0(10)        !        reserved
        REAL*4      HMESH          ! [1001] mesh density along line acc. 39/NR:100 HMESH
        REAL*4      I_11(3)        !        reserved
        REAL*4      PROG           !        progression factor (>0 monoton, <0 symmetric)
        REAL*4      I_15
        INTEGER   TEXT(17)         !        Designation of Line
      END TYPE CGLN
      INTEGER, PARAMETER :: LEN_CGLN=39
      INTEGER, PARAMETER :: VER_CGLN=201303

      TYPE CGLN_REF                ! 31/NR:-  Reference to another Geometry
        SEQUENCE
        INTEGER   IGM              !        negative value of the master geometry
        INTEGER   IGS              !        optional identifier of a secondary axis
        REAL*4      SMIN           !        min parameter on referenced axis
        REAL*4      SMAX           !        max parameter on referenced axis
      END TYPE CGLN_REF
      INTEGER, PARAMETER :: LEN_CGLN_REF=4
      INTEGER, PARAMETER :: VER_CGLN_REF=200501

      INTEGER, PARAMETER :: GLN_GEO_DEFAULT=1
      INTEGER, PARAMETER :: GLN_GEO_KLOTOID=2
      INTEGER, PARAMETER :: GLN_GEO_SPLINE=3
      INTEGER, PARAMETER :: GLN_GEO_EXSPLI=4
      INTEGER, PARAMETER :: GLN_GEO_BEZIER=5
      INTEGER, PARAMETER :: GLN_GEO_NURBS=6
      INTEGER, PARAMETER :: GLN_GEO_NURBX=7
      INTEGER, PARAMETER :: GLN_GEO_DATA=8
      INTEGER, PARAMETER :: GLN_GEO_NORM=9
      INTEGER, PARAMETER :: GLN_GEO_CIRC=10
      INTEGER, PARAMETER :: GLN_GEO_DWN_POSY=+2
      INTEGER, PARAMETER :: GLN_GEO_DWN_NEGY=-2
      INTEGER, PARAMETER :: GLN_GEO_DWN_POSZ=+3
      INTEGER, PARAMETER :: GLN_GEO_DWN_NEGZ=-3
      TYPE CGLN_GEO                ! 31/NR:??  Geometric properties
        SEQUENCE
        INTEGER   ILN              !        Code of geometry
        REAL*4      GPG            ! [1001] geometry parameter 1
        REAL*4      GPA            ! [1001] geometry parameter 2
        REAL*4      DD             ! [1001] arc length
        REAL*4      S1             !        parameter s on start
        REAL*4      XYZ1(3)        ! [1001] Ordinate of start
        REAL*4      DXYZ1(3)       !        Tangent of start
        REAL*4      RG1            ! [1009] in-plane curvature
        REAL*4      RA1            ! [1009] vertical curvature
        REAL*4      S2             !        parameter s on end
        REAL*4      XYZ2(3)        ! [1001] Ordinate of endpoint
        REAL*4      DXYZ2(3)       !        Tangent of endpoint
        REAL*4      RG2            ! [1009] in-plane curvature
        REAL*4      RA2            ! [1009] vertical curvature
      END TYPE CGLN_GEO
      INTEGER, PARAMETER :: LEN_CGLN_GEO=22
      INTEGER, PARAMETER :: VER_CGLN_GEO=200501

! COMPATIBLE EFFECTIVE SHORTER LENGTH OF STRUCTURE
! LEN_C3101_BUF AT LEAST LEN_CGLN_GEO+1
      INTEGER, PARAMETER :: LEN_C3101_BUF = 256   ! BUFFERLENGTH
      INTEGER, PARAMETER :: LEN_C3101     = 1+21  ! MINLENGTH
      INTEGER, PARAMETER :: MAX_C3101     = 64    ! MAX NO OF SEGMENTS
      INTEGER, PARAMETER :: GLN_BEAM_IBC_LOCAL=16384
      INTEGER, PARAMETER :: GLN_BEAM_IBC_NFREE=32768
      TYPE CGLN_BEAM               ! 31/NR:100  Properties of beams (obsoleted)
        SEQUENCE
        INTEGER   ID               !        ident 100
        INTEGER   NOG              !        Element type
        INTEGER   NQ               !        number cross section
        INTEGER   NP               !        number bedding props
        INTEGER   IBC              !        Hinge code
        INTEGER   DIV              !        prescribed subdivision no of segments
        REAL*4      EYA            ! [1001] eccentricity at start
        REAL*4      EZA            ! [1001] eccentricity at start
        REAL*4      EYE            ! [1001] eccentricity at end
        REAL*4      EZE            ! [1001] eccentricity at end
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
        REAL*4      CM             ! [1099] torsional bedding
        REAL*4      CX             ! [1096] global X  bedding
        REAL*4      CY             ! [1096] global Y  bedding
        REAL*4      CZ             ! [1096] global Z  bedding
        REAL*4      CXX            ! [1099] global X  tors.bed.
        REAL*4      CYY            ! [1099] global Y  tors.bed.
        REAL*4      CZZ            ! [1099] global Z  tors.bed.
      END TYPE CGLN_BEAM
      INTEGER, PARAMETER :: LEN_CGLN_BEAM=19
      INTEGER, PARAMETER :: VER_CGLN_BEAM=200501

      TYPE CGLN_ELNR               ! 31/NR:121  Elements generated on lines
        SEQUENCE
        INTEGER   ID               !        identifier = 121
        INTEGER   ETYP             !        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
        INTEGER   IBIT             !        Bit-code
        INTEGER   NR(253)          !        packed list of element numbers
      END TYPE CGLN_ELNR
      INTEGER, PARAMETER :: LEN_CGLN_ELNR=256
      INTEGER, PARAMETER :: VER_CGLN_ELNR=201301

      TYPE CGLN_DADS               ! 31/NR:998  Ids of items being an anchestor
        SEQUENCE
        INTEGER   ID               !        ident 998
        INTEGER   IDD(63)          !        ids of all anchestors
      END TYPE CGLN_DADS
      INTEGER, PARAMETER :: LEN_CGLN_DADS=64
      INTEGER, PARAMETER :: VER_CGLN_DADS=200808

      INTEGER, PARAMETER :: GAR_IBC_REF=32768
      TYPE CGAR                    ! 32/NR:0  Structural area
        SEQUENCE
        INTEGER   ID               !        identification of general data (0)
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   NOR              !        number of reinforc.
        INTEGER   ITP              !        Bitpattern for element generation QUAD
        INTEGER   IBC              !        Boundary condition
        REAL*4      TD(0:4)        ! [1010] Constant thickness
        REAL*4      CB             !        bedding factor
        REAL*4      CQ             !        tangential bedding factor
        REAL*4      TROT           !        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
        REAL*4      TAL(3)         !        Vector to be aligned as local axis
        INTEGER   TEXT(17)         !        Designation of surface
      END TYPE CGAR
      INTEGER, PARAMETER :: LEN_CGAR=34
      INTEGER, PARAMETER :: VER_CGAR=200501

      TYPE CGAR_REF                ! 32/NR:-  Reference to another Geometry
        SEQUENCE
        INTEGER   IGM              !        negative value of the master geometry
      END TYPE CGAR_REF
      INTEGER, PARAMETER :: LEN_CGAR_REF=1
      INTEGER, PARAMETER :: VER_CGAR_REF=200501

      TYPE CGAR_BOUN               ! 32/NR:1  Outer Boundary of Area
        SEQUENCE
        INTEGER   ID               !        identification
        INTEGER   NG               !        edgeno     (31/NG)
        INTEGER   NA               !        startpoint (30/NA)
        INTEGER   NB               !        endpoint   (30/NB)
        INTEGER   NM               !        midpoint   (30/NM)
        INTEGER   IFC              !        Interface hinge bit pattern
        REAL*4      T              ! [1010] Plate thickness of edge
        REAL*4      DFIX           ! [1001] Distance (offset) of region to edge
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
        REAL*4      CM             ! [1099] torsional bedding
      END TYPE CGAR_BOUN
      INTEGER, PARAMETER :: LEN_CGAR_BOUN=11
      INTEGER, PARAMETER :: VER_CGAR_BOUN=200501

      TYPE CGAR_HOLE               ! 32/NR:2  Inner Boundary of Area
        SEQUENCE
        INTEGER   ID               !        identification
        INTEGER   NG               !        edgeno     (31/NG)
        INTEGER   NA               !        startpoint (30/NA)
        INTEGER   NB               !        endpoint   (30/NB)
        INTEGER   NM               !        midpoint   (30/NM)
        INTEGER   IFC              !        Interface hinge bit pattern
        REAL*4      T              ! [1010] Plate thickness of edge
        REAL*4      DFIX           ! [1001] Distance (offset) of region to edge
        REAL*4      CA             ! [1096] axial     bedding
        REAL*4      CQ             ! [1096] lateral   bedding
        REAL*4      CM             ! [1099] torsional bedding
      END TYPE CGAR_HOLE
      INTEGER, PARAMETER :: LEN_CGAR_HOLE=11
      INTEGER, PARAMETER :: VER_CGAR_HOLE=200501

      TYPE CGAR_CON3               ! 32/NR:3  Prescribed Edges/Points
        SEQUENCE
        INTEGER   ID               !        identification
        INTEGER   NG               !        edgenumber (31/NG)
        INTEGER   NA               !        startpoint (30/NA)
        INTEGER   NB               !        endpoint   (30/NB)
        INTEGER   NM               !        midpoint   (30/NM)
        INTEGER   MAT              !        Materialnumber of subregion for ID==4
        REAL*4      T              ! [1010] Plate thickness at edge or point
      END TYPE CGAR_CON3
      INTEGER, PARAMETER :: LEN_CGAR_CON3=7
      INTEGER, PARAMETER :: VER_CGAR_CON3=200501

      TYPE CGAR_CON4               ! 32/NR:4  Domain-Subdivision-Edges
        SEQUENCE
        INTEGER   ID               !        identification
        INTEGER   NG               !        edgenumber (31/NG)
        INTEGER   NA               !        startpoint (30/NA)
        INTEGER   NB               !        endpoint   (30/NB)
        INTEGER   NM               !        midpoint   (30/NM)
        INTEGER   MAT              !        Materialnumber of subregion for ID==4
        REAL*4      T              ! [1010] Plate thickness at edge or point
      END TYPE CGAR_CON4
      INTEGER, PARAMETER :: LEN_CGAR_CON4=7
      INTEGER, PARAMETER :: VER_CGAR_CON4=200501

      TYPE CGAR_MESH               ! 32/NR:9  Prescribed Mesh size
        SEQUENCE
        INTEGER   ID               !        identification
        INTEGER   NG               !        number of support macro generating mesh
        INTEGER   NA               !        startedge  (31/NA)
        INTEGER   NB               !        endedge    (31/NB)
        INTEGER   I4               !        not used
        INTEGER   I5               !        not used
        REAL*4      HSIZE(3)       ! [1001] requested mesh size
        REAL*4      PTA(3)         ! [1001] Coordinates of startpoint
        REAL*4      PTE(3)         ! [1001] Coordinates of endpoint
        REAL*4      PTM(3)         ! [1001] Coordinates of midpoint
      END TYPE CGAR_MESH
      INTEGER, PARAMETER :: LEN_CGAR_MESH=18
      INTEGER, PARAMETER :: VER_CGAR_MESH=201109

      TYPE CGAR_GEO                ! 32/NR:10  Geometry of surface
        SEQUENCE
        INTEGER   ID               !        Identification of surface description 10
        INTEGER   NG               !        Type of surface representation
        INTEGER   MGRI             !        number of data/control points in s of mesh
        INTEGER   NGRI             !        number of data/control points in t of mesh
        INTEGER   MSPL             !        degree of B-spline in s direction
        INTEGER   NSPL             !        degree of B-spline in t direction
        REAL*4      SX             !        plane  direction sx
        REAL*4      SY             !        plane  direction sy
        REAL*4      SZ             !        plane  direction sz
        REAL*4      TX             !        plane  direction tx
        REAL*4      TY             !        plane  direction ty
        REAL*4      TZ             !        plane  direction tz
        REAL*4      NX             !        normal direction nx
        REAL*4      NY             !        normal direction ny
        REAL*4      NZ             !        normal direction nz
        REAL*4      X              ! [1001] X-ordinate Origin
        REAL*4      Y              ! [1001] Y-ordinate Origin
        REAL*4      Z              ! [1001] Z-ordinate Origin
        REAL*4      PAR(0:15)      !        additional Parameters
        REAL*4      BOX(2,3)       ! [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        REAL*4      XPAR(1)        !        extended parameters
                                   !        unknwon length!
      END TYPE CGAR_GEO
      INTEGER, PARAMETER :: LEN_CGAR_GEO=41
      INTEGER, PARAMETER :: VER_CGAR_GEO=200501

      INTEGER, PARAMETER :: MAXDEG_3210=32  ! MAX OF DEGREE
      INTEGER, PARAMETER :: MAXGRD_3210=64  ! MAX OF GRID-POINTS
      INTEGER, PARAMETER :: MAXNNP_3210=128 ! GRID+2*(DEG-1)
      INTEGER, PARAMETER :: MAXCSP_3210=5*(MAXGRD_3210)**2
 
      TYPE C3210   ! 32/NR:10-AREA DEFINITION
           SEQUENCE
           INTEGER IAG(0:5)
           REAL    TA(3,4),PAR(0:15),BOX(2,3)
           REAL    TU(MAXNNP_3210),TV(MAXNNP_3210),CSPL(MAXCSP_3210)
      END TYPE
      INTEGER, PARAMETER :: LEN_C3210=6+34 ! MIN.LENGTH OF C3200
 
      TYPE CGAR_SURF               ! 32/NR:11  UserPointonSurface
        SEQUENCE
        INTEGER   ID               !        Identification of user surface description 11
        INTEGER   IT               !        Type of point
        INTEGER   M                !        Rasterlocation of mesh 0 < m ( mgri )
        INTEGER   N                !        Rasterlocation of mesh 0 < n ( ngri )
        INTEGER   N3               !        the degree of the Spline becoming effective
        INTEGER   N4               !        the weight of NURBS control point [-]
        REAL*4      X              ! [1001] X-ordinate
        REAL*4      Y              ! [1001] Y-ordinate
        REAL*4      Z              ! [1001] Z-ordinate
        REAL*4      T              ! [1010] Thickness
      END TYPE CGAR_SURF
      INTEGER, PARAMETER :: LEN_CGAR_SURF=10
      INTEGER, PARAMETER :: VER_CGAR_SURF=200501

      TYPE CGAR_COON               ! 32/NR:12  COONsPatchInfo
        SEQUENCE
        INTEGER   ID               !        Identification of COONs blending edges 12
        INTEGER   IT               !        Type of blending
        INTEGER   IU0              !        No of geometry line for u=umin (left)
        INTEGER   IU1              !        No of geometry line for u=umax (right)
        INTEGER   IV0              !        No of geometry line for v=vmin (lower)
        INTEGER   IV1              !        No of geometry line for v=vmax (upper)
        REAL*4      SP(3,4)        !        Length parameters for the edges iu0,iu1,iv0,iv1
        REAL*4      UV(2,2)        !        umin,umax,vmin,vmax of the parameter plane
        REAL*4      CXYZ(3,4)      !        Coordinates of the corner points C1,C2,C3,C4
        REAL*4      TINC(3,8)      !        inclinations for a bicubic patch as vectors
        REAL*4      TWIST(3,4)     !        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END TYPE CGAR_COON
      INTEGER, PARAMETER :: LEN_CGAR_COON=70
      INTEGER, PARAMETER :: VER_CGAR_COON=201303

      TYPE CGAR_ELNR               ! 32/NR:221  Generated elements from area
        SEQUENCE
        INTEGER   ID               !        identifier = 221
        INTEGER   ETYP             !        Type of element {200,...} for {QUAD,...}
        INTEGER   ID2              !        reserved
        INTEGER   NR(253)          !        packed list of element numbers
      END TYPE CGAR_ELNR
      INTEGER, PARAMETER :: LEN_CGAR_ELNR=256
      INTEGER, PARAMETER :: VER_CGAR_ELNR=201301

      TYPE CGAR_DADS               ! 32/NR:998  Ids of items being an anchestor
        SEQUENCE
        INTEGER   ID               !        ident 998
        INTEGER   IDD(63)          !        ids of all anchestors
      END TYPE CGAR_DADS
      INTEGER, PARAMETER :: LEN_CGAR_DADS=64
      INTEGER, PARAMETER :: VER_CGAR_DADS=200808

      TYPE CGVO                    ! 33/NR:0  StructuralVolume
        SEQUENCE
        INTEGER   ID               !        identification of general data (0)
        INTEGER   NOG              !        number of group
        INTEGER   NOM              !        number of material
        INTEGER   NOR              !        number of reinforc.
        INTEGER   NOT              !        number of elementtype
        INTEGER   IBC              !        Boundary condition
        INTEGER   TEXT(17)         !        Designation of Volume
      END TYPE CGVO
      INTEGER, PARAMETER :: LEN_CGVO=23
      INTEGER, PARAMETER :: VER_CGVO=200501

      TYPE CGVO_SURF               ! 33/NR:+  Involved Surfaces
        SEQUENCE
        INTEGER   ITP              !        identification of definition
        INTEGER   NG               !        surface    (32/NG)
        INTEGER   NR               !        extrusion or rotation geometry identifier
        INTEGER   NREF             !        optional number of a reference point
        INTEGER   NARA             !        region identifier for start surface
        INTEGER   NARE             !        region identifier for end surface
        REAL*4      T              ! [1010] Thickness of interface layer
        REAL*4      FAC            !        Scale factor for extrusion
        REAL*4      FAC0           !        Scale factor for start segment
        REAL*4      PHI            ! [   5] end rotation angle for extrusion/rotation
        REAL*4      PHI0           ! [   5] start rotation angle for rotation
        REAL*4      DPHI           ! [   5] allowable sector angle for rotation
        REAL*4      DX             ! [1001] explicit extrusion / rotational axis
        REAL*4      DY             ! [1001] explicit extrusion / rotational axis
        REAL*4      DZ             ! [1001] explicit extrusion / rotational axis
        REAL*4      XREF           ! [1001] explicit reference point
        REAL*4      YREF           ! [1001] explicit reference point
        REAL*4      ZREF           ! [1001] explicit reference point
        REAL*4      TFAC(0:2)      ! [1010] Factor for thickness extrusion START/END/REF
      END TYPE CGVO_SURF
      INTEGER, PARAMETER :: LEN_CGVO_SURF=21
      INTEGER, PARAMETER :: VER_CGVO_SURF=200501

      TYPE CSLVL_DEF               ! 34/NR:0  Structural Storey Level Definition
        SEQUENCE
        INTEGER   ID0              !        identification of definition data (0)
        INTEGER   SPTM             !        ID of SPT to be generated at center of mass
        INTEGER   SPTR             !        ID of SPT to be generated at center of rigidity
        INTEGER   IBIT_STC         !        stiffness calculation bit pattern
        INTEGER   IBIT_CPC         !        capacity calculation bit pattern
        INTEGER   IBC              !        reserved
        REAL*4      ZLEV           ! [1006] Storey level, upwards positive (reference)
        REAL*4      DZUPW          ! [1001] Vertical extension upwards (search box) OK
        REAL*4      DZDWN          ! [1001] Vertical extension downwards (search box) UK
        REAL*4      XMIN           ! [1001] Lateral extension (search box)
        REAL*4      XMAX           ! [1001] Lateral extension (search box)
        REAL*4      YMIN           ! [1001] Lateral extension (search box)
        REAL*4      YMAX           ! [1001] Lateral extension (search box)
        INTEGER   TEXT(17)         !        Designation of level
      END TYPE CSLVL_DEF
      INTEGER, PARAMETER :: LEN_CSLVL_DEF=30
      INTEGER, PARAMETER :: VER_CSLVL_DEF=200501

      TYPE CDSLN_DEF               ! 35/ID:0  Design Element Definition
        SEQUENCE
        INTEGER   ID0              !        identification of definition data (0)
        INTEGER   DSLN             !        number of design element
        INTEGER   FREF             !        reference of forces
        INTEGER   NCS              !        number of cross section
        INTEGER   DSEL             !        type of quad selection
        INTEGER   NIDS             !        count of geometry identifiers
        REAL*4      HDIV           ! [1001] interval of sub-division sections
      END TYPE CDSLN_DEF
      INTEGER, PARAMETER :: LEN_CDSLN_DEF=7
      INTEGER, PARAMETER :: VER_CDSLN_DEF=201804

      TYPE CDGEO_DEF               ! 35/ID:1  Design Element Geometry
        SEQUENCE
        INTEGER   ID               !        identification of data (2)
        INTEGER   TYPE             !        type of geometric definition
        INTEGER   IDS(100)         !        ids of structural lines or beams
        REAL*4      XYZA(3)        ! [1001] geometry of a straight line
        REAL*4      XYZE(3)        ! [1001] geometry of a straight line
        REAL*4      DZ(3)          ! [1001] direction z-axis of straight line
      END TYPE CDGEO_DEF
      INTEGER, PARAMETER :: LEN_CDGEO_DEF=111
      INTEGER, PARAMETER :: VER_CDGEO_DEF=201804

      TYPE CDSLC_DEF               ! 35/ID:2  Design Sections
        SEQUENCE
        INTEGER   ID               !        identification of data (1)
        INTEGER   TYPE             !        type of sectioning
        INTEGER   ITYP             !        type of section
        REAL*4      POS            ! [1001] position of sections
      END TYPE CDSLC_DEF
      INTEGER, PARAMETER :: LEN_CDSLC_DEF=4
      INTEGER, PARAMETER :: VER_CDSLC_DEF=201804

      TYPE CGLAR_0                 ! 38/NR:0  Load distribution areas Header
        SEQUENCE
        INTEGER   ID               !        Identification 0
        INTEGER   NGAR             !        number of an 32/NGAR area definition
        INTEGER   NGRP(0:3)        !        group of area and three active groups
        INTEGER   MGRI             !        prescribed grid subdivision (NGAR=0)
        INTEGER   NGRI             !        prescribed grid subdivision (NGAR=0)
        INTEGER   ID32             !        access ID of 32/0 to check valid data
        INTEGER   ID20             !        access ID of 20/0 to check valid data
        INTEGER   NNOD             !        number of nodes            38/NR:1
        INTEGER   NQUA             !        number of quadrilaterals   38/NR:2
        INTEGER   NSEG             !        number of beam sections    38/NR:3
        INTEGER   DUMMY(2)         !        reserved
        INTEGER   SGRP             !        optional secondary group selector id
        REAL*4      T              ! [1010] thickness of load area used to catch beams
        REAL*4      XYZ(3,4)       ! [1001] ! 4 corner points of area (optional)
      END TYPE CGLAR_0
      INTEGER, PARAMETER :: LEN_CGLAR_0=29
      INTEGER, PARAMETER :: VER_CGLAR_0=200501

      TYPE CGLAR_NOD               ! 38/NR:1  Node of load distribution area
        SEQUENCE
        INTEGER   ID               !        Identification 1 (instead of NR)
        INTEGER   INR              !        nodenumber within the region
        INTEGER   NFIX             !        not used
        INTEGER   NCOD             !        not used
        REAL*4      XYZ(3)         ! [1001] coordinates
        REAL*4      DXYZ(3)        ! [1001] displacements for uniform load -> animator
      END TYPE CGLAR_NOD
      INTEGER, PARAMETER :: LEN_CGLAR_NOD=10
      INTEGER, PARAMETER :: VER_CGLAR_NOD=200803

      TYPE CGLAR_QUA               ! 38/NR:2  QUAD of load distribution area
        SEQUENCE
        INTEGER   ID               !        Identification 2 (instead of NR)
        INTEGER   NODE(4)          !        nodenumbers of the quad within region
        INTEGER   MAT              !        not used
        INTEGER   MRF              !        not used
        INTEGER   NRA              !        type of element
        REAL*4      DET(0:2)       !        Parameter of Jacobi Determinant
        REAL*4      THICK(0:4)     ! [1010] element thickness
        REAL*4      CB             !        not used
        REAL*4      CQ             !        not used
        REAL*4      T(3,3)         !        transformation matrix
      END TYPE CGLAR_QUA
      INTEGER, PARAMETER :: LEN_CGLAR_QUA=27
      INTEGER, PARAMETER :: VER_CGLAR_QUA=200501

      TYPE CGLAR_SEG               ! 38/NR:3  BEAM segments within area
        SEQUENCE
        INTEGER   ID               !        Identification 3
        INTEGER   NR               !        number of loaded beam element
        REAL*4      X              ! [1001] start point
        REAL*4      L              ! [1001] length of segment
      END TYPE CGLAR_SEG
      INTEGER, PARAMETER :: LEN_CGLAR_SEG=4
      INTEGER, PARAMETER :: VER_CGLAR_SEG=200501

      TYPE CGLAR_P                 ! 38/NR:1?  Load distribution areas  Pointloads
        SEQUENCE
        INTEGER   ID               !        Identification 10:13
        INTEGER   INR              !        nodenumber of 038/NR:1 within region
        INTEGER   NODE             !        nodenumber of a global node
        REAL*4      P(0:3)         !        value of load
      END TYPE CGLAR_P
      INTEGER, PARAMETER :: LEN_CGLAR_P=7
      INTEGER, PARAMETER :: VER_CGLAR_P=200501

      TYPE CGLAR_L                 ! 38/NR:10?  Load distribution areas  Beamloads
        SEQUENCE
        INTEGER   ID               !        Identification 100:103
        INTEGER   INR              !        nodenumber of 038/NR:1 within region
        INTEGER   NSEG             !        number of 038/NR:3 segment
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
        REAL*4      MA             !        start value of torque
        REAL*4      ME             !        end value of torque
      END TYPE CGLAR_L
      INTEGER, PARAMETER :: LEN_CGLAR_L=7
      INTEGER, PARAMETER :: VER_CGLAR_L=200501


      INTEGER, PARAMETER :: AXIS_KWH = 3
      INTEGER, PARAMETER :: AREA_KWH = 5
      INTEGER, PARAMETER :: GPT_KWH = 30
      INTEGER, PARAMETER :: GLN_MATC_KWH = 31
      INTEGER, PARAMETER :: GLN_MATC_KWL = 0
      INTEGER, PARAMETER :: GLN_KWH = 31
      INTEGER, PARAMETER :: GAR_MATC_KWH = 32
      INTEGER, PARAMETER :: GAR_MATC_KWL = 0
      INTEGER, PARAMETER :: GAR_KWH = 32
      INTEGER, PARAMETER :: GVO_KWH = 33
      INTEGER, PARAMETER :: SLVL_DEF_KWH = 34
      INTEGER, PARAMETER :: DSLN_DEF_KWH = 35
      INTEGER, PARAMETER :: GLAR_0_KWH = 38
      INTEGER, PARAMETER :: SPT_KWH = 39

      END MODULE CDB_TYPES_GEO

!     end of automatically generated header
!     SOFiSTiK AG
!
