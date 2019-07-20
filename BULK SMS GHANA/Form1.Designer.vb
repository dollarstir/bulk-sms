<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pmain = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcenter = New System.Windows.Forms.Panel()
        Me.pmain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pmain
        '
        Me.pmain.Controls.Add(Me.pcenter)
        Me.pmain.Controls.Add(Me.Panel1)
        Me.pmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pmain.Location = New System.Drawing.Point(0, 0)
        Me.pmain.Name = "pmain"
        Me.pmain.Size = New System.Drawing.Size(608, 470)
        Me.pmain.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 39)
        Me.Panel1.TabIndex = 0
        '
        'pcenter
        '
        Me.pcenter.BackColor = System.Drawing.Color.DarkKhaki
        Me.pcenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcenter.Location = New System.Drawing.Point(0, 39)
        Me.pcenter.Name = "pcenter"
        Me.pcenter.Size = New System.Drawing.Size(608, 431)
        Me.pcenter.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(608, 470)
        Me.Controls.Add(Me.pmain)
        Me.Name = "Form1"
        Me.Text = "BULK SMS GHANA"
        Me.pmain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pmain As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pcenter As Panel
End Class
