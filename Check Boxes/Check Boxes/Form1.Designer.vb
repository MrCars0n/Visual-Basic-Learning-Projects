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
        Me.chkUSA = New System.Windows.Forms.CheckBox()
        Me.chkUK = New System.Windows.Forms.CheckBox()
        Me.picUSA = New System.Windows.Forms.PictureBox()
        Me.picUK = New System.Windows.Forms.PictureBox()
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkUSA
        '
        Me.chkUSA.BackColor = System.Drawing.Color.Transparent
        Me.chkUSA.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUSA.Location = New System.Drawing.Point(20, 12)
        Me.chkUSA.Name = "chkUSA"
        Me.chkUSA.Size = New System.Drawing.Size(342, 60)
        Me.chkUSA.TabIndex = 0
        Me.chkUSA.Text = "Show Picture 1"
        Me.chkUSA.UseVisualStyleBackColor = False
        '
        'chkUK
        '
        Me.chkUK.BackColor = System.Drawing.Color.Transparent
        Me.chkUK.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUK.Location = New System.Drawing.Point(20, 78)
        Me.chkUK.Name = "chkUK"
        Me.chkUK.Size = New System.Drawing.Size(342, 60)
        Me.chkUK.TabIndex = 1
        Me.chkUK.Text = "Show Picture 2"
        Me.chkUK.UseVisualStyleBackColor = False
        '
        'picUSA
        '
        Me.picUSA.BackColor = System.Drawing.Color.Transparent
        Me.picUSA.Image = Global.Check_Boxes.My.Resources.Resources.USA
        Me.picUSA.Location = New System.Drawing.Point(12, 144)
        Me.picUSA.Name = "picUSA"
        Me.picUSA.Size = New System.Drawing.Size(167, 139)
        Me.picUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUSA.TabIndex = 2
        Me.picUSA.TabStop = False
        '
        'picUK
        '
        Me.picUK.BackColor = System.Drawing.Color.Transparent
        Me.picUK.Image = Global.Check_Boxes.My.Resources.Resources.UK
        Me.picUK.Location = New System.Drawing.Point(195, 144)
        Me.picUK.Name = "picUK"
        Me.picUK.Size = New System.Drawing.Size(167, 139)
        Me.picUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUK.TabIndex = 3
        Me.picUK.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Check_Boxes.My.Resources.Resources.PATTERN7
        Me.ClientSize = New System.Drawing.Size(366, 288)
        Me.Controls.Add(Me.picUK)
        Me.Controls.Add(Me.picUSA)
        Me.Controls.Add(Me.chkUK)
        Me.Controls.Add(Me.chkUSA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Check Boxes"
        CType(Me.picUSA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chkUSA As CheckBox
    Friend WithEvents chkUK As CheckBox
    Friend WithEvents picUSA As PictureBox
    Friend WithEvents picUK As PictureBox
End Class
