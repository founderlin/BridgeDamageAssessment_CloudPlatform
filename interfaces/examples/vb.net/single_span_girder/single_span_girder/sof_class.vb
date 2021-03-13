'+============================================================================+
'| Company:   SOFiSTiK AG                                                     |
'| Version:   SOFiSTIK 2018                                                   |
'+============================================================================+

Public Class Cc_node
    ' Here the sof_cdb_get function is declared for the CNODE structure
    ' Instead of using classes, pointers can also be used (this approach is not used in this example
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer,
                                                                                      ByVal kwh As Integer,
                                                                                      ByVal kwl As Integer,
                                                                                      ByRef data As CNODE,
                                                                                      ByRef datalen As Integer,
                                                                                      ByVal pos As Integer) As Integer
End Class

Public Class Cc_mat_conc
    ' Here the sof_cdb_get function is declared for the CMAT_CONC structure
    ' Instead of using classes, pointers can also be used (this approach is not used in this example
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer,
                                                                                      ByVal kwh As Integer,
                                                                                      ByVal kwl As Integer,
                                                                                      ByRef data As CMAT_CONC,
                                                                                      ByRef datalen As Integer,
                                                                                      ByVal pos As Integer) As Integer
End Class

Public Class Cc_mat_stee
    ' Here the sof_cdb_get function is declared for the CMAT_STEE structure
    ' Instead of using classes, pointers can also be used (this approach is not used in this example
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer,
                                                                                      ByVal kwh As Integer,
                                                                                      ByVal kwl As Integer,
                                                                                      ByRef data As CMAT_STEE,
                                                                                      ByRef datalen As Integer,
                                                                                      ByVal pos As Integer) As Integer
End Class

Public Class Cc_beam_foc
    ' Here the sof_cdb_get function is declared for the CBEAM_FOC structure
    ' Instead of using classes, pointers can also be used (this approach is not used in this example
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer, ByVal kwh As Integer, ByVal kwl As Integer, ByRef data As CBEAM_FOC, ByRef datalen As Integer, ByVal pos As Integer) As Integer
End Class

Public Class Cc_sect_rec
    ' Here the sof_cdb_get function is declared for the CSECT_REC structure
    ' Instead of using classes, pointers can also be used (this approach is not used in this example
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer,
                                                                                      ByVal kwh As Integer,
                                                                                      ByVal kwl As Integer,
                                                                                      ByRef data As CSECT_REC,
                                                                                      ByRef datalen As Integer,
                                                                                      ByVal pos As Integer) As Integer
End Class
