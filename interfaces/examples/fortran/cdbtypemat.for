!     cdbtypemat.for
!     SOFiSTiK AG
!     automatically generated header, no use to modify

      MODULE CDB_TYPES_MAT

      INTEGER, PARAMETER, PUBLIC :: MAXMAT=999

      TYPE CDBMAT   !  GENERIC DATA WITH TWO INTEGERS
           SEQUENCE
           INTEGER IS(0:2)
           REAL    SS(255)
      END TYPE CDBMAT
      INTEGER, PARAMETER    :: LEN_CDBMAT=3+255

      INTEGER, PARAMETER :: MAT_CONS_GW=701
      INTEGER, PARAMETER :: MAT_CONS_GP=702
      INTEGER, PARAMETER :: MAT_CONS_GM=703
      INTEGER, PARAMETER :: MAT_CONS_GC=704
      INTEGER, PARAMETER :: MAT_CONS_SW=705
      INTEGER, PARAMETER :: MAT_CONS_SP=706
      INTEGER, PARAMETER :: MAT_CONS_SM=707
      INTEGER, PARAMETER :: MAT_CONS_SC=708
      INTEGER, PARAMETER :: MAT_CONS_SAND=709
      INTEGER, PARAMETER :: MAT_CONS_ML=711
      INTEGER, PARAMETER :: MAT_CONS_MI=712
      INTEGER, PARAMETER :: MAT_CONS_MH=713
      INTEGER, PARAMETER :: MAT_CONS_CL=715
      INTEGER, PARAMETER :: MAT_CONS_CI=716
      INTEGER, PARAMETER :: MAT_CONS_CH=717
      INTEGER, PARAMETER :: MAT_CONS_CLAY=719
      INTEGER, PARAMETER :: MAT_CONS_ROC1=721
      INTEGER, PARAMETER :: MAT_CONS_ROC2=722
      INTEGER, PARAMETER :: MAT_CONS_ROC3=723
      INTEGER, PARAMETER :: MAT_CONS_ROC4=724
      INTEGER, PARAMETER :: MAT_CONS_AIR=801
      INTEGER, PARAMETER :: MAT_CONS_H2O=802
      INTEGER, PARAMETER :: MAT_CONS_CO2=803
      INTEGER, PARAMETER :: MAT_CONS_O2=804
      INTEGER, PARAMETER :: MAT_CONS_N2=805
      INTEGER, PARAMETER :: MAT_CONS_CH4=806
      INTEGER, PARAMETER :: MAT_CONS_HE=809
      INTEGER, PARAMETER :: MAT_CONS_NE=810
      INTEGER, PARAMETER :: MAT_CONS_AR=811
      INTEGER, PARAMETER :: MAT_CONS_KR=812
      INTEGER, PARAMETER :: MAT_CONS_XE=813
      INTEGER, PARAMETER :: MAT_CONS_SF6=814
      INTEGER, PARAMETER :: MAT_CONS_GLAS=901
      INTEGER, PARAMETER :: MAT_CONS_ESG=902
      INTEGER, PARAMETER :: MAT_CONS_VSGH=903
      INTEGER, PARAMETER :: MAT_CONS_VSGV=904
      INTEGER, PARAMETER :: MAT_CONS_TVG=905
      INTEGER, PARAMETER :: MAT_CONS_CU=906
      INTEGER, PARAMETER :: MAT_CONS_PB=907
      INTEGER, PARAMETER :: MAT_CONS_MG=908
      INTEGER, PARAMETER :: MAT_CONS_W=909
      INTEGER, PARAMETER :: MAT_CONS_ZN=910
      INTEGER, PARAMETER :: MAT_CONS_BRAS=911
      INTEGER, PARAMETER :: MAT_CONS_BRON=912
      INTEGER, PARAMETER :: MAT_CONS_BRIC=925
      INTEGER, PARAMETER :: MAT_CONS_SLBR=926
      INTEGER, PARAMETER :: MAT_CONS_CLIN=927
      INTEGER, PARAMETER :: MAT_CONS_IGYP=930
      INTEGER, PARAMETER :: MAT_CONS_GYPS=931
      INTEGER, PARAMETER :: MAT_CONS_MOGY=932
      INTEGER, PARAMETER :: MAT_CONS_MOCH=933
      INTEGER, PARAMETER :: MAT_CONS_MOCE=934
      INTEGER, PARAMETER :: MAT_CONS_ASPH=937
      INTEGER, PARAMETER :: MAT_CONS_BITU=938
      INTEGER, PARAMETER :: MAT_CONS_CARP=941
      INTEGER, PARAMETER :: MAT_CONS_WOOL=942
      INTEGER, PARAMETER :: MAT_CONS_CORK=943
      INTEGER, PARAMETER :: MAT_CONS_LINO=944
      INTEGER, PARAMETER :: MAT_CONS_EPOX=946
      INTEGER, PARAMETER :: MAT_CONS_PHEN=947
      INTEGER, PARAMETER :: MAT_CONS_PEST=948
      INTEGER, PARAMETER :: MAT_CONS_ACRY=949
      INTEGER, PARAMETER :: MAT_CONS_PC=950
      INTEGER, PARAMETER :: MAT_CONS_PTFE=951
      INTEGER, PARAMETER :: MAT_CONS_PVC=952
      INTEGER, PARAMETER :: MAT_CONS_PMMA=953
      INTEGER, PARAMETER :: MAT_CONS_POM=954
      INTEGER, PARAMETER :: MAT_CONS_PA=955
      INTEGER, PARAMETER :: MAT_CONS_PEHD=956
      INTEGER, PARAMETER :: MAT_CONS_PELD=957
      INTEGER, PARAMETER :: MAT_CONS_PS=958
      INTEGER, PARAMETER :: MAT_CONS_PP=959
      INTEGER, PARAMETER :: MAT_CONS_PUR=960
      INTEGER, PARAMETER :: MAT_CONS_RUBB=961
      INTEGER, PARAMETER :: MAT_CONS_NEOP=962
      INTEGER, PARAMETER :: MAT_CONS_EBON=963
      INTEGER, PARAMETER :: MAT_CONS_EPDM=964
      INTEGER, PARAMETER :: MAT_CONS_PSUL=965
      INTEGER, PARAMETER :: MAT_CONS_BUTA=966
      INTEGER, PARAMETER :: MAT_CONS_SI=967
      INTEGER, PARAMETER :: MAT_CONS_SILA=968
      INTEGER, PARAMETER :: MAT_CONS_FOAM=973
      INTEGER, PARAMETER :: MAT_CONS_FOAS=974
      INTEGER, PARAMETER :: MAT_CONS_FOAU=975
      INTEGER, PARAMETER :: MAT_CONS_FOAC=976
      INTEGER, PARAMETER :: MAT_CONS_FOAR=977
      INTEGER, PARAMETER :: MAT_CONS_FOAE=978
      INTEGER, PARAMETER :: MAT_CONS_LAY=999
      TYPE CMAT                    ! 1/NR:0  MaterialTitle
        SEQUENCE
        INTEGER   ID               !        Identification = 0
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        INTEGER   TITLE(17)        !        designation
      END TYPE CMAT
      INTEGER, PARAMETER :: LEN_CMAT=20
      INTEGER, PARAMETER :: VER_CMAT=200501

      TYPE CMAT_USER               ! 1/NR:10??  Information on user input
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   BIT(32)          !        User input for 001/NR:1
      END TYPE CMAT_USER
      INTEGER, PARAMETER :: LEN_CMAT_USER=33
      INTEGER, PARAMETER :: VER_CMAT_USER=0

      TYPE CMAT_FLUI               ! 1/NR:1  MaterialConstants
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Compression modulus
        REAL*4      NUE            ! [1221] Kinematic Viscosity
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      RHO            ! [1189] Density
        REAL*4      GAMB           ! [1091] dead weight buyoncy
        REAL*4      ALFA           ! [ 107] Temperature Elongation coefficient
      END TYPE CMAT_FLUI
      INTEGER, PARAMETER :: LEN_CMAT_FLUI=10
      INTEGER, PARAMETER :: VER_CMAT_FLUI=200502

      INTEGER, PARAMETER :: MAT_CONS_LINE=0
      INTEGER, PARAMETER :: MAT_CONS_MISE=1
      INTEGER, PARAMETER :: MAT_CONS_MOHR=2
      INTEGER, PARAMETER :: MAT_CONS_GUDE=3
      INTEGER, PARAMETER :: MAT_CONS_ROCK=4
      INTEGER, PARAMETER :: MAT_CONS_LADE=5
      INTEGER, PARAMETER :: MAT_CONS_DUNC=6
      INTEGER, PARAMETER :: MAT_CONS_HYPO=7
      INTEGER, PARAMETER :: MAT_CONS_MEMB=8
      INTEGER, PARAMETER :: MAT_CONS_GRAN=10
      INTEGER, PARAMETER :: MAT_CONS_CAMC=11
      INTEGER, PARAMETER :: MAT_CONS_UNDR=14
      INTEGER, PARAMETER :: MAT_CONS_FAIL=15
      INTEGER, PARAMETER :: MAT_CONS_SWEL=16
      INTEGER, PARAMETER :: MAT_CONS_VMIS=17
      INTEGER, PARAMETER :: MAT_CONS_DRUC=18
      TYPE CMAT_CONS               ! 1/NR:1  MaterialConstants
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      GAMB           ! [1091] dead weight buyoncy
        REAL*4      ALFA           ! [ 107] Temperature Expansion
        REAL*4      E90            ! [1090] Transvers Elasticity
        REAL*4      MUE90          !        anisotrope Poisson
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FY             ! [1092] effective strength
        REAL*4      FT             ! [1092] nominal strength
        REAL*4      P(18)          !        variable parameters
      END TYPE CMAT_CONS
      INTEGER, PARAMETER :: LEN_CMAT_CONS=35
      INTEGER, PARAMETER :: VER_CMAT_CONS=200502

      TYPE CMAT_UNDR               ! 1/NR:14  Undrained soil parameters
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      GAMB           ! [1091] dead weight buyoncy
        REAL*4      ALFA           ! [ 107] Temperature Expansion
        REAL*4      E90            ! [1090] Transvers Elasticity
        REAL*4      MUE90          !        anisotrope Poisson
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FY             ! [1092] effective strength
        REAL*4      FT             ! [1092] nominal strength
        REAL*4      P(18)          !        variable parameters
      END TYPE CMAT_UNDR
      INTEGER, PARAMETER :: LEN_CMAT_UNDR=35
      INTEGER, PARAMETER :: VER_CMAT_UNDR=201302

      TYPE CMAT_FAUL               ! 1/NR:15  Fault/Shear plane
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      GAMB           ! [1091] dead weight buyoncy
        REAL*4      ALFA           ! [ 107] Temperature Expansion
        REAL*4      E90            ! [1090] Transvers Elasticity
        REAL*4      MUE90          !        anisotrope Poisson
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FY             ! [1092] effective strength
        REAL*4      FT             ! [1092] nominal strength
        REAL*4      P(18)          !        variable parameters
      END TYPE CMAT_FAUL
      INTEGER, PARAMETER :: LEN_CMAT_FAUL=35
      INTEGER, PARAMETER :: VER_CMAT_FAUL=200501

      TYPE CMAT_SWEL               ! 1/NR:16  Swelling parameters
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      GAMB           ! [1091] dead weight buyoncy
        REAL*4      ALFA           ! [ 107] Temperature Expansion
        REAL*4      E90            ! [1090] Transvers Elasticity
        REAL*4      MUE90          !        anisotrope Poisson
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FY             ! [1092] effective strength
        REAL*4      FT             ! [1092] nominal strength
        REAL*4      P(18)          !        variable parameters
      END TYPE CMAT_SWEL
      INTEGER, PARAMETER :: LEN_CMAT_SWEL=35
      INTEGER, PARAMETER :: VER_CMAT_SWEL=200501

      TYPE CMAT_CONC               ! 1/NR:1  MaterialConcrete
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      RHO            ! [1189] Density
        REAL*4      ALFA           ! [ 107] Temperature Elongation coefficient
        REAL*4      E90            ! [1090] Elasticity modulus perpendicular
        REAL*4      MUE90          !        Poissons ratio perpendicular
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FC             ! [1092] effective strength
        REAL*4      FCK            ! [1092] nominal strength
        REAL*4      FTM            ! [1092] mean value of tensional strength
        REAL*4      FTL            ! [1092] lower fractile of tensional strength
        REAL*4      FTK            ! [1092] upper fractile of tensional strength
        REAL*4      EC             !        compr. failure Energy (deprecated)
        REAL*4      ET             ! [ 112] tensile failure energy
        REAL*4      MUER           !        friction in the crack
        REAL*4      FCM            ! [1092] mean value of strength
        REAL*4      RDCL           !        weight class
        REAL*4      FCR            ! [1092] calculatoric mean value of strength
        REAL*4      ECR            ! [1090] Elasticity modul for worklaw CE
        REAL*4      FBD            ! [1092] bond strength (EC2 Table. 5.1.3)
        REAL*4      FTD            ! [1092] Initial tensile strength Bemessungszugfestigkeit
        REAL*4      FEQR           ! [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
        REAL*4      FEQT           ! [1092] Residual tensile strength  Restzugfestigkeit im Bruch
        REAL*4      FCFAT          ! [1092] Fatigue Strength
        REAL*4      SCMS           !        Material safety for the serviceability law
        REAL*4      SCMU           !        Material safety for ultimate stress strain law
        REAL*4      SCMC           !        Material safety for the calculatoric law
      END TYPE CMAT_CONC
      INTEGER, PARAMETER :: LEN_CMAT_CONC=35
      INTEGER, PARAMETER :: VER_CMAT_CONC=200501

      TYPE CMAT_STEE               ! 1/NR:1  MaterialSteel
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      RHO            ! [1189] Density
        REAL*4      ALFA           ! [ 107] Temperature Elongation coefficient
        REAL*4      E90            ! [1090] Elasticity modulus perpendicular
        REAL*4      MUE90          !        Poissons ratio perpendicular
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FY             ! [1092] yield stress
        REAL*4      FT             ! [1092] tensile strength
        REAL*4      EPS            ! [   9] limit strain
        REAL*4      REL1           !        Relaxation 0.55fpk
        REAL*4      REL2           !        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
        REAL*4      R              !        bond coefficient
        REAL*4      K1             !        bondfactor EC2
        REAL*4      EH             ! [1090] Hardening module
        REAL*4      FE             ! [1092] Proportional stress
        REAL*4      EPSE           ! [   9] Plastic strain
        REAL*4      FDYN           ! [1092] Dynamic strength
        REAL*4      FYC            ! [1092] compr. yield stress
        REAL*4      FTC            ! [1092] compress. strength
        REAL*4      TMAX           ! [1023] max.plate thickness
        REAL*4      BC             !        (eg. Aluminium 1.0/2.0 = "A","B" )
        REAL*4      DUMMY(2)
        REAL*4      SCMS           !        Material safety for the serviceability law
        REAL*4      SCMU           !        Material safety for ultimate stress strain law
        REAL*4      SCMC           !        Material safety for the calculatoric law
      END TYPE CMAT_STEE
      INTEGER, PARAMETER :: LEN_CMAT_STEE=35
      INTEGER, PARAMETER :: VER_CMAT_STEE=200501

      TYPE CMAT_TIMB               ! 1/NR:1  MaterialTimber
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Material type
        INTEGER   CLASS            !        Classification
        REAL*4      EMOD           ! [1090] Elasticity Modulus along the fibres
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      RHO            ! [1189] Density
        REAL*4      ALFA           ! [ 107] Temperature Elongation coefficient
        REAL*4      E90            ! [1090] Elasticity modulus perpendicular to fibres
        REAL*4      MUE90          !        Poissons ratio perpendicular
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FYB            ! [1092] Bending strength
        REAL*4      FYT            ! [1092] tensile strength along the fibres
        REAL*4      FYT90          ! [1092] tensile strength perpend. the fibres
        REAL*4      FYC            ! [1092] compressive strength along the fibres
        REAL*4      FYC90          ! [1092] compressive strength perpend. the fibres
        REAL*4      FYS            ! [1092] middle shear strength (Membrane Shear force)
        REAL*4      FYST           ! [1092] edge shear strength (Torsion)
        REAL*4      FYSB           ! [1092] maximum shear strength (plate shear)
        REAL*4      FYB90          ! [1092] Bending strength perpendicular to fibres
        REAL*4      G90            ! [1090] transverse shear modulus for platebending
        REAL*4      SMOD0          !        Strength Modifier kmod for Service classes
        REAL*4      SMOD1          !        Strength Modifier kmod for Service classes
        REAL*4      SMOD2          !        Strength Modifier kmod for Service classes
        REAL*4      SMOD3          !        Strength Modifier kmod for Service classes
        REAL*4      SMOD4          !        Strength Modifier kmod for Service classes
        REAL*4      KDEF           !        Deformation modifier
        REAL*4      TMAX           ! [1023] max.plate thickness
        REAL*4      SCMS           !        Material safety
        REAL*4      SCMU           !        Material safety
        REAL*4      SCMC           !        Material safety
      END TYPE CMAT_TIMB
      INTEGER, PARAMETER :: LEN_CMAT_TIMB=35
      INTEGER, PARAMETER :: VER_CMAT_TIMB=200501

      TYPE CMAT_BRIC               ! 1/NR:1  MaterialBrickwork
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TYPE             !        Bric type and strength
        INTEGER   CLASS            !        Mortar class
        REAL*4      EMOD           ! [1090] Elasticity Modulus
        REAL*4      MUE            !        Poissons ratio
        REAL*4      GMOD           ! [1090] Shear modulus
        REAL*4      KMOD           ! [1090] Compression modulus
        REAL*4      GAM            ! [1091] dead weight
        REAL*4      RHO            ! [1189] Density
        REAL*4      ALFA           ! [ 107] Temperature Elongation coefficient
        REAL*4      E90            ! [1090] Elasticity modulus perpendicular
        REAL*4      MUE90          !        Poissons ratio perpendicular
        REAL*4      ALF            ! [   5] Euler Angle I
        REAL*4      BET            ! [   5] Euler Angle II
        REAL*4      SCM            !        Material safety
        REAL*4      FK             ! [1092] Strength
        REAL*4      FB             ! [1092] brick strength
        REAL*4      FT             ! [1092] tensile strength
        REAL*4      FV             ! [1092] shear strength
        REAL*4      FV0            ! [1092] adhesional strength
        REAL*4      FBT            ! [1092] tens.brick strength
        REAL*4      FM             ! [1092] mortar strength
        REAL*4      DUMMY(10)
        REAL*4      SCMS           !        Material safety
        REAL*4      SCMU           !        Material safety
        REAL*4      SCMC           !        Material safety
      END TYPE CMAT_BRIC
      INTEGER, PARAMETER :: LEN_CMAT_BRIC=35
      INTEGER, PARAMETER :: VER_CMAT_BRIC=200501

      TYPE CMAT_SERV               ! 1/NR:2  StressStrainLaw (Servicability)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TEMP             !        Temperature
        INTEGER   TYPE             !        Type of law
        REAL*4      SCM            !        Safety factor
        REAL*4      EPS            ! [   9] Elongation at TEMP if TEMP>0
        REAL*4      RES1           ! [   9] Shift of strains TEMP>0 (-TempStrain)
        REAL*4      RES2           !        Tensile Strength  Concrete   for 21:24
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CMAT_SERV
      INTEGER, PARAMETER :: LEN_CMAT_SERV=107
      INTEGER, PARAMETER :: VER_CMAT_SERV=200501

      TYPE CMAT_ULTI               ! 1/NR:3  StressStrainLaw (Ultimate Limit state)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TEMP             !        Temperature
        INTEGER   TYPE             !        Type of law
        REAL*4      SCM            !        Safety factor
        REAL*4      EPS            ! [   9] Elongation at TEMP if TEMP>0
        REAL*4      RES1           ! [   9] Shift of strains TEMP>0 (-TempStrain)
        REAL*4      RES2           !        Tensile Strength  Concrete   for 21:24
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CMAT_ULTI
      INTEGER, PARAMETER :: LEN_CMAT_ULTI=107
      INTEGER, PARAMETER :: VER_CMAT_ULTI=200501

      TYPE CMAT_NONL               ! 1/NR:4  StressStrainLaw (Nonlinear Mean Values)
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   TEMP             !        Temperature
        INTEGER   TYPE             !        Type of law
        REAL*4      SCM            !        Safety factor
        REAL*4      EPS            ! [   9] Elongation at TEMP if TEMP>0
        REAL*4      RES1           ! [   9] Shift of strains TEMP>0 (-TempStrain)
        REAL*4      RES2           !        Tensile Strength  Concrete   for 21:24
        REAL*4      ARB(5,0:19)    !        Function values
      END TYPE CMAT_NONL
      INTEGER, PARAMETER :: LEN_CMAT_NONL=107
      INTEGER, PARAMETER :: VER_CMAT_NONL=200501

      TYPE CMAT_BED                ! 1/NR:7  MaterialBedding
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   MNR              !        Materialnumber of bedding boddy
        INTEGER   IBT              !        Type of bedding mechanism
        REAL*4      C              ! [1097] Bedding Coefficient
        REAL*4      CT             ! [1097] Tangential Bedding
        REAL*4      RISS           ! [1092] rupture stress
        REAL*4      FLIE           ! [1092] yield   stress
        REAL*4      MUE            !        friction coefficient
        REAL*4      KOH            ! [1092] cohesion
        REAL*4      DIL            !        dilatancy coeffic.
        REAL*4      GAM            ! [1184] mass of bedding
        REAL*4      H              ! [1001] reference length
      END TYPE CMAT_BED
      INTEGER, PARAMETER :: LEN_CMAT_BED=12
      INTEGER, PARAMETER :: VER_CMAT_BED=200501

      TYPE CMAT_LAY                ! 1/NR:8  MaterialLayerStructure
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   NM               !        Number of a material
        INTEGER   I_2
        REAL*4      T              ! [1010] Thickness
      END TYPE CMAT_LAY
      INTEGER, PARAMETER :: LEN_CMAT_LAY=4
      INTEGER, PARAMETER :: VER_CMAT_LAY=200501

      INTEGER, PARAMETER :: MAT_HYD_FLOW=-1
      INTEGER, PARAMETER :: MAT_HYD_DARC=0
      INTEGER, PARAMETER :: MAT_HYD_ADARC=1
      INTEGER, PARAMETER :: MAT_HYD_FORC=2
      INTEGER, PARAMETER :: MAT_HYD_MISS=3
      INTEGER, PARAMETER :: MAT_HYD_FOUR=4
      INTEGER, PARAMETER :: MAT_HYD_AFOUR=5
      INTEGER, PARAMETER :: MAT_HYD_EC4S=6
      INTEGER, PARAMETER :: MAT_HYD_EC4C=7
      INTEGER, PARAMETER :: MAT_HYD_JONA=16
      INTEGER, PARAMETER :: MAT_HYD_HSCM=17
      INTEGER, PARAMETER :: MAT_HYD_WESC=18
      TYPE CMAT_HYD                ! 1/NR:9  MaterialConductivity
        SEQUENCE
        INTEGER   ID               !        Identification
        INTEGER   T                !        Temperature / pressure
        INTEGER   TYPE             !        Type of Material law
        REAL*4      D              !        special Parameter
        REAL*4      C              !        Storage Capacity
        REAL*4      N              !        Porosity/humidity
        REAL*4      K(6)           !        Conductivity
        REAL*4      KLOC(6)        !        Conductivity
      END TYPE CMAT_HYD
      INTEGER, PARAMETER :: LEN_CMAT_HYD=18
      INTEGER, PARAMETER :: VER_CMAT_HYD=200501

      TYPE CMAT_SPE                ! 1/NR:90  MaterialSpecial
        SEQUENCE
        INTEGER   ID               !        Identification = 90
        INTEGER   TYPE             !        type of material value
        INTEGER   EXP              !        exposition class identifier (0=all classes)
        REAL*4      RVAL(32)       !        real material values
      END TYPE CMAT_SPE
      INTEGER, PARAMETER :: LEN_CMAT_SPE=35
      INTEGER, PARAMETER :: VER_CMAT_SPE=200501

      TYPE CBORE                   ! 2/NR:0  SoilProfile
        SEQUENCE
        INTEGER   ID               !        identifier 0 (always the first record)
        REAL*4      X              ! [1001] X_ordinate
        REAL*4      Y              ! [1001] Y_ordinate
        REAL*4      Z              ! [1001] Z_ordinate
        REAL*4      DX             !        direction of axis
        REAL*4      DY             !        direction of axis
        REAL*4      DZ             !        direction of axis
        REAL*4      ALF            ! [   5] Angle of reference
        REAL*4      HGWL           ! [1006] lower ground water level
        REAL*4      HGWH           ! [1006] upper ground water level
        REAL*4      I_10(6)
        INTEGER   TEXT(17)         !        Designation of Profile
      END TYPE CBORE
      INTEGER, PARAMETER :: LEN_CBORE=33
      INTEGER, PARAMETER :: VER_CBORE=201407

      TYPE CBORE_LAY               ! 2/NR:1  Soillayer
        SEQUENCE
        INTEGER   ID               !        Identifier 1
        INTEGER   MNR              !        Material number
        INTEGER   VARI             !        Type of stiffness variation
        INTEGER   ILAY             !        Additional layer information
        INTEGER   I_4              !        reserved
        INTEGER   I_5              !        reserved
        REAL*4      S              ! [1001] Ordinate on bore profile axis (positive)
        REAL*4      ES             ! [1096] Stiffness Modulus
        REAL*4      DES            ! [1096] Increment of ES within current layer
        REAL*4      MUE            !        Poissons ratio
        REAL*4      PMAX           ! [1096] Max. pressure at pile foot
        REAL*4      PMAL           ! [1096] Max. lateral pressure
        REAL*4      C              ! [1096] Cohesion
        REAL*4      PHI            ! [   5] Soil/Pile friction angle
        REAL*4      GAM            ! [1091] nominal weight
        REAL*4      GAMB           ! [1091] nominal weight under buoyancy
      END TYPE CBORE_LAY
      INTEGER, PARAMETER :: LEN_CBORE_LAY=16
      INTEGER, PARAMETER :: VER_CBORE_LAY=201011

      TYPE CBORE_TAB               ! 2/NR:10  SoilTabdefinition
        SEQUENCE
        INTEGER   ID               !        Identifier 10
        INTEGER   OPT              !        Option
        INTEGER   CLASS            !        Classification subtype
        REAL*4      FACS           !        Factor on stresses
        REAL*4      B(10)          ! [1001] Width of foundation
      END TYPE CBORE_TAB
      INTEGER, PARAMETER :: LEN_CBORE_TAB=14
      INTEGER, PARAMETER :: VER_CBORE_TAB=201407

      TYPE CBORE_TAD               ! 2/NR:11  SoilTabvalues
        SEQUENCE
        INTEGER   ID               !        Identifier 11
        INTEGER   I_1              !        reserved
        INTEGER   I_2              !        reserved
        REAL*4      D              ! [1006] Embedment depth of foundation
        REAL*4      SIGD(10)       ! [1089] design stresses at specified depth values
      END TYPE CBORE_TAD
      INTEGER, PARAMETER :: LEN_CBORE_TAD=14
      INTEGER, PARAMETER :: VER_CBORE_TAD=201407

      TYPE CBORE_BAX               ! 2/NR:1001  BoreProfileAxial
        SEQUENCE
        INTEGER   ID               !        identifier 1001
        REAL*4      Z1             !        parameter s on start
        REAL*4      Z2             !        parameter s on end
        REAL*4      K0             ! [1096] constant bedding
        REAL*4      K1             ! [1096] parabolic bedding
        REAL*4      K2             ! [1096] linear bedding
        REAL*4      K3             ! [1096] quadratic bedding
        REAL*4      M0             ! [1153] cohesive loading
        REAL*4      C0             ! [1153] cohesion
        REAL*4      TANR           !        friction angle
        REAL*4      TAND           !        dilatancy angle
        REAL*4      KQ             !        pressure coefficient
        REAL*4      PMAX           ! [1101] maxforce at pile foot
      END TYPE CBORE_BAX
      INTEGER, PARAMETER :: LEN_CBORE_BAX=13
      INTEGER, PARAMETER :: VER_CBORE_BAX=201004

      TYPE CBORE_BLA               ! 2/NR:1002  BoreProfileTransverse
        SEQUENCE
        INTEGER   ID               !        identifier 1002
        REAL*4      Z1             !        parameter s on start
        REAL*4      Z2             !        parameter s on end
        REAL*4      K0             ! [1096] constant bedding
        REAL*4      K1             ! [1096] parabolic bedding
        REAL*4      K2             ! [1096] linear bedding
        REAL*4      K3             ! [1096] quadratic bedding
        REAL*4      F0             !        peripher Distribution
        REAL*4      F1
        REAL*4      F2
        REAL*4      PM1            ! [1153] maximum value on upper ordinate
        REAL*4      PM2            ! [1153] maximum value on lower ordinate
        REAL*4      P0             !        peripher Distribution
        REAL*4      P1
        REAL*4      P2
        REAL*4      P3
      END TYPE CBORE_BLA
      INTEGER, PARAMETER :: LEN_CBORE_BLA=16
      INTEGER, PARAMETER :: VER_CBORE_BLA=200501

      TYPE CBORE_BAM               ! 2/NR:1003  BoreProfileMoment
        SEQUENCE
        INTEGER   ID               !        identifier 1003
        REAL*4      Z1             !        parameter s on start
        REAL*4      Z2             !        parameter s on end
        REAL*4      K0             ! [1099] constant bedding
        REAL*4      K1             ! [1099] parabolic bedding
        REAL*4      K2             ! [1099] linear bedding
        REAL*4      K3             ! [1099] quadratic bedding
      END TYPE CBORE_BAM
      INTEGER, PARAMETER :: LEN_CBORE_BAM=7
      INTEGER, PARAMETER :: VER_CBORE_BAM=200501

      TYPE CBORE_DYA               ! 2/NR:1011  BoreProfileAxialDynamic
        SEQUENCE
        INTEGER   ID               !        identifier 1011
        REAL*4      Z1             !        parameter s on start
        REAL*4      Z2             !        parameter s on end
        REAL*4      D0             ! [ 105] constant damping
        REAL*4      D1             ! [ 105] parabolic damping
        REAL*4      D2             ! [ 105] linear damping
        REAL*4      D3             ! [ 105] quadratic damping
      END TYPE CBORE_DYA
      INTEGER, PARAMETER :: LEN_CBORE_DYA=7
      INTEGER, PARAMETER :: VER_CBORE_DYA=200601

      TYPE CBORE_DYL               ! 2/NR:1012  BoreProfileTransverseDynamic
        SEQUENCE
        INTEGER   ID               !        identifier 1012
        REAL*4      Z1             !        parameter s on start
        REAL*4      Z2             !        parameter s on end
        REAL*4      D0             ! [ 105] constant damping
        REAL*4      D1             ! [ 105] parabolic damping
        REAL*4      D2             ! [ 105] linear damping
        REAL*4      D3             ! [ 105] quadratic damping
        REAL*4      M0             ! [1181] constant soil mass
        REAL*4      M2             ! [1181] linear soil mass
      END TYPE CBORE_DYL
      INTEGER, PARAMETER :: LEN_CBORE_DYL=9
      INTEGER, PARAMETER :: VER_CBORE_DYL=200601

      TYPE CTEND                   ! 4/ID:0  Prestressing Schemes
        SEQUENCE
        INTEGER   ID0              !        identifier 0
        INTEGER   KEY              !        Control bits + Info
        INTEGER   ID2              !        reserved
        INTEGER   TXT(17)          !        Main Designation of company and scheme
      END TYPE CTEND
      INTEGER, PARAMETER :: LEN_CTEND=20
      INTEGER, PARAMETER :: VER_CTEND=200701

      TYPE CTEND_1                 ! 4/ID:1  Tendon of Prestressing Schemes
        SEQUENCE
        INTEGER   ID0              !        identifier 1
        INTEGER   MNR              !        Material number of Prestressing Steel
        INTEGER   ID2              !        reserved
        REAL*4      ZV             ! [1028] Nominal force
        REAL*4      AZ             ! [1020] Area of tendon
        REAL*4      RNLI           !        Number or wires
        REAL*4      SLS            ! [  16] Slip at anchor
        REAL*4      SLK            ! [  16] Slip at coupling
        REAL*4      SLF            ! [  16] Slip at fixed end
        REAL*4      VLS            !        Loss at anchor
        REAL*4      VLK            !        Loss at coupling
        REAL*4      VLF            !        Loss at fixed end
        REAL*4      DLS            ! [1001] Straight at anchor
        REAL*4      DLK            ! [1001] Straight at coupling
        REAL*4      DLF            ! [1001] Straight at fixed end
        REAL*4      DI             ! [1023] inner diameter of duct
        REAL*4      DA             ! [1023] outer diamtere of duct
        REAL*4      RMIN           ! [1001] minimum radius
        REAL*4      BETA(2)        ! [  17] unintended angles
        REAL*4      RMUE(2)        !        Friction coefficients
        REAL*4      EXZ            ! [1011] max exzentricity
        REAL*4      EACHS          ! [1011] distance between
        REAL*4      ERAND          ! [1011] distance to outer edge
        REAL*4      BLOCK(8)       !        reserved extra data
        INTEGER   TXT(17)          !        Designation of tendon
      END TYPE CTEND_1
      INTEGER, PARAMETER :: LEN_CTEND_1=50
      INTEGER, PARAMETER :: VER_CTEND_1=200701

      TYPE CTEND_2                 ! 4/ID:2  Anchor of Prestressing Schemes
        SEQUENCE
        INTEGER   ID0              !        identifier 2
        INTEGER   ID1              !        Type of anchor
        INTEGER   TYP              !        Type of anchor geometry
        REAL*4      ANKER(16)      !        Data
        INTEGER   TXT(17)          !        Designation of anchor
      END TYPE CTEND_2
      INTEGER, PARAMETER :: LEN_CTEND_2=36
      INTEGER, PARAMETER :: VER_CTEND_2=200701

      TYPE CTEND_3                 ! 4/ID:3  Jack of Prestressing Schemes
        SEQUENCE
        INTEGER   ID0              !        identifier 2
        INTEGER   ID1              !        reserved
        INTEGER   TYP              !        Type of jack
        REAL*4      JACK(16)       !        Data
        INTEGER   TXT(17)          !        Designation of jack
      END TYPE CTEND_3
      INTEGER, PARAMETER :: LEN_CTEND_3=36
      INTEGER, PARAMETER :: VER_CTEND_3=200701


      INTEGER, PARAMETER :: MAT_KWH = 1
      INTEGER, PARAMETER :: BORE_KWH = 2
      INTEGER, PARAMETER :: TEND_KWH = 4

      END MODULE CDB_TYPES_MAT

!     end of automatically generated header
!     SOFiSTiK AG
!
