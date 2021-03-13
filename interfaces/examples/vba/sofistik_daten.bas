'   SOFiSTiK AG
'     sofistik_daten.bas
'     Datei wurde automatisch erzeugt! Keine Änderungen vornehmen!
'     Die benötigten Elemente einfach hier rauskopieren!
'


      TYPE CREC_INDX               ' -999/-998  Sorted index on structure names
        m_NAME(1 to 2) as Long     '        Name of this structure
        m_KWH as Long              '        Kwh
        m_KWL as Long              '        Kwl
        m_SEL1(1 to 2) as Long     '        Selection string of first integer value
        m_SEL2(1 to 2) as Long     '        Selection string of second integer value
      END TYPE

      TYPE CREC_VERS               ' -999/-999  Revision number of generating cdbase.txt
        m_VERS as Long             '        version
      END TYPE

      TYPE CREC_PUB                ' -999/-999:1  public REC
        m_ID as Long               '        Identification 1/2
        m_KWH as Long              '        Kwh
        m_KWL as Long              '        Kwl (may be NR/LC or number)
        m_SEL1(1 to 2) as Long     '        Selection string of first integer value
        m_SEL2(1 to 2) as Long     '        Selection string of second integer value
        m_NAME(1 to 2) as Long     '        name of this structure
        m_VERSION as Long          '        Version number of description
        m_OPTION as Long           '        options  0 = default
        m_TYPE as Long             '        type
      END TYPE

      TYPE CREC_INT                ' -999/-999:2  internal REC
        m_ID as Long               '        Identification 1/2
        m_KWH as Long              '        Kwh
        m_KWL as Long              '        Kwl (may be NR/LC or number)
        m_SEL1(1 to 2) as Long     '        Selection string of first integer value
        m_SEL2(1 to 2) as Long     '        Selection string of second integer value
        m_NAME(1 to 2) as Long     '        name of this structure
        m_VERSION as Long          '        Version number of description
        m_OPTION as Long           '        options  0 = default
        m_TYPE as Long             '        type
      END TYPE

      TYPE CREC_DAD                ' -999/-999:3  public DAD
        m_ID as Long               '        Identification 3
        m_KWH as Long              '        Kwh
        m_KWL as Long              '        Kwl
      END TYPE

      TYPE CREC_DESC               ' -999/-999:4  description string to last entry or item
        m_ID as Long               '        Identification 4
        m_LANG as Long             '        Language of this item
        m_NAME(1 to 64) as Long    '        Description
      END TYPE

      TYPE CREC_ITM5_STRU          '        Names of the structure elements
        m_NAME(1 to 2) as Long
        m_DIM as Long
        m_DIM1 as Long
      END TYPE

      TYPE CREC_ITM5               ' -999/-999:5  item of a record (obsoleted)
        m_ID as Long               '        Identification 5
        m_NR as Long               '        number of the item
        m_INDEX as Long            '        index of the item starting with 0
        m_TYP as Long              '        Type of the item
        m_OFFSET as Long           '        offset of the item to be merged
        m_NAME(1 to 2) as Long     '        item name (4 chars significant)
        m_DIM as Long              '        unit or type of item
        m_DIM1 as Long             '        first dimension
        m_BEG1 as Long             '        first index of first dimension
        m_DIM2 as Long             '        second dimension
        m_BEG2 as Long             '        first index of second dimension
        m_BITS as Long             '        additional information Bits
        m_STRUCTUR(1 to 20) as CREC_ITM5_STRU '        Names of the structure elements
      END TYPE

      TYPE CREC_ITEM_STRU          '        Names of the structure elements
        m_NAME(1 to 2) as Long
        m_DIM as Long
        m_TYPE as Long
        m_DIM1 as Long
      END TYPE

      TYPE CREC_ITEM               ' -999/-999:6  item of a record
        m_ID as Long               '        Identification 6
        m_NR as Long               '        number of the item
        m_INDEX as Long            '        index of the item starting with 0
        m_TYP as Long              '        Type of the item
        m_OFFSET as Long           '        offset of the item to be merged
        m_NAME(1 to 2) as Long     '        item name (4 chars significant)
        m_DIM as Long              '        unit of item
        m_TYPE as Long             '        type of item
        m_DIM1 as Long             '        first dimension
        m_BEG1 as Long             '        first index of first dimension
        m_DIM2 as Long             '        second dimension
        m_BEG2 as Long             '        first index of second dimension
        m_BITS as Long             '        additional information Bits
        m_STRUCTUR(1 to 20) as CREC_ITEM_STRU '        Names of the structure elements
      END TYPE

      TYPE CREC_MIX_MIXI           '        Mixinfo
        m_TYP as Long
        m_KEYTYP as Long
        m_MIXFROM as Long
      END TYPE

      TYPE CREC_MIX                ' -999/-999:11  mixinfo of a record
        m_ID as Long               '        Identification 11/12
        m_NKEY as Long
        m_NLEN as Long
        m_NMIXFLAG as Long
        m_SELECTOR as Long
        m_MIXINFO(1 to 256) as CREC_MIX_MIXI '        Mixinfo
      END TYPE

      TYPE CREC_MHD_MIXI           '        Mixinfo
        m_TYP as Long
        m_KEYTYP as Long
        m_MIXFROM as Long
      END TYPE

      TYPE CREC_MHD                ' -999/-999:12  mixinfo of a record header
        m_ID as Long               '        Identification 11/12
        m_NKEY as Long
        m_NLEN as Long
        m_NMIXFLAG as Long
        m_SELECTOR as Long
        m_MIXINFO(1 to 256) as CREC_MHD_MIXI '        Mixinfo
      END TYPE

      TYPE CCTRL_010               ' 0/01:999  AccessInfo Last Program
        m_ID as Long               '        Identifier 999
        m_ACCE as Long             '        Number of access
        m_VERS as Long             '        Version number
        m_NAME(1 to 17) as Long    '        Name of Program
        m_ERR(1 to 4) as Long      '        Name of ERR-File
      END TYPE

      TYPE CCTRL_011               ' 0/01:?  Messages
        m_ID as Long               '        Level
        m_IDERR(1 to 2) as Long    '        Number of errortext
        m_IDSUP(1 to 4) as Long    '        Name of subroutine
        m_ITEXT(1 to 6) as Long    '        Text value of message
        m_NILIST as Long           '        count on Integer values of message
        m_NRLIST as Long           '        count on Real values of message
        m_LIST(1 to 255) as Long   '        values of message ILIST+RLIST
      END TYPE

      TYPE CCTRL_OBJ               ' 0/01:101  involved objects
        m_ID as Long               '        Identifier = 101
        m_ID2 as Long              '        bitpattern of specified data
        m_TYPE as Long             '        KWH of Elementtype (30,31,32,33)
        m_NR as Long               '        Number of element  (TYPE/NR)
        m_IDBIM(1 to 32) as Long   '        256 Bit GUId Identifier of element in the BIM/CAD system
        m_UVW(1 to 3) as Single    ' [1001] local coordinates in object
        m_BOX(1 to 2,1 to 3) as Single ' [1001] bounding box x,y,z min, x,y,z max
      END TYPE

      TYPE CCTRL_OID               ' 0/01:102  GUId
        m_ID as Long               '        identifier 102
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of preceeding element
      END TYPE

      TYPE CSSD_SPE                ' 0/96:1  SSD-Spezial
        m_ID as Long               '        id==1
        m_TYPE as Long             '        type of information
        m_IVAL as Long             '        integer value
        m_RVAL(1 to 3) as Single   '        real values
        m_ITXT(1 to 4) as Long     '        string value
      END TYPE

      TYPE CVIS_LC0                ' 0/97:0  active Loadcase
        m_ID as Long               '        id==0
        m_LFNR as Long             '        Loadcase number
        m_VIS as Long              '        unused
      END TYPE

      TYPE CVIS_LC                 ' 0/97:1  Loadcase visualisation
        m_ID as Long               '        id==1
        m_LFNR as Long             '        Loadcase number
        m_VIS as Long              '        Visualisation
      END TYPE

const CTRL_ACCESS_MIX = 1
const CTRL_ACCESS_CONVERT = 2
const CTRL_ACCESS_2010 = 4
const CTRL_ACCESS_2012 = 8
const CTRL_ACCESS_2014 = 16
const CTRL_ACCESS_2016 = 32
const CTRL_ACCESS_2018 = 64
const CTRL_ACCESS_2020 = 128
      TYPE CCTRL                   ' 0/99:*  PrintControl
        m_MAXL as Long             '        Lines per page
        m_MARG as Long             '        Left margin
        m_TOBO as Long             '        Top/bottom margin
        m_MODP as Long             '        Type of Headding
        m_PAGE as Long             '        Current page no
        m_LOUT as Long             '        Output Language
        m_LINP as Long             '        Input  Language
        m_UNIT as Long             '        Unit set
        m_ACCE as Long             '        No of last access
        m_PAG(1 to 7) as Long      '        Paging Text
        m_REL_VERS as Long         '        ReleaseVersion of this database
        m_REL_BITS as Long         '        Accessbits
      END TYPE

      TYPE CCTRL_0                 ' 0/99:0  AccessInfo
        m_ID as Long               '        Identifier 0
        m_ACCE as Long             '        Number of access
        m_VERS as Long             '        Version number
        m_ERRO as Long             '        Number of Errors
        m_WARN as Long             '        Number of Errors
        m_NAME(1 to 17) as Long    '        Name of Program
        m_REL_VERS as Long         '        ReleaseVersion of last access
      END TYPE

      TYPE CCTRL_1                 ' 0/99:1  AccessTitle
        m_ID as Long               '        Identifier 1
        m_ACCE as Long             '        Number of access
        m_KOPF(1 to 64) as Long    '        Title of access
      END TYPE

      TYPE CCTRL_VAR               ' 0/100  Global_CADINP_Variable
        m_NAME(1 to 4) as Long     '        name of variable
        m_IND as Long              '        index for arrays
        m_VAL as Single            '        value of variable
        m_SCOPE as Long            '        name of scope
        m_DIM as Long              '        unit of variable
        m_TXT(1 to 17) as Long     '        Comment on variable
      END TYPE

      TYPE CCTRL_VAP               ' 0/100:???  Private_CADINP_Variable
        m_ID as Long               '        Identification = ???
        m_IND1 as Long             '        Lower Index of variable
        m_IND2 as Long             '        Upper Index of variable
        m_NAME(1 to 4) as Long     '        Name of variable
        m_VAL(1 to 1020) as Single '        values of the variable NAME[IND1:IND2]
      END TYPE

      TYPE CCTRL_DIM               ' 0/101  Unit definitions
        m_IDIM as Long             '        number of an implicit unit (>999)
        m_UNIA as Long             '        unit for output (0=do not change)
        m_UNIE as Long             '        unit for input  (0=do not change)
        m_DIGA as Long             '        number of digits for output (>10 for Exponential)
        m_DIGE as Long             '        number of digits for input (=GUI)
      END TYPE

const MAT_CONS_GW = 701
const MAT_CONS_GP = 702
const MAT_CONS_GM = 703
const MAT_CONS_GC = 704
const MAT_CONS_SW = 705
const MAT_CONS_SP = 706
const MAT_CONS_SM = 707
const MAT_CONS_SC = 708
const MAT_CONS_SAND = 709
const MAT_CONS_ML = 711
const MAT_CONS_MI = 712
const MAT_CONS_MH = 713
const MAT_CONS_CL = 715
const MAT_CONS_CI = 716
const MAT_CONS_CH = 717
const MAT_CONS_CLAY = 719
const MAT_CONS_ROC1 = 721
const MAT_CONS_ROC2 = 722
const MAT_CONS_ROC3 = 723
const MAT_CONS_ROC4 = 724
const MAT_CONS_AIR = 801
const MAT_CONS_H2O = 802
const MAT_CONS_CO2 = 803
const MAT_CONS_O2 = 804
const MAT_CONS_N2 = 805
const MAT_CONS_CH4 = 806
const MAT_CONS_HE = 809
const MAT_CONS_NE = 810
const MAT_CONS_AR = 811
const MAT_CONS_KR = 812
const MAT_CONS_XE = 813
const MAT_CONS_SF6 = 814
const MAT_CONS_GLAS = 901
const MAT_CONS_ESG = 902
const MAT_CONS_VSGh = 903
const MAT_CONS_VSGv = 904
const MAT_CONS_TVG = 905
const MAT_CONS_Cu = 906
const MAT_CONS_Pb = 907
const MAT_CONS_Mg = 908
const MAT_CONS_W = 909
const MAT_CONS_Zn = 910
const MAT_CONS_BRAS = 911
const MAT_CONS_BRON = 912
const MAT_CONS_BRIC = 925
const MAT_CONS_SLBR = 926
const MAT_CONS_CLIN = 927
const MAT_CONS_IGYP = 930
const MAT_CONS_GYPS = 931
const MAT_CONS_MOGY = 932
const MAT_CONS_MOCH = 933
const MAT_CONS_MOCE = 934
const MAT_CONS_ASPH = 937
const MAT_CONS_BITU = 938
const MAT_CONS_CARP = 941
const MAT_CONS_WOOL = 942
const MAT_CONS_CORK = 943
const MAT_CONS_LINO = 944
const MAT_CONS_EPOX = 946
const MAT_CONS_PHEN = 947
const MAT_CONS_PEST = 948
const MAT_CONS_ACRY = 949
const MAT_CONS_PC = 950
const MAT_CONS_PTFE = 951
const MAT_CONS_PVC = 952
const MAT_CONS_PMMA = 953
const MAT_CONS_POM = 954
const MAT_CONS_PA = 955
const MAT_CONS_PEHD = 956
const MAT_CONS_PELD = 957
const MAT_CONS_PS = 958
const MAT_CONS_PP = 959
const MAT_CONS_PUR = 960
const MAT_CONS_RUBB = 961
const MAT_CONS_NEOP = 962
const MAT_CONS_EBON = 963
const MAT_CONS_EPDM = 964
const MAT_CONS_PSUL = 965
const MAT_CONS_BUTA = 966
const MAT_CONS_SI = 967
const MAT_CONS_SILA = 968
const MAT_CONS_FOAM = 973
const MAT_CONS_FOAS = 974
const MAT_CONS_FOAU = 975
const MAT_CONS_FOAC = 976
const MAT_CONS_FOAR = 977
const MAT_CONS_FOAE = 978
const MAT_CONS_LAY = 999
      TYPE CMAT                    ' 1/NR:0  MaterialTitle
        m_ID as Long               '        Identification = 0
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_TITLE(1 to 17) as Long   '        designation
      END TYPE

      TYPE CMAT_USER               ' 1/NR:10??  Information on user input
        m_ID as Long               '        Identification
        m_BIT(1 to 32) as Long     '        User input for 001/NR:1
      END TYPE

      TYPE CMAT_FLUI               ' 1/NR:1  MaterialConstants
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Compression modulus
        m_NUE as Single            ' [1221] Kinematic Viscosity
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_RHO as Single            ' [1189] Density
        m_GAMB as Single           ' [1091] dead weight buyoncy
        m_ALFA as Single           ' [ 107] Temperature Elongation coefficient
      END TYPE

const MAT_CONS_LINE = 0
const MAT_CONS_MISE = 1
const MAT_CONS_MOHR = 2
const MAT_CONS_GUDE = 3
const MAT_CONS_ROCK = 4
const MAT_CONS_LADE = 5
const MAT_CONS_DUNC = 6
const MAT_CONS_HYPO = 7
const MAT_CONS_MEMB = 8
const MAT_CONS_GRAN = 10
const MAT_CONS_CAMC = 11
const MAT_CONS_UNDR = 14
const MAT_CONS_FAIL = 15
const MAT_CONS_SWEL = 16
const MAT_CONS_VMIS = 17
const MAT_CONS_DRUC = 18
      TYPE CMAT_CONS               ' 1/NR:1  MaterialConstants
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_GAMB as Single           ' [1091] dead weight buyoncy
        m_ALFA as Single           ' [ 107] Temperature Expansion
        m_E90 as Single            ' [1090] Transvers Elasticity
        m_MUE90 as Single          '        anisotrope Poisson
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FY as Single             ' [1092] effective strength
        m_FT as Single             ' [1092] nominal strength
        m_P(1 to 18) as Single     '        variable parameters
      END TYPE

      TYPE CMAT_UNDR               ' 1/NR:14  Undrained soil parameters
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_GAMB as Single           ' [1091] dead weight buyoncy
        m_ALFA as Single           ' [ 107] Temperature Expansion
        m_E90 as Single            ' [1090] Transvers Elasticity
        m_MUE90 as Single          '        anisotrope Poisson
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FY as Single             ' [1092] effective strength
        m_FT as Single             ' [1092] nominal strength
        m_P(1 to 18) as Single     '        variable parameters
      END TYPE

      TYPE CMAT_FAUL               ' 1/NR:15  Fault/Shear plane
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_GAMB as Single           ' [1091] dead weight buyoncy
        m_ALFA as Single           ' [ 107] Temperature Expansion
        m_E90 as Single            ' [1090] Transvers Elasticity
        m_MUE90 as Single          '        anisotrope Poisson
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FY as Single             ' [1092] effective strength
        m_FT as Single             ' [1092] nominal strength
        m_P(1 to 18) as Single     '        variable parameters
      END TYPE

      TYPE CMAT_SWEL               ' 1/NR:16  Swelling parameters
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_GAMB as Single           ' [1091] dead weight buyoncy
        m_ALFA as Single           ' [ 107] Temperature Expansion
        m_E90 as Single            ' [1090] Transvers Elasticity
        m_MUE90 as Single          '        anisotrope Poisson
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FY as Single             ' [1092] effective strength
        m_FT as Single             ' [1092] nominal strength
        m_P(1 to 18) as Single     '        variable parameters
      END TYPE

      TYPE CMAT_CONC               ' 1/NR:1  MaterialConcrete
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_RHO as Single            ' [1189] Density
        m_ALFA as Single           ' [ 107] Temperature Elongation coefficient
        m_E90 as Single            ' [1090] Elasticity modulus perpendicular
        m_MUE90 as Single          '        Poissons ratio perpendicular
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FC as Single             ' [1092] effective strength
        m_FCK as Single            ' [1092] nominal strength
        m_FTM as Single            ' [1092] mean value of tensional strength
        m_FTL as Single            ' [1092] lower fractile of tensional strength
        m_FTK as Single            ' [1092] upper fractile of tensional strength
        m_EC as Single             '        compr. failure Energy (deprecated)
        m_ET as Single             ' [ 112] tensile failure energy
        m_MUER as Single           '        friction in the crack
        m_FCM as Single            ' [1092] mean value of strength
        m_RDCL as Single           '        weight class
        m_FCR as Single            ' [1092] calculatoric mean value of strength
        m_ECR as Single            ' [1090] Elasticity modul for worklaw CE
        m_FBD as Single            ' [1092] bond strength (EC2 Table. 5.1.3)
        m_FTD as Single            ' [1092] Initial tensile strength Bemessungszugfestigkeit
        m_FEQR as Single           ' [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
        m_FEQT as Single           ' [1092] Residual tensile strength  Restzugfestigkeit im Bruch
        m_FCFAT as Single          ' [1092] Fatigue Strength
        m_SCMS as Single           '        Material safety for the serviceability law
        m_SCMU as Single           '        Material safety for ultimate stress strain law
        m_SCMC as Single           '        Material safety for the calculatoric law
      END TYPE

      TYPE CMAT_STEE               ' 1/NR:1  MaterialSteel
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_RHO as Single            ' [1189] Density
        m_ALFA as Single           ' [ 107] Temperature Elongation coefficient
        m_E90 as Single            ' [1090] Elasticity modulus perpendicular
        m_MUE90 as Single          '        Poissons ratio perpendicular
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FY as Single             ' [1092] yield stress
        m_FT as Single             ' [1092] tensile strength
        m_EPS as Single            ' [   9] limit strain
        m_REL1 as Single           '        Relaxation 0.55fpk
        m_REL2 as Single           '        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
        m_R as Single              '        bond coefficient
        m_K1 as Single             '        bondfactor EC2
        m_EH as Single             ' [1090] Hardening module
        m_FE as Single             ' [1092] Proportional stress
        m_EPSE as Single           ' [   9] Plastic strain
        m_FDYN as Single           ' [1092] Dynamic strength
        m_FYC as Single            ' [1092] compr. yield stress
        m_FTC as Single            ' [1092] compress. strength
        m_TMAX as Single           ' [1023] max.plate thickness
        m_BC as Single             '        (eg. Aluminium 1.0/2.0 = "A","B" )
        m_DUMMY(1 to 2) as Single
        m_SCMS as Single           '        Material safety for the serviceability law
        m_SCMU as Single           '        Material safety for ultimate stress strain law
        m_SCMC as Single           '        Material safety for the calculatoric law
      END TYPE

      TYPE CMAT_TIMB               ' 1/NR:1  MaterialTimber
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Material type
        m_CLASS as Long            '        Classification
        m_EMOD as Single           ' [1090] Elasticity Modulus along the fibres
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] nominal weight
        m_RHO as Single            ' [1189] Density
        m_ALFA as Single           ' [ 107] Temperature Elongation coefficient
        m_E90 as Single            ' [1090] Elasticity modulus perpendicular to fibres
        m_MUE90 as Single          '        Poissons ratio perpendicular
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FYB as Single            ' [1092] Bending strength
        m_FYT as Single            ' [1092] tensile strength along the fibres
        m_FYT90 as Single          ' [1092] tensile strength perpend. the fibres
        m_FYC as Single            ' [1092] compressive strength along the fibres
        m_FYC90 as Single          ' [1092] compressive strength perpend. the fibres
        m_FYS as Single            ' [1092] middle shear strength (Membrane Shear force)
        m_FYST as Single           ' [1092] edge shear strength (Torsion)
        m_FYSB as Single           ' [1092] maximum shear strength (plate shear)
        m_FYB90 as Single          ' [1092] Bending strength perpendicular to fibres
        m_G90 as Single            ' [1090] transverse shear modulus for platebending
        m_SMOD0 as Single          '        Strength Modifier kmod for Service classes
        m_SMOD1 as Single          '        Strength Modifier kmod for Service classes
        m_SMOD2 as Single          '        Strength Modifier kmod for Service classes
        m_SMOD3 as Single          '        Strength Modifier kmod for Service classes
        m_SMOD4 as Single          '        Strength Modifier kmod for Service classes
        m_KDEF as Single           '        Deformation modifier
        m_TMAX as Single           ' [1023] max.plate thickness
        m_SCMS as Single           '        Material safety
        m_SCMU as Single           '        Material safety
        m_SCMC as Single           '        Material safety
      END TYPE

      TYPE CMAT_BRIC               ' 1/NR:1  MaterialBrickwork
        m_ID as Long               '        Identification
        m_TYPE as Long             '        Bric type and strength
        m_CLASS as Long            '        Mortar class
        m_EMOD as Single           ' [1090] Elasticity Modulus
        m_MUE as Single            '        Poissons ratio
        m_GMOD as Single           ' [1090] Shear modulus
        m_KMOD as Single           ' [1090] Compression modulus
        m_GAM as Single            ' [1091] dead weight
        m_RHO as Single            ' [1189] Density
        m_ALFA as Single           ' [ 107] Temperature Elongation coefficient
        m_E90 as Single            ' [1090] Elasticity modulus perpendicular
        m_MUE90 as Single          '        Poissons ratio perpendicular
        m_ALF as Single            ' [   5] Euler Angle I
        m_BET as Single            ' [   5] Euler Angle II
        m_SCM as Single            '        Material safety
        m_FK as Single             ' [1092] Strength
        m_FB as Single             ' [1092] brick strength
        m_FT as Single             ' [1092] tensile strength
        m_FV as Single             ' [1092] shear strength
        m_FV0 as Single            ' [1092] adhesional strength
        m_FBT as Single            ' [1092] tens.brick strength
        m_FM as Single             ' [1092] mortar strength
        m_DUMMY(1 to 10) as Single
        m_SCMS as Single           '        Material safety
        m_SCMU as Single           '        Material safety
        m_SCMC as Single           '        Material safety
      END TYPE

      TYPE CMAT_SERV               ' 1/NR:2  StressStrainLaw (Servicability)
        m_ID as Long               '        Identification
        m_TEMP as Long             '        Temperature
        m_TYPE as Long             '        Type of law
        m_SCM as Single            '        Safety factor
        m_EPS as Single            ' [   9] Elongation at TEMP if TEMP>0
        m_RES1 as Single           ' [   9] Shift of strains TEMP>0 (-TempStrain)
        m_RES2 as Single           '        Tensile Strength  Concrete   for 21:24
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CMAT_ULTI               ' 1/NR:3  StressStrainLaw (Ultimate Limit state)
        m_ID as Long               '        Identification
        m_TEMP as Long             '        Temperature
        m_TYPE as Long             '        Type of law
        m_SCM as Single            '        Safety factor
        m_EPS as Single            ' [   9] Elongation at TEMP if TEMP>0
        m_RES1 as Single           ' [   9] Shift of strains TEMP>0 (-TempStrain)
        m_RES2 as Single           '        Tensile Strength  Concrete   for 21:24
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CMAT_NONL               ' 1/NR:4  StressStrainLaw (Nonlinear Mean Values)
        m_ID as Long               '        Identification
        m_TEMP as Long             '        Temperature
        m_TYPE as Long             '        Type of law
        m_SCM as Single            '        Safety factor
        m_EPS as Single            ' [   9] Elongation at TEMP if TEMP>0
        m_RES1 as Single           ' [   9] Shift of strains TEMP>0 (-TempStrain)
        m_RES2 as Single           '        Tensile Strength  Concrete   for 21:24
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CMAT_BED                ' 1/NR:7  MaterialBedding
        m_ID as Long               '        Identification
        m_MNR as Long              '        Materialnumber of bedding boddy
        m_IBT as Long              '        Type of bedding mechanism
        m_C as Single              ' [1097] Bedding Coefficient
        m_CT as Single             ' [1097] Tangential Bedding
        m_RISS as Single           ' [1092] rupture stress
        m_FLIE as Single           ' [1092] yield   stress
        m_MUE as Single            '        friction coefficient
        m_KOH as Single            ' [1092] cohesion
        m_DIL as Single            '        dilatancy coeffic.
        m_GAM as Single            ' [1184] mass of bedding
        m_H as Single              ' [1001] reference length
      END TYPE

      TYPE CMAT_LAY                ' 1/NR:8  MaterialLayerStructure
        m_ID as Long               '        Identification
        m_NM as Long               '        Number of a material
        m_I_2 as Long
        m_T as Single              ' [1010] Thickness
      END TYPE

const MAT_HYD_FLOW = -1
const MAT_HYD_DARC = 0
const MAT_HYD_ADARC = 1
const MAT_HYD_FORC = 2
const MAT_HYD_MISS = 3
const MAT_HYD_FOUR = 4
const MAT_HYD_AFOUR = 5
const MAT_HYD_EC4S = 6
const MAT_HYD_EC4C = 7
const MAT_HYD_JONA = 16
const MAT_HYD_HSCM = 17
const MAT_HYD_WESC = 18
      TYPE CMAT_HYD                ' 1/NR:9  MaterialConductivity
        m_ID as Long               '        Identification
        m_T as Long                '        Temperature / pressure
        m_TYPE as Long             '        Type of Material law
        m_D as Single              '        special Parameter
        m_C as Single              '        Storage Capacity
        m_N as Single              '        Porosity/humidity
        m_K(1 to 6) as Single      '        Conductivity
        m_KLOC(1 to 6) as Single   '        Conductivity
      END TYPE

      TYPE CMAT_SPE                ' 1/NR:90  MaterialSpecial
        m_ID as Long               '        Identification = 90
        m_TYPE as Long             '        type of material value
        m_EXP as Long              '        exposition class identifier (0=all classes)
        m_RVAL(1 to 32) as Single  '        real material values
      END TYPE

      TYPE CBORE                   ' 2/NR:0  SoilProfile
        m_ID as Long               '        identifier 0 (always the first record)
        m_X as Single              ' [1001] X_ordinate
        m_Y as Single              ' [1001] Y_ordinate
        m_Z as Single              ' [1001] Z_ordinate
        m_DX as Single             '        direction of axis
        m_DY as Single             '        direction of axis
        m_DZ as Single             '        direction of axis
        m_ALF as Single            ' [   5] Angle of reference
        m_HGWL as Single           ' [1006] lower ground water level
        m_HGWH as Single           ' [1006] upper ground water level
        m_I_10(1 to 6) as Single
        m_TEXT(1 to 17) as Long    '        Designation of Profile
      END TYPE

      TYPE CBORE_LAY               ' 2/NR:1  Soillayer
        m_ID as Long               '        Identifier 1
        m_MNR as Long              '        Material number
        m_VARI as Long             '        Type of stiffness variation
        m_ILAY as Long             '        Additional layer information
        m_I_4 as Long              '        reserved
        m_I_5 as Long              '        reserved
        m_S as Single              ' [1001] Ordinate on bore profile axis (positive)
        m_ES as Single             ' [1096] Stiffness Modulus
        m_DES as Single            ' [1096] Increment of ES within current layer
        m_MUE as Single            '        Poissons ratio
        m_PMAX as Single           ' [1096] Max. pressure at pile foot
        m_PMAL as Single           ' [1096] Max. lateral pressure
        m_C as Single              ' [1096] Cohesion
        m_PHI as Single            ' [   5] Soil/Pile friction angle
        m_GAM as Single            ' [1091] nominal weight
        m_GAMB as Single           ' [1091] nominal weight under buoyancy
      END TYPE

      TYPE CBORE_TAB               ' 2/NR:10  SoilTabdefinition
        m_ID as Long               '        Identifier 10
        m_OPT as Long              '        Option
        m_CLASS as Long            '        Classification subtype
        m_FACS as Single           '        Factor on stresses
        m_B(1 to 10) as Single     ' [1001] Width of foundation
      END TYPE

      TYPE CBORE_TAD               ' 2/NR:11  SoilTabvalues
        m_ID as Long               '        Identifier 11
        m_I_1 as Long              '        reserved
        m_I_2 as Long              '        reserved
        m_D as Single              ' [1006] Embedment depth of foundation
        m_SIGD(1 to 10) as Single  ' [1089] design stresses at specified depth values
      END TYPE

      TYPE CBORE_BAX               ' 2/NR:1001  BoreProfileAxial
        m_ID as Long               '        identifier 1001
        m_Z1 as Single             '        parameter s on start
        m_Z2 as Single             '        parameter s on end
        m_K0 as Single             ' [1096] constant bedding
        m_K1 as Single             ' [1096] parabolic bedding
        m_K2 as Single             ' [1096] linear bedding
        m_K3 as Single             ' [1096] quadratic bedding
        m_M0 as Single             ' [1153] cohesive loading
        m_C0 as Single             ' [1153] cohesion
        m_TANR as Single           '        friction angle
        m_TAND as Single           '        dilatancy angle
        m_KQ as Single             '        pressure coefficient
        m_PMAX as Single           ' [1101] maxforce at pile foot
      END TYPE

      TYPE CBORE_BLA               ' 2/NR:1002  BoreProfileTransverse
        m_ID as Long               '        identifier 1002
        m_Z1 as Single             '        parameter s on start
        m_Z2 as Single             '        parameter s on end
        m_K0 as Single             ' [1096] constant bedding
        m_K1 as Single             ' [1096] parabolic bedding
        m_K2 as Single             ' [1096] linear bedding
        m_K3 as Single             ' [1096] quadratic bedding
        m_F0 as Single             '        peripher Distribution
        m_F1 as Single
        m_F2 as Single
        m_PM1 as Single            ' [1153] maximum value on upper ordinate
        m_PM2 as Single            ' [1153] maximum value on lower ordinate
        m_P0 as Single             '        peripher Distribution
        m_P1 as Single
        m_P2 as Single
        m_P3 as Single
      END TYPE

      TYPE CBORE_BAM               ' 2/NR:1003  BoreProfileMoment
        m_ID as Long               '        identifier 1003
        m_Z1 as Single             '        parameter s on start
        m_Z2 as Single             '        parameter s on end
        m_K0 as Single             ' [1099] constant bedding
        m_K1 as Single             ' [1099] parabolic bedding
        m_K2 as Single             ' [1099] linear bedding
        m_K3 as Single             ' [1099] quadratic bedding
      END TYPE

      TYPE CBORE_DYA               ' 2/NR:1011  BoreProfileAxialDynamic
        m_ID as Long               '        identifier 1011
        m_Z1 as Single             '        parameter s on start
        m_Z2 as Single             '        parameter s on end
        m_D0 as Single             ' [ 105] constant damping
        m_D1 as Single             ' [ 105] parabolic damping
        m_D2 as Single             ' [ 105] linear damping
        m_D3 as Single             ' [ 105] quadratic damping
      END TYPE

      TYPE CBORE_DYL               ' 2/NR:1012  BoreProfileTransverseDynamic
        m_ID as Long               '        identifier 1012
        m_Z1 as Single             '        parameter s on start
        m_Z2 as Single             '        parameter s on end
        m_D0 as Single             ' [ 105] constant damping
        m_D1 as Single             ' [ 105] parabolic damping
        m_D2 as Single             ' [ 105] linear damping
        m_D3 as Single             ' [ 105] quadratic damping
        m_M0 as Single             ' [1181] constant soil mass
        m_M2 as Single             ' [1181] linear soil mass
      END TYPE

const AXIS_SUBTYPE_NONE = 0
const AXIS_SUBTYPE_AXIS = 1
const AXIS_SUBTYPE_BEAM = 2
const AXIS_SUBTYPE_LANE = 10
const AXIS_SUBTYPE_BGEO = 11
const AXIS_SUBTYPE_TEND = 12
const AXIS_SUBTYPE_POST = 15
const AXIS_SUBTYPE_AUXI = 19
const AXIS_SUBTYPE_GRAF = 90
      TYPE CAXIS                   ' 3/ID:0  Geometric Axis
        m_ID0 as Long              '        identifier 0
        m_ID1 as Long              '        subtype of axis
        m_ID2 as Long              '        reserved
        m_ID3 as Long              '        reserved
        m_ID4 as Long              '        reserved
        m_ID5 as Long              '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Line
      END TYPE

      TYPE CAXIS_REF               ' 3/ID:-  Reference to another Geometry
        m_IGM as Long              '        negative value of the master geometry 03/abs(IGM)
        m_IGS as Long              '        optional identifier of a secondary axis
        m_SMIN as Single           '        min parameter on referenced axis
        m_SMAX as Single           '        max parameter on referenced axis
      END TYPE

const GAX_GEO_DEFAULT = 1
const GAX_GEO_PROJECT = 2
const GAX_GEO_SPLINE = 3
const GAX_GEO_EXSPLI = 4
const GAX_GEO_BEZIER = 5
const GAX_GEO_NURBS = 6
const GAX_GEO_NURBX = 7
const GAX_GEO_DATA = 8
const GAX_GEO_NORM = 9
const GAX_GEO_CIRC = 11
const GAX_GEO_CBEZIER = 15
const GAX_GEO_CNURBS = 16
const GAX_GEO_PROJ_CLO = 20
const GAX_GEO_PROJ_CUB = 21
const GAX_GEO_PROJ_BLO = 22
const GAX_GEO_PROJ_SIN = 24
const GAX_GEO_PROJ_COS = 25
const GAX_GEO_NURBS_KN = 90
const GAX_GEO_NURBS_CPT = 91
      TYPE CAXIS_GEO               ' 3/ID:??  Geometric properties
        m_ILN as Long              '        Code of geometry
        m_GPG as Single            ' [1001] geometry parameter 1
        m_GPA as Single            ' [1001] geometry parameter 2
        m_DD as Single             ' [1001] arc length
        m_S1 as Single             '        parameter s on start
        m_XYZ1(1 to 3) as Single   ' [1001] Ordinate of start
        m_DXYZ1(1 to 3) as Single  '        Tangent of start
        m_RG1 as Single            ' [1009] in-plane curvature
        m_RA1 as Single            ' [1009] vertical curvature
        m_S2 as Single             '        parameter s on end
        m_XYZ2(1 to 3) as Single   ' [1001] Ordinate of endpoint
        m_DXYZ2(1 to 3) as Single  '        Tangent of endpoint
        m_RG2 as Single            ' [1009] in-plane curvature
        m_RA2 as Single            ' [1009] vertical curvature
        m_XAT as Single            ' [1001] relat. startordinate
      END TYPE

      TYPE CAXIS_NKN               ' 3/ID:90  Knots of a Nurb
        m_ILN as Long              '        ID=90
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Single    '        Knot-Vector
      END TYPE

      TYPE CSLN_NKN                ' 39/NR:90  Knots of a Nurb
        m_ILN as Long              '        ID=90
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Single    '        Knot-Vector
      END TYPE

      TYPE CAXIS_CPT               ' 3/ID:91  Control point of a Nurb
        m_ILN as Long              '        ID=91
        m_W as Single              '        Weight
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates
        m_DIR(1 to 3) as Single    '        upward direction
      END TYPE

      TYPE CSLN_CPT                ' 39/NR:91  Control point of a Nurb
        m_ILN as Long              '        ID=91
        m_W as Single              '        Weight
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates
        m_DIR(1 to 3) as Single    '        upward direction
      END TYPE

      TYPE CAXIS_PT                ' 3/ID:92  Data point on curve
        m_ILN as Long              '        ID=92
        m_S as Single              '        Parameter along curve
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates
        m_DIR(1 to 3) as Single    '        upward direction
      END TYPE

      TYPE CSLN_PT                 ' 39/NR:92  Data point on curve
        m_ILN as Long              '        ID=92
        m_S as Single              '        Parameter along curve
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates
        m_DIR(1 to 3) as Single    '        upward direction
      END TYPE

      TYPE CAXIS_ARC               ' 3/ID:93  Circular Arc
        m_ILN as Long              '        ID=93
        m_IDF as Long              '        Definition selected
        m_R as Single              ' [1001] Radius of arc
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates of center
        m_DIR(1 to 3) as Single    '        upward direction of plane
        m_XYZA(1 to 3) as Single   ' [1001] optional start point of arc
        m_XYZE(1 to 3) as Single   ' [1001] optional end point of arc
      END TYPE

      TYPE CSLN_ARC                ' 39/NR:93  Circular Arc
        m_ILN as Long              '        ID=93
        m_IDF as Long              '        Definition selected
        m_R as Single              ' [1001] Radius of arc
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates of center
        m_DIR(1 to 3) as Single    '        upward direction of plane
        m_XYZA(1 to 3) as Single   ' [1001] optional start point of arc
        m_XYZE(1 to 3) as Single   ' [1001] optional end point of arc
      END TYPE

      TYPE CAXIS_SPT               ' 3/ID:97  Station point on a Nurb
        m_ILN as Long              '        ID=97
        m_S as Single              '        Station value at data point
        m_L as Single              ' [1001] Length (prescribed if XYZ==0.0)
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates for 3D-intersection plane
        m_DIR(1 to 3) as Single    '        Direction (nx,ny,nz) of normal of the plane
      END TYPE

      TYPE CAXIS_VIZ               ' 3/ID:98  Data points for visualisation
        m_ILN as Long              '        ID=98
        m_COLOR as Long            '        hexadecimal RGB-value (e.g. 99AAFF)
        m_THICK as Long            '        Thickness in pixel
        m_PTS(1 to 64,1 to 3) as Single ' [1001] Data Points
      END TYPE

      TYPE CAXIS_OBB               ' 3/ID:99  Oriented Boundig Box
        m_ILN as Long              '        ID=99
        m_S1 as Single             '        Parameter on Start
        m_S2 as Single             '        Parameter on end
        m_TA(1 to 3,1 to 3) as Single '        Transformation Matrix
        m_XYZ(1 to 3) as Single    ' [1001] Center of Box
        m_XI(1 to 3) as Single     ' [1001] Half widths
      END TYPE

      TYPE CAXIS_ATB               ' 3/ID:101  Geometric segments of axis plan view
        m_ID0 as Long              '        ident=101
        m_ID1 as Long              '        specification type
        m_ID2 as Long              '        type of transition curve to be used
        m_S as Single              '        Station value at tangent
        m_L(1 to 5) as Single      ' [1001] Length of segment
        m_R(1 to 5) as Single      ' [1001] Radius mid & start & end
        m_XYZ(1 to 3) as Single    ' [1001] Startpoint of tangent
        m_DIR(1 to 3) as Single    '        Tangential direction
        m_D(1 to 2) as Single      ' [1001] Distance to point on curve (start/end)
        m_TAU as Single            ' [   5] deflection angle
        m_TXT as Long              '        Identifier of this sequence
      END TYPE

      TYPE CAXIS_VTB               ' 3/ID:102  Geometric properties for axis heights
        m_ID0 as Long              '        ident=102
        m_ID1 as Long              '        specification type
        m_ID2 as Long              '        reserved
        m_S as Single              '        Parameter s along the axis
        m_H as Single              ' [1001] Height of gradient polygon
        m_R as Single              ' [1001] Radius of curvature at this point
        m_X as Single              ' [1001] Calculated true length along the axis
        m_T as Single              ' [1001] Calculated secant length along the axis
      END TYPE

      TYPE CAXIS_ITB               ' 3/ID:103  Placement at axis position
        m_ID0 as Long              '        ident=103
        m_IDS as Long              '        Enum of secondary axis
        m_TYP as Long              '        properties of this placement
        m_NPT as Long              '        point number
        m_GRP as Long              '        group number behind that placement
        m_NOS(1 to 2) as Long      '        Number of section before and behind that placement
        m_SEGT as Long             '        identifier of a segment see (900/0) behind that placement
        m_S as Single              '        Parameter s of this section
        m_Y as Single              ' [1001] additional transverse offset
        m_Z as Single              ' [1001] additional vertical offset
        m_ALF as Single            ' [   5] Rotation about global Z
        m_ALFX as Single           ' [   5] Rotation about local axis x
        m_ALFY as Single           ' [   5] Rotation about transverse y
        m_ALFZ as Single           ' [   5] Rotation about vertical   z
        m_INCR as Single           ' [   5] Inclination to the right +y
        m_INCL as Single           ' [   5] Inclination to the left  -y
        m_SRULE(1 to 5) as Long    '        Formula string to evaluate the value S
        m_TEXT(1 to 17) as Long    '        Designation of Placement
      END TYPE

      TYPE CAXIS_ITS               ' 3/ID:104  Secondary axis definition
        m_ID0 as Long              '        Ident=104
        m_IDS as Long              '        Enum of secondary axis (1='A' to 26 ='Z')
        m_IREF as Long             '        Reference to external axis geometry
        m_NPT as Long              '        offset for structural points along the axis
        m_GRP as Long              '        group number (:103 is always added as an offset)
        m_Y as Single              ' [1001] constant or maximum value of y offset
        m_Z as Single              ' [1001] constant or maximum value of z offset
        m_Y_V(1 to 4) as Long      '        variable name for y offset (see :110)
        m_Z_V(1 to 4) as Long      '        variable name for z offset (see :110)
        m_TEXT(1 to 17) as Long    '        Designation (only for first point of a sequence)
      END TYPE

      TYPE CAXIS_PSM               ' 3/ID:105  Prestress method
        m_ID0 as Long              '        ident=105
        m_IDT as Long              '        Identifier of Tendon
        m_TYPE as Long             '        Type of Spline geometry
        m_NSP as Long              '        Number of tendon elements
        m_ID5 as Long              '        Placement of tendons
        m_JACK as Long             '        Jacking procedure
        m_LIRE as Long             '        Sides for jacking
        m_IBA(1 to 3) as Long      '        Construction stage identifiers
        m_NRSV as Long             '        number of jacking method
        m_DUMMY(1 to 5) as Long    '        reserved
        m_FAK as Single            '        factor for prestress
        m_LITZ as Single           '        partial number of strands
        m_FRSP(1 to 2) as Single   ' [1001] Length controls for free tendon geometry
        m_ZSP(1 to 2) as Single    ' [1011] Distances of tendon to extreme fiber upper/lower
        m_TEXTL(1 to 17) as Long   '        Designation of layer of Tendons
      END TYPE

      TYPE CAXIS_PSP               ' 3/ID:106  Prestress placements
        m_ID0 as Long              '        ident=106
        m_TYP as Long              '        Type of placement
        m_ID2 as Long              '        Type of station data (bitpattern)
        m_ID3 as Long              '        reserved
        m_ID4 as Long              '        reserved
        m_ID5 as Long              '        reserved
        m_S as Single              '        Station along axis
        m_ZT as Single             ' [1011] Distances of tendon to extreme fiber upper/lower
        m_DZT as Single            '        inclination of tendon to axis
      END TYPE

      TYPE CAXIS_PLC               ' 3/ID:107  Placement at axis position
        m_ID0 as Long              '        ident=107
        m_IDS as Long              '        Enum of secondary axis
        m_TYP as Long              '        properties of this placement
        m_NPT as Long              '        point number
        m_GRP as Long              '        group number behind that placement
        m_NOS(1 to 2) as Long      '        Number of section before and behind that placement
        m_IB0 as Long              '        general bit-mask
        m_IDP as Long              '        identifier of this placement
        m_SEGT as Long             '        identifier of a segment see (900/0) behind that placement
        m_RES(1 to 6) as Long      '        reserved
        m_S as Single              '        Parameter s of this section
        m_Y as Single              ' [1001] additional transverse offset
        m_Z as Single              ' [1001] additional vertical offset
        m_ALF as Single            ' [   5] Rotation about global Z
        m_ALFX as Single           ' [   5] Rotation about local axis x
        m_ALFY as Single           ' [   5] Rotation about transverse y
        m_ALFZ as Single           ' [   5] Rotation about vertical   z
        m_INCR as Single           ' [   5] Inclination to the right +y
        m_INCL as Single           ' [   5] Inclination to the left  -y
        m_SRULE(1 to 5) as Long    '        Formula string to evaluate the value S
        m_TEXT(1 to 17) as Long    '        Designation of placement
      END TYPE

      TYPE CAXIS_OPT               ' 3/ID:10107  Placement options
        m_ID0 as Long              '        ident=10107
        m_A_FILTER as Long         '        Filter for axis
        m_T_FILTER as Long         '        Filter for axis type
      END TYPE

      TYPE CAXIS_PRP               ' 3/ID:110  General properties of axis
        m_ID0 as Long              '        ident=110
        m_NAME(1 to 4) as Long     '        Name of this item
        m_TYP as Long              '        Continuity Type of this data point
        m_S_VAL(1 to 5) as Single  '        Parameter s of this section and values
        m_SRULE(1 to 5) as Long    '        Formula string to evaluate the value S
        m_VRULE(1 to 10) as Long   '        Formula string to evaluate the value VAL
        m_DVRULE(1 to 10) as Long  '        Formula string to evaluate the value dVAL/dS
      END TYPE

      TYPE CGAXD_ATB               ' 3/ID:121  Geometric segments of axis plan view (double precision)
        m_ID0 as Long              '        ident=121
        m_ID1 as Long              '        specification type
        m_ID2 as Long              '        type of transition curve to be used
        m_ID3 as Long              '        reserved
        m_S as Double              '        Station value at tangent
        m_L(1 to 5) as Double      ' [1001] Length of segment
        m_R(1 to 5) as Double      ' [1001] Radius mid & start & end
        m_XYZ(1 to 3) as Double    ' [1001] Startpoint of tangent
        m_DIR(1 to 3) as Double    '        Tangential direction
        m_D(1 to 2) as Double      ' [1001] Distance to point on curve (start/end)
        m_TAU as Double            ' [   5] deflection angle
        m_TXT0 as Long             '        reserved
        m_TXT as Long              '        Identifier of this sequence
      END TYPE

      TYPE CGAXD_VTB               ' 3/ID:122  Geometric properties for axis heights (double precision)
        m_ID0 as Long              '        ident=122
        m_ID1 as Long              '        specification type
        m_ID2 as Long              '        reserved
        m_ID3 as Long              '        reserved
        m_S as Double              '        Parameter s along the axis
        m_H as Double              ' [1001] Height of gradient polygon
        m_R as Double              ' [1001] Radius of curvature at this point
        m_X as Double              ' [1001] Calculated true length along the axis
        m_T as Double              ' [1001] Calculated secant length along the axis
      END TYPE

const GAXD_GEO_DEFAULT = 181
const GAXD_GEO_PROJECT = 182
      TYPE CGAXD_GEO               ' 3/ID:18?  Geometric properties
        m_ILN as Long              '        Code of geometry
        m_ID1 as Long              '        reserved
        m_GPG as Double            ' [1001] geometry parameter 1
        m_GPA as Double            ' [1001] geometry parameter 2
        m_DD as Double             ' [1001] arc length
        m_S1 as Double             '        parameter s on start
        m_XYZ1(1 to 3) as Double   ' [1001] Ordinate of start
        m_DXYZ1(1 to 3) as Double  '        Tangent of start
        m_RG1 as Double            ' [1009] in-plane curvature
        m_RA1 as Double            ' [1009] vertical curvature
        m_S2 as Double             '        parameter s on end
        m_XYZ2(1 to 3) as Double   ' [1001] Ordinate of endpoint
        m_DXYZ2(1 to 3) as Double  '        Tangent of endpoint
        m_RG2 as Double            ' [1009] in-plane curvature
        m_RA2 as Double            ' [1009] vertical curvature
        m_XAT as Double            ' [1001] relat. startordinate
      END TYPE

      TYPE CGAXD_NKN               ' 3/ID:190  Knots of a Nurb
        m_ILN as Long              '        ID=190
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Double    '        Knot-Vector
      END TYPE

      TYPE CGAXD_CPT               ' 3/ID:191  Control point of a Nurb
        m_ILN as Long              '        ID=191
        m_ID1 as Long              '        reserved
        m_W as Double              '        Weight
        m_XYZ(1 to 3) as Double    ' [1001] Coordinates
        m_DIR(1 to 3) as Double    '        upward direction
      END TYPE

      TYPE CGAXD_PT                ' 3/ID:192  Data point on curve
        m_ILN as Long              '        ID=192
        m_ID1 as Long              '        specification type
        m_S as Double              '        Parameter along curve
        m_XYZ(1 to 3) as Double    ' [1001] Coordinates
        m_DIR(1 to 3) as Double    '        direction
      END TYPE

      TYPE CGAXD_ARC               ' 3/ID:193  Circular Arc
        m_ILN as Long              '        ID=193
        m_IDF as Long              '        Definition selected
        m_R as Double              ' [1001] Radius of arc
        m_XYZ(1 to 3) as Double    ' [1001] Coordinates of center
        m_DIR(1 to 3) as Double    '        upward direction of plane
        m_XYZA(1 to 3) as Double   ' [1001] optional start point of arc
        m_XYZE(1 to 3) as Double   ' [1001] optional end point of arc
      END TYPE

      TYPE CAXIS_TRL               ' 3/ID:300  Properties for train loading
        m_ID0 as Long              '        ident 300
        m_NRA as Long              '        Number of the lane (0:99)
        m_NRS as Long              '        Number of the segment
        m_BTYP as Long             '        Literal of default type
        m_SA as Single             '        Parameter s of start of this section
        m_SE as Single             '        Parameter s of end of this section
        m_YCA as Single            ' [1001] Center ordinate of lane at SA
        m_YCE as Single            ' [1001] Center ordinate of lane at SE
        m_YRA as Single            ' [1001] Right boundary at SA of lane area
        m_YRE as Single            ' [1001] Right boundary at SE of lane area
        m_YLA as Single            ' [1001] Left boundary at SA of lane area
        m_YLE as Single            ' [1001] Left boundary at SE of lane area
        m_L as Single              ' [1001] Reference length for impact factor
        m_HSA as Single            ' [1001] Total height of traffic lane above axis at SA
        m_HSE as Single            ' [1001] Total height of traffic lane above axis at SE
        m_INCA as Single           ' [   5] Inclination within lane at SA
        m_INCE as Single           ' [   5] Inclination within lane at SE
        m_HEFF as Single           ' [1001] Height of rail and sleeper construction
        m_BEFF as Single           ' [1001] Effective length of sleeper
        m_DEFF as Single           ' [1001] Width of sleepers
        m_INCD as Single           '        Inclination of load distribution (e.g. 1:4)
        m_ASL as Single            ' [1001] Distance of Sleepers or mounting points
      END TYPE

      TYPE CTEND                   ' 4/ID:0  Prestressing Schemes
        m_ID0 as Long              '        identifier 0
        m_KEY as Long              '        Control bits + Info
        m_ID2 as Long              '        reserved
        m_TXT(1 to 17) as Long     '        Main Designation of company and scheme
      END TYPE

      TYPE CTEND_1                 ' 4/ID:1  Tendon of Prestressing Schemes
        m_ID0 as Long              '        identifier 1
        m_MNR as Long              '        Material number of Prestressing Steel
        m_ID2 as Long              '        reserved
        m_ZV as Single             ' [1028] Nominal force
        m_AZ as Single             ' [1020] Area of tendon
        m_RNLI as Single           '        Number or wires
        m_SLS as Single            ' [  16] Slip at anchor
        m_SLK as Single            ' [  16] Slip at coupling
        m_SLF as Single            ' [  16] Slip at fixed end
        m_VLS as Single            '        Loss at anchor
        m_VLK as Single            '        Loss at coupling
        m_VLF as Single            '        Loss at fixed end
        m_DLS as Single            ' [1001] Straight at anchor
        m_DLK as Single            ' [1001] Straight at coupling
        m_DLF as Single            ' [1001] Straight at fixed end
        m_DI as Single             ' [1023] inner diameter of duct
        m_DA as Single             ' [1023] outer diamtere of duct
        m_RMIN as Single           ' [1001] minimum radius
        m_BETA(1 to 2) as Single   ' [  17] unintended angles
        m_RMUE(1 to 2) as Single   '        Friction coefficients
        m_EXZ as Single            ' [1011] max exzentricity
        m_EACHS as Single          ' [1011] distance between
        m_ERAND as Single          ' [1011] distance to outer edge
        m_BLOCK(1 to 8) as Single  '        reserved extra data
        m_TXT(1 to 17) as Long     '        Designation of tendon
      END TYPE

      TYPE CTEND_2                 ' 4/ID:2  Anchor of Prestressing Schemes
        m_ID0 as Long              '        identifier 2
        m_ID1 as Long              '        Type of anchor
        m_TYP as Long              '        Type of anchor geometry
        m_ANKER(1 to 16) as Single '        Data
        m_TXT(1 to 17) as Long     '        Designation of anchor
      END TYPE

      TYPE CTEND_3                 ' 4/ID:3  Jack of Prestressing Schemes
        m_ID0 as Long              '        identifier 2
        m_ID1 as Long              '        reserved
        m_TYP as Long              '        Type of jack
        m_JACK(1 to 16) as Single  '        Data
        m_TXT(1 to 17) as Long     '        Designation of jack
      END TYPE

      TYPE CAREA                   ' 5/ID:0  Geometric Area
        m_ID0 as Long              '        identifier 0
        m_NG as Long               '        Type of surface representation
        m_GID1 as Long             '        Axis identifier of first reference axis
        m_GID2 as Long             '        Axis identifier of second reference axis
        m_MGRI as Long             '        number of data/control points in s of mesh
        m_NGRI as Long             '        number of data/control points in t of mesh
        m_MSPL as Long             '        degree of B-spline in s direction
        m_NSPL as Long             '        degree of B-spline in t direction
        m_SFLG as Long             '        property options of surface
        m_T(1 to 4,1 to 3) as Single '        Transformation
        m_PAR(1 to 16) as Single   '        additional Parameters
        m_BOX(1 to 3,1 to 2) as Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        m_TEXT(1 to 17) as Long    '        Designation of Line
      END TYPE

      TYPE CAREA_CPT               ' 5/ID:10  Control points of area
        m_ID as Long               '        Identification of control point data = 10
        m_XPAR(1 to 9999) as Single'        spline grid and coefficients
      END TYPE

      TYPE CAREA_PTS               ' 5/ID:11  AreaPointonSurface
        m_ID as Long               '        Identification of surface description = 11
        m_IT as Long               '        Type of point
        m_M as Long                '        Rasterlocation of mesh (0 < m < mgri )
        m_N as Long                '        Rasterlocation of mesh (0 < n < ngri )
        m_W as Single              '        the weight of NURBS control point
        m_X as Single              ' [1001] X-ordinate
        m_Y as Single              ' [1001] Y-ordinate
        m_Z as Single              ' [1001] Z-ordinate
        m_T as Single              ' [1010] Thickness
      END TYPE

      TYPE CAREA_CPI               ' 5/ID:12  COONsPatchInfo
        m_ID as Long               '        Identification of COONs blending edges 12
        m_IT as Long               '        Type of blending
        m_IU0 as Long              '        No of geometry line for u=umin (left)
        m_IU1 as Long              '        No of geometry line for u=umax (right)
        m_IV0 as Long              '        No of geometry line for v=vmin (lower)
        m_IV1 as Long              '        No of geometry line for v=vmax (upper)
        m_SP(1 to 4,1 to 3) as Single '        Length parameters for the edges iu0,iu1,iv0,iv1
        m_UV(1 to 2,1 to 2) as Single '        umin,umax,vmin,vmax of the parameter plane
        m_CXYZ(1 to 4,1 to 3) as Single '        Coordinates of the corner points C1,C2,C3,C4
        m_TINC(1 to 8,1 to 3) as Single '        inclinations for a bicubic patch as vectors
        m_TWIST(1 to 4,1 to 3) as Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END TYPE

      TYPE CAREA_NKN               ' 5/ID:9?  Knots of a Nurb
        m_ILN as Long              '        ID
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Single    '        Knot-Vector
      END TYPE

      TYPE CGARD_PTS               ' 5/ID:290  AreaPointonSurface
        m_ID as Long               '        Id = 290
        m_IT as Long               '        Type of point
        m_M as Long                '        Rasterlocation of mesh (0 < m < mgri )
        m_N as Long                '        Rasterlocation of mesh (0 < n < ngri )
        m_W as Double              '        the weight of NURBS control point
        m_X as Double              ' [1001] X-ordinate
        m_Y as Double              ' [1001] Y-ordinate
        m_Z as Double              ' [1001] Z-ordinate
        m_T as Double              ' [1010] Thickness
      END TYPE

      TYPE CGARD_NKU               ' 5/ID:291  Knots of a Nurb
        m_ILN as Long              '        ID
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Double    '        Knot-Vector
      END TYPE

      TYPE CGARD_NKV               ' 5/ID:292  Knots of a Nurb
        m_ILN as Long              '        ID
        m_DEG as Long              '        Order of Spline
        m_S(1 to 256) as Double    '        Knot-Vector
      END TYPE

      TYPE CCON_0                  ' 8/ID:0  Connection Headder
        m_IDS as Long              '        Identification = 0
        m_TYP as Long              '        Type of connection
        m_MAT as Long              '        Materialnumber for all plates
        m_TEXT(1 to 17) as Long    '        designation of connection
      END TYPE

      TYPE CCON_BOL                ' 8/ID:1  Definition of Bolts
        m_IDS as Long              '        Identification = 1
        m_TYP as Long              '        Type of hole
        m_MAT as Long              '        Materialdesignation of bolt
        m_D as Single              ' [1011] Diameter of bolt
        m_NORM(1 to 4) as Long     '        Designation of product code
        m_TEXT(1 to 17) as Long    '        designation of bolt
      END TYPE

      TYPE CCON_WEL                ' 8/ID:2  Definition of Weldings
        m_IDS as Long              '        Identification = 2
        m_TYP as Long              '        Type of weld
        m_MAT as Long              '        Materialnumber of weld (not used)
        m_T as Single              ' [1011] Thickness of weld
        m_AW as Single             '        Reduction factor
        m_TEXT(1 to 17) as Long    '        designation of weld
      END TYPE

      TYPE CCON_CLE                ' 8/ID:3  Definition of Cleats (Angle/Latch)
        m_IDS as Long              '        Identification = 3
        m_TYP as Long              '        Enum of type (angle/latch not really enforced)
        m_MAT as Long              '        Material number of the plate
        m_BOL(1 to 2) as Long      '        id of bolts
        m_NBB(1 to 2) as Long      '        Number of bolts in width direction
        m_NBL(1 to 2) as Long      '        Number of bolts in angle directions 1 & 2
        m_T as Single              ' [1011] Thickness of cleat
        m_B as Single              ' [1011] Width/Height of cleat
        m_L(1 to 2) as Single      ' [1011] Length of angles
        m_W(1 to 8) as Single      ' [1011] Distances
        m_A(1 to 2) as Single      ' [1011] weld thickness for NBL(i) if welding is used
        m_TF as Single             ' [1011] Thickness of backplate
        m_TEXT(1 to 17) as Long    '        designation of element
      END TYPE

      TYPE CCON_MEM                ' 8/ID:10  Connected Member data
        m_IDS as Long              '        Identification = 10
        m_NR as Long               '        Enumeration or designation of member
        m_TYP as Long              '        Type of connection bitpattern
        m_NRQ as Long              '        Number of section
        m_WTYP as Long             '        id of the web connection
        m_UTYP as Long             '        id of the upper flange connection
        m_LTYP as Long             '        id of the lower flange connection
        m_L as Single              ' [1001] length of member
        m_AW as Single             ' [1011] weld thickness for web connection
        m_AU as Single             ' [1011] weld thickness for upper flange connection
        m_AL as Single             ' [1011] weld thickness for lower flange connection
        m_DD as Single             ' [1011] Distance value of endpoint to central node
        m_D(1 to 3) as Single      '        Direction vector to beam axis in the
        m_ROTY as Single           ' [   5] Angle of end plate y-rotation
        m_ROTZ as Single           ' [   5] Angle of end plate z-rotation
        m_CUTU as Single           ' [1011] Cut out height for upper flange
        m_CUTL as Single           ' [1011] Cut out height for lower flange
        m_CLU as Single            ' [1011] Cut out length for upper flange
        m_CLD as Single            ' [1011] Cut out length for lower flange
        m_VOUTE(1 to 4,1 to 2) as Single ' [1011] Voute [lenght,height] for
      END TYPE

      TYPE CCON_END                ' 8/ID:11  Endplate of Beam
        m_IDS as Long              '        Identification = 11
        m_TYP as Long              '        Type of end plate
        m_MAT as Long              '        Materialnumber of endplate
        m_BOLT as Long             '        Identifier of bolt type
        m_NBR as Long              '        Number of bolts in height direction
        m_NBC as Long              '        Number of bolts in width direction
        m_B as Single              ' [1011] Width of plate
        m_H as Single              ' [1011] Total plate height
        m_MX as Single             ' [1011] Eccentricity
        m_T as Single              ' [1011] Thickness of plate
        m_HB(1 to 5) as Single     ' [1011] Height for bolts
        m_W(1 to 2) as Single      ' [1011] Width for bolts
        m_HTBP(1 to 4) as Single   ' [1011] Height and thickness values for back plates
      END TYPE

      TYPE CCON_PIN                ' 8/ID:12  Pinned plate of Beam
        m_IDS as Long              '        Identification = 13
        m_MAT as Long              '        Materialnumber of pin plate
        m_MATS as Long             '        Materialnumber of support plate
        m_MATP as Long             '        Materialnumber of pin
        m_DP as Single             ' [1011] Diameter of pin
        m_DH as Single             ' [1011] Diameter of hole
        m_TP as Single             ' [1011] Thickness pin plate
        m_TSUP as Single           ' [1011] Thickness sup plate
        m_C as Single              ' [1011] gap between plates
        m_E1 as Single             ' [1011] eccentricity 1
        m_E2 as Single             ' [1011] eccentricity 2
      END TYPE

      TYPE CCON_PLT                ' 8/ID:20  Additional plates in connection
        m_IDS as Long              '        Identification = 20
        m_TYP as Long              '        Type of plate
        m_MAT as Long              '        Number of material
        m_T as Single              ' [1011] Thickness of plate
        m_EDGE(1 to 8,1 to 5) as Single ' [1011] Local coordinates, weldid, weldthickness
      END TYPE

      TYPE CSECT                   ' 9/NR:0  SectionalValues (total section)
        m_ID as Long               '        Identification
        m_MNO as Long              '        Materialnumber of sections
        m_MRF as Long              '        Materialnumber of Reinforcement
        m_A as Single              ' [1012] Area
        m_AY as Single             ' [1012] Sheardeformation area Y
        m_AZ as Single             ' [1012] Sheardeformation area Z
        m_IT as Single             ' [1014] Torsional moment of inertia
        m_IY as Single             ' [1014] Moments of inertia y-y
        m_IZ as Single             ' [1014] Moments of inertia z-z
        m_IYZ as Single            ' [1014] Moments of inertia y-z
        m_YS as Single             ' [1011] y-Ordinate Center of elasticity
        m_ZS as Single             ' [1011] z-Ordinate Center of elasticity
        m_YSC as Single            ' [1011] y-Ordinate of Shear-Center
        m_ZSC as Single            ' [1011] z-Ordinate of Shear-Center
        m_EM as Single             ' [1090] Elasticity Modulus
        m_GM as Single             ' [1090] Shear Modulus
        m_GAM as Single            ' [1091] Nominal weight
      END TYPE

      TYPE CSECT_EFF               ' 9/NR:1  SectionalValues (effective section)
        m_ID as Long               '        Identification
        m_MNO as Long              '        Materialnumber of sections
        m_MRF as Long              '        Materialnumber of Reinforcement
        m_A as Single              ' [1012] Area
        m_AY as Single             ' [1012] Sheardeformation area Y
        m_AZ as Single             ' [1012] Sheardeformation area Z
        m_IT as Single             ' [1014] Torsional moment of inertia
        m_IY as Single             ' [1014] Moments of inertia y-y
        m_IZ as Single             ' [1014] Moments of inertia z-z
        m_IYZ as Single            ' [1014] Moments of inertia y-z
        m_YS as Single             ' [1011] y-Ordinate Center of elasticity
        m_ZS as Single             ' [1011] z-Ordinate Center of elasticity
        m_YSC as Single            ' [1011] y-Ordinate of Shear-Center
        m_ZSC as Single            ' [1011] z-Ordinate of Shear-Center
        m_EM as Single             ' [1090] Elasticity Modulus
        m_GM as Single             ' [1090] Shear Modulus
        m_GAM as Single            ' [1091] Nominal weight
      END TYPE

      TYPE CSECT_PAR               ' 9/NR:2  SectionalValues (total part of section)
        m_ID as Long               '        Identification
        m_MNO as Long              '        Materialnumber of sections
        m_MRF as Long              '        Materialnumber of Reinforcement
        m_A as Single              ' [1012] Area
        m_AY as Single             ' [1012] Sheardeformation area Y
        m_AZ as Single             ' [1012] Sheardeformation area Z
        m_IT as Single             ' [1014] Torsional moment of inertia
        m_IY as Single             ' [1014] Moments of inertia y-y
        m_IZ as Single             ' [1014] Moments of inertia z-z
        m_IYZ as Single            ' [1014] Moments of inertia y-z
        m_YS as Single             ' [1011] y-Ordinate Center of elasticity
        m_ZS as Single             ' [1011] z-Ordinate Center of elasticity
        m_YSC as Single            ' [1011] y-Ordinate of Shear-Center
        m_ZSC as Single            ' [1011] z-Ordinate of Shear-Center
        m_EM as Single             ' [1090] Elasticity Modulus
        m_GM as Single             ' [1090] Shear Modulus
        m_GAM as Single            ' [1091] Nominal weight
      END TYPE

      TYPE CSECT_PEF               ' 9/NR:3  SectionalValues (effective part of section)
        m_ID as Long               '        Identification
        m_MNO as Long              '        Materialnumber of sections
        m_MRF as Long              '        Materialnumber of Reinforcement
        m_A as Single              ' [1012] Area
        m_AY as Single             ' [1012] Sheardeformation area Y
        m_AZ as Single             ' [1012] Sheardeformation area Z
        m_IT as Single             ' [1014] Torsional moment of inertia
        m_IY as Single             ' [1014] Moments of inertia y-y
        m_IZ as Single             ' [1014] Moments of inertia z-z
        m_IYZ as Single            ' [1014] Moments of inertia y-z
        m_YS as Single             ' [1011] y-Ordinate Center of elasticity
        m_ZS as Single             ' [1011] z-Ordinate Center of elasticity
        m_YSC as Single            ' [1011] y-Ordinate of Shear-Center
        m_ZSC as Single            ' [1011] z-Ordinate of Shear-Center
        m_EM as Single             ' [1090] Elasticity Modulus
        m_GM as Single             ' [1090] Shear Modulus
        m_GAM as Single            ' [1091] Nominal weight
      END TYPE

const SECT_ADD_MOD = 0
const SECT_ADD_VAL = 1
const SECT_ADD_TYP = 2
const SECT_ADD_PLA = 3
const SECT_ADD_SOL = 4
const SECT_ADD_EFF = 5
const SECT_ADD_FEM = 6
const SECT_ADD_HYD = 9
const SECT_ADD_FIBRE = +128
const SECT_ADD_NEFF = +512
const SECT_ADD_INTE = +1024
const SECT_ADD_TEMP = +2048
const SECT_ADD_VARI = +4096
const SECT_ADD_REFP = +8192
const SECT_ADD_HOT = +16384
      TYPE CSECT_ADD               ' 9/NR:4  SectionalValuesShear , Temperature
        m_ID as Long
        m_STYPE as Long
        m_MRF as Long              '        Materialnumber of Stirup-Reinforcement
        m_AT as Single             ' [ 107] Elongationkoefficient for Temperature
        m_YMIN as Single           ' [1011] Minimum Ordinate of section to center ys
        m_YMAX as Single           ' [1011] Maximum Ordinate of section to center ys
        m_ZMIN as Single           ' [1011] Minimum Ordinate of section to center zs
        m_ZMAX as Single           ' [1011] Maximum Ordinate of section to center zs
        m_TMIN as Single           ' [1011] minimum thickness
        m_TMAX as Single           ' [1011] maximum thickness
        m_WT as Single             ' [1018] maximum tau for Torsion MT=1
        m_WVY as Single            ' [1017] maximum tau for Shear VY=1
        m_WVZ as Single            ' [1017] maximum tau for Shear VZ=1
        m_WT2 as Single            ' [1018] maximum tau for sekundary Torsion
        m_AK as Single             ' [1012] kernel area for Torsion
        m_AYZ as Single            ' [1012] Shear deviation area
        m_AB as Single             ' [1012] pure concrete area
        m_LEVY as Single           ' [1011] minimum lever for cracked shear Vy
        m_LEVZ as Single           ' [1011] minimum lever for cracked shear Vz
        m_ELVY as Single           ' [  17] elastic shear flux for Vy = Sy-max/Iz
        m_ELVZ as Single           ' [  17] elastic shear flux for Vz = Sz-max/Iy
        m_YMINE as Single          ' [1011] Minimum Ordinate of effective section
        m_YMAXE as Single          ' [1011] Maximum Ordinate of effective section
        m_ZMINE as Single          ' [1011] Minimum Ordinate of effective section
        m_ZMAXE as Single          ' [1011] Maximum Ordinate of effective section
      END TYPE

      TYPE CSECT_WAR               ' 9/NR:5  SectionalValuesWarping
        m_ID as Long               '        Identification = 5
        m_I_1 as Long              '        unused
        m_I_2 as Long              '        unused
        m_AYYY as Single           ' [1015] Integrals on section
        m_AYYZ as Single           ' [1015] Integrals on section
        m_AYZZ as Single           ' [1015] Integrals on section
        m_AZZZ as Single           ' [1015] Integrals on section
        m_AWY as Single            ' [1015] Integrals on section
        m_AWZ as Single            ' [1015] Integrals on section
        m_AWYY as Single           ' [1016] Integrals on section
        m_AWZZ as Single           ' [1016] Integrals on section
        m_CM as Single             ' [1016] Warping resistance
        m_CMS as Single            ' [1014] Warping Shear resist.
        m_WMIN as Single           ' [1012] Minimum warping
        m_WMAX as Single           ' [1012] Maximum warping
        m_FYSW as Single           ' [1012] Shear VY-MT2 area
        m_FZSW as Single           ' [1012] Shear VZ-MT2 area
        m_IPSC as Single           ' [1014] polar inertia at SC
      END TYPE

const SECT_IBC_MULT = 32
      TYPE CSECT_PLA               ' 9/NR:6  SectionalPlasticForces
        m_ID as Long               '        Identification = 6
        m_IBC as Long              '        Buckling curve
        m_IB as Long               '        Control
        m_WPN as Single            ' [1101] Normal force
        m_WPVY as Single           ' [1102] Y-Shear force
        m_WPVZ as Single           ' [1102] Y-Shear force
        m_WPMT as Single           ' [1103] Torsional moment
        m_WPMY as Single           ' [1104] Bending moment My
        m_WPMZ as Single           ' [1104] Bending moment Mz
        m_YSP as Single            ' [1001] Plastic center
        m_ZSP as Single            ' [1001] Plastic center
        m_WPMB as Single           ' [1105] warping moment Mb
        m_WPT2 as Single           ' [1103] 2nd torsional moment
      END TYPE

      TYPE CSECT_DES               ' 9/NR:7  SectionalValuesDesign
        m_ID as Long               '        Identification = 7
        m_MNR as Long              '        used reference material
        m_IBC as Long              '        buckling curve index (see 009/NR:6)
        m_A as Single              ' [1012] Area
        m_AY as Single             ' [1012] Sheardeformation area Y
        m_AZ as Single             ' [1012] Sheardeformation area Z
        m_IT as Single             ' [1014] Torsional moment of inertia
        m_IY as Single             ' [1014] Moments of inertia y-y
        m_IZ as Single             ' [1014] Moments of inertia z-z
        m_IYZ as Single            ' [1014] Moments of inertia y-z
        m_YS as Single             ' [1011] y-Ordinate Center of gravity
        m_ZS as Single             ' [1011] z-Ordinate Center of gravity
        m_YSC as Single            ' [1011] y-Ordinate of Shear-Center
        m_ZSC as Single            ' [1011] z-Ordinate of Shear-Center
        m_EM as Single             ' [1090] Elasticity Modulus/safety
        m_GM as Single             ' [1090] Shear Modulus/safety
        m_GAM as Single            ' [1091] Nominal weight
      END TYPE

      TYPE CSECT_PRE               ' 9/NR:8  SectionalForcesPrestress
        m_ID as Long               '        Identification = 8
        m_ITP as Long              '        subtype of information = 0
        m_ITS as Long              '        source of values
        m_N as Single              ' [1101] Normal force
        m_MY as Single             ' [1104] Bending moment My
        m_MZ as Single             ' [1104] Bending moment Mz
        m_EA as Single             ' [1101] tangential stiffnes E*A
        m_EAY as Single            ' [1105] tangential stiffnes E*A*z*z
        m_EAZ as Single            ' [1105] tangential stiffnes E*A*y*y
        m_EAYZ as Single           ' [1105] tangential stiffnes E*A*y*z
        m_YSE as Single            ' [1011] elastic tangential center ys
        m_ZSE as Single            ' [1011] elastic tangential center zs
        m_NCM as Single            ' [1101] maximum compressive force
        m_NTM as Single            ' [1101] maximum tensile force
      END TYPE

      TYPE CSECT_GV                ' 9/NR:8  SectionalGeometricValues
        m_ID as Long               '        Identification = 8
        m_ITP as Long              '        subtype of information = 2
        m_MNO as Long              '        Materialnumber (0=total section)
        m_UO as Single             ' [1011] outer perimeter
        m_UI as Single             ' [1011] inner perimeter
        m_TMIN as Single           ' [1011] minimum thickness
        m_TMAX as Single           ' [1011] maximum thickness
        m_KTZ as Single            ' [   8] total weight factor
        m_UOM as Single            ' [1011] outer effect.perimeter
        m_UIM as Single            ' [1011] inner effect.perimeter
        m_ARO as Single            ' [1012] Outer total gross area
        m_AR as Single             ' [1012] total gross area
        m_IPM as Single            ' [1183] rotational inertia      gam*Ip  ! values to be converted * DC_M
        m_IYM as Single            ' [1183] sectional mass inertia  gam*Iy  ! values to be converted * DC_M
        m_IZM as Single            ' [1183] sectional mass inertia  gam*Iz  ! values to be converted * DC_M
        m_IYZM as Single           ' [1183] sectional mass inertia  gam*Iyz ! values to be converted * DC_M
        m_YSM as Single            ' [1011] true mass gravity center
        m_ZSM as Single            ' [1011] true mass gravity center
        m_DW as Single             ' [1011] effective thickness for creep/shrinkage
        m_UAIR as Single           ' [1011] air contact perimeter
      END TYPE

      TYPE CSECT_TRA               ' 9/NR:8  SectionalAppliedTransformation
        m_ID as Long               '        Identification = 8
        m_ITP as Long              '        subtype of information = 3
        m_I_2 as Long              '        not used
        m_ALF as Single            ' [   5] rotation angle
        m_YTF as Single            ' [1011] shift in y direction
        m_ZTF as Single            ' [1011] shift in z direction
      END TYPE

      TYPE CSECT_LAY               ' 9/NR:9  SectionalReinforcementLayer  (LAY)
        m_ID as Long               '        Identification = 9
        m_MNR as Long              '        Materialnumber + 1000*No of concrete \%
        m_INR as Long              '        Type/number of layer
        m_TNR as Long              '        Designation
        m_ALOW as Single           ' [1020] Lower bound for area of layer
        m_AHIG as Single           ' [1020] Upper bound for area of layer
        m_ASUM as Single           ' [1020] Sum of reference areas of layer
        m_AFAK as Single           '        maximum allowable factor of layer
        m_YS as Single             ' [1011] center of layer
        m_ZS as Single             ' [1011] center of layer
        m_VAS as Single            ' [1020] Lower sequential total bound of layer area
        m_BAS as Single            ' [1020] Upper sequential total bound of layer area
        m_IY as Single             ' [1014] 4th ord.areas (inertia)
        m_IZ as Single             ' [1014] 4th ord.areas (inertia)
        m_IYZ as Single            ' [1014] 4th ord.areas (inertia)
        m_EMOD as Single           ' [1090] Elasticity-Modulus
        m_BETS as Single           ' [1092] yieldstress
        m_RL as Single             ' [1011] torsional refer. length
        m_DMIN as Single           ' [1023] smallest used diameter
        m_DMAX as Single           ' [1023] largest  used diameter
        m_N as Single              ' [1101] Normal force
        m_MY as Single             ' [1104] Bending moment My
        m_MZ as Single             ' [1104] Bending moment Mz
        m_EA as Single             ' [1101] tangential stiffnes E*A
        m_EAY as Single            ' [1104] tangential stiffnes E*A*z
        m_EAZ as Single            ' [1104] tangential stiffnes E*A*y
        m_EAYY as Single           ' [1105] tangential stiffnes E*A*y*y
        m_EAZZ as Single           ' [1105] tangential stiffnes E*A*z*z
        m_EAYZ as Single           ' [1105] tangential stiffnes E*A*y*z
        m_NPLC as Single           ' [1101] maximum compressive force
        m_NPLT as Single           ' [1101] maximum tensile force
      END TYPE

const SECT_REC_PLATE = 0
const SECT_REC_RECT = 1
const SECT_REC_TBEAM = 2
const SECT_REC_TTBEAM = 3
const SECT_REC_VPLAT = 4
const SECT_REC_VHREC = 5
const SECT_REC_VBREC = 6
const SECT_REC_VRECT = 7
const SECT_REC_REFPT = 256
const SECT_REC_SCLOC = 8192
const SECT_REC_IBCOFF = 32768
const SECT_REC_RF_CU = 0
const SECT_REC_RF_SYM = 1
const SECT_REC_RF_ASY = 2
const SECT_REC_RF_AST = 3
const SECT_REC_RF_ASB = 4
const SECT_REC_CORNER = 8
const SECT_REC_RF_TRA = 64
const SECT_REC_BUNDLE = 128
const SECT_REC_FIXLAY = 256
      TYPE CSECT_REC               ' 9/NR:10  SectiontypeRectangular T-Beam (SREC)
        m_ID as Long               '        Identification = 10
        m_IQ as Long               '        Identification of section
        m_IR as Long               '        Identification of reinforcement and origin
        m_H as Single              ' [1011] total height
        m_B as Single              ' [1011] width (of web)
        m_SO as Single             ' [1024] Boundary distance of upper reinforcement
        m_SU as Single             ' [1024] Boundary distance of lower reinforcement
        m_ASO as Single            ' [1020] reinforcement up
        m_ASU as Single            ' [1020] reinforcement down
        m_HO as Single             ' [1011] height of plate
        m_BO as Single             ' [1011] width  of plate
        m_DASO as Single           ' [1023] reinf. Diameter up
        m_DASU as Single           ' [1023] reinf. Diameter dn
        m_FKIT as Single           '        <0 = factor for torsional inertia >0 = absolut value of torsion
        m_FKAY as Single           '        <0 = factor for shear deformation area >0 = absolut value of sh
        m_FKAZ as Single           '        <0 = factor for shear deformation area >0 = absolut value of sh
        m_YSMP as Single           ' [1011] explicit location of shear center
        m_ZSSMP as Single          ' [1011] explicit location of shear center
        m_YS as Single             ' [1011] explicit location of reference point
        m_ZS as Single             ' [1011] explicit location of reference point
        m_PHIB as Single           ' [   5] inclination of transverse reinforcements
        m_BEFF as Single           ' [1011] width of equivalent hollow section
        m_ASBM as Single           '        Minimum shear reinf.
        m_A as Single              ' [1011] spacing of reinforcements
        m_AMIN as Single           ' [1011] minimum distance of single reinforcements
        m_AMAX as Single           ' [1011] maximum distance of single reinforcements
        m_SS as Single             ' [1024] Boundary distance of lateral reinforcement
        m_DASS as Single           ' [1023] reinf. Diameter side
        m_HMAX as Single           ' [1011] maximum mesh size for FE/fibre analysis
        m_BETC as Single           '        friction coefficient
        m_MUE as Single            '        friction in joint
      END TYPE

      TYPE CSECT_ANN               ' 9/NR:11  SectiontypeAnnular (SCIT)
        m_ID as Long               '        Identification = 11
        m_IR as Long               '        Identification of section
        m_IR2 as Long              '        Identification of reinforcement
        m_RO as Single             ' [1011] outer radius
        m_RI as Single             ' [1011] inner radius
        m_ROS as Single            ' [1011] outer reinf radius
        m_RIS as Single            ' [1011] inner reinf radius
        m_ASO as Single            ' [1020] outer reinforcement
        m_ASI as Single            ' [1020] inner reinforcement
        m_DASO as Single           ' [1023] reinf. Diameter
        m_AMAX as Single           ' [1011] maximum distance of single reinforcements
        m_ASBM as Single           ' [1021] Minimum shear reinf.
        m_HMAX as Single           ' [1011] maximum mesh size for FE/fibre analysis
        m_FKIT as Single           '        <0 = factor for torsional inertia >0 = absolut value of torsion
        m_FKAY as Single           '        <0 = factor for shear deformation area >0 = absolut value of sh
        m_FKAZ as Single           '        <0 = factor for shear deformation area >0 = absolut value of sh
      END TYPE

      TYPE CSECT_TUB               ' 9/NR:11  SectiontypeTube (TUBE)
        m_ID as Long               '        Identification = 11
        m_IR as Long               '        Identification of section = 2
        m_IR2 as Long              '        property Bit
        m_D as Single              ' [1011] Diameter
        m_T as Single              ' [1011] thickness of tubes
      END TYPE

      TYPE CSECT_CAB               ' 9/NR:11  SectiontypeCable (CABL)
        m_ID as Long               '        Identification = 11
        m_IR as Long               '        Identification of section = 3
        m_IC as Long               '        sectiontype*256 + codeflag*64 + inlet type
        m_D as Single              ' [1011] Diameter
        m_TYP(1 to 2) as Long      '        Literal of type
        m_INL as Long              '        Literal of inlet
        m_NLI as Single            '        no of strands
        m_NDR as Single            '        no of wires
        m_F as Single              '        fill factor
        m_K as Single              '        cable factor
        m_W as Single              '        weight factor
        m_KE as Single             '        loss factor
        m_ZD as Single             ' [1090] design  force
        m_ZB as Single             ' [1090] rupture force
        m_GAM as Single            ' [1188] weight
      END TYPE

      TYPE CSECT_PRO               ' 9/NR:12  SectiontypeShape (PROF)
        m_ID as Long               '        Identification = 12
        m_MNO as Long              '        Materialnumber + 1000*imbedded Materialnumber
        m_IBIT as Long             '        ityp + 64*iref + ivtp
        m_TYP as Long              '        type of section
        m_Z1 as Single             '        nominal first size
        m_Z2 as Single             '        nominal second size
        m_Z3 as Single             '        thickness or weight selector
        m_ALF as Single            ' [   5] rotation angle
        m_IT as Single             ' [1014] tabul.Tors.Inertia
        m_YSC as Single            ' [1011] tabul.shear center
        m_ZSC as Single            ' [1011] tabul.shear center
        m_H as Single              ' [1011] height
        m_B as Single              ' [1011] width
        m_S as Single              ' [1011] thickness of web
        m_T as Single              ' [1011] thickness of flange
        m_R1 as Single             ' [1011] radius
        m_R2 as Single             ' [1011] radius
        m_YOFF as Single           ' [1011] y coord. offset
        m_ZOFF as Single           ' [1011] z coord. offset
        m_CM as Single             ' [1016] tabul.warp.resist.
        m_WMIN as Single           ' [1012] charact. warping 1
        m_WMAX as Single           ' [1012] charact. warping 2
        m_WT as Single             ' [1018] Torsional resist.
        m_AY as Single             ' [1012] Shear area
        m_AZ as Single             ' [1012] Shear area
        m_RID as Long              '        user defined ident
        m_WU1 as Single            ' [1011] bolt position 1
        m_WU2 as Single            ' [1011] bolt position 2
        m_WU3 as Single            ' [1011] bolt position 3
        m_YREF as Single           ' [1011] Coordinates of
        m_ZREF as Single           ' [1011] Reference point
        m_B2 as Single             ' [1011] width lower part
        m_T2 as Single             ' [1011] lower flange thick.
        m_BEZ(1 to 8) as Long      '        character of shape
        m_VYPL as Single           ' [1102] plastic shear force Vy
        m_VZPL as Single           ' [1102] plastic shear force Vz
        m_MTPL as Single           ' [1103] plastic torsional   Mt
        m_MT2PL as Single          ' [1103] plastic torsional   Mt2
        m_MBPL as Single           ' [1103] plastic warpmoment  Mb
      END TYPE

      TYPE CSECT_TBA               ' 9/NR:18  List of construction stages
        m_ID as Long               '        Identification = 18
        m_IBA as Long              '        Headder of construction stages = 0
        m_IBD as Long              '        Number of materials over all construction stages
        m_IBAT(1 to 64) as Long    '        List of external construction stage numbers
      END TYPE

      TYPE CSECT_IBA               ' 9/NR:18  ConstructionStage (CS/BA)
        m_ID as Long               '        Identification = 18
        m_IBA as Long              '        number of construction stage BIRTH
        m_IBD as Long              '        number of construction stage DEATH
        m_TXT(1 to 17) as Long     '        Text
      END TYPE

      TYPE CSECT_TXT               ' 9/NR:19  SectionText
        m_ID as Long               '        Identification = 19
        m_NR as Long               '        external construction stage number for CS separator
        m_IDS as Long              '        Source/Selector flag
        m_TXT(1 to 128) as Long    '        Text
      END TYPE

      TYPE CSECT_WLS               ' 9/NR:6?  SectionWorklaw Serviceability Analysis
        m_ID as Long               '        Identification
        m_N as Long                '        Normal force 0/00
        m_NTYP as Long             '        Type of law
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CSECT_WLU               ' 9/NR:7?  SectionWorklaw Ultimate Analysis
        m_ID as Long               '        Identification
        m_N as Long                '        Normal force 0/00
        m_NTYP as Long             '        Type of law
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CSECT_CW                ' 9/NR:80  Hydrodynamic coefficients (WIND/Wave loading)
        m_ID as Long               '        Identification 80
        m_IREF as Long             '        Reference of coefficients
        m_ALF as Long              '        angle of attack in degrees
        m_CY as Single             '        wind reaction coefficient in y-direction
        m_CZ as Single             '        wind reaction coefficient in z-direction
        m_CT as Single             '        wind reaction coefficient for torsional moment
        m_CHYD as Single           '        hydrodynamic coefficient (Morrison equation)
        m_CLAT as Single           '        lateral wind reaction coefficient
        m_S as Single              '        Strouhal number
        m_AG as Single             '        reserved (must be present to detect old data without chyd)
      END TYPE

      TYPE CSECT_WPA               ' 9/NR:81  SectionWindParameters for Wind loading (WPAR)
        m_ID as Long               '        Identification 81
        m_IBA as Long              '        construction stage number
        m_IBIT as Long             '        bitpattern of explicit limits
        m_KD as Single             ' [1011] equivalent roughness k
        m_ICE as Single            ' [1011] ice cover
        m_TRAF as Single           ' [1011] height of traffic lane
        m_YMIN as Single           ' [1011] wind attack area
        m_ZMIN as Single           ' [1011] wind attack area
        m_YMAX as Single           ' [1011] wind attack area
        m_ZMAX as Single           ' [1011] wind attack area
        m_YREF as Single           ' [1011] wind moment reference
        m_ZREF as Single           ' [1011] wind moment reference
        m_CORN as Single           ' [1011] radius of round edge for rectangular shapes
        m_CWF as Single            '        explicit factor or value of wind coefficient
        m_ALF as Single            ' [   5] rotation for default wind coefficients
      END TYPE

      TYPE CSECT_WDE               ' 9/NR:82  SectionWindDerivativa for Wind loading (WIND)
        m_ID as Long               '        Identification 82
        m_IREF as Long             '        Type of derivativa
        m_ALF as Long              '        angle of attack in degrees (see 009/NR:80)
        m_DER(1 to 20,1 to 5) as Single '        Derivativa vred,value as splines
      END TYPE

      TYPE CSECT_USR               ' 9/NR:90  SectionUserValues (SV/QW)
        m_ID as Long               '        Identification = 90
        m_ITP as Long              '        type of control value set
        m_IVAL as Long             '        value of control flag
        m_RVAL as Single           '        real value of control flag
        m_RVALD as Single          '        place to save the original value which has been
      END TYPE

      TYPE CSECT_MAT               ' 9/NR:91  SectionalMaterial list
        m_ID as Long               '        Identification = 91
        m_MAT(1 to 31) as Long     '        material numbers
      END TYPE

      TYPE CSECT_VAD               ' 9/NR:97  SectionVarDefaults
        m_ID as Long               '        Identification = 97/98
        m_IND1 as Long             '        Lower Index of variable
        m_IND2 as Long             '        Upper Index of variable
        m_IDIM as Long             '        Unit of variable
        m_NAME(1 to 4) as Long     '        Name of variable
        m_RVAL(1 to 1020) as Single'        values of the variable NAME(I1:I2)
      END TYPE

      TYPE CSECT_VAR               ' 9/NR:98  SectionVarValues
        m_ID as Long               '        Identification = 97/98
        m_IND1 as Long             '        Lower Index of variable
        m_IND2 as Long             '        Upper Index of variable
        m_IDIM as Long             '        Unit of variable
        m_NAME(1 to 4) as Long     '        Name of variable
        m_RVAL(1 to 1020) as Single'        values of the variable NAME(I1:I2)
      END TYPE

      TYPE CSECT_REF               ' 9/NR:99  SectionReference
        m_ID as Long               '        Identification 099
        m_IM as Long               '        Type of reference structure definition (see AQUA.ERR)
        m_IRTS as Long             '        Subtype of reference definition for the points:
        m_REF(1 to 200) as Long    '        Identifier of references (0 = not defined)
      END TYPE

      TYPE CSECT_SPT               ' 9/NR:100  SectionStressPoint (SPT/QSP)
        m_ID as Long               '        Identification 100/101
        m_MNO as Long              '        Material number
        m_IDP as Long              '        Number*256 + Bitpattern
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_RT as Single             ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
        m_WTY as Single            ' [1018] Resistance Torsion
        m_WVYY as Single           ' [1017] Resistance y-shear
        m_WVZY as Single           ' [1017] Resistance z-shear
        m_WT2Y as Single           ' [1018] Resistance 2nd Torsion
        m_WTZ as Single            ' [1018] Resistance Torsion
        m_WVYZ as Single           ' [1017] Resistance y-shear
        m_WVZZ as Single           ' [1017] Resistance z-shear
        m_WT2Z as Single           ' [1018] Resistance 2nd Torsion
        m_W0 as Single             ' [1012] unit warping
        m_EPSR as Single           '        non effective strain ratio (0 < epsr <= 1)
        m_EXP as Single            '        exposition class
        m_FIX as Single            ' [1011] location of fix point
        m_SIGD as Single           ' [1092] max. dynamic allowed stress range sig-d(-1)
        m_TAUD as Single           ' [1092] max dynamic allowed stress range tau-d(-1)
        m_LITD as Long             '        literal for notch type
        m_SIGY as Single           ' [1092] stress perpendicular
        m_AREF as Single           ' [1012] weight (effective area) FE-integration points
        m_TEMP as Single           ' [1215] Temperature
        m_TEMP1 as Single          ' [1215] maximum temperature in history (for damage)
      END TYPE

      TYPE CSECT_PPT               ' 9/NR:101  SectionPolygonPoint (POLY/QPOL)
        m_ID as Long               '        Identification 100/101
        m_MNO as Long              '        Material number
        m_IDP as Long              '        Number*256 + Bitpattern
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_RT as Single             ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
        m_WTY as Single            ' [1018] Resistance Torsion
        m_WVYY as Single           ' [1017] Resistance y-shear
        m_WVZY as Single           ' [1017] Resistance z-shear
        m_WT2Y as Single           ' [1018] Resistance 2nd Torsion
        m_WTZ as Single            ' [1018] Resistance Torsion
        m_WVYZ as Single           ' [1017] Resistance y-shear
        m_WVZZ as Single           ' [1017] Resistance z-shear
        m_WT2Z as Single           ' [1018] Resistance 2nd Torsion
        m_W0 as Single             ' [1012] unit warping
        m_EPSR as Single           '        non effective strain ratio (0 < epsr <= 1)
        m_EXP as Single            '        exposition class
        m_FIX as Single            ' [1011] location of fix point
        m_SIGD as Single           ' [1092] max. dynamic allowed stress range sig-d(-1)
        m_TAUD as Single           ' [1092] max dynamic allowed stress range tau-d(-1)
        m_LITD as Long             '        literal for notch type
        m_SIGY as Single           ' [1092] stress perpendicular
        m_AREF as Single           ' [1012] weight (effective area) FE-integration points
        m_TEMP as Single           ' [1215] Temperature
        m_TEMP1 as Single          ' [1215] maximum temperature in history (for damage)
      END TYPE

      TYPE CSECT_CIR               ' 9/NR:102  SectionCircle (CIRC/KREI)
        m_ID as Long               '        Identification 102
        m_MNO as Long              '        Material number
        m_ITP as Long              '        interior construction
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate center
        m_Z as Single              ' [1011] z-ordinate center
        m_R as Single              ' [1011] Radius
        m_RI as Single             ' [1011] Radius hole
        m_UC as Single             ' [1011] air contact length
      END TYPE

      TYPE CSECT_PAN               ' 9/NR:103  SectionPanel (PLAT,WALL)
        m_ID as Long               '        Identification 103/104
        m_MNO as Long              '        Material number
        m_IDP as Long              '        Bit-pattern
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_T as Single              ' [1010] thickness
        m_WA as Single             ' [1012] unit warping start
        m_WE as Single             ' [1012] unit warping end
        m_WT as Single             ' [1018] maximum shear from MT
        m_WVY as Single            ' [1017] maximum shear from Vy
        m_WVZ as Single            ' [1017] maximum shear from Vz
        m_WT2 as Single            ' [1018] maximum shear from MT2
        m_XVY as Single            '        relative Ordinate WVy
        m_XVZ as Single            '        relative Ordinate WVz
        m_XMT2 as Single           '        relative Ordinate Wt2
        m_WTBR as Single           '        Bredt torsional shear
        m_FIXA as Single           ' [1011] location of fix point
        m_FIXB as Single           ' [1011] location of fix point
        m_TEFF as Single           ' [1010] effective thickness
        m_AST as Single            ' [1011] Distance of stiffeners along beam axis
        m_ETA as Single            '        Reduction factor for local buckling
      END TYPE

      TYPE CSECT_WEL               ' 9/NR:104  SectionWeld  (WELD)
        m_ID as Long               '        Identification 103/104
        m_MNO as Long              '        Material number
        m_IDP as Long              '        Bit-pattern
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_T as Single              ' [1010] thickness
        m_WA as Single             ' [1012] unit warping start
        m_WE as Single             ' [1012] unit warping end
        m_WT as Single             ' [1018] maximum shear from MT
        m_WVY as Single            ' [1017] maximum shear from Vy
        m_WVZ as Single            ' [1017] maximum shear from Vz
        m_WT2 as Single            ' [1018] maximum shear from MT2
        m_XVY as Single            '        relative Ordinate WVy
        m_XVZ as Single            '        relative Ordinate WVz
        m_XMT2 as Single           '        relative Ordinate Wt2
        m_WTBR as Single           '        Bredt torsional shear
        m_FIXA as Single           ' [1011] location of fix point
        m_FIXB as Single           ' [1011] location of fix point
        m_TEFF as Single           ' [1010] effective thickness
        m_AST as Single            ' [1011] Distance of stiffeners along beam axis
        m_ETA as Single            '        Reduction factor for local buckling
      END TYPE

      TYPE CSECT_PER               ' 9/NR:110  SectionPeriphery
        m_ID as Long               '        Identification 110
        m_MNO as Long              '        Material number
        m_MN2 as Long              '        2nd material number
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate
        m_ZA as Single             ' [1011] z-ordinate
        m_YE as Single             ' [1011] y-ordinate
        m_ZE as Single             ' [1011] z-ordinate
        m_AIR as Single            '        air contact ratio
      END TYPE

      TYPE CSECT_FEM               ' 9/NR:112  SectionTopology
        m_ID as Long               '        Identification 111
        m_MNO as Long              '        Material number
        m_NREL as Long             '        internal element number
        m_NODE(1 to 4) as Long     '        internal element nodes
      END TYPE

      TYPE CSECT_NER               ' 9/NR:190  SectionNonEffectiveRectangle (NEFF)
        m_ID as Long               '        Identification 190
        m_MNO as Long              '        Material number
        m_IDP as Long              '        Noneffective for (same bits as :101)
        m_TNR as Long              '        Designation
        m_YMIN as Single           ' [1011] y-ordinate
        m_ZMIN as Single           ' [1011] z-ordinate
        m_YMAX as Single           ' [1011] y-ordinate
        m_ZMAX as Single           ' [1011] z-ordinate
        m_T as Single              ' [1011] thickness
        m_SMIN as Single           ' [1092] stress at point (ymin,zmin)
        m_SMAX as Single           ' [1092] stress at point (ymax,zmax)
      END TYPE

      TYPE CSECT_NEP               ' 9/NR:191  Partial non effective polygons
        m_ID as Long               '        Identification 191
        m_MNO as Long              '        Materialnumber
        m_IDP as Long              '        Noneffective for (see :190)
        m_TNR as Long              '        Ident from 190 / Cut identifier for :312 elements
        m_YZ(1 to 511,1 to 2) as Single ' [1011] yz(2,*) = vertices (old format is blocked with 7 points
      END TYPE

      TYPE CSECT_PRF               ' 9/NR:200  SectionPointReinforcement (RF/BEW)
        m_ID as Long               '        Identification 200
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_SIG as Single            ' [1092] prestress
        m_TEMP as Single           ' [1215] Temperature
        m_AS as Single             ' [1020] Reinforcement area
        m_ASMA as Single           ' [1020] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1012] Reference area
        m_A as Single              ' [1011] distance of bars
      END TYPE

      TYPE CSECT_LRF               ' 9/NR:201  SectionLineReinforcement (LRF/LBEW)
        m_ID as Long               '        Identification 201/211/221 or 321
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_R as Single              ' [1011] Radius
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_LRP               ' 9/NR:211  SectionLineReinforcement in Points
        m_ID as Long               '        Identification 201/211/221 or 321
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_R as Single              ' [1011] Radius
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_LSL               ' 9/NR:221  SectionShearLink
        m_ID as Long               '        Identification 201/211/221 or 321
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_R as Single              ' [1011] Radius
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_CRF               ' 9/NR:202  SectionCircularReinforcement (CRF/KBEW)
        m_ID as Long               '        Identification 202/212/222
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate center
        m_Z as Single              ' [1011] z-ordinate center
        m_R as Single              ' [1011] Radius
        m_I_4 as Single
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_CRP               ' 9/NR:212  SectionCircularReinforcement in Points
        m_ID as Long               '        Identification 202/212/222
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate center
        m_Z as Single              ' [1011] z-ordinate center
        m_R as Single              ' [1011] Radius
        m_I_4 as Single
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_CSL               ' 9/NR:222  SectionHelicalShearLink
        m_ID as Long               '        Identification 202/212/222
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate center
        m_Z as Single              ' [1011] z-ordinate center
        m_R as Single              ' [1011] Radius
        m_I_4 as Single
        m_AS as Single             ' [1029] Reinforc. area
        m_ASMA as Single           ' [1029] max Reinforcement area
        m_RNG as Single            '        Layer number
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Diameter
        m_AREF as Single           ' [1019] Reference area = width of element
        m_A as Single              ' [1011] distance of bars
        m_PHIA as Single           ' [   5] start angle for generated points
        m_PHIE as Single           ' [   5] end   angle for generated points
      END TYPE

      TYPE CSECT_URF               ' 9/NR:210  SectionPeriphericReinforcement (CURF,UBEW)
        m_ID as Long               '        Identification 210/220
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_COVER as Single          ' [1024] static cover
        m_EXP(1 to 2) as Long      '        Exposition class
        m_WC as Single             '        weight for centering reinforcement
        m_AS as Single             ' [1021] Reinforc. area/length
        m_ASMA as Single           ' [1021] max Reinforcement area
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Bar Diameter
        m_AREF as Single           ' [1019] Reference area for crack width
        m_A as Single              ' [1011] distance of bars
      END TYPE

      TYPE CSECT_USL               ' 9/NR:220  SectionPeriphericShearLink
        m_ID as Long               '        Identification 210/220
        m_MNO as Long              '        Material number
        m_IR as Long               '        Layer number
        m_TNR as Long              '        Designation
        m_COVER as Single          ' [1024] static cover
        m_EXP(1 to 2) as Long      '        Exposition class
        m_WC as Single             '        weight for centering reinforcement
        m_AS as Single             ' [1021] Reinforc. area/length
        m_ASMA as Single           ' [1021] max Reinforcement area
        m_FT as Single             '        torsional effect
        m_D as Single              ' [1023] Bar Diameter
        m_AREF as Single           ' [1019] Reference area for crack width
        m_A as Single              ' [1011] distance of bars
      END TYPE

      TYPE CSECT_CPT               ' 9/NR:300  SectionCutStressPoint
        m_ID as Long               '        Identification 300
        m_MNO as Long              '        Material of Reinforc. + 1000*Materialnumber
        m_BIT as Long              '        Cut-Index*128 + Bitpattern
        m_TNR as Long              '        Designation
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_B0 as Single             ' [1011] width of cut
        m_WTM as Single            ' [1018] Resistance Torsion
        m_WTR as Single            ' [1018] Resistance max Torsion
        m_WVY as Single            ' [1017] Resistance y-shear
        m_WVZ as Single            ' [1017] Resistance z-shear
        m_FRS as Single            '        Factor for total reinf
        m_W0 as Single             ' [1012] unit warping
        m_SIGY as Single           ' [1092] stress perpendicular
        m_BB as Single             ' [1011] total width of cut
        m_VYFK as Single           '        part of total y-shear
        m_VZFK as Single           '        part of total z-shear
        m_BQFK as Single           '        partial width factor
        m_BYFK as Single           ' [1011] shear design width for Vy
        m_BZFK as Single           ' [1011] shear design width for Vz
      END TYPE

      TYPE CSECT_CUT               ' 9/NR:301  ShearCut (CUT)
        m_ID as Long               '        Identification 301
        m_MNO as Long              '        Material of Reinforc. + 1000*Materialnumber
        m_IDP as Long              '        Bitpattern
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_B0 as Single             ' [1011] effective width
        m_N as Single              ' [1111] Normal force perpend.
        m_M as Single              ' [1114] bending moment perpend
        m_WTM as Single            ' [1018] Resistance Torsion mid
        m_WTD as Single            ' [1018] add tors.resist.edge
        m_VYFK as Single           '        part of total y-shear
        m_VZFK as Single           '        part of total z-shear
        m_BV as Single             ' [1011] total effective width
        m_PHIB as Single           ' [   5] inclination stirups
        m_IRB as Single            '        number of shearlayer
        m_TY as Single             ' [  17] unit shear Sy/Iz
        m_TZ as Single             ' [  17] unit shear Sz/Iy
        m_BRED as Single           ' [1011] reduction for ducts
        m_ASBM as Single           '        Minimum shear reinf.
        m_BETC as Single           '        friction coefficient
        m_MUE as Single            '        friction in joint
        m_ACT as Single            ' [1012] Area of cut off
        m_KSL as Single            '        parameters for plate
        m_SXE as Single            ' [1011] crack spacing for AASTHO
        m_COTT as Single           '        explicit selected inclination for truss model
        m_BMIN as Single           ' [1011] minimum of cut width
        m_BMAX as Single           ' [1011] maximum of cut width
      END TYPE

      TYPE CSECT_CPL               ' 9/NR:311  Partial polygons of shear cut
        m_ID as Long               '        Identification 311
        m_MNO as Long              '        Materialnumber
        m_IDP as Long              '        Cut number (0=continue last one)
        m_TNR as Long              '        Designation of cut
        m_YZ(1 to 511,1 to 2) as Single ' [1011] yz(2,*) = up to seven vertices
      END TYPE

      TYPE CSECT_APL               ' 9/NR:313  Partial polygons of AKT crack area
        m_ID as Long               '        Identification 311
        m_MNO as Long              '        Materialnumber
        m_IDP as Long              '        Cut number (0=continue last one)
        m_TNR as Long              '        Designation of cut
        m_YZ(1 to 511,1 to 2) as Single ' [1011] yz(2,*) = up to seven vertices
      END TYPE

      TYPE CSECT_HYD               ' 9/NR:900  SectionalHydraulics total section
        m_ID as Long               '        Identification = 900/903
        m_I_1 as Long
        m_I_2 as Long
        m_A as Single              ' [1012] Area
        m_UT as Single             ' [1011] total periphery
        m_UP as Single             ' [1011] total wet periphery
        m_R as Single              ' [1011] hydraulic radius
        m_ZET1 as Single           '        loss factor 1
        m_ZET2 as Single           '        loss factor 2
        m_SLK as Single            '        total leakage
        m_YS as Single             ' [1011] y-Ordinate Center
        m_ZS as Single             ' [1011] y-Ordinate Center
      END TYPE

      TYPE CSECT_HYP               ' 9/NR:903  SectionalHydraulics partial section
        m_ID as Long               '        Identification = 900/903
        m_I_1 as Long
        m_I_2 as Long
        m_A as Single              ' [1012] Area
        m_UT as Single             ' [1011] total periphery
        m_UP as Single             ' [1011] total wet periphery
        m_R as Single              ' [1011] hydraulic radius
        m_ZET1 as Single           '        loss factor 1
        m_ZET2 as Single           '        loss factor 2
        m_SLK as Single            '        total leakage
        m_YS as Single             ' [1011] y-Ordinate Center
        m_ZS as Single             ' [1011] y-Ordinate Center
      END TYPE

      TYPE CSECT_HYA               ' 9/NR:904  SectionalHydraulicsAddval
        m_ID as Long               '        identifier 904
        m_I_2 as Long
        m_TYPE as Long             '        type of section
        m_NW as Single             '        Nominal width
        m_YMIN as Single           ' [1011] Minimum Ordinate of section
        m_YMAX as Single           ' [1011] Maximum Ordinate of section
        m_ZMIN as Single           ' [1011] Minimum Ordinate of section
        m_ZMAX as Single           ' [1011] Maximum Ordinate of section
        m_KS as Single             ' [  16] absolute roughness
        m_S as Single              '        storage coefficient
        m_I_8 as Single            '        reserved
        m_I_9 as Single            '        reserved
        m_I_10 as Single           '        reserved
        m_HP as Single             ' [1010] lift of pump
        m_LMIN as Single           '        minimum power
        m_LMAX as Single           '        maximum power
        m_QMAX as Single           '        maximum delivery
      END TYPE

      TYPE CSECT_HYS               ' 9/NR:910  SectionalHydraulicsPolygon
        m_ID as Long               '        Identification 910
        m_MAT as Long              '        identifier 0 (material number)
        m_NR as Long               '        number of side
        m_TNR as Long              '        Designation
        m_YA as Single             ' [1011] y-ordinate start
        m_ZA as Single             ' [1011] z-ordinate start
        m_YE as Single             ' [1011] y-ordinate end
        m_ZE as Single             ' [1011] z-ordinate end
        m_KS as Single             ' [  16] absolute roughness
        m_SLK as Single            '        leakage
      END TYPE

      TYPE CSECT_INS               ' 9/NR:100002  structural database contents
        m_ID as Long               '        Identification of record key
        m_KWH as Long              '        Identification of record key (30/31/32)
        m_KWL as Long              '        Identification of record key (=NR)
        m_IB(1 to 9999) as Long    '        buffer of record contents for record KWH/KWL
      END TYPE

      TYPE CSYST                   ' 10/00  SystemInfo
        m_IPROB as Long            '        Type of System
        m_IACHS as Long            '        Orientation of gravity
        m_NKNOT as Long            '        Number of nodes
        m_MKNOT as Long            '        Highest node number
        m_IGDIV as Long            '        Group divisor
        m_IGRES as Long
        m_BOX(1 to 2,1 to 3) as Single ' [1001] bounding box
        m_TG(1 to 4,1 to 3) as Single '        global CDB-System transformation matrix
        m_TXT(1 to 64) as Long     '        Name of projekt, 127 chars
      END TYPE

      TYPE CSYST_DES               ' 10/1:0  SystemDesignCode
        m_ID as Long               '        identifier = 0
        m_IDC as Long              '        Design code enumeration
        m_COUNTRY as Long          '        Country code for variants
        m_CODE as Long             '        main number or ident of code
        m_YEAR as Long             '        Year of publication
        m_CLASS as Long            '        classification (see master.ini)
        m_TXT(1 to 4) as Long      '        specific Text of Design code (16 characters)
        m_WIND as Long             '        enum of a wind classification (see master.ini)
        m_SNOW as Long             '        enum of a snow-classification (see master.ini)
        m_SEIS as Long             '        enum of a seismic-classification (see master.ini)
        m_GRAVITY as Single        ' [1202] explicit gravity acceleration constant for site
        m_ALTIOBS as Single        ' [1006] obsoleted altitude above sea level
        m_VERS as Single           '        Version number of INI-File (21.0)
        m_LONGITUD as Single       ' [ 205] longitude of location
        m_LATITUDE as Single       ' [ 205] latitude of location
        m_ALTITUDE as Single       ' [1006] altitude above sea level
      END TYPE

      TYPE CSYST_ACT               ' 10/1:1  Predefined Actions from INI-file
        m_ID as Long               '        identifier = 1
        m_ACTION as Long           '        ID of the real action = type of action
        m_TYPE as Long             '        16*Part of action + superposition
        m_GAMU as Single           '        safety factor unfavourable
        m_GAMF as Single           '        safety factor favourable
        m_PSI0 as Single           '        combination value
        m_PSI1 as Single           '        frequent combination value
        m_PSI2 as Single           '        quasi permanent combination value
        m_PS1S as Single           '        non frequent combination value psi1'
        m_GAMA as Single           '        safety factor accidential
        m_CAT as Long              '        sub category of action
        m_TXTREF as Long           '        designation_enum in SOFISTIK.ERR
        m_TXT(1 to 17) as Long     '        explicit designation (in native language)
      END TYPE

      TYPE CSYST_COM_ACT           '        Identifier of action
        m_ID as Long
        m_FAKU as Single
        m_FAKF as Single
      END TYPE

      TYPE CSYST_COM               ' 10/1:2  Possible Combination of actions
        m_ID as Long               '        identifier = 2
        m_LFB as Long              '        loadcase number offset
        m_EXTR as Long             '        Combination rule equation to be used
        m_TYPE as Long             '        type or action of resulting load case
        m_APPLY as Long            '        Is generally used for:
        m_TXT(1 to 8) as Long      '        Name of combination
        m_DUMMY as Single          '        reserved
        m_ACT(1 to 31) as CSYST_COM_ACT '        Identifier of action
      END TYPE

      TYPE CGRP                    ' 11/00  Groups
        m_NG as Long               '        group-number
        m_TYP as Long              '        element code
        m_NUM as Long              '        number of elements of this type
        m_MIN as Long              '        minimum element-number of group
        m_MAX as Long              '        maximum element-number of group
        m_MNR as Long              '        material-number of group
        m_MBW as Long              '        reinforcement material-number of group
        m_INF as Long              '        Bit-code of group
        m_FAKS as Single           '        stiffness factor of group (ASE/TALPA)
        m_FAKA as Single           '        reducing factor of axial bedding for piles
        m_FAKT as Single           '        reducing factor of transverse bedding
        m_VTOT as Single           ' [1093] total volume
        m_MTOT as Single           ' [1093] total mass
        m_RTOT as Single           ' [1030] total reinforcement
        m_ETOT as Single           ' [1093] total energy
        m_ECOM as Single           ' [1093] compression energy
        m_EDEV as Single           ' [1093] shear energy
        m_EKIN as Single           ' [1093] kinetic energy
        m_EPOT as Single           ' [1093] potential energy
        m_EDAM as Single           ' [1093] damping energy
        m_H_GW as Single           ' [1001] Level of Groundwater
        m_DUMMY as Single          '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Group
      END TYPE

      TYPE CGRP_LC                 ' 11/LC  Groups of Loadcase
        m_NG as Long               '        group-number
        m_TYP as Long              '        element code
        m_NUM as Long              '        number of elements of this type
        m_MIN as Long              '        minimum element-number of group
        m_MAX as Long              '        maximum element-number of group
        m_MNR as Long              '        material-number of group
        m_MBW as Long              '        reinforcement material-number of group
        m_INF as Long              '        Bit-code of group
        m_FAKS as Single           '        stiffness factor of group (ASE/TALPA)
        m_FAKA as Single           '        reducing factor of axial bedding for piles
        m_FAKT as Single           '        reducing factor of transverse bedding
        m_VTOT as Single           ' [1093] total volume
        m_MTOT as Single           ' [1093] total mass
        m_RTOT as Single           ' [1030] total reinforcement
        m_ETOT as Single           ' [1093] total energy
        m_ECOM as Single           ' [1093] compression energy
        m_EDEV as Single           ' [1093] shear energy
        m_EKIN as Single           ' [1093] kinetic energy
        m_EPOT as Single           ' [1093] potential energy
        m_EDAM as Single           ' [1093] damping energy
        m_H_GW as Single           ' [1001] Level of Groundwater
        m_DUMMY as Single          '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Group
      END TYPE

const LTYP_IMP = 70
      TYPE CLC_CTRL                ' 12/LC:?  Informations on loadcase LC
        m_KIND as Long             '        type of loadcase
        m_ITYP as Long             '        action type (14/ID)
        m_THEO as Long             '        first order theory
        m_IBA(1 to 2) as Long      '        construction stage number of birth & death
        m_PLC as Long              '        Primary load case for 2nd order analysis
        m_RPAR as Single           '        Timevalue of Load [sec]
        m_PSI0 as Single           '        combin. factor psi0
        m_PSI1 as Single           '        combin. factor psi1
        m_PSI2 as Single           '        combin. factor psi2
        m_FACT as Single           '        loadcase factor
        m_FACX as Single           '        dead load factor X
        m_FACY as Single           '        dead load factor Y
        m_FACZ as Single           '        dead load factor Z
        m_RX as Single             ' [1151] sum of support PX
        m_RY as Single             ' [1151] sum of support PY
        m_RZ as Single             ' [1151] sum of support PZ
        m_CRI1 as Single           '        1st eval. criteria
        m_CRI2 as Single           '        2nd eval. criteria
        m_CRI3 as Single           '        3rd eval. criteria
        m_GAM1 as Single           '        unfavourable factor
        m_GAM2 as Single           '        favourable factor
        m_NAME(1 to 8) as Long     '        Generating source
        m_RTEX(1 to 17) as Long    '        Designation of loadcase
      END TYPE

      TYPE CLC_EVAL                ' 12/LC:011  Evaluation request
        m_ID as Long               '        identifier 11
        m_LREF as Long             '        Referenced load case or construction stage
        m_LTYP as Long             '        type of evaluation request
        m_LEIG as Long             '        load case number of first eigenvalue
        m_NAME(1 to 4) as Long     '        Literal of variable name
        m_VAL(1 to 99) as Single   '        Results of evaluation (array for ietyp 4)
      END TYPE

      TYPE CLC_COPY                ' 12/LC:012  Loads from other loadcases
        m_ID as Long               '        identifier 12 / 13
        m_LREF as Long             '        Referenced load case or action ID [chr]
        m_LSEL as Long             '        selection bits for elements
        m_LITF as Long             '        enum of applied generic factors
        m_ISEL(1 to 4) as Long     '        optional filter for element numbers
        m_NREF(1 to 8) as Long     '        Load train application control (see cdblfta.for)
        m_SREF(1 to 32) as Single  '        Factors and coordinates
        m_SUM(1 to 7) as Single    '        Sum of forces (psup,lsup)
        m_CLIT(1 to 128) as Long   '        Literal of an external database as source
      END TYPE

      TYPE CLC_COPI                ' 12/LC:013  Loads from other loadcases
        m_ID as Long               '        identifier 12 / 13
        m_LREF as Long             '        Referenced load case or action ID [chr]
        m_LSEL as Long             '        selection bits for elements
        m_LITF as Long             '        enum of applied generic factors
        m_ISEL(1 to 4) as Long     '        optional filter for element numbers
        m_NREF(1 to 8) as Long     '        Load train application control (see cdblfta.for)
        m_SREF(1 to 32) as Single  '        Factors and coordinates
        m_SUM(1 to 7) as Single    '        Sum of forces (psup,lsup)
        m_CLIT(1 to 128) as Long   '        Literal of an external database as source
      END TYPE

      TYPE CLC_MBODY               ' 12/LC:2?  Rotation of Body
        m_ID as Long               '        identifier 20/21
        m_NR as Long               '        primary or secondary group number of moving elements
        m_NREF as Long             '        Reference beam number
        m_AX as Single             ' [1003] acceleration local X
        m_AY as Single             ' [1003] acceleration local Y
        m_AZ as Single             ' [1003] acceleration local Z
        m_AXX as Single            ' [1207] rotational acceleration local X-X
        m_AYY as Single            ' [1207] rotational acceleration local Y-Y
        m_AZZ as Single            ' [1207] rotational acceleration local Z-Z
        m_ARX as Single            ' [1207] rotational acceleration local X-X  (= vxx**2)
        m_ARY as Single            ' [1207] rotational acceleration local Y-Y  (= vyy**2)
        m_ARZ as Single            ' [1207] rotational acceleration local Z-Z  (= vzz**2)
        m_EX as Single             ' [1001] global reference point for rotational acceleration
        m_EY as Single             ' [1001] global reference point for rotational acceleration
        m_EZ as Single             ' [1001] global reference point for rotational acceleration
      END TYPE

      TYPE CLC_LRES_LC             '        load case number and factor (dynamic length)
        m_N as Long
        m_F as Single
      END TYPE

      TYPE CLC_LRES                ' 12/LC:89  Explicit factors for selected results
        m_ID as Long               '        identifier 89
        m_KW as Long               '        KW where result has been stored
        m_IPOS as Long             '        Position of Result within record
        m_NREL as Long             '        Element number
        m_XABS as Single           ' [1011] Section location for beams/structural lines
        m_LC(1 to 255) as CLC_LRES_LC '        load case number and factor (dynamic length)
      END TYPE

      TYPE CLC_LPOS                ' 12/LC:90  Position of Load trains
        m_ID as Long               '        identifier 90
        m_CASE as Long             '        number of the case
        m_REF as Long              '        name of the reference lane
        m_SUB as Long              '        subnumber of lane
        m_KW as Long               '        KW where result has been stored
        m_IPOS as Long             '        Position of Result within record
        m_NREL as Long             '        Elementnumber
        m_LFTG as Long             '        LFT*1000+500*ISCONVOY+LFG
        m_XABS as Single           ' [1011] Section location for beams
        m_YEX as Single            ' [1001] Eccentricity of load train
        m_PSC(1 to 2) as Single    '        Maximum load values in load train (PL/BL)
        m_XPOS(1 to 64) as Single  '        Position and distance values
      END TYPE

      TYPE CLC_LPO1                ' 12/LC:91  Individual position of Point load
        m_ID as Long               '        identifier 91
        m_X as Single              ' [1001] Position of individual load
        m_PVAL(1 to 4) as Single   '        Load values in PV,PVM,PX,PY
      END TYPE

      TYPE CLC_LPO2                ' 12/LC:92  Individual position of Block load
        m_ID as Long               '        identifier 92
        m_XA as Single             ' [1001] Position of individual load start
        m_XE as Single             ' [1001] Position of individual load end
        m_PVAL(1 to 4) as Single   '        Load values in PV,PVM,PX,PY
      END TYPE

      TYPE CLC_LPO3                ' 12/LC:93  Individual residual loadings
        m_ID as Long               '        identifier 93
        m_XA as Single             ' [1001] Position of individual load start
        m_XE as Single             ' [1001] Position of individual load end
        m_PVAL(1 to 8) as Single   '        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
      END TYPE

      TYPE CLC_LPOX                ' 12/LC:99  Spandefinitions from ELLA
        m_ID as Long               '        identifier 99
        m_XA as Single             ' [1001] Limits of an active area start
        m_XE as Single             ' [1001] Limits of an active area end
        m_YL as Single             ' [1001] Limits of an active area left
        m_YR as Single             ' [1001] Limits of an active area right
        m_PHI as Single            '        impact factor
        m_V as Single              ' [1203] velocity of load train
      END TYPE

      TYPE CLC_POIN_LPT            '        loadpt
        m_P as Single
        m_X as Single              ' [1001] 
        m_Y as Single              ' [1001] 
        m_Z as Single              ' [1001] 
      END TYPE

      TYPE CLC_POIN                ' 12/LC:10?  Free point loads
        m_KREF as Long             '        Reference type
        m_NREF as Long             '        Reference number
        m_TREF(1 to 3) as Long     '        Reference text    (12 characters)
        m_TYP as Long              '        type of load
        m_TXT(1 to 3) as Long      '        Identifiying Text (12 characters)
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_WIDTH as Single          ' [1001] Tolerance load direction to match elements
        m_LPT(1 to 4) as CLC_POIN_LPT '        loadpt
      END TYPE

      TYPE CLC_LINE_LPT            '        loadpts
        m_P as Single
        m_X as Single              ' [1001] 
        m_Y as Single              ' [1001] 
        m_Z as Single              ' [1001] 
      END TYPE

      TYPE CLC_LINE                ' 12/LC:11?  Free line loads
        m_KREF as Long             '        Reference type
        m_NREF as Long             '        Reference number
        m_TREF(1 to 3) as Long     '        Reference text    (12 characters)
        m_TYP as Long              '        type of load
        m_TXT(1 to 3) as Long      '        Identifiying Text (12 characters)
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_WIDTH as Single          ' [1001] Tolerance load direction to match elements
        m_LPT(1 to 63) as CLC_LINE_LPT '        loadpts
      END TYPE

      TYPE CLC_CURV_LPT            '        loadpts
        m_P as Single
        m_X as Single              ' [1001] 
        m_Y as Single              ' [1001] 
        m_Z as Single              ' [1001] 
      END TYPE

      TYPE CLC_CURV                ' 12/LC:14?  Free spline loads
        m_KREF as Long             '        Reference type
        m_NREF as Long             '        Reference number
        m_TREF(1 to 3) as Long     '        Reference text    (12 characters)
        m_TYP as Long              '        type of load
        m_TXT(1 to 3) as Long      '        Identifiying Text (12 characters)
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_WIDTH as Single          ' [1001] Tolerance load direction to match elements
        m_LPT(1 to 63) as CLC_CURV_LPT '        loadpts
      END TYPE

      TYPE CLC_AREA_LPT            '        loadpts
        m_P as Single
        m_X as Single              ' [1001] 
        m_Y as Single              ' [1001] 
        m_Z as Single              ' [1001] 
      END TYPE

      TYPE CLC_AREA                ' 12/LC:12?  Free area loads
        m_KREF as Long             '        Reference type
        m_NREF as Long             '        Reference number
        m_TREF(1 to 3) as Long     '        Reference text    (12 characters)
        m_TYP as Long              '        type of load
        m_TXT(1 to 3) as Long      '        Identifiying Text (12 characters)
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_WIDTH as Single          ' [1001] Tolerance load direction to match elements
        m_LPT(1 to 63) as CLC_AREA_LPT '        loadpts
      END TYPE

      TYPE CLC_VOLU                ' 12/LC:13?  Free volume loads
        m_KREF as Long             '        Reference type
        m_NREF as Long             '        Reference number
        m_TREF(1 to 3) as Long     '        Reference text    (12 characters)
        m_TYP as Long              '        type of load
        m_TXT(1 to 3) as Long      '        Identifiying Text (12 characters)
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_WIDTH as Single          ' [1001] Factor for silo fillings A/U
        m_P0 as Single             '        load value
        m_X as Single              ' [1001] Reference point for load value P0
        m_Y as Single              ' [1001] 
        m_Z as Single              ' [1001] 
        m_P1 as Single             '        variant load value second reference point
        m_DX1 as Single            ' [1001] Reference point for load value P1
        m_DY1 as Single            ' [1001] 
        m_DZ1 as Single            ' [1001] 
        m_P2 as Single             '        variant load value second reference point
        m_DX2 as Single            ' [1001] Reference point for load value P2
        m_DY2 as Single            ' [1001] 
        m_DZ2 as Single            ' [1001] 
        m_P3 as Single             '        variant load value second reference point
        m_DX3 as Single            ' [1001] Reference point for load value P3
        m_DY3 as Single            ' [1001] 
        m_DZ3 as Single            ' [1001] 
        m_P4 as Single             '        variant load value second reference point
        m_DX4 as Single            ' [1001] Reference point for load value P2
        m_DY4 as Single            ' [1001] 
        m_DZ4 as Single            ' [1001] 
        m_P5 as Single             '        variant load value second reference point
        m_DX5 as Single            ' [1001] Reference point for load value P3
        m_DY5 as Single            ' [1001] 
        m_DZ5 as Single            ' [1001] 
      END TYPE

      TYPE CGLC_GUID               ' 12/LC:199  Unique identifier of loading member
        m_ID as Long               '        identifier 199
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of following element
      END TYPE

      TYPE CLC_TRAI                ' 12/LC:300  Train loading
        m_ID as Long               '        identifier 300
        m_IDEN as Long             '        Type of load train
        m_BPAT as Long             '        Preselected Bitpattern of special options
        m_P1 as Single             '        Char Designation or Class of loading
        m_P2 as Single             '        second entry for load magnitude
        m_P3 as Single             '        third entry for load magnitude
        m_P4 as Single             '        fourth entry for load magnitude
        m_P5 as Single             '        Basic area loading
        m_P6 as Single             '        Wind loading
        m_P7 as Single             '        Height subjected to wind load
        m_P8 as Single             '        Entry for brake loading
        m_P9 as Single             '        Height of the gravity centreline
        m_TOTFAC as Single         '        Factor for the vertical loads of the
        m_PHIB as Single           '        explicit impact factor for bending
        m_PHIBF as Single          '        explicit impact factor favourable bending
        m_PHIS as Single           '        explicit impact factor for shear
        m_PHISF as Single          '        explicit impact factor favourable shear
        m_WIDTH as Single          ' [1001] Width of moving lane to be spared with P5
        m_YEX as Single            ' [1001] reserved: Eccentricity of loading in lane
        m_XCOL as Single           ' [1001] Minimum distance for multiple instances
        m_V as Single              ' [1203] Speed of train
        m_FACF as Single           '        Factor for the masses of the loading
        m_FAVF as Single           '        factor for favorable loading
        m_FRB as Single            '        Frequence of body to bogie spring
        m_DAB as Single            '        Modal damping of body to bogie
        m_PZBO as Single           ' [1001] Fractional load value of bogie (included in PZ)
        m_FRBO as Single           '        Frequence of bogie to wheel spring
        m_DABO as Single           '        Modal damping of bogie to body
        m_PZWH as Single           ' [1001] Fractional load value of wheel (included in PZ)
        m_FRWH as Single           '        Frequence of wheel to surface / bridge deck
        m_DAWH as Single           '        Modal damping of wheel to surface
      END TYPE

      TYPE CLC_TRAL                ' 12/LC:301  Individual loads of Train loading
        m_ID as Long               '        identifier 301
        m_TYPE as Long             '        Type of loading
        m_BPAT as Long             '        contact node for single loads
        m_PZ as Single             '        Vertical loading
        m_YMIN as Single           ' [1001] min eccentricity in y direction
        m_YMAX as Single           ' [1001] max eccentricity in y direction
        m_PX as Single             '        Load value for braking
        m_PW as Single             '        Explicit force for wind attack
        m_ZW as Single             ' [1001] Height for wind force resultant
        m_PV as Single             '        Massvalue for zentrifugal force
        m_ZPV as Single            ' [1001] Height for zentrifugal force resultant
        m_FACFAV as Single         '        Factor for favourable effects
        m_A as Single              ' [1001] Distance to last load
        m_L as Single              ' [1001] Length of loading for block loads (0 = unlimited)
        m_LMAX as Single           ' [1001] Maximum length of block loading if variable
        m_LDEL as Single           ' [1001] Discrete increment of length for block loading
        m_HW as Single             ' [1001] Height of train for wind attack area
        m_WIDTH as Single          ' [1001] Width of train
        m_YEXVAR as Single         '        Variable eccentricity for secondary load trains
        m_WWHEEL as Single         ' [1001] Width of single wheel
        m_LWHEEL as Single         ' [1001] Length of single wheel
        m_DUMMY(1 to 2) as Single  '        reserved
        m_FRB as Single            '        Frequence of body to bogie spring
        m_DAB as Single            '        Modal damping of body to bogie
        m_PZBO as Single           ' [1001] Fractional load value of bogie (included in PZ)
        m_FRBO as Single           '        Frequence of bogie to wheel spring
        m_DABO as Single           '        Modal damping of bogie to body
        m_PZWH as Single           ' [1001] Fractional load value of wheel (included in PZ)
        m_FRWH as Single           '        Frequence of wheel to surface / bridge deck
        m_DAWH as Single           '        Modal damping of wheel to surface
      END TYPE

      TYPE CLC_WIND                ' 12/LC:400  wind loading
        m_ID as Long               '        identifier 400
        m_NORM as Long             '        wind design code
        m_CLAS as Long             '        type of zone and terrain
        m_VATM as Single           ' [1201] atmospheric wind
        m_VREF as Single           ' [1201] mean reference wind
        m_VBOE as Single           ' [1201] gust reference wind
        m_DX as Single             '        components of wind direction
        m_DY as Single
        m_DZ as Single
        m_XREF as Single           ' [1001] Reference point
        m_YREF as Single           ' [1001] 
        m_ZREF as Single           ' [1001] 
        m_DXRE as Single           '        Reference direction
        m_DYRE as Single
        m_DZRE as Single
        m_GH as Single             ' [1001] coordinate of ground level
        m_HMIN as Single           ' [1001] value for constant wind speed below (zmin)
        m_RHO as Single            ' [  59] weight of the air / fluid
        m_LAT as Single            ' [   5] explicit lattitude of site
        m_Z0 as Single             ' [1001] explicit roughness
      END TYPE

      TYPE CLC_WTOP                ' 12/LC:401  Wind environment
        m_ID as Long               '        identifier 401
        m_TYP as Single            '        type of environment height
        m_I_2 as Single            '        reserved
        m_XM as Single             ' [1001] center of elevation in system coordinates
        m_YM as Single             ' [1001] center of elevation in system coordinates
        m_ZM as Single             ' [1001] center of elevation in system coordinates
        m_DX as Single             '        direction of crest of ridge
        m_DY as Single             '        or local x-coordinate of a summit
        m_DZ as Single
        m_H as Single              ' [1001] height above ground defining the slopes
        m_WLEN as Single           ' [1001] width in negative local y direction
        m_BLEN as Single           ' [1001] width in positive local x direction
      END TYPE

      TYPE CLC_WROU_R              '        limits given
        m_D as Single              ' [1001] 
        m_R as Single              ' [1001] 
        m_DH as Single             ' [1001] 
        m_HH as Single             ' [1001] 
      END TYPE

      TYPE CLC_WROU                ' 12/LC:402  Roughness (wind)
        m_ID as Long               '        identifier 402
        m_I_1 as Single            '        reserved
        m_I_2 as Single            '        reserved
        m_DSEA as Single           ' [1001] Distance to the sea
        m_R(1 to 9) as CLC_WROU_R  '        limits given
      END TYPE

      TYPE CLC_WSPE                ' 12/LC:410  wind spectrum
        m_ID as Long               '        identifier 410
        m_TYP as Long              '        type of spectra
        m_CTYP as Long             '        type of coherence model
        m_A1LO as Single           '        1st coefficient longitudinal
        m_A2LO as Single           '        2nd coefficient longitudinal
        m_A3LO as Single           '        3rd coefficient longitudinal
        m_B_LO as Single           '        4th coefficient longitudinal
        m_C_LO as Single           '        5th coefficient longitudinal
        m_D_LO as Single           '        6th coefficient longitudinal
        m_A1LA as Single           '        1st coefficient lateral
        m_A2LA as Single           '        2nd coefficient lateral
        m_A3LA as Single           '        3rd coefficient lateral
        m_B_LA as Single           '        4th coefficient lateral
        m_C_LA as Single           '        5th coefficient lateral
        m_D_LA as Single           '        6th coefficient lateral
        m_A1VE as Single           '        1st coefficient vertical
        m_A2VE as Single           '        2nd coefficient vertical
        m_A3VE as Single           '        3rd coefficient vertical
        m_B_VE as Single           '        4th coefficient vertical
        m_C_VE as Single           '        5th coefficient vertical
        m_D_VE as Single           '        6th coefficient vertical
        m_C3D as Single            '        Longitudinal coefficient
        m_KUU as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KUV as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KUW as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KVU as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KVV as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KVW as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KWU as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KWV as Single            '        HWD factor for ESDU, coefficient otherwise
        m_KWW as Single            '        HWD factor for ESDU, coefficient otherwise
      END TYPE

      TYPE CLC_WTST                ' 12/LC:411  wind coherence test requests
        m_ID as Long               '        identifier 411
        m_TYP as Long              '        type of coherence component
        m_LC as Long               '        load case of an eigenvalue
        m_XREF as Single           ' [1001] Reference point
        m_YREF as Single           ' [1001] 
        m_ZREF as Single           ' [1001] 
        m_RX as Single             ' [1001] Distance or direction of distance
        m_RY as Single             ' [1001] 
        m_RZ as Single             ' [1001] 
        m_CX as Single             '        Davenport/Krenk reference coefficients
        m_CY as Single
        m_CZ as Single
        m_EIG as Single            '        Eigenfrequency (Hertz) for LC>0
        m_U as Single              ' [  96] mean velocity
        m_HWD as Single            ' [1001] real distance for LC==0
        m_XMAX as Single           '        maximum x-value for data
        m_DATA(1 to 64) as Single  '        calculated sqrt of coherence data ( 2 sets)
      END TYPE

      TYPE CLC_WPRC                ' 12/LC:420  wind profile control values
        m_ID as Long               '        identifier 420
        m_ID2 as Long              '        identifier 0
        m_IPRO as Single           '        number of generated profiles
        m_WXMI as Single           ' [1001] size of structure in wind coordinates
        m_WXMA as Single           ' [1001] 
        m_WYMI as Single           ' [1001] 
        m_WYMA as Single           ' [1001] 
        m_WZMI as Single           ' [1001] 
        m_WZMA as Single           ' [1001] 
        m_ALFA as Single           '        some angle ...
        m_BETA as Single           '        some angle ...
        m_GAMM as Single           '        some angle ...
        m_DELT as Single           '        some angle ...
      END TYPE

      TYPE CLC_WPRO                ' 12/LC:420  wind profile distinct values
        m_ID as Long               '        identifier 420
        m_IST as Long              '        source of data
        m_I_2 as Single            '        index reserved
        m_H as Single              ' [1001] height above ground level
        m_V as Single              ' [1201] mean value of wind velocity
        m_VBOE as Single           ' [1201] peak value of wind velocity
        m_TLON as Single           ' [1201] longitudinal turbulence
        m_TLAT as Single           ' [1201] lateral turbulence
        m_TVER as Single           ' [1201] vertical turbulence
        m_LLON as Single           ' [1001] longitudinal wave length
        m_LLAT as Single           ' [1001] lateral wave length
        m_LVER as Single           ' [1001] vertical wave length
        m_PHAS as Single           '        phase
      END TYPE

      TYPE CLC_WAVE                ' 12/LC:500  Wave Loading
        m_ID as Long               '        identifier 500
        m_TYP as Long              '        wave theory bit pattern
        m_NF as Long               '        number of frequencies in spectra
        m_H as Single              ' [1001] wave height / significant wave height
        m_T as Single              ' [  90] period of wave / peak period of wave
        m_D as Single              ' [1001] water depth (0 = infinite)
        m_SWL as Single            ' [1001] sea water reference level
        m_DIR(1 to 3) as Single    '        principal direction of travelling
        m_UC as Single             ' [1201] additional constant current
        m_ALF as Single            '        exponent U(z)=UC*(z/d)**alf
        m_RHO as Single            ' [  59] weight of the fluid
        m_L as Single              ' [1001] calculated wave length
        m_PAR(1 to 15) as Single   '        special parameters for wave spectra
      END TYPE

      TYPE CLC_HIST                ' 13/LC:0  TimeHistoryTitle
        m_ID as Long               '        identifier 0
        m_IDT as Long              '        Unit of time resp x-axis
        m_IDF as Long              '        Unit of function values
        m_NFUN as Long             '        number of functions
        m_NVAL as Long             '        max number of discrete time values
        m_TYPE as Long             '        general type of curve
        m_TITLE(1 to 17) as Long   '        Designation
      END TYPE

      TYPE CLC_DAMP                ' 13/LC:1  Damping values
        m_ID as Long               '        identifier 1
        m_D(1 to 7) as Single      '        modal damping values
      END TYPE

      TYPE CLC_FVAL                ' 13/LC:?0  Discrete function values
        m_ID as Long               '        identifier
        m_TT as Single             '        Time/frequency/modenumber
        m_F(1 to 7) as Single      '        function values
      END TYPE

      TYPE CLC_FMODC               ' 13/LC:9?  Explicit modal coordinates
        m_ID as Long               '        identifier
        m_TT as Single             '        Time/frequency/modenumber
        m_F(1 to 7) as Single      '        function values
      END TYPE

      TYPE CLC_FSIN                ' 13/LC:11  Harmonic function additive
        m_ID as Long               '        identifier
        m_T as Single              ' [  90] Time/frequency
        m_F1 as Single             '        Amplitude value
        m_PHI1 as Single           ' [  90] phase value
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime if > starttime
        m_S as Single              '        impactfactor
        m_F2 as Single             '        Amplitude value for T/2 (Fourier)
        m_PHI2 as Single           ' [  90] phase value for f2
        m_F3 as Single             '        Amplitude value for T/3 (Fourier)
        m_PHI3 as Single           ' [  90] phase value for f3
        m_F4 as Single             '        Amplitude value for T/4 (Fourier)
        m_PHI4 as Single           ' [  90] phase value for f4
      END TYPE

      TYPE CLC_FSINM               ' 13/LC:21  Harmonic function multiplier
        m_ID as Long               '        identifier
        m_T as Single              ' [  90] Time/frequency
        m_F1 as Single             '        Amplitude value
        m_PHI1 as Single           ' [  90] phase value
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime if > starttime
        m_S as Single              '        impactfactor
        m_F2 as Single             '        Amplitude value for T/2 (Fourier)
        m_PHI2 as Single           ' [  90] phase value for f2
        m_F3 as Single             '        Amplitude value for T/3 (Fourier)
        m_PHI3 as Single           ' [  90] phase value for f3
        m_F4 as Single             '        Amplitude value for T/4 (Fourier)
        m_PHI4 as Single           ' [  90] phase value for f4
      END TYPE

      TYPE CLC_FSTP                ' 13/LC:12  Periodic stepping function additive
        m_ID as Long               '        identifier
        m_T as Single              ' [  90] Time/frequency
        m_F as Single              '        Amplitude value
        m_TC as Single             ' [  90] contact time
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime if > starttime
        m_S as Single              '        impactfactor (Sailer/Hüttner/Bachmann)
      END TYPE

      TYPE CLC_FSTPM               ' 13/LC:22  Periodic stepping function multiplier
        m_ID as Long               '        identifier
        m_T as Single              ' [  90] Time/frequency
        m_F as Single              '        Amplitude value
        m_TC as Single             ' [  90] contact time
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime if > starttime
        m_S as Single              '        impactfactor (Sailer/Hüttner/Bachmann)
      END TYPE

      TYPE CLC_FINA                ' 13/LC:13  Aperiodic function additive
        m_ID as Long               '        identifier 13
        m_T as Single              ' [  90] Total Time
        m_F as Single              '        Amplitude value
        m_T1 as Single             ' [  90] Time of constant intensity
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime = tmin+T
        m_TYP as Long              '        Type of function
        m_F2 as Single             '        Amplitude factor
        m_T2 as Single             ' [  90] lead in time duration
        m_F3 as Single             '        Amplitude factor
        m_T3 as Single             ' [  90] lead out time duration
      END TYPE

      TYPE CLC_FINM                ' 13/LC:23  Aperiodic function multiplier
        m_ID as Long               '        identifier 13
        m_T as Single              ' [  90] Total Time
        m_F as Single              '        Amplitude value
        m_T1 as Single             ' [  90] Time of constant intensity
        m_TMIN as Single           ' [  90] starttime
        m_TMAX as Single           ' [  90] stoptime = tmin+T
        m_TYP as Long              '        Type of function
        m_F2 as Single             '        Amplitude factor
        m_T2 as Single             ' [  90] lead in time duration
        m_F3 as Single             '        Amplitude factor
        m_T3 as Single             ' [  90] lead out time duration
      END TYPE

      TYPE CLC_RESW                ' 13/LC:9??  Response spectra wind
        m_TYP as Long              '        Type of spectra 900 - 999
        m_SINT as Single           '        Integral of spectra
        m_A1 as Single             '        Spectrum coefficient
        m_A2 as Single             '        Spectrum coefficient
        m_A3 as Single             '        Spectrum coefficient
        m_B as Single              '        Spectrum coefficient
        m_C as Single              '        Spectrum coefficient
        m_D as Single              '        Spectrum coefficient
        m_RES(1 to 9) as Single    '        reserved
        m_TITLE(1 to 17) as Long   '        Designation of Spectra
      END TYPE

      TYPE CLC_RESP                ' 13/LC:???  Response seismic spectra
        m_TYP as Long              '        Type of spectra 100 - 999
        m_D as Single              '        Damping value eta or behaviour factor q
        m_SA as Single             '        Rigid acceleration factor (Soil Parameter S)
        m_SB as Single             '        Max acceleration factor
        m_SMIN as Single           '        Min acceleration factor (beta)
        m_TB as Single             ' [  90] Time value
        m_TC as Single             ' [  90] Time value
        m_TD as Single             ' [  90] Time value
        m_TE as Single             ' [  90] Cutt-Off Time
        m_K1 as Single             '        Coefficient k1
        m_K2 as Single             '        Coefficient k2
        m_ZONE(1 to 3) as Long     '        Seismic zone
        m_AG as Single             ' [1202] Reference base acceleration
        m_AH as Single             '        Horizontal factor (importance etc.)
        m_AV as Single             '        Vertical factor
        m_TITLE(1 to 17) as Long   '        Designation of Spectra
      END TYPE

      TYPE CLC_FREF                ' 13/LC:????  Discrete reference function values
        m_ID as Long               '        line type
        m_TT as Single             '        Time/frequency
        m_F(1 to 2) as Single      '        function values
      END TYPE

      TYPE CACT_TASK_SCOM          '        index,factor and name of items
        m_IND as Long
        m_FAK as Single
        m_BEZ as Long
      END TYPE

      TYPE CACT_TASK               ' 14/0  Superposition task commands
        m_IVERS as Long            '        < 9999 = old data format (ACT_RULE)
        m_NUM as Long              '        number of superposition command
        m_ACT as Long              '        number of groups of actions at 14/act
        m_LFM(1 to 2) as Long      '        base of load case numbers
        m_KSAV as Long             '        0 = do not save, >0 = save factors as combination KSAV
        m_KWERG as Long            '        Identifier of resultrecord in CDB
        m_FROM as Long             '        smallest  element number
        m_TO as Long               '        highest   element number
        m_INC as Long              '        increment element number
        m_TID as Long              '        optional identifier
        m_X as Single              ' [1001] X-ordinate for beams (see INC!)
        m_COMB as Long             '        combination method for items given at SCOM
        m_SCOM(1 to 9) as CACT_TASK_SCOM '        index,factor and name of items
        m_TXT(1 to 33) as Long     '        Name of superposition
        m_UFORM(1 to 128) as Long  '        User defined target function (index == 0!)
      END TYPE

      TYPE CACT_RULE_SCOM          '        index,factor and name of items
        m_IND as Long
        m_FAK as Single
        m_BEZ as Long
      END TYPE

      TYPE CACT_RULE               ' 14/0  Superposition commands (old Version)
        m_NUM as Long              '        number of superposition command
        m_ACT as Long              '        number of groups of actions at 14/act
        m_LFM(1 to 2) as Long      '        base of load case numbers
        m_KWERG as Long            '        Identifier of resultrecord in CDB
        m_FROM as Long             '        smallest  element number (echo only)
        m_TO as Long               '        highest   element number (echo only)
        m_INC as Long              '        increment element number (echo only)
        m_TID as Long              '        optional identifier
        m_COMB as Long             '        combination method for items given at SCOM
        m_SCOM(1 to 9) as CACT_RULE_SCOM '        index,factor and name of items
        m_TXT(1 to 33) as Long     '        Name of superposition
      END TYPE

      TYPE CLC_ACT0                ' 14/NR:0  Group of Actions for SUPP-task
        m_ID as Long               '        ident = 0  user defined ; < 0 automatic
        m_LFB as Long              '        load case offset
        m_EXTR as Long             '        type of formula for evaluating the extrema
        m_TYPE as Long             '        type or action of resulting load case
        m_TXT(1 to 17) as Long     '        Group designation for collection of actions
      END TYPE

      TYPE CLC_CACT0               ' 12/LC:80  Group of Actions for SUPP-task
        m_ID as Long               '        ident = 0  user defined ; < 0 automatic
        m_LFB as Long              '        load case offset
        m_EXTR as Long             '        type of formula for evaluating the extrema
        m_TYPE as Long             '        type or action of resulting load case
        m_TXT(1 to 17) as Long     '        Group designation for collection of actions
      END TYPE

      TYPE CLC_ACT1                ' 14/NR:1  Action member
        m_ID as Long               '        ident = 1 / 81
        m_ACTION as Long           '        ID of the action = type of action
        m_TYPE as Long             '        256*subgroup + 16*Group_of_action + superposition
        m_GAMU as Single           '        safety factor unfavourable
        m_GAMF as Single           '        safety factor favourable
        m_PSI0 as Single           '        combination value
        m_PSI1 as Single           '        combination value
        m_PSI2 as Single           '        quasi permanent combination value
        m_PS1S as Single           '        non frequent combination value psi1'
        m_GAMA as Single           '        safety factor accidential
        m_CAT as Long              '        category (see 14/ID) not used here
        m_TXT(1 to 17) as Long     '        designation
      END TYPE

      TYPE CLC_CACT1               ' 12/NR:81  current action member
        m_ID as Long               '        ident = 1 / 81
        m_ACTION as Long           '        ID of the action = type of action
        m_TYPE as Long             '        256*subgroup + 16*Group_of_action + superposition
        m_GAMU as Single           '        safety factor unfavourable
        m_GAMF as Single           '        safety factor favourable
        m_PSI0 as Single           '        combination value
        m_PSI1 as Single           '        combination value
        m_PSI2 as Single           '        quasi permanent combination value
        m_PS1S as Single           '        non frequent combination value psi1'
        m_GAMA as Single           '        safety factor accidential
        m_CAT as Long              '        category (see 14/ID) not used here
        m_TXT(1 to 17) as Long     '        designation
      END TYPE

      TYPE CLC_ACT_L               ' 14/NR:2  loadcase of action
        m_ID as Long               '        ident = 2 / 82
        m_LF as Long               '        load case number
        m_TYPE as Long             '        load case action type
        m_FACT as Single           '        factor
      END TYPE

      TYPE CLC_CACT2               ' 12/NR:82  current loadcase of action
        m_ID as Long               '        ident = 2 / 82
        m_LF as Long               '        load case number
        m_TYPE as Long             '        load case action type
        m_FACT as Single           '        factor
      END TYPE

      TYPE CLC_ACT_R               ' 14/NR:1?  Response Spectra
        m_ID as Long               '        Evaluation type of response
        m_RESP as Long             '        load case number of spectra
        m_LFEIG as Long            '        load case of first eigenform
        m_NEIG as Long             '        numbers of eigenforms to be used
      END TYPE

      TYPE CLC_ACT                 ' 14/ID:1  Action defaults
        m_ID as Long               '        ident = 1
        m_ACTION as Long           '        ID of the real action = type of action
        m_TYPE as Long             '        256*subgroup + 16*Group_of_action + superposition
        m_GAMU as Single           '        safety factor unfavourable
        m_GAMF as Single           '        safety factor favourable
        m_PSI0 as Single           '        combination value
        m_PSI1 as Single           '        combination value
        m_PSI2 as Single           '        quasi permanent combination value
        m_PS1S as Single           '        non frequent combination value psi1'
        m_GAMA as Single           '        safety factor accidential
        m_CAT as Long              '        category for preselection of psi-values
        m_TXT(1 to 17) as Long     '        designation
      END TYPE

      TYPE CCSM_GRP                ' 15/-1  Construction Stage Group Definitions
        m_GRP as Long              '        Group number
        m_ICS as Long              '        CS number of first activation
        m_GFIX as Long             '        CS number of hinge fixing
        m_END as Long              '        CS number of last action
        m_FREE(1 to 2) as Long     '        free integer for later use
        m_T0 as Single             ' [  93] minimum age for loading
      END TYPE

      TYPE CCSM_LC                 ' 15/-2  Construction Stage Loadcase Definitions
        m_LC as Long               '        Loadcase
        m_START as Long            '        CS number for first action
        m_END as Long              '        CS number of last action
      END TYPE

      TYPE CCSM_CS                 ' 15/-3  Construction Stage Table
        m_CS as Long               '        Construction Stage
        m_ID as Long               '        Main action type in this CS
        m_CSTEP as Long            '        number of creep+shrink step to be produced
        m_DL_CS as Long            '        dead load activation in composite cross sections
        m_FREE(1 to 2) as Long     '        free integer for later use
        m_DT as Single             ' [  93] duration of creep+shrink step
        m_RH as Single             ' [   8] relative humidity in this creep+shrink step
        m_TEMP as Single           ' [   8] temperture in this creep+shrink step
      END TYPE

      TYPE CCSM_CREE               ' 15/-4  creep+shrink values for manual input
        m_MNO as Long              '        Material number
        m_GRP as Long              '        Group number
        m_PHI as Single            '        total creep factor from first loading til infinite
        m_EPS as Single            '        total shrinkage coefficient
        m_RELAX as Single          '        total tendon relaxation
      END TYPE

      TYPE CCSG_CS                 ' 15/-10  Construction Stage
        m_NO as Long               '        construction stage number
        m_TITL(1 to 32) as Long    '        Designation
        m_DT as Single             ' [  93] duration of construction stage
      END TYPE

      TYPE CCSG_CGRP               ' 15/-11  Group specification
        m_ICS as Long              '        corresponding cs number
        m_NO as Long               '        group number
        m_ACT as Long              '        group action
        m_ACT2 as Long             '        group action cont'd
        m_PTYP as Long             '        type of prestressing
        m_PLQ as Long              '        primary load case swelling
        m_MNO as Long              '        material number
        m_FACS as Single           '        stiffness factor
        m_ALPH as Single           '        alpha factor
        m_HW as Single             ' [  13] ground water level
        m_K as Single              '        earth pressure coefficient
        m_P as Single              '        prestress force
      END TYPE

      TYPE CCSG_CLAS               ' 15/-12  Load specification
        m_ICS as Long              '        corresponding cs number
        m_NO as Long               '        number of referenced loadcase
        m_OPT as Long              '        option of the load
        m_FACT as Single           '        factor for loads
      END TYPE

      TYPE CCSG_CSYS               ' 15/-13  System specification
        m_ICS as Long              '        corresponding cs number
        m_PROB as Long             '        problem type
      END TYPE

      TYPE CCSG_CCRL               ' 15/-14  Computation control
        m_ICS as Long              '        corresponding cs number
        m_OPT as Long              '        control option
        m_SAVE as Long             '        save interval
        m_FACQ as Long             '        not used
        m_VAL as Single            '        value of the option
        m_FMAX as Single           '        2nd value of the option
        m_FMIN as Single           '        3rd value of the option
        m_EMAX as Single           '        4th value of the option
        m_EMIN as Single           '        5th value of the option
        m_V6 as Single             '        6th value of the option
        m_V7 as Single             '        7th value of the option
        m_V8 as Single             '        8th value of the option
      END TYPE

      TYPE CCSG_CGW                ' 15/-15  Change ground water level
        m_ICS as Long              '        corresponding cs number
        m_HW as Single             ' [  13] new ground water level
      END TYPE

      TYPE CCSG_ECHO               ' 15/-16  Echo options
        m_ICS as Long              '        corresponding cs number
        m_OPT as Long              '        echo option
        m_VAL as Long              '        value of the option
      END TYPE

      TYPE CCSM_LC1                ' 15/LC:1  CSM loadcase parameters Group members
        m_ID as Long               '        identifier 1
        m_GRP as Long              '        Group number
        m_T1 as Single             ' [  93] age at the end of loadcase
        m_SUMEPS as Single         '        accumulated shrinkage strain
      END TYPE

      TYPE CCSM_LC2                ' 15/LC:2  CSM loadcase parameters quad-tendon members
        m_ID as Long               '        identifier 2
        m_GRP as Long              '        quad-tendon number
        m_T1 as Single             ' [  93] age at the end of loadcase
        m_SUMRELAX as Single       '        accumulated quad-tendon relaxation
      END TYPE

      TYPE CVIEW                   ' 18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
        m_IACHS as Long            '        downward direction (compare 10/0)
        m_PERS as Long             '        Perspective
        m_LC as Long               '        loadcase
        m_VOPT as Long             '        View Options (Bitcode I)
        m_EOPT as Long             '        Element Options (Bitcode II)
        m_COPT as Long             '        Colour Options (Bitcode III)
        m_DUMMY(1 to 3) as Long    '        reserved
        m_TOPT as Long             '        Exchange option
        m_XBL as Single            ' [1001] X-coordinate of view point
        m_YBL as Single            ' [1001] Y-coordinate of view point
        m_ZBL as Single            ' [1001] Z-coordinate of view point
        m_XCAM as Single           ' [1001] X-coordinate of camera point
        m_YCAM as Single           ' [1001] Y-coordinate of camera point
        m_ZCAM as Single           ' [1001] Z-coordinate of camera point
        m_FAKV as Single           '        Factor of deformed structure
        m_SSIZ as Single           '        Size of supports (0.-100.)
        m_WMAG as Single           '        Warping magnification (0.-100.)
        m_FOVY as Single           ' [   5] perspective angle of field of view
        m_XUP as Single            '        X-part Up Vector
        m_YUP as Single            '        Y-part Up Vector
        m_ZUP as Single            '        Z-part Up Vector
      END TYPE

      TYPE CVIEW_SEL_R             '        Range lower and upper limit
        m_LOW as Long
        m_UPP as Long
      END TYPE

      TYPE CVIEW_SEL               ' 18/-2  currently selected elements in WINGRAF
        m_ID as Long               '        Identifikator
        m_R(1 to 32) as CVIEW_SEL_R'        Range lower and upper limit
      END TYPE

      TYPE CVIEW_SRE               ' 18/-3  currently selected results in WINGRAF
        m_KWH as Long              '        Main key of current item
        m_KWL as Long              '        Secondary key of cuurent item (LF,MAT)
        m_VALUES(1 to 14) as Long  '        Selected values of this record type
      END TYPE

      TYPE CMTXT_0                 ' 18/-4:0  Header for membrane manufacturing
        m_ID as Long               '        identificator = 0
        m_LF as Long               '        used load case of a deformed structure Lastfallnummer einer ver
        m_BITS as Long             '        Bitpattern of conditions of evaluation
        m_NFL as Long              '        Number of manufacturing areas
        m_NQU as Long              '        total number of QUADS within those areas
        m_NNO as Long              '        Number of new nodes inserted
      END TYPE

      TYPE CMTXT_NOD               ' 18/-4:-  Definition of new nodes
        m_NO as Long               '        Number of new interpolated node
        m_QUAD as Long             '        Nummer of QUAD-element containing this node
        m_S as Single              '        S-Koordinate im QUAD-Element
        m_T as Single              '        T-Koordinate im QUAD-Element
      END TYPE

      TYPE CMTXT_ELM               ' 18/-4:+  Definition of manufacturing elements
        m_NO as Long               '        Number of manufacturing area
        m_QUAD as Long             '        Number of QUAD-element
        m_N1 as Long               '        1st node (< 0 if new interpolated node)
        m_N2 as Long               '        2nd node (< 0 if new interpolated node)
        m_N3 as Long               '        3rd node (< 0 if new interpolated node)
        m_N4 as Long               '        4th node (< 0 if new interpolated node)
      END TYPE

      TYPE CVIEW_MCO               ' 18/-5  Colour of material
        m_NO as Long               '        Number of material / group
        m_RED as Single            '        RGBA: red color
        m_GREEN as Single          '        RGBA: green color
        m_BLUE as Single           '        RGBA: blue color
        m_ALPHA as Single          '        RGBA: alpha value
      END TYPE

      TYPE CVIEW_GCO               ' 18/-6  Colour of group
        m_NO as Long               '        Number of material / group
        m_RED as Single            '        RGBA: red color
        m_GREEN as Single          '        RGBA: green color
        m_BLUE as Single           '        RGBA: blue color
        m_ALPHA as Single          '        RGBA: alpha value
      END TYPE

const ANI_SELE_IGRP_ELEM = 0
const ANI_SELE_IGRP_BEAM = 1
const ANI_SELE_IGRP_GRUP = 2
const ANI_SELE_IGRP_SLN = 3
      TYPE CANI_SELE               ' 18/-101:1  Dialogbox Animator selection request
        m_SELE as Long             '        identifier 1 : selection request
        m_IGRP as Long             '        element-group switch
        m_NSEL as Long             '        necessary-possible amount of selected elements
        m_ETYP as Long             '        requested element type - multiple records allowed
        m_FROM as Long             '        select only elements or groups from FROM to TO
        m_TO as Long               '        TO
      END TYPE

      TYPE CANI_CTRL               ' 18/-101:2  Dialogbox Animator drawing controls
        m_SELE as Long             '        identifier 2 : drawing controls
        m_IGRP as Long             '        element-group switch as in record 018/-101
        m_NSEL as Long             '        free
        m_ETYP as Long             '        element type - see 018/-101:1
        m_FROM as Long             '        drawing controls for elements/groups from FROM to TO
        m_TO as Long               '        TO
        m_STYLE as Long            '        representation style guide number
        m_RGBA(1 to 4) as Single   '        colour and transparency factor - only for STYLE=1
      END TYPE

      TYPE CANI_SRES               ' 18/-103  Selection result from Animator
        m_ID101 as Long            '        access ID of 18/-101 to check if selection allready done
        m_IGRP as Long             '        element-group switch as defined in 018/-101
        m_ISEL as Long             '        termination control
        m_ETYP as Long             '        element type - see 018/-101:1
        m_FROM as Long             '        first selected element or group
        m_TO as Long               '        last "
        m_FREE as Long             '        not used
        m_X as Single              ' [1001] sectional abscissa
      END TYPE

      TYPE CLC_SELF                ' 18/LCD  Self weight loading of elements from ASE
        m_KWH as Long              '        Type of load element
        m_NR as Long               '        all other values as in KWH/LC
        m_TYP as Long              '        all other values as in KWH/LC
        m_PVAL(1 to 9999) as Single'        all other values as in KWH/LC
      END TYPE

      TYPE CGRP_BIL                ' 19/LC  Bilances of Flow in HYDRA
        m_ID as Long               '        type of result
        m_NR as Long               '        group number
        m_QINP as Single           '        Quantity of inflow
        m_QOUT as Single           '        Quantity of outflow
        m_QNEW as Single           '        Quantity generated in domain
        m_ENER as Single           '        Energy term
      END TYPE

      TYPE CNODE                   ' 20/00  Nodes
        m_NR as Long               '        node-number
        m_INR as Long              '        internal node-number
        m_KFIX as Long             '        degree of freedoms
        m_NCOD as Long             '        additional bit code
        m_XYZ(1 to 3) as Single    ' [1001] X-Y-Z-ordinates
      END TYPE

      TYPE CNODE_GRC               ' 20/11:0  number of Nodegroups
        m_ID as Long
        m_MAXGRP as Long           '        maximum number of groups per node
      END TYPE

      TYPE CNODE_GRP               ' 20/11:+  Nodegroups
        m_N as Long                '        node-number
        m_IGRP(1 to 9999) as Long  '        group-numbers connecting to node
      END TYPE

      TYPE CNODE_KIC               ' 21/00:0  Info on kinematic constraints
        m_ID as Long
        m_NLEV as Long             '        depth of recurent coupling (obsolete)
        m_NKIN as Long             '        maximum number of coupling equations
        m_NVAR as Long             '        maximum number of coupling factors
      END TYPE

      TYPE CNODE_KIN               ' 21/00:+  Standard kinematic constraint
        m_KTL as Long              '        type + 100 * depth + 10000*group-number
        m_NR as Long               '        node-number
        m_KR(1 to 2) as Long       '        reference nodes
        m_DXYZ(1 to 3) as Single   '        direction of coupling X/Y/Z-axis
        m_DD as Single             '        factor of interpolation for INTP/INTF/INTS
        m_FF as Single             '        factor of multiplication (not used)
      END TYPE

      TYPE CNODE_KIG_ID            '        node+degree-number of dependent (0)
        m_NR as Long
        m_ND as Long
      END TYPE

      TYPE CNODE_KIG               ' 21/00:*99  general constraints (equation list)
        m_KTL as Long
        m_ID(1 to 256) as CNODE_KIG_ID '        node+degree-number of dependent (0)
      END TYPE

      TYPE CNODE_KIF               ' 21/00:*99  general constraints (factor list)
        m_KTL as Long              '        99 + 100 * depth
        m_ID as Long               '        identifier 0
        m_FR(1 to 255) as Single   '        factors of constrained equation
      END TYPE

      TYPE CNODE_KIH               ' 21/09  Hydraulic couplings
        m_NG as Long               '        group-number
        m_NR as Long               '        node-number
        m_KR as Long               '        reference node
      END TYPE

      TYPE CNODE_KFC               ' 22/LC:0  Max. Constraining Forces
        m_ID as Long               '        identifier 0
        m_PX as Single             ' [1190] force component X
        m_PY as Single             ' [1190] force component Y
        m_PZ as Single             ' [1190] force component Z
        m_MX as Single             ' [1194] moment component X
        m_MY as Single             ' [1194] moment component Y
        m_MZ as Single             ' [1194] moment component Z
        m_MB as Single             ' [1194] warping moment
      END TYPE

      TYPE CNODE_KFO               ' 22/LC:+  Constraining forces
        m_NR as Long               '        node-number
        m_PX as Single             ' [1190] force component X
        m_PY as Single             ' [1190] force component Y
        m_PZ as Single             ' [1190] force component Z
        m_MX as Single             ' [1194] moment component X
        m_MY as Single             ' [1194] moment component Y
        m_MZ as Single             ' [1194] moment component Z
        m_MB as Single             ' [1194] warping moment
      END TYPE

      TYPE CNODE_L                 ' 23/LC:+  Nodal_loads
        m_NR as Long               '        node-number
        m_TYP as Long              '        type of load
        m_PX as Single             ' [1190] single force X-component
        m_PY as Single             ' [1190] single force Y-component
        m_PZ as Single             ' [1190] single force Z-component
        m_MX as Single             ' [1194] single moment X-component
        m_MY as Single             ' [1194] single moment Y-component
        m_MZ as Single             ' [1194] single moment Z-component
        m_MB as Single             ' [1195] warping moment
      END TYPE

      TYPE CNODE_LW                ' 23/LC:+  prescribed support displacements
        m_NR as Long               '        node-number
        m_TYP as Long              '        type of load
        m_WX as Single             ' [1003] Displacement X
        m_WY as Single             ' [1003] Displacement Y
        m_WZ as Single             ' [1003] Displacement Z
        m_RX as Single             ' [1004] Rotation X-X
        m_RY as Single             ' [1004] Rotation Y-Y
        m_RZ as Single             ' [1004] Rotation Z-Z
      END TYPE

      TYPE CNODE_ACC               ' 23/LC:*  Base acceleration
        m_NR as Long               '        node number / influence load case
        m_TYP as Long              '        type of load (=10)
        m_AX as Single             ' [1202] transversal acceleration X
        m_AY as Single             ' [1202] transversal acceleration Y
        m_AZ as Single             ' [1202] transversal acceleration Z
        m_AXX as Single            ' [1207] rotational acceleration X-X
        m_AYY as Single            ' [1207] rotational acceleration Y-Y
        m_AZZ as Single            ' [1207] rotational acceleration Z-Z
        m_EX as Single             ' [1001] reference point for rotational acceleration
        m_EY as Single             ' [1001] reference point for rotational acceleration
        m_EZ as Single             ' [1001] reference point for rotational acceleration
        m_EXREF as Single          '        V25: if a value is present (length criteria)
      END TYPE

      TYPE CNODE_LA                ' 23/LC:+  prescribed nodal accelerations
        m_NR as Long               '        node-number
        m_TYP as Long              '        type of load
        m_AX as Single             ' [1003] acceleration X
        m_AY as Single             ' [1003] acceleration Y
        m_AZ as Single             ' [1003] acceleration Z
        m_ARX as Single            ' [1004] Rotation X-X
        m_ARY as Single            ' [1004] Rotation Y-Y
        m_ARZ as Single            ' [1004] Rotation Z-Z
      END TYPE

      TYPE CNODE_ROT               ' 23/LC:+  Rotation of Body
        m_NR as Long               '        influence reference
        m_TYP as Long              '        type of load (=20)
        m_AXX as Single            ' [1207] rotational acceleration X-X  (= vxx**2)
        m_AYY as Single            ' [1207] rotational acceleration Y-Y  (= vyy**2)
        m_AZZ as Single            ' [1207] rotational acceleration Z-Z  (= vzz**2)
        m_EX as Single             ' [1001] reference point for rotational acceleration
        m_EY as Single             ' [1001] reference point for rotational acceleration
        m_EZ as Single             ' [1001] reference point for rotational acceleration
      END TYPE

      TYPE CN_DISPC                ' 24/LC:0  Max. Displacements and support forces
        m_ID as Long
        m_UX as Single             ' [1003] displacement X
        m_UY as Single             ' [1003] displacement Y
        m_UZ as Single             ' [1003] displacement Z
        m_URX as Single            ' [1004] rotation X
        m_URY as Single            ' [1004] rotation Y
        m_URZ as Single            ' [1004] rotation Z
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support X
        m_PY as Single             ' [1151] nodal support Y
        m_PZ as Single             ' [1151] nodal support Z
        m_MX as Single             ' [1152] support moment X
        m_MY as Single             ' [1152] support moment Y
        m_MZ as Single             ' [1152] support moment Z
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_DISPIC               ' 26/LC:0  Max. Displacement and forces increments
        m_ID as Long
        m_UX as Single             ' [1003] displacement X
        m_UY as Single             ' [1003] displacement Y
        m_UZ as Single             ' [1003] displacement Z
        m_URX as Single            ' [1004] rotation X
        m_URY as Single            ' [1004] rotation Y
        m_URZ as Single            ' [1004] rotation Z
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support X
        m_PY as Single             ' [1151] nodal support Y
        m_PZ as Single             ' [1151] nodal support Z
        m_MX as Single             ' [1152] support moment X
        m_MY as Single             ' [1152] support moment Y
        m_MZ as Single             ' [1152] support moment Z
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_DISPTC               ' 27/LC:0  Max. Cooordinate offsets
        m_ID as Long
        m_UX as Single             ' [1003] displacement X
        m_UY as Single             ' [1003] displacement Y
        m_UZ as Single             ' [1003] displacement Z
        m_URX as Single            ' [1004] rotation X
        m_URY as Single            ' [1004] rotation Y
        m_URZ as Single            ' [1004] rotation Z
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support X
        m_PY as Single             ' [1151] nodal support Y
        m_PZ as Single             ' [1151] nodal support Z
        m_MX as Single             ' [1152] support moment X
        m_MY as Single             ' [1152] support moment Y
        m_MZ as Single             ' [1152] support moment Z
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_DISP                 ' 24/LC:+  Displacements and support forces of nodes
        m_NR as Long               '        node-number
        m_UX as Single             ' [1003] displacement
        m_UY as Single             ' [1003] displacement
        m_UZ as Single             ' [1003] displacement
        m_URX as Single            ' [1004] rotation
        m_URY as Single            ' [1004] rotation
        m_URZ as Single            ' [1004] rotation
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support
        m_PY as Single             ' [1151] nodal support
        m_PZ as Single             ' [1151] nodal support
        m_MX as Single             ' [1152] support moment
        m_MY as Single             ' [1152] support moment
        m_MZ as Single             ' [1152] support moment
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_DISPI                ' 26/LC:+  Displacement increments and residual forces
        m_NR as Long               '        node-number
        m_UX as Single             ' [1003] displacement
        m_UY as Single             ' [1003] displacement
        m_UZ as Single             ' [1003] displacement
        m_URX as Single            ' [1004] rotation
        m_URY as Single            ' [1004] rotation
        m_URZ as Single            ' [1004] rotation
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support
        m_PY as Single             ' [1151] nodal support
        m_PZ as Single             ' [1151] nodal support
        m_MX as Single             ' [1152] support moment
        m_MY as Single             ' [1152] support moment
        m_MZ as Single             ' [1152] support moment
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_DISPT                ' 27/LC:+  Cooordinate offsets
        m_NR as Long               '        node-number
        m_UX as Single             ' [1003] displacement
        m_UY as Single             ' [1003] displacement
        m_UZ as Single             ' [1003] displacement
        m_URX as Single            ' [1004] rotation
        m_URY as Single            ' [1004] rotation
        m_URZ as Single            ' [1004] rotation
        m_URB as Single            ' [1005] twisting
        m_PX as Single             ' [1151] nodal support
        m_PY as Single             ' [1151] nodal support
        m_PZ as Single             ' [1151] nodal support
        m_MX as Single             ' [1152] support moment
        m_MY as Single             ' [1152] support moment
        m_MZ as Single             ' [1152] support moment
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CN_VELOC                ' 25/LC:0  Max. velocities and accelerations of nodes
        m_ID as Long
        m_VX as Single             ' [1201] velocity X
        m_VY as Single             ' [1201] velocity Y
        m_VZ as Single             ' [1201] velocity Z
        m_VRX as Single            ' [1206] angular veloc. XX
        m_VRY as Single            ' [1206] angular veloc. YY
        m_VRZ as Single            ' [1206] angular veloc. ZZ
        m_VBB as Single            ' [1208] twisting velocity
        m_AX as Single             ' [1202] acceleration X
        m_AY as Single             ' [1202] acceleration Y
        m_AZ as Single             ' [1202] acceleration Z
        m_ARX as Single            ' [1207] ang. acceler. XX
        m_ARY as Single            ' [1207] ang. acceler. YY
        m_ARZ as Single            ' [1207] ang. acceler. ZZ
        m_ABB as Single            ' [1209] twisting acceler
      END TYPE

      TYPE CN_VELO                 ' 25/LC:+  velocitys and acceleration of nodes
        m_NR as Long               '        node-number
        m_VX as Single             ' [1201] velocity X
        m_VY as Single             ' [1201] velocity Y
        m_VZ as Single             ' [1201] velocity Z
        m_VRX as Single            ' [1206] angular veloc. X-X
        m_VRY as Single            ' [1206] angular veloc. Y-Y
        m_VRZ as Single            ' [1206] angular veloc. Z-Z
        m_VBB as Single            ' [1208] twisting velocity
        m_AX as Single             ' [1202] acceleration X
        m_AY as Single             ' [1202] acceleration Y
        m_AZ as Single             ' [1202] acceleration Z
        m_ARX as Single            ' [1207] ang. acceler. X-X
        m_ARY as Single            ' [1207] ang. acceler. Y-Y
        m_ARZ as Single            ' [1207] ang. acceler. Z-Z
        m_ABB as Single            ' [1209] twisting acceler
      END TYPE

      TYPE CGLN_MATC               ' 31/0  Heritage of Structural lines
        m_NR as Long               '        original structural line number
        m_IDS(1 to 9999) as Long   '        sequence of sub-lines
      END TYPE

      TYPE CGAR_MATC               ' 32/0  Heritage of Structural Areas
        m_NR as Long               '        original structural area number
        m_IDS(1 to 9999) as Long   '        list of sub-areas
      END TYPE

      TYPE CSPT                    ' 39/NR:0  Structural points
        m_ID as Long               '        identifier 0
        m_IDS as Long              '        optional identifier of point
        m_REF as Long              '        reserved reference
        m_NOG as Long              '        reserved number of group
        m_NOM as Long              '        reserved number of material
        m_NOR as Long              '        reserved number of reinforc.
        m_IBT as Long              '        Bitpattern of element properties
        m_IBC as Long              '        Boundary condition
        m_I_8 as Long              '        reserved
        m_I_9 as Long              '        reserved
        m_XYZ(1 to 3) as Single    ' [1001] Coordinates of that point
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_BX as Single             ' [1001] Dimension in local x
        m_BY as Single             ' [1001] Dimension in local y
        m_THICK as Single          ' [1010] Plate thickness at that point
        m_HMESH as Single          ' [1001] Mesh density at point
        m_RES(1 to 3) as Single    '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Point
      END TYPE

      TYPE CSLN                    ' 39/NR:100  Structural lines
        m_ID as Long               '        identifier 100
        m_IDS as Long              '        optional identifier of structural line
        m_REF as Long              '        reference identifier to a given GAX [chr] or sln [int]
        m_SREF as Long             '        secondary axis enum for GAX references
        m_NA as Long               '        optional identifier of line start point
        m_NB as Long               '        optional identifier of line end point
        m_IBT as Long              '        Bitpattern of element properties
        m_IBC as Long              '        primary boundary condition
        m_ID8 as Long              '        reserved
        m_ID9 as Long              '        reserved
        m_HMESH as Single          ' [1001] >0.0 = mesh density along line
        m_TUP(1 to 3) as Single    '        Vector to define downward direction
        m_TROT as Single           '        Fractional rotation about local x-axis  (obsoleted => :101/:102
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis      (obsoleted => :101/:102
        m_PROG as Single           '        progression factor (>0 monoton, <0 symmetric)
        m_R10 as Single            '        reserved
        m_R11 as Single            '        reserved
        m_R12 as Single            '        reserved
        m_R13 as Single            '        reserved
        m_R14 as Single            '        reserved
        m_R15 as Single            '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Line
      END TYPE

const SLN_BEAM_NONE = -1
const SLN_BEAM_CENTRIC = 0
const SLN_BEAM_REFERENCE = 1
const SLN_BEAM_TRUSS = 2
const SLN_BEAM_CABLE = 3
const SLN_BEAM_CCOLUMN = 4
const SLN_BEAM_COLUMN = 5
const SLN_BEAM_SECTION = 7
      TYPE CSLN_BEAM               ' 39/NR:101  Properties of beams
        m_ID as Long               '        ident 101
        m_TYP as Long              '        Element type (see 009/NR:90:4 IBTYP)
        m_NOG as Long              '        group number
        m_NQ(1 to 2) as Long       '        number cross section start/end
        m_NP as Long               '        number bedding props
        m_IBC(1 to 4) as Long      '        Hinge properties A/E/XA/XE (start/end/internal start/end)
        m_DIV as Long              '        type of element subdivision
        m_KR as Single             '        identifier of local coordinate system orientation
        m_R12 as Single
        m_R13 as Single
        m_R14 as Single
        m_R15 as Single
        m_EXA as Single            ' [1001] eccentricity at start
        m_EYA as Single            ' [1001] eccentricity at start
        m_EZA as Single            ' [1001] eccentricity at start
        m_EXE as Single            ' [1001] eccentricity at end
        m_EYE as Single            ' [1001] eccentricity at end
        m_EZE as Single            ' [1001] eccentricity at end
        m_TROT as Single           '        additional rotation about local x-axis, given as fraction of 36
        m_TAL(1 to 3) as Single    '        vector defining the orientation of the local z-axis of the loca
      END TYPE

      TYPE CGLN_BPRO               ' 31/NR:101  Properties of beams
        m_ID as Long               '        ident 101
        m_TYP as Long              '        Element type (see 009/NR:90:4 IBTYP)
        m_NOG as Long              '        group number
        m_NQ(1 to 2) as Long       '        number cross section start/end
        m_NP as Long               '        number bedding props
        m_IBC(1 to 4) as Long      '        Hinge properties A/E/XA/XE (start/end/internal start/end)
        m_DIV as Long              '        type of element subdivision
        m_KR as Single             '        identifier of local coordinate system orientation
        m_R12 as Single
        m_R13 as Single
        m_R14 as Single
        m_R15 as Single
        m_EXA as Single            ' [1001] eccentricity at start
        m_EYA as Single            ' [1001] eccentricity at start
        m_EZA as Single            ' [1001] eccentricity at start
        m_EXE as Single            ' [1001] eccentricity at end
        m_EYE as Single            ' [1001] eccentricity at end
        m_EZE as Single            ' [1001] eccentricity at end
        m_TROT as Single           '        additional rotation about local x-axis, given as fraction of 36
        m_TAL(1 to 3) as Single    '        vector defining the orientation of the local z-axis of the loca
      END TYPE

      TYPE CSLN_SUPP               ' 39/NR:102  Support of Structural lines
        m_ID as Long               '        identifier 102
        m_IDS as Long              '        type of reference
        m_REF as Long              '        reference identifier
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_IBC as Long              '        Boundary condition / kinematic constraints
        m_KR as Long               '        local orientation
        m_W as Single              ' [1001] width of support
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
        m_CM as Single             ' [1099] torsional bedding
        m_DRX as Single            '        explicit X direction of support
        m_DRY as Single            '        explicit Y direction of support
        m_DRZ as Single            '        explicit Z direction of support
        m_D as Single              ' [1001] distance to coupled line (IDS={5,6,7})
        m_R8 as Single
        m_R9 as Single
        m_FKA as Single            '        factor bedding at start
        m_FKE as Single            '        factor bedding at end
        m_TROT as Single           '        Fractional rotation about local x-axis
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis
      END TYPE

      TYPE CGLN_SUPP               ' 31/NR:102  Support of Structural lines
        m_ID as Long               '        identifier 102
        m_IDS as Long              '        type of reference
        m_REF as Long              '        reference identifier
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_IBC as Long              '        Boundary condition / kinematic constraints
        m_KR as Long               '        local orientation
        m_W as Single              ' [1001] width of support
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
        m_CM as Single             ' [1099] torsional bedding
        m_DRX as Single            '        explicit X direction of support
        m_DRY as Single            '        explicit Y direction of support
        m_DRZ as Single            '        explicit Z direction of support
        m_D as Single              ' [1001] distance to coupled line (IDS={5,6,7})
        m_R8 as Single
        m_R9 as Single
        m_FKA as Single            '        factor bedding at start
        m_FKE as Single            '        factor bedding at end
        m_TROT as Single           '        Fractional rotation about local x-axis
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis
      END TYPE

      TYPE CSLN_EXYZ               ' 39/NR:120  Explicit nodes on lines
        m_ID as Long               '        identifier = 120
        m_ID1 as Long              '        reserved
        m_XYZ(1 to 64,1 to 3) as Single ' [1001] XYZ coordinates
      END TYPE

      TYPE CGLN_EXYZ               ' 31/NR:120  Explicit nodes on lines
        m_ID as Long               '        identifier = 120
        m_ID1 as Long              '        reserved
        m_XYZ(1 to 64,1 to 3) as Single ' [1001] XYZ coordinates
      END TYPE

      TYPE CSLN_SCT                ' 39/NR:130  Beams sections
        m_ID as Long               '        identifier = 130
        m_REFT as Long             '        Type of reference
        m_ITYP as Long             '        Bitcodes according 100/NR:0 ITYP
        m_I1 as Long               '        reserved
        m_S as Single              ' [1001] location on geometry
      END TYPE

      TYPE CGLN_SCT                ' 31/NR:130  Beams sections
        m_ID as Long               '        identifier = 130
        m_REFT as Long             '        Type of reference
        m_ITYP as Long             '        Bitcodes according 100/NR:0 ITYP
        m_I1 as Long               '        reserved
        m_S as Single              ' [1001] location on geometry
      END TYPE

      TYPE CSAR                    ' 39/NR:200  Structural area
        m_ID as Long               '        identification of general data = 200
        m_IDS as Long              '        identifier of structural area (0=auto)
        m_REF as Long              '        reference to a given GAR [chr] or SAR [int]
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_NOR as Long              '        number of reinforc.
        m_ITP as Long              '        Bitpattern for element generation QUAD
        m_IBC as Long              '        Boundary condition
        m_KR as Long               '        local orientation QUADs
        m_IATR as Long             '        Bitpattern for attribut areas (see SBOX_PROP)
        m_TD(1 to 5) as Single     ' [1010] Constant thickness
        m_CB as Single             '        bedding factor
        m_CQ as Single             '        tangential bedding factor
        m_TUP(1 to 3) as Single    '        Vector to define upward direction
        m_TROT as Single           '        Fractional rotation about local z-axis
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis
        m_H(1 to 7) as Single      ' [1001] mesh density parameters
        m_TEXT(1 to 17) as Long    '        Designation of surface
      END TYPE

      TYPE CSAR_INF                ' 39/NR:210  GeometricAreaInfo
        m_ID0 as Long              '        identifier 210
        m_NG as Long               '        Type of surface representation
        m_GID1 as Long             '        Axis identifier of first reference axis
        m_GID2 as Long             '        Axis identifier of second reference axis
        m_T(1 to 4,1 to 3) as Single '        Transformation
        m_UV(1 to 2,1 to 2) as Single '        umin,umax,vmin,vmax of the parameter plane
      END TYPE

      TYPE CSAR_PTS                ' 39/NR:211  AreaPointonSurface
        m_ID as Long               '        Identifier 211
        m_IT as Long               '        Type of point (see 5/ID:11 for more)
        m_M as Long                '        Rasterlocation of mesh (0 < m < mgri )
        m_N as Long                '        Rasterlocation of mesh (0 < n < ngri )
        m_W as Single              '        the weight of NURBS control point
        m_X as Single              ' [1001] X-ordinate
        m_Y as Single              ' [1001] Y-ordinate
        m_Z as Single              ' [1001] Z-ordinate
        m_T as Single              ' [1010] Thickness
      END TYPE

      TYPE CSAR_CPI                ' 39/NR:212  COONsPatchInfo
        m_ID as Long               '        Id = 212
        m_IT as Long               '        Type of blending
        m_IU0 as Long              '        No of geometry line for u=umin (left)
        m_IU1 as Long              '        No of geometry line for u=umax (right)
        m_IV0 as Long              '        No of geometry line for v=vmin (lower)
        m_IV1 as Long              '        No of geometry line for v=vmax (upper)
      END TYPE

      TYPE CSAR_EXYZ               ' 39/NR:220  Explicit QUAD nodes on area
        m_ID as Long               '        identifier = 220
        m_ID1 as Long              '        reserved
        m_XYZ(1 to 4,1 to 3) as Single ' [1001] XYZ coordinates
      END TYPE

      TYPE CGAR_EXYZ               ' 32/NR:220  Explicit QUAD nodes on area
        m_ID as Long               '        identifier = 220
        m_ID1 as Long              '        reserved
        m_XYZ(1 to 4,1 to 3) as Single ' [1001] XYZ coordinates
      END TYPE

      TYPE CSAR_SUPP               ' 39/NR:221  Support and coupling of structural areas
        m_ID as Long               '        identifier 221
        m_IDS as Long              '        type of reference
        m_REF as Long              '        reference identifier
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_IBC as Long              '        Boundary condition / kinematic constraints
        m_I6 as Long               '        reserved
        m_RCTL as Long             '        properties of area-area reference
        m_RPTR as Long             '        reference point on boundary of referenced area
        m_RPT0 as Long             '        reference point on boundary of given area
        m_I10 as Long              '        reserved
        m_D as Single              ' [1001] distance of interface layer
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
      END TYPE

      TYPE CGAR_SUPP               ' 32/NR:221  Support and coupling of structural areas
        m_ID as Long               '        identifier 221
        m_IDS as Long              '        type of reference
        m_REF as Long              '        reference identifier
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_IBC as Long              '        Boundary condition / kinematic constraints
        m_I6 as Long               '        reserved
        m_RCTL as Long             '        properties of area-area reference
        m_RPTR as Long             '        reference point on boundary of referenced area
        m_RPT0 as Long             '        reference point on boundary of given area
        m_I10 as Long              '        reserved
        m_D as Single              ' [1001] distance of interface layer
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
      END TYPE

      TYPE CSVO                    ' 39/NR:300  StructuralVolume
        m_ID as Long               '        identification = 300
        m_IDS as Long              '        identifier of structural area (0=auto)
        m_REF as Long              '        reference to a given GVO (reserved)
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_NOR as Long              '        number of reinforc.
        m_NOT as Long              '        number of elementtype
        m_IBC as Long              '        Boundary condition
        m_ID8 as Long              '        reserved
        m_ID9 as Long              '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Volume
      END TYPE

      TYPE CSMB_ATTR               ' 39/NR:997  Attributes of structural member
        m_ID as Long               '        identifier 997
        m_I1 as Long               '        reserved
        m_I2 as Long               '        reserved
        m_GRXA as Long             '        identifier of 1st grid axis x-x
        m_GRYA as Long             '        identifier of 2nd grid axis y-y
        m_ELVB as Long             '        identifier of elevation at bottom
        m_ELVT as Long             '        identifier of elevation at top
        m_DPOS as Long             '        Identifier of design group membership
        m_DTXT(1 to 17) as Long    '        Designation of design group membership
      END TYPE

      TYPE CSPT_ATTR               ' 30/NR:997  Attributes of structural member
        m_ID as Long               '        identifier 997
        m_I1 as Long               '        reserved
        m_I2 as Long               '        reserved
        m_GRXA as Long             '        identifier of 1st grid axis x-x
        m_GRYA as Long             '        identifier of 2nd grid axis y-y
        m_ELVB as Long             '        identifier of elevation at bottom
        m_ELVT as Long             '        identifier of elevation at top
        m_DPOS as Long             '        Identifier of design group membership
        m_DTXT(1 to 17) as Long    '        Designation of design group membership
      END TYPE

      TYPE CSLN_ATTR               ' 31/NR:997  Attributes of structural member
        m_ID as Long               '        identifier 997
        m_I1 as Long               '        reserved
        m_I2 as Long               '        reserved
        m_GRXA as Long             '        identifier of 1st grid axis x-x
        m_GRYA as Long             '        identifier of 2nd grid axis y-y
        m_ELVB as Long             '        identifier of elevation at bottom
        m_ELVT as Long             '        identifier of elevation at top
        m_DPOS as Long             '        Identifier of design group membership
        m_DTXT(1 to 17) as Long    '        Designation of design group membership
      END TYPE

      TYPE CSAR_ATTR               ' 32/NR:997  Attributes of structural member
        m_ID as Long               '        identifier 997
        m_I1 as Long               '        reserved
        m_I2 as Long               '        reserved
        m_GRXA as Long             '        identifier of 1st grid axis x-x
        m_GRYA as Long             '        identifier of 2nd grid axis y-y
        m_ELVB as Long             '        identifier of elevation at bottom
        m_ELVT as Long             '        identifier of elevation at top
        m_DPOS as Long             '        Identifier of design group membership
        m_DTXT(1 to 17) as Long    '        Designation of design group membership
      END TYPE

      TYPE CSMB_GUID               ' 39/NR:999  Unique identifier of structural member
        m_ID as Long               '        identifier 999
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of preceeding element
      END TYPE

      TYPE CSPT_GUID               ' 30/NR:999  Unique identifier of structural member
        m_ID as Long               '        identifier 999
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of preceeding element
      END TYPE

      TYPE CSLN_GUID               ' 31/NR:999  Unique identifier of structural member
        m_ID as Long               '        identifier 999
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of preceeding element
      END TYPE

      TYPE CSAR_GUID               ' 32/NR:999  Unique identifier of structural member
        m_ID as Long               '        identifier 999
        m_IDBIM(1 to 36) as Long   '        256 Bit GUId Identifier of preceeding element
      END TYPE

const GPT_IBC_SUP = 8192
const GPT_IBC_REF = 32768
      TYPE CGPT                    ' 30/NR:0  Structural points
        m_ID as Long               '        identifier 0 (always the first record)
        m_IBC as Long              '        Boundary condition
        m_XYZ(1 to 3) as Single    ' [1001] Ordinates
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_BX as Single             ' [1001] Dimension in x
        m_BY as Single             ' [1001] Dimension in y
        m_THICK as Single          ' [1010] Plate thickness
        m_HMESH as Single          ' [1001] Mesh density at point
        m_R17 as Single            '        reserved
        m_TEXT(1 to 17) as Long    '        Designation of Point
      END TYPE

      TYPE CGPT_COH                ' 30/NR:1  Dimension of column head
        m_ID as Long               '        identifier 1/2/3
        m_NS as Long               '        Number of a cross section 9/NR for details
        m_X as Single              ' [1001] Width in local x
        m_Y as Single              ' [1001] Width in local y
        m_A as Single              ' [1002] Equivalent Area
        m_T as Single              ' [1010] Plate thickness
      END TYPE

      TYPE CGPT_HAU                ' 30/NR:2  Dimension of voute
        m_ID as Long               '        identifier 1/2/3
        m_NS as Long               '        Number of a cross section 9/NR for details
        m_X as Single              ' [1001] Width in local x
        m_Y as Single              ' [1001] Width in local y
        m_A as Single              ' [1002] Equivalent Area
        m_T as Single              ' [1010] Plate thickness
      END TYPE

      TYPE CGPT_PUN                ' 30/NR:3  Dimension of punching perimeter
        m_ID as Long               '        identifier 1/2/3
        m_NS as Long               '        Number of a cross section 9/NR for details
        m_X as Single              ' [1001] Width in local x
        m_Y as Single              ' [1001] Width in local y
        m_A as Single              ' [1002] Equivalent Area
        m_T as Single              ' [1010] Plate thickness
      END TYPE

      TYPE CGPT_COL                ' 30/NR:4  Connecting columns
        m_ID as Long               '        identifier 4
        m_NS as Long               '        Number of a cross section 9/NR for column
        m_X as Single              ' [1001] Width in local x
        m_Y as Single              ' [1001] Width in local y
        m_A as Single              ' [1002] Equivalent Area
        m_L as Single              ' [1001] Column length
        m_FAK as Single            '        Rigidity factor
      END TYPE

      TYPE CGPT_FOO                ' 30/NR:5  Footing instance definition
        m_ID as Long               '        identifier 5
        m_POS as Long              '        referenced building position
        m_TYPE as Long             '        Type of foundation
        m_IGP as Long              '        Bitpattern Foundation Properties
        m_IDR as Long              '        Bitpattern Design Results
        m_IR1 as Long              '        reserved
        m_MNO as Long              '        Id of concrete material
        m_MRF as Long              '        Id of reinforcement material
        m_NRSP as Long             '        Id of soil profile (002/NR)
        m_T(1 to 3,1 to 3) as Single '        Orientation of local coordinate system
        m_BX as Single             ' [1001] Width in local x
        m_BY as Single             ' [1001] Width in local y
        m_HI as Single             ' [1001] inner Thickness
        m_HA as Single             ' [1001] outer Thickness
        m_EX as Single             ' [1001] Eccentricity of column in local x-direction
        m_EY as Single             ' [1001] Eccentricity of column in local y-direction
        m_EZ as Single             ' [1001] Eccentricity of endpoint of column(=structural point) in local 
        m_CLX as Single            ' [1011] Assumed dimension of column in local x-direction
        m_CLY as Single            ' [1011] Assumed dimension of column in local y-direction
        m_SXT as Single            ' [1024] Boundary distance of x-aligned reinforcement on top face
        m_SYT as Single            ' [1024] Boundary distance of y-aligned reinforcement on top face
        m_SXB as Single            ' [1024] Boundary distance of x-aligned reinforcement on bottom face
        m_SYB as Single            ' [1024] Boundary distance of y-aligned reinforcement on bottom face
        m_COVT as Single           ' [1024] Concrete cover (nominal) on top face
        m_COVB as Single           ' [1024] Concrete cover (nominal) on bottom face
        m_COVL as Single           ' [1024] Concrete cover (nominal) on lateral faces
        m_RES1 as Single           '        Reserved
        m_RES2 as Single           '        Reserved
        m_RES3 as Single           '        Reserved
        m_RES4 as Single           '        Reserved
        m_SLHO as Single           ' [1001] obsolete
        m_SLHI as Single           ' [1001] obsolete
        m_SLWX as Single           ' [1001] obsolete
        m_SLWY as Single           ' [1001] obsolete
        m_SLGU as Single           ' [1001] obsolete
        m_SLGL as Single           ' [1001] obsolete
        m_DATA(1 to 12) as Single  '        Reserved
        m_TITL(1 to 17) as Long    '        Designation of Foundation
      END TYPE

      TYPE CGPT_FRR                ' 30/NR:1005  Footing required reinforcement
        m_ID as Long               '        identifier 1005
        m_TYPE as Long             '        Type of reinforcement
        m_N_AS as Long             '        number of values stored in array AS
        m_IR1 as Long              '        reserved
        m_IR2 as Long              '        reserved
        m_XOFF as Single           ' [1001] offset of distribution in x-direction
        m_YOFF as Single           ' [1001] offset of distribution in y-direction
        m_RES1 as Single           '        reserved
        m_RES2 as Single           '        reserved
        m_AS(1 to 32) as Single    ' [1021] reinforcement values
      END TYPE

      TYPE CGPT_SLP                ' 30/NR:1006  Sleeve foundation properties
        m_ID as Long               '        identifier 1006
        m_IR1 as Long              '        reserved
        m_IR2 as Long              '        reserved
        m_IR3 as Long              '        reserved
        m_HSWO as Single           ' [1001] Outer height of sleeve wall (measured from z=0 of local coordin
        m_HSWI as Single           ' [1001] Inner height of sleeve wall (measured from upper face of sleeve
        m_WXWU as Single           ' [1001] Upper width of sleeve wall in x-direction
        m_WYWU as Single           ' [1001] Upper width of sleeve wall in y-direction
        m_WXWL as Single           ' [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
        m_WYWL as Single           ' [1001] Lower width of sleeve wall in y-direction
        m_WXGU as Single           ' [1001] Upper width of gap between wall and column in x-direction
        m_WYGU as Single           ' [1001] Upper width of gap between wall and column in y-direction
        m_WXGL as Single           ' [1001] Lower width of gap between wall and column in x-direction
        m_WYGL as Single           ' [1001] Lower width of gap between wall and column in y-direction
        m_CLX as Single            ' [1011] Assumed dimension of column in local x-direction (deprecated)
        m_CLY as Single            ' [1011] Assumed dimension of column in local y-direction (deprecated)
      END TYPE

      TYPE CGPT_HPI                ' 30/NR:6  Halfspace pile
        m_ID as Long               '        identifier 6
        m_NQ as Long               '        number cross section   =0 if diameter from 030/NR:0
        m_L as Single              ' [1001] pile length in GDIR direction
        m_MANT as Single           '        percentage of skin friction for linear analysis
        m_ZMAN as Single           '        percentage of inactive skin length
        m_PMAN as Single           ' [1151] maximum load skin friction (nonlinear analysis)
        m_PMAF as Single           ' [1151] maximum load pile foot
      END TYPE

      TYPE CGPT_CON_M              '        connected members
        m_NELT as Long
        m_NREL as Long
        m_NODE as Long
        m_NARB as Long
        m_X as Single              ' [1001] 
      END TYPE

      TYPE CGPT_CON                ' 30/NR:8  Steelconnection reference
        m_ID as Long               '        identifier 8
        m_CONID as Long            '        connection identifier
        m_M(1 to 15) as CGPT_CON_M '        connected members
      END TYPE

      TYPE CGPT_SPR                ' 30/NR:10  Elastic Spring support
        m_ID as Long               '        identifier 10
        m_IRI as Long              '        direction
        m_NR as Long               '        element number
        m_NG as Long               '        group number
        m_IPC as Long              '        connecting to node
        m_NWL as Long              '        Reference to work-law / material no
        m_T(1 to 3) as Single      '        explicit direction (dx,dy,dz)
        m_AREF as Single           '        reference / influence area (see also  184 170/0 )
        m_CP as Single             ' [1095] spring stiffness z
        m_CQ as Single             ' [1095] transverse stiff.
        m_CM as Single             ' [1098] torsional stiff.
        m_PRE as Single            '        prestress for cp
        m_GAP as Single            '        slip of spring
        m_RISS as Single           '        max tension force
        m_FLIE as Single           '        yielding load
        m_MUE as Single            '        friction cross
        m_COH as Single            '        cohesion cross
        m_DIL as Single            '        dilatancy factor
        m_GAPQ as Single           '        transverse slip/gap
      END TYPE

      TYPE CGPT_KIN                ' 30/NR:11  Kinematic Constraint
        m_ID as Long               '        identifier 11
        m_KTL as Long              '        type +  10000*group-number
        m_KR1 as Long              '        reference GPT 1
        m_KR2 as Long              '        reference GPT 2
        m_DX as Single             '        direction of coupling X-axis
        m_DY as Single             '        direction of coupling Y-axis
        m_DZ as Single             '        direction of coupling Z-axis
        m_DD as Single             '        factor of interpolation
        m_FF as Single             '        factor of multiplication
      END TYPE

      TYPE CGPT_SPC                ' 30/NR:12  Elastic Spring connection (obsoleted)
        m_ID as Long               '        identifier 12
        m_IRI as Long              '        direction + 100*sign(group number,direction)
        m_IPC as Long              '        connecting Spoint
        m_NWL as Long              '        work law number
        m_CP as Single             ' [1095] spring stiffness z
        m_CQ as Single             ' [1095] transverse stiff.
        m_CM as Single             ' [1098] torsional stiff.
        m_PRE as Single            '        prestress for cp
        m_GAP as Single            '        slip of spring
        m_RISS as Single           '        max tension force
        m_FLIE as Single           '        yielding load
        m_MUE as Single            '        friction cross
        m_COH as Single            '        cohesion cross
        m_DIL as Single            '        dilatancy factor
      END TYPE

      TYPE CGPT_DADS               ' 30/NR:998  List of origin ids the structural member has been created from
        m_ID as Long               '        ident 998
        m_IDD(1 to 63) as Long     '        ids of all anchestors
      END TYPE

      TYPE CGLN                    ' 31/NR:0  Structural lines
        m_ID as Long               '        identifier 0
        m_PT(1 to 2) as Long       '        Number start & end point
        m_I3 as Long               '        reserved
        m_IBT as Long              '        Bitpattern of element properties acc. 39/NR:100 IBT
        m_IBC as Long              '        Boundary condition acc. 39/NR:100 IBC
        m_I_0(1 to 10) as Single   '        reserved
        m_HMESH as Single          ' [1001] mesh density along line acc. 39/NR:100 HMESH
        m_I_11(1 to 3) as Single   '        reserved
        m_PROG as Single           '        progression factor (>0 monoton, <0 symmetric)
        m_I_15 as Single
        m_TEXT(1 to 17) as Long    '        Designation of Line
      END TYPE

      TYPE CGLN_REF                ' 31/NR:-  Reference to another Geometry
        m_IGM as Long              '        negative value of the master geometry
        m_IGS as Long              '        optional identifier of a secondary axis
        m_SMIN as Single           '        min parameter on referenced axis
        m_SMAX as Single           '        max parameter on referenced axis
      END TYPE

const GLN_GEO_DEFAULT = 1
const GLN_GEO_KLOTOID = 2
const GLN_GEO_SPLINE = 3
const GLN_GEO_EXSPLI = 4
const GLN_GEO_BEZIER = 5
const GLN_GEO_NURBS = 6
const GLN_GEO_NURBX = 7
const GLN_GEO_DATA = 8
const GLN_GEO_NORM = 9
const GLN_GEO_CIRC = 10
const GLN_GEO_DWN_POSY = +2
const GLN_GEO_DWN_NEGY = -2
const GLN_GEO_DWN_POSZ = +3
const GLN_GEO_DWN_NEGZ = -3
      TYPE CGLN_GEO                ' 31/NR:??  Geometric properties
        m_ILN as Long              '        Code of geometry
        m_GPG as Single            ' [1001] geometry parameter 1
        m_GPA as Single            ' [1001] geometry parameter 2
        m_DD as Single             ' [1001] arc length
        m_S1 as Single             '        parameter s on start
        m_XYZ1(1 to 3) as Single   ' [1001] Ordinate of start
        m_DXYZ1(1 to 3) as Single  '        Tangent of start
        m_RG1 as Single            ' [1009] in-plane curvature
        m_RA1 as Single            ' [1009] vertical curvature
        m_S2 as Single             '        parameter s on end
        m_XYZ2(1 to 3) as Single   ' [1001] Ordinate of endpoint
        m_DXYZ2(1 to 3) as Single  '        Tangent of endpoint
        m_RG2 as Single            ' [1009] in-plane curvature
        m_RA2 as Single            ' [1009] vertical curvature
      END TYPE

const GLN_BEAM_IBC_LOCAL = 16384
const GLN_BEAM_IBC_NFREE = 32768
      TYPE CGLN_BEAM               ' 31/NR:100  Properties of beams (obsoleted)
        m_ID as Long               '        ident 100
        m_NOG as Long              '        Element type
        m_NQ as Long               '        number cross section
        m_NP as Long               '        number bedding props
        m_IBC as Long              '        Hinge code
        m_DIV as Long              '        prescribed subdivision no of segments
        m_EYA as Single            ' [1001] eccentricity at start
        m_EZA as Single            ' [1001] eccentricity at start
        m_EYE as Single            ' [1001] eccentricity at end
        m_EZE as Single            ' [1001] eccentricity at end
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
        m_CM as Single             ' [1099] torsional bedding
        m_CX as Single             ' [1096] global X  bedding
        m_CY as Single             ' [1096] global Y  bedding
        m_CZ as Single             ' [1096] global Z  bedding
        m_CXX as Single            ' [1099] global X  tors.bed.
        m_CYY as Single            ' [1099] global Y  tors.bed.
        m_CZZ as Single            ' [1099] global Z  tors.bed.
      END TYPE

      TYPE CGLN_ELNR               ' 31/NR:121  Elements generated on lines
        m_ID as Long               '        identifier = 121
        m_ETYP as Long             '        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
        m_IBIT as Long             '        Bit-code
        m_NR(1 to 253) as Long     '        packed list of element numbers
      END TYPE

      TYPE CGLN_DADS               ' 31/NR:998  Ids of items being an anchestor
        m_ID as Long               '        ident 998
        m_IDD(1 to 63) as Long     '        ids of all anchestors
      END TYPE

const GAR_IBC_REF = 32768
      TYPE CGAR                    ' 32/NR:0  Structural area
        m_ID as Long               '        identification of general data (0)
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_NOR as Long              '        number of reinforc.
        m_ITP as Long              '        Bitpattern for element generation QUAD
        m_IBC as Long              '        Boundary condition
        m_TD(1 to 5) as Single     ' [1010] Constant thickness
        m_CB as Single             '        bedding factor
        m_CQ as Single             '        tangential bedding factor
        m_TROT as Single           '        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis
        m_TEXT(1 to 17) as Long    '        Designation of surface
      END TYPE

      TYPE CGAR_REF                ' 32/NR:-  Reference to another Geometry
        m_IGM as Long              '        negative value of the master geometry
      END TYPE

      TYPE CGAR_BOUN               ' 32/NR:1  Outer Boundary of Area
        m_ID as Long               '        identification
        m_NG as Long               '        edgeno     (31/NG)
        m_NA as Long               '        startpoint (30/NA)
        m_NB as Long               '        endpoint   (30/NB)
        m_NM as Long               '        midpoint   (30/NM)
        m_IFC as Long              '        Interface hinge bit pattern
        m_T as Single              ' [1010] Plate thickness of edge
        m_DFIX as Single           ' [1001] Distance (offset) of region to edge
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
        m_CM as Single             ' [1099] torsional bedding
      END TYPE

      TYPE CGAR_HOLE               ' 32/NR:2  Inner Boundary of Area
        m_ID as Long               '        identification
        m_NG as Long               '        edgeno     (31/NG)
        m_NA as Long               '        startpoint (30/NA)
        m_NB as Long               '        endpoint   (30/NB)
        m_NM as Long               '        midpoint   (30/NM)
        m_IFC as Long              '        Interface hinge bit pattern
        m_T as Single              ' [1010] Plate thickness of edge
        m_DFIX as Single           ' [1001] Distance (offset) of region to edge
        m_CA as Single             ' [1096] axial     bedding
        m_CQ as Single             ' [1096] lateral   bedding
        m_CM as Single             ' [1099] torsional bedding
      END TYPE

      TYPE CGAR_CON3               ' 32/NR:3  Prescribed Edges/Points
        m_ID as Long               '        identification
        m_NG as Long               '        edgenumber (31/NG)
        m_NA as Long               '        startpoint (30/NA)
        m_NB as Long               '        endpoint   (30/NB)
        m_NM as Long               '        midpoint   (30/NM)
        m_MAT as Long              '        Materialnumber of subregion for ID==4
        m_T as Single              ' [1010] Plate thickness at edge or point
      END TYPE

      TYPE CGAR_CON4               ' 32/NR:4  Domain-Subdivision-Edges
        m_ID as Long               '        identification
        m_NG as Long               '        edgenumber (31/NG)
        m_NA as Long               '        startpoint (30/NA)
        m_NB as Long               '        endpoint   (30/NB)
        m_NM as Long               '        midpoint   (30/NM)
        m_MAT as Long              '        Materialnumber of subregion for ID==4
        m_T as Single              ' [1010] Plate thickness at edge or point
      END TYPE

      TYPE CGAR_MESH               ' 32/NR:9  Prescribed Mesh size
        m_ID as Long               '        identification
        m_NG as Long               '        number of support macro generating mesh
        m_NA as Long               '        startedge  (31/NA)
        m_NB as Long               '        endedge    (31/NB)
        m_I4 as Long               '        not used
        m_I5 as Long               '        not used
        m_HSIZE(1 to 3) as Single  ' [1001] requested mesh size
        m_PTA(1 to 3) as Single    ' [1001] Coordinates of startpoint
        m_PTE(1 to 3) as Single    ' [1001] Coordinates of endpoint
        m_PTM(1 to 3) as Single    ' [1001] Coordinates of midpoint
      END TYPE

      TYPE CGAR_GEO                ' 32/NR:10  Geometry of surface
        m_ID as Long               '        Identification of surface description 10
        m_NG as Long               '        Type of surface representation
        m_MGRI as Long             '        number of data/control points in s of mesh
        m_NGRI as Long             '        number of data/control points in t of mesh
        m_MSPL as Long             '        degree of B-spline in s direction
        m_NSPL as Long             '        degree of B-spline in t direction
        m_SX as Single             '        plane  direction sx
        m_SY as Single             '        plane  direction sy
        m_SZ as Single             '        plane  direction sz
        m_TX as Single             '        plane  direction tx
        m_TY as Single             '        plane  direction ty
        m_TZ as Single             '        plane  direction tz
        m_NX as Single             '        normal direction nx
        m_NY as Single             '        normal direction ny
        m_NZ as Single             '        normal direction nz
        m_X as Single              ' [1001] X-ordinate Origin
        m_Y as Single              ' [1001] Y-ordinate Origin
        m_Z as Single              ' [1001] Z-ordinate Origin
        m_PAR(1 to 16) as Single   '        additional Parameters
        m_BOX(1 to 3,1 to 2) as Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        m_XPAR(1 to 9999) as Single'        extended parameters
      END TYPE

      TYPE CGAR_SURF               ' 32/NR:11  UserPointonSurface
        m_ID as Long               '        Identification of user surface description 11
        m_IT as Long               '        Type of point
        m_M as Long                '        Rasterlocation of mesh 0 < m ( mgri )
        m_N as Long                '        Rasterlocation of mesh 0 < n ( ngri )
        m_N3 as Long               '        the degree of the Spline becoming effective
        m_N4 as Long               '        the weight of NURBS control point [-]
        m_X as Single              ' [1001] X-ordinate
        m_Y as Single              ' [1001] Y-ordinate
        m_Z as Single              ' [1001] Z-ordinate
        m_T as Single              ' [1010] Thickness
      END TYPE

      TYPE CGAR_COON               ' 32/NR:12  COONsPatchInfo
        m_ID as Long               '        Identification of COONs blending edges 12
        m_IT as Long               '        Type of blending
        m_IU0 as Long              '        No of geometry line for u=umin (left)
        m_IU1 as Long              '        No of geometry line for u=umax (right)
        m_IV0 as Long              '        No of geometry line for v=vmin (lower)
        m_IV1 as Long              '        No of geometry line for v=vmax (upper)
        m_SP(1 to 4,1 to 3) as Single '        Length parameters for the edges iu0,iu1,iv0,iv1
        m_UV(1 to 2,1 to 2) as Single '        umin,umax,vmin,vmax of the parameter plane
        m_CXYZ(1 to 4,1 to 3) as Single '        Coordinates of the corner points C1,C2,C3,C4
        m_TINC(1 to 8,1 to 3) as Single '        inclinations for a bicubic patch as vectors
        m_TWIST(1 to 4,1 to 3) as Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END TYPE

      TYPE CGAR_ELNR               ' 32/NR:221  Generated elements from area
        m_ID as Long               '        identifier = 221
        m_ETYP as Long             '        Type of element {200,...} for {QUAD,...}
        m_ID2 as Long              '        reserved
        m_NR(1 to 253) as Long     '        packed list of element numbers
      END TYPE

      TYPE CGAR_DADS               ' 32/NR:998  Ids of items being an anchestor
        m_ID as Long               '        ident 998
        m_IDD(1 to 63) as Long     '        ids of all anchestors
      END TYPE

      TYPE CGVO                    ' 33/NR:0  StructuralVolume
        m_ID as Long               '        identification of general data (0)
        m_NOG as Long              '        number of group
        m_NOM as Long              '        number of material
        m_NOR as Long              '        number of reinforc.
        m_NOT as Long              '        number of elementtype
        m_IBC as Long              '        Boundary condition
        m_TEXT(1 to 17) as Long    '        Designation of Volume
      END TYPE

      TYPE CGVO_SURF               ' 33/NR:+  Involved Surfaces
        m_ITP as Long              '        identification of definition
        m_NG as Long               '        surface    (32/NG)
        m_NR as Long               '        extrusion or rotation geometry identifier
        m_NREF as Long             '        optional number of a reference point
        m_NARA as Long             '        region identifier for start surface
        m_NARE as Long             '        region identifier for end surface
        m_T as Single              ' [1010] Thickness of interface layer
        m_FAC as Single            '        Scale factor for extrusion
        m_FAC0 as Single           '        Scale factor for start segment
        m_PHI as Single            ' [   5] end rotation angle for extrusion/rotation
        m_PHI0 as Single           ' [   5] start rotation angle for rotation
        m_DPHI as Single           ' [   5] allowable sector angle for rotation
        m_DX as Single             ' [1001] explicit extrusion / rotational axis
        m_DY as Single             ' [1001] explicit extrusion / rotational axis
        m_DZ as Single             ' [1001] explicit extrusion / rotational axis
        m_XREF as Single           ' [1001] explicit reference point
        m_YREF as Single           ' [1001] explicit reference point
        m_ZREF as Single           ' [1001] explicit reference point
        m_TFAC(1 to 3) as Single   ' [1010] Factor for thickness extrusion START/END/REF
      END TYPE

      TYPE CSLVL_DEF               ' 34/NR:0  Structural Storey Level Definition
        m_ID0 as Long              '        identification of definition data (0)
        m_SPTM as Long             '        ID of SPT to be generated at center of mass
        m_SPTR as Long             '        ID of SPT to be generated at center of rigidity
        m_IBIT_STC as Long         '        stiffness calculation bit pattern
        m_IBIT_CPC as Long         '        capacity calculation bit pattern
        m_IBC as Long              '        reserved
        m_ZLEV as Single           ' [1006] Storey level, upwards positive (reference)
        m_DZUPW as Single          ' [1001] Vertical extension upwards (search box) OK
        m_DZDWN as Single          ' [1001] Vertical extension downwards (search box) UK
        m_XMIN as Single           ' [1001] Lateral extension (search box)
        m_XMAX as Single           ' [1001] Lateral extension (search box)
        m_YMIN as Single           ' [1001] Lateral extension (search box)
        m_YMAX as Single           ' [1001] Lateral extension (search box)
        m_TEXT(1 to 17) as Long    '        Designation of level
      END TYPE

      TYPE CDSLN_DEF               ' 35/ID:0  Design Element Definition
        m_ID0 as Long              '        identification of definition data (0)
        m_DSLN as Long             '        number of design element
        m_FREF as Long             '        reference of forces
        m_NCS as Long              '        number of cross section
        m_DSEL as Long             '        type of quad selection
        m_NIDS as Long             '        count of geometry identifiers
        m_HDIV as Single           ' [1001] interval of sub-division sections
      END TYPE

      TYPE CDGEO_DEF               ' 35/ID:1  Design Element Geometry
        m_ID as Long               '        identification of data (2)
        m_TYPE as Long             '        type of geometric definition
        m_IDS(1 to 100) as Long    '        ids of structural lines or beams
        m_XYZA(1 to 3) as Single   ' [1001] geometry of a straight line
        m_XYZE(1 to 3) as Single   ' [1001] geometry of a straight line
        m_DZ(1 to 3) as Single     ' [1001] direction z-axis of straight line
      END TYPE

      TYPE CDSLC_DEF               ' 35/ID:2  Design Sections
        m_ID as Long               '        identification of data (1)
        m_TYPE as Long             '        type of sectioning
        m_ITYP as Long             '        type of section
        m_POS as Single            ' [1001] position of sections
      END TYPE

      TYPE CSGRP                   ' 37/ID:0  Secondary groups
        m_ID0 as Long              '        identification of general data (0)
        m_TYP as Long              '        Bit infos of selected element types
        m_BIT as Long              '        Bit infos on selections contained in that group
        m_TEXT(1 to 17) as Long    '        Designation of sgrp
      END TYPE

      TYPE CSGRP_BOX               ' 37/ID:1  Selective Basic-Volume
        m_ID as Long               '        identification of data (1)
        m_TYP as Long              '        type of property volume
        m_BIT as Long              '        option
        m_PAR(1 to 7,1 to 3) as Single ' [1001] PARAMETERS OF BOX par(3,0:6)
      END TYPE

      TYPE CSGRP_POL               ' 37/ID:2  Selective Polyeder-Volume
        m_ID as Long               '        identification of data (2)
        m_TYP as Long              '        number of vertices
        m_BIT as Long              '        option
        m_T(1 to 4,1 to 3) as Single '        transformation matrix to local coordinates
        m_EXT(1 to 3,1 to 3) as Single ' [1001] global extension, local extensions min/max
        m_VERT(1 to 63,1 to 3) as Single ' [1001] vertices in local coordinates r,s,t
      END TYPE

      TYPE CSGRP_LIS               ' 37/ID:0???  Calculated Selective Element List
        m_ID as Long               '        identifier of element to be selected (positive)
        m_NR(1 to 255) as Long     '        element numbers
      END TYPE

      TYPE CSGRP_ADD               ' 37/ID:1???  Selecting Element List
        m_ID as Long               '        identifier of element to be selected (positive)
        m_NR(1 to 255) as Long     '        element numbers
      END TYPE

      TYPE CSGRP_SUB               ' 37/ID:2???  Excluding Element List
        m_ID as Long               '        identifier of element to be selected (positive)
        m_NR(1 to 255) as Long     '        element numbers
      END TYPE

      TYPE CSGRP_SEL               ' 37/ID:3???  Property-Values
        m_ID as Long               '        identifier of element to be modified
        m_TYPE as Long             '        Option to perform
        m_BIT as Long              '        bit pattern of selected data
        m_ITP as Long              '        key value for orientation of coordinate system
        m_DIV as Long              '        key value of subdivision or other extended data
        m_IDQ as Long              '        key value of cross section or other extended data
        m_IDH as Long              '        key value of hinge conditions or other extended data
        m_IDX as Long              '        key value of other extended data
        m_TROT as Single           '        Fractional rotation about
        m_TAL(1 to 3) as Single    '        Vector to be aligned as local axis
        m_RDAT(1 to 4) as Single   '        reserved for values not in DATA
        m_DATA(1 to 64) as Long    '        equivalenced data structure of that
      END TYPE

      TYPE CGLAR_0                 ' 38/NR:0  Load distribution areas Header
        m_ID as Long               '        Identification 0
        m_NGAR as Long             '        number of an 32/NGAR area definition
        m_NGRP(1 to 4) as Long     '        group of area and three active groups
        m_MGRI as Long             '        prescribed grid subdivision (NGAR=0)
        m_NGRI as Long             '        prescribed grid subdivision (NGAR=0)
        m_ID32 as Long             '        access ID of 32/0 to check valid data
        m_ID20 as Long             '        access ID of 20/0 to check valid data
        m_NNOD as Long             '        number of nodes            38/NR:1
        m_NQUA as Long             '        number of quadrilaterals   38/NR:2
        m_NSEG as Long             '        number of beam sections    38/NR:3
        m_DUMMY(1 to 2) as Long    '        reserved
        m_SGRP as Long             '        optional secondary group selector id
        m_T as Single              ' [1010] thickness of load area used to catch beams
        m_XYZ(1 to 4,1 to 3) as Single ' [1001] ! 4 corner points of area (optional)
      END TYPE

      TYPE CGLAR_NOD               ' 38/NR:1  Node of load distribution area
        m_ID as Long               '        Identification 1 (instead of NR)
        m_INR as Long              '        nodenumber within the region
        m_NFIX as Long             '        not used
        m_NCOD as Long             '        not used
        m_XYZ(1 to 3) as Single    ' [1001] coordinates
        m_DXYZ(1 to 3) as Single   ' [1001] displacements for uniform load -> animator
      END TYPE

      TYPE CGLAR_QUA               ' 38/NR:2  QUAD of load distribution area
        m_ID as Long               '        Identification 2 (instead of NR)
        m_NODE(1 to 4) as Long     '        nodenumbers of the quad within region
        m_MAT as Long              '        not used
        m_MRF as Long              '        not used
        m_NRA as Long              '        type of element
        m_DET(1 to 3) as Single    '        Parameter of Jacobi Determinant
        m_THICK(1 to 5) as Single  ' [1010] element thickness
        m_CB as Single             '        not used
        m_CQ as Single             '        not used
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
      END TYPE

      TYPE CGLAR_SEG               ' 38/NR:3  BEAM segments within area
        m_ID as Long               '        Identification 3
        m_NR as Long               '        number of loaded beam element
        m_X as Single              ' [1001] start point
        m_L as Single              ' [1001] length of segment
      END TYPE

      TYPE CGLAR_P                 ' 38/NR:1?  Load distribution areas  Pointloads
        m_ID as Long               '        Identification 10:13
        m_INR as Long              '        nodenumber of 038/NR:1 within region
        m_NODE as Long             '        nodenumber of a global node
        m_P(1 to 4) as Single      '        value of load
      END TYPE

      TYPE CGLAR_L                 ' 38/NR:10?  Load distribution areas  Beamloads
        m_ID as Long               '        Identification 100:103
        m_INR as Long              '        nodenumber of 038/NR:1 within region
        m_NSEG as Long             '        number of 038/NR:3 segment
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
        m_MA as Single             '        start value of torque
        m_ME as Single             '        end value of torque
      END TYPE

      TYPE CTENDAXIS               ' 40/NR:0  Tendon lanes/reference axis data
        m_ID0 as Long              '        identifier 0
        m_IGSYS as Long            '        prestress for:
        m_IGINFO as Long           '        Systeminfo
        m_IGREF as Long            '        reference to geometry
        m_ICBIT as Long            '        bit for analysis type
        m_IDS as Long              '        Enum of secondary axis (1='A' to 26 ='Z')
        m_TEXT(1 to 17) as Long    '        Designation
      END TYPE

      TYPE CTENDAX_1               ' 40/NR:1  Tendon lane stations
        m_ID0 as Long              '        identifier 1
        m_IGBIT as Long            '        station parameter
        m_NRSTAB as Long           '        internal beam number
        m_ID3 as Long              '        reserved (value = 0)
        m_XL as Single             '        beam X/L on beam
        m_S as Single              ' [1001] station on reference lane
        m_SG as Single             ' [1001] station of geometry
        m_SF as Single             '        toppoint station
      END TYPE

      TYPE CTENDSPLI               ' 41/NR:0  Tendon splines
        m_ID0 as Long              '        identifier 0
        m_NRSPUR as Long           '        corresponding lane
        m_NRSV as Long             '        prestress system
        m_IGSYS as Long            '        prestress for:
        m_INTYP as Long            '        bit for analysis type
        m_IGREF as Long            '        reference to      geometry  Rec: 03
        m_IGREFX as Long           '        reference to exc. geometry  Rec: 03
        m_ID7 as Long              '        reserved (value = 0)
        m_ID8 as Long              '        reserved (value = 0)
        m_ID9 as Long              '        reserved (value = 0)
        m_STPARM(1 to 12) as Single'        additional data:
        m_TEXT(1 to 17) as Long    '        Designation
      END TYPE

      TYPE CTENDSP_I               ' 41/NR:??  Input points
        m_ID0 as Long              '        identifier INTYP see 41/0  (1=ZPUV standard geometry)
        m_IGBIT as Long            '        station parameter see 40/1
        m_ID2 as Long              '        reserved (value = 0)
        m_ID3 as Long              '        reserved (value = 0)
        m_DATA(1 to 20) as Single  '        Input point data
        m_QSP as Long              '        Selection string - reference to cross section point
        m_VARU as Long             '        Selection string - axis variable for offset U
        m_VARV as Long             '        Selection string - axis variable for offset V
        m_DAT2(1 to 50) as Single  '        Additional input point
      END TYPE

      TYPE CTENDTOPP               ' 43/NR  Tendon toppoints
        m_ID0 as Long              '        identifier:
        m_NR as Long               '        corresponding lane
        m_IGREF as Long            '        reference to      geometry  Rec: 03
        m_S(1 to 124) as Single    ' [1001] stations on toppoints (max. 124)
      END TYPE

      TYPE CTENDON                 ' 44/NR:0  Tendons
        m_ID0 as Long              '        identifier 0
        m_NRSPUR as Long           '        corresponding lane
        m_NRSPLI as Long           '        Spline-No
        m_NRSTRG as Long           '        tendon no.
        m_IGREF as Long            '        reference to      geometry  Rec: 03
        m_IGTYP as Long            '        bit for analysis type
        m_IZ_REF as Long           '        IGTYP=1024:  Def-No of geometry
        m_NIBA(1 to 3) as Long     '        construction stages
        m_NRSV as Long             '        prestress system
        m_NSP as Long              '        number of tendons
        m_MATA as Long             '        material concrete
        m_NVART as Long            '        type of jacking
        m_NVARTU as Long           '        output control
        m_NVVOR as Long            '        prestress input
        m_NVBIT(1 to 2) as Long    '        jacking bit
        m_LFP(1 to 2) as Long      '        prestress loadcases
        m_IGSYS as Long            '        prestress for:
        m_ID21 as Long             '        reserved (value = 0)
        m_KAPA as Single           '        KAPA + 100*KAPL + 1000*action
        m_EINL as Single           '        transition length
        m_ETYP as Single           '        force type to EINL
        m_TFAK as Single           '        factor partial p
        m_TLITZ as Single          '        no. of wires
        m_AR as Single             '        crack design area
        m_DZ as Single             '        diameter of tendon
        m_UZ as Single             '        perimeter
        m_VALM(1 to 4) as Single   '        reserved
        m_TEXT(1 to 17) as Long    '        Designation
      END TYPE

      TYPE CTENDJACK               ' 44/NR:1  Tendon jacking data
        m_ID0 as Long              '        identifier 1
        m_ID1 as Long              '        reserved (value = 0)
        m_ID2 as Long              '        reserved (value = 0)
        m_ID3 as Long              '        reserved (value = 0)
        m_ZVSTRG(1 to 16) as Single'        geometry data
        m_ZVFAK(1 to 24) as Single '        stresses and stressing factors
        m_ZVVOR(1 to 12) as Single '        direct input of prestress
        m_ZVFREE(1 to 12) as Single'        free prestress
        m_ZVAEND(1 to 8) as Single '        local geometry position
        m_ZVREIB(1 to 8) as Single '        additional friction data
        m_ZVFGRZ(1 to 32) as Single'        limit values of prestress
        m_ZVWEG(1 to 16) as Single '        stressing deformation
        m_TEXT(1 to 17) as Long    '        Designation
      END TYPE

      TYPE CTENDFACT               ' 44/NR:2  Tendon jacking factors
        m_ID0 as Long              '        identifier 2
        m_IGBIT as Long            '        station parameter see 40/1
        m_ID2 as Long              '        reserved (value = 0)
        m_ID3 as Long              '        reserved (value = 0)
        m_S as Single              ' [1001] station
        m_FAK as Single            '        active stressing factors
        m_ZWFAK(1 to 12) as Single '        additional factor data
      END TYPE

      TYPE CHIST_HED               ' 80/LC:-10?  TimeHistoryTitle
        m_RID as Single            '        Identifier of history type
        m_TITLE(1 to 33) as Long   '        Designation
      END TYPE

      TYPE CHIST_PAR               ' 80/LC:-9??  IterationParameters
        m_RID as Single            '        identifier
        m_VAL as Single            '        current value
        m_MIN as Single            '        minimum allowed value
        m_MAX as Single            '        maximum allowed value
        m_NAME(1 to 17) as Long    '        name of parameter
      END TYPE

      TYPE CHIST_ITEM              '        History element
        m_NR as Long
        m_TYP as Long
      END TYPE

      TYPE CHIST                   ' 80/LC:-  Identification of history elements
        m_RID as Single            '        Identification -100 < RID < 0.
        m_ITEM(1 to 32) as CHIST_ITEM '        History element
      END TYPE

      TYPE CHIST_VAL               ' 80/LC:+  Transient data
        m_TT as Single             '        Time/frequency
        m_VB(1 to 32) as Single    '        curve values
      END TYPE

      TYPE CSLVL_DAT               ' 87/0:+  Structural Storey Level Data
        m_NR as Long               '        Storey Level ID (34/NR)
        m_NREF(1 to 2) as Long     '        Node numbers of reference nodes on level
        m_NR_COR as Long           '        spt number of center of rigidity (COR)
        m_NR_COM as Long           '        spt number of center of mass (COM)
        m_CREATOR as Long          '        generated by (program) (0=SOFiMSHC, 1=DYNA)
        m_ZLEV as Single           ' [1006] Storey elevation, upwards positive (reference)
        m_H as Single              ' [1001] Storey height
        m_XEXT(1 to 2) as Single   ' [1001] Storey extensions in global X [XMIN, XMAX]
        m_YEXT(1 to 2) as Single   ' [1001] Storey extensions in global Y [YMIN, YMAX]
        m_MASS as Single           ' [1180] Storey mass
        m_XYZM(1 to 3) as Single   ' [1001] Coordinates of COM
        m_STX as Single            ' [1095] Storey stiffness in global X
        m_STY as Single            ' [1095] Storey stiffness in global Y
        m_XYZR(1 to 3) as Single   ' [1001] Coordinates of COR
        m_CPX as Single            ' [1151] Storey capacity in global X
        m_CPY as Single            ' [1151] Storey capacity in global Y
        m_TEXT(1 to 17) as Long    '        Designation of level
      END TYPE

      TYPE CSLVL_RES               ' 87/LC:+  Structural Storey Level Results
        m_NR as Long               '        Storey Level ID (34/NR)
        m_NR_MODE as Long          '        mode number (=0: resultant values, e.g. from CQC sup.)
        m_STYP(1 to 2) as Long     '        superposition type
        m_PX as Single             ' [1151] base shear in X
        m_PY as Single             ' [1151] base shear in Y
        m_PZ as Single             ' [1151] total vertical load at and above the storey
        m_MX as Single             ' [1152] moment about X
        m_MY as Single             ' [1152] moment about Y
        m_MZ as Single             ' [1152] moment about Z
        m_UX as Single             ' [1003] average storey displacement in X (=translations at COR)
        m_UY as Single             ' [1003] average storey displacement in Y
        m_UZ as Single             ' [1003] average storey displacement in Z
        m_RZ as Single             ' [1004] average storey rotation in XY-plane
        m_DX as Single             ' [1003] inter-storey drift in X (=difference between top and bottom of 
        m_DY as Single             ' [1003] inter-storey drift in Y
        m_DRZ as Single            ' [1004] inter-storey rotation in XY-plane
        m_LSAF as Single           ' [  98] modal acceleration (only for NR_MODE>0)
      END TYPE

      TYPE CBEAM                   ' 100/00:+  Beams
        m_NR as Long               '        beam number
        m_NODE(1 to 2) as Long     '        node number start/end
        m_NP as Long               '        prop number
        m_DL as Single             ' [1001] beamlength
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_EX(1 to 2,1 to 3) as Single ' [1001] 
        m_NREF as Long             '        reference axis
        m_SPAR(1 to 2) as Single   '        distances along a continuous beam or
        m_BETY as Single
        m_BETZ as Single
        m_LDFY as Single
        m_LDFZ as Single           '        deformation length factor for vz
      END TYPE

      TYPE CBSLN                   ' 120/00:+  Design elements
        m_NR as Long               '        beam number
        m_NODE(1 to 2) as Long     '        node number start/end
        m_NP as Long               '        prop number
        m_DL as Single             ' [1001] beamlength
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_EX(1 to 2,1 to 3) as Single ' [1001] 
        m_NREF as Long             '        reference axis
        m_SPAR(1 to 2) as Single   '        distances along a continuous beam or
        m_BETY as Single
        m_BETZ as Single
        m_LDFY as Single
        m_LDFZ as Single           '        deformation length factor for vz
      END TYPE

      TYPE CBSCT                   ' 140/00:+  External sections
        m_NR as Long               '        beam number
        m_NODE(1 to 2) as Long     '        node number start/end
        m_NP as Long               '        prop number
        m_DL as Single             ' [1001] beamlength
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_EX(1 to 2,1 to 3) as Single ' [1001] 
        m_NREF as Long             '        reference axis
        m_SPAR(1 to 2) as Single   '        distances along a continuous beam or
        m_BETY as Single
        m_BETZ as Single
        m_LDFY as Single
        m_LDFZ as Single           '        deformation length factor for vz
      END TYPE

      TYPE CBEAM_SCT               ' 100/00:0  Beams sections
        m_ID as Long               '        identifier for sections 0
        m_NQ as Long               '        number cross section
        m_ITYP as Long             '        Bitcodes
        m_ITP2 as Long             '        Connection / Hinges for x=0,x=dl
        m_X as Single              ' [1001] sectional abscissa
      END TYPE

      TYPE CBSLN_SCT               ' 120/00:0  Design element sections
        m_ID as Long               '        identifier for sections 0
        m_NQ as Long               '        number cross section
        m_ITYP as Long             '        Bitcode I   (identical to 100/0:0)
        m_ITP2 as Long             '        Bitcode II  (identical to 100/0:0)
        m_X as Single              ' [1001] sectional abscissa
        m_T(1 to 4,1 to 3) as Single '        transformation matrix
        m_YMIN as Single           ' [1001] Box of active elements in cut plane
        m_ZMIN as Single           ' [1001] Box of active elements in cut plane
        m_YMAX as Single           ' [1001] Box of active elements in cut plane
        m_ZMAX as Single           ' [1001] Box of active elements in cut plane
        m_XMIN as Single           ' [1001] Box of active elements in cut plane
        m_XMAX as Single           ' [1001] Box of active elements in cut plane
        m_YMINSEL as Single        ' [1001] Max user defined size of Box
        m_ZMINSEL as Single        ' [1001] Max user defined size of Box
        m_YMAXSEL as Single        ' [1001] Max user defined size of Box
        m_ZMAXSEL as Single        ' [1001] Max user defined size of Box
        m_YSC as Single            ' [1001] Coordinate y of shear centre
        m_ZSC as Single            ' [1001] Coordinate z of shear centre
      END TYPE

      TYPE CBSCT_SCT               ' 140/00:0  External sections
        m_ID as Long               '        identifier for sections 0
        m_NQ as Long               '        number cross section
        m_ITYP as Long             '        Bitcode I   (identical to 100/0:0)
        m_ITP2 as Long             '        Bitcode II  (identical to 100/0:0)
        m_X as Single              ' [1001] sectional abscissa
        m_T(1 to 4,1 to 3) as Single '        transformation matrix
        m_YMIN as Single           ' [1001] Box of active elements in cut plane
        m_ZMIN as Single           ' [1001] Box of active elements in cut plane
        m_YMAX as Single           ' [1001] Box of active elements in cut plane
        m_ZMAX as Single           ' [1001] Box of active elements in cut plane
        m_XMIN as Single           ' [1001] Box of active elements in cut plane
        m_XMAX as Single           ' [1001] Box of active elements in cut plane
        m_YMINSEL as Single        ' [1001] Max user defined size of Box
        m_ZMINSEL as Single        ' [1001] Max user defined size of Box
        m_YMAXSEL as Single        ' [1001] Max user defined size of Box
        m_ZMAXSEL as Single        ' [1001] Max user defined size of Box
        m_YSC as Single            ' [1001] Coordinate y of shear centre
        m_ZSC as Single            ' [1001] Coordinate z of shear centre
      END TYPE

      TYPE CBEAM_TRA               ' 100/01  transformation matrix
        m_NR as Long               '        beamnumber
        m_DL as Single             ' [1001] beamlength
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
      END TYPE

      TYPE CBEAM_TRS               ' 100/03  Info about dynamic moving beams (TREX)
        m_LF as Long               '        Loadcase number containing the train
        m_NR as Long               '        Number of Beam
        m_BPAT as Long             '        Options for BEAM (see TREX in SOFILOAD)
        m_NODA(1 to 4) as Long     '        Node Numbers for Start of beam element
        m_NODE(1 to 4) as Long     '        Node Numbers for end of beam element
        m_XN(1 to 2) as Single     ' [1001] x-values of nodes along load train
      END TYPE

      TYPE CBEAM_TND               ' 100/05  tendons of beams
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        tendon number
        m_MNR as Long              '        material number of tendon + 1000 * material number of cross-sec
        m_IBA1 as Long             '        construction stage number for placing
        m_IBA2 as Long             '        construction stage number for grouting
        m_IBA3 as Long             '        construction stage number for removing
        m_X as Single              ' [1011] x-ordinate
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_ZZ as Single             ' [1101] tensoning force
        m_AZ as Single             ' [1020] tendon area
        m_D as Single              ' [1023] diameter
        m_UZ as Single             ' [1023] effect. periphery
        m_NY as Single             '        inclination DY/DX
        m_NZ as Single             '        inclination DZ/DX
        m_YHR as Single            ' [1011] y-ordinate duct
        m_ZHR as Single            ' [1011] z-ordinate duct
        m_AHR as Single            ' [1020] area of duct
        m_AR as Single             ' [1012] reference area
        m_TEMP as Single           ' [1215] Temperature
        m_REDFAK as Single         '        Reduction factor within transmission length
        m_XSI as Single            '        Relative ordinate within total tendon
      END TYPE

      TYPE CBSLN_TND               ' 120/05  tendons of structural beam lines
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        tendon number
        m_MNR as Long              '        material number of tendon + 1000 * material number of cross-sec
        m_IBA1 as Long             '        construction stage number for placing
        m_IBA2 as Long             '        construction stage number for grouting
        m_IBA3 as Long             '        construction stage number for removing
        m_X as Single              ' [1011] x-ordinate
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_ZZ as Single             ' [1101] tensoning force
        m_AZ as Single             ' [1020] tendon area
        m_D as Single              ' [1023] diameter
        m_UZ as Single             ' [1023] effect. periphery
        m_NY as Single             '        inclination DY/DX
        m_NZ as Single             '        inclination DZ/DX
        m_YHR as Single            ' [1011] y-ordinate duct
        m_ZHR as Single            ' [1011] z-ordinate duct
        m_AHR as Single            ' [1020] area of duct
        m_AR as Single             ' [1012] reference area
        m_TEMP as Single           ' [1215] Temperature
        m_REDFAK as Single         '        Reduction factor within transmission length
        m_XSI as Single            '        Relative ordinate within total tendon
      END TYPE

      TYPE CBSCT_TND               ' 140/05  tendons of external sections
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        tendon number
        m_MNR as Long              '        material number of tendon + 1000 * material number of cross-sec
        m_IBA1 as Long             '        construction stage number for placing
        m_IBA2 as Long             '        construction stage number for grouting
        m_IBA3 as Long             '        construction stage number for removing
        m_X as Single              ' [1011] x-ordinate
        m_Y as Single              ' [1011] y-ordinate
        m_Z as Single              ' [1011] z-ordinate
        m_ZZ as Single             ' [1101] tensoning force
        m_AZ as Single             ' [1020] tendon area
        m_D as Single              ' [1023] diameter
        m_UZ as Single             ' [1023] effect. periphery
        m_NY as Single             '        inclination DY/DX
        m_NZ as Single             '        inclination DZ/DX
        m_YHR as Single            ' [1011] y-ordinate duct
        m_ZHR as Single            ' [1011] z-ordinate duct
        m_AHR as Single            ' [1020] area of duct
        m_AR as Single             ' [1012] reference area
        m_TEMP as Single           ' [1215] Temperature
        m_REDFAK as Single         '        Reduction factor within transmission length
        m_XSI as Single            '        Relative ordinate within total tendon
      END TYPE

      TYPE CBEAM_SL                ' 101/LC:*  single beam loads
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_X as Single              ' [1001] load point
        m_I_2 as Single            ' [1001] reserved 0.
        m_PA as Single             '        value of load
        m_I_4 as Single            '        reserved 0.
        m_YA as Single             ' [1001] eccentr. local y
        m_ZA as Single             ' [1001] eccentr. local z
      END TYPE

      TYPE CBEAM_DL                ' 101/LC:*  distributed beam loading on reference
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_X as Single              ' [1001] start point
        m_L as Single              ' [1001] length of load
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
        m_YA as Single             ' [1001] eccentr. local y A
        m_ZA as Single             ' [1001] eccentr. local z A
        m_YE as Single             ' [1001] eccentr. local y E
        m_ZE as Single             ' [1001] eccentr. local z E
        m_DYA as Single            '        gradient of eccentricity, local y, start
        m_DZA as Single            '        gradient of eccentricity, local z, start
        m_DYE as Single            '        gradient of eccentricity, local y, end
        m_DZE as Single            '        gradient of eccentricity, local z, end
      END TYPE

      TYPE CBEAM_TL                ' 101/LC:*  distributed beam loading on reference
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_X as Single              ' [1001] start point
        m_L as Single              ' [1001] length of load
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
        m_YA as Single             ' [1001] eccentr. local y A
        m_ZA as Single             ' [1001] eccentr. local z A
        m_YE as Single             ' [1001] eccentr. local y E
        m_ZE as Single             ' [1001] eccentr. local z E
        m_DYA as Single            '        gradient of eccentricity, local y, start
        m_DZA as Single            '        gradient of eccentricity, local z, start
        m_DYE as Single            '        gradient of eccentricity, local y, end
        m_DZE as Single            '        gradient of eccentricity, local z, end
      END TYPE

      TYPE CBEAM_CL                ' 101/LC:*  cubic beamloads
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_X as Single              ' [1001] start point
        m_L as Single              ' [1001] length of load
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
        m_DPA as Single            '        start derivative
        m_DPE as Single            '        end   derivative
      END TYPE

      TYPE CBEAM_WL                ' 101/LC:*  dynamic wind loads
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_FA as Single             '        Factor cross start
        m_FE as Single             '        Factor cross end
        m_FT as Single             '        Factor frictional
        m_VXA as Single            ' [1201] wind velocity
        m_VYA as Single            ' [1201] wind velocity
        m_VZA as Single            ' [1201] wind velocity
        m_VXE as Single            ' [1201] wind velocity
        m_VYE as Single            ' [1201] wind velocity
        m_VZE as Single            ' [1201] wind velocity
        m_VXAM as Single           ' [1201] mean wind velocity
        m_VYAM as Single           ' [1201] mean wind velocity
        m_VZAM as Single           ' [1201] mean wind velocity
        m_VXEM as Single           ' [1201] mean wind velocity
        m_VYEM as Single           ' [1201] mean wind velocity
        m_VZEM as Single           ' [1201] mean wind velocity
      END TYPE

      TYPE CTRUS_WL                ' 151/LC:*  dynamic wind loads
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_FA as Single             '        Factor cross start
        m_FE as Single             '        Factor cross end
        m_FT as Single             '        Factor frictional
        m_VXA as Single            ' [1201] wind velocity
        m_VYA as Single            ' [1201] wind velocity
        m_VZA as Single            ' [1201] wind velocity
        m_VXE as Single            ' [1201] wind velocity
        m_VYE as Single            ' [1201] wind velocity
        m_VZE as Single            ' [1201] wind velocity
        m_VXAM as Single           ' [1201] mean wind velocity
        m_VYAM as Single           ' [1201] mean wind velocity
        m_VZAM as Single           ' [1201] mean wind velocity
        m_VXEM as Single           ' [1201] mean wind velocity
        m_VYEM as Single           ' [1201] mean wind velocity
        m_VZEM as Single           ' [1201] mean wind velocity
      END TYPE

      TYPE CCABL_WL                ' 161/LC:*  dynamic wind loads
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of load
        m_FA as Single             '        Factor cross start
        m_FE as Single             '        Factor cross end
        m_FT as Single             '        Factor frictional
        m_VXA as Single            ' [1201] wind velocity
        m_VYA as Single            ' [1201] wind velocity
        m_VZA as Single            ' [1201] wind velocity
        m_VXE as Single            ' [1201] wind velocity
        m_VYE as Single            ' [1201] wind velocity
        m_VZE as Single            ' [1201] wind velocity
        m_VXAM as Single           ' [1201] mean wind velocity
        m_VYAM as Single           ' [1201] mean wind velocity
        m_VZAM as Single           ' [1201] mean wind velocity
        m_VXEM as Single           ' [1201] mean wind velocity
        m_VYEM as Single           ' [1201] mean wind velocity
        m_VZEM as Single           ' [1201] mean wind velocity
      END TYPE

      TYPE CBEAM_FOC               ' 102/LC:0  Maximum of Total Beam forces and deformations
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] max. beam length
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsionalmom.
        m_UX as Single             ' [1003] diplacem. local x
        m_UY as Single             ' [1003] diplacem. local y
        m_UZ as Single             ' [1003] diplacem. local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
      END TYPE

      TYPE CBEAM_FTC               ' 112/LC:0  Maximum of Beam forces without plate components
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] max. beam length
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsionalmom.
        m_UX as Single             ' [1003] diplacem. local x
        m_UY as Single             ' [1003] diplacem. local y
        m_UZ as Single             ' [1003] diplacem. local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
      END TYPE

      TYPE CBSLN_FTC               ' 122/LC:0  Maximum of Beam forces without plate components
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] max. beam length
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsionalmom.
        m_UX as Single             ' [1003] diplacem. local x
        m_UY as Single             ' [1003] diplacem. local y
        m_UZ as Single             ' [1003] diplacem. local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
      END TYPE

      TYPE CBSCT_FOC               ' 142/LC:0  Maximum of External sections forces
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] max. beam length
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsionalmom.
        m_UX as Single             ' [1003] diplacem. local x
        m_UY as Single             ' [1003] diplacem. local y
        m_UZ as Single             ' [1003] diplacem. local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
      END TYPE

      TYPE CBEAM_FOR               ' 102/LC:+  Total Beam forces and deformations
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] distance from start
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsional moment
        m_UX as Single             ' [1003] diplacement local x
        m_UY as Single             ' [1003] diplacement local y
        m_UZ as Single             ' [1003] diplacement local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
        m_Q1 as Single             '        quaternion component q1
        m_Q2 as Single             '        quaternion component q2
        m_Q3 as Single             '        quaternion component q3
        m_Q0 as Single             '        quaternion component q0
        m_UXX as Single            ' [1003] translation in global X
        m_UYY as Single            ' [1003] translation in global Y
        m_UZZ as Single            ' [1003] translation in global Z
      END TYPE

      TYPE CBEAM_FTR               ' 112/LC:+  Beam forces without plate components
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] distance from start
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsional moment
        m_UX as Single             ' [1003] diplacement local x
        m_UY as Single             ' [1003] diplacement local y
        m_UZ as Single             ' [1003] diplacement local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
        m_Q1 as Single             '        quaternion component q1
        m_Q2 as Single             '        quaternion component q2
        m_Q3 as Single             '        quaternion component q3
        m_Q0 as Single             '        quaternion component q0
        m_UXX as Single            ' [1003] translation in global X
        m_UYY as Single            ' [1003] translation in global Y
        m_UZZ as Single            ' [1003] translation in global Z
      END TYPE

      TYPE CBSLN_FTR               ' 122/LC:+  Beam forces without plate components
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] distance from start
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsional moment
        m_UX as Single             ' [1003] diplacement local x
        m_UY as Single             ' [1003] diplacement local y
        m_UZ as Single             ' [1003] diplacement local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
        m_Q1 as Single             '        quaternion component q1
        m_Q2 as Single             '        quaternion component q2
        m_Q3 as Single             '        quaternion component q3
        m_Q0 as Single             '        quaternion component q0
        m_UXX as Single            ' [1003] translation in global X
        m_UYY as Single            ' [1003] translation in global Y
        m_UZZ as Single            ' [1003] translation in global Z
      END TYPE

      TYPE CBSCT_FOR               ' 142/LC:+  External sections forces
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] distance from start
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsional moment
        m_UX as Single             ' [1003] diplacement local x
        m_UY as Single             ' [1003] diplacement local y
        m_UZ as Single             ' [1003] diplacement local z
        m_PHIX as Single           ' [1004] rotation local x
        m_PHIY as Single           ' [1004] rotation local y
        m_PHIZ as Single           ' [1004] rotation local z
        m_PHIW as Single           ' [1005] twisting
        m_MT3 as Single            ' [1103] 3rd torsionalmom
        m_PA as Single             ' [1095] axial bedding
        m_PT as Single             ' [1095] transverse bedding
        m_PTY as Single            ' [1095] local y component of transverse bedding
        m_PTZ as Single            ' [1095] local z component of transverse bedding
        m_Q1 as Single             '        quaternion component q1
        m_Q2 as Single             '        quaternion component q2
        m_Q3 as Single             '        quaternion component q3
        m_Q0 as Single             '        quaternion component q0
        m_UXX as Single            ' [1003] translation in global X
        m_UYY as Single            ' [1003] translation in global Y
        m_UZZ as Single            ' [1003] translation in global Z
      END TYPE

      TYPE CBEAM_FOX               ' 102/0  Total External Beam forces
        m_NQ as Long               '        section number
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] abscissa
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsion.moment
      END TYPE

      TYPE CBSCT_FOX               ' 142/0  Total External Forces for external sections
        m_NQ as Long               '        section number
        m_NR as Long               '        beamnumber
        m_X as Single              ' [1001] abscissa
        m_N as Single              ' [1101] normal force
        m_VY as Single             ' [1102] y-shear force
        m_VZ as Single             ' [1102] z-shear force
        m_MT as Single             ' [1103] torsional moment
        m_MY as Single             ' [1104] bending moment My
        m_MZ as Single             ' [1104] bending moment Mz
        m_MB as Single             ' [1105] warping moment Mb
        m_MT2 as Single            ' [1103] 2nd torsion.moment
      END TYPE

      TYPE CBEAM_STI               ' 103/LC  Stiffness of beams
        m_NR as Long               '        beam number
        m_X as Single              ' [1001] distance from start
        m_EA as Single             ' [  62] normal stiffness
        m_GAY as Single            ' [  62] y-shear stiffness
        m_GAZ as Single            ' [  62] z-shear stiffness
        m_GIT as Single            ' [  83] torsional stiffness
        m_EIY as Single            ' [  83] bending stiffness y
        m_EIZ as Single            ' [  83] bending stiffness z
        m_EIYZ as Single           ' [  83] bending stiffness yz
        m_GAYZ as Single           ' [  62] yz-shear stiffness
        m_KPX as Single            ' [   8] plastic strain x
        m_KPY as Single            ' [  17] plastic curvature y
        m_KPZ as Single            ' [  17] plastic curvature z
        m_EMIN as Single           ' [1081] minimum strain
        m_EMAX as Single           ' [1081] maximum strain
        m_GE1 as Single            ' [1101] Residual of current step (Crisfield)
        m_GE2 as Single            ' [1104] Residual of current step (Crisfield)
        m_GE3 as Single            ' [1104] Residual of current step (Crisfield)
        m_EA0 as Single            ' [  83] lin. stiffness EA
        m_EIY0 as Single           ' [  83] lin. stiffness EIy
        m_EIZ0 as Single           ' [  83] lin. stiffness EIz
        m_DYSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_DZSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_PRE as Single            ' [1101] primary axial force
        m_YS as Single             ' [1001] y-eccentricity of centre of gravity
        m_ZS as Single             ' [1001] z-eccentricity of centre of gravity
        m_ECM as Single            '        warping stiffness
        m_GCMS as Single           '        secondary torsion
        m_NI as Single             ' [1101] inner normal force
        m_VYI as Single            ' [1102] inner y-shear force
        m_VZI as Single            ' [1102] inner z-shear force
        m_MTI as Single            ' [1103] inner torsional moment
        m_MYI as Single            ' [1104] inner bending moment My
        m_MZI as Single            ' [1104] inner bending moment Mz
        m_MBI as Single            ' [1105] inner warping moment Mb
        m_E0 as Single             ' [1081] total strain x
        m_GKPY as Single           ' [  17] total curvature y
        m_GKPZ as Single           ' [  17] total curvature z
        m_KFVY as Single           '        plastic factor V-y
        m_KFVZ as Single           '        plastic factor V-z
        m_KFMT as Single           '        plastic factor M-t
        m_DE_0(1 to 7) as Single   '        Crisfield increments of current step di
        m_DE_1(1 to 7) as Single   '        Crisfield increments of last step di-1
        m_I_54 as Single           '        unused
        m_ERF_MIN as Single        ' [1081] minimum strain reinf.
        m_ERF_MAX as Single        ' [1081] maximum strain reinf.
        m_HC as Single             ' [   8] relative compressive zone height
        m_CCW as Single            ' [1026] current crack opening
        m_I_59(1 to 11) as Single  '        unused
      END TYPE

      TYPE CBSLN_STI               ' 123/LC  Stiffness of beams
        m_NR as Long               '        beam number
        m_X as Single              ' [1001] distance from start
        m_EA as Single             ' [  62] normal stiffness
        m_GAY as Single            ' [  62] y-shear stiffness
        m_GAZ as Single            ' [  62] z-shear stiffness
        m_GIT as Single            ' [  83] torsional stiffness
        m_EIY as Single            ' [  83] bending stiffness y
        m_EIZ as Single            ' [  83] bending stiffness z
        m_EIYZ as Single           ' [  83] bending stiffness yz
        m_GAYZ as Single           ' [  62] yz-shear stiffness
        m_KPX as Single            ' [   8] plastic strain x
        m_KPY as Single            ' [  17] plastic curvature y
        m_KPZ as Single            ' [  17] plastic curvature z
        m_EMIN as Single           ' [1081] minimum strain
        m_EMAX as Single           ' [1081] maximum strain
        m_GE1 as Single            ' [1101] Residual of current step (Crisfield)
        m_GE2 as Single            ' [1104] Residual of current step (Crisfield)
        m_GE3 as Single            ' [1104] Residual of current step (Crisfield)
        m_EA0 as Single            ' [  83] lin. stiffness EA
        m_EIY0 as Single           ' [  83] lin. stiffness EIy
        m_EIZ0 as Single           ' [  83] lin. stiffness EIz
        m_DYSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_DZSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_PRE as Single            ' [1101] primary axial force
        m_YS as Single             ' [1001] y-eccentricity of centre of gravity
        m_ZS as Single             ' [1001] z-eccentricity of centre of gravity
        m_ECM as Single            '        warping stiffness
        m_GCMS as Single           '        secondary torsion
        m_NI as Single             ' [1101] inner normal force
        m_VYI as Single            ' [1102] inner y-shear force
        m_VZI as Single            ' [1102] inner z-shear force
        m_MTI as Single            ' [1103] inner torsional moment
        m_MYI as Single            ' [1104] inner bending moment My
        m_MZI as Single            ' [1104] inner bending moment Mz
        m_MBI as Single            ' [1105] inner warping moment Mb
        m_E0 as Single             ' [1081] total strain x
        m_GKPY as Single           ' [  17] total curvature y
        m_GKPZ as Single           ' [  17] total curvature z
        m_KFVY as Single           '        plastic factor V-y
        m_KFVZ as Single           '        plastic factor V-z
        m_KFMT as Single           '        plastic factor M-t
        m_DE_0(1 to 7) as Single   '        Crisfield increments of current step di
        m_DE_1(1 to 7) as Single   '        Crisfield increments of last step di-1
        m_I_54 as Single           '        unused
        m_ERF_MIN as Single        ' [1081] minimum strain reinf.
        m_ERF_MAX as Single        ' [1081] maximum strain reinf.
        m_HC as Single             ' [   8] relative compressive zone height
        m_CCW as Single            ' [1026] current crack opening
        m_I_59(1 to 11) as Single  '        unused
      END TYPE

      TYPE CBSCT_STI               ' 143/LC  Stiffness of beams
        m_NR as Long               '        beam number
        m_X as Single              ' [1001] distance from start
        m_EA as Single             ' [  62] normal stiffness
        m_GAY as Single            ' [  62] y-shear stiffness
        m_GAZ as Single            ' [  62] z-shear stiffness
        m_GIT as Single            ' [  83] torsional stiffness
        m_EIY as Single            ' [  83] bending stiffness y
        m_EIZ as Single            ' [  83] bending stiffness z
        m_EIYZ as Single           ' [  83] bending stiffness yz
        m_GAYZ as Single           ' [  62] yz-shear stiffness
        m_KPX as Single            ' [   8] plastic strain x
        m_KPY as Single            ' [  17] plastic curvature y
        m_KPZ as Single            ' [  17] plastic curvature z
        m_EMIN as Single           ' [1081] minimum strain
        m_EMAX as Single           ' [1081] maximum strain
        m_GE1 as Single            ' [1101] Residual of current step (Crisfield)
        m_GE2 as Single            ' [1104] Residual of current step (Crisfield)
        m_GE3 as Single            ' [1104] Residual of current step (Crisfield)
        m_EA0 as Single            ' [  83] lin. stiffness EA
        m_EIY0 as Single           ' [  83] lin. stiffness EIy
        m_EIZ0 as Single           ' [  83] lin. stiffness EIz
        m_DYSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_DZSM as Single           ' [1011] ordinate shear centre to gravity centre
        m_PRE as Single            ' [1101] primary axial force
        m_YS as Single             ' [1001] y-eccentricity of centre of gravity
        m_ZS as Single             ' [1001] z-eccentricity of centre of gravity
        m_ECM as Single            '        warping stiffness
        m_GCMS as Single           '        secondary torsion
        m_NI as Single             ' [1101] inner normal force
        m_VYI as Single            ' [1102] inner y-shear force
        m_VZI as Single            ' [1102] inner z-shear force
        m_MTI as Single            ' [1103] inner torsional moment
        m_MYI as Single            ' [1104] inner bending moment My
        m_MZI as Single            ' [1104] inner bending moment Mz
        m_MBI as Single            ' [1105] inner warping moment Mb
        m_E0 as Single             ' [1081] total strain x
        m_GKPY as Single           ' [  17] total curvature y
        m_GKPZ as Single           ' [  17] total curvature z
        m_KFVY as Single           '        plastic factor V-y
        m_KFVZ as Single           '        plastic factor V-z
        m_KFMT as Single           '        plastic factor M-t
        m_DE_0(1 to 7) as Single   '        Crisfield increments of current step di
        m_DE_1(1 to 7) as Single   '        Crisfield increments of last step di-1
        m_I_54 as Single           '        unused
        m_ERF_MIN as Single        ' [1081] minimum strain reinf.
        m_ERF_MAX as Single        ' [1081] maximum strain reinf.
        m_HC as Single             ' [   8] relative compressive zone height
        m_CCW as Single            ' [1026] current crack opening
        m_I_59(1 to 11) as Single  '        unused
      END TYPE

      TYPE CBEAM_CRC               ' 104/LC:0  Parameter of creep interval for each material
        m_ID as Long               '        identifier 0
        m_MNR as Long              '        materialnumber
        m_EXP as Long              '        exposition class of explicit curve
        m_T as Single              ' [  93] absolute age
        m_PHI as Single            '        creep coefficient
        m_EPS as Single            '        shrinkage
        m_RH as Single             ' [   8] relative moisture
        m_TEMP as Single           ' [   6] temperature
        m_TWA as Single            ' [  93] effective age start
        m_TWE as Single            ' [  93] effective age end
        m_BETH as Single           '        creep coefficient beta-h
        m_TS as Single             ' [  93] start date of drying
        m_TC as Single             ' [  93] start date of loading
      END TYPE

      TYPE CBSLN_CRC               ' 124/LC:0  Parameter of creep interval for each material
        m_ID as Long               '        identifier 0
        m_MNR as Long              '        materialnumber
        m_EXP as Long              '        exposition class of explicit curve
        m_T as Single              ' [  93] absolute age
        m_PHI as Single            '        creep coefficient
        m_EPS as Single            '        shrinkage
        m_RH as Single             ' [   8] relative moisture
        m_TEMP as Single           ' [   6] temperature
        m_TWA as Single            ' [  93] effective age start
        m_TWE as Single            ' [  93] effective age end
        m_BETH as Single           '        creep coefficient beta-h
        m_TS as Single             ' [  93] start date of drying
        m_TC as Single             ' [  93] start date of loading
      END TYPE

      TYPE CBSCT_CRC               ' 144/LC:0  Parameter of creep interval for each material
        m_ID as Long               '        identifier 0
        m_MNR as Long              '        materialnumber
        m_EXP as Long              '        exposition class of explicit curve
        m_T as Single              ' [  93] absolute age
        m_PHI as Single            '        creep coefficient
        m_EPS as Single            '        shrinkage
        m_RH as Single             ' [   8] relative moisture
        m_TEMP as Single           ' [   6] temperature
        m_TWA as Single            ' [  93] effective age start
        m_TWE as Single            ' [  93] effective age end
        m_BETH as Single           '        creep coefficient beta-h
        m_TS as Single             ' [  93] start date of drying
        m_TC as Single             ' [  93] start date of loading
      END TYPE

      TYPE CBEAM_CRF               ' 104/LC:+  resulting forces of redistribution
        m_NR as Long               '        beamnumber
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_SDNI as Single           ' [1101] total normal force
        m_SDVY as Single           ' [1102] total y-shear force
        m_SDVZ as Single           ' [1102] total z-shear force
        m_SDMT as Single           ' [1103] total torsion moment
        m_SDMY as Single           ' [1104] total bending moment
        m_SDMZ as Single           ' [1104] total bending moment
        m_SRNI as Single           ' [1101] relat. normal force
        m_SRVY as Single           ' [1102] relat. y-shear force
        m_SRVZ as Single           ' [1102] relat. y-shear force
        m_SRMT as Single           ' [1103] relat. torsionmoment
        m_SRMY as Single           ' [1104] relat. bendingmoment
        m_SRMZ as Single           ' [1104] relat. bendingmoment
      END TYPE

      TYPE CBSLN_CRF               ' 124/LC:+  resulting forces of redistribution
        m_NR as Long               '        beamnumber
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_SDNI as Single           ' [1101] total normal force
        m_SDVY as Single           ' [1102] total y-shear force
        m_SDVZ as Single           ' [1102] total z-shear force
        m_SDMT as Single           ' [1103] total torsion moment
        m_SDMY as Single           ' [1104] total bending moment
        m_SDMZ as Single           ' [1104] total bending moment
        m_SRNI as Single           ' [1101] relat. normal force
        m_SRVY as Single           ' [1102] relat. y-shear force
        m_SRVZ as Single           ' [1102] relat. y-shear force
        m_SRMT as Single           ' [1103] relat. torsionmoment
        m_SRMY as Single           ' [1104] relat. bendingmoment
        m_SRMZ as Single           ' [1104] relat. bendingmoment
      END TYPE

      TYPE CBSCT_CRF               ' 144/LC:+  resulting forces of redistribution
        m_NR as Long               '        beamnumber
        m_ID as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_SDNI as Single           ' [1101] total normal force
        m_SDVY as Single           ' [1102] total y-shear force
        m_SDVZ as Single           ' [1102] total z-shear force
        m_SDMT as Single           ' [1103] total torsion moment
        m_SDMY as Single           ' [1104] total bending moment
        m_SDMZ as Single           ' [1104] total bending moment
        m_SRNI as Single           ' [1101] relat. normal force
        m_SRVY as Single           ' [1102] relat. y-shear force
        m_SRVZ as Single           ' [1102] relat. y-shear force
        m_SRMT as Single           ' [1103] relat. torsionmoment
        m_SRMY as Single           ' [1104] relat. bendingmoment
        m_SRMZ as Single           ' [1104] relat. bendingmoment
      END TYPE

      TYPE CBEAM_TSN               ' 104/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        10000+materialnumber
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 32,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBSLN_TSN               ' 124/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        10000+materialnumber
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 32,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBSCT_TSN               ' 144/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        10000+materialnumber
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 32,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBEAM_CRP               ' 104/LC:+  forces on sectional parts per material
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_DNI as Single            ' [1101] impr. normal force
        m_DMYI as Single           ' [1104] impr. bending moment
        m_DMZI as Single           ' [1104] impr. bending moment
        m_NI as Single             ' [1101] total normal force
        m_MYI as Single            ' [1104] total bending moment
        m_MZI as Single            ' [1104] total bending moment
        m_SDNI as Single           ' [1192] stress plane parameter from (DNI:DMZI)
        m_SDMYI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SDMZI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SNI as Single            ' [1192] stress plane parameter from (NI:MZI)
        m_SMYI as Single           ' [1193] stress plane parameter from (NI:MZI)
        m_SMZI as Single           ' [1193] stress plane parameter from (NI:MZI)
      END TYPE

      TYPE CBSLN_CRP               ' 124/LC:+  forces on sectional parts per material
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_DNI as Single            ' [1101] impr. normal force
        m_DMYI as Single           ' [1104] impr. bending moment
        m_DMZI as Single           ' [1104] impr. bending moment
        m_NI as Single             ' [1101] total normal force
        m_MYI as Single            ' [1104] total bending moment
        m_MZI as Single            ' [1104] total bending moment
        m_SDNI as Single           ' [1192] stress plane parameter from (DNI:DMZI)
        m_SDMYI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SDMZI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SNI as Single            ' [1192] stress plane parameter from (NI:MZI)
        m_SMYI as Single           ' [1193] stress plane parameter from (NI:MZI)
        m_SMZI as Single           ' [1193] stress plane parameter from (NI:MZI)
      END TYPE

      TYPE CBSCT_CRP               ' 144/LC:+  forces on sectional parts per material
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_DNI as Single            ' [1101] impr. normal force
        m_DMYI as Single           ' [1104] impr. bending moment
        m_DMZI as Single           ' [1104] impr. bending moment
        m_NI as Single             ' [1101] total normal force
        m_MYI as Single            ' [1104] total bending moment
        m_MZI as Single            ' [1104] total bending moment
        m_SDNI as Single           ' [1192] stress plane parameter from (DNI:DMZI)
        m_SDMYI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SDMZI as Single          ' [1193] stress plane parameter from (DNI:DMZI)
        m_SNI as Single            ' [1192] stress plane parameter from (NI:MZI)
        m_SMYI as Single           ' [1193] stress plane parameter from (NI:MZI)
        m_SMZI as Single           ' [1193] stress plane parameter from (NI:MZI)
      END TYPE

      TYPE CBEAM_CRT               ' 104/LC:+  changes of tensional force
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        neg. tendonnumber
        m_X as Single              ' [1001] distance from start
        m_DZZ as Single            ' [1092] change of stress to prestress
        m_DZR as Single            ' [1092] rel. change of stress to concrete strain
        m_DZ as Single             ' [1101] rel. change of force from mean strain
        m_DZFAK(1 to 5) as Single  '        ordinates, inclinations to evaluate forces
      END TYPE

      TYPE CBSLN_CRT               ' 124/LC:+  changes of tensional force
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        neg. tendonnumber
        m_X as Single              ' [1001] distance from start
        m_DZZ as Single            ' [1092] change of stress to prestress
        m_DZR as Single            ' [1092] rel. change of stress to concrete strain
        m_DZ as Single             ' [1101] rel. change of force from mean strain
        m_DZFAK(1 to 5) as Single  '        ordinates, inclinations to evaluate forces
      END TYPE

      TYPE CBSCT_CRT               ' 144/LC:+  changes of tensional force
        m_NR as Long               '        beamnumber
        m_NRS as Long              '        neg. tendonnumber
        m_X as Single              ' [1001] distance from start
        m_DZZ as Single            ' [1092] change of stress to prestress
        m_DZR as Single            ' [1092] rel. change of stress to concrete strain
        m_DZ as Single             ' [1101] rel. change of force from mean strain
        m_DZFAK(1 to 5) as Single  '        ordinates, inclinations to evaluate forces
      END TYPE

      TYPE CBEAM_STC               ' 105/LC:0  Maximum stresses in cross-section of beams
        m_NR as Long               '        Ident 0
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance to start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial comp stress
        m_SIGU as Single           ' [1092] uniaxial tens stress
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling intensity
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
      END TYPE

      TYPE CBSLN_STC               ' 125/LC:0  Maximum stresses in cross-section of beams
        m_NR as Long               '        Ident 0
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance to start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial comp stress
        m_SIGU as Single           ' [1092] uniaxial tens stress
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling intensity
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
      END TYPE

      TYPE CBSCT_STC               ' 145/LC:0  Maximum stresses in cross-section of beams
        m_NR as Long               '        Ident 0
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance to start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial comp stress
        m_SIGU as Single           ' [1092] uniaxial tens stress
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling intensity
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
      END TYPE

      TYPE CBEAM_TST               ' 105/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        100000 + material number as in BSCT_STC
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 128,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBSLN_TST               ' 125/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        100000 + material number as in BSCT_STC
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 128,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBSCT_TST               ' 145/LC:+  thermal eigen stress per material
        m_NR as Long               '        element number
        m_MNRX as Long             '        100000 + material number as in BSCT_STC
        m_X as Single              ' [1001] distance from start
        m_TS(1 to 128,1 to 2) as Single ' [1092] Eigenstress table (z,sig)
      END TYPE

      TYPE CBEAM_STR               ' 105/LC:+  Stresses in cross-section of beams
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial stress up
        m_SIGU as Single           ' [1092] uniaxial stress down
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling effects
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
        m_RCTRL as Single          '        control value of stress/strain description
        m_ES0 as Single            '        strain in center of total section
        m_ESY as Single            '        strain gradient in y-direction
        m_ESZ as Single            '        strain gradient in z-direction
        m_YC as Single             ' [1011] location of center of partial section
        m_ZC as Single             ' [1011] location of center of partial section
        m_ESW as Single            '        factor for unit warping
        m_VYF as Single            ' [1102] shear force
        m_VZF as Single            ' [1102] shear force
        m_MTF as Single            ' [1103] primary torsional moment
        m_MT2F as Single           ' [1103] secondary torsional moment
      END TYPE

      TYPE CBSLN_STR               ' 125/LC:+  Stresses in cross-section of beams
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial stress up
        m_SIGU as Single           ' [1092] uniaxial stress down
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling effects
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
        m_RCTRL as Single          '        control value of stress/strain description
        m_ES0 as Single            '        strain in center of total section
        m_ESY as Single            '        strain gradient in y-direction
        m_ESZ as Single            '        strain gradient in z-direction
        m_YC as Single             ' [1011] location of center of partial section
        m_ZC as Single             ' [1011] location of center of partial section
        m_ESW as Single            '        factor for unit warping
        m_VYF as Single            ' [1102] shear force
        m_VZF as Single            ' [1102] shear force
        m_MTF as Single            ' [1103] primary torsional moment
        m_MT2F as Single           ' [1103] secondary torsional moment
      END TYPE

      TYPE CBSCT_STR               ' 145/LC:+  Stresses in cross-section of beams
        m_NR as Long               '        beamnumber
        m_MNR as Long              '        materialnumber
        m_X as Single              ' [1001] distance from start
        m_SIGC as Single           ' [1092] compressive stress
        m_SIGT as Single           ' [1092] tensile stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGV as Single           ' [1092] reference stress
        m_SI as Single             ' [1092] main tension stress
        m_SII as Single            ' [1092] main compress stress
        m_SIGO as Single           ' [1092] uniaxial stress up
        m_SIGU as Single           ' [1092] uniaxial stress down
        m_DSIG as Single           ' [1092] sway of normal stress
        m_DTAU as Single           ' [1092] sway of shear stress
        m_SIGW as Single           ' [1092] stress in weldings
        m_VB as Single             ' [1153] Bond force
        m_BUCK as Single           '        buckling effects
        m_I_14 as Single           '        reserved
        m_SIGCT as Single          ' [1092] decompression stress
        m_RCTRL as Single          '        control value of stress/strain description
        m_ES0 as Single            '        strain in center of total section
        m_ESY as Single            '        strain gradient in y-direction
        m_ESZ as Single            '        strain gradient in z-direction
        m_YC as Single             ' [1011] location of center of partial section
        m_ZC as Single             ' [1011] location of center of partial section
        m_ESW as Single            '        factor for unit warping
        m_VYF as Single            ' [1102] shear force
        m_VZF as Single            ' [1102] shear force
        m_MTF as Single            ' [1103] primary torsional moment
        m_MT2F as Single           ' [1103] secondary torsional moment
      END TYPE

      TYPE CBEAM_RF0               ' 106/DC:0  max. values of reinforcement
        m_NR as Long               '        identifier 0
        m_NVERS as Long            '        Version number
        m_ASLMAX as Single         ' [1021] maximum longitudinal reinforcement
        m_ASBMAX as Single         ' [1021] maximum of transverse reinforcement reinforcement
        m_VMMAX as Single          ' [1001] maximum of shift rule offset
        m_RESERVED(1 to 12) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CBSLN_RF0               ' 126/DC:0  max. values of reinforcement
        m_NR as Long               '        identifier 0
        m_NVERS as Long            '        Version number
        m_ASLMAX as Single         ' [1021] maximum longitudinal reinforcement
        m_ASBMAX as Single         ' [1021] maximum of transverse reinforcement reinforcement
        m_VMMAX as Single          ' [1001] maximum of shift rule offset
        m_RESERVED(1 to 12) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CBSCT_RF0               ' 146/DC:0  max. values of reinforcement
        m_NR as Long               '        identifier 0
        m_NVERS as Long            '        Version number
        m_ASLMAX as Single         ' [1021] maximum longitudinal reinforcement
        m_ASBMAX as Single         ' [1021] maximum of transverse reinforcement reinforcement
        m_VMMAX as Single          ' [1001] maximum of shift rule offset
        m_RESERVED(1 to 12) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CTRUS_RF0               ' 156/DC:0  max. values of reinforcement
        m_NR as Long               '        identifier 0
        m_NVERS as Long            '        Version number
        m_ASLMAX as Single         ' [1021] maximum longitudinal reinforcement
        m_ASBMAX as Single         ' [1021] maximum of transverse reinforcement reinforcement
        m_VMMAX as Single          ' [1001] maximum of shift rule offset
        m_RESERVED(1 to 12) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CCABL_RF0               ' 166/DC:0  max. values of reinforcement
        m_NR as Long               '        identifier 0
        m_NVERS as Long            '        Version number
        m_ASLMAX as Single         ' [1021] maximum longitudinal reinforcement
        m_ASBMAX as Single         ' [1021] maximum of transverse reinforcement reinforcement
        m_VMMAX as Single          ' [1001] maximum of shift rule offset
        m_RESERVED(1 to 12) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CBEAM_RFI               ' 106/DC:+  info of reinforcement of beam
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        info id = 0
        m_X as Single              ' [1001] distance from start
        m_ASL(1 to 10,1 to 2) as Long '        infos for longitudinal layers 0:9
        m_ASV(1 to 15,1 to 2) as Long '        infos for transverse reinforcement layers 1:15
      END TYPE

      TYPE CBSLN_RFI               ' 126/DC:+  info of reinforcement of design element sect.
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        info id = 0
        m_X as Single              ' [1001] distance from start
        m_ASL(1 to 10,1 to 2) as Long '        infos for longitudinal layers 0:9
        m_ASV(1 to 15,1 to 2) as Long '        infos for transverse reinforcement layers 1:15
      END TYPE

      TYPE CBSCT_RFI               ' 146/DC:+  info of reinforcement of external section
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        info id = 0
        m_X as Single              ' [1001] distance from start
        m_ASL(1 to 10,1 to 2) as Long '        infos for longitudinal layers 0:9
        m_ASV(1 to 15,1 to 2) as Long '        infos for transverse reinforcement layers 1:15
      END TYPE

      TYPE CTRUS_RFI               ' 156/DC:+  info of reinforcement of truss
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        info id = 0
        m_X as Single              ' [1001] distance from start
        m_ASL(1 to 10,1 to 2) as Long '        infos for longitudinal layers 0:9
        m_ASV(1 to 15,1 to 2) as Long '        infos for transverse reinforcement layers 1:15
      END TYPE

      TYPE CCABL_RFI               ' 166/DC:+  info of reinforcement of cables
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        info id = 0
        m_X as Single              ' [1001] distance from start
        m_ASL(1 to 10,1 to 2) as Long '        infos for longitudinal layers 0:9
        m_ASV(1 to 15,1 to 2) as Long '        infos for transverse reinforcement layers 1:15
      END TYPE

      TYPE CBEAM_RFC               ' 106/DC:+  reinforcement of beam
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        section number
        m_X as Single              ' [1001] distance from start
        m_ASUM as Single           ' [1020] Total longitudinal reinforcement
        m_ATOR as Single           ' [1021] maximum of torsional reinforcement
        m_ASL(1 to 10) as Single   ' [1020] Area of layer 0:9
        m_VM as Single             ' [1001] shift rule offset
        m_ASBMAX as Single         ' [1021] maximum of all transverse reinforcement areas
        m_ASB(1 to 15,1 to 2) as Single ' [1021] transverse reinforcements
      END TYPE

      TYPE CBSLN_RFC               ' 126/DC:+  reinforcement of design element section
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        section number
        m_X as Single              ' [1001] distance from start
        m_ASUM as Single           ' [1020] Total longitudinal reinforcement
        m_ATOR as Single           ' [1021] maximum of torsional reinforcement
        m_ASL(1 to 10) as Single   ' [1020] Area of layer 0:9
        m_VM as Single             ' [1001] shift rule offset
        m_ASBMAX as Single         ' [1021] maximum of all transverse reinforcement areas
        m_ASB(1 to 15,1 to 2) as Single ' [1021] transverse reinforcements
      END TYPE

      TYPE CBSCT_RFC               ' 146/DC:+  reinforcement of external section
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        section number
        m_X as Single              ' [1001] distance from start
        m_ASUM as Single           ' [1020] Total longitudinal reinforcement
        m_ATOR as Single           ' [1021] maximum of torsional reinforcement
        m_ASL(1 to 10) as Single   ' [1020] Area of layer 0:9
        m_VM as Single             ' [1001] shift rule offset
        m_ASBMAX as Single         ' [1021] maximum of all transverse reinforcement areas
        m_ASB(1 to 15,1 to 2) as Single ' [1021] transverse reinforcements
      END TYPE

      TYPE CTRUS_RFC               ' 156/DC:+  reinforcement of truss
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        section number
        m_X as Single              ' [1001] distance from start
        m_ASUM as Single           ' [1020] Total longitudinal reinforcement
        m_ATOR as Single           ' [1021] maximum of torsional reinforcement
        m_ASL(1 to 10) as Single   ' [1020] Area of layer 0:9
        m_VM as Single             ' [1001] shift rule offset
        m_ASBMAX as Single         ' [1021] maximum of all transverse reinforcement areas
        m_ASB(1 to 15,1 to 2) as Single ' [1021] transverse reinforcements
      END TYPE

      TYPE CCABL_RFC               ' 166/DC:+  reinforcement of cables
        m_NR as Long               '        beamnumber
        m_NQ as Long               '        section number
        m_X as Single              ' [1001] distance from start
        m_ASUM as Single           ' [1020] Total longitudinal reinforcement
        m_ATOR as Single           ' [1021] maximum of torsional reinforcement
        m_ASL(1 to 10) as Single   ' [1020] Area of layer 0:9
        m_VM as Single             ' [1001] shift rule offset
        m_ASBMAX as Single         ' [1021] maximum of all transverse reinforcement areas
        m_ASB(1 to 15,1 to 2) as Single ' [1021] transverse reinforcements
      END TYPE

      TYPE CBEAM_DE0               ' 107/LC:0  max. values of Ultimate/Plastic Design results
        m_NR as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBSLN_DE0               ' 127/LC:0  max. values of Ultimate/Plastic Design results
        m_NR as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBSCT_DE0               ' 147/LC:0  max. values of Ultimate/Plastic Design results
        m_NR as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CTRUS_DE0               ' 157/LC:0  max. values of Ultimate/Plastic Design results
        m_NR as Long               '        identifier 0
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBEAM_DES               ' 107/LC:+  Ultimate/Plastic Design results
        m_NR as Long               '        elementnumber
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBSLN_DES               ' 127/LC:+  Ultimate/Plastic Design results
        m_NR as Long               '        elementnumber
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBSCT_DES               ' 147/LC:+  Ultimate/Plastic Design results
        m_NR as Long               '        elementnumber
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CTRUS_DES               ' 157/LC:+  Ultimate/Plastic Design results
        m_NR as Long               '        elementnumber
        m_X as Single              ' [1001] distance from start
        m_NI as Single             ' [1101] Inner normal force
        m_MYI as Single            ' [1104] bending moment My
        m_MZI as Single            ' [1104] bending moment My
        m_SCF as Single            '        relative capacity
        m_E0 as Single             ' [   9] strain at center
        m_EY as Single             ' [1009] curvature y direct.
        m_EZ as Single             ' [1009] curvature z direct.
        m_E1 as Single             ' [   9] compressive strain
        m_E2 as Single             ' [   9] tensional   strain
        m_HL as Single             ' [1011] lever of forces
        m_HVM as Single            ' [1001] shift rule value
        m_HX as Single             ' [1001] height of compression zone   (NSTR-Analysis)
        m_EDCMIN as Single         ' [   9] minimum decompression strain (NSTR-Analysis)
        m_EDCMAX as Single         ' [   9] maximum decompression strain (NSTR-Analysis)
        m_FCHK as Single           ' [1092] not used
        m_TCF as Single            '        total utilisation level (all effects)
        m_SCN as Single            '        utilisation level  (1) N/Npl
        m_SCVY as Single           '        utilisation level  (2) Vy/Vypl
        m_SCVZ as Single           '        utilisation level  (3) Vz/Vzpl
        m_SCMT as Single           '        utilisation level  (4) Mt/Mtpl
        m_SCMY as Single           '        utilisation level  (5) My/Mypl
        m_SCMZ as Single           '        utilisation level  (6) Mz/Mzpl
        m_SCMB as Single           '        utilisation level  (7) Mb/Mbpl
        m_SCT2 as Single           '        utilisation level  (8) Mt2/Mt2pl
        m_SCCOMB as Single         '        utilisation level  (9) TOTAL INTERACTION
        m_SCBN as Single           '        utilisation level (10) buckling / torsional buckling
        m_CSIGC as Single          '        utilisation level (11) sig-c/fy
        m_CSIGT as Single          '        utilisation level (12) sig-t/fy
        m_CTAU as Single           '        utilisation level (13) tau/tauy
        m_CSGV as Single           '        utilisation level (14) sigv/fy (von Mises)
        m_CSGR as Single           '        utilisation level (15) sig-s (tendon/reinforc.stress)
        m_CAS as Single            '        utilisation level (16) As/As-provided (long.Reinforc)
        m_CASL as Single           '        utilisation level (17) Asv/Asv-provided (transverse reinf)
        m_CCW as Single            '        utilisation level (18) As/As-provided for crack width
        m_CSGD as Single           '        utilisation level (19) sig-d (dynamic stress range)
        m_CTAU0 as Single          '        utilisation level (20) tau0  (Nachweisgrenzen)
        m_C2T as Single            '        utilisation level (21) plate slenderness (c/t)
        m_CLASS as Single          '        highest criteria for section class
      END TYPE

      TYPE CBEAM_PIF               ' 108/LC  reducing factors of stiffness
        m_NR as Long               '        pilenumber
        m_REDP as Single           '        reducing factor of stiffness
        m_REDA as Single           '        reducing factor of axial bedding
        m_REDQ as Single           '        reducing factor of cross bedding
      END TYPE

      TYPE CBEAM_HR0               ' 111/LC:0  Maximum of Implicit Hinge Reactions
        m_ID as Long               '        identifier 0
        m_TYP as Long              '        type of hinge
        m_IBIT(1 to 2) as Long     '        reserved
        m_X as Single              ' [1001] max. beam length
        m_REAC as Single           '        extremal reaction force/ moment
        m_STV(1 to 4) as Single    '        extremal values of statevar's
      END TYPE

      TYPE CBEAM_HRC               ' 111/LC:+  Implicit Hinge Reactions
        m_NR as Long               '        beamnumber
        m_TYP as Long              '        type of hinge
        m_IBIT(1 to 2) as Long     '        reserved
        m_X as Single              ' [1001] hinge location, beam abscissa value
        m_REAC as Single           '        reaction force/ moment
        m_STV(1 to 4) as Single    '        statevar's
      END TYPE

      TYPE CBEAM_MP0               ' 115/LC:0  Extremal values of cross-sectional material point reactions
        m_NR as Long               '        identifier 0
        m_TYPE as Long             '        type: reinforcement=1, base material point=0
        m_MNO as Long              '        material number
        m_MRF as Long              '        material number reinforcement
        m_NPTS as Long             '        number of base material points
        m_NRF as Long              '        Anzahl Materialpunkte Bewehrung
        m_X as Single              ' [1001] max. beam length
        m_Y as Single              ' [1011] max. y-ccordinate
        m_Z as Single              ' [1011] max. z-ccordinate
        m_SIGX as Single           ' [1092] axial normal stress
        m_TAUXY as Single          ' [1092] shear stress xy
        m_TAUXZ as Single          ' [1092] shear stress xz
        m_F0 as Single             '        utilization level
        m_KAPAP as Single          ' [   9] equiv. plastic strain
        m_KAPAD as Single          ' [   9] fracturing strain
        m_CCW as Single            ' [1026] current crack opening
        m_TEMP as Single           ' [   6] current temperature
        m_TEMPMAX as Single        ' [   6] maximum temperature in loading history
        m_EPS_S as Single          ' [   9] pure reinforcement strain (without TS strain correction)
        m_EPS_TS as Single         ' [   9] tension stiffening strain correction (accumulated)
        m_DUMMY as Single          '        unused
        m_IZONE as Single          '        performance interval
        m_EPST as Single           ' [   9] axial temperature strain
        m_EPSX as Single           ' [   9] axial total strain (without temperature strain)
        m_A_MPT as Single          ' [1012] associated material point area
        m_FC_TEMP as Single        ' [1092] current compressive strength (temperature dependent)
        m_FT_TEMP as Single        ' [1092] current tensile strength (temperature dependent)
      END TYPE

      TYPE CBEAM_MPT               ' 115/LC:+  Cross-sectional material point reactions
        m_NR as Long               '        beam number
        m_TYPE as Long             '        type: reinforcement=1, base material point=0
        m_MNO as Long              '        material number
        m_MRF as Long              '        material number reinforcement
        m_NPTS as Long             '        number of base material points
        m_NRF as Long              '        Anzahl Materialpunkte Bewehrung
        m_X as Single              ' [1001] beam abscissa value
        m_Y as Single              ' [1011] cross-sectional y-position
        m_Z as Single              ' [1011] cross-sectional z-position
        m_SIGX as Single           ' [1092] axial normal stress
        m_TAUXY as Single          ' [1092] shear stress xy
        m_TAUXZ as Single          ' [1092] shear stress xz
        m_F0 as Single             '        utilization level
        m_KAPAP as Single          ' [   9] equiv. plastic strain
        m_KAPAD as Single          ' [   9] fracturing strain
        m_CCW as Single            ' [1026] current crack opening
        m_TEMP as Single           ' [   6] current temperature
        m_TEMPMAX as Single        ' [   6] maximum temperature in loading history
        m_EPS_S as Single          ' [   9] pure reinforcement strain (without TS strain correction)
        m_EPS_TS as Single         ' [   9] tension stiffening strain correction (accumulated)
        m_DUMMY as Single          '        unused
        m_IZONE as Single          '        performance interval
        m_EPST as Single           ' [   9] axial temperature strain
        m_EPSX as Single           ' [   9] axial total strain (without temperature strain)
        m_A_MPT as Single          ' [1012] associated material point area
        m_FC_TEMP as Single        ' [1092] current compressive strength (temperature dependent)
        m_FT_TEMP as Single        ' [1092] current tensile strength (temperature dependent)
      END TYPE

      TYPE CTRUS                   ' 150/00  trusselements
        m_NR as Long               '        truss number
        m_NODE(1 to 2) as Long     '        nodenumbers
        m_NRQ as Long              '        cross-section number
        m_T(1 to 3) as Single      '        normal direction
        m_DL as Single             ' [1001] length of truss
        m_PRE as Single            ' [1101] prestress
        m_GAP as Single            ' [1003] slip of element
        m_RISS as Single           ' [1101] max tension force
        m_FLIE as Single           ' [1101] yielding load
        m_NREF as Long             '        reference axis
      END TYPE

      TYPE CTRUS_LOA               ' 151/LC  Loads on truss elements
        m_NR as Long               '        truss number
        m_TYP as Long              '        type of load
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
      END TYPE

      TYPE CTRUS_RE0               ' 152/LC:0  maximum of results of truss elements
        m_NR as Long               '        identifier 0
        m_N as Single              ' [1101] normal force
        m_V as Single              ' [1003] axial displacement
      END TYPE

      TYPE CTRUS_RES               ' 152/LC:+  results of truss elements
        m_NR as Long               '        truss number
        m_N as Single              ' [1101] normal force
        m_V as Single              ' [1003] axial displacement
        m_LEX as Single            '        nonlinear effect
        m_DAMM(1 to 6) as Single   '        Damage Parameter
      END TYPE

      TYPE CTRUS_ST0               ' 155/LC:0  checked truss stresses
        m_NR as Long               '        ident 0
        m_MAT as Long              '        Materialnumber
        m_SIG as Single            ' [1092] normal stress
        m_BUCK as Single           '        buckling intensity
      END TYPE

      TYPE CTRUS_STR               ' 155/LC:+  truss stress (AQB)
        m_NR as Long               '        trussingnumber
        m_MAT as Long              '        Materialnumber
        m_SIG as Single            ' [1092] normal stress
        m_BUCK as Single           '        buckling intensity
      END TYPE

      TYPE CCABL                   ' 160/00  cable elements
        m_NR as Long               '        cable number
        m_NODE(1 to 2) as Long     '        nodenumbers
        m_NRQ as Long              '        cross-section number
        m_T(1 to 3) as Single      '        normal direction
        m_DL as Single             ' [1001] length of cable
        m_PRE as Single            ' [1101] prestress
        m_GAP as Single            ' [1003] slip of element
        m_RISS as Single           ' [1101] max tension force
        m_FLIE as Single           ' [1101] yielding load
        m_NREF as Long             '        reference axis
      END TYPE

      TYPE CCABL_LOA               ' 161/LC  loads on cables
        m_NR as Long               '        cable number
        m_TYP as Long              '        type of load
        m_PA as Single             '        start value of load
        m_PE as Single             '        end value of load
      END TYPE

      TYPE CCABL_RE0               ' 162/LC:0  maximum results of cables
        m_NR as Long               '        identifier 0
        m_N as Single              ' [1101] normal force
        m_V as Single              ' [1003] axial displacement
        m_VT as Single             ' [1003] maximum suspension of cable across axis
        m_VTX as Single            ' [1003] suspension of cable, global X-component
        m_VTY as Single            ' [1003] suspension of cable, global Y-component
        m_VTZ as Single            ' [1003] suspension of cable, global Z-component
        m_EPS0 as Single           '        maximum induced strain
      END TYPE

      TYPE CCABL_RES               ' 162/LC:+  results of cables
        m_NR as Long               '        cablenumber
        m_N as Single              ' [1101] normal force
        m_V as Single              ' [1003] axial displacement
        m_VQ as Single             ' [1003] maximum suspension of cable across axis
        m_VTX as Single            ' [1003] suspension of cable, global X-component
        m_VTY as Single            ' [1003] suspension of cable, global Y-component
        m_VTZ as Single            ' [1003] suspension of cable, global Z-component
        m_EPS0 as Single           '        Total induced strain
        m_N_M as Single            ' [1101] average normal force
        m_F0 as Single             ' [1003] vertical suspension of cable in load direction
        m_L0 as Single             ' [1001] relaxed cable length incl. temp. and prestrain effects
        m_LEX as Single            '        nonlinear effect
        m_EFFS as Single           '        effective stiffness factor due to cable sagging
        m_DAMM(1 to 6) as Single   '        Damage Parameter
      END TYPE

      TYPE CCABL_SLP               ' 163/00  slip cables
        m_NRSL as Long             '        slip cable number
        m_NRG as Long              '        group number
        m_NREL as Long             '        element number
        m_FREE as Long             '        free
        m_MUE as Single            '        friction value
      END TYPE

      TYPE CCABL_ST0               ' 165/LC:0  checked cable stresses
        m_NR as Long               '        ident 0
        m_MAT as Long              '        Materialnumber
        m_SIG as Single            ' [1092] normal stress
      END TYPE

      TYPE CCABL_STR               ' 165/LC:+  cable stresses (AQB)
        m_NR as Long               '        trussingnumber
        m_MAT as Long              '        Materialnumber
        m_SIG as Single            ' [1092] normal stress
      END TYPE

      TYPE CSPRI                   ' 170/00  Spring-elements
        m_NR as Long               '        springnumber
        m_NODE(1 to 2) as Long     '        start nodenumber
        m_NRQ as Long              '        Material/section no
        m_T(1 to 3) as Single      '        normal direction
        m_AREF as Single           '        reference area
        m_CP as Single             ' [1095] spring stiffness
        m_CQ as Single             ' [1095] transverse stiff.
        m_CM as Single             ' [1098] torsional stiff.
        m_PRE as Single            '        prestress
        m_GAP as Single            '        slip/gap of spring
        m_RISS as Single           '        max tension force
        m_FLIE as Single           '        yielding load
        m_MUE as Single            '        friction cross
        m_COH as Single            '        cohesion cross
        m_DIL as Single            '        dilatancy factor
        m_GAPQ as Single           '        transverse slip/gap
        m_DP as Single             '        damping constant
        m_DQ as Single             '        damping shear
        m_DM as Single             '        damping moment
        m_EXPP as Single           '        exponent for nonlinear damping dp**expp
        m_EXPQ as Single           '        exponent for nonlinear damping dq**expq
        m_EXPM as Single           '        exponent for nonlinear damping dm**expm
        m_TB(1 to 3) as Single     '        rotational direction
        m_NREF as Long             '        additional bit code
      END TYPE

      TYPE CSPRI_RE0               ' 170/LC:0  maximum of results of spring-elements
        m_ID as Long               '        identifier
        m_P as Single              ' [1151] maximum spring force
        m_PT as Single             ' [1151] maximum spring transverse force
        m_PTX as Single            ' [1151] maximum global X-shear component
        m_PTY as Single            ' [1151] maximum global Y-shear component
        m_PTZ as Single            ' [1151] maximum global Z-shear component
        m_M as Single              ' [1152] maximum spring moment
        m_V as Single              ' [1003] maximum axial displacement
        m_VT as Single             ' [1003] maximum transverse displacement
        m_VTX as Single            ' [1003] maximum trans displ., global X-component
        m_VTY as Single            ' [1003] maximum trans displ., global Y-component
        m_VTZ as Single            ' [1003] maximum trans displ., global Z-component
        m_PHI as Single            ' [1004] rotation
      END TYPE

      TYPE CSPRI_RES               ' 170/LC:+  results of spring-elements
        m_NR as Long               '        springnumber
        m_P as Single              ' [1151] spring force
        m_PT as Single             ' [1151] spring transforce
        m_PTX as Single            ' [1151] global X-shear component
        m_PTY as Single            ' [1151] global Y-shear component
        m_PTZ as Single            ' [1151] global Z-shear component
        m_M as Single              ' [1152] spring moment
        m_V as Single              ' [1003] axial displacement
        m_VT as Single             ' [1003] trans. displacement
        m_VTX as Single            ' [1003] trans. displacement, global X-component
        m_VTY as Single            ' [1003] trans. displacement, global Y-component
        m_VTZ as Single            ' [1003] trans. displacement, global Z-component
        m_PHI as Single            ' [1004] rotation
        m_LEX as Single            '        nonlinear effect
        m_STVP(1 to 10) as Single  '        State variable / Damage Parameter for CP
        m_STVM(1 to 10) as Single  '        State variable / Damage Parameter for CM
        m_STVT(1 to 10) as Single  '        State variable / Damage Parameter for CT
      END TYPE

      TYPE CDAMP                   ' 171/00  Damping elements (DYNA)
        m_NR as Long               '        element number
        m_NODE(1 to 2) as Long     '        nodenumbers
        m_I_3 as Long
        m_T(1 to 3) as Single      '        normal direction
        m_AREF as Single           '        reference area
        m_DP as Single             '        damping constant
        m_DQ as Single             '        damping shear
        m_DM as Single             '        damping moment
        m_EXPP as Single           '        exponent for nonlinear damping dp**expp
        m_EXPQ as Single           '        exponent for nonlinear damping dq**expq
        m_EXPM as Single           '        exponent for nonlinear damping dm**expm
      END TYPE

      TYPE CMASS                   ' 172/00  Persistent Nodal masses
        m_NR as Long               '        nodenumber
        m_NRG as Long              '        pseudoelementnumber IGDIV*Groupnr+IREF
        m_MT(1 to 3) as Single     ' [  52] transversal mass mt-x,mt-y,mt-z
        m_MR(1 to 6) as Single     ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        m_MB(1 to 7) as Single     '        warping  mass and higher coefficients
      END TYPE

      TYPE CMASS_ADD               ' 172/01  non persistent additional nodal masses
        m_NR as Long               '        nodenumber
        m_NRG as Long              '        pseudoelementnumber IGDIV*Groupnr+IREF
        m_MT(1 to 3) as Single     ' [  52] transversal mass mt-x,mt-y,mt-z
        m_MR(1 to 6) as Single     ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        m_MB(1 to 7) as Single     '        warping  mass and higher coefficients
      END TYPE

      TYPE CMASS_EFF               ' 172/LD:Z+  Effective nodal masses
        m_NR as Long               '        identifier
        m_MT(1 to 3) as Single     ' [  52] transversal mass mt-x,mt-y,mt-z
        m_MR(1 to 3) as Single     ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz
      END TYPE

      TYPE CMASS_EFC               ' 172/LD:-  Effective consistent masses
        m_NR as Long               '        identifier = negative number of nodes
        m_NODE(1 to 8) as Long     '        node numbers
        m_M(1 to 1176) as Single   '        mass matrix in triangular format
      END TYPE

const SPRI_WL0_LTYP_STD = 1
const SPRI_WL0_LTYP_IHNG = 2
const SPRI_WL0_LTYP_PMM = 3
const SPRI_WL0_MTYP_PLAS = 1
const SPRI_WL0_MTYP_PISO = 2
const SPRI_WL0_MTYP_HYPE = 3
const SPRI_WL0_MTYP_PKIN = 4
      TYPE CSPRI_WL0               ' 173/NR:0  (nonlinear) Spring material
        m_ID as Long               '        Identification = 0
        m_LTYP as Long             '        Type of link
        m_MTYP as Long             '        Type of law
        m_ICAP as Long             '        capacities from reference-section SNO
        m_IBIT2 as Long            '        reserved
        m_IHBIT as Long            '        Bitpattern of defined degrees of freedom for implicit hinges
        m_RLIM(1 to 2,1 to 7) as Single ' [1105] 
        m_ALPH as Single           '        Interpolation exponent My-Mz (PMM, only)
        m_PAR(1 to 16) as Single   '        further reserved material parameters
        m_TITLE(1 to 17) as Long   '        Designation
      END TYPE

const SPRI_WL_ID_CP = 1
const SPRI_WL_ID_CQ = 2
const SPRI_WL_ID_CM = 3
const SPRI_WL_ID_NX = 11
const SPRI_WL_ID_VY = 12
const SPRI_WL_ID_VZ = 13
const SPRI_WL_ID_MT = 14
const SPRI_WL_ID_MY = 15
const SPRI_WL_ID_MZ = 16
const SPRI_WL_ID_MB = 17
const SPRI_WL_NTYP_USER = 0
const SPRI_WL_NTYP_LIN = 1
const SPRI_WL_NTYP_BILIN = 2
const SPRI_WL_NTYP_TRILIN = 3
const SPRI_WL_NTYP_PLAS = 4
      TYPE CSPRI_WL                ' 173/NR:+  Worklaw for nonlinear Springs
        m_ID as Long               '        Identification
        m_NTYP as Long             '        Type of law
        m_PLVL as Single           ' [1101] Normal force reference level
        m_EUR as Single            '        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
        m_PAR(1 to 8) as Single    '        further reserved material parameters
        m_ARB(1 to 20,1 to 5) as Single '        Function values
      END TYPE

      TYPE CSPRI_MOV               ' 174/00  Moving Springs
        m_NR as Long               '        spring element number
        m_TYP as Long              '        searching criteria
        m_FROM as Long             '        selection for TYP
        m_TO as Long               '        selection for TYP
        m_INC as Long              '        selection for TYP
      END TYPE

      TYPE CS_MATRIX               ' 175/00  General systemmatrices
        m_NR as Long               '        element number
        m_TYP as Long              '        element type
        m_NDN as Long              '        number of degrees of freedom per node
        m_NODE(1 to 6) as Long     '        node numbers
        m_PER as Single            ' [  90] period of matrix
        m_S(1 to 2048) as Single   '        stiffness matrix
      END TYPE

      TYPE CBOUN                   ' 180/00:+  Boundary elements
        m_NR as Long               '        elementnumber
        m_NVON as Long             '        start nodenumber
        m_NBIS as Long             '        end nodenumber
        m_NDEL as Long             '        increment
        m_TYP as Long              '        type of bedding
        m_MESS as Long             '        direction of addition
        m_CA as Single             '        start constant of bedding
        m_CE as Single             '        end constant of bedding
        m_DXYZ(1 to 3) as Single   '        direction of bedding, X/Y/Z-component
        m_TEXT(1 to 17) as Long    '        Designation of element
      END TYPE

      TYPE CBOUN_RES               ' 180/LC  results of boundary elements
        m_NR as Long               '        element number
        m_NK as Long               '        nodenumber
        m_PX as Single             ' [1153] X-support force
        m_PY as Single             ' [1153] Y-support force
        m_PZ as Single             ' [1153] Z-support force
        m_MN as Single             ' [1154] support moment
      END TYPE

      TYPE CBOUN_SUM               ' 181/LC  resultant of boundary results
        m_NR as Long               '        element number
        m_PX as Single             ' [1151] X-support force
        m_PY as Single             ' [1151] X-support force
        m_PZ as Single             ' [1151] X-support force
        m_MN as Single             ' [1152] N-support moment
        m_MX as Single             ' [1152] X-support moment
        m_MY as Single             ' [1152] Y-support moment
        m_MZ as Single             ' [1152] Z-support moment
      END TYPE

      TYPE CBOUN_LC_LPT            '        node number + load value
        m_N as Long
        m_P as Single
      END TYPE

      TYPE CBOUN_LC                ' 183/LC  Info on loading on boundaries
        m_NR as Long               '        element number
        m_TYP as Long              '        type of load
        m_LPT(1 to 127) as CBOUN_LC_LPT '        node number + load value
      END TYPE

      TYPE CSPRI_SUM               ' 187/LC  Sum of forces of support springs
        m_NR as Long               '        group-number
        m_PX as Single             ' [1151] nodal support X
        m_PY as Single             ' [1151] nodal support Y
        m_PZ as Single             ' [1151] nodal support u
        m_MX as Single             ' [1152] support moment X
        m_MY as Single             ' [1152] support moment Y
        m_MZ as Single             ' [1152] support moment Z
        m_MB as Single             ' [1105] warping moment
      END TYPE

      TYPE CRSET                   ' 188/00:+  Sets of results
        m_ID as Long               '        number / identifier of result set
        m_NIT as Long              '        number of items in that result set
        m_TEXT(1 to 17) as Long    '        Designation of that set
      END TYPE

      TYPE CRSET_ITM               ' 188/00:0  Member of result set
        m_ID0 as Long              '        Identifier = 0
        m_ID(1 to 2) as Long       '        Short name of member for headdings
        m_IDS(1 to 2) as Long      '        Selector of main structure
        m_IDM(1 to 2) as Long      '        Selector of item member
        m_DIM as Long              '        enum of explicitly selected unit
        m_KWH as Long              '        main id of result data
        m_POS as Long              '        position of value in data (starting at zero)
        m_BIT as Long              '        bit pattern of defined selection data
        m_NR as Long               '        main number of result data
        m_NG as Long               '        second number of result data (e.g. group)
        m_ND1 as Long              '        reserved for additional selection data
        m_ND2 as Long              '        reserved for additional selection data
        m_ND3 as Long              '        reserved for additional selection data
        m_X as Single              '        selector for beam abscissae
      END TYPE

      TYPE CRSET_DAT               ' 188/LC  Result-values for sets of results
        m_ID as Long               '        identifier of result set
        m_VAL(1 to 255) as Single  '        result values
      END TYPE

      TYPE CLINK                   ' 179/00  link elements
        m_NR as Long               '        pipenumber
        m_NODE(1 to 2) as Long     '        nodenumbers
        m_NRQ as Long              '        material-, type- or cross-sectionnumber
        m_DL as Single             ' [1001] length of pipe
        m_A as Single              '        Nominal width or linear loss factor
        m_B as Single              '        Abs. Roughness or quadratic loss factor
        m_C as Single              '        specific storage coefficient
        m_EPS as Single            '        emission coefficient
        m_AREF as Single           ' [1002] reference area of element
      END TYPE

      TYPE CPIPE                   ' 190/00  pipes / armatures
        m_NR as Long               '        pipenumber
        m_NODE(1 to 2) as Long     '        nodenumbers
        m_NRQ as Long              '        material-, type- or cross-sectionnumber
        m_DL as Single             ' [1001] length of pipe
        m_A as Single              '        Nominal width or linear loss factor
        m_B as Single              '        Abs. Roughness or quadratic loss factor
        m_C as Single              '        specific storage coefficient
        m_EPS as Single            '        emission coefficient
        m_AREF as Single           ' [1002] reference area of element
      END TYPE

      TYPE CPIPE_RES               ' 190/LC  results of pipes
        m_NR as Long               '        pipenumber
        m_HA as Single             ' [1010] start potential
        m_HE as Single             ' [1010] end potential
        m_I as Single              '        gradient
        m_A as Single              ' [1012] flow area
        m_PA as Single             ' [  70] start compression
        m_PE as Single             ' [  70] end compression
        m_Q as Single              ' [1211] flow quantity
        m_V as Single              ' [1212] flow velocity
        m_R as Single              ' [1011] hydraulic radius
        m_K as Single              ' [1016] roughness
        m_RE as Single             '        Reynolds number
        m_FR as Single             '        Froud    number
      END TYPE

const LEN_CQUAD0 = 27
      TYPE CQUAD                   ' 200/00  QuadElements
        m_NR as Long               '        elementnumber
        m_NODE(1 to 4) as Long     '        nodenumbers
        m_MAT as Long              '        materialnumber
        m_MRF as Long              '        material Reinf.
        m_NRA as Long              '        type of element
        m_DET(1 to 3) as Single    '        Parameter of Jacobi Determinant
        m_THICK(1 to 5) as Single  ' [1010] element thickness
        m_CB as Single             '        bedding factor
        m_CQ as Single             '        tangential bedding factor
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
        m_IFC1 as Long             '        identifier of a most adjacent outer boundary
        m_DFC1(1 to 4) as Single   ' [1001] distance of the nodes to the boundary IFC1
        m_IFC2 as Long             '        identifier of a most adjacent inner boundary
        m_DFC2(1 to 4) as Single   ' [1001] distance of the nodes to the boundary IFC2
      END TYPE

      TYPE CQUAD_NOH               ' 200/1:0  unified properties of Quad-nodes
        m_ID1 as Long
        m_ID2 as Long
        m_NKREC as Long
        m_MAXNEL as Long
        m_MAXUGR as Long
        m_MAXGR as Long
        m_NQUAD as Long
        m_MQUAD as Long            '        Highest Number of Quadelement
      END TYPE

      TYPE CQUAD_NOM               ' 200/1:-  unified properties of Quad-nodes
        m_NGT as Long              '        groupselector
        m_NR as Long               '        nodenumber
        m_IEL(1 to 9999) as Long   '        connecting elements
      END TYPE

      TYPE CQUAD_NOD               ' 200/1:*  properties of Quad-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_D as Single              ' [1010] minimum thickness of plate on node
        m_T(1 to 3,1 to 3) as Single '        lokal average coordinate system
      END TYPE

      TYPE CQUAD_EDH               ' 200/2:0  Edges of Quad-elements
        m_ID1 as Long
        m_ID2 as Long
        m_NEDG as Long
        m_MQUA as Long             '        max number of quads per edge
      END TYPE

      TYPE CQUAD_EDG               ' 200/2:+  Edges of Quad-elements
        m_KA as Long               '        First Node
        m_KE as Long               '        Last Node
        m_IJMP as Long             '        bit pattern of jump condition
        m_NQUA as Long             '        number of quads
        m_NREL(1 to 9999) as Long  '        Number of Quad-elements
      END TYPE

      TYPE CQUAD_TEN               ' 200/5  tendons of Quad-elements
        m_NR as Long               '        elementnumber
        m_NRS as Long              '        tendon number
        m_MNR as Long              '        tendon material
        m_IBA1 as Long             '        construction stage number for placing
        m_IBA2 as Long             '        construction stage number for grouting
        m_IBA3 as Long             '        construction stage number for removing
        m_R(1 to 2) as Single      '        isoparametric coordinates start/end point
        m_S(1 to 2) as Single      '        isoparametric coordinates start/end point
        m_Z(1 to 2) as Single      ' [1011] eccentricity of the middle area
        m_ZZ(1 to 2) as Single     ' [1101] tendon force, start- and endpoint
        m_AZ as Single             ' [1020] area of tendon
        m_UZ as Single             ' [1023] effect. periphery
        m_AH as Single             ' [1020] area of duct
        m_AR as Single             ' [1012] relative area
        m_DY(1 to 2) as Single     '        gradient of tendon
        m_DZ(1 to 2) as Single     '        gradient of tendon
        m_EXZ(1 to 2) as Single    ' [1011] perpendicular eccentricity of duct to tendon
        m_EXY(1 to 2) as Single    ' [1011] transverse eccentricity of duct to tendon
        m_SREF(1 to 2) as Single   '        parameter values along tendon geometry
        m_XYZT(1 to 2,1 to 3) as Single ' [1001] Coordinates of tendon start & endpoint
        m_XYZH(1 to 2,1 to 3) as Single ' [1001] Coordinates of duct start & endpoint
      END TYPE

      TYPE CQUAD_RIM               ' 200/6  Prescribed Reinforcements of Quad-elements
        m_NRG as Long              '        group number
        m_NR as Long               '        selector number
        m_TYP as Long              '        Type of Reinforc.
        m_GTYP as Long             '        Type of grading
        m_IDRA as Long             '        drawing source type
        m_RIO as Single            ' [   5] direction of upside reinforcement
        m_RIOQ as Single           ' [   5] direction of upside cross reinforcement
        m_RIOI as Single           ' [   5] direction of upside third reinforcement
        m_RIU as Single            ' [   5] direction of downside reinforcement
        m_RIUQ as Single           ' [   5] direction of downside cross reinforcement
        m_RIUI as Single           ' [   5] direction of downside third reinforcement
        m_XREF as Single           ' [1001] Reference point for circular reinforcement
        m_YREF as Single           ' [1001] Reference point for circular reinforcement
        m_ZREF as Single           ' [1001] Reference point for circular reinforcement
        m_HIO as Single            ' [1024] distance of upside reinforcement
        m_HIOQ as Single           ' [1024] distance of upside cross reinforcement
        m_HIOI as Single           ' [1024] distance of upside third reinforcement
        m_HIU as Single            ' [1024] distance of downside reinforcement
        m_HIUQ as Single           ' [1024] distance of downside cross reinforcement
        m_HIUI as Single           ' [1024] distance of downside third reinforcement
        m_DIO as Single            ' [1023] Diameter of upside reinforcement
        m_DIOQ as Single           ' [1023] Diameter of upside cross reinforcement
        m_DIOI as Single           ' [1023] Diameter of upside third reinforcement
        m_DIU as Single            ' [1023] Diameter of downside reinforcement
        m_DIUQ as Single           ' [1023] Diameter of downside cross reinforcement
        m_DIUI as Single           ' [1023] Diameter of downside third reinforcement
        m_DSS as Single            ' [1023] Diameter of transverse reinforcement
        m_ASO as Single            ' [1021] upside Minimum reinforcement (outside)
        m_ASOQ as Single           ' [1021] upside cross Minimum reinforcement (middle)
        m_ASOI as Single           ' [1021] upside third Minimum reinforcement (inside)
        m_ASU as Single            ' [1021] downside Minimum reinforcement (outside)
        m_ASUQ as Single           ' [1021] downside cross Minimum reinforcement (middle)
        m_ASUI as Single           ' [1021] downside third Minimum reinforcement (inside)
        m_ASS as Single            ' [1022] Min stirrup cm2/m2
        m_AMO as Single            ' [1021] upside Maximum reinforcement (outside)
        m_AMOQ as Single           ' [1021] upside cross Maximum reinforcement (middle)
        m_AMOI as Single           ' [1021] upside third Maximum reinforcement (inside)
        m_AMU as Single            ' [1021] downside Maximum reinforcement (outside)
        m_AMUQ as Single           ' [1021] downside cross Maximum reinforcement (middle)
        m_AMUI as Single           ' [1021] downside third Maximum reinforcement (inside)
        m_AMS as Single            ' [1022] Max stirrup cm2/m2
        m_WK6(1 to 6) as Single    ' [1026] design crack width
        m_SIG6(1 to 6) as Single   ' [1092] SLS steel stress limit
      END TYPE

      TYPE CQUAD_RID               ' 200/7:0  Reinforcement Definitions of Quad-elements
        m_ID as Long               '        identifier (0 = Headder of a definition)
        m_NRG as Long              '        group number
        m_NR as Long               '        selector or element number
        m_BITS as Long             '        Type of grading
        m_ASS as Single            ' [1022] Min stirrup ratio
        m_AMS as Single            ' [1022] Max stirrup ratio
        m_DSS as Single            ' [1023] Diameter of stirrup reinforcements
        m_EXPP as Long             '        Exposition class at positive face
        m_EXPN as Long             '        Exposition class at negative face
      END TYPE

      TYPE CQUAD_RED               ' 270/0:0  Evaluated Reinforcement Definitions of Elements
        m_ID as Long               '        identifier (0 = Headder of a definition)
        m_NRG as Long              '        group number
        m_NR as Long               '        selector or element number
        m_BITS as Long             '        Type of grading
        m_ASS as Single            ' [1022] Min stirrup ratio
        m_AMS as Single            ' [1022] Max stirrup ratio
        m_DSS as Single            ' [1023] Diameter of stirrup reinforcements
        m_EXPP as Long             '        Exposition class at positive face
        m_EXPN as Long             '        Exposition class at negative face
      END TYPE

      TYPE CQUAD_RIL               ' 200/7:+  Reinforcement Layers of Quad-elements
        m_ID as Long               '        reference for this layer
        m_DIR as Long              '        Type of local x-direction
        m_ROT as Single            ' [   5] Angle with reference to the local x-direction
        m_XDIR as Single           ' [1001] Global reference direction or reference point
        m_YDIR as Single           ' [1001] Global reference direction or reference point
        m_ZDIR as Single           ' [1001] Global reference direction or reference point
        m_H as Single              ' [1011] effective distance according to ID-reference definition
        m_ASMIN as Single          ' [1021] Min reinforcement value
        m_ASMAX as Single          ' [1021] Max reinforcement value
        m_D as Single              ' [1023] Diameter of reinforcements
        m_SIG as Single            ' [1092] SLS steel stress limit for crack width (optional)
        m_CRW as Single            ' [1026] design crack width (optional)
      END TYPE

      TYPE CQUAD_REL               ' 270/0:+  Evaluated Reinforcement Definitions of Elements
        m_ID as Long               '        reference for this layer
        m_DIR as Long              '        Type of local x-direction
        m_ROT as Single            ' [   5] Angle with reference to the local x-direction
        m_XDIR as Single           ' [1001] Global reference direction or reference point
        m_YDIR as Single           ' [1001] Global reference direction or reference point
        m_ZDIR as Single           ' [1001] Global reference direction or reference point
        m_H as Single              ' [1011] effective distance according to ID-reference definition
        m_ASMIN as Single          ' [1021] Min reinforcement value
        m_ASMAX as Single          ' [1021] Max reinforcement value
        m_D as Single              ' [1023] Diameter of reinforcements
        m_SIG as Single            ' [1092] SLS steel stress limit for crack width (optional)
        m_CRW as Single            ' [1026] design crack width (optional)
      END TYPE

      TYPE CQCUT_0                 ' 200/8:0  Header for fabrication areas
        m_NR as Long               '        identifier = 0
        m_TYP as Long              '        identifier = 0
        m_NAR as Long              '        number of areas
        m_X as Single              ' [1001] x-center
        m_Y as Single              ' [1001] y-
        m_AR3D as Single           ' [1002] area in 3D
        m_AR2D as Single           ' [1002] area in 2D
        m_AR_0 as Single           ' [1002] area stressfree
      END TYPE

      TYPE CQCUT_NEW               ' 200/8:+  New cutting area
        m_NR as Long               '        areanumber
        m_TYP as Long              '        identifier = 0
        m_LF as Long               '        Loadcase
        m_X as Single              ' [1001] x-ordinate
        m_Y as Single              ' [1001] y- center(text)
        m_AR3D as Single           ' [1002] area in 3D
        m_AR2D as Single           ' [1002] area in 2D
        m_AR_0 as Single           ' [1002] area stressfree
      END TYPE

      TYPE CQCUT_DIR               ' 200/8:+  Material direction
        m_NR as Long               '        areanumber
        m_TYP as Long              '        Identification
        m_MNR as Long              '        material no
        m_ALF as Single            ' [   5] warp direction
        m_EMOD as Single           ' [1090] E Mod warp direction
        m_E90 as Single            ' [1090] Elasticity modulus perpendicular
      END TYPE

      TYPE CQCUT_OUT               ' 200/8:+  Vertex of geometric boundary
        m_NR as Long               '        areanumber
        m_TYP as Long              '        Identification
        m_LINE as Long             '        linetype
        m_X as Single              ' [1001] x-ordinate
        m_Y as Single              ' [1001] y-ordinate
      END TYPE

      TYPE CQCUT_IN                ' 200/8:+  Geometry inner lines
        m_NR as Long               '        areanumber
        m_TYP as Long              '        Identification
        m_I_2 as Long
        m_XA as Single             ' [1001] x  startpoint
        m_YA as Single             ' [1001] y  startpoint
        m_XE as Single             ' [1001] x  endpoint
        m_YE as Single             ' [1001] y  endpoint
      END TYPE

      TYPE CQCUT_WAR               ' 200/8:+  element warp direction
        m_NR as Long               '        areanumber
        m_TYP as Long              '        Identification
        m_NREL as Long             '        orig elem.no
        m_XA as Single             ' [1001] x  startpoint
        m_YA as Single             ' [1001] y  startpoint
        m_XE as Single             ' [1001] x  endpoint
        m_YE as Single             ' [1001] y  endpoint
        m_ALF as Single            ' [   5] warp direction
      END TYPE

      TYPE CTEXTILE                ' 200/9  definition of cutting lines
        m_IG as Long               '        group selector
        m_TYP as Long              '        type of line
        m_XA as Single             ' [1001] line point A
        m_YA as Single             ' [1001] 
        m_ZA as Single             ' [1001] 
        m_XE as Single             ' [1001] line point E
        m_YE as Single             ' [1001] 
        m_ZE as Single             ' [1001] 
        m_NX as Single             ' [1001] projection
        m_NY as Single             ' [1001] 
        m_NZ as Single             ' [1001] 
      END TYPE

      TYPE CQUAD_P                 ' 200/10  Quad-P-elements
        m_NR as Long               '        elementnumber
        m_NODE(1 to 4) as Long     '        nodenumbers
        m_MAT as Long              '        materialnumber
        m_MRF as Long              '        material Reinf.
        m_NRA as Long              '        type of element
        m_EDGE(1 to 4) as Long     '        No of geometric property of edge 1-2
        m_DET(1 to 3) as Single    '        Parameter of Jacobi Determinant
        m_THICK(1 to 5) as Single  ' [1010] element thickness
        m_CB as Single             '        bedding factor
        m_CQ as Single             '        tangential bedding factor
        m_T(1 to 3,1 to 3) as Single '        transformation matrix
      END TYPE

      TYPE CQUAD_LOA               ' 202/LC  Quad-element loads
        m_VON as Long              '        start elementnumber
        m_BIS as Long              '        end elementnumber
        m_DEL as Long              '        increment
        m_TYP as Long              '        type of load
        m_LNR as Long              '        special option value
        m_P as Single              '        load values
        m_DPDX as Single
        m_DPDY as Single
        m_DPDZ as Single
        m_XREF as Single           ' [1001] optional reference point for load value to
        m_YREF as Single           ' [1001] 
        m_ZREF as Single           ' [1001] 
        m_TFUN(1 to 16,1 to 2) as Single '        optional function of load values across the
      END TYPE

      TYPE CQUAD_LPI               ' 203/LC:*  internal single loads on Quad-elements
        m_NR as Long               '        element number
        m_TYP as Long              '        type of load
        m_PRZ as Single            ' [   8] Percentage of load covered with elements
        m_S as Single              '        load point in local coordinates
        m_T as Single              '        load point in local coordinates
        m_P as Single              '        load value
      END TYPE

      TYPE CQUAD_LLI               ' 203/LC:*  internal line loads of Quad-elements
        m_NR as Long               '        element number
        m_TYP as Long              '        type of load
        m_PRZ as Single            ' [   8] 
        m_SA as Single
        m_TA as Single
        m_PA as Single
        m_SB as Single
        m_TB as Single
        m_PB as Single             '        load value end point
      END TYPE

      TYPE CQUAD_LAI_LPT           '        load points in local coordinates
        m_S as Single
        m_T as Single
        m_P as Single
      END TYPE

      TYPE CQUAD_LAI               ' 203/LC:*  Free area loads on Quad-elements
        m_NR as Long               '        element number
        m_TYP as Long              '        type of load
        m_PRZ as Single            ' [   8] 
        m_LPT(1 to 63) as CQUAD_LAI_LPT '        load points in local coordinates
      END TYPE

      TYPE CQUAD_LT                ' 206/NR  Temperature load profiles for QUADs
        m_T as Single              ' [  90] Time value
        m_TEMP(1 to 20,1 to 5) as Single '        Temperature values
      END TYPE

      TYPE CQUAD_FOC               ' 210/LC:0  maximum forces of Quad elements
        m_NR as Long               '        ident 0 for maximum (first records)
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force
        m_VY as Single             ' [1111] shear force
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_HP1 as Single            '        yield function
        m_HP2 as Single            '        volum. hardening
      END TYPE

      TYPE CQUAD_FOR               ' 210/LC:+  forces of Quad-elements
        m_NR as Long               '        elementnumber
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force
        m_VY as Single             ' [1111] shear force
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_SG(1 to 4,1 to 8) as Single ' [1112] results in GAUSS-points
        m_HP1(1 to 5) as Single    '        yield function
        m_HP2(1 to 5) as Single    '        volum. hardening
        m_HP3(1 to 5) as Single    '        3rd parameter
      END TYPE

      TYPE CQUAD_NFC               ' 211/LC:0  maximum forces in nodes
        m_NG as Long               '        ident 0 for maximum (first records)
        m_NR as Long               '        ident 0 for maximum (first records)
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force
        m_VY as Single             ' [1111] shear force
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_VX_V as Single           ' [1111] shear force signed
        m_VY_V as Single           ' [1111] shear force signed
        m_HP1 as Single            '        yield function
      END TYPE

      TYPE CQUAD_NFO               ' 211/LC:Z+  Nodal Quad forces
        m_NG as Long               '        groupselector
        m_NR as Long               '        nodenumber
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force abs
        m_VY as Single             ' [1111] shear force abs
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_VX_V as Single           ' [1111] shear force signed
        m_VY_V as Single           ' [1111] shear force signed
        m_FY as Single             '        yield function
      END TYPE

      TYPE CQUAD_EFC               ' 212/LC:0  maximum error estimates for Quad-elements
        m_NR as Long               '        ident 0 for maximum (first records)
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force
        m_VY as Single             ' [1111] shear force
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_ERR as Single            '        error in energy
      END TYPE

      TYPE CQUAD_EFO               ' 212/LC:+  error estimates for Quad-elements
        m_NR as Long               '        elementnumber
        m_MXX as Single            ' [1114] bending moment
        m_MYY as Single            ' [1114] bending moment
        m_MXY as Single            ' [1113] torsion moment
        m_VX as Single             ' [1111] shear force
        m_VY as Single             ' [1111] shear force
        m_NX as Single             ' [1112] membran force
        m_NY as Single             ' [1112] membran force
        m_NXY as Single            ' [1112] membran force
        m_HOPT as Single           ' [1001] optimal mesh size
      END TYPE

      TYPE CQUAD_BEC               ' 213/LC:0  bedding stresses and results
        m_NR as Long               '        ident 0 for maximum (first records)
        m_PSE as Single            ' [1155] bedding centre
        m_PS(1 to 4) as Single     ' [1155] bedding in nodes
        m_PRE as Single            ' [1151] result bedd.force in centre
        m_PR(1 to 4) as Single     ' [1151] result bedd. values in Quad-nodes
        m_PVE as Single            ' [1003] bedding displacememts in centre
        m_PV(1 to 4) as Single     ' [1003] bedding displacements in nodes
        m_PTE as Single            ' [1155] tangential bedding in centre
        m_PT(1 to 4) as Single     ' [1155] tangential bedding in nodes
        m_PTXE as Single           ' [1155] tangential bedding in centre X-component
        m_PTX(1 to 4) as Single    ' [1155] tangential bedding in nodes X-component
        m_PTYE as Single           ' [1155] tangential bedding in centre Y-component
        m_PTY(1 to 4) as Single    ' [1155] tangential bedding in nodes Y-component
        m_PTZE as Single           ' [1155] tangential bedding in centre Z-component
        m_PTZ(1 to 4) as Single    ' [1155] tangential bedding in nodes Z-component
        m_RQ(1 to 12) as Single    ' [1151] resulting tangential bedding in nodes
      END TYPE

      TYPE CQUAD_BED               ' 213/LC:+  bedding stresses and results
        m_NR as Long               '        Quadelementnumber
        m_PSE as Single            ' [1155] bedding centre
        m_PS(1 to 4) as Single     ' [1155] bedding in nodes
        m_PRE as Single            ' [1151] result bedd.force in centre
        m_PR(1 to 4) as Single     ' [1151] result bedd. values in Quad-nodes
        m_PVE as Single            ' [1003] bedding displacememts in centre
        m_PV(1 to 4) as Single     ' [1003] bedding displacements in nodes
        m_PTE as Single            ' [1155] tangential bedding in centre
        m_PT(1 to 4) as Single     ' [1155] tangential bedding in nodes
        m_PTXE as Single           ' [1155] tangential bedding in centre X-component
        m_PTX(1 to 4) as Single    ' [1155] tangential bedding in nodes X-component
        m_PTYE as Single           ' [1155] tangential bedding in centre Y-component
        m_PTY(1 to 4) as Single    ' [1155] tangential bedding in nodes Y-component
        m_PTZE as Single           ' [1155] tangential bedding in centre Z-component
        m_PTZ(1 to 4) as Single    ' [1155] tangential bedding in nodes Z-component
        m_RQ(1 to 12) as Single    ' [1151] resulting tangential bedding in nodes
      END TYPE

      TYPE CQUAD_RFX               ' 214/LC  additional information for primary loadcases
        m_NR as Long               '        Quad-elementnumber
        m_EPS(1 to 8,1 to 5) as Single '        strain
        m_RISS(1 to 8,1 to 5) as Single '        directions of crack
      END TYPE

      TYPE CQUAD_RNC               ' 215/LC:0  nonlinear results of Quad-element
        m_NR as Long               '        ident 0 for maximum
        m_NMAT as Long             '        type of material behaviour
        m_ESXO as Single           ' [   9] upside strain
        m_ESYO as Single           ' [   9] upside strain
        m_EXYO as Single           ' [   9] upside strain
        m_ESMO as Single           ' [   9] upside reference strain
        m_ESXU as Single           ' [   9] downside strain
        m_ESYU as Single           ' [   9] downside strain
        m_EXYU as Single           ' [   9] downside strain
        m_ESMU as Single           ' [   9] downside reference strain
        m_SXO as Single            ' [1092] upside stress
        m_SYO as Single            ' [1092] upside stress
        m_SXYO as Single           ' [1092] upside stress
        m_SMO as Single            ' [1092] upside reference stress
        m_SXU as Single            ' [1092] downside stress
        m_SYU as Single            ' [1092] downside stress
        m_SXYU as Single           ' [1092] downside stress
        m_SM_U as Single           ' [1092] downside reference stress
        m_SGVO as Single           ' [1092] upside reference stress incl. shear
        m_SGVU as Single           ' [1092] downside reference stress incl. shear
        m_FY as Single             '        yield function
        m_FDO as Single            ' [1011] steel - upside yield depth
        m_FDU as Single            ' [1011] steel - downside yield depth
        m_I_22 as Single
        m_WR1O as Single           '        concrete - upside direction of crack 1
        m_WR1U as Single           '        concrete - downside direction of crack 1
        m_WR2O as Single           '        concrete - upside direction of crack 2
        m_WR2U as Single           '        concrete - downside direction of crack 2
        m_SGSO as Single           ' [1092] concrete - upside shear stress on crack
        m_SGSU as Single           ' [1092] concrete - downside shear stress on crack
        m_SG1O as Single           ' [1092] concrete - upside steel stress II,dir.1
        m_SG1U as Single           ' [1092] concrete - downside steel stress II,dir.1
        m_SG2O as Single           ' [1092] concrete - upside steel stress II,dir. 2
        m_SG2U as Single           ' [1092] concrete - downside steel stress II,dir.2
        m_W1O as Single            ' [1026] concrete - upside width of crack,direct. 1
        m_W1U as Single            ' [1026] concrete - downside width of crack,dir. 1
        m_W2O as Single            ' [1026] concrete - upside width of crack,direct. 2
        m_W2U as Single            ' [1026] concrete - downside width of crack,dir. 2
        m_BRO as Single            '        concrete -upside direction reinforcement
        m_BRU as Single            '        concrete -downs. direction reinforcement
        m_XD_X as Single           ' [1011] Minimum compression depth in local x axis
        m_XD_Y as Single           ' [1011] Minimum compression depth in local y axis
        m_XD_1 as Single           ' [1011] Minimum compression depth at least pressed uniaxial
        m_XD_2 as Single           ' [1011] Minimum compression depth pressed biaxial
        m_EPSB as Single           ' [   9] Maximum concrete compression strain
        m_EPSC as Single           ' [   9] Minimum averaged reinforcement strain
        m_EPST as Single           ' [   9] Maximum averaged reinforcement strain
        m_SIGC as Single           ' [1092] Maximum concrete compression stress
        m_SIGT as Single           ' [1092] Maximum concrete tension in the concrete layers
        m_EPSR as Single           ' [   9] Maximum reinforcement strain in the crack
      END TYPE

      TYPE CQUAD_RNO               ' 215/LC:+  nonlinear results of Quad-element
        m_NR as Long               '        Quad-elementnumber
        m_NMAT as Long             '        type of material behaviour
        m_ESXO as Single           ' [   9] upside strain
        m_ESYO as Single           ' [   9] upside strain
        m_EXYO as Single           ' [   9] upside strain
        m_ESMO as Single           ' [   9] upside reference strain
        m_ESXU as Single           ' [   9] downside strain
        m_ESYU as Single           ' [   9] downside strain
        m_EXYU as Single           ' [   9] downside strain
        m_ESMU as Single           ' [   9] downside reference strain
        m_SXO as Single            ' [1092] upside stress
        m_SYO as Single            ' [1092] upside stress
        m_SXYO as Single           ' [1092] upside stress
        m_SMO as Single            ' [1092] upside reference stress
        m_SXU as Single            ' [1092] downside stress
        m_SYU as Single            ' [1092] downside stress
        m_SXYU as Single           ' [1092] downside stress
        m_SM_U as Single           ' [1092] downside reference stress
        m_SGVO as Single           ' [1092] upside reference stress incl. shear
        m_SGVU as Single           ' [1092] downside reference stress incl. shear
        m_FY as Single             '        yield function
        m_FDO as Single            ' [1011] steel - upside yield depth
        m_FDU as Single            ' [1011] steel - downside yield depth
        m_I_22 as Single
        m_WR1O as Single           '        concrete - upside direction of crack 1
        m_WR1U as Single           '        concrete - downside direction of crack 1
        m_WR2O as Single           '        concrete - upside direction of crack 2
        m_WR2U as Single           '        concrete - downside direction of crack 2
        m_SGSO as Single           ' [1092] concrete - upside shear stress on crack
        m_SGSU as Single           ' [1092] concrete - downside shear stress on crack
        m_SG1O as Single           ' [1092] concrete - upside steel stress II,dir.1
        m_SG1U as Single           ' [1092] concrete - downside steel stress II,dir.1
        m_SG2O as Single           ' [1092] concrete - upside steel stress II,dir. 2
        m_SG2U as Single           ' [1092] concrete - downside steel stress II,dir.2
        m_W1O as Single            ' [1026] concrete - upside width of crack,direct. 1
        m_W1U as Single            ' [1026] concrete - downside width of crack,dir. 1
        m_W2O as Single            ' [1026] concrete - upside width of crack,direct. 2
        m_W2U as Single            ' [1026] concrete - downside width of crack,dir. 2
        m_BRO as Single            '        concrete -upside direction reinforcement
        m_BRU as Single            '        concrete -downs. direction reinforcement
        m_XD_X as Single           ' [1011] Minimum compression depth in local x axis
        m_XD_Y as Single           ' [1011] Minimum compression depth in local y axis
        m_XD_1 as Single           ' [1011] Minimum compression depth at least pressed uniaxial
        m_XD_2 as Single           ' [1011] Minimum compression depth pressed biaxial
        m_EPSB as Single           ' [   9] Maximum concrete compression strain
        m_EPSC as Single           ' [   9] Minimum averaged reinforcement strain
        m_EPST as Single           ' [   9] Maximum averaged reinforcement strain
        m_SIGC as Single           ' [1092] Maximum concrete compression stress
        m_SIGT as Single           ' [1092] Maximum concrete tension in the concrete layers
        m_EPSR as Single           ' [   9] Maximum reinforcement strain in the crack
      END TYPE

      TYPE CQUAD_STC               ' 220/LC:0  maximum Quad-stress
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SVXY as Single           ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_HP1 as Single            ' [1092] yield function
        m_HP2 as Single            '        2nd Parameter
        m_HP3 as Single            '        3rd Parameter
        m_HP4 as Single            '        4th Parameter
        m_HP5 as Single            '        5th Parameter
        m_HP6 as Single            '        6th Parameter
      END TYPE

      TYPE CQUAD_STP_HTYP          '        = state variables for nonlinear material
        m_ID as Long
        m_IDIM as Long
        m_MAXVAL as Single
      END TYPE

      TYPE CQUAD_STP               ' 220/LC:-  Nonlinear QUAD-stress Headder
        m_TYP as Long              '        enum of nonlinear parameters as in 1/NR:1/???
        m_HTYP(1 to 15) as CQUAD_STP_HTYP '        = state variables for nonlinear material
      END TYPE

      TYPE CBRIC_STP_HTYP          '        = state variables for nonlinear material
        m_ID as Long
        m_IDIM as Long
        m_MAXVAL as Single
      END TYPE

      TYPE CBRIC_STP               ' 310/LC:-  Nonlinear BRIC-stress Headder
        m_TYP as Long              '        enum of nonlinear parameters as in 1/NR:1/???
        m_HTYP(1 to 15) as CBRIC_STP_HTYP '        = state variables for nonlinear material
      END TYPE

      TYPE CQUAD_STR_SG            '        results in GAUSS-points
        m_SIGX as Single           ' [1092] 
        m_SIGY as Single           ' [1092] 
        m_TAU as Single            ' [1092] 
        m_SIGZ as Single           ' [1092] 
      END TYPE

      TYPE CQUAD_STR               ' 220/LC:+  stresses of Quad-element
        m_NR as Long               '        Elementnumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_SG(1 to 4) as CQUAD_STR_SG '        results in GAUSS-points
        m_PVX as Single            ' [1192] volume loading
        m_PVY as Single            ' [1192] volume loading
        m_PVT as Single            ' [   6] temperature loads
        m_HP1(1 to 5) as Single    '        yield function
        m_HP2(1 to 5) as Single    '        2nd parameter as specified in headder record
        m_HP3(1 to 5) as Single    '        3rd parameter as specified in headder record
        m_HP4(1 to 5) as Single    '        4th parameter as specified in headder record
        m_HP5(1 to 5) as Single    '        5th parameter as specified in headder record
        m_HP6(1 to 5) as Single    '        6th parameter as specified in headder record
        m_HP7(1 to 5) as Single    '        7th parameter as specified in headder record
        m_HP8(1 to 5) as Single    '        8th parameter as specified in headder record
        m_HP9(1 to 5) as Single    '        9th parameter as specified in headder record
        m_HP10(1 to 5) as Single   '        10th parameter as specified in headder record
        m_HP11(1 to 5) as Single   '        11th parameter as specified in headder record
        m_HP12(1 to 5) as Single   '        12th parameter as specified in headder record
        m_HP13(1 to 5) as Single   '        13th parameter as specified in headder record
        m_HP14(1 to 5) as Single   '        14th parameter as specified in headder record
        m_HP15(1 to 5) as Single   '        15th parameter as specified in headder record
      END TYPE

      TYPE CQUAD_NSC               ' 221/LC:0  maximum stresses in nodes
        m_NG as Long               '        ident 0 for maximum (first records)
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SVXY as Single           ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_FY as Single             '        yield function
      END TYPE

      TYPE CQUAD_NST               ' 221/LC:Z+  stresses in Quad-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_FY as Single             '        yield function
      END TYPE

      TYPE CQUAD_ESC               ' 222/LC:0  max. errors in nodes
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SVXY as Single           ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_ERR as Single            '        error in energy
      END TYPE

      TYPE CQUAD_EST               ' 222/LC:+  error estimates of Quad-element stresses
        m_NR as Long               '        elementnumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_TAU as Single            ' [1092] shear stress
        m_SIGZ as Single           ' [1092] stress
        m_HOPT as Single           ' [1002] optimal mesh size
      END TYPE

      TYPE CQUAD_RLC               ' 225/LC:0  max Quad-Layer-results
        m_NR as Long               '        ident 0 for maximum (first records)
        m_MNR as Long              '        ident 0 for maximum (first records)
        m_XI as Single             '        local-z
        m_SIGX as Single           ' [1092] stress x
        m_SIGY as Single           ' [1092] stress y
        m_TAU as Single            ' [1092] shear stress xy
        m_SIGZ as Single           ' [1092] stress
        m_TAUX as Single           ' [1092] shear stress vx
        m_TAUY as Single           ' [1092] shear stress vy
        m_HP1 as Single            '        yield function
        m_HP2 as Single            '        volum. hardening
        m_HP3 as Single            '        damage parameter x
        m_HP4 as Single            '        damage parameter y
        m_HP5 as Single            ' [   3] crack direction 1
        m_HP6 as Single            ' [   3] crack direction 2
        m_HP7 as Single            ' [   9] accumulated temperature strain
        m_HP8 as Single            '        internal damage parameter shrinkage
        m_HP9 as Single            ' [   9] accumulated shrinkage strain
        m_HP10 as Single           '        damage parameter xy
        m_HP11 as Single           ' [   9] epsx  strain in stress strain curve
        m_HP12 as Single           ' [   9] epsy  strain in stress strain curve
        m_HP13 as Single           ' [1215] layer temperature in case of fire analysis
      END TYPE

      TYPE CQUAD_RLA_SG            '        results in GAUSS-points
        m_SIGX as Single           ' [1092] 
        m_SIGY as Single           ' [1092] 
        m_TAU as Single            ' [1092] 
        m_SIGZ as Single           ' [1092] 
        m_TAUX as Single           ' [1092] 
        m_TAUY as Single           ' [1092] 
      END TYPE

      TYPE CQUAD_RLA               ' 225/LC:+  Layer-stresses of Quads
        m_NR as Long               '        Elementnumber
        m_MNR as Long              '        Materialnumber MNR>0
        m_XI as Single             '        local-z
        m_SIGX as Single           ' [1092] stress x
        m_SIGY as Single           ' [1092] stress y
        m_TAU as Single            ' [1092] shear stress xy
        m_SIGZ as Single           ' [1092] stress
        m_TAUX as Single           ' [1092] shear stress vx
        m_TAUY as Single           ' [1092] shear stress vy
        m_SG(1 to 4) as CQUAD_RLA_SG '        results in GAUSS-points
        m_HP1(1 to 5) as Single    '        yield function
        m_HP2(1 to 5) as Single    '        volum. hardening
        m_HP3(1 to 5) as Single    '        damage parameter x
        m_HP4(1 to 5) as Single    '        damage parameter y
        m_HP5(1 to 5) as Single    ' [   3] crack direction 1
        m_HP6(1 to 5) as Single    ' [   3] crack direction 2
        m_HP7(1 to 5) as Single    ' [   9] accumulated temperature strain
        m_HP8(1 to 5) as Single    '        internal damage parameter shrinkage
        m_HP9(1 to 5) as Single    ' [   9] accumulated shrinkage strain
        m_HP10(1 to 5) as Single   '        damage parameter xy
        m_HP11(1 to 5) as Single   ' [   9] epsx  strain in stress strain curve
        m_HP12(1 to 5) as Single   ' [   9] epsy  strain in stress strain curve
        m_HP13(1 to 5) as Single   ' [1215] layer temperature in case of fire analysis
        m_HP14(1 to 5) as Single   ' [1215] max. layer temperature in load history
      END TYPE

      TYPE CQUAD_RLB_SG            '        results in GAUSS-points
        m_SIG1 as Single           ' [1092] 
        m_SIG2 as Single           ' [1092] 
        m_EPS1 as Single
        m_XI1 as Single
        m_XI2 as Single
        m_EPS2 as Single
      END TYPE

      TYPE CQUAD_RLB               ' 225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
        m_NR as Long               '        Elementnumber
        m_MNR as Long              '        MNR=-1 identifier for reinforcement data
        m_XI as Single             '        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
        m_SIG1 as Single           ' [1092] stress in reinforcement 1. layer
        m_SIG2 as Single           ' [1092] stress in reinforcement 2. layer
        m_EPS1 as Single           '        eps strain in stress strain curve 1. layer
        m_XI1 as Single            '        exact xi position 1. layer
        m_XI2 as Single            '        exact xi position 2. layer
        m_EPS2 as Single           '        eps strain in stress strain curve 2. layer
        m_SG(1 to 4) as CQUAD_RLB_SG '        results in GAUSS-points
        m_HP1(1 to 5) as Single    '        damage parameter 1. layer
        m_HP2(1 to 5) as Single    '        damage parameter 2. layer
        m_HP3(1 to 5) as Single    ' [1092] delta-sigma tension stiff. layer 1
        m_HP4(1 to 5) as Single    ' [1092] delta-sigma tension stiff. layer 2
        m_HP5(1 to 5) as Single    '        direction of reinforcement layer 1
        m_HP6(1 to 5) as Single    '        direction of reinforcement layer 2
        m_HP7(1 to 5) as Single    ' [   9] accumulated temperature strain
        m_HP8(1 to 5) as Single    '        free
        m_HP9(1 to 5) as Single    '        free
        m_HP10(1 to 5) as Single   ' [1215] layer 1 actual temperature in case of fire analysis
        m_HP11(1 to 5) as Single   ' [1215] layer 2 actual temperature in case of fire analysis
      END TYPE

      TYPE CQUAD_SEC               ' 229/LC:0  maximum Quad-sectional stress
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] normalstress
        m_SIGY as Single           ' [1092] transverse stress
        m_SIGZ as Single           ' [1092] transverse stress
        m_TAUXY as Single          ' [1092] shear stress
        m_TAUXZ as Single          ' [1092] shear stress
        m_TAUYZ as Single          ' [1092] shear stress
      END TYPE

      TYPE CQUAD_SEQ               ' 229/LC:-  location of sectional results in master
        m_NR as Long               '        negative beam number
        m_X as Single              ' [1001] section along beam
      END TYPE

      TYPE CQUAD_SER               ' 229/LC:+  stresses of sectional Quad-elements
        m_NR as Long               '        Elementnumber
        m_SIGX as Single           ' [1092] normalstress
        m_SIGY as Single           ' [1092] transverse stress
        m_SIGZ as Single           ' [1092] transverse stress
        m_TAUXY as Single          ' [1092] shear stress
        m_TAUXZ as Single          ' [1092] shear stress
        m_TAUYZ as Single          ' [1092] shear stress
      END TYPE

      TYPE CQUAD_RT0               ' 230/LC:0  maximum of tendon stresses
        m_NR as Long               '        identifier 0
        m_NRS as Long              '        identifier 0
        m_SIGZ as Single           ' [1092] stress increment
        m_ZZ as Single             ' [1101] force in tendon
        m_ZH as Single             ' [1101] duct deduction force
        m_SZG1 as Single           ' [1092] stress in G-point 1
        m_SZG2 as Single           ' [1092] stress in G-point 2
        m_ZZX1 as Single           ' [1101] force tendon+cement1
        m_ZZX2 as Single           ' [1101] force tendon+cement1
        m_ZHG1 as Single           ' [1101] duct deduction G1
        m_ZHG2 as Single           ' [1101] duct deduction G2
        m_ZZG1 as Single           ' [1101] force in tendon G1
        m_ZZG2 as Single           ' [1101] force in tendon G2
        m_AGE as Single            ' [  93] age since prestress
        m_RELZ as Single           '        accumulated relaxation
        m_TZG1 as Single           ' [1215] temperature tendon G1
        m_TZG2 as Single           ' [1215] temperature tendon G2
        m_THG1 as Single           ' [1215] temperature tendon duct G1
        m_THG2 as Single           ' [1215] temperature tendon duct G2
      END TYPE

      TYPE CQUAD_RTS               ' 230/LC:+  tendon stresses in two integration points
        m_NR as Long               '        elementnumber
        m_NRS as Long              '        tendonnumber
        m_SIGZ as Single           ' [1092] stress increment
        m_ZZ as Single             ' [1101] force in tendon
        m_ZH as Single             ' [1101] duct deduction force
        m_SZG1 as Single           ' [1092] stress in G-point 1
        m_SZG2 as Single           ' [1092] stress in G-point 2
        m_ZZX1 as Single           ' [1101] force tendon+cement1
        m_ZZX2 as Single           ' [1101] force tendon+cement1
        m_ZHG1 as Single           ' [1101] duct deduction G1
        m_ZHG2 as Single           ' [1101] duct deduction G2
        m_ZZG1 as Single           ' [1101] force in tendon G1
        m_ZZG2 as Single           ' [1101] force in tendon G2
        m_AGE as Single            ' [  93] age since prestress
        m_RELZ as Single           '        accumulated relaxation
        m_TZG1 as Single           ' [1215] temperature tendon G1
        m_TZG2 as Single           ' [1215] temperature tendon G2
        m_THG1 as Single           ' [1215] temperature tendon duct G1
        m_THG2 as Single           ' [1215] temperature tendon duct G2
      END TYPE

      TYPE CQUAD_DST               ' 250/DC:+  design stresses in Quad-elements
        m_NR as Long               '        elementnumber
        m_SMIO as Single           ' [1092] minimum upside main stress
        m_SMAO as Single           ' [1092] maximum upside main stress
        m_SMIU as Single           ' [1092] minimum downside main stress
        m_SMAU as Single           ' [1092] maximum downside main stress
        m_TAUM as Single           ' [1092] maximum shear stress
        m_SVMA as Single           ' [1092] maximum reference stress
        m_SVO as Single            ' [1092] maximum reference stress upside
        m_SVU as Single            ' [1092] maximum reference stress downside
        m_RESERVED(1 to 7) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CQUAD_NDS               ' 251/DC:Z+  design stresses in Quad-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_SMIO as Single           ' [1092] minimum upside main stress Minimale Hauptspannung oben
        m_SMAO as Single           ' [1092] maximum upside main stress Maximale Hauptspannung oben
        m_SMIU as Single           ' [1092] minimum downside main stress Minimale Hauptspannung unten
        m_SMAU as Single           ' [1092] maximum downside main stress Maximale Hauptspannung unten
        m_TAUM as Single           ' [1092] maximum shear stress
        m_SVMA as Single           ' [1092] maximum reference stress
        m_SVO as Single            ' [1092] maximum reference stress upside
        m_SVU as Single            ' [1092] maximum reference stress downside
        m_RESERVED(1 to 7) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of designcase
      END TYPE

      TYPE CQUAD_RIC               ' 260/DC:0  maximum reinforcement in Quad-elements
        m_NR as Long               '        ident 0
        m_ASO as Single            ' [1021] upside reinforcement (outside)
        m_ASOQ as Single           ' [1021] upside cross reinforcement (middle)
        m_ASU as Single            ' [1021] downside reinforcement (outside)
        m_ASUQ as Single           ' [1021] downside cross reinforcement (middle)
        m_ASOI as Single           ' [1021] upside third reinforcement (inside)
        m_ASUI as Single           ' [1021] downside third reinforcement (inside)
        m_ASS as Single            ' [1022] stirrup cm2/m2
        m_ASSE as Single           ' [1020] stirrup cm2
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_SIXO as Single           ' [1030] upside reinforcement quantity
        m_SIXU as Single           ' [1030] downside reinforcement quantity
        m_SIXS as Single           ' [1030] shear reinforcement quantity
        m_FREE0(1 to 3) as Single  '        not yet used
        m_ZMIN as Single           ' [1001] minimum lever arm
        m_VEDR as Single           '        max. VED/VRDMAX
        m_COTT as Single           '        max. cot_theta
        m_VED as Single            '        max. VED
        m_VM as Single             ' [1001] shift rule
        m_SDO(1 to 3) as Single    ' [1092] upside stress range (outside)
        m_SDU(1 to 3) as Single    ' [1092] downside stress range (inside)
        m_SDV as Single            ' [1092] stirrup stress range
        m_SSO(1 to 3) as Single    ' [1092] maximum stell stress upside (outside)
        m_SSU(1 to 3) as Single    ' [1092] maximum stell stress downside(inside)
        m_SSV as Single            ' [1092] maximum stirrup stress (not yet used)
        m_SIGBO as Single          ' [1092] maximum concrete pressure upside (outside)
        m_SIGBU as Single          ' [1092] maximum concrete pressure downside(inside)
        m_SHZMAX as Single         '        maximum skew principal tensile stress
        m_SHZX as Single           '        max. skew principal tensile stress in local x
        m_SHZY as Single           '        max. skew principal tensile stress in local y
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_ASBEND(1 to 6) as Single ' [1021] Info reinforcement bending design only
        m_ASPLUS(1 to 6) as Single ' [1021] Info reinforcement if increased due to shear
        m_ASPOSS(1 to 6) as Single ' [1021] Info reinforcement to satisfy shear without stirrups
        m_BMOM(1 to 6) as Single   ' [1114] Design bending moment in direction of reinforcement
        m_ORIGIN(1 to 7) as Single '        bitpattern of origins of maximum reinforcements
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons
        m_WK6(1 to 6) as Single    ' [1026] crack width  reinforcement
        m_RESERVED(1 to 4) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of designcase
      END TYPE

      TYPE CQUAD_REI               ' 260/DC:+  reinforcement in Quad-elements
        m_NR as Long               '        elementnumber
        m_ASO as Single            ' [1021] upside reinforcement (outside)
        m_ASOQ as Single           ' [1021] upside cross reinforcement (middle)
        m_ASU as Single            ' [1021] downside reinforcement (outside)
        m_ASUQ as Single           ' [1021] downside cross reinforcement (middle)
        m_ASOI as Single           ' [1021] upside third reinforcement (inside)
        m_ASUI as Single           ' [1021] downside third reinforcement (inside)
        m_ASS as Single            ' [1022] stirrup cm2/m2
        m_ASSE as Single           ' [1020] stirrup cm2
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_RIO as Single            '        direction of upside reinforcement
        m_RIOQ as Single           '        direction of upside cross reinforcement
        m_RIU as Single            '        direction of downside reinforcement
        m_RIUQ as Single           '        direction of downside cross reinforcement
        m_RIOI as Single           '        direction of upside third reinforcement
        m_RIUI as Single           '        direction of downside third reinforcement
        m_ZMIN as Single           ' [1001] minimum lever arm (ULS design)
        m_VEDR as Single           '        max. VED/VRDMAX (ULS design)
        m_COTT as Single           '        max. cot_theta (ULS design)
        m_VED as Single            '        max. VED (ULS design)
        m_VM as Single             ' [1001] shift rule
        m_SDO(1 to 3) as Single    ' [1092] upside stress range (outside)
        m_SDU(1 to 3) as Single    ' [1092] downside stress range (inside)
        m_SDV as Single            ' [1092] stirrup stress range
        m_SSO(1 to 3) as Single    ' [1092] maximum stell stress upside (outside)
        m_SSU(1 to 3) as Single    ' [1092] maximum stell stress downside(inside)
        m_SSV as Single            ' [1092] maximum stirrup stress (not yet used)
        m_SIGBO as Single          ' [1092] maximum concrete pressure upside (outside)
        m_SIGBU as Single          ' [1092] maximum concrete pressure downside(inside)
        m_SHZMAX as Single         '        maximum skew principal tensile stress (SLS uncracked)
        m_SHZX as Single           '        max. skew principal tensile stress in local x
        m_SHZY as Single           '        max. skew principal tensile stress in local y
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_ASBEND(1 to 6) as Single ' [1021] Info reinforcement bending design only (ULS design)
        m_ASPLUS(1 to 6) as Single ' [1021] Info reinforcement if increased due to shear (ULS design)
        m_ASPOSS(1 to 6) as Single ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        m_BMOM(1 to 6) as Single   ' [1114] Design bending moment in direction of reinforcement
        m_ORIGIN(1 to 7) as Single '        origin of maximum reinforcement:
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons
        m_WK6(1 to 6) as Single    ' [1026] crack width  reinforcement
      END TYPE

      TYPE CQUAD_NRC               ' 261/DC:0  maximum reinforcement in Quad-nodes
        m_NR as Long               '        ident 0
        m_NG as Long               '        ident 0
        m_ASO as Single            ' [1021] upside reinforcement (outside)
        m_ASOQ as Single           ' [1021] upside cross reinforcement (middle)
        m_ASU as Single            ' [1021] downside reinforcement (outside)
        m_ASUQ as Single           ' [1021] downside cross reinforcement (middle)
        m_ASOI as Single           ' [1021] upside third reinforcement (inside)
        m_ASUI as Single           ' [1021] downside third reinforcement (inside)
        m_ASS as Single            ' [1022] stirrup cm2/m2
        m_I_8 as Single            '        reserved 0.0
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_FREE0(1 to 6) as Single  '        not yet used
        m_ZMIN as Single           ' [1001] minimum lever arm
        m_VEDR as Single           '        max. VED/VRDMAX
        m_COTT as Single           '        max. cot_theta
        m_VED as Single            '        max. VED
        m_VM as Single             ' [1001] shift rule
        m_SDO(1 to 3) as Single    ' [1092] upside stress range (outside)
        m_SDU(1 to 3) as Single    ' [1092] downside stress range (inside)
        m_SDV as Single            ' [1092] stirrup stress range
        m_SSO(1 to 3) as Single    ' [1092] maximum stell stress upside (outside)
        m_SSU(1 to 3) as Single    ' [1092] maximum stell stress downside(inside)
        m_SSV as Single            ' [1092] maximum stirrup stress (not yet used)
        m_SIGBO as Single          ' [1092] maximum concrete pressure upside (outside)
        m_SIGBU as Single          ' [1092] maximum concrete pressure downside(inside)
        m_SHZMAX as Single         '        maximum skew principal tensile stress
        m_SHZX as Single           '        max. skew principal tensile stress in local x
        m_SHZY as Single           '        max. skew principal tensile stress in local y
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_ASBEND(1 to 6) as Single ' [1021] Info reinforcement bending design only
        m_ASPLUS(1 to 6) as Single ' [1021] Info reinforcement if increased due to shear
        m_ASPOSS(1 to 6) as Single ' [1021] Info reinforcement to satisfy shear without stirrups
        m_BMOM(1 to 6) as Single   ' [1114] Design bending moment in direction of reinforcement
        m_ORIGIN(1 to 7) as Single '        bitpattern of origins of maximum reinforcements
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons
        m_WK6(1 to 6) as Single    ' [1026] crack width  reinforcement
        m_RESERVED(1 to 4) as Single '        reserved for future usage
        m_TEXT(1 to 17) as Long    '        Designation of Designcase
      END TYPE

      TYPE CQUAD_NRI               ' 261/DC:Z+  reinforcement in Quad-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_ASO as Single            ' [1021] upside reinforcement (outside)
        m_ASOQ as Single           ' [1021] upside cross reinforcement (middle)
        m_ASU as Single            ' [1021] downside reinforcement (outside)
        m_ASUQ as Single           ' [1021] downside cross reinforcement (middle)
        m_ASOI as Single           ' [1021] upside third reinforcement (inside)
        m_ASUI as Single           ' [1021] downside third reinforcement (inside)
        m_ASS as Single            ' [1022] stirrup cm2/m2
        m_I_8 as Single            '        reserved 0.0
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_RIO as Single            '        direction of upside reinforcement
        m_RIOQ as Single           '        direction of upside cross reinforcement
        m_RIU as Single            '        direction of downside reinforcement
        m_RIUQ as Single           '        direction of downside cross reinforcement
        m_RIOI as Single           '        direction of upside third reinforcement
        m_RIUI as Single           '        direction of downside third reinforcement
        m_ZMIN as Single           ' [1001] minimum lever arm
        m_VEDR as Single           '        max. VED/VRDMAX
        m_COTT as Single           '        max. cot_theta
        m_VED as Single            '        max. VED
        m_VM as Single             ' [1001] shift rule
        m_SDO(1 to 3) as Single    ' [1092] upside stress range (outside)
        m_SDU(1 to 3) as Single    ' [1092] downside stress range (inside)
        m_SDV as Single            ' [1092] stirrup stress range
        m_SSO(1 to 3) as Single    ' [1092] maximum stell stress upside (outside)
        m_SSU(1 to 3) as Single    ' [1092] maximum stell stress downside(inside)
        m_SSV as Single            ' [1092] maximum stirrup stress (not yet used)
        m_SIGBO as Single          ' [1092] maximum concrete pressure upside (outside)
        m_SIGBU as Single          ' [1092] maximum concrete pressure downside(inside)
        m_SHZMAX as Single         '        maximum skew principal tensile stress
        m_SHZX as Single           '        max. skew principal tensile stress in local x
        m_SHZY as Single           '        max. skew principal tensile stress in local y
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_ASBEND(1 to 6) as Single ' [1021] Info reinforcement bending design only
        m_ASPLUS(1 to 6) as Single ' [1021] Info reinforcement if increased due to shear
        m_ASPOSS(1 to 6) as Single ' [1021] Info reinforcement to satisfy shear without stirrups
        m_BMOM(1 to 6) as Single   ' [1114] Design bending moment in direction of reinforcement
        m_ORIGIN(1 to 7) as Single '        origin of maximum reinforcement
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons
        m_WK6(1 to 6) as Single    ' [1026] crack width  reinforcement
      END TYPE

      TYPE CQUAD_NRP               ' 262/DC:+  punching reinforcement in nodes
        m_NR as Long               '        nodenumber
        m_ISTA as Long             '        state of force
        m_IDUS as Long             '        punching state
        m_U0 as Single             ' [1001] effective length of first perimeter
        m_REDO as Single           '        reduction factor for openings/free edges
        m_V as Single              ' [1151] punching force
        m_ASL as Single            ' [1020] required longitudinal reinforcement
        m_ASV1 as Single           ' [1022] shear reinforcement within 1st perimeter
        m_ASV2 as Single           ' [1022] shear reinforcement within 2nd perimeter
        m_ASV3 as Single           ' [1022] shear reinforcement within 3rd perimeter
        m_ASV4 as Single           ' [1022] shear reinforcement within 4th perimeter
        m_FREE0(1 to 5) as Single  '        not yet used
        m_TXT1(1 to 16) as Long    '        Halfen Description 1 (30 chars require n/2+1 words)
        m_TXT2(1 to 16) as Long    '        Halfen Description 2
        m_TXT3(1 to 16) as Long    '        Halfen Description 3
      END TYPE

      TYPE CQUAD_PUN               ' 262/DC:0  punching periphery
        m_NR as Long               '        identifier 0
        m_ID as Long               '        identifier 0
        m_TYP as Long              '        type of line
        m_X1 as Single             ' [1001] Coordinates of start point
        m_Y1 as Single             ' [1001] 
        m_Z1 as Single             ' [1001] 
        m_X2 as Single             ' [1001] Coordinates of end point
        m_Y2 as Single             ' [1001] 
        m_Z2 as Single             ' [1001] 
      END TYPE

      TYPE CQUAD_PU1               ' 262/DC:0  punching parameters
        m_NR as Long               '        identifier 0
        m_ID as Long               '        identifier 1
        m_KDUST(1 to 199) as Long  '        Integer-punching parameters
        m_RDUST(1 to 299) as Single'        Real-punching parameters
      END TYPE

      TYPE CQUAD_RD0               ' 265/DC:0  maximum of tendon stresses in the design
        m_NR as Long               '        identifier 0
        m_NRS as Long              '        identifier 0
        m_SMAX as Single           ' [1092] maximum design stress
        m_SMIN as Single           ' [1092] minimum design stress
        m_PERM as Single           ' [1092] permanent stress
      END TYPE

      TYPE CQUAD_RTD               ' 265/DC:+  tendon stress in the design
        m_NR as Long               '        elementnumber
        m_NRS as Long              '        tendonnumber
        m_SMAX as Single           ' [1092] maximum design stress
        m_SMIN as Single           ' [1092] minimum design stress
        m_PERM as Single           ' [1092] permanent stress
      END TYPE

      TYPE CQUAD_REE               ' 270/DC:0  maximum design values in Quad-elements
        m_NG as Long               '        ident 0
        m_NR as Long               '        ident 0
        m_ID as Long               '        activated layers: -(nupper +100*nlower +10000*ncentric)
        m_ORIG as Long             '        origin - error messages:
        m_SIGC(1 to 2) as Single   ' [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
        m_SIGCD(1 to 2) as Single  ' [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
        m_SHZ(1 to 3) as Single    ' [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
        m_SIGS(1 to 3) as Single   ' [1092] maximum SLS reinforcement stress for center/upside/downside
        m_SIGSD(1 to 3) as Single  ' [1092] maximum SLS reinforcement stress range for center/upside/downsi
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons upside/downsid
        m_ZMIN as Single           ' [1001] minimum lever arm (ULS design)
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_ASS as Single            ' [1022] stirrup reinforcement ratio
        m_VEDR as Single           '        max. VED/VRDMAX (ULS design)
        m_COTT as Single           '        max. cot_theta (ULS design)
        m_VED as Single            '        max. VED (ULS design)
        m_VM as Single             ' [1001] shift rule
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_OPT(1 to 15) as Single   '        reserved
        m_SUMO as Single           ' [1030] upside reinforcement quantity
        m_SUMU as Single           ' [1030] downside reinforcement quantity
        m_SUMM as Single           ' [1030] centric reinforcement quantity
        m_SUMS as Single           ' [1030] shear reinforcement quantity
        m_TEXT(1 to 17) as Long    '        Designation of designcase
      END TYPE

      TYPE CQUAD_RNE               ' 271/DC:0  maximum design values in Nodes of Quad-elements
        m_NG as Long               '        ident 0
        m_NR as Long               '        ident 0
        m_ID as Long               '        activated layers: -(nupper +100*nlower +10000*ncentric)
        m_ORIG as Long             '        origin - error messages:
        m_SIGC(1 to 2) as Single   ' [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
        m_SIGCD(1 to 2) as Single  ' [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
        m_SHZ(1 to 3) as Single    ' [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
        m_SIGS(1 to 3) as Single   ' [1092] maximum SLS reinforcement stress for center/upside/downside
        m_SIGSD(1 to 3) as Single  ' [1092] maximum SLS reinforcement stress range for center/upside/downsi
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons upside/downsid
        m_ZMIN as Single           ' [1001] minimum lever arm (ULS design)
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_ASS as Single            ' [1022] stirrup reinforcement ratio
        m_VEDR as Single           '        max. VED/VRDMAX (ULS design)
        m_COTT as Single           '        max. cot_theta (ULS design)
        m_VED as Single            '        max. VED (ULS design)
        m_VM as Single             ' [1001] shift rule
        m_UTILC as Single          '        max. utilization fatigue check concrete
        m_OPT(1 to 15) as Single   '        reserved
        m_SUMO as Single           ' [1030] upside reinforcement quantity
        m_SUMU as Single           ' [1030] downside reinforcement quantity
        m_SUMM as Single           ' [1030] centric reinforcement quantity
        m_SUMS as Single           ' [1030] shear reinforcement quantity
        m_TEXT(1 to 17) as Long    '        Designation of designcase
      END TYPE

      TYPE CQUAD_REM               ' 270/DC:0  maximum reinforcement results in Quad-elements
        m_NG as Long               '        ident 0
        m_NR as Long               '        ident 0
        m_ID as Long               '        +1 identifier for reincorcement
        m_ORIG as Long             '        origin of maximum reinforcement, see QUAD_REA for Details
        m_ASO as Single            ' [1021] reinforcement area
        m_SDO(1 to 3) as Single    ' [1092] reinforcement stress SLS
        m_ASBEND as Single         ' [1021] Info reinforcement bending design only (ULS design)
        m_ASPLUS as Single         ' [1021] Info reinforcement if increased due to shear (ULS design)
        m_ASPOSS as Single         ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        m_BMOM as Single           ' [1114] Design bending moment in direction of reinforcement
        m_WK as Single             ' [1026] crack width
      END TYPE

      TYPE CQUAD_REA               ' 270/DC:Z+  General Concrete Design Results
        m_NG as Long               '        group number (for nodal results)
        m_NR as Long               '        element number
        m_ID as Long               '        ident 0 : concrete results
        m_ORIG as Long             '        origin of maximum reinforcement:
        m_SIGO(1 to 3) as Single   ' [1092] stress of concrete pressure upside (Z-)
        m_SIGU(1 to 3) as Single   ' [1092] stress of concrete pressure downside (Z+)
        m_SHZMAX as Single         '        maximum skew principal tensile stress (SLS uncracked)
        m_SHZX as Single           '        max. skew principal tensile stress in local x
        m_SHZY as Single           '        max. skew principal tensile stress in local y
        m_ZMIN as Single           ' [1001] minimum lever arm (ULS design)
        m_DECO(1 to 2) as Single   ' [   9] decompression strain in the direction of tendons
        m_SUMO as Single           ' [1021] upside reinforcement quantity
        m_SUMU as Single           ' [1021] downside reinforcement quantity
        m_SUMM as Single           ' [1021] shear reinforcement quantity
        m_TAU0 as Single           ' [1092] design shear stress (shear force)
        m_ASS as Single            ' [1022] stirrup reinforcement ratio
        m_VEDR as Single           '        max. VED/VRDMAX (ULS design)
        m_COTT as Single           '        max. cot_theta (ULS design)
        m_VED as Single            '        max. VED (ULS design)
        m_VM as Single             ' [1001] shift rule
        m_UTILC as Single          '        max. utilization fatigue check concrete
      END TYPE

      TYPE CQUAD_RER               ' 270/DC:Z+  Reinforcement Layer Design Results
        m_NG as Long               '        group number (for nodal results)
        m_NR as Long               '        element number
        m_ID as Long               '        identifier of reincorcement layer
        m_ORIG as Long             '        origin of maximum reinforcement, see QUAD_REA for Details
        m_ASO as Single            ' [1021] reinforcement area
        m_SDO(1 to 3) as Single    ' [1092] reinforcement stress SLS
        m_ASBEND as Single         ' [1021] Info reinforcement bending design only (ULS design)
        m_ASPLUS as Single         ' [1021] Info reinforcement if increased due to shear (ULS design)
        m_ASPOSS as Single         ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        m_BMOM as Single           ' [1114] Design bending moment in direction of reinforcement
        m_WK as Single             ' [1026] crack width
      END TYPE

      TYPE CQUAD_CFD               ' 290/LC  Fluid flow results in Quad-elements
        m_NR as Long               '        elementnumber
        m_VX as Single             ' [1212] velocity
        m_VY as Single             ' [1212] velocity
        m_VZ as Single             ' [1212] velocity
        m_Q as Single              ' [1211] stream quantity
        m_HOPT as Single           ' [1001] Boundary layer
        m_VXA as Single            ' [1212] particle velocity
        m_VYA as Single            ' [1212] particle velocity
        m_VZA as Single            ' [1212] particle velocity
        m_MUED as Single           ' [1220] laminar viscosity
        m_DUX(1 to 2) as Single    ' [  95] gradient values of fluid flow du/dx, du/dy
        m_DVX(1 to 2) as Single    ' [  95] gradient values of fluid flow dv/dx, dv/dy
        m_TK as Single             ' [1222] turbulent energy
        m_MUET as Single           ' [1220] turbulent viscosity
        m_ED as Single             ' [1223] dissipation rate
        m_SCALAR(1 to 4) as Single '        optional scalar values
      END TYPE

      TYPE CQUAD_TM                ' 291/LC:0  Maximum of Temperature Results in Quads
        m_NR as Long               '        elementnumber
        m_QX as Single             ' [1218] heat flux
        m_QY as Single             ' [1218] heat flux
        m_QZ as Single             ' [1218] heat flux
        m_Q as Single              ' [1216] Total flux
        m_HOPT as Single           ' [1001] optimal mesh size
        m_TEFF as Single           ' [  92] Effective Age
        m_HYDR as Single           '        Hydration degree
        m_LFR as Single            '        Liquid fraction
      END TYPE

      TYPE CQUAD_TMP               ' 291/LC  Temperature Results in Quad-elements
        m_NR as Long               '        elementnumber
        m_QX as Single             ' [1218] heat flux
        m_QY as Single             ' [1218] heat flux
        m_QZ as Single             ' [1218] heat flux
        m_Q as Single              ' [1216] Total flux
        m_HOPT as Single           ' [1001] optimal mesh size
        m_TEFF(1 to 5) as Single   ' [  92] Effective Age
        m_HYDR(1 to 5) as Single   '        Hydratation degree
        m_LFR(1 to 5) as Single    '        Liquid fraction
      END TYPE

      TYPE CBRIC                   ' 300/00  Bric-elements
        m_NR as Long               '        elementnumber
        m_NODE(1 to 8) as Long     '        nodenumbers
        m_MAT as Long              '        materialnumber
        m_NRA as Long              '        type of element
        m_DET(1 to 4) as Single    '        Values of Jacobian Determinant / Volume
      END TYPE

      TYPE CBRIC_SU                ' 300/02:0  Surfaces and Neighbours of Bric-elements
        m_N0(1 to 4) as Long
        m_NSUR as Long
        m_MBRI as Long             '        max number of brics per surface
      END TYPE

      TYPE CBRIC_SUR               ' 300/02:+  Surfaces and Neighbours of Bric-elements
        m_NODE(1 to 4) as Long
        m_IJMP as Long
        m_NBRI as Long
        m_NREL(1 to 7) as Long     '        bric numbers for this surface
      END TYPE

      TYPE CBRIC_RIM               ' 300/6  Prescribed Reinforcements of Bric-elements
        m_NRG as Long              '        group number
        m_NR as Long               '        selector number
        m_TYP as Long              '        Type of Reinforc.
        m_GTYP as Long             '        Type of grading
        m_IDRA as Long             '        drawing source type
        m_OAL as Single            '        Euler Angle I reinforcement
        m_OAF as Single            '        Euler Angle II
        m_XREF as Single           ' [1001] Reference point for circular reinforcement
        m_YREF as Single           ' [1001] XREF+YREF allowed in combination with OAL and OAF
        m_ZREF as Single           ' [1001] ZREF<>RW only allowed for OAL=OAF=0
        m_DI(1 to 3) as Single     ' [1023] Diameter of reinforcement 1-3
        m_AS(1 to 3) as Single     ' [1022] Minimum reinforcement 1-3
        m_AM(1 to 3) as Single     ' [1022] Maximum reinforcement 1-3
        m_WK(1 to 3) as Single     ' [1026] design crack width
        m_SIG(1 to 3) as Single    ' [1092] SLS steel stress limit
      END TYPE

      TYPE CBRIC_P                 ' 300/10  Bric-P-Elements
        m_NR as Long               '        elementnumber
        m_NODE(1 to 8) as Long     '        nodenumbers
        m_MAT as Long              '        materialnumber
        m_EDGE(1 to 12) as Long    '        geometric id of edge 1-2
        m_FACE(1 to 6) as Long     '        geometric id of face 1-2-3-4
      END TYPE

      TYPE CBRIC_LOA               ' 302/LC  loads of Bric-elements
        m_VON as Long              '        start elementnumber
        m_BIS as Long              '        end elementnumber
        m_DEL as Long              '        increment
        m_TYP as Long              '        type of load
        m_LNR as Long              '        primary loadcasenumber,if TYP = 18/30
        m_P as Single              '        load value
        m_DPDX as Single
        m_DPDY as Single
        m_DPDZ as Single
        m_XREF as Single           ' [1001] optional reference point for load value
        m_YREF as Single           ' [1001] 
        m_ZREF as Single           ' [1001] 
      END TYPE

      TYPE CBRIC_STC               ' 310/LC:0  maximum stress in BRICs
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
        m_HP1 as Single            '        yield function
        m_HP2 as Single            '        volum. hardening
      END TYPE

      TYPE CBRIC_STR_SG            '        results in GAUSS-points
        m_SIGX as Single           ' [1092] 
        m_SIGY as Single           ' [1092] 
        m_SIGZ as Single           ' [1092] 
        m_TVXY as Single           ' [1092] 
        m_TVXZ as Single           ' [1092] 
        m_TVYZ as Single           ' [1092] 
      END TYPE

      TYPE CBRIC_STR               ' 310/LC:+  3D-stresses in Bric-elements
        m_NR as Long               '        elementnumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
        m_SG(1 to 8) as CBRIC_STR_SG '        results in GAUSS-points
        m_HP1(1 to 9) as Single    '        yield function
        m_HP2(1 to 9) as Single    '        2nd parameter as specified in headder record
        m_HP3(1 to 9) as Single    '        3rd parameter as specified in headder record
        m_HP4(1 to 9) as Single    '        4th parameter as specified in headder record
        m_HP5(1 to 9) as Single    '        5th parameter as specified in headder record
        m_HP6(1 to 9) as Single    '        6th parameter as specified in headder record
        m_HP7(1 to 9) as Single    '        7th parameter as specified in headder record
        m_HP8(1 to 9) as Single    '        8th parameter as specified in headder record
        m_HP9(1 to 9) as Single    '        9th parameter as specified in headder record
        m_HP10(1 to 9) as Single   '        10th parameter as specified in headder record
        m_HP11(1 to 9) as Single   '        11th parameter as specified in headder record
        m_HP12(1 to 9) as Single   '        12th parameter as specified in headder record
        m_HP13(1 to 9) as Single   '        13th parameter as specified in headder record
        m_HP14(1 to 9) as Single   '        14th parameter as specified in headder record
        m_HP15(1 to 9) as Single   '        15th parameter as specified in headder record
      END TYPE

      TYPE CBRIC_NSC               ' 311/LC:0  maximum nodal 3D stress
        m_NG as Long               '        ident 0 for maximum (first records)
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
      END TYPE

      TYPE CBRIC_NST               ' 311/LC:Z+  3D-stresses in Bric-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
        m_FY as Single             '        yield function
      END TYPE

      TYPE CBRIC_ESC               ' 312/LC:0  max. errors of Bric-stresses
        m_NR as Long               '        ident 0 for maximum (first records)
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
      END TYPE

      TYPE CBRIC_EST               ' 312/LC:+  3D-error estimates in Bric-Elements
        m_NR as Long               '        elementnumber
        m_SIGX as Single           ' [1092] stress
        m_SIGY as Single           ' [1092] stress
        m_SIGZ as Single           ' [1092] stress
        m_TVXY as Single           ' [1092] shear stress
        m_TVXZ as Single           ' [1092] shear stress
        m_TVYZ as Single           ' [1092] shear stress
      END TYPE

      TYPE CBRIC_REI               ' 360/DC:+  reinforcement in Bric-elements
        m_NR as Long               '        elementnumber
        m_AS(1 to 3) as Single     ' [1022] reinforcement 1-3
        m_OAL as Single            '        Euler Angle I
        m_OAF as Single            '        Euler Angle II
        m_SD(1 to 3) as Single     ' [1092] stress range 1-3
        m_SIGB as Single           ' [1092] maximum concrete pressure
        m_SHZMAX as Single         '        maximum skew principal tensile stress (SLS uncracked)
        m_ORIGIN(1 to 3) as Single '        origin of maximum reinforcement: as defined in 260/DC
      END TYPE

      TYPE CBRIC_NRI               ' 361/DC:Z+  reinforcement in Bric-nodes
        m_NG as Long               '        groupnumber
        m_NR as Long               '        nodenumber
        m_AS(1 to 3) as Single     ' [1022] reinforcement 1-3
        m_OAL as Single            '        Euler Angle I
        m_OAF as Single            '        Euler Angle II
        m_SD(1 to 3) as Single     ' [1092] stress range 1-3
        m_SIGB as Single           ' [1092] maximum concrete pressure
        m_SHZMAX as Single         '        maximum skew principal tensile stress (SLS uncracked)
        m_ORIGIN(1 to 3) as Single '        origin of maximum reinforcement: as defined in 260/DC
      END TYPE

      TYPE CBRIC_CFD               ' 390/LC  Fluid flow results in BRIC-elements
        m_NR as Long               '        elementnumber
        m_VX as Single             ' [1212] velocity
        m_VY as Single             ' [1212] velocity
        m_VZ as Single             ' [1212] velocity
        m_Q as Single              ' [1211] stream quantity
        m_HOPT as Single           ' [1001] optimal mesh size
        m_VXA as Single            ' [1212] particle velocity
        m_VYA as Single            ' [1212] particle velocity
        m_VZA as Single            ' [1212] particle velocity
        m_MUED as Single           ' [1220] laminar viscosity
        m_DUX(1 to 3) as Single    ' [  95] gradient values fluid flow du/dx, du/dy, du/dz
        m_DVX(1 to 3) as Single    ' [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
        m_DWX(1 to 3) as Single    ' [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
        m_TK as Single             ' [1222] turbulent energy
        m_MUET as Single           ' [1220] turbulent viscosity
        m_ED as Single             ' [1223] dissipation rate
        m_SCALAR(1 to 4) as Single '        optional scalar parameters
      END TYPE

      TYPE CBRIC_TM                ' 391/LC:0  Maximum Temperature Results in BRICs
        m_NR as Long               '        elementnumber
        m_QX as Single             ' [1218] heat flux
        m_QY as Single             ' [1218] heat flux
        m_QZ as Single             ' [1218] heat flux
        m_Q as Single              ' [1216] Total flux
        m_TEFF as Single           ' [  92] Effective Age
        m_HYDR as Single           '        Hydration degree
        m_LFR as Single            '        Liquid fraction
      END TYPE

      TYPE CBRIC_TMP               ' 391/LC  Temperature Results in BRIC-elements
        m_NR as Long               '        elementnumber
        m_QX as Single             ' [1218] heat flux
        m_QY as Single             ' [1218] heat flux
        m_QZ as Single             ' [1218] heat flux
        m_Q as Single              ' [1216] Total flux
        m_TEFF(1 to 9) as Single   ' [  92] Effective Age
        m_HYDR(1 to 9) as Single   '        Hydration degree
        m_LFR(1 to 9) as Single    '        Liquid fraction
      END TYPE

      TYPE CHASE_PIH               ' 404/NR:0  HASE-Piles in Half-space
        m_ID as Long               '        Identification 0
        m_NPILE as Long            '        Number of piles
        m_MPILE as Long            '        Max. values per pile
        m_NHKNOT as Long           '        Number of nodes
      END TYPE

      TYPE CHASE_PIL               ' 404/NR:+  HASE-Piles in Half-space
        m_ENR as Long              '        External node number
        m_X as Single              ' [1001] Pile X-coordinate
        m_Y as Single              ' [1001] Pile Y-coordinate
        m_DF as Single             ' [1001] Pile-foot diameter
        m_Z as Single              ' [1001] Pile-foot coordinate
        m_MANT as Single           '        Fraction of the total pile load transfered as a pile
        m_PMAM as Single           ' [1190] Max. load transferable by skin friction
        m_INR as Long              '        Ixternal node number
        m_BEZ(1 to 4) as Long      '        Designation
        m_PMAF as Single           ' [1190] Max. load transferable trough pile-foot
        m_ZMAN as Single           ' [1001] Z-coordiante from which the skin friction is active
        m_CFAC as Single           '        Factor of load applied as compression-only
        m_PLEN as Single           ' [1001] Pile length
        m_PLSF as Single           ' [1001] Pile length part inactive for skin friction
        m_D0 as Single             ' [1001] Pile diameter
        m_MNR as Single            '        Pile material number
      END TYPE

      TYPE CSEG_DEF                ' 900/00  Segmentdefinition
        m_ID as Long               '        Identification of segment
        m_TYP as Long              '        Type of segment
        m_BIT as Long              '        Bitpattern idef+4*iref
        m_LEN as Single            ' [1001] Length of segment
        m_ALFA as Single           ' [   5] Angle of start face to axis (0 = match-cast)
        m_ALFR as Single           ' [   5] Angle of end   face to axis (0 = match-cast)
        m_DSPA as Single           ' [1001] Distance of start survey point
        m_DSPE as Single           ' [1001] Distance of end survey point
        m_TEXT(1 to 17) as Long    '        designation of segment
      END TYPE

      TYPE CIL_CTRL0               ' -1/NS:0  Headder of a location
        m_ID as Long               '        ID=0
        m_KWERG as Long            '        KWH for results to be saved
        m_NERG as Long             '        Count on corresponding items
        m_NREL as Long             '        element number
        m_XABS as Single           ' [1001] abszissae for beam sections
        m_TXT(1 to 17) as Long     '        Name of location
      END TYPE

      TYPE CIL_CTRL1               ' -1/NS:?  Headder of a result
        m_IDI as Long              '        Type of result
        m_IERG as Long             '        index of this item + 1000*IMUNIT
        m_LFMAX as Long            '        Offset for load case number of results for maximum
        m_LFMIN as Long            '        Offset for load case number of results for minimum
        m_LPHI as Single           ' [1001] characteristic lenght for dynamic impact factor
        m_TXT(1 to 17) as Long     '        Name of item
      END TYPE

      TYPE CIL_DATA0               ' -1/NS:1????  Influence values (V23, obsoleted)
        m_IDI as Long              '        Type of derivatives defined
        m_X as Single              ' [1001] abszissae along lane
        m_PV as Single             '        Influence value for vertical loading (z)
        m_MT as Single             '        Influence value for torsional loading (x-x)
        m_PL as Single             '        Influence value for longitudinal loading (x)
        m_PT as Single             '        Influence value for transverse loading (y)
        m_DPV as Single            '        Derivative of PV/dx (if IDI&1000)
        m_DMT as Single            '        Derivative of MT/dx (if IDI&0100)
        m_DPL as Single            '        Derivative of PL/dx (if IDI&0010)
        m_DPT as Single            '        Derivative of PT/dx (if IDI&0001)
      END TYPE

      TYPE CIL_DATA                ' -1/NS:1??????  Influence values
        m_IDI as Long              '        Type of derivatives defined
        m_X as Single              ' [1001] abszissae along lane
        m_PV as Single             '        Influence value for vertical loading (z)
        m_MT as Single             '        Influence value for torsional loading (x-x)
        m_PL as Single             '        Influence value for longitudinal loading (x)
        m_PT as Single             '        Influence value for transverse loading (y)
        m_PPOS as Single           '        Influence value for vertical distributed loading
        m_PNEG as Single           '        Influence value for vertical distributed loading
        m_DPV as Single            '        Derivative of PV/dx   (if IDI&100000)
        m_DMT as Single            '        Derivative of MT/dx   (if IDI&010000)
        m_DPL as Single            '        Derivative of PL/dx   (if IDI&001000)
        m_DPT as Single            '        Derivative of PT/dx   (if IDI&000100)
        m_DPPOS as Single          '        Derivative of PPOS/dx (if IDI&000010)
        m_DPNEG as Single          '        Derivative of PNEG/dx (if IDI&000001)
        m_RRES as Single           '        Influence value for right residual loading
        m_LRES as Single           '        Influence value for left residual loading
      END TYPE


'   SOFiSTiK AG
'     sofistik_daten.bas
'     ende der automatisch erzeugten Datei


