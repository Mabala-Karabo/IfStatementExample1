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
        btnGreetings = New Button()
        Label1 = New Label()
        txtCountry = New TextBox()
        SuspendLayout()
        ' 
        ' btnGreetings
        ' 
        btnGreetings.Location = New Point(582, 278)
        btnGreetings.Name = "btnGreetings"
        btnGreetings.Size = New Size(112, 34)
        btnGreetings.TabIndex = 0
        btnGreetings.Text = "Greetings"
        btnGreetings.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter your country"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(273, 64)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(150, 31)
        txtCountry.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCountry)
        Controls.Add(Label1)
        Controls.Add(btnGreetings)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreetings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountry As TextBox
End Class
