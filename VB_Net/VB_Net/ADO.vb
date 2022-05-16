Imports System.Data
Imports System.Data.SqlClient

Public Class ADO
    'Let's test ADO database reader
    'Private cant be inside sub
    Private con As SqlConnection = New SqlConnection("Initial Catalog=Northwind;" &
 "Data Source=.;Integrated Security=true;")
    Private cmd As SqlCommand = con.CreateCommand
    Private reader As SqlDataReader
    Private result As String


    'Inserts
    Private con1 As SqlConnection = New SqlConnection("Initial Catalog=BAIS3150CodeSampleSystem;" &
 "Data Source=.;Integrated Security=true;")
    'Private cmd1 As SqlCommand = con.CreateCommand
    Private reader1 As SqlDataReader
    Private result1 As String

    Sub GetName()
        'Ensure this matches sql, will determine rows returned or 
        Dim counter = 0
        cmd.CommandText = "SELECT TOP(9) FirstName, LastName FROM Employees"

        con.Open()
        reader = cmd.ExecuteReader()

        Do While reader.Read()
            result = result & reader.GetString(0) & vbTab &
    reader.GetString(1) & vbLf

            counter = counter + 1
        Loop
        Console.WriteLine("{0}", result)
        Console.WriteLine("Counter: {0}", counter)
        con.Close()
    End Sub

    Sub Insert(programCode As String, description As String)
        Using cmd1 As New SqlCommand()
            With cmd1
                .Connection = con1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "AddProgram"
                .Parameters.AddWithValue("@ProgramCode", programCode)
                .Parameters.AddWithValue("@Description", description)
            End With
            Try
                con1.Open()
                cmd1.ExecuteNonQuery()
                con1.Close()
                Console.Write("Program Successfully Added")
                GetProgram(programCode)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                con1.Close()
            End Try
        End Using
    End Sub

    Sub GetProgram(programCode As String)
        Using getCMD As New SqlCommand()
            With getCMD
                .Connection = con1
                .CommandType = CommandType.StoredProcedure
                .CommandText = "GetProgram"
                .Parameters.AddWithValue("@ProgramCode", programCode)
            End With
            Try
                con1.Open()
                reader = getCMD.ExecuteReader()

                Do While reader.Read()
                    Console.WriteLine($"{reader.GetString(0)} Description: {reader.GetString(1)}")
                Loop
                con1.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                con1.Close()
            End Try
        End Using
    End Sub

End Class

