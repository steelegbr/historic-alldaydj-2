Imports Bass = Un4seen.Bass.Bass

Public Class RecLoop

    Shared chunk As Long
    Shared rchan As Integer
    Declare Sub FillMemory Lib "kernel32.dll" Alias "RtlFillMemory" (ByVal Destination As Integer, ByVal length As Long, ByVal Fill As Byte)

    ' For playback system

    Shared Function stream(ByVal handle As Integer, ByVal buffer As IntPtr, ByVal length As Integer, ByVal user As Integer) As Integer

        Dim c As Integer
        Dim temp As IntPtr
        Dim tempb As Byte = 0
        temp = IntPtr.Zero

        ' check how much recorded data is buffered

        c = Bass.BASS_ChannelGetData(rchan, temp, Un4seen.Bass.BASSData.BASS_DATA_AVAILABLE)

        ' fetch recorded data into stream

        c = Bass.BASS_ChannelGetData(rchan, buffer, length)
        Return c

    End Function

    ' Set playout channel

    Shared Sub setPlayout(ByVal channel As Integer)
        rchan = channel
    End Sub

End Class
