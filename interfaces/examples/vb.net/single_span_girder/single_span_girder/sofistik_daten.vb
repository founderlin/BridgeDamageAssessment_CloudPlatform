'+============================================================================+
'| Company:   SOFiSTiK AG                                                     |
'| Version:   SOFiSTIK 2018                                                   |
'+============================================================================+

Imports System.Runtime.InteropServices

'This data is automatically updated and can be found in:
'   ...ANALYSIS_50_X64\interfaces\examples\vb.net\sofistik_daten.vb
Public Module SofistikDataTypes

    Structure CREC_VERS          ' -999/-999  Revision number of generating cdbase.txt
        Dim m_VERS As Integer       '        version
    End Structure

    Structure CREC_INDX          ' -999/-998  Sorted index on structure names
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        Name of this structure
        Dim m_KWH As Integer        '        Kwh
        Dim m_KWL As Integer        '        Kwl
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() As Integer '        Selection string of first integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() As Integer '        Selection string of second integer value
    End Structure

    Structure CREC_PUB           ' -999/-997:1  public REC
        Dim m_ID As Integer         '        Identification 1/2
        Dim m_KWH As Integer        '        Kwh
        Dim m_KWL As Integer        '        Kwl (may be NR/LC or number)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() As Integer '        Selection string of first integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() As Integer '        Selection string of second integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        name of this structure
        Dim m_VERSION As Integer    '        Version number of description
        Dim m_OPTION As Integer     '        options  0 = default
    End Structure

    Structure CREC_INT           ' -999/-997:2  internal REC
        Dim m_ID As Integer         '        Identification 1/2
        Dim m_KWH As Integer        '        Kwh
        Dim m_KWL As Integer        '        Kwl (may be NR/LC or number)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL1() As Integer '        Selection string of first integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SEL2() As Integer '        Selection string of second integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        name of this structure
        Dim m_VERSION As Integer    '        Version number of description
        Dim m_OPTION As Integer     '        options  0 = default
    End Structure

    Structure CREC_DAD           ' -999/-997:3  public DAD
        Dim m_ID As Integer         '        Identification 3
        Dim m_KWH As Integer        '        Kwh
        Dim m_KWL As Integer        '        Kwl
    End Structure

    Structure CREC_DESC          ' -999/-997:4  description string to last entry or item
        Dim m_ID As Integer         '        Identification 4
        Dim m_LANG As Integer       '        Language of this item
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_NAME() As Integer '        Description
    End Structure

    Structure CREC_ITM5_STRU     '        Names of the structure elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer
        Dim m_DIM As Integer
        Dim m_DIM1 As Integer
    End Structure

    Structure CREC_ITM5          ' -999/-997:5  item of a record (obsoleted)
        Dim m_ID As Integer         '        Identification 5
        Dim m_NR As Integer         '        number of the item
        Dim m_INDEX As Integer      '        index of the item starting with 0
        Dim m_TYP As Integer        '        Type of the item
        Dim m_OFFSET As Integer     '        offset of the item to be merged
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        item name (4 chars significant)
        Dim m_DIM As Integer        '        unit or type of item
        Dim m_DIM1 As Integer       '        first dimension
        Dim m_BEG1 As Integer       '        first index of first dimension
        Dim m_DIM2 As Integer       '        second dimension
        Dim m_BEG2 As Integer       '        first index of second dimension
        Dim m_BITS As Integer       '        additional information Bits
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_STRUCTUR() As CREC_ITM5_STRU '        Names of the structure elements
    End Structure

    Structure CREC_ITEM_STRU     '        Names of the structure elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer
        Dim m_DIM As Integer
        Dim m_TYPE As Integer
        Dim m_DIM1 As Integer
    End Structure

    Structure CREC_ITEM          ' -999/-997:6  item of a record
        Dim m_ID As Integer         '        Identification 6
        Dim m_NR As Integer         '        number of the item
        Dim m_INDEX As Integer      '        index of the item starting with 0
        Dim m_TYP As Integer        '        Type of the item
        Dim m_OFFSET As Integer     '        offset of the item to be merged
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        item name (4 chars significant)
        Dim m_DIM As Integer        '        unit of item
        Dim m_TYPE As Integer       '        type of item
        Dim m_DIM1 As Integer       '        first dimension
        Dim m_BEG1 As Integer       '        first index of first dimension
        Dim m_DIM2 As Integer       '        second dimension
        Dim m_BEG2 As Integer       '        first index of second dimension
        Dim m_BITS As Integer       '        additional information Bits
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_STRUCTUR() As CREC_ITEM_STRU '        Names of the structure elements
    End Structure

    Structure CREC_MIX_MIXI      '        Mixinfo
        Dim m_TYP As Integer
        Dim m_KEYTYP As Integer
        Dim m_MIXFROM As Integer
    End Structure

    Structure CREC_MIX           ' -999/-997:11  mixinfo of a record
        Dim m_ID As Integer         '        Identification 11/12
        Dim m_NKEY As Integer
        Dim m_NLEN As Integer
        Dim m_NMIXFLAG As Integer
        Dim m_SELECTOR As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_MIXINFO() As CREC_MIX_MIXI '        Mixinfo
    End Structure

    Structure CREC_MHD_MIXI      '        Mixinfo
        Dim m_TYP As Integer
        Dim m_KEYTYP As Integer
        Dim m_MIXFROM As Integer
    End Structure

    Structure CREC_MHD           ' -999/-997:12  mixinfo of a record header
        Dim m_ID As Integer         '        Identification 11/12
        Dim m_NKEY As Integer
        Dim m_NLEN As Integer
        Dim m_NMIXFLAG As Integer
        Dim m_SELECTOR As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_MIXINFO() As CREC_MHD_MIXI '        Mixinfo
    End Structure

    Structure CCTRL_010          ' 0/01:999  AccessInfo Last Program
        Dim m_ID As Integer         '        Identifier 999
        Dim m_ACCE As Integer       '        Number of access
        Dim m_VERS As Integer       '        Version number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() As Integer '        Name of Program
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ERR() As Integer '        Name of ERR-File
    End Structure

    Structure CCTRL_011          ' 0/01:?  Messages
        Dim m_ID As Integer         '        Level
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDERR() As Integer '        Number of errortext
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IDSUP() As Integer '        Name of subroutine
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ITEXT() As Integer '        Text value of message
        Dim m_NILIST As Integer     '        count on Integer values of message
        Dim m_NRLIST As Integer     '        count on Real values of message
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_LIST() As Integer '        values of message ILIST+RLIST
    End Structure

    Structure CCTRL_OBJ          ' 0/01:101  involved objects
        Dim m_ID As Integer         '        Identifier = 101
        Dim m_ID2 As Integer        '        bitpattern of specified data
        Dim m_TYPE As Integer       '        KWH of Elementtype (30,31,32,33)
        Dim m_NR As Integer         '        Number of element  (TYPE/NR)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_IDBIM() As Integer '        256 Bit GUId Identifier of element in the BIM/CAD system
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_UVW() As Single ' [1001] local coordinates in object
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() As Single ' [1001] bounding box x,y,z min, x,y,z max
    End Structure

    Structure CCTRL_OID          ' 0/01:102  GUId
        Dim m_ID As Integer         '        identifier 102
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() As Integer '        256 Bit GUId Identifier of preceeding element
    End Structure

    Structure CSSD_SPE           ' 0/96:1  SSD-Spezial
        Dim m_ID As Integer         '        id==1
        Dim m_TYPE As Integer       '        type of information
        Dim m_IVAL As Integer       '        integer value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_RVAL() As Single '        real values
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ITXT() As Integer '        string value
    End Structure

    Structure CVIS_LC0           ' 0/97:0  active Loadcase
        Dim m_ID As Integer         '        id==0
        Dim m_LFNR As Integer       '        Loadcase number
        Dim m_VIS As Integer        '        unused
    End Structure

    Structure CVIS_LC            ' 0/97:1  Loadcase visualisation
        Dim m_ID As Integer         '        id==1
        Dim m_LFNR As Integer       '        Loadcase number
        Dim m_VIS As Integer        '        Visualisation
    End Structure

    Const CTRL_ACCESS_MIX = 1
    Const CTRL_ACCESS_CONVERT = 2
    Const CTRL_ACCESS_2010 = 4
    Const CTRL_ACCESS_2012 = 8
    Const CTRL_ACCESS_2014 = 16
    Const CTRL_ACCESS_2016 = 32
    Structure CCTRL              ' 0/99:*  PrintControl
        Dim m_MAXL As Integer       '        Lines per page
        Dim m_MARG As Integer       '        Left margin
        Dim m_TOBO As Integer       '        Top/bottom margin
        Dim m_MODP As Integer       '        Type of Headding
        Dim m_PAGE As Integer       '        Current page no
        Dim m_LOUT As Integer       '        Output Language
        Dim m_LINP As Integer       '        Input  Language
        Dim m_UNIT As Integer       '        Unit set
        Dim m_ACCE As Integer       '        No of last access
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_PAG() As Integer '        Paging Text
        Dim m_REL_VERS As Integer   '        ReleaseVersion of this database
        Dim m_REL_BITS As Integer   '        Accessbits
    End Structure

    Structure CCTRL_0            ' 0/99:0  AccessInfo
        Dim m_ID As Integer         '        Identifier 0
        Dim m_ACCE As Integer       '        Number of access
        Dim m_VERS As Integer       '        Version number
        Dim m_ERRO As Integer       '        Number of Errors
        Dim m_WARN As Integer       '        Number of Errors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() As Integer '        Name of Program
        Dim m_REL_VERS As Integer   '        ReleaseVersion of last access
    End Structure

    Structure CCTRL_1            ' 0/99:1  AccessTitle
        Dim m_ID As Integer         '        Identifier 1
        Dim m_ACCE As Integer       '        Number of access
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_KOPF() As Integer '        Title of access
    End Structure

    Structure CCTRL_VAR          ' 0/100  Global_CADINP_Variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() As Integer '        name of variable
        Dim m_IND As Integer        '        index for arrays
        Dim m_VAL As Single         '        value of variable
        Dim m_SCOPE As Integer      '        name of scope
        Dim m_DIM As Integer        '        unit of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Comment on variable
    End Structure

    Structure CCTRL_VAP          ' 0/100:???  Private_CADINP_Variable
        Dim m_ID As Integer         '        Identification = ???
        Dim m_IND1 As Integer       '        Lower Index of variable
        Dim m_IND2 As Integer       '        Upper Index of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() As Integer '        Name of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_VAL() As Single '        values of the variable NAME[IND1:IND2]
    End Structure

    Const MAT_CONS_GW = 701
    Const MAT_CONS_GP = 702
    Const MAT_CONS_GM = 703
    Const MAT_CONS_GC = 704
    Const MAT_CONS_SW = 705
    Const MAT_CONS_SP = 706
    Const MAT_CONS_SM = 707
    Const MAT_CONS_SC = 708
    Const MAT_CONS_SAND = 709
    Const MAT_CONS_ML = 711
    Const MAT_CONS_MI = 712
    Const MAT_CONS_MH = 713
    Const MAT_CONS_CL = 715
    Const MAT_CONS_CI = 716
    Const MAT_CONS_CH = 717
    Const MAT_CONS_CLAY = 719
    Const MAT_CONS_ROC1 = 721
    Const MAT_CONS_ROC2 = 722
    Const MAT_CONS_ROC3 = 723
    Const MAT_CONS_ROC4 = 724
    Const MAT_CONS_AIR = 801
    Const MAT_CONS_H2O = 802
    Const MAT_CONS_CO2 = 803
    Const MAT_CONS_O2 = 804
    Const MAT_CONS_N2 = 805
    Const MAT_CONS_CH4 = 806
    Const MAT_CONS_HE = 809
    Const MAT_CONS_NE = 810
    Const MAT_CONS_AR = 811
    Const MAT_CONS_KR = 812
    Const MAT_CONS_XE = 813
    Const MAT_CONS_SF6 = 814
    Const MAT_CONS_GLAS = 901
    Const MAT_CONS_ESG = 902
    Const MAT_CONS_VSGh = 903
    Const MAT_CONS_VSGv = 904
    Const MAT_CONS_TVG = 905
    Const MAT_CONS_Cu = 906
    Const MAT_CONS_Pb = 907
    Const MAT_CONS_Mg = 908
    Const MAT_CONS_W = 909
    Const MAT_CONS_Zn = 910
    Const MAT_CONS_BRAS = 911
    Const MAT_CONS_BRON = 912
    Const MAT_CONS_BRIC = 925
    Const MAT_CONS_SLBR = 926
    Const MAT_CONS_CLIN = 927
    Const MAT_CONS_IGYP = 930
    Const MAT_CONS_GYPS = 931
    Const MAT_CONS_MOGY = 932
    Const MAT_CONS_MOCH = 933
    Const MAT_CONS_MOCE = 934
    Const MAT_CONS_ASPH = 937
    Const MAT_CONS_BITU = 938
    Const MAT_CONS_CARP = 941
    Const MAT_CONS_WOOL = 942
    Const MAT_CONS_CORK = 943
    Const MAT_CONS_LINO = 944
    Const MAT_CONS_EPOX = 946
    Const MAT_CONS_PHEN = 947
    Const MAT_CONS_PEST = 948
    Const MAT_CONS_ACRY = 949
    Const MAT_CONS_PC = 950
    Const MAT_CONS_PTFE = 951
    Const MAT_CONS_PVC = 952
    Const MAT_CONS_PMMA = 953
    Const MAT_CONS_POM = 954
    Const MAT_CONS_PA = 955
    Const MAT_CONS_PEHD = 956
    Const MAT_CONS_PELD = 957
    Const MAT_CONS_PS = 958
    Const MAT_CONS_PP = 959
    Const MAT_CONS_PUR = 960
    Const MAT_CONS_RUBB = 961
    Const MAT_CONS_NEOP = 962
    Const MAT_CONS_EBON = 963
    Const MAT_CONS_EPDM = 964
    Const MAT_CONS_PSUL = 965
    Const MAT_CONS_BUTA = 966
    Const MAT_CONS_SI = 967
    Const MAT_CONS_SILA = 968
    Const MAT_CONS_FOAM = 973
    Const MAT_CONS_FOAS = 974
    Const MAT_CONS_FOAU = 975
    Const MAT_CONS_FOAC = 976
    Const MAT_CONS_FOAR = 977
    Const MAT_CONS_FOAE = 978
    Const MAT_CONS_LAY = 999
    Structure CMAT               ' 1/NR:0  MaterialTitle
        Dim m_ID As Integer         '        Identification = 0
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() As Integer '        designation
    End Structure

    Structure CMAT_USER          ' 1/NR:10??  Information on user input
        Dim m_ID As Integer         '        Identification
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_BIT() As Integer '        User input for 001/NR:1
    End Structure

    Structure CMAT_FLUI          ' 1/NR:1  MaterialConstants
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Compression modulus
        Dim m_NUE As Single         ' [1221] Kinematic Viscosity
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_RHO As Single         ' [ 159] Density
        Dim m_GAMB As Single        ' [1091] dead weight buyoncy
        Dim m_ALFA As Single        ' [ 107] Temperature Elongation coefficient
    End Structure

    Const MAT_CONS_LINE = 0
    Const MAT_CONS_MISE = 1
    Const MAT_CONS_MOHR = 2
    Const MAT_CONS_GUDE = 3
    Const MAT_CONS_ROCK = 4
    Const MAT_CONS_LADE = 5
    Const MAT_CONS_DUNC = 6
    Const MAT_CONS_HYPO = 7
    Const MAT_CONS_MEMB = 8
    Const MAT_CONS_GRAN = 10
    Const MAT_CONS_CAMC = 11
    Const MAT_CONS_UNDR = 14
    Const MAT_CONS_FAIL = 15
    Const MAT_CONS_SWEL = 16
    Const MAT_CONS_VMIS = 17
    Const MAT_CONS_DRUC = 18
    Structure CMAT_CONS          ' 1/NR:1  MaterialConstants
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_GAMB As Single        ' [1091] dead weight buyoncy
        Dim m_ALFA As Single        ' [ 107] Temperature Expansion
        Dim m_E90 As Single         ' [1090] Transvers Elasticity
        Dim m_MUE90 As Single       '        anisotrope Poisson
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FY As Single          ' [1092] effective strength
        Dim m_FT As Single          ' [1092] nominal strength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() As Single '        variable parameters
    End Structure

    Structure CMAT_UNDR          ' 1/NR:14  Undrained soil parameters
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_GAMB As Single        ' [1091] dead weight buyoncy
        Dim m_ALFA As Single        ' [ 107] Temperature Expansion
        Dim m_E90 As Single         ' [1090] Transvers Elasticity
        Dim m_MUE90 As Single       '        anisotrope Poisson
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FY As Single          ' [1092] effective strength
        Dim m_FT As Single          ' [1092] nominal strength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() As Single '        variable parameters
    End Structure

    Structure CMAT_FAUL          ' 1/NR:15  Fault/Shear plane
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_GAMB As Single        ' [1091] dead weight buyoncy
        Dim m_ALFA As Single        ' [ 107] Temperature Expansion
        Dim m_E90 As Single         ' [1090] Transvers Elasticity
        Dim m_MUE90 As Single       '        anisotrope Poisson
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FY As Single          ' [1092] effective strength
        Dim m_FT As Single          ' [1092] nominal strength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() As Single '        variable parameters
    End Structure

    Structure CMAT_SWEL          ' 1/NR:16  Swelling parameters
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_GAMB As Single        ' [1091] dead weight buyoncy
        Dim m_ALFA As Single        ' [ 107] Temperature Expansion
        Dim m_E90 As Single         ' [1090] Transvers Elasticity
        Dim m_MUE90 As Single       '        anisotrope Poisson
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FY As Single          ' [1092] effective strength
        Dim m_FT As Single          ' [1092] nominal strength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=18)> Dim m_P() As Single '        variable parameters
    End Structure

    Structure CMAT_CONC          ' 1/NR:1  MaterialConcrete
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] Dead weight
        Dim m_RHO As Single         ' [ 159] Density
        Dim m_ALFA As Single        ' [ 107] Temperature Elongation coefficient
        Dim m_E90 As Single         ' [1090] Elasticity modulus perpendicular
        Dim m_MUE90 As Single       '        Poissons ratio perpendicular
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FC As Single          ' [1092] effective strength
        Dim m_FCK As Single         ' [1092] nominal strength
        Dim m_FTM As Single         ' [1092] mean value of tensional strength
        Dim m_FTL As Single         ' [1092] lower fractile of tensional strength
        Dim m_FTK As Single         ' [1092] upper fractile of tensional strength
        Dim m_EC As Single          '        compr. failure Energy (deprecated)
        Dim m_ET As Single          ' [ 112] tensile failure energy
        Dim m_MUER As Single        '        friction in the crack
        Dim m_FCM As Single         ' [1092] mean value of strength
        Dim m_RDCL As Single        '        weight class
        Dim m_FCR As Single         ' [1092] calculatoric mean value of strength
        Dim m_ECR As Single         ' [1090] Elasticity modul for worklaw CE
        Dim m_FBD As Single         ' [1092] bond strength (EC2 Table. 5.1.3)
        Dim m_FTD As Single         ' [1092] Initial tensile strength Bemessungszugfestigkeit
        Dim m_FEQR As Single        ' [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
        Dim m_FEQT As Single        ' [1092] Residual tensile strength  Restzugfestigkeit im Bruch
        Dim m_FCFAT As Single       ' [1092] Fatigue Strength
        Dim m_SCMS As Single        '        Material safety
        Dim m_SCMU As Single        '        Material safety
        Dim m_SCMC As Single        '        Material safety
    End Structure

    Structure CMAT_STEE          ' 1/NR:1  MaterialSteel
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_RHO As Single         ' [ 159] Density
        Dim m_ALFA As Single        ' [ 107] Temperature Elongation coefficient
        Dim m_E90 As Single         ' [1090] Elasticity modulus perpendicular
        Dim m_MUE90 As Single       '        Poissons ratio perpendicular
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FY As Single          ' [1092] yield stress
        Dim m_FT As Single          ' [1092] tensile strength
        Dim m_EPS As Single         ' [   9] limit strain
        Dim m_REL1 As Single        '        Relaxation 0.55fpk
        Dim m_REL2 As Single        '        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
        Dim m_R As Single           '        bond coefficient
        Dim m_K1 As Single          '        bondfactor EC2
        Dim m_EH As Single          ' [1090] Hardening module
        Dim m_FE As Single          ' [1092] Proportional stress
        Dim m_EPSE As Single        ' [   9] Plastic strain
        Dim m_FDYN As Single        ' [1092] Dynamic strength
        Dim m_FYC As Single         ' [1092] compr. yield stress
        Dim m_FTC As Single         ' [1092] compress. strength
        Dim m_TMAX As Single        ' [  16] max.plate thickness
        Dim m_BC As Single          '        (eg. Aluminium 1.0/2.0 = "A","B" )
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() As Single
        Dim m_SCMS As Single        '        Material safety
        Dim m_SCMU As Single        '        Material safety
        Dim m_SCMC As Single        '        Material safety
    End Structure

    Structure CMAT_TIMB          ' 1/NR:1  MaterialTimber
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Material type
        Dim m_CLASS As Integer      '        Classification
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus along the fibres
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_RHO As Single         ' [ 159] Density
        Dim m_ALFA As Single        ' [ 107] Temperature Elongation coefficient
        Dim m_E90 As Single         ' [1090] Elasticity modulus perpendicular to fibres
        Dim m_MUE90 As Single       '        Poissons ratio perpendicular
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FYB As Single         ' [1092] Bending strength
        Dim m_FYT As Single         ' [1092] tensile strength along the fibres
        Dim m_FYT90 As Single       ' [1092] tensile strength perpend. the fibres
        Dim m_FYC As Single         ' [1092] compressive strength along the fibres
        Dim m_FYC90 As Single       ' [1092] compressive strength perpend. the fibres
        Dim m_FYS As Single         ' [1092] middle shear strength (Membrane Shear force)
        Dim m_FYST As Single        ' [1092] edge shear strength (Torsion)
        Dim m_FYSB As Single        ' [1092] maximum shear strength (plate shear)
        Dim m_FYB90 As Single       ' [1092] Bending strength perpendicular to fibres
        Dim m_G90 As Single         ' [1090] transverse shear modulus for platebending
        Dim m_SMOD0 As Single       '        Strength Modifier kmod for Service classes
        Dim m_SMOD1 As Single       '        Strength Modifier kmod for Service classes
        Dim m_SMOD2 As Single       '        Strength Modifier kmod for Service classes
        Dim m_SMOD3 As Single       '        Strength Modifier kmod for Service classes
        Dim m_SMOD4 As Single       '        Strength Modifier kmod for Service classes
        Dim m_KDEF As Single        '        Deformation modifier
        Dim m_TMAX As Single        ' [  16] max.plate thickness
        Dim m_SCMS As Single        '        Material safety
        Dim m_SCMU As Single        '        Material safety
        Dim m_SCMC As Single        '        Material safety
    End Structure

    Structure CMAT_BRIC          ' 1/NR:1  MaterialBrickwork
        Dim m_ID As Integer         '        Identification
        Dim m_TYPE As Integer       '        Bric type and strength
        Dim m_CLASS As Integer      '        Mortar class
        Dim m_EMOD As Single        ' [1090] Elasticity Modulus
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_GMOD As Single        ' [1090] Shear modulus
        Dim m_KMOD As Single        ' [1090] Compression modulus
        Dim m_GAM As Single         ' [1091] dead weight
        Dim m_RHO As Single         ' [ 159] Density
        Dim m_ALFA As Single        ' [ 107] Temperature Elongation coefficient
        Dim m_E90 As Single         ' [1090] Elasticity modulus perpendicular
        Dim m_MUE90 As Single       '        Poissons ratio perpendicular
        Dim m_ALF As Single         ' [   5] Euler Angle I
        Dim m_BET As Single         ' [   5] Euler Angle II
        Dim m_SCM As Single         '        Material safety
        Dim m_FK As Single          ' [1092] Strength
        Dim m_FB As Single          ' [1092] brick strength
        Dim m_FT As Single          ' [1092] tensile strength
        Dim m_FV As Single          ' [1092] shear strength
        Dim m_FV0 As Single         ' [1092] adhesional strength
        Dim m_FBT As Single         ' [1092] tens.brick strength
        Dim m_FM As Single          ' [1092] mortar strength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_DUMMY() As Single
        Dim m_SCMS As Single        '        Material safety
        Dim m_SCMU As Single        '        Material safety
        Dim m_SCMC As Single        '        Material safety
    End Structure

    Structure CMAT_SERV          ' 1/NR:2  StressStrainLaw (Servicability)
        Dim m_ID As Integer         '        Identification
        Dim m_TEMP As Integer       '        Temperature
        Dim m_TYPE As Integer       '        Type of law
        Dim m_SCM As Single         '        Safety factor
        Dim m_EPS As Single         ' [   9] Elongation at TEMP if TEMP>0
        Dim m_RES1 As Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
        Dim m_RES2 As Single        '        Tensile Strength  Concrete   for 21:24
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CMAT_ULTI          ' 1/NR:3  StressStrainLaw (Ultimate Limit state)
        Dim m_ID As Integer         '        Identification
        Dim m_TEMP As Integer       '        Temperature
        Dim m_TYPE As Integer       '        Type of law
        Dim m_SCM As Single         '        Safety factor
        Dim m_EPS As Single         ' [   9] Elongation at TEMP if TEMP>0
        Dim m_RES1 As Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
        Dim m_RES2 As Single        '        Tensile Strength  Concrete   for 21:24
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CMAT_NONL          ' 1/NR:4  StressStrainLaw (Nonlinear Mean Values)
        Dim m_ID As Integer         '        Identification
        Dim m_TEMP As Integer       '        Temperature
        Dim m_TYPE As Integer       '        Type of law
        Dim m_SCM As Single         '        Safety factor
        Dim m_EPS As Single         ' [   9] Elongation at TEMP if TEMP>0
        Dim m_RES1 As Single        ' [   9] Shift of strains TEMP>0 (-TempStrain)
        Dim m_RES2 As Single        '        Tensile Strength  Concrete   for 21:24
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CMAT_BED           ' 1/NR:7  MaterialBedding
        Dim m_ID As Integer         '        Identification
        Dim m_MNR As Integer        '        Materialnumber of bedding boddy
        Dim m_IBT As Integer        '        Type of bedding mechanism
        Dim m_C As Single           ' [1097] Bedding Coefficient
        Dim m_CT As Single          ' [1097] Tangential Bedding
        Dim m_RISS As Single        ' [1092] rupture stress
        Dim m_FLIE As Single        ' [1092] yield   stress
        Dim m_MUE As Single         '        friction coefficient
        Dim m_KOH As Single         ' [1092] cohesion
        Dim m_DIL As Single         '        dilatancy coeffic.
        Dim m_GAM As Single         ' [1184] mass of bedding
        Dim m_H As Single           ' [1001] reference length
    End Structure

    Structure CMAT_LAY           ' 1/NR:8  MaterialLayerStructure
        Dim m_ID As Integer         '        Identification
        Dim m_NM As Integer         '        Number of a material
        Dim m_I_2 As Integer
        Dim m_T As Single           ' [1010] Thickness
    End Structure

    Const MAT_HYD_FLOW = -1
    Const MAT_HYD_DARC = 0
    Const MAT_HYD_ADARC = 1
    Const MAT_HYD_FORC = 2
    Const MAT_HYD_MISS = 3
    Const MAT_HYD_FOUR = 4
    Const MAT_HYD_AFOUR = 5
    Const MAT_HYD_EC4S = 6
    Const MAT_HYD_EC4C = 7
    Const MAT_HYD_JONA = 16
    Const MAT_HYD_HSCM = 17
    Const MAT_HYD_WESC = 18
    Structure CMAT_HYD           ' 1/NR:9  MaterialConductivity
        Dim m_ID As Integer         '        Identification
        Dim m_T As Integer          '        Temperature / pressure
        Dim m_TYPE As Integer       '        Type of Material law
        Dim m_D As Single           '        special Parameter
        Dim m_C As Single           '        Storage Capacity
        Dim m_N As Single           '        Porosity/humidity
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_K() As Single '        Conductivity
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_KLOC() As Single '        Conductivity
    End Structure

    Structure CMAT_SPE           ' 1/NR:90  MaterialSpecial
        Dim m_ID As Integer         '        Identification = 90
        Dim m_TYPE As Integer       '        type of material value
        Dim m_EXP As Integer        '        exposition class identifier (0=all classes)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_RVAL() As Single '        real material values
    End Structure

    Structure CBORE              ' 2/NR:0  SoilProfile
        Dim m_ID As Integer         '        identifier 0 (always the first record)
        Dim m_X As Single           ' [1001] X_ordinate
        Dim m_Y As Single           ' [1001] Y_ordinate
        Dim m_Z As Single           ' [1001] Z_ordinate
        Dim m_DX As Single          '        direction of axis
        Dim m_DY As Single          '        direction of axis
        Dim m_DZ As Single          '        direction of axis
        Dim m_ALF As Single         ' [   5] Angle of reference
        Dim m_HGWL As Single        ' [1006] lower ground water level
        Dim m_HGWH As Single        ' [1006] upper ground water level
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_I_10() As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Profile
    End Structure

    Structure CBORE_LAY          ' 2/NR:1  Soillayer
        Dim m_ID As Integer         '        Identifier 1
        Dim m_MNR As Integer        '        Material number
        Dim m_VARI As Integer       '        Type of stiffness variation
        Dim m_ILAY As Integer       '        Additional layer information
        Dim m_I_4 As Integer        '        reserved
        Dim m_I_5 As Integer        '        reserved
        Dim m_S As Single           ' [1001] Ordinate on bore profile axis (positive)
        Dim m_ES As Single          ' [1096] Stiffness Modulus
        Dim m_DES As Single         ' [1096] Increment of ES within current layer
        Dim m_MUE As Single         '        Poissons ratio
        Dim m_PMAX As Single        ' [1096] Max. pressure at pile foot
        Dim m_PMAL As Single        ' [1096] Max. lateral pressure
        Dim m_C As Single           ' [1096] Cohesion
        Dim m_PHI As Single         ' [   5] Soil/Pile friction angle
        Dim m_GAM As Single         ' [1091] Specific weight
        Dim m_GAMB As Single        ' [1091] Specific weight under buoyancy
    End Structure

    Structure CBORE_TAB          ' 2/NR:10  SoilTabdefinition
        Dim m_ID As Integer         '        Identifier 10
        Dim m_OPT As Integer        '        Option
        Dim m_CLASS As Integer      '        Classification subtype
        Dim m_FACS As Single        '        Factor on stresses
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_B() As Single ' [1001] Width of foundation
    End Structure

    Structure CBORE_TAD          ' 2/NR:11  SoilTabvalues
        Dim m_ID As Integer         '        Identifier 11
        Dim m_I_1 As Integer        '        reserved
        Dim m_I_2 As Integer        '        reserved
        Dim m_D As Single           ' [1006] Embedment depth of foundation
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_SIGD() As Single ' [1089] design stresses at specified depth values
    End Structure

    Structure CBORE_BAX          ' 2/NR:1001  BoreProfileAxial
        Dim m_ID As Integer         '        identifier 1001
        Dim m_Z1 As Single          '        parameter s on start
        Dim m_Z2 As Single          '        parameter s on end
        Dim m_K0 As Single          ' [1096] constant bedding
        Dim m_K1 As Single          ' [1096] parabolic bedding
        Dim m_K2 As Single          ' [1096] linear bedding
        Dim m_K3 As Single          ' [1096] quadratic bedding
        Dim m_M0 As Single          ' [1153] cohesive loading
        Dim m_C0 As Single          ' [1153] cohesion
        Dim m_TANR As Single        '        friction angle
        Dim m_TAND As Single        '        dilatancy angle
        Dim m_KQ As Single          '        pressure coefficient
        Dim m_PMAX As Single        ' [1101] maxforce at pile foot
    End Structure

    Structure CBORE_BLA          ' 2/NR:1002  BoreProfileTransverse
        Dim m_ID As Integer         '        identifier 1002
        Dim m_Z1 As Single          '        parameter s on start
        Dim m_Z2 As Single          '        parameter s on end
        Dim m_K0 As Single          ' [1096] constant bedding
        Dim m_K1 As Single          ' [1096] parabolic bedding
        Dim m_K2 As Single          ' [1096] linear bedding
        Dim m_K3 As Single          ' [1096] quadratic bedding
        Dim m_F0 As Single          '        peripher Distribution
        Dim m_F1 As Single
        Dim m_F2 As Single
        Dim m_PM1 As Single         ' [1153] maximum value on upper ordinate
        Dim m_PM2 As Single         ' [1153] maximum value on lower ordinate
        Dim m_P0 As Single          '        peripher Distribution
        Dim m_P1 As Single
        Dim m_P2 As Single
        Dim m_P3 As Single
    End Structure

    Structure CBORE_BAM          ' 2/NR:1003  BoreProfileMoment
        Dim m_ID As Integer         '        identifier 1003
        Dim m_Z1 As Single          '        parameter s on start
        Dim m_Z2 As Single          '        parameter s on end
        Dim m_K0 As Single          ' [1099] constant bedding
        Dim m_K1 As Single          ' [1099] parabolic bedding
        Dim m_K2 As Single          ' [1099] linear bedding
        Dim m_K3 As Single          ' [1099] quadratic bedding
    End Structure

    Structure CBORE_DYA          ' 2/NR:1011  BoreProfileAxialDynamic
        Dim m_ID As Integer         '        identifier 1011
        Dim m_Z1 As Single          '        parameter s on start
        Dim m_Z2 As Single          '        parameter s on end
        Dim m_D0 As Single          ' [ 105] constant damping
        Dim m_D1 As Single          ' [ 105] parabolic damping
        Dim m_D2 As Single          ' [ 105] linear damping
        Dim m_D3 As Single          ' [ 105] quadratic damping
    End Structure

    Structure CBORE_DYL          ' 2/NR:1012  BoreProfileTransverseDynamic
        Dim m_ID As Integer         '        identifier 1012
        Dim m_Z1 As Single          '        parameter s on start
        Dim m_Z2 As Single          '        parameter s on end
        Dim m_D0 As Single          ' [ 105] constant damping
        Dim m_D1 As Single          ' [ 105] parabolic damping
        Dim m_D2 As Single          ' [ 105] linear damping
        Dim m_D3 As Single          ' [ 105] quadratic damping
        Dim m_M0 As Single          ' [1181] constant soil mass
        Dim m_M2 As Single          ' [1181] linear soil mass
    End Structure

    Const AXIS_SUBTYPE_NONE = 0
    Const AXIS_SUBTYPE_AXIS = 1
    Const AXIS_SUBTYPE_BEAM = 2
    Const AXIS_SUBTYPE_LANE = 10
    Const AXIS_SUBTYPE_BGEO = 11
    Const AXIS_SUBTYPE_TEND = 12
    Const AXIS_SUBTYPE_POST = 15
    Const AXIS_SUBTYPE_AUXI = 19
    Const AXIS_SUBTYPE_GRAF = 90
    Structure CAXIS              ' 3/ID:0  Geometric Axis
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_ID1 As Integer        '        subtype of axis
        Dim m_ID2 As Integer        '        reserved
        Dim m_ID3 As Integer        '        reserved
        Dim m_ID4 As Integer        '        reserved
        Dim m_ID5 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Line
    End Structure

    Structure CAXIS_REF          ' 3/ID:-  Reference to another Geometry
        Dim m_IGM As Integer        '        negative value of the master geometry 03/abs(IGM)
        Dim m_IGS As Integer        '        optional identifier of a secondary axis
        Dim m_SMIN As Single        '        min parameter on referenced axis
        Dim m_SMAX As Single        '        max parameter on referenced axis
    End Structure

    Const GAX_GEO_DEFAULT = 1
    Const GAX_GEO_PROJECT = 2
    Const GAX_GEO_SPLINE = 3
    Const GAX_GEO_EXSPLI = 4
    Const GAX_GEO_BEZIER = 5
    Const GAX_GEO_NURBS = 6
    Const GAX_GEO_NURBX = 7
    Const GAX_GEO_DATA = 8
    Const GAX_GEO_NORM = 9
    Const GAX_GEO_CIRC = 11
    Const GAX_GEO_CBEZIER = 15
    Const GAX_GEO_CNURBS = 16
    Const GAX_GEO_PROJ_CLO = 20
    Const GAX_GEO_PROJ_CUB = 21
    Const GAX_GEO_PROJ_BLO = 22
    Const GAX_GEO_PROJ_SIN = 24
    Const GAX_GEO_PROJ_COS = 25
    Const GAX_GEO_NURBS_KN = 90
    Const GAX_GEO_NURBS_CPT = 91
    Structure CAXIS_GEO          ' 3/ID:??  Geometric properties
        Dim m_ILN As Integer        '        Code of geometry
        Dim m_GPG As Single         ' [1001] geometry parameter 1
        Dim m_GPA As Single         ' [1001] geometry parameter 2
        Dim m_DD As Single          ' [1001] arc length
        Dim m_S1 As Single          '        parameter s on start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() As Single ' [1001] Ordinate of start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() As Single '        Tangent of start
        Dim m_RG1 As Single         ' [1009] in-plane curvature
        Dim m_RA1 As Single         ' [1009] vertical curvature
        Dim m_S2 As Single          '        parameter s on end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() As Single ' [1001] Ordinate of endpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() As Single '        Tangent of endpoint
        Dim m_RG2 As Single         ' [1009] in-plane curvature
        Dim m_RA2 As Single         ' [1009] vertical curvature
        Dim m_XAT As Single         ' [1001] relat. startordinate
    End Structure

    Structure CAXIS_NKN          ' 3/ID:90  Knots of a Nurb
        Dim m_ILN As Integer        '        ID=90
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Single '        Knot-Vector
    End Structure

    Structure CSLN_NKN           ' 39/NR:90  Knots of a Nurb
        Dim m_ILN As Integer        '        ID=90
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Single '        Knot-Vector
    End Structure

    Structure CAXIS_CPT          ' 3/ID:91  Control point of a Nurb
        Dim m_ILN As Integer        '        ID=91
        Dim m_W As Single           '        Weight
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction
    End Structure

    Structure CSLN_CPT           ' 39/NR:91  Control point of a Nurb
        Dim m_ILN As Integer        '        ID=91
        Dim m_W As Single           '        Weight
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction
    End Structure

    Structure CAXIS_PT           ' 3/ID:92  Data point on curve
        Dim m_ILN As Integer        '        ID=92
        Dim m_S As Single           '        Parameter along curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction
    End Structure

    Structure CSLN_PT            ' 39/NR:92  Data point on curve
        Dim m_ILN As Integer        '        ID=92
        Dim m_S As Single           '        Parameter along curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction
    End Structure

    Structure CAXIS_ARC          ' 3/ID:93  Circular Arc
        Dim m_ILN As Integer        '        ID=93
        Dim m_IDF As Integer        '        Definition selected
        Dim m_R As Single           ' [1001] Radius of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates of center
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction of plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() As Single ' [1001] optional start point of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() As Single ' [1001] optional end point of arc
    End Structure

    Structure CSLN_ARC           ' 39/NR:93  Circular Arc
        Dim m_ILN As Integer        '        ID=93
        Dim m_IDF As Integer        '        Definition selected
        Dim m_R As Single           ' [1001] Radius of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates of center
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        upward direction of plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() As Single ' [1001] optional start point of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() As Single ' [1001] optional end point of arc
    End Structure

    Structure CAXIS_SPT          ' 3/ID:97  Station point on a Nurb
        Dim m_ILN As Integer        '        ID=97
        Dim m_S As Single           '        Station value at data point
        Dim m_L As Single           ' [1001] Length (prescribed if XYZ==0.0)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates for 3D-intersection plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        Direction (nx,ny,nz) of normal of the plane
    End Structure

    Structure CAXIS_VIZ          ' 3/ID:98  Data points for visualisation
        Dim m_ILN As Integer        '        ID=98
        Dim m_COLOR As Integer      '        hexadecimal RGB-value (e.g. 99AAFF)
        Dim m_THICK As Integer      '        Thickness in pixel
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_PTS() As Single ' [1001] Data Points
    End Structure

    Structure CAXIS_OBB          ' 3/ID:99  Oriented Boundig Box
        Dim m_ILN As Integer        '        ID=99
        Dim m_S1 As Single          '        Parameter on Start
        Dim m_S2 As Single          '        Parameter on end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_TA() As Single '        Transformation Matrix
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Center of Box
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XI() As Single ' [1001] Half widths
    End Structure

    Structure CAXIS_ATB          ' 3/ID:101  Geometric segments of axis plan view
        Dim m_ID0 As Integer        '        ident 101
        Dim m_ID1 As Integer        '        specification type
        Dim m_ID2 As Integer        '        type of transition curve to be used
        Dim m_S As Single           '        Station value at tangent
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_L() As Single ' [1001] Length of segment
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_R() As Single ' [1001] Radius mid & start & end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Startpoint of tangent
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        Tangential direction
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_D() As Single ' [1001] Distance to point on curve (start/end)
        Dim m_TAU As Single         ' [   5] deflection angle
        Dim m_TXT As Integer        '        Identifier of this sequence
    End Structure

    Structure CAXIS_VTB          ' 3/ID:102  Geometric properties for axis heights
        Dim m_ID0 As Integer        '        ident 102
        Dim m_ID1 As Integer        '        specification type
        Dim m_ID2 As Integer        '        reserved
        Dim m_S As Single           '        Parameter s along the axis
        Dim m_H As Single           ' [1001] Height of gradient polygon
        Dim m_R As Single           ' [1001] Radius of curvature at this point
        Dim m_X As Single           ' [1001] Calculated true length along the axis
        Dim m_T As Single           ' [1001] Calculated secant length along the axis
    End Structure

    Structure CAXIS_ITB          ' 3/ID:103  Placement at axis position
        Dim m_ID0 As Integer        '        ident 103
        Dim m_IDS As Integer        '        Enum of secondary axis
        Dim m_TYP As Integer        '        properties of this placement
        Dim m_NPT As Integer        '        point number
        Dim m_GRP As Integer        '        group number behind that placement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NOS() As Integer '        Number of section before and behind that placement
        Dim m_SEGT As Integer       '        identifier of a segment see (900/0) behind that placement
        Dim m_S As Single           '        Parameter s of this section
        Dim m_Y As Single           ' [1001] additional transverse offset
        Dim m_Z As Single           ' [1001] additional vertical offset
        Dim m_ALF As Single         ' [   5] Rotation about global Z
        Dim m_ALFX As Single        ' [   5] Rotation about local axis x
        Dim m_ALFY As Single        ' [   5] Rotation about transverse y
        Dim m_ALFZ As Single        ' [   5] Rotation about vertical   z
        Dim m_INCR As Single        ' [   5] Inclination to the right +y
        Dim m_INCL As Single        ' [   5] Inclination to the left  -y
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() As Integer '        Formula string to evaluate the value S
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Placement
    End Structure

    Structure CAXIS_ITS          ' 3/ID:104  Secondary axis definition
        Dim m_ID0 As Integer        '        Ident 104
        Dim m_IDS As Integer        '        Enum of secondary axis (1='A' to 26 ='Z')
        Dim m_IREF As Integer       '        Reference to external axis geometry
        Dim m_NPT As Integer        '        offset for structural points along the axis
        Dim m_GRP As Integer        '        group number (:103 is always added as an offset)
        Dim m_Y As Single           ' [1001] constant or maximum value of y offset
        Dim m_Z As Single           ' [1001] constant or maximum value of z offset
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_Y_V() As Integer '        variable name for y offset (see :110)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_Z_V() As Integer '        variable name for z offset (see :110)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation (only for first point of a sequence)
    End Structure

    Structure CAXIS_PSM          ' 3/ID:105  Prestress method
        Dim m_ID0 As Integer        '        ident 105
        Dim m_IDT As Integer        '        Identifier of Tendon
        Dim m_TYPE As Integer       '        Type of Spline geometry
        Dim m_NSP As Integer        '        Number of tendon elements
        Dim m_ID5 As Integer        '        Placement of tendons
        Dim m_JACK As Integer       '        Jacking procedure
        Dim m_LIRE As Integer       '        Sides for jacking
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_IBA() As Integer '        Construction stage identifiers
        Dim m_NRSV As Integer       '        number of jacking method
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DUMMY() As Integer '        reserved
        Dim m_FAK As Single         '        factor for prestress
        Dim m_LITZ As Single        '        partial number of strands
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FRSP() As Single ' [1001] Length controls for free tendon geometry
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ZSP() As Single ' [1011] Distances of tendon to extreme fiber upper/lower
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXTL() As Integer '        Designation of layer of Tendons
    End Structure

    Structure CAXIS_PSP          ' 3/ID:106  Prestress placements
        Dim m_ID0 As Integer        '        ident 106
        Dim m_TYP As Integer        '        Type of placement
        Dim m_ID2 As Integer        '        Type of station data (bitpattern)
        Dim m_ID3 As Integer        '        reserved
        Dim m_ID4 As Integer        '        reserved
        Dim m_ID5 As Integer        '        reserved
        Dim m_S As Single           '        Station along axis
        Dim m_ZT As Single          ' [1011] Distances of tendon to extreme fiber upper/lower
        Dim m_DZT As Single         '        inclination of tendon to axis
    End Structure

    Structure CAXIS_PLC          ' 3/ID:107  Placement at axis position
        Dim m_ID0 As Integer        '        ident 107
        Dim m_IDS As Integer        '        Enum of secondary axis
        Dim m_TYP As Integer        '        properties of this placement
        Dim m_NPT As Integer        '        point number
        Dim m_GRP As Integer        '        group number behind that placement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NOS() As Integer '        Number of section before and behind that placement
        Dim m_IB0 As Integer        '        general bit-mask
        Dim m_IDP As Integer        '        identifier of this placement
        Dim m_SEGT As Integer       '        identifier of a segment see (900/0) behind that placement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_RES() As Integer '        reserved
        Dim m_S As Single           '        Parameter s of this section
        Dim m_Y As Single           ' [1001] additional transverse offset
        Dim m_Z As Single           ' [1001] additional vertical offset
        Dim m_ALF As Single         ' [   5] Rotation about global Z
        Dim m_ALFX As Single        ' [   5] Rotation about local axis x
        Dim m_ALFY As Single        ' [   5] Rotation about transverse y
        Dim m_ALFZ As Single        ' [   5] Rotation about vertical   z
        Dim m_INCR As Single        ' [   5] Inclination to the right +y
        Dim m_INCL As Single        ' [   5] Inclination to the left  -y
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() As Integer '        Formula string to evaluate the value S
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of placement
    End Structure

    Structure CAXIS_OPT          ' 3/ID:10107  Placement options
        Dim m_ID0 As Integer        '        ident 10107
        Dim m_A_FILTER As Integer   '        Filter for axis
        Dim m_T_FILTER As Integer   '        Filter for axis type
    End Structure

    Structure CAXIS_PRP          ' 3/ID:110  General properties of axis
        Dim m_ID0 As Integer        '        ident 110
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() As Integer '        Name of this item
        Dim m_TYP As Integer        '        Continuity Type of this data point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_S_VAL() As Single '        Parameter s of this section and values
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_SRULE() As Integer '        Formula string to evaluate the value S
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_VRULE() As Integer '        Formula string to evaluate the value VAL
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_DVRULE() As Integer '        Formula string to evaluate the value dVAL/dS
    End Structure

    Structure CGAXD_ATB          ' 3/ID:121  Geometric segments of axis plan view (double precision)
        Dim m_ID0 As Integer        '        ident 201
        Dim m_ID1 As Integer        '        specification type
        Dim m_ID2 As Integer        '        type of transition curve to be used
        Dim m_ID3 As Integer        '        reserved
        Dim m_S As Double           '        Station value at tangent
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_L() As Double ' [1001] Length of segment
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_R() As Double ' [1001] Radius mid & start & end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Double ' [1001] Startpoint of tangent
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Double '        Tangential direction
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_D() As Double ' [1001] Distance to point on curve (start/end)
        Dim m_TAU As Double         ' [   5] deflection angle
        Dim m_TXT0 As Integer       '        reserved
        Dim m_TXT As Integer        '        Identifier of this sequence
    End Structure

    Structure CGAXD_VTB          ' 3/ID:122  Geometric properties for axis heights (double precision)
        Dim m_ID0 As Integer        '        ident 202
        Dim m_ID1 As Integer        '        specification type
        Dim m_ID2 As Integer        '        reserved
        Dim m_ID3 As Integer        '        reserved
        Dim m_S As Double           '        Parameter s along the axis
        Dim m_H As Double           ' [1001] Height of gradient polygon
        Dim m_R As Double           ' [1001] Radius of curvature at this point
        Dim m_X As Double           ' [1001] Calculated true length along the axis
        Dim m_T As Double           ' [1001] Calculated secant length along the axis
    End Structure

    Const GAXD_GEO_DEFAULT = 181
    Const GAXD_GEO_PROJECT = 182
    Structure CGAXD_GEO          ' 3/ID:18?  Geometric properties
        Dim m_ILN As Integer        '        Code of geometry
        Dim m_ID1 As Integer        '        reserved
        Dim m_GPG As Double         ' [1001] geometry parameter 1
        Dim m_GPA As Double         ' [1001] geometry parameter 2
        Dim m_DD As Double          ' [1001] arc length
        Dim m_S1 As Double          '        parameter s on start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() As Double ' [1001] Ordinate of start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() As Double '        Tangent of start
        Dim m_RG1 As Double         ' [1009] in-plane curvature
        Dim m_RA1 As Double         ' [1009] vertical curvature
        Dim m_S2 As Double          '        parameter s on end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() As Double ' [1001] Ordinate of endpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() As Double '        Tangent of endpoint
        Dim m_RG2 As Double         ' [1009] in-plane curvature
        Dim m_RA2 As Double         ' [1009] vertical curvature
        Dim m_XAT As Double         ' [1001] relat. startordinate
    End Structure

    Structure CGAXD_NKN          ' 3/ID:190  Knots of a Nurb
        Dim m_ILN As Integer        '        ID=290
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Double '        Knot-Vector
    End Structure

    Structure CGAXD_CPT          ' 3/ID:191  Control point of a Nurb
        Dim m_ILN As Integer        '        ID=191
        Dim m_ID1 As Integer        '        reserved
        Dim m_W As Double           '        Weight
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Double ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Double '        upward direction
    End Structure

    Structure CGAXD_PT           ' 3/ID:192  Data point on curve
        Dim m_ILN As Integer        '        ID=192
        Dim m_ID1 As Integer        '        specification type
        Dim m_S As Double           '        Parameter along curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Double ' [1001] Coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Double '        direction
    End Structure

    Structure CGAXD_ARC          ' 3/ID:193  Circular Arc
        Dim m_ILN As Integer        '        ID=93
        Dim m_IDF As Integer        '        Definition selected
        Dim m_R As Double           ' [1001] Radius of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Double ' [1001] Coordinates of center
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Double '        upward direction of plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZA() As Double ' [1001] optional start point of arc
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZE() As Double ' [1001] optional end point of arc
    End Structure

    Structure CAXIS_TRL          ' 3/ID:300  Properties for train loading
        Dim m_ID0 As Integer        '        ident 300
        Dim m_NRA As Integer        '        Number of the lane (0:99)
        Dim m_NRS As Integer        '        Number of the segment
        Dim m_BTYP As Integer       '        Literal of default type
        Dim m_SA As Single          '        Parameter s of start of this section
        Dim m_SE As Single          '        Parameter s of end of this section
        Dim m_YCA As Single         ' [1001] Center ordinate of lane at SA
        Dim m_YCE As Single         ' [1001] Center ordinate of lane at SE
        Dim m_YRA As Single         ' [1001] Right boundary at SA of lane area
        Dim m_YRE As Single         ' [1001] Right boundary at SE of lane area
        Dim m_YLA As Single         ' [1001] Left boundary at SA of lane area
        Dim m_YLE As Single         ' [1001] Left boundary at SE of lane area
        Dim m_L As Single           ' [1001] Reference length for impact factor
        Dim m_HSA As Single         ' [1001] Total height of traffic lane above axis at SA
        Dim m_HSE As Single         ' [1001] Total height of traffic lane above axis at SE
        Dim m_INCA As Single        ' [   5] Inclination within lane at SA
        Dim m_INCE As Single        ' [   5] Inclination within lane at SE
        Dim m_HEFF As Single        ' [1001] Height of rail and sleeper construction
        Dim m_BEFF As Single        ' [1001] Effective length of sleeper
        Dim m_DEFF As Single        ' [1001] Width of sleepers
        Dim m_INCD As Single        '        Inclination of load distribution (e.g. 1:4)
        Dim m_ASL As Single         ' [1001] Distance of Sleepers or mounting points
    End Structure

    Structure CTEND              ' 4/ID:0  Prestressing Schemes
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_KEY As Integer        '        Control bits + Info
        Dim m_MNR As Integer        '        Material number Steel
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Main Designation of company and scheme
    End Structure

    Structure CTEND_1            ' 4/ID:1  Tendon of Prestressing Schemes
        Dim m_ID0 As Integer        '        identifier 1
        Dim m_ID1 As Integer        '        reserved
        Dim m_ID2 As Integer        '        reserved
        Dim m_ZV As Single          ' [1028] Nominal force
        Dim m_AZ As Single          ' [1020] Area of tendon
        Dim m_RNLI As Single        '        Number or wires
        Dim m_SLS As Single         ' [  16] Slip at anchor
        Dim m_SLK As Single         ' [  16] Slip at coupling
        Dim m_SLF As Single         ' [  16] Slip at fixed end
        Dim m_VLS As Single         '        Loss at anchor
        Dim m_VLK As Single         '        Loss at coupling
        Dim m_VLF As Single         '        Loss at fixed end
        Dim m_DLS As Single         ' [1001] Straight at anchor
        Dim m_DLK As Single         ' [1001] Straight at coupling
        Dim m_DLF As Single         ' [1001] Straight at fixed end
        Dim m_DI As Single          ' [1023] inner diameter of duct
        Dim m_DA As Single          ' [1023] outer diamtere of duct
        Dim m_RMIN As Single        ' [1001] minimum radius
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_BETA() As Single ' [  17] unintended angles
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_RMUE() As Single '        Friction coefficients
        Dim m_EXZ As Single         ' [1011] max exzentricity
        Dim m_EACHS As Single       ' [1011] distance between
        Dim m_ERAND As Single       ' [1011] distance to outer edge
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_BLOCK() As Single '        reserved extra data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Designation of tendon
    End Structure

    Structure CTEND_2            ' 4/ID:2  Anchor of Prestressing Schemes
        Dim m_ID0 As Integer        '        identifier 2
        Dim m_ID1 As Integer        '        Type of anchor
        Dim m_TYP As Integer        '        Type of anchor geometry
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ANKER() As Single '        Data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Designation of anchor
    End Structure

    Structure CTEND_3            ' 4/ID:3  Jack of Prestressing Schemes
        Dim m_ID0 As Integer        '        identifier 2
        Dim m_ID1 As Integer        '        reserved
        Dim m_TYP As Integer        '        Type of jack
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_JACK() As Single '        Data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Designation of jack
    End Structure

    Structure CAREA              ' 5/ID:0  Geometric Area
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_NG As Integer         '        Type of surface representation
        Dim m_GID1 As Integer       '        Axis identifier of first reference axis
        Dim m_GID2 As Integer       '        Axis identifier of second reference axis
        Dim m_MGRI As Integer       '        number of data/control points in s of mesh
        Dim m_NGRI As Integer       '        number of data/control points in t of mesh
        Dim m_MSPL As Integer       '        degree of B-spline in s direction
        Dim m_NSPL As Integer       '        degree of B-spline in t direction
        Dim m_SFLG As Integer       '        property options of surface
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() As Single '        Transformation
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() As Single '        additional Parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() As Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Line
    End Structure

    Structure CAREA_CPT          ' 5/ID:10  Control points of area
        Dim m_ID As Integer         '        Identification of control point data = 10
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_XPAR() As Single '        spline grid and coefficients
    End Structure

    Structure CAREA_PTS          ' 5/ID:11  AreaPointonSurface
        Dim m_ID As Integer         '        Identification of surface description = 11
        Dim m_IT As Integer         '        Type of point
        Dim m_M As Integer          '        Rasterlocation of mesh (0 < m < mgri )
        Dim m_N As Integer          '        Rasterlocation of mesh (0 < n < ngri )
        Dim m_W As Single           '        the weight of NURBS control point
        Dim m_X As Single           ' [1001] X-ordinate
        Dim m_Y As Single           ' [1001] Y-ordinate
        Dim m_Z As Single           ' [1001] Z-ordinate
        Dim m_T As Single           ' [1010] Thickness
    End Structure

    Structure CAREA_CPI          ' 5/ID:12  COONsPatchInfo
        Dim m_ID As Integer         '        Identification of COONs blending edges 12
        Dim m_IT As Integer         '        Type of blending
        Dim m_IU0 As Integer        '        No of geometry line for u=umin (left)
        Dim m_IU1 As Integer        '        No of geometry line for u=umax (right)
        Dim m_IV0 As Integer        '        No of geometry line for v=vmin (lower)
        Dim m_IV1 As Integer        '        No of geometry line for v=vmax (upper)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_SP() As Single '        Length parameters for the edges iu0,iu1,iv0,iv1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() As Single '        umin,umax,vmin,vmax of the parameter plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_CXYZ() As Single '        Coordinates of the corner points C1,C2,C3,C4
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_TINC() As Single '        inclinations for a bicubic patch as vectors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TWIST() As Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
    End Structure

    Structure CAREA_NKN          ' 5/ID:9?  Knots of a Nurb
        Dim m_ILN As Integer        '        ID
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Single '        Knot-Vector
    End Structure

    Structure CGARD_PTS          ' 5/ID:290  AreaPointonSurface
        Dim m_ID As Integer         '        Id = 290
        Dim m_IT As Integer         '        Type of point
        Dim m_M As Integer          '        Rasterlocation of mesh (0 < m < mgri )
        Dim m_N As Integer          '        Rasterlocation of mesh (0 < n < ngri )
        Dim m_W As Double           '        the weight of NURBS control point
        Dim m_X As Double           ' [1001] X-ordinate
        Dim m_Y As Double           ' [1001] Y-ordinate
        Dim m_Z As Double           ' [1001] Z-ordinate
        Dim m_T As Double           ' [1010] Thickness
    End Structure

    Structure CGARD_NKU          ' 5/ID:291  Knots of a Nurb
        Dim m_ILN As Integer        '        ID
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Double '        Knot-Vector
    End Structure

    Structure CGARD_NKV          ' 5/ID:292  Knots of a Nurb
        Dim m_ILN As Integer        '        ID
        Dim m_DEG As Integer        '        Order of Spline
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=256)> Dim m_S() As Double '        Knot-Vector
    End Structure

    Structure CCON_0             ' 8/ID:0  Connection Headder
        Dim m_IDS As Integer        '        Identification = 0
        Dim m_TYP As Integer        '        Type of connection
        Dim m_MAT As Integer        '        Materialnumber for all plates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        designation of connection
    End Structure

    Structure CCON_BOL           ' 8/ID:1  Definition of Bolts
        Dim m_IDS As Integer        '        Identification = 1
        Dim m_TYP As Integer        '        Type of hole
        Dim m_MAT As Integer        '        Materialdesignation of bolt
        Dim m_D As Single           ' [1011] Diameter of bolt
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NORM() As Integer '        Designation of product code
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        designation of bolt
    End Structure

    Structure CCON_WEL           ' 8/ID:2  Definition of Weldings
        Dim m_IDS As Integer        '        Identification = 2
        Dim m_TYP As Integer        '        Type of weld
        Dim m_MAT As Integer        '        Materialnumber of weld (not used)
        Dim m_T As Single           ' [1011] Thickness of weld
        Dim m_AW As Single          '        Reduction factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        designation of weld
    End Structure

    Structure CCON_CLE           ' 8/ID:3  Definition of Cleats (Angle/Latch)
        Dim m_IDS As Integer        '        Identification = 3
        Dim m_TYP As Integer        '        Enum of type (angle/latch not really enforced)
        Dim m_MAT As Integer        '        Material number of the plate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_BOL() As Integer '        id of bolts
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NBB() As Integer '        Number of bolts in width direction
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NBL() As Integer '        Number of bolts in angle directions 1 & 2
        Dim m_T As Single           ' [1011] Thickness of cleat
        Dim m_B As Single           ' [1011] Width/Height of cleat
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_L() As Single ' [1011] Length of angles
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_W() As Single ' [1011] Distances
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_A() As Single ' [1011] weld thickness for NBL(i) if welding is used
        Dim m_TF As Single          ' [1011] Thickness of backplate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        designation of element
    End Structure

    Structure CCON_MEM           ' 8/ID:10  Connected Member data
        Dim m_IDS As Integer        '        Identification = 10
        Dim m_NR As Integer         '        Enumeration or designation of member
        Dim m_TYP As Integer        '        Type of connection bitpattern
        Dim m_NRQ As Integer        '        Number of section
        Dim m_WTYP As Integer       '        id of the web connection
        Dim m_UTYP As Integer       '        id of the upper flange connection
        Dim m_LTYP As Integer       '        id of the lower flange connection
        Dim m_L As Single           ' [1001] length of member
        Dim m_AW As Single          ' [1011] weld thickness for web connection
        Dim m_AU As Single          ' [1011] weld thickness for upper flange connection
        Dim m_AL As Single          ' [1011] weld thickness for lower flange connection
        Dim m_DD As Single          ' [1011] Distance value of endpoint to central node
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_D() As Single '        Direction vector to beam axis in the
        Dim m_ROTY As Single        ' [   5] Angle of end plate y-rotation
        Dim m_ROTZ As Single        ' [   5] Angle of end plate z-rotation
        Dim m_CUTU As Single        ' [1011] Cut out height for upper flange
        Dim m_CUTL As Single        ' [1011] Cut out height for lower flange
        Dim m_CLU As Single         ' [1011] Cut out length for upper flange
        Dim m_CLD As Single         ' [1011] Cut out length for lower flange
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_VOUTE() As Single ' [1011] Voute [lenght,height] for
    End Structure

    Structure CCON_END           ' 8/ID:11  Endplate of Beam
        Dim m_IDS As Integer        '        Identification = 11
        Dim m_TYP As Integer        '        Type of end plate
        Dim m_MAT As Integer        '        Materialnumber of endplate
        Dim m_BOLT As Integer       '        Identifier of bolt type
        Dim m_NBR As Integer        '        Number of bolts in height direction
        Dim m_NBC As Integer        '        Number of bolts in width direction
        Dim m_B As Single           ' [1011] Width of plate
        Dim m_H As Single           ' [1011] Total plate height
        Dim m_MX As Single          ' [1011] Eccentricity
        Dim m_T As Single           ' [1011] Thickness of plate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HB() As Single ' [1011] Height for bolts
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_W() As Single ' [1011] Width for bolts
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_HTBP() As Single ' [1011] Height and thickness values for back plates
    End Structure

    Structure CCON_PIN           ' 8/ID:12  Pinned plate of Beam
        Dim m_IDS As Integer        '        Identification = 13
        Dim m_MAT As Integer        '        Materialnumber of pin plate
        Dim m_MATS As Integer       '        Materialnumber of support plate
        Dim m_MATP As Integer       '        Materialnumber of pin
        Dim m_DP As Single          ' [1011] Diameter of pin
        Dim m_DH As Single          ' [1011] Diameter of hole
        Dim m_TP As Single          ' [1011] Thickness pin plate
        Dim m_TSUP As Single        ' [1011] Thickness sup plate
        Dim m_C As Single           ' [1011] gap between plates
        Dim m_E1 As Single          ' [1011] eccentricity 1
        Dim m_E2 As Single          ' [1011] eccentricity 2
    End Structure

    Structure CCON_PLT           ' 8/ID:20  Additional plates in connection
        Dim m_IDS As Integer        '        Identification = 20
        Dim m_TYP As Integer        '        Type of plate
        Dim m_MAT As Integer        '        Number of material
        Dim m_T As Single           ' [1011] Thickness of plate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_EDGE() As Single ' [1011] Local coordinates, weldid, weldthickness
    End Structure

    Structure CSECT              ' 9/NR:0  SectionalValues (total section)
        Dim m_ID As Integer         '        Identification
        Dim m_MNO As Integer        '        Materialnumber of sections
        Dim m_MRF As Integer        '        Materialnumber of Reinforcement
        Dim m_A As Single           ' [1012] Area
        Dim m_AY As Single          ' [1012] Sheardeformation area Y
        Dim m_AZ As Single          ' [1012] Sheardeformation area Z
        Dim m_IT As Single          ' [1014] Torsional moment of inertia
        Dim m_IY As Single          ' [1014] Moments of inertia y-y
        Dim m_IZ As Single          ' [1014] Moments of inertia z-z
        Dim m_IYZ As Single         ' [1014] Moments of inertia y-z
        Dim m_YS As Single          ' [1011] y-Ordinate Center of gravity
        Dim m_ZS As Single          ' [1011] z-Ordinate Center of gravity
        Dim m_YSC As Single         ' [1011] y-Ordinate of Shear-Center
        Dim m_ZSC As Single         ' [1011] z-Ordinate of Shear-Center
        Dim m_EM As Single          ' [1090] Elasticity Modulus
        Dim m_GM As Single          ' [1090] Shear Modulus
        Dim m_GAM As Single         ' [1091] Deadweight
    End Structure

    Structure CSECT_EFF          ' 9/NR:1  SectionalValues (effective section)
        Dim m_ID As Integer         '        Identification
        Dim m_MNO As Integer        '        Materialnumber of sections
        Dim m_MRF As Integer        '        Materialnumber of Reinforcement
        Dim m_A As Single           ' [1012] Area
        Dim m_AY As Single          ' [1012] Sheardeformation area Y
        Dim m_AZ As Single          ' [1012] Sheardeformation area Z
        Dim m_IT As Single          ' [1014] Torsional moment of inertia
        Dim m_IY As Single          ' [1014] Moments of inertia y-y
        Dim m_IZ As Single          ' [1014] Moments of inertia z-z
        Dim m_IYZ As Single         ' [1014] Moments of inertia y-z
        Dim m_YS As Single          ' [1011] y-Ordinate Center of gravity
        Dim m_ZS As Single          ' [1011] z-Ordinate Center of gravity
        Dim m_YSC As Single         ' [1011] y-Ordinate of Shear-Center
        Dim m_ZSC As Single         ' [1011] z-Ordinate of Shear-Center
        Dim m_EM As Single          ' [1090] Elasticity Modulus
        Dim m_GM As Single          ' [1090] Shear Modulus
        Dim m_GAM As Single         ' [1091] Deadweight
    End Structure

    Structure CSECT_PAR          ' 9/NR:2  SectionalValues (total part of section)
        Dim m_ID As Integer         '        Identification
        Dim m_MNO As Integer        '        Materialnumber of sections
        Dim m_MRF As Integer        '        Materialnumber of Reinforcement
        Dim m_A As Single           ' [1012] Area
        Dim m_AY As Single          ' [1012] Sheardeformation area Y
        Dim m_AZ As Single          ' [1012] Sheardeformation area Z
        Dim m_IT As Single          ' [1014] Torsional moment of inertia
        Dim m_IY As Single          ' [1014] Moments of inertia y-y
        Dim m_IZ As Single          ' [1014] Moments of inertia z-z
        Dim m_IYZ As Single         ' [1014] Moments of inertia y-z
        Dim m_YS As Single          ' [1011] y-Ordinate Center of gravity
        Dim m_ZS As Single          ' [1011] z-Ordinate Center of gravity
        Dim m_YSC As Single         ' [1011] y-Ordinate of Shear-Center
        Dim m_ZSC As Single         ' [1011] z-Ordinate of Shear-Center
        Dim m_EM As Single          ' [1090] Elasticity Modulus
        Dim m_GM As Single          ' [1090] Shear Modulus
        Dim m_GAM As Single         ' [1091] Deadweight
    End Structure

    Structure CSECT_PEF          ' 9/NR:3  SectionalValues (effective part of section)
        Dim m_ID As Integer         '        Identification
        Dim m_MNO As Integer        '        Materialnumber of sections
        Dim m_MRF As Integer        '        Materialnumber of Reinforcement
        Dim m_A As Single           ' [1012] Area
        Dim m_AY As Single          ' [1012] Sheardeformation area Y
        Dim m_AZ As Single          ' [1012] Sheardeformation area Z
        Dim m_IT As Single          ' [1014] Torsional moment of inertia
        Dim m_IY As Single          ' [1014] Moments of inertia y-y
        Dim m_IZ As Single          ' [1014] Moments of inertia z-z
        Dim m_IYZ As Single         ' [1014] Moments of inertia y-z
        Dim m_YS As Single          ' [1011] y-Ordinate Center of gravity
        Dim m_ZS As Single          ' [1011] z-Ordinate Center of gravity
        Dim m_YSC As Single         ' [1011] y-Ordinate of Shear-Center
        Dim m_ZSC As Single         ' [1011] z-Ordinate of Shear-Center
        Dim m_EM As Single          ' [1090] Elasticity Modulus
        Dim m_GM As Single          ' [1090] Shear Modulus
        Dim m_GAM As Single         ' [1091] Deadweight
    End Structure

    Const SECT_ADD_MOD = 0
    Const SECT_ADD_VAL = 1
    Const SECT_ADD_TYP = 2
    Const SECT_ADD_PLA = 3
    Const SECT_ADD_SOL = 4
    Const SECT_ADD_EFF = 5
    Const SECT_ADD_FEM = 6
    Const SECT_ADD_HYD = 9
    Const SECT_ADD_FIBRE = +128
    Const SECT_ADD_NEFF = +512
    Const SECT_ADD_INTE = +1024
    Const SECT_ADD_TEMP = +2048
    Const SECT_ADD_VARI = +4096
    Const SECT_ADD_REFP = +8192
    Const SECT_ADD_HOT = +16384
    Structure CSECT_ADD          ' 9/NR:4  SectionalValuesShear , Temperature
        Dim m_ID As Integer
        Dim m_STYPE As Integer
        Dim m_MRF As Integer        '        Materialnumber of Stirup-Reinforcement
        Dim m_AT As Single          ' [ 107] Elongationkoefficient for Temperature
        Dim m_YMIN As Single        ' [1011] Minimum Ordinate of section to center ys
        Dim m_YMAX As Single        ' [1011] Maximum Ordinate of section to center ys
        Dim m_ZMIN As Single        ' [1011] Minimum Ordinate of section to center zs
        Dim m_ZMAX As Single        ' [1011] Maximum Ordinate of section to center zs
        Dim m_TMIN As Single        ' [1011] minimum thickness
        Dim m_TMAX As Single        ' [1011] maximum thickness
        Dim m_WT As Single          ' [1018] maximum tau for Torsion MT=1
        Dim m_WVY As Single         ' [1017] maximum tau for Shear VY=1
        Dim m_WVZ As Single         ' [1017] maximum tau for Shear VZ=1
        Dim m_WT2 As Single         ' [1018] maximum tau for sekundary Torsion
        Dim m_AK As Single          ' [1012] kernel area for Torsion
        Dim m_AYZ As Single         ' [1012] Shear deviation area
        Dim m_AB As Single          ' [1012] pure concrete area
        Dim m_LEVY As Single        ' [1011] minimum lever for cracked shear Vy
        Dim m_LEVZ As Single        ' [1011] minimum lever for cracked shear Vz
        Dim m_ELVY As Single        ' [1011] elastic lever for shear Vy = Sy-max/Iz
        Dim m_ELVZ As Single        ' [1011] elastic lever for shear Vz = Sz-max/Iy
        Dim m_YMINE As Single       ' [1011] Minimum Ordinate of effective section
        Dim m_YMAXE As Single       ' [1011] Maximum Ordinate of effective section
        Dim m_ZMINE As Single       ' [1011] Minimum Ordinate of effective section
        Dim m_ZMAXE As Single       ' [1011] Maximum Ordinate of effective section
    End Structure

    Structure CSECT_WAR          ' 9/NR:5  SectionalValuesWarping
        Dim m_ID As Integer         '        Identification = 5
        Dim m_I_1 As Integer        '        unused
        Dim m_I_2 As Integer        '        unused
        Dim m_AYYY As Single        ' [1015] Integrals on section
        Dim m_AYYZ As Single        ' [1015] Integrals on section
        Dim m_AYZZ As Single        ' [1015] Integrals on section
        Dim m_AZZZ As Single        ' [1015] Integrals on section
        Dim m_AWY As Single         ' [1015] Integrals on section
        Dim m_AWZ As Single         ' [1015] Integrals on section
        Dim m_AWYY As Single        ' [1016] Integrals on section
        Dim m_AWZZ As Single        ' [1016] Integrals on section
        Dim m_CM As Single          ' [1016] Warping resistance
        Dim m_CMS As Single         ' [1014] Warping Shear resist.
        Dim m_WMIN As Single        ' [1012] Minimum warping
        Dim m_WMAX As Single        ' [1012] Maximum warping
        Dim m_FYSW As Single        ' [1012] Shear VY-MT2 area
        Dim m_FZSW As Single        ' [1012] Shear VZ-MT2 area
        Dim m_IPSC As Single        ' [1014] polar inertia at SC
    End Structure

    Structure CSECT_PLA          ' 9/NR:6  SectionalPlasticForces
        Dim m_ID As Integer         '        Identification = 6
        Dim m_IBC As Integer        '        Buckling curve IBC
        Dim m_IB As Integer         '        Control
        Dim m_WPN As Single         ' [1101] Normal force
        Dim m_WPVY As Single        ' [1102] Y-Shear force
        Dim m_WPVZ As Single        ' [1102] Y-Shear force
        Dim m_WPMT As Single        ' [1103] Torsional moment
        Dim m_WPMY As Single        ' [1104] Bending moment My
        Dim m_WPMZ As Single        ' [1104] Bending moment Mz
        Dim m_YSP As Single         ' [1001] Plastic center
        Dim m_ZSP As Single         ' [1001] Plastic center
        Dim m_WPMB As Single        ' [1105] warping moment Mb
        Dim m_WPT2 As Single        ' [1103] 2nd torsional moment
    End Structure

    Structure CSECT_DES          ' 9/NR:7  SectionalValuesDesign
        Dim m_ID As Integer         '        Identification = 7
        Dim m_MNR As Integer        '        used reference material
        Dim m_IBC As Integer        '        buckling curve index
        Dim m_A As Single           ' [1012] Area
        Dim m_AY As Single          ' [1012] Sheardeformation area Y
        Dim m_AZ As Single          ' [1012] Sheardeformation area Z
        Dim m_IT As Single          ' [1014] Torsional moment of inertia
        Dim m_IY As Single          ' [1014] Moments of inertia y-y
        Dim m_IZ As Single          ' [1014] Moments of inertia z-z
        Dim m_IYZ As Single         ' [1014] Moments of inertia y-z
        Dim m_YS As Single          ' [1011] y-Ordinate Center of gravity
        Dim m_ZS As Single          ' [1011] z-Ordinate Center of gravity
        Dim m_YSC As Single         ' [1011] y-Ordinate of Shear-Center
        Dim m_ZSC As Single         ' [1011] z-Ordinate of Shear-Center
        Dim m_EM As Single          ' [1090] Elasticity Modulus/safety
        Dim m_GM As Single          ' [1090] Shear Modulus/safety
        Dim m_GAM As Single         ' [1091] Deadweight
    End Structure

    Structure CSECT_PRE          ' 9/NR:8  SectionalForcesPrestress
        Dim m_ID As Integer         '        Identification = 8
        Dim m_ITP As Integer        '        subtype of information = 0
        Dim m_ITS As Integer        '        source of values
        Dim m_N As Single           ' [1101] Normal force
        Dim m_MY As Single          ' [1104] Bending moment My
        Dim m_MZ As Single          ' [1104] Bending moment Mz
        Dim m_EA As Single          ' [1101] tangential stiffnes E*A
        Dim m_EAY As Single         ' [1105] tangential stiffnes E*A*z*z
        Dim m_EAZ As Single         ' [1105] tangential stiffnes E*A*y*y
        Dim m_EAYZ As Single        ' [1105] tangential stiffnes E*A*y*z
        Dim m_YSE As Single         ' [1011] elastic tangential center ys
        Dim m_ZSE As Single         ' [1011] elastic tangential center zs
        Dim m_NCM As Single         ' [1101] maximum compressive force
        Dim m_NTM As Single         ' [1101] maximum tensile force
    End Structure

    Structure CSECT_GV           ' 9/NR:8  SectionalGeometricValues
        Dim m_ID As Integer         '        Identification = 8
        Dim m_ITP As Integer        '        subtype of information = 2
        Dim m_MNO As Integer        '        Materialnumber (0=total section)
        Dim m_UO As Single          ' [1011] outer perimeter
        Dim m_UI As Single          ' [1011] inner perimeter
        Dim m_TMIN As Single        ' [1011] minimum thickness
        Dim m_TMAX As Single        ' [1011] maximum thickness
        Dim m_KTZ As Single         ' [   8] total weight factor
        Dim m_UOM As Single         ' [1011] outer effect.perimeter
        Dim m_UIM As Single         ' [1011] inner effect.perimeter
        Dim m_ARO As Single         ' [1012] Outer total gross area
        Dim m_AR As Single          ' [1012] total gross area
        Dim m_IPM As Single         ' [1014] rotational inertia      gam*Ip
        Dim m_IYM As Single         ' [1014] sectional mass inertia  gam*Iy
        Dim m_IZM As Single         ' [1014] sectional mass inertia  gam*Iz
        Dim m_IYZM As Single        ' [1014] sectional mass inertia  gam*Iyz
        Dim m_YSM As Single         ' [1011] true mass gravity center
        Dim m_ZSM As Single         ' [1011] true mass gravity center
        Dim m_DW As Single          ' [1011] effective thickness for creep/shrinkage
        Dim m_UAIR As Single        ' [1011] air contact perimeter
    End Structure

    Structure CSECT_TRA          ' 9/NR:8  SectionalAppliedTransformation
        Dim m_ID As Integer         '        Identification = 8
        Dim m_ITP As Integer        '        subtype of information = 3
        Dim m_I_2 As Integer        '        not used
        Dim m_ALF As Single         ' [   5] rotation angle
        Dim m_YTF As Single         ' [1011] shift in y direction
        Dim m_ZTF As Single         ' [1011] shift in z direction
    End Structure

    Structure CSECT_LAY          ' 9/NR:9  SectionalReinforcementLayer
        Dim m_ID As Integer         '        Identification = 9
        Dim m_MNR As Integer        '        Materialnumber + 1000*No of concrete \%
        Dim m_INR As Integer        '        Type/number of layer
        Dim m_TNR As Integer        '        Designation
        Dim m_ALOW As Single        ' [1020] Lower bound for area of layer
        Dim m_AHIG As Single        ' [1020] Upper bound for area of layer
        Dim m_ASUM As Single        ' [1020] Sum of reference areas of layer
        Dim m_AFAK As Single        '        maximum allowable factor of layer
        Dim m_YS As Single          ' [1011] center of layer
        Dim m_ZS As Single          ' [1011] center of layer
        Dim m_VAS As Single         ' [1020] Lower sequential total bound of layer area
        Dim m_BAS As Single         ' [1020] Upper sequential total bound of layer area
        Dim m_IY As Single          ' [1014] 4th ord.areas (inertia)
        Dim m_IZ As Single          ' [1014] 4th ord.areas (inertia)
        Dim m_IYZ As Single         ' [1014] 4th ord.areas (inertia)
        Dim m_EMOD As Single        ' [1090] Elasticity-Modulus
        Dim m_BETS As Single        ' [1092] yieldstress
        Dim m_RL As Single          ' [1011] torsional refer. length
        Dim m_N As Single           ' [1101] Normal force
        Dim m_MY As Single          ' [1104] Bending moment My
        Dim m_MZ As Single          ' [1104] Bending moment Mz
        Dim m_EA As Single          ' [1101] tangential stiffnes E*A
        Dim m_EAY As Single         ' [1105] tangential stiffnes E*A*z*z
        Dim m_EAZ As Single         ' [1105] tangential stiffnes E*A*y*y
        Dim m_EAYZ As Single        ' [1105] tangential stiffnes E*A*y*z
        Dim m_YSE As Single         ' [1011] elastic tangential center ys
        Dim m_ZSE As Single         ' [1011] elastic tangential center zs
    End Structure

    Const SECT_REC_PLATE = 0
    Const SECT_REC_RECT = 1
    Const SECT_REC_TBEAM = 2
    Const SECT_REC_VPLAT = 4
    Const SECT_REC_VHREC = 5
    Const SECT_REC_VBREC = 6
    Const SECT_REC_VRECT = 7
    Const SECT_REC_RF_CU = 0
    Const SECT_REC_RF_SYM = 1
    Const SECT_REC_RF_ASY = 2
    Const SECT_REC_RF_AST = 3
    Const SECT_REC_RF_ASB = 4
    Const SECT_REC_CORNER = 8
    Const SECT_REC_RF_TRA = 64
    Const SECT_REC_BUNDLE = 128
    Structure CSECT_REC          ' 9/NR:10  SectiontypeRectangular T-Beam
        Dim m_ID As Integer         '        Identification = 10
        Dim m_IQ As Integer         '        Identification of section
        Dim m_IR As Integer         '        Identification of reinforcement and origin
        Dim m_H As Single           ' [1011] total height
        Dim m_B As Single           ' [1011] width (of web)
        Dim m_SO As Single          ' [1024] Boundary distance of upper reinforcement
        Dim m_SU As Single          ' [1024] Boundary distance of lower reinforcement
        Dim m_ASO As Single         ' [1020] reinforcement up
        Dim m_ASU As Single         ' [1020] reinforcement down
        Dim m_HO As Single          ' [1011] height of plate
        Dim m_BO As Single          ' [1011] width  of plate
        Dim m_DASO As Single        ' [1023] reinf. Diameter up
        Dim m_DASU As Single        ' [1023] reinf. Diameter dn
        Dim m_FKIT As Single        '        <0 = factor for torsional inertia >0 = absolut value of torsion
        Dim m_FKAY As Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
        Dim m_FKAZ As Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
        Dim m_YSMP As Single        ' [1011] explicit location of shear center
        Dim m_ZSSMP As Single       ' [1011] explicit location of shear center
        Dim m_YS As Single          ' [1011] explicit location of reference point
        Dim m_ZS As Single          ' [1011] explicit location of reference point
        Dim m_PHIB As Single        ' [   5] inclination of shear links
        Dim m_BEFF As Single        ' [1011] width of equivalent hollow section
        Dim m_ASBM As Single        ' [1029] Minimum shear reinf.
        Dim m_A As Single           ' [1011] spacing of reinforcements
        Dim m_AMIN As Single        ' [1011] minimum distance of single reinforcements
        Dim m_AMAX As Single        ' [1011] maximum distance of single reinforcements
        Dim m_SS As Single          ' [1024] Boundary distance of lateral reinforcement
        Dim m_DASS As Single        ' [1023] reinf. Diameter side
        Dim m_HMAX As Single        ' [1011] maximum mesh size for FE/fibre analysis
    End Structure

    Structure CSECT_ANN          ' 9/NR:11  SectiontypeAnnular
        Dim m_ID As Integer         '        Identification = 11
        Dim m_IR As Integer         '        Identification of section
        Dim m_IR2 As Integer        '        Identification of reinforcement
        Dim m_RO As Single          ' [1011] outer radius
        Dim m_RI As Single          ' [1011] inner radius
        Dim m_ROS As Single         ' [1011] outer reinf radius
        Dim m_RIS As Single         ' [1011] inner reinf radius
        Dim m_ASO As Single         ' [1020] outer reinforcement
        Dim m_ASI As Single         ' [1020] inner reinforcement
        Dim m_DASO As Single        ' [1023] reinf. Diameter
        Dim m_AMAX As Single        ' [1011] maximum distance of single reinforcements
        Dim m_ASBM As Single        ' [1029] Minimum shear reinf.
        Dim m_HMAX As Single        ' [1011] maximum mesh size for FE/fibre analysis
        Dim m_FKIT As Single        '        <0 = factor for torsional inertia >0 = absolut value of torsion
        Dim m_FKAY As Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
        Dim m_FKAZ As Single        '        <0 = factor for shear deformation area >0 = absolut value of sh
    End Structure

    Structure CSECT_TUB          ' 9/NR:11  SectiontypeTube
        Dim m_ID As Integer         '        Identification = 11
        Dim m_IR As Integer         '        Identification of section = 2
        Dim m_IR2 As Integer        '        property Bit
        Dim m_D As Single           ' [1011] Diameter
        Dim m_T As Single           ' [1011] thickness of tubes
    End Structure

    Structure CSECT_CAB          ' 9/NR:11  SectiontypeCable
        Dim m_ID As Integer         '        Identification = 11
        Dim m_IR As Integer         '        Identification of section = 3
        Dim m_IC As Integer         '        sectiontype*256 + codeflag*64 + inlet type
        Dim m_D As Single           ' [1011] Diameter
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_TYP() As Integer '        Literal of type
        Dim m_INL As Integer        '        Literal of inlet
        Dim m_NLI As Single         '        no of strands
        Dim m_NDR As Single         '        no of wires
        Dim m_F As Single           '        fill factor
        Dim m_K As Single           '        cable factor
        Dim m_W As Single           '        weight factor
        Dim m_KE As Single          '        loss factor
        Dim m_ZD As Single          ' [1090] design  force
        Dim m_ZB As Single          ' [1090] rupture force
        Dim m_GAM As Single         ' [ 158] weight
    End Structure

    Structure CSECT_PRO          ' 9/NR:12  SectiontypeShape
        Dim m_ID As Integer         '        Identification = 12
        Dim m_MNO As Integer        '        Materialnumber + 1000*imbedded Materialnumber
        Dim m_IBIT As Integer       '        ityp + 64*iref + 1024*ivtp
        Dim m_TYP As Integer        '        type of section
        Dim m_Z1 As Single          '        first dimension mm
        Dim m_Z2 As Single          '        first dimension mm
        Dim m_Z3 As Single          '        first dimension mm
        Dim m_ALF As Single         ' [   5] rotation angle
        Dim m_IT As Single          ' [1014] tabul.Tors.Inertia
        Dim m_YSC As Single         ' [1011] tabul.shear center
        Dim m_ZSC As Single         ' [1011] tabul.shear center
        Dim m_H As Single           ' [1011] height
        Dim m_B As Single           ' [1011] width
        Dim m_S As Single           ' [1011] thickness of web
        Dim m_T As Single           ' [1011] thickness of flange
        Dim m_R1 As Single          ' [1011] radius
        Dim m_R2 As Single          ' [1011] radius
        Dim m_YOFF As Single        ' [1011] y coord. offset
        Dim m_ZOFF As Single        ' [1011] z coord. offset
        Dim m_CM As Single          ' [1016] tabul.warp.resist.
        Dim m_WMIN As Single        ' [1012] charact. warping 1
        Dim m_WMAX As Single        ' [1012] charact. warping 2
        Dim m_WT As Single          ' [1018] Torsional resist.
        Dim m_AY As Single          ' [1012] Shear area
        Dim m_AZ As Single          ' [1012] Shear area
        Dim m_RID As Integer        '        user defined ident
        Dim m_WU1 As Single         ' [1011] bolt position 1
        Dim m_WU2 As Single         ' [1011] bolt position 2
        Dim m_WU3 As Single         ' [1011] bolt position 3
        Dim m_YREF As Single        ' [1011] Coordinates of
        Dim m_ZREF As Single        ' [1011] Reference point
        Dim m_B2 As Single          ' [1011] width lower part
        Dim m_T2 As Single          ' [1011] lower flange thick.
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_BEZ() As Integer '        character of shape
        Dim m_VYPL As Single        ' [1102] plastic shear force Vy
        Dim m_VZPL As Single        ' [1102] plastic shear force Vz
        Dim m_MTPL As Single        ' [1103] plastic torsional   Mt
        Dim m_MT2PL As Single       ' [1103] plastic torsional   Mt2
        Dim m_MBPL As Single        ' [1103] plastic warpmoment  Mb
    End Structure

    Structure CSECT_TBA          ' 9/NR:18  List of construction stages
        Dim m_ID As Integer         '        Identification = 18
        Dim m_IBA As Integer        '        Headder of construction stages = 0
        Dim m_IBD As Integer        '        Number of materials over all construction stages
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_IBAT() As Integer '        List of external construction stage numbers
    End Structure

    Structure CSECT_IBA          ' 9/NR:18  ConstructionStage
        Dim m_ID As Integer         '        Identification = 18
        Dim m_IBA As Integer        '        number of construction stage BIRTH
        Dim m_IBD As Integer        '        number of construction stage DEATH
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Text
    End Structure

    Structure CSECT_TXT          ' 9/NR:19  SectionText
        Dim m_ID As Integer         '        Identification = 19
        Dim m_NR As Integer         '        external construction stage number for CS separator
        Dim m_IDS As Integer        '        Source/Selector flag
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_TXT() As Integer '        Text
    End Structure

    Structure CSECT_WLS          ' 9/NR:6?  SectionWorklaw Serviceability Analysis
        Dim m_ID As Integer         '        Identification
        Dim m_N As Integer          '        Normal force 0/00
        Dim m_NTYP As Integer       '        Type of law
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CSECT_WLU          ' 9/NR:7?  SectionWorklaw Ultimate Analysis
        Dim m_ID As Integer         '        Identification
        Dim m_N As Integer          '        Normal force 0/00
        Dim m_NTYP As Integer       '        Type of law
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CSECT_CW           ' 9/NR:80  Hydrodynamic coefficients (Wind/Wave loading)
        Dim m_ID As Integer         '        Identification 80
        Dim m_IREF As Integer       '        Reference of coefficients
        Dim m_ALF As Integer        '        angle of attack in degrees
        Dim m_CY As Single          '        wind reaction coefficient in y-direction
        Dim m_CZ As Single          '        wind reaction coefficient in z-direction
        Dim m_CT As Single          '        wind reaction coefficient for torsional moment
        Dim m_CHYD As Single        '        hydrodynamic coefficient (Morrison equation)
        Dim m_CLAT As Single        '        lateral wind reaction coefficient
        Dim m_S As Single           '        Strouhal number
        Dim m_AG As Single          '        reserved (must be present to detect old data without chyd)
    End Structure

    Structure CSECT_WPA          ' 9/NR:81  SectionWindParameters for Wind loading
        Dim m_ID As Integer         '        Identification 81
        Dim m_IBA As Integer        '        construction stage number
        Dim m_IBIT As Integer       '        bitpattern of explicit limits
        Dim m_KD As Single          '        relative roughness k/D
        Dim m_ICE As Single         ' [1011] ice cover
        Dim m_TRAF As Single        ' [1011] height of traffic lane
        Dim m_YMIN As Single        ' [1011] wind attack area
        Dim m_YMAX As Single        ' [1011] wind attack area
        Dim m_ZMIN As Single        ' [1011] wind attack area
        Dim m_ZMAX As Single        ' [1011] wind attack area
        Dim m_YREF As Single        ' [1011] wind moment reference
        Dim m_ZREF As Single        ' [1011] wind moment reference
    End Structure

    Structure CSECT_WDE          ' 9/NR:82  SectionWindDerivativa for Wind loading
        Dim m_ID As Integer         '        Identification 82
        Dim m_IREF As Integer       '        Type of derivativa
        Dim m_ALF As Integer        '        angle of attack in degrees (see 009/NR:80)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_DER() As Single '        Derivativa vred,value as splines
    End Structure

    Structure CSECT_USR          ' 9/NR:90  SectionUserValues
        Dim m_ID As Integer         '        Identification = 90
        Dim m_ITP As Integer        '        type of control value set
        Dim m_IVAL As Integer       '        value of control flag
        Dim m_RVAL As Single        '        real value of control flag
        Dim m_RVALD As Single       '        place to save the original value which has been
    End Structure

    Structure CSECT_MAT          ' 9/NR:91  SectionalMaterial list
        Dim m_ID As Integer         '        Identification = 91
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=31)> Dim m_MAT() As Integer '        material numbers
    End Structure

    Structure CSECT_VAD          ' 9/NR:97  SectionVarDefaults
        Dim m_ID As Integer         '        Identification = 97/98
        Dim m_IND1 As Integer       '        Lower Index of variable
        Dim m_IND2 As Integer       '        Upper Index of variable
        Dim m_IDIM As Integer       '        Unit of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() As Integer '        Name of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_RVAL() As Single '        values of the variable NAME(I1:I2)
    End Structure

    Structure CSECT_VAR          ' 9/NR:98  SectionVarValues
        Dim m_ID As Integer         '        Identification = 97/98
        Dim m_IND1 As Integer       '        Lower Index of variable
        Dim m_IND2 As Integer       '        Upper Index of variable
        Dim m_IDIM As Integer       '        Unit of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NAME() As Integer '        Name of variable
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1020)> Dim m_RVAL() As Single '        values of the variable NAME(I1:I2)
    End Structure

    Structure CSECT_REF          ' 9/NR:99  SectionReference
        Dim m_ID As Integer         '        Identification 099
        Dim m_IM As Integer         '        Type of reference structure definition (see AQUA.ERR)
        Dim m_IRTS As Integer       '        Subtype of reference definition for the points:
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=200)> Dim m_REF() As Integer '        Identifier of references (0 = not defined)
    End Structure

    Structure CSECT_SPT          ' 9/NR:100  SectionStressPoint
        Dim m_ID As Integer         '        Identification 100/101
        Dim m_MNO As Integer        '        Material number
        Dim m_IDP As Integer        '        Number*256 + Bitpattern
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_RT As Single          ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
        Dim m_WTY As Single         ' [1018] Resistance Torsion
        Dim m_WVYY As Single        ' [1017] Resistance y-shear
        Dim m_WVZY As Single        ' [1017] Resistance z-shear
        Dim m_WT2Y As Single        ' [1018] Resistance 2nd Torsion
        Dim m_WTZ As Single         ' [1018] Resistance Torsion
        Dim m_WVYZ As Single        ' [1017] Resistance y-shear
        Dim m_WVZZ As Single        ' [1017] Resistance z-shear
        Dim m_WT2Z As Single        ' [1018] Resistance 2nd Torsion
        Dim m_W0 As Single          ' [1012] unit warping
        Dim m_EPSR As Single        '        non effective strain ratio (0 < epsr <= 1)
        Dim m_EXP As Single         '        exposition class
        Dim m_FIX As Single         ' [1011] location of fix point
        Dim m_SIGD As Single        ' [1092] max. dynamic allowed stress range sig-d(-1)
        Dim m_TAUD As Single        ' [1092] max dynamic allowed stress range tau-d(-1)
        Dim m_LITD As Integer       '        literal for notch type
        Dim m_SIGY As Single        ' [1092] stress perpendicular
        Dim m_AREF As Single        ' [1012] weight (effective area) FE-integration points
        Dim m_TEMP As Single        ' [1215] Temperature
        Dim m_TEMP1 As Single       ' [1215] maximum temperature in history (for damage)
    End Structure

    Structure CSECT_PPT          ' 9/NR:101  SectionPolygonPoint
        Dim m_ID As Integer         '        Identification 100/101
        Dim m_MNO As Integer        '        Material number
        Dim m_IDP As Integer        '        Number*256 + Bitpattern
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_RT As Single          ' [1011] Radius of arc   (:101) ; effect. thickness (:100)
        Dim m_WTY As Single         ' [1018] Resistance Torsion
        Dim m_WVYY As Single        ' [1017] Resistance y-shear
        Dim m_WVZY As Single        ' [1017] Resistance z-shear
        Dim m_WT2Y As Single        ' [1018] Resistance 2nd Torsion
        Dim m_WTZ As Single         ' [1018] Resistance Torsion
        Dim m_WVYZ As Single        ' [1017] Resistance y-shear
        Dim m_WVZZ As Single        ' [1017] Resistance z-shear
        Dim m_WT2Z As Single        ' [1018] Resistance 2nd Torsion
        Dim m_W0 As Single          ' [1012] unit warping
        Dim m_EPSR As Single        '        non effective strain ratio (0 < epsr <= 1)
        Dim m_EXP As Single         '        exposition class
        Dim m_FIX As Single         ' [1011] location of fix point
        Dim m_SIGD As Single        ' [1092] max. dynamic allowed stress range sig-d(-1)
        Dim m_TAUD As Single        ' [1092] max dynamic allowed stress range tau-d(-1)
        Dim m_LITD As Integer       '        literal for notch type
        Dim m_SIGY As Single        ' [1092] stress perpendicular
        Dim m_AREF As Single        ' [1012] weight (effective area) FE-integration points
        Dim m_TEMP As Single        ' [1215] Temperature
        Dim m_TEMP1 As Single       ' [1215] maximum temperature in history (for damage)
    End Structure

    Structure CSECT_CIR          ' 9/NR:102  SectionCircle
        Dim m_ID As Integer         '        Identification 102
        Dim m_MNO As Integer        '        Material number
        Dim m_ITP As Integer        '        interior construction
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate center
        Dim m_Z As Single           ' [1011] z-ordinate center
        Dim m_R As Single           ' [1011] Radius
        Dim m_RI As Single          ' [1011] Radius hole
        Dim m_UC As Single          ' [1011] air contact length
    End Structure

    Structure CSECT_PAN          ' 9/NR:103  SectionPanel
        Dim m_ID As Integer         '        Identification 103/104
        Dim m_MNO As Integer        '        Material number
        Dim m_IDP As Integer        '        Bit-pattern
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_T As Single           ' [1010] thickness
        Dim m_WA As Single          ' [1012] unit warping start
        Dim m_WE As Single          ' [1012] unit warping end
        Dim m_WT As Single          ' [1018] maximum shear from MT
        Dim m_WVY As Single         ' [1017] maximum shear from Vy
        Dim m_WVZ As Single         ' [1017] maximum shear from Vz
        Dim m_WT2 As Single         ' [1018] maximum shear from MT2
        Dim m_XVY As Single         '        relative Ordinate WVy
        Dim m_XVZ As Single         '        relative Ordinate WVz
        Dim m_XMT2 As Single        '        relative Ordinate Wt2
        Dim m_WTBR As Single        '        Bredt torsional shear
        Dim m_FIXA As Single        ' [1011] location of fix point
        Dim m_FIXB As Single        ' [1011] location of fix point
        Dim m_TEFF As Single        ' [1010] effective thickness
        Dim m_AST As Single         ' [1011] Distance of stiffeners along beam axis
        Dim m_ETA As Single         '        Reduction factor for local buckling
    End Structure

    Structure CSECT_WEL          ' 9/NR:104  SectionWeld
        Dim m_ID As Integer         '        Identification 103/104
        Dim m_MNO As Integer        '        Material number
        Dim m_IDP As Integer        '        Bit-pattern
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_T As Single           ' [1010] thickness
        Dim m_WA As Single          ' [1012] unit warping start
        Dim m_WE As Single          ' [1012] unit warping end
        Dim m_WT As Single          ' [1018] maximum shear from MT
        Dim m_WVY As Single         ' [1017] maximum shear from Vy
        Dim m_WVZ As Single         ' [1017] maximum shear from Vz
        Dim m_WT2 As Single         ' [1018] maximum shear from MT2
        Dim m_XVY As Single         '        relative Ordinate WVy
        Dim m_XVZ As Single         '        relative Ordinate WVz
        Dim m_XMT2 As Single        '        relative Ordinate Wt2
        Dim m_WTBR As Single        '        Bredt torsional shear
        Dim m_FIXA As Single        ' [1011] location of fix point
        Dim m_FIXB As Single        ' [1011] location of fix point
        Dim m_TEFF As Single        ' [1010] effective thickness
        Dim m_AST As Single         ' [1011] Distance of stiffeners along beam axis
        Dim m_ETA As Single         '        Reduction factor for local buckling
    End Structure

    Structure CSECT_PER          ' 9/NR:110  SectionPeriphery
        Dim m_ID As Integer         '        Identification 110
        Dim m_MNO As Integer        '        Material number
        Dim m_MN2 As Integer        '        2nd material number
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate
        Dim m_ZA As Single          ' [1011] z-ordinate
        Dim m_YE As Single          ' [1011] y-ordinate
        Dim m_ZE As Single          ' [1011] z-ordinate
        Dim m_AIR As Single         '        air contact ratio
    End Structure

    Structure CSECT_FEM          ' 9/NR:112  SectionTopology
        Dim m_ID As Integer         '        Identification 111
        Dim m_MNO As Integer        '        Material number
        Dim m_NREL As Integer       '        internal element number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer '        internal element nodes
    End Structure

    Structure CSECT_NER          ' 9/NR:190  SectionNonEffectiveRectangle
        Dim m_ID As Integer         '        Identification 190
        Dim m_MNO As Integer        '        Material number
        Dim m_IDP As Integer        '        Noneffective for (same bits as :101)
        Dim m_TNR As Integer        '        Designation
        Dim m_YMIN As Single        ' [1011] y-ordinate
        Dim m_ZMIN As Single        ' [1011] z-ordinate
        Dim m_YMAX As Single        ' [1011] y-ordinate
        Dim m_ZMAX As Single        ' [1011] z-ordinate
        Dim m_T As Single           ' [1011] thickness
        Dim m_SMIN As Single        ' [1092] stress at point (ymin,zmin)
        Dim m_SMAX As Single        ' [1092] stress at point (ymax,zmax)
    End Structure

    Structure CSECT_NEP          ' 9/NR:191  Partial non effective polygons
        Dim m_ID As Integer         '        Identification 191
        Dim m_MNO As Integer        '        Materialnumber
        Dim m_IDP As Integer        '        Noneffective for (see :190)
        Dim m_TNR As Integer        '        Ident from 190 / Cut identifier for :312 elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1022)> Dim m_YZ() As Single ' [1011] yz(2,*) = vertices (old format is blocked with 7 points
    End Structure

    Structure CSECT_PRF          ' 9/NR:200  SectionPointReinforcement
        Dim m_ID As Integer         '        Identification 200
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_SIG As Single         ' [1092] prestress
        Dim m_TEMP As Single        ' [1215] Temperature
        Dim m_AS As Single          ' [1020] Reinforcement area
        Dim m_ASMA As Single        ' [1020] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1012] Reference area
        Dim m_A As Single           ' [1011] distance of bars
    End Structure

    Structure CSECT_LRF          ' 9/NR:201  SectionLineReinforcement
        Dim m_ID As Integer         '        Identification 201/211/221 or 321
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_R As Single           ' [1011] Radius
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_LRP          ' 9/NR:211  SectionLineReinforcement in Points
        Dim m_ID As Integer         '        Identification 201/211/221 or 321
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_R As Single           ' [1011] Radius
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_LSL          ' 9/NR:221  SectionShearLink
        Dim m_ID As Integer         '        Identification 201/211/221 or 321
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_R As Single           ' [1011] Radius
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_CRF          ' 9/NR:202  SectionCircularReinforcement
        Dim m_ID As Integer         '        Identification 202/212/222
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate center
        Dim m_Z As Single           ' [1011] z-ordinate center
        Dim m_R As Single           ' [1011] Radius
        Dim m_I_4 As Single
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_CRP          ' 9/NR:212  SectionCircularReinforcement in Points
        Dim m_ID As Integer         '        Identification 202/212/222
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate center
        Dim m_Z As Single           ' [1011] z-ordinate center
        Dim m_R As Single           ' [1011] Radius
        Dim m_I_4 As Single
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_CSL          ' 9/NR:222  SectionHelicalShearLink
        Dim m_ID As Integer         '        Identification 202/212/222
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate center
        Dim m_Z As Single           ' [1011] z-ordinate center
        Dim m_R As Single           ' [1011] Radius
        Dim m_I_4 As Single
        Dim m_AS As Single          ' [1029] Reinforc. area
        Dim m_ASMA As Single        ' [1029] max Reinforcement area
        Dim m_RNG As Single         '        Layer number
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Diameter
        Dim m_AREF As Single        ' [1019] Reference area = width of element
        Dim m_A As Single           ' [1011] distance of bars
        Dim m_PHIA As Single        ' [   5] start angle for generated points
        Dim m_PHIE As Single        ' [   5] end   angle for generated points
    End Structure

    Structure CSECT_URF          ' 9/NR:210  SectionPeriphericReinforcement
        Dim m_ID As Integer         '        Identification 210/220
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_COVER As Single       ' [1024] static cover
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXP() As Integer '        Exposition class
        Dim m_WC As Single          '        weight for centering reinforcement
        Dim m_AS As Single          ' [1021] Reinforc. area/length
        Dim m_ASMA As Single        ' [1021] max Reinforcement area
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Bar Diameter
        Dim m_AREF As Single        ' [1019] Reference area for crack width
        Dim m_A As Single           ' [1011] distance of bars
    End Structure

    Structure CSECT_USL          ' 9/NR:220  SectionPeriphericShearLink
        Dim m_ID As Integer         '        Identification 210/220
        Dim m_MNO As Integer        '        Material number
        Dim m_IR As Integer         '        Layer number
        Dim m_TNR As Integer        '        Designation
        Dim m_COVER As Single       ' [1024] static cover
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXP() As Integer '        Exposition class
        Dim m_WC As Single          '        weight for centering reinforcement
        Dim m_AS As Single          ' [1021] Reinforc. area/length
        Dim m_ASMA As Single        ' [1021] max Reinforcement area
        Dim m_FT As Single          '        torsional effect
        Dim m_D As Single           ' [1023] Bar Diameter
        Dim m_AREF As Single        ' [1019] Reference area for crack width
        Dim m_A As Single           ' [1011] distance of bars
    End Structure

    Structure CSECT_CPT          ' 9/NR:300  SectionCutStressPoint
        Dim m_ID As Integer         '        Identification 300
        Dim m_MNO As Integer        '        Material of Reinforc. + 1000*Materialnumber
        Dim m_BIT As Integer        '        Cut-Index*128 + Bitpattern
        Dim m_TNR As Integer        '        Designation
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_B0 As Single          ' [1011] width of cut
        Dim m_WTM As Single         ' [1018] Resistance Torsion
        Dim m_WTR As Single         ' [1018] Resistance max Torsion
        Dim m_WVY As Single         ' [1017] Resistance y-shear
        Dim m_WVZ As Single         ' [1017] Resistance z-shear
        Dim m_FRS As Single         '        Factor for total reinf
        Dim m_W0 As Single          ' [1012] unit warping
        Dim m_SIGY As Single        ' [1092] stress perpendicular
        Dim m_BB As Single          ' [1011] total width of cut
        Dim m_VYFK As Single        '        part of total y-shear
        Dim m_VZFK As Single        '        part of total z-shear
        Dim m_BQFK As Single        '        partial width factor
    End Structure

    Structure CSECT_CUT          ' 9/NR:301  SectionCut
        Dim m_ID As Integer         '        Identification 301
        Dim m_MNO As Integer        '        Material of Reinforc. + 1000*Materialnumber
        Dim m_IDP As Integer        '        Bitpattern
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_B0 As Single          ' [1011] effective width
        Dim m_N As Single           ' [1111] Normal force perpend.
        Dim m_M As Single           ' [1114] bending moment perpend
        Dim m_WTM As Single         ' [1018] Resistance Torsion mid
        Dim m_WTD As Single         ' [1018] add tors.resist.edge
        Dim m_VYFK As Single        '        part of total y-shear
        Dim m_VZFK As Single        '        part of total z-shear
        Dim m_BV As Single          ' [1011] total width
        Dim m_PHIB As Single        ' [   5] inclination stirups
        Dim m_IRB As Single         '        number of shearlayer
        Dim m_TY As Single          ' [  17] unit shear Sy/Iz
        Dim m_TZ As Single          ' [  17] unit shear Sz/Iy
        Dim m_BRED As Single        ' [1011] reduction for ducts
        Dim m_ASBM As Single        '        Minimum shear reinf.
        Dim m_BETC As Single        '        friction coefficient
        Dim m_MUE As Single         '        friction in joint
        Dim m_ACT As Single         ' [1012] Area of cut off
        Dim m_KSL As Single         '        parameters for plate
        Dim m_SXE As Single         ' [1011] crack spacing for AASTHO
        Dim m_COTT As Single        '        explicit selected inclination for truss model
    End Structure

    Structure CSECT_HYD          ' 9/NR:900  SectionalHydraulics total section
        Dim m_ID As Integer         '        Identification = 900/903
        Dim m_I_1 As Integer
        Dim m_I_2 As Integer
        Dim m_A As Single           ' [1012] Area
        Dim m_UT As Single          ' [1011] total periphery
        Dim m_UP As Single          ' [1011] total wet periphery
        Dim m_R As Single           ' [1011] hydraulic radius
        Dim m_ZET1 As Single        '        loss factor 1
        Dim m_ZET2 As Single        '        loss factor 2
        Dim m_SLK As Single         '        total leakage
        Dim m_YS As Single          ' [1011] y-Ordinate Center
        Dim m_ZS As Single          ' [1011] y-Ordinate Center
    End Structure

    Structure CSECT_HYP          ' 9/NR:903  SectionalHydraulics partial section
        Dim m_ID As Integer         '        Identification = 900/903
        Dim m_I_1 As Integer
        Dim m_I_2 As Integer
        Dim m_A As Single           ' [1012] Area
        Dim m_UT As Single          ' [1011] total periphery
        Dim m_UP As Single          ' [1011] total wet periphery
        Dim m_R As Single           ' [1011] hydraulic radius
        Dim m_ZET1 As Single        '        loss factor 1
        Dim m_ZET2 As Single        '        loss factor 2
        Dim m_SLK As Single         '        total leakage
        Dim m_YS As Single          ' [1011] y-Ordinate Center
        Dim m_ZS As Single          ' [1011] y-Ordinate Center
    End Structure

    Structure CSECT_HYA          ' 9/NR:904  SectionalHydraulicsAddval
        Dim m_ID As Integer         '        identifier 904
        Dim m_I_2 As Integer
        Dim m_TYPE As Integer       '        type of section
        Dim m_NW As Single          '        Nominal width
        Dim m_YMIN As Single        ' [1011] Minimum Ordinate of section
        Dim m_YMAX As Single        ' [1011] Maximum Ordinate of section
        Dim m_ZMIN As Single        ' [1011] Minimum Ordinate of section
        Dim m_ZMAX As Single        ' [1011] Maximum Ordinate of section
        Dim m_KS As Single          ' [  16] absolute roughness
        Dim m_S As Single           '        storage coefficient
        Dim m_I_8 As Single         '        reserved
        Dim m_I_9 As Single         '        reserved
        Dim m_I_10 As Single        '        reserved
        Dim m_HP As Single          ' [1010] lift of pump
        Dim m_LMIN As Single        '        minimum power
        Dim m_LMAX As Single        '        maximum power
        Dim m_QMAX As Single        '        maximum delivery
    End Structure

    Structure CSECT_HYS          ' 9/NR:910  SectionalHydraulicsPolygon
        Dim m_ID As Integer         '        Identification 910
        Dim m_MAT As Integer        '        identifier 0 (material number)
        Dim m_NR As Integer         '        number of side
        Dim m_TNR As Integer        '        Designation
        Dim m_YA As Single          ' [1011] y-ordinate start
        Dim m_ZA As Single          ' [1011] z-ordinate start
        Dim m_YE As Single          ' [1011] y-ordinate end
        Dim m_ZE As Single          ' [1011] z-ordinate end
        Dim m_KS As Single          ' [  16] absolute roughness
        Dim m_SLK As Single         '        leakage
    End Structure

    Structure CSYST              ' 10/00  SystemInfo
        Dim m_IPROB As Integer      '        Type of System
        Dim m_IACHS As Integer      '        Orientation of gravity
        Dim m_NKNOT As Integer      '        Number of nodes
        Dim m_MKNOT As Integer      '        Highest node number
        Dim m_IGDIV As Integer      '        Group divisor
        Dim m_IGRES As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() As Single ' [1001] bounding box
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TG() As Single '        global CDB-System transformation matrix
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_TXT() As Integer '        Name of projekt, 127 chars
    End Structure

    Structure CSYST_DES          ' 10/1:0  SystemDesignCode
        Dim m_ID As Integer         '        identifier = 0
        Dim m_IDC As Integer        '        Design code enumeration
        Dim m_COUNTRY As Integer    '        Country code for variants
        Dim m_CODE As Integer       '        main number or ident of code
        Dim m_YEAR As Integer       '        Year of publication
        Dim m_CLASS As Integer      '        enum of a classification (see master.ini)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_TXT() As Integer '        specific Text of Design code (16 characters)
        Dim m_WIND As Integer       '        enum of a wind classification (see master.ini)
        Dim m_SNOW As Integer       '        enum of a snow-classification (see master.ini)
        Dim m_SEIS As Integer       '        enum of a seismic-classification (see master.ini)
        Dim m_DUMMY As Integer      '        reserved classification values
        Dim m_ALTITUDE As Single    ' [1006] altitude above sea level
        Dim m_VERS As Single        '        Version number of INI-File (21.0)
    End Structure

    Structure CSYST_ACT          ' 10/1:1  Predefined Actions from INI-file
        Dim m_ID As Integer         '        identifier = 1
        Dim m_ACTION As Integer     '        ID of the real action = type of action
        Dim m_TYPE As Integer       '        16*Part of action + superposition
        Dim m_GAMU As Single        '        safety factor unfavourable
        Dim m_GAMF As Single        '        safety factor favourable
        Dim m_PSI0 As Single        '        combination value
        Dim m_PSI1 As Single        '        frequent combination value
        Dim m_PSI2 As Single        '        quasi permanent combination value
        Dim m_PS1S As Single        '        non frequent combination value psi1'
        Dim m_GAMA As Single        '        safety factor accidential
        Dim m_CAT As Integer        '        sub category of action
        Dim m_TXTREF As Integer     '        designation_enum in SOFISTIK.ERR
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        explicit designation (in native language)
    End Structure

    Structure CSYST_COM_ACT      '        Identifier of action
        Dim m_ID As Integer
        Dim m_FAKU As Single
        Dim m_FAKF As Single
    End Structure

    Structure CSYST_COM          ' 10/1:2  Possible Combination of actions
        Dim m_ID As Integer         '        identifier = 2
        Dim m_LFB As Integer        '        loadcase number offset
        Dim m_EXTR As Integer       '        Combination rule equation to be used
        Dim m_TYPE As Integer       '        type or action of resulting load case
        Dim m_APPLY As Integer      '        Is generally used for:
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_TXT() As Integer '        Name of combination
        Dim m_DUMMY As Single       '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=31)> Dim m_ACT() As CSYST_COM_ACT '        Identifier of action
    End Structure

    Structure CGRP               ' 11/00  Groups
        Dim m_NG As Integer         '        group-number
        Dim m_TYP As Integer        '        element code
        Dim m_NUM As Integer        '        number of elements of this type
        Dim m_MIN As Integer        '        minimum element-number of group
        Dim m_MAX As Integer        '        maximum element-number of group
        Dim m_MNR As Integer        '        material-number of group
        Dim m_MBW As Integer        '        reinforcement material-number of group
        Dim m_INF As Integer        '        Bit-code of group
        Dim m_FAKS As Single        '        stiffness factor of group (ASE/TALPA)
        Dim m_FAKA As Single        '        reducing factor of axial bedding for piles
        Dim m_FAKT As Single        '        reducing factor of transverse bedding
        Dim m_VTOT As Single        ' [1093] total volume
        Dim m_MTOT As Single        ' [1093] total mass
        Dim m_RTOT As Single        ' [1030] total reinforcement
        Dim m_ETOT As Single        ' [1093] total energy
        Dim m_ECOM As Single        ' [1093] compression energy
        Dim m_EDEV As Single        ' [1093] shear energy
        Dim m_EKIN As Single        ' [1093] kinetic energy
        Dim m_EPOT As Single        ' [1093] potential energy
        Dim m_EDAM As Single        ' [1093] damping energy
        Dim m_H_GW As Single        ' [1001] Level of Groundwater
        Dim m_DUMMY As Single       '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Group
    End Structure

    Structure CGRP_LC            ' 11/LC  Groups of Loadcase
        Dim m_NG As Integer         '        group-number
        Dim m_TYP As Integer        '        element code
        Dim m_NUM As Integer        '        number of elements of this type
        Dim m_MIN As Integer        '        minimum element-number of group
        Dim m_MAX As Integer        '        maximum element-number of group
        Dim m_MNR As Integer        '        material-number of group
        Dim m_MBW As Integer        '        reinforcement material-number of group
        Dim m_INF As Integer        '        Bit-code of group
        Dim m_FAKS As Single        '        stiffness factor of group (ASE/TALPA)
        Dim m_FAKA As Single        '        reducing factor of axial bedding for piles
        Dim m_FAKT As Single        '        reducing factor of transverse bedding
        Dim m_VTOT As Single        ' [1093] total volume
        Dim m_MTOT As Single        ' [1093] total mass
        Dim m_RTOT As Single        ' [1030] total reinforcement
        Dim m_ETOT As Single        ' [1093] total energy
        Dim m_ECOM As Single        ' [1093] compression energy
        Dim m_EDEV As Single        ' [1093] shear energy
        Dim m_EKIN As Single        ' [1093] kinetic energy
        Dim m_EPOT As Single        ' [1093] potential energy
        Dim m_EDAM As Single        ' [1093] damping energy
        Dim m_H_GW As Single        ' [1001] Level of Groundwater
        Dim m_DUMMY As Single       '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Group
    End Structure

    Const LTYP_IMP = 70
    Structure CLC_CTRL           ' 12/LC:?  Informations on loadcase LC
        Dim m_KIND As Integer       '        type of loadcase
        Dim m_ITYP As Integer       '        action type (14/ID)
        Dim m_THEO As Integer       '        first order theory
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBA() As Integer '        construction stage number of birth & death
        Dim m_PLC As Integer        '        Primary load case for 2nd order analysis
        Dim m_RPAR As Single        '        Timevalue of Load [sec]
        Dim m_PSI0 As Single        '        combin. factor psi0
        Dim m_PSI1 As Single        '        combin. factor psi1
        Dim m_PSI2 As Single        '        combin. factor psi2
        Dim m_FACT As Single        '        loadcase factor
        Dim m_FACX As Single        '        dead load factor X
        Dim m_FACY As Single        '        dead load factor Y
        Dim m_FACZ As Single        '        dead load factor Z
        Dim m_RX As Single          ' [1151] sum of support PX
        Dim m_RY As Single          ' [1151] sum of support PY
        Dim m_RZ As Single          ' [1151] sum of support PZ
        Dim m_CRI1 As Single        '        1st eval. criteria
        Dim m_CRI2 As Single        '        2nd eval. criteria
        Dim m_CRI3 As Single        '        3rd eval. criteria
        Dim m_GAM1 As Single        '        unfavourable factor
        Dim m_GAM2 As Single        '        favourable factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NAME() As Integer '        Generating source
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_RTEX() As Integer '        Designation of loadcase
    End Structure

    Structure CLC_EVAL           ' 12/LC:011  Evaluation request
        Dim m_ID As Integer         '        identifier 11
        Dim m_LREF As Integer       '        Referenced load case
        Dim m_LTYP As Integer       '        type of evaluation request
        Dim m_VAL As Single         '        Result of evaluation
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NAME() As Integer '        Literal of variable name
    End Structure

    Structure CLC_COPY           ' 12/LC:012  Loads from other loadcases
        Dim m_ID As Integer         '        identifier 12 / 13
        Dim m_LREF As Integer       '        Referenced load case or action ID [chr]
        Dim m_LSEL As Integer       '        selection bits for elements
        Dim m_LITF As Integer       '        enum of applied generic factors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ISEL() As Integer '        optional filter for element numbers
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NREF() As Integer '        Load train application control (see cdblfta.for)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SREF() As Single '        Factors and coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_SUM() As Single '        Sum of forces (psup,lsup)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_CLIT() As Integer '        Literal of an external database as source
    End Structure

    Structure CLC_COPI           ' 12/LC:013  Loads from other loadcases
        Dim m_ID As Integer         '        identifier 12 / 13
        Dim m_LREF As Integer       '        Referenced load case or action ID [chr]
        Dim m_LSEL As Integer       '        selection bits for elements
        Dim m_LITF As Integer       '        enum of applied generic factors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_ISEL() As Integer '        optional filter for element numbers
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NREF() As Integer '        Load train application control (see cdblfta.for)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SREF() As Single '        Factors and coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_SUM() As Single '        Sum of forces (psup,lsup)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_CLIT() As Integer '        Literal of an external database as source
    End Structure

    Structure CLC_MBODY          ' 12/LC:2?  Rotation of Body
        Dim m_ID As Integer         '        identifier 20/21
        Dim m_NR As Integer         '        primary or secondary group number of moving elements
        Dim m_NREF As Integer       '        Reference beam number
        Dim m_AX As Single          ' [1003] acceleration local X
        Dim m_AY As Single          ' [1003] acceleration local Y
        Dim m_AZ As Single          ' [1003] acceleration local Z
        Dim m_AXX As Single         ' [1207] rotational acceleration local X-X
        Dim m_AYY As Single         ' [1207] rotational acceleration local Y-Y
        Dim m_AZZ As Single         ' [1207] rotational acceleration local Z-Z
        Dim m_ARX As Single         ' [1207] rotational acceleration local X-X  (= vxx**2)
        Dim m_ARY As Single         ' [1207] rotational acceleration local Y-Y  (= vyy**2)
        Dim m_ARZ As Single         ' [1207] rotational acceleration local Z-Z  (= vzz**2)
        Dim m_EX As Single          ' [1001] global reference point for rotational acceleration
        Dim m_EY As Single          ' [1001] global reference point for rotational acceleration
        Dim m_EZ As Single          ' [1001] global reference point for rotational acceleration
    End Structure

    Structure CLC_LPOS           ' 12/LC:90  Position of Load trains
        Dim m_ID As Integer         '        identifier 90
        Dim m_CASE As Integer       '        number of the case
        Dim m_REF As Integer        '        name of the reference lane
        Dim m_SUB As Integer        '        subnumber of lane
        Dim m_KW As Integer         '        KW where result has been stored
        Dim m_IPOS As Integer       '        Position of Result within record
        Dim m_NREL As Integer       '        Elementnumber
        Dim m_LFTG As Integer       '        LFT*1000+500*ISCONVOY+LFG
        Dim m_XABS As Single        ' [1011] Section location for beams
        Dim m_YEX As Single         ' [1001] Eccentricity of load train
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_PSC() As Single '        Maximum load values in load train (PL/BL)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_XPOS() As Single '        Position and distance values
    End Structure

    Structure CLC_LPO1           ' 12/LC:91  Individual position of Point load
        Dim m_ID As Integer         '        identifier 91
        Dim m_X As Single           ' [1001] Position of individual load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PVAL() As Single '        Load values in PV,PVM,PX,PY
    End Structure

    Structure CLC_LPO2           ' 12/LC:92  Individual position of Block load
        Dim m_ID As Integer         '        identifier 92
        Dim m_XA As Single          ' [1001] Position of individual load start
        Dim m_XE As Single          ' [1001] Position of individual load end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PVAL() As Single '        Load values in PV,PVM,PX,PY
    End Structure

    Structure CLC_LPO3           ' 12/LC:93  Individual residual loadings
        Dim m_ID As Integer         '        identifier 93
        Dim m_XA As Single          ' [1001] Position of individual load start
        Dim m_XE As Single          ' [1001] Position of individual load end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_PVAL() As Single '        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
    End Structure

    Structure CLC_LPOX           ' 12/LC:99  Spandefinitions from ELLA
        Dim m_ID As Integer         '        identifier 99
        Dim m_XA As Single          ' [1001] Limits of an active area start
        Dim m_XE As Single          ' [1001] Limits of an active area end
        Dim m_YL As Single          ' [1001] Limits of an active area left
        Dim m_YR As Single          ' [1001] Limits of an active area right
        Dim m_PHI As Single         '        impact factor
        Dim m_V As Single           ' [1203] velocity of load train
    End Structure

    Structure CLC_POIN_LPT       '        loadpt
        Dim m_P As Single
        Dim m_X As Single           ' [1001] 
        Dim m_Y As Single           ' [1001] 
        Dim m_Z As Single           ' [1001] 
    End Structure

    Structure CLC_POIN           ' 12/LC:10?  Free point loads
        Dim m_KREF As Integer       '        Reference type
        Dim m_NREF As Integer       '        Reference number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() As Integer '        Identifiying Text (12 characters)
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_WIDT As Single        ' [1001] Tolerance load direction to match elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_LPT() As CLC_POIN_LPT '        loadpt
    End Structure

    Structure CLC_LINE_LPT       '        loadpts
        Dim m_P As Single
        Dim m_X As Single           ' [1001] 
        Dim m_Y As Single           ' [1001] 
        Dim m_Z As Single           ' [1001] 
    End Structure

    Structure CLC_LINE           ' 12/LC:11?  Free line loads
        Dim m_KREF As Integer       '        Reference type
        Dim m_NREF As Integer       '        Reference number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() As Integer '        Identifiying Text (12 characters)
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_WIDT As Single        ' [1001] Tolerance load direction to match elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() As CLC_LINE_LPT '        loadpts
    End Structure

    Structure CLC_CURV_LPT       '        loadpts
        Dim m_P As Single
        Dim m_X As Single           ' [1001] 
        Dim m_Y As Single           ' [1001] 
        Dim m_Z As Single           ' [1001] 
    End Structure

    Structure CLC_CURV           ' 12/LC:14?  Free spline loads
        Dim m_KREF As Integer       '        Reference type
        Dim m_NREF As Integer       '        Reference number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() As Integer '        Identifiying Text (12 characters)
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_WIDT As Single        ' [1001] Tolerance load direction to match elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() As CLC_CURV_LPT '        loadpts
    End Structure

    Structure CLC_AREA_LPT       '        loadpts
        Dim m_P As Single
        Dim m_X As Single           ' [1001] 
        Dim m_Y As Single           ' [1001] 
        Dim m_Z As Single           ' [1001] 
    End Structure

    Structure CLC_AREA           ' 12/LC:12?  Free area loads
        Dim m_KREF As Integer       '        Reference type
        Dim m_NREF As Integer       '        Reference number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() As Integer '        Identifiying Text (12 characters)
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_WIDTH As Single       ' [1001] Tolerance load direction to match elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() As CLC_AREA_LPT '        loadpts
    End Structure

    Structure CLC_VOLU           ' 12/LC:13?  Free volume loads
        Dim m_KREF As Integer       '        Reference type
        Dim m_NREF As Integer       '        Reference number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TXT() As Integer '        Identifiying Text (12 characters)
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_WIDTH As Single       ' [1001] Factor for silo fillings A/U
        Dim m_P0 As Single          '        load value
        Dim m_X As Single           ' [1001] Reference point for load value P0
        Dim m_Y As Single           ' [1001] 
        Dim m_Z As Single           ' [1001] 
        Dim m_P1 As Single          '        variant load value second reference point
        Dim m_DX1 As Single         ' [1001] Reference point for load value P1
        Dim m_DY1 As Single         ' [1001] 
        Dim m_DZ1 As Single         ' [1001] 
        Dim m_P2 As Single          '        variant load value second reference point
        Dim m_DX2 As Single         ' [1001] Reference point for load value P2
        Dim m_DY2 As Single         ' [1001] 
        Dim m_DZ2 As Single         ' [1001] 
        Dim m_P3 As Single          '        variant load value second reference point
        Dim m_DX3 As Single         ' [1001] Reference point for load value P3
        Dim m_DY3 As Single         ' [1001] 
        Dim m_DZ3 As Single         ' [1001] 
        Dim m_P4 As Single          '        variant load value second reference point
        Dim m_DX4 As Single         ' [1001] Reference point for load value P2
        Dim m_DY4 As Single         ' [1001] 
        Dim m_DZ4 As Single         ' [1001] 
        Dim m_P5 As Single          '        variant load value second reference point
        Dim m_DX5 As Single         ' [1001] Reference point for load value P3
        Dim m_DY5 As Single         ' [1001] 
        Dim m_DZ5 As Single         ' [1001] 
    End Structure

    Structure CLC_TRAI           ' 12/LC:300  Train loading
        Dim m_ID As Integer         '        identifier 300
        Dim m_IDEN As Integer       '        Type of load train
        Dim m_BPAT As Integer       '        Preselected Bitpattern of special options
        Dim m_P1 As Single          '        Char Designation or Class of loading
        Dim m_P2 As Single          '        second entry for load magnitude
        Dim m_P3 As Single          '        third entry for load magnitude
        Dim m_P4 As Single          '        fourth entry for load magnitude
        Dim m_P5 As Single          '        Basic area loading
        Dim m_P6 As Single          '        Wind loading
        Dim m_P7 As Single          '        Height subjected to wind load
        Dim m_P8 As Single          '        Entry for brake loading
        Dim m_P9 As Single          '        Height of the gravity centreline
        Dim m_TOTFAC As Single      '        Factor for the vertical loads of the
        Dim m_PHIB As Single        '        explicit impact factor for bending
        Dim m_PHIBF As Single       '        explicit impact factor favourable bending
        Dim m_PHIS As Single        '        explicit impact factor for shear
        Dim m_PHISF As Single       '        explicit impact factor favourable shear
        Dim m_WIDTH As Single       ' [1001] Width of moving lane to be spared with P5
        Dim m_YEX As Single         ' [1001] reserved: Eccentricity of loading in lane
        Dim m_XCOL As Single        ' [1001] Minimum distance for multiple instances
        Dim m_V As Single           ' [1203] Speed of train
        Dim m_FACF As Single        '        Factor for the masses of the loading
        Dim m_DUMMY As Single       '        reserved
        Dim m_FRB As Single         '        Frequence of body to bogie spring
        Dim m_DAB As Single         '        Modal damping of body to bogie
        Dim m_PZBO As Single        ' [1001] Fractional load value of bogie (included in PZ)
        Dim m_FRBO As Single        '        Frequence of bogie to wheel spring
        Dim m_DABO As Single        '        Modal damping of bogie to body
        Dim m_PZWH As Single        ' [1001] Fractional load value of wheel (included in PZ)
        Dim m_FRWH As Single        '        Frequence of wheel to surface / bridge deck
        Dim m_DAWH As Single        '        Modal damping of wheel to surface
    End Structure

    Structure CLC_TRAL           ' 12/LC:301  Individual loads of Train loading
        Dim m_ID As Integer         '        identifier 301
        Dim m_TYPE As Integer       '        Type of loading
        Dim m_BPAT As Integer       '        contact node for single loads
        Dim m_PZ As Single          '        Vertical loading
        Dim m_YMIN As Single        ' [1001] min eccentricity in y direction
        Dim m_YMAX As Single        ' [1001] max eccentricity in y direction
        Dim m_PX As Single          '        Load value for braking
        Dim m_PW As Single          '        Explicit force for wind attack
        Dim m_ZW As Single          ' [1001] Height for wind force resultant
        Dim m_PV As Single          '        Massvalue for zentrifugal force
        Dim m_ZPV As Single         ' [1001] Height for zentrifugal force resultant
        Dim m_FACFAV As Single      '        Factor for favourable effects
        Dim m_A As Single           ' [1001] Distance to last load
        Dim m_L As Single           ' [1001] Length of loading for block loads (0 = unlimited)
        Dim m_LMAX As Single        ' [1001] Maximum length of block loading if variable
        Dim m_LDEL As Single        ' [1001] Discrete increment of length for block loading
        Dim m_HW As Single          ' [1001] Height of train for wind attack area
        Dim m_WIDTH As Single       ' [1001] Width of train
        Dim m_YEXVAR As Single      '        Variable eccentricity for secondary load trains
        Dim m_WWHEEL As Single      ' [1001] Width of single wheel
        Dim m_LWHEEL As Single      ' [1001] Length of single wheel
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() As Single '        reserved
        Dim m_FRB As Single         '        Frequence of body to bogie spring
        Dim m_DAB As Single         '        Modal damping of body to bogie
        Dim m_PZBO As Single        ' [1001] Fractional load value of bogie (included in PZ)
        Dim m_FRBO As Single        '        Frequence of bogie to wheel spring
        Dim m_DABO As Single        '        Modal damping of bogie to body
        Dim m_PZWH As Single        ' [1001] Fractional load value of wheel (included in PZ)
        Dim m_FRWH As Single        '        Frequence of wheel to surface / bridge deck
        Dim m_DAWH As Single        '        Modal damping of wheel to surface
    End Structure

    Structure CLC_WIND           ' 12/LC:400  wind loading
        Dim m_ID As Integer         '        identifier 400
        Dim m_NORM As Integer       '        wind design code
        Dim m_CLAS As Integer       '        type of zone
        Dim m_VATM As Single        ' [1201] atmospheric wind
        Dim m_VREF As Single        ' [1201] mean reference wind
        Dim m_VBOE As Single        ' [1201] gust reference wind
        Dim m_DX As Single          '        components of wind direction
        Dim m_DY As Single
        Dim m_DZ As Single
        Dim m_XREF As Single        ' [1001] Reference point
        Dim m_YREF As Single        ' [1001] 
        Dim m_ZREF As Single        ' [1001] 
        Dim m_DXRE As Single        '        Reference direction
        Dim m_DYRE As Single
        Dim m_DZRE As Single
        Dim m_GH As Single          ' [1001] coordinate of ground level
        Dim m_HMIN As Single        ' [1001] value for constant wind speed below
        Dim m_RHO As Single         ' [  59] weight of the air / fluid
        Dim m_LAT As Single         ' [   5] lattitude of site
    End Structure

    Structure CLC_WTOP           ' 12/LC:401  Wind environment
        Dim m_ID As Integer         '        identifier 401
        Dim m_TYP As Single         '        type of environment height
        Dim m_I_2 As Single         '        reserved
        Dim m_XM As Single          ' [1001] center of elevation in system coordinates
        Dim m_YM As Single          ' [1001] center of elevation in system coordinates
        Dim m_ZM As Single          ' [1001] center of elevation in system coordinates
        Dim m_DX As Single          '        direction of crest of ridge
        Dim m_DY As Single          '        or local x-coordinate of a summit
        Dim m_DZ As Single
        Dim m_H As Single           ' [1001] height above ground defining the slopes
        Dim m_WLEN As Single        ' [1001] width in negative local y direction
        Dim m_BLEN As Single        ' [1001] width in positive local x direction
    End Structure

    Structure CLC_WROU_R         '        limits given
        Dim m_D As Single           ' [1001] 
        Dim m_R As Single           ' [1001] 
        Dim m_DH As Single          ' [1001] 
        Dim m_HH As Single          ' [1001] 
    End Structure

    Structure CLC_WROU           ' 12/LC:402  Roughness (wind)
        Dim m_ID As Integer         '        identifier 402
        Dim m_I_1 As Single         '        reserved
        Dim m_I_2 As Single         '        reserved
        Dim m_DSEA As Single        ' [1001] Distance to the sea
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_R() As CLC_WROU_R '        limits given
    End Structure

    Structure CLC_WSPE           ' 12/LC:410  wind spectrum
        Dim m_ID As Integer         '        identifier 410
        Dim m_TYP As Integer        '        type of spectra
        Dim m_I_2 As Integer        '        reserved
        Dim m_A1LO As Single        '        1st coefficient longitudinal
        Dim m_A2LO As Single        '        2nd coefficient longitudinal
        Dim m_A3LO As Single        '        3rd coefficient longitudinal
        Dim m_B_LO As Single        '        4th coefficient longitudinal
        Dim m_C_LO As Single        '        5th coefficient longitudinal
        Dim m_D_LO As Single        '        6th coefficient longitudinal
        Dim m_A1LA As Single        '        1st coefficient lateral
        Dim m_A2LA As Single        '        2nd coefficient lateral
        Dim m_A3LA As Single        '        3rd coefficient lateral
        Dim m_B_LA As Single        '        4th coefficient lateral
        Dim m_C_LA As Single        '        5th coefficient lateral
        Dim m_D_LA As Single        '        6th coefficient lateral
        Dim m_A1VE As Single        '        1st coefficient vertical
        Dim m_A2VE As Single        '        2nd coefficient vertical
        Dim m_A3VE As Single        '        3rd coefficient vertical
        Dim m_B_VE As Single        '        4th coefficient vertical
        Dim m_C_VE As Single        '        5th coefficient vertical
        Dim m_D_VE As Single        '        6th coefficient vertical
        Dim m_C3D As Single         '        Longitudinal coefficient
        Dim m_KUU As Single         '        halfvalue distance coefficient
        Dim m_KUV As Single         '        halfvalue distance coefficient
        Dim m_KUW As Single         '        halfvalue distance coefficient
        Dim m_KVU As Single         '        halfvalue distance coefficient
        Dim m_KVV As Single         '        halfvalue distance coefficient
        Dim m_KVW As Single         '        halfvalue distance coefficient
        Dim m_KWU As Single         '        halfvalue distance coefficient
        Dim m_KWV As Single         '        halfvalue distance coefficient
        Dim m_KWW As Single         '        halfvalue distance coefficient
    End Structure

    Structure CLC_WTST           ' 12/LC:411  wind coherence test requests
        Dim m_ID As Integer         '        identifier 411
        Dim m_TYP As Integer        '        type of coherence component (1:9)
        Dim m_LC As Integer         '        load case of an eigenvalue
        Dim m_XREF As Single        ' [1001] Reference point
        Dim m_YREF As Single        ' [1001] 
        Dim m_ZREF As Single        ' [1001] 
        Dim m_RX As Single          ' [1001] Distance or direction of distance
        Dim m_RY As Single          ' [1001] 
        Dim m_RZ As Single          ' [1001] 
        Dim m_CX As Single          '        Davenport/Krenk reference coefficients
        Dim m_CY As Single
        Dim m_CZ As Single
        Dim m_EIG As Single         '        Eigenfrequency (Hertz) for LC>0
        Dim m_U As Single           ' [  96] mean velocity
        Dim m_HWD As Single         ' [1001] real distance for LC==0
        Dim m_XMAX As Single        '        maximum x-value for data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_DATA() As Single '        calculated sqrt of coherence data ( 2 sets)
    End Structure

    Structure CLC_WPRC           ' 12/LC:420  wind profile control values
        Dim m_ID As Integer         '        identifier 420
        Dim m_ID2 As Integer        '        identifier 0
        Dim m_IPRO As Single        '        number of generated profiles
        Dim m_WXMI As Single        ' [1001] size of structure in wind coordinates
        Dim m_WXMA As Single        ' [1001] 
        Dim m_WYMI As Single        ' [1001] 
        Dim m_WYMA As Single        ' [1001] 
        Dim m_WZMI As Single        ' [1001] 
        Dim m_WZMA As Single        ' [1001] 
        Dim m_ALFA As Single        '        some angle ...
        Dim m_BETA As Single        '        some angle ...
        Dim m_GAMM As Single        '        some angle ...
        Dim m_DELT As Single        '        some angle ...
    End Structure

    Structure CLC_WPRO           ' 12/LC:420  wind profile distinct values
        Dim m_ID As Integer         '        identifier 420
        Dim m_IST As Integer        '        source of data
        Dim m_I_2 As Single         '        index reserved
        Dim m_H As Single           ' [1001] height above ground level
        Dim m_V As Single           ' [1201] mean value of wind velocity
        Dim m_VBOE As Single        ' [1201] peak value of wind velocity
        Dim m_TLON As Single        ' [1201] longitudinal turbulence
        Dim m_TLAT As Single        ' [1201] lateral turbulence
        Dim m_TVER As Single        ' [1201] vertical turbulence
        Dim m_LLON As Single        ' [1001] longitudinal wave length
        Dim m_LLAT As Single        ' [1001] lateral wave length
        Dim m_LVER As Single        ' [1001] vertical wave length
        Dim m_PHAS As Single        '        phase
    End Structure

    Structure CLC_WAVE           ' 12/LC:500  Wave Loading
        Dim m_ID As Integer         '        identifier 500
        Dim m_TYP As Integer        '        wave theory bit pattern
        Dim m_NF As Integer         '        number of frequencies in spectra
        Dim m_H As Single           ' [1001] wave height / significant wave height
        Dim m_T As Single           ' [  90] period of wave / peak period of wave
        Dim m_D As Single           ' [1001] water depth (0 = infinite)
        Dim m_SWL As Single         ' [1001] sea water reference level
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DIR() As Single '        principal direction of travelling
        Dim m_UC As Single          ' [1201] additional constant current
        Dim m_ALF As Single         '        exponent U(z)=UC*(z/d)**alf
        Dim m_RHO As Single         ' [  59] weight of the fluid
        Dim m_L As Single           ' [1001] calculated wave length
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_PAR() As Single '        special parameters for wave spectra
    End Structure

    Structure CLC_HIST           ' 13/LC:0  TimeHistoryTitle
        Dim m_ID As Integer         '        identifier 0
        Dim m_IDT As Integer        '        Unit of time resp x-axis
        Dim m_IDF As Integer        '        Unit of function values
        Dim m_NFUN As Integer       '        number of functions
        Dim m_NVAL As Integer       '        max number of discrete time values
        Dim m_TYPE As Integer       '        general type of curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() As Integer '        Designation
    End Structure

    Structure CLC_DAMP           ' 13/LC:1  Damping values
        Dim m_ID As Integer         '        identifier 1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_D() As Single '        modal damping values
    End Structure

    Structure CLC_FVAL           ' 13/LC:?0  Discrete function values
        Dim m_ID As Integer         '        identifier
        Dim m_TT As Single          '        Time/frequency/modenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_F() As Single '        function values
    End Structure

    Structure CLC_FMODC          ' 13/LC:9?  Explicit modal coordinates
        Dim m_ID As Integer         '        identifier
        Dim m_TT As Single          '        Time/frequency/modenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_F() As Single '        function values
    End Structure

    Structure CLC_FSIN           ' 13/LC:11  Harmonic function additive
        Dim m_ID As Integer         '        identifier
        Dim m_T As Single           ' [  90] Time/frequency
        Dim m_F1 As Single          '        Amplitude value
        Dim m_PHI1 As Single        ' [  90] phase value
        Dim m_TMIN As Single        ' [  90] starttime
        Dim m_TMAX As Single        ' [  90] stoptime if > starttime
        Dim m_S As Single           '        impactfactor
        Dim m_F2 As Single          '        Amplitude value for T/2 (Fourier)
        Dim m_PHI2 As Single        ' [  90] phase value for f2
        Dim m_F3 As Single          '        Amplitude value for T/3 (Fourier)
        Dim m_PHI3 As Single        ' [  90] phase value for f3
        Dim m_F4 As Single          '        Amplitude value for T/4 (Fourier)
        Dim m_PHI4 As Single        ' [  90] phase value for f4
    End Structure

    Structure CLC_FSINM          ' 13/LC:21  Harmonic function multiplier
        Dim m_ID As Integer         '        identifier
        Dim m_T As Single           ' [  90] Time/frequency
        Dim m_F1 As Single          '        Amplitude value
        Dim m_PHI1 As Single        ' [  90] phase value
        Dim m_TMIN As Single        ' [  90] starttime
        Dim m_TMAX As Single        ' [  90] stoptime if > starttime
        Dim m_S As Single           '        impactfactor
        Dim m_F2 As Single          '        Amplitude value for T/2 (Fourier)
        Dim m_PHI2 As Single        ' [  90] phase value for f2
        Dim m_F3 As Single          '        Amplitude value for T/3 (Fourier)
        Dim m_PHI3 As Single        ' [  90] phase value for f3
        Dim m_F4 As Single          '        Amplitude value for T/4 (Fourier)
        Dim m_PHI4 As Single        ' [  90] phase value for f4
    End Structure

    Structure CLC_FSTP           ' 13/LC:12  Periodic stepping function additive
        Dim m_ID As Integer         '        identifier
        Dim m_T As Single           ' [  90] Time/frequency
        Dim m_F As Single           '        Amplitude value
        Dim m_TC As Single          ' [  90] contact time
        Dim m_TMIN As Single        ' [  90] starttime
        Dim m_TMAX As Single        ' [  90] stoptime if > starttime
        Dim m_S As Single           '        impactfactor (Sailer/Hüttner/Bachmann)
    End Structure

    Structure CLC_FSTPM          ' 13/LC:22  Periodic stepping function multiplier
        Dim m_ID As Integer         '        identifier
        Dim m_T As Single           ' [  90] Time/frequency
        Dim m_F As Single           '        Amplitude value
        Dim m_TC As Single          ' [  90] contact time
        Dim m_TMIN As Single        ' [  90] starttime
        Dim m_TMAX As Single        ' [  90] stoptime if > starttime
        Dim m_S As Single           '        impactfactor (Sailer/Hüttner/Bachmann)
    End Structure

    Structure CLC_FINT           ' 13/LC:13  Aperiodic function additive
        Dim m_ID As Integer         '        identifier 13
        Dim m_T As Single           ' [  90] Total Time
        Dim m_F As Single           '        Amplitude value
        Dim m_T1 As Single          ' [  90] Time of constant intensity
        Dim m_TMIN As Single        ' [  90] starttime
        Dim m_TMAX As Single        ' [  90] stoptime = tmin+T
        Dim m_TYP As Integer        '        Type of function
        Dim m_F2 As Single          '        Amplitude factor
        Dim m_T2 As Single          ' [  90] lead in time duration
        Dim m_F3 As Single          '        Amplitude factor
        Dim m_T3 As Single          ' [  90] lead out time duration
    End Structure

    Structure CLC_RESW           ' 13/LC:9??  Response spectra wind
        Dim m_TYP As Integer        '        Type of spectra 900 - 999
        Dim m_SINT As Single        '        Integral of spectra
        Dim m_A1 As Single          '        Spectrum coefficient
        Dim m_A2 As Single          '        Spectrum coefficient
        Dim m_A3 As Single          '        Spectrum coefficient
        Dim m_B As Single           '        Spectrum coefficient
        Dim m_C As Single           '        Spectrum coefficient
        Dim m_D As Single           '        Spectrum coefficient
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_RES() As Single '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() As Integer '        Designation of Spectra
    End Structure

    Structure CLC_RESP           ' 13/LC:???  Response spectra earthquake
        Dim m_TYP As Integer        '        Type of spectra 100 - 999
        Dim m_D As Single           '        Damping value eta or behaviour factor q
        Dim m_SA As Single          '        Rigid acceleration factor (Soil Parameter S)
        Dim m_SB As Single          '        Max acceleration factor
        Dim m_SMIN As Single        '        Min acceleration factor (beta)
        Dim m_TB As Single          ' [  90] Time value
        Dim m_TC As Single          ' [  90] Time value
        Dim m_TD As Single          ' [  90] Time value
        Dim m_TE As Single          ' [  90] Cutt-Off Time
        Dim m_K1 As Single          '        Coefficient k1
        Dim m_K2 As Single          '        Coefficient k2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ZONE() As Integer '        Earthquake zone
        Dim m_AG As Single          ' [1202] Reference base acceleration
        Dim m_AH As Single          '        Horizontal factor (importance etc.)
        Dim m_AV As Single          '        Vertical factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() As Integer '        Designation of Spectra
    End Structure

    Structure CLC_FREF           ' 13/LC:????  Discrete reference function values
        Dim m_ID As Integer         '        line type
        Dim m_TT As Single          '        Time/frequency
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_F() As Single '        function values
    End Structure

    Structure CACT_TASK_SCOM     '        index,factor and name of items
        Dim m_IND As Integer
        Dim m_FAK As Single
        Dim m_BEZ As Integer
    End Structure

    Structure CACT_TASK          ' 14/0  Superposition task commands
        Dim m_IVERS As Integer      '        < 9999 = old data format (ACT_RULE)
        Dim m_NUM As Integer        '        number of superposition command
        Dim m_ACT As Integer        '        number of groups of actions at 14/act
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFM() As Integer '        base of load case numbers
        Dim m_KSAV As Integer       '        0 = do not save, >0 = save factors as combination KSAV
        Dim m_KWERG As Integer      '        Identifier of resultrecord in CDB
        Dim m_FROM As Integer       '        smallest  element number (echo only)
        Dim m_TO As Integer         '        highest   element number (echo only)
        Dim m_INC As Integer        '        increment element number (echo only)
        Dim m_TID As Integer        '        optional identifier
        Dim m_X As Single           ' [1001] X-ordinate for beams
        Dim m_COMB As Integer       '        combination method for items given at SCOM
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_SCOM() As CACT_TASK_SCOM '        index,factor and name of items
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TXT() As Integer '        Name of superposition
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=128)> Dim m_UFORM() As Integer '        User defined target function (index == 0!)
    End Structure

    Structure CACT_RULE_SCOM     '        index,factor and name of items
        Dim m_IND As Integer
        Dim m_FAK As Single
        Dim m_BEZ As Integer
    End Structure

    Structure CACT_RULE          ' 14/0  Superposition commands (old Version)
        Dim m_NUM As Integer        '        number of superposition command
        Dim m_ACT As Integer        '        number of groups of actions at 14/act
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFM() As Integer '        base of load case numbers
        Dim m_KWERG As Integer      '        Identifier of resultrecord in CDB
        Dim m_FROM As Integer       '        smallest  element number (echo only)
        Dim m_TO As Integer         '        highest   element number (echo only)
        Dim m_INC As Integer        '        increment element number (echo only)
        Dim m_TID As Integer        '        optional identifier
        Dim m_COMB As Integer       '        combination method for items given at SCOM
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_SCOM() As CACT_RULE_SCOM '        index,factor and name of items
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TXT() As Integer '        Name of superposition
    End Structure

    Structure CLC_ACT0           ' 14/NR:0  Group of Actions for SUPP-task
        Dim m_ID As Integer         '        ident = 0  user defined ; < 0 automatic
        Dim m_LFB As Integer        '        load case offset
        Dim m_EXTR As Integer       '        type of formula for evaluating the extrema
        Dim m_TYPE As Integer       '        type or action of resulting load case
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Group designation for collection of actions
    End Structure

    Structure CLC_ACT1           ' 14/NR:1  Actionmember
        Dim m_ID As Integer         '        ident = 1
        Dim m_ACTION As Integer     '        ID of the action = type of action
        Dim m_TYPE As Integer       '        256*subgroup + 16*Group_of_action + superposition
        Dim m_GAMU As Single        '        safety factor unfavourable
        Dim m_GAMF As Single        '        safety factor favourable
        Dim m_PSI0 As Single        '        combination value
        Dim m_PSI1 As Single        '        combination value
        Dim m_PSI2 As Single        '        quasi permanent combination value
        Dim m_PS1S As Single        '        non frequent combination value psi1'
        Dim m_GAMA As Single        '        safety factor accidential
        Dim m_CAT As Integer        '        category (see 14/IDT) not used here
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        designation
    End Structure

    Structure CLC_ACT_L          ' 14/NR:2  loadcase of action
        Dim m_ID As Integer         '        ident = 2
        Dim m_LF As Integer         '        load case number
        Dim m_TYPE As Integer       '        load case action type
        Dim m_FACT As Single        '        factor
    End Structure

    Structure CLC_ACT_R          ' 14/NR:1?  Response Spectra
        Dim m_ID As Integer         '        Evaluation type of response
        Dim m_RESP As Integer       '        load case number of spectra
        Dim m_LFEIG As Integer      '        load case of first eigenform
        Dim m_NEIG As Integer       '        numbers of eigenforms to be used
    End Structure

    Structure CLC_ACT            ' 14/IDT:1  Action defaults
        Dim m_ID As Integer         '        ident = 1
        Dim m_ACTION As Integer     '        ID of the real action = type of action
        Dim m_TYPE As Integer       '        256*subgroup + 16*Group_of_action + superposition
        Dim m_GAMU As Single        '        safety factor unfavourable
        Dim m_GAMF As Single        '        safety factor favourable
        Dim m_PSI0 As Single        '        combination value
        Dim m_PSI1 As Single        '        combination value
        Dim m_PSI2 As Single        '        quasi permanent combination value
        Dim m_PS1S As Single        '        non frequent combination value psi1'
        Dim m_GAMA As Single        '        safety factor accidential
        Dim m_CAT As Integer        '        category for preselection of psi-values
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        designation
    End Structure

    Structure CCSM_GRP           ' 15/-1  Construction Stage Group Definitions
        Dim m_GRP As Integer        '        Group number
        Dim m_ICS As Integer        '        CS number of first activation
        Dim m_GFIX As Integer       '        CS number of hinge fixing
        Dim m_END As Integer        '        CS number of last action
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FREE() As Integer '        free integer for later use
        Dim m_T0 As Single          ' [  93] minimum age for loading
    End Structure

    Structure CCSM_LC            ' 15/-2  Construction Stage Loadcase Definitions
        Dim m_LC As Integer         '        Loadcase
        Dim m_START As Integer      '        CS number for first action
        Dim m_END As Integer        '        CS number of last action
    End Structure

    Structure CCSM_CS            ' 15/-3  Construction Stage Table
        Dim m_CS As Integer         '        Construction Stage
        Dim m_ID As Integer         '        Main action type in this CS
        Dim m_CSTEP As Integer      '        number of creep+shrink step to be produced
        Dim m_DL_CS As Integer      '        dead load activation in composite cross sections
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_FREE() As Integer '        free integer for later use
        Dim m_DT As Single          ' [  93] duration of creep+shrink step
        Dim m_RH As Single          ' [   8] relative humidity in this creep+shrink step
        Dim m_TEMP As Single        ' [   8] temperture in this creep+shrink step
    End Structure

    Structure CCSM_CREE          ' 15/-4  creep+shrink values for manual input
        Dim m_MNO As Integer        '        Material number
        Dim m_GRP As Integer        '        Group number
        Dim m_PHI As Single         '        total creep factor from first loading til infinite
        Dim m_EPS As Single         '        total shrinkage coefficient
        Dim m_RELAX As Single       '        total tendon relaxation
    End Structure

    Structure CCSG_CS            ' 15/-10  Construction Stage
        Dim m_NO As Integer         '        construction stage number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_TITL() As Integer '        Designation
        Dim m_DT As Single          ' [  93] duration of construction stage
    End Structure

    Structure CCSG_CGRP          ' 15/-11  Group specification
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_NO As Integer         '        group number
        Dim m_ACT As Integer        '        group action
        Dim m_ACT2 As Integer       '        group action cont'd
        Dim m_PTYP As Integer       '        type of prestressing
        Dim m_PLQ As Integer        '        primary load case swelling
        Dim m_MNO As Integer        '        material number
        Dim m_FACS As Single        '        stiffness factor
        Dim m_ALPH As Single        '        alpha factor
        Dim m_HW As Single          ' [  13] ground water level
        Dim m_K As Single           '        earth pressure coefficient
        Dim m_P As Single           '        prestress force
    End Structure

    Structure CCSG_CLAS          ' 15/-12  Load specification
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_NO As Integer         '        number of referenced loadcase
        Dim m_OPT As Integer        '        option of the load
        Dim m_FACT As Single        '        factor for loads
    End Structure

    Structure CCSG_CSYS          ' 15/-13  System specification
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_PROB As Integer       '        problem type
    End Structure

    Structure CCSG_CCRL          ' 15/-14  Computation control
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_OPT As Integer        '        control option
        Dim m_SAVE As Integer       '        save interval
        Dim m_FACQ As Integer       '        not used
        Dim m_VAL As Single         '        value of the option
        Dim m_FMAX As Single        '        2nd value of the option
        Dim m_FMIN As Single        '        3rd value of the option
        Dim m_EMAX As Single        '        4th value of the option
        Dim m_EMIN As Single        '        5th value of the option
        Dim m_V6 As Single          '        6th value of the option
        Dim m_V7 As Single          '        7th value of the option
        Dim m_V8 As Single          '        8th value of the option
    End Structure

    Structure CCSG_CGW           ' 15/-15  Change ground water level
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_HW As Single          ' [  13] new ground water level
    End Structure

    Structure CCSG_ECHO          ' 15/-16  Echo options
        Dim m_ICS As Integer        '        corresponding cs number
        Dim m_OPT As Integer        '        echo option
        Dim m_VAL As Integer        '        value of the option
    End Structure

    Structure CCSM_LC1           ' 15/LC:1  CSM loadcase parameters Group members
        Dim m_ID As Integer         '        identifier 1
        Dim m_GRP As Integer        '        Group number
        Dim m_T1 As Single          ' [  93] age at the end of loadcase
        Dim m_SUMEPS As Single      '        accumulated shrinkage strain
    End Structure

    Structure CCSM_LC2           ' 15/LC:2  CSM loadcase parameters quad-tendon members
        Dim m_ID As Integer         '        identifier 2
        Dim m_GRP As Integer        '        quad-tendon number
        Dim m_T1 As Single          ' [  93] age at the end of loadcase
        Dim m_SUMRELAX As Single    '        accumulated quad-tendon relaxation
    End Structure

    Structure CVIEW              ' 18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
        Dim m_IACHS As Integer      '        downward direction (compare 10/0)
        Dim m_PERS As Integer       '        Perspective
        Dim m_LC As Integer         '        loadcase
        Dim m_VOPT As Integer       '        View Options (Bitcode I)
        Dim m_EOPT As Integer       '        Element Options (Bitcode II)
        Dim m_COPT As Integer       '        Colour Options (Bitcode III)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DUMMY() As Integer '        reserved
        Dim m_TOPT As Integer       '        Exchange option
        Dim m_XBL As Single         ' [1001] X-coordinate of view point
        Dim m_YBL As Single         ' [1001] Y-coordinate of view point
        Dim m_ZBL As Single         ' [1001] Z-coordinate of view point
        Dim m_XCAM As Single        ' [1001] X-coordinate of camera point
        Dim m_YCAM As Single        ' [1001] Y-coordinate of camera point
        Dim m_ZCAM As Single        ' [1001] Z-coordinate of camera point
        Dim m_FAKV As Single        '        Factor of deformed structure
        Dim m_SSIZ As Single        '        Size of supports (0.-100.)
        Dim m_WMAG As Single        '        Warping magnification (0.-100.)
        Dim m_FOVY As Single        ' [   5] perspective angle of field of view
        Dim m_XUP As Single         '        X-part Up Vector
        Dim m_YUP As Single         '        Y-part Up Vector
        Dim m_ZUP As Single         '        Z-part Up Vector
    End Structure

    Structure CVIEW_SEL_R        '        Range lower and upper limit
        Dim m_LOW As Integer
        Dim m_UPP As Integer
    End Structure

    Structure CVIEW_SEL          ' 18/-2  currently selected elements in WINGRAF
        Dim m_ID As Integer         '        Identifikator
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_R() As CVIEW_SEL_R '        Range lower and upper limit
    End Structure

    Structure CVIEW_SRE          ' 18/-3  currently selected results in WINGRAF
        Dim m_KWH As Integer        '        Main key of current item
        Dim m_KWL As Integer        '        Secondary key of cuurent item (LF,MAT)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=14)> Dim m_VALUES() As Integer '        Selected values of this record type
    End Structure

    Structure CMTXT_0            ' 18/-4:0  Header for membrane manufacturing
        Dim m_ID As Integer         '        identificator = 0
        Dim m_LF As Integer         '        used load case of a deformed structure Lastfallnummer einer ver
        Dim m_BITS As Integer       '        Bitpattern of conditions of evaluation
        Dim m_NFL As Integer        '        Number of manufacturing areas
        Dim m_NQU As Integer        '        total number of QUADS within those areas
        Dim m_NNO As Integer        '        Number of new nodes inserted
    End Structure

    Structure CMTXT_NOD          ' 18/-4:-  Definition of new nodes
        Dim m_NO As Integer         '        Number of new interpolated node
        Dim m_QUAD As Integer       '        Nummer of QUAD-element containing this node
        Dim m_S As Single           '        S-Koordinate im QUAD-Element
        Dim m_T As Single           '        T-Koordinate im QUAD-Element
    End Structure

    Structure CMTXT_ELM          ' 18/-4:+  Definition of manufacturing elements
        Dim m_NO As Integer         '        Number of manufacturing area
        Dim m_QUAD As Integer       '        Number of QUAD-element
        Dim m_N1 As Integer         '        1st node (< 0 if new interpolated node)
        Dim m_N2 As Integer         '        2nd node (< 0 if new interpolated node)
        Dim m_N3 As Integer         '        3rd node (< 0 if new interpolated node)
        Dim m_N4 As Integer         '        4th node (< 0 if new interpolated node)
    End Structure

    Structure CVIEW_MCO          ' 18/-5  Colour of material
        Dim m_NO As Integer         '        Number of material / group
        Dim m_RED As Single         '        RGBA: red color
        Dim m_GREEN As Single       '        RGBA: green color
        Dim m_BLUE As Single        '        RGBA: blue color
        Dim m_ALPHA As Single       '        RGBA: alpha value
    End Structure

    Structure CVIEW_GCO          ' 18/-6  Colour of group
        Dim m_NO As Integer         '        Number of material / group
        Dim m_RED As Single         '        RGBA: red color
        Dim m_GREEN As Single       '        RGBA: green color
        Dim m_BLUE As Single        '        RGBA: blue color
        Dim m_ALPHA As Single       '        RGBA: alpha value
    End Structure

    Structure CANI_SELE          ' 18/-101:1  Dialogbox Animator selection request
        Dim m_SELE As Integer       '        identifier 1 : selection request
        Dim m_IGRP As Integer       '        element-group switch
        Dim m_NSEL As Integer       '        necessary-possible amount of selected elements
        Dim m_ETYP As Integer       '        requested element type - multiple records allowed
        Dim m_FROM As Integer       '        select only elements or groups from FROM to TO
        Dim m_TO As Integer         '        TO
    End Structure

    Structure CANI_CTRL          ' 18/-101:2  Dialogbox Animator drawing controls
        Dim m_SELE As Integer       '        identifier 2 : drawing controls
        Dim m_IGRP As Integer       '        element-group switch as in record 018/-101
        Dim m_NSEL As Integer       '        free
        Dim m_ETYP As Integer       '        element type - see 018/-101:1
        Dim m_FROM As Integer       '        drawing controls for elements/groups from FROM to TO
        Dim m_TO As Integer         '        TO
        Dim m_STYLE As Integer      '        representation style guide number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RGBA() As Single '        colour and transparency factor - only for STYLE=1
    End Structure

    Structure CANI_SRES          ' 18/-103  Selection result from Animator
        Dim m_ID101 As Integer      '        access ID of 18/-101 to check if selection allready done
        Dim m_IGRP As Integer       '        element-group switch as defined in 018/-101
        Dim m_ISEL As Integer       '        termination control
        Dim m_ETYP As Integer       '        element type - see 018/-101:1
        Dim m_FROM As Integer       '        first selected element or group
        Dim m_TO As Integer         '        last "
        Dim m_FREE As Integer       '        not used
        Dim m_X As Single           ' [1001] sectional abscissa
    End Structure

    Structure CLC_SELF           ' 18/LCD  Self weight loading of elements from ASE
        Dim m_KWH As Integer        '        Type of load element
        Dim m_NR As Integer         '        all other values as in KWH/LC
        Dim m_TYP As Integer        '        all other values as in KWH/LC
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_PVAL() As Single '        all other values as in KWH/LC
    End Structure

    Structure CGRP_BIL           ' 19/LC  Bilances of Flow in HYDRA
        Dim m_ID As Integer         '        type of result
        Dim m_NR As Integer         '        group number
        Dim m_QINP As Single        '        Quantity of inflow
        Dim m_QOUT As Single        '        Quantity of outflow
        Dim m_QNEW As Single        '        Quantity generated in domain
        Dim m_ENER As Single        '        Energy term
    End Structure

    Structure CNODE              ' 20/00  Nodes
        Dim m_NR As Integer         '        node-number
        Dim m_INR As Integer        '        internal node-number
        Dim m_KFIX As Integer       '        degree of freedoms
        Dim m_NCOD As Integer       '        additional bit code
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] X-Y-Z-ordinates
    End Structure

    Structure CNODE_GRC          ' 20/11:0  number of Nodegroups
        Dim m_ID As Integer
        Dim m_MAXGRP As Integer     '        maximum number of groups per node
    End Structure

    Structure CNODE_GRP          ' 20/11:+  Nodegroups
        Dim m_N As Integer          '        node-number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IGRP() As Integer '        group-numbers connecting to node
    End Structure

    Structure CNODE_KIC          ' 21/00:0  Info on kinematic constraints
        Dim m_ID As Integer
        Dim m_NLEV As Integer       '        depth of recurent coupling (obsolete)
        Dim m_NKIN As Integer       '        maximum number of coupling equations
        Dim m_NVAR As Integer       '        maximum number of coupling factors
    End Structure

    Structure CNODE_KIN          ' 21/00:+  Standard kinematic constraint
        Dim m_KTL As Integer        '        type + 100 * depth + 10000*group-number
        Dim m_NR As Integer         '        node-number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_KR() As Integer '        reference nodes
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() As Single '        direction of coupling X/Y/Z-axis
        Dim m_DD As Single          '        factor of interpolation for INTP/INTF/INTS
        Dim m_FF As Single          '        factor of multiplication (not used)
    End Structure

    Structure CNODE_KIG_ID       '        node+degree-numbers of dependent and up to 21
        Dim m_NR As Integer
        Dim m_ND As Integer
    End Structure

    Structure CNODE_KIG          ' 21/00:*99  general constraints (equation list)
        Dim m_KTL As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=22)> Dim m_ID() As CNODE_KIG_ID '        node+degree-numbers of dependent and up to 21
    End Structure

    Structure CNODE_KIF          ' 21/00:*99  general constraints (factor list)
        Dim m_KTL As Integer        '        99 + 100 * depth
        Dim m_ID As Integer         '        identifier 0
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=21)> Dim m_FR() As Single '        factors of constrained equation
    End Structure

    Structure CNODE_KIH          ' 21/09  Hydraulic couplings
        Dim m_NG As Integer         '        group-number
        Dim m_NR As Integer         '        node-number
        Dim m_KR As Integer         '        reference node
    End Structure

    Structure CNODE_KFC          ' 22/LC:0  Max. Constraining Forces
        Dim m_ID As Integer         '        identifier 0
        Dim m_PX As Single          ' [1190] force component X
        Dim m_PY As Single          ' [1190] force component Y
        Dim m_PZ As Single          ' [1190] force component Z
        Dim m_MX As Single          ' [1194] moment component X
        Dim m_MY As Single          ' [1194] moment component Y
        Dim m_MZ As Single          ' [1194] moment component Z
        Dim m_MB As Single          ' [1194] warping moment
    End Structure

    Structure CNODE_KFO          ' 22/LC:+  Constraining forces
        Dim m_NR As Integer         '        node-number
        Dim m_PX As Single          ' [1190] force component X
        Dim m_PY As Single          ' [1190] force component Y
        Dim m_PZ As Single          ' [1190] force component Z
        Dim m_MX As Single          ' [1194] moment component X
        Dim m_MY As Single          ' [1194] moment component Y
        Dim m_MZ As Single          ' [1194] moment component Z
        Dim m_MB As Single          ' [1194] warping moment
    End Structure

    Structure CNODE_L            ' 23/LC:+  Nodal_loads
        Dim m_NR As Integer         '        node-number
        Dim m_TYP As Integer        '        type of load
        Dim m_PX As Single          ' [1190] single force X-component
        Dim m_PY As Single          ' [1190] single force Y-component
        Dim m_PZ As Single          ' [1190] single force Z-component
        Dim m_MX As Single          ' [1194] single moment X-component
        Dim m_MY As Single          ' [1194] single moment Y-component
        Dim m_MZ As Single          ' [1194] single moment Z-component
        Dim m_MB As Single          ' [1195] warping moment
    End Structure

    Structure CNODE_LW           ' 23/LC:+  prescribed support displacements
        Dim m_NR As Integer         '        node-number
        Dim m_TYP As Integer        '        type of load
        Dim m_WX As Single          ' [1003] Displacement X
        Dim m_WY As Single          ' [1003] Displacement Y
        Dim m_WZ As Single          ' [1003] Displacement Z
        Dim m_RX As Single          ' [1004] Rotation X-X
        Dim m_RY As Single          ' [1004] Rotation Y-Y
        Dim m_RZ As Single          ' [1004] Rotation Z-Z
    End Structure

    Structure CNODE_ACC          ' 23/LC:*  Base acceleration
        Dim m_NR As Integer         '        node number / influence load case
        Dim m_TYP As Integer        '        type of load (=10)
        Dim m_AX As Single          ' [1202] transversal acceleration X
        Dim m_AY As Single          ' [1202] transversal acceleration Y
        Dim m_AZ As Single          ' [1202] transversal acceleration Z
        Dim m_AXX As Single         ' [1207] rotational acceleration X-X
        Dim m_AYY As Single         ' [1207] rotational acceleration Y-Y
        Dim m_AZZ As Single         ' [1207] rotational acceleration Z-Z
        Dim m_EX As Single          ' [1001] reference point for rotational acceleration
        Dim m_EY As Single          ' [1001] reference point for rotational acceleration
        Dim m_EZ As Single          ' [1001] reference point for rotational acceleration
        Dim m_EXREF As Single       '        V25: if a value is present (length criteria)
    End Structure

    Structure CNODE_LA           ' 23/LC:+  prescribed nodal accelerations
        Dim m_NR As Integer         '        node-number
        Dim m_TYP As Integer        '        type of load
        Dim m_AX As Single          ' [1003] acceleration X
        Dim m_AY As Single          ' [1003] acceleration Y
        Dim m_AZ As Single          ' [1003] acceleration Z
        Dim m_ARX As Single         ' [1004] Rotation X-X
        Dim m_ARY As Single         ' [1004] Rotation Y-Y
        Dim m_ARZ As Single         ' [1004] Rotation Z-Z
    End Structure

    Structure CNODE_ROT          ' 23/LC:+  Rotation of Body
        Dim m_NR As Integer         '        influence reference
        Dim m_TYP As Integer        '        type of load (=20)
        Dim m_AXX As Single         ' [1207] rotational acceleration X-X  (= vxx**2)
        Dim m_AYY As Single         ' [1207] rotational acceleration Y-Y  (= vyy**2)
        Dim m_AZZ As Single         ' [1207] rotational acceleration Z-Z  (= vzz**2)
        Dim m_EX As Single          ' [1001] reference point for rotational acceleration
        Dim m_EY As Single          ' [1001] reference point for rotational acceleration
        Dim m_EZ As Single          ' [1001] reference point for rotational acceleration
    End Structure

    Structure CN_DISPC           ' 24/LC:0  Max. Displacements and support forces
        Dim m_ID As Integer
        Dim m_UX As Single          ' [1003] displacement X
        Dim m_UY As Single          ' [1003] displacement Y
        Dim m_UZ As Single          ' [1003] displacement Z
        Dim m_URX As Single         ' [1004] rotation X
        Dim m_URY As Single         ' [1004] rotation Y
        Dim m_URZ As Single         ' [1004] rotation Z
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support X
        Dim m_PY As Single          ' [1151] nodal support Y
        Dim m_PZ As Single          ' [1151] nodal support Z
        Dim m_MX As Single          ' [1152] support moment X
        Dim m_MY As Single          ' [1152] support moment Y
        Dim m_MZ As Single          ' [1152] support moment Z
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_DISPIC          ' 26/LC:0  Max. Displacement and forces increments
        Dim m_ID As Integer
        Dim m_UX As Single          ' [1003] displacement X
        Dim m_UY As Single          ' [1003] displacement Y
        Dim m_UZ As Single          ' [1003] displacement Z
        Dim m_URX As Single         ' [1004] rotation X
        Dim m_URY As Single         ' [1004] rotation Y
        Dim m_URZ As Single         ' [1004] rotation Z
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support X
        Dim m_PY As Single          ' [1151] nodal support Y
        Dim m_PZ As Single          ' [1151] nodal support Z
        Dim m_MX As Single          ' [1152] support moment X
        Dim m_MY As Single          ' [1152] support moment Y
        Dim m_MZ As Single          ' [1152] support moment Z
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_DISPTC          ' 27/LC:0  Max. Cooordinate offsets
        Dim m_ID As Integer
        Dim m_UX As Single          ' [1003] displacement X
        Dim m_UY As Single          ' [1003] displacement Y
        Dim m_UZ As Single          ' [1003] displacement Z
        Dim m_URX As Single         ' [1004] rotation X
        Dim m_URY As Single         ' [1004] rotation Y
        Dim m_URZ As Single         ' [1004] rotation Z
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support X
        Dim m_PY As Single          ' [1151] nodal support Y
        Dim m_PZ As Single          ' [1151] nodal support Z
        Dim m_MX As Single          ' [1152] support moment X
        Dim m_MY As Single          ' [1152] support moment Y
        Dim m_MZ As Single          ' [1152] support moment Z
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_DISP            ' 24/LC:+  Displacements and support forces of nodes
        Dim m_NR As Integer         '        node-number
        Dim m_UX As Single          ' [1003] displacement
        Dim m_UY As Single          ' [1003] displacement
        Dim m_UZ As Single          ' [1003] displacement
        Dim m_URX As Single         ' [1004] rotation
        Dim m_URY As Single         ' [1004] rotation
        Dim m_URZ As Single         ' [1004] rotation
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support
        Dim m_PY As Single          ' [1151] nodal support
        Dim m_PZ As Single          ' [1151] nodal support
        Dim m_MX As Single          ' [1152] support moment
        Dim m_MY As Single          ' [1152] support moment
        Dim m_MZ As Single          ' [1152] support moment
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_DISPI           ' 26/LC:+  Displacement increments and residual forces
        Dim m_NR As Integer         '        node-number
        Dim m_UX As Single          ' [1003] displacement
        Dim m_UY As Single          ' [1003] displacement
        Dim m_UZ As Single          ' [1003] displacement
        Dim m_URX As Single         ' [1004] rotation
        Dim m_URY As Single         ' [1004] rotation
        Dim m_URZ As Single         ' [1004] rotation
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support
        Dim m_PY As Single          ' [1151] nodal support
        Dim m_PZ As Single          ' [1151] nodal support
        Dim m_MX As Single          ' [1152] support moment
        Dim m_MY As Single          ' [1152] support moment
        Dim m_MZ As Single          ' [1152] support moment
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_DISPT           ' 27/LC:+  Cooordinate offsets
        Dim m_NR As Integer         '        node-number
        Dim m_UX As Single          ' [1003] displacement
        Dim m_UY As Single          ' [1003] displacement
        Dim m_UZ As Single          ' [1003] displacement
        Dim m_URX As Single         ' [1004] rotation
        Dim m_URY As Single         ' [1004] rotation
        Dim m_URZ As Single         ' [1004] rotation
        Dim m_URB As Single         ' [1005] twisting
        Dim m_PX As Single          ' [1151] nodal support
        Dim m_PY As Single          ' [1151] nodal support
        Dim m_PZ As Single          ' [1151] nodal support
        Dim m_MX As Single          ' [1152] support moment
        Dim m_MY As Single          ' [1152] support moment
        Dim m_MZ As Single          ' [1152] support moment
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CN_VELOC           ' 25/LC:0  Max. velocities and accelerations of nodes
        Dim m_ID As Integer
        Dim m_VX As Single          ' [1201] velocity X
        Dim m_VY As Single          ' [1201] velocity Y
        Dim m_VZ As Single          ' [1201] velocity Z
        Dim m_VRX As Single         ' [1206] angular veloc. XX
        Dim m_VRY As Single         ' [1206] angular veloc. YY
        Dim m_VRZ As Single         ' [1206] angular veloc. ZZ
        Dim m_VBB As Single         ' [1208] twisting velocity
        Dim m_AX As Single          ' [1202] acceleration X
        Dim m_AY As Single          ' [1202] acceleration Y
        Dim m_AZ As Single          ' [1202] acceleration Z
        Dim m_ARX As Single         ' [1207] ang. acceler. XX
        Dim m_ARY As Single         ' [1207] ang. acceler. YY
        Dim m_ARZ As Single         ' [1207] ang. acceler. ZZ
        Dim m_ABB As Single         ' [1209] twisting acceler
    End Structure

    Structure CN_VELO            ' 25/LC:+  velocitys and acceleration of nodes
        Dim m_NR As Integer         '        node-number
        Dim m_VX As Single          ' [1201] velocity X
        Dim m_VY As Single          ' [1201] velocity Y
        Dim m_VZ As Single          ' [1201] velocity Z
        Dim m_VRX As Single         ' [1206] angular veloc. X-X
        Dim m_VRY As Single         ' [1206] angular veloc. Y-Y
        Dim m_VRZ As Single         ' [1206] angular veloc. Z-Z
        Dim m_VBB As Single         ' [1208] twisting velocity
        Dim m_AX As Single          ' [1202] acceleration X
        Dim m_AY As Single          ' [1202] acceleration Y
        Dim m_AZ As Single          ' [1202] acceleration Z
        Dim m_ARX As Single         ' [1207] ang. acceler. X-X
        Dim m_ARY As Single         ' [1207] ang. acceler. Y-Y
        Dim m_ARZ As Single         ' [1207] ang. acceler. Z-Z
        Dim m_ABB As Single         ' [1209] twisting acceler
    End Structure

    Structure CSPT               ' 39/NR:0  Structural points
        Dim m_ID As Integer         '        identifier 0
        Dim m_IDS As Integer        '        optional identifier of point
        Dim m_REF As Integer        '        reserved reference
        Dim m_NOG As Integer        '        reserved number of group
        Dim m_NOM As Integer        '        reserved number of material
        Dim m_NOR As Integer        '        reserved number of reinforc.
        Dim m_IBT As Integer        '        Bitpattern of element properties
        Dim m_IBC As Integer        '        Boundary condition
        Dim m_I_8 As Integer        '        reserved
        Dim m_I_9 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Coordinates of that point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
        Dim m_BX As Single          ' [1001] Dimension in local x
        Dim m_BY As Single          ' [1001] Dimension in local y
        Dim m_THICK As Single       ' [1010] Plate thickness at that point
        Dim m_HMESH As Single       ' [1001] Mesh density at point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_RES() As Single '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Point
    End Structure

    Structure CSLN               ' 39/NR:100  Structural lines
        Dim m_ID As Integer         '        identifier 100
        Dim m_IDS As Integer        '        optional identifier of structural line
        Dim m_REF As Integer        '        reference identifier to a given GAX [chr] or sln [int]
        Dim m_SREF As Integer       '        secondary axis enum for GAX references
        Dim m_NA As Integer         '        optional identifier of line start point
        Dim m_NB As Integer         '        optional identifier of line end point
        Dim m_IBT As Integer        '        Bitpattern of element properties
        Dim m_IBC As Integer        '        primary boundary condition
        Dim m_ID8 As Integer        '        reserved
        Dim m_ID9 As Integer        '        reserved
        Dim m_HMESH As Single       ' [1001] >0.0 = mesh density along line
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TUP() As Single '        Vector to define downward direction
        Dim m_TROT As Single        '        Fractional rotation about local x-axis  (obsoleted => :101/:102
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis      (obsoleted => :101/:102
        Dim m_PROG As Single        '        progression factor (>0 monoton, <0 symmetric)
        Dim m_R10 As Single         '        reserved
        Dim m_R11 As Single         '        reserved
        Dim m_R12 As Single         '        reserved
        Dim m_R13 As Single         '        reserved
        Dim m_R14 As Single         '        reserved
        Dim m_R15 As Single         '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Line
    End Structure

    Const SLN_BEAM_NONE = -1
    Const SLN_BEAM_CENTRIC = 0
    Const SLN_BEAM_REFERENCE = 1
    Const SLN_BEAM_TRUSS = 2
    Const SLN_BEAM_CABLE = 3
    Const SLN_BEAM_CCOLUMN = 4
    Const SLN_BEAM_COLUMN = 5
    Const SLN_BEAM_SECTION = 7
    Structure CSLN_BEAM          ' 39/NR:101  Properties of beams
        Dim m_ID As Integer         '        ident 101
        Dim m_TYP As Integer        '        Element type (see 009/NR:90:4 IBTYP)
        Dim m_NOG As Integer        '        group number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NQ() As Integer '        number cross section start/end
        Dim m_NP As Integer         '        number bedding props
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IBC() As Integer '        Hinge properties A/E/XA/XE (start/end/internal start/end)
        Dim m_DIV As Integer        '        type of element subdivision
        Dim m_KR As Single          '        identifier of local coordinate system orientation
        Dim m_R12 As Single
        Dim m_R13 As Single
        Dim m_R14 As Single
        Dim m_R15 As Single
        Dim m_EXA As Single         ' [1001] eccentricity at start
        Dim m_EYA As Single         ' [1001] eccentricity at start
        Dim m_EZA As Single         ' [1001] eccentricity at start
        Dim m_EXE As Single         ' [1001] eccentricity at end
        Dim m_EYE As Single         ' [1001] eccentricity at end
        Dim m_EZE As Single         ' [1001] eccentricity at end
        Dim m_TROT As Single        '        additional rotation about local x-axis, given as fraction of 36
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        vector defining the orientation of the local z-axis of the loca
    End Structure

    Structure CGLN_BPRO          ' 31/NR:101  Properties of beams
        Dim m_ID As Integer         '        ident 101
        Dim m_TYP As Integer        '        Element type (see 009/NR:90:4 IBTYP)
        Dim m_NOG As Integer        '        group number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NQ() As Integer '        number cross section start/end
        Dim m_NP As Integer         '        number bedding props
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_IBC() As Integer '        Hinge properties A/E/XA/XE (start/end/internal start/end)
        Dim m_DIV As Integer        '        type of element subdivision
        Dim m_KR As Single          '        identifier of local coordinate system orientation
        Dim m_R12 As Single
        Dim m_R13 As Single
        Dim m_R14 As Single
        Dim m_R15 As Single
        Dim m_EXA As Single         ' [1001] eccentricity at start
        Dim m_EYA As Single         ' [1001] eccentricity at start
        Dim m_EZA As Single         ' [1001] eccentricity at start
        Dim m_EXE As Single         ' [1001] eccentricity at end
        Dim m_EYE As Single         ' [1001] eccentricity at end
        Dim m_EZE As Single         ' [1001] eccentricity at end
        Dim m_TROT As Single        '        additional rotation about local x-axis, given as fraction of 36
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        vector defining the orientation of the local z-axis of the loca
    End Structure

    Structure CSLN_SUPP          ' 39/NR:102  Support of Structural lines
        Dim m_ID As Integer         '        identifier 102
        Dim m_IDS As Integer        '        type of reference
        Dim m_REF As Integer        '        reference identifier
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_IBC As Integer        '        Boundary condition / kinematic constraints
        Dim m_KR As Integer         '        local orientation
        Dim m_W As Single           ' [1001] width of support
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
        Dim m_CM As Single          ' [1099] torsional bedding
        Dim m_DRX As Single         '        explicit X direction of support
        Dim m_DRY As Single         '        explicit Y direction of support
        Dim m_DRZ As Single         '        explicit Z direction of support
        Dim m_D As Single           ' [1001] distance to coupled line (IDS={5,6,7})
        Dim m_R8 As Single
        Dim m_R9 As Single
        Dim m_FKA As Single         '        factor bedding at start
        Dim m_FKE As Single         '        factor bedding at end
        Dim m_TROT As Single        '        Fractional rotation about local x-axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis
    End Structure

    Structure CGLN_SUPP          ' 31/NR:102  Support of Structural lines
        Dim m_ID As Integer         '        identifier 102
        Dim m_IDS As Integer        '        type of reference
        Dim m_REF As Integer        '        reference identifier
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_IBC As Integer        '        Boundary condition / kinematic constraints
        Dim m_KR As Integer         '        local orientation
        Dim m_W As Single           ' [1001] width of support
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
        Dim m_CM As Single          ' [1099] torsional bedding
        Dim m_DRX As Single         '        explicit X direction of support
        Dim m_DRY As Single         '        explicit Y direction of support
        Dim m_DRZ As Single         '        explicit Z direction of support
        Dim m_D As Single           ' [1001] distance to coupled line (IDS={5,6,7})
        Dim m_R8 As Single
        Dim m_R9 As Single
        Dim m_FKA As Single         '        factor bedding at start
        Dim m_FKE As Single         '        factor bedding at end
        Dim m_TROT As Single        '        Fractional rotation about local x-axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis
    End Structure

    Structure CSLN_EXYZ          ' 39/NR:120  Explicit nodes on lines
        Dim m_ID As Integer         '        identifier = 120
        Dim m_ID1 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_XYZ() As Single ' [1001] XYZ coordinates
    End Structure

    Structure CGLN_EXYZ          ' 31/NR:120  Explicit nodes on lines
        Dim m_ID As Integer         '        identifier = 120
        Dim m_ID1 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=192)> Dim m_XYZ() As Single ' [1001] XYZ coordinates
    End Structure

    Structure CSLN_SCT           ' 39/NR:130  Beams sections
        Dim m_ID As Integer         '        identifier = 130
        Dim m_REFT As Integer       '        Type of reference
        Dim m_ITYP As Integer       '        Bitcodes according 100/NR:0 ITYP
        Dim m_I1 As Integer         '        reserved
        Dim m_S As Single           ' [1001] location on geometry
    End Structure

    Structure CGLN_SCT           ' 31/NR:130  Beams sections
        Dim m_ID As Integer         '        identifier = 130
        Dim m_REFT As Integer       '        Type of reference
        Dim m_ITYP As Integer       '        Bitcodes according 100/NR:0 ITYP
        Dim m_I1 As Integer         '        reserved
        Dim m_S As Single           ' [1001] location on geometry
    End Structure

    Structure CSAR               ' 39/NR:200  Structural area
        Dim m_ID As Integer         '        identification of general data = 200
        Dim m_IDS As Integer        '        identifier of structural area (0=auto)
        Dim m_REF As Integer        '        reference to a given GAR [chr] or SAR [int]
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_NOR As Integer        '        number of reinforc.
        Dim m_ITP As Integer        '        Bitpattern for element generation QUAD
        Dim m_IBC As Integer        '        Boundary condition
        Dim m_KR As Integer         '        local orientation QUADs
        Dim m_IATR As Integer       '        Bitpattern for attribut areas (see SBOX_PROP)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TD() As Single ' [1010] Constant thickness
        Dim m_CB As Single          '        bedding factor
        Dim m_CQ As Single          '        tangential bedding factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TUP() As Single '        Vector to define upward direction
        Dim m_TROT As Single        '        Fractional rotation about local z-axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_H() As Single ' [1001] mesh density parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of surface
    End Structure

    Structure CSAR_INF           ' 39/NR:210  GeometricAreaInfo
        Dim m_ID0 As Integer        '        identifier 210
        Dim m_NG As Integer         '        Type of surface representation
        Dim m_GID1 As Integer       '        Axis identifier of first reference axis
        Dim m_GID2 As Integer       '        Axis identifier of second reference axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() As Single '        Transformation
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() As Single '        umin,umax,vmin,vmax of the parameter plane
    End Structure

    Structure CSAR_PTS           ' 39/NR:211  AreaPointonSurface
        Dim m_ID As Integer         '        Identifier 211
        Dim m_IT As Integer         '        Type of point (see 5/ID:11 for more)
        Dim m_M As Integer          '        Rasterlocation of mesh (0 < m < mgri )
        Dim m_N As Integer          '        Rasterlocation of mesh (0 < n < ngri )
        Dim m_W As Single           '        the weight of NURBS control point
        Dim m_X As Single           ' [1001] X-ordinate
        Dim m_Y As Single           ' [1001] Y-ordinate
        Dim m_Z As Single           ' [1001] Z-ordinate
        Dim m_T As Single           ' [1010] Thickness
    End Structure

    Structure CSAR_CPI           ' 39/NR:212  COONsPatchInfo
        Dim m_ID As Integer         '        Id = 212
        Dim m_IT As Integer         '        Type of blending
        Dim m_IU0 As Integer        '        No of geometry line for u=umin (left)
        Dim m_IU1 As Integer        '        No of geometry line for u=umax (right)
        Dim m_IV0 As Integer        '        No of geometry line for v=vmin (lower)
        Dim m_IV1 As Integer        '        No of geometry line for v=vmax (upper)
    End Structure

    Structure CSAR_EXYZ          ' 39/NR:220  Explicit QUAD nodes on area
        Dim m_ID As Integer         '        identifier = 220
        Dim m_ID1 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() As Single ' [1001] XYZ coordinates
    End Structure

    Structure CGAR_EXYZ          ' 32/NR:220  Explicit QUAD nodes on area
        Dim m_ID As Integer         '        identifier = 220
        Dim m_ID1 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() As Single ' [1001] XYZ coordinates
    End Structure

    Structure CSAR_SUPP          ' 39/NR:221  Support and coupling of structural areas
        Dim m_ID As Integer         '        identifier 221
        Dim m_IDS As Integer        '        type of reference
        Dim m_REF As Integer        '        reference identifier
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_IBC As Integer        '        Boundary condition / kinematic constraints
        Dim m_I6 As Integer         '        reserved
        Dim m_RCTL As Integer       '        properties of area-area reference
        Dim m_RPTR As Integer       '        reference point on boundary of referenced area
        Dim m_RPT0 As Integer       '        reference point on boundary of given area
        Dim m_I10 As Integer        '        reserved
        Dim m_D As Single           ' [1001] distance of interface layer
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
    End Structure

    Structure CGAR_SUPP          ' 32/NR:221  Support and coupling of structural areas
        Dim m_ID As Integer         '        identifier 221
        Dim m_IDS As Integer        '        type of reference
        Dim m_REF As Integer        '        reference identifier
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_IBC As Integer        '        Boundary condition / kinematic constraints
        Dim m_I6 As Integer         '        reserved
        Dim m_RCTL As Integer       '        properties of area-area reference
        Dim m_RPTR As Integer       '        reference point on boundary of referenced area
        Dim m_RPT0 As Integer       '        reference point on boundary of given area
        Dim m_I10 As Integer        '        reserved
        Dim m_D As Single           ' [1001] distance of interface layer
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
    End Structure

    Structure CSVO               ' 39/NR:300  StructuralVolume
        Dim m_ID As Integer         '        identification = 300
        Dim m_IDS As Integer        '        identifier of structural area (0=auto)
        Dim m_REF As Integer        '        reference to a given GVO (reserved)
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_NOR As Integer        '        number of reinforc.
        Dim m_NOT As Integer        '        number of elementtype
        Dim m_IBC As Integer        '        Boundary condition
        Dim m_ID8 As Integer        '        reserved
        Dim m_ID9 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Volume
    End Structure

    Structure CSPT_ID            ' 39/NR:999  GUId
        Dim m_ID As Integer         '        identifier 999
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=36)> Dim m_IDBIM() As Integer '        256 Bit GUId Identifier of preceeding element
    End Structure

    Const GPT_IBC_SUP = 8192
    Const GPT_IBC_REF = 32768
    Structure CGPT               ' 30/NR:0  Structural points
        Dim m_ID As Integer         '        identifier 0 (always the first record)
        Dim m_IBC As Integer        '        Boundary condition
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] Ordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
        Dim m_BX As Single          ' [1001] Dimension in x
        Dim m_BY As Single          ' [1001] Dimension in y
        Dim m_THICK As Single       ' [1010] Plate thickness
        Dim m_HMESH As Single       ' [1001] Mesh density at point
        Dim m_R17 As Single         '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Point
    End Structure

    Structure CGPT_COH           ' 30/NR:1  Dimension of column head
        Dim m_ID As Integer         '        identifier 1/2/3
        Dim m_NS As Integer         '        Number of a cross section 9/NR for details
        Dim m_X As Single           ' [1001] Width in local x
        Dim m_Y As Single           ' [1001] Width in local y
        Dim m_A As Single           ' [1002] Equivalent Area
        Dim m_T As Single           ' [1010] Plate thickness
    End Structure

    Structure CGPT_HAU           ' 30/NR:2  Dimension of voute
        Dim m_ID As Integer         '        identifier 1/2/3
        Dim m_NS As Integer         '        Number of a cross section 9/NR for details
        Dim m_X As Single           ' [1001] Width in local x
        Dim m_Y As Single           ' [1001] Width in local y
        Dim m_A As Single           ' [1002] Equivalent Area
        Dim m_T As Single           ' [1010] Plate thickness
    End Structure

    Structure CGPT_PUN           ' 30/NR:3  Dimension of punching perimeter
        Dim m_ID As Integer         '        identifier 1/2/3
        Dim m_NS As Integer         '        Number of a cross section 9/NR for details
        Dim m_X As Single           ' [1001] Width in local x
        Dim m_Y As Single           ' [1001] Width in local y
        Dim m_A As Single           ' [1002] Equivalent Area
        Dim m_T As Single           ' [1010] Plate thickness
    End Structure

    Structure CGPT_COL           ' 30/NR:4  Connecting columns
        Dim m_ID As Integer         '        identifier 4
        Dim m_NS As Integer         '        Number of a cross section 9/NR for column
        Dim m_X As Single           ' [1001] Width in local x
        Dim m_Y As Single           ' [1001] Width in local y
        Dim m_A As Single           ' [1002] Equivalent Area
        Dim m_L As Single           ' [1001] Column length
        Dim m_FAK As Single         '        Rigidity factor
    End Structure

    Structure CGPT_FOO           ' 30/NR:5  Footing instance definition
        Dim m_ID As Integer         '        identifier 5
        Dim m_POS As Integer        '        referenced building position
        Dim m_TYPE As Integer       '        Type of foundation
        Dim m_IGP As Integer        '        Bitpattern Foundation Properties
        Dim m_IDR As Integer        '        Bitpattern Design Results
        Dim m_IR1 As Integer        '        reserved
        Dim m_MNO As Integer        '        Id of concrete material
        Dim m_MRF As Integer        '        Id of reinforcement material
        Dim m_NRSP As Integer       '        Id of soil profile (002/NR)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        Orientation of local coordinate system
        Dim m_BX As Single          ' [1001] Width in local x
        Dim m_BY As Single          ' [1001] Width in local y
        Dim m_HI As Single          ' [1001] inner Thickness
        Dim m_HA As Single          ' [1001] outer Thickness
        Dim m_EX As Single          ' [1001] Eccentricity of column in local x-direction
        Dim m_EY As Single          ' [1001] Eccentricity of column in local y-direction
        Dim m_EZ As Single          ' [1001] Eccentricity of endpoint of column(=structural point) in local 
        Dim m_CLX As Single         ' [1011] Assumed dimension of column in local x-direction
        Dim m_CLY As Single         ' [1011] Assumed dimension of column in local y-direction
        Dim m_SXT As Single         ' [1024] Boundary distance of x-aligned reinforcement on top face
        Dim m_SYT As Single         ' [1024] Boundary distance of y-aligned reinforcement on top face
        Dim m_SXB As Single         ' [1024] Boundary distance of x-aligned reinforcement on bottom face
        Dim m_SYB As Single         ' [1024] Boundary distance of y-aligned reinforcement on bottom face
        Dim m_COVT As Single        ' [1024] Concrete cover (nominal) on top face
        Dim m_COVB As Single        ' [1024] Concrete cover (nominal) on bottom face
        Dim m_COVL As Single        ' [1024] Concrete cover (nominal) on lateral faces
        Dim m_RES1 As Single        '        Reserved
        Dim m_RES2 As Single        '        Reserved
        Dim m_RES3 As Single        '        Reserved
        Dim m_RES4 As Single        '        Reserved
        Dim m_SLHO As Single        ' [1001] obsolete
        Dim m_SLHI As Single        ' [1001] obsolete
        Dim m_SLWX As Single        ' [1001] obsolete
        Dim m_SLWY As Single        ' [1001] obsolete
        Dim m_SLGU As Single        ' [1001] obsolete
        Dim m_SLGL As Single        ' [1001] obsolete
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_DATA() As Single '        Reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITL() As Integer '        Designation of Foundation
    End Structure

    Structure CGPT_FRR           ' 30/NR:1005  Footing required reinforcement
        Dim m_ID As Integer         '        identifier 1005
        Dim m_TYPE As Integer       '        Type of reinforcement
        Dim m_N_AS As Integer       '        number of values stored in array AS
        Dim m_IR1 As Integer        '        reserved
        Dim m_IR2 As Integer        '        reserved
        Dim m_XOFF As Single        ' [1001] offset of distribution in x-direction
        Dim m_YOFF As Single        ' [1001] offset of distribution in y-direction
        Dim m_RES1 As Single        '        reserved
        Dim m_RES2 As Single        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_AS() As Single ' [1021] reinforcement values
    End Structure

    Structure CGPT_SLP           ' 30/NR:1006  Sleeve foundation properties
        Dim m_ID As Integer         '        identifier 1006
        Dim m_IR1 As Integer        '        reserved
        Dim m_IR2 As Integer        '        reserved
        Dim m_IR3 As Integer        '        reserved
        Dim m_HSWO As Single        ' [1001] Outer height of sleeve wall (measured from z=0 of local coordin
        Dim m_HSWI As Single        ' [1001] Inner height of sleeve wall (measured from upper face of sleeve
        Dim m_WXWU As Single        ' [1001] Upper width of sleeve wall in x-direction
        Dim m_WYWU As Single        ' [1001] Upper width of sleeve wall in y-direction
        Dim m_WXWL As Single        ' [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
        Dim m_WYWL As Single        ' [1001] Lower width of sleeve wall in y-direction
        Dim m_WXGU As Single        ' [1001] Upper width of gap between wall and column in x-direction
        Dim m_WYGU As Single        ' [1001] Upper width of gap between wall and column in y-direction
        Dim m_WXGL As Single        ' [1001] Lower width of gap between wall and column in x-direction
        Dim m_WYGL As Single        ' [1001] Lower width of gap between wall and column in y-direction
        Dim m_CLX As Single         ' [1011] Assumed dimension of column in local x-direction (deprecated)
        Dim m_CLY As Single         ' [1011] Assumed dimension of column in local y-direction (deprecated)
    End Structure

    Structure CGPT_HPI           ' 30/NR:6  Halfspace pile
        Dim m_ID As Integer         '        identifier 6
        Dim m_NQ As Integer         '        number cross section   =0 if diameter from 030/NR:0
        Dim m_L As Single           ' [1001] pile length in GDIR direction
        Dim m_MANT As Single        '        percentage of skin friction for linear analysis
        Dim m_ZMAN As Single        '        percentage of inactive skin length
        Dim m_PMAN As Single        ' [1151] maximum load skin friction (nonlinear analysis)
        Dim m_PMAF As Single        ' [1151] maximum load pile foot
    End Structure

    Structure CGPT_CON_M         '        connected members
        Dim m_NELT As Integer
        Dim m_NREL As Integer
        Dim m_NODE As Integer
        Dim m_NARB As Integer
        Dim m_X As Single           ' [1001] 
    End Structure

    Structure CGPT_CON           ' 30/NR:8  Steelconnection reference
        Dim m_ID As Integer         '        identifier 8
        Dim m_CONID As Integer      '        connection identifier
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_M() As CGPT_CON_M '        connected members
    End Structure

    Structure CGPT_SPR           ' 30/NR:10  Elastic Spring support
        Dim m_ID As Integer         '        identifier 10
        Dim m_IRI As Integer        '        direction
        Dim m_NR As Integer         '        element number
        Dim m_NG As Integer         '        group number
        Dim m_IPC As Integer        '        connecting to node
        Dim m_NWL As Integer        '        Reference to work-law / material no
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() As Single '        explicit direction (dx,dy,dz)
        Dim m_AREF As Single        '        reference / influence area (see also  184 170/0 )
        Dim m_CP As Single          ' [1095] spring stiffness z
        Dim m_CQ As Single          ' [1095] transverse stiff.
        Dim m_CM As Single          ' [1098] torsional stiff.
        Dim m_PRE As Single         '        prestress for cp
        Dim m_GAP As Single         '        slip of spring
        Dim m_RISS As Single        '        max tension force
        Dim m_FLIE As Single        '        yielding load
        Dim m_MUE As Single         '        friction cross
        Dim m_COH As Single         '        cohesion cross
        Dim m_DIL As Single         '        dilatancy factor
        Dim m_GAPQ As Single        '        transverse slip/gap
    End Structure

    Structure CGPT_KIN           ' 30/NR:11  Kinematic Constraint
        Dim m_ID As Integer         '        identifier 11
        Dim m_KTL As Integer        '        type +  10000*group-number
        Dim m_KR1 As Integer        '        reference GPT 1
        Dim m_KR2 As Integer        '        reference GPT 2
        Dim m_DX As Single          '        direction of coupling X-axis
        Dim m_DY As Single          '        direction of coupling Y-axis
        Dim m_DZ As Single          '        direction of coupling Z-axis
        Dim m_DD As Single          '        factor of interpolation
        Dim m_FF As Single          '        factor of multiplication
    End Structure

    Structure CGPT_SPC           ' 30/NR:12  Elastic Spring connection (obsoleted)
        Dim m_ID As Integer         '        identifier 12
        Dim m_IRI As Integer        '        direction + 100*sign(group number,direction)
        Dim m_IPC As Integer        '        connecting Spoint
        Dim m_NWL As Integer        '        work law number
        Dim m_CP As Single          ' [1095] spring stiffness z
        Dim m_CQ As Single          ' [1095] transverse stiff.
        Dim m_CM As Single          ' [1098] torsional stiff.
        Dim m_PRE As Single         '        prestress for cp
        Dim m_GAP As Single         '        slip of spring
        Dim m_RISS As Single        '        max tension force
        Dim m_FLIE As Single        '        yielding load
        Dim m_MUE As Single         '        friction cross
        Dim m_COH As Single         '        cohesion cross
        Dim m_DIL As Single         '        dilatancy factor
    End Structure

    Structure CGPT_DADS          ' 30/NR:998  Ids of items being an anchestor
        Dim m_ID As Integer         '        ident 998
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() As Integer '        ids of all anchestors
    End Structure

    Structure CGLN               ' 31/NR:0  Structural lines
        Dim m_ID As Integer         '        identifier 0
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_PT() As Integer '        Number start & end point
        Dim m_I3 As Integer         '        reserved
        Dim m_IBT As Integer        '        Bitpattern of element properties acc. 39/NR:100 IBT
        Dim m_IBC As Integer        '        Boundary condition acc. 39/NR:100 IBC
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_I_0() As Single '        reserved
        Dim m_HMESH As Single       ' [1001] mesh density along line acc. 39/NR:100 HMESH
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_I_11() As Single '        reserved
        Dim m_PROG As Single        '        progression factor (>0 monoton, <0 symmetric)
        Dim m_I_15 As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Line
    End Structure

    Structure CGLN_REF           ' 31/NR:-  Reference to another Geometry
        Dim m_IGM As Integer        '        negative value of the master geometry
        Dim m_IGS As Integer        '        optional identifier of a secondary axis
        Dim m_SMIN As Single        '        min parameter on referenced axis
        Dim m_SMAX As Single        '        max parameter on referenced axis
    End Structure

    Const GLN_GEO_DEFAULT = 1
    Const GLN_GEO_KLOTOID = 2
    Const GLN_GEO_SPLINE = 3
    Const GLN_GEO_EXSPLI = 4
    Const GLN_GEO_BEZIER = 5
    Const GLN_GEO_NURBS = 6
    Const GLN_GEO_NURBX = 7
    Const GLN_GEO_DATA = 8
    Const GLN_GEO_NORM = 9
    Const GLN_GEO_CIRC = 10
    Const GLN_GEO_DWN_POSY = +2
    Const GLN_GEO_DWN_NEGY = -2
    Const GLN_GEO_DWN_POSZ = +3
    Const GLN_GEO_DWN_NEGZ = -3
    Structure CGLN_GEO           ' 31/NR:??  Geometric properties
        Dim m_ILN As Integer        '        Code of geometry
        Dim m_GPG As Single         ' [1001] geometry parameter 1
        Dim m_GPA As Single         ' [1001] geometry parameter 2
        Dim m_DD As Single          ' [1001] arc length
        Dim m_S1 As Single          '        parameter s on start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ1() As Single ' [1001] Ordinate of start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ1() As Single '        Tangent of start
        Dim m_RG1 As Single         ' [1009] in-plane curvature
        Dim m_RA1 As Single         ' [1009] vertical curvature
        Dim m_S2 As Single          '        parameter s on end
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ2() As Single ' [1001] Ordinate of endpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ2() As Single '        Tangent of endpoint
        Dim m_RG2 As Single         ' [1009] in-plane curvature
        Dim m_RA2 As Single         ' [1009] vertical curvature
    End Structure

    Const GLN_BEAM_IBC_LOCAL = 16384
    Const GLN_BEAM_IBC_NFREE = 32768
    Structure CGLN_BEAM          ' 31/NR:100  Properties of beams (obsoleted)
        Dim m_ID As Integer         '        ident 100
        Dim m_NOG As Integer        '        Element type
        Dim m_NQ As Integer         '        number cross section
        Dim m_NP As Integer         '        number bedding props
        Dim m_IBC As Integer        '        Hinge code
        Dim m_DIV As Integer        '        prescribed subdivision no of segments
        Dim m_EYA As Single         ' [1001] eccentricity at start
        Dim m_EZA As Single         ' [1001] eccentricity at start
        Dim m_EYE As Single         ' [1001] eccentricity at end
        Dim m_EZE As Single         ' [1001] eccentricity at end
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
        Dim m_CM As Single          ' [1099] torsional bedding
        Dim m_CX As Single          ' [1096] global X  bedding
        Dim m_CY As Single          ' [1096] global Y  bedding
        Dim m_CZ As Single          ' [1096] global Z  bedding
        Dim m_CXX As Single         ' [1099] global X  tors.bed.
        Dim m_CYY As Single         ' [1099] global Y  tors.bed.
        Dim m_CZZ As Single         ' [1099] global Z  tors.bed.
    End Structure

    Structure CGLN_ELNR          ' 31/NR:121  Elements generated on lines
        Dim m_ID As Integer         '        identifier = 121
        Dim m_ETYP As Integer       '        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
        Dim m_IBIT As Integer       '        Bit-code
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=253)> Dim m_NR() As Integer '        packed list of element numbers
    End Structure

    Structure CGLN_DADS          ' 31/NR:998  Ids of items being an anchestor
        Dim m_ID As Integer         '        ident 998
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() As Integer '        ids of all anchestors
    End Structure

    Const GAR_IBC_REF = 32768
    Structure CGAR               ' 32/NR:0  Structural area
        Dim m_ID As Integer         '        identification of general data (0)
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_NOR As Integer        '        number of reinforc.
        Dim m_ITP As Integer        '        Bitpattern for element generation QUAD
        Dim m_IBC As Integer        '        Boundary condition
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TD() As Single ' [1010] Constant thickness
        Dim m_CB As Single          '        bedding factor
        Dim m_CQ As Single          '        tangential bedding factor
        Dim m_TROT As Single        '        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of surface
    End Structure

    Structure CGAR_REF           ' 32/NR:-  Reference to another Geometry
        Dim m_IGM As Integer        '        negative value of the master geometry
    End Structure

    Structure CGAR_BOUN          ' 32/NR:1  Outer Boundary of Area
        Dim m_ID As Integer         '        identification
        Dim m_NG As Integer         '        edgeno     (31/NG)
        Dim m_NA As Integer         '        startpoint (30/NA)
        Dim m_NB As Integer         '        endpoint   (30/NB)
        Dim m_NM As Integer         '        midpoint   (30/NM)
        Dim m_IFC As Integer        '        Interface hinge bit pattern
        Dim m_T As Single           ' [1010] Plate thickness of edge
        Dim m_DFIX As Single        ' [1001] Distance (offset) of region to edge
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
        Dim m_CM As Single          ' [1099] torsional bedding
    End Structure

    Structure CGAR_HOLE          ' 32/NR:2  Inner Boundary of Area
        Dim m_ID As Integer         '        identification
        Dim m_NG As Integer         '        edgeno     (31/NG)
        Dim m_NA As Integer         '        startpoint (30/NA)
        Dim m_NB As Integer         '        endpoint   (30/NB)
        Dim m_NM As Integer         '        midpoint   (30/NM)
        Dim m_IFC As Integer        '        Interface hinge bit pattern
        Dim m_T As Single           ' [1010] Plate thickness of edge
        Dim m_DFIX As Single        ' [1001] Distance (offset) of region to edge
        Dim m_CA As Single          ' [1096] axial     bedding
        Dim m_CQ As Single          ' [1096] lateral   bedding
        Dim m_CM As Single          ' [1099] torsional bedding
    End Structure

    Structure CGAR_CON3          ' 32/NR:3  Prescribed Edges/Points
        Dim m_ID As Integer         '        identification
        Dim m_NG As Integer         '        edgenumber (31/NG)
        Dim m_NA As Integer         '        startpoint (30/NA)
        Dim m_NB As Integer         '        endpoint   (30/NB)
        Dim m_NM As Integer         '        midpoint   (30/NM)
        Dim m_MAT As Integer        '        Materialnumber of subregion for ID==4
        Dim m_T As Single           ' [1010] Plate thickness at edge or point
    End Structure

    Structure CGAR_CON4          ' 32/NR:4  Domain-Subdivision-Edges
        Dim m_ID As Integer         '        identification
        Dim m_NG As Integer         '        edgenumber (31/NG)
        Dim m_NA As Integer         '        startpoint (30/NA)
        Dim m_NB As Integer         '        endpoint   (30/NB)
        Dim m_NM As Integer         '        midpoint   (30/NM)
        Dim m_MAT As Integer        '        Materialnumber of subregion for ID==4
        Dim m_T As Single           ' [1010] Plate thickness at edge or point
    End Structure

    Structure CGAR_MESH          ' 32/NR:9  Prescribed Mesh size
        Dim m_ID As Integer         '        identification
        Dim m_NG As Integer         '        number of support macro generating mesh
        Dim m_NA As Integer         '        startedge  (31/NA)
        Dim m_NB As Integer         '        endedge    (31/NB)
        Dim m_I4 As Integer         '        not used
        Dim m_I5 As Integer         '        not used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_HSIZE() As Single ' [1001] requested mesh size
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTA() As Single ' [1001] Coordinates of startpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTE() As Single ' [1001] Coordinates of endpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_PTM() As Single ' [1001] Coordinates of midpoint
    End Structure

    Structure CGAR_GEO           ' 32/NR:10  Geometry of surface
        Dim m_ID As Integer         '        Identification of surface description 10
        Dim m_NG As Integer         '        Type of surface representation
        Dim m_MGRI As Integer       '        number of data/control points in s of mesh
        Dim m_NGRI As Integer       '        number of data/control points in t of mesh
        Dim m_MSPL As Integer       '        degree of B-spline in s direction
        Dim m_NSPL As Integer       '        degree of B-spline in t direction
        Dim m_SX As Single          '        plane  direction sx
        Dim m_SY As Single          '        plane  direction sy
        Dim m_SZ As Single          '        plane  direction sz
        Dim m_TX As Single          '        plane  direction tx
        Dim m_TY As Single          '        plane  direction ty
        Dim m_TZ As Single          '        plane  direction tz
        Dim m_NX As Single          '        normal direction nx
        Dim m_NY As Single          '        normal direction ny
        Dim m_NZ As Single          '        normal direction nz
        Dim m_X As Single           ' [1001] X-ordinate Origin
        Dim m_Y As Single           ' [1001] Y-ordinate Origin
        Dim m_Z As Single           ' [1001] Z-ordinate Origin
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() As Single '        additional Parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BOX() As Single ' [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_XPAR() As Single '        extended parameters
    End Structure

    Structure CGAR_SURF          ' 32/NR:11  UserPointonSurface
        Dim m_ID As Integer         '        Identification of user surface description 11
        Dim m_IT As Integer         '        Type of point
        Dim m_M As Integer          '        Rasterlocation of mesh 0 < m ( mgri )
        Dim m_N As Integer          '        Rasterlocation of mesh 0 < n ( ngri )
        Dim m_N3 As Integer         '        the degree of the Spline becoming effective
        Dim m_N4 As Integer         '        the weight of NURBS control point [-]
        Dim m_X As Single           ' [1001] X-ordinate
        Dim m_Y As Single           ' [1001] Y-ordinate
        Dim m_Z As Single           ' [1001] Z-ordinate
        Dim m_T As Single           ' [1010] Thickness
    End Structure

    Structure CGAR_COON          ' 32/NR:12  COONsPatchInfo
        Dim m_ID As Integer         '        Identification of COONs blending edges 12
        Dim m_IT As Integer         '        Type of blending
        Dim m_IU0 As Integer        '        No of geometry line for u=umin (left)
        Dim m_IU1 As Integer        '        No of geometry line for u=umax (right)
        Dim m_IV0 As Integer        '        No of geometry line for v=vmin (lower)
        Dim m_IV1 As Integer        '        No of geometry line for v=vmax (upper)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_SP() As Single '        Length parameters for the edges iu0,iu1,iv0,iv1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_UV() As Single '        umin,umax,vmin,vmax of the parameter plane
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_CXYZ() As Single '        Coordinates of the corner points C1,C2,C3,C4
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_TINC() As Single '        inclinations for a bicubic patch as vectors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_TWIST() As Single '        Twist of x,y,z-Ordinate at corner C1 (0,0)
    End Structure

    Structure CGAR_ELNR          ' 32/NR:221  Generated elements from area
        Dim m_ID As Integer         '        identifier = 221
        Dim m_ETYP As Integer       '        Type of element {200,...} for {QUAD,...}
        Dim m_ID2 As Integer        '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=253)> Dim m_NR() As Integer '        packed list of element numbers
    End Structure

    Structure CGAR_DADS          ' 32/NR:998  Ids of items being an anchestor
        Dim m_ID As Integer         '        ident 998
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_IDD() As Integer '        ids of all anchestors
    End Structure

    Structure CGVO               ' 33/NR:0  StructuralVolume
        Dim m_ID As Integer         '        identification of general data (0)
        Dim m_NOG As Integer        '        number of group
        Dim m_NOM As Integer        '        number of material
        Dim m_NOR As Integer        '        number of reinforc.
        Dim m_NOT As Integer        '        number of elementtype
        Dim m_IBC As Integer        '        Boundary condition
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Volume
    End Structure

    Structure CGVO_SURF          ' 33/NR:+  Involved Surfaces
        Dim m_ITP As Integer        '        identification of definition
        Dim m_NG As Integer         '        surface    (32/NG)
        Dim m_NR As Integer         '        extrusion or rotation geometry identifier
        Dim m_NREF As Integer       '        optional number of a reference point
        Dim m_NARA As Integer       '        region identifier for start surface
        Dim m_NARE As Integer       '        region identifier for end surface
        Dim m_T As Single           ' [1010] Thickness of interface layer
        Dim m_FAC As Single         '        Scale factor for extrusion
        Dim m_FAC0 As Single        '        Scale factor for start segment
        Dim m_PHI As Single         ' [   5] end rotation angle for extrusion/rotation
        Dim m_PHI0 As Single        ' [   5] start rotation angle for rotation
        Dim m_DPHI As Single        ' [   5] allowable sector angle for rotation
        Dim m_DX As Single          ' [1001] explicit extrusion / rotational axis
        Dim m_DY As Single          ' [1001] explicit extrusion / rotational axis
        Dim m_DZ As Single          ' [1001] explicit extrusion / rotational axis
        Dim m_XREF As Single        ' [1001] explicit reference point
        Dim m_YREF As Single        ' [1001] explicit reference point
        Dim m_ZREF As Single        ' [1001] explicit reference point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TFAC() As Single ' [1010] Factor for thickness extrusion START/END/REF
    End Structure

    Structure CSGRP              ' 37/ID:0  Secondary groups
        Dim m_ID0 As Integer        '        identification of general data (0)
        Dim m_TYP As Integer        '        Bit infos of selected element types
        Dim m_BIT As Integer        '        Bit infos on selections contained in that group
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of sgrp
    End Structure

    Structure CSGRP_BOX          ' 37/ID:1  Selective Basic-Volume
        Dim m_ID As Integer         '        identification of data (1)
        Dim m_TYP As Integer        '        type of property volume
        Dim m_BIT As Integer        '        option
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=21)> Dim m_PAR() As Single ' [1001] PARAMETERS OF BOX par(3,0:6)
    End Structure

    Structure CSGRP_POL          ' 37/ID:2  Selective Polyeder-Volume
        Dim m_ID As Integer         '        identification of data (2)
        Dim m_TYP As Integer        '        number of vertices
        Dim m_BIT As Integer        '        option
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() As Single '        transformation matrix to local coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_EXT() As Single ' [1001] global extension, local extensions min/max
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=189)> Dim m_VERT() As Single ' [1001] vertices in local coordinates r,s,t
    End Structure

    Structure CSGRP_LIS          ' 37/ID:0???  Calculated Selective Element List
        Dim m_ID As Integer         '        identifier of element to be selected (positive)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() As Integer '        element numbers
    End Structure

    Structure CSGRP_ADD          ' 37/ID:1???  Selecting Element List
        Dim m_ID As Integer         '        identifier of element to be selected (positive)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() As Integer '        element numbers
    End Structure

    Structure CSGRP_SUB          ' 37/ID:2???  Excluding Element List
        Dim m_ID As Integer         '        identifier of element to be selected (positive)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_NR() As Integer '        element numbers
    End Structure

    Structure CSGRP_SEL          ' 37/ID:3???  Property-Values
        Dim m_ID As Integer         '        identifier of element to be modified
        Dim m_TYPE As Integer       '        Option to perform
        Dim m_BIT As Integer        '        bit pattern of selected data
        Dim m_ITP As Integer        '        key value for orientation of coordinate system
        Dim m_DIV As Integer        '        key value of subdivision or other extended data
        Dim m_IDQ As Integer        '        key value of cross section or other extended data
        Dim m_IDH As Integer        '        key value of hinge conditions or other extended data
        Dim m_IDX As Integer        '        key value of other extended data
        Dim m_TROT As Single        '        Fractional rotation about
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TAL() As Single '        Vector to be aligned as local axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_RDAT() As Single '        reserved for values not in DATA
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=64)> Dim m_DATA() As Integer '        equivalenced data structure of that
    End Structure

    Structure CGLAR_0            ' 38/NR:0  Load distribution areas Header
        Dim m_ID As Integer         '        Identification 0
        Dim m_NGAR As Integer       '        number of an 32/NGAR area definition
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NGRP() As Integer '        group of area and three active groups
        Dim m_MGRI As Integer       '        prescribed grid subdivision (NGAR=0)
        Dim m_NGRI As Integer       '        prescribed grid subdivision (NGAR=0)
        Dim m_ID32 As Integer       '        access ID of 32/0 to check valid data
        Dim m_ID20 As Integer       '        access ID of 20/0 to check valid data
        Dim m_NNOD As Integer       '        number of nodes            38/NR:1
        Dim m_NQUA As Integer       '        number of quadrilaterals   38/NR:2
        Dim m_NSEG As Integer       '        number of beam sections    38/NR:3
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUMMY() As Integer '        reserved
        Dim m_SGRP As Integer       '        optional secondary group selector id
        Dim m_T As Single           ' [1010] thickness of load area used to catch beams
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_XYZ() As Single ' [1001] ! 4 corner points of area (optional)
    End Structure

    Structure CGLAR_NOD          ' 38/NR:1  Node of load distribution area
        Dim m_ID As Integer         '        Identification 1 (instead of NR)
        Dim m_INR As Integer        '        nodenumber within the region
        Dim m_NFIX As Integer       '        not used
        Dim m_NCOD As Integer       '        not used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_XYZ() As Single ' [1001] coordinates
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() As Single ' [1001] displacements for uniform load -> animator
    End Structure

    Structure CGLAR_QUA          ' 38/NR:2  QUAD of load distribution area
        Dim m_ID As Integer         '        Identification 2 (instead of NR)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer '        nodenumbers of the quad within region
        Dim m_MAT As Integer        '        not used
        Dim m_MRF As Integer        '        not used
        Dim m_NRA As Integer        '        type of element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() As Single '        Parameter of Jacobi Determinant
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() As Single ' [1010] element thickness
        Dim m_CB As Single          '        not used
        Dim m_CQ As Single          '        not used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
    End Structure

    Structure CGLAR_SEG          ' 38/NR:3  BEAM segments within area
        Dim m_ID As Integer         '        Identification 3
        Dim m_NR As Integer         '        number of loaded beam element
        Dim m_X As Single           ' [1001] start point
        Dim m_L As Single           ' [1001] length of segment
    End Structure

    Structure CGLAR_P            ' 38/NR:1?  Load distribution areas  Pointloads
        Dim m_ID As Integer         '        Identification 10:13
        Dim m_INR As Integer        '        nodenumber of 038/NR:1 within region
        Dim m_NODE As Integer       '        nodenumber of a global node
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_P() As Single '        value of load
    End Structure

    Structure CGLAR_L            ' 38/NR:10?  Load distribution areas  Beamloads
        Dim m_ID As Integer         '        Identification 100:103
        Dim m_INR As Integer        '        nodenumber of 038/NR:1 within region
        Dim m_NSEG As Integer       '        number of 038/NR:3 segment
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
        Dim m_MA As Single          '        start value of torque
        Dim m_ME As Single          '        end value of torque
    End Structure

    Structure CTENDAXIS          ' 40/NR:0  Tendon lanes/reference axis data
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_IGSYS As Integer      '        prestress for:
        Dim m_IGINFO As Integer     '        Systeminfo
        Dim m_IGREF As Integer      '        reference to geometry
        Dim m_ICBIT As Integer      '        bit for analysis type
        Dim m_IDS As Integer        '        Enum of secondary axis (1='A' to 26 ='Z')
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation
    End Structure

    Structure CTENDAX_1          ' 40/NR:1  Tendon lane stations
        Dim m_ID0 As Integer        '        identifier 1
        Dim m_IGBIT As Integer      '        station parameter
        Dim m_NRSTAB As Integer     '        internal beam number
        Dim m_ID3 As Integer        '        reserved (value = 0)
        Dim m_XL As Single          '        beam X/L on beam
        Dim m_S As Single           ' [1001] station on reference lane
        Dim m_SG As Single          ' [1001] station of geometry
        Dim m_SF As Single          '        toppoint station
    End Structure

    Structure CTENDSPLI          ' 41/NR:0  Tendon splines
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_NRSPUR As Integer     '        corresponding lane
        Dim m_NRSV As Integer       '        prestress system
        Dim m_IGSYS As Integer      '        prestress for:
        Dim m_INTYP As Integer      '        bit for analysis type
        Dim m_IGREF As Integer      '        reference to      geometry  Rec: 03
        Dim m_IGREFX As Integer     '        reference to exc. geometry  Rec: 03
        Dim m_ID7 As Integer        '        reserved (value = 0)
        Dim m_ID8 As Integer        '        reserved (value = 0)
        Dim m_ID9 As Integer        '        reserved (value = 0)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_STPARM() As Single '        additional data:
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation
    End Structure

    Structure CTENDSP_I          ' 41/NR:??  Input points
        Dim m_ID0 As Integer        '        identifier INTYP see 41/0  (1=ZPUV standard geometry)
        Dim m_IGBIT As Integer      '        station parameter see 40/1
        Dim m_ID2 As Integer        '        reserved (value = 0)
        Dim m_ID3 As Integer        '        reserved (value = 0)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_DATA() As Single '        Input point data
        Dim m_QSP As Integer        '        Selection string - reference to cross section point
        Dim m_VARU As Integer       '        Selection string - axis variable for offset U
        Dim m_VARV As Integer       '        Selection string - axis variable for offset V
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=50)> Dim m_DAT2() As Single '        Additional input point
    End Structure

    Structure CTENDTOPP          ' 43/NR  Tendon toppoints
        Dim m_ID0 As Integer        '        identifier:
        Dim m_NR As Integer         '        corresponding lane
        Dim m_IGREF As Integer      '        reference to      geometry  Rec: 03
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=124)> Dim m_S() As Single ' [1001] stations on toppoints (max. 124)
    End Structure

    Structure CTENDON            ' 44/NR:0  Tendons
        Dim m_ID0 As Integer        '        identifier 0
        Dim m_NRSPUR As Integer     '        corresponding lane
        Dim m_NRSPLI As Integer     '        Spline-No
        Dim m_NRSTRG As Integer     '        tendon no.
        Dim m_IGREF As Integer      '        reference to      geometry  Rec: 03
        Dim m_IGTYP As Integer      '        bit for analysis type
        Dim m_IZ_REF As Integer     '        IGTYP=1024:  Def-No of geometry
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_NIBA() As Integer '        construction stages
        Dim m_NRSV As Integer       '        prestress system
        Dim m_NSP As Integer        '        number of tendons
        Dim m_MATA As Integer       '        material concrete
        Dim m_NVART As Integer      '        type of jacking
        Dim m_NVARTU As Integer     '        output control
        Dim m_NVVOR As Integer      '        prestress input
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NVBIT() As Integer '        jacking bit
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_LFP() As Integer '        prestress loadcases
        Dim m_IGSYS As Integer      '        prestress for:
        Dim m_ID21 As Integer       '        reserved (value = 0)
        Dim m_KAPA As Single        '        KAPA + 100*KAPL + 1000*action
        Dim m_EINL As Single        '        transition length
        Dim m_ETYP As Single        '        force type to EINL
        Dim m_TFAK As Single        '        factor partial p
        Dim m_TLITZ As Single       '        no. of wires
        Dim m_AR As Single          '        crack design area
        Dim m_DZ As Single          '        diameter of tendon
        Dim m_UZ As Single          '        perimeter
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_VALM() As Single '        reserved
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation
    End Structure

    Structure CTENDJACK          ' 44/NR:1  Tendon jacking data
        Dim m_ID0 As Integer        '        identifier 1
        Dim m_ID1 As Integer        '        reserved (value = 0)
        Dim m_ID2 As Integer        '        reserved (value = 0)
        Dim m_ID3 As Integer        '        reserved (value = 0)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ZVSTRG() As Single '        geometry data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=24)> Dim m_ZVFAK() As Single '        stresses and stressing factors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZVVOR() As Single '        direct input of prestress
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZVFREE() As Single '        free prestress
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_ZVAEND() As Single '        local geometry position
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_ZVREIB() As Single '        additional friction data
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_ZVFGRZ() As Single '        limit values of prestress
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_ZVWEG() As Single '        stressing deformation
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation
    End Structure

    Structure CTENDFACT          ' 44/NR:2  Tendon jacking factors
        Dim m_ID0 As Integer        '        identifier 2
        Dim m_IGBIT As Integer      '        station parameter see 40/1
        Dim m_ID2 As Integer        '        reserved (value = 0)
        Dim m_ID3 As Integer        '        reserved (value = 0)
        Dim m_S As Single           ' [1001] station
        Dim m_FAK As Single         '        active stressing factors
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_ZWFAK() As Single '        additional factor data
    End Structure

    Structure CHIST_HED          ' 80/LC:-10?  TimeHistoryTitle
        Dim m_RID As Single         '        Identifier of history type
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=33)> Dim m_TITLE() As Integer '        Designation
    End Structure

    Structure CHIST_PAR          ' 80/LC:-9??  IterationParameters
        Dim m_RID As Single         '        identifier
        Dim m_VAL As Single         '        current value
        Dim m_MIN As Single         '        minimum allowed value
        Dim m_MAX As Single         '        maximum allowed value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_NAME() As Integer '        name of parameter
    End Structure

    Structure CHIST_ITEM         '        History element
        Dim m_NR As Integer
        Dim m_TYP As Integer
    End Structure

    Structure CHIST              ' 80/LC:-  Identification of history elements
        Dim m_RID As Single         '        Identification -100 < RID < 0.
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_ITEM() As CHIST_ITEM '        History element
    End Structure

    Structure CHIST_VAL          ' 80/LC:+  Transient data
        Dim m_TT As Single          '        Time/frequency
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_VB() As Single '        curve values
    End Structure

    Structure CBASE_SUM          ' 87/LC  Base shear values
        Dim m_NR As Integer         '        mode-number
        Dim m_PX As Single          ' [1151] nodal support X
        Dim m_PY As Single          ' [1151] nodal support Y
        Dim m_PZ As Single          ' [1151] nodal support Z
        Dim m_MX As Single          ' [1152] support moment X
        Dim m_MY As Single          ' [1152] support moment Y
        Dim m_MZ As Single          ' [1152] support moment Z
        Dim m_LSAF As Single        ' [  98] modal acceleration
        Dim m_H As Single           ' [1001] height of base shear
    End Structure

    Structure CBEAM              ' 100/00:+  Beams
        Dim m_NR As Integer         '        beam number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        node number start/end
        Dim m_NP As Integer         '        prop number
        Dim m_DL As Single          ' [1001] beamlength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_EX() As Single ' [1001] 
        Dim m_NREF As Integer       '        reference axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SPAR() As Single '        distances along a continuous beam or
        Dim m_BETY As Single
        Dim m_BETZ As Single
        Dim m_LDFY As Single
        Dim m_LDFZ As Single        '        deformation length factor for vz
    End Structure

    Structure CBSCT              ' 140/00:+  External sections
        Dim m_NR As Integer         '        beam number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        node number start/end
        Dim m_NP As Integer         '        prop number
        Dim m_DL As Single          ' [1001] beamlength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_EX() As Single ' [1001] 
        Dim m_NREF As Integer       '        reference axis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SPAR() As Single '        distances along a continuous beam or
        Dim m_BETY As Single
        Dim m_BETZ As Single
        Dim m_LDFY As Single
        Dim m_LDFZ As Single        '        deformation length factor for vz
    End Structure

    Structure CBEAM_SCT          ' 100/00:0  Beams sections
        Dim m_ID As Integer         '        identifier for sections 0
        Dim m_NQ As Integer         '        number cross section
        Dim m_ITYP As Integer       '        Bitcodes
        Dim m_ITP2 As Integer       '        Connection / Hinges for x=0,x=dl
        Dim m_X As Single           ' [1001] sectional abscissa
    End Structure

    Structure CBSCT_SCT          ' 140/00:0  External sections
        Dim m_ID As Integer         '        identifier for sections 0
        Dim m_NQ As Integer         '        number cross section
        Dim m_ITYP As Integer       '        Bitcode I   (identical to 100/0:0)
        Dim m_ITP2 As Integer       '        Bitcode II  (identical to 100/0:0)
        Dim m_X As Single           ' [1001] sectional abscissa
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_T() As Single '        transformation matrix
        Dim m_YMIN As Single        ' [1001] Box of active elements in cut plane
        Dim m_ZMIN As Single        ' [1001] Box of active elements in cut plane
        Dim m_YMAX As Single        ' [1001] Box of active elements in cut plane
        Dim m_ZMAX As Single        ' [1001] Box of active elements in cut plane
        Dim m_XMIN As Single        ' [1001] Box of active elements in cut plane
        Dim m_XMAX As Single        ' [1001] Box of active elements in cut plane
        Dim m_YMINSEL As Single     ' [1001] Max user defined size of Box
        Dim m_ZMINSEL As Single     ' [1001] Max user defined size of Box
        Dim m_YMAXSEL As Single     ' [1001] Max user defined size of Box
        Dim m_ZMAXSEL As Single     ' [1001] Max user defined size of Box
        Dim m_YSC As Single         ' [1001] Coordinate y of shear centre
        Dim m_ZSC As Single         ' [1001] Coordinate z of shear centre
    End Structure

    Structure CBEAM_TRA          ' 100/01  transformation matrix
        Dim m_NR As Integer         '        beamnumber
        Dim m_DL As Single          ' [1001] beamlength
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
    End Structure

    Structure CBEAM_TRS          ' 100/03  Info about dynamic moving beams (TREX)
        Dim m_LF As Integer         '        Loadcase number containing the train
        Dim m_NR As Integer         '        Number of Beam
        Dim m_BPAT As Integer       '        Options for BEAM (see TREX in SOFILOAD)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODA() As Integer '        Node Numbers for Start of beam element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer '        Node Numbers for end of beam element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_XN() As Single ' [1001] x-values of nodes along load train
    End Structure

    Structure CBEAM_TND          ' 100/05  tendons of beams
        Dim m_NR As Integer         '        beamnumber
        Dim m_NRS As Integer        '        tendon number
        Dim m_MNR As Integer        '        material number of tendon + 1000 * material number of cross-sec
        Dim m_IBA1 As Integer       '        construction stage number for placing
        Dim m_IBA2 As Integer       '        construction stage number for grouting
        Dim m_IBA3 As Integer       '        construction stage number for removing
        Dim m_X As Single           ' [1011] x-ordinate
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_ZZ As Single          ' [1101] tensoning force
        Dim m_AZ As Single          ' [1020] tendon area
        Dim m_D As Single           ' [1023] diameter
        Dim m_UZ As Single          ' [1023] effect. periphery
        Dim m_NY As Single          '        inclination DY/DX
        Dim m_NZ As Single          '        inclination DZ/DX
        Dim m_YHR As Single         ' [1011] y-ordinate duct
        Dim m_ZHR As Single         ' [1011] z-ordinate duct
        Dim m_AHR As Single         ' [1020] area of duct
        Dim m_AR As Single          ' [1012] reference area
        Dim m_TEMP As Single        ' [1215] Temperature
        Dim m_REDFAK As Single      '        Reduction factor within transmission length
        Dim m_XSI As Single         '        Relative ordinate within total tendon
    End Structure

    Structure CBSCT_TND          ' 140/05  tendons of external sections
        Dim m_NR As Integer         '        beamnumber
        Dim m_NRS As Integer        '        tendon number
        Dim m_MNR As Integer        '        material number of tendon + 1000 * material number of cross-sec
        Dim m_IBA1 As Integer       '        construction stage number for placing
        Dim m_IBA2 As Integer       '        construction stage number for grouting
        Dim m_IBA3 As Integer       '        construction stage number for removing
        Dim m_X As Single           ' [1011] x-ordinate
        Dim m_Y As Single           ' [1011] y-ordinate
        Dim m_Z As Single           ' [1011] z-ordinate
        Dim m_ZZ As Single          ' [1101] tensoning force
        Dim m_AZ As Single          ' [1020] tendon area
        Dim m_D As Single           ' [1023] diameter
        Dim m_UZ As Single          ' [1023] effect. periphery
        Dim m_NY As Single          '        inclination DY/DX
        Dim m_NZ As Single          '        inclination DZ/DX
        Dim m_YHR As Single         ' [1011] y-ordinate duct
        Dim m_ZHR As Single         ' [1011] z-ordinate duct
        Dim m_AHR As Single         ' [1020] area of duct
        Dim m_AR As Single          ' [1012] reference area
        Dim m_TEMP As Single        ' [1215] Temperature
        Dim m_REDFAK As Single      '        Reduction factor within transmission length
        Dim m_XSI As Single         '        Relative ordinate within total tendon
    End Structure

    Structure CBEAM_SL           ' 101/LC:*  single beam loads
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_X As Single           ' [1001] load point
        Dim m_I_2 As Single         ' [1001] reserved 0.
        Dim m_PA As Single          '        value of load
        Dim m_I_4 As Single         '        reserved 0.
        Dim m_YA As Single          ' [1001] eccentr. local y
        Dim m_ZA As Single          ' [1001] eccentr. local z
    End Structure

    Structure CBEAM_DL           ' 101/LC:*  distributed beam loading on reference
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_X As Single           ' [1001] start point
        Dim m_L As Single           ' [1001] length of load
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
        Dim m_YA As Single          ' [1001] eccentr. local y A
        Dim m_ZA As Single          ' [1001] eccentr. local z A
        Dim m_YE As Single          ' [1001] eccentr. local y E
        Dim m_ZE As Single          ' [1001] eccentr. local z E
        Dim m_DYA As Single         '        gradient of eccentricity, local y, start
        Dim m_DZA As Single         '        gradient of eccentricity, local z, start
        Dim m_DYE As Single         '        gradient of eccentricity, local y, end
        Dim m_DZE As Single         '        gradient of eccentricity, local z, end
    End Structure

    Structure CBEAM_TL           ' 101/LC:*  distributed beam loading on reference
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_X As Single           ' [1001] start point
        Dim m_L As Single           ' [1001] length of load
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
        Dim m_YA As Single          ' [1001] eccentr. local y A
        Dim m_ZA As Single          ' [1001] eccentr. local z A
        Dim m_YE As Single          ' [1001] eccentr. local y E
        Dim m_ZE As Single          ' [1001] eccentr. local z E
        Dim m_DYA As Single         '        gradient of eccentricity, local y, start
        Dim m_DZA As Single         '        gradient of eccentricity, local z, start
        Dim m_DYE As Single         '        gradient of eccentricity, local y, end
        Dim m_DZE As Single         '        gradient of eccentricity, local z, end
    End Structure

    Structure CBEAM_CL           ' 101/LC:*  cubic beamloads
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_X As Single           ' [1001] start point
        Dim m_L As Single           ' [1001] length of load
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
        Dim m_DPA As Single         '        start derivative
        Dim m_DPE As Single         '        end   derivative
    End Structure

    Structure CBEAM_WL           ' 101/LC:*  dynamic wind loads
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_FA As Single          '        Factor cross start
        Dim m_FE As Single          '        Factor cross end
        Dim m_FT As Single          '        Factor frictional
        Dim m_VXA As Single         ' [1201] wind velocity
        Dim m_VYA As Single         ' [1201] wind velocity
        Dim m_VZA As Single         ' [1201] wind velocity
        Dim m_VXE As Single         ' [1201] wind velocity
        Dim m_VYE As Single         ' [1201] wind velocity
        Dim m_VZE As Single         ' [1201] wind velocity
        Dim m_VXAM As Single        ' [1201] mean wind velocity
        Dim m_VYAM As Single        ' [1201] mean wind velocity
        Dim m_VZAM As Single        ' [1201] mean wind velocity
        Dim m_VXEM As Single        ' [1201] mean wind velocity
        Dim m_VYEM As Single        ' [1201] mean wind velocity
        Dim m_VZEM As Single        ' [1201] mean wind velocity
    End Structure

    Structure CTRUS_WL           ' 151/LC:*  dynamic wind loads
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_FA As Single          '        Factor cross start
        Dim m_FE As Single          '        Factor cross end
        Dim m_FT As Single          '        Factor frictional
        Dim m_VXA As Single         ' [1201] wind velocity
        Dim m_VYA As Single         ' [1201] wind velocity
        Dim m_VZA As Single         ' [1201] wind velocity
        Dim m_VXE As Single         ' [1201] wind velocity
        Dim m_VYE As Single         ' [1201] wind velocity
        Dim m_VZE As Single         ' [1201] wind velocity
        Dim m_VXAM As Single        ' [1201] mean wind velocity
        Dim m_VYAM As Single        ' [1201] mean wind velocity
        Dim m_VZAM As Single        ' [1201] mean wind velocity
        Dim m_VXEM As Single        ' [1201] mean wind velocity
        Dim m_VYEM As Single        ' [1201] mean wind velocity
        Dim m_VZEM As Single        ' [1201] mean wind velocity
    End Structure

    Structure CCABL_WL           ' 161/LC:*  dynamic wind loads
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_FA As Single          '        Factor cross start
        Dim m_FE As Single          '        Factor cross end
        Dim m_FT As Single          '        Factor frictional
        Dim m_VXA As Single         ' [1201] wind velocity
        Dim m_VYA As Single         ' [1201] wind velocity
        Dim m_VZA As Single         ' [1201] wind velocity
        Dim m_VXE As Single         ' [1201] wind velocity
        Dim m_VYE As Single         ' [1201] wind velocity
        Dim m_VZE As Single         ' [1201] wind velocity
        Dim m_VXAM As Single        ' [1201] mean wind velocity
        Dim m_VYAM As Single        ' [1201] mean wind velocity
        Dim m_VZAM As Single        ' [1201] mean wind velocity
        Dim m_VXEM As Single        ' [1201] mean wind velocity
        Dim m_VYEM As Single        ' [1201] mean wind velocity
        Dim m_VZEM As Single        ' [1201] mean wind velocity
    End Structure

    Structure CBEAM_FOC          ' 102/LC:0  Maximum of Total Beam forces and deformations
        Dim m_ID As Integer         '        identifier 0
        Dim m_X As Single           ' [1001] max. beam length
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsionalmom.
        Dim m_UX As Single          ' [1003] diplacem. local x
        Dim m_UY As Single          ' [1003] diplacem. local y
        Dim m_UZ As Single          ' [1003] diplacem. local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBEAM_FTC          ' 112/LC:0  Maximum of Beam forces without plate components
        Dim m_ID As Integer         '        identifier 0
        Dim m_X As Single           ' [1001] max. beam length
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsionalmom.
        Dim m_UX As Single          ' [1003] diplacem. local x
        Dim m_UY As Single          ' [1003] diplacem. local y
        Dim m_UZ As Single          ' [1003] diplacem. local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBSCT_FOC          ' 142/LC:0  Maximum of External sections forces
        Dim m_ID As Integer         '        identifier 0
        Dim m_X As Single           ' [1001] max. beam length
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsionalmom.
        Dim m_UX As Single          ' [1003] diplacem. local x
        Dim m_UY As Single          ' [1003] diplacem. local y
        Dim m_UZ As Single          ' [1003] diplacem. local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBEAM_FOR          ' 102/LC:+  Total Beam forces and deformations
        Dim m_NR As Integer         '        beamnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsional moment
        Dim m_UX As Single          ' [1003] diplacement local x
        Dim m_UY As Single          ' [1003] diplacement local y
        Dim m_UZ As Single          ' [1003] diplacement local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBEAM_FTR          ' 112/LC:+  Beam forces without plate components
        Dim m_NR As Integer         '        beamnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsional moment
        Dim m_UX As Single          ' [1003] diplacement local x
        Dim m_UY As Single          ' [1003] diplacement local y
        Dim m_UZ As Single          ' [1003] diplacement local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBSCT_FOR          ' 142/LC:+  External sections forces
        Dim m_NR As Integer         '        beamnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsional moment
        Dim m_UX As Single          ' [1003] diplacement local x
        Dim m_UY As Single          ' [1003] diplacement local y
        Dim m_UZ As Single          ' [1003] diplacement local z
        Dim m_PHIX As Single        ' [1004] rotation local x
        Dim m_PHIY As Single        ' [1004] rotation local y
        Dim m_PHIZ As Single        ' [1004] rotation local z
        Dim m_PHIW As Single        ' [1005] twisting
        Dim m_MT3 As Single         ' [1103] 3rd torsionalmom
        Dim m_PA As Single          ' [1095] axial bedding
        Dim m_PT As Single          ' [1095] transverse bedding
        Dim m_PTY As Single         ' [1095] local y component of transverse bedding
        Dim m_PTZ As Single         ' [1095] local z component of transverse bedding
    End Structure

    Structure CBEAM_FOX          ' 102/0  Total External Beam forces
        Dim m_NQ As Integer         '        section number
        Dim m_NR As Integer         '        beamnumber
        Dim m_X As Single           ' [1001] abscissa
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsion.moment
    End Structure

    Structure CBSCT_FOX          ' 142/0  Total External Beam forces
        Dim m_NQ As Integer         '        section number
        Dim m_NR As Integer         '        beamnumber
        Dim m_X As Single           ' [1001] abscissa
        Dim m_N As Single           ' [1101] normal force
        Dim m_VY As Single          ' [1102] y-shear force
        Dim m_VZ As Single          ' [1102] z-shear force
        Dim m_MT As Single          ' [1103] torsional moment
        Dim m_MY As Single          ' [1104] bending moment My
        Dim m_MZ As Single          ' [1104] bending moment Mz
        Dim m_MB As Single          ' [1105] warping moment Mb
        Dim m_MT2 As Single         ' [1103] 2nd torsion.moment
    End Structure

    Structure CBEAM_STI          ' 103/LC  Stiffness of beams
        Dim m_NR As Integer         '        beam number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_EA As Single          ' [  62] normal stiffness
        Dim m_GAY As Single         ' [  62] y-shear stiffness
        Dim m_GAZ As Single         ' [  62] z-shear stiffness
        Dim m_GIT As Single         ' [  83] torsional stiffness
        Dim m_EIY As Single         ' [  83] bending stiffness y
        Dim m_EIZ As Single         ' [  83] bending stiffness z
        Dim m_EIYZ As Single        ' [  83] bending stiffness yz
        Dim m_GAYZ As Single        ' [  62] yz-shear stiffness
        Dim m_KPX As Single         ' [   8] plastic strain x
        Dim m_KPY As Single         ' [  17] plastic curvature y
        Dim m_KPZ As Single         ' [  17] plastic curvature z
        Dim m_EMIN As Single        ' [1081] minimum strain
        Dim m_EMAX As Single        ' [1081] maximum strain
        Dim m_GE1 As Single         ' [1101] Residual of current step (Crisfield)
        Dim m_GE2 As Single         ' [1104] Residual of current step (Crisfield)
        Dim m_GE3 As Single         ' [1104] Residual of current step (Crisfield)
        Dim m_EA0 As Single         ' [  83] lin. stiffness EA
        Dim m_EIY0 As Single        ' [  83] lin. stiffness EIy
        Dim m_EIZ0 As Single        ' [  83] lin. stiffness EIz
        Dim m_DYSM As Single        ' [1011] ordinate shear centre to gravity centre
        Dim m_DZSM As Single        ' [1011] ordinate shear centre to gravity centre
        Dim m_PRE As Single         ' [1101] primary axial force
        Dim m_YS As Single          ' [1001] y-eccentricity of centre of gravity
        Dim m_ZS As Single          ' [1001] z-eccentricity of centre of gravity
        Dim m_ECM As Single         '        warping stiffness
        Dim m_GCMS As Single        '        secondary torsion
        Dim m_NI As Single          ' [1101] inner normal force
        Dim m_VYI As Single         ' [1102] inner y-shear force
        Dim m_VZI As Single         ' [1102] inner z-shear force
        Dim m_MTI As Single         ' [1103] inner torsional moment
        Dim m_MYI As Single         ' [1104] inner bending moment My
        Dim m_MZI As Single         ' [1104] inner bending moment Mz
        Dim m_MBI As Single         ' [1105] inner warping moment Mb
        Dim m_E0 As Single          ' [1081] total strain x
        Dim m_GKPY As Single        ' [  17] total curvature y
        Dim m_GKPZ As Single        ' [  17] total curvature z
        Dim m_KFVY As Single        '        plastic factor V-y
        Dim m_KFVZ As Single        '        plastic factor V-z
        Dim m_KFMT As Single        '        plastic factor M-t
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_0() As Single '        Crisfield increments of current step di
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_1() As Single '        Crisfield increments of last step di-1
        Dim m_I_54 As Single        '        unused
        Dim m_ERF_MIN As Single     ' [1081] minimum strain reinf.
        Dim m_ERF_MAX As Single     ' [1081] maximum strain reinf.
        Dim m_HC As Single          ' [   8] relative compressive zone height
        Dim m_CCW As Single         ' [1026] current crack opening
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)> Dim m_I_59() As Single '        unused
    End Structure

    Structure CBSCT_STI          ' 143/LC  Stiffness of beams
        Dim m_NR As Integer         '        beam number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_EA As Single          ' [  62] normal stiffness
        Dim m_GAY As Single         ' [  62] y-shear stiffness
        Dim m_GAZ As Single         ' [  62] z-shear stiffness
        Dim m_GIT As Single         ' [  83] torsional stiffness
        Dim m_EIY As Single         ' [  83] bending stiffness y
        Dim m_EIZ As Single         ' [  83] bending stiffness z
        Dim m_EIYZ As Single        ' [  83] bending stiffness yz
        Dim m_GAYZ As Single        ' [  62] yz-shear stiffness
        Dim m_KPX As Single         ' [   8] plastic strain x
        Dim m_KPY As Single         ' [  17] plastic curvature y
        Dim m_KPZ As Single         ' [  17] plastic curvature z
        Dim m_EMIN As Single        ' [1081] minimum strain
        Dim m_EMAX As Single        ' [1081] maximum strain
        Dim m_GE1 As Single         ' [1101] Residual of current step (Crisfield)
        Dim m_GE2 As Single         ' [1104] Residual of current step (Crisfield)
        Dim m_GE3 As Single         ' [1104] Residual of current step (Crisfield)
        Dim m_EA0 As Single         ' [  83] lin. stiffness EA
        Dim m_EIY0 As Single        ' [  83] lin. stiffness EIy
        Dim m_EIZ0 As Single        ' [  83] lin. stiffness EIz
        Dim m_DYSM As Single        ' [1011] ordinate shear centre to gravity centre
        Dim m_DZSM As Single        ' [1011] ordinate shear centre to gravity centre
        Dim m_PRE As Single         ' [1101] primary axial force
        Dim m_YS As Single          ' [1001] y-eccentricity of centre of gravity
        Dim m_ZS As Single          ' [1001] z-eccentricity of centre of gravity
        Dim m_ECM As Single         '        warping stiffness
        Dim m_GCMS As Single        '        secondary torsion
        Dim m_NI As Single          ' [1101] inner normal force
        Dim m_VYI As Single         ' [1102] inner y-shear force
        Dim m_VZI As Single         ' [1102] inner z-shear force
        Dim m_MTI As Single         ' [1103] inner torsional moment
        Dim m_MYI As Single         ' [1104] inner bending moment My
        Dim m_MZI As Single         ' [1104] inner bending moment Mz
        Dim m_MBI As Single         ' [1105] inner warping moment Mb
        Dim m_E0 As Single          ' [1081] total strain x
        Dim m_GKPY As Single        ' [  17] total curvature y
        Dim m_GKPZ As Single        ' [  17] total curvature z
        Dim m_KFVY As Single        '        plastic factor V-y
        Dim m_KFVZ As Single        '        plastic factor V-z
        Dim m_KFMT As Single        '        plastic factor M-t
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_0() As Single '        Crisfield increments of current step di
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_DE_1() As Single '        Crisfield increments of last step di-1
        Dim m_I_54 As Single        '        unused
        Dim m_ERF_MIN As Single     ' [1081] minimum strain reinf.
        Dim m_ERF_MAX As Single     ' [1081] maximum strain reinf.
        Dim m_HC As Single          ' [   8] relative compressive zone height
        Dim m_CCW As Single         ' [1026] current crack opening
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=11)> Dim m_I_59() As Single '        unused
    End Structure

    Structure CBEAM_CRC          ' 104/LC:0  Parameter of creep interval for each material
        Dim m_ID As Integer         '        identifier 0
        Dim m_MNR As Integer        '        materialnumber
        Dim m_I_0 As Single
        Dim m_T As Single           ' [  93] absolute age
        Dim m_PHI As Single         '        creep coefficient
        Dim m_EPS As Single         '        shrinkage
        Dim m_RH As Single          ' [   8] relative moisture
        Dim m_TEMP As Single        ' [   6] temperature
        Dim m_TWA As Single         ' [  93] effective age start
        Dim m_TWE As Single         ' [  93] effective age end
        Dim m_BETH As Single        '        creep coefficient beta-h
        Dim m_TS As Single          ' [  93] start date of drying
    End Structure

    Structure CBSCT_CRC          ' 144/LC:0  Parameter of creep interval for each material
        Dim m_ID As Integer         '        identifier 0
        Dim m_MNR As Integer        '        materialnumber
        Dim m_I_0 As Single
        Dim m_T As Single           ' [  93] absolute age
        Dim m_PHI As Single         '        creep coefficient
        Dim m_EPS As Single         '        shrinkage
        Dim m_RH As Single          ' [   8] relative moisture
        Dim m_TEMP As Single        ' [   6] temperature
        Dim m_TWA As Single         ' [  93] effective age start
        Dim m_TWE As Single         ' [  93] effective age end
        Dim m_BETH As Single        '        creep coefficient beta-h
        Dim m_TS As Single          ' [  93] start date of drying
    End Structure

    Structure CBEAM_CRF          ' 104/LC:+  resulting forces of redistribution
        Dim m_NR As Integer         '        beamnumber
        Dim m_ID As Integer         '        identifier 0
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SDNI As Single        ' [1101] total normal force
        Dim m_SDVY As Single        ' [1102] total y-shear force
        Dim m_SDVZ As Single        ' [1102] total z-shear force
        Dim m_SDMT As Single        ' [1103] total torsion moment
        Dim m_SDMY As Single        ' [1104] total bending moment
        Dim m_SDMZ As Single        ' [1104] total bending moment
        Dim m_SRNI As Single        ' [1101] relat. normal force
        Dim m_SRVY As Single        ' [1102] relat. y-shear force
        Dim m_SRVZ As Single        ' [1102] relat. y-shear force
        Dim m_SRMT As Single        ' [1103] relat. torsionmoment
        Dim m_SRMY As Single        ' [1104] relat. bendingmoment
        Dim m_SRMZ As Single        ' [1104] relat. bendingmoment
    End Structure

    Structure CBSCT_CRF          ' 144/LC:+  resulting forces of redistribution
        Dim m_NR As Integer         '        beamnumber
        Dim m_ID As Integer         '        identifier 0
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SDNI As Single        ' [1101] total normal force
        Dim m_SDVY As Single        ' [1102] total y-shear force
        Dim m_SDVZ As Single        ' [1102] total z-shear force
        Dim m_SDMT As Single        ' [1103] total torsion moment
        Dim m_SDMY As Single        ' [1104] total bending moment
        Dim m_SDMZ As Single        ' [1104] total bending moment
        Dim m_SRNI As Single        ' [1101] relat. normal force
        Dim m_SRVY As Single        ' [1102] relat. y-shear force
        Dim m_SRVZ As Single        ' [1102] relat. y-shear force
        Dim m_SRMT As Single        ' [1103] relat. torsionmoment
        Dim m_SRMY As Single        ' [1104] relat. bendingmoment
        Dim m_SRMZ As Single        ' [1104] relat. bendingmoment
    End Structure

    Structure CBEAM_CRP          ' 104/LC:+  forces on sectional parts per material
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_DNI As Single         ' [1101] impr. normal force
        Dim m_DMYI As Single        ' [1104] impr. bending moment
        Dim m_DMZI As Single        ' [1104] impr. bending moment
        Dim m_NI As Single          ' [1101] total normal force
        Dim m_MYI As Single         ' [1104] total bending moment
        Dim m_MZI As Single         ' [1104] total bending moment
        Dim m_SDNI As Single        ' [1192] stress plane parameter from (DNI:DMZI)
        Dim m_SDMYI As Single       ' [1193] stress plane parameter from (DNI:DMZI)
        Dim m_SDMZI As Single       ' [1193] stress plane parameter from (DNI:DMZI)
        Dim m_SNI As Single         ' [1192] stress plane parameter from (NI:MZI)
        Dim m_SMYI As Single        ' [1193] stress plane parameter from (NI:MZI)
        Dim m_SMZI As Single        ' [1193] stress plane parameter from (NI:MZI)
    End Structure

    Structure CBSCT_CRP          ' 144/LC:+  forces on sectional parts per material
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_DNI As Single         ' [1101] impr. normal force
        Dim m_DMYI As Single        ' [1104] impr. bending moment
        Dim m_DMZI As Single        ' [1104] impr. bending moment
        Dim m_NI As Single          ' [1101] total normal force
        Dim m_MYI As Single         ' [1104] total bending moment
        Dim m_MZI As Single         ' [1104] total bending moment
        Dim m_SDNI As Single        ' [1192] stress plane parameter from (DNI:DMZI)
        Dim m_SDMYI As Single       ' [1193] stress plane parameter from (DNI:DMZI)
        Dim m_SDMZI As Single       ' [1193] stress plane parameter from (DNI:DMZI)
        Dim m_SNI As Single         ' [1192] stress plane parameter from (NI:MZI)
        Dim m_SMYI As Single        ' [1193] stress plane parameter from (NI:MZI)
        Dim m_SMZI As Single        ' [1193] stress plane parameter from (NI:MZI)
    End Structure

    Structure CBEAM_CRT          ' 104/LC:+  changes of tensional force
        Dim m_NR As Integer         '        beamnumber
        Dim m_NRS As Integer        '        neg. tendonnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_DZZ As Single         ' [1092] change of stress to prestress
        Dim m_DZR As Single         ' [1092] rel. change of stress to concrete strain
        Dim m_DZ As Single          ' [1091] rel. change of force from mean strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DZFAK() As Single '        ordinates, inclinations to evaluate forces
    End Structure

    Structure CBSCT_CRT          ' 144/LC:+  changes of tensional force
        Dim m_NR As Integer         '        beamnumber
        Dim m_NRS As Integer        '        neg. tendonnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_DZZ As Single         ' [1092] change of stress to prestress
        Dim m_DZR As Single         ' [1092] rel. change of stress to concrete strain
        Dim m_DZ As Single          ' [1091] rel. change of force from mean strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_DZFAK() As Single '        ordinates, inclinations to evaluate forces
    End Structure

    Structure CBEAM_STC          ' 105/LC:0  Maximum stresses in cross-section of beams
        Dim m_NR As Integer         '        Ident 0
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance to start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGV As Single        ' [1092] reference stress
        Dim m_SI As Single          ' [1092] main tension stress
        Dim m_SII As Single         ' [1092] main compress stress
        Dim m_SIGO As Single        ' [1092] uniaxial comp stress
        Dim m_SIGU As Single        ' [1092] uniaxial tens stress
        Dim m_DSIG As Single        ' [1092] sway of normal stress
        Dim m_DTAU As Single        ' [1092] sway of shear stress
        Dim m_SIGW As Single        ' [1092] stress in weldings
        Dim m_VB As Single          ' [1153] Bond force
        Dim m_BUCK As Single        '        buckling intensity
        Dim m_I_14 As Single        '        reserved
        Dim m_SIGCT As Single       '        decompression stress
    End Structure

    Structure CBSCT_STC          ' 145/LC:0  Maximum stresses in cross-section of beams
        Dim m_NR As Integer         '        Ident 0
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance to start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGV As Single        ' [1092] reference stress
        Dim m_SI As Single          ' [1092] main tension stress
        Dim m_SII As Single         ' [1092] main compress stress
        Dim m_SIGO As Single        ' [1092] uniaxial comp stress
        Dim m_SIGU As Single        ' [1092] uniaxial tens stress
        Dim m_DSIG As Single        ' [1092] sway of normal stress
        Dim m_DTAU As Single        ' [1092] sway of shear stress
        Dim m_SIGW As Single        ' [1092] stress in weldings
        Dim m_VB As Single          ' [1153] Bond force
        Dim m_BUCK As Single        '        buckling intensity
        Dim m_I_14 As Single        '        reserved
        Dim m_SIGCT As Single       '        decompression stress
    End Structure

    Structure CBEAM_STS          ' 105/LC:+  Stresses in reinforcements of beams
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        neg. materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] stress in shear links
        Dim m_SDS As Single         ' [1092] longitudinal stress sway for reinforcements
        Dim m_SDL As Single         ' [1092] stress sway for shear links reinforcements
        Dim m_SII As Single         ' [1092] reserved
    End Structure

    Structure CBSCT_STS          ' 145/LC:+  Stresses in reinforcements of beams
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        neg. materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] stress in shear links
        Dim m_SDS As Single         ' [1092] longitudinal stress sway for reinforcements
        Dim m_SDL As Single         ' [1092] stress sway for shear links reinforcements
        Dim m_SII As Single         ' [1092] reserved
    End Structure

    Structure CBEAM_STR          ' 105/LC:+  Stresses in cross-section of beams
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGV As Single        ' [1092] reference stress
        Dim m_SI As Single          ' [1092] main tension stress
        Dim m_SII As Single         ' [1092] main compress stress
        Dim m_SIGO As Single        ' [1092] uniaxial stress up
        Dim m_SIGU As Single        ' [1092] uniaxial stress down
        Dim m_DSIG As Single        ' [1092] sway of normal stress
        Dim m_DTAU As Single        ' [1092] sway of shear stress
        Dim m_SIGW As Single        ' [1092] stress in weldings
        Dim m_VB As Single          ' [1153] Bond force
        Dim m_BUCK As Single        '        buckling effects
        Dim m_I_14 As Single        '        reserved
        Dim m_SIGCT As Single       '        decompression stress
        Dim m_RCTRL As Single       '        control value of stress/strain description
        Dim m_ES0 As Single         '        strain in center of total section
        Dim m_ESY As Single         '        strain gradient in y-direction
        Dim m_ESZ As Single         '        strain gradient in z-direction
        Dim m_YC As Single          ' [1011] location of center of partial section
        Dim m_ZC As Single          ' [1011] location of center of partial section
        Dim m_ESW As Single         '        factor for unit warping
        Dim m_VYF As Single         ' [1102] shear force
        Dim m_VZF As Single         ' [1102] shear force
        Dim m_MTF As Single         ' [1103] primary torsional moment
        Dim m_MT2F As Single        ' [1103] secondary torsional moment
    End Structure

    Structure CBSCT_STR          ' 145/LC:+  Stresses in cross-section of beams
        Dim m_NR As Integer         '        beamnumber
        Dim m_MNR As Integer        '        materialnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_SIGC As Single        ' [1092] compressive stress
        Dim m_SIGT As Single        ' [1092] tensile stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGV As Single        ' [1092] reference stress
        Dim m_SI As Single          ' [1092] main tension stress
        Dim m_SII As Single         ' [1092] main compress stress
        Dim m_SIGO As Single        ' [1092] uniaxial stress up
        Dim m_SIGU As Single        ' [1092] uniaxial stress down
        Dim m_DSIG As Single        ' [1092] sway of normal stress
        Dim m_DTAU As Single        ' [1092] sway of shear stress
        Dim m_SIGW As Single        ' [1092] stress in weldings
        Dim m_VB As Single          ' [1153] Bond force
        Dim m_BUCK As Single        '        buckling effects
        Dim m_I_14 As Single        '        reserved
        Dim m_SIGCT As Single       '        decompression stress
        Dim m_RCTRL As Single       '        control value of stress/strain description
        Dim m_ES0 As Single         '        strain in center of total section
        Dim m_ESY As Single         '        strain gradient in y-direction
        Dim m_ESZ As Single         '        strain gradient in z-direction
        Dim m_YC As Single          ' [1011] location of center of partial section
        Dim m_ZC As Single          ' [1011] location of center of partial section
        Dim m_ESW As Single         '        factor for unit warping
        Dim m_VYF As Single         ' [1102] shear force
        Dim m_VZF As Single         ' [1102] shear force
        Dim m_MTF As Single         ' [1103] primary torsional moment
        Dim m_MT2F As Single        ' [1103] secondary torsional moment
    End Structure

    Structure CBEAM_RF0          ' 106/DC:0  max. values of reinforcement
        Dim m_NR As Integer         '        identifier 0
        Dim m_NVERS As Integer      '        Version number
        Dim m_ASLMAX As Single      ' [1021] maximum longitudinal reinforcement
        Dim m_ASBMAX As Single      ' [1021] maximum of shear link reinforcement
        Dim m_VMMAX As Single       ' [1001] maximum of shift rule offset
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CBSCT_RF0          ' 146/DC:0  max. values of reinforcement
        Dim m_NR As Integer         '        identifier 0
        Dim m_NVERS As Integer      '        Version number
        Dim m_ASLMAX As Single      ' [1021] maximum longitudinal reinforcement
        Dim m_ASBMAX As Single      ' [1021] maximum of shear link reinforcement
        Dim m_VMMAX As Single       ' [1001] maximum of shift rule offset
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CTRUS_RF0          ' 156/DC:0  max. values of reinforcement
        Dim m_NR As Integer         '        identifier 0
        Dim m_NVERS As Integer      '        Version number
        Dim m_ASLMAX As Single      ' [1021] maximum longitudinal reinforcement
        Dim m_ASBMAX As Single      ' [1021] maximum of shear link reinforcement
        Dim m_VMMAX As Single       ' [1001] maximum of shift rule offset
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CCABL_RF0          ' 166/DC:0  max. values of reinforcement
        Dim m_NR As Integer         '        identifier 0
        Dim m_NVERS As Integer      '        Version number
        Dim m_ASLMAX As Single      ' [1021] maximum longitudinal reinforcement
        Dim m_ASBMAX As Single      ' [1021] maximum of shear link reinforcement
        Dim m_VMMAX As Single       ' [1001] maximum of shift rule offset
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CBEAM_RFI          ' 106/DC:+  info of reinforcement of beam
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        info id = 0
        Dim m_X As Single           ' [1001] distance from start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() As Integer '        infos for longitudinal layers 0:9
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() As Integer '        infos for shear link   layers 1:15
    End Structure

    Structure CBSCT_RFI          ' 146/DC:+  info of reinforcement of external section
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        info id = 0
        Dim m_X As Single           ' [1001] distance from start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() As Integer '        infos for longitudinal layers 0:9
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() As Integer '        infos for shear link   layers 1:15
    End Structure

    Structure CTRUS_RFI          ' 156/DC:+  info of reinforcement of truss
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        info id = 0
        Dim m_X As Single           ' [1001] distance from start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() As Integer '        infos for longitudinal layers 0:9
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() As Integer '        infos for shear link   layers 1:15
    End Structure

    Structure CCABL_RFI          ' 166/DC:+  info of reinforcement of cables
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        info id = 0
        Dim m_X As Single           ' [1001] distance from start
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim m_ASL() As Integer '        infos for longitudinal layers 0:9
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASV() As Integer '        infos for shear link   layers 1:15
    End Structure

    Structure CBEAM_RFC          ' 106/DC:+  reinforcement of beam
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        section number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_ASUM As Single        ' [1020] Total longitudinal reinforcement
        Dim m_ATOR As Single        ' [1021] maximum of torsional reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() As Single ' [1020] Area of layer 0:9
        Dim m_VM As Single          ' [1001] shift rule offset
        Dim m_ASBMAX As Single      ' [1021] maximum of all shear link areas
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() As Single ' [1021] shear links
    End Structure

    Structure CBSCT_RFC          ' 146/DC:+  reinforcement of external section
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        section number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_ASUM As Single        ' [1020] Total longitudinal reinforcement
        Dim m_ATOR As Single        ' [1021] maximum of torsional reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() As Single ' [1020] Area of layer 0:9
        Dim m_VM As Single          ' [1001] shift rule offset
        Dim m_ASBMAX As Single      ' [1021] maximum of all shear link areas
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() As Single ' [1021] shear links
    End Structure

    Structure CTRUS_RFC          ' 156/DC:+  reinforcement of truss
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        section number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_ASUM As Single        ' [1020] Total longitudinal reinforcement
        Dim m_ATOR As Single        ' [1021] maximum of torsional reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() As Single ' [1020] Area of layer 0:9
        Dim m_VM As Single          ' [1001] shift rule offset
        Dim m_ASBMAX As Single      ' [1021] maximum of all shear link areas
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() As Single ' [1021] shear links
    End Structure

    Structure CCABL_RFC          ' 166/DC:+  reinforcement of cables
        Dim m_NR As Integer         '        beamnumber
        Dim m_NQ As Integer         '        section number
        Dim m_X As Single           ' [1001] distance from start
        Dim m_ASUM As Single        ' [1020] Total longitudinal reinforcement
        Dim m_ATOR As Single        ' [1021] maximum of torsional reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_ASL() As Single ' [1020] Area of layer 0:9
        Dim m_VM As Single          ' [1001] shift rule offset
        Dim m_ASBMAX As Single      ' [1021] maximum of all shear link areas
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_ASB() As Single ' [1021] shear links
    End Structure

    Structure CBEAM_DES          ' 107/LC  Ultimate/Plastic Design results
        Dim m_NR As Integer         '        elementnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_NI As Single          ' [1101] Inner normal force
        Dim m_MYI As Single         ' [1104] bending moment My
        Dim m_MZI As Single         ' [1104] bending moment My
        Dim m_SCF As Single         '        relative capacity
        Dim m_E0 As Single          ' [   9] strain at center
        Dim m_EY As Single          ' [1009] curvature y direct.
        Dim m_EZ As Single          ' [1009] curvature z direct.
        Dim m_E1 As Single          ' [   9] compressive strain
        Dim m_E2 As Single          ' [   9] tensional   strain
        Dim m_HL As Single          ' [1011] lever of forces
        Dim m_HVM As Single         ' [1001] shift rule value
        Dim m_HX As Single          ' [1001] height of compression zone   (NSTR-Analysis)
        Dim m_EDCMIN As Single      ' [   9] minimum decompression strain (NSTR-Analysis)
        Dim m_EDCMAX As Single      ' [   9] maximum decompression strain (NSTR-Analysis)
        Dim m_FCHK As Single        ' [1092] not used
        Dim m_TCF As Single         '        total utilisation level (all effects)
        Dim m_SCN As Single         '        utilisation level  (1) N/Npl
        Dim m_SCVY As Single        '        utilisation level  (2) Vy/Vypl
        Dim m_SCVZ As Single        '        utilisation level  (3) Vz/Vzpl
        Dim m_SCMT As Single        '        utilisation level  (4) Mt/Mtpl
        Dim m_SCMY As Single        '        utilisation level  (5) My/Mypl
        Dim m_SCMZ As Single        '        utilisation level  (6) Mz/Mzpl
        Dim m_SCMB As Single        '        utilisation level  (7) Mb/Mbpl
        Dim m_SCT2 As Single        '        utilisation level  (8) Mt2/Mt2pl
        Dim m_SCCOMB As Single      '        utilisation level  (9) TOTAL INTERACTION
        Dim m_SCBN As Single        '        utilisation level (10) buckling / torsional buckling
        Dim m_CSIGC As Single       '        utilisation level (11) sig-c/fy
        Dim m_CSIGT As Single       '        utilisation level (12) sig-t/fy
        Dim m_CTAU As Single        '        utilisation level (13) tau/tauy
        Dim m_CSGV As Single        '        utilisation level (14) sigv/fy (von Mises)
        Dim m_CSGR As Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
        Dim m_CAS As Single         '        utilisation level (16) As/As-provided (long.Reinforc)
        Dim m_CASL As Single        '        utilisation level (17) Asl/Asl-provided (shear links)
        Dim m_CCW As Single         '        utilisation level (18) As/As-provided for crack width
        Dim m_CSGD As Single        '        utilisation level (19) sig-d (dynamic stress range)
        Dim m_CTAU0 As Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
        Dim m_C2T As Single         '        utilisation level (21) plate slenderness (c/t)
        Dim m_CLASS As Single       '        highest criteria for section class
    End Structure

    Structure CBSCT_DES          ' 147/LC  Ultimate/Plastic Design results
        Dim m_NR As Integer         '        elementnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_NI As Single          ' [1101] Inner normal force
        Dim m_MYI As Single         ' [1104] bending moment My
        Dim m_MZI As Single         ' [1104] bending moment My
        Dim m_SCF As Single         '        relative capacity
        Dim m_E0 As Single          ' [   9] strain at center
        Dim m_EY As Single          ' [1009] curvature y direct.
        Dim m_EZ As Single          ' [1009] curvature z direct.
        Dim m_E1 As Single          ' [   9] compressive strain
        Dim m_E2 As Single          ' [   9] tensional   strain
        Dim m_HL As Single          ' [1011] lever of forces
        Dim m_HVM As Single         ' [1001] shift rule value
        Dim m_HX As Single          ' [1001] height of compression zone   (NSTR-Analysis)
        Dim m_EDCMIN As Single      ' [   9] minimum decompression strain (NSTR-Analysis)
        Dim m_EDCMAX As Single      ' [   9] maximum decompression strain (NSTR-Analysis)
        Dim m_FCHK As Single        ' [1092] not used
        Dim m_TCF As Single         '        total utilisation level (all effects)
        Dim m_SCN As Single         '        utilisation level  (1) N/Npl
        Dim m_SCVY As Single        '        utilisation level  (2) Vy/Vypl
        Dim m_SCVZ As Single        '        utilisation level  (3) Vz/Vzpl
        Dim m_SCMT As Single        '        utilisation level  (4) Mt/Mtpl
        Dim m_SCMY As Single        '        utilisation level  (5) My/Mypl
        Dim m_SCMZ As Single        '        utilisation level  (6) Mz/Mzpl
        Dim m_SCMB As Single        '        utilisation level  (7) Mb/Mbpl
        Dim m_SCT2 As Single        '        utilisation level  (8) Mt2/Mt2pl
        Dim m_SCCOMB As Single      '        utilisation level  (9) TOTAL INTERACTION
        Dim m_SCBN As Single        '        utilisation level (10) buckling / torsional buckling
        Dim m_CSIGC As Single       '        utilisation level (11) sig-c/fy
        Dim m_CSIGT As Single       '        utilisation level (12) sig-t/fy
        Dim m_CTAU As Single        '        utilisation level (13) tau/tauy
        Dim m_CSGV As Single        '        utilisation level (14) sigv/fy (von Mises)
        Dim m_CSGR As Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
        Dim m_CAS As Single         '        utilisation level (16) As/As-provided (long.Reinforc)
        Dim m_CASL As Single        '        utilisation level (17) Asl/Asl-provided (shear links)
        Dim m_CCW As Single         '        utilisation level (18) As/As-provided for crack width
        Dim m_CSGD As Single        '        utilisation level (19) sig-d (dynamic stress range)
        Dim m_CTAU0 As Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
        Dim m_C2T As Single         '        utilisation level (21) plate slenderness (c/t)
        Dim m_CLASS As Single       '        highest criteria for section class
    End Structure

    Structure CTRUS_DES          ' 157/LC  Ultimate/Plastic Design results
        Dim m_NR As Integer         '        elementnumber
        Dim m_X As Single           ' [1001] distance from start
        Dim m_NI As Single          ' [1101] Inner normal force
        Dim m_MYI As Single         ' [1104] bending moment My
        Dim m_MZI As Single         ' [1104] bending moment My
        Dim m_SCF As Single         '        relative capacity
        Dim m_E0 As Single          ' [   9] strain at center
        Dim m_EY As Single          ' [1009] curvature y direct.
        Dim m_EZ As Single          ' [1009] curvature z direct.
        Dim m_E1 As Single          ' [   9] compressive strain
        Dim m_E2 As Single          ' [   9] tensional   strain
        Dim m_HL As Single          ' [1011] lever of forces
        Dim m_HVM As Single         ' [1001] shift rule value
        Dim m_HX As Single          ' [1001] height of compression zone   (NSTR-Analysis)
        Dim m_EDCMIN As Single      ' [   9] minimum decompression strain (NSTR-Analysis)
        Dim m_EDCMAX As Single      ' [   9] maximum decompression strain (NSTR-Analysis)
        Dim m_FCHK As Single        ' [1092] not used
        Dim m_TCF As Single         '        total utilisation level (all effects)
        Dim m_SCN As Single         '        utilisation level  (1) N/Npl
        Dim m_SCVY As Single        '        utilisation level  (2) Vy/Vypl
        Dim m_SCVZ As Single        '        utilisation level  (3) Vz/Vzpl
        Dim m_SCMT As Single        '        utilisation level  (4) Mt/Mtpl
        Dim m_SCMY As Single        '        utilisation level  (5) My/Mypl
        Dim m_SCMZ As Single        '        utilisation level  (6) Mz/Mzpl
        Dim m_SCMB As Single        '        utilisation level  (7) Mb/Mbpl
        Dim m_SCT2 As Single        '        utilisation level  (8) Mt2/Mt2pl
        Dim m_SCCOMB As Single      '        utilisation level  (9) TOTAL INTERACTION
        Dim m_SCBN As Single        '        utilisation level (10) buckling / torsional buckling
        Dim m_CSIGC As Single       '        utilisation level (11) sig-c/fy
        Dim m_CSIGT As Single       '        utilisation level (12) sig-t/fy
        Dim m_CTAU As Single        '        utilisation level (13) tau/tauy
        Dim m_CSGV As Single        '        utilisation level (14) sigv/fy (von Mises)
        Dim m_CSGR As Single        '        utilisation level (15) sig-s (tendon/reinforc.stress)
        Dim m_CAS As Single         '        utilisation level (16) As/As-provided (long.Reinforc)
        Dim m_CASL As Single        '        utilisation level (17) Asl/Asl-provided (shear links)
        Dim m_CCW As Single         '        utilisation level (18) As/As-provided for crack width
        Dim m_CSGD As Single        '        utilisation level (19) sig-d (dynamic stress range)
        Dim m_CTAU0 As Single       '        utilisation level (20) tau0  (Nachweisgrenzen)
        Dim m_C2T As Single         '        utilisation level (21) plate slenderness (c/t)
        Dim m_CLASS As Single       '        highest criteria for section class
    End Structure

    Structure CBEAM_PIF          ' 108/LC  reducing factors of stiffness
        Dim m_NR As Integer         '        pilenumber
        Dim m_REDP As Single        '        reducing factor of stiffness
        Dim m_REDA As Single        '        reducing factor of axial bedding
        Dim m_REDQ As Single        '        reducing factor of cross bedding
    End Structure

    Structure CBEAM_HR0          ' 111/LC:0  Maximum of Implicit Hinge Reactions
        Dim m_ID As Integer         '        identifier 0
        Dim m_TYP As Integer        '        type of hinge
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBIT() As Integer '        reserved
        Dim m_X As Single           ' [1001] max. beam length
        Dim m_REAC As Single        '        extremal reaction force/ moment
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_STV() As Single '        extremal values of statevar's
    End Structure

    Structure CBEAM_HRC          ' 111/LC:+  Implicit Hinge Reactions
        Dim m_NR As Integer         '        beamnumber
        Dim m_TYP As Integer        '        type of hinge
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IBIT() As Integer '        reserved
        Dim m_X As Single           ' [1001] hinge location, beam abscissa value
        Dim m_REAC As Single        '        reaction force/ moment
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_STV() As Single '        statevar's
    End Structure

    Structure CBEAM_MP0          ' 132/LC:0  Extremal values of cross-sectional material point reactions
        Dim m_NR As Integer         '        identifier 0
        Dim m_TYPE As Integer       '        type: reinforcement=1, base material point=0
        Dim m_MNO As Integer        '        material number
        Dim m_MRF As Integer        '        material number reinforcement
        Dim m_NPTS As Integer       '        number of base material points
        Dim m_NRF As Integer        '        Anzahl Materialpunkte Bewehrung
        Dim m_X As Single           ' [1001] max. beam length
        Dim m_Y As Single           ' [1011] max. y-ccordinate
        Dim m_Z As Single           ' [1011] max. z-ccordinate
        Dim m_SIGX As Single        ' [1092] axial normal stress
        Dim m_TAUXY As Single       ' [1092] shear stress xy
        Dim m_TAUXZ As Single       ' [1092] shear stress xz
        Dim m_F0 As Single          '        utilization level
        Dim m_KAPAP As Single       ' [   9] equiv. plastic strain
        Dim m_KAPAD As Single       ' [   9] fracturing strain
        Dim m_CCW As Single         ' [1026] current crack opening
        Dim m_TEMP As Single        ' [   6] current temperature
        Dim m_TEMPMAX As Single     ' [   6] maximum temperature in loading history
        Dim m_EPS_S As Single       ' [   9] pure reinforcement strain (without TS strain correction)
        Dim m_EPS_TS As Single      ' [   9] tension stiffening strain correction (accumulated)
        Dim m_DUMMY As Single       '        unused
        Dim m_IZONE As Single       '        performance interval
        Dim m_EPST As Single        ' [   9] axial temperature strain
        Dim m_EPSX As Single        ' [   9] axial total strain (without temperature strain)
        Dim m_A_MPT As Single       ' [1012] associated material point area
        Dim m_FC_TEMP As Single     ' [1092] current compressive strength (temperature dependent)
        Dim m_FT_TEMP As Single     ' [1092] current tensile strength (temperature dependent)
    End Structure

    Structure CBEAM_MPT          ' 132/LC:+  Cross-sectional material point reactions
        Dim m_NR As Integer         '        beam number
        Dim m_TYPE As Integer       '        type: reinforcement=1, base material point=0
        Dim m_MNO As Integer        '        material number
        Dim m_MRF As Integer        '        material number reinforcement
        Dim m_NPTS As Integer       '        number of base material points
        Dim m_NRF As Integer        '        Anzahl Materialpunkte Bewehrung
        Dim m_X As Single           ' [1001] beam abscissa value
        Dim m_Y As Single           ' [1011] cross-sectional y-position
        Dim m_Z As Single           ' [1011] cross-sectional z-position
        Dim m_SIGX As Single        ' [1092] axial normal stress
        Dim m_TAUXY As Single       ' [1092] shear stress xy
        Dim m_TAUXZ As Single       ' [1092] shear stress xz
        Dim m_F0 As Single          '        utilization level
        Dim m_KAPAP As Single       ' [   9] equiv. plastic strain
        Dim m_KAPAD As Single       ' [   9] fracturing strain
        Dim m_CCW As Single         ' [1026] current crack opening
        Dim m_TEMP As Single        ' [   6] current temperature
        Dim m_TEMPMAX As Single     ' [   6] maximum temperature in loading history
        Dim m_EPS_S As Single       ' [   9] pure reinforcement strain (without TS strain correction)
        Dim m_EPS_TS As Single      ' [   9] tension stiffening strain correction (accumulated)
        Dim m_DUMMY As Single       '        unused
        Dim m_IZONE As Single       '        performance interval
        Dim m_EPST As Single        ' [   9] axial temperature strain
        Dim m_EPSX As Single        ' [   9] axial total strain (without temperature strain)
        Dim m_A_MPT As Single       ' [1012] associated material point area
        Dim m_FC_TEMP As Single     ' [1092] current compressive strength (temperature dependent)
        Dim m_FT_TEMP As Single     ' [1092] current tensile strength (temperature dependent)
    End Structure

    Structure CTRUS              ' 150/00  trusselements
        Dim m_NR As Integer         '        truss number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_NRQ As Integer        '        cross-section number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() As Single '        normal direction
        Dim m_DL As Single          ' [1001] length of truss
        Dim m_PRE As Single         ' [1101] prestress
        Dim m_GAP As Single         ' [1003] slip of element
        Dim m_RISS As Single        ' [1101] max tension force
        Dim m_FLIE As Single        ' [1101] yielding load
        Dim m_NREF As Integer       '        reference axis
    End Structure

    Structure CTRUS_LOA          ' 151/LC  Loads on truss elements
        Dim m_NR As Integer         '        truss number
        Dim m_TYP As Integer        '        type of load
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
    End Structure

    Structure CTRUS_RE0          ' 152/LC:0  maximum of results of truss elements
        Dim m_NR As Integer         '        identifier 0
        Dim m_N As Single           ' [1101] normal force
        Dim m_V As Single           ' [1003] axial displacement
    End Structure

    Structure CTRUS_RES          ' 152/LC:+  results of truss elements
        Dim m_NR As Integer         '        truss number
        Dim m_N As Single           ' [1101] normal force
        Dim m_V As Single           ' [1003] axial displacement
        Dim m_LEX As Single         '        nonlinear effect
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_DAMM() As Single '        Damage Parameter
    End Structure

    Structure CTRUS_ST0          ' 155/LC:0  checked truss stresses
        Dim m_NR As Integer         '        ident 0
        Dim m_MAT As Integer        '        Materialnumber
        Dim m_SIG As Single         ' [1092] normal stress
        Dim m_BUCK As Single        '        buckling intensity
    End Structure

    Structure CTRUS_STR          ' 155/LC:+  truss stress (AQB)
        Dim m_NR As Integer         '        trussingnumber
        Dim m_MAT As Integer        '        Materialnumber
        Dim m_SIG As Single         ' [1092] normal stress
        Dim m_BUCK As Single        '        buckling intensity
    End Structure

    Structure CCABL              ' 160/00  cable elements
        Dim m_NR As Integer         '        cable number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_NRQ As Integer        '        cross-section number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() As Single '        normal direction
        Dim m_DL As Single          ' [1001] length of cable
        Dim m_PRE As Single         ' [1101] prestress
        Dim m_GAP As Single         ' [1003] slip of element
        Dim m_RISS As Single        ' [1101] max tension force
        Dim m_FLIE As Single        ' [1101] yielding load
        Dim m_NREF As Integer       '        reference axis
    End Structure

    Structure CCABL_LOA          ' 161/LC  loads on cables
        Dim m_NR As Integer         '        cable number
        Dim m_TYP As Integer        '        type of load
        Dim m_PA As Single          '        start value of load
        Dim m_PE As Single          '        end value of load
    End Structure

    Structure CCABL_RE0          ' 162/LC:0  maximum results of cables
        Dim m_NR As Integer         '        identifier 0
        Dim m_N As Single           ' [1101] normal force
        Dim m_V As Single           ' [1003] axial displacement
        Dim m_VT As Single          ' [1003] maximum suspension of cable across axis
        Dim m_VTX As Single         ' [1003] suspension of cable, global X-component
        Dim m_VTY As Single         ' [1003] suspension of cable, global Y-component
        Dim m_VTZ As Single         ' [1003] suspension of cable, global Z-component
        Dim m_EPS0 As Single        '        maximum induced strain
    End Structure

    Structure CCABL_RES          ' 162/LC:+  results of cables
        Dim m_NR As Integer         '        cablenumber
        Dim m_N As Single           ' [1101] normal force
        Dim m_V As Single           ' [1003] axial displacement
        Dim m_VQ As Single          ' [1003] maximum suspension of cable across axis
        Dim m_VTX As Single         ' [1003] suspension of cable, global X-component
        Dim m_VTY As Single         ' [1003] suspension of cable, global Y-component
        Dim m_VTZ As Single         ' [1003] suspension of cable, global Z-component
        Dim m_EPS0 As Single        '        Total induced strain
        Dim m_N_M As Single         ' [1101] average normal force
        Dim m_F0 As Single          ' [1003] vertical suspension of cable in load direction
        Dim m_L0 As Single          ' [1001] relaxed cable length incl. temp. and prestrain effects
        Dim m_LEX As Single         '        nonlinear effect
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_DAMM() As Single '        Damage Parameter
    End Structure

    Structure CCABL_SLP          ' 163/00  slip cables
        Dim m_NRSL As Integer       '        slip cable number
        Dim m_NRG As Integer        '        group number
        Dim m_NREL As Integer       '        element number
    End Structure

    Structure CCABL_ST0          ' 165/LC:0  checked cable stresses
        Dim m_NR As Integer         '        ident 0
        Dim m_MAT As Integer        '        Materialnumber
        Dim m_SIG As Single         ' [1092] normal stress
    End Structure

    Structure CCABL_STR          ' 165/LC:+  cable stresses (AQB)
        Dim m_NR As Integer         '        trussingnumber
        Dim m_MAT As Integer        '        Materialnumber
        Dim m_SIG As Single         ' [1092] normal stress
    End Structure

    Structure CSPRI              ' 170/00  Spring-elements
        Dim m_NR As Integer         '        springnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        start nodenumber
        Dim m_NRQ As Integer        '        Material/section no
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() As Single '        normal direction
        Dim m_AREF As Single        '        reference area
        Dim m_CP As Single          ' [1095] spring stiffness
        Dim m_CQ As Single          ' [1095] transverse stiff.
        Dim m_CM As Single          ' [1098] torsional stiff.
        Dim m_PRE As Single         '        prestress
        Dim m_GAP As Single         '        slip/gap of spring
        Dim m_RISS As Single        '        max tension force
        Dim m_FLIE As Single        '        yielding load
        Dim m_MUE As Single         '        friction cross
        Dim m_COH As Single         '        cohesion cross
        Dim m_DIL As Single         '        dilatancy factor
        Dim m_GAPQ As Single        '        transverse slip/gap
        Dim m_DP As Single          '        damping constant
        Dim m_DQ As Single          '        damping shear
        Dim m_DM As Single          '        damping moment
        Dim m_EXPP As Single        '        exponent for nonlinear damping dp**expp
        Dim m_EXPQ As Single        '        exponent for nonlinear damping dq**expq
        Dim m_EXPM As Single        '        exponent for nonlinear damping dm**expm
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_TB() As Single '        rotational direction
        Dim m_NREF As Integer       '        additional bit code
    End Structure

    Structure CSPRI_RE0          ' 170/LC:0  maximum of results of spring-elements
        Dim m_ID As Integer         '        identifier
        Dim m_P As Single           ' [1151] maximum spring force
        Dim m_PT As Single          ' [1151] maximum spring transverse force
        Dim m_PTX As Single         ' [1151] maximum global X-shear component
        Dim m_PTY As Single         ' [1151] maximum global Y-shear component
        Dim m_PTZ As Single         ' [1151] maximum global Z-shear component
        Dim m_M As Single           ' [1152] maximum spring moment
        Dim m_V As Single           ' [1003] maximum axial displacement
        Dim m_VT As Single          ' [1003] maximum transverse displacement
        Dim m_VTX As Single         ' [1003] maximum trans displ., global X-component
        Dim m_VTY As Single         ' [1003] maximum trans displ., global Y-component
        Dim m_VTZ As Single         ' [1003] maximum trans displ., global Z-component
        Dim m_PHI As Single         ' [1004] rotation
    End Structure

    Structure CSPRI_RES          ' 170/LC:+  results of spring-elements
        Dim m_NR As Integer         '        springnumber
        Dim m_P As Single           ' [1151] spring force
        Dim m_PT As Single          ' [1151] spring transforce
        Dim m_PTX As Single         ' [1151] global X-shear component
        Dim m_PTY As Single         ' [1151] global Y-shear component
        Dim m_PTZ As Single         ' [1151] global Z-shear component
        Dim m_M As Single           ' [1152] spring moment
        Dim m_V As Single           ' [1003] axial displacement
        Dim m_VT As Single          ' [1003] trans. displacement
        Dim m_VTX As Single         ' [1003] trans. displacement, global X-component
        Dim m_VTY As Single         ' [1003] trans. displacement, global Y-component
        Dim m_VTZ As Single         ' [1003] trans. displacement, global Z-component
        Dim m_PHI As Single         ' [1004] rotation
        Dim m_LEX As Single         '        nonlinear effect
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVP() As Single '        State variable / Damage Parameter for CP
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVM() As Single '        State variable / Damage Parameter for CM
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_STVT() As Single '        State variable / Damage Parameter for CT
    End Structure

    Structure CDAMP              ' 171/00  Damping elements (DYNA)
        Dim m_NR As Integer         '        element number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_I_3 As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_T() As Single '        normal direction
        Dim m_AREF As Single        '        reference area
        Dim m_DP As Single          '        damping constant
        Dim m_DQ As Single          '        damping shear
        Dim m_DM As Single          '        damping moment
        Dim m_EXPP As Single        '        exponent for nonlinear damping dp**expp
        Dim m_EXPQ As Single        '        exponent for nonlinear damping dq**expq
        Dim m_EXPM As Single        '        exponent for nonlinear damping dm**expm
    End Structure

    Structure CMASS              ' 172/00  Persistent Nodal masses
        Dim m_NR As Integer         '        nodenumber
        Dim m_NRG As Integer        '        pseudoelementnumber IGDIV*Groupnr+IREF
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() As Single ' [  52] transversal mass mt-x,mt-y,mt-z
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_MR() As Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_MB() As Single '        warping  mass and higher coefficients
    End Structure

    Structure CMASS_ADD          ' 172/01  non persistent additional nodal masses
        Dim m_NR As Integer         '        nodenumber
        Dim m_NRG As Integer        '        pseudoelementnumber IGDIV*Groupnr+IREF
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() As Single ' [  52] transversal mass mt-x,mt-y,mt-z
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_MR() As Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_MB() As Single '        warping  mass and higher coefficients
    End Structure

    Structure CMASS_EFF          ' 172/LD:Z+  Effective nodal masses
        Dim m_NR As Integer         '        identifier
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MT() As Single ' [  52] transversal mass mt-x,mt-y,mt-z
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_MR() As Single ' [  55] rotatory mass    mr-xx,mr-yy,mr-zz
    End Structure

    Structure CMASS_EFC          ' 172/LD:-  Effective consistent masses
        Dim m_NR As Integer         '        identifier = negative number of nodes
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() As Integer '        node numbers
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=1176)> Dim m_M() As Single '        mass matrix in triangular format
    End Structure

    Const SPRI_WL0_LTYP_STD = 1
    Const SPRI_WL0_LTYP_IHNG = 2
    Const SPRI_WL0_LTYP_PMM = 3
    Const SPRI_WL0_MTYP_PLAS = 1
    Const SPRI_WL0_MTYP_PISO = 2
    Const SPRI_WL0_MTYP_HYPE = 3
    Const SPRI_WL0_MTYP_PKIN = 4
    Structure CSPRI_WL0          ' 173/NR:0  (nonlinear) Spring material
        Dim m_ID As Integer         '        Identification = 0
        Dim m_LTYP As Integer       '        Type of link
        Dim m_MTYP As Integer       '        Type of law
        Dim m_ICAP As Integer       '        capacities from reference-section SNO
        Dim m_IBIT2 As Integer      '        reserved
        Dim m_IHBIT As Integer      '        Bitpattern of defined degrees of freedom for implicit hinges
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=14)> Dim m_RLIM() As Single ' [1105] 
        Dim m_ALPH As Single        '        Interpolation exponent My-Mz (PMM, only)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_PAR() As Single '        further reserved material parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TITLE() As Integer '        Designation
    End Structure

    Const SPRI_WL_ID_CP = 1
    Const SPRI_WL_ID_CQ = 2
    Const SPRI_WL_ID_CM = 3
    Const SPRI_WL_ID_NX = 11
    Const SPRI_WL_ID_VY = 12
    Const SPRI_WL_ID_VZ = 13
    Const SPRI_WL_ID_MT = 14
    Const SPRI_WL_ID_MY = 15
    Const SPRI_WL_ID_MZ = 16
    Const SPRI_WL_ID_MB = 17
    Const SPRI_WL_NTYP_USER = 0
    Const SPRI_WL_NTYP_LIN = 1
    Const SPRI_WL_NTYP_BILIN = 2
    Const SPRI_WL_NTYP_TRILIN = 3
    Const SPRI_WL_NTYP_PLAS = 4
    Structure CSPRI_WL           ' 173/NR:+  Worklaw for nonlinear Springs
        Dim m_ID As Integer         '        Identification
        Dim m_NTYP As Integer       '        Type of law
        Dim m_PLVL As Single        ' [1101] Normal force reference level
        Dim m_EUR As Single         '        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_PAR() As Single '        further reserved material parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_ARB() As Single '        Function values
    End Structure

    Structure CSPRI_MOV          ' 174/00  Moving Springs
        Dim m_NR As Integer         '        spring element number
        Dim m_TYP As Integer        '        searching criteria
        Dim m_FROM As Integer       '        selection for TYP
        Dim m_TO As Integer         '        selection for TYP
        Dim m_INC As Integer        '        selection for TYP
    End Structure

    Structure CS_MATRIX          ' 175/00  General systemmatrices
        Dim m_NR As Integer         '        element number
        Dim m_TYP As Integer        '        element type
        Dim m_NDN As Integer        '        number of degrees of freedom per node
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_NODE() As Integer '        node numbers
        Dim m_PER As Single         ' [  90] period of matrix
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2048)> Dim m_S() As Single '        stiffness matrix
    End Structure

    Structure CBOUN              ' 180/00:+  Boundary elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_NVON As Integer       '        start nodenumber
        Dim m_NBIS As Integer       '        end nodenumber
        Dim m_NDEL As Integer       '        increment
        Dim m_TYP As Integer        '        type of bedding
        Dim m_MESS As Integer       '        direction of addition
        Dim m_CA As Single          '        start constant of bedding
        Dim m_CE As Single          '        end constant of bedding
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DXYZ() As Single '        direction of bedding, X/Y/Z-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of element
    End Structure

    Structure CBOUN_RES          ' 180/LC  results of boundary elements
        Dim m_NR As Integer         '        element number
        Dim m_NK As Integer         '        nodenumber
        Dim m_PX As Single          ' [1153] X-support force
        Dim m_PY As Single          ' [1153] Y-support force
        Dim m_PZ As Single          ' [1153] Z-support force
        Dim m_MN As Single          ' [1154] support moment
    End Structure

    Structure CBOUN_SUM          ' 181/LC  resultant of boundary results
        Dim m_NR As Integer         '        element number
        Dim m_PX As Single          ' [1151] X-support force
        Dim m_PY As Single          ' [1151] X-support force
        Dim m_PZ As Single          ' [1151] X-support force
        Dim m_MN As Single          ' [1152] N-support moment
        Dim m_MX As Single          ' [1152] X-support moment
        Dim m_MY As Single          ' [1152] Y-support moment
        Dim m_MZ As Single          ' [1152] Z-support moment
    End Structure

    Structure CBOUN_LC_LPT       '        node number + load value
        Dim m_N As Integer
        Dim m_P As Single
    End Structure

    Structure CBOUN_LC           ' 183/LC  Info on loading on boundaries
        Dim m_NR As Integer         '        element number
        Dim m_TYP As Integer        '        type of load
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=127)> Dim m_LPT() As CBOUN_LC_LPT '        node number + load value
    End Structure

    Structure CBOUN_LOA          ' 176/LC  loads on edges
        Dim m_NVON As Integer       '        start nodenumber
        Dim m_NBIS As Integer       '        end nodenumber
        Dim m_NDEL As Integer       '        increment
        Dim m_TYP As Integer        '        type of load
        Dim m_MESS As Integer       '        direction of addition
        Dim m_PA As Single          '        start load value
        Dim m_PE As Single          '        end load value
    End Structure

    Structure CSPRI_SUM          ' 187/LC  Sum of forces of support springs
        Dim m_NR As Integer         '        group-number
        Dim m_PX As Single          ' [1151] nodal support X
        Dim m_PY As Single          ' [1151] nodal support Y
        Dim m_PZ As Single          ' [1151] nodal support u
        Dim m_MX As Single          ' [1152] support moment X
        Dim m_MY As Single          ' [1152] support moment Y
        Dim m_MZ As Single          ' [1152] support moment Z
        Dim m_MB As Single          ' [1105] warping moment
    End Structure

    Structure CRSET              ' 188/00:+  Sets of results
        Dim m_ID As Integer         '        number / identifier of result set
        Dim m_NIT As Integer        '        number of items in that result set
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of that set
    End Structure

    Structure CRSET_ITM          ' 188/00:0  Member of result set
        Dim m_ID0 As Integer        '        Identifier = 0
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ID() As Integer '        Short name of member for headdings
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDS() As Integer '        Selector of main structure
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_IDM() As Integer '        Selector of item member
        Dim m_DIM As Integer        '        enum of explicitly selected unit
        Dim m_KWH As Integer        '        main id of result data
        Dim m_POS As Integer        '        position of value in data (starting at zero)
        Dim m_BIT As Integer        '        bit pattern of defined selection data
        Dim m_NR As Integer         '        main number of result data
        Dim m_NG As Integer         '        second number of result data (e.g. group)
        Dim m_ND1 As Integer        '        reserved for additional selection data
        Dim m_ND2 As Integer        '        reserved for additional selection data
        Dim m_ND3 As Integer        '        reserved for additional selection data
        Dim m_X As Single           '        selector for beam abscissae
    End Structure

    Structure CRSET_DAT          ' 188/LC  Result-values for sets of results
        Dim m_ID As Integer         '        identifier of result set
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=255)> Dim m_VAL() As Single '        result values
    End Structure

    Structure CLINK              ' 179/00  link elements
        Dim m_NR As Integer         '        pipenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_NRQ As Integer        '        material-, type- or cross-sectionnumber
        Dim m_DL As Single          ' [1001] length of pipe
        Dim m_A As Single           '        Nominal width or linear loss factor
        Dim m_B As Single           '        Abs. Roughness or quadratic loss factor
        Dim m_C As Single           '        specific storage coefficient
        Dim m_EPS As Single         '        emission coefficient
        Dim m_AREF As Single        ' [1002] reference area of element
    End Structure

    Structure CPIPE              ' 190/00  pipes / armatures
        Dim m_NR As Integer         '        pipenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_NRQ As Integer        '        material-, type- or cross-sectionnumber
        Dim m_DL As Single          ' [1001] length of pipe
        Dim m_A As Single           '        Nominal width or linear loss factor
        Dim m_B As Single           '        Abs. Roughness or quadratic loss factor
        Dim m_C As Single           '        specific storage coefficient
        Dim m_EPS As Single         '        emission coefficient
        Dim m_AREF As Single        ' [1002] reference area of element
    End Structure

    Structure CPIPE_RES          ' 190/LC  results of pipes
        Dim m_NR As Integer         '        pipenumber
        Dim m_HA As Single          ' [1010] start potential
        Dim m_HE As Single          ' [1010] end potential
        Dim m_I As Single           '        gradient
        Dim m_A As Single           ' [1012] flow area
        Dim m_PA As Single          ' [  70] start compression
        Dim m_PE As Single          ' [  70] end compression
        Dim m_Q As Single           ' [1211] flow quantity
        Dim m_V As Single           ' [1212] flow velocity
        Dim m_R As Single           ' [1011] hydraulic radius
        Dim m_K As Single           ' [1016] roughness
        Dim m_RE As Single          '        Reynolds number
        Dim m_FR As Single          '        Froud    number
    End Structure

    Const LEN_CQUAD0 = 27
    Structure CQUAD              ' 200/00  QuadElements
        Dim m_NR As Integer         '        elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_MAT As Integer        '        materialnumber
        Dim m_MRF As Integer        '        material Reinf.
        Dim m_NRA As Integer        '        type of element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() As Single '        Parameter of Jacobi Determinant
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() As Single ' [1010] element thickness
        Dim m_CB As Single          '        bedding factor
        Dim m_CQ As Single          '        tangential bedding factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
        Dim m_IFC1 As Integer       '        identifier of a most adjacent outer boundary
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DFC1() As Single ' [1001] distance of the nodes to the boundary IFC1
        Dim m_IFC2 As Integer       '        identifier of a most adjacent inner boundary
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DFC2() As Single ' [1001] distance of the nodes to the boundary IFC2
    End Structure

    Structure CQUAD_NOH          ' 200/1:0  unified properties of Quad-nodes
        Dim m_ID1 As Integer
        Dim m_ID2 As Integer
        Dim m_NKREC As Integer
        Dim m_MAXNEL As Integer
        Dim m_MAXUGR As Integer
        Dim m_MAXGR As Integer
        Dim m_NQUAD As Integer
        Dim m_MQUAD As Integer      '        Highest Number of Quadelement
    End Structure

    Structure CQUAD_NOM          ' 200/1:-  unified properties of Quad-nodes
        Dim m_NGT As Integer        '        groupselector
        Dim m_NR As Integer         '        nodenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_IEL() As Integer '        connecting elements
    End Structure

    Structure CQUAD_NOD          ' 200/1:*  properties of Quad-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        Dim m_D As Single           ' [1010] minimum thickness of plate on node
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        lokal average coordinate system
    End Structure

    Structure CQUAD_EDH          ' 200/2:0  Edges of Quad-elements
        Dim m_ID1 As Integer
        Dim m_ID2 As Integer
        Dim m_NEDG As Integer
        Dim m_MQUA As Integer       '        max number of quads per edge
    End Structure

    Structure CQUAD_EDG          ' 200/2:+  Edges of Quad-elements
        Dim m_KA As Integer         '        First Node
        Dim m_KE As Integer         '        Last Node
        Dim m_IJMP As Integer       '        bit pattern of jump condition
        Dim m_NQUA As Integer       '        number of quads
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9999)> Dim m_NREL() As Integer '        Number of Quad-elements
    End Structure

    Structure CQUAD_TEN          ' 200/5  tendons of Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_NRS As Integer        '        tendon number
        Dim m_MNR As Integer        '        tendon material
        Dim m_IBA1 As Integer       '        construction stage number for placing
        Dim m_IBA2 As Integer       '        construction stage number for grouting
        Dim m_IBA3 As Integer       '        construction stage number for removing
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_R() As Single '        isoparametric coordinates start/end point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_S() As Single '        isoparametric coordinates start/end point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_Z() As Single ' [1011] eccentricity of the middle area
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_ZZ() As Single ' [1101] tendon force, start- and endpoint
        Dim m_AZ As Single          ' [1020] area of tendon
        Dim m_UZ As Single          ' [1023] effect. periphery
        Dim m_AH As Single          ' [1020] area of duct
        Dim m_AR As Single          ' [1012] relative area
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DY() As Single '        gradient of tendon
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DZ() As Single '        gradient of tendon
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXZ() As Single ' [1011] perpendicular eccentricity of duct to tendon
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_EXY() As Single ' [1011] transverse eccentricity of duct to tendon
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_SREF() As Single '        parameter values along tendon geometry
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_XYZT() As Single ' [1001] Coordinates of tendon start & endpoint
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_XYZH() As Single ' [1001] Coordinates of duct start & endpoint
    End Structure

    Structure CQUAD_RIM          ' 200/6  Prescribed Reinforcements of Quad-elements
        Dim m_NRG As Integer        '        group number
        Dim m_NR As Integer         '        selector number
        Dim m_TYP As Integer        '        Type of Reinforc.
        Dim m_GTYP As Integer       '        Type of grading
        Dim m_IDRA As Integer       '        drawing source type
        Dim m_RIO As Single         ' [   5] direction of upside reinforcement
        Dim m_RIOQ As Single        ' [   5] direction of upside cross reinforcement
        Dim m_RIOI As Single        ' [   5] direction of upside third reinforcement
        Dim m_RIU As Single         ' [   5] direction of downside reinforcement
        Dim m_RIUQ As Single        ' [   5] direction of downside cross reinforcement
        Dim m_RIUI As Single        ' [   5] direction of downside third reinforcement
        Dim m_XREF As Single        ' [1001] Reference point for circular reinforcement
        Dim m_YREF As Single        ' [1001] Reference point for circular reinforcement
        Dim m_ZREF As Single        ' [1001] Reference point for circular reinforcement
        Dim m_HIO As Single         ' [1024] distance of upside reinforcement
        Dim m_HIOQ As Single        ' [1024] distance of upside cross reinforcement
        Dim m_HIOI As Single        ' [1024] distance of upside third reinforcement
        Dim m_HIU As Single         ' [1024] distance of downside reinforcement
        Dim m_HIUQ As Single        ' [1024] distance of downside cross reinforcement
        Dim m_HIUI As Single        ' [1024] distance of downside third reinforcement
        Dim m_DIO As Single         ' [1023] Diameter of upside reinforcement
        Dim m_DIOQ As Single        ' [1023] Diameter of upside cross reinforcement
        Dim m_DIOI As Single        ' [1023] Diameter of upside third reinforcement
        Dim m_DIU As Single         ' [1023] Diameter of downside reinforcement
        Dim m_DIUQ As Single        ' [1023] Diameter of downside cross reinforcement
        Dim m_DIUI As Single        ' [1023] Diameter of downside third reinforcement
        Dim m_DSS As Single         ' [1023] Diameter of stirrup reinforcement
        Dim m_ASO As Single         ' [1021] upside Minimum reinforcement (outside)
        Dim m_ASOQ As Single        ' [1021] upside cross Minimum reinforcement (middle)
        Dim m_ASOI As Single        ' [1021] upside third Minimum reinforcement (inside)
        Dim m_ASU As Single         ' [1021] downside Minimum reinforcement (outside)
        Dim m_ASUQ As Single        ' [1021] downside cross Minimum reinforcement (middle)
        Dim m_ASUI As Single        ' [1021] downside third Minimum reinforcement (inside)
        Dim m_ASS As Single         ' [1022] Min stirrup cm2/m2
        Dim m_AMO As Single         ' [1021] upside Maximum reinforcement (outside)
        Dim m_AMOQ As Single        ' [1021] upside cross Maximum reinforcement (middle)
        Dim m_AMOI As Single        ' [1021] upside third Maximum reinforcement (inside)
        Dim m_AMU As Single         ' [1021] downside Maximum reinforcement (outside)
        Dim m_AMUQ As Single        ' [1021] downside cross Maximum reinforcement (middle)
        Dim m_AMUI As Single        ' [1021] downside third Maximum reinforcement (inside)
        Dim m_AMS As Single         ' [1022] Max stirrup cm2/m2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_WK6() As Single ' [1026] design crack width
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_SIG6() As Single ' [1092] SLS steel stress limit
    End Structure

    Structure CQCUT_0            ' 200/8:0  Header for fabrication areas
        Dim m_NR As Integer         '        identifier = 0
        Dim m_TYP As Integer        '        identifier = 0
        Dim m_NAR As Integer        '        number of areas
        Dim m_X As Single           ' [1001] x-center
        Dim m_Y As Single           ' [1001] y-
        Dim m_AR3D As Single        ' [1002] area in 3D
        Dim m_AR2D As Single        ' [1002] area in 2D
        Dim m_AR_0 As Single        ' [1002] area stressfree
    End Structure

    Structure CQCUT_NEW          ' 200/8:+  New cutting area
        Dim m_NR As Integer         '        areanumber
        Dim m_TYP As Integer        '        identifier = 0
        Dim m_LF As Integer         '        Loadcase
        Dim m_X As Single           ' [1001] x-ordinate
        Dim m_Y As Single           ' [1001] y- center(text)
        Dim m_AR3D As Single        ' [1002] area in 3D
        Dim m_AR2D As Single        ' [1002] area in 2D
        Dim m_AR_0 As Single        ' [1002] area stressfree
    End Structure

    Structure CQCUT_DIR          ' 200/8:+  Material direction
        Dim m_NR As Integer         '        areanumber
        Dim m_TYP As Integer        '        Identification
        Dim m_MNR As Integer        '        material no
        Dim m_ALF As Single         ' [   5] warp direction
        Dim m_EMOD As Single        ' [1090] E Mod warp direction
        Dim m_E90 As Single         ' [1090] Elasticity modulus perpendicular
    End Structure

    Structure CQCUT_OUT          ' 200/8:+  Vertex of geometric boundary
        Dim m_NR As Integer         '        areanumber
        Dim m_TYP As Integer        '        Identification
        Dim m_LINE As Integer       '        linetype
        Dim m_X As Single           ' [1001] x-ordinate
        Dim m_Y As Single           ' [1001] y-ordinate
    End Structure

    Structure CQCUT_IN           ' 200/8:+  Geometry inner lines
        Dim m_NR As Integer         '        areanumber
        Dim m_TYP As Integer        '        Identification
        Dim m_I_2 As Integer
        Dim m_XA As Single          ' [1001] x  startpoint
        Dim m_YA As Single          ' [1001] y  startpoint
        Dim m_XE As Single          ' [1001] x  endpoint
        Dim m_YE As Single          ' [1001] y  endpoint
    End Structure

    Structure CQCUT_WAR          ' 200/8:+  element warp direction
        Dim m_NR As Integer         '        areanumber
        Dim m_TYP As Integer        '        Identification
        Dim m_NREL As Integer       '        orig elem.no
        Dim m_XA As Single          ' [1001] x  startpoint
        Dim m_YA As Single          ' [1001] y  startpoint
        Dim m_XE As Single          ' [1001] x  endpoint
        Dim m_YE As Single          ' [1001] y  endpoint
        Dim m_ALF As Single         ' [   5] warp direction
    End Structure

    Structure CTEXTILE           ' 200/9  definition of cutting lines
        Dim m_IG As Integer         '        group selector
        Dim m_TYP As Integer        '        type of line
        Dim m_XA As Single          ' [1001] line point A
        Dim m_YA As Single          ' [1001] 
        Dim m_ZA As Single          ' [1001] 
        Dim m_XE As Single          ' [1001] line point E
        Dim m_YE As Single          ' [1001] 
        Dim m_ZE As Single          ' [1001] 
        Dim m_NX As Single          ' [1001] projection
        Dim m_NY As Single          ' [1001] 
        Dim m_NZ As Single          ' [1001] 
    End Structure

    Structure CQUAD_P            ' 200/10  Quad-P-elements
        Dim m_NR As Integer         '        elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_MAT As Integer        '        materialnumber
        Dim m_MRF As Integer        '        material Reinf.
        Dim m_NRA As Integer        '        type of element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_EDGE() As Integer '        No of geometric property of edge 1-2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DET() As Single '        Parameter of Jacobi Determinant
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_THICK() As Single ' [1010] element thickness
        Dim m_CB As Single          '        bedding factor
        Dim m_CQ As Single          '        tangential bedding factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_T() As Single '        transformation matrix
    End Structure

    Structure CQUAD_LPT          ' 201/LC:*  Free single loads on Quad-elements
        Dim m_NRG As Integer        '        groupnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_XA As Single          ' [1001] load point
        Dim m_YA As Single          ' [1001] load point
        Dim m_ZA As Single          ' [1001] load point
        Dim m_P As Single           '        load value
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
    End Structure

    Structure CQUAD_LLN          ' 201/LC:*  global line loads of Quad-elements
        Dim m_NRG As Integer        '        groupnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_XA As Single          ' [1001] load reference point
        Dim m_YA As Single          ' [1001] load reference point
        Dim m_ZA As Single          ' [1001] load reference point
        Dim m_DX As Single          ' [1001] difference to 2nd point
        Dim m_DY As Single          ' [1001] difference to 2nd point
        Dim m_DZ As Single          ' [1001] difference to 2nd point
        Dim m_PA As Single          '        load value start point
        Dim m_PB As Single          '        load value end point
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
    End Structure

    Structure CQUAD_LAR          ' 201/LC:*  global area loads of Quad-elements
        Dim m_NRG As Integer        '        groupnumber
        Dim m_TYP As Integer        '        type of load
        Dim m_XA As Single          ' [1001] load reference point
        Dim m_YA As Single          ' [1001] load reference point
        Dim m_ZA As Single          ' [1001] load reference point
        Dim m_DX As Single          ' [1001] difference to 3rd point (diagonal)
        Dim m_DY As Single          ' [1001] difference to 3rd point (diagonal)
        Dim m_DZ As Single          ' [1001] difference to 3rd point (diagonal)
        Dim m_DXS As Single         ' [1001] difference to 2nd point
        Dim m_DYS As Single         ' [1001] difference to 2nd point
        Dim m_DZS As Single         ' [1001] difference to 2nd point
        Dim m_DXT As Single         ' [1001] difference to 4th point
        Dim m_DYT As Single         ' [1001] difference to 4th point
        Dim m_DZT As Single         ' [1001] difference to 4th point
        Dim m_P1 As Single          '        load value
        Dim m_P2 As Single          '        load value
        Dim m_P3 As Single          '        load value
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
    End Structure

    Structure CQUAD_LOA          ' 202/LC  Quad-element loads
        Dim m_VON As Integer        '        start elementnumber
        Dim m_BIS As Integer        '        end elementnumber
        Dim m_DEL As Integer        '        increment
        Dim m_TYP As Integer        '        type of load
        Dim m_LNR As Integer        '        special option value
        Dim m_P As Single           '        load values
        Dim m_DPDX As Single
        Dim m_DPDY As Single
        Dim m_DPDZ As Single
        Dim m_XREF As Single        ' [1001] optional reference point for load value to
        Dim m_YREF As Single        ' [1001] 
        Dim m_ZREF As Single        ' [1001] 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=30)> Dim m_TFUN() As Single '        optional function of load values across the
    End Structure

    Structure CQUAD_LPI          ' 203/LC:*  internal single loads on Quad-elements
        Dim m_NR As Integer         '        element number
        Dim m_TYP As Integer        '        type of load
        Dim m_PRZ As Single         ' [   8] Percentage of load covered with elements
        Dim m_S As Single           '        load point in local coordinates
        Dim m_T As Single           '        load point in local coordinates
        Dim m_P As Single           '        load value
    End Structure

    Structure CQUAD_LLI          ' 203/LC:*  internal line loads of Quad-elements
        Dim m_NR As Integer         '        element number
        Dim m_TYP As Integer        '        type of load
        Dim m_PRZ As Single         ' [   8] 
        Dim m_SA As Single
        Dim m_TA As Single
        Dim m_PA As Single
        Dim m_SB As Single
        Dim m_TB As Single
        Dim m_PB As Single          '        load value end point
    End Structure

    Structure CQUAD_LAI_LPT      '        load points in local coordinates
        Dim m_S As Single
        Dim m_T As Single
        Dim m_P As Single
    End Structure

    Structure CQUAD_LAI          ' 203/LC:*  Free area loads on Quad-elements
        Dim m_NR As Integer         '        element number
        Dim m_TYP As Integer        '        type of load
        Dim m_PRZ As Single         ' [   8] 
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=63)> Dim m_LPT() As CQUAD_LAI_LPT '        load points in local coordinates
    End Structure

    Structure CQUAD_LT           ' 206/NR  Temperature load profiles for QUADs
        Dim m_T As Single           ' [  90] Time value
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=100)> Dim m_TEMP() As Single '        Temperature values
    End Structure

    Structure CQUAD_FOC          ' 210/LC:0  maximum forces of Quad elements
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force
        Dim m_VY As Single          ' [1111] shear force
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        Dim m_HP1 As Single         '        yield function
        Dim m_HP2 As Single         '        volum. hardening
    End Structure

    Structure CQUAD_FOR          ' 210/LC:+  forces of Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force
        Dim m_VY As Single          ' [1111] shear force
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim m_SG() As Single ' [1112] results in GAUSS-points
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() As Single '        yield function
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() As Single '        volum. hardening
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() As Single '        3rd parameter
    End Structure

    Structure CQUAD_NFC          ' 211/LC:0  maximum forces in nodes
        Dim m_NG As Integer         '        ident 0 for maximum (first records)
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force
        Dim m_VY As Single          ' [1111] shear force
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        Dim m_HP1 As Single         '        yield function
    End Structure

    Structure CQUAD_NFO          ' 211/LC:Z+  Nodal Quad forces
        Dim m_NG As Integer         '        groupselector
        Dim m_NR As Integer         '        nodenumber
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force abs
        Dim m_VY As Single          ' [1111] shear force abs
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        Dim m_VX_V As Single        ' [1111] shear force signed
        Dim m_VY_V As Single        ' [1111] shear force signed
        Dim m_FY As Single          '        yield function
    End Structure

    Structure CQUAD_EFC          ' 212/LC:0  maximum error estimates for Quad-elements
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force
        Dim m_VY As Single          ' [1111] shear force
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        Dim m_ERR As Single         '        error in energy
    End Structure

    Structure CQUAD_EFO          ' 212/LC:+  error estimates for Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_MXX As Single         ' [1114] bending moment
        Dim m_MYY As Single         ' [1114] bending moment
        Dim m_MXY As Single         ' [1113] torsion moment
        Dim m_VX As Single          ' [1111] shear force
        Dim m_VY As Single          ' [1111] shear force
        Dim m_NX As Single          ' [1112] membran force
        Dim m_NY As Single          ' [1112] membran force
        Dim m_NXY As Single         ' [1112] membran force
        Dim m_HOPT As Single        ' [1001] optimal mesh size
    End Structure

    Structure CQUAD_BEC          ' 213/LC:0  bedding stresses and results
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_PSE As Single         ' [1155] bedding centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PS() As Single ' [1155] bedding in nodes
        Dim m_PRE As Single         ' [1151] result bedd.force in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PR() As Single ' [1151] result bedd. values in Quad-nodes
        Dim m_PVE As Single         ' [1003] bedding displacememts in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PV() As Single ' [1003] bedding displacements in nodes
        Dim m_PTE As Single         ' [1155] tangential bedding in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PT() As Single ' [1155] tangential bedding in nodes
        Dim m_PTXE As Single        ' [1155] tangential bedding in centre X-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTX() As Single ' [1155] tangential bedding in nodes X-component
        Dim m_PTYE As Single        ' [1155] tangential bedding in centre Y-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTY() As Single ' [1155] tangential bedding in nodes Y-component
        Dim m_PTZE As Single        ' [1155] tangential bedding in centre Z-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTZ() As Single ' [1155] tangential bedding in nodes Z-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RQ() As Single ' [1151] resulting tangential bedding in nodes
    End Structure

    Structure CQUAD_BED          ' 213/LC:+  bedding stresses and results
        Dim m_NR As Integer         '        Quadelementnumber
        Dim m_PSE As Single         ' [1155] bedding centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PS() As Single ' [1155] bedding in nodes
        Dim m_PRE As Single         ' [1151] result bedd.force in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PR() As Single ' [1151] result bedd. values in Quad-nodes
        Dim m_PVE As Single         ' [1003] bedding displacememts in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PV() As Single ' [1003] bedding displacements in nodes
        Dim m_PTE As Single         ' [1155] tangential bedding in centre
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PT() As Single ' [1155] tangential bedding in nodes
        Dim m_PTXE As Single        ' [1155] tangential bedding in centre X-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTX() As Single ' [1155] tangential bedding in nodes X-component
        Dim m_PTYE As Single        ' [1155] tangential bedding in centre Y-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTY() As Single ' [1155] tangential bedding in nodes Y-component
        Dim m_PTZE As Single        ' [1155] tangential bedding in centre Z-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_PTZ() As Single ' [1155] tangential bedding in nodes Z-component
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_RQ() As Single ' [1151] resulting tangential bedding in nodes
    End Structure

    Structure CQUAD_RFX          ' 214/LC  additional information for primary loadcases
        Dim m_NR As Integer         '        Quad-elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_EPS() As Single '        strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim m_RISS() As Single '        directions of crack
    End Structure

    Structure CQUAD_RNC          ' 215/LC:0  nonlinear results of Quad-element
        Dim m_NR As Integer         '        ident 0 for maximum
        Dim m_NMAT As Integer       '        type of material behaviour
        Dim m_ESXO As Single        ' [   9] upside strain
        Dim m_ESYO As Single        ' [   9] upside strain
        Dim m_EXYO As Single        ' [   9] upside strain
        Dim m_ESMO As Single        ' [   9] upside reference strain
        Dim m_ESXU As Single        ' [   9] downside strain
        Dim m_ESYU As Single        ' [   9] downside strain
        Dim m_EXYU As Single        ' [   9] downside strain
        Dim m_ESMU As Single        ' [   9] downside reference strain
        Dim m_SXO As Single         ' [1092] upside stress
        Dim m_SYO As Single         ' [1092] upside stress
        Dim m_SXYO As Single        ' [1092] upside stress
        Dim m_SMO As Single         ' [1092] upside reference stress
        Dim m_SXU As Single         ' [1092] downside stress
        Dim m_SYU As Single         ' [1092] downside stress
        Dim m_SXYU As Single        ' [1092] downside stress
        Dim m_SM_U As Single        ' [1092] downside reference stress
        Dim m_SGVO As Single        ' [1092] upside reference stress incl. shear
        Dim m_SGVU As Single        ' [1092] downside reference stress incl. shear
        Dim m_FY As Single          '        yield function
        Dim m_FDO As Single         ' [1011] steel - upside yield depth
        Dim m_FDU As Single         ' [1011] steel - downside yield depth
        Dim m_I_22 As Single
        Dim m_WR1O As Single        '        concrete - upside direction of crack 1
        Dim m_WR1U As Single        '        concrete - downside direction of crack 1
        Dim m_WR2O As Single        '        concrete - upside direction of crack 2
        Dim m_WR2U As Single        '        concrete - downside direction of crack 2
        Dim m_SGSO As Single        ' [1092] concrete - upside shear stress on crack
        Dim m_SGSU As Single        ' [1092] concrete - downside shear stress on crack
        Dim m_SG1O As Single        ' [1092] concrete - upside steel stress II,dir.1
        Dim m_SG1U As Single        ' [1092] concrete - downside steel stress II,dir.1
        Dim m_SG2O As Single        ' [1092] concrete - upside steel stress II,dir. 2
        Dim m_SG2U As Single        ' [1092] concrete - downside steel stress II,dir.2
        Dim m_W1O As Single         ' [1026] concrete - upside width of crack,direct. 1
        Dim m_W1U As Single         ' [1026] concrete - downside width of crack,dir. 1
        Dim m_W2O As Single         ' [1026] concrete - upside width of crack,direct. 2
        Dim m_W2U As Single         ' [1026] concrete - downside width of crack,dir. 2
        Dim m_BRO As Single         '        concrete -upside direction reinforcement
        Dim m_BRU As Single         '        concrete -downs. direction reinforcement
        Dim m_XD_X As Single        ' [1011] Minimum compression depth in local x axis
        Dim m_XD_Y As Single        ' [1011] Minimum compression depth in local y axis
        Dim m_XD_1 As Single        ' [1011] Minimum compression depth at least pressed uniaxial
        Dim m_XD_2 As Single        ' [1011] Minimum compression depth pressed biaxial
        Dim m_EPSB As Single        ' [   9] Maximum concrete compression strain
        Dim m_EPSC As Single        ' [   9] Minimum averaged reinforcement strain
        Dim m_EPST As Single        ' [   9] Maximum averaged reinforcement strain
        Dim m_SIGC As Single        ' [1092] Maximum concrete compression stress
        Dim m_SIGT As Single        ' [1092] Maximum concrete tension in the concrete layers
        Dim m_EPSR As Single        ' [   9] Maximum reinforcement strain in the crack
    End Structure

    Structure CQUAD_RNO          ' 215/LC:+  nonlinear results of Quad-element
        Dim m_NR As Integer         '        Quad-elementnumber
        Dim m_NMAT As Integer       '        type of material behaviour
        Dim m_ESXO As Single        ' [   9] upside strain
        Dim m_ESYO As Single        ' [   9] upside strain
        Dim m_EXYO As Single        ' [   9] upside strain
        Dim m_ESMO As Single        ' [   9] upside reference strain
        Dim m_ESXU As Single        ' [   9] downside strain
        Dim m_ESYU As Single        ' [   9] downside strain
        Dim m_EXYU As Single        ' [   9] downside strain
        Dim m_ESMU As Single        ' [   9] downside reference strain
        Dim m_SXO As Single         ' [1092] upside stress
        Dim m_SYO As Single         ' [1092] upside stress
        Dim m_SXYO As Single        ' [1092] upside stress
        Dim m_SMO As Single         ' [1092] upside reference stress
        Dim m_SXU As Single         ' [1092] downside stress
        Dim m_SYU As Single         ' [1092] downside stress
        Dim m_SXYU As Single        ' [1092] downside stress
        Dim m_SM_U As Single        ' [1092] downside reference stress
        Dim m_SGVO As Single        ' [1092] upside reference stress incl. shear
        Dim m_SGVU As Single        ' [1092] downside reference stress incl. shear
        Dim m_FY As Single          '        yield function
        Dim m_FDO As Single         ' [1011] steel - upside yield depth
        Dim m_FDU As Single         ' [1011] steel - downside yield depth
        Dim m_I_22 As Single
        Dim m_WR1O As Single        '        concrete - upside direction of crack 1
        Dim m_WR1U As Single        '        concrete - downside direction of crack 1
        Dim m_WR2O As Single        '        concrete - upside direction of crack 2
        Dim m_WR2U As Single        '        concrete - downside direction of crack 2
        Dim m_SGSO As Single        ' [1092] concrete - upside shear stress on crack
        Dim m_SGSU As Single        ' [1092] concrete - downside shear stress on crack
        Dim m_SG1O As Single        ' [1092] concrete - upside steel stress II,dir.1
        Dim m_SG1U As Single        ' [1092] concrete - downside steel stress II,dir.1
        Dim m_SG2O As Single        ' [1092] concrete - upside steel stress II,dir. 2
        Dim m_SG2U As Single        ' [1092] concrete - downside steel stress II,dir.2
        Dim m_W1O As Single         ' [1026] concrete - upside width of crack,direct. 1
        Dim m_W1U As Single         ' [1026] concrete - downside width of crack,dir. 1
        Dim m_W2O As Single         ' [1026] concrete - upside width of crack,direct. 2
        Dim m_W2U As Single         ' [1026] concrete - downside width of crack,dir. 2
        Dim m_BRO As Single         '        concrete -upside direction reinforcement
        Dim m_BRU As Single         '        concrete -downs. direction reinforcement
        Dim m_XD_X As Single        ' [1011] Minimum compression depth in local x axis
        Dim m_XD_Y As Single        ' [1011] Minimum compression depth in local y axis
        Dim m_XD_1 As Single        ' [1011] Minimum compression depth at least pressed uniaxial
        Dim m_XD_2 As Single        ' [1011] Minimum compression depth pressed biaxial
        Dim m_EPSB As Single        ' [   9] Maximum concrete compression strain
        Dim m_EPSC As Single        ' [   9] Minimum averaged reinforcement strain
        Dim m_EPST As Single        ' [   9] Maximum averaged reinforcement strain
        Dim m_SIGC As Single        ' [1092] Maximum concrete compression stress
        Dim m_SIGT As Single        ' [1092] Maximum concrete tension in the concrete layers
        Dim m_EPSR As Single        ' [   9] Maximum reinforcement strain in the crack
    End Structure

    Structure CQUAD_STC          ' 220/LC:0  maximum Quad-stress
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SVXY As Single        ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_HP1 As Single         ' [1092] yield function
        Dim m_HP2 As Single         '        2nd Parameter
        Dim m_HP3 As Single         '        3rd Parameter
        Dim m_HP4 As Single         '        4th Parameter
        Dim m_HP5 As Single         '        5th Parameter
        Dim m_HP6 As Single         '        6th Parameter
    End Structure

    Structure CQUAD_STP_HTYP     '        = state variables for nonlinear material
        Dim m_ID As Integer
        Dim m_IDIM As Integer
        Dim m_MAXVAL As Single
    End Structure

    Structure CQUAD_STP          ' 220/LC:-  Nonlinear QUAD-stress Headder
        Dim m_TYP As Integer        '        enum of nonlinear parameters as in 1/NR:1/???
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_HTYP() As CQUAD_STP_HTYP '        = state variables for nonlinear material
    End Structure

    Structure CBRIC_STP_HTYP     '        = state variables for nonlinear material
        Dim m_ID As Integer
        Dim m_IDIM As Integer
        Dim m_MAXVAL As Single
    End Structure

    Structure CBRIC_STP          ' 310/LC:-  Nonlinear BRIC-stress Headder
        Dim m_TYP As Integer        '        enum of nonlinear parameters as in 1/NR:1/???
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=15)> Dim m_HTYP() As CBRIC_STP_HTYP '        = state variables for nonlinear material
    End Structure

    Structure CQUAD_STR_SG       '        results in GAUSS-points
        Dim m_SIGX As Single        ' [1092] 
        Dim m_SIGY As Single        ' [1092] 
        Dim m_TAU As Single         ' [1092] 
        Dim m_SIGZ As Single        ' [1092] 
    End Structure

    Structure CQUAD_STR          ' 220/LC  stresses of Quad-element
        Dim m_NR As Integer         '        Elementnumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() As CQUAD_STR_SG '        results in GAUSS-points
        Dim m_PVX As Single         ' [1192] volume loading
        Dim m_PVY As Single         ' [1192] volume loading
        Dim m_PVT As Single         ' [   6] temperature loads
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() As Single '        yield function
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() As Single '        2nd parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() As Single '        3rd parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() As Single '        4th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() As Single '        5th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() As Single '        6th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() As Single '        7th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() As Single '        8th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() As Single '        9th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() As Single '        10th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() As Single '        11th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP12() As Single '        12th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP13() As Single '        13th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP14() As Single '        14th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP15() As Single '        15th parameter as specified in headder record
    End Structure

    Structure CQUAD_NSC          ' 221/LC:0  maximum stresses in nodes
        Dim m_NG As Integer         '        ident 0 for maximum (first records)
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SVXY As Single        ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_FY As Single          '        yield function
    End Structure

    Structure CQUAD_NST          ' 221/LC:Z+  stresses in Quad-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_FY As Single          '        yield function
    End Structure

    Structure CQUAD_ESC          ' 222/LC:0  max. errors in nodes
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SVXY As Single        ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_ERR As Single         '        error in energy
    End Structure

    Structure CQUAD_EST          ' 222/LC:+  error estimates of Quad-element stresses
        Dim m_NR As Integer         '        elementnumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_TAU As Single         ' [1092] shear stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_HOPT As Single        ' [1002] optimal mesh size
    End Structure

    Structure CQUAD_RLC          ' 225/LC:0  max Quad-Layer-results
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_MNR As Integer        '        ident 0 for maximum (first records)
        Dim m_XI As Single          '        local-z
        Dim m_SIGX As Single        ' [1092] stress x
        Dim m_SIGY As Single        ' [1092] stress y
        Dim m_TAU As Single         ' [1092] shear stress xy
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TAUX As Single        ' [1092] shear stress vx
        Dim m_TAUY As Single        ' [1092] shear stress vy
        Dim m_HP1 As Single         '        yield function
        Dim m_HP2 As Single         '        volum. hardening
        Dim m_HP3 As Single         '        damage parameter x
        Dim m_HP4 As Single         '        damage parameter y
        Dim m_HP5 As Single         ' [   3] crack direction 1
        Dim m_HP6 As Single         ' [   3] crack direction 2
        Dim m_HP7 As Single         ' [   9] accumulated temperature strain
        Dim m_HP8 As Single         '        internal damage parameter shrinkage
        Dim m_HP9 As Single         ' [   9] accumulated shrinkage strain
        Dim m_HP10 As Single        '        damage parameter xy
        Dim m_HP11 As Single        ' [   9] epsx  strain in stress strain curve
        Dim m_HP12 As Single        ' [   9] epsy  strain in stress strain curve
        Dim m_HP13 As Single        ' [1215] layer temperature in case of fire analysis
    End Structure

    Structure CQUAD_RLA_SG       '        results in GAUSS-points
        Dim m_SIGX As Single        ' [1092] 
        Dim m_SIGY As Single        ' [1092] 
        Dim m_TAU As Single         ' [1092] 
        Dim m_SIGZ As Single        ' [1092] 
        Dim m_TAUX As Single        ' [1092] 
        Dim m_TAUY As Single        ' [1092] 
    End Structure

    Structure CQUAD_RLA          ' 225/LC:+  Layer-stresses of Quads
        Dim m_NR As Integer         '        Elementnumber
        Dim m_MNR As Integer        '        Materialnumber MNR>0
        Dim m_XI As Single          '        local-z
        Dim m_SIGX As Single        ' [1092] stress x
        Dim m_SIGY As Single        ' [1092] stress y
        Dim m_TAU As Single         ' [1092] shear stress xy
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TAUX As Single        ' [1092] shear stress vx
        Dim m_TAUY As Single        ' [1092] shear stress vy
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() As CQUAD_RLA_SG '        results in GAUSS-points
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() As Single '        yield function
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() As Single '        volum. hardening
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() As Single '        damage parameter x
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() As Single '        damage parameter y
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() As Single ' [   3] crack direction 1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() As Single ' [   3] crack direction 2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() As Single ' [   9] accumulated temperature strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() As Single '        internal damage parameter shrinkage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() As Single ' [   9] accumulated shrinkage strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() As Single '        damage parameter xy
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() As Single ' [   9] epsx  strain in stress strain curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP12() As Single ' [   9] epsy  strain in stress strain curve
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP13() As Single ' [1215] layer temperature in case of fire analysis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP14() As Single ' [1215] max. layer temperature in load history
    End Structure

    Structure CQUAD_RLB_SG       '        results in GAUSS-points
        Dim m_SIG1 As Single        ' [1092] 
        Dim m_SIG2 As Single        ' [1092] 
        Dim m_EPS1 As Single
        Dim m_XI1 As Single
        Dim m_XI2 As Single
        Dim m_EPS2 As Single
    End Structure

    Structure CQUAD_RLB          ' 225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
        Dim m_NR As Integer         '        Elementnumber
        Dim m_MNR As Integer        '        MNR=-1 identifier for reinforcement data
        Dim m_XI As Single          '        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
        Dim m_SIG1 As Single        ' [1092] stress in reinforcement 1. layer
        Dim m_SIG2 As Single        ' [1092] stress in reinforcement 2. layer
        Dim m_EPS1 As Single        '        eps strain in stress strain curve 1. layer
        Dim m_XI1 As Single         '        exact xi position 1. layer
        Dim m_XI2 As Single         '        exact xi position 2. layer
        Dim m_EPS2 As Single        '        eps strain in stress strain curve 2. layer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SG() As CQUAD_RLB_SG '        results in GAUSS-points
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP1() As Single '        damage parameter 1. layer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP2() As Single '        damage parameter 2. layer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP3() As Single ' [1092] delta-sigma tension stiff. layer 1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP4() As Single ' [1092] delta-sigma tension stiff. layer 2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP5() As Single '        direction of reinforcement layer 1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP6() As Single '        direction of reinforcement layer 2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP7() As Single ' [   9] accumulated temperature strain
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP8() As Single '        free
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP9() As Single '        free
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP10() As Single ' [1215] layer 1 actual temperature in case of fire analysis
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HP11() As Single ' [1215] layer 2 actual temperature in case of fire analysis
    End Structure

    Structure CQUAD_SEC          ' 229/LC:0  maximum Quad-sectional stress
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] normalstress
        Dim m_SIGY As Single        ' [1092] transverse stress
        Dim m_SIGZ As Single        ' [1092] transverse stress
        Dim m_TAUXY As Single       ' [1092] shear stress
        Dim m_TAUXZ As Single       ' [1092] shear stress
        Dim m_TAUYZ As Single       ' [1092] shear stress
    End Structure

    Structure CQUAD_SEQ          ' 229/LC:-  location of sectional results in master
        Dim m_NR As Integer         '        negative beam number
        Dim m_X As Single           ' [1001] section along beam
    End Structure

    Structure CQUAD_SER          ' 229/LC:+  stresses of sectional Quad-elements
        Dim m_NR As Integer         '        Elementnumber
        Dim m_SIGX As Single        ' [1092] normalstress
        Dim m_SIGY As Single        ' [1092] transverse stress
        Dim m_SIGZ As Single        ' [1092] transverse stress
        Dim m_TAUXY As Single       ' [1092] shear stress
        Dim m_TAUXZ As Single       ' [1092] shear stress
        Dim m_TAUYZ As Single       ' [1092] shear stress
    End Structure

    Structure CQUAD_RTS          ' 230/LC  tendon stresses in two integration points
        Dim m_NR As Integer         '        elementnumber
        Dim m_NRS As Integer        '        tendonnumber
        Dim m_SIGZ As Single        ' [1092] stress increment
        Dim m_ZZ As Single          ' [1101] force in tendon
        Dim m_ZH As Single          ' [1101] duct deduction force
        Dim m_SZG1 As Single        ' [1092] stress in G-point 1
        Dim m_SZG2 As Single        ' [1092] stress in G-point 2
        Dim m_ZZX1 As Single        ' [1101] force tendon+cement1
        Dim m_ZZX2 As Single        ' [1101] force tendon+cement1
        Dim m_ZHG1 As Single        ' [1101] duct deduction G1
        Dim m_ZHG2 As Single        ' [1101] duct deduction G2
        Dim m_ZZG1 As Single        ' [1101] force in tendon G1
        Dim m_ZZG2 As Single        ' [1101] force in tendon G2
        Dim m_AGE As Single         ' [  93] age since prestress
        Dim m_RELZ As Single        '        accumulated relaxation
        Dim m_TZG1 As Single        ' [1215] temperature tendon G1
        Dim m_TZG2 As Single        ' [1215] temperature tendon G2
        Dim m_THG1 As Single        ' [1215] temperature tendon duct G1
        Dim m_THG2 As Single        ' [1215] temperature tendon duct G2
    End Structure

    Structure CQUAD_DST          ' 250/DC  design stresses in Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_SMIO As Single        ' [1092] minimum upside main stress
        Dim m_SMAO As Single        ' [1092] maximum upside main stress
        Dim m_SMIU As Single        ' [1092] minimum downside main stress
        Dim m_SMAU As Single        ' [1092] maximum downside main stress
        Dim m_TAUM As Single        ' [1092] maximum shear stress
        Dim m_SVMA As Single        ' [1092] maximum reference stress
        Dim m_SVO As Single         ' [1092] maximum reference stress upside
        Dim m_SVU As Single         ' [1092] maximum reference stress downside
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CQUAD_NDS          ' 251/DC  design stresses in Quad-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        Dim m_SMIO As Single        ' [1092] minimum upside main stress Minimale Hauptspannung oben
        Dim m_SMAO As Single        ' [1092] maximum upside main stress Maximale Hauptspannung oben
        Dim m_SMIU As Single        ' [1092] minimum downside main stress Minimale Hauptspannung unten
        Dim m_SMAU As Single        ' [1092] maximum downside main stress Maximale Hauptspannung unten
        Dim m_TAUM As Single        ' [1092] maximum shear stress
        Dim m_SVMA As Single        ' [1092] maximum reference stress
        Dim m_SVO As Single         ' [1092] maximum reference stress upside
        Dim m_SVU As Single         ' [1092] maximum reference stress downside
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of designcase
    End Structure

    Structure CQUAD_RIC          ' 260/DC:0  maximum reinforcement in Quad-elements
        Dim m_NR As Integer         '        ident 0
        Dim m_ASO As Single         ' [1021] upside reinforcement (outside)
        Dim m_ASOQ As Single        ' [1021] upside cross reinforcement (middle)
        Dim m_ASU As Single         ' [1021] downside reinforcement (outside)
        Dim m_ASUQ As Single        ' [1021] downside cross reinforcement (middle)
        Dim m_ASOI As Single        ' [1021] upside third reinforcement (inside)
        Dim m_ASUI As Single        ' [1021] downside third reinforcement (inside)
        Dim m_ASS As Single         ' [1022] stirrup cm2/m2
        Dim m_ASSE As Single        ' [1020] stirrup cm2
        Dim m_TAU0 As Single        ' [1092] design shear stress (shear force)
        Dim m_SIXO As Single        ' [1030] upside reinforcement quantity
        Dim m_SIXU As Single        ' [1030] downside reinforcement quantity
        Dim m_SIXS As Single        ' [1030] shear reinforcement quantity
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_FREE0() As Single '        not yet used
        Dim m_ZMIN As Single        ' [1001] minimum lever arm
        Dim m_VEDR As Single        '        max. VED/VRDMAX
        Dim m_COTT As Single        '        max. cot_theta
        Dim m_VED As Single         '        max. VED
        Dim m_FREE As Single        '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() As Single ' [1092] upside stress range (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() As Single ' [1092] downside stress range (inside)
        Dim m_SDV As Single         ' [1092] stirrup stress range
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() As Single ' [1092] maximum stell stress upside (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() As Single ' [1092] maximum stell stress downside(inside)
        Dim m_SSV As Single         ' [1092] maximum stirrup stress (not yet used)
        Dim m_SIGBO As Single       ' [1092] maximum concrete pressure upside (outside)
        Dim m_SIGBU As Single       ' [1092] maximum concrete pressure downside(inside)
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress
        Dim m_SHZX As Single        '        max. skew principal tensile stress in local x
        Dim m_SHZY As Single        '        max. skew principal tensile stress in local y
        Dim m_FREE40 As Single      '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() As Single ' [1021] Info reinforcement bending design only
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() As Single ' [1021] Info reinforcement if increased due to shear
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() As Single ' [1021] Info reinforcement to satisfy shear without stirrups
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() As Single ' [1114] Design bending moment in direction of reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() As Single '        bitpattern of origins of maximum reinforcements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() As Single ' [   9] decompression strain in the direction of tendons
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of designcase
    End Structure

    Structure CQUAD_REI          ' 260/DC:+  reinforcement in Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_ASO As Single         ' [1021] upside reinforcement (outside)
        Dim m_ASOQ As Single        ' [1021] upside cross reinforcement (middle)
        Dim m_ASU As Single         ' [1021] downside reinforcement (outside)
        Dim m_ASUQ As Single        ' [1021] downside cross reinforcement (middle)
        Dim m_ASOI As Single        ' [1021] upside third reinforcement (inside)
        Dim m_ASUI As Single        ' [1021] downside third reinforcement (inside)
        Dim m_ASS As Single         ' [1022] stirrup cm2/m2
        Dim m_ASSE As Single        ' [1020] stirrup cm2
        Dim m_TAU0 As Single        ' [1092] design shear stress (shear force)
        Dim m_RIO As Single         '        direction of upside reinforcement
        Dim m_RIOQ As Single        '        direction of upside cross reinforcement
        Dim m_RIU As Single         '        direction of downside reinforcement
        Dim m_RIUQ As Single        '        direction of downside cross reinforcement
        Dim m_RIOI As Single        '        direction of upside third reinforcement
        Dim m_RIUI As Single        '        direction of downside third reinforcement
        Dim m_ZMIN As Single        ' [1001] minimum lever arm (ULS design)
        Dim m_VEDR As Single        '        max. VED/VRDMAX (ULS design)
        Dim m_COTT As Single        '        max. cot_theta (ULS design)
        Dim m_VED As Single         '        max. VED (ULS design)
        Dim m_VM As Single          ' [1001] shift rule
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() As Single ' [1092] upside stress range (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() As Single ' [1092] downside stress range (inside)
        Dim m_SDV As Single         ' [1092] stirrup stress range
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() As Single ' [1092] maximum stell stress upside (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() As Single ' [1092] maximum stell stress downside(inside)
        Dim m_SSV As Single         ' [1092] maximum stirrup stress (not yet used)
        Dim m_SIGBO As Single       ' [1092] maximum concrete pressure upside (outside)
        Dim m_SIGBU As Single       ' [1092] maximum concrete pressure downside(inside)
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress (SLS uncracked)
        Dim m_SHZX As Single        '        max. skew principal tensile stress in local x
        Dim m_SHZY As Single        '        max. skew principal tensile stress in local y
        Dim m_FREE40 As Single      '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() As Single ' [1021] Info reinforcement bending design only (ULS design)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() As Single ' [1021] Info reinforcement if increased due to shear (ULS design)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() As Single ' [1021] Info reinforcement to satisfy shear without stirrups (ULS)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() As Single ' [1114] Design bending moment in direction of reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() As Single '        origin of maximum reinforcement:
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() As Single ' [   9] decompression strain in the direction of tendons
    End Structure

    Structure CQUAD_NRC          ' 261/DC:0  maximum reinforcement in Quad-nodes
        Dim m_NR As Integer         '        ident 0
        Dim m_NG As Integer         '        ident 0
        Dim m_ASO As Single         ' [1021] upside reinforcement (outside)
        Dim m_ASOQ As Single        ' [1021] upside cross reinforcement (middle)
        Dim m_ASU As Single         ' [1021] downside reinforcement (outside)
        Dim m_ASUQ As Single        ' [1021] downside cross reinforcement (middle)
        Dim m_ASOI As Single        ' [1021] upside third reinforcement (inside)
        Dim m_ASUI As Single        ' [1021] downside third reinforcement (inside)
        Dim m_ASS As Single         ' [1022] stirrup cm2/m2
        Dim m_I_8 As Single         '        reserved 0.0
        Dim m_TAU0 As Single        ' [1092] design shear stress (shear force)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_FREE0() As Single '        not yet used
        Dim m_ZMIN As Single        ' [1001] minimum lever arm
        Dim m_VEDR As Single        '        max. VED/VRDMAX
        Dim m_COTT As Single        '        max. cot_theta
        Dim m_VED As Single         '        max. VED
        Dim m_FREE As Single        '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() As Single ' [1092] upside stress range (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() As Single ' [1092] downside stress range (inside)
        Dim m_SDV As Single         ' [1092] stirrup stress range
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() As Single ' [1092] maximum stell stress upside (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() As Single ' [1092] maximum stell stress downside(inside)
        Dim m_SSV As Single         ' [1092] maximum stirrup stress (not yet used)
        Dim m_SIGBO As Single       ' [1092] maximum concrete pressure upside (outside)
        Dim m_SIGBU As Single       ' [1092] maximum concrete pressure downside(inside)
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress
        Dim m_SHZX As Single        '        max. skew principal tensile stress in local x
        Dim m_SHZY As Single        '        max. skew principal tensile stress in local y
        Dim m_FREE40 As Single      '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() As Single ' [1021] Info reinforcement bending design only
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() As Single ' [1021] Info reinforcement if increased due to shear
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() As Single ' [1021] Info reinforcement to satisfy shear without stirrups
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() As Single ' [1114] Design bending moment in direction of reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() As Single '        bitpattern of origins of maximum reinforcements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() As Single ' [   9] decompression strain in the direction of tendons
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> Dim m_RESERVED() As Single '        reserved for future usage
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        Designation of Designcase
    End Structure

    Structure CQUAD_NRI          ' 261/DC:Z+  reinforcement in Quad-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        Dim m_ASO As Single         ' [1021] upside reinforcement (outside)
        Dim m_ASOQ As Single        ' [1021] upside cross reinforcement (middle)
        Dim m_ASU As Single         ' [1021] downside reinforcement (outside)
        Dim m_ASUQ As Single        ' [1021] downside cross reinforcement (middle)
        Dim m_ASOI As Single        ' [1021] upside third reinforcement (inside)
        Dim m_ASUI As Single        ' [1021] downside third reinforcement (inside)
        Dim m_ASS As Single         ' [1022] stirrup cm2/m2
        Dim m_I_8 As Single         '        reserved 0.0
        Dim m_TAU0 As Single        ' [1092] design shear stress (shear force)
        Dim m_RIO As Single         '        direction of upside reinforcement
        Dim m_RIOQ As Single        '        direction of upside cross reinforcement
        Dim m_RIU As Single         '        direction of downside reinforcement
        Dim m_RIUQ As Single        '        direction of downside cross reinforcement
        Dim m_RIOI As Single        '        direction of upside third reinforcement
        Dim m_RIUI As Single        '        direction of downside third reinforcement
        Dim m_ZMIN As Single        ' [1001] minimum lever arm
        Dim m_VEDR As Single        '        max. VED/VRDMAX
        Dim m_COTT As Single        '        max. cot_theta
        Dim m_VED As Single         '        max. VED
        Dim m_FREE As Single        '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDO() As Single ' [1092] upside stress range (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SDU() As Single ' [1092] downside stress range (inside)
        Dim m_SDV As Single         ' [1092] stirrup stress range
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSO() As Single ' [1092] maximum stell stress upside (outside)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SSU() As Single ' [1092] maximum stell stress downside(inside)
        Dim m_SSV As Single         ' [1092] maximum stirrup stress (not yet used)
        Dim m_SIGBO As Single       ' [1092] maximum concrete pressure upside (outside)
        Dim m_SIGBU As Single       ' [1092] maximum concrete pressure downside(inside)
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress
        Dim m_SHZX As Single        '        max. skew principal tensile stress in local x
        Dim m_SHZY As Single        '        max. skew principal tensile stress in local y
        Dim m_FREE40 As Single      '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASBEND() As Single ' [1021] Info reinforcement bending design only
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPLUS() As Single ' [1021] Info reinforcement if increased due to shear
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_ASPOSS() As Single ' [1021] Info reinforcement to satisfy shear without stirrups
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_BMOM() As Single ' [1114] Design bending moment in direction of reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_ORIGIN() As Single '        origin of maximum reinforcement
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DECO() As Single ' [   9] decompression strain in the direction of tendons
    End Structure

    Structure CQUAD_NRP          ' 262/DC:+  punching reinforcement in nodes
        Dim m_NR As Integer         '        nodenumber
        Dim m_ISTA As Integer       '        state of force
        Dim m_IDUS As Integer       '        punching state
        Dim m_U0 As Single          ' [1001] effective length of first perimeter
        Dim m_REDO As Single        '        reduction factor for openings/free edges
        Dim m_V As Single           ' [1151] punching force
        Dim m_ASL As Single         ' [1020] required longitudinal reinforcement
        Dim m_ASV1 As Single        ' [1022] shear reinforcement within 1st perimeter
        Dim m_ASV2 As Single        ' [1022] shear reinforcement within 2nd perimeter
        Dim m_ASV3 As Single        ' [1022] shear reinforcement within 3rd perimeter
        Dim m_ASV4 As Single        ' [1022] shear reinforcement within 4th perimeter
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_FREE0() As Single '        not yet used
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT1() As Integer '        Halfen Description 1 (30 chars require n/2+1 words)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT2() As Integer '        Halfen Description 2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim m_TXT3() As Integer '        Halfen Description 3
    End Structure

    Structure CQUAD_PUN          ' 262/DC:0  punching periphery
        Dim m_NR As Integer         '        identifier 0
        Dim m_ID As Integer         '        identifier 0
        Dim m_TYP As Integer        '        type of line
        Dim m_X1 As Single          ' [1001] Coordinates of start point
        Dim m_Y1 As Single          ' [1001] 
        Dim m_Z1 As Single          ' [1001] 
        Dim m_X2 As Single          ' [1001] Coordinates of end point
        Dim m_Y2 As Single          ' [1001] 
        Dim m_Z2 As Single          ' [1001] 
    End Structure

    Structure CQUAD_PU1          ' 262/DC:0  punching parameters
        Dim m_NR As Integer         '        identifier 0
        Dim m_ID As Integer         '        identifier 1
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=199)> Dim m_KDUST() As Integer '        Integer-punching parameters
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=299)> Dim m_RDUST() As Single '        Real-punching parameters
    End Structure

    Structure CQUAD_CFD          ' 290/LC  Fluid flow results in Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_VX As Single          ' [1212] velocity
        Dim m_VY As Single          ' [1212] velocity
        Dim m_VZ As Single          ' [1212] velocity
        Dim m_Q As Single           ' [1211] stream quantity
        Dim m_HOPT As Single        ' [1001] Boundary layer
        Dim m_VXA As Single         ' [1212] particle velocity
        Dim m_VYA As Single         ' [1212] particle velocity
        Dim m_VZA As Single         ' [1212] particle velocity
        Dim m_MUED As Single        ' [1220] laminar viscosity
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DUX() As Single ' [  95] gradient values of fluid flow du/dx, du/dy
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> Dim m_DVX() As Single ' [  95] gradient values of fluid flow dv/dx, dv/dy
        Dim m_TK As Single          ' [1222] turbulent energy
        Dim m_MUET As Single        ' [1220] turbulent viscosity
        Dim m_ED As Single          ' [1223] dissipation rate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SCALAR() As Single '        optional scalar values
    End Structure

    Structure CQUAD_TM           ' 291/LC:0  Maximum of Temperature Results in Quads
        Dim m_NR As Integer         '        elementnumber
        Dim m_QX As Single          ' [1218] heat flux
        Dim m_QY As Single          ' [1218] heat flux
        Dim m_QZ As Single          ' [1218] heat flux
        Dim m_Q As Single           ' [1216] Total flux
        Dim m_HOPT As Single        ' [1001] optimal mesh size
        Dim m_TEFF As Single        ' [  92] Effective Age
        Dim m_HYDR As Single        '        Hydration degree
        Dim m_LFR As Single         '        Liquid fraction
    End Structure

    Structure CQUAD_TMP          ' 291/LC  Temperature Results in Quad-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_QX As Single          ' [1218] heat flux
        Dim m_QY As Single          ' [1218] heat flux
        Dim m_QZ As Single          ' [1218] heat flux
        Dim m_Q As Single           ' [1216] Total flux
        Dim m_HOPT As Single        ' [1001] optimal mesh size
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_TEFF() As Single ' [  92] Effective Age
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_HYDR() As Single '        Hydratation degree
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=5)> Dim m_LFR() As Single '        Liquid fraction
    End Structure

    Structure CBRIC              ' 300/00  Bric-elements
        Dim m_NR As Integer         '        elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_MAT As Integer        '        materialnumber
        Dim m_NRA As Integer        '        type of element
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_DET() As Single '        Values of Jacobian Determinant / Volume
    End Structure

    Structure CBRIC_SU           ' 300/02:0  Surfaces and Neighbours of Bric-elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_N0() As Integer
        Dim m_NSUR As Integer
        Dim m_MBRI As Integer       '        max number of brics per surface
    End Structure

    Structure CBRIC_SUR          ' 300/02:+  Surfaces and Neighbours of Bric-elements
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_NODE() As Integer
        Dim m_IJMP As Integer
        Dim m_NBRI As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=7)> Dim m_NREL() As Integer '        bric numbers for this surface
    End Structure

    Structure CBRIC_RIM          ' 300/6  Prescribed Reinforcements of Bric-elements
        Dim m_NRG As Integer        '        group number
        Dim m_NR As Integer         '        selector number
        Dim m_TYP As Integer        '        Type of Reinforc.
        Dim m_GTYP As Integer       '        Type of grading
        Dim m_IDRA As Integer       '        drawing source type
        Dim m_OAL As Single         '        Euler Angle I reinforcement
        Dim m_OAF As Single         '        Euler Angle II
        Dim m_XREF As Single        ' [1001] Reference point for circular reinforcement
        Dim m_YREF As Single        ' [1001] XREF+YREF allowed in combination with OAL and OAF
        Dim m_ZREF As Single        ' [1001] ZREF<>RW only allowed for OAL=OAF=0
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DI() As Single ' [1023] Diameter of reinforcement 1-3
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() As Single ' [1022] Minimum reinforcement 1-3
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AM() As Single ' [1022] Maximum reinforcement 1-3
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_WK() As Single ' [1026] design crack width
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SIG() As Single ' [1092] SLS steel stress limit
    End Structure

    Structure CBRIC_P            ' 300/10  Bric-P-Elements
        Dim m_NR As Integer         '        elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_NODE() As Integer '        nodenumbers
        Dim m_MAT As Integer        '        materialnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)> Dim m_EDGE() As Integer '        geometric id of edge 1-2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> Dim m_FACE() As Integer '        geometric id of face 1-2-3-4
    End Structure

    Structure CBRIC_LOA          ' 302/LC  loads of Bric-elements
        Dim m_VON As Integer        '        start elementnumber
        Dim m_BIS As Integer        '        end elementnumber
        Dim m_DEL As Integer        '        increment
        Dim m_TYP As Integer        '        type of load
        Dim m_LNR As Integer        '        primary loadcasenumber,if TYP = 18/30
        Dim m_P As Single           '        load value
        Dim m_DPDX As Single
        Dim m_DPDY As Single
        Dim m_DPDZ As Single
        Dim m_XREF As Single        ' [1001] optional reference point for load value
        Dim m_YREF As Single        ' [1001] 
        Dim m_ZREF As Single        ' [1001] 
    End Structure

    Structure CBRIC_STC          ' 310/LC:0  maximum stress in BRICs
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
        Dim m_HP1 As Single         '        yield function
        Dim m_HP2 As Single         '        volum. hardening
    End Structure

    Structure CBRIC_STR_SG       '        results in GAUSS-points
        Dim m_SIGX As Single        ' [1092] 
        Dim m_SIGY As Single        ' [1092] 
        Dim m_SIGZ As Single        ' [1092] 
        Dim m_TVXY As Single        ' [1092] 
        Dim m_TVXZ As Single        ' [1092] 
        Dim m_TVYZ As Single        ' [1092] 
    End Structure

    Structure CBRIC_STR          ' 310/LC:+  3D-stresses in Bric-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> Dim m_SG() As CBRIC_STR_SG '        results in GAUSS-points
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP1() As Single '        yield function
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP2() As Single '        2nd parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP3() As Single '        3rd parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP4() As Single '        4th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP5() As Single '        5th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP6() As Single '        6th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP7() As Single '        7th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP8() As Single '        8th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP9() As Single '        9th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP10() As Single '        10th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP11() As Single '        11th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP12() As Single '        12th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP13() As Single '        13th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP14() As Single '        14th parameter as specified in headder record
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HP15() As Single '        15th parameter as specified in headder record
    End Structure

    Structure CBRIC_NSC          ' 311/LC:0  maximum nodal 3D stress
        Dim m_NG As Integer         '        ident 0 for maximum (first records)
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
    End Structure

    Structure CBRIC_NST          ' 311/LC:+  3D-stresses in Bric-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
        Dim m_FY As Single          '        yield function
    End Structure

    Structure CBRIC_ESC          ' 312/LC:0  max. errors of Bric-stresses
        Dim m_NR As Integer         '        ident 0 for maximum (first records)
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
    End Structure

    Structure CBRIC_EST          ' 312/LC:+  3D-error estimates in Bric-Elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_SIGX As Single        ' [1092] stress
        Dim m_SIGY As Single        ' [1092] stress
        Dim m_SIGZ As Single        ' [1092] stress
        Dim m_TVXY As Single        ' [1092] shear stress
        Dim m_TVXZ As Single        ' [1092] shear stress
        Dim m_TVYZ As Single        ' [1092] shear stress
    End Structure

    Structure CBRIC_REI          ' 360/DC:+  reinforcement in Bric-elements
        Dim m_NR As Integer         '        elementnumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() As Single ' [1022] reinforcement 1-3
        Dim m_OAL As Single         '        Euler Angle I
        Dim m_OAF As Single         '        Euler Angle II
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SD() As Single ' [1092] stress range 1-3
        Dim m_SIGB As Single        ' [1092] maximum concrete pressure
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress (SLS uncracked)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ORIGIN() As Single '        origin of maximum reinforcement: as defined in 260/DC
    End Structure

    Structure CBRIC_NRI          ' 361/DC:+  reinforcement in Bric-nodes
        Dim m_NG As Integer         '        groupnumber
        Dim m_NR As Integer         '        nodenumber
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_AS() As Single ' [1022] reinforcement 1-3
        Dim m_OAL As Single         '        Euler Angle I
        Dim m_OAF As Single         '        Euler Angle II
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_SD() As Single ' [1092] stress range 1-3
        Dim m_SIGB As Single        ' [1092] maximum concrete pressure
        Dim m_SHZMAX As Single      '        maximum skew principal tensile stress (SLS uncracked)
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_ORIGIN() As Single '        origin of maximum reinforcement: as defined in 260/DC
    End Structure

    Structure CBRIC_CFD          ' 390/LC  Fluid flow results in BRIC-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_VX As Single          ' [1212] velocity
        Dim m_VY As Single          ' [1212] velocity
        Dim m_VZ As Single          ' [1212] velocity
        Dim m_Q As Single           ' [1211] stream quantity
        Dim m_HOPT As Single        ' [1001] optimal mesh size
        Dim m_VXA As Single         ' [1212] particle velocity
        Dim m_VYA As Single         ' [1212] particle velocity
        Dim m_VZA As Single         ' [1212] particle velocity
        Dim m_MUED As Single        ' [1220] laminar viscosity
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DUX() As Single ' [  95] gradient values fluid flow du/dx, du/dy, du/dz
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DVX() As Single ' [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim m_DWX() As Single ' [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
        Dim m_TK As Single          ' [1222] turbulent energy
        Dim m_MUET As Single        ' [1220] turbulent viscosity
        Dim m_ED As Single          ' [1223] dissipation rate
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_SCALAR() As Single '        optional scalar parameters
    End Structure

    Structure CBRIC_TM           ' 391/LC:0  Maximum Temperature Results in BRICs
        Dim m_NR As Integer         '        elementnumber
        Dim m_QX As Single          ' [1218] heat flux
        Dim m_QY As Single          ' [1218] heat flux
        Dim m_QZ As Single          ' [1218] heat flux
        Dim m_Q As Single           ' [1216] Total flux
        Dim m_TEFF As Single        ' [  92] Effective Age
        Dim m_HYDR As Single        '        Hydration degree
        Dim m_LFR As Single         '        Liquid fraction
    End Structure

    Structure CBRIC_TMP          ' 391/LC  Temperature Results in BRIC-elements
        Dim m_NR As Integer         '        elementnumber
        Dim m_QX As Single          ' [1218] heat flux
        Dim m_QY As Single          ' [1218] heat flux
        Dim m_QZ As Single          ' [1218] heat flux
        Dim m_Q As Single           ' [1216] Total flux
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_TEFF() As Single ' [  92] Effective Age
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_HYDR() As Single '        Hydration degree
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=9)> Dim m_LFR() As Single '        Liquid fraction
    End Structure

    Structure CHASE_PIH          ' 404/NR:0  HASE-Piles in Half-space
        Dim m_ID As Integer         '        Identification 0
        Dim m_NPILE As Integer      '        Number of piles
        Dim m_MPILE As Integer      '        Max. values per pile
        Dim m_NHKNOT As Integer     '        Number of nodes
    End Structure

    Structure CHASE_PIL          ' 404/NR:+  HASE-Piles in Half-space
        Dim m_ENR As Integer        '        External node number
        Dim m_X As Single           ' [1001] Pile X-coordinate
        Dim m_Y As Single           ' [1001] Pile Y-coordinate
        Dim m_DF As Single          ' [1001] Pile-foot diameter
        Dim m_Z As Single           ' [1001] Pile-foot coordinate
        Dim m_MANT As Single        '        Fraction of the total pile load transfered as a pile
        Dim m_PMAM As Single        ' [1190] Max. load transferable by skin friction
        Dim m_INR As Integer        '        Ixternal node number
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim m_BEZ() As Integer '        Designation
        Dim m_PMAF As Single        ' [1190] Max. load transferable trough pile-foot
        Dim m_ZMAN As Single        ' [1001] Z-coordiante from which the skin friction is active
        Dim m_CFAC As Single        '        Factor of load applied as compression-only
        Dim m_PLEN As Single        ' [1001] Pile length
        Dim m_PLSF As Single        ' [1001] Pile length part inactive for skin friction
        Dim m_D0 As Single          ' [1001] Pile diameter
        Dim m_MNR As Single         '        Pile material number
    End Structure

    Structure CSEG_DEF           ' 900/00  Segmentdefinition
        Dim m_ID As Integer         '        Identification of segment
        Dim m_TYP As Integer        '        Type of segment
        Dim m_BIT As Integer        '        Bitpattern idef+4*iref
        Dim m_LEN As Single         ' [1001] Length of segment
        Dim m_ALFA As Single        ' [   5] Angle of start face to axis (0 = match-cast)
        Dim m_ALFR As Single        ' [   5] Angle of end   face to axis (0 = match-cast)
        Dim m_DSPA As Single        ' [1001] Distance of start survey point
        Dim m_DSPE As Single        ' [1001] Distance of end survey point
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TEXT() As Integer '        designation of segment
    End Structure

    Structure CIL_CTRL0          ' -1/NS:0  Headder of a location
        Dim m_ID As Integer         '        ID=0
        Dim m_KWERG As Integer      '        KWH for results to be saved
        Dim m_NERG As Integer       '        Count on corresponding items
        Dim m_NN As Integer         '        reserved
        Dim m_XABS As Single        ' [1001] abszissae for beam sections
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Name of location
    End Structure

    Structure CIL_CTRL1          ' -1/NS:?  Headder of a result
        Dim m_IDI As Integer        '        Type of result
        Dim m_IERG As Integer       '        index of this item + 1000*IMUNIT
        Dim m_LFMAX As Integer      '        Offset for load case number of results for maximum
        Dim m_LFMIN As Integer      '        Offset for load case number of results for minimum
        Dim m_LPHI As Single        ' [1001] characteristic lenght for dynamic impact factor
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=17)> Dim m_TXT() As Integer '        Name of item
    End Structure

    Structure CIL_DATA0          ' -1/NS:1????  Influence values (V23, obsoleted)
        Dim m_IDI As Integer        '        Type of derivatives defined
        Dim m_X As Single           ' [1001] abszissae along lane
        Dim m_PV As Single          '        Influence value for vertical loading (z)
        Dim m_MT As Single          '        Influence value for torsional loading (x-x)
        Dim m_PL As Single          '        Influence value for longitudinal loading (x)
        Dim m_PT As Single          '        Influence value for transverse loading (y)
        Dim m_DPV As Single         '        Derivative of PV/dx (if IDI&1000)
        Dim m_DMT As Single         '        Derivative of MT/dx (if IDI&0100)
        Dim m_DPL As Single         '        Derivative of PL/dx (if IDI&0010)
        Dim m_DPT As Single         '        Derivative of PT/dx (if IDI&0001)
    End Structure

    Structure CIL_DATA           ' -1/NS:1??????  Influence values
        Dim m_IDI As Integer        '        Type of derivatives defined
        Dim m_X As Single           ' [1001] abszissae along lane
        Dim m_PV As Single          '        Influence value for vertical loading (z)
        Dim m_MT As Single          '        Influence value for torsional loading (x-x)
        Dim m_PL As Single          '        Influence value for longitudinal loading (x)
        Dim m_PT As Single          '        Influence value for transverse loading (y)
        Dim m_PPOS As Single        '        Influence value for vertical distributed loading
        Dim m_PNEG As Single        '        Influence value for vertical distributed loading
        Dim m_DPV As Single         '        Derivative of PV/dx   (if IDI&100000)
        Dim m_DMT As Single         '        Derivative of MT/dx   (if IDI&010000)
        Dim m_DPL As Single         '        Derivative of PL/dx   (if IDI&001000)
        Dim m_DPT As Single         '        Derivative of PT/dx   (if IDI&000100)
        Dim m_DPPOS As Single       '        Derivative of PPOS/dx (if IDI&000010)
        Dim m_DPNEG As Single       '        Derivative of PNEG/dx (if IDI&000001)
        Dim m_RRES As Single        '        Influence value for right residual loading
        Dim m_LRES As Single        '        Influence value for left residual loading
    End Structure


    '   SOFiSTiK AG                             Nov 10 2015
    '     sofistik_daten.vb
    '     ende der automatisch erzeugten Datei


End Module
