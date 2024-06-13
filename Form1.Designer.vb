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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.TxtPrenume = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(99, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(129, 20)
        Me.txtId.TabIndex = 1
        '
        'txtNume
        '
        Me.txtNume.Location = New System.Drawing.Point(99, 65)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(129, 20)
        Me.txtNume.TabIndex = 2
        '
        'TxtPrenume
        '
        Me.TxtPrenume.Location = New System.Drawing.Point(99, 105)
        Me.TxtPrenume.Name = "TxtPrenume"
        Me.TxtPrenume.Size = New System.Drawing.Size(129, 20)
        Me.TxtPrenume.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prenume"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Adauga"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrenume)
        Me.Controls.Add(Me.txtNume)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNume As TextBox
    Friend WithEvents TxtPrenume As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
