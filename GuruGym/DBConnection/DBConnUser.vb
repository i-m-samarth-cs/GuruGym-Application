Imports System.Data.OleDb
Public Class DBConnUser
    Private da As OleDbDataAdapter
    Private ds As DataSet
    Private conn As OleDbConnection

    Public Sub New()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gurugym.accdb")
        conn.Open()
        da = New OleDbDataAdapter()
        ds = New DataSet()
        da.SelectCommand = New OleDbCommand("select * from users", conn)
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Fill(ds, "users")
    End Sub

    Public Function getUserDA() As OleDbDataAdapter
        Return da
    End Function

    Public Function getUserDS() As DataSet
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Update(ds, "users")
        ds.Clear()
        da.Fill(ds, "users")
        Return ds
    End Function

    Public Sub closeConn()
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand
        da.Update(ds, "users")
        conn.Close()
    End Sub

    Public Function insertData(ByVal details As usersDetail) As String
        Dim sql_insert As String
        Try
            Dim rows_aadhar() As DataRow = ds.Tables(0).Select("aadhar='" & details.aadhar & "'")
            If rows_aadhar.Length > 0 Then
                Return "User with Aadhar=" & details.aadhar & " Already present"
            End If

            Dim rows_mobile() As DataRow = ds.Tables(0).Select("mobile='" & details.mobile & "'")
            If rows_mobile.Length > 0 Then
                Return "User with Mobile=" & details.mobile & " Already present"
            End If

            sql_insert = "Insert into users (name, email, aadhar, mobile, joining, lastUpdated, active) values('" &
                details.name & "','" & details.email & "','" & details.aadhar & "','" & details.mobile & "','" &
                details.joining & "','" & Date.Now.ToLocalTime & "',true)"

            MsgBox(sql_insert)
            da.InsertCommand = New OleDbCommand(sql_insert, conn)
            da.InsertCommand.ExecuteNonQuery()
            Return "User Added Successfully"
        Catch exc As Exception
            Return "something went wrong contact administrator " & exc.Message
        End Try
    End Function

    Public Function updateData(ByVal details As usersDetail, ByVal uid As Integer) As String
        Try
            da.UpdateCommand = New OleDb.OleDbCommand("update users set name='" & details.name & "',aadhar='" & details.aadhar &
                                                      "',mobile='" & details.mobile & "', email='" & details.email &
                                                      "', joining='" & details.joining & "', lastUpdated='" &
                                                      Date.Now.ToLocalTime & "', active=" & details.active & " where id=" & uid, conn)

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

    Public Function deleteUserWithID(ByVal uid As Integer)
        Try
            da.DeleteCommand = New OleDb.OleDbCommand("delete from users where id=" & uid, conn)
            Dim deletedRows As Integer = da.DeleteCommand.ExecuteNonQuery()

            If deletedRows > 0 Then
                Return "User with UID=" & uid & "deleted successfully"
            Else
                Return "User with UID=" & uid & "Not found"
            End If
        Catch exc As Exception
            Return "User Non deleted please contact administrator"
        End Try
    End Function

End Class

Public Structure usersDetail
    Dim name As String
    Dim email As String
    Dim aadhar As String
    Dim mobile As String
    Dim joining As Date
    Dim uid As Integer
    Dim active As Boolean
End Structure
