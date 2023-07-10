<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnMoveNumber = New System.Windows.Forms.Button()
        Me.btnMoveName = New System.Windows.Forms.Button()
        Me.txtMoveNumber = New System.Windows.Forms.TextBox()
        Me.txtMoveName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'btnMoveNumber
        '
        Me.btnMoveNumber.Location = New System.Drawing.Point(346, 370)
        Me.btnMoveNumber.Name = "btnMoveNumber"
        Me.btnMoveNumber.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveNumber.TabIndex = 1
        Me.btnMoveNumber.Text = "TM Number"
        Me.btnMoveNumber.UseVisualStyleBackColor = True
        '
        'btnMoveName
        '
        Me.btnMoveName.Location = New System.Drawing.Point(15, 370)
        Me.btnMoveName.Name = "btnMoveName"
        Me.btnMoveName.Size = New System.Drawing.Size(100, 23)
        Me.btnMoveName.TabIndex = 2
        Me.btnMoveName.Text = "TM Name"
        Me.btnMoveName.UseVisualStyleBackColor = True
        '
        'txtMoveNumber
        '
        Me.txtMoveNumber.Location = New System.Drawing.Point(346, 334)
        Me.txtMoveNumber.Name = "txtMoveNumber"
        Me.txtMoveNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtMoveNumber.TabIndex = 3
        '
        'txtMoveName
        '
        Me.txtMoveName.Location = New System.Drawing.Point(15, 334)
        Me.txtMoveName.Name = "txtMoveName"
        Me.txtMoveName.Size = New System.Drawing.Size(100, 20)
        Me.txtMoveName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(343, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Move Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Move Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMoveName)
        Me.Controls.Add(Me.txtMoveNumber)
        Me.Controls.Add(Me.btnMoveName)
        Me.Controls.Add(Me.btnMoveNumber)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnMoveNumber As Button
    Friend WithEvents btnMoveName As Button
    Friend WithEvents txtMoveNumber As TextBox
    Friend WithEvents txtMoveName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
