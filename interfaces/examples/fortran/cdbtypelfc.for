!     cdbtypelfc.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_LFC

      INTEGER, PARAMETER, PUBLIC :: MAXLFD=999999 ! MAXIMUM DESIGN LOAD CASES
      INTEGER, PARAMETER, PUBLIC :: MAXLFX=999999 ! HIGHEST LOADCASE NUMBER

      INTEGER, PARAMETER :: LTYP_IMP=70
      TYPE CLC_CTRL                ! 12/LC:?  Informations on loadcase LC
        SEQUENCE
        INTEGER   KIND             !        type of loadcase
        INTEGER   ITYP             !        action type (14/ID)
        INTEGER   THEO             !        first order theory
        INTEGER   IBA(0:1)         !        construction stage number of birth & death
        INTEGER   PLC              !        Primary load case for 2nd order analysis
        REAL*4      RPAR           !        Timevalue of Load [sec]
        REAL*4      PSI0           !        combin. factor psi0
        REAL*4      PSI1           !        combin. factor psi1
        REAL*4      PSI2           !        combin. factor psi2
        REAL*4      FACT           !        loadcase factor
        REAL*4      FACX           !        dead load factor X
        REAL*4      FACY           !        dead load factor Y
        REAL*4      FACZ           !        dead load factor Z
        REAL*4      RX             ! [1151] sum of support PX
        REAL*4      RY             ! [1151] sum of support PY
        REAL*4      RZ             ! [1151] sum of support PZ
        REAL*4      CRI1           !        1st eval. criteria
        REAL*4      CRI2           !        2nd eval. criteria
        REAL*4      CRI3           !        3rd eval. criteria
        REAL*4      GAM1           !        unfavourable factor
        REAL*4      GAM2           !        favourable factor
        INTEGER   NAME(8)          !        Generating source
        INTEGER   RTEX(17)         !        Designation of loadcase
      END TYPE CLC_CTRL
      INTEGER, PARAMETER :: LEN_CLC_CTRL=47
      INTEGER, PARAMETER :: VER_CLC_CTRL=200501

      TYPE CLC_EVAL                ! 12/LC:011  Evaluation request
        SEQUENCE
        INTEGER   ID               !        identifier 11
        INTEGER   LREF             !        Referenced load case or construction stage
        INTEGER   LTYP             !        type of evaluation request
        INTEGER   LEIG             !        load case number of first eigenvalue
        INTEGER   NAME(4)          !        Literal of variable name
        REAL*4      VAL(99)        !        Results of evaluation (array for ietyp 4)
      END TYPE CLC_EVAL
      INTEGER, PARAMETER :: LEN_CLC_EVAL=107
      INTEGER, PARAMETER :: VER_CLC_EVAL=200501

      TYPE CLC_COPY                ! 12/LC:012  Loads from other loadcases
        SEQUENCE
        INTEGER   ID               !        identifier 12 / 13
        INTEGER   LREF             !        Referenced load case or action ID [chr]
        INTEGER   LSEL             !        selection bits for elements
        INTEGER   LITF             !        enum of applied generic factors
        INTEGER   ISEL(4)          !        optional filter for element numbers
        INTEGER   NREF(0:7)        !        Load train application control (see cdblfta.for)
        REAL*4      SREF(0:31)     !        Factors and coordinates
        REAL*4      SUM(7)         !        Sum of forces (psup,lsup)
        INTEGER   CLIT(128)        !        Literal of an external database as source
      END TYPE CLC_COPY
      INTEGER, PARAMETER :: LEN_CLC_COPY=183
      INTEGER, PARAMETER :: VER_CLC_COPY=201211

      TYPE CLC_COPI                ! 12/LC:013  Loads from other loadcases
        SEQUENCE
        INTEGER   ID               !        identifier 12 / 13
        INTEGER   LREF             !        Referenced load case or action ID [chr]
        INTEGER   LSEL             !        selection bits for elements
        INTEGER   LITF             !        enum of applied generic factors
        INTEGER   ISEL(4)          !        optional filter for element numbers
        INTEGER   NREF(0:7)        !        Load train application control (see cdblfta.for)
        REAL*4      SREF(0:31)     !        Factors and coordinates
        REAL*4      SUM(7)         !        Sum of forces (psup,lsup)
        INTEGER   CLIT(128)        !        Literal of an external database as source
      END TYPE CLC_COPI
      INTEGER, PARAMETER :: LEN_CLC_COPI=183
      INTEGER, PARAMETER :: VER_CLC_COPI=201211

      TYPE CLC_MBODY               ! 12/LC:2?  Rotation of Body
        SEQUENCE
        INTEGER   ID               !        identifier 20/21
        INTEGER   NR               !        primary or secondary group number of moving elements
        INTEGER   NREF             !        Reference beam number
        REAL*4      AX             ! [1003] acceleration local X
        REAL*4      AY             ! [1003] acceleration local Y
        REAL*4      AZ             ! [1003] acceleration local Z
        REAL*4      AXX            ! [1207] rotational acceleration local X-X
        REAL*4      AYY            ! [1207] rotational acceleration local Y-Y
        REAL*4      AZZ            ! [1207] rotational acceleration local Z-Z
        REAL*4      ARX            ! [1207] rotational acceleration local X-X  (= vxx**2)
        REAL*4      ARY            ! [1207] rotational acceleration local Y-Y  (= vyy**2)
        REAL*4      ARZ            ! [1207] rotational acceleration local Z-Z  (= vzz**2)
        REAL*4      EX             ! [1001] global reference point for rotational acceleration
        REAL*4      EY             ! [1001] global reference point for rotational acceleration
        REAL*4      EZ             ! [1001] global reference point for rotational acceleration
      END TYPE CLC_MBODY
      INTEGER, PARAMETER :: LEN_CLC_MBODY=15
      INTEGER, PARAMETER :: VER_CLC_MBODY=201312

      TYPE CLC_LRES_LC             !        load case number and factor (dynamic length)
        SEQUENCE
        INTEGER   N
        REAL*4      F
      END TYPE CLC_LRES_LC
      INTEGER, PARAMETER :: LEN_CLC_LRES_LC=2

      TYPE CLC_LRES                ! 12/LC:89  Explicit factors for selected results
        SEQUENCE
        INTEGER   ID               !        identifier 89
        INTEGER   KW               !        KW where result has been stored
        INTEGER   IPOS             !        Position of Result within record
        INTEGER   NREL             !        Element number
        REAL*4      XABS           ! [1011] Section location for beams/structural lines
        TYPE(CLC_LRES_LC) LC(255)  !        load case number and factor (dynamic length)
      END TYPE CLC_LRES
      INTEGER, PARAMETER :: LEN_CLC_LRES=515
      INTEGER, PARAMETER :: VER_CLC_LRES=201607

      TYPE CLC_LPOS                ! 12/LC:90  Position of Load trains
        SEQUENCE
        INTEGER   ID               !        identifier 90
        INTEGER   CASE             !        number of the case
        INTEGER   REF              !        name of the reference lane
        INTEGER   SUB              !        subnumber of lane
        INTEGER   KW               !        KW where result has been stored
        INTEGER   IPOS             !        Position of Result within record
        INTEGER   NREL             !        Elementnumber
        INTEGER   LFTG             !        LFT*1000+500*ISCONVOY+LFG
        REAL*4      XABS           ! [1011] Section location for beams
        REAL*4      YEX            ! [1001] Eccentricity of load train
        REAL*4      PSC(0:1)       !        Maximum load values in load train (PL/BL)
        REAL*4      XPOS(0:63)     !        Position and distance values
      END TYPE CLC_LPOS
      INTEGER, PARAMETER :: LEN_CLC_LPOS=76
      INTEGER, PARAMETER :: VER_CLC_LPOS=200805

      TYPE CLC_LPO1                ! 12/LC:91  Individual position of Point load
        SEQUENCE
        INTEGER   ID               !        identifier 91
        REAL*4      X              ! [1001] Position of individual load
        REAL*4      PVAL(4)        !        Load values in PV,PVM,PX,PY
      END TYPE CLC_LPO1
      INTEGER, PARAMETER :: LEN_CLC_LPO1=6
      INTEGER, PARAMETER :: VER_CLC_LPO1=200601

      TYPE CLC_LPO2                ! 12/LC:92  Individual position of Block load
        SEQUENCE
        INTEGER   ID               !        identifier 92
        REAL*4      XA             ! [1001] Position of individual load start
        REAL*4      XE             ! [1001] Position of individual load end
        REAL*4      PVAL(4)        !        Load values in PV,PVM,PX,PY
      END TYPE CLC_LPO2
      INTEGER, PARAMETER :: LEN_CLC_LPO2=7
      INTEGER, PARAMETER :: VER_CLC_LPO2=200601

      TYPE CLC_LPO3                ! 12/LC:93  Individual residual loadings
        SEQUENCE
        INTEGER   ID               !        identifier 93
        REAL*4      XA             ! [1001] Position of individual load start
        REAL*4      XE             ! [1001] Position of individual load end
        REAL*4      PVAL(8)        !        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
      END TYPE CLC_LPO3
      INTEGER, PARAMETER :: LEN_CLC_LPO3=11
      INTEGER, PARAMETER :: VER_CLC_LPO3=200601

      TYPE CLC_LPOX                ! 12/LC:99  Spandefinitions from ELLA
        SEQUENCE
        INTEGER   ID               !        identifier 99
        REAL*4      XA             ! [1001] Limits of an active area start
        REAL*4      XE             ! [1001] Limits of an active area end
        REAL*4      YL             ! [1001] Limits of an active area left
        REAL*4      YR             ! [1001] Limits of an active area right
        REAL*4      PHI            !        impact factor
        REAL*4      V              ! [1203] velocity of load train
      END TYPE CLC_LPOX
      INTEGER, PARAMETER :: LEN_CLC_LPOX=7
      INTEGER, PARAMETER :: VER_CLC_LPOX=200911

      TYPE CLC_POIN_LPT            !        loadpt
        SEQUENCE
        REAL*4      P
        REAL*4      X              ! [1001] 
        REAL*4      Y              ! [1001] 
        REAL*4      Z              ! [1001] 
      END TYPE CLC_POIN_LPT
      INTEGER, PARAMETER :: LEN_CLC_POIN_LPT=4

      TYPE CLC_POIN                ! 12/LC:10?  Free point loads
        SEQUENCE
        INTEGER   KREF             !        Reference type
        INTEGER   NREF             !        Reference number
        INTEGER   TREF(3)          !        Reference text    (12 characters)
        INTEGER   TYP              !        type of load
        INTEGER   TXT(3)           !        Identifiying Text (12 characters)
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      WIDTH          ! [1001] Tolerance load direction to match elements
        TYPE(CLC_POIN_LPT) LPT     !        loadpt
      END TYPE CLC_POIN
      INTEGER, PARAMETER :: LEN_CLC_POIN=15
      INTEGER, PARAMETER :: VER_CLC_POIN=200707

      TYPE CLC_LINE_LPT            !        loadpts
        SEQUENCE
        REAL*4      P
        REAL*4      X              ! [1001] 
        REAL*4      Y              ! [1001] 
        REAL*4      Z              ! [1001] 
      END TYPE CLC_LINE_LPT
      INTEGER, PARAMETER :: LEN_CLC_LINE_LPT=4

      TYPE CLC_LINE                ! 12/LC:11?  Free line loads
        SEQUENCE
        INTEGER   KREF             !        Reference type
        INTEGER   NREF             !        Reference number
        INTEGER   TREF(3)          !        Reference text    (12 characters)
        INTEGER   TYP              !        type of load
        INTEGER   TXT(3)           !        Identifiying Text (12 characters)
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      WIDTH          ! [1001] Tolerance load direction to match elements
        TYPE(CLC_LINE_LPT) LPT(63) !        loadpts
      END TYPE CLC_LINE
      INTEGER, PARAMETER :: LEN_CLC_LINE=263
      INTEGER, PARAMETER :: VER_CLC_LINE=200502

      TYPE CLC_CURV_LPT            !        loadpts
        SEQUENCE
        REAL*4      P
        REAL*4      X              ! [1001] 
        REAL*4      Y              ! [1001] 
        REAL*4      Z              ! [1001] 
      END TYPE CLC_CURV_LPT
      INTEGER, PARAMETER :: LEN_CLC_CURV_LPT=4

      TYPE CLC_CURV                ! 12/LC:14?  Free spline loads
        SEQUENCE
        INTEGER   KREF             !        Reference type
        INTEGER   NREF             !        Reference number
        INTEGER   TREF(3)          !        Reference text    (12 characters)
        INTEGER   TYP              !        type of load
        INTEGER   TXT(3)           !        Identifiying Text (12 characters)
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      WIDTH          ! [1001] Tolerance load direction to match elements
        TYPE(CLC_CURV_LPT) LPT(63) !        loadpts
      END TYPE CLC_CURV
      INTEGER, PARAMETER :: LEN_CLC_CURV=263
      INTEGER, PARAMETER :: VER_CLC_CURV=200502

      TYPE CLC_AREA_LPT            !        loadpts
        SEQUENCE
        REAL*4      P
        REAL*4      X              ! [1001] 
        REAL*4      Y              ! [1001] 
        REAL*4      Z              ! [1001] 
      END TYPE CLC_AREA_LPT
      INTEGER, PARAMETER :: LEN_CLC_AREA_LPT=4

      TYPE CLC_AREA                ! 12/LC:12?  Free area loads
        SEQUENCE
        INTEGER   KREF             !        Reference type
        INTEGER   NREF             !        Reference number
        INTEGER   TREF(3)          !        Reference text    (12 characters)
        INTEGER   TYP              !        type of load
        INTEGER   TXT(3)           !        Identifiying Text (12 characters)
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      WIDTH          ! [1001] Tolerance load direction to match elements
        TYPE(CLC_AREA_LPT) LPT(63) !        loadpts
      END TYPE CLC_AREA
      INTEGER, PARAMETER :: LEN_CLC_AREA=263
      INTEGER, PARAMETER :: VER_CLC_AREA=200501

      TYPE CLC_VOLU                ! 12/LC:13?  Free volume loads
        SEQUENCE
        INTEGER   KREF             !        Reference type
        INTEGER   NREF             !        Reference number
        INTEGER   TREF(3)          !        Reference text    (12 characters)
        INTEGER   TYP              !        type of load
        INTEGER   TXT(3)           !        Identifiying Text (12 characters)
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      WIDTH          ! [1001] Factor for silo fillings A/U
        REAL*4      P0             !        load value
        REAL*4      X              ! [1001] Reference point for load value P0
        REAL*4      Y              ! [1001] 
        REAL*4      Z              ! [1001] 
        REAL*4      P1             !        variant load value second reference point
        REAL*4      DX1            ! [1001] Reference point for load value P1
        REAL*4      DY1            ! [1001] 
        REAL*4      DZ1            ! [1001] 
        REAL*4      P2             !        variant load value second reference point
        REAL*4      DX2            ! [1001] Reference point for load value P2
        REAL*4      DY2            ! [1001] 
        REAL*4      DZ2            ! [1001] 
        REAL*4      P3             !        variant load value second reference point
        REAL*4      DX3            ! [1001] Reference point for load value P3
        REAL*4      DY3            ! [1001] 
        REAL*4      DZ3            ! [1001] 
        REAL*4      P4             !        variant load value second reference point
        REAL*4      DX4            ! [1001] Reference point for load value P2
        REAL*4      DY4            ! [1001] 
        REAL*4      DZ4            ! [1001] 
        REAL*4      P5             !        variant load value second reference point
        REAL*4      DX5            ! [1001] Reference point for load value P3
        REAL*4      DY5            ! [1001] 
        REAL*4      DZ5            ! [1001] 
      END TYPE CLC_VOLU
      INTEGER, PARAMETER :: LEN_CLC_VOLU=35
      INTEGER, PARAMETER :: VER_CLC_VOLU=200502

      TYPE CGLC_GUID               ! 12/LC:199  Unique identifier of loading member
        SEQUENCE
        INTEGER   ID               !        identifier 199
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of following element
      END TYPE CGLC_GUID
      INTEGER, PARAMETER :: LEN_CGLC_GUID=37
      INTEGER, PARAMETER :: VER_CGLC_GUID=0

      TYPE CLC_TRAI                ! 12/LC:300  Train loading
        SEQUENCE
        INTEGER   ID               !        identifier 300
        INTEGER   IDEN             !        Type of load train
        INTEGER   BPAT             !        Preselected Bitpattern of special options
        REAL*4      P1             !        Char Designation or Class of loading
        REAL*4      P2             !        second entry for load magnitude
        REAL*4      P3             !        third entry for load magnitude
        REAL*4      P4             !        fourth entry for load magnitude
        REAL*4      P5             !        Basic area loading
        REAL*4      P6             !        Wind loading
        REAL*4      P7             !        Height subjected to wind load
        REAL*4      P8             !        Entry for brake loading
        REAL*4      P9             !        Height of the gravity centreline
        REAL*4      TOTFAC         !        Factor for the vertical loads of the
        REAL*4      PHIB           !        explicit impact factor for bending
        REAL*4      PHIBF          !        explicit impact factor favourable bending
        REAL*4      PHIS           !        explicit impact factor for shear
        REAL*4      PHISF          !        explicit impact factor favourable shear
        REAL*4      WIDTH          ! [1001] Width of moving lane to be spared with P5
        REAL*4      YEX            ! [1001] reserved: Eccentricity of loading in lane
        REAL*4      XCOL           ! [1001] Minimum distance for multiple instances
        REAL*4      V              ! [1203] Speed of train
        REAL*4      FACF           !        Factor for the masses of the loading
        REAL*4      FAVF           !        factor for favorable loading
        REAL*4      FRB            !        Frequence of body to bogie spring
        REAL*4      DAB            !        Modal damping of body to bogie
        REAL*4      PZBO           ! [1001] Fractional load value of bogie (included in PZ)
        REAL*4      FRBO           !        Frequence of bogie to wheel spring
        REAL*4      DABO           !        Modal damping of bogie to body
        REAL*4      PZWH           ! [1001] Fractional load value of wheel (included in PZ)
        REAL*4      FRWH           !        Frequence of wheel to surface / bridge deck
        REAL*4      DAWH           !        Modal damping of wheel to surface
      END TYPE CLC_TRAI
      INTEGER, PARAMETER :: LEN_CLC_TRAI=31
      INTEGER, PARAMETER :: VER_CLC_TRAI=201807

      TYPE CLC_TRAL                ! 12/LC:301  Individual loads of Train loading
        SEQUENCE
        INTEGER   ID               !        identifier 301
        INTEGER   TYPE             !        Type of loading
        INTEGER   BPAT             !        contact node for single loads
        REAL*4      PZ             !        Vertical loading
        REAL*4      YMIN           ! [1001] min eccentricity in y direction
        REAL*4      YMAX           ! [1001] max eccentricity in y direction
        REAL*4      PX             !        Load value for braking
        REAL*4      PW             !        Explicit force for wind attack
        REAL*4      ZW             ! [1001] Height for wind force resultant
        REAL*4      PV             !        Massvalue for zentrifugal force
        REAL*4      ZPV            ! [1001] Height for zentrifugal force resultant
        REAL*4      FACFAV         !        Factor for favourable effects
        REAL*4      A              ! [1001] Distance to last load
        REAL*4      L              ! [1001] Length of loading for block loads (0 = unlimited)
        REAL*4      LMAX           ! [1001] Maximum length of block loading if variable
        REAL*4      LDEL           ! [1001] Discrete increment of length for block loading
        REAL*4      HW             ! [1001] Height of train for wind attack area
        REAL*4      WIDTH          ! [1001] Width of train
        REAL*4      YEXVAR         !        Variable eccentricity for secondary load trains
        REAL*4      WWHEEL         ! [1001] Width of single wheel
        REAL*4      LWHEEL         ! [1001] Length of single wheel
        REAL*4      DUMMY(2)       !        reserved
        REAL*4      FRB            !        Frequence of body to bogie spring
        REAL*4      DAB            !        Modal damping of body to bogie
        REAL*4      PZBO           ! [1001] Fractional load value of bogie (included in PZ)
        REAL*4      FRBO           !        Frequence of bogie to wheel spring
        REAL*4      DABO           !        Modal damping of bogie to body
        REAL*4      PZWH           ! [1001] Fractional load value of wheel (included in PZ)
        REAL*4      FRWH           !        Frequence of wheel to surface / bridge deck
        REAL*4      DAWH           !        Modal damping of wheel to surface
      END TYPE CLC_TRAL
      INTEGER, PARAMETER :: LEN_CLC_TRAL=31
      INTEGER, PARAMETER :: VER_CLC_TRAL=200911

      TYPE CLC_WIND                ! 12/LC:400  wind loading
        SEQUENCE
        INTEGER   ID               !        identifier 400
        INTEGER   NORM             !        wind design code
        INTEGER   CLAS             !        type of zone and terrain
        REAL*4      VATM           ! [1201] atmospheric wind
        REAL*4      VREF           ! [1201] mean reference wind
        REAL*4      VBOE           ! [1201] gust reference wind
        REAL*4      DX             !        components of wind direction
        REAL*4      DY
        REAL*4      DZ
        REAL*4      XREF           ! [1001] Reference point
        REAL*4      YREF           ! [1001] 
        REAL*4      ZREF           ! [1001] 
        REAL*4      DXRE           !        Reference direction
        REAL*4      DYRE
        REAL*4      DZRE
        REAL*4      GH             ! [1001] coordinate of ground level
        REAL*4      HMIN           ! [1001] value for constant wind speed below (zmin)
        REAL*4      RHO            ! [  59] weight of the air / fluid
        REAL*4      LAT            ! [   5] explicit lattitude of site
        REAL*4      Z0             ! [1001] explicit roughness
      END TYPE CLC_WIND
      INTEGER, PARAMETER :: LEN_CLC_WIND=20
      INTEGER, PARAMETER :: VER_CLC_WIND=200501

      TYPE CLC_WTOP                ! 12/LC:401  Wind environment
        SEQUENCE
        INTEGER   ID               !        identifier 401
        REAL*4      TYP            !        type of environment height
        REAL*4      I_2            !        reserved
        REAL*4      XM             ! [1001] center of elevation in system coordinates
        REAL*4      YM             ! [1001] center of elevation in system coordinates
        REAL*4      ZM             ! [1001] center of elevation in system coordinates
        REAL*4      DX             !        direction of crest of ridge
        REAL*4      DY             !        or local x-coordinate of a summit
        REAL*4      DZ
        REAL*4      H              ! [1001] height above ground defining the slopes
        REAL*4      WLEN           ! [1001] width in negative local y direction
        REAL*4      BLEN           ! [1001] width in positive local x direction
      END TYPE CLC_WTOP
      INTEGER, PARAMETER :: LEN_CLC_WTOP=12
      INTEGER, PARAMETER :: VER_CLC_WTOP=200501

      TYPE CLC_WROU_R              !        limits given
        SEQUENCE
        REAL*4      D              ! [1001] 
        REAL*4      R              ! [1001] 
        REAL*4      DH             ! [1001] 
        REAL*4      HH             ! [1001] 
      END TYPE CLC_WROU_R
      INTEGER, PARAMETER :: LEN_CLC_WROU_R=4

      TYPE CLC_WROU                ! 12/LC:402  Roughness (wind)
        SEQUENCE
        INTEGER   ID               !        identifier 402
        REAL*4      I_1            !        reserved
        REAL*4      I_2            !        reserved
        REAL*4      DSEA           ! [1001] Distance to the sea
        TYPE(CLC_WROU_R) R(9)      !        limits given
      END TYPE CLC_WROU
      INTEGER, PARAMETER :: LEN_CLC_WROU=40
      INTEGER, PARAMETER :: VER_CLC_WROU=200501

      TYPE CLC_WSPE                ! 12/LC:410  wind spectrum
        SEQUENCE
        INTEGER   ID               !        identifier 410
        INTEGER   TYP              !        type of spectra
        INTEGER   CTYP             !        type of coherence model
        REAL*4      A1LO           !        1st coefficient longitudinal
        REAL*4      A2LO           !        2nd coefficient longitudinal
        REAL*4      A3LO           !        3rd coefficient longitudinal
        REAL*4      B_LO           !        4th coefficient longitudinal
        REAL*4      C_LO           !        5th coefficient longitudinal
        REAL*4      D_LO           !        6th coefficient longitudinal
        REAL*4      A1LA           !        1st coefficient lateral
        REAL*4      A2LA           !        2nd coefficient lateral
        REAL*4      A3LA           !        3rd coefficient lateral
        REAL*4      B_LA           !        4th coefficient lateral
        REAL*4      C_LA           !        5th coefficient lateral
        REAL*4      D_LA           !        6th coefficient lateral
        REAL*4      A1VE           !        1st coefficient vertical
        REAL*4      A2VE           !        2nd coefficient vertical
        REAL*4      A3VE           !        3rd coefficient vertical
        REAL*4      B_VE           !        4th coefficient vertical
        REAL*4      C_VE           !        5th coefficient vertical
        REAL*4      D_VE           !        6th coefficient vertical
        REAL*4      C3D            !        Longitudinal coefficient
        REAL*4      KUU            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KUV            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KUW            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KVU            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KVV            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KVW            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KWU            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KWV            !        HWD factor for ESDU, coefficient otherwise
        REAL*4      KWW            !        HWD factor for ESDU, coefficient otherwise
      END TYPE CLC_WSPE
      INTEGER, PARAMETER :: LEN_CLC_WSPE=31
      INTEGER, PARAMETER :: VER_CLC_WSPE=200501

      TYPE CLC_WTST                ! 12/LC:411  wind coherence test requests
        SEQUENCE
        INTEGER   ID               !        identifier 411
        INTEGER   TYP              !        type of coherence component
        INTEGER   LC               !        load case of an eigenvalue
        REAL*4      XREF           ! [1001] Reference point
        REAL*4      YREF           ! [1001] 
        REAL*4      ZREF           ! [1001] 
        REAL*4      RX             ! [1001] Distance or direction of distance
        REAL*4      RY             ! [1001] 
        REAL*4      RZ             ! [1001] 
        REAL*4      CX             !        Davenport/Krenk reference coefficients
        REAL*4      CY
        REAL*4      CZ
        REAL*4      EIG            !        Eigenfrequency (Hertz) for LC>0
        REAL*4      U              ! [  96] mean velocity
        REAL*4      HWD            ! [1001] real distance for LC==0
        REAL*4      XMAX           !        maximum x-value for data
        REAL*4      DATA(64)       !        calculated sqrt of coherence data ( 2 sets)
      END TYPE CLC_WTST
      INTEGER, PARAMETER :: LEN_CLC_WTST=80
      INTEGER, PARAMETER :: VER_CLC_WTST=201406

      TYPE CLC_WPRC                ! 12/LC:420  wind profile control values
        SEQUENCE
        INTEGER   ID               !        identifier 420
        INTEGER   ID2              !        identifier 0
        REAL*4      IPRO           !        number of generated profiles
        REAL*4      WXMI           ! [1001] size of structure in wind coordinates
        REAL*4      WXMA           ! [1001] 
        REAL*4      WYMI           ! [1001] 
        REAL*4      WYMA           ! [1001] 
        REAL*4      WZMI           ! [1001] 
        REAL*4      WZMA           ! [1001] 
        REAL*4      ALFA           !        some angle ...
        REAL*4      BETA           !        some angle ...
        REAL*4      GAMM           !        some angle ...
        REAL*4      DELT           !        some angle ...
      END TYPE CLC_WPRC
      INTEGER, PARAMETER :: LEN_CLC_WPRC=13
      INTEGER, PARAMETER :: VER_CLC_WPRC=200501

      TYPE CLC_WPRO                ! 12/LC:420  wind profile distinct values
        SEQUENCE
        INTEGER   ID               !        identifier 420
        INTEGER   IST              !        source of data
        REAL*4      I_2            !        index reserved
        REAL*4      H              ! [1001] height above ground level
        REAL*4      V              ! [1201] mean value of wind velocity
        REAL*4      VBOE           ! [1201] peak value of wind velocity
        REAL*4      TLON           ! [1201] longitudinal turbulence
        REAL*4      TLAT           ! [1201] lateral turbulence
        REAL*4      TVER           ! [1201] vertical turbulence
        REAL*4      LLON           ! [1001] longitudinal wave length
        REAL*4      LLAT           ! [1001] lateral wave length
        REAL*4      LVER           ! [1001] vertical wave length
        REAL*4      PHAS           !        phase
      END TYPE CLC_WPRO
      INTEGER, PARAMETER :: LEN_CLC_WPRO=13
      INTEGER, PARAMETER :: VER_CLC_WPRO=200501

      TYPE CLC_WAVE                ! 12/LC:500  Wave Loading
        SEQUENCE
        INTEGER   ID               !        identifier 500
        INTEGER   TYP              !        wave theory bit pattern
        INTEGER   NF               !        number of frequencies in spectra
        REAL*4      H              ! [1001] wave height / significant wave height
        REAL*4      T              ! [  90] period of wave / peak period of wave
        REAL*4      D              ! [1001] water depth (0 = infinite)
        REAL*4      SWL            ! [1001] sea water reference level
        REAL*4      DIR(3)         !        principal direction of travelling
        REAL*4      UC             ! [1201] additional constant current
        REAL*4      ALF            !        exponent U(z)=UC*(z/d)**alf
        REAL*4      RHO            ! [  59] weight of the fluid
        REAL*4      L              ! [1001] calculated wave length
        REAL*4      PAR(0:14)      !        special parameters for wave spectra
      END TYPE CLC_WAVE
      INTEGER, PARAMETER :: LEN_CLC_WAVE=29
      INTEGER, PARAMETER :: VER_CLC_WAVE=201301

      TYPE CLC_HIST                ! 13/LC:0  TimeHistoryTitle
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   IDT              !        Unit of time resp x-axis
        INTEGER   IDF              !        Unit of function values
        INTEGER   NFUN             !        number of functions
        INTEGER   NVAL             !        max number of discrete time values
        INTEGER   TYPE             !        general type of curve
        INTEGER   TITLE(17)        !        Designation
      END TYPE CLC_HIST
      INTEGER, PARAMETER :: LEN_CLC_HIST=23
      INTEGER, PARAMETER :: VER_CLC_HIST=201104

      TYPE CLC_DAMP                ! 13/LC:1  Damping values
        SEQUENCE
        INTEGER   ID               !        identifier 1
        REAL*4      D(7)           !        modal damping values
      END TYPE CLC_DAMP
      INTEGER, PARAMETER :: LEN_CLC_DAMP=8
      INTEGER, PARAMETER :: VER_CLC_DAMP=200501

      TYPE CLC_FVAL                ! 13/LC:?0  Discrete function values
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      TT             !        Time/frequency/modenumber
        REAL*4      F(7)           !        function values
      END TYPE CLC_FVAL
      INTEGER, PARAMETER :: LEN_CLC_FVAL=9
      INTEGER, PARAMETER :: VER_CLC_FVAL=200501

      TYPE CLC_FMODC               ! 13/LC:9?  Explicit modal coordinates
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      TT             !        Time/frequency/modenumber
        REAL*4      F(7)           !        function values
      END TYPE CLC_FMODC
      INTEGER, PARAMETER :: LEN_CLC_FMODC=9
      INTEGER, PARAMETER :: VER_CLC_FMODC=201602

      TYPE CLC_FSIN                ! 13/LC:11  Harmonic function additive
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      T              ! [  90] Time/frequency
        REAL*4      F1             !        Amplitude value
        REAL*4      PHI1           ! [  90] phase value
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime if > starttime
        REAL*4      S              !        impactfactor
        REAL*4      F2             !        Amplitude value for T/2 (Fourier)
        REAL*4      PHI2           ! [  90] phase value for f2
        REAL*4      F3             !        Amplitude value for T/3 (Fourier)
        REAL*4      PHI3           ! [  90] phase value for f3
        REAL*4      F4             !        Amplitude value for T/4 (Fourier)
        REAL*4      PHI4           ! [  90] phase value for f4
      END TYPE CLC_FSIN
      INTEGER, PARAMETER :: LEN_CLC_FSIN=13
      INTEGER, PARAMETER :: VER_CLC_FSIN=200501

      TYPE CLC_FSINM               ! 13/LC:21  Harmonic function multiplier
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      T              ! [  90] Time/frequency
        REAL*4      F1             !        Amplitude value
        REAL*4      PHI1           ! [  90] phase value
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime if > starttime
        REAL*4      S              !        impactfactor
        REAL*4      F2             !        Amplitude value for T/2 (Fourier)
        REAL*4      PHI2           ! [  90] phase value for f2
        REAL*4      F3             !        Amplitude value for T/3 (Fourier)
        REAL*4      PHI3           ! [  90] phase value for f3
        REAL*4      F4             !        Amplitude value for T/4 (Fourier)
        REAL*4      PHI4           ! [  90] phase value for f4
      END TYPE CLC_FSINM
      INTEGER, PARAMETER :: LEN_CLC_FSINM=13
      INTEGER, PARAMETER :: VER_CLC_FSINM=200501

      TYPE CLC_FSTP                ! 13/LC:12  Periodic stepping function additive
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      T              ! [  90] Time/frequency
        REAL*4      F              !        Amplitude value
        REAL*4      TC             ! [  90] contact time
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime if > starttime
        REAL*4      S              !        impactfactor (Sailer/Hüttner/Bachmann)
      END TYPE CLC_FSTP
      INTEGER, PARAMETER :: LEN_CLC_FSTP=7
      INTEGER, PARAMETER :: VER_CLC_FSTP=200501

      TYPE CLC_FSTPM               ! 13/LC:22  Periodic stepping function multiplier
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      T              ! [  90] Time/frequency
        REAL*4      F              !        Amplitude value
        REAL*4      TC             ! [  90] contact time
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime if > starttime
        REAL*4      S              !        impactfactor (Sailer/Hüttner/Bachmann)
      END TYPE CLC_FSTPM
      INTEGER, PARAMETER :: LEN_CLC_FSTPM=7
      INTEGER, PARAMETER :: VER_CLC_FSTPM=200501

      TYPE CLC_FINA                ! 13/LC:13  Aperiodic function additive
        SEQUENCE
        INTEGER   ID               !        identifier 13
        REAL*4      T              ! [  90] Total Time
        REAL*4      F              !        Amplitude value
        REAL*4      T1             ! [  90] Time of constant intensity
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime = tmin+T
        INTEGER   TYP              !        Type of function
        REAL*4      F2             !        Amplitude factor
        REAL*4      T2             ! [  90] lead in time duration
        REAL*4      F3             !        Amplitude factor
        REAL*4      T3             ! [  90] lead out time duration
      END TYPE CLC_FINA
      INTEGER, PARAMETER :: LEN_CLC_FINA=11
      INTEGER, PARAMETER :: VER_CLC_FINA=201104

      TYPE CLC_FINM                ! 13/LC:23  Aperiodic function multiplier
        SEQUENCE
        INTEGER   ID               !        identifier 13
        REAL*4      T              ! [  90] Total Time
        REAL*4      F              !        Amplitude value
        REAL*4      T1             ! [  90] Time of constant intensity
        REAL*4      TMIN           ! [  90] starttime
        REAL*4      TMAX           ! [  90] stoptime = tmin+T
        INTEGER   TYP              !        Type of function
        REAL*4      F2             !        Amplitude factor
        REAL*4      T2             ! [  90] lead in time duration
        REAL*4      F3             !        Amplitude factor
        REAL*4      T3             ! [  90] lead out time duration
      END TYPE CLC_FINM
      INTEGER, PARAMETER :: LEN_CLC_FINM=11
      INTEGER, PARAMETER :: VER_CLC_FINM=201104

      TYPE CLC_RESW                ! 13/LC:9??  Response spectra wind
        SEQUENCE
        INTEGER   TYP              !        Type of spectra 900 - 999
        REAL*4      SINT           !        Integral of spectra
        REAL*4      A1             !        Spectrum coefficient
        REAL*4      A2             !        Spectrum coefficient
        REAL*4      A3             !        Spectrum coefficient
        REAL*4      B              !        Spectrum coefficient
        REAL*4      C              !        Spectrum coefficient
        REAL*4      D              !        Spectrum coefficient
        REAL*4      RES(9)         !        reserved
        INTEGER   TITLE(17)        !        Designation of Spectra
      END TYPE CLC_RESW
      INTEGER, PARAMETER :: LEN_CLC_RESW=34
      INTEGER, PARAMETER :: VER_CLC_RESW=201502

      TYPE CLC_RESP                ! 13/LC:???  Response seismic spectra
        SEQUENCE
        INTEGER   TYP              !        Type of spectra 100 - 999
        REAL*4      D              !        Damping value eta or behaviour factor q
        REAL*4      SA             !        Rigid acceleration factor (Soil Parameter S)
        REAL*4      SB             !        Max acceleration factor
        REAL*4      SMIN           !        Min acceleration factor (beta)
        REAL*4      TB             ! [  90] Time value
        REAL*4      TC             ! [  90] Time value
        REAL*4      TD             ! [  90] Time value
        REAL*4      TE             ! [  90] Cutt-Off Time
        REAL*4      K1             !        Coefficient k1
        REAL*4      K2             !        Coefficient k2
        INTEGER   ZONE(3)          !        Seismic zone
        REAL*4      AG             ! [1202] Reference base acceleration
        REAL*4      AH             !        Horizontal factor (importance etc.)
        REAL*4      AV             !        Vertical factor
        INTEGER   TITLE(17)        !        Designation of Spectra
      END TYPE CLC_RESP
      INTEGER, PARAMETER :: LEN_CLC_RESP=34
      INTEGER, PARAMETER :: VER_CLC_RESP=200501

      TYPE CLC_FREF                ! 13/LC:????  Discrete reference function values
        SEQUENCE
        INTEGER   ID               !        line type
        REAL*4      TT             !        Time/frequency
        REAL*4      F(2)           !        function values
      END TYPE CLC_FREF
      INTEGER, PARAMETER :: LEN_CLC_FREF=4
      INTEGER, PARAMETER :: VER_CLC_FREF=201104

      TYPE CACT_TASK_SCOM          !        index,factor and name of items
        SEQUENCE
        INTEGER   IND
        REAL*4      FAK
        INTEGER   BEZ
      END TYPE CACT_TASK_SCOM
      INTEGER, PARAMETER :: LEN_CACT_TASK_SCOM=3

      TYPE CACT_TASK               ! 14/0  Superposition task commands
        SEQUENCE
        INTEGER   IVERS            !        < 9999 = old data format (ACT_RULE)
        INTEGER   NUM              !        number of superposition command
        INTEGER   ACT              !        number of groups of actions at 14/act
        INTEGER   LFM(2)           !        base of load case numbers
        INTEGER   KSAV             !        0 = do not save, >0 = save factors as combination KSAV
        INTEGER   KWERG            !        Identifier of resultrecord in CDB
        INTEGER   FROM             !        smallest  element number
        INTEGER   TO               !        highest   element number
        INTEGER   INC              !        increment element number
        INTEGER   TID              !        optional identifier
        REAL*4      X              ! [1001] X-ordinate for beams (see INC!)
        INTEGER   COMB             !        combination method for items given at SCOM
        TYPE(CACT_TASK_SCOM) SCOM(9)!        index,factor and name of items
        INTEGER   TXT(33)          !        Name of superposition
        INTEGER   UFORM(128)       !        User defined target function (index == 0!)
      END TYPE CACT_TASK
      INTEGER, PARAMETER :: LEN_CACT_TASK=201
      INTEGER, PARAMETER :: VER_CACT_TASK=200806

      TYPE CACT_RULE_SCOM          !        index,factor and name of items
        SEQUENCE
        INTEGER   IND
        REAL*4      FAK
        INTEGER   BEZ
      END TYPE CACT_RULE_SCOM
      INTEGER, PARAMETER :: LEN_CACT_RULE_SCOM=3

      TYPE CACT_RULE               ! 14/0  Superposition commands (old Version)
        SEQUENCE
        INTEGER   NUM              !        number of superposition command
        INTEGER   ACT              !        number of groups of actions at 14/act
        INTEGER   LFM(2)           !        base of load case numbers
        INTEGER   KWERG            !        Identifier of resultrecord in CDB
        INTEGER   FROM             !        smallest  element number (echo only)
        INTEGER   TO               !        highest   element number (echo only)
        INTEGER   INC              !        increment element number (echo only)
        INTEGER   TID              !        optional identifier
        INTEGER   COMB             !        combination method for items given at SCOM
        TYPE(CACT_RULE_SCOM) SCOM(9)!        index,factor and name of items
        INTEGER   TXT(33)          !        Name of superposition
      END TYPE CACT_RULE
      INTEGER, PARAMETER :: LEN_CACT_RULE=70
      INTEGER, PARAMETER :: VER_CACT_RULE=200501

      TYPE CLC_ACT0                ! 14/NR:0  Group of Actions for SUPP-task
        SEQUENCE
        INTEGER   ID               !        ident = 0  user defined ; < 0 automatic
        INTEGER   LFB              !        load case offset
        INTEGER   EXTR             !        type of formula for evaluating the extrema
        INTEGER   TYPE             !        type or action of resulting load case
        INTEGER   TXT(17)          !        Group designation for collection of actions
      END TYPE CLC_ACT0
      INTEGER, PARAMETER :: LEN_CLC_ACT0=21
      INTEGER, PARAMETER :: VER_CLC_ACT0=200501

      TYPE CLC_CACT0               ! 12/LC:80  Group of Actions for SUPP-task
        SEQUENCE
        INTEGER   ID               !        ident = 0  user defined ; < 0 automatic
        INTEGER   LFB              !        load case offset
        INTEGER   EXTR             !        type of formula for evaluating the extrema
        INTEGER   TYPE             !        type or action of resulting load case
        INTEGER   TXT(17)          !        Group designation for collection of actions
      END TYPE CLC_CACT0
      INTEGER, PARAMETER :: LEN_CLC_CACT0=21
      INTEGER, PARAMETER :: VER_CLC_CACT0=0

      TYPE CLC_ACT1                ! 14/NR:1  Action member
        SEQUENCE
        INTEGER   ID               !        ident = 1 / 81
        INTEGER   ACTION           !        ID of the action = type of action
        INTEGER   TYPE             !        256*subgroup + 16*Group_of_action + superposition
        REAL*4      GAMU           !        safety factor unfavourable
        REAL*4      GAMF           !        safety factor favourable
        REAL*4      PSI0           !        combination value
        REAL*4      PSI1           !        combination value
        REAL*4      PSI2           !        quasi permanent combination value
        REAL*4      PS1S           !        non frequent combination value psi1'
        REAL*4      GAMA           !        safety factor accidential
        INTEGER   CAT              !        category (see 14/ID) not used here
        INTEGER   TXT(17)          !        designation
      END TYPE CLC_ACT1
      INTEGER, PARAMETER :: LEN_CLC_ACT1=28
      INTEGER, PARAMETER :: VER_CLC_ACT1=200501

      TYPE CLC_CACT1               ! 12/NR:81  current action member
        SEQUENCE
        INTEGER   ID               !        ident = 1 / 81
        INTEGER   ACTION           !        ID of the action = type of action
        INTEGER   TYPE             !        256*subgroup + 16*Group_of_action + superposition
        REAL*4      GAMU           !        safety factor unfavourable
        REAL*4      GAMF           !        safety factor favourable
        REAL*4      PSI0           !        combination value
        REAL*4      PSI1           !        combination value
        REAL*4      PSI2           !        quasi permanent combination value
        REAL*4      PS1S           !        non frequent combination value psi1'
        REAL*4      GAMA           !        safety factor accidential
        INTEGER   CAT              !        category (see 14/ID) not used here
        INTEGER   TXT(17)          !        designation
      END TYPE CLC_CACT1
      INTEGER, PARAMETER :: LEN_CLC_CACT1=28
      INTEGER, PARAMETER :: VER_CLC_CACT1=201607

      TYPE CLC_ACT_L               ! 14/NR:2  loadcase of action
        SEQUENCE
        INTEGER   ID               !        ident = 2 / 82
        INTEGER   LF               !        load case number
        INTEGER   TYPE             !        load case action type
        REAL*4      FACT           !        factor
      END TYPE CLC_ACT_L
      INTEGER, PARAMETER :: LEN_CLC_ACT_L=4
      INTEGER, PARAMETER :: VER_CLC_ACT_L=200501

      TYPE CLC_CACT2               ! 12/NR:82  current loadcase of action
        SEQUENCE
        INTEGER   ID               !        ident = 2 / 82
        INTEGER   LF               !        load case number
        INTEGER   TYPE             !        load case action type
        REAL*4      FACT           !        factor
      END TYPE CLC_CACT2
      INTEGER, PARAMETER :: LEN_CLC_CACT2=4
      INTEGER, PARAMETER :: VER_CLC_CACT2=201607

      TYPE CLC_ACT_R               ! 14/NR:1?  Response Spectra
        SEQUENCE
        INTEGER   ID               !        Evaluation type of response
        INTEGER   RESP             !        load case number of spectra
        INTEGER   LFEIG            !        load case of first eigenform
        INTEGER   NEIG             !        numbers of eigenforms to be used
      END TYPE CLC_ACT_R
      INTEGER, PARAMETER :: LEN_CLC_ACT_R=4
      INTEGER, PARAMETER :: VER_CLC_ACT_R=200501

      TYPE CLC_ACT                 ! 14/ID:1  Action defaults
        SEQUENCE
        INTEGER   ID               !        ident = 1
        INTEGER   ACTION           !        ID of the real action = type of action
        INTEGER   TYPE             !        256*subgroup + 16*Group_of_action + superposition
        REAL*4      GAMU           !        safety factor unfavourable
        REAL*4      GAMF           !        safety factor favourable
        REAL*4      PSI0           !        combination value
        REAL*4      PSI1           !        combination value
        REAL*4      PSI2           !        quasi permanent combination value
        REAL*4      PS1S           !        non frequent combination value psi1'
        REAL*4      GAMA           !        safety factor accidential
        INTEGER   CAT              !        category for preselection of psi-values
        INTEGER   TXT(17)          !        designation
      END TYPE CLC_ACT
      INTEGER, PARAMETER :: LEN_CLC_ACT=28
      INTEGER, PARAMETER :: VER_CLC_ACT=200501


      INTEGER, PARAMETER :: LC_CTRL_KWH = 12
      INTEGER, PARAMETER :: LC_CACT1_KWH = 12
      INTEGER, PARAMETER :: LC_HIST_KWH = 13
      INTEGER, PARAMETER :: ACT_TASK_KWH = 14
      INTEGER, PARAMETER :: ACT_TASK_KWL = 0
      INTEGER, PARAMETER :: LC_ACT0_KWH = 14
      INTEGER, PARAMETER :: LC_ACT_KWH = 14

      END MODULE CDB_TYPES_LFC

!     end of automatically generated header
!     SOFiSTiK AG
!
