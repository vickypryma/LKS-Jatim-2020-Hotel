Partial Class DbHotelDataSet
    Partial Public Class EmployeeDataTable
        Private Sub EmployeeDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PasswordColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
