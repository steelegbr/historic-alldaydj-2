Public Class InstantPlayer

    Inherits Player

    ' Constructor

    Public Sub New(ByVal sound_card As Integer, ByVal pan As Integer, ByVal volume As Integer)

        MyBase.New(sound_card, pan, volume)

    End Sub

    ' Load an item

    Public Overloads Sub loadItem(ByRef item As AudioItem)

        MyBase.loadItem(item, False)

    End Sub

    ' Play an item

    Public Overloads Sub play(ByVal override As Boolean)

        MyBase.play(override)
        frmMain.getMC.fadeDown()

    End Sub

End Class
