!     cdbtypesct.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_SCT

      INTEGER, PARAMETER, PUBLIC :: MAXQNR=999

      TYPE CSECT                   ! 9/NR:0  SectionalValues (total section)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   MNO              !        Materialnumber of sections
        INTEGER   MRF              !        Materialnumber of Reinforcement
        REAL*4      A              ! [1012] Area
        REAL*4      AY             ! [1012] Sheardeformation area Y
        REAL*4      AZ             ! [1012] Sheardeformation area Z
        REAL*4      IT             ! [1014] Torsional moment of inertia
        REAL*4      IY             ! [1014] Moments of inertia y-y
        REAL*4      IZ             ! [1014] Moments of inertia z-z
        REAL*4      IYZ            ! [1014] Moments of inertia y-z
        REAL*4      YS             ! [1011] y-Ordinate Center of elasticity
        REAL*4      ZS             ! [1011] z-Ordinate Center of elasticity
        REAL*4      YSC            ! [1011] y-Ordinate of Shear-Center
        REAL*4      ZSC            ! [1011] z-Ordinate of Shear-Center
        REAL*4      EM             ! [1090] Elasticity Modulus
        REAL*4      GM             ! [1090] Shear Modulus
        REAL*4      GAM            ! [1091] Nominal weight
      END TYPE CSECT
      INTEGER, PARAMETER :: LEN_CSECT=17
      INTEGER, PARAMETER :: VER_CSECT=200501

      TYPE CSECT_EFF               ! 9/NR:1  SectionalValues (effective section)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   MNO              !        Materialnumber of sections
        INTEGER   MRF              !        Materialnumber of Reinforcement
        REAL*4      A              ! [1012] Area
        REAL*4      AY             ! [1012] Sheardeformation area Y
        REAL*4      AZ             ! [1012] Sheardeformation area Z
        REAL*4      IT             ! [1014] Torsional moment of inertia
        REAL*4      IY             ! [1014] Moments of inertia y-y
        REAL*4      IZ             ! [1014] Moments of inertia z-z
        REAL*4      IYZ            ! [1014] Moments of inertia y-z
        REAL*4      YS             ! [1011] y-Ordinate Center of elasticity
        REAL*4      ZS             ! [1011] z-Ordinate Center of elasticity
        REAL*4      YSC            ! [1011] y-Ordinate of Shear-Center
        REAL*4      ZSC            ! [1011] z-Ordinate of Shear-Center
        REAL*4      EM             ! [1090] Elasticity Modulus
        REAL*4      GM             ! [1090] Shear Modulus
        REAL*4      GAM            ! [1091] Nominal weight
      END TYPE CSECT_EFF
      INTEGER, PARAMETER :: LEN_CSECT_EFF=17
      INTEGER, PARAMETER :: VER_CSECT_EFF=200501

      TYPE CSECT_PAR               ! 9/NR:2  SectionalValues (total part of section)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   MNO              !        Materialnumber of sections
        INTEGER   MRF              !        Materialnumber of Reinforcement
        REAL*4      A              ! [1012] Area
        REAL*4      AY             ! [1012] Sheardeformation area Y
        REAL*4      AZ             ! [1012] Sheardeformation area Z
        REAL*4      IT             ! [1014] Torsional moment of inertia
        REAL*4      IY             ! [1014] Moments of inertia y-y
        REAL*4      IZ             ! [1014] Moments of inertia z-z
        REAL*4      IYZ            ! [1014] Moments of inertia y-z
        REAL*4      YS             ! [1011] y-Ordinate Center of elasticity
        REAL*4      ZS             ! [1011] z-Ordinate Center of elasticity
        REAL*4      YSC            ! [1011] y-Ordinate of Shear-Center
        REAL*4      ZSC            ! [1011] z-Ordinate of Shear-Center
        REAL*4      EM             ! [1090] Elasticity Modulus
        REAL*4      GM             ! [1090] Shear Modulus
        REAL*4      GAM            ! [1091] Nominal weight
      END TYPE CSECT_PAR
      INTEGER, PARAMETER :: LEN_CSECT_PAR=17
      INTEGER, PARAMETER :: VER_CSECT_PAR=200501

      TYPE CSECT_PEF               ! 9/NR:3  SectionalValues (effective part of section)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   MNO              !        Materialnumber of sections
        INTEGER   MRF              !        Materialnumber of Reinforcement
        REAL*4      A              ! [1012] Area
        REAL*4      AY             ! [1012] Sheardeformation area Y
        REAL*4      AZ             ! [1012] Sheardeformation area Z
        REAL*4      IT             ! [1014] Torsional moment of inertia
        REAL*4      IY             ! [1014] Moments of inertia y-y
        REAL*4      IZ             ! [1014] Moments of inertia z-z
        REAL*4      IYZ            ! [1014] Moments of inertia y-z
        REAL*4      YS             ! [1011] y-Ordinate Center of elasticity
        REAL*4      ZS             ! [1011] z-Ordinate Center of elasticity
        REAL*4      YSC            ! [1011] y-Ordinate of Shear-Center
        REAL*4      ZSC            ! [1011] z-Ordinate of Shear-Center
        REAL*4      EM             ! [1090] Elasticity Modulus
        REAL*4      GM             ! [1090] Shear Modulus
        REAL*4      GAM            ! [1091] Nominal weight
      END TYPE CSECT_PEF
      INTEGER, PARAMETER :: LEN_CSECT_PEF=17
      INTEGER, PARAMETER :: VER_CSECT_PEF=200501

      INTEGER, PARAMETER :: SECT_ADD_MOD=0
      INTEGER, PARAMETER :: SECT_ADD_VAL=1
      INTEGER, PARAMETER :: SECT_ADD_TYP=2
      INTEGER, PARAMETER :: SECT_ADD_PLA=3
      INTEGER, PARAMETER :: SECT_ADD_SOL=4
      INTEGER, PARAMETER :: SECT_ADD_EFF=5
      INTEGER, PARAMETER :: SECT_ADD_FEM=6
      INTEGER, PARAMETER :: SECT_ADD_HYD=9
      INTEGER, PARAMETER :: SECT_ADD_FIBRE=+128
      INTEGER, PARAMETER :: SECT_ADD_NEFF=+512
      INTEGER, PARAMETER :: SECT_ADD_INTE=+1024
      INTEGER, PARAMETER :: SECT_ADD_TEMP=+2048
      INTEGER, PARAMETER :: SECT_ADD_VARI=+4096
      INTEGER, PARAMETER :: SECT_ADD_REFP=+8192
      INTEGER, PARAMETER :: SECT_ADD_HOT=+16384
      TYPE CSECT_ADD               ! 9/NR:4  SectionalValuesShear , Temperature
        SEQUENCE
        INTEGER   ID
        INTEGER   STYPE
        INTEGER   MRF              !        Materialnumber of Stirup-Reinforcement
        REAL*4      AT             ! [ 107] Elongationkoefficient for Temperature
        REAL*4      YMIN           ! [1011] Minimum Ordinate of section to center ys
        REAL*4      YMAX           ! [1011] Maximum Ordinate of section to center ys
        REAL*4      ZMIN           ! [1011] Minimum Ordinate of section to center zs
        REAL*4      ZMAX           ! [1011] Maximum Ordinate of section to center zs
        REAL*4      TMIN           ! [1011] minimum thickness
        REAL*4      TMAX           ! [1011] maximum thickness
        REAL*4      WT             ! [1018] maximum tau for Torsion MT=1
        REAL*4      WVY            ! [1017] maximum tau for Shear VY=1
        REAL*4      WVZ            ! [1017] maximum tau for Shear VZ=1
        REAL*4      WT2            ! [1018] maximum tau for sekundary Torsion
        REAL*4      AK             ! [1012] kernel area for Torsion
        REAL*4      AYZ            ! [1012] Shear deviation area
        REAL*4      AB             ! [1012] pure concrete area
        REAL*4      LEVY           ! [1011] minimum lever for cracked shear Vy
        REAL*4      LEVZ           ! [1011] minimum lever for cracked shear Vz
        REAL*4      ELVY           ! [  17] elastic shear flux for Vy = Sy-max/Iz
        REAL*4      ELVZ           ! [  17] elastic shear flux for Vz = Sz-max/Iy
        REAL*4      YMINE          ! [1011] Minimum Ordinate of effective section
        REAL*4      YMAXE          ! [1011] Maximum Ordinate of effective section
        REAL*4      ZMINE          ! [1011] Minimum Ordinate of effective section
        REAL*4      ZMAXE          ! [1011] Maximum Ordinate of effective section
      END TYPE CSECT_ADD
      INTEGER, PARAMETER :: LEN_CSECT_ADD=25
      INTEGER, PARAMETER :: VER_CSECT_ADD=200501

      TYPE CSECT_WAR               ! 9/NR:5  SectionalValuesWarping
        SEQUENCE
        INTEGER   ID               !        Identification = 5
        INTEGER   I_1              !        unused
        INTEGER   I_2              !        unused
        REAL*4      AYYY           ! [1015] Integrals on section
        REAL*4      AYYZ           ! [1015] Integrals on section
        REAL*4      AYZZ           ! [1015] Integrals on section
        REAL*4      AZZZ           ! [1015] Integrals on section
        REAL*4      AWY            ! [1015] Integrals on section
        REAL*4      AWZ            ! [1015] Integrals on section
        REAL*4      AWYY           ! [1016] Integrals on section
        REAL*4      AWZZ           ! [1016] Integrals on section
        REAL*4      CM             ! [1016] Warping resistance
        REAL*4      CMS            ! [1014] Warping Shear resist.
        REAL*4      WMIN           ! [1012] Minimum warping
        REAL*4      WMAX           ! [1012] Maximum warping
        REAL*4      FYSW           ! [1012] Shear VY-MT2 area
        REAL*4      FZSW           ! [1012] Shear VZ-MT2 area
        REAL*4      IPSC           ! [1014] polar inertia at SC
      END TYPE CSECT_WAR
      INTEGER, PARAMETER :: LEN_CSECT_WAR=18
      INTEGER, PARAMETER :: VER_CSECT_WAR=200501

      INTEGER, PARAMETER :: SECT_IBC_MULT=32
      TYPE CSECT_PLA               ! 9/NR:6  SectionalPlasticForces
        SEQUENCE
        INTEGER   ID               !        Identification = 6
        INTEGER   IBC              !        Buckling curve
        INTEGER   IB               !        Control
        REAL*4      WPN            ! [1101] Normal force
        REAL*4      WPVY           ! [1102] Y-Shear force
        REAL*4      WPVZ           ! [1102] Y-Shear force
        REAL*4      WPMT           ! [1103] Torsional moment
        REAL*4      WPMY           ! [1104] Bending moment My
        REAL*4      WPMZ           ! [1104] Bending moment Mz
        REAL*4      YSP            ! [1001] Plastic center
        REAL*4      ZSP            ! [1001] Plastic center
        REAL*4      WPMB           ! [1105] warping moment Mb
        REAL*4      WPT2           ! [1103] 2nd torsional moment
      END TYPE CSECT_PLA
      INTEGER, PARAMETER :: LEN_CSECT_PLA=13
      INTEGER, PARAMETER :: VER_CSECT_PLA=200501

      TYPE CSECT_DES               ! 9/NR:7  SectionalValuesDesign
        SEQUENCE
        INTEGER   ID               !        Identification = 7
        INTEGER   MNR              !        used reference material
        INTEGER   IBC              !        buckling curve index (see 009/NR:6)
        REAL*4      A              ! [1012] Area
        REAL*4      AY             ! [1012] Sheardeformation area Y
        REAL*4      AZ             ! [1012] Sheardeformation area Z
        REAL*4      IT             ! [1014] Torsional moment of inertia
        REAL*4      IY             ! [1014] Moments of inertia y-y
        REAL*4      IZ             ! [1014] Moments of inertia z-z
        REAL*4      IYZ            ! [1014] Moments of inertia y-z
        REAL*4      YS             ! [1011] y-Ordinate Center of gravity
        REAL*4      ZS             ! [1011] z-Ordinate Center of gravity
        REAL*4      YSC            ! [1011] y-Ordinate of Shear-Center
        REAL*4      ZSC            ! [1011] z-Ordinate of Shear-Center
        REAL*4      EM             ! [1090] Elasticity Modulus/safety
        REAL*4      GM             ! [1090] Shear Modulus/safety
        REAL*4      GAM            ! [1091] Nominal weight
      END TYPE CSECT_DES
      INTEGER, PARAMETER :: LEN_CSECT_DES=17
      INTEGER, PARAMETER :: VER_CSECT_DES=200501

      TYPE CSECT_PRE               ! 9/NR:8  SectionalForcesPrestress
        SEQUENCE
        INTEGER   ID               !        Identification = 8
        INTEGER   ITP              !        subtype of information = 0
        INTEGER   ITS              !        source of values
        REAL*4      N              ! [1101] Normal force
        REAL*4      MY             ! [1104] Bending moment My
        REAL*4      MZ             ! [1104] Bending moment Mz
        REAL*4      EA             ! [1101] tangential stiffnes E*A
        REAL*4      EAY            ! [1105] tangential stiffnes E*A*z*z
        REAL*4      EAZ            ! [1105] tangential stiffnes E*A*y*y
        REAL*4      EAYZ           ! [1105] tangential stiffnes E*A*y*z
        REAL*4      YSE            ! [1011] elastic tangential center ys
        REAL*4      ZSE            ! [1011] elastic tangential center zs
        REAL*4      NCM            ! [1101] maximum compressive force
        REAL*4      NTM            ! [1101] maximum tensile force
      END TYPE CSECT_PRE
      INTEGER, PARAMETER :: LEN_CSECT_PRE=14
      INTEGER, PARAMETER :: VER_CSECT_PRE=200501

      TYPE CSECT_GV                ! 9/NR:8  SectionalGeometricValues
        SEQUENCE
        INTEGER   ID               !        Identification = 8
        INTEGER   ITP              !        subtype of information = 2
        INTEGER   MNO              !        Materialnumber (0=total section)
        REAL*4      UO             ! [1011] outer perimeter
        REAL*4      UI             ! [1011] inner perimeter
        REAL*4      TMIN           ! [1011] minimum thickness
        REAL*4      TMAX           ! [1011] maximum thickness
        REAL*4      KTZ            ! [   8] total weight factor
        REAL*4      UOM            ! [1011] outer effect.perimeter
        REAL*4      UIM            ! [1011] inner effect.perimeter
        REAL*4      ARO            ! [1012] Outer total gross area
        REAL*4      AR             ! [1012] total gross area
        REAL*4      IPM            ! [1183] rotational inertia      gam*Ip  ! values to be converted * DC_M
        REAL*4      IYM            ! [1183] sectional mass inertia  gam*Iy  ! values to be converted * DC_M
        REAL*4      IZM            ! [1183] sectional mass inertia  gam*Iz  ! values to be converted * DC_M
        REAL*4      IYZM           ! [1183] sectional mass inertia  gam*Iyz ! values to be converted * DC_M
        REAL*4      YSM            ! [1011] true mass gravity center
        REAL*4      ZSM            ! [1011] true mass gravity center
        REAL*4      DW             ! [1011] effective thickness for creep/shrinkage
        REAL*4      UAIR           ! [1011] air contact perimeter
      END TYPE CSECT_GV
      INTEGER, PARAMETER :: LEN_CSECT_GV=20
      INTEGER, PARAMETER :: VER_CSECT_GV=200501

      TYPE CSECT_TRA               ! 9/NR:8  SectionalAppliedTransformation
        SEQUENCE
        INTEGER   ID               !        Identification = 8
        INTEGER   ITP              !        subtype of information = 3
        INTEGER   I_2              !        not used
        REAL*4      ALF            ! [   5] rotation angle
        REAL*4      YTF            ! [1011] shift in y direction
        REAL*4      ZTF            ! [1011] shift in z direction
      END TYPE CSECT_TRA
      INTEGER, PARAMETER :: LEN_CSECT_TRA=6
      INTEGER, PARAMETER :: VER_CSECT_TRA=201306

      TYPE CSECT_LAY               ! 9/NR:9  SectionalReinforcementLayer  (LAY)
        SEQUENCE
        INTEGER   ID               !        Identification = 9
        INTEGER   MNR              !        Materialnumber + 1000*No of concrete \%
        INTEGER   INR              !        Type/number of layer
        INTEGER   TNR              !        Designation
        REAL*4      ALOW           ! [1020] Lower bound for area of layer
        REAL*4      AHIG           ! [1020] Upper bound for area of layer
        REAL*4      ASUM           ! [1020] Sum of reference areas of layer
        REAL*4      AFAK           !        maximum allowable factor of layer
        REAL*4      YS             ! [1011] center of layer
        REAL*4      ZS             ! [1011] center of layer
        REAL*4      VAS            ! [1020] Lower sequential total bound of layer area
        REAL*4      BAS            ! [1020] Upper sequential total bound of layer area
        REAL*4      IY             ! [1014] 4th ord.areas (inertia)
        REAL*4      IZ             ! [1014] 4th ord.areas (inertia)
        REAL*4      IYZ            ! [1014] 4th ord.areas (inertia)
        REAL*4      EMOD           ! [1090] Elasticity-Modulus
        REAL*4      BETS           ! [1092] yieldstress
        REAL*4      RL             ! [1011] torsional refer. length
        REAL*4      DMIN           ! [1023] smallest used diameter
        REAL*4      DMAX           ! [1023] largest  used diameter
        REAL*4      N              ! [1101] Normal force
        REAL*4      MY             ! [1104] Bending moment My
        REAL*4      MZ             ! [1104] Bending moment Mz
        REAL*4      EA             ! [1101] tangential stiffnes E*A
        REAL*4      EAY            ! [1104] tangential stiffnes E*A*z
        REAL*4      EAZ            ! [1104] tangential stiffnes E*A*y
        REAL*4      EAYY           ! [1105] tangential stiffnes E*A*y*y
        REAL*4      EAZZ           ! [1105] tangential stiffnes E*A*z*z
        REAL*4      EAYZ           ! [1105] tangential stiffnes E*A*y*z
        REAL*4      NPLC           ! [1101] maximum compressive force
        REAL*4      NPLT           ! [1101] maximum tensile force
      END TYPE CSECT_LAY
      INTEGER, PARAMETER :: LEN_CSECT_LAY=31
      INTEGER, PARAMETER :: VER_CSECT_LAY=201705

      INTEGER, PARAMETER :: SECT_REC_PLATE=0
      INTEGER, PARAMETER :: SECT_REC_RECT=1
      INTEGER, PARAMETER :: SECT_REC_TBEAM=2
      INTEGER, PARAMETER :: SECT_REC_TTBEAM=3
      INTEGER, PARAMETER :: SECT_REC_VPLAT=4
      INTEGER, PARAMETER :: SECT_REC_VHREC=5
      INTEGER, PARAMETER :: SECT_REC_VBREC=6
      INTEGER, PARAMETER :: SECT_REC_VRECT=7
      INTEGER, PARAMETER :: SECT_REC_REFPT=256
      INTEGER, PARAMETER :: SECT_REC_SCLOC=8192
      INTEGER, PARAMETER :: SECT_REC_IBCOFF=32768
      INTEGER, PARAMETER :: SECT_REC_RF_CU=0
      INTEGER, PARAMETER :: SECT_REC_RF_SYM=1
      INTEGER, PARAMETER :: SECT_REC_RF_ASY=2
      INTEGER, PARAMETER :: SECT_REC_RF_AST=3
      INTEGER, PARAMETER :: SECT_REC_RF_ASB=4
      INTEGER, PARAMETER :: SECT_REC_CORNER=8
      INTEGER, PARAMETER :: SECT_REC_RF_TRA=64
      INTEGER, PARAMETER :: SECT_REC_BUNDLE=128
      INTEGER, PARAMETER :: SECT_REC_FIXLAY=256
      TYPE CSECT_REC               ! 9/NR:10  SectiontypeRectangular T-Beam (SREC)
        SEQUENCE
        INTEGER   ID               !        Identification = 10
        INTEGER   IQ               !        Identification of section
        INTEGER   IR               !        Identification of reinforcement and origin
        REAL*4      H              ! [1011] total height
        REAL*4      B              ! [1011] width (of web)
        REAL*4      SO             ! [1024] Boundary distance of upper reinforcement
        REAL*4      SU             ! [1024] Boundary distance of lower reinforcement
        REAL*4      ASO            ! [1020] reinforcement up
        REAL*4      ASU            ! [1020] reinforcement down
        REAL*4      HO             ! [1011] height of plate
        REAL*4      BO             ! [1011] width  of plate
        REAL*4      DASO           ! [1023] reinf. Diameter up
        REAL*4      DASU           ! [1023] reinf. Diameter dn
        REAL*4      FKIT           !        <0 = factor for torsional inertia >0 = absolut value of torsion
        REAL*4      FKAY           !        <0 = factor for shear deformation area >0 = absolut value of sh
        REAL*4      FKAZ           !        <0 = factor for shear deformation area >0 = absolut value of sh
        REAL*4      YSMP           ! [1011] explicit location of shear center
        REAL*4      ZSSMP          ! [1011] explicit location of shear center
        REAL*4      YS             ! [1011] explicit location of reference point
        REAL*4      ZS             ! [1011] explicit location of reference point
        REAL*4      PHIB           ! [   5] inclination of transverse reinforcements
        REAL*4      BEFF           ! [1011] width of equivalent hollow section
        REAL*4      ASBM           !        Minimum shear reinf.
        REAL*4      A              ! [1011] spacing of reinforcements
        REAL*4      AMIN           ! [1011] minimum distance of single reinforcements
        REAL*4      AMAX           ! [1011] maximum distance of single reinforcements
        REAL*4      SS             ! [1024] Boundary distance of lateral reinforcement
        REAL*4      DASS           ! [1023] reinf. Diameter side
        REAL*4      HMAX           ! [1011] maximum mesh size for FE/fibre analysis
        REAL*4      BETC           !        friction coefficient
        REAL*4      MUE            !        friction in joint
      END TYPE CSECT_REC
      INTEGER, PARAMETER :: LEN_CSECT_REC=31
      INTEGER, PARAMETER :: VER_CSECT_REC=201302

      TYPE CSECT_ANN               ! 9/NR:11  SectiontypeAnnular (SCIT)
        SEQUENCE
        INTEGER   ID               !        Identification = 11
        INTEGER   IR               !        Identification of section
        INTEGER   IR2              !        Identification of reinforcement
        REAL*4      RO             ! [1011] outer radius
        REAL*4      RI             ! [1011] inner radius
        REAL*4      ROS            ! [1011] outer reinf radius
        REAL*4      RIS            ! [1011] inner reinf radius
        REAL*4      ASO            ! [1020] outer reinforcement
        REAL*4      ASI            ! [1020] inner reinforcement
        REAL*4      DASO           ! [1023] reinf. Diameter
        REAL*4      AMAX           ! [1011] maximum distance of single reinforcements
        REAL*4      ASBM           ! [1021] Minimum shear reinf.
        REAL*4      HMAX           ! [1011] maximum mesh size for FE/fibre analysis
        REAL*4      FKIT           !        <0 = factor for torsional inertia >0 = absolut value of torsion
        REAL*4      FKAY           !        <0 = factor for shear deformation area >0 = absolut value of sh
        REAL*4      FKAZ           !        <0 = factor for shear deformation area >0 = absolut value of sh
      END TYPE CSECT_ANN
      INTEGER, PARAMETER :: LEN_CSECT_ANN=16
      INTEGER, PARAMETER :: VER_CSECT_ANN=201212

      TYPE CSECT_TUB               ! 9/NR:11  SectiontypeTube (TUBE)
        SEQUENCE
        INTEGER   ID               !        Identification = 11
        INTEGER   IR               !        Identification of section = 2
        INTEGER   IR2              !        property Bit
        REAL*4      D              ! [1011] Diameter
        REAL*4      T              ! [1011] thickness of tubes
      END TYPE CSECT_TUB
      INTEGER, PARAMETER :: LEN_CSECT_TUB=5
      INTEGER, PARAMETER :: VER_CSECT_TUB=200501

      TYPE CSECT_CAB               ! 9/NR:11  SectiontypeCable (CABL)
        SEQUENCE
        INTEGER   ID               !        Identification = 11
        INTEGER   IR               !        Identification of section = 3
        INTEGER   IC               !        sectiontype*256 + codeflag*64 + inlet type
        REAL*4      D              ! [1011] Diameter
        INTEGER   TYP(2)           !        Literal of type
        INTEGER   INL              !        Literal of inlet
        REAL*4      NLI            !        no of strands
        REAL*4      NDR            !        no of wires
        REAL*4      F              !        fill factor
        REAL*4      K              !        cable factor
        REAL*4      W              !        weight factor
        REAL*4      KE             !        loss factor
        REAL*4      ZD             ! [1090] design  force
        REAL*4      ZB             ! [1090] rupture force
        REAL*4      GAM            ! [1188] weight
      END TYPE CSECT_CAB
      INTEGER, PARAMETER :: LEN_CSECT_CAB=16
      INTEGER, PARAMETER :: VER_CSECT_CAB=200501

      TYPE CSECT_PRO               ! 9/NR:12  SectiontypeShape (PROF)
        SEQUENCE
        INTEGER   ID               !        Identification = 12
        INTEGER   MNO              !        Materialnumber + 1000*imbedded Materialnumber
        INTEGER   IBIT             !        ityp + 64*iref + ivtp
        INTEGER   TYP              !        type of section
        REAL*4      Z1             !        nominal first size
        REAL*4      Z2             !        nominal second size
        REAL*4      Z3             !        thickness or weight selector
        REAL*4      ALF            ! [   5] rotation angle
        REAL*4      IT             ! [1014] tabul.Tors.Inertia
        REAL*4      YSC            ! [1011] tabul.shear center
        REAL*4      ZSC            ! [1011] tabul.shear center
        REAL*4      H              ! [1011] height
        REAL*4      B              ! [1011] width
        REAL*4      S              ! [1011] thickness of web
        REAL*4      T              ! [1011] thickness of flange
        REAL*4      R1             ! [1011] radius
        REAL*4      R2             ! [1011] radius
        REAL*4      YOFF           ! [1011] y coord. offset
        REAL*4      ZOFF           ! [1011] z coord. offset
        REAL*4      CM             ! [1016] tabul.warp.resist.
        REAL*4      WMIN           ! [1012] charact. warping 1
        REAL*4      WMAX           ! [1012] charact. warping 2
        REAL*4      WT             ! [1018] Torsional resist.
        REAL*4      AY             ! [1012] Shear area
        REAL*4      AZ             ! [1012] Shear area
        INTEGER   RID              !        user defined ident
        REAL*4      WU1            ! [1011] bolt position 1
        REAL*4      WU2            ! [1011] bolt position 2
        REAL*4      WU3            ! [1011] bolt position 3
        REAL*4      YREF           ! [1011] Coordinates of
        REAL*4      ZREF           ! [1011] Reference point
        REAL*4      B2             ! [1011] width lower part
        REAL*4      T2             ! [1011] lower flange thick.
        INTEGER   BEZ(8)           !        character of shape
        REAL*4      VYPL           ! [1102] plastic shear force Vy
        REAL*4      VZPL           ! [1102] plastic shear force Vz
        REAL*4      MTPL           ! [1103] plastic torsional   Mt
        REAL*4      MT2PL          ! [1103] plastic torsional   Mt2
        REAL*4      MBPL           ! [1103] plastic warpmoment  Mb
      END TYPE CSECT_PRO
      INTEGER, PARAMETER :: LEN_CSECT_PRO=46
      INTEGER, PARAMETER :: VER_CSECT_PRO=201311

      TYPE CSECT_TBA               ! 9/NR:18  List of construction stages
        SEQUENCE
        INTEGER   ID               !        Identification = 18
        INTEGER   IBA              !        Headder of construction stages = 0
        INTEGER   IBD              !        Number of materials over all construction stages
        INTEGER   IBAT(64)         !        List of external construction stage numbers
      END TYPE CSECT_TBA
      INTEGER, PARAMETER :: LEN_CSECT_TBA=67
      INTEGER, PARAMETER :: VER_CSECT_TBA=201509

      TYPE CSECT_IBA               ! 9/NR:18  ConstructionStage (CS/BA)
        SEQUENCE
        INTEGER   ID               !        Identification = 18
        INTEGER   IBA              !        number of construction stage BIRTH
        INTEGER   IBD              !        number of construction stage DEATH
        INTEGER   TXT(17)          !        Text
      END TYPE CSECT_IBA
      INTEGER, PARAMETER :: LEN_CSECT_IBA=20
      INTEGER, PARAMETER :: VER_CSECT_IBA=200501

      TYPE CSECT_TXT               ! 9/NR:19  SectionText
        SEQUENCE
        INTEGER   ID               !        Identification = 19
        INTEGER   NR               !        external construction stage number for CS separator
        INTEGER   IDS              !        Source/Selector flag
        INTEGER   TXT(128)         !        Text
      END TYPE CSECT_TXT
      INTEGER, PARAMETER :: LEN_CSECT_TXT=131
      INTEGER, PARAMETER :: VER_CSECT_TXT=200501

      TYPE CSECT_WLS               ! 9/NR:6?  SectionWorklaw Serviceability Analysis
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   N                !        Normal force 0/00
        INTEGER   NTYP             !        Type of law
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CSECT_WLS
      INTEGER, PARAMETER :: LEN_CSECT_WLS=103
      INTEGER, PARAMETER :: VER_CSECT_WLS=200501

      TYPE CSECT_WLU               ! 9/NR:7?  SectionWorklaw Ultimate Analysis
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   N                !        Normal force 0/00
        INTEGER   NTYP             !        Type of law
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CSECT_WLU
      INTEGER, PARAMETER :: LEN_CSECT_WLU=103
      INTEGER, PARAMETER :: VER_CSECT_WLU=200501

      TYPE CSECT_CW                ! 9/NR:80  Hydrodynamic coefficients (WIND/Wave loading)
        SEQUENCE
        INTEGER   ID               !        Identification 80
        INTEGER   IREF             !        Reference of coefficients
        INTEGER   ALF              !        angle of attack in degrees
        REAL*4      CY             !        wind reaction coefficient in y-direction
        REAL*4      CZ             !        wind reaction coefficient in z-direction
        REAL*4      CT             !        wind reaction coefficient for torsional moment
        REAL*4      CHYD           !        hydrodynamic coefficient (Morrison equation)
        REAL*4      CLAT           !        lateral wind reaction coefficient
        REAL*4      S              !        Strouhal number
        REAL*4      AG             !        reserved (must be present to detect old data without chyd)
      END TYPE CSECT_CW
      INTEGER, PARAMETER :: LEN_CSECT_CW=10
      INTEGER, PARAMETER :: VER_CSECT_CW=201301

      TYPE CSECT_WPA               ! 9/NR:81  SectionWindParameters for Wind loading (WPAR)
        SEQUENCE
        INTEGER   ID               !        Identification 81
        INTEGER   IBA              !        construction stage number
        INTEGER   IBIT             !        bitpattern of explicit limits
        REAL*4      KD             ! [1011] equivalent roughness k
        REAL*4      ICE            ! [1011] ice cover
        REAL*4      TRAF           ! [1011] height of traffic lane
        REAL*4      YMIN           ! [1011] wind attack area
        REAL*4      ZMIN           ! [1011] wind attack area
        REAL*4      YMAX           ! [1011] wind attack area
        REAL*4      ZMAX           ! [1011] wind attack area
        REAL*4      YREF           ! [1011] wind moment reference
        REAL*4      ZREF           ! [1011] wind moment reference
        REAL*4      CORN           ! [1011] radius of round edge for rectangular shapes
        REAL*4      CWF            !        explicit factor or value of wind coefficient
        REAL*4      ALF            ! [   5] rotation for default wind coefficients
      END TYPE CSECT_WPA
      INTEGER, PARAMETER :: LEN_CSECT_WPA=15
      INTEGER, PARAMETER :: VER_CSECT_WPA=200501

      TYPE CSECT_WDE               ! 9/NR:82  SectionWindDerivativa for Wind loading (WIND)
        SEQUENCE
        INTEGER   ID               !        Identification 82
        INTEGER   IREF             !        Type of derivativa
        INTEGER   ALF              !        angle of attack in degrees (see 009/NR:80)
        REAL*4      DER(5,20)      !        Derivativa vred,value as splines
      END TYPE CSECT_WDE
      INTEGER, PARAMETER :: LEN_CSECT_WDE=103
      INTEGER, PARAMETER :: VER_CSECT_WDE=200601

      TYPE CSECT_USR               ! 9/NR:90  SectionUserValues (SV/QW)
        SEQUENCE
        INTEGER   ID               !        Identification = 90
        INTEGER   ITP              !        type of control value set
        INTEGER   IVAL             !        value of control flag
        REAL*4      RVAL           !        real value of control flag
        REAL*4      RVALD          !        place to save the original value which has been
      END TYPE CSECT_USR
      INTEGER, PARAMETER :: LEN_CSECT_USR=5
      INTEGER, PARAMETER :: VER_CSECT_USR=200502

      TYPE CSECT_MAT               ! 9/NR:91  SectionalMaterial list
        SEQUENCE
        INTEGER   ID               !        Identification = 91
        INTEGER   MAT(31)          !        material numbers
      END TYPE CSECT_MAT
      INTEGER, PARAMETER :: LEN_CSECT_MAT=32
      INTEGER, PARAMETER :: VER_CSECT_MAT=201507

      TYPE CSECT_VAD               ! 9/NR:97  SectionVarDefaults
        SEQUENCE
        INTEGER   ID               !        Identification = 97/98
        INTEGER   IND1             !        Lower Index of variable
        INTEGER   IND2             !        Upper Index of variable
        INTEGER   IDIM             !        Unit of variable
        INTEGER   NAME(4)          !        Name of variable
        REAL*4      RVAL(1020)     !        values of the variable NAME(I1:I2)
      END TYPE CSECT_VAD
      INTEGER, PARAMETER :: LEN_CSECT_VAD=1028
      INTEGER, PARAMETER :: VER_CSECT_VAD=201310

      TYPE CSECT_VAR               ! 9/NR:98  SectionVarValues
        SEQUENCE
        INTEGER   ID               !        Identification = 97/98
        INTEGER   IND1             !        Lower Index of variable
        INTEGER   IND2             !        Upper Index of variable
        INTEGER   IDIM             !        Unit of variable
        INTEGER   NAME(4)          !        Name of variable
        REAL*4      RVAL(1020)     !        values of the variable NAME(I1:I2)
      END TYPE CSECT_VAR
      INTEGER, PARAMETER :: LEN_CSECT_VAR=1028
      INTEGER, PARAMETER :: VER_CSECT_VAR=201310

      TYPE CSECT_REF               ! 9/NR:99  SectionReference
        SEQUENCE
        INTEGER   ID               !        Identification 099
        INTEGER   IM               !        Type of reference structure definition (see AQUA.ERR)
        INTEGER   IRTS             !        Subtype of reference definition for the points:
        INTEGER   REF(200)         !        Identifier of references (0 = not defined)
      END TYPE CSECT_REF
      INTEGER, PARAMETER :: LEN_CSECT_REF=203
      INTEGER, PARAMETER :: VER_CSECT_REF=200501

      TYPE CSECT_SPT               ! 9/NR:100  SectionStressPoint (SPT/QSP)
        SEQUENCE
        INTEGER   ID               !        Identification 100/101
        INTEGER   MNO              !        Material number
        INTEGER   IDP              !        Number*256 + Bitpattern
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      RT             ! [1011] Radius of arc   (:101) ; effect. thickness (:100)
        REAL*4      WTY            ! [1018] Resistance Torsion
        REAL*4      WVYY           ! [1017] Resistance y-shear
        REAL*4      WVZY           ! [1017] Resistance z-shear
        REAL*4      WT2Y           ! [1018] Resistance 2nd Torsion
        REAL*4      WTZ            ! [1018] Resistance Torsion
        REAL*4      WVYZ           ! [1017] Resistance y-shear
        REAL*4      WVZZ           ! [1017] Resistance z-shear
        REAL*4      WT2Z           ! [1018] Resistance 2nd Torsion
        REAL*4      W0             ! [1012] unit warping
        REAL*4      EPSR           !        non effective strain ratio (0 < epsr <= 1)
        REAL*4      EXP            !        exposition class
        REAL*4      FIX            ! [1011] location of fix point
        REAL*4      SIGD           ! [1092] max. dynamic allowed stress range sig-d(-1)
        REAL*4      TAUD           ! [1092] max dynamic allowed stress range tau-d(-1)
        INTEGER   LITD             !        literal for notch type
        REAL*4      SIGY           ! [1092] stress perpendicular
        REAL*4      AREF           ! [1012] weight (effective area) FE-integration points
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      TEMP1          ! [1215] maximum temperature in history (for damage)
      END TYPE CSECT_SPT
      INTEGER, PARAMETER :: LEN_CSECT_SPT=26
      INTEGER, PARAMETER :: VER_CSECT_SPT=200805

      TYPE CSECT_PPT               ! 9/NR:101  SectionPolygonPoint (POLY/QPOL)
        SEQUENCE
        INTEGER   ID               !        Identification 100/101
        INTEGER   MNO              !        Material number
        INTEGER   IDP              !        Number*256 + Bitpattern
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      RT             ! [1011] Radius of arc   (:101) ; effect. thickness (:100)
        REAL*4      WTY            ! [1018] Resistance Torsion
        REAL*4      WVYY           ! [1017] Resistance y-shear
        REAL*4      WVZY           ! [1017] Resistance z-shear
        REAL*4      WT2Y           ! [1018] Resistance 2nd Torsion
        REAL*4      WTZ            ! [1018] Resistance Torsion
        REAL*4      WVYZ           ! [1017] Resistance y-shear
        REAL*4      WVZZ           ! [1017] Resistance z-shear
        REAL*4      WT2Z           ! [1018] Resistance 2nd Torsion
        REAL*4      W0             ! [1012] unit warping
        REAL*4      EPSR           !        non effective strain ratio (0 < epsr <= 1)
        REAL*4      EXP            !        exposition class
        REAL*4      FIX            ! [1011] location of fix point
        REAL*4      SIGD           ! [1092] max. dynamic allowed stress range sig-d(-1)
        REAL*4      TAUD           ! [1092] max dynamic allowed stress range tau-d(-1)
        INTEGER   LITD             !        literal for notch type
        REAL*4      SIGY           ! [1092] stress perpendicular
        REAL*4      AREF           ! [1012] weight (effective area) FE-integration points
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      TEMP1          ! [1215] maximum temperature in history (for damage)
      END TYPE CSECT_PPT
      INTEGER, PARAMETER :: LEN_CSECT_PPT=26
      INTEGER, PARAMETER :: VER_CSECT_PPT=200910

      TYPE CSECT_CIR               ! 9/NR:102  SectionCircle (CIRC/KREI)
        SEQUENCE
        INTEGER   ID               !        Identification 102
        INTEGER   MNO              !        Material number
        INTEGER   ITP              !        interior construction
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate center
        REAL*4      Z              ! [1011] z-ordinate center
        REAL*4      R              ! [1011] Radius
        REAL*4      RI             ! [1011] Radius hole
        REAL*4      UC             ! [1011] air contact length
      END TYPE CSECT_CIR
      INTEGER, PARAMETER :: LEN_CSECT_CIR=9
      INTEGER, PARAMETER :: VER_CSECT_CIR=200501

      TYPE CSECT_PAN               ! 9/NR:103  SectionPanel (PLAT,WALL)
        SEQUENCE
        INTEGER   ID               !        Identification 103/104
        INTEGER   MNO              !        Material number
        INTEGER   IDP              !        Bit-pattern
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      T              ! [1010] thickness
        REAL*4      WA             ! [1012] unit warping start
        REAL*4      WE             ! [1012] unit warping end
        REAL*4      WT             ! [1018] maximum shear from MT
        REAL*4      WVY            ! [1017] maximum shear from Vy
        REAL*4      WVZ            ! [1017] maximum shear from Vz
        REAL*4      WT2            ! [1018] maximum shear from MT2
        REAL*4      XVY            !        relative Ordinate WVy
        REAL*4      XVZ            !        relative Ordinate WVz
        REAL*4      XMT2           !        relative Ordinate Wt2
        REAL*4      WTBR           !        Bredt torsional shear
        REAL*4      FIXA           ! [1011] location of fix point
        REAL*4      FIXB           ! [1011] location of fix point
        REAL*4      TEFF           ! [1010] effective thickness
        REAL*4      AST            ! [1011] Distance of stiffeners along beam axis
        REAL*4      ETA            !        Reduction factor for local buckling
      END TYPE CSECT_PAN
      INTEGER, PARAMETER :: LEN_CSECT_PAN=24
      INTEGER, PARAMETER :: VER_CSECT_PAN=201803

      TYPE CSECT_WEL               ! 9/NR:104  SectionWeld  (WELD)
        SEQUENCE
        INTEGER   ID               !        Identification 103/104
        INTEGER   MNO              !        Material number
        INTEGER   IDP              !        Bit-pattern
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      T              ! [1010] thickness
        REAL*4      WA             ! [1012] unit warping start
        REAL*4      WE             ! [1012] unit warping end
        REAL*4      WT             ! [1018] maximum shear from MT
        REAL*4      WVY            ! [1017] maximum shear from Vy
        REAL*4      WVZ            ! [1017] maximum shear from Vz
        REAL*4      WT2            ! [1018] maximum shear from MT2
        REAL*4      XVY            !        relative Ordinate WVy
        REAL*4      XVZ            !        relative Ordinate WVz
        REAL*4      XMT2           !        relative Ordinate Wt2
        REAL*4      WTBR           !        Bredt torsional shear
        REAL*4      FIXA           ! [1011] location of fix point
        REAL*4      FIXB           ! [1011] location of fix point
        REAL*4      TEFF           ! [1010] effective thickness
        REAL*4      AST            ! [1011] Distance of stiffeners along beam axis
        REAL*4      ETA            !        Reduction factor for local buckling
      END TYPE CSECT_WEL
      INTEGER, PARAMETER :: LEN_CSECT_WEL=24
      INTEGER, PARAMETER :: VER_CSECT_WEL=201803

      TYPE CSECT_PER               ! 9/NR:110  SectionPeriphery
        SEQUENCE
        INTEGER   ID               !        Identification 110
        INTEGER   MNO              !        Material number
        INTEGER   MN2              !        2nd material number
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate
        REAL*4      ZA             ! [1011] z-ordinate
        REAL*4      YE             ! [1011] y-ordinate
        REAL*4      ZE             ! [1011] z-ordinate
        REAL*4      AIR            !        air contact ratio
      END TYPE CSECT_PER
      INTEGER, PARAMETER :: LEN_CSECT_PER=9
      INTEGER, PARAMETER :: VER_CSECT_PER=200708

      TYPE CSECT_FEM               ! 9/NR:112  SectionTopology
        SEQUENCE
        INTEGER   ID               !        Identification 111
        INTEGER   MNO              !        Material number
        INTEGER   NREL             !        internal element number
        INTEGER   NODE(4)          !        internal element nodes
      END TYPE CSECT_FEM
      INTEGER, PARAMETER :: LEN_CSECT_FEM=7
      INTEGER, PARAMETER :: VER_CSECT_FEM=201301

      TYPE CSECT_NER               ! 9/NR:190  SectionNonEffectiveRectangle (NEFF)
        SEQUENCE
        INTEGER   ID               !        Identification 190
        INTEGER   MNO              !        Material number
        INTEGER   IDP              !        Noneffective for (same bits as :101)
        INTEGER   TNR              !        Designation
        REAL*4      YMIN           ! [1011] y-ordinate
        REAL*4      ZMIN           ! [1011] z-ordinate
        REAL*4      YMAX           ! [1011] y-ordinate
        REAL*4      ZMAX           ! [1011] z-ordinate
        REAL*4      T              ! [1011] thickness
        REAL*4      SMIN           ! [1092] stress at point (ymin,zmin)
        REAL*4      SMAX           ! [1092] stress at point (ymax,zmax)
      END TYPE CSECT_NER
      INTEGER, PARAMETER :: LEN_CSECT_NER=11
      INTEGER, PARAMETER :: VER_CSECT_NER=201511

      TYPE CSECT_NEP               ! 9/NR:191  Partial non effective polygons
        SEQUENCE
        INTEGER   ID               !        Identification 191
        INTEGER   MNO              !        Materialnumber
        INTEGER   IDP              !        Noneffective for (see :190)
        INTEGER   TNR              !        Ident from 190 / Cut identifier for :312 elements
        REAL*4      YZ(2,511)      ! [1011] yz(2,*) = vertices (old format is blocked with 7 points
      END TYPE CSECT_NEP
      INTEGER, PARAMETER :: LEN_CSECT_NEP=1026
      INTEGER, PARAMETER :: VER_CSECT_NEP=200810

      TYPE CSECT_PRF               ! 9/NR:200  SectionPointReinforcement (RF/BEW)
        SEQUENCE
        INTEGER   ID               !        Identification 200
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      SIG            ! [1092] prestress
        REAL*4      TEMP           ! [1215] Temperature
        REAL*4      AS             ! [1020] Reinforcement area
        REAL*4      ASMA           ! [1020] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1012] Reference area
        REAL*4      A              ! [1011] distance of bars
      END TYPE CSECT_PRF
      INTEGER, PARAMETER :: LEN_CSECT_PRF=15
      INTEGER, PARAMETER :: VER_CSECT_PRF=200501

      TYPE CSECT_LRF               ! 9/NR:201  SectionLineReinforcement (LRF/LBEW)
        SEQUENCE
        INTEGER   ID               !        Identification 201/211/221 or 321
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      R              ! [1011] Radius
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_LRF
      INTEGER, PARAMETER :: LEN_CSECT_LRF=18
      INTEGER, PARAMETER :: VER_CSECT_LRF=200501

      TYPE CSECT_LRP               ! 9/NR:211  SectionLineReinforcement in Points
        SEQUENCE
        INTEGER   ID               !        Identification 201/211/221 or 321
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      R              ! [1011] Radius
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_LRP
      INTEGER, PARAMETER :: LEN_CSECT_LRP=18
      INTEGER, PARAMETER :: VER_CSECT_LRP=201302

      TYPE CSECT_LSL               ! 9/NR:221  SectionShearLink
        SEQUENCE
        INTEGER   ID               !        Identification 201/211/221 or 321
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      R              ! [1011] Radius
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_LSL
      INTEGER, PARAMETER :: LEN_CSECT_LSL=18
      INTEGER, PARAMETER :: VER_CSECT_LSL=201112

      TYPE CSECT_CRF               ! 9/NR:202  SectionCircularReinforcement (CRF/KBEW)
        SEQUENCE
        INTEGER   ID               !        Identification 202/212/222
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate center
        REAL*4      Z              ! [1011] z-ordinate center
        REAL*4      R              ! [1011] Radius
        REAL*4      I_4
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_CRF
      INTEGER, PARAMETER :: LEN_CSECT_CRF=17
      INTEGER, PARAMETER :: VER_CSECT_CRF=200501

      TYPE CSECT_CRP               ! 9/NR:212  SectionCircularReinforcement in Points
        SEQUENCE
        INTEGER   ID               !        Identification 202/212/222
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate center
        REAL*4      Z              ! [1011] z-ordinate center
        REAL*4      R              ! [1011] Radius
        REAL*4      I_4
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_CRP
      INTEGER, PARAMETER :: LEN_CSECT_CRP=17
      INTEGER, PARAMETER :: VER_CSECT_CRP=201210

      TYPE CSECT_CSL               ! 9/NR:222  SectionHelicalShearLink
        SEQUENCE
        INTEGER   ID               !        Identification 202/212/222
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate center
        REAL*4      Z              ! [1011] z-ordinate center
        REAL*4      R              ! [1011] Radius
        REAL*4      I_4
        REAL*4      AS             ! [1029] Reinforc. area
        REAL*4      ASMA           ! [1029] max Reinforcement area
        REAL*4      RNG            !        Layer number
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Diameter
        REAL*4      AREF           ! [1019] Reference area = width of element
        REAL*4      A              ! [1011] distance of bars
        REAL*4      PHIA           ! [   5] start angle for generated points
        REAL*4      PHIE           ! [   5] end   angle for generated points
      END TYPE CSECT_CSL
      INTEGER, PARAMETER :: LEN_CSECT_CSL=17
      INTEGER, PARAMETER :: VER_CSECT_CSL=201112

      TYPE CSECT_URF               ! 9/NR:210  SectionPeriphericReinforcement (CURF,UBEW)
        SEQUENCE
        INTEGER   ID               !        Identification 210/220
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      COVER          ! [1024] static cover
        INTEGER   EXP(2)           !        Exposition class
        REAL*4      WC             !        weight for centering reinforcement
        REAL*4      AS             ! [1021] Reinforc. area/length
        REAL*4      ASMA           ! [1021] max Reinforcement area
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Bar Diameter
        REAL*4      AREF           ! [1019] Reference area for crack width
        REAL*4      A              ! [1011] distance of bars
      END TYPE CSECT_URF
      INTEGER, PARAMETER :: LEN_CSECT_URF=14
      INTEGER, PARAMETER :: VER_CSECT_URF=201302

      TYPE CSECT_USL               ! 9/NR:220  SectionPeriphericShearLink
        SEQUENCE
        INTEGER   ID               !        Identification 210/220
        INTEGER   MNO              !        Material number
        INTEGER   IR               !        Layer number
        INTEGER   TNR              !        Designation
        REAL*4      COVER          ! [1024] static cover
        INTEGER   EXP(2)           !        Exposition class
        REAL*4      WC             !        weight for centering reinforcement
        REAL*4      AS             ! [1021] Reinforc. area/length
        REAL*4      ASMA           ! [1021] max Reinforcement area
        REAL*4      FT             !        torsional effect
        REAL*4      D              ! [1023] Bar Diameter
        REAL*4      AREF           ! [1019] Reference area for crack width
        REAL*4      A              ! [1011] distance of bars
      END TYPE CSECT_USL
      INTEGER, PARAMETER :: LEN_CSECT_USL=14
      INTEGER, PARAMETER :: VER_CSECT_USL=201302

      TYPE CSECT_CPT               ! 9/NR:300  SectionCutStressPoint
        SEQUENCE
        INTEGER   ID               !        Identification 300
        INTEGER   MNO              !        Material of Reinforc. + 1000*Materialnumber
        INTEGER   BIT              !        Cut-Index*128 + Bitpattern
        INTEGER   TNR              !        Designation
        REAL*4      Y              ! [1011] y-ordinate
        REAL*4      Z              ! [1011] z-ordinate
        REAL*4      B0             ! [1011] width of cut
        REAL*4      WTM            ! [1018] Resistance Torsion
        REAL*4      WTR            ! [1018] Resistance max Torsion
        REAL*4      WVY            ! [1017] Resistance y-shear
        REAL*4      WVZ            ! [1017] Resistance z-shear
        REAL*4      FRS            !        Factor for total reinf
        REAL*4      W0             ! [1012] unit warping
        REAL*4      SIGY           ! [1092] stress perpendicular
        REAL*4      BB             ! [1011] total width of cut
        REAL*4      VYFK           !        part of total y-shear
        REAL*4      VZFK           !        part of total z-shear
        REAL*4      BQFK           !        partial width factor
        REAL*4      BYFK           ! [1011] shear design width for Vy
        REAL*4      BZFK           ! [1011] shear design width for Vz
      END TYPE CSECT_CPT
      INTEGER, PARAMETER :: LEN_CSECT_CPT=20
      INTEGER, PARAMETER :: VER_CSECT_CPT=200501

      TYPE CSECT_CUT               ! 9/NR:301  ShearCut (CUT)
        SEQUENCE
        INTEGER   ID               !        Identification 301
        INTEGER   MNO              !        Material of Reinforc. + 1000*Materialnumber
        INTEGER   IDP              !        Bitpattern
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      B0             ! [1011] effective width
        REAL*4      N              ! [1111] Normal force perpend.
        REAL*4      M              ! [1114] bending moment perpend
        REAL*4      WTM            ! [1018] Resistance Torsion mid
        REAL*4      WTD            ! [1018] add tors.resist.edge
        REAL*4      VYFK           !        part of total y-shear
        REAL*4      VZFK           !        part of total z-shear
        REAL*4      BV             ! [1011] total effective width
        REAL*4      PHIB           ! [   5] inclination stirups
        REAL*4      IRB            !        number of shearlayer
        REAL*4      TY             ! [  17] unit shear Sy/Iz
        REAL*4      TZ             ! [  17] unit shear Sz/Iy
        REAL*4      BRED           ! [1011] reduction for ducts
        REAL*4      ASBM           !        Minimum shear reinf.
        REAL*4      BETC           !        friction coefficient
        REAL*4      MUE            !        friction in joint
        REAL*4      ACT            ! [1012] Area of cut off
        REAL*4      KSL            !        parameters for plate
        REAL*4      SXE            ! [1011] crack spacing for AASTHO
        REAL*4      COTT           !        explicit selected inclination for truss model
        REAL*4      BMIN           ! [1011] minimum of cut width
        REAL*4      BMAX           ! [1011] maximum of cut width
      END TYPE CSECT_CUT
      INTEGER, PARAMETER :: LEN_CSECT_CUT=30
      INTEGER, PARAMETER :: VER_CSECT_CUT=201803

      TYPE CSECT_CPL               ! 9/NR:311  Partial polygons of shear cut
        SEQUENCE
        INTEGER   ID               !        Identification 311
        INTEGER   MNO              !        Materialnumber
        INTEGER   IDP              !        Cut number (0=continue last one)
        INTEGER   TNR              !        Designation of cut
        REAL*4      YZ(2,511)      ! [1011] yz(2,*) = up to seven vertices
      END TYPE CSECT_CPL
      INTEGER, PARAMETER :: LEN_CSECT_CPL=1026
      INTEGER, PARAMETER :: VER_CSECT_CPL=0

      TYPE CSECT_APL               ! 9/NR:313  Partial polygons of AKT crack area
        SEQUENCE
        INTEGER   ID               !        Identification 311
        INTEGER   MNO              !        Materialnumber
        INTEGER   IDP              !        Cut number (0=continue last one)
        INTEGER   TNR              !        Designation of cut
        REAL*4      YZ(2,511)      ! [1011] yz(2,*) = up to seven vertices
      END TYPE CSECT_APL
      INTEGER, PARAMETER :: LEN_CSECT_APL=1026
      INTEGER, PARAMETER :: VER_CSECT_APL=0

      TYPE CSECT_HYD               ! 9/NR:900  SectionalHydraulics total section
        SEQUENCE
        INTEGER   ID               !        Identification = 900/903
        INTEGER   I_1
        INTEGER   I_2
        REAL*4      A              ! [1012] Area
        REAL*4      UT             ! [1011] total periphery
        REAL*4      UP             ! [1011] total wet periphery
        REAL*4      R              ! [1011] hydraulic radius
        REAL*4      ZET1           !        loss factor 1
        REAL*4      ZET2           !        loss factor 2
        REAL*4      SLK            !        total leakage
        REAL*4      YS             ! [1011] y-Ordinate Center
        REAL*4      ZS             ! [1011] y-Ordinate Center
      END TYPE CSECT_HYD
      INTEGER, PARAMETER :: LEN_CSECT_HYD=12
      INTEGER, PARAMETER :: VER_CSECT_HYD=200501

      TYPE CSECT_HYP               ! 9/NR:903  SectionalHydraulics partial section
        SEQUENCE
        INTEGER   ID               !        Identification = 900/903
        INTEGER   I_1
        INTEGER   I_2
        REAL*4      A              ! [1012] Area
        REAL*4      UT             ! [1011] total periphery
        REAL*4      UP             ! [1011] total wet periphery
        REAL*4      R              ! [1011] hydraulic radius
        REAL*4      ZET1           !        loss factor 1
        REAL*4      ZET2           !        loss factor 2
        REAL*4      SLK            !        total leakage
        REAL*4      YS             ! [1011] y-Ordinate Center
        REAL*4      ZS             ! [1011] y-Ordinate Center
      END TYPE CSECT_HYP
      INTEGER, PARAMETER :: LEN_CSECT_HYP=12
      INTEGER, PARAMETER :: VER_CSECT_HYP=200501

      TYPE CSECT_HYA               ! 9/NR:904  SectionalHydraulicsAddval
        SEQUENCE
        INTEGER   ID               !        identifier 904
        INTEGER   I_2
        INTEGER   TYPE             !        type of section
        REAL*4      NW             !        Nominal width
        REAL*4      YMIN           ! [1011] Minimum Ordinate of section
        REAL*4      YMAX           ! [1011] Maximum Ordinate of section
        REAL*4      ZMIN           ! [1011] Minimum Ordinate of section
        REAL*4      ZMAX           ! [1011] Maximum Ordinate of section
        REAL*4      KS             ! [  16] absolute roughness
        REAL*4      S              !        storage coefficient
        REAL*4      I_8            !        reserved
        REAL*4      I_9            !        reserved
        REAL*4      I_10           !        reserved
        REAL*4      HP             ! [1010] lift of pump
        REAL*4      LMIN           !        minimum power
        REAL*4      LMAX           !        maximum power
        REAL*4      QMAX           !        maximum delivery
      END TYPE CSECT_HYA
      INTEGER, PARAMETER :: LEN_CSECT_HYA=17
      INTEGER, PARAMETER :: VER_CSECT_HYA=200501

      TYPE CSECT_HYS               ! 9/NR:910  SectionalHydraulicsPolygon
        SEQUENCE
        INTEGER   ID               !        Identification 910
        INTEGER   MAT              !        identifier 0 (material number)
        INTEGER   NR               !        number of side
        INTEGER   TNR              !        Designation
        REAL*4      YA             ! [1011] y-ordinate start
        REAL*4      ZA             ! [1011] z-ordinate start
        REAL*4      YE             ! [1011] y-ordinate end
        REAL*4      ZE             ! [1011] z-ordinate end
        REAL*4      KS             ! [  16] absolute roughness
        REAL*4      SLK            !        leakage
      END TYPE CSECT_HYS
      INTEGER, PARAMETER :: LEN_CSECT_HYS=10
      INTEGER, PARAMETER :: VER_CSECT_HYS=200501

      TYPE CSECT_INS               ! 9/NR:100002  structural database contents
        SEQUENCE
        INTEGER   ID               !        Identification of record key
        INTEGER   KWH              !        Identification of record key (30/31/32)
        INTEGER   KWL              !        Identification of record key (=NR)
        INTEGER   IB(1)            !        buffer of record contents for record KWH/KWL
                                   !        unknwon length!
      END TYPE CSECT_INS
      INTEGER, PARAMETER :: LEN_CSECT_INS=4
      INTEGER, PARAMETER :: VER_CSECT_INS=0


      INTEGER, PARAMETER :: SECT_KWH = 9

      END MODULE CDB_TYPES_SCT

!     end of automatically generated header
!     SOFiSTiK AG
!
