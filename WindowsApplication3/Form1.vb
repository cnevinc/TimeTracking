

Public Class Form1
    Dim countUp As Integer
    Dim countDown As Integer
    Dim countDonwBoundary As Integer
    Dim buttonCounter1 As Integer
    Dim buttonCounter2 As Integer
    Dim buttonCounter3 As Integer
    Dim logFile As String
    Dim planFile As String
    Dim noteFile As String
    Dim keyEvent As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'MessageBox.Show(e.KeyCode())
        Select Case e.KeyCode
            Case Keys.A
                If e.Alt Then
                    Button1_Click(e, e)
                End If

            Case Keys.S
                If e.Alt Then
                    Button2_Click(e, e)
                End If

            Case Keys.D
                If e.Alt Then
                    Button3_Click(e, e)
                End If

            Case Keys.F1
                ButtonGDS_Click(e, e)

            Case Keys.F2
                ButtonRDS_Click(e, e)

            Case Keys.F3
                ButtonERP_Click(e, e)

            Case Keys.F4
                ButtoniProcess_Click(e, e)

            Case Keys.F5
                ButtonPRS_Click(e, e)

            Case Keys.F6
                ButtonFIAT_Click(e, e)

            Case Keys.F7
                ButtonTA_Click(e, e)

            Case Keys.F8
                ButtonPersonal_Click(e, e)

        End Select

    End Sub

    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        logFile = "D:\workLog.txt"
        noteFile = "D:\workPlan.txt"
        planFile = "D:\workNote.txt"

        'Me.Height = 400

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        countDown = 1500
        countDonwBoundary = 1500
        buttonCounter1 = buttonCounter1 + 1
        Label2.Text = buttonCounter1

        Timer1.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        countDown = 300
        countDonwBoundary = 300
        buttonCounter2 = buttonCounter2 + 1
        Label3.Text = buttonCounter2

        Timer1.Start()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        countDown = 1200
        countDonwBoundary = 1200
        buttonCounter3 = buttonCounter3 + 1
        Label4.Text = buttonCounter3

        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Interval = 1000

        countDown = countDown - 1
        TextBox1.Text = countDown \ 60 '分 用"\"可以求商
        TextBox2.Text = countDown Mod 60 '秒

        'If (countDown <= countDonwBoundary - 2) Then
        If (countDown = 0) Then
            Timer1.Stop()
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)

            MessageBox.Show((countDonwBoundary / 60).ToString() + " minutes up at " + (Now().TimeOfDay).ToString())
        End If

        ' if current Work is selected , start countUp
        If TextBoxNowWorking.Text <> "" Then
            countUp = countUp + 1

            TextBox5.Text = countUp \ 60 '分 用"\"可以求商
            TextBox6.Text = countUp Mod 60 '秒
        End If

        ' Reset Clock
        Label1.Text = Now().ToString()
    End Sub



    Private Sub ButtonGDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGDS.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                        Now() + "," + "GDS" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "GDS"
        countUp = 0

    End Sub

    Private Sub ButtonRDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRDS.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                       Now() + "," + "RDS" + vbCrLf, True)
        TextBoxNowWorking.Text = "RDS"
        countUp = 0

    End Sub

    Private Sub ButtonERP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonERP.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                     Now() + "," + "ERP" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "ERP"
        countUp = 0

    End Sub

    Private Sub ButtoniProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtoniProcess.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                    Now() + "," + "iProcess" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "iProcess"
        countUp = 0

    End Sub

    Private Sub ButtonPRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPRS.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                   Now() + "," + "PRS" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "PRS"
        countUp = 0

    End Sub

    Private Sub ButtonFIAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFIAT.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                  Now() + "," + "FIAT" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "FIAT"
        countUp = 0

    End Sub

    Private Sub ButtonTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTA.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                  Now() + "," + "TA" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "TA"
        countUp = 0

    End Sub

    Private Sub ButtonPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPersonal.Click
        My.Computer.FileSystem.WriteAllText(logFile, _
                  Now() + "," + "Personal" + "," + TextBox3.Text + vbCrLf, True)
        TextBoxNowWorking.Text = "Personal"
        countUp = 0


    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox3.Text = ComboBox1.SelectedItem

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.Height = 165
        Else
            Me.Height = 400
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Me.Height = Me.Height + 300
        Else
            Me.Height = Me.Height - 340
        End If
    End Sub

  
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        My.Computer.FileSystem.WriteAllText(planFile, TextBox4.Text, False)
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        My.Computer.FileSystem.WriteAllText(noteFile, TextBox7.Text, False)
    End Sub
End Class