!     cdbtypesys.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_SYS
 
      TYPE CCTRL_010               ! 0/01:999  AccessInfo Last Program
        SEQUENCE
        INTEGER   ID               !        Identifier 999
        INTEGER   ACCE             !        Number of access
        INTEGER   VERS             !        Version number
        INTEGER   NAME(17)         !        Name of Program
        INTEGER   ERR(4)           !        Name of ERR-File
      END TYPE CCTRL_010
      INTEGER, PARAMETER :: LEN_CCTRL_010=24
      INTEGER, PARAMETER :: VER_CCTRL_010=201004

      TYPE CCTRL_011               ! 0/01:?  Messages
        SEQUENCE
        INTEGER   ID               !        Level
        INTEGER   IDERR(2)         !        Number of errortext
        INTEGER   IDSUP(4)         !        Name of subroutine
        INTEGER   ITEXT(6)         !        Text value of message
        INTEGER   NILIST           !        count on Integer values of message
        INTEGER   NRLIST           !        count on Real values of message
        INTEGER   LIST(255)        !        values of message ILIST+RLIST
      END TYPE CCTRL_011
      INTEGER, PARAMETER :: LEN_CCTRL_011=270
      INTEGER, PARAMETER :: VER_CCTRL_011=200706

      TYPE CCTRL_OBJ               ! 0/01:101  involved objects
        SEQUENCE
        INTEGER   ID               !        Identifier = 101
        INTEGER   ID2              !        bitpattern of specified data
        INTEGER   TYPE             !        KWH of Elementtype (30,31,32,33)
        INTEGER   NR               !        Number of element  (TYPE/NR)
        INTEGER   IDBIM(32)        !        256 Bit GUId Identifier of element in the BIM/CAD system
        REAL*4      UVW(3)         ! [1001] local coordinates in object
        REAL*4      BOX(3,2)       ! [1001] bounding box x,y,z min, x,y,z max
      END TYPE CCTRL_OBJ
      INTEGER, PARAMETER :: LEN_CCTRL_OBJ=45
      INTEGER, PARAMETER :: VER_CCTRL_OBJ=200706

      TYPE CCTRL_OID               ! 0/01:102  GUId
        SEQUENCE
        INTEGER   ID               !        identifier 102
        INTEGER   IDBIM(36)        !        256 Bit GUId Identifier of preceeding element
      END TYPE CCTRL_OID
      INTEGER, PARAMETER :: LEN_CCTRL_OID=37
      INTEGER, PARAMETER :: VER_CCTRL_OID=201005

      TYPE CSSD_SPE                ! 0/96:1  SSD-Spezial
        SEQUENCE
        INTEGER   ID               !        id==1
        INTEGER   TYPE             !        type of information
        INTEGER   IVAL             !        integer value
        REAL*4      RVAL(3)        !        real values
        INTEGER   ITXT(4)          !        string value
      END TYPE CSSD_SPE
      INTEGER, PARAMETER :: LEN_CSSD_SPE=10
      INTEGER, PARAMETER :: VER_CSSD_SPE=0

      TYPE CVIS_LC0                ! 0/97:0  active Loadcase
        SEQUENCE
        INTEGER   ID               !        id==0
        INTEGER   LFNR             !        Loadcase number
        INTEGER   VIS              !        unused
      END TYPE CVIS_LC0
      INTEGER, PARAMETER :: LEN_CVIS_LC0=3
      INTEGER, PARAMETER :: VER_CVIS_LC0=0

      TYPE CVIS_LC                 ! 0/97:1  Loadcase visualisation
        SEQUENCE
        INTEGER   ID               !        id==1
        INTEGER   LFNR             !        Loadcase number
        INTEGER   VIS              !        Visualisation
      END TYPE CVIS_LC
      INTEGER, PARAMETER :: LEN_CVIS_LC=3
      INTEGER, PARAMETER :: VER_CVIS_LC=0

      INTEGER, PARAMETER :: CTRL_ACCESS_MIX=1
      INTEGER, PARAMETER :: CTRL_ACCESS_CONVERT=2
      INTEGER, PARAMETER :: CTRL_ACCESS_2010=4
      INTEGER, PARAMETER :: CTRL_ACCESS_2012=8
      INTEGER, PARAMETER :: CTRL_ACCESS_2014=16
      INTEGER, PARAMETER :: CTRL_ACCESS_2016=32
      INTEGER, PARAMETER :: CTRL_ACCESS_2018=64
      INTEGER, PARAMETER :: CTRL_ACCESS_2020=128
      TYPE CCTRL                   ! 0/99:*  PrintControl
        SEQUENCE
        INTEGER   MAXL             !        Lines per page
        INTEGER   MARG             !        Left margin
        INTEGER   TOBO             !        Top/bottom margin
        INTEGER   MODP             !        Type of Headding
        INTEGER   PAGE             !        Current page no
        INTEGER   LOUT             !        Output Language
        INTEGER   LINP             !        Input  Language
        INTEGER   UNIT             !        Unit set
        INTEGER   ACCE             !        No of last access
        INTEGER   PAG(7)           !        Paging Text
        INTEGER   REL_VERS         !        ReleaseVersion of this database
        INTEGER   REL_BITS         !        Accessbits
      END TYPE CCTRL
      INTEGER, PARAMETER :: LEN_CCTRL=18
      INTEGER, PARAMETER :: VER_CCTRL=200501

      TYPE CCTRL_0                 ! 0/99:0  AccessInfo
        SEQUENCE
        INTEGER   ID               !        Identifier 0
        INTEGER   ACCE             !        Number of access
        INTEGER   VERS             !        Version number
        INTEGER   ERRO             !        Number of Errors
        INTEGER   WARN             !        Number of Errors
        INTEGER   NAME(17)         !        Name of Program
        INTEGER   REL_VERS         !        ReleaseVersion of last access
      END TYPE CCTRL_0
      INTEGER, PARAMETER :: LEN_CCTRL_0=23
      INTEGER, PARAMETER :: VER_CCTRL_0=200501

      TYPE CCTRL_1                 ! 0/99:1  AccessTitle
        SEQUENCE
        INTEGER   ID               !        Identifier 1
        INTEGER   ACCE             !        Number of access
        INTEGER   KOPF(64)         !        Title of access
      END TYPE CCTRL_1
      INTEGER, PARAMETER :: LEN_CCTRL_1=66
      INTEGER, PARAMETER :: VER_CCTRL_1=200501

      TYPE CCTRL_VAR               ! 0/100  Global_CADINP_Variable
        SEQUENCE
        INTEGER   NAME(4)          !        name of variable
        INTEGER   IND              !        index for arrays
        REAL*4      VAL            !        value of variable
        INTEGER   SCOPE            !        name of scope
        INTEGER   DIM              !        unit of variable
        INTEGER   TXT(17)          !        Comment on variable
      END TYPE CCTRL_VAR
      INTEGER, PARAMETER :: LEN_CCTRL_VAR=25
      INTEGER, PARAMETER :: VER_CCTRL_VAR=201310

      TYPE CCTRL_VAP               ! 0/100:???  Private_CADINP_Variable
        SEQUENCE
        INTEGER   ID               !        Identification = ???
        INTEGER   IND1             !        Lower Index of variable
        INTEGER   IND2             !        Upper Index of variable
        INTEGER   NAME(4)          !        Name of variable
        REAL*4      VAL(1020)      !        values of the variable NAME[IND1:IND2]
      END TYPE CCTRL_VAP
      INTEGER, PARAMETER :: LEN_CCTRL_VAP=1027
      INTEGER, PARAMETER :: VER_CCTRL_VAP=200704

      TYPE CCTRL_DIM               ! 0/101  Unit definitions
        SEQUENCE
        INTEGER   IDIM             !        number of an implicit unit (>999)
        INTEGER   UNIA             !        unit for output (0=do not change)
        INTEGER   UNIE             !        unit for input  (0=do not change)
        INTEGER   DIGA             !        number of digits for output (>10 for Exponential)
        INTEGER   DIGE             !        number of digits for input (=GUI)
      END TYPE CCTRL_DIM
      INTEGER, PARAMETER :: LEN_CCTRL_DIM=5
      INTEGER, PARAMETER :: VER_CCTRL_DIM=201606

      TYPE CCSM_GRP                ! 15/-1  Construction Stage Group Definitions
        SEQUENCE
        INTEGER   GRP              !        Group number
        INTEGER   ICS              !        CS number of first activation
        INTEGER   GFIX             !        CS number of hinge fixing
        INTEGER   END              !        CS number of last action
        INTEGER   FREE(2)          !        free integer for later use
        REAL*4      T0             ! [  93] minimum age for loading
      END TYPE CCSM_GRP
      INTEGER, PARAMETER :: LEN_CCSM_GRP=7
      INTEGER, PARAMETER :: VER_CCSM_GRP=200501

      TYPE CCSM_LC                 ! 15/-2  Construction Stage Loadcase Definitions
        SEQUENCE
        INTEGER   LC               !        Loadcase
        INTEGER   START            !        CS number for first action
        INTEGER   END              !        CS number of last action
      END TYPE CCSM_LC
      INTEGER, PARAMETER :: LEN_CCSM_LC=3
      INTEGER, PARAMETER :: VER_CCSM_LC=200501

      TYPE CCSM_CS                 ! 15/-3  Construction Stage Table
        SEQUENCE
        INTEGER   CS               !        Construction Stage
        INTEGER   ID               !        Main action type in this CS
        INTEGER   CSTEP            !        number of creep+shrink step to be produced
        INTEGER   DL_CS            !        dead load activation in composite cross sections
        INTEGER   FREE(2)          !        free integer for later use
        REAL*4      DT             ! [  93] duration of creep+shrink step
        REAL*4      RH             ! [   8] relative humidity in this creep+shrink step
        REAL*4      TEMP           ! [   8] temperture in this creep+shrink step
      END TYPE CCSM_CS
      INTEGER, PARAMETER :: LEN_CCSM_CS=9
      INTEGER, PARAMETER :: VER_CCSM_CS=200501

      TYPE CCSM_CREE               ! 15/-4  creep+shrink values for manual input
        SEQUENCE
        INTEGER   MNO              !        Material number
        INTEGER   GRP              !        Group number
        REAL*4      PHI            !        total creep factor from first loading til infinite
        REAL*4      EPS            !        total shrinkage coefficient
        REAL*4      RELAX          !        total tendon relaxation
      END TYPE CCSM_CREE
      INTEGER, PARAMETER :: LEN_CCSM_CREE=5
      INTEGER, PARAMETER :: VER_CCSM_CREE=200501

      TYPE CCSG_CS                 ! 15/-10  Construction Stage
        SEQUENCE
        INTEGER   NO               !        construction stage number
        INTEGER   TITL(32)         !        Designation
        REAL*4      DT             ! [  93] duration of construction stage
      END TYPE CCSG_CS
      INTEGER, PARAMETER :: LEN_CCSG_CS=34
      INTEGER, PARAMETER :: VER_CCSG_CS=200501

      TYPE CCSG_CGRP               ! 15/-11  Group specification
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        INTEGER   NO               !        group number
        INTEGER   ACT              !        group action
        INTEGER   ACT2             !        group action cont'd
        INTEGER   PTYP             !        type of prestressing
        INTEGER   PLQ              !        primary load case swelling
        INTEGER   MNO              !        material number
        REAL*4      FACS           !        stiffness factor
        REAL*4      ALPH           !        alpha factor
        REAL*4      HW             ! [  13] ground water level
        REAL*4      K              !        earth pressure coefficient
        REAL*4      P              !        prestress force
      END TYPE CCSG_CGRP
      INTEGER, PARAMETER :: LEN_CCSG_CGRP=12
      INTEGER, PARAMETER :: VER_CCSG_CGRP=200501

      TYPE CCSG_CLAS               ! 15/-12  Load specification
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        INTEGER   NO               !        number of referenced loadcase
        INTEGER   OPT              !        option of the load
        REAL*4      FACT           !        factor for loads
      END TYPE CCSG_CLAS
      INTEGER, PARAMETER :: LEN_CCSG_CLAS=4
      INTEGER, PARAMETER :: VER_CCSG_CLAS=200501

      TYPE CCSG_CSYS               ! 15/-13  System specification
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        INTEGER   PROB             !        problem type
      END TYPE CCSG_CSYS
      INTEGER, PARAMETER :: LEN_CCSG_CSYS=2
      INTEGER, PARAMETER :: VER_CCSG_CSYS=200501

      TYPE CCSG_CCRL               ! 15/-14  Computation control
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        INTEGER   OPT              !        control option
        INTEGER   SAVE             !        save interval
        INTEGER   FACQ             !        not used
        REAL*4      VAL            !        value of the option
        REAL*4      FMAX           !        2nd value of the option
        REAL*4      FMIN           !        3rd value of the option
        REAL*4      EMAX           !        4th value of the option
        REAL*4      EMIN           !        5th value of the option
        REAL*4      V6             !        6th value of the option
        REAL*4      V7             !        7th value of the option
        REAL*4      V8             !        8th value of the option
      END TYPE CCSG_CCRL
      INTEGER, PARAMETER :: LEN_CCSG_CCRL=12
      INTEGER, PARAMETER :: VER_CCSG_CCRL=200501

      TYPE CCSG_CGW                ! 15/-15  Change ground water level
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        REAL*4      HW             ! [  13] new ground water level
      END TYPE CCSG_CGW
      INTEGER, PARAMETER :: LEN_CCSG_CGW=2
      INTEGER, PARAMETER :: VER_CCSG_CGW=200501

      TYPE CCSG_ECHO               ! 15/-16  Echo options
        SEQUENCE
        INTEGER   ICS              !        corresponding cs number
        INTEGER   OPT              !        echo option
        INTEGER   VAL              !        value of the option
      END TYPE CCSG_ECHO
      INTEGER, PARAMETER :: LEN_CCSG_ECHO=3
      INTEGER, PARAMETER :: VER_CCSG_ECHO=200501

      TYPE CCSM_LC1                ! 15/LC:1  CSM loadcase parameters Group members
        SEQUENCE
        INTEGER   ID               !        identifier 1
        INTEGER   GRP              !        Group number
        REAL*4      T1             ! [  93] age at the end of loadcase
        REAL*4      SUMEPS         !        accumulated shrinkage strain
      END TYPE CCSM_LC1
      INTEGER, PARAMETER :: LEN_CCSM_LC1=4
      INTEGER, PARAMETER :: VER_CCSM_LC1=200501

      TYPE CCSM_LC2                ! 15/LC:2  CSM loadcase parameters quad-tendon members
        SEQUENCE
        INTEGER   ID               !        identifier 2
        INTEGER   GRP              !        quad-tendon number
        REAL*4      T1             ! [  93] age at the end of loadcase
        REAL*4      SUMRELAX       !        accumulated quad-tendon relaxation
      END TYPE CCSM_LC2
      INTEGER, PARAMETER :: LEN_CCSM_LC2=4
      INTEGER, PARAMETER :: VER_CCSM_LC2=200501

      TYPE CVIEW                   ! 18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
        SEQUENCE
        INTEGER   IACHS            !        downward direction (compare 10/0)
        INTEGER   PERS             !        Perspective
        INTEGER   LC               !        loadcase
        INTEGER   VOPT             !        View Options (Bitcode I)
        INTEGER   EOPT             !        Element Options (Bitcode II)
        INTEGER   COPT             !        Colour Options (Bitcode III)
        INTEGER   DUMMY(3)         !        reserved
        INTEGER   TOPT             !        Exchange option
        REAL*4      XBL            ! [1001] X-coordinate of view point
        REAL*4      YBL            ! [1001] Y-coordinate of view point
        REAL*4      ZBL            ! [1001] Z-coordinate of view point
        REAL*4      XCAM           ! [1001] X-coordinate of camera point
        REAL*4      YCAM           ! [1001] Y-coordinate of camera point
        REAL*4      ZCAM           ! [1001] Z-coordinate of camera point
        REAL*4      FAKV           !        Factor of deformed structure
        REAL*4      SSIZ           !        Size of supports (0.-100.)
        REAL*4      WMAG           !        Warping magnification (0.-100.)
        REAL*4      FOVY           ! [   5] perspective angle of field of view
        REAL*4      XUP            !        X-part Up Vector
        REAL*4      YUP            !        Y-part Up Vector
        REAL*4      ZUP            !        Z-part Up Vector
      END TYPE CVIEW
      INTEGER, PARAMETER :: LEN_CVIEW=23
      INTEGER, PARAMETER :: VER_CVIEW=0

      TYPE CVIEW_SEL_R             !        Range lower and upper limit
        SEQUENCE
        INTEGER   LOW
        INTEGER   UPP
      END TYPE CVIEW_SEL_R
      INTEGER, PARAMETER :: LEN_CVIEW_SEL_R=2

      TYPE CVIEW_SEL               ! 18/-2  currently selected elements in WINGRAF
        SEQUENCE
        INTEGER   ID               !        Identifikator
        TYPE(CVIEW_SEL_R) R(32)    !        Range lower and upper limit
      END TYPE CVIEW_SEL
      INTEGER, PARAMETER :: LEN_CVIEW_SEL=65
      INTEGER, PARAMETER :: VER_CVIEW_SEL=0

      TYPE CVIEW_SRE               ! 18/-3  currently selected results in WINGRAF
        SEQUENCE
        INTEGER   KWH              !        Main key of current item
        INTEGER   KWL              !        Secondary key of cuurent item (LF,MAT)
        INTEGER   VALUES(14)       !        Selected values of this record type
      END TYPE CVIEW_SRE
      INTEGER, PARAMETER :: LEN_CVIEW_SRE=16
      INTEGER, PARAMETER :: VER_CVIEW_SRE=0

      TYPE CMTXT_0                 ! 18/-4:0  Header for membrane manufacturing
        SEQUENCE
        INTEGER   ID               !        identificator = 0
        INTEGER   LF               !        used load case of a deformed structure Lastfallnummer einer ver
        INTEGER   BITS             !        Bitpattern of conditions of evaluation
        INTEGER   NFL              !        Number of manufacturing areas
        INTEGER   NQU              !        total number of QUADS within those areas
        INTEGER   NNO              !        Number of new nodes inserted
      END TYPE CMTXT_0
      INTEGER, PARAMETER :: LEN_CMTXT_0=6
      INTEGER, PARAMETER :: VER_CMTXT_0=0

      TYPE CMTXT_NOD               ! 18/-4:-  Definition of new nodes
        SEQUENCE
        INTEGER   NO               !        Number of new interpolated node
        INTEGER   QUAD             !        Nummer of QUAD-element containing this node
        REAL*4      S              !        S-Koordinate im QUAD-Element
        REAL*4      T              !        T-Koordinate im QUAD-Element
      END TYPE CMTXT_NOD
      INTEGER, PARAMETER :: LEN_CMTXT_NOD=4
      INTEGER, PARAMETER :: VER_CMTXT_NOD=0

      TYPE CMTXT_ELM               ! 18/-4:+  Definition of manufacturing elements
        SEQUENCE
        INTEGER   NO               !        Number of manufacturing area
        INTEGER   QUAD             !        Number of QUAD-element
        INTEGER   N1               !        1st node (< 0 if new interpolated node)
        INTEGER   N2               !        2nd node (< 0 if new interpolated node)
        INTEGER   N3               !        3rd node (< 0 if new interpolated node)
        INTEGER   N4               !        4th node (< 0 if new interpolated node)
      END TYPE CMTXT_ELM
      INTEGER, PARAMETER :: LEN_CMTXT_ELM=6
      INTEGER, PARAMETER :: VER_CMTXT_ELM=0

      TYPE CVIEW_MCO               ! 18/-5  Colour of material
        SEQUENCE
        INTEGER   NO               !        Number of material / group
        REAL*4      RED            !        RGBA: red color
        REAL*4      GREEN          !        RGBA: green color
        REAL*4      BLUE           !        RGBA: blue color
        REAL*4      ALPHA          !        RGBA: alpha value
      END TYPE CVIEW_MCO
      INTEGER, PARAMETER :: LEN_CVIEW_MCO=5
      INTEGER, PARAMETER :: VER_CVIEW_MCO=0

      TYPE CVIEW_GCO               ! 18/-6  Colour of group
        SEQUENCE
        INTEGER   NO               !        Number of material / group
        REAL*4      RED            !        RGBA: red color
        REAL*4      GREEN          !        RGBA: green color
        REAL*4      BLUE           !        RGBA: blue color
        REAL*4      ALPHA          !        RGBA: alpha value
      END TYPE CVIEW_GCO
      INTEGER, PARAMETER :: LEN_CVIEW_GCO=5
      INTEGER, PARAMETER :: VER_CVIEW_GCO=0

      INTEGER, PARAMETER :: ANI_SELE_IGRP_ELEM=0
      INTEGER, PARAMETER :: ANI_SELE_IGRP_BEAM=1
      INTEGER, PARAMETER :: ANI_SELE_IGRP_GRUP=2
      INTEGER, PARAMETER :: ANI_SELE_IGRP_SLN=3
      TYPE CANI_SELE               ! 18/-101:1  Dialogbox Animator selection request
        SEQUENCE
        INTEGER   SELE             !        identifier 1 : selection request
        INTEGER   IGRP             !        element-group switch
        INTEGER   NSEL             !        necessary-possible amount of selected elements
        INTEGER   ETYP             !        requested element type - multiple records allowed
        INTEGER   FROM             !        select only elements or groups from FROM to TO
        INTEGER   TO               !        TO
      END TYPE CANI_SELE
      INTEGER, PARAMETER :: LEN_CANI_SELE=6
      INTEGER, PARAMETER :: VER_CANI_SELE=0

      TYPE CANI_CTRL               ! 18/-101:2  Dialogbox Animator drawing controls
        SEQUENCE
        INTEGER   SELE             !        identifier 2 : drawing controls
        INTEGER   IGRP             !        element-group switch as in record 018/-101
        INTEGER   NSEL             !        free
        INTEGER   ETYP             !        element type - see 018/-101:1
        INTEGER   FROM             !        drawing controls for elements/groups from FROM to TO
        INTEGER   TO               !        TO
        INTEGER   STYLE            !        representation style guide number
        REAL*4      RGBA(4)        !        colour and transparency factor - only for STYLE=1
      END TYPE CANI_CTRL
      INTEGER, PARAMETER :: LEN_CANI_CTRL=11
      INTEGER, PARAMETER :: VER_CANI_CTRL=0

      TYPE CANI_SRES               ! 18/-103  Selection result from Animator
        SEQUENCE
        INTEGER   ID101            !        access ID of 18/-101 to check if selection allready done
        INTEGER   IGRP             !        element-group switch as defined in 018/-101
        INTEGER   ISEL             !        termination control
        INTEGER   ETYP             !        element type - see 018/-101:1
        INTEGER   FROM             !        first selected element or group
        INTEGER   TO               !        last "
        INTEGER   FREE             !        not used
        REAL*4      X              ! [1001] sectional abscissa
      END TYPE CANI_SRES
      INTEGER, PARAMETER :: LEN_CANI_SRES=8
      INTEGER, PARAMETER :: VER_CANI_SRES=0

      TYPE CLC_SELF                ! 18/LCD  Self weight loading of elements from ASE
        SEQUENCE
        INTEGER   KWH              !        Type of load element
        INTEGER   NR               !        all other values as in KWH/LC
        INTEGER   TYP              !        all other values as in KWH/LC
        REAL*4      PVAL(1)        !        all other values as in KWH/LC
                                   !        unknwon length!
      END TYPE CLC_SELF
      INTEGER, PARAMETER :: LEN_CLC_SELF=4
      INTEGER, PARAMETER :: VER_CLC_SELF=0

      TYPE CGRP_BIL                ! 19/LC  Bilances of Flow in HYDRA
        SEQUENCE
        INTEGER   ID               !        type of result
        INTEGER   NR               !        group number
        REAL*4      QINP           !        Quantity of inflow
        REAL*4      QOUT           !        Quantity of outflow
        REAL*4      QNEW           !        Quantity generated in domain
        REAL*4      ENER           !        Energy term
      END TYPE CGRP_BIL
      INTEGER, PARAMETER :: LEN_CGRP_BIL=6
      INTEGER, PARAMETER :: VER_CGRP_BIL=201112

      TYPE CHIST_HED               ! 80/LC:-10?  TimeHistoryTitle
        SEQUENCE
        REAL*4      RID            !        Identifier of history type
        INTEGER   TITLE(33)        !        Designation
      END TYPE CHIST_HED
      INTEGER, PARAMETER :: LEN_CHIST_HED=34
      INTEGER, PARAMETER :: VER_CHIST_HED=200501

      TYPE CHIST_PAR               ! 80/LC:-9??  IterationParameters
        SEQUENCE
        REAL*4      RID            !        identifier
        REAL*4      VAL            !        current value
        REAL*4      MIN            !        minimum allowed value
        REAL*4      MAX            !        maximum allowed value
        INTEGER   NAME(17)         !        name of parameter
      END TYPE CHIST_PAR
      INTEGER, PARAMETER :: LEN_CHIST_PAR=21
      INTEGER, PARAMETER :: VER_CHIST_PAR=200501

      TYPE CHIST_ITEM              !        History element
        SEQUENCE
        INTEGER   NR
        INTEGER   TYP
      END TYPE CHIST_ITEM
      INTEGER, PARAMETER :: LEN_CHIST_ITEM=2

      TYPE CHIST                   ! 80/LC:-  Identification of history elements
        SEQUENCE
        REAL*4      RID            !        Identification -100 < RID < 0.
        TYPE(CHIST_ITEM) ITEM(32)  !        History element
      END TYPE CHIST
      INTEGER, PARAMETER :: LEN_CHIST=65
      INTEGER, PARAMETER :: VER_CHIST=200502

      TYPE CHIST_VAL               ! 80/LC:+  Transient data
        SEQUENCE
        REAL*4      TT             !        Time/frequency
        REAL*4      VB(32)         !        curve values
      END TYPE CHIST_VAL
      INTEGER, PARAMETER :: LEN_CHIST_VAL=33
      INTEGER, PARAMETER :: VER_CHIST_VAL=200501

      TYPE CSLVL_DAT               ! 87/0:+  Structural Storey Level Data
        SEQUENCE
        INTEGER   NR               !        Storey Level ID (34/NR)
        INTEGER   NREF(2)          !        Node numbers of reference nodes on level
        INTEGER   NR_COR           !        spt number of center of rigidity (COR)
        INTEGER   NR_COM           !        spt number of center of mass (COM)
        INTEGER   CREATOR          !        generated by (program) (0=SOFiMSHC, 1=DYNA)
        REAL*4      ZLEV           ! [1006] Storey elevation, upwards positive (reference)
        REAL*4      H              ! [1001] Storey height
        REAL*4      XEXT(2)        ! [1001] Storey extensions in global X [XMIN, XMAX]
        REAL*4      YEXT(2)        ! [1001] Storey extensions in global Y [YMIN, YMAX]
        REAL*4      MASS           ! [1180] Storey mass
        REAL*4      XYZM(3)        ! [1001] Coordinates of COM
        REAL*4      STX            ! [1095] Storey stiffness in global X
        REAL*4      STY            ! [1095] Storey stiffness in global Y
        REAL*4      XYZR(3)        ! [1001] Coordinates of COR
        REAL*4      CPX            ! [1151] Storey capacity in global X
        REAL*4      CPY            ! [1151] Storey capacity in global Y
        INTEGER   TEXT(17)         !        Designation of level
      END TYPE CSLVL_DAT
      INTEGER, PARAMETER :: LEN_CSLVL_DAT=40
      INTEGER, PARAMETER :: VER_CSLVL_DAT=200902

      TYPE CSLVL_RES               ! 87/LC:+  Structural Storey Level Results
        SEQUENCE
        INTEGER   NR               !        Storey Level ID (34/NR)
        INTEGER   NR_MODE          !        mode number (=0: resultant values, e.g. from CQC sup.)
        INTEGER   STYP(2)          !        superposition type
        REAL*4      PX             ! [1151] base shear in X
        REAL*4      PY             ! [1151] base shear in Y
        REAL*4      PZ             ! [1151] total vertical load at and above the storey
        REAL*4      MX             ! [1152] moment about X
        REAL*4      MY             ! [1152] moment about Y
        REAL*4      MZ             ! [1152] moment about Z
        REAL*4      UX             ! [1003] average storey displacement in X (=translations at COR)
        REAL*4      UY             ! [1003] average storey displacement in Y
        REAL*4      UZ             ! [1003] average storey displacement in Z
        REAL*4      RZ             ! [1004] average storey rotation in XY-plane
        REAL*4      DX             ! [1003] inter-storey drift in X (=difference between top and bottom of 
        REAL*4      DY             ! [1003] inter-storey drift in Y
        REAL*4      DRZ            ! [1004] inter-storey rotation in XY-plane
        REAL*4      LSAF           ! [  98] modal acceleration (only for NR_MODE>0)
      END TYPE CSLVL_RES
      INTEGER, PARAMETER :: LEN_CSLVL_RES=18
      INTEGER, PARAMETER :: VER_CSLVL_RES=200902

      END MODULE CDB_TYPES_SYS

!     end of automatically generated header
!     SOFiSTiK AG
!
