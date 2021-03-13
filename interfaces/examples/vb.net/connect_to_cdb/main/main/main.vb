'+============================================================================+
'| Company:   SOFiSTiK AG                                                     |
'| Version:   SOFiSTIK 2018                                                   |
'+============================================================================+

Imports System.Runtime.InteropServices

Module main
    'In this example, 64bit dlls are used
    Public Declare Function sof_cdb_init Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_init" (ByVal name As String, ByVal InitType As Integer) As Integer
    Public Declare Function sof_cdb_status Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_status" (ByVal Index As Integer) As Integer
    Public Declare Function sof_cdb_close Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_close" (ByVal Index As Integer) As Integer

    Sub Main()
        Dim Filename As String
        Dim Index As Integer
        Dim Path As String
        Dim analysisPath As String
        Dim analysisPath2 As String

        'Path of the SOFiSTIK Directory
        analysisPath = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit\"
        analysisPath2 = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\"

        'Set the environment variable
        Path = Environment.GetEnvironmentVariable("path")
        Path = analysisPath2 + ";" + analysisPath + ";" + Path
        Environment.SetEnvironmentVariable("path", Path)

        'Filename = full path with name of the cdb
        Filename = "S:\test\test.cdb"

        ' To connect to the CDB we will use
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

        ' Output the index and status
        Console.WriteLine("Index: " & Index)
        Console.WriteLine("CDB Status: " & sof_cdb_status(Index))    'this outputs the status of the CDB, please refer to cdbase.chm for more details

        ' Close the CDB
        Call sof_cdb_close(0)

        'Check if CDB closed succesfully

        If sof_cdb_status(Index) = 0 Then
            Console.WriteLine("CDB closed succesfully, status = 0")
        End If

        ' Press any key to close the program
        Console.Write("Press any <key> to close the program")
        Console.ReadKey()

    End Sub
End Module
