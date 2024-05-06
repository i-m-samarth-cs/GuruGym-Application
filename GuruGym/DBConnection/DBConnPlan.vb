Imports System.Data.OleDb

Public Class DBConnPlan
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private conn As OleDbConnection

    Public Sub New()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gurugym.accdb")
        conn.Open()
        da = New OleDbDataAdapter()
        ds = New DataSet()
        da.SelectCommand = New OleDbCommand("select * from plan", conn)
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Fill(ds, "plan")
    End Sub

    Public Function getPlanDA() As OleDbDataAdapter
        Return da
    End Function

    Public Function getPlanDS() As DataSet
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Update(ds, "plan")
        ds.Clear()
        da.Fill(ds, "plan")
        Return ds
    End Function

    Public Sub closeConn()
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Update(ds, "plan")
        conn.Close()
    End Sub

    Public Function insertData(ByVal details As planDetail) As String
        Try
            Dim name_rows() As DataRow = ds.Tables(0).Select("name='" & details.name & "'")
            If name_rows.Length > 0 Then
                Return "Name already present"
            End If

            da.InsertCommand = New OleDbCommand("Insert into plan (name, months, amount, active) values('" & details.name &
                "','" & details.months & "','" & details.amount & "',True)", conn)

            MsgBox(da.InsertCommand.CommandText)

            Dim affectedRows As Integer = da.InsertCommand.ExecuteNonQuery()
            If affectedRows > 0 Then
                Return "Record Inserted Successfully"
            End If
        Catch ex As Exception
            MsgBox("Something went wrong " & ex.Message)
        End Try
        Return "Something went wrong "
    End Function

    Public Function deletePlanWithID(ByVal id As Integer)
        Try
            da.DeleteCommand = New OleDb.OleDbCommand("delete from plan where id=" & id, conn)
            Dim deletedRows As Integer = da.DeleteCommand.ExecuteNonQuery()

            If deletedRows > 0 Then
                Return "Plan with ID=" & id & "deleted successfully"
            Else
                Return "Plan with ID=" & id & "Not found"
            End If
        Catch exc As Exception
            Return "Plan Non deleted please contact administrator"
        End Try
    End Function

    Public Function updateData(ByVal details As planDetail, ByVal id As Integer) As String
        Try
            da.UpdateCommand = New OleDb.OleDbCommand("update plan set name='" & details.name & "', months=" & details.months &
                                                      ",amount=" & details.amount & ", active=" & details.active & " where id=" & id, conn)

            Dim changedRows As Integer = da.UpdateCommand.ExecuteNonQuery()
            If changedRows > 0 Then
                Return "Successfully updated Record"
            Else
                Return "Updating Record Failed"
            End If
        Catch exc As Exception
            MsgBox("Something Went wrong")
        End Try
        Return "Something Went wrong"
    End Function

End Class

Public Structure planDetail
    Dim name As String
    Dim months As Integer
    Dim amount As Integer
    Dim active As Boolean
End Structure
