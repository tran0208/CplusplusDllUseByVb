Imports System
Imports System.Runtime.InteropServices
 
Public Class Form

    <DllImport("dllTest.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function HelloWorld(ByVal x As Int32) As Int32
    End Function

    Private Declare Function HelloWorld Lib "dllTest.dll" (int) As Integer



    ' <DllImport("Math.dll", CallingConvention:= CallingConvention.Cdecl)> _
    ' Public Shared Function HelloWorld( ByVal x As Int32) As Int32 
    ' End Function

    'Private Declare Function HelloWorld Lib "Math.dll" (int) As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j

        j = HelloWorld(CInt(TextBox1.Text))
        TextBox2.Text = j
        
    End Sub
End Class
