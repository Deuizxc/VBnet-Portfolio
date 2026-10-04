Public Class BaseForm
    Inherits Form

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Automatically wire up hover and click sounds for every form that inherits this
        AudioManager.AttachSounds(Me)
    End Sub
End Class