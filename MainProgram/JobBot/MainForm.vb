Imports System
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions 'jutumärgid
Imports System.ComponentModel 'taustal töötava taustprotsessi asi 
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.Threading
Imports System.Globalization
Imports System.Runtime.InteropServices

Public Class MainForm
    Dim PROGRAM_MAIN_VERSION As String = "4.5"

    Private WithEvents Tray As NotifyIcon

    Private LOGIN As String = "Login"
    Private CONNECT As String = "Connect"
    Private CALENDAR As String = "Calendar"
    Private MAIN As String = "Main"
    Private WIDGET As String = "Widget"

    'Layer memory
    Dim currentLayer = LOGIN
    Dim beforeLayer = LOGIN

    'User selected START/END DateTime
    Dim userStartDateTime() As Date
    Dim userEndDateTime() As Date
    Dim dateCounter As Integer = 0

    'Counters
    Dim refreshCounter As Integer = 0
    Dim taskCounter As Integer = 0
    Dim checkInErrorCount As Integer = 0

    'Window dragging variables
    Private boolDrag As Boolean
    Private intMouseX As Integer
    Private intMouseY As Integer

    'User login data
    Private userID As String
    Private userPassword As String

    'Login status
    Private booLoginSuccessful As Boolean = False

    'Declare spider and server
    Dim spider As New Spider 'Get information from website
    Dim server As New Server 'Get information from server

    ' This integer variable keeps track of the remaining time.
    Private timeLeftOnline As Integer
    Private timeLeftOffline As Integer

    'Browser and button switch status
    Private acceptBrowser As Boolean = True
    Private StartStop As Boolean = True

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize the tray
        Tray = New NotifyIcon
        Tray.Icon = My.Resources.ico
        Tray.ContextMenuStrip = cmsMenyy
        Tray.Text = "R&G"
        'Display
        Tray.Visible = False

        'Roundup seconds
        Dim OriginalDateTime As DateTime = Now()
        dtpEndDateTime.Value = OriginalDateTime.AddSeconds(-OriginalDateTime.Second)
        dtpStartDateTime.Value = OriginalDateTime.AddSeconds(-OriginalDateTime.Second)

        spider.websiteUml = "http://task.betgenius.com/WorkAvailable"

        Me.pbGIF.SizeMode = PictureBoxSizeMode.CenterImage
        cmsMenyy.ForeColor = Color.White

        ChangeCursor()

        ChangeBackgrounsTransparent()

        lbCounter.Text = refreshCounter

        'Read username and password and DateTime if exists
        Try
            ReadDateFromFile()

            Using StreamReader As New StreamReader("RG")
                tbUserId.Text = AES_Decrypt(StreamReader.ReadLine())
                tbUserPassword.Text = AES_Decrypt(StreamReader.ReadLine())
            End Using
        Catch ex As Exception

        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------Transparetnt/Cursor
    ''' <summary>
    ''' List of BacroundToTransparent() tasks.
    ''' </summary>
    Private Sub ChangeBackgrounsTransparent()
        BacroundToTransparent(pbStartStop, pbMainBackground)
        BacroundToTransparent(pbGIF, pbMainBackground)
        BacroundToTransparent(pbCalendar, pbMainBackground)
        BacroundToTransparent(cbAll, pbMainBackground)
        BacroundToTransparent(cbBroadcasting, pbMainBackground)
        BacroundToTransparent(cbInRunning, pbMainBackground)
        BacroundToTransparent(cbMedia, pbMainBackground)
        BacroundToTransparent(cbQC, pbMainBackground)
        BacroundToTransparent(cbResource, pbMainBackground)
        BacroundToTransparent(cbUATTesting, pbMainBackground)
        BacroundToTransparent(lbTaskType2, pbMainBackground)
        BacroundToTransparent(lbOfflineTimeMain, pbMainBackground)
        BacroundToTransparent(lbOnlineTimeMain, pbMainBackground)
        BacroundToTransparent(lbExit, pbMainBackground)
        BacroundToTransparent(lbMinimize, pbMainBackground)

        BacroundToTransparent(lbMainError, pbGIF)
        BacroundToTransparent(lbCounter, pbGIF)

        BacroundToTransparent(lbDateStartTime, pbCalendarBackground)
        BacroundToTransparent(lbDateEndTime, pbCalendarBackground)
        BacroundToTransparent(lbEndDT, pbCalendarBackground)
        BacroundToTransparent(lbEndD, pbCalendarBackground)
        BacroundToTransparent(lbEndT, pbCalendarBackground)
        BacroundToTransparent(lbStartDT, pbCalendarBackground)
        BacroundToTransparent(lbStartD, pbCalendarBackground)
        BacroundToTransparent(lbStartT, pbCalendarBackground)
        BacroundToTransparent(lbCalendarError, pbCalendarBackground)
        BacroundToTransparent(pbAddTime, pbCalendarBackground)
        BacroundToTransparent(pbRemoveTime, pbCalendarBackground)
        BacroundToTransparent(pbFinish, pbCalendarBackground)
        BacroundToTransparent(lbOfflineTimeCalendar, pbCalendarBackground)
        BacroundToTransparent(lbOnlineTimeCalendar, pbCalendarBackground)
        BacroundToTransparent(lbMinimizeCalendar, pbCalendarBackground)
        BacroundToTransparent(lbExitCalendar, pbCalendarBackground)

        BacroundToTransparent(lbMail, pbLoginBackground)
        BacroundToTransparent(lbLoginError, pbLoginBackground)
        BacroundToTransparent(lbOfflineTime, pbLoginBackground)
        BacroundToTransparent(pbLogin, pbLoginBackground)
        BacroundToTransparent(lbExitLogin, pbLoginBackground)
        BacroundToTransparent(lbMinimizeLogin, pbLoginBackground)

        BacroundToTransparent(pbConnectGif, pbConnectBackground)

        BacroundToTransparent(pbSearchSmallGIF, pbWidgetBackground)
        BacroundToTransparent(lbMaximizeWidget, pbWidgetBackground)
        BacroundToTransparent(lbExitWidget, pbWidgetBackground)
    End Sub

    ''' <summary>
    ''' Make the background of this object transparent
    ''' taking account parent objects (backround image)
    ''' </summary>
    ''' <param name="objName">Make the background of this object transparent</param>
    ''' <param name="parentObject">This is the background that must be shown when transparent</param>
    Private Sub BacroundToTransparent(ByVal objName As Object, ByVal parentObject As Object)
        objName.Parent = parentObject
        objName.BackColor = Color.Transparent

        'Calculate new location based on background location
        Dim locX As Integer = objName.Location.X - parentObject.Location.X
        Dim locY As Integer = objName.Location.Y - parentObject.Location.Y

        objName.Location = New Point(locX, locY)
    End Sub

    ''' <summary>
    ''' Change IBeam cursor to custom white IBeam
    ''' </summary>
    Private Sub ChangeCursor()
        tbUserPassword.Cursor = New Cursor(New System.IO.MemoryStream(My.Resources.IBcursor))
        tbUserId.Cursor = New Cursor(New System.IO.MemoryStream(My.Resources.IBcursor))
        rtbOutput.Cursor = New Cursor(New System.IO.MemoryStream(My.Resources.IBcursor))
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------LAYERS
    ''' <summary>
    ''' Allows to change label visibility and text while in BackgroundWorker
    ''' </summary>
    ''' <param name="panel"></param>
    ''' <param name="visibility"></param>
    Private Sub SetLayer(ByVal panel As Panel, ByVal visibility As Boolean)
        If panel.InvokeRequired Then
            panel.Invoke(New SetLayerInvoker(AddressOf SetLayer), panel, visibility)
        Else
            panel.Visible = visibility
        End If
    End Sub
    Private Delegate Sub SetLayerInvoker(ByVal panel As Panel, ByVal visibility As Boolean)

    ''' <summary>
    ''' Layer (Panel) switcher.
    ''' </summary>
    ''' <param name="layer">LOGIN, CONNECT, CALENDAR, MAIN, WIDGET</param>
    ''' <param name="visibility">True, False</param>
    Private Sub Layers(layer As String, visibility As Boolean)
        'Change visibility of old layer to false
        If visibility = True And currentLayer IsNot WIDGET Then
            Layers(currentLayer, False)
        End If

        'Change visibility
        Select Case layer
            Case LOGIN
                SetLayer(LoginPanel, visibility)
                currentLayer = LOGIN
            Case CONNECT
                SetLayer(ConnectPanel, visibility)
                currentLayer = CONNECT
            Case CALENDAR
                SetLayer(CalendarPanel, visibility)
                currentLayer = CALENDAR
            Case MAIN
                SetLayer(MainPanel, visibility)
                currentLayer = MAIN
            Case WIDGET
                'Remember previous Layer to switch back from WIDGET
                If currentLayer = WIDGET And visibility = False Then
                    SetLayer(WidgetPanel, False)
                    Layers(beforeLayer, True)
                Else
                    SetLayer(WidgetPanel, visibility)
                    If currentLayer IsNot WIDGET Then
                        beforeLayer = currentLayer
                    End If

                    currentLayer = WIDGET
                End If
        End Select
    End Sub

    ''' <summary>
    ''' Allows to change label visibility and text while in BackgroundWorker
    ''' </summary>
    ''' <param name="errorValue"></param>
    ''' <param name="lbl"></param>
    ''' <param name="visibility"></param>
    Private Sub SetLabelTxt(ByVal errorValue As String, ByVal lbl As Label, ByVal visibility As Boolean)
        If lbl.InvokeRequired Then
            lbl.Invoke(New SetLabelTxtInvoker(AddressOf SetLabelTxt), errorValue, lbl, visibility)
        Else
            lbl.Text = errorValue
            lbl.Visible = visibility
        End If
    End Sub
    Private Delegate Sub SetLabelTxtInvoker(ByVal text As String, ByVal lbl As Label, ByVal visibility As Boolean)

    ''' <summary>
    ''' Error Layer switcer.
    ''' Login, Main and WIDGET
    ''' </summary>
    ''' <param name="layer">LOGIN, CALENDAR, MAIN</param>
    ''' <param name="visibility">True False</param>
    ''' <param name="errorValue">Error string</param>
    Private Sub LayersError(layer As String, visibility As Boolean, errorValue As String)
        Select Case layer
            Case LOGIN
                SetLabelTxt(errorValue, lbLoginError, visibility)
            Case CALENDAR
                SetLabelTxt(errorValue, lbCalendarError, visibility)
            Case MAIN
                SetLabelTxt(errorValue, lbMainError, visibility)
                'Change Main GIF
                If visibility Then
                    pbGIF.Image = My.Resources.ErrorGIF
                Else
                    pbGIF.Image = My.Resources.StandbyGIF
                End If
        End Select
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------Move Screen
    ''' <summary>
    ''' Establish window movement START
    ''' and original mouse start location
    ''' </summary>
    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown,
        pbLoginBackground.MouseDown, lbLoginError.MouseDown, pbWidgetBackground.MouseDown,
        pbSearchSmallGIF.MouseDown, pbMainBackground.MouseDown, pbGIF.MouseDown, pbConnectGif.MouseDown,
        pbConnectBackground.MouseDown, pbCalendarBackground.MouseDown, lbMainError.MouseDown, lbCounter.MouseDown,
        lbCalendarError.MouseDown

        boolDrag = True
        intMouseX = System.Windows.Forms.Cursor.Position.X - Me.Left
        intMouseY = System.Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    ''' <summary>
    ''' Establish window movement END
    ''' </summary>
    Private Sub MainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles pbLoginBackground.MouseUp,
        lbLoginError.MouseUp, pbWidgetBackground.MouseUp, pbSearchSmallGIF.MouseUp, pbMainBackground.MouseUp,
        pbGIF.MouseUp, pbConnectGif.MouseUp, pbConnectBackground.MouseUp, pbCalendarBackground.MouseUp,
        lbMainError.MouseUp, lbCounter.MouseUp, lbCalendarError.MouseUp

        boolDrag = False
    End Sub

    ''' <summary>
    ''' Move window. Change X and Y position acording to cursor location
    ''' </summary>
    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles pbLoginBackground.MouseMove,
        lbLoginError.MouseMove, pbWidgetBackground.MouseMove, pbSearchSmallGIF.MouseMove, pbMainBackground.MouseMove,
        pbGIF.MouseMove, pbConnectGif.MouseMove, pbConnectBackground.MouseMove, pbCalendarBackground.MouseMove,
        lbMainError.MouseMove, lbCounter.MouseMove, lbCalendarError.MouseMove

        If boolDrag Then  'if move
            Me.Top = System.Windows.Forms.Cursor.Position.Y - intMouseY
            Me.Left = System.Windows.Forms.Cursor.Position.X - intMouseX
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------CheckBox
    ''' <summary>
    ''' If checkbox ALL is checked then check all boxes
    ''' </summary>
    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        If cbAll.Checked Then
            cbBroadcasting.Checked = True
            cbInRunning.Checked = True
            cbMedia.Checked = True
            cbQC.Checked = True
            cbResource.Checked = True
            cbUATTesting.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbMedia_CheckedChanged(sender As Object, e As EventArgs) Handles cbMedia.CheckedChanged
        If Not cbMedia.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbInRunning_CheckedChanged(sender As Object, e As EventArgs) Handles cbInRunning.CheckedChanged
        If Not cbInRunning.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbResource_CheckedChanged(sender As Object, e As EventArgs) Handles cbResource.CheckedChanged
        If Not cbResource.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbQC_CheckedChanged(sender As Object, e As EventArgs) Handles cbQC.CheckedChanged
        If Not cbQC.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbUATTesting_CheckedChanged(sender As Object, e As EventArgs) Handles cbUATTesting.CheckedChanged
        If Not cbUATTesting.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' If checkbox uncheckt then unchecked checkbox ALL 
    ''' </summary>
    Private Sub cbBroadcasting_CheckedChanged(sender As Object, e As EventArgs) Handles cbBroadcasting.CheckedChanged
        If Not cbBroadcasting.Checked Then
            cbAll.Checked = False
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------LOGIN
    ''' <summary>
    ''' Login to server and get loginCookie
    ''' </summary>
    Private Function LoginToTheSite()

        Dim postData As String = "UserName=" & userID & "@sportsdataservices.co.uk&Password=" & userPassword
        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)

        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("http://task.betgenius.com/Account/LogOn"), HttpWebRequest)
        postReq.Method = "POST"
        'postReq.Proxy = myProxy
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.Referer = "http://task.betgenius.com/Account/LogOn"
        postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()

        Dim postresponse As HttpWebResponse

        postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
        tempCookies.Add(postresponse.Cookies)
        spider.loginCookie = tempCookies

        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

        Dim thepage As String = postreqreader.ReadToEnd

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''WELCOME'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If thepage.Contains("Welcome!") Then
            booLoginSuccessful = True
            spider.cookieLost = False
            Return True
        Else
            booLoginSuccessful = False
            Return False
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Function

    ''' <summary>
    ''' Register user with server
    ''' </summary>
    ''' <returns>True/False</returns>
    Private Function RegisterUser()
        If LoginDataCheck() Then
            Dim uml As String = "http://ouroborosrg.16mb.com/Register.php?user=" + userID

            Select Case server.GetServerData(uml)
                Case 1 'Register
                    timeLeftOffline = server.servercleanupTime * 60
                    timeLeftOnline = server.serverOnline * 3600
                    Return True
                Case 2 'Chekin
                    Return True
                Case 3 'User Exists
                    timeLeftOffline = server.servercleanupTime * 60
                    timeLeftOnline = server.serverOnline * 3600
                    Return True
                Case 0 'Error
                    LayersError(LOGIN, True, server.serverError)
                    Return False
                Case -1 'Error
                    LayersError(LOGIN, True, "Something went wrong." & vbNewLine & "Please try again later! E001")
                    Return False
                Case -2 'Error
                    LayersError(LOGIN, True, "Something went wrong." & vbNewLine & "Please try again later! E002")
                    Return False
            End Select

            Return False
        End If
    End Function

    ''' <summary>
    ''' Let server know that I'm still running
    ''' </summary>
    ''' <returns>True/False</returns>
    Private Function CheckInUser()
        Dim uml As String = "http://ouroborosrg.16mb.com/CheckIn.php?user=" & userID & "&refreshC=" & refreshCounter & "&taskC=" & taskCounter

        Select Case server.GetServerData(uml)
            Case 1 'Register
                timeLeftOffline = server.servercleanupTime * 60
                timeLeftOnline = server.serverOnline * 3600
                Return True
            Case 2 'Chekin
                'MsgBox("Uptated")
                Return True
            Case 3 'User Exists
                timeLeftOffline = server.servercleanupTime * 60
                timeLeftOnline = server.serverOnline * 3600
                Return True
            Case 0 'Error
                LayersError(LOGIN, True, server.serverError)
                Return False
            Case -1 'Error
                LayersError(LOGIN, True, "Something went wrong." & vbNewLine & "Please try again later! E001")
                Return False
            Case -2 'Error
                LayersError(LOGIN, True, "Something went wrong." & vbNewLine & "Please try again later! E002")
                Return False
        End Select

        Return False
    End Function

    ''' <summary>
    ''' Check if login information is filled
    ''' if not then let user know whats wrong
    ''' </summary>
    ''' <returns></returns>
    Private Function LoginDataCheck()
        If tbUserId.Text Is "" And tbUserPassword.Text Is "" Then
            LayersError(LOGIN, True, "Pleas insert username and password!")
            Return False
        End If

        If tbUserId.Text IsNot "" Then
            If tbUserPassword.Text IsNot "" Then
                LayersError(LOGIN, False, "")
                userID = tbUserId.Text
                userPassword = tbUserPassword.Text
                Return True
            Else
                LayersError(LOGIN, True, "Pleas insert password!")
                Return False
            End If
        Else
            LayersError(LOGIN, True, "Pleas insert username!")
            Return False
        End If

    End Function

    ''' <summary>
    ''' Login to all browsers
    ''' </summary>
    Private Sub LogInBrowser()
        wbBrowser1.Navigate("http://task.betgenius.com/")
        Do While wbBrowser1.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
        Dim Browser1HTML As String = wbBrowser1.DocumentText

        If Browser1HTML.Contains("loginContainer") Then
            wbBrowser1.Document.GetElementById("UserName").SetAttribute("value", userID & "@sportsdataservices.co.uk")
            wbBrowser1.Document.GetElementById("Password").SetAttribute("value", userPassword)

            Dim allelements As HtmlElementCollection = wbBrowser1.Document.All

            For Each webpageelement As HtmlElement In allelements
                If webpageelement.GetAttribute("value") = "Log On" Then
                    webpageelement.InvokeMember("Click")
                End If
            Next
        End If

        wbBrowser2.Navigate("http://task.betgenius.com/")
        Do While wbBrowser2.ReadyState <> WebBrowserReadyState.Complete
            Application.DoEvents()
        Loop
        Dim Browser2HTML As String = wbBrowser2.DocumentText

        If Browser2HTML.Contains("loginContainer") Then
            wbBrowser2.Document.GetElementById("UserName").SetAttribute("value", userID & "@sportsdataservices.co.uk")
            wbBrowser2.Document.GetElementById("Password").SetAttribute("value", userPassword)

            Dim allelements2 As HtmlElementCollection = wbBrowser2.Document.All

            For Each webpageelement As HtmlElement In allelements2
                If webpageelement.GetAttribute("value") = "Log On" Then
                    webpageelement.InvokeMember("Click")
                End If
            Next
        End If

    End Sub

    ''' <summary>
    ''' Login from all browsers
    ''' </summary>
    Private Sub LogOffBrowser()
        wbBrowser2.Navigate("http://task.betgenius.com/Account/LogOff")
        wbBrowser1.Navigate("http://task.betgenius.com/Account/LogOff")
    End Sub

    ''' <summary>
    ''' LOGIN task
    ''' </summary>
    Private Sub LOGN()
        If RegisterUser() Then
            If LoginToTheSite() Then

            Else
                LayersError(LOGIN, True, "Something went wrong." & vbNewLine & "Please try again later! E003")
                Thread.Sleep(2000)
                Layers(LOGIN, True)
            End If
        Else
            Thread.Sleep(3000)
            Layers(LOGIN, True)
        End If
    End Sub

    '-----------------------------------------------------------------------LOGIN BackgroundWorker-----------
    ''' <summary>
    ''' LOGIN BackgroundWorker START
    ''' </summary>
    Private Sub bwLogin_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwLogin.DoWork
        LOGN()
    End Sub

    ''' <summary>
    ''' LOGIN BackgroundWorker has completed
    ''' </summary>
    Private Sub bwLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwLogin.RunWorkerCompleted
        If PROGRAM_MAIN_VERSION = server.serverVersion Then
            If booLoginSuccessful Then
                TimerOffline(True)
                TimerOnline(True)
                TimerCheckIn(True)

                LogInBrowser()
                Layers(CALENDAR, True)
                'Save username and password
                Using streamWriter As New StreamWriter("RG")
                    streamWriter.WriteLine(AES_Encrypt(tbUserId.Text))
                    streamWriter.WriteLine(AES_Encrypt(tbUserPassword.Text))
                End Using
            Else
                Layers(LOGIN, True)
            End If

        Else
            LayersError(LOGIN, True, "You are using an older version of R&G!" & vbNewLine & "Please update to the latest version to continue using R&G")
            Layers(LOGIN, True)
        End If

    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------MINIMIZE/MAXIMIZE/EXIT
    '-----------------------------------------------------------------------EXIT
    ''' <summary>
    ''' Exit program
    ''' </summary>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lbExit_Click(sender As Object, e As EventArgs) Handles lbExit.Click
        Me.Close()
    End Sub

    Private Sub lbExitLogin_Click(sender As Object, e As EventArgs) Handles lbExitLogin.Click
        Me.Close()
    End Sub

    Private Sub lbExitCalendar_Click(sender As Object, e As EventArgs) Handles lbExitCalendar.Click
        Me.Close()
    End Sub

    Private Sub lbExitWidget_Click(sender As Object, e As EventArgs) Handles lbExitWidget.Click
        Me.Close()
    End Sub
    '-----------------------------------------------------------------------MINIMIZE
    ''' <summary>
    ''' Minimize program (WIDGET)
    ''' </summary>
    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.ShowInTaskbar = False
        Tray.Visible = True
        Layers(WIDGET, True)
    End Sub

    Private Sub lbMinimize_Click(sender As Object, e As EventArgs) Handles lbMinimize.Click
        Me.ShowInTaskbar = False
        Tray.Visible = True
        Layers(WIDGET, True)
    End Sub

    Private Sub lbMinimizeLogin_Click(sender As Object, e As EventArgs) Handles lbMinimizeLogin.Click
        Me.ShowInTaskbar = False
        Tray.Visible = True
        Layers(WIDGET, True)
    End Sub

    Private Sub lbMinimizeCalendar_Click(sender As Object, e As EventArgs) Handles lbMinimizeCalendar.Click
        Me.ShowInTaskbar = False
        Tray.Visible = True
        Layers(WIDGET, True)
    End Sub

    '-----------------------------------------------------------------------MAXIMIZE
    ''' <summary>
    ''' Maximize program (Full program)
    ''' </summary>
    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.ShowInTaskbar = True
        Tray.Visible = False
        Layers(WIDGET, False)
    End Sub

    Private Sub lbMaximizeWidget_Click(sender As Object, e As EventArgs) Handles lbMaximizeWidget.Click
        Me.ShowInTaskbar = True
        Tray.Visible = False
        Layers(WIDGET, False)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------ADD/REMOVE DATE/TIME
    ''' <summary>
    ''' Add selected start/end date/time!
    ''' </summary>
    Private Sub pbAddTime_Click(sender As Object, e As EventArgs) Handles pbAddTime.Click
        If CalendarInputCheck() Then
            ReDim Preserve userStartDateTime(dateCounter)
            ReDim Preserve userEndDateTime(dateCounter)
            userStartDateTime(dateCounter) = dtpStartDateTime.Value
            userEndDateTime(dateCounter) = dtpEndDateTime.Value
            clbTimes.Items.Add(userStartDateTime(dateCounter) & vbTab & vbTab & vbTab & userEndDateTime(dateCounter))
            dateCounter += 1
        End If
    End Sub

    ''' <summary>
    ''' Remove selected start/end date/time!
    ''' </summary>
    Private Sub pbRemoveTime_Click(sender As Object, e As EventArgs) Handles pbRemoveTime.Click
        Dim i2 As Integer = 0

        For i As Integer = clbTimes.Items.Count - 1 To 0 Step -1
            If (clbTimes.GetItemCheckState(i) = CheckState.Checked) Then
                clbTimes.Items.RemoveAt(i)
                dateCounter -= 1
                While i2 < (dateCounter - i)
                    userStartDateTime(i + i2) = userStartDateTime(i + i2 + 1)
                    userEndDateTime(i + i2) = userEndDateTime(i + i2 + 1)
                    i2 += 1
                End While
                i2 = 0
                Array.Resize(userEndDateTime, dateCounter)
                Array.Resize(userStartDateTime, dateCounter)
            End If
        Next
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------BUTTONS
    ''' <summary>
    ''' Change PictureBox button image 
    ''' </summary>
    ''' <param name="pictureBox">PictureBox</param>
    ''' <param name="button">Start, Stop</param>
    Private Sub ButonStyle(ByVal pictureBox As PictureBox, ByVal button As String)
        Select Case button
            Case "Start"
                pictureBox.Image = My.Resources.Start
            Case "Stop"
                pictureBox.Image = My.Resources.StopB
        End Select
    End Sub

    Private Sub pbFinish_Click(sender As Object, e As EventArgs) Handles pbFinish.Click
        WriteDateToFile()
        Layers(MAIN, True)
    End Sub

    Private Sub pbCalendar_Click(sender As Object, e As EventArgs) Handles pbCalendar.Click
        Layers(CALENDAR, True)
    End Sub

    Private Sub pbLogin_Click(sender As Object, e As EventArgs) Handles pbLogin.Click
        Layers(CONNECT, True)
        bwLogin.RunWorkerAsync()
    End Sub

    Private Sub pbStartStop_Click(sender As Object, e As EventArgs) Handles pbStartStop.Click
        If dateCounter > 0 Then
            If StartStop Then
                StartStop = False
                ButonStyle(pbStartStop, "Stop")
                TimerOffline(False)
                LayersError(MAIN, False, "")
                pbGIF.Image = My.Resources.SearchGIF
                lbCounter.Visible = True
                bwScan.RunWorkerAsync()
            Else
                StartStop = True
                ButonStyle(pbStartStop, "Start")
                TimerOffline(True)
                pbGIF.Image = My.Resources.StandbyGIF
                lbCounter.Visible = False
                bwScan.CancelAsync()
                LayersError(MAIN, True, "Shutting down searching process, please wait!!")
            End If
        Else
            lbCounter.Visible = False
            LayersError(MAIN, True, "You have to choose at least one start and end time!")
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------CALENDAR
    ''' <summary>
    ''' Check if chosen date/time is correct
    ''' </summary>
    ''' <returns>True=correct | False=error</returns>
    Private Function CalendarInputCheck()
        If dtpStartDateTime.Value >= dtpEndDateTime.Value Then
            LayersError(CALENDAR, True, "Start time cannot be greater or equal than end time!")
            Return False
        Else
            LayersError(CALENDAR, False, "")
            Return True
        End If
    End Function

    ''' <summary>
    ''' When Start date/time is changed Check if valid
    ''' </summary>
    Private Sub dtpStartDateTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDateTime.ValueChanged
        CalendarInputCheck()
    End Sub

    ''' <summary>
    ''' When End date/time is changed Check if valid
    ''' </summary>
    Private Sub dtpEndDateTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDateTime.ValueChanged
        CalendarInputCheck()
    End Sub

    ''' <summary>
    ''' Write start/end DateTime to files start.txt and end.txt
    ''' </summary>
    Private Sub WriteDateToFile()
        Try
            If dateCounter > 0 Then
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("start.txt", False)
                For Each time As Date In userStartDateTime
                    file.WriteLine(time.ToString)
                Next
                file.Close()

                file = My.Computer.FileSystem.OpenTextFileWriter("end.txt", False)
                For Each time As Date In userEndDateTime
                    file.WriteLine(time.ToString)
                Next
                file.Close()
            Else
                My.Computer.FileSystem.OpenTextFileWriter("start.txt", False)
                My.Computer.FileSystem.OpenTextFileWriter("end.txt", False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Read start/end DateTime from files start.txt and end.txt
    ''' </summary>
    Private Sub ReadDateFromFile()
        Dim dateCounter2 As Integer = 0
        Dim provider As CultureInfo = CultureInfo.InvariantCulture
        Dim format As String = "dd.MM.yyyy HH:mm.ss"

        Try
            Using sr As New StreamReader("start.txt")
                Do While sr.Peek() >= 0
                    ReDim Preserve userStartDateTime(dateCounter)
                    userStartDateTime(dateCounter) = Date.ParseExact(sr.ReadLine(), format, provider)
                    dateCounter += 1
                Loop
            End Using

            Using sr As New StreamReader("end.txt")
                Do While sr.Peek() >= 0
                    ReDim Preserve userEndDateTime(dateCounter2)
                    userEndDateTime(dateCounter2) = Date.ParseExact(sr.ReadLine(), format, provider)
                    dateCounter2 += 1
                Loop
            End Using

            dateCounter2 = 0
            For Each time As Date In userStartDateTime
                clbTimes.Items.Add(userStartDateTime(dateCounter2) & vbTab & vbTab & vbTab & userEndDateTime(dateCounter2))
                dateCounter2 += 1
            Next

        Catch ex As Exception

        End Try
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------TIMERS
    ''' <summary>
    ''' Disables/Activates timeCheckIn and gives time Interval its value
    ''' </summary>
    ''' <param name="status">True/False</param>
    Private Sub TimerCheckIn(ByVal status As Boolean)
        timeCheckIn.Interval = server.serverCheckIn
        If status Then
            timeCheckIn.Start()
        Else
            timeCheckIn.Stop()
        End If
    End Sub

    ''' <summary>
    ''' Disables/Activates timeOnline and gives timeLeftOnline its value
    ''' </summary>
    ''' <param name="status">True/False</param>
    Private Sub TimerOnline(ByVal status As Boolean)
        timeLeftOnline = server.serverOnline * 3600
        If status Then
            timeOnline.Start()
        Else
            timeOnline.Stop()
        End If
    End Sub

    ''' <summary>
    ''' Disables/Activates timeOffline and gives timeLeftOffline its value
    ''' </summary>
    ''' <param name="status">True/False</param>
    Private Sub TimerOffline(ByVal status As Boolean)
        timeLeftOffline = server.servercleanupTime * 60
        If status Then
            timeOffline.Start()
        Else
            timeOffline.Stop()
            Dim hms = TimeSpan.FromSeconds(timeLeftOffline)
            Dim h = hms.Hours.ToString
            Dim m = hms.Minutes.ToString
            Dim s = hms.Seconds.ToString
            lbOfflineTime.Text = m & ":" & s
            lbOfflineTimeMain.Text = m & ":" & s
            lbOfflineTimeCalendar.Text = m & ":" & s
        End If
    End Sub

    ''' <summary>
    ''' Check how long user is Offline
    ''' </summary>
    Private Sub timeOnline_Tick(sender As Object, e As EventArgs) Handles timeOnline.Tick
        'How long user is registerd in server
        If timeLeftOnline > 0 Then
            Dim hms = TimeSpan.FromSeconds(timeLeftOnline)
            Dim h = hms.Hours.ToString
            Dim m = hms.Minutes.ToString
            Dim s = hms.Seconds.ToString
            timeLeftOnline -= 1
            lbOnlineTimeMain.Text = h & ":" & m & ":" & s
            lbOnlineTimeCalendar.Text = h & ":" & m & ":" & s
        Else
            ' If the user ran out of time, stop the timer, show
            timeOnline.Stop()
            lbOnlineTimeMain.Text = "00:00:00"
            lbOnlineTimeCalendar.Text = "00:00:00"
            LogOffBrowser()     'Log off browser
            Layers(LOGIN, True) 'Go to Login page
        End If

        If spider.cookieLost Then
            LogOffBrowser()
            LoginToTheSite()
            LogInBrowser()
            spider.cookieLost = False
        End If
    End Sub

    ''' <summary>
    ''' Check how long user has been Online an can be
    ''' </summary>
    Private Sub timeOffline_Tick(sender As Object, e As EventArgs) Handles timeOffline.Tick
        If timeLeftOffline > 0 Then
            Dim hms = TimeSpan.FromSeconds(timeLeftOffline)
            Dim h = hms.Hours.ToString
            Dim m = hms.Minutes.ToString
            Dim s = hms.Seconds.ToString
            timeLeftOffline -= 1
            lbOfflineTime.Text = m & ":" & s
            lbOfflineTimeMain.Text = m & ":" & s
            lbOfflineTimeCalendar.Text = m & ":" & s
        Else
            ' If the user ran out of time, stop the timeOfline, show
            lbOfflineTime.Text = "Time's Up"
            lbOfflineTimeMain.Text = "Time's Up"
            lbOfflineTimeCalendar.Text = "Time's Up"
            bwScan.CancelAsync()
            LogOffBrowser()     'Log off browser
            Layers(LOGIN, True) 'Go to Login page
            TimerOffline(False)
        End If
    End Sub

    ''' <summary>
    ''' If user has missed 2 Check-Ins then logoff and cancel scan
    ''' </summary>
    Private Sub timeCheckIn_Tick(sender As Object, e As EventArgs) Handles timeCheckIn.Tick
        If CheckInUser() Then
            checkInErrorCount = 0
        ElseIf checkInErrorCount > 2 Then
            bwScan.CancelAsync()
            TimerCheckIn(False)
            LogOffBrowser()
            Layers(LOGIN, True)
            checkInErrorCount = 0
        Else
            checkInErrorCount += 1
        End If
    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------Encrypt/Decrypt
    ''' <summary>
    ''' Encrypt strings
    ''' </summary>
    ''' <param name="input">Original string</param>
    ''' <returns>Encrypted string</returns>
    Public Function AES_Encrypt(ByVal input As String) As String
        Dim pass As String = "DfdsAVgP]7582hO/HY#"
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    ''' <summary>
    ''' Decrypt strings
    ''' </summary>
    ''' <param name="input">Encrypted string</param>
    ''' <returns>Decrypted string</returns>
    Public Function AES_Decrypt(ByVal input As String) As String
        Dim pass As String = "DfdsAVgP]7582hO/HY#"
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------------------------------------------------Spider SCAN
    ''' <summary>
    ''' RUN tasks. While BackgroundWorker runs Check spider
    ''' </summary>
    Private Sub RUN()
        While Not bwScan.CancellationPending ' While BackgroundWorker runs
            Thread.Sleep(server.serverRefreshRate)
            spider.ScanSite()
            refreshCounter += 1
            CheckScanData()
            SetLabelTxt(refreshCounter, lbCounter, True)
            SetLabelTxt(refreshCounter, lbWidgetRefreshCounter, True)
        End While

    End Sub

    ''' <summary>
    ''' Check what tasks spider found
    ''' </summary>
    Private Sub CheckScanData()
        Dim i As Integer = 0
        For Each gameButton As String In spider.acceptButtonLink
            If CheckUserChoices(i, spider.dateStartTime(i), spider.dateEndTime(i)) Then
                If acceptBrowser Then
                    acceptBrowser = False
                    Me.wbBrowser1.Navigate("http://task.betgenius.com/WorkAvailable/Accept/" & spider.acceptButtonLink(i))
                Else
                    acceptBrowser = True
                    Me.wbBrowser2.Navigate("http://task.betgenius.com/WorkAvailable/Accept/" & spider.acceptButtonLink(i))
                End If
                SetRichTextBoxTxt(spider.gameName(i) & vbTab & vbTab & vbTab & spider.dateStartTime(i) & vbTab & vbTab & vbTab & spider.dateEndTime(i) & vbTab & vbTab & vbTab & spider.duration(i) & vbTab & vbTab & vbTab & System.DateTime.Now.ToString & vbNewLine)
                taskCounter += 1
                SetLabelTxt(taskCounter, lbWidgetTaskCounter, True)
                Thread.Sleep(200)
            End If
            i += 1
        Next
    End Sub

    ''' <summary>
    ''' Check if user wants this TASK
    ''' </summary>
    ''' <param name="i">Task in array</param>
    ''' <param name="dateStart">Task starts</param>
    ''' <param name="dateEnd">Task ends</param>
    ''' <returns>Wants=True, Doesn't want=False</returns>
    Private Function CheckUserChoices(ByVal i As Integer, ByVal dateStart As Date, ByVal dateEnd As Date)

        For index = 0 To dateCounter - 1 Step 1

            '(t1,t2)->   t1<t2=-1    t1=t2=0   t1>t2=1
            Dim resultStart As Integer = DateTime.Compare(dateStart, userStartDateTime(index))     '1 V 0
            Dim resultEnd As Integer = DateTime.Compare(dateEnd, userEndDateTime(index))        '-1 V 0

            If (resultStart = 1 Or resultStart = 0) And (resultEnd = -1 Or resultEnd = 0) Then  ' Does the time fit user
                If cbBroadcasting.Checked And spider.gameName(i).Contains("Broadcasting") Then
                    Return True
                End If
                If cbMedia.Checked And spider.gameName(i).Contains("Media") Then
                    Return True
                End If
                If cbInRunning.Checked And spider.gameName(i).Contains("InRunning") Then
                    Return True
                End If
                If cbQC.Checked And spider.gameName(i).Contains("QC") Then
                    Return True
                End If
                If cbResource.Checked And spider.gameName(i).Contains("Resource") Then
                    Return True
                End If
                If cbUATTesting.Checked And spider.gameName(i).Contains("UATTesting") Then
                    Return True
                End If
            End If
        Next

        Return False

    End Function

    ''' <summary>
    ''' Allows to change RichTextBox text while in BackgroundWorker
    ''' </summary>
    ''' <param name="output">Add this string at the beginning of the RichTextBox</param>
    Private Sub SetRichTextBoxTxt(ByVal output As String)
        If rtbOutput.InvokeRequired Then
            rtbOutput.Invoke(New SetRichTextBoxTxtInvoker(AddressOf SetRichTextBoxTxt), output)
        Else
            rtbOutput.Text = output + rtbOutput.Text
        End If
    End Sub
    Private Delegate Sub SetRichTextBoxTxtInvoker(ByVal output As String)

    '-----------------------------------------------------------------------Spider SCAN BackgroundWorker
    ''' <summary>
    ''' Spider Scan BackgroundWorker START
    ''' </summary>
    Private Sub bwScan_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwScan.DoWork
        RUN()
    End Sub

    ''' <summary>
    ''' Spider Scan  BackgroundWorker has completed. Remove Shutdown error message.
    ''' </summary>
    Private Sub bwScan_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwScan.RunWorkerCompleted
        LayersError(MAIN, False, "")
        lbCounter.Visible = False
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------FORM CLOSING
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If booLoginSuccessful Then
            'Exit from server
            server.ExitServer(userID)
            'Close Spider scan
            bwScan.CancelAsync()
        End If
    End Sub

End Class
