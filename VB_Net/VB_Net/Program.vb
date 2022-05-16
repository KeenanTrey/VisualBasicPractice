Imports System
Imports System.Data.SqlClient

Module Program


    Sub Main(args As String())
        'Dim test2 As New Loops        
        'test2.Looping()
        Console.ForegroundColor = ConsoleColor.Blue

        Dim testObj As New ADO()
        Console.WriteLine("Choose Method: ")
        Console.WriteLine("1: Get Northwind Employee Names")
        Console.WriteLine("2: Insert Test Entry into Sample Database")
        Dim entry = Console.ReadLine()

        Select Case entry
            Case "1"
                testObj.GetName()
            Case "2"
                testObj.Insert("TEST101", "Testing VB With Parameters")
            Case Else
                Console.WriteLine("Must choose either 1 or 2")
        End Select

        Console.ForegroundColor = ConsoleColor.Black
        Console.ResetColor()
        Console.Read()
    End Sub
End Module
