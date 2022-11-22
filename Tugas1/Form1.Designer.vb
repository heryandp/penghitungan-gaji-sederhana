<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInput))
        Me.lNama = New System.Windows.Forms.Label()
        Me.lNpm = New System.Windows.Forms.Label()
        Me.lKelas = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.tbNpm = New System.Windows.Forms.TextBox()
        Me.tbKelas = New System.Windows.Forms.TextBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lNama
        '
        resources.ApplyResources(Me.lNama, "lNama")
        Me.lNama.Name = "lNama"
        '
        'lNpm
        '
        resources.ApplyResources(Me.lNpm, "lNpm")
        Me.lNpm.Name = "lNpm"
        '
        'lKelas
        '
        resources.ApplyResources(Me.lKelas, "lKelas")
        Me.lKelas.Name = "lKelas"
        '
        'tbNama
        '
        resources.ApplyResources(Me.tbNama, "tbNama")
        Me.tbNama.Name = "tbNama"
        '
        'tbNpm
        '
        resources.ApplyResources(Me.tbNpm, "tbNpm")
        Me.tbNpm.Name = "tbNpm"
        '
        'tbKelas
        '
        resources.ApplyResources(Me.tbKelas, "tbKelas")
        Me.tbKelas.Name = "tbKelas"
        '
        'btnCetak
        '
        resources.ApplyResources(Me.btnCetak, "btnCetak")
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'fInput
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.tbKelas)
        Me.Controls.Add(Me.tbNpm)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.lKelas)
        Me.Controls.Add(Me.lNpm)
        Me.Controls.Add(Me.lNama)
        Me.MaximizeBox = False
        Me.Name = "fInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lNama As System.Windows.Forms.Label
    Friend WithEvents lNpm As System.Windows.Forms.Label
    Friend WithEvents lKelas As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents tbNpm As System.Windows.Forms.TextBox
    Friend WithEvents tbKelas As System.Windows.Forms.TextBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button

End Class
