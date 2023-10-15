<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Qpatienttoday = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_BedUnava = New System.Windows.Forms.Label()
        Me.lbl_Bedava = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblUnpay = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.lbl_Qpatienttoday)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(51, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(171, 87)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Qpatienttoday
        '
        Me.lbl_Qpatienttoday.AutoSize = True
        Me.lbl_Qpatienttoday.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Qpatienttoday.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Qpatienttoday.Location = New System.Drawing.Point(65, 28)
        Me.lbl_Qpatienttoday.Name = "lbl_Qpatienttoday"
        Me.lbl_Qpatienttoday.Size = New System.Drawing.Size(51, 40)
        Me.lbl_Qpatienttoday.TabIndex = 1
        Me.lbl_Qpatienttoday.Text = "00"
        Me.lbl_Qpatienttoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Qpatienttoday.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(17, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "New Patient in today"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.lbl_staff)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(242, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 87)
        Me.Panel2.TabIndex = 1
        '
        'lbl_staff
        '
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_staff.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_staff.Location = New System.Drawing.Point(67, 28)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(51, 40)
        Me.lbl_staff.TabIndex = 2
        Me.lbl_staff.Text = "00"
        Me.lbl_staff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_staff.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(36, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Staff in hospital"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(171, 25)
        Me.Panel6.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(64, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "STAFF"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.lbl_BedUnava)
        Me.Panel3.Controls.Add(Me.lbl_Bedava)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(427, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 87)
        Me.Panel3.TabIndex = 2
        '
        'lbl_BedUnava
        '
        Me.lbl_BedUnava.AutoSize = True
        Me.lbl_BedUnava.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_BedUnava.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_BedUnava.Location = New System.Drawing.Point(118, 28)
        Me.lbl_BedUnava.Name = "lbl_BedUnava"
        Me.lbl_BedUnava.Size = New System.Drawing.Size(51, 40)
        Me.lbl_BedUnava.TabIndex = 12
        Me.lbl_BedUnava.Text = "00"
        Me.lbl_BedUnava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_BedUnava.UseWaitCursor = True
        '
        'lbl_Bedava
        '
        Me.lbl_Bedava.AutoSize = True
        Me.lbl_Bedava.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_Bedava.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_Bedava.Location = New System.Drawing.Point(27, 28)
        Me.lbl_Bedava.Name = "lbl_Bedava"
        Me.lbl_Bedava.Size = New System.Drawing.Size(51, 40)
        Me.lbl_Bedava.TabIndex = 11
        Me.lbl_Bedava.Text = "00"
        Me.lbl_Bedava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Bedava.UseWaitCursor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(94, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Unavailable Bed"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(191, 25)
        Me.Panel7.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(76, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "BED"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(3, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Available bed"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Controls.Add(Me.lblUnpay)
        Me.Panel4.Controls.Add(Me.lblPay)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(643, 72)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(171, 87)
        Me.Panel4.TabIndex = 3
        '
        'lblUnpay
        '
        Me.lblUnpay.AutoSize = True
        Me.lblUnpay.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblUnpay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUnpay.Location = New System.Drawing.Point(108, 28)
        Me.lblUnpay.Name = "lblUnpay"
        Me.lblUnpay.Size = New System.Drawing.Size(51, 40)
        Me.lblUnpay.TabIndex = 14
        Me.lblUnpay.Text = "00"
        Me.lblUnpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUnpay.UseWaitCursor = True
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lblPay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPay.Location = New System.Drawing.Point(21, 28)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(51, 40)
        Me.lblPay.TabIndex = 13
        Me.lblPay.Text = "00"
        Me.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPay.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(108, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "UNPAID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(25, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PAID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(356, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dashboard"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(51, 72)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(171, 25)
        Me.Panel5.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(57, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PATIENT"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(643, 72)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(171, 25)
        Me.Panel8.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(52, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PAYMENT"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(51, 186)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(362, 240)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "Chart1"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(890, 575)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_Qpatienttoday As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_Bedava As Label
    Friend WithEvents lbl_BedUnava As Label
    Friend WithEvents lblUnpay As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
