Module Round
    Public Sub roundedFORM(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None
        'obj.Opacity = 1
        obj.AllowTransparency = True
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 25, 25), 180, 90)
        DGP.AddLine(25, 0, obj.Width - 25, 0)
        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 25, 0, 25, 25), -90, 90)
        DGP.AddLine(obj.Width, 25, obj.Width, obj.Height - 25)
        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 25, obj.Height - 25, 25, 25), 0, 90)
        DGP.AddLine(obj.Width - 25, obj.Height, 25, obj.Height)
        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 25, 25, 25), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Public Sub roundedBTN(obj As Button)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)
        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)
        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)
        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Public Sub roundedPANEL(obj As Panel)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 25, 25), 180, 90)
        DGP.AddLine(25, 0, obj.Width - 25, 0)
        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, 0, 30, 30), -90, 90)
        DGP.AddLine(obj.Width, 30, obj.Width, obj.Height - 30)
        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, obj.Height - 30, 30, 30), 0, 90)
        DGP.AddLine(obj.Width - 30, obj.Height, 30, obj.Height)
        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 25, 25, 25), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Public Sub roundedPANELIN(obj As Panel)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 25, 25), 180, 90)
        DGP.AddLine(25, 0, obj.Width - 25, 0)
        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, 0, 30, 30), -90, 90)
        DGP.AddLine(obj.Width, 30, obj.Width, obj.Height - 30)
        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 30, obj.Height - 30, 30, 30), 0, 90)
        DGP.AddLine(obj.Width - 30, obj.Height, 30, obj.Height)
        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 25, 25, 25), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub
End Module
