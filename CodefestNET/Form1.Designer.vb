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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ControlPanel = New System.Windows.Forms.Panel
        Me.Bexit = New System.Windows.Forms.Button
        Me.Bmax = New System.Windows.Forms.Button
        Me.Bmin = New System.Windows.Forms.Button
        Me.ControlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlPanel.Controls.Add(Me.Bexit)
        Me.ControlPanel.Controls.Add(Me.Bmax)
        Me.ControlPanel.Controls.Add(Me.Bmin)
        Me.ControlPanel.Location = New System.Drawing.Point(862, 12)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(114, 38)
        Me.ControlPanel.TabIndex = 5
        '
        'Bexit
        '
        Me.Bexit.BackColor = System.Drawing.Color.Transparent
        Me.Bexit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Bexit.FlatAppearance.BorderSize = 2
        Me.Bexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Bexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Bexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bexit.ForeColor = System.Drawing.Color.White
        Me.Bexit.Image = CType(resources.GetObject("Bexit.Image"), System.Drawing.Image)
        Me.Bexit.Location = New System.Drawing.Point(79, 3)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(32, 32)
        Me.Bexit.TabIndex = 1
        Me.Bexit.UseVisualStyleBackColor = False
        '
        'Bmax
        '
        Me.Bmax.BackColor = System.Drawing.Color.Transparent
        Me.Bmax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Bmax.FlatAppearance.BorderSize = 2
        Me.Bmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Bmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Bmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmax.ForeColor = System.Drawing.Color.White
        Me.Bmax.Image = CType(resources.GetObject("Bmax.Image"), System.Drawing.Image)
        Me.Bmax.Location = New System.Drawing.Point(41, 3)
        Me.Bmax.Name = "Bmax"
        Me.Bmax.Size = New System.Drawing.Size(32, 32)
        Me.Bmax.TabIndex = 3
        Me.Bmax.UseVisualStyleBackColor = False
        '
        'Bmin
        '
        Me.Bmin.BackColor = System.Drawing.Color.Transparent
        Me.Bmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Bmin.FlatAppearance.BorderSize = 2
        Me.Bmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Bmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Bmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bmin.ForeColor = System.Drawing.Color.White
        Me.Bmin.Image = CType(resources.GetObject("Bmin.Image"), System.Drawing.Image)
        Me.Bmin.Location = New System.Drawing.Point(3, 3)
        Me.Bmin.Name = "Bmin"
        Me.Bmin.Size = New System.Drawing.Size(32, 32)
        Me.Bmin.TabIndex = 2
        Me.Bmin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(988, 547)
        Me.Controls.Add(Me.ControlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9
        Me.Text = "Form1"
        Me.ControlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlPanel As System.Windows.Forms.Panel
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bmax As System.Windows.Forms.Button
    Friend WithEvents Bmin As System.Windows.Forms.Button

End Class
