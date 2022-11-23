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
        Me.HSr = New System.Windows.Forms.HScrollBar()
        Me.Lr = New System.Windows.Forms.Label()
        Me.Lg = New System.Windows.Forms.Label()
        Me.HSg = New System.Windows.Forms.HScrollBar()
        Me.Lb = New System.Windows.Forms.Label()
        Me.HSb = New System.Windows.Forms.HScrollBar()
        Me.NUPr = New System.Windows.Forms.NumericUpDown()
        Me.NUPb = New System.Windows.Forms.NumericUpDown()
        Me.NUPg = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUPg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HSr
        '
        Me.HSr.Location = New System.Drawing.Point(114, 13)
        Me.HSr.Maximum = 255
        Me.HSr.Name = "HSr"
        Me.HSr.Size = New System.Drawing.Size(484, 57)
        Me.HSr.TabIndex = 0
        '
        'Lr
        '
        Me.Lr.BackColor = System.Drawing.Color.Red
        Me.Lr.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lr.Location = New System.Drawing.Point(12, 13)
        Me.Lr.Name = "Lr"
        Me.Lr.Size = New System.Drawing.Size(99, 57)
        Me.Lr.TabIndex = 1
        Me.Lr.Text = "0"
        Me.Lr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lr.UseCompatibleTextRendering = True
        '
        'Lg
        '
        Me.Lg.BackColor = System.Drawing.Color.Green
        Me.Lg.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lg.Location = New System.Drawing.Point(12, 127)
        Me.Lg.Name = "Lg"
        Me.Lg.Size = New System.Drawing.Size(99, 57)
        Me.Lg.TabIndex = 3
        Me.Lg.Text = "0"
        Me.Lg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lg.UseCompatibleTextRendering = True
        '
        'HSg
        '
        Me.HSg.Location = New System.Drawing.Point(114, 127)
        Me.HSg.Maximum = 255
        Me.HSg.Name = "HSg"
        Me.HSg.Size = New System.Drawing.Size(484, 57)
        Me.HSg.TabIndex = 2
        '
        'Lb
        '
        Me.Lb.BackColor = System.Drawing.Color.Blue
        Me.Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb.Location = New System.Drawing.Point(12, 70)
        Me.Lb.Name = "Lb"
        Me.Lb.Size = New System.Drawing.Size(99, 57)
        Me.Lb.TabIndex = 5
        Me.Lb.Text = "0"
        Me.Lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lb.UseCompatibleTextRendering = True
        '
        'HSb
        '
        Me.HSb.Location = New System.Drawing.Point(114, 70)
        Me.HSb.Maximum = 255
        Me.HSb.Name = "HSb"
        Me.HSb.Size = New System.Drawing.Size(484, 57)
        Me.HSb.TabIndex = 4
        '
        'NUPr
        '
        Me.NUPr.BackColor = System.Drawing.Color.Red
        Me.NUPr.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPr.Location = New System.Drawing.Point(734, 13)
        Me.NUPr.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUPr.Name = "NUPr"
        Me.NUPr.Size = New System.Drawing.Size(120, 57)
        Me.NUPr.TabIndex = 6
        Me.NUPr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUPb
        '
        Me.NUPb.BackColor = System.Drawing.Color.Blue
        Me.NUPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPb.Location = New System.Drawing.Point(734, 70)
        Me.NUPb.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUPb.Name = "NUPb"
        Me.NUPb.Size = New System.Drawing.Size(120, 57)
        Me.NUPb.TabIndex = 7
        Me.NUPb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NUPg
        '
        Me.NUPg.BackColor = System.Drawing.Color.Green
        Me.NUPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUPg.Location = New System.Drawing.Point(734, 127)
        Me.NUPg.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NUPg.Name = "NUPg"
        Me.NUPg.Size = New System.Drawing.Size(120, 57)
        Me.NUPg.TabIndex = 8
        Me.NUPg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(866, 371)
        Me.Controls.Add(Me.NUPg)
        Me.Controls.Add(Me.NUPb)
        Me.Controls.Add(Me.NUPr)
        Me.Controls.Add(Me.Lb)
        Me.Controls.Add(Me.HSb)
        Me.Controls.Add(Me.Lg)
        Me.Controls.Add(Me.HSg)
        Me.Controls.Add(Me.Lr)
        Me.Controls.Add(Me.HSr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Sliders 2: The Return"
        CType(Me.NUPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUPg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HSr As HScrollBar
    Friend WithEvents Lr As Label
    Friend WithEvents Lg As Label
    Friend WithEvents HSg As HScrollBar
    Friend WithEvents Lb As Label
    Friend WithEvents HSb As HScrollBar
    Friend WithEvents NUPr As NumericUpDown
    Friend WithEvents NUPb As NumericUpDown
    Friend WithEvents NUPg As NumericUpDown
End Class
