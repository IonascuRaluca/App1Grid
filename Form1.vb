Imports System.Runtime.InteropServices
Public Class Form1
    Dim dt As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dt.Rows.Add(txtId.Text, txtNume.Text, TxtPrenume.Text)

        DataGridView1.DataSource = dt

        txtId.Clear()
        txtNume.Clear()
        TxtPrenume.Clear()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        dt.Columns.Add("Id", Type.GetType("System.Int32"))
        dt.Columns.Add("Nume", Type.GetType("System.String"))
        dt.Columns.Add("Prenume", Type.GetType("System.String"))

        DataGridView1.DataSource = dt

    End Sub

End Class
