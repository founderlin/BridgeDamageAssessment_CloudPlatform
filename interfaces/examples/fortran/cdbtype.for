!     cdbtype.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES
! ----------------------------------------------------------------------
! * ALL ATOMIC STRUCTURES AND PARAMETER DEFINITIONS FOR CDBASE ITEMS   *
! ----------------------------------------------------------------------
      TYPE CDB01   !  GENERAL DATA WITH ONE INTEGER
           SEQUENCE
           INTEGER IS
           REAL    SS(256)
      END TYPE CDB01
      TYPE CDB01_0 !  GENERAL DATA WITH ONE INTEGER
           SEQUENCE
           INTEGER IS
           REAL    SS(0:255)
      END TYPE CDB01_0
      INTEGER, PARAMETER :: LEN_CDB01=1+256
 
      TYPE CDB02   !  GENERAL DATA WITH TWO INTEGERS
           SEQUENCE
           INTEGER IS(0:1)
           REAL    SS(256)
      END TYPE CDB02
      TYPE CDB02_0 !  GENERAL DATA WITH TWO INTEGERS
           SEQUENCE
           INTEGER IS(0:1)
           REAL    SS(0:255)
      END TYPE CDB02_0
      INTEGER, PARAMETER :: LEN_CDB02=2+256
 
      TYPE CDB03   !  GENERAL DATA WITH TWO INTEGERS
           SEQUENCE
           INTEGER IS(0:2)
           REAL    SS(256)
      END TYPE CDB03
      TYPE CDB03_0 !  GENERAL DATA WITH TWO INTEGERS
           SEQUENCE
           INTEGER IS(0:2)
           REAL    SS(0:255)
      END TYPE CDB03_0
      INTEGER, PARAMETER :: LEN_CDB03=3+256
 
      TYPE CDB04   !  GENERAL DATA WITH FOUR INTEGERS
           SEQUENCE
           INTEGER IS(0:3)
           REAL    SS(256)
      END TYPE CDB04
      TYPE CDB04_0 !  GENERAL DATA WITH FOUR INTEGERS
           SEQUENCE
           INTEGER IS(0:3)
           REAL    SS(0:255)
      END TYPE CDB04_0
      INTEGER, PARAMETER :: LEN_CDB04=4+256
 
      TYPE CDB05   !  GENERAL DATA WITH FIVE INTEGERS
           SEQUENCE
           INTEGER IS(0:4)
           REAL    SS(256)
      END TYPE CDB05
      TYPE CDB05_0 !  GENERAL DATA WITH FIVE INTEGERS
           SEQUENCE
           INTEGER IS(0:4)
           REAL    SS(0:255)
      END TYPE CDB05_0
      INTEGER, PARAMETER :: LEN_CDB05=5+256
 
      TYPE CDB06   !  GENERAL DATA WITH SIX INTEGERS
           SEQUENCE
           INTEGER IS(0:5)
           REAL    SS(256)
      END TYPE CDB06
      TYPE CDB06_0 !  GENERAL DATA WITH SIX INTEGERS
           SEQUENCE
           INTEGER IS(0:5)
           REAL    SS(0:255)
      END TYPE CDB06_0
      INTEGER, PARAMETER :: LEN_CDB06=6+256
 
! ---------------------------------------------------------
 
      TYPE C900    !  CROSS SECTION VALUES / MATERIALS
           SEQUENCE
           INTEGER ISP(0:2)
           REAL    SP(128)
      END TYPE C900
      INTEGER, PARAMETER :: LEN_C900=3+128
      TYPE C900X   !  EXTENDED BUFFER FOR CROSS SECTION VALUES
           SEQUENCE
           INTEGER ISP(0:2)
           REAL    SP(1024)
      END TYPE C900X
      TYPE C900X0  !  EXTENDED BUFFER FOR CROSS SECTION VALUES
           SEQUENCE
           INTEGER ISP(0:2)
           REAL    SP(0:1023)
      END TYPE C900X0
      INTEGER, PARAMETER :: LEN_C900X=3+1024
 
      TYPE CSYST                   ! 10/00  SystemInfo
        SEQUENCE
        INTEGER   IPROB            !        Type of System
        INTEGER   IACHS            !        Orientation of gravity
        INTEGER   NKNOT            !        Number of nodes
        INTEGER   MKNOT            !        Highest node number
        INTEGER   IGDIV            !        Group divisor
        INTEGER   IGRES
        REAL*4      BOX(3,2)       ! [1001] bounding box
        REAL*4      TG(3,0:3)      !        global CDB-System transformation matrix
        INTEGER   TXT(64)          !        Name of projekt, 127 chars
      END TYPE CSYST
      INTEGER, PARAMETER :: LEN_CSYST=88
      INTEGER, PARAMETER :: VER_CSYST=200501

      TYPE CSYST_DES               ! 10/1:0  SystemDesignCode
        SEQUENCE
        INTEGER   ID               !        identifier = 0
        INTEGER   IDC              !        Design code enumeration
        INTEGER   COUNTRY          !        Country code for variants
        INTEGER   CODE             !        main number or ident of code
        INTEGER   YEAR             !        Year of publication
        INTEGER   CLASS            !        classification (see master.ini)
        INTEGER   TXT(4)           !        specific Text of Design code (16 characters)
        INTEGER   WIND             !        enum of a wind classification (see master.ini)
        INTEGER   SNOW             !        enum of a snow-classification (see master.ini)
        INTEGER   SEIS             !        enum of a seismic-classification (see master.ini)
        REAL*4      GRAVITY        ! [1202] explicit gravity acceleration constant for site
        REAL*4      ALTIOBS        ! [1006] obsoleted altitude above sea level
        REAL*4      VERS           !        Version number of INI-File (21.0)
        REAL*4      LONGITUD       ! [ 205] longitude of location
        REAL*4      LATITUDE       ! [ 205] latitude of location
        REAL*4      ALTITUDE       ! [1006] altitude above sea level
      END TYPE CSYST_DES
      INTEGER, PARAMETER :: LEN_CSYST_DES=19
      INTEGER, PARAMETER :: VER_CSYST_DES=200502

      TYPE CSYST_ACT               ! 10/1:1  Predefined Actions from INI-file
        SEQUENCE
        INTEGER   ID               !        identifier = 1
        INTEGER   ACTION           !        ID of the real action = type of action
        INTEGER   TYPE             !        16*Part of action + superposition
        REAL*4      GAMU           !        safety factor unfavourable
        REAL*4      GAMF           !        safety factor favourable
        REAL*4      PSI0           !        combination value
        REAL*4      PSI1           !        frequent combination value
        REAL*4      PSI2           !        quasi permanent combination value
        REAL*4      PS1S           !        non frequent combination value psi1'
        REAL*4      GAMA           !        safety factor accidential
        INTEGER   CAT              !        sub category of action
        INTEGER   TXTREF           !        designation_enum in SOFISTIK.ERR
        INTEGER   TXT(17)          !        explicit designation (in native language)
      END TYPE CSYST_ACT
      INTEGER, PARAMETER :: LEN_CSYST_ACT=29
      INTEGER, PARAMETER :: VER_CSYST_ACT=200501

      TYPE CSYST_COM_ACT           !        Identifier of action
        SEQUENCE
        INTEGER   ID
        REAL*4      FAKU
        REAL*4      FAKF
      END TYPE CSYST_COM_ACT
      INTEGER, PARAMETER :: LEN_CSYST_COM_ACT=3

      TYPE CSYST_COM               ! 10/1:2  Possible Combination of actions
        SEQUENCE
        INTEGER   ID               !        identifier = 2
        INTEGER   LFB              !        loadcase number offset
        INTEGER   EXTR             !        Combination rule equation to be used
        INTEGER   TYPE             !        type or action of resulting load case
        INTEGER   APPLY            !        Is generally used for:
        INTEGER   TXT(8)           !        Name of combination
        REAL*4      DUMMY          !        reserved
        TYPE(CSYST_COM_ACT) ACT(31)!        Identifier of action
      END TYPE CSYST_COM
      INTEGER, PARAMETER :: LEN_CSYST_COM=107
      INTEGER, PARAMETER :: VER_CSYST_COM=200501

!  -- Number of groups allowed --
      INTEGER, PARAMETER, PUBLIC :: MAXGRP=999

      TYPE CGRP                    ! 11/00  Groups
        SEQUENCE
        INTEGER   NG               !        group-number
        INTEGER   TYP              !        element code
        INTEGER   NUM              !        number of elements of this type
        INTEGER   MIN              !        minimum element-number of group
        INTEGER   MAX              !        maximum element-number of group
        INTEGER   MNR              !        material-number of group
        INTEGER   MBW              !        reinforcement material-number of group
        INTEGER   INF              !        Bit-code of group
        REAL*4      FAKS           !        stiffness factor of group (ASE/TALPA)
        REAL*4      FAKA           !        reducing factor of axial bedding for piles
        REAL*4      FAKT           !        reducing factor of transverse bedding
        REAL*4      VTOT           ! [1093] total volume
        REAL*4      MTOT           ! [1093] total mass
        REAL*4      RTOT           ! [1030] total reinforcement
        REAL*4      ETOT           ! [1093] total energy
        REAL*4      ECOM           ! [1093] compression energy
        REAL*4      EDEV           ! [1093] shear energy
        REAL*4      EKIN           ! [1093] kinetic energy
        REAL*4      EPOT           ! [1093] potential energy
        REAL*4      EDAM           ! [1093] damping energy
        REAL*4      H_GW           ! [1001] Level of Groundwater
        REAL*4      DUMMY          !        reserved
        INTEGER   TEXT(17)         !        Designation of Group
      END TYPE CGRP
      INTEGER, PARAMETER :: LEN_CGRP=39
      INTEGER, PARAMETER :: VER_CGRP=200501

      TYPE CGRP_LC                 ! 11/LC  Groups of Loadcase
        SEQUENCE
        INTEGER   NG               !        group-number
        INTEGER   TYP              !        element code
        INTEGER   NUM              !        number of elements of this type
        INTEGER   MIN              !        minimum element-number of group
        INTEGER   MAX              !        maximum element-number of group
        INTEGER   MNR              !        material-number of group
        INTEGER   MBW              !        reinforcement material-number of group
        INTEGER   INF              !        Bit-code of group
        REAL*4      FAKS           !        stiffness factor of group (ASE/TALPA)
        REAL*4      FAKA           !        reducing factor of axial bedding for piles
        REAL*4      FAKT           !        reducing factor of transverse bedding
        REAL*4      VTOT           ! [1093] total volume
        REAL*4      MTOT           ! [1093] total mass
        REAL*4      RTOT           ! [1030] total reinforcement
        REAL*4      ETOT           ! [1093] total energy
        REAL*4      ECOM           ! [1093] compression energy
        REAL*4      EDEV           ! [1093] shear energy
        REAL*4      EKIN           ! [1093] kinetic energy
        REAL*4      EPOT           ! [1093] potential energy
        REAL*4      EDAM           ! [1093] damping energy
        REAL*4      H_GW           ! [1001] Level of Groundwater
        REAL*4      DUMMY          !        reserved
        INTEGER   TEXT(17)         !        Designation of Group
      END TYPE CGRP_LC
      INTEGER, PARAMETER :: LEN_CGRP_LC=39
      INTEGER, PARAMETER :: VER_CGRP_LC=200501

      TYPE CNODE                   ! 20/00  Nodes
        SEQUENCE
        INTEGER   NR               !        node-number
        INTEGER   INR              !        internal node-number
        INTEGER   KFIX             !        degree of freedoms
        INTEGER   NCOD             !        additional bit code
        REAL*4      XYZ(3)         ! [1001] X-Y-Z-ordinates
      END TYPE CNODE
      INTEGER, PARAMETER :: LEN_CNODE=7
      INTEGER, PARAMETER :: VER_CNODE=200501

      TYPE CNODE_GRC               ! 20/11:0  number of Nodegroups
        SEQUENCE
        INTEGER   ID
        INTEGER   MAXGRP           !        maximum number of groups per node
      END TYPE CNODE_GRC
      INTEGER, PARAMETER :: LEN_CNODE_GRC=2
      INTEGER, PARAMETER :: VER_CNODE_GRC=200501

      TYPE CNODE_GRP               ! 20/11:+  Nodegroups
        SEQUENCE
        INTEGER   N                !        node-number
        INTEGER   IGRP(1)          !        group-numbers connecting to node
                                   !        unknwon length!
      END TYPE CNODE_GRP
      INTEGER, PARAMETER :: LEN_CNODE_GRP=2
      INTEGER, PARAMETER :: VER_CNODE_GRP=200501

      TYPE CNODE_KIC               ! 21/00:0  Info on kinematic constraints
        SEQUENCE
        INTEGER   ID
        INTEGER   NLEV             !        depth of recurent coupling (obsolete)
        INTEGER   NKIN             !        maximum number of coupling equations
        INTEGER   NVAR             !        maximum number of coupling factors
      END TYPE CNODE_KIC
      INTEGER, PARAMETER :: LEN_CNODE_KIC=4
      INTEGER, PARAMETER :: VER_CNODE_KIC=200501

      TYPE CNODE_KIN               ! 21/00:+  Standard kinematic constraint
        SEQUENCE
        INTEGER   KTL              !        type + 100 * depth + 10000*group-number
        INTEGER   NR               !        node-number
        INTEGER   KR(2)            !        reference nodes
        REAL*4      DXYZ(3)        !        direction of coupling X/Y/Z-axis
        REAL*4      DD             !        factor of interpolation for INTP/INTF/INTS
        REAL*4      FF             !        factor of multiplication (not used)
      END TYPE CNODE_KIN
      INTEGER, PARAMETER :: LEN_CNODE_KIN=9
      INTEGER, PARAMETER :: VER_CNODE_KIN=201704

      TYPE CNODE_KIG_ID            !        node+degree-number of dependent (0)
        SEQUENCE
        INTEGER   NR
        INTEGER   ND
      END TYPE CNODE_KIG_ID
      INTEGER, PARAMETER :: LEN_CNODE_KIG_ID=2

      TYPE CNODE_KIG               ! 21/00:*99  general constraints (equation list)
        SEQUENCE
        INTEGER   KTL
        TYPE(CNODE_KIG_ID) ID(0:255)!        node+degree-number of dependent (0)
      END TYPE CNODE_KIG
      INTEGER, PARAMETER :: LEN_CNODE_KIG=513
      INTEGER, PARAMETER :: VER_CNODE_KIG=201704

      TYPE CNODE_KIF               ! 21/00:*99  general constraints (factor list)
        SEQUENCE
        INTEGER   KTL              !        99 + 100 * depth
        INTEGER   ID               !        identifier 0
        REAL*4      FR(255)        !        factors of constrained equation
      END TYPE CNODE_KIF
      INTEGER, PARAMETER :: LEN_CNODE_KIF=257
      INTEGER, PARAMETER :: VER_CNODE_KIF=201704

      TYPE CNODE_KIH               ! 21/09  Hydraulic couplings
        SEQUENCE
        INTEGER   NG               !        group-number
        INTEGER   NR               !        node-number
        INTEGER   KR               !        reference node
      END TYPE CNODE_KIH
      INTEGER, PARAMETER :: LEN_CNODE_KIH=3
      INTEGER, PARAMETER :: VER_CNODE_KIH=200501

      TYPE CNODE_KFC               ! 22/LC:0  Max. Constraining Forces
        SEQUENCE
        INTEGER   ID               !        identifier 0
        REAL*4      PX             ! [1190] force component X
        REAL*4      PY             ! [1190] force component Y
        REAL*4      PZ             ! [1190] force component Z
        REAL*4      MX             ! [1194] moment component X
        REAL*4      MY             ! [1194] moment component Y
        REAL*4      MZ             ! [1194] moment component Z
        REAL*4      MB             ! [1194] warping moment
      END TYPE CNODE_KFC
      INTEGER, PARAMETER :: LEN_CNODE_KFC=8
      INTEGER, PARAMETER :: VER_CNODE_KFC=200501

      TYPE CNODE_KFO               ! 22/LC:+  Constraining forces
        SEQUENCE
        INTEGER   NR               !        node-number
        REAL*4      PX             ! [1190] force component X
        REAL*4      PY             ! [1190] force component Y
        REAL*4      PZ             ! [1190] force component Z
        REAL*4      MX             ! [1194] moment component X
        REAL*4      MY             ! [1194] moment component Y
        REAL*4      MZ             ! [1194] moment component Z
        REAL*4      MB             ! [1194] warping moment
      END TYPE CNODE_KFO
      INTEGER, PARAMETER :: LEN_CNODE_KFO=8
      INTEGER, PARAMETER :: VER_CNODE_KFO=200501

      TYPE CNODE_L                 ! 23/LC:+  Nodal_loads
        SEQUENCE
        INTEGER   NR               !        node-number
        INTEGER   TYP              !        type of load
        REAL*4      PX             ! [1190] single force X-component
        REAL*4      PY             ! [1190] single force Y-component
        REAL*4      PZ             ! [1190] single force Z-component
        REAL*4      MX             ! [1194] single moment X-component
        REAL*4      MY             ! [1194] single moment Y-component
        REAL*4      MZ             ! [1194] single moment Z-component
        REAL*4      MB             ! [1195] warping moment
      END TYPE CNODE_L
      INTEGER, PARAMETER :: LEN_CNODE_L=9
      INTEGER, PARAMETER :: VER_CNODE_L=200601

      TYPE CNODE_LW                ! 23/LC:+  prescribed support displacements
        SEQUENCE
        INTEGER   NR               !        node-number
        INTEGER   TYP              !        type of load
        REAL*4      WX             ! [1003] Displacement X
        REAL*4      WY             ! [1003] Displacement Y
        REAL*4      WZ             ! [1003] Displacement Z
        REAL*4      RX             ! [1004] Rotation X-X
        REAL*4      RY             ! [1004] Rotation Y-Y
        REAL*4      RZ             ! [1004] Rotation Z-Z
      END TYPE CNODE_LW
      INTEGER, PARAMETER :: LEN_CNODE_LW=8
      INTEGER, PARAMETER :: VER_CNODE_LW=200501

      TYPE CNODE_ACC               ! 23/LC:*  Base acceleration
        SEQUENCE
        INTEGER   NR               !        node number / influence load case
        INTEGER   TYP              !        type of load (=10)
        REAL*4      AX             ! [1202] transversal acceleration X
        REAL*4      AY             ! [1202] transversal acceleration Y
        REAL*4      AZ             ! [1202] transversal acceleration Z
        REAL*4      AXX            ! [1207] rotational acceleration X-X
        REAL*4      AYY            ! [1207] rotational acceleration Y-Y
        REAL*4      AZZ            ! [1207] rotational acceleration Z-Z
        REAL*4      EX             ! [1001] reference point for rotational acceleration
        REAL*4      EY             ! [1001] reference point for rotational acceleration
        REAL*4      EZ             ! [1001] reference point for rotational acceleration
        REAL*4      EXREF          !        V25: if a value is present (length criteria)
      END TYPE CNODE_ACC
      INTEGER, PARAMETER :: LEN_CNODE_ACC=12
      INTEGER, PARAMETER :: VER_CNODE_ACC=200905

      TYPE CNODE_LA                ! 23/LC:+  prescribed nodal accelerations
        SEQUENCE
        INTEGER   NR               !        node-number
        INTEGER   TYP              !        type of load
        REAL*4      AX             ! [1003] acceleration X
        REAL*4      AY             ! [1003] acceleration Y
        REAL*4      AZ             ! [1003] acceleration Z
        REAL*4      ARX            ! [1004] Rotation X-X
        REAL*4      ARY            ! [1004] Rotation Y-Y
        REAL*4      ARZ            ! [1004] Rotation Z-Z
      END TYPE CNODE_LA
      INTEGER, PARAMETER :: LEN_CNODE_LA=8
      INTEGER, PARAMETER :: VER_CNODE_LA=200904

      TYPE CNODE_ROT               ! 23/LC:+  Rotation of Body
        SEQUENCE
        INTEGER   NR               !        influence reference
        INTEGER   TYP              !        type of load (=20)
        REAL*4      AXX            ! [1207] rotational acceleration X-X  (= vxx**2)
        REAL*4      AYY            ! [1207] rotational acceleration Y-Y  (= vyy**2)
        REAL*4      AZZ            ! [1207] rotational acceleration Z-Z  (= vzz**2)
        REAL*4      EX             ! [1001] reference point for rotational acceleration
        REAL*4      EY             ! [1001] reference point for rotational acceleration
        REAL*4      EZ             ! [1001] reference point for rotational acceleration
      END TYPE CNODE_ROT
      INTEGER, PARAMETER :: LEN_CNODE_ROT=8
      INTEGER, PARAMETER :: VER_CNODE_ROT=200607

      TYPE CN_DISPC                ! 24/LC:0  Max. Displacements and support forces
        SEQUENCE
        INTEGER   ID
        REAL*4      UX             ! [1003] displacement X
        REAL*4      UY             ! [1003] displacement Y
        REAL*4      UZ             ! [1003] displacement Z
        REAL*4      URX            ! [1004] rotation X
        REAL*4      URY            ! [1004] rotation Y
        REAL*4      URZ            ! [1004] rotation Z
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support X
        REAL*4      PY             ! [1151] nodal support Y
        REAL*4      PZ             ! [1151] nodal support Z
        REAL*4      MX             ! [1152] support moment X
        REAL*4      MY             ! [1152] support moment Y
        REAL*4      MZ             ! [1152] support moment Z
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISPC
      INTEGER, PARAMETER :: LEN_CN_DISPC=15
      INTEGER, PARAMETER :: VER_CN_DISPC=200501

      TYPE CN_DISPIC               ! 26/LC:0  Max. Displacement and forces increments
        SEQUENCE
        INTEGER   ID
        REAL*4      UX             ! [1003] displacement X
        REAL*4      UY             ! [1003] displacement Y
        REAL*4      UZ             ! [1003] displacement Z
        REAL*4      URX            ! [1004] rotation X
        REAL*4      URY            ! [1004] rotation Y
        REAL*4      URZ            ! [1004] rotation Z
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support X
        REAL*4      PY             ! [1151] nodal support Y
        REAL*4      PZ             ! [1151] nodal support Z
        REAL*4      MX             ! [1152] support moment X
        REAL*4      MY             ! [1152] support moment Y
        REAL*4      MZ             ! [1152] support moment Z
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISPIC
      INTEGER, PARAMETER :: LEN_CN_DISPIC=15
      INTEGER, PARAMETER :: VER_CN_DISPIC=200501

      TYPE CN_DISPTC               ! 27/LC:0  Max. Cooordinate offsets
        SEQUENCE
        INTEGER   ID
        REAL*4      UX             ! [1003] displacement X
        REAL*4      UY             ! [1003] displacement Y
        REAL*4      UZ             ! [1003] displacement Z
        REAL*4      URX            ! [1004] rotation X
        REAL*4      URY            ! [1004] rotation Y
        REAL*4      URZ            ! [1004] rotation Z
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support X
        REAL*4      PY             ! [1151] nodal support Y
        REAL*4      PZ             ! [1151] nodal support Z
        REAL*4      MX             ! [1152] support moment X
        REAL*4      MY             ! [1152] support moment Y
        REAL*4      MZ             ! [1152] support moment Z
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISPTC
      INTEGER, PARAMETER :: LEN_CN_DISPTC=15
      INTEGER, PARAMETER :: VER_CN_DISPTC=200702

      TYPE CN_DISP                 ! 24/LC:+  Displacements and support forces of nodes
        SEQUENCE
        INTEGER   NR               !        node-number
        REAL*4      UX             ! [1003] displacement
        REAL*4      UY             ! [1003] displacement
        REAL*4      UZ             ! [1003] displacement
        REAL*4      URX            ! [1004] rotation
        REAL*4      URY            ! [1004] rotation
        REAL*4      URZ            ! [1004] rotation
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support
        REAL*4      PY             ! [1151] nodal support
        REAL*4      PZ             ! [1151] nodal support
        REAL*4      MX             ! [1152] support moment
        REAL*4      MY             ! [1152] support moment
        REAL*4      MZ             ! [1152] support moment
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISP
      INTEGER, PARAMETER :: LEN_CN_DISP=15
      INTEGER, PARAMETER :: VER_CN_DISP=200501

      TYPE CN_DISPI                ! 26/LC:+  Displacement increments and residual forces
        SEQUENCE
        INTEGER   NR               !        node-number
        REAL*4      UX             ! [1003] displacement
        REAL*4      UY             ! [1003] displacement
        REAL*4      UZ             ! [1003] displacement
        REAL*4      URX            ! [1004] rotation
        REAL*4      URY            ! [1004] rotation
        REAL*4      URZ            ! [1004] rotation
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support
        REAL*4      PY             ! [1151] nodal support
        REAL*4      PZ             ! [1151] nodal support
        REAL*4      MX             ! [1152] support moment
        REAL*4      MY             ! [1152] support moment
        REAL*4      MZ             ! [1152] support moment
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISPI
      INTEGER, PARAMETER :: LEN_CN_DISPI=15
      INTEGER, PARAMETER :: VER_CN_DISPI=200501

      TYPE CN_DISPT                ! 27/LC:+  Cooordinate offsets
        SEQUENCE
        INTEGER   NR               !        node-number
        REAL*4      UX             ! [1003] displacement
        REAL*4      UY             ! [1003] displacement
        REAL*4      UZ             ! [1003] displacement
        REAL*4      URX            ! [1004] rotation
        REAL*4      URY            ! [1004] rotation
        REAL*4      URZ            ! [1004] rotation
        REAL*4      URB            ! [1005] twisting
        REAL*4      PX             ! [1151] nodal support
        REAL*4      PY             ! [1151] nodal support
        REAL*4      PZ             ! [1151] nodal support
        REAL*4      MX             ! [1152] support moment
        REAL*4      MY             ! [1152] support moment
        REAL*4      MZ             ! [1152] support moment
        REAL*4      MB             ! [1105] warping moment
      END TYPE CN_DISPT
      INTEGER, PARAMETER :: LEN_CN_DISPT=15
      INTEGER, PARAMETER :: VER_CN_DISPT=200702

      TYPE CN_VELOC                ! 25/LC:0  Max. velocities and accelerations of nodes
        SEQUENCE
        INTEGER   ID
        REAL*4      VX             ! [1201] velocity X
        REAL*4      VY             ! [1201] velocity Y
        REAL*4      VZ             ! [1201] velocity Z
        REAL*4      VRX            ! [1206] angular veloc. XX
        REAL*4      VRY            ! [1206] angular veloc. YY
        REAL*4      VRZ            ! [1206] angular veloc. ZZ
        REAL*4      VBB            ! [1208] twisting velocity
        REAL*4      AX             ! [1202] acceleration X
        REAL*4      AY             ! [1202] acceleration Y
        REAL*4      AZ             ! [1202] acceleration Z
        REAL*4      ARX            ! [1207] ang. acceler. XX
        REAL*4      ARY            ! [1207] ang. acceler. YY
        REAL*4      ARZ            ! [1207] ang. acceler. ZZ
        REAL*4      ABB            ! [1209] twisting acceler
      END TYPE CN_VELOC
      INTEGER, PARAMETER :: LEN_CN_VELOC=15
      INTEGER, PARAMETER :: VER_CN_VELOC=200501

      TYPE CN_VELO                 ! 25/LC:+  velocitys and acceleration of nodes
        SEQUENCE
        INTEGER   NR               !        node-number
        REAL*4      VX             ! [1201] velocity X
        REAL*4      VY             ! [1201] velocity Y
        REAL*4      VZ             ! [1201] velocity Z
        REAL*4      VRX            ! [1206] angular veloc. X-X
        REAL*4      VRY            ! [1206] angular veloc. Y-Y
        REAL*4      VRZ            ! [1206] angular veloc. Z-Z
        REAL*4      VBB            ! [1208] twisting velocity
        REAL*4      AX             ! [1202] acceleration X
        REAL*4      AY             ! [1202] acceleration Y
        REAL*4      AZ             ! [1202] acceleration Z
        REAL*4      ARX            ! [1207] ang. acceler. X-X
        REAL*4      ARY            ! [1207] ang. acceler. Y-Y
        REAL*4      ARZ            ! [1207] ang. acceler. Z-Z
        REAL*4      ABB            ! [1209] twisting acceler
      END TYPE CN_VELO
      INTEGER, PARAMETER :: LEN_CN_VELO=15
      INTEGER, PARAMETER :: VER_CN_VELO=200501

      TYPE CSGRP                   ! 37/ID:0  Secondary groups
        SEQUENCE
        INTEGER   ID0              !        identification of general data (0)
        INTEGER   TYP              !        Bit infos of selected element types
        INTEGER   BIT              !        Bit infos on selections contained in that group
        INTEGER   TEXT(17)         !        Designation of sgrp
      END TYPE CSGRP
      INTEGER, PARAMETER :: LEN_CSGRP=20
      INTEGER, PARAMETER :: VER_CSGRP=200903

      TYPE CSGRP_BOX               ! 37/ID:1  Selective Basic-Volume
        SEQUENCE
        INTEGER   ID               !        identification of data (1)
        INTEGER   TYP              !        type of property volume
        INTEGER   BIT              !        option
        REAL*4      PAR(3,0:6)     ! [1001] PARAMETERS OF BOX par(3,0:6)
      END TYPE CSGRP_BOX
      INTEGER, PARAMETER :: LEN_CSGRP_BOX=24
      INTEGER, PARAMETER :: VER_CSGRP_BOX=200903

      TYPE CSGRP_POL               ! 37/ID:2  Selective Polyeder-Volume
        SEQUENCE
        INTEGER   ID               !        identification of data (2)
        INTEGER   TYP              !        number of vertices
        INTEGER   BIT              !        option
        REAL*4      T(3,4)         !        transformation matrix to local coordinates
        REAL*4      EXT(3,0:2)     ! [1001] global extension, local extensions min/max
        REAL*4      VERT(3,63)     ! [1001] vertices in local coordinates r,s,t
      END TYPE CSGRP_POL
      INTEGER, PARAMETER :: LEN_CSGRP_POL=213
      INTEGER, PARAMETER :: VER_CSGRP_POL=200903

      TYPE CSGRP_LIS               ! 37/ID:0???  Calculated Selective Element List
        SEQUENCE
        INTEGER   ID               !        identifier of element to be selected (positive)
        INTEGER   NR(255)          !        element numbers
      END TYPE CSGRP_LIS
      INTEGER, PARAMETER :: LEN_CSGRP_LIS=256
      INTEGER, PARAMETER :: VER_CSGRP_LIS=200903

      TYPE CSGRP_ADD               ! 37/ID:1???  Selecting Element List
        SEQUENCE
        INTEGER   ID               !        identifier of element to be selected (positive)
        INTEGER   NR(255)          !        element numbers
      END TYPE CSGRP_ADD
      INTEGER, PARAMETER :: LEN_CSGRP_ADD=256
      INTEGER, PARAMETER :: VER_CSGRP_ADD=200903

      TYPE CSGRP_SUB               ! 37/ID:2???  Excluding Element List
        SEQUENCE
        INTEGER   ID               !        identifier of element to be selected (positive)
        INTEGER   NR(255)          !        element numbers
      END TYPE CSGRP_SUB
      INTEGER, PARAMETER :: LEN_CSGRP_SUB=256
      INTEGER, PARAMETER :: VER_CSGRP_SUB=200903

      TYPE CSGRP_SEL               ! 37/ID:3???  Property-Values
        SEQUENCE
        INTEGER   ID               !        identifier of element to be modified
        INTEGER   TYPE             !        Option to perform
        INTEGER   BIT              !        bit pattern of selected data
        INTEGER   ITP              !        key value for orientation of coordinate system
        INTEGER   DIV              !        key value of subdivision or other extended data
        INTEGER   IDQ              !        key value of cross section or other extended data
        INTEGER   IDH              !        key value of hinge conditions or other extended data
        INTEGER   IDX              !        key value of other extended data
        REAL*4      TROT           !        Fractional rotation about
        REAL*4      TAL(3)         !        Vector to be aligned as local axis
        REAL*4      RDAT(4)        !        reserved for values not in DATA
        INTEGER   DATA(64)         !        equivalenced data structure of that
      END TYPE CSGRP_SEL
      INTEGER, PARAMETER :: LEN_CSGRP_SEL=80
      INTEGER, PARAMETER :: VER_CSGRP_SEL=200903

      TYPE CBEAM                   ! 100/00:+  Beams
        SEQUENCE
        INTEGER   NR               !        beam number
        INTEGER   NODE(2)          !        node number start/end
        INTEGER   NP               !        prop number
        REAL*4      DL             ! [1001] beamlength
        REAL*4      T(3,3)         !        transformation matrix
        REAL*4      EX(3,2)        ! [1001] 
        INTEGER   NREF             !        reference axis
        REAL*4      SPAR(2)        !        distances along a continuous beam or
        REAL*4      BETY
        REAL*4      BETZ
        REAL*4      LDFY
        REAL*4      LDFZ           !        deformation length factor for vz
      END TYPE CBEAM
      INTEGER, PARAMETER :: LEN_CBEAM=27
      INTEGER, PARAMETER :: VER_CBEAM=200502

      TYPE CBSLN                   ! 120/00:+  Design elements
        SEQUENCE
        INTEGER   NR               !        beam number
        INTEGER   NODE(2)          !        node number start/end
        INTEGER   NP               !        prop number
        REAL*4      DL             ! [1001] beamlength
        REAL*4      T(3,3)         !        transformation matrix
        REAL*4      EX(3,2)        ! [1001] 
        INTEGER   NREF             !        reference axis
        REAL*4      SPAR(2)        !        distances along a continuous beam or
        REAL*4      BETY
        REAL*4      BETZ
        REAL*4      LDFY
        REAL*4      LDFZ           !        deformation length factor for vz
      END TYPE CBSLN
      INTEGER, PARAMETER :: LEN_CBSLN=27
      INTEGER, PARAMETER :: VER_CBSLN=201606

      TYPE CBSCT                   ! 140/00:+  External sections
        SEQUENCE
        INTEGER   NR               !        beam number
        INTEGER   NODE(2)          !        node number start/end
        INTEGER   NP               !        prop number
        REAL*4      DL             ! [1001] beamlength
        REAL*4      T(3,3)         !        transformation matrix
        REAL*4      EX(3,2)        ! [1001] 
        INTEGER   NREF             !        reference axis
        REAL*4      SPAR(2)        !        distances along a continuous beam or
        REAL*4      BETY
        REAL*4      BETZ
        REAL*4      LDFY
        REAL*4      LDFZ           !        deformation length factor for vz
      END TYPE CBSCT
      INTEGER, PARAMETER :: LEN_CBSCT=27
      INTEGER, PARAMETER :: VER_CBSCT=200501

      TYPE CBEAM_SCT               ! 100/00:0  Beams sections
        SEQUENCE
        INTEGER   ID               !        identifier for sections 0
        INTEGER   NQ               !        number cross section
        INTEGER   ITYP             !        Bitcodes
        INTEGER   ITP2             !        Connection / Hinges for x=0,x=dl
        REAL*4      X              ! [1001] sectional abscissa
      END TYPE CBEAM_SCT
      INTEGER, PARAMETER :: LEN_CBEAM_SCT=5
      INTEGER, PARAMETER :: VER_CBEAM_SCT=200502

      TYPE CBSLN_SCT               ! 120/00:0  Design element sections
        SEQUENCE
        INTEGER   ID               !        identifier for sections 0
        INTEGER   NQ               !        number cross section
        INTEGER   ITYP             !        Bitcode I   (identical to 100/0:0)
        INTEGER   ITP2             !        Bitcode II  (identical to 100/0:0)
        REAL*4      X              ! [1001] sectional abscissa
        REAL*4      T(3,4)         !        transformation matrix
        REAL*4      YMIN           ! [1001] Box of active elements in cut plane
        REAL*4      ZMIN           ! [1001] Box of active elements in cut plane
        REAL*4      YMAX           ! [1001] Box of active elements in cut plane
        REAL*4      ZMAX           ! [1001] Box of active elements in cut plane
        REAL*4      XMIN           ! [1001] Box of active elements in cut plane
        REAL*4      XMAX           ! [1001] Box of active elements in cut plane
        REAL*4      YMINSEL        ! [1001] Max user defined size of Box
        REAL*4      ZMINSEL        ! [1001] Max user defined size of Box
        REAL*4      YMAXSEL        ! [1001] Max user defined size of Box
        REAL*4      ZMAXSEL        ! [1001] Max user defined size of Box
        REAL*4      YSC            ! [1001] Coordinate y of shear centre
        REAL*4      ZSC            ! [1001] Coordinate z of shear centre
      END TYPE CBSLN_SCT
      INTEGER, PARAMETER :: LEN_CBSLN_SCT=29
      INTEGER, PARAMETER :: VER_CBSLN_SCT=201606

      TYPE CBSCT_SCT               ! 140/00:0  External sections
        SEQUENCE
        INTEGER   ID               !        identifier for sections 0
        INTEGER   NQ               !        number cross section
        INTEGER   ITYP             !        Bitcode I   (identical to 100/0:0)
        INTEGER   ITP2             !        Bitcode II  (identical to 100/0:0)
        REAL*4      X              ! [1001] sectional abscissa
        REAL*4      T(3,4)         !        transformation matrix
        REAL*4      YMIN           ! [1001] Box of active elements in cut plane
        REAL*4      ZMIN           ! [1001] Box of active elements in cut plane
        REAL*4      YMAX           ! [1001] Box of active elements in cut plane
        REAL*4      ZMAX           ! [1001] Box of active elements in cut plane
        REAL*4      XMIN           ! [1001] Box of active elements in cut plane
        REAL*4      XMAX           ! [1001] Box of active elements in cut plane
        REAL*4      YMINSEL        ! [1001] Max user defined size of Box
        REAL*4      ZMINSEL        ! [1001] Max user defined size of Box
        REAL*4      YMAXSEL        ! [1001] Max user defined size of Box
        REAL*4      ZMAXSEL        ! [1001] Max user defined size of Box
        REAL*4      YSC            ! [1001] Coordinate y of shear centre
        REAL*4      ZSC            ! [1001] Coordinate z of shear centre
      END TYPE CBSCT_SCT
      INTEGER, PARAMETER :: LEN_CBSCT_SCT=29
      INTEGER, PARAMETER :: VER_CBSCT_SCT=200501

      TYPE CBEAM_TRA               ! 100/01  transformation matrix
        SEQUENCE
        INTEGER   NR               !        beamnumber
        REAL*4      DL             ! [1001] beamlength
        REAL*4      T(3,3)         !        transformation matrix
      END TYPE CBEAM_TRA
      INTEGER, PARAMETER :: LEN_CBEAM_TRA=11
      INTEGER, PARAMETER :: VER_CBEAM_TRA=200501

      TYPE CBEAM_TRS               ! 100/03  Info about dynamic moving beams (TREX)
        SEQUENCE
        INTEGER   LF               !        Loadcase number containing the train
        INTEGER   NR               !        Number of Beam
        INTEGER   BPAT             !        Options for BEAM (see TREX in SOFILOAD)
        INTEGER   NODA(0:3)        !        Node Numbers for Start of beam element
        INTEGER   NODE(0:3)        !        Node Numbers for end of beam element
        REAL*4      XN(2)          ! [1001] x-values of nodes along load train
      END TYPE CBEAM_TRS
      INTEGER, PARAMETER :: LEN_CBEAM_TRS=13
      INTEGER, PARAMETER :: VER_CBEAM_TRS=200501

      TYPE CBEAM_TND               ! 100/05  tendons of beams
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        tendon number
        INTEGER   MNR              !        material number of tendon + 1000 * material number of cross-sec
        INTEGER   IBA1             !        construction stage number for placing
        INTEGER   IBA2             !        construction stage number for grouting
        INTEGER   IBA3             !        construction stage number for removing
        REAL*4      X              ! [1011] x-ordinate
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      ZZ             ! [1101] tensoning force
        REAL*4      AZ             ! [1020] tendon area
        REAL*4      D              ! [1023] diameter
        REAL*4      UZ             ! [1023] effect. periphery
        REAL*4      NY             !        inclination DY/DX
        REAL*4      NZ             !        inclination DZ/DX
        REAL*4      YHR            ! [1011] y-ordinate duct
        REAL*4      ZHR            ! [1011] z-ordinate duct
        REAL*4      AHR            ! [1020] area of duct
        REAL*4      AR             ! [1012] reference area
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      REDFAK         !        Reduction factor within transmission length
        REAL*4      XSI            !        Relative ordinate within total tendon
      END TYPE CBEAM_TND
      INTEGER, PARAMETER :: LEN_CBEAM_TND=22
      INTEGER, PARAMETER :: VER_CBEAM_TND=200501

      TYPE CBSLN_TND               ! 120/05  tendons of structural beam lines
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        tendon number
        INTEGER   MNR              !        material number of tendon + 1000 * material number of cross-sec
        INTEGER   IBA1             !        construction stage number for placing
        INTEGER   IBA2             !        construction stage number for grouting
        INTEGER   IBA3             !        construction stage number for removing
        REAL*4      X              ! [1011] x-ordinate
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      ZZ             ! [1101] tensoning force
        REAL*4      AZ             ! [1020] tendon area
        REAL*4      D              ! [1023] diameter
        REAL*4      UZ             ! [1023] effect. periphery
        REAL*4      NY             !        inclination DY/DX
        REAL*4      NZ             !        inclination DZ/DX
        REAL*4      YHR            ! [1011] y-ordinate duct
        REAL*4      ZHR            ! [1011] z-ordinate duct
        REAL*4      AHR            ! [1020] area of duct
        REAL*4      AR             ! [1012] reference area
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      REDFAK         !        Reduction factor within transmission length
        REAL*4      XSI            !        Relative ordinate within total tendon
      END TYPE CBSLN_TND
      INTEGER, PARAMETER :: LEN_CBSLN_TND=22
      INTEGER, PARAMETER :: VER_CBSLN_TND=201606

      TYPE CBSCT_TND               ! 140/05  tendons of external sections
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        tendon number
        INTEGER   MNR              !        material number of tendon + 1000 * material number of cross-sec
        INTEGER   IBA1             !        construction stage number for placing
        INTEGER   IBA2             !        construction stage number for grouting
        INTEGER   IBA3             !        construction stage number for removing
        REAL*4      X              ! [1011] x-ordinate
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      ZZ             ! [1101] tensoning force
        REAL*4      AZ             ! [1020] tendon area
        REAL*4      D              ! [1023] diameter
        REAL*4      UZ             ! [1023] effect. periphery
        REAL*4      NY             !        inclination DY/DX
        REAL*4      NZ             !        inclination DZ/DX
        REAL*4      YHR            ! [1011] y-ordinate duct
        REAL*4      ZHR            ! [1011] z-ordinate duct
        REAL*4      AHR            ! [1020] area of duct
        REAL*4      AR             ! [1012] reference area
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      REDFAK         !        Reduction factor within transmission length
        REAL*4      XSI            !        Relative ordinate within total tendon
      END TYPE CBSCT_TND
      INTEGER, PARAMETER :: LEN_CBSCT_TND=22
      INTEGER, PARAMETER :: VER_CBSCT_TND=200501

      TYPE CBEAM_SL                ! 101/LC:*  single beam loads
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      X              ! [1001] load point
        REAL*4      I_2            ! [1001] reserved 0.
        REAL*4      PA             !        value of load
        REAL*4      I_4            !        reserved 0.
        REAL*4      YA             ! [1001] eccentr. local y
        REAL*4      ZA             ! [1001] eccentr. local z
      END TYPE CBEAM_SL
      INTEGER, PARAMETER :: LEN_CBEAM_SL=8
      INTEGER, PARAMETER :: VER_CBEAM_SL=200501

      TYPE CBEAM_DL                ! 101/LC:*  distributed beam loading on reference
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      X              ! [1001] start point
        REAL*4      L              ! [1001] length of load
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
        REAL*4      YA             ! [1001] eccentr. local y A
        REAL*4      ZA             ! [1001] eccentr. local z A
        REAL*4      YE             ! [1001] eccentr. local y E
        REAL*4      ZE             ! [1001] eccentr. local z E
        REAL*4      DYA            !        gradient of eccentricity, local y, start
        REAL*4      DZA            !        gradient of eccentricity, local z, start
        REAL*4      DYE            !        gradient of eccentricity, local y, end
        REAL*4      DZE            !        gradient of eccentricity, local z, end
      END TYPE CBEAM_DL
      INTEGER, PARAMETER :: LEN_CBEAM_DL=14
      INTEGER, PARAMETER :: VER_CBEAM_DL=200501

      TYPE CBEAM_TL                ! 101/LC:*  distributed beam loading on reference
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      X              ! [1001] start point
        REAL*4      L              ! [1001] length of load
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
        REAL*4      YA             ! [1001] eccentr. local y A
        REAL*4      ZA             ! [1001] eccentr. local z A
        REAL*4      YE             ! [1001] eccentr. local y E
        REAL*4      ZE             ! [1001] eccentr. local z E
        REAL*4      DYA            !        gradient of eccentricity, local y, start
        REAL*4      DZA            !        gradient of eccentricity, local z, start
        REAL*4      DYE            !        gradient of eccentricity, local y, end
        REAL*4      DZE            !        gradient of eccentricity, local z, end
      END TYPE CBEAM_TL
      INTEGER, PARAMETER :: LEN_CBEAM_TL=14
      INTEGER, PARAMETER :: VER_CBEAM_TL=200501

      TYPE CBEAM_CL                ! 101/LC:*  cubic beamloads
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      X              ! [1001] start point
        REAL*4      L              ! [1001] length of load
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
        REAL*4      DPA            !        start derivative
        REAL*4      DPE            !        end   derivative
      END TYPE CBEAM_CL
      INTEGER, PARAMETER :: LEN_CBEAM_CL=8
      INTEGER, PARAMETER :: VER_CBEAM_CL=200501

      TYPE CBEAM_WL                ! 101/LC:*  dynamic wind loads
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      FA             !        Factor cross start
        REAL*4      FE             !        Factor cross end
        REAL*4      FT             !        Factor frictional
        REAL*4      VXA            ! [1201] wind velocity
        REAL*4      VYA            ! [1201] wind velocity
        REAL*4      VZA            ! [1201] wind velocity
        REAL*4      VXE            ! [1201] wind velocity
        REAL*4      VYE            ! [1201] wind velocity
        REAL*4      VZE            ! [1201] wind velocity
        REAL*4      VXAM           ! [1201] mean wind velocity
        REAL*4      VYAM           ! [1201] mean wind velocity
        REAL*4      VZAM           ! [1201] mean wind velocity
        REAL*4      VXEM           ! [1201] mean wind velocity
        REAL*4      VYEM           ! [1201] mean wind velocity
        REAL*4      VZEM           ! [1201] mean wind velocity
      END TYPE CBEAM_WL
      INTEGER, PARAMETER :: LEN_CBEAM_WL=17
      INTEGER, PARAMETER :: VER_CBEAM_WL=200501

      TYPE CTRUS_WL                ! 151/LC:*  dynamic wind loads
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      FA             !        Factor cross start
        REAL*4      FE             !        Factor cross end
        REAL*4      FT             !        Factor frictional
        REAL*4      VXA            ! [1201] wind velocity
        REAL*4      VYA            ! [1201] wind velocity
        REAL*4      VZA            ! [1201] wind velocity
        REAL*4      VXE            ! [1201] wind velocity
        REAL*4      VYE            ! [1201] wind velocity
        REAL*4      VZE            ! [1201] wind velocity
        REAL*4      VXAM           ! [1201] mean wind velocity
        REAL*4      VYAM           ! [1201] mean wind velocity
        REAL*4      VZAM           ! [1201] mean wind velocity
        REAL*4      VXEM           ! [1201] mean wind velocity
        REAL*4      VYEM           ! [1201] mean wind velocity
        REAL*4      VZEM           ! [1201] mean wind velocity
      END TYPE CTRUS_WL
      INTEGER, PARAMETER :: LEN_CTRUS_WL=17
      INTEGER, PARAMETER :: VER_CTRUS_WL=200501

      TYPE CCABL_WL                ! 161/LC:*  dynamic wind loads
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of load
        REAL*4      FA             !        Factor cross start
        REAL*4      FE             !        Factor cross end
        REAL*4      FT             !        Factor frictional
        REAL*4      VXA            ! [1201] wind velocity
        REAL*4      VYA            ! [1201] wind velocity
        REAL*4      VZA            ! [1201] wind velocity
        REAL*4      VXE            ! [1201] wind velocity
        REAL*4      VYE            ! [1201] wind velocity
        REAL*4      VZE            ! [1201] wind velocity
        REAL*4      VXAM           ! [1201] mean wind velocity
        REAL*4      VYAM           ! [1201] mean wind velocity
        REAL*4      VZAM           ! [1201] mean wind velocity
        REAL*4      VXEM           ! [1201] mean wind velocity
        REAL*4      VYEM           ! [1201] mean wind velocity
        REAL*4      VZEM           ! [1201] mean wind velocity
      END TYPE CCABL_WL
      INTEGER, PARAMETER :: LEN_CCABL_WL=17
      INTEGER, PARAMETER :: VER_CCABL_WL=200501

      TYPE CBEAM_FOC               ! 102/LC:0  Maximum of Total Beam forces and deformations
        SEQUENCE
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] max. beam length
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsionalmom.
        REAL*4      UX             ! [1003] diplacem. local x
        REAL*4      UY             ! [1003] diplacem. local y
        REAL*4      UZ             ! [1003] diplacem. local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
      END TYPE CBEAM_FOC
      INTEGER, PARAMETER :: LEN_CBEAM_FOC=22
      INTEGER, PARAMETER :: VER_CBEAM_FOC=200803

      TYPE CBEAM_FTC               ! 112/LC:0  Maximum of Beam forces without plate components
        SEQUENCE
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] max. beam length
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsionalmom.
        REAL*4      UX             ! [1003] diplacem. local x
        REAL*4      UY             ! [1003] diplacem. local y
        REAL*4      UZ             ! [1003] diplacem. local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
      END TYPE CBEAM_FTC
      INTEGER, PARAMETER :: LEN_CBEAM_FTC=22
      INTEGER, PARAMETER :: VER_CBEAM_FTC=200803

      TYPE CBSLN_FTC               ! 122/LC:0  Maximum of Beam forces without plate components
        SEQUENCE
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] max. beam length
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsionalmom.
        REAL*4      UX             ! [1003] diplacem. local x
        REAL*4      UY             ! [1003] diplacem. local y
        REAL*4      UZ             ! [1003] diplacem. local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
      END TYPE CBSLN_FTC
      INTEGER, PARAMETER :: LEN_CBSLN_FTC=22
      INTEGER, PARAMETER :: VER_CBSLN_FTC=201606

      TYPE CBSCT_FOC               ! 142/LC:0  Maximum of External sections forces
        SEQUENCE
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] max. beam length
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsionalmom.
        REAL*4      UX             ! [1003] diplacem. local x
        REAL*4      UY             ! [1003] diplacem. local y
        REAL*4      UZ             ! [1003] diplacem. local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
      END TYPE CBSCT_FOC
      INTEGER, PARAMETER :: LEN_CBSCT_FOC=22
      INTEGER, PARAMETER :: VER_CBSCT_FOC=200803

      TYPE CBEAM_FOR               ! 102/LC:+  Total Beam forces and deformations
        SEQUENCE
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsional moment
        REAL*4      UX             ! [1003] diplacement local x
        REAL*4      UY             ! [1003] diplacement local y
        REAL*4      UZ             ! [1003] diplacement local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
        REAL*4      Q1             !        quaternion component q1
        REAL*4      Q2             !        quaternion component q2
        REAL*4      Q3             !        quaternion component q3
        REAL*4      Q0             !        quaternion component q0
        REAL*4      UXX            ! [1003] translation in global X
        REAL*4      UYY            ! [1003] translation in global Y
        REAL*4      UZZ            ! [1003] translation in global Z
      END TYPE CBEAM_FOR
      INTEGER, PARAMETER :: LEN_CBEAM_FOR=29
      INTEGER, PARAMETER :: VER_CBEAM_FOR=201109

      TYPE CBEAM_FTR               ! 112/LC:+  Beam forces without plate components
        SEQUENCE
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsional moment
        REAL*4      UX             ! [1003] diplacement local x
        REAL*4      UY             ! [1003] diplacement local y
        REAL*4      UZ             ! [1003] diplacement local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
        REAL*4      Q1             !        quaternion component q1
        REAL*4      Q2             !        quaternion component q2
        REAL*4      Q3             !        quaternion component q3
        REAL*4      Q0             !        quaternion component q0
        REAL*4      UXX            ! [1003] translation in global X
        REAL*4      UYY            ! [1003] translation in global Y
        REAL*4      UZZ            ! [1003] translation in global Z
      END TYPE CBEAM_FTR
      INTEGER, PARAMETER :: LEN_CBEAM_FTR=29
      INTEGER, PARAMETER :: VER_CBEAM_FTR=201109

      TYPE CBSLN_FTR               ! 122/LC:+  Beam forces without plate components
        SEQUENCE
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsional moment
        REAL*4      UX             ! [1003] diplacement local x
        REAL*4      UY             ! [1003] diplacement local y
        REAL*4      UZ             ! [1003] diplacement local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
        REAL*4      Q1             !        quaternion component q1
        REAL*4      Q2             !        quaternion component q2
        REAL*4      Q3             !        quaternion component q3
        REAL*4      Q0             !        quaternion component q0
        REAL*4      UXX            ! [1003] translation in global X
        REAL*4      UYY            ! [1003] translation in global Y
        REAL*4      UZZ            ! [1003] translation in global Z
      END TYPE CBSLN_FTR
      INTEGER, PARAMETER :: LEN_CBSLN_FTR=29
      INTEGER, PARAMETER :: VER_CBSLN_FTR=201606

      TYPE CBSCT_FOR               ! 142/LC:+  External sections forces
        SEQUENCE
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsional moment
        REAL*4      UX             ! [1003] diplacement local x
        REAL*4      UY             ! [1003] diplacement local y
        REAL*4      UZ             ! [1003] diplacement local z
        REAL*4      PHIX           ! [1004] rotation local x
        REAL*4      PHIY           ! [1004] rotation local y
        REAL*4      PHIZ           ! [1004] rotation local z
        REAL*4      PHIW           ! [1005] twisting
        REAL*4      MT3            ! [1103] 3rd torsionalmom
        REAL*4      PA             ! [1095] axial bedding
        REAL*4      PT             ! [1095] transverse bedding
        REAL*4      PTY            ! [1095] local y component of transverse bedding
        REAL*4      PTZ            ! [1095] local z component of transverse bedding
        REAL*4      Q1             !        quaternion component q1
        REAL*4      Q2             !        quaternion component q2
        REAL*4      Q3             !        quaternion component q3
        REAL*4      Q0             !        quaternion component q0
        REAL*4      UXX            ! [1003] translation in global X
        REAL*4      UYY            ! [1003] translation in global Y
        REAL*4      UZZ            ! [1003] translation in global Z
      END TYPE CBSCT_FOR
      INTEGER, PARAMETER :: LEN_CBSCT_FOR=29
      INTEGER, PARAMETER :: VER_CBSCT_FOR=201109

      TYPE CBEAM_FOX               ! 102/0  Total External Beam forces
        SEQUENCE
        INTEGER   NQ               !        section number
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] abscissa
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsion.moment
      END TYPE CBEAM_FOX
      INTEGER, PARAMETER :: LEN_CBEAM_FOX=11
      INTEGER, PARAMETER :: VER_CBEAM_FOX=200501

      TYPE CBSCT_FOX               ! 142/0  Total External Forces for external sections
        SEQUENCE
        INTEGER   NQ               !        section number
        INTEGER   NR               !        beamnumber
        REAL*4      X              ! [1001] abscissa
        REAL*4      N              ! [1101] normal force
        REAL*4      VY             ! [1102] y-shear force
        REAL*4      VZ             ! [1102] z-shear force
        REAL*4      MT             ! [1103] torsional moment
        REAL*4      MY             ! [1104] bending moment My
        REAL*4      MZ             ! [1104] bending moment Mz
        REAL*4      MB             ! [1105] warping moment Mb
        REAL*4      MT2            ! [1103] 2nd torsion.moment
      END TYPE CBSCT_FOX
      INTEGER, PARAMETER :: LEN_CBSCT_FOX=11
      INTEGER, PARAMETER :: VER_CBSCT_FOX=200501

      TYPE CBEAM_STI               ! 103/LC  Stiffness of beams
        SEQUENCE
        INTEGER   NR               !        beam number
        REAL*4      X              ! [1001] distance from start
        REAL*4      EA             ! [  62] normal stiffness
        REAL*4      GAY            ! [  62] y-shear stiffness
        REAL*4      GAZ            ! [  62] z-shear stiffness
        REAL*4      GIT            ! [  83] torsional stiffness
        REAL*4      EIY            ! [  83] bending stiffness y
        REAL*4      EIZ            ! [  83] bending stiffness z
        REAL*4      EIYZ           ! [  83] bending stiffness yz
        REAL*4      GAYZ           ! [  62] yz-shear stiffness
        REAL*4      KPX            ! [   8] plastic strain x
        REAL*4      KPY            ! [  17] plastic curvature y
        REAL*4      KPZ            ! [  17] plastic curvature z
        REAL*4      EMIN           ! [1081] minimum strain
        REAL*4      EMAX           ! [1081] maximum strain
        REAL*4      GE1            ! [1101] Residual of current step (Crisfield)
        REAL*4      GE2            ! [1104] Residual of current step (Crisfield)
        REAL*4      GE3            ! [1104] Residual of current step (Crisfield)
        REAL*4      EA0            ! [  83] lin. stiffness EA
        REAL*4      EIY0           ! [  83] lin. stiffness EIy
        REAL*4      EIZ0           ! [  83] lin. stiffness EIz
        REAL*4      DYSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      DZSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      PRE            ! [1101] primary axial force
        REAL*4      YS             ! [1001] y-eccentricity of centre of gravity
        REAL*4      ZS             ! [1001] z-eccentricity of centre of gravity
        REAL*4      ECM            !        warping stiffness
        REAL*4      GCMS           !        secondary torsion
        REAL*4      NI             ! [1101] inner normal force
        REAL*4      VYI            ! [1102] inner y-shear force
        REAL*4      VZI            ! [1102] inner z-shear force
        REAL*4      MTI            ! [1103] inner torsional moment
        REAL*4      MYI            ! [1104] inner bending moment My
        REAL*4      MZI            ! [1104] inner bending moment Mz
        REAL*4      MBI            ! [1105] inner warping moment Mb
        REAL*4      E0             ! [1081] total strain x
        REAL*4      GKPY           ! [  17] total curvature y
        REAL*4      GKPZ           ! [  17] total curvature z
        REAL*4      KFVY           !        plastic factor V-y
        REAL*4      KFVZ           !        plastic factor V-z
        REAL*4      KFMT           !        plastic factor M-t
        REAL*4      DE_0(7)        !        Crisfield increments of current step di
        REAL*4      DE_1(7)        !        Crisfield increments of last step di-1
        REAL*4      I_54           !        unused
        REAL*4      ERF_MIN        ! [1081] minimum strain reinf.
        REAL*4      ERF_MAX        ! [1081] maximum strain reinf.
        REAL*4      HC             ! [   8] relative compressive zone height
        REAL*4      CCW            ! [1026] current crack opening
        REAL*4      I_59(11)       !        unused
      END TYPE CBEAM_STI
      INTEGER, PARAMETER :: LEN_CBEAM_STI=71
      INTEGER, PARAMETER :: VER_CBEAM_STI=200501

      TYPE CBSLN_STI               ! 123/LC  Stiffness of beams
        SEQUENCE
        INTEGER   NR               !        beam number
        REAL*4      X              ! [1001] distance from start
        REAL*4      EA             ! [  62] normal stiffness
        REAL*4      GAY            ! [  62] y-shear stiffness
        REAL*4      GAZ            ! [  62] z-shear stiffness
        REAL*4      GIT            ! [  83] torsional stiffness
        REAL*4      EIY            ! [  83] bending stiffness y
        REAL*4      EIZ            ! [  83] bending stiffness z
        REAL*4      EIYZ           ! [  83] bending stiffness yz
        REAL*4      GAYZ           ! [  62] yz-shear stiffness
        REAL*4      KPX            ! [   8] plastic strain x
        REAL*4      KPY            ! [  17] plastic curvature y
        REAL*4      KPZ            ! [  17] plastic curvature z
        REAL*4      EMIN           ! [1081] minimum strain
        REAL*4      EMAX           ! [1081] maximum strain
        REAL*4      GE1            ! [1101] Residual of current step (Crisfield)
        REAL*4      GE2            ! [1104] Residual of current step (Crisfield)
        REAL*4      GE3            ! [1104] Residual of current step (Crisfield)
        REAL*4      EA0            ! [  83] lin. stiffness EA
        REAL*4      EIY0           ! [  83] lin. stiffness EIy
        REAL*4      EIZ0           ! [  83] lin. stiffness EIz
        REAL*4      DYSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      DZSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      PRE            ! [1101] primary axial force
        REAL*4      YS             ! [1001] y-eccentricity of centre of gravity
        REAL*4      ZS             ! [1001] z-eccentricity of centre of gravity
        REAL*4      ECM            !        warping stiffness
        REAL*4      GCMS           !        secondary torsion
        REAL*4      NI             ! [1101] inner normal force
        REAL*4      VYI            ! [1102] inner y-shear force
        REAL*4      VZI            ! [1102] inner z-shear force
        REAL*4      MTI            ! [1103] inner torsional moment
        REAL*4      MYI            ! [1104] inner bending moment My
        REAL*4      MZI            ! [1104] inner bending moment Mz
        REAL*4      MBI            ! [1105] inner warping moment Mb
        REAL*4      E0             ! [1081] total strain x
        REAL*4      GKPY           ! [  17] total curvature y
        REAL*4      GKPZ           ! [  17] total curvature z
        REAL*4      KFVY           !        plastic factor V-y
        REAL*4      KFVZ           !        plastic factor V-z
        REAL*4      KFMT           !        plastic factor M-t
        REAL*4      DE_0(7)        !        Crisfield increments of current step di
        REAL*4      DE_1(7)        !        Crisfield increments of last step di-1
        REAL*4      I_54           !        unused
        REAL*4      ERF_MIN        ! [1081] minimum strain reinf.
        REAL*4      ERF_MAX        ! [1081] maximum strain reinf.
        REAL*4      HC             ! [   8] relative compressive zone height
        REAL*4      CCW            ! [1026] current crack opening
        REAL*4      I_59(11)       !        unused
      END TYPE CBSLN_STI
      INTEGER, PARAMETER :: LEN_CBSLN_STI=71
      INTEGER, PARAMETER :: VER_CBSLN_STI=201606

      TYPE CBSCT_STI               ! 143/LC  Stiffness of beams
        SEQUENCE
        INTEGER   NR               !        beam number
        REAL*4      X              ! [1001] distance from start
        REAL*4      EA             ! [  62] normal stiffness
        REAL*4      GAY            ! [  62] y-shear stiffness
        REAL*4      GAZ            ! [  62] z-shear stiffness
        REAL*4      GIT            ! [  83] torsional stiffness
        REAL*4      EIY            ! [  83] bending stiffness y
        REAL*4      EIZ            ! [  83] bending stiffness z
        REAL*4      EIYZ           ! [  83] bending stiffness yz
        REAL*4      GAYZ           ! [  62] yz-shear stiffness
        REAL*4      KPX            ! [   8] plastic strain x
        REAL*4      KPY            ! [  17] plastic curvature y
        REAL*4      KPZ            ! [  17] plastic curvature z
        REAL*4      EMIN           ! [1081] minimum strain
        REAL*4      EMAX           ! [1081] maximum strain
        REAL*4      GE1            ! [1101] Residual of current step (Crisfield)
        REAL*4      GE2            ! [1104] Residual of current step (Crisfield)
        REAL*4      GE3            ! [1104] Residual of current step (Crisfield)
        REAL*4      EA0            ! [  83] lin. stiffness EA
        REAL*4      EIY0           ! [  83] lin. stiffness EIy
        REAL*4      EIZ0           ! [  83] lin. stiffness EIz
        REAL*4      DYSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      DZSM           ! [1011] ordinate shear centre to gravity centre
        REAL*4      PRE            ! [1101] primary axial force
        REAL*4      YS             ! [1001] y-eccentricity of centre of gravity
        REAL*4      ZS             ! [1001] z-eccentricity of centre of gravity
        REAL*4      ECM            !        warping stiffness
        REAL*4      GCMS           !        secondary torsion
        REAL*4      NI             ! [1101] inner normal force
        REAL*4      VYI            ! [1102] inner y-shear force
        REAL*4      VZI            ! [1102] inner z-shear force
        REAL*4      MTI            ! [1103] inner torsional moment
        REAL*4      MYI            ! [1104] inner bending moment My
        REAL*4      MZI            ! [1104] inner bending moment Mz
        REAL*4      MBI            ! [1105] inner warping moment Mb
        REAL*4      E0             ! [1081] total strain x
        REAL*4      GKPY           ! [  17] total curvature y
        REAL*4      GKPZ           ! [  17] total curvature z
        REAL*4      KFVY           !        plastic factor V-y
        REAL*4      KFVZ           !        plastic factor V-z
        REAL*4      KFMT           !        plastic factor M-t
        REAL*4      DE_0(7)        !        Crisfield increments of current step di
        REAL*4      DE_1(7)        !        Crisfield increments of last step di-1
        REAL*4      I_54           !        unused
        REAL*4      ERF_MIN        ! [1081] minimum strain reinf.
        REAL*4      ERF_MAX        ! [1081] maximum strain reinf.
        REAL*4      HC             ! [   8] relative compressive zone height
        REAL*4      CCW            ! [1026] current crack opening
        REAL*4      I_59(11)       !        unused
      END TYPE CBSCT_STI
      INTEGER, PARAMETER :: LEN_CBSCT_STI=71
      INTEGER, PARAMETER :: VER_CBSCT_STI=200501

      TYPE CBEAM_CRC               ! 104/LC:0  Parameter of creep interval for each material
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   MNR              !        materialnumber
        INTEGER   EXP              !        exposition class of explicit curve
        REAL*4      T              ! [  93] absolute age
        REAL*4      PHI            !        creep coefficient
        REAL*4      EPS            !        shrinkage
        REAL*4      RH             ! [   8] relative moisture
        REAL*4      TEMP           ! [   6] temperature
        REAL*4      TWA            ! [  93] effective age start
        REAL*4      TWE            ! [  93] effective age end
        REAL*4      BETH           !        creep coefficient beta-h
        REAL*4      TS             ! [  93] start date of drying
        REAL*4      TC             ! [  93] start date of loading
      END TYPE CBEAM_CRC
      INTEGER, PARAMETER :: LEN_CBEAM_CRC=13
      INTEGER, PARAMETER :: VER_CBEAM_CRC=200701

      TYPE CBSLN_CRC               ! 124/LC:0  Parameter of creep interval for each material
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   MNR              !        materialnumber
        INTEGER   EXP              !        exposition class of explicit curve
        REAL*4      T              ! [  93] absolute age
        REAL*4      PHI            !        creep coefficient
        REAL*4      EPS            !        shrinkage
        REAL*4      RH             ! [   8] relative moisture
        REAL*4      TEMP           ! [   6] temperature
        REAL*4      TWA            ! [  93] effective age start
        REAL*4      TWE            ! [  93] effective age end
        REAL*4      BETH           !        creep coefficient beta-h
        REAL*4      TS             ! [  93] start date of drying
        REAL*4      TC             ! [  93] start date of loading
      END TYPE CBSLN_CRC
      INTEGER, PARAMETER :: LEN_CBSLN_CRC=13
      INTEGER, PARAMETER :: VER_CBSLN_CRC=201606

      TYPE CBSCT_CRC               ! 144/LC:0  Parameter of creep interval for each material
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   MNR              !        materialnumber
        INTEGER   EXP              !        exposition class of explicit curve
        REAL*4      T              ! [  93] absolute age
        REAL*4      PHI            !        creep coefficient
        REAL*4      EPS            !        shrinkage
        REAL*4      RH             ! [   8] relative moisture
        REAL*4      TEMP           ! [   6] temperature
        REAL*4      TWA            ! [  93] effective age start
        REAL*4      TWE            ! [  93] effective age end
        REAL*4      BETH           !        creep coefficient beta-h
        REAL*4      TS             ! [  93] start date of drying
        REAL*4      TC             ! [  93] start date of loading
      END TYPE CBSCT_CRC
      INTEGER, PARAMETER :: LEN_CBSCT_CRC=13
      INTEGER, PARAMETER :: VER_CBSCT_CRC=200701

      TYPE CBEAM_CRF               ! 104/LC:+  resulting forces of redistribution
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      SDNI           ! [1101] total normal force
        REAL*4      SDVY           ! [1102] total y-shear force
        REAL*4      SDVZ           ! [1102] total z-shear force
        REAL*4      SDMT           ! [1103] total torsion moment
        REAL*4      SDMY           ! [1104] total bending moment
        REAL*4      SDMZ           ! [1104] total bending moment
        REAL*4      SRNI           ! [1101] relat. normal force
        REAL*4      SRVY           ! [1102] relat. y-shear force
        REAL*4      SRVZ           ! [1102] relat. y-shear force
        REAL*4      SRMT           ! [1103] relat. torsionmoment
        REAL*4      SRMY           ! [1104] relat. bendingmoment
        REAL*4      SRMZ           ! [1104] relat. bendingmoment
      END TYPE CBEAM_CRF
      INTEGER, PARAMETER :: LEN_CBEAM_CRF=15
      INTEGER, PARAMETER :: VER_CBEAM_CRF=200501

      TYPE CBSLN_CRF               ! 124/LC:+  resulting forces of redistribution
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      SDNI           ! [1101] total normal force
        REAL*4      SDVY           ! [1102] total y-shear force
        REAL*4      SDVZ           ! [1102] total z-shear force
        REAL*4      SDMT           ! [1103] total torsion moment
        REAL*4      SDMY           ! [1104] total bending moment
        REAL*4      SDMZ           ! [1104] total bending moment
        REAL*4      SRNI           ! [1101] relat. normal force
        REAL*4      SRVY           ! [1102] relat. y-shear force
        REAL*4      SRVZ           ! [1102] relat. y-shear force
        REAL*4      SRMT           ! [1103] relat. torsionmoment
        REAL*4      SRMY           ! [1104] relat. bendingmoment
        REAL*4      SRMZ           ! [1104] relat. bendingmoment
      END TYPE CBSLN_CRF
      INTEGER, PARAMETER :: LEN_CBSLN_CRF=15
      INTEGER, PARAMETER :: VER_CBSLN_CRF=201606

      TYPE CBSCT_CRF               ! 144/LC:+  resulting forces of redistribution
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   ID               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      SDNI           ! [1101] total normal force
        REAL*4      SDVY           ! [1102] total y-shear force
        REAL*4      SDVZ           ! [1102] total z-shear force
        REAL*4      SDMT           ! [1103] total torsion moment
        REAL*4      SDMY           ! [1104] total bending moment
        REAL*4      SDMZ           ! [1104] total bending moment
        REAL*4      SRNI           ! [1101] relat. normal force
        REAL*4      SRVY           ! [1102] relat. y-shear force
        REAL*4      SRVZ           ! [1102] relat. y-shear force
        REAL*4      SRMT           ! [1103] relat. torsionmoment
        REAL*4      SRMY           ! [1104] relat. bendingmoment
        REAL*4      SRMZ           ! [1104] relat. bendingmoment
      END TYPE CBSCT_CRF
      INTEGER, PARAMETER :: LEN_CBSCT_CRF=15
      INTEGER, PARAMETER :: VER_CBSCT_CRF=200501

      TYPE CBEAM_TSN               ! 104/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        10000+materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,32)       ! [1092] Eigenstress table (z,sig)
      END TYPE CBEAM_TSN
      INTEGER, PARAMETER :: LEN_CBEAM_TSN=67
      INTEGER, PARAMETER :: VER_CBEAM_TSN=201704

      TYPE CBSLN_TSN               ! 124/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        10000+materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,32)       ! [1092] Eigenstress table (z,sig)
      END TYPE CBSLN_TSN
      INTEGER, PARAMETER :: LEN_CBSLN_TSN=67
      INTEGER, PARAMETER :: VER_CBSLN_TSN=201704

      TYPE CBSCT_TSN               ! 144/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        10000+materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,32)       ! [1092] Eigenstress table (z,sig)
      END TYPE CBSCT_TSN
      INTEGER, PARAMETER :: LEN_CBSCT_TSN=67
      INTEGER, PARAMETER :: VER_CBSCT_TSN=201704

      TYPE CBEAM_CRP               ! 104/LC:+  forces on sectional parts per material
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DNI            ! [1101] impr. normal force
        REAL*4      DMYI           ! [1104] impr. bending moment
        REAL*4      DMZI           ! [1104] impr. bending moment
        REAL*4      NI             ! [1101] total normal force
        REAL*4      MYI            ! [1104] total bending moment
        REAL*4      MZI            ! [1104] total bending moment
        REAL*4      SDNI           ! [1192] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMYI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMZI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SNI            ! [1192] stress plane parameter from (NI:MZI)
        REAL*4      SMYI           ! [1193] stress plane parameter from (NI:MZI)
        REAL*4      SMZI           ! [1193] stress plane parameter from (NI:MZI)
      END TYPE CBEAM_CRP
      INTEGER, PARAMETER :: LEN_CBEAM_CRP=15
      INTEGER, PARAMETER :: VER_CBEAM_CRP=200501

      TYPE CBSLN_CRP               ! 124/LC:+  forces on sectional parts per material
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DNI            ! [1101] impr. normal force
        REAL*4      DMYI           ! [1104] impr. bending moment
        REAL*4      DMZI           ! [1104] impr. bending moment
        REAL*4      NI             ! [1101] total normal force
        REAL*4      MYI            ! [1104] total bending moment
        REAL*4      MZI            ! [1104] total bending moment
        REAL*4      SDNI           ! [1192] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMYI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMZI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SNI            ! [1192] stress plane parameter from (NI:MZI)
        REAL*4      SMYI           ! [1193] stress plane parameter from (NI:MZI)
        REAL*4      SMZI           ! [1193] stress plane parameter from (NI:MZI)
      END TYPE CBSLN_CRP
      INTEGER, PARAMETER :: LEN_CBSLN_CRP=15
      INTEGER, PARAMETER :: VER_CBSLN_CRP=201606

      TYPE CBSCT_CRP               ! 144/LC:+  forces on sectional parts per material
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DNI            ! [1101] impr. normal force
        REAL*4      DMYI           ! [1104] impr. bending moment
        REAL*4      DMZI           ! [1104] impr. bending moment
        REAL*4      NI             ! [1101] total normal force
        REAL*4      MYI            ! [1104] total bending moment
        REAL*4      MZI            ! [1104] total bending moment
        REAL*4      SDNI           ! [1192] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMYI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SDMZI          ! [1193] stress plane parameter from (DNI:DMZI)
        REAL*4      SNI            ! [1192] stress plane parameter from (NI:MZI)
        REAL*4      SMYI           ! [1193] stress plane parameter from (NI:MZI)
        REAL*4      SMZI           ! [1193] stress plane parameter from (NI:MZI)
      END TYPE CBSCT_CRP
      INTEGER, PARAMETER :: LEN_CBSCT_CRP=15
      INTEGER, PARAMETER :: VER_CBSCT_CRP=200501

      TYPE CBEAM_CRT               ! 104/LC:+  changes of tensional force
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        neg. tendonnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DZZ            ! [1092] change of stress to prestress
        REAL*4      DZR            ! [1092] rel. change of stress to concrete strain
        REAL*4      DZ             ! [1101] rel. change of force from mean strain
        REAL*4      DZFAK(5)       !        ordinates, inclinations to evaluate forces
      END TYPE CBEAM_CRT
      INTEGER, PARAMETER :: LEN_CBEAM_CRT=11
      INTEGER, PARAMETER :: VER_CBEAM_CRT=200501

      TYPE CBSLN_CRT               ! 124/LC:+  changes of tensional force
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        neg. tendonnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DZZ            ! [1092] change of stress to prestress
        REAL*4      DZR            ! [1092] rel. change of stress to concrete strain
        REAL*4      DZ             ! [1101] rel. change of force from mean strain
        REAL*4      DZFAK(5)       !        ordinates, inclinations to evaluate forces
      END TYPE CBSLN_CRT
      INTEGER, PARAMETER :: LEN_CBSLN_CRT=11
      INTEGER, PARAMETER :: VER_CBSLN_CRT=201606

      TYPE CBSCT_CRT               ! 144/LC:+  changes of tensional force
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NRS              !        neg. tendonnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      DZZ            ! [1092] change of stress to prestress
        REAL*4      DZR            ! [1092] rel. change of stress to concrete strain
        REAL*4      DZ             ! [1101] rel. change of force from mean strain
        REAL*4      DZFAK(5)       !        ordinates, inclinations to evaluate forces
      END TYPE CBSCT_CRT
      INTEGER, PARAMETER :: LEN_CBSCT_CRT=11
      INTEGER, PARAMETER :: VER_CBSCT_CRT=200501

      TYPE CBEAM_STC               ! 105/LC:0  Maximum stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        Ident 0
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance to start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial comp stress
        REAL*4      SIGU           ! [1092] uniaxial tens stress
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling intensity
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
      END TYPE CBEAM_STC
      INTEGER, PARAMETER :: LEN_CBEAM_STC=18
      INTEGER, PARAMETER :: VER_CBEAM_STC=200501

      TYPE CBSLN_STC               ! 125/LC:0  Maximum stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        Ident 0
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance to start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial comp stress
        REAL*4      SIGU           ! [1092] uniaxial tens stress
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling intensity
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
      END TYPE CBSLN_STC
      INTEGER, PARAMETER :: LEN_CBSLN_STC=18
      INTEGER, PARAMETER :: VER_CBSLN_STC=200501

      TYPE CBSCT_STC               ! 145/LC:0  Maximum stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        Ident 0
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance to start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial comp stress
        REAL*4      SIGU           ! [1092] uniaxial tens stress
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling intensity
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
      END TYPE CBSCT_STC
      INTEGER, PARAMETER :: LEN_CBSCT_STC=18
      INTEGER, PARAMETER :: VER_CBSCT_STC=200501

      TYPE CBEAM_TST               ! 105/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        100000 + material number as in BSCT_STC
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,128)      ! [1092] Eigenstress table (z,sig)
      END TYPE CBEAM_TST
      INTEGER, PARAMETER :: LEN_CBEAM_TST=259
      INTEGER, PARAMETER :: VER_CBEAM_TST=201704

      TYPE CBSLN_TST               ! 125/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        100000 + material number as in BSCT_STC
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,128)      ! [1092] Eigenstress table (z,sig)
      END TYPE CBSLN_TST
      INTEGER, PARAMETER :: LEN_CBSLN_TST=259
      INTEGER, PARAMETER :: VER_CBSLN_TST=201704

      TYPE CBSCT_TST               ! 145/LC:+  thermal eigen stress per material
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   MNRX             !        100000 + material number as in BSCT_STC
        REAL*4      X              ! [1001] distance from start
        REAL*4      TS(2,128)      ! [1092] Eigenstress table (z,sig)
      END TYPE CBSCT_TST
      INTEGER, PARAMETER :: LEN_CBSCT_TST=259
      INTEGER, PARAMETER :: VER_CBSCT_TST=201704

      TYPE CBEAM_STR               ! 105/LC:+  Stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial stress up
        REAL*4      SIGU           ! [1092] uniaxial stress down
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling effects
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
        REAL*4      RCTRL          !        control value of stress/strain description
        REAL*4      ES0            !        strain in center of total section
        REAL*4      ESY            !        strain gradient in y-direction
        REAL*4      ESZ            !        strain gradient in z-direction
        REAL*4      YC             ! [1011] location of center of partial section
        REAL*4      ZC             ! [1011] location of center of partial section
        REAL*4      ESW            !        factor for unit warping
        REAL*4      VYF            ! [1102] shear force
        REAL*4      VZF            ! [1102] shear force
        REAL*4      MTF            ! [1103] primary torsional moment
        REAL*4      MT2F           ! [1103] secondary torsional moment
      END TYPE CBEAM_STR
      INTEGER, PARAMETER :: LEN_CBEAM_STR=29
      INTEGER, PARAMETER :: VER_CBEAM_STR=201009

      TYPE CBSLN_STR               ! 125/LC:+  Stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial stress up
        REAL*4      SIGU           ! [1092] uniaxial stress down
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling effects
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
        REAL*4      RCTRL          !        control value of stress/strain description
        REAL*4      ES0            !        strain in center of total section
        REAL*4      ESY            !        strain gradient in y-direction
        REAL*4      ESZ            !        strain gradient in z-direction
        REAL*4      YC             ! [1011] location of center of partial section
        REAL*4      ZC             ! [1011] location of center of partial section
        REAL*4      ESW            !        factor for unit warping
        REAL*4      VYF            ! [1102] shear force
        REAL*4      VZF            ! [1102] shear force
        REAL*4      MTF            ! [1103] primary torsional moment
        REAL*4      MT2F           ! [1103] secondary torsional moment
      END TYPE CBSLN_STR
      INTEGER, PARAMETER :: LEN_CBSLN_STR=29
      INTEGER, PARAMETER :: VER_CBSLN_STR=201606

      TYPE CBSCT_STR               ! 145/LC:+  Stresses in cross-section of beams
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   MNR              !        materialnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      SIGC           ! [1092] compressive stress
        REAL*4      SIGT           ! [1092] tensile stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGV           ! [1092] reference stress
        REAL*4      SI             ! [1092] main tension stress
        REAL*4      SII            ! [1092] main compress stress
        REAL*4      SIGO           ! [1092] uniaxial stress up
        REAL*4      SIGU           ! [1092] uniaxial stress down
        REAL*4      DSIG           ! [1092] sway of normal stress
        REAL*4      DTAU           ! [1092] sway of shear stress
        REAL*4      SIGW           ! [1092] stress in weldings
        REAL*4      VB             ! [1153] Bond force
        REAL*4      BUCK           !        buckling effects
        REAL*4      I_14           !        reserved
        REAL*4      SIGCT          ! [1092] decompression stress
        REAL*4      RCTRL          !        control value of stress/strain description
        REAL*4      ES0            !        strain in center of total section
        REAL*4      ESY            !        strain gradient in y-direction
        REAL*4      ESZ            !        strain gradient in z-direction
        REAL*4      YC             ! [1011] location of center of partial section
        REAL*4      ZC             ! [1011] location of center of partial section
        REAL*4      ESW            !        factor for unit warping
        REAL*4      VYF            ! [1102] shear force
        REAL*4      VZF            ! [1102] shear force
        REAL*4      MTF            ! [1103] primary torsional moment
        REAL*4      MT2F           ! [1103] secondary torsional moment
      END TYPE CBSCT_STR
      INTEGER, PARAMETER :: LEN_CBSCT_STR=29
      INTEGER, PARAMETER :: VER_CBSCT_STR=201009

      TYPE CBEAM_RF0               ! 106/DC:0  max. values of reinforcement
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NVERS            !        Version number
        REAL*4      ASLMAX         ! [1021] maximum longitudinal reinforcement
        REAL*4      ASBMAX         ! [1021] maximum of transverse reinforcement reinforcement
        REAL*4      VMMAX          ! [1001] maximum of shift rule offset
        REAL*4      RESERVED(12)   !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CBEAM_RF0
      INTEGER, PARAMETER :: LEN_CBEAM_RF0=34
      INTEGER, PARAMETER :: VER_CBEAM_RF0=200804

      TYPE CBSLN_RF0               ! 126/DC:0  max. values of reinforcement
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NVERS            !        Version number
        REAL*4      ASLMAX         ! [1021] maximum longitudinal reinforcement
        REAL*4      ASBMAX         ! [1021] maximum of transverse reinforcement reinforcement
        REAL*4      VMMAX          ! [1001] maximum of shift rule offset
        REAL*4      RESERVED(12)   !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CBSLN_RF0
      INTEGER, PARAMETER :: LEN_CBSLN_RF0=34
      INTEGER, PARAMETER :: VER_CBSLN_RF0=201606

      TYPE CBSCT_RF0               ! 146/DC:0  max. values of reinforcement
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NVERS            !        Version number
        REAL*4      ASLMAX         ! [1021] maximum longitudinal reinforcement
        REAL*4      ASBMAX         ! [1021] maximum of transverse reinforcement reinforcement
        REAL*4      VMMAX          ! [1001] maximum of shift rule offset
        REAL*4      RESERVED(12)   !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CBSCT_RF0
      INTEGER, PARAMETER :: LEN_CBSCT_RF0=34
      INTEGER, PARAMETER :: VER_CBSCT_RF0=200804

      TYPE CTRUS_RF0               ! 156/DC:0  max. values of reinforcement
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NVERS            !        Version number
        REAL*4      ASLMAX         ! [1021] maximum longitudinal reinforcement
        REAL*4      ASBMAX         ! [1021] maximum of transverse reinforcement reinforcement
        REAL*4      VMMAX          ! [1001] maximum of shift rule offset
        REAL*4      RESERVED(12)   !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CTRUS_RF0
      INTEGER, PARAMETER :: LEN_CTRUS_RF0=34
      INTEGER, PARAMETER :: VER_CTRUS_RF0=200804

      TYPE CCABL_RF0               ! 166/DC:0  max. values of reinforcement
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NVERS            !        Version number
        REAL*4      ASLMAX         ! [1021] maximum longitudinal reinforcement
        REAL*4      ASBMAX         ! [1021] maximum of transverse reinforcement reinforcement
        REAL*4      VMMAX          ! [1001] maximum of shift rule offset
        REAL*4      RESERVED(12)   !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CCABL_RF0
      INTEGER, PARAMETER :: LEN_CCABL_RF0=34
      INTEGER, PARAMETER :: VER_CCABL_RF0=200804

      TYPE CBEAM_RFI               ! 106/DC:+  info of reinforcement of beam
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        info id = 0
        REAL*4      X              ! [1001] distance from start
        INTEGER   ASL(2,10)        !        infos for longitudinal layers 0:9
        INTEGER   ASV(2,15)        !        infos for transverse reinforcement layers 1:15
      END TYPE CBEAM_RFI
      INTEGER, PARAMETER :: LEN_CBEAM_RFI=53
      INTEGER, PARAMETER :: VER_CBEAM_RFI=201501

      TYPE CBSLN_RFI               ! 126/DC:+  info of reinforcement of design element sect.
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        info id = 0
        REAL*4      X              ! [1001] distance from start
        INTEGER   ASL(2,10)        !        infos for longitudinal layers 0:9
        INTEGER   ASV(2,15)        !        infos for transverse reinforcement layers 1:15
      END TYPE CBSLN_RFI
      INTEGER, PARAMETER :: LEN_CBSLN_RFI=53
      INTEGER, PARAMETER :: VER_CBSLN_RFI=201606

      TYPE CBSCT_RFI               ! 146/DC:+  info of reinforcement of external section
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        info id = 0
        REAL*4      X              ! [1001] distance from start
        INTEGER   ASL(2,10)        !        infos for longitudinal layers 0:9
        INTEGER   ASV(2,15)        !        infos for transverse reinforcement layers 1:15
      END TYPE CBSCT_RFI
      INTEGER, PARAMETER :: LEN_CBSCT_RFI=53
      INTEGER, PARAMETER :: VER_CBSCT_RFI=201501

      TYPE CTRUS_RFI               ! 156/DC:+  info of reinforcement of truss
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        info id = 0
        REAL*4      X              ! [1001] distance from start
        INTEGER   ASL(2,10)        !        infos for longitudinal layers 0:9
        INTEGER   ASV(2,15)        !        infos for transverse reinforcement layers 1:15
      END TYPE CTRUS_RFI
      INTEGER, PARAMETER :: LEN_CTRUS_RFI=53
      INTEGER, PARAMETER :: VER_CTRUS_RFI=201501

      TYPE CCABL_RFI               ! 166/DC:+  info of reinforcement of cables
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        info id = 0
        REAL*4      X              ! [1001] distance from start
        INTEGER   ASL(2,10)        !        infos for longitudinal layers 0:9
        INTEGER   ASV(2,15)        !        infos for transverse reinforcement layers 1:15
      END TYPE CCABL_RFI
      INTEGER, PARAMETER :: LEN_CCABL_RFI=53
      INTEGER, PARAMETER :: VER_CCABL_RFI=201501

      TYPE CBEAM_RFC               ! 106/DC:+  reinforcement of beam
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        section number
        REAL*4      X              ! [1001] distance from start
        REAL*4      ASUM           ! [1020] Total longitudinal reinforcement
        REAL*4      ATOR           ! [1021] maximum of torsional reinforcement
        REAL*4      ASL(10)        ! [1020] Area of layer 0:9
        REAL*4      VM             ! [1001] shift rule offset
        REAL*4      ASBMAX         ! [1021] maximum of all transverse reinforcement areas
        REAL*4      ASB(2,15)      ! [1021] transverse reinforcements
      END TYPE CBEAM_RFC
      INTEGER, PARAMETER :: LEN_CBEAM_RFC=47
      INTEGER, PARAMETER :: VER_CBEAM_RFC=200804

      TYPE CBSLN_RFC               ! 126/DC:+  reinforcement of design element section
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        section number
        REAL*4      X              ! [1001] distance from start
        REAL*4      ASUM           ! [1020] Total longitudinal reinforcement
        REAL*4      ATOR           ! [1021] maximum of torsional reinforcement
        REAL*4      ASL(10)        ! [1020] Area of layer 0:9
        REAL*4      VM             ! [1001] shift rule offset
        REAL*4      ASBMAX         ! [1021] maximum of all transverse reinforcement areas
        REAL*4      ASB(2,15)      ! [1021] transverse reinforcements
      END TYPE CBSLN_RFC
      INTEGER, PARAMETER :: LEN_CBSLN_RFC=47
      INTEGER, PARAMETER :: VER_CBSLN_RFC=201606

      TYPE CBSCT_RFC               ! 146/DC:+  reinforcement of external section
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        section number
        REAL*4      X              ! [1001] distance from start
        REAL*4      ASUM           ! [1020] Total longitudinal reinforcement
        REAL*4      ATOR           ! [1021] maximum of torsional reinforcement
        REAL*4      ASL(10)        ! [1020] Area of layer 0:9
        REAL*4      VM             ! [1001] shift rule offset
        REAL*4      ASBMAX         ! [1021] maximum of all transverse reinforcement areas
        REAL*4      ASB(2,15)      ! [1021] transverse reinforcements
      END TYPE CBSCT_RFC
      INTEGER, PARAMETER :: LEN_CBSCT_RFC=47
      INTEGER, PARAMETER :: VER_CBSCT_RFC=200804

      TYPE CTRUS_RFC               ! 156/DC:+  reinforcement of truss
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        section number
        REAL*4      X              ! [1001] distance from start
        REAL*4      ASUM           ! [1020] Total longitudinal reinforcement
        REAL*4      ATOR           ! [1021] maximum of torsional reinforcement
        REAL*4      ASL(10)        ! [1020] Area of layer 0:9
        REAL*4      VM             ! [1001] shift rule offset
        REAL*4      ASBMAX         ! [1021] maximum of all transverse reinforcement areas
        REAL*4      ASB(2,15)      ! [1021] transverse reinforcements
      END TYPE CTRUS_RFC
      INTEGER, PARAMETER :: LEN_CTRUS_RFC=47
      INTEGER, PARAMETER :: VER_CTRUS_RFC=200804

      TYPE CCABL_RFC               ! 166/DC:+  reinforcement of cables
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   NQ               !        section number
        REAL*4      X              ! [1001] distance from start
        REAL*4      ASUM           ! [1020] Total longitudinal reinforcement
        REAL*4      ATOR           ! [1021] maximum of torsional reinforcement
        REAL*4      ASL(10)        ! [1020] Area of layer 0:9
        REAL*4      VM             ! [1001] shift rule offset
        REAL*4      ASBMAX         ! [1021] maximum of all transverse reinforcement areas
        REAL*4      ASB(2,15)      ! [1021] transverse reinforcements
      END TYPE CCABL_RFC
      INTEGER, PARAMETER :: LEN_CCABL_RFC=47
      INTEGER, PARAMETER :: VER_CCABL_RFC=200804

      TYPE CBEAM_DE0               ! 107/LC:0  max. values of Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBEAM_DE0
      INTEGER, PARAMETER :: LEN_CBEAM_DE0=40
      INTEGER, PARAMETER :: VER_CBEAM_DE0=200501

      TYPE CBSLN_DE0               ! 127/LC:0  max. values of Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBSLN_DE0
      INTEGER, PARAMETER :: LEN_CBSLN_DE0=40
      INTEGER, PARAMETER :: VER_CBSLN_DE0=201606

      TYPE CBSCT_DE0               ! 147/LC:0  max. values of Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBSCT_DE0
      INTEGER, PARAMETER :: LEN_CBSCT_DE0=40
      INTEGER, PARAMETER :: VER_CBSCT_DE0=200501

      TYPE CTRUS_DE0               ! 157/LC:0  max. values of Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CTRUS_DE0
      INTEGER, PARAMETER :: LEN_CTRUS_DE0=40
      INTEGER, PARAMETER :: VER_CTRUS_DE0=200501

      TYPE CBEAM_DES               ! 107/LC:+  Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBEAM_DES
      INTEGER, PARAMETER :: LEN_CBEAM_DES=40
      INTEGER, PARAMETER :: VER_CBEAM_DES=200501

      TYPE CBSLN_DES               ! 127/LC:+  Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBSLN_DES
      INTEGER, PARAMETER :: LEN_CBSLN_DES=40
      INTEGER, PARAMETER :: VER_CBSLN_DES=201606

      TYPE CBSCT_DES               ! 147/LC:+  Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CBSCT_DES
      INTEGER, PARAMETER :: LEN_CBSCT_DES=40
      INTEGER, PARAMETER :: VER_CBSCT_DES=200501

      TYPE CTRUS_DES               ! 157/LC:+  Ultimate/Plastic Design results
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      X              ! [1001] distance from start
        REAL*4      NI             ! [1101] Inner normal force
        REAL*4      MYI            ! [1104] bending moment My
        REAL*4      MZI            ! [1104] bending moment My
        REAL*4      SCF            !        relative capacity
        REAL*4      E0             ! [   9] strain at center
        REAL*4      EY             ! [1009] curvature y direct.
        REAL*4      EZ             ! [1009] curvature z direct.
        REAL*4      E1             ! [   9] compressive strain
        REAL*4      E2             ! [   9] tensional   strain
        REAL*4      HL             ! [1011] lever of forces
        REAL*4      HVM            ! [1001] shift rule value
        REAL*4      HX             ! [1001] height of compression zone   (NSTR-Analysis)
        REAL*4      EDCMIN         ! [   9] minimum decompression strain (NSTR-Analysis)
        REAL*4      EDCMAX         ! [   9] maximum decompression strain (NSTR-Analysis)
        REAL*4      FCHK           ! [1092] not used
        REAL*4      TCF            !        total utilisation level (all effects)
        REAL*4      SCN            !        utilisation level  (1) N/Npl
        REAL*4      SCVY           !        utilisation level  (2) Vy/Vypl
        REAL*4      SCVZ           !        utilisation level  (3) Vz/Vzpl
        REAL*4      SCMT           !        utilisation level  (4) Mt/Mtpl
        REAL*4      SCMY           !        utilisation level  (5) My/Mypl
        REAL*4      SCMZ           !        utilisation level  (6) Mz/Mzpl
        REAL*4      SCMB           !        utilisation level  (7) Mb/Mbpl
        REAL*4      SCT2           !        utilisation level  (8) Mt2/Mt2pl
        REAL*4      SCCOMB         !        utilisation level  (9) TOTAL INTERACTION
        REAL*4      SCBN           !        utilisation level (10) buckling / torsional buckling
        REAL*4      CSIGC          !        utilisation level (11) sig-c/fy
        REAL*4      CSIGT          !        utilisation level (12) sig-t/fy
        REAL*4      CTAU           !        utilisation level (13) tau/tauy
        REAL*4      CSGV           !        utilisation level (14) sigv/fy (von Mises)
        REAL*4      CSGR           !        utilisation level (15) sig-s (tendon/reinforc.stress)
        REAL*4      CAS            !        utilisation level (16) As/As-provided (long.Reinforc)
        REAL*4      CASL           !        utilisation level (17) Asv/Asv-provided (transverse reinf)
        REAL*4      CCW            !        utilisation level (18) As/As-provided for crack width
        REAL*4      CSGD           !        utilisation level (19) sig-d (dynamic stress range)
        REAL*4      CTAU0          !        utilisation level (20) tau0  (Nachweisgrenzen)
        REAL*4      C2T            !        utilisation level (21) plate slenderness (c/t)
        REAL*4      CLASS          !        highest criteria for section class
      END TYPE CTRUS_DES
      INTEGER, PARAMETER :: LEN_CTRUS_DES=40
      INTEGER, PARAMETER :: VER_CTRUS_DES=200501

      TYPE CBEAM_PIF               ! 108/LC  reducing factors of stiffness
        SEQUENCE
        INTEGER   NR               !        pilenumber
        REAL*4      REDP           !        reducing factor of stiffness
        REAL*4      REDA           !        reducing factor of axial bedding
        REAL*4      REDQ           !        reducing factor of cross bedding
      END TYPE CBEAM_PIF
      INTEGER, PARAMETER :: LEN_CBEAM_PIF=4
      INTEGER, PARAMETER :: VER_CBEAM_PIF=200501

      TYPE CBEAM_HR0               ! 111/LC:0  Maximum of Implicit Hinge Reactions
        SEQUENCE
        INTEGER   ID               !        identifier 0
        INTEGER   TYP              !        type of hinge
        INTEGER   IBIT(2)          !        reserved
        REAL*4      X              ! [1001] max. beam length
        REAL*4      REAC           !        extremal reaction force/ moment
        REAL*4      STV(4)         !        extremal values of statevar's
      END TYPE CBEAM_HR0
      INTEGER, PARAMETER :: LEN_CBEAM_HR0=10
      INTEGER, PARAMETER :: VER_CBEAM_HR0=200707

      TYPE CBEAM_HRC               ! 111/LC:+  Implicit Hinge Reactions
        SEQUENCE
        INTEGER   NR               !        beamnumber
        INTEGER   TYP              !        type of hinge
        INTEGER   IBIT(2)          !        reserved
        REAL*4      X              ! [1001] hinge location, beam abscissa value
        REAL*4      REAC           !        reaction force/ moment
        REAL*4      STV(4)         !        statevar's
      END TYPE CBEAM_HRC
      INTEGER, PARAMETER :: LEN_CBEAM_HRC=10
      INTEGER, PARAMETER :: VER_CBEAM_HRC=200707

      TYPE CBEAM_MP0               ! 115/LC:0  Extremal values of cross-sectional material point reactions
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   TYPE             !        type: reinforcement=1, base material point=0
        INTEGER   MNO              !        material number
        INTEGER   MRF              !        material number reinforcement
        INTEGER   NPTS             !        number of base material points
        INTEGER   NRF              !        Anzahl Materialpunkte Bewehrung
        REAL*4      X              ! [1001] max. beam length
        REAL*4      Y              ! [1011] max. y-ccordinate
        REAL*4      Z              ! [1011] max. z-ccordinate
        REAL*4      SIGX           ! [1092] axial normal stress
        REAL*4      TAUXY          ! [1092] shear stress xy
        REAL*4      TAUXZ          ! [1092] shear stress xz
        REAL*4      F0             !        utilization level
        REAL*4      KAPAP          ! [   9] equiv. plastic strain
        REAL*4      KAPAD          ! [   9] fracturing strain
        REAL*4      CCW            ! [1026] current crack opening
        REAL*4      TEMP           ! [   6] current temperature
        REAL*4      TEMPMAX        ! [   6] maximum temperature in loading history
        REAL*4      EPS_S          ! [   9] pure reinforcement strain (without TS strain correction)
        REAL*4      EPS_TS         ! [   9] tension stiffening strain correction (accumulated)
        REAL*4      DUMMY          !        unused
        REAL*4      IZONE          !        performance interval
        REAL*4      EPST           ! [   9] axial temperature strain
        REAL*4      EPSX           ! [   9] axial total strain (without temperature strain)
        REAL*4      A_MPT          ! [1012] associated material point area
        REAL*4      FC_TEMP        ! [1092] current compressive strength (temperature dependent)
        REAL*4      FT_TEMP        ! [1092] current tensile strength (temperature dependent)
      END TYPE CBEAM_MP0
      INTEGER, PARAMETER :: LEN_CBEAM_MP0=27
      INTEGER, PARAMETER :: VER_CBEAM_MP0=201008

      TYPE CBEAM_MPT               ! 115/LC:+  Cross-sectional material point reactions
        SEQUENCE
        INTEGER   NR               !        beam number
        INTEGER   TYPE             !        type: reinforcement=1, base material point=0
        INTEGER   MNO              !        material number
        INTEGER   MRF              !        material number reinforcement
        INTEGER   NPTS             !        number of base material points
        INTEGER   NRF              !        Anzahl Materialpunkte Bewehrung
        REAL*4      X              ! [1001] beam abscissa value
        REAL*4      Y              ! [1011] cross-sectional y-position
        REAL*4      Z              ! [1011] cross-sectional z-position
        REAL*4      SIGX           ! [1092] axial normal stress
        REAL*4      TAUXY          ! [1092] shear stress xy
        REAL*4      TAUXZ          ! [1092] shear stress xz
        REAL*4      F0             !        utilization level
        REAL*4      KAPAP          ! [   9] equiv. plastic strain
        REAL*4      KAPAD          ! [   9] fracturing strain
        REAL*4      CCW            ! [1026] current crack opening
        REAL*4      TEMP           ! [   6] current temperature
        REAL*4      TEMPMAX        ! [   6] maximum temperature in loading history
        REAL*4      EPS_S          ! [   9] pure reinforcement strain (without TS strain correction)
        REAL*4      EPS_TS         ! [   9] tension stiffening strain correction (accumulated)
        REAL*4      DUMMY          !        unused
        REAL*4      IZONE          !        performance interval
        REAL*4      EPST           ! [   9] axial temperature strain
        REAL*4      EPSX           ! [   9] axial total strain (without temperature strain)
        REAL*4      A_MPT          ! [1012] associated material point area
        REAL*4      FC_TEMP        ! [1092] current compressive strength (temperature dependent)
        REAL*4      FT_TEMP        ! [1092] current tensile strength (temperature dependent)
      END TYPE CBEAM_MPT
      INTEGER, PARAMETER :: LEN_CBEAM_MPT=27
      INTEGER, PARAMETER :: VER_CBEAM_MPT=201008

      TYPE CTRUS                   ! 150/00  trusselements
        SEQUENCE
        INTEGER   NR               !        truss number
        INTEGER   NODE(2)          !        nodenumbers
        INTEGER   NRQ              !        cross-section number
        REAL*4      T(3)           !        normal direction
        REAL*4      DL             ! [1001] length of truss
        REAL*4      PRE            ! [1101] prestress
        REAL*4      GAP            ! [1003] slip of element
        REAL*4      RISS           ! [1101] max tension force
        REAL*4      FLIE           ! [1101] yielding load
        INTEGER   NREF             !        reference axis
      END TYPE CTRUS
      INTEGER, PARAMETER :: LEN_CTRUS=13
      INTEGER, PARAMETER :: VER_CTRUS=200910

      TYPE CTRUS_LOA               ! 151/LC  Loads on truss elements
        SEQUENCE
        INTEGER   NR               !        truss number
        INTEGER   TYP              !        type of load
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
      END TYPE CTRUS_LOA
      INTEGER, PARAMETER :: LEN_CTRUS_LOA=4
      INTEGER, PARAMETER :: VER_CTRUS_LOA=200501

      TYPE CTRUS_RE0               ! 152/LC:0  maximum of results of truss elements
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      N              ! [1101] normal force
        REAL*4      V              ! [1003] axial displacement
      END TYPE CTRUS_RE0
      INTEGER, PARAMETER :: LEN_CTRUS_RE0=3
      INTEGER, PARAMETER :: VER_CTRUS_RE0=200501

      TYPE CTRUS_RES               ! 152/LC:+  results of truss elements
        SEQUENCE
        INTEGER   NR               !        truss number
        REAL*4      N              ! [1101] normal force
        REAL*4      V              ! [1003] axial displacement
        REAL*4      LEX            !        nonlinear effect
        REAL*4      DAMM(6)        !        Damage Parameter
      END TYPE CTRUS_RES
      INTEGER, PARAMETER :: LEN_CTRUS_RES=10
      INTEGER, PARAMETER :: VER_CTRUS_RES=200501

      TYPE CTRUS_ST0               ! 155/LC:0  checked truss stresses
        SEQUENCE
        INTEGER   NR               !        ident 0
        INTEGER   MAT              !        Materialnumber
        REAL*4      SIG            ! [1092] normal stress
        REAL*4      BUCK           !        buckling intensity
      END TYPE CTRUS_ST0
      INTEGER, PARAMETER :: LEN_CTRUS_ST0=4
      INTEGER, PARAMETER :: VER_CTRUS_ST0=200501

      TYPE CTRUS_STR               ! 155/LC:+  truss stress (AQB)
        SEQUENCE
        INTEGER   NR               !        trussingnumber
        INTEGER   MAT              !        Materialnumber
        REAL*4      SIG            ! [1092] normal stress
        REAL*4      BUCK           !        buckling intensity
      END TYPE CTRUS_STR
      INTEGER, PARAMETER :: LEN_CTRUS_STR=4
      INTEGER, PARAMETER :: VER_CTRUS_STR=200501

      TYPE CCABL                   ! 160/00  cable elements
        SEQUENCE
        INTEGER   NR               !        cable number
        INTEGER   NODE(2)          !        nodenumbers
        INTEGER   NRQ              !        cross-section number
        REAL*4      T(3)           !        normal direction
        REAL*4      DL             ! [1001] length of cable
        REAL*4      PRE            ! [1101] prestress
        REAL*4      GAP            ! [1003] slip of element
        REAL*4      RISS           ! [1101] max tension force
        REAL*4      FLIE           ! [1101] yielding load
        INTEGER   NREF             !        reference axis
      END TYPE CCABL
      INTEGER, PARAMETER :: LEN_CCABL=13
      INTEGER, PARAMETER :: VER_CCABL=200910

      TYPE CCABL_LOA               ! 161/LC  loads on cables
        SEQUENCE
        INTEGER   NR               !        cable number
        INTEGER   TYP              !        type of load
        REAL*4      PA             !        start value of load
        REAL*4      PE             !        end value of load
      END TYPE CCABL_LOA
      INTEGER, PARAMETER :: LEN_CCABL_LOA=4
      INTEGER, PARAMETER :: VER_CCABL_LOA=200501

      TYPE CCABL_RE0               ! 162/LC:0  maximum results of cables
        SEQUENCE
        INTEGER   NR               !        identifier 0
        REAL*4      N              ! [1101] normal force
        REAL*4      V              ! [1003] axial displacement
        REAL*4      VT             ! [1003] maximum suspension of cable across axis
        REAL*4      VTX            ! [1003] suspension of cable, global X-component
        REAL*4      VTY            ! [1003] suspension of cable, global Y-component
        REAL*4      VTZ            ! [1003] suspension of cable, global Z-component
        REAL*4      EPS0           !        maximum induced strain
      END TYPE CCABL_RE0
      INTEGER, PARAMETER :: LEN_CCABL_RE0=8
      INTEGER, PARAMETER :: VER_CCABL_RE0=200501

      TYPE CCABL_RES               ! 162/LC:+  results of cables
        SEQUENCE
        INTEGER   NR               !        cablenumber
        REAL*4      N              ! [1101] normal force
        REAL*4      V              ! [1003] axial displacement
        REAL*4      VQ             ! [1003] maximum suspension of cable across axis
        REAL*4      VTX            ! [1003] suspension of cable, global X-component
        REAL*4      VTY            ! [1003] suspension of cable, global Y-component
        REAL*4      VTZ            ! [1003] suspension of cable, global Z-component
        REAL*4      EPS0           !        Total induced strain
        REAL*4      N_M            ! [1101] average normal force
        REAL*4      F0             ! [1003] vertical suspension of cable in load direction
        REAL*4      L0             ! [1001] relaxed cable length incl. temp. and prestrain effects
        REAL*4      LEX            !        nonlinear effect
        REAL*4      EFFS           !        effective stiffness factor due to cable sagging
        REAL*4      DAMM(6)        !        Damage Parameter
      END TYPE CCABL_RES
      INTEGER, PARAMETER :: LEN_CCABL_RES=19
      INTEGER, PARAMETER :: VER_CCABL_RES=200501

      TYPE CCABL_SLP               ! 163/00  slip cables
        SEQUENCE
        INTEGER   NRSL             !        slip cable number
        INTEGER   NRG              !        group number
        INTEGER   NREL             !        element number
        INTEGER   FREE             !        free
        REAL*4      MUE            !        friction value
      END TYPE CCABL_SLP
      INTEGER, PARAMETER :: LEN_CCABL_SLP=5
      INTEGER, PARAMETER :: VER_CCABL_SLP=200501

      TYPE CCABL_ST0               ! 165/LC:0  checked cable stresses
        SEQUENCE
        INTEGER   NR               !        ident 0
        INTEGER   MAT              !        Materialnumber
        REAL*4      SIG            ! [1092] normal stress
      END TYPE CCABL_ST0
      INTEGER, PARAMETER :: LEN_CCABL_ST0=3
      INTEGER, PARAMETER :: VER_CCABL_ST0=200501

      TYPE CCABL_STR               ! 165/LC:+  cable stresses (AQB)
        SEQUENCE
        INTEGER   NR               !        trussingnumber
        INTEGER   MAT              !        Materialnumber
        REAL*4      SIG            ! [1092] normal stress
      END TYPE CCABL_STR
      INTEGER, PARAMETER :: LEN_CCABL_STR=3
      INTEGER, PARAMETER :: VER_CCABL_STR=200501

      TYPE CSPRI                   ! 170/00  Spring-elements
        SEQUENCE
        INTEGER   NR               !        springnumber
        INTEGER   NODE(2)          !        start nodenumber
        INTEGER   NRQ              !        Material/section no
        REAL*4      T(3)           !        normal direction
        REAL*4      AREF           !        reference area
        REAL*4      CP             ! [1095] spring stiffness
        REAL*4      CQ             ! [1095] transverse stiff.
        REAL*4      CM             ! [1098] torsional stiff.
        REAL*4      PRE            !        prestress
        REAL*4      GAP            !        slip/gap of spring
        REAL*4      RISS           !        max tension force
        REAL*4      FLIE           !        yielding load
        REAL*4      MUE            !        friction cross
        REAL*4      COH            !        cohesion cross
        REAL*4      DIL            !        dilatancy factor
        REAL*4      GAPQ           !        transverse slip/gap
        REAL*4      DP             !        damping constant
        REAL*4      DQ             !        damping shear
        REAL*4      DM             !        damping moment
        REAL*4      EXPP           !        exponent for nonlinear damping dp**expp
        REAL*4      EXPQ           !        exponent for nonlinear damping dq**expq
        REAL*4      EXPM           !        exponent for nonlinear damping dm**expm
        REAL*4      TB(3)          !        rotational direction
        INTEGER   NREF             !        additional bit code
      END TYPE CSPRI
      INTEGER, PARAMETER :: LEN_CSPRI=29
      INTEGER, PARAMETER :: VER_CSPRI=201201

      TYPE CSPRI_RE0               ! 170/LC:0  maximum of results of spring-elements
        SEQUENCE
        INTEGER   ID               !        identifier
        REAL*4      P              ! [1151] maximum spring force
        REAL*4      PT             ! [1151] maximum spring transverse force
        REAL*4      PTX            ! [1151] maximum global X-shear component
        REAL*4      PTY            ! [1151] maximum global Y-shear component
        REAL*4      PTZ            ! [1151] maximum global Z-shear component
        REAL*4      M              ! [1152] maximum spring moment
        REAL*4      V              ! [1003] maximum axial displacement
        REAL*4      VT             ! [1003] maximum transverse displacement
        REAL*4      VTX            ! [1003] maximum trans displ., global X-component
        REAL*4      VTY            ! [1003] maximum trans displ., global Y-component
        REAL*4      VTZ            ! [1003] maximum trans displ., global Z-component
        REAL*4      PHI            ! [1004] rotation
      END TYPE CSPRI_RE0
      INTEGER, PARAMETER :: LEN_CSPRI_RE0=13
      INTEGER, PARAMETER :: VER_CSPRI_RE0=200501

      TYPE CSPRI_RES               ! 170/LC:+  results of spring-elements
        SEQUENCE
        INTEGER   NR               !        springnumber
        REAL*4      P              ! [1151] spring force
        REAL*4      PT             ! [1151] spring transforce
        REAL*4      PTX            ! [1151] global X-shear component
        REAL*4      PTY            ! [1151] global Y-shear component
        REAL*4      PTZ            ! [1151] global Z-shear component
        REAL*4      M              ! [1152] spring moment
        REAL*4      V              ! [1003] axial displacement
        REAL*4      VT             ! [1003] trans. displacement
        REAL*4      VTX            ! [1003] trans. displacement, global X-component
        REAL*4      VTY            ! [1003] trans. displacement, global Y-component
        REAL*4      VTZ            ! [1003] trans. displacement, global Z-component
        REAL*4      PHI            ! [1004] rotation
        REAL*4      LEX            !        nonlinear effect
        REAL*4      STVP(10)       !        State variable / Damage Parameter for CP
        REAL*4      STVM(10)       !        State variable / Damage Parameter for CM
        REAL*4      STVT(10)       !        State variable / Damage Parameter for CT
      END TYPE CSPRI_RES
      INTEGER, PARAMETER :: LEN_CSPRI_RES=44
      INTEGER, PARAMETER :: VER_CSPRI_RES=200501

      TYPE CDAMP                   ! 171/00  Damping elements (DYNA)
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   NODE(2)          !        nodenumbers
        INTEGER   I_3
        REAL*4      T(3)           !        normal direction
        REAL*4      AREF           !        reference area
        REAL*4      DP             !        damping constant
        REAL*4      DQ             !        damping shear
        REAL*4      DM             !        damping moment
        REAL*4      EXPP           !        exponent for nonlinear damping dp**expp
        REAL*4      EXPQ           !        exponent for nonlinear damping dq**expq
        REAL*4      EXPM           !        exponent for nonlinear damping dm**expm
      END TYPE CDAMP
      INTEGER, PARAMETER :: LEN_CDAMP=14
      INTEGER, PARAMETER :: VER_CDAMP=200501

      TYPE CMASS                   ! 172/00  Persistent Nodal masses
        SEQUENCE
        INTEGER   NR               !        nodenumber
        INTEGER   NRG              !        pseudoelementnumber IGDIV*Groupnr+IREF
        REAL*4      MT(3)          ! [  52] transversal mass mt-x,mt-y,mt-z
        REAL*4      MR(6)          ! [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        REAL*4      MB(0:6)        !        warping  mass and higher coefficients
      END TYPE CMASS
      INTEGER, PARAMETER :: LEN_CMASS=18
      INTEGER, PARAMETER :: VER_CMASS=200501

      TYPE CMASS_ADD               ! 172/01  non persistent additional nodal masses
        SEQUENCE
        INTEGER   NR               !        nodenumber
        INTEGER   NRG              !        pseudoelementnumber IGDIV*Groupnr+IREF
        REAL*4      MT(3)          ! [  52] transversal mass mt-x,mt-y,mt-z
        REAL*4      MR(6)          ! [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        REAL*4      MB(0:6)        !        warping  mass and higher coefficients
      END TYPE CMASS_ADD
      INTEGER, PARAMETER :: LEN_CMASS_ADD=18
      INTEGER, PARAMETER :: VER_CMASS_ADD=200501

      TYPE CMASS_EFF               ! 172/LD:Z+  Effective nodal masses
        SEQUENCE
        INTEGER   NR               !        identifier
        REAL*4      MT(3)          ! [  52] transversal mass mt-x,mt-y,mt-z
        REAL*4      MR(3)          ! [  55] rotatory mass    mr-xx,mr-yy,mr-zz
      END TYPE CMASS_EFF
      INTEGER, PARAMETER :: LEN_CMASS_EFF=7
      INTEGER, PARAMETER :: VER_CMASS_EFF=200910

      TYPE CMASS_EFC               ! 172/LD:-  Effective consistent masses
        SEQUENCE
        INTEGER   NR               !        identifier = negative number of nodes
        INTEGER   NODE(8)          !        node numbers
        REAL*4      M(1176)        !        mass matrix in triangular format
      END TYPE CMASS_EFC
      INTEGER, PARAMETER :: LEN_CMASS_EFC=1185
      INTEGER, PARAMETER :: VER_CMASS_EFC=200910

      INTEGER, PARAMETER :: SPRI_WL0_LTYP_STD=1
      INTEGER, PARAMETER :: SPRI_WL0_LTYP_IHNG=2
      INTEGER, PARAMETER :: SPRI_WL0_LTYP_PMM=3
      INTEGER, PARAMETER :: SPRI_WL0_MTYP_PLAS=1
      INTEGER, PARAMETER :: SPRI_WL0_MTYP_PISO=2
      INTEGER, PARAMETER :: SPRI_WL0_MTYP_HYPE=3
      INTEGER, PARAMETER :: SPRI_WL0_MTYP_PKIN=4
      TYPE CSPRI_WL0               ! 173/NR:0  (nonlinear) Spring material
        SEQUENCE
        INTEGER   ID               !        Identification = 0
        INTEGER   LTYP             !        Type of link
        INTEGER   MTYP             !        Type of law
        INTEGER   ICAP             !        capacities from reference-section SNO
        INTEGER   IBIT2            !        reserved
        INTEGER   IHBIT            !        Bitpattern of defined degrees of freedom for implicit hinges
        REAL*4      RLIM(7,2)      ! [1105] 
        REAL*4      ALPH           !        Interpolation exponent My-Mz (PMM, only)
        REAL*4      PAR(16)        !        further reserved material parameters
        INTEGER   TITLE(17)        !        Designation
      END TYPE CSPRI_WL0
      INTEGER, PARAMETER :: LEN_CSPRI_WL0=54
      INTEGER, PARAMETER :: VER_CSPRI_WL0=201502

      INTEGER, PARAMETER :: SPRI_WL_ID_CP=1
      INTEGER, PARAMETER :: SPRI_WL_ID_CQ=2
      INTEGER, PARAMETER :: SPRI_WL_ID_CM=3
      INTEGER, PARAMETER :: SPRI_WL_ID_NX=11
      INTEGER, PARAMETER :: SPRI_WL_ID_VY=12
      INTEGER, PARAMETER :: SPRI_WL_ID_VZ=13
      INTEGER, PARAMETER :: SPRI_WL_ID_MT=14
      INTEGER, PARAMETER :: SPRI_WL_ID_MY=15
      INTEGER, PARAMETER :: SPRI_WL_ID_MZ=16
      INTEGER, PARAMETER :: SPRI_WL_ID_MB=17
      INTEGER, PARAMETER :: SPRI_WL_NTYP_USER=0
      INTEGER, PARAMETER :: SPRI_WL_NTYP_LIN=1
      INTEGER, PARAMETER :: SPRI_WL_NTYP_BILIN=2
      INTEGER, PARAMETER :: SPRI_WL_NTYP_TRILIN=3
      INTEGER, PARAMETER :: SPRI_WL_NTYP_PLAS=4
      TYPE CSPRI_WL                ! 173/NR:+  Worklaw for nonlinear Springs
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   NTYP             !        Type of law
        REAL*4      PLVL           ! [1101] Normal force reference level
        REAL*4      EUR            !        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
        REAL*4      PAR(8)         !        further reserved material parameters
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CSPRI_WL
      INTEGER, PARAMETER :: LEN_CSPRI_WL=112
      INTEGER, PARAMETER :: VER_CSPRI_WL=201206

      TYPE CSPRI_MOV               ! 174/00  Moving Springs
        SEQUENCE
        INTEGER   NR               !        spring element number
        INTEGER   TYP              !        searching criteria
        INTEGER   FROM             !        selection for TYP
        INTEGER   TO               !        selection for TYP
        INTEGER   INC              !        selection for TYP
      END TYPE CSPRI_MOV
      INTEGER, PARAMETER :: LEN_CSPRI_MOV=5
      INTEGER, PARAMETER :: VER_CSPRI_MOV=200501

      TYPE CS_MATRIX               ! 175/00  General systemmatrices
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   TYP              !        element type
        INTEGER   NDN              !        number of degrees of freedom per node
        INTEGER   NODE(6)          !        node numbers
        REAL*4      PER            ! [  90] period of matrix
        REAL*4      S(2048)        !        stiffness matrix
      END TYPE CS_MATRIX
      INTEGER, PARAMETER :: LEN_CS_MATRIX=2058
      INTEGER, PARAMETER :: VER_CS_MATRIX=201601

      TYPE CBOUN                   ! 180/00:+  Boundary elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NVON             !        start nodenumber
        INTEGER   NBIS             !        end nodenumber
        INTEGER   NDEL             !        increment
        INTEGER   TYP              !        type of bedding
        INTEGER   MESS             !        direction of addition
        REAL*4      CA             !        start constant of bedding
        REAL*4      CE             !        end constant of bedding
        REAL*4      DXYZ(3)        !        direction of bedding, X/Y/Z-component
        INTEGER   TEXT(17)         !        Designation of element
      END TYPE CBOUN
      INTEGER, PARAMETER :: LEN_CBOUN=28
      INTEGER, PARAMETER :: VER_CBOUN=200501

      TYPE CBOUN_RES               ! 180/LC  results of boundary elements
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   NK               !        nodenumber
        REAL*4      PX             ! [1153] X-support force
        REAL*4      PY             ! [1153] Y-support force
        REAL*4      PZ             ! [1153] Z-support force
        REAL*4      MN             ! [1154] support moment
      END TYPE CBOUN_RES
      INTEGER, PARAMETER :: LEN_CBOUN_RES=6
      INTEGER, PARAMETER :: VER_CBOUN_RES=200501

      TYPE CBOUN_SUM               ! 181/LC  resultant of boundary results
        SEQUENCE
        INTEGER   NR               !        element number
        REAL*4      PX             ! [1151] X-support force
        REAL*4      PY             ! [1151] X-support force
        REAL*4      PZ             ! [1151] X-support force
        REAL*4      MN             ! [1152] N-support moment
        REAL*4      MX             ! [1152] X-support moment
        REAL*4      MY             ! [1152] Y-support moment
        REAL*4      MZ             ! [1152] Z-support moment
      END TYPE CBOUN_SUM
      INTEGER, PARAMETER :: LEN_CBOUN_SUM=8
      INTEGER, PARAMETER :: VER_CBOUN_SUM=200501

      TYPE CBOUN_LC_LPT            !        node number + load value
        SEQUENCE
        INTEGER   N
        REAL*4      P
      END TYPE CBOUN_LC_LPT
      INTEGER, PARAMETER :: LEN_CBOUN_LC_LPT=2

      TYPE CBOUN_LC                ! 183/LC  Info on loading on boundaries
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   TYP              !        type of load
        TYPE(CBOUN_LC_LPT) LPT(127)!        node number + load value
      END TYPE CBOUN_LC
      INTEGER, PARAMETER :: LEN_CBOUN_LC=256
      INTEGER, PARAMETER :: VER_CBOUN_LC=200501

      TYPE CSPRI_SUM               ! 187/LC  Sum of forces of support springs
        SEQUENCE
        INTEGER   NR               !        group-number
        REAL*4      PX             ! [1151] nodal support X
        REAL*4      PY             ! [1151] nodal support Y
        REAL*4      PZ             ! [1151] nodal support u
        REAL*4      MX             ! [1152] support moment X
        REAL*4      MY             ! [1152] support moment Y
        REAL*4      MZ             ! [1152] support moment Z
        REAL*4      MB             ! [1105] warping moment
      END TYPE CSPRI_SUM
      INTEGER, PARAMETER :: LEN_CSPRI_SUM=8
      INTEGER, PARAMETER :: VER_CSPRI_SUM=200501

      TYPE CRSET                   ! 188/00:+  Sets of results
        SEQUENCE
        INTEGER   ID               !        number / identifier of result set
        INTEGER   NIT              !        number of items in that result set
        INTEGER   TEXT(17)         !        Designation of that set
      END TYPE CRSET
      INTEGER, PARAMETER :: LEN_CRSET=19
      INTEGER, PARAMETER :: VER_CRSET=201005

      TYPE CRSET_ITM               ! 188/00:0  Member of result set
        SEQUENCE
        INTEGER   ID0              !        Identifier = 0
        INTEGER   ID(2)            !        Short name of member for headdings
        INTEGER   IDS(2)           !        Selector of main structure
        INTEGER   IDM(2)           !        Selector of item member
        INTEGER   DIM              !        enum of explicitly selected unit
        INTEGER   KWH              !        main id of result data
        INTEGER   POS              !        position of value in data (starting at zero)
        INTEGER   BIT              !        bit pattern of defined selection data
        INTEGER   NR               !        main number of result data
        INTEGER   NG               !        second number of result data (e.g. group)
        INTEGER   ND1              !        reserved for additional selection data
        INTEGER   ND2              !        reserved for additional selection data
        INTEGER   ND3              !        reserved for additional selection data
        REAL*4      X              !        selector for beam abscissae
      END TYPE CRSET_ITM
      INTEGER, PARAMETER :: LEN_CRSET_ITM=17
      INTEGER, PARAMETER :: VER_CRSET_ITM=201005

      TYPE CRSET_DAT               ! 188/LC  Result-values for sets of results
        SEQUENCE
        INTEGER   ID               !        identifier of result set
        REAL*4      VAL(255)       !        result values
      END TYPE CRSET_DAT
      INTEGER, PARAMETER :: LEN_CRSET_DAT=256
      INTEGER, PARAMETER :: VER_CRSET_DAT=200910

      TYPE CLINK                   ! 179/00  link elements
        SEQUENCE
        INTEGER   NR               !        pipenumber
        INTEGER   NODE(2)          !        nodenumbers
        INTEGER   NRQ              !        material-, type- or cross-sectionnumber
        REAL*4      DL             ! [1001] length of pipe
        REAL*4      A              !        Nominal width or linear loss factor
        REAL*4      B              !        Abs. Roughness or quadratic loss factor
        REAL*4      C              !        specific storage coefficient
        REAL*4      EPS            !        emission coefficient
        REAL*4      AREF           ! [1002] reference area of element
      END TYPE CLINK
      INTEGER, PARAMETER :: LEN_CLINK=10
      INTEGER, PARAMETER :: VER_CLINK=201304

      TYPE CPIPE                   ! 190/00  pipes / armatures
        SEQUENCE
        INTEGER   NR               !        pipenumber
        INTEGER   NODE(2)          !        nodenumbers
        INTEGER   NRQ              !        material-, type- or cross-sectionnumber
        REAL*4      DL             ! [1001] length of pipe
        REAL*4      A              !        Nominal width or linear loss factor
        REAL*4      B              !        Abs. Roughness or quadratic loss factor
        REAL*4      C              !        specific storage coefficient
        REAL*4      EPS            !        emission coefficient
        REAL*4      AREF           ! [1002] reference area of element
      END TYPE CPIPE
      INTEGER, PARAMETER :: LEN_CPIPE=10
      INTEGER, PARAMETER :: VER_CPIPE=201304

      TYPE CPIPE_RES               ! 190/LC  results of pipes
        SEQUENCE
        INTEGER   NR               !        pipenumber
        REAL*4      HA             ! [1010] start potential
        REAL*4      HE             ! [1010] end potential
        REAL*4      I              !        gradient
        REAL*4      A              ! [1012] flow area
        REAL*4      PA             ! [  70] start compression
        REAL*4      PE             ! [  70] end compression
        REAL*4      Q              ! [1211] flow quantity
        REAL*4      V              ! [1212] flow velocity
        REAL*4      R              ! [1011] hydraulic radius
        REAL*4      K              ! [1016] roughness
        REAL*4      RE             !        Reynolds number
        REAL*4      FR             !        Froud    number
      END TYPE CPIPE_RES
      INTEGER, PARAMETER :: LEN_CPIPE_RES=13
      INTEGER, PARAMETER :: VER_CPIPE_RES=200501

      INTEGER, PARAMETER :: LEN_CQUAD0=27
      TYPE CQUAD                   ! 200/00  QuadElements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NODE(4)          !        nodenumbers
        INTEGER   MAT              !        materialnumber
        INTEGER   MRF              !        material Reinf.
        INTEGER   NRA              !        type of element
        REAL*4      DET(0:2)       !        Parameter of Jacobi Determinant
        REAL*4      THICK(0:4)     ! [1010] element thickness
        REAL*4      CB             !        bedding factor
        REAL*4      CQ             !        tangential bedding factor
        REAL*4      T(3,3)         !        transformation matrix
        INTEGER   IFC1             !        identifier of a most adjacent outer boundary
        REAL*4      DFC1(4)        ! [1001] distance of the nodes to the boundary IFC1
        INTEGER   IFC2             !        identifier of a most adjacent inner boundary
        REAL*4      DFC2(4)        ! [1001] distance of the nodes to the boundary IFC2
      END TYPE CQUAD
      INTEGER, PARAMETER :: LEN_CQUAD=37
      INTEGER, PARAMETER :: VER_CQUAD=201408

      TYPE CQUAD_NOH               ! 200/1:0  unified properties of Quad-nodes
        SEQUENCE
        INTEGER   ID1
        INTEGER   ID2
        INTEGER   NKREC
        INTEGER   MAXNEL
        INTEGER   MAXUGR
        INTEGER   MAXGR
        INTEGER   NQUAD
        INTEGER   MQUAD            !        Highest Number of Quadelement
      END TYPE CQUAD_NOH
      INTEGER, PARAMETER :: LEN_CQUAD_NOH=8
      INTEGER, PARAMETER :: VER_CQUAD_NOH=0

      TYPE CQUAD_NOM               ! 200/1:-  unified properties of Quad-nodes
        SEQUENCE
        INTEGER   NGT              !        groupselector
        INTEGER   NR               !        nodenumber
        INTEGER   IEL(1)           !        connecting elements
                                   !        unknwon length!
      END TYPE CQUAD_NOM
      INTEGER, PARAMETER :: LEN_CQUAD_NOM=3
      INTEGER, PARAMETER :: VER_CQUAD_NOM=0

      TYPE CQUAD_NOD               ! 200/1:*  properties of Quad-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      D              ! [1010] minimum thickness of plate on node
        REAL*4      T(3,3)         !        lokal average coordinate system
      END TYPE CQUAD_NOD
      INTEGER, PARAMETER :: LEN_CQUAD_NOD=12
      INTEGER, PARAMETER :: VER_CQUAD_NOD=0

      TYPE CQUAD_EDH               ! 200/2:0  Edges of Quad-elements
        SEQUENCE
        INTEGER   ID1
        INTEGER   ID2
        INTEGER   NEDG
        INTEGER   MQUA             !        max number of quads per edge
      END TYPE CQUAD_EDH
      INTEGER, PARAMETER :: LEN_CQUAD_EDH=4
      INTEGER, PARAMETER :: VER_CQUAD_EDH=0

      TYPE CQUAD_EDG               ! 200/2:+  Edges of Quad-elements
        SEQUENCE
        INTEGER   KA               !        First Node
        INTEGER   KE               !        Last Node
        INTEGER   IJMP             !        bit pattern of jump condition
        INTEGER   NQUA             !        number of quads
        INTEGER   NREL(1)          !        Number of Quad-elements
                                   !        unknwon length!
      END TYPE CQUAD_EDG
      INTEGER, PARAMETER :: LEN_CQUAD_EDG=5
      INTEGER, PARAMETER :: VER_CQUAD_EDG=0

      TYPE CQUAD_TEN               ! 200/5  tendons of Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NRS              !        tendon number
        INTEGER   MNR              !        tendon material
        INTEGER   IBA1             !        construction stage number for placing
        INTEGER   IBA2             !        construction stage number for grouting
        INTEGER   IBA3             !        construction stage number for removing
        REAL*4      R(2)           !        isoparametric coordinates start/end point
        REAL*4      S(2)           !        isoparametric coordinates start/end point
        REAL*4      Z(2)           ! [1011] eccentricity of the middle area
        REAL*4      ZZ(2)          ! [1101] tendon force, start- and endpoint
        REAL*4      AZ             ! [1020] area of tendon
        REAL*4      UZ             ! [1023] effect. periphery
        REAL*4      AH             ! [1020] area of duct
        REAL*4      AR             ! [1012] relative area
        REAL*4      DY(2)          !        gradient of tendon
        REAL*4      DZ(2)          !        gradient of tendon
        REAL*4      EXZ(2)         ! [1011] perpendicular eccentricity of duct to tendon
        REAL*4      EXY(2)         ! [1011] transverse eccentricity of duct to tendon
        REAL*4      SREF(0:1)      !        parameter values along tendon geometry
        REAL*4      XYZT(3,0:1)    ! [1001] Coordinates of tendon start & endpoint
        REAL*4      XYZH(3,0:1)    ! [1001] Coordinates of duct start & endpoint
      END TYPE CQUAD_TEN
      INTEGER, PARAMETER :: LEN_CQUAD_TEN=40
      INTEGER, PARAMETER :: VER_CQUAD_TEN=200501

      TYPE CQUAD_RIM               ! 200/6  Prescribed Reinforcements of Quad-elements
        SEQUENCE
        INTEGER   NRG              !        group number
        INTEGER   NR               !        selector number
        INTEGER   TYP              !        Type of Reinforc.
        INTEGER   GTYP             !        Type of grading
        INTEGER   IDRA             !        drawing source type
        REAL*4      RIO            ! [   5] direction of upside reinforcement
        REAL*4      RIOQ           ! [   5] direction of upside cross reinforcement
        REAL*4      RIOI           ! [   5] direction of upside third reinforcement
        REAL*4      RIU            ! [   5] direction of downside reinforcement
        REAL*4      RIUQ           ! [   5] direction of downside cross reinforcement
        REAL*4      RIUI           ! [   5] direction of downside third reinforcement
        REAL*4      XREF           ! [1001] Reference point for circular reinforcement
        REAL*4      YREF           ! [1001] Reference point for circular reinforcement
        REAL*4      ZREF           ! [1001] Reference point for circular reinforcement
        REAL*4      HIO            ! [1024] distance of upside reinforcement
        REAL*4      HIOQ           ! [1024] distance of upside cross reinforcement
        REAL*4      HIOI           ! [1024] distance of upside third reinforcement
        REAL*4      HIU            ! [1024] distance of downside reinforcement
        REAL*4      HIUQ           ! [1024] distance of downside cross reinforcement
        REAL*4      HIUI           ! [1024] distance of downside third reinforcement
        REAL*4      DIO            ! [1023] Diameter of upside reinforcement
        REAL*4      DIOQ           ! [1023] Diameter of upside cross reinforcement
        REAL*4      DIOI           ! [1023] Diameter of upside third reinforcement
        REAL*4      DIU            ! [1023] Diameter of downside reinforcement
        REAL*4      DIUQ           ! [1023] Diameter of downside cross reinforcement
        REAL*4      DIUI           ! [1023] Diameter of downside third reinforcement
        REAL*4      DSS            ! [1023] Diameter of transverse reinforcement
        REAL*4      ASO            ! [1021] upside Minimum reinforcement (outside)
        REAL*4      ASOQ           ! [1021] upside cross Minimum reinforcement (middle)
        REAL*4      ASOI           ! [1021] upside third Minimum reinforcement (inside)
        REAL*4      ASU            ! [1021] downside Minimum reinforcement (outside)
        REAL*4      ASUQ           ! [1021] downside cross Minimum reinforcement (middle)
        REAL*4      ASUI           ! [1021] downside third Minimum reinforcement (inside)
        REAL*4      ASS            ! [1022] Min stirrup cm2/m2
        REAL*4      AMO            ! [1021] upside Maximum reinforcement (outside)
        REAL*4      AMOQ           ! [1021] upside cross Maximum reinforcement (middle)
        REAL*4      AMOI           ! [1021] upside third Maximum reinforcement (inside)
        REAL*4      AMU            ! [1021] downside Maximum reinforcement (outside)
        REAL*4      AMUQ           ! [1021] downside cross Maximum reinforcement (middle)
        REAL*4      AMUI           ! [1021] downside third Maximum reinforcement (inside)
        REAL*4      AMS            ! [1022] Max stirrup cm2/m2
        REAL*4      WK6(6)         ! [1026] design crack width
        REAL*4      SIG6(6)        ! [1092] SLS steel stress limit
      END TYPE CQUAD_RIM
      INTEGER, PARAMETER :: LEN_CQUAD_RIM=53
      INTEGER, PARAMETER :: VER_CQUAD_RIM=200501

      TYPE CQUAD_RID               ! 200/7:0  Reinforcement Definitions of Quad-elements
        SEQUENCE
        INTEGER   ID               !        identifier (0 = Headder of a definition)
        INTEGER   NRG              !        group number
        INTEGER   NR               !        selector or element number
        INTEGER   BITS             !        Type of grading
        REAL*4      ASS            ! [1022] Min stirrup ratio
        REAL*4      AMS            ! [1022] Max stirrup ratio
        REAL*4      DSS            ! [1023] Diameter of stirrup reinforcements
        INTEGER   EXPP             !        Exposition class at positive face
        INTEGER   EXPN             !        Exposition class at negative face
      END TYPE CQUAD_RID
      INTEGER, PARAMETER :: LEN_CQUAD_RID=9
      INTEGER, PARAMETER :: VER_CQUAD_RID=201603

      TYPE CQUAD_RED               ! 270/0:0  Evaluated Reinforcement Definitions of Elements
        SEQUENCE
        INTEGER   ID               !        identifier (0 = Headder of a definition)
        INTEGER   NRG              !        group number
        INTEGER   NR               !        selector or element number
        INTEGER   BITS             !        Type of grading
        REAL*4      ASS            ! [1022] Min stirrup ratio
        REAL*4      AMS            ! [1022] Max stirrup ratio
        REAL*4      DSS            ! [1023] Diameter of stirrup reinforcements
        INTEGER   EXPP             !        Exposition class at positive face
        INTEGER   EXPN             !        Exposition class at negative face
      END TYPE CQUAD_RED
      INTEGER, PARAMETER :: LEN_CQUAD_RED=9
      INTEGER, PARAMETER :: VER_CQUAD_RED=201603

      TYPE CQUAD_RIL               ! 200/7:+  Reinforcement Layers of Quad-elements
        SEQUENCE
        INTEGER   ID               !        reference for this layer
        INTEGER   DIR              !        Type of local x-direction
        REAL*4      ROT            ! [   5] Angle with reference to the local x-direction
        REAL*4      XDIR           ! [1001] Global reference direction or reference point
        REAL*4      YDIR           ! [1001] Global reference direction or reference point
        REAL*4      ZDIR           ! [1001] Global reference direction or reference point
        REAL*4      H              ! [1011] effective distance according to ID-reference definition
        REAL*4      ASMIN          ! [1021] Min reinforcement value
        REAL*4      ASMAX          ! [1021] Max reinforcement value
        REAL*4      D              ! [1023] Diameter of reinforcements
        REAL*4      SIG            ! [1092] SLS steel stress limit for crack width (optional)
        REAL*4      CRW            ! [1026] design crack width (optional)
      END TYPE CQUAD_RIL
      INTEGER, PARAMETER :: LEN_CQUAD_RIL=12
      INTEGER, PARAMETER :: VER_CQUAD_RIL=201603

      TYPE CQUAD_REL               ! 270/0:+  Evaluated Reinforcement Definitions of Elements
        SEQUENCE
        INTEGER   ID               !        reference for this layer
        INTEGER   DIR              !        Type of local x-direction
        REAL*4      ROT            ! [   5] Angle with reference to the local x-direction
        REAL*4      XDIR           ! [1001] Global reference direction or reference point
        REAL*4      YDIR           ! [1001] Global reference direction or reference point
        REAL*4      ZDIR           ! [1001] Global reference direction or reference point
        REAL*4      H              ! [1011] effective distance according to ID-reference definition
        REAL*4      ASMIN          ! [1021] Min reinforcement value
        REAL*4      ASMAX          ! [1021] Max reinforcement value
        REAL*4      D              ! [1023] Diameter of reinforcements
        REAL*4      SIG            ! [1092] SLS steel stress limit for crack width (optional)
        REAL*4      CRW            ! [1026] design crack width (optional)
      END TYPE CQUAD_REL
      INTEGER, PARAMETER :: LEN_CQUAD_REL=12
      INTEGER, PARAMETER :: VER_CQUAD_REL=201603

      TYPE CQCUT_0                 ! 200/8:0  Header for fabrication areas
        SEQUENCE
        INTEGER   NR               !        identifier = 0
        INTEGER   TYP              !        identifier = 0
        INTEGER   NAR              !        number of areas
        REAL*4      X              ! [1001] x-center
        REAL*4      Y              ! [1001] y-
        REAL*4      AR3D           ! [1002] area in 3D
        REAL*4      AR2D           ! [1002] area in 2D
        REAL*4      AR_0           ! [1002] area stressfree
      END TYPE CQCUT_0
      INTEGER, PARAMETER :: LEN_CQCUT_0=8
      INTEGER, PARAMETER :: VER_CQCUT_0=0

      TYPE CQCUT_NEW               ! 200/8:+  New cutting area
        SEQUENCE
        INTEGER   NR               !        areanumber
        INTEGER   TYP              !        identifier = 0
        INTEGER   LF               !        Loadcase
        REAL*4      X              ! [1001] x-ordinate
        REAL*4      Y              ! [1001] y- center(text)
        REAL*4      AR3D           ! [1002] area in 3D
        REAL*4      AR2D           ! [1002] area in 2D
        REAL*4      AR_0           ! [1002] area stressfree
      END TYPE CQCUT_NEW
      INTEGER, PARAMETER :: LEN_CQCUT_NEW=8
      INTEGER, PARAMETER :: VER_CQCUT_NEW=0

      TYPE CQCUT_DIR               ! 200/8:+  Material direction
        SEQUENCE
        INTEGER   NR               !        areanumber
        INTEGER   TYP              !        Identification
        INTEGER   MNR              !        material no
        REAL*4      ALF            ! [   5] warp direction
        REAL*4      EMOD           ! [1090] E Mod warp direction
        REAL*4      E90            ! [1090] Elasticity modulus perpendicular
      END TYPE CQCUT_DIR
      INTEGER, PARAMETER :: LEN_CQCUT_DIR=6
      INTEGER, PARAMETER :: VER_CQCUT_DIR=0

      TYPE CQCUT_OUT               ! 200/8:+  Vertex of geometric boundary
        SEQUENCE
        INTEGER   NR               !        areanumber
        INTEGER   TYP              !        Identification
        INTEGER   LINE             !        linetype
        REAL*4      X              ! [1001] x-ordinate
        REAL*4      Y              ! [1001] y-ordinate
      END TYPE CQCUT_OUT
      INTEGER, PARAMETER :: LEN_CQCUT_OUT=5
      INTEGER, PARAMETER :: VER_CQCUT_OUT=0

      TYPE CQCUT_IN                ! 200/8:+  Geometry inner lines
        SEQUENCE
        INTEGER   NR               !        areanumber
        INTEGER   TYP              !        Identification
        INTEGER   I_2
        REAL*4      XA             ! [1001] x  startpoint
        REAL*4      YA             ! [1001] y  startpoint
        REAL*4      XE             ! [1001] x  endpoint
        REAL*4      YE             ! [1001] y  endpoint
      END TYPE CQCUT_IN
      INTEGER, PARAMETER :: LEN_CQCUT_IN=7
      INTEGER, PARAMETER :: VER_CQCUT_IN=0

      TYPE CQCUT_WAR               ! 200/8:+  element warp direction
        SEQUENCE
        INTEGER   NR               !        areanumber
        INTEGER   TYP              !        Identification
        INTEGER   NREL             !        orig elem.no
        REAL*4      XA             ! [1001] x  startpoint
        REAL*4      YA             ! [1001] y  startpoint
        REAL*4      XE             ! [1001] x  endpoint
        REAL*4      YE             ! [1001] y  endpoint
        REAL*4      ALF            ! [   5] warp direction
      END TYPE CQCUT_WAR
      INTEGER, PARAMETER :: LEN_CQCUT_WAR=8
      INTEGER, PARAMETER :: VER_CQCUT_WAR=0

      TYPE CTEXTILE                ! 200/9  definition of cutting lines
        SEQUENCE
        INTEGER   IG               !        group selector
        INTEGER   TYP              !        type of line
        REAL*4      XA             ! [1001] line point A
        REAL*4      YA             ! [1001] 
        REAL*4      ZA             ! [1001] 
        REAL*4      XE             ! [1001] line point E
        REAL*4      YE             ! [1001] 
        REAL*4      ZE             ! [1001] 
        REAL*4      NX             ! [1001] projection
        REAL*4      NY             ! [1001] 
        REAL*4      NZ             ! [1001] 
      END TYPE CTEXTILE
      INTEGER, PARAMETER :: LEN_CTEXTILE=11
      INTEGER, PARAMETER :: VER_CTEXTILE=200501

      TYPE CQUAD_P                 ! 200/10  Quad-P-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NODE(4)          !        nodenumbers
        INTEGER   MAT              !        materialnumber
        INTEGER   MRF              !        material Reinf.
        INTEGER   NRA              !        type of element
        INTEGER   EDGE(4)          !        No of geometric property of edge 1-2
        REAL*4      DET(0:2)       !        Parameter of Jacobi Determinant
        REAL*4      THICK(0:4)     ! [1010] element thickness
        REAL*4      CB             !        bedding factor
        REAL*4      CQ             !        tangential bedding factor
        REAL*4      T(3,3)         !        transformation matrix
      END TYPE CQUAD_P
      INTEGER, PARAMETER :: LEN_CQUAD_P=31
      INTEGER, PARAMETER :: VER_CQUAD_P=200501

      TYPE CQUAD_LOA               ! 202/LC  Quad-element loads
        SEQUENCE
        INTEGER   VON              !        start elementnumber
        INTEGER   BIS              !        end elementnumber
        INTEGER   DEL              !        increment
        INTEGER   TYP              !        type of load
        INTEGER   LNR              !        special option value
        REAL*4      P              !        load values
        REAL*4      DPDX
        REAL*4      DPDY
        REAL*4      DPDZ
        REAL*4      XREF           ! [1001] optional reference point for load value to
        REAL*4      YREF           ! [1001] 
        REAL*4      ZREF           ! [1001] 
        REAL*4      TFUN(2,16)     !        optional function of load values across the
      END TYPE CQUAD_LOA
      INTEGER, PARAMETER :: LEN_CQUAD_LOA=44
      INTEGER, PARAMETER :: VER_CQUAD_LOA=200501

      TYPE CQUAD_LPI               ! 203/LC:*  internal single loads on Quad-elements
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   TYP              !        type of load
        REAL*4      PRZ            ! [   8] Percentage of load covered with elements
        REAL*4      S              !        load point in local coordinates
        REAL*4      T              !        load point in local coordinates
        REAL*4      P              !        load value
      END TYPE CQUAD_LPI
      INTEGER, PARAMETER :: LEN_CQUAD_LPI=6
      INTEGER, PARAMETER :: VER_CQUAD_LPI=0

      TYPE CQUAD_LLI               ! 203/LC:*  internal line loads of Quad-elements
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   TYP              !        type of load
        REAL*4      PRZ            ! [   8] 
        REAL*4      SA
        REAL*4      TA
        REAL*4      PA
        REAL*4      SB
        REAL*4      TB
        REAL*4      PB             !        load value end point
      END TYPE CQUAD_LLI
      INTEGER, PARAMETER :: LEN_CQUAD_LLI=9
      INTEGER, PARAMETER :: VER_CQUAD_LLI=0

      TYPE CQUAD_LAI_LPT           !        load points in local coordinates
        SEQUENCE
        REAL*4      S
        REAL*4      T
        REAL*4      P
      END TYPE CQUAD_LAI_LPT
      INTEGER, PARAMETER :: LEN_CQUAD_LAI_LPT=3

      TYPE CQUAD_LAI               ! 203/LC:*  Free area loads on Quad-elements
        SEQUENCE
        INTEGER   NR               !        element number
        INTEGER   TYP              !        type of load
        REAL*4      PRZ            ! [   8] 
        TYPE(CQUAD_LAI_LPT) LPT(63)!        load points in local coordinates
      END TYPE CQUAD_LAI
      INTEGER, PARAMETER :: LEN_CQUAD_LAI=192
      INTEGER, PARAMETER :: VER_CQUAD_LAI=0

      TYPE CQUAD_LT                ! 206/NR  Temperature load profiles for QUADs
        SEQUENCE
        REAL*4      T              ! [  90] Time value
        REAL*4      TEMP(5,0:19)   !        Temperature values
      END TYPE CQUAD_LT
      INTEGER, PARAMETER :: LEN_CQUAD_LT=101
      INTEGER, PARAMETER :: VER_CQUAD_LT=200811

      TYPE CQUAD_FOC               ! 210/LC:0  maximum forces of Quad elements
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force
        REAL*4      VY             ! [1111] shear force
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      HP1            !        yield function
        REAL*4      HP2            !        volum. hardening
      END TYPE CQUAD_FOC
      INTEGER, PARAMETER :: LEN_CQUAD_FOC=11
      INTEGER, PARAMETER :: VER_CQUAD_FOC=200501

      TYPE CQUAD_FOR               ! 210/LC:+  forces of Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force
        REAL*4      VY             ! [1111] shear force
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      SG(8,4)        ! [1112] results in GAUSS-points
        REAL*4      HP1(0:4)       !        yield function
        REAL*4      HP2(0:4)       !        volum. hardening
        REAL*4      HP3(0:4)       !        3rd parameter
      END TYPE CQUAD_FOR
      INTEGER, PARAMETER :: LEN_CQUAD_FOR=56
      INTEGER, PARAMETER :: VER_CQUAD_FOR=200501

      TYPE CQUAD_NFC               ! 211/LC:0  maximum forces in nodes
        SEQUENCE
        INTEGER   NG               !        ident 0 for maximum (first records)
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force
        REAL*4      VY             ! [1111] shear force
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      VX_V           ! [1111] shear force signed
        REAL*4      VY_V           ! [1111] shear force signed
        REAL*4      HP1            !        yield function
      END TYPE CQUAD_NFC
      INTEGER, PARAMETER :: LEN_CQUAD_NFC=13
      INTEGER, PARAMETER :: VER_CQUAD_NFC=200501

      TYPE CQUAD_NFO               ! 211/LC:Z+  Nodal Quad forces
        SEQUENCE
        INTEGER   NG               !        groupselector
        INTEGER   NR               !        nodenumber
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force abs
        REAL*4      VY             ! [1111] shear force abs
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      VX_V           ! [1111] shear force signed
        REAL*4      VY_V           ! [1111] shear force signed
        REAL*4      FY             !        yield function
      END TYPE CQUAD_NFO
      INTEGER, PARAMETER :: LEN_CQUAD_NFO=13
      INTEGER, PARAMETER :: VER_CQUAD_NFO=200501

      TYPE CQUAD_EFC               ! 212/LC:0  maximum error estimates for Quad-elements
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force
        REAL*4      VY             ! [1111] shear force
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      ERR            !        error in energy
      END TYPE CQUAD_EFC
      INTEGER, PARAMETER :: LEN_CQUAD_EFC=10
      INTEGER, PARAMETER :: VER_CQUAD_EFC=200501

      TYPE CQUAD_EFO               ! 212/LC:+  error estimates for Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      MXX            ! [1114] bending moment
        REAL*4      MYY            ! [1114] bending moment
        REAL*4      MXY            ! [1113] torsion moment
        REAL*4      VX             ! [1111] shear force
        REAL*4      VY             ! [1111] shear force
        REAL*4      NX             ! [1112] membran force
        REAL*4      NY             ! [1112] membran force
        REAL*4      NXY            ! [1112] membran force
        REAL*4      HOPT           ! [1001] optimal mesh size
      END TYPE CQUAD_EFO
      INTEGER, PARAMETER :: LEN_CQUAD_EFO=10
      INTEGER, PARAMETER :: VER_CQUAD_EFO=200501

      TYPE CQUAD_BEC               ! 213/LC:0  bedding stresses and results
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      PSE            ! [1155] bedding centre
        REAL*4      PS(4)          ! [1155] bedding in nodes
        REAL*4      PRE            ! [1151] result bedd.force in centre
        REAL*4      PR(4)          ! [1151] result bedd. values in Quad-nodes
        REAL*4      PVE            ! [1003] bedding displacememts in centre
        REAL*4      PV(4)          ! [1003] bedding displacements in nodes
        REAL*4      PTE            ! [1155] tangential bedding in centre
        REAL*4      PT(4)          ! [1155] tangential bedding in nodes
        REAL*4      PTXE           ! [1155] tangential bedding in centre X-component
        REAL*4      PTX(4)         ! [1155] tangential bedding in nodes X-component
        REAL*4      PTYE           ! [1155] tangential bedding in centre Y-component
        REAL*4      PTY(4)         ! [1155] tangential bedding in nodes Y-component
        REAL*4      PTZE           ! [1155] tangential bedding in centre Z-component
        REAL*4      PTZ(4)         ! [1155] tangential bedding in nodes Z-component
        REAL*4      RQ(12)         ! [1151] resulting tangential bedding in nodes
      END TYPE CQUAD_BEC
      INTEGER, PARAMETER :: LEN_CQUAD_BEC=48
      INTEGER, PARAMETER :: VER_CQUAD_BEC=200501

      TYPE CQUAD_BED               ! 213/LC:+  bedding stresses and results
        SEQUENCE
        INTEGER   NR               !        Quadelementnumber
        REAL*4      PSE            ! [1155] bedding centre
        REAL*4      PS(4)          ! [1155] bedding in nodes
        REAL*4      PRE            ! [1151] result bedd.force in centre
        REAL*4      PR(4)          ! [1151] result bedd. values in Quad-nodes
        REAL*4      PVE            ! [1003] bedding displacememts in centre
        REAL*4      PV(4)          ! [1003] bedding displacements in nodes
        REAL*4      PTE            ! [1155] tangential bedding in centre
        REAL*4      PT(4)          ! [1155] tangential bedding in nodes
        REAL*4      PTXE           ! [1155] tangential bedding in centre X-component
        REAL*4      PTX(4)         ! [1155] tangential bedding in nodes X-component
        REAL*4      PTYE           ! [1155] tangential bedding in centre Y-component
        REAL*4      PTY(4)         ! [1155] tangential bedding in nodes Y-component
        REAL*4      PTZE           ! [1155] tangential bedding in centre Z-component
        REAL*4      PTZ(4)         ! [1155] tangential bedding in nodes Z-component
        REAL*4      RQ(12)         ! [1151] resulting tangential bedding in nodes
      END TYPE CQUAD_BED
      INTEGER, PARAMETER :: LEN_CQUAD_BED=48
      INTEGER, PARAMETER :: VER_CQUAD_BED=200501

      TYPE CQUAD_RFX               ! 214/LC  additional information for primary loadcases
        SEQUENCE
        INTEGER   NR               !        Quad-elementnumber
        REAL*4      EPS(5,0:7)     !        strain
        REAL*4      RISS(5,0:7)    !        directions of crack
      END TYPE CQUAD_RFX
      INTEGER, PARAMETER :: LEN_CQUAD_RFX=81
      INTEGER, PARAMETER :: VER_CQUAD_RFX=200501

      TYPE CQUAD_RNC               ! 215/LC:0  nonlinear results of Quad-element
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum
        INTEGER   NMAT             !        type of material behaviour
        REAL*4      ESXO           ! [   9] upside strain
        REAL*4      ESYO           ! [   9] upside strain
        REAL*4      EXYO           ! [   9] upside strain
        REAL*4      ESMO           ! [   9] upside reference strain
        REAL*4      ESXU           ! [   9] downside strain
        REAL*4      ESYU           ! [   9] downside strain
        REAL*4      EXYU           ! [   9] downside strain
        REAL*4      ESMU           ! [   9] downside reference strain
        REAL*4      SXO            ! [1092] upside stress
        REAL*4      SYO            ! [1092] upside stress
        REAL*4      SXYO           ! [1092] upside stress
        REAL*4      SMO            ! [1092] upside reference stress
        REAL*4      SXU            ! [1092] downside stress
        REAL*4      SYU            ! [1092] downside stress
        REAL*4      SXYU           ! [1092] downside stress
        REAL*4      SM_U           ! [1092] downside reference stress
        REAL*4      SGVO           ! [1092] upside reference stress incl. shear
        REAL*4      SGVU           ! [1092] downside reference stress incl. shear
        REAL*4      FY             !        yield function
        REAL*4      FDO            ! [1011] steel - upside yield depth
        REAL*4      FDU            ! [1011] steel - downside yield depth
        REAL*4      I_22
        REAL*4      WR1O           !        concrete - upside direction of crack 1
        REAL*4      WR1U           !        concrete - downside direction of crack 1
        REAL*4      WR2O           !        concrete - upside direction of crack 2
        REAL*4      WR2U           !        concrete - downside direction of crack 2
        REAL*4      SGSO           ! [1092] concrete - upside shear stress on crack
        REAL*4      SGSU           ! [1092] concrete - downside shear stress on crack
        REAL*4      SG1O           ! [1092] concrete - upside steel stress II,dir.1
        REAL*4      SG1U           ! [1092] concrete - downside steel stress II,dir.1
        REAL*4      SG2O           ! [1092] concrete - upside steel stress II,dir. 2
        REAL*4      SG2U           ! [1092] concrete - downside steel stress II,dir.2
        REAL*4      W1O            ! [1026] concrete - upside width of crack,direct. 1
        REAL*4      W1U            ! [1026] concrete - downside width of crack,dir. 1
        REAL*4      W2O            ! [1026] concrete - upside width of crack,direct. 2
        REAL*4      W2U            ! [1026] concrete - downside width of crack,dir. 2
        REAL*4      BRO            !        concrete -upside direction reinforcement
        REAL*4      BRU            !        concrete -downs. direction reinforcement
        REAL*4      XD_X           ! [1011] Minimum compression depth in local x axis
        REAL*4      XD_Y           ! [1011] Minimum compression depth in local y axis
        REAL*4      XD_1           ! [1011] Minimum compression depth at least pressed uniaxial
        REAL*4      XD_2           ! [1011] Minimum compression depth pressed biaxial
        REAL*4      EPSB           ! [   9] Maximum concrete compression strain
        REAL*4      EPSC           ! [   9] Minimum averaged reinforcement strain
        REAL*4      EPST           ! [   9] Maximum averaged reinforcement strain
        REAL*4      SIGC           ! [1092] Maximum concrete compression stress
        REAL*4      SIGT           ! [1092] Maximum concrete tension in the concrete layers
        REAL*4      EPSR           ! [   9] Maximum reinforcement strain in the crack
      END TYPE CQUAD_RNC
      INTEGER, PARAMETER :: LEN_CQUAD_RNC=50
      INTEGER, PARAMETER :: VER_CQUAD_RNC=200501

      TYPE CQUAD_RNO               ! 215/LC:+  nonlinear results of Quad-element
        SEQUENCE
        INTEGER   NR               !        Quad-elementnumber
        INTEGER   NMAT             !        type of material behaviour
        REAL*4      ESXO           ! [   9] upside strain
        REAL*4      ESYO           ! [   9] upside strain
        REAL*4      EXYO           ! [   9] upside strain
        REAL*4      ESMO           ! [   9] upside reference strain
        REAL*4      ESXU           ! [   9] downside strain
        REAL*4      ESYU           ! [   9] downside strain
        REAL*4      EXYU           ! [   9] downside strain
        REAL*4      ESMU           ! [   9] downside reference strain
        REAL*4      SXO            ! [1092] upside stress
        REAL*4      SYO            ! [1092] upside stress
        REAL*4      SXYO           ! [1092] upside stress
        REAL*4      SMO            ! [1092] upside reference stress
        REAL*4      SXU            ! [1092] downside stress
        REAL*4      SYU            ! [1092] downside stress
        REAL*4      SXYU           ! [1092] downside stress
        REAL*4      SM_U           ! [1092] downside reference stress
        REAL*4      SGVO           ! [1092] upside reference stress incl. shear
        REAL*4      SGVU           ! [1092] downside reference stress incl. shear
        REAL*4      FY             !        yield function
        REAL*4      FDO            ! [1011] steel - upside yield depth
        REAL*4      FDU            ! [1011] steel - downside yield depth
        REAL*4      I_22
        REAL*4      WR1O           !        concrete - upside direction of crack 1
        REAL*4      WR1U           !        concrete - downside direction of crack 1
        REAL*4      WR2O           !        concrete - upside direction of crack 2
        REAL*4      WR2U           !        concrete - downside direction of crack 2
        REAL*4      SGSO           ! [1092] concrete - upside shear stress on crack
        REAL*4      SGSU           ! [1092] concrete - downside shear stress on crack
        REAL*4      SG1O           ! [1092] concrete - upside steel stress II,dir.1
        REAL*4      SG1U           ! [1092] concrete - downside steel stress II,dir.1
        REAL*4      SG2O           ! [1092] concrete - upside steel stress II,dir. 2
        REAL*4      SG2U           ! [1092] concrete - downside steel stress II,dir.2
        REAL*4      W1O            ! [1026] concrete - upside width of crack,direct. 1
        REAL*4      W1U            ! [1026] concrete - downside width of crack,dir. 1
        REAL*4      W2O            ! [1026] concrete - upside width of crack,direct. 2
        REAL*4      W2U            ! [1026] concrete - downside width of crack,dir. 2
        REAL*4      BRO            !        concrete -upside direction reinforcement
        REAL*4      BRU            !        concrete -downs. direction reinforcement
        REAL*4      XD_X           ! [1011] Minimum compression depth in local x axis
        REAL*4      XD_Y           ! [1011] Minimum compression depth in local y axis
        REAL*4      XD_1           ! [1011] Minimum compression depth at least pressed uniaxial
        REAL*4      XD_2           ! [1011] Minimum compression depth pressed biaxial
        REAL*4      EPSB           ! [   9] Maximum concrete compression strain
        REAL*4      EPSC           ! [   9] Minimum averaged reinforcement strain
        REAL*4      EPST           ! [   9] Maximum averaged reinforcement strain
        REAL*4      SIGC           ! [1092] Maximum concrete compression stress
        REAL*4      SIGT           ! [1092] Maximum concrete tension in the concrete layers
        REAL*4      EPSR           ! [   9] Maximum reinforcement strain in the crack
      END TYPE CQUAD_RNO
      INTEGER, PARAMETER :: LEN_CQUAD_RNO=50
      INTEGER, PARAMETER :: VER_CQUAD_RNO=200501

      TYPE CQUAD_STC               ! 220/LC:0  maximum Quad-stress
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SVXY           ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      HP1            ! [1092] yield function
        REAL*4      HP2            !        2nd Parameter
        REAL*4      HP3            !        3rd Parameter
        REAL*4      HP4            !        4th Parameter
        REAL*4      HP5            !        5th Parameter
        REAL*4      HP6            !        6th Parameter
      END TYPE CQUAD_STC
      INTEGER, PARAMETER :: LEN_CQUAD_STC=11
      INTEGER, PARAMETER :: VER_CQUAD_STC=200502

      TYPE CQUAD_STP_HTYP          !        = state variables for nonlinear material
        SEQUENCE
        INTEGER   ID
        INTEGER   IDIM
        REAL*4      MAXVAL
      END TYPE CQUAD_STP_HTYP
      INTEGER, PARAMETER :: LEN_CQUAD_STP_HTYP=3

      TYPE CQUAD_STP               ! 220/LC:-  Nonlinear QUAD-stress Headder
        SEQUENCE
        INTEGER   TYP              !        enum of nonlinear parameters as in 1/NR:1/???
        TYPE(CQUAD_STP_HTYP) HTYP(15)!        = state variables for nonlinear material
      END TYPE CQUAD_STP
      INTEGER, PARAMETER :: LEN_CQUAD_STP=46
      INTEGER, PARAMETER :: VER_CQUAD_STP=200501

      TYPE CBRIC_STP_HTYP          !        = state variables for nonlinear material
        SEQUENCE
        INTEGER   ID
        INTEGER   IDIM
        REAL*4      MAXVAL
      END TYPE CBRIC_STP_HTYP
      INTEGER, PARAMETER :: LEN_CBRIC_STP_HTYP=3

      TYPE CBRIC_STP               ! 310/LC:-  Nonlinear BRIC-stress Headder
        SEQUENCE
        INTEGER   TYP              !        enum of nonlinear parameters as in 1/NR:1/???
        TYPE(CBRIC_STP_HTYP) HTYP(15)!        = state variables for nonlinear material
      END TYPE CBRIC_STP
      INTEGER, PARAMETER :: LEN_CBRIC_STP=46
      INTEGER, PARAMETER :: VER_CBRIC_STP=200501

      TYPE CQUAD_STR_SG            !        results in GAUSS-points
        SEQUENCE
        REAL*4      SIGX           ! [1092] 
        REAL*4      SIGY           ! [1092] 
        REAL*4      TAU            ! [1092] 
        REAL*4      SIGZ           ! [1092] 
      END TYPE CQUAD_STR_SG
      INTEGER, PARAMETER :: LEN_CQUAD_STR_SG=4

      TYPE CQUAD_STR               ! 220/LC:+  stresses of Quad-element
        SEQUENCE
        INTEGER   NR               !        Elementnumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        TYPE(CQUAD_STR_SG) SG(4)   !        results in GAUSS-points
        REAL*4      PVX            ! [1192] volume loading
        REAL*4      PVY            ! [1192] volume loading
        REAL*4      PVT            ! [   6] temperature loads
        REAL*4      HP1(0:4)       !        yield function
        REAL*4      HP2(0:4)       !        2nd parameter as specified in headder record
        REAL*4      HP3(0:4)       !        3rd parameter as specified in headder record
        REAL*4      HP4(0:4)       !        4th parameter as specified in headder record
        REAL*4      HP5(0:4)       !        5th parameter as specified in headder record
        REAL*4      HP6(0:4)       !        6th parameter as specified in headder record
        REAL*4      HP7(0:4)       !        7th parameter as specified in headder record
        REAL*4      HP8(0:4)       !        8th parameter as specified in headder record
        REAL*4      HP9(0:4)       !        9th parameter as specified in headder record
        REAL*4      HP10(0:4)      !        10th parameter as specified in headder record
        REAL*4      HP11(0:4)      !        11th parameter as specified in headder record
        REAL*4      HP12(0:4)      !        12th parameter as specified in headder record
        REAL*4      HP13(0:4)      !        13th parameter as specified in headder record
        REAL*4      HP14(0:4)      !        14th parameter as specified in headder record
        REAL*4      HP15(0:4)      !        15th parameter as specified in headder record
      END TYPE CQUAD_STR
      INTEGER, PARAMETER :: LEN_CQUAD_STR=99
      INTEGER, PARAMETER :: VER_CQUAD_STR=200502

      TYPE CQUAD_NSC               ! 221/LC:0  maximum stresses in nodes
        SEQUENCE
        INTEGER   NG               !        ident 0 for maximum (first records)
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SVXY           ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      FY             !        yield function
      END TYPE CQUAD_NSC
      INTEGER, PARAMETER :: LEN_CQUAD_NSC=7
      INTEGER, PARAMETER :: VER_CQUAD_NSC=200501

      TYPE CQUAD_NST               ! 221/LC:Z+  stresses in Quad-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      FY             !        yield function
      END TYPE CQUAD_NST
      INTEGER, PARAMETER :: LEN_CQUAD_NST=7
      INTEGER, PARAMETER :: VER_CQUAD_NST=200501

      TYPE CQUAD_ESC               ! 222/LC:0  max. errors in nodes
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SVXY           ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      ERR            !        error in energy
      END TYPE CQUAD_ESC
      INTEGER, PARAMETER :: LEN_CQUAD_ESC=6
      INTEGER, PARAMETER :: VER_CQUAD_ESC=200501

      TYPE CQUAD_EST               ! 222/LC:+  error estimates of Quad-element stresses
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      TAU            ! [1092] shear stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      HOPT           ! [1002] optimal mesh size
      END TYPE CQUAD_EST
      INTEGER, PARAMETER :: LEN_CQUAD_EST=6
      INTEGER, PARAMETER :: VER_CQUAD_EST=200501

      TYPE CQUAD_RLC               ! 225/LC:0  max Quad-Layer-results
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        INTEGER   MNR              !        ident 0 for maximum (first records)
        REAL*4      XI             !        local-z
        REAL*4      SIGX           ! [1092] stress x
        REAL*4      SIGY           ! [1092] stress y
        REAL*4      TAU            ! [1092] shear stress xy
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TAUX           ! [1092] shear stress vx
        REAL*4      TAUY           ! [1092] shear stress vy
        REAL*4      HP1            !        yield function
        REAL*4      HP2            !        volum. hardening
        REAL*4      HP3            !        damage parameter x
        REAL*4      HP4            !        damage parameter y
        REAL*4      HP5            ! [   3] crack direction 1
        REAL*4      HP6            ! [   3] crack direction 2
        REAL*4      HP7            ! [   9] accumulated temperature strain
        REAL*4      HP8            !        internal damage parameter shrinkage
        REAL*4      HP9            ! [   9] accumulated shrinkage strain
        REAL*4      HP10           !        damage parameter xy
        REAL*4      HP11           ! [   9] epsx  strain in stress strain curve
        REAL*4      HP12           ! [   9] epsy  strain in stress strain curve
        REAL*4      HP13           ! [1215] layer temperature in case of fire analysis
      END TYPE CQUAD_RLC
      INTEGER, PARAMETER :: LEN_CQUAD_RLC=22
      INTEGER, PARAMETER :: VER_CQUAD_RLC=200501

      TYPE CQUAD_RLA_SG            !        results in GAUSS-points
        SEQUENCE
        REAL*4      SIGX           ! [1092] 
        REAL*4      SIGY           ! [1092] 
        REAL*4      TAU            ! [1092] 
        REAL*4      SIGZ           ! [1092] 
        REAL*4      TAUX           ! [1092] 
        REAL*4      TAUY           ! [1092] 
      END TYPE CQUAD_RLA_SG
      INTEGER, PARAMETER :: LEN_CQUAD_RLA_SG=6

      TYPE CQUAD_RLA               ! 225/LC:+  Layer-stresses of Quads
        SEQUENCE
        INTEGER   NR               !        Elementnumber
        INTEGER   MNR              !        Materialnumber MNR>0
        REAL*4      XI             !        local-z
        REAL*4      SIGX           ! [1092] stress x
        REAL*4      SIGY           ! [1092] stress y
        REAL*4      TAU            ! [1092] shear stress xy
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TAUX           ! [1092] shear stress vx
        REAL*4      TAUY           ! [1092] shear stress vy
        TYPE(CQUAD_RLA_SG) SG(4)   !        results in GAUSS-points
        REAL*4      HP1(0:4)       !        yield function
        REAL*4      HP2(0:4)       !        volum. hardening
        REAL*4      HP3(0:4)       !        damage parameter x
        REAL*4      HP4(0:4)       !        damage parameter y
        REAL*4      HP5(0:4)       ! [   3] crack direction 1
        REAL*4      HP6(0:4)       ! [   3] crack direction 2
        REAL*4      HP7(0:4)       ! [   9] accumulated temperature strain
        REAL*4      HP8(0:4)       !        internal damage parameter shrinkage
        REAL*4      HP9(0:4)       ! [   9] accumulated shrinkage strain
        REAL*4      HP10(0:4)      !        damage parameter xy
        REAL*4      HP11(0:4)      ! [   9] epsx  strain in stress strain curve
        REAL*4      HP12(0:4)      ! [   9] epsy  strain in stress strain curve
        REAL*4      HP13(0:4)      ! [1215] layer temperature in case of fire analysis
        REAL*4      HP14(0:4)      ! [1215] max. layer temperature in load history
      END TYPE CQUAD_RLA
      INTEGER, PARAMETER :: LEN_CQUAD_RLA=103
      INTEGER, PARAMETER :: VER_CQUAD_RLA=200501

      TYPE CQUAD_RLB_SG            !        results in GAUSS-points
        SEQUENCE
        REAL*4      SIG1           ! [1092] 
        REAL*4      SIG2           ! [1092] 
        REAL*4      EPS1
        REAL*4      XI1
        REAL*4      XI2
        REAL*4      EPS2
      END TYPE CQUAD_RLB_SG
      INTEGER, PARAMETER :: LEN_CQUAD_RLB_SG=6

      TYPE CQUAD_RLB               ! 225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
        SEQUENCE
        INTEGER   NR               !        Elementnumber
        INTEGER   MNR              !        MNR=-1 identifier for reinforcement data
        REAL*4      XI             !        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
        REAL*4      SIG1           ! [1092] stress in reinforcement 1. layer
        REAL*4      SIG2           ! [1092] stress in reinforcement 2. layer
        REAL*4      EPS1           !        eps strain in stress strain curve 1. layer
        REAL*4      XI1            !        exact xi position 1. layer
        REAL*4      XI2            !        exact xi position 2. layer
        REAL*4      EPS2           !        eps strain in stress strain curve 2. layer
        TYPE(CQUAD_RLB_SG) SG(4)   !        results in GAUSS-points
        REAL*4      HP1(0:4)       !        damage parameter 1. layer
        REAL*4      HP2(0:4)       !        damage parameter 2. layer
        REAL*4      HP3(0:4)       ! [1092] delta-sigma tension stiff. layer 1
        REAL*4      HP4(0:4)       ! [1092] delta-sigma tension stiff. layer 2
        REAL*4      HP5(0:4)       !        direction of reinforcement layer 1
        REAL*4      HP6(0:4)       !        direction of reinforcement layer 2
        REAL*4      HP7(0:4)       ! [   9] accumulated temperature strain
        REAL*4      HP8(0:4)       !        free
        REAL*4      HP9(0:4)       !        free
        REAL*4      HP10(0:4)      ! [1215] layer 1 actual temperature in case of fire analysis
        REAL*4      HP11(0:4)      ! [1215] layer 2 actual temperature in case of fire analysis
      END TYPE CQUAD_RLB
      INTEGER, PARAMETER :: LEN_CQUAD_RLB=88
      INTEGER, PARAMETER :: VER_CQUAD_RLB=200501

      TYPE CQUAD_SEC               ! 229/LC:0  maximum Quad-sectional stress
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] normalstress
        REAL*4      SIGY           ! [1092] transverse stress
        REAL*4      SIGZ           ! [1092] transverse stress
        REAL*4      TAUXY          ! [1092] shear stress
        REAL*4      TAUXZ          ! [1092] shear stress
        REAL*4      TAUYZ          ! [1092] shear stress
      END TYPE CQUAD_SEC
      INTEGER, PARAMETER :: LEN_CQUAD_SEC=7
      INTEGER, PARAMETER :: VER_CQUAD_SEC=200708

      TYPE CQUAD_SEQ               ! 229/LC:-  location of sectional results in master
        SEQUENCE
        INTEGER   NR               !        negative beam number
        REAL*4      X              ! [1001] section along beam
      END TYPE CQUAD_SEQ
      INTEGER, PARAMETER :: LEN_CQUAD_SEQ=2
      INTEGER, PARAMETER :: VER_CQUAD_SEQ=200708

      TYPE CQUAD_SER               ! 229/LC:+  stresses of sectional Quad-elements
        SEQUENCE
        INTEGER   NR               !        Elementnumber
        REAL*4      SIGX           ! [1092] normalstress
        REAL*4      SIGY           ! [1092] transverse stress
        REAL*4      SIGZ           ! [1092] transverse stress
        REAL*4      TAUXY          ! [1092] shear stress
        REAL*4      TAUXZ          ! [1092] shear stress
        REAL*4      TAUYZ          ! [1092] shear stress
      END TYPE CQUAD_SER
      INTEGER, PARAMETER :: LEN_CQUAD_SER=7
      INTEGER, PARAMETER :: VER_CQUAD_SER=200708

      TYPE CQUAD_RT0               ! 230/LC:0  maximum of tendon stresses
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NRS              !        identifier 0
        REAL*4      SIGZ           ! [1092] stress increment
        REAL*4      ZZ             ! [1101] force in tendon
        REAL*4      ZH             ! [1101] duct deduction force
        REAL*4      SZG1           ! [1092] stress in G-point 1
        REAL*4      SZG2           ! [1092] stress in G-point 2
        REAL*4      ZZX1           ! [1101] force tendon+cement1
        REAL*4      ZZX2           ! [1101] force tendon+cement1
        REAL*4      ZHG1           ! [1101] duct deduction G1
        REAL*4      ZHG2           ! [1101] duct deduction G2
        REAL*4      ZZG1           ! [1101] force in tendon G1
        REAL*4      ZZG2           ! [1101] force in tendon G2
        REAL*4      AGE            ! [  93] age since prestress
        REAL*4      RELZ           !        accumulated relaxation
        REAL*4      TZG1           ! [1215] temperature tendon G1
        REAL*4      TZG2           ! [1215] temperature tendon G2
        REAL*4      THG1           ! [1215] temperature tendon duct G1
        REAL*4      THG2           ! [1215] temperature tendon duct G2
      END TYPE CQUAD_RT0
      INTEGER, PARAMETER :: LEN_CQUAD_RT0=19
      INTEGER, PARAMETER :: VER_CQUAD_RT0=200501

      TYPE CQUAD_RTS               ! 230/LC:+  tendon stresses in two integration points
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NRS              !        tendonnumber
        REAL*4      SIGZ           ! [1092] stress increment
        REAL*4      ZZ             ! [1101] force in tendon
        REAL*4      ZH             ! [1101] duct deduction force
        REAL*4      SZG1           ! [1092] stress in G-point 1
        REAL*4      SZG2           ! [1092] stress in G-point 2
        REAL*4      ZZX1           ! [1101] force tendon+cement1
        REAL*4      ZZX2           ! [1101] force tendon+cement1
        REAL*4      ZHG1           ! [1101] duct deduction G1
        REAL*4      ZHG2           ! [1101] duct deduction G2
        REAL*4      ZZG1           ! [1101] force in tendon G1
        REAL*4      ZZG2           ! [1101] force in tendon G2
        REAL*4      AGE            ! [  93] age since prestress
        REAL*4      RELZ           !        accumulated relaxation
        REAL*4      TZG1           ! [1215] temperature tendon G1
        REAL*4      TZG2           ! [1215] temperature tendon G2
        REAL*4      THG1           ! [1215] temperature tendon duct G1
        REAL*4      THG2           ! [1215] temperature tendon duct G2
      END TYPE CQUAD_RTS
      INTEGER, PARAMETER :: LEN_CQUAD_RTS=19
      INTEGER, PARAMETER :: VER_CQUAD_RTS=200501

      TYPE CQUAD_DST               ! 250/DC:+  design stresses in Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      SMIO           ! [1092] minimum upside main stress
        REAL*4      SMAO           ! [1092] maximum upside main stress
        REAL*4      SMIU           ! [1092] minimum downside main stress
        REAL*4      SMAU           ! [1092] maximum downside main stress
        REAL*4      TAUM           ! [1092] maximum shear stress
        REAL*4      SVMA           ! [1092] maximum reference stress
        REAL*4      SVO            ! [1092] maximum reference stress upside
        REAL*4      SVU            ! [1092] maximum reference stress downside
        REAL*4      RESERVED(7)    !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CQUAD_DST
      INTEGER, PARAMETER :: LEN_CQUAD_DST=33
      INTEGER, PARAMETER :: VER_CQUAD_DST=200501

      TYPE CQUAD_NDS               ! 251/DC:Z+  design stresses in Quad-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      SMIO           ! [1092] minimum upside main stress Minimale Hauptspannung oben
        REAL*4      SMAO           ! [1092] maximum upside main stress Maximale Hauptspannung oben
        REAL*4      SMIU           ! [1092] minimum downside main stress Minimale Hauptspannung unten
        REAL*4      SMAU           ! [1092] maximum downside main stress Maximale Hauptspannung unten
        REAL*4      TAUM           ! [1092] maximum shear stress
        REAL*4      SVMA           ! [1092] maximum reference stress
        REAL*4      SVO            ! [1092] maximum reference stress upside
        REAL*4      SVU            ! [1092] maximum reference stress downside
        REAL*4      RESERVED(7)    !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of designcase
      END TYPE CQUAD_NDS
      INTEGER, PARAMETER :: LEN_CQUAD_NDS=34
      INTEGER, PARAMETER :: VER_CQUAD_NDS=200501

      TYPE CQUAD_RIC               ! 260/DC:0  maximum reinforcement in Quad-elements
        SEQUENCE
        INTEGER   NR               !        ident 0
        REAL*4      ASO            ! [1021] upside reinforcement (outside)
        REAL*4      ASOQ           ! [1021] upside cross reinforcement (middle)
        REAL*4      ASU            ! [1021] downside reinforcement (outside)
        REAL*4      ASUQ           ! [1021] downside cross reinforcement (middle)
        REAL*4      ASOI           ! [1021] upside third reinforcement (inside)
        REAL*4      ASUI           ! [1021] downside third reinforcement (inside)
        REAL*4      ASS            ! [1022] stirrup cm2/m2
        REAL*4      ASSE           ! [1020] stirrup cm2
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      SIXO           ! [1030] upside reinforcement quantity
        REAL*4      SIXU           ! [1030] downside reinforcement quantity
        REAL*4      SIXS           ! [1030] shear reinforcement quantity
        REAL*4      FREE0(3)       !        not yet used
        REAL*4      ZMIN           ! [1001] minimum lever arm
        REAL*4      VEDR           !        max. VED/VRDMAX
        REAL*4      COTT           !        max. cot_theta
        REAL*4      VED            !        max. VED
        REAL*4      VM             ! [1001] shift rule
        REAL*4      SDO(3)         ! [1092] upside stress range (outside)
        REAL*4      SDU(3)         ! [1092] downside stress range (inside)
        REAL*4      SDV            ! [1092] stirrup stress range
        REAL*4      SSO(3)         ! [1092] maximum stell stress upside (outside)
        REAL*4      SSU(3)         ! [1092] maximum stell stress downside(inside)
        REAL*4      SSV            ! [1092] maximum stirrup stress (not yet used)
        REAL*4      SIGBO          ! [1092] maximum concrete pressure upside (outside)
        REAL*4      SIGBU          ! [1092] maximum concrete pressure downside(inside)
        REAL*4      SHZMAX         !        maximum skew principal tensile stress
        REAL*4      SHZX           !        max. skew principal tensile stress in local x
        REAL*4      SHZY           !        max. skew principal tensile stress in local y
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      ASBEND(6)      ! [1021] Info reinforcement bending design only
        REAL*4      ASPLUS(6)      ! [1021] Info reinforcement if increased due to shear
        REAL*4      ASPOSS(6)      ! [1021] Info reinforcement to satisfy shear without stirrups
        REAL*4      BMOM(6)        ! [1114] Design bending moment in direction of reinforcement
        REAL*4      ORIGIN(7)      !        bitpattern of origins of maximum reinforcements
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons
        REAL*4      WK6(6)         ! [1026] crack width  reinforcement
        REAL*4      RESERVED(4)    !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of designcase
      END TYPE CQUAD_RIC
      INTEGER, PARAMETER :: LEN_CQUAD_RIC=101
      INTEGER, PARAMETER :: VER_CQUAD_RIC=200501

      TYPE CQUAD_REI               ! 260/DC:+  reinforcement in Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      ASO            ! [1021] upside reinforcement (outside)
        REAL*4      ASOQ           ! [1021] upside cross reinforcement (middle)
        REAL*4      ASU            ! [1021] downside reinforcement (outside)
        REAL*4      ASUQ           ! [1021] downside cross reinforcement (middle)
        REAL*4      ASOI           ! [1021] upside third reinforcement (inside)
        REAL*4      ASUI           ! [1021] downside third reinforcement (inside)
        REAL*4      ASS            ! [1022] stirrup cm2/m2
        REAL*4      ASSE           ! [1020] stirrup cm2
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      RIO            !        direction of upside reinforcement
        REAL*4      RIOQ           !        direction of upside cross reinforcement
        REAL*4      RIU            !        direction of downside reinforcement
        REAL*4      RIUQ           !        direction of downside cross reinforcement
        REAL*4      RIOI           !        direction of upside third reinforcement
        REAL*4      RIUI           !        direction of downside third reinforcement
        REAL*4      ZMIN           ! [1001] minimum lever arm (ULS design)
        REAL*4      VEDR           !        max. VED/VRDMAX (ULS design)
        REAL*4      COTT           !        max. cot_theta (ULS design)
        REAL*4      VED            !        max. VED (ULS design)
        REAL*4      VM             ! [1001] shift rule
        REAL*4      SDO(3)         ! [1092] upside stress range (outside)
        REAL*4      SDU(3)         ! [1092] downside stress range (inside)
        REAL*4      SDV            ! [1092] stirrup stress range
        REAL*4      SSO(3)         ! [1092] maximum stell stress upside (outside)
        REAL*4      SSU(3)         ! [1092] maximum stell stress downside(inside)
        REAL*4      SSV            ! [1092] maximum stirrup stress (not yet used)
        REAL*4      SIGBO          ! [1092] maximum concrete pressure upside (outside)
        REAL*4      SIGBU          ! [1092] maximum concrete pressure downside(inside)
        REAL*4      SHZMAX         !        maximum skew principal tensile stress (SLS uncracked)
        REAL*4      SHZX           !        max. skew principal tensile stress in local x
        REAL*4      SHZY           !        max. skew principal tensile stress in local y
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      ASBEND(6)      ! [1021] Info reinforcement bending design only (ULS design)
        REAL*4      ASPLUS(6)      ! [1021] Info reinforcement if increased due to shear (ULS design)
        REAL*4      ASPOSS(6)      ! [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        REAL*4      BMOM(6)        ! [1114] Design bending moment in direction of reinforcement
        REAL*4      ORIGIN(7)      !        origin of maximum reinforcement:
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons
        REAL*4      WK6(6)         ! [1026] crack width  reinforcement
      END TYPE CQUAD_REI
      INTEGER, PARAMETER :: LEN_CQUAD_REI=80
      INTEGER, PARAMETER :: VER_CQUAD_REI=200501

      TYPE CQUAD_NRC               ! 261/DC:0  maximum reinforcement in Quad-nodes
        SEQUENCE
        INTEGER   NR               !        ident 0
        INTEGER   NG               !        ident 0
        REAL*4      ASO            ! [1021] upside reinforcement (outside)
        REAL*4      ASOQ           ! [1021] upside cross reinforcement (middle)
        REAL*4      ASU            ! [1021] downside reinforcement (outside)
        REAL*4      ASUQ           ! [1021] downside cross reinforcement (middle)
        REAL*4      ASOI           ! [1021] upside third reinforcement (inside)
        REAL*4      ASUI           ! [1021] downside third reinforcement (inside)
        REAL*4      ASS            ! [1022] stirrup cm2/m2
        REAL*4      I_8            !        reserved 0.0
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      FREE0(6)       !        not yet used
        REAL*4      ZMIN           ! [1001] minimum lever arm
        REAL*4      VEDR           !        max. VED/VRDMAX
        REAL*4      COTT           !        max. cot_theta
        REAL*4      VED            !        max. VED
        REAL*4      VM             ! [1001] shift rule
        REAL*4      SDO(3)         ! [1092] upside stress range (outside)
        REAL*4      SDU(3)         ! [1092] downside stress range (inside)
        REAL*4      SDV            ! [1092] stirrup stress range
        REAL*4      SSO(3)         ! [1092] maximum stell stress upside (outside)
        REAL*4      SSU(3)         ! [1092] maximum stell stress downside(inside)
        REAL*4      SSV            ! [1092] maximum stirrup stress (not yet used)
        REAL*4      SIGBO          ! [1092] maximum concrete pressure upside (outside)
        REAL*4      SIGBU          ! [1092] maximum concrete pressure downside(inside)
        REAL*4      SHZMAX         !        maximum skew principal tensile stress
        REAL*4      SHZX           !        max. skew principal tensile stress in local x
        REAL*4      SHZY           !        max. skew principal tensile stress in local y
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      ASBEND(6)      ! [1021] Info reinforcement bending design only
        REAL*4      ASPLUS(6)      ! [1021] Info reinforcement if increased due to shear
        REAL*4      ASPOSS(6)      ! [1021] Info reinforcement to satisfy shear without stirrups
        REAL*4      BMOM(6)        ! [1114] Design bending moment in direction of reinforcement
        REAL*4      ORIGIN(7)      !        bitpattern of origins of maximum reinforcements
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons
        REAL*4      WK6(6)         ! [1026] crack width  reinforcement
        REAL*4      RESERVED(4)    !        reserved for future usage
        INTEGER   TEXT(17)         !        Designation of Designcase
      END TYPE CQUAD_NRC
      INTEGER, PARAMETER :: LEN_CQUAD_NRC=102
      INTEGER, PARAMETER :: VER_CQUAD_NRC=200501

      TYPE CQUAD_NRI               ! 261/DC:Z+  reinforcement in Quad-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      ASO            ! [1021] upside reinforcement (outside)
        REAL*4      ASOQ           ! [1021] upside cross reinforcement (middle)
        REAL*4      ASU            ! [1021] downside reinforcement (outside)
        REAL*4      ASUQ           ! [1021] downside cross reinforcement (middle)
        REAL*4      ASOI           ! [1021] upside third reinforcement (inside)
        REAL*4      ASUI           ! [1021] downside third reinforcement (inside)
        REAL*4      ASS            ! [1022] stirrup cm2/m2
        REAL*4      I_8            !        reserved 0.0
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      RIO            !        direction of upside reinforcement
        REAL*4      RIOQ           !        direction of upside cross reinforcement
        REAL*4      RIU            !        direction of downside reinforcement
        REAL*4      RIUQ           !        direction of downside cross reinforcement
        REAL*4      RIOI           !        direction of upside third reinforcement
        REAL*4      RIUI           !        direction of downside third reinforcement
        REAL*4      ZMIN           ! [1001] minimum lever arm
        REAL*4      VEDR           !        max. VED/VRDMAX
        REAL*4      COTT           !        max. cot_theta
        REAL*4      VED            !        max. VED
        REAL*4      VM             ! [1001] shift rule
        REAL*4      SDO(3)         ! [1092] upside stress range (outside)
        REAL*4      SDU(3)         ! [1092] downside stress range (inside)
        REAL*4      SDV            ! [1092] stirrup stress range
        REAL*4      SSO(3)         ! [1092] maximum stell stress upside (outside)
        REAL*4      SSU(3)         ! [1092] maximum stell stress downside(inside)
        REAL*4      SSV            ! [1092] maximum stirrup stress (not yet used)
        REAL*4      SIGBO          ! [1092] maximum concrete pressure upside (outside)
        REAL*4      SIGBU          ! [1092] maximum concrete pressure downside(inside)
        REAL*4      SHZMAX         !        maximum skew principal tensile stress
        REAL*4      SHZX           !        max. skew principal tensile stress in local x
        REAL*4      SHZY           !        max. skew principal tensile stress in local y
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      ASBEND(6)      ! [1021] Info reinforcement bending design only
        REAL*4      ASPLUS(6)      ! [1021] Info reinforcement if increased due to shear
        REAL*4      ASPOSS(6)      ! [1021] Info reinforcement to satisfy shear without stirrups
        REAL*4      BMOM(6)        ! [1114] Design bending moment in direction of reinforcement
        REAL*4      ORIGIN(7)      !        origin of maximum reinforcement
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons
        REAL*4      WK6(6)         ! [1026] crack width  reinforcement
      END TYPE CQUAD_NRI
      INTEGER, PARAMETER :: LEN_CQUAD_NRI=81
      INTEGER, PARAMETER :: VER_CQUAD_NRI=200501

      TYPE CQUAD_NRP               ! 262/DC:+  punching reinforcement in nodes
        SEQUENCE
        INTEGER   NR               !        nodenumber
        INTEGER   ISTA             !        state of force
        INTEGER   IDUS             !        punching state
        REAL*4      U0             ! [1001] effective length of first perimeter
        REAL*4      REDO           !        reduction factor for openings/free edges
        REAL*4      V              ! [1151] punching force
        REAL*4      ASL            ! [1020] required longitudinal reinforcement
        REAL*4      ASV1           ! [1022] shear reinforcement within 1st perimeter
        REAL*4      ASV2           ! [1022] shear reinforcement within 2nd perimeter
        REAL*4      ASV3           ! [1022] shear reinforcement within 3rd perimeter
        REAL*4      ASV4           ! [1022] shear reinforcement within 4th perimeter
        REAL*4      FREE0(5)       !        not yet used
        INTEGER   TXT1(16)         !        Halfen Description 1 (30 chars require n/2+1 words)
        INTEGER   TXT2(16)         !        Halfen Description 2
        INTEGER   TXT3(16)         !        Halfen Description 3
      END TYPE CQUAD_NRP
      INTEGER, PARAMETER :: LEN_CQUAD_NRP=64
      INTEGER, PARAMETER :: VER_CQUAD_NRP=200501

      TYPE CQUAD_PUN               ! 262/DC:0  punching periphery
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   ID               !        identifier 0
        INTEGER   TYP              !        type of line
        REAL*4      X1             ! [1001] Coordinates of start point
        REAL*4      Y1             ! [1001] 
        REAL*4      Z1             ! [1001] 
        REAL*4      X2             ! [1001] Coordinates of end point
        REAL*4      Y2             ! [1001] 
        REAL*4      Z2             ! [1001] 
      END TYPE CQUAD_PUN
      INTEGER, PARAMETER :: LEN_CQUAD_PUN=9
      INTEGER, PARAMETER :: VER_CQUAD_PUN=200501

      TYPE CQUAD_PU1               ! 262/DC:0  punching parameters
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   ID               !        identifier 1
        INTEGER   KDUST(199)       !        Integer-punching parameters
        REAL*4      RDUST(299)     !        Real-punching parameters
      END TYPE CQUAD_PU1
      INTEGER, PARAMETER :: LEN_CQUAD_PU1=500
      INTEGER, PARAMETER :: VER_CQUAD_PU1=200501

      TYPE CQUAD_RD0               ! 265/DC:0  maximum of tendon stresses in the design
        SEQUENCE
        INTEGER   NR               !        identifier 0
        INTEGER   NRS              !        identifier 0
        REAL*4      SMAX           ! [1092] maximum design stress
        REAL*4      SMIN           ! [1092] minimum design stress
        REAL*4      PERM           ! [1092] permanent stress
      END TYPE CQUAD_RD0
      INTEGER, PARAMETER :: LEN_CQUAD_RD0=5
      INTEGER, PARAMETER :: VER_CQUAD_RD0=200501

      TYPE CQUAD_RTD               ! 265/DC:+  tendon stress in the design
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NRS              !        tendonnumber
        REAL*4      SMAX           ! [1092] maximum design stress
        REAL*4      SMIN           ! [1092] minimum design stress
        REAL*4      PERM           ! [1092] permanent stress
      END TYPE CQUAD_RTD
      INTEGER, PARAMETER :: LEN_CQUAD_RTD=5
      INTEGER, PARAMETER :: VER_CQUAD_RTD=200501

      TYPE CQUAD_REE               ! 270/DC:0  maximum design values in Quad-elements
        SEQUENCE
        INTEGER   NG               !        ident 0
        INTEGER   NR               !        ident 0
        INTEGER   ID               !        activated layers: -(nupper +100*nlower +10000*ncentric)
        INTEGER   ORIG             !        origin - error messages:
        REAL*4      SIGC(2)        ! [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
        REAL*4      SIGCD(2)       ! [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
        REAL*4      SHZ(3)         ! [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
        REAL*4      SIGS(3)        ! [1092] maximum SLS reinforcement stress for center/upside/downside
        REAL*4      SIGSD(3)       ! [1092] maximum SLS reinforcement stress range for center/upside/downsi
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons upside/downsid
        REAL*4      ZMIN           ! [1001] minimum lever arm (ULS design)
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      ASS            ! [1022] stirrup reinforcement ratio
        REAL*4      VEDR           !        max. VED/VRDMAX (ULS design)
        REAL*4      COTT           !        max. cot_theta (ULS design)
        REAL*4      VED            !        max. VED (ULS design)
        REAL*4      VM             ! [1001] shift rule
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      OPT(15)        !        reserved
        REAL*4      SUMO           ! [1030] upside reinforcement quantity
        REAL*4      SUMU           ! [1030] downside reinforcement quantity
        REAL*4      SUMM           ! [1030] centric reinforcement quantity
        REAL*4      SUMS           ! [1030] shear reinforcement quantity
        INTEGER   TEXT(17)         !        Designation of designcase
      END TYPE CQUAD_REE
      INTEGER, PARAMETER :: LEN_CQUAD_REE=63
      INTEGER, PARAMETER :: VER_CQUAD_REE=201603

      TYPE CQUAD_RNE               ! 271/DC:0  maximum design values in Nodes of Quad-elements
        SEQUENCE
        INTEGER   NG               !        ident 0
        INTEGER   NR               !        ident 0
        INTEGER   ID               !        activated layers: -(nupper +100*nlower +10000*ncentric)
        INTEGER   ORIG             !        origin - error messages:
        REAL*4      SIGC(2)        ! [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
        REAL*4      SIGCD(2)       ! [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
        REAL*4      SHZ(3)         ! [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
        REAL*4      SIGS(3)        ! [1092] maximum SLS reinforcement stress for center/upside/downside
        REAL*4      SIGSD(3)       ! [1092] maximum SLS reinforcement stress range for center/upside/downsi
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons upside/downsid
        REAL*4      ZMIN           ! [1001] minimum lever arm (ULS design)
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      ASS            ! [1022] stirrup reinforcement ratio
        REAL*4      VEDR           !        max. VED/VRDMAX (ULS design)
        REAL*4      COTT           !        max. cot_theta (ULS design)
        REAL*4      VED            !        max. VED (ULS design)
        REAL*4      VM             ! [1001] shift rule
        REAL*4      UTILC          !        max. utilization fatigue check concrete
        REAL*4      OPT(15)        !        reserved
        REAL*4      SUMO           ! [1030] upside reinforcement quantity
        REAL*4      SUMU           ! [1030] downside reinforcement quantity
        REAL*4      SUMM           ! [1030] centric reinforcement quantity
        REAL*4      SUMS           ! [1030] shear reinforcement quantity
        INTEGER   TEXT(17)         !        Designation of designcase
      END TYPE CQUAD_RNE
      INTEGER, PARAMETER :: LEN_CQUAD_RNE=63
      INTEGER, PARAMETER :: VER_CQUAD_RNE=201603

      TYPE CQUAD_REM               ! 270/DC:0  maximum reinforcement results in Quad-elements
        SEQUENCE
        INTEGER   NG               !        ident 0
        INTEGER   NR               !        ident 0
        INTEGER   ID               !        +1 identifier for reincorcement
        INTEGER   ORIG             !        origin of maximum reinforcement, see QUAD_REA for Details
        REAL*4      ASO            ! [1021] reinforcement area
        REAL*4      SDO(3)         ! [1092] reinforcement stress SLS
        REAL*4      ASBEND         ! [1021] Info reinforcement bending design only (ULS design)
        REAL*4      ASPLUS         ! [1021] Info reinforcement if increased due to shear (ULS design)
        REAL*4      ASPOSS         ! [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        REAL*4      BMOM           ! [1114] Design bending moment in direction of reinforcement
        REAL*4      WK             ! [1026] crack width
      END TYPE CQUAD_REM
      INTEGER, PARAMETER :: LEN_CQUAD_REM=13
      INTEGER, PARAMETER :: VER_CQUAD_REM=201603

      TYPE CQUAD_REA               ! 270/DC:Z+  General Concrete Design Results
        SEQUENCE
        INTEGER   NG               !        group number (for nodal results)
        INTEGER   NR               !        element number
        INTEGER   ID               !        ident 0 : concrete results
        INTEGER   ORIG             !        origin of maximum reinforcement:
        REAL*4      SIGO(3)        ! [1092] stress of concrete pressure upside (Z-)
        REAL*4      SIGU(3)        ! [1092] stress of concrete pressure downside (Z+)
        REAL*4      SHZMAX         !        maximum skew principal tensile stress (SLS uncracked)
        REAL*4      SHZX           !        max. skew principal tensile stress in local x
        REAL*4      SHZY           !        max. skew principal tensile stress in local y
        REAL*4      ZMIN           ! [1001] minimum lever arm (ULS design)
        REAL*4      DECO(2)        ! [   9] decompression strain in the direction of tendons
        REAL*4      SUMO           ! [1021] upside reinforcement quantity
        REAL*4      SUMU           ! [1021] downside reinforcement quantity
        REAL*4      SUMM           ! [1021] shear reinforcement quantity
        REAL*4      TAU0           ! [1092] design shear stress (shear force)
        REAL*4      ASS            ! [1022] stirrup reinforcement ratio
        REAL*4      VEDR           !        max. VED/VRDMAX (ULS design)
        REAL*4      COTT           !        max. cot_theta (ULS design)
        REAL*4      VED            !        max. VED (ULS design)
        REAL*4      VM             ! [1001] shift rule
        REAL*4      UTILC          !        max. utilization fatigue check concrete
      END TYPE CQUAD_REA
      INTEGER, PARAMETER :: LEN_CQUAD_REA=26
      INTEGER, PARAMETER :: VER_CQUAD_REA=201603

      TYPE CQUAD_RER               ! 270/DC:Z+  Reinforcement Layer Design Results
        SEQUENCE
        INTEGER   NG               !        group number (for nodal results)
        INTEGER   NR               !        element number
        INTEGER   ID               !        identifier of reincorcement layer
        INTEGER   ORIG             !        origin of maximum reinforcement, see QUAD_REA for Details
        REAL*4      ASO            ! [1021] reinforcement area
        REAL*4      SDO(3)         ! [1092] reinforcement stress SLS
        REAL*4      ASBEND         ! [1021] Info reinforcement bending design only (ULS design)
        REAL*4      ASPLUS         ! [1021] Info reinforcement if increased due to shear (ULS design)
        REAL*4      ASPOSS         ! [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        REAL*4      BMOM           ! [1114] Design bending moment in direction of reinforcement
        REAL*4      WK             ! [1026] crack width
      END TYPE CQUAD_RER
      INTEGER, PARAMETER :: LEN_CQUAD_RER=13
      INTEGER, PARAMETER :: VER_CQUAD_RER=201603

      TYPE CQUAD_CFD               ! 290/LC  Fluid flow results in Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      VX             ! [1212] velocity
        REAL*4      VY             ! [1212] velocity
        REAL*4      VZ             ! [1212] velocity
        REAL*4      Q              ! [1211] stream quantity
        REAL*4      HOPT           ! [1001] Boundary layer
        REAL*4      VXA            ! [1212] particle velocity
        REAL*4      VYA            ! [1212] particle velocity
        REAL*4      VZA            ! [1212] particle velocity
        REAL*4      MUED           ! [1220] laminar viscosity
        REAL*4      DUX(2)         ! [  95] gradient values of fluid flow du/dx, du/dy
        REAL*4      DVX(2)         ! [  95] gradient values of fluid flow dv/dx, dv/dy
        REAL*4      TK             ! [1222] turbulent energy
        REAL*4      MUET           ! [1220] turbulent viscosity
        REAL*4      ED             ! [1223] dissipation rate
        REAL*4      SCALAR(4)      !        optional scalar values
      END TYPE CQUAD_CFD
      INTEGER, PARAMETER :: LEN_CQUAD_CFD=21
      INTEGER, PARAMETER :: VER_CQUAD_CFD=201108

      TYPE CQUAD_TM                ! 291/LC:0  Maximum of Temperature Results in Quads
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      QX             ! [1218] heat flux
        REAL*4      QY             ! [1218] heat flux
        REAL*4      QZ             ! [1218] heat flux
        REAL*4      Q              ! [1216] Total flux
        REAL*4      HOPT           ! [1001] optimal mesh size
        REAL*4      TEFF           ! [  92] Effective Age
        REAL*4      HYDR           !        Hydration degree
        REAL*4      LFR            !        Liquid fraction
      END TYPE CQUAD_TM
      INTEGER, PARAMETER :: LEN_CQUAD_TM=9
      INTEGER, PARAMETER :: VER_CQUAD_TM=200501

      TYPE CQUAD_TMP               ! 291/LC  Temperature Results in Quad-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      QX             ! [1218] heat flux
        REAL*4      QY             ! [1218] heat flux
        REAL*4      QZ             ! [1218] heat flux
        REAL*4      Q              ! [1216] Total flux
        REAL*4      HOPT           ! [1001] optimal mesh size
        REAL*4      TEFF(0:4)      ! [  92] Effective Age
        REAL*4      HYDR(0:4)      !        Hydratation degree
        REAL*4      LFR(0:4)       !        Liquid fraction
      END TYPE CQUAD_TMP
      INTEGER, PARAMETER :: LEN_CQUAD_TMP=21
      INTEGER, PARAMETER :: VER_CQUAD_TMP=200501

      TYPE CBRIC                   ! 300/00  Bric-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NODE(8)          !        nodenumbers
        INTEGER   MAT              !        materialnumber
        INTEGER   NRA              !        type of element
        REAL*4      DET(0:3)       !        Values of Jacobian Determinant / Volume
      END TYPE CBRIC
      INTEGER, PARAMETER :: LEN_CBRIC=15
      INTEGER, PARAMETER :: VER_CBRIC=200501

      TYPE CBRIC_SU                ! 300/02:0  Surfaces and Neighbours of Bric-elements
        SEQUENCE
        INTEGER   N0(4)
        INTEGER   NSUR
        INTEGER   MBRI             !        max number of brics per surface
      END TYPE CBRIC_SU
      INTEGER, PARAMETER :: LEN_CBRIC_SU=6
      INTEGER, PARAMETER :: VER_CBRIC_SU=200502

      TYPE CBRIC_SUR               ! 300/02:+  Surfaces and Neighbours of Bric-elements
        SEQUENCE
        INTEGER   NODE(4)
        INTEGER   IJMP
        INTEGER   NBRI
        INTEGER   NREL(7)          !        bric numbers for this surface
      END TYPE CBRIC_SUR
      INTEGER, PARAMETER :: LEN_CBRIC_SUR=13
      INTEGER, PARAMETER :: VER_CBRIC_SUR=200502

      TYPE CBRIC_RIM               ! 300/6  Prescribed Reinforcements of Bric-elements
        SEQUENCE
        INTEGER   NRG              !        group number
        INTEGER   NR               !        selector number
        INTEGER   TYP              !        Type of Reinforc.
        INTEGER   GTYP             !        Type of grading
        INTEGER   IDRA             !        drawing source type
        REAL*4      OAL            !        Euler Angle I reinforcement
        REAL*4      OAF            !        Euler Angle II
        REAL*4      XREF           ! [1001] Reference point for circular reinforcement
        REAL*4      YREF           ! [1001] XREF+YREF allowed in combination with OAL and OAF
        REAL*4      ZREF           ! [1001] ZREF<>RW only allowed for OAL=OAF=0
        REAL*4      DI(3)          ! [1023] Diameter of reinforcement 1-3
        REAL*4      AS(3)          ! [1022] Minimum reinforcement 1-3
        REAL*4      AM(3)          ! [1022] Maximum reinforcement 1-3
        REAL*4      WK(3)          ! [1026] design crack width
        REAL*4      SIG(3)         ! [1092] SLS steel stress limit
      END TYPE CBRIC_RIM
      INTEGER, PARAMETER :: LEN_CBRIC_RIM=25
      INTEGER, PARAMETER :: VER_CBRIC_RIM=200904

      TYPE CBRIC_P                 ! 300/10  Bric-P-Elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        INTEGER   NODE(8)          !        nodenumbers
        INTEGER   MAT              !        materialnumber
        INTEGER   EDGE(12)         !        geometric id of edge 1-2
        INTEGER   FACE(6)          !        geometric id of face 1-2-3-4
      END TYPE CBRIC_P
      INTEGER, PARAMETER :: LEN_CBRIC_P=28
      INTEGER, PARAMETER :: VER_CBRIC_P=200501

      TYPE CBRIC_LOA               ! 302/LC  loads of Bric-elements
        SEQUENCE
        INTEGER   VON              !        start elementnumber
        INTEGER   BIS              !        end elementnumber
        INTEGER   DEL              !        increment
        INTEGER   TYP              !        type of load
        INTEGER   LNR              !        primary loadcasenumber,if TYP = 18/30
        REAL*4      P              !        load value
        REAL*4      DPDX
        REAL*4      DPDY
        REAL*4      DPDZ
        REAL*4      XREF           ! [1001] optional reference point for load value
        REAL*4      YREF           ! [1001] 
        REAL*4      ZREF           ! [1001] 
      END TYPE CBRIC_LOA
      INTEGER, PARAMETER :: LEN_CBRIC_LOA=12
      INTEGER, PARAMETER :: VER_CBRIC_LOA=200501

      TYPE CBRIC_STC               ! 310/LC:0  maximum stress in BRICs
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
        REAL*4      HP1            !        yield function
        REAL*4      HP2            !        volum. hardening
      END TYPE CBRIC_STC
      INTEGER, PARAMETER :: LEN_CBRIC_STC=9
      INTEGER, PARAMETER :: VER_CBRIC_STC=200501

      TYPE CBRIC_STR_SG            !        results in GAUSS-points
        SEQUENCE
        REAL*4      SIGX           ! [1092] 
        REAL*4      SIGY           ! [1092] 
        REAL*4      SIGZ           ! [1092] 
        REAL*4      TVXY           ! [1092] 
        REAL*4      TVXZ           ! [1092] 
        REAL*4      TVYZ           ! [1092] 
      END TYPE CBRIC_STR_SG
      INTEGER, PARAMETER :: LEN_CBRIC_STR_SG=6

      TYPE CBRIC_STR               ! 310/LC:+  3D-stresses in Bric-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
        TYPE(CBRIC_STR_SG) SG(8)   !        results in GAUSS-points
        REAL*4      HP1(0:8)       !        yield function
        REAL*4      HP2(0:8)       !        2nd parameter as specified in headder record
        REAL*4      HP3(0:8)       !        3rd parameter as specified in headder record
        REAL*4      HP4(0:8)       !        4th parameter as specified in headder record
        REAL*4      HP5(0:8)       !        5th parameter as specified in headder record
        REAL*4      HP6(0:8)       !        6th parameter as specified in headder record
        REAL*4      HP7(0:8)       !        7th parameter as specified in headder record
        REAL*4      HP8(0:8)       !        8th parameter as specified in headder record
        REAL*4      HP9(0:8)       !        9th parameter as specified in headder record
        REAL*4      HP10(0:8)      !        10th parameter as specified in headder record
        REAL*4      HP11(0:8)      !        11th parameter as specified in headder record
        REAL*4      HP12(0:8)      !        12th parameter as specified in headder record
        REAL*4      HP13(0:8)      !        13th parameter as specified in headder record
        REAL*4      HP14(0:8)      !        14th parameter as specified in headder record
        REAL*4      HP15(0:8)      !        15th parameter as specified in headder record
      END TYPE CBRIC_STR
      INTEGER, PARAMETER :: LEN_CBRIC_STR=190
      INTEGER, PARAMETER :: VER_CBRIC_STR=200501

      TYPE CBRIC_NSC               ! 311/LC:0  maximum nodal 3D stress
        SEQUENCE
        INTEGER   NG               !        ident 0 for maximum (first records)
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
      END TYPE CBRIC_NSC
      INTEGER, PARAMETER :: LEN_CBRIC_NSC=8
      INTEGER, PARAMETER :: VER_CBRIC_NSC=200501

      TYPE CBRIC_NST               ! 311/LC:Z+  3D-stresses in Bric-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
        REAL*4      FY             !        yield function
      END TYPE CBRIC_NST
      INTEGER, PARAMETER :: LEN_CBRIC_NST=9
      INTEGER, PARAMETER :: VER_CBRIC_NST=200501

      TYPE CBRIC_ESC               ! 312/LC:0  max. errors of Bric-stresses
        SEQUENCE
        INTEGER   NR               !        ident 0 for maximum (first records)
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
      END TYPE CBRIC_ESC
      INTEGER, PARAMETER :: LEN_CBRIC_ESC=7
      INTEGER, PARAMETER :: VER_CBRIC_ESC=200501

      TYPE CBRIC_EST               ! 312/LC:+  3D-error estimates in Bric-Elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      SIGX           ! [1092] stress
        REAL*4      SIGY           ! [1092] stress
        REAL*4      SIGZ           ! [1092] stress
        REAL*4      TVXY           ! [1092] shear stress
        REAL*4      TVXZ           ! [1092] shear stress
        REAL*4      TVYZ           ! [1092] shear stress
      END TYPE CBRIC_EST
      INTEGER, PARAMETER :: LEN_CBRIC_EST=7
      INTEGER, PARAMETER :: VER_CBRIC_EST=200501

      TYPE CBRIC_REI               ! 360/DC:+  reinforcement in Bric-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      AS(3)          ! [1022] reinforcement 1-3
        REAL*4      OAL            !        Euler Angle I
        REAL*4      OAF            !        Euler Angle II
        REAL*4      SD(3)          ! [1092] stress range 1-3
        REAL*4      SIGB           ! [1092] maximum concrete pressure
        REAL*4      SHZMAX         !        maximum skew principal tensile stress (SLS uncracked)
        REAL*4      ORIGIN(3)      !        origin of maximum reinforcement: as defined in 260/DC
      END TYPE CBRIC_REI
      INTEGER, PARAMETER :: LEN_CBRIC_REI=14
      INTEGER, PARAMETER :: VER_CBRIC_REI=200904

      TYPE CBRIC_NRI               ! 361/DC:Z+  reinforcement in Bric-nodes
        SEQUENCE
        INTEGER   NG               !        groupnumber
        INTEGER   NR               !        nodenumber
        REAL*4      AS(3)          ! [1022] reinforcement 1-3
        REAL*4      OAL            !        Euler Angle I
        REAL*4      OAF            !        Euler Angle II
        REAL*4      SD(3)          ! [1092] stress range 1-3
        REAL*4      SIGB           ! [1092] maximum concrete pressure
        REAL*4      SHZMAX         !        maximum skew principal tensile stress (SLS uncracked)
        REAL*4      ORIGIN(3)      !        origin of maximum reinforcement: as defined in 260/DC
      END TYPE CBRIC_NRI
      INTEGER, PARAMETER :: LEN_CBRIC_NRI=15
      INTEGER, PARAMETER :: VER_CBRIC_NRI=200904

      TYPE CBRIC_CFD               ! 390/LC  Fluid flow results in BRIC-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      VX             ! [1212] velocity
        REAL*4      VY             ! [1212] velocity
        REAL*4      VZ             ! [1212] velocity
        REAL*4      Q              ! [1211] stream quantity
        REAL*4      HOPT           ! [1001] optimal mesh size
        REAL*4      VXA            ! [1212] particle velocity
        REAL*4      VYA            ! [1212] particle velocity
        REAL*4      VZA            ! [1212] particle velocity
        REAL*4      MUED           ! [1220] laminar viscosity
        REAL*4      DUX(3)         ! [  95] gradient values fluid flow du/dx, du/dy, du/dz
        REAL*4      DVX(3)         ! [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
        REAL*4      DWX(3)         ! [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
        REAL*4      TK             ! [1222] turbulent energy
        REAL*4      MUET           ! [1220] turbulent viscosity
        REAL*4      ED             ! [1223] dissipation rate
        REAL*4      SCALAR(4)      !        optional scalar parameters
      END TYPE CBRIC_CFD
      INTEGER, PARAMETER :: LEN_CBRIC_CFD=26
      INTEGER, PARAMETER :: VER_CBRIC_CFD=201108

      TYPE CBRIC_TM                ! 391/LC:0  Maximum Temperature Results in BRICs
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      QX             ! [1218] heat flux
        REAL*4      QY             ! [1218] heat flux
        REAL*4      QZ             ! [1218] heat flux
        REAL*4      Q              ! [1216] Total flux
        REAL*4      TEFF           ! [  92] Effective Age
        REAL*4      HYDR           !        Hydration degree
        REAL*4      LFR            !        Liquid fraction
      END TYPE CBRIC_TM
      INTEGER, PARAMETER :: LEN_CBRIC_TM=8
      INTEGER, PARAMETER :: VER_CBRIC_TM=200501

      TYPE CBRIC_TMP               ! 391/LC  Temperature Results in BRIC-elements
        SEQUENCE
        INTEGER   NR               !        elementnumber
        REAL*4      QX             ! [1218] heat flux
        REAL*4      QY             ! [1218] heat flux
        REAL*4      QZ             ! [1218] heat flux
        REAL*4      Q              ! [1216] Total flux
        REAL*4      TEFF(0:8)      ! [  92] Effective Age
        REAL*4      HYDR(0:8)      !        Hydration degree
        REAL*4      LFR(0:8)       !        Liquid fraction
      END TYPE CBRIC_TMP
      INTEGER, PARAMETER :: LEN_CBRIC_TMP=32
      INTEGER, PARAMETER :: VER_CBRIC_TMP=200501

      TYPE CHASE_PIH               ! 404/NR:0  HASE-Piles in Half-space
        SEQUENCE
        INTEGER   ID               !        Identification 0
        INTEGER   NPILE            !        Number of piles
        INTEGER   MPILE            !        Max. values per pile
        INTEGER   NHKNOT           !        Number of nodes
      END TYPE CHASE_PIH
      INTEGER, PARAMETER :: LEN_CHASE_PIH=4
      INTEGER, PARAMETER :: VER_CHASE_PIH=0

      TYPE CHASE_PIL               ! 404/NR:+  HASE-Piles in Half-space
        SEQUENCE
        INTEGER   ENR              !        External node number
        REAL*4      X              ! [1001] Pile X-coordinate
        REAL*4      Y              ! [1001] Pile Y-coordinate
        REAL*4      DF             ! [1001] Pile-foot diameter
        REAL*4      Z              ! [1001] Pile-foot coordinate
        REAL*4      MANT           !        Fraction of the total pile load transfered as a pile
        REAL*4      PMAM           ! [1190] Max. load transferable by skin friction
        INTEGER   INR              !        Ixternal node number
        INTEGER   BEZ(4)           !        Designation
        REAL*4      PMAF           ! [1190] Max. load transferable trough pile-foot
        REAL*4      ZMAN           ! [1001] Z-coordiante from which the skin friction is active
        REAL*4      CFAC           !        Factor of load applied as compression-only
        REAL*4      PLEN           ! [1001] Pile length
        REAL*4      PLSF           ! [1001] Pile length part inactive for skin friction
        REAL*4      D0             ! [1001] Pile diameter
        REAL*4      MNR            !        Pile material number
      END TYPE CHASE_PIL
      INTEGER, PARAMETER :: LEN_CHASE_PIL=19
      INTEGER, PARAMETER :: VER_CHASE_PIL=0

      TYPE CSEG_DEF                ! 900/00  Segmentdefinition
        SEQUENCE
        INTEGER   ID               !        Identification of segment
        INTEGER   TYP              !        Type of segment
        INTEGER   BIT              !        Bitpattern idef+4*iref
        REAL*4      LEN            ! [1001] Length of segment
        REAL*4      ALFA           ! [   5] Angle of start face to axis (0 = match-cast)
        REAL*4      ALFR           ! [   5] Angle of end   face to axis (0 = match-cast)
        REAL*4      DSPA           ! [1001] Distance of start survey point
        REAL*4      DSPE           ! [1001] Distance of end survey point
        INTEGER   TEXT(17)         !        designation of segment
      END TYPE CSEG_DEF
      INTEGER, PARAMETER :: LEN_CSEG_DEF=25
      INTEGER, PARAMETER :: VER_CSEG_DEF=200712

      TYPE CIL_CTRL0               ! -1/NS:0  Headder of a location
        SEQUENCE
        INTEGER   ID               !        ID=0
        INTEGER   KWERG            !        KWH for results to be saved
        INTEGER   NERG             !        Count on corresponding items
        INTEGER   NREL             !        element number
        REAL*4      XABS           ! [1001] abszissae for beam sections
        INTEGER   TXT(17)          !        Name of location
      END TYPE CIL_CTRL0
      INTEGER, PARAMETER :: LEN_CIL_CTRL0=22
      INTEGER, PARAMETER :: VER_CIL_CTRL0=201105

      TYPE CIL_CTRL1               ! -1/NS:?  Headder of a result
        SEQUENCE
        INTEGER   IDI              !        Type of result
        INTEGER   IERG             !        index of this item + 1000*IMUNIT
        INTEGER   LFMAX            !        Offset for load case number of results for maximum
        INTEGER   LFMIN            !        Offset for load case number of results for minimum
        REAL*4      LPHI           ! [1001] characteristic lenght for dynamic impact factor
        INTEGER   TXT(17)          !        Name of item
      END TYPE CIL_CTRL1
      INTEGER, PARAMETER :: LEN_CIL_CTRL1=22
      INTEGER, PARAMETER :: VER_CIL_CTRL1=201105

      TYPE CIL_DATA0               ! -1/NS:1????  Influence values (V23, obsoleted)
        SEQUENCE
        INTEGER   IDI              !        Type of derivatives defined
        REAL*4      X              ! [1001] abszissae along lane
        REAL*4      PV             !        Influence value for vertical loading (z)
        REAL*4      MT             !        Influence value for torsional loading (x-x)
        REAL*4      PL             !        Influence value for longitudinal loading (x)
        REAL*4      PT             !        Influence value for transverse loading (y)
        REAL*4      DPV            !        Derivative of PV/dx (if IDI&1000)
        REAL*4      DMT            !        Derivative of MT/dx (if IDI&0100)
        REAL*4      DPL            !        Derivative of PL/dx (if IDI&0010)
        REAL*4      DPT            !        Derivative of PT/dx (if IDI&0001)
      END TYPE CIL_DATA0
      INTEGER, PARAMETER :: LEN_CIL_DATA0=10
      INTEGER, PARAMETER :: VER_CIL_DATA0=201105

      TYPE CIL_DATA                ! -1/NS:1??????  Influence values
        SEQUENCE
        INTEGER   IDI              !        Type of derivatives defined
        REAL*4      X              ! [1001] abszissae along lane
        REAL*4      PV             !        Influence value for vertical loading (z)
        REAL*4      MT             !        Influence value for torsional loading (x-x)
        REAL*4      PL             !        Influence value for longitudinal loading (x)
        REAL*4      PT             !        Influence value for transverse loading (y)
        REAL*4      PPOS           !        Influence value for vertical distributed loading
        REAL*4      PNEG           !        Influence value for vertical distributed loading
        REAL*4      DPV            !        Derivative of PV/dx   (if IDI&100000)
        REAL*4      DMT            !        Derivative of MT/dx   (if IDI&010000)
        REAL*4      DPL            !        Derivative of PL/dx   (if IDI&001000)
        REAL*4      DPT            !        Derivative of PT/dx   (if IDI&000100)
        REAL*4      DPPOS          !        Derivative of PPOS/dx (if IDI&000010)
        REAL*4      DPNEG          !        Derivative of PNEG/dx (if IDI&000001)
        REAL*4      RRES           !        Influence value for right residual loading
        REAL*4      LRES           !        Influence value for left residual loading
      END TYPE CIL_DATA
      INTEGER, PARAMETER :: LEN_CIL_DATA=16
      INTEGER, PARAMETER :: VER_CIL_DATA=201105

      END MODULE CDB_TYPES

!     end of automatically generated header
!     SOFiSTiK AG
!
