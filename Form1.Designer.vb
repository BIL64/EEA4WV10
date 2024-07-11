<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pARK = New Panel()
        rtbARK = New RichTextBox()
        a4wMenyStrip = New MenuStrip()
        tsmSTART = New ToolStripMenuItem()
        tsmiNew = New ToolStripMenuItem()
        tsmiOpen = New ToolStripMenuItem()
        tsmiSave = New ToolStripMenuItem()
        tsmiSA = New ToolStripMenuItem()
        tsmiLatest = New ToolStripMenuItem()
        tsmiCLatest = New ToolStripMenuItem()
        tsmiPP = New ToolStripMenuItem()
        tsmiPrint = New ToolStripMenuItem()
        tsmiINITpos = New ToolStripMenuItem()
        tsmiExit = New ToolStripMenuItem()
        tsmEDIT = New ToolStripMenuItem()
        tsmiUndo = New ToolStripMenuItem()
        tsmiRedo = New ToolStripMenuItem()
        tssCopy = New ToolStripSeparator()
        tsmiCopy = New ToolStripMenuItem()
        tsmiCut = New ToolStripMenuItem()
        tsmiPaste = New ToolStripMenuItem()
        tsmiSelectall = New ToolStripMenuItem()
        tsmiDeselectall = New ToolStripMenuItem()
        tsmiClearall = New ToolStripMenuItem()
        tssSearch = New ToolStripSeparator()
        tsmiSearch = New ToolStripMenuItem()
        tsmiReplace = New ToolStripMenuItem()
        tsmFORMAT = New ToolStripMenuItem()
        tsmiFont = New ToolStripMenuItem()
        tsmiFColor = New ToolStripMenuItem()
        tsmiBColor = New ToolStripMenuItem()
        tsmiA4BColor = New ToolStripMenuItem()
        tsmiCap = New ToolStripMenuItem()
        tsmiLow = New ToolStripMenuItem()
        tssAlignL = New ToolStripSeparator()
        tsmiAlignL = New ToolStripMenuItem()
        tsmiAlignC = New ToolStripMenuItem()
        tsmiAlignR = New ToolStripMenuItem()
        tsmiAlignJ = New ToolStripMenuItem()
        tssSpacing = New ToolStripSeparator()
        tsmiSpacing = New ToolStripMenuItem()
        tsmOBJECT = New ToolStripMenuItem()
        tsmiImageL = New ToolStripMenuItem()
        tsmiBrowser = New ToolStripMenuItem()
        tsmiBulletl = New ToolStripMenuItem()
        tsmiNumberl = New ToolStripMenuItem()
        tsmiIndent = New ToolStripMenuItem()
        tsmiTab = New ToolStripMenuItem()
        tsmiSymbol = New ToolStripMenuItem()
        tsmiEncoding = New ToolStripMenuItem()
        tsmiTXTsizefont = New ToolStripMenuItem()
        tsmiA4S = New ToolStripMenuItem()
        tsmiRecreate = New ToolStripMenuItem()
        a4wFontDialog = New FontDialog()
        btnSNITT = New Button()
        nudLEFT = New NumericUpDown()
        nudRIGHT = New NumericUpDown()
        lblLeft = New Label()
        lblRight = New Label()
        nudTOP = New NumericUpDown()
        nudBOTTOM = New NumericUpDown()
        lblTop = New Label()
        lblBottom = New Label()
        btnCT = New Button()
        btnCY = New Button()
        btnPT = New Button()
        pbEE = New PictureBox()
        a4wPrintDialog = New PrintDialog()
        a4wPrintDocument = New Printing.PrintDocument()
        btnRA4 = New Button()
        pbAU = New PictureBox()
        pbAD = New PictureBox()
        tbBROWS = New TextBox()
        btnLEFT = New Button()
        btnOPEN = New Button()
        btnSAVE = New Button()
        btnSAVEAS = New Button()
        btnPREVIEW = New Button()
        btnPRINT = New Button()
        tbSNITT = New TextBox()
        btnCENTER = New Button()
        btnRIGHT = New Button()
        btnOWN = New Button()
        btnUO = New Button()
        btnRO = New Button()
        a4wOpenFileDialog = New OpenFileDialog()
        a4wSaveFileDialog = New SaveFileDialog()
        btnBL = New Button()
        btnLOUT = New Button()
        btnREPLACE = New Button()
        btnSEARCH = New Button()
        btnLIN = New Button()
        a4wToolTip = New ToolTip(components)
        btnRIN = New Button()
        btnROUT = New Button()
        btnRESETINDENT = New Button()
        btnIMAGE = New Button()
        rbL = New RadioButton()
        rbC = New RadioButton()
        rbR = New RadioButton()
        btnFORMAT = New Button()
        tbPAGES = New TextBox()
        btnJUST = New Button()
        btnCOLOR = New Button()
        btnBCOLOR = New Button()
        btnSUP = New Button()
        btnB = New Button()
        btnU = New Button()
        btnI = New Button()
        btnS = New Button()
        btnSPACE = New Button()
        nudSL = New NumericUpDown()
        btnNL = New Button()
        btnOHM = New Button()
        btnSELECTALL = New Button()
        btnDESELECTALL = New Button()
        btnINDENTBL = New Button()
        btnSTYLENL = New Button()
        btnTAB = New Button()
        btnINDENT = New Button()
        imgOpenFileDialog = New OpenFileDialog()
        a4wPrintPreviewDialog = New PrintPreviewDialog()
        pARK.SuspendLayout()
        a4wMenyStrip.SuspendLayout()
        CType(nudLEFT, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudRIGHT, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTOP, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBOTTOM, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEE, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbAU, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbAD, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSL, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pARK
        ' 
        pARK.BackColor = Color.White
        pARK.BorderStyle = BorderStyle.FixedSingle
        pARK.Controls.Add(rtbARK)
        pARK.Location = New Point(8, 104)
        pARK.Name = "pARK"
        pARK.Size = New Size(760, 336)
        pARK.TabIndex = 0
        ' 
        ' rtbARK
        ' 
        rtbARK.Font = New Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        rtbARK.HideSelection = False
        rtbARK.ImeMode = ImeMode.NoControl
        rtbARK.Location = New Point(72, 40)
        rtbARK.Name = "rtbARK"
        rtbARK.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbARK.Size = New Size(648, 256)
        rtbARK.TabIndex = 0
        rtbARK.Text = ""
        ' 
        ' a4wMenyStrip
        ' 
        a4wMenyStrip.Items.AddRange(New ToolStripItem() {tsmSTART, tsmEDIT, tsmFORMAT, tsmOBJECT})
        a4wMenyStrip.Location = New Point(0, 0)
        a4wMenyStrip.Name = "a4wMenyStrip"
        a4wMenyStrip.Size = New Size(820, 25)
        a4wMenyStrip.TabIndex = 1
        a4wMenyStrip.Text = "MenuStrip1"
        ' 
        ' tsmSTART
        ' 
        tsmSTART.BackColor = SystemColors.Control
        tsmSTART.DropDownItems.AddRange(New ToolStripItem() {tsmiNew, tsmiOpen, tsmiSave, tsmiSA, tsmiLatest, tsmiCLatest, tsmiPP, tsmiPrint, tsmiINITpos, tsmiExit})
        tsmSTART.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        tsmSTART.ForeColor = SystemColors.WindowFrame
        tsmSTART.Name = "tsmSTART"
        tsmSTART.Size = New Size(60, 21)
        tsmSTART.Text = "START"
        ' 
        ' tsmiNew
        ' 
        tsmiNew.BackColor = Color.LightCyan
        tsmiNew.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiNew.ForeColor = Color.Indigo
        tsmiNew.Name = "tsmiNew"
        tsmiNew.Size = New Size(180, 22)
        tsmiNew.Text = "New"
        ' 
        ' tsmiOpen
        ' 
        tsmiOpen.BackColor = Color.LightCyan
        tsmiOpen.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiOpen.Name = "tsmiOpen"
        tsmiOpen.Size = New Size(180, 22)
        tsmiOpen.Text = "Open File"
        ' 
        ' tsmiSave
        ' 
        tsmiSave.BackColor = Color.LightCyan
        tsmiSave.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSave.Name = "tsmiSave"
        tsmiSave.Size = New Size(180, 22)
        tsmiSave.Text = "Save File"
        ' 
        ' tsmiSA
        ' 
        tsmiSA.BackColor = Color.LightCyan
        tsmiSA.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSA.Name = "tsmiSA"
        tsmiSA.Size = New Size(180, 22)
        tsmiSA.Text = "Save As..."
        ' 
        ' tsmiLatest
        ' 
        tsmiLatest.BackColor = Color.LightCyan
        tsmiLatest.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiLatest.ForeColor = Color.Indigo
        tsmiLatest.Name = "tsmiLatest"
        tsmiLatest.Size = New Size(180, 22)
        tsmiLatest.Text = "Open Job"
        ' 
        ' tsmiCLatest
        ' 
        tsmiCLatest.BackColor = Color.LightCyan
        tsmiCLatest.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiCLatest.ForeColor = Color.Indigo
        tsmiCLatest.Name = "tsmiCLatest"
        tsmiCLatest.Size = New Size(180, 22)
        tsmiCLatest.Text = "Clear All Jobs"
        ' 
        ' tsmiPP
        ' 
        tsmiPP.BackColor = Color.LightCyan
        tsmiPP.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiPP.Name = "tsmiPP"
        tsmiPP.Size = New Size(180, 22)
        tsmiPP.Text = "Preview Print"
        ' 
        ' tsmiPrint
        ' 
        tsmiPrint.BackColor = Color.LightCyan
        tsmiPrint.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiPrint.Name = "tsmiPrint"
        tsmiPrint.Size = New Size(180, 22)
        tsmiPrint.Text = "Print"
        ' 
        ' tsmiINITpos
        ' 
        tsmiINITpos.BackColor = Color.LightCyan
        tsmiINITpos.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiINITpos.ForeColor = Color.Indigo
        tsmiINITpos.Name = "tsmiINITpos"
        tsmiINITpos.Size = New Size(180, 22)
        tsmiINITpos.Text = "Save Init Position"
        ' 
        ' tsmiExit
        ' 
        tsmiExit.BackColor = Color.LightCyan
        tsmiExit.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        tsmiExit.Name = "tsmiExit"
        tsmiExit.Size = New Size(180, 22)
        tsmiExit.Text = "Close"
        ' 
        ' tsmEDIT
        ' 
        tsmEDIT.BackColor = SystemColors.Control
        tsmEDIT.DropDownItems.AddRange(New ToolStripItem() {tsmiUndo, tsmiRedo, tssCopy, tsmiCopy, tsmiCut, tsmiPaste, tsmiSelectall, tsmiDeselectall, tsmiClearall, tssSearch, tsmiSearch, tsmiReplace})
        tsmEDIT.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        tsmEDIT.ForeColor = SystemColors.WindowFrame
        tsmEDIT.Name = "tsmEDIT"
        tsmEDIT.Size = New Size(49, 21)
        tsmEDIT.Text = "EDIT"
        ' 
        ' tsmiUndo
        ' 
        tsmiUndo.BackColor = Color.LightCyan
        tsmiUndo.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiUndo.Name = "tsmiUndo"
        tsmiUndo.Size = New Size(143, 22)
        tsmiUndo.Text = "Undo"
        ' 
        ' tsmiRedo
        ' 
        tsmiRedo.BackColor = Color.LightCyan
        tsmiRedo.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiRedo.Name = "tsmiRedo"
        tsmiRedo.Size = New Size(143, 22)
        tsmiRedo.Text = "Redo"
        ' 
        ' tssCopy
        ' 
        tssCopy.BackColor = Color.LightCyan
        tssCopy.ForeColor = SystemColors.ActiveCaptionText
        tssCopy.Name = "tssCopy"
        tssCopy.Size = New Size(140, 6)
        ' 
        ' tsmiCopy
        ' 
        tsmiCopy.BackColor = Color.LightCyan
        tsmiCopy.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiCopy.Name = "tsmiCopy"
        tsmiCopy.Size = New Size(143, 22)
        tsmiCopy.Text = "Copy"
        ' 
        ' tsmiCut
        ' 
        tsmiCut.BackColor = Color.LightCyan
        tsmiCut.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiCut.Name = "tsmiCut"
        tsmiCut.Size = New Size(143, 22)
        tsmiCut.Text = "Cut"
        ' 
        ' tsmiPaste
        ' 
        tsmiPaste.BackColor = Color.LightCyan
        tsmiPaste.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiPaste.Name = "tsmiPaste"
        tsmiPaste.Size = New Size(143, 22)
        tsmiPaste.Text = "Paste"
        ' 
        ' tsmiSelectall
        ' 
        tsmiSelectall.BackColor = Color.LightCyan
        tsmiSelectall.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSelectall.ForeColor = SystemColors.ControlText
        tsmiSelectall.Name = "tsmiSelectall"
        tsmiSelectall.Size = New Size(143, 22)
        tsmiSelectall.Text = "Select All"
        ' 
        ' tsmiDeselectall
        ' 
        tsmiDeselectall.BackColor = Color.LightCyan
        tsmiDeselectall.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiDeselectall.ForeColor = SystemColors.ControlText
        tsmiDeselectall.Name = "tsmiDeselectall"
        tsmiDeselectall.Size = New Size(143, 22)
        tsmiDeselectall.Text = "Deselect All"
        ' 
        ' tsmiClearall
        ' 
        tsmiClearall.BackColor = Color.LightCyan
        tsmiClearall.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiClearall.ForeColor = Color.Indigo
        tsmiClearall.Name = "tsmiClearall"
        tsmiClearall.Size = New Size(143, 22)
        tsmiClearall.Text = "Clear All"
        ' 
        ' tssSearch
        ' 
        tssSearch.Name = "tssSearch"
        tssSearch.Size = New Size(140, 6)
        ' 
        ' tsmiSearch
        ' 
        tsmiSearch.BackColor = Color.LightCyan
        tsmiSearch.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSearch.Name = "tsmiSearch"
        tsmiSearch.Size = New Size(143, 22)
        tsmiSearch.Text = "Search"
        ' 
        ' tsmiReplace
        ' 
        tsmiReplace.BackColor = Color.LightCyan
        tsmiReplace.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiReplace.Name = "tsmiReplace"
        tsmiReplace.Size = New Size(143, 22)
        tsmiReplace.Text = "Replace"
        ' 
        ' tsmFORMAT
        ' 
        tsmFORMAT.BackColor = SystemColors.Control
        tsmFORMAT.DropDownItems.AddRange(New ToolStripItem() {tsmiFont, tsmiFColor, tsmiBColor, tsmiA4BColor, tsmiCap, tsmiLow, tssAlignL, tsmiAlignL, tsmiAlignC, tsmiAlignR, tsmiAlignJ, tssSpacing, tsmiSpacing})
        tsmFORMAT.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        tsmFORMAT.ForeColor = SystemColors.WindowFrame
        tsmFORMAT.Name = "tsmFORMAT"
        tsmFORMAT.Size = New Size(74, 21)
        tsmFORMAT.Text = "FORMAT"
        ' 
        ' tsmiFont
        ' 
        tsmiFont.BackColor = Color.LightCyan
        tsmiFont.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiFont.Name = "tsmiFont"
        tsmiFont.Size = New Size(181, 22)
        tsmiFont.Text = "Select Font"
        ' 
        ' tsmiFColor
        ' 
        tsmiFColor.BackColor = Color.LightCyan
        tsmiFColor.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiFColor.Name = "tsmiFColor"
        tsmiFColor.Size = New Size(181, 22)
        tsmiFColor.Text = "Text Color"
        ' 
        ' tsmiBColor
        ' 
        tsmiBColor.BackColor = Color.LightCyan
        tsmiBColor.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiBColor.Name = "tsmiBColor"
        tsmiBColor.Size = New Size(181, 22)
        tsmiBColor.Text = "Text Back Color"
        ' 
        ' tsmiA4BColor
        ' 
        tsmiA4BColor.BackColor = Color.LightCyan
        tsmiA4BColor.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiA4BColor.ForeColor = Color.Indigo
        tsmiA4BColor.Name = "tsmiA4BColor"
        tsmiA4BColor.Size = New Size(181, 22)
        tsmiA4BColor.Text = "Background Color"
        ' 
        ' tsmiCap
        ' 
        tsmiCap.BackColor = Color.LightCyan
        tsmiCap.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiCap.ForeColor = Color.Indigo
        tsmiCap.Name = "tsmiCap"
        tsmiCap.Size = New Size(181, 22)
        tsmiCap.Text = "Capitalize All"
        ' 
        ' tsmiLow
        ' 
        tsmiLow.BackColor = Color.LightCyan
        tsmiLow.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiLow.ForeColor = Color.Indigo
        tsmiLow.Name = "tsmiLow"
        tsmiLow.Size = New Size(181, 22)
        tsmiLow.Text = "Lower Case All"
        ' 
        ' tssAlignL
        ' 
        tssAlignL.Name = "tssAlignL"
        tssAlignL.Size = New Size(178, 6)
        ' 
        ' tsmiAlignL
        ' 
        tsmiAlignL.BackColor = Color.LightCyan
        tsmiAlignL.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiAlignL.Name = "tsmiAlignL"
        tsmiAlignL.Size = New Size(181, 22)
        tsmiAlignL.Text = "Align Left"
        ' 
        ' tsmiAlignC
        ' 
        tsmiAlignC.BackColor = Color.LightCyan
        tsmiAlignC.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiAlignC.Name = "tsmiAlignC"
        tsmiAlignC.Size = New Size(181, 22)
        tsmiAlignC.Text = "Align Center"
        ' 
        ' tsmiAlignR
        ' 
        tsmiAlignR.BackColor = Color.LightCyan
        tsmiAlignR.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiAlignR.Name = "tsmiAlignR"
        tsmiAlignR.Size = New Size(181, 22)
        tsmiAlignR.Text = "Align Right"
        ' 
        ' tsmiAlignJ
        ' 
        tsmiAlignJ.BackColor = Color.LightCyan
        tsmiAlignJ.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiAlignJ.Name = "tsmiAlignJ"
        tsmiAlignJ.Size = New Size(181, 22)
        tsmiAlignJ.Text = "Align Justify"
        ' 
        ' tssSpacing
        ' 
        tssSpacing.Name = "tssSpacing"
        tssSpacing.Size = New Size(178, 6)
        ' 
        ' tsmiSpacing
        ' 
        tsmiSpacing.BackColor = Color.LightCyan
        tsmiSpacing.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSpacing.ForeColor = Color.Indigo
        tsmiSpacing.Name = "tsmiSpacing"
        tsmiSpacing.Size = New Size(181, 22)
        tsmiSpacing.Text = "Line Spacing"
        ' 
        ' tsmOBJECT
        ' 
        tsmOBJECT.BackColor = SystemColors.Control
        tsmOBJECT.DropDownItems.AddRange(New ToolStripItem() {tsmiImageL, tsmiBrowser, tsmiBulletl, tsmiNumberl, tsmiIndent, tsmiTab, tsmiSymbol, tsmiEncoding, tsmiTXTsizefont, tsmiA4S, tsmiRecreate})
        tsmOBJECT.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        tsmOBJECT.ForeColor = SystemColors.WindowFrame
        tsmOBJECT.Name = "tsmOBJECT"
        tsmOBJECT.Size = New Size(67, 21)
        tsmOBJECT.Text = "OBJECT"
        ' 
        ' tsmiImageL
        ' 
        tsmiImageL.BackColor = Color.LightCyan
        tsmiImageL.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiImageL.Name = "tsmiImageL"
        tsmiImageL.Size = New Size(278, 22)
        tsmiImageL.Text = "Insert Image"
        ' 
        ' tsmiBrowser
        ' 
        tsmiBrowser.BackColor = Color.LightCyan
        tsmiBrowser.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiBrowser.ForeColor = Color.Indigo
        tsmiBrowser.Name = "tsmiBrowser"
        tsmiBrowser.Size = New Size(278, 22)
        tsmiBrowser.Text = "Change Browser"
        ' 
        ' tsmiBulletl
        ' 
        tsmiBulletl.BackColor = Color.LightCyan
        tsmiBulletl.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiBulletl.ForeColor = SystemColors.ControlText
        tsmiBulletl.Name = "tsmiBulletl"
        tsmiBulletl.Size = New Size(278, 22)
        tsmiBulletl.Text = "List Indent Values"
        ' 
        ' tsmiNumberl
        ' 
        tsmiNumberl.BackColor = Color.LightCyan
        tsmiNumberl.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiNumberl.ForeColor = SystemColors.ControlText
        tsmiNumberl.Name = "tsmiNumberl"
        tsmiNumberl.Size = New Size(278, 22)
        tsmiNumberl.Text = "Number List Style"
        ' 
        ' tsmiIndent
        ' 
        tsmiIndent.BackColor = Color.LightCyan
        tsmiIndent.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiIndent.ForeColor = SystemColors.ControlText
        tsmiIndent.Name = "tsmiIndent"
        tsmiIndent.Size = New Size(278, 22)
        tsmiIndent.Text = "Indent Value"
        ' 
        ' tsmiTab
        ' 
        tsmiTab.BackColor = Color.LightCyan
        tsmiTab.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiTab.ForeColor = SystemColors.ControlText
        tsmiTab.Name = "tsmiTab"
        tsmiTab.Size = New Size(278, 22)
        tsmiTab.Text = "Tab Value"
        ' 
        ' tsmiSymbol
        ' 
        tsmiSymbol.BackColor = Color.LightCyan
        tsmiSymbol.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiSymbol.Name = "tsmiSymbol"
        tsmiSymbol.Size = New Size(278, 22)
        tsmiSymbol.Text = "Get symbol"
        ' 
        ' tsmiEncoding
        ' 
        tsmiEncoding.BackColor = Color.LightCyan
        tsmiEncoding.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiEncoding.ForeColor = Color.Indigo
        tsmiEncoding.Name = "tsmiEncoding"
        tsmiEncoding.Size = New Size(278, 22)
        tsmiEncoding.Text = "Set Encoding Type"
        ' 
        ' tsmiTXTsizefont
        ' 
        tsmiTXTsizefont.BackColor = Color.LightCyan
        tsmiTXTsizefont.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiTXTsizefont.ForeColor = Color.Indigo
        tsmiTXTsizefont.Name = "tsmiTXTsizefont"
        tsmiTXTsizefont.Size = New Size(278, 22)
        tsmiTXTsizefont.Text = "Save Custom TXT A4-size and Font"
        ' 
        ' tsmiA4S
        ' 
        tsmiA4S.BackColor = Color.LightCyan
        tsmiA4S.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiA4S.ForeColor = Color.Indigo
        tsmiA4S.Name = "tsmiA4S"
        tsmiA4S.Size = New Size(278, 22)
        tsmiA4S.Text = "Save Custom A4-size"
        ' 
        ' tsmiRecreate
        ' 
        tsmiRecreate.BackColor = Color.LightCyan
        tsmiRecreate.Font = New Font("Microsoft New Tai Lue", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        tsmiRecreate.ForeColor = Color.Crimson
        tsmiRecreate.Name = "tsmiRecreate"
        tsmiRecreate.Size = New Size(278, 22)
        tsmiRecreate.Text = "Recreate Custom File"
        ' 
        ' a4wFontDialog
        ' 
        a4wFontDialog.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        a4wFontDialog.FontMustExist = True
        a4wFontDialog.ShowApply = True
        a4wFontDialog.ShowColor = True
        ' 
        ' btnSNITT
        ' 
        btnSNITT.BackColor = Color.LightYellow
        btnSNITT.Cursor = Cursors.Hand
        btnSNITT.Font = New Font("SF Electrotome", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSNITT.ForeColor = Color.Navy
        btnSNITT.Location = New Point(8, 29)
        btnSNITT.Name = "btnSNITT"
        btnSNITT.Size = New Size(96, 27)
        btnSNITT.TabIndex = 2
        btnSNITT.Text = "SELECT FONT"
        btnSNITT.UseVisualStyleBackColor = False
        ' 
        ' nudLEFT
        ' 
        nudLEFT.Font = New Font("SF Electrotome Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        nudLEFT.Location = New Point(8, 80)
        nudLEFT.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudLEFT.Name = "nudLEFT"
        nudLEFT.Size = New Size(48, 21)
        nudLEFT.TabIndex = 3
        a4wToolTip.SetToolTip(nudLEFT, "Left margin on paper")
        nudLEFT.Value = New Decimal(New Integer() {90, 0, 0, 0})
        ' 
        ' nudRIGHT
        ' 
        nudRIGHT.Font = New Font("SF Electrotome Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        nudRIGHT.Location = New Point(760, 80)
        nudRIGHT.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudRIGHT.Name = "nudRIGHT"
        nudRIGHT.Size = New Size(48, 21)
        nudRIGHT.TabIndex = 4
        a4wToolTip.SetToolTip(nudRIGHT, "Right margin on paper")
        nudRIGHT.Value = New Decimal(New Integer() {35, 0, 0, 0})
        ' 
        ' lblLeft
        ' 
        lblLeft.AutoSize = True
        lblLeft.BackColor = Color.Transparent
        lblLeft.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblLeft.ForeColor = SystemColors.ControlDarkDark
        lblLeft.Location = New Point(6, 62)
        lblLeft.Name = "lblLeft"
        lblLeft.Size = New Size(62, 17)
        lblLeft.TabIndex = 5
        lblLeft.Text = "Left margin:"
        ' 
        ' lblRight
        ' 
        lblRight.AutoSize = True
        lblRight.BackColor = Color.Transparent
        lblRight.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblRight.ForeColor = SystemColors.ControlDarkDark
        lblRight.Location = New Point(694, 82)
        lblRight.Name = "lblRight"
        lblRight.Size = New Size(65, 17)
        lblRight.TabIndex = 6
        lblRight.Text = "Right margin:"
        ' 
        ' nudTOP
        ' 
        nudTOP.Font = New Font("SF Electrotome Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        nudTOP.Location = New Point(640, 56)
        nudTOP.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudTOP.Name = "nudTOP"
        nudTOP.Size = New Size(48, 21)
        nudTOP.TabIndex = 7
        a4wToolTip.SetToolTip(nudTOP, "Top margin on paper")
        nudTOP.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' nudBOTTOM
        ' 
        nudBOTTOM.Font = New Font("SF Electrotome Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        nudBOTTOM.Location = New Point(640, 80)
        nudBOTTOM.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudBOTTOM.Name = "nudBOTTOM"
        nudBOTTOM.Size = New Size(48, 21)
        nudBOTTOM.TabIndex = 8
        a4wToolTip.SetToolTip(nudBOTTOM, "Bottom margin on paper")
        nudBOTTOM.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' lblTop
        ' 
        lblTop.AutoSize = True
        lblTop.BackColor = Color.Transparent
        lblTop.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTop.ForeColor = SystemColors.ControlDarkDark
        lblTop.Location = New Point(582, 58)
        lblTop.Name = "lblTop"
        lblTop.Size = New Size(57, 17)
        lblTop.TabIndex = 9
        lblTop.Text = "Top margin:"
        ' 
        ' lblBottom
        ' 
        lblBottom.AutoSize = True
        lblBottom.BackColor = Color.Transparent
        lblBottom.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBottom.ForeColor = SystemColors.ControlDarkDark
        lblBottom.Location = New Point(593, 82)
        lblBottom.Name = "lblBottom"
        lblBottom.Size = New Size(45, 17)
        lblBottom.TabIndex = 10
        lblBottom.Text = "Bottom:"
        ' 
        ' btnCT
        ' 
        btnCT.BackColor = Color.Azure
        btnCT.Cursor = Cursors.Hand
        btnCT.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCT.ForeColor = Color.Navy
        btnCT.Location = New Point(376, 56)
        btnCT.Margin = New Padding(3, 0, 3, 3)
        btnCT.Name = "btnCT"
        btnCT.Size = New Size(48, 20)
        btnCT.TabIndex = 11
        btnCT.Text = "Cut"
        btnCT.TextAlign = ContentAlignment.TopCenter
        btnCT.UseVisualStyleBackColor = False
        ' 
        ' btnCY
        ' 
        btnCY.BackColor = Color.Azure
        btnCY.Cursor = Cursors.Hand
        btnCY.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCY.ForeColor = Color.Navy
        btnCY.Location = New Point(376, 29)
        btnCY.Margin = New Padding(3, 0, 3, 3)
        btnCY.Name = "btnCY"
        btnCY.Size = New Size(48, 20)
        btnCY.TabIndex = 12
        btnCY.Text = "Copy"
        btnCY.TextAlign = ContentAlignment.TopCenter
        btnCY.UseVisualStyleBackColor = False
        ' 
        ' btnPT
        ' 
        btnPT.BackColor = Color.Azure
        btnPT.Cursor = Cursors.Hand
        btnPT.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnPT.ForeColor = Color.Navy
        btnPT.Location = New Point(376, 82)
        btnPT.Margin = New Padding(3, 0, 3, 3)
        btnPT.Name = "btnPT"
        btnPT.Size = New Size(48, 20)
        btnPT.TabIndex = 13
        btnPT.Text = "Paste"
        btnPT.TextAlign = ContentAlignment.TopCenter
        btnPT.UseVisualStyleBackColor = False
        ' 
        ' pbEE
        ' 
        pbEE.Cursor = Cursors.Cross
        pbEE.Image = CType(resources.GetObject("pbEE.Image"), Image)
        pbEE.Location = New Point(785, 112)
        pbEE.Name = "pbEE"
        pbEE.Size = New Size(24, 24)
        pbEE.SizeMode = PictureBoxSizeMode.Zoom
        pbEE.TabIndex = 14
        pbEE.TabStop = False
        a4wToolTip.SetToolTip(pbEE, "© Essential Electronics 2022")
        ' 
        ' a4wPrintDialog
        ' 
        a4wPrintDialog.AllowSelection = True
        a4wPrintDialog.AllowSomePages = True
        a4wPrintDialog.Document = a4wPrintDocument
        a4wPrintDialog.UseEXDialog = True
        ' 
        ' a4wPrintDocument
        ' 
        ' 
        ' btnRA4
        ' 
        btnRA4.BackColor = Color.GhostWhite
        btnRA4.Cursor = Cursors.Hand
        btnRA4.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRA4.ForeColor = Color.Navy
        btnRA4.Location = New Point(745, 29)
        btnRA4.Margin = New Padding(3, 0, 3, 3)
        btnRA4.Name = "btnRA4"
        btnRA4.Size = New Size(64, 20)
        btnRA4.TabIndex = 15
        btnRA4.Text = "Reset A4"
        btnRA4.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnRA4, "Back to normal A4")
        btnRA4.UseVisualStyleBackColor = False
        ' 
        ' pbAU
        ' 
        pbAU.BackColor = Color.Transparent
        pbAU.Image = CType(resources.GetObject("pbAU.Image"), Image)
        pbAU.Location = New Point(785, 168)
        pbAU.Name = "pbAU"
        pbAU.Size = New Size(24, 24)
        pbAU.SizeMode = PictureBoxSizeMode.StretchImage
        pbAU.TabIndex = 16
        pbAU.TabStop = False
        ' 
        ' pbAD
        ' 
        pbAD.BackColor = Color.Transparent
        pbAD.Image = CType(resources.GetObject("pbAD.Image"), Image)
        pbAD.Location = New Point(785, 232)
        pbAD.Name = "pbAD"
        pbAD.Size = New Size(24, 24)
        pbAD.SizeMode = PictureBoxSizeMode.StretchImage
        pbAD.TabIndex = 17
        pbAD.TabStop = False
        ' 
        ' tbBROWS
        ' 
        tbBROWS.BackColor = Color.White
        tbBROWS.BorderStyle = BorderStyle.FixedSingle
        tbBROWS.Font = New Font("SF Electrotome", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbBROWS.Location = New Point(777, 202)
        tbBROWS.Name = "tbBROWS"
        tbBROWS.Size = New Size(40, 21)
        tbBROWS.TabIndex = 18
        tbBROWS.TextAlign = HorizontalAlignment.Center
        a4wToolTip.SetToolTip(tbBROWS, "Go to page (approx)")
        ' 
        ' btnLEFT
        ' 
        btnLEFT.BackColor = Color.Transparent
        btnLEFT.BackgroundImage = CType(resources.GetObject("btnLEFT.BackgroundImage"), Image)
        btnLEFT.BackgroundImageLayout = ImageLayout.Center
        btnLEFT.Cursor = Cursors.Hand
        btnLEFT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLEFT.ForeColor = SystemColors.Control
        btnLEFT.Location = New Point(74, 56)
        btnLEFT.Margin = New Padding(3, 0, 3, 3)
        btnLEFT.Name = "btnLEFT"
        btnLEFT.Size = New Size(24, 24)
        btnLEFT.TabIndex = 19
        btnLEFT.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnLEFT, "Align Left")
        btnLEFT.UseVisualStyleBackColor = False
        ' 
        ' btnOPEN
        ' 
        btnOPEN.BackColor = Color.LightCyan
        btnOPEN.Cursor = Cursors.Hand
        btnOPEN.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnOPEN.ForeColor = Color.Navy
        btnOPEN.Location = New Point(488, 29)
        btnOPEN.Margin = New Padding(3, 0, 3, 3)
        btnOPEN.Name = "btnOPEN"
        btnOPEN.Size = New Size(48, 20)
        btnOPEN.TabIndex = 22
        btnOPEN.Text = "Open"
        btnOPEN.TextAlign = ContentAlignment.TopCenter
        btnOPEN.UseVisualStyleBackColor = False
        ' 
        ' btnSAVE
        ' 
        btnSAVE.BackColor = Color.LightCyan
        btnSAVE.Cursor = Cursors.Hand
        btnSAVE.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSAVE.ForeColor = Color.Navy
        btnSAVE.Location = New Point(488, 56)
        btnSAVE.Margin = New Padding(3, 0, 3, 3)
        btnSAVE.Name = "btnSAVE"
        btnSAVE.Size = New Size(48, 20)
        btnSAVE.TabIndex = 23
        btnSAVE.Text = "Save"
        btnSAVE.TextAlign = ContentAlignment.TopCenter
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' btnSAVEAS
        ' 
        btnSAVEAS.BackColor = Color.LightCyan
        btnSAVEAS.Cursor = Cursors.Hand
        btnSAVEAS.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSAVEAS.ForeColor = Color.Navy
        btnSAVEAS.Location = New Point(488, 82)
        btnSAVEAS.Margin = New Padding(3, 0, 3, 3)
        btnSAVEAS.Name = "btnSAVEAS"
        btnSAVEAS.Size = New Size(48, 20)
        btnSAVEAS.TabIndex = 24
        btnSAVEAS.Text = "Save As"
        btnSAVEAS.TextAlign = ContentAlignment.TopCenter
        btnSAVEAS.UseVisualStyleBackColor = False
        ' 
        ' btnPREVIEW
        ' 
        btnPREVIEW.BackColor = Color.LavenderBlush
        btnPREVIEW.Cursor = Cursors.Hand
        btnPREVIEW.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnPREVIEW.ForeColor = Color.Navy
        btnPREVIEW.Location = New Point(320, 56)
        btnPREVIEW.Margin = New Padding(3, 0, 3, 3)
        btnPREVIEW.Name = "btnPREVIEW"
        btnPREVIEW.Size = New Size(48, 20)
        btnPREVIEW.TabIndex = 25
        btnPREVIEW.Text = "Preview"
        btnPREVIEW.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnPREVIEW, "Preview A4")
        btnPREVIEW.UseVisualStyleBackColor = False
        ' 
        ' btnPRINT
        ' 
        btnPRINT.BackColor = Color.LavenderBlush
        btnPRINT.Cursor = Cursors.Hand
        btnPRINT.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnPRINT.ForeColor = Color.Navy
        btnPRINT.Location = New Point(320, 82)
        btnPRINT.Margin = New Padding(3, 0, 3, 3)
        btnPRINT.Name = "btnPRINT"
        btnPRINT.Size = New Size(48, 20)
        btnPRINT.TabIndex = 26
        btnPRINT.Text = "Print"
        btnPRINT.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnPRINT, "Print A4")
        btnPRINT.UseVisualStyleBackColor = False
        ' 
        ' tbSNITT
        ' 
        tbSNITT.BorderStyle = BorderStyle.FixedSingle
        tbSNITT.Font = New Font("SF Electrotome Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        tbSNITT.Location = New Point(112, 30)
        tbSNITT.Name = "tbSNITT"
        tbSNITT.ReadOnly = True
        tbSNITT.Size = New Size(200, 19)
        tbSNITT.TabIndex = 27
        a4wToolTip.SetToolTip(tbSNITT, "Current selected font")
        ' 
        ' btnCENTER
        ' 
        btnCENTER.BackColor = Color.Transparent
        btnCENTER.BackgroundImage = CType(resources.GetObject("btnCENTER.BackgroundImage"), Image)
        btnCENTER.BackgroundImageLayout = ImageLayout.Center
        btnCENTER.Cursor = Cursors.Hand
        btnCENTER.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCENTER.ForeColor = SystemColors.Control
        btnCENTER.Location = New Point(134, 56)
        btnCENTER.Margin = New Padding(3, 0, 3, 3)
        btnCENTER.Name = "btnCENTER"
        btnCENTER.Size = New Size(24, 24)
        btnCENTER.TabIndex = 29
        btnCENTER.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnCENTER, "Align Center")
        btnCENTER.UseVisualStyleBackColor = False
        ' 
        ' btnRIGHT
        ' 
        btnRIGHT.BackColor = Color.Transparent
        btnRIGHT.BackgroundImage = CType(resources.GetObject("btnRIGHT.BackgroundImage"), Image)
        btnRIGHT.BackgroundImageLayout = ImageLayout.Center
        btnRIGHT.Cursor = Cursors.Hand
        btnRIGHT.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRIGHT.ForeColor = SystemColors.Control
        btnRIGHT.Location = New Point(104, 56)
        btnRIGHT.Margin = New Padding(3, 0, 3, 3)
        btnRIGHT.Name = "btnRIGHT"
        btnRIGHT.Size = New Size(24, 24)
        btnRIGHT.TabIndex = 30
        btnRIGHT.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnRIGHT, "Align Right")
        btnRIGHT.UseVisualStyleBackColor = False
        ' 
        ' btnOWN
        ' 
        btnOWN.BackColor = Color.GhostWhite
        btnOWN.Cursor = Cursors.Hand
        btnOWN.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnOWN.ForeColor = Color.Navy
        btnOWN.Location = New Point(745, 51)
        btnOWN.Margin = New Padding(3, 0, 3, 3)
        btnOWN.Name = "btnOWN"
        btnOWN.Size = New Size(64, 20)
        btnOWN.TabIndex = 31
        btnOWN.Text = "Custom Size"
        btnOWN.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnOWN, "Your custom size")
        btnOWN.UseVisualStyleBackColor = False
        ' 
        ' btnUO
        ' 
        btnUO.BackColor = Color.LemonChiffon
        btnUO.Cursor = Cursors.Hand
        btnUO.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnUO.ForeColor = Color.Navy
        btnUO.Location = New Point(432, 29)
        btnUO.Margin = New Padding(3, 0, 3, 3)
        btnUO.Name = "btnUO"
        btnUO.Size = New Size(48, 20)
        btnUO.TabIndex = 34
        btnUO.Text = "Undo"
        btnUO.TextAlign = ContentAlignment.TopCenter
        btnUO.UseVisualStyleBackColor = False
        ' 
        ' btnRO
        ' 
        btnRO.BackColor = Color.LemonChiffon
        btnRO.Cursor = Cursors.Hand
        btnRO.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRO.ForeColor = Color.Navy
        btnRO.Location = New Point(432, 56)
        btnRO.Margin = New Padding(3, 0, 3, 3)
        btnRO.Name = "btnRO"
        btnRO.Size = New Size(48, 20)
        btnRO.TabIndex = 35
        btnRO.Text = "Redo"
        btnRO.TextAlign = ContentAlignment.TopCenter
        btnRO.UseVisualStyleBackColor = False
        ' 
        ' a4wOpenFileDialog
        ' 
        a4wOpenFileDialog.DefaultExt = "rtf"
        a4wOpenFileDialog.FileName = "WordPad"
        a4wOpenFileDialog.Filter = "Rich Text Format (.rtf)|*.*"
        ' 
        ' a4wSaveFileDialog
        ' 
        a4wSaveFileDialog.DefaultExt = "rtf"
        a4wSaveFileDialog.Filter = "Rich Text Format (.rtf)|*.*"
        ' 
        ' btnBL
        ' 
        btnBL.BackColor = SystemColors.Control
        btnBL.BackgroundImage = CType(resources.GetObject("btnBL.BackgroundImage"), Image)
        btnBL.BackgroundImageLayout = ImageLayout.Center
        btnBL.Cursor = Cursors.Hand
        btnBL.Location = New Point(654, 29)
        btnBL.Name = "btnBL"
        btnBL.Size = New Size(24, 24)
        btnBL.TabIndex = 36
        a4wToolTip.SetToolTip(btnBL, "Bullet List")
        btnBL.UseVisualStyleBackColor = False
        ' 
        ' btnLOUT
        ' 
        btnLOUT.BackgroundImage = CType(resources.GetObject("btnLOUT.BackgroundImage"), Image)
        btnLOUT.BackgroundImageLayout = ImageLayout.Center
        btnLOUT.Cursor = Cursors.Hand
        btnLOUT.Location = New Point(544, 29)
        btnLOUT.Name = "btnLOUT"
        btnLOUT.Size = New Size(24, 24)
        btnLOUT.TabIndex = 37
        a4wToolTip.SetToolTip(btnLOUT, "Increase Left Indent")
        btnLOUT.UseVisualStyleBackColor = True
        ' 
        ' btnREPLACE
        ' 
        btnREPLACE.BackColor = Color.White
        btnREPLACE.Cursor = Cursors.Hand
        btnREPLACE.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnREPLACE.ForeColor = Color.Navy
        btnREPLACE.Location = New Point(264, 82)
        btnREPLACE.Margin = New Padding(3, 0, 3, 3)
        btnREPLACE.Name = "btnREPLACE"
        btnREPLACE.Size = New Size(48, 20)
        btnREPLACE.TabIndex = 39
        btnREPLACE.Text = "Replace"
        btnREPLACE.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnREPLACE, "Replace character, word or words")
        btnREPLACE.UseVisualStyleBackColor = False
        ' 
        ' btnSEARCH
        ' 
        btnSEARCH.BackColor = Color.White
        btnSEARCH.Cursor = Cursors.Hand
        btnSEARCH.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSEARCH.ForeColor = Color.Navy
        btnSEARCH.Location = New Point(264, 56)
        btnSEARCH.Margin = New Padding(3, 0, 3, 3)
        btnSEARCH.Name = "btnSEARCH"
        btnSEARCH.Size = New Size(48, 20)
        btnSEARCH.TabIndex = 38
        btnSEARCH.Text = "Search"
        btnSEARCH.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnSEARCH, "Search character, word or words")
        btnSEARCH.UseVisualStyleBackColor = False
        ' 
        ' btnLIN
        ' 
        btnLIN.BackgroundImage = CType(resources.GetObject("btnLIN.BackgroundImage"), Image)
        btnLIN.BackgroundImageLayout = ImageLayout.Center
        btnLIN.Cursor = Cursors.Hand
        btnLIN.Location = New Point(568, 29)
        btnLIN.Name = "btnLIN"
        btnLIN.Size = New Size(24, 24)
        btnLIN.TabIndex = 40
        a4wToolTip.SetToolTip(btnLIN, "Decrease Left Indent")
        btnLIN.UseVisualStyleBackColor = True
        ' 
        ' btnRIN
        ' 
        btnRIN.BackgroundImage = CType(resources.GetObject("btnRIN.BackgroundImage"), Image)
        btnRIN.BackgroundImageLayout = ImageLayout.Center
        btnRIN.Cursor = Cursors.Hand
        btnRIN.Location = New Point(622, 29)
        btnRIN.Name = "btnRIN"
        btnRIN.Size = New Size(24, 24)
        btnRIN.TabIndex = 43
        a4wToolTip.SetToolTip(btnRIN, "Decrease Right Indent")
        btnRIN.UseVisualStyleBackColor = True
        ' 
        ' btnROUT
        ' 
        btnROUT.BackgroundImage = CType(resources.GetObject("btnROUT.BackgroundImage"), Image)
        btnROUT.BackgroundImageLayout = ImageLayout.Center
        btnROUT.Cursor = Cursors.Hand
        btnROUT.Location = New Point(598, 29)
        btnROUT.Name = "btnROUT"
        btnROUT.Size = New Size(24, 24)
        btnROUT.TabIndex = 42
        a4wToolTip.SetToolTip(btnROUT, "Increase Right Indent")
        btnROUT.UseVisualStyleBackColor = True
        ' 
        ' btnRESETINDENT
        ' 
        btnRESETINDENT.BackgroundImage = CType(resources.GetObject("btnRESETINDENT.BackgroundImage"), Image)
        btnRESETINDENT.BackgroundImageLayout = ImageLayout.Center
        btnRESETINDENT.Cursor = Cursors.Hand
        btnRESETINDENT.Location = New Point(544, 53)
        btnRESETINDENT.Name = "btnRESETINDENT"
        btnRESETINDENT.Size = New Size(24, 24)
        btnRESETINDENT.TabIndex = 44
        a4wToolTip.SetToolTip(btnRESETINDENT, "Reset ALL Indent")
        btnRESETINDENT.UseVisualStyleBackColor = True
        ' 
        ' btnIMAGE
        ' 
        btnIMAGE.BackgroundImage = CType(resources.GetObject("btnIMAGE.BackgroundImage"), Image)
        btnIMAGE.BackgroundImageLayout = ImageLayout.Center
        btnIMAGE.Cursor = Cursors.Hand
        btnIMAGE.Image = CType(resources.GetObject("btnIMAGE.Image"), Image)
        btnIMAGE.Location = New Point(703, 29)
        btnIMAGE.Name = "btnIMAGE"
        btnIMAGE.Size = New Size(31, 31)
        btnIMAGE.TabIndex = 45
        a4wToolTip.SetToolTip(btnIMAGE, "Load Image")
        btnIMAGE.UseVisualStyleBackColor = True
        ' 
        ' rbL
        ' 
        rbL.AutoSize = True
        rbL.Checked = True
        rbL.Location = New Point(696, 64)
        rbL.Name = "rbL"
        rbL.Size = New Size(14, 13)
        rbL.TabIndex = 46
        rbL.TabStop = True
        a4wToolTip.SetToolTip(rbL, "Image to Left")
        rbL.UseVisualStyleBackColor = True
        ' 
        ' rbC
        ' 
        rbC.AutoSize = True
        rbC.Location = New Point(712, 64)
        rbC.Name = "rbC"
        rbC.Size = New Size(14, 13)
        rbC.TabIndex = 47
        a4wToolTip.SetToolTip(rbC, "Image to Center")
        rbC.UseVisualStyleBackColor = True
        ' 
        ' rbR
        ' 
        rbR.AutoSize = True
        rbR.Location = New Point(728, 64)
        rbR.Name = "rbR"
        rbR.Size = New Size(14, 13)
        rbR.TabIndex = 48
        a4wToolTip.SetToolTip(rbR, "Image to Right")
        rbR.UseVisualStyleBackColor = True
        ' 
        ' btnFORMAT
        ' 
        btnFORMAT.BackColor = Color.Bisque
        btnFORMAT.Cursor = Cursors.Hand
        btnFORMAT.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnFORMAT.ForeColor = Color.Navy
        btnFORMAT.Location = New Point(432, 82)
        btnFORMAT.Margin = New Padding(3, 0, 3, 3)
        btnFORMAT.Name = "btnFORMAT"
        btnFORMAT.Size = New Size(47, 20)
        btnFORMAT.TabIndex = 41
        btnFORMAT.Text = "Format"
        btnFORMAT.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnFORMAT, "Get the selected format")
        btnFORMAT.UseVisualStyleBackColor = False
        ' 
        ' tbPAGES
        ' 
        tbPAGES.BackColor = Color.LavenderBlush
        tbPAGES.BorderStyle = BorderStyle.None
        tbPAGES.Font = New Font("SF Electrotome", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tbPAGES.ForeColor = Color.Navy
        tbPAGES.Location = New Point(777, 264)
        tbPAGES.Name = "tbPAGES"
        tbPAGES.ReadOnly = True
        tbPAGES.Size = New Size(40, 14)
        tbPAGES.TabIndex = 49
        tbPAGES.TextAlign = HorizontalAlignment.Center
        a4wToolTip.SetToolTip(tbPAGES, "Total pages (approx)")
        ' 
        ' btnJUST
        ' 
        btnJUST.BackColor = Color.Transparent
        btnJUST.BackgroundImage = CType(resources.GetObject("btnJUST.BackgroundImage"), Image)
        btnJUST.BackgroundImageLayout = ImageLayout.Center
        btnJUST.Cursor = Cursors.Hand
        btnJUST.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnJUST.ForeColor = SystemColors.Control
        btnJUST.Location = New Point(164, 56)
        btnJUST.Margin = New Padding(3, 0, 3, 3)
        btnJUST.Name = "btnJUST"
        btnJUST.Size = New Size(24, 24)
        btnJUST.TabIndex = 50
        btnJUST.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnJUST, "Align Justified")
        btnJUST.UseVisualStyleBackColor = False
        ' 
        ' btnCOLOR
        ' 
        btnCOLOR.BackgroundImage = CType(resources.GetObject("btnCOLOR.BackgroundImage"), Image)
        btnCOLOR.BackgroundImageLayout = ImageLayout.Center
        btnCOLOR.Cursor = Cursors.Hand
        btnCOLOR.Location = New Point(194, 56)
        btnCOLOR.Name = "btnCOLOR"
        btnCOLOR.Size = New Size(24, 24)
        btnCOLOR.TabIndex = 51
        a4wToolTip.SetToolTip(btnCOLOR, "Set text Color")
        btnCOLOR.UseVisualStyleBackColor = True
        ' 
        ' btnBCOLOR
        ' 
        btnBCOLOR.BackgroundImage = CType(resources.GetObject("btnBCOLOR.BackgroundImage"), Image)
        btnBCOLOR.BackgroundImageLayout = ImageLayout.Center
        btnBCOLOR.Cursor = Cursors.Hand
        btnBCOLOR.Location = New Point(224, 56)
        btnBCOLOR.Name = "btnBCOLOR"
        btnBCOLOR.Size = New Size(24, 24)
        btnBCOLOR.TabIndex = 52
        a4wToolTip.SetToolTip(btnBCOLOR, "Set back Color")
        btnBCOLOR.UseVisualStyleBackColor = True
        ' 
        ' btnSUP
        ' 
        btnSUP.BackColor = Color.Silver
        btnSUP.Cursor = Cursors.Hand
        btnSUP.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSUP.ForeColor = Color.Navy
        btnSUP.Location = New Point(194, 82)
        btnSUP.Margin = New Padding(3, 0, 3, 3)
        btnSUP.Name = "btnSUP"
        btnSUP.Size = New Size(24, 20)
        btnSUP.TabIndex = 53
        btnSUP.Text = "§"
        btnSUP.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnSUP, "Superscript or subscript (repeatable)")
        btnSUP.UseVisualStyleBackColor = False
        ' 
        ' btnB
        ' 
        btnB.BackColor = Color.LightYellow
        btnB.Cursor = Cursors.Hand
        btnB.Font = New Font("SF Electrotome", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnB.ForeColor = Color.Navy
        btnB.Location = New Point(74, 82)
        btnB.Margin = New Padding(3, 0, 3, 3)
        btnB.Name = "btnB"
        btnB.Size = New Size(24, 20)
        btnB.TabIndex = 54
        btnB.Text = "B"
        btnB.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnB, "Bold")
        btnB.UseVisualStyleBackColor = False
        ' 
        ' btnU
        ' 
        btnU.BackColor = Color.LightYellow
        btnU.Cursor = Cursors.Hand
        btnU.Font = New Font("SF Electrotome", 8.25F, FontStyle.Underline, GraphicsUnit.Point)
        btnU.ForeColor = Color.Navy
        btnU.Location = New Point(134, 82)
        btnU.Margin = New Padding(3, 0, 3, 3)
        btnU.Name = "btnU"
        btnU.Size = New Size(24, 20)
        btnU.TabIndex = 55
        btnU.Text = "U"
        btnU.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnU, "Underline")
        btnU.UseVisualStyleBackColor = False
        ' 
        ' btnI
        ' 
        btnI.BackColor = Color.LightYellow
        btnI.Cursor = Cursors.Hand
        btnI.Font = New Font("SF Electrotome", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        btnI.ForeColor = Color.Navy
        btnI.Location = New Point(104, 82)
        btnI.Margin = New Padding(3, 0, 3, 3)
        btnI.Name = "btnI"
        btnI.Size = New Size(24, 20)
        btnI.TabIndex = 56
        btnI.Text = "I"
        btnI.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnI, "Italic")
        btnI.UseVisualStyleBackColor = False
        ' 
        ' btnS
        ' 
        btnS.BackColor = Color.LightYellow
        btnS.Cursor = Cursors.Hand
        btnS.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnS.ForeColor = Color.Navy
        btnS.Location = New Point(164, 82)
        btnS.Margin = New Padding(3, 0, 3, 3)
        btnS.Name = "btnS"
        btnS.Size = New Size(24, 20)
        btnS.TabIndex = 57
        btnS.Text = "S"
        btnS.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnS, "Strikeout")
        btnS.UseVisualStyleBackColor = False
        ' 
        ' btnSPACE
        ' 
        btnSPACE.BackColor = Color.Silver
        btnSPACE.Cursor = Cursors.Hand
        btnSPACE.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSPACE.ForeColor = Color.Navy
        btnSPACE.Location = New Point(224, 82)
        btnSPACE.Margin = New Padding(3, 0, 3, 3)
        btnSPACE.Name = "btnSPACE"
        btnSPACE.Size = New Size(24, 20)
        btnSPACE.TabIndex = 58
        btnSPACE.Text = "="
        btnSPACE.TextAlign = ContentAlignment.TopCenter
        a4wToolTip.SetToolTip(btnSPACE, "V alignment or line spacing")
        btnSPACE.UseVisualStyleBackColor = False
        ' 
        ' nudSL
        ' 
        nudSL.BackColor = SystemColors.Control
        nudSL.Font = New Font("SF Electrotome Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudSL.Location = New Point(315, 30)
        nudSL.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        nudSL.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudSL.Name = "nudSL"
        nudSL.Size = New Size(52, 19)
        nudSL.TabIndex = 59
        a4wToolTip.SetToolTip(nudSL, "Adjustable font size")
        nudSL.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnNL
        ' 
        btnNL.BackColor = SystemColors.Control
        btnNL.BackgroundImage = CType(resources.GetObject("btnNL.BackgroundImage"), Image)
        btnNL.BackgroundImageLayout = ImageLayout.Center
        btnNL.Cursor = Cursors.Hand
        btnNL.Location = New Point(678, 29)
        btnNL.Name = "btnNL"
        btnNL.Size = New Size(24, 24)
        btnNL.TabIndex = 60
        a4wToolTip.SetToolTip(btnNL, "Number List (after bullet)")
        btnNL.UseVisualStyleBackColor = False
        ' 
        ' btnOHM
        ' 
        btnOHM.BackgroundImage = CType(resources.GetObject("btnOHM.BackgroundImage"), Image)
        btnOHM.BackgroundImageLayout = ImageLayout.Center
        btnOHM.Cursor = Cursors.Hand
        btnOHM.Location = New Point(544, 78)
        btnOHM.Name = "btnOHM"
        btnOHM.Size = New Size(24, 24)
        btnOHM.TabIndex = 61
        a4wToolTip.SetToolTip(btnOHM, "Get Symbol")
        btnOHM.UseVisualStyleBackColor = True
        ' 
        ' btnSELECTALL
        ' 
        btnSELECTALL.BackColor = Color.Black
        btnSELECTALL.Location = New Point(250, 56)
        btnSELECTALL.Name = "btnSELECTALL"
        btnSELECTALL.Size = New Size(12, 12)
        btnSELECTALL.TabIndex = 62
        a4wToolTip.SetToolTip(btnSELECTALL, "Select all")
        btnSELECTALL.UseVisualStyleBackColor = False
        ' 
        ' btnDESELECTALL
        ' 
        btnDESELECTALL.BackColor = Color.White
        btnDESELECTALL.Location = New Point(250, 68)
        btnDESELECTALL.Name = "btnDESELECTALL"
        btnDESELECTALL.Size = New Size(12, 12)
        btnDESELECTALL.TabIndex = 63
        a4wToolTip.SetToolTip(btnDESELECTALL, "Deselect all")
        btnDESELECTALL.UseVisualStyleBackColor = False
        ' 
        ' btnINDENTBL
        ' 
        btnINDENTBL.BackColor = Color.Aquamarine
        btnINDENTBL.Location = New Point(570, 53)
        btnINDENTBL.Name = "btnINDENTBL"
        btnINDENTBL.Size = New Size(12, 12)
        btnINDENTBL.TabIndex = 64
        a4wToolTip.SetToolTip(btnINDENTBL, "List indent values")
        btnINDENTBL.UseVisualStyleBackColor = False
        ' 
        ' btnSTYLENL
        ' 
        btnSTYLENL.BackColor = Color.DeepSkyBlue
        btnSTYLENL.Location = New Point(570, 65)
        btnSTYLENL.Name = "btnSTYLENL"
        btnSTYLENL.Size = New Size(12, 12)
        btnSTYLENL.TabIndex = 65
        a4wToolTip.SetToolTip(btnSTYLENL, "Number list style")
        btnSTYLENL.UseVisualStyleBackColor = False
        ' 
        ' btnTAB
        ' 
        btnTAB.BackColor = Color.Black
        btnTAB.Location = New Point(570, 90)
        btnTAB.Name = "btnTAB"
        btnTAB.Size = New Size(12, 12)
        btnTAB.TabIndex = 67
        a4wToolTip.SetToolTip(btnTAB, "Tab value")
        btnTAB.UseVisualStyleBackColor = False
        ' 
        ' btnINDENT
        ' 
        btnINDENT.BackColor = SystemColors.ControlDark
        btnINDENT.Location = New Point(570, 78)
        btnINDENT.Name = "btnINDENT"
        btnINDENT.Size = New Size(12, 12)
        btnINDENT.TabIndex = 66
        a4wToolTip.SetToolTip(btnINDENT, "Indent value")
        btnINDENT.UseVisualStyleBackColor = False
        ' 
        ' imgOpenFileDialog
        ' 
        imgOpenFileDialog.FileName = "Image"
        imgOpenFileDialog.Filter = "JPEG (.jpg)|*.*"
        ' 
        ' a4wPrintPreviewDialog
        ' 
        a4wPrintPreviewDialog.AutoScrollMargin = New Size(0, 0)
        a4wPrintPreviewDialog.AutoScrollMinSize = New Size(0, 0)
        a4wPrintPreviewDialog.ClientSize = New Size(400, 300)
        a4wPrintPreviewDialog.Document = a4wPrintDocument
        a4wPrintPreviewDialog.Enabled = True
        a4wPrintPreviewDialog.Icon = CType(resources.GetObject("a4wPrintPreviewDialog.Icon"), Icon)
        a4wPrintPreviewDialog.Name = "a4wPrintPreviewDialog"
        a4wPrintPreviewDialog.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(820, 451)
        Controls.Add(btnTAB)
        Controls.Add(btnINDENT)
        Controls.Add(btnSTYLENL)
        Controls.Add(btnINDENTBL)
        Controls.Add(btnDESELECTALL)
        Controls.Add(btnSELECTALL)
        Controls.Add(btnOHM)
        Controls.Add(btnNL)
        Controls.Add(nudSL)
        Controls.Add(btnSPACE)
        Controls.Add(btnS)
        Controls.Add(btnI)
        Controls.Add(btnU)
        Controls.Add(btnB)
        Controls.Add(btnSUP)
        Controls.Add(btnBCOLOR)
        Controls.Add(tbPAGES)
        Controls.Add(rbR)
        Controls.Add(rbC)
        Controls.Add(rbL)
        Controls.Add(btnIMAGE)
        Controls.Add(btnRESETINDENT)
        Controls.Add(btnRIN)
        Controls.Add(btnROUT)
        Controls.Add(btnFORMAT)
        Controls.Add(btnLIN)
        Controls.Add(btnLOUT)
        Controls.Add(btnBL)
        Controls.Add(btnRO)
        Controls.Add(btnUO)
        Controls.Add(btnOWN)
        Controls.Add(btnSAVEAS)
        Controls.Add(btnSAVE)
        Controls.Add(btnOPEN)
        Controls.Add(tbBROWS)
        Controls.Add(pbAD)
        Controls.Add(pbAU)
        Controls.Add(btnRA4)
        Controls.Add(pbEE)
        Controls.Add(btnPT)
        Controls.Add(btnCY)
        Controls.Add(btnCT)
        Controls.Add(lblBottom)
        Controls.Add(lblTop)
        Controls.Add(nudBOTTOM)
        Controls.Add(nudTOP)
        Controls.Add(lblRight)
        Controls.Add(lblLeft)
        Controls.Add(nudRIGHT)
        Controls.Add(nudLEFT)
        Controls.Add(btnSNITT)
        Controls.Add(pARK)
        Controls.Add(a4wMenyStrip)
        Controls.Add(tbSNITT)
        Controls.Add(btnCOLOR)
        Controls.Add(btnJUST)
        Controls.Add(btnREPLACE)
        Controls.Add(btnSEARCH)
        Controls.Add(btnRIGHT)
        Controls.Add(btnCENTER)
        Controls.Add(btnPRINT)
        Controls.Add(btnPREVIEW)
        Controls.Add(btnLEFT)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = a4wMenyStrip
        Name = "Form1"
        Text = "EE A4W Portrait [RTF]"
        pARK.ResumeLayout(False)
        a4wMenyStrip.ResumeLayout(False)
        a4wMenyStrip.PerformLayout()
        CType(nudLEFT, ComponentModel.ISupportInitialize).EndInit()
        CType(nudRIGHT, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTOP, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBOTTOM, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEE, ComponentModel.ISupportInitialize).EndInit()
        CType(pbAU, ComponentModel.ISupportInitialize).EndInit()
        CType(pbAD, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSL, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pARK As Panel
    Friend WithEvents rtbARK As RichTextBox
    Friend WithEvents a4wMenyStrip As MenuStrip
    Friend WithEvents a4wFontDialog As FontDialog
    Friend WithEvents btnSNITT As Button
    Friend WithEvents nudLEFT As NumericUpDown
    Friend WithEvents nudRIGHT As NumericUpDown
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents nudTOP As NumericUpDown
    Friend WithEvents nudBOTTOM As NumericUpDown
    Friend WithEvents lblTop As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents tsmSTART As ToolStripMenuItem
    Friend WithEvents tsmiNew As ToolStripMenuItem
    Friend WithEvents btnCT As Button
    Friend WithEvents btnCY As Button
    Friend WithEvents btnPT As Button
    Friend WithEvents pbEE As PictureBox
    Friend WithEvents a4wPrintDialog As PrintDialog
    Friend WithEvents tsmiOpen As ToolStripMenuItem
    Friend WithEvents tsmiSave As ToolStripMenuItem
    Friend WithEvents tsmiSA As ToolStripMenuItem
    Friend WithEvents tsmiPP As ToolStripMenuItem
    Friend WithEvents tsmiPrint As ToolStripMenuItem
    Friend WithEvents btnRA4 As Button
    Friend WithEvents pbAU As PictureBox
    Friend WithEvents pbAD As PictureBox
    Friend WithEvents tbBROWS As TextBox
    Friend WithEvents btnLEFT As Button
    Friend WithEvents btnOPEN As Button
    Friend WithEvents btnSAVE As Button
    Friend WithEvents btnSAVEAS As Button
    Friend WithEvents btnPREVIEW As Button
    Friend WithEvents btnPRINT As Button
    Friend WithEvents tbSNITT As TextBox
    Friend WithEvents btnCENTER As Button
    Friend WithEvents btnRIGHT As Button
    Friend WithEvents btnOWN As Button
    Friend WithEvents btnUO As Button
    Friend WithEvents btnRO As Button
    Friend WithEvents a4wOpenFileDialog As OpenFileDialog
    Friend WithEvents a4wSaveFileDialog As SaveFileDialog
    Friend WithEvents btnBL As Button
    Friend WithEvents btnLOUT As Button
    Friend WithEvents btnREPLACE As Button
    Friend WithEvents btnSEARCH As Button
    Friend WithEvents btnLIN As Button
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents tsmEDIT As ToolStripMenuItem
    Friend WithEvents tsmiUndo As ToolStripMenuItem
    Friend WithEvents tsmiRedo As ToolStripMenuItem
    Friend WithEvents tssCopy As ToolStripSeparator
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiCut As ToolStripMenuItem
    Friend WithEvents tsmiPaste As ToolStripMenuItem
    Friend WithEvents tsmiClearall As ToolStripMenuItem
    Friend WithEvents tssSearch As ToolStripSeparator
    Friend WithEvents tsmiSearch As ToolStripMenuItem
    Friend WithEvents tsmiReplace As ToolStripMenuItem
    Friend WithEvents tsmFORMAT As ToolStripMenuItem
    Friend WithEvents tsmiAlignL As ToolStripMenuItem
    Friend WithEvents tsmiAlignC As ToolStripMenuItem
    Friend WithEvents tsmiAlignR As ToolStripMenuItem
    Friend WithEvents tsmiAlignJ As ToolStripMenuItem
    Friend WithEvents tssSpacing As ToolStripSeparator
    Friend WithEvents tsmiSpacing As ToolStripMenuItem
    Friend WithEvents tsmOBJECT As ToolStripMenuItem
    Friend WithEvents tsmiImageL As ToolStripMenuItem
    Friend WithEvents tsmiBrowser As ToolStripMenuItem
    Friend WithEvents tsmiBulletl As ToolStripMenuItem
    Friend WithEvents tsmiFont As ToolStripMenuItem
    Friend WithEvents tssAlignL As ToolStripSeparator
    Friend WithEvents tsmiDeselectall As ToolStripMenuItem
    Friend WithEvents a4wToolTip As ToolTip
    Friend WithEvents btnFORMAT As Button
    Friend WithEvents tsmiSelectall As ToolStripMenuItem
    Friend WithEvents btnRIN As Button
    Friend WithEvents btnROUT As Button
    Friend WithEvents btnRESETINDENT As Button
    Friend WithEvents btnIMAGE As Button
    Friend WithEvents rbL As RadioButton
    Friend WithEvents rbC As RadioButton
    Friend WithEvents rbR As RadioButton
    Friend WithEvents imgOpenFileDialog As OpenFileDialog
    Friend WithEvents tsmiIndent As ToolStripMenuItem
    Friend WithEvents tsmiBColor As ToolStripMenuItem
    Friend WithEvents a4wPrintDocument As Printing.PrintDocument
    Friend WithEvents a4wPrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents tbPAGES As TextBox
    Friend WithEvents btnJUST As Button
    Friend WithEvents btnCOLOR As Button
    Friend WithEvents tsmiFColor As ToolStripMenuItem
    Friend WithEvents tsmiLatest As ToolStripMenuItem
    Friend WithEvents tsmiCLatest As ToolStripMenuItem
    Friend WithEvents btnBCOLOR As Button
    Friend WithEvents btnSUP As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnSPACE As Button
    Friend WithEvents nudSL As NumericUpDown
    Friend WithEvents btnNL As Button
    Friend WithEvents tsmiCap As ToolStripMenuItem
    Friend WithEvents tsmiLow As ToolStripMenuItem
    Friend WithEvents tsmiNumberl As ToolStripMenuItem
    Friend WithEvents btnOHM As Button
    Friend WithEvents tsmiSymbol As ToolStripMenuItem
    Friend WithEvents tsmiA4BColor As ToolStripMenuItem
    Friend WithEvents btnSELECTALL As Button
    Friend WithEvents btnDESELECTALL As Button
    Friend WithEvents btnINDENTBL As Button
    Friend WithEvents btnSTYLENL As Button
    Friend WithEvents btnTAB As Button
    Friend WithEvents btnINDENT As Button
    Friend WithEvents tsmiTab As ToolStripMenuItem
    Friend WithEvents tsmiEncoding As ToolStripMenuItem
    Friend WithEvents tsmiA4S As ToolStripMenuItem
    Friend WithEvents tsmiRecreate As ToolStripMenuItem
    Friend WithEvents tsmiTXTsizefont As ToolStripMenuItem
    Friend WithEvents tsmiINITpos As ToolStripMenuItem
End Class
