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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Paddle = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.brickSwitchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paddle
        '
        Me.Paddle.BackColor = System.Drawing.Color.Transparent
        Me.Paddle.Image = Global.Brick_Breaker.My.Resources.Resources.Paddle
        Me.Paddle.Location = New System.Drawing.Point(406, 740)
        Me.Paddle.Name = "Paddle"
        Me.Paddle.Size = New System.Drawing.Size(202, 70)
        Me.Paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Paddle.TabIndex = 0
        Me.Paddle.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.Transparent
        Me.Ball.Image = Global.Brick_Breaker.My.Resources.Resources.DVD_Logo1
        Me.Ball.Location = New System.Drawing.Point(531, 521)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(77, 56)
        Me.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ball.TabIndex = 1
        Me.Ball.TabStop = False
        '
        'brickSwitchTimer
        '
        Me.brickSwitchTimer.Enabled = True
        Me.brickSwitchTimer.Interval = 1000
        '
        'animationTimer
        '
        Me.animationTimer.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Brick_Breaker.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1499, 861)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.Paddle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brick Breaker"
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Paddle As PictureBox
    Friend WithEvents Ball As PictureBox
    Friend WithEvents brickSwitchTimer As Timer
    Friend WithEvents animationTimer As Timer
End Class
