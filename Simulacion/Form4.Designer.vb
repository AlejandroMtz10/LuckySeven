<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadradosCentralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CongruencialMixtoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BonusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuckySevenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Harlow Solid Italic", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(239, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(690, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generador de numeros aleatorios."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneradorToolStripMenuItem, Me.BonusToolStripMenuItem1, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1165, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneradorToolStripMenuItem
        '
        Me.GeneradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuadradosCentralesToolStripMenuItem, Me.CongruencialMixtoToolStripMenuItem})
        Me.GeneradorToolStripMenuItem.Name = "GeneradorToolStripMenuItem"
        Me.GeneradorToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.GeneradorToolStripMenuItem.Text = "Generador"
        '
        'CuadradosCentralesToolStripMenuItem
        '
        Me.CuadradosCentralesToolStripMenuItem.Name = "CuadradosCentralesToolStripMenuItem"
        Me.CuadradosCentralesToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CuadradosCentralesToolStripMenuItem.Text = "Cuadrados centrales"
        '
        'CongruencialMixtoToolStripMenuItem
        '
        Me.CongruencialMixtoToolStripMenuItem.Name = "CongruencialMixtoToolStripMenuItem"
        Me.CongruencialMixtoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CongruencialMixtoToolStripMenuItem.Text = "Congruencial mixto"
        '
        'BonusToolStripMenuItem1
        '
        Me.BonusToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LuckySevenToolStripMenuItem})
        Me.BonusToolStripMenuItem1.Name = "BonusToolStripMenuItem1"
        Me.BonusToolStripMenuItem1.Size = New System.Drawing.Size(61, 24)
        Me.BonusToolStripMenuItem1.Text = "Bonus"
        '
        'LuckySevenToolStripMenuItem
        '
        Me.LuckySevenToolStripMenuItem.Name = "LuckySevenToolStripMenuItem"
        Me.LuckySevenToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.LuckySevenToolStripMenuItem.Text = "Lucky Seven"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(571, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 666)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeneradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadradosCentralesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CongruencialMixtoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BonusToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LuckySevenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
