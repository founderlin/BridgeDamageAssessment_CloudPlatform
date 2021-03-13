Imports System.Runtime.InteropServices

Module SofistikDataTypes 

'   SOFiSTiK AG
'     sofistik_daten.vb
'     Datei wurde automatisch erzeugt! Keine Änderungen vornehmen!
'     Die benötigten Elemente einfach hier rauskopieren!
'


      Structure CREC_INDX          ' -999/-998  Sorted index on structure names
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer '        Name of this structure
       Dim m_KWH as Integer        '        Kwh
       Dim m_KWL as Integer        '        Kwl
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() as Integer '        Selection string of first integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() as Integer '        Selection string of second integer value
      END Structure

      Structure CREC_VERS          ' -999/-999  Revision number of generating cdbase.txt
       Dim m_VERS as Integer       '        version
      END Structure

      Structure CREC_PUB           ' -999/-999:1  public REC
       Dim m_ID as Integer         '        Identification 1/2
       Dim m_KWH as Integer        '        Kwh
       Dim m_KWL as Integer        '        Kwl (may be NR/LC or number)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() as Integer '        Selection string of first integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() as Integer '        Selection string of second integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer '        name of this structure
       Dim m_VERSION as Integer    '        Version number of description
       Dim m_OPTION as Integer     '        options  0 = default
       Dim m_TYPE as Integer       '        type
      END Structure

      Structure CREC_INT           ' -999/-999:2  internal REC
       Dim m_ID as Integer         '        Identification 1/2
       Dim m_KWH as Integer        '        Kwh
       Dim m_KWL as Integer        '        Kwl (may be NR/LC or number)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() as Integer '        Selection string of first integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() as Integer '        Selection string of second integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer '        name of this structure
       Dim m_VERSION as Integer    '        Version number of description
       Dim m_OPTION as Integer     '        options  0 = default
       Dim m_TYPE as Integer       '        type
      END Structure

      Structure CREC_DAD           ' -999/-999:3  public DAD
       Dim m_ID as Integer         '        Identification 3
       Dim m_KWH as Integer        '        Kwh
       Dim m_KWL as Integer        '        Kwl
      END Structure

      Structure CREC_DESC          ' -999/-999:4  description string to last entry or item
       Dim m_ID as Integer         '        Identification 4
       Dim m_LANG as Integer       '        Language of this item
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_NAME() as Integer '        Description
      END Structure

      Structure CREC_ITM5_STRU     '        Names of the structure elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer
       Dim m_DIM as Integer
       Dim m_DIM1 as Integer
      END Structure

      Structure CREC_ITM5          ' -999/-999:5  item of a record (obsoleted)
       Dim m_ID as Integer         '        Identification 5
       Dim m_NR as Integer         '        number of the item
       Dim m_INDEX as Integer      '        index of the item starting with 0
       Dim m_TYP as Integer        '        Type of the item
       Dim m_OFFSET as Integer     '        offset of the item to be merged
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer '        item name (4 chars significant)
       Dim m_DIM as Integer        '        unit or type of item
       Dim m_DIM1 as Integer       '        first dimension
       Dim m_BEG1 as Integer       '        first index of first dimension
       Dim m_DIM2 as Integer       '        second dimension
       Dim m_BEG2 as Integer       '        first index of second dimension
       Dim m_BITS as Integer       '        additional information Bits
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_STRUCTUR() as CREC_ITM5_STRU '        Names of the structure elements
      END Structure

      Structure CREC_ITEM_STRU     '        Names of the structure elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer
       Dim m_DIM as Integer
       Dim m_TYPE as Integer
       Dim m_DIM1 as Integer
      END Structure

      Structure CREC_ITEM          ' -999/-999:6  item of a record
       Dim m_ID as Integer         '        Identification 6
       Dim m_NR as Integer         '        number of the item
       Dim m_INDEX as Integer      '        index of the item starting with 0
       Dim m_TYP as Integer        '        Type of the item
       Dim m_OFFSET as Integer     '        offset of the item to be merged
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() as Integer '        item name (4 chars significant)
       Dim m_DIM as Integer        '        unit of item
       Dim m_TYPE as Integer       '        type of item
       Dim m_DIM1 as Integer       '        first dimension
       Dim m_BEG1 as Integer       '        first index of first dimension
       Dim m_DIM2 as Integer       '        second dimension
       Dim m_BEG2 as Integer       '        first index of second dimension
       Dim m_BITS as Integer       '        additional information Bits
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_STRUCTUR() as CREC_ITEM_STRU '        Names of the structure elements
      END Structure

      Structure CREC_MIX_MIXI      '        Mixinfo
       Dim m_TYP as Integer
       Dim m_KEYTYP as Integer
       Dim m_MIXFROM as Integer
      END Structure

      Structure CREC_MIX           ' -999/-999:11  mixinfo of a record
       Dim m_ID as Integer         '        Identification 11/12
       Dim m_NKEY as Integer
       Dim m_NLEN as Integer
       Dim m_NMIXFLAG as Integer
       Dim m_SELECTOR as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_MIXINFO() as CREC_MIX_MIXI '        Mixinfo
      END Structure

      Structure CREC_MHD_MIXI      '        Mixinfo
       Dim m_TYP as Integer
       Dim m_KEYTYP as Integer
       Dim m_MIXFROM as Integer
      END Structure

      Structure CREC_MHD           ' -999/-999:12  mixinfo of a record header
       Dim m_ID as Integer         '        Identification 11/12
       Dim m_NKEY as Integer
       Dim m_NLEN as Integer
       Dim m_NMIXFLAG as Integer
       Dim m_SELECTOR as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_MIXINFO() as CREC_MHD_MIXI '        Mixinfo
      END Structure

      Structure CCTRL_010          ' 0/01:999  AccessInfo Last Program
       Dim m_ID as Integer         '        Identifier 999
       Dim m_ACCE as Integer       '        Number of access
       Dim m_VERS as Integer       '        Version number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() as Integer '        Name of Program
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ERR() as Integer '        Name of ERR-File
      END Structure

      Structure CCTRL_011          ' 0/01:?  Messages
       Dim m_ID as Integer         '        Level
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDERR() as Integer '        Number of errortext
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IDSUP() as Integer '        Name of subroutine
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ITEXT() as Integer '        Text value of message
       Dim m_NILIST as Integer     '        count on Integer values of message
       Dim m_NRLIST as Integer     '        count on Real values of message
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_LIST() as Integer '        values of message ILIST+RLIST
      END Structure

      Structure CCTRL_OBJ          ' 0/01:101  involved objects
       Dim m_ID as Integer         '        Identifier = 101
       Dim m_ID2 as Integer        '        bitpattern of specified data
       Dim m_TYPE as Integer       '        KWH of Elementtype (30,31,32,33)
       Dim m_NR as Integer         '        Number of element  (TYPE/NR)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of element in the BIM/CAD system
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_UVW() as Single ' [1001] local coordinates in object
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() as Single ' [1001] bounding box x,y,z min, x,y,z max
      END Structure

      Structure CCTRL_OID          ' 0/01:102  GUId
       Dim m_ID as Integer         '        identifier 102
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of preceeding element
      END Structure

      Structure CSSD_SPE           ' 0/96:1  SSD-Spezial
       Dim m_ID as Integer         '        id==1
       Dim m_TYPE as Integer       '        type of information
       Dim m_IVAL as Integer       '        integer value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_RVAL() as Single '        real values
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ITXT() as Integer '        string value
      END Structure

      Structure CVIS_LC0           ' 0/97:0  active Loadcase
       Dim m_ID as Integer         '        id==0
       Dim m_LFNR as Integer       '        Loadcase number
       Dim m_VIS as Integer        '        unused
      END Structure

      Structure CVIS_LC            ' 0/97:1  Loadcase visualisation
       Dim m_ID as Integer         '        id==1
       Dim m_LFNR as Integer       '        Loadcase number
       Dim m_VIS as Integer        '        Visualisation
      END Structure

const CTRL_ACCESS_MIX = 1
const CTRL_ACCESS_CONVERT = 2
const CTRL_ACCESS_2010 = 4
const CTRL_ACCESS_2012 = 8
const CTRL_ACCESS_2014 = 16
const CTRL_ACCESS_2016 = 32
const CTRL_ACCESS_2018 = 64
const CTRL_ACCESS_2020 = 128
      Structure CCTRL              ' 0/99:*  PrintControl
       Dim m_MAXL as Integer       '        Lines per page
       Dim m_MARG as Integer       '        Left margin
       Dim m_TOBO as Integer       '        Top/bottom margin
       Dim m_MODP as Integer       '        Type of Headding
       Dim m_PAGE as Integer       '        Current page no
       Dim m_LOUT as Integer       '        Output Language
       Dim m_LINP as Integer       '        Input  Language
       Dim m_UNIT as Integer       '        Unit set
       Dim m_ACCE as Integer       '        No of last access
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_PAG() as Integer '        Paging Text
       Dim m_REL_VERS as Integer   '        ReleaseVersion of this database
       Dim m_REL_BITS as Integer   '        Accessbits
      END Structure

      Structure CCTRL_0            ' 0/99:0  AccessInfo
       Dim m_ID as Integer         '        Identifier 0
       Dim m_ACCE as Integer       '        Number of access
       Dim m_VERS as Integer       '        Version number
       Dim m_ERRO as Integer       '        Number of Errors
       Dim m_WARN as Integer       '        Number of Errors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() as Integer '        Name of Program
       Dim m_REL_VERS as Integer   '        ReleaseVersion of last access
      END Structure

      Structure CCTRL_1            ' 0/99:1  AccessTitle
       Dim m_ID as Integer         '        Identifier 1
       Dim m_ACCE as Integer       '        Number of access
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_KOPF() as Integer '        Title of access
      END Structure

      Structure CCTRL_VAR          ' 0/100  Global_CADINP_Variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        name of variable
       Dim m_IND as Integer        '        index for arrays
       Dim m_VAL as Single         '        value of variable
       Dim m_SCOPE as Integer      '        name of scope
       Dim m_DIM as Integer        '        unit of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Comment on variable
      END Structure

      Structure CCTRL_VAP          ' 0/100:???  Private_CADINP_Variable
       Dim m_ID as Integer         '        Identification = ???
       Dim m_IND1 as Integer       '        Lower Index of variable
       Dim m_IND2 as Integer       '        Upper Index of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        Name of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_VAL() as Single '        values of the variable NAME[IND1:IND2]
      END Structure

      Structure CCTRL_DIM          ' 0/101  Unit definitions
       Dim m_IDIM as Integer       '        number of an implicit unit (>999)
       Dim m_UNIA as Integer       '        unit for output (0=do not change)
       Dim m_UNIE as Integer       '        unit for input  (0=do not change)
       Dim m_DIGA as Integer       '        number of digits for output (>10 for Exponential)
       Dim m_DIGE as Integer       '        number of digits for input (=GUI)
      END Structure

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
      Structure CMAT               ' 1/NR:0  MaterialTitle
       Dim m_ID as Integer         '        Identification = 0
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() as Integer '        designation
      END Structure

      Structure CMAT_USER          ' 1/NR:10??  Information on user input
       Dim m_ID as Integer         '        Identification
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_BIT() as Integer '        User input for 001/NR:1
      END Structure

      Structure CMAT_FLUI          ' 1/NR:1  MaterialConstants
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Compression modulus
       Dim m_NUE as Single         ' [1221] Kinematic Viscosity
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_RHO as Single         ' [1189] Density
       Dim m_GAMB as Single        ' [1091] dead weight buyoncy
       Dim m_ALFA as Single        ' [ 107] Temperature Elongation coefficient
      END Structure

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
      Structure CMAT_CONS          ' 1/NR:1  MaterialConstants
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_GAMB as Single        ' [1091] dead weight buyoncy
       Dim m_ALFA as Single        ' [ 107] Temperature Expansion
       Dim m_E90 as Single         ' [1090] Transvers Elasticity
       Dim m_MUE90 as Single       '        anisotrope Poisson
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FY as Single          ' [1092] effective strength
       Dim m_FT as Single          ' [1092] nominal strength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() as Single '        variable parameters
      END Structure

      Structure CMAT_UNDR          ' 1/NR:14  Undrained soil parameters
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_GAMB as Single        ' [1091] dead weight buyoncy
       Dim m_ALFA as Single        ' [ 107] Temperature Expansion
       Dim m_E90 as Single         ' [1090] Transvers Elasticity
       Dim m_MUE90 as Single       '        anisotrope Poisson
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FY as Single          ' [1092] effective strength
       Dim m_FT as Single          ' [1092] nominal strength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() as Single '        variable parameters
      END Structure

      Structure CMAT_FAUL          ' 1/NR:15  Fault/Shear plane
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_GAMB as Single        ' [1091] dead weight buyoncy
       Dim m_ALFA as Single        ' [ 107] Temperature Expansion
       Dim m_E90 as Single         ' [1090] Transvers Elasticity
       Dim m_MUE90 as Single       '        anisotrope Poisson
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FY as Single          ' [1092] effective strength
       Dim m_FT as Single          ' [1092] nominal strength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() as Single '        variable parameters
      END Structure

      Structure CMAT_SWEL          ' 1/NR:16  Swelling parameters
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_GAMB as Single        ' [1091] dead weight buyoncy
       Dim m_ALFA as Single        ' [ 107] Temperature Expansion
       Dim m_E90 as Single         ' [1090] Transvers Elasticity
       Dim m_MUE90 as Single       '        anisotrope Poisson
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FY as Single          ' [1092] effective strength
       Dim m_FT as Single          ' [1092] nominal strength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() as Single '        variable parameters
      END Structure

      Structure CMAT_CONC          ' 1/NR:1  MaterialConcrete
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_RHO as Single         ' [1189] Density
       Dim m_ALFA as Single        ' [ 107] Temperature Elongation coefficient
       Dim m_E90 as Single         ' [1090] Elasticity modulus perpendicular
       Dim m_MUE90 as Single       '        Poissons ratio perpendicular
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FC as Single          ' [1092] effective strength
       Dim m_FCK as Single         ' [1092] nominal strength
       Dim m_FTM as Single         ' [1092] mean value of tensional strength
       Dim m_FTL as Single         ' [1092] lower fractile of tensional strength
       Dim m_FTK as Single         ' [1092] upper fractile of tensional strength
       Dim m_EC as Single          '        compr. failure Energy (deprecated)
       Dim m_ET as Single          ' [ 112] tensile failure energy
       Dim m_MUER as Single        '        friction in the crack
       Dim m_FCM as Single         ' [1092] mean value of strength
       Dim m_RDCL as Single        '        weight class
       Dim m_FCR as Single         ' [1092] calculatoric mean value of strength
       Dim m_ECR as Single         ' [1090] Elasticity modul for worklaw CE
       Dim m_FBD as Single         ' [1092] bond strength (EC2 Table. 5.1.3)
       Dim m_FTD as Single         ' [1092] Initial tensile strength Bemessungszugfestigkeit
       Dim m_FEQR as Single        ' [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
       Dim m_FEQT as Single        ' [1092] Residual tensile strength  Restzugfestigkeit im Bruch
       Dim m_FCFAT as Single       ' [1092] Fatigue Strength
       Dim m_SCMS as Single        '        Material safety for the serviceability law
       Dim m_SCMU as Single        '        Material safety for ultimate stress strain law
       Dim m_SCMC as Single        '        Material safety for the calculatoric law
      END Structure

      Structure CMAT_STEE          ' 1/NR:1  MaterialSteel
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_RHO as Single         ' [1189] Density
       Dim m_ALFA as Single        ' [ 107] Temperature Elongation coefficient
       Dim m_E90 as Single         ' [1090] Elasticity modulus perpendicular
       Dim m_MUE90 as Single       '        Poissons ratio perpendicular
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FY as Single          ' [1092] yield stress
       Dim m_FT as Single          ' [1092] tensile strength
       Dim m_EPS as Single         ' [   9] limit strain
       Dim m_REL1 as Single        '        Relaxation 0.55fpk
       Dim m_REL2 as Single        '        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
       Dim m_R as Single           '        bond coefficient
       Dim m_K1 as Single          '        bondfactor EC2
       Dim m_EH as Single          ' [1090] Hardening module
       Dim m_FE as Single          ' [1092] Proportional stress
       Dim m_EPSE as Single        ' [   9] Plastic strain
       Dim m_FDYN as Single        ' [1092] Dynamic strength
       Dim m_FYC as Single         ' [1092] compr. yield stress
       Dim m_FTC as Single         ' [1092] compress. strength
       Dim m_TMAX as Single        ' [1023] max.plate thickness
       Dim m_BC as Single          '        (eg. Aluminium 1.0/2.0 = "A","B" )
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() as Single
       Dim m_SCMS as Single        '        Material safety for the serviceability law
       Dim m_SCMU as Single        '        Material safety for ultimate stress strain law
       Dim m_SCMC as Single        '        Material safety for the calculatoric law
      END Structure

      Structure CMAT_TIMB          ' 1/NR:1  MaterialTimber
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Material type
       Dim m_CLASS as Integer      '        Classification
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus along the fibres
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_RHO as Single         ' [1189] Density
       Dim m_ALFA as Single        ' [ 107] Temperature Elongation coefficient
       Dim m_E90 as Single         ' [1090] Elasticity modulus perpendicular to fibres
       Dim m_MUE90 as Single       '        Poissons ratio perpendicular
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FYB as Single         ' [1092] Bending strength
       Dim m_FYT as Single         ' [1092] tensile strength along the fibres
       Dim m_FYT90 as Single       ' [1092] tensile strength perpend. the fibres
       Dim m_FYC as Single         ' [1092] compressive strength along the fibres
       Dim m_FYC90 as Single       ' [1092] compressive strength perpend. the fibres
       Dim m_FYS as Single         ' [1092] middle shear strength (Membrane Shear force)
       Dim m_FYST as Single        ' [1092] edge shear strength (Torsion)
       Dim m_FYSB as Single        ' [1092] maximum shear strength (plate shear)
       Dim m_FYB90 as Single       ' [1092] Bending strength perpendicular to fibres
       Dim m_G90 as Single         ' [1090] transverse shear modulus for platebending
       Dim m_SMOD0 as Single       '        Strength Modifier kmod for Service classes
       Dim m_SMOD1 as Single       '        Strength Modifier kmod for Service classes
       Dim m_SMOD2 as Single       '        Strength Modifier kmod for Service classes
       Dim m_SMOD3 as Single       '        Strength Modifier kmod for Service classes
       Dim m_SMOD4 as Single       '        Strength Modifier kmod for Service classes
       Dim m_KDEF as Single        '        Deformation modifier
       Dim m_TMAX as Single        ' [1023] max.plate thickness
       Dim m_SCMS as Single        '        Material safety
       Dim m_SCMU as Single        '        Material safety
       Dim m_SCMC as Single        '        Material safety
      END Structure

      Structure CMAT_BRIC          ' 1/NR:1  MaterialBrickwork
       Dim m_ID as Integer         '        Identification
       Dim m_TYPE as Integer       '        Bric type and strength
       Dim m_CLASS as Integer      '        Mortar class
       Dim m_EMOD as Single        ' [1090] Elasticity Modulus
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_GMOD as Single        ' [1090] Shear modulus
       Dim m_KMOD as Single        ' [1090] Compression modulus
       Dim m_GAM as Single         ' [1091] dead weight
       Dim m_RHO as Single         ' [1189] Density
       Dim m_ALFA as Single        ' [ 107] Temperature Elongation coefficient
       Dim m_E90 as Single         ' [1090] Elasticity modulus perpendicular
       Dim m_MUE90 as Single       '        Poissons ratio perpendicular
       Dim m_ALF as Single         ' [   5] Euler Angle I
       Dim m_BET as Single         ' [   5] Euler Angle II
       Dim m_SCM as Single         '        Material safety
       Dim m_FK as Single          ' [1092] Strength
       Dim m_FB as Single          ' [1092] brick strength
       Dim m_FT as Single          ' [1092] tensile strength
       Dim m_FV as Single          ' [1092] shear strength
       Dim m_FV0 as Single         ' [1092] adhesional strength
       Dim m_FBT as Single         ' [1092] tens.brick strength
       Dim m_FM as Single          ' [1092] mortar strength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_DUMMY() as Single
       Dim m_SCMS as Single        '        Material safety
       Dim m_SCMU as Single        '        Material safety
       Dim m_SCMC as Single        '        Material safety
      END Structure

      Structure CMAT_SERV          ' 1/NR:2  StressStrainLaw (Servicability)
       Dim m_ID as Integer         '        Identification
       Dim m_TEMP as Integer       '        Temperature
       Dim m_TYPE as Integer       '        Type of law
       Dim m_SCM as Single         '        Safety factor
       Dim m_EPS as Single         ' [   9] Elongation at TEMP if TEMP>0
       Dim m_RES1 as Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
       Dim m_RES2 as Single        '        Tensile Strength  Concrete   for 21:24
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CMAT_ULTI          ' 1/NR:3  StressStrainLaw (Ultimate Limit state)
       Dim m_ID as Integer         '        Identification
       Dim m_TEMP as Integer       '        Temperature
       Dim m_TYPE as Integer       '        Type of law
       Dim m_SCM as Single         '        Safety factor
       Dim m_EPS as Single         ' [   9] Elongation at TEMP if TEMP>0
       Dim m_RES1 as Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
       Dim m_RES2 as Single        '        Tensile Strength  Concrete   for 21:24
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CMAT_NONL          ' 1/NR:4  StressStrainLaw (Nonlinear Mean Values)
       Dim m_ID as Integer         '        Identification
       Dim m_TEMP as Integer       '        Temperature
       Dim m_TYPE as Integer       '        Type of law
       Dim m_SCM as Single         '        Safety factor
       Dim m_EPS as Single         ' [   9] Elongation at TEMP if TEMP>0
       Dim m_RES1 as Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
       Dim m_RES2 as Single        '        Tensile Strength  Concrete   for 21:24
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CMAT_BED           ' 1/NR:7  MaterialBedding
       Dim m_ID as Integer         '        Identification
       Dim m_MNR as Integer        '        Materialnumber of bedding boddy
       Dim m_IBT as Integer        '        Type of bedding mechanism
       Dim m_C as Single           ' [1097] Bedding Coefficient
       Dim m_CT as Single          ' [1097] Tangential Bedding
       Dim m_RISS as Single        ' [1092] rupture stress
       Dim m_FLIE as Single        ' [1092] yield   stress
       Dim m_MUE as Single         '        friction coefficient
       Dim m_KOH as Single         ' [1092] cohesion
       Dim m_DIL as Single         '        dilatancy coeffic.
       Dim m_GAM as Single         ' [1184] mass of bedding
       Dim m_H as Single           ' [1001] reference length
      END Structure

      Structure CMAT_LAY           ' 1/NR:8  MaterialLayerStructure
       Dim m_ID as Integer         '        Identification
       Dim m_NM as Integer         '        Number of a material
       Dim m_I_2 as Integer
       Dim m_T as Single           ' [1010] Thickness
      END Structure

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
      Structure CMAT_HYD           ' 1/NR:9  MaterialConductivity
       Dim m_ID as Integer         '        Identification
       Dim m_T as Integer          '        Temperature / pressure
       Dim m_TYPE as Integer       '        Type of Material law
       Dim m_D as Single           '        special Parameter
       Dim m_C as Single           '        Storage Capacity
       Dim m_N as Single           '        Porosity/humidity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_K() as Single '        Conductivity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_KLOC() as Single '        Conductivity
      END Structure

      Structure CMAT_SPE           ' 1/NR:90  MaterialSpecial
       Dim m_ID as Integer         '        Identification = 90
       Dim m_TYPE as Integer       '        type of material value
       Dim m_EXP as Integer        '        exposition class identifier (0=all classes)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_RVAL() as Single '        real material values
      END Structure

      Structure CBORE              ' 2/NR:0  SoilProfile
       Dim m_ID as Integer         '        identifier 0 (always the first record)
       Dim m_X as Single           ' [1001] X_ordinate
       Dim m_Y as Single           ' [1001] Y_ordinate
       Dim m_Z as Single           ' [1001] Z_ordinate
       Dim m_DX as Single          '        direction of axis
       Dim m_DY as Single          '        direction of axis
       Dim m_DZ as Single          '        direction of axis
       Dim m_ALF as Single         ' [   5] Angle of reference
       Dim m_HGWL as Single        ' [1006] lower ground water level
       Dim m_HGWH as Single        ' [1006] upper ground water level
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_I_10() as Single
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Profile
      END Structure

      Structure CBORE_LAY          ' 2/NR:1  Soillayer
       Dim m_ID as Integer         '        Identifier 1
       Dim m_MNR as Integer        '        Material number
       Dim m_VARI as Integer       '        Type of stiffness variation
       Dim m_ILAY as Integer       '        Additional layer information
       Dim m_I_4 as Integer        '        reserved
       Dim m_I_5 as Integer        '        reserved
       Dim m_S as Single           ' [1001] Ordinate on bore profile axis (positive)
       Dim m_ES as Single          ' [1096] Stiffness Modulus
       Dim m_DES as Single         ' [1096] Increment of ES within current layer
       Dim m_MUE as Single         '        Poissons ratio
       Dim m_PMAX as Single        ' [1096] Max. pressure at pile foot
       Dim m_PMAL as Single        ' [1096] Max. lateral pressure
       Dim m_C as Single           ' [1096] Cohesion
       Dim m_PHI as Single         ' [   5] Soil/Pile friction angle
       Dim m_GAM as Single         ' [1091] nominal weight
       Dim m_GAMB as Single        ' [1091] nominal weight under buoyancy
      END Structure

      Structure CBORE_TAB          ' 2/NR:10  SoilTabdefinition
       Dim m_ID as Integer         '        Identifier 10
       Dim m_OPT as Integer        '        Option
       Dim m_CLASS as Integer      '        Classification subtype
       Dim m_FACS as Single        '        Factor on stresses
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_B() as Single ' [1001] Width of foundation
      END Structure

      Structure CBORE_TAD          ' 2/NR:11  SoilTabvalues
       Dim m_ID as Integer         '        Identifier 11
       Dim m_I_1 as Integer        '        reserved
       Dim m_I_2 as Integer        '        reserved
       Dim m_D as Single           ' [1006] Embedment depth of foundation
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_SIGD() as Single ' [1089] design stresses at specified depth values
      END Structure

      Structure CBORE_BAX          ' 2/NR:1001  BoreProfileAxial
       Dim m_ID as Integer         '        identifier 1001
       Dim m_Z1 as Single          '        parameter s on start
       Dim m_Z2 as Single          '        parameter s on end
       Dim m_K0 as Single          ' [1096] constant bedding
       Dim m_K1 as Single          ' [1096] parabolic bedding
       Dim m_K2 as Single          ' [1096] linear bedding
       Dim m_K3 as Single          ' [1096] quadratic bedding
       Dim m_M0 as Single          ' [1153] cohesive loading
       Dim m_C0 as Single          ' [1153] cohesion
       Dim m_TANR as Single        '        friction angle
       Dim m_TAND as Single        '        dilatancy angle
       Dim m_KQ as Single          '        pressure coefficient
       Dim m_PMAX as Single        ' [1101] maxforce at pile foot
      END Structure

      Structure CBORE_BLA          ' 2/NR:1002  BoreProfileTransverse
       Dim m_ID as Integer         '        identifier 1002
       Dim m_Z1 as Single          '        parameter s on start
       Dim m_Z2 as Single          '        parameter s on end
       Dim m_K0 as Single          ' [1096] constant bedding
       Dim m_K1 as Single          ' [1096] parabolic bedding
       Dim m_K2 as Single          ' [1096] linear bedding
       Dim m_K3 as Single          ' [1096] quadratic bedding
       Dim m_F0 as Single          '        peripher Distribution
       Dim m_F1 as Single
       Dim m_F2 as Single
       Dim m_PM1 as Single         ' [1153] maximum value on upper ordinate
       Dim m_PM2 as Single         ' [1153] maximum value on lower ordinate
       Dim m_P0 as Single          '        peripher Distribution
       Dim m_P1 as Single
       Dim m_P2 as Single
       Dim m_P3 as Single
      END Structure

      Structure CBORE_BAM          ' 2/NR:1003  BoreProfileMoment
       Dim m_ID as Integer         '        identifier 1003
       Dim m_Z1 as Single          '        parameter s on start
       Dim m_Z2 as Single          '        parameter s on end
       Dim m_K0 as Single          ' [1099] constant bedding
       Dim m_K1 as Single          ' [1099] parabolic bedding
       Dim m_K2 as Single          ' [1099] linear bedding
       Dim m_K3 as Single          ' [1099] quadratic bedding
      END Structure

      Structure CBORE_DYA          ' 2/NR:1011  BoreProfileAxialDynamic
       Dim m_ID as Integer         '        identifier 1011
       Dim m_Z1 as Single          '        parameter s on start
       Dim m_Z2 as Single          '        parameter s on end
       Dim m_D0 as Single          ' [ 105] constant damping
       Dim m_D1 as Single          ' [ 105] parabolic damping
       Dim m_D2 as Single          ' [ 105] linear damping
       Dim m_D3 as Single          ' [ 105] quadratic damping
      END Structure

      Structure CBORE_DYL          ' 2/NR:1012  BoreProfileTransverseDynamic
       Dim m_ID as Integer         '        identifier 1012
       Dim m_Z1 as Single          '        parameter s on start
       Dim m_Z2 as Single          '        parameter s on end
       Dim m_D0 as Single          ' [ 105] constant damping
       Dim m_D1 as Single          ' [ 105] parabolic damping
       Dim m_D2 as Single          ' [ 105] linear damping
       Dim m_D3 as Single          ' [ 105] quadratic damping
       Dim m_M0 as Single          ' [1181] constant soil mass
       Dim m_M2 as Single          ' [1181] linear soil mass
      END Structure

const AXIS_SUBTYPE_NONE = 0
const AXIS_SUBTYPE_AXIS = 1
const AXIS_SUBTYPE_BEAM = 2
const AXIS_SUBTYPE_LANE = 10
const AXIS_SUBTYPE_BGEO = 11
const AXIS_SUBTYPE_TEND = 12
const AXIS_SUBTYPE_POST = 15
const AXIS_SUBTYPE_AUXI = 19
const AXIS_SUBTYPE_GRAF = 90
      Structure CAXIS              ' 3/ID:0  Geometric Axis
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_ID1 as Integer        '        subtype of axis
       Dim m_ID2 as Integer        '        reserved
       Dim m_ID3 as Integer        '        reserved
       Dim m_ID4 as Integer        '        reserved
       Dim m_ID5 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Line
      END Structure

      Structure CAXIS_REF          ' 3/ID:-  Reference to another Geometry
       Dim m_IGM as Integer        '        negative value of the master geometry 03/abs(IGM)
       Dim m_IGS as Integer        '        optional identifier of a secondary axis
       Dim m_SMIN as Single        '        min parameter on referenced axis
       Dim m_SMAX as Single        '        max parameter on referenced axis
      END Structure

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
      Structure CAXIS_GEO          ' 3/ID:??  Geometric properties
       Dim m_ILN as Integer        '        Code of geometry
       Dim m_GPG as Single         ' [1001] geometry parameter 1
       Dim m_GPA as Single         ' [1001] geometry parameter 2
       Dim m_DD as Single          ' [1001] arc length
       Dim m_S1 as Single          '        parameter s on start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() as Single ' [1001] Ordinate of start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() as Single '        Tangent of start
       Dim m_RG1 as Single         ' [1009] in-plane curvature
       Dim m_RA1 as Single         ' [1009] vertical curvature
       Dim m_S2 as Single          '        parameter s on end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() as Single ' [1001] Ordinate of endpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() as Single '        Tangent of endpoint
       Dim m_RG2 as Single         ' [1009] in-plane curvature
       Dim m_RA2 as Single         ' [1009] vertical curvature
       Dim m_XAT as Single         ' [1001] relat. startordinate
      END Structure

      Structure CAXIS_NKN          ' 3/ID:90  Knots of a Nurb
       Dim m_ILN as Integer        '        ID=90
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Single '        Knot-Vector
      END Structure

      Structure CSLN_NKN           ' 39/NR:90  Knots of a Nurb
       Dim m_ILN as Integer        '        ID=90
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Single '        Knot-Vector
      END Structure

      Structure CAXIS_CPT          ' 3/ID:91  Control point of a Nurb
       Dim m_ILN as Integer        '        ID=91
       Dim m_W as Single           '        Weight
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction
      END Structure

      Structure CSLN_CPT           ' 39/NR:91  Control point of a Nurb
       Dim m_ILN as Integer        '        ID=91
       Dim m_W as Single           '        Weight
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction
      END Structure

      Structure CAXIS_PT           ' 3/ID:92  Data point on curve
       Dim m_ILN as Integer        '        ID=92
       Dim m_S as Single           '        Parameter along curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction
      END Structure

      Structure CSLN_PT            ' 39/NR:92  Data point on curve
       Dim m_ILN as Integer        '        ID=92
       Dim m_S as Single           '        Parameter along curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction
      END Structure

      Structure CAXIS_ARC          ' 3/ID:93  Circular Arc
       Dim m_ILN as Integer        '        ID=93
       Dim m_IDF as Integer        '        Definition selected
       Dim m_R as Single           ' [1001] Radius of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates of center
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction of plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() as Single ' [1001] optional start point of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() as Single ' [1001] optional end point of arc
      END Structure

      Structure CSLN_ARC           ' 39/NR:93  Circular Arc
       Dim m_ILN as Integer        '        ID=93
       Dim m_IDF as Integer        '        Definition selected
       Dim m_R as Single           ' [1001] Radius of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates of center
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        upward direction of plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() as Single ' [1001] optional start point of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() as Single ' [1001] optional end point of arc
      END Structure

      Structure CAXIS_SPT          ' 3/ID:97  Station point on a Nurb
       Dim m_ILN as Integer        '        ID=97
       Dim m_S as Single           '        Station value at data point
       Dim m_L as Single           ' [1001] Length (prescribed if XYZ==0.0)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates for 3D-intersection plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        Direction (nx,ny,nz) of normal of the plane
      END Structure

      Structure CAXIS_VIZ          ' 3/ID:98  Data points for visualisation
       Dim m_ILN as Integer        '        ID=98
       Dim m_COLOR as Integer      '        hexadecimal RGB-value (e.g. 99AAFF)
       Dim m_THICK as Integer      '        Thickness in pixel
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_PTS() as Single ' [1001] Data Points
      END Structure

      Structure CAXIS_OBB          ' 3/ID:99  Oriented Boundig Box
       Dim m_ILN as Integer        '        ID=99
       Dim m_S1 as Single          '        Parameter on Start
       Dim m_S2 as Single          '        Parameter on end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_TA() as Single '        Transformation Matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Center of Box
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XI() as Single ' [1001] Half widths
      END Structure

      Structure CAXIS_ATB          ' 3/ID:101  Geometric segments of axis plan view
       Dim m_ID0 as Integer        '        ident=101
       Dim m_ID1 as Integer        '        specification type
       Dim m_ID2 as Integer        '        type of transition curve to be used
       Dim m_S as Single           '        Station value at tangent
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_L() as Single ' [1001] Length of segment
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_R() as Single ' [1001] Radius mid & start & end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Startpoint of tangent
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        Tangential direction
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_D() as Single ' [1001] Distance to point on curve (start/end)
       Dim m_TAU as Single         ' [   5] deflection angle
       Dim m_TXT as Integer        '        Identifier of this sequence
      END Structure

      Structure CAXIS_VTB          ' 3/ID:102  Geometric properties for axis heights
       Dim m_ID0 as Integer        '        ident=102
       Dim m_ID1 as Integer        '        specification type
       Dim m_ID2 as Integer        '        reserved
       Dim m_S as Single           '        Parameter s along the axis
       Dim m_H as Single           ' [1001] Height of gradient polygon
       Dim m_R as Single           ' [1001] Radius of curvature at this point
       Dim m_X as Single           ' [1001] Calculated true length along the axis
       Dim m_T as Single           ' [1001] Calculated secant length along the axis
      END Structure

      Structure CAXIS_ITB          ' 3/ID:103  Placement at axis position
       Dim m_ID0 as Integer        '        ident=103
       Dim m_IDS as Integer        '        Enum of secondary axis
       Dim m_TYP as Integer        '        properties of this placement
       Dim m_NPT as Integer        '        point number
       Dim m_GRP as Integer        '        group number behind that placement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NOS() as Integer '        Number of section before and behind that placement
       Dim m_SEGT as Integer       '        identifier of a segment see (900/0) behind that placement
       Dim m_S as Single           '        Parameter s of this section
       Dim m_Y as Single           ' [1001] additional transverse offset
       Dim m_Z as Single           ' [1001] additional vertical offset
       Dim m_ALF as Single         ' [   5] Rotation about global Z
       Dim m_ALFX as Single        ' [   5] Rotation about local axis x
       Dim m_ALFY as Single        ' [   5] Rotation about transverse y
       Dim m_ALFZ as Single        ' [   5] Rotation about vertical   z
       Dim m_INCR as Single        ' [   5] Inclination to the right +y
       Dim m_INCL as Single        ' [   5] Inclination to the left  -y
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() as Integer '        Formula string to evaluate the value S
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Placement
      END Structure

      Structure CAXIS_ITS          ' 3/ID:104  Secondary axis definition
       Dim m_ID0 as Integer        '        Ident=104
       Dim m_IDS as Integer        '        Enum of secondary axis (1='A' to 26 ='Z')
       Dim m_IREF as Integer       '        Reference to external axis geometry
       Dim m_NPT as Integer        '        offset for structural points along the axis
       Dim m_GRP as Integer        '        group number (:103 is always added as an offset)
       Dim m_Y as Single           ' [1001] constant or maximum value of y offset
       Dim m_Z as Single           ' [1001] constant or maximum value of z offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_Y_V() as Integer '        variable name for y offset (see :110)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_Z_V() as Integer '        variable name for z offset (see :110)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation (only for first point of a sequence)
      END Structure

      Structure CAXIS_PSM          ' 3/ID:105  Prestress method
       Dim m_ID0 as Integer        '        ident=105
       Dim m_IDT as Integer        '        Identifier of Tendon
       Dim m_TYPE as Integer       '        Type of Spline geometry
       Dim m_NSP as Integer        '        Number of tendon elements
       Dim m_ID5 as Integer        '        Placement of tendons
       Dim m_JACK as Integer       '        Jacking procedure
       Dim m_LIRE as Integer       '        Sides for jacking
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_IBA() as Integer '        Construction stage identifiers
       Dim m_NRSV as Integer       '        number of jacking method
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DUMMY() as Integer '        reserved
       Dim m_FAK as Single         '        factor for prestress
       Dim m_LITZ as Single        '        partial number of strands
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FRSP() as Single ' [1001] Length controls for free tendon geometry
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ZSP() as Single ' [1011] Distances of tendon to extreme fiber upper/lower
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXTL() as Integer '        Designation of layer of Tendons
      END Structure

      Structure CAXIS_PSP          ' 3/ID:106  Prestress placements
       Dim m_ID0 as Integer        '        ident=106
       Dim m_TYP as Integer        '        Type of placement
       Dim m_ID2 as Integer        '        Type of station data (bitpattern)
       Dim m_ID3 as Integer        '        reserved
       Dim m_ID4 as Integer        '        reserved
       Dim m_ID5 as Integer        '        reserved
       Dim m_S as Single           '        Station along axis
       Dim m_ZT as Single          ' [1011] Distances of tendon to extreme fiber upper/lower
       Dim m_DZT as Single         '        inclination of tendon to axis
      END Structure

      Structure CAXIS_PLC          ' 3/ID:107  Placement at axis position
       Dim m_ID0 as Integer        '        ident=107
       Dim m_IDS as Integer        '        Enum of secondary axis
       Dim m_TYP as Integer        '        properties of this placement
       Dim m_NPT as Integer        '        point number
       Dim m_GRP as Integer        '        group number behind that placement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NOS() as Integer '        Number of section before and behind that placement
       Dim m_IB0 as Integer        '        general bit-mask
       Dim m_IDP as Integer        '        identifier of this placement
       Dim m_SEGT as Integer       '        identifier of a segment see (900/0) behind that placement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_RES() as Integer '        reserved
       Dim m_S as Single           '        Parameter s of this section
       Dim m_Y as Single           ' [1001] additional transverse offset
       Dim m_Z as Single           ' [1001] additional vertical offset
       Dim m_ALF as Single         ' [   5] Rotation about global Z
       Dim m_ALFX as Single        ' [   5] Rotation about local axis x
       Dim m_ALFY as Single        ' [   5] Rotation about transverse y
       Dim m_ALFZ as Single        ' [   5] Rotation about vertical   z
       Dim m_INCR as Single        ' [   5] Inclination to the right +y
       Dim m_INCL as Single        ' [   5] Inclination to the left  -y
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() as Integer '        Formula string to evaluate the value S
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of placement
      END Structure

      Structure CAXIS_OPT          ' 3/ID:10107  Placement options
       Dim m_ID0 as Integer        '        ident=10107
       Dim m_A_FILTER as Integer   '        Filter for axis
       Dim m_T_FILTER as Integer   '        Filter for axis type
      END Structure

      Structure CAXIS_PRP          ' 3/ID:110  General properties of axis
       Dim m_ID0 as Integer        '        ident=110
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        Name of this item
       Dim m_TYP as Integer        '        Continuity Type of this data point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_S_VAL() as Single '        Parameter s of this section and values
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() as Integer '        Formula string to evaluate the value S
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_VRULE() as Integer '        Formula string to evaluate the value VAL
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_DVRULE() as Integer '        Formula string to evaluate the value dVAL/dS
      END Structure

      Structure CGAXD_ATB          ' 3/ID:121  Geometric segments of axis plan view (double precision)
       Dim m_ID0 as Integer        '        ident=121
       Dim m_ID1 as Integer        '        specification type
       Dim m_ID2 as Integer        '        type of transition curve to be used
       Dim m_ID3 as Integer        '        reserved
       Dim m_S as Double           '        Station value at tangent
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_L() as Double ' [1001] Length of segment
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_R() as Double ' [1001] Radius mid & start & end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Double ' [1001] Startpoint of tangent
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Double '        Tangential direction
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_D() as Double ' [1001] Distance to point on curve (start/end)
       Dim m_TAU as Double         ' [   5] deflection angle
       Dim m_TXT0 as Integer       '        reserved
       Dim m_TXT as Integer        '        Identifier of this sequence
      END Structure

      Structure CGAXD_VTB          ' 3/ID:122  Geometric properties for axis heights (double precision)
       Dim m_ID0 as Integer        '        ident=122
       Dim m_ID1 as Integer        '        specification type
       Dim m_ID2 as Integer        '        reserved
       Dim m_ID3 as Integer        '        reserved
       Dim m_S as Double           '        Parameter s along the axis
       Dim m_H as Double           ' [1001] Height of gradient polygon
       Dim m_R as Double           ' [1001] Radius of curvature at this point
       Dim m_X as Double           ' [1001] Calculated true length along the axis
       Dim m_T as Double           ' [1001] Calculated secant length along the axis
      END Structure

const GAXD_GEO_DEFAULT = 181
const GAXD_GEO_PROJECT = 182
      Structure CGAXD_GEO          ' 3/ID:18?  Geometric properties
       Dim m_ILN as Integer        '        Code of geometry
       Dim m_ID1 as Integer        '        reserved
       Dim m_GPG as Double         ' [1001] geometry parameter 1
       Dim m_GPA as Double         ' [1001] geometry parameter 2
       Dim m_DD as Double          ' [1001] arc length
       Dim m_S1 as Double          '        parameter s on start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() as Double ' [1001] Ordinate of start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() as Double '        Tangent of start
       Dim m_RG1 as Double         ' [1009] in-plane curvature
       Dim m_RA1 as Double         ' [1009] vertical curvature
       Dim m_S2 as Double          '        parameter s on end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() as Double ' [1001] Ordinate of endpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() as Double '        Tangent of endpoint
       Dim m_RG2 as Double         ' [1009] in-plane curvature
       Dim m_RA2 as Double         ' [1009] vertical curvature
       Dim m_XAT as Double         ' [1001] relat. startordinate
      END Structure

      Structure CGAXD_NKN          ' 3/ID:190  Knots of a Nurb
       Dim m_ILN as Integer        '        ID=190
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Double '        Knot-Vector
      END Structure

      Structure CGAXD_CPT          ' 3/ID:191  Control point of a Nurb
       Dim m_ILN as Integer        '        ID=191
       Dim m_ID1 as Integer        '        reserved
       Dim m_W as Double           '        Weight
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Double ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Double '        upward direction
      END Structure

      Structure CGAXD_PT           ' 3/ID:192  Data point on curve
       Dim m_ILN as Integer        '        ID=192
       Dim m_ID1 as Integer        '        specification type
       Dim m_S as Double           '        Parameter along curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Double ' [1001] Coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Double '        direction
      END Structure

      Structure CGAXD_ARC          ' 3/ID:193  Circular Arc
       Dim m_ILN as Integer        '        ID=193
       Dim m_IDF as Integer        '        Definition selected
       Dim m_R as Double           ' [1001] Radius of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Double ' [1001] Coordinates of center
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Double '        upward direction of plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() as Double ' [1001] optional start point of arc
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() as Double ' [1001] optional end point of arc
      END Structure

      Structure CAXIS_TRL          ' 3/ID:300  Properties for train loading
       Dim m_ID0 as Integer        '        ident 300
       Dim m_NRA as Integer        '        Number of the lane (0:99)
       Dim m_NRS as Integer        '        Number of the segment
       Dim m_BTYP as Integer       '        Literal of default type
       Dim m_SA as Single          '        Parameter s of start of this section
       Dim m_SE as Single          '        Parameter s of end of this section
       Dim m_YCA as Single         ' [1001] Center ordinate of lane at SA
       Dim m_YCE as Single         ' [1001] Center ordinate of lane at SE
       Dim m_YRA as Single         ' [1001] Right boundary at SA of lane area
       Dim m_YRE as Single         ' [1001] Right boundary at SE of lane area
       Dim m_YLA as Single         ' [1001] Left boundary at SA of lane area
       Dim m_YLE as Single         ' [1001] Left boundary at SE of lane area
       Dim m_L as Single           ' [1001] Reference length for impact factor
       Dim m_HSA as Single         ' [1001] Total height of traffic lane above axis at SA
       Dim m_HSE as Single         ' [1001] Total height of traffic lane above axis at SE
       Dim m_INCA as Single        ' [   5] Inclination within lane at SA
       Dim m_INCE as Single        ' [   5] Inclination within lane at SE
       Dim m_HEFF as Single        ' [1001] Height of rail and sleeper construction
       Dim m_BEFF as Single        ' [1001] Effective length of sleeper
       Dim m_DEFF as Single        ' [1001] Width of sleepers
       Dim m_INCD as Single        '        Inclination of load distribution (e.g. 1:4)
       Dim m_ASL as Single         ' [1001] Distance of Sleepers or mounting points
      END Structure

      Structure CTEND              ' 4/ID:0  Prestressing Schemes
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_KEY as Integer        '        Control bits + Info
       Dim m_ID2 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Main Designation of company and scheme
      END Structure

      Structure CTEND_1            ' 4/ID:1  Tendon of Prestressing Schemes
       Dim m_ID0 as Integer        '        identifier 1
       Dim m_MNR as Integer        '        Material number of Prestressing Steel
       Dim m_ID2 as Integer        '        reserved
       Dim m_ZV as Single          ' [1028] Nominal force
       Dim m_AZ as Single          ' [1020] Area of tendon
       Dim m_RNLI as Single        '        Number or wires
       Dim m_SLS as Single         ' [  16] Slip at anchor
       Dim m_SLK as Single         ' [  16] Slip at coupling
       Dim m_SLF as Single         ' [  16] Slip at fixed end
       Dim m_VLS as Single         '        Loss at anchor
       Dim m_VLK as Single         '        Loss at coupling
       Dim m_VLF as Single         '        Loss at fixed end
       Dim m_DLS as Single         ' [1001] Straight at anchor
       Dim m_DLK as Single         ' [1001] Straight at coupling
       Dim m_DLF as Single         ' [1001] Straight at fixed end
       Dim m_DI as Single          ' [1023] inner diameter of duct
       Dim m_DA as Single          ' [1023] outer diamtere of duct
       Dim m_RMIN as Single        ' [1001] minimum radius
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_BETA() as Single ' [  17] unintended angles
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_RMUE() as Single '        Friction coefficients
       Dim m_EXZ as Single         ' [1011] max exzentricity
       Dim m_EACHS as Single       ' [1011] distance between
       Dim m_ERAND as Single       ' [1011] distance to outer edge
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_BLOCK() as Single '        reserved extra data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Designation of tendon
      END Structure

      Structure CTEND_2            ' 4/ID:2  Anchor of Prestressing Schemes
       Dim m_ID0 as Integer        '        identifier 2
       Dim m_ID1 as Integer        '        Type of anchor
       Dim m_TYP as Integer        '        Type of anchor geometry
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ANKER() as Single '        Data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Designation of anchor
      END Structure

      Structure CTEND_3            ' 4/ID:3  Jack of Prestressing Schemes
       Dim m_ID0 as Integer        '        identifier 2
       Dim m_ID1 as Integer        '        reserved
       Dim m_TYP as Integer        '        Type of jack
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_JACK() as Single '        Data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Designation of jack
      END Structure

      Structure CAREA              ' 5/ID:0  Geometric Area
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_NG as Integer         '        Type of surface representation
       Dim m_GID1 as Integer       '        Axis identifier of first reference axis
       Dim m_GID2 as Integer       '        Axis identifier of second reference axis
       Dim m_MGRI as Integer       '        number of data/control points in s of mesh
       Dim m_NGRI as Integer       '        number of data/control points in t of mesh
       Dim m_MSPL as Integer       '        degree of B-spline in s direction
       Dim m_NSPL as Integer       '        degree of B-spline in t direction
       Dim m_SFLG as Integer       '        property options of surface
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() as Single '        Transformation
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() as Single '        additional Parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() as Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Line
      END Structure

      Structure CAREA_CPT          ' 5/ID:10  Control points of area
       Dim m_ID as Integer         '        Identification of control point data = 10
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_XPAR() as Single '        spline grid and coefficients
      END Structure

      Structure CAREA_PTS          ' 5/ID:11  AreaPointonSurface
       Dim m_ID as Integer         '        Identification of surface description = 11
       Dim m_IT as Integer         '        Type of point
       Dim m_M as Integer          '        Rasterlocation of mesh (0 < m < mgri )
       Dim m_N as Integer          '        Rasterlocation of mesh (0 < n < ngri )
       Dim m_W as Single           '        the weight of NURBS control point
       Dim m_X as Single           ' [1001] X-ordinate
       Dim m_Y as Single           ' [1001] Y-ordinate
       Dim m_Z as Single           ' [1001] Z-ordinate
       Dim m_T as Single           ' [1010] Thickness
      END Structure

      Structure CAREA_CPI          ' 5/ID:12  COONsPatchInfo
       Dim m_ID as Integer         '        Identification of COONs blending edges 12
       Dim m_IT as Integer         '        Type of blending
       Dim m_IU0 as Integer        '        No of geometry line for u=umin (left)
       Dim m_IU1 as Integer        '        No of geometry line for u=umax (right)
       Dim m_IV0 as Integer        '        No of geometry line for v=vmin (lower)
       Dim m_IV1 as Integer        '        No of geometry line for v=vmax (upper)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_SP() as Single '        Length parameters for the edges iu0,iu1,iv0,iv1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() as Single '        umin,umax,vmin,vmax of the parameter plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_CXYZ() as Single '        Coordinates of the corner points C1,C2,C3,C4
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_TINC() as Single '        inclinations for a bicubic patch as vectors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TWIST() as Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END Structure

      Structure CAREA_NKN          ' 5/ID:9?  Knots of a Nurb
       Dim m_ILN as Integer        '        ID
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Single '        Knot-Vector
      END Structure

      Structure CGARD_PTS          ' 5/ID:290  AreaPointonSurface
       Dim m_ID as Integer         '        Id = 290
       Dim m_IT as Integer         '        Type of point
       Dim m_M as Integer          '        Rasterlocation of mesh (0 < m < mgri )
       Dim m_N as Integer          '        Rasterlocation of mesh (0 < n < ngri )
       Dim m_W as Double           '        the weight of NURBS control point
       Dim m_X as Double           ' [1001] X-ordinate
       Dim m_Y as Double           ' [1001] Y-ordinate
       Dim m_Z as Double           ' [1001] Z-ordinate
       Dim m_T as Double           ' [1010] Thickness
      END Structure

      Structure CGARD_NKU          ' 5/ID:291  Knots of a Nurb
       Dim m_ILN as Integer        '        ID
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Double '        Knot-Vector
      END Structure

      Structure CGARD_NKV          ' 5/ID:292  Knots of a Nurb
       Dim m_ILN as Integer        '        ID
       Dim m_DEG as Integer        '        Order of Spline
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() as Double '        Knot-Vector
      END Structure

      Structure CCON_0             ' 8/ID:0  Connection Headder
       Dim m_IDS as Integer        '        Identification = 0
       Dim m_TYP as Integer        '        Type of connection
       Dim m_MAT as Integer        '        Materialnumber for all plates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        designation of connection
      END Structure

      Structure CCON_BOL           ' 8/ID:1  Definition of Bolts
       Dim m_IDS as Integer        '        Identification = 1
       Dim m_TYP as Integer        '        Type of hole
       Dim m_MAT as Integer        '        Materialdesignation of bolt
       Dim m_D as Single           ' [1011] Diameter of bolt
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NORM() as Integer '        Designation of product code
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        designation of bolt
      END Structure

      Structure CCON_WEL           ' 8/ID:2  Definition of Weldings
       Dim m_IDS as Integer        '        Identification = 2
       Dim m_TYP as Integer        '        Type of weld
       Dim m_MAT as Integer        '        Materialnumber of weld (not used)
       Dim m_T as Single           ' [1011] Thickness of weld
       Dim m_AW as Single          '        Reduction factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        designation of weld
      END Structure

      Structure CCON_CLE           ' 8/ID:3  Definition of Cleats (Angle/Latch)
       Dim m_IDS as Integer        '        Identification = 3
       Dim m_TYP as Integer        '        Enum of type (angle/latch not really enforced)
       Dim m_MAT as Integer        '        Material number of the plate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_BOL() as Integer '        id of bolts
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NBB() as Integer '        Number of bolts in width direction
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NBL() as Integer '        Number of bolts in angle directions 1 & 2
       Dim m_T as Single           ' [1011] Thickness of cleat
       Dim m_B as Single           ' [1011] Width/Height of cleat
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_L() as Single ' [1011] Length of angles
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_W() as Single ' [1011] Distances
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_A() as Single ' [1011] weld thickness for NBL(i) if welding is used
       Dim m_TF as Single          ' [1011] Thickness of backplate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        designation of element
      END Structure

      Structure CCON_MEM           ' 8/ID:10  Connected Member data
       Dim m_IDS as Integer        '        Identification = 10
       Dim m_NR as Integer         '        Enumeration or designation of member
       Dim m_TYP as Integer        '        Type of connection bitpattern
       Dim m_NRQ as Integer        '        Number of section
       Dim m_WTYP as Integer       '        id of the web connection
       Dim m_UTYP as Integer       '        id of the upper flange connection
       Dim m_LTYP as Integer       '        id of the lower flange connection
       Dim m_L as Single           ' [1001] length of member
       Dim m_AW as Single          ' [1011] weld thickness for web connection
       Dim m_AU as Single          ' [1011] weld thickness for upper flange connection
       Dim m_AL as Single          ' [1011] weld thickness for lower flange connection
       Dim m_DD as Single          ' [1011] Distance value of endpoint to central node
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_D() as Single '        Direction vector to beam axis in the
       Dim m_ROTY as Single        ' [   5] Angle of end plate y-rotation
       Dim m_ROTZ as Single        ' [   5] Angle of end plate z-rotation
       Dim m_CUTU as Single        ' [1011] Cut out height for upper flange
       Dim m_CUTL as Single        ' [1011] Cut out height for lower flange
       Dim m_CLU as Single         ' [1011] Cut out length for upper flange
       Dim m_CLD as Single         ' [1011] Cut out length for lower flange
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_VOUTE() as Single ' [1011] Voute [lenght,height] for
      END Structure

      Structure CCON_END           ' 8/ID:11  Endplate of Beam
       Dim m_IDS as Integer        '        Identification = 11
       Dim m_TYP as Integer        '        Type of end plate
       Dim m_MAT as Integer        '        Materialnumber of endplate
       Dim m_BOLT as Integer       '        Identifier of bolt type
       Dim m_NBR as Integer        '        Number of bolts in height direction
       Dim m_NBC as Integer        '        Number of bolts in width direction
       Dim m_B as Single           ' [1011] Width of plate
       Dim m_H as Single           ' [1011] Total plate height
       Dim m_MX as Single          ' [1011] Eccentricity
       Dim m_T as Single           ' [1011] Thickness of plate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HB() as Single ' [1011] Height for bolts
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_W() as Single ' [1011] Width for bolts
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_HTBP() as Single ' [1011] Height and thickness values for back plates
      END Structure

      Structure CCON_PIN           ' 8/ID:12  Pinned plate of Beam
       Dim m_IDS as Integer        '        Identification = 13
       Dim m_MAT as Integer        '        Materialnumber of pin plate
       Dim m_MATS as Integer       '        Materialnumber of support plate
       Dim m_MATP as Integer       '        Materialnumber of pin
       Dim m_DP as Single          ' [1011] Diameter of pin
       Dim m_DH as Single          ' [1011] Diameter of hole
       Dim m_TP as Single          ' [1011] Thickness pin plate
       Dim m_TSUP as Single        ' [1011] Thickness sup plate
       Dim m_C as Single           ' [1011] gap between plates
       Dim m_E1 as Single          ' [1011] eccentricity 1
       Dim m_E2 as Single          ' [1011] eccentricity 2
      END Structure

      Structure CCON_PLT           ' 8/ID:20  Additional plates in connection
       Dim m_IDS as Integer        '        Identification = 20
       Dim m_TYP as Integer        '        Type of plate
       Dim m_MAT as Integer        '        Number of material
       Dim m_T as Single           ' [1011] Thickness of plate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_EDGE() as Single ' [1011] Local coordinates, weldid, weldthickness
      END Structure

      Structure CSECT              ' 9/NR:0  SectionalValues (total section)
       Dim m_ID as Integer         '        Identification
       Dim m_MNO as Integer        '        Materialnumber of sections
       Dim m_MRF as Integer        '        Materialnumber of Reinforcement
       Dim m_A as Single           ' [1012] Area
       Dim m_AY as Single          ' [1012] Sheardeformation area Y
       Dim m_AZ as Single          ' [1012] Sheardeformation area Z
       Dim m_IT as Single          ' [1014] Torsional moment of inertia
       Dim m_IY as Single          ' [1014] Moments of inertia y-y
       Dim m_IZ as Single          ' [1014] Moments of inertia z-z
       Dim m_IYZ as Single         ' [1014] Moments of inertia y-z
       Dim m_YS as Single          ' [1011] y-Ordinate Center of elasticity
       Dim m_ZS as Single          ' [1011] z-Ordinate Center of elasticity
       Dim m_YSC as Single         ' [1011] y-Ordinate of Shear-Center
       Dim m_ZSC as Single         ' [1011] z-Ordinate of Shear-Center
       Dim m_EM as Single          ' [1090] Elasticity Modulus
       Dim m_GM as Single          ' [1090] Shear Modulus
       Dim m_GAM as Single         ' [1091] Nominal weight
      END Structure

      Structure CSECT_EFF          ' 9/NR:1  SectionalValues (effective section)
       Dim m_ID as Integer         '        Identification
       Dim m_MNO as Integer        '        Materialnumber of sections
       Dim m_MRF as Integer        '        Materialnumber of Reinforcement
       Dim m_A as Single           ' [1012] Area
       Dim m_AY as Single          ' [1012] Sheardeformation area Y
       Dim m_AZ as Single          ' [1012] Sheardeformation area Z
       Dim m_IT as Single          ' [1014] Torsional moment of inertia
       Dim m_IY as Single          ' [1014] Moments of inertia y-y
       Dim m_IZ as Single          ' [1014] Moments of inertia z-z
       Dim m_IYZ as Single         ' [1014] Moments of inertia y-z
       Dim m_YS as Single          ' [1011] y-Ordinate Center of elasticity
       Dim m_ZS as Single          ' [1011] z-Ordinate Center of elasticity
       Dim m_YSC as Single         ' [1011] y-Ordinate of Shear-Center
       Dim m_ZSC as Single         ' [1011] z-Ordinate of Shear-Center
       Dim m_EM as Single          ' [1090] Elasticity Modulus
       Dim m_GM as Single          ' [1090] Shear Modulus
       Dim m_GAM as Single         ' [1091] Nominal weight
      END Structure

      Structure CSECT_PAR          ' 9/NR:2  SectionalValues (total part of section)
       Dim m_ID as Integer         '        Identification
       Dim m_MNO as Integer        '        Materialnumber of sections
       Dim m_MRF as Integer        '        Materialnumber of Reinforcement
       Dim m_A as Single           ' [1012] Area
       Dim m_AY as Single          ' [1012] Sheardeformation area Y
       Dim m_AZ as Single          ' [1012] Sheardeformation area Z
       Dim m_IT as Single          ' [1014] Torsional moment of inertia
       Dim m_IY as Single          ' [1014] Moments of inertia y-y
       Dim m_IZ as Single          ' [1014] Moments of inertia z-z
       Dim m_IYZ as Single         ' [1014] Moments of inertia y-z
       Dim m_YS as Single          ' [1011] y-Ordinate Center of elasticity
       Dim m_ZS as Single          ' [1011] z-Ordinate Center of elasticity
       Dim m_YSC as Single         ' [1011] y-Ordinate of Shear-Center
       Dim m_ZSC as Single         ' [1011] z-Ordinate of Shear-Center
       Dim m_EM as Single          ' [1090] Elasticity Modulus
       Dim m_GM as Single          ' [1090] Shear Modulus
       Dim m_GAM as Single         ' [1091] Nominal weight
      END Structure

      Structure CSECT_PEF          ' 9/NR:3  SectionalValues (effective part of section)
       Dim m_ID as Integer         '        Identification
       Dim m_MNO as Integer        '        Materialnumber of sections
       Dim m_MRF as Integer        '        Materialnumber of Reinforcement
       Dim m_A as Single           ' [1012] Area
       Dim m_AY as Single          ' [1012] Sheardeformation area Y
       Dim m_AZ as Single          ' [1012] Sheardeformation area Z
       Dim m_IT as Single          ' [1014] Torsional moment of inertia
       Dim m_IY as Single          ' [1014] Moments of inertia y-y
       Dim m_IZ as Single          ' [1014] Moments of inertia z-z
       Dim m_IYZ as Single         ' [1014] Moments of inertia y-z
       Dim m_YS as Single          ' [1011] y-Ordinate Center of elasticity
       Dim m_ZS as Single          ' [1011] z-Ordinate Center of elasticity
       Dim m_YSC as Single         ' [1011] y-Ordinate of Shear-Center
       Dim m_ZSC as Single         ' [1011] z-Ordinate of Shear-Center
       Dim m_EM as Single          ' [1090] Elasticity Modulus
       Dim m_GM as Single          ' [1090] Shear Modulus
       Dim m_GAM as Single         ' [1091] Nominal weight
      END Structure

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
      Structure CSECT_ADD          ' 9/NR:4  SectionalValuesShear , Temperature
       Dim m_ID as Integer
       Dim m_STYPE as Integer
       Dim m_MRF as Integer        '        Materialnumber of Stirup-Reinforcement
       Dim m_AT as Single          ' [ 107] Elongationkoefficient for Temperature
       Dim m_YMIN as Single        ' [1011] Minimum Ordinate of section to center ys
       Dim m_YMAX as Single        ' [1011] Maximum Ordinate of section to center ys
       Dim m_ZMIN as Single        ' [1011] Minimum Ordinate of section to center zs
       Dim m_ZMAX as Single        ' [1011] Maximum Ordinate of section to center zs
       Dim m_TMIN as Single        ' [1011] minimum thickness
       Dim m_TMAX as Single        ' [1011] maximum thickness
       Dim m_WT as Single          ' [1018] maximum tau for Torsion MT=1
       Dim m_WVY as Single         ' [1017] maximum tau for Shear VY=1
       Dim m_WVZ as Single         ' [1017] maximum tau for Shear VZ=1
       Dim m_WT2 as Single         ' [1018] maximum tau for sekundary Torsion
       Dim m_AK as Single          ' [1012] kernel area for Torsion
       Dim m_AYZ as Single         ' [1012] Shear deviation area
       Dim m_AB as Single          ' [1012] pure concrete area
       Dim m_LEVY as Single        ' [1011] minimum lever for cracked shear Vy
       Dim m_LEVZ as Single        ' [1011] minimum lever for cracked shear Vz
       Dim m_ELVY as Single        ' [  17] elastic shear flux for Vy = Sy-max/Iz
       Dim m_ELVZ as Single        ' [  17] elastic shear flux for Vz = Sz-max/Iy
       Dim m_YMINE as Single       ' [1011] Minimum Ordinate of effective section
       Dim m_YMAXE as Single       ' [1011] Maximum Ordinate of effective section
       Dim m_ZMINE as Single       ' [1011] Minimum Ordinate of effective section
       Dim m_ZMAXE as Single       ' [1011] Maximum Ordinate of effective section
      END Structure

      Structure CSECT_WAR          ' 9/NR:5  SectionalValuesWarping
       Dim m_ID as Integer         '        Identification = 5
       Dim m_I_1 as Integer        '        unused
       Dim m_I_2 as Integer        '        unused
       Dim m_AYYY as Single        ' [1015] Integrals on section
       Dim m_AYYZ as Single        ' [1015] Integrals on section
       Dim m_AYZZ as Single        ' [1015] Integrals on section
       Dim m_AZZZ as Single        ' [1015] Integrals on section
       Dim m_AWY as Single         ' [1015] Integrals on section
       Dim m_AWZ as Single         ' [1015] Integrals on section
       Dim m_AWYY as Single        ' [1016] Integrals on section
       Dim m_AWZZ as Single        ' [1016] Integrals on section
       Dim m_CM as Single          ' [1016] Warping resistance
       Dim m_CMS as Single         ' [1014] Warping Shear resist.
       Dim m_WMIN as Single        ' [1012] Minimum warping
       Dim m_WMAX as Single        ' [1012] Maximum warping
       Dim m_FYSW as Single        ' [1012] Shear VY-MT2 area
       Dim m_FZSW as Single        ' [1012] Shear VZ-MT2 area
       Dim m_IPSC as Single        ' [1014] polar inertia at SC
      END Structure

const SECT_IBC_MULT = 32
      Structure CSECT_PLA          ' 9/NR:6  SectionalPlasticForces
       Dim m_ID as Integer         '        Identification = 6
       Dim m_IBC as Integer        '        Buckling curve
       Dim m_IB as Integer         '        Control
       Dim m_WPN as Single         ' [1101] Normal force
       Dim m_WPVY as Single        ' [1102] Y-Shear force
       Dim m_WPVZ as Single        ' [1102] Y-Shear force
       Dim m_WPMT as Single        ' [1103] Torsional moment
       Dim m_WPMY as Single        ' [1104] Bending moment My
       Dim m_WPMZ as Single        ' [1104] Bending moment Mz
       Dim m_YSP as Single         ' [1001] Plastic center
       Dim m_ZSP as Single         ' [1001] Plastic center
       Dim m_WPMB as Single        ' [1105] warping moment Mb
       Dim m_WPT2 as Single        ' [1103] 2nd torsional moment
      END Structure

      Structure CSECT_DES          ' 9/NR:7  SectionalValuesDesign
       Dim m_ID as Integer         '        Identification = 7
       Dim m_MNR as Integer        '        used reference material
       Dim m_IBC as Integer        '        buckling curve index (see 009/NR:6)
       Dim m_A as Single           ' [1012] Area
       Dim m_AY as Single          ' [1012] Sheardeformation area Y
       Dim m_AZ as Single          ' [1012] Sheardeformation area Z
       Dim m_IT as Single          ' [1014] Torsional moment of inertia
       Dim m_IY as Single          ' [1014] Moments of inertia y-y
       Dim m_IZ as Single          ' [1014] Moments of inertia z-z
       Dim m_IYZ as Single         ' [1014] Moments of inertia y-z
       Dim m_YS as Single          ' [1011] y-Ordinate Center of gravity
       Dim m_ZS as Single          ' [1011] z-Ordinate Center of gravity
       Dim m_YSC as Single         ' [1011] y-Ordinate of Shear-Center
       Dim m_ZSC as Single         ' [1011] z-Ordinate of Shear-Center
       Dim m_EM as Single          ' [1090] Elasticity Modulus/safety
       Dim m_GM as Single          ' [1090] Shear Modulus/safety
       Dim m_GAM as Single         ' [1091] Nominal weight
      END Structure

      Structure CSECT_PRE          ' 9/NR:8  SectionalForcesPrestress
       Dim m_ID as Integer         '        Identification = 8
       Dim m_ITP as Integer        '        subtype of information = 0
       Dim m_ITS as Integer        '        source of values
       Dim m_N as Single           ' [1101] Normal force
       Dim m_MY as Single          ' [1104] Bending moment My
       Dim m_MZ as Single          ' [1104] Bending moment Mz
       Dim m_EA as Single          ' [1101] tangential stiffnes E*A
       Dim m_EAY as Single         ' [1105] tangential stiffnes E*A*z*z
       Dim m_EAZ as Single         ' [1105] tangential stiffnes E*A*y*y
       Dim m_EAYZ as Single        ' [1105] tangential stiffnes E*A*y*z
       Dim m_YSE as Single         ' [1011] elastic tangential center ys
       Dim m_ZSE as Single         ' [1011] elastic tangential center zs
       Dim m_NCM as Single         ' [1101] maximum compressive force
       Dim m_NTM as Single         ' [1101] maximum tensile force
      END Structure

      Structure CSECT_GV           ' 9/NR:8  SectionalGeometricValues
       Dim m_ID as Integer         '        Identification = 8
       Dim m_ITP as Integer        '        subtype of information = 2
       Dim m_MNO as Integer        '        Materialnumber (0=total section)
       Dim m_UO as Single          ' [1011] outer perimeter
       Dim m_UI as Single          ' [1011] inner perimeter
       Dim m_TMIN as Single        ' [1011] minimum thickness
       Dim m_TMAX as Single        ' [1011] maximum thickness
       Dim m_KTZ as Single         ' [   8] total weight factor
       Dim m_UOM as Single         ' [1011] outer effect.perimeter
       Dim m_UIM as Single         ' [1011] inner effect.perimeter
       Dim m_ARO as Single         ' [1012] Outer total gross area
       Dim m_AR as Single          ' [1012] total gross area
       Dim m_IPM as Single         ' [1183] rotational inertia      gam*Ip  ! values to be converted * DC_M
       Dim m_IYM as Single         ' [1183] sectional mass inertia  gam*Iy  ! values to be converted * DC_M
       Dim m_IZM as Single         ' [1183] sectional mass inertia  gam*Iz  ! values to be converted * DC_M
       Dim m_IYZM as Single        ' [1183] sectional mass inertia  gam*Iyz ! values to be converted * DC_M
       Dim m_YSM as Single         ' [1011] true mass gravity center
       Dim m_ZSM as Single         ' [1011] true mass gravity center
       Dim m_DW as Single          ' [1011] effective thickness for creep/shrinkage
       Dim m_UAIR as Single        ' [1011] air contact perimeter
      END Structure

      Structure CSECT_TRA          ' 9/NR:8  SectionalAppliedTransformation
       Dim m_ID as Integer         '        Identification = 8
       Dim m_ITP as Integer        '        subtype of information = 3
       Dim m_I_2 as Integer        '        not used
       Dim m_ALF as Single         ' [   5] rotation angle
       Dim m_YTF as Single         ' [1011] shift in y direction
       Dim m_ZTF as Single         ' [1011] shift in z direction
      END Structure

      Structure CSECT_LAY          ' 9/NR:9  SectionalReinforcementLayer  (LAY)
       Dim m_ID as Integer         '        Identification = 9
       Dim m_MNR as Integer        '        Materialnumber + 1000*No of concrete \%
       Dim m_INR as Integer        '        Type/number of layer
       Dim m_TNR as Integer        '        Designation
       Dim m_ALOW as Single        ' [1020] Lower bound for area of layer
       Dim m_AHIG as Single        ' [1020] Upper bound for area of layer
       Dim m_ASUM as Single        ' [1020] Sum of reference areas of layer
       Dim m_AFAK as Single        '        maximum allowable factor of layer
       Dim m_YS as Single          ' [1011] center of layer
       Dim m_ZS as Single          ' [1011] center of layer
       Dim m_VAS as Single         ' [1020] Lower sequential total bound of layer area
       Dim m_BAS as Single         ' [1020] Upper sequential total bound of layer area
       Dim m_IY as Single          ' [1014] 4th ord.areas (inertia)
       Dim m_IZ as Single          ' [1014] 4th ord.areas (inertia)
       Dim m_IYZ as Single         ' [1014] 4th ord.areas (inertia)
       Dim m_EMOD as Single        ' [1090] Elasticity-Modulus
       Dim m_BETS as Single        ' [1092] yieldstress
       Dim m_RL as Single          ' [1011] torsional refer. length
       Dim m_DMIN as Single        ' [1023] smallest used diameter
       Dim m_DMAX as Single        ' [1023] largest  used diameter
       Dim m_N as Single           ' [1101] Normal force
       Dim m_MY as Single          ' [1104] Bending moment My
       Dim m_MZ as Single          ' [1104] Bending moment Mz
       Dim m_EA as Single          ' [1101] tangential stiffnes E*A
       Dim m_EAY as Single         ' [1104] tangential stiffnes E*A*z
       Dim m_EAZ as Single         ' [1104] tangential stiffnes E*A*y
       Dim m_EAYY as Single        ' [1105] tangential stiffnes E*A*y*y
       Dim m_EAZZ as Single        ' [1105] tangential stiffnes E*A*z*z
       Dim m_EAYZ as Single        ' [1105] tangential stiffnes E*A*y*z
       Dim m_NPLC as Single        ' [1101] maximum compressive force
       Dim m_NPLT as Single        ' [1101] maximum tensile force
      END Structure

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
      Structure CSECT_REC          ' 9/NR:10  SectiontypeRectangular T-Beam (SREC)
       Dim m_ID as Integer         '        Identification = 10
       Dim m_IQ as Integer         '        Identification of section
       Dim m_IR as Integer         '        Identification of reinforcement and origin
       Dim m_H as Single           ' [1011] total height
       Dim m_B as Single           ' [1011] width (of web)
       Dim m_SO as Single          ' [1024] Boundary distance of upper reinforcement
       Dim m_SU as Single          ' [1024] Boundary distance of lower reinforcement
       Dim m_ASO as Single         ' [1020] reinforcement up
       Dim m_ASU as Single         ' [1020] reinforcement down
       Dim m_HO as Single          ' [1011] height of plate
       Dim m_BO as Single          ' [1011] width  of plate
       Dim m_DASO as Single        ' [1023] reinf. Diameter up
       Dim m_DASU as Single        ' [1023] reinf. Diameter dn
       Dim m_FKIT as Single        '        <0 = factor for torsional inertia >0 = absolut value of torsion
       Dim m_FKAY as Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
       Dim m_FKAZ as Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
       Dim m_YSMP as Single        ' [1011] explicit location of shear center
       Dim m_ZSSMP as Single       ' [1011] explicit location of shear center
       Dim m_YS as Single          ' [1011] explicit location of reference point
       Dim m_ZS as Single          ' [1011] explicit location of reference point
       Dim m_PHIB as Single        ' [   5] inclination of transverse reinforcements
       Dim m_BEFF as Single        ' [1011] width of equivalent hollow section
       Dim m_ASBM as Single        '        Minimum shear reinf.
       Dim m_A as Single           ' [1011] spacing of reinforcements
       Dim m_AMIN as Single        ' [1011] minimum distance of single reinforcements
       Dim m_AMAX as Single        ' [1011] maximum distance of single reinforcements
       Dim m_SS as Single          ' [1024] Boundary distance of lateral reinforcement
       Dim m_DASS as Single        ' [1023] reinf. Diameter side
       Dim m_HMAX as Single        ' [1011] maximum mesh size for FE/fibre analysis
       Dim m_BETC as Single        '        friction coefficient
       Dim m_MUE as Single         '        friction in joint
      END Structure

      Structure CSECT_ANN          ' 9/NR:11  SectiontypeAnnular (SCIT)
       Dim m_ID as Integer         '        Identification = 11
       Dim m_IR as Integer         '        Identification of section
       Dim m_IR2 as Integer        '        Identification of reinforcement
       Dim m_RO as Single          ' [1011] outer radius
       Dim m_RI as Single          ' [1011] inner radius
       Dim m_ROS as Single         ' [1011] outer reinf radius
       Dim m_RIS as Single         ' [1011] inner reinf radius
       Dim m_ASO as Single         ' [1020] outer reinforcement
       Dim m_ASI as Single         ' [1020] inner reinforcement
       Dim m_DASO as Single        ' [1023] reinf. Diameter
       Dim m_AMAX as Single        ' [1011] maximum distance of single reinforcements
       Dim m_ASBM as Single        ' [1021] Minimum shear reinf.
       Dim m_HMAX as Single        ' [1011] maximum mesh size for FE/fibre analysis
       Dim m_FKIT as Single        '        <0 = factor for torsional inertia >0 = absolut value of torsion
       Dim m_FKAY as Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
       Dim m_FKAZ as Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
      END Structure

      Structure CSECT_TUB          ' 9/NR:11  SectiontypeTube (TUBE)
       Dim m_ID as Integer         '        Identification = 11
       Dim m_IR as Integer         '        Identification of section = 2
       Dim m_IR2 as Integer        '        property Bit
       Dim m_D as Single           ' [1011] Diameter
       Dim m_T as Single           ' [1011] thickness of tubes
      END Structure

      Structure CSECT_CAB          ' 9/NR:11  SectiontypeCable (CABL)
       Dim m_ID as Integer         '        Identification = 11
       Dim m_IR as Integer         '        Identification of section = 3
       Dim m_IC as Integer         '        sectiontype*256 + codeflag*64 + inlet type
       Dim m_D as Single           ' [1011] Diameter
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_TYP() as Integer '        Literal of type
       Dim m_INL as Integer        '        Literal of inlet
       Dim m_NLI as Single         '        no of strands
       Dim m_NDR as Single         '        no of wires
       Dim m_F as Single           '        fill factor
       Dim m_K as Single           '        cable factor
       Dim m_W as Single           '        weight factor
       Dim m_KE as Single          '        loss factor
       Dim m_ZD as Single          ' [1090] design  force
       Dim m_ZB as Single          ' [1090] rupture force
       Dim m_GAM as Single         ' [1188] weight
      END Structure

      Structure CSECT_PRO          ' 9/NR:12  SectiontypeShape (PROF)
       Dim m_ID as Integer         '        Identification = 12
       Dim m_MNO as Integer        '        Materialnumber + 1000*imbedded Materialnumber
       Dim m_IBIT as Integer       '        ityp + 64*iref + ivtp
       Dim m_TYP as Integer        '        type of section
       Dim m_Z1 as Single          '        nominal first size
       Dim m_Z2 as Single          '        nominal second size
       Dim m_Z3 as Single          '        thickness or weight selector
       Dim m_ALF as Single         ' [   5] rotation angle
       Dim m_IT as Single          ' [1014] tabul.Tors.Inertia
       Dim m_YSC as Single         ' [1011] tabul.shear center
       Dim m_ZSC as Single         ' [1011] tabul.shear center
       Dim m_H as Single           ' [1011] height
       Dim m_B as Single           ' [1011] width
       Dim m_S as Single           ' [1011] thickness of web
       Dim m_T as Single           ' [1011] thickness of flange
       Dim m_R1 as Single          ' [1011] radius
       Dim m_R2 as Single          ' [1011] radius
       Dim m_YOFF as Single        ' [1011] y coord. offset
       Dim m_ZOFF as Single        ' [1011] z coord. offset
       Dim m_CM as Single          ' [1016] tabul.warp.resist.
       Dim m_WMIN as Single        ' [1012] charact. warping 1
       Dim m_WMAX as Single        ' [1012] charact. warping 2
       Dim m_WT as Single          ' [1018] Torsional resist.
       Dim m_AY as Single          ' [1012] Shear area
       Dim m_AZ as Single          ' [1012] Shear area
       Dim m_RID as Integer        '        user defined ident
       Dim m_WU1 as Single         ' [1011] bolt position 1
       Dim m_WU2 as Single         ' [1011] bolt position 2
       Dim m_WU3 as Single         ' [1011] bolt position 3
       Dim m_YREF as Single        ' [1011] Coordinates of
       Dim m_ZREF as Single        ' [1011] Reference point
       Dim m_B2 as Single          ' [1011] width lower part
       Dim m_T2 as Single          ' [1011] lower flange thick.
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_BEZ() as Integer '        character of shape
       Dim m_VYPL as Single        ' [1102] plastic shear force Vy
       Dim m_VZPL as Single        ' [1102] plastic shear force Vz
       Dim m_MTPL as Single        ' [1103] plastic torsional   Mt
       Dim m_MT2PL as Single       ' [1103] plastic torsional   Mt2
       Dim m_MBPL as Single        ' [1103] plastic warpmoment  Mb
      END Structure

      Structure CSECT_TBA          ' 9/NR:18  List of construction stages
       Dim m_ID as Integer         '        Identification = 18
       Dim m_IBA as Integer        '        Headder of construction stages = 0
       Dim m_IBD as Integer        '        Number of materials over all construction stages
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_IBAT() as Integer '        List of external construction stage numbers
      END Structure

      Structure CSECT_IBA          ' 9/NR:18  ConstructionStage (CS/BA)
       Dim m_ID as Integer         '        Identification = 18
       Dim m_IBA as Integer        '        number of construction stage BIRTH
       Dim m_IBD as Integer        '        number of construction stage DEATH
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Text
      END Structure

      Structure CSECT_TXT          ' 9/NR:19  SectionText
       Dim m_ID as Integer         '        Identification = 19
       Dim m_NR as Integer         '        external construction stage number for CS separator
       Dim m_IDS as Integer        '        Source/Selector flag
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_TXT() as Integer '        Text
      END Structure

      Structure CSECT_WLS          ' 9/NR:6?  SectionWorklaw Serviceability Analysis
       Dim m_ID as Integer         '        Identification
       Dim m_N as Integer          '        Normal force 0/00
       Dim m_NTYP as Integer       '        Type of law
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CSECT_WLU          ' 9/NR:7?  SectionWorklaw Ultimate Analysis
       Dim m_ID as Integer         '        Identification
       Dim m_N as Integer          '        Normal force 0/00
       Dim m_NTYP as Integer       '        Type of law
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CSECT_CW           ' 9/NR:80  Hydrodynamic coefficients (WIND/Wave loading)
       Dim m_ID as Integer         '        Identification 80
       Dim m_IREF as Integer       '        Reference of coefficients
       Dim m_ALF as Integer        '        angle of attack in degrees
       Dim m_CY as Single          '        wind reaction coefficient in y-direction
       Dim m_CZ as Single          '        wind reaction coefficient in z-direction
       Dim m_CT as Single          '        wind reaction coefficient for torsional moment
       Dim m_CHYD as Single        '        hydrodynamic coefficient (Morrison equation)
       Dim m_CLAT as Single        '        lateral wind reaction coefficient
       Dim m_S as Single           '        Strouhal number
       Dim m_AG as Single          '        reserved (must be present to detect old data without chyd)
      END Structure

      Structure CSECT_WPA          ' 9/NR:81  SectionWindParameters for Wind loading (WPAR)
       Dim m_ID as Integer         '        Identification 81
       Dim m_IBA as Integer        '        construction stage number
       Dim m_IBIT as Integer       '        bitpattern of explicit limits
       Dim m_KD as Single          ' [1011] equivalent roughness k
       Dim m_ICE as Single         ' [1011] ice cover
       Dim m_TRAF as Single        ' [1011] height of traffic lane
       Dim m_YMIN as Single        ' [1011] wind attack area
       Dim m_ZMIN as Single        ' [1011] wind attack area
       Dim m_YMAX as Single        ' [1011] wind attack area
       Dim m_ZMAX as Single        ' [1011] wind attack area
       Dim m_YREF as Single        ' [1011] wind moment reference
       Dim m_ZREF as Single        ' [1011] wind moment reference
       Dim m_CORN as Single        ' [1011] radius of round edge for rectangular shapes
       Dim m_CWF as Single         '        explicit factor or value of wind coefficient
       Dim m_ALF as Single         ' [   5] rotation for default wind coefficients
      END Structure

      Structure CSECT_WDE          ' 9/NR:82  SectionWindDerivativa for Wind loading (WIND)
       Dim m_ID as Integer         '        Identification 82
       Dim m_IREF as Integer       '        Type of derivativa
       Dim m_ALF as Integer        '        angle of attack in degrees (see 009/NR:80)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_DER() as Single '        Derivativa vred,value as splines
      END Structure

      Structure CSECT_USR          ' 9/NR:90  SectionUserValues (SV/QW)
       Dim m_ID as Integer         '        Identification = 90
       Dim m_ITP as Integer        '        type of control value set
       Dim m_IVAL as Integer       '        value of control flag
       Dim m_RVAL as Single        '        real value of control flag
       Dim m_RVALD as Single       '        place to save the original value which has been
      END Structure

      Structure CSECT_MAT          ' 9/NR:91  SectionalMaterial list
       Dim m_ID as Integer         '        Identification = 91
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=31)> Dim m_MAT() as Integer '        material numbers
      END Structure

      Structure CSECT_VAD          ' 9/NR:97  SectionVarDefaults
       Dim m_ID as Integer         '        Identification = 97/98
       Dim m_IND1 as Integer       '        Lower Index of variable
       Dim m_IND2 as Integer       '        Upper Index of variable
       Dim m_IDIM as Integer       '        Unit of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        Name of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_RVAL() as Single '        values of the variable NAME(I1:I2)
      END Structure

      Structure CSECT_VAR          ' 9/NR:98  SectionVarValues
       Dim m_ID as Integer         '        Identification = 97/98
       Dim m_IND1 as Integer       '        Lower Index of variable
       Dim m_IND2 as Integer       '        Upper Index of variable
       Dim m_IDIM as Integer       '        Unit of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        Name of variable
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_RVAL() as Single '        values of the variable NAME(I1:I2)
      END Structure

      Structure CSECT_REF          ' 9/NR:99  SectionReference
       Dim m_ID as Integer         '        Identification 099
       Dim m_IM as Integer         '        Type of reference structure definition (see AQUA.ERR)
       Dim m_IRTS as Integer       '        Subtype of reference definition for the points:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=200)> Dim m_REF() as Integer '        Identifier of references (0 = not defined)
      END Structure

      Structure CSECT_SPT          ' 9/NR:100  SectionStressPoint (SPT/QSP)
       Dim m_ID as Integer         '        Identification 100/101
       Dim m_MNO as Integer        '        Material number
       Dim m_IDP as Integer        '        Number*256 + Bitpattern
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_RT as Single          ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
       Dim m_WTY as Single         ' [1018] Resistance Torsion
       Dim m_WVYY as Single        ' [1017] Resistance y-shear
       Dim m_WVZY as Single        ' [1017] Resistance z-shear
       Dim m_WT2Y as Single        ' [1018] Resistance 2nd Torsion
       Dim m_WTZ as Single         ' [1018] Resistance Torsion
       Dim m_WVYZ as Single        ' [1017] Resistance y-shear
       Dim m_WVZZ as Single        ' [1017] Resistance z-shear
       Dim m_WT2Z as Single        ' [1018] Resistance 2nd Torsion
       Dim m_W0 as Single          ' [1012] unit warping
       Dim m_EPSR as Single        '        non effective strain ratio (0 < epsr <= 1)
       Dim m_EXP as Single         '        exposition class
       Dim m_FIX as Single         ' [1011] location of fix point
       Dim m_SIGD as Single        ' [1092] max. dynamic allowed stress range sig-d(-1)
       Dim m_TAUD as Single        ' [1092] max dynamic allowed stress range tau-d(-1)
       Dim m_LITD as Integer       '        literal for notch type
       Dim m_SIGY as Single        ' [1092] stress perpendicular
       Dim m_AREF as Single        ' [1012] weight (effective area) FE-integration points
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_TEMP1 as Single       ' [1215] maximum temperature in history (for damage)
      END Structure

      Structure CSECT_PPT          ' 9/NR:101  SectionPolygonPoint (POLY/QPOL)
       Dim m_ID as Integer         '        Identification 100/101
       Dim m_MNO as Integer        '        Material number
       Dim m_IDP as Integer        '        Number*256 + Bitpattern
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_RT as Single          ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
       Dim m_WTY as Single         ' [1018] Resistance Torsion
       Dim m_WVYY as Single        ' [1017] Resistance y-shear
       Dim m_WVZY as Single        ' [1017] Resistance z-shear
       Dim m_WT2Y as Single        ' [1018] Resistance 2nd Torsion
       Dim m_WTZ as Single         ' [1018] Resistance Torsion
       Dim m_WVYZ as Single        ' [1017] Resistance y-shear
       Dim m_WVZZ as Single        ' [1017] Resistance z-shear
       Dim m_WT2Z as Single        ' [1018] Resistance 2nd Torsion
       Dim m_W0 as Single          ' [1012] unit warping
       Dim m_EPSR as Single        '        non effective strain ratio (0 < epsr <= 1)
       Dim m_EXP as Single         '        exposition class
       Dim m_FIX as Single         ' [1011] location of fix point
       Dim m_SIGD as Single        ' [1092] max. dynamic allowed stress range sig-d(-1)
       Dim m_TAUD as Single        ' [1092] max dynamic allowed stress range tau-d(-1)
       Dim m_LITD as Integer       '        literal for notch type
       Dim m_SIGY as Single        ' [1092] stress perpendicular
       Dim m_AREF as Single        ' [1012] weight (effective area) FE-integration points
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_TEMP1 as Single       ' [1215] maximum temperature in history (for damage)
      END Structure

      Structure CSECT_CIR          ' 9/NR:102  SectionCircle (CIRC/KREI)
       Dim m_ID as Integer         '        Identification 102
       Dim m_MNO as Integer        '        Material number
       Dim m_ITP as Integer        '        interior construction
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate center
       Dim m_Z as Single           ' [1011] z-ordinate center
       Dim m_R as Single           ' [1011] Radius
       Dim m_RI as Single          ' [1011] Radius hole
       Dim m_UC as Single          ' [1011] air contact length
      END Structure

      Structure CSECT_PAN          ' 9/NR:103  SectionPanel (PLAT,WALL)
       Dim m_ID as Integer         '        Identification 103/104
       Dim m_MNO as Integer        '        Material number
       Dim m_IDP as Integer        '        Bit-pattern
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_T as Single           ' [1010] thickness
       Dim m_WA as Single          ' [1012] unit warping start
       Dim m_WE as Single          ' [1012] unit warping end
       Dim m_WT as Single          ' [1018] maximum shear from MT
       Dim m_WVY as Single         ' [1017] maximum shear from Vy
       Dim m_WVZ as Single         ' [1017] maximum shear from Vz
       Dim m_WT2 as Single         ' [1018] maximum shear from MT2
       Dim m_XVY as Single         '        relative Ordinate WVy
       Dim m_XVZ as Single         '        relative Ordinate WVz
       Dim m_XMT2 as Single        '        relative Ordinate Wt2
       Dim m_WTBR as Single        '        Bredt torsional shear
       Dim m_FIXA as Single        ' [1011] location of fix point
       Dim m_FIXB as Single        ' [1011] location of fix point
       Dim m_TEFF as Single        ' [1010] effective thickness
       Dim m_AST as Single         ' [1011] Distance of stiffeners along beam axis
       Dim m_ETA as Single         '        Reduction factor for local buckling
      END Structure

      Structure CSECT_WEL          ' 9/NR:104  SectionWeld  (WELD)
       Dim m_ID as Integer         '        Identification 103/104
       Dim m_MNO as Integer        '        Material number
       Dim m_IDP as Integer        '        Bit-pattern
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_T as Single           ' [1010] thickness
       Dim m_WA as Single          ' [1012] unit warping start
       Dim m_WE as Single          ' [1012] unit warping end
       Dim m_WT as Single          ' [1018] maximum shear from MT
       Dim m_WVY as Single         ' [1017] maximum shear from Vy
       Dim m_WVZ as Single         ' [1017] maximum shear from Vz
       Dim m_WT2 as Single         ' [1018] maximum shear from MT2
       Dim m_XVY as Single         '        relative Ordinate WVy
       Dim m_XVZ as Single         '        relative Ordinate WVz
       Dim m_XMT2 as Single        '        relative Ordinate Wt2
       Dim m_WTBR as Single        '        Bredt torsional shear
       Dim m_FIXA as Single        ' [1011] location of fix point
       Dim m_FIXB as Single        ' [1011] location of fix point
       Dim m_TEFF as Single        ' [1010] effective thickness
       Dim m_AST as Single         ' [1011] Distance of stiffeners along beam axis
       Dim m_ETA as Single         '        Reduction factor for local buckling
      END Structure

      Structure CSECT_PER          ' 9/NR:110  SectionPeriphery
       Dim m_ID as Integer         '        Identification 110
       Dim m_MNO as Integer        '        Material number
       Dim m_MN2 as Integer        '        2nd material number
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate
       Dim m_ZA as Single          ' [1011] z-ordinate
       Dim m_YE as Single          ' [1011] y-ordinate
       Dim m_ZE as Single          ' [1011] z-ordinate
       Dim m_AIR as Single         '        air contact ratio
      END Structure

      Structure CSECT_FEM          ' 9/NR:112  SectionTopology
       Dim m_ID as Integer         '        Identification 111
       Dim m_MNO as Integer        '        Material number
       Dim m_NREL as Integer       '        internal element number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer '        internal element nodes
      END Structure

      Structure CSECT_NER          ' 9/NR:190  SectionNonEffectiveRectangle (NEFF)
       Dim m_ID as Integer         '        Identification 190
       Dim m_MNO as Integer        '        Material number
       Dim m_IDP as Integer        '        Noneffective for (same bits as :101)
       Dim m_TNR as Integer        '        Designation
       Dim m_YMIN as Single        ' [1011] y-ordinate
       Dim m_ZMIN as Single        ' [1011] z-ordinate
       Dim m_YMAX as Single        ' [1011] y-ordinate
       Dim m_ZMAX as Single        ' [1011] z-ordinate
       Dim m_T as Single           ' [1011] thickness
       Dim m_SMIN as Single        ' [1092] stress at point (ymin,zmin)
       Dim m_SMAX as Single        ' [1092] stress at point (ymax,zmax)
      END Structure

      Structure CSECT_NEP          ' 9/NR:191  Partial non effective polygons
       Dim m_ID as Integer         '        Identification 191
       Dim m_MNO as Integer        '        Materialnumber
       Dim m_IDP as Integer        '        Noneffective for (see :190)
       Dim m_TNR as Integer        '        Ident from 190 / Cut identifier for :312 elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1022)> Dim m_YZ() as Single ' [1011] yz(2,*) = vertices (old format is blocked with 7 points
      END Structure

      Structure CSECT_PRF          ' 9/NR:200  SectionPointReinforcement (RF/BEW)
       Dim m_ID as Integer         '        Identification 200
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_SIG as Single         ' [1092] prestress
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_AS as Single          ' [1020] Reinforcement area
       Dim m_ASMA as Single        ' [1020] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1012] Reference area
       Dim m_A as Single           ' [1011] distance of bars
      END Structure

      Structure CSECT_LRF          ' 9/NR:201  SectionLineReinforcement (LRF/LBEW)
       Dim m_ID as Integer         '        Identification 201/211/221 or 321
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_R as Single           ' [1011] Radius
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_LRP          ' 9/NR:211  SectionLineReinforcement in Points
       Dim m_ID as Integer         '        Identification 201/211/221 or 321
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_R as Single           ' [1011] Radius
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_LSL          ' 9/NR:221  SectionShearLink
       Dim m_ID as Integer         '        Identification 201/211/221 or 321
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_R as Single           ' [1011] Radius
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_CRF          ' 9/NR:202  SectionCircularReinforcement (CRF/KBEW)
       Dim m_ID as Integer         '        Identification 202/212/222
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate center
       Dim m_Z as Single           ' [1011] z-ordinate center
       Dim m_R as Single           ' [1011] Radius
       Dim m_I_4 as Single
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_CRP          ' 9/NR:212  SectionCircularReinforcement in Points
       Dim m_ID as Integer         '        Identification 202/212/222
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate center
       Dim m_Z as Single           ' [1011] z-ordinate center
       Dim m_R as Single           ' [1011] Radius
       Dim m_I_4 as Single
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_CSL          ' 9/NR:222  SectionHelicalShearLink
       Dim m_ID as Integer         '        Identification 202/212/222
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate center
       Dim m_Z as Single           ' [1011] z-ordinate center
       Dim m_R as Single           ' [1011] Radius
       Dim m_I_4 as Single
       Dim m_AS as Single          ' [1029] Reinforc. area
       Dim m_ASMA as Single        ' [1029] max Reinforcement area
       Dim m_RNG as Single         '        Layer number
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Diameter
       Dim m_AREF as Single        ' [1019] Reference area = width of element
       Dim m_A as Single           ' [1011] distance of bars
       Dim m_PHIA as Single        ' [   5] start angle for generated points
       Dim m_PHIE as Single        ' [   5] end   angle for generated points
      END Structure

      Structure CSECT_URF          ' 9/NR:210  SectionPeriphericReinforcement (CURF,UBEW)
       Dim m_ID as Integer         '        Identification 210/220
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_COVER as Single       ' [1024] static cover
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXP() as Integer '        Exposition class
       Dim m_WC as Single          '        weight for centering reinforcement
       Dim m_AS as Single          ' [1021] Reinforc. area/length
       Dim m_ASMA as Single        ' [1021] max Reinforcement area
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Bar Diameter
       Dim m_AREF as Single        ' [1019] Reference area for crack width
       Dim m_A as Single           ' [1011] distance of bars
      END Structure

      Structure CSECT_USL          ' 9/NR:220  SectionPeriphericShearLink
       Dim m_ID as Integer         '        Identification 210/220
       Dim m_MNO as Integer        '        Material number
       Dim m_IR as Integer         '        Layer number
       Dim m_TNR as Integer        '        Designation
       Dim m_COVER as Single       ' [1024] static cover
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXP() as Integer '        Exposition class
       Dim m_WC as Single          '        weight for centering reinforcement
       Dim m_AS as Single          ' [1021] Reinforc. area/length
       Dim m_ASMA as Single        ' [1021] max Reinforcement area
       Dim m_FT as Single          '        torsional effect
       Dim m_D as Single           ' [1023] Bar Diameter
       Dim m_AREF as Single        ' [1019] Reference area for crack width
       Dim m_A as Single           ' [1011] distance of bars
      END Structure

      Structure CSECT_CPT          ' 9/NR:300  SectionCutStressPoint
       Dim m_ID as Integer         '        Identification 300
       Dim m_MNO as Integer        '        Material of Reinforc. + 1000*Materialnumber
       Dim m_BIT as Integer        '        Cut-Index*128 + Bitpattern
       Dim m_TNR as Integer        '        Designation
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_B0 as Single          ' [1011] width of cut
       Dim m_WTM as Single         ' [1018] Resistance Torsion
       Dim m_WTR as Single         ' [1018] Resistance max Torsion
       Dim m_WVY as Single         ' [1017] Resistance y-shear
       Dim m_WVZ as Single         ' [1017] Resistance z-shear
       Dim m_FRS as Single         '        Factor for total reinf
       Dim m_W0 as Single          ' [1012] unit warping
       Dim m_SIGY as Single        ' [1092] stress perpendicular
       Dim m_BB as Single          ' [1011] total width of cut
       Dim m_VYFK as Single        '        part of total y-shear
       Dim m_VZFK as Single        '        part of total z-shear
       Dim m_BQFK as Single        '        partial width factor
       Dim m_BYFK as Single        ' [1011] shear design width for Vy
       Dim m_BZFK as Single        ' [1011] shear design width for Vz
      END Structure

      Structure CSECT_CUT          ' 9/NR:301  ShearCut (CUT)
       Dim m_ID as Integer         '        Identification 301
       Dim m_MNO as Integer        '        Material of Reinforc. + 1000*Materialnumber
       Dim m_IDP as Integer        '        Bitpattern
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_B0 as Single          ' [1011] effective width
       Dim m_N as Single           ' [1111] Normal force perpend.
       Dim m_M as Single           ' [1114] bending moment perpend
       Dim m_WTM as Single         ' [1018] Resistance Torsion mid
       Dim m_WTD as Single         ' [1018] add tors.resist.edge
       Dim m_VYFK as Single        '        part of total y-shear
       Dim m_VZFK as Single        '        part of total z-shear
       Dim m_BV as Single          ' [1011] total effective width
       Dim m_PHIB as Single        ' [   5] inclination stirups
       Dim m_IRB as Single         '        number of shearlayer
       Dim m_TY as Single          ' [  17] unit shear Sy/Iz
       Dim m_TZ as Single          ' [  17] unit shear Sz/Iy
       Dim m_BRED as Single        ' [1011] reduction for ducts
       Dim m_ASBM as Single        '        Minimum shear reinf.
       Dim m_BETC as Single        '        friction coefficient
       Dim m_MUE as Single         '        friction in joint
       Dim m_ACT as Single         ' [1012] Area of cut off
       Dim m_KSL as Single         '        parameters for plate
       Dim m_SXE as Single         ' [1011] crack spacing for AASTHO
       Dim m_COTT as Single        '        explicit selected inclination for truss model
       Dim m_BMIN as Single        ' [1011] minimum of cut width
       Dim m_BMAX as Single        ' [1011] maximum of cut width
      END Structure

      Structure CSECT_CPL          ' 9/NR:311  Partial polygons of shear cut
       Dim m_ID as Integer         '        Identification 311
       Dim m_MNO as Integer        '        Materialnumber
       Dim m_IDP as Integer        '        Cut number (0=continue last one)
       Dim m_TNR as Integer        '        Designation of cut
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1022)> Dim m_YZ() as Single ' [1011] yz(2,*) = up to seven vertices
      END Structure

      Structure CSECT_APL          ' 9/NR:313  Partial polygons of AKT crack area
       Dim m_ID as Integer         '        Identification 311
       Dim m_MNO as Integer        '        Materialnumber
       Dim m_IDP as Integer        '        Cut number (0=continue last one)
       Dim m_TNR as Integer        '        Designation of cut
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1022)> Dim m_YZ() as Single ' [1011] yz(2,*) = up to seven vertices
      END Structure

      Structure CSECT_HYD          ' 9/NR:900  SectionalHydraulics total section
       Dim m_ID as Integer         '        Identification = 900/903
       Dim m_I_1 as Integer
       Dim m_I_2 as Integer
       Dim m_A as Single           ' [1012] Area
       Dim m_UT as Single          ' [1011] total periphery
       Dim m_UP as Single          ' [1011] total wet periphery
       Dim m_R as Single           ' [1011] hydraulic radius
       Dim m_ZET1 as Single        '        loss factor 1
       Dim m_ZET2 as Single        '        loss factor 2
       Dim m_SLK as Single         '        total leakage
       Dim m_YS as Single          ' [1011] y-Ordinate Center
       Dim m_ZS as Single          ' [1011] y-Ordinate Center
      END Structure

      Structure CSECT_HYP          ' 9/NR:903  SectionalHydraulics partial section
       Dim m_ID as Integer         '        Identification = 900/903
       Dim m_I_1 as Integer
       Dim m_I_2 as Integer
       Dim m_A as Single           ' [1012] Area
       Dim m_UT as Single          ' [1011] total periphery
       Dim m_UP as Single          ' [1011] total wet periphery
       Dim m_R as Single           ' [1011] hydraulic radius
       Dim m_ZET1 as Single        '        loss factor 1
       Dim m_ZET2 as Single        '        loss factor 2
       Dim m_SLK as Single         '        total leakage
       Dim m_YS as Single          ' [1011] y-Ordinate Center
       Dim m_ZS as Single          ' [1011] y-Ordinate Center
      END Structure

      Structure CSECT_HYA          ' 9/NR:904  SectionalHydraulicsAddval
       Dim m_ID as Integer         '        identifier 904
       Dim m_I_2 as Integer
       Dim m_TYPE as Integer       '        type of section
       Dim m_NW as Single          '        Nominal width
       Dim m_YMIN as Single        ' [1011] Minimum Ordinate of section
       Dim m_YMAX as Single        ' [1011] Maximum Ordinate of section
       Dim m_ZMIN as Single        ' [1011] Minimum Ordinate of section
       Dim m_ZMAX as Single        ' [1011] Maximum Ordinate of section
       Dim m_KS as Single          ' [  16] absolute roughness
       Dim m_S as Single           '        storage coefficient
       Dim m_I_8 as Single         '        reserved
       Dim m_I_9 as Single         '        reserved
       Dim m_I_10 as Single        '        reserved
       Dim m_HP as Single          ' [1010] lift of pump
       Dim m_LMIN as Single        '        minimum power
       Dim m_LMAX as Single        '        maximum power
       Dim m_QMAX as Single        '        maximum delivery
      END Structure

      Structure CSECT_HYS          ' 9/NR:910  SectionalHydraulicsPolygon
       Dim m_ID as Integer         '        Identification 910
       Dim m_MAT as Integer        '        identifier 0 (material number)
       Dim m_NR as Integer         '        number of side
       Dim m_TNR as Integer        '        Designation
       Dim m_YA as Single          ' [1011] y-ordinate start
       Dim m_ZA as Single          ' [1011] z-ordinate start
       Dim m_YE as Single          ' [1011] y-ordinate end
       Dim m_ZE as Single          ' [1011] z-ordinate end
       Dim m_KS as Single          ' [  16] absolute roughness
       Dim m_SLK as Single         '        leakage
      END Structure

      Structure CSECT_INS          ' 9/NR:100002  structural database contents
       Dim m_ID as Integer         '        Identification of record key
       Dim m_KWH as Integer        '        Identification of record key (30/31/32)
       Dim m_KWL as Integer        '        Identification of record key (=NR)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IB() as Integer '        buffer of record contents for record KWH/KWL
      END Structure

      Structure CSYST              ' 10/00  SystemInfo
       Dim m_IPROB as Integer      '        Type of System
       Dim m_IACHS as Integer      '        Orientation of gravity
       Dim m_NKNOT as Integer      '        Number of nodes
       Dim m_MKNOT as Integer      '        Highest node number
       Dim m_IGDIV as Integer      '        Group divisor
       Dim m_IGRES as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() as Single ' [1001] bounding box
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TG() as Single '        global CDB-System transformation matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_TXT() as Integer '        Name of projekt, 127 chars
      END Structure

      Structure CSYST_DES          ' 10/1:0  SystemDesignCode
       Dim m_ID as Integer         '        identifier = 0
       Dim m_IDC as Integer        '        Design code enumeration
       Dim m_COUNTRY as Integer    '        Country code for variants
       Dim m_CODE as Integer       '        main number or ident of code
       Dim m_YEAR as Integer       '        Year of publication
       Dim m_CLASS as Integer      '        classification (see master.ini)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_TXT() as Integer '        specific Text of Design code (16 characters)
       Dim m_WIND as Integer       '        enum of a wind classification (see master.ini)
       Dim m_SNOW as Integer       '        enum of a snow-classification (see master.ini)
       Dim m_SEIS as Integer       '        enum of a seismic-classification (see master.ini)
       Dim m_GRAVITY as Single     ' [1202] explicit gravity acceleration constant for site
       Dim m_ALTIOBS as Single     ' [1006] obsoleted altitude above sea level
       Dim m_VERS as Single        '        Version number of INI-File (21.0)
       Dim m_LONGITUD as Single    ' [ 205] longitude of location
       Dim m_LATITUDE as Single    ' [ 205] latitude of location
       Dim m_ALTITUDE as Single    ' [1006] altitude above sea level
      END Structure

      Structure CSYST_ACT          ' 10/1:1  Predefined Actions from INI-file
       Dim m_ID as Integer         '        identifier = 1
       Dim m_ACTION as Integer     '        ID of the real action = type of action
       Dim m_TYPE as Integer       '        16*Part of action + superposition
       Dim m_GAMU as Single        '        safety factor unfavourable
       Dim m_GAMF as Single        '        safety factor favourable
       Dim m_PSI0 as Single        '        combination value
       Dim m_PSI1 as Single        '        frequent combination value
       Dim m_PSI2 as Single        '        quasi permanent combination value
       Dim m_PS1S as Single        '        non frequent combination value psi1'
       Dim m_GAMA as Single        '        safety factor accidential
       Dim m_CAT as Integer        '        sub category of action
       Dim m_TXTREF as Integer     '        designation_enum in SOFISTIK.ERR
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        explicit designation (in native language)
      END Structure

      Structure CSYST_COM_ACT      '        Identifier of action
       Dim m_ID as Integer
       Dim m_FAKU as Single
       Dim m_FAKF as Single
      END Structure

      Structure CSYST_COM          ' 10/1:2  Possible Combination of actions
       Dim m_ID as Integer         '        identifier = 2
       Dim m_LFB as Integer        '        loadcase number offset
       Dim m_EXTR as Integer       '        Combination rule equation to be used
       Dim m_TYPE as Integer       '        type or action of resulting load case
       Dim m_APPLY as Integer      '        Is generally used for:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_TXT() as Integer '        Name of combination
       Dim m_DUMMY as Single       '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=31)> Dim m_ACT() as CSYST_COM_ACT '        Identifier of action
      END Structure

      Structure CGRP               ' 11/00  Groups
       Dim m_NG as Integer         '        group-number
       Dim m_TYP as Integer        '        element code
       Dim m_NUM as Integer        '        number of elements of this type
       Dim m_MIN as Integer        '        minimum element-number of group
       Dim m_MAX as Integer        '        maximum element-number of group
       Dim m_MNR as Integer        '        material-number of group
       Dim m_MBW as Integer        '        reinforcement material-number of group
       Dim m_INF as Integer        '        Bit-code of group
       Dim m_FAKS as Single        '        stiffness factor of group (ASE/TALPA)
       Dim m_FAKA as Single        '        reducing factor of axial bedding for piles
       Dim m_FAKT as Single        '        reducing factor of transverse bedding
       Dim m_VTOT as Single        ' [1093] total volume
       Dim m_MTOT as Single        ' [1093] total mass
       Dim m_RTOT as Single        ' [1030] total reinforcement
       Dim m_ETOT as Single        ' [1093] total energy
       Dim m_ECOM as Single        ' [1093] compression energy
       Dim m_EDEV as Single        ' [1093] shear energy
       Dim m_EKIN as Single        ' [1093] kinetic energy
       Dim m_EPOT as Single        ' [1093] potential energy
       Dim m_EDAM as Single        ' [1093] damping energy
       Dim m_H_GW as Single        ' [1001] Level of Groundwater
       Dim m_DUMMY as Single       '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Group
      END Structure

      Structure CGRP_LC            ' 11/LC  Groups of Loadcase
       Dim m_NG as Integer         '        group-number
       Dim m_TYP as Integer        '        element code
       Dim m_NUM as Integer        '        number of elements of this type
       Dim m_MIN as Integer        '        minimum element-number of group
       Dim m_MAX as Integer        '        maximum element-number of group
       Dim m_MNR as Integer        '        material-number of group
       Dim m_MBW as Integer        '        reinforcement material-number of group
       Dim m_INF as Integer        '        Bit-code of group
       Dim m_FAKS as Single        '        stiffness factor of group (ASE/TALPA)
       Dim m_FAKA as Single        '        reducing factor of axial bedding for piles
       Dim m_FAKT as Single        '        reducing factor of transverse bedding
       Dim m_VTOT as Single        ' [1093] total volume
       Dim m_MTOT as Single        ' [1093] total mass
       Dim m_RTOT as Single        ' [1030] total reinforcement
       Dim m_ETOT as Single        ' [1093] total energy
       Dim m_ECOM as Single        ' [1093] compression energy
       Dim m_EDEV as Single        ' [1093] shear energy
       Dim m_EKIN as Single        ' [1093] kinetic energy
       Dim m_EPOT as Single        ' [1093] potential energy
       Dim m_EDAM as Single        ' [1093] damping energy
       Dim m_H_GW as Single        ' [1001] Level of Groundwater
       Dim m_DUMMY as Single       '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Group
      END Structure

const LTYP_IMP = 70
      Structure CLC_CTRL           ' 12/LC:?  Informations on loadcase LC
       Dim m_KIND as Integer       '        type of loadcase
       Dim m_ITYP as Integer       '        action type (14/ID)
       Dim m_THEO as Integer       '        first order theory
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBA() as Integer '        construction stage number of birth & death
       Dim m_PLC as Integer        '        Primary load case for 2nd order analysis
       Dim m_RPAR as Single        '        Timevalue of Load [sec]
       Dim m_PSI0 as Single        '        combin. factor psi0
       Dim m_PSI1 as Single        '        combin. factor psi1
       Dim m_PSI2 as Single        '        combin. factor psi2
       Dim m_FACT as Single        '        loadcase factor
       Dim m_FACX as Single        '        dead load factor X
       Dim m_FACY as Single        '        dead load factor Y
       Dim m_FACZ as Single        '        dead load factor Z
       Dim m_RX as Single          ' [1151] sum of support PX
       Dim m_RY as Single          ' [1151] sum of support PY
       Dim m_RZ as Single          ' [1151] sum of support PZ
       Dim m_CRI1 as Single        '        1st eval. criteria
       Dim m_CRI2 as Single        '        2nd eval. criteria
       Dim m_CRI3 as Single        '        3rd eval. criteria
       Dim m_GAM1 as Single        '        unfavourable factor
       Dim m_GAM2 as Single        '        favourable factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NAME() as Integer '        Generating source
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_RTEX() as Integer '        Designation of loadcase
      END Structure

      Structure CLC_EVAL           ' 12/LC:011  Evaluation request
       Dim m_ID as Integer         '        identifier 11
       Dim m_LREF as Integer       '        Referenced load case or construction stage
       Dim m_LTYP as Integer       '        type of evaluation request
       Dim m_LEIG as Integer       '        load case number of first eigenvalue
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() as Integer '        Literal of variable name
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=99)> Dim m_VAL() as Single '        Results of evaluation (array for ietyp 4)
      END Structure

      Structure CLC_COPY           ' 12/LC:012  Loads from other loadcases
       Dim m_ID as Integer         '        identifier 12 / 13
       Dim m_LREF as Integer       '        Referenced load case or action ID [chr]
       Dim m_LSEL as Integer       '        selection bits for elements
       Dim m_LITF as Integer       '        enum of applied generic factors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ISEL() as Integer '        optional filter for element numbers
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NREF() as Integer '        Load train application control (see cdblfta.for)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SREF() as Single '        Factors and coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_SUM() as Single '        Sum of forces (psup,lsup)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_CLIT() as Integer '        Literal of an external database as source
      END Structure

      Structure CLC_COPI           ' 12/LC:013  Loads from other loadcases
       Dim m_ID as Integer         '        identifier 12 / 13
       Dim m_LREF as Integer       '        Referenced load case or action ID [chr]
       Dim m_LSEL as Integer       '        selection bits for elements
       Dim m_LITF as Integer       '        enum of applied generic factors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ISEL() as Integer '        optional filter for element numbers
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NREF() as Integer '        Load train application control (see cdblfta.for)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SREF() as Single '        Factors and coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_SUM() as Single '        Sum of forces (psup,lsup)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_CLIT() as Integer '        Literal of an external database as source
      END Structure

      Structure CLC_MBODY          ' 12/LC:2?  Rotation of Body
       Dim m_ID as Integer         '        identifier 20/21
       Dim m_NR as Integer         '        primary or secondary group number of moving elements
       Dim m_NREF as Integer       '        Reference beam number
       Dim m_AX as Single          ' [1003] acceleration local X
       Dim m_AY as Single          ' [1003] acceleration local Y
       Dim m_AZ as Single          ' [1003] acceleration local Z
       Dim m_AXX as Single         ' [1207] rotational acceleration local X-X
       Dim m_AYY as Single         ' [1207] rotational acceleration local Y-Y
       Dim m_AZZ as Single         ' [1207] rotational acceleration local Z-Z
       Dim m_ARX as Single         ' [1207] rotational acceleration local X-X  (= vxx**2)
       Dim m_ARY as Single         ' [1207] rotational acceleration local Y-Y  (= vyy**2)
       Dim m_ARZ as Single         ' [1207] rotational acceleration local Z-Z  (= vzz**2)
       Dim m_EX as Single          ' [1001] global reference point for rotational acceleration
       Dim m_EY as Single          ' [1001] global reference point for rotational acceleration
       Dim m_EZ as Single          ' [1001] global reference point for rotational acceleration
      END Structure

      Structure CLC_LRES_LC        '        load case number and factor (dynamic length)
       Dim m_N as Integer
       Dim m_F as Single
      END Structure

      Structure CLC_LRES           ' 12/LC:89  Explicit factors for selected results
       Dim m_ID as Integer         '        identifier 89
       Dim m_KW as Integer         '        KW where result has been stored
       Dim m_IPOS as Integer       '        Position of Result within record
       Dim m_NREL as Integer       '        Element number
       Dim m_XABS as Single        ' [1011] Section location for beams/structural lines
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_LC() as CLC_LRES_LC '        load case number and factor (dynamic length)
      END Structure

      Structure CLC_LPOS           ' 12/LC:90  Position of Load trains
       Dim m_ID as Integer         '        identifier 90
       Dim m_CASE as Integer       '        number of the case
       Dim m_REF as Integer        '        name of the reference lane
       Dim m_SUB as Integer        '        subnumber of lane
       Dim m_KW as Integer         '        KW where result has been stored
       Dim m_IPOS as Integer       '        Position of Result within record
       Dim m_NREL as Integer       '        Elementnumber
       Dim m_LFTG as Integer       '        LFT*1000+500*ISCONVOY+LFG
       Dim m_XABS as Single        ' [1011] Section location for beams
       Dim m_YEX as Single         ' [1001] Eccentricity of load train
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_PSC() as Single '        Maximum load values in load train (PL/BL)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_XPOS() as Single '        Position and distance values
      END Structure

      Structure CLC_LPO1           ' 12/LC:91  Individual position of Point load
       Dim m_ID as Integer         '        identifier 91
       Dim m_X as Single           ' [1001] Position of individual load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PVAL() as Single '        Load values in PV,PVM,PX,PY
      END Structure

      Structure CLC_LPO2           ' 12/LC:92  Individual position of Block load
       Dim m_ID as Integer         '        identifier 92
       Dim m_XA as Single          ' [1001] Position of individual load start
       Dim m_XE as Single          ' [1001] Position of individual load end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PVAL() as Single '        Load values in PV,PVM,PX,PY
      END Structure

      Structure CLC_LPO3           ' 12/LC:93  Individual residual loadings
       Dim m_ID as Integer         '        identifier 93
       Dim m_XA as Single          ' [1001] Position of individual load start
       Dim m_XE as Single          ' [1001] Position of individual load end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_PVAL() as Single '        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
      END Structure

      Structure CLC_LPOX           ' 12/LC:99  Spandefinitions from ELLA
       Dim m_ID as Integer         '        identifier 99
       Dim m_XA as Single          ' [1001] Limits of an active area start
       Dim m_XE as Single          ' [1001] Limits of an active area end
       Dim m_YL as Single          ' [1001] Limits of an active area left
       Dim m_YR as Single          ' [1001] Limits of an active area right
       Dim m_PHI as Single         '        impact factor
       Dim m_V as Single           ' [1203] velocity of load train
      END Structure

      Structure CLC_POIN_LPT       '        loadpt
       Dim m_P as Single
       Dim m_X as Single           ' [1001] 
       Dim m_Y as Single           ' [1001] 
       Dim m_Z as Single           ' [1001] 
      END Structure

      Structure CLC_POIN           ' 12/LC:10?  Free point loads
       Dim m_KREF as Integer       '        Reference type
       Dim m_NREF as Integer       '        Reference number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TREF() as Integer '        Reference text    (12 characters)
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() as Integer '        Identifiying Text (12 characters)
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_WIDTH as Single       ' [1001] Tolerance load direction to match elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_LPT() as CLC_POIN_LPT '        loadpt
      END Structure

      Structure CLC_LINE_LPT       '        loadpts
       Dim m_P as Single
       Dim m_X as Single           ' [1001] 
       Dim m_Y as Single           ' [1001] 
       Dim m_Z as Single           ' [1001] 
      END Structure

      Structure CLC_LINE           ' 12/LC:11?  Free line loads
       Dim m_KREF as Integer       '        Reference type
       Dim m_NREF as Integer       '        Reference number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TREF() as Integer '        Reference text    (12 characters)
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() as Integer '        Identifiying Text (12 characters)
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_WIDTH as Single       ' [1001] Tolerance load direction to match elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() as CLC_LINE_LPT '        loadpts
      END Structure

      Structure CLC_CURV_LPT       '        loadpts
       Dim m_P as Single
       Dim m_X as Single           ' [1001] 
       Dim m_Y as Single           ' [1001] 
       Dim m_Z as Single           ' [1001] 
      END Structure

      Structure CLC_CURV           ' 12/LC:14?  Free spline loads
       Dim m_KREF as Integer       '        Reference type
       Dim m_NREF as Integer       '        Reference number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TREF() as Integer '        Reference text    (12 characters)
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() as Integer '        Identifiying Text (12 characters)
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_WIDTH as Single       ' [1001] Tolerance load direction to match elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() as CLC_CURV_LPT '        loadpts
      END Structure

      Structure CLC_AREA_LPT       '        loadpts
       Dim m_P as Single
       Dim m_X as Single           ' [1001] 
       Dim m_Y as Single           ' [1001] 
       Dim m_Z as Single           ' [1001] 
      END Structure

      Structure CLC_AREA           ' 12/LC:12?  Free area loads
       Dim m_KREF as Integer       '        Reference type
       Dim m_NREF as Integer       '        Reference number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TREF() as Integer '        Reference text    (12 characters)
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() as Integer '        Identifiying Text (12 characters)
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_WIDTH as Single       ' [1001] Tolerance load direction to match elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() as CLC_AREA_LPT '        loadpts
      END Structure

      Structure CLC_VOLU           ' 12/LC:13?  Free volume loads
       Dim m_KREF as Integer       '        Reference type
       Dim m_NREF as Integer       '        Reference number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TREF() as Integer '        Reference text    (12 characters)
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() as Integer '        Identifiying Text (12 characters)
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_WIDTH as Single       ' [1001] Factor for silo fillings A/U
       Dim m_P0 as Single          '        load value
       Dim m_X as Single           ' [1001] Reference point for load value P0
       Dim m_Y as Single           ' [1001] 
       Dim m_Z as Single           ' [1001] 
       Dim m_P1 as Single          '        variant load value second reference point
       Dim m_DX1 as Single         ' [1001] Reference point for load value P1
       Dim m_DY1 as Single         ' [1001] 
       Dim m_DZ1 as Single         ' [1001] 
       Dim m_P2 as Single          '        variant load value second reference point
       Dim m_DX2 as Single         ' [1001] Reference point for load value P2
       Dim m_DY2 as Single         ' [1001] 
       Dim m_DZ2 as Single         ' [1001] 
       Dim m_P3 as Single          '        variant load value second reference point
       Dim m_DX3 as Single         ' [1001] Reference point for load value P3
       Dim m_DY3 as Single         ' [1001] 
       Dim m_DZ3 as Single         ' [1001] 
       Dim m_P4 as Single          '        variant load value second reference point
       Dim m_DX4 as Single         ' [1001] Reference point for load value P2
       Dim m_DY4 as Single         ' [1001] 
       Dim m_DZ4 as Single         ' [1001] 
       Dim m_P5 as Single          '        variant load value second reference point
       Dim m_DX5 as Single         ' [1001] Reference point for load value P3
       Dim m_DY5 as Single         ' [1001] 
       Dim m_DZ5 as Single         ' [1001] 
      END Structure

      Structure CGLC_GUID          ' 12/LC:199  Unique identifier of loading member
       Dim m_ID as Integer         '        identifier 199
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of following element
      END Structure

      Structure CLC_TRAI           ' 12/LC:300  Train loading
       Dim m_ID as Integer         '        identifier 300
       Dim m_IDEN as Integer       '        Type of load train
       Dim m_BPAT as Integer       '        Preselected Bitpattern of special options
       Dim m_P1 as Single          '        Char Designation or Class of loading
       Dim m_P2 as Single          '        second entry for load magnitude
       Dim m_P3 as Single          '        third entry for load magnitude
       Dim m_P4 as Single          '        fourth entry for load magnitude
       Dim m_P5 as Single          '        Basic area loading
       Dim m_P6 as Single          '        Wind loading
       Dim m_P7 as Single          '        Height subjected to wind load
       Dim m_P8 as Single          '        Entry for brake loading
       Dim m_P9 as Single          '        Height of the gravity centreline
       Dim m_TOTFAC as Single      '        Factor for the vertical loads of the
       Dim m_PHIB as Single        '        explicit impact factor for bending
       Dim m_PHIBF as Single       '        explicit impact factor favourable bending
       Dim m_PHIS as Single        '        explicit impact factor for shear
       Dim m_PHISF as Single       '        explicit impact factor favourable shear
       Dim m_WIDTH as Single       ' [1001] Width of moving lane to be spared with P5
       Dim m_YEX as Single         ' [1001] reserved: Eccentricity of loading in lane
       Dim m_XCOL as Single        ' [1001] Minimum distance for multiple instances
       Dim m_V as Single           ' [1203] Speed of train
       Dim m_FACF as Single        '        Factor for the masses of the loading
       Dim m_FAVF as Single        '        factor for favorable loading
       Dim m_FRB as Single         '        Frequence of body to bogie spring
       Dim m_DAB as Single         '        Modal damping of body to bogie
       Dim m_PZBO as Single        ' [1001] Fractional load value of bogie (included in PZ)
       Dim m_FRBO as Single        '        Frequence of bogie to wheel spring
       Dim m_DABO as Single        '        Modal damping of bogie to body
       Dim m_PZWH as Single        ' [1001] Fractional load value of wheel (included in PZ)
       Dim m_FRWH as Single        '        Frequence of wheel to surface / bridge deck
       Dim m_DAWH as Single        '        Modal damping of wheel to surface
      END Structure

      Structure CLC_TRAL           ' 12/LC:301  Individual loads of Train loading
       Dim m_ID as Integer         '        identifier 301
       Dim m_TYPE as Integer       '        Type of loading
       Dim m_BPAT as Integer       '        contact node for single loads
       Dim m_PZ as Single          '        Vertical loading
       Dim m_YMIN as Single        ' [1001] min eccentricity in y direction
       Dim m_YMAX as Single        ' [1001] max eccentricity in y direction
       Dim m_PX as Single          '        Load value for braking
       Dim m_PW as Single          '        Explicit force for wind attack
       Dim m_ZW as Single          ' [1001] Height for wind force resultant
       Dim m_PV as Single          '        Massvalue for zentrifugal force
       Dim m_ZPV as Single         ' [1001] Height for zentrifugal force resultant
       Dim m_FACFAV as Single      '        Factor for favourable effects
       Dim m_A as Single           ' [1001] Distance to last load
       Dim m_L as Single           ' [1001] Length of loading for block loads (0 = unlimited)
       Dim m_LMAX as Single        ' [1001] Maximum length of block loading if variable
       Dim m_LDEL as Single        ' [1001] Discrete increment of length for block loading
       Dim m_HW as Single          ' [1001] Height of train for wind attack area
       Dim m_WIDTH as Single       ' [1001] Width of train
       Dim m_YEXVAR as Single      '        Variable eccentricity for secondary load trains
       Dim m_WWHEEL as Single      ' [1001] Width of single wheel
       Dim m_LWHEEL as Single      ' [1001] Length of single wheel
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() as Single '        reserved
       Dim m_FRB as Single         '        Frequence of body to bogie spring
       Dim m_DAB as Single         '        Modal damping of body to bogie
       Dim m_PZBO as Single        ' [1001] Fractional load value of bogie (included in PZ)
       Dim m_FRBO as Single        '        Frequence of bogie to wheel spring
       Dim m_DABO as Single        '        Modal damping of bogie to body
       Dim m_PZWH as Single        ' [1001] Fractional load value of wheel (included in PZ)
       Dim m_FRWH as Single        '        Frequence of wheel to surface / bridge deck
       Dim m_DAWH as Single        '        Modal damping of wheel to surface
      END Structure

      Structure CLC_WIND           ' 12/LC:400  wind loading
       Dim m_ID as Integer         '        identifier 400
       Dim m_NORM as Integer       '        wind design code
       Dim m_CLAS as Integer       '        type of zone and terrain
       Dim m_VATM as Single        ' [1201] atmospheric wind
       Dim m_VREF as Single        ' [1201] mean reference wind
       Dim m_VBOE as Single        ' [1201] gust reference wind
       Dim m_DX as Single          '        components of wind direction
       Dim m_DY as Single
       Dim m_DZ as Single
       Dim m_XREF as Single        ' [1001] Reference point
       Dim m_YREF as Single        ' [1001] 
       Dim m_ZREF as Single        ' [1001] 
       Dim m_DXRE as Single        '        Reference direction
       Dim m_DYRE as Single
       Dim m_DZRE as Single
       Dim m_GH as Single          ' [1001] coordinate of ground level
       Dim m_HMIN as Single        ' [1001] value for constant wind speed below (zmin)
       Dim m_RHO as Single         ' [  59] weight of the air / fluid
       Dim m_LAT as Single         ' [   5] explicit lattitude of site
       Dim m_Z0 as Single          ' [1001] explicit roughness
      END Structure

      Structure CLC_WTOP           ' 12/LC:401  Wind environment
       Dim m_ID as Integer         '        identifier 401
       Dim m_TYP as Single         '        type of environment height
       Dim m_I_2 as Single         '        reserved
       Dim m_XM as Single          ' [1001] center of elevation in system coordinates
       Dim m_YM as Single          ' [1001] center of elevation in system coordinates
       Dim m_ZM as Single          ' [1001] center of elevation in system coordinates
       Dim m_DX as Single          '        direction of crest of ridge
       Dim m_DY as Single          '        or local x-coordinate of a summit
       Dim m_DZ as Single
       Dim m_H as Single           ' [1001] height above ground defining the slopes
       Dim m_WLEN as Single        ' [1001] width in negative local y direction
       Dim m_BLEN as Single        ' [1001] width in positive local x direction
      END Structure

      Structure CLC_WROU_R         '        limits given
       Dim m_D as Single           ' [1001] 
       Dim m_R as Single           ' [1001] 
       Dim m_DH as Single          ' [1001] 
       Dim m_HH as Single          ' [1001] 
      END Structure

      Structure CLC_WROU           ' 12/LC:402  Roughness (wind)
       Dim m_ID as Integer         '        identifier 402
       Dim m_I_1 as Single         '        reserved
       Dim m_I_2 as Single         '        reserved
       Dim m_DSEA as Single        ' [1001] Distance to the sea
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_R() as CLC_WROU_R '        limits given
      END Structure

      Structure CLC_WSPE           ' 12/LC:410  wind spectrum
       Dim m_ID as Integer         '        identifier 410
       Dim m_TYP as Integer        '        type of spectra
       Dim m_CTYP as Integer       '        type of coherence model
       Dim m_A1LO as Single        '        1st coefficient longitudinal
       Dim m_A2LO as Single        '        2nd coefficient longitudinal
       Dim m_A3LO as Single        '        3rd coefficient longitudinal
       Dim m_B_LO as Single        '        4th coefficient longitudinal
       Dim m_C_LO as Single        '        5th coefficient longitudinal
       Dim m_D_LO as Single        '        6th coefficient longitudinal
       Dim m_A1LA as Single        '        1st coefficient lateral
       Dim m_A2LA as Single        '        2nd coefficient lateral
       Dim m_A3LA as Single        '        3rd coefficient lateral
       Dim m_B_LA as Single        '        4th coefficient lateral
       Dim m_C_LA as Single        '        5th coefficient lateral
       Dim m_D_LA as Single        '        6th coefficient lateral
       Dim m_A1VE as Single        '        1st coefficient vertical
       Dim m_A2VE as Single        '        2nd coefficient vertical
       Dim m_A3VE as Single        '        3rd coefficient vertical
       Dim m_B_VE as Single        '        4th coefficient vertical
       Dim m_C_VE as Single        '        5th coefficient vertical
       Dim m_D_VE as Single        '        6th coefficient vertical
       Dim m_C3D as Single         '        Longitudinal coefficient
       Dim m_KUU as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KUV as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KUW as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KVU as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KVV as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KVW as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KWU as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KWV as Single         '        HWD factor for ESDU, coefficient otherwise
       Dim m_KWW as Single         '        HWD factor for ESDU, coefficient otherwise
      END Structure

      Structure CLC_WTST           ' 12/LC:411  wind coherence test requests
       Dim m_ID as Integer         '        identifier 411
       Dim m_TYP as Integer        '        type of coherence component
       Dim m_LC as Integer         '        load case of an eigenvalue
       Dim m_XREF as Single        ' [1001] Reference point
       Dim m_YREF as Single        ' [1001] 
       Dim m_ZREF as Single        ' [1001] 
       Dim m_RX as Single          ' [1001] Distance or direction of distance
       Dim m_RY as Single          ' [1001] 
       Dim m_RZ as Single          ' [1001] 
       Dim m_CX as Single          '        Davenport/Krenk reference coefficients
       Dim m_CY as Single
       Dim m_CZ as Single
       Dim m_EIG as Single         '        Eigenfrequency (Hertz) for LC>0
       Dim m_U as Single           ' [  96] mean velocity
       Dim m_HWD as Single         ' [1001] real distance for LC==0
       Dim m_XMAX as Single        '        maximum x-value for data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_DATA() as Single '        calculated sqrt of coherence data ( 2 sets)
      END Structure

      Structure CLC_WPRC           ' 12/LC:420  wind profile control values
       Dim m_ID as Integer         '        identifier 420
       Dim m_ID2 as Integer        '        identifier 0
       Dim m_IPRO as Single        '        number of generated profiles
       Dim m_WXMI as Single        ' [1001] size of structure in wind coordinates
       Dim m_WXMA as Single        ' [1001] 
       Dim m_WYMI as Single        ' [1001] 
       Dim m_WYMA as Single        ' [1001] 
       Dim m_WZMI as Single        ' [1001] 
       Dim m_WZMA as Single        ' [1001] 
       Dim m_ALFA as Single        '        some angle ...
       Dim m_BETA as Single        '        some angle ...
       Dim m_GAMM as Single        '        some angle ...
       Dim m_DELT as Single        '        some angle ...
      END Structure

      Structure CLC_WPRO           ' 12/LC:420  wind profile distinct values
       Dim m_ID as Integer         '        identifier 420
       Dim m_IST as Integer        '        source of data
       Dim m_I_2 as Single         '        index reserved
       Dim m_H as Single           ' [1001] height above ground level
       Dim m_V as Single           ' [1201] mean value of wind velocity
       Dim m_VBOE as Single        ' [1201] peak value of wind velocity
       Dim m_TLON as Single        ' [1201] longitudinal turbulence
       Dim m_TLAT as Single        ' [1201] lateral turbulence
       Dim m_TVER as Single        ' [1201] vertical turbulence
       Dim m_LLON as Single        ' [1001] longitudinal wave length
       Dim m_LLAT as Single        ' [1001] lateral wave length
       Dim m_LVER as Single        ' [1001] vertical wave length
       Dim m_PHAS as Single        '        phase
      END Structure

      Structure CLC_WAVE           ' 12/LC:500  Wave Loading
       Dim m_ID as Integer         '        identifier 500
       Dim m_TYP as Integer        '        wave theory bit pattern
       Dim m_NF as Integer         '        number of frequencies in spectra
       Dim m_H as Single           ' [1001] wave height / significant wave height
       Dim m_T as Single           ' [  90] period of wave / peak period of wave
       Dim m_D as Single           ' [1001] water depth (0 = infinite)
       Dim m_SWL as Single         ' [1001] sea water reference level
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() as Single '        principal direction of travelling
       Dim m_UC as Single          ' [1201] additional constant current
       Dim m_ALF as Single         '        exponent U(z)=UC*(z/d)**alf
       Dim m_RHO as Single         ' [  59] weight of the fluid
       Dim m_L as Single           ' [1001] calculated wave length
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_PAR() as Single '        special parameters for wave spectra
      END Structure

      Structure CLC_HIST           ' 13/LC:0  TimeHistoryTitle
       Dim m_ID as Integer         '        identifier 0
       Dim m_IDT as Integer        '        Unit of time resp x-axis
       Dim m_IDF as Integer        '        Unit of function values
       Dim m_NFUN as Integer       '        number of functions
       Dim m_NVAL as Integer       '        max number of discrete time values
       Dim m_TYPE as Integer       '        general type of curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() as Integer '        Designation
      END Structure

      Structure CLC_DAMP           ' 13/LC:1  Damping values
       Dim m_ID as Integer         '        identifier 1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_D() as Single '        modal damping values
      END Structure

      Structure CLC_FVAL           ' 13/LC:?0  Discrete function values
       Dim m_ID as Integer         '        identifier
       Dim m_TT as Single          '        Time/frequency/modenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_F() as Single '        function values
      END Structure

      Structure CLC_FMODC          ' 13/LC:9?  Explicit modal coordinates
       Dim m_ID as Integer         '        identifier
       Dim m_TT as Single          '        Time/frequency/modenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_F() as Single '        function values
      END Structure

      Structure CLC_FSIN           ' 13/LC:11  Harmonic function additive
       Dim m_ID as Integer         '        identifier
       Dim m_T as Single           ' [  90] Time/frequency
       Dim m_F1 as Single          '        Amplitude value
       Dim m_PHI1 as Single        ' [  90] phase value
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime if > starttime
       Dim m_S as Single           '        impactfactor
       Dim m_F2 as Single          '        Amplitude value for T/2 (Fourier)
       Dim m_PHI2 as Single        ' [  90] phase value for f2
       Dim m_F3 as Single          '        Amplitude value for T/3 (Fourier)
       Dim m_PHI3 as Single        ' [  90] phase value for f3
       Dim m_F4 as Single          '        Amplitude value for T/4 (Fourier)
       Dim m_PHI4 as Single        ' [  90] phase value for f4
      END Structure

      Structure CLC_FSINM          ' 13/LC:21  Harmonic function multiplier
       Dim m_ID as Integer         '        identifier
       Dim m_T as Single           ' [  90] Time/frequency
       Dim m_F1 as Single          '        Amplitude value
       Dim m_PHI1 as Single        ' [  90] phase value
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime if > starttime
       Dim m_S as Single           '        impactfactor
       Dim m_F2 as Single          '        Amplitude value for T/2 (Fourier)
       Dim m_PHI2 as Single        ' [  90] phase value for f2
       Dim m_F3 as Single          '        Amplitude value for T/3 (Fourier)
       Dim m_PHI3 as Single        ' [  90] phase value for f3
       Dim m_F4 as Single          '        Amplitude value for T/4 (Fourier)
       Dim m_PHI4 as Single        ' [  90] phase value for f4
      END Structure

      Structure CLC_FSTP           ' 13/LC:12  Periodic stepping function additive
       Dim m_ID as Integer         '        identifier
       Dim m_T as Single           ' [  90] Time/frequency
       Dim m_F as Single           '        Amplitude value
       Dim m_TC as Single          ' [  90] contact time
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime if > starttime
       Dim m_S as Single           '        impactfactor (Sailer/Hüttner/Bachmann)
      END Structure

      Structure CLC_FSTPM          ' 13/LC:22  Periodic stepping function multiplier
       Dim m_ID as Integer         '        identifier
       Dim m_T as Single           ' [  90] Time/frequency
       Dim m_F as Single           '        Amplitude value
       Dim m_TC as Single          ' [  90] contact time
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime if > starttime
       Dim m_S as Single           '        impactfactor (Sailer/Hüttner/Bachmann)
      END Structure

      Structure CLC_FINA           ' 13/LC:13  Aperiodic function additive
       Dim m_ID as Integer         '        identifier 13
       Dim m_T as Single           ' [  90] Total Time
       Dim m_F as Single           '        Amplitude value
       Dim m_T1 as Single          ' [  90] Time of constant intensity
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime = tmin+T
       Dim m_TYP as Integer        '        Type of function
       Dim m_F2 as Single          '        Amplitude factor
       Dim m_T2 as Single          ' [  90] lead in time duration
       Dim m_F3 as Single          '        Amplitude factor
       Dim m_T3 as Single          ' [  90] lead out time duration
      END Structure

      Structure CLC_FINM           ' 13/LC:23  Aperiodic function multiplier
       Dim m_ID as Integer         '        identifier 13
       Dim m_T as Single           ' [  90] Total Time
       Dim m_F as Single           '        Amplitude value
       Dim m_T1 as Single          ' [  90] Time of constant intensity
       Dim m_TMIN as Single        ' [  90] starttime
       Dim m_TMAX as Single        ' [  90] stoptime = tmin+T
       Dim m_TYP as Integer        '        Type of function
       Dim m_F2 as Single          '        Amplitude factor
       Dim m_T2 as Single          ' [  90] lead in time duration
       Dim m_F3 as Single          '        Amplitude factor
       Dim m_T3 as Single          ' [  90] lead out time duration
      END Structure

      Structure CLC_RESW           ' 13/LC:9??  Response spectra wind
       Dim m_TYP as Integer        '        Type of spectra 900 - 999
       Dim m_SINT as Single        '        Integral of spectra
       Dim m_A1 as Single          '        Spectrum coefficient
       Dim m_A2 as Single          '        Spectrum coefficient
       Dim m_A3 as Single          '        Spectrum coefficient
       Dim m_B as Single           '        Spectrum coefficient
       Dim m_C as Single           '        Spectrum coefficient
       Dim m_D as Single           '        Spectrum coefficient
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_RES() as Single '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() as Integer '        Designation of Spectra
      END Structure

      Structure CLC_RESP           ' 13/LC:???  Response seismic spectra
       Dim m_TYP as Integer        '        Type of spectra 100 - 999
       Dim m_D as Single           '        Damping value eta or behaviour factor q
       Dim m_SA as Single          '        Rigid acceleration factor (Soil Parameter S)
       Dim m_SB as Single          '        Max acceleration factor
       Dim m_SMIN as Single        '        Min acceleration factor (beta)
       Dim m_TB as Single          ' [  90] Time value
       Dim m_TC as Single          ' [  90] Time value
       Dim m_TD as Single          ' [  90] Time value
       Dim m_TE as Single          ' [  90] Cutt-Off Time
       Dim m_K1 as Single          '        Coefficient k1
       Dim m_K2 as Single          '        Coefficient k2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ZONE() as Integer '        Seismic zone
       Dim m_AG as Single          ' [1202] Reference base acceleration
       Dim m_AH as Single          '        Horizontal factor (importance etc.)
       Dim m_AV as Single          '        Vertical factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() as Integer '        Designation of Spectra
      END Structure

      Structure CLC_FREF           ' 13/LC:????  Discrete reference function values
       Dim m_ID as Integer         '        line type
       Dim m_TT as Single          '        Time/frequency
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_F() as Single '        function values
      END Structure

      Structure CACT_TASK_SCOM     '        index,factor and name of items
       Dim m_IND as Integer
       Dim m_FAK as Single
       Dim m_BEZ as Integer
      END Structure

      Structure CACT_TASK          ' 14/0  Superposition task commands
       Dim m_IVERS as Integer      '        < 9999 = old data format (ACT_RULE)
       Dim m_NUM as Integer        '        number of superposition command
       Dim m_ACT as Integer        '        number of groups of actions at 14/act
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFM() as Integer '        base of load case numbers
       Dim m_KSAV as Integer       '        0 = do not save, >0 = save factors as combination KSAV
       Dim m_KWERG as Integer      '        Identifier of resultrecord in CDB
       Dim m_FROM as Integer       '        smallest  element number
       Dim m_TO as Integer         '        highest   element number
       Dim m_INC as Integer        '        increment element number
       Dim m_TID as Integer        '        optional identifier
       Dim m_X as Single           ' [1001] X-ordinate for beams (see INC!)
       Dim m_COMB as Integer       '        combination method for items given at SCOM
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_SCOM() as CACT_TASK_SCOM '        index,factor and name of items
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TXT() as Integer '        Name of superposition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_UFORM() as Integer '        User defined target function (index == 0!)
      END Structure

      Structure CACT_RULE_SCOM     '        index,factor and name of items
       Dim m_IND as Integer
       Dim m_FAK as Single
       Dim m_BEZ as Integer
      END Structure

      Structure CACT_RULE          ' 14/0  Superposition commands (old Version)
       Dim m_NUM as Integer        '        number of superposition command
       Dim m_ACT as Integer        '        number of groups of actions at 14/act
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFM() as Integer '        base of load case numbers
       Dim m_KWERG as Integer      '        Identifier of resultrecord in CDB
       Dim m_FROM as Integer       '        smallest  element number (echo only)
       Dim m_TO as Integer         '        highest   element number (echo only)
       Dim m_INC as Integer        '        increment element number (echo only)
       Dim m_TID as Integer        '        optional identifier
       Dim m_COMB as Integer       '        combination method for items given at SCOM
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_SCOM() as CACT_RULE_SCOM '        index,factor and name of items
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TXT() as Integer '        Name of superposition
      END Structure

      Structure CLC_ACT0           ' 14/NR:0  Group of Actions for SUPP-task
       Dim m_ID as Integer         '        ident = 0  user defined ; < 0 automatic
       Dim m_LFB as Integer        '        load case offset
       Dim m_EXTR as Integer       '        type of formula for evaluating the extrema
       Dim m_TYPE as Integer       '        type or action of resulting load case
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Group designation for collection of actions
      END Structure

      Structure CLC_CACT0          ' 12/LC:80  Group of Actions for SUPP-task
       Dim m_ID as Integer         '        ident = 0  user defined ; < 0 automatic
       Dim m_LFB as Integer        '        load case offset
       Dim m_EXTR as Integer       '        type of formula for evaluating the extrema
       Dim m_TYPE as Integer       '        type or action of resulting load case
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Group designation for collection of actions
      END Structure

      Structure CLC_ACT1           ' 14/NR:1  Action member
       Dim m_ID as Integer         '        ident = 1 / 81
       Dim m_ACTION as Integer     '        ID of the action = type of action
       Dim m_TYPE as Integer       '        256*subgroup + 16*Group_of_action + superposition
       Dim m_GAMU as Single        '        safety factor unfavourable
       Dim m_GAMF as Single        '        safety factor favourable
       Dim m_PSI0 as Single        '        combination value
       Dim m_PSI1 as Single        '        combination value
       Dim m_PSI2 as Single        '        quasi permanent combination value
       Dim m_PS1S as Single        '        non frequent combination value psi1'
       Dim m_GAMA as Single        '        safety factor accidential
       Dim m_CAT as Integer        '        category (see 14/ID) not used here
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        designation
      END Structure

      Structure CLC_CACT1          ' 12/NR:81  current action member
       Dim m_ID as Integer         '        ident = 1 / 81
       Dim m_ACTION as Integer     '        ID of the action = type of action
       Dim m_TYPE as Integer       '        256*subgroup + 16*Group_of_action + superposition
       Dim m_GAMU as Single        '        safety factor unfavourable
       Dim m_GAMF as Single        '        safety factor favourable
       Dim m_PSI0 as Single        '        combination value
       Dim m_PSI1 as Single        '        combination value
       Dim m_PSI2 as Single        '        quasi permanent combination value
       Dim m_PS1S as Single        '        non frequent combination value psi1'
       Dim m_GAMA as Single        '        safety factor accidential
       Dim m_CAT as Integer        '        category (see 14/ID) not used here
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        designation
      END Structure

      Structure CLC_ACT_L          ' 14/NR:2  loadcase of action
       Dim m_ID as Integer         '        ident = 2 / 82
       Dim m_LF as Integer         '        load case number
       Dim m_TYPE as Integer       '        load case action type
       Dim m_FACT as Single        '        factor
      END Structure

      Structure CLC_CACT2          ' 12/NR:82  current loadcase of action
       Dim m_ID as Integer         '        ident = 2 / 82
       Dim m_LF as Integer         '        load case number
       Dim m_TYPE as Integer       '        load case action type
       Dim m_FACT as Single        '        factor
      END Structure

      Structure CLC_ACT_R          ' 14/NR:1?  Response Spectra
       Dim m_ID as Integer         '        Evaluation type of response
       Dim m_RESP as Integer       '        load case number of spectra
       Dim m_LFEIG as Integer      '        load case of first eigenform
       Dim m_NEIG as Integer       '        numbers of eigenforms to be used
      END Structure

      Structure CLC_ACT            ' 14/ID:1  Action defaults
       Dim m_ID as Integer         '        ident = 1
       Dim m_ACTION as Integer     '        ID of the real action = type of action
       Dim m_TYPE as Integer       '        256*subgroup + 16*Group_of_action + superposition
       Dim m_GAMU as Single        '        safety factor unfavourable
       Dim m_GAMF as Single        '        safety factor favourable
       Dim m_PSI0 as Single        '        combination value
       Dim m_PSI1 as Single        '        combination value
       Dim m_PSI2 as Single        '        quasi permanent combination value
       Dim m_PS1S as Single        '        non frequent combination value psi1'
       Dim m_GAMA as Single        '        safety factor accidential
       Dim m_CAT as Integer        '        category for preselection of psi-values
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        designation
      END Structure

      Structure CCSM_GRP           ' 15/-1  Construction Stage Group Definitions
       Dim m_GRP as Integer        '        Group number
       Dim m_ICS as Integer        '        CS number of first activation
       Dim m_GFIX as Integer       '        CS number of hinge fixing
       Dim m_END as Integer        '        CS number of last action
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FREE() as Integer '        free integer for later use
       Dim m_T0 as Single          ' [  93] minimum age for loading
      END Structure

      Structure CCSM_LC            ' 15/-2  Construction Stage Loadcase Definitions
       Dim m_LC as Integer         '        Loadcase
       Dim m_START as Integer      '        CS number for first action
       Dim m_END as Integer        '        CS number of last action
      END Structure

      Structure CCSM_CS            ' 15/-3  Construction Stage Table
       Dim m_CS as Integer         '        Construction Stage
       Dim m_ID as Integer         '        Main action type in this CS
       Dim m_CSTEP as Integer      '        number of creep+shrink step to be produced
       Dim m_DL_CS as Integer      '        dead load activation in composite cross sections
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FREE() as Integer '        free integer for later use
       Dim m_DT as Single          ' [  93] duration of creep+shrink step
       Dim m_RH as Single          ' [   8] relative humidity in this creep+shrink step
       Dim m_TEMP as Single        ' [   8] temperture in this creep+shrink step
      END Structure

      Structure CCSM_CREE          ' 15/-4  creep+shrink values for manual input
       Dim m_MNO as Integer        '        Material number
       Dim m_GRP as Integer        '        Group number
       Dim m_PHI as Single         '        total creep factor from first loading til infinite
       Dim m_EPS as Single         '        total shrinkage coefficient
       Dim m_RELAX as Single       '        total tendon relaxation
      END Structure

      Structure CCSG_CS            ' 15/-10  Construction Stage
       Dim m_NO as Integer         '        construction stage number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_TITL() as Integer '        Designation
       Dim m_DT as Single          ' [  93] duration of construction stage
      END Structure

      Structure CCSG_CGRP          ' 15/-11  Group specification
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_NO as Integer         '        group number
       Dim m_ACT as Integer        '        group action
       Dim m_ACT2 as Integer       '        group action cont'd
       Dim m_PTYP as Integer       '        type of prestressing
       Dim m_PLQ as Integer        '        primary load case swelling
       Dim m_MNO as Integer        '        material number
       Dim m_FACS as Single        '        stiffness factor
       Dim m_ALPH as Single        '        alpha factor
       Dim m_HW as Single          ' [  13] ground water level
       Dim m_K as Single           '        earth pressure coefficient
       Dim m_P as Single           '        prestress force
      END Structure

      Structure CCSG_CLAS          ' 15/-12  Load specification
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_NO as Integer         '        number of referenced loadcase
       Dim m_OPT as Integer        '        option of the load
       Dim m_FACT as Single        '        factor for loads
      END Structure

      Structure CCSG_CSYS          ' 15/-13  System specification
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_PROB as Integer       '        problem type
      END Structure

      Structure CCSG_CCRL          ' 15/-14  Computation control
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_OPT as Integer        '        control option
       Dim m_SAVE as Integer       '        save interval
       Dim m_FACQ as Integer       '        not used
       Dim m_VAL as Single         '        value of the option
       Dim m_FMAX as Single        '        2nd value of the option
       Dim m_FMIN as Single        '        3rd value of the option
       Dim m_EMAX as Single        '        4th value of the option
       Dim m_EMIN as Single        '        5th value of the option
       Dim m_V6 as Single          '        6th value of the option
       Dim m_V7 as Single          '        7th value of the option
       Dim m_V8 as Single          '        8th value of the option
      END Structure

      Structure CCSG_CGW           ' 15/-15  Change ground water level
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_HW as Single          ' [  13] new ground water level
      END Structure

      Structure CCSG_ECHO          ' 15/-16  Echo options
       Dim m_ICS as Integer        '        corresponding cs number
       Dim m_OPT as Integer        '        echo option
       Dim m_VAL as Integer        '        value of the option
      END Structure

      Structure CCSM_LC1           ' 15/LC:1  CSM loadcase parameters Group members
       Dim m_ID as Integer         '        identifier 1
       Dim m_GRP as Integer        '        Group number
       Dim m_T1 as Single          ' [  93] age at the end of loadcase
       Dim m_SUMEPS as Single      '        accumulated shrinkage strain
      END Structure

      Structure CCSM_LC2           ' 15/LC:2  CSM loadcase parameters quad-tendon members
       Dim m_ID as Integer         '        identifier 2
       Dim m_GRP as Integer        '        quad-tendon number
       Dim m_T1 as Single          ' [  93] age at the end of loadcase
       Dim m_SUMRELAX as Single    '        accumulated quad-tendon relaxation
      END Structure

      Structure CVIEW              ' 18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
       Dim m_IACHS as Integer      '        downward direction (compare 10/0)
       Dim m_PERS as Integer       '        Perspective
       Dim m_LC as Integer         '        loadcase
       Dim m_VOPT as Integer       '        View Options (Bitcode I)
       Dim m_EOPT as Integer       '        Element Options (Bitcode II)
       Dim m_COPT as Integer       '        Colour Options (Bitcode III)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DUMMY() as Integer '        reserved
       Dim m_TOPT as Integer       '        Exchange option
       Dim m_XBL as Single         ' [1001] X-coordinate of view point
       Dim m_YBL as Single         ' [1001] Y-coordinate of view point
       Dim m_ZBL as Single         ' [1001] Z-coordinate of view point
       Dim m_XCAM as Single        ' [1001] X-coordinate of camera point
       Dim m_YCAM as Single        ' [1001] Y-coordinate of camera point
       Dim m_ZCAM as Single        ' [1001] Z-coordinate of camera point
       Dim m_FAKV as Single        '        Factor of deformed structure
       Dim m_SSIZ as Single        '        Size of supports (0.-100.)
       Dim m_WMAG as Single        '        Warping magnification (0.-100.)
       Dim m_FOVY as Single        ' [   5] perspective angle of field of view
       Dim m_XUP as Single         '        X-part Up Vector
       Dim m_YUP as Single         '        Y-part Up Vector
       Dim m_ZUP as Single         '        Z-part Up Vector
      END Structure

      Structure CVIEW_SEL_R        '        Range lower and upper limit
       Dim m_LOW as Integer
       Dim m_UPP as Integer
      END Structure

      Structure CVIEW_SEL          ' 18/-2  currently selected elements in WINGRAF
       Dim m_ID as Integer         '        Identifikator
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_R() as CVIEW_SEL_R '        Range lower and upper limit
      END Structure

      Structure CVIEW_SRE          ' 18/-3  currently selected results in WINGRAF
       Dim m_KWH as Integer        '        Main key of current item
       Dim m_KWL as Integer        '        Secondary key of cuurent item (LF,MAT)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=14)> Dim m_VALUES() as Integer '        Selected values of this record type
      END Structure

      Structure CMTXT_0            ' 18/-4:0  Header for membrane manufacturing
       Dim m_ID as Integer         '        identificator = 0
       Dim m_LF as Integer         '        used load case of a deformed structure Lastfallnummer einer ver
       Dim m_BITS as Integer       '        Bitpattern of conditions of evaluation
       Dim m_NFL as Integer        '        Number of manufacturing areas
       Dim m_NQU as Integer        '        total number of QUADS within those areas
       Dim m_NNO as Integer        '        Number of new nodes inserted
      END Structure

      Structure CMTXT_NOD          ' 18/-4:-  Definition of new nodes
       Dim m_NO as Integer         '        Number of new interpolated node
       Dim m_QUAD as Integer       '        Nummer of QUAD-element containing this node
       Dim m_S as Single           '        S-Koordinate im QUAD-Element
       Dim m_T as Single           '        T-Koordinate im QUAD-Element
      END Structure

      Structure CMTXT_ELM          ' 18/-4:+  Definition of manufacturing elements
       Dim m_NO as Integer         '        Number of manufacturing area
       Dim m_QUAD as Integer       '        Number of QUAD-element
       Dim m_N1 as Integer         '        1st node (< 0 if new interpolated node)
       Dim m_N2 as Integer         '        2nd node (< 0 if new interpolated node)
       Dim m_N3 as Integer         '        3rd node (< 0 if new interpolated node)
       Dim m_N4 as Integer         '        4th node (< 0 if new interpolated node)
      END Structure

      Structure CVIEW_MCO          ' 18/-5  Colour of material
       Dim m_NO as Integer         '        Number of material / group
       Dim m_RED as Single         '        RGBA: red color
       Dim m_GREEN as Single       '        RGBA: green color
       Dim m_BLUE as Single        '        RGBA: blue color
       Dim m_ALPHA as Single       '        RGBA: alpha value
      END Structure

      Structure CVIEW_GCO          ' 18/-6  Colour of group
       Dim m_NO as Integer         '        Number of material / group
       Dim m_RED as Single         '        RGBA: red color
       Dim m_GREEN as Single       '        RGBA: green color
       Dim m_BLUE as Single        '        RGBA: blue color
       Dim m_ALPHA as Single       '        RGBA: alpha value
      END Structure

const ANI_SELE_IGRP_ELEM = 0
const ANI_SELE_IGRP_BEAM = 1
const ANI_SELE_IGRP_GRUP = 2
const ANI_SELE_IGRP_SLN = 3
      Structure CANI_SELE          ' 18/-101:1  Dialogbox Animator selection request
       Dim m_SELE as Integer       '        identifier 1 : selection request
       Dim m_IGRP as Integer       '        element-group switch
       Dim m_NSEL as Integer       '        necessary-possible amount of selected elements
       Dim m_ETYP as Integer       '        requested element type - multiple records allowed
       Dim m_FROM as Integer       '        select only elements or groups from FROM to TO
       Dim m_TO as Integer         '        TO
      END Structure

      Structure CANI_CTRL          ' 18/-101:2  Dialogbox Animator drawing controls
       Dim m_SELE as Integer       '        identifier 2 : drawing controls
       Dim m_IGRP as Integer       '        element-group switch as in record 018/-101
       Dim m_NSEL as Integer       '        free
       Dim m_ETYP as Integer       '        element type - see 018/-101:1
       Dim m_FROM as Integer       '        drawing controls for elements/groups from FROM to TO
       Dim m_TO as Integer         '        TO
       Dim m_STYLE as Integer      '        representation style guide number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RGBA() as Single '        colour and transparency factor - only for STYLE=1
      END Structure

      Structure CANI_SRES          ' 18/-103  Selection result from Animator
       Dim m_ID101 as Integer      '        access ID of 18/-101 to check if selection allready done
       Dim m_IGRP as Integer       '        element-group switch as defined in 018/-101
       Dim m_ISEL as Integer       '        termination control
       Dim m_ETYP as Integer       '        element type - see 018/-101:1
       Dim m_FROM as Integer       '        first selected element or group
       Dim m_TO as Integer         '        last "
       Dim m_FREE as Integer       '        not used
       Dim m_X as Single           ' [1001] sectional abscissa
      END Structure

      Structure CLC_SELF           ' 18/LCD  Self weight loading of elements from ASE
       Dim m_KWH as Integer        '        Type of load element
       Dim m_NR as Integer         '        all other values as in KWH/LC
       Dim m_TYP as Integer        '        all other values as in KWH/LC
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_PVAL() as Single '        all other values as in KWH/LC
      END Structure

      Structure CGRP_BIL           ' 19/LC  Bilances of Flow in HYDRA
       Dim m_ID as Integer         '        type of result
       Dim m_NR as Integer         '        group number
       Dim m_QINP as Single        '        Quantity of inflow
       Dim m_QOUT as Single        '        Quantity of outflow
       Dim m_QNEW as Single        '        Quantity generated in domain
       Dim m_ENER as Single        '        Energy term
      END Structure

      Structure CNODE              ' 20/00  Nodes
       Dim m_NR as Integer         '        node-number
       Dim m_INR as Integer        '        internal node-number
       Dim m_KFIX as Integer       '        degree of freedoms
       Dim m_NCOD as Integer       '        additional bit code
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] X-Y-Z-ordinates
      END Structure

      Structure CNODE_GRC          ' 20/11:0  number of Nodegroups
       Dim m_ID as Integer
       Dim m_MAXGRP as Integer     '        maximum number of groups per node
      END Structure

      Structure CNODE_GRP          ' 20/11:+  Nodegroups
       Dim m_N as Integer          '        node-number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IGRP() as Integer '        group-numbers connecting to node
      END Structure

      Structure CNODE_KIC          ' 21/00:0  Info on kinematic constraints
       Dim m_ID as Integer
       Dim m_NLEV as Integer       '        depth of recurent coupling (obsolete)
       Dim m_NKIN as Integer       '        maximum number of coupling equations
       Dim m_NVAR as Integer       '        maximum number of coupling factors
      END Structure

      Structure CNODE_KIN          ' 21/00:+  Standard kinematic constraint
       Dim m_KTL as Integer        '        type + 100 * depth + 10000*group-number
       Dim m_NR as Integer         '        node-number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_KR() as Integer '        reference nodes
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() as Single '        direction of coupling X/Y/Z-axis
       Dim m_DD as Single          '        factor of interpolation for INTP/INTF/INTS
       Dim m_FF as Single          '        factor of multiplication (not used)
      END Structure

      Structure CNODE_KIG_ID       '        node+degree-number of dependent (0)
       Dim m_NR as Integer
       Dim m_ND as Integer
      END Structure

      Structure CNODE_KIG          ' 21/00:*99  general constraints (equation list)
       Dim m_KTL as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_ID() as CNODE_KIG_ID '        node+degree-number of dependent (0)
      END Structure

      Structure CNODE_KIF          ' 21/00:*99  general constraints (factor list)
       Dim m_KTL as Integer        '        99 + 100 * depth
       Dim m_ID as Integer         '        identifier 0
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_FR() as Single '        factors of constrained equation
      END Structure

      Structure CNODE_KIH          ' 21/09  Hydraulic couplings
       Dim m_NG as Integer         '        group-number
       Dim m_NR as Integer         '        node-number
       Dim m_KR as Integer         '        reference node
      END Structure

      Structure CNODE_KFC          ' 22/LC:0  Max. Constraining Forces
       Dim m_ID as Integer         '        identifier 0
       Dim m_PX as Single          ' [1190] force component X
       Dim m_PY as Single          ' [1190] force component Y
       Dim m_PZ as Single          ' [1190] force component Z
       Dim m_MX as Single          ' [1194] moment component X
       Dim m_MY as Single          ' [1194] moment component Y
       Dim m_MZ as Single          ' [1194] moment component Z
       Dim m_MB as Single          ' [1194] warping moment
      END Structure

      Structure CNODE_KFO          ' 22/LC:+  Constraining forces
       Dim m_NR as Integer         '        node-number
       Dim m_PX as Single          ' [1190] force component X
       Dim m_PY as Single          ' [1190] force component Y
       Dim m_PZ as Single          ' [1190] force component Z
       Dim m_MX as Single          ' [1194] moment component X
       Dim m_MY as Single          ' [1194] moment component Y
       Dim m_MZ as Single          ' [1194] moment component Z
       Dim m_MB as Single          ' [1194] warping moment
      END Structure

      Structure CNODE_L            ' 23/LC:+  Nodal_loads
       Dim m_NR as Integer         '        node-number
       Dim m_TYP as Integer        '        type of load
       Dim m_PX as Single          ' [1190] single force X-component
       Dim m_PY as Single          ' [1190] single force Y-component
       Dim m_PZ as Single          ' [1190] single force Z-component
       Dim m_MX as Single          ' [1194] single moment X-component
       Dim m_MY as Single          ' [1194] single moment Y-component
       Dim m_MZ as Single          ' [1194] single moment Z-component
       Dim m_MB as Single          ' [1195] warping moment
      END Structure

      Structure CNODE_LW           ' 23/LC:+  prescribed support displacements
       Dim m_NR as Integer         '        node-number
       Dim m_TYP as Integer        '        type of load
       Dim m_WX as Single          ' [1003] Displacement X
       Dim m_WY as Single          ' [1003] Displacement Y
       Dim m_WZ as Single          ' [1003] Displacement Z
       Dim m_RX as Single          ' [1004] Rotation X-X
       Dim m_RY as Single          ' [1004] Rotation Y-Y
       Dim m_RZ as Single          ' [1004] Rotation Z-Z
      END Structure

      Structure CNODE_ACC          ' 23/LC:*  Base acceleration
       Dim m_NR as Integer         '        node number / influence load case
       Dim m_TYP as Integer        '        type of load (=10)
       Dim m_AX as Single          ' [1202] transversal acceleration X
       Dim m_AY as Single          ' [1202] transversal acceleration Y
       Dim m_AZ as Single          ' [1202] transversal acceleration Z
       Dim m_AXX as Single         ' [1207] rotational acceleration X-X
       Dim m_AYY as Single         ' [1207] rotational acceleration Y-Y
       Dim m_AZZ as Single         ' [1207] rotational acceleration Z-Z
       Dim m_EX as Single          ' [1001] reference point for rotational acceleration
       Dim m_EY as Single          ' [1001] reference point for rotational acceleration
       Dim m_EZ as Single          ' [1001] reference point for rotational acceleration
       Dim m_EXREF as Single       '        V25: if a value is present (length criteria)
      END Structure

      Structure CNODE_LA           ' 23/LC:+  prescribed nodal accelerations
       Dim m_NR as Integer         '        node-number
       Dim m_TYP as Integer        '        type of load
       Dim m_AX as Single          ' [1003] acceleration X
       Dim m_AY as Single          ' [1003] acceleration Y
       Dim m_AZ as Single          ' [1003] acceleration Z
       Dim m_ARX as Single         ' [1004] Rotation X-X
       Dim m_ARY as Single         ' [1004] Rotation Y-Y
       Dim m_ARZ as Single         ' [1004] Rotation Z-Z
      END Structure

      Structure CNODE_ROT          ' 23/LC:+  Rotation of Body
       Dim m_NR as Integer         '        influence reference
       Dim m_TYP as Integer        '        type of load (=20)
       Dim m_AXX as Single         ' [1207] rotational acceleration X-X  (= vxx**2)
       Dim m_AYY as Single         ' [1207] rotational acceleration Y-Y  (= vyy**2)
       Dim m_AZZ as Single         ' [1207] rotational acceleration Z-Z  (= vzz**2)
       Dim m_EX as Single          ' [1001] reference point for rotational acceleration
       Dim m_EY as Single          ' [1001] reference point for rotational acceleration
       Dim m_EZ as Single          ' [1001] reference point for rotational acceleration
      END Structure

      Structure CN_DISPC           ' 24/LC:0  Max. Displacements and support forces
       Dim m_ID as Integer
       Dim m_UX as Single          ' [1003] displacement X
       Dim m_UY as Single          ' [1003] displacement Y
       Dim m_UZ as Single          ' [1003] displacement Z
       Dim m_URX as Single         ' [1004] rotation X
       Dim m_URY as Single         ' [1004] rotation Y
       Dim m_URZ as Single         ' [1004] rotation Z
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support X
       Dim m_PY as Single          ' [1151] nodal support Y
       Dim m_PZ as Single          ' [1151] nodal support Z
       Dim m_MX as Single          ' [1152] support moment X
       Dim m_MY as Single          ' [1152] support moment Y
       Dim m_MZ as Single          ' [1152] support moment Z
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_DISPIC          ' 26/LC:0  Max. Displacement and forces increments
       Dim m_ID as Integer
       Dim m_UX as Single          ' [1003] displacement X
       Dim m_UY as Single          ' [1003] displacement Y
       Dim m_UZ as Single          ' [1003] displacement Z
       Dim m_URX as Single         ' [1004] rotation X
       Dim m_URY as Single         ' [1004] rotation Y
       Dim m_URZ as Single         ' [1004] rotation Z
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support X
       Dim m_PY as Single          ' [1151] nodal support Y
       Dim m_PZ as Single          ' [1151] nodal support Z
       Dim m_MX as Single          ' [1152] support moment X
       Dim m_MY as Single          ' [1152] support moment Y
       Dim m_MZ as Single          ' [1152] support moment Z
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_DISPTC          ' 27/LC:0  Max. Cooordinate offsets
       Dim m_ID as Integer
       Dim m_UX as Single          ' [1003] displacement X
       Dim m_UY as Single          ' [1003] displacement Y
       Dim m_UZ as Single          ' [1003] displacement Z
       Dim m_URX as Single         ' [1004] rotation X
       Dim m_URY as Single         ' [1004] rotation Y
       Dim m_URZ as Single         ' [1004] rotation Z
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support X
       Dim m_PY as Single          ' [1151] nodal support Y
       Dim m_PZ as Single          ' [1151] nodal support Z
       Dim m_MX as Single          ' [1152] support moment X
       Dim m_MY as Single          ' [1152] support moment Y
       Dim m_MZ as Single          ' [1152] support moment Z
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_DISP            ' 24/LC:+  Displacements and support forces of nodes
       Dim m_NR as Integer         '        node-number
       Dim m_UX as Single          ' [1003] displacement
       Dim m_UY as Single          ' [1003] displacement
       Dim m_UZ as Single          ' [1003] displacement
       Dim m_URX as Single         ' [1004] rotation
       Dim m_URY as Single         ' [1004] rotation
       Dim m_URZ as Single         ' [1004] rotation
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support
       Dim m_PY as Single          ' [1151] nodal support
       Dim m_PZ as Single          ' [1151] nodal support
       Dim m_MX as Single          ' [1152] support moment
       Dim m_MY as Single          ' [1152] support moment
       Dim m_MZ as Single          ' [1152] support moment
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_DISPI           ' 26/LC:+  Displacement increments and residual forces
       Dim m_NR as Integer         '        node-number
       Dim m_UX as Single          ' [1003] displacement
       Dim m_UY as Single          ' [1003] displacement
       Dim m_UZ as Single          ' [1003] displacement
       Dim m_URX as Single         ' [1004] rotation
       Dim m_URY as Single         ' [1004] rotation
       Dim m_URZ as Single         ' [1004] rotation
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support
       Dim m_PY as Single          ' [1151] nodal support
       Dim m_PZ as Single          ' [1151] nodal support
       Dim m_MX as Single          ' [1152] support moment
       Dim m_MY as Single          ' [1152] support moment
       Dim m_MZ as Single          ' [1152] support moment
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_DISPT           ' 27/LC:+  Cooordinate offsets
       Dim m_NR as Integer         '        node-number
       Dim m_UX as Single          ' [1003] displacement
       Dim m_UY as Single          ' [1003] displacement
       Dim m_UZ as Single          ' [1003] displacement
       Dim m_URX as Single         ' [1004] rotation
       Dim m_URY as Single         ' [1004] rotation
       Dim m_URZ as Single         ' [1004] rotation
       Dim m_URB as Single         ' [1005] twisting
       Dim m_PX as Single          ' [1151] nodal support
       Dim m_PY as Single          ' [1151] nodal support
       Dim m_PZ as Single          ' [1151] nodal support
       Dim m_MX as Single          ' [1152] support moment
       Dim m_MY as Single          ' [1152] support moment
       Dim m_MZ as Single          ' [1152] support moment
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CN_VELOC           ' 25/LC:0  Max. velocities and accelerations of nodes
       Dim m_ID as Integer
       Dim m_VX as Single          ' [1201] velocity X
       Dim m_VY as Single          ' [1201] velocity Y
       Dim m_VZ as Single          ' [1201] velocity Z
       Dim m_VRX as Single         ' [1206] angular veloc. XX
       Dim m_VRY as Single         ' [1206] angular veloc. YY
       Dim m_VRZ as Single         ' [1206] angular veloc. ZZ
       Dim m_VBB as Single         ' [1208] twisting velocity
       Dim m_AX as Single          ' [1202] acceleration X
       Dim m_AY as Single          ' [1202] acceleration Y
       Dim m_AZ as Single          ' [1202] acceleration Z
       Dim m_ARX as Single         ' [1207] ang. acceler. XX
       Dim m_ARY as Single         ' [1207] ang. acceler. YY
       Dim m_ARZ as Single         ' [1207] ang. acceler. ZZ
       Dim m_ABB as Single         ' [1209] twisting acceler
      END Structure

      Structure CN_VELO            ' 25/LC:+  velocitys and acceleration of nodes
       Dim m_NR as Integer         '        node-number
       Dim m_VX as Single          ' [1201] velocity X
       Dim m_VY as Single          ' [1201] velocity Y
       Dim m_VZ as Single          ' [1201] velocity Z
       Dim m_VRX as Single         ' [1206] angular veloc. X-X
       Dim m_VRY as Single         ' [1206] angular veloc. Y-Y
       Dim m_VRZ as Single         ' [1206] angular veloc. Z-Z
       Dim m_VBB as Single         ' [1208] twisting velocity
       Dim m_AX as Single          ' [1202] acceleration X
       Dim m_AY as Single          ' [1202] acceleration Y
       Dim m_AZ as Single          ' [1202] acceleration Z
       Dim m_ARX as Single         ' [1207] ang. acceler. X-X
       Dim m_ARY as Single         ' [1207] ang. acceler. Y-Y
       Dim m_ARZ as Single         ' [1207] ang. acceler. Z-Z
       Dim m_ABB as Single         ' [1209] twisting acceler
      END Structure

      Structure CGLN_MATC          ' 31/0  Heritage of Structural lines
       Dim m_NR as Integer         '        original structural line number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IDS() as Integer '        sequence of sub-lines
      END Structure

      Structure CGAR_MATC          ' 32/0  Heritage of Structural Areas
       Dim m_NR as Integer         '        original structural area number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IDS() as Integer '        list of sub-areas
      END Structure

      Structure CSPT               ' 39/NR:0  Structural points
       Dim m_ID as Integer         '        identifier 0
       Dim m_IDS as Integer        '        optional identifier of point
       Dim m_REF as Integer        '        reserved reference
       Dim m_NOG as Integer        '        reserved number of group
       Dim m_NOM as Integer        '        reserved number of material
       Dim m_NOR as Integer        '        reserved number of reinforc.
       Dim m_IBT as Integer        '        Bitpattern of element properties
       Dim m_IBC as Integer        '        Boundary condition
       Dim m_I_8 as Integer        '        reserved
       Dim m_I_9 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Coordinates of that point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       Dim m_BX as Single          ' [1001] Dimension in local x
       Dim m_BY as Single          ' [1001] Dimension in local y
       Dim m_THICK as Single       ' [1010] Plate thickness at that point
       Dim m_HMESH as Single       ' [1001] Mesh density at point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_RES() as Single '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Point
      END Structure

      Structure CSLN               ' 39/NR:100  Structural lines
       Dim m_ID as Integer         '        identifier 100
       Dim m_IDS as Integer        '        optional identifier of structural line
       Dim m_REF as Integer        '        reference identifier to a given GAX [chr] or sln [int]
       Dim m_SREF as Integer       '        secondary axis enum for GAX references
       Dim m_NA as Integer         '        optional identifier of line start point
       Dim m_NB as Integer         '        optional identifier of line end point
       Dim m_IBT as Integer        '        Bitpattern of element properties
       Dim m_IBC as Integer        '        primary boundary condition
       Dim m_ID8 as Integer        '        reserved
       Dim m_ID9 as Integer        '        reserved
       Dim m_HMESH as Single       ' [1001] >0.0 = mesh density along line
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TUP() as Single '        Vector to define downward direction
       Dim m_TROT as Single        '        Fractional rotation about local x-axis  (obsoleted => :101/:102
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis      (obsoleted => :101/:102
       Dim m_PROG as Single        '        progression factor (>0 monoton, <0 symmetric)
       Dim m_R10 as Single         '        reserved
       Dim m_R11 as Single         '        reserved
       Dim m_R12 as Single         '        reserved
       Dim m_R13 as Single         '        reserved
       Dim m_R14 as Single         '        reserved
       Dim m_R15 as Single         '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Line
      END Structure

const SLN_BEAM_NONE = -1
const SLN_BEAM_CENTRIC = 0
const SLN_BEAM_REFERENCE = 1
const SLN_BEAM_TRUSS = 2
const SLN_BEAM_CABLE = 3
const SLN_BEAM_CCOLUMN = 4
const SLN_BEAM_COLUMN = 5
const SLN_BEAM_SECTION = 7
      Structure CSLN_BEAM          ' 39/NR:101  Properties of beams
       Dim m_ID as Integer         '        ident 101
       Dim m_TYP as Integer        '        Element type (see 009/NR:90:4 IBTYP)
       Dim m_NOG as Integer        '        group number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NQ() as Integer '        number cross section start/end
       Dim m_NP as Integer         '        number bedding props
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IBC() as Integer '        Hinge properties A/E/XA/XE (start/end/internal start/end)
       Dim m_DIV as Integer        '        type of element subdivision
       Dim m_KR as Single          '        identifier of local coordinate system orientation
       Dim m_R12 as Single
       Dim m_R13 as Single
       Dim m_R14 as Single
       Dim m_R15 as Single
       Dim m_EXA as Single         ' [1001] eccentricity at start
       Dim m_EYA as Single         ' [1001] eccentricity at start
       Dim m_EZA as Single         ' [1001] eccentricity at start
       Dim m_EXE as Single         ' [1001] eccentricity at end
       Dim m_EYE as Single         ' [1001] eccentricity at end
       Dim m_EZE as Single         ' [1001] eccentricity at end
       Dim m_TROT as Single        '        additional rotation about local x-axis, given as fraction of 36
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        vector defining the orientation of the local z-axis of the loca
      END Structure

      Structure CGLN_BPRO          ' 31/NR:101  Properties of beams
       Dim m_ID as Integer         '        ident 101
       Dim m_TYP as Integer        '        Element type (see 009/NR:90:4 IBTYP)
       Dim m_NOG as Integer        '        group number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NQ() as Integer '        number cross section start/end
       Dim m_NP as Integer         '        number bedding props
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IBC() as Integer '        Hinge properties A/E/XA/XE (start/end/internal start/end)
       Dim m_DIV as Integer        '        type of element subdivision
       Dim m_KR as Single          '        identifier of local coordinate system orientation
       Dim m_R12 as Single
       Dim m_R13 as Single
       Dim m_R14 as Single
       Dim m_R15 as Single
       Dim m_EXA as Single         ' [1001] eccentricity at start
       Dim m_EYA as Single         ' [1001] eccentricity at start
       Dim m_EZA as Single         ' [1001] eccentricity at start
       Dim m_EXE as Single         ' [1001] eccentricity at end
       Dim m_EYE as Single         ' [1001] eccentricity at end
       Dim m_EZE as Single         ' [1001] eccentricity at end
       Dim m_TROT as Single        '        additional rotation about local x-axis, given as fraction of 36
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        vector defining the orientation of the local z-axis of the loca
      END Structure

      Structure CSLN_SUPP          ' 39/NR:102  Support of Structural lines
       Dim m_ID as Integer         '        identifier 102
       Dim m_IDS as Integer        '        type of reference
       Dim m_REF as Integer        '        reference identifier
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_IBC as Integer        '        Boundary condition / kinematic constraints
       Dim m_KR as Integer         '        local orientation
       Dim m_W as Single           ' [1001] width of support
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
       Dim m_CM as Single          ' [1099] torsional bedding
       Dim m_DRX as Single         '        explicit X direction of support
       Dim m_DRY as Single         '        explicit Y direction of support
       Dim m_DRZ as Single         '        explicit Z direction of support
       Dim m_D as Single           ' [1001] distance to coupled line (IDS={5,6,7})
       Dim m_R8 as Single
       Dim m_R9 as Single
       Dim m_FKA as Single         '        factor bedding at start
       Dim m_FKE as Single         '        factor bedding at end
       Dim m_TROT as Single        '        Fractional rotation about local x-axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis
      END Structure

      Structure CGLN_SUPP          ' 31/NR:102  Support of Structural lines
       Dim m_ID as Integer         '        identifier 102
       Dim m_IDS as Integer        '        type of reference
       Dim m_REF as Integer        '        reference identifier
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_IBC as Integer        '        Boundary condition / kinematic constraints
       Dim m_KR as Integer         '        local orientation
       Dim m_W as Single           ' [1001] width of support
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
       Dim m_CM as Single          ' [1099] torsional bedding
       Dim m_DRX as Single         '        explicit X direction of support
       Dim m_DRY as Single         '        explicit Y direction of support
       Dim m_DRZ as Single         '        explicit Z direction of support
       Dim m_D as Single           ' [1001] distance to coupled line (IDS={5,6,7})
       Dim m_R8 as Single
       Dim m_R9 as Single
       Dim m_FKA as Single         '        factor bedding at start
       Dim m_FKE as Single         '        factor bedding at end
       Dim m_TROT as Single        '        Fractional rotation about local x-axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis
      END Structure

      Structure CSLN_EXYZ          ' 39/NR:120  Explicit nodes on lines
       Dim m_ID as Integer         '        identifier = 120
       Dim m_ID1 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_XYZ() as Single ' [1001] XYZ coordinates
      END Structure

      Structure CGLN_EXYZ          ' 31/NR:120  Explicit nodes on lines
       Dim m_ID as Integer         '        identifier = 120
       Dim m_ID1 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_XYZ() as Single ' [1001] XYZ coordinates
      END Structure

      Structure CSLN_SCT           ' 39/NR:130  Beams sections
       Dim m_ID as Integer         '        identifier = 130
       Dim m_REFT as Integer       '        Type of reference
       Dim m_ITYP as Integer       '        Bitcodes according 100/NR:0 ITYP
       Dim m_I1 as Integer         '        reserved
       Dim m_S as Single           ' [1001] location on geometry
      END Structure

      Structure CGLN_SCT           ' 31/NR:130  Beams sections
       Dim m_ID as Integer         '        identifier = 130
       Dim m_REFT as Integer       '        Type of reference
       Dim m_ITYP as Integer       '        Bitcodes according 100/NR:0 ITYP
       Dim m_I1 as Integer         '        reserved
       Dim m_S as Single           ' [1001] location on geometry
      END Structure

      Structure CSAR               ' 39/NR:200  Structural area
       Dim m_ID as Integer         '        identification of general data = 200
       Dim m_IDS as Integer        '        identifier of structural area (0=auto)
       Dim m_REF as Integer        '        reference to a given GAR [chr] or SAR [int]
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_NOR as Integer        '        number of reinforc.
       Dim m_ITP as Integer        '        Bitpattern for element generation QUAD
       Dim m_IBC as Integer        '        Boundary condition
       Dim m_KR as Integer         '        local orientation QUADs
       Dim m_IATR as Integer       '        Bitpattern for attribut areas (see SBOX_PROP)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TD() as Single ' [1010] Constant thickness
       Dim m_CB as Single          '        bedding factor
       Dim m_CQ as Single          '        tangential bedding factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TUP() as Single '        Vector to define upward direction
       Dim m_TROT as Single        '        Fractional rotation about local z-axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_H() as Single ' [1001] mesh density parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of surface
      END Structure

      Structure CSAR_INF           ' 39/NR:210  GeometricAreaInfo
       Dim m_ID0 as Integer        '        identifier 210
       Dim m_NG as Integer         '        Type of surface representation
       Dim m_GID1 as Integer       '        Axis identifier of first reference axis
       Dim m_GID2 as Integer       '        Axis identifier of second reference axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() as Single '        Transformation
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() as Single '        umin,umax,vmin,vmax of the parameter plane
      END Structure

      Structure CSAR_PTS           ' 39/NR:211  AreaPointonSurface
       Dim m_ID as Integer         '        Identifier 211
       Dim m_IT as Integer         '        Type of point (see 5/ID:11 for more)
       Dim m_M as Integer          '        Rasterlocation of mesh (0 < m < mgri )
       Dim m_N as Integer          '        Rasterlocation of mesh (0 < n < ngri )
       Dim m_W as Single           '        the weight of NURBS control point
       Dim m_X as Single           ' [1001] X-ordinate
       Dim m_Y as Single           ' [1001] Y-ordinate
       Dim m_Z as Single           ' [1001] Z-ordinate
       Dim m_T as Single           ' [1010] Thickness
      END Structure

      Structure CSAR_CPI           ' 39/NR:212  COONsPatchInfo
       Dim m_ID as Integer         '        Id = 212
       Dim m_IT as Integer         '        Type of blending
       Dim m_IU0 as Integer        '        No of geometry line for u=umin (left)
       Dim m_IU1 as Integer        '        No of geometry line for u=umax (right)
       Dim m_IV0 as Integer        '        No of geometry line for v=vmin (lower)
       Dim m_IV1 as Integer        '        No of geometry line for v=vmax (upper)
      END Structure

      Structure CSAR_EXYZ          ' 39/NR:220  Explicit QUAD nodes on area
       Dim m_ID as Integer         '        identifier = 220
       Dim m_ID1 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() as Single ' [1001] XYZ coordinates
      END Structure

      Structure CGAR_EXYZ          ' 32/NR:220  Explicit QUAD nodes on area
       Dim m_ID as Integer         '        identifier = 220
       Dim m_ID1 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() as Single ' [1001] XYZ coordinates
      END Structure

      Structure CSAR_SUPP          ' 39/NR:221  Support and coupling of structural areas
       Dim m_ID as Integer         '        identifier 221
       Dim m_IDS as Integer        '        type of reference
       Dim m_REF as Integer        '        reference identifier
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_IBC as Integer        '        Boundary condition / kinematic constraints
       Dim m_I6 as Integer         '        reserved
       Dim m_RCTL as Integer       '        properties of area-area reference
       Dim m_RPTR as Integer       '        reference point on boundary of referenced area
       Dim m_RPT0 as Integer       '        reference point on boundary of given area
       Dim m_I10 as Integer        '        reserved
       Dim m_D as Single           ' [1001] distance of interface layer
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
      END Structure

      Structure CGAR_SUPP          ' 32/NR:221  Support and coupling of structural areas
       Dim m_ID as Integer         '        identifier 221
       Dim m_IDS as Integer        '        type of reference
       Dim m_REF as Integer        '        reference identifier
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_IBC as Integer        '        Boundary condition / kinematic constraints
       Dim m_I6 as Integer         '        reserved
       Dim m_RCTL as Integer       '        properties of area-area reference
       Dim m_RPTR as Integer       '        reference point on boundary of referenced area
       Dim m_RPT0 as Integer       '        reference point on boundary of given area
       Dim m_I10 as Integer        '        reserved
       Dim m_D as Single           ' [1001] distance of interface layer
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
      END Structure

      Structure CSVO               ' 39/NR:300  StructuralVolume
       Dim m_ID as Integer         '        identification = 300
       Dim m_IDS as Integer        '        identifier of structural area (0=auto)
       Dim m_REF as Integer        '        reference to a given GVO (reserved)
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_NOR as Integer        '        number of reinforc.
       Dim m_NOT as Integer        '        number of elementtype
       Dim m_IBC as Integer        '        Boundary condition
       Dim m_ID8 as Integer        '        reserved
       Dim m_ID9 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Volume
      END Structure

      Structure CSMB_ATTR          ' 39/NR:997  Attributes of structural member
       Dim m_ID as Integer         '        identifier 997
       Dim m_I1 as Integer         '        reserved
       Dim m_I2 as Integer         '        reserved
       Dim m_GRXA as Integer       '        identifier of 1st grid axis x-x
       Dim m_GRYA as Integer       '        identifier of 2nd grid axis y-y
       Dim m_ELVB as Integer       '        identifier of elevation at bottom
       Dim m_ELVT as Integer       '        identifier of elevation at top
       Dim m_DPOS as Integer       '        Identifier of design group membership
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_DTXT() as Integer '        Designation of design group membership
      END Structure

      Structure CSPT_ATTR          ' 30/NR:997  Attributes of structural member
       Dim m_ID as Integer         '        identifier 997
       Dim m_I1 as Integer         '        reserved
       Dim m_I2 as Integer         '        reserved
       Dim m_GRXA as Integer       '        identifier of 1st grid axis x-x
       Dim m_GRYA as Integer       '        identifier of 2nd grid axis y-y
       Dim m_ELVB as Integer       '        identifier of elevation at bottom
       Dim m_ELVT as Integer       '        identifier of elevation at top
       Dim m_DPOS as Integer       '        Identifier of design group membership
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_DTXT() as Integer '        Designation of design group membership
      END Structure

      Structure CSLN_ATTR          ' 31/NR:997  Attributes of structural member
       Dim m_ID as Integer         '        identifier 997
       Dim m_I1 as Integer         '        reserved
       Dim m_I2 as Integer         '        reserved
       Dim m_GRXA as Integer       '        identifier of 1st grid axis x-x
       Dim m_GRYA as Integer       '        identifier of 2nd grid axis y-y
       Dim m_ELVB as Integer       '        identifier of elevation at bottom
       Dim m_ELVT as Integer       '        identifier of elevation at top
       Dim m_DPOS as Integer       '        Identifier of design group membership
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_DTXT() as Integer '        Designation of design group membership
      END Structure

      Structure CSAR_ATTR          ' 32/NR:997  Attributes of structural member
       Dim m_ID as Integer         '        identifier 997
       Dim m_I1 as Integer         '        reserved
       Dim m_I2 as Integer         '        reserved
       Dim m_GRXA as Integer       '        identifier of 1st grid axis x-x
       Dim m_GRYA as Integer       '        identifier of 2nd grid axis y-y
       Dim m_ELVB as Integer       '        identifier of elevation at bottom
       Dim m_ELVT as Integer       '        identifier of elevation at top
       Dim m_DPOS as Integer       '        Identifier of design group membership
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_DTXT() as Integer '        Designation of design group membership
      END Structure

      Structure CSMB_GUID          ' 39/NR:999  Unique identifier of structural member
       Dim m_ID as Integer         '        identifier 999
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of preceeding element
      END Structure

      Structure CSPT_GUID          ' 30/NR:999  Unique identifier of structural member
       Dim m_ID as Integer         '        identifier 999
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of preceeding element
      END Structure

      Structure CSLN_GUID          ' 31/NR:999  Unique identifier of structural member
       Dim m_ID as Integer         '        identifier 999
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of preceeding element
      END Structure

      Structure CSAR_GUID          ' 32/NR:999  Unique identifier of structural member
       Dim m_ID as Integer         '        identifier 999
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() as Integer '        256 Bit GUId Identifier of preceeding element
      END Structure

const GPT_IBC_SUP = 8192
const GPT_IBC_REF = 32768
      Structure CGPT               ' 30/NR:0  Structural points
       Dim m_ID as Integer         '        identifier 0 (always the first record)
       Dim m_IBC as Integer        '        Boundary condition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] Ordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       Dim m_BX as Single          ' [1001] Dimension in x
       Dim m_BY as Single          ' [1001] Dimension in y
       Dim m_THICK as Single       ' [1010] Plate thickness
       Dim m_HMESH as Single       ' [1001] Mesh density at point
       Dim m_R17 as Single         '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Point
      END Structure

      Structure CGPT_COH           ' 30/NR:1  Dimension of column head
       Dim m_ID as Integer         '        identifier 1/2/3
       Dim m_NS as Integer         '        Number of a cross section 9/NR for details
       Dim m_X as Single           ' [1001] Width in local x
       Dim m_Y as Single           ' [1001] Width in local y
       Dim m_A as Single           ' [1002] Equivalent Area
       Dim m_T as Single           ' [1010] Plate thickness
      END Structure

      Structure CGPT_HAU           ' 30/NR:2  Dimension of voute
       Dim m_ID as Integer         '        identifier 1/2/3
       Dim m_NS as Integer         '        Number of a cross section 9/NR for details
       Dim m_X as Single           ' [1001] Width in local x
       Dim m_Y as Single           ' [1001] Width in local y
       Dim m_A as Single           ' [1002] Equivalent Area
       Dim m_T as Single           ' [1010] Plate thickness
      END Structure

      Structure CGPT_PUN           ' 30/NR:3  Dimension of punching perimeter
       Dim m_ID as Integer         '        identifier 1/2/3
       Dim m_NS as Integer         '        Number of a cross section 9/NR for details
       Dim m_X as Single           ' [1001] Width in local x
       Dim m_Y as Single           ' [1001] Width in local y
       Dim m_A as Single           ' [1002] Equivalent Area
       Dim m_T as Single           ' [1010] Plate thickness
      END Structure

      Structure CGPT_COL           ' 30/NR:4  Connecting columns
       Dim m_ID as Integer         '        identifier 4
       Dim m_NS as Integer         '        Number of a cross section 9/NR for column
       Dim m_X as Single           ' [1001] Width in local x
       Dim m_Y as Single           ' [1001] Width in local y
       Dim m_A as Single           ' [1002] Equivalent Area
       Dim m_L as Single           ' [1001] Column length
       Dim m_FAK as Single         '        Rigidity factor
      END Structure

      Structure CGPT_FOO           ' 30/NR:5  Footing instance definition
       Dim m_ID as Integer         '        identifier 5
       Dim m_POS as Integer        '        referenced building position
       Dim m_TYPE as Integer       '        Type of foundation
       Dim m_IGP as Integer        '        Bitpattern Foundation Properties
       Dim m_IDR as Integer        '        Bitpattern Design Results
       Dim m_IR1 as Integer        '        reserved
       Dim m_MNO as Integer        '        Id of concrete material
       Dim m_MRF as Integer        '        Id of reinforcement material
       Dim m_NRSP as Integer       '        Id of soil profile (002/NR)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        Orientation of local coordinate system
       Dim m_BX as Single          ' [1001] Width in local x
       Dim m_BY as Single          ' [1001] Width in local y
       Dim m_HI as Single          ' [1001] inner Thickness
       Dim m_HA as Single          ' [1001] outer Thickness
       Dim m_EX as Single          ' [1001] Eccentricity of column in local x-direction
       Dim m_EY as Single          ' [1001] Eccentricity of column in local y-direction
       Dim m_EZ as Single          ' [1001] Eccentricity of endpoint of column(=structural point) in local 
       Dim m_CLX as Single         ' [1011] Assumed dimension of column in local x-direction
       Dim m_CLY as Single         ' [1011] Assumed dimension of column in local y-direction
       Dim m_SXT as Single         ' [1024] Boundary distance of x-aligned reinforcement on top face
       Dim m_SYT as Single         ' [1024] Boundary distance of y-aligned reinforcement on top face
       Dim m_SXB as Single         ' [1024] Boundary distance of x-aligned reinforcement on bottom face
       Dim m_SYB as Single         ' [1024] Boundary distance of y-aligned reinforcement on bottom face
       Dim m_COVT as Single        ' [1024] Concrete cover (nominal) on top face
       Dim m_COVB as Single        ' [1024] Concrete cover (nominal) on bottom face
       Dim m_COVL as Single        ' [1024] Concrete cover (nominal) on lateral faces
       Dim m_RES1 as Single        '        Reserved
       Dim m_RES2 as Single        '        Reserved
       Dim m_RES3 as Single        '        Reserved
       Dim m_RES4 as Single        '        Reserved
       Dim m_SLHO as Single        ' [1001] obsolete
       Dim m_SLHI as Single        ' [1001] obsolete
       Dim m_SLWX as Single        ' [1001] obsolete
       Dim m_SLWY as Single        ' [1001] obsolete
       Dim m_SLGU as Single        ' [1001] obsolete
       Dim m_SLGL as Single        ' [1001] obsolete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_DATA() as Single '        Reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITL() as Integer '        Designation of Foundation
      END Structure

      Structure CGPT_FRR           ' 30/NR:1005  Footing required reinforcement
       Dim m_ID as Integer         '        identifier 1005
       Dim m_TYPE as Integer       '        Type of reinforcement
       Dim m_N_AS as Integer       '        number of values stored in array AS
       Dim m_IR1 as Integer        '        reserved
       Dim m_IR2 as Integer        '        reserved
       Dim m_XOFF as Single        ' [1001] offset of distribution in x-direction
       Dim m_YOFF as Single        ' [1001] offset of distribution in y-direction
       Dim m_RES1 as Single        '        reserved
       Dim m_RES2 as Single        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_AS() as Single ' [1021] reinforcement values
      END Structure

      Structure CGPT_SLP           ' 30/NR:1006  Sleeve foundation properties
       Dim m_ID as Integer         '        identifier 1006
       Dim m_IR1 as Integer        '        reserved
       Dim m_IR2 as Integer        '        reserved
       Dim m_IR3 as Integer        '        reserved
       Dim m_HSWO as Single        ' [1001] Outer height of sleeve wall (measured from z=0 of local coordin
       Dim m_HSWI as Single        ' [1001] Inner height of sleeve wall (measured from upper face of sleeve
       Dim m_WXWU as Single        ' [1001] Upper width of sleeve wall in x-direction
       Dim m_WYWU as Single        ' [1001] Upper width of sleeve wall in y-direction
       Dim m_WXWL as Single        ' [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
       Dim m_WYWL as Single        ' [1001] Lower width of sleeve wall in y-direction
       Dim m_WXGU as Single        ' [1001] Upper width of gap between wall and column in x-direction
       Dim m_WYGU as Single        ' [1001] Upper width of gap between wall and column in y-direction
       Dim m_WXGL as Single        ' [1001] Lower width of gap between wall and column in x-direction
       Dim m_WYGL as Single        ' [1001] Lower width of gap between wall and column in y-direction
       Dim m_CLX as Single         ' [1011] Assumed dimension of column in local x-direction (deprecated)
       Dim m_CLY as Single         ' [1011] Assumed dimension of column in local y-direction (deprecated)
      END Structure

      Structure CGPT_HPI           ' 30/NR:6  Halfspace pile
       Dim m_ID as Integer         '        identifier 6
       Dim m_NQ as Integer         '        number cross section   =0 if diameter from 030/NR:0
       Dim m_L as Single           ' [1001] pile length in GDIR direction
       Dim m_MANT as Single        '        percentage of skin friction for linear analysis
       Dim m_ZMAN as Single        '        percentage of inactive skin length
       Dim m_PMAN as Single        ' [1151] maximum load skin friction (nonlinear analysis)
       Dim m_PMAF as Single        ' [1151] maximum load pile foot
      END Structure

      Structure CGPT_CON_M         '        connected members
       Dim m_NELT as Integer
       Dim m_NREL as Integer
       Dim m_NODE as Integer
       Dim m_NARB as Integer
       Dim m_X as Single           ' [1001] 
      END Structure

      Structure CGPT_CON           ' 30/NR:8  Steelconnection reference
       Dim m_ID as Integer         '        identifier 8
       Dim m_CONID as Integer      '        connection identifier
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_M() as CGPT_CON_M '        connected members
      END Structure

      Structure CGPT_SPR           ' 30/NR:10  Elastic Spring support
       Dim m_ID as Integer         '        identifier 10
       Dim m_IRI as Integer        '        direction
       Dim m_NR as Integer         '        element number
       Dim m_NG as Integer         '        group number
       Dim m_IPC as Integer        '        connecting to node
       Dim m_NWL as Integer        '        Reference to work-law / material no
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() as Single '        explicit direction (dx,dy,dz)
       Dim m_AREF as Single        '        reference / influence area (see also  184 170/0 )
       Dim m_CP as Single          ' [1095] spring stiffness z
       Dim m_CQ as Single          ' [1095] transverse stiff.
       Dim m_CM as Single          ' [1098] torsional stiff.
       Dim m_PRE as Single         '        prestress for cp
       Dim m_GAP as Single         '        slip of spring
       Dim m_RISS as Single        '        max tension force
       Dim m_FLIE as Single        '        yielding load
       Dim m_MUE as Single         '        friction cross
       Dim m_COH as Single         '        cohesion cross
       Dim m_DIL as Single         '        dilatancy factor
       Dim m_GAPQ as Single        '        transverse slip/gap
      END Structure

      Structure CGPT_KIN           ' 30/NR:11  Kinematic Constraint
       Dim m_ID as Integer         '        identifier 11
       Dim m_KTL as Integer        '        type +  10000*group-number
       Dim m_KR1 as Integer        '        reference GPT 1
       Dim m_KR2 as Integer        '        reference GPT 2
       Dim m_DX as Single          '        direction of coupling X-axis
       Dim m_DY as Single          '        direction of coupling Y-axis
       Dim m_DZ as Single          '        direction of coupling Z-axis
       Dim m_DD as Single          '        factor of interpolation
       Dim m_FF as Single          '        factor of multiplication
      END Structure

      Structure CGPT_SPC           ' 30/NR:12  Elastic Spring connection (obsoleted)
       Dim m_ID as Integer         '        identifier 12
       Dim m_IRI as Integer        '        direction + 100*sign(group number,direction)
       Dim m_IPC as Integer        '        connecting Spoint
       Dim m_NWL as Integer        '        work law number
       Dim m_CP as Single          ' [1095] spring stiffness z
       Dim m_CQ as Single          ' [1095] transverse stiff.
       Dim m_CM as Single          ' [1098] torsional stiff.
       Dim m_PRE as Single         '        prestress for cp
       Dim m_GAP as Single         '        slip of spring
       Dim m_RISS as Single        '        max tension force
       Dim m_FLIE as Single        '        yielding load
       Dim m_MUE as Single         '        friction cross
       Dim m_COH as Single         '        cohesion cross
       Dim m_DIL as Single         '        dilatancy factor
      END Structure

      Structure CGPT_DADS          ' 30/NR:998  List of origin ids the structural member has been created from
       Dim m_ID as Integer         '        ident 998
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() as Integer '        ids of all anchestors
      END Structure

      Structure CGLN               ' 31/NR:0  Structural lines
       Dim m_ID as Integer         '        identifier 0
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_PT() as Integer '        Number start & end point
       Dim m_I3 as Integer         '        reserved
       Dim m_IBT as Integer        '        Bitpattern of element properties acc. 39/NR:100 IBT
       Dim m_IBC as Integer        '        Boundary condition acc. 39/NR:100 IBC
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_I_0() as Single '        reserved
       Dim m_HMESH as Single       ' [1001] mesh density along line acc. 39/NR:100 HMESH
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_I_11() as Single '        reserved
       Dim m_PROG as Single        '        progression factor (>0 monoton, <0 symmetric)
       Dim m_I_15 as Single
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Line
      END Structure

      Structure CGLN_REF           ' 31/NR:-  Reference to another Geometry
       Dim m_IGM as Integer        '        negative value of the master geometry
       Dim m_IGS as Integer        '        optional identifier of a secondary axis
       Dim m_SMIN as Single        '        min parameter on referenced axis
       Dim m_SMAX as Single        '        max parameter on referenced axis
      END Structure

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
      Structure CGLN_GEO           ' 31/NR:??  Geometric properties
       Dim m_ILN as Integer        '        Code of geometry
       Dim m_GPG as Single         ' [1001] geometry parameter 1
       Dim m_GPA as Single         ' [1001] geometry parameter 2
       Dim m_DD as Single          ' [1001] arc length
       Dim m_S1 as Single          '        parameter s on start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() as Single ' [1001] Ordinate of start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() as Single '        Tangent of start
       Dim m_RG1 as Single         ' [1009] in-plane curvature
       Dim m_RA1 as Single         ' [1009] vertical curvature
       Dim m_S2 as Single          '        parameter s on end
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() as Single ' [1001] Ordinate of endpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() as Single '        Tangent of endpoint
       Dim m_RG2 as Single         ' [1009] in-plane curvature
       Dim m_RA2 as Single         ' [1009] vertical curvature
      END Structure

const GLN_BEAM_IBC_LOCAL = 16384
const GLN_BEAM_IBC_NFREE = 32768
      Structure CGLN_BEAM          ' 31/NR:100  Properties of beams (obsoleted)
       Dim m_ID as Integer         '        ident 100
       Dim m_NOG as Integer        '        Element type
       Dim m_NQ as Integer         '        number cross section
       Dim m_NP as Integer         '        number bedding props
       Dim m_IBC as Integer        '        Hinge code
       Dim m_DIV as Integer        '        prescribed subdivision no of segments
       Dim m_EYA as Single         ' [1001] eccentricity at start
       Dim m_EZA as Single         ' [1001] eccentricity at start
       Dim m_EYE as Single         ' [1001] eccentricity at end
       Dim m_EZE as Single         ' [1001] eccentricity at end
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
       Dim m_CM as Single          ' [1099] torsional bedding
       Dim m_CX as Single          ' [1096] global X  bedding
       Dim m_CY as Single          ' [1096] global Y  bedding
       Dim m_CZ as Single          ' [1096] global Z  bedding
       Dim m_CXX as Single         ' [1099] global X  tors.bed.
       Dim m_CYY as Single         ' [1099] global Y  tors.bed.
       Dim m_CZZ as Single         ' [1099] global Z  tors.bed.
      END Structure

      Structure CGLN_ELNR          ' 31/NR:121  Elements generated on lines
       Dim m_ID as Integer         '        identifier = 121
       Dim m_ETYP as Integer       '        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
       Dim m_IBIT as Integer       '        Bit-code
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=253)> Dim m_NR() as Integer '        packed list of element numbers
      END Structure

      Structure CGLN_DADS          ' 31/NR:998  Ids of items being an anchestor
       Dim m_ID as Integer         '        ident 998
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() as Integer '        ids of all anchestors
      END Structure

const GAR_IBC_REF = 32768
      Structure CGAR               ' 32/NR:0  Structural area
       Dim m_ID as Integer         '        identification of general data (0)
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_NOR as Integer        '        number of reinforc.
       Dim m_ITP as Integer        '        Bitpattern for element generation QUAD
       Dim m_IBC as Integer        '        Boundary condition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TD() as Single ' [1010] Constant thickness
       Dim m_CB as Single          '        bedding factor
       Dim m_CQ as Single          '        tangential bedding factor
       Dim m_TROT as Single        '        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of surface
      END Structure

      Structure CGAR_REF           ' 32/NR:-  Reference to another Geometry
       Dim m_IGM as Integer        '        negative value of the master geometry
      END Structure

      Structure CGAR_BOUN          ' 32/NR:1  Outer Boundary of Area
       Dim m_ID as Integer         '        identification
       Dim m_NG as Integer         '        edgeno     (31/NG)
       Dim m_NA as Integer         '        startpoint (30/NA)
       Dim m_NB as Integer         '        endpoint   (30/NB)
       Dim m_NM as Integer         '        midpoint   (30/NM)
       Dim m_IFC as Integer        '        Interface hinge bit pattern
       Dim m_T as Single           ' [1010] Plate thickness of edge
       Dim m_DFIX as Single        ' [1001] Distance (offset) of region to edge
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
       Dim m_CM as Single          ' [1099] torsional bedding
      END Structure

      Structure CGAR_HOLE          ' 32/NR:2  Inner Boundary of Area
       Dim m_ID as Integer         '        identification
       Dim m_NG as Integer         '        edgeno     (31/NG)
       Dim m_NA as Integer         '        startpoint (30/NA)
       Dim m_NB as Integer         '        endpoint   (30/NB)
       Dim m_NM as Integer         '        midpoint   (30/NM)
       Dim m_IFC as Integer        '        Interface hinge bit pattern
       Dim m_T as Single           ' [1010] Plate thickness of edge
       Dim m_DFIX as Single        ' [1001] Distance (offset) of region to edge
       Dim m_CA as Single          ' [1096] axial     bedding
       Dim m_CQ as Single          ' [1096] lateral   bedding
       Dim m_CM as Single          ' [1099] torsional bedding
      END Structure

      Structure CGAR_CON3          ' 32/NR:3  Prescribed Edges/Points
       Dim m_ID as Integer         '        identification
       Dim m_NG as Integer         '        edgenumber (31/NG)
       Dim m_NA as Integer         '        startpoint (30/NA)
       Dim m_NB as Integer         '        endpoint   (30/NB)
       Dim m_NM as Integer         '        midpoint   (30/NM)
       Dim m_MAT as Integer        '        Materialnumber of subregion for ID==4
       Dim m_T as Single           ' [1010] Plate thickness at edge or point
      END Structure

      Structure CGAR_CON4          ' 32/NR:4  Domain-Subdivision-Edges
       Dim m_ID as Integer         '        identification
       Dim m_NG as Integer         '        edgenumber (31/NG)
       Dim m_NA as Integer         '        startpoint (30/NA)
       Dim m_NB as Integer         '        endpoint   (30/NB)
       Dim m_NM as Integer         '        midpoint   (30/NM)
       Dim m_MAT as Integer        '        Materialnumber of subregion for ID==4
       Dim m_T as Single           ' [1010] Plate thickness at edge or point
      END Structure

      Structure CGAR_MESH          ' 32/NR:9  Prescribed Mesh size
       Dim m_ID as Integer         '        identification
       Dim m_NG as Integer         '        number of support macro generating mesh
       Dim m_NA as Integer         '        startedge  (31/NA)
       Dim m_NB as Integer         '        endedge    (31/NB)
       Dim m_I4 as Integer         '        not used
       Dim m_I5 as Integer         '        not used
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_HSIZE() as Single ' [1001] requested mesh size
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTA() as Single ' [1001] Coordinates of startpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTE() as Single ' [1001] Coordinates of endpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTM() as Single ' [1001] Coordinates of midpoint
      END Structure

      Structure CGAR_GEO           ' 32/NR:10  Geometry of surface
       Dim m_ID as Integer         '        Identification of surface description 10
       Dim m_NG as Integer         '        Type of surface representation
       Dim m_MGRI as Integer       '        number of data/control points in s of mesh
       Dim m_NGRI as Integer       '        number of data/control points in t of mesh
       Dim m_MSPL as Integer       '        degree of B-spline in s direction
       Dim m_NSPL as Integer       '        degree of B-spline in t direction
       Dim m_SX as Single          '        plane  direction sx
       Dim m_SY as Single          '        plane  direction sy
       Dim m_SZ as Single          '        plane  direction sz
       Dim m_TX as Single          '        plane  direction tx
       Dim m_TY as Single          '        plane  direction ty
       Dim m_TZ as Single          '        plane  direction tz
       Dim m_NX as Single          '        normal direction nx
       Dim m_NY as Single          '        normal direction ny
       Dim m_NZ as Single          '        normal direction nz
       Dim m_X as Single           ' [1001] X-ordinate Origin
       Dim m_Y as Single           ' [1001] Y-ordinate Origin
       Dim m_Z as Single           ' [1001] Z-ordinate Origin
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() as Single '        additional Parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() as Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_XPAR() as Single '        extended parameters
      END Structure

      Structure CGAR_SURF          ' 32/NR:11  UserPointonSurface
       Dim m_ID as Integer         '        Identification of user surface description 11
       Dim m_IT as Integer         '        Type of point
       Dim m_M as Integer          '        Rasterlocation of mesh 0 < m ( mgri )
       Dim m_N as Integer          '        Rasterlocation of mesh 0 < n ( ngri )
       Dim m_N3 as Integer         '        the degree of the Spline becoming effective
       Dim m_N4 as Integer         '        the weight of NURBS control point [-]
       Dim m_X as Single           ' [1001] X-ordinate
       Dim m_Y as Single           ' [1001] Y-ordinate
       Dim m_Z as Single           ' [1001] Z-ordinate
       Dim m_T as Single           ' [1010] Thickness
      END Structure

      Structure CGAR_COON          ' 32/NR:12  COONsPatchInfo
       Dim m_ID as Integer         '        Identification of COONs blending edges 12
       Dim m_IT as Integer         '        Type of blending
       Dim m_IU0 as Integer        '        No of geometry line for u=umin (left)
       Dim m_IU1 as Integer        '        No of geometry line for u=umax (right)
       Dim m_IV0 as Integer        '        No of geometry line for v=vmin (lower)
       Dim m_IV1 as Integer        '        No of geometry line for v=vmax (upper)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_SP() as Single '        Length parameters for the edges iu0,iu1,iv0,iv1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() as Single '        umin,umax,vmin,vmax of the parameter plane
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_CXYZ() as Single '        Coordinates of the corner points C1,C2,C3,C4
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_TINC() as Single '        inclinations for a bicubic patch as vectors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TWIST() as Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
      END Structure

      Structure CGAR_ELNR          ' 32/NR:221  Generated elements from area
       Dim m_ID as Integer         '        identifier = 221
       Dim m_ETYP as Integer       '        Type of element {200,...} for {QUAD,...}
       Dim m_ID2 as Integer        '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=253)> Dim m_NR() as Integer '        packed list of element numbers
      END Structure

      Structure CGAR_DADS          ' 32/NR:998  Ids of items being an anchestor
       Dim m_ID as Integer         '        ident 998
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() as Integer '        ids of all anchestors
      END Structure

      Structure CGVO               ' 33/NR:0  StructuralVolume
       Dim m_ID as Integer         '        identification of general data (0)
       Dim m_NOG as Integer        '        number of group
       Dim m_NOM as Integer        '        number of material
       Dim m_NOR as Integer        '        number of reinforc.
       Dim m_NOT as Integer        '        number of elementtype
       Dim m_IBC as Integer        '        Boundary condition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Volume
      END Structure

      Structure CGVO_SURF          ' 33/NR:+  Involved Surfaces
       Dim m_ITP as Integer        '        identification of definition
       Dim m_NG as Integer         '        surface    (32/NG)
       Dim m_NR as Integer         '        extrusion or rotation geometry identifier
       Dim m_NREF as Integer       '        optional number of a reference point
       Dim m_NARA as Integer       '        region identifier for start surface
       Dim m_NARE as Integer       '        region identifier for end surface
       Dim m_T as Single           ' [1010] Thickness of interface layer
       Dim m_FAC as Single         '        Scale factor for extrusion
       Dim m_FAC0 as Single        '        Scale factor for start segment
       Dim m_PHI as Single         ' [   5] end rotation angle for extrusion/rotation
       Dim m_PHI0 as Single        ' [   5] start rotation angle for rotation
       Dim m_DPHI as Single        ' [   5] allowable sector angle for rotation
       Dim m_DX as Single          ' [1001] explicit extrusion / rotational axis
       Dim m_DY as Single          ' [1001] explicit extrusion / rotational axis
       Dim m_DZ as Single          ' [1001] explicit extrusion / rotational axis
       Dim m_XREF as Single        ' [1001] explicit reference point
       Dim m_YREF as Single        ' [1001] explicit reference point
       Dim m_ZREF as Single        ' [1001] explicit reference point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TFAC() as Single ' [1010] Factor for thickness extrusion START/END/REF
      END Structure

      Structure CSLVL_DEF          ' 34/NR:0  Structural Storey Level Definition
       Dim m_ID0 as Integer        '        identification of definition data (0)
       Dim m_SPTM as Integer       '        ID of SPT to be generated at center of mass
       Dim m_SPTR as Integer       '        ID of SPT to be generated at center of rigidity
       Dim m_IBIT_STC as Integer   '        stiffness calculation bit pattern
       Dim m_IBIT_CPC as Integer   '        capacity calculation bit pattern
       Dim m_IBC as Integer        '        reserved
       Dim m_ZLEV as Single        ' [1006] Storey level, upwards positive (reference)
       Dim m_DZUPW as Single       ' [1001] Vertical extension upwards (search box) OK
       Dim m_DZDWN as Single       ' [1001] Vertical extension downwards (search box) UK
       Dim m_XMIN as Single        ' [1001] Lateral extension (search box)
       Dim m_XMAX as Single        ' [1001] Lateral extension (search box)
       Dim m_YMIN as Single        ' [1001] Lateral extension (search box)
       Dim m_YMAX as Single        ' [1001] Lateral extension (search box)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of level
      END Structure

      Structure CDSLN_DEF          ' 35/ID:0  Design Element Definition
       Dim m_ID0 as Integer        '        identification of definition data (0)
       Dim m_DSLN as Integer       '        number of design element
       Dim m_FREF as Integer       '        reference of forces
       Dim m_NCS as Integer        '        number of cross section
       Dim m_DSEL as Integer       '        type of quad selection
       Dim m_NIDS as Integer       '        count of geometry identifiers
       Dim m_HDIV as Single        ' [1001] interval of sub-division sections
      END Structure

      Structure CDGEO_DEF          ' 35/ID:1  Design Element Geometry
       Dim m_ID as Integer         '        identification of data (2)
       Dim m_TYPE as Integer       '        type of geometric definition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_IDS() as Integer '        ids of structural lines or beams
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() as Single ' [1001] geometry of a straight line
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() as Single ' [1001] geometry of a straight line
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DZ() as Single ' [1001] direction z-axis of straight line
      END Structure

      Structure CDSLC_DEF          ' 35/ID:2  Design Sections
       Dim m_ID as Integer         '        identification of data (1)
       Dim m_TYPE as Integer       '        type of sectioning
       Dim m_ITYP as Integer       '        type of section
       Dim m_POS as Single         ' [1001] position of sections
      END Structure

      Structure CSGRP              ' 37/ID:0  Secondary groups
       Dim m_ID0 as Integer        '        identification of general data (0)
       Dim m_TYP as Integer        '        Bit infos of selected element types
       Dim m_BIT as Integer        '        Bit infos on selections contained in that group
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of sgrp
      END Structure

      Structure CSGRP_BOX          ' 37/ID:1  Selective Basic-Volume
       Dim m_ID as Integer         '        identification of data (1)
       Dim m_TYP as Integer        '        type of property volume
       Dim m_BIT as Integer        '        option
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=21)> Dim m_PAR() as Single ' [1001] PARAMETERS OF BOX par(3,0:6)
      END Structure

      Structure CSGRP_POL          ' 37/ID:2  Selective Polyeder-Volume
       Dim m_ID as Integer         '        identification of data (2)
       Dim m_TYP as Integer        '        number of vertices
       Dim m_BIT as Integer        '        option
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() as Single '        transformation matrix to local coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_EXT() as Single ' [1001] global extension, local extensions min/max
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=189)> Dim m_VERT() as Single ' [1001] vertices in local coordinates r,s,t
      END Structure

      Structure CSGRP_LIS          ' 37/ID:0???  Calculated Selective Element List
       Dim m_ID as Integer         '        identifier of element to be selected (positive)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() as Integer '        element numbers
      END Structure

      Structure CSGRP_ADD          ' 37/ID:1???  Selecting Element List
       Dim m_ID as Integer         '        identifier of element to be selected (positive)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() as Integer '        element numbers
      END Structure

      Structure CSGRP_SUB          ' 37/ID:2???  Excluding Element List
       Dim m_ID as Integer         '        identifier of element to be selected (positive)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() as Integer '        element numbers
      END Structure

      Structure CSGRP_SEL          ' 37/ID:3???  Property-Values
       Dim m_ID as Integer         '        identifier of element to be modified
       Dim m_TYPE as Integer       '        Option to perform
       Dim m_BIT as Integer        '        bit pattern of selected data
       Dim m_ITP as Integer        '        key value for orientation of coordinate system
       Dim m_DIV as Integer        '        key value of subdivision or other extended data
       Dim m_IDQ as Integer        '        key value of cross section or other extended data
       Dim m_IDH as Integer        '        key value of hinge conditions or other extended data
       Dim m_IDX as Integer        '        key value of other extended data
       Dim m_TROT as Single        '        Fractional rotation about
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() as Single '        Vector to be aligned as local axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RDAT() as Single '        reserved for values not in DATA
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_DATA() as Integer '        equivalenced data structure of that
      END Structure

      Structure CGLAR_0            ' 38/NR:0  Load distribution areas Header
       Dim m_ID as Integer         '        Identification 0
       Dim m_NGAR as Integer       '        number of an 32/NGAR area definition
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NGRP() as Integer '        group of area and three active groups
       Dim m_MGRI as Integer       '        prescribed grid subdivision (NGAR=0)
       Dim m_NGRI as Integer       '        prescribed grid subdivision (NGAR=0)
       Dim m_ID32 as Integer       '        access ID of 32/0 to check valid data
       Dim m_ID20 as Integer       '        access ID of 20/0 to check valid data
       Dim m_NNOD as Integer       '        number of nodes            38/NR:1
       Dim m_NQUA as Integer       '        number of quadrilaterals   38/NR:2
       Dim m_NSEG as Integer       '        number of beam sections    38/NR:3
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() as Integer '        reserved
       Dim m_SGRP as Integer       '        optional secondary group selector id
       Dim m_T as Single           ' [1010] thickness of load area used to catch beams
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() as Single ' [1001] ! 4 corner points of area (optional)
      END Structure

      Structure CGLAR_NOD          ' 38/NR:1  Node of load distribution area
       Dim m_ID as Integer         '        Identification 1 (instead of NR)
       Dim m_INR as Integer        '        nodenumber within the region
       Dim m_NFIX as Integer       '        not used
       Dim m_NCOD as Integer       '        not used
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() as Single ' [1001] coordinates
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() as Single ' [1001] displacements for uniform load -> animator
      END Structure

      Structure CGLAR_QUA          ' 38/NR:2  QUAD of load distribution area
       Dim m_ID as Integer         '        Identification 2 (instead of NR)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer '        nodenumbers of the quad within region
       Dim m_MAT as Integer        '        not used
       Dim m_MRF as Integer        '        not used
       Dim m_NRA as Integer        '        type of element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() as Single '        Parameter of Jacobi Determinant
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() as Single ' [1010] element thickness
       Dim m_CB as Single          '        not used
       Dim m_CQ as Single          '        not used
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
      END Structure

      Structure CGLAR_SEG          ' 38/NR:3  BEAM segments within area
       Dim m_ID as Integer         '        Identification 3
       Dim m_NR as Integer         '        number of loaded beam element
       Dim m_X as Single           ' [1001] start point
       Dim m_L as Single           ' [1001] length of segment
      END Structure

      Structure CGLAR_P            ' 38/NR:1?  Load distribution areas  Pointloads
       Dim m_ID as Integer         '        Identification 10:13
       Dim m_INR as Integer        '        nodenumber of 038/NR:1 within region
       Dim m_NODE as Integer       '        nodenumber of a global node
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_P() as Single '        value of load
      END Structure

      Structure CGLAR_L            ' 38/NR:10?  Load distribution areas  Beamloads
       Dim m_ID as Integer         '        Identification 100:103
       Dim m_INR as Integer        '        nodenumber of 038/NR:1 within region
       Dim m_NSEG as Integer       '        number of 038/NR:3 segment
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
       Dim m_MA as Single          '        start value of torque
       Dim m_ME as Single          '        end value of torque
      END Structure

      Structure CTENDAXIS          ' 40/NR:0  Tendon lanes/reference axis data
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_IGSYS as Integer      '        prestress for:
       Dim m_IGINFO as Integer     '        Systeminfo
       Dim m_IGREF as Integer      '        reference to geometry
       Dim m_ICBIT as Integer      '        bit for analysis type
       Dim m_IDS as Integer        '        Enum of secondary axis (1='A' to 26 ='Z')
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation
      END Structure

      Structure CTENDAX_1          ' 40/NR:1  Tendon lane stations
       Dim m_ID0 as Integer        '        identifier 1
       Dim m_IGBIT as Integer      '        station parameter
       Dim m_NRSTAB as Integer     '        internal beam number
       Dim m_ID3 as Integer        '        reserved (value = 0)
       Dim m_XL as Single          '        beam X/L on beam
       Dim m_S as Single           ' [1001] station on reference lane
       Dim m_SG as Single          ' [1001] station of geometry
       Dim m_SF as Single          '        toppoint station
      END Structure

      Structure CTENDSPLI          ' 41/NR:0  Tendon splines
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_NRSPUR as Integer     '        corresponding lane
       Dim m_NRSV as Integer       '        prestress system
       Dim m_IGSYS as Integer      '        prestress for:
       Dim m_INTYP as Integer      '        bit for analysis type
       Dim m_IGREF as Integer      '        reference to      geometry  Rec: 03
       Dim m_IGREFX as Integer     '        reference to exc. geometry  Rec: 03
       Dim m_ID7 as Integer        '        reserved (value = 0)
       Dim m_ID8 as Integer        '        reserved (value = 0)
       Dim m_ID9 as Integer        '        reserved (value = 0)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_STPARM() as Single '        additional data:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation
      END Structure

      Structure CTENDSP_I          ' 41/NR:??  Input points
       Dim m_ID0 as Integer        '        identifier INTYP see 41/0  (1=ZPUV standard geometry)
       Dim m_IGBIT as Integer      '        station parameter see 40/1
       Dim m_ID2 as Integer        '        reserved (value = 0)
       Dim m_ID3 as Integer        '        reserved (value = 0)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_DATA() as Single '        Input point data
       Dim m_QSP as Integer        '        Selection string - reference to cross section point
       Dim m_VARU as Integer       '        Selection string - axis variable for offset U
       Dim m_VARV as Integer       '        Selection string - axis variable for offset V
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=50)> Dim m_DAT2() as Single '        Additional input point
      END Structure

      Structure CTENDTOPP          ' 43/NR  Tendon toppoints
       Dim m_ID0 as Integer        '        identifier:
       Dim m_NR as Integer         '        corresponding lane
       Dim m_IGREF as Integer      '        reference to      geometry  Rec: 03
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=124)> Dim m_S() as Single ' [1001] stations on toppoints (max. 124)
      END Structure

      Structure CTENDON            ' 44/NR:0  Tendons
       Dim m_ID0 as Integer        '        identifier 0
       Dim m_NRSPUR as Integer     '        corresponding lane
       Dim m_NRSPLI as Integer     '        Spline-No
       Dim m_NRSTRG as Integer     '        tendon no.
       Dim m_IGREF as Integer      '        reference to      geometry  Rec: 03
       Dim m_IGTYP as Integer      '        bit for analysis type
       Dim m_IZ_REF as Integer     '        IGTYP=1024:  Def-No of geometry
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_NIBA() as Integer '        construction stages
       Dim m_NRSV as Integer       '        prestress system
       Dim m_NSP as Integer        '        number of tendons
       Dim m_MATA as Integer       '        material concrete
       Dim m_NVART as Integer      '        type of jacking
       Dim m_NVARTU as Integer     '        output control
       Dim m_NVVOR as Integer      '        prestress input
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NVBIT() as Integer '        jacking bit
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFP() as Integer '        prestress loadcases
       Dim m_IGSYS as Integer      '        prestress for:
       Dim m_ID21 as Integer       '        reserved (value = 0)
       Dim m_KAPA as Single        '        KAPA + 100*KAPL + 1000*action
       Dim m_EINL as Single        '        transition length
       Dim m_ETYP as Single        '        force type to EINL
       Dim m_TFAK as Single        '        factor partial p
       Dim m_TLITZ as Single       '        no. of wires
       Dim m_AR as Single          '        crack design area
       Dim m_DZ as Single          '        diameter of tendon
       Dim m_UZ as Single          '        perimeter
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_VALM() as Single '        reserved
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation
      END Structure

      Structure CTENDJACK          ' 44/NR:1  Tendon jacking data
       Dim m_ID0 as Integer        '        identifier 1
       Dim m_ID1 as Integer        '        reserved (value = 0)
       Dim m_ID2 as Integer        '        reserved (value = 0)
       Dim m_ID3 as Integer        '        reserved (value = 0)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ZVSTRG() as Single '        geometry data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_ZVFAK() as Single '        stresses and stressing factors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZVVOR() as Single '        direct input of prestress
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZVFREE() as Single '        free prestress
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_ZVAEND() as Single '        local geometry position
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_ZVREIB() as Single '        additional friction data
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_ZVFGRZ() as Single '        limit values of prestress
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ZVWEG() as Single '        stressing deformation
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation
      END Structure

      Structure CTENDFACT          ' 44/NR:2  Tendon jacking factors
       Dim m_ID0 as Integer        '        identifier 2
       Dim m_IGBIT as Integer      '        station parameter see 40/1
       Dim m_ID2 as Integer        '        reserved (value = 0)
       Dim m_ID3 as Integer        '        reserved (value = 0)
       Dim m_S as Single           ' [1001] station
       Dim m_FAK as Single         '        active stressing factors
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZWFAK() as Single '        additional factor data
      END Structure

      Structure CHIST_HED          ' 80/LC:-10?  TimeHistoryTitle
       Dim m_RID as Single         '        Identifier of history type
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TITLE() as Integer '        Designation
      END Structure

      Structure CHIST_PAR          ' 80/LC:-9??  IterationParameters
       Dim m_RID as Single         '        identifier
       Dim m_VAL as Single         '        current value
       Dim m_MIN as Single         '        minimum allowed value
       Dim m_MAX as Single         '        maximum allowed value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() as Integer '        name of parameter
      END Structure

      Structure CHIST_ITEM         '        History element
       Dim m_NR as Integer
       Dim m_TYP as Integer
      END Structure

      Structure CHIST              ' 80/LC:-  Identification of history elements
       Dim m_RID as Single         '        Identification -100 < RID < 0.
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_ITEM() as CHIST_ITEM '        History element
      END Structure

      Structure CHIST_VAL          ' 80/LC:+  Transient data
       Dim m_TT as Single          '        Time/frequency
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_VB() as Single '        curve values
      END Structure

      Structure CSLVL_DAT          ' 87/0:+  Structural Storey Level Data
       Dim m_NR as Integer         '        Storey Level ID (34/NR)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NREF() as Integer '        Node numbers of reference nodes on level
       Dim m_NR_COR as Integer     '        spt number of center of rigidity (COR)
       Dim m_NR_COM as Integer     '        spt number of center of mass (COM)
       Dim m_CREATOR as Integer    '        generated by (program) (0=SOFiMSHC, 1=DYNA)
       Dim m_ZLEV as Single        ' [1006] Storey elevation, upwards positive (reference)
       Dim m_H as Single           ' [1001] Storey height
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_XEXT() as Single ' [1001] Storey extensions in global X [XMIN, XMAX]
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_YEXT() as Single ' [1001] Storey extensions in global Y [YMIN, YMAX]
       Dim m_MASS as Single        ' [1180] Storey mass
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZM() as Single ' [1001] Coordinates of COM
       Dim m_STX as Single         ' [1095] Storey stiffness in global X
       Dim m_STY as Single         ' [1095] Storey stiffness in global Y
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZR() as Single ' [1001] Coordinates of COR
       Dim m_CPX as Single         ' [1151] Storey capacity in global X
       Dim m_CPY as Single         ' [1151] Storey capacity in global Y
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of level
      END Structure

      Structure CSLVL_RES          ' 87/LC:+  Structural Storey Level Results
       Dim m_NR as Integer         '        Storey Level ID (34/NR)
       Dim m_NR_MODE as Integer    '        mode number (=0: resultant values, e.g. from CQC sup.)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_STYP() as Integer '        superposition type
       Dim m_PX as Single          ' [1151] base shear in X
       Dim m_PY as Single          ' [1151] base shear in Y
       Dim m_PZ as Single          ' [1151] total vertical load at and above the storey
       Dim m_MX as Single          ' [1152] moment about X
       Dim m_MY as Single          ' [1152] moment about Y
       Dim m_MZ as Single          ' [1152] moment about Z
       Dim m_UX as Single          ' [1003] average storey displacement in X (=translations at COR)
       Dim m_UY as Single          ' [1003] average storey displacement in Y
       Dim m_UZ as Single          ' [1003] average storey displacement in Z
       Dim m_RZ as Single          ' [1004] average storey rotation in XY-plane
       Dim m_DX as Single          ' [1003] inter-storey drift in X (=difference between top and bottom of 
       Dim m_DY as Single          ' [1003] inter-storey drift in Y
       Dim m_DRZ as Single         ' [1004] inter-storey rotation in XY-plane
       Dim m_LSAF as Single        ' [  98] modal acceleration (only for NR_MODE>0)
      END Structure

      Structure CBEAM              ' 100/00:+  Beams
       Dim m_NR as Integer         '        beam number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        node number start/end
       Dim m_NP as Integer         '        prop number
       Dim m_DL as Single          ' [1001] beamlength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_EX() as Single ' [1001] 
       Dim m_NREF as Integer       '        reference axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SPAR() as Single '        distances along a continuous beam or
       Dim m_BETY as Single
       Dim m_BETZ as Single
       Dim m_LDFY as Single
       Dim m_LDFZ as Single        '        deformation length factor for vz
      END Structure

      Structure CBSLN              ' 120/00:+  Design elements
       Dim m_NR as Integer         '        beam number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        node number start/end
       Dim m_NP as Integer         '        prop number
       Dim m_DL as Single          ' [1001] beamlength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_EX() as Single ' [1001] 
       Dim m_NREF as Integer       '        reference axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SPAR() as Single '        distances along a continuous beam or
       Dim m_BETY as Single
       Dim m_BETZ as Single
       Dim m_LDFY as Single
       Dim m_LDFZ as Single        '        deformation length factor for vz
      END Structure

      Structure CBSCT              ' 140/00:+  External sections
       Dim m_NR as Integer         '        beam number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        node number start/end
       Dim m_NP as Integer         '        prop number
       Dim m_DL as Single          ' [1001] beamlength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_EX() as Single ' [1001] 
       Dim m_NREF as Integer       '        reference axis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SPAR() as Single '        distances along a continuous beam or
       Dim m_BETY as Single
       Dim m_BETZ as Single
       Dim m_LDFY as Single
       Dim m_LDFZ as Single        '        deformation length factor for vz
      END Structure

      Structure CBEAM_SCT          ' 100/00:0  Beams sections
       Dim m_ID as Integer         '        identifier for sections 0
       Dim m_NQ as Integer         '        number cross section
       Dim m_ITYP as Integer       '        Bitcodes
       Dim m_ITP2 as Integer       '        Connection / Hinges for x=0,x=dl
       Dim m_X as Single           ' [1001] sectional abscissa
      END Structure

      Structure CBSLN_SCT          ' 120/00:0  Design element sections
       Dim m_ID as Integer         '        identifier for sections 0
       Dim m_NQ as Integer         '        number cross section
       Dim m_ITYP as Integer       '        Bitcode I   (identical to 100/0:0)
       Dim m_ITP2 as Integer       '        Bitcode II  (identical to 100/0:0)
       Dim m_X as Single           ' [1001] sectional abscissa
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() as Single '        transformation matrix
       Dim m_YMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_ZMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_YMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_ZMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_XMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_XMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_YMINSEL as Single     ' [1001] Max user defined size of Box
       Dim m_ZMINSEL as Single     ' [1001] Max user defined size of Box
       Dim m_YMAXSEL as Single     ' [1001] Max user defined size of Box
       Dim m_ZMAXSEL as Single     ' [1001] Max user defined size of Box
       Dim m_YSC as Single         ' [1001] Coordinate y of shear centre
       Dim m_ZSC as Single         ' [1001] Coordinate z of shear centre
      END Structure

      Structure CBSCT_SCT          ' 140/00:0  External sections
       Dim m_ID as Integer         '        identifier for sections 0
       Dim m_NQ as Integer         '        number cross section
       Dim m_ITYP as Integer       '        Bitcode I   (identical to 100/0:0)
       Dim m_ITP2 as Integer       '        Bitcode II  (identical to 100/0:0)
       Dim m_X as Single           ' [1001] sectional abscissa
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() as Single '        transformation matrix
       Dim m_YMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_ZMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_YMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_ZMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_XMIN as Single        ' [1001] Box of active elements in cut plane
       Dim m_XMAX as Single        ' [1001] Box of active elements in cut plane
       Dim m_YMINSEL as Single     ' [1001] Max user defined size of Box
       Dim m_ZMINSEL as Single     ' [1001] Max user defined size of Box
       Dim m_YMAXSEL as Single     ' [1001] Max user defined size of Box
       Dim m_ZMAXSEL as Single     ' [1001] Max user defined size of Box
       Dim m_YSC as Single         ' [1001] Coordinate y of shear centre
       Dim m_ZSC as Single         ' [1001] Coordinate z of shear centre
      END Structure

      Structure CBEAM_TRA          ' 100/01  transformation matrix
       Dim m_NR as Integer         '        beamnumber
       Dim m_DL as Single          ' [1001] beamlength
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
      END Structure

      Structure CBEAM_TRS          ' 100/03  Info about dynamic moving beams (TREX)
       Dim m_LF as Integer         '        Loadcase number containing the train
       Dim m_NR as Integer         '        Number of Beam
       Dim m_BPAT as Integer       '        Options for BEAM (see TREX in SOFILOAD)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODA() as Integer '        Node Numbers for Start of beam element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer '        Node Numbers for end of beam element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_XN() as Single ' [1001] x-values of nodes along load train
      END Structure

      Structure CBEAM_TND          ' 100/05  tendons of beams
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        tendon number
       Dim m_MNR as Integer        '        material number of tendon + 1000 * material number of cross-sec
       Dim m_IBA1 as Integer       '        construction stage number for placing
       Dim m_IBA2 as Integer       '        construction stage number for grouting
       Dim m_IBA3 as Integer       '        construction stage number for removing
       Dim m_X as Single           ' [1011] x-ordinate
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_ZZ as Single          ' [1101] tensoning force
       Dim m_AZ as Single          ' [1020] tendon area
       Dim m_D as Single           ' [1023] diameter
       Dim m_UZ as Single          ' [1023] effect. periphery
       Dim m_NY as Single          '        inclination DY/DX
       Dim m_NZ as Single          '        inclination DZ/DX
       Dim m_YHR as Single         ' [1011] y-ordinate duct
       Dim m_ZHR as Single         ' [1011] z-ordinate duct
       Dim m_AHR as Single         ' [1020] area of duct
       Dim m_AR as Single          ' [1012] reference area
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_REDFAK as Single      '        Reduction factor within transmission length
       Dim m_XSI as Single         '        Relative ordinate within total tendon
      END Structure

      Structure CBSLN_TND          ' 120/05  tendons of structural beam lines
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        tendon number
       Dim m_MNR as Integer        '        material number of tendon + 1000 * material number of cross-sec
       Dim m_IBA1 as Integer       '        construction stage number for placing
       Dim m_IBA2 as Integer       '        construction stage number for grouting
       Dim m_IBA3 as Integer       '        construction stage number for removing
       Dim m_X as Single           ' [1011] x-ordinate
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_ZZ as Single          ' [1101] tensoning force
       Dim m_AZ as Single          ' [1020] tendon area
       Dim m_D as Single           ' [1023] diameter
       Dim m_UZ as Single          ' [1023] effect. periphery
       Dim m_NY as Single          '        inclination DY/DX
       Dim m_NZ as Single          '        inclination DZ/DX
       Dim m_YHR as Single         ' [1011] y-ordinate duct
       Dim m_ZHR as Single         ' [1011] z-ordinate duct
       Dim m_AHR as Single         ' [1020] area of duct
       Dim m_AR as Single          ' [1012] reference area
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_REDFAK as Single      '        Reduction factor within transmission length
       Dim m_XSI as Single         '        Relative ordinate within total tendon
      END Structure

      Structure CBSCT_TND          ' 140/05  tendons of external sections
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        tendon number
       Dim m_MNR as Integer        '        material number of tendon + 1000 * material number of cross-sec
       Dim m_IBA1 as Integer       '        construction stage number for placing
       Dim m_IBA2 as Integer       '        construction stage number for grouting
       Dim m_IBA3 as Integer       '        construction stage number for removing
       Dim m_X as Single           ' [1011] x-ordinate
       Dim m_Y as Single           ' [1011] y-ordinate
       Dim m_Z as Single           ' [1011] z-ordinate
       Dim m_ZZ as Single          ' [1101] tensoning force
       Dim m_AZ as Single          ' [1020] tendon area
       Dim m_D as Single           ' [1023] diameter
       Dim m_UZ as Single          ' [1023] effect. periphery
       Dim m_NY as Single          '        inclination DY/DX
       Dim m_NZ as Single          '        inclination DZ/DX
       Dim m_YHR as Single         ' [1011] y-ordinate duct
       Dim m_ZHR as Single         ' [1011] z-ordinate duct
       Dim m_AHR as Single         ' [1020] area of duct
       Dim m_AR as Single          ' [1012] reference area
       Dim m_TEMP as Single        ' [1215] Temperature
       Dim m_REDFAK as Single      '        Reduction factor within transmission length
       Dim m_XSI as Single         '        Relative ordinate within total tendon
      END Structure

      Structure CBEAM_SL           ' 101/LC:*  single beam loads
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_X as Single           ' [1001] load point
       Dim m_I_2 as Single         ' [1001] reserved 0.
       Dim m_PA as Single          '        value of load
       Dim m_I_4 as Single         '        reserved 0.
       Dim m_YA as Single          ' [1001] eccentr. local y
       Dim m_ZA as Single          ' [1001] eccentr. local z
      END Structure

      Structure CBEAM_DL           ' 101/LC:*  distributed beam loading on reference
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_X as Single           ' [1001] start point
       Dim m_L as Single           ' [1001] length of load
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
       Dim m_YA as Single          ' [1001] eccentr. local y A
       Dim m_ZA as Single          ' [1001] eccentr. local z A
       Dim m_YE as Single          ' [1001] eccentr. local y E
       Dim m_ZE as Single          ' [1001] eccentr. local z E
       Dim m_DYA as Single         '        gradient of eccentricity, local y, start
       Dim m_DZA as Single         '        gradient of eccentricity, local z, start
       Dim m_DYE as Single         '        gradient of eccentricity, local y, end
       Dim m_DZE as Single         '        gradient of eccentricity, local z, end
      END Structure

      Structure CBEAM_TL           ' 101/LC:*  distributed beam loading on reference
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_X as Single           ' [1001] start point
       Dim m_L as Single           ' [1001] length of load
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
       Dim m_YA as Single          ' [1001] eccentr. local y A
       Dim m_ZA as Single          ' [1001] eccentr. local z A
       Dim m_YE as Single          ' [1001] eccentr. local y E
       Dim m_ZE as Single          ' [1001] eccentr. local z E
       Dim m_DYA as Single         '        gradient of eccentricity, local y, start
       Dim m_DZA as Single         '        gradient of eccentricity, local z, start
       Dim m_DYE as Single         '        gradient of eccentricity, local y, end
       Dim m_DZE as Single         '        gradient of eccentricity, local z, end
      END Structure

      Structure CBEAM_CL           ' 101/LC:*  cubic beamloads
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_X as Single           ' [1001] start point
       Dim m_L as Single           ' [1001] length of load
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
       Dim m_DPA as Single         '        start derivative
       Dim m_DPE as Single         '        end   derivative
      END Structure

      Structure CBEAM_WL           ' 101/LC:*  dynamic wind loads
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_FA as Single          '        Factor cross start
       Dim m_FE as Single          '        Factor cross end
       Dim m_FT as Single          '        Factor frictional
       Dim m_VXA as Single         ' [1201] wind velocity
       Dim m_VYA as Single         ' [1201] wind velocity
       Dim m_VZA as Single         ' [1201] wind velocity
       Dim m_VXE as Single         ' [1201] wind velocity
       Dim m_VYE as Single         ' [1201] wind velocity
       Dim m_VZE as Single         ' [1201] wind velocity
       Dim m_VXAM as Single        ' [1201] mean wind velocity
       Dim m_VYAM as Single        ' [1201] mean wind velocity
       Dim m_VZAM as Single        ' [1201] mean wind velocity
       Dim m_VXEM as Single        ' [1201] mean wind velocity
       Dim m_VYEM as Single        ' [1201] mean wind velocity
       Dim m_VZEM as Single        ' [1201] mean wind velocity
      END Structure

      Structure CTRUS_WL           ' 151/LC:*  dynamic wind loads
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_FA as Single          '        Factor cross start
       Dim m_FE as Single          '        Factor cross end
       Dim m_FT as Single          '        Factor frictional
       Dim m_VXA as Single         ' [1201] wind velocity
       Dim m_VYA as Single         ' [1201] wind velocity
       Dim m_VZA as Single         ' [1201] wind velocity
       Dim m_VXE as Single         ' [1201] wind velocity
       Dim m_VYE as Single         ' [1201] wind velocity
       Dim m_VZE as Single         ' [1201] wind velocity
       Dim m_VXAM as Single        ' [1201] mean wind velocity
       Dim m_VYAM as Single        ' [1201] mean wind velocity
       Dim m_VZAM as Single        ' [1201] mean wind velocity
       Dim m_VXEM as Single        ' [1201] mean wind velocity
       Dim m_VYEM as Single        ' [1201] mean wind velocity
       Dim m_VZEM as Single        ' [1201] mean wind velocity
      END Structure

      Structure CCABL_WL           ' 161/LC:*  dynamic wind loads
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of load
       Dim m_FA as Single          '        Factor cross start
       Dim m_FE as Single          '        Factor cross end
       Dim m_FT as Single          '        Factor frictional
       Dim m_VXA as Single         ' [1201] wind velocity
       Dim m_VYA as Single         ' [1201] wind velocity
       Dim m_VZA as Single         ' [1201] wind velocity
       Dim m_VXE as Single         ' [1201] wind velocity
       Dim m_VYE as Single         ' [1201] wind velocity
       Dim m_VZE as Single         ' [1201] wind velocity
       Dim m_VXAM as Single        ' [1201] mean wind velocity
       Dim m_VYAM as Single        ' [1201] mean wind velocity
       Dim m_VZAM as Single        ' [1201] mean wind velocity
       Dim m_VXEM as Single        ' [1201] mean wind velocity
       Dim m_VYEM as Single        ' [1201] mean wind velocity
       Dim m_VZEM as Single        ' [1201] mean wind velocity
      END Structure

      Structure CBEAM_FOC          ' 102/LC:0  Maximum of Total Beam forces and deformations
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsionalmom.
       Dim m_UX as Single          ' [1003] diplacem. local x
       Dim m_UY as Single          ' [1003] diplacem. local y
       Dim m_UZ as Single          ' [1003] diplacem. local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
      END Structure

      Structure CBEAM_FTC          ' 112/LC:0  Maximum of Beam forces without plate components
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsionalmom.
       Dim m_UX as Single          ' [1003] diplacem. local x
       Dim m_UY as Single          ' [1003] diplacem. local y
       Dim m_UZ as Single          ' [1003] diplacem. local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
      END Structure

      Structure CBSLN_FTC          ' 122/LC:0  Maximum of Beam forces without plate components
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsionalmom.
       Dim m_UX as Single          ' [1003] diplacem. local x
       Dim m_UY as Single          ' [1003] diplacem. local y
       Dim m_UZ as Single          ' [1003] diplacem. local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
      END Structure

      Structure CBSCT_FOC          ' 142/LC:0  Maximum of External sections forces
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsionalmom.
       Dim m_UX as Single          ' [1003] diplacem. local x
       Dim m_UY as Single          ' [1003] diplacem. local y
       Dim m_UZ as Single          ' [1003] diplacem. local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
      END Structure

      Structure CBEAM_FOR          ' 102/LC:+  Total Beam forces and deformations
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsional moment
       Dim m_UX as Single          ' [1003] diplacement local x
       Dim m_UY as Single          ' [1003] diplacement local y
       Dim m_UZ as Single          ' [1003] diplacement local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
       Dim m_Q1 as Single          '        quaternion component q1
       Dim m_Q2 as Single          '        quaternion component q2
       Dim m_Q3 as Single          '        quaternion component q3
       Dim m_Q0 as Single          '        quaternion component q0
       Dim m_UXX as Single         ' [1003] translation in global X
       Dim m_UYY as Single         ' [1003] translation in global Y
       Dim m_UZZ as Single         ' [1003] translation in global Z
      END Structure

      Structure CBEAM_FTR          ' 112/LC:+  Beam forces without plate components
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsional moment
       Dim m_UX as Single          ' [1003] diplacement local x
       Dim m_UY as Single          ' [1003] diplacement local y
       Dim m_UZ as Single          ' [1003] diplacement local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
       Dim m_Q1 as Single          '        quaternion component q1
       Dim m_Q2 as Single          '        quaternion component q2
       Dim m_Q3 as Single          '        quaternion component q3
       Dim m_Q0 as Single          '        quaternion component q0
       Dim m_UXX as Single         ' [1003] translation in global X
       Dim m_UYY as Single         ' [1003] translation in global Y
       Dim m_UZZ as Single         ' [1003] translation in global Z
      END Structure

      Structure CBSLN_FTR          ' 122/LC:+  Beam forces without plate components
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsional moment
       Dim m_UX as Single          ' [1003] diplacement local x
       Dim m_UY as Single          ' [1003] diplacement local y
       Dim m_UZ as Single          ' [1003] diplacement local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
       Dim m_Q1 as Single          '        quaternion component q1
       Dim m_Q2 as Single          '        quaternion component q2
       Dim m_Q3 as Single          '        quaternion component q3
       Dim m_Q0 as Single          '        quaternion component q0
       Dim m_UXX as Single         ' [1003] translation in global X
       Dim m_UYY as Single         ' [1003] translation in global Y
       Dim m_UZZ as Single         ' [1003] translation in global Z
      END Structure

      Structure CBSCT_FOR          ' 142/LC:+  External sections forces
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsional moment
       Dim m_UX as Single          ' [1003] diplacement local x
       Dim m_UY as Single          ' [1003] diplacement local y
       Dim m_UZ as Single          ' [1003] diplacement local z
       Dim m_PHIX as Single        ' [1004] rotation local x
       Dim m_PHIY as Single        ' [1004] rotation local y
       Dim m_PHIZ as Single        ' [1004] rotation local z
       Dim m_PHIW as Single        ' [1005] twisting
       Dim m_MT3 as Single         ' [1103] 3rd torsionalmom
       Dim m_PA as Single          ' [1095] axial bedding
       Dim m_PT as Single          ' [1095] transverse bedding
       Dim m_PTY as Single         ' [1095] local y component of transverse bedding
       Dim m_PTZ as Single         ' [1095] local z component of transverse bedding
       Dim m_Q1 as Single          '        quaternion component q1
       Dim m_Q2 as Single          '        quaternion component q2
       Dim m_Q3 as Single          '        quaternion component q3
       Dim m_Q0 as Single          '        quaternion component q0
       Dim m_UXX as Single         ' [1003] translation in global X
       Dim m_UYY as Single         ' [1003] translation in global Y
       Dim m_UZZ as Single         ' [1003] translation in global Z
      END Structure

      Structure CBEAM_FOX          ' 102/0  Total External Beam forces
       Dim m_NQ as Integer         '        section number
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] abscissa
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsion.moment
      END Structure

      Structure CBSCT_FOX          ' 142/0  Total External Forces for external sections
       Dim m_NQ as Integer         '        section number
       Dim m_NR as Integer         '        beamnumber
       Dim m_X as Single           ' [1001] abscissa
       Dim m_N as Single           ' [1101] normal force
       Dim m_VY as Single          ' [1102] y-shear force
       Dim m_VZ as Single          ' [1102] z-shear force
       Dim m_MT as Single          ' [1103] torsional moment
       Dim m_MY as Single          ' [1104] bending moment My
       Dim m_MZ as Single          ' [1104] bending moment Mz
       Dim m_MB as Single          ' [1105] warping moment Mb
       Dim m_MT2 as Single         ' [1103] 2nd torsion.moment
      END Structure

      Structure CBEAM_STI          ' 103/LC  Stiffness of beams
       Dim m_NR as Integer         '        beam number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_EA as Single          ' [  62] normal stiffness
       Dim m_GAY as Single         ' [  62] y-shear stiffness
       Dim m_GAZ as Single         ' [  62] z-shear stiffness
       Dim m_GIT as Single         ' [  83] torsional stiffness
       Dim m_EIY as Single         ' [  83] bending stiffness y
       Dim m_EIZ as Single         ' [  83] bending stiffness z
       Dim m_EIYZ as Single        ' [  83] bending stiffness yz
       Dim m_GAYZ as Single        ' [  62] yz-shear stiffness
       Dim m_KPX as Single         ' [   8] plastic strain x
       Dim m_KPY as Single         ' [  17] plastic curvature y
       Dim m_KPZ as Single         ' [  17] plastic curvature z
       Dim m_EMIN as Single        ' [1081] minimum strain
       Dim m_EMAX as Single        ' [1081] maximum strain
       Dim m_GE1 as Single         ' [1101] Residual of current step (Crisfield)
       Dim m_GE2 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_GE3 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_EA0 as Single         ' [  83] lin. stiffness EA
       Dim m_EIY0 as Single        ' [  83] lin. stiffness EIy
       Dim m_EIZ0 as Single        ' [  83] lin. stiffness EIz
       Dim m_DYSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_DZSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_PRE as Single         ' [1101] primary axial force
       Dim m_YS as Single          ' [1001] y-eccentricity of centre of gravity
       Dim m_ZS as Single          ' [1001] z-eccentricity of centre of gravity
       Dim m_ECM as Single         '        warping stiffness
       Dim m_GCMS as Single        '        secondary torsion
       Dim m_NI as Single          ' [1101] inner normal force
       Dim m_VYI as Single         ' [1102] inner y-shear force
       Dim m_VZI as Single         ' [1102] inner z-shear force
       Dim m_MTI as Single         ' [1103] inner torsional moment
       Dim m_MYI as Single         ' [1104] inner bending moment My
       Dim m_MZI as Single         ' [1104] inner bending moment Mz
       Dim m_MBI as Single         ' [1105] inner warping moment Mb
       Dim m_E0 as Single          ' [1081] total strain x
       Dim m_GKPY as Single        ' [  17] total curvature y
       Dim m_GKPZ as Single        ' [  17] total curvature z
       Dim m_KFVY as Single        '        plastic factor V-y
       Dim m_KFVZ as Single        '        plastic factor V-z
       Dim m_KFMT as Single        '        plastic factor M-t
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_0() as Single '        Crisfield increments of current step di
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_1() as Single '        Crisfield increments of last step di-1
       Dim m_I_54 as Single        '        unused
       Dim m_ERF_MIN as Single     ' [1081] minimum strain reinf.
       Dim m_ERF_MAX as Single     ' [1081] maximum strain reinf.
       Dim m_HC as Single          ' [   8] relative compressive zone height
       Dim m_CCW as Single         ' [1026] current crack opening
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)> Dim m_I_59() as Single '        unused
      END Structure

      Structure CBSLN_STI          ' 123/LC  Stiffness of beams
       Dim m_NR as Integer         '        beam number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_EA as Single          ' [  62] normal stiffness
       Dim m_GAY as Single         ' [  62] y-shear stiffness
       Dim m_GAZ as Single         ' [  62] z-shear stiffness
       Dim m_GIT as Single         ' [  83] torsional stiffness
       Dim m_EIY as Single         ' [  83] bending stiffness y
       Dim m_EIZ as Single         ' [  83] bending stiffness z
       Dim m_EIYZ as Single        ' [  83] bending stiffness yz
       Dim m_GAYZ as Single        ' [  62] yz-shear stiffness
       Dim m_KPX as Single         ' [   8] plastic strain x
       Dim m_KPY as Single         ' [  17] plastic curvature y
       Dim m_KPZ as Single         ' [  17] plastic curvature z
       Dim m_EMIN as Single        ' [1081] minimum strain
       Dim m_EMAX as Single        ' [1081] maximum strain
       Dim m_GE1 as Single         ' [1101] Residual of current step (Crisfield)
       Dim m_GE2 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_GE3 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_EA0 as Single         ' [  83] lin. stiffness EA
       Dim m_EIY0 as Single        ' [  83] lin. stiffness EIy
       Dim m_EIZ0 as Single        ' [  83] lin. stiffness EIz
       Dim m_DYSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_DZSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_PRE as Single         ' [1101] primary axial force
       Dim m_YS as Single          ' [1001] y-eccentricity of centre of gravity
       Dim m_ZS as Single          ' [1001] z-eccentricity of centre of gravity
       Dim m_ECM as Single         '        warping stiffness
       Dim m_GCMS as Single        '        secondary torsion
       Dim m_NI as Single          ' [1101] inner normal force
       Dim m_VYI as Single         ' [1102] inner y-shear force
       Dim m_VZI as Single         ' [1102] inner z-shear force
       Dim m_MTI as Single         ' [1103] inner torsional moment
       Dim m_MYI as Single         ' [1104] inner bending moment My
       Dim m_MZI as Single         ' [1104] inner bending moment Mz
       Dim m_MBI as Single         ' [1105] inner warping moment Mb
       Dim m_E0 as Single          ' [1081] total strain x
       Dim m_GKPY as Single        ' [  17] total curvature y
       Dim m_GKPZ as Single        ' [  17] total curvature z
       Dim m_KFVY as Single        '        plastic factor V-y
       Dim m_KFVZ as Single        '        plastic factor V-z
       Dim m_KFMT as Single        '        plastic factor M-t
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_0() as Single '        Crisfield increments of current step di
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_1() as Single '        Crisfield increments of last step di-1
       Dim m_I_54 as Single        '        unused
       Dim m_ERF_MIN as Single     ' [1081] minimum strain reinf.
       Dim m_ERF_MAX as Single     ' [1081] maximum strain reinf.
       Dim m_HC as Single          ' [   8] relative compressive zone height
       Dim m_CCW as Single         ' [1026] current crack opening
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)> Dim m_I_59() as Single '        unused
      END Structure

      Structure CBSCT_STI          ' 143/LC  Stiffness of beams
       Dim m_NR as Integer         '        beam number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_EA as Single          ' [  62] normal stiffness
       Dim m_GAY as Single         ' [  62] y-shear stiffness
       Dim m_GAZ as Single         ' [  62] z-shear stiffness
       Dim m_GIT as Single         ' [  83] torsional stiffness
       Dim m_EIY as Single         ' [  83] bending stiffness y
       Dim m_EIZ as Single         ' [  83] bending stiffness z
       Dim m_EIYZ as Single        ' [  83] bending stiffness yz
       Dim m_GAYZ as Single        ' [  62] yz-shear stiffness
       Dim m_KPX as Single         ' [   8] plastic strain x
       Dim m_KPY as Single         ' [  17] plastic curvature y
       Dim m_KPZ as Single         ' [  17] plastic curvature z
       Dim m_EMIN as Single        ' [1081] minimum strain
       Dim m_EMAX as Single        ' [1081] maximum strain
       Dim m_GE1 as Single         ' [1101] Residual of current step (Crisfield)
       Dim m_GE2 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_GE3 as Single         ' [1104] Residual of current step (Crisfield)
       Dim m_EA0 as Single         ' [  83] lin. stiffness EA
       Dim m_EIY0 as Single        ' [  83] lin. stiffness EIy
       Dim m_EIZ0 as Single        ' [  83] lin. stiffness EIz
       Dim m_DYSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_DZSM as Single        ' [1011] ordinate shear centre to gravity centre
       Dim m_PRE as Single         ' [1101] primary axial force
       Dim m_YS as Single          ' [1001] y-eccentricity of centre of gravity
       Dim m_ZS as Single          ' [1001] z-eccentricity of centre of gravity
       Dim m_ECM as Single         '        warping stiffness
       Dim m_GCMS as Single        '        secondary torsion
       Dim m_NI as Single          ' [1101] inner normal force
       Dim m_VYI as Single         ' [1102] inner y-shear force
       Dim m_VZI as Single         ' [1102] inner z-shear force
       Dim m_MTI as Single         ' [1103] inner torsional moment
       Dim m_MYI as Single         ' [1104] inner bending moment My
       Dim m_MZI as Single         ' [1104] inner bending moment Mz
       Dim m_MBI as Single         ' [1105] inner warping moment Mb
       Dim m_E0 as Single          ' [1081] total strain x
       Dim m_GKPY as Single        ' [  17] total curvature y
       Dim m_GKPZ as Single        ' [  17] total curvature z
       Dim m_KFVY as Single        '        plastic factor V-y
       Dim m_KFVZ as Single        '        plastic factor V-z
       Dim m_KFMT as Single        '        plastic factor M-t
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_0() as Single '        Crisfield increments of current step di
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_1() as Single '        Crisfield increments of last step di-1
       Dim m_I_54 as Single        '        unused
       Dim m_ERF_MIN as Single     ' [1081] minimum strain reinf.
       Dim m_ERF_MAX as Single     ' [1081] maximum strain reinf.
       Dim m_HC as Single          ' [   8] relative compressive zone height
       Dim m_CCW as Single         ' [1026] current crack opening
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)> Dim m_I_59() as Single '        unused
      END Structure

      Structure CBEAM_CRC          ' 104/LC:0  Parameter of creep interval for each material
       Dim m_ID as Integer         '        identifier 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_EXP as Integer        '        exposition class of explicit curve
       Dim m_T as Single           ' [  93] absolute age
       Dim m_PHI as Single         '        creep coefficient
       Dim m_EPS as Single         '        shrinkage
       Dim m_RH as Single          ' [   8] relative moisture
       Dim m_TEMP as Single        ' [   6] temperature
       Dim m_TWA as Single         ' [  93] effective age start
       Dim m_TWE as Single         ' [  93] effective age end
       Dim m_BETH as Single        '        creep coefficient beta-h
       Dim m_TS as Single          ' [  93] start date of drying
       Dim m_TC as Single          ' [  93] start date of loading
      END Structure

      Structure CBSLN_CRC          ' 124/LC:0  Parameter of creep interval for each material
       Dim m_ID as Integer         '        identifier 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_EXP as Integer        '        exposition class of explicit curve
       Dim m_T as Single           ' [  93] absolute age
       Dim m_PHI as Single         '        creep coefficient
       Dim m_EPS as Single         '        shrinkage
       Dim m_RH as Single          ' [   8] relative moisture
       Dim m_TEMP as Single        ' [   6] temperature
       Dim m_TWA as Single         ' [  93] effective age start
       Dim m_TWE as Single         ' [  93] effective age end
       Dim m_BETH as Single        '        creep coefficient beta-h
       Dim m_TS as Single          ' [  93] start date of drying
       Dim m_TC as Single          ' [  93] start date of loading
      END Structure

      Structure CBSCT_CRC          ' 144/LC:0  Parameter of creep interval for each material
       Dim m_ID as Integer         '        identifier 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_EXP as Integer        '        exposition class of explicit curve
       Dim m_T as Single           ' [  93] absolute age
       Dim m_PHI as Single         '        creep coefficient
       Dim m_EPS as Single         '        shrinkage
       Dim m_RH as Single          ' [   8] relative moisture
       Dim m_TEMP as Single        ' [   6] temperature
       Dim m_TWA as Single         ' [  93] effective age start
       Dim m_TWE as Single         ' [  93] effective age end
       Dim m_BETH as Single        '        creep coefficient beta-h
       Dim m_TS as Single          ' [  93] start date of drying
       Dim m_TC as Single          ' [  93] start date of loading
      END Structure

      Structure CBEAM_CRF          ' 104/LC:+  resulting forces of redistribution
       Dim m_NR as Integer         '        beamnumber
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SDNI as Single        ' [1101] total normal force
       Dim m_SDVY as Single        ' [1102] total y-shear force
       Dim m_SDVZ as Single        ' [1102] total z-shear force
       Dim m_SDMT as Single        ' [1103] total torsion moment
       Dim m_SDMY as Single        ' [1104] total bending moment
       Dim m_SDMZ as Single        ' [1104] total bending moment
       Dim m_SRNI as Single        ' [1101] relat. normal force
       Dim m_SRVY as Single        ' [1102] relat. y-shear force
       Dim m_SRVZ as Single        ' [1102] relat. y-shear force
       Dim m_SRMT as Single        ' [1103] relat. torsionmoment
       Dim m_SRMY as Single        ' [1104] relat. bendingmoment
       Dim m_SRMZ as Single        ' [1104] relat. bendingmoment
      END Structure

      Structure CBSLN_CRF          ' 124/LC:+  resulting forces of redistribution
       Dim m_NR as Integer         '        beamnumber
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SDNI as Single        ' [1101] total normal force
       Dim m_SDVY as Single        ' [1102] total y-shear force
       Dim m_SDVZ as Single        ' [1102] total z-shear force
       Dim m_SDMT as Single        ' [1103] total torsion moment
       Dim m_SDMY as Single        ' [1104] total bending moment
       Dim m_SDMZ as Single        ' [1104] total bending moment
       Dim m_SRNI as Single        ' [1101] relat. normal force
       Dim m_SRVY as Single        ' [1102] relat. y-shear force
       Dim m_SRVZ as Single        ' [1102] relat. y-shear force
       Dim m_SRMT as Single        ' [1103] relat. torsionmoment
       Dim m_SRMY as Single        ' [1104] relat. bendingmoment
       Dim m_SRMZ as Single        ' [1104] relat. bendingmoment
      END Structure

      Structure CBSCT_CRF          ' 144/LC:+  resulting forces of redistribution
       Dim m_NR as Integer         '        beamnumber
       Dim m_ID as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SDNI as Single        ' [1101] total normal force
       Dim m_SDVY as Single        ' [1102] total y-shear force
       Dim m_SDVZ as Single        ' [1102] total z-shear force
       Dim m_SDMT as Single        ' [1103] total torsion moment
       Dim m_SDMY as Single        ' [1104] total bending moment
       Dim m_SDMZ as Single        ' [1104] total bending moment
       Dim m_SRNI as Single        ' [1101] relat. normal force
       Dim m_SRVY as Single        ' [1102] relat. y-shear force
       Dim m_SRVZ as Single        ' [1102] relat. y-shear force
       Dim m_SRMT as Single        ' [1103] relat. torsionmoment
       Dim m_SRMY as Single        ' [1104] relat. bendingmoment
       Dim m_SRMZ as Single        ' [1104] relat. bendingmoment
      END Structure

      Structure CBEAM_TSN          ' 104/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        10000+materialnumber
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBSLN_TSN          ' 124/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        10000+materialnumber
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBSCT_TSN          ' 144/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        10000+materialnumber
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBEAM_CRP          ' 104/LC:+  forces on sectional parts per material
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DNI as Single         ' [1101] impr. normal force
       Dim m_DMYI as Single        ' [1104] impr. bending moment
       Dim m_DMZI as Single        ' [1104] impr. bending moment
       Dim m_NI as Single          ' [1101] total normal force
       Dim m_MYI as Single         ' [1104] total bending moment
       Dim m_MZI as Single         ' [1104] total bending moment
       Dim m_SDNI as Single        ' [1192] stress plane parameter from (DNI:DMZI)
       Dim m_SDMYI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SDMZI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SNI as Single         ' [1192] stress plane parameter from (NI:MZI)
       Dim m_SMYI as Single        ' [1193] stress plane parameter from (NI:MZI)
       Dim m_SMZI as Single        ' [1193] stress plane parameter from (NI:MZI)
      END Structure

      Structure CBSLN_CRP          ' 124/LC:+  forces on sectional parts per material
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DNI as Single         ' [1101] impr. normal force
       Dim m_DMYI as Single        ' [1104] impr. bending moment
       Dim m_DMZI as Single        ' [1104] impr. bending moment
       Dim m_NI as Single          ' [1101] total normal force
       Dim m_MYI as Single         ' [1104] total bending moment
       Dim m_MZI as Single         ' [1104] total bending moment
       Dim m_SDNI as Single        ' [1192] stress plane parameter from (DNI:DMZI)
       Dim m_SDMYI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SDMZI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SNI as Single         ' [1192] stress plane parameter from (NI:MZI)
       Dim m_SMYI as Single        ' [1193] stress plane parameter from (NI:MZI)
       Dim m_SMZI as Single        ' [1193] stress plane parameter from (NI:MZI)
      END Structure

      Structure CBSCT_CRP          ' 144/LC:+  forces on sectional parts per material
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DNI as Single         ' [1101] impr. normal force
       Dim m_DMYI as Single        ' [1104] impr. bending moment
       Dim m_DMZI as Single        ' [1104] impr. bending moment
       Dim m_NI as Single          ' [1101] total normal force
       Dim m_MYI as Single         ' [1104] total bending moment
       Dim m_MZI as Single         ' [1104] total bending moment
       Dim m_SDNI as Single        ' [1192] stress plane parameter from (DNI:DMZI)
       Dim m_SDMYI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SDMZI as Single       ' [1193] stress plane parameter from (DNI:DMZI)
       Dim m_SNI as Single         ' [1192] stress plane parameter from (NI:MZI)
       Dim m_SMYI as Single        ' [1193] stress plane parameter from (NI:MZI)
       Dim m_SMZI as Single        ' [1193] stress plane parameter from (NI:MZI)
      END Structure

      Structure CBEAM_CRT          ' 104/LC:+  changes of tensional force
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        neg. tendonnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DZZ as Single         ' [1092] change of stress to prestress
       Dim m_DZR as Single         ' [1092] rel. change of stress to concrete strain
       Dim m_DZ as Single          ' [1101] rel. change of force from mean strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DZFAK() as Single '        ordinates, inclinations to evaluate forces
      END Structure

      Structure CBSLN_CRT          ' 124/LC:+  changes of tensional force
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        neg. tendonnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DZZ as Single         ' [1092] change of stress to prestress
       Dim m_DZR as Single         ' [1092] rel. change of stress to concrete strain
       Dim m_DZ as Single          ' [1101] rel. change of force from mean strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DZFAK() as Single '        ordinates, inclinations to evaluate forces
      END Structure

      Structure CBSCT_CRT          ' 144/LC:+  changes of tensional force
       Dim m_NR as Integer         '        beamnumber
       Dim m_NRS as Integer        '        neg. tendonnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_DZZ as Single         ' [1092] change of stress to prestress
       Dim m_DZR as Single         ' [1092] rel. change of stress to concrete strain
       Dim m_DZ as Single          ' [1101] rel. change of force from mean strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DZFAK() as Single '        ordinates, inclinations to evaluate forces
      END Structure

      Structure CBEAM_STC          ' 105/LC:0  Maximum stresses in cross-section of beams
       Dim m_NR as Integer         '        Ident 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance to start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial comp stress
       Dim m_SIGU as Single        ' [1092] uniaxial tens stress
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling intensity
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
      END Structure

      Structure CBSLN_STC          ' 125/LC:0  Maximum stresses in cross-section of beams
       Dim m_NR as Integer         '        Ident 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance to start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial comp stress
       Dim m_SIGU as Single        ' [1092] uniaxial tens stress
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling intensity
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
      END Structure

      Structure CBSCT_STC          ' 145/LC:0  Maximum stresses in cross-section of beams
       Dim m_NR as Integer         '        Ident 0
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance to start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial comp stress
       Dim m_SIGU as Single        ' [1092] uniaxial tens stress
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling intensity
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
      END Structure

      Structure CBEAM_TST          ' 105/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        100000 + material number as in BSCT_STC
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBSLN_TST          ' 125/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        100000 + material number as in BSCT_STC
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBSCT_TST          ' 145/LC:+  thermal eigen stress per material
       Dim m_NR as Integer         '        element number
       Dim m_MNRX as Integer       '        100000 + material number as in BSCT_STC
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_TS() as Single ' [1092] Eigenstress table (z,sig)
      END Structure

      Structure CBEAM_STR          ' 105/LC:+  Stresses in cross-section of beams
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial stress up
       Dim m_SIGU as Single        ' [1092] uniaxial stress down
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling effects
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
       Dim m_RCTRL as Single       '        control value of stress/strain description
       Dim m_ES0 as Single         '        strain in center of total section
       Dim m_ESY as Single         '        strain gradient in y-direction
       Dim m_ESZ as Single         '        strain gradient in z-direction
       Dim m_YC as Single          ' [1011] location of center of partial section
       Dim m_ZC as Single          ' [1011] location of center of partial section
       Dim m_ESW as Single         '        factor for unit warping
       Dim m_VYF as Single         ' [1102] shear force
       Dim m_VZF as Single         ' [1102] shear force
       Dim m_MTF as Single         ' [1103] primary torsional moment
       Dim m_MT2F as Single        ' [1103] secondary torsional moment
      END Structure

      Structure CBSLN_STR          ' 125/LC:+  Stresses in cross-section of beams
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial stress up
       Dim m_SIGU as Single        ' [1092] uniaxial stress down
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling effects
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
       Dim m_RCTRL as Single       '        control value of stress/strain description
       Dim m_ES0 as Single         '        strain in center of total section
       Dim m_ESY as Single         '        strain gradient in y-direction
       Dim m_ESZ as Single         '        strain gradient in z-direction
       Dim m_YC as Single          ' [1011] location of center of partial section
       Dim m_ZC as Single          ' [1011] location of center of partial section
       Dim m_ESW as Single         '        factor for unit warping
       Dim m_VYF as Single         ' [1102] shear force
       Dim m_VZF as Single         ' [1102] shear force
       Dim m_MTF as Single         ' [1103] primary torsional moment
       Dim m_MT2F as Single        ' [1103] secondary torsional moment
      END Structure

      Structure CBSCT_STR          ' 145/LC:+  Stresses in cross-section of beams
       Dim m_NR as Integer         '        beamnumber
       Dim m_MNR as Integer        '        materialnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_SIGC as Single        ' [1092] compressive stress
       Dim m_SIGT as Single        ' [1092] tensile stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGV as Single        ' [1092] reference stress
       Dim m_SI as Single          ' [1092] main tension stress
       Dim m_SII as Single         ' [1092] main compress stress
       Dim m_SIGO as Single        ' [1092] uniaxial stress up
       Dim m_SIGU as Single        ' [1092] uniaxial stress down
       Dim m_DSIG as Single        ' [1092] sway of normal stress
       Dim m_DTAU as Single        ' [1092] sway of shear stress
       Dim m_SIGW as Single        ' [1092] stress in weldings
       Dim m_VB as Single          ' [1153] Bond force
       Dim m_BUCK as Single        '        buckling effects
       Dim m_I_14 as Single        '        reserved
       Dim m_SIGCT as Single       ' [1092] decompression stress
       Dim m_RCTRL as Single       '        control value of stress/strain description
       Dim m_ES0 as Single         '        strain in center of total section
       Dim m_ESY as Single         '        strain gradient in y-direction
       Dim m_ESZ as Single         '        strain gradient in z-direction
       Dim m_YC as Single          ' [1011] location of center of partial section
       Dim m_ZC as Single          ' [1011] location of center of partial section
       Dim m_ESW as Single         '        factor for unit warping
       Dim m_VYF as Single         ' [1102] shear force
       Dim m_VZF as Single         ' [1102] shear force
       Dim m_MTF as Single         ' [1103] primary torsional moment
       Dim m_MT2F as Single        ' [1103] secondary torsional moment
      END Structure

      Structure CBEAM_RF0          ' 106/DC:0  max. values of reinforcement
       Dim m_NR as Integer         '        identifier 0
       Dim m_NVERS as Integer      '        Version number
       Dim m_ASLMAX as Single      ' [1021] maximum longitudinal reinforcement
       Dim m_ASBMAX as Single      ' [1021] maximum of transverse reinforcement reinforcement
       Dim m_VMMAX as Single       ' [1001] maximum of shift rule offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CBSLN_RF0          ' 126/DC:0  max. values of reinforcement
       Dim m_NR as Integer         '        identifier 0
       Dim m_NVERS as Integer      '        Version number
       Dim m_ASLMAX as Single      ' [1021] maximum longitudinal reinforcement
       Dim m_ASBMAX as Single      ' [1021] maximum of transverse reinforcement reinforcement
       Dim m_VMMAX as Single       ' [1001] maximum of shift rule offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CBSCT_RF0          ' 146/DC:0  max. values of reinforcement
       Dim m_NR as Integer         '        identifier 0
       Dim m_NVERS as Integer      '        Version number
       Dim m_ASLMAX as Single      ' [1021] maximum longitudinal reinforcement
       Dim m_ASBMAX as Single      ' [1021] maximum of transverse reinforcement reinforcement
       Dim m_VMMAX as Single       ' [1001] maximum of shift rule offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CTRUS_RF0          ' 156/DC:0  max. values of reinforcement
       Dim m_NR as Integer         '        identifier 0
       Dim m_NVERS as Integer      '        Version number
       Dim m_ASLMAX as Single      ' [1021] maximum longitudinal reinforcement
       Dim m_ASBMAX as Single      ' [1021] maximum of transverse reinforcement reinforcement
       Dim m_VMMAX as Single       ' [1001] maximum of shift rule offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CCABL_RF0          ' 166/DC:0  max. values of reinforcement
       Dim m_NR as Integer         '        identifier 0
       Dim m_NVERS as Integer      '        Version number
       Dim m_ASLMAX as Single      ' [1021] maximum longitudinal reinforcement
       Dim m_ASBMAX as Single      ' [1021] maximum of transverse reinforcement reinforcement
       Dim m_VMMAX as Single       ' [1001] maximum of shift rule offset
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CBEAM_RFI          ' 106/DC:+  info of reinforcement of beam
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        info id = 0
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() as Integer '        infos for longitudinal layers 0:9
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() as Integer '        infos for transverse reinforcement layers 1:15
      END Structure

      Structure CBSLN_RFI          ' 126/DC:+  info of reinforcement of design element sect.
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        info id = 0
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() as Integer '        infos for longitudinal layers 0:9
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() as Integer '        infos for transverse reinforcement layers 1:15
      END Structure

      Structure CBSCT_RFI          ' 146/DC:+  info of reinforcement of external section
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        info id = 0
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() as Integer '        infos for longitudinal layers 0:9
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() as Integer '        infos for transverse reinforcement layers 1:15
      END Structure

      Structure CTRUS_RFI          ' 156/DC:+  info of reinforcement of truss
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        info id = 0
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() as Integer '        infos for longitudinal layers 0:9
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() as Integer '        infos for transverse reinforcement layers 1:15
      END Structure

      Structure CCABL_RFI          ' 166/DC:+  info of reinforcement of cables
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        info id = 0
       Dim m_X as Single           ' [1001] distance from start
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() as Integer '        infos for longitudinal layers 0:9
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() as Integer '        infos for transverse reinforcement layers 1:15
      END Structure

      Structure CBEAM_RFC          ' 106/DC:+  reinforcement of beam
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        section number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_ASUM as Single        ' [1020] Total longitudinal reinforcement
       Dim m_ATOR as Single        ' [1021] maximum of torsional reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() as Single ' [1020] Area of layer 0:9
       Dim m_VM as Single          ' [1001] shift rule offset
       Dim m_ASBMAX as Single      ' [1021] maximum of all transverse reinforcement areas
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() as Single ' [1021] transverse reinforcements
      END Structure

      Structure CBSLN_RFC          ' 126/DC:+  reinforcement of design element section
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        section number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_ASUM as Single        ' [1020] Total longitudinal reinforcement
       Dim m_ATOR as Single        ' [1021] maximum of torsional reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() as Single ' [1020] Area of layer 0:9
       Dim m_VM as Single          ' [1001] shift rule offset
       Dim m_ASBMAX as Single      ' [1021] maximum of all transverse reinforcement areas
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() as Single ' [1021] transverse reinforcements
      END Structure

      Structure CBSCT_RFC          ' 146/DC:+  reinforcement of external section
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        section number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_ASUM as Single        ' [1020] Total longitudinal reinforcement
       Dim m_ATOR as Single        ' [1021] maximum of torsional reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() as Single ' [1020] Area of layer 0:9
       Dim m_VM as Single          ' [1001] shift rule offset
       Dim m_ASBMAX as Single      ' [1021] maximum of all transverse reinforcement areas
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() as Single ' [1021] transverse reinforcements
      END Structure

      Structure CTRUS_RFC          ' 156/DC:+  reinforcement of truss
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        section number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_ASUM as Single        ' [1020] Total longitudinal reinforcement
       Dim m_ATOR as Single        ' [1021] maximum of torsional reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() as Single ' [1020] Area of layer 0:9
       Dim m_VM as Single          ' [1001] shift rule offset
       Dim m_ASBMAX as Single      ' [1021] maximum of all transverse reinforcement areas
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() as Single ' [1021] transverse reinforcements
      END Structure

      Structure CCABL_RFC          ' 166/DC:+  reinforcement of cables
       Dim m_NR as Integer         '        beamnumber
       Dim m_NQ as Integer         '        section number
       Dim m_X as Single           ' [1001] distance from start
       Dim m_ASUM as Single        ' [1020] Total longitudinal reinforcement
       Dim m_ATOR as Single        ' [1021] maximum of torsional reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() as Single ' [1020] Area of layer 0:9
       Dim m_VM as Single          ' [1001] shift rule offset
       Dim m_ASBMAX as Single      ' [1021] maximum of all transverse reinforcement areas
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() as Single ' [1021] transverse reinforcements
      END Structure

      Structure CBEAM_DE0          ' 107/LC:0  max. values of Ultimate/Plastic Design results
       Dim m_NR as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBSLN_DE0          ' 127/LC:0  max. values of Ultimate/Plastic Design results
       Dim m_NR as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBSCT_DE0          ' 147/LC:0  max. values of Ultimate/Plastic Design results
       Dim m_NR as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CTRUS_DE0          ' 157/LC:0  max. values of Ultimate/Plastic Design results
       Dim m_NR as Integer         '        identifier 0
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBEAM_DES          ' 107/LC:+  Ultimate/Plastic Design results
       Dim m_NR as Integer         '        elementnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBSLN_DES          ' 127/LC:+  Ultimate/Plastic Design results
       Dim m_NR as Integer         '        elementnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBSCT_DES          ' 147/LC:+  Ultimate/Plastic Design results
       Dim m_NR as Integer         '        elementnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CTRUS_DES          ' 157/LC:+  Ultimate/Plastic Design results
       Dim m_NR as Integer         '        elementnumber
       Dim m_X as Single           ' [1001] distance from start
       Dim m_NI as Single          ' [1101] Inner normal force
       Dim m_MYI as Single         ' [1104] bending moment My
       Dim m_MZI as Single         ' [1104] bending moment My
       Dim m_SCF as Single         '        relative capacity
       Dim m_E0 as Single          ' [   9] strain at center
       Dim m_EY as Single          ' [1009] curvature y direct.
       Dim m_EZ as Single          ' [1009] curvature z direct.
       Dim m_E1 as Single          ' [   9] compressive strain
       Dim m_E2 as Single          ' [   9] tensional   strain
       Dim m_HL as Single          ' [1011] lever of forces
       Dim m_HVM as Single         ' [1001] shift rule value
       Dim m_HX as Single          ' [1001] height of compression zone   (NSTR-Analysis)
       Dim m_EDCMIN as Single      ' [   9] minimum decompression strain (NSTR-Analysis)
       Dim m_EDCMAX as Single      ' [   9] maximum decompression strain (NSTR-Analysis)
       Dim m_FCHK as Single        ' [1092] not used
       Dim m_TCF as Single         '        total utilisation level (all effects)
       Dim m_SCN as Single         '        utilisation level  (1) N/Npl
       Dim m_SCVY as Single        '        utilisation level  (2) Vy/Vypl
       Dim m_SCVZ as Single        '        utilisation level  (3) Vz/Vzpl
       Dim m_SCMT as Single        '        utilisation level  (4) Mt/Mtpl
       Dim m_SCMY as Single        '        utilisation level  (5) My/Mypl
       Dim m_SCMZ as Single        '        utilisation level  (6) Mz/Mzpl
       Dim m_SCMB as Single        '        utilisation level  (7) Mb/Mbpl
       Dim m_SCT2 as Single        '        utilisation level  (8) Mt2/Mt2pl
       Dim m_SCCOMB as Single      '        utilisation level  (9) TOTAL INTERACTION
       Dim m_SCBN as Single        '        utilisation level (10) buckling / torsional buckling
       Dim m_CSIGC as Single       '        utilisation level (11) sig-c/fy
       Dim m_CSIGT as Single       '        utilisation level (12) sig-t/fy
       Dim m_CTAU as Single        '        utilisation level (13) tau/tauy
       Dim m_CSGV as Single        '        utilisation level (14) sigv/fy (von Mises)
       Dim m_CSGR as Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
       Dim m_CAS as Single         '        utilisation level (16) As/As-provided (long.Reinforc)
       Dim m_CASL as Single        '        utilisation level (17) Asv/Asv-provided (transverse reinf)
       Dim m_CCW as Single         '        utilisation level (18) As/As-provided for crack width
       Dim m_CSGD as Single        '        utilisation level (19) sig-d (dynamic stress range)
       Dim m_CTAU0 as Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
       Dim m_C2T as Single         '        utilisation level (21) plate slenderness (c/t)
       Dim m_CLASS as Single       '        highest criteria for section class
      END Structure

      Structure CBEAM_PIF          ' 108/LC  reducing factors of stiffness
       Dim m_NR as Integer         '        pilenumber
       Dim m_REDP as Single        '        reducing factor of stiffness
       Dim m_REDA as Single        '        reducing factor of axial bedding
       Dim m_REDQ as Single        '        reducing factor of cross bedding
      END Structure

      Structure CBEAM_HR0          ' 111/LC:0  Maximum of Implicit Hinge Reactions
       Dim m_ID as Integer         '        identifier 0
       Dim m_TYP as Integer        '        type of hinge
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBIT() as Integer '        reserved
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_REAC as Single        '        extremal reaction force/ moment
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_STV() as Single '        extremal values of statevar's
      END Structure

      Structure CBEAM_HRC          ' 111/LC:+  Implicit Hinge Reactions
       Dim m_NR as Integer         '        beamnumber
       Dim m_TYP as Integer        '        type of hinge
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBIT() as Integer '        reserved
       Dim m_X as Single           ' [1001] hinge location, beam abscissa value
       Dim m_REAC as Single        '        reaction force/ moment
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_STV() as Single '        statevar's
      END Structure

      Structure CBEAM_MP0          ' 115/LC:0  Extremal values of cross-sectional material point reactions
       Dim m_NR as Integer         '        identifier 0
       Dim m_TYPE as Integer       '        type: reinforcement=1, base material point=0
       Dim m_MNO as Integer        '        material number
       Dim m_MRF as Integer        '        material number reinforcement
       Dim m_NPTS as Integer       '        number of base material points
       Dim m_NRF as Integer        '        Anzahl Materialpunkte Bewehrung
       Dim m_X as Single           ' [1001] max. beam length
       Dim m_Y as Single           ' [1011] max. y-ccordinate
       Dim m_Z as Single           ' [1011] max. z-ccordinate
       Dim m_SIGX as Single        ' [1092] axial normal stress
       Dim m_TAUXY as Single       ' [1092] shear stress xy
       Dim m_TAUXZ as Single       ' [1092] shear stress xz
       Dim m_F0 as Single          '        utilization level
       Dim m_KAPAP as Single       ' [   9] equiv. plastic strain
       Dim m_KAPAD as Single       ' [   9] fracturing strain
       Dim m_CCW as Single         ' [1026] current crack opening
       Dim m_TEMP as Single        ' [   6] current temperature
       Dim m_TEMPMAX as Single     ' [   6] maximum temperature in loading history
       Dim m_EPS_S as Single       ' [   9] pure reinforcement strain (without TS strain correction)
       Dim m_EPS_TS as Single      ' [   9] tension stiffening strain correction (accumulated)
       Dim m_DUMMY as Single       '        unused
       Dim m_IZONE as Single       '        performance interval
       Dim m_EPST as Single        ' [   9] axial temperature strain
       Dim m_EPSX as Single        ' [   9] axial total strain (without temperature strain)
       Dim m_A_MPT as Single       ' [1012] associated material point area
       Dim m_FC_TEMP as Single     ' [1092] current compressive strength (temperature dependent)
       Dim m_FT_TEMP as Single     ' [1092] current tensile strength (temperature dependent)
      END Structure

      Structure CBEAM_MPT          ' 115/LC:+  Cross-sectional material point reactions
       Dim m_NR as Integer         '        beam number
       Dim m_TYPE as Integer       '        type: reinforcement=1, base material point=0
       Dim m_MNO as Integer        '        material number
       Dim m_MRF as Integer        '        material number reinforcement
       Dim m_NPTS as Integer       '        number of base material points
       Dim m_NRF as Integer        '        Anzahl Materialpunkte Bewehrung
       Dim m_X as Single           ' [1001] beam abscissa value
       Dim m_Y as Single           ' [1011] cross-sectional y-position
       Dim m_Z as Single           ' [1011] cross-sectional z-position
       Dim m_SIGX as Single        ' [1092] axial normal stress
       Dim m_TAUXY as Single       ' [1092] shear stress xy
       Dim m_TAUXZ as Single       ' [1092] shear stress xz
       Dim m_F0 as Single          '        utilization level
       Dim m_KAPAP as Single       ' [   9] equiv. plastic strain
       Dim m_KAPAD as Single       ' [   9] fracturing strain
       Dim m_CCW as Single         ' [1026] current crack opening
       Dim m_TEMP as Single        ' [   6] current temperature
       Dim m_TEMPMAX as Single     ' [   6] maximum temperature in loading history
       Dim m_EPS_S as Single       ' [   9] pure reinforcement strain (without TS strain correction)
       Dim m_EPS_TS as Single      ' [   9] tension stiffening strain correction (accumulated)
       Dim m_DUMMY as Single       '        unused
       Dim m_IZONE as Single       '        performance interval
       Dim m_EPST as Single        ' [   9] axial temperature strain
       Dim m_EPSX as Single        ' [   9] axial total strain (without temperature strain)
       Dim m_A_MPT as Single       ' [1012] associated material point area
       Dim m_FC_TEMP as Single     ' [1092] current compressive strength (temperature dependent)
       Dim m_FT_TEMP as Single     ' [1092] current tensile strength (temperature dependent)
      END Structure

      Structure CTRUS              ' 150/00  trusselements
       Dim m_NR as Integer         '        truss number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_NRQ as Integer        '        cross-section number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() as Single '        normal direction
       Dim m_DL as Single          ' [1001] length of truss
       Dim m_PRE as Single         ' [1101] prestress
       Dim m_GAP as Single         ' [1003] slip of element
       Dim m_RISS as Single        ' [1101] max tension force
       Dim m_FLIE as Single        ' [1101] yielding load
       Dim m_NREF as Integer       '        reference axis
      END Structure

      Structure CTRUS_LOA          ' 151/LC  Loads on truss elements
       Dim m_NR as Integer         '        truss number
       Dim m_TYP as Integer        '        type of load
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
      END Structure

      Structure CTRUS_RE0          ' 152/LC:0  maximum of results of truss elements
       Dim m_NR as Integer         '        identifier 0
       Dim m_N as Single           ' [1101] normal force
       Dim m_V as Single           ' [1003] axial displacement
      END Structure

      Structure CTRUS_RES          ' 152/LC:+  results of truss elements
       Dim m_NR as Integer         '        truss number
       Dim m_N as Single           ' [1101] normal force
       Dim m_V as Single           ' [1003] axial displacement
       Dim m_LEX as Single         '        nonlinear effect
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_DAMM() as Single '        Damage Parameter
      END Structure

      Structure CTRUS_ST0          ' 155/LC:0  checked truss stresses
       Dim m_NR as Integer         '        ident 0
       Dim m_MAT as Integer        '        Materialnumber
       Dim m_SIG as Single         ' [1092] normal stress
       Dim m_BUCK as Single        '        buckling intensity
      END Structure

      Structure CTRUS_STR          ' 155/LC:+  truss stress (AQB)
       Dim m_NR as Integer         '        trussingnumber
       Dim m_MAT as Integer        '        Materialnumber
       Dim m_SIG as Single         ' [1092] normal stress
       Dim m_BUCK as Single        '        buckling intensity
      END Structure

      Structure CCABL              ' 160/00  cable elements
       Dim m_NR as Integer         '        cable number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_NRQ as Integer        '        cross-section number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() as Single '        normal direction
       Dim m_DL as Single          ' [1001] length of cable
       Dim m_PRE as Single         ' [1101] prestress
       Dim m_GAP as Single         ' [1003] slip of element
       Dim m_RISS as Single        ' [1101] max tension force
       Dim m_FLIE as Single        ' [1101] yielding load
       Dim m_NREF as Integer       '        reference axis
      END Structure

      Structure CCABL_LOA          ' 161/LC  loads on cables
       Dim m_NR as Integer         '        cable number
       Dim m_TYP as Integer        '        type of load
       Dim m_PA as Single          '        start value of load
       Dim m_PE as Single          '        end value of load
      END Structure

      Structure CCABL_RE0          ' 162/LC:0  maximum results of cables
       Dim m_NR as Integer         '        identifier 0
       Dim m_N as Single           ' [1101] normal force
       Dim m_V as Single           ' [1003] axial displacement
       Dim m_VT as Single          ' [1003] maximum suspension of cable across axis
       Dim m_VTX as Single         ' [1003] suspension of cable, global X-component
       Dim m_VTY as Single         ' [1003] suspension of cable, global Y-component
       Dim m_VTZ as Single         ' [1003] suspension of cable, global Z-component
       Dim m_EPS0 as Single        '        maximum induced strain
      END Structure

      Structure CCABL_RES          ' 162/LC:+  results of cables
       Dim m_NR as Integer         '        cablenumber
       Dim m_N as Single           ' [1101] normal force
       Dim m_V as Single           ' [1003] axial displacement
       Dim m_VQ as Single          ' [1003] maximum suspension of cable across axis
       Dim m_VTX as Single         ' [1003] suspension of cable, global X-component
       Dim m_VTY as Single         ' [1003] suspension of cable, global Y-component
       Dim m_VTZ as Single         ' [1003] suspension of cable, global Z-component
       Dim m_EPS0 as Single        '        Total induced strain
       Dim m_N_M as Single         ' [1101] average normal force
       Dim m_F0 as Single          ' [1003] vertical suspension of cable in load direction
       Dim m_L0 as Single          ' [1001] relaxed cable length incl. temp. and prestrain effects
       Dim m_LEX as Single         '        nonlinear effect
       Dim m_EFFS as Single        '        effective stiffness factor due to cable sagging
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_DAMM() as Single '        Damage Parameter
      END Structure

      Structure CCABL_SLP          ' 163/00  slip cables
       Dim m_NRSL as Integer       '        slip cable number
       Dim m_NRG as Integer        '        group number
       Dim m_NREL as Integer       '        element number
       Dim m_FREE as Integer       '        free
       Dim m_MUE as Single         '        friction value
      END Structure

      Structure CCABL_ST0          ' 165/LC:0  checked cable stresses
       Dim m_NR as Integer         '        ident 0
       Dim m_MAT as Integer        '        Materialnumber
       Dim m_SIG as Single         ' [1092] normal stress
      END Structure

      Structure CCABL_STR          ' 165/LC:+  cable stresses (AQB)
       Dim m_NR as Integer         '        trussingnumber
       Dim m_MAT as Integer        '        Materialnumber
       Dim m_SIG as Single         ' [1092] normal stress
      END Structure

      Structure CSPRI              ' 170/00  Spring-elements
       Dim m_NR as Integer         '        springnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        start nodenumber
       Dim m_NRQ as Integer        '        Material/section no
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() as Single '        normal direction
       Dim m_AREF as Single        '        reference area
       Dim m_CP as Single          ' [1095] spring stiffness
       Dim m_CQ as Single          ' [1095] transverse stiff.
       Dim m_CM as Single          ' [1098] torsional stiff.
       Dim m_PRE as Single         '        prestress
       Dim m_GAP as Single         '        slip/gap of spring
       Dim m_RISS as Single        '        max tension force
       Dim m_FLIE as Single        '        yielding load
       Dim m_MUE as Single         '        friction cross
       Dim m_COH as Single         '        cohesion cross
       Dim m_DIL as Single         '        dilatancy factor
       Dim m_GAPQ as Single        '        transverse slip/gap
       Dim m_DP as Single          '        damping constant
       Dim m_DQ as Single          '        damping shear
       Dim m_DM as Single          '        damping moment
       Dim m_EXPP as Single        '        exponent for nonlinear damping dp**expp
       Dim m_EXPQ as Single        '        exponent for nonlinear damping dq**expq
       Dim m_EXPM as Single        '        exponent for nonlinear damping dm**expm
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TB() as Single '        rotational direction
       Dim m_NREF as Integer       '        additional bit code
      END Structure

      Structure CSPRI_RE0          ' 170/LC:0  maximum of results of spring-elements
       Dim m_ID as Integer         '        identifier
       Dim m_P as Single           ' [1151] maximum spring force
       Dim m_PT as Single          ' [1151] maximum spring transverse force
       Dim m_PTX as Single         ' [1151] maximum global X-shear component
       Dim m_PTY as Single         ' [1151] maximum global Y-shear component
       Dim m_PTZ as Single         ' [1151] maximum global Z-shear component
       Dim m_M as Single           ' [1152] maximum spring moment
       Dim m_V as Single           ' [1003] maximum axial displacement
       Dim m_VT as Single          ' [1003] maximum transverse displacement
       Dim m_VTX as Single         ' [1003] maximum trans displ., global X-component
       Dim m_VTY as Single         ' [1003] maximum trans displ., global Y-component
       Dim m_VTZ as Single         ' [1003] maximum trans displ., global Z-component
       Dim m_PHI as Single         ' [1004] rotation
      END Structure

      Structure CSPRI_RES          ' 170/LC:+  results of spring-elements
       Dim m_NR as Integer         '        springnumber
       Dim m_P as Single           ' [1151] spring force
       Dim m_PT as Single          ' [1151] spring transforce
       Dim m_PTX as Single         ' [1151] global X-shear component
       Dim m_PTY as Single         ' [1151] global Y-shear component
       Dim m_PTZ as Single         ' [1151] global Z-shear component
       Dim m_M as Single           ' [1152] spring moment
       Dim m_V as Single           ' [1003] axial displacement
       Dim m_VT as Single          ' [1003] trans. displacement
       Dim m_VTX as Single         ' [1003] trans. displacement, global X-component
       Dim m_VTY as Single         ' [1003] trans. displacement, global Y-component
       Dim m_VTZ as Single         ' [1003] trans. displacement, global Z-component
       Dim m_PHI as Single         ' [1004] rotation
       Dim m_LEX as Single         '        nonlinear effect
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVP() as Single '        State variable / Damage Parameter for CP
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVM() as Single '        State variable / Damage Parameter for CM
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVT() as Single '        State variable / Damage Parameter for CT
      END Structure

      Structure CDAMP              ' 171/00  Damping elements (DYNA)
       Dim m_NR as Integer         '        element number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_I_3 as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() as Single '        normal direction
       Dim m_AREF as Single        '        reference area
       Dim m_DP as Single          '        damping constant
       Dim m_DQ as Single          '        damping shear
       Dim m_DM as Single          '        damping moment
       Dim m_EXPP as Single        '        exponent for nonlinear damping dp**expp
       Dim m_EXPQ as Single        '        exponent for nonlinear damping dq**expq
       Dim m_EXPM as Single        '        exponent for nonlinear damping dm**expm
      END Structure

      Structure CMASS              ' 172/00  Persistent Nodal masses
       Dim m_NR as Integer         '        nodenumber
       Dim m_NRG as Integer        '        pseudoelementnumber IGDIV*Groupnr+IREF
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() as Single ' [  52] transversal mass mt-x,mt-y,mt-z
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_MR() as Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_MB() as Single '        warping  mass and higher coefficients
      END Structure

      Structure CMASS_ADD          ' 172/01  non persistent additional nodal masses
       Dim m_NR as Integer         '        nodenumber
       Dim m_NRG as Integer        '        pseudoelementnumber IGDIV*Groupnr+IREF
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() as Single ' [  52] transversal mass mt-x,mt-y,mt-z
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_MR() as Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_MB() as Single '        warping  mass and higher coefficients
      END Structure

      Structure CMASS_EFF          ' 172/LD:Z+  Effective nodal masses
       Dim m_NR as Integer         '        identifier
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() as Single ' [  52] transversal mass mt-x,mt-y,mt-z
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MR() as Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz
      END Structure

      Structure CMASS_EFC          ' 172/LD:-  Effective consistent masses
       Dim m_NR as Integer         '        identifier = negative number of nodes
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() as Integer '        node numbers
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1176)> Dim m_M() as Single '        mass matrix in triangular format
      END Structure

const SPRI_WL0_LTYP_STD = 1
const SPRI_WL0_LTYP_IHNG = 2
const SPRI_WL0_LTYP_PMM = 3
const SPRI_WL0_MTYP_PLAS = 1
const SPRI_WL0_MTYP_PISO = 2
const SPRI_WL0_MTYP_HYPE = 3
const SPRI_WL0_MTYP_PKIN = 4
      Structure CSPRI_WL0          ' 173/NR:0  (nonlinear) Spring material
       Dim m_ID as Integer         '        Identification = 0
       Dim m_LTYP as Integer       '        Type of link
       Dim m_MTYP as Integer       '        Type of law
       Dim m_ICAP as Integer       '        capacities from reference-section SNO
       Dim m_IBIT2 as Integer      '        reserved
       Dim m_IHBIT as Integer      '        Bitpattern of defined degrees of freedom for implicit hinges
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=14)> Dim m_RLIM() as Single ' [1105] 
       Dim m_ALPH as Single        '        Interpolation exponent My-Mz (PMM, only)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() as Single '        further reserved material parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() as Integer '        Designation
      END Structure

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
      Structure CSPRI_WL           ' 173/NR:+  Worklaw for nonlinear Springs
       Dim m_ID as Integer         '        Identification
       Dim m_NTYP as Integer       '        Type of law
       Dim m_PLVL as Single        ' [1101] Normal force reference level
       Dim m_EUR as Single         '        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_PAR() as Single '        further reserved material parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() as Single '        Function values
      END Structure

      Structure CSPRI_MOV          ' 174/00  Moving Springs
       Dim m_NR as Integer         '        spring element number
       Dim m_TYP as Integer        '        searching criteria
       Dim m_FROM as Integer       '        selection for TYP
       Dim m_TO as Integer         '        selection for TYP
       Dim m_INC as Integer        '        selection for TYP
      END Structure

      Structure CS_MATRIX          ' 175/00  General systemmatrices
       Dim m_NR as Integer         '        element number
       Dim m_TYP as Integer        '        element type
       Dim m_NDN as Integer        '        number of degrees of freedom per node
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_NODE() as Integer '        node numbers
       Dim m_PER as Single         ' [  90] period of matrix
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2048)> Dim m_S() as Single '        stiffness matrix
      END Structure

      Structure CBOUN              ' 180/00:+  Boundary elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_NVON as Integer       '        start nodenumber
       Dim m_NBIS as Integer       '        end nodenumber
       Dim m_NDEL as Integer       '        increment
       Dim m_TYP as Integer        '        type of bedding
       Dim m_MESS as Integer       '        direction of addition
       Dim m_CA as Single          '        start constant of bedding
       Dim m_CE as Single          '        end constant of bedding
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() as Single '        direction of bedding, X/Y/Z-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of element
      END Structure

      Structure CBOUN_RES          ' 180/LC  results of boundary elements
       Dim m_NR as Integer         '        element number
       Dim m_NK as Integer         '        nodenumber
       Dim m_PX as Single          ' [1153] X-support force
       Dim m_PY as Single          ' [1153] Y-support force
       Dim m_PZ as Single          ' [1153] Z-support force
       Dim m_MN as Single          ' [1154] support moment
      END Structure

      Structure CBOUN_SUM          ' 181/LC  resultant of boundary results
       Dim m_NR as Integer         '        element number
       Dim m_PX as Single          ' [1151] X-support force
       Dim m_PY as Single          ' [1151] X-support force
       Dim m_PZ as Single          ' [1151] X-support force
       Dim m_MN as Single          ' [1152] N-support moment
       Dim m_MX as Single          ' [1152] X-support moment
       Dim m_MY as Single          ' [1152] Y-support moment
       Dim m_MZ as Single          ' [1152] Z-support moment
      END Structure

      Structure CBOUN_LC_LPT       '        node number + load value
       Dim m_N as Integer
       Dim m_P as Single
      END Structure

      Structure CBOUN_LC           ' 183/LC  Info on loading on boundaries
       Dim m_NR as Integer         '        element number
       Dim m_TYP as Integer        '        type of load
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=127)> Dim m_LPT() as CBOUN_LC_LPT '        node number + load value
      END Structure

      Structure CSPRI_SUM          ' 187/LC  Sum of forces of support springs
       Dim m_NR as Integer         '        group-number
       Dim m_PX as Single          ' [1151] nodal support X
       Dim m_PY as Single          ' [1151] nodal support Y
       Dim m_PZ as Single          ' [1151] nodal support u
       Dim m_MX as Single          ' [1152] support moment X
       Dim m_MY as Single          ' [1152] support moment Y
       Dim m_MZ as Single          ' [1152] support moment Z
       Dim m_MB as Single          ' [1105] warping moment
      END Structure

      Structure CRSET              ' 188/00:+  Sets of results
       Dim m_ID as Integer         '        number / identifier of result set
       Dim m_NIT as Integer        '        number of items in that result set
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of that set
      END Structure

      Structure CRSET_ITM          ' 188/00:0  Member of result set
       Dim m_ID0 as Integer        '        Identifier = 0
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ID() as Integer '        Short name of member for headdings
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDS() as Integer '        Selector of main structure
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDM() as Integer '        Selector of item member
       Dim m_DIM as Integer        '        enum of explicitly selected unit
       Dim m_KWH as Integer        '        main id of result data
       Dim m_POS as Integer        '        position of value in data (starting at zero)
       Dim m_BIT as Integer        '        bit pattern of defined selection data
       Dim m_NR as Integer         '        main number of result data
       Dim m_NG as Integer         '        second number of result data (e.g. group)
       Dim m_ND1 as Integer        '        reserved for additional selection data
       Dim m_ND2 as Integer        '        reserved for additional selection data
       Dim m_ND3 as Integer        '        reserved for additional selection data
       Dim m_X as Single           '        selector for beam abscissae
      END Structure

      Structure CRSET_DAT          ' 188/LC  Result-values for sets of results
       Dim m_ID as Integer         '        identifier of result set
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_VAL() as Single '        result values
      END Structure

      Structure CLINK              ' 179/00  link elements
       Dim m_NR as Integer         '        pipenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_NRQ as Integer        '        material-, type- or cross-sectionnumber
       Dim m_DL as Single          ' [1001] length of pipe
       Dim m_A as Single           '        Nominal width or linear loss factor
       Dim m_B as Single           '        Abs. Roughness or quadratic loss factor
       Dim m_C as Single           '        specific storage coefficient
       Dim m_EPS as Single         '        emission coefficient
       Dim m_AREF as Single        ' [1002] reference area of element
      END Structure

      Structure CPIPE              ' 190/00  pipes / armatures
       Dim m_NR as Integer         '        pipenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_NRQ as Integer        '        material-, type- or cross-sectionnumber
       Dim m_DL as Single          ' [1001] length of pipe
       Dim m_A as Single           '        Nominal width or linear loss factor
       Dim m_B as Single           '        Abs. Roughness or quadratic loss factor
       Dim m_C as Single           '        specific storage coefficient
       Dim m_EPS as Single         '        emission coefficient
       Dim m_AREF as Single        ' [1002] reference area of element
      END Structure

      Structure CPIPE_RES          ' 190/LC  results of pipes
       Dim m_NR as Integer         '        pipenumber
       Dim m_HA as Single          ' [1010] start potential
       Dim m_HE as Single          ' [1010] end potential
       Dim m_I as Single           '        gradient
       Dim m_A as Single           ' [1012] flow area
       Dim m_PA as Single          ' [  70] start compression
       Dim m_PE as Single          ' [  70] end compression
       Dim m_Q as Single           ' [1211] flow quantity
       Dim m_V as Single           ' [1212] flow velocity
       Dim m_R as Single           ' [1011] hydraulic radius
       Dim m_K as Single           ' [1016] roughness
       Dim m_RE as Single          '        Reynolds number
       Dim m_FR as Single          '        Froud    number
      END Structure

const LEN_CQUAD0 = 27
      Structure CQUAD              ' 200/00  QuadElements
       Dim m_NR as Integer         '        elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_MAT as Integer        '        materialnumber
       Dim m_MRF as Integer        '        material Reinf.
       Dim m_NRA as Integer        '        type of element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() as Single '        Parameter of Jacobi Determinant
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() as Single ' [1010] element thickness
       Dim m_CB as Single          '        bedding factor
       Dim m_CQ as Single          '        tangential bedding factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
       Dim m_IFC1 as Integer       '        identifier of a most adjacent outer boundary
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DFC1() as Single ' [1001] distance of the nodes to the boundary IFC1
       Dim m_IFC2 as Integer       '        identifier of a most adjacent inner boundary
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DFC2() as Single ' [1001] distance of the nodes to the boundary IFC2
      END Structure

      Structure CQUAD_NOH          ' 200/1:0  unified properties of Quad-nodes
       Dim m_ID1 as Integer
       Dim m_ID2 as Integer
       Dim m_NKREC as Integer
       Dim m_MAXNEL as Integer
       Dim m_MAXUGR as Integer
       Dim m_MAXGR as Integer
       Dim m_NQUAD as Integer
       Dim m_MQUAD as Integer      '        Highest Number of Quadelement
      END Structure

      Structure CQUAD_NOM          ' 200/1:-  unified properties of Quad-nodes
       Dim m_NGT as Integer        '        groupselector
       Dim m_NR as Integer         '        nodenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IEL() as Integer '        connecting elements
      END Structure

      Structure CQUAD_NOD          ' 200/1:*  properties of Quad-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       Dim m_D as Single           ' [1010] minimum thickness of plate on node
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        lokal average coordinate system
      END Structure

      Structure CQUAD_EDH          ' 200/2:0  Edges of Quad-elements
       Dim m_ID1 as Integer
       Dim m_ID2 as Integer
       Dim m_NEDG as Integer
       Dim m_MQUA as Integer       '        max number of quads per edge
      END Structure

      Structure CQUAD_EDG          ' 200/2:+  Edges of Quad-elements
       Dim m_KA as Integer         '        First Node
       Dim m_KE as Integer         '        Last Node
       Dim m_IJMP as Integer       '        bit pattern of jump condition
       Dim m_NQUA as Integer       '        number of quads
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_NREL() as Integer '        Number of Quad-elements
      END Structure

      Structure CQUAD_TEN          ' 200/5  tendons of Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_NRS as Integer        '        tendon number
       Dim m_MNR as Integer        '        tendon material
       Dim m_IBA1 as Integer       '        construction stage number for placing
       Dim m_IBA2 as Integer       '        construction stage number for grouting
       Dim m_IBA3 as Integer       '        construction stage number for removing
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_R() as Single '        isoparametric coordinates start/end point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_S() as Single '        isoparametric coordinates start/end point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_Z() as Single ' [1011] eccentricity of the middle area
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ZZ() as Single ' [1101] tendon force, start- and endpoint
       Dim m_AZ as Single          ' [1020] area of tendon
       Dim m_UZ as Single          ' [1023] effect. periphery
       Dim m_AH as Single          ' [1020] area of duct
       Dim m_AR as Single          ' [1012] relative area
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DY() as Single '        gradient of tendon
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DZ() as Single '        gradient of tendon
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXZ() as Single ' [1011] perpendicular eccentricity of duct to tendon
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXY() as Single ' [1011] transverse eccentricity of duct to tendon
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SREF() as Single '        parameter values along tendon geometry
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_XYZT() as Single ' [1001] Coordinates of tendon start & endpoint
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_XYZH() as Single ' [1001] Coordinates of duct start & endpoint
      END Structure

      Structure CQUAD_RIM          ' 200/6  Prescribed Reinforcements of Quad-elements
       Dim m_NRG as Integer        '        group number
       Dim m_NR as Integer         '        selector number
       Dim m_TYP as Integer        '        Type of Reinforc.
       Dim m_GTYP as Integer       '        Type of grading
       Dim m_IDRA as Integer       '        drawing source type
       Dim m_RIO as Single         ' [   5] direction of upside reinforcement
       Dim m_RIOQ as Single        ' [   5] direction of upside cross reinforcement
       Dim m_RIOI as Single        ' [   5] direction of upside third reinforcement
       Dim m_RIU as Single         ' [   5] direction of downside reinforcement
       Dim m_RIUQ as Single        ' [   5] direction of downside cross reinforcement
       Dim m_RIUI as Single        ' [   5] direction of downside third reinforcement
       Dim m_XREF as Single        ' [1001] Reference point for circular reinforcement
       Dim m_YREF as Single        ' [1001] Reference point for circular reinforcement
       Dim m_ZREF as Single        ' [1001] Reference point for circular reinforcement
       Dim m_HIO as Single         ' [1024] distance of upside reinforcement
       Dim m_HIOQ as Single        ' [1024] distance of upside cross reinforcement
       Dim m_HIOI as Single        ' [1024] distance of upside third reinforcement
       Dim m_HIU as Single         ' [1024] distance of downside reinforcement
       Dim m_HIUQ as Single        ' [1024] distance of downside cross reinforcement
       Dim m_HIUI as Single        ' [1024] distance of downside third reinforcement
       Dim m_DIO as Single         ' [1023] Diameter of upside reinforcement
       Dim m_DIOQ as Single        ' [1023] Diameter of upside cross reinforcement
       Dim m_DIOI as Single        ' [1023] Diameter of upside third reinforcement
       Dim m_DIU as Single         ' [1023] Diameter of downside reinforcement
       Dim m_DIUQ as Single        ' [1023] Diameter of downside cross reinforcement
       Dim m_DIUI as Single        ' [1023] Diameter of downside third reinforcement
       Dim m_DSS as Single         ' [1023] Diameter of transverse reinforcement
       Dim m_ASO as Single         ' [1021] upside Minimum reinforcement (outside)
       Dim m_ASOQ as Single        ' [1021] upside cross Minimum reinforcement (middle)
       Dim m_ASOI as Single        ' [1021] upside third Minimum reinforcement (inside)
       Dim m_ASU as Single         ' [1021] downside Minimum reinforcement (outside)
       Dim m_ASUQ as Single        ' [1021] downside cross Minimum reinforcement (middle)
       Dim m_ASUI as Single        ' [1021] downside third Minimum reinforcement (inside)
       Dim m_ASS as Single         ' [1022] Min stirrup cm2/m2
       Dim m_AMO as Single         ' [1021] upside Maximum reinforcement (outside)
       Dim m_AMOQ as Single        ' [1021] upside cross Maximum reinforcement (middle)
       Dim m_AMOI as Single        ' [1021] upside third Maximum reinforcement (inside)
       Dim m_AMU as Single         ' [1021] downside Maximum reinforcement (outside)
       Dim m_AMUQ as Single        ' [1021] downside cross Maximum reinforcement (middle)
       Dim m_AMUI as Single        ' [1021] downside third Maximum reinforcement (inside)
       Dim m_AMS as Single         ' [1022] Max stirrup cm2/m2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() as Single ' [1026] design crack width
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_SIG6() as Single ' [1092] SLS steel stress limit
      END Structure

      Structure CQUAD_RID          ' 200/7:0  Reinforcement Definitions of Quad-elements
       Dim m_ID as Integer         '        identifier (0 = Headder of a definition)
       Dim m_NRG as Integer        '        group number
       Dim m_NR as Integer         '        selector or element number
       Dim m_BITS as Integer       '        Type of grading
       Dim m_ASS as Single         ' [1022] Min stirrup ratio
       Dim m_AMS as Single         ' [1022] Max stirrup ratio
       Dim m_DSS as Single         ' [1023] Diameter of stirrup reinforcements
       Dim m_EXPP as Integer       '        Exposition class at positive face
       Dim m_EXPN as Integer       '        Exposition class at negative face
      END Structure

      Structure CQUAD_RED          ' 270/0:0  Evaluated Reinforcement Definitions of Elements
       Dim m_ID as Integer         '        identifier (0 = Headder of a definition)
       Dim m_NRG as Integer        '        group number
       Dim m_NR as Integer         '        selector or element number
       Dim m_BITS as Integer       '        Type of grading
       Dim m_ASS as Single         ' [1022] Min stirrup ratio
       Dim m_AMS as Single         ' [1022] Max stirrup ratio
       Dim m_DSS as Single         ' [1023] Diameter of stirrup reinforcements
       Dim m_EXPP as Integer       '        Exposition class at positive face
       Dim m_EXPN as Integer       '        Exposition class at negative face
      END Structure

      Structure CQUAD_RIL          ' 200/7:+  Reinforcement Layers of Quad-elements
       Dim m_ID as Integer         '        reference for this layer
       Dim m_DIR as Integer        '        Type of local x-direction
       Dim m_ROT as Single         ' [   5] Angle with reference to the local x-direction
       Dim m_XDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_YDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_ZDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_H as Single           ' [1011] effective distance according to ID-reference definition
       Dim m_ASMIN as Single       ' [1021] Min reinforcement value
       Dim m_ASMAX as Single       ' [1021] Max reinforcement value
       Dim m_D as Single           ' [1023] Diameter of reinforcements
       Dim m_SIG as Single         ' [1092] SLS steel stress limit for crack width (optional)
       Dim m_CRW as Single         ' [1026] design crack width (optional)
      END Structure

      Structure CQUAD_REL          ' 270/0:+  Evaluated Reinforcement Definitions of Elements
       Dim m_ID as Integer         '        reference for this layer
       Dim m_DIR as Integer        '        Type of local x-direction
       Dim m_ROT as Single         ' [   5] Angle with reference to the local x-direction
       Dim m_XDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_YDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_ZDIR as Single        ' [1001] Global reference direction or reference point
       Dim m_H as Single           ' [1011] effective distance according to ID-reference definition
       Dim m_ASMIN as Single       ' [1021] Min reinforcement value
       Dim m_ASMAX as Single       ' [1021] Max reinforcement value
       Dim m_D as Single           ' [1023] Diameter of reinforcements
       Dim m_SIG as Single         ' [1092] SLS steel stress limit for crack width (optional)
       Dim m_CRW as Single         ' [1026] design crack width (optional)
      END Structure

      Structure CQCUT_0            ' 200/8:0  Header for fabrication areas
       Dim m_NR as Integer         '        identifier = 0
       Dim m_TYP as Integer        '        identifier = 0
       Dim m_NAR as Integer        '        number of areas
       Dim m_X as Single           ' [1001] x-center
       Dim m_Y as Single           ' [1001] y-
       Dim m_AR3D as Single        ' [1002] area in 3D
       Dim m_AR2D as Single        ' [1002] area in 2D
       Dim m_AR_0 as Single        ' [1002] area stressfree
      END Structure

      Structure CQCUT_NEW          ' 200/8:+  New cutting area
       Dim m_NR as Integer         '        areanumber
       Dim m_TYP as Integer        '        identifier = 0
       Dim m_LF as Integer         '        Loadcase
       Dim m_X as Single           ' [1001] x-ordinate
       Dim m_Y as Single           ' [1001] y- center(text)
       Dim m_AR3D as Single        ' [1002] area in 3D
       Dim m_AR2D as Single        ' [1002] area in 2D
       Dim m_AR_0 as Single        ' [1002] area stressfree
      END Structure

      Structure CQCUT_DIR          ' 200/8:+  Material direction
       Dim m_NR as Integer         '        areanumber
       Dim m_TYP as Integer        '        Identification
       Dim m_MNR as Integer        '        material no
       Dim m_ALF as Single         ' [   5] warp direction
       Dim m_EMOD as Single        ' [1090] E Mod warp direction
       Dim m_E90 as Single         ' [1090] Elasticity modulus perpendicular
      END Structure

      Structure CQCUT_OUT          ' 200/8:+  Vertex of geometric boundary
       Dim m_NR as Integer         '        areanumber
       Dim m_TYP as Integer        '        Identification
       Dim m_LINE as Integer       '        linetype
       Dim m_X as Single           ' [1001] x-ordinate
       Dim m_Y as Single           ' [1001] y-ordinate
      END Structure

      Structure CQCUT_IN           ' 200/8:+  Geometry inner lines
       Dim m_NR as Integer         '        areanumber
       Dim m_TYP as Integer        '        Identification
       Dim m_I_2 as Integer
       Dim m_XA as Single          ' [1001] x  startpoint
       Dim m_YA as Single          ' [1001] y  startpoint
       Dim m_XE as Single          ' [1001] x  endpoint
       Dim m_YE as Single          ' [1001] y  endpoint
      END Structure

      Structure CQCUT_WAR          ' 200/8:+  element warp direction
       Dim m_NR as Integer         '        areanumber
       Dim m_TYP as Integer        '        Identification
       Dim m_NREL as Integer       '        orig elem.no
       Dim m_XA as Single          ' [1001] x  startpoint
       Dim m_YA as Single          ' [1001] y  startpoint
       Dim m_XE as Single          ' [1001] x  endpoint
       Dim m_YE as Single          ' [1001] y  endpoint
       Dim m_ALF as Single         ' [   5] warp direction
      END Structure

      Structure CTEXTILE           ' 200/9  definition of cutting lines
       Dim m_IG as Integer         '        group selector
       Dim m_TYP as Integer        '        type of line
       Dim m_XA as Single          ' [1001] line point A
       Dim m_YA as Single          ' [1001] 
       Dim m_ZA as Single          ' [1001] 
       Dim m_XE as Single          ' [1001] line point E
       Dim m_YE as Single          ' [1001] 
       Dim m_ZE as Single          ' [1001] 
       Dim m_NX as Single          ' [1001] projection
       Dim m_NY as Single          ' [1001] 
       Dim m_NZ as Single          ' [1001] 
      END Structure

      Structure CQUAD_P            ' 200/10  Quad-P-elements
       Dim m_NR as Integer         '        elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_MAT as Integer        '        materialnumber
       Dim m_MRF as Integer        '        material Reinf.
       Dim m_NRA as Integer        '        type of element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_EDGE() as Integer '        No of geometric property of edge 1-2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() as Single '        Parameter of Jacobi Determinant
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() as Single ' [1010] element thickness
       Dim m_CB as Single          '        bedding factor
       Dim m_CQ as Single          '        tangential bedding factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() as Single '        transformation matrix
      END Structure

      Structure CQUAD_LOA          ' 202/LC  Quad-element loads
       Dim m_VON as Integer        '        start elementnumber
       Dim m_BIS as Integer        '        end elementnumber
       Dim m_DEL as Integer        '        increment
       Dim m_TYP as Integer        '        type of load
       Dim m_LNR as Integer        '        special option value
       Dim m_P as Single           '        load values
       Dim m_DPDX as Single
       Dim m_DPDY as Single
       Dim m_DPDZ as Single
       Dim m_XREF as Single        ' [1001] optional reference point for load value to
       Dim m_YREF as Single        ' [1001] 
       Dim m_ZREF as Single        ' [1001] 
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_TFUN() as Single '        optional function of load values across the
      END Structure

      Structure CQUAD_LPI          ' 203/LC:*  internal single loads on Quad-elements
       Dim m_NR as Integer         '        element number
       Dim m_TYP as Integer        '        type of load
       Dim m_PRZ as Single         ' [   8] Percentage of load covered with elements
       Dim m_S as Single           '        load point in local coordinates
       Dim m_T as Single           '        load point in local coordinates
       Dim m_P as Single           '        load value
      END Structure

      Structure CQUAD_LLI          ' 203/LC:*  internal line loads of Quad-elements
       Dim m_NR as Integer         '        element number
       Dim m_TYP as Integer        '        type of load
       Dim m_PRZ as Single         ' [   8] 
       Dim m_SA as Single
       Dim m_TA as Single
       Dim m_PA as Single
       Dim m_SB as Single
       Dim m_TB as Single
       Dim m_PB as Single          '        load value end point
      END Structure

      Structure CQUAD_LAI_LPT      '        load points in local coordinates
       Dim m_S as Single
       Dim m_T as Single
       Dim m_P as Single
      END Structure

      Structure CQUAD_LAI          ' 203/LC:*  Free area loads on Quad-elements
       Dim m_NR as Integer         '        element number
       Dim m_TYP as Integer        '        type of load
       Dim m_PRZ as Single         ' [   8] 
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() as CQUAD_LAI_LPT '        load points in local coordinates
      END Structure

      Structure CQUAD_LT           ' 206/NR  Temperature load profiles for QUADs
       Dim m_T as Single           ' [  90] Time value
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_TEMP() as Single '        Temperature values
      END Structure

      Structure CQUAD_FOC          ' 210/LC:0  maximum forces of Quad elements
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force
       Dim m_VY as Single          ' [1111] shear force
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       Dim m_HP1 as Single         '        yield function
       Dim m_HP2 as Single         '        volum. hardening
      END Structure

      Structure CQUAD_FOR          ' 210/LC:+  forces of Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force
       Dim m_VY as Single          ' [1111] shear force
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SG() as Single ' [1112] results in GAUSS-points
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() as Single '        yield function
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() as Single '        volum. hardening
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() as Single '        3rd parameter
      END Structure

      Structure CQUAD_NFC          ' 211/LC:0  maximum forces in nodes
       Dim m_NG as Integer         '        ident 0 for maximum (first records)
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force
       Dim m_VY as Single          ' [1111] shear force
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       Dim m_VX_V as Single        ' [1111] shear force signed
       Dim m_VY_V as Single        ' [1111] shear force signed
       Dim m_HP1 as Single         '        yield function
      END Structure

      Structure CQUAD_NFO          ' 211/LC:Z+  Nodal Quad forces
       Dim m_NG as Integer         '        groupselector
       Dim m_NR as Integer         '        nodenumber
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force abs
       Dim m_VY as Single          ' [1111] shear force abs
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       Dim m_VX_V as Single        ' [1111] shear force signed
       Dim m_VY_V as Single        ' [1111] shear force signed
       Dim m_FY as Single          '        yield function
      END Structure

      Structure CQUAD_EFC          ' 212/LC:0  maximum error estimates for Quad-elements
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force
       Dim m_VY as Single          ' [1111] shear force
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       Dim m_ERR as Single         '        error in energy
      END Structure

      Structure CQUAD_EFO          ' 212/LC:+  error estimates for Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_MXX as Single         ' [1114] bending moment
       Dim m_MYY as Single         ' [1114] bending moment
       Dim m_MXY as Single         ' [1113] torsion moment
       Dim m_VX as Single          ' [1111] shear force
       Dim m_VY as Single          ' [1111] shear force
       Dim m_NX as Single          ' [1112] membran force
       Dim m_NY as Single          ' [1112] membran force
       Dim m_NXY as Single         ' [1112] membran force
       Dim m_HOPT as Single        ' [1001] optimal mesh size
      END Structure

      Structure CQUAD_BEC          ' 213/LC:0  bedding stresses and results
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_PSE as Single         ' [1155] bedding centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PS() as Single ' [1155] bedding in nodes
       Dim m_PRE as Single         ' [1151] result bedd.force in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PR() as Single ' [1151] result bedd. values in Quad-nodes
       Dim m_PVE as Single         ' [1003] bedding displacememts in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PV() as Single ' [1003] bedding displacements in nodes
       Dim m_PTE as Single         ' [1155] tangential bedding in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PT() as Single ' [1155] tangential bedding in nodes
       Dim m_PTXE as Single        ' [1155] tangential bedding in centre X-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTX() as Single ' [1155] tangential bedding in nodes X-component
       Dim m_PTYE as Single        ' [1155] tangential bedding in centre Y-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTY() as Single ' [1155] tangential bedding in nodes Y-component
       Dim m_PTZE as Single        ' [1155] tangential bedding in centre Z-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTZ() as Single ' [1155] tangential bedding in nodes Z-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RQ() as Single ' [1151] resulting tangential bedding in nodes
      END Structure

      Structure CQUAD_BED          ' 213/LC:+  bedding stresses and results
       Dim m_NR as Integer         '        Quadelementnumber
       Dim m_PSE as Single         ' [1155] bedding centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PS() as Single ' [1155] bedding in nodes
       Dim m_PRE as Single         ' [1151] result bedd.force in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PR() as Single ' [1151] result bedd. values in Quad-nodes
       Dim m_PVE as Single         ' [1003] bedding displacememts in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PV() as Single ' [1003] bedding displacements in nodes
       Dim m_PTE as Single         ' [1155] tangential bedding in centre
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PT() as Single ' [1155] tangential bedding in nodes
       Dim m_PTXE as Single        ' [1155] tangential bedding in centre X-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTX() as Single ' [1155] tangential bedding in nodes X-component
       Dim m_PTYE as Single        ' [1155] tangential bedding in centre Y-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTY() as Single ' [1155] tangential bedding in nodes Y-component
       Dim m_PTZE as Single        ' [1155] tangential bedding in centre Z-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTZ() as Single ' [1155] tangential bedding in nodes Z-component
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RQ() as Single ' [1151] resulting tangential bedding in nodes
      END Structure

      Structure CQUAD_RFX          ' 214/LC  additional information for primary loadcases
       Dim m_NR as Integer         '        Quad-elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_EPS() as Single '        strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_RISS() as Single '        directions of crack
      END Structure

      Structure CQUAD_RNC          ' 215/LC:0  nonlinear results of Quad-element
       Dim m_NR as Integer         '        ident 0 for maximum
       Dim m_NMAT as Integer       '        type of material behaviour
       Dim m_ESXO as Single        ' [   9] upside strain
       Dim m_ESYO as Single        ' [   9] upside strain
       Dim m_EXYO as Single        ' [   9] upside strain
       Dim m_ESMO as Single        ' [   9] upside reference strain
       Dim m_ESXU as Single        ' [   9] downside strain
       Dim m_ESYU as Single        ' [   9] downside strain
       Dim m_EXYU as Single        ' [   9] downside strain
       Dim m_ESMU as Single        ' [   9] downside reference strain
       Dim m_SXO as Single         ' [1092] upside stress
       Dim m_SYO as Single         ' [1092] upside stress
       Dim m_SXYO as Single        ' [1092] upside stress
       Dim m_SMO as Single         ' [1092] upside reference stress
       Dim m_SXU as Single         ' [1092] downside stress
       Dim m_SYU as Single         ' [1092] downside stress
       Dim m_SXYU as Single        ' [1092] downside stress
       Dim m_SM_U as Single        ' [1092] downside reference stress
       Dim m_SGVO as Single        ' [1092] upside reference stress incl. shear
       Dim m_SGVU as Single        ' [1092] downside reference stress incl. shear
       Dim m_FY as Single          '        yield function
       Dim m_FDO as Single         ' [1011] steel - upside yield depth
       Dim m_FDU as Single         ' [1011] steel - downside yield depth
       Dim m_I_22 as Single
       Dim m_WR1O as Single        '        concrete - upside direction of crack 1
       Dim m_WR1U as Single        '        concrete - downside direction of crack 1
       Dim m_WR2O as Single        '        concrete - upside direction of crack 2
       Dim m_WR2U as Single        '        concrete - downside direction of crack 2
       Dim m_SGSO as Single        ' [1092] concrete - upside shear stress on crack
       Dim m_SGSU as Single        ' [1092] concrete - downside shear stress on crack
       Dim m_SG1O as Single        ' [1092] concrete - upside steel stress II,dir.1
       Dim m_SG1U as Single        ' [1092] concrete - downside steel stress II,dir.1
       Dim m_SG2O as Single        ' [1092] concrete - upside steel stress II,dir. 2
       Dim m_SG2U as Single        ' [1092] concrete - downside steel stress II,dir.2
       Dim m_W1O as Single         ' [1026] concrete - upside width of crack,direct. 1
       Dim m_W1U as Single         ' [1026] concrete - downside width of crack,dir. 1
       Dim m_W2O as Single         ' [1026] concrete - upside width of crack,direct. 2
       Dim m_W2U as Single         ' [1026] concrete - downside width of crack,dir. 2
       Dim m_BRO as Single         '        concrete -upside direction reinforcement
       Dim m_BRU as Single         '        concrete -downs. direction reinforcement
       Dim m_XD_X as Single        ' [1011] Minimum compression depth in local x axis
       Dim m_XD_Y as Single        ' [1011] Minimum compression depth in local y axis
       Dim m_XD_1 as Single        ' [1011] Minimum compression depth at least pressed uniaxial
       Dim m_XD_2 as Single        ' [1011] Minimum compression depth pressed biaxial
       Dim m_EPSB as Single        ' [   9] Maximum concrete compression strain
       Dim m_EPSC as Single        ' [   9] Minimum averaged reinforcement strain
       Dim m_EPST as Single        ' [   9] Maximum averaged reinforcement strain
       Dim m_SIGC as Single        ' [1092] Maximum concrete compression stress
       Dim m_SIGT as Single        ' [1092] Maximum concrete tension in the concrete layers
       Dim m_EPSR as Single        ' [   9] Maximum reinforcement strain in the crack
      END Structure

      Structure CQUAD_RNO          ' 215/LC:+  nonlinear results of Quad-element
       Dim m_NR as Integer         '        Quad-elementnumber
       Dim m_NMAT as Integer       '        type of material behaviour
       Dim m_ESXO as Single        ' [   9] upside strain
       Dim m_ESYO as Single        ' [   9] upside strain
       Dim m_EXYO as Single        ' [   9] upside strain
       Dim m_ESMO as Single        ' [   9] upside reference strain
       Dim m_ESXU as Single        ' [   9] downside strain
       Dim m_ESYU as Single        ' [   9] downside strain
       Dim m_EXYU as Single        ' [   9] downside strain
       Dim m_ESMU as Single        ' [   9] downside reference strain
       Dim m_SXO as Single         ' [1092] upside stress
       Dim m_SYO as Single         ' [1092] upside stress
       Dim m_SXYO as Single        ' [1092] upside stress
       Dim m_SMO as Single         ' [1092] upside reference stress
       Dim m_SXU as Single         ' [1092] downside stress
       Dim m_SYU as Single         ' [1092] downside stress
       Dim m_SXYU as Single        ' [1092] downside stress
       Dim m_SM_U as Single        ' [1092] downside reference stress
       Dim m_SGVO as Single        ' [1092] upside reference stress incl. shear
       Dim m_SGVU as Single        ' [1092] downside reference stress incl. shear
       Dim m_FY as Single          '        yield function
       Dim m_FDO as Single         ' [1011] steel - upside yield depth
       Dim m_FDU as Single         ' [1011] steel - downside yield depth
       Dim m_I_22 as Single
       Dim m_WR1O as Single        '        concrete - upside direction of crack 1
       Dim m_WR1U as Single        '        concrete - downside direction of crack 1
       Dim m_WR2O as Single        '        concrete - upside direction of crack 2
       Dim m_WR2U as Single        '        concrete - downside direction of crack 2
       Dim m_SGSO as Single        ' [1092] concrete - upside shear stress on crack
       Dim m_SGSU as Single        ' [1092] concrete - downside shear stress on crack
       Dim m_SG1O as Single        ' [1092] concrete - upside steel stress II,dir.1
       Dim m_SG1U as Single        ' [1092] concrete - downside steel stress II,dir.1
       Dim m_SG2O as Single        ' [1092] concrete - upside steel stress II,dir. 2
       Dim m_SG2U as Single        ' [1092] concrete - downside steel stress II,dir.2
       Dim m_W1O as Single         ' [1026] concrete - upside width of crack,direct. 1
       Dim m_W1U as Single         ' [1026] concrete - downside width of crack,dir. 1
       Dim m_W2O as Single         ' [1026] concrete - upside width of crack,direct. 2
       Dim m_W2U as Single         ' [1026] concrete - downside width of crack,dir. 2
       Dim m_BRO as Single         '        concrete -upside direction reinforcement
       Dim m_BRU as Single         '        concrete -downs. direction reinforcement
       Dim m_XD_X as Single        ' [1011] Minimum compression depth in local x axis
       Dim m_XD_Y as Single        ' [1011] Minimum compression depth in local y axis
       Dim m_XD_1 as Single        ' [1011] Minimum compression depth at least pressed uniaxial
       Dim m_XD_2 as Single        ' [1011] Minimum compression depth pressed biaxial
       Dim m_EPSB as Single        ' [   9] Maximum concrete compression strain
       Dim m_EPSC as Single        ' [   9] Minimum averaged reinforcement strain
       Dim m_EPST as Single        ' [   9] Maximum averaged reinforcement strain
       Dim m_SIGC as Single        ' [1092] Maximum concrete compression stress
       Dim m_SIGT as Single        ' [1092] Maximum concrete tension in the concrete layers
       Dim m_EPSR as Single        ' [   9] Maximum reinforcement strain in the crack
      END Structure

      Structure CQUAD_STC          ' 220/LC:0  maximum Quad-stress
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SVXY as Single        ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_HP1 as Single         ' [1092] yield function
       Dim m_HP2 as Single         '        2nd Parameter
       Dim m_HP3 as Single         '        3rd Parameter
       Dim m_HP4 as Single         '        4th Parameter
       Dim m_HP5 as Single         '        5th Parameter
       Dim m_HP6 as Single         '        6th Parameter
      END Structure

      Structure CQUAD_STP_HTYP     '        = state variables for nonlinear material
       Dim m_ID as Integer
       Dim m_IDIM as Integer
       Dim m_MAXVAL as Single
      END Structure

      Structure CQUAD_STP          ' 220/LC:-  Nonlinear QUAD-stress Headder
       Dim m_TYP as Integer        '        enum of nonlinear parameters as in 1/NR:1/???
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_HTYP() as CQUAD_STP_HTYP '        = state variables for nonlinear material
      END Structure

      Structure CBRIC_STP_HTYP     '        = state variables for nonlinear material
       Dim m_ID as Integer
       Dim m_IDIM as Integer
       Dim m_MAXVAL as Single
      END Structure

      Structure CBRIC_STP          ' 310/LC:-  Nonlinear BRIC-stress Headder
       Dim m_TYP as Integer        '        enum of nonlinear parameters as in 1/NR:1/???
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_HTYP() as CBRIC_STP_HTYP '        = state variables for nonlinear material
      END Structure

      Structure CQUAD_STR_SG       '        results in GAUSS-points
       Dim m_SIGX as Single        ' [1092] 
       Dim m_SIGY as Single        ' [1092] 
       Dim m_TAU as Single         ' [1092] 
       Dim m_SIGZ as Single        ' [1092] 
      END Structure

      Structure CQUAD_STR          ' 220/LC:+  stresses of Quad-element
       Dim m_NR as Integer         '        Elementnumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() as CQUAD_STR_SG '        results in GAUSS-points
       Dim m_PVX as Single         ' [1192] volume loading
       Dim m_PVY as Single         ' [1192] volume loading
       Dim m_PVT as Single         ' [   6] temperature loads
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() as Single '        yield function
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() as Single '        2nd parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() as Single '        3rd parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() as Single '        4th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() as Single '        5th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() as Single '        6th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() as Single '        7th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() as Single '        8th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() as Single '        9th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() as Single '        10th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() as Single '        11th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP12() as Single '        12th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP13() as Single '        13th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP14() as Single '        14th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP15() as Single '        15th parameter as specified in headder record
      END Structure

      Structure CQUAD_NSC          ' 221/LC:0  maximum stresses in nodes
       Dim m_NG as Integer         '        ident 0 for maximum (first records)
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SVXY as Single        ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_FY as Single          '        yield function
      END Structure

      Structure CQUAD_NST          ' 221/LC:Z+  stresses in Quad-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_FY as Single          '        yield function
      END Structure

      Structure CQUAD_ESC          ' 222/LC:0  max. errors in nodes
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SVXY as Single        ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_ERR as Single         '        error in energy
      END Structure

      Structure CQUAD_EST          ' 222/LC:+  error estimates of Quad-element stresses
       Dim m_NR as Integer         '        elementnumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_TAU as Single         ' [1092] shear stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_HOPT as Single        ' [1002] optimal mesh size
      END Structure

      Structure CQUAD_RLC          ' 225/LC:0  max Quad-Layer-results
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_MNR as Integer        '        ident 0 for maximum (first records)
       Dim m_XI as Single          '        local-z
       Dim m_SIGX as Single        ' [1092] stress x
       Dim m_SIGY as Single        ' [1092] stress y
       Dim m_TAU as Single         ' [1092] shear stress xy
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TAUX as Single        ' [1092] shear stress vx
       Dim m_TAUY as Single        ' [1092] shear stress vy
       Dim m_HP1 as Single         '        yield function
       Dim m_HP2 as Single         '        volum. hardening
       Dim m_HP3 as Single         '        damage parameter x
       Dim m_HP4 as Single         '        damage parameter y
       Dim m_HP5 as Single         ' [   3] crack direction 1
       Dim m_HP6 as Single         ' [   3] crack direction 2
       Dim m_HP7 as Single         ' [   9] accumulated temperature strain
       Dim m_HP8 as Single         '        internal damage parameter shrinkage
       Dim m_HP9 as Single         ' [   9] accumulated shrinkage strain
       Dim m_HP10 as Single        '        damage parameter xy
       Dim m_HP11 as Single        ' [   9] epsx  strain in stress strain curve
       Dim m_HP12 as Single        ' [   9] epsy  strain in stress strain curve
       Dim m_HP13 as Single        ' [1215] layer temperature in case of fire analysis
      END Structure

      Structure CQUAD_RLA_SG       '        results in GAUSS-points
       Dim m_SIGX as Single        ' [1092] 
       Dim m_SIGY as Single        ' [1092] 
       Dim m_TAU as Single         ' [1092] 
       Dim m_SIGZ as Single        ' [1092] 
       Dim m_TAUX as Single        ' [1092] 
       Dim m_TAUY as Single        ' [1092] 
      END Structure

      Structure CQUAD_RLA          ' 225/LC:+  Layer-stresses of Quads
       Dim m_NR as Integer         '        Elementnumber
       Dim m_MNR as Integer        '        Materialnumber MNR>0
       Dim m_XI as Single          '        local-z
       Dim m_SIGX as Single        ' [1092] stress x
       Dim m_SIGY as Single        ' [1092] stress y
       Dim m_TAU as Single         ' [1092] shear stress xy
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TAUX as Single        ' [1092] shear stress vx
       Dim m_TAUY as Single        ' [1092] shear stress vy
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() as CQUAD_RLA_SG '        results in GAUSS-points
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() as Single '        yield function
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() as Single '        volum. hardening
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() as Single '        damage parameter x
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() as Single '        damage parameter y
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() as Single ' [   3] crack direction 1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() as Single ' [   3] crack direction 2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() as Single ' [   9] accumulated temperature strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() as Single '        internal damage parameter shrinkage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() as Single ' [   9] accumulated shrinkage strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() as Single '        damage parameter xy
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() as Single ' [   9] epsx  strain in stress strain curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP12() as Single ' [   9] epsy  strain in stress strain curve
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP13() as Single ' [1215] layer temperature in case of fire analysis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP14() as Single ' [1215] max. layer temperature in load history
      END Structure

      Structure CQUAD_RLB_SG       '        results in GAUSS-points
       Dim m_SIG1 as Single        ' [1092] 
       Dim m_SIG2 as Single        ' [1092] 
       Dim m_EPS1 as Single
       Dim m_XI1 as Single
       Dim m_XI2 as Single
       Dim m_EPS2 as Single
      END Structure

      Structure CQUAD_RLB          ' 225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
       Dim m_NR as Integer         '        Elementnumber
       Dim m_MNR as Integer        '        MNR=-1 identifier for reinforcement data
       Dim m_XI as Single          '        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
       Dim m_SIG1 as Single        ' [1092] stress in reinforcement 1. layer
       Dim m_SIG2 as Single        ' [1092] stress in reinforcement 2. layer
       Dim m_EPS1 as Single        '        eps strain in stress strain curve 1. layer
       Dim m_XI1 as Single         '        exact xi position 1. layer
       Dim m_XI2 as Single         '        exact xi position 2. layer
       Dim m_EPS2 as Single        '        eps strain in stress strain curve 2. layer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() as CQUAD_RLB_SG '        results in GAUSS-points
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() as Single '        damage parameter 1. layer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() as Single '        damage parameter 2. layer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() as Single ' [1092] delta-sigma tension stiff. layer 1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() as Single ' [1092] delta-sigma tension stiff. layer 2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() as Single '        direction of reinforcement layer 1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() as Single '        direction of reinforcement layer 2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() as Single ' [   9] accumulated temperature strain
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() as Single '        free
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() as Single '        free
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() as Single ' [1215] layer 1 actual temperature in case of fire analysis
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() as Single ' [1215] layer 2 actual temperature in case of fire analysis
      END Structure

      Structure CQUAD_SEC          ' 229/LC:0  maximum Quad-sectional stress
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] normalstress
       Dim m_SIGY as Single        ' [1092] transverse stress
       Dim m_SIGZ as Single        ' [1092] transverse stress
       Dim m_TAUXY as Single       ' [1092] shear stress
       Dim m_TAUXZ as Single       ' [1092] shear stress
       Dim m_TAUYZ as Single       ' [1092] shear stress
      END Structure

      Structure CQUAD_SEQ          ' 229/LC:-  location of sectional results in master
       Dim m_NR as Integer         '        negative beam number
       Dim m_X as Single           ' [1001] section along beam
      END Structure

      Structure CQUAD_SER          ' 229/LC:+  stresses of sectional Quad-elements
       Dim m_NR as Integer         '        Elementnumber
       Dim m_SIGX as Single        ' [1092] normalstress
       Dim m_SIGY as Single        ' [1092] transverse stress
       Dim m_SIGZ as Single        ' [1092] transverse stress
       Dim m_TAUXY as Single       ' [1092] shear stress
       Dim m_TAUXZ as Single       ' [1092] shear stress
       Dim m_TAUYZ as Single       ' [1092] shear stress
      END Structure

      Structure CQUAD_RT0          ' 230/LC:0  maximum of tendon stresses
       Dim m_NR as Integer         '        identifier 0
       Dim m_NRS as Integer        '        identifier 0
       Dim m_SIGZ as Single        ' [1092] stress increment
       Dim m_ZZ as Single          ' [1101] force in tendon
       Dim m_ZH as Single          ' [1101] duct deduction force
       Dim m_SZG1 as Single        ' [1092] stress in G-point 1
       Dim m_SZG2 as Single        ' [1092] stress in G-point 2
       Dim m_ZZX1 as Single        ' [1101] force tendon+cement1
       Dim m_ZZX2 as Single        ' [1101] force tendon+cement1
       Dim m_ZHG1 as Single        ' [1101] duct deduction G1
       Dim m_ZHG2 as Single        ' [1101] duct deduction G2
       Dim m_ZZG1 as Single        ' [1101] force in tendon G1
       Dim m_ZZG2 as Single        ' [1101] force in tendon G2
       Dim m_AGE as Single         ' [  93] age since prestress
       Dim m_RELZ as Single        '        accumulated relaxation
       Dim m_TZG1 as Single        ' [1215] temperature tendon G1
       Dim m_TZG2 as Single        ' [1215] temperature tendon G2
       Dim m_THG1 as Single        ' [1215] temperature tendon duct G1
       Dim m_THG2 as Single        ' [1215] temperature tendon duct G2
      END Structure

      Structure CQUAD_RTS          ' 230/LC:+  tendon stresses in two integration points
       Dim m_NR as Integer         '        elementnumber
       Dim m_NRS as Integer        '        tendonnumber
       Dim m_SIGZ as Single        ' [1092] stress increment
       Dim m_ZZ as Single          ' [1101] force in tendon
       Dim m_ZH as Single          ' [1101] duct deduction force
       Dim m_SZG1 as Single        ' [1092] stress in G-point 1
       Dim m_SZG2 as Single        ' [1092] stress in G-point 2
       Dim m_ZZX1 as Single        ' [1101] force tendon+cement1
       Dim m_ZZX2 as Single        ' [1101] force tendon+cement1
       Dim m_ZHG1 as Single        ' [1101] duct deduction G1
       Dim m_ZHG2 as Single        ' [1101] duct deduction G2
       Dim m_ZZG1 as Single        ' [1101] force in tendon G1
       Dim m_ZZG2 as Single        ' [1101] force in tendon G2
       Dim m_AGE as Single         ' [  93] age since prestress
       Dim m_RELZ as Single        '        accumulated relaxation
       Dim m_TZG1 as Single        ' [1215] temperature tendon G1
       Dim m_TZG2 as Single        ' [1215] temperature tendon G2
       Dim m_THG1 as Single        ' [1215] temperature tendon duct G1
       Dim m_THG2 as Single        ' [1215] temperature tendon duct G2
      END Structure

      Structure CQUAD_DST          ' 250/DC:+  design stresses in Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_SMIO as Single        ' [1092] minimum upside main stress
       Dim m_SMAO as Single        ' [1092] maximum upside main stress
       Dim m_SMIU as Single        ' [1092] minimum downside main stress
       Dim m_SMAU as Single        ' [1092] maximum downside main stress
       Dim m_TAUM as Single        ' [1092] maximum shear stress
       Dim m_SVMA as Single        ' [1092] maximum reference stress
       Dim m_SVO as Single         ' [1092] maximum reference stress upside
       Dim m_SVU as Single         ' [1092] maximum reference stress downside
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CQUAD_NDS          ' 251/DC:Z+  design stresses in Quad-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       Dim m_SMIO as Single        ' [1092] minimum upside main stress Minimale Hauptspannung oben
       Dim m_SMAO as Single        ' [1092] maximum upside main stress Maximale Hauptspannung oben
       Dim m_SMIU as Single        ' [1092] minimum downside main stress Minimale Hauptspannung unten
       Dim m_SMAU as Single        ' [1092] maximum downside main stress Maximale Hauptspannung unten
       Dim m_TAUM as Single        ' [1092] maximum shear stress
       Dim m_SVMA as Single        ' [1092] maximum reference stress
       Dim m_SVO as Single         ' [1092] maximum reference stress upside
       Dim m_SVU as Single         ' [1092] maximum reference stress downside
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of designcase
      END Structure

      Structure CQUAD_RIC          ' 260/DC:0  maximum reinforcement in Quad-elements
       Dim m_NR as Integer         '        ident 0
       Dim m_ASO as Single         ' [1021] upside reinforcement (outside)
       Dim m_ASOQ as Single        ' [1021] upside cross reinforcement (middle)
       Dim m_ASU as Single         ' [1021] downside reinforcement (outside)
       Dim m_ASUQ as Single        ' [1021] downside cross reinforcement (middle)
       Dim m_ASOI as Single        ' [1021] upside third reinforcement (inside)
       Dim m_ASUI as Single        ' [1021] downside third reinforcement (inside)
       Dim m_ASS as Single         ' [1022] stirrup cm2/m2
       Dim m_ASSE as Single        ' [1020] stirrup cm2
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_SIXO as Single        ' [1030] upside reinforcement quantity
       Dim m_SIXU as Single        ' [1030] downside reinforcement quantity
       Dim m_SIXS as Single        ' [1030] shear reinforcement quantity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_FREE0() as Single '        not yet used
       Dim m_ZMIN as Single        ' [1001] minimum lever arm
       Dim m_VEDR as Single        '        max. VED/VRDMAX
       Dim m_COTT as Single        '        max. cot_theta
       Dim m_VED as Single         '        max. VED
       Dim m_VM as Single          ' [1001] shift rule
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] upside stress range (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() as Single ' [1092] downside stress range (inside)
       Dim m_SDV as Single         ' [1092] stirrup stress range
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() as Single ' [1092] maximum stell stress upside (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() as Single ' [1092] maximum stell stress downside(inside)
       Dim m_SSV as Single         ' [1092] maximum stirrup stress (not yet used)
       Dim m_SIGBO as Single       ' [1092] maximum concrete pressure upside (outside)
       Dim m_SIGBU as Single       ' [1092] maximum concrete pressure downside(inside)
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress
       Dim m_SHZX as Single        '        max. skew principal tensile stress in local x
       Dim m_SHZY as Single        '        max. skew principal tensile stress in local y
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() as Single ' [1021] Info reinforcement bending design only
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() as Single ' [1021] Info reinforcement if increased due to shear
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() as Single ' [1021] Info reinforcement to satisfy shear without stirrups
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() as Single ' [1114] Design bending moment in direction of reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() as Single '        bitpattern of origins of maximum reinforcements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() as Single ' [1026] crack width  reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of designcase
      END Structure

      Structure CQUAD_REI          ' 260/DC:+  reinforcement in Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_ASO as Single         ' [1021] upside reinforcement (outside)
       Dim m_ASOQ as Single        ' [1021] upside cross reinforcement (middle)
       Dim m_ASU as Single         ' [1021] downside reinforcement (outside)
       Dim m_ASUQ as Single        ' [1021] downside cross reinforcement (middle)
       Dim m_ASOI as Single        ' [1021] upside third reinforcement (inside)
       Dim m_ASUI as Single        ' [1021] downside third reinforcement (inside)
       Dim m_ASS as Single         ' [1022] stirrup cm2/m2
       Dim m_ASSE as Single        ' [1020] stirrup cm2
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_RIO as Single         '        direction of upside reinforcement
       Dim m_RIOQ as Single        '        direction of upside cross reinforcement
       Dim m_RIU as Single         '        direction of downside reinforcement
       Dim m_RIUQ as Single        '        direction of downside cross reinforcement
       Dim m_RIOI as Single        '        direction of upside third reinforcement
       Dim m_RIUI as Single        '        direction of downside third reinforcement
       Dim m_ZMIN as Single        ' [1001] minimum lever arm (ULS design)
       Dim m_VEDR as Single        '        max. VED/VRDMAX (ULS design)
       Dim m_COTT as Single        '        max. cot_theta (ULS design)
       Dim m_VED as Single         '        max. VED (ULS design)
       Dim m_VM as Single          ' [1001] shift rule
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] upside stress range (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() as Single ' [1092] downside stress range (inside)
       Dim m_SDV as Single         ' [1092] stirrup stress range
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() as Single ' [1092] maximum stell stress upside (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() as Single ' [1092] maximum stell stress downside(inside)
       Dim m_SSV as Single         ' [1092] maximum stirrup stress (not yet used)
       Dim m_SIGBO as Single       ' [1092] maximum concrete pressure upside (outside)
       Dim m_SIGBU as Single       ' [1092] maximum concrete pressure downside(inside)
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress (SLS uncracked)
       Dim m_SHZX as Single        '        max. skew principal tensile stress in local x
       Dim m_SHZY as Single        '        max. skew principal tensile stress in local y
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() as Single ' [1021] Info reinforcement bending design only (ULS design)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() as Single ' [1021] Info reinforcement if increased due to shear (ULS design)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() as Single ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() as Single ' [1114] Design bending moment in direction of reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() as Single '        origin of maximum reinforcement:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() as Single ' [1026] crack width  reinforcement
      END Structure

      Structure CQUAD_NRC          ' 261/DC:0  maximum reinforcement in Quad-nodes
       Dim m_NR as Integer         '        ident 0
       Dim m_NG as Integer         '        ident 0
       Dim m_ASO as Single         ' [1021] upside reinforcement (outside)
       Dim m_ASOQ as Single        ' [1021] upside cross reinforcement (middle)
       Dim m_ASU as Single         ' [1021] downside reinforcement (outside)
       Dim m_ASUQ as Single        ' [1021] downside cross reinforcement (middle)
       Dim m_ASOI as Single        ' [1021] upside third reinforcement (inside)
       Dim m_ASUI as Single        ' [1021] downside third reinforcement (inside)
       Dim m_ASS as Single         ' [1022] stirrup cm2/m2
       Dim m_I_8 as Single         '        reserved 0.0
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_FREE0() as Single '        not yet used
       Dim m_ZMIN as Single        ' [1001] minimum lever arm
       Dim m_VEDR as Single        '        max. VED/VRDMAX
       Dim m_COTT as Single        '        max. cot_theta
       Dim m_VED as Single         '        max. VED
       Dim m_VM as Single          ' [1001] shift rule
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] upside stress range (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() as Single ' [1092] downside stress range (inside)
       Dim m_SDV as Single         ' [1092] stirrup stress range
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() as Single ' [1092] maximum stell stress upside (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() as Single ' [1092] maximum stell stress downside(inside)
       Dim m_SSV as Single         ' [1092] maximum stirrup stress (not yet used)
       Dim m_SIGBO as Single       ' [1092] maximum concrete pressure upside (outside)
       Dim m_SIGBU as Single       ' [1092] maximum concrete pressure downside(inside)
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress
       Dim m_SHZX as Single        '        max. skew principal tensile stress in local x
       Dim m_SHZY as Single        '        max. skew principal tensile stress in local y
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() as Single ' [1021] Info reinforcement bending design only
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() as Single ' [1021] Info reinforcement if increased due to shear
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() as Single ' [1021] Info reinforcement to satisfy shear without stirrups
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() as Single ' [1114] Design bending moment in direction of reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() as Single '        bitpattern of origins of maximum reinforcements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() as Single ' [1026] crack width  reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RESERVED() as Single '        reserved for future usage
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of Designcase
      END Structure

      Structure CQUAD_NRI          ' 261/DC:Z+  reinforcement in Quad-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       Dim m_ASO as Single         ' [1021] upside reinforcement (outside)
       Dim m_ASOQ as Single        ' [1021] upside cross reinforcement (middle)
       Dim m_ASU as Single         ' [1021] downside reinforcement (outside)
       Dim m_ASUQ as Single        ' [1021] downside cross reinforcement (middle)
       Dim m_ASOI as Single        ' [1021] upside third reinforcement (inside)
       Dim m_ASUI as Single        ' [1021] downside third reinforcement (inside)
       Dim m_ASS as Single         ' [1022] stirrup cm2/m2
       Dim m_I_8 as Single         '        reserved 0.0
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_RIO as Single         '        direction of upside reinforcement
       Dim m_RIOQ as Single        '        direction of upside cross reinforcement
       Dim m_RIU as Single         '        direction of downside reinforcement
       Dim m_RIUQ as Single        '        direction of downside cross reinforcement
       Dim m_RIOI as Single        '        direction of upside third reinforcement
       Dim m_RIUI as Single        '        direction of downside third reinforcement
       Dim m_ZMIN as Single        ' [1001] minimum lever arm
       Dim m_VEDR as Single        '        max. VED/VRDMAX
       Dim m_COTT as Single        '        max. cot_theta
       Dim m_VED as Single         '        max. VED
       Dim m_VM as Single          ' [1001] shift rule
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] upside stress range (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() as Single ' [1092] downside stress range (inside)
       Dim m_SDV as Single         ' [1092] stirrup stress range
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() as Single ' [1092] maximum stell stress upside (outside)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() as Single ' [1092] maximum stell stress downside(inside)
       Dim m_SSV as Single         ' [1092] maximum stirrup stress (not yet used)
       Dim m_SIGBO as Single       ' [1092] maximum concrete pressure upside (outside)
       Dim m_SIGBU as Single       ' [1092] maximum concrete pressure downside(inside)
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress
       Dim m_SHZX as Single        '        max. skew principal tensile stress in local x
       Dim m_SHZY as Single        '        max. skew principal tensile stress in local y
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() as Single ' [1021] Info reinforcement bending design only
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() as Single ' [1021] Info reinforcement if increased due to shear
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() as Single ' [1021] Info reinforcement to satisfy shear without stirrups
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() as Single ' [1114] Design bending moment in direction of reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() as Single '        origin of maximum reinforcement
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() as Single ' [1026] crack width  reinforcement
      END Structure

      Structure CQUAD_NRP          ' 262/DC:+  punching reinforcement in nodes
       Dim m_NR as Integer         '        nodenumber
       Dim m_ISTA as Integer       '        state of force
       Dim m_IDUS as Integer       '        punching state
       Dim m_U0 as Single          ' [1001] effective length of first perimeter
       Dim m_REDO as Single        '        reduction factor for openings/free edges
       Dim m_V as Single           ' [1151] punching force
       Dim m_ASL as Single         ' [1020] required longitudinal reinforcement
       Dim m_ASV1 as Single        ' [1022] shear reinforcement within 1st perimeter
       Dim m_ASV2 as Single        ' [1022] shear reinforcement within 2nd perimeter
       Dim m_ASV3 as Single        ' [1022] shear reinforcement within 3rd perimeter
       Dim m_ASV4 as Single        ' [1022] shear reinforcement within 4th perimeter
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_FREE0() as Single '        not yet used
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT1() as Integer '        Halfen Description 1 (30 chars require n/2+1 words)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT2() as Integer '        Halfen Description 2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT3() as Integer '        Halfen Description 3
      END Structure

      Structure CQUAD_PUN          ' 262/DC:0  punching periphery
       Dim m_NR as Integer         '        identifier 0
       Dim m_ID as Integer         '        identifier 0
       Dim m_TYP as Integer        '        type of line
       Dim m_X1 as Single          ' [1001] Coordinates of start point
       Dim m_Y1 as Single          ' [1001] 
       Dim m_Z1 as Single          ' [1001] 
       Dim m_X2 as Single          ' [1001] Coordinates of end point
       Dim m_Y2 as Single          ' [1001] 
       Dim m_Z2 as Single          ' [1001] 
      END Structure

      Structure CQUAD_PU1          ' 262/DC:0  punching parameters
       Dim m_NR as Integer         '        identifier 0
       Dim m_ID as Integer         '        identifier 1
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=199)> Dim m_KDUST() as Integer '        Integer-punching parameters
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=299)> Dim m_RDUST() as Single '        Real-punching parameters
      END Structure

      Structure CQUAD_RD0          ' 265/DC:0  maximum of tendon stresses in the design
       Dim m_NR as Integer         '        identifier 0
       Dim m_NRS as Integer        '        identifier 0
       Dim m_SMAX as Single        ' [1092] maximum design stress
       Dim m_SMIN as Single        ' [1092] minimum design stress
       Dim m_PERM as Single        ' [1092] permanent stress
      END Structure

      Structure CQUAD_RTD          ' 265/DC:+  tendon stress in the design
       Dim m_NR as Integer         '        elementnumber
       Dim m_NRS as Integer        '        tendonnumber
       Dim m_SMAX as Single        ' [1092] maximum design stress
       Dim m_SMIN as Single        ' [1092] minimum design stress
       Dim m_PERM as Single        ' [1092] permanent stress
      END Structure

      Structure CQUAD_REE          ' 270/DC:0  maximum design values in Quad-elements
       Dim m_NG as Integer         '        ident 0
       Dim m_NR as Integer         '        ident 0
       Dim m_ID as Integer         '        activated layers: -(nupper +100*nlower +10000*ncentric)
       Dim m_ORIG as Integer       '        origin - error messages:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SIGC() as Single ' [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SIGCD() as Single ' [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SHZ() as Single ' [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGS() as Single ' [1092] maximum SLS reinforcement stress for center/upside/downside
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGSD() as Single ' [1092] maximum SLS reinforcement stress range for center/upside/downsi
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons upside/downsid
       Dim m_ZMIN as Single        ' [1001] minimum lever arm (ULS design)
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_ASS as Single         ' [1022] stirrup reinforcement ratio
       Dim m_VEDR as Single        '        max. VED/VRDMAX (ULS design)
       Dim m_COTT as Single        '        max. cot_theta (ULS design)
       Dim m_VED as Single         '        max. VED (ULS design)
       Dim m_VM as Single          ' [1001] shift rule
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_OPT() as Single '        reserved
       Dim m_SUMO as Single        ' [1030] upside reinforcement quantity
       Dim m_SUMU as Single        ' [1030] downside reinforcement quantity
       Dim m_SUMM as Single        ' [1030] centric reinforcement quantity
       Dim m_SUMS as Single        ' [1030] shear reinforcement quantity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of designcase
      END Structure

      Structure CQUAD_RNE          ' 271/DC:0  maximum design values in Nodes of Quad-elements
       Dim m_NG as Integer         '        ident 0
       Dim m_NR as Integer         '        ident 0
       Dim m_ID as Integer         '        activated layers: -(nupper +100*nlower +10000*ncentric)
       Dim m_ORIG as Integer       '        origin - error messages:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SIGC() as Single ' [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SIGCD() as Single ' [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SHZ() as Single ' [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGS() as Single ' [1092] maximum SLS reinforcement stress for center/upside/downside
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGSD() as Single ' [1092] maximum SLS reinforcement stress range for center/upside/downsi
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons upside/downsid
       Dim m_ZMIN as Single        ' [1001] minimum lever arm (ULS design)
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_ASS as Single         ' [1022] stirrup reinforcement ratio
       Dim m_VEDR as Single        '        max. VED/VRDMAX (ULS design)
       Dim m_COTT as Single        '        max. cot_theta (ULS design)
       Dim m_VED as Single         '        max. VED (ULS design)
       Dim m_VM as Single          ' [1001] shift rule
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_OPT() as Single '        reserved
       Dim m_SUMO as Single        ' [1030] upside reinforcement quantity
       Dim m_SUMU as Single        ' [1030] downside reinforcement quantity
       Dim m_SUMM as Single        ' [1030] centric reinforcement quantity
       Dim m_SUMS as Single        ' [1030] shear reinforcement quantity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        Designation of designcase
      END Structure

      Structure CQUAD_REM          ' 270/DC:0  maximum reinforcement results in Quad-elements
       Dim m_NG as Integer         '        ident 0
       Dim m_NR as Integer         '        ident 0
       Dim m_ID as Integer         '        +1 identifier for reincorcement
       Dim m_ORIG as Integer       '        origin of maximum reinforcement, see QUAD_REA for Details
       Dim m_ASO as Single         ' [1021] reinforcement area
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] reinforcement stress SLS
       Dim m_ASBEND as Single      ' [1021] Info reinforcement bending design only (ULS design)
       Dim m_ASPLUS as Single      ' [1021] Info reinforcement if increased due to shear (ULS design)
       Dim m_ASPOSS as Single      ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
       Dim m_BMOM as Single        ' [1114] Design bending moment in direction of reinforcement
       Dim m_WK as Single          ' [1026] crack width
      END Structure

      Structure CQUAD_REA          ' 270/DC:Z+  General Concrete Design Results
       Dim m_NG as Integer         '        group number (for nodal results)
       Dim m_NR as Integer         '        element number
       Dim m_ID as Integer         '        ident 0 : concrete results
       Dim m_ORIG as Integer       '        origin of maximum reinforcement:
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGO() as Single ' [1092] stress of concrete pressure upside (Z-)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIGU() as Single ' [1092] stress of concrete pressure downside (Z+)
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress (SLS uncracked)
       Dim m_SHZX as Single        '        max. skew principal tensile stress in local x
       Dim m_SHZY as Single        '        max. skew principal tensile stress in local y
       Dim m_ZMIN as Single        ' [1001] minimum lever arm (ULS design)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() as Single ' [   9] decompression strain in the direction of tendons
       Dim m_SUMO as Single        ' [1021] upside reinforcement quantity
       Dim m_SUMU as Single        ' [1021] downside reinforcement quantity
       Dim m_SUMM as Single        ' [1021] shear reinforcement quantity
       Dim m_TAU0 as Single        ' [1092] design shear stress (shear force)
       Dim m_ASS as Single         ' [1022] stirrup reinforcement ratio
       Dim m_VEDR as Single        '        max. VED/VRDMAX (ULS design)
       Dim m_COTT as Single        '        max. cot_theta (ULS design)
       Dim m_VED as Single         '        max. VED (ULS design)
       Dim m_VM as Single          ' [1001] shift rule
       Dim m_UTILC as Single       '        max. utilization fatigue check concrete
      END Structure

      Structure CQUAD_RER          ' 270/DC:Z+  Reinforcement Layer Design Results
       Dim m_NG as Integer         '        group number (for nodal results)
       Dim m_NR as Integer         '        element number
       Dim m_ID as Integer         '        identifier of reincorcement layer
       Dim m_ORIG as Integer       '        origin of maximum reinforcement, see QUAD_REA for Details
       Dim m_ASO as Single         ' [1021] reinforcement area
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() as Single ' [1092] reinforcement stress SLS
       Dim m_ASBEND as Single      ' [1021] Info reinforcement bending design only (ULS design)
       Dim m_ASPLUS as Single      ' [1021] Info reinforcement if increased due to shear (ULS design)
       Dim m_ASPOSS as Single      ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
       Dim m_BMOM as Single        ' [1114] Design bending moment in direction of reinforcement
       Dim m_WK as Single          ' [1026] crack width
      END Structure

      Structure CQUAD_CFD          ' 290/LC  Fluid flow results in Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_VX as Single          ' [1212] velocity
       Dim m_VY as Single          ' [1212] velocity
       Dim m_VZ as Single          ' [1212] velocity
       Dim m_Q as Single           ' [1211] stream quantity
       Dim m_HOPT as Single        ' [1001] Boundary layer
       Dim m_VXA as Single         ' [1212] particle velocity
       Dim m_VYA as Single         ' [1212] particle velocity
       Dim m_VZA as Single         ' [1212] particle velocity
       Dim m_MUED as Single        ' [1220] laminar viscosity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUX() as Single ' [  95] gradient values of fluid flow du/dx, du/dy
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DVX() as Single ' [  95] gradient values of fluid flow dv/dx, dv/dy
       Dim m_TK as Single          ' [1222] turbulent energy
       Dim m_MUET as Single        ' [1220] turbulent viscosity
       Dim m_ED as Single          ' [1223] dissipation rate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SCALAR() as Single '        optional scalar values
      END Structure

      Structure CQUAD_TM           ' 291/LC:0  Maximum of Temperature Results in Quads
       Dim m_NR as Integer         '        elementnumber
       Dim m_QX as Single          ' [1218] heat flux
       Dim m_QY as Single          ' [1218] heat flux
       Dim m_QZ as Single          ' [1218] heat flux
       Dim m_Q as Single           ' [1216] Total flux
       Dim m_HOPT as Single        ' [1001] optimal mesh size
       Dim m_TEFF as Single        ' [  92] Effective Age
       Dim m_HYDR as Single        '        Hydration degree
       Dim m_LFR as Single         '        Liquid fraction
      END Structure

      Structure CQUAD_TMP          ' 291/LC  Temperature Results in Quad-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_QX as Single          ' [1218] heat flux
       Dim m_QY as Single          ' [1218] heat flux
       Dim m_QZ as Single          ' [1218] heat flux
       Dim m_Q as Single           ' [1216] Total flux
       Dim m_HOPT as Single        ' [1001] optimal mesh size
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TEFF() as Single ' [  92] Effective Age
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HYDR() as Single '        Hydratation degree
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_LFR() as Single '        Liquid fraction
      END Structure

      Structure CBRIC              ' 300/00  Bric-elements
       Dim m_NR as Integer         '        elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_MAT as Integer        '        materialnumber
       Dim m_NRA as Integer        '        type of element
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DET() as Single '        Values of Jacobian Determinant / Volume
      END Structure

      Structure CBRIC_SU           ' 300/02:0  Surfaces and Neighbours of Bric-elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_N0() as Integer
       Dim m_NSUR as Integer
       Dim m_MBRI as Integer       '        max number of brics per surface
      END Structure

      Structure CBRIC_SUR          ' 300/02:+  Surfaces and Neighbours of Bric-elements
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() as Integer
       Dim m_IJMP as Integer
       Dim m_NBRI as Integer
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_NREL() as Integer '        bric numbers for this surface
      END Structure

      Structure CBRIC_RIM          ' 300/6  Prescribed Reinforcements of Bric-elements
       Dim m_NRG as Integer        '        group number
       Dim m_NR as Integer         '        selector number
       Dim m_TYP as Integer        '        Type of Reinforc.
       Dim m_GTYP as Integer       '        Type of grading
       Dim m_IDRA as Integer       '        drawing source type
       Dim m_OAL as Single         '        Euler Angle I reinforcement
       Dim m_OAF as Single         '        Euler Angle II
       Dim m_XREF as Single        ' [1001] Reference point for circular reinforcement
       Dim m_YREF as Single        ' [1001] XREF+YREF allowed in combination with OAL and OAF
       Dim m_ZREF as Single        ' [1001] ZREF<>RW only allowed for OAL=OAF=0
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DI() as Single ' [1023] Diameter of reinforcement 1-3
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() as Single ' [1022] Minimum reinforcement 1-3
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AM() as Single ' [1022] Maximum reinforcement 1-3
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_WK() as Single ' [1026] design crack width
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIG() as Single ' [1092] SLS steel stress limit
      END Structure

      Structure CBRIC_P            ' 300/10  Bric-P-Elements
       Dim m_NR as Integer         '        elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() as Integer '        nodenumbers
       Dim m_MAT as Integer        '        materialnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_EDGE() as Integer '        geometric id of edge 1-2
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_FACE() as Integer '        geometric id of face 1-2-3-4
      END Structure

      Structure CBRIC_LOA          ' 302/LC  loads of Bric-elements
       Dim m_VON as Integer        '        start elementnumber
       Dim m_BIS as Integer        '        end elementnumber
       Dim m_DEL as Integer        '        increment
       Dim m_TYP as Integer        '        type of load
       Dim m_LNR as Integer        '        primary loadcasenumber,if TYP = 18/30
       Dim m_P as Single           '        load value
       Dim m_DPDX as Single
       Dim m_DPDY as Single
       Dim m_DPDZ as Single
       Dim m_XREF as Single        ' [1001] optional reference point for load value
       Dim m_YREF as Single        ' [1001] 
       Dim m_ZREF as Single        ' [1001] 
      END Structure

      Structure CBRIC_STC          ' 310/LC:0  maximum stress in BRICs
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
       Dim m_HP1 as Single         '        yield function
       Dim m_HP2 as Single         '        volum. hardening
      END Structure

      Structure CBRIC_STR_SG       '        results in GAUSS-points
       Dim m_SIGX as Single        ' [1092] 
       Dim m_SIGY as Single        ' [1092] 
       Dim m_SIGZ as Single        ' [1092] 
       Dim m_TVXY as Single        ' [1092] 
       Dim m_TVXZ as Single        ' [1092] 
       Dim m_TVYZ as Single        ' [1092] 
      END Structure

      Structure CBRIC_STR          ' 310/LC:+  3D-stresses in Bric-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_SG() as CBRIC_STR_SG '        results in GAUSS-points
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP1() as Single '        yield function
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP2() as Single '        2nd parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP3() as Single '        3rd parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP4() as Single '        4th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP5() as Single '        5th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP6() as Single '        6th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP7() as Single '        7th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP8() as Single '        8th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP9() as Single '        9th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP10() as Single '        10th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP11() as Single '        11th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP12() as Single '        12th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP13() as Single '        13th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP14() as Single '        14th parameter as specified in headder record
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP15() as Single '        15th parameter as specified in headder record
      END Structure

      Structure CBRIC_NSC          ' 311/LC:0  maximum nodal 3D stress
       Dim m_NG as Integer         '        ident 0 for maximum (first records)
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
      END Structure

      Structure CBRIC_NST          ' 311/LC:Z+  3D-stresses in Bric-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
       Dim m_FY as Single          '        yield function
      END Structure

      Structure CBRIC_ESC          ' 312/LC:0  max. errors of Bric-stresses
       Dim m_NR as Integer         '        ident 0 for maximum (first records)
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
      END Structure

      Structure CBRIC_EST          ' 312/LC:+  3D-error estimates in Bric-Elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_SIGX as Single        ' [1092] stress
       Dim m_SIGY as Single        ' [1092] stress
       Dim m_SIGZ as Single        ' [1092] stress
       Dim m_TVXY as Single        ' [1092] shear stress
       Dim m_TVXZ as Single        ' [1092] shear stress
       Dim m_TVYZ as Single        ' [1092] shear stress
      END Structure

      Structure CBRIC_REI          ' 360/DC:+  reinforcement in Bric-elements
       Dim m_NR as Integer         '        elementnumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() as Single ' [1022] reinforcement 1-3
       Dim m_OAL as Single         '        Euler Angle I
       Dim m_OAF as Single         '        Euler Angle II
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SD() as Single ' [1092] stress range 1-3
       Dim m_SIGB as Single        ' [1092] maximum concrete pressure
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress (SLS uncracked)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ORIGIN() as Single '        origin of maximum reinforcement: as defined in 260/DC
      END Structure

      Structure CBRIC_NRI          ' 361/DC:Z+  reinforcement in Bric-nodes
       Dim m_NG as Integer         '        groupnumber
       Dim m_NR as Integer         '        nodenumber
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() as Single ' [1022] reinforcement 1-3
       Dim m_OAL as Single         '        Euler Angle I
       Dim m_OAF as Single         '        Euler Angle II
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SD() as Single ' [1092] stress range 1-3
       Dim m_SIGB as Single        ' [1092] maximum concrete pressure
       Dim m_SHZMAX as Single      '        maximum skew principal tensile stress (SLS uncracked)
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ORIGIN() as Single '        origin of maximum reinforcement: as defined in 260/DC
      END Structure

      Structure CBRIC_CFD          ' 390/LC  Fluid flow results in BRIC-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_VX as Single          ' [1212] velocity
       Dim m_VY as Single          ' [1212] velocity
       Dim m_VZ as Single          ' [1212] velocity
       Dim m_Q as Single           ' [1211] stream quantity
       Dim m_HOPT as Single        ' [1001] optimal mesh size
       Dim m_VXA as Single         ' [1212] particle velocity
       Dim m_VYA as Single         ' [1212] particle velocity
       Dim m_VZA as Single         ' [1212] particle velocity
       Dim m_MUED as Single        ' [1220] laminar viscosity
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DUX() as Single ' [  95] gradient values fluid flow du/dx, du/dy, du/dz
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DVX() as Single ' [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DWX() as Single ' [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
       Dim m_TK as Single          ' [1222] turbulent energy
       Dim m_MUET as Single        ' [1220] turbulent viscosity
       Dim m_ED as Single          ' [1223] dissipation rate
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SCALAR() as Single '        optional scalar parameters
      END Structure

      Structure CBRIC_TM           ' 391/LC:0  Maximum Temperature Results in BRICs
       Dim m_NR as Integer         '        elementnumber
       Dim m_QX as Single          ' [1218] heat flux
       Dim m_QY as Single          ' [1218] heat flux
       Dim m_QZ as Single          ' [1218] heat flux
       Dim m_Q as Single           ' [1216] Total flux
       Dim m_TEFF as Single        ' [  92] Effective Age
       Dim m_HYDR as Single        '        Hydration degree
       Dim m_LFR as Single         '        Liquid fraction
      END Structure

      Structure CBRIC_TMP          ' 391/LC  Temperature Results in BRIC-elements
       Dim m_NR as Integer         '        elementnumber
       Dim m_QX as Single          ' [1218] heat flux
       Dim m_QY as Single          ' [1218] heat flux
       Dim m_QZ as Single          ' [1218] heat flux
       Dim m_Q as Single           ' [1216] Total flux
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_TEFF() as Single ' [  92] Effective Age
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HYDR() as Single '        Hydration degree
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_LFR() as Single '        Liquid fraction
      END Structure

      Structure CHASE_PIH          ' 404/NR:0  HASE-Piles in Half-space
       Dim m_ID as Integer         '        Identification 0
       Dim m_NPILE as Integer      '        Number of piles
       Dim m_MPILE as Integer      '        Max. values per pile
       Dim m_NHKNOT as Integer     '        Number of nodes
      END Structure

      Structure CHASE_PIL          ' 404/NR:+  HASE-Piles in Half-space
       Dim m_ENR as Integer        '        External node number
       Dim m_X as Single           ' [1001] Pile X-coordinate
       Dim m_Y as Single           ' [1001] Pile Y-coordinate
       Dim m_DF as Single          ' [1001] Pile-foot diameter
       Dim m_Z as Single           ' [1001] Pile-foot coordinate
       Dim m_MANT as Single        '        Fraction of the total pile load transfered as a pile
       Dim m_PMAM as Single        ' [1190] Max. load transferable by skin friction
       Dim m_INR as Integer        '        Ixternal node number
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_BEZ() as Integer '        Designation
       Dim m_PMAF as Single        ' [1190] Max. load transferable trough pile-foot
       Dim m_ZMAN as Single        ' [1001] Z-coordiante from which the skin friction is active
       Dim m_CFAC as Single        '        Factor of load applied as compression-only
       Dim m_PLEN as Single        ' [1001] Pile length
       Dim m_PLSF as Single        ' [1001] Pile length part inactive for skin friction
       Dim m_D0 as Single          ' [1001] Pile diameter
       Dim m_MNR as Single         '        Pile material number
      END Structure

      Structure CSEG_DEF           ' 900/00  Segmentdefinition
       Dim m_ID as Integer         '        Identification of segment
       Dim m_TYP as Integer        '        Type of segment
       Dim m_BIT as Integer        '        Bitpattern idef+4*iref
       Dim m_LEN as Single         ' [1001] Length of segment
       Dim m_ALFA as Single        ' [   5] Angle of start face to axis (0 = match-cast)
       Dim m_ALFR as Single        ' [   5] Angle of end   face to axis (0 = match-cast)
       Dim m_DSPA as Single        ' [1001] Distance of start survey point
       Dim m_DSPE as Single        ' [1001] Distance of end survey point
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() as Integer '        designation of segment
      END Structure

      Structure CIL_CTRL0          ' -1/NS:0  Headder of a location
       Dim m_ID as Integer         '        ID=0
       Dim m_KWERG as Integer      '        KWH for results to be saved
       Dim m_NERG as Integer       '        Count on corresponding items
       Dim m_NREL as Integer       '        element number
       Dim m_XABS as Single        ' [1001] abszissae for beam sections
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Name of location
      END Structure

      Structure CIL_CTRL1          ' -1/NS:?  Headder of a result
       Dim m_IDI as Integer        '        Type of result
       Dim m_IERG as Integer       '        index of this item + 1000*IMUNIT
       Dim m_LFMAX as Integer      '        Offset for load case number of results for maximum
       Dim m_LFMIN as Integer      '        Offset for load case number of results for minimum
       Dim m_LPHI as Single        ' [1001] characteristic lenght for dynamic impact factor
       <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() as Integer '        Name of item
      END Structure

      Structure CIL_DATA0          ' -1/NS:1????  Influence values (V23, obsoleted)
       Dim m_IDI as Integer        '        Type of derivatives defined
       Dim m_X as Single           ' [1001] abszissae along lane
       Dim m_PV as Single          '        Influence value for vertical loading (z)
       Dim m_MT as Single          '        Influence value for torsional loading (x-x)
       Dim m_PL as Single          '        Influence value for longitudinal loading (x)
       Dim m_PT as Single          '        Influence value for transverse loading (y)
       Dim m_DPV as Single         '        Derivative of PV/dx (if IDI&1000)
       Dim m_DMT as Single         '        Derivative of MT/dx (if IDI&0100)
       Dim m_DPL as Single         '        Derivative of PL/dx (if IDI&0010)
       Dim m_DPT as Single         '        Derivative of PT/dx (if IDI&0001)
      END Structure

      Structure CIL_DATA           ' -1/NS:1??????  Influence values
       Dim m_IDI as Integer        '        Type of derivatives defined
       Dim m_X as Single           ' [1001] abszissae along lane
       Dim m_PV as Single          '        Influence value for vertical loading (z)
       Dim m_MT as Single          '        Influence value for torsional loading (x-x)
       Dim m_PL as Single          '        Influence value for longitudinal loading (x)
       Dim m_PT as Single          '        Influence value for transverse loading (y)
       Dim m_PPOS as Single        '        Influence value for vertical distributed loading
       Dim m_PNEG as Single        '        Influence value for vertical distributed loading
       Dim m_DPV as Single         '        Derivative of PV/dx   (if IDI&100000)
       Dim m_DMT as Single         '        Derivative of MT/dx   (if IDI&010000)
       Dim m_DPL as Single         '        Derivative of PL/dx   (if IDI&001000)
       Dim m_DPT as Single         '        Derivative of PT/dx   (if IDI&000100)
       Dim m_DPPOS as Single       '        Derivative of PPOS/dx (if IDI&000010)
       Dim m_DPNEG as Single       '        Derivative of PNEG/dx (if IDI&000001)
       Dim m_RRES as Single        '        Influence value for right residual loading
       Dim m_LRES as Single        '        Influence value for left residual loading
      END Structure


'   SOFiSTiK AG
'     sofistik_daten.vb
'     ende der automatisch erzeugten Datei


End Module
