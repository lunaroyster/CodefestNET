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
        Me.Bmin = New System.Windows.Forms.Button
        Me.Console = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Deb1 = New System.Windows.Forms.Button
        Me.Clear = New System.Windows.Forms.Button
        Me.ControlPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlPanel.Controls.Add(Me.Bexit)
        Me.ControlPanel.Controls.Add(Me.Bmin)
        Me.ControlPanel.Location = New System.Drawing.Point(884, 3)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(77, 38)
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
        Me.Bexit.Location = New System.Drawing.Point(41, 3)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(32, 32)
        Me.Bexit.TabIndex = 1
        Me.Bexit.UseVisualStyleBackColor = False
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
        'Console
        '
        Me.Console.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Console.BackColor = System.Drawing.Color.Black
        Me.Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Console.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Console.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Console.ForeColor = System.Drawing.Color.White
        Me.Console.Location = New System.Drawing.Point(12, 62)
        Me.Console.Multiline = True
        Me.Console.Name = "Console"
        Me.Console.ReadOnly = True
        Me.Console.Size = New System.Drawing.Size(964, 473)
        Me.Console.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Clear)
        Me.Panel1.Controls.Add(Me.Deb1)
        Me.Panel1.Controls.Add(Me.ControlPanel)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 44)
        Me.Panel1.TabIndex = 7
        '
        'Deb1
        '
        Me.Deb1.BackColor = System.Drawing.Color.Black
        Me.Deb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deb1.ForeColor = System.Drawing.Color.Transparent
        Me.Deb1.Location = New System.Drawing.Point(3, 11)
        Me.Deb1.Name = "Deb1"
        Me.Deb1.Size = New System.Drawing.Size(91, 23)
        Me.Deb1.TabIndex = 6
        Me.Deb1.Text = "Debug Button"
        Me.Deb1.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Black
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.ForeColor = System.Drawing.Color.Transparent
        Me.Clear.Location = New System.Drawing.Point(100, 11)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(91, 23)
        Me.Clear.TabIndex = 7
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(988, 547)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Console)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.9
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ControlPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ControlPanel As System.Windows.Forms.Panel
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents Bmin As System.Windows.Forms.Button
    Friend WithEvents Console As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Deb1 As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button

End Class
