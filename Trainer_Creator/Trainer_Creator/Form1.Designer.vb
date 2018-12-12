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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxAge = New System.Windows.Forms.TextBox()
        Me.txtbxHeight = New System.Windows.Forms.TextBox()
        Me.txtbxWeight = New System.Windows.Forms.TextBox()
        Me.txtbxMoney = New System.Windows.Forms.TextBox()
        Me.txtbxHp = New System.Windows.Forms.TextBox()
        Me.lblTotalhp = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.lblClassAdjusted = New System.Windows.Forms.Label()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.txtbxStr = New System.Windows.Forms.TextBox()
        Me.txtbxDex = New System.Windows.Forms.TextBox()
        Me.txtbxCon = New System.Windows.Forms.TextBox()
        Me.txtbxInt = New System.Windows.Forms.TextBox()
        Me.txtbxWis = New System.Windows.Forms.TextBox()
        Me.txtbxCha = New System.Windows.Forms.TextBox()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.lblDexterity = New System.Windows.Forms.Label()
        Me.lblConstitution = New System.Windows.Forms.Label()
        Me.lblIntelligence = New System.Windows.Forms.Label()
        Me.lblWisdom = New System.Windows.Forms.Label()
        Me.lblCharisma = New System.Windows.Forms.Label()
        Me.lblPointsLeft = New System.Windows.Forms.Label()
        Me.lblAdjStr = New System.Windows.Forms.Label()
        Me.lblAdjDex = New System.Windows.Forms.Label()
        Me.lblAdjCon = New System.Windows.Forms.Label()
        Me.lblAdjInt = New System.Windows.Forms.Label()
        Me.lblAdjWis = New System.Windows.Forms.Label()
        Me.lblAdjCha = New System.Windows.Forms.Label()
        Me.lblModStr = New System.Windows.Forms.Label()
        Me.lblModDex = New System.Windows.Forms.Label()
        Me.lblModCon = New System.Windows.Forms.Label()
        Me.lblModInt = New System.Windows.Forms.Label()
        Me.lblModWis = New System.Windows.Forms.Label()
        Me.lblModCha = New System.Windows.Forms.Label()
        Me.cbxClass1 = New System.Windows.Forms.ComboBox()
        Me.cbxClass2 = New System.Windows.Forms.ComboBox()
        Me.cbxClass3 = New System.Windows.Forms.ComboBox()
        Me.cbxClass4 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lbox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 27)
        Me.Label1.MaximumSize = New System.Drawing.Size(47, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(252, 27)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(81, 20)
        Me.txtbxName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age/Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(188, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Money"
        '
        'txtbxAge
        '
        Me.txtbxAge.Location = New System.Drawing.Point(252, 55)
        Me.txtbxAge.Name = "txtbxAge"
        Me.txtbxAge.Size = New System.Drawing.Size(54, 20)
        Me.txtbxAge.TabIndex = 9
        Me.txtbxAge.Text = "12/F"
        '
        'txtbxHeight
        '
        Me.txtbxHeight.Location = New System.Drawing.Point(252, 83)
        Me.txtbxHeight.Name = "txtbxHeight"
        Me.txtbxHeight.Size = New System.Drawing.Size(46, 20)
        Me.txtbxHeight.TabIndex = 10
        Me.txtbxHeight.Text = "5'6"
        '
        'txtbxWeight
        '
        Me.txtbxWeight.Location = New System.Drawing.Point(252, 111)
        Me.txtbxWeight.Name = "txtbxWeight"
        Me.txtbxWeight.Size = New System.Drawing.Size(46, 20)
        Me.txtbxWeight.TabIndex = 11
        Me.txtbxWeight.Text = "150"
        '
        'txtbxMoney
        '
        Me.txtbxMoney.Location = New System.Drawing.Point(252, 167)
        Me.txtbxMoney.Name = "txtbxMoney"
        Me.txtbxMoney.Size = New System.Drawing.Size(69, 20)
        Me.txtbxMoney.TabIndex = 12
        Me.txtbxMoney.Text = "5000"
        '
        'txtbxHp
        '
        Me.txtbxHp.Location = New System.Drawing.Point(252, 139)
        Me.txtbxHp.Name = "txtbxHp"
        Me.txtbxHp.Size = New System.Drawing.Size(46, 20)
        Me.txtbxHp.TabIndex = 13
        Me.txtbxHp.Text = "50"
        '
        'lblTotalhp
        '
        Me.lblTotalhp.AutoSize = True
        Me.lblTotalhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalhp.Location = New System.Drawing.Point(306, 141)
        Me.lblTotalhp.Name = "lblTotalhp"
        Me.lblTotalhp.Size = New System.Drawing.Size(13, 16)
        Me.lblTotalhp.TabIndex = 14
        Me.lblTotalhp.Text = "/"
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.Location = New System.Drawing.Point(84, 189)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(36, 13)
        Me.lblStats.TabIndex = 15
        Me.lblStats.Text = "Stats"
        '
        'lblClassAdjusted
        '
        Me.lblClassAdjusted.AutoSize = True
        Me.lblClassAdjusted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassAdjusted.Location = New System.Drawing.Point(129, 189)
        Me.lblClassAdjusted.Name = "lblClassAdjusted"
        Me.lblClassAdjusted.Size = New System.Drawing.Size(90, 13)
        Me.lblClassAdjusted.TabIndex = 16
        Me.lblClassAdjusted.Text = "Class Adjusted"
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModifier.Location = New System.Drawing.Point(238, 189)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(52, 13)
        Me.lblModifier.TabIndex = 17
        Me.lblModifier.Text = "Modifier"
        '
        'txtbxStr
        '
        Me.txtbxStr.Location = New System.Drawing.Point(87, 206)
        Me.txtbxStr.Name = "txtbxStr"
        Me.txtbxStr.Size = New System.Drawing.Size(32, 20)
        Me.txtbxStr.TabIndex = 18
        Me.txtbxStr.Text = "10"
        '
        'txtbxDex
        '
        Me.txtbxDex.Location = New System.Drawing.Point(87, 232)
        Me.txtbxDex.Name = "txtbxDex"
        Me.txtbxDex.Size = New System.Drawing.Size(32, 20)
        Me.txtbxDex.TabIndex = 19
        Me.txtbxDex.Text = "10"
        '
        'txtbxCon
        '
        Me.txtbxCon.Location = New System.Drawing.Point(87, 258)
        Me.txtbxCon.Name = "txtbxCon"
        Me.txtbxCon.Size = New System.Drawing.Size(32, 20)
        Me.txtbxCon.TabIndex = 20
        Me.txtbxCon.Text = "10"
        '
        'txtbxInt
        '
        Me.txtbxInt.Location = New System.Drawing.Point(87, 284)
        Me.txtbxInt.Name = "txtbxInt"
        Me.txtbxInt.Size = New System.Drawing.Size(32, 20)
        Me.txtbxInt.TabIndex = 21
        Me.txtbxInt.Text = "10"
        '
        'txtbxWis
        '
        Me.txtbxWis.Location = New System.Drawing.Point(87, 310)
        Me.txtbxWis.Name = "txtbxWis"
        Me.txtbxWis.Size = New System.Drawing.Size(32, 20)
        Me.txtbxWis.TabIndex = 22
        Me.txtbxWis.Text = "10"
        '
        'txtbxCha
        '
        Me.txtbxCha.Location = New System.Drawing.Point(87, 336)
        Me.txtbxCha.Name = "txtbxCha"
        Me.txtbxCha.Size = New System.Drawing.Size(32, 20)
        Me.txtbxCha.TabIndex = 23
        Me.txtbxCha.Text = "10"
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrength.Location = New System.Drawing.Point(0, 209)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(55, 13)
        Me.lblStrength.TabIndex = 24
        Me.lblStrength.Text = "Strength"
        '
        'lblDexterity
        '
        Me.lblDexterity.AutoSize = True
        Me.lblDexterity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDexterity.Location = New System.Drawing.Point(0, 235)
        Me.lblDexterity.Name = "lblDexterity"
        Me.lblDexterity.Size = New System.Drawing.Size(57, 13)
        Me.lblDexterity.TabIndex = 25
        Me.lblDexterity.Text = "Dexterity"
        '
        'lblConstitution
        '
        Me.lblConstitution.AutoSize = True
        Me.lblConstitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConstitution.Location = New System.Drawing.Point(0, 261)
        Me.lblConstitution.Name = "lblConstitution"
        Me.lblConstitution.Size = New System.Drawing.Size(74, 13)
        Me.lblConstitution.TabIndex = 26
        Me.lblConstitution.Text = "Constitution"
        '
        'lblIntelligence
        '
        Me.lblIntelligence.AutoSize = True
        Me.lblIntelligence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntelligence.Location = New System.Drawing.Point(0, 287)
        Me.lblIntelligence.Name = "lblIntelligence"
        Me.lblIntelligence.Size = New System.Drawing.Size(73, 13)
        Me.lblIntelligence.TabIndex = 27
        Me.lblIntelligence.Text = "Intelligence"
        '
        'lblWisdom
        '
        Me.lblWisdom.AutoSize = True
        Me.lblWisdom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWisdom.Location = New System.Drawing.Point(0, 312)
        Me.lblWisdom.Name = "lblWisdom"
        Me.lblWisdom.Size = New System.Drawing.Size(51, 13)
        Me.lblWisdom.TabIndex = 28
        Me.lblWisdom.Text = "Wisdom"
        '
        'lblCharisma
        '
        Me.lblCharisma.AutoSize = True
        Me.lblCharisma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharisma.Location = New System.Drawing.Point(0, 338)
        Me.lblCharisma.Name = "lblCharisma"
        Me.lblCharisma.Size = New System.Drawing.Size(58, 13)
        Me.lblCharisma.TabIndex = 29
        Me.lblCharisma.Text = "Charisma"
        '
        'lblPointsLeft
        '
        Me.lblPointsLeft.AutoSize = True
        Me.lblPointsLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsLeft.Location = New System.Drawing.Point(0, 366)
        Me.lblPointsLeft.Name = "lblPointsLeft"
        Me.lblPointsLeft.Size = New System.Drawing.Size(76, 13)
        Me.lblPointsLeft.TabIndex = 30
        Me.lblPointsLeft.Text = "Points Left :"
        '
        'lblAdjStr
        '
        Me.lblAdjStr.AutoSize = True
        Me.lblAdjStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjStr.Location = New System.Drawing.Point(174, 209)
        Me.lblAdjStr.Name = "lblAdjStr"
        Me.lblAdjStr.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjStr.TabIndex = 31
        Me.lblAdjStr.Text = "0"
        '
        'lblAdjDex
        '
        Me.lblAdjDex.AutoSize = True
        Me.lblAdjDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjDex.Location = New System.Drawing.Point(174, 235)
        Me.lblAdjDex.Name = "lblAdjDex"
        Me.lblAdjDex.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjDex.TabIndex = 32
        Me.lblAdjDex.Text = "0"
        '
        'lblAdjCon
        '
        Me.lblAdjCon.AutoSize = True
        Me.lblAdjCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjCon.Location = New System.Drawing.Point(174, 261)
        Me.lblAdjCon.Name = "lblAdjCon"
        Me.lblAdjCon.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjCon.TabIndex = 33
        Me.lblAdjCon.Text = "0"
        '
        'lblAdjInt
        '
        Me.lblAdjInt.AutoSize = True
        Me.lblAdjInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjInt.Location = New System.Drawing.Point(174, 287)
        Me.lblAdjInt.Name = "lblAdjInt"
        Me.lblAdjInt.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjInt.TabIndex = 34
        Me.lblAdjInt.Text = "0"
        '
        'lblAdjWis
        '
        Me.lblAdjWis.AutoSize = True
        Me.lblAdjWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjWis.Location = New System.Drawing.Point(174, 313)
        Me.lblAdjWis.Name = "lblAdjWis"
        Me.lblAdjWis.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjWis.TabIndex = 35
        Me.lblAdjWis.Text = "0"
        '
        'lblAdjCha
        '
        Me.lblAdjCha.AutoSize = True
        Me.lblAdjCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjCha.Location = New System.Drawing.Point(174, 339)
        Me.lblAdjCha.Name = "lblAdjCha"
        Me.lblAdjCha.Size = New System.Drawing.Size(14, 13)
        Me.lblAdjCha.TabIndex = 36
        Me.lblAdjCha.Text = "0"
        '
        'lblModStr
        '
        Me.lblModStr.AutoSize = True
        Me.lblModStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModStr.Location = New System.Drawing.Point(260, 209)
        Me.lblModStr.Name = "lblModStr"
        Me.lblModStr.Size = New System.Drawing.Size(14, 13)
        Me.lblModStr.TabIndex = 37
        Me.lblModStr.Text = "0"
        '
        'lblModDex
        '
        Me.lblModDex.AutoSize = True
        Me.lblModDex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModDex.Location = New System.Drawing.Point(260, 235)
        Me.lblModDex.Name = "lblModDex"
        Me.lblModDex.Size = New System.Drawing.Size(14, 13)
        Me.lblModDex.TabIndex = 38
        Me.lblModDex.Text = "0"
        '
        'lblModCon
        '
        Me.lblModCon.AutoSize = True
        Me.lblModCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModCon.Location = New System.Drawing.Point(260, 261)
        Me.lblModCon.Name = "lblModCon"
        Me.lblModCon.Size = New System.Drawing.Size(14, 13)
        Me.lblModCon.TabIndex = 39
        Me.lblModCon.Text = "0"
        '
        'lblModInt
        '
        Me.lblModInt.AutoSize = True
        Me.lblModInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModInt.Location = New System.Drawing.Point(260, 287)
        Me.lblModInt.Name = "lblModInt"
        Me.lblModInt.Size = New System.Drawing.Size(14, 13)
        Me.lblModInt.TabIndex = 40
        Me.lblModInt.Text = "0"
        '
        'lblModWis
        '
        Me.lblModWis.AutoSize = True
        Me.lblModWis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModWis.Location = New System.Drawing.Point(260, 312)
        Me.lblModWis.Name = "lblModWis"
        Me.lblModWis.Size = New System.Drawing.Size(14, 13)
        Me.lblModWis.TabIndex = 41
        Me.lblModWis.Text = "0"
        '
        'lblModCha
        '
        Me.lblModCha.AutoSize = True
        Me.lblModCha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModCha.Location = New System.Drawing.Point(260, 338)
        Me.lblModCha.Name = "lblModCha"
        Me.lblModCha.Size = New System.Drawing.Size(14, 13)
        Me.lblModCha.TabIndex = 42
        Me.lblModCha.Text = "0"
        '
        'cbxClass1
        '
        Me.cbxClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClass1.FormattingEnabled = True
        Me.cbxClass1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbxClass1.Items.AddRange(New Object() {"None", "Ace Trainer", "Breeder", "Capture Specialist", "Coordinator", "Martial Artist", "Mystic", "Psychic", "Ranger", "Researcher"})
        Me.cbxClass1.Location = New System.Drawing.Point(407, 49)
        Me.cbxClass1.Name = "cbxClass1"
        Me.cbxClass1.Size = New System.Drawing.Size(154, 21)
        Me.cbxClass1.TabIndex = 43
        '
        'cbxClass2
        '
        Me.cbxClass2.AllowDrop = True
        Me.cbxClass2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClass2.FormattingEnabled = True
        Me.cbxClass2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbxClass2.Items.AddRange(New Object() {"None", "Ace Trainer", "Breeder", "Capture Specialist", "Coordinator", "Martial Artist", "Mystic", "Psychic", "Ranger", "Researcher"})
        Me.cbxClass2.Location = New System.Drawing.Point(407, 76)
        Me.cbxClass2.Name = "cbxClass2"
        Me.cbxClass2.Size = New System.Drawing.Size(154, 21)
        Me.cbxClass2.TabIndex = 44
        '
        'cbxClass3
        '
        Me.cbxClass3.AllowDrop = True
        Me.cbxClass3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClass3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClass3.FormattingEnabled = True
        Me.cbxClass3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbxClass3.Items.AddRange(New Object() {"None", "Ace Trainer", "Breeder", "Capture Specialist", "Coordinator", "Martial Artist", "Mystic", "Psychic", "Ranger", "Researcher"})
        Me.cbxClass3.Location = New System.Drawing.Point(407, 103)
        Me.cbxClass3.Name = "cbxClass3"
        Me.cbxClass3.Size = New System.Drawing.Size(154, 21)
        Me.cbxClass3.TabIndex = 45
        '
        'cbxClass4
        '
        Me.cbxClass4.AllowDrop = True
        Me.cbxClass4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxClass4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxClass4.FormattingEnabled = True
        Me.cbxClass4.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cbxClass4.Items.AddRange(New Object() {"None", "Ace Trainer", "Breeder", "Capture Specialist", "Coordinator", "Martial Artist", "Mystic", "Psychic", "Ranger", "Researcher"})
        Me.cbxClass4.Location = New System.Drawing.Point(407, 130)
        Me.cbxClass4.Name = "cbxClass4"
        Me.cbxClass4.Size = New System.Drawing.Size(154, 21)
        Me.cbxClass4.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Level :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Classes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Stat Boost"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(201, 363)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(31, 20)
        Me.TextBox1.TabIndex = 50
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(392, 29)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(14, 13)
        Me.lblLevel.TabIndex = 51
        Me.lblLevel.Text = "1"
        '
        'lbox1
        '
        Me.lbox1.FormattingEnabled = True
        Me.lbox1.Items.AddRange(New Object() {"pokemon1", "pokemon2", "pokemon3", "pokemon4", "pokemon5", "pokemon6"})
        Me.lbox1.Location = New System.Drawing.Point(309, 209)
        Me.lbox1.Name = "lbox1"
        Me.lbox1.Size = New System.Drawing.Size(120, 82)
        Me.lbox1.TabIndex = 52
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(441, 206)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 53
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 408)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.lbox1)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxClass4)
        Me.Controls.Add(Me.cbxClass3)
        Me.Controls.Add(Me.cbxClass2)
        Me.Controls.Add(Me.cbxClass1)
        Me.Controls.Add(Me.lblModCha)
        Me.Controls.Add(Me.lblModWis)
        Me.Controls.Add(Me.lblModInt)
        Me.Controls.Add(Me.lblModCon)
        Me.Controls.Add(Me.lblModDex)
        Me.Controls.Add(Me.lblModStr)
        Me.Controls.Add(Me.lblAdjCha)
        Me.Controls.Add(Me.lblAdjWis)
        Me.Controls.Add(Me.lblAdjInt)
        Me.Controls.Add(Me.lblAdjCon)
        Me.Controls.Add(Me.lblAdjDex)
        Me.Controls.Add(Me.lblAdjStr)
        Me.Controls.Add(Me.lblPointsLeft)
        Me.Controls.Add(Me.lblCharisma)
        Me.Controls.Add(Me.lblWisdom)
        Me.Controls.Add(Me.lblIntelligence)
        Me.Controls.Add(Me.lblConstitution)
        Me.Controls.Add(Me.lblDexterity)
        Me.Controls.Add(Me.lblStrength)
        Me.Controls.Add(Me.txtbxCha)
        Me.Controls.Add(Me.txtbxWis)
        Me.Controls.Add(Me.txtbxInt)
        Me.Controls.Add(Me.txtbxCon)
        Me.Controls.Add(Me.txtbxDex)
        Me.Controls.Add(Me.txtbxStr)
        Me.Controls.Add(Me.lblModifier)
        Me.Controls.Add(Me.lblClassAdjusted)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.lblTotalhp)
        Me.Controls.Add(Me.txtbxHp)
        Me.Controls.Add(Me.txtbxMoney)
        Me.Controls.Add(Me.txtbxWeight)
        Me.Controls.Add(Me.txtbxHeight)
        Me.Controls.Add(Me.txtbxAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Class"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxAge As TextBox
    Friend WithEvents txtbxHeight As TextBox
    Friend WithEvents txtbxWeight As TextBox
    Friend WithEvents txtbxMoney As TextBox
    Friend WithEvents txtbxHp As TextBox
    Friend WithEvents lblTotalhp As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents lblClassAdjusted As Label
    Friend WithEvents lblModifier As Label
    Friend WithEvents txtbxStr As TextBox
    Friend WithEvents txtbxDex As TextBox
    Friend WithEvents txtbxCon As TextBox
    Friend WithEvents txtbxInt As TextBox
    Friend WithEvents txtbxWis As TextBox
    Friend WithEvents txtbxCha As TextBox
    Friend WithEvents lblStrength As Label
    Friend WithEvents lblDexterity As Label
    Friend WithEvents lblConstitution As Label
    Friend WithEvents lblIntelligence As Label
    Friend WithEvents lblWisdom As Label
    Friend WithEvents lblCharisma As Label
    Friend WithEvents lblPointsLeft As Label
    Friend WithEvents lblAdjStr As Label
    Friend WithEvents lblAdjDex As Label
    Friend WithEvents lblAdjCon As Label
    Friend WithEvents lblAdjInt As Label
    Friend WithEvents lblAdjWis As Label
    Friend WithEvents lblAdjCha As Label
    Friend WithEvents lblModStr As Label
    Friend WithEvents lblModDex As Label
    Friend WithEvents lblModCon As Label
    Friend WithEvents lblModInt As Label
    Friend WithEvents lblModWis As Label
    Friend WithEvents lblModCha As Label
    Friend WithEvents cbxClass1 As ComboBox
    Friend WithEvents cbxClass2 As ComboBox
    Friend WithEvents cbxClass3 As ComboBox
    Friend WithEvents cbxClass4 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblLevel As Label
    Friend WithEvents lbox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
