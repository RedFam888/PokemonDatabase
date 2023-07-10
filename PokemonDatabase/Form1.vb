Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMoveName_Click(sender As Object, e As EventArgs) Handles btnMoveName.Click

        Dim tmName As String = txtMoveName.Text
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider = Microsoft.Ace.OLEDB.12.0;" & "Data Source = C:\Users\Mason PC\OneDrive\Documents\Visual Basic Complete Class\COMP 9\New folder\PokemonDatabase.mdb"
        sqlStatement = "SELECT PokemonAttacks.MoveName, Uses.MoveNumber, PokemonNamesandNumbers.PokemonName, PokemonNamesandNumbers.UniqueSubName " &
        "FROM (PokemonAttacks " &
        "INNER JOIN Uses ON PokemonAttacks.MoveNumber = Uses.MoveNumber) " &
        "INNER JOIN PokemonNamesandNumbers On PokemonNamesandNumbers.PokemonName = Uses.PokemonName " &
        "WHERE PokemonAttacks.MoveName = '" & tmName & "'"

        Dim dtProperties As New DataTable
        Dim dbDataAdpater As OleDbDataAdapter
        dbDataAdpater = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdpater.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties
    End Sub

    Private Sub btnMoveNumber_Click(sender As Object, e As EventArgs) Handles btnMoveNumber.Click

        Dim tmNumber As String = txtMoveNumber.Text.ToUpper
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider = Microsoft.Ace.OLEDB.12.0;" & "Data Source = C:\Users\Mason PC\OneDrive\Documents\Visual Basic Complete Class\COMP 9\New folder\PokemonDatabase.mdb"
        sqlStatement = "SELECT Uses.MoveNumber, PokemonNamesandNumbers.PokemonName, PokemonNamesandNumbers.UniqueSubName " &
        "FROM PokemonNamesandNumbers " &
        "INNER JOIN Uses ON PokemonNamesandNumbers.PokemonName = Uses.PokemonName " &
        "WHERE Uses.MoveNumber = '" & tmNumber & "'"

        Dim dtProperties As New DataTable
        Dim dbDataAdpater As OleDbDataAdapter
        dbDataAdpater = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdpater.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties
    End Sub
End Class
