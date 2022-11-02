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
        Me.components = New System.ComponentModel.Container()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.Location = New System.Drawing.Point(46, 12)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(120, 37)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stop.Location = New System.Drawing.Point(46, 55)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(120, 38)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 108)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "Form1"
        Me.Text = "Stay Awake"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents asd As Button
End Class
