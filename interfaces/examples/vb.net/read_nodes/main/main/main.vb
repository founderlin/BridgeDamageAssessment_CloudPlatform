'+============================================================================+
'| Company:   SOFiSTiK AG                                                     |
'| Version:   SOFiSTIK 2018                                                   |
'+============================================================================+

Imports System.Runtime.InteropServices

Module main
    Public Declare Function sof_cdb_init Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_init" (ByVal name As String,
                                                                                        ByVal InitType As Integer) As Integer
    Public Declare Function sof_cdb_status Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_status" (ByVal Index As Integer) As Integer
    Public Declare Function sof_cdb_close Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_close" (ByVal Index As Integer) As Integer

    Sub Main()
        Dim Filename As String
        Dim Index As Integer
        Dim Path As String
        Dim analysisPath As String
        Dim datalen As Integer
        Dim data As New CNODE()
        Dim analysisPath2 As String

        'Path of the SOFiSTIK Directory
        analysisPath = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit\"
        analysisPath2 = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\"

        'Set the environment variable
        Path = Environment.GetEnvironmentVariable("path")
        Path = analysisPath2 + ";" + analysisPath + ";" + Path
        Environment.SetEnvironmentVariable("path", Path)

        'Filename = full path with name of the cdb
        Filename = "S:\test\read_nodes.cdb"

        ' To connect to the CDB
        Index = sof_cdb_init(Filename, 99)
        If Index < 0 Then
            Console.WriteLine("ERROR: Index= " & Index & " < 0 - see clib1.h for meaning of error codes")
            Console.ReadKey()
            Exit Sub
        ElseIf Index = 0 Then
            Console.WriteLine("ERROR: Index= " & Index & " - The File is not a database")
            Console.ReadKey()
            Exit Sub
        End If

        ' Redim the m_XYZ array
        ReDim data.m_XYZ(2) ' this step is necessary because in VB.NET fixed array in structures are not supported

        ' Get the data-length
        datalen = Marshal.SizeOf(data)

        ' Print the values
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}", "m_NR", "m_INR", "m_KFIX", "m_NCOD", "m_X", "m_Y", "m_Z")
        Do While Cc_node.sof_cdb_get(Index, 20, 0, data, datalen, 1) < 2
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15}",
                              data.m_NR,
                              data.m_INR,
                              data.m_KFIX,
                              data.m_NCOD,
                              data.m_XYZ(0),
                              data.m_XYZ(1),
                              data.m_XYZ(2))
            datalen = Marshal.SizeOf(data)
        Loop

        'This outputs the status of the CDB, please refer to cdbase.chm for more details
        Console.WriteLine("Index: " & Index)
        Console.WriteLine("CDB Status: " & sof_cdb_status(Index))

        'Close the CDB
        Call sof_cdb_close(0)

        'Check the CDB Status
        If sof_cdb_status(Index) = 0 Then
            Console.WriteLine("CDB closed succesfully, status = 0")
        End If

        Console.Write("Press any <key> to close the program")
        Console.ReadKey()

    End Sub
End Module
