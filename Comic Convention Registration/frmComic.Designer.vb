<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComic))
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.grpBadge = New System.Windows.Forms.GroupBox()
        Me.rbConvention = New System.Windows.Forms.RadioButton()
        Me.rbCA = New System.Windows.Forms.RadioButton()
        Me.rbCSE = New System.Windows.Forms.RadioButton()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblCalcCost = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadge.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = CType(resources.GetObject("picComic.Image"), System.Drawing.Image)
        Me.picComic.Location = New System.Drawing.Point(-1, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(674, 142)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeader.ForeColor = System.Drawing.Color.Red
        Me.lblHeader.Location = New System.Drawing.Point(105, 160)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(508, 49)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Comic Convention Regisration"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGroup.ForeColor = System.Drawing.Color.Red
        Me.lblGroup.Location = New System.Drawing.Point(234, 236)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(101, 23)
        Me.lblGroup.TabIndex = 2
        Me.lblGroup.Text = "Group Size:"
        '
        'txtGroup
        '
        Me.txtGroup.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtGroup.Location = New System.Drawing.Point(334, 233)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(100, 24)
        Me.txtGroup.TabIndex = 0
        '
        'grpBadge
        '
        Me.grpBadge.BackColor = System.Drawing.Color.Cyan
        Me.grpBadge.Controls.Add(Me.rbConvention)
        Me.grpBadge.Controls.Add(Me.rbCA)
        Me.grpBadge.Controls.Add(Me.rbCSE)
        Me.grpBadge.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpBadge.ForeColor = System.Drawing.Color.Red
        Me.grpBadge.Location = New System.Drawing.Point(172, 272)
        Me.grpBadge.Name = "grpBadge"
        Me.grpBadge.Size = New System.Drawing.Size(365, 146)
        Me.grpBadge.TabIndex = 4
        Me.grpBadge.TabStop = False
        Me.grpBadge.Text = "Select Badge Types:"
        '
        'rbConvention
        '
        Me.rbConvention.AutoSize = True
        Me.rbConvention.Location = New System.Drawing.Point(41, 112)
        Me.rbConvention.Name = "rbConvention"
        Me.rbConvention.Size = New System.Drawing.Size(107, 27)
        Me.rbConvention.TabIndex = 2
        Me.rbConvention.TabStop = True
        Me.rbConvention.Text = "Convention"
        Me.rbConvention.UseVisualStyleBackColor = True
        '
        'rbCA
        '
        Me.rbCA.AutoSize = True
        Me.rbCA.Location = New System.Drawing.Point(41, 76)
        Me.rbCA.Name = "rbCA"
        Me.rbCA.Size = New System.Drawing.Size(219, 27)
        Me.rbCA.TabIndex = 1
        Me.rbCA.TabStop = True
        Me.rbCA.Text = "Convention + Autographs"
        Me.rbCA.UseVisualStyleBackColor = True
        '
        'rbCSE
        '
        Me.rbCSE.AutoSize = True
        Me.rbCSE.Location = New System.Drawing.Point(41, 38)
        Me.rbCSE.Name = "rbCSE"
        Me.rbCSE.Size = New System.Drawing.Size(300, 27)
        Me.rbCSE.TabIndex = 0
        Me.rbCSE.TabStop = True
        Me.rbCSE.Text = "Convention + Superhero Experience"
        Me.rbCSE.UseVisualStyleBackColor = True
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(172, 469)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(151, 23)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Registration Cost:"
        '
        'lblCalcCost
        '
        Me.lblCalcCost.AutoSize = True
        Me.lblCalcCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCalcCost.Location = New System.Drawing.Point(403, 469)
        Me.lblCalcCost.Name = "lblCalcCost"
        Me.lblCalcCost.Size = New System.Drawing.Size(88, 23)
        Me.lblCalcCost.TabIndex = 6
        Me.lblCalcCost.Text = "$0000.00"
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Cyan
        Me.btnCalc.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(172, 520)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(92, 39)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Cyan
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(401, 520)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 39)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 590)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblCalcCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBadge)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picComic)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "frmComic"
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadge.ResumeLayout(False)
        Me.grpBadge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents grpBadge As GroupBox
    Friend WithEvents rbConvention As RadioButton
    Friend WithEvents rbCA As RadioButton
    Friend WithEvents rbCSE As RadioButton
    Friend WithEvents lblCost As Label
    Friend WithEvents lblCalcCost As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
End Class
