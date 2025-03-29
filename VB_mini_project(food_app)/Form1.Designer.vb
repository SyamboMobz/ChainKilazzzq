<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnMyCart = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnDeserts = New System.Windows.Forms.Button()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.Teal
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.PictureBox2)
        Me.pnlLeftSide.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlLeftSide.Controls.Add(Me.PictureBox1)
        Me.pnlLeftSide.Controls.Add(Me.Label19)
        Me.pnlLeftSide.Controls.Add(Me.Label16)
        Me.pnlLeftSide.Controls.Add(Me.btnAboutUs)
        Me.pnlLeftSide.Controls.Add(Me.btnMyCart)
        Me.pnlLeftSide.Controls.Add(Me.btnDrinks)
        Me.pnlLeftSide.Controls.Add(Me.btnDeserts)
        Me.pnlLeftSide.Controls.Add(Me.btnFoods)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLeftSide.Location = New System.Drawing.Point(709, 29)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(176, 606)
        Me.pnlLeftSide.TabIndex = 0
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 165)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(11, 57)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.VB_mini_project.My.Resources.Resources.menu_icon_white_png_5
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(176, 141)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(80, 333)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.VB_mini_project.My.Resources.Resources.white_menu_icon_png_18
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(122, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 61)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Comic Sans MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(56, 93)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 53)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Food"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(40, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 53)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Menu"
        '
        'btnAboutUs
        '
        Me.btnAboutUs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAboutUs.Image = Global.VB_mini_project.My.Resources.Resources.btnAboutUs2
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 406)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(176, 58)
        Me.btnAboutUs.TabIndex = 8
        Me.btnAboutUs.Text = "    About  "
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnMyCart
        '
        Me.btnMyCart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMyCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyCart.FlatAppearance.BorderSize = 0
        Me.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyCart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMyCart.Image = Global.VB_mini_project.My.Resources.Resources.picCart
        Me.btnMyCart.Location = New System.Drawing.Point(0, 345)
        Me.btnMyCart.Name = "btnMyCart"
        Me.btnMyCart.Size = New System.Drawing.Size(176, 58)
        Me.btnMyCart.TabIndex = 6
        Me.btnMyCart.Text = "    MyCart "
        Me.btnMyCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMyCart.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrinks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDrinks.Image = Global.VB_mini_project.My.Resources.Resources.btnDrinks
        Me.btnDrinks.Location = New System.Drawing.Point(0, 223)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(176, 58)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "    Drinks  "
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnDeserts
        '
        Me.btnDeserts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeserts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeserts.FlatAppearance.BorderSize = 0
        Me.btnDeserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeserts.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeserts.Image = Global.VB_mini_project.My.Resources.Resources.btnDessert
        Me.btnDeserts.Location = New System.Drawing.Point(0, 284)
        Me.btnDeserts.Name = "btnDeserts"
        Me.btnDeserts.Size = New System.Drawing.Size(176, 58)
        Me.btnDeserts.TabIndex = 2
        Me.btnDeserts.Text = "   Desserts"
        Me.btnDeserts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDeserts.UseVisualStyleBackColor = True
        '
        'btnFoods
        '
        Me.btnFoods.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFoods.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFoods.FlatAppearance.BorderSize = 0
        Me.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFoods.Image = Global.VB_mini_project.My.Resources.Resources.btnFoods
        Me.btnFoods.Location = New System.Drawing.Point(0, 162)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(176, 58)
        Me.btnFoods.TabIndex = 0
        Me.btnFoods.Text = "    Foods  "
        Me.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnFoods.UseVisualStyleBackColor = True
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.picMinimize)
        Me.pnlTopSide.Controls.Add(Me.picClose)
        Me.pnlTopSide.Controls.Add(Me.Label20)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(885, 29)
        Me.pnlTopSide.TabIndex = 1
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMinimize.Location = New System.Drawing.Point(830, 0)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(18, 29)
        Me.picMinimize.TabIndex = 13
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Location = New System.Drawing.Point(854, 0)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(18, 29)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(2, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(194, 29)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Looteds Fast Food"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTopSide
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 606)
        Me.Panel1.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 635)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTopSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlTopSide.PerformLayout()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnMyCart As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnDeserts As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label20 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
