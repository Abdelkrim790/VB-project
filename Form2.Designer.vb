<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        volst = New DataGridView()
        num = New DataGridViewTextBoxColumn()
        des = New DataGridViewTextBoxColumn()
        dat = New DataGridViewTextBoxColumn()
        nbp = New DataGridViewTextBoxColumn()
        pri = New DataGridViewTextBoxColumn()
        numero = New TextBox()
        prix = New TextBox()
        nbpl = New TextBox()
        dest = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ajouter = New Button()
        modifier = New Button()
        suppr = New Button()
        Label6 = New Label()
        dateh = New TextBox()
        CType(volst, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' volst
        ' 
        volst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        volst.Columns.AddRange(New DataGridViewColumn() {num, des, dat, nbp, pri})
        volst.Location = New Point(460, 90)
        volst.Name = "volst"
        volst.Size = New Size(500, 580)
        volst.TabIndex = 0
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
        ' 
        ' num
        ' 
        num.HeaderText = "Numero de vol"
        num.Name = "num"
        ' 
        ' des
        ' 
        des.HeaderText = "La destination"
        des.Name = "des"
        ' 
        ' dat
        ' 
        dat.HeaderText = "La date et l'heure"
        dat.Name = "dat"
        ' 
        ' nbp
        ' 
        nbp.HeaderText = "NB Places disponibles"
        nbp.Name = "nbp"
        ' 
        ' pri
        ' 
        pri.HeaderText = "Prix"
        pri.Name = "pri"
        ' 
        ' numero
        ' 
        numero.Location = New Point(25, 20)
        numero.Name = "numero"
        numero.Size = New Size(350, 35)
        numero.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        numero.BorderStyle = BorderStyle.FixedSingle
        numero.PlaceholderText = "Numéro de vol"
        ' 
        ' prix
        ' 
        prix.Location = New Point(25, 220)
        prix.Name = "prix"
        prix.Size = New Size(350, 35)
        prix.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        prix.BorderStyle = BorderStyle.FixedSingle
        prix.PlaceholderText = "Prix"
        ' 
        ' nbpl
        ' 
        nbpl.Location = New Point(25, 170)
        nbpl.Name = "nbpl"
        nbpl.Size = New Size(350, 35)
        nbpl.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        nbpl.BorderStyle = BorderStyle.FixedSingle
        nbpl.PlaceholderText = "Nombre de places"
        ' 
        ' dest
        ' 
        dest.Location = New Point(25, 70)
        dest.Name = "dest"
        dest.Size = New Size(350, 35)
        dest.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        dest.BorderStyle = BorderStyle.FixedSingle
        dest.PlaceholderText = "Destination"
        ' 
        ' Label1
        ' 
        ' 
        ' Label2
        ' 
        ' 
        ' Label3
        ' 
        ' 
        ' Label4
        ' 
        ' 
        ' Label5
        ' 
        ' 
        ' ajouter
        ' 
        ajouter.Location = New Point(0, 0)
        ajouter.Name = "ajouter"
        ajouter.Size = New Size(110, 45)
        ajouter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        ajouter.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        ajouter.ForeColor = System.Drawing.Color.White
        ajouter.FlatStyle = FlatStyle.Flat
        ajouter.FlatAppearance.BorderSize = 0
        ajouter.Text = "Ajouter"
        ajouter.Cursor = Cursors.Hand
        ' 
        ' modifier
        ' 
        modifier.Location = New Point(120, 0)
        modifier.Name = "modifier"
        modifier.Size = New Size(110, 45)
        modifier.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        modifier.BackColor = System.Drawing.Color.FromArgb(255, 140, 0)
        modifier.ForeColor = System.Drawing.Color.White
        modifier.FlatStyle = FlatStyle.Flat
        modifier.FlatAppearance.BorderSize = 0
        modifier.Text = "Modifier"
        modifier.Cursor = Cursors.Hand
        ' 
        ' suppr
        ' 
        suppr.Location = New Point(240, 0)
        suppr.Name = "suppr"
        suppr.Size = New Size(110, 45)
        suppr.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        suppr.BackColor = System.Drawing.Color.FromArgb(209, 17, 65)
        suppr.ForeColor = System.Drawing.Color.White
        suppr.FlatStyle = FlatStyle.Flat
        suppr.FlatAppearance.BorderSize = 0
        suppr.Text = "Supprimer"
        suppr.Cursor = Cursors.Hand
        ' 
        ' Label6
        ' 
        Dim titleLabel As New Label()
        titleLabel.Text = "Gestion des Vols"
        titleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        titleLabel.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
        titleLabel.Size = New System.Drawing.Size(400, 50)
        titleLabel.Location = New System.Drawing.Point(30, 20)
        titleLabel.TextAlign = ContentAlignment.MiddleLeft
        Me.Controls.Add(titleLabel)
        ' 
        ' dateh
        ' 
        dateh.Location = New Point(25, 120)
        dateh.Name = "dateh"
        dateh.Size = New Size(350, 35)
        dateh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        dateh.BorderStyle = BorderStyle.FixedSingle
        dateh.PlaceholderText = "Date et heure (JJ/MM/AAAA HH:MM)"
        ' 
        ' Form2
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration des Vols"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Dim inputPanel As New Panel()
        inputPanel.Size = New System.Drawing.Size(400, 400)
        inputPanel.Location = New System.Drawing.Point(30, 90)
        inputPanel.BackColor = System.Drawing.Color.White
        inputPanel.BorderStyle = BorderStyle.None
        Me.Controls.Add(inputPanel)
        inputPanel.Controls.Add(numero)
        inputPanel.Controls.Add(dest)
        inputPanel.Controls.Add(dateh)
        inputPanel.Controls.Add(nbpl)
        inputPanel.Controls.Add(prix)
        Dim buttonsPanel As New Panel()
        buttonsPanel.Size = New System.Drawing.Size(350, 120)
        buttonsPanel.Location = New System.Drawing.Point(25, 270)
        buttonsPanel.BackColor = System.Drawing.Color.Transparent
        inputPanel.Controls.Add(buttonsPanel)
        buttonsPanel.Controls.Add(ajouter)
        buttonsPanel.Controls.Add(modifier)
        buttonsPanel.Controls.Add(suppr)
        Me.Controls.Add(volst)
        CType(volst, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents volst As DataGridView
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents des As DataGridViewTextBoxColumn
    Friend WithEvents dat As DataGridViewTextBoxColumn
    Friend WithEvents nbp As DataGridViewTextBoxColumn
    Friend WithEvents pri As DataGridViewTextBoxColumn
    Friend WithEvents numero As TextBox
    Friend WithEvents prix As TextBox
    Friend WithEvents nbpl As TextBox
    Friend WithEvents dest As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ajouter As Button
    Friend WithEvents modifier As Button
    Friend WithEvents suppr As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dateh As TextBox
End Class
