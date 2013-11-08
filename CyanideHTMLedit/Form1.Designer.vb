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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 565)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(856, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(856, 536)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(850, 530)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "<HTML>" & Global.Microsoft.VisualBasic.ChrW(10) & "<HEAD>" & Global.Microsoft.VisualBasic.ChrW(10) & "Head here" & Global.Microsoft.VisualBasic.ChrW(10) & "</HEAD>" & Global.Microsoft.VisualBasic.ChrW(10) & "<BODY>" & Global.Microsoft.VisualBasic.ChrW(10) & "All body here" & Global.Microsoft.VisualBasic.ChrW(10) & "</Body>" & Global.Microsoft.VisualBasic.ChrW(10) & "</HTML>"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(850, 530)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.RichTextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(856, 536)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Enabled = False
        Me.RichTextBox2.Location = New System.Drawing.Point(306, 82)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(155, 105)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = "Cyanide HTML Editor" & Global.Microsoft.VisualBasic.ChrW(10) & "Very basic" & Global.Microsoft.VisualBasic.ChrW(10) & "Quite usefull" & Global.Microsoft.VisualBasic.ChrW(10) & "Coded by cyanide" & Global.Microsoft.VisualBasic.ChrW(10) & "This is just an exa" & _
    "mple"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(306, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 565)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "CyanideHTMLeditor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
