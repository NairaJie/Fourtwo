
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=perhitungan_gaji_nai"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim totgaji, gapok, jabatan, kesehatan As Double

    Private Sub Txtasuransi_TextChanged(sender As Object, e As EventArgs) Handles Txtasuransi.TextChanged
        totgaji = gapok + jabatan + kesehatan - Val(Txtasuransi.Text) - Val(Txtkoperasi.Text)
        Lbltotalgaji.Text = Format(totgaji, "Rp ###,###,##")
    End Sub

    Private Sub Cmdsimpan_Click(sender As Object, e As EventArgs) Handles Cmdsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into gaji values('" & Txtkode.Text & "', " &
        " '" & Txtkaryawan.Text & "' , '" & Cmbjabatan.Text & "' , " &
        " '" & Lblgajipokok.Text & "' , '" & Lbltunjjabatan.Text & "' ," &
        " '" & Lbltunjkes.Text & "','" & Txtasuransi.Text & "','" & Txtkoperasi.Text & "','" & Lbltotalgaji.Text & "')"
        perintah.ExecuteNonQuery()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        kon.Close()
    End Sub

    Private Sub Txtkoperasi_TextChanged(sender As Object, e As EventArgs) Handles Txtkoperasi.TextChanged
        totgaji = gapok + jabatan + kesehatan - Val(Txtasuransi.Text) - Val(Txtkoperasi.Text)
        Lbltotalgaji.Text = Format(totgaji, "Rp ###,###,##")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmbjabatan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbjabatan.SelectedIndexChanged
        Select Case Cmbjabatan.SelectedIndex
            Case 0
                gapok = 4000000
                jabatan = 4000000 * 20 / 100
                kesehatan = 4000000 * 15 / 100

            Case 1
                gapok = 3000000
                jabatan = 3000000 * 15 / 100
                kesehatan = 3000000 * 10 / 100

            Case 2
                gapok = 2500000
                jabatan = 2500000 * 15 / 100
                kesehatan = 2500000 * 10 / 100


        End Select
        Lblgajipokok.Text = Format(gapok, "Rp ###,###,##")
        Lbltunjjabatan.Text = Format(jabatan, "Rp ###,###,##")
        Lbltunjkes.Text = Format(kesehatan, "Rp ###,###,##")
    End Sub
End Class
