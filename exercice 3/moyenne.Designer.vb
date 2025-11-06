<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class moyenne
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txt = New TextBox()
        btnenvoyer = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(24, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 38)
        Label1.TabIndex = 0
        Label1.Text = "Donner moyenne"
        ' 
        ' txt
        ' 
        txt.Location = New Point(278, 149)
        txt.Name = "txt"
        txt.Size = New Size(193, 27)
        txt.TabIndex = 1
        ' 
        ' btnenvoyer
        ' 
        btnenvoyer.Location = New Point(322, 234)
        btnenvoyer.Name = "btnenvoyer"
        btnenvoyer.Size = New Size(94, 29)
        btnenvoyer.TabIndex = 2
        btnenvoyer.Text = "envoyer"
        btnenvoyer.UseVisualStyleBackColor = True
        ' 
        ' moyenne
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnenvoyer)
        Controls.Add(txt)
        Controls.Add(Label1)
        Name = "moyenne"
        Text = "moyenne"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt As TextBox
    Friend WithEvents btnenvoyer As Button

End Class
