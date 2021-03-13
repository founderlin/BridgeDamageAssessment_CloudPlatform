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
    Public Declare Function sof_cdb_flush Lib "cdb_w50_x64.dll" Alias "VB_sof_cdb_flush" (ByVal Index As Integer) As Integer

    Public Sub Main()
        Dim Filename As String
        Dim ie As Integer
        Dim Path As String
        Dim analysisPath As String
        Dim datalen As Integer
        Dim analysisPath2 As String

        'Path of the SOFiSTIK Directory
        analysisPath = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit\"
        analysisPath2 = "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\"

        'Set the environment variable
        Path = Environment.GetEnvironmentVariable("path")
        Path = analysisPath2 + ";" + analysisPath + ";" + Path
        Environment.SetEnvironmentVariable("path", Path)

        'Filename = full path with name of the cdb
        Filename = "S:\test\single_span_girder\simple_span_girder.cdb"

        '#############################
        '# Connect to the CDB        #
        '# int sof_cdb_init()        #
        '#############################
        ie = sof_cdb_init(Filename, 99)
        If ie < 0 Then
            Console.WriteLine("ERROR: Index= " & ie & " < 0 - see clib1.h for meaning of error codes")
            Console.ReadKey()
            Exit Sub
        ElseIf ie = 0 Then
            Console.WriteLine("ERROR: Index= " & ie & " - The File is not a database")
            Console.ReadKey()
            Exit Sub
        End If

        '#############################
        '# Read the data             #
        '# sof_cdb_get()             #
        '#############################

        '-----------------------------
        ' Read the f_ck value
        '-----------------------------
        Dim d_cmat_conc As New CMAT_CONC()
        Dim fck As Single
        ' Get the data-length
        datalen = Marshal.SizeOf(d_cmat_conc)

        ' Print the values
        Do While Cc_mat_conc.sof_cdb_get(ie, 1, 1, d_cmat_conc, datalen, 1) < 2
            If (d_cmat_conc.m_ID = 1) Then
                fck = d_cmat_conc.m_FCK
            End If
            datalen = Marshal.SizeOf(d_cmat_conc)
        Loop

        ' Release all locks. All memory for directories and 
        '     data is released. 
        ' Only after this call the directory structure is 
        '     reread which allows the access to newly 
        '     defined keys.
        Call sof_cdb_flush(ie)

        '-----------------------------
        ' Read the f_yk value
        '-----------------------------
        Dim d_cmat_stee As New CMAT_STEE

        ' In VB.NET fixed array in structs are not supported
        ' please see the structure CMAT_STEE
        ' all arrays must be redimensioned
        ' size = 2 (m_DUMMY(0), m_DUMMY(1))
        ReDim d_cmat_stee.m_DUMMY(1)
        Dim fyk As Single
        ' Get the data-length
        datalen = Marshal.SizeOf(d_cmat_stee)

        ' Print the values
        Do While Cc_mat_stee.sof_cdb_get(ie, 1, 2, d_cmat_stee, datalen, 1) < 2
            If (d_cmat_stee.m_ID = 1) Then
                fyk = d_cmat_stee.m_FY
            End If
            datalen = Marshal.SizeOf(d_cmat_stee)
        Loop

        ' Release all locks
        Call sof_cdb_flush(ie)

        '-----------------------------
        ' Read the b, h, so, su
        '-----------------------------
        Dim d_sect_rec As New CSECT_REC
        ' Get the data-length
        datalen = Marshal.SizeOf(d_sect_rec)
        Dim b As Single
        Dim h As Single
        Dim so As Single
        Dim su As Single

        ' kwh = 9, kwl = 1
        Do While (Cc_sect_rec.sof_cdb_get(ie, 9, 1, d_sect_rec, datalen, 1) < 2)
            If (d_sect_rec.m_ID = 10) Then
                b = d_sect_rec.m_B
                h = d_sect_rec.m_H
                so = d_sect_rec.m_SO
                su = d_sect_rec.m_SU
            End If
            datalen = Marshal.SizeOf(d_sect_rec)
        Loop

        ' Release all locks
        Call sof_cdb_flush(ie)

        '-------------------------------
        ' Read the internal forces M, N
        '-------------------------------
        Dim d_beam_foc As New CBEAM_FOC
        ' Get the data-length
        datalen = Marshal.SizeOf(d_beam_foc)
        Dim Ned As Single
        Dim Med As Single

        ' kwh = 102, kwl = 1001
        Do While (Cc_beam_foc.sof_cdb_get(ie, 102, 1001, d_beam_foc, datalen, 1) < 2)
            If (d_beam_foc.m_ID = 0) Then
                If (Math.Abs(Ned) < Math.Abs(d_beam_foc.m_N)) And (Math.Abs(d_beam_foc.m_N) < 1.0E+35) Then
                    Ned = d_beam_foc.m_N
                End If
                If (Math.Abs(Med) < Math.Abs(d_beam_foc.m_MY)) And (Math.Abs(d_beam_foc.m_MY) < 1.0E+35) Then
                    Med = d_beam_foc.m_MY
                End If
            End If
            datalen = Marshal.SizeOf(d_beam_foc)
        Loop

        ' Release all locks
        Call sof_cdb_flush(ie)

        ' ***************************************************
        ' * CROSS SECTION DESIGN                            *
        ' * iterating the reinforcement to get equilibrium  *
        ' ***************************************************
        Dim epss As Single
        epss = 25
        Dim epsc As Single
        Dim Mrd As Single
        Dim mu As Single
        Dim alpha As Single
        Dim xi As Single
        Dim x As Single
        Dim d As Single
        d = h - su
        Dim ka As Single
        Dim z As Single
        Dim zeta As Single
        Dim omega As Single
        Dim fcd As Single
        fcd = (fck * 0.85) / 1.5
        Dim fyd As Single
        fyd = fyk / 1.15
        Dim As1 As Single
        Dim Meds As Single

        Meds = Med - Ned * (h / 2 - su)

        ' Iterate the reinforcement
        Do While (Mrd <= Meds) And (mu <= 0.296)
            If (epsc >= 0) And (epsc <= 2) Then
                alpha = epsc / 12 * (6 - epsc)
            ElseIf (epsc > 2) And (epsc <= 3.5) Then
                alpha = (3 * epsc - 2) / (3 * epsc)
            End If


            ' Calculate the Xi value
            xi = epsc / (epss + epsc)

            ' Calculate x
            x = xi * d

            ' Calcualte ka
            If (epsc >= 0) And (epsc <= 2) Then
                ka = (8 - epsc) / (4 * (6 - epsc))
            ElseIf (epsc < 2) And (epsc <= 3.5) Then
                ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))
            End If

            ' Calculate z
            z = d - ka * x

            ' Calculate zeta
            zeta = 1 - ka * xi

            ' Calculate omega
            omega = alpha * xi

            ' Calculate mu
            mu = alpha * xi * zeta

            ' Calculate the Mrd resistance moment
            Mrd = alpha * xi * d * b * fcd * zeta * d

            ' Required reinforcement
            As1 = (1 / fyd) * (omega * b * d * fcd + Ned)


            If (epsc >= 3.5) Then
                Do While (Mrd <= Meds) And (epss >= 0) And (mu < 0.296)
                    If (epsc > 0) And (epsc <= 2) Then
                        alpha = epsc / 12 * (6 - epsc)
                    ElseIf (epsc > 2) And (epsc <= 3.5) Then
                        alpha = (3 * epsc - 2) / (3 * epsc)
                    End If

                    ' Calculate the Xi value
                    xi = epsc / (epss + epsc)

                    ' Calculate x
                    x = xi * d

                    ' Calculate ka
                    If (epsc > 0) And (epsc <= 2) Then
                        ka = (8 - epsc) / (4 * (6 - epsc))
                    ElseIf (epsc > 2) And (epsc <= 3.5) Then
                        ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))
                    End If

                    ' Calculate z
                    z = d - ka * x

                    ' Calculate zeta
                    zeta = 1 - ka * xi

                    ' Calculate omega
                    omega = alpha * xi

                    ' Calculate mu
                    mu = alpha * xi * zeta

                    ' Calculate the Mrd resistance moment
                    Mrd = alpha * xi * d * b * fcd * zeta * d

                    ' Required reinforcement
                    As1 = (1 / fyd) * (omega * b * d * fcd + Ned)

                    If (epss = 0) Then
                        Console.WriteLine("Reinforcement reached 0 [o/oo]")
                    End If

                    ' Iterate epss
                    epss = epss - 0.001
                Loop
            End If
            ' Iterate epsc
            epsc = epsc + 0.001
        Loop

        ' ***************************************************
        ' * OUTPUT                                          *
        ' ***************************************************
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "fcd", "=", fcd, "[MPa]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "fyd", "=", fyd, "[MPa]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "epsc", "=", epsc, "[o/oo]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "epss", "=", epss, "[o/oo]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "alpha", "=", alpha, "[-]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "ka", "=", ka, "[-]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "z", "=", z, "[m]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "zeta", "=", zeta, "[-]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "omega", "=", omega, "[-]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "mu", "=", mu, "[-]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "d", "=", d, "[m]")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "Xi", "=", xi, "[-]")
        Console.WriteLine("-------------")
        Console.WriteLine("{0,-6} {1,6} {2,-12} {3,0}", "As1", "=", As1 * 100 * 100, "[cm2]")

        ' This outputs the status of the CDB, please refer to cdbase.chm for more details
        Console.WriteLine("Index: " & ie)
        Console.WriteLine("CDB Status: " & sof_cdb_status(ie))

        ' Close the CDB
        Call sof_cdb_close(0)

        'Check the CDB Status
        If sof_cdb_status(ie) = 0 Then
            Console.WriteLine("CDB closed succesfully, status = 0")
        End If

        Console.Write("Press any <key> to close the program")
        Console.ReadKey()

    End Sub
End Module
