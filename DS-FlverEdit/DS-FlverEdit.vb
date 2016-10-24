Imports System.IO
Imports System.Reflection

Public Class DS_FlverEdit


    Public Shared bigEndian As Boolean = False
    Public Shared fs As FileStream


    Dim dataOffset As Integer
    Dim dataSize As Integer
    Dim hitboxCount As Integer
    Dim materialCount As Integer
    Dim boneCount As Integer
    Dim meshCount As Integer
    Dim vertexInfoCount As Integer
    Dim facesetCount As Integer
    Dim vertexDescriptorCount As Integer
    Dim materialParameterCount As Integer






    Private Function ReadBytes(ByVal loc As Integer, ByVal count As Integer) As Byte()
        Dim byt(count - 1) As Byte
        fs.Position = loc

        For i = 0 To count - 1
            byt(i) = fs.ReadByte
        Next

        Return byt
    End Function

    Private Function ReadInt8() As SByte
        Return ReadInt8(fs.Position)
    End Function
    Private Function ReadInt8(ByVal loc As Integer) As SByte
        fs.Position = loc
        Return CSByte(fs.ReadByte)
    End Function

    Private Function ReadInt16() As Int16
        Return ReadInt16(fs.Position)
    End Function
    Private Function ReadInt16(ByVal loc As Integer) As Int16
        Dim byt(1) As Byte

        byt = ReadBytes(loc, 2)

        If bigEndian Then Array.Reverse(byt)

        Return BitConverter.ToInt16(byt, 0)
    End Function

    Private Function ReadInt32() As Int32
        Return ReadInt32(fs.Position)
    End Function
    Private Function ReadInt32(ByVal loc As Integer) As Int32
        Dim byt(3) As Byte

        byt = ReadBytes(loc, 4)

        If bigEndian Then Array.Reverse(byt)

        Return BitConverter.ToInt32(byt, 0)
    End Function

    Private Function ReadSingle() As Single
        Return ReadSingle(fs.Position)
    End Function
    Private Function ReadSingle(ByVal loc As Integer) As Single
        Dim byt(3) As Byte

        byt = ReadBytes(loc, 4)

        If bigEndian Then Array.Reverse(byt)

        Return BitConverter.ToSingle(byt, 0)
    End Function

    Private Function ReadAscString() As String
        Return ReadAscString(fs.Position)
    End Function
    Private Function ReadAscString(ByVal loc As Integer) As String
        Dim str As String = ""
        Dim chr As Char
        Dim cont As Boolean = True

        fs.Position = loc

        While cont
            chr = Convert.ToChar(fs.ReadByte)

            If AscW(chr) = 0 Then
                cont = False
            Else
                str = str + chr
            End If

        End While

        Return str
    End Function

    Private Function ReadUniString() As String
        Return ReadUniString(fs.Position)
    End Function
    Private Function ReadUniString(ByVal loc As Integer) As String
        Dim str As String = ""
        Dim chr As Char
        Dim cont As Boolean = True
        Dim chrpos As Integer = 0
        Dim byt(1) As Byte

        While cont
            byt = ReadBytes(loc + chrpos, 2)

            If bigEndian Then Array.Reverse(byt)

            chr = BitConverter.ToChar(byt, 0)
            chrpos += 2

            If AscW(chr) = 0 Then
                cont = False
            Else
                str = str & chr
            End If

        End While

        Return str
    End Function

    Private Function SeekUniString(ByVal loc As Integer) As String
        Dim offset As Integer
        Dim str As String
        offset = fs.Position
        str = ReadUniString(loc)
        fs.Position = offset
        Return str
    End Function


    Private Sub txt_Drop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles txtFLVERfile.DragDrop
        Dim file() As String = e.Data.GetData(DataFormats.FileDrop)
        sender.Text = file(0)
    End Sub
    Private Sub txt_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles txtFLVERfile.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub



    Private Function ParseFLVERHeader As Boolean
        '0x00
        If Not ReadAscString = "FLVER" Then Return False
        bigEndian = (ReadAscString = "B")
        ReadInt32   'Version?
        dataOffset = ReadInt32

        '0x10
        dataSize = ReadInt32
        hitboxCount = ReadInt32
        materialCount = ReadInt32
        boneCount = ReadInt32

        '0x20
        meshCount = ReadInt32
        vertexInfoCount = ReadInt32
        ReadSingle
        ReadSingle

        '0x30
        ReadSingle
        ReadSingle
        ReadSingle
        ReadSingle

        '0x40
        ReadInt32
        ReadInt32
        ReadInt8
        ReadInt8
        ReadInt16
        ReadInt16
        ReadInt16

        '0x50
        facesetCount = ReadInt32
        vertexDescriptorCount = ReadInt32
        materialParameterCount = ReadInt32

        For i = 0 To 8
            ReadInt32
        Next

        'Header end
        '0x80
        Return True
    End Function
    Private Function ParseHitboxes As Boolean
        Try
            For i = 0 To hitboxCount - 1
                dgvHitbox.Rows.Add({ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                               ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                               ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt8, ReadInt8, _
                               ReadInt32, ReadInt32, ReadInt32, ReadInt32})
                dgvHitbox.Rows(i).HeaderCell.Value = i.ToString
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function ParseMaterials As Boolean
        Try
            For i = 0 To materialCount - 1
                dgvMaterial.Rows.Add({SeekUniString(ReadInt32), SeekUniString(ReadInt32), ReadInt32, ReadInt32, _
                                     "0x" & Hex(ReadInt32), ReadInt32, ReadInt32, ReadInt32})
                dgvMaterial.Rows(i).HeaderCell.Value = i.ToString
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function ParseBones As Boolean
        Try
            For i = 0 To boneCount - 1
                dgvBone.Rows.Add({ReadSingle, ReadSingle, ReadSingle, SeekUniString(ReadInt32), _
                                 ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                                 ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                                 ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                                 ReadSingle, ReadSingle, ReadSingle, ReadInt16, ReadInt16, _
                                 ReadInt32, ReadInt32, ReadInt32, ReadInt32, _
                                 ReadInt32, ReadInt32, ReadInt32, ReadInt32, _
                                 ReadInt32, ReadInt32, ReadInt32, ReadInt32})
                dgvBone.Rows(i).HeaderCell.Value = i.ToString
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function ParseMesh As Boolean
        Try
            For i = 0 To meshCount - 1
                dgvMesh.Rows.Add({ReadInt32, ReadInt32, ReadInt32, ReadInt32, _
                                 ReadInt32, ReadInt32, ReadInt32, "0x" & Hex(ReadInt32), _
                                 ReadInt32, "0x" & Hex(ReadInt32), ReadInt32, "0x" & Hex(ReadInt32)})
                dgvMesh.Rows(i).HeaderCell.Value = i.ToString
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub err(ByVal msg As String)
        If fs.CanRead Then fs.Close
        MsgBox(msg)
    End Sub


    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            fs = File.Open(txtFLVERfile.Text, FileMode.Open)

            dgvHitbox.Rows.Clear
            dgvMaterial.Rows.Clear
            dgvBone.Rows.Clear
            dgvMesh.Rows.Clear


            If Not ParseFLVERHeader Then
                err("Error parsing FLVER header.")
                Return
            End If

            If hitboxCount > 0 Then
                If Not ParseHitboxes Then
                    err("Error parsing hitboxes.")
                    Return
                End If
            End If

            If materialCount > 0 Then
                If Not ParseMaterials Then
                    err("Error parsing materials.")
                    Return
                End If
            End If

            If boneCount > 0 Then
                If Not ParseBones Then
                    err("Error parsing bones.")
                    Return
                End If
            End If

            If meshCount > 0 Then
                If Not ParseMesh Then
                    err("Error parsing bones.")
                    Return
                End If
            End If


            fs.Close
        Catch ex As Exception
            MsgBox("Error." & Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub initDGVcols(dgv As DataGridView, colList As List(Of String))
        Dim gray As Boolean = False
        For i = 0 To colList.Count - 1
            dgv.Columns.Add(colList.Item(i), colList.Item(i))
            dgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
    Public Shared Sub SetDoubleBuffered(ByVal control As Control)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub
    Private Sub DS_FlverEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colList As New List(Of String)

        SetDoubleBuffered(dgvHitbox)
        SetDoubleBuffered(dgvMaterial)
        SetDoubleBuffered(dgvBone)
        SetDoubleBuffered(dgvMesh)

        colList.AddRange({"f32", "f32", "f32", "i16", "i16", _
                         "f32", "f32", "f32", "DmyPoly", "i16", _
                         "f32", "f32", "f32", "i16", "i8", "i8", _
                         "i32", "i32", "i32", "i32"})
        initDGVcols(dgvHitbox, colList)



        colList.Clear
        colList.AddRange({"Name", "MTD Name", "Param Count", "Param StartIndex", _
                         "Text Size", "i32", "i32", "i32"})
        initDGVcols(dgvMaterial, colList)


        colList.Clear
        colList.AddRange({"X pos", "Y pos", "Z pos", "Name", _
                         "X rot", "Y rot", "Z rot", "Parent Idx", "First Child Idx", _
                         "X scale", "Y scale", "Z scale", "1st Sibling Idx", "CopyOF Idx", _
                         "f32", "f32", "f32", "IsNub", "i16", _
                         "f32", "f32", "f32", "i16", "i16", _
                         "i32", "i32", "i32", "i32", _
                         "i32", "i32", "i32", "i32", _
                         "i32", "i32", "i32", "i32"})
        initDGVcols(dgvBone, colList)


        colList.Clear
        colList.AddRange({"isDynamic", "Index", "i32", "i32", _
                         "Default Bone Idx", "Bone Idx Count", "i32", "Bone Idx Offset", _
                         "Faceset Count", "Faceset Idx Offset", "Vertex Info Count", "Vertex Info Offset"})
        initDGVcols(dgvMesh, colList)


    End Sub
End Class
