!     cdbtypeten.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_TEN
      TYPE CTENDAXIS               ! 40/NR:0  Tendon lanes/reference axis data
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   IGSYS            !        prestress for:
        INTEGER   IGINFO           !        Systeminfo
        INTEGER   IGREF            !        reference to geometry
        INTEGER   ICBIT            !        bit for analysis type
        INTEGER   IDS              !        Enum of secondary axis (1='A' to 26 ='Z')
        INTEGER   TEXT(17)         !        Designation
      END TYPE CTENDAXIS
      INTEGER, PARAMETER :: LEN_CTENDAXIS=23
      INTEGER, PARAMETER :: VER_CTENDAXIS=201002

      TYPE CTENDAX_1               ! 40/NR:1  Tendon lane stations
        SEQUENCE
        INTEGER   ID0              !        identifier 1
        INTEGER   IGBIT            !        station parameter
        INTEGER   NRSTAB           !        internal beam number
        INTEGER   ID3              !        reserved (value = 0)
        REAL*4      XL             !        beam X/L on beam
        REAL*4      S              ! [1001] station on reference lane
        REAL*4      SG             ! [1001] station of geometry
        REAL*4      SF             !        toppoint station
      END TYPE CTENDAX_1
      INTEGER, PARAMETER :: LEN_CTENDAX_1=8
      INTEGER, PARAMETER :: VER_CTENDAX_1=201002

      TYPE CTENDSPLI               ! 41/NR:0  Tendon splines
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   NRSPUR           !        corresponding lane
        INTEGER   NRSV             !        prestress system
        INTEGER   IGSYS            !        prestress for:
        INTEGER   INTYP            !        bit for analysis type
        INTEGER   IGREF            !        reference to      geometry  Rec: 03
        INTEGER   IGREFX           !        reference to exc. geometry  Rec: 03
        INTEGER   ID7              !        reserved (value = 0)
        INTEGER   ID8              !        reserved (value = 0)
        INTEGER   ID9              !        reserved (value = 0)
        REAL*4      STPARM(12)     !        additional data:
        INTEGER   TEXT(17)         !        Designation
      END TYPE CTENDSPLI
      INTEGER, PARAMETER :: LEN_CTENDSPLI=39
      INTEGER, PARAMETER :: VER_CTENDSPLI=201002

      TYPE CTENDSP_I               ! 41/NR:??  Input points
        SEQUENCE
        INTEGER   ID0              !        identifier INTYP see 41/0  (1=ZPUV standard geometry)
        INTEGER   IGBIT            !        station parameter see 40/1
        INTEGER   ID2              !        reserved (value = 0)
        INTEGER   ID3              !        reserved (value = 0)
        REAL*4      DATA(20)       !        Input point data
        INTEGER   QSP              !        Selection string - reference to cross section point
        INTEGER   VARU             !        Selection string - axis variable for offset U
        INTEGER   VARV             !        Selection string - axis variable for offset V
        REAL*4      DAT2(50)       !        Additional input point
      END TYPE CTENDSP_I
      INTEGER, PARAMETER :: LEN_CTENDSP_I=77
      INTEGER, PARAMETER :: VER_CTENDSP_I=201002

      TYPE CTENDTOPP               ! 43/NR  Tendon toppoints
        SEQUENCE
        INTEGER   ID0              !        identifier:
        INTEGER   NR               !        corresponding lane
        INTEGER   IGREF            !        reference to      geometry  Rec: 03
        REAL*4      S(124)         ! [1001] stations on toppoints (max. 124)
      END TYPE CTENDTOPP
      INTEGER, PARAMETER :: LEN_CTENDTOPP=127
      INTEGER, PARAMETER :: VER_CTENDTOPP=201002

      TYPE CTENDON                 ! 44/NR:0  Tendons
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   NRSPUR           !        corresponding lane
        INTEGER   NRSPLI           !        Spline-No
        INTEGER   NRSTRG           !        tendon no.
        INTEGER   IGREF            !        reference to      geometry  Rec: 03
        INTEGER   IGTYP            !        bit for analysis type
        INTEGER   IZ_REF           !        IGTYP=1024:  Def-No of geometry
        INTEGER   NIBA(3)          !        construction stages
        INTEGER   NRSV             !        prestress system
        INTEGER   NSP              !        number of tendons
        INTEGER   MATA             !        material concrete
        INTEGER   NVART            !        type of jacking
        INTEGER   NVARTU           !        output control
        INTEGER   NVVOR            !        prestress input
        INTEGER   NVBIT(2)         !        jacking bit
        INTEGER   LFP(2)           !        prestress loadcases
        INTEGER   IGSYS            !        prestress for:
        INTEGER   ID21             !        reserved (value = 0)
        REAL*4      KAPA           !        KAPA + 100*KAPL + 1000*action
        REAL*4      EINL           !        transition length
        REAL*4      ETYP           !        force type to EINL
        REAL*4      TFAK           !        factor partial p
        REAL*4      TLITZ          !        no. of wires
        REAL*4      AR             !        crack design area
        REAL*4      DZ             !        diameter of tendon
        REAL*4      UZ             !        perimeter
        REAL*4      VALM(4)        !        reserved
        INTEGER   TEXT(17)         !        Designation
      END TYPE CTENDON
      INTEGER, PARAMETER :: LEN_CTENDON=51
      INTEGER, PARAMETER :: VER_CTENDON=201002

      TYPE CTENDJACK               ! 44/NR:1  Tendon jacking data
        SEQUENCE
        INTEGER   ID0              !        identifier 1
        INTEGER   ID1              !        reserved (value = 0)
        INTEGER   ID2              !        reserved (value = 0)
        INTEGER   ID3              !        reserved (value = 0)
        REAL*4      ZVSTRG(16)     !        geometry data
        REAL*4      ZVFAK(24)      !        stresses and stressing factors
        REAL*4      ZVVOR(12)      !        direct input of prestress
        REAL*4      ZVFREE(12)     !        free prestress
        REAL*4      ZVAEND(8)      !        local geometry position
        REAL*4      ZVREIB(8)      !        additional friction data
        REAL*4      ZVFGRZ(32)     !        limit values of prestress
        REAL*4      ZVWEG(16)      !        stressing deformation
        INTEGER   TEXT(17)         !        Designation
      END TYPE CTENDJACK
      INTEGER, PARAMETER :: LEN_CTENDJACK=149
      INTEGER, PARAMETER :: VER_CTENDJACK=201002

      TYPE CTENDFACT               ! 44/NR:2  Tendon jacking factors
        SEQUENCE
        INTEGER   ID0              !        identifier 2
        INTEGER   IGBIT            !        station parameter see 40/1
        INTEGER   ID2              !        reserved (value = 0)
        INTEGER   ID3              !        reserved (value = 0)
        REAL*4      S              ! [1001] station
        REAL*4      FAK            !        active stressing factors
        REAL*4      ZWFAK(12)      !        additional factor data
      END TYPE CTENDFACT
      INTEGER, PARAMETER :: LEN_CTENDFACT=18
      INTEGER, PARAMETER :: VER_CTENDFACT=201002


      INTEGER, PARAMETER :: TENDAXIS_KWH = 40
      INTEGER, PARAMETER :: TENDSPLI_KWH = 41
      INTEGER, PARAMETER :: TENDTOPP_KWH = 43
      INTEGER, PARAMETER :: TENDON_KWH = 44

      END MODULE CDB_TYPES_TEN

!     end of automatically generated header
!     SOFiSTiK AG
!
