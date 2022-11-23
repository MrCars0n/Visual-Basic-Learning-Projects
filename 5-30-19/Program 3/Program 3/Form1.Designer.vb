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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Inches = New System.Windows.Forms.RadioButton()
        Me.Feet = New System.Windows.Forms.RadioButton()
        Me.yards = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Inches
        '
        Me.Inches.AutoSize = True
        Me.Inches.Location = New System.Drawing.Point(12, 40)
        Me.Inches.Name = "Inches"
        Me.Inches.Size = New System.Drawing.Size(57, 17)
        Me.Inches.TabIndex = 1
        Me.Inches.TabStop = True
        Me.Inches.Text = "Inches"
        Me.Inches.UseVisualStyleBackColor = True
        '
        'Feet
        '
        Me.Feet.AutoSize = True
        Me.Feet.Location = New System.Drawing.Point(12, 63)
        Me.Feet.Name = "Feet"
        Me.Feet.Size = New System.Drawing.Size(46, 17)
        Me.Feet.TabIndex = 2
        Me.Feet.TabStop = True
        Me.Feet.Text = "Feet"
        Me.Feet.UseVisualStyleBackColor = True
        '
        'yards
        '
        Me.yards.AutoSize = True
        Me.yards.Location = New System.Drawing.Point(12, 86)
        Me.yards.Name = "yards"
        Me.yards.Size = New System.Drawing.Size(52, 17)
        Me.yards.TabIndex = 3
        Me.yards.TabStop = True
        Me.yards.Text = "Yards"
        Me.yards.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.yards)
        Me.Controls.Add(Me.Feet)
        Me.Controls.Add(Me.Inches)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Program 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Inches As RadioButton
    Friend WithEvents Feet As RadioButton
    Friend WithEvents yards As RadioButton
    Friend WithEvents Label1 As Label
End Class
