'+============================================================================+
'| Company:   SOFiSTiK AG                                                     |
'| Version:   SOFiSTIK 2018                                                   |
'+============================================================================+

Public Class Cc_node
    ' Here the sof_cdb_get function is declared for the CNODE structure
    ' Instead of using classes, pointers can also be used
    Public Declare Function sof_cdb_get Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_get" (ByVal Index As Integer,
                                                                                      ByVal kwh As Integer,
                                                                                      ByVal kwl As Integer,
                                                                                      ByRef data As CNODE,
                                                                                      ByRef datalen As Integer,
                                                                                      ByVal pos As Integer) As Integer
End Class
