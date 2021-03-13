#+============================================================================
#| Company:   SOFiSTiK AG 
#|      sofistik_daten.py
#|      automatically generated header, no use to modify!
#+============================================================================


from ctypes import *


class CREC_VERS(Structure):        # -999/-999  Revision number of generating cdbase.txt
   _fields_ = [
         ('m_vers', c_int)         #        version
      ]
crec_vers = CREC_VERS()

class CREC_INDX(Structure):        # -999/-998  Sorted index on structure names
   _fields_ = [
         ('m_name', c_int * 2),    #        Name of this structure
         ('m_kwh', c_int),         #        Kwh
         ('m_kwl', c_int),         #        Kwl
         ('m_sel1', c_int * 2),    #        Selection string of first integer value
         ('m_sel2', c_int * 2)     #        Selection string of second integer value
      ]
crec_indx = CREC_INDX()

class CREC_PUB(Structure):         # -999/-997:1  public REC
   _fields_ = [
         ('m_id', c_int),          #        Identification 1/2
         ('m_kwh', c_int),         #        Kwh
         ('m_kwl', c_int),         #        Kwl (may be NR/LC or number)
         ('m_sel1', c_int * 2),    #        Selection string of first integer value
         ('m_sel2', c_int * 2),    #        Selection string of second integer value
         ('m_name', c_int * 2),    #        name of this structure
         ('m_version', c_int),     #        Version number of description
         ('m_option', c_int)       #        options  0 = default
      ]
crec_pub = CREC_PUB()

class CREC_INT(Structure):         # -999/-997:2  internal REC
   _fields_ = [
         ('m_id', c_int),          #        Identification 1/2
         ('m_kwh', c_int),         #        Kwh
         ('m_kwl', c_int),         #        Kwl (may be NR/LC or number)
         ('m_sel1', c_int * 2),    #        Selection string of first integer value
         ('m_sel2', c_int * 2),    #        Selection string of second integer value
         ('m_name', c_int * 2),    #        name of this structure
         ('m_version', c_int),     #        Version number of description
         ('m_option', c_int)       #        options  0 = default
      ]
crec_int = CREC_INT()

class CREC_DAD(Structure):         # -999/-997:3  public DAD
   _fields_ = [
         ('m_id', c_int),          #        Identification 3
         ('m_kwh', c_int),         #        Kwh
         ('m_kwl', c_int)          #        Kwl
      ]
crec_dad = CREC_DAD()

class CREC_DESC(Structure):        # -999/-997:4  description string to last entry or item
   _fields_ = [
         ('m_id', c_int),          #        Identification 4
         ('m_lang', c_int),        #        Language of this item
         ('m_name',  c_int * 64)   #        Description
      ]
crec_desc = CREC_DESC()

class CREC_ITM5_STRU(Structure):   #        Names of the structure elements
   _fields_ = [
         ('m_name', c_int * 2),
         ('m_dim', c_int),
         ('m_dim1', c_int)
      ]
crec_itm5_stru = CREC_ITM5_STRU()

class CREC_ITM5(Structure):        # -999/-997:5  item of a record (obsoleted)
   _fields_ = [
         ('m_id', c_int),          #        Identification 5
         ('m_nr', c_int),          #        number of the item
         ('m_index', c_int),       #        index of the item starting with 0
         ('m_typ', c_int),         #        Type of the item
         ('m_offset', c_int),      #        offset of the item to be merged
         ('m_name', c_int * 2),    #        item name (4 chars significant)
         ('m_dim', c_int),         #        unit or type of item
         ('m_dim1', c_int),        #        first dimension
         ('m_beg1', c_int),        #        first index of first dimension
         ('m_dim2', c_int),        #        second dimension
         ('m_beg2', c_int),        #        first index of second dimension
         ('m_bits', c_int),        #        additional information Bits
         ('m_structur',  CREC_ITM5_STRU * 20)  #        Names of the structure elements
      ]
crec_itm5 = CREC_ITM5()

class CREC_ITEM_STRU(Structure):   #        Names of the structure elements
   _fields_ = [
         ('m_name', c_int * 2),
         ('m_dim', c_int),
         ('m_type', c_int),
         ('m_dim1', c_int)
      ]
crec_item_stru = CREC_ITEM_STRU()

class CREC_ITEM(Structure):        # -999/-997:6  item of a record
   _fields_ = [
         ('m_id', c_int),          #        Identification 6
         ('m_nr', c_int),          #        number of the item
         ('m_index', c_int),       #        index of the item starting with 0
         ('m_typ', c_int),         #        Type of the item
         ('m_offset', c_int),      #        offset of the item to be merged
         ('m_name', c_int * 2),    #        item name (4 chars significant)
         ('m_dim', c_int),         #        unit of item
         ('m_type', c_int),        #        type of item
         ('m_dim1', c_int),        #        first dimension
         ('m_beg1', c_int),        #        first index of first dimension
         ('m_dim2', c_int),        #        second dimension
         ('m_beg2', c_int),        #        first index of second dimension
         ('m_bits', c_int),        #        additional information Bits
         ('m_structur',  CREC_ITEM_STRU * 20)  #        Names of the structure elements
      ]
crec_item = CREC_ITEM()

class CREC_MIX_MIXI(Structure):    #        Mixinfo
   _fields_ = [
         ('m_typ', c_int),
         ('m_keytyp', c_int),
         ('m_mixfrom', c_int)
      ]
crec_mix_mixi = CREC_MIX_MIXI()

class CREC_MIX(Structure):         # -999/-997:11  mixinfo of a record
   _fields_ = [
         ('m_id', c_int),          #        Identification 11/12
         ('m_nkey', c_int),
         ('m_nlen', c_int),
         ('m_nmixflag', c_int),
         ('m_selector', c_int),
         ('m_mixinfo',  CREC_MIX_MIXI * 256)  #        Mixinfo
      ]
crec_mix = CREC_MIX()

class CREC_MHD_MIXI(Structure):    #        Mixinfo
   _fields_ = [
         ('m_typ', c_int),
         ('m_keytyp', c_int),
         ('m_mixfrom', c_int)
      ]
crec_mhd_mixi = CREC_MHD_MIXI()

class CREC_MHD(Structure):         # -999/-997:12  mixinfo of a record header
   _fields_ = [
         ('m_id', c_int),          #        Identification 11/12
         ('m_nkey', c_int),
         ('m_nlen', c_int),
         ('m_nmixflag', c_int),
         ('m_selector', c_int),
         ('m_mixinfo',  CREC_MHD_MIXI * 256)  #        Mixinfo
      ]
crec_mhd = CREC_MHD()

class CCTRL_010(Structure):        # 0/01:999  AccessInfo Last Program
   _fields_ = [
         ('m_id', c_int),          #        Identifier 999
         ('m_acce', c_int),        #        Number of access
         ('m_vers', c_int),        #        Version number
         ('m_name',  c_int * 17),  #        Name of Program
         ('m_err', c_int * 4)      #        Name of ERR-File
      ]
cctrl_010 = CCTRL_010()

class CCTRL_011(Structure):        # 0/01:?  Messages
   _fields_ = [
         ('m_id', c_int),          #        Level
         ('m_iderr', c_int * 2),   #        Number of errortext
         ('m_idsup', c_int * 4),   #        Name of subroutine
         ('m_itext', c_int * 6),   #        Text value of message
         ('m_nilist', c_int),      #        count on Integer values of message
         ('m_nrlist', c_int),      #        count on Real values of message
         ('m_list', c_int * 255)   #        values of message ILIST+RLIST
      ]
cctrl_011 = CCTRL_011()

class CCTRL_OBJ(Structure):        # 0/01:101  involved objects
   _fields_ = [
         ('m_id', c_int),          #        Identifier = 101
         ('m_id2', c_int),         #        bitpattern of specified data
         ('m_type', c_int),        #        KWH of Elementtype (30,31,32,33)
         ('m_nr', c_int),          #        Number of element  (TYPE/NR)
         ('m_idbim', c_int * 32),  #        256 Bit GUId Identifier of element in the BIM/CAD system
         ('m_uvw', c_float * 3),   # [1001] local coordinates in object
         ('m_box', c_float * 2 * 3)  # [1001] bounding box x,y,z min, x,y,z max
      ]
cctrl_obj = CCTRL_OBJ()

class CCTRL_OID(Structure):        # 0/01:102  GUId
   _fields_ = [
         ('m_id', c_int),          #        identifier 102
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of preceeding element
      ]
cctrl_oid = CCTRL_OID()

class CSSD_SPE(Structure):         # 0/96:1  SSD-Spezial
   _fields_ = [
         ('m_id', c_int),          #        id==1
         ('m_type', c_int),        #        type of information
         ('m_ival', c_int),        #        integer value
         ('m_rval', c_float * 3),  #        real values
         ('m_itxt', c_int * 4)     #        string value
      ]
cssd_spe = CSSD_SPE()

class CVIS_LC0(Structure):         # 0/97:0  active Loadcase
   _fields_ = [
         ('m_id', c_int),          #        id==0
         ('m_lfnr', c_int),        #        Loadcase number
         ('m_vis', c_int)          #        unused
      ]
cvis_lc0 = CVIS_LC0()

class CVIS_LC(Structure):          # 0/97:1  Loadcase visualisation
   _fields_ = [
         ('m_id', c_int),          #        id==1
         ('m_lfnr', c_int),        #        Loadcase number
         ('m_vis', c_int)          #        Visualisation
      ]
cvis_lc = CVIS_LC()

class CCTRL(Structure):            # 0/99:*  PrintControl
   _fields_ = [
         ('m_maxl', c_int),        #        Lines per page
         ('m_marg', c_int),        #        Left margin
         ('m_tobo', c_int),        #        Top/bottom margin
         ('m_modp', c_int),        #        Type of Headding
         ('m_page', c_int),        #        Current page no
         ('m_lout', c_int),        #        Output Language
         ('m_linp', c_int),        #        Input  Language
         ('m_unit', c_int),        #        Unit set
         ('m_acce', c_int),        #        No of last access
         ('m_pag',  c_int * 7),    #        Paging Text
         ('m_rel_vers', c_int),    #        ReleaseVersion of this database
         ('m_rel_bits', c_int)     #        Accessbits
      ]
cctrl = CCTRL()

class CCTRL_0(Structure):          # 0/99:0  AccessInfo
   _fields_ = [
         ('m_id', c_int),          #        Identifier 0
         ('m_acce', c_int),        #        Number of access
         ('m_vers', c_int),        #        Version number
         ('m_erro', c_int),        #        Number of Errors
         ('m_warn', c_int),        #        Number of Errors
         ('m_name',  c_int * 17),  #        Name of Program
         ('m_rel_vers', c_int)     #        ReleaseVersion of last access
      ]
cctrl_0 = CCTRL_0()

class CCTRL_1(Structure):          # 0/99:1  AccessTitle
   _fields_ = [
         ('m_id', c_int),          #        Identifier 1
         ('m_acce', c_int),        #        Number of access
         ('m_kopf',  c_int * 64)   #        Title of access
      ]
cctrl_1 = CCTRL_1()

class CCTRL_VAR(Structure):        # 0/100  Global_CADINP_Variable
   _fields_ = [
         ('m_name', c_int * 4),    #        name of variable
         ('m_ind', c_int),         #        index for arrays
         ('m_val', c_float),       #        value of variable
         ('m_scope', c_int),       #        name of scope
         ('m_dim', c_int),         #        unit of variable
         ('m_txt',  c_int * 17)    #        Comment on variable
      ]
cctrl_var = CCTRL_VAR()

class CCTRL_VAP(Structure):        # 0/100:???  Private_CADINP_Variable
   _fields_ = [
         ('m_id', c_int),          #        Identification = ???
         ('m_ind1', c_int),        #        Lower Index of variable
         ('m_ind2', c_int),        #        Upper Index of variable
         ('m_name', c_int * 4),    #        Name of variable
         ('m_val', c_float * 1020) #        values of the variable NAME[IND1:IND2]
      ]
cctrl_vap = CCTRL_VAP()

class CCTRL_DIM(Structure):        # 0/101  Unit definitions
   _fields_ = [
         ('m_idim', c_int),        #        number of an implicit unit (>999)
         ('m_unia', c_int),        #        unit for output (0=do not change)
         ('m_unie', c_int),        #        unit for input  (0=do not change)
         ('m_diga', c_int),        #        number of digits for output (>10 for Exponential)
         ('m_dige', c_int)         #        number of digits for input (=GUI)
      ]
cctrl_dim = CCTRL_DIM()

class CMAT(Structure):             # 1/NR:0  MaterialTitle
   _fields_ = [
         ('m_id', c_int),          #        Identification = 0
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_title',  c_int * 17)  #        designation
      ]
cmat = CMAT()

class CMAT_USER(Structure):        # 1/NR:10??  Information on user input
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_bit', c_int * 32)     #        User input for 001/NR:1
      ]
cmat_user = CMAT_USER()

class CMAT_FLUI(Structure):        # 1/NR:1  MaterialConstants
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Compression modulus
         ('m_nue', c_float),       # [1221] Kinematic Viscosity
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_rho', c_float),       # [1189] Density
         ('m_gamb', c_float),      # [1091] dead weight buyoncy
         ('m_alfa', c_float)       # [ 107] Temperature Elongation coefficient
      ]
cmat_flui = CMAT_FLUI()

class CMAT_CONS(Structure):        # 1/NR:1  MaterialConstants
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_gamb', c_float),      # [1091] dead weight buyoncy
         ('m_alfa', c_float),      # [ 107] Temperature Expansion
         ('m_e90', c_float),       # [1090] Transvers Elasticity
         ('m_mue90', c_float),     #        anisotrope Poisson
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fy', c_float),        # [1092] effective strength
         ('m_ft', c_float),        # [1092] nominal strength
         ('m_p', c_float * 18)     #        variable parameters
      ]
cmat_cons = CMAT_CONS()

class CMAT_UNDR(Structure):        # 1/NR:14  Undrained soil parameters
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_gamb', c_float),      # [1091] dead weight buyoncy
         ('m_alfa', c_float),      # [ 107] Temperature Expansion
         ('m_e90', c_float),       # [1090] Transvers Elasticity
         ('m_mue90', c_float),     #        anisotrope Poisson
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fy', c_float),        # [1092] effective strength
         ('m_ft', c_float),        # [1092] nominal strength
         ('m_p', c_float * 18)     #        variable parameters
      ]
cmat_undr = CMAT_UNDR()

class CMAT_FAUL(Structure):        # 1/NR:15  Fault/Shear plane
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_gamb', c_float),      # [1091] dead weight buyoncy
         ('m_alfa', c_float),      # [ 107] Temperature Expansion
         ('m_e90', c_float),       # [1090] Transvers Elasticity
         ('m_mue90', c_float),     #        anisotrope Poisson
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fy', c_float),        # [1092] effective strength
         ('m_ft', c_float),        # [1092] nominal strength
         ('m_p', c_float * 18)     #        variable parameters
      ]
cmat_faul = CMAT_FAUL()

class CMAT_SWEL(Structure):        # 1/NR:16  Swelling parameters
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_gamb', c_float),      # [1091] dead weight buyoncy
         ('m_alfa', c_float),      # [ 107] Temperature Expansion
         ('m_e90', c_float),       # [1090] Transvers Elasticity
         ('m_mue90', c_float),     #        anisotrope Poisson
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fy', c_float),        # [1092] effective strength
         ('m_ft', c_float),        # [1092] nominal strength
         ('m_p', c_float * 18)     #        variable parameters
      ]
cmat_swel = CMAT_SWEL()

class CMAT_CONC(Structure):        # 1/NR:1  MaterialConcrete
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_rho', c_float),       # [1189] Density
         ('m_alfa', c_float),      # [ 107] Temperature Elongation coefficient
         ('m_e90', c_float),       # [1090] Elasticity modulus perpendicular
         ('m_mue90', c_float),     #        Poissons ratio perpendicular
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fc', c_float),        # [1092] effective strength
         ('m_fck', c_float),       # [1092] nominal strength
         ('m_ftm', c_float),       # [1092] mean value of tensional strength
         ('m_ftl', c_float),       # [1092] lower fractile of tensional strength
         ('m_ftk', c_float),       # [1092] upper fractile of tensional strength
         ('m_ec', c_float),        #        compr. failure Energy (deprecated)
         ('m_et', c_float),        # [ 112] tensile failure energy
         ('m_muer', c_float),      #        friction in the crack
         ('m_fcm', c_float),       # [1092] mean value of strength
         ('m_rdcl', c_float),      #        weight class
         ('m_fcr', c_float),       # [1092] calculatoric mean value of strength
         ('m_ecr', c_float),       # [1090] Elasticity modul for worklaw CE
         ('m_fbd', c_float),       # [1092] bond strength (EC2 Table. 5.1.3)
         ('m_ftd', c_float),       # [1092] Initial tensile strength Bemessungszugfestigkeit
         ('m_feqr', c_float),      # [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
         ('m_feqt', c_float),      # [1092] Residual tensile strength  Restzugfestigkeit im Bruch
         ('m_fcfat', c_float),     # [1092] Fatigue Strength
         ('m_scms', c_float),      #        Material safety for the serviceability law
         ('m_scmu', c_float),      #        Material safety for ultimate stress strain law
         ('m_scmc', c_float)       #        Material safety for the calculatoric law
      ]
cmat_conc = CMAT_CONC()

class CMAT_STEE(Structure):        # 1/NR:1  MaterialSteel
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_rho', c_float),       # [1189] Density
         ('m_alfa', c_float),      # [ 107] Temperature Elongation coefficient
         ('m_e90', c_float),       # [1090] Elasticity modulus perpendicular
         ('m_mue90', c_float),     #        Poissons ratio perpendicular
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fy', c_float),        # [1092] yield stress
         ('m_ft', c_float),        # [1092] tensile strength
         ('m_eps', c_float),       # [   9] limit strain
         ('m_rel1', c_float),      #        Relaxation 0.55fpk
         ('m_rel2', c_float),      #        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
         ('m_r', c_float),         #        bond coefficient
         ('m_k1', c_float),        #        bondfactor EC2
         ('m_eh', c_float),        # [1090] Hardening module
         ('m_fe', c_float),        # [1092] Proportional stress
         ('m_epse', c_float),      # [   9] Plastic strain
         ('m_fdyn', c_float),      # [1092] Dynamic strength
         ('m_fyc', c_float),       # [1092] compr. yield stress
         ('m_ftc', c_float),       # [1092] compress. strength
         ('m_tmax', c_float),      # [1023] max.plate thickness
         ('m_bc', c_float),        #        (eg. Aluminium 1.0/2.0 = "A","B" )
         ('m_dummy', c_float * 2),
         ('m_scms', c_float),      #        Material safety for the serviceability law
         ('m_scmu', c_float),      #        Material safety for ultimate stress strain law
         ('m_scmc', c_float)       #        Material safety for the calculatoric law
      ]
cmat_stee = CMAT_STEE()

class CMAT_TIMB(Structure):        # 1/NR:1  MaterialTimber
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Material type
         ('m_class', c_int),       #        Classification
         ('m_emod', c_float),      # [1090] Elasticity Modulus along the fibres
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_rho', c_float),       # [1189] Density
         ('m_alfa', c_float),      # [ 107] Temperature Elongation coefficient
         ('m_e90', c_float),       # [1090] Elasticity modulus perpendicular to fibres
         ('m_mue90', c_float),     #        Poissons ratio perpendicular
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fyb', c_float),       # [1092] Bending strength
         ('m_fyt', c_float),       # [1092] tensile strength along the fibres
         ('m_fyt90', c_float),     # [1092] tensile strength perpend. the fibres
         ('m_fyc', c_float),       # [1092] compressive strength along the fibres
         ('m_fyc90', c_float),     # [1092] compressive strength perpend. the fibres
         ('m_fys', c_float),       # [1092] middle shear strength (Membrane Shear force)
         ('m_fyst', c_float),      # [1092] edge shear strength (Torsion)
         ('m_fysb', c_float),      # [1092] maximum shear strength (plate shear)
         ('m_fyb90', c_float),     # [1092] Bending strength perpendicular to fibres
         ('m_g90', c_float),       # [1090] transverse shear modulus for platebending
         ('m_smod0', c_float),     #        Strength Modifier kmod for Service classes
         ('m_smod1', c_float),     #        Strength Modifier kmod for Service classes
         ('m_smod2', c_float),     #        Strength Modifier kmod for Service classes
         ('m_smod3', c_float),     #        Strength Modifier kmod for Service classes
         ('m_smod4', c_float),     #        Strength Modifier kmod for Service classes
         ('m_kdef', c_float),      #        Deformation modifier
         ('m_tmax', c_float),      # [1023] max.plate thickness
         ('m_scms', c_float),      #        Material safety
         ('m_scmu', c_float),      #        Material safety
         ('m_scmc', c_float)       #        Material safety
      ]
cmat_timb = CMAT_TIMB()

class CMAT_BRIC(Structure):        # 1/NR:1  MaterialBrickwork
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_type', c_int),        #        Bric type and strength
         ('m_class', c_int),       #        Mortar class
         ('m_emod', c_float),      # [1090] Elasticity Modulus
         ('m_mue', c_float),       #        Poissons ratio
         ('m_gmod', c_float),      # [1090] Shear modulus
         ('m_kmod', c_float),      # [1090] Compression modulus
         ('m_gam', c_float),       # [1091] dead weight
         ('m_rho', c_float),       # [1189] Density
         ('m_alfa', c_float),      # [ 107] Temperature Elongation coefficient
         ('m_e90', c_float),       # [1090] Elasticity modulus perpendicular
         ('m_mue90', c_float),     #        Poissons ratio perpendicular
         ('m_alf', c_float),       # [   5] Euler Angle I
         ('m_bet', c_float),       # [   5] Euler Angle II
         ('m_scm', c_float),       #        Material safety
         ('m_fk', c_float),        # [1092] Strength
         ('m_fb', c_float),        # [1092] brick strength
         ('m_ft', c_float),        # [1092] tensile strength
         ('m_fv', c_float),        # [1092] shear strength
         ('m_fv0', c_float),       # [1092] adhesional strength
         ('m_fbt', c_float),       # [1092] tens.brick strength
         ('m_fm', c_float),        # [1092] mortar strength
         ('m_dummy', c_float * 10),
         ('m_scms', c_float),      #        Material safety
         ('m_scmu', c_float),      #        Material safety
         ('m_scmc', c_float)       #        Material safety
      ]
cmat_bric = CMAT_BRIC()

class CMAT_SERV(Structure):        # 1/NR:2  StressStrainLaw (Servicability)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_temp', c_int),        #        Temperature
         ('m_type', c_int),        #        Type of law
         ('m_scm', c_float),       #        Safety factor
         ('m_eps', c_float),       # [   9] Elongation at TEMP if TEMP>0
         ('m_res1', c_float),      # [   9] Shift of strains TEMP>0 (-TempStrain)
         ('m_res2', c_float),      #        Tensile Strength  Concrete   for 21:24
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
cmat_serv = CMAT_SERV()

class CMAT_ULTI(Structure):        # 1/NR:3  StressStrainLaw (Ultimate Limit state)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_temp', c_int),        #        Temperature
         ('m_type', c_int),        #        Type of law
         ('m_scm', c_float),       #        Safety factor
         ('m_eps', c_float),       # [   9] Elongation at TEMP if TEMP>0
         ('m_res1', c_float),      # [   9] Shift of strains TEMP>0 (-TempStrain)
         ('m_res2', c_float),      #        Tensile Strength  Concrete   for 21:24
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
cmat_ulti = CMAT_ULTI()

class CMAT_NONL(Structure):        # 1/NR:4  StressStrainLaw (Nonlinear Mean Values)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_temp', c_int),        #        Temperature
         ('m_type', c_int),        #        Type of law
         ('m_scm', c_float),       #        Safety factor
         ('m_eps', c_float),       # [   9] Elongation at TEMP if TEMP>0
         ('m_res1', c_float),      # [   9] Shift of strains TEMP>0 (-TempStrain)
         ('m_res2', c_float),      #        Tensile Strength  Concrete   for 21:24
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
cmat_nonl = CMAT_NONL()

class CMAT_BED(Structure):         # 1/NR:7  MaterialBedding
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_mnr', c_int),         #        Materialnumber of bedding boddy
         ('m_ibt', c_int),         #        Type of bedding mechanism
         ('m_c', c_float),         # [1097] Bedding Coefficient
         ('m_ct', c_float),        # [1097] Tangential Bedding
         ('m_riss', c_float),      # [1092] rupture stress
         ('m_flie', c_float),      # [1092] yield   stress
         ('m_mue', c_float),       #        friction coefficient
         ('m_koh', c_float),       # [1092] cohesion
         ('m_dil', c_float),       #        dilatancy coeffic.
         ('m_gam', c_float),       # [1184] mass of bedding
         ('m_h', c_float)          # [1001] reference length
      ]
cmat_bed = CMAT_BED()

class CMAT_LAY(Structure):         # 1/NR:8  MaterialLayerStructure
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_nm', c_int),          #        Number of a material
         ('m_i_2', c_int),
         ('m_t', c_float)          # [1010] Thickness
      ]
cmat_lay = CMAT_LAY()

class CMAT_HYD(Structure):         # 1/NR:9  MaterialConductivity
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_t', c_int),           #        Temperature / pressure
         ('m_type', c_int),        #        Type of Material law
         ('m_d', c_float),         #        special Parameter
         ('m_c', c_float),         #        Storage Capacity
         ('m_n', c_float),         #        Porosity/humidity
         ('m_k', c_float * 6),     #        Conductivity
         ('m_kloc', c_float * 6)   #        Conductivity
      ]
cmat_hyd = CMAT_HYD()

class CMAT_SPE(Structure):         # 1/NR:90  MaterialSpecial
   _fields_ = [
         ('m_id', c_int),          #        Identification = 90
         ('m_type', c_int),        #        type of material value
         ('m_exp', c_int),         #        exposition class identifier (0=all classes)
         ('m_rval', c_float * 32)  #        real material values
      ]
cmat_spe = CMAT_SPE()

class CBORE(Structure):            # 2/NR:0  SoilProfile
   _fields_ = [
         ('m_id', c_int),          #        identifier 0 (always the first record)
         ('m_x', c_float),         # [1001] X_ordinate
         ('m_y', c_float),         # [1001] Y_ordinate
         ('m_z', c_float),         # [1001] Z_ordinate
         ('m_dx', c_float),        #        direction of axis
         ('m_dy', c_float),        #        direction of axis
         ('m_dz', c_float),        #        direction of axis
         ('m_alf', c_float),       # [   5] Angle of reference
         ('m_hgwl', c_float),      # [1006] lower ground water level
         ('m_hgwh', c_float),      # [1006] upper ground water level
         ('m_i_10', c_float * 6),
         ('m_text',  c_int * 17)   #        Designation of Profile
      ]
cbore = CBORE()

class CBORE_LAY(Structure):        # 2/NR:1  Soillayer
   _fields_ = [
         ('m_id', c_int),          #        Identifier 1
         ('m_mnr', c_int),         #        Material number
         ('m_vari', c_int),        #        Type of stiffness variation
         ('m_ilay', c_int),        #        Additional layer information
         ('m_i_4', c_int),         #        reserved
         ('m_i_5', c_int),         #        reserved
         ('m_s', c_float),         # [1001] Ordinate on bore profile axis (positive)
         ('m_es', c_float),        # [1096] Stiffness Modulus
         ('m_des', c_float),       # [1096] Increment of ES within current layer
         ('m_mue', c_float),       #        Poissons ratio
         ('m_pmax', c_float),      # [1096] Max. pressure at pile foot
         ('m_pmal', c_float),      # [1096] Max. lateral pressure
         ('m_c', c_float),         # [1096] Cohesion
         ('m_phi', c_float),       # [   5] Soil/Pile friction angle
         ('m_gam', c_float),       # [1091] nominal weight
         ('m_gamb', c_float)       # [1091] nominal weight under buoyancy
      ]
cbore_lay = CBORE_LAY()

class CBORE_TAB(Structure):        # 2/NR:10  SoilTabdefinition
   _fields_ = [
         ('m_id', c_int),          #        Identifier 10
         ('m_opt', c_int),         #        Option
         ('m_class', c_int),       #        Classification subtype
         ('m_facs', c_float),      #        Factor on stresses
         ('m_b', c_float * 10)     # [1001] Width of foundation
      ]
cbore_tab = CBORE_TAB()

class CBORE_TAD(Structure):        # 2/NR:11  SoilTabvalues
   _fields_ = [
         ('m_id', c_int),          #        Identifier 11
         ('m_i_1', c_int),         #        reserved
         ('m_i_2', c_int),         #        reserved
         ('m_d', c_float),         # [1006] Embedment depth of foundation
         ('m_sigd', c_float * 10)  # [1089] design stresses at specified depth values
      ]
cbore_tad = CBORE_TAD()

class CBORE_BAX(Structure):        # 2/NR:1001  BoreProfileAxial
   _fields_ = [
         ('m_id', c_int),          #        identifier 1001
         ('m_z1', c_float),        #        parameter s on start
         ('m_z2', c_float),        #        parameter s on end
         ('m_k0', c_float),        # [1096] constant bedding
         ('m_k1', c_float),        # [1096] parabolic bedding
         ('m_k2', c_float),        # [1096] linear bedding
         ('m_k3', c_float),        # [1096] quadratic bedding
         ('m_m0', c_float),        # [1153] cohesive loading
         ('m_c0', c_float),        # [1153] cohesion
         ('m_tanr', c_float),      #        friction angle
         ('m_tand', c_float),      #        dilatancy angle
         ('m_kq', c_float),        #        pressure coefficient
         ('m_pmax', c_float)       # [1101] maxforce at pile foot
      ]
cbore_bax = CBORE_BAX()

class CBORE_BLA(Structure):        # 2/NR:1002  BoreProfileTransverse
   _fields_ = [
         ('m_id', c_int),          #        identifier 1002
         ('m_z1', c_float),        #        parameter s on start
         ('m_z2', c_float),        #        parameter s on end
         ('m_k0', c_float),        # [1096] constant bedding
         ('m_k1', c_float),        # [1096] parabolic bedding
         ('m_k2', c_float),        # [1096] linear bedding
         ('m_k3', c_float),        # [1096] quadratic bedding
         ('m_f0', c_float),        #        peripher Distribution
         ('m_f1', c_float),
         ('m_f2', c_float),
         ('m_pm1', c_float),       # [1153] maximum value on upper ordinate
         ('m_pm2', c_float),       # [1153] maximum value on lower ordinate
         ('m_p0', c_float),        #        peripher Distribution
         ('m_p1', c_float),
         ('m_p2', c_float),
         ('m_p3', c_float) 
      ]
cbore_bla = CBORE_BLA()

class CBORE_BAM(Structure):        # 2/NR:1003  BoreProfileMoment
   _fields_ = [
         ('m_id', c_int),          #        identifier 1003
         ('m_z1', c_float),        #        parameter s on start
         ('m_z2', c_float),        #        parameter s on end
         ('m_k0', c_float),        # [1099] constant bedding
         ('m_k1', c_float),        # [1099] parabolic bedding
         ('m_k2', c_float),        # [1099] linear bedding
         ('m_k3', c_float)         # [1099] quadratic bedding
      ]
cbore_bam = CBORE_BAM()

class CBORE_DYA(Structure):        # 2/NR:1011  BoreProfileAxialDynamic
   _fields_ = [
         ('m_id', c_int),          #        identifier 1011
         ('m_z1', c_float),        #        parameter s on start
         ('m_z2', c_float),        #        parameter s on end
         ('m_d0', c_float),        # [ 105] constant damping
         ('m_d1', c_float),        # [ 105] parabolic damping
         ('m_d2', c_float),        # [ 105] linear damping
         ('m_d3', c_float)         # [ 105] quadratic damping
      ]
cbore_dya = CBORE_DYA()

class CBORE_DYL(Structure):        # 2/NR:1012  BoreProfileTransverseDynamic
   _fields_ = [
         ('m_id', c_int),          #        identifier 1012
         ('m_z1', c_float),        #        parameter s on start
         ('m_z2', c_float),        #        parameter s on end
         ('m_d0', c_float),        # [ 105] constant damping
         ('m_d1', c_float),        # [ 105] parabolic damping
         ('m_d2', c_float),        # [ 105] linear damping
         ('m_d3', c_float),        # [ 105] quadratic damping
         ('m_m0', c_float),        # [1181] constant soil mass
         ('m_m2', c_float)         # [1181] linear soil mass
      ]
cbore_dyl = CBORE_DYL()

class CAXIS(Structure):            # 3/ID:0  Geometric Axis
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_id1', c_int),         #        subtype of axis
         ('m_id2', c_int),         #        reserved
         ('m_id3', c_int),         #        reserved
         ('m_id4', c_int),         #        reserved
         ('m_id5', c_int),         #        reserved
         ('m_text',  c_int * 17)   #        Designation of Line
      ]
caxis = CAXIS()

class CAXIS_REF(Structure):        # 3/ID:-  Reference to another Geometry
   _fields_ = [
         ('m_igm', c_int),         #        negative value of the master geometry 03/abs(IGM)
         ('m_igs', c_int),         #        optional identifier of a secondary axis
         ('m_smin', c_float),      #        min parameter on referenced axis
         ('m_smax', c_float)       #        max parameter on referenced axis
      ]
caxis_ref = CAXIS_REF()

class CAXIS_GEO(Structure):        # 3/ID:??  Geometric properties
   _fields_ = [
         ('m_iln', c_int),         #        Code of geometry
         ('m_gpg', c_float),       # [1001] geometry parameter 1
         ('m_gpa', c_float),       # [1001] geometry parameter 2
         ('m_dd', c_float),        # [1001] arc length
         ('m_s1', c_float),        #        parameter s on start
         ('m_xyz1', c_float * 3),  # [1001] Ordinate of start
         ('m_dxyz1', c_float * 3), #        Tangent of start
         ('m_rg1', c_float),       # [1009] in-plane curvature
         ('m_ra1', c_float),       # [1009] vertical curvature
         ('m_s2', c_float),        #        parameter s on end
         ('m_xyz2', c_float * 3),  # [1001] Ordinate of endpoint
         ('m_dxyz2', c_float * 3), #        Tangent of endpoint
         ('m_rg2', c_float),       # [1009] in-plane curvature
         ('m_ra2', c_float),       # [1009] vertical curvature
         ('m_xat', c_float)        # [1001] relat. startordinate
      ]
caxis_geo = CAXIS_GEO()

class CAXIS_NKN(Structure):        # 3/ID:90  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=90
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_float * 256)    #        Knot-Vector
      ]
caxis_nkn = CAXIS_NKN()

class CSLN_NKN(Structure):         # 39/NR:90  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=90
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_float * 256)    #        Knot-Vector
      ]
csln_nkn = CSLN_NKN()

class CAXIS_CPT(Structure):        # 3/ID:91  Control point of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=91
         ('m_w', c_float),         #        Weight
         ('m_xyz', c_float * 3),   # [1001] Coordinates
         ('m_dir', c_float * 3)    #        upward direction
      ]
caxis_cpt = CAXIS_CPT()

class CSLN_CPT(Structure):         # 39/NR:91  Control point of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=91
         ('m_w', c_float),         #        Weight
         ('m_xyz', c_float * 3),   # [1001] Coordinates
         ('m_dir', c_float * 3)    #        upward direction
      ]
csln_cpt = CSLN_CPT()

class CAXIS_PT(Structure):         # 3/ID:92  Data point on curve
   _fields_ = [
         ('m_iln', c_int),         #        ID=92
         ('m_s', c_float),         #        Parameter along curve
         ('m_xyz', c_float * 3),   # [1001] Coordinates
         ('m_dir', c_float * 3)    #        upward direction
      ]
caxis_pt = CAXIS_PT()

class CSLN_PT(Structure):          # 39/NR:92  Data point on curve
   _fields_ = [
         ('m_iln', c_int),         #        ID=92
         ('m_s', c_float),         #        Parameter along curve
         ('m_xyz', c_float * 3),   # [1001] Coordinates
         ('m_dir', c_float * 3)    #        upward direction
      ]
csln_pt = CSLN_PT()

class CAXIS_ARC(Structure):        # 3/ID:93  Circular Arc
   _fields_ = [
         ('m_iln', c_int),         #        ID=93
         ('m_idf', c_int),         #        Definition selected
         ('m_r', c_float),         # [1001] Radius of arc
         ('m_xyz', c_float * 3),   # [1001] Coordinates of center
         ('m_dir', c_float * 3),   #        upward direction of plane
         ('m_xyza', c_float * 3),  # [1001] optional start point of arc
         ('m_xyze', c_float * 3)   # [1001] optional end point of arc
      ]
caxis_arc = CAXIS_ARC()

class CSLN_ARC(Structure):         # 39/NR:93  Circular Arc
   _fields_ = [
         ('m_iln', c_int),         #        ID=93
         ('m_idf', c_int),         #        Definition selected
         ('m_r', c_float),         # [1001] Radius of arc
         ('m_xyz', c_float * 3),   # [1001] Coordinates of center
         ('m_dir', c_float * 3),   #        upward direction of plane
         ('m_xyza', c_float * 3),  # [1001] optional start point of arc
         ('m_xyze', c_float * 3)   # [1001] optional end point of arc
      ]
csln_arc = CSLN_ARC()

class CAXIS_SPT(Structure):        # 3/ID:97  Station point on a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=97
         ('m_s', c_float),         #        Station value at data point
         ('m_l', c_float),         # [1001] Length (prescribed if XYZ==0.0)
         ('m_xyz', c_float * 3),   # [1001] Coordinates for 3D-intersection plane
         ('m_dir', c_float * 3)    #        Direction (nx,ny,nz) of normal of the plane
      ]
caxis_spt = CAXIS_SPT()

class CAXIS_VIZ(Structure):        # 3/ID:98  Data points for visualisation
   _fields_ = [
         ('m_iln', c_int),         #        ID=98
         ('m_color', c_int),       #        hexadecimal RGB-value (e.g. 99AAFF)
         ('m_thick', c_int),       #        Thickness in pixel
         ('m_pts', c_float * 64 * 3)  # [1001] Data Points
      ]
caxis_viz = CAXIS_VIZ()

class CAXIS_OBB(Structure):        # 3/ID:99  Oriented Boundig Box
   _fields_ = [
         ('m_iln', c_int),         #        ID=99
         ('m_s1', c_float),        #        Parameter on Start
         ('m_s2', c_float),        #        Parameter on end
         ('m_ta', c_float * 3 * 3),#        Transformation Matrix
         ('m_xyz', c_float * 3),   # [1001] Center of Box
         ('m_xi', c_float * 3)     # [1001] Half widths
      ]
caxis_obb = CAXIS_OBB()

class CAXIS_ATB(Structure):        # 3/ID:101  Geometric segments of axis plan view
   _fields_ = [
         ('m_id0', c_int),         #        ident=101
         ('m_id1', c_int),         #        specification type
         ('m_id2', c_int),         #        type of transition curve to be used
         ('m_s', c_float),         #        Station value at tangent
         ('m_l', c_float * 5),     # [1001] Length of segment
         ('m_r', c_float * 5),     # [1001] Radius mid & start & end
         ('m_xyz', c_float * 3),   # [1001] Startpoint of tangent
         ('m_dir', c_float * 3),   #        Tangential direction
         ('m_d', c_float * 2),     # [1001] Distance to point on curve (start/end)
         ('m_tau', c_float),       # [   5] deflection angle
         ('m_txt', c_int)          #        Identifier of this sequence
      ]
caxis_atb = CAXIS_ATB()

class CAXIS_VTB(Structure):        # 3/ID:102  Geometric properties for axis heights
   _fields_ = [
         ('m_id0', c_int),         #        ident=102
         ('m_id1', c_int),         #        specification type
         ('m_id2', c_int),         #        reserved
         ('m_s', c_float),         #        Parameter s along the axis
         ('m_h', c_float),         # [1001] Height of gradient polygon
         ('m_r', c_float),         # [1001] Radius of curvature at this point
         ('m_x', c_float),         # [1001] Calculated true length along the axis
         ('m_t', c_float)          # [1001] Calculated secant length along the axis
      ]
caxis_vtb = CAXIS_VTB()

class CAXIS_ITB(Structure):        # 3/ID:103  Placement at axis position
   _fields_ = [
         ('m_id0', c_int),         #        ident=103
         ('m_ids', c_int),         #        Enum of secondary axis
         ('m_typ', c_int),         #        properties of this placement
         ('m_npt', c_int),         #        point number
         ('m_grp', c_int),         #        group number behind that placement
         ('m_nos', c_int * 2),     #        Number of section before and behind that placement
         ('m_segt', c_int),        #        identifier of a segment see (900/0) behind that placement
         ('m_s', c_float),         #        Parameter s of this section
         ('m_y', c_float),         # [1001] additional transverse offset
         ('m_z', c_float),         # [1001] additional vertical offset
         ('m_alf', c_float),       # [   5] Rotation about global Z
         ('m_alfx', c_float),      # [   5] Rotation about local axis x
         ('m_alfy', c_float),      # [   5] Rotation about transverse y
         ('m_alfz', c_float),      # [   5] Rotation about vertical   z
         ('m_incr', c_float),      # [   5] Inclination to the right +y
         ('m_incl', c_float),      # [   5] Inclination to the left  -y
         ('m_srule', c_int * 5),   #        Formula string to evaluate the value S
         ('m_text',  c_int * 17)   #        Designation of Placement
      ]
caxis_itb = CAXIS_ITB()

class CAXIS_ITS(Structure):        # 3/ID:104  Secondary axis definition
   _fields_ = [
         ('m_id0', c_int),         #        Ident=104
         ('m_ids', c_int),         #        Enum of secondary axis (1='A' to 26 ='Z')
         ('m_iref', c_int),        #        Reference to external axis geometry
         ('m_npt', c_int),         #        offset for structural points along the axis
         ('m_grp', c_int),         #        group number (:103 is always added as an offset)
         ('m_y', c_float),         # [1001] constant or maximum value of y offset
         ('m_z', c_float),         # [1001] constant or maximum value of z offset
         ('m_y_v', c_int * 4),     #        variable name for y offset (see :110)
         ('m_z_v', c_int * 4),     #        variable name for z offset (see :110)
         ('m_text',  c_int * 17)   #        Designation (only for first point of a sequence)
      ]
caxis_its = CAXIS_ITS()

class CAXIS_PSM(Structure):        # 3/ID:105  Prestress method
   _fields_ = [
         ('m_id0', c_int),         #        ident=105
         ('m_idt', c_int),         #        Identifier of Tendon
         ('m_type', c_int),        #        Type of Spline geometry
         ('m_nsp', c_int),         #        Number of tendon elements
         ('m_id5', c_int),         #        Placement of tendons
         ('m_jack', c_int),        #        Jacking procedure
         ('m_lire', c_int),        #        Sides for jacking
         ('m_iba', c_int * 3),     #        Construction stage identifiers
         ('m_nrsv', c_int),        #        number of jacking method
         ('m_dummy', c_int * 5),   #        reserved
         ('m_fak', c_float),       #        factor for prestress
         ('m_litz', c_float),      #        partial number of strands
         ('m_frsp', c_float * 2),  # [1001] Length controls for free tendon geometry
         ('m_zsp', c_float * 2),   # [1011] Distances of tendon to extreme fiber upper/lower
         ('m_textl',  c_int * 17)  #        Designation of layer of Tendons
      ]
caxis_psm = CAXIS_PSM()

class CAXIS_PSP(Structure):        # 3/ID:106  Prestress placements
   _fields_ = [
         ('m_id0', c_int),         #        ident=106
         ('m_typ', c_int),         #        Type of placement
         ('m_id2', c_int),         #        Type of station data (bitpattern)
         ('m_id3', c_int),         #        reserved
         ('m_id4', c_int),         #        reserved
         ('m_id5', c_int),         #        reserved
         ('m_s', c_float),         #        Station along axis
         ('m_zt', c_float),        # [1011] Distances of tendon to extreme fiber upper/lower
         ('m_dzt', c_float)        #        inclination of tendon to axis
      ]
caxis_psp = CAXIS_PSP()

class CAXIS_PLC(Structure):        # 3/ID:107  Placement at axis position
   _fields_ = [
         ('m_id0', c_int),         #        ident=107
         ('m_ids', c_int),         #        Enum of secondary axis
         ('m_typ', c_int),         #        properties of this placement
         ('m_npt', c_int),         #        point number
         ('m_grp', c_int),         #        group number behind that placement
         ('m_nos', c_int * 2),     #        Number of section before and behind that placement
         ('m_ib0', c_int),         #        general bit-mask
         ('m_idp', c_int),         #        identifier of this placement
         ('m_segt', c_int),        #        identifier of a segment see (900/0) behind that placement
         ('m_res', c_int * 6),     #        reserved
         ('m_s', c_float),         #        Parameter s of this section
         ('m_y', c_float),         # [1001] additional transverse offset
         ('m_z', c_float),         # [1001] additional vertical offset
         ('m_alf', c_float),       # [   5] Rotation about global Z
         ('m_alfx', c_float),      # [   5] Rotation about local axis x
         ('m_alfy', c_float),      # [   5] Rotation about transverse y
         ('m_alfz', c_float),      # [   5] Rotation about vertical   z
         ('m_incr', c_float),      # [   5] Inclination to the right +y
         ('m_incl', c_float),      # [   5] Inclination to the left  -y
         ('m_srule', c_int * 5),   #        Formula string to evaluate the value S
         ('m_text',  c_int * 17)   #        Designation of placement
      ]
caxis_plc = CAXIS_PLC()

class CAXIS_OPT(Structure):        # 3/ID:10107  Placement options
   _fields_ = [
         ('m_id0', c_int),         #        ident=10107
         ('m_a_filter', c_int),    #        Filter for axis
         ('m_t_filter', c_int)     #        Filter for axis type
      ]
caxis_opt = CAXIS_OPT()

class CAXIS_PRP(Structure):        # 3/ID:110  General properties of axis
   _fields_ = [
         ('m_id0', c_int),         #        ident=110
         ('m_name', c_int * 4),    #        Name of this item
         ('m_typ', c_int),         #        Continuity Type of this data point
         ('m_s_val', c_float * 5), #        Parameter s of this section and values
         ('m_srule', c_int * 5),   #        Formula string to evaluate the value S
         ('m_vrule', c_int * 10),  #        Formula string to evaluate the value VAL
         ('m_dvrule', c_int * 10)  #        Formula string to evaluate the value dVAL/dS
      ]
caxis_prp = CAXIS_PRP()

class CGAXD_ATB(Structure):        # 3/ID:121  Geometric segments of axis plan view (double precision)
   _fields_ = [
         ('m_id0', c_int),         #        ident=121
         ('m_id1', c_int),         #        specification type
         ('m_id2', c_int),         #        type of transition curve to be used
         ('m_id3', c_int),         #        reserved
         ('m_s', c_double),        #        Station value at tangent
         ('m_l', c_double * 5),    # [1001] Length of segment
         ('m_r', c_double * 5),    # [1001] Radius mid & start & end
         ('m_xyz', c_double * 3),  # [1001] Startpoint of tangent
         ('m_dir', c_double * 3),  #        Tangential direction
         ('m_d', c_double * 2),    # [1001] Distance to point on curve (start/end)
         ('m_tau', c_double),      # [   5] deflection angle
         ('m_txt0', c_int),        #        reserved
         ('m_txt', c_int)          #        Identifier of this sequence
      ]
cgaxd_atb = CGAXD_ATB()

class CGAXD_VTB(Structure):        # 3/ID:122  Geometric properties for axis heights (double precision)
   _fields_ = [
         ('m_id0', c_int),         #        ident=122
         ('m_id1', c_int),         #        specification type
         ('m_id2', c_int),         #        reserved
         ('m_id3', c_int),         #        reserved
         ('m_s', c_double),        #        Parameter s along the axis
         ('m_h', c_double),        # [1001] Height of gradient polygon
         ('m_r', c_double),        # [1001] Radius of curvature at this point
         ('m_x', c_double),        # [1001] Calculated true length along the axis
         ('m_t', c_double)         # [1001] Calculated secant length along the axis
      ]
cgaxd_vtb = CGAXD_VTB()

class CGAXD_GEO(Structure):        # 3/ID:18?  Geometric properties
   _fields_ = [
         ('m_iln', c_int),         #        Code of geometry
         ('m_id1', c_int),         #        reserved
         ('m_gpg', c_double),      # [1001] geometry parameter 1
         ('m_gpa', c_double),      # [1001] geometry parameter 2
         ('m_dd', c_double),       # [1001] arc length
         ('m_s1', c_double),       #        parameter s on start
         ('m_xyz1', c_double * 3), # [1001] Ordinate of start
         ('m_dxyz1', c_double * 3),#        Tangent of start
         ('m_rg1', c_double),      # [1009] in-plane curvature
         ('m_ra1', c_double),      # [1009] vertical curvature
         ('m_s2', c_double),       #        parameter s on end
         ('m_xyz2', c_double * 3), # [1001] Ordinate of endpoint
         ('m_dxyz2', c_double * 3),#        Tangent of endpoint
         ('m_rg2', c_double),      # [1009] in-plane curvature
         ('m_ra2', c_double),      # [1009] vertical curvature
         ('m_xat', c_double)       # [1001] relat. startordinate
      ]
cgaxd_geo = CGAXD_GEO()

class CGAXD_NKN(Structure):        # 3/ID:190  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=190
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_double * 256)   #        Knot-Vector
      ]
cgaxd_nkn = CGAXD_NKN()

class CGAXD_CPT(Structure):        # 3/ID:191  Control point of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID=191
         ('m_id1', c_int),         #        reserved
         ('m_w', c_double),        #        Weight
         ('m_xyz', c_double * 3),  # [1001] Coordinates
         ('m_dir', c_double * 3)   #        upward direction
      ]
cgaxd_cpt = CGAXD_CPT()

class CGAXD_PT(Structure):         # 3/ID:192  Data point on curve
   _fields_ = [
         ('m_iln', c_int),         #        ID=192
         ('m_id1', c_int),         #        specification type
         ('m_s', c_double),        #        Parameter along curve
         ('m_xyz', c_double * 3),  # [1001] Coordinates
         ('m_dir', c_double * 3)   #        direction
      ]
cgaxd_pt = CGAXD_PT()

class CGAXD_ARC(Structure):        # 3/ID:193  Circular Arc
   _fields_ = [
         ('m_iln', c_int),         #        ID=193
         ('m_idf', c_int),         #        Definition selected
         ('m_r', c_double),        # [1001] Radius of arc
         ('m_xyz', c_double * 3),  # [1001] Coordinates of center
         ('m_dir', c_double * 3),  #        upward direction of plane
         ('m_xyza', c_double * 3), # [1001] optional start point of arc
         ('m_xyze', c_double * 3)  # [1001] optional end point of arc
      ]
cgaxd_arc = CGAXD_ARC()

class CAXIS_TRL(Structure):        # 3/ID:300  Properties for train loading
   _fields_ = [
         ('m_id0', c_int),         #        ident 300
         ('m_nra', c_int),         #        Number of the lane (0:99)
         ('m_nrs', c_int),         #        Number of the segment
         ('m_btyp', c_int),        #        Literal of default type
         ('m_sa', c_float),        #        Parameter s of start of this section
         ('m_se', c_float),        #        Parameter s of end of this section
         ('m_yca', c_float),       # [1001] Center ordinate of lane at SA
         ('m_yce', c_float),       # [1001] Center ordinate of lane at SE
         ('m_yra', c_float),       # [1001] Right boundary at SA of lane area
         ('m_yre', c_float),       # [1001] Right boundary at SE of lane area
         ('m_yla', c_float),       # [1001] Left boundary at SA of lane area
         ('m_yle', c_float),       # [1001] Left boundary at SE of lane area
         ('m_l', c_float),         # [1001] Reference length for impact factor
         ('m_hsa', c_float),       # [1001] Total height of traffic lane above axis at SA
         ('m_hse', c_float),       # [1001] Total height of traffic lane above axis at SE
         ('m_inca', c_float),      # [   5] Inclination within lane at SA
         ('m_ince', c_float),      # [   5] Inclination within lane at SE
         ('m_heff', c_float),      # [1001] Height of rail and sleeper construction
         ('m_beff', c_float),      # [1001] Effective length of sleeper
         ('m_deff', c_float),      # [1001] Width of sleepers
         ('m_incd', c_float),      #        Inclination of load distribution (e.g. 1:4)
         ('m_asl', c_float)        # [1001] Distance of Sleepers or mounting points
      ]
caxis_trl = CAXIS_TRL()

class CTEND(Structure):            # 4/ID:0  Prestressing Schemes
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_key', c_int),         #        Control bits + Info
         ('m_id2', c_int),         #        reserved
         ('m_txt',  c_int * 17)    #        Main Designation of company and scheme
      ]
ctend = CTEND()

class CTEND_1(Structure):          # 4/ID:1  Tendon of Prestressing Schemes
   _fields_ = [
         ('m_id0', c_int),         #        identifier 1
         ('m_mnr', c_int),         #        Material number of Prestressing Steel
         ('m_id2', c_int),         #        reserved
         ('m_zv', c_float),        # [1028] Nominal force
         ('m_az', c_float),        # [1020] Area of tendon
         ('m_rnli', c_float),      #        Number or wires
         ('m_sls', c_float),       # [  16] Slip at anchor
         ('m_slk', c_float),       # [  16] Slip at coupling
         ('m_slf', c_float),       # [  16] Slip at fixed end
         ('m_vls', c_float),       #        Loss at anchor
         ('m_vlk', c_float),       #        Loss at coupling
         ('m_vlf', c_float),       #        Loss at fixed end
         ('m_dls', c_float),       # [1001] Straight at anchor
         ('m_dlk', c_float),       # [1001] Straight at coupling
         ('m_dlf', c_float),       # [1001] Straight at fixed end
         ('m_di', c_float),        # [1023] inner diameter of duct
         ('m_da', c_float),        # [1023] outer diamtere of duct
         ('m_rmin', c_float),      # [1001] minimum radius
         ('m_beta', c_float * 2),  # [  17] unintended angles
         ('m_rmue', c_float * 2),  #        Friction coefficients
         ('m_exz', c_float),       # [1011] max exzentricity
         ('m_eachs', c_float),     # [1011] distance between
         ('m_erand', c_float),     # [1011] distance to outer edge
         ('m_block', c_float * 8), #        reserved extra data
         ('m_txt',  c_int * 17)    #        Designation of tendon
      ]
ctend_1 = CTEND_1()

class CTEND_2(Structure):          # 4/ID:2  Anchor of Prestressing Schemes
   _fields_ = [
         ('m_id0', c_int),         #        identifier 2
         ('m_id1', c_int),         #        Type of anchor
         ('m_typ', c_int),         #        Type of anchor geometry
         ('m_anker', c_float * 16),#        Data
         ('m_txt',  c_int * 17)    #        Designation of anchor
      ]
ctend_2 = CTEND_2()

class CTEND_3(Structure):          # 4/ID:3  Jack of Prestressing Schemes
   _fields_ = [
         ('m_id0', c_int),         #        identifier 2
         ('m_id1', c_int),         #        reserved
         ('m_typ', c_int),         #        Type of jack
         ('m_jack', c_float * 16), #        Data
         ('m_txt',  c_int * 17)    #        Designation of jack
      ]
ctend_3 = CTEND_3()

class CAREA(Structure):            # 5/ID:0  Geometric Area
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_ng', c_int),          #        Type of surface representation
         ('m_gid1', c_int),        #        Axis identifier of first reference axis
         ('m_gid2', c_int),        #        Axis identifier of second reference axis
         ('m_mgri', c_int),        #        number of data/control points in s of mesh
         ('m_ngri', c_int),        #        number of data/control points in t of mesh
         ('m_mspl', c_int),        #        degree of B-spline in s direction
         ('m_nspl', c_int),        #        degree of B-spline in t direction
         ('m_sflg', c_int),        #        property options of surface
         ('m_t', c_float * 4 * 3), #        Transformation
         ('m_par', c_float * 16),  #        additional Parameters
         ('m_box', c_float * 3 * 2), # [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
         ('m_text',  c_int * 17)   #        Designation of Line
      ]
carea = CAREA()

class CAREA_CPT(Structure):        # 5/ID:10  Control points of area
   _fields_ = [
         ('m_id', c_int),          #        Identification of control point data = 10
         ('m_xpar', c_float * 9999)  #        spline grid and coefficients
      ]
carea_cpt = CAREA_CPT()

class CAREA_PTS(Structure):        # 5/ID:11  AreaPointonSurface
   _fields_ = [
         ('m_id', c_int),          #        Identification of surface description = 11
         ('m_it', c_int),          #        Type of point
         ('m_m', c_int),           #        Rasterlocation of mesh (0 < m < mgri )
         ('m_n', c_int),           #        Rasterlocation of mesh (0 < n < ngri )
         ('m_w', c_float),         #        the weight of NURBS control point
         ('m_x', c_float),         # [1001] X-ordinate
         ('m_y', c_float),         # [1001] Y-ordinate
         ('m_z', c_float),         # [1001] Z-ordinate
         ('m_t', c_float)          # [1010] Thickness
      ]
carea_pts = CAREA_PTS()

class CAREA_CPI(Structure):        # 5/ID:12  COONsPatchInfo
   _fields_ = [
         ('m_id', c_int),          #        Identification of COONs blending edges 12
         ('m_it', c_int),          #        Type of blending
         ('m_iu0', c_int),         #        No of geometry line for u=umin (left)
         ('m_iu1', c_int),         #        No of geometry line for u=umax (right)
         ('m_iv0', c_int),         #        No of geometry line for v=vmin (lower)
         ('m_iv1', c_int),         #        No of geometry line for v=vmax (upper)
         ('m_sp', c_float * 4 * 3),#        Length parameters for the edges iu0,iu1,iv0,iv1
         ('m_uv', c_float * 2 * 2),#        umin,umax,vmin,vmax of the parameter plane
         ('m_cxyz', c_float * 4 * 3), #        Coordinates of the corner points C1,C2,C3,C4
         ('m_tinc', c_float * 8 * 3), #        inclinations for a bicubic patch as vectors
         ('m_twist', c_float * 4 * 3)  #        Twist of x,y,z-Ordinate at corner C1 (0,0)
      ]
carea_cpi = CAREA_CPI()

class CAREA_NKN(Structure):        # 5/ID:9?  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_float * 256)    #        Knot-Vector
      ]
carea_nkn = CAREA_NKN()

class CGARD_PTS(Structure):        # 5/ID:290  AreaPointonSurface
   _fields_ = [
         ('m_id', c_int),          #        Id = 290
         ('m_it', c_int),          #        Type of point
         ('m_m', c_int),           #        Rasterlocation of mesh (0 < m < mgri )
         ('m_n', c_int),           #        Rasterlocation of mesh (0 < n < ngri )
         ('m_w', c_double),        #        the weight of NURBS control point
         ('m_x', c_double),        # [1001] X-ordinate
         ('m_y', c_double),        # [1001] Y-ordinate
         ('m_z', c_double),        # [1001] Z-ordinate
         ('m_t', c_double)         # [1010] Thickness
      ]
cgard_pts = CGARD_PTS()

class CGARD_NKU(Structure):        # 5/ID:291  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_double * 256)   #        Knot-Vector
      ]
cgard_nku = CGARD_NKU()

class CGARD_NKV(Structure):        # 5/ID:292  Knots of a Nurb
   _fields_ = [
         ('m_iln', c_int),         #        ID
         ('m_deg', c_int),         #        Order of Spline
         ('m_s', c_double * 256)   #        Knot-Vector
      ]
cgard_nkv = CGARD_NKV()

class CCON_0(Structure):           # 8/ID:0  Connection Headder
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 0
         ('m_typ', c_int),         #        Type of connection
         ('m_mat', c_int),         #        Materialnumber for all plates
         ('m_text',  c_int * 17)   #        designation of connection
      ]
ccon_0 = CCON_0()

class CCON_BOL(Structure):         # 8/ID:1  Definition of Bolts
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 1
         ('m_typ', c_int),         #        Type of hole
         ('m_mat', c_int),         #        Materialdesignation of bolt
         ('m_d', c_float),         # [1011] Diameter of bolt
         ('m_norm', c_int * 4),    #        Designation of product code
         ('m_text',  c_int * 17)   #        designation of bolt
      ]
ccon_bol = CCON_BOL()

class CCON_WEL(Structure):         # 8/ID:2  Definition of Weldings
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 2
         ('m_typ', c_int),         #        Type of weld
         ('m_mat', c_int),         #        Materialnumber of weld (not used)
         ('m_t', c_float),         # [1011] Thickness of weld
         ('m_aw', c_float),        #        Reduction factor
         ('m_text',  c_int * 17)   #        designation of weld
      ]
ccon_wel = CCON_WEL()

class CCON_CLE(Structure):         # 8/ID:3  Definition of Cleats (Angle/Latch)
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 3
         ('m_typ', c_int),         #        Enum of type (angle/latch not really enforced)
         ('m_mat', c_int),         #        Material number of the plate
         ('m_bol', c_int * 2),     #        id of bolts
         ('m_nbb', c_int * 2),     #        Number of bolts in width direction
         ('m_nbl', c_int * 2),     #        Number of bolts in angle directions 1 & 2
         ('m_t', c_float),         # [1011] Thickness of cleat
         ('m_b', c_float),         # [1011] Width/Height of cleat
         ('m_l', c_float * 2),     # [1011] Length of angles
         ('m_w', c_float * 8),     # [1011] Distances
         ('m_a', c_float * 2),     # [1011] weld thickness for NBL(i) if welding is used
         ('m_tf', c_float),        # [1011] Thickness of backplate
         ('m_text',  c_int * 17)   #        designation of element
      ]
ccon_cle = CCON_CLE()

class CCON_MEM(Structure):         # 8/ID:10  Connected Member data
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 10
         ('m_nr', c_int),          #        Enumeration or designation of member
         ('m_typ', c_int),         #        Type of connection bitpattern
         ('m_nrq', c_int),         #        Number of section
         ('m_wtyp', c_int),        #        id of the web connection
         ('m_utyp', c_int),        #        id of the upper flange connection
         ('m_ltyp', c_int),        #        id of the lower flange connection
         ('m_l', c_float),         # [1001] length of member
         ('m_aw', c_float),        # [1011] weld thickness for web connection
         ('m_au', c_float),        # [1011] weld thickness for upper flange connection
         ('m_al', c_float),        # [1011] weld thickness for lower flange connection
         ('m_dd', c_float),        # [1011] Distance value of endpoint to central node
         ('m_d', c_float * 3),     #        Direction vector to beam axis in the
         ('m_roty', c_float),      # [   5] Angle of end plate y-rotation
         ('m_rotz', c_float),      # [   5] Angle of end plate z-rotation
         ('m_cutu', c_float),      # [1011] Cut out height for upper flange
         ('m_cutl', c_float),      # [1011] Cut out height for lower flange
         ('m_clu', c_float),       # [1011] Cut out length for upper flange
         ('m_cld', c_float),       # [1011] Cut out length for lower flange
         ('m_voute', c_float * 4 * 2)  # [1011] Voute [lenght,height] for
      ]
ccon_mem = CCON_MEM()

class CCON_END(Structure):         # 8/ID:11  Endplate of Beam
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 11
         ('m_typ', c_int),         #        Type of end plate
         ('m_mat', c_int),         #        Materialnumber of endplate
         ('m_bolt', c_int),        #        Identifier of bolt type
         ('m_nbr', c_int),         #        Number of bolts in height direction
         ('m_nbc', c_int),         #        Number of bolts in width direction
         ('m_b', c_float),         # [1011] Width of plate
         ('m_h', c_float),         # [1011] Total plate height
         ('m_mx', c_float),        # [1011] Eccentricity
         ('m_t', c_float),         # [1011] Thickness of plate
         ('m_hb', c_float * 5),    # [1011] Height for bolts
         ('m_w', c_float * 2),     # [1011] Width for bolts
         ('m_htbp', c_float * 4)   # [1011] Height and thickness values for back plates
      ]
ccon_end = CCON_END()

class CCON_PIN(Structure):         # 8/ID:12  Pinned plate of Beam
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 13
         ('m_mat', c_int),         #        Materialnumber of pin plate
         ('m_mats', c_int),        #        Materialnumber of support plate
         ('m_matp', c_int),        #        Materialnumber of pin
         ('m_dp', c_float),        # [1011] Diameter of pin
         ('m_dh', c_float),        # [1011] Diameter of hole
         ('m_tp', c_float),        # [1011] Thickness pin plate
         ('m_tsup', c_float),      # [1011] Thickness sup plate
         ('m_c', c_float),         # [1011] gap between plates
         ('m_e1', c_float),        # [1011] eccentricity 1
         ('m_e2', c_float)         # [1011] eccentricity 2
      ]
ccon_pin = CCON_PIN()

class CCON_PLT(Structure):         # 8/ID:20  Additional plates in connection
   _fields_ = [
         ('m_ids', c_int),         #        Identification = 20
         ('m_typ', c_int),         #        Type of plate
         ('m_mat', c_int),         #        Number of material
         ('m_t', c_float),         # [1011] Thickness of plate
         ('m_edge', c_float * 8 * 5)  # [1011] Local coordinates, weldid, weldthickness
      ]
ccon_plt = CCON_PLT()

class CSECT(Structure):            # 9/NR:0  SectionalValues (total section)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_mno', c_int),         #        Materialnumber of sections
         ('m_mrf', c_int),         #        Materialnumber of Reinforcement
         ('m_a', c_float),         # [1012] Area
         ('m_ay', c_float),        # [1012] Sheardeformation area Y
         ('m_az', c_float),        # [1012] Sheardeformation area Z
         ('m_it', c_float),        # [1014] Torsional moment of inertia
         ('m_iy', c_float),        # [1014] Moments of inertia y-y
         ('m_iz', c_float),        # [1014] Moments of inertia z-z
         ('m_iyz', c_float),       # [1014] Moments of inertia y-z
         ('m_ys', c_float),        # [1011] y-Ordinate Center of elasticity
         ('m_zs', c_float),        # [1011] z-Ordinate Center of elasticity
         ('m_ysc', c_float),       # [1011] y-Ordinate of Shear-Center
         ('m_zsc', c_float),       # [1011] z-Ordinate of Shear-Center
         ('m_em', c_float),        # [1090] Elasticity Modulus
         ('m_gm', c_float),        # [1090] Shear Modulus
         ('m_gam', c_float)        # [1091] Nominal weight
      ]
csect = CSECT()

class CSECT_EFF(Structure):        # 9/NR:1  SectionalValues (effective section)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_mno', c_int),         #        Materialnumber of sections
         ('m_mrf', c_int),         #        Materialnumber of Reinforcement
         ('m_a', c_float),         # [1012] Area
         ('m_ay', c_float),        # [1012] Sheardeformation area Y
         ('m_az', c_float),        # [1012] Sheardeformation area Z
         ('m_it', c_float),        # [1014] Torsional moment of inertia
         ('m_iy', c_float),        # [1014] Moments of inertia y-y
         ('m_iz', c_float),        # [1014] Moments of inertia z-z
         ('m_iyz', c_float),       # [1014] Moments of inertia y-z
         ('m_ys', c_float),        # [1011] y-Ordinate Center of elasticity
         ('m_zs', c_float),        # [1011] z-Ordinate Center of elasticity
         ('m_ysc', c_float),       # [1011] y-Ordinate of Shear-Center
         ('m_zsc', c_float),       # [1011] z-Ordinate of Shear-Center
         ('m_em', c_float),        # [1090] Elasticity Modulus
         ('m_gm', c_float),        # [1090] Shear Modulus
         ('m_gam', c_float)        # [1091] Nominal weight
      ]
csect_eff = CSECT_EFF()

class CSECT_PAR(Structure):        # 9/NR:2  SectionalValues (total part of section)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_mno', c_int),         #        Materialnumber of sections
         ('m_mrf', c_int),         #        Materialnumber of Reinforcement
         ('m_a', c_float),         # [1012] Area
         ('m_ay', c_float),        # [1012] Sheardeformation area Y
         ('m_az', c_float),        # [1012] Sheardeformation area Z
         ('m_it', c_float),        # [1014] Torsional moment of inertia
         ('m_iy', c_float),        # [1014] Moments of inertia y-y
         ('m_iz', c_float),        # [1014] Moments of inertia z-z
         ('m_iyz', c_float),       # [1014] Moments of inertia y-z
         ('m_ys', c_float),        # [1011] y-Ordinate Center of elasticity
         ('m_zs', c_float),        # [1011] z-Ordinate Center of elasticity
         ('m_ysc', c_float),       # [1011] y-Ordinate of Shear-Center
         ('m_zsc', c_float),       # [1011] z-Ordinate of Shear-Center
         ('m_em', c_float),        # [1090] Elasticity Modulus
         ('m_gm', c_float),        # [1090] Shear Modulus
         ('m_gam', c_float)        # [1091] Nominal weight
      ]
csect_par = CSECT_PAR()

class CSECT_PEF(Structure):        # 9/NR:3  SectionalValues (effective part of section)
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_mno', c_int),         #        Materialnumber of sections
         ('m_mrf', c_int),         #        Materialnumber of Reinforcement
         ('m_a', c_float),         # [1012] Area
         ('m_ay', c_float),        # [1012] Sheardeformation area Y
         ('m_az', c_float),        # [1012] Sheardeformation area Z
         ('m_it', c_float),        # [1014] Torsional moment of inertia
         ('m_iy', c_float),        # [1014] Moments of inertia y-y
         ('m_iz', c_float),        # [1014] Moments of inertia z-z
         ('m_iyz', c_float),       # [1014] Moments of inertia y-z
         ('m_ys', c_float),        # [1011] y-Ordinate Center of elasticity
         ('m_zs', c_float),        # [1011] z-Ordinate Center of elasticity
         ('m_ysc', c_float),       # [1011] y-Ordinate of Shear-Center
         ('m_zsc', c_float),       # [1011] z-Ordinate of Shear-Center
         ('m_em', c_float),        # [1090] Elasticity Modulus
         ('m_gm', c_float),        # [1090] Shear Modulus
         ('m_gam', c_float)        # [1091] Nominal weight
      ]
csect_pef = CSECT_PEF()

class CSECT_ADD(Structure):        # 9/NR:4  SectionalValuesShear , Temperature
   _fields_ = [
         ('m_id', c_int),
         ('m_stype', c_int),
         ('m_mrf', c_int),         #        Materialnumber of Stirup-Reinforcement
         ('m_at', c_float),        # [ 107] Elongationkoefficient for Temperature
         ('m_ymin', c_float),      # [1011] Minimum Ordinate of section to center ys
         ('m_ymax', c_float),      # [1011] Maximum Ordinate of section to center ys
         ('m_zmin', c_float),      # [1011] Minimum Ordinate of section to center zs
         ('m_zmax', c_float),      # [1011] Maximum Ordinate of section to center zs
         ('m_tmin', c_float),      # [1011] minimum thickness
         ('m_tmax', c_float),      # [1011] maximum thickness
         ('m_wt', c_float),        # [1018] maximum tau for Torsion MT=1
         ('m_wvy', c_float),       # [1017] maximum tau for Shear VY=1
         ('m_wvz', c_float),       # [1017] maximum tau for Shear VZ=1
         ('m_wt2', c_float),       # [1018] maximum tau for sekundary Torsion
         ('m_ak', c_float),        # [1012] kernel area for Torsion
         ('m_ayz', c_float),       # [1012] Shear deviation area
         ('m_ab', c_float),        # [1012] pure concrete area
         ('m_levy', c_float),      # [1011] minimum lever for cracked shear Vy
         ('m_levz', c_float),      # [1011] minimum lever for cracked shear Vz
         ('m_elvy', c_float),      # [  17] elastic shear flux for Vy = Sy-max/Iz
         ('m_elvz', c_float),      # [  17] elastic shear flux for Vz = Sz-max/Iy
         ('m_ymine', c_float),     # [1011] Minimum Ordinate of effective section
         ('m_ymaxe', c_float),     # [1011] Maximum Ordinate of effective section
         ('m_zmine', c_float),     # [1011] Minimum Ordinate of effective section
         ('m_zmaxe', c_float)      # [1011] Maximum Ordinate of effective section
      ]
csect_add = CSECT_ADD()

class CSECT_WAR(Structure):        # 9/NR:5  SectionalValuesWarping
   _fields_ = [
         ('m_id', c_int),          #        Identification = 5
         ('m_i_1', c_int),         #        unused
         ('m_i_2', c_int),         #        unused
         ('m_ayyy', c_float),      # [1015] Integrals on section
         ('m_ayyz', c_float),      # [1015] Integrals on section
         ('m_ayzz', c_float),      # [1015] Integrals on section
         ('m_azzz', c_float),      # [1015] Integrals on section
         ('m_awy', c_float),       # [1015] Integrals on section
         ('m_awz', c_float),       # [1015] Integrals on section
         ('m_awyy', c_float),      # [1016] Integrals on section
         ('m_awzz', c_float),      # [1016] Integrals on section
         ('m_cm', c_float),        # [1016] Warping resistance
         ('m_cms', c_float),       # [1014] Warping Shear resist.
         ('m_wmin', c_float),      # [1012] Minimum warping
         ('m_wmax', c_float),      # [1012] Maximum warping
         ('m_fysw', c_float),      # [1012] Shear VY-MT2 area
         ('m_fzsw', c_float),      # [1012] Shear VZ-MT2 area
         ('m_ipsc', c_float)       # [1014] polar inertia at SC
      ]
csect_war = CSECT_WAR()

class CSECT_PLA(Structure):        # 9/NR:6  SectionalPlasticForces
   _fields_ = [
         ('m_id', c_int),          #        Identification = 6
         ('m_ibc', c_int),         #        Buckling curve
         ('m_ib', c_int),          #        Control
         ('m_wpn', c_float),       # [1101] Normal force
         ('m_wpvy', c_float),      # [1102] Y-Shear force
         ('m_wpvz', c_float),      # [1102] Y-Shear force
         ('m_wpmt', c_float),      # [1103] Torsional moment
         ('m_wpmy', c_float),      # [1104] Bending moment My
         ('m_wpmz', c_float),      # [1104] Bending moment Mz
         ('m_ysp', c_float),       # [1001] Plastic center
         ('m_zsp', c_float),       # [1001] Plastic center
         ('m_wpmb', c_float),      # [1105] warping moment Mb
         ('m_wpt2', c_float)       # [1103] 2nd torsional moment
      ]
csect_pla = CSECT_PLA()

class CSECT_DES(Structure):        # 9/NR:7  SectionalValuesDesign
   _fields_ = [
         ('m_id', c_int),          #        Identification = 7
         ('m_mnr', c_int),         #        used reference material
         ('m_ibc', c_int),         #        buckling curve index (see 009/NR:6)
         ('m_a', c_float),         # [1012] Area
         ('m_ay', c_float),        # [1012] Sheardeformation area Y
         ('m_az', c_float),        # [1012] Sheardeformation area Z
         ('m_it', c_float),        # [1014] Torsional moment of inertia
         ('m_iy', c_float),        # [1014] Moments of inertia y-y
         ('m_iz', c_float),        # [1014] Moments of inertia z-z
         ('m_iyz', c_float),       # [1014] Moments of inertia y-z
         ('m_ys', c_float),        # [1011] y-Ordinate Center of gravity
         ('m_zs', c_float),        # [1011] z-Ordinate Center of gravity
         ('m_ysc', c_float),       # [1011] y-Ordinate of Shear-Center
         ('m_zsc', c_float),       # [1011] z-Ordinate of Shear-Center
         ('m_em', c_float),        # [1090] Elasticity Modulus/safety
         ('m_gm', c_float),        # [1090] Shear Modulus/safety
         ('m_gam', c_float)        # [1091] Nominal weight
      ]
csect_des = CSECT_DES()

class CSECT_PRE(Structure):        # 9/NR:8  SectionalForcesPrestress
   _fields_ = [
         ('m_id', c_int),          #        Identification = 8
         ('m_itp', c_int),         #        subtype of information = 0
         ('m_its', c_int),         #        source of values
         ('m_n', c_float),         # [1101] Normal force
         ('m_my', c_float),        # [1104] Bending moment My
         ('m_mz', c_float),        # [1104] Bending moment Mz
         ('m_ea', c_float),        # [1101] tangential stiffnes E*A
         ('m_eay', c_float),       # [1105] tangential stiffnes E*A*z*z
         ('m_eaz', c_float),       # [1105] tangential stiffnes E*A*y*y
         ('m_eayz', c_float),      # [1105] tangential stiffnes E*A*y*z
         ('m_yse', c_float),       # [1011] elastic tangential center ys
         ('m_zse', c_float),       # [1011] elastic tangential center zs
         ('m_ncm', c_float),       # [1101] maximum compressive force
         ('m_ntm', c_float)        # [1101] maximum tensile force
      ]
csect_pre = CSECT_PRE()

class CSECT_GV(Structure):         # 9/NR:8  SectionalGeometricValues
   _fields_ = [
         ('m_id', c_int),          #        Identification = 8
         ('m_itp', c_int),         #        subtype of information = 2
         ('m_mno', c_int),         #        Materialnumber (0=total section)
         ('m_uo', c_float),        # [1011] outer perimeter
         ('m_ui', c_float),        # [1011] inner perimeter
         ('m_tmin', c_float),      # [1011] minimum thickness
         ('m_tmax', c_float),      # [1011] maximum thickness
         ('m_ktz', c_float),       # [   8] total weight factor
         ('m_uom', c_float),       # [1011] outer effect.perimeter
         ('m_uim', c_float),       # [1011] inner effect.perimeter
         ('m_aro', c_float),       # [1012] Outer total gross area
         ('m_ar', c_float),        # [1012] total gross area
         ('m_ipm', c_float),       # [1014] rotational inertia      gam*Ip
         ('m_iym', c_float),       # [1014] sectional mass inertia  gam*Iy
         ('m_izm', c_float),       # [1014] sectional mass inertia  gam*Iz
         ('m_iyzm', c_float),      # [1014] sectional mass inertia  gam*Iyz
         ('m_ysm', c_float),       # [1011] true mass gravity center
         ('m_zsm', c_float),       # [1011] true mass gravity center
         ('m_dw', c_float),        # [1011] effective thickness for creep/shrinkage
         ('m_uair', c_float)       # [1011] air contact perimeter
      ]
csect_gv = CSECT_GV()

class CSECT_TRA(Structure):        # 9/NR:8  SectionalAppliedTransformation
   _fields_ = [
         ('m_id', c_int),          #        Identification = 8
         ('m_itp', c_int),         #        subtype of information = 3
         ('m_i_2', c_int),         #        not used
         ('m_alf', c_float),       # [   5] rotation angle
         ('m_ytf', c_float),       # [1011] shift in y direction
         ('m_ztf', c_float)        # [1011] shift in z direction
      ]
csect_tra = CSECT_TRA()

class CSECT_LAY(Structure):        # 9/NR:9  SectionalReinforcementLayer  (LAY)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 9
         ('m_mnr', c_int),         #        Materialnumber + 1000*No of concrete \%
         ('m_inr', c_int),         #        Type/number of layer
         ('m_tnr', c_int),         #        Designation
         ('m_alow', c_float),      # [1020] Lower bound for area of layer
         ('m_ahig', c_float),      # [1020] Upper bound for area of layer
         ('m_asum', c_float),      # [1020] Sum of reference areas of layer
         ('m_afak', c_float),      #        maximum allowable factor of layer
         ('m_ys', c_float),        # [1011] center of layer
         ('m_zs', c_float),        # [1011] center of layer
         ('m_vas', c_float),       # [1020] Lower sequential total bound of layer area
         ('m_bas', c_float),       # [1020] Upper sequential total bound of layer area
         ('m_iy', c_float),        # [1014] 4th ord.areas (inertia)
         ('m_iz', c_float),        # [1014] 4th ord.areas (inertia)
         ('m_iyz', c_float),       # [1014] 4th ord.areas (inertia)
         ('m_emod', c_float),      # [1090] Elasticity-Modulus
         ('m_bets', c_float),      # [1092] yieldstress
         ('m_rl', c_float),        # [1011] torsional refer. length
         ('m_dmin', c_float),      # [1023] smallest used diameter
         ('m_dmax', c_float),      # [1023] largest  used diameter
         ('m_n', c_float),         # [1101] Normal force
         ('m_my', c_float),        # [1104] Bending moment My
         ('m_mz', c_float),        # [1104] Bending moment Mz
         ('m_ea', c_float),        # [1101] tangential stiffnes E*A
         ('m_eay', c_float),       # [1104] tangential stiffnes E*A*z
         ('m_eaz', c_float),       # [1104] tangential stiffnes E*A*y
         ('m_eayy', c_float),      # [1105] tangential stiffnes E*A*y*y
         ('m_eazz', c_float),      # [1105] tangential stiffnes E*A*z*z
         ('m_eayz', c_float),      # [1105] tangential stiffnes E*A*y*z
         ('m_nplc', c_float),      # [1101] maximum compressive force
         ('m_nplt', c_float)       # [1101] maximum tensile force
      ]
csect_lay = CSECT_LAY()

class CSECT_REC(Structure):        # 9/NR:10  SectiontypeRectangular T-Beam (SREC)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 10
         ('m_iq', c_int),          #        Identification of section
         ('m_ir', c_int),          #        Identification of reinforcement and origin
         ('m_h', c_float),         # [1011] total height
         ('m_b', c_float),         # [1011] width (of web)
         ('m_so', c_float),        # [1024] Boundary distance of upper reinforcement
         ('m_su', c_float),        # [1024] Boundary distance of lower reinforcement
         ('m_aso', c_float),       # [1020] reinforcement up
         ('m_asu', c_float),       # [1020] reinforcement down
         ('m_ho', c_float),        # [1011] height of plate
         ('m_bo', c_float),        # [1011] width  of plate
         ('m_daso', c_float),      # [1023] reinf. Diameter up
         ('m_dasu', c_float),      # [1023] reinf. Diameter dn
         ('m_fkit', c_float),      #        <0 = factor for torsional inertia >0 = absolut value of torsion
         ('m_fkay', c_float),      #        <0 = factor for shear deformation area >0 = absolut value of sh
         ('m_fkaz', c_float),      #        <0 = factor for shear deformation area >0 = absolut value of sh
         ('m_ysmp', c_float),      # [1011] explicit location of shear center
         ('m_zssmp', c_float),     # [1011] explicit location of shear center
         ('m_ys', c_float),        # [1011] explicit location of reference point
         ('m_zs', c_float),        # [1011] explicit location of reference point
         ('m_phib', c_float),      # [   5] inclination of shear links
         ('m_beff', c_float),      # [1011] width of equivalent hollow section
         ('m_asbm', c_float),      #        Minimum shear reinf.
         ('m_a', c_float),         # [1011] spacing of reinforcements
         ('m_amin', c_float),      # [1011] minimum distance of single reinforcements
         ('m_amax', c_float),      # [1011] maximum distance of single reinforcements
         ('m_ss', c_float),        # [1024] Boundary distance of lateral reinforcement
         ('m_dass', c_float),      # [1023] reinf. Diameter side
         ('m_hmax', c_float),      # [1011] maximum mesh size for FE/fibre analysis
         ('m_betc', c_float),      #        friction coefficient
         ('m_mue', c_float)        #        friction in joint
      ]
csect_rec = CSECT_REC()

class CSECT_ANN(Structure):        # 9/NR:11  SectiontypeAnnular (SCIT)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 11
         ('m_ir', c_int),          #        Identification of section
         ('m_ir2', c_int),         #        Identification of reinforcement
         ('m_ro', c_float),        # [1011] outer radius
         ('m_ri', c_float),        # [1011] inner radius
         ('m_ros', c_float),       # [1011] outer reinf radius
         ('m_ris', c_float),       # [1011] inner reinf radius
         ('m_aso', c_float),       # [1020] outer reinforcement
         ('m_asi', c_float),       # [1020] inner reinforcement
         ('m_daso', c_float),      # [1023] reinf. Diameter
         ('m_amax', c_float),      # [1011] maximum distance of single reinforcements
         ('m_asbm', c_float),      # [1021] Minimum shear reinf.
         ('m_hmax', c_float),      # [1011] maximum mesh size for FE/fibre analysis
         ('m_fkit', c_float),      #        <0 = factor for torsional inertia >0 = absolut value of torsion
         ('m_fkay', c_float),      #        <0 = factor for shear deformation area >0 = absolut value of sh
         ('m_fkaz', c_float)       #        <0 = factor for shear deformation area >0 = absolut value of sh
      ]
csect_ann = CSECT_ANN()

class CSECT_TUB(Structure):        # 9/NR:11  SectiontypeTube (TUBE)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 11
         ('m_ir', c_int),          #        Identification of section = 2
         ('m_ir2', c_int),         #        property Bit
         ('m_d', c_float),         # [1011] Diameter
         ('m_t', c_float)          # [1011] thickness of tubes
      ]
csect_tub = CSECT_TUB()

class CSECT_CAB(Structure):        # 9/NR:11  SectiontypeCable (CABL)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 11
         ('m_ir', c_int),          #        Identification of section = 3
         ('m_ic', c_int),          #        sectiontype*256 + codeflag*64 + inlet type
         ('m_d', c_float),         # [1011] Diameter
         ('m_typ', c_int * 2),     #        Literal of type
         ('m_inl', c_int),         #        Literal of inlet
         ('m_nli', c_float),       #        no of strands
         ('m_ndr', c_float),       #        no of wires
         ('m_f', c_float),         #        fill factor
         ('m_k', c_float),         #        cable factor
         ('m_w', c_float),         #        weight factor
         ('m_ke', c_float),        #        loss factor
         ('m_zd', c_float),        # [1090] design  force
         ('m_zb', c_float),        # [1090] rupture force
         ('m_gam', c_float)        # [1188] weight
      ]
csect_cab = CSECT_CAB()

class CSECT_PRO(Structure):        # 9/NR:12  SectiontypeShape (PROF)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 12
         ('m_mno', c_int),         #        Materialnumber + 1000*imbedded Materialnumber
         ('m_ibit', c_int),        #        ityp + 64*iref + ivtp
         ('m_typ', c_int),         #        type of section
         ('m_z1', c_float),        #        nominal first size
         ('m_z2', c_float),        #        nominal second size
         ('m_z3', c_float),        #        thickness or weight selector
         ('m_alf', c_float),       # [   5] rotation angle
         ('m_it', c_float),        # [1014] tabul.Tors.Inertia
         ('m_ysc', c_float),       # [1011] tabul.shear center
         ('m_zsc', c_float),       # [1011] tabul.shear center
         ('m_h', c_float),         # [1011] height
         ('m_b', c_float),         # [1011] width
         ('m_s', c_float),         # [1011] thickness of web
         ('m_t', c_float),         # [1011] thickness of flange
         ('m_r1', c_float),        # [1011] radius
         ('m_r2', c_float),        # [1011] radius
         ('m_yoff', c_float),      # [1011] y coord. offset
         ('m_zoff', c_float),      # [1011] z coord. offset
         ('m_cm', c_float),        # [1016] tabul.warp.resist.
         ('m_wmin', c_float),      # [1012] charact. warping 1
         ('m_wmax', c_float),      # [1012] charact. warping 2
         ('m_wt', c_float),        # [1018] Torsional resist.
         ('m_ay', c_float),        # [1012] Shear area
         ('m_az', c_float),        # [1012] Shear area
         ('m_rid', c_int),         #        user defined ident
         ('m_wu1', c_float),       # [1011] bolt position 1
         ('m_wu2', c_float),       # [1011] bolt position 2
         ('m_wu3', c_float),       # [1011] bolt position 3
         ('m_yref', c_float),      # [1011] Coordinates of
         ('m_zref', c_float),      # [1011] Reference point
         ('m_b2', c_float),        # [1011] width lower part
         ('m_t2', c_float),        # [1011] lower flange thick.
         ('m_bez', c_int * 8),     #        character of shape
         ('m_vypl', c_float),      # [1102] plastic shear force Vy
         ('m_vzpl', c_float),      # [1102] plastic shear force Vz
         ('m_mtpl', c_float),      # [1103] plastic torsional   Mt
         ('m_mt2pl', c_float),     # [1103] plastic torsional   Mt2
         ('m_mbpl', c_float)       # [1103] plastic warpmoment  Mb
      ]
csect_pro = CSECT_PRO()

class CSECT_TBA(Structure):        # 9/NR:18  List of construction stages
   _fields_ = [
         ('m_id', c_int),          #        Identification = 18
         ('m_iba', c_int),         #        Headder of construction stages = 0
         ('m_ibd', c_int),         #        Number of materials over all construction stages
         ('m_ibat', c_int * 64)    #        List of external construction stage numbers
      ]
csect_tba = CSECT_TBA()

class CSECT_IBA(Structure):        # 9/NR:18  ConstructionStage (CS/BA)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 18
         ('m_iba', c_int),         #        number of construction stage BIRTH
         ('m_ibd', c_int),         #        number of construction stage DEATH
         ('m_txt',  c_int * 17)    #        Text
      ]
csect_iba = CSECT_IBA()

class CSECT_TXT(Structure):        # 9/NR:19  SectionText
   _fields_ = [
         ('m_id', c_int),          #        Identification = 19
         ('m_nr', c_int),          #        external construction stage number for CS separator
         ('m_ids', c_int),         #        Source/Selector flag
         ('m_txt',  c_int * 128)   #        Text
      ]
csect_txt = CSECT_TXT()

class CSECT_WLS(Structure):        # 9/NR:6?  SectionWorklaw Serviceability Analysis
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_n', c_int),           #        Normal force 0/00
         ('m_ntyp', c_int),        #        Type of law
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
csect_wls = CSECT_WLS()

class CSECT_WLU(Structure):        # 9/NR:7?  SectionWorklaw Ultimate Analysis
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_n', c_int),           #        Normal force 0/00
         ('m_ntyp', c_int),        #        Type of law
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
csect_wlu = CSECT_WLU()

class CSECT_CW(Structure):         # 9/NR:80  Hydrodynamic coefficients (WIND/Wave loading)
   _fields_ = [
         ('m_id', c_int),          #        Identification 80
         ('m_iref', c_int),        #        Reference of coefficients
         ('m_alf', c_int),         #        angle of attack in degrees
         ('m_cy', c_float),        #        wind reaction coefficient in y-direction
         ('m_cz', c_float),        #        wind reaction coefficient in z-direction
         ('m_ct', c_float),        #        wind reaction coefficient for torsional moment
         ('m_chyd', c_float),      #        hydrodynamic coefficient (Morrison equation)
         ('m_clat', c_float),      #        lateral wind reaction coefficient
         ('m_s', c_float),         #        Strouhal number
         ('m_ag', c_float)         #        reserved (must be present to detect old data without chyd)
      ]
csect_cw = CSECT_CW()

class CSECT_WPA(Structure):        # 9/NR:81  SectionWindParameters for Wind loading (WPAR)
   _fields_ = [
         ('m_id', c_int),          #        Identification 81
         ('m_iba', c_int),         #        construction stage number
         ('m_ibit', c_int),        #        bitpattern of explicit limits
         ('m_kd', c_float),        # [1011] equivalent roughness k
         ('m_ice', c_float),       # [1011] ice cover
         ('m_traf', c_float),      # [1011] height of traffic lane
         ('m_ymin', c_float),      # [1011] wind attack area
         ('m_zmin', c_float),      # [1011] wind attack area
         ('m_ymax', c_float),      # [1011] wind attack area
         ('m_zmax', c_float),      # [1011] wind attack area
         ('m_yref', c_float),      # [1011] wind moment reference
         ('m_zref', c_float),      # [1011] wind moment reference
         ('m_alf', c_float)        # [   5] rotation for default wind coefficients
      ]
csect_wpa = CSECT_WPA()

class CSECT_WDE(Structure):        # 9/NR:82  SectionWindDerivativa for Wind loading (WIND)
   _fields_ = [
         ('m_id', c_int),          #        Identification 82
         ('m_iref', c_int),        #        Type of derivativa
         ('m_alf', c_int),         #        angle of attack in degrees (see 009/NR:80)
         ('m_der', c_float * 20 * 5)  #        Derivativa vred,value as splines
      ]
csect_wde = CSECT_WDE()

class CSECT_USR(Structure):        # 9/NR:90  SectionUserValues (SV/QW)
   _fields_ = [
         ('m_id', c_int),          #        Identification = 90
         ('m_itp', c_int),         #        type of control value set
         ('m_ival', c_int),        #        value of control flag
         ('m_rval', c_float),      #        real value of control flag
         ('m_rvald', c_float)      #        place to save the original value which has been
      ]
csect_usr = CSECT_USR()

class CSECT_MAT(Structure):        # 9/NR:91  SectionalMaterial list
   _fields_ = [
         ('m_id', c_int),          #        Identification = 91
         ('m_mat', c_int * 31)     #        material numbers
      ]
csect_mat = CSECT_MAT()

class CSECT_VAD(Structure):        # 9/NR:97  SectionVarDefaults
   _fields_ = [
         ('m_id', c_int),          #        Identification = 97/98
         ('m_ind1', c_int),        #        Lower Index of variable
         ('m_ind2', c_int),        #        Upper Index of variable
         ('m_idim', c_int),        #        Unit of variable
         ('m_name', c_int * 4),    #        Name of variable
         ('m_rval', c_float * 1020)  #        values of the variable NAME(I1:I2)
      ]
csect_vad = CSECT_VAD()

class CSECT_VAR(Structure):        # 9/NR:98  SectionVarValues
   _fields_ = [
         ('m_id', c_int),          #        Identification = 97/98
         ('m_ind1', c_int),        #        Lower Index of variable
         ('m_ind2', c_int),        #        Upper Index of variable
         ('m_idim', c_int),        #        Unit of variable
         ('m_name', c_int * 4),    #        Name of variable
         ('m_rval', c_float * 1020)  #        values of the variable NAME(I1:I2)
      ]
csect_var = CSECT_VAR()

class CSECT_REF(Structure):        # 9/NR:99  SectionReference
   _fields_ = [
         ('m_id', c_int),          #        Identification 099
         ('m_im', c_int),          #        Type of reference structure definition (see AQUA.ERR)
         ('m_irts', c_int),        #        Subtype of reference definition for the points:
         ('m_ref', c_int * 200)    #        Identifier of references (0 = not defined)
      ]
csect_ref = CSECT_REF()

class CSECT_SPT(Structure):        # 9/NR:100  SectionStressPoint (SPT/QSP)
   _fields_ = [
         ('m_id', c_int),          #        Identification 100/101
         ('m_mno', c_int),         #        Material number
         ('m_idp', c_int),         #        Number*256 + Bitpattern
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_rt', c_float),        # [1011] Radius of arc   (:101) ; effect. thickness (:100)
         ('m_wty', c_float),       # [1018] Resistance Torsion
         ('m_wvyy', c_float),      # [1017] Resistance y-shear
         ('m_wvzy', c_float),      # [1017] Resistance z-shear
         ('m_wt2y', c_float),      # [1018] Resistance 2nd Torsion
         ('m_wtz', c_float),       # [1018] Resistance Torsion
         ('m_wvyz', c_float),      # [1017] Resistance y-shear
         ('m_wvzz', c_float),      # [1017] Resistance z-shear
         ('m_wt2z', c_float),      # [1018] Resistance 2nd Torsion
         ('m_w0', c_float),        # [1012] unit warping
         ('m_epsr', c_float),      #        non effective strain ratio (0 < epsr <= 1)
         ('m_exp', c_float),       #        exposition class
         ('m_fix', c_float),       # [1011] location of fix point
         ('m_sigd', c_float),      # [1092] max. dynamic allowed stress range sig-d(-1)
         ('m_taud', c_float),      # [1092] max dynamic allowed stress range tau-d(-1)
         ('m_litd', c_int),        #        literal for notch type
         ('m_sigy', c_float),      # [1092] stress perpendicular
         ('m_aref', c_float),      # [1012] weight (effective area) FE-integration points
         ('m_temp', c_float),      # [1215] Temperature
         ('m_temp1', c_float)      # [1215] maximum temperature in history (for damage)
      ]
csect_spt = CSECT_SPT()

class CSECT_PPT(Structure):        # 9/NR:101  SectionPolygonPoint (POLY/QPOL)
   _fields_ = [
         ('m_id', c_int),          #        Identification 100/101
         ('m_mno', c_int),         #        Material number
         ('m_idp', c_int),         #        Number*256 + Bitpattern
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_rt', c_float),        # [1011] Radius of arc   (:101) ; effect. thickness (:100)
         ('m_wty', c_float),       # [1018] Resistance Torsion
         ('m_wvyy', c_float),      # [1017] Resistance y-shear
         ('m_wvzy', c_float),      # [1017] Resistance z-shear
         ('m_wt2y', c_float),      # [1018] Resistance 2nd Torsion
         ('m_wtz', c_float),       # [1018] Resistance Torsion
         ('m_wvyz', c_float),      # [1017] Resistance y-shear
         ('m_wvzz', c_float),      # [1017] Resistance z-shear
         ('m_wt2z', c_float),      # [1018] Resistance 2nd Torsion
         ('m_w0', c_float),        # [1012] unit warping
         ('m_epsr', c_float),      #        non effective strain ratio (0 < epsr <= 1)
         ('m_exp', c_float),       #        exposition class
         ('m_fix', c_float),       # [1011] location of fix point
         ('m_sigd', c_float),      # [1092] max. dynamic allowed stress range sig-d(-1)
         ('m_taud', c_float),      # [1092] max dynamic allowed stress range tau-d(-1)
         ('m_litd', c_int),        #        literal for notch type
         ('m_sigy', c_float),      # [1092] stress perpendicular
         ('m_aref', c_float),      # [1012] weight (effective area) FE-integration points
         ('m_temp', c_float),      # [1215] Temperature
         ('m_temp1', c_float)      # [1215] maximum temperature in history (for damage)
      ]
csect_ppt = CSECT_PPT()

class CSECT_CIR(Structure):        # 9/NR:102  SectionCircle (CIRC/KREI)
   _fields_ = [
         ('m_id', c_int),          #        Identification 102
         ('m_mno', c_int),         #        Material number
         ('m_itp', c_int),         #        interior construction
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate center
         ('m_z', c_float),         # [1011] z-ordinate center
         ('m_r', c_float),         # [1011] Radius
         ('m_ri', c_float),        # [1011] Radius hole
         ('m_uc', c_float)         # [1011] air contact length
      ]
csect_cir = CSECT_CIR()

class CSECT_PAN(Structure):        # 9/NR:103  SectionPanel (PLAT,WALL)
   _fields_ = [
         ('m_id', c_int),          #        Identification 103/104
         ('m_mno', c_int),         #        Material number
         ('m_idp', c_int),         #        Bit-pattern
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_t', c_float),         # [1010] thickness
         ('m_wa', c_float),        # [1012] unit warping start
         ('m_we', c_float),        # [1012] unit warping end
         ('m_wt', c_float),        # [1018] maximum shear from MT
         ('m_wvy', c_float),       # [1017] maximum shear from Vy
         ('m_wvz', c_float),       # [1017] maximum shear from Vz
         ('m_wt2', c_float),       # [1018] maximum shear from MT2
         ('m_xvy', c_float),       #        relative Ordinate WVy
         ('m_xvz', c_float),       #        relative Ordinate WVz
         ('m_xmt2', c_float),      #        relative Ordinate Wt2
         ('m_wtbr', c_float),      #        Bredt torsional shear
         ('m_fixa', c_float),      # [1011] location of fix point
         ('m_fixb', c_float),      # [1011] location of fix point
         ('m_teff', c_float),      # [1010] effective thickness
         ('m_ast', c_float),       # [1011] Distance of stiffeners along beam axis
         ('m_eta', c_float)        #        Reduction factor for local buckling
      ]
csect_pan = CSECT_PAN()

class CSECT_WEL(Structure):        # 9/NR:104  SectionWeld  (WELD)
   _fields_ = [
         ('m_id', c_int),          #        Identification 103/104
         ('m_mno', c_int),         #        Material number
         ('m_idp', c_int),         #        Bit-pattern
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_t', c_float),         # [1010] thickness
         ('m_wa', c_float),        # [1012] unit warping start
         ('m_we', c_float),        # [1012] unit warping end
         ('m_wt', c_float),        # [1018] maximum shear from MT
         ('m_wvy', c_float),       # [1017] maximum shear from Vy
         ('m_wvz', c_float),       # [1017] maximum shear from Vz
         ('m_wt2', c_float),       # [1018] maximum shear from MT2
         ('m_xvy', c_float),       #        relative Ordinate WVy
         ('m_xvz', c_float),       #        relative Ordinate WVz
         ('m_xmt2', c_float),      #        relative Ordinate Wt2
         ('m_wtbr', c_float),      #        Bredt torsional shear
         ('m_fixa', c_float),      # [1011] location of fix point
         ('m_fixb', c_float),      # [1011] location of fix point
         ('m_teff', c_float),      # [1010] effective thickness
         ('m_ast', c_float),       # [1011] Distance of stiffeners along beam axis
         ('m_eta', c_float)        #        Reduction factor for local buckling
      ]
csect_wel = CSECT_WEL()

class CSECT_PER(Structure):        # 9/NR:110  SectionPeriphery
   _fields_ = [
         ('m_id', c_int),          #        Identification 110
         ('m_mno', c_int),         #        Material number
         ('m_mn2', c_int),         #        2nd material number
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate
         ('m_za', c_float),        # [1011] z-ordinate
         ('m_ye', c_float),        # [1011] y-ordinate
         ('m_ze', c_float),        # [1011] z-ordinate
         ('m_air', c_float)        #        air contact ratio
      ]
csect_per = CSECT_PER()

class CSECT_FEM(Structure):        # 9/NR:112  SectionTopology
   _fields_ = [
         ('m_id', c_int),          #        Identification 111
         ('m_mno', c_int),         #        Material number
         ('m_nrel', c_int),        #        internal element number
         ('m_node', c_int * 4)     #        internal element nodes
      ]
csect_fem = CSECT_FEM()

class CSECT_NER(Structure):        # 9/NR:190  SectionNonEffectiveRectangle (NEFF)
   _fields_ = [
         ('m_id', c_int),          #        Identification 190
         ('m_mno', c_int),         #        Material number
         ('m_idp', c_int),         #        Noneffective for (same bits as :101)
         ('m_tnr', c_int),         #        Designation
         ('m_ymin', c_float),      # [1011] y-ordinate
         ('m_zmin', c_float),      # [1011] z-ordinate
         ('m_ymax', c_float),      # [1011] y-ordinate
         ('m_zmax', c_float),      # [1011] z-ordinate
         ('m_t', c_float),         # [1011] thickness
         ('m_smin', c_float),      # [1092] stress at point (ymin,zmin)
         ('m_smax', c_float)       # [1092] stress at point (ymax,zmax)
      ]
csect_ner = CSECT_NER()

class CSECT_NEP(Structure):        # 9/NR:191  Partial non effective polygons
   _fields_ = [
         ('m_id', c_int),          #        Identification 191
         ('m_mno', c_int),         #        Materialnumber
         ('m_idp', c_int),         #        Noneffective for (see :190)
         ('m_tnr', c_int),         #        Ident from 190 / Cut identifier for :312 elements
         ('m_yz', c_float * 511 * 2)  # [1011] yz(2,*) = vertices (old format is blocked with 7 points
      ]
csect_nep = CSECT_NEP()

class CSECT_PRF(Structure):        # 9/NR:200  SectionPointReinforcement (RF/BEW)
   _fields_ = [
         ('m_id', c_int),          #        Identification 200
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_sig', c_float),       # [1092] prestress
         ('m_temp', c_float),      # [1215] Temperature
         ('m_as', c_float),        # [1020] Reinforcement area
         ('m_asma', c_float),      # [1020] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1012] Reference area
         ('m_a', c_float)          # [1011] distance of bars
      ]
csect_prf = CSECT_PRF()

class CSECT_LRF(Structure):        # 9/NR:201  SectionLineReinforcement (LRF/LBEW)
   _fields_ = [
         ('m_id', c_int),          #        Identification 201/211/221 or 321
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_r', c_float),         # [1011] Radius
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_lrf = CSECT_LRF()

class CSECT_LRP(Structure):        # 9/NR:211  SectionLineReinforcement in Points
   _fields_ = [
         ('m_id', c_int),          #        Identification 201/211/221 or 321
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_r', c_float),         # [1011] Radius
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_lrp = CSECT_LRP()

class CSECT_LSL(Structure):        # 9/NR:221  SectionShearLink
   _fields_ = [
         ('m_id', c_int),          #        Identification 201/211/221 or 321
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_r', c_float),         # [1011] Radius
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_lsl = CSECT_LSL()

class CSECT_CRF(Structure):        # 9/NR:202  SectionCircularReinforcement (CRF/KBEW)
   _fields_ = [
         ('m_id', c_int),          #        Identification 202/212/222
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate center
         ('m_z', c_float),         # [1011] z-ordinate center
         ('m_r', c_float),         # [1011] Radius
         ('m_i_4', c_float),
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_crf = CSECT_CRF()

class CSECT_CRP(Structure):        # 9/NR:212  SectionCircularReinforcement in Points
   _fields_ = [
         ('m_id', c_int),          #        Identification 202/212/222
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate center
         ('m_z', c_float),         # [1011] z-ordinate center
         ('m_r', c_float),         # [1011] Radius
         ('m_i_4', c_float),
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_crp = CSECT_CRP()

class CSECT_CSL(Structure):        # 9/NR:222  SectionHelicalShearLink
   _fields_ = [
         ('m_id', c_int),          #        Identification 202/212/222
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate center
         ('m_z', c_float),         # [1011] z-ordinate center
         ('m_r', c_float),         # [1011] Radius
         ('m_i_4', c_float),
         ('m_as', c_float),        # [1029] Reinforc. area
         ('m_asma', c_float),      # [1029] max Reinforcement area
         ('m_rng', c_float),       #        Layer number
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Diameter
         ('m_aref', c_float),      # [1019] Reference area = width of element
         ('m_a', c_float),         # [1011] distance of bars
         ('m_phia', c_float),      # [   5] start angle for generated points
         ('m_phie', c_float)       # [   5] end   angle for generated points
      ]
csect_csl = CSECT_CSL()

class CSECT_URF(Structure):        # 9/NR:210  SectionPeriphericReinforcement (CURF,UBEW)
   _fields_ = [
         ('m_id', c_int),          #        Identification 210/220
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_cover', c_float),     # [1024] static cover
         ('m_exp', c_int * 2),     #        Exposition class
         ('m_wc', c_float),        #        weight for centering reinforcement
         ('m_as', c_float),        # [1021] Reinforc. area/length
         ('m_asma', c_float),      # [1021] max Reinforcement area
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Bar Diameter
         ('m_aref', c_float),      # [1019] Reference area for crack width
         ('m_a', c_float)          # [1011] distance of bars
      ]
csect_urf = CSECT_URF()

class CSECT_USL(Structure):        # 9/NR:220  SectionPeriphericShearLink
   _fields_ = [
         ('m_id', c_int),          #        Identification 210/220
         ('m_mno', c_int),         #        Material number
         ('m_ir', c_int),          #        Layer number
         ('m_tnr', c_int),         #        Designation
         ('m_cover', c_float),     # [1024] static cover
         ('m_exp', c_int * 2),     #        Exposition class
         ('m_wc', c_float),        #        weight for centering reinforcement
         ('m_as', c_float),        # [1021] Reinforc. area/length
         ('m_asma', c_float),      # [1021] max Reinforcement area
         ('m_ft', c_float),        #        torsional effect
         ('m_d', c_float),         # [1023] Bar Diameter
         ('m_aref', c_float),      # [1019] Reference area for crack width
         ('m_a', c_float)          # [1011] distance of bars
      ]
csect_usl = CSECT_USL()

class CSECT_CPT(Structure):        # 9/NR:300  SectionCutStressPoint
   _fields_ = [
         ('m_id', c_int),          #        Identification 300
         ('m_mno', c_int),         #        Material of Reinforc. + 1000*Materialnumber
         ('m_bit', c_int),         #        Cut-Index*128 + Bitpattern
         ('m_tnr', c_int),         #        Designation
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_b0', c_float),        # [1011] width of cut
         ('m_wtm', c_float),       # [1018] Resistance Torsion
         ('m_wtr', c_float),       # [1018] Resistance max Torsion
         ('m_wvy', c_float),       # [1017] Resistance y-shear
         ('m_wvz', c_float),       # [1017] Resistance z-shear
         ('m_frs', c_float),       #        Factor for total reinf
         ('m_w0', c_float),        # [1012] unit warping
         ('m_sigy', c_float),      # [1092] stress perpendicular
         ('m_bb', c_float),        # [1011] total width of cut
         ('m_vyfk', c_float),      #        part of total y-shear
         ('m_vzfk', c_float),      #        part of total z-shear
         ('m_bqfk', c_float),      #        partial width factor
         ('m_byfk', c_float),      # [1011] shear design width for Vy
         ('m_bzfk', c_float)       # [1011] shear design width for Vz
      ]
csect_cpt = CSECT_CPT()

class CSECT_CUT(Structure):        # 9/NR:301  ShearCut (CUT)
   _fields_ = [
         ('m_id', c_int),          #        Identification 301
         ('m_mno', c_int),         #        Material of Reinforc. + 1000*Materialnumber
         ('m_idp', c_int),         #        Bitpattern
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_b0', c_float),        # [1011] effective width
         ('m_n', c_float),         # [1111] Normal force perpend.
         ('m_m', c_float),         # [1114] bending moment perpend
         ('m_wtm', c_float),       # [1018] Resistance Torsion mid
         ('m_wtd', c_float),       # [1018] add tors.resist.edge
         ('m_vyfk', c_float),      #        part of total y-shear
         ('m_vzfk', c_float),      #        part of total z-shear
         ('m_bv', c_float),        # [1011] total effective width
         ('m_phib', c_float),      # [   5] inclination stirups
         ('m_irb', c_float),       #        number of shearlayer
         ('m_ty', c_float),        # [  17] unit shear Sy/Iz
         ('m_tz', c_float),        # [  17] unit shear Sz/Iy
         ('m_bred', c_float),      # [1011] reduction for ducts
         ('m_asbm', c_float),      #        Minimum shear reinf.
         ('m_betc', c_float),      #        friction coefficient
         ('m_mue', c_float),       #        friction in joint
         ('m_act', c_float),       # [1012] Area of cut off
         ('m_ksl', c_float),       #        parameters for plate
         ('m_sxe', c_float),       # [1011] crack spacing for AASTHO
         ('m_cott', c_float),      #        explicit selected inclination for truss model
         ('m_bmin', c_float),      # [1011] minimum of cut width
         ('m_bmax', c_float)       # [1011] maximum of cut width
      ]
csect_cut = CSECT_CUT()

class CSECT_CPL(Structure):        # 9/NR:311  Partial polygons of shear cut
   _fields_ = [
         ('m_id', c_int),          #        Identification 311
         ('m_mno', c_int),         #        Materialnumber
         ('m_idp', c_int),         #        Cut number (0=continue last one)
         ('m_tnr', c_int),         #        Designation of cut
         ('m_yz', c_float * 511 * 2)  # [1011] yz(2,*) = up to seven vertices
      ]
csect_cpl = CSECT_CPL()

class CSECT_APL(Structure):        # 9/NR:313  Partial polygons of AKT crack area
   _fields_ = [
         ('m_id', c_int),          #        Identification 311
         ('m_mno', c_int),         #        Materialnumber
         ('m_idp', c_int),         #        Cut number (0=continue last one)
         ('m_tnr', c_int),         #        Designation of cut
         ('m_yz', c_float * 511 * 2)  # [1011] yz(2,*) = up to seven vertices
      ]
csect_apl = CSECT_APL()

class CSECT_HYD(Structure):        # 9/NR:900  SectionalHydraulics total section
   _fields_ = [
         ('m_id', c_int),          #        Identification = 900/903
         ('m_i_1', c_int),
         ('m_i_2', c_int),
         ('m_a', c_float),         # [1012] Area
         ('m_ut', c_float),        # [1011] total periphery
         ('m_up', c_float),        # [1011] total wet periphery
         ('m_r', c_float),         # [1011] hydraulic radius
         ('m_zet1', c_float),      #        loss factor 1
         ('m_zet2', c_float),      #        loss factor 2
         ('m_slk', c_float),       #        total leakage
         ('m_ys', c_float),        # [1011] y-Ordinate Center
         ('m_zs', c_float)         # [1011] y-Ordinate Center
      ]
csect_hyd = CSECT_HYD()

class CSECT_HYP(Structure):        # 9/NR:903  SectionalHydraulics partial section
   _fields_ = [
         ('m_id', c_int),          #        Identification = 900/903
         ('m_i_1', c_int),
         ('m_i_2', c_int),
         ('m_a', c_float),         # [1012] Area
         ('m_ut', c_float),        # [1011] total periphery
         ('m_up', c_float),        # [1011] total wet periphery
         ('m_r', c_float),         # [1011] hydraulic radius
         ('m_zet1', c_float),      #        loss factor 1
         ('m_zet2', c_float),      #        loss factor 2
         ('m_slk', c_float),       #        total leakage
         ('m_ys', c_float),        # [1011] y-Ordinate Center
         ('m_zs', c_float)         # [1011] y-Ordinate Center
      ]
csect_hyp = CSECT_HYP()

class CSECT_HYA(Structure):        # 9/NR:904  SectionalHydraulicsAddval
   _fields_ = [
         ('m_id', c_int),          #        identifier 904
         ('m_i_2', c_int),
         ('m_type', c_int),        #        type of section
         ('m_nw', c_float),        #        Nominal width
         ('m_ymin', c_float),      # [1011] Minimum Ordinate of section
         ('m_ymax', c_float),      # [1011] Maximum Ordinate of section
         ('m_zmin', c_float),      # [1011] Minimum Ordinate of section
         ('m_zmax', c_float),      # [1011] Maximum Ordinate of section
         ('m_ks', c_float),        # [  16] absolute roughness
         ('m_s', c_float),         #        storage coefficient
         ('m_i_8', c_float),       #        reserved
         ('m_i_9', c_float),       #        reserved
         ('m_i_10', c_float),      #        reserved
         ('m_hp', c_float),        # [1010] lift of pump
         ('m_lmin', c_float),      #        minimum power
         ('m_lmax', c_float),      #        maximum power
         ('m_qmax', c_float)       #        maximum delivery
      ]
csect_hya = CSECT_HYA()

class CSECT_HYS(Structure):        # 9/NR:910  SectionalHydraulicsPolygon
   _fields_ = [
         ('m_id', c_int),          #        Identification 910
         ('m_mat', c_int),         #        identifier 0 (material number)
         ('m_nr', c_int),          #        number of side
         ('m_tnr', c_int),         #        Designation
         ('m_ya', c_float),        # [1011] y-ordinate start
         ('m_za', c_float),        # [1011] z-ordinate start
         ('m_ye', c_float),        # [1011] y-ordinate end
         ('m_ze', c_float),        # [1011] z-ordinate end
         ('m_ks', c_float),        # [  16] absolute roughness
         ('m_slk', c_float)        #        leakage
      ]
csect_hys = CSECT_HYS()

class CSECT_INS(Structure):        # 9/NR:100002  structural database contents
   _fields_ = [
         ('m_id', c_int),          #        Identification of record key
         ('m_kwh', c_int),         #        Identification of record key (30/31/32)
         ('m_kwl', c_int),         #        Identification of record key (=NR)
         ('m_ib', c_int * 9999)    #        buffer of record contents for record KWH/KWL
      ]
csect_ins = CSECT_INS()

class CSYST(Structure):            # 10/00  SystemInfo
   _fields_ = [
         ('m_iprob', c_int),       #        Type of System
         ('m_iachs', c_int),       #        Orientation of gravity
         ('m_nknot', c_int),       #        Number of nodes
         ('m_mknot', c_int),       #        Highest node number
         ('m_igdiv', c_int),       #        Group divisor
         ('m_igres', c_int),
         ('m_box', c_float * 2 * 3), # [1001] bounding box
         ('m_tg', c_float * 4 * 3),#        global CDB-System transformation matrix
         ('m_txt',  c_int * 64)    #        Name of projekt, 127 chars
      ]
csyst = CSYST()

class CSYST_DES(Structure):        # 10/1:0  SystemDesignCode
   _fields_ = [
         ('m_id', c_int),          #        identifier = 0
         ('m_idc', c_int),         #        Design code enumeration
         ('m_country', c_int),     #        Country code for variants
         ('m_code', c_int),        #        main number or ident of code
         ('m_year', c_int),        #        Year of publication
         ('m_class', c_int),       #        classification (see master.ini)
         ('m_txt', c_int * 4),     #        specific Text of Design code (16 characters)
         ('m_wind', c_int),        #        enum of a wind classification (see master.ini)
         ('m_snow', c_int),        #        enum of a snow-classification (see master.ini)
         ('m_seis', c_int),        #        enum of a seismic-classification (see master.ini)
         ('m_gravity', c_float),   # [1202] explicit gravity acceleration constant for site
         ('m_altiobs', c_float),   # [1006] obsoleted altitude above sea level
         ('m_vers', c_float),      #        Version number of INI-File (21.0)
         ('m_longitud', c_float),  # [ 205] longitude of location
         ('m_latitude', c_float),  # [ 205] latitude of location
         ('m_altitude', c_float)   # [1006] altitude above sea level
      ]
csyst_des = CSYST_DES()

class CSYST_ACT(Structure):        # 10/1:1  Predefined Actions from INI-file
   _fields_ = [
         ('m_id', c_int),          #        identifier = 1
         ('m_action', c_int),      #        ID of the real action = type of action
         ('m_type', c_int),        #        16*Part of action + superposition
         ('m_gamu', c_float),      #        safety factor unfavourable
         ('m_gamf', c_float),      #        safety factor favourable
         ('m_psi0', c_float),      #        combination value
         ('m_psi1', c_float),      #        frequent combination value
         ('m_psi2', c_float),      #        quasi permanent combination value
         ('m_ps1s', c_float),      #        non frequent combination value psi1'
         ('m_gama', c_float),      #        safety factor accidential
         ('m_cat', c_int),         #        sub category of action
         ('m_txtref', c_int),      #        designation_enum in SOFISTIK.ERR
         ('m_txt',  c_int * 17)    #        explicit designation (in native language)
      ]
csyst_act = CSYST_ACT()

class CSYST_COM_ACT(Structure):    #        Identifier of action
   _fields_ = [
         ('m_id', c_int),
         ('m_faku', c_float),
         ('m_fakf', c_float)
      ]
csyst_com_act = CSYST_COM_ACT()

class CSYST_COM(Structure):        # 10/1:2  Possible Combination of actions
   _fields_ = [
         ('m_id', c_int),          #        identifier = 2
         ('m_lfb', c_int),         #        loadcase number offset
         ('m_extr', c_int),        #        Combination rule equation to be used
         ('m_type', c_int),        #        type or action of resulting load case
         ('m_apply', c_int),       #        Is generally used for:
         ('m_txt', c_int * 8),     #        Name of combination
         ('m_dummy', c_float),     #        reserved
         ('m_act',  CSYST_COM_ACT * 31)  #        Identifier of action
      ]
csyst_com = CSYST_COM()

class CGRP(Structure):             # 11/00  Groups
   _fields_ = [
         ('m_ng', c_int),          #        group-number
         ('m_typ', c_int),         #        element code
         ('m_num', c_int),         #        number of elements of this type
         ('m_min', c_int),         #        minimum element-number of group
         ('m_max', c_int),         #        maximum element-number of group
         ('m_mnr', c_int),         #        material-number of group
         ('m_mbw', c_int),         #        reinforcement material-number of group
         ('m_inf', c_int),         #        Bit-code of group
         ('m_faks', c_float),      #        stiffness factor of group (ASE/TALPA)
         ('m_faka', c_float),      #        reducing factor of axial bedding for piles
         ('m_fakt', c_float),      #        reducing factor of transverse bedding
         ('m_vtot', c_float),      # [1093] total volume
         ('m_mtot', c_float),      # [1093] total mass
         ('m_rtot', c_float),      # [1030] total reinforcement
         ('m_etot', c_float),      # [1093] total energy
         ('m_ecom', c_float),      # [1093] compression energy
         ('m_edev', c_float),      # [1093] shear energy
         ('m_ekin', c_float),      # [1093] kinetic energy
         ('m_epot', c_float),      # [1093] potential energy
         ('m_edam', c_float),      # [1093] damping energy
         ('m_h_gw', c_float),      # [1001] Level of Groundwater
         ('m_dummy', c_float),     #        reserved
         ('m_text',  c_int * 17)   #        Designation of Group
      ]
cgrp = CGRP()

class CGRP_LC(Structure):          # 11/LC  Groups of Loadcase
   _fields_ = [
         ('m_ng', c_int),          #        group-number
         ('m_ng', c_int),          #        group-number
         ('m_typ', c_int),         #        element code
         ('m_num', c_int),         #        number of elements of this type
         ('m_min', c_int),         #        minimum element-number of group
         ('m_max', c_int),         #        maximum element-number of group
         ('m_mnr', c_int),         #        material-number of group
         ('m_mbw', c_int),         #        reinforcement material-number of group
         ('m_inf', c_int),         #        Bit-code of group
         ('m_faks', c_float),      #        stiffness factor of group (ASE/TALPA)
         ('m_faka', c_float),      #        reducing factor of axial bedding for piles
         ('m_fakt', c_float),      #        reducing factor of transverse bedding
         ('m_vtot', c_float),      # [1093] total volume
         ('m_mtot', c_float),      # [1093] total mass
         ('m_rtot', c_float),      # [1030] total reinforcement
         ('m_etot', c_float),      # [1093] total energy
         ('m_ecom', c_float),      # [1093] compression energy
         ('m_edev', c_float),      # [1093] shear energy
         ('m_ekin', c_float),      # [1093] kinetic energy
         ('m_epot', c_float),      # [1093] potential energy
         ('m_edam', c_float),      # [1093] damping energy
         ('m_h_gw', c_float),      # [1001] Level of Groundwater
         ('m_dummy', c_float),     #        reserved
         ('m_text',  c_int * 17)   #        Designation of Group
      ]
cgrp_lc = CGRP_LC()

class CLC_CTRL(Structure):         # 12/LC:?  Informations on loadcase LC
   _fields_ = [
         ('m_kind', c_int),        #        type of loadcase
         ('m_ityp', c_int),        #        action type (14/ID)
         ('m_theo', c_int),        #        first order theory
         ('m_iba', c_int * 2),     #        construction stage number of birth & death
         ('m_plc', c_int),         #        Primary load case for 2nd order analysis
         ('m_rpar', c_float),      #        Timevalue of Load [sec]
         ('m_psi0', c_float),      #        combin. factor psi0
         ('m_psi1', c_float),      #        combin. factor psi1
         ('m_psi2', c_float),      #        combin. factor psi2
         ('m_fact', c_float),      #        loadcase factor
         ('m_facx', c_float),      #        dead load factor X
         ('m_facy', c_float),      #        dead load factor Y
         ('m_facz', c_float),      #        dead load factor Z
         ('m_rx', c_float),        # [1151] sum of support PX
         ('m_ry', c_float),        # [1151] sum of support PY
         ('m_rz', c_float),        # [1151] sum of support PZ
         ('m_cri1', c_float),      #        1st eval. criteria
         ('m_cri2', c_float),      #        2nd eval. criteria
         ('m_cri3', c_float),      #        3rd eval. criteria
         ('m_gam1', c_float),      #        unfavourable factor
         ('m_gam2', c_float),      #        favourable factor
         ('m_name', c_int * 8),    #        Generating source
         ('m_rtex',  c_int * 17)   #        Designation of loadcase
      ]
clc_ctrl = CLC_CTRL()

class CLC_EVAL(Structure):         # 12/LC:011  Evaluation request
   _fields_ = [
         ('m_id', c_int),          #        identifier 11
         ('m_lref', c_int),        #        Referenced load case or construction stage
         ('m_ltyp', c_int),        #        type of evaluation request
         ('m_leig', c_int),        #        load case number of first eigenvalue
         ('m_name', c_int * 4),    #        Literal of variable name
         ('m_val', c_float * 99)   #        Results of evaluation (array for ietyp 4)
      ]
clc_eval = CLC_EVAL()

class CLC_COPY(Structure):         # 12/LC:012  Loads from other loadcases
   _fields_ = [
         ('m_id', c_int),          #        identifier 12 / 13
         ('m_lref', c_int),        #        Referenced load case or action ID [chr]
         ('m_lsel', c_int),        #        selection bits for elements
         ('m_litf', c_int),        #        enum of applied generic factors
         ('m_isel', c_int * 4),    #        optional filter for element numbers
         ('m_nref', c_int * 8),    #        Load train application control (see cdblfta.for)
         ('m_sref', c_float * 32), #        Factors and coordinates
         ('m_sum', c_float * 7),   #        Sum of forces (psup,lsup)
         ('m_clit',  c_int * 128)  #        Literal of an external database as source
      ]
clc_copy = CLC_COPY()

class CLC_COPI(Structure):         # 12/LC:013  Loads from other loadcases
   _fields_ = [
         ('m_id', c_int),          #        identifier 12 / 13
         ('m_lref', c_int),        #        Referenced load case or action ID [chr]
         ('m_lsel', c_int),        #        selection bits for elements
         ('m_litf', c_int),        #        enum of applied generic factors
         ('m_isel', c_int * 4),    #        optional filter for element numbers
         ('m_nref', c_int * 8),    #        Load train application control (see cdblfta.for)
         ('m_sref', c_float * 32), #        Factors and coordinates
         ('m_sum', c_float * 7),   #        Sum of forces (psup,lsup)
         ('m_clit',  c_int * 128)  #        Literal of an external database as source
      ]
clc_copi = CLC_COPI()

class CLC_MBODY(Structure):        # 12/LC:2?  Rotation of Body
   _fields_ = [
         ('m_id', c_int),          #        identifier 20/21
         ('m_nr', c_int),          #        primary or secondary group number of moving elements
         ('m_nref', c_int),        #        Reference beam number
         ('m_ax', c_float),        # [1003] acceleration local X
         ('m_ay', c_float),        # [1003] acceleration local Y
         ('m_az', c_float),        # [1003] acceleration local Z
         ('m_axx', c_float),       # [1207] rotational acceleration local X-X
         ('m_ayy', c_float),       # [1207] rotational acceleration local Y-Y
         ('m_azz', c_float),       # [1207] rotational acceleration local Z-Z
         ('m_arx', c_float),       # [1207] rotational acceleration local X-X  (= vxx**2)
         ('m_ary', c_float),       # [1207] rotational acceleration local Y-Y  (= vyy**2)
         ('m_arz', c_float),       # [1207] rotational acceleration local Z-Z  (= vzz**2)
         ('m_ex', c_float),        # [1001] global reference point for rotational acceleration
         ('m_ey', c_float),        # [1001] global reference point for rotational acceleration
         ('m_ez', c_float)         # [1001] global reference point for rotational acceleration
      ]
clc_mbody = CLC_MBODY()

class CLC_LRES_LC(Structure):      #        load case number and factor (dynamic length)
   _fields_ = [
         ('m_n', c_int),
         ('m_f', c_float)
      ]
clc_lres_lc = CLC_LRES_LC()

class CLC_LRES(Structure):         # 12/LC:89  Explicit factors for selected results
   _fields_ = [
         ('m_id', c_int),          #        identifier 89
         ('m_kw', c_int),          #        KW where result has been stored
         ('m_ipos', c_int),        #        Position of Result within record
         ('m_nrel', c_int),        #        Element number
         ('m_xabs', c_float),      # [1011] Section location for beams/structural lines
         ('m_lc',  CLC_LRES_LC * 255)  #        load case number and factor (dynamic length)
      ]
clc_lres = CLC_LRES()

class CLC_LPOS(Structure):         # 12/LC:90  Position of Load trains
   _fields_ = [
         ('m_id', c_int),          #        identifier 90
         ('m_case', c_int),        #        number of the case
         ('m_ref', c_int),         #        name of the reference lane
         ('m_sub', c_int),         #        subnumber of lane
         ('m_kw', c_int),          #        KW where result has been stored
         ('m_ipos', c_int),        #        Position of Result within record
         ('m_nrel', c_int),        #        Elementnumber
         ('m_lftg', c_int),        #        LFT*1000+500*ISCONVOY+LFG
         ('m_xabs', c_float),      # [1011] Section location for beams
         ('m_yex', c_float),       # [1001] Eccentricity of load train
         ('m_psc', c_float * 2),   #        Maximum load values in load train (PL/BL)
         ('m_xpos', c_float * 64)  #        Position and distance values
      ]
clc_lpos = CLC_LPOS()

class CLC_LPO1(Structure):         # 12/LC:91  Individual position of Point load
   _fields_ = [
         ('m_id', c_int),          #        identifier 91
         ('m_x', c_float),         # [1001] Position of individual load
         ('m_pval', c_float * 4)   #        Load values in PV,PVM,PX,PY
      ]
clc_lpo1 = CLC_LPO1()

class CLC_LPO2(Structure):         # 12/LC:92  Individual position of Block load
   _fields_ = [
         ('m_id', c_int),          #        identifier 92
         ('m_xa', c_float),        # [1001] Position of individual load start
         ('m_xe', c_float),        # [1001] Position of individual load end
         ('m_pval', c_float * 4)   #        Load values in PV,PVM,PX,PY
      ]
clc_lpo2 = CLC_LPO2()

class CLC_LPO3(Structure):         # 12/LC:93  Individual residual loadings
   _fields_ = [
         ('m_id', c_int),          #        identifier 93
         ('m_xa', c_float),        # [1001] Position of individual load start
         ('m_xe', c_float),        # [1001] Position of individual load end
         ('m_pval', c_float * 8)   #        Load values in PRA,PRE,PLA,PLE,MRA,MRE,MLA,MLE
      ]
clc_lpo3 = CLC_LPO3()

class CLC_LPOX(Structure):         # 12/LC:99  Spandefinitions from ELLA
   _fields_ = [
         ('m_id', c_int),          #        identifier 99
         ('m_xa', c_float),        # [1001] Limits of an active area start
         ('m_xe', c_float),        # [1001] Limits of an active area end
         ('m_yl', c_float),        # [1001] Limits of an active area left
         ('m_yr', c_float),        # [1001] Limits of an active area right
         ('m_phi', c_float),       #        impact factor
         ('m_v', c_float)          # [1203] velocity of load train
      ]
clc_lpox = CLC_LPOX()

class CLC_POIN_LPT(Structure):     #        loadpt
   _fields_ = [
         ('m_p', c_float),
         ('m_x', c_float),         # [1001] 
         ('m_y', c_float),         # [1001] 
         ('m_z', c_float)          # [1001] 
      ]
clc_poin_lpt = CLC_POIN_LPT()

class CLC_POIN(Structure):         # 12/LC:10?  Free point loads
   _fields_ = [
         ('m_kref', c_int),        #        Reference type
         ('m_nref', c_int),        #        Reference number
         ('m_tref', c_int * 3),    #        Reference text    (12 characters)
         ('m_typ', c_int),         #        type of load
         ('m_txt', c_int * 3),     #        Identifiying Text (12 characters)
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_width', c_float),     # [1001] Tolerance load direction to match elements
         ('m_lpt',  CLC_POIN_LPT)  #        loadpt
      ]
clc_poin = CLC_POIN()

class CLC_LINE_LPT(Structure):     #        loadpts
   _fields_ = [
         ('m_p', c_float),
         ('m_x', c_float),         # [1001] 
         ('m_y', c_float),         # [1001] 
         ('m_z', c_float)          # [1001] 
      ]
clc_line_lpt = CLC_LINE_LPT()

class CLC_LINE(Structure):         # 12/LC:11?  Free line loads
   _fields_ = [
         ('m_kref', c_int),        #        Reference type
         ('m_nref', c_int),        #        Reference number
         ('m_tref', c_int * 3),    #        Reference text    (12 characters)
         ('m_typ', c_int),         #        type of load
         ('m_txt', c_int * 3),     #        Identifiying Text (12 characters)
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_width', c_float),     # [1001] Tolerance load direction to match elements
         ('m_lpt',  CLC_LINE_LPT * 63)  #        loadpts
      ]
clc_line = CLC_LINE()

class CLC_CURV_LPT(Structure):     #        loadpts
   _fields_ = [
         ('m_p', c_float),
         ('m_x', c_float),         # [1001] 
         ('m_y', c_float),         # [1001] 
         ('m_z', c_float)          # [1001] 
      ]
clc_curv_lpt = CLC_CURV_LPT()

class CLC_CURV(Structure):         # 12/LC:14?  Free spline loads
   _fields_ = [
         ('m_kref', c_int),        #        Reference type
         ('m_nref', c_int),        #        Reference number
         ('m_tref', c_int * 3),    #        Reference text    (12 characters)
         ('m_typ', c_int),         #        type of load
         ('m_txt', c_int * 3),     #        Identifiying Text (12 characters)
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_width', c_float),     # [1001] Tolerance load direction to match elements
         ('m_lpt',  CLC_CURV_LPT * 63)  #        loadpts
      ]
clc_curv = CLC_CURV()

class CLC_AREA_LPT(Structure):     #        loadpts
   _fields_ = [
         ('m_p', c_float),
         ('m_x', c_float),         # [1001] 
         ('m_y', c_float),         # [1001] 
         ('m_z', c_float)          # [1001] 
      ]
clc_area_lpt = CLC_AREA_LPT()

class CLC_AREA(Structure):         # 12/LC:12?  Free area loads
   _fields_ = [
         ('m_kref', c_int),        #        Reference type
         ('m_nref', c_int),        #        Reference number
         ('m_tref', c_int * 3),    #        Reference text    (12 characters)
         ('m_typ', c_int),         #        type of load
         ('m_txt', c_int * 3),     #        Identifiying Text (12 characters)
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_width', c_float),     # [1001] Tolerance load direction to match elements
         ('m_lpt',  CLC_AREA_LPT * 63)  #        loadpts
      ]
clc_area = CLC_AREA()

class CLC_VOLU(Structure):         # 12/LC:13?  Free volume loads
   _fields_ = [
         ('m_kref', c_int),        #        Reference type
         ('m_nref', c_int),        #        Reference number
         ('m_tref', c_int * 3),    #        Reference text    (12 characters)
         ('m_typ', c_int),         #        type of load
         ('m_txt', c_int * 3),     #        Identifiying Text (12 characters)
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_width', c_float),     # [1001] Factor for silo fillings A/U
         ('m_p0', c_float),        #        load value
         ('m_x', c_float),         # [1001] Reference point for load value P0
         ('m_y', c_float),         # [1001] 
         ('m_z', c_float),         # [1001] 
         ('m_p1', c_float),        #        variant load value second reference point
         ('m_dx1', c_float),       # [1001] Reference point for load value P1
         ('m_dy1', c_float),       # [1001] 
         ('m_dz1', c_float),       # [1001] 
         ('m_p2', c_float),        #        variant load value second reference point
         ('m_dx2', c_float),       # [1001] Reference point for load value P2
         ('m_dy2', c_float),       # [1001] 
         ('m_dz2', c_float),       # [1001] 
         ('m_p3', c_float),        #        variant load value second reference point
         ('m_dx3', c_float),       # [1001] Reference point for load value P3
         ('m_dy3', c_float),       # [1001] 
         ('m_dz3', c_float),       # [1001] 
         ('m_p4', c_float),        #        variant load value second reference point
         ('m_dx4', c_float),       # [1001] Reference point for load value P2
         ('m_dy4', c_float),       # [1001] 
         ('m_dz4', c_float),       # [1001] 
         ('m_p5', c_float),        #        variant load value second reference point
         ('m_dx5', c_float),       # [1001] Reference point for load value P3
         ('m_dy5', c_float),       # [1001] 
         ('m_dz5', c_float)        # [1001] 
      ]
clc_volu = CLC_VOLU()

class CGLC_GUID(Structure):        # 12/LC:199  Unique identifier of loading member
   _fields_ = [
         ('m_id', c_int),          #        identifier 199
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of following element
      ]
cglc_guid = CGLC_GUID()

class CLC_TRAI(Structure):         # 12/LC:300  Train loading
   _fields_ = [
         ('m_id', c_int),          #        identifier 300
         ('m_iden', c_int),        #        Type of load train
         ('m_bpat', c_int),        #        Preselected Bitpattern of special options
         ('m_p1', c_float),        #        Char Designation or Class of loading
         ('m_p2', c_float),        #        second entry for load magnitude
         ('m_p3', c_float),        #        third entry for load magnitude
         ('m_p4', c_float),        #        fourth entry for load magnitude
         ('m_p5', c_float),        #        Basic area loading
         ('m_p6', c_float),        #        Wind loading
         ('m_p7', c_float),        #        Height subjected to wind load
         ('m_p8', c_float),        #        Entry for brake loading
         ('m_p9', c_float),        #        Height of the gravity centreline
         ('m_totfac', c_float),    #        Factor for the vertical loads of the
         ('m_phib', c_float),      #        explicit impact factor for bending
         ('m_phibf', c_float),     #        explicit impact factor favourable bending
         ('m_phis', c_float),      #        explicit impact factor for shear
         ('m_phisf', c_float),     #        explicit impact factor favourable shear
         ('m_width', c_float),     # [1001] Width of moving lane to be spared with P5
         ('m_yex', c_float),       # [1001] reserved: Eccentricity of loading in lane
         ('m_xcol', c_float),      # [1001] Minimum distance for multiple instances
         ('m_v', c_float),         # [1203] Speed of train
         ('m_facf', c_float),      #        Factor for the masses of the loading
         ('m_dummy', c_float),     #        reserved
         ('m_frb', c_float),       #        Frequence of body to bogie spring
         ('m_dab', c_float),       #        Modal damping of body to bogie
         ('m_pzbo', c_float),      # [1001] Fractional load value of bogie (included in PZ)
         ('m_frbo', c_float),      #        Frequence of bogie to wheel spring
         ('m_dabo', c_float),      #        Modal damping of bogie to body
         ('m_pzwh', c_float),      # [1001] Fractional load value of wheel (included in PZ)
         ('m_frwh', c_float),      #        Frequence of wheel to surface / bridge deck
         ('m_dawh', c_float)       #        Modal damping of wheel to surface
      ]
clc_trai = CLC_TRAI()

class CLC_TRAL(Structure):         # 12/LC:301  Individual loads of Train loading
   _fields_ = [
         ('m_id', c_int),          #        identifier 301
         ('m_type', c_int),        #        Type of loading
         ('m_bpat', c_int),        #        contact node for single loads
         ('m_pz', c_float),        #        Vertical loading
         ('m_ymin', c_float),      # [1001] min eccentricity in y direction
         ('m_ymax', c_float),      # [1001] max eccentricity in y direction
         ('m_px', c_float),        #        Load value for braking
         ('m_pw', c_float),        #        Explicit force for wind attack
         ('m_zw', c_float),        # [1001] Height for wind force resultant
         ('m_pv', c_float),        #        Massvalue for zentrifugal force
         ('m_zpv', c_float),       # [1001] Height for zentrifugal force resultant
         ('m_facfav', c_float),    #        Factor for favourable effects
         ('m_a', c_float),         # [1001] Distance to last load
         ('m_l', c_float),         # [1001] Length of loading for block loads (0 = unlimited)
         ('m_lmax', c_float),      # [1001] Maximum length of block loading if variable
         ('m_ldel', c_float),      # [1001] Discrete increment of length for block loading
         ('m_hw', c_float),        # [1001] Height of train for wind attack area
         ('m_width', c_float),     # [1001] Width of train
         ('m_yexvar', c_float),    #        Variable eccentricity for secondary load trains
         ('m_wwheel', c_float),    # [1001] Width of single wheel
         ('m_lwheel', c_float),    # [1001] Length of single wheel
         ('m_dummy', c_float * 2), #        reserved
         ('m_frb', c_float),       #        Frequence of body to bogie spring
         ('m_dab', c_float),       #        Modal damping of body to bogie
         ('m_pzbo', c_float),      # [1001] Fractional load value of bogie (included in PZ)
         ('m_frbo', c_float),      #        Frequence of bogie to wheel spring
         ('m_dabo', c_float),      #        Modal damping of bogie to body
         ('m_pzwh', c_float),      # [1001] Fractional load value of wheel (included in PZ)
         ('m_frwh', c_float),      #        Frequence of wheel to surface / bridge deck
         ('m_dawh', c_float)       #        Modal damping of wheel to surface
      ]
clc_tral = CLC_TRAL()

class CLC_WIND(Structure):         # 12/LC:400  wind loading
   _fields_ = [
         ('m_id', c_int),          #        identifier 400
         ('m_norm', c_int),        #        wind design code
         ('m_clas', c_int),        #        type of zone and terrain
         ('m_vatm', c_float),      # [1201] atmospheric wind
         ('m_vref', c_float),      # [1201] mean reference wind
         ('m_vboe', c_float),      # [1201] gust reference wind
         ('m_dx', c_float),        #        components of wind direction
         ('m_dy', c_float),
         ('m_dz', c_float),
         ('m_xref', c_float),      # [1001] Reference point
         ('m_yref', c_float),      # [1001] 
         ('m_zref', c_float),      # [1001] 
         ('m_dxre', c_float),      #        Reference direction
         ('m_dyre', c_float),
         ('m_dzre', c_float),
         ('m_gh', c_float),        # [1001] coordinate of ground level
         ('m_hmin', c_float),      # [1001] value for constant wind speed below (zmin)
         ('m_rho', c_float),       # [  59] weight of the air / fluid
         ('m_lat', c_float),       # [   5] explicit lattitude of site
         ('m_z0', c_float)         # [1001] explicit roughness
      ]
clc_wind = CLC_WIND()

class CLC_WTOP(Structure):         # 12/LC:401  Wind environment
   _fields_ = [
         ('m_id', c_int),          #        identifier 401
         ('m_typ', c_float),       #        type of environment height
         ('m_i_2', c_float),       #        reserved
         ('m_xm', c_float),        # [1001] center of elevation in system coordinates
         ('m_ym', c_float),        # [1001] center of elevation in system coordinates
         ('m_zm', c_float),        # [1001] center of elevation in system coordinates
         ('m_dx', c_float),        #        direction of crest of ridge
         ('m_dy', c_float),        #        or local x-coordinate of a summit
         ('m_dz', c_float),
         ('m_h', c_float),         # [1001] height above ground defining the slopes
         ('m_wlen', c_float),      # [1001] width in negative local y direction
         ('m_blen', c_float)       # [1001] width in positive local x direction
      ]
clc_wtop = CLC_WTOP()

class CLC_WROU_R(Structure):       #        limits given
   _fields_ = [
         ('m_d', c_float),         # [1001] 
         ('m_r', c_float),         # [1001] 
         ('m_dh', c_float),        # [1001] 
         ('m_hh', c_float)         # [1001] 
      ]
clc_wrou_r = CLC_WROU_R()

class CLC_WROU(Structure):         # 12/LC:402  Roughness (wind)
   _fields_ = [
         ('m_id', c_int),          #        identifier 402
         ('m_i_1', c_float),       #        reserved
         ('m_i_2', c_float),       #        reserved
         ('m_dsea', c_float),      # [1001] Distance to the sea
         ('m_r',  CLC_WROU_R * 9)  #        limits given
      ]
clc_wrou = CLC_WROU()

class CLC_WSPE(Structure):         # 12/LC:410  wind spectrum
   _fields_ = [
         ('m_id', c_int),          #        identifier 410
         ('m_typ', c_int),         #        type of spectra
         ('m_ctyp', c_int),        #        type of coherence model
         ('m_a1lo', c_float),      #        1st coefficient longitudinal
         ('m_a2lo', c_float),      #        2nd coefficient longitudinal
         ('m_a3lo', c_float),      #        3rd coefficient longitudinal
         ('m_b_lo', c_float),      #        4th coefficient longitudinal
         ('m_c_lo', c_float),      #        5th coefficient longitudinal
         ('m_d_lo', c_float),      #        6th coefficient longitudinal
         ('m_a1la', c_float),      #        1st coefficient lateral
         ('m_a2la', c_float),      #        2nd coefficient lateral
         ('m_a3la', c_float),      #        3rd coefficient lateral
         ('m_b_la', c_float),      #        4th coefficient lateral
         ('m_c_la', c_float),      #        5th coefficient lateral
         ('m_d_la', c_float),      #        6th coefficient lateral
         ('m_a1ve', c_float),      #        1st coefficient vertical
         ('m_a2ve', c_float),      #        2nd coefficient vertical
         ('m_a3ve', c_float),      #        3rd coefficient vertical
         ('m_b_ve', c_float),      #        4th coefficient vertical
         ('m_c_ve', c_float),      #        5th coefficient vertical
         ('m_d_ve', c_float),      #        6th coefficient vertical
         ('m_c3d', c_float),       #        Longitudinal coefficient
         ('m_kuu', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kuv', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kuw', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kvu', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kvv', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kvw', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kwu', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kwv', c_float),       #        HWD factor for ESDU, coefficient otherwise
         ('m_kww', c_float)        #        HWD factor for ESDU, coefficient otherwise
      ]
clc_wspe = CLC_WSPE()

class CLC_WTST(Structure):         # 12/LC:411  wind coherence test requests
   _fields_ = [
         ('m_id', c_int),          #        identifier 411
         ('m_typ', c_int),         #        type of coherence component
         ('m_lc', c_int),          #        load case of an eigenvalue
         ('m_xref', c_float),      # [1001] Reference point
         ('m_yref', c_float),      # [1001] 
         ('m_zref', c_float),      # [1001] 
         ('m_rx', c_float),        # [1001] Distance or direction of distance
         ('m_ry', c_float),        # [1001] 
         ('m_rz', c_float),        # [1001] 
         ('m_cx', c_float),        #        Davenport/Krenk reference coefficients
         ('m_cy', c_float),
         ('m_cz', c_float),
         ('m_eig', c_float),       #        Eigenfrequency (Hertz) for LC>0
         ('m_u', c_float),         # [  96] mean velocity
         ('m_hwd', c_float),       # [1001] real distance for LC==0
         ('m_xmax', c_float),      #        maximum x-value for data
         ('m_data', c_float * 64)  #        calculated sqrt of coherence data ( 2 sets)
      ]
clc_wtst = CLC_WTST()

class CLC_WPRC(Structure):         # 12/LC:420  wind profile control values
   _fields_ = [
         ('m_id', c_int),          #        identifier 420
         ('m_id2', c_int),         #        identifier 0
         ('m_ipro', c_float),      #        number of generated profiles
         ('m_wxmi', c_float),      # [1001] size of structure in wind coordinates
         ('m_wxma', c_float),      # [1001] 
         ('m_wymi', c_float),      # [1001] 
         ('m_wyma', c_float),      # [1001] 
         ('m_wzmi', c_float),      # [1001] 
         ('m_wzma', c_float),      # [1001] 
         ('m_alfa', c_float),      #        some angle ...
         ('m_beta', c_float),      #        some angle ...
         ('m_gamm', c_float),      #        some angle ...
         ('m_delt', c_float)       #        some angle ...
      ]
clc_wprc = CLC_WPRC()

class CLC_WPRO(Structure):         # 12/LC:420  wind profile distinct values
   _fields_ = [
         ('m_id', c_int),          #        identifier 420
         ('m_ist', c_int),         #        source of data
         ('m_i_2', c_float),       #        index reserved
         ('m_h', c_float),         # [1001] height above ground level
         ('m_v', c_float),         # [1201] mean value of wind velocity
         ('m_vboe', c_float),      # [1201] peak value of wind velocity
         ('m_tlon', c_float),      # [1201] longitudinal turbulence
         ('m_tlat', c_float),      # [1201] lateral turbulence
         ('m_tver', c_float),      # [1201] vertical turbulence
         ('m_llon', c_float),      # [1001] longitudinal wave length
         ('m_llat', c_float),      # [1001] lateral wave length
         ('m_lver', c_float),      # [1001] vertical wave length
         ('m_phas', c_float)       #        phase
      ]
clc_wpro = CLC_WPRO()

class CLC_WAVE(Structure):         # 12/LC:500  Wave Loading
   _fields_ = [
         ('m_id', c_int),          #        identifier 500
         ('m_typ', c_int),         #        wave theory bit pattern
         ('m_nf', c_int),          #        number of frequencies in spectra
         ('m_h', c_float),         # [1001] wave height / significant wave height
         ('m_t', c_float),         # [  90] period of wave / peak period of wave
         ('m_d', c_float),         # [1001] water depth (0 = infinite)
         ('m_swl', c_float),       # [1001] sea water reference level
         ('m_dir', c_float * 3),   #        principal direction of travelling
         ('m_uc', c_float),        # [1201] additional constant current
         ('m_alf', c_float),       #        exponent U(z)=UC*(z/d)**alf
         ('m_rho', c_float),       # [  59] weight of the fluid
         ('m_l', c_float),         # [1001] calculated wave length
         ('m_par', c_float * 15)   #        special parameters for wave spectra
      ]
clc_wave = CLC_WAVE()

class CLC_HIST(Structure):         # 13/LC:0  TimeHistoryTitle
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_idt', c_int),         #        Unit of time resp x-axis
         ('m_idf', c_int),         #        Unit of function values
         ('m_nfun', c_int),        #        number of functions
         ('m_nval', c_int),        #        max number of discrete time values
         ('m_type', c_int),        #        general type of curve
         ('m_title',  c_int * 17)  #        Designation
      ]
clc_hist = CLC_HIST()

class CLC_DAMP(Structure):         # 13/LC:1  Damping values
   _fields_ = [
         ('m_id', c_int),          #        identifier 1
         ('m_d', c_float * 7)      #        modal damping values
      ]
clc_damp = CLC_DAMP()

class CLC_FVAL(Structure):         # 13/LC:?0  Discrete function values
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_tt', c_float),        #        Time/frequency/modenumber
         ('m_f', c_float * 7)      #        function values
      ]
clc_fval = CLC_FVAL()

class CLC_FMODC(Structure):        # 13/LC:9?  Explicit modal coordinates
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_tt', c_float),        #        Time/frequency/modenumber
         ('m_f', c_float * 7)      #        function values
      ]
clc_fmodc = CLC_FMODC()

class CLC_FSIN(Structure):         # 13/LC:11  Harmonic function additive
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_t', c_float),         # [  90] Time/frequency
         ('m_f1', c_float),        #        Amplitude value
         ('m_phi1', c_float),      # [  90] phase value
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime if > starttime
         ('m_s', c_float),         #        impactfactor
         ('m_f2', c_float),        #        Amplitude value for T/2 (Fourier)
         ('m_phi2', c_float),      # [  90] phase value for f2
         ('m_f3', c_float),        #        Amplitude value for T/3 (Fourier)
         ('m_phi3', c_float),      # [  90] phase value for f3
         ('m_f4', c_float),        #        Amplitude value for T/4 (Fourier)
         ('m_phi4', c_float)       # [  90] phase value for f4
      ]
clc_fsin = CLC_FSIN()

class CLC_FSINM(Structure):        # 13/LC:21  Harmonic function multiplier
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_t', c_float),         # [  90] Time/frequency
         ('m_f1', c_float),        #        Amplitude value
         ('m_phi1', c_float),      # [  90] phase value
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime if > starttime
         ('m_s', c_float),         #        impactfactor
         ('m_f2', c_float),        #        Amplitude value for T/2 (Fourier)
         ('m_phi2', c_float),      # [  90] phase value for f2
         ('m_f3', c_float),        #        Amplitude value for T/3 (Fourier)
         ('m_phi3', c_float),      # [  90] phase value for f3
         ('m_f4', c_float),        #        Amplitude value for T/4 (Fourier)
         ('m_phi4', c_float)       # [  90] phase value for f4
      ]
clc_fsinm = CLC_FSINM()

class CLC_FSTP(Structure):         # 13/LC:12  Periodic stepping function additive
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_t', c_float),         # [  90] Time/frequency
         ('m_f', c_float),         #        Amplitude value
         ('m_tc', c_float),        # [  90] contact time
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime if > starttime
         ('m_s', c_float)          #        impactfactor (Sailer/H-ttner/Bachmann)
      ]
clc_fstp = CLC_FSTP()

class CLC_FSTPM(Structure):        # 13/LC:22  Periodic stepping function multiplier
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_t', c_float),         # [  90] Time/frequency
         ('m_f', c_float),         #        Amplitude value
         ('m_tc', c_float),        # [  90] contact time
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime if > starttime
         ('m_s', c_float)          #        impactfactor (Sailer/H-ttner/Bachmann)
      ]
clc_fstpm = CLC_FSTPM()

class CLC_FINA(Structure):         # 13/LC:13  Aperiodic function additive
   _fields_ = [
         ('m_id', c_int),          #        identifier 13
         ('m_t', c_float),         # [  90] Total Time
         ('m_f', c_float),         #        Amplitude value
         ('m_t1', c_float),        # [  90] Time of constant intensity
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime = tmin+T
         ('m_typ', c_int),         #        Type of function
         ('m_f2', c_float),        #        Amplitude factor
         ('m_t2', c_float),        # [  90] lead in time duration
         ('m_f3', c_float),        #        Amplitude factor
         ('m_t3', c_float)         # [  90] lead out time duration
      ]
clc_fina = CLC_FINA()

class CLC_FINM(Structure):         # 13/LC:23  Aperiodic function multiplier
   _fields_ = [
         ('m_id', c_int),          #        identifier 13
         ('m_t', c_float),         # [  90] Total Time
         ('m_f', c_float),         #        Amplitude value
         ('m_t1', c_float),        # [  90] Time of constant intensity
         ('m_tmin', c_float),      # [  90] starttime
         ('m_tmax', c_float),      # [  90] stoptime = tmin+T
         ('m_typ', c_int),         #        Type of function
         ('m_f2', c_float),        #        Amplitude factor
         ('m_t2', c_float),        # [  90] lead in time duration
         ('m_f3', c_float),        #        Amplitude factor
         ('m_t3', c_float)         # [  90] lead out time duration
      ]
clc_finm = CLC_FINM()

class CLC_RESW(Structure):         # 13/LC:9??  Response spectra wind
   _fields_ = [
         ('m_typ', c_int),         #        Type of spectra 900 - 999
         ('m_sint', c_float),      #        Integral of spectra
         ('m_a1', c_float),        #        Spectrum coefficient
         ('m_a2', c_float),        #        Spectrum coefficient
         ('m_a3', c_float),        #        Spectrum coefficient
         ('m_b', c_float),         #        Spectrum coefficient
         ('m_c', c_float),         #        Spectrum coefficient
         ('m_d', c_float),         #        Spectrum coefficient
         ('m_res', c_float * 9),   #        reserved
         ('m_title',  c_int * 17)  #        Designation of Spectra
      ]
clc_resw = CLC_RESW()

class CLC_RESP(Structure):         # 13/LC:???  Response spectra earthquake
   _fields_ = [
         ('m_typ', c_int),         #        Type of spectra 100 - 999
         ('m_d', c_float),         #        Damping value eta or behaviour factor q
         ('m_sa', c_float),        #        Rigid acceleration factor (Soil Parameter S)
         ('m_sb', c_float),        #        Max acceleration factor
         ('m_smin', c_float),      #        Min acceleration factor (beta)
         ('m_tb', c_float),        # [  90] Time value
         ('m_tc', c_float),        # [  90] Time value
         ('m_td', c_float),        # [  90] Time value
         ('m_te', c_float),        # [  90] Cutt-Off Time
         ('m_k1', c_float),        #        Coefficient k1
         ('m_k2', c_float),        #        Coefficient k2
         ('m_zone', c_int * 3),    #        Earthquake zone
         ('m_ag', c_float),        # [1202] Reference base acceleration
         ('m_ah', c_float),        #        Horizontal factor (importance etc.)
         ('m_av', c_float),        #        Vertical factor
         ('m_title',  c_int * 17)  #        Designation of Spectra
      ]
clc_resp = CLC_RESP()

class CLC_FREF(Structure):         # 13/LC:????  Discrete reference function values
   _fields_ = [
         ('m_id', c_int),          #        line type
         ('m_tt', c_float),        #        Time/frequency
         ('m_f', c_float * 2)      #        function values
      ]
clc_fref = CLC_FREF()

class CACT_TASK_SCOM(Structure):   #        index,factor and name of items
   _fields_ = [
         ('m_ind', c_int),
         ('m_fak', c_float),
         ('m_bez', c_int)
      ]
cact_task_scom = CACT_TASK_SCOM()

class CACT_TASK(Structure):        # 14/0  Superposition task commands
   _fields_ = [
         ('m_ivers', c_int),       #        < 9999 = old data format (ACT_RULE)
         ('m_num', c_int),         #        number of superposition command
         ('m_act', c_int),         #        number of groups of actions at 14/act
         ('m_lfm', c_int * 2),     #        base of load case numbers
         ('m_ksav', c_int),        #        0 = do not save, >0 = save factors as combination KSAV
         ('m_kwerg', c_int),       #        Identifier of resultrecord in CDB
         ('m_from', c_int),        #        smallest  element number
         ('m_to', c_int),          #        highest   element number
         ('m_inc', c_int),         #        increment element number
         ('m_tid', c_int),         #        optional identifier
         ('m_x', c_float),         # [1001] X-ordinate for beams (see INC!)
         ('m_comb', c_int),        #        combination method for items given at SCOM
         ('m_scom',  CACT_TASK_SCOM * 9), #        index,factor and name of items
         ('m_txt',  c_int * 33),   #        Name of superposition
         ('m_uform', c_int * 128)  #        User defined target function (index == 0!)
      ]
cact_task = CACT_TASK()

class CACT_RULE_SCOM(Structure):   #        index,factor and name of items
   _fields_ = [
         ('m_ind', c_int),
         ('m_fak', c_float),
         ('m_bez', c_int)
      ]
cact_rule_scom = CACT_RULE_SCOM()

class CACT_RULE(Structure):        # 14/0  Superposition commands (old Version)
   _fields_ = [
         ('m_num', c_int),         #        number of superposition command
         ('m_act', c_int),         #        number of groups of actions at 14/act
         ('m_lfm', c_int * 2),     #        base of load case numbers
         ('m_kwerg', c_int),       #        Identifier of resultrecord in CDB
         ('m_from', c_int),        #        smallest  element number (echo only)
         ('m_to', c_int),          #        highest   element number (echo only)
         ('m_inc', c_int),         #        increment element number (echo only)
         ('m_tid', c_int),         #        optional identifier
         ('m_comb', c_int),        #        combination method for items given at SCOM
         ('m_scom',  CACT_RULE_SCOM * 9), #        index,factor and name of items
         ('m_txt',  c_int * 33)    #        Name of superposition
      ]
cact_rule = CACT_RULE()

class CLC_ACT0(Structure):         # 14/NR:0  Group of Actions for SUPP-task
   _fields_ = [
         ('m_id', c_int),          #        ident = 0  user defined ; < 0 automatic
         ('m_lfb', c_int),         #        load case offset
         ('m_extr', c_int),        #        type of formula for evaluating the extrema
         ('m_type', c_int),        #        type or action of resulting load case
         ('m_txt',  c_int * 17)    #        Group designation for collection of actions
      ]
clc_act0 = CLC_ACT0()

class CLC_CACT0(Structure):        # 12/LC:80  Group of Actions for SUPP-task
   _fields_ = [
         ('m_id', c_int),          #        ident = 0  user defined ; < 0 automatic
         ('m_lfb', c_int),         #        load case offset
         ('m_extr', c_int),        #        type of formula for evaluating the extrema
         ('m_type', c_int),        #        type or action of resulting load case
         ('m_txt',  c_int * 17)    #        Group designation for collection of actions
      ]
clc_cact0 = CLC_CACT0()

class CLC_ACT1(Structure):         # 14/NR:1  Action member
   _fields_ = [
         ('m_id', c_int),          #        ident = 1 / 81
         ('m_action', c_int),      #        ID of the action = type of action
         ('m_type', c_int),        #        256*subgroup + 16*Group_of_action + superposition
         ('m_gamu', c_float),      #        safety factor unfavourable
         ('m_gamf', c_float),      #        safety factor favourable
         ('m_psi0', c_float),      #        combination value
         ('m_psi1', c_float),      #        combination value
         ('m_psi2', c_float),      #        quasi permanent combination value
         ('m_ps1s', c_float),      #        non frequent combination value psi1'
         ('m_gama', c_float),      #        safety factor accidential
         ('m_cat', c_int),         #        category (see 14/IDT) not used here
         ('m_txt',  c_int * 17)    #        designation
      ]
clc_act1 = CLC_ACT1()

class CLC_CACT1(Structure):        # 12/NR:81  current action member
   _fields_ = [
         ('m_id', c_int),          #        ident = 1 / 81
         ('m_action', c_int),      #        ID of the action = type of action
         ('m_type', c_int),        #        256*subgroup + 16*Group_of_action + superposition
         ('m_gamu', c_float),      #        safety factor unfavourable
         ('m_gamf', c_float),      #        safety factor favourable
         ('m_psi0', c_float),      #        combination value
         ('m_psi1', c_float),      #        combination value
         ('m_psi2', c_float),      #        quasi permanent combination value
         ('m_ps1s', c_float),      #        non frequent combination value psi1'
         ('m_gama', c_float),      #        safety factor accidential
         ('m_cat', c_int),         #        category (see 14/IDT) not used here
         ('m_txt',  c_int * 17)    #        designation
      ]
clc_cact1 = CLC_CACT1()

class CLC_ACT_L(Structure):        # 14/NR:2  loadcase of action
   _fields_ = [
         ('m_id', c_int),          #        ident = 2 / 82
         ('m_lf', c_int),          #        load case number
         ('m_type', c_int),        #        load case action type
         ('m_fact', c_float)       #        factor
      ]
clc_act_l = CLC_ACT_L()

class CLC_CACT2(Structure):        # 12/NR:82  current loadcase of action
   _fields_ = [
         ('m_id', c_int),          #        ident = 2 / 82
         ('m_lf', c_int),          #        load case number
         ('m_type', c_int),        #        load case action type
         ('m_fact', c_float)       #        factor
      ]
clc_cact2 = CLC_CACT2()

class CLC_ACT_R(Structure):        # 14/NR:1?  Response Spectra
   _fields_ = [
         ('m_id', c_int),          #        Evaluation type of response
         ('m_resp', c_int),        #        load case number of spectra
         ('m_lfeig', c_int),       #        load case of first eigenform
         ('m_neig', c_int)         #        numbers of eigenforms to be used
      ]
clc_act_r = CLC_ACT_R()

class CLC_ACT(Structure):          # 14/IDT:1  Action defaults
   _fields_ = [
         ('m_id', c_int),          #        ident = 1
         ('m_action', c_int),      #        ID of the real action = type of action
         ('m_type', c_int),        #        256*subgroup + 16*Group_of_action + superposition
         ('m_gamu', c_float),      #        safety factor unfavourable
         ('m_gamf', c_float),      #        safety factor favourable
         ('m_psi0', c_float),      #        combination value
         ('m_psi1', c_float),      #        combination value
         ('m_psi2', c_float),      #        quasi permanent combination value
         ('m_ps1s', c_float),      #        non frequent combination value psi1'
         ('m_gama', c_float),      #        safety factor accidential
         ('m_cat', c_int),         #        category for preselection of psi-values
         ('m_txt',  c_int * 17)    #        designation
      ]
clc_act = CLC_ACT()

class CCSM_GRP(Structure):         # 15/-1  Construction Stage Group Definitions
   _fields_ = [
         ('m_grp', c_int),         #        Group number
         ('m_ics', c_int),         #        CS number of first activation
         ('m_gfix', c_int),        #        CS number of hinge fixing
         ('m_end', c_int),         #        CS number of last action
         ('m_free', c_int * 2),    #        free integer for later use
         ('m_t0', c_float)         # [  93] minimum age for loading
      ]
ccsm_grp = CCSM_GRP()

class CCSM_LC(Structure):          # 15/-2  Construction Stage Loadcase Definitions
   _fields_ = [
         ('m_lc', c_int),          #        Loadcase
         ('m_start', c_int),       #        CS number for first action
         ('m_end', c_int)          #        CS number of last action
      ]
ccsm_lc = CCSM_LC()

class CCSM_CS(Structure):          # 15/-3  Construction Stage Table
   _fields_ = [
         ('m_cs', c_int),          #        Construction Stage
         ('m_id', c_int),          #        Main action type in this CS
         ('m_cstep', c_int),       #        number of creep+shrink step to be produced
         ('m_dl_cs', c_int),       #        dead load activation in composite cross sections
         ('m_free', c_int * 2),    #        free integer for later use
         ('m_dt', c_float),        # [  93] duration of creep+shrink step
         ('m_rh', c_float),        # [   8] relative humidity in this creep+shrink step
         ('m_temp', c_float)       # [   8] temperture in this creep+shrink step
      ]
ccsm_cs = CCSM_CS()

class CCSM_CREE(Structure):        # 15/-4  creep+shrink values for manual input
   _fields_ = [
         ('m_mno', c_int),         #        Material number
         ('m_grp', c_int),         #        Group number
         ('m_phi', c_float),       #        total creep factor from first loading til infinite
         ('m_eps', c_float),       #        total shrinkage coefficient
         ('m_relax', c_float)      #        total tendon relaxation
      ]
ccsm_cree = CCSM_CREE()

class CCSG_CS(Structure):          # 15/-10  Construction Stage
   _fields_ = [
         ('m_no', c_int),          #        construction stage number
         ('m_titl', c_int * 32),   #        Designation
         ('m_dt', c_float)         # [  93] duration of construction stage
      ]
ccsg_cs = CCSG_CS()

class CCSG_CGRP(Structure):        # 15/-11  Group specification
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_no', c_int),          #        group number
         ('m_act', c_int),         #        group action
         ('m_act2', c_int),        #        group action cont'd
         ('m_ptyp', c_int),        #        type of prestressing
         ('m_plq', c_int),         #        primary load case swelling
         ('m_mno', c_int),         #        material number
         ('m_facs', c_float),      #        stiffness factor
         ('m_alph', c_float),      #        alpha factor
         ('m_hw', c_float),        # [  13] ground water level
         ('m_k', c_float),         #        earth pressure coefficient
         ('m_p', c_float)          #        prestress force
      ]
ccsg_cgrp = CCSG_CGRP()

class CCSG_CLAS(Structure):        # 15/-12  Load specification
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_no', c_int),          #        number of referenced loadcase
         ('m_opt', c_int),         #        option of the load
         ('m_fact', c_float)       #        factor for loads
      ]
ccsg_clas = CCSG_CLAS()

class CCSG_CSYS(Structure):        # 15/-13  System specification
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_prob', c_int)         #        problem type
      ]
ccsg_csys = CCSG_CSYS()

class CCSG_CCRL(Structure):        # 15/-14  Computation control
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_opt', c_int),         #        control option
         ('m_save', c_int),        #        save interval
         ('m_facq', c_int),        #        not used
         ('m_val', c_float),       #        value of the option
         ('m_fmax', c_float),      #        2nd value of the option
         ('m_fmin', c_float),      #        3rd value of the option
         ('m_emax', c_float),      #        4th value of the option
         ('m_emin', c_float),      #        5th value of the option
         ('m_v6', c_float),        #        6th value of the option
         ('m_v7', c_float),        #        7th value of the option
         ('m_v8', c_float)         #        8th value of the option
      ]
ccsg_ccrl = CCSG_CCRL()

class CCSG_CGW(Structure):         # 15/-15  Change ground water level
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_hw', c_float)         # [  13] new ground water level
      ]
ccsg_cgw = CCSG_CGW()

class CCSG_ECHO(Structure):        # 15/-16  Echo options
   _fields_ = [
         ('m_ics', c_int),         #        corresponding cs number
         ('m_opt', c_int),         #        echo option
         ('m_val', c_int)          #        value of the option
      ]
ccsg_echo = CCSG_ECHO()

class CCSM_LC1(Structure):         # 15/LC:1  CSM loadcase parameters Group members
   _fields_ = [
         ('m_id', c_int),          #        identifier 1
         ('m_grp', c_int),         #        Group number
         ('m_t1', c_float),        # [  93] age at the end of loadcase
         ('m_sumeps', c_float)     #        accumulated shrinkage strain
      ]
ccsm_lc1 = CCSM_LC1()

class CCSM_LC2(Structure):         # 15/LC:2  CSM loadcase parameters quad-tendon members
   _fields_ = [
         ('m_id', c_int),          #        identifier 2
         ('m_grp', c_int),         #        quad-tendon number
         ('m_t1', c_float),        # [  93] age at the end of loadcase
         ('m_sumrelax', c_float)   #        accumulated quad-tendon relaxation
      ]
ccsm_lc2 = CCSM_LC2()

class CVIEW(Structure):            # 18/-1  View definitions (Exchange ANIMATOR-WINGRAF)
   _fields_ = [
         ('m_iachs', c_int),       #        downward direction (compare 10/0)
         ('m_pers', c_int),        #        Perspective
         ('m_lc', c_int),          #        loadcase
         ('m_vopt', c_int),        #        View Options (Bitcode I)
         ('m_eopt', c_int),        #        Element Options (Bitcode II)
         ('m_copt', c_int),        #        Colour Options (Bitcode III)
         ('m_dummy', c_int * 3),   #        reserved
         ('m_topt', c_int),        #        Exchange option
         ('m_xbl', c_float),       # [1001] X-coordinate of view point
         ('m_ybl', c_float),       # [1001] Y-coordinate of view point
         ('m_zbl', c_float),       # [1001] Z-coordinate of view point
         ('m_xcam', c_float),      # [1001] X-coordinate of camera point
         ('m_ycam', c_float),      # [1001] Y-coordinate of camera point
         ('m_zcam', c_float),      # [1001] Z-coordinate of camera point
         ('m_fakv', c_float),      #        Factor of deformed structure
         ('m_ssiz', c_float),      #        Size of supports (0.-100.)
         ('m_wmag', c_float),      #        Warping magnification (0.-100.)
         ('m_fovy', c_float),      # [   5] perspective angle of field of view
         ('m_xup', c_float),       #        X-part Up Vector
         ('m_yup', c_float),       #        Y-part Up Vector
         ('m_zup', c_float)        #        Z-part Up Vector
      ]
cview = CVIEW()

class CVIEW_SEL_R(Structure):      #        Range lower and upper limit
   _fields_ = [
         ('m_low', c_int),
         ('m_upp', c_int)
      ]
cview_sel_r = CVIEW_SEL_R()

class CVIEW_SEL(Structure):        # 18/-2  currently selected elements in WINGRAF
   _fields_ = [
         ('m_id', c_int),          #        Identifikator
         ('m_r',  CVIEW_SEL_R * 32)  #        Range lower and upper limit
      ]
cview_sel = CVIEW_SEL()

class CVIEW_SRE(Structure):        # 18/-3  currently selected results in WINGRAF
   _fields_ = [
         ('m_kwh', c_int),         #        Main key of current item
         ('m_kwl', c_int),         #        Secondary key of cuurent item (LF,MAT)
         ('m_values', c_int * 14)  #        Selected values of this record type
      ]
cview_sre = CVIEW_SRE()

class CMTXT_0(Structure):          # 18/-4:0  Header for membrane manufacturing
   _fields_ = [
         ('m_id', c_int),          #        identificator = 0
         ('m_lf', c_int),          #        used load case of a deformed structure Lastfallnummer einer ver
         ('m_bits', c_int),        #        Bitpattern of conditions of evaluation
         ('m_nfl', c_int),         #        Number of manufacturing areas
         ('m_nqu', c_int),         #        total number of QUADS within those areas
         ('m_nno', c_int)          #        Number of new nodes inserted
      ]
cmtxt_0 = CMTXT_0()

class CMTXT_NOD(Structure):        # 18/-4:-  Definition of new nodes
   _fields_ = [
         ('m_no', c_int),          #        Number of new interpolated node
         ('m_quad', c_int),        #        Nummer of QUAD-element containing this node
         ('m_s', c_float),         #        S-Koordinate im QUAD-Element
         ('m_t', c_float)          #        T-Koordinate im QUAD-Element
      ]
cmtxt_nod = CMTXT_NOD()

class CMTXT_ELM(Structure):        # 18/-4:+  Definition of manufacturing elements
   _fields_ = [
         ('m_no', c_int),          #        Number of manufacturing area
         ('m_quad', c_int),        #        Number of QUAD-element
         ('m_n1', c_int),          #        1st node (< 0 if new interpolated node)
         ('m_n2', c_int),          #        2nd node (< 0 if new interpolated node)
         ('m_n3', c_int),          #        3rd node (< 0 if new interpolated node)
         ('m_n4', c_int)           #        4th node (< 0 if new interpolated node)
      ]
cmtxt_elm = CMTXT_ELM()

class CVIEW_MCO(Structure):        # 18/-5  Colour of material
   _fields_ = [
         ('m_no', c_int),          #        Number of material / group
         ('m_red', c_float),       #        RGBA: red color
         ('m_green', c_float),     #        RGBA: green color
         ('m_blue', c_float),      #        RGBA: blue color
         ('m_alpha', c_float)      #        RGBA: alpha value
      ]
cview_mco = CVIEW_MCO()

class CVIEW_GCO(Structure):        # 18/-6  Colour of group
   _fields_ = [
         ('m_no', c_int),          #        Number of material / group
         ('m_red', c_float),       #        RGBA: red color
         ('m_green', c_float),     #        RGBA: green color
         ('m_blue', c_float),      #        RGBA: blue color
         ('m_alpha', c_float)      #        RGBA: alpha value
      ]
cview_gco = CVIEW_GCO()

class CANI_SELE(Structure):        # 18/-101:1  Dialogbox Animator selection request
   _fields_ = [
         ('m_sele', c_int),        #        identifier 1 : selection request
         ('m_igrp', c_int),        #        element-group switch
         ('m_nsel', c_int),        #        necessary-possible amount of selected elements
         ('m_etyp', c_int),        #        requested element type - multiple records allowed
         ('m_from', c_int),        #        select only elements or groups from FROM to TO
         ('m_to', c_int)           #        TO
      ]
cani_sele = CANI_SELE()

class CANI_CTRL(Structure):        # 18/-101:2  Dialogbox Animator drawing controls
   _fields_ = [
         ('m_sele', c_int),        #        identifier 2 : drawing controls
         ('m_igrp', c_int),        #        element-group switch as in record 018/-101
         ('m_nsel', c_int),        #        free
         ('m_etyp', c_int),        #        element type - see 018/-101:1
         ('m_from', c_int),        #        drawing controls for elements/groups from FROM to TO
         ('m_to', c_int),          #        TO
         ('m_style', c_int),       #        representation style guide number
         ('m_rgba', c_float * 4)   #        colour and transparency factor - only for STYLE=1
      ]
cani_ctrl = CANI_CTRL()

class CANI_SRES(Structure):        # 18/-103  Selection result from Animator
   _fields_ = [
         ('m_id101', c_int),       #        access ID of 18/-101 to check if selection allready done
         ('m_igrp', c_int),        #        element-group switch as defined in 018/-101
         ('m_isel', c_int),        #        termination control
         ('m_etyp', c_int),        #        element type - see 018/-101:1
         ('m_from', c_int),        #        first selected element or group
         ('m_to', c_int),          #        last "
         ('m_free', c_int),        #        not used
         ('m_x', c_float)          # [1001] sectional abscissa
      ]
cani_sres = CANI_SRES()

class CLC_SELF(Structure):         # 18/LCD  Self weight loading of elements from ASE
   _fields_ = [
         ('m_kwh', c_int),         #        Type of load element
         ('m_nr', c_int),          #        all other values as in KWH/LC
         ('m_typ', c_int),         #        all other values as in KWH/LC
         ('m_pval', c_float * 9999)  #        all other values as in KWH/LC
      ]
clc_self = CLC_SELF()

class CGRP_BIL(Structure):         # 19/LC  Bilances of Flow in HYDRA
   _fields_ = [
         ('m_id', c_int),          #        type of result
         ('m_nr', c_int),          #        group number
         ('m_qinp', c_float),      #        Quantity of inflow
         ('m_qout', c_float),      #        Quantity of outflow
         ('m_qnew', c_float),      #        Quantity generated in domain
         ('m_ener', c_float)       #        Energy term
      ]
cgrp_bil = CGRP_BIL()

class CNODE(Structure):            # 20/00  Nodes
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_inr', c_int),         #        internal node-number
         ('m_kfix', c_int),        #        degree of freedoms
         ('m_ncod', c_int),        #        additional bit code
         ('m_xyz', c_float * 3)    # [1001] X-Y-Z-ordinates
      ]
cnode = CNODE()

class CNODE_GRC(Structure):        # 20/11:0  number of Nodegroups
   _fields_ = [
         ('m_id', c_int),
         ('m_maxgrp', c_int)       #        maximum number of groups per node
      ]
cnode_grc = CNODE_GRC()

class CNODE_GRP(Structure):        # 20/11:+  Nodegroups
   _fields_ = [
         ('m_n', c_int),           #        node-number
         ('m_igrp', c_int * 9999)  #        group-numbers connecting to node
      ]
cnode_grp = CNODE_GRP()

class CNODE_KIC(Structure):        # 21/00:0  Info on kinematic constraints
   _fields_ = [
         ('m_id', c_int),
         ('m_nlev', c_int),        #        depth of recurent coupling (obsolete)
         ('m_nkin', c_int),        #        maximum number of coupling equations
         ('m_nvar', c_int)         #        maximum number of coupling factors
      ]
cnode_kic = CNODE_KIC()

class CNODE_KIN(Structure):        # 21/00:+  Standard kinematic constraint
   _fields_ = [
         ('m_ktl', c_int),         #        type + 100 * depth + 10000*group-number
         ('m_nr', c_int),          #        node-number
         ('m_kr', c_int * 2),      #        reference nodes
         ('m_dxyz', c_float * 3),  #        direction of coupling X/Y/Z-axis
         ('m_dd', c_float),        #        factor of interpolation for INTP/INTF/INTS
         ('m_ff', c_float)         #        factor of multiplication (not used)
      ]
cnode_kin = CNODE_KIN()

class CNODE_KIG_ID(Structure):     #        node+degree-number of dependent (0)
   _fields_ = [
         ('m_nr', c_int),
         ('m_nd', c_int)
      ]
cnode_kig_id = CNODE_KIG_ID()

class CNODE_KIG(Structure):        # 21/00:*99  general constraints (equation list)
   _fields_ = [
         ('m_ktl', c_int),
         ('m_id',  CNODE_KIG_ID * 256)  #        node+degree-number of dependent (0)
      ]
cnode_kig = CNODE_KIG()

class CNODE_KIF(Structure):        # 21/00:*99  general constraints (factor list)
   _fields_ = [
         ('m_ktl', c_int),         #        99 + 100 * depth
         ('m_id', c_int),          #        identifier 0
         ('m_fr', c_float * 255)   #        factors of constrained equation
      ]
cnode_kif = CNODE_KIF()

class CNODE_KIH(Structure):        # 21/09  Hydraulic couplings
   _fields_ = [
         ('m_ng', c_int),          #        group-number
         ('m_nr', c_int),          #        node-number
         ('m_kr', c_int)           #        reference node
      ]
cnode_kih = CNODE_KIH()

class CNODE_KFC(Structure):        # 22/LC:0  Max. Constraining Forces
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_px', c_float),        # [1190] force component X
         ('m_py', c_float),        # [1190] force component Y
         ('m_pz', c_float),        # [1190] force component Z
         ('m_mx', c_float),        # [1194] moment component X
         ('m_my', c_float),        # [1194] moment component Y
         ('m_mz', c_float),        # [1194] moment component Z
         ('m_mb', c_float)         # [1194] warping moment
      ]
cnode_kfc = CNODE_KFC()

class CNODE_KFO(Structure):        # 22/LC:+  Constraining forces
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_px', c_float),        # [1190] force component X
         ('m_py', c_float),        # [1190] force component Y
         ('m_pz', c_float),        # [1190] force component Z
         ('m_mx', c_float),        # [1194] moment component X
         ('m_my', c_float),        # [1194] moment component Y
         ('m_mz', c_float),        # [1194] moment component Z
         ('m_mb', c_float)         # [1194] warping moment
      ]
cnode_kfo = CNODE_KFO()

class CNODE_L(Structure):          # 23/LC:+  Nodal_loads
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_typ', c_int),         #        type of load
         ('m_px', c_float),        # [1190] single force X-component
         ('m_py', c_float),        # [1190] single force Y-component
         ('m_pz', c_float),        # [1190] single force Z-component
         ('m_mx', c_float),        # [1194] single moment X-component
         ('m_my', c_float),        # [1194] single moment Y-component
         ('m_mz', c_float),        # [1194] single moment Z-component
         ('m_mb', c_float)         # [1195] warping moment
      ]
cnode_l = CNODE_L()

class CNODE_LW(Structure):         # 23/LC:+  prescribed support displacements
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_typ', c_int),         #        type of load
         ('m_wx', c_float),        # [1003] Displacement X
         ('m_wy', c_float),        # [1003] Displacement Y
         ('m_wz', c_float),        # [1003] Displacement Z
         ('m_rx', c_float),        # [1004] Rotation X-X
         ('m_ry', c_float),        # [1004] Rotation Y-Y
         ('m_rz', c_float)         # [1004] Rotation Z-Z
      ]
cnode_lw = CNODE_LW()

class CNODE_ACC(Structure):        # 23/LC:*  Base acceleration
   _fields_ = [
         ('m_nr', c_int),          #        node number / influence load case
         ('m_typ', c_int),         #        type of load (=10)
         ('m_ax', c_float),        # [1202] transversal acceleration X
         ('m_ay', c_float),        # [1202] transversal acceleration Y
         ('m_az', c_float),        # [1202] transversal acceleration Z
         ('m_axx', c_float),       # [1207] rotational acceleration X-X
         ('m_ayy', c_float),       # [1207] rotational acceleration Y-Y
         ('m_azz', c_float),       # [1207] rotational acceleration Z-Z
         ('m_ex', c_float),        # [1001] reference point for rotational acceleration
         ('m_ey', c_float),        # [1001] reference point for rotational acceleration
         ('m_ez', c_float),        # [1001] reference point for rotational acceleration
         ('m_exref', c_float)      #        V25: if a value is present (length criteria)
      ]
cnode_acc = CNODE_ACC()

class CNODE_LA(Structure):         # 23/LC:+  prescribed nodal accelerations
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_typ', c_int),         #        type of load
         ('m_ax', c_float),        # [1003] acceleration X
         ('m_ay', c_float),        # [1003] acceleration Y
         ('m_az', c_float),        # [1003] acceleration Z
         ('m_arx', c_float),       # [1004] Rotation X-X
         ('m_ary', c_float),       # [1004] Rotation Y-Y
         ('m_arz', c_float)        # [1004] Rotation Z-Z
      ]
cnode_la = CNODE_LA()

class CNODE_ROT(Structure):        # 23/LC:+  Rotation of Body
   _fields_ = [
         ('m_nr', c_int),          #        influence reference
         ('m_typ', c_int),         #        type of load (=20)
         ('m_axx', c_float),       # [1207] rotational acceleration X-X  (= vxx**2)
         ('m_ayy', c_float),       # [1207] rotational acceleration Y-Y  (= vyy**2)
         ('m_azz', c_float),       # [1207] rotational acceleration Z-Z  (= vzz**2)
         ('m_ex', c_float),        # [1001] reference point for rotational acceleration
         ('m_ey', c_float),        # [1001] reference point for rotational acceleration
         ('m_ez', c_float)         # [1001] reference point for rotational acceleration
      ]
cnode_rot = CNODE_ROT()

class CN_DISPC(Structure):         # 24/LC:0  Max. Displacements and support forces
   _fields_ = [
         ('m_id', c_int),
         ('m_ux', c_float),        # [1003] displacement X
         ('m_uy', c_float),        # [1003] displacement Y
         ('m_uz', c_float),        # [1003] displacement Z
         ('m_urx', c_float),       # [1004] rotation X
         ('m_ury', c_float),       # [1004] rotation Y
         ('m_urz', c_float),       # [1004] rotation Z
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support X
         ('m_py', c_float),        # [1151] nodal support Y
         ('m_pz', c_float),        # [1151] nodal support Z
         ('m_mx', c_float),        # [1152] support moment X
         ('m_my', c_float),        # [1152] support moment Y
         ('m_mz', c_float),        # [1152] support moment Z
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_dispc = CN_DISPC()

class CN_DISPIC(Structure):        # 26/LC:0  Max. Displacement and forces increments
   _fields_ = [
         ('m_id', c_int),
         ('m_ux', c_float),        # [1003] displacement X
         ('m_uy', c_float),        # [1003] displacement Y
         ('m_uz', c_float),        # [1003] displacement Z
         ('m_urx', c_float),       # [1004] rotation X
         ('m_ury', c_float),       # [1004] rotation Y
         ('m_urz', c_float),       # [1004] rotation Z
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support X
         ('m_py', c_float),        # [1151] nodal support Y
         ('m_pz', c_float),        # [1151] nodal support Z
         ('m_mx', c_float),        # [1152] support moment X
         ('m_my', c_float),        # [1152] support moment Y
         ('m_mz', c_float),        # [1152] support moment Z
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_dispic = CN_DISPIC()

class CN_DISPTC(Structure):        # 27/LC:0  Max. Cooordinate offsets
   _fields_ = [
         ('m_id', c_int),
         ('m_ux', c_float),        # [1003] displacement X
         ('m_uy', c_float),        # [1003] displacement Y
         ('m_uz', c_float),        # [1003] displacement Z
         ('m_urx', c_float),       # [1004] rotation X
         ('m_ury', c_float),       # [1004] rotation Y
         ('m_urz', c_float),       # [1004] rotation Z
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support X
         ('m_py', c_float),        # [1151] nodal support Y
         ('m_pz', c_float),        # [1151] nodal support Z
         ('m_mx', c_float),        # [1152] support moment X
         ('m_my', c_float),        # [1152] support moment Y
         ('m_mz', c_float),        # [1152] support moment Z
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_disptc = CN_DISPTC()

class CN_DISP(Structure):          # 24/LC:+  Displacements and support forces of nodes
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_ux', c_float),        # [1003] displacement
         ('m_uy', c_float),        # [1003] displacement
         ('m_uz', c_float),        # [1003] displacement
         ('m_urx', c_float),       # [1004] rotation
         ('m_ury', c_float),       # [1004] rotation
         ('m_urz', c_float),       # [1004] rotation
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support
         ('m_py', c_float),        # [1151] nodal support
         ('m_pz', c_float),        # [1151] nodal support
         ('m_mx', c_float),        # [1152] support moment
         ('m_my', c_float),        # [1152] support moment
         ('m_mz', c_float),        # [1152] support moment
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_disp = CN_DISP()

class CN_DISPI(Structure):         # 26/LC:+  Displacement increments and residual forces
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_ux', c_float),        # [1003] displacement
         ('m_uy', c_float),        # [1003] displacement
         ('m_uz', c_float),        # [1003] displacement
         ('m_urx', c_float),       # [1004] rotation
         ('m_ury', c_float),       # [1004] rotation
         ('m_urz', c_float),       # [1004] rotation
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support
         ('m_py', c_float),        # [1151] nodal support
         ('m_pz', c_float),        # [1151] nodal support
         ('m_mx', c_float),        # [1152] support moment
         ('m_my', c_float),        # [1152] support moment
         ('m_mz', c_float),        # [1152] support moment
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_dispi = CN_DISPI()

class CN_DISPT(Structure):         # 27/LC:+  Cooordinate offsets
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_ux', c_float),        # [1003] displacement
         ('m_uy', c_float),        # [1003] displacement
         ('m_uz', c_float),        # [1003] displacement
         ('m_urx', c_float),       # [1004] rotation
         ('m_ury', c_float),       # [1004] rotation
         ('m_urz', c_float),       # [1004] rotation
         ('m_urb', c_float),       # [1005] twisting
         ('m_px', c_float),        # [1151] nodal support
         ('m_py', c_float),        # [1151] nodal support
         ('m_pz', c_float),        # [1151] nodal support
         ('m_mx', c_float),        # [1152] support moment
         ('m_my', c_float),        # [1152] support moment
         ('m_mz', c_float),        # [1152] support moment
         ('m_mb', c_float)         # [1105] warping moment
      ]
cn_dispt = CN_DISPT()

class CN_VELOC(Structure):         # 25/LC:0  Max. velocities and accelerations of nodes
   _fields_ = [
         ('m_id', c_int),
         ('m_vx', c_float),        # [1201] velocity X
         ('m_vy', c_float),        # [1201] velocity Y
         ('m_vz', c_float),        # [1201] velocity Z
         ('m_vrx', c_float),       # [1206] angular veloc. XX
         ('m_vry', c_float),       # [1206] angular veloc. YY
         ('m_vrz', c_float),       # [1206] angular veloc. ZZ
         ('m_vbb', c_float),       # [1208] twisting velocity
         ('m_ax', c_float),        # [1202] acceleration X
         ('m_ay', c_float),        # [1202] acceleration Y
         ('m_az', c_float),        # [1202] acceleration Z
         ('m_arx', c_float),       # [1207] ang. acceler. XX
         ('m_ary', c_float),       # [1207] ang. acceler. YY
         ('m_arz', c_float),       # [1207] ang. acceler. ZZ
         ('m_abb', c_float)        # [1209] twisting acceler
      ]
cn_veloc = CN_VELOC()

class CN_VELO(Structure):          # 25/LC:+  velocitys and acceleration of nodes
   _fields_ = [
         ('m_nr', c_int),          #        node-number
         ('m_vx', c_float),        # [1201] velocity X
         ('m_vy', c_float),        # [1201] velocity Y
         ('m_vz', c_float),        # [1201] velocity Z
         ('m_vrx', c_float),       # [1206] angular veloc. X-X
         ('m_vry', c_float),       # [1206] angular veloc. Y-Y
         ('m_vrz', c_float),       # [1206] angular veloc. Z-Z
         ('m_vbb', c_float),       # [1208] twisting velocity
         ('m_ax', c_float),        # [1202] acceleration X
         ('m_ay', c_float),        # [1202] acceleration Y
         ('m_az', c_float),        # [1202] acceleration Z
         ('m_arx', c_float),       # [1207] ang. acceler. X-X
         ('m_ary', c_float),       # [1207] ang. acceler. Y-Y
         ('m_arz', c_float),       # [1207] ang. acceler. Z-Z
         ('m_abb', c_float)        # [1209] twisting acceler
      ]
cn_velo = CN_VELO()

class CGLN_MATC(Structure):        # 31/0  Heritage of Structural lines
   _fields_ = [
         ('m_nr', c_int),          #        original structural line number
         ('m_ids', c_int * 9999)   #        sequence of sub-lines
      ]
cgln_matc = CGLN_MATC()

class CGAR_MATC(Structure):        # 32/0  Heritage of Structural Areas
   _fields_ = [
         ('m_nr', c_int),          #        original structural area number
         ('m_ids', c_int * 9999)   #        list of sub-areas
      ]
cgar_matc = CGAR_MATC()

class CSPT(Structure):             # 39/NR:0  Structural points
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_ids', c_int),         #        optional identifier of point
         ('m_ref', c_int),         #        reserved reference
         ('m_nog', c_int),         #        reserved number of group
         ('m_nom', c_int),         #        reserved number of material
         ('m_nor', c_int),         #        reserved number of reinforc.
         ('m_ibt', c_int),         #        Bitpattern of element properties
         ('m_ibc', c_int),         #        Boundary condition
         ('m_i_8', c_int),         #        reserved
         ('m_i_9', c_int),         #        reserved
         ('m_xyz', c_float * 3),   # [1001] Coordinates of that point
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_bx', c_float),        # [1001] Dimension in local x
         ('m_by', c_float),        # [1001] Dimension in local y
         ('m_thick', c_float),     # [1010] Plate thickness at that point
         ('m_hmesh', c_float),     # [1001] Mesh density at point
         ('m_res', c_float * 3),   #        reserved
         ('m_text',  c_int * 17)   #        Designation of Point
      ]
cspt = CSPT()

class CSLN(Structure):             # 39/NR:100  Structural lines
   _fields_ = [
         ('m_id', c_int),          #        identifier 100
         ('m_ids', c_int),         #        optional identifier of structural line
         ('m_ref', c_int),         #        reference identifier to a given GAX [chr] or sln [int]
         ('m_sref', c_int),        #        secondary axis enum for GAX references
         ('m_na', c_int),          #        optional identifier of line start point
         ('m_nb', c_int),          #        optional identifier of line end point
         ('m_ibt', c_int),         #        Bitpattern of element properties
         ('m_ibc', c_int),         #        primary boundary condition
         ('m_id8', c_int),         #        reserved
         ('m_id9', c_int),         #        reserved
         ('m_hmesh', c_float),     # [1001] >0.0 = mesh density along line
         ('m_tup', c_float * 3),   #        Vector to define downward direction
         ('m_trot', c_float),      #        Fractional rotation about local x-axis  (obsoleted => :101/:102
         ('m_tal', c_float * 3),   #        Vector to be aligned as local axis      (obsoleted => :101/:102
         ('m_prog', c_float),      #        progression factor (>0 monoton, <0 symmetric)
         ('m_r10', c_float),       #        reserved
         ('m_r11', c_float),       #        reserved
         ('m_r12', c_float),       #        reserved
         ('m_r13', c_float),       #        reserved
         ('m_r14', c_float),       #        reserved
         ('m_r15', c_float),       #        reserved
         ('m_text',  c_int * 17)   #        Designation of Line
      ]
csln = CSLN()

class CSLN_BEAM(Structure):        # 39/NR:101  Properties of beams
   _fields_ = [
         ('m_id', c_int),          #        ident 101
         ('m_typ', c_int),         #        Element type (see 009/NR:90:4 IBTYP)
         ('m_nog', c_int),         #        group number
         ('m_nq', c_int * 2),      #        number cross section start/end
         ('m_np', c_int),          #        number bedding props
         ('m_ibc', c_int * 4),     #        Hinge properties A/E/XA/XE (start/end/internal start/end)
         ('m_div', c_int),         #        type of element subdivision
         ('m_kr', c_float),        #        identifier of local coordinate system orientation
         ('m_r12', c_float),
         ('m_r13', c_float),
         ('m_r14', c_float),
         ('m_r15', c_float),
         ('m_exa', c_float),       # [1001] eccentricity at start
         ('m_eya', c_float),       # [1001] eccentricity at start
         ('m_eza', c_float),       # [1001] eccentricity at start
         ('m_exe', c_float),       # [1001] eccentricity at end
         ('m_eye', c_float),       # [1001] eccentricity at end
         ('m_eze', c_float),       # [1001] eccentricity at end
         ('m_trot', c_float),      #        additional rotation about local x-axis, given as fraction of 36
         ('m_tal', c_float * 3)    #        vector defining the orientation of the local z-axis of the loca
      ]
csln_beam = CSLN_BEAM()

class CGLN_BPRO(Structure):        # 31/NR:101  Properties of beams
   _fields_ = [
         ('m_id', c_int),          #        ident 101
         ('m_typ', c_int),         #        Element type (see 009/NR:90:4 IBTYP)
         ('m_nog', c_int),         #        group number
         ('m_nq', c_int * 2),      #        number cross section start/end
         ('m_np', c_int),          #        number bedding props
         ('m_ibc', c_int * 4),     #        Hinge properties A/E/XA/XE (start/end/internal start/end)
         ('m_div', c_int),         #        type of element subdivision
         ('m_kr', c_float),        #        identifier of local coordinate system orientation
         ('m_r12', c_float),
         ('m_r13', c_float),
         ('m_r14', c_float),
         ('m_r15', c_float),
         ('m_exa', c_float),       # [1001] eccentricity at start
         ('m_eya', c_float),       # [1001] eccentricity at start
         ('m_eza', c_float),       # [1001] eccentricity at start
         ('m_exe', c_float),       # [1001] eccentricity at end
         ('m_eye', c_float),       # [1001] eccentricity at end
         ('m_eze', c_float),       # [1001] eccentricity at end
         ('m_trot', c_float),      #        additional rotation about local x-axis, given as fraction of 36
         ('m_tal', c_float * 3)    #        vector defining the orientation of the local z-axis of the loca
      ]
cgln_bpro = CGLN_BPRO()

class CSLN_SUPP(Structure):        # 39/NR:102  Support of Structural lines
   _fields_ = [
         ('m_id', c_int),          #        identifier 102
         ('m_ids', c_int),         #        type of reference
         ('m_ref', c_int),         #        reference identifier
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_ibc', c_int),         #        Boundary condition / kinematic constraints
         ('m_kr', c_int),          #        local orientation
         ('m_w', c_float),         # [1001] width of support
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float),        # [1096] lateral   bedding
         ('m_cm', c_float),        # [1099] torsional bedding
         ('m_drx', c_float),       #        explicit X direction of support
         ('m_dry', c_float),       #        explicit Y direction of support
         ('m_drz', c_float),       #        explicit Z direction of support
         ('m_d', c_float),         # [1001] distance to coupled line (IDS={5,6,7})
         ('m_r8', c_float),
         ('m_r9', c_float),
         ('m_fka', c_float),       #        factor bedding at start
         ('m_fke', c_float),       #        factor bedding at end
         ('m_trot', c_float),      #        Fractional rotation about local x-axis
         ('m_tal', c_float * 3)    #        Vector to be aligned as local axis
      ]
csln_supp = CSLN_SUPP()

class CGLN_SUPP(Structure):        # 31/NR:102  Support of Structural lines
   _fields_ = [
         ('m_id', c_int),          #        identifier 102
         ('m_ids', c_int),         #        type of reference
         ('m_ref', c_int),         #        reference identifier
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_ibc', c_int),         #        Boundary condition / kinematic constraints
         ('m_kr', c_int),          #        local orientation
         ('m_w', c_float),         # [1001] width of support
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float),        # [1096] lateral   bedding
         ('m_cm', c_float),        # [1099] torsional bedding
         ('m_drx', c_float),       #        explicit X direction of support
         ('m_dry', c_float),       #        explicit Y direction of support
         ('m_drz', c_float),       #        explicit Z direction of support
         ('m_d', c_float),         # [1001] distance to coupled line (IDS={5,6,7})
         ('m_r8', c_float),
         ('m_r9', c_float),
         ('m_fka', c_float),       #        factor bedding at start
         ('m_fke', c_float),       #        factor bedding at end
         ('m_trot', c_float),      #        Fractional rotation about local x-axis
         ('m_tal', c_float * 3)    #        Vector to be aligned as local axis
      ]
cgln_supp = CGLN_SUPP()

class CSLN_EXYZ(Structure):        # 39/NR:120  Explicit nodes on lines
   _fields_ = [
         ('m_id', c_int),          #        identifier = 120
         ('m_id1', c_int),         #        reserved
         ('m_xyz', c_float * 64 * 3)  # [1001] XYZ coordinates
      ]
csln_exyz = CSLN_EXYZ()

class CGLN_EXYZ(Structure):        # 31/NR:120  Explicit nodes on lines
   _fields_ = [
         ('m_id', c_int),          #        identifier = 120
         ('m_id1', c_int),         #        reserved
         ('m_xyz', c_float * 64 * 3)  # [1001] XYZ coordinates
      ]
cgln_exyz = CGLN_EXYZ()

class CSLN_SCT(Structure):         # 39/NR:130  Beams sections
   _fields_ = [
         ('m_id', c_int),          #        identifier = 130
         ('m_reft', c_int),        #        Type of reference
         ('m_ityp', c_int),        #        Bitcodes according 100/NR:0 ITYP
         ('m_i1', c_int),          #        reserved
         ('m_s', c_float)          # [1001] location on geometry
      ]
csln_sct = CSLN_SCT()

class CGLN_SCT(Structure):         # 31/NR:130  Beams sections
   _fields_ = [
         ('m_id', c_int),          #        identifier = 130
         ('m_reft', c_int),        #        Type of reference
         ('m_ityp', c_int),        #        Bitcodes according 100/NR:0 ITYP
         ('m_i1', c_int),          #        reserved
         ('m_s', c_float)          # [1001] location on geometry
      ]
cgln_sct = CGLN_SCT()

class CSAR(Structure):             # 39/NR:200  Structural area
   _fields_ = [
         ('m_id', c_int),          #        identification of general data = 200
         ('m_ids', c_int),         #        identifier of structural area (0=auto)
         ('m_ref', c_int),         #        reference to a given GAR [chr] or SAR [int]
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_nor', c_int),         #        number of reinforc.
         ('m_itp', c_int),         #        Bitpattern for element generation QUAD
         ('m_ibc', c_int),         #        Boundary condition
         ('m_kr', c_int),          #        local orientation QUADs
         ('m_iatr', c_int),        #        Bitpattern for attribut areas (see SBOX_PROP)
         ('m_td', c_float * 5),    # [1010] Constant thickness
         ('m_cb', c_float),        #        bedding factor
         ('m_cq', c_float),        #        tangential bedding factor
         ('m_tup', c_float * 3),   #        Vector to define upward direction
         ('m_trot', c_float),      #        Fractional rotation about local z-axis
         ('m_tal', c_float * 3),   #        Vector to be aligned as local axis
         ('m_h', c_float * 7),     # [1001] mesh density parameters
         ('m_text',  c_int * 17)   #        Designation of surface
      ]
csar = CSAR()

class CSAR_INF(Structure):         # 39/NR:210  GeometricAreaInfo
   _fields_ = [
         ('m_id0', c_int),         #        identifier 210
         ('m_ng', c_int),          #        Type of surface representation
         ('m_gid1', c_int),        #        Axis identifier of first reference axis
         ('m_gid2', c_int),        #        Axis identifier of second reference axis
         ('m_t', c_float * 4 * 3), #        Transformation
         ('m_uv', c_float * 2 * 2) #        umin,umax,vmin,vmax of the parameter plane
      ]
csar_inf = CSAR_INF()

class CSAR_PTS(Structure):         # 39/NR:211  AreaPointonSurface
   _fields_ = [
         ('m_id', c_int),          #        Identifier 211
         ('m_it', c_int),          #        Type of point (see 5/ID:11 for more)
         ('m_m', c_int),           #        Rasterlocation of mesh (0 < m < mgri )
         ('m_n', c_int),           #        Rasterlocation of mesh (0 < n < ngri )
         ('m_w', c_float),         #        the weight of NURBS control point
         ('m_x', c_float),         # [1001] X-ordinate
         ('m_y', c_float),         # [1001] Y-ordinate
         ('m_z', c_float),         # [1001] Z-ordinate
         ('m_t', c_float)          # [1010] Thickness
      ]
csar_pts = CSAR_PTS()

class CSAR_CPI(Structure):         # 39/NR:212  COONsPatchInfo
   _fields_ = [
         ('m_id', c_int),          #        Id = 212
         ('m_it', c_int),          #        Type of blending
         ('m_iu0', c_int),         #        No of geometry line for u=umin (left)
         ('m_iu1', c_int),         #        No of geometry line for u=umax (right)
         ('m_iv0', c_int),         #        No of geometry line for v=vmin (lower)
         ('m_iv1', c_int)          #        No of geometry line for v=vmax (upper)
      ]
csar_cpi = CSAR_CPI()

class CSAR_EXYZ(Structure):        # 39/NR:220  Explicit QUAD nodes on area
   _fields_ = [
         ('m_id', c_int),          #        identifier = 220
         ('m_id1', c_int),         #        reserved
         ('m_xyz', c_float * 4 * 3)  # [1001] XYZ coordinates
      ]
csar_exyz = CSAR_EXYZ()

class CGAR_EXYZ(Structure):        # 32/NR:220  Explicit QUAD nodes on area
   _fields_ = [
         ('m_id', c_int),          #        identifier = 220
         ('m_id1', c_int),         #        reserved
         ('m_xyz', c_float * 4 * 3)  # [1001] XYZ coordinates
      ]
cgar_exyz = CGAR_EXYZ()

class CSAR_SUPP(Structure):        # 39/NR:221  Support and coupling of structural areas
   _fields_ = [
         ('m_id', c_int),          #        identifier 221
         ('m_ids', c_int),         #        type of reference
         ('m_ref', c_int),         #        reference identifier
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_ibc', c_int),         #        Boundary condition / kinematic constraints
         ('m_i6', c_int),          #        reserved
         ('m_rctl', c_int),        #        properties of area-area reference
         ('m_rptr', c_int),        #        reference point on boundary of referenced area
         ('m_rpt0', c_int),        #        reference point on boundary of given area
         ('m_i10', c_int),         #        reserved
         ('m_d', c_float),         # [1001] distance of interface layer
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float)         # [1096] lateral   bedding
      ]
csar_supp = CSAR_SUPP()

class CGAR_SUPP(Structure):        # 32/NR:221  Support and coupling of structural areas
   _fields_ = [
         ('m_id', c_int),          #        identifier 221
         ('m_ids', c_int),         #        type of reference
         ('m_ref', c_int),         #        reference identifier
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_ibc', c_int),         #        Boundary condition / kinematic constraints
         ('m_i6', c_int),          #        reserved
         ('m_rctl', c_int),        #        properties of area-area reference
         ('m_rptr', c_int),        #        reference point on boundary of referenced area
         ('m_rpt0', c_int),        #        reference point on boundary of given area
         ('m_i10', c_int),         #        reserved
         ('m_d', c_float),         # [1001] distance of interface layer
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float)         # [1096] lateral   bedding
      ]
cgar_supp = CGAR_SUPP()

class CSVO(Structure):             # 39/NR:300  StructuralVolume
   _fields_ = [
         ('m_id', c_int),          #        identification = 300
         ('m_ids', c_int),         #        identifier of structural area (0=auto)
         ('m_ref', c_int),         #        reference to a given GVO (reserved)
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_nor', c_int),         #        number of reinforc.
         ('m_not', c_int),         #        number of elementtype
         ('m_ibc', c_int),         #        Boundary condition
         ('m_id8', c_int),         #        reserved
         ('m_id9', c_int),         #        reserved
         ('m_text',  c_int * 17)   #        Designation of Volume
      ]
csvo = CSVO()

class CSMB_ATTR(Structure):        # 39/NR:997  Attributes of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 997
         ('m_i1', c_int),          #        reserved
         ('m_i2', c_int),          #        reserved
         ('m_grxa', c_int),        #        identifier of 1st grid axis x-x
         ('m_grya', c_int),        #        identifier of 2nd grid axis y-y
         ('m_elvb', c_int),        #        identifier of elevation at bottom
         ('m_elvt', c_int),        #        identifier of elevation at top
         ('m_dpos', c_int),        #        Identifier of design group membership
         ('m_dtxt',  c_int * 17)   #        Designation of design group membership
      ]
csmb_attr = CSMB_ATTR()

class CSPT_ATTR(Structure):        # 30/NR:997  Attributes of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 997
         ('m_i1', c_int),          #        reserved
         ('m_i2', c_int),          #        reserved
         ('m_grxa', c_int),        #        identifier of 1st grid axis x-x
         ('m_grya', c_int),        #        identifier of 2nd grid axis y-y
         ('m_elvb', c_int),        #        identifier of elevation at bottom
         ('m_elvt', c_int),        #        identifier of elevation at top
         ('m_dpos', c_int),        #        Identifier of design group membership
         ('m_dtxt',  c_int * 17)   #        Designation of design group membership
      ]
cspt_attr = CSPT_ATTR()

class CSLN_ATTR(Structure):        # 31/NR:997  Attributes of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 997
         ('m_i1', c_int),          #        reserved
         ('m_i2', c_int),          #        reserved
         ('m_grxa', c_int),        #        identifier of 1st grid axis x-x
         ('m_grya', c_int),        #        identifier of 2nd grid axis y-y
         ('m_elvb', c_int),        #        identifier of elevation at bottom
         ('m_elvt', c_int),        #        identifier of elevation at top
         ('m_dpos', c_int),        #        Identifier of design group membership
         ('m_dtxt',  c_int * 17)   #        Designation of design group membership
      ]
csln_attr = CSLN_ATTR()

class CSAR_ATTR(Structure):        # 32/NR:997  Attributes of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 997
         ('m_i1', c_int),          #        reserved
         ('m_i2', c_int),          #        reserved
         ('m_grxa', c_int),        #        identifier of 1st grid axis x-x
         ('m_grya', c_int),        #        identifier of 2nd grid axis y-y
         ('m_elvb', c_int),        #        identifier of elevation at bottom
         ('m_elvt', c_int),        #        identifier of elevation at top
         ('m_dpos', c_int),        #        Identifier of design group membership
         ('m_dtxt',  c_int * 17)   #        Designation of design group membership
      ]
csar_attr = CSAR_ATTR()

class CSMB_GUID(Structure):        # 39/NR:999  Unique identifier of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 999
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of preceeding element
      ]
csmb_guid = CSMB_GUID()

class CSPT_GUID(Structure):        # 30/NR:999  Unique identifier of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 999
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of preceeding element
      ]
cspt_guid = CSPT_GUID()

class CSLN_GUID(Structure):        # 31/NR:999  Unique identifier of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 999
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of preceeding element
      ]
csln_guid = CSLN_GUID()

class CSAR_GUID(Structure):        # 32/NR:999  Unique identifier of structural member
   _fields_ = [
         ('m_id', c_int),          #        identifier 999
         ('m_idbim', c_int * 36)   #        256 Bit GUId Identifier of preceeding element
      ]
csar_guid = CSAR_GUID()

class CGPT(Structure):             # 30/NR:0  Structural points
   _fields_ = [
         ('m_id', c_int),          #        identifier 0 (always the first record)
         ('m_ibc', c_int),         #        Boundary condition
         ('m_xyz', c_float * 3),   # [1001] Ordinates
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_bx', c_float),        # [1001] Dimension in x
         ('m_by', c_float),        # [1001] Dimension in y
         ('m_thick', c_float),     # [1010] Plate thickness
         ('m_hmesh', c_float),     # [1001] Mesh density at point
         ('m_r17', c_float),       #        reserved
         ('m_text',  c_int * 17)   #        Designation of Point
      ]
cgpt = CGPT()

class CGPT_COH(Structure):         # 30/NR:1  Dimension of column head
   _fields_ = [
         ('m_id', c_int),          #        identifier 1/2/3
         ('m_ns', c_int),          #        Number of a cross section 9/NR for details
         ('m_x', c_float),         # [1001] Width in local x
         ('m_y', c_float),         # [1001] Width in local y
         ('m_a', c_float),         # [1002] Equivalent Area
         ('m_t', c_float)          # [1010] Plate thickness
      ]
cgpt_coh = CGPT_COH()

class CGPT_HAU(Structure):         # 30/NR:2  Dimension of voute
   _fields_ = [
         ('m_id', c_int),          #        identifier 1/2/3
         ('m_ns', c_int),          #        Number of a cross section 9/NR for details
         ('m_x', c_float),         # [1001] Width in local x
         ('m_y', c_float),         # [1001] Width in local y
         ('m_a', c_float),         # [1002] Equivalent Area
         ('m_t', c_float)          # [1010] Plate thickness
      ]
cgpt_hau = CGPT_HAU()

class CGPT_PUN(Structure):         # 30/NR:3  Dimension of punching perimeter
   _fields_ = [
         ('m_id', c_int),          #        identifier 1/2/3
         ('m_ns', c_int),          #        Number of a cross section 9/NR for details
         ('m_x', c_float),         # [1001] Width in local x
         ('m_y', c_float),         # [1001] Width in local y
         ('m_a', c_float),         # [1002] Equivalent Area
         ('m_t', c_float)          # [1010] Plate thickness
      ]
cgpt_pun = CGPT_PUN()

class CGPT_COL(Structure):         # 30/NR:4  Connecting columns
   _fields_ = [
         ('m_id', c_int),          #        identifier 4
         ('m_ns', c_int),          #        Number of a cross section 9/NR for column
         ('m_x', c_float),         # [1001] Width in local x
         ('m_y', c_float),         # [1001] Width in local y
         ('m_a', c_float),         # [1002] Equivalent Area
         ('m_l', c_float),         # [1001] Column length
         ('m_fak', c_float)        #        Rigidity factor
      ]
cgpt_col = CGPT_COL()

class CGPT_FOO(Structure):         # 30/NR:5  Footing instance definition
   _fields_ = [
         ('m_id', c_int),          #        identifier 5
         ('m_pos', c_int),         #        referenced building position
         ('m_type', c_int),        #        Type of foundation
         ('m_igp', c_int),         #        Bitpattern Foundation Properties
         ('m_idr', c_int),         #        Bitpattern Design Results
         ('m_ir1', c_int),         #        reserved
         ('m_mno', c_int),         #        Id of concrete material
         ('m_mrf', c_int),         #        Id of reinforcement material
         ('m_nrsp', c_int),        #        Id of soil profile (002/NR)
         ('m_t', c_float * 3 * 3), #        Orientation of local coordinate system
         ('m_bx', c_float),        # [1001] Width in local x
         ('m_by', c_float),        # [1001] Width in local y
         ('m_hi', c_float),        # [1001] inner Thickness
         ('m_ha', c_float),        # [1001] outer Thickness
         ('m_ex', c_float),        # [1001] Eccentricity of column in local x-direction
         ('m_ey', c_float),        # [1001] Eccentricity of column in local y-direction
         ('m_ez', c_float),        # [1001] Eccentricity of endpoint of column(=structural point) in local 
         ('m_clx', c_float),       # [1011] Assumed dimension of column in local x-direction
         ('m_cly', c_float),       # [1011] Assumed dimension of column in local y-direction
         ('m_sxt', c_float),       # [1024] Boundary distance of x-aligned reinforcement on top face
         ('m_syt', c_float),       # [1024] Boundary distance of y-aligned reinforcement on top face
         ('m_sxb', c_float),       # [1024] Boundary distance of x-aligned reinforcement on bottom face
         ('m_syb', c_float),       # [1024] Boundary distance of y-aligned reinforcement on bottom face
         ('m_covt', c_float),      # [1024] Concrete cover (nominal) on top face
         ('m_covb', c_float),      # [1024] Concrete cover (nominal) on bottom face
         ('m_covl', c_float),      # [1024] Concrete cover (nominal) on lateral faces
         ('m_res1', c_float),      #        Reserved
         ('m_res2', c_float),      #        Reserved
         ('m_res3', c_float),      #        Reserved
         ('m_res4', c_float),      #        Reserved
         ('m_slho', c_float),      # [1001] obsolete
         ('m_slhi', c_float),      # [1001] obsolete
         ('m_slwx', c_float),      # [1001] obsolete
         ('m_slwy', c_float),      # [1001] obsolete
         ('m_slgu', c_float),      # [1001] obsolete
         ('m_slgl', c_float),      # [1001] obsolete
         ('m_data', c_float * 12), #        Reserved
         ('m_titl',  c_int * 17)   #        Designation of Foundation
      ]
cgpt_foo = CGPT_FOO()

class CGPT_FRR(Structure):         # 30/NR:1005  Footing required reinforcement
   _fields_ = [
         ('m_id', c_int),          #        identifier 1005
         ('m_type', c_int),        #        Type of reinforcement
         ('m_n_as', c_int),        #        number of values stored in array AS
         ('m_ir1', c_int),         #        reserved
         ('m_ir2', c_int),         #        reserved
         ('m_xoff', c_float),      # [1001] offset of distribution in x-direction
         ('m_yoff', c_float),      # [1001] offset of distribution in y-direction
         ('m_res1', c_float),      #        reserved
         ('m_res2', c_float),      #        reserved
         ('m_as', c_float * 32)    # [1021] reinforcement values
      ]
cgpt_frr = CGPT_FRR()

class CGPT_SLP(Structure):         # 30/NR:1006  Sleeve foundation properties
   _fields_ = [
         ('m_id', c_int),          #        identifier 1006
         ('m_ir1', c_int),         #        reserved
         ('m_ir2', c_int),         #        reserved
         ('m_ir3', c_int),         #        reserved
         ('m_hswo', c_float),      # [1001] Outer height of sleeve wall (measured from z=0 of local coordin
         ('m_hswi', c_float),      # [1001] Inner height of sleeve wall (measured from upper face of sleeve
         ('m_wxwu', c_float),      # [1001] Upper width of sleeve wall in x-direction
         ('m_wywu', c_float),      # [1001] Upper width of sleeve wall in y-direction
         ('m_wxwl', c_float),      # [1001] Lower width of sleeve wall in x-direction (measured at z=0 of l
         ('m_wywl', c_float),      # [1001] Lower width of sleeve wall in y-direction
         ('m_wxgu', c_float),      # [1001] Upper width of gap between wall and column in x-direction
         ('m_wygu', c_float),      # [1001] Upper width of gap between wall and column in y-direction
         ('m_wxgl', c_float),      # [1001] Lower width of gap between wall and column in x-direction
         ('m_wygl', c_float),      # [1001] Lower width of gap between wall and column in y-direction
         ('m_clx', c_float),       # [1011] Assumed dimension of column in local x-direction (deprecated)
         ('m_cly', c_float)        # [1011] Assumed dimension of column in local y-direction (deprecated)
      ]
cgpt_slp = CGPT_SLP()

class CGPT_HPI(Structure):         # 30/NR:6  Halfspace pile
   _fields_ = [
         ('m_id', c_int),          #        identifier 6
         ('m_nq', c_int),          #        number cross section   =0 if diameter from 030/NR:0
         ('m_l', c_float),         # [1001] pile length in GDIR direction
         ('m_mant', c_float),      #        percentage of skin friction for linear analysis
         ('m_zman', c_float),      #        percentage of inactive skin length
         ('m_pman', c_float),      # [1151] maximum load skin friction (nonlinear analysis)
         ('m_pmaf', c_float)       # [1151] maximum load pile foot
      ]
cgpt_hpi = CGPT_HPI()

class CGPT_CON_M(Structure):       #        connected members
   _fields_ = [
         ('m_nelt', c_int),
         ('m_nrel', c_int),
         ('m_node', c_int),
         ('m_narb', c_int),
         ('m_x', c_float)          # [1001] 
      ]
cgpt_con_m = CGPT_CON_M()

class CGPT_CON(Structure):         # 30/NR:8  Steelconnection reference
   _fields_ = [
         ('m_id', c_int),          #        identifier 8
         ('m_conid', c_int),       #        connection identifier
         ('m_m',  CGPT_CON_M * 15) #        connected members
      ]
cgpt_con = CGPT_CON()

class CGPT_SPR(Structure):         # 30/NR:10  Elastic Spring support
   _fields_ = [
         ('m_id', c_int),          #        identifier 10
         ('m_iri', c_int),         #        direction
         ('m_nr', c_int),          #        element number
         ('m_ng', c_int),          #        group number
         ('m_ipc', c_int),         #        connecting to node
         ('m_nwl', c_int),         #        Reference to work-law / material no
         ('m_t', c_float * 3),     #        explicit direction (dx,dy,dz)
         ('m_aref', c_float),      #        reference / influence area (see also  184 170/0 )
         ('m_cp', c_float),        # [1095] spring stiffness z
         ('m_cq', c_float),        # [1095] transverse stiff.
         ('m_cm', c_float),        # [1098] torsional stiff.
         ('m_pre', c_float),       #        prestress for cp
         ('m_gap', c_float),       #        slip of spring
         ('m_riss', c_float),      #        max tension force
         ('m_flie', c_float),      #        yielding load
         ('m_mue', c_float),       #        friction cross
         ('m_coh', c_float),       #        cohesion cross
         ('m_dil', c_float),       #        dilatancy factor
         ('m_gapq', c_float)       #        transverse slip/gap
      ]
cgpt_spr = CGPT_SPR()

class CGPT_KIN(Structure):         # 30/NR:11  Kinematic Constraint
   _fields_ = [
         ('m_id', c_int),          #        identifier 11
         ('m_ktl', c_int),         #        type +  10000*group-number
         ('m_kr1', c_int),         #        reference GPT 1
         ('m_kr2', c_int),         #        reference GPT 2
         ('m_dx', c_float),        #        direction of coupling X-axis
         ('m_dy', c_float),        #        direction of coupling Y-axis
         ('m_dz', c_float),        #        direction of coupling Z-axis
         ('m_dd', c_float),        #        factor of interpolation
         ('m_ff', c_float)         #        factor of multiplication
      ]
cgpt_kin = CGPT_KIN()

class CGPT_SPC(Structure):         # 30/NR:12  Elastic Spring connection (obsoleted)
   _fields_ = [
         ('m_id', c_int),          #        identifier 12
         ('m_iri', c_int),         #        direction + 100*sign(group number,direction)
         ('m_ipc', c_int),         #        connecting Spoint
         ('m_nwl', c_int),         #        work law number
         ('m_cp', c_float),        # [1095] spring stiffness z
         ('m_cq', c_float),        # [1095] transverse stiff.
         ('m_cm', c_float),        # [1098] torsional stiff.
         ('m_pre', c_float),       #        prestress for cp
         ('m_gap', c_float),       #        slip of spring
         ('m_riss', c_float),      #        max tension force
         ('m_flie', c_float),      #        yielding load
         ('m_mue', c_float),       #        friction cross
         ('m_coh', c_float),       #        cohesion cross
         ('m_dil', c_float)        #        dilatancy factor
      ]
cgpt_spc = CGPT_SPC()

class CGPT_DADS(Structure):        # 30/NR:998  List of origin ids the structural member has been created from
   _fields_ = [
         ('m_id', c_int),          #        ident 998
         ('m_idd', c_int * 63)     #        ids of all anchestors
      ]
cgpt_dads = CGPT_DADS()

class CGLN(Structure):             # 31/NR:0  Structural lines
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_pt', c_int * 2),      #        Number start & end point
         ('m_i3', c_int),          #        reserved
         ('m_ibt', c_int),         #        Bitpattern of element properties acc. 39/NR:100 IBT
         ('m_ibc', c_int),         #        Boundary condition acc. 39/NR:100 IBC
         ('m_i_0', c_float * 10),  #        reserved
         ('m_hmesh', c_float),     # [1001] mesh density along line acc. 39/NR:100 HMESH
         ('m_i_11', c_float * 3),  #        reserved
         ('m_prog', c_float),      #        progression factor (>0 monoton, <0 symmetric)
         ('m_i_15', c_float),
         ('m_text',  c_int * 17)   #        Designation of Line
      ]
cgln = CGLN()

class CGLN_REF(Structure):         # 31/NR:-  Reference to another Geometry
   _fields_ = [
         ('m_igm', c_int),         #        negative value of the master geometry
         ('m_igs', c_int),         #        optional identifier of a secondary axis
         ('m_smin', c_float),      #        min parameter on referenced axis
         ('m_smax', c_float)       #        max parameter on referenced axis
      ]
cgln_ref = CGLN_REF()

class CGLN_GEO(Structure):         # 31/NR:??  Geometric properties
   _fields_ = [
         ('m_iln', c_int),         #        Code of geometry
         ('m_gpg', c_float),       # [1001] geometry parameter 1
         ('m_gpa', c_float),       # [1001] geometry parameter 2
         ('m_dd', c_float),        # [1001] arc length
         ('m_s1', c_float),        #        parameter s on start
         ('m_xyz1', c_float * 3),  # [1001] Ordinate of start
         ('m_dxyz1', c_float * 3), #        Tangent of start
         ('m_rg1', c_float),       # [1009] in-plane curvature
         ('m_ra1', c_float),       # [1009] vertical curvature
         ('m_s2', c_float),        #        parameter s on end
         ('m_xyz2', c_float * 3),  # [1001] Ordinate of endpoint
         ('m_dxyz2', c_float * 3), #        Tangent of endpoint
         ('m_rg2', c_float),       # [1009] in-plane curvature
         ('m_ra2', c_float)        # [1009] vertical curvature
      ]
cgln_geo = CGLN_GEO()

class CGLN_BEAM(Structure):        # 31/NR:100  Properties of beams (obsoleted)
   _fields_ = [
         ('m_id', c_int),          #        ident 100
         ('m_nog', c_int),         #        Element type
         ('m_nq', c_int),          #        number cross section
         ('m_np', c_int),          #        number bedding props
         ('m_ibc', c_int),         #        Hinge code
         ('m_div', c_int),         #        prescribed subdivision no of segments
         ('m_eya', c_float),       # [1001] eccentricity at start
         ('m_eza', c_float),       # [1001] eccentricity at start
         ('m_eye', c_float),       # [1001] eccentricity at end
         ('m_eze', c_float),       # [1001] eccentricity at end
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float),        # [1096] lateral   bedding
         ('m_cm', c_float),        # [1099] torsional bedding
         ('m_cx', c_float),        # [1096] global X  bedding
         ('m_cy', c_float),        # [1096] global Y  bedding
         ('m_cz', c_float),        # [1096] global Z  bedding
         ('m_cxx', c_float),       # [1099] global X  tors.bed.
         ('m_cyy', c_float),       # [1099] global Y  tors.bed.
         ('m_czz', c_float)        # [1099] global Z  tors.bed.
      ]
cgln_beam = CGLN_BEAM()

class CGLN_ELNR(Structure):        # 31/NR:121  Elements generated on lines
   _fields_ = [
         ('m_id', c_int),          #        identifier = 121
         ('m_etyp', c_int),        #        Type of element {100,150,160,...} for {Beam,Truss,Cable,...}
         ('m_ibit', c_int),        #        Bit-code
         ('m_nr', c_int * 253)     #        packed list of element numbers
      ]
cgln_elnr = CGLN_ELNR()

class CGLN_DADS(Structure):        # 31/NR:998  Ids of items being an anchestor
   _fields_ = [
         ('m_id', c_int),          #        ident 998
         ('m_idd', c_int * 63)     #        ids of all anchestors
      ]
cgln_dads = CGLN_DADS()

class CGAR(Structure):             # 32/NR:0  Structural area
   _fields_ = [
         ('m_id', c_int),          #        identification of general data (0)
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_nor', c_int),         #        number of reinforc.
         ('m_itp', c_int),         #        Bitpattern for element generation QUAD
         ('m_ibc', c_int),         #        Boundary condition
         ('m_td', c_float * 5),    # [1010] Constant thickness
         ('m_cb', c_float),        #        bedding factor
         ('m_cq', c_float),        #        tangential bedding factor
         ('m_trot', c_float),      #        Fractional rotation about local z-axisBruchteil der 360-Grad Dr
         ('m_tal', c_float * 3),   #        Vector to be aligned as local axis
         ('m_text',  c_int * 17)   #        Designation of surface
      ]
cgar = CGAR()

class CGAR_REF(Structure):         # 32/NR:-  Reference to another Geometry
   _fields_ = [
         ('m_igm', c_int)          #        negative value of the master geometry
      ]
cgar_ref = CGAR_REF()

class CGAR_BOUN(Structure):        # 32/NR:1  Outer Boundary of Area
   _fields_ = [
         ('m_id', c_int),          #        identification
         ('m_ng', c_int),          #        edgeno     (31/NG)
         ('m_na', c_int),          #        startpoint (30/NA)
         ('m_nb', c_int),          #        endpoint   (30/NB)
         ('m_nm', c_int),          #        midpoint   (30/NM)
         ('m_ifc', c_int),         #        Interface hinge bit pattern
         ('m_t', c_float),         # [1010] Plate thickness of edge
         ('m_dfix', c_float),      # [1001] Distance (offset) of region to edge
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float),        # [1096] lateral   bedding
         ('m_cm', c_float)         # [1099] torsional bedding
      ]
cgar_boun = CGAR_BOUN()

class CGAR_HOLE(Structure):        # 32/NR:2  Inner Boundary of Area
   _fields_ = [
         ('m_id', c_int),          #        identification
         ('m_ng', c_int),          #        edgeno     (31/NG)
         ('m_na', c_int),          #        startpoint (30/NA)
         ('m_nb', c_int),          #        endpoint   (30/NB)
         ('m_nm', c_int),          #        midpoint   (30/NM)
         ('m_ifc', c_int),         #        Interface hinge bit pattern
         ('m_t', c_float),         # [1010] Plate thickness of edge
         ('m_dfix', c_float),      # [1001] Distance (offset) of region to edge
         ('m_ca', c_float),        # [1096] axial     bedding
         ('m_cq', c_float),        # [1096] lateral   bedding
         ('m_cm', c_float)         # [1099] torsional bedding
      ]
cgar_hole = CGAR_HOLE()

class CGAR_CON3(Structure):        # 32/NR:3  Prescribed Edges/Points
   _fields_ = [
         ('m_id', c_int),          #        identification
         ('m_ng', c_int),          #        edgenumber (31/NG)
         ('m_na', c_int),          #        startpoint (30/NA)
         ('m_nb', c_int),          #        endpoint   (30/NB)
         ('m_nm', c_int),          #        midpoint   (30/NM)
         ('m_mat', c_int),         #        Materialnumber of subregion for ID==4
         ('m_t', c_float)          # [1010] Plate thickness at edge or point
      ]
cgar_con3 = CGAR_CON3()

class CGAR_CON4(Structure):        # 32/NR:4  Domain-Subdivision-Edges
   _fields_ = [
         ('m_id', c_int),          #        identification
         ('m_ng', c_int),          #        edgenumber (31/NG)
         ('m_na', c_int),          #        startpoint (30/NA)
         ('m_nb', c_int),          #        endpoint   (30/NB)
         ('m_nm', c_int),          #        midpoint   (30/NM)
         ('m_mat', c_int),         #        Materialnumber of subregion for ID==4
         ('m_t', c_float)          # [1010] Plate thickness at edge or point
      ]
cgar_con4 = CGAR_CON4()

class CGAR_MESH(Structure):        # 32/NR:9  Prescribed Mesh size
   _fields_ = [
         ('m_id', c_int),          #        identification
         ('m_ng', c_int),          #        number of support macro generating mesh
         ('m_na', c_int),          #        startedge  (31/NA)
         ('m_nb', c_int),          #        endedge    (31/NB)
         ('m_i4', c_int),          #        not used
         ('m_i5', c_int),          #        not used
         ('m_hsize', c_float * 3), # [1001] requested mesh size
         ('m_pta', c_float * 3),   # [1001] Coordinates of startpoint
         ('m_pte', c_float * 3),   # [1001] Coordinates of endpoint
         ('m_ptm', c_float * 3)    # [1001] Coordinates of midpoint
      ]
cgar_mesh = CGAR_MESH()

class CGAR_GEO(Structure):         # 32/NR:10  Geometry of surface
   _fields_ = [
         ('m_id', c_int),          #        Identification of surface description 10
         ('m_ng', c_int),          #        Type of surface representation
         ('m_mgri', c_int),        #        number of data/control points in s of mesh
         ('m_ngri', c_int),        #        number of data/control points in t of mesh
         ('m_mspl', c_int),        #        degree of B-spline in s direction
         ('m_nspl', c_int),        #        degree of B-spline in t direction
         ('m_sx', c_float),        #        plane  direction sx
         ('m_sy', c_float),        #        plane  direction sy
         ('m_sz', c_float),        #        plane  direction sz
         ('m_tx', c_float),        #        plane  direction tx
         ('m_ty', c_float),        #        plane  direction ty
         ('m_tz', c_float),        #        plane  direction tz
         ('m_nx', c_float),        #        normal direction nx
         ('m_ny', c_float),        #        normal direction ny
         ('m_nz', c_float),        #        normal direction nz
         ('m_x', c_float),         # [1001] X-ordinate Origin
         ('m_y', c_float),         # [1001] Y-ordinate Origin
         ('m_z', c_float),         # [1001] Z-ordinate Origin
         ('m_par', c_float * 16),  #        additional Parameters
         ('m_box', c_float * 3 * 2), # [1001] boundig box xmin,xmax,ymin,ymax,zmin,zmax
         ('m_xpar', c_float * 9999)  #        extended parameters
      ]
cgar_geo = CGAR_GEO()

class CGAR_SURF(Structure):        # 32/NR:11  UserPointonSurface
   _fields_ = [
         ('m_id', c_int),          #        Identification of user surface description 11
         ('m_it', c_int),          #        Type of point
         ('m_m', c_int),           #        Rasterlocation of mesh 0 < m ( mgri )
         ('m_n', c_int),           #        Rasterlocation of mesh 0 < n ( ngri )
         ('m_n3', c_int),          #        the degree of the Spline becoming effective
         ('m_n4', c_int),          #        the weight of NURBS control point [-]
         ('m_x', c_float),         # [1001] X-ordinate
         ('m_y', c_float),         # [1001] Y-ordinate
         ('m_z', c_float),         # [1001] Z-ordinate
         ('m_t', c_float)          # [1010] Thickness
      ]
cgar_surf = CGAR_SURF()

class CGAR_COON(Structure):        # 32/NR:12  COONsPatchInfo
   _fields_ = [
         ('m_id', c_int),          #        Identification of COONs blending edges 12
         ('m_it', c_int),          #        Type of blending
         ('m_iu0', c_int),         #        No of geometry line for u=umin (left)
         ('m_iu1', c_int),         #        No of geometry line for u=umax (right)
         ('m_iv0', c_int),         #        No of geometry line for v=vmin (lower)
         ('m_iv1', c_int),         #        No of geometry line for v=vmax (upper)
         ('m_sp', c_float * 4 * 3),#        Length parameters for the edges iu0,iu1,iv0,iv1
         ('m_uv', c_float * 2 * 2),#        umin,umax,vmin,vmax of the parameter plane
         ('m_cxyz', c_float * 4 * 3), #        Coordinates of the corner points C1,C2,C3,C4
         ('m_tinc', c_float * 8 * 3), #        inclinations for a bicubic patch as vectors
         ('m_twist', c_float * 4 * 3)  #        Twist of x,y,z-Ordinate at corner C1 (0,0)
      ]
cgar_coon = CGAR_COON()

class CGAR_ELNR(Structure):        # 32/NR:221  Generated elements from area
   _fields_ = [
         ('m_id', c_int),          #        identifier = 221
         ('m_etyp', c_int),        #        Type of element {200,...} for {QUAD,...}
         ('m_id2', c_int),         #        reserved
         ('m_nr', c_int * 253)     #        packed list of element numbers
      ]
cgar_elnr = CGAR_ELNR()

class CGAR_DADS(Structure):        # 32/NR:998  Ids of items being an anchestor
   _fields_ = [
         ('m_id', c_int),          #        ident 998
         ('m_idd', c_int * 63)     #        ids of all anchestors
      ]
cgar_dads = CGAR_DADS()

class CGVO(Structure):             # 33/NR:0  StructuralVolume
   _fields_ = [
         ('m_id', c_int),          #        identification of general data (0)
         ('m_nog', c_int),         #        number of group
         ('m_nom', c_int),         #        number of material
         ('m_nor', c_int),         #        number of reinforc.
         ('m_not', c_int),         #        number of elementtype
         ('m_ibc', c_int),         #        Boundary condition
         ('m_text',  c_int * 17)   #        Designation of Volume
      ]
cgvo = CGVO()

class CGVO_SURF(Structure):        # 33/NR:+  Involved Surfaces
   _fields_ = [
         ('m_itp', c_int),         #        identification of definition
         ('m_ng', c_int),          #        surface    (32/NG)
         ('m_nr', c_int),          #        extrusion or rotation geometry identifier
         ('m_nref', c_int),        #        optional number of a reference point
         ('m_nara', c_int),        #        region identifier for start surface
         ('m_nare', c_int),        #        region identifier for end surface
         ('m_t', c_float),         # [1010] Thickness of interface layer
         ('m_fac', c_float),       #        Scale factor for extrusion
         ('m_fac0', c_float),      #        Scale factor for start segment
         ('m_phi', c_float),       # [   5] end rotation angle for extrusion/rotation
         ('m_phi0', c_float),      # [   5] start rotation angle for rotation
         ('m_dphi', c_float),      # [   5] allowable sector angle for rotation
         ('m_dx', c_float),        # [1001] explicit extrusion / rotational axis
         ('m_dy', c_float),        # [1001] explicit extrusion / rotational axis
         ('m_dz', c_float),        # [1001] explicit extrusion / rotational axis
         ('m_xref', c_float),      # [1001] explicit reference point
         ('m_yref', c_float),      # [1001] explicit reference point
         ('m_zref', c_float),      # [1001] explicit reference point
         ('m_tfac', c_float * 3)   # [1010] Factor for thickness extrusion START/END/REF
      ]
cgvo_surf = CGVO_SURF()

class CSLVL_DEF(Structure):        # 34/NR:0  Structural Storey Level Definition
   _fields_ = [
         ('m_id0', c_int),         #        identification of definition data (0)
         ('m_sptm', c_int),        #        ID of SPT to be generated at center of mass
         ('m_sptr', c_int),        #        ID of SPT to be generated at center of rigidity
         ('m_ibit_stc', c_int),    #        stiffness calculation bit pattern
         ('m_ibit_cpc', c_int),    #        capacity calculation bit pattern
         ('m_ibc', c_int),         #        reserved
         ('m_zlev', c_float),      # [1006] Storey level, upwards positive (reference)
         ('m_dzupw', c_float),     # [1001] Vertical extension upwards (search box) OK
         ('m_dzdwn', c_float),     # [1001] Vertical extension downwards (search box) UK
         ('m_xmin', c_float),      # [1001] Lateral extension (search box)
         ('m_xmax', c_float),      # [1001] Lateral extension (search box)
         ('m_ymin', c_float),      # [1001] Lateral extension (search box)
         ('m_ymax', c_float),      # [1001] Lateral extension (search box)
         ('m_text',  c_int * 17)   #        Designation of level
      ]
cslvl_def = CSLVL_DEF()

class CDSLN_DEF(Structure):        # 35/ID:0  Design Element Definition
   _fields_ = [
         ('m_id0', c_int),         #        identification of definition data (0)
         ('m_dsln', c_int),        #        number of design element
         ('m_fref', c_int),        #        reference of forces
         ('m_ncs', c_int),         #        number of cross section
         ('m_dsel', c_int),        #        type of quad selection
         ('m_nids', c_int),        #        count of geometry identifiers
         ('m_hdiv', c_float)       # [1001] interval of sub-division sections
      ]
cdsln_def = CDSLN_DEF()

class CDGEO_DEF(Structure):        # 35/ID:1  Design Element Geometry
   _fields_ = [
         ('m_id', c_int),          #        identification of data (2)
         ('m_type', c_int),        #        type of geometric definition
         ('m_ids', c_int * 100),   #        ids of structural lines or beams
         ('m_xyza', c_float * 3),  # [1001] geometry of a straight line
         ('m_xyze', c_float * 3),  # [1001] geometry of a straight line
         ('m_dz', c_float * 3)     # [1001] direction z-axis of straight line
      ]
cdgeo_def = CDGEO_DEF()

class CDSLC_DEF(Structure):        # 35/ID:2  Design Sections
   _fields_ = [
         ('m_id', c_int),          #        identification of data (1)
         ('m_type', c_int),        #        type of sectioning
         ('m_ityp', c_int),        #        type of section
         ('m_pos', c_float)        # [1001] position of sections
      ]
cdslc_def = CDSLC_DEF()

class CSGRP(Structure):            # 37/ID:0  Secondary groups
   _fields_ = [
         ('m_id0', c_int),         #        identification of general data (0)
         ('m_typ', c_int),         #        Bit infos of selected element types
         ('m_bit', c_int),         #        Bit infos on selections contained in that group
         ('m_text',  c_int * 17)   #        Designation of sgrp
      ]
csgrp = CSGRP()

class CSGRP_BOX(Structure):        # 37/ID:1  Selective Basic-Volume
   _fields_ = [
         ('m_id', c_int),          #        identification of data (1)
         ('m_typ', c_int),         #        type of property volume
         ('m_bit', c_int),         #        option
         ('m_par', c_float * 7 * 3)  # [1001] PARAMETERS OF BOX par(3,0:6)
      ]
csgrp_box = CSGRP_BOX()

class CSGRP_POL(Structure):        # 37/ID:2  Selective Polyeder-Volume
   _fields_ = [
         ('m_id', c_int),          #        identification of data (2)
         ('m_typ', c_int),         #        number of vertices
         ('m_bit', c_int),         #        option
         ('m_t', c_float * 4 * 3), #        transformation matrix to local coordinates
         ('m_ext', c_float * 3 * 3), # [1001] global extension, local extensions min/max
         ('m_vert', c_float * 63 * 3)  # [1001] vertices in local coordinates r,s,t
      ]
csgrp_pol = CSGRP_POL()

class CSGRP_LIS(Structure):        # 37/ID:0???  Calculated Selective Element List
   _fields_ = [
         ('m_id', c_int),          #        identifier of element to be selected (positive)
         ('m_nr', c_int * 255)     #        element numbers
      ]
csgrp_lis = CSGRP_LIS()

class CSGRP_ADD(Structure):        # 37/ID:1???  Selecting Element List
   _fields_ = [
         ('m_id', c_int),          #        identifier of element to be selected (positive)
         ('m_nr', c_int * 255)     #        element numbers
      ]
csgrp_add = CSGRP_ADD()

class CSGRP_SUB(Structure):        # 37/ID:2???  Excluding Element List
   _fields_ = [
         ('m_id', c_int),          #        identifier of element to be selected (positive)
         ('m_nr', c_int * 255)     #        element numbers
      ]
csgrp_sub = CSGRP_SUB()

class CSGRP_SEL(Structure):        # 37/ID:3???  Property-Values
   _fields_ = [
         ('m_id', c_int),          #        identifier of element to be modified
         ('m_type', c_int),        #        Option to perform
         ('m_bit', c_int),         #        bit pattern of selected data
         ('m_itp', c_int),         #        key value for orientation of coordinate system
         ('m_div', c_int),         #        key value of subdivision or other extended data
         ('m_idq', c_int),         #        key value of cross section or other extended data
         ('m_idh', c_int),         #        key value of hinge conditions or other extended data
         ('m_idx', c_int),         #        key value of other extended data
         ('m_trot', c_float),      #        Fractional rotation about
         ('m_tal', c_float * 3),   #        Vector to be aligned as local axis
         ('m_rdat', c_float * 4),  #        reserved for values not in DATA
         ('m_data', c_int * 64)    #        equivalenced data structure of that
      ]
csgrp_sel = CSGRP_SEL()

class CGLAR_0(Structure):          # 38/NR:0  Load distribution areas Header
   _fields_ = [
         ('m_id', c_int),          #        Identification 0
         ('m_ngar', c_int),        #        number of an 32/NGAR area definition
         ('m_ngrp', c_int * 4),    #        group of area and three active groups
         ('m_mgri', c_int),        #        prescribed grid subdivision (NGAR=0)
         ('m_ngri', c_int),        #        prescribed grid subdivision (NGAR=0)
         ('m_id32', c_int),        #        access ID of 32/0 to check valid data
         ('m_id20', c_int),        #        access ID of 20/0 to check valid data
         ('m_nnod', c_int),        #        number of nodes            38/NR:1
         ('m_nqua', c_int),        #        number of quadrilaterals   38/NR:2
         ('m_nseg', c_int),        #        number of beam sections    38/NR:3
         ('m_dummy', c_int * 2),   #        reserved
         ('m_sgrp', c_int),        #        optional secondary group selector id
         ('m_t', c_float),         # [1010] thickness of load area used to catch beams
         ('m_xyz', c_float * 4 * 3)  # [1001] ! 4 corner points of area (optional)
      ]
cglar_0 = CGLAR_0()

class CGLAR_NOD(Structure):        # 38/NR:1  Node of load distribution area
   _fields_ = [
         ('m_id', c_int),          #        Identification 1 (instead of NR)
         ('m_inr', c_int),         #        nodenumber within the region
         ('m_nfix', c_int),        #        not used
         ('m_ncod', c_int),        #        not used
         ('m_xyz', c_float * 3),   # [1001] coordinates
         ('m_dxyz', c_float * 3)   # [1001] displacements for uniform load -> animator
      ]
cglar_nod = CGLAR_NOD()

class CGLAR_QUA(Structure):        # 38/NR:2  QUAD of load distribution area
   _fields_ = [
         ('m_id', c_int),          #        Identification 2 (instead of NR)
         ('m_node', c_int * 4),    #        nodenumbers of the quad within region
         ('m_mat', c_int),         #        not used
         ('m_mrf', c_int),         #        not used
         ('m_nra', c_int),         #        type of element
         ('m_det', c_float * 3),   #        Parameter of Jacobi Determinant
         ('m_thick', c_float * 5), # [1010] element thickness
         ('m_cb', c_float),        #        not used
         ('m_cq', c_float),        #        not used
         ('m_t', c_float * 3 * 3)  #        transformation matrix
      ]
cglar_qua = CGLAR_QUA()

class CGLAR_SEG(Structure):        # 38/NR:3  BEAM segments within area
   _fields_ = [
         ('m_id', c_int),          #        Identification 3
         ('m_nr', c_int),          #        number of loaded beam element
         ('m_x', c_float),         # [1001] start point
         ('m_l', c_float)          # [1001] length of segment
      ]
cglar_seg = CGLAR_SEG()

class CGLAR_P(Structure):          # 38/NR:1?  Load distribution areas  Pointloads
   _fields_ = [
         ('m_id', c_int),          #        Identification 10:13
         ('m_inr', c_int),         #        nodenumber of 038/NR:1 within region
         ('m_node', c_int),        #        nodenumber of a global node
         ('m_p', c_float * 4)      #        value of load
      ]
cglar_p = CGLAR_P()

class CGLAR_L(Structure):          # 38/NR:10?  Load distribution areas  Beamloads
   _fields_ = [
         ('m_id', c_int),          #        Identification 100:103
         ('m_inr', c_int),         #        nodenumber of 038/NR:1 within region
         ('m_nseg', c_int),        #        number of 038/NR:3 segment
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float),        #        end value of load
         ('m_ma', c_float),        #        start value of torque
         ('m_me', c_float)         #        end value of torque
      ]
cglar_l = CGLAR_L()

class CTENDAXIS(Structure):        # 40/NR:0  Tendon lanes/reference axis data
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_igsys', c_int),       #        prestress for:
         ('m_iginfo', c_int),      #        Systeminfo
         ('m_igref', c_int),       #        reference to geometry
         ('m_icbit', c_int),       #        bit for analysis type
         ('m_ids', c_int),         #        Enum of secondary axis (1='A' to 26 ='Z')
         ('m_text',  c_int * 17)   #        Designation
      ]
ctendaxis = CTENDAXIS()

class CTENDAX_1(Structure):        # 40/NR:1  Tendon lane stations
   _fields_ = [
         ('m_id0', c_int),         #        identifier 1
         ('m_igbit', c_int),       #        station parameter
         ('m_nrstab', c_int),      #        internal beam number
         ('m_id3', c_int),         #        reserved (value = 0)
         ('m_xl', c_float),        #        beam X/L on beam
         ('m_s', c_float),         # [1001] station on reference lane
         ('m_sg', c_float),        # [1001] station of geometry
         ('m_sf', c_float)         #        toppoint station
      ]
ctendax_1 = CTENDAX_1()

class CTENDSPLI(Structure):        # 41/NR:0  Tendon splines
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_nrspur', c_int),      #        corresponding lane
         ('m_nrsv', c_int),        #        prestress system
         ('m_igsys', c_int),       #        prestress for:
         ('m_intyp', c_int),       #        bit for analysis type
         ('m_igref', c_int),       #        reference to      geometry  Rec: 03
         ('m_igrefx', c_int),      #        reference to exc. geometry  Rec: 03
         ('m_id7', c_int),         #        reserved (value = 0)
         ('m_id8', c_int),         #        reserved (value = 0)
         ('m_id9', c_int),         #        reserved (value = 0)
         ('m_stparm', c_float * 12), #        additional data:
         ('m_text',  c_int * 17)   #        Designation
      ]
ctendspli = CTENDSPLI()

class CTENDSP_I(Structure):        # 41/NR:??  Input points
   _fields_ = [
         ('m_id0', c_int),         #        identifier INTYP see 41/0  (1=ZPUV standard geometry)
         ('m_igbit', c_int),       #        station parameter see 40/1
         ('m_id2', c_int),         #        reserved (value = 0)
         ('m_id3', c_int),         #        reserved (value = 0)
         ('m_data', c_float * 20), #        Input point data
         ('m_qsp', c_int),         #        Selection string - reference to cross section point
         ('m_varu', c_int),        #        Selection string - axis variable for offset U
         ('m_varv', c_int),        #        Selection string - axis variable for offset V
         ('m_dat2', c_float * 50)  #        Additional input point
      ]
ctendsp_i = CTENDSP_I()

class CTENDTOPP(Structure):        # 43/NR  Tendon toppoints
   _fields_ = [
         ('m_id0', c_int),         #        identifier:
         ('m_nr', c_int),          #        corresponding lane
         ('m_igref', c_int),       #        reference to      geometry  Rec: 03
         ('m_s', c_float * 124)    # [1001] stations on toppoints (max. 124)
      ]
ctendtopp = CTENDTOPP()

class CTENDON(Structure):          # 44/NR:0  Tendons
   _fields_ = [
         ('m_id0', c_int),         #        identifier 0
         ('m_nrspur', c_int),      #        corresponding lane
         ('m_nrspli', c_int),      #        Spline-No
         ('m_nrstrg', c_int),      #        tendon no.
         ('m_igref', c_int),       #        reference to      geometry  Rec: 03
         ('m_igtyp', c_int),       #        bit for analysis type
         ('m_iz_ref', c_int),      #        IGTYP=1024:  Def-No of geometry
         ('m_niba', c_int * 3),    #        construction stages
         ('m_nrsv', c_int),        #        prestress system
         ('m_nsp', c_int),         #        number of tendons
         ('m_mata', c_int),        #        material concrete
         ('m_nvart', c_int),       #        type of jacking
         ('m_nvartu', c_int),      #        output control
         ('m_nvvor', c_int),       #        prestress input
         ('m_nvbit', c_int * 2),   #        jacking bit
         ('m_lfp', c_int * 2),     #        prestress loadcases
         ('m_igsys', c_int),       #        prestress for:
         ('m_id21', c_int),        #        reserved (value = 0)
         ('m_kapa', c_float),      #        KAPA + 100*KAPL + 1000*action
         ('m_einl', c_float),      #        transition length
         ('m_etyp', c_float),      #        force type to EINL
         ('m_tfak', c_float),      #        factor partial p
         ('m_tlitz', c_float),     #        no. of wires
         ('m_ar', c_float),        #        crack design area
         ('m_dz', c_float),        #        diameter of tendon
         ('m_uz', c_float),        #        perimeter
         ('m_valm', c_float * 4),  #        reserved
         ('m_text',  c_int * 17)   #        Designation
      ]
ctendon = CTENDON()

class CTENDJACK(Structure):        # 44/NR:1  Tendon jacking data
   _fields_ = [
         ('m_id0', c_int),         #        identifier 1
         ('m_id1', c_int),         #        reserved (value = 0)
         ('m_id2', c_int),         #        reserved (value = 0)
         ('m_id3', c_int),         #        reserved (value = 0)
         ('m_zvstrg', c_float * 16), #        geometry data
         ('m_zvfak', c_float * 24),#        stresses and stressing factors
         ('m_zvvor', c_float * 12),#        direct input of prestress
         ('m_zvfree', c_float * 12), #        free prestress
         ('m_zvaend', c_float * 8),#        local geometry position
         ('m_zvreib', c_float * 8),#        additional friction data
         ('m_zvfgrz', c_float * 32), #        limit values of prestress
         ('m_zvweg', c_float * 16),#        stressing deformation
         ('m_text',  c_int * 17)   #        Designation
      ]
ctendjack = CTENDJACK()

class CTENDFACT(Structure):        # 44/NR:2  Tendon jacking factors
   _fields_ = [
         ('m_id0', c_int),         #        identifier 2
         ('m_igbit', c_int),       #        station parameter see 40/1
         ('m_id2', c_int),         #        reserved (value = 0)
         ('m_id3', c_int),         #        reserved (value = 0)
         ('m_s', c_float),         # [1001] station
         ('m_fak', c_float),       #        active stressing factors
         ('m_zwfak', c_float * 12) #        additional factor data
      ]
ctendfact = CTENDFACT()

class CHIST_HED(Structure):        # 80/LC:-10?  TimeHistoryTitle
   _fields_ = [
         ('m_rid', c_float),       #        Identifier of history type
         ('m_title',  c_int * 33)  #        Designation
      ]
chist_hed = CHIST_HED()

class CHIST_PAR(Structure):        # 80/LC:-9??  IterationParameters
   _fields_ = [
         ('m_rid', c_float),       #        identifier
         ('m_val', c_float),       #        current value
         ('m_min', c_float),       #        minimum allowed value
         ('m_max', c_float),       #        maximum allowed value
         ('m_name',  c_int * 17)   #        name of parameter
      ]
chist_par = CHIST_PAR()

class CHIST_ITEM(Structure):       #        History element
   _fields_ = [
         ('m_nr', c_int),
         ('m_typ', c_int)
      ]
chist_item = CHIST_ITEM()

class CHIST(Structure):            # 80/LC:-  Identification of history elements
   _fields_ = [
         ('m_rid', c_float),       #        Identification -100 < RID < 0.
         ('m_item',  CHIST_ITEM * 32)  #        History element
      ]
chist = CHIST()

class CHIST_VAL(Structure):        # 80/LC:+  Transient data
   _fields_ = [
         ('m_tt', c_float),        #        Time/frequency
         ('m_vb', c_float * 32)    #        curve values
      ]
chist_val = CHIST_VAL()

class CSLVL_DAT(Structure):        # 87/0:+  Structural Storey Level Data
   _fields_ = [
         ('m_nr', c_int),          #        Storey Level ID (34/NR)
         ('m_nref', c_int * 2),    #        Node numbers of reference nodes on level
         ('m_nr_cor', c_int),      #        spt number of center of rigidity (COR)
         ('m_nr_com', c_int),      #        spt number of center of mass (COM)
         ('m_creator', c_int),     #        generated by (program) (0=SOFiMSHC, 1=DYNA)
         ('m_zlev', c_float),      # [1006] Storey elevation, upwards positive (reference)
         ('m_h', c_float),         # [1001] Storey height
         ('m_xext', c_float * 2),  # [1001] Storey extensions in global X [XMIN, XMAX]
         ('m_yext', c_float * 2),  # [1001] Storey extensions in global Y [YMIN, YMAX]
         ('m_mass', c_float),      # [1180] Storey mass
         ('m_xyzm', c_float * 3),  # [1001] Coordinates of COM
         ('m_stx', c_float),       # [1095] Storey stiffness in global X
         ('m_sty', c_float),       # [1095] Storey stiffness in global Y
         ('m_xyzr', c_float * 3),  # [1001] Coordinates of COR
         ('m_cpx', c_float),       # [1151] Storey capacity in global X
         ('m_cpy', c_float),       # [1151] Storey capacity in global Y
         ('m_text',  c_int * 17)   #        Designation of level
      ]
cslvl_dat = CSLVL_DAT()

class CSLVL_RES(Structure):        # 87/LC:+  Structural Storey Level Results
   _fields_ = [
         ('m_nr', c_int),          #        Storey Level ID (34/NR)
         ('m_nr_mode', c_int),     #        mode number (=0: resultant values, e.g. from CQC sup.)
         ('m_styp', c_int * 2),    #        superposition type
         ('m_px', c_float),        # [1151] base shear in X
         ('m_py', c_float),        # [1151] base shear in Y
         ('m_pz', c_float),        # [1151] total vertical load at and above the storey
         ('m_mx', c_float),        # [1152] moment about X
         ('m_my', c_float),        # [1152] moment about Y
         ('m_mz', c_float),        # [1152] moment about Z
         ('m_ux', c_float),        # [1003] average storey displacement in X (=translations at COR)
         ('m_uy', c_float),        # [1003] average storey displacement in Y
         ('m_uz', c_float),        # [1003] average storey displacement in Z
         ('m_rz', c_float),        # [1004] average storey rotation in XY-plane
         ('m_dx', c_float),        # [1003] inter-storey drift in X (=difference between top and bottom of 
         ('m_dy', c_float),        # [1003] inter-storey drift in Y
         ('m_drz', c_float),       # [1004] inter-storey rotation in XY-plane
         ('m_lsaf', c_float)       # [  98] modal acceleration (only for NR_MODE>0)
      ]
cslvl_res = CSLVL_RES()

class CBEAM(Structure):            # 100/00:+  Beams
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_node', c_int * 2),    #        node number start/end
         ('m_np', c_int),          #        prop number
         ('m_dl', c_float),        # [1001] beamlength
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_ex', c_float * 2 * 3),# [1001] 
         ('m_nref', c_int),        #        reference axis
         ('m_spar', c_float * 2),  #        distances along a continuous beam or
         ('m_bety', c_float),
         ('m_betz', c_float),
         ('m_ldfy', c_float),
         ('m_ldfz', c_float)       #        deformation length factor for vz
      ]
cbeam = CBEAM()

class CBSLN(Structure):            # 120/00:+  Design elements
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_node', c_int * 2),    #        node number start/end
         ('m_np', c_int),          #        prop number
         ('m_dl', c_float),        # [1001] beamlength
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_ex', c_float * 2 * 3),# [1001] 
         ('m_nref', c_int),        #        reference axis
         ('m_spar', c_float * 2),  #        distances along a continuous beam or
         ('m_bety', c_float),
         ('m_betz', c_float),
         ('m_ldfy', c_float),
         ('m_ldfz', c_float)       #        deformation length factor for vz
      ]
cbsln = CBSLN()

class CBSCT(Structure):            # 140/00:+  External sections
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_node', c_int * 2),    #        node number start/end
         ('m_np', c_int),          #        prop number
         ('m_dl', c_float),        # [1001] beamlength
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_ex', c_float * 2 * 3),# [1001] 
         ('m_nref', c_int),        #        reference axis
         ('m_spar', c_float * 2),  #        distances along a continuous beam or
         ('m_bety', c_float),
         ('m_betz', c_float),
         ('m_ldfy', c_float),
         ('m_ldfz', c_float)       #        deformation length factor for vz
      ]
cbsct = CBSCT()

class CBEAM_SCT(Structure):        # 100/00:0  Beams sections
   _fields_ = [
         ('m_id', c_int),          #        identifier for sections 0
         ('m_nq', c_int),          #        number cross section
         ('m_ityp', c_int),        #        Bitcodes
         ('m_itp2', c_int),        #        Connection / Hinges for x=0,x=dl
         ('m_x', c_float)          # [1001] sectional abscissa
      ]
cbeam_sct = CBEAM_SCT()

class CBSLN_SCT(Structure):        # 120/00:0  Design element sections
   _fields_ = [
         ('m_id', c_int),          #        identifier for sections 0
         ('m_nq', c_int),          #        number cross section
         ('m_ityp', c_int),        #        Bitcode I   (identical to 100/0:0)
         ('m_itp2', c_int),        #        Bitcode II  (identical to 100/0:0)
         ('m_x', c_float),         # [1001] sectional abscissa
         ('m_t', c_float * 4 * 3), #        transformation matrix
         ('m_ymin', c_float),      # [1001] Box of active elements in cut plane
         ('m_zmin', c_float),      # [1001] Box of active elements in cut plane
         ('m_ymax', c_float),      # [1001] Box of active elements in cut plane
         ('m_zmax', c_float),      # [1001] Box of active elements in cut plane
         ('m_xmin', c_float),      # [1001] Box of active elements in cut plane
         ('m_xmax', c_float),      # [1001] Box of active elements in cut plane
         ('m_yminsel', c_float),   # [1001] Max user defined size of Box
         ('m_zminsel', c_float),   # [1001] Max user defined size of Box
         ('m_ymaxsel', c_float),   # [1001] Max user defined size of Box
         ('m_zmaxsel', c_float),   # [1001] Max user defined size of Box
         ('m_ysc', c_float),       # [1001] Coordinate y of shear centre
         ('m_zsc', c_float)        # [1001] Coordinate z of shear centre
      ]
cbsln_sct = CBSLN_SCT()

class CBSCT_SCT(Structure):        # 140/00:0  External sections
   _fields_ = [
         ('m_id', c_int),          #        identifier for sections 0
         ('m_nq', c_int),          #        number cross section
         ('m_ityp', c_int),        #        Bitcode I   (identical to 100/0:0)
         ('m_itp2', c_int),        #        Bitcode II  (identical to 100/0:0)
         ('m_x', c_float),         # [1001] sectional abscissa
         ('m_t', c_float * 4 * 3), #        transformation matrix
         ('m_ymin', c_float),      # [1001] Box of active elements in cut plane
         ('m_zmin', c_float),      # [1001] Box of active elements in cut plane
         ('m_ymax', c_float),      # [1001] Box of active elements in cut plane
         ('m_zmax', c_float),      # [1001] Box of active elements in cut plane
         ('m_xmin', c_float),      # [1001] Box of active elements in cut plane
         ('m_xmax', c_float),      # [1001] Box of active elements in cut plane
         ('m_yminsel', c_float),   # [1001] Max user defined size of Box
         ('m_zminsel', c_float),   # [1001] Max user defined size of Box
         ('m_ymaxsel', c_float),   # [1001] Max user defined size of Box
         ('m_zmaxsel', c_float),   # [1001] Max user defined size of Box
         ('m_ysc', c_float),       # [1001] Coordinate y of shear centre
         ('m_zsc', c_float)        # [1001] Coordinate z of shear centre
      ]
cbsct_sct = CBSCT_SCT()

class CBEAM_TRA(Structure):        # 100/01  transformation matrix
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_dl', c_float),        # [1001] beamlength
         ('m_t', c_float * 3 * 3)  #        transformation matrix
      ]
cbeam_tra = CBEAM_TRA()

class CBEAM_TRS(Structure):        # 100/03  Info about dynamic moving beams (TREX)
   _fields_ = [
         ('m_lf', c_int),          #        Loadcase number containing the train
         ('m_nr', c_int),          #        Number of Beam
         ('m_bpat', c_int),        #        Options for BEAM (see TREX in SOFILOAD)
         ('m_noda', c_int * 4),    #        Node Numbers for Start of beam element
         ('m_node', c_int * 4),    #        Node Numbers for end of beam element
         ('m_xn', c_float * 2)     # [1001] x-values of nodes along load train
      ]
cbeam_trs = CBEAM_TRS()

class CBEAM_TND(Structure):        # 100/05  tendons of beams
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        tendon number
         ('m_mnr', c_int),         #        material number of tendon + 1000 * material number of cross-sec
         ('m_iba1', c_int),        #        construction stage number for placing
         ('m_iba2', c_int),        #        construction stage number for grouting
         ('m_iba3', c_int),        #        construction stage number for removing
         ('m_x', c_float),         # [1011] x-ordinate
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_zz', c_float),        # [1101] tensoning force
         ('m_az', c_float),        # [1020] tendon area
         ('m_d', c_float),         # [1023] diameter
         ('m_uz', c_float),        # [1023] effect. periphery
         ('m_ny', c_float),        #        inclination DY/DX
         ('m_nz', c_float),        #        inclination DZ/DX
         ('m_yhr', c_float),       # [1011] y-ordinate duct
         ('m_zhr', c_float),       # [1011] z-ordinate duct
         ('m_ahr', c_float),       # [1020] area of duct
         ('m_ar', c_float),        # [1012] reference area
         ('m_temp', c_float),      # [1215] Temperature
         ('m_redfak', c_float),    #        Reduction factor within transmission length
         ('m_xsi', c_float)        #        Relative ordinate within total tendon
      ]
cbeam_tnd = CBEAM_TND()

class CBSLN_TND(Structure):        # 120/05  tendons of structural beam lines
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        tendon number
         ('m_mnr', c_int),         #        material number of tendon + 1000 * material number of cross-sec
         ('m_iba1', c_int),        #        construction stage number for placing
         ('m_iba2', c_int),        #        construction stage number for grouting
         ('m_iba3', c_int),        #        construction stage number for removing
         ('m_x', c_float),         # [1011] x-ordinate
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_zz', c_float),        # [1101] tensoning force
         ('m_az', c_float),        # [1020] tendon area
         ('m_d', c_float),         # [1023] diameter
         ('m_uz', c_float),        # [1023] effect. periphery
         ('m_ny', c_float),        #        inclination DY/DX
         ('m_nz', c_float),        #        inclination DZ/DX
         ('m_yhr', c_float),       # [1011] y-ordinate duct
         ('m_zhr', c_float),       # [1011] z-ordinate duct
         ('m_ahr', c_float),       # [1020] area of duct
         ('m_ar', c_float),        # [1012] reference area
         ('m_temp', c_float),      # [1215] Temperature
         ('m_redfak', c_float),    #        Reduction factor within transmission length
         ('m_xsi', c_float)        #        Relative ordinate within total tendon
      ]
cbsln_tnd = CBSLN_TND()

class CBSCT_TND(Structure):        # 140/05  tendons of external sections
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        tendon number
         ('m_mnr', c_int),         #        material number of tendon + 1000 * material number of cross-sec
         ('m_iba1', c_int),        #        construction stage number for placing
         ('m_iba2', c_int),        #        construction stage number for grouting
         ('m_iba3', c_int),        #        construction stage number for removing
         ('m_x', c_float),         # [1011] x-ordinate
         ('m_y', c_float),         # [1011] y-ordinate
         ('m_z', c_float),         # [1011] z-ordinate
         ('m_zz', c_float),        # [1101] tensoning force
         ('m_az', c_float),        # [1020] tendon area
         ('m_d', c_float),         # [1023] diameter
         ('m_uz', c_float),        # [1023] effect. periphery
         ('m_ny', c_float),        #        inclination DY/DX
         ('m_nz', c_float),        #        inclination DZ/DX
         ('m_yhr', c_float),       # [1011] y-ordinate duct
         ('m_zhr', c_float),       # [1011] z-ordinate duct
         ('m_ahr', c_float),       # [1020] area of duct
         ('m_ar', c_float),        # [1012] reference area
         ('m_temp', c_float),      # [1215] Temperature
         ('m_redfak', c_float),    #        Reduction factor within transmission length
         ('m_xsi', c_float)        #        Relative ordinate within total tendon
      ]
cbsct_tnd = CBSCT_TND()

class CBEAM_SL(Structure):         # 101/LC:*  single beam loads
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_x', c_float),         # [1001] load point
         ('m_i_2', c_float),       # [1001] reserved 0.
         ('m_pa', c_float),        #        value of load
         ('m_i_4', c_float),       #        reserved 0.
         ('m_ya', c_float),        # [1001] eccentr. local y
         ('m_za', c_float)         # [1001] eccentr. local z
      ]
cbeam_sl = CBEAM_SL()

class CBEAM_DL(Structure):         # 101/LC:*  distributed beam loading on reference
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_x', c_float),         # [1001] start point
         ('m_l', c_float),         # [1001] length of load
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float),        #        end value of load
         ('m_ya', c_float),        # [1001] eccentr. local y A
         ('m_za', c_float),        # [1001] eccentr. local z A
         ('m_ye', c_float),        # [1001] eccentr. local y E
         ('m_ze', c_float),        # [1001] eccentr. local z E
         ('m_dya', c_float),       #        gradient of eccentricity, local y, start
         ('m_dza', c_float),       #        gradient of eccentricity, local z, start
         ('m_dye', c_float),       #        gradient of eccentricity, local y, end
         ('m_dze', c_float)        #        gradient of eccentricity, local z, end
      ]
cbeam_dl = CBEAM_DL()

class CBEAM_TL(Structure):         # 101/LC:*  distributed beam loading on reference
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_x', c_float),         # [1001] start point
         ('m_l', c_float),         # [1001] length of load
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float),        #        end value of load
         ('m_ya', c_float),        # [1001] eccentr. local y A
         ('m_za', c_float),        # [1001] eccentr. local z A
         ('m_ye', c_float),        # [1001] eccentr. local y E
         ('m_ze', c_float),        # [1001] eccentr. local z E
         ('m_dya', c_float),       #        gradient of eccentricity, local y, start
         ('m_dza', c_float),       #        gradient of eccentricity, local z, start
         ('m_dye', c_float),       #        gradient of eccentricity, local y, end
         ('m_dze', c_float)        #        gradient of eccentricity, local z, end
      ]
cbeam_tl = CBEAM_TL()

class CBEAM_CL(Structure):         # 101/LC:*  cubic beamloads
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_x', c_float),         # [1001] start point
         ('m_l', c_float),         # [1001] length of load
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float),        #        end value of load
         ('m_dpa', c_float),       #        start derivative
         ('m_dpe', c_float)        #        end   derivative
      ]
cbeam_cl = CBEAM_CL()

class CBEAM_WL(Structure):         # 101/LC:*  dynamic wind loads
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_fa', c_float),        #        Factor cross start
         ('m_fe', c_float),        #        Factor cross end
         ('m_ft', c_float),        #        Factor frictional
         ('m_vxa', c_float),       # [1201] wind velocity
         ('m_vya', c_float),       # [1201] wind velocity
         ('m_vza', c_float),       # [1201] wind velocity
         ('m_vxe', c_float),       # [1201] wind velocity
         ('m_vye', c_float),       # [1201] wind velocity
         ('m_vze', c_float),       # [1201] wind velocity
         ('m_vxam', c_float),      # [1201] mean wind velocity
         ('m_vyam', c_float),      # [1201] mean wind velocity
         ('m_vzam', c_float),      # [1201] mean wind velocity
         ('m_vxem', c_float),      # [1201] mean wind velocity
         ('m_vyem', c_float),      # [1201] mean wind velocity
         ('m_vzem', c_float)       # [1201] mean wind velocity
      ]
cbeam_wl = CBEAM_WL()

class CTRUS_WL(Structure):         # 151/LC:*  dynamic wind loads
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_fa', c_float),        #        Factor cross start
         ('m_fe', c_float),        #        Factor cross end
         ('m_ft', c_float),        #        Factor frictional
         ('m_vxa', c_float),       # [1201] wind velocity
         ('m_vya', c_float),       # [1201] wind velocity
         ('m_vza', c_float),       # [1201] wind velocity
         ('m_vxe', c_float),       # [1201] wind velocity
         ('m_vye', c_float),       # [1201] wind velocity
         ('m_vze', c_float),       # [1201] wind velocity
         ('m_vxam', c_float),      # [1201] mean wind velocity
         ('m_vyam', c_float),      # [1201] mean wind velocity
         ('m_vzam', c_float),      # [1201] mean wind velocity
         ('m_vxem', c_float),      # [1201] mean wind velocity
         ('m_vyem', c_float),      # [1201] mean wind velocity
         ('m_vzem', c_float)       # [1201] mean wind velocity
      ]
ctrus_wl = CTRUS_WL()

class CCABL_WL(Structure):         # 161/LC:*  dynamic wind loads
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of load
         ('m_fa', c_float),        #        Factor cross start
         ('m_fe', c_float),        #        Factor cross end
         ('m_ft', c_float),        #        Factor frictional
         ('m_vxa', c_float),       # [1201] wind velocity
         ('m_vya', c_float),       # [1201] wind velocity
         ('m_vza', c_float),       # [1201] wind velocity
         ('m_vxe', c_float),       # [1201] wind velocity
         ('m_vye', c_float),       # [1201] wind velocity
         ('m_vze', c_float),       # [1201] wind velocity
         ('m_vxam', c_float),      # [1201] mean wind velocity
         ('m_vyam', c_float),      # [1201] mean wind velocity
         ('m_vzam', c_float),      # [1201] mean wind velocity
         ('m_vxem', c_float),      # [1201] mean wind velocity
         ('m_vyem', c_float),      # [1201] mean wind velocity
         ('m_vzem', c_float)       # [1201] mean wind velocity
      ]
ccabl_wl = CCABL_WL()

class CBEAM_FOC(Structure):        # 102/LC:0  Maximum of Total Beam forces and deformations
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] max. beam length
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsionalmom.
         ('m_ux', c_float),        # [1003] diplacem. local x
         ('m_uy', c_float),        # [1003] diplacem. local y
         ('m_uz', c_float),        # [1003] diplacem. local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float)        # [1095] local z component of transverse bedding
      ]
cbeam_foc = CBEAM_FOC()

class CBEAM_FTC(Structure):        # 112/LC:0  Maximum of Beam forces without plate components
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] max. beam length
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsionalmom.
         ('m_ux', c_float),        # [1003] diplacem. local x
         ('m_uy', c_float),        # [1003] diplacem. local y
         ('m_uz', c_float),        # [1003] diplacem. local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float)        # [1095] local z component of transverse bedding
      ]
cbeam_ftc = CBEAM_FTC()

class CBSLN_FTC(Structure):        # 122/LC:0  Maximum of Beam forces without plate components
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] max. beam length
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsionalmom.
         ('m_ux', c_float),        # [1003] diplacem. local x
         ('m_uy', c_float),        # [1003] diplacem. local y
         ('m_uz', c_float),        # [1003] diplacem. local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float)        # [1095] local z component of transverse bedding
      ]
cbsln_ftc = CBSLN_FTC()

class CBSCT_FOC(Structure):        # 142/LC:0  Maximum of External sections forces
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] max. beam length
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsionalmom.
         ('m_ux', c_float),        # [1003] diplacem. local x
         ('m_uy', c_float),        # [1003] diplacem. local y
         ('m_uz', c_float),        # [1003] diplacem. local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float)        # [1095] local z component of transverse bedding
      ]
cbsct_foc = CBSCT_FOC()

class CBEAM_FOR(Structure):        # 102/LC:+  Total Beam forces and deformations
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsional moment
         ('m_ux', c_float),        # [1003] diplacement local x
         ('m_uy', c_float),        # [1003] diplacement local y
         ('m_uz', c_float),        # [1003] diplacement local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float),       # [1095] local z component of transverse bedding
         ('m_q1', c_float),        #        quaternion component q1
         ('m_q2', c_float),        #        quaternion component q2
         ('m_q3', c_float),        #        quaternion component q3
         ('m_q0', c_float),        #        quaternion component q0
         ('m_uxx', c_float),       # [1003] translation in global X
         ('m_uyy', c_float),       # [1003] translation in global Y
         ('m_uzz', c_float)        # [1003] translation in global Z
      ]
cbeam_for = CBEAM_FOR()

class CBEAM_FTR(Structure):        # 112/LC:+  Beam forces without plate components
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsional moment
         ('m_ux', c_float),        # [1003] diplacement local x
         ('m_uy', c_float),        # [1003] diplacement local y
         ('m_uz', c_float),        # [1003] diplacement local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float),       # [1095] local z component of transverse bedding
         ('m_q1', c_float),        #        quaternion component q1
         ('m_q2', c_float),        #        quaternion component q2
         ('m_q3', c_float),        #        quaternion component q3
         ('m_q0', c_float),        #        quaternion component q0
         ('m_uxx', c_float),       # [1003] translation in global X
         ('m_uyy', c_float),       # [1003] translation in global Y
         ('m_uzz', c_float)        # [1003] translation in global Z
      ]
cbeam_ftr = CBEAM_FTR()

class CBSLN_FTR(Structure):        # 122/LC:+  Beam forces without plate components
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsional moment
         ('m_ux', c_float),        # [1003] diplacement local x
         ('m_uy', c_float),        # [1003] diplacement local y
         ('m_uz', c_float),        # [1003] diplacement local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float),       # [1095] local z component of transverse bedding
         ('m_q1', c_float),        #        quaternion component q1
         ('m_q2', c_float),        #        quaternion component q2
         ('m_q3', c_float),        #        quaternion component q3
         ('m_q0', c_float),        #        quaternion component q0
         ('m_uxx', c_float),       # [1003] translation in global X
         ('m_uyy', c_float),       # [1003] translation in global Y
         ('m_uzz', c_float)        # [1003] translation in global Z
      ]
cbsln_ftr = CBSLN_FTR()

class CBSCT_FOR(Structure):        # 142/LC:+  External sections forces
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float),       # [1103] 2nd torsional moment
         ('m_ux', c_float),        # [1003] diplacement local x
         ('m_uy', c_float),        # [1003] diplacement local y
         ('m_uz', c_float),        # [1003] diplacement local z
         ('m_phix', c_float),      # [1004] rotation local x
         ('m_phiy', c_float),      # [1004] rotation local y
         ('m_phiz', c_float),      # [1004] rotation local z
         ('m_phiw', c_float),      # [1005] twisting
         ('m_mt3', c_float),       # [1103] 3rd torsionalmom
         ('m_pa', c_float),        # [1095] axial bedding
         ('m_pt', c_float),        # [1095] transverse bedding
         ('m_pty', c_float),       # [1095] local y component of transverse bedding
         ('m_ptz', c_float),       # [1095] local z component of transverse bedding
         ('m_q1', c_float),        #        quaternion component q1
         ('m_q2', c_float),        #        quaternion component q2
         ('m_q3', c_float),        #        quaternion component q3
         ('m_q0', c_float),        #        quaternion component q0
         ('m_uxx', c_float),       # [1003] translation in global X
         ('m_uyy', c_float),       # [1003] translation in global Y
         ('m_uzz', c_float)        # [1003] translation in global Z
      ]
cbsct_for = CBSCT_FOR()

class CBEAM_FOX(Structure):        # 102/0  Total External Beam forces
   _fields_ = [
         ('m_nq', c_int),          #        section number
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] abscissa
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float)        # [1103] 2nd torsion.moment
      ]
cbeam_fox = CBEAM_FOX()

class CBSCT_FOX(Structure):        # 142/0  Total External Forces for external sections
   _fields_ = [
         ('m_nq', c_int),          #        section number
         ('m_nr', c_int),          #        beamnumber
         ('m_x', c_float),         # [1001] abscissa
         ('m_n', c_float),         # [1101] normal force
         ('m_vy', c_float),        # [1102] y-shear force
         ('m_vz', c_float),        # [1102] z-shear force
         ('m_mt', c_float),        # [1103] torsional moment
         ('m_my', c_float),        # [1104] bending moment My
         ('m_mz', c_float),        # [1104] bending moment Mz
         ('m_mb', c_float),        # [1105] warping moment Mb
         ('m_mt2', c_float)        # [1103] 2nd torsion.moment
      ]
cbsct_fox = CBSCT_FOX()

class CBEAM_STI(Structure):        # 103/LC  Stiffness of beams
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_x', c_float),         # [1001] distance from start
         ('m_ea', c_float),        # [  62] normal stiffness
         ('m_gay', c_float),       # [  62] y-shear stiffness
         ('m_gaz', c_float),       # [  62] z-shear stiffness
         ('m_git', c_float),       # [  83] torsional stiffness
         ('m_eiy', c_float),       # [  83] bending stiffness y
         ('m_eiz', c_float),       # [  83] bending stiffness z
         ('m_eiyz', c_float),      # [  83] bending stiffness yz
         ('m_gayz', c_float),      # [  62] yz-shear stiffness
         ('m_kpx', c_float),       # [   8] plastic strain x
         ('m_kpy', c_float),       # [  17] plastic curvature y
         ('m_kpz', c_float),       # [  17] plastic curvature z
         ('m_emin', c_float),      # [1081] minimum strain
         ('m_emax', c_float),      # [1081] maximum strain
         ('m_ge1', c_float),       # [1101] Residual of current step (Crisfield)
         ('m_ge2', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ge3', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ea0', c_float),       # [  83] lin. stiffness EA
         ('m_eiy0', c_float),      # [  83] lin. stiffness EIy
         ('m_eiz0', c_float),      # [  83] lin. stiffness EIz
         ('m_dysm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_dzsm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_pre', c_float),       # [1101] primary axial force
         ('m_ys', c_float),        # [1001] y-eccentricity of centre of gravity
         ('m_zs', c_float),        # [1001] z-eccentricity of centre of gravity
         ('m_ecm', c_float),       #        warping stiffness
         ('m_gcms', c_float),      #        secondary torsion
         ('m_ni', c_float),        # [1101] inner normal force
         ('m_vyi', c_float),       # [1102] inner y-shear force
         ('m_vzi', c_float),       # [1102] inner z-shear force
         ('m_mti', c_float),       # [1103] inner torsional moment
         ('m_myi', c_float),       # [1104] inner bending moment My
         ('m_mzi', c_float),       # [1104] inner bending moment Mz
         ('m_mbi', c_float),       # [1105] inner warping moment Mb
         ('m_e0', c_float),        # [1081] total strain x
         ('m_gkpy', c_float),      # [  17] total curvature y
         ('m_gkpz', c_float),      # [  17] total curvature z
         ('m_kfvy', c_float),      #        plastic factor V-y
         ('m_kfvz', c_float),      #        plastic factor V-z
         ('m_kfmt', c_float),      #        plastic factor M-t
         ('m_de_0', c_float * 7),  #        Crisfield increments of current step di
         ('m_de_1', c_float * 7),  #        Crisfield increments of last step di-1
         ('m_i_54', c_float),      #        unused
         ('m_erf_min', c_float),   # [1081] minimum strain reinf.
         ('m_erf_max', c_float),   # [1081] maximum strain reinf.
         ('m_hc', c_float),        # [   8] relative compressive zone height
         ('m_ccw', c_float),       # [1026] current crack opening
         ('m_i_59', c_float * 11)  #        unused
      ]
cbeam_sti = CBEAM_STI()

class CBSLN_STI(Structure):        # 123/LC  Stiffness of beams
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_x', c_float),         # [1001] distance from start
         ('m_ea', c_float),        # [  62] normal stiffness
         ('m_gay', c_float),       # [  62] y-shear stiffness
         ('m_gaz', c_float),       # [  62] z-shear stiffness
         ('m_git', c_float),       # [  83] torsional stiffness
         ('m_eiy', c_float),       # [  83] bending stiffness y
         ('m_eiz', c_float),       # [  83] bending stiffness z
         ('m_eiyz', c_float),      # [  83] bending stiffness yz
         ('m_gayz', c_float),      # [  62] yz-shear stiffness
         ('m_kpx', c_float),       # [   8] plastic strain x
         ('m_kpy', c_float),       # [  17] plastic curvature y
         ('m_kpz', c_float),       # [  17] plastic curvature z
         ('m_emin', c_float),      # [1081] minimum strain
         ('m_emax', c_float),      # [1081] maximum strain
         ('m_ge1', c_float),       # [1101] Residual of current step (Crisfield)
         ('m_ge2', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ge3', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ea0', c_float),       # [  83] lin. stiffness EA
         ('m_eiy0', c_float),      # [  83] lin. stiffness EIy
         ('m_eiz0', c_float),      # [  83] lin. stiffness EIz
         ('m_dysm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_dzsm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_pre', c_float),       # [1101] primary axial force
         ('m_ys', c_float),        # [1001] y-eccentricity of centre of gravity
         ('m_zs', c_float),        # [1001] z-eccentricity of centre of gravity
         ('m_ecm', c_float),       #        warping stiffness
         ('m_gcms', c_float),      #        secondary torsion
         ('m_ni', c_float),        # [1101] inner normal force
         ('m_vyi', c_float),       # [1102] inner y-shear force
         ('m_vzi', c_float),       # [1102] inner z-shear force
         ('m_mti', c_float),       # [1103] inner torsional moment
         ('m_myi', c_float),       # [1104] inner bending moment My
         ('m_mzi', c_float),       # [1104] inner bending moment Mz
         ('m_mbi', c_float),       # [1105] inner warping moment Mb
         ('m_e0', c_float),        # [1081] total strain x
         ('m_gkpy', c_float),      # [  17] total curvature y
         ('m_gkpz', c_float),      # [  17] total curvature z
         ('m_kfvy', c_float),      #        plastic factor V-y
         ('m_kfvz', c_float),      #        plastic factor V-z
         ('m_kfmt', c_float),      #        plastic factor M-t
         ('m_de_0', c_float * 7),  #        Crisfield increments of current step di
         ('m_de_1', c_float * 7),  #        Crisfield increments of last step di-1
         ('m_i_54', c_float),      #        unused
         ('m_erf_min', c_float),   # [1081] minimum strain reinf.
         ('m_erf_max', c_float),   # [1081] maximum strain reinf.
         ('m_hc', c_float),        # [   8] relative compressive zone height
         ('m_ccw', c_float),       # [1026] current crack opening
         ('m_i_59', c_float * 11)  #        unused
      ]
cbsln_sti = CBSLN_STI()

class CBSCT_STI(Structure):        # 143/LC  Stiffness of beams
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_x', c_float),         # [1001] distance from start
         ('m_ea', c_float),        # [  62] normal stiffness
         ('m_gay', c_float),       # [  62] y-shear stiffness
         ('m_gaz', c_float),       # [  62] z-shear stiffness
         ('m_git', c_float),       # [  83] torsional stiffness
         ('m_eiy', c_float),       # [  83] bending stiffness y
         ('m_eiz', c_float),       # [  83] bending stiffness z
         ('m_eiyz', c_float),      # [  83] bending stiffness yz
         ('m_gayz', c_float),      # [  62] yz-shear stiffness
         ('m_kpx', c_float),       # [   8] plastic strain x
         ('m_kpy', c_float),       # [  17] plastic curvature y
         ('m_kpz', c_float),       # [  17] plastic curvature z
         ('m_emin', c_float),      # [1081] minimum strain
         ('m_emax', c_float),      # [1081] maximum strain
         ('m_ge1', c_float),       # [1101] Residual of current step (Crisfield)
         ('m_ge2', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ge3', c_float),       # [1104] Residual of current step (Crisfield)
         ('m_ea0', c_float),       # [  83] lin. stiffness EA
         ('m_eiy0', c_float),      # [  83] lin. stiffness EIy
         ('m_eiz0', c_float),      # [  83] lin. stiffness EIz
         ('m_dysm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_dzsm', c_float),      # [1011] ordinate shear centre to gravity centre
         ('m_pre', c_float),       # [1101] primary axial force
         ('m_ys', c_float),        # [1001] y-eccentricity of centre of gravity
         ('m_zs', c_float),        # [1001] z-eccentricity of centre of gravity
         ('m_ecm', c_float),       #        warping stiffness
         ('m_gcms', c_float),      #        secondary torsion
         ('m_ni', c_float),        # [1101] inner normal force
         ('m_vyi', c_float),       # [1102] inner y-shear force
         ('m_vzi', c_float),       # [1102] inner z-shear force
         ('m_mti', c_float),       # [1103] inner torsional moment
         ('m_myi', c_float),       # [1104] inner bending moment My
         ('m_mzi', c_float),       # [1104] inner bending moment Mz
         ('m_mbi', c_float),       # [1105] inner warping moment Mb
         ('m_e0', c_float),        # [1081] total strain x
         ('m_gkpy', c_float),      # [  17] total curvature y
         ('m_gkpz', c_float),      # [  17] total curvature z
         ('m_kfvy', c_float),      #        plastic factor V-y
         ('m_kfvz', c_float),      #        plastic factor V-z
         ('m_kfmt', c_float),      #        plastic factor M-t
         ('m_de_0', c_float * 7),  #        Crisfield increments of current step di
         ('m_de_1', c_float * 7),  #        Crisfield increments of last step di-1
         ('m_i_54', c_float),      #        unused
         ('m_erf_min', c_float),   # [1081] minimum strain reinf.
         ('m_erf_max', c_float),   # [1081] maximum strain reinf.
         ('m_hc', c_float),        # [   8] relative compressive zone height
         ('m_ccw', c_float),       # [1026] current crack opening
         ('m_i_59', c_float * 11)  #        unused
      ]
cbsct_sti = CBSCT_STI()

class CBEAM_CRC(Structure):        # 104/LC:0  Parameter of creep interval for each material
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_exp', c_int),         #        exposition class of explicit curve
         ('m_t', c_float),         # [  93] absolute age
         ('m_phi', c_float),       #        creep coefficient
         ('m_eps', c_float),       #        shrinkage
         ('m_rh', c_float),        # [   8] relative moisture
         ('m_temp', c_float),      # [   6] temperature
         ('m_twa', c_float),       # [  93] effective age start
         ('m_twe', c_float),       # [  93] effective age end
         ('m_beth', c_float),      #        creep coefficient beta-h
         ('m_ts', c_float),        # [  93] start date of drying
         ('m_tc', c_float)         # [  93] start date of loading
      ]
cbeam_crc = CBEAM_CRC()

class CBSLN_CRC(Structure):        # 124/LC:0  Parameter of creep interval for each material
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_exp', c_int),         #        exposition class of explicit curve
         ('m_t', c_float),         # [  93] absolute age
         ('m_phi', c_float),       #        creep coefficient
         ('m_eps', c_float),       #        shrinkage
         ('m_rh', c_float),        # [   8] relative moisture
         ('m_temp', c_float),      # [   6] temperature
         ('m_twa', c_float),       # [  93] effective age start
         ('m_twe', c_float),       # [  93] effective age end
         ('m_beth', c_float),      #        creep coefficient beta-h
         ('m_ts', c_float),        # [  93] start date of drying
         ('m_tc', c_float)         # [  93] start date of loading
      ]
cbsln_crc = CBSLN_CRC()

class CBSCT_CRC(Structure):        # 144/LC:0  Parameter of creep interval for each material
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_exp', c_int),         #        exposition class of explicit curve
         ('m_t', c_float),         # [  93] absolute age
         ('m_phi', c_float),       #        creep coefficient
         ('m_eps', c_float),       #        shrinkage
         ('m_rh', c_float),        # [   8] relative moisture
         ('m_temp', c_float),      # [   6] temperature
         ('m_twa', c_float),       # [  93] effective age start
         ('m_twe', c_float),       # [  93] effective age end
         ('m_beth', c_float),      #        creep coefficient beta-h
         ('m_ts', c_float),        # [  93] start date of drying
         ('m_tc', c_float)         # [  93] start date of loading
      ]
cbsct_crc = CBSCT_CRC()

class CBEAM_CRF(Structure):        # 104/LC:+  resulting forces of redistribution
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_sdni', c_float),      # [1101] total normal force
         ('m_sdvy', c_float),      # [1102] total y-shear force
         ('m_sdvz', c_float),      # [1102] total z-shear force
         ('m_sdmt', c_float),      # [1103] total torsion moment
         ('m_sdmy', c_float),      # [1104] total bending moment
         ('m_sdmz', c_float),      # [1104] total bending moment
         ('m_srni', c_float),      # [1101] relat. normal force
         ('m_srvy', c_float),      # [1102] relat. y-shear force
         ('m_srvz', c_float),      # [1102] relat. y-shear force
         ('m_srmt', c_float),      # [1103] relat. torsionmoment
         ('m_srmy', c_float),      # [1104] relat. bendingmoment
         ('m_srmz', c_float)       # [1104] relat. bendingmoment
      ]
cbeam_crf = CBEAM_CRF()

class CBSLN_CRF(Structure):        # 124/LC:+  resulting forces of redistribution
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_sdni', c_float),      # [1101] total normal force
         ('m_sdvy', c_float),      # [1102] total y-shear force
         ('m_sdvz', c_float),      # [1102] total z-shear force
         ('m_sdmt', c_float),      # [1103] total torsion moment
         ('m_sdmy', c_float),      # [1104] total bending moment
         ('m_sdmz', c_float),      # [1104] total bending moment
         ('m_srni', c_float),      # [1101] relat. normal force
         ('m_srvy', c_float),      # [1102] relat. y-shear force
         ('m_srvz', c_float),      # [1102] relat. y-shear force
         ('m_srmt', c_float),      # [1103] relat. torsionmoment
         ('m_srmy', c_float),      # [1104] relat. bendingmoment
         ('m_srmz', c_float)       # [1104] relat. bendingmoment
      ]
cbsln_crf = CBSLN_CRF()

class CBSCT_CRF(Structure):        # 144/LC:+  resulting forces of redistribution
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_id', c_int),          #        identifier 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_sdni', c_float),      # [1101] total normal force
         ('m_sdvy', c_float),      # [1102] total y-shear force
         ('m_sdvz', c_float),      # [1102] total z-shear force
         ('m_sdmt', c_float),      # [1103] total torsion moment
         ('m_sdmy', c_float),      # [1104] total bending moment
         ('m_sdmz', c_float),      # [1104] total bending moment
         ('m_srni', c_float),      # [1101] relat. normal force
         ('m_srvy', c_float),      # [1102] relat. y-shear force
         ('m_srvz', c_float),      # [1102] relat. y-shear force
         ('m_srmt', c_float),      # [1103] relat. torsionmoment
         ('m_srmy', c_float),      # [1104] relat. bendingmoment
         ('m_srmz', c_float)       # [1104] relat. bendingmoment
      ]
cbsct_crf = CBSCT_CRF()

class CBEAM_TSN(Structure):        # 104/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        10000+materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 32 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbeam_tsn = CBEAM_TSN()

class CBSLN_TSN(Structure):        # 124/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        10000+materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 32 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbsln_tsn = CBSLN_TSN()

class CBSCT_TSN(Structure):        # 144/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        10000+materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 32 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbsct_tsn = CBSCT_TSN()

class CBEAM_CRP(Structure):        # 104/LC:+  forces on sectional parts per material
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dni', c_float),       # [1101] impr. normal force
         ('m_dmyi', c_float),      # [1104] impr. bending moment
         ('m_dmzi', c_float),      # [1104] impr. bending moment
         ('m_ni', c_float),        # [1101] total normal force
         ('m_myi', c_float),       # [1104] total bending moment
         ('m_mzi', c_float),       # [1104] total bending moment
         ('m_sdni', c_float),      # [1192] stress plane parameter from (DNI:DMZI)
         ('m_sdmyi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sdmzi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sni', c_float),       # [1192] stress plane parameter from (NI:MZI)
         ('m_smyi', c_float),      # [1193] stress plane parameter from (NI:MZI)
         ('m_smzi', c_float)       # [1193] stress plane parameter from (NI:MZI)
      ]
cbeam_crp = CBEAM_CRP()

class CBSLN_CRP(Structure):        # 124/LC:+  forces on sectional parts per material
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dni', c_float),       # [1101] impr. normal force
         ('m_dmyi', c_float),      # [1104] impr. bending moment
         ('m_dmzi', c_float),      # [1104] impr. bending moment
         ('m_ni', c_float),        # [1101] total normal force
         ('m_myi', c_float),       # [1104] total bending moment
         ('m_mzi', c_float),       # [1104] total bending moment
         ('m_sdni', c_float),      # [1192] stress plane parameter from (DNI:DMZI)
         ('m_sdmyi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sdmzi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sni', c_float),       # [1192] stress plane parameter from (NI:MZI)
         ('m_smyi', c_float),      # [1193] stress plane parameter from (NI:MZI)
         ('m_smzi', c_float)       # [1193] stress plane parameter from (NI:MZI)
      ]
cbsln_crp = CBSLN_CRP()

class CBSCT_CRP(Structure):        # 144/LC:+  forces on sectional parts per material
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dni', c_float),       # [1101] impr. normal force
         ('m_dmyi', c_float),      # [1104] impr. bending moment
         ('m_dmzi', c_float),      # [1104] impr. bending moment
         ('m_ni', c_float),        # [1101] total normal force
         ('m_myi', c_float),       # [1104] total bending moment
         ('m_mzi', c_float),       # [1104] total bending moment
         ('m_sdni', c_float),      # [1192] stress plane parameter from (DNI:DMZI)
         ('m_sdmyi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sdmzi', c_float),     # [1193] stress plane parameter from (DNI:DMZI)
         ('m_sni', c_float),       # [1192] stress plane parameter from (NI:MZI)
         ('m_smyi', c_float),      # [1193] stress plane parameter from (NI:MZI)
         ('m_smzi', c_float)       # [1193] stress plane parameter from (NI:MZI)
      ]
cbsct_crp = CBSCT_CRP()

class CBEAM_CRT(Structure):        # 104/LC:+  changes of tensional force
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        neg. tendonnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dzz', c_float),       # [1092] change of stress to prestress
         ('m_dzr', c_float),       # [1092] rel. change of stress to concrete strain
         ('m_dz', c_float),        # [1101] rel. change of force from mean strain
         ('m_dzfak', c_float * 5)  #        ordinates, inclinations to evaluate forces
      ]
cbeam_crt = CBEAM_CRT()

class CBSLN_CRT(Structure):        # 124/LC:+  changes of tensional force
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        neg. tendonnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dzz', c_float),       # [1092] change of stress to prestress
         ('m_dzr', c_float),       # [1092] rel. change of stress to concrete strain
         ('m_dz', c_float),        # [1101] rel. change of force from mean strain
         ('m_dzfak', c_float * 5)  #        ordinates, inclinations to evaluate forces
      ]
cbsln_crt = CBSLN_CRT()

class CBSCT_CRT(Structure):        # 144/LC:+  changes of tensional force
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nrs', c_int),         #        neg. tendonnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_dzz', c_float),       # [1092] change of stress to prestress
         ('m_dzr', c_float),       # [1092] rel. change of stress to concrete strain
         ('m_dz', c_float),        # [1101] rel. change of force from mean strain
         ('m_dzfak', c_float * 5)  #        ordinates, inclinations to evaluate forces
      ]
cbsct_crt = CBSCT_CRT()

class CBEAM_STC(Structure):        # 105/LC:0  Maximum stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        Ident 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance to start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial comp stress
         ('m_sigu', c_float),      # [1092] uniaxial tens stress
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling intensity
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float)      # [1092] decompression stress
      ]
cbeam_stc = CBEAM_STC()

class CBSLN_STC(Structure):        # 125/LC:0  Maximum stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        Ident 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance to start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial comp stress
         ('m_sigu', c_float),      # [1092] uniaxial tens stress
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling intensity
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float)      # [1092] decompression stress
      ]
cbsln_stc = CBSLN_STC()

class CBSCT_STC(Structure):        # 145/LC:0  Maximum stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        Ident 0
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance to start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial comp stress
         ('m_sigu', c_float),      # [1092] uniaxial tens stress
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling intensity
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float)      # [1092] decompression stress
      ]
cbsct_stc = CBSCT_STC()

class CBEAM_TST(Structure):        # 105/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        100000 + material number as in BSCT_STC
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 128 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbeam_tst = CBEAM_TST()

class CBSLN_TST(Structure):        # 125/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        100000 + material number as in BSCT_STC
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 128 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbsln_tst = CBSLN_TST()

class CBSCT_TST(Structure):        # 145/LC:+  thermal eigen stress per material
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_mnrx', c_int),        #        100000 + material number as in BSCT_STC
         ('m_x', c_float),         # [1001] distance from start
         ('m_ts', c_float * 128 * 2)  # [1092] Eigenstress table (z,sig)
      ]
cbsct_tst = CBSCT_TST()

class CBEAM_STR(Structure):        # 105/LC:+  Stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial stress up
         ('m_sigu', c_float),      # [1092] uniaxial stress down
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling effects
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float),     # [1092] decompression stress
         ('m_rctrl', c_float),     #        control value of stress/strain description
         ('m_es0', c_float),       #        strain in center of total section
         ('m_esy', c_float),       #        strain gradient in y-direction
         ('m_esz', c_float),       #        strain gradient in z-direction
         ('m_yc', c_float),        # [1011] location of center of partial section
         ('m_zc', c_float),        # [1011] location of center of partial section
         ('m_esw', c_float),       #        factor for unit warping
         ('m_vyf', c_float),       # [1102] shear force
         ('m_vzf', c_float),       # [1102] shear force
         ('m_mtf', c_float),       # [1103] primary torsional moment
         ('m_mt2f', c_float)       # [1103] secondary torsional moment
      ]
cbeam_str = CBEAM_STR()

class CBSLN_STR(Structure):        # 125/LC:+  Stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial stress up
         ('m_sigu', c_float),      # [1092] uniaxial stress down
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling effects
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float),     # [1092] decompression stress
         ('m_rctrl', c_float),     #        control value of stress/strain description
         ('m_es0', c_float),       #        strain in center of total section
         ('m_esy', c_float),       #        strain gradient in y-direction
         ('m_esz', c_float),       #        strain gradient in z-direction
         ('m_yc', c_float),        # [1011] location of center of partial section
         ('m_zc', c_float),        # [1011] location of center of partial section
         ('m_esw', c_float),       #        factor for unit warping
         ('m_vyf', c_float),       # [1102] shear force
         ('m_vzf', c_float),       # [1102] shear force
         ('m_mtf', c_float),       # [1103] primary torsional moment
         ('m_mt2f', c_float)       # [1103] secondary torsional moment
      ]
cbsln_str = CBSLN_STR()

class CBSCT_STR(Structure):        # 145/LC:+  Stresses in cross-section of beams
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_mnr', c_int),         #        materialnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_sigc', c_float),      # [1092] compressive stress
         ('m_sigt', c_float),      # [1092] tensile stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigv', c_float),      # [1092] reference stress
         ('m_si', c_float),        # [1092] main tension stress
         ('m_sii', c_float),       # [1092] main compress stress
         ('m_sigo', c_float),      # [1092] uniaxial stress up
         ('m_sigu', c_float),      # [1092] uniaxial stress down
         ('m_dsig', c_float),      # [1092] sway of normal stress
         ('m_dtau', c_float),      # [1092] sway of shear stress
         ('m_sigw', c_float),      # [1092] stress in weldings
         ('m_vb', c_float),        # [1153] Bond force
         ('m_buck', c_float),      #        buckling effects
         ('m_i_14', c_float),      #        reserved
         ('m_sigct', c_float),     # [1092] decompression stress
         ('m_rctrl', c_float),     #        control value of stress/strain description
         ('m_es0', c_float),       #        strain in center of total section
         ('m_esy', c_float),       #        strain gradient in y-direction
         ('m_esz', c_float),       #        strain gradient in z-direction
         ('m_yc', c_float),        # [1011] location of center of partial section
         ('m_zc', c_float),        # [1011] location of center of partial section
         ('m_esw', c_float),       #        factor for unit warping
         ('m_vyf', c_float),       # [1102] shear force
         ('m_vzf', c_float),       # [1102] shear force
         ('m_mtf', c_float),       # [1103] primary torsional moment
         ('m_mt2f', c_float)       # [1103] secondary torsional moment
      ]
cbsct_str = CBSCT_STR()

class CBEAM_RF0(Structure):        # 106/DC:0  max. values of reinforcement
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nvers', c_int),       #        Version number
         ('m_aslmax', c_float),    # [1021] maximum longitudinal reinforcement
         ('m_asbmax', c_float),    # [1021] maximum of shear link reinforcement
         ('m_vmmax', c_float),     # [1001] maximum of shift rule offset
         ('m_reserved', c_float * 12), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
cbeam_rf0 = CBEAM_RF0()

class CBSLN_RF0(Structure):        # 126/DC:0  max. values of reinforcement
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nvers', c_int),       #        Version number
         ('m_aslmax', c_float),    # [1021] maximum longitudinal reinforcement
         ('m_asbmax', c_float),    # [1021] maximum of shear link reinforcement
         ('m_vmmax', c_float),     # [1001] maximum of shift rule offset
         ('m_reserved', c_float * 12), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
cbsln_rf0 = CBSLN_RF0()

class CBSCT_RF0(Structure):        # 146/DC:0  max. values of reinforcement
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nvers', c_int),       #        Version number
         ('m_aslmax', c_float),    # [1021] maximum longitudinal reinforcement
         ('m_asbmax', c_float),    # [1021] maximum of shear link reinforcement
         ('m_vmmax', c_float),     # [1001] maximum of shift rule offset
         ('m_reserved', c_float * 12), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
cbsct_rf0 = CBSCT_RF0()

class CTRUS_RF0(Structure):        # 156/DC:0  max. values of reinforcement
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nvers', c_int),       #        Version number
         ('m_aslmax', c_float),    # [1021] maximum longitudinal reinforcement
         ('m_asbmax', c_float),    # [1021] maximum of shear link reinforcement
         ('m_vmmax', c_float),     # [1001] maximum of shift rule offset
         ('m_reserved', c_float * 12), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
ctrus_rf0 = CTRUS_RF0()

class CCABL_RF0(Structure):        # 166/DC:0  max. values of reinforcement
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nvers', c_int),       #        Version number
         ('m_aslmax', c_float),    # [1021] maximum longitudinal reinforcement
         ('m_asbmax', c_float),    # [1021] maximum of shear link reinforcement
         ('m_vmmax', c_float),     # [1001] maximum of shift rule offset
         ('m_reserved', c_float * 12), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
ccabl_rf0 = CCABL_RF0()

class CBEAM_RFI(Structure):        # 106/DC:+  info of reinforcement of beam
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        info id = 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_asl', c_int * 10 * 2),#        infos for longitudinal layers 0:9
         ('m_asv', c_int * 15 * 2) #        infos for shear link   layers 1:15
      ]
cbeam_rfi = CBEAM_RFI()

class CBSLN_RFI(Structure):        # 126/DC:+  info of reinforcement of design element sect.
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        info id = 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_asl', c_int * 10 * 2),#        infos for longitudinal layers 0:9
         ('m_asv', c_int * 15 * 2) #        infos for shear link   layers 1:15
      ]
cbsln_rfi = CBSLN_RFI()

class CBSCT_RFI(Structure):        # 146/DC:+  info of reinforcement of external section
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        info id = 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_asl', c_int * 10 * 2),#        infos for longitudinal layers 0:9
         ('m_asv', c_int * 15 * 2) #        infos for shear link   layers 1:15
      ]
cbsct_rfi = CBSCT_RFI()

class CTRUS_RFI(Structure):        # 156/DC:+  info of reinforcement of truss
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        info id = 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_asl', c_int * 10 * 2),#        infos for longitudinal layers 0:9
         ('m_asv', c_int * 15 * 2) #        infos for shear link   layers 1:15
      ]
ctrus_rfi = CTRUS_RFI()

class CCABL_RFI(Structure):        # 166/DC:+  info of reinforcement of cables
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        info id = 0
         ('m_x', c_float),         # [1001] distance from start
         ('m_asl', c_int * 10 * 2),#        infos for longitudinal layers 0:9
         ('m_asv', c_int * 15 * 2) #        infos for shear link   layers 1:15
      ]
ccabl_rfi = CCABL_RFI()

class CBEAM_RFC(Structure):        # 106/DC:+  reinforcement of beam
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        section number
         ('m_x', c_float),         # [1001] distance from start
         ('m_asum', c_float),      # [1020] Total longitudinal reinforcement
         ('m_ator', c_float),      # [1021] maximum of torsional reinforcement
         ('m_asl', c_float * 10),  # [1020] Area of layer 0:9
         ('m_vm', c_float),        # [1001] shift rule offset
         ('m_asbmax', c_float),    # [1021] maximum of all shear link areas
         ('m_asb', c_float * 15 * 2)  # [1021] shear links
      ]
cbeam_rfc = CBEAM_RFC()

class CBSLN_RFC(Structure):        # 126/DC:+  reinforcement of design element section
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        section number
         ('m_x', c_float),         # [1001] distance from start
         ('m_asum', c_float),      # [1020] Total longitudinal reinforcement
         ('m_ator', c_float),      # [1021] maximum of torsional reinforcement
         ('m_asl', c_float * 10),  # [1020] Area of layer 0:9
         ('m_vm', c_float),        # [1001] shift rule offset
         ('m_asbmax', c_float),    # [1021] maximum of all shear link areas
         ('m_asb', c_float * 15 * 2)  # [1021] shear links
      ]
cbsln_rfc = CBSLN_RFC()

class CBSCT_RFC(Structure):        # 146/DC:+  reinforcement of external section
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        section number
         ('m_x', c_float),         # [1001] distance from start
         ('m_asum', c_float),      # [1020] Total longitudinal reinforcement
         ('m_ator', c_float),      # [1021] maximum of torsional reinforcement
         ('m_asl', c_float * 10),  # [1020] Area of layer 0:9
         ('m_vm', c_float),        # [1001] shift rule offset
         ('m_asbmax', c_float),    # [1021] maximum of all shear link areas
         ('m_asb', c_float * 15 * 2)  # [1021] shear links
      ]
cbsct_rfc = CBSCT_RFC()

class CTRUS_RFC(Structure):        # 156/DC:+  reinforcement of truss
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        section number
         ('m_x', c_float),         # [1001] distance from start
         ('m_asum', c_float),      # [1020] Total longitudinal reinforcement
         ('m_ator', c_float),      # [1021] maximum of torsional reinforcement
         ('m_asl', c_float * 10),  # [1020] Area of layer 0:9
         ('m_vm', c_float),        # [1001] shift rule offset
         ('m_asbmax', c_float),    # [1021] maximum of all shear link areas
         ('m_asb', c_float * 15 * 2)  # [1021] shear links
      ]
ctrus_rfc = CTRUS_RFC()

class CCABL_RFC(Structure):        # 166/DC:+  reinforcement of cables
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_nq', c_int),          #        section number
         ('m_x', c_float),         # [1001] distance from start
         ('m_asum', c_float),      # [1020] Total longitudinal reinforcement
         ('m_ator', c_float),      # [1021] maximum of torsional reinforcement
         ('m_asl', c_float * 10),  # [1020] Area of layer 0:9
         ('m_vm', c_float),        # [1001] shift rule offset
         ('m_asbmax', c_float),    # [1021] maximum of all shear link areas
         ('m_asb', c_float * 15 * 2)  # [1021] shear links
      ]
ccabl_rfc = CCABL_RFC()

class CBEAM_DES(Structure):        # 107/LC  Ultimate/Plastic Design results
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ni', c_float),        # [1101] Inner normal force
         ('m_myi', c_float),       # [1104] bending moment My
         ('m_mzi', c_float),       # [1104] bending moment My
         ('m_scf', c_float),       #        relative capacity
         ('m_e0', c_float),        # [   9] strain at center
         ('m_ey', c_float),        # [1009] curvature y direct.
         ('m_ez', c_float),        # [1009] curvature z direct.
         ('m_e1', c_float),        # [   9] compressive strain
         ('m_e2', c_float),        # [   9] tensional   strain
         ('m_hl', c_float),        # [1011] lever of forces
         ('m_hvm', c_float),       # [1001] shift rule value
         ('m_hx', c_float),        # [1001] height of compression zone   (NSTR-Analysis)
         ('m_edcmin', c_float),    # [   9] minimum decompression strain (NSTR-Analysis)
         ('m_edcmax', c_float),    # [   9] maximum decompression strain (NSTR-Analysis)
         ('m_fchk', c_float),      # [1092] not used
         ('m_tcf', c_float),       #        total utilisation level (all effects)
         ('m_scn', c_float),       #        utilisation level  (1) N/Npl
         ('m_scvy', c_float),      #        utilisation level  (2) Vy/Vypl
         ('m_scvz', c_float),      #        utilisation level  (3) Vz/Vzpl
         ('m_scmt', c_float),      #        utilisation level  (4) Mt/Mtpl
         ('m_scmy', c_float),      #        utilisation level  (5) My/Mypl
         ('m_scmz', c_float),      #        utilisation level  (6) Mz/Mzpl
         ('m_scmb', c_float),      #        utilisation level  (7) Mb/Mbpl
         ('m_sct2', c_float),      #        utilisation level  (8) Mt2/Mt2pl
         ('m_sccomb', c_float),    #        utilisation level  (9) TOTAL INTERACTION
         ('m_scbn', c_float),      #        utilisation level (10) buckling / torsional buckling
         ('m_csigc', c_float),     #        utilisation level (11) sig-c/fy
         ('m_csigt', c_float),     #        utilisation level (12) sig-t/fy
         ('m_ctau', c_float),      #        utilisation level (13) tau/tauy
         ('m_csgv', c_float),      #        utilisation level (14) sigv/fy (von Mises)
         ('m_csgr', c_float),      #        utilisation level (15) sig-s (tendon/reinforc.stress)
         ('m_cas', c_float),       #        utilisation level (16) As/As-provided (long.Reinforc)
         ('m_casl', c_float),      #        utilisation level (17) Asl/Asl-provided (shear links)
         ('m_ccw', c_float),       #        utilisation level (18) As/As-provided for crack width
         ('m_csgd', c_float),      #        utilisation level (19) sig-d (dynamic stress range)
         ('m_ctau0', c_float),     #        utilisation level (20) tau0  (Nachweisgrenzen)
         ('m_c2t', c_float),       #        utilisation level (21) plate slenderness (c/t)
         ('m_class', c_float)      #        highest criteria for section class
      ]
cbeam_des = CBEAM_DES()

class CBSLN_DES(Structure):        # 127/LC  Ultimate/Plastic Design results
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ni', c_float),        # [1101] Inner normal force
         ('m_myi', c_float),       # [1104] bending moment My
         ('m_mzi', c_float),       # [1104] bending moment My
         ('m_scf', c_float),       #        relative capacity
         ('m_e0', c_float),        # [   9] strain at center
         ('m_ey', c_float),        # [1009] curvature y direct.
         ('m_ez', c_float),        # [1009] curvature z direct.
         ('m_e1', c_float),        # [   9] compressive strain
         ('m_e2', c_float),        # [   9] tensional   strain
         ('m_hl', c_float),        # [1011] lever of forces
         ('m_hvm', c_float),       # [1001] shift rule value
         ('m_hx', c_float),        # [1001] height of compression zone   (NSTR-Analysis)
         ('m_edcmin', c_float),    # [   9] minimum decompression strain (NSTR-Analysis)
         ('m_edcmax', c_float),    # [   9] maximum decompression strain (NSTR-Analysis)
         ('m_fchk', c_float),      # [1092] not used
         ('m_tcf', c_float),       #        total utilisation level (all effects)
         ('m_scn', c_float),       #        utilisation level  (1) N/Npl
         ('m_scvy', c_float),      #        utilisation level  (2) Vy/Vypl
         ('m_scvz', c_float),      #        utilisation level  (3) Vz/Vzpl
         ('m_scmt', c_float),      #        utilisation level  (4) Mt/Mtpl
         ('m_scmy', c_float),      #        utilisation level  (5) My/Mypl
         ('m_scmz', c_float),      #        utilisation level  (6) Mz/Mzpl
         ('m_scmb', c_float),      #        utilisation level  (7) Mb/Mbpl
         ('m_sct2', c_float),      #        utilisation level  (8) Mt2/Mt2pl
         ('m_sccomb', c_float),    #        utilisation level  (9) TOTAL INTERACTION
         ('m_scbn', c_float),      #        utilisation level (10) buckling / torsional buckling
         ('m_csigc', c_float),     #        utilisation level (11) sig-c/fy
         ('m_csigt', c_float),     #        utilisation level (12) sig-t/fy
         ('m_ctau', c_float),      #        utilisation level (13) tau/tauy
         ('m_csgv', c_float),      #        utilisation level (14) sigv/fy (von Mises)
         ('m_csgr', c_float),      #        utilisation level (15) sig-s (tendon/reinforc.stress)
         ('m_cas', c_float),       #        utilisation level (16) As/As-provided (long.Reinforc)
         ('m_casl', c_float),      #        utilisation level (17) Asl/Asl-provided (shear links)
         ('m_ccw', c_float),       #        utilisation level (18) As/As-provided for crack width
         ('m_csgd', c_float),      #        utilisation level (19) sig-d (dynamic stress range)
         ('m_ctau0', c_float),     #        utilisation level (20) tau0  (Nachweisgrenzen)
         ('m_c2t', c_float),       #        utilisation level (21) plate slenderness (c/t)
         ('m_class', c_float)      #        highest criteria for section class
      ]
cbsln_des = CBSLN_DES()

class CBSCT_DES(Structure):        # 147/LC  Ultimate/Plastic Design results
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ni', c_float),        # [1101] Inner normal force
         ('m_myi', c_float),       # [1104] bending moment My
         ('m_mzi', c_float),       # [1104] bending moment My
         ('m_scf', c_float),       #        relative capacity
         ('m_e0', c_float),        # [   9] strain at center
         ('m_ey', c_float),        # [1009] curvature y direct.
         ('m_ez', c_float),        # [1009] curvature z direct.
         ('m_e1', c_float),        # [   9] compressive strain
         ('m_e2', c_float),        # [   9] tensional   strain
         ('m_hl', c_float),        # [1011] lever of forces
         ('m_hvm', c_float),       # [1001] shift rule value
         ('m_hx', c_float),        # [1001] height of compression zone   (NSTR-Analysis)
         ('m_edcmin', c_float),    # [   9] minimum decompression strain (NSTR-Analysis)
         ('m_edcmax', c_float),    # [   9] maximum decompression strain (NSTR-Analysis)
         ('m_fchk', c_float),      # [1092] not used
         ('m_tcf', c_float),       #        total utilisation level (all effects)
         ('m_scn', c_float),       #        utilisation level  (1) N/Npl
         ('m_scvy', c_float),      #        utilisation level  (2) Vy/Vypl
         ('m_scvz', c_float),      #        utilisation level  (3) Vz/Vzpl
         ('m_scmt', c_float),      #        utilisation level  (4) Mt/Mtpl
         ('m_scmy', c_float),      #        utilisation level  (5) My/Mypl
         ('m_scmz', c_float),      #        utilisation level  (6) Mz/Mzpl
         ('m_scmb', c_float),      #        utilisation level  (7) Mb/Mbpl
         ('m_sct2', c_float),      #        utilisation level  (8) Mt2/Mt2pl
         ('m_sccomb', c_float),    #        utilisation level  (9) TOTAL INTERACTION
         ('m_scbn', c_float),      #        utilisation level (10) buckling / torsional buckling
         ('m_csigc', c_float),     #        utilisation level (11) sig-c/fy
         ('m_csigt', c_float),     #        utilisation level (12) sig-t/fy
         ('m_ctau', c_float),      #        utilisation level (13) tau/tauy
         ('m_csgv', c_float),      #        utilisation level (14) sigv/fy (von Mises)
         ('m_csgr', c_float),      #        utilisation level (15) sig-s (tendon/reinforc.stress)
         ('m_cas', c_float),       #        utilisation level (16) As/As-provided (long.Reinforc)
         ('m_casl', c_float),      #        utilisation level (17) Asl/Asl-provided (shear links)
         ('m_ccw', c_float),       #        utilisation level (18) As/As-provided for crack width
         ('m_csgd', c_float),      #        utilisation level (19) sig-d (dynamic stress range)
         ('m_ctau0', c_float),     #        utilisation level (20) tau0  (Nachweisgrenzen)
         ('m_c2t', c_float),       #        utilisation level (21) plate slenderness (c/t)
         ('m_class', c_float)      #        highest criteria for section class
      ]
cbsct_des = CBSCT_DES()

class CTRUS_DES(Structure):        # 157/LC  Ultimate/Plastic Design results
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_x', c_float),         # [1001] distance from start
         ('m_ni', c_float),        # [1101] Inner normal force
         ('m_myi', c_float),       # [1104] bending moment My
         ('m_mzi', c_float),       # [1104] bending moment My
         ('m_scf', c_float),       #        relative capacity
         ('m_e0', c_float),        # [   9] strain at center
         ('m_ey', c_float),        # [1009] curvature y direct.
         ('m_ez', c_float),        # [1009] curvature z direct.
         ('m_e1', c_float),        # [   9] compressive strain
         ('m_e2', c_float),        # [   9] tensional   strain
         ('m_hl', c_float),        # [1011] lever of forces
         ('m_hvm', c_float),       # [1001] shift rule value
         ('m_hx', c_float),        # [1001] height of compression zone   (NSTR-Analysis)
         ('m_edcmin', c_float),    # [   9] minimum decompression strain (NSTR-Analysis)
         ('m_edcmax', c_float),    # [   9] maximum decompression strain (NSTR-Analysis)
         ('m_fchk', c_float),      # [1092] not used
         ('m_tcf', c_float),       #        total utilisation level (all effects)
         ('m_scn', c_float),       #        utilisation level  (1) N/Npl
         ('m_scvy', c_float),      #        utilisation level  (2) Vy/Vypl
         ('m_scvz', c_float),      #        utilisation level  (3) Vz/Vzpl
         ('m_scmt', c_float),      #        utilisation level  (4) Mt/Mtpl
         ('m_scmy', c_float),      #        utilisation level  (5) My/Mypl
         ('m_scmz', c_float),      #        utilisation level  (6) Mz/Mzpl
         ('m_scmb', c_float),      #        utilisation level  (7) Mb/Mbpl
         ('m_sct2', c_float),      #        utilisation level  (8) Mt2/Mt2pl
         ('m_sccomb', c_float),    #        utilisation level  (9) TOTAL INTERACTION
         ('m_scbn', c_float),      #        utilisation level (10) buckling / torsional buckling
         ('m_csigc', c_float),     #        utilisation level (11) sig-c/fy
         ('m_csigt', c_float),     #        utilisation level (12) sig-t/fy
         ('m_ctau', c_float),      #        utilisation level (13) tau/tauy
         ('m_csgv', c_float),      #        utilisation level (14) sigv/fy (von Mises)
         ('m_csgr', c_float),      #        utilisation level (15) sig-s (tendon/reinforc.stress)
         ('m_cas', c_float),       #        utilisation level (16) As/As-provided (long.Reinforc)
         ('m_casl', c_float),      #        utilisation level (17) Asl/Asl-provided (shear links)
         ('m_ccw', c_float),       #        utilisation level (18) As/As-provided for crack width
         ('m_csgd', c_float),      #        utilisation level (19) sig-d (dynamic stress range)
         ('m_ctau0', c_float),     #        utilisation level (20) tau0  (Nachweisgrenzen)
         ('m_c2t', c_float),       #        utilisation level (21) plate slenderness (c/t)
         ('m_class', c_float)      #        highest criteria for section class
      ]
ctrus_des = CTRUS_DES()

class CBEAM_PIF(Structure):        # 108/LC  reducing factors of stiffness
   _fields_ = [
         ('m_nr', c_int),          #        pilenumber
         ('m_redp', c_float),      #        reducing factor of stiffness
         ('m_reda', c_float),      #        reducing factor of axial bedding
         ('m_redq', c_float)       #        reducing factor of cross bedding
      ]
cbeam_pif = CBEAM_PIF()

class CBEAM_HR0(Structure):        # 111/LC:0  Maximum of Implicit Hinge Reactions
   _fields_ = [
         ('m_id', c_int),          #        identifier 0
         ('m_typ', c_int),         #        type of hinge
         ('m_ibit', c_int * 2),    #        reserved
         ('m_x', c_float),         # [1001] max. beam length
         ('m_reac', c_float),      #        extremal reaction force/ moment
         ('m_stv', c_float * 4)    #        extremal values of statevar's
      ]
cbeam_hr0 = CBEAM_HR0()

class CBEAM_HRC(Structure):        # 111/LC:+  Implicit Hinge Reactions
   _fields_ = [
         ('m_nr', c_int),          #        beamnumber
         ('m_typ', c_int),         #        type of hinge
         ('m_ibit', c_int * 2),    #        reserved
         ('m_x', c_float),         # [1001] hinge location, beam abscissa value
         ('m_reac', c_float),      #        reaction force/ moment
         ('m_stv', c_float * 4)    #        statevar's
      ]
cbeam_hrc = CBEAM_HRC()

class CBEAM_MP0(Structure):        # 115/LC:0  Extremal values of cross-sectional material point reactions
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_type', c_int),        #        type: reinforcement=1, base material point=0
         ('m_mno', c_int),         #        material number
         ('m_mrf', c_int),         #        material number reinforcement
         ('m_npts', c_int),        #        number of base material points
         ('m_nrf', c_int),         #        Anzahl Materialpunkte Bewehrung
         ('m_x', c_float),         # [1001] max. beam length
         ('m_y', c_float),         # [1011] max. y-ccordinate
         ('m_z', c_float),         # [1011] max. z-ccordinate
         ('m_sigx', c_float),      # [1092] axial normal stress
         ('m_tauxy', c_float),     # [1092] shear stress xy
         ('m_tauxz', c_float),     # [1092] shear stress xz
         ('m_f0', c_float),        #        utilization level
         ('m_kapap', c_float),     # [   9] equiv. plastic strain
         ('m_kapad', c_float),     # [   9] fracturing strain
         ('m_ccw', c_float),       # [1026] current crack opening
         ('m_temp', c_float),      # [   6] current temperature
         ('m_tempmax', c_float),   # [   6] maximum temperature in loading history
         ('m_eps_s', c_float),     # [   9] pure reinforcement strain (without TS strain correction)
         ('m_eps_ts', c_float),    # [   9] tension stiffening strain correction (accumulated)
         ('m_dummy', c_float),     #        unused
         ('m_izone', c_float),     #        performance interval
         ('m_epst', c_float),      # [   9] axial temperature strain
         ('m_epsx', c_float),      # [   9] axial total strain (without temperature strain)
         ('m_a_mpt', c_float),     # [1012] associated material point area
         ('m_fc_temp', c_float),   # [1092] current compressive strength (temperature dependent)
         ('m_ft_temp', c_float)    # [1092] current tensile strength (temperature dependent)
      ]
cbeam_mp0 = CBEAM_MP0()

class CBEAM_MPT(Structure):        # 115/LC:+  Cross-sectional material point reactions
   _fields_ = [
         ('m_nr', c_int),          #        beam number
         ('m_type', c_int),        #        type: reinforcement=1, base material point=0
         ('m_mno', c_int),         #        material number
         ('m_mrf', c_int),         #        material number reinforcement
         ('m_npts', c_int),        #        number of base material points
         ('m_nrf', c_int),         #        Anzahl Materialpunkte Bewehrung
         ('m_x', c_float),         # [1001] beam abscissa value
         ('m_y', c_float),         # [1011] cross-sectional y-position
         ('m_z', c_float),         # [1011] cross-sectional z-position
         ('m_sigx', c_float),      # [1092] axial normal stress
         ('m_tauxy', c_float),     # [1092] shear stress xy
         ('m_tauxz', c_float),     # [1092] shear stress xz
         ('m_f0', c_float),        #        utilization level
         ('m_kapap', c_float),     # [   9] equiv. plastic strain
         ('m_kapad', c_float),     # [   9] fracturing strain
         ('m_ccw', c_float),       # [1026] current crack opening
         ('m_temp', c_float),      # [   6] current temperature
         ('m_tempmax', c_float),   # [   6] maximum temperature in loading history
         ('m_eps_s', c_float),     # [   9] pure reinforcement strain (without TS strain correction)
         ('m_eps_ts', c_float),    # [   9] tension stiffening strain correction (accumulated)
         ('m_dummy', c_float),     #        unused
         ('m_izone', c_float),     #        performance interval
         ('m_epst', c_float),      # [   9] axial temperature strain
         ('m_epsx', c_float),      # [   9] axial total strain (without temperature strain)
         ('m_a_mpt', c_float),     # [1012] associated material point area
         ('m_fc_temp', c_float),   # [1092] current compressive strength (temperature dependent)
         ('m_ft_temp', c_float)    # [1092] current tensile strength (temperature dependent)
      ]
cbeam_mpt = CBEAM_MPT()

class CTRUS(Structure):            # 150/00  trusselements
   _fields_ = [
         ('m_nr', c_int),          #        truss number
         ('m_node', c_int * 2),    #        nodenumbers
         ('m_nrq', c_int),         #        cross-section number
         ('m_t', c_float * 3),     #        normal direction
         ('m_dl', c_float),        # [1001] length of truss
         ('m_pre', c_float),       # [1101] prestress
         ('m_gap', c_float),       # [1003] slip of element
         ('m_riss', c_float),      # [1101] max tension force
         ('m_flie', c_float),      # [1101] yielding load
         ('m_nref', c_int)         #        reference axis
      ]
ctrus = CTRUS()

class CTRUS_LOA(Structure):        # 151/LC  Loads on truss elements
   _fields_ = [
         ('m_nr', c_int),          #        truss number
         ('m_typ', c_int),         #        type of load
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float)         #        end value of load
      ]
ctrus_loa = CTRUS_LOA()

class CTRUS_RE0(Structure):        # 152/LC:0  maximum of results of truss elements
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_n', c_float),         # [1101] normal force
         ('m_v', c_float)          # [1003] axial displacement
      ]
ctrus_re0 = CTRUS_RE0()

class CTRUS_RES(Structure):        # 152/LC:+  results of truss elements
   _fields_ = [
         ('m_nr', c_int),          #        truss number
         ('m_n', c_float),         # [1101] normal force
         ('m_v', c_float),         # [1003] axial displacement
         ('m_lex', c_float),       #        nonlinear effect
         ('m_damm', c_float * 6)   #        Damage Parameter
      ]
ctrus_res = CTRUS_RES()

class CTRUS_ST0(Structure):        # 155/LC:0  checked truss stresses
   _fields_ = [
         ('m_nr', c_int),          #        ident 0
         ('m_mat', c_int),         #        Materialnumber
         ('m_sig', c_float),       # [1092] normal stress
         ('m_buck', c_float)       #        buckling intensity
      ]
ctrus_st0 = CTRUS_ST0()

class CTRUS_STR(Structure):        # 155/LC:+  truss stress (AQB)
   _fields_ = [
         ('m_nr', c_int),          #        trussingnumber
         ('m_mat', c_int),         #        Materialnumber
         ('m_sig', c_float),       # [1092] normal stress
         ('m_buck', c_float)       #        buckling intensity
      ]
ctrus_str = CTRUS_STR()

class CCABL(Structure):            # 160/00  cable elements
   _fields_ = [
         ('m_nr', c_int),          #        cable number
         ('m_node', c_int * 2),    #        nodenumbers
         ('m_nrq', c_int),         #        cross-section number
         ('m_t', c_float * 3),     #        normal direction
         ('m_dl', c_float),        # [1001] length of cable
         ('m_pre', c_float),       # [1101] prestress
         ('m_gap', c_float),       # [1003] slip of element
         ('m_riss', c_float),      # [1101] max tension force
         ('m_flie', c_float),      # [1101] yielding load
         ('m_nref', c_int)         #        reference axis
      ]
ccabl = CCABL()

class CCABL_LOA(Structure):        # 161/LC  loads on cables
   _fields_ = [
         ('m_nr', c_int),          #        cable number
         ('m_typ', c_int),         #        type of load
         ('m_pa', c_float),        #        start value of load
         ('m_pe', c_float)         #        end value of load
      ]
ccabl_loa = CCABL_LOA()

class CCABL_RE0(Structure):        # 162/LC:0  maximum results of cables
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_n', c_float),         # [1101] normal force
         ('m_v', c_float),         # [1003] axial displacement
         ('m_vt', c_float),        # [1003] maximum suspension of cable across axis
         ('m_vtx', c_float),       # [1003] suspension of cable, global X-component
         ('m_vty', c_float),       # [1003] suspension of cable, global Y-component
         ('m_vtz', c_float),       # [1003] suspension of cable, global Z-component
         ('m_eps0', c_float)       #        maximum induced strain
      ]
ccabl_re0 = CCABL_RE0()

class CCABL_RES(Structure):        # 162/LC:+  results of cables
   _fields_ = [
         ('m_nr', c_int),          #        cablenumber
         ('m_n', c_float),         # [1101] normal force
         ('m_v', c_float),         # [1003] axial displacement
         ('m_vq', c_float),        # [1003] maximum suspension of cable across axis
         ('m_vtx', c_float),       # [1003] suspension of cable, global X-component
         ('m_vty', c_float),       # [1003] suspension of cable, global Y-component
         ('m_vtz', c_float),       # [1003] suspension of cable, global Z-component
         ('m_eps0', c_float),      #        Total induced strain
         ('m_n_m', c_float),       # [1101] average normal force
         ('m_f0', c_float),        # [1003] vertical suspension of cable in load direction
         ('m_l0', c_float),        # [1001] relaxed cable length incl. temp. and prestrain effects
         ('m_lex', c_float),       #        nonlinear effect
         ('m_effs', c_float),      #        effective stiffness factor due to cable sagging
         ('m_damm', c_float * 6)   #        Damage Parameter
      ]
ccabl_res = CCABL_RES()

class CCABL_SLP(Structure):        # 163/00  slip cables
   _fields_ = [
         ('m_nrsl', c_int),        #        slip cable number
         ('m_nrg', c_int),         #        group number
         ('m_nrel', c_int),        #        element number
         ('m_free', c_int),        #        free
         ('m_mue', c_float)        #        friction value
      ]
ccabl_slp = CCABL_SLP()

class CCABL_ST0(Structure):        # 165/LC:0  checked cable stresses
   _fields_ = [
         ('m_nr', c_int),          #        ident 0
         ('m_mat', c_int),         #        Materialnumber
         ('m_sig', c_float)        # [1092] normal stress
      ]
ccabl_st0 = CCABL_ST0()

class CCABL_STR(Structure):        # 165/LC:+  cable stresses (AQB)
   _fields_ = [
         ('m_nr', c_int),          #        trussingnumber
         ('m_mat', c_int),         #        Materialnumber
         ('m_sig', c_float)        # [1092] normal stress
      ]
ccabl_str = CCABL_STR()

class CSPRI(Structure):            # 170/00  Spring-elements
   _fields_ = [
         ('m_nr', c_int),          #        springnumber
         ('m_node', c_int * 2),    #        start nodenumber
         ('m_nrq', c_int),         #        Material/section no
         ('m_t', c_float * 3),     #        normal direction
         ('m_aref', c_float),      #        reference area
         ('m_cp', c_float),        # [1095] spring stiffness
         ('m_cq', c_float),        # [1095] transverse stiff.
         ('m_cm', c_float),        # [1098] torsional stiff.
         ('m_pre', c_float),       #        prestress
         ('m_gap', c_float),       #        slip/gap of spring
         ('m_riss', c_float),      #        max tension force
         ('m_flie', c_float),      #        yielding load
         ('m_mue', c_float),       #        friction cross
         ('m_coh', c_float),       #        cohesion cross
         ('m_dil', c_float),       #        dilatancy factor
         ('m_gapq', c_float),      #        transverse slip/gap
         ('m_dp', c_float),        #        damping constant
         ('m_dq', c_float),        #        damping shear
         ('m_dm', c_float),        #        damping moment
         ('m_expp', c_float),      #        exponent for nonlinear damping dp**expp
         ('m_expq', c_float),      #        exponent for nonlinear damping dq**expq
         ('m_expm', c_float),      #        exponent for nonlinear damping dm**expm
         ('m_tb', c_float * 3),    #        rotational direction
         ('m_nref', c_int)         #        additional bit code
      ]
cspri = CSPRI()

class CSPRI_RE0(Structure):        # 170/LC:0  maximum of results of spring-elements
   _fields_ = [
         ('m_id', c_int),          #        identifier
         ('m_p', c_float),         # [1151] maximum spring force
         ('m_pt', c_float),        # [1151] maximum spring transverse force
         ('m_ptx', c_float),       # [1151] maximum global X-shear component
         ('m_pty', c_float),       # [1151] maximum global Y-shear component
         ('m_ptz', c_float),       # [1151] maximum global Z-shear component
         ('m_m', c_float),         # [1152] maximum spring moment
         ('m_v', c_float),         # [1003] maximum axial displacement
         ('m_vt', c_float),        # [1003] maximum transverse displacement
         ('m_vtx', c_float),       # [1003] maximum trans displ., global X-component
         ('m_vty', c_float),       # [1003] maximum trans displ., global Y-component
         ('m_vtz', c_float),       # [1003] maximum trans displ., global Z-component
         ('m_phi', c_float)        # [1004] rotation
      ]
cspri_re0 = CSPRI_RE0()

class CSPRI_RES(Structure):        # 170/LC:+  results of spring-elements
   _fields_ = [
         ('m_nr', c_int),          #        springnumber
         ('m_p', c_float),         # [1151] spring force
         ('m_pt', c_float),        # [1151] spring transforce
         ('m_ptx', c_float),       # [1151] global X-shear component
         ('m_pty', c_float),       # [1151] global Y-shear component
         ('m_ptz', c_float),       # [1151] global Z-shear component
         ('m_m', c_float),         # [1152] spring moment
         ('m_v', c_float),         # [1003] axial displacement
         ('m_vt', c_float),        # [1003] trans. displacement
         ('m_vtx', c_float),       # [1003] trans. displacement, global X-component
         ('m_vty', c_float),       # [1003] trans. displacement, global Y-component
         ('m_vtz', c_float),       # [1003] trans. displacement, global Z-component
         ('m_phi', c_float),       # [1004] rotation
         ('m_lex', c_float),       #        nonlinear effect
         ('m_stvp', c_float * 10), #        State variable / Damage Parameter for CP
         ('m_stvm', c_float * 10), #        State variable / Damage Parameter for CM
         ('m_stvt', c_float * 10)  #        State variable / Damage Parameter for CT
      ]
cspri_res = CSPRI_RES()

class CDAMP(Structure):            # 171/00  Damping elements (DYNA)
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_node', c_int * 2),    #        nodenumbers
         ('m_i_3', c_int),
         ('m_t', c_float * 3),     #        normal direction
         ('m_aref', c_float),      #        reference area
         ('m_dp', c_float),        #        damping constant
         ('m_dq', c_float),        #        damping shear
         ('m_dm', c_float),        #        damping moment
         ('m_expp', c_float),      #        exponent for nonlinear damping dp**expp
         ('m_expq', c_float),      #        exponent for nonlinear damping dq**expq
         ('m_expm', c_float)       #        exponent for nonlinear damping dm**expm
      ]
cdamp = CDAMP()

class CMASS(Structure):            # 172/00  Persistent Nodal masses
   _fields_ = [
         ('m_nr', c_int),          #        nodenumber
         ('m_nrg', c_int),         #        pseudoelementnumber IGDIV*Groupnr+IREF
         ('m_mt', c_float * 3),    # [  52] transversal mass mt-x,mt-y,mt-z
         ('m_mr', c_float * 6),    # [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
         ('m_mb', c_float * 7)     #        warping  mass and higher coefficients
      ]
cmass = CMASS()

class CMASS_ADD(Structure):        # 172/01  non persistent additional nodal masses
   _fields_ = [
         ('m_nr', c_int),          #        nodenumber
         ('m_nrg', c_int),         #        pseudoelementnumber IGDIV*Groupnr+IREF
         ('m_mt', c_float * 3),    # [  52] transversal mass mt-x,mt-y,mt-z
         ('m_mr', c_float * 6),    # [  55] rotatory mass    mr-xx,mr-yy,mr-zz,mr-xy,mr-xz,mr-yz
         ('m_mb', c_float * 7)     #        warping  mass and higher coefficients
      ]
cmass_add = CMASS_ADD()

class CMASS_EFF(Structure):        # 172/LD:Z+  Effective nodal masses
   _fields_ = [
         ('m_nr', c_int),          #        identifier
         ('m_mt', c_float * 3),    # [  52] transversal mass mt-x,mt-y,mt-z
         ('m_mr', c_float * 3)     # [  55] rotatory mass    mr-xx,mr-yy,mr-zz
      ]
cmass_eff = CMASS_EFF()

class CMASS_EFC(Structure):        # 172/LD:-  Effective consistent masses
   _fields_ = [
         ('m_nr', c_int),          #        identifier = negative number of nodes
         ('m_node', c_int * 8),    #        node numbers
         ('m_m', c_float * 1176)   #        mass matrix in triangular format
      ]
cmass_efc = CMASS_EFC()

class CSPRI_WL0(Structure):        # 173/NR:0  (nonlinear) Spring material
   _fields_ = [
         ('m_id', c_int),          #        Identification = 0
         ('m_ltyp', c_int),        #        Type of link
         ('m_mtyp', c_int),        #        Type of law
         ('m_icap', c_int),        #        capacities from reference-section SNO
         ('m_ibit2', c_int),       #        reserved
         ('m_ihbit', c_int),       #        Bitpattern of defined degrees of freedom for implicit hinges
         ('m_rlim', c_float * 2 * 7), # [1105] 
         ('m_alph', c_float),      #        Interpolation exponent My-Mz (PMM, only)
         ('m_par', c_float * 16),  #        further reserved material parameters
         ('m_title',  c_int * 17)  #        Designation
      ]
cspri_wl0 = CSPRI_WL0()

class CSPRI_WL(Structure):         # 173/NR:+  Worklaw for nonlinear Springs
   _fields_ = [
         ('m_id', c_int),          #        Identification
         ('m_ntyp', c_int),        #        Type of law
         ('m_plvl', c_float),      # [1101] Normal force reference level
         ('m_eur', c_float),       #        Elastic unloading/reloading stiffness [kN/m],[kNm/rad]
         ('m_par', c_float * 8),   #        further reserved material parameters
         ('m_arb', c_float * 20 * 5)  #        Function values
      ]
cspri_wl = CSPRI_WL()

class CSPRI_MOV(Structure):        # 174/00  Moving Springs
   _fields_ = [
         ('m_nr', c_int),          #        spring element number
         ('m_typ', c_int),         #        searching criteria
         ('m_from', c_int),        #        selection for TYP
         ('m_to', c_int),          #        selection for TYP
         ('m_inc', c_int)          #        selection for TYP
      ]
cspri_mov = CSPRI_MOV()

class CS_MATRIX(Structure):        # 175/00  General systemmatrices
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_typ', c_int),         #        element type
         ('m_ndn', c_int),         #        number of degrees of freedom per node
         ('m_node', c_int * 6),    #        node numbers
         ('m_per', c_float),       # [  90] period of matrix
         ('m_s', c_float * 2048)   #        stiffness matrix
      ]
cs_matrix = CS_MATRIX()

class CBOUN(Structure):            # 180/00:+  Boundary elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_nvon', c_int),        #        start nodenumber
         ('m_nbis', c_int),        #        end nodenumber
         ('m_ndel', c_int),        #        increment
         ('m_typ', c_int),         #        type of bedding
         ('m_mess', c_int),        #        direction of addition
         ('m_ca', c_float),        #        start constant of bedding
         ('m_ce', c_float),        #        end constant of bedding
         ('m_dxyz', c_float * 3),  #        direction of bedding, X/Y/Z-component
         ('m_text',  c_int * 17)   #        Designation of element
      ]
cboun = CBOUN()

class CBOUN_RES(Structure):        # 180/LC  results of boundary elements
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_nk', c_int),          #        nodenumber
         ('m_px', c_float),        # [1153] X-support force
         ('m_py', c_float),        # [1153] Y-support force
         ('m_pz', c_float),        # [1153] Z-support force
         ('m_mn', c_float)         # [1154] support moment
      ]
cboun_res = CBOUN_RES()

class CBOUN_SUM(Structure):        # 181/LC  resultant of boundary results
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_px', c_float),        # [1151] X-support force
         ('m_py', c_float),        # [1151] X-support force
         ('m_pz', c_float),        # [1151] X-support force
         ('m_mn', c_float),        # [1152] N-support moment
         ('m_mx', c_float),        # [1152] X-support moment
         ('m_my', c_float),        # [1152] Y-support moment
         ('m_mz', c_float)         # [1152] Z-support moment
      ]
cboun_sum = CBOUN_SUM()

class CBOUN_LC_LPT(Structure):     #        node number + load value
   _fields_ = [
         ('m_n', c_int),
         ('m_p', c_float)
      ]
cboun_lc_lpt = CBOUN_LC_LPT()

class CBOUN_LC(Structure):         # 183/LC  Info on loading on boundaries
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_typ', c_int),         #        type of load
         ('m_lpt',  CBOUN_LC_LPT * 127)  #        node number + load value
      ]
cboun_lc = CBOUN_LC()

class CSPRI_SUM(Structure):        # 187/LC  Sum of forces of support springs
   _fields_ = [
         ('m_nr', c_int),          #        group-number
         ('m_px', c_float),        # [1151] nodal support X
         ('m_py', c_float),        # [1151] nodal support Y
         ('m_pz', c_float),        # [1151] nodal support u
         ('m_mx', c_float),        # [1152] support moment X
         ('m_my', c_float),        # [1152] support moment Y
         ('m_mz', c_float),        # [1152] support moment Z
         ('m_mb', c_float)         # [1105] warping moment
      ]
cspri_sum = CSPRI_SUM()

class CRSET(Structure):            # 188/00:+  Sets of results
   _fields_ = [
         ('m_id', c_int),          #        number / identifier of result set
         ('m_nit', c_int),         #        number of items in that result set
         ('m_text',  c_int * 17)   #        Designation of that set
      ]
crset = CRSET()

class CRSET_ITM(Structure):        # 188/00:0  Member of result set
   _fields_ = [
         ('m_id0', c_int),         #        Identifier = 0
         ('m_id', c_int * 2),      #        Short name of member for headdings
         ('m_ids', c_int * 2),     #        Selector of main structure
         ('m_idm', c_int * 2),     #        Selector of item member
         ('m_dim', c_int),         #        enum of explicitly selected unit
         ('m_kwh', c_int),         #        main id of result data
         ('m_pos', c_int),         #        position of value in data (starting at zero)
         ('m_bit', c_int),         #        bit pattern of defined selection data
         ('m_nr', c_int),          #        main number of result data
         ('m_ng', c_int),          #        second number of result data (e.g. group)
         ('m_nd1', c_int),         #        reserved for additional selection data
         ('m_nd2', c_int),         #        reserved for additional selection data
         ('m_nd3', c_int),         #        reserved for additional selection data
         ('m_x', c_float)          #        selector for beam abscissae
      ]
crset_itm = CRSET_ITM()

class CRSET_DAT(Structure):        # 188/LC  Result-values for sets of results
   _fields_ = [
         ('m_id', c_int),          #        identifier of result set
         ('m_val', c_float * 255)  #        result values
      ]
crset_dat = CRSET_DAT()

class CLINK(Structure):            # 179/00  link elements
   _fields_ = [
         ('m_nr', c_int),          #        pipenumber
         ('m_node', c_int * 2),    #        nodenumbers
         ('m_nrq', c_int),         #        material-, type- or cross-sectionnumber
         ('m_dl', c_float),        # [1001] length of pipe
         ('m_a', c_float),         #        Nominal width or linear loss factor
         ('m_b', c_float),         #        Abs. Roughness or quadratic loss factor
         ('m_c', c_float),         #        specific storage coefficient
         ('m_eps', c_float),       #        emission coefficient
         ('m_aref', c_float)       # [1002] reference area of element
      ]
clink = CLINK()

class CPIPE(Structure):            # 190/00  pipes / armatures
   _fields_ = [
         ('m_nr', c_int),          #        pipenumber
         ('m_node', c_int * 2),    #        nodenumbers
         ('m_nrq', c_int),         #        material-, type- or cross-sectionnumber
         ('m_dl', c_float),        # [1001] length of pipe
         ('m_a', c_float),         #        Nominal width or linear loss factor
         ('m_b', c_float),         #        Abs. Roughness or quadratic loss factor
         ('m_c', c_float),         #        specific storage coefficient
         ('m_eps', c_float),       #        emission coefficient
         ('m_aref', c_float)       # [1002] reference area of element
      ]
cpipe = CPIPE()

class CPIPE_RES(Structure):        # 190/LC  results of pipes
   _fields_ = [
         ('m_nr', c_int),          #        pipenumber
         ('m_ha', c_float),        # [1010] start potential
         ('m_he', c_float),        # [1010] end potential
         ('m_i', c_float),         #        gradient
         ('m_a', c_float),         # [1012] flow area
         ('m_pa', c_float),        # [  70] start compression
         ('m_pe', c_float),        # [  70] end compression
         ('m_q', c_float),         # [1211] flow quantity
         ('m_v', c_float),         # [1212] flow velocity
         ('m_r', c_float),         # [1011] hydraulic radius
         ('m_k', c_float),         # [1016] roughness
         ('m_re', c_float),        #        Reynolds number
         ('m_fr', c_float)         #        Froud    number
      ]
cpipe_res = CPIPE_RES()

class CQUAD(Structure):            # 200/00  QuadElements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_node', c_int * 4),    #        nodenumbers
         ('m_mat', c_int),         #        materialnumber
         ('m_mrf', c_int),         #        material Reinf.
         ('m_nra', c_int),         #        type of element
         ('m_det', c_float * 3),   #        Parameter of Jacobi Determinant
         ('m_thick', c_float * 5), # [1010] element thickness
         ('m_cb', c_float),        #        bedding factor
         ('m_cq', c_float),        #        tangential bedding factor
         ('m_t', c_float * 3 * 3), #        transformation matrix
         ('m_ifc1', c_int),        #        identifier of a most adjacent outer boundary
         ('m_dfc1', c_float * 4),  # [1001] distance of the nodes to the boundary IFC1
         ('m_ifc2', c_int),        #        identifier of a most adjacent inner boundary
         ('m_dfc2', c_float * 4)   # [1001] distance of the nodes to the boundary IFC2
      ]
cquad = CQUAD()

class CQUAD_NOH(Structure):        # 200/1:0  unified properties of Quad-nodes
   _fields_ = [
         ('m_id1', c_int),
         ('m_id2', c_int),
         ('m_nkrec', c_int),
         ('m_maxnel', c_int),
         ('m_maxugr', c_int),
         ('m_maxgr', c_int),
         ('m_nquad', c_int),
         ('m_mquad', c_int)        #        Highest Number of Quadelement
      ]
cquad_noh = CQUAD_NOH()

class CQUAD_NOM(Structure):        # 200/1:-  unified properties of Quad-nodes
   _fields_ = [
         ('m_ngt', c_int),         #        groupselector
         ('m_nr', c_int),          #        nodenumber
         ('m_iel', c_int * 9999)   #        connecting elements
      ]
cquad_nom = CQUAD_NOM()

class CQUAD_NOD(Structure):        # 200/1:*  properties of Quad-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_d', c_float),         # [1010] minimum thickness of plate on node
         ('m_t', c_float * 3 * 3)  #        lokal average coordinate system
      ]
cquad_nod = CQUAD_NOD()

class CQUAD_EDH(Structure):        # 200/2:0  Edges of Quad-elements
   _fields_ = [
         ('m_id1', c_int),
         ('m_id2', c_int),
         ('m_nedg', c_int),
         ('m_mqua', c_int)         #        max number of quads per edge
      ]
cquad_edh = CQUAD_EDH()

class CQUAD_EDG(Structure):        # 200/2:+  Edges of Quad-elements
   _fields_ = [
         ('m_ka', c_int),          #        First Node
         ('m_ke', c_int),          #        Last Node
         ('m_ijmp', c_int),        #        bit pattern of jump condition
         ('m_nqua', c_int),        #        number of quads
         ('m_nrel', c_int * 9999)  #        Number of Quad-elements
      ]
cquad_edg = CQUAD_EDG()

class CQUAD_TEN(Structure):        # 200/5  tendons of Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_nrs', c_int),         #        tendon number
         ('m_mnr', c_int),         #        tendon material
         ('m_iba1', c_int),        #        construction stage number for placing
         ('m_iba2', c_int),        #        construction stage number for grouting
         ('m_iba3', c_int),        #        construction stage number for removing
         ('m_r', c_float * 2),     #        isoparametric coordinates start/end point
         ('m_s', c_float * 2),     #        isoparametric coordinates start/end point
         ('m_z', c_float * 2),     # [1011] eccentricity of the middle area
         ('m_zz', c_float * 2),    # [1101] tendon force, start- and endpoint
         ('m_az', c_float),        # [1020] area of tendon
         ('m_uz', c_float),        # [1023] effect. periphery
         ('m_ah', c_float),        # [1020] area of duct
         ('m_ar', c_float),        # [1012] relative area
         ('m_dy', c_float * 2),    #        gradient of tendon
         ('m_dz', c_float * 2),    #        gradient of tendon
         ('m_exz', c_float * 2),   # [1011] perpendicular eccentricity of duct to tendon
         ('m_exy', c_float * 2),   # [1011] transverse eccentricity of duct to tendon
         ('m_sref', c_float * 2),  #        parameter values along tendon geometry
         ('m_xyzt', c_float * 2 * 3), # [1001] Coordinates of tendon start & endpoint
         ('m_xyzh', c_float * 2 * 3)  # [1001] Coordinates of duct start & endpoint
      ]
cquad_ten = CQUAD_TEN()

class CQUAD_RIM(Structure):        # 200/6  Prescribed Reinforcements of Quad-elements
   _fields_ = [
         ('m_nrg', c_int),         #        group number
         ('m_nr', c_int),          #        selector number
         ('m_typ', c_int),         #        Type of Reinforc.
         ('m_gtyp', c_int),        #        Type of grading
         ('m_idra', c_int),        #        drawing source type
         ('m_rio', c_float),       # [   5] direction of upside reinforcement
         ('m_rioq', c_float),      # [   5] direction of upside cross reinforcement
         ('m_rioi', c_float),      # [   5] direction of upside third reinforcement
         ('m_riu', c_float),       # [   5] direction of downside reinforcement
         ('m_riuq', c_float),      # [   5] direction of downside cross reinforcement
         ('m_riui', c_float),      # [   5] direction of downside third reinforcement
         ('m_xref', c_float),      # [1001] Reference point for circular reinforcement
         ('m_yref', c_float),      # [1001] Reference point for circular reinforcement
         ('m_zref', c_float),      # [1001] Reference point for circular reinforcement
         ('m_hio', c_float),       # [1024] distance of upside reinforcement
         ('m_hioq', c_float),      # [1024] distance of upside cross reinforcement
         ('m_hioi', c_float),      # [1024] distance of upside third reinforcement
         ('m_hiu', c_float),       # [1024] distance of downside reinforcement
         ('m_hiuq', c_float),      # [1024] distance of downside cross reinforcement
         ('m_hiui', c_float),      # [1024] distance of downside third reinforcement
         ('m_dio', c_float),       # [1023] Diameter of upside reinforcement
         ('m_dioq', c_float),      # [1023] Diameter of upside cross reinforcement
         ('m_dioi', c_float),      # [1023] Diameter of upside third reinforcement
         ('m_diu', c_float),       # [1023] Diameter of downside reinforcement
         ('m_diuq', c_float),      # [1023] Diameter of downside cross reinforcement
         ('m_diui', c_float),      # [1023] Diameter of downside third reinforcement
         ('m_dss', c_float),       # [1023] Diameter of stirrup reinforcement
         ('m_aso', c_float),       # [1021] upside Minimum reinforcement (outside)
         ('m_asoq', c_float),      # [1021] upside cross Minimum reinforcement (middle)
         ('m_asoi', c_float),      # [1021] upside third Minimum reinforcement (inside)
         ('m_asu', c_float),       # [1021] downside Minimum reinforcement (outside)
         ('m_asuq', c_float),      # [1021] downside cross Minimum reinforcement (middle)
         ('m_asui', c_float),      # [1021] downside third Minimum reinforcement (inside)
         ('m_ass', c_float),       # [1022] Min stirrup cm2/m2
         ('m_amo', c_float),       # [1021] upside Maximum reinforcement (outside)
         ('m_amoq', c_float),      # [1021] upside cross Maximum reinforcement (middle)
         ('m_amoi', c_float),      # [1021] upside third Maximum reinforcement (inside)
         ('m_amu', c_float),       # [1021] downside Maximum reinforcement (outside)
         ('m_amuq', c_float),      # [1021] downside cross Maximum reinforcement (middle)
         ('m_amui', c_float),      # [1021] downside third Maximum reinforcement (inside)
         ('m_ams', c_float),       # [1022] Max stirrup cm2/m2
         ('m_wk6', c_float * 6),   # [1026] design crack width
         ('m_sig6', c_float * 6)   # [1092] SLS steel stress limit
      ]
cquad_rim = CQUAD_RIM()

class CQUAD_RID(Structure):        # 200/7:0  Reinforcement Definitions of Quad-elements
   _fields_ = [
         ('m_id', c_int),          #        identifier (0 = Headder of a definition)
         ('m_nrg', c_int),         #        group number
         ('m_nr', c_int),          #        selector or element number
         ('m_bits', c_int),        #        Type of grading
         ('m_ass', c_float),       # [1022] Min stirrup ratio
         ('m_ams', c_float),       # [1022] Max stirrup ratio
         ('m_dss', c_float),       # [1023] Diameter of stirrup reinforcements
         ('m_expp', c_int),        #        Exposition class at positive face
         ('m_expn', c_int)         #        Exposition class at negative face
      ]
cquad_rid = CQUAD_RID()

class CQUAD_RED(Structure):        # 270/0:0  Evaluated Reinforcement Definitions of Elements
   _fields_ = [
         ('m_id', c_int),          #        identifier (0 = Headder of a definition)
         ('m_nrg', c_int),         #        group number
         ('m_nr', c_int),          #        selector or element number
         ('m_bits', c_int),        #        Type of grading
         ('m_ass', c_float),       # [1022] Min stirrup ratio
         ('m_ams', c_float),       # [1022] Max stirrup ratio
         ('m_dss', c_float),       # [1023] Diameter of stirrup reinforcements
         ('m_expp', c_int),        #        Exposition class at positive face
         ('m_expn', c_int)         #        Exposition class at negative face
      ]
cquad_red = CQUAD_RED()

class CQUAD_RIL(Structure):        # 200/7:+  Reinforcement Layers of Quad-elements
   _fields_ = [
         ('m_id', c_int),          #        reference for this layer
         ('m_dir', c_int),         #        Type of local x-direction
         ('m_rot', c_float),       # [   5] Angle with reference to the local x-direction
         ('m_xdir', c_float),      # [1001] Global reference direction or reference point
         ('m_ydir', c_float),      # [1001] Global reference direction or reference point
         ('m_zdir', c_float),      # [1001] Global reference direction or reference point
         ('m_h', c_float),         # [1011] effective distance according to ID-reference definition
         ('m_asmin', c_float),     # [1021] Min reinforcement value
         ('m_asmax', c_float),     # [1021] Max reinforcement value
         ('m_d', c_float),         # [1023] Diameter of reinforcements
         ('m_sig', c_float),       # [1092] SLS steel stress limit for crack width (optional)
         ('m_crw', c_float)        # [1026] design crack width (optional)
      ]
cquad_ril = CQUAD_RIL()

class CQUAD_REL(Structure):        # 270/0:+  Evaluated Reinforcement Definitions of Elements
   _fields_ = [
         ('m_id', c_int),          #        reference for this layer
         ('m_dir', c_int),         #        Type of local x-direction
         ('m_rot', c_float),       # [   5] Angle with reference to the local x-direction
         ('m_xdir', c_float),      # [1001] Global reference direction or reference point
         ('m_ydir', c_float),      # [1001] Global reference direction or reference point
         ('m_zdir', c_float),      # [1001] Global reference direction or reference point
         ('m_h', c_float),         # [1011] effective distance according to ID-reference definition
         ('m_asmin', c_float),     # [1021] Min reinforcement value
         ('m_asmax', c_float),     # [1021] Max reinforcement value
         ('m_d', c_float),         # [1023] Diameter of reinforcements
         ('m_sig', c_float),       # [1092] SLS steel stress limit for crack width (optional)
         ('m_crw', c_float)        # [1026] design crack width (optional)
      ]
cquad_rel = CQUAD_REL()

class CQCUT_0(Structure):          # 200/8:0  Header for fabrication areas
   _fields_ = [
         ('m_nr', c_int),          #        identifier = 0
         ('m_typ', c_int),         #        identifier = 0
         ('m_nar', c_int),         #        number of areas
         ('m_x', c_float),         # [1001] x-center
         ('m_y', c_float),         # [1001] y-
         ('m_ar3d', c_float),      # [1002] area in 3D
         ('m_ar2d', c_float),      # [1002] area in 2D
         ('m_ar_0', c_float)       # [1002] area stressfree
      ]
cqcut_0 = CQCUT_0()

class CQCUT_NEW(Structure):        # 200/8:+  New cutting area
   _fields_ = [
         ('m_nr', c_int),          #        areanumber
         ('m_typ', c_int),         #        identifier = 0
         ('m_lf', c_int),          #        Loadcase
         ('m_x', c_float),         # [1001] x-ordinate
         ('m_y', c_float),         # [1001] y- center(text)
         ('m_ar3d', c_float),      # [1002] area in 3D
         ('m_ar2d', c_float),      # [1002] area in 2D
         ('m_ar_0', c_float)       # [1002] area stressfree
      ]
cqcut_new = CQCUT_NEW()

class CQCUT_DIR(Structure):        # 200/8:+  Material direction
   _fields_ = [
         ('m_nr', c_int),          #        areanumber
         ('m_typ', c_int),         #        Identification
         ('m_mnr', c_int),         #        material no
         ('m_alf', c_float),       # [   5] warp direction
         ('m_emod', c_float),      # [1090] E Mod warp direction
         ('m_e90', c_float)        # [1090] Elasticity modulus perpendicular
      ]
cqcut_dir = CQCUT_DIR()

class CQCUT_OUT(Structure):        # 200/8:+  Vertex of geometric boundary
   _fields_ = [
         ('m_nr', c_int),          #        areanumber
         ('m_typ', c_int),         #        Identification
         ('m_line', c_int),        #        linetype
         ('m_x', c_float),         # [1001] x-ordinate
         ('m_y', c_float)          # [1001] y-ordinate
      ]
cqcut_out = CQCUT_OUT()

class CQCUT_IN(Structure):         # 200/8:+  Geometry inner lines
   _fields_ = [
         ('m_nr', c_int),          #        areanumber
         ('m_typ', c_int),         #        Identification
         ('m_i_2', c_int),
         ('m_xa', c_float),        # [1001] x  startpoint
         ('m_ya', c_float),        # [1001] y  startpoint
         ('m_xe', c_float),        # [1001] x  endpoint
         ('m_ye', c_float)         # [1001] y  endpoint
      ]
cqcut_in = CQCUT_IN()

class CQCUT_WAR(Structure):        # 200/8:+  element warp direction
   _fields_ = [
         ('m_nr', c_int),          #        areanumber
         ('m_typ', c_int),         #        Identification
         ('m_nrel', c_int),        #        orig elem.no
         ('m_xa', c_float),        # [1001] x  startpoint
         ('m_ya', c_float),        # [1001] y  startpoint
         ('m_xe', c_float),        # [1001] x  endpoint
         ('m_ye', c_float),        # [1001] y  endpoint
         ('m_alf', c_float)        # [   5] warp direction
      ]
cqcut_war = CQCUT_WAR()

class CTEXTILE(Structure):         # 200/9  definition of cutting lines
   _fields_ = [
         ('m_ig', c_int),          #        group selector
         ('m_typ', c_int),         #        type of line
         ('m_xa', c_float),        # [1001] line point A
         ('m_ya', c_float),        # [1001] 
         ('m_za', c_float),        # [1001] 
         ('m_xe', c_float),        # [1001] line point E
         ('m_ye', c_float),        # [1001] 
         ('m_ze', c_float),        # [1001] 
         ('m_nx', c_float),        # [1001] projection
         ('m_ny', c_float),        # [1001] 
         ('m_nz', c_float)         # [1001] 
      ]
ctextile = CTEXTILE()

class CQUAD_P(Structure):          # 200/10  Quad-P-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_node', c_int * 4),    #        nodenumbers
         ('m_mat', c_int),         #        materialnumber
         ('m_mrf', c_int),         #        material Reinf.
         ('m_nra', c_int),         #        type of element
         ('m_edge', c_int * 4),    #        No of geometric property of edge 1-2
         ('m_det', c_float * 3),   #        Parameter of Jacobi Determinant
         ('m_thick', c_float * 5), # [1010] element thickness
         ('m_cb', c_float),        #        bedding factor
         ('m_cq', c_float),        #        tangential bedding factor
         ('m_t', c_float * 3 * 3)  #        transformation matrix
      ]
cquad_p = CQUAD_P()

class CQUAD_LOA(Structure):        # 202/LC  Quad-element loads
   _fields_ = [
         ('m_von', c_int),         #        start elementnumber
         ('m_bis', c_int),         #        end elementnumber
         ('m_del', c_int),         #        increment
         ('m_typ', c_int),         #        type of load
         ('m_lnr', c_int),         #        special option value
         ('m_p', c_float),         #        load values
         ('m_dpdx', c_float),
         ('m_dpdy', c_float),
         ('m_dpdz', c_float),
         ('m_xref', c_float),      # [1001] optional reference point for load value to
         ('m_yref', c_float),      # [1001] 
         ('m_zref', c_float),      # [1001] 
         ('m_tfun', c_float * 16 * 2)  #        optional function of load values across the
      ]
cquad_loa = CQUAD_LOA()

class CQUAD_LPI(Structure):        # 203/LC:*  internal single loads on Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_typ', c_int),         #        type of load
         ('m_prz', c_float),       # [   8] Percentage of load covered with elements
         ('m_s', c_float),         #        load point in local coordinates
         ('m_t', c_float),         #        load point in local coordinates
         ('m_p', c_float)          #        load value
      ]
cquad_lpi = CQUAD_LPI()

class CQUAD_LLI(Structure):        # 203/LC:*  internal line loads of Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_typ', c_int),         #        type of load
         ('m_prz', c_float),       # [   8] 
         ('m_sa', c_float),
         ('m_ta', c_float),
         ('m_pa', c_float),
         ('m_sb', c_float),
         ('m_tb', c_float),
         ('m_pb', c_float)         #        load value end point
      ]
cquad_lli = CQUAD_LLI()

class CQUAD_LAI_LPT(Structure):    #        load points in local coordinates
   _fields_ = [
         ('m_s', c_float),
         ('m_t', c_float),
         ('m_p', c_float)
      ]
cquad_lai_lpt = CQUAD_LAI_LPT()

class CQUAD_LAI(Structure):        # 203/LC:*  Free area loads on Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        element number
         ('m_typ', c_int),         #        type of load
         ('m_prz', c_float),       # [   8] 
         ('m_lpt',  CQUAD_LAI_LPT * 63)  #        load points in local coordinates
      ]
cquad_lai = CQUAD_LAI()

class CQUAD_LT(Structure):         # 206/NR  Temperature load profiles for QUADs
   _fields_ = [
         ('m_t', c_float),         # [  90] Time value
         ('m_temp', c_float * 20 * 5)  #        Temperature values
      ]
cquad_lt = CQUAD_LT()

class CQUAD_FOC(Structure):        # 210/LC:0  maximum forces of Quad elements
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force
         ('m_vy', c_float),        # [1111] shear force
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_hp1', c_float),       #        yield function
         ('m_hp2', c_float)        #        volum. hardening
      ]
cquad_foc = CQUAD_FOC()

class CQUAD_FOR(Structure):        # 210/LC:+  forces of Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force
         ('m_vy', c_float),        # [1111] shear force
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_sg', c_float * 4 * 8),# [1112] results in GAUSS-points
         ('m_hp1', c_float * 5),   #        yield function
         ('m_hp2', c_float * 5),   #        volum. hardening
         ('m_hp3', c_float * 5)    #        3rd parameter
      ]
cquad_for = CQUAD_FOR()

class CQUAD_NFC(Structure):        # 211/LC:0  maximum forces in nodes
   _fields_ = [
         ('m_ng', c_int),          #        ident 0 for maximum (first records)
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force
         ('m_vy', c_float),        # [1111] shear force
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_vx_v', c_float),      # [1111] shear force signed
         ('m_vy_v', c_float),      # [1111] shear force signed
         ('m_hp1', c_float)        #        yield function
      ]
cquad_nfc = CQUAD_NFC()

class CQUAD_NFO(Structure):        # 211/LC:Z+  Nodal Quad forces
   _fields_ = [
         ('m_ng', c_int),          #        groupselector
         ('m_nr', c_int),          #        nodenumber
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force abs
         ('m_vy', c_float),        # [1111] shear force abs
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_vx_v', c_float),      # [1111] shear force signed
         ('m_vy_v', c_float),      # [1111] shear force signed
         ('m_fy', c_float)         #        yield function
      ]
cquad_nfo = CQUAD_NFO()

class CQUAD_EFC(Structure):        # 212/LC:0  maximum error estimates for Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force
         ('m_vy', c_float),        # [1111] shear force
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_err', c_float)        #        error in energy
      ]
cquad_efc = CQUAD_EFC()

class CQUAD_EFO(Structure):        # 212/LC:+  error estimates for Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_mxx', c_float),       # [1114] bending moment
         ('m_myy', c_float),       # [1114] bending moment
         ('m_mxy', c_float),       # [1113] torsion moment
         ('m_vx', c_float),        # [1111] shear force
         ('m_vy', c_float),        # [1111] shear force
         ('m_nx', c_float),        # [1112] membran force
         ('m_ny', c_float),        # [1112] membran force
         ('m_nxy', c_float),       # [1112] membran force
         ('m_hopt', c_float)       # [1001] optimal mesh size
      ]
cquad_efo = CQUAD_EFO()

class CQUAD_BEC(Structure):        # 213/LC:0  bedding stresses and results
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_pse', c_float),       # [1155] bedding centre
         ('m_ps', c_float * 4),    # [1155] bedding in nodes
         ('m_pre', c_float),       # [1151] result bedd.force in centre
         ('m_pr', c_float * 4),    # [1151] result bedd. values in Quad-nodes
         ('m_pve', c_float),       # [1003] bedding displacememts in centre
         ('m_pv', c_float * 4),    # [1003] bedding displacements in nodes
         ('m_pte', c_float),       # [1155] tangential bedding in centre
         ('m_pt', c_float * 4),    # [1155] tangential bedding in nodes
         ('m_ptxe', c_float),      # [1155] tangential bedding in centre X-component
         ('m_ptx', c_float * 4),   # [1155] tangential bedding in nodes X-component
         ('m_ptye', c_float),      # [1155] tangential bedding in centre Y-component
         ('m_pty', c_float * 4),   # [1155] tangential bedding in nodes Y-component
         ('m_ptze', c_float),      # [1155] tangential bedding in centre Z-component
         ('m_ptz', c_float * 4),   # [1155] tangential bedding in nodes Z-component
         ('m_rq', c_float * 12)    # [1151] resulting tangential bedding in nodes
      ]
cquad_bec = CQUAD_BEC()

class CQUAD_BED(Structure):        # 213/LC:+  bedding stresses and results
   _fields_ = [
         ('m_nr', c_int),          #        Quadelementnumber
         ('m_pse', c_float),       # [1155] bedding centre
         ('m_ps', c_float * 4),    # [1155] bedding in nodes
         ('m_pre', c_float),       # [1151] result bedd.force in centre
         ('m_pr', c_float * 4),    # [1151] result bedd. values in Quad-nodes
         ('m_pve', c_float),       # [1003] bedding displacememts in centre
         ('m_pv', c_float * 4),    # [1003] bedding displacements in nodes
         ('m_pte', c_float),       # [1155] tangential bedding in centre
         ('m_pt', c_float * 4),    # [1155] tangential bedding in nodes
         ('m_ptxe', c_float),      # [1155] tangential bedding in centre X-component
         ('m_ptx', c_float * 4),   # [1155] tangential bedding in nodes X-component
         ('m_ptye', c_float),      # [1155] tangential bedding in centre Y-component
         ('m_pty', c_float * 4),   # [1155] tangential bedding in nodes Y-component
         ('m_ptze', c_float),      # [1155] tangential bedding in centre Z-component
         ('m_ptz', c_float * 4),   # [1155] tangential bedding in nodes Z-component
         ('m_rq', c_float * 12)    # [1151] resulting tangential bedding in nodes
      ]
cquad_bed = CQUAD_BED()

class CQUAD_RFX(Structure):        # 214/LC  additional information for primary loadcases
   _fields_ = [
         ('m_nr', c_int),          #        Quad-elementnumber
         ('m_eps', c_float * 8 * 5), #        strain
         ('m_riss', c_float * 8 * 5)  #        directions of crack
      ]
cquad_rfx = CQUAD_RFX()

class CQUAD_RNC(Structure):        # 215/LC:0  nonlinear results of Quad-element
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum
         ('m_nmat', c_int),        #        type of material behaviour
         ('m_esxo', c_float),      # [   9] upside strain
         ('m_esyo', c_float),      # [   9] upside strain
         ('m_exyo', c_float),      # [   9] upside strain
         ('m_esmo', c_float),      # [   9] upside reference strain
         ('m_esxu', c_float),      # [   9] downside strain
         ('m_esyu', c_float),      # [   9] downside strain
         ('m_exyu', c_float),      # [   9] downside strain
         ('m_esmu', c_float),      # [   9] downside reference strain
         ('m_sxo', c_float),       # [1092] upside stress
         ('m_syo', c_float),       # [1092] upside stress
         ('m_sxyo', c_float),      # [1092] upside stress
         ('m_smo', c_float),       # [1092] upside reference stress
         ('m_sxu', c_float),       # [1092] downside stress
         ('m_syu', c_float),       # [1092] downside stress
         ('m_sxyu', c_float),      # [1092] downside stress
         ('m_sm_u', c_float),      # [1092] downside reference stress
         ('m_sgvo', c_float),      # [1092] upside reference stress incl. shear
         ('m_sgvu', c_float),      # [1092] downside reference stress incl. shear
         ('m_fy', c_float),        #        yield function
         ('m_fdo', c_float),       # [1011] steel - upside yield depth
         ('m_fdu', c_float),       # [1011] steel - downside yield depth
         ('m_i_22', c_float),
         ('m_wr1o', c_float),      #        concrete - upside direction of crack 1
         ('m_wr1u', c_float),      #        concrete - downside direction of crack 1
         ('m_wr2o', c_float),      #        concrete - upside direction of crack 2
         ('m_wr2u', c_float),      #        concrete - downside direction of crack 2
         ('m_sgso', c_float),      # [1092] concrete - upside shear stress on crack
         ('m_sgsu', c_float),      # [1092] concrete - downside shear stress on crack
         ('m_sg1o', c_float),      # [1092] concrete - upside steel stress II,dir.1
         ('m_sg1u', c_float),      # [1092] concrete - downside steel stress II,dir.1
         ('m_sg2o', c_float),      # [1092] concrete - upside steel stress II,dir. 2
         ('m_sg2u', c_float),      # [1092] concrete - downside steel stress II,dir.2
         ('m_w1o', c_float),       # [1026] concrete - upside width of crack,direct. 1
         ('m_w1u', c_float),       # [1026] concrete - downside width of crack,dir. 1
         ('m_w2o', c_float),       # [1026] concrete - upside width of crack,direct. 2
         ('m_w2u', c_float),       # [1026] concrete - downside width of crack,dir. 2
         ('m_bro', c_float),       #        concrete -upside direction reinforcement
         ('m_bru', c_float),       #        concrete -downs. direction reinforcement
         ('m_xd_x', c_float),      # [1011] Minimum compression depth in local x axis
         ('m_xd_y', c_float),      # [1011] Minimum compression depth in local y axis
         ('m_xd_1', c_float),      # [1011] Minimum compression depth at least pressed uniaxial
         ('m_xd_2', c_float),      # [1011] Minimum compression depth pressed biaxial
         ('m_epsb', c_float),      # [   9] Maximum concrete compression strain
         ('m_epsc', c_float),      # [   9] Minimum averaged reinforcement strain
         ('m_epst', c_float),      # [   9] Maximum averaged reinforcement strain
         ('m_sigc', c_float),      # [1092] Maximum concrete compression stress
         ('m_sigt', c_float),      # [1092] Maximum concrete tension in the concrete layers
         ('m_epsr', c_float)       # [   9] Maximum reinforcement strain in the crack
      ]
cquad_rnc = CQUAD_RNC()

class CQUAD_RNO(Structure):        # 215/LC:+  nonlinear results of Quad-element
   _fields_ = [
         ('m_nr', c_int),          #        Quad-elementnumber
         ('m_nmat', c_int),        #        type of material behaviour
         ('m_esxo', c_float),      # [   9] upside strain
         ('m_esyo', c_float),      # [   9] upside strain
         ('m_exyo', c_float),      # [   9] upside strain
         ('m_esmo', c_float),      # [   9] upside reference strain
         ('m_esxu', c_float),      # [   9] downside strain
         ('m_esyu', c_float),      # [   9] downside strain
         ('m_exyu', c_float),      # [   9] downside strain
         ('m_esmu', c_float),      # [   9] downside reference strain
         ('m_sxo', c_float),       # [1092] upside stress
         ('m_syo', c_float),       # [1092] upside stress
         ('m_sxyo', c_float),      # [1092] upside stress
         ('m_smo', c_float),       # [1092] upside reference stress
         ('m_sxu', c_float),       # [1092] downside stress
         ('m_syu', c_float),       # [1092] downside stress
         ('m_sxyu', c_float),      # [1092] downside stress
         ('m_sm_u', c_float),      # [1092] downside reference stress
         ('m_sgvo', c_float),      # [1092] upside reference stress incl. shear
         ('m_sgvu', c_float),      # [1092] downside reference stress incl. shear
         ('m_fy', c_float),        #        yield function
         ('m_fdo', c_float),       # [1011] steel - upside yield depth
         ('m_fdu', c_float),       # [1011] steel - downside yield depth
         ('m_i_22', c_float),
         ('m_wr1o', c_float),      #        concrete - upside direction of crack 1
         ('m_wr1u', c_float),      #        concrete - downside direction of crack 1
         ('m_wr2o', c_float),      #        concrete - upside direction of crack 2
         ('m_wr2u', c_float),      #        concrete - downside direction of crack 2
         ('m_sgso', c_float),      # [1092] concrete - upside shear stress on crack
         ('m_sgsu', c_float),      # [1092] concrete - downside shear stress on crack
         ('m_sg1o', c_float),      # [1092] concrete - upside steel stress II,dir.1
         ('m_sg1u', c_float),      # [1092] concrete - downside steel stress II,dir.1
         ('m_sg2o', c_float),      # [1092] concrete - upside steel stress II,dir. 2
         ('m_sg2u', c_float),      # [1092] concrete - downside steel stress II,dir.2
         ('m_w1o', c_float),       # [1026] concrete - upside width of crack,direct. 1
         ('m_w1u', c_float),       # [1026] concrete - downside width of crack,dir. 1
         ('m_w2o', c_float),       # [1026] concrete - upside width of crack,direct. 2
         ('m_w2u', c_float),       # [1026] concrete - downside width of crack,dir. 2
         ('m_bro', c_float),       #        concrete -upside direction reinforcement
         ('m_bru', c_float),       #        concrete -downs. direction reinforcement
         ('m_xd_x', c_float),      # [1011] Minimum compression depth in local x axis
         ('m_xd_y', c_float),      # [1011] Minimum compression depth in local y axis
         ('m_xd_1', c_float),      # [1011] Minimum compression depth at least pressed uniaxial
         ('m_xd_2', c_float),      # [1011] Minimum compression depth pressed biaxial
         ('m_epsb', c_float),      # [   9] Maximum concrete compression strain
         ('m_epsc', c_float),      # [   9] Minimum averaged reinforcement strain
         ('m_epst', c_float),      # [   9] Maximum averaged reinforcement strain
         ('m_sigc', c_float),      # [1092] Maximum concrete compression stress
         ('m_sigt', c_float),      # [1092] Maximum concrete tension in the concrete layers
         ('m_epsr', c_float)       # [   9] Maximum reinforcement strain in the crack
      ]
cquad_rno = CQUAD_RNO()

class CQUAD_STC(Structure):        # 220/LC:0  maximum Quad-stress
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_svxy', c_float),      # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_hp1', c_float),       # [1092] yield function
         ('m_hp2', c_float),       #        2nd Parameter
         ('m_hp3', c_float),       #        3rd Parameter
         ('m_hp4', c_float),       #        4th Parameter
         ('m_hp5', c_float),       #        5th Parameter
         ('m_hp6', c_float)        #        6th Parameter
      ]
cquad_stc = CQUAD_STC()

class CQUAD_STP_HTYP(Structure):   #        = state variables for nonlinear material
   _fields_ = [
         ('m_id', c_int),
         ('m_idim', c_int),
         ('m_maxval', c_float)
      ]
cquad_stp_htyp = CQUAD_STP_HTYP()

class CQUAD_STP(Structure):        # 220/LC:-  Nonlinear QUAD-stress Headder
   _fields_ = [
         ('m_typ', c_int),         #        enum of nonlinear parameters as in 1/NR:1/???
         ('m_htyp',  CQUAD_STP_HTYP * 15)  #        = state variables for nonlinear material
      ]
cquad_stp = CQUAD_STP()

class CBRIC_STP_HTYP(Structure):   #        = state variables for nonlinear material
   _fields_ = [
         ('m_id', c_int),
         ('m_idim', c_int),
         ('m_maxval', c_float)
      ]
cbric_stp_htyp = CBRIC_STP_HTYP()

class CBRIC_STP(Structure):        # 310/LC:-  Nonlinear BRIC-stress Headder
   _fields_ = [
         ('m_typ', c_int),         #        enum of nonlinear parameters as in 1/NR:1/???
         ('m_htyp',  CBRIC_STP_HTYP * 15)  #        = state variables for nonlinear material
      ]
cbric_stp = CBRIC_STP()

class CQUAD_STR_SG(Structure):     #        results in GAUSS-points
   _fields_ = [
         ('m_sigx', c_float),      # [1092] 
         ('m_sigy', c_float),      # [1092] 
         ('m_tau', c_float),       # [1092] 
         ('m_sigz', c_float)       # [1092] 
      ]
cquad_str_sg = CQUAD_STR_SG()

class CQUAD_STR(Structure):        # 220/LC  stresses of Quad-element
   _fields_ = [
         ('m_nr', c_int),          #        Elementnumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_sg',  CQUAD_STR_SG * 4), #        results in GAUSS-points
         ('m_pvx', c_float),       # [1192] volume loading
         ('m_pvy', c_float),       # [1192] volume loading
         ('m_pvt', c_float),       # [   6] temperature loads
         ('m_hp1', c_float * 5),   #        yield function
         ('m_hp2', c_float * 5),   #        2nd parameter as specified in headder record
         ('m_hp3', c_float * 5),   #        3rd parameter as specified in headder record
         ('m_hp4', c_float * 5),   #        4th parameter as specified in headder record
         ('m_hp5', c_float * 5),   #        5th parameter as specified in headder record
         ('m_hp6', c_float * 5),   #        6th parameter as specified in headder record
         ('m_hp7', c_float * 5),   #        7th parameter as specified in headder record
         ('m_hp8', c_float * 5),   #        8th parameter as specified in headder record
         ('m_hp9', c_float * 5),   #        9th parameter as specified in headder record
         ('m_hp10', c_float * 5),  #        10th parameter as specified in headder record
         ('m_hp11', c_float * 5),  #        11th parameter as specified in headder record
         ('m_hp12', c_float * 5),  #        12th parameter as specified in headder record
         ('m_hp13', c_float * 5),  #        13th parameter as specified in headder record
         ('m_hp14', c_float * 5),  #        14th parameter as specified in headder record
         ('m_hp15', c_float * 5)   #        15th parameter as specified in headder record
      ]
cquad_str = CQUAD_STR()

class CQUAD_NSC(Structure):        # 221/LC:0  maximum stresses in nodes
   _fields_ = [
         ('m_ng', c_int),          #        ident 0 for maximum (first records)
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_svxy', c_float),      # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_fy', c_float)         #        yield function
      ]
cquad_nsc = CQUAD_NSC()

class CQUAD_NST(Structure):        # 221/LC:Z+  stresses in Quad-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_fy', c_float)         #        yield function
      ]
cquad_nst = CQUAD_NST()

class CQUAD_ESC(Structure):        # 222/LC:0  max. errors in nodes
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_svxy', c_float),      # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_err', c_float)        #        error in energy
      ]
cquad_esc = CQUAD_ESC()

class CQUAD_EST(Structure):        # 222/LC:+  error estimates of Quad-element stresses
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_tau', c_float),       # [1092] shear stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_hopt', c_float)       # [1002] optimal mesh size
      ]
cquad_est = CQUAD_EST()

class CQUAD_RLC(Structure):        # 225/LC:0  max Quad-Layer-results
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_mnr', c_int),         #        ident 0 for maximum (first records)
         ('m_xi', c_float),        #        local-z
         ('m_sigx', c_float),      # [1092] stress x
         ('m_sigy', c_float),      # [1092] stress y
         ('m_tau', c_float),       # [1092] shear stress xy
         ('m_sigz', c_float),      # [1092] stress
         ('m_taux', c_float),      # [1092] shear stress vx
         ('m_tauy', c_float),      # [1092] shear stress vy
         ('m_hp1', c_float),       #        yield function
         ('m_hp2', c_float),       #        volum. hardening
         ('m_hp3', c_float),       #        damage parameter x
         ('m_hp4', c_float),       #        damage parameter y
         ('m_hp5', c_float),       # [   3] crack direction 1
         ('m_hp6', c_float),       # [   3] crack direction 2
         ('m_hp7', c_float),       # [   9] accumulated temperature strain
         ('m_hp8', c_float),       #        internal damage parameter shrinkage
         ('m_hp9', c_float),       # [   9] accumulated shrinkage strain
         ('m_hp10', c_float),      #        damage parameter xy
         ('m_hp11', c_float),      # [   9] epsx  strain in stress strain curve
         ('m_hp12', c_float),      # [   9] epsy  strain in stress strain curve
         ('m_hp13', c_float)       # [1215] layer temperature in case of fire analysis
      ]
cquad_rlc = CQUAD_RLC()

class CQUAD_RLA_SG(Structure):     #        results in GAUSS-points
   _fields_ = [
         ('m_sigx', c_float),      # [1092] 
         ('m_sigy', c_float),      # [1092] 
         ('m_tau', c_float),       # [1092] 
         ('m_sigz', c_float),      # [1092] 
         ('m_taux', c_float),      # [1092] 
         ('m_tauy', c_float)       # [1092] 
      ]
cquad_rla_sg = CQUAD_RLA_SG()

class CQUAD_RLA(Structure):        # 225/LC:+  Layer-stresses of Quads
   _fields_ = [
         ('m_nr', c_int),          #        Elementnumber
         ('m_mnr', c_int),         #        Materialnumber MNR>0
         ('m_xi', c_float),        #        local-z
         ('m_sigx', c_float),      # [1092] stress x
         ('m_sigy', c_float),      # [1092] stress y
         ('m_tau', c_float),       # [1092] shear stress xy
         ('m_sigz', c_float),      # [1092] stress
         ('m_taux', c_float),      # [1092] shear stress vx
         ('m_tauy', c_float),      # [1092] shear stress vy
         ('m_sg',  CQUAD_RLA_SG * 4), #        results in GAUSS-points
         ('m_hp1', c_float * 5),   #        yield function
         ('m_hp2', c_float * 5),   #        volum. hardening
         ('m_hp3', c_float * 5),   #        damage parameter x
         ('m_hp4', c_float * 5),   #        damage parameter y
         ('m_hp5', c_float * 5),   # [   3] crack direction 1
         ('m_hp6', c_float * 5),   # [   3] crack direction 2
         ('m_hp7', c_float * 5),   # [   9] accumulated temperature strain
         ('m_hp8', c_float * 5),   #        internal damage parameter shrinkage
         ('m_hp9', c_float * 5),   # [   9] accumulated shrinkage strain
         ('m_hp10', c_float * 5),  #        damage parameter xy
         ('m_hp11', c_float * 5),  # [   9] epsx  strain in stress strain curve
         ('m_hp12', c_float * 5),  # [   9] epsy  strain in stress strain curve
         ('m_hp13', c_float * 5),  # [1215] layer temperature in case of fire analysis
         ('m_hp14', c_float * 5)   # [1215] max. layer temperature in load history
      ]
cquad_rla = CQUAD_RLA()

class CQUAD_RLB_SG(Structure):     #        results in GAUSS-points
   _fields_ = [
         ('m_sig1', c_float),      # [1092] 
         ('m_sig2', c_float),      # [1092] 
         ('m_eps1', c_float),
         ('m_xi1', c_float),
         ('m_xi2', c_float),
         ('m_eps2', c_float)
      ]
cquad_rlb_sg = CQUAD_RLB_SG()

class CQUAD_RLB(Structure):        # 225/LC:+  Layer-reinforcement stresses of Quads MNR=-1
   _fields_ = [
         ('m_nr', c_int),          #        Elementnumber
         ('m_mnr', c_int),         #        MNR=-1 identifier for reinforcement data
         ('m_xi', c_float),        #        xi=-0.8 top reinforcement, xi=+0.8 bottom reinforcement
         ('m_sig1', c_float),      # [1092] stress in reinforcement 1. layer
         ('m_sig2', c_float),      # [1092] stress in reinforcement 2. layer
         ('m_eps1', c_float),      #        eps strain in stress strain curve 1. layer
         ('m_xi1', c_float),       #        exact xi position 1. layer
         ('m_xi2', c_float),       #        exact xi position 2. layer
         ('m_eps2', c_float),      #        eps strain in stress strain curve 2. layer
         ('m_sg',  CQUAD_RLB_SG * 4), #        results in GAUSS-points
         ('m_hp1', c_float * 5),   #        damage parameter 1. layer
         ('m_hp2', c_float * 5),   #        damage parameter 2. layer
         ('m_hp3', c_float * 5),   # [1092] delta-sigma tension stiff. layer 1
         ('m_hp4', c_float * 5),   # [1092] delta-sigma tension stiff. layer 2
         ('m_hp5', c_float * 5),   #        direction of reinforcement layer 1
         ('m_hp6', c_float * 5),   #        direction of reinforcement layer 2
         ('m_hp7', c_float * 5),   # [   9] accumulated temperature strain
         ('m_hp8', c_float * 5),   #        free
         ('m_hp9', c_float * 5),   #        free
         ('m_hp10', c_float * 5),  # [1215] layer 1 actual temperature in case of fire analysis
         ('m_hp11', c_float * 5)   # [1215] layer 2 actual temperature in case of fire analysis
      ]
cquad_rlb = CQUAD_RLB()

class CQUAD_SEC(Structure):        # 229/LC:0  maximum Quad-sectional stress
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] normalstress
         ('m_sigy', c_float),      # [1092] transverse stress
         ('m_sigz', c_float),      # [1092] transverse stress
         ('m_tauxy', c_float),     # [1092] shear stress
         ('m_tauxz', c_float),     # [1092] shear stress
         ('m_tauyz', c_float)      # [1092] shear stress
      ]
cquad_sec = CQUAD_SEC()

class CQUAD_SEQ(Structure):        # 229/LC:-  location of sectional results in master
   _fields_ = [
         ('m_nr', c_int),          #        negative beam number
         ('m_x', c_float)          # [1001] section along beam
      ]
cquad_seq = CQUAD_SEQ()

class CQUAD_SER(Structure):        # 229/LC:+  stresses of sectional Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        Elementnumber
         ('m_sigx', c_float),      # [1092] normalstress
         ('m_sigy', c_float),      # [1092] transverse stress
         ('m_sigz', c_float),      # [1092] transverse stress
         ('m_tauxy', c_float),     # [1092] shear stress
         ('m_tauxz', c_float),     # [1092] shear stress
         ('m_tauyz', c_float)      # [1092] shear stress
      ]
cquad_ser = CQUAD_SER()

class CQUAD_RT0(Structure):        # 230/LC:0  maximum of tendon stresses
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nrs', c_int),         #        identifier 0
         ('m_sigz', c_float),      # [1092] stress increment
         ('m_zz', c_float),        # [1101] force in tendon
         ('m_zh', c_float),        # [1101] duct deduction force
         ('m_szg1', c_float),      # [1092] stress in G-point 1
         ('m_szg2', c_float),      # [1092] stress in G-point 2
         ('m_zzx1', c_float),      # [1101] force tendon+cement1
         ('m_zzx2', c_float),      # [1101] force tendon+cement1
         ('m_zhg1', c_float),      # [1101] duct deduction G1
         ('m_zhg2', c_float),      # [1101] duct deduction G2
         ('m_zzg1', c_float),      # [1101] force in tendon G1
         ('m_zzg2', c_float),      # [1101] force in tendon G2
         ('m_age', c_float),       # [  93] age since prestress
         ('m_relz', c_float),      #        accumulated relaxation
         ('m_tzg1', c_float),      # [1215] temperature tendon G1
         ('m_tzg2', c_float),      # [1215] temperature tendon G2
         ('m_thg1', c_float),      # [1215] temperature tendon duct G1
         ('m_thg2', c_float)       # [1215] temperature tendon duct G2
      ]
cquad_rt0 = CQUAD_RT0()

class CQUAD_RTS(Structure):        # 230/LC  tendon stresses in two integration points
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_nrs', c_int),         #        tendonnumber
         ('m_sigz', c_float),      # [1092] stress increment
         ('m_zz', c_float),        # [1101] force in tendon
         ('m_zh', c_float),        # [1101] duct deduction force
         ('m_szg1', c_float),      # [1092] stress in G-point 1
         ('m_szg2', c_float),      # [1092] stress in G-point 2
         ('m_zzx1', c_float),      # [1101] force tendon+cement1
         ('m_zzx2', c_float),      # [1101] force tendon+cement1
         ('m_zhg1', c_float),      # [1101] duct deduction G1
         ('m_zhg2', c_float),      # [1101] duct deduction G2
         ('m_zzg1', c_float),      # [1101] force in tendon G1
         ('m_zzg2', c_float),      # [1101] force in tendon G2
         ('m_age', c_float),       # [  93] age since prestress
         ('m_relz', c_float),      #        accumulated relaxation
         ('m_tzg1', c_float),      # [1215] temperature tendon G1
         ('m_tzg2', c_float),      # [1215] temperature tendon G2
         ('m_thg1', c_float),      # [1215] temperature tendon duct G1
         ('m_thg2', c_float)       # [1215] temperature tendon duct G2
      ]
cquad_rts = CQUAD_RTS()

class CQUAD_DST(Structure):        # 250/DC  design stresses in Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_smio', c_float),      # [1092] minimum upside main stress
         ('m_smao', c_float),      # [1092] maximum upside main stress
         ('m_smiu', c_float),      # [1092] minimum downside main stress
         ('m_smau', c_float),      # [1092] maximum downside main stress
         ('m_taum', c_float),      # [1092] maximum shear stress
         ('m_svma', c_float),      # [1092] maximum reference stress
         ('m_svo', c_float),       # [1092] maximum reference stress upside
         ('m_svu', c_float),       # [1092] maximum reference stress downside
         ('m_reserved', c_float * 7), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
cquad_dst = CQUAD_DST()

class CQUAD_NDS(Structure):        # 251/DC  design stresses in Quad-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_smio', c_float),      # [1092] minimum upside main stress Minimale Hauptspannung oben
         ('m_smao', c_float),      # [1092] maximum upside main stress Maximale Hauptspannung oben
         ('m_smiu', c_float),      # [1092] minimum downside main stress Minimale Hauptspannung unten
         ('m_smau', c_float),      # [1092] maximum downside main stress Maximale Hauptspannung unten
         ('m_taum', c_float),      # [1092] maximum shear stress
         ('m_svma', c_float),      # [1092] maximum reference stress
         ('m_svo', c_float),       # [1092] maximum reference stress upside
         ('m_svu', c_float),       # [1092] maximum reference stress downside
         ('m_reserved', c_float * 7), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of designcase
      ]
cquad_nds = CQUAD_NDS()

class CQUAD_RIC(Structure):        # 260/DC:0  maximum reinforcement in Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        ident 0
         ('m_aso', c_float),       # [1021] upside reinforcement (outside)
         ('m_asoq', c_float),      # [1021] upside cross reinforcement (middle)
         ('m_asu', c_float),       # [1021] downside reinforcement (outside)
         ('m_asuq', c_float),      # [1021] downside cross reinforcement (middle)
         ('m_asoi', c_float),      # [1021] upside third reinforcement (inside)
         ('m_asui', c_float),      # [1021] downside third reinforcement (inside)
         ('m_ass', c_float),       # [1022] stirrup cm2/m2
         ('m_asse', c_float),      # [1020] stirrup cm2
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_sixo', c_float),      # [1030] upside reinforcement quantity
         ('m_sixu', c_float),      # [1030] downside reinforcement quantity
         ('m_sixs', c_float),      # [1030] shear reinforcement quantity
         ('m_free0', c_float * 3), #        not yet used
         ('m_zmin', c_float),      # [1001] minimum lever arm
         ('m_vedr', c_float),      #        max. VED/VRDMAX
         ('m_cott', c_float),      #        max. cot_theta
         ('m_ved', c_float),       #        max. VED
         ('m_free', c_float),      #        not yet used
         ('m_sdo', c_float * 3),   # [1092] upside stress range (outside)
         ('m_sdu', c_float * 3),   # [1092] downside stress range (inside)
         ('m_sdv', c_float),       # [1092] stirrup stress range
         ('m_sso', c_float * 3),   # [1092] maximum stell stress upside (outside)
         ('m_ssu', c_float * 3),   # [1092] maximum stell stress downside(inside)
         ('m_ssv', c_float),       # [1092] maximum stirrup stress (not yet used)
         ('m_sigbo', c_float),     # [1092] maximum concrete pressure upside (outside)
         ('m_sigbu', c_float),     # [1092] maximum concrete pressure downside(inside)
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress
         ('m_shzx', c_float),      #        max. skew principal tensile stress in local x
         ('m_shzy', c_float),      #        max. skew principal tensile stress in local y
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_asbend', c_float * 6),# [1021] Info reinforcement bending design only
         ('m_asplus', c_float * 6),# [1021] Info reinforcement if increased due to shear
         ('m_asposs', c_float * 6),# [1021] Info reinforcement to satisfy shear without stirrups
         ('m_bmom', c_float * 6),  # [1114] Design bending moment in direction of reinforcement
         ('m_origin', c_float * 7),#        bitpattern of origins of maximum reinforcements
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons
         ('m_wk6', c_float * 6),   # [1026] crack width  reinforcement
         ('m_reserved', c_float * 4), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of designcase
      ]
cquad_ric = CQUAD_RIC()

class CQUAD_REI(Structure):        # 260/DC:+  reinforcement in Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_aso', c_float),       # [1021] upside reinforcement (outside)
         ('m_asoq', c_float),      # [1021] upside cross reinforcement (middle)
         ('m_asu', c_float),       # [1021] downside reinforcement (outside)
         ('m_asuq', c_float),      # [1021] downside cross reinforcement (middle)
         ('m_asoi', c_float),      # [1021] upside third reinforcement (inside)
         ('m_asui', c_float),      # [1021] downside third reinforcement (inside)
         ('m_ass', c_float),       # [1022] stirrup cm2/m2
         ('m_asse', c_float),      # [1020] stirrup cm2
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_rio', c_float),       #        direction of upside reinforcement
         ('m_rioq', c_float),      #        direction of upside cross reinforcement
         ('m_riu', c_float),       #        direction of downside reinforcement
         ('m_riuq', c_float),      #        direction of downside cross reinforcement
         ('m_rioi', c_float),      #        direction of upside third reinforcement
         ('m_riui', c_float),      #        direction of downside third reinforcement
         ('m_zmin', c_float),      # [1001] minimum lever arm (ULS design)
         ('m_vedr', c_float),      #        max. VED/VRDMAX (ULS design)
         ('m_cott', c_float),      #        max. cot_theta (ULS design)
         ('m_ved', c_float),       #        max. VED (ULS design)
         ('m_vm', c_float),        # [1001] shift rule
         ('m_sdo', c_float * 3),   # [1092] upside stress range (outside)
         ('m_sdu', c_float * 3),   # [1092] downside stress range (inside)
         ('m_sdv', c_float),       # [1092] stirrup stress range
         ('m_sso', c_float * 3),   # [1092] maximum stell stress upside (outside)
         ('m_ssu', c_float * 3),   # [1092] maximum stell stress downside(inside)
         ('m_ssv', c_float),       # [1092] maximum stirrup stress (not yet used)
         ('m_sigbo', c_float),     # [1092] maximum concrete pressure upside (outside)
         ('m_sigbu', c_float),     # [1092] maximum concrete pressure downside(inside)
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress (SLS uncracked)
         ('m_shzx', c_float),      #        max. skew principal tensile stress in local x
         ('m_shzy', c_float),      #        max. skew principal tensile stress in local y
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_asbend', c_float * 6),# [1021] Info reinforcement bending design only (ULS design)
         ('m_asplus', c_float * 6),# [1021] Info reinforcement if increased due to shear (ULS design)
         ('m_asposs', c_float * 6),# [1021] Info reinforcement to satisfy shear without stirrups (ULS)
         ('m_bmom', c_float * 6),  # [1114] Design bending moment in direction of reinforcement
         ('m_origin', c_float * 7),#        origin of maximum reinforcement:
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons
         ('m_wk6', c_float * 6)    # [1026] crack width  reinforcement
      ]
cquad_rei = CQUAD_REI()

class CQUAD_NRC(Structure):        # 261/DC:0  maximum reinforcement in Quad-nodes
   _fields_ = [
         ('m_nr', c_int),          #        ident 0
         ('m_ng', c_int),          #        ident 0
         ('m_aso', c_float),       # [1021] upside reinforcement (outside)
         ('m_asoq', c_float),      # [1021] upside cross reinforcement (middle)
         ('m_asu', c_float),       # [1021] downside reinforcement (outside)
         ('m_asuq', c_float),      # [1021] downside cross reinforcement (middle)
         ('m_asoi', c_float),      # [1021] upside third reinforcement (inside)
         ('m_asui', c_float),      # [1021] downside third reinforcement (inside)
         ('m_ass', c_float),       # [1022] stirrup cm2/m2
         ('m_i_8', c_float),       #        reserved 0.0
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_free0', c_float * 6), #        not yet used
         ('m_zmin', c_float),      # [1001] minimum lever arm
         ('m_vedr', c_float),      #        max. VED/VRDMAX
         ('m_cott', c_float),      #        max. cot_theta
         ('m_ved', c_float),       #        max. VED
         ('m_free', c_float),      #        not yet used
         ('m_sdo', c_float * 3),   # [1092] upside stress range (outside)
         ('m_sdu', c_float * 3),   # [1092] downside stress range (inside)
         ('m_sdv', c_float),       # [1092] stirrup stress range
         ('m_sso', c_float * 3),   # [1092] maximum stell stress upside (outside)
         ('m_ssu', c_float * 3),   # [1092] maximum stell stress downside(inside)
         ('m_ssv', c_float),       # [1092] maximum stirrup stress (not yet used)
         ('m_sigbo', c_float),     # [1092] maximum concrete pressure upside (outside)
         ('m_sigbu', c_float),     # [1092] maximum concrete pressure downside(inside)
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress
         ('m_shzx', c_float),      #        max. skew principal tensile stress in local x
         ('m_shzy', c_float),      #        max. skew principal tensile stress in local y
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_asbend', c_float * 6),# [1021] Info reinforcement bending design only
         ('m_asplus', c_float * 6),# [1021] Info reinforcement if increased due to shear
         ('m_asposs', c_float * 6),# [1021] Info reinforcement to satisfy shear without stirrups
         ('m_bmom', c_float * 6),  # [1114] Design bending moment in direction of reinforcement
         ('m_origin', c_float * 7),#        bitpattern of origins of maximum reinforcements
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons
         ('m_wk6', c_float * 6),   # [1026] crack width  reinforcement
         ('m_reserved', c_float * 4), #        reserved for future usage
         ('m_text',  c_int * 17)   #        Designation of Designcase
      ]
cquad_nrc = CQUAD_NRC()

class CQUAD_NRI(Structure):        # 261/DC:Z+  reinforcement in Quad-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_aso', c_float),       # [1021] upside reinforcement (outside)
         ('m_asoq', c_float),      # [1021] upside cross reinforcement (middle)
         ('m_asu', c_float),       # [1021] downside reinforcement (outside)
         ('m_asuq', c_float),      # [1021] downside cross reinforcement (middle)
         ('m_asoi', c_float),      # [1021] upside third reinforcement (inside)
         ('m_asui', c_float),      # [1021] downside third reinforcement (inside)
         ('m_ass', c_float),       # [1022] stirrup cm2/m2
         ('m_i_8', c_float),       #        reserved 0.0
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_rio', c_float),       #        direction of upside reinforcement
         ('m_rioq', c_float),      #        direction of upside cross reinforcement
         ('m_riu', c_float),       #        direction of downside reinforcement
         ('m_riuq', c_float),      #        direction of downside cross reinforcement
         ('m_rioi', c_float),      #        direction of upside third reinforcement
         ('m_riui', c_float),      #        direction of downside third reinforcement
         ('m_zmin', c_float),      # [1001] minimum lever arm
         ('m_vedr', c_float),      #        max. VED/VRDMAX
         ('m_cott', c_float),      #        max. cot_theta
         ('m_ved', c_float),       #        max. VED
         ('m_free', c_float),      #        not yet used
         ('m_sdo', c_float * 3),   # [1092] upside stress range (outside)
         ('m_sdu', c_float * 3),   # [1092] downside stress range (inside)
         ('m_sdv', c_float),       # [1092] stirrup stress range
         ('m_sso', c_float * 3),   # [1092] maximum stell stress upside (outside)
         ('m_ssu', c_float * 3),   # [1092] maximum stell stress downside(inside)
         ('m_ssv', c_float),       # [1092] maximum stirrup stress (not yet used)
         ('m_sigbo', c_float),     # [1092] maximum concrete pressure upside (outside)
         ('m_sigbu', c_float),     # [1092] maximum concrete pressure downside(inside)
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress
         ('m_shzx', c_float),      #        max. skew principal tensile stress in local x
         ('m_shzy', c_float),      #        max. skew principal tensile stress in local y
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_asbend', c_float * 6),# [1021] Info reinforcement bending design only
         ('m_asplus', c_float * 6),# [1021] Info reinforcement if increased due to shear
         ('m_asposs', c_float * 6),# [1021] Info reinforcement to satisfy shear without stirrups
         ('m_bmom', c_float * 6),  # [1114] Design bending moment in direction of reinforcement
         ('m_origin', c_float * 7),#        origin of maximum reinforcement
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons
         ('m_wk6', c_float * 6)    # [1026] crack width  reinforcement
      ]
cquad_nri = CQUAD_NRI()

class CQUAD_NRP(Structure):        # 262/DC:+  punching reinforcement in nodes
   _fields_ = [
         ('m_nr', c_int),          #        nodenumber
         ('m_ista', c_int),        #        state of force
         ('m_idus', c_int),        #        punching state
         ('m_u0', c_float),        # [1001] effective length of first perimeter
         ('m_redo', c_float),      #        reduction factor for openings/free edges
         ('m_v', c_float),         # [1151] punching force
         ('m_asl', c_float),       # [1020] required longitudinal reinforcement
         ('m_asv1', c_float),      # [1022] shear reinforcement within 1st perimeter
         ('m_asv2', c_float),      # [1022] shear reinforcement within 2nd perimeter
         ('m_asv3', c_float),      # [1022] shear reinforcement within 3rd perimeter
         ('m_asv4', c_float),      # [1022] shear reinforcement within 4th perimeter
         ('m_free0', c_float * 5), #        not yet used
         ('m_txt1',  c_int * 16),  #        Halfen Description 1 (30 chars require n/2+1 words)
         ('m_txt2',  c_int * 16),  #        Halfen Description 2
         ('m_txt3',  c_int * 16)   #        Halfen Description 3
      ]
cquad_nrp = CQUAD_NRP()

class CQUAD_PUN(Structure):        # 262/DC:0  punching periphery
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_id', c_int),          #        identifier 0
         ('m_typ', c_int),         #        type of line
         ('m_x1', c_float),        # [1001] Coordinates of start point
         ('m_y1', c_float),        # [1001] 
         ('m_z1', c_float),        # [1001] 
         ('m_x2', c_float),        # [1001] Coordinates of end point
         ('m_y2', c_float),        # [1001] 
         ('m_z2', c_float)         # [1001] 
      ]
cquad_pun = CQUAD_PUN()

class CQUAD_PU1(Structure):        # 262/DC:0  punching parameters
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_id', c_int),          #        identifier 1
         ('m_kdust', c_int * 199), #        Integer-punching parameters
         ('m_rdust', c_float * 299)  #        Real-punching parameters
      ]
cquad_pu1 = CQUAD_PU1()

class CQUAD_RD0(Structure):        # 265/DC:0  maximum of tendon stresses in the design
   _fields_ = [
         ('m_nr', c_int),          #        identifier 0
         ('m_nrs', c_int),         #        identifier 0
         ('m_smax', c_float),      # [1092] maximum design stress
         ('m_smin', c_float),      # [1092] minimum design stress
         ('m_perm', c_float)       # [1092] permanent stress
      ]
cquad_rd0 = CQUAD_RD0()

class CQUAD_RTD(Structure):        # 265/DC  tendon stress in the design
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_nrs', c_int),         #        tendonnumber
         ('m_smax', c_float),      # [1092] maximum design stress
         ('m_smin', c_float),      # [1092] minimum design stress
         ('m_perm', c_float)       # [1092] permanent stress
      ]
cquad_rtd = CQUAD_RTD()

class CQUAD_REE(Structure):        # 270/DC:0  maximum design values in Quad-elements
   _fields_ = [
         ('m_ng', c_int),          #        ident 0
         ('m_nr', c_int),          #        ident 0
         ('m_id', c_int),          #        activated layers: -(nupper +100*nlower +10000*ncentric)
         ('m_orig', c_int),        #        origin - error messages:
         ('m_sigc', c_float * 2),  # [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
         ('m_sigcd', c_float * 2), # [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
         ('m_shz', c_float * 3),   # [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
         ('m_sigs', c_float * 3),  # [1092] maximum SLS reinforcement stress for center/upside/downside
         ('m_sigsd', c_float * 3), # [1092] maximum SLS reinforcement stress range for center/upside/downsi
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons upside/downsid
         ('m_zmin', c_float),      # [1001] minimum lever arm (ULS design)
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_ass', c_float),       # [1022] stirrup reinforcement ratio
         ('m_vedr', c_float),      #        max. VED/VRDMAX (ULS design)
         ('m_cott', c_float),      #        max. cot_theta (ULS design)
         ('m_ved', c_float),       #        max. VED (ULS design)
         ('m_vm', c_float),        # [1001] shift rule
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_opt', c_float * 15),  #        reserved
         ('m_sumo', c_float),      # [1030] upside reinforcement quantity
         ('m_sumu', c_float),      # [1030] downside reinforcement quantity
         ('m_summ', c_float),      # [1030] centric reinforcement quantity
         ('m_sums', c_float),      # [1030] shear reinforcement quantity
         ('m_text',  c_int * 17)   #        Designation of designcase
      ]
cquad_ree = CQUAD_REE()

class CQUAD_RNE(Structure):        # 271/DC:0  maximum design values in Nodes of Quad-elements
   _fields_ = [
         ('m_ng', c_int),          #        ident 0
         ('m_nr', c_int),          #        ident 0
         ('m_id', c_int),          #        activated layers: -(nupper +100*nlower +10000*ncentric)
         ('m_orig', c_int),        #        origin - error messages:
         ('m_sigc', c_float * 2),  # [1092] maximum SLS concrete pressure upside (Z-) and downside (Z+)
         ('m_sigcd', c_float * 2), # [1092] maximum SLS concrete stress range upside (Z-) and downside (Z+)
         ('m_shz', c_float * 3),   # [1092] maximum SLS tensile stress skew/x/y principal (SLS uncracked)
         ('m_sigs', c_float * 3),  # [1092] maximum SLS reinforcement stress for center/upside/downside
         ('m_sigsd', c_float * 3), # [1092] maximum SLS reinforcement stress range for center/upside/downsi
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons upside/downsid
         ('m_zmin', c_float),      # [1001] minimum lever arm (ULS design)
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_ass', c_float),       # [1022] stirrup reinforcement ratio
         ('m_vedr', c_float),      #        max. VED/VRDMAX (ULS design)
         ('m_cott', c_float),      #        max. cot_theta (ULS design)
         ('m_ved', c_float),       #        max. VED (ULS design)
         ('m_vm', c_float),        # [1001] shift rule
         ('m_utilc', c_float),     #        max. utilization fatigue check concrete
         ('m_opt', c_float * 15),  #        reserved
         ('m_sumo', c_float),      # [1030] upside reinforcement quantity
         ('m_sumu', c_float),      # [1030] downside reinforcement quantity
         ('m_summ', c_float),      # [1030] centric reinforcement quantity
         ('m_sums', c_float),      # [1030] shear reinforcement quantity
         ('m_text',  c_int * 17)   #        Designation of designcase
      ]
cquad_rne = CQUAD_RNE()

class CQUAD_REM(Structure):        # 270/DC:0  maximum reinforcement results in Quad-elements
   _fields_ = [
         ('m_ng', c_int),          #        ident 0
         ('m_nr', c_int),          #        ident 0
         ('m_id', c_int),          #        +1 identifier for reincorcement
         ('m_orig', c_int),        #        origin of maximum reinforcement, see QUAD_REA for Details
         ('m_aso', c_float),       # [1021] reinforcement area
         ('m_sdo', c_float * 3),   # [1092] reinforcement stress SLS
         ('m_asbend', c_float),    # [1021] Info reinforcement bending design only (ULS design)
         ('m_asplus', c_float),    # [1021] Info reinforcement if increased due to shear (ULS design)
         ('m_asposs', c_float),    # [1021] Info reinforcement to satisfy shear without stirrups (ULS)
         ('m_bmom', c_float),      # [1114] Design bending moment in direction of reinforcement
         ('m_wk', c_float)         # [1026] crack width
      ]
cquad_rem = CQUAD_REM()

class CQUAD_REA(Structure):        # 270/DC:z+  General Concrete Design Results
   _fields_ = [
         ('m_ng', c_int),          #        group number (for nodal results)
         ('m_nr', c_int),          #        element number
         ('m_id', c_int),          #        ident 0 : concrete results
         ('m_orig', c_int),        #        origin of maximum reinforcement:
         ('m_sigo', c_float * 3),  # [1092] stress of concrete pressure upside (Z-)
         ('m_sigu', c_float * 3),  # [1092] stress of concrete pressure downside (Z+)
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress (SLS uncracked)
         ('m_shzx', c_float),      #        max. skew principal tensile stress in local x
         ('m_shzy', c_float),      #        max. skew principal tensile stress in local y
         ('m_zmin', c_float),      # [1001] minimum lever arm (ULS design)
         ('m_deco', c_float * 2),  # [   9] decompression strain in the direction of tendons
         ('m_sumo', c_float),      # [1021] upside reinforcement quantity
         ('m_sumu', c_float),      # [1021] downside reinforcement quantity
         ('m_summ', c_float),      # [1021] shear reinforcement quantity
         ('m_tau0', c_float),      # [1092] design shear stress (shear force)
         ('m_ass', c_float),       # [1022] stirrup reinforcement ratio
         ('m_vedr', c_float),      #        max. VED/VRDMAX (ULS design)
         ('m_cott', c_float),      #        max. cot_theta (ULS design)
         ('m_ved', c_float),       #        max. VED (ULS design)
         ('m_vm', c_float),        # [1001] shift rule
         ('m_utilc', c_float)      #        max. utilization fatigue check concrete
      ]
cquad_rea = CQUAD_REA()

class CQUAD_RER(Structure):        # 270/DC:z+  Reinforcement Layer Design Results
   _fields_ = [
         ('m_ng', c_int),          #        group number (for nodal results)
         ('m_nr', c_int),          #        element number
         ('m_id', c_int),          #        identifier of reincorcement layer
         ('m_orig', c_int),        #        origin of maximum reinforcement, see QUAD_REA for Details
         ('m_aso', c_float),       # [1021] reinforcement area
         ('m_sdo', c_float * 3),   # [1092] reinforcement stress SLS
         ('m_asbend', c_float),    # [1021] Info reinforcement bending design only (ULS design)
         ('m_asplus', c_float),    # [1021] Info reinforcement if increased due to shear (ULS design)
         ('m_asposs', c_float),    # [1021] Info reinforcement to satisfy shear without stirrups (ULS)
         ('m_bmom', c_float),      # [1114] Design bending moment in direction of reinforcement
         ('m_wk', c_float)         # [1026] crack width
      ]
cquad_rer = CQUAD_RER()

class CQUAD_CFD(Structure):        # 290/LC  Fluid flow results in Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_vx', c_float),        # [1212] velocity
         ('m_vy', c_float),        # [1212] velocity
         ('m_vz', c_float),        # [1212] velocity
         ('m_q', c_float),         # [1211] stream quantity
         ('m_hopt', c_float),      # [1001] Boundary layer
         ('m_vxa', c_float),       # [1212] particle velocity
         ('m_vya', c_float),       # [1212] particle velocity
         ('m_vza', c_float),       # [1212] particle velocity
         ('m_mued', c_float),      # [1220] laminar viscosity
         ('m_dux', c_float * 2),   # [  95] gradient values of fluid flow du/dx, du/dy
         ('m_dvx', c_float * 2),   # [  95] gradient values of fluid flow dv/dx, dv/dy
         ('m_tk', c_float),        # [1222] turbulent energy
         ('m_muet', c_float),      # [1220] turbulent viscosity
         ('m_ed', c_float),        # [1223] dissipation rate
         ('m_scalar', c_float * 4) #        optional scalar values
      ]
cquad_cfd = CQUAD_CFD()

class CQUAD_TM(Structure):         # 291/LC:0  Maximum of Temperature Results in Quads
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_qx', c_float),        # [1218] heat flux
         ('m_qy', c_float),        # [1218] heat flux
         ('m_qz', c_float),        # [1218] heat flux
         ('m_q', c_float),         # [1216] Total flux
         ('m_hopt', c_float),      # [1001] optimal mesh size
         ('m_teff', c_float),      # [  92] Effective Age
         ('m_hydr', c_float),      #        Hydration degree
         ('m_lfr', c_float)        #        Liquid fraction
      ]
cquad_tm = CQUAD_TM()

class CQUAD_TMP(Structure):        # 291/LC  Temperature Results in Quad-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_qx', c_float),        # [1218] heat flux
         ('m_qy', c_float),        # [1218] heat flux
         ('m_qz', c_float),        # [1218] heat flux
         ('m_q', c_float),         # [1216] Total flux
         ('m_hopt', c_float),      # [1001] optimal mesh size
         ('m_teff', c_float * 5),  # [  92] Effective Age
         ('m_hydr', c_float * 5),  #        Hydratation degree
         ('m_lfr', c_float * 5)    #        Liquid fraction
      ]
cquad_tmp = CQUAD_TMP()

class CBRIC(Structure):            # 300/00  Bric-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_node', c_int * 8),    #        nodenumbers
         ('m_mat', c_int),         #        materialnumber
         ('m_nra', c_int),         #        type of element
         ('m_det', c_float * 4)    #        Values of Jacobian Determinant / Volume
      ]
cbric = CBRIC()

class CBRIC_SU(Structure):         # 300/02:0  Surfaces and Neighbours of Bric-elements
   _fields_ = [
         ('m_n0', c_int * 4),
         ('m_nsur', c_int),
         ('m_mbri', c_int)         #        max number of brics per surface
      ]
cbric_su = CBRIC_SU()

class CBRIC_SUR(Structure):        # 300/02:+  Surfaces and Neighbours of Bric-elements
   _fields_ = [
         ('m_node', c_int * 4),
         ('m_ijmp', c_int),
         ('m_nbri', c_int),
         ('m_nrel', c_int * 7)     #        bric numbers for this surface
      ]
cbric_sur = CBRIC_SUR()

class CBRIC_RIM(Structure):        # 300/6  Prescribed Reinforcements of Bric-elements
   _fields_ = [
         ('m_nrg', c_int),         #        group number
         ('m_nr', c_int),          #        selector number
         ('m_typ', c_int),         #        Type of Reinforc.
         ('m_gtyp', c_int),        #        Type of grading
         ('m_idra', c_int),        #        drawing source type
         ('m_oal', c_float),       #        Euler Angle I reinforcement
         ('m_oaf', c_float),       #        Euler Angle II
         ('m_xref', c_float),      # [1001] Reference point for circular reinforcement
         ('m_yref', c_float),      # [1001] XREF+YREF allowed in combination with OAL and OAF
         ('m_zref', c_float),      # [1001] ZREF<>RW only allowed for OAL=OAF=0
         ('m_di', c_float * 3),    # [1023] Diameter of reinforcement 1-3
         ('m_as', c_float * 3),    # [1022] Minimum reinforcement 1-3
         ('m_am', c_float * 3),    # [1022] Maximum reinforcement 1-3
         ('m_wk', c_float * 3),    # [1026] design crack width
         ('m_sig', c_float * 3)    # [1092] SLS steel stress limit
      ]
cbric_rim = CBRIC_RIM()

class CBRIC_P(Structure):          # 300/10  Bric-P-Elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_node', c_int * 8),    #        nodenumbers
         ('m_mat', c_int),         #        materialnumber
         ('m_edge', c_int * 12),   #        geometric id of edge 1-2
         ('m_face', c_int * 6)     #        geometric id of face 1-2-3-4
      ]
cbric_p = CBRIC_P()

class CBRIC_LOA(Structure):        # 302/LC  loads of Bric-elements
   _fields_ = [
         ('m_von', c_int),         #        start elementnumber
         ('m_bis', c_int),         #        end elementnumber
         ('m_del', c_int),         #        increment
         ('m_typ', c_int),         #        type of load
         ('m_lnr', c_int),         #        primary loadcasenumber,if TYP = 18/30
         ('m_p', c_float),         #        load value
         ('m_dpdx', c_float),
         ('m_dpdy', c_float),
         ('m_dpdz', c_float),
         ('m_xref', c_float),      # [1001] optional reference point for load value
         ('m_yref', c_float),      # [1001] 
         ('m_zref', c_float)       # [1001] 
      ]
cbric_loa = CBRIC_LOA()

class CBRIC_STC(Structure):        # 310/LC:0  maximum stress in BRICs
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float),      # [1092] shear stress
         ('m_hp1', c_float),       #        yield function
         ('m_hp2', c_float)        #        volum. hardening
      ]
cbric_stc = CBRIC_STC()

class CBRIC_STR_SG(Structure):     #        results in GAUSS-points
   _fields_ = [
         ('m_sigx', c_float),      # [1092] 
         ('m_sigy', c_float),      # [1092] 
         ('m_sigz', c_float),      # [1092] 
         ('m_tvxy', c_float),      # [1092] 
         ('m_tvxz', c_float),      # [1092] 
         ('m_tvyz', c_float)       # [1092] 
      ]
cbric_str_sg = CBRIC_STR_SG()

class CBRIC_STR(Structure):        # 310/LC:+  3D-stresses in Bric-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float),      # [1092] shear stress
         ('m_sg',  CBRIC_STR_SG * 8), #        results in GAUSS-points
         ('m_hp1', c_float * 9),   #        yield function
         ('m_hp2', c_float * 9),   #        2nd parameter as specified in headder record
         ('m_hp3', c_float * 9),   #        3rd parameter as specified in headder record
         ('m_hp4', c_float * 9),   #        4th parameter as specified in headder record
         ('m_hp5', c_float * 9),   #        5th parameter as specified in headder record
         ('m_hp6', c_float * 9),   #        6th parameter as specified in headder record
         ('m_hp7', c_float * 9),   #        7th parameter as specified in headder record
         ('m_hp8', c_float * 9),   #        8th parameter as specified in headder record
         ('m_hp9', c_float * 9),   #        9th parameter as specified in headder record
         ('m_hp10', c_float * 9),  #        10th parameter as specified in headder record
         ('m_hp11', c_float * 9),  #        11th parameter as specified in headder record
         ('m_hp12', c_float * 9),  #        12th parameter as specified in headder record
         ('m_hp13', c_float * 9),  #        13th parameter as specified in headder record
         ('m_hp14', c_float * 9),  #        14th parameter as specified in headder record
         ('m_hp15', c_float * 9)   #        15th parameter as specified in headder record
      ]
cbric_str = CBRIC_STR()

class CBRIC_NSC(Structure):        # 311/LC:0  maximum nodal 3D stress
   _fields_ = [
         ('m_ng', c_int),          #        ident 0 for maximum (first records)
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float)       # [1092] shear stress
      ]
cbric_nsc = CBRIC_NSC()

class CBRIC_NST(Structure):        # 311/LC:+  3D-stresses in Bric-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float),      # [1092] shear stress
         ('m_fy', c_float)         #        yield function
      ]
cbric_nst = CBRIC_NST()

class CBRIC_ESC(Structure):        # 312/LC:0  max. errors of Bric-stresses
   _fields_ = [
         ('m_nr', c_int),          #        ident 0 for maximum (first records)
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float)       # [1092] shear stress
      ]
cbric_esc = CBRIC_ESC()

class CBRIC_EST(Structure):        # 312/LC:+  3D-error estimates in Bric-Elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_sigx', c_float),      # [1092] stress
         ('m_sigy', c_float),      # [1092] stress
         ('m_sigz', c_float),      # [1092] stress
         ('m_tvxy', c_float),      # [1092] shear stress
         ('m_tvxz', c_float),      # [1092] shear stress
         ('m_tvyz', c_float)       # [1092] shear stress
      ]
cbric_est = CBRIC_EST()

class CBRIC_REI(Structure):        # 360/DC:+  reinforcement in Bric-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_as', c_float * 3),    # [1022] reinforcement 1-3
         ('m_oal', c_float),       #        Euler Angle I
         ('m_oaf', c_float),       #        Euler Angle II
         ('m_sd', c_float * 3),    # [1092] stress range 1-3
         ('m_sigb', c_float),      # [1092] maximum concrete pressure
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress (SLS uncracked)
         ('m_origin', c_float * 3) #        origin of maximum reinforcement: as defined in 260/DC
      ]
cbric_rei = CBRIC_REI()

class CBRIC_NRI(Structure):        # 361/DC:+  reinforcement in Bric-nodes
   _fields_ = [
         ('m_ng', c_int),          #        groupnumber
         ('m_nr', c_int),          #        nodenumber
         ('m_as', c_float * 3),    # [1022] reinforcement 1-3
         ('m_oal', c_float),       #        Euler Angle I
         ('m_oaf', c_float),       #        Euler Angle II
         ('m_sd', c_float * 3),    # [1092] stress range 1-3
         ('m_sigb', c_float),      # [1092] maximum concrete pressure
         ('m_shzmax', c_float),    #        maximum skew principal tensile stress (SLS uncracked)
         ('m_origin', c_float * 3) #        origin of maximum reinforcement: as defined in 260/DC
      ]
cbric_nri = CBRIC_NRI()

class CBRIC_CFD(Structure):        # 390/LC  Fluid flow results in BRIC-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_vx', c_float),        # [1212] velocity
         ('m_vy', c_float),        # [1212] velocity
         ('m_vz', c_float),        # [1212] velocity
         ('m_q', c_float),         # [1211] stream quantity
         ('m_hopt', c_float),      # [1001] optimal mesh size
         ('m_vxa', c_float),       # [1212] particle velocity
         ('m_vya', c_float),       # [1212] particle velocity
         ('m_vza', c_float),       # [1212] particle velocity
         ('m_mued', c_float),      # [1220] laminar viscosity
         ('m_dux', c_float * 3),   # [  95] gradient values fluid flow du/dx, du/dy, du/dz
         ('m_dvx', c_float * 3),   # [  95] gradient values fluid flow dv/dx, dv/dy, dv/dz
         ('m_dwx', c_float * 3),   # [  95] gradient values fluid flow dw/dx, dw/dy, dw/dz
         ('m_tk', c_float),        # [1222] turbulent energy
         ('m_muet', c_float),      # [1220] turbulent viscosity
         ('m_ed', c_float),        # [1223] dissipation rate
         ('m_scalar', c_float * 4) #        optional scalar parameters
      ]
cbric_cfd = CBRIC_CFD()

class CBRIC_TM(Structure):         # 391/LC:0  Maximum Temperature Results in BRICs
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_qx', c_float),        # [1218] heat flux
         ('m_qy', c_float),        # [1218] heat flux
         ('m_qz', c_float),        # [1218] heat flux
         ('m_q', c_float),         # [1216] Total flux
         ('m_teff', c_float),      # [  92] Effective Age
         ('m_hydr', c_float),      #        Hydration degree
         ('m_lfr', c_float)        #        Liquid fraction
      ]
cbric_tm = CBRIC_TM()

class CBRIC_TMP(Structure):        # 391/LC  Temperature Results in BRIC-elements
   _fields_ = [
         ('m_nr', c_int),          #        elementnumber
         ('m_qx', c_float),        # [1218] heat flux
         ('m_qy', c_float),        # [1218] heat flux
         ('m_qz', c_float),        # [1218] heat flux
         ('m_q', c_float),         # [1216] Total flux
         ('m_teff', c_float * 9),  # [  92] Effective Age
         ('m_hydr', c_float * 9),  #        Hydration degree
         ('m_lfr', c_float * 9)    #        Liquid fraction
      ]
cbric_tmp = CBRIC_TMP()

class CHASE_PIH(Structure):        # 404/NR:0  HASE-Piles in Half-space
   _fields_ = [
         ('m_id', c_int),          #        Identification 0
         ('m_npile', c_int),       #        Number of piles
         ('m_mpile', c_int),       #        Max. values per pile
         ('m_nhknot', c_int)       #        Number of nodes
      ]
chase_pih = CHASE_PIH()

class CHASE_PIL(Structure):        # 404/NR:+  HASE-Piles in Half-space
   _fields_ = [
         ('m_enr', c_int),         #        External node number
         ('m_x', c_float),         # [1001] Pile X-coordinate
         ('m_y', c_float),         # [1001] Pile Y-coordinate
         ('m_df', c_float),        # [1001] Pile-foot diameter
         ('m_z', c_float),         # [1001] Pile-foot coordinate
         ('m_mant', c_float),      #        Fraction of the total pile load transfered as a pile
         ('m_pmam', c_float),      # [1190] Max. load transferable by skin friction
         ('m_inr', c_int),         #        Ixternal node number
         ('m_bez', c_int * 4),     #        Designation
         ('m_pmaf', c_float),      # [1190] Max. load transferable trough pile-foot
         ('m_zman', c_float),      # [1001] Z-coordiante from which the skin friction is active
         ('m_cfac', c_float),      #        Factor of load applied as compression-only
         ('m_plen', c_float),      # [1001] Pile length
         ('m_plsf', c_float),      # [1001] Pile length part inactive for skin friction
         ('m_d0', c_float),        # [1001] Pile diameter
         ('m_mnr', c_float)        #        Pile material number
      ]
chase_pil = CHASE_PIL()

class CSEG_DEF(Structure):         # 900/00  Segmentdefinition
   _fields_ = [
         ('m_id', c_int),          #        Identification of segment
         ('m_typ', c_int),         #        Type of segment
         ('m_bit', c_int),         #        Bitpattern idef+4*iref
         ('m_len', c_float),       # [1001] Length of segment
         ('m_alfa', c_float),      # [   5] Angle of start face to axis (0 = match-cast)
         ('m_alfr', c_float),      # [   5] Angle of end   face to axis (0 = match-cast)
         ('m_dspa', c_float),      # [1001] Distance of start survey point
         ('m_dspe', c_float),      # [1001] Distance of end survey point
         ('m_text',  c_int * 17)   #        designation of segment
      ]
cseg_def = CSEG_DEF()

class CIL_CTRL0(Structure):        # -1/NS:0  Headder of a location
   _fields_ = [
         ('m_id', c_int),          #        ID=0
         ('m_kwerg', c_int),       #        KWH for results to be saved
         ('m_nerg', c_int),        #        Count on corresponding items
         ('m_nrel', c_int),        #        element number
         ('m_xabs', c_float),      # [1001] abszissae for beam sections
         ('m_txt',  c_int * 17)    #        Name of location
      ]
cil_ctrl0 = CIL_CTRL0()

class CIL_CTRL1(Structure):        # -1/NS:?  Headder of a result
   _fields_ = [
         ('m_idi', c_int),         #        Type of result
         ('m_ierg', c_int),        #        index of this item + 1000*IMUNIT
         ('m_lfmax', c_int),       #        Offset for load case number of results for maximum
         ('m_lfmin', c_int),       #        Offset for load case number of results for minimum
         ('m_lphi', c_float),      # [1001] characteristic lenght for dynamic impact factor
         ('m_txt',  c_int * 17)    #        Name of item
      ]
cil_ctrl1 = CIL_CTRL1()

class CIL_DATA0(Structure):        # -1/NS:1????  Influence values (V23, obsoleted)
   _fields_ = [
         ('m_idi', c_int),         #        Type of derivatives defined
         ('m_x', c_float),         # [1001] abszissae along lane
         ('m_pv', c_float),        #        Influence value for vertical loading (z)
         ('m_mt', c_float),        #        Influence value for torsional loading (x-x)
         ('m_pl', c_float),        #        Influence value for longitudinal loading (x)
         ('m_pt', c_float),        #        Influence value for transverse loading (y)
         ('m_dpv', c_float),       #        Derivative of PV/dx (if IDI&1000)
         ('m_dmt', c_float),       #        Derivative of MT/dx (if IDI&0100)
         ('m_dpl', c_float),       #        Derivative of PL/dx (if IDI&0010)
         ('m_dpt', c_float)        #        Derivative of PT/dx (if IDI&0001)
      ]
cil_data0 = CIL_DATA0()

class CIL_DATA(Structure):         # -1/NS:1??????  Influence values
   _fields_ = [
         ('m_idi', c_int),         #        Type of derivatives defined
         ('m_x', c_float),         # [1001] abszissae along lane
         ('m_pv', c_float),        #        Influence value for vertical loading (z)
         ('m_mt', c_float),        #        Influence value for torsional loading (x-x)
         ('m_pl', c_float),        #        Influence value for longitudinal loading (x)
         ('m_pt', c_float),        #        Influence value for transverse loading (y)
         ('m_ppos', c_float),      #        Influence value for vertical distributed loading
         ('m_pneg', c_float),      #        Influence value for vertical distributed loading
         ('m_dpv', c_float),       #        Derivative of PV/dx   (if IDI&100000)
         ('m_dmt', c_float),       #        Derivative of MT/dx   (if IDI&010000)
         ('m_dpl', c_float),       #        Derivative of PL/dx   (if IDI&001000)
         ('m_dpt', c_float),       #        Derivative of PT/dx   (if IDI&000100)
         ('m_dppos', c_float),     #        Derivative of PPOS/dx (if IDI&000010)
         ('m_dpneg', c_float),     #        Derivative of PNEG/dx (if IDI&000001)
         ('m_rres', c_float),      #        Influence value for right residual loading
         ('m_lres', c_float)       #        Influence value for left residual loading
      ]
cil_data = CIL_DATA()

#+============================================================================
#| Company:   SOFiSTiK AG 
#|      sofistik_daten.py
#|      end of automatically generated header
#+============================================================================


