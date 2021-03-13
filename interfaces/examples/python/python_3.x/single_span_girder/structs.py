#+============================================================================+
#| Company:   SOFiSTiK AG                                                     |
#| Version:   SOFiSTIK 2018                                                   |
#+============================================================================+

from ctypes import *


class MAT_STEE(Structure):                  #  1/NR:1  MaterialSteel
    _fields_ = \
        [
            ('m_id', c_int),                #        Identification
            ("m_type", c_int),              #        Material type
            ("m_class", c_int),             #        Classification
            ("m_emod", c_float),            # [1090] Elasticity Modulus
            ("m_mue", c_float),             #        Poissons ratio
            ("m_gmod", c_float),            # [1090] Shear modulus
            ("m_kmod", c_float),            # [1090] Compression modulus
            ("m_gam", c_float),             # [1091] dead weight
            ("m_rho", c_float),             # [ 159] Density
            ("m_alfa", c_float),            # [ 107] Temperature Elongation coefficient
            ("m_e90", c_float),             # [1090] Elasticity modulus perpendicular
            ("m_mue90", c_float),           #        Poissons ratio perpendicular
            ("m_alf", c_float),             # [   5] Euler Angle I
            ("m_bet", c_float),             # [   5] Euler Angle II
            ("m_scm", c_float),             #        Material safety
            ("m_fy", c_float),              # [1092] yield stress
            ("m_ft", c_float),              # [1092] tensile strength
            ("m_eps", c_float),             # [   9] limit strain
            ("m_rel1", c_float),            #        Relaxation 0.55fpk
            ("m_rel2", c_float),            #        Relaxation 0.70fpk or 0.70fp=rho-1000 for ENC?
            ("m_r", c_float),               #        bond coefficient
            ("m_k1", c_float),              #        bondfactor EC2
            ("m_eh", c_float),              # [1090] Hardening module
            ("m_fe", c_float),              # [1092] Proportional stress
            ("m_epse", c_float),            # [   9] Plastic strain
            ("m_fdyn", c_float),            # [1092] Dynamic strength
            ("m_fyc", c_float),             # [1092] compr. yield stress
            ("m_ftc", c_float),             # [1092] compress. strength
            ("m_tmax", c_float),            # [  16] max.plate thickness
            ("m_bc", c_float),              #        (eg. Aluminium 1.0/2.0 = "A","B" )
            ("m_dummy", c_float * 2),       #
            ("m_scms", c_float),            #        Material safety
            ("m_scmu", c_float),            #        Material safety
            ("m_scmc", c_float),            #        Material safety
        ]
mat_stee = MAT_STEE()


class MAT_CONC(Structure):                  # 1/NR:1  MaterialConcrete
    _fields_ = \
        [
            ('m_id', c_int),                #        Identification
            ("m_type", c_int),              #        Material type
            ("m_class", c_int),             #        Classification
            ("m_emod", c_float),            # [1090] Elasticity Modulus
            ("m_mue", c_float),             #        Poissons ratio
            ("m_gmod", c_float),            # [1090] Shear modulus
            ("m_kmod", c_float),            # [1090] Compression modulus
            ("m_gam", c_float),             # [1091] Dead weight
            ("m_rho", c_float),             # [ 159] Density
            ("m_alfa", c_float),            # [ 107] Temperature Elongation coefficient
            ("m_e90", c_float),             # [1090] Elasticity modulus perpendicular
            ("m_mue90", c_float),           #        Poissons ratio perpendicular
            ("m_alf", c_float),             # [   5] Euler Angle I
            ("m_bet", c_float),             # [   5] Euler Angle II
            ("m_scm", c_float),             #        Material safety
            ("m_fc", c_float),              # [1092] effective strength
            ("m_fck", c_float),             # [1092] nominal strength
            ("m_ftm", c_float),             # [1092] mean value of tensional strength
            ("m_ftl", c_float),             # [1092] mean value of tensional strength
            ("m_ftk", c_float),             # [1092] lower fractile of tensional strength
            ("m_ec", c_float),              # [1092] upper fractile of tensional strength
            ("m_et", c_float),              #        compr. failure Energy (deprecated)
            ("m_muer", c_float),            # [ 112] tensile failure energy
            ("m_fcm", c_float),             #        friction in the crack
            ("m_rdcl", c_float),            # [1092] mean value of strength
            ("m_fcr", c_float),             #        weight class
            ("m_ecr", c_float),             # [1092] calculatoric mean value of strength
            ("m_fbd", c_float),             # [1090] Elasticity modul for worklaw CE
            ("m_ftd", c_float),             # [1092] bond strength (EC2 Table. 5.1.3)
            ("m_feqr", c_float),            # [1092] Initial tensile strength Bemessungszugfestigkeit
            ("m_feqt", c_float),            # [1092] Tensile strength after cracking Zugfestigkeit nach Rissbildung
            ("m_fcfat", c_float),           # [1092] Residual tensile strength  Restzugfestigkeit im Bruch
            ("m_scms", c_float),            # [1092] Fatigue Strength
            ("m_scmu", c_float),            #        Material safety
            ("m_scmc", c_float),            #        Material safety
        ]
mat_conc = MAT_CONC()


class SECT_REC(Structure):                  # 9/NR:10  Section type Rectangular T-Beam
    _fields_ = \
        [
            ('m_id', c_int),                #        Identification = 10
            ("m_iq", c_int),                #        Identification of section
            ("m_ir", c_int),                #        Identification of reinforcement and origin
            ("m_h", c_float),               # [1011] total height
            ("m_b", c_float),               # [1011] width (of web)
            ("m_so", c_float),              # [1024] Boundary distance of upper reinforcement
            ("m_su", c_float),              # [1024] Boundary distance of lower reinforcement
            ("m_aso", c_float),             # [1020] reinforcement up
            ("m_asu", c_float),             # [1020] reinforcement down
            ("m_ho", c_float),              # [1011] height of plate
            ("m_bo", c_float),              # [1011] width  of plate
            ("m_daso", c_float),            # [1023] reinf. Diameter up
            ("m_dasu", c_float),            # [1023] reinf. Diameter dn
            ("m_fkit", c_float),            #        <0 = factor for torsional inertia >0 = absolute value of torsion
            ("m_fkay", c_float),            #        <0 = factor for shear deformation area >0 = absolute value of sh
            ("m_fkaz", c_float),            #        <0 = factor for shear deformation area >0 = absolute value of sh
            ("m_ysmp", c_float),            # [1011] explicit location of shear center
            ("m_zssmp", c_float),           # [1011] explicit location of shear center
            ("m_ys", c_float),              # [1011] explicit location of reference point
            ("m_zs", c_float),              # [1011] explicit location of reference point
            ("m_phib", c_float),            # [   5] inclination of shear links
            ("m_beff", c_float),            # [1011] width of equivalent hollow section
            ("m_asbm", c_float),            # [1022] Minimum shear reinf.
            ("m_a", c_float),               # [1011] spacing of reinforcements
            ("m_amin", c_float),            # [1011] minimum distance of single reinforcements
            ("m_amax", c_float),            # [1011] maximum distance of single reinforcements
            ("m_ss", c_float),              # [1024] Boundary distance of lateral reinforcement
            ("m_dass", c_float),            # [1023] reinf. Diameter side
            ("m_hmax", c_float),            # [1011] maximum mesh size for FE/fibre analysis
        ]
sect_rec = SECT_REC()


class BEAM_FOC(Structure):                  # 102/LC:0  Maximum of Total Beam forces and deformations
    _fields_ = \
        [
            ('m_id', c_int),                #        identifier 0
            ("m_x", c_float),               # [1001] max. beam length
            ("m_n", c_float),               # [1101] normal force
            ("m_vy", c_float),              # [1102] y-shear force
            ("m_vz", c_float),              # [1102] z-shear force
            ("m_mt", c_float),              # [1103] torsional moment
            ("m_my", c_float),              # [1104] bending moment My
            ("m_mz", c_float),              # [1104] bending moment Mz
            ("m_mb", c_float),              # [1105] warping moment Mb
            ("m_mt2", c_float),             # [1103] 2nd torsional moment
            ("m_ux", c_float),              # [1003] displacement local x
            ("m_uy", c_float),              # [1003] displacement local y
            ("m_uz", c_float),              # [1003] displacement local z
            ("m_phix", c_float),            # [1004] rotation local x
            ("m_phiy", c_float),            # [1004] rotation local y
            ("m_phiz", c_float),            # [1004] rotation local z
            ("m_phiw", c_float),            # [1005] twisting
            ("m_mt3", c_float),             # [1103] 3rd torsional moment
            ("m_pa", c_float),              # [1095] axial bedding
            ("m_pt", c_float),              # [1095] transverse bedding
            ("m_pty", c_float),             # [1095] local y component of transverse bedding
            ("m_ptz", c_float),             # [1095] local z component of transverse bedding
        ]
beam_foc = BEAM_FOC()
