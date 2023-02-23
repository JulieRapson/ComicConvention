<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.picComicPic = New System.Windows.Forms.PictureBox()
        Me.lblComicTitle = New System.Windows.Forms.Label()
        Me.lblGroupSz = New System.Windows.Forms.Label()
        Me.txtGroupAmt = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radCon = New System.Windows.Forms.RadioButton()
        Me.radConAutographs = New System.Windows.Forms.RadioButton()
        Me.radConSuper = New System.Windows.Forms.RadioButton()
        Me.lblRegCost = New System.Windows.Forms.Label()
        Me.lblRegCostCalc = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComicPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComicPic
        '
        Me.picComicPic.Image = Global.ComicConvention.My.Resources.Resources.comic
        Me.picComicPic.Location = New System.Drawing.Point(-1, 0)
        Me.picComicPic.Name = "picComicPic"
        Me.picComicPic.Size = New System.Drawing.Size(753, 208)
        Me.picComicPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComicPic.TabIndex = 0
        Me.picComicPic.TabStop = False
        '
        'lblComicTitle
        '
        Me.lblComicTitle.AutoSize = True
        Me.lblComicTitle.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicTitle.ForeColor = System.Drawing.Color.Firebrick
        Me.lblComicTitle.Location = New System.Drawing.Point(99, 233)
        Me.lblComicTitle.Name = "lblComicTitle"
        Me.lblComicTitle.Size = New System.Drawing.Size(552, 51)
        Me.lblComicTitle.TabIndex = 1
        Me.lblComicTitle.Text = "Comic Convention Registration"
        '
        'lblGroupSz
        '
        Me.lblGroupSz.AutoSize = True
        Me.lblGroupSz.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSz.ForeColor = System.Drawing.Color.Firebrick
        Me.lblGroupSz.Location = New System.Drawing.Point(252, 311)
        Me.lblGroupSz.Name = "lblGroupSz"
        Me.lblGroupSz.Size = New System.Drawing.Size(132, 30)
        Me.lblGroupSz.TabIndex = 2
        Me.lblGroupSz.Text = "Group Size:"
        '
        'txtGroupAmt
        '
        Me.txtGroupAmt.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupAmt.ForeColor = System.Drawing.Color.Firebrick
        Me.txtGroupAmt.Location = New System.Drawing.Point(425, 311)
        Me.txtGroupAmt.Name = "txtGroupAmt"
        Me.txtGroupAmt.Size = New System.Drawing.Size(73, 37)
        Me.txtGroupAmt.TabIndex = 3
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadgeType.Controls.Add(Me.radCon)
        Me.grpBadgeType.Controls.Add(Me.radConAutographs)
        Me.grpBadgeType.Controls.Add(Me.radConSuper)
        Me.grpBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Firebrick
        Me.grpBadgeType.Location = New System.Drawing.Point(143, 375)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(465, 134)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radCon
        '
        Me.radCon.AutoSize = True
        Me.radCon.Location = New System.Drawing.Point(23, 97)
        Me.radCon.Name = "radCon"
        Me.radCon.Size = New System.Drawing.Size(107, 27)
        Me.radCon.TabIndex = 2
        Me.radCon.TabStop = True
        Me.radCon.Text = "Convention"
        Me.radCon.UseVisualStyleBackColor = True
        '
        'radConAutographs
        '
        Me.radConAutographs.AutoSize = True
        Me.radConAutographs.Location = New System.Drawing.Point(23, 63)
        Me.radConAutographs.Name = "radConAutographs"
        Me.radConAutographs.Size = New System.Drawing.Size(219, 27)
        Me.radConAutographs.TabIndex = 1
        Me.radConAutographs.TabStop = True
        Me.radConAutographs.Text = "Convention + Autographs"
        Me.radConAutographs.UseVisualStyleBackColor = True
        '
        'radConSuper
        '
        Me.radConSuper.AutoSize = True
        Me.radConSuper.Location = New System.Drawing.Point(23, 30)
        Me.radConSuper.Name = "radConSuper"
        Me.radConSuper.Size = New System.Drawing.Size(300, 27)
        Me.radConSuper.TabIndex = 0
        Me.radConSuper.TabStop = True
        Me.radConSuper.Text = "Convention + Superhero Experience"
        Me.radConSuper.UseVisualStyleBackColor = True
        '
        'lblRegCost
        '
        Me.lblRegCost.AutoSize = True
        Me.lblRegCost.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblRegCost.Location = New System.Drawing.Point(191, 534)
        Me.lblRegCost.Name = "lblRegCost"
        Me.lblRegCost.Size = New System.Drawing.Size(226, 35)
        Me.lblRegCost.TabIndex = 5
        Me.lblRegCost.Text = "Registration Cost:"
        '
        'lblRegCostCalc
        '
        Me.lblRegCostCalc.AutoSize = True
        Me.lblRegCostCalc.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCostCalc.ForeColor = System.Drawing.Color.Firebrick
        Me.lblRegCostCalc.Location = New System.Drawing.Point(469, 534)
        Me.lblRegCostCalc.Name = "lblRegCostCalc"
        Me.lblRegCostCalc.Size = New System.Drawing.Size(90, 35)
        Me.lblRegCostCalc.TabIndex = 6
        Me.lblRegCostCalc.Text = "Label1"
        Me.lblRegCostCalc.Visible = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(176, 590)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(149, 38)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(426, 590)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 38)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 658)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblRegCostCalc)
        Me.Controls.Add(Me.lblRegCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupAmt)
        Me.Controls.Add(Me.lblGroupSz)
        Me.Controls.Add(Me.lblComicTitle)
        Me.Controls.Add(Me.picComicPic)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.picComicPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComicPic As PictureBox
    Friend WithEvents lblComicTitle As Label
    Friend WithEvents lblGroupSz As Label
    Friend WithEvents txtGroupAmt As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radCon As RadioButton
    Friend WithEvents radConAutographs As RadioButton
    Friend WithEvents radConSuper As RadioButton
    Friend WithEvents lblRegCost As Label
    Friend WithEvents lblRegCostCalc As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
End Class
