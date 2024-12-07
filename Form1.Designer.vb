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
        lst = New ComboBox()
        RDproposition1 = New RadioButton()
        RDproposition2 = New RadioButton()
        RDproposition3 = New RadioButton()
        chkprop1 = New CheckBox()
        chkprop2 = New CheckBox()
        chkprop3 = New CheckBox()
        chkprop4 = New CheckBox()
        btn = New Button()
        Type_de_croute = New GroupBox()
        GroupBox2 = New GroupBox()
        Type_de_croute.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lst
        ' 
        lst.BackColor = Color.Cornsilk
        lst.FormattingEnabled = True
        lst.Items.AddRange(New Object() {"petit", "moyenne", "grand"})
        lst.Location = New Point(135, 51)
        lst.Name = "lst"
        lst.Size = New Size(496, 28)
        lst.TabIndex = 0
        ' 
        ' RDproposition1
        ' 
        RDproposition1.AutoSize = True
        RDproposition1.Location = New Point(15, 35)
        RDproposition1.Name = "RDproposition1"
        RDproposition1.Size = New Size(101, 24)
        RDproposition1.TabIndex = 1
        RDproposition1.TabStop = True
        RDproposition1.Text = "croute fine"
        RDproposition1.UseVisualStyleBackColor = True
        ' 
        ' RDproposition2
        ' 
        RDproposition2.AutoSize = True
        RDproposition2.Location = New Point(15, 91)
        RDproposition2.Name = "RDproposition2"
        RDproposition2.Size = New Size(136, 24)
        RDproposition2.TabIndex = 2
        RDproposition2.TabStop = True
        RDproposition2.Text = "croute classique"
        RDproposition2.UseVisualStyleBackColor = True
        ' 
        ' RDproposition3
        ' 
        RDproposition3.AutoSize = True
        RDproposition3.Location = New Point(15, 147)
        RDproposition3.Name = "RDproposition3"
        RDproposition3.Size = New Size(125, 24)
        RDproposition3.TabIndex = 3
        RDproposition3.TabStop = True
        RDproposition3.Text = "croute épaisse"
        RDproposition3.UseVisualStyleBackColor = True
        ' 
        ' chkprop1
        ' 
        chkprop1.AutoSize = True
        chkprop1.Location = New Point(16, 35)
        chkprop1.Name = "chkprop1"
        chkprop1.Size = New Size(120, 24)
        chkprop1.TabIndex = 4
        chkprop1.Text = "champignons"
        chkprop1.UseVisualStyleBackColor = True
        ' 
        ' chkprop2
        ' 
        chkprop2.AutoSize = True
        chkprop2.Location = New Point(16, 77)
        chkprop2.Name = "chkprop2"
        chkprop2.Size = New Size(69, 24)
        chkprop2.TabIndex = 5
        chkprop2.Text = "olives"
        chkprop2.UseVisualStyleBackColor = True
        ' 
        ' chkprop3
        ' 
        chkprop3.AutoSize = True
        chkprop3.Location = New Point(16, 124)
        chkprop3.Name = "chkprop3"
        chkprop3.Size = New Size(88, 24)
        chkprop3.TabIndex = 6
        chkprop3.Text = "poivrons"
        chkprop3.UseVisualStyleBackColor = True
        ' 
        ' chkprop4
        ' 
        chkprop4.AutoSize = True
        chkprop4.Location = New Point(16, 174)
        chkprop4.Name = "chkprop4"
        chkprop4.Size = New Size(201, 24)
        chkprop4.TabIndex = 7
        chkprop4.Text = "fromage supplémentaires"
        chkprop4.UseVisualStyleBackColor = True
        ' 
        ' btn
        ' 
        btn.BackColor = Color.LightGoldenrodYellow
        btn.Location = New Point(165, 421)
        btn.Name = "btn"
        btn.Size = New Size(454, 44)
        btn.TabIndex = 8
        btn.Text = "Afficher la récapitulatif"
        btn.UseVisualStyleBackColor = False
        ' 
        ' Type_de_croute
        ' 
        Type_de_croute.BackColor = SystemColors.ActiveCaption
        Type_de_croute.Controls.Add(RDproposition1)
        Type_de_croute.Controls.Add(RDproposition2)
        Type_de_croute.Controls.Add(RDproposition3)
        Type_de_croute.Location = New Point(455, 139)
        Type_de_croute.Name = "Type_de_croute"
        Type_de_croute.Size = New Size(274, 247)
        Type_de_croute.TabIndex = 9
        Type_de_croute.TabStop = False
        Type_de_croute.Text = "Type de croute"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(chkprop1)
        GroupBox2.Controls.Add(chkprop2)
        GroupBox2.Controls.Add(chkprop3)
        GroupBox2.Controls.Add(chkprop4)
        GroupBox2.Location = New Point(45, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 247)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "les ingredients"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 548)
        Controls.Add(GroupBox2)
        Controls.Add(Type_de_croute)
        Controls.Add(btn)
        Controls.Add(lst)
        Name = "Form1"
        Text = "Form1"
        Type_de_croute.ResumeLayout(False)
        Type_de_croute.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lst As ComboBox
    Friend WithEvents RDproposition1 As RadioButton
    Friend WithEvents RDproposition2 As RadioButton
    Friend WithEvents RDproposition3 As RadioButton
    Friend WithEvents chkprop1 As CheckBox
    Friend WithEvents chkprop2 As CheckBox
    Friend WithEvents chkprop3 As CheckBox
    Friend WithEvents chkprop4 As CheckBox
    Friend WithEvents btn As Button
    Friend WithEvents Type_de_croute As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
