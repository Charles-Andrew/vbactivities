Imports MySql.Data.MySqlClient

Public Class StudentClass
    Private FirstName As String
    Public Property FirstNameProp() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property

    Private MiddleName As String
    Public Property MiddleNameProp() As String
        Get
            Return MiddleName
        End Get
        Set(ByVal value As String)
            MiddleName = value
        End Set
    End Property

    Private LastName As String
    Public Property LastNameProp() As String
        Get
            Return LastName
        End Get
        Set(ByVal value As String)
            LastName = value
        End Set
    End Property

    Private Gender As String
    Public Property GenderProp() As String
        Get
            Return Gender
        End Get
        Set(ByVal value As String)
            Gender = value
        End Set
    End Property

    Private DOB As Date
    Public Property DOBProp() As Date
        Get
            Return DOB
        End Get
        Set(ByVal value As Date)
            DOB = value
        End Set
    End Property

    Private ParentName As String
    Public Property ParentNameProp() As String
        Get
            Return ParentName
        End Get
        Set(ByVal value As String)
            ParentName = value
        End Set
    End Property

    Private Address As String
    Public Property AddressProp() As String
        Get
            Return Address
        End Get
        Set(ByVal value As String)
            Address = value
        End Set
    End Property

    Private ContactNo As String
    Public Property ContactNoProp() As String
        Get
            Return ContactNo
        End Get
        Set(ByVal value As String)
            ContactNo = value
        End Set
    End Property

    Public Sub AddStudent(tempcourse As Integer, tempsy As Integer, tempyl As String, tempstat As String)
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "INSERT INTO student (LName, FName, MName, Gender, DOB, ParentName, Address, ContactNo) VALUES 
                           (@LN, @FN, @MN, @G, @DOB, @PN, @Add, @CN); SELECT last_insert_id()"
        cmd.Parameters.AddWithValue("@LN", LastNameProp)
        cmd.Parameters.AddWithValue("@FN", FirstNameProp)
        cmd.Parameters.AddWithValue("@MN", MiddleNameProp)
        cmd.Parameters.AddWithValue("@G", GenderProp)
        cmd.Parameters.AddWithValue("@DOB", DOBProp)
        cmd.Parameters.AddWithValue("@PN", ParentNameProp)
        cmd.Parameters.AddWithValue("@Add", AddressProp)
        cmd.Parameters.AddWithValue("@CN", ContactNoProp)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                Dim scc As New StudentCourseClass
                scc.StudentID = dr(0)
                scc.StudentCourse = tempcourse
                scc.StudentSY = tempsy
                scc.StudentYearLevel = tempyl
                scc.StudentStatus = tempstat
                scc.AddStudCourse()
                MessageBox.Show("New student record was successfully added.")
            End While
        End If
        dbconn.Close()

    End Sub

    Public Function UpdateStudent(id As Integer, tidsy As Integer, tidcourse As Integer, tyl As String, tstat As String) As Integer
        dbconn.Open()
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        cmd.CommandText = "UPDATE student SET LName = @LN, FName = @FN, MName = @MN, 
                           Gender = @G, DOB = @DOB, ParentName = @PN, Address = @Add, 
                           ContactNo = @CN WHERE idstudent = @IDS"
        cmd.Parameters.AddWithValue("@LN", LastNameProp)
        cmd.Parameters.AddWithValue("@FN", FirstNameProp)
        cmd.Parameters.AddWithValue("@MN", MiddleNameProp)
        cmd.Parameters.AddWithValue("@G", GenderProp)
        cmd.Parameters.AddWithValue("@DOB", DOBProp)
        cmd.Parameters.AddWithValue("@PN", ParentNameProp)
        cmd.Parameters.AddWithValue("@Add", AddressProp)
        cmd.Parameters.AddWithValue("@CN", ContactNoProp)
        cmd.Parameters.AddWithValue("@IDS", id)

        If cmd.ExecuteNonQuery Then
            Dim scc As New StudentCourseClass
            scc.StudentCourse = tidcourse
            scc.StudentSY = tidsy
            scc.StudentYearLevel = tyl
            scc.StudentStatus = tstat
            scc.EditStudCourse(id)
            MessageBox.Show("Selected student record was successfully updated.")
            Return 1
        Else
            MessageBox.Show("Something went wrong. Try again.")
            Return 0
        End If
        dbconn.Close()
    End Function

    Public Function DeleteStudent(id As Integer) As Integer
        Try
            dbconn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = Conn
            cmd.CommandText = "DELETE FROM student WHERE idstudent = @IDS"
            cmd.Parameters.AddWithValue("@IDS", id)

            If cmd.ExecuteNonQuery Then
                MessageBox.Show("Selected student record was successfully deleted.")
                Return 1
            Else
                MessageBox.Show("Something went wrong. Try again.")
                Return 0
            End If
            dbconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return 0
    End Function
End Class
