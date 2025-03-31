Imports System.IO

Public Class Form1
    Dim choose1 As Boolean = False
    Dim choose2 As Boolean = False
    Dim choose3 As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRegedit()
        TBfrom.Text = Fromfolder
        TBto.Text = Tofolder
        TBcsv.Text = CSVfile
        Checkchoose()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        SaveRegedit()
    End Sub

    Private Sub BTfrom_Click(sender As Object, e As EventArgs) Handles BTfrom.Click
        Note.Text = "Choose From folder"
        Dim folderBrowserDialog As New FolderBrowserDialog With {
            .Description = "Select From folder",
            .RootFolder = Environment.SpecialFolder.MyComputer,
            .ShowNewFolderButton = True
        }
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = folderBrowserDialog.SelectedPath
            TBfrom.Text = filePath
            Fromfolder = filePath
            choose1 = True
            Checkchoose()
        End If
    End Sub

    Private Sub BTto_Click(sender As Object, e As EventArgs) Handles BTto.Click
        Note.Text = "Choose To folder"
        Dim folderBrowserDialog As New FolderBrowserDialog With {
            .Description = "Select To folder",
            .RootFolder = Environment.SpecialFolder.MyComputer,
            .ShowNewFolderButton = True
        }
        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = folderBrowserDialog.SelectedPath
            TBto.Text = filePath
            Tofolder = filePath
            choose2 = True
            Checkchoose()
        End If
    End Sub

    Private Sub BTcsv_Click(sender As Object, e As EventArgs) Handles BTcsv.Click
        Note.Text = "Choose CSV file"
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "CSV files (*.csv)|*.csv",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            TBcsv.Text = filePath
            CSVfile = filePath
            choose3 = True
            Checkchoose()
        End If

    End Sub

    Private Sub BTstart_Click(sender As Object, e As EventArgs) Handles BTstart.Click
        LoadSKUsvg(CSVfile)
        Note.Text = "Start copy..."
        ProgressBar1.Value = 10
        Note.Refresh()
        Dim errortext As String = "Cannot find folder: " & vbCrLf
        For Each ASIN As String In ASINItems
            If ASIN <> "" Then
                Dim Checkfrom As String = Path.Combine(Fromfolder, ASIN)
                Dim Checkto As String = Path.Combine(Tofolder, ASIN)
                If Directory.Exists(Checkfrom) Then
                    Note.Text = $"Copying {ASIN} ..."
                    Note.Refresh()
                    RecursiveDirectoryCopy(Checkfrom, Checkto, True, True)
                Else
                    errortext += Checkfrom & vbCrLf
                End If
            End If
        Next
        ProgressBar1.Value = 100
        If errortext <> "Cannot find folder: " Then
            MessageBox.Show(errortext)
        Else
            MessageBox.Show("Copy all folder successful!")
        End If
    End Sub

    Private Sub Checkchoose()
        ProgressBar1.Value = 0
        If (choose1 = True And choose2 = True And choose3 = True) Or (TBcsv.Text <> "C:\temp" And TBfrom.Text <> "C:\temp" And TBto.Text <> "C:\temp") Then
            If Directory.Exists(TBfrom.Text) And Directory.Exists(TBto.Text) And File.Exists(TBcsv.Text) Then
                SaveRegedit()
                'LoadSKUsvg(TBcsv.Text)
                BTstart.Enabled = True
            Else
                BTstart.Enabled = False
            End If
        Else
            BTstart.Enabled = False
        End If
    End Sub

End Class
