Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32

Module GlobalVar
    Private Const RegistryPath As String = "HKEY_CURRENT_USER\Software\Loft3Di_Pro\Copy_File_Reference"
    Private Const FromFolderKey As String = "FromFolderKey"
    Private Const ToFolderKey As String = "ToFolderKey"
    Private Const CSVfileKey As String = "CSVfileKey"

    ' Var for iniFile.vb
    Public Const INIFILE_ERR_FILENAME_REQUIRED = -1000
    Public Const INIFILE_ERR_KEY_REQUIRED = -1001

    ' Fuction for iniFile.vb
    Function AppPath() As String
        '-- Return application folder ended with "\"
        Return AppDomain.CurrentDomain.BaseDirectory
    End Function

    ' Var
    Public CurrentFolder As String = CurDir()
    Public inipath As String = CurrentFolder + "\setting.ini"
    Public ASINItems() As String
    Public ASINItemsCount As Integer = 0
    Public Progresscout As Integer = 1

    Public Fromfolder As String = "C:\temp"
    Public Tofolder As String = "C:\temp"
    Public CSVfile As String = "C:\temp"

    Public Sub LoadSKUsvg(filePath)
        Dim fs As FileStream
        Dim sr As StreamReader
        Dim sLine As String

        fs = New FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite)
        sr = New StreamReader(fs, Encoding.UTF8)

        ASINItemsCount = 0
        While True
            sLine = Trim(sr.ReadLine())
            ASINItemsCount += 1
            ReDim Preserve ASINItems(ASINItemsCount)
            ASINItems(ASINItemsCount - 1) = sLine
            If sr.EndOfStream Then
                Exit While
            End If
        End While

        sr.Close()
        fs.Close()
        'sr = Nothing
        'fs = Nothing
    End Sub

    Public Sub LoadRegedit()
        Dim loadFromFolder As String = CStr(Registry.GetValue(RegistryPath, FromFolderKey, String.Empty))
        Dim loadToFolder As String = CStr(Registry.GetValue(RegistryPath, ToFolderKey, String.Empty))
        Dim loadCSVfile As String = CStr(Registry.GetValue(RegistryPath, CSVfileKey, String.Empty))

        If loadFromFolder <> "" And loadToFolder <> "" And loadCSVfile <> "" Then
            Fromfolder = loadFromFolder
            Tofolder = loadToFolder
            CSVfile = loadCSVfile
        Else
            SaveRegedit()
        End If
    End Sub

    Public Sub ClearRegedit()
        ' Save Register
        Registry.SetValue(RegistryPath, FromFolderKey, String.Empty)
        Registry.SetValue(RegistryPath, ToFolderKey, String.Empty)
        Registry.SetValue(RegistryPath, CSVfileKey, String.Empty)
    End Sub

    Public Sub SaveRegedit()
        ' Save Register
        Registry.SetValue(RegistryPath, FromFolderKey, Fromfolder)
        Registry.SetValue(RegistryPath, ToFolderKey, Tofolder)
        Registry.SetValue(RegistryPath, CSVfileKey, CSVfile)
    End Sub

    Public Sub RecursiveDirectoryCopy(ByVal sourceDir As String, ByVal destDir As String, ByVal fRecursive As Boolean, ByVal overWrite As Boolean)
        ' Copytree Folder
        ' Add trailing separators to the supplied paths if they don't exist.
        If Not sourceDir.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
            sourceDir &= Path.DirectorySeparatorChar
        End If
        If Not destDir.EndsWith(Path.DirectorySeparatorChar.ToString()) Then
            destDir &= Path.DirectorySeparatorChar
        End If

        ' If destination directory does not exist, create it.
        Dim dDirInfo As New DirectoryInfo(destDir)
        If Not dDirInfo.Exists Then
            dDirInfo.Create()
        End If

        ' Recursive switch to continue drilling down into directory structure.
        If fRecursive Then
            ' Get a list of directories from the current parent.
            For Each sDir In Directory.GetDirectories(sourceDir)
                Dim sDirInfo As New DirectoryInfo(sDir)
                Dim dSubDir As String = Path.Combine(destDir, sDirInfo.Name)
                RecursiveDirectoryCopy(sDirInfo.FullName, dSubDir, fRecursive, overWrite)
            Next
        End If

        ' Get the files from the current parent.
        Dim Dirfiles As String() = Directory.GetFiles(sourceDir)
        Dim Countfiles = Dirfiles.Count
        Dim n As Integer = 0
        For Each sFile In Dirfiles
            n += 1
            Dim sFileInfo As New FileInfo(sFile)
            Dim dFile As String = Path.Combine(destDir, sFileInfo.Name)
            Dim dFileInfo As New FileInfo(dFile)

            ' If file does not exist or overwrite is true, copy the file.
            If Not dFileInfo.Exists OrElse overWrite Then
                Form1.ProgressBar1.Value = n / Countfiles * 100
                Form1.ProgressBar1.Refresh()
                'If Form1.ProgressBar1.Value < 95 Then
                '    Form1.ProgressBar1.Value += 5
                '    Form1.ProgressBar1.Refresh()
                'End If
                sFileInfo.CopyTo(dFile, overWrite)
            End If
        Next
    End Sub

End Module


