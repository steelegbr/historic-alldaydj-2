Imports Bass = Un4seen.Bass.Bass    ' Bass sound system reference
Imports FX = Un4seen.Bass.AddOn.Fx  ' BassFX

Public Class Player

    Private sound_card As Integer
    Private pan As Integer
    Private volume As Integer
    Private item As AudioItem
    Private is_playing As Boolean
    Private channel As Long

    ' Constructor

    Public Sub New(ByVal sound_card As Integer, ByVal pan As Integer, ByVal volume As Integer)

        ' Set values for playback

        Me.sound_card = sound_card
        Me.pan = pan
        Me.volume = volume
        Me.is_playing = False

    End Sub

    ' Load an item

    Public Sub loadItem(ByRef item As AudioItem, Optional ByVal auto_unload As Boolean = True)

        On Error Resume Next

        ' Break check

        Dim bi As BreakItem = Nothing
        bi = item

        If (Not bi Is Nothing) Then
            Me.item = item
            Me.is_playing = False
            Me.channel = -1
            Exit Sub
        End If

        ' Otherwise

        item.loadTrack(Me.sound_card, Me.pan, Me.volume, auto_unload)
        Me.item = item
        Me.is_playing = False
        Me.channel = Me.item.getPlayoutChannel

    End Sub

    ' Unload an item

    Public Sub unloadItem()

        On Error Resume Next

        If is_playing Then
            Me.item.unloadTrack()
        End If
        Me.item = Nothing
        Me.is_playing = False

    End Sub

    ' Play the item

    Public Sub play(ByVal override As Boolean)

        Dim position As Long
        Dim channel As Integer

        ' Get the channel

        channel = Me.channel

        ' Check the item is not already playing

        If (Me.is_playing) And (Bass.BASS_ChannelIsActive(channel)) And Not override Then
            Exit Sub
        End If

        ' Leave if the item has not been properly loaded

        'If (me.channel = 0) Then
        'Exit Sub
        Me.item.loadTrack(Me.sound_card, Me.pan, Me.volume)
        Me.channel = Me.item.getPlayoutChannel
        channel = Me.channel
        'End If

        ' Now go ahead and play the item

        Me.applyAGC()
        Me.applyCompression()
        If (Not Bass.BASS_ChannelPlay(channel, False)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If
        position = Bass.BASS_ChannelSeconds2Bytes(channel, Me.item.getTimeStartTrack)
        If (Not Bass.BASS_ChannelSetPosition(channel, position)) Then
            'MsgBox("Bass error " & Bass.BASS_ErrorGetCode & ".", MsgBoxStyle.Exclamation, "Error")
        End If
        Me.is_playing = True

        ' Note that the item is being played

        Me.item.setPlayed(True)

    End Sub

    ' Stop the item

    Public Sub stopPlayback(ByVal fade_time As Integer, ByVal wait As Boolean)

        Dim level As Integer = 1

        ' Leave if the item is nothing

        If (Me.item Is Nothing) Then
            Exit Sub
        End If

        ' Fade out and only wait if we have to

        Bass.BASS_ChannelSlideAttributes(Me.item.getPlayoutChannel, -1, -2, -101, fade_time)

        If wait Then
            While level > 0
                level = Un4seen.Bass.Utils.HighWord(Bass.BASS_ChannelGetLevel(Me.item.getPlayoutChannel))
            End While
        End If

        ' Stop the channel completely

        Me.is_playing = False
        'Me.unloadItem()

    End Sub

    ' Return the item in the player (for processing)

    Public Function getItem() As AudioItem
        Return Me.item
    End Function

    ' Apply AGC to the channel

    Private Sub applyAGC()

        Dim channel As Integer
        Dim agc As New FX.BASS_FX_DSPDAMP

        ' Obtain the settings

        channel = Me.item.getPlayoutChannel
        agc = General.program_settings.getAGC

        ' Apply the settings

        If (General.program_settings.getApplyAGC) Then
            FX.BassFx.BASS_FX_DSP_Set(channel, FX.BASSFXDsp.BASS_FX_DSPFX_DAMP, 1)
            FX.BassFx.BASS_FX_DSP_SetParameters(channel, agc)
        End If

    End Sub

    ' Apply compression to the channel

    Private Sub applyCompressor()

        Dim channel As Integer
        Dim compressor As New FX.BASS_FX_DSPCOMPRESSOR

        ' Obtain the settings

        channel = Me.item.getPlayoutChannel
        compressor = General.program_settings.getCompressor

        ' Apply the settings

        If (General.program_settings.getApplyCompressor) Then
            FX.BassFx.BASS_FX_DSP_Set(channel, FX.BASSFXDsp.BASS_FX_DSPFX_COMPRESSOR, 2)
            FX.BassFx.BASS_FX_DSP_SetParameters(channel, compressor)
        End If

    End Sub

    ' Set the item

    Public Sub setItem(ByRef item As AudioItem, Optional ByVal player_number As Integer = -1, Optional ByVal is_playing As Boolean = False)

        Me.item = item

        If (Not item Is Nothing) Then
            Me.item.setPlayerTag(player_number)
            Me.is_playing = is_playing
            Me.channel = item.getPlayoutChannel
        Else
            Me.unloadItem()
        End If

    End Sub

    ' Apply compression to the channel

    Public Sub applyCompression()

        Me.applyCompressor()

    End Sub

    ' Gets the time left

    Public Function getTimeLeft() As Integer

        Return (Me.getItem.getTimeEndTrack - Bass.BASS_ChannelBytes2Seconds(Me.getItem.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.getItem.getPlayoutChannel)))

    End Function

    ' Gets the current position

    Public Function getCurrentTime() As Integer

        Return (Bass.BASS_ChannelBytes2Seconds(Me.getItem.getPlayoutChannel, Bass.BASS_ChannelGetPosition(Me.getItem.getPlayoutChannel)) - Me.getItem.getTimeStartTrack)

    End Function

    ' Checks if the player is playing

    Public Function getIsPlaying() As Boolean

        Return Me.is_playing

    End Function

    ' Get volume

    Public Function getVolume() As Integer

        Dim frequency As Integer
        Dim volume As Integer
        Dim pan As Integer

        Bass.BASS_ChannelGetAttributes(Integer.Parse(Me.channel.ToString), frequency, volume, pan)
        Return volume

    End Function

    ' Set the volume

    Public Sub setVolume(ByVal volume As Integer)

        Me.volume = volume
        Bass.BASS_ChannelSlideAttributes(Me.channel, -1, volume, -101, 10)

    End Sub

    ' Gets the volume levels

    Public Function getLeftVolumeLevel() As Integer

        Return Un4seen.Bass.Utils.LowWord(Bass.BASS_ChannelGetLevel(Me.channel))

    End Function

    Public Function getRightVolumeLevel() As Integer

        Return Un4seen.Bass.Utils.HighWord(Bass.BASS_ChannelGetLevel(Me.channel))

    End Function

End Class
