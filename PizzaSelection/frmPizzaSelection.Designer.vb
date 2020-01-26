<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPizzaSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.PicThinCrust = New System.Windows.Forms.PictureBox()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeading.Location = New System.Drawing.Point(118, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(179, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(44, 250)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(327, 14)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Choose a pizza type and then click the Select Pizza button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Location = New System.Drawing.Point(143, 277)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(128, 13)
        Me.lblConfirmation.TabIndex = 2
        Me.lblConfirmation.Text = "Enjoy your pizza selection"
        Me.lblConfirmation.Visible = False
        '
        'PicThinCrust
        '
        Me.PicThinCrust.Image = CType(resources.GetObject("PicThinCrust.Image"), System.Drawing.Image)
        Me.PicThinCrust.Location = New System.Drawing.Point(217, 45)
        Me.PicThinCrust.Name = "PicThinCrust"
        Me.PicThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.PicThinCrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicThinCrust.TabIndex = 3
        Me.PicThinCrust.TabStop = False
        Me.PicThinCrust.Visible = False
        '
        'picDeepDish
        '
        Me.picDeepDish.Image = CType(resources.GetObject("picDeepDish.Image"), System.Drawing.Image)
        Me.picDeepDish.Location = New System.Drawing.Point(12, 45)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.picDeepDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeepDish.TabIndex = 4
        Me.picDeepDish.TabStop = False
        Me.picDeepDish.Visible = False
        '
        'btnThinCrust
        '
        Me.btnThinCrust.BackColor = System.Drawing.Color.Wheat
        Me.btnThinCrust.Location = New System.Drawing.Point(284, 201)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(75, 23)
        Me.btnThinCrust.TabIndex = 5
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = False
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.BackColor = System.Drawing.Color.Wheat
        Me.btnSelectPizza.Enabled = False
        Me.btnSelectPizza.Location = New System.Drawing.Point(170, 201)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectPizza.TabIndex = 6
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = False
        '
        'btnDeepDish
        '
        Me.btnDeepDish.BackColor = System.Drawing.Color.Wheat
        Me.btnDeepDish.Location = New System.Drawing.Point(64, 201)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(75, 23)
        Me.btnDeepDish.TabIndex = 7
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Wheat
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(170, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.PicThinCrust)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.PicThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents PicThinCrust As PictureBox
    Friend WithEvents picDeepDish As PictureBox
    Friend WithEvents btnThinCrust As Button
    Friend WithEvents btnSelectPizza As Button
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnExit As Button
End Class
