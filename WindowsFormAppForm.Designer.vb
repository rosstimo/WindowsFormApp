<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowsFormAppForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.UserInputLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(104, 90)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(200, 121)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(355, 90)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(197, 121)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.Location = New System.Drawing.Point(104, 58)
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.Size = New System.Drawing.Size(448, 26)
        Me.UserInputTextBox.TabIndex = 0
        '
        'UserInputLabel
        '
        Me.UserInputLabel.AutoSize = True
        Me.UserInputLabel.Location = New System.Drawing.Point(12, 61)
        Me.UserInputLabel.Name = "UserInputLabel"
        Me.UserInputLabel.Size = New System.Drawing.Size(86, 20)
        Me.UserInputLabel.TabIndex = 3
        Me.UserInputLabel.Text = "Enter Text:"
        '
        'WindowsFormAppForm
        '
        Me.AcceptButton = Me.GoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(624, 275)
        Me.Controls.Add(Me.UserInputLabel)
        Me.Controls.Add(Me.UserInputTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "WindowsFormAppForm"
        Me.Text = "My Cool Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInputTextBox As TextBox
    Friend WithEvents UserInputLabel As Label
End Class
