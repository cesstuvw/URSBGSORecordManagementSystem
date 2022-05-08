'Imports System.Windows.Forms
'Imports System.Drawing
'Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Module CustomizedButton
    Public Class CustomButton
        Inherits Button

        Private borderSize As Integer = 0
        Private borderRadius As Integer = 20
        Private borderColor As Color = Color.PaleVioletRed

        <Category("RJ Code Advance")>
        Public Property BorderSizes As Integer
            Get
                Return borderSize
            End Get
            Set(ByVal value As Integer)
                borderSize = value
                Me.Invalidate()
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property BorderRadiuss As Integer
            Get
                Return borderRadius
            End Get
            Set(ByVal value As Integer)
                borderRadius = value
                Me.Invalidate()
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property BorderColorr As Color
            Get
                Return borderColor
            End Get
            Set(ByVal value As Color)
                borderColor = value
                Me.Invalidate()
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property BackgroundColor As Color
            Get
                Return Me.BackColor
            End Get
            Set(ByVal value As Color)
                Me.BackColor = value
            End Set
        End Property

        <Category("RJ Code Advance")>
        Public Property TextColor As Color
            Get
                Return Me.ForeColor
            End Get
            Set(ByVal value As Color)
                Me.ForeColor = value
            End Set
        End Property
    End Class


End Module
