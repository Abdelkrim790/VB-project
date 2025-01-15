<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Réservation de Vols"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog

        Dim titleLabel As New Label()
        titleLabel.Text = "Réservation de Vols"
        titleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        titleLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
        titleLabel.Size = New System.Drawing.Size(400, 50)
        titleLabel.Location = New System.Drawing.Point(30, 20)
        titleLabel.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(titleLabel)

        Dim searchPanel As New Panel()
        searchPanel.Size = New System.Drawing.Size(940, 80)
        searchPanel.Location = New System.Drawing.Point(30, 90)
        searchPanel.BackColor = System.Drawing.Color.White
        searchPanel.BorderStyle = BorderStyle.None
        Me.Controls.Add(searchPanel)

        dest.Size = New System.Drawing.Size(350, 35)
        dest.Location = New System.Drawing.Point(20, 20)
        dest.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        dest.BorderStyle = BorderStyle.FixedSingle
        dest.PlaceholderText = "Destination"
        searchPanel.Controls.Add(dest)

        dateh.Size = New System.Drawing.Size(350, 35)
        dateh.Location = New System.Drawing.Point(390, 20)
        dateh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        dateh.BorderStyle = BorderStyle.FixedSingle
        dateh.PlaceholderText = "Date (JJ/MM/AAAA HH:MM)"
        searchPanel.Controls.Add(dateh)

        rech.Size = New System.Drawing.Size(150, 35)
        rech.Location = New System.Drawing.Point(760, 20)
        rech.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        rech.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        rech.ForeColor = System.Drawing.Color.White
        rech.FlatStyle = FlatStyle.Flat
        rech.FlatAppearance.BorderSize = 0
        rech.Text = "Rechercher"
        rech.Cursor = Cursors.Hand
        searchPanel.Controls.Add(rech)

        volst.Size = New System.Drawing.Size(940, 300)
        volst.Location = New System.Drawing.Point(30, 190)
        volst.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        volst.BackgroundColor = System.Drawing.Color.White
        volst.BorderStyle = BorderStyle.None
        volst.GridColor = System.Drawing.Color.FromArgb(230, 230, 230)
        volst.RowHeadersVisible = False
        volst.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        volst.MultiSelect = False
        volst.AllowUserToAddRows = False
        volst.AllowUserToDeleteRows = False
        volst.ReadOnly = True
        volst.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        volst.EnableHeadersVisualStyles = False
        volst.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 51, 51)
        volst.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        volst.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        volst.ColumnHeadersHeight = 40
        volst.RowTemplate.Height = 35
        volst.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.Controls.Add(volst)

        Dim reservationPanel As New Panel()
        reservationPanel.Size = New System.Drawing.Size(940, 150)
        reservationPanel.Location = New System.Drawing.Point(30, 510)
        reservationPanel.BackColor = System.Drawing.Color.White
        reservationPanel.BorderStyle = BorderStyle.None
        Me.Controls.Add(reservationPanel)

        nom.Size = New System.Drawing.Size(250, 35)
        nom.Location = New System.Drawing.Point(20, 20)
        nom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        nom.BorderStyle = BorderStyle.FixedSingle
        nom.PlaceholderText = "Nom"
        reservationPanel.Controls.Add(nom)

        pre.Size = New System.Drawing.Size(250, 35)
        pre.Location = New System.Drawing.Point(290, 20)
        pre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        pre.BorderStyle = BorderStyle.FixedSingle
        pre.PlaceholderText = "Prénom"
        reservationPanel.Controls.Add(pre)

        tel.Size = New System.Drawing.Size(250, 35)
        tel.Location = New System.Drawing.Point(560, 20)
        tel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        tel.BorderStyle = BorderStyle.FixedSingle
        tel.PlaceholderText = "Téléphone"
        reservationPanel.Controls.Add(tel)

        btnres.Size = New System.Drawing.Size(200, 45)
        btnres.Location = New System.Drawing.Point(370, 80)
        btnres.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        btnres.BackColor = System.Drawing.Color.FromArgb(46, 125, 50)
        btnres.ForeColor = System.Drawing.Color.White
        btnres.FlatStyle = FlatStyle.Flat
        btnres.FlatAppearance.BorderSize = 0
        btnres.Text = "Réserver"
        btnres.Cursor = Cursors.Hand
        reservationPanel.Controls.Add(btnres)
    End Sub

    Friend WithEvents volst As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents des As DataGridViewTextBoxColumn
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents nbp As DataGridViewTextBoxColumn
    Friend WithEvents pri As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dest As TextBox
    Friend WithEvents rech As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents btnres As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dateh As TextBox
End Class
