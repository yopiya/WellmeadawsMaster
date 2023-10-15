Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting



Public Class Dashboard

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim connection As New SqlConnection(connectionString)

    Protected Sub Load_New_Patient()
        connection.Open()

        Dim today As Date = Date.Today
        Dim countPatients As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Patients WHERE DateRegistered = @Today", connection)
            cmd.Parameters.AddWithValue("@Today", today)
            countPatients = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_Qpatienttoday.Text = "+" & countPatients.ToString()
    End Sub

    Protected Sub Load_New_staff()
        connection.Open()



        Dim countStaff As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM staff WHERE staffID IS NOT NULL", connection)
            countStaff = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_staff.Text = countStaff.ToString()
    End Sub

    Private Sub bed_ava()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM beds WHERE BedStatus = 'Occupied'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_Bedava.Text = countOccupiedBeds.ToString()
    End Sub

    Private Sub bed_unava()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Beds WHERE BedStatus = 'Vacant'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lbl_BedUnava.Text = countOccupiedBeds.ToString()
    End Sub


    Private Sub pay()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Bills WHERE PaymentStatus = 'Paid'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lblPay.Text = countOccupiedBeds.ToString()
    End Sub


    Private Sub unpay()

        connection.Open()

        Dim countOccupiedBeds As Integer = 0

        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Bills WHERE PaymentStatus = 'Unpaid'", connection)
            countOccupiedBeds = CInt(cmd.ExecuteScalar())
        End Using

        connection.Close()

        ' นำค่าที่นับได้แสดงใน Label
        lblUnpay.Text = countOccupiedBeds.ToString()
    End Sub

    Protected Sub Chart1_dis()
        connection.Open()

        Dim nightShiftCount As Integer = 0
        Dim dayShiftCount As Integer = 0

        Dim query As String = "SELECT COUNT(*) FROM StaffAllocation WHERE Shift = 'Night Shift'"
        Using command As New SqlCommand(query, connection)
            nightShiftCount = CInt(command.ExecuteScalar())
        End Using

        query = "SELECT COUNT(*) FROM StaffAllocation WHERE Shift = 'Day Shift'"
        Using command As New SqlCommand(query, connection)
            dayShiftCount = CInt(command.ExecuteScalar())
        End Using

        connection.Close()

        ' สร้าง Bar Chart
        Chart1.Series.Clear()
        Chart1.Series.Add("Night Shifts")
        Chart1.Series.Add("Day Shifts")

        ' เพิ่มแท่ง Night Shift และกำหนดสีเป็นน้ำเงิน
        Dim nightShiftPoint As New DataPoint()
        nightShiftPoint.SetValueY(nightShiftCount)
        nightShiftPoint.Color = Color.Blue
        nightShiftPoint.AxisLabel = "Night  Day"
        nightShiftPoint.Label = nightShiftCount.ToString() ' กำหนดจำนวนบนแท่ง
        Chart1.Series("Night Shifts").Points.Add(nightShiftPoint)

        ' เพิ่มแท่ง Day Shift และกำหนดสีเป็นส้ม
        Dim dayShiftPoint As New DataPoint()
        dayShiftPoint.SetValueY(dayShiftCount)
        dayShiftPoint.Color = Color.Orange
        dayShiftPoint.AxisLabel = ""
        dayShiftPoint.Label = dayShiftCount.ToString() ' กำหนดจำนวนบนแท่ง
        Chart1.Series("Day Shifts").Points.Add(dayShiftPoint)

        ' กำหนดระยะห่างระหว่างแท่งในแกน X
        Chart1.ChartAreas(0).AxisX.Title = "Shifts" ' กำหนดชื่อแกน X
        Chart1.ChartAreas(0).AxisX.Interval = 1 ' ระยะห่างระหว่างแท่ง 1 หน่วย
        Chart1.ChartAreas(0).AxisX.IntervalType = DateTimeIntervalType.Number ' ระยะห่างเป็นตัวเลข
        Chart1.ChartAreas(0).AxisX.Minimum = 0 ' ค่าต่ำสุดในแกน X

        Chart1.ChartAreas(0).AxisY.Title = "Number of Staff" ' กำหนดชื่อแกน Y
        Chart1.ChartAreas(0).AxisY.Interval = 1
        Chart1.ChartAreas(0).AxisY.IntervalType = DateTimeIntervalType.Number




    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_New_Patient()
        Load_New_staff()
        bed_ava()
        bed_unava()
        pay()
        unpay()
        Chart1_dis()

    End Sub


End Class
