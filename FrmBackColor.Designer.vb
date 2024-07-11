<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackColor
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
        pWhite = New Panel()
        btnBACKCOLOR = New Button()
        lblRED = New Label()
        lblGREEN = New Label()
        lblBLUE = New Label()
        lbl255 = New Label()
        nudRED = New NumericUpDown()
        nudGREEN = New NumericUpDown()
        nudBLUE = New NumericUpDown()
        pRGB = New Panel()
        pBlack = New Panel()
        p224 = New Panel()
        pSilver = New Panel()
        pGray = New Panel()
        p64 = New Panel()
        pMaroon = New Panel()
        p1920 = New Panel()
        pRed = New Panel()
        p255128 = New Panel()
        p640 = New Panel()
        p255192 = New Panel()
        p128640 = New Panel()
        p192640 = New Panel()
        p2551280 = New Panel()
        p255192128 = New Panel()
        p12864 = New Panel()
        p255224192 = New Panel()
        pOlive = New Panel()
        p1921920 = New Panel()
        pYellow = New Panel()
        p255255128 = New Panel()
        p64640 = New Panel()
        p255255192 = New Panel()
        pGreen = New Panel()
        p01920 = New Panel()
        pLime = New Panel()
        p128255128 = New Panel()
        p0640 = New Panel()
        p192255192 = New Panel()
        pTeal = New Panel()
        p0192192 = New Panel()
        pCyan = New Panel()
        p128255255 = New Panel()
        p06464 = New Panel()
        p192255255 = New Panel()
        pNavy = New Panel()
        p00192 = New Panel()
        pBlue = New Panel()
        p128128255 = New Panel()
        p0064 = New Panel()
        p192192255 = New Panel()
        pPurple = New Panel()
        p1920192 = New Panel()
        pFuchsia = New Panel()
        p255128255 = New Panel()
        p64064 = New Panel()
        p255192255 = New Panel()
        CType(nudRED, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudGREEN, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBLUE, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pWhite
        ' 
        pWhite.BackColor = Color.White
        pWhite.BorderStyle = BorderStyle.Fixed3D
        pWhite.Location = New Point(16, 16)
        pWhite.Name = "pWhite"
        pWhite.Size = New Size(16, 16)
        pWhite.TabIndex = 0
        ' 
        ' btnBACKCOLOR
        ' 
        btnBACKCOLOR.BackColor = Color.White
        btnBACKCOLOR.Cursor = Cursors.Hand
        btnBACKCOLOR.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBACKCOLOR.ForeColor = Color.Navy
        btnBACKCOLOR.Location = New Point(328, 184)
        btnBACKCOLOR.Margin = New Padding(3, 0, 3, 3)
        btnBACKCOLOR.Name = "btnBACKCOLOR"
        btnBACKCOLOR.Size = New Size(32, 20)
        btnBACKCOLOR.TabIndex = 68
        btnBACKCOLOR.Text = "GO"
        btnBACKCOLOR.TextAlign = ContentAlignment.TopCenter
        btnBACKCOLOR.UseVisualStyleBackColor = False
        ' 
        ' lblRED
        ' 
        lblRED.AutoSize = True
        lblRED.BackColor = Color.Transparent
        lblRED.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblRED.ForeColor = Color.Red
        lblRED.Location = New Point(64, 160)
        lblRED.Name = "lblRED"
        lblRED.Size = New Size(62, 17)
        lblRED.TabIndex = 69
        lblRED.Text = "RGB - Red"
        ' 
        ' lblGREEN
        ' 
        lblGREEN.AutoSize = True
        lblGREEN.BackColor = Color.Transparent
        lblGREEN.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblGREEN.ForeColor = Color.Green
        lblGREEN.Location = New Point(144, 160)
        lblGREEN.Name = "lblGREEN"
        lblGREEN.Size = New Size(73, 17)
        lblGREEN.TabIndex = 71
        lblGREEN.Text = "RGB - Green"
        ' 
        ' lblBLUE
        ' 
        lblBLUE.AutoSize = True
        lblBLUE.BackColor = Color.Transparent
        lblBLUE.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBLUE.ForeColor = Color.Blue
        lblBLUE.Location = New Point(224, 160)
        lblBLUE.Name = "lblBLUE"
        lblBLUE.Size = New Size(66, 17)
        lblBLUE.TabIndex = 73
        lblBLUE.Text = "RGB - Blue"
        ' 
        ' lbl255
        ' 
        lbl255.AutoSize = True
        lbl255.BackColor = Color.Transparent
        lbl255.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbl255.ForeColor = Color.Navy
        lbl255.Location = New Point(8, 184)
        lbl255.Name = "lbl255"
        lbl255.Size = New Size(50, 17)
        lbl255.TabIndex = 74
        lbl255.Text = "0-255"
        ' 
        ' nudRED
        ' 
        nudRED.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudRED.Location = New Point(64, 182)
        nudRED.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudRED.Name = "nudRED"
        nudRED.Size = New Size(56, 24)
        nudRED.TabIndex = 75
        ' 
        ' nudGREEN
        ' 
        nudGREEN.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudGREEN.Location = New Point(144, 182)
        nudGREEN.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudGREEN.Name = "nudGREEN"
        nudGREEN.Size = New Size(56, 24)
        nudGREEN.TabIndex = 76
        ' 
        ' nudBLUE
        ' 
        nudBLUE.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudBLUE.Location = New Point(224, 182)
        nudBLUE.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        nudBLUE.Name = "nudBLUE"
        nudBLUE.Size = New Size(56, 24)
        nudBLUE.TabIndex = 77
        ' 
        ' pRGB
        ' 
        pRGB.BackColor = Color.Black
        pRGB.BorderStyle = BorderStyle.Fixed3D
        pRGB.Location = New Point(296, 182)
        pRGB.Name = "pRGB"
        pRGB.Size = New Size(24, 24)
        pRGB.TabIndex = 78
        ' 
        ' pBlack
        ' 
        pBlack.BackColor = Color.Black
        pBlack.BorderStyle = BorderStyle.Fixed3D
        pBlack.Location = New Point(16, 136)
        pBlack.Name = "pBlack"
        pBlack.Size = New Size(16, 16)
        pBlack.TabIndex = 79
        ' 
        ' p224
        ' 
        p224.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        p224.BorderStyle = BorderStyle.Fixed3D
        p224.Location = New Point(16, 40)
        p224.Name = "p224"
        p224.Size = New Size(16, 16)
        p224.TabIndex = 80
        ' 
        ' pSilver
        ' 
        pSilver.BackColor = Color.Silver
        pSilver.BorderStyle = BorderStyle.Fixed3D
        pSilver.Location = New Point(16, 64)
        pSilver.Name = "pSilver"
        pSilver.Size = New Size(16, 16)
        pSilver.TabIndex = 81
        ' 
        ' pGray
        ' 
        pGray.BackColor = Color.Gray
        pGray.BorderStyle = BorderStyle.Fixed3D
        pGray.Location = New Point(16, 88)
        pGray.Name = "pGray"
        pGray.Size = New Size(16, 16)
        pGray.TabIndex = 82
        ' 
        ' p64
        ' 
        p64.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        p64.BorderStyle = BorderStyle.Fixed3D
        p64.Location = New Point(16, 112)
        p64.Name = "p64"
        p64.Size = New Size(16, 16)
        p64.TabIndex = 83
        ' 
        ' pMaroon
        ' 
        pMaroon.BackColor = Color.Maroon
        pMaroon.BorderStyle = BorderStyle.Fixed3D
        pMaroon.Location = New Point(48, 112)
        pMaroon.Name = "pMaroon"
        pMaroon.Size = New Size(16, 16)
        pMaroon.TabIndex = 89
        ' 
        ' p1920
        ' 
        p1920.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        p1920.BorderStyle = BorderStyle.Fixed3D
        p1920.Location = New Point(48, 88)
        p1920.Name = "p1920"
        p1920.Size = New Size(16, 16)
        p1920.TabIndex = 88
        ' 
        ' pRed
        ' 
        pRed.BackColor = Color.Red
        pRed.BorderStyle = BorderStyle.Fixed3D
        pRed.Location = New Point(48, 64)
        pRed.Name = "pRed"
        pRed.Size = New Size(16, 16)
        pRed.TabIndex = 87
        ' 
        ' p255128
        ' 
        p255128.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        p255128.BorderStyle = BorderStyle.Fixed3D
        p255128.Location = New Point(48, 40)
        p255128.Name = "p255128"
        p255128.Size = New Size(16, 16)
        p255128.TabIndex = 86
        ' 
        ' p640
        ' 
        p640.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        p640.BorderStyle = BorderStyle.Fixed3D
        p640.Location = New Point(48, 136)
        p640.Name = "p640"
        p640.Size = New Size(16, 16)
        p640.TabIndex = 85
        ' 
        ' p255192
        ' 
        p255192.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        p255192.BorderStyle = BorderStyle.Fixed3D
        p255192.Location = New Point(48, 16)
        p255192.Name = "p255192"
        p255192.Size = New Size(16, 16)
        p255192.TabIndex = 84
        ' 
        ' p128640
        ' 
        p128640.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        p128640.BorderStyle = BorderStyle.Fixed3D
        p128640.Location = New Point(80, 112)
        p128640.Name = "p128640"
        p128640.Size = New Size(16, 16)
        p128640.TabIndex = 95
        ' 
        ' p192640
        ' 
        p192640.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        p192640.BorderStyle = BorderStyle.Fixed3D
        p192640.Location = New Point(80, 88)
        p192640.Name = "p192640"
        p192640.Size = New Size(16, 16)
        p192640.TabIndex = 94
        ' 
        ' p2551280
        ' 
        p2551280.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        p2551280.BorderStyle = BorderStyle.Fixed3D
        p2551280.Location = New Point(80, 64)
        p2551280.Name = "p2551280"
        p2551280.Size = New Size(16, 16)
        p2551280.TabIndex = 93
        ' 
        ' p255192128
        ' 
        p255192128.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        p255192128.BorderStyle = BorderStyle.Fixed3D
        p255192128.Location = New Point(80, 40)
        p255192128.Name = "p255192128"
        p255192128.Size = New Size(16, 16)
        p255192128.TabIndex = 92
        ' 
        ' p12864
        ' 
        p12864.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        p12864.BorderStyle = BorderStyle.Fixed3D
        p12864.Location = New Point(80, 136)
        p12864.Name = "p12864"
        p12864.Size = New Size(16, 16)
        p12864.TabIndex = 91
        ' 
        ' p255224192
        ' 
        p255224192.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        p255224192.BorderStyle = BorderStyle.Fixed3D
        p255224192.Location = New Point(80, 16)
        p255224192.Name = "p255224192"
        p255224192.Size = New Size(16, 16)
        p255224192.TabIndex = 90
        ' 
        ' pOlive
        ' 
        pOlive.BackColor = Color.Olive
        pOlive.BorderStyle = BorderStyle.Fixed3D
        pOlive.Location = New Point(112, 112)
        pOlive.Name = "pOlive"
        pOlive.Size = New Size(16, 16)
        pOlive.TabIndex = 101
        ' 
        ' p1921920
        ' 
        p1921920.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        p1921920.BorderStyle = BorderStyle.Fixed3D
        p1921920.Location = New Point(112, 88)
        p1921920.Name = "p1921920"
        p1921920.Size = New Size(16, 16)
        p1921920.TabIndex = 100
        ' 
        ' pYellow
        ' 
        pYellow.BackColor = Color.Yellow
        pYellow.BorderStyle = BorderStyle.Fixed3D
        pYellow.Location = New Point(112, 64)
        pYellow.Name = "pYellow"
        pYellow.Size = New Size(16, 16)
        pYellow.TabIndex = 99
        ' 
        ' p255255128
        ' 
        p255255128.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        p255255128.BorderStyle = BorderStyle.Fixed3D
        p255255128.Location = New Point(112, 40)
        p255255128.Name = "p255255128"
        p255255128.Size = New Size(16, 16)
        p255255128.TabIndex = 98
        ' 
        ' p64640
        ' 
        p64640.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        p64640.BorderStyle = BorderStyle.Fixed3D
        p64640.Location = New Point(112, 136)
        p64640.Name = "p64640"
        p64640.Size = New Size(16, 16)
        p64640.TabIndex = 97
        ' 
        ' p255255192
        ' 
        p255255192.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        p255255192.BorderStyle = BorderStyle.Fixed3D
        p255255192.Location = New Point(112, 16)
        p255255192.Name = "p255255192"
        p255255192.Size = New Size(16, 16)
        p255255192.TabIndex = 96
        ' 
        ' pGreen
        ' 
        pGreen.BackColor = Color.Green
        pGreen.BorderStyle = BorderStyle.Fixed3D
        pGreen.Location = New Point(144, 112)
        pGreen.Name = "pGreen"
        pGreen.Size = New Size(16, 16)
        pGreen.TabIndex = 107
        ' 
        ' p01920
        ' 
        p01920.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        p01920.BorderStyle = BorderStyle.Fixed3D
        p01920.Location = New Point(144, 88)
        p01920.Name = "p01920"
        p01920.Size = New Size(16, 16)
        p01920.TabIndex = 106
        ' 
        ' pLime
        ' 
        pLime.BackColor = Color.Lime
        pLime.BorderStyle = BorderStyle.Fixed3D
        pLime.Location = New Point(144, 64)
        pLime.Name = "pLime"
        pLime.Size = New Size(16, 16)
        pLime.TabIndex = 105
        ' 
        ' p128255128
        ' 
        p128255128.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        p128255128.BorderStyle = BorderStyle.Fixed3D
        p128255128.Location = New Point(144, 40)
        p128255128.Name = "p128255128"
        p128255128.Size = New Size(16, 16)
        p128255128.TabIndex = 104
        ' 
        ' p0640
        ' 
        p0640.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        p0640.BorderStyle = BorderStyle.Fixed3D
        p0640.Location = New Point(144, 136)
        p0640.Name = "p0640"
        p0640.Size = New Size(16, 16)
        p0640.TabIndex = 103
        ' 
        ' p192255192
        ' 
        p192255192.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        p192255192.BorderStyle = BorderStyle.Fixed3D
        p192255192.Location = New Point(144, 16)
        p192255192.Name = "p192255192"
        p192255192.Size = New Size(16, 16)
        p192255192.TabIndex = 102
        ' 
        ' pTeal
        ' 
        pTeal.BackColor = Color.Teal
        pTeal.BorderStyle = BorderStyle.Fixed3D
        pTeal.Location = New Point(176, 112)
        pTeal.Name = "pTeal"
        pTeal.Size = New Size(16, 16)
        pTeal.TabIndex = 113
        ' 
        ' p0192192
        ' 
        p0192192.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        p0192192.BorderStyle = BorderStyle.Fixed3D
        p0192192.Location = New Point(176, 88)
        p0192192.Name = "p0192192"
        p0192192.Size = New Size(16, 16)
        p0192192.TabIndex = 112
        ' 
        ' pCyan
        ' 
        pCyan.BackColor = Color.Cyan
        pCyan.BorderStyle = BorderStyle.Fixed3D
        pCyan.Location = New Point(176, 64)
        pCyan.Name = "pCyan"
        pCyan.Size = New Size(16, 16)
        pCyan.TabIndex = 111
        ' 
        ' p128255255
        ' 
        p128255255.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        p128255255.BorderStyle = BorderStyle.Fixed3D
        p128255255.Location = New Point(176, 40)
        p128255255.Name = "p128255255"
        p128255255.Size = New Size(16, 16)
        p128255255.TabIndex = 110
        ' 
        ' p06464
        ' 
        p06464.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        p06464.BorderStyle = BorderStyle.Fixed3D
        p06464.Location = New Point(176, 136)
        p06464.Name = "p06464"
        p06464.Size = New Size(16, 16)
        p06464.TabIndex = 109
        ' 
        ' p192255255
        ' 
        p192255255.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        p192255255.BorderStyle = BorderStyle.Fixed3D
        p192255255.Location = New Point(176, 16)
        p192255255.Name = "p192255255"
        p192255255.Size = New Size(16, 16)
        p192255255.TabIndex = 108
        ' 
        ' pNavy
        ' 
        pNavy.BackColor = Color.Navy
        pNavy.BorderStyle = BorderStyle.Fixed3D
        pNavy.Location = New Point(210, 114)
        pNavy.Name = "pNavy"
        pNavy.Size = New Size(16, 16)
        pNavy.TabIndex = 119
        ' 
        ' p00192
        ' 
        p00192.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        p00192.BorderStyle = BorderStyle.Fixed3D
        p00192.Location = New Point(210, 90)
        p00192.Name = "p00192"
        p00192.Size = New Size(16, 16)
        p00192.TabIndex = 118
        ' 
        ' pBlue
        ' 
        pBlue.BackColor = Color.Blue
        pBlue.BorderStyle = BorderStyle.Fixed3D
        pBlue.Location = New Point(210, 66)
        pBlue.Name = "pBlue"
        pBlue.Size = New Size(16, 16)
        pBlue.TabIndex = 117
        ' 
        ' p128128255
        ' 
        p128128255.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        p128128255.BorderStyle = BorderStyle.Fixed3D
        p128128255.Location = New Point(210, 42)
        p128128255.Name = "p128128255"
        p128128255.Size = New Size(16, 16)
        p128128255.TabIndex = 116
        ' 
        ' p0064
        ' 
        p0064.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        p0064.BorderStyle = BorderStyle.Fixed3D
        p0064.Location = New Point(210, 138)
        p0064.Name = "p0064"
        p0064.Size = New Size(16, 16)
        p0064.TabIndex = 115
        ' 
        ' p192192255
        ' 
        p192192255.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        p192192255.BorderStyle = BorderStyle.Fixed3D
        p192192255.Location = New Point(210, 18)
        p192192255.Name = "p192192255"
        p192192255.Size = New Size(16, 16)
        p192192255.TabIndex = 114
        ' 
        ' pPurple
        ' 
        pPurple.BackColor = Color.Purple
        pPurple.BorderStyle = BorderStyle.Fixed3D
        pPurple.Location = New Point(242, 114)
        pPurple.Name = "pPurple"
        pPurple.Size = New Size(16, 16)
        pPurple.TabIndex = 125
        ' 
        ' p1920192
        ' 
        p1920192.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        p1920192.BorderStyle = BorderStyle.Fixed3D
        p1920192.Location = New Point(242, 90)
        p1920192.Name = "p1920192"
        p1920192.Size = New Size(16, 16)
        p1920192.TabIndex = 124
        ' 
        ' pFuchsia
        ' 
        pFuchsia.BackColor = Color.Fuchsia
        pFuchsia.BorderStyle = BorderStyle.Fixed3D
        pFuchsia.Location = New Point(242, 66)
        pFuchsia.Name = "pFuchsia"
        pFuchsia.Size = New Size(16, 16)
        pFuchsia.TabIndex = 123
        ' 
        ' p255128255
        ' 
        p255128255.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        p255128255.BorderStyle = BorderStyle.Fixed3D
        p255128255.Location = New Point(242, 42)
        p255128255.Name = "p255128255"
        p255128255.Size = New Size(16, 16)
        p255128255.TabIndex = 122
        ' 
        ' p64064
        ' 
        p64064.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        p64064.BorderStyle = BorderStyle.Fixed3D
        p64064.Location = New Point(242, 138)
        p64064.Name = "p64064"
        p64064.Size = New Size(16, 16)
        p64064.TabIndex = 121
        ' 
        ' p255192255
        ' 
        p255192255.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        p255192255.BorderStyle = BorderStyle.Fixed3D
        p255192255.Location = New Point(242, 18)
        p255192255.Name = "p255192255"
        p255192255.Size = New Size(16, 16)
        p255192255.TabIndex = 120
        ' 
        ' FrmBackColor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 216)
        Controls.Add(pPurple)
        Controls.Add(p1920192)
        Controls.Add(pFuchsia)
        Controls.Add(p255128255)
        Controls.Add(p64064)
        Controls.Add(p255192255)
        Controls.Add(pNavy)
        Controls.Add(p00192)
        Controls.Add(pBlue)
        Controls.Add(p128128255)
        Controls.Add(p0064)
        Controls.Add(p192192255)
        Controls.Add(pTeal)
        Controls.Add(p0192192)
        Controls.Add(pCyan)
        Controls.Add(p128255255)
        Controls.Add(p06464)
        Controls.Add(p192255255)
        Controls.Add(pGreen)
        Controls.Add(p01920)
        Controls.Add(pLime)
        Controls.Add(p128255128)
        Controls.Add(p0640)
        Controls.Add(p192255192)
        Controls.Add(pOlive)
        Controls.Add(p1921920)
        Controls.Add(pYellow)
        Controls.Add(p255255128)
        Controls.Add(p64640)
        Controls.Add(p255255192)
        Controls.Add(p128640)
        Controls.Add(p192640)
        Controls.Add(p2551280)
        Controls.Add(p255192128)
        Controls.Add(p12864)
        Controls.Add(p255224192)
        Controls.Add(pMaroon)
        Controls.Add(p1920)
        Controls.Add(pRed)
        Controls.Add(p255128)
        Controls.Add(p640)
        Controls.Add(p255192)
        Controls.Add(p64)
        Controls.Add(pGray)
        Controls.Add(pSilver)
        Controls.Add(p224)
        Controls.Add(pBlack)
        Controls.Add(pRGB)
        Controls.Add(nudBLUE)
        Controls.Add(nudGREEN)
        Controls.Add(nudRED)
        Controls.Add(lbl255)
        Controls.Add(lblBLUE)
        Controls.Add(lblGREEN)
        Controls.Add(lblRED)
        Controls.Add(btnBACKCOLOR)
        Controls.Add(pWhite)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmBackColor"
        TopMost = True
        CType(nudRED, ComponentModel.ISupportInitialize).EndInit()
        CType(nudGREEN, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBLUE, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pWhite As Panel
    Friend WithEvents btnBACKCOLOR As Button
    Friend WithEvents lblRED As Label
    Friend WithEvents lblGREEN As Label
    Friend WithEvents lblBLUE As Label
    Friend WithEvents lbl255 As Label
    Friend WithEvents nudRED As NumericUpDown
    Friend WithEvents nudGREEN As NumericUpDown
    Friend WithEvents nudBLUE As NumericUpDown
    Friend WithEvents pRGB As Panel
    Friend WithEvents pBlack As Panel
    Friend WithEvents p224 As Panel
    Friend WithEvents pSilver As Panel
    Friend WithEvents pGray As Panel
    Friend WithEvents p64 As Panel
    Friend WithEvents pMaroon As Panel
    Friend WithEvents p1920 As Panel
    Friend WithEvents pRed As Panel
    Friend WithEvents p255128 As Panel
    Friend WithEvents p640 As Panel
    Friend WithEvents p255192 As Panel
    Friend WithEvents p128640 As Panel
    Friend WithEvents p192640 As Panel
    Friend WithEvents p2551280 As Panel
    Friend WithEvents p255192128 As Panel
    Friend WithEvents p12864 As Panel
    Friend WithEvents p255224192 As Panel
    Friend WithEvents pOlive As Panel
    Friend WithEvents p1921920 As Panel
    Friend WithEvents pYellow As Panel
    Friend WithEvents p255255128 As Panel
    Friend WithEvents p64640 As Panel
    Friend WithEvents p255255192 As Panel
    Friend WithEvents pGreen As Panel
    Friend WithEvents p01920 As Panel
    Friend WithEvents pLime As Panel
    Friend WithEvents p128255128 As Panel
    Friend WithEvents p0640 As Panel
    Friend WithEvents p192255192 As Panel
    Friend WithEvents pTeal As Panel
    Friend WithEvents p0192192 As Panel
    Friend WithEvents pCyan As Panel
    Friend WithEvents p128255255 As Panel
    Friend WithEvents p06464 As Panel
    Friend WithEvents p192255255 As Panel
    Friend WithEvents pNavy As Panel
    Friend WithEvents p00192 As Panel
    Friend WithEvents pBlue As Panel
    Friend WithEvents p128128255 As Panel
    Friend WithEvents p0064 As Panel
    Friend WithEvents p192192255 As Panel
    Friend WithEvents pPurple As Panel
    Friend WithEvents p1920192 As Panel
    Friend WithEvents pFuchsia As Panel
    Friend WithEvents p255128255 As Panel
    Friend WithEvents p64064 As Panel
    Friend WithEvents p255192255 As Panel
End Class
