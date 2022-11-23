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
        Me.LBname = New System.Windows.Forms.Label()
        Me.LBmedium = New System.Windows.Forms.Label()
        Me.RBmedium = New System.Windows.Forms.RadioButton()
        Me.RBlarge = New System.Windows.Forms.RadioButton()
        Me.LBlarge = New System.Windows.Forms.Label()
        Me.LBamerican = New System.Windows.Forms.Label()
        Me.RBamerican = New System.Windows.Forms.RadioButton()
        Me.PBPizza = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.LBdrinks = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTcompleteorder = New System.Windows.Forms.Button()
        Me.LBsubtotal = New System.Windows.Forms.Label()
        Me.LBsubtotalnum = New System.Windows.Forms.Label()
        Me.LBsalestaxnum = New System.Windows.Forms.Label()
        Me.LBsalestax = New System.Windows.Forms.Label()
        Me.LBfinaltotalnum = New System.Windows.Forms.Label()
        Me.LBfinaltotal = New System.Windows.Forms.Label()
        CType(Me.PBPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBname
        '
        Me.LBname.Font = New System.Drawing.Font("Viner Hand ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBname.Location = New System.Drawing.Point(314, 12)
        Me.LBname.Name = "LBname"
        Me.LBname.Size = New System.Drawing.Size(411, 68)
        Me.LBname.TabIndex = 1
        Me.LBname.Text = "Lé Chef Carson's"
        Me.LBname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBmedium
        '
        Me.LBmedium.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBmedium.Location = New System.Drawing.Point(12, 247)
        Me.LBmedium.Name = "LBmedium"
        Me.LBmedium.Size = New System.Drawing.Size(152, 47)
        Me.LBmedium.TabIndex = 2
        Me.LBmedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBmedium
        '
        Me.RBmedium.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBmedium.BackColor = System.Drawing.Color.Green
        Me.RBmedium.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBmedium.Location = New System.Drawing.Point(15, 250)
        Me.RBmedium.Name = "RBmedium"
        Me.RBmedium.Size = New System.Drawing.Size(146, 41)
        Me.RBmedium.TabIndex = 3
        Me.RBmedium.TabStop = True
        Me.RBmedium.Text = "Medium ($6)"
        Me.RBmedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RBmedium.UseVisualStyleBackColor = False
        '
        'RBlarge
        '
        Me.RBlarge.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBlarge.BackColor = System.Drawing.Color.White
        Me.RBlarge.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBlarge.Location = New System.Drawing.Point(15, 297)
        Me.RBlarge.Name = "RBlarge"
        Me.RBlarge.Size = New System.Drawing.Size(146, 41)
        Me.RBlarge.TabIndex = 5
        Me.RBlarge.TabStop = True
        Me.RBlarge.Text = "Large ($8)"
        Me.RBlarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RBlarge.UseVisualStyleBackColor = False
        '
        'LBlarge
        '
        Me.LBlarge.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBlarge.Location = New System.Drawing.Point(12, 294)
        Me.LBlarge.Name = "LBlarge"
        Me.LBlarge.Size = New System.Drawing.Size(152, 47)
        Me.LBlarge.TabIndex = 4
        Me.LBlarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBamerican
        '
        Me.LBamerican.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.LBamerican.Location = New System.Drawing.Point(12, 341)
        Me.LBamerican.Name = "LBamerican"
        Me.LBamerican.Size = New System.Drawing.Size(152, 47)
        Me.LBamerican.TabIndex = 6
        Me.LBamerican.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RBamerican
        '
        Me.RBamerican.Appearance = System.Windows.Forms.Appearance.Button
        Me.RBamerican.BackColor = System.Drawing.Color.Red
        Me.RBamerican.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RBamerican.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBamerican.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RBamerican.Location = New System.Drawing.Point(15, 344)
        Me.RBamerican.Name = "RBamerican"
        Me.RBamerican.Size = New System.Drawing.Size(146, 41)
        Me.RBamerican.TabIndex = 7
        Me.RBamerican.TabStop = True
        Me.RBamerican.Text = "American ($10)"
        Me.RBamerican.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RBamerican.UseVisualStyleBackColor = False
        '
        'PBPizza
        '
        Me.PBPizza.Image = Global.Pizza_Restraunt.My.Resources.Resources.pizza
        Me.PBPizza.Location = New System.Drawing.Point(12, 12)
        Me.PBPizza.Name = "PBPizza"
        Me.PBPizza.Size = New System.Drawing.Size(247, 232)
        Me.PBPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPizza.TabIndex = 0
        Me.PBPizza.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(321, 83)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 29)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Sausage"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(321, 118)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(130, 29)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Mushrooms"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(321, 153)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(118, 29)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "Pepperoni"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(321, 188)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(105, 29)
        Me.CheckBox4.TabIndex = 11
        Me.CheckBox4.Text = "Pinapple"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(321, 223)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(151, 29)
        Me.CheckBox5.TabIndex = 12
        Me.CheckBox5.Text = "Green Pepper"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(321, 301)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(133, 29)
        Me.CheckBox6.TabIndex = 13
        Me.CheckBox6.Text = "The Works"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'LBdrinks
        '
        Me.LBdrinks.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBdrinks.Location = New System.Drawing.Point(477, 85)
        Me.LBdrinks.Name = "LBdrinks"
        Me.LBdrinks.Size = New System.Drawing.Size(155, 23)
        Me.LBdrinks.TabIndex = 14
        Me.LBdrinks.Text = "# of Drinks"
        Me.LBdrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(638, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTcompleteorder
        '
        Me.BTcompleteorder.BackColor = System.Drawing.Color.IndianRed
        Me.BTcompleteorder.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTcompleteorder.Location = New System.Drawing.Point(508, 217)
        Me.BTcompleteorder.Name = "BTcompleteorder"
        Me.BTcompleteorder.Size = New System.Drawing.Size(230, 40)
        Me.BTcompleteorder.TabIndex = 16
        Me.BTcompleteorder.Text = "Complete Order"
        Me.BTcompleteorder.UseVisualStyleBackColor = False
        '
        'LBsubtotal
        '
        Me.LBsubtotal.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBsubtotal.Location = New System.Drawing.Point(491, 280)
        Me.LBsubtotal.Name = "LBsubtotal"
        Me.LBsubtotal.Size = New System.Drawing.Size(155, 23)
        Me.LBsubtotal.TabIndex = 17
        Me.LBsubtotal.Text = "Subtotal"
        Me.LBsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBsubtotalnum
        '
        Me.LBsubtotalnum.BackColor = System.Drawing.Color.White
        Me.LBsubtotalnum.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBsubtotalnum.Location = New System.Drawing.Point(652, 278)
        Me.LBsubtotalnum.Name = "LBsubtotalnum"
        Me.LBsubtotalnum.Size = New System.Drawing.Size(100, 29)
        Me.LBsubtotalnum.TabIndex = 18
        Me.LBsubtotalnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBsalestaxnum
        '
        Me.LBsalestaxnum.BackColor = System.Drawing.Color.White
        Me.LBsalestaxnum.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBsalestaxnum.Location = New System.Drawing.Point(652, 313)
        Me.LBsalestaxnum.Name = "LBsalestaxnum"
        Me.LBsalestaxnum.Size = New System.Drawing.Size(100, 29)
        Me.LBsalestaxnum.TabIndex = 20
        Me.LBsalestaxnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBsalestax
        '
        Me.LBsalestax.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBsalestax.Location = New System.Drawing.Point(491, 315)
        Me.LBsalestax.Name = "LBsalestax"
        Me.LBsalestax.Size = New System.Drawing.Size(155, 23)
        Me.LBsalestax.TabIndex = 19
        Me.LBsalestax.Text = "Sales Tax"
        Me.LBsalestax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBfinaltotalnum
        '
        Me.LBfinaltotalnum.BackColor = System.Drawing.Color.White
        Me.LBfinaltotalnum.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBfinaltotalnum.Location = New System.Drawing.Point(652, 352)
        Me.LBfinaltotalnum.Name = "LBfinaltotalnum"
        Me.LBfinaltotalnum.Size = New System.Drawing.Size(100, 29)
        Me.LBfinaltotalnum.TabIndex = 22
        Me.LBfinaltotalnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBfinaltotal
        '
        Me.LBfinaltotal.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBfinaltotal.Location = New System.Drawing.Point(491, 354)
        Me.LBfinaltotal.Name = "LBfinaltotal"
        Me.LBfinaltotal.Size = New System.Drawing.Size(155, 23)
        Me.LBfinaltotal.TabIndex = 21
        Me.LBfinaltotal.Text = "Final Total"
        Me.LBfinaltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(771, 393)
        Me.Controls.Add(Me.LBfinaltotalnum)
        Me.Controls.Add(Me.LBfinaltotal)
        Me.Controls.Add(Me.LBsalestaxnum)
        Me.Controls.Add(Me.LBsalestax)
        Me.Controls.Add(Me.LBsubtotalnum)
        Me.Controls.Add(Me.LBsubtotal)
        Me.Controls.Add(Me.BTcompleteorder)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LBdrinks)
        Me.Controls.Add(Me.CheckBox6)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RBamerican)
        Me.Controls.Add(Me.LBamerican)
        Me.Controls.Add(Me.RBlarge)
        Me.Controls.Add(Me.LBlarge)
        Me.Controls.Add(Me.RBmedium)
        Me.Controls.Add(Me.LBmedium)
        Me.Controls.Add(Me.LBname)
        Me.Controls.Add(Me.PBPizza)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Super Italian Bros"
        CType(Me.PBPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBPizza As PictureBox
    Friend WithEvents LBname As Label
    Friend WithEvents LBmedium As Label
    Friend WithEvents RBmedium As RadioButton
    Friend WithEvents RBlarge As RadioButton
    Friend WithEvents LBlarge As Label
    Friend WithEvents RBamerican As RadioButton
    Friend WithEvents LBamerican As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents LBdrinks As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTcompleteorder As Button
    Friend WithEvents LBsubtotal As Label
    Friend WithEvents LBsubtotalnum As Label
    Friend WithEvents LBsalestaxnum As Label
    Friend WithEvents LBsalestax As Label
    Friend WithEvents LBfinaltotalnum As Label
    Friend WithEvents LBfinaltotal As Label
End Class
