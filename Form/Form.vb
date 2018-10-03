Imports System
Imports System.Runtime.InteropServices
 
Public Class Form

    <DllImport("dllTest.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function HelloWorld(ByVal x As Int32) As Int32
    End Function 
    Private Declare Function HelloWorld Lib "dllTest.dll" (int) As Integer




    <DllImport("dllTest.dll", CallingConvention:=CallingConvention.Cdecl)> _
    Public Shared Function compute(ByVal x As double) As double
    End Function 
    Private Declare Function compute Lib "dllTest.dll" (float) As double




 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j

        'j = HelloWorld(CInt(TextBox1.Text))
        j = compute(Convert.ToDouble( "0" + TextBox1.Text ))
        TextBox2.Text = j
        
    End Sub
End Class
