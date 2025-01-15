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
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(450, 500)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False

        'Title Label
        Dim titleLabel As New Label()
        titleLabel.Text = "Connexion"
        titleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        titleLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
        titleLabel.Size = New System.Drawing.Size(300, 50)
        titleLabel.Location = New System.Drawing.Point(75, 40)
        titleLabel.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(titleLabel)

        'Username TextBox
        uti.Size = New System.Drawing.Size(300, 35)
        uti.Location = New System.Drawing.Point(75, 150)
        uti.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        uti.BorderStyle = BorderStyle.FixedSingle
        uti.PlaceholderText = "Nom d'utilisateur"

        'Password TextBox
        mdp.Size = New System.Drawing.Size(300, 35)
        mdp.Location = New System.Drawing.Point(75, 220)
        mdp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        mdp.BorderStyle = BorderStyle.FixedSingle
        mdp.PasswordChar = "•"
        mdp.PlaceholderText = "Mot de passe"

        'Login Button
        con.Size = New System.Drawing.Size(300, 45)
        con.Location = New System.Drawing.Point(75, 300)
        con.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        con.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        con.ForeColor = System.Drawing.Color.White
        con.FlatStyle = FlatStyle.Flat
        con.FlatAppearance.BorderSize = 0
        con.Text = "Se connecter"
        con.Cursor = Cursors.Hand

        'Message Label
        msg.Size = New System.Drawing.Size(300, 40)
        msg.Location = New System.Drawing.Point(75, 360)
        msg.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        msg.ForeColor = System.Drawing.Color.Red
        msg.TextAlign = ContentAlignment.MiddleCenter

        Me.Controls.Add(uti)
        Me.Controls.Add(mdp)
        Me.Controls.Add(con)
        Me.Controls.Add(msg)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uti As TextBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents con As Button
    Friend WithEvents msg As Label

End Class
