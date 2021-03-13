!     cdbtypecon.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_CON

      TYPE CCON_0                  ! 8/ID:0  Connection Headder
        SEQUENCE
        INTEGER   IDS              !        Identification = 0
        INTEGER   TYP              !        Type of connection
        INTEGER   MAT              !        Materialnumber for all plates
        INTEGER   TEXT(17)         !        designation of connection
      END TYPE CCON_0
      INTEGER, PARAMETER :: LEN_CCON_0=20
      INTEGER, PARAMETER :: VER_CCON_0=200501

      TYPE CCON_BOL                ! 8/ID:1  Definition of Bolts
        SEQUENCE
        INTEGER   IDS              !        Identification = 1
        INTEGER   TYP              !        Type of hole
        INTEGER   MAT              !        Materialdesignation of bolt
        REAL*4      D              ! [1011] Diameter of bolt
        INTEGER   NORM(4)          !        Designation of product code
        INTEGER   TEXT(17)         !        designation of bolt
      END TYPE CCON_BOL
      INTEGER, PARAMETER :: LEN_CCON_BOL=25
      INTEGER, PARAMETER :: VER_CCON_BOL=200501

      TYPE CCON_WEL                ! 8/ID:2  Definition of Weldings
        SEQUENCE
        INTEGER   IDS              !        Identification = 2
        INTEGER   TYP              !        Type of weld
        INTEGER   MAT              !        Materialnumber of weld (not used)
        REAL*4      T              ! [1011] Thickness of weld
        REAL*4      AW             !        Reduction factor
        INTEGER   TEXT(17)         !        designation of weld
      END TYPE CCON_WEL
      INTEGER, PARAMETER :: LEN_CCON_WEL=22
      INTEGER, PARAMETER :: VER_CCON_WEL=200501

      TYPE CCON_CLE                ! 8/ID:3  Definition of Cleats (Angle/Latch)
        SEQUENCE
        INTEGER   IDS              !        Identification = 3
        INTEGER   TYP              !        Enum of type (angle/latch not really enforced)
        INTEGER   MAT              !        Material number of the plate
        INTEGER   BOL(2)           !        id of bolts
        INTEGER   NBB(2)           !        Number of bolts in width direction
        INTEGER   NBL(2)           !        Number of bolts in angle directions 1 & 2
        REAL*4      T              ! [1011] Thickness of cleat
        REAL*4      B              ! [1011] Width/Height of cleat
        REAL*4      L(2)           ! [1011] Length of angles
        REAL*4      W(0:7)         ! [1011] Distances
        REAL*4      A(2)           ! [1011] weld thickness for NBL(i) if welding is used
        REAL*4      TF             ! [1011] Thickness of backplate
        INTEGER   TEXT(17)         !        designation of element
      END TYPE CCON_CLE
      INTEGER, PARAMETER :: LEN_CCON_CLE=41
      INTEGER, PARAMETER :: VER_CCON_CLE=200501

      TYPE CCON_MEM                ! 8/ID:10  Connected Member data
        SEQUENCE
        INTEGER   IDS              !        Identification = 10
        INTEGER   NR               !        Enumeration or designation of member
        INTEGER   TYP              !        Type of connection bitpattern
        INTEGER   NRQ              !        Number of section
        INTEGER   WTYP             !        id of the web connection
        INTEGER   UTYP             !        id of the upper flange connection
        INTEGER   LTYP             !        id of the lower flange connection
        REAL*4      L              ! [1001] length of member
        REAL*4      AW             ! [1011] weld thickness for web connection
        REAL*4      AU             ! [1011] weld thickness for upper flange connection
        REAL*4      AL             ! [1011] weld thickness for lower flange connection
        REAL*4      DD             ! [1011] Distance value of endpoint to central node
        REAL*4      D(3)           !        Direction vector to beam axis in the
        REAL*4      ROTY           ! [   5] Angle of end plate y-rotation
        REAL*4      ROTZ           ! [   5] Angle of end plate z-rotation
        REAL*4      CUTU           ! [1011] Cut out height for upper flange
        REAL*4      CUTL           ! [1011] Cut out height for lower flange
        REAL*4      CLU            ! [1011] Cut out length for upper flange
        REAL*4      CLD            ! [1011] Cut out length for lower flange
        REAL*4      VOUTE(2,4)     ! [1011] Voute [lenght,height] for
      END TYPE CCON_MEM
      INTEGER, PARAMETER :: LEN_CCON_MEM=29
      INTEGER, PARAMETER :: VER_CCON_MEM=200501

      TYPE CCON_END                ! 8/ID:11  Endplate of Beam
        SEQUENCE
        INTEGER   IDS              !        Identification = 11
        INTEGER   TYP              !        Type of end plate
        INTEGER   MAT              !        Materialnumber of endplate
        INTEGER   BOLT             !        Identifier of bolt type
        INTEGER   NBR              !        Number of bolts in height direction
        INTEGER   NBC              !        Number of bolts in width direction
        REAL*4      B              ! [1011] Width of plate
        REAL*4      H              ! [1011] Total plate height
        REAL*4      MX             ! [1011] Eccentricity
        REAL*4      T              ! [1011] Thickness of plate
        REAL*4      HB(0:4)        ! [1011] Height for bolts
        REAL*4      W(0:1)         ! [1011] Width for bolts
        REAL*4      HTBP(4)        ! [1011] Height and thickness values for back plates
      END TYPE CCON_END
      INTEGER, PARAMETER :: LEN_CCON_END=21
      INTEGER, PARAMETER :: VER_CCON_END=200501

      TYPE CCON_PIN                ! 8/ID:12  Pinned plate of Beam
        SEQUENCE
        INTEGER   IDS              !        Identification = 13
        INTEGER   MAT              !        Materialnumber of pin plate
        INTEGER   MATS             !        Materialnumber of support plate
        INTEGER   MATP             !        Materialnumber of pin
        REAL*4      DP             ! [1011] Diameter of pin
        REAL*4      DH             ! [1011] Diameter of hole
        REAL*4      TP             ! [1011] Thickness pin plate
        REAL*4      TSUP           ! [1011] Thickness sup plate
        REAL*4      C              ! [1011] gap between plates
        REAL*4      E1             ! [1011] eccentricity 1
        REAL*4      E2             ! [1011] eccentricity 2
      END TYPE CCON_PIN
      INTEGER, PARAMETER :: LEN_CCON_PIN=11
      INTEGER, PARAMETER :: VER_CCON_PIN=200712

      TYPE CCON_PLT                ! 8/ID:20  Additional plates in connection
        SEQUENCE
        INTEGER   IDS              !        Identification = 20
        INTEGER   TYP              !        Type of plate
        INTEGER   MAT              !        Number of material
        REAL*4      T              ! [1011] Thickness of plate
        REAL*4      EDGE(5,8)      ! [1011] Local coordinates, weldid, weldthickness
      END TYPE CCON_PLT
      INTEGER, PARAMETER :: LEN_CCON_PLT=44
      INTEGER, PARAMETER :: VER_CCON_PLT=200501


      INTEGER, PARAMETER :: CON_0_KWH = 8

      END MODULE CDB_TYPES_CON

!     end of automatically generated header
!     SOFiSTiK AG
!
