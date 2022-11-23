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
        Me.a = New System.Windows.Forms.Label()
        Me.NUPa = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUPb = New System.Windows.Forms.NumericUpDown()
        Me.b = New System.Windows.Forms.Label()
        Me.NUPc = New System.Windows.Forms.NumericUpDown()
        Me.c = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lx1 = New System.Windows.Forms.Label()
        Me.Lx2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.NUPa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUPc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'a
        '
        Me.a.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a.Location = New System.Drawing.Point(16, 9)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(92, 54)
        Me.a.TabIndex = 0
        Me.a.Text = "0"
        Me.a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NUPa
        '
        Me.NUPa.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPa.Location = New System.Drawing.Point(23, 66)
        Me.NUPa.Name = "NUPa"
        Me.NUPa.Size = New System.Drawing.Size(120, 44)
        Me.NUPa.TabIndex = 1
        Me.NUPa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "x²  +"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 54)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "x  +"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NUPb
        '
        Me.NUPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPb.Location = New System.Drawing.Point(180, 66)
        Me.NUPb.Name = "NUPb"
        Me.NUPb.Size = New System.Drawing.Size(120, 44)
        Me.NUPb.TabIndex = 4
        Me.NUPb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b.Location = New System.Drawing.Point(173, 9)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(92, 54)
        Me.b.TabIndex = 3
        Me.b.Text = "0"
        Me.b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NUPc
        '
        Me.NUPc.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPc.Location = New System.Drawing.Point(337, 66)
        Me.NUPc.Name = "NUPc"
        Me.NUPc.Size = New System.Drawing.Size(120, 44)
        Me.NUPc.TabIndex = 7
        Me.NUPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c
        '
        Me.c.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.Location = New System.Drawing.Point(342, 9)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(92, 54)
        Me.c.TabIndex = 6
        Me.c.Text = "0"
        Me.c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "x = "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lx1
        '
        Me.Lx1.BackColor = System.Drawing.SystemColors.Control
        Me.Lx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lx1.Location = New System.Drawing.Point(96, 135)
        Me.Lx1.Name = "Lx1"
        Me.Lx1.Size = New System.Drawing.Size(204, 54)
        Me.Lx1.TabIndex = 9
        Me.Lx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lx2
        '
        Me.Lx2.BackColor = System.Drawing.SystemColors.Control
        Me.Lx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lx2.Location = New System.Drawing.Point(96, 256)
        Me.Lx2.Name = "Lx2"
        Me.Lx2.Size = New System.Drawing.Size(204, 54)
        Me.Lx2.TabIndex = 11
        Me.Lx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 54)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "x = "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 172)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 54)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "or"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(468, 319)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lx2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Lx1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NUPc)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NUPb)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NUPa)
        Me.Controls.Add(Me.a)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Quadratic Solver"
        CType(Me.NUPa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUPc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents a As Label
    Friend WithEvents NUPa As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NUPb As NumericUpDown
    Friend WithEvents b As Label
    Friend WithEvents NUPc As NumericUpDown
    Friend WithEvents c As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lx1 As Label
    Friend WithEvents Lx2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
End Class
