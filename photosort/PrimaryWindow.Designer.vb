<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimaryWindow
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
        CurDisplay = New PictureBox()
        ButtonCSVload = New Button()
        csvTextbox = New TextBox()
        CType(CurDisplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CurDisplay
        ' 
        CurDisplay.BackColor = Color.Gray
        CurDisplay.BorderStyle = BorderStyle.Fixed3D
        CurDisplay.Dock = DockStyle.Top
        CurDisplay.Location = New Point(0, 0)
        CurDisplay.Name = "CurDisplay"
        CurDisplay.Size = New Size(900, 768)
        CurDisplay.SizeMode = PictureBoxSizeMode.Zoom
        CurDisplay.TabIndex = 0
        CurDisplay.TabStop = False
        ' 
        ' ButtonCSVload
        ' 
        ButtonCSVload.Location = New Point(201, 972)
        ButtonCSVload.Name = "ButtonCSVload"
        ButtonCSVload.Size = New Size(131, 40)
        ButtonCSVload.TabIndex = 2
        ButtonCSVload.Text = "load csv"
        ButtonCSVload.UseVisualStyleBackColor = True
        ' 
        ' csvTextbox
        ' 
        csvTextbox.AcceptsReturn = True
        csvTextbox.Location = New Point(8, 782)
        csvTextbox.Multiline = True
        csvTextbox.Name = "csvTextbox"
        csvTextbox.Size = New Size(880, 184)
        csvTextbox.TabIndex = 3
        ' 
        ' PrimaryWindow
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 30.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 1024)
        Controls.Add(csvTextbox)
        Controls.Add(ButtonCSVload)
        Controls.Add(CurDisplay)
        Name = "PrimaryWindow"
        Text = "Photosort & AI helper"
        CType(CurDisplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CurDisplay As PictureBox
    Friend WithEvents ButtonCSVload As Button
    Friend WithEvents csvTextbox As TextBox
End Class
